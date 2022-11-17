using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_mock
{
    class Pyramid : Shape
    {
        new private static int _amount;
        private double _side;
        private double _height;
        public Pyramid() : base()
        {
            _geotype = ShapeType.Geo.PYRAMID;
            _side = 0;
            _height = 0;
            _amount++;
        }
        public Pyramid(double side, double height, ShapeType.Material mtype) : base(mtype)
        {
            _geotype = ShapeType.Geo.PYRAMID;
            _side = side;
            _height = height;
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
        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 0) _height = 0;
                _height = value;
            }
        }
        public override double Volume()
        {
            return 1.0/3 * Side * Side * Height;
        }
        public override string ShapeProperty()
        {
            string msg = string.Format("{0,8}", "Pyramid");
            msg += '\t';
            msg += string.Format("{0,8:F2}", Side);
            msg += '\t';
            msg += string.Format("{0,8:F2}", Height);
            msg += '\t';
            msg += Property();
            return msg;
        }
    }
}
