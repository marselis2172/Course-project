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
        public ObservableCollection<Node> Nodes { get { return nodes; }}
    }

    public class Node : INotifyPropertyChanged
    { 
        public ImageSource Img { get; set; } // полезные данные, характеризующие узел 
        public string Text { get; set; } // полезные данные, характеризующие узел 
        public Thickness margin { get; set; } // полезные данные, характеризующие узел 
        public Point Pos { get; set; } // позиция узла на Canvas, нужна только для View
        public ObservableCollection<Node> link { get; set; }
        public List<Node> left { get; set; }
        public List<Node> right { get; set; }
        bool selected;
        bool on;
        public bool Selected { get { return selected; } }
        public bool Oned { get { return on; } }
        public int ShadowOpacity { get { return selected ? 1 : 0; } }
        internal void InvSelect()
        {
            selected = !selected;
            PropertyChanged(this, new PropertyChangedEventArgs("ShadowOpacity"));
        }
        internal void InvOn()
        {
            on = !on;
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
        internal void NewImg(ImageSource source)
        {
            Img = source;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Img"));
            }
        }
        internal void NewText(string text)
        {
            Text = text;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Text"));
            }
        }
    }
        //public PointCollection Points
        //{
        //    get
        //    {
        //        PointCollection a = new PointCollection();
        //        a.Add(new Point(A.Pos.X, A.Pos.Y));
        //        a.Add(new Point(A.Pos.X, B.Pos.Y));
        //        a.Add(new Point(B.Pos.X, B.Pos.Y));
        //        return a;
        //    }
        //    set { }
        //}
}
