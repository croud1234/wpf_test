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
using System.Diagnostics;


namespace OpacityWindow
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        Point start;
        Point end;
        Boolean once;
        private Point _position;
        private bool _trimEnable = false;


        public MainWindow()
        {
            InitializeComponent();
            this.once = false;

        }

        private void MouseDownTest(object sender, MouseButtonEventArgs e)
        {
            Point sp = this.PointToScreen(Mouse.GetPosition(this));
            //Debug.WriteLine(sp);
            start = sp;
        }

        private void MouseUpTest(object sender, MouseButtonEventArgs e)
        {
            if (this.once) return;
            this.once = true;

            end = this.PointToScreen(Mouse.GetPosition(this));
            // this.Label1.Content = "start: "+ this.start.ToString() + " end: " + this.end.ToString();
            /*
            Debug.WriteLine(this.start);
            Debug.WriteLine(this.end);
             * */
            var tmpw = new Window1();
            tmpw.Height = this.end.Y - this.start.Y;
            tmpw.Width = this.end.X - this.start.X;
            tmpw.Left = this.start.X;
            tmpw.Top = this.start.Y;
            tmpw.Show();
            this.Opacity = 0.1;
            // new Window1().Show();
            // new Page1();
        }

    }
}
