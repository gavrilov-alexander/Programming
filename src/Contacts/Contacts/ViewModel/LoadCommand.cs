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
    /// <summary>
    /// Загружает объект из файла.
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Вызывается при изменении состояния команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Загруженный контакт.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Метод.
        /// </summary>
        private Action<Contact> _loadCommand;

        /// <summary>
        /// Создает объект комманды.
        /// </summary>
        /// <param name="loadCommand">Метод.</param>
        public LoadCommand(Action<Contact> loadCommand)
        {
            _loadCommand = loadCommand;
        }

        /// <summary>
        /// Определяет может ли выполниться команда.
        /// </summary>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет команду загрузки контакта.
        /// </summary>
        public void Execute(object? parameter)
        {
            if (CanExecute(parameter))
            {
                _contact = ContactSerializer.LoadData();
                _loadCommand(_contact);
            }
        }
    }
}
