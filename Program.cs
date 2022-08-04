using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":                 
                    NewNumber newNum = new NewNumber();
                    newNum.add();
                    newNum.ListContact();
                    break;

                case "2":                   
                    DeleteNumber delNum = new DeleteNumber();
                    delNum.delete();
                    break;

                case "3":                   
                    UpdateNumber updNum = new UpdateNumber();
                    updNum.updateNum();
                    break;

                case "4":
                    ContactClass baseObj = new ContactClass();
                    baseObj.ListContact();
                    break;

                case "5":
                    SearchContact search = new SearchContact();
                    search.Search();
                    break;

            }

            Console.ReadLine();
        }
    }

}
