using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace mid_mock
{
    public partial class Form2 : Form
    {
        private List<Shape> shapeArr = new List<Shape>();
        private List<Rollable> rollArr = new List<Rollable>();
        private delegate bool comparefunc(Shape a, Shape b);
        private ShapeType.Material _mtype;
        public Form2()
        {
            InitializeComponent();
            cbx_geo.SelectedIndex = 0;
            cbx_mat.SelectedIndex = 0;
            cbx_sort.SelectedIndex = 0;
            mat_density_txt.Enabled = false;
        }

        private void btn_shape_add_Click(object sender, EventArgs e)
        {
            switch (cbx_geo.SelectedItem.ToString())
            {
                case "Ball":
                    shapeArr.Add(new Ball(double.Parse(geo1_txt.Text), _mtype));
                    break;
                case "Cube":
                    shapeArr.Add(new Cube(double.Parse(geo1_txt.Text), _mtype));
                    break;
                case "Cylinder":
                    shapeArr.Add(new Cylinder(double.Parse(geo1_txt.Text), double.Parse(geo2_txt.Text), _mtype));
                    break;
                case "Pyramid":
                    shapeArr.Add(new Pyramid(double.Parse(geo1_txt.Text), double.Parse(geo2_txt.Text), _mtype));
                    break;
                default:
                    break;
            }
            total_txt.Text = Shape.Amount.ToString();
            ball_txt.Text = Ball.Amount.ToString();
            cube_txt.Text = Cube.Amount.ToString();
            cylinder_txt.Text = Cylinder.Amount.ToString();
            pyramid_txt.Text = Pyramid.Amount.ToString();
            ShowAllShapeInfo(txt_message);
        }

        private void ShowAllShapeInfo(TextBox d)
        {
            string str = "";
            foreach (var s in shapeArr) str += (s.ShapeProperty() + "\r\n");
            d.Text = str;
        }

        private void cbx_geo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_geo.SelectedItem.ToString())
            {
                case "Ball":
                    geo1_lbl.Text = "Radius";
                    geo2_lbl.Visible = false;
                    geo2_txt.Visible = false;
                    break;
                case "Cube":
                    geo1_lbl.Text = "Side";
                    geo2_lbl.Visible = false;
                    geo2_txt.Visible = false;
                    break;
                case "Cylinder":
                    geo1_lbl.Text = "Radius";
                    geo2_lbl.Visible = true;
                    geo2_lbl.Text = "Height";
                    geo2_txt.Visible = true;
                    break;
                case "Pyramid":
                    geo1_lbl.Text = "Side";
                    geo2_lbl.Visible = true;
                    geo2_lbl.Text = "Height";
                    geo2_txt.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void cbx_mat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material = cbx_mat.SelectedItem.ToString();
            _mtype = MaterialTable.Type(material);
            mat_density_txt.Text = MaterialTable.Density(material).ToString();
        }
        private bool compareShapeAscent(Shape a, Shape b)
        {
            if (a.GeoType > b.GeoType) return true;
            else return false;
        }
        private bool compareShapeDescent(Shape a, Shape b)
        {
            if (a.GeoType < b.GeoType) return true;
            else return false;
        }
        private bool compareMaterialAscent(Shape a, Shape b)
        {
            if (a.MaterialType > b.MaterialType) return true;
            else return false;
        }
        private bool compareMaterialDescent(Shape a, Shape b)
        {
            if (a.MaterialType < b.MaterialType) return true;
            else return false;
        }
        private bool compareVolumeAscent(Shape a, Shape b)
        {
            if (a.Volume() > b.Volume()) return true;
            else return false;
        }
        private bool compareVolumeDescent(Shape a, Shape b)
        {
            if (a.Volume() < b.Volume()) return true;
            else return false;
        }
        private bool compareWeightAscent(Shape a, Shape b)
        {
            if (a.Weight() > b.Weight()) return true;
            else return false;
        }
        private bool compareWeightDescent(Shape a, Shape b)
        {
            if (a.Weight() < b.Weight()) return true;
            else return false;
        }
        private void sorting(comparefunc cmp)
        {
            Shape temp;
            for(int i = 0; i < shapeArr.Count; i++)
            {
                for(int j=0;j<shapeArr.Count - 1; j++)
                {
                    if(cmp(shapeArr[j], shapeArr[j + 1]))
                    {
                        temp = shapeArr[j];
                        shapeArr[j] = shapeArr[j + 1];
                        shapeArr[j + 1] = temp;
                    }
                }
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            switch (cbx_sort.SelectedItem.ToString())
            {
                case "Shape":
                    if (ascent.Checked) sorting(compareShapeAscent);
                    else sorting(compareShapeDescent);
                    break;
                case "Material":
                    if (ascent.Checked) sorting(compareMaterialAscent);
                    else sorting(compareMaterialDescent);
                    break;
                case "Volume":
                    if (ascent.Checked) sorting(compareVolumeAscent);
                    else sorting(compareVolumeDescent);
                    break;
                case "Weight":
                    if (ascent.Checked) sorting(compareWeightAscent);
                    else sorting(compareWeightDescent);
                    break;
                default:
                    break;
            }
            ShowAllShapeInfo(sort_txt);
        }
        private int compareDistance(Rollable a, Rollable b)
        {
            if (a.Distance() > b.Distance()) return -1;
            else return 1;
        }

        private void btn_roll_Click(object sender, EventArgs e)
        {
            Rollable roll = null;
            rollArr.Clear();
            foreach(var s in shapeArr)
            {
                roll = s as Rollable;
                if (null != roll) rollArr.Add(roll);
            }
            rollArr.Sort(compareDistance);
            ShowRollProperty(roll_txt);
        }
        private void ShowRollProperty(TextBox d)
        {
            string str = "";
            foreach (var r in rollArr) str += (r.RollShapeProperty() + "\r\n");
            d.Text = str;
        }
    }
}
