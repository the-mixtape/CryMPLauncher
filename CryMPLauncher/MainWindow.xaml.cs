using System.IO;
using System.Windows;
using System.Windows.Input;

namespace CryMPLauncher
{
    enum LauncherStatus
    {
        Ready,
        Failed,
        DownloadingGame,
        DownloadingUpdate
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private string _rootPath;
        private string _versionFile;
        private string _gameZip;
        private string _gameExe;

        public MainWindow()
        {
            InitializeComponent();
            // this.Icon = BitmapFrame.Create(new Uri("pack://application:,,,/Resources/Image/close.png"));
            _rootPath = Directory.GetCurrentDirectory();
            _versionFile = Path.Combine(_rootPath, "version.txt");
            _gameZip = Path.Combine(_rootPath, "CMPPackage.txt");
            _gameExe = Path.Combine(_rootPath, "Game", "Game.exe");
        }

        private void ButtonMinimize_OnClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MainWindow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}