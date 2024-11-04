using System;

class Bilgisayar : BaseMakine
{
    private int usbGirisSayisi;
    public int UsbGirisSayisi
    // if else geçerlimi değilmidir kontrolü yapılıyor
    {
        get { return usbGirisSayisi; }
        set
        {
            if (value == 2 || value == 4)
                usbGirisSayisi = value;
            else
            {
                Console.WriteLine("Geçersiz USB giriş sayısı. -1 olarak atanıyor.");
                usbGirisSayisi = -1;
            }
        }
    }
    public bool Bluetooth { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
        Console.WriteLine($"Bluetooth: {Bluetooth}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
    }
}
