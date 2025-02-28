/*
 * 
 *   String Methods
 * 
 * 
 */

string mesaj = "Ahmet Turan isimli kişi 20 yaşındadır. ";
//int adet = mesaj.Length; // LENGTH METODU İLE KARAKTER SAYISINI BULMA
//string adet = mesaj.ToLower(); // TOLOWER METODU İLE KÜÇÜK HARFE ÇEVİRME
//string adet = mesaj.ToUpper(); // TOUPPER ME TODU İLE BÜYÜK HARFE ÇEVİRME
//string adet = mesaj.Trim(); // TRIM METODU İLE BAŞTAKİ VE SONDAN KARAKTERLERİ SİLME
//var adet = mesaj.Split(" "); // SPLIT METODU İLE KARAKTERLERİ AYIRMA
//var adet = mesaj.Split(" ")[3]; // SPLIT METODU İLE KARAKTERLERİ AYIRMA VE İSTENİLEN KARAKTERİNİ ALMA, 3. KARAKTERİ ALDIK
//var adet = mesaj.StartsWith("A"); // STARTSWITH METODU İLE BAŞLANGIÇ KARAKTERİNİ KONTROL ETME VE TRUE FALSE DÖNDÜRME (Yani metin girilen değer ilemi başlıyor bunu da True False döner)
//var adet = mesaj.EndsWith("."); // ENDSWITH METODU İLE BİTİŞ KARAKTERİNİ KONTROL ETME VE TRUE FALSE DÖNDÜRME (Yani metin girilen değer ilemi bitiyor bunu da True False döner)
//var adet = mesaj.Contains("Turan"); // CONTAINS METODU İLE İÇERİP İÇERMEDİĞİNİ KONTROL ETME VE TRUE FALSE DÖNDÜRME (Yani metin girilen değer içeriyormu bunu da True False döner)
//var adet = mesaj.IndexOf("Turan"); // INDEXOF METODU İLE KARAKTERİN KONUMUNU BULMA (Yani metin girilen değerin kaçıncı karakterde olduğunu bulur)
var adet = mesaj.Substring(0, 5); // SUBSTRING METODU İLE KARAKTERLERİ AYIRMA (Yani metin girilen değerin kaçıncı karakterden kaçıncı karaktere kadar olan kısmını alır)
Console.WriteLine("Karakter Sayısı: " + adet);