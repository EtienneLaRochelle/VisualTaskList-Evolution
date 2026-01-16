using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualTaskList.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TypeId { get; set; } 
        public TypeModel Type {get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public string Notes { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsHidden { get; set; } = false;
    }
}
