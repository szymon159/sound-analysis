using System.Windows.Forms;

namespace SoundAnalysis
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
