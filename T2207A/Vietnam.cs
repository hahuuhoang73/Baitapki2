using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class Vietnam
    {
        public string maKH;
        public string hoTen;
        public DateTime ngayRaDon;
        public string doiTuongKH;
        public double soLuongKW;
        public double donGia;
        public double thanhTien;

        public Vietnam(string maKH, string hoTen, DateTime ngayRaDon, string doiTuongKH, double soLuongKW,double donGia)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.ngayRaDon = ngayRaDon;
            this.doiTuongKH = doiTuongKH;
            this.soLuongKW = soLuongKW;
            this.donGia = donGia;
            TinhThanhTien();
        }
        public void TinhThanhTien()
        {
            double dinhMuc = 0;
            switch (doiTuongKH)
            {
                case "sinh hoat":
                    dinhMuc = 50;
                    break;
                case "kinh doanh":
                    dinhMuc = 100;
                    break;
                case "san xuat":
                    dinhMuc = 200;
                    break;
                default:
                    break;
            }

            if (soLuongKW <= dinhMuc)
            {
                thanhTien = soLuongKW * donGia;
            }
            else
            {
                double giaVuotDinhMuc = 0;
                if (soLuongKW > dinhMuc && soLuongKW <= 50)
                {
                    giaVuotDinhMuc = 1000;
                }
                else if (soLuongKW > 50 && soLuongKW <= 100)
                {
                    giaVuotDinhMuc = 1200;
                }
                else if (soLuongKW > 100 && soLuongKW <= 200)
                {
                    giaVuotDinhMuc = 1500;
                }
                else if (soLuongKW > 200)
                {
                    giaVuotDinhMuc = 2000;
                }
                thanhTien = dinhMuc * donGia + (soLuongKW - dinhMuc) * giaVuotDinhMuc;
            }
        }
        public void Hienthi()
        {
            Console.WriteLine(maKH+"---"+hoTen+"----"+ngayRaDon+"____"+doiTuongKH+"----"+soLuongKW+"------"+donGia+"----"+thanhTien);
        }
    }
    }


