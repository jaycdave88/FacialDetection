using System.Windows;

namespace FacialDetection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        WebCam webcam;
        private void mainWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
           
           webcam = new WebCam();
           webcam.InitializeWebCam(ref imgVideo);  
          
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            webcam.Start();
        }
    }
}
