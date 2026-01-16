using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualOrganisationTool
{
    public class Task
    {
        public int id;
        public string name;
        public string className;
        public string type;
        public DateTime dueDate;
        public string notes;

        public Task(int id, string name, string className, string type, DateTime dueDate, string notes = null)
        {
            this.id = id;
            this.name = name;
            this.className = className;
            this.type = type;
            this.dueDate = dueDate;
            this.notes = notes;
        }

        public string display()
        {
            return $"{className} - {name} - {dueDate.ToString("dd MMM")}";
        }


    }
}
