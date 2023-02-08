using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace HalconDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HRegion SingleRegion = new HRegion(10.0, 10.0, 50.0, 50.0);
            HRegion MultipleRegions = new HRegion(new HTuple(20.0, 30.0), new HTuple(20.0, 30.0),
            new HTuple(60.0, 70.0), new HTuple(60.0, 70.0));

            double Area, Row, Column;
            HTuple Areas, Rows, Columns;
            Area = SingleRegion.AreaCenter(out Row, out Column);
            Areas = MultipleRegions.AreaCenter(out Rows, out Columns);
        }
    }
}
