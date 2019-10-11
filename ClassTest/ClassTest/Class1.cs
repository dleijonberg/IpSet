using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTest
{
    class PointClass
    {
        private int _x;
        private int _y;
        private int _num;

        public PointClass(int num, int x, int y)
        {
            _num = num;
            _x = x;
            _y = y;
        }

        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int num
        {
            get { return _num; }
            set { _num = value; }

        }

    }
}
