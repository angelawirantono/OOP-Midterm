using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_mock
{
    public class Element
    {
        public ShapeType.Material MaterialType { get; set; }
        public string Name { get; set; }
        public double Density { get; set; }
        public Element() { }
        public Element(ShapeType.Material mtype, string name, double density)
        {
            MaterialType = mtype;
            Name = name;
            Density = density;
        }
    }
    public static class MaterialTable
    {
        public static Element[] elm = {
            new Element(ShapeType.Material.ALUMINIUM, "Aluminium", 2.7),
            new Element(ShapeType.Material.IRON, "Iron", 7.87),
            new Element(ShapeType.Material.LEAD, "Lead", 11.3)};
        public static ShapeType.Material Type(string name)
        {
            foreach(var e in elm)
            {
                if (e.Name == name) return e.MaterialType;
            }
            return ShapeType.Material.UNKNOWN;
        }
        public static double Density(string name)
        {
            foreach(var e in elm)
            {
                if (e.Name == name) return e.Density;
            }
            return 0;
        }
        public static double Density(ShapeType.Material mtype)
        {
            foreach (var e in elm)
            {
                if (e.MaterialType == mtype) return e.Density;
            }
            return 0;
        }
    }
}
