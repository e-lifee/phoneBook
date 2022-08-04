using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneBook
{
    public class ContactClass
    {
        
            public Dictionary<string, string> contact = new Dictionary<string, string>();

            public ContactClass()
            {
                contact.Add("45411545454", "elife efe");
                contact.Add("46546877854", "melahat tabakli");
                contact.Add("45678797979", "merve agac");
                contact.Add("45645123654", "sinem tasdemir");
                contact.Add("41555546545", "meryem avsar");
            }

            public void ListContact()
            {
                foreach (var item in contact)
                {
                    Console.WriteLine(item);
                }
            }

        }
    
}
