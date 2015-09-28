using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.Instagram;
using MySelfies;
using MySelfies.Sections;
using MySelfies.ViewModels;

namespace MySelfies.Views
{
    public sealed partial class SmallTileGridListPage : PageBase
    {
        public ListViewModel<InstagramDataConfig, InstagramSchema> ViewModel { get; set; }

        public SmallTileGridListPage()
        {
            this.ViewModel = new ListViewModel<InstagramDataConfig, InstagramSchema>(new SmallTileGridConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
