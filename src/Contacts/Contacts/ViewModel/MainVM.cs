using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Класс ViewModel.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
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
                CurrentContact.Name = _name;
                OnPropertyChanged();

            }
        }

        /// <summary>
        /// Возвращает и задапет номер телефона.
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
                CurrentContact.Phone = _phone;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// возвращат и задает почту.
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
                CurrentContact.Email = _email;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Команда сохранения объекта в файл.
        /// </summary>
        public SaveCommand Save { get; }

        /// <summary>
        /// Команда загрузки объекта из файла.
        /// </summary>
        public LoadCommand Load { get; }

        /// <summary>
        /// Возвращает и задает текущий контакт.
        /// </summary>
        public Contact CurrentContact { get; set; }

        /// <summary>
        /// Создает объект класса MainVM.
        /// </summary>
        public MainVM()
        {
            CurrentContact = new Contact();
            Save = new SaveCommand();
            Load = new LoadCommand(LoadContact);
        }

        /// <summary>
        /// Заполняет поля объекта при загрузке из файла.
        /// </summary>
        /// <param name="contact"></param>
        private void LoadContact(Contact contact)
        {
            if (contact == null)
            {
                return;
            }
            Name = contact.Name;
            Phone = contact.Phone;
            Email = contact.Email;
        }

        /// <summary>
        /// Зажигатся при изменении значения property.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Обновляет связанные объекты.
        /// </summary>
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
