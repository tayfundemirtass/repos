/*
 * 
 *  String Veri Tipi: Karakter dizilerini tutmak için kullanılan veri tipidir.
 * 
 */

//char cinsiyet = 'E'; // char veri tipi ile tek bir karakter tutulur.

//string cinsiyet2 = "Erkek"; // string veri tipi ile karakter dizileri tutulur. Tek bir karakterden oluşan dizilerde kullanılabilir.


Console.Write("Adı: ");
string? ad = Console.ReadLine();
Console.Write("Soyadı: ");
string? soyad = Console.ReadLine();
Console.Write("Yaşı: ");
string? yas = Console.ReadLine();

// string veri tipi ile karakter dizileri birleştirilebilir.
//string mesaj = "Benim adım " + ad + " " + soyad + " ve " + yas + " yaşındayım."; // bu yöntem bir farklı yazım biçimi mesaj2 kısmındaki yazım biçimidir. String interpolation
//Console.WriteLine(mesaj);

// String interpolation
string mesaj2 = $"Benim adım {ad} {soyad} ve {yas} yaşındayım."; // En başa $ işareti koyulur ve süslü parantez içine değişken adı yazılır.
Console.WriteLine(mesaj2);


