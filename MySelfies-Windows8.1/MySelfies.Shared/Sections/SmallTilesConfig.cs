using System;
using System.Collections.Generic;
using AppStudio.Common.Actions;
using AppStudio.Common.Commands;
using AppStudio.Common.Navigation;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Core;
using AppStudio.DataProviders.Instagram;
using MySelfies.Config;
using MySelfies.ViewModels;

namespace MySelfies.Sections
{
    public class SmallTilesConfig : SectionConfigBase<InstagramDataConfig, InstagramSchema>
    {
        public override DataProviderBase<InstagramDataConfig, InstagramSchema> DataProvider
        {
            get
            {
                return new InstagramDataProvider(new InstagramOAuthTokens
                {
                    ClientId = "5effb294d1084d45847e10dbfa137962"

                });
            }
        }

        public override InstagramDataConfig Config
        {
            get
            {
                return new InstagramDataConfig
                {
                    QueryType = InstagramQueryType.Tag,
                    Query = @"selfie"
                };
            }
        }

        public override NavigationInfo ListNavigationInfo
        {
            get
            {
                return NavigationInfo.FromPage("SmallTilesListPage");
            }
        }

        public override ListPageConfig<InstagramSchema> ListPage
        {
            get
            {
                return new ListPageConfig<InstagramSchema>
                {
                    Title = "Small Tiles",

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.Title.ToSafeString();
                        viewModel.SubTitle = "";
                        viewModel.Description = null;
                        viewModel.Image = item.ThumbnailUrl.ToSafeString();

                    },
                    NavigationInfo = (item) =>
                    {
                        return NavigationInfo.FromPage("SmallTilesDetailPage", true);
                    }
                };
            }
        }

        public override DetailPageConfig<InstagramSchema> DetailPage
        {
            get
            {
                var bindings = new List<Action<ItemViewModel, InstagramSchema>>();

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = item.Title.ToSafeString();
                    viewModel.Title = item.Title.ToSafeString();
                    viewModel.Description = item.Published.ToSafeString();
                    viewModel.Image = item.ImageUrl.ToSafeString();
                    viewModel.Content = null;
                });

            var actions = new List<ActionConfig<InstagramSchema>>
            {
                    ActionConfig<InstagramSchema>.Link("Go To Source", (item) => item.SourceUrl.ToSafeString()),
            };

                return new DetailPageConfig<InstagramSchema>
                {
                    Title = "Small Tiles",
                    LayoutBindings = bindings,
                    Actions = actions
                };
            }
        }

        public override string PageTitle
        {
            get { return "Small Tiles"; }
        }

    }
}
