using System.Collections.Generic;
using T2207A;

public class Program
{
    public static void Main(String[] args)
    {
        // Console.WriteLine("Hello World");
        // int x = 10;
        // string s = "T2207a";
        // double pi = 3.14159;
        // if (x > 5)
        // {
        //     x--;
        // }
        //  else
        //  {
        //    x++;
        //  }
        // int[] arr = new int[5];
        //  arr[0] = 1;
        //  arr[1] = 56;
        //  arr[2] = 12;
        //  arr[3] = 2;
        // arr[4] = 4;

        // foreach( int i in arr)
        // {
        //     Console.WriteLine(i);
        // }
        //  Console.WriteLine("Vui long nhap");
        //  String cmd = Console.ReadLine();
        //  Console.WriteLine("Chuoi vua nhap: " + cmd);

        //  Console.WriteLine("vui long nhap so can kiem tra");
        //  String cmd2 = Console.ReadLine();
        // int n = Convert.ToInt32(cmd2);
        //  if (isPrimed(n))
        // {
        //     Console.WriteLine(n + "la SNT");
        //  }

        //  List<int> ints = new List<int>();
        // Class1 cl = new Class1();
        //  cl.Run();
        //  cl.Learn();
        // cl.Learnn("abc");
        //cl.Name = "Nguyen van an";


        //Bai toan phan so
        //Phanso ps = new Phanso();
        //ps.Nhap();
        //Console.WriteLine("Phan so vua nhap la:");
        //ps.Hienthi();
        //Console.WriteLine("Hay nhap phan so muon thuc hienj phep toan:");
        //Phanso psnew = new Phanso();
        //psnew.Nhap();

        //Giai quyet bai toan 
        //Console.WriteLine("tONG HAI PHAN SO LA");
        //Phanso tong = ps.Cong(psnew);
        //tong.Rutgonphanso();
        //tong.Hienthi();

        //Console.WriteLine("TRU HAI PHAN SO LA");
        //Phanso tru = ps.Tru(psnew);
        //tru.Rutgonphanso();
        //tru.Hienthi();

        //Console.WriteLine("NHAN HAI PHAN SO LA");
        //Phanso nhan = ps.Nhan(psnew);
        //nhan.Rutgonphanso();
        //nhan.Hienthi();

        //Console.WriteLine("CHIA HAI PHAN SO LA");
        //Phanso chia = ps.Cong(psnew);
        //chia.Rutgonphanso();
        //chia.Hienthi();




        //  Vietnam vn = new Vietnam("K123","Ha Huu Hoang", new DateTime(2023, 4, 14), "kinh doanh",61,50);

        // vn.Hienthi();
        Phone phonebook = new PhoneBoock();
        phonebook.insertPhone("John", "123456789");
        phonebook.insertPhone("Jane", "987654321");
        phonebook.SearchPhone("John");
        phonebook.UpdatePhone("Jane", "111111111");
        phonebook.RemovePhone("John");
        phonebook.Sort();





    }
   
   
}