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
        public ObservableCollection<ToDoItem> ToDoItemsList { get; set; }
        public string InputValue { get; set; }

        public ToDoListViewModel()
        {
            ToDoItemsList = new ObservableCollection<ToDoItem>();

            ToDoItemsList.Add(new ToDoItem("todo1", true));
            ToDoItemsList.Add(new ToDoItem("todo2", true));
            ToDoItemsList.Add(new ToDoItem("todo3", false));
        }

        void AddToDoItem()
        {
            ToDoItemsList.Add(new ToDoItem(InputValue, false));            
        }

        void RemoveToDoItem(object o)
        {
            ToDoItem todoItemBeingRemoved = o as ToDoItem;
            ToDoItemsList.Remove(todoItemBeingRemoved);
        }
    }
}
