using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class Phanso
    {
        public int tuso;
        public int mauso;

        public Phanso()
        {
            tuso = 0;
            mauso = 1;
        }

        public Phanso(int ts,int ms)
        {
            this.tuso = ts;
            this.mauso = ms;
        }
        //nhập phân số
        public void Nhap()
        {
            do
            {
                Console.WriteLine("NHap tu so :");
                String x = Console.ReadLine();
                tuso = Convert.ToInt32(x);

                Console.WriteLine("Nhap mau so :");
                String y = Console.ReadLine();
                mauso = Convert.ToInt32(y);
                if (mauso != 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ban da nhap sai dinh dang hoac mau so bang 0. Vui long nhap lai!");
                }
            } while (true);
            
        }
        //in phân số
        public void Hienthi()
        {
            Console.WriteLine(tuso + "/" + mauso);
        }
        //tìm UCLN
        public int Ucln(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0) return a + b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        //rút gọn phân số
        public void Rutgonphanso()
        {
            int ucln = Ucln(tuso, mauso);
            tuso = tuso / ucln;
            mauso = mauso / ucln;
        }

        //Ngịch đảo phân số

        public void Ngichdaophanso()
        {
            int temp = tuso;
            tuso = mauso;
            mauso = temp;
            
        }

        //tổng

        public Phanso Cong(Phanso psnew)
        {
            int ts = tuso * psnew.mauso + psnew.tuso * mauso;
            int ms = mauso * psnew.mauso;
            return new Phanso(ts, ms);
        }

        //trừ 
        public Phanso Tru(Phanso psnew)
        {
            int ts = tuso * psnew.mauso - psnew.tuso * mauso;
            int ms = mauso * psnew.mauso;
            return new Phanso(ts, ms);
        }

        //Nhân 
        public Phanso Nhan(Phanso psnew)
        {
            int ts = tuso * psnew.tuso;
            int ms = mauso * psnew.mauso;
            return new Phanso(ts, ms);
        }
        //Chia

        public Phanso Chia(Phanso psnew)
        {
            int ts = tuso * psnew.mauso;
            int ms = mauso * psnew.tuso;
            return new Phanso(ts, ms);
        }

        public String Tosing()
        {
            return tuso + "/" + mauso;
        }

    }
}
