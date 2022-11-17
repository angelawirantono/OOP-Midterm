using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_mock
{
    public static class ShapeType
    {
        public enum Geo
        {
            UNKNOWN = -1, BALL = 0, CUBE, CYLINDER, PYRAMID
        };
        public enum Material
        {
            UNKNOWN = -1, ALUMINIUM = 0, IRON, LEAD
        };
    }
    abstract class Shape
    {
        protected static int _amount;
        protected ShapeType.Material _materialtype;
        protected ShapeType.Geo _geotype;

        public Shape()
        {
            _materialtype = ShapeType.Material.UNKNOWN;
            _amount++;
        }
        public Shape(ShapeType.Material mtype)
        {
            _materialtype = mtype;
            _amount++;
        }
        public static int Amount
        {
            get { return _amount; }
        }
        public ShapeType.Material MaterialType
        {
            get { return _materialtype; }
        }
        public ShapeType.Geo GeoType
        {
            get { return _geotype; }
        }
        public abstract double Volume();
        public double Weight()
        {
            return Density() * Volume();
        }
        public double Density()
        {
            return MaterialTable.Density(_materialtype);
        }
        public abstract string ShapeProperty();

        protected string Property()
        {
            string msg = "";
            msg += string.Format("{0,8:F2}", Density());
            msg +='\t';
            msg += string.Format("{0,8:F2}", Volume());
            msg += '\t';
            msg += string.Format("{0,8:F2}", Weight());
            return msg;
        }
    }
}
