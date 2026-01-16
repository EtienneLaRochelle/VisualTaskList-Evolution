using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualOrganisationTool
{
    public class Cour
    {

        public int id;
        public string name;
        public string shortName;

        public Cour(int id, string name, string shortName)
        {
            this.id = id;
            this.name = name;
            this.shortName = shortName;
        }

        public string display()
        {
            return $"{shortName}";
        }
    }
}
