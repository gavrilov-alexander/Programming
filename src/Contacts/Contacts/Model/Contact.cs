using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Хранит и возвращает контакт.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name { get; set; }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phone { get; set; }

        /// <summary>
        /// Почта.
        /// </summary>
        private string _email { get; set; }
        
        /// <summary>
        /// Возвращает и задает имя.
        /// </summary>
        public string Name 
        {
            get 
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает телефон.
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }

        /// <summary>
        /// Возвращает и задает почту.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        /// <summary>
        /// Создает объект класса без инициализации.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создает объект класса.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="email">Почта.</param>
        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
