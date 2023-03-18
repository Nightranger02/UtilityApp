using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UtilityApp
{
    public class ToDoListViewModel
    {
        public ICommand AddToDoCommand => new Command(AddToDoItem);

        public ICommand RemoveToDoCommand => new Command(RemoveToDoItem);
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        public string InputValue { get; set; }

        public ToDoListViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();

            ToDoItems.Add(new ToDoItem("todo1", true));
            ToDoItems.Add(new ToDoItem("todo2", true));
            ToDoItems.Add(new ToDoItem("todo3", false));
        }

        void AddToDoItem()
        {
            ToDoItems.Add(new ToDoItem(InputValue, false));
            //TODO: clear input value after item is added.
        }

        void RemoveToDoItem(object o)
        {
            ToDoItem todoItemBeingRemoved = o as ToDoItem;
            ToDoItems.Remove(todoItemBeingRemoved);
        }
    }
}
