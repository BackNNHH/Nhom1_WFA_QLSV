-- Thêm 48 sinh viên mới vào bảng SinhVien

-- Khai báo biến để theo dõi số lượng sinh viên đã thêm
DECLARE @Counter INT = 3; -- Bắt đầu từ 3 vì đã có SV001 và SV002

-- Vòng lặp để thêm 48 sinh viên
WHILE @Counter <= 50
BEGIN
    -- Khai báo các biến cục bộ để lưu trữ dữ liệu sinh viên
    DECLARE @MaSV CHAR(10);
    DECLARE @HoTen NVARCHAR(100);
    DECLARE @NgaySinh DATE;
    DECLARE @GioiTinh NVARCHAR(10);
    DECLARE @DiaChi NVARCHAR(255);
    DECLARE @Email NVARCHAR(100);
    DECLARE @SoDienThoai CHAR(10);
    DECLARE @MaLop CHAR(10);

    -- Tạo MaSV (Ví dụ: SV003, SV004, ..., SV050)
    SET @MaSV = 'SV' + RIGHT('00' + CAST(@Counter AS VARCHAR(2)), 3);

    -- Tạo HoTen (Ví dụ: Sinh Viên 3, Sinh Viên 4, ...)
    SET @HoTen = 'Sinh Viên ' + CAST(@Counter AS NVARCHAR(10));

    -- Tạo NgaySinh (Ngày ngẫu nhiên trong khoảng 2000-01-01 đến 2005-12-31)
    SET @NgaySinh = DATEADD(day, ABS(CHECKSUM(NEWID())) % 2192, '2000-01-01');

    -- Tạo GioiTinh (50% Nam, 50% Nữ)
    IF (ABS(CHECKSUM(NEWID())) % 2) = 0
        SET @GioiTinh = N'Nam';
    ELSE
        SET @GioiTinh = N'Nữ';

    -- Tạo DiaChi (Địa chỉ ngẫu nhiên)
    SET @DiaChi = N'Địa chỉ ' + CAST(@Counter AS NVARCHAR(10));

    -- Tạo Email (email ngẫu nhiên)
    SET @Email = 'sv' + CAST(@Counter AS NVARCHAR(10)) + '@example.com';

    -- Tạo SoDienThoai (Số điện thoại ngẫu nhiên, đảm bảo không trùng lặp)
    SET @SoDienThoai = '0' + CAST(ABS(CHECKSUM(NEWID())) % 900000000 + 100000000 AS VARCHAR(10));

    -- Tạo MaLop (Chọn ngẫu nhiên một MaLop đã tồn tại trong bảng LopHoc)
    -- Lấy MaLop ngẫu nhiên từ bảng LopHoc
    SELECT TOP 1 @MaLop = MaLop
    FROM LopHoc
    ORDER BY NEWID();


    -- Thêm sinh viên vào bảng SinhVien
    BEGIN TRY
        INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SoDienThoai, MaLop)
        VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Email, @SoDienThoai, @MaLop);

        -- Tăng bộ đếm
        SET @Counter = @Counter + 1;
    END TRY
    BEGIN CATCH
         --Xử lý lỗi nếu UNIQUE constraint bị vi phạm. In ra lỗi và bỏ qua sinh viên này.
        PRINT 'Lỗi khi chèn sinh viên ' + @MaSV + ': ' + ERROR_MESSAGE();
        SET @Counter = @Counter + 1; -- Vẫn tăng counter để tiếp tục vòng lặp
    END CATCH

END
GO

-- Kiểm tra số lượng sinh viên đã thêm
SELECT COUNT(*) AS SoLuongSinhVien FROM SinhVien;