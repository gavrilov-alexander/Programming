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
    /// <summary>
    /// Загружает объект в файл.
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Вызывается при изменении состония команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Создает объект комманды без инициализации.
        /// </summary>
        public SaveCommand() 
        {
            
        }

        /// <summary>
        /// Определяет может ли выполниться команда.
        /// </summary>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет команду сохранения контакта.
        /// </summary>
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
