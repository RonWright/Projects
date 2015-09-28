using Windows.UI.Xaml.Controls;
using MySelfies.ViewModels;

namespace MySelfies
{
    public sealed partial class AboutThisAppPage : Page
    {
        public AboutThisAppViewModel AboutModel { get; private set; }
        public AboutThisAppPage()
        {
            AboutModel = new AboutThisAppViewModel();
            this.InitializeComponent();
        }
    }
}

