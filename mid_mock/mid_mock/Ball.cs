using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_mock
{
    class Ball: Shape, Rollable
    {
        new private static int _amount;
        private double _radius;
        private static double _phi = 3.1415926;
        public Ball() : base()
        {
            _geotype = ShapeType.Geo.BALL;
            _radius = 0;
            _amount++;
        }
        public Ball(double radius, ShapeType.Material mtype) : base(mtype)
        {
            _geotype = ShapeType.Geo.BALL;
            _radius = radius;
            _amount++;
        }
        new public static int Amount
        {
            get { return _amount; }
        }
        public double Radius
        {
            get { return _radius; }
            set { if (value < 0) _radius = 0;
                _radius = value;
            }
        }
        public override double Volume()
        {
            return 4.0 / 3 * _phi * Radius * Radius * Radius;
        }
        public override string ShapeProperty()
        {
            string msg = string.Format("{0,8}", "Ball");
            msg += '\t';
            msg += string.Format("{0,8:F2}", Radius);
            msg += '\t';
            msg += string.Format("{0,8:F2}", "");
            msg += '\t';
            msg += Property();
            return msg;
        }
        public double Distance()
        {
            return Radius * Radius;
        }
        public string RollShapeProperty()
        {
            return ShapeProperty() + string.Format("{0,8:F2}", Distance());
        }
    }
}
