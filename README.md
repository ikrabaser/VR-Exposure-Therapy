# 🧠 NEUROPHOBIA

Bu proje sanal gerçeklik teknolojilerinin psikolojik terapi alanındaki kullanımını araştırmak amacıyla geliştirilmiştir.

## VR Height Exposure Therapy Simulation

<img width="1510" height="841" alt="MenuKapak" src="https://github.com/user-attachments/assets/caa4ead6-92df-4899-8525-95bdf6f6b8a3" />


---

## 📖 Proje Hakkında

NEUROPHOBIA, yükseklik korkusuna sahip bireylerin kontrollü bir sanal gerçeklik ortamında yükseklik deneyimi yaşayabilmesi amacıyla geliştirilmiş VR tabanlı bir terapi simülasyonudur.

Proje Unity oyun motoru kullanılarak geliştirilmiş ve OpenXR altyapısı ile sanal gerçeklik desteği sağlanmıştır.

Kullanıcı terapi süresince:

- Yüksek platformlar üzerinde ilerler
- Görevleri tamamlar
- Stres seviyesini takip eder
- Kalp atışı geri bildirimi alır
- Görsel korku efektleri ile karşılaşır
- Terapi seansını başarıyla tamamlamaya çalışır

Bu sistem gerçek terapi uygulaması değildir. Eğitimsel ve akademik amaçlarla geliştirilmiştir.

---

## 🎯 Projenin Amacı

Yükseklik korkusu (Acrophobia), bireylerin günlük yaşam aktivitelerini etkileyebilen yaygın bir fobi türüdür.

Gerçek hayatta uygulanan maruziyet terapileri:

- Maliyetlidir
- Risk içerebilir
- Her zaman uygulanamayabilir

Bu projede sanal gerçeklik teknolojileri kullanılarak kontrollü ve güvenli bir alternatif ortam oluşturulmuştur.

Amaç:

- Kullanıcıyı yüksekliğe kontrollü şekilde maruz bırakmak
- Kaygı seviyesini yönetmek
- Kademeli görevlerle ilerleme sağlamak
- VR teknolojilerinin terapi alanındaki kullanımını göstermek

---

# 🚀 Kullanılan Teknolojiler

| Teknoloji | Kullanım Amacı |
|------------|------------|
| Unity 2022 | Oyun Motoru |
| C# | Oyun Mantığı |
| OpenXR | VR Desteği |
| XR Interaction Toolkit | XR Yönetimi |
| TextMeshPro | UI Sistemi |
| URP | Grafik Sistemi |
| XR Device Simulator | VR Simülasyonu |
# 🥽 OpenXR Yapılandırması
<img width="1899" height="779" alt="OpenXR_Ayar" src="https://github.com/user-attachments/assets/e6bab647-f8bd-4a7f-99b7-739f8f0e570e" />

Proje sanal gerçeklik desteği için OpenXR altyapısı kullanılarak geliştirilmiştir.

OpenXR, farklı VR donanımları arasında ortak bir standart sağlayan açık kaynaklı bir XR platformudur. Bu yapı sayesinde proje gelecekte Meta Quest, Oculus ve diğer OpenXR uyumlu cihazlara kolaylıkla uyarlanabilecek şekilde tasarlanmıştır.

Bu projede:

* OpenXR etkinleştirilmiştir.
* Oculus Touch Controller Profile kullanılmıştır.
* XR Interaction Toolkit ile entegrasyon sağlanmıştır.
* XR Device Simulator ile fiziksel VR gözlüğü olmadan test yapılmıştır.

Bu yaklaşım geliştirme sürecini hızlandırmış ve donanım bağımlılığını azaltmıştır.

---

# 🏗 Sahne Yapısı

<img width="335" height="566" alt="Unity sahne hiyerarşisi" src="https://github.com/user-attachments/assets/55ed658f-af1f-43ca-958f-b2d97c3caf35" />

