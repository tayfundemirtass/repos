//int dogumTarihi = 1990;
//int yasInt = 2025 - dogumTarihi;
//byte yas = (byte)yasInt;
/*byte yas = checked((byte)yasInt);*/ // checked ile taşma kontrolü yapılır. Taşma olursa hata verir. checked kullanılmazsa taşma olursa değer 0 olur. 
//Console.WriteLine("Yas: " + yas);

//float kdvOrani = 1.18f; // 1.18 değerini float olarak tanımlamak için sonuna f harfi eklenir.
//decimal kdvOrani1 = 1.18m; // 1.18 değerini decimal olarak tanımlamak için sonuna m harfi eklenir.
//double kdvOrani2 = 1.18; // 1.18 değerini double olarak tanımlamak için sonuna f harfi eklenmez.
//byte kdvOrani3 = 18; // 18 değerini byte olarak tanımlamak için 0-255 arasında olmalıdır.
//bool isTrue = true; // true veya false değer alır.

// Değişkenlerin tipini öğrenmek için GetType() metodu kullanılır. Örneğin; yas.GetType() yazılarak yas değişkeninin tipi öğrenilebilir. 
// GetType() metodu ile tipi öğrenilen değişkenlerin tipi System.Type olarak döner.
// GetType() metodu ile tipi öğrenilen değişkenlerin tipini yazdırmak için GetType().Name kullanılır. Örneğin; yas.GetType().Name yazılarak yas değişkeninin tipi yazdırılabilir.
//Console.WriteLine("Yas tipi: " + yas.GetType().Name);

// ---------------------------------------------------------------------------------------------------//

// Değişken tip dönüşümleri yapılırken dikkat edilmesi gerekenler: 
// 1. Küçük tipten büyük tipte dönüşümde herhangi bir sorun olmaz. Örneğin; byte -> int, int -> long, float -> double, double -> decimal
// 2. Büyük tipten küçük tipte dönüşümde taşma olabilir. Örneğin; int -> byte, long -> int, double -> float, decimal -> double
// 3. Dönüşüm yapılırken veri kaybı olabilir. Örneğin; double -> float, decimal -> double
// 4. Dönüşüm yapılırken veri kaybı olmayacaksa implicit dönüşüm yapılır. Örneğin; int -> double, float -> double
// 5. Dönüşüm yapılırken veri kaybı olacaksa explicit dönüşüm yapılır. Örneğin; double -> int, double -> float  Örneğin; byte -> int, int -> byte
// 6. checked ile taşma kontrolü yapılır. checked kullanılmazsa taşma olursa değer 0 olur. checked kullanıldığında taşma olursa hata verir.


//Console.Write("1. Sayı:");
//var sayi1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("2. Sayı:");
//var sayi2 = Convert.ToInt32( Console.ReadLine());
////var toplam = sayi1 + sayi2;
//int toplam = Convert.ToInt32(sayi1 + sayi2);
//Console.Write(toplam);


// ---------------------------------------------------------------------------------------------------//

/*
 *      Veri Tipi Dönüşümleri
 *      // Implicit Conversion (Bilinçsiz Dönüşüm)
 *      // explicit Conversion (Bilinçli Dönüşüm)
 *  
 * 
 */

int a = 10; // Burada a değişkeni int tipindedir, ve ram de int tipinde yer kaplar.
byte b = (byte)a; // Implicit Conversion (Bilinçsiz Dönüşüm) işlemi yapılmıştır. Int tipinde ayrılan yere byte tipinde ayrılan b değerine atanmaya çalışılmıştır. Bu sebeble hata verir.
            // burada dönüşüm yapılarak sorun giderilir. byte b = (byte)a; şeklinde dönüşüm yapılabilir.
