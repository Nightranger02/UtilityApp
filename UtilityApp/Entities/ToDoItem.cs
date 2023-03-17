using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityApp
{
    public class ToDoItem
    {
        public string ToDoText { get; set; }
        public bool Completed { get; set; }

        public ToDoItem(string toDoText, bool complete)
        {
            this.ToDoText = toDoText;
            this.Completed = complete;
        }
    }
}
