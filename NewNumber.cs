using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneBook
{
    public class NewNumber:ContactClass
    {
        public void add()
        {

            Console.WriteLine("Lütfen isim giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz:");
            string number = Console.ReadLine();
            contact.Add(number, name + " " + surname);
            Console.WriteLine(name + " " + surname + "added successfully.");        

        }
    }
}
