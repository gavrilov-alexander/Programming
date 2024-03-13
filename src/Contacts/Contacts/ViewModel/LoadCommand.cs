using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    public class LoadCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Contact _contact;

        private Action<Contact> _loadContact;

        public LoadCommand(Action<Contact> loadContact)
        {
            _loadContact = loadContact;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (CanExecute(parameter))
            {
                _contact = ContactSerializer.LoadData();
                _loadContact(_contact);
            }
        }
    }
}
