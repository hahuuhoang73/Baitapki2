using System.Collections.Generic;
using T2207A;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello World");
        int x = 10;
        string s = "T2207a";
        double pi = 3.14159;
        if (x > 5)
        {
            x--;
        }
        else
        {
            x++;
        }
        int[] arr = new int[5];
        arr[0] = 1;
        arr[1] = 56;
        arr[2] = 12;
        arr[3] = 2;
        arr[4] = 4;
        
        foreach( int i in arr)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Vui long nhap");
        String cmd = Console.ReadLine();
        Console.WriteLine("Chuoi vua nhap: " + cmd);

        Console.WriteLine("vui long nhap so can kiem tra");
        String cmd2 = Console.ReadLine();
        int n = Convert.ToInt32(cmd2);
        if (isPrimed(n))
        {
            Console.WriteLine(n + "la SNT");
        }

        List<int> ints = new List<int>();
        Class1 cl = new Class1();
        cl.Run();
        cl.Learn();


        //Bai toan phan so
        Phanso ps = new Phanso();
        //Console.WriteLine("Nhap lua chon cua ban:");
        //String cmd3 = Console.ReadLine();
        //int z = Convert.ToInt32(cmd3);
        //switch (z)
        //{
        //  case 1:
        //    ps.Nhap();
        //  break;
        //case 2:
        //  ps.Hienthi();
        //break;

        //}
        ps.Nhap();

        ps.Rutgonphanso();
        ps.Hienthi();
        ps.Ngichdaophanso();
        ps.Hienthi();



    }
    public static bool isPrimed(int n)
    {
        if( n< 2)
        
            return false;
        
        if(n < 4)
        
            return true;
        
        for( int i =2; i< n/2;i++)
        {
            if(n % i==0)
          
                return false;
        }
        return true;

    }
}