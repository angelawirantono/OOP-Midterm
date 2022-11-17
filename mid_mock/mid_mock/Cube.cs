using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_mock
{
    class Cube : Shape
    {
        new private static int _amount;
        private double _side;
        private static double _phi = 3.1415926;
        public Cube() : base()
        {
            _geotype = ShapeType.Geo.CUBE;
            _side = 0;
            _amount++;
        }
        public Cube(double side, ShapeType.Material mtype) : base(mtype)
        {
            _geotype = ShapeType.Geo.CUBE;
            _side = side;
            _amount++;
        }
        new public static int Amount
        {
            get { return _amount; }
        }
        public double Side
        {
            get { return _side; }
            set
            {
                if (value < 0) _side = 0;
                _side = value;
            }
        }
        public override double Volume()
        {
            return Side * Side * Side;
        }
        public override string ShapeProperty()
        {
            string msg = string.Format("{0,8}", "Cube");
            msg += '\t';
            msg += string.Format("{0,8:F2}", Side);
            msg += '\t';
            msg += string.Format("{0,8:F2}", "");
            msg += '\t';
            msg += Property();
            return msg;
        }
    }
}
