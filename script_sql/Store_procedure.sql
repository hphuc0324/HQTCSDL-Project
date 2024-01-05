--Tim ma theo sdt
CREATE PROCEDURE sp_findID @sdt varchar(50), @type varchar(5), @id varchar(20) OUTPUT
AS
BEGIN
	IF(NOT EXISTS(SELECT * FROM TAIKHOAN T WHERE T.SDT = @sdt))
		RETURN 0

	IF(@type = 'BN')
		SELECT @id = B.MaBN FROM BENHNHAN B WHERE B.BNSdt = @sdt		
	ELSE IF(@type = 'NS')
		SELECT @id = NS.MaNS FROM NHASI NS WHERE NS.NSSdt = @sdt
	ELSE IF(@type = 'NV')
		SELECT @id = NV.NVSdt FROM NHANVIEN NV WHERE NV.NVSdt = @sdt	
	ELSE
		SELECT @id = QTV.MaQTV FROM QUANTRIVIEN QTV WHERE QTV.QTVSdt = @sdt

	RETURN 1
END
GO

--Check login
CREATE PROCEDURE sp_checkLogin @sdt varchar(50), @pass varchar(50), @type varchar(5) OUTPUT, @id varchar(20) OUTPUT
AS
BEGIN
	IF(NOT EXISTS(SELECT * FROM TAIKHOAN T WHERE T.SDT = @sdt AND T.MATKHAU = @pass))
	BEGIN
		SET @type = NULL;
		RETURN 0;
	END
	ELSE
	BEGIN
		SELECT @type = T.LOAITAIKHOAN FROM TAIKHOAN T WHERE T.SDT = @sdt AND T.MATKHAU = @pass 
		EXEC sp_findID @sdt, @pass, @id
		RETURN 1
	END
END
GO

--Dang ky
CREATE PROCEDURE sp_register @sdt varchar(50), @pass varchar(50), @mabn varchar(20), @hoten nvarchar(50), @ngaysinh date, @diachi nvarchar(100)
AS
BEGIN
	IF(EXISTS(SELECT * FROM TAIKHOAN T WHERE T.SDT = @sdt))
		RETURN 0;
	
	INSERT INTO TAIKHOAN
	VALUES
	(@sdt, @pass, 'BN')

	INSERT INTO BENHNHAN(MaBN, BNSdt, BNHoten, BNNgaysinh, BNDiachi)
	VALUES
	(@mabn, @sdt, @hoten, @ngaysinh, @diachi)

	--TAO LOGIN
	--ADD ROLE
	RETURN 1;
END
GO


---Them dich vu vao ho so
CREATE OR ALTER PROCEDURE sp_addTreating
@maHS varchar(20), @maDV varchar(20)
AS
BEGIN
	IF(EXISTS(SELECT * FROM HOSO_DICHVU WHERE MaHSKham = @maHS AND MaDVSuDung = @maDV))
		RETURN
	ELSE
	BEGIN
		INSERT INTO HOSO_DICHVU
		VALUES(@maHS, @maDV)
	END	
END
GO

--Xoa dich vu khoi ho so
CREATE OR ALTER PROCEDURE sp_delTreating
@maHS varchar(20), @maDV varchar(20)
AS 
BEGIN
	IF(NOT EXISTS(SELECT * FROM HOSO_DICHVU WHERE MaHSKham = @maHS AND MaDVSuDung = @maDV))
		RETURN
	ELSE
		DELETE FROM HOSO_DICHVU WHERE MaHSKham = @maHS AND MaDVSuDung = @maDV
END
GO

--Them don thuoc
CREATE OR ALTER PROCEDURE sp_addTreatingMed
@maHS varchar(20), @maThuoc varchar(20), @soluong INT
AS 
BEGIN
	IF(EXISTS(SELECT * FROM HOSO_THUOC WHERE MaHSKham = @maHS AND MaThuocChiDinh = @maThuoc))
		RETURN
	ELSE
	INSERT INTO HOSO_THUOC
	VALUES
	(@maHS, @maThuoc, @soluong)
END
GO

--Update don thuoc
CREATE OR ALTER PROCEDURE sp_updateTreatingMed
@maHS varchar(20), @maThuoc varchar(20), @soluong INT
AS 
BEGIN
	IF(NOT EXISTS(SELECT * FROM HOSO_THUOC WHERE MaHSKham = @maHS AND MaThuocChiDinh = @maThuoc))
		RETURN
	ELSE
	UPDATE HOSO_THUOC SET SoLuong = @soluong WHERE MaHSKham = @maHS AND MaThuocChiDinh = @maThuoc
END
GO


--Xoa don thuoc
CREATE OR ALTER PROCEDURE sp_delTreatingMed
@maHS varchar(20), @maThuoc varchar(20)
AS 
BEGIN
	IF(NOT EXISTS(SELECT * FROM HOSO_THUOC WHERE MaHSKham = @maHS AND MaThuocChiDinh = @maThuoc))
		RETURN
	ELSE
	DELETE FROM HOSO_THUOC WHERE MaHSKham = @maHS AND MaThuocChiDinh = @maThuoc 
END
GO







