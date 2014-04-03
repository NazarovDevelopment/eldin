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

namespace Electrodynamics
{
    public partial class FormForEStatic : Form
    {
        public ArrayList AllGraphics;
        public int LeftGraphIndex;
        public int RightGraphIndex;
        public FormForEStatic()
        {
            InitializeComponent();
            AllGraphics = new ArrayList();          
        }

        private void CreateGraphic()
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormForEStatic_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ButtonBuild1_Click(object sender, EventArgs e)
        {
            double[,] points = new double[400,400];
            double max = 0;
            double min = 0;
            for (int i = 0; i < 400; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    points[i,j] = ((GraphicElStatic)AllGraphics[LeftGraphIndex]).Potential((i),(j));

                    if(points[i,j] > 10)
                        points[i,j] = 10;

                    if(points[i,j] < -10)
                        points[i,j] = -10;

                    if (points[i, j] > max)
                        max = points[i, j];
                    if (points[i, j] < min)
                        min = points[i, j];
                }
            }

            Graphics graph = pictureBox1.CreateGraphics();
            Color myRgbColor = new Color();
            for (int i = 0; i < 400; i++)
            {
                for (int j = 0; j < 400; j ++)
                {
                    int color = Convert.ToInt32(points[i, j] * 255 / (max - min));                 
                    myRgbColor = Color.FromArgb(0,255 -color, 0);
                    Pen MyPen = new Pen(myRgbColor, 1);
                    SolidBrush MyBrush = new SolidBrush(myRgbColor);
                    graph.DrawLine(MyPen, new Point(i, j), new Point(i,j+1));               
                }
            }          
        }

        private void newGraphic1_Click(object sender, EventArgs e)
        {
            GraphicElStatic graph;
            graph = new GraphicElStatic();         
            graph.name = "Graph #" + AllGraphics.Count.ToString();
            AllGraphics.Add(graph);

            AllGraph1.Items.Add(graph.name);
        }

        private void NewPoint1_Click(object sender, EventArgs e)
        {
            Charge point = new Charge();
            point.point.x = Convert.ToDouble(FirstPointX1.Text);
            point.point.y = Convert.ToDouble(FirstPointY1.Text);
            point.q = Convert.ToDouble(ChargeT1.Text);

            ((GraphicElStatic)AllGraphics[LeftGraphIndex]).AllElements.Add(point);

            Double x = point.point.x;
            Double y = point.point.y;
            AllElements1.Items.Add("x = " + x.ToString() + "   " + "y = " + y.ToString());

        }

        private void AllElements1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChooseGraph1_Click(object sender, EventArgs e)
        {
            AllElements1.Items.Clear();
            LeftGraphIndex = AllGraph1.SelectedIndex;

            GraphicElStatic graph =  (GraphicElStatic)AllGraphics[LeftGraphIndex];
            
            for (int i = 0; i < graph.AllElements.Count; i ++)
            {
                Charge point = (Charge)graph.AllElements[i];
                Double x = point.point.x;
                Double y = point.point.y;

                AllElements1.Items.Add("x = "+ x.ToString() + "   "+ "y = " + y.ToString());
            }
        }

        private void ChangePoint1_Click(object sender, EventArgs e)
        {
            int index = AllElements1.SelectedIndex;

            Charge point = (Charge)(((GraphicElStatic)AllGraphics[LeftGraphIndex]).AllElements[index]);

            FirstPointX1.Text = Convert.ToString(point.point.x);
            FirstPointY1.Text = Convert.ToString(point.point.y);
            ChargeT1.Text = Convert.ToString(point.q);
        }

        private void SaveElement1_Click(object sender, EventArgs e)
        {
            int index = AllElements1.SelectedIndex;
            Charge point = new Charge();
            point.point.x = Convert.ToDouble(FirstPointX1.Text);
            point.point.y = Convert.ToDouble(FirstPointY1.Text);
            point.q = Convert.ToDouble(ChargeT1.Text);

            ((GraphicElStatic)AllGraphics[LeftGraphIndex]).AllElements[index] = point;

            AllElements1.Items.RemoveAt(index);
            AllElements1.Items.Insert(index, "x = " + Convert.ToString(point.point.x) + "   " + "y = " + Convert.ToString(point.point.y));
        }
    }
}
