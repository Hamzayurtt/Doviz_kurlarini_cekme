# Canlı Döviz Kuru Takip Uygulaması

![Uygulama Ekran Görüntüsü](ekran-goruntusu.png)

Hoş geldiniz! 

Bu proje, Türkiye Cumhuriyeti Merkez Bankası'nın güncel döviz kurlarını çekerek istediğiniz döviz kuru üzerinden belirttiğiniz
 miktardaki paranın Türk Lirası karşılığını hesaplayan ve aynı zamanda bu kurları SQL veritabanına kaydeden bir uygulamadır.

## Özellikler

- Güncel döviz kurlarını Türkiye Cumhuriyeti Merkez Bankası'ndan anlık olarak çeker.
- Seçtiğiniz döviz kuru üzerinden belirttiğiniz miktarı Türk Lirası karşılığına dönüştürür.
- Döviz kurları ve dönüşüm sonuçlarını anlık olarak SQL veritabanına kaydeder.
- Önceden kaydedilmiş döviz kuru verilerini tablo şeklinde görüntüler.

## Nasıl Kullanılır

1. Uygulamayı başlatın.
2. Anasayfada kuer verilerini getir butonunu göreceksiniz . Bu butona bastığınzda güncel döviz kurlarını göreceksiniz.
3. İstediğiniz döviz kuru üzerine tıklayarak dönüşüm yapmak istediğiniz parayı girin.
4. "Dönüştür" düğmesine tıklayarak girilen miktarın Türk Lirası karşılığını görüntüleyin.
5. "Verileri Kaydet" düğmesiyle döviz kuru verilerini SQL veritabanına kaydedin
6. "Önceki Veriler" sekmesinde kaydedilen döviz kuru verilerini tablo şeklinde görebilirsiniz.

## Proje Kurulumu

1. Bu projeyi yerel makinenize klonlayın veya indirin.
2. Visual Studio veya tercih ettiğiniz C# derleyicisini kullanarak projeyi açın.
3. Projeyi çalıştırmadan önce gerekli bağımlılıkları yüklemeyi unutmayın.
4. SQL veritabanı ayarlarınızı `app.config` dosyasında yapılandırın.
5. Proje içindeki kodu inceleyerek özelleştirmeler yapabilirsiniz.
6. Uygulamayı derleyin ve başlatın.

## Katkı

Eğer bu projeye katkıda bulunmak isterseniz, aşağıdaki adımları takip edebilirsiniz:

1. Projeyi forklayın.
2. Yaptığınız değişiklikleri yeni bir dalda (branch) geliştirin.
3. Değişikliklerinizi açıklayan açıklayıcı bir açıklama ekleyin.
4. Değişikliklerinizi ana projeye göndermek için bir pull isteği (pull request) oluşturun.

## Teşekkürler

Bu uygulamayı kullanarak veya geliştirmeye katkıda bulunarak zamanınızı ayırdığınız için teşekkür ederim! Herhangi bir sorunuz veya öneriniz varsa, lütfen iletişime geçmekten çekinmeyin.

**Keyifli kullanımlar!**