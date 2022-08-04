using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneBook
{
    public class UpdateNumber:ContactClass
    {
        public void updateNum()
        {
            update:
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string name = Console.ReadLine();
            int count = 0;
            foreach (var item in contact)
            {
                if (item.Value.Contains(name))
                {
                    Console.WriteLine("lütfen yeni numarasını giriniz:");
                    string number = Console.ReadLine();
                    string nameNew = item.Value;
                    contact.Remove(item.Key);
                    contact.Add(number, nameNew);

                    break;
                }
                else
                {
                    continue;
                }
            }
            if (count == contact.Count)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("çıkış yapıldı.");
                }
                else if (choice == "2")
                    goto update;

            }

            foreach (var item in contact)
            {
                Console.WriteLine(item);
            }
        }
    }
}
