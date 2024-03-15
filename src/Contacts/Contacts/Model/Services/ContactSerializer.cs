using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    /// <summary>
    /// Предоставляет методы сериализации и десериализации данных.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Возвращает и задает полный путь к файлу.
        /// </summary>
        public static string FileName { get; set; }

        /// <summary>
        /// Сериализует объекты.
        /// </summary>
        /// <param name="contact">Входной объект.</param>
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

        /// <summary>
        /// Десериализует объекты.
        /// </summary>
        /// <returns>Контакт.</returns>
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
