using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }

       

        // Void ile int farkı 
        // Burada int ile yazıp return etsem ne olur veya void ile yazıp Console.WriteLine ile yazdırsam ne olur? 
        // Topla2 burada işini yapıyor ve sayi1 ve sayi2 yi toplayıp ekrana yazdırıyor.
        // Daha sonra program.cs'e gelip productManager.Topla2(3, 6); yazıyoruz. Bu işlem bize sonucu verir.
        // Burada neden return'e ihtiyacım var. Bir bankacılık uygulaması düşünün bankacılık uygulamasında krediyi hesaplarsınız ortaya çıkan sonucu
        // Daha sonra bir başka yerde daha kullanırsınız yani yukarıda yaptığım işlemin sonucunu aslında bir başka yerde daha kullanmak istiyorum.
        // Ancak void ile bunu yapmam mümkün değil bu yüzden returnleri kullanırız. 

    }
}
