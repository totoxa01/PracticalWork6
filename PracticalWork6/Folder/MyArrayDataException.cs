using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork6.Folder
{
    [Serializable]
    class MyArrayDataException:Exception
    {
        int rows;
        int columns;

        public MyArrayDataException(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
    }
}
