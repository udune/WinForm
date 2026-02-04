using System.Diagnostics.Contracts;

namespace ConsoleContactListApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>
            {
                new Contact { Name = "Jane Smith", PhoneNumber = "987-654-3210" },
                new Contact { Name = "Alice Johnson", PhoneNumber = "555-123-4567" },
                new Contact { Name = "Bob Brown", PhoneNumber = "444-555-6666" },
                new Contact { Name = "Charlie Davis", PhoneNumber = "333-222-1111" },
                new Contact { Name = "Eve Wilson", PhoneNumber = "777-888-9999" }
            };

            ContactFileReadWrite contactFileReadWrite = new ContactFileReadWrite();
            string filePath = "C:\\Work\\2026_02_04\\ConsoleContactListApp1\\contacts.txt";
            int savedCount = contactFileReadWrite.SaveContactList(contacts, filePath);
            Console.WriteLine(savedCount);

            List<Contact> loadedContacts = contactFileReadWrite.LoadContactList(filePath);
            foreach (Contact c in loadedContacts)
            {
                Console.WriteLine(c);
            }
        }
    }
}
