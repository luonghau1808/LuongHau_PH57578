namespace TestFinal
{
    public class SanPhamService
    {
        private List<SanPham> _listSanPham = new List<SanPham>()
        {
            new SanPham{Ma = "SP001", Ten = "Điện thoại Samsung Galaxy S21", NamBaoHanh = 24, Gia = 19990000, SoLuong = 10, DanhMuc = "Điện thoại"},
            new SanPham{Ma = "SP002", Ten = "Laptop Dell XPS 13", NamBaoHanh = 12, Gia = 29990000, SoLuong = 5, DanhMuc = "Laptop"} 
        };

        public void ThemSanPham(SanPham sanPham)
        {
            _listSanPham.Add(sanPham);
        }
        public void KiemTraMaTonTai(string ma)
        {
            var sanPham = _listSanPham.FirstOrDefault(sp => sp.Ma == ma);
            if (sanPham != null)
            {
                throw new Exception("Mã sản phẩm đã tồn tại");
            }
        }


        public bool XoaSanPham(string ma)
        {
            var sanPham = _listSanPham.FirstOrDefault(sp => sp.Ma == ma);

            if (sanPham != null)
            {
                _listSanPham.Remove(sanPham);
                return true;
            }
            
            if (sanPham != null && sanPham.SoLuong < 0) { return true; }
            if (sanPham != null && sanPham.NamBaoHanh < 0) { return true; }
            if (sanPham != null && sanPham.Gia < 0) { return true; }
            return false;
         
        }
        public SanPham? GetByMa(string ma)
        {
            return _listSanPham.FirstOrDefault(sp => sp.Ma == ma);
        }








        }
}
