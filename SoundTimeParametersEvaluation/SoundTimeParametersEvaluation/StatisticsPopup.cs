using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundTimeParametersEvaluation
{
    public partial class StatisticsPopup : Form
    {
        private Statistics statistics;
        private StatisticsType statisticsType;

        public StatisticsPopup(Statistics statistics, StatisticsType statisticsType)
        {
            InitializeComponent();

            this.statistics = statistics;
            this.statisticsType = statisticsType;

            this.Text = statisticsType.ToString() + " Statistics";

            listView1.Items.AddRange(statistics.GetListViewItemsByType(statisticsType));
        }
    }
}
