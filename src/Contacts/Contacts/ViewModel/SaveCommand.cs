using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class SaveCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public SaveCommand() 
        {
            
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (CanExecute(parameter))
            {
                if (parameter is Contact contact)
                {
                    ContactSerializer.SaveData(contact);
                }
            }
        }
    }
}
