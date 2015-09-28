using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.Instagram;
using MySelfies;
using MySelfies.Sections;
using MySelfies.ViewModels;

namespace MySelfies.Views
{
    public sealed partial class BigTilesListPage : PageBase
    {
        public ListViewModel<InstagramDataConfig, InstagramSchema> ViewModel { get; set; }

        public BigTilesListPage()
        {
            this.ViewModel = new ListViewModel<InstagramDataConfig, InstagramSchema>(new BigTilesConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
