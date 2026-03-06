namespace TestFinal.Test;

[TestFixture]
public class SanPhamServiceTest
{
    private SanPhamService _sanPhamService = null!;
    [SetUp]
    public void Setup()
    {
        _sanPhamService = new SanPhamService();
    }
    // Áp dụng kĩ thuật phân vùng tương đương xóa sản phẩm tồn tại
    // kqmm: Ma = "SP002"
    // kqtt: true
    [Test]
    public void XoaSanPham_MaTonTai_ReturnTrue()
    {
        var result = _sanPhamService.XoaSanPham("SP002");
        Assert.That(result, Is.True);
    }
    // Áp dụng kĩ thuật phân vùng tương đương xóa sản phẩm không tồn tại
    // kqmm: Ma = "SP99"
    // kqtt: true
    [Test]
    public void XoaSanPham_MaKhongTonTai_ReturnFalse()
    {
        var result = _sanPhamService.XoaSanPham("SP99");
        Assert.That(result, Is.False);
    }
    // Áp dụng kĩ thuật biên xóa sản phẩm với mã rỗng
    // kqmm: Ma = ""
    // kqtt: false
    [Test]
    public void XoaSanPham_MaRong_ReturnFalse()
    {
        var result = _sanPhamService.XoaSanPham("");
        Assert.That(result, Is.False);
    }
    //Áp dụng kĩ thuật biên xóa sản phẩm với sản phẩm có giá âm 
    // kqmm: Ma = "SP003", Gia = -1000
    // kqtt: true
    [Test]
    public void XoaSanPham_GiaAm_ReturnTrue()
    {
        var sanPham = new SanPham { Ma = "SP003", Ten = "Sản phẩm mới", NamBaoHanh = 12, Gia = -1000, SoLuong = 5, DanhMuc = "Điện thoại" };
        _sanPhamService.ThemSanPham(sanPham);
        var result = _sanPhamService.XoaSanPham("SP003");
        Assert.That(result, Is.True);
    }
    // Áp dụng kĩ thuật biên xóa sản phẩm với sản phẩm có số lượng âm
    // kqmm: Ma = "SP004", SoLuong = -5
    // kqtt: false
    [Test]
    public void XoaSanPham_SoLuongAm_ReturnTrue()
    {
        var sanPham = new SanPham { Ma = "SP004", Ten = "Sản phẩm mới", NamBaoHanh = 12, Gia = 1000, SoLuong = -5, DanhMuc = "Điện thoại" };
        _sanPhamService.ThemSanPham(sanPham);
        var result = _sanPhamService.XoaSanPham("SP004");
        Assert.That(result, Is.True);
    }
}
      