Proje sahnesi terapi deneyimini oluşturan temel bileşenlerden oluşmaktadır. Sahne içerisinde VR oyuncusunu temsil eden XR Origin, terapi akışını yöneten GameManager, kullanıcı arayüzü için Canvas, stres hesaplamalarında kullanılan StressCenter ve terapi görevlerinin gerçekleştirildiği köprü platformu bulunmaktadır. Ayrıca XR Device Simulator sayesinde VR gözlük olmadan test işlemleri gerçekleştirilmiştir.

## Temel Nesneler

### XR Origin (XR Rig)

Kullanıcının sanal gerçeklik ortamındaki konumunu ve kamera sistemini yönetmektedir.

Görevleri:

* Kamera kontrolü
* Oyuncu pozisyonu
* VR takip sistemi

---

### XR Device Simulator

Geliştirme sürecinde gerçek bir VR gözlüğü bulunmadığından XR Device Simulator kullanılmıştır.

Bu sistem sayesinde:

* Klavye ve fare ile VR hareketleri test edilebilmiştir.
* Kamera kontrolü sağlanmıştır.
* XR etkileşimleri simüle edilmiştir.

---

### Player

Terapiyi deneyimleyen kullanıcıyı temsil etmektedir.

Oyuncu:

* Köprü üzerinde hareket eder.
* Görevleri tamamlar.
* Stres seviyesine bağlı geri bildirimler alır.

---

### StressCenter

Stres seviyesinin hesaplanmasında kullanılan referans noktadır.

Oyuncunun bu noktaya olan uzaklığı kullanılarak:

* Stres seviyesi hesaplanır.
* Kalp atışı sistemi güncellenir.
* Kamera sallanması kontrol edilir.
* Korku efekti uygulanır.

---

### TargetPoint

Terapi seansının tamamlanacağı hedef noktadır.

Kullanıcının terapi sürecini başarıyla tamamlayıp tamamlamadığı bu noktaya ulaşmasına göre belirlenmektedir.

---

### Bridge

Yükseklik deneyiminin yaşandığı ana platformdur.

Bu köprü:

* Kontrollü maruziyet ortamı oluşturur.
* Yükseklik hissini artırır.
* Kullanıcının korku seviyesini tetikler.

Terapi süreci boyunca tüm görevler bu alan üzerinde gerçekleştirilmektedir.

---

# 🎮 Ana Menü

<img width="1510" height="841" alt="MenuKapak" src="https://github.com/user-attachments/assets/3027b07a-5bbe-494f-b2a6-b39cf9ead458" />


Uygulama ilk açıldığında kullanıcı terapi sistemi hakkında bilgilendirilmektedir.

Menü ekranında kullanıcıya sistemin temel özellikleri sunulmaktadır.

## Sunulan Özellikler

### Stres Takibi

Kullanıcının kaygı seviyesinin gerçek zamanlı olarak takip edilmesini sağlar.

### Kontrollü Maruziyet

Yükseklik korkusuna karşı aşamalı ilerleme mantığı uygulanır.

### Görev Tabanlı İlerleme

Terapi belirli aşamalar ve görevler üzerinden ilerler.

### Gerçek Zamanlı Geri Bildirim

Kalp atışı ve görsel efekt sistemleri ile kullanıcıya anlık geri bildirim verilir.

Kullanıcı "Seansı Başlat" butonuna bastığında terapi süreci başlamaktadır.
# 🎬 Terapi Akışı

<img width="1519" height="849" alt="terapi0" src="https://github.com/user-attachments/assets/af2c02a1-6b4c-4223-a0e1-8fe09b49b90d" />

NEUROPHOBIA içerisinde terapi deneyimi aşamalı ilerleme mantığı kullanılarak tasarlanmıştır.

Kullanıcı bir anda yüksek stresli bir ortama maruz bırakılmak yerine kontrollü ve kademeli bir süreçten geçirilmektedir.

Bu yaklaşım gerçek dünyada kullanılan Exposure Therapy (Maruziyet Terapisi) yöntemlerinden esinlenmiştir.

