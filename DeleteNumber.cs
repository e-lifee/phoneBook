using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneBook
{
    public class DeleteNumber:ContactClass
    {
        public void delete()
        {
            delete:
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string nameSurname = Console.ReadLine();
            int count = 0;
            foreach (var item in contact)
            {
                if (item.Value.Contains(nameSurname))
                {
                    contact.Remove(item.Key);
                    Console.WriteLine(item.Value + " başarıyla silindi.");
                    break;
                }
                else
                {
                    count++;
                    continue;
                }
            }

            if (count == contact.Count)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("çıkış yapıldı.");                   
                }
                else if (choice == "2")
                    goto delete;
                    
            }

            foreach (var item in contact)
            {
                Console.WriteLine(item);
            }

        }
    }
}
