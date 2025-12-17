using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace PulseBoost
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Img1.RenderTransform = new TranslateTransform();
            Img2.RenderTransform = new TranslateTransform();
            Img3.RenderTransform = new TranslateTransform();
            Img4.RenderTransform = new TranslateTransform();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.GetPosition(this);

            double cx = ActualWidth / 2;
            double cy = ActualHeight / 2;

            double dx = (p.X - cx) / cx;
            double dy = (p.Y - cy) / cy;

            Move(Img1, dx * 10, dy * 10);
            Move(Img2, dx * 16, dy * 8);
            Move(Img3, dx * 8, dy * 16);
            Move(Img4, dx * 14, dy * 14);
        }

        private void Move(UIElement el, double x, double y)
        {
            if (el.RenderTransform is TranslateTransform t)
            {
                t.X = x;
                t.Y = y;
            }
        }
    }
}
