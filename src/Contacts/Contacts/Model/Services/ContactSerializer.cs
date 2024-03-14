using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    public static class ContactSerializer
    {
        public static string FileName { get; set; }
        public static void SaveData(Contact contact)
        {
            string directoryName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts");
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryName);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            FileName = Path.Combine(directoryName, "contacts.json");
            FileInfo fileInfo = new FileInfo(FileName);

            File.WriteAllText(FileName, string.Empty);
            File.AppendAllText(FileName, JsonConvert.SerializeObject(contact));
        }
        public static Contact LoadData()
        {
            string directoryName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts");
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryName);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            FileName = Path.Combine(directoryName, "contacts.json");
            FileInfo fileInfo = new FileInfo(FileName);
            if (!fileInfo.Exists)
            {
                File.WriteAllText(FileName, string.Empty);
                return new Contact();
            }
            else
            {
                Contact contact = new Contact();
                JsonTextReader reader = new JsonTextReader(new StreamReader(FileName));
                reader.SupportMultipleContent = true;
                while (reader.Read())
                {
                    JsonSerializer serializer = new JsonSerializer();
                    contact = serializer.Deserialize<Contact>(reader);
                    return contact;
                }
                reader.Close();
                return contact;
            }
        }
    }
}
