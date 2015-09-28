using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppStudio.Common;
using AppStudio.Common.Actions;
using AppStudio.Common.Commands;
using AppStudio.Common.Navigation;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Instagram;
using AppStudio.DataProviders.LocalStorage;
using MySelfies.Sections;


namespace MySelfies.ViewModels
{
    public class MainViewModel : ObservableBase
    {
        public MainViewModel(int visibleItems)
        {
            PageTitle = "MySelfies";
            BigTiles = new ListViewModel<InstagramDataConfig, InstagramSchema>(new BigTilesConfig(), visibleItems);
            SmallTiles = new ListViewModel<InstagramDataConfig, InstagramSchema>(new SmallTilesConfig(), visibleItems);
            SmallTiles1 = new ListViewModel<InstagramDataConfig, InstagramSchema>(new SmallTiles1Config(), visibleItems);
            BigTiles1 = new ListViewModel<InstagramDataConfig, InstagramSchema>(new BigTiles1Config(), visibleItems);
            SmallTileGrid = new ListViewModel<InstagramDataConfig, InstagramSchema>(new SmallTileGridConfig(), visibleItems);
            Actions = new List<ActionInfo>();

            if (GetViewModels().Any(vm => !vm.HasLocalData))
            {
                Actions.Add(new ActionInfo
                {
                    Command = new RelayCommand(Refresh),
                    Style = ActionKnownStyles.Refresh,
                    Name = "RefreshButton",
                    ActionType = ActionType.Primary
                });
            }
        }

        public string PageTitle { get; set; }
        public ListViewModel<InstagramDataConfig, InstagramSchema> BigTiles { get; private set; }
        public ListViewModel<InstagramDataConfig, InstagramSchema> SmallTiles { get; private set; }
        public ListViewModel<InstagramDataConfig, InstagramSchema> SmallTiles1 { get; private set; }
        public ListViewModel<InstagramDataConfig, InstagramSchema> BigTiles1 { get; private set; }
        public ListViewModel<InstagramDataConfig, InstagramSchema> SmallTileGrid { get; private set; }

        public RelayCommand<INavigable> SectionHeaderClickCommand
        {
            get
            {
                return new RelayCommand<INavigable>(item =>
                    {
                        NavigationService.NavigateTo(item);
                    });
            }
        }

        public DateTime? LastUpdated
        {
            get
            {
                return GetViewModels().Select(vm => vm.LastUpdated)
                            .OrderByDescending(d => d).FirstOrDefault();
            }
        }

        public List<ActionInfo> Actions { get; private set; }

        public bool HasActions
        {
            get
            {
                return Actions != null && Actions.Count > 0;
            }
        }

        public async Task LoadDataAsync()
        {
            var loadDataTasks = GetViewModels().Select(vm => vm.LoadDataAsync());

            await Task.WhenAll(loadDataTasks);

            OnPropertyChanged("LastUpdated");
        }

        private async void Refresh()
        {
            var refreshDataTasks = GetViewModels()
                                        .Where(vm => !vm.HasLocalData)
                                        .Select(vm => vm.LoadDataAsync(true));

            await Task.WhenAll(refreshDataTasks);

            OnPropertyChanged("LastUpdated");
        }

        private IEnumerable<DataViewModelBase> GetViewModels()
        {
            yield return BigTiles;
            yield return SmallTiles;
            yield return SmallTiles1;
            yield return BigTiles1;
            yield return SmallTileGrid;
        }
    }
}
