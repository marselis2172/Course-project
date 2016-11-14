using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    class Graph
    {
        private ObservableCollection<Node> nodes = new ObservableCollection<Node>();
        private ObservableCollection<Edge> edges = new ObservableCollection<Edge>();
        public ObservableCollection<Node> Nodes { get { return nodes; } }
        public ObservableCollection<Edge> Edges { get { return edges; } }
    }

    public class Node : INotifyPropertyChanged
    { 
        public string Text { get; set; } // полезные данные, характеризующие узел 
        public Point Pos { get; set; } // позиция узла на Canvas, нужна только для View
        bool selected;
        public bool Selected { get { return selected; } }
        public int ShadowOpacity { get { return selected ? 1 : 0; } }
        internal void InvSelect()
        {
            selected = !selected;
            PropertyChanged(this, new PropertyChangedEventArgs("ShadowOpacity"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        internal void MoveRef(Vector vector)
        {
            Pos += vector;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Pos"));
            }
        }
    }
    
    class Edge
    {
        public Node A { get; set; } // ребро соединяет узел A
        public Node B { get; set; } // c узлом B
    }
}
