using System;
public abstract class BaseMakine
{
   // Üretim Tarihi , seri numarası , ad , açıklama , işletim sistemi
   public DateTime UretimTarihi { get; set; }
   //required null dönmesin diye
    public required string SeriNumarasi { get; set; }

    public required string Ad { get; set; }

    public required string Aciklama { get; set; }

    public required string IsletimSistemi { get; set; }
    public BaseMakine()
    {
        UretimTarihi = DateTime.Now;
    }   
    public virtual void BilgileriYazdir()

    {
        //Üretim Tarihi , seri numarası , ad , açıklama , işletim sistemi yazdır
        Console.WriteLine($"Üretim Tarihi : {UretimTarihi}");
        Console.WriteLine($"Seri Numarası : {SeriNumarasi}");
        Console.WriteLine($"Ad : {Ad}");
        Console.WriteLine($"Açıklama : {Aciklama}");
        Console.WriteLine($"İşletim Sistemi : {IsletimSistemi}");

    }
    public abstract void UrunAdiGetir();
}