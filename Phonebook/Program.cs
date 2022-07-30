using System;
using System.Linq;

namespace Phonebook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Telefon Rehberi Uygulamasına Hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("1 Telefon rehberine İletişim bilgisi ekle");
            Console.WriteLine("2 Tüm Telefon Rehberini görüntüle (Kayıt sırasına göre)");
            Console.WriteLine("3 Tüm Telefon Rehberini görüntüle (Alfabetik sıraya göre)");
            Console.WriteLine("4 Numaraya göre iletişim bilgisini görüntüle");
            Console.WriteLine("5 İsim veya Soyisime göre arama yap");
            Console.WriteLine("x Çıkış");
            Console.WriteLine("---------------------------------------------");

            var userInput = Console.ReadLine();

            var Book = new Book();


            while (true)
            {


                switch (userInput)
                {


                    case "1":

                        Console.WriteLine("İsim:");
                        var name = Console.ReadLine();
                        bool check = name.All(Char.IsLetter);
                        int nlen = name.Length;

                        if (check == true && nlen != 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Sadece harf girişi yapınız. Ana menüye geri döndünüz.");
                            break;
                        }

                        Console.WriteLine("Soyisim:");
                        var surname = Console.ReadLine();
                        int slen = surname.Length;

                        bool check2 = surname.All(Char.IsLetter);
                        if (check2 == true && slen != 0)
                        {
                            if (Book.Already(name, surname))
                            {
                                Console.WriteLine("Numarayı güncellemek istiyor musunuz? (e/h)");
                                var _respond = Console.ReadLine();
                                if (_respond == "e")
                                {
                                    Console.WriteLine("Yeni numarayı girin: ");
                                    var _number = Console.ReadLine();
                                    Book.DeleteContact(name, surname, _number);
                                    break;
                                }
                                else if (_respond == "h")
                                {
                                    break;
                                }
                                else
                                    Console.WriteLine("Sadece e veya h harfini yazarak devam ediniz. Ana menüye geri döndünüz.");
                                break;

                            }
                        }
                        else
                        {
                            Console.WriteLine("Sadece harf girişi yapınız. Ana menüye geri döndünüz.");
                            break;
                        }



                        Console.WriteLine("Numara:");
                        var number = (Console.ReadLine());
                        int nulen = number.Length;
                        bool check3 = number.All(Char.IsDigit);
                        if (check3 == true && nulen != 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Sadece rakam girişi yapınız. Ana menüye geri döndünüz.");
                            break;
                        }


                        var NewContact = new Contact(name, surname, number);

                        Book.AddContact(NewContact);
                        Console.WriteLine("Rehbere başarılı bir şekilde kayıt edildi.");


                        break;

                    case "2":

                        Book.DisplayAll();

                        break;
                    case "3":
                        Console.WriteLine("Rehberi İsime göre alfabetik sıralamak için 1");
                        Console.WriteLine("Rehberi Soyisime göre alfabetik sıralamak için 2");
                        Console.WriteLine("Rehberi Numaraya göre sıralamak için 3");
                        var userInput3 = Console.ReadLine();
                        if (userInput3 == "1")
                        {


                            Book.AlphaName();
                            break;
                        }
                        else if (userInput3 == "2")
                        {

                            Book.AlphaSurname();
                            break;

                        }
                        else if (userInput3 == "3")
                        {

                            Book.AlphaNumber();
                            break;

                        }

                        else
                        {
                            Console.WriteLine("Doğru bir seçim yapmadığınız için ana menüye döndünüz.");
                            break;
                        }


                        break;

                    case "4":
                        Console.WriteLine("Arama yapmak için numarayı giriniz:");
                        var Searchnumber = Console.ReadLine();
                        Book.DisplayContact(Searchnumber);

                        break;



                    case "5":
                        Console.WriteLine("İsim için arama yapmak için 1");
                        Console.WriteLine("Soyisim için arama yapmak için 2");
                        var userInput2 = Console.ReadLine();
                        if (userInput2 == "1")
                        {

                            Console.WriteLine("İstediğiniz aramayı giriniz:");
                            var matchingsearch = Console.ReadLine();
                            Book.DisplayMatched(matchingsearch);
                            break;
                        }
                        else if (userInput2 == "2")
                        {
                            Console.WriteLine("İstediğiniz aramayı giriniz:");
                            var matchingsearch = Console.ReadLine();
                            Book.DisplayMatchedS(matchingsearch);
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Doğru bir seçim yapmadığınız için ana menüye döndünüz.");
                            break;
                        }
                    case "x":

                        return;


                    default:
                        Console.WriteLine("Doğru bir seçim yapmadınız");
                        break;



                }
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
                userInput = Console.ReadLine();
            }


        }
    }
}
