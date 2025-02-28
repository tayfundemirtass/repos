// Nullable Types

// int a; // Bu bir hata verir. Çünkü a değişkeni tanımlanmış ama değeri atanmamıştır.
//int a = 10;

//Console.WriteLine(a);


//int? b = null; // Nullable bir değişken tanımlanmıştır. Bu değişkenin değeri null olabilir.

int? maas = null;

Console.WriteLine(maas.HasValue); // Burada maas değişkeninin değeri var mı yok mu kontrol edilir. Eğer değeri varsa true, yoksa false döner.

Console.WriteLine(maas.Value); // Eğer maas değişkeninin değeri yoksa hata verir. Bu yüzden önce değeri var mı yok mu kontrol edilmelidir.

Console.WriteLine(maas.GetValueOrDefault()); // Eğer maas değişkeninin değeri yoksa default değeri döner. Default değeri int için 0'dır.