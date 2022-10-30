Public Class AppDataDefs

    Public Class gv_Data_InPhieu_THUCHI
        Public Property mGroup As String
        Public Property SoChungTu As String
        Public Property SoThamChieu As String
        Public Property Copy As Integer
        Public Property CopyName As String
        Public Property RefNum As String
        Public Property NgayCTu As Date
        Public Property MaDoiTuong As String
        Public Property TenDoiTuong As String
        Public Property DiaChiDoiTuong As String
        Public Property GhiChu As String
        Public Property SoTien As String
    End Class

    Public Class gv_Data_BangKe_THUCHI
        Public Property ID As Integer
        Public Property SoChungTu As String
        Public Property NgayCTu As Date
        Public Property SoThamChieu As String
        Public Property HangMuc As String
        Public Property TenHangMuc As String
        Public Property MaDoiTuong As String
        Public Property TenDoiTuong As String
        Public Property DiaChi As String
        Public Property SoTien As Double
        Public Property GhiChu As String
    End Class

    Public Class gv_Data_ChiTietCongNo_Phieu
        Public Property MaDoiTuong As String
        Public Property TenDoiTuong As String
        Public Property DiaChiDoiTuong As String

        Public Property NgayCTu As Date
        Public Property SapXep As Integer
        Public Property SoChungTu As String
        Public Property GhiChu As String
        Public Property PhatSinhNo As Double
        Public Property ThanhToan As Double

        Public Property SoDuDK As Double
        Public Property SoDuCK As Double
        Public Property TongSoDuDK As Double
        Public Property TongSoDuCK As Double
    End Class

    Public Class gv_Data_ChiTietCongNo_HangHoa
        Public Property MaDoiTuong As String
        Public Property TenDoiTuong As String
        Public Property DiaChiDoiTuong As String

        Public Property NgayCTu As Date
        Public Property SapXep As Integer
        Public Property SoChungTu As String
        Public Property Dong As Integer
        Public Property MaHang As String
        Public Property TenHang As String
        Public Property SoLuong As Double
        Public Property DonGia As Double
        Public Property TienHang As Double
        Public Property TienThue As Double
        Public Property ThanhTien As Double
        Public Property TyLeCKTT As Double
        Public Property TienCKTT As Double
        Public Property PhatSinhNo As Double
        Public Property ThanhToan As Double

        Public Property SoDuDK As Double
        Public Property SoDuCK As Double
        Public Property TongSoDuDK As Double
        Public Property TongSoDuCK As Double
    End Class

    Public Class gv_Data_TongHopCongNo
        Public Property MaDoiTuong As String
        Public Property TenDoiTuong As String
        Public Property DiaChiDoiTuong As String
        Public Property SoDuDK As Double
        Public Property PhatSinhNo As Double
        Public Property ThanhToan As Double
        Public Property SoDuCK As Double
    End Class

    Public Class gv_Data_SoQuyTienMat
        Public Property NgayCTu As Date
        Public Property SapXep As Integer
        Public Property SoChungTu As String
        Public Property DienGiaiNghiepVu As String
        Public Property SoDuDK As Double
        Public Property TienThu As Double
        Public Property TienChi As Double
        Public Property TienTon As Double
        Public Property TongTienThu As Double
        Public Property TongTienChi As Double
        Public Property SoDuCK As Double
    End Class

    Public Class gv_Data_InPhieu_HangHoaDauVaoDauRa
        Public Property NhomTrang As String
        Public Property SoLienIn As Integer
        Public Property TenLienIn As String
        Public Property DienGiaiLienIn As String

        Public Property SoChungTu As String
        Public Property NgayCTu As Date
        Public Property MaDoiTuong As String
        Public Property TenDoiTuong As String
        Public Property DiaChi As String
        Public Property GhiChu As String

        Public Property Dong As Integer
        Public Property MaHang As String
        Public Property TenHang As String
        Public Property DVT As String
        Public Property SoLuong As Double
        Public Property DonGia As Double
        Public Property TienHang As Double
        Public Property TyLeThue As Double
        Public Property TienThue As Double
        Public Property ThanhTien As Double
        Public Property TyLeCKTT As Double
        Public Property TienCKTT As Double
        Public Property TongCong As Double

        Public Property TongNoDau As Double
        Public Property TongNoPS As Double
        Public Property TongTraPS As Double
        Public Property TongNoCuoi As Double
    End Class

    'Public Class gv_Data_InPhieu_HangHoaDauRa
    '    Public Property NhomTrang As String
    '    Public Property SoLienIn As Integer
    '    Public Property TenLienIn As String
    '    Public Property DienGiaiLienIn As String

    '    Public Property SoChungTu As String
    '    Public Property NgayCTu As Date
    '    Public Property MaDoiTuong As String
    '    Public Property TenDoiTuong As String
    '    Public Property DiaChi As String
    '    Public Property GhiChu As String

    '    Public Property Dong As Integer
    '    Public Property MaHang As String
    '    Public Property TenHang As String
    '    Public Property DVT As String
    '    Public Property SoLuong As Double
    '    Public Property DonGia As Double
    '    Public Property TienHang As Double
    '    Public Property TyLeThue As Double
    '    Public Property TienThue As Double
    '    Public Property ThanhTien As Double
    '    Public Property TyLeCKTT As Double
    '    Public Property TienCKTT As Double
    '    Public Property TongCong As Double

    '    Public Property TongNoDau As Double
    '    Public Property TongNoPS As Double
    '    Public Property TongNoCuoi As Double
    'End Class

    Public Class gv_Data_BangKe_HangHoaDauVaoDauRa
        Public Property MaDoiTuong As String
        Public Property TenDoiTuong As String
        Public Property DiaChi As String

        Public Property SoChungTu As String
        Public Property NgayCTu As Date
        Public Property GhiChu As String
        Public Property Dong As Integer
        Public Property MaHang As String
        Public Property TenHang As String
        Public Property DVT As String

        Public Property SoLuong As Double
        Public Property DonGia As Double
        Public Property TienHang As Double
        Public Property TyLeThue As Double
        Public Property TienThue As Double
        Public Property ThanhTien As Double
        Public Property TyLeCKTT As Double
        Public Property TienCKTT As Double
        Public Property TongCong As Double

        Public Property NhomHang As String
        Public Property TenNhomHang As String
    End Class

    Public Class gv_Data_InPhieu_HangHoaTrongKho
        Public Property NhomTrang As String
        Public Property SoLienIn As Integer
        Public Property TenLienIn As String
        Public Property DienGiaiLienIn As String

        Public Property SoChungTu As String
        Public Property NgayCTu As Date
        Public Property SoThamChieu As String
        Public Property MaThamChieu As String
        Public Property ThongTinThamChieu As String
        Public Property LyDoNhapXuat As String
        Public Property KhoChinh As String
        Public Property KhoThamChieu As String
        Public Property GhiChu As String

        Public Property Dong As Integer
        Public Property MaHang As String
        Public Property TenHang As String
        Public Property DVT As String
        Public Property SoLuong As Double
        Public Property DonGiaKho As Double
        Public Property TriGiaKho As Double
    End Class

    Public Class gv_Data_InPhieu_HangHoaLapRap
        Public Property NhomTrang As String
        Public Property SoLienIn As Integer
        Public Property TenLienIn As String
        Public Property DienGiaiLienIn As String

        Public Property SoChungTu As String
        Public Property NgayCTu As Date
        Public Property KhoChinh As String
        Public Property GhiChu As String

        Public Property Dong As Integer
        Public Property MaHang As String
        Public Property TenHang As String
        Public Property DVT As String
        Public Property SoLuong As Double
        Public Property DonGiaKho As Double
        Public Property TriGiaKho As Double

        Public Property Dong_CT As Integer
        Public Property MaHang_CT As String
        Public Property TenHang_CT As String
        Public Property DVT_CT As String
        Public Property SoLuong_CT As Double
        Public Property DonGiaKho_CT As Double
        Public Property TriGiaKho_CT As Double

        Public Property TongSoLuong As Double
        Public Property TongTriGiaKho As Double
    End Class

    Public Class gv_Data_BangKe_HangHoaTrongKho
        Public Property SoThamChieu As String
        Public Property MaKho As String
        Public Property ThongTinKho As String
        Public Property MaKhoThamChieu As String
        Public Property ThongTinKhoThamChieu As String

        Public Property SoChungTu As String
        Public Property NgayCTu As Date
        Public Property GhiChu As String
        Public Property Dong As Integer
        Public Property MaHang As String
        Public Property TenHang As String
        Public Property DVT As String

        Public Property SoLuong As Double
        Public Property DonGiaKho As Double
        Public Property TriGiaKho As Double

        Public Property NhomHang As String
        Public Property TenNhomHang As String
        Public Property LoaiHang As String
        Public Property TenLoaiHang As String
    End Class

    Public Class gv_Data_CanDoiNXT
        Public Property MaKho As String
        Public Property TenKho As String

        Public Property NhomDuLieuAm As Integer
        Public Property NhomHang As String
        Public Property TenNhomHang As String
        Public Property MaHang As String
        Public Property TenHang As String
        Public Property DVT As String

        Public Property SoLuongTonDK As Double
        Public Property TriGiaTonDK As Double
        Public Property SoLuongNhap As Double
        Public Property TriGiaNhap As Double
        Public Property SoLuongXuat As Double
        Public Property TriGiaXuat As Double
        Public Property SoLuongTonCK As Double
        Public Property TriGiaTonCK As Double
    End Class

    Public Class gv_Data_TheKho
        Public Property PhanNhom As String

        Public Property MaKho As String
        Public Property TenKho As String

        Public Property SapXep As Integer
        Public Property SoChungTu As String
        Public Property NgayCTu As String
        Public Property MaHang As String
        Public Property TenHang As String
        Public Property DVT As String
        Public Property GhiChu As String

        Public Property SoLuongTonDK As Double
        Public Property TriGiaTonDK As Double
        Public Property SoLuongNhap As Double
        Public Property TriGiaNhap As Double
        Public Property SoLuongXuat As Double
        Public Property TriGiaXuat As Double
        Public Property SoLuongTonCK As Double
        Public Property TriGiaTonCK As Double
    End Class

    Public Class gv_Data_TonKho
        Public Property MaKho As String
        Public Property TenKho As String

        Public Property NhomDuLieuAm As Integer
        Public Property DienGiaiSapXep As String
        Public Property NhomHang As String
        Public Property TenNhomHang As String
        Public Property MaHang As String
        Public Property TenHang As String
        Public Property DVT As String

        Public Property SoLuongTon As Double
        Public Property TriGiaTon As Double
    End Class

    Public Class gv_Data_BangGia
        Public Property NhomGia As String
        Public Property TenNhomGia As String
        Public Property GhiChu As String

        Public Property MaHang As String
        Public Property TenHang As String
        Public Property DVT As String

        Public Property DonGia As Double
        Public Property CoThue As Boolean
        Public Property TyLeThue As Double
    End Class

    Public Class gv_Data_MaVach
        Public Property MaHang1 As String
        Public Property TenHang1 As String
        Public Property DVT1 As String
        Public Property MaVach1 As String
        Public Property DonGia1 As Double

        Public Property MaHang2 As String
        Public Property TenHang2 As String
        Public Property DVT2 As String
        Public Property MaVach2 As String
        Public Property DonGia2 As Double

        Public Property MaHang3 As String
        Public Property TenHang3 As String
        Public Property DVT3 As String
        Public Property MaVach3 As String
        Public Property DonGia3 As Double
    End Class

    Public Class gv_Data_LaiLo
        Public Property DoiTuong As String
        Public Property TenDoiTuong As String
        Public Property MaHang As String
        Public Property TenHang As String
        Public Property DVT As String

        Public Property DoanhSo As Double
        Public Property GiaVon As Double
        Public Property TienLai As Double
        Public Property TienLo As Double
    End Class

    Public Class gv_Data_LaiLo_TheoKho
        Public Property MaKho As String
        Public Property TenKho As String
        Public Property DoiTuong As String
        Public Property TenDoiTuong As String
        Public Property MaHang As String
        Public Property TenHang As String
        Public Property DVT As String

        Public Property DoanhSo As Double
        Public Property GiaVon As Double
        Public Property TienLai As Double
        Public Property TienLo As Double
    End Class

End Class