Terapi toplamda üç aşamadan oluşmaktadır.

---

# 🧘 Görev 1: Nefesini Kontrol Et ve Ortamı Gözlemle

<img width="1507" height="830" alt="terapi1" src="https://github.com/user-attachments/assets/cacdfca4-3e15-4cca-a05b-a2249d47c92b" />


Terapi başladıktan sonra kullanıcı ilk olarak yüksek platform üzerinde güvenli bir bölgede bulunmaktadır.

Bu aşamada amaç:

* Kullanıcının ortama alışması
* İlk kaygı seviyesini azaltması
* Nefes kontrolünü sağlaması
* Çevreyi gözlemlemesi

Görev metni ekranın alt kısmında görüntülenmektedir.

Bu bölüm terapi sürecinin başlangıç aşamasını oluşturmaktadır.

Kullanıcının yüksekliğe karşı ani tepki vermemesi ve kontrollü biçimde ortama adapte olması hedeflenmiştir.

---

## Bu Aşamada Aktif Sistemler

* Görev Sistemi
* UI Sistemi
* Oyuncu Hareket Sistemi
* Stres Takip Sistemi

---

# 🌆 Görev 2: Yüksekliği Gözlemle ve Yavaşça İlerle

<img width="1495" height="835" alt="terapi2" src="https://github.com/user-attachments/assets/127041b3-3eda-4c9e-a864-7f4facb6cd0f" />


İkinci aşamada kullanıcı yüksekliğin daha belirgin hissedildiği bölgelere yönlendirilmektedir.

Bu aşamada:

* Platform genişlemektedir.
* Açık alan miktarı artmaktadır.
* Kullanıcının yükseklik algısı güçlenmektedir.

Amaç kullanıcının yükseklik hissine alışmasını sağlamaktır.

Görev ilerledikçe oyuncu daha fazla hareket etmek zorunda kalmaktadır.

Bu durum kontrollü maruziyet seviyesini artırmaktadır.

---

## Bu Aşamada Aktif Sistemler

* Görev Sistemi
* Stres Takibi
* Kamera Efektleri
* Kalp Atışı Sistemi

---

# 🚶 Görev 3: Stres Seviyeni Takip Ederek İlerlemeye Devam Et

<img width="1512" height="836" alt="terapi3" src="https://github.com/user-attachments/assets/0bb9d144-810d-452e-8683-34c630308820" />

Bu aşama terapi sürecinin en yoğun bölümüdür.

Oyuncu artık yüksekliğin maksimum hissedildiği bölgelerde hareket etmektedir.

Bu bölümde:

* Stres seviyesi yükselmektedir.
* Kamera sallanması aktif olmaktadır.
* Kalp atışı sesi duyulmaktadır.
* Görsel korku efektleri uygulanmaktadır.

Amaç oyuncunun kaygı seviyesini gözlemleyerek ilerlemeye devam etmesini sağlamaktır.

Bu aşama gerçek maruziyet terapisine en yakın deneyimi sunmaktadır.

---

## Bu Aşamada Aktif Sistemler

* StressManager
* CameraShake
* FearEffect
* HeartbeatController
* TherapyProgression

---

# 📊 Gerçek Zamanlı Geri Bildirim Sistemi

<img width="290" height="151" alt="hudpanel" src="https://github.com/user-attachments/assets/ed9d21e9-0d37-4e9e-aa73-c311db52e28d" />


Terapi sırasında kullanıcıya sürekli geri bildirim sağlanmaktadır.

Sol üst köşede bulunan panel üzerinden:

### Stres Seviyesi

Kullanıcının o anki kaygı seviyesini göstermektedir.

### Zorluk Seviyesi

Maruziyet seviyesini temsil etmektedir.

### Durum Bilgisi

Kullanıcının terapi içerisindeki genel durumunu göstermektedir.

Bu bilgiler oyuncunun süreç boyunca kendi durumunu takip etmesine yardımcı olmaktadır.

---

