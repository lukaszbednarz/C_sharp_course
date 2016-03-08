using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convert_Code_to_use_EventHandler_T_
{
    class MartialStatusChangedEventArgs : EventArgs
    {
        public bool isMarried;
        private bool isMarried_2;

        public MartialStatusChangedEventArgs(bool isMarried_2)
        {
            // TODO: Complete member initialization
            this.isMarried_2 = isMarried_2;
        }
    }
}
