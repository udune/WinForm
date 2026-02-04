using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp1
{
    public class Contact
    {
        public string Name { get; set; } = "";
        public string PhoneNumber { get; set; } = "";

        public override string ToString()
        {
            return $"{Name}: {PhoneNumber}";
        }
    }

    public static class ContactFileReadWrite
    {
        public static int SaveContactList(List<Contact> contactList, string path)
        {
            int ret = 0;
            int lineCount = 0;
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Contact contact in contactList)
                {
                    lineCount++;
                    writer.WriteLine(contact.ToString());
                }
                ret = lineCount;
            }
            return ret;
        }

        public static List<Contact> LoadContactList(string path)
        {
            List<Contact> contactList = new List<Contact>();
            using (StreamReader reader = new StreamReader(path))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] parts = line.Split(new char[] { ':' }, 2);
                    if (parts.Length == 2)
                    {
                        Contact contact = new Contact
                        {
                            Name = parts[0].Trim(),
                            PhoneNumber = parts[1].Trim()
                        };
                        contactList.Add(contact);
                    }
                }
            }

            return contactList;
        }
    }
}
