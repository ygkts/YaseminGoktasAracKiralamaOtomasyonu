	KULLANILAN TEKNOLOJÝLER:

	- Microsoft Sql Server 2014
	- Visual Studio Enterprise 2015
	- Entity Framework
	- c# Programlama Dili
	- .net Framework

	PROGRAMIN AMACI :

	- Bu program, bir araç kiralama þirketinde çalýþanlarýn internetsiz bir ortamda gerekli tüm iþlemleri yapabilmesi için yazýlmýþtýr.

	PROGRAMIN KULLANIM AÞAMALARI:

	Program çalýþtýrýldýðýnda ilk olarak KULLANICI GÝRÝÞÝ ekraný karþýmýza çýkar. Burada bu formun formLoad eventinde otomatik olarak email ve þifre atanmýþtýr. Bu hazýr gelen bilgiler ile giriþ yapýlabilineceði gibi kullanýcýlar veri tabanýndaki diðer kullanýcýlarýn bilgileriyle de giriþ yapýlabilir. Ýki textbox da dolu ise enter tuþuna basarak anasayfa formuna giriþ yapabilirsiniz.
	
	Ýlk olarak anasayfanýn sað üst köþesinde giriþ yapan kullanýcýnýn adý ve soyadý bilgisi belirmektedir. Çýkýþ yap butonu ile formun kapanmasýný saðlayýp programdan çýkabilirsiniz. 
	
	Menü Strip'in ilk menüsü Müþteri Ýþlemleri menüsüdür. Burada müþteri ekleme, çýkarma ve bilgilerini güncelleme iþlemleri yapýlabilir. Bu menüye týkladýðýmýzda AnasayfaFormunun içine MüþteriÝþlemleri formunu almýþ oluruz. Açýlan bu form müþteri için her türlü ihtiyaç duyulan bilgileri içermektedir. PictureBox'a bir müþteri resmi ekleyerek bu resmi de veri tabanýna ekleyebilirsiniz. Bu, pictureBox'taki resmin Byte [] türüne yani bir byte dizisine çevirilmesiyle gerçekleþtirilmiþtir. Resim haricindeki bilgiler de textboxlar, comboboxlar, datetimepicker'lar kullanýlarak alýnmýþtýr. Bu alanda datagridbiew üzerinde bir satýra týklandýðýnda tüm bilgiler ayrý ayrý güncelleme yapabilmek için yerlerine yerleþtirilir. Bu iþlem datagridview'in cellmouseclick event'ine yazýlmýþtýr.
	
	Sonraki menü Araç Ýþlemleri menüsüdür ve bize Araç Ýþlemleri Formunu açar. Bu formda müþteri iþlemlerindeki gibi eklem, çýkarma ve güncellem iþlemlerini veirt tabanýmýza yapabilmektir. Eðer þirket yeni bir araç aldýysa veya araç bilgisi hakkýnda güncellem yapacak ise veya arýzalý ya da çok eski bir aracý sistemden çýkarmak istiyorsa bu forma ihtiyaç duymaktadýr.
	
	Diðer menü Kira Ýþlemleri adýndadýr. Buraya týklandýðýnda 
 adet alt menü karþýmýza çýkar: Araç Kirala ve Kiradan Araç Al . Bu iki menü de ayný formu açmaktadýr. Farklý bir kullaným olmasý açýsýndan burada ayrý ayrý formlar oluþturmak yerine ayný tabloüzerinde iþlem yapýlacaðý için tek formun iki alt menü için de gerekli yerleri aktif býrakýlarak kullanýþlý bir form oluþturulmuþtur. Bu form da Araç Kirala ile Kiralamýþ araçlar tablosuna ekleme ve güncelleme iþlemi yapýlýr ve bu kiralama yapýldýðýnda Müsaiit Araçlar tablosundan o plakalý araç silinmiþtir. Kiradan Araç Al alt menüsü ise Kiralanmýþ Araçlar tablosundan silme iþlemi yapar. BU silme gerçekletiðinde bu araç msüait araçlar tablosuna tekrar eklenmiþ olur.
	
	Raporlar menüsü kiralanmýþ bir araç tesllim alýndýktan sonra eðer büyük bir hasarý olduðu anlaþýlýrsa o araç hakkýnda kiralayan kiþiye hasar ücretini alabilmek için rapor tutulur.  Rapor tutalan araç Müsait Araçlar kýsmýndan (tablosundan) çýkarýlmýþtýr. Eðer bu raporlar tablosundaki araç da silinir ise Araçlar tablosundan da bu araç silinmektedir. Çünkü artýk o araç þirket prensipleri gereði þirketin galerisinde tutulmak ve bir müþteriye kiralanmak istenmez.
	
	Hakkýnda menüsü ile otomasyon kullanýcýsýna, otomasyonu tanýtmak amacý ile kýsaca bilgilendirme yapýlmýþtýr. Neyin ne iþe yaradýðý neyi nasýl kullanacaðý hakkýnda bilgiler bu form sayesinde kullanýcýya iletilir.
	
	Ayarlar menüsü sisteme giriþ yapan otomasyon kullanýcýsýnýn yetki düzeyi 5 ve üzeri ise eriþilebilmektedir. Eðer bu alt menüyü açabilme yetkiniz var ise bu kýsým kullanýcýý ekleme silme veya bilgileri güncellemeye yaramaktadýr. Yetki düzeyi kullanýcýlar tablosunda YetkiDüzeyi alanýnda tutulur ve buradan çekilerek program kodu içinde kontrol gerçekleþtirilir.