# 🏁 Seansın Tamamlanması

<img width="1511" height="839" alt="terapi4" src="https://github.com/user-attachments/assets/0e8ecfea-e6f7-41be-b6bd-20ccb2d388d1" />


Tüm görevlerin tamamlanmasının ardından terapi seansı başarıyla sonlandırılmaktadır.

Bu aşamada kullanıcıya:

> Seansı başarıyla tamamladın

mesajı gösterilmektedir.

Bu ekran terapi sürecinin başarıyla tamamlandığını ifade etmektedir.

Ayrıca kullanıcıya olumlu geri bildirim verilerek terapi deneyimi pozitif şekilde sonlandırılmaktadır.

---

# 🎯 Terapi İlerleme Mantığı

Terapi sistemi aşağıdaki akış ile çalışmaktadır.

```text
Seans Başlat
      │
      ▼
Görev 1
      │
      ▼
Görev 2
      │
      ▼
Görev 3
      │
      ▼
Seans Tamamlandı
```

Her görev belirli bir süre boyunca aktif kalmaktadır.

Görev süresi tamamlandığında sistem otomatik olarak bir sonraki aşamaya geçmektedir.

Bu yapı TherapyProgression scripti tarafından kontrol edilmektedir.
---

# 💻 Script Mimarisi

## Script Yapısı

Proje içerisinde terapi akışını ve kullanıcı geri bildirimlerini yönetmek amacıyla çeşitli C# scriptleri geliştirilmiştir.

### Başlıca Scriptler

| Script | Görevi |
|----------|----------|
| SessionIntroController | Terapi oturumunu başlatır |
| TherapyProgression | Görev ilerleyişini yönetir |
| StressManager | Stres seviyesini hesaplar |
| FearEffect | Görsel korku efektlerini uygular |
| HeartbeatController | Kalp atışı ses sistemini yönetir |
| CameraShake | Kamera sallanma efektini uygular |
| FallReset | Oyuncu düştüğünde başlangıç noktasına döndürür |
| PlayerMovement | Oyuncu hareketlerini sağlar |

---

# 📈 StressManager Sistemi

<img width="676" height="678" alt="StressManager cs" src="https://github.com/user-attachments/assets/65829f1c-b4a5-445f-8b1c-6e2b0ec8ab06" />


StressManager sistemi terapi deneyiminin merkezinde yer almaktadır.

Bu sistem oyuncu ile sahne içerisinde bulunan **StressCenter** nesnesi arasındaki mesafeyi sürekli olarak hesaplamaktadır.

Mesafeye bağlı olarak oyuncunun stres seviyesi güncellenmektedir.

| Mesafe | Stres Seviyesi |
|----------|----------|
| 0-2 | 4 |
| 2-5 | 6 |
| 5-8 | 8 |
| 8+ | 10 |

Stres seviyesi arttığında:

- Kamera sallanması aktif olur
- Kalp atışı sistemi çalışır
- Korku efekti uygulanır
- Kullanıcı arayüzü güncellenir

Bu yapı sayesinde oyuncunun yükseklik algısına bağlı olarak gerçek zamanlı psikolojik geri bildirim sağlanmaktadır.

---

# ❤️ Heartbeat Sistemi

<img width="991" height="563" alt="HeartbeatController cs" src="https://github.com/user-attachments/assets/1643a8e5-6728-48f3-abc6-1d60a80ca637" />


HeartbeatController sistemi oyuncunun stres seviyesine göre kalp atışı seslerini kontrol etmektedir.

Sistem özellikle yüksek stres seviyelerinde aktif hale gelmektedir.

Özellikleri:

- Stres seviyesi 8 ve üzerindeyken çalışır
- Kalp atışı sesini başlatır
- Ses seviyesini kademeli artırır
- Stres azaldığında sesi yavaşça düşürür
- Ani ses değişimlerini engeller

Bu sistem oyuncunun psikolojik gerilimini artıran önemli bir geri bildirim mekanizmasıdır.

---

