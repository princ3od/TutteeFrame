using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutteeFrame.Modal
{
    class DataAccess
    {
        // singleton design-pattern
        private DataAccess() { }
        readonly static DataAccess _instance = new DataAccess();
        public static DataAccess Instance => _instance;

    }
}
