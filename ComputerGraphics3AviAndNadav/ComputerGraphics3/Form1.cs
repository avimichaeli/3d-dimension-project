using ComputerGraphics3.Castings;
using ComputerGraphics3.Exceptions;
using ComputerGraphics3.Shapes;
using ComputerGraphics3.Transformations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ComputerGraphics3
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// </summary>
    public partial class Form1 : Form
    {
        private JavaScriptSerializer serializer = new JavaScriptSerializer();
        private FileContentAndPath fc;
        private Orthographic orthographic = new Orthographic();
        private Oblique oblique = new Oblique();
        private Prespective prespective = new Prespective();
        private ScalingTransform scaling = new ScalingTransform();
        private RotateTransform rotate = new RotateTransform();
        private Translation translation = new Translation();
        private Graphics graphics;
        private int panelHeight, panelWidth;
        bool IsLoaded = false;


        public Form1()
        {
            InitializeComponent();
            panelHeight = panel1.Height;
            panelWidth = panel1.Width;
            cmbx.Items.Add("X");
            cmbx.Items.Add("Y");
            cmbx.Items.Add("Z");
            cmbx.SelectedIndex = 0;
        }

        private void Init()
        {
            this.Refresh();
            Utils.SortByMaxZ(fc.Polygons);
            Utils.Draw(fc, graphics, panelHeight, panelWidth);

            //Utils.ReLoadSameFile(fc);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Repaint_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            graphics = panel1.CreateGraphics();
            //Utils.ReLoadSameFile(fc);
            // tbPath.Text = Path.GetFileName(fc.Path);
            Utils.Draw(fc, graphics, panelHeight, panelWidth);
        }

        private void ScaleBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            float sx = float.Parse(Sx.Text);
            float sy = float.Parse(Sy.Text);
            float sz = float.Parse(Sz.Text);


            scaling.Scale(fc, sx, sy, sz);
            Init();


        }

        /// <summary>
        /// the exceptions in the project 
        /// </summary>
        /// <returns></returns>
        bool ValidateInput()
        {
            try
            {
                if (!File.Exists(fc.Path))
                {
                    MessageBox.Show("Invalid file path");
                    return false;
                }
                int angle = Convert.ToInt32(Math.Round(cabinetUpDown.Value, 0));
                if (angle > 360 || angle < -360)
                    throw new InvalidValueException("ERROR: angle must be between -360 to 360");
                if (float.Parse(cofficientTb.Text) < 0)
                    throw new InvalidValueException("ERROR: cofficient cannot be negative");
                if (tbPath.Text == "")
                    throw new FileNotSelectedException("File must be selcted");

                angle = Convert.ToInt32(Math.Round(numericUpDownAngleRotate.Value, 0));
                if (angle > 360 || angle < -360)
                    throw new InvalidValueException("ERROR: angle must be between -360 to 360");
                float sx = float.Parse(Sx.Text);
                float sy = float.Parse(Sy.Text);
                float sz = float.Parse(Sz.Text);
                if (sx > 3 || sy > 3 || sz > 3 || sx < 0.4 || sy < 0.4 || sz < 0.4)
                    throw new InvalidValueException("ERROR: Value must be between 0.4 to 3");




                if (int.Parse(txTb.Text) > 100 || int.Parse(txTb.Text) < 1)
                    throw new InvalidValueException("ERROR: Value must be between 1 to 100");
                if (int.Parse(tyTb.Text) > 100 || int.Parse(tyTb.Text) < 1)
                    throw new InvalidValueException("ERROR: Value must be between 1 to 100");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private void RotateBtn_Click(object sender, EventArgs e)
        {


            if (!ValidateInput()) return;
            float angle = (float)Math.Round(numericUpDownAngleRotate.Value, 0) * (float)Math.PI / 180;
            //float angle = (float.Parse(numericUpDownAngleRotate.Value) * (float)Math.PI) / 180;

            MyPoint3D myPoint3 = new MyPoint3D();
            int selectedIndex = cmbx.SelectedIndex;
            string selectedValue = (string)cmbx.SelectedItem;
            switch (selectedValue)
            {
                case "X":
                    myPoint3.X = angle;
                    myPoint3.Y = 0;
                    myPoint3.Z = 0;
                    break;
                case "Y":
                    myPoint3.X = 0;
                    myPoint3.Y = angle;
                    myPoint3.Z = 0;
                    break;
                case "Z":
                    myPoint3.X = 0;
                    myPoint3.Y = 0;
                    myPoint3.Z = angle;
                    break;
            }


            rotate.Rotate(fc, angle, myPoint3);
            Init();

        }

        private void Left_Btn(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            translation.Translate(int.Parse(txTb.Text) * (-1), 0, fc);
            Init();
        }

        private void Up_Btn(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            translation.Translate(0, (int.Parse(tyTb.Text) * (-1)), fc);
            Init();
        }

        private void Down_Btn(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            translation.Translate(0, int.Parse(tyTb.Text), fc);
            Init();
        }

        private void Right_Btn(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            translation.Translate(int.Parse(txTb.Text), 0, fc);
            Init();
        }



        private void browse_Click(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
            fc = Utils.LoadFile(true,null);
            prespective.PrespectiveExc(fc, -1000f);
            tbPath.Text = Path.GetFileName(fc.Path);
            Utils.Draw(fc, graphics, panelHeight, panelWidth);
        }

        private void Prespec_change(object sender, EventArgs e)
        {
            if (rbPresp.Checked)
            {
                if (!ValidateInput()) return;
                prespective.PrespectiveExc(fc, -1000f);
                Reload(true);
                Init();
            }
        }

        private void rbObliq_Change(object sender, EventArgs e)
        {
            if (rbObliq.Checked)
            {
                if (!ValidateInput()) return;
                int angle = Convert.ToInt32(Math.Round(cabinetUpDown.Value, 0));
                float cofficient = float.Parse(cofficientTb.Text);
                Reload(true);
                oblique.ObliqueCabinet(fc, angle, cofficient);              
                Init();
            }
        }

        private void Orth_Change(object sender, EventArgs e)
        {
            if (rbOrth.Checked)
            {
                if (!ValidateInput()) return;        
                orthographic.OrthographicExc(fc);
                Reload(false);
                Init();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Reload(bool presp)
        {
            graphics = panel1.CreateGraphics();
            fc = Utils.LoadFile(false,fc);
            if (presp)
                prespective.PrespectiveExc(fc, -1000f);
            tbPath.Text = Path.GetFileName(fc.Path);
            Utils.Draw(fc, graphics, panelHeight, panelWidth);
        }
    }
}
