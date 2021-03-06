﻿#if !AppStore
namespace GitTrends.Mobile.Shared
{
    public class BackdoorMethodConstants
    {
        public const string SetGitHubUser = nameof(SetGitHubUser);
        public const string TriggerPullToRefresh = nameof(TriggerPullToRefresh);
        public const string GetVisibleCollection = nameof(GetVisibleCollection);
        public const string GetCurrentTrendsChartOption = nameof(GetCurrentTrendsChartOption);
        public const string IsTrendsSeriesVisible = nameof(IsTrendsSeriesVisible);
    }
}
#endif