# 🎥 Camera Shake Sistemi

<img width="850" height="702" alt="CameraShake cs" src="https://github.com/user-attachments/assets/a709acdf-d183-4f7c-8cad-344845c0cb8a" />


CameraShake sistemi yüksek stres seviyelerinde ekranın hafif şekilde sallanmasını sağlamaktadır.

Bu sistem:

- Kaygı hissini artırır
- Yükseklik etkisini güçlendirir
- Gerçekçilik seviyesini yükseltir

Kamera hareketleri Sin ve Cos fonksiyonları kullanılarak oluşturulmuştur.

Bu sayede doğal ve rahatsız etmeyen bir sallanma elde edilmiştir.

---

# 👁 Fear Effect Sistemi

<img width="632" height="355" alt="FearEffect cs" src="https://github.com/user-attachments/assets/66e4c8a9-b271-4766-b2a1-5a3ce0a43cc3" />


FearEffect sistemi oyuncuya görsel korku geri bildirimi vermektedir.

Stres seviyesi yükseldikçe ekran üzerinde yarı saydam bir katman görünür hale gelir.

Bu sistem:

- Kaygı hissini güçlendirir
- Oyuncunun stres durumunu görsel olarak yansıtır
- Maruziyet deneyimini daha etkili hale getirir

---

# 🔄 Session Yönetimi

<img width="813" height="794" alt="SessionIntroController cs" src="https://github.com/user-attachments/assets/0824e7ea-3b8a-4fa5-bde9-47aba2ba7218" />
<img width="731" height="727" alt="SessionIntroController1 cs" src="https://github.com/user-attachments/assets/4543dfda-ba1e-47c3-be4b-c002ed6a494e" />



SessionIntroController sistemi terapi sürecinin başlangıcını yönetmektedir.

Başlıca görevleri:

- Giriş ekranını göstermek
- Oyuncu hareketlerini başlangıçta kapatmak
- Terapi oturumunu başlatmak
- Görev sistemini etkinleştirmek
- HUD ekranlarını açmak

Bu yapı sayesinde kullanıcı kontrollü şekilde terapi sürecine dahil edilmektedir.

---

# 📝 TherapyProgression Sistemi

<img width="840" height="784" alt="TherapyProgression cs" src="https://github.com/user-attachments/assets/7ad95832-bc04-43bb-99b9-74e74f5a28e8" />
<img width="747" height="794" alt="TherapyProgression1 cs" src="https://github.com/user-attachments/assets/ad3a6c2b-8a99-46b5-b0ae-6cb46a504d00" />



TherapyProgression sistemi terapi sürecinin aşamalı olarak ilerlemesini sağlamaktadır.

Terapi aşağıdaki aşamalardan oluşmaktadır:

1. Nefesi kontrol et ve ortamı gözlemle
2. Yüksekliği gözlemle ve yavaşça ilerle
3. Stres seviyeni takip ederek ilerlemeye devam et
4. Seansı tamamla

Görevler belirli süreler boyunca aktif kalmaktadır.

Süre tamamlandığında sistem otomatik olarak sonraki göreve geçmektedir.

Bu yapı maruziyet terapilerinde kullanılan kademeli ilerleme mantığını simüle etmektedir.

---

# ⚠️ Düşme Kontrol Sistemi

<img width="991" height="731" alt="FallReset cs" src="https://github.com/user-attachments/assets/2c388782-37b5-40d1-8c11-e6428202d5ab" />


FallReset sistemi oyuncunun platformdan düşmesi durumunda devreye girmektedir.

Sistem:

- Oyuncunun yüksekliğini kontrol eder
- Belirlenen sınırın altına düşüldüğünde çalışır
- Oyuncuyu başlangıç pozisyonuna taşır
- Hız değerlerini sıfırlar
- Sesli geri bildirim verir

Bu sayede terapi deneyimi kesintiye uğramadan devam etmektedir.

---

# 🎮 Oyuncu Hareket Sistemi

