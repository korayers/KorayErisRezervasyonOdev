# Koray Eriş - 20210108050

Bu projede dosyalardan verileri okuyup, işlemler yaparak olası uçuşları listelemek için bir konsol uygulaması geliştirdim. Uygulama C# dili kullanılarak yazıldı.Kullanım

## Uygulama 
_UcakRezervasyonKonsol.exe_ dosyası çalıştırılarak kullanılır. Program başlatıldığında, konsol yardımıyla kullanıcıdan nereden 
nereye uçuş yapılacağı bilgisi alınır. Bu bilgilere göre uygun uçuşlar listelenir ve kullanıcıdan uçuş numarası seçmesi beklenir. Uçuş seçildikten sonra müşterinin bilgileri alınır ve 
_Musteriler.txt_ dosyasına yazılır. Uçak kapasitesine göre rastgele bir koltuk müşteriye verilir. Müşteri sınıfı ve uçuş sınıfı ile _Rezervasyonlar.txt_ dosyasına kayıt oluşturulur.

### Modeller
Model sınıflarının özellikleri her bir sınıfa Interfacelerin implement edilmesiyle oluşturulmuştur.

### Methodlar
Metin dosyalarından okuma ve dosyaya yazma işlemlerinin gerçekleştirildiği methodları içeren _DosyadanOkuma ve DosyayaYazma_ isimli iki sınıf oluşturuldu. Bu sınıfların nesnesi
oluşturularak ana programda okuma ve yazma işlemleri için kullanıldı.

## Gereksinimler
.NET Framework 5.0.0 veya üzeri sürüm
