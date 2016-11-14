using System;
using System.Collections.Generic;
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

namespace Lab5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Graph graph = new Graph();

        public Point mousePress;
        public Node curNode;
        

        public MainWindow()
        {
            InitializeComponent();

            var node1 = new Node { Pos = new Point(200, 100), Text = "Источник постоянного напряжения" };
            var node2 = new Node { Pos = new Point(400, 100), Text = "Лампочка" };
            var node3 = new Node { Pos = new Point(300, 200), Text = "Выключатель" };
            graph.Nodes.Add(node1);
            graph.Nodes.Add(node2);
            graph.Nodes.Add(node3);
            var edge1 = new Edge { A = node1, B = node2 };
            var edge2 = new Edge { A = node2, B = node3 };
            var edge3 = new Edge { A = node3, B = node1 };
            graph.Edges.Add(edge1);
            graph.Edges.Add(edge2);
            graph.Edges.Add(edge3);

            DataContext = graph;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                mousePress = e.GetPosition(this); // запоминаем позицию курсора
                var border = sender as Border; // источник события
                curNode = border.DataContext as Node; // получаем привязанный экземпляр
                border.CaptureMouse(); // захватим мышку, чтобы при движении не "отлипал" узел
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                {
                    curNode.InvSelect();
                    var nodes = graph.Nodes.Where(x => x.Selected).ToArray();
                    if (nodes.Length == 2)
                    {
                        var edge = graph.Edges
                        .Where(x => x.A == nodes[0] && x.B == nodes[1]
                        || x.A == nodes[1] && x.B == nodes[0])
                        .FirstOrDefault();
                        if (edge != null)
                        {
                            graph.Edges.Remove(edge);
                        }
                        else
                        {
                            edge = new Edge { A = nodes[0], B = nodes[1] };
                            graph.Edges.Add(edge);
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
                var p = e.GetPosition(this);
                curNode.MoveRef(p - mousePress);
                mousePress = p;
            }
        }

        private void Border_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var border = sender as Border;
            border.ReleaseMouseCapture(); // освобождаем мышь для других элементов управления
        }

        private void ItemsControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                var p = e.GetPosition(this);
                mousePress = p;
                curNode = new Node { Pos = p, Text = "Node " + (graph.Nodes.Count() + 1) };
                graph.Nodes.Add(curNode);
            }
        }
    }
}
