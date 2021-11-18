using System;
using System.Collections.Generic;

namespace Quản_Lý_Nhân_Sự
{
    class Program
    {       

        static void Main(string[] args)
        {
            QuanLyNhanSu quanLyNhanSu = new QuanLyNhanSu();
            

            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY NHAN VIEN ");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them nhan vien ( nhap : ae)                   **");
                Console.WriteLine("**  2. Them khach hang ( nhap : ac)                  **");
                Console.WriteLine("**  3. Hien thi danh sach nhan vien ( nhap : dae )   **");
                Console.WriteLine("**  4. Hien thi danh sach khach hang ( nhap : dac)   **");
                Console.WriteLine("**  5. Hien thi loai khach hang (nhap : cs )         **");                
                Console.WriteLine("**  0. Thoat (nhap : out)                            **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                string key = Convert.ToString(Console.ReadLine());

                switch (key)
                {
                    case "ae":
                        Console.WriteLine("\nThem nhan vien");
                        quanLyNhanSu.ThemNV();
                        Console.WriteLine("\nThem Thanh Cong !!!");
                        break;
                    case "ac":
                        Console.WriteLine("\nThem khach hang");
                        quanLyNhanSu.ThemKH();
                        Console.WriteLine("\nThem Thanh Cong !!!");
                        break;
                    case "dae":
                        if(quanLyNhanSu.SoLuongNhanVien() > 0)
                        {
                            Console.WriteLine("\nHien thi danh sach nhan vien");
                            quanLyNhanSu.DanhSachNV(quanLyNhanSu.getListNhanVien());
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach nhan vien rong!");
                        }
                        break;
                    case "dac":
                        if(quanLyNhanSu.SoLuongKhachHang() > 0)
                        {
                            Console.WriteLine("\nHien Thi danh sach nhan vien");
                            quanLyNhanSu.DanhsachKH(quanLyNhanSu.getListKhachHang());
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach khach hang rong!");
                        }
                        break;
                    case "cs":
                        Console.WriteLine("Hien thi Thong ke loai khach hang");
                        quanLyNhanSu.ThongKe(quanLyNhanSu.getListKhachHang());
                        break;
                    case "out":
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong MENU.");
                        break;
                }

            }
        }
    }
}
