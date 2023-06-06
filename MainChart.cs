using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinWaveLaunch
{
    public class MainChart
    {
        public ISeries[] MainChartSeries { get; set; }
            = new ISeries[]
            {
                new LineSeries<double>
                {
                    Name = "Main wave",
                    Values = new double[]{2,1,3,5,3,4,6,20,30,100,30,40,60,30,20,30,40,50,60,10,20,30,20,14,43,65,34,56,1,65},
                    Fill = null
                }
                
            };

    }

    
}
