using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id=101,AdSoyad="Rana Yalcin",MusteriAdres="Istanbul",BankaHesapNo=20120047 };
            Customer customer2 = new Customer() { Id = 102, AdSoyad = "Ali Unsal", MusteriAdres = "Istanbul", BankaHesapNo = 23018004 };
            Customer customer3 = new Customer() { Id = 103, AdSoyad = "Yavuz Eroglu", MusteriAdres = "Almanya", BankaHesapNo = 23920048 };
            Customer customer4 = new Customer() { Id = 104, AdSoyad = "Zehra Hekimoglu", MusteriAdres = "Ankara", BankaHesapNo = 20194646 };
            Customer customer5 = new Customer() { Id = 105, AdSoyad = "Gizem Kılıc", MusteriAdres = "Malatya", BankaHesapNo = 25120015 };

            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4,customer5 };

            Console.WriteLine("<<<<<Musteriler ekleniyor>>>>>");
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerAdd(customer2);
            customerManager.CustomerAdd(customer3);
            customerManager.CustomerAdd(customer4);
            customerManager.CustomerAdd(customer5);
           
            Console.WriteLine();

            customerManager.Listing(customers); //Hangi bilgilere gore musterileri siralamak istiyorsak ona gore listeler.
            
            Console.WriteLine();
            
            Console.WriteLine("103 Id numarali  Yavuz Eroglu isimli musterinin adres bilgilerinde degisiklik var!");
            customerManager.CustomerUpdate(customer3);

            Console.WriteLine();

            Console.WriteLine("201200047 numarali hesap kapatildi! ");
            customerManager.CustomerRemove(customer1);
            Console.ReadKey();

        }
    }
}
