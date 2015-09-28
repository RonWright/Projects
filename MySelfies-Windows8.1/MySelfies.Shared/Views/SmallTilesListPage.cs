using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.Instagram;
using MySelfies;
using MySelfies.Sections;
using MySelfies.ViewModels;

namespace MySelfies.Views
{
    public sealed partial class SmallTilesListPage : PageBase
    {
        public ListViewModel<InstagramDataConfig, InstagramSchema> ViewModel { get; set; }

        public SmallTilesListPage()
        {
            this.ViewModel = new ListViewModel<InstagramDataConfig, InstagramSchema>(new SmallTilesConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
