using Microsoft.AspNetCore.Blazor.Components;
using System.Collections.Generic;

namespace BlazorChartControls.Pages
{
    public class ChartsComponent : BlazorComponent
    {
        protected IEnumerable<object> LineChartDataSource { get; private set; }

        protected IEnumerable<object> AreaChartDataSource { get; private set; }

        protected IEnumerable<object> BarChartDataSource { get; private set; }

        protected IEnumerable<object> DonutChartDataSource { get; private set; }

        protected override void OnInit()
        {
            LineChartDataSource = new[]
            {
                new { month = "2016-1", value = 34},
                new { month = "2016-2", value = 24},
                new { month = "2016-3", value = 3},
                new { month = "2016-4", value = 12},
                new { month = "2016-5", value = 13},
                new { month = "2016-6", value = 22},
                new { month = "2016-7", value = 5},
                new { month = "2016-8", value = 26}
            };
            AreaChartDataSource = new[]
            {
                new { year = "2014", a = 2, b = 8, c = 1},
                new { year = "2015", a = 1, b = 11, c = 3},
                new { year = "2016", a = 0, b = 22, c = 0}
            };
            BarChartDataSource = new[]
            {
                new { year = "2016-1", i = 100, pr = 34, c = 12},
                new { year = "2016-2", i = 75, pr = 11, c = 3},
                new { year = "2016-3", i = 50, pr = 99, c = 7},
                new { year = "2016-4", i = 75, pr = 56, c = 1},
                new { year = "2016-5", i = 24, pr = 0, c = 54},
                new { year = "2016-6", i = 75, pr = 31, c = 3},
                new { year = "2016-7", i = 100, pr = 77, c = 44}
            };
            DonutChartDataSource = new[]
            {
                new { label = "Followers", value = 78},
                new { label = "Following", value = 131},
                new { label = "Starred", value = 16}
            };
        }
    }
}