using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_MLTA_3
{
    public partial class fMain : Form
    {
        private ShortestWay graph;

        public fMain()
        {
            InitializeComponent();
            InitializeGraph();
            InitializeVertexComboBox();
        }

        private void InitializeVertexComboBox()
        {
            cmbStartVertex.Items.AddRange(new string[] { "a", "b", "c", "d", "e", "f" });
            cmbStartVertex.SelectedIndex = 0; 
        }

        // a, b, c, d, e, f
        // 0, 1, 2, 3, 4, 5 
        private void InitializeGraph()
        {
            graph = new ShortestWay(6);

            // Додаємо ребра з вагами
            graph.AddEdge(0, 1, 3); // a -> b
            graph.AddEdge(0, 5, 9); // a -> f
            graph.AddEdge(1, 3, 2); // b -> d
            graph.AddEdge(1, 5, 5); // b -> f
            graph.AddEdge(2, 0, 4); // c -> a
            graph.AddEdge(2, 4, 9); // c -> e
            graph.AddEdge(2, 3, 12); // c -> d
            graph.AddEdge(3, 4, 4); // d -> e
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            tbResult.Clear();
            tbResult.AppendText("             Алгоритм Дейкстри" + Environment.NewLine); 
            int selectedIndex = cmbStartVertex.SelectedIndex;
            var distances = graph.Dekstra(selectedIndex); 
            tbResult.AppendText(graph.PrintDekstra(distances));
        }

        private void btnFloyd_Click(object sender, EventArgs e)
        {
            tbResult.Clear();
            tbResult.AppendText("              Алгоритм Флойда" + Environment.NewLine); 
            var distances = graph.Floyd(); 
            tbResult.AppendText(graph.PrintFloyd(distances)); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            Application.Exit();
        }
    }

}
