function getOption() {
    var option = {
        color: [],
        title: {
            text: ''
        },
        tooltip: {//提示框组件
            trigger: 'axis'
        },
        grid: {//直角坐标系内绘图网格
            right: 150
        },
        legend: {//图例组件(趨勢圖名稱icon)
            orient: 'vertical',
            right: 10,
            top: 200,
            bottom: 20,
            data: []
        },
        toolbox: {//工具栏-icon樣式
            show: true,
            feature: {
                magicType: {
                    title: {
                        line: '切換為折線圖',
                        bar: '切換為柱狀圖',
                    },
                    type: ['line', 'bar']

                },
                saveAsImage: {
                    title: '保存為圖片'
                }
            }
        },
        xAxis: {
            type: 'category',
            boundaryGap: false,
            data: []
        },
        yAxis: {
            type: 'value',
            axisLabel: {
                formatter: '{value}'
            }
        },
        series: []
    };
    return option;
}