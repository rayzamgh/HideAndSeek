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
using System.IO;

namespace Hide_and_Seek
{
    public partial class Main : Form
    {

        private Form graphForm = null;

        private Graph currentGraph = null;

        public Main()
        {
            InitializeComponent();

            centralize(titleLabel, this);
            centralize(solveButton, this);
            centralize(hasilLabel, this);

            graphBrowseButton.Click += new EventHandler(graphBrowseButton_Click);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            /*int[][] arin = new int[][]
            {
                new int[] {1, 2},
                new int[] {1, 7},
                new int[] {1, 3},
                new int[] {2, 9},
                new int[] {5, 4},
                new int[] {5, 6},
                new int[] {7, 8},
                new int[] {3, 5},
            };*/

            solveButton.Click += solveButton_Click;
        }

        private void drawGraph(Graph _graph)
        {
            List<List<bool>> drawnEdges = new List<List<bool>>();

            for (int i = 0; i < _graph.edges.Count; i++)
            {
                List<bool> temp = new List<bool>();
                temp.Add(true);
                for (int j = 1; j < _graph.edges[i].Count; j++)
                {
                    temp.Add(false);
                }

                drawnEdges.Add(temp);
            }

            graphForm = new Form();
            Microsoft.Msagl.GraphViewerGdi.GViewer graphViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph();

            for (int i = 0; i < _graph.edges.Count(); i++)
            {
                for (int j = 1; j < _graph.edges[i].Count(); j++)
                {
                    if (!drawnEdges[i][j])
                    {
                        int nodeAsal = _graph.edges[i][0];
                        int nodeTujuan = _graph.edges[i][j];
                        Microsoft.Msagl.Drawing.Edge newEdge = graph.AddEdge(nodeAsal.ToString(), nodeTujuan.ToString());
                        newEdge.Attr.ArrowheadAtSource = Microsoft.Msagl.Drawing.ArrowStyle.None;
                        newEdge.Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;

                        drawnEdges[nodeAsal - 1][j] = true;
                        drawnEdges[nodeTujuan - 1][_graph.edges[nodeTujuan - 1].FindIndex(n => n == nodeAsal)] = true;
                    }
                }
            }

            graphViewer.Graph = graph;

            graphForm.Controls.Add(graphViewer);

            graphForm.Size = new Size(graphViewer.Size.Width, graphViewer.Size.Height + 30);
            
            if (graphForm != null)
            {
                graphForm.Show();
            }
        }

        private void centralize(Control _control, Control _parent)
        {
            _control.Location = new Point((_parent.Width - _control.Width) / 2, _control.Location.Y);
        }

        private string locationToString(Control _control)
        {
            return _control.Location.X + " " + _control.Location.Y;
        }

        private void graphBrowseButton_Click(object sender, EventArgs o)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Text files (*.txt) | *.txt",
                Title = "Buka teks graf!"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = ofd.FileName;
            }
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            if (graphForm != null)
            {
                graphForm.Close();
            }

            if (pathBox.Text != "")
            {
                FileReader FiRe = new FileReader();
                if (File.Exists(pathBox.Text)){
                    FiRe.ParseNumberFile(pathBox.Text);

                    GC.Collect();
                    currentGraph = new Graph(FiRe.nVertex, FiRe.inputArray);

                    string query = queryBox.Text;

                    if (queryValid(query))
                    {
                        string[] querySplit = query.Split(' ');
                        if (currentGraph.IsFerguso(Int32.Parse(querySplit[0]), Int32.Parse(querySplit[1]), Int32.Parse(querySplit[2])))
                        {
                            hasilLabel.Text = "Hasil: YA";
                        }else
                        {
                            hasilLabel.Text = "Hasil: TIDAK";
                        }

                        centralize(hasilLabel, this);

                        drawGraph(currentGraph);
                    }
                    else
                    {
                        MessageBox.Show("Query tidak valid!", "Error");
                    }
                }else
                {
                    MessageBox.Show("File tidak ditemukan!", "Error");
                }
            }else
            {
                MessageBox.Show("Path masih kosong!", "Error");
            }
        }

        private bool queryValid(string _query)
        {
            if (_query == "")
            {
                return false;
            }

            string[] splitQuery = _query.Split(' ');

            bool firstCheck = Int32.Parse(splitQuery[0]) == 0 | Int32.Parse(splitQuery[0]) == 1;
            bool secondCheck = Int32.Parse(splitQuery[1]) > 0;
            bool thirdCheck = Int32.Parse(splitQuery[2]) > 0;
            if (currentGraph != null)
            {
                secondCheck = secondCheck && Int32.Parse(splitQuery[1]) >= currentGraph.edges[0][0] && Int32.Parse(splitQuery[1]) <= currentGraph.edges[currentGraph.edges.Count - 1][0];
                thirdCheck = thirdCheck && Int32.Parse(splitQuery[2]) >= currentGraph.edges[0][0] && Int32.Parse(splitQuery[2]) <= currentGraph.edges[currentGraph.edges.Count - 1][0];
            }

            return firstCheck && secondCheck && thirdCheck;
        }
    }
}
