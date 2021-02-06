using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.BankaHesapNo + " hesap nolu musteri eklendi!");
        }
    
        public void CustomerRemove(Customer customer)
        {
            Console.WriteLine(customer.Id +" numarali musteri silindi!");
        }
    
        public void CustomerUpdate(Customer customer)
        {
            Console.WriteLine(customer.AdSoyad + " isimli musterinin bilgileri guncellendi!");
        }
        public void Listing(Customer[] customers)
        {

            Console.WriteLine("Musterilerin hangi turde sıralanacagını seciniz");
            Console.WriteLine(" \t Id ye gore:1  \n \t Isme gore:2 \n \t Adrese gore:3 \n \t Hesap numarasina gore:4 \n \t Tumu:5");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    foreach (Customer inform in customers)
                    {
                        Console.WriteLine(inform.Id);
                    }
                    break;
                case 2:
                    foreach (Customer inform in customers)
                    {
                        Console.WriteLine(inform.AdSoyad);
                    }
                    break;
                case 3:
                    foreach (Customer inform in customers)
                    {
                        Console.WriteLine(inform.MusteriAdres);
                    }
                    break;
                case 4:
                    foreach (Customer inform in customers)
                    {
                        Console.WriteLine(inform.BankaHesapNo);
                    }
                    break;
                case 5:
                    foreach (Customer inform in customers)
                    {
                        Console.WriteLine(inform.Id + " Id numarali " + inform.AdSoyad +" --->" +
                         " Adresi: " + inform.MusteriAdres + " Banka hesap numarasi: " + inform.BankaHesapNo  );
                    }
                    break;
                default:
                    Console.WriteLine("Hatali giris yaptiniz!");
                    break;
            }
        }
    
    }

}
