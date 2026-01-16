using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualTaskList.Class
{
    public static class ErrorManager
    {
        public static Action<string, Color> ShowErrorAction;

        public static void Show(string message)
        {
            Show(message, Color.Red);
        }

        public static void Show(string message, Color color)
        {
            ShowErrorAction?.Invoke(message, color);
        }
    }
}
