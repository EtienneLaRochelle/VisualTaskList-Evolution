using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList
{
    internal interface IMainForm
    {
        public void SetLegendLabels(List<TypeModel> types);
        public void SetCubeCalender(List<TaskModel> tasks);
    }
}
