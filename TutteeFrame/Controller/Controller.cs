using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutteeFrame.Controller
{
    class Controller
    {
        // singleton design-pattern
        private Controller() { }
        readonly static Controller _instance = new Controller();
        public static Controller Instance => _instance;

      
    }
}
