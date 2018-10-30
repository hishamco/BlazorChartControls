using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorChartControls
{
    public static class ChartJSInterop
    {
        public static Task InitializeLineChart(string element, IEnumerable<object> dataSource, string xKey, IEnumerable<string> yKeys, IEnumerable<string> labels)
        {
            return JSRuntime.Current.InvokeAsync<object>("charts.drawLineChart", element, dataSource, xKey, yKeys, labels);
        }

        public static Task InitializeAreaChart(string element, IEnumerable<object> dataSource, string xKey, IEnumerable<string> yKeys, IEnumerable<string> labels)
        {
            return JSRuntime.Current.InvokeAsync<object>("charts.drawAreaChart", element, dataSource, xKey, yKeys, labels);
        }

        public static Task InitializeBarChart(string element, IEnumerable<object> dataSource, string xKey, IEnumerable<string> yKeys, IEnumerable<string> labels)
        {
            return JSRuntime.Current.InvokeAsync<object>("charts.drawBarChart", element, dataSource, xKey, yKeys, labels);
        }

        public static Task InitializeDonutChart(string element, IEnumerable<object> dataSource)
        {
            return JSRuntime.Current.InvokeAsync<object>("charts.drawDonutChart", element, dataSource);
        }
    }
}