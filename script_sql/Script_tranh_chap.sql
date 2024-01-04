---Cap nhat thong tin Benh nhan

CREATE OR ALTER PROCEDURE 
sp_updatePatientInfo
@id varchar(20),
@sdt varchar(50), 
@pass varchar(50), @hoten nvarchar(50), 
@ngaysinh varchar(50), 
@diachi nvarchar(100)
AS
BEGIN TRAN
	BEGIN TRY
	IF(@sdt <> (SELECT BNSdt FROM BENHNHAN WHERE MaBN = @id))
	BEGIN
		DECLARE @temp varchar(50)
		SET @temp = (SELECT BNSdt FROM BENHNHAN WHERE MaBN = @id)
		ALTER TABLE BENHNHAN
			NOCHECK CONSTRAINT FK_BN_TK
		
		UPDATE TAIKHOAN SET SDT = @sdt, MATKHAU = @pass WHERE SDT = @temp
		UPDATE BENHNHAN SET BNSdt = @sdt, BNHoten = @hoten, BNNgaysinh = @ngaysinh, BNDiachi = @diachi WHERE MaBN = @id

		ALTER TABLE BENHNHAN
			CHECK CONSTRAINT FK_BN_TK
		COMMIT TRAN
	END
	ELSE
	BEGIN
		UPDATE TAIKHOAN SET MATKHAU = @pass WHERE SDT = @sdt
		UPDATE BENHNHAN SET BNSdt = @sdt, BNHoten = @hoten, BNNgaysinh = @ngaysinh, BNDiachi = @diachi WHERE BNSdt = @sdt
		COMMIT TRAN
	END

	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
GO




