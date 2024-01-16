
namespace orderarry;
internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        Console.WriteLine("nhap so phan tu mang:");
        a = Int32.Parse(Console.ReadLine());
        int[] mang = new int[a+1];
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine("Nhap phan tu mang:");
            mang[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Mang co cac phan tu la:");
        for (int i = 0; i < a; i++)
        {
            Console.Write(mang[i]+"\t");
        }
        Console.Write("\n");
        Console.WriteLine("nhap phan tu can chen:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap vi tri chen:");
        int c = int.Parse(Console.ReadLine());
        for (int i = a; i>=c ; i--)
        {
            mang[i]=mang[i-1];
        }
        mang[c-1]=b; //chen phan tu
        for (int i = 0; i <= a; i++)
        {
            Console.Write(mang[i]+"\t");
        }
        Console.WriteLine("ok");
        }
}
