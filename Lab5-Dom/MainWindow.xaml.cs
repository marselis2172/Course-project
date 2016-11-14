using Lab5;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab5_Dom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        Graph graph = new Graph();
        public Point mousePress;
        public Node curNode;

        public MainWindow()
        {
            InitializeComponent();

            var node1 = new Node { Pos = new Point(47, 350), Text="1"};
            var node2 = new Node { Pos = new Point(144, 208), Text = "2"};
            var node3 = new Node { Pos = new Point(242, 207), Text = "0" };
            var node4 = new Node { Pos = new Point(302, 122), Text = "4" };
            var node5 = new Node { Pos = new Point(405, 121), Text = "0" };
            var node6 = new Node { Pos = new Point(513, 52), Text = "6" };
            var node7 = new Node { Pos = new Point(514, 119), Text = "7" };
            var node8 = new Node { Pos = new Point(468, 188), Text = "8" };
            var node9 = new Node { Pos = new Point(564, 186), Text = "9" };
            var node10 = new Node { Pos = new Point(660, 124), Text = "0*" };
            var node11 = new Node { Pos = new Point(483, 310), Text = "11" };
            var node12 = new Node { Pos = new Point(743, 208), Text = "0*" };
            var node13 = new Node { Pos = new Point(808, 209), Text = "13" };
            var node14 = new Node { Pos = new Point(858, 350), Text = "14" };
            var node15 = new Node { Pos = new Point(400, 350), Text = "+-" };
            graph.Nodes.Add(node1);
            graph.Nodes.Add(node2);
            graph.Nodes.Add(node3);
            graph.Nodes.Add(node4);
            graph.Nodes.Add(node5);
            graph.Nodes.Add(node6);
            graph.Nodes.Add(node7);
            graph.Nodes.Add(node8);
            graph.Nodes.Add(node9);
            graph.Nodes.Add(node10);
            graph.Nodes.Add(node11);
            graph.Nodes.Add(node12);
            graph.Nodes.Add(node13);
            graph.Nodes.Add(node14);
            graph.Nodes.Add(node15);
            //graph.Nodes[0].left.Add(graph.Nodes[14]); graph.Nodes[0].right.Add(graph.Nodes[1]);
            //graph.Nodes[1].left.Add(graph.Nodes[0]); graph.Nodes[1].right.Add(graph.Nodes[2]);
            //graph.Nodes[2].left.Add(graph.Nodes[1]); graph.Nodes[2].right.Add(graph.Nodes[3]); graph.Nodes[2].right.Add(graph.Nodes[10]);
            //graph.Nodes[3].left.Add(graph.Nodes[2]); graph.Nodes[3].right.Add(graph.Nodes[4]);
            //graph.Nodes[4].left.Add(graph.Nodes[3]); graph.Nodes[4].right.Add(graph.Nodes[5]); graph.Nodes[4].right.Add(graph.Nodes[6]); graph.Nodes[4].right.Add(graph.Nodes[7]);
            //graph.Nodes[5].left.Add(graph.Nodes[4]); graph.Nodes[5].right.Add(graph.Nodes[9]);
            //graph.Nodes[6].left.Add(graph.Nodes[4]); graph.Nodes[6].right.Add(graph.Nodes[9]);
            //graph.Nodes[7].left.Add(graph.Nodes[4]); graph.Nodes[7].right.Add(graph.Nodes[8]);
            //graph.Nodes[8].left.Add(graph.Nodes[7]); graph.Nodes[8].right.Add(graph.Nodes[9]);
            //graph.Nodes[9].left.Add(graph.Nodes[5]); graph.Nodes[9].left.Add(graph.Nodes[6]); graph.Nodes[9].left.Add(graph.Nodes[8]); graph.Nodes[9].right.Add(graph.Nodes[11]);
            //graph.Nodes[10].left.Add(graph.Nodes[2]); graph.Nodes[10].right.Add(graph.Nodes[11]);
            //graph.Nodes[11].left.Add(graph.Nodes[9]); graph.Nodes[11].left.Add(graph.Nodes[10]); graph.Nodes[11].right.Add(graph.Nodes[12]);
            //graph.Nodes[12].left.Add(graph.Nodes[11]); graph.Nodes[12].right.Add(graph.Nodes[13]);
            //graph.Nodes[13].left.Add(graph.Nodes[12]); graph.Nodes[13].right.Add(graph.Nodes[14]);
            //graph.Nodes[14].left.Add(graph.Nodes[13]); graph.Nodes[14].right.Add(graph.Nodes[0]);

            graph.Nodes[0].link = new ObservableCollection<Node>(); graph.Nodes[0].link.Add(graph.Nodes[14]); graph.Nodes[0].link.Add(graph.Nodes[1]);
            graph.Nodes[1].link = new ObservableCollection<Node>(); graph.Nodes[1].link.Add(graph.Nodes[0]); graph.Nodes[1].link.Add(graph.Nodes[2]);
            graph.Nodes[2].link = new ObservableCollection<Node>(); graph.Nodes[2].link.Add(graph.Nodes[1]); graph.Nodes[2].link.Add(graph.Nodes[3]); graph.Nodes[2].link.Add(graph.Nodes[10]);
            graph.Nodes[3].link = new ObservableCollection<Node>(); graph.Nodes[3].link.Add(graph.Nodes[2]); graph.Nodes[3].link.Add(graph.Nodes[4]);
            graph.Nodes[4].link = new ObservableCollection<Node>(); graph.Nodes[4].link.Add(graph.Nodes[3]); graph.Nodes[4].link.Add(graph.Nodes[5]); graph.Nodes[4].link.Add(graph.Nodes[6]); graph.Nodes[4].link.Add(graph.Nodes[7]);
            graph.Nodes[5].link = new ObservableCollection<Node>(); graph.Nodes[5].link.Add(graph.Nodes[4]); graph.Nodes[5].link.Add(graph.Nodes[9]);
            graph.Nodes[6].link = new ObservableCollection<Node>(); graph.Nodes[6].link.Add(graph.Nodes[4]); graph.Nodes[6].link.Add(graph.Nodes[9]);
            graph.Nodes[7].link = new ObservableCollection<Node>(); graph.Nodes[7].link.Add(graph.Nodes[4]); graph.Nodes[7].link.Add(graph.Nodes[8]);
            graph.Nodes[8].link = new ObservableCollection<Node>(); graph.Nodes[8].link.Add(graph.Nodes[7]); graph.Nodes[8].link.Add(graph.Nodes[9]);
            graph.Nodes[9].link = new ObservableCollection<Node>(); graph.Nodes[9].link.Add(graph.Nodes[5]); graph.Nodes[9].link.Add(graph.Nodes[6]); graph.Nodes[9].link.Add(graph.Nodes[8]); graph.Nodes[9].link.Add(graph.Nodes[11]);
            graph.Nodes[10].link = new ObservableCollection<Node>(); graph.Nodes[10].link.Add(graph.Nodes[2]); graph.Nodes[10].link.Add(graph.Nodes[11]);
            graph.Nodes[11].link = new ObservableCollection<Node>(); graph.Nodes[11].link.Add(graph.Nodes[9]); graph.Nodes[11].link.Add(graph.Nodes[10]); graph.Nodes[11].link.Add(graph.Nodes[12]);
            graph.Nodes[12].link = new ObservableCollection<Node>(); graph.Nodes[12].link.Add(graph.Nodes[11]); graph.Nodes[12].link.Add(graph.Nodes[13]);
            graph.Nodes[13].link = new ObservableCollection<Node>(); graph.Nodes[13].link.Add(graph.Nodes[12]); graph.Nodes[13].link.Add(graph.Nodes[14]);
            graph.Nodes[14].link = new ObservableCollection<Node>(); graph.Nodes[14].link.Add(graph.Nodes[13]); graph.Nodes[14].link.Add(graph.Nodes[0]);

            CreateMesh();
            DataContext = graph;
        }

        private void CreateMesh()
        {
            Line vertLine = new Line();
            for (int i = 0; i < wind.Width; i += 50)
            {
                vertLine = new Line();
                vertLine.StrokeThickness = 2;
                vertLine.Stroke = Brushes.LightBlue;
                vertLine.X1 = i;
                vertLine.Y1 = 0;
                vertLine.X2 = i;
                vertLine.Y2 = wind.Height;
                grid.Children.Add(vertLine);
            }

            for (int i = 0; i < wind.Height; i += 50)
            {
                vertLine = new Line();
                vertLine.StrokeThickness = 2;
                vertLine.Stroke = Brushes.LightBlue;
                vertLine.X1 = 0;
                vertLine.Y1 = i;
                vertLine.X2 = wind.Width;
                vertLine.Y2 = i;
                grid.Children.Add(vertLine);
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                mousePress = e.GetPosition(ic); // запоминаем позицию курсора
                var border = sender as Border; // источник события
                curNode = border.DataContext as Node; // получаем привязанный экземпляр
                border.CaptureMouse(); // захватим мышку, чтобы при движении не "отлипал" узел
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                {
                    curNode.InvSelect();
                    var nodes = graph.Nodes.Where(x => x.Selected).ToList();
                    if (nodes.Count() == 2)
                    {
                        bool connection = false;
                        foreach (var item in nodes[0].link)
                        {
                            if (item == nodes[1])
                            {
                                connection = true;
                                nodes[0].link.Remove(item);
                                nodes[1].link.Remove(nodes[0]);
                                break;
                            }
                        }
                        if (connection == false)
                        {
                            nodes[0].link.Add(nodes[1]);
                            nodes[1].link.Add(nodes[0]);
                        }
                        nodes[0].InvSelect();
                        nodes[1].InvSelect();
                    }
                }
                e.Handled = true; // сообщаем, что обработали
            }
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var p = e.GetPosition(ic);
                curNode.MoveRef(p - mousePress);
                mousePress = p;
            }
        }

        private void Border_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var border = sender as Border;
            double xCoord = Math.Round(curNode.Pos.X / 50) * 50;
            double yCoord = Math.Round(curNode.Pos.Y / 50) * 50;
            curNode.Pos = new Point(xCoord, yCoord);
            curNode.MoveRef(new Vector(0, 0));
            border.ReleaseMouseCapture(); // освобождаем мышь для других элементов управления
        }

        private void ItemsControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                var p = e.GetPosition(ic);
                double xCoord = Math.Round(p.X / 50) * 50;
                double yCoord = Math.Round(p.Y / 50) * 50;
                mousePress = p;
                curNode = new Node { Pos = p, Text = "Node " + (graph.Nodes.Count() + 1), Img = new BitmapImage(new Uri("Resources/block.png", UriKind.Relative)), margin = new Thickness(30, 25, 0, 0) };
                graph.Nodes.Add(curNode);
                graph.Nodes.Last().link = new ObservableCollection<Node>();
            }
        }

        private List<object> circuit(Node node, Node edge)
        {
            double resist = 0;
            List<object> list = new List<object>();
            Node temp;
            while ((node.Text != "0*") && (node.Text != "+-"))
            {
                while ((node.Text != "0") && (node.Text != "0*") && (node.Text != "+-"))
                {
                    resist += Convert.ToDouble(node.Text);
                    temp = edge;
                    edge = node;
                    node = node.link.Where(x => x != temp).FirstOrDefault();
                }

                List<object> tempoedges = new List<object>();
                if ((node.Text != "0*") && (node.Text != "+-"))
                {
                    var edges = node.link.Where(x => x != edge).ToArray();
                    Node nodemodel = node;
                    double temporesist = 0;
                    foreach (var item in edges)
                    {
                        list = circuit(item, node);
                        tempoedges.Add(list[1]);
                        temporesist += 1 / Convert.ToDouble(list[2]);
                    }
                    node = (Node)list[0];
                    resist += 1 / temporesist;
                    edge = (Node)node.link.Except(tempoedges).FirstOrDefault();
                    temp = edge;
                    edge = node;
                    node = temp;
                }
            }

            list = new List<object>(3);
            list.Add(node);
            list.Add(edge);
            list.Add(resist);
            return list;
        }

        //private void bypass(Node node1, Node node2)
        //{
        //    node1.left.Add(node2);
        //    node1.right = node1.link.Except(node1.left).ToList();


        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //bypass(graph.Nodes[0], graph.Nodes[0].link[0]);

            List<object> list = circuit(graph.Nodes[0], graph.Nodes[0].link[0]);
            txtBlock.Text = list[2].ToString();
        }

        private void wind_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            grid.Children.Clear();
            CreateMesh();
        }
    }
}
