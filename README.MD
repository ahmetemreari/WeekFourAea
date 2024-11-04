# WeekFourAea Projesi

Bu proje, kullanıcıların telefon ve bilgisayar üretimini simüle etmelerini sağlayan bir konsol uygulamasıdır. Kullanıcılar, çeşitli bilgileri girerek telefon veya bilgisayar oluşturabilir ve bu bilgileri ekranda görüntüleyebilirler.

## İçindekiler

- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Özellikler](#özellikler)
- [Katkıda Bulunma](#katkıda-bulunma)
- [Lisans](#lisans)

## Kurulum

Bu projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1. Bu depoyu klonlayın:
    ```sh
    git clone https://github.com/ahmetemreari/WeekFourAea.git
    ```

2. Proje dizinine gidin:
    ```sh
    cd WeekFourAea
    ```

3. Gerekli bağımlılıkları yükleyin ve projeyi çalıştırın:
    ```sh
    dotnet build
    dotnet run
    ```

## Kullanım

Uygulamayı çalıştırdıktan sonra, kullanıcıdan telefon veya bilgisayar üretmek için seçim yapması istenecektir. Kullanıcı, gerekli bilgileri girdikten sonra ürün bilgileri ekranda görüntülenecektir.

### Telefon Üretimi

1. Konsolda "Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basınız:" mesajını göreceksiniz.
2. Telefon üretmek için `1` tuşuna basın.
3. İstenilen bilgileri girin:
    - Seri Numarası
    - Ad
    - Açıklama
    - İşletim Sistemi
    - TR Lisanslı (true/false)

### Bilgisayar Üretimi

1. Konsolda "Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basınız:" mesajını göreceksiniz.
2. Bilgisayar üretmek için `2` tuşuna basın.
3. İstenilen bilgileri girin (Bilgisayar üretim işlemleri henüz tamamlanmamıştır).

## Özellikler

- Telefon üretimi
- Kullanıcıdan bilgi alma ve doğrulama
- Ürün bilgilerini ekranda görüntüleme

## Katkıda Bulunma

Katkıda bulunmak isterseniz, lütfen bir pull request gönderin veya bir issue açın. Katkılarınızı memnuniyetle karşılıyoruz!

1. Depoyu fork edin
2. Yeni bir dal (branch) oluşturun (`git checkout -b feature/ozellik`)
3. Değişikliklerinizi commit edin (`git commit -am 'Yeni özellik ekle'`)
4. Dalınızı push edin (`git push origin feature/ozellik`)
5. Bir pull request açın

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.