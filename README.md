# TravelTripProject

Bu proje, M&Y Yazılım Eğitim Akademi Danışmanlık bünyesinde Murat Yücedağ hocamın rehberliğinde devam eden **Full Stack .Net Core Development** eğitiminin bir parçası olarak geliştirilmiştir. "TravelTripProject", seyahat ve gezi deneyimlerini paylaşmayı hedefleyen dinamik bir platform olarak kullanıcıların gezdiği yerleri, yorumları ve içerikleri yönetmelerine olanak tanır.

## Proje Hakkında

### Kullanıcı Arayüzü
**TravelTripProject**, ziyaretçilerin gezilecek yerler hakkında bilgi alabilecekleri, gezilere dair yorum yapabilecekleri ve dinamik içerikleri takip edebilecekleri modern ve kullanıcı dostu bir arayüz sunar. Ayrıca, ziyaretçiler belirli bir seyahat için yorum yaparak etkileşimde bulunabilirler.

### Admin Yönetim Paneli
**Admin Paneli**, site yöneticisinin blog gönderilerini ve yorumları yönetmesine, kullanıcı yetkilendirmesi yapmasına ve içerikleri dinamik olarak düzenlemesine olanak tanır. Yönetim paneli, güvenli giriş için **Authentication** işlemlerini içerir ve CRUD işlemlerinin tamamı admin tarafından kolayca gerçekleştirilebilir.

## Projede Kullanılan Teknolojiler

- **ASP.NET MVC**: Web uygulamasının ana çatısı olarak kullanıldı ve kullanıcı ile admin arayüzleri arasında sorunsuz bir geçiş sağlandı.
- **Entity Framework Code-First**: Veritabanı işlemleri için Code-First yaklaşımı kullanıldı; böylece veritabanı şeması model sınıfları üzerinden oluşturuldu ve yönetildi.
- **Microsoft SQL Server (MSSQL)**: Veritabanı yönetimi için kullanıldı ve tüm veri güvenliği sağlandı.
- **HTML - CSS - Bootstrap**: Responsive ve kullanıcı dostu bir arayüz sağlamak için kullanıldı.
- **JavaScript**: Dinamik içerikler ve kullanıcı etkileşimlerini desteklemek amacıyla kullanıldı.
- **LINQ**: Veri sorgulama işlemlerinde kodun daha okunabilir ve sürdürülebilir olması sağlandı.

## Projenin Özellikleri

- **Slider Kullanımı**: Anasayfada, gezilecek yerler ve öne çıkan seyahat içerikleri slider ile görsel olarak sunulmakta.
- **Tek View’da Birden Fazla Tablodan Veri Çekme**: Partial view ve `IEnumerable` kullanılarak farklı tablolardan veriler tek bir view’da dinamik olarak gösterilmektedir.
- **Temel CRUD İşlemleri**: Admin paneli üzerinden içeriklerin oluşturulması, okunması, güncellenmesi ve silinmesi sağlanmaktadır.
- **Yorum Yapma**: BlogDetay sayfası üzerinden kullanıcılar belirli gezilere yorum yapabilirler.
- **Authentication İşlemleri**: Admin paneline güvenli giriş yapılabilmesi için kimlik doğrulama işlemleri uygulanmıştır.

---

Bu proje, **ASP.NET MVC** ve **Entity Framework** gibi .NET teknolojilerinin etkin bir şekilde kullanıldığı, dinamik içerik ve kullanıcı etkileşimi sunan bir seyahat platformu olarak geliştirilmiştir.

#Proje Görselleri
![Ekran görüntüsü 2024-10-28 134747](https://github.com/user-attachments/assets/e940837d-08ed-4e05-888e-33b2799e2549)
![Ekran görüntüsü 2024-10-28 134854](https://github.com/user-attachments/assets/55d0e755-ed05-4287-850e-dae40f746f45)
![Ekran görüntüsü 2024-10-28 135017](https://github.com/user-attachments/assets/5dc1e833-488b-40be-acd3-f51ee9f6778c)
![Ekran görüntüsü 2024-10-28 135106](https://github.com/user-attachments/assets/7ea62ba3-0c8e-4d86-8d07-108ae5934689)
![Ekran görüntüsü 2024-10-28 135136](https://github.com/user-attachments/assets/3a86725a-7628-44bb-9a00-cf3fec2a099e)
![Ekran görüntüsü 2024-10-28 135212](https://github.com/user-attachments/assets/48ccd4f7-275b-4b6e-8e17-47f50b7f6a30)
![Ekran görüntüsü 2024-10-28 135255](https://github.com/user-attachments/assets/9892c4c9-6fc9-4f4c-9bf6-96750992af79)
![Ekran görüntüsü 2024-10-28 135328](https://github.com/user-attachments/assets/7ee099f1-69e0-4e17-8d08-4f829d5e23af)
![Ekran görüntüsü 2024-10-28 135427](https://github.com/user-attachments/assets/c8f42973-cb89-4402-bd52-60ee81ad5af6)
![Ekran görüntüsü 2024-10-28 135520](https://github.com/user-attachments/assets/0d5a8e69-5121-40fd-98bd-5ceae4ab7195)
