using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualTaskList.Models
{
    public class TypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public Color Color { get; set; }
    }
}
