using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basınız, çıkış yapmak için 3'e basınız:");
            if (int.TryParse(Console.ReadLine(), out int secim))
            {
                if (secim == 1)
                {
                    Telefon telefon = new Telefon
                    {
                        SeriNumarasi = GetInput("Seri Numarası: "),
                        Ad = GetInput("Ad: "),
                        Aciklama = GetInput("Açıklama: "),
                        IsletimSistemi = GetInput("İşletim Sistemi: "),
                        TrLisansli = bool.TryParse(GetInput("TR Lisanslı (true/false): "), out bool trLisansli) && trLisansli
                    };

                    telefon.BilgileriYazdir();
                    telefon.UrunAdiGetir();
                    Console.WriteLine("Telefon başarıyla üretildi!");
                }
                else if (secim == 2)
                {
                    // Bilgisayar üretim işlemleri burada yapılabilir
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş, lütfen tekrar deneyin.");
            }
        }
    }

    static string GetInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? string.Empty;
    }
}