<img width="729" height="349" alt="PlayerMovement cs" src="https://github.com/user-attachments/assets/0985406a-af28-484d-9631-40a089b25d52" />


PlayerMovement sistemi oyuncunun sahne içerisinde hareket etmesini sağlamaktadır.

### Kontroller

| Tuş | Hareket |
|------|----------|
| W | İleri |
| S | Geri |
| A | Sol |
| D | Sağ |

Bu sistem sayesinde oyuncu terapi köprüsü üzerinde ilerleyerek görevleri tamamlayabilmektedir.

---

# 🥽 VR Test Süreci

<img width="1507" height="831" alt="XR Panel Göstergesi" src="https://github.com/user-attachments/assets/0809f7ec-8da3-40d0-9d59-47989fa7e78d" />

Proje geliştirme sürecinde fiziksel bir VR gözlüğü bulunmadığından XR Device Simulator kullanılmıştır.

Bu sistem sayesinde:

- VR kamera hareketleri test edilmiştir
- OpenXR entegrasyonu doğrulanmıştır
- XR etkileşimleri simüle edilmiştir
- Proje gözlük olmadan geliştirilebilmiştir

Bu yaklaşım geliştirme sürecinin daha hızlı ilerlemesini sağlamıştır.

---

# 🎯 Proje Çıktıları

Bu proje kapsamında:

✅ Unity ile VR geliştirme deneyimi kazanılmıştır.

✅ OpenXR entegrasyonu gerçekleştirilmiştir.

✅ Gerçek zamanlı stres takip sistemi geliştirilmiştir.

✅ Kamera ve ses tabanlı korku efektleri uygulanmıştır.

✅ Görev tabanlı terapi akışı oluşturulmuştur.

✅ Yükseklik maruziyet terapisi konsepti sanal gerçeklik ortamına uyarlanmıştır.

---

# 📚 Gelecek Çalışmalar

Projenin gelecekte aşağıdaki özelliklerle geliştirilmesi planlanmaktadır:

- Gerçek VR gözlük entegrasyonu
- Dinamik stres ölçümü
- Biyometrik veri kullanımı
- Çoklu terapi senaryoları
- Performans analiz ekranı
- Kullanıcı kayıt sistemi
- Seans raporlama modülü


# ⭐ Proje Durumu

Bu proje akademik amaçlarla geliştirilmiş olup VR teknolojilerinin psikolojik terapi alanındaki kullanımını göstermek amacıyla hazırlanmıştır.

---

# 📚 Kaynakça

Bu proje geliştirilirken aşağıdaki kaynaklardan yararlanılmıştır.

## Unity Documentation

Unity Technologies. (2025).

https://docs.unity.com/

Unity oyun motoru, sahne yönetimi, kullanıcı arayüzü sistemleri ve C# script geliştirme süreçlerinde referans olarak kullanılmıştır.

---

## OpenXR Documentation

Khronos Group. (2025).

https://www.khronos.org/openxr/

OpenXR entegrasyonu ve XR cihaz desteği için kullanılmıştır.

---

## XR Interaction Toolkit Documentation

Unity Technologies. (2025).

https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit

XR Origin, XR Device Simulator ve VR etkileşim sistemlerinin geliştirilmesinde kullanılmıştır.

---

## TextMeshPro Documentation

Unity Technologies. (2025).

https://docs.unity3d.com/Packages/com.unity.textmeshpro

Arayüz elemanlarının ve görev sisteminin geliştirilmesinde kullanılmıştır.

---

## Exposure Therapy

American Psychological Association (APA).

https://www.apa.org

Maruziyet terapisi (Exposure Therapy) yaklaşımının temel prensipleri incelenmiştir.

---

## Acrophobia Research

National Institute of Mental Health (NIMH).

https://www.nimh.nih.gov

Yükseklik korkusu ve anksiyete bozuklukları üzerine genel bilgiler için kullanılmıştır.

---

## Unity Learn

Unity Technologies.

https://learn.unity.com


---
