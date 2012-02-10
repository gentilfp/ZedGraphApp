using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace ZedGraphPlot
{
    public partial class Form1 : Form
    {
        // pane used to draw your chart
        GraphPane myPane = new GraphPane();

        // poing pair lists
        PointPairList listPointsOne = new PointPairList();
        PointPairList listPointsTwo = new PointPairList();

        // line item
        LineItem myCurveOne;
        LineItem myCurveTwo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set your pane
            myPane = zedGraphControl1.GraphPane;
            
            // set a title
            myPane.Title.Text = "This is an example!";

            // set X and Y axis titles
            myPane.XAxis.Title.Text = "X Axis";
            myPane.YAxis.Title.Text = "Y Axis";

            // ---- CURVE ONE ----
            // draw a sin curve
            for (int i = 0; i < 100; i++)
            {
                listPointsOne.Add(i, Math.Sin(i));
            }

            // set lineitem to list of points
            myCurveOne = myPane.AddCurve(null, listPointsOne, Color.Black, SymbolType.Circle);    
            // ---------------------

            // ---- CURVE TWO ----
            listPointsTwo.Add(10, 50);
            listPointsTwo.Add(50, 50);            

            // set lineitem to list of points
            myCurveTwo = myPane.AddCurve(null, listPointsTwo, Color.Blue, SymbolType.None);
            myCurveTwo.Line.Width = 5;
            // ---------------------

            // delegate to draw
            zedGraphControl1.AxisChange();              
        }
    }
}
