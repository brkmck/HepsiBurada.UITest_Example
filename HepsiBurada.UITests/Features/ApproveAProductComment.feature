Feature: ApproveAProductComment
	Hepsiburada sitesi açılır, ürün araması yapılır,
	bir ürün detayına gidilir, ürüne yapılan yorum beğenilir

Background: 
	* 'https://www.hepsiburada.com/' sitesine gidilir

Scenario: ApproveAProductComment
	* Arama çubuğundan 'iphone' ürünü aratılır
	* Arama sonucunda gelen ürün listesinden rastgele bir ürün seçilir
	* Ürün detay sayfasından değerlendirmeler tabına tıklanır
	* Yorumların geldiği kontrol edilir, eğer yorum yapılmamışsa test bitirilir
	* Gelen yorumlar arasından ilk yorumun evet butonuna basılır
	* 'Teşekkür Ederiz.' yazısının geldiği görülür