using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_mock
{
    class Cylinder : Shape, Rollable
    {
        new private static int _amount;
        private double _radius;
        private double _height;
        private static double _phi = 3.1415926;
        public Cylinder() : base()
        {
            _geotype = ShapeType.Geo.CYLINDER;
            _radius = 0;
            _height = 0;
            _amount++;
        }
        public Cylinder(double radius, double height, ShapeType.Material mtype) : base(mtype)
        {
            _geotype = ShapeType.Geo.CYLINDER;
            _radius = radius;
            _height = height;
            _amount++;
        }
        new public static int Amount
        {
            get { return _amount; }
        }
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0) _radius = 0;
                _radius = value;
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
            return _phi * Radius * Radius * Height;
        }
        public override string ShapeProperty()
        {
            string msg = string.Format("{0,8}", "Cylinder");
            msg += '\t';
            msg += string.Format("{0,8:F2}", Radius);
            msg += '\t';
            msg += string.Format("{0,8:F2}", Height);
            msg += '\t';
            msg += Property();
            return msg;
        }
        public double Distance()
        {
            return Radius * Height;
        }
        public string RollShapeProperty()
        {
            return ShapeProperty() + string.Format("{0,8:F2}", Distance());
        }
    }
}
