using System;

namespace Geri_Döndürülemeyen_methodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Kisiler ks = new Kisiler();
            string ads;
            Console.Write("İsim Giriniz :  ");
            ads = Console.ReadLine();
            ks.Kisiler1(ads);
            Console.ReadKey();

                
                
                
                

        }
    }
}
