using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Msagl;
using System.Threading;

namespace Hide_and_Seek
{
    public partial class Main : Form
    {

        Form graphForm = null;
        Thread graphThread = null;

        public Main()
        {
            InitializeComponent();

            Control label1 = this.Controls["label1"];
            centralize(label1, this);

            Control button1 = this.Controls["button1"];
            centralize(button1, this);
            //label1.Text = button1.Location.Y.ToString();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            FormClosing += Main_FormClosing;

            int[][] arin = new int[][]
            {
                new int[] {1, 2},
                new int[] {1, 7},
                new int[] {1, 3},
                new int[] {2, 9},
                new int[] {5, 4},
                new int[] {5, 6},
                new int[] {7, 8},
                new int[] {3, 5},
            };

            Graph pepega = new Graph(9, arin);

            graphThread = new Thread(() =>
            {
                drawGraph(pepega);
            });

            graphThread.Start();
        }

        public void drawGraph(Graph _graph)
        {
            graphForm = new Form();
            Microsoft.Msagl.GraphViewerGdi.GViewer graphViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph();

            for (int i = 0; i < _graph.edges.Count(); i++)
            {
                graph.AddEdge(_graph.edges[i][0].ToString(), _graph.edges[i][1].ToString());
            }

            graphViewer.Graph = graph;

            graphForm.Controls.Add(graphViewer);
            
            if (graphForm != null)
            {
                Application.Run(graphForm);
            }
        }

        public void centralize(Control _control, Control _parent)
        {
            Console.Out.WriteLine(_parent.Width.ToString() + " " + _parent.Height.ToString());
            _control.Location = new Point(_parent.Location.X + (_parent.Width - _control.Width) / 2, _control.Location.Y);
            Console.Out.WriteLine(locationToString(_control));
        }

        public string locationToString(Control _control)
        {
            return _control.Location.X + " " + _control.Location.Y;
        }

        private void Main_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Console.Out.WriteLine("Closing");

            graphThread.Abort();
        }
    }
}
