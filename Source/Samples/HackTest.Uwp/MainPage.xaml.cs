using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using SharpDXTutorial2;

namespace HackTest.Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MyGame _game;

        public MainPage()
        {
            this.InitializeComponent();

            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            _game = new MyGame();
            _game.Run(this._swapChainPanel);
        }
    }
}
