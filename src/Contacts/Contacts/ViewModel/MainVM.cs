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
    public class MainVM : INotifyPropertyChanged
    {
        private string _name { get; set; }
        private string _phone { get; set; }
        private string _email { get; set; }
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
        public SaveCommand Save { get; }
        public LoadCommand Load { get; }
        public Contact CurrentContact { get; set; }
        public MainVM()
        {
            CurrentContact = new Contact();
            Save = new SaveCommand();
            Load = new LoadCommand(LoadContact);
        }
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
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
