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





