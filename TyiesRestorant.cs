using System;

namespace foodreceipt.huseyin.ali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************************************************************* ");
            Console.WriteLine("************************************************************************************************* ");
            Console.WriteLine("**                                                                                             **");
            Console.WriteLine("**                           Oj Geldiniz Rezdronamıza                                          **");
            Console.WriteLine("**                                                                                             **");
            Console.WriteLine("**                                                                                             **");
            Console.WriteLine("**    Üzeyin Abimizin Baqlavası                 Yemek No:'1'             Fiyat: 45.50tl        **");
            double baqlava = 45.5;                     
            Console.WriteLine("**    Feroş  Abimizin Kürek Pidesi              Yemek No:'2'             Fiyat: 19.99tl        **");
            double pide = 19.99;
            Console.WriteLine("**    Bomba Abimizin İzmir Bombası              Yemek No:'3'             Fiyat: 12.50tl        **");
            double bombe = 12.50;
            Console.WriteLine("**    Mami  Abimizin Alzaymır Çayı              Yemek No:'4'             Fiyat: 4.50tl         **");
            double cay = 4.5;
            Console.WriteLine("**    Şopar Memo  Abimizin Menemeni             Yemek No:'5'             Fiyat: 18.75tl        **");
            double menemen = 18.75;
            Console.WriteLine("**    Pilavcı Bilo  Abimizin Pilavı             Yemek No:'6'             Fiyat: 14.25tl        **");
            double pilav = 14.25;
            Console.WriteLine("**    Karslı Samet  Abimizin Kaşarlı Böreği     Yemek No:'7'             Fiyat: 22.50tl        **");
            double borek = 22.50;
            Console.WriteLine("**                                                                                             **");
            Console.WriteLine("************************************************************************************************* ");
            Console.WriteLine("************************************************************************************************* ");

            Console.WriteLine("Leziz Yemeklerimizden Yer misiniz:'Evet'-'Hayır'");
            string secim = Console.ReadLine();
          
            double ücret = 0;
            if (secim=="Evet")
            {
                donus:
                Console.WriteLine("Lütfen İstediğiniz Yemeğin Yemek Nosunu Yazınz.");
                string secim2 = Console.ReadLine();
               
                if (secim2=="1")
                {
                    Console.WriteLine("Baklavanız Ortalama Olarak 3 Dakika İçinde Geliyor");
                   ücret=ücret + baqlava;        
                }
                if (secim2 == "2")
                {
                    Console.WriteLine("Pideniz Ortalama Olarak 3 Dakika İçinde Geliyor");
                    ücret = ücret + pide;
                }
                if (secim2 == "3")
                {
                    Console.WriteLine("İzmir Bombanız Ortalama Olarak 3 Dakika İçinde Geliyor");
                    ücret = ücret + bombe;
                }
                if (secim2 == "4")
                {
                    Console.WriteLine("Çayınız Ortalama Olarak 3 Dakika İçinde Geliyor");
                    ücret = ücret + cay;
                }
                if (secim2 == "5")
                {
                    Console.WriteLine("Menemeneniz Ortalama Olarak 3 Dakika İçinde Geliyor");
                    ücret = ücret + menemen;
                }
                if (secim2 == "6")
                {
                    Console.WriteLine("Pilavınız Ortalama Olarak 3 Dakika İçinde Geliyor");
                    ücret = ücret + pilav;
                }
                if (secim2 == "7")
                {
                    Console.WriteLine("Böğreğiniz Ortalama Olarak 3 Dakika İçinde Geliyor");
                    ücret = ücret + borek;
                }
                
                Console.WriteLine("Başka Bir Yemek İster Misiniz:'Evet'-'Hayır'");
                string secim3 = Console.ReadLine();
               
                if (secim3 == "Evet")
                {
                    goto donus;
                }
                else
                {
                    Console.WriteLine("Afiyet Olsun");
                    Console.WriteLine("Toplam Ücret:"+ücret);
                }
            }
            else
            {
                Console.WriteLine("Derhal Burayı Terk Et!!!");
            }
               


























Console.ReadKey();
        }
    }
}  
