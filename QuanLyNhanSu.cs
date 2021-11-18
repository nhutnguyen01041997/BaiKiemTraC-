using System;
using System.Collections.Generic;
using System.Text;

namespace Quản_Lý_Nhân_Sự
{
    class QuanLyNhanSu
    {
        private List<NhanVien> ListNhanVien = null;
        private List<KhachHang> ListKhachHang = null;
        public QuanLyNhanSu()
        {
            ListNhanVien = new List<NhanVien>();
            ListKhachHang = new List<KhachHang>();
        }


        public int SoLuongNhanVien()
        {
            int Count = 0;
            if (ListNhanVien != null)
            {
                Count = ListNhanVien.Count;
            }
            return Count;
        }
        public int SoLuongKhachHang()
        {
            int Count = 0;
            if (ListKhachHang != null)
            {
                Count = ListKhachHang.Count;
            }
            return Count;
        }
        //Hàm thêm nhân viên
        public void ThemNV()
        {
            NhanVien NV = new NhanVien();
            Console.Write("Nhap Ma Nhan Vien : ");
            NV.MaNV = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap Ten Nhan Vien : ");
            NV.TenNV = Console.ReadLine();

            Console.Write("Nhap Gioi Tinh Nhan Vien : ");
            NV.GioiTinh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap Bang Cap Nhan Vien : ");
            NV.BangCap = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap Ngay Sinh Nhan Vien : ");
            NV.Ngaysinh = Convert.ToString(Console.ReadLine());

            ListNhanVien.Add(NV);
        }
        // Hàm nhập Thêm khách hàng
        public void ThemKH()
        {
            KhachHang KH = new KhachHang();
            Console.Write("Nhap Ma Khach Hang : ");
            KH.MaKH = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap ten Khach Hang : ");
            KH.TenKH = Console.ReadLine();

            Console.Write("Nhap Gioi Tinh Khach Hang : ");
            KH.GioiTinh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap Ngay Sinh Khach Hang : ");
            KH.NgaySinh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap Loai Khach Hang : ");
            KH.LoaiKH = Convert.ToString(Console.ReadLine());

            ListKhachHang.Add(KH);
        }
        //Hàm hiển thị ra danh sách nhan viên
        public void DanhSachNV(List<NhanVien> nhanViens)
        {
            // Hiển thị tiêu đề vs cột
            Console.WriteLine("{0,-5} {1, -20} {2, -7} {3, 7} {4, 7} ", "MaNV", "TenNV", "GioiTinh", "BangCap", "NgaySinh");
            //Hiển thị danh sách nhân viên
            if (ListNhanVien != null && ListNhanVien.Count > 0)
            {
                foreach (NhanVien NV in ListNhanVien)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -7} {3, 7} {4, 7}", NV.MaNV, NV.TenNV, NV.GioiTinh, NV.BangCap, NV.Ngaysinh);

                }
                Console.WriteLine();
            }

        }

        

        //Hàm hiển thị danh sách khách hàng
        public void DanhsachKH(List<KhachHang> khachHangs)
        {
            //Hiển thị tiêu đề vs cột
            Console.WriteLine("{0,-5} {1, -20} {2, -7} {3, 7} {4, 7} ", "MaKH", "TenKH", "GioiTinh", "NgaySinh", "LoaiKH");
            //Hiển thị danh sách khách hàng
            if(ListKhachHang != null && ListKhachHang.Count > 0)
            {
                foreach(KhachHang KH in ListKhachHang)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -7} {3, 7} {4, 7}", KH.MaKH, KH.TenKH, KH.GioiTinh, KH.NgaySinh, KH.LoaiKH);
                }
                Console.WriteLine();
            }
        }
        // Hàm trả về danh sách nhân viên hiện tại
        public List<NhanVien> getListNhanVien()
        {
            return ListNhanVien;
        }
        //ham trả về danh sách khách hàng hiện tại
        public List<KhachHang> getListKhachHang()
        {
            return ListKhachHang;
        }
        //Hàm thống kê khách hàng
        public void ThongKe(List<KhachHang> khachHangs)
        {
            int KH_Vip = 0;
            int KH_ThanhVien = 0;
            int KH_Moi = 0;

            foreach (KhachHang kh in ListKhachHang)
            {
                if (kh.LoaiKH == "VIP") { KH_Vip += 1; }
                else if (kh.LoaiKH == "ThanhVien") { KH_ThanhVien += 1; }
                else if (kh.LoaiKH == "Moi") { KH_Moi += 1; }
            }
            Console.WriteLine("\n******Thong Ke so luong khach hang******");
            Console.WriteLine(" So khach hang Vip: {0}", KH_Vip);
            Console.WriteLine(" So khach hang Thanh vien: {0}", KH_ThanhVien);
            Console.WriteLine(" So khach hang Moi: {0}", KH_Moi);
            Console.WriteLine("***************************************\n");
        }
    }
}
