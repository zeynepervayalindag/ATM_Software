using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kartla giriş yapmak için kartınızı yerleştiriniz");

            int i = 0, kartsifresi = 0797, miktar1, miktar2, miktar3, miktar4; ;
            double bakiye = 27987.7D;
            do
            {
                Console.WriteLine("Sayın ZEYNEP ERVA YALINDAĞ");
                Console.WriteLine("Lütfen Kart Şifrenizi Giriniz");
                kartsifresi = Convert.ToInt32(Console.ReadLine());
                if (kartsifresi == 0797)
                {
                    Console.WriteLine("Şifre Güvenliğiniz İle İlgili Uyarılar");
                    Console.WriteLine("Şifrenizi Albaraka personeli dahil kimse ile paylaşmayınız");
                    Console.WriteLine("Aynı rakamları içeren veya ardışık rakamlardan oluşan şifre kullanmayınız");
                    Console.WriteLine("Şifrenizi hiçbir yere yazmayınız");
                    Console.WriteLine("Kartınızın sıkışması durumunda, 444 5 666 arayıp kartınızı kullanıma kapatınız");
                    Console.WriteLine("LÜTFEN DİKKAT");
                    Console.WriteLine("Kendini Polis,Asker,Hakim,Savcı vb. şekilde tanıtarak sizden para talep eden kişilere inanmayınız.Tanımadığınız kişiler tarafından telefonla aranarak T.C. Kimlik No veya Telefon hattına para yatırılması taleplerine itibar etmeyiniz.Bu ve benzeri durumlarda 155 Polis İmdat Hattını arayınız.Dolandırılıyor olabilirsiniz.");
                    break;
                }
                else
                {
                    Console.WriteLine("Şifreniz yanlış.Lütfen şifrenizi doğru giriniz.");
                }
                i++;
            } while (i < 3);

            if (i >= 3)
            {
                Console.WriteLine("Kartınız bloke olmuştur.");
            }
            else
            {
                string islem1;
                Console.WriteLine("Lütfen İşlem Yapmak İçin Giriş Yapınız");
                islem1 = Convert.ToString(Console.ReadLine());
                switch (islem1)
                {
                    case "paracekme":
                        Console.WriteLine("Çekmek istediğiniz miktarı giriniz:");
                        miktar1 = Convert.ToInt32(Console.ReadLine());
                        if (miktar1 > bakiye)
                        {
                            Console.WriteLine("Çekeceğiniz miktar bakiyenizden büyüktür.Çekmek istediğiniz miktarı tekrar giriniz:");
                            miktar1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Bakiyeniz:{0}", bakiye - miktar1);
                        }
                        else if (miktar1 > 5000)
                        {
                            Console.WriteLine("Günlük para çekme limiti 5000 TL'dir.Çekmek istediğiniz miktarı tekrar giriniz:");
                            miktar1 = Convert.ToInt32(Console.ReadLine());
                            if (miktar1 % 5 != 0)
                            {
                                Console.WriteLine("5 ve katları şeklinde para çekebilirsiniz.Çekmek istediğiniz miktarı tekrar giriniz:");
                                miktar1 = Convert.ToInt32(Console.ReadLine());
                            }
                            else if (miktar1 > bakiye)
                            {
                                Console.WriteLine("Çekeceğiniz miktar bakiyenizden büyüktür.Çekmek istediğiniz miktarı tekrar giriniz:");
                                miktar1 = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("Bakiyeniz:{0}", bakiye - miktar1);
                        }
                        else if (miktar1 % 5 != 0)
                        {
                            Console.WriteLine("5 ve katları şeklinde para çekebilirsiniz.Çekmek istediğiniz miktarı tekrar giriniz:");
                            miktar1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Bakiyeniz:{0}", bakiye - miktar1);
                        }
                        else
                        {
                            Console.WriteLine("Bakiyeniz:{0}", bakiye - miktar1);
                        }
                        break;
                    case "parayatırma":
                        Console.WriteLine("Yatırmak istediğiniz miktarı giriniz:");
                        miktar2 = Convert.ToInt32(Console.ReadLine());
                        if (miktar2 > 20000)
                        {
                            Console.WriteLine("Günlük para yatırma limiti 20000 TL'dir.Yatırmak istediğiniz miktarı tekrar giriniz:");
                            miktar2 = Convert.ToInt32(Console.ReadLine());
                            if (miktar2 % 5 != 0)
                            {
                                Console.WriteLine("5 ve katları şeklinde para çekebilirsiniz.Yatırmak istediğiniz miktarı tekrar giriniz:");
                                miktar2 = Convert.ToInt32(Console.ReadLine());
                            }
                            else if (miktar2 > bakiye)
                            {
                                Console.WriteLine("Çekeceğiniz miktar bakiyenizden büyüktür.Yatırmak istediğiniz miktarı tekrar giriniz:");
                                miktar2 = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("Bakiyeniz:{0}", bakiye + miktar2);
                        }
                        else if (miktar2 % 5 != 0)
                        {
                            Console.WriteLine("5 ve katları şeklinde para yatırabilirsiniz.Yatırmak istediğiniz miktarı tekrar giriniz:");
                            miktar2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Bakiyeniz:{0}", bakiye + miktar2);
                        }
                        else
                        {
                            Console.WriteLine("Bakiyeniz:{0}", bakiye + miktar2);
                        }
                        break;
                    case "bakiyesorgulama":
                        Console.WriteLine("Bakiyeniz:{0}", bakiye);
                        break;
                }
                string islem2, cevap1, cevap2, cevap3;

                Console.WriteLine("Başka Bir İşlem Yapmak İstiyor Musunuz?");
                cevap1 = Convert.ToString(Console.ReadLine());
                if (cevap1 == "Hayır")
                {
                    Console.WriteLine("İşleminizin sonunda fiş istiyor musunuz?");
                    cevap2 = Convert.ToString(Console.ReadLine());
                    if (cevap2 == "Hayır")
                    {
                        Console.WriteLine("Lütfen kartınızı kontrol ederek alınız.");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen kartınızı ve fişinizi kontrol ederek alınız.");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen İşlem Yapmak İçin Giriş Yapınız");
                    islem2 = Convert.ToString(Console.ReadLine());

                    switch (islem2)
                    {
                        case "paracekme2":
                            Console.WriteLine("Çekmek istediğiniz miktarı giriniz:");
                            miktar3 = Convert.ToInt32(Console.ReadLine());
                            if (miktar3 > bakiye)
                            {
                                Console.WriteLine("Çekeceğiniz miktar bakiyenizden büyüktür.Çekmek istediğiniz miktarı tekrar giriniz:");
                                miktar3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Bakiyeniz:{0}", bakiye - miktar3);
                            }
                            else if (miktar3 > 5000)
                            {
                                Console.WriteLine("Günlük para çekme limiti 5000 TL'dir.Çekmek istediğiniz miktarı tekrar giriniz:");

                                miktar3 = Convert.ToInt32(Console.ReadLine());
                                if (miktar3 % 5 != 0)
                                {
                                    Console.WriteLine("5 ve katları şeklinde para çekebilirsiniz.Çekmek istediğiniz miktarı tekrar giriniz:");
                                    miktar3 = Convert.ToInt32(Console.ReadLine());
                                }
                                else if (miktar3 > bakiye)
                                {
                                    Console.WriteLine("Çekeceğiniz miktar bakiyenizden büyüktür.Çekmek istediğiniz miktarı tekrar giriniz:");
                                    miktar3 = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.WriteLine("Bakiyeniz:{0}", bakiye - miktar3);
                            }
                            else if (miktar3 % 5 != 0)
                            {
                                Console.WriteLine("5 ve katları şeklinde para çekebilirsiniz.Çekmek istediğiniz miktarı tekrar giriniz:");
                                miktar3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Bakiyeniz:{0}", bakiye - miktar3);
                            }
                            else
                            {
                                Console.WriteLine("Bakiyeniz:{0}", bakiye - miktar3);
                            }
                            break;
                        case "parayatırma2":
                            Console.WriteLine("Yatırmak istediğiniz miktarı giriniz:");
                            miktar4 = Convert.ToInt32(Console.ReadLine());
                            if (miktar4 > 20000)
                            {
                                Console.WriteLine("Günlük para yatırma limiti 20000 TL'dir.Yatırmak istediğiniz miktarı tekrar giriniz:");
                                miktar4 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Bakiyeniz:{0}", bakiye + miktar4);
                            }
                            else if (miktar4 % 5 != 0)
                            {
                                Console.WriteLine("5 ve katları şeklinde para yatırabilirsiniz.Yatırmak istediğiniz miktarı tekrar giriniz:");
                                miktar4 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Bakiyeniz:{0}", bakiye + miktar4);
                            }
                            else
                            {
                                Console.WriteLine("Bakiyeniz:{0}", bakiye + miktar4);
                            }
                            break;
                        case "bakiyesorgulama2":
                            Console.WriteLine("Bakiyeniz:{0}", bakiye);
                            break;
                    }
                    Console.WriteLine("İşleminizin sonunda fiş istiyor musunuz?");
                    cevap3 = Convert.ToString(Console.ReadLine());
                    if (cevap3 == "Hayır")
                    {
                        Console.WriteLine("Lütfen kartınızı kontrol ederek alınız.");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen kartınızı ve fişinizi kontrol ederek alınız.");
                    }
                }
            }
        }



    }
}


