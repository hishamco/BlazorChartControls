window.charts = {
    drawLineChart: function (id, dataSource, xKey, yKeys, labels) {
        Morris.Line({
            element: id,
            data: dataSource,
            xkey: xKey,
            ykeys: yKeys,
            labels: labels
        });
    },
    drawAreaChart: function (id, dataSource, xKey, yKeys, labels) {
        Morris.Area({
            element: id,
            data: dataSource,
            xkey: xKey,
            ykeys: yKeys,
            labels: labels
        });
    },
    drawBarChart: function (id, dataSource, xKey, yKeys, labels) {
        Morris.Bar({
            element: id,
            data: dataSource,
            xkey: xKey,
            ykeys: yKeys,
            labels: labels
        });
    },
    drawDonutChart: function (id, dataSource) {
        Morris.Donut({
            element: id,
            data: dataSource
        });
    }
};