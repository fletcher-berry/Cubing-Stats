using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CubingStats
{
    public partial class StatsControl : UserControl
    {
        public List<double> Times;
        public List<double> SortedTimes;

        public List<double> Ao5List;
        public List<double> Ao12List;
        public List<double> Ao100List;

        const int HeightPerRowTimesList = 30;

        public StatsControl()
        {
            InitializeComponent();

            Times = null;
            SortedTimes = null;
            ConsecutiveLabel.Text = "";
        }

        private void ImportTimesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text (*.txt)|*.txt";
            dialog.Title = "Load times";
            dialog.ShowDialog();
            string path = dialog.FileName;
            string shortPath = Path.GetFileName(path);
            FileNameLabel.Text = shortPath;
            if (path.Equals(""))
                return;
            StreamReader reader = new StreamReader(path);
            string timeString = reader.ReadToEnd();
            reader.Close();
            var times = timeString.Split(',');
            Times = new List<double>();
            SortedTimes = new List<double>();
            int i = 0;
            try
            {
                for (int k = 0; k < times.Length; k++)
                {
                    i = k;
                    string str = times[k].Trim();
                    if (str.EndsWith("+"))
                        str = str.Substring(0, str.Length - 1);
                    double d = double.Parse(str);
                    Times.Add(d);
                    SortedTimes.Add(d);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File is in the wrong format " + i, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Times = null;
                SortedTimes = null;
                return;
            }
            SortedTimes.Sort();

            TimesTable.SuspendLayout();
            SortedTimesTable.SuspendLayout();

            TimesTable.Controls.Clear();
            SortedTimesTable.Controls.Clear();

            TimesTable.RowCount = Times.Count;
            SortedTimesTable.RowCount = Times.Count;
            for (int k = 0; k < Times.Count; k++)
            {
                TimesTable.Controls.Add(new Label() { Text = (k+ 1).ToString(), Font = new Font(FontFamily.GenericSansSerif, 14), Width = 70 }, 0, k);
                TimesTable.Controls.Add(new Label() { Text = Times[k].ToString(), Font = new Font(FontFamily.GenericSansSerif, 14), Width = 120 }, 1, k);
                SortedTimesTable.Controls.Add(new Label() { Text = (k + 1).ToString(), Font = new Font(FontFamily.GenericSansSerif, 14), Width = 70 }, 0, k);
                SortedTimesTable.Controls.Add(new Label() { Text = SortedTimes[k].ToString(), Font = new Font(FontFamily.GenericSansSerif, 14), Width = 120 }, 1, k);
            }

            TimesTable.ResumeLayout();
            SortedTimesTable.ResumeLayout();
            Update();

            SummaryTable.SuspendLayout();
            SummaryTable.Controls.Clear();
            for(int k = 0; k < 5; k++)
            {
                SummaryTable.Controls.Add(new Label() { Text = (20 * k + 10 + "%"), Font = new Font(FontFamily.GenericSansSerif, 14), Width = 70 },k, 0);
                SummaryTable.Controls.Add(new Label() { Text = CalcTime(20 * k + 10).ToString(), Font = new Font(FontFamily.GenericSansSerif, 14), Width = 70 }, k, 1);
            }
            SummaryTable.ResumeLayout();

            MeanLabel.Text = calcMean().ToString("F2");
            AverageLabel.Text = calcAverage(0, Times.Count).ToString("F2");
            MedianLabel.Text = SortedTimes[SortedTimes.Count / 2].ToString();
            CountLabel.Text = Times.Count.ToString();

            ConsecutiveLabel.Text = "";

            // averages
            Ao5List = new List<double>();
            Ao12List = new List<double>();
            Ao100List = new List<double>();
            for (int k = 0; k + 5 <= Times.Count; k++)
                Ao5List.Add(CalcAo5(k));
            for (int k = 0; k + 12 <= Times.Count; k++)
                Ao12List.Add(CalcAo12(k));
            InitializeAo100List();

            if (Times.Count >= 5)
                Ao5Label.Text = Ao5List.Min().ToString("F2");
            else
                Ao5Label.Text = "N/A";
            if (Times.Count >= 12)
                Ao12Label.Text = Ao12List.Min().ToString("F2");
            else
                Ao12Label.Text = "N/A";
            if (Times.Count >= 100)
                Ao100Label.Text = Ao100List.Min().ToString("F2");
            else
                Ao100Label.Text = "N/A";
            StdDevLabel.Text = CalcStdDev().ToString("F2");
        }

        public double CalcTime(double rank)
        {
            if (rank >= 100 || rank < 0)
                throw new ArgumentException("rank must be between 0 and 1");
            int index = (int)(rank / 100 * Times.Count);
            return SortedTimes[index];
        }

        public double CalcRank(double time)
        {
            int minIdx = 0;
            int maxIdx = SortedTimes.Count - 1;
            if (SortedTimes[0] > time)
                return 0;
            if (SortedTimes[SortedTimes.Count - 1] < time)
                return 100;
            while(maxIdx > minIdx)
            {
                int midIdx = (minIdx + maxIdx + 1) / 2;
                if(SortedTimes[midIdx] >= time)
                {
                    maxIdx = midIdx - 1;
                }
                else
                {
                    minIdx = midIdx;
                }
                
            }
            int numBetter = minIdx + 1;
            return (double)numBetter / Times.Count * 100;
        }

        public double CalcAo5(int startIdx)
        {
            int bestIdx = startIdx;
            int worstIdx = startIdx;
            for(int k = startIdx + 1; k < startIdx + 5; k++)
            {
                if (Times[k] < Times[bestIdx])
                    bestIdx = k;
                if (Times[k] > Times[worstIdx])
                    worstIdx = k;
                if (bestIdx == worstIdx)
                    worstIdx++;
            }
            if (bestIdx == worstIdx)
                worstIdx++;
            double total = 0;
            for (int k = startIdx; k < startIdx + 5; k++)
            {
                if(k != bestIdx && k != worstIdx)
                {
                    total += Times[k];
                }
            }
            return total / 3;
        }

        public double CalcAo12(int startIdx)
        {
            int bestIdx = startIdx;
            int worstIdx = startIdx;
            for (int k = startIdx + 1; k < startIdx + 12; k++)
            {
                if (Times[k] < Times[bestIdx])
                    bestIdx = k;
                if (Times[k] > Times[worstIdx])
                    worstIdx = k;
                if (bestIdx == worstIdx)
                    worstIdx++;
            }
            if (bestIdx == worstIdx)
                worstIdx++;
            double total = 0;
            for (int k = startIdx; k < startIdx + 12; k++)
            {
                if (k != bestIdx && k != worstIdx)
                {
                    total += Times[k];
                }
            }
            return total / 10;
        }

        public void InitializeAo100List()
        {
            if (Times.Count < 100)
                return;
            var firstHundred = Times.Where((time, idx) => idx < 100).ToList();
            var bestIndexes = new List<int>() { 0, 1, 2, 3, 4 };
            var worstIndexes = new List<int>() { 0, 1, 2, 3, 4 };
            firstHundred.Sort();
            for(int k = 5; k < 100; k++)
            {
                double max = bestIndexes.Max(x => Times[x]);
                double min = worstIndexes.Min(x => Times[x]);
                if (Times[k] < max)
                {
                    bestIndexes.Add(k);
                    bestIndexes.Remove(bestIndexes.First(x => Times[x] == max));
                }
                if(Times[k] > min)
                {
                    worstIndexes.Add(k);
                    worstIndexes.Remove(worstIndexes.First(x => Times[x] == min));
                }
            }
            var sum = firstHundred.Sum();
            foreach (var x in bestIndexes)
                sum -= Times[x];
            foreach (var x in worstIndexes)
                sum -= Times[x];
            List<int> middleIndexes = new List<int>();
            for(int k = 0; k < 100; k++)
            {
                if (!bestIndexes.Contains(k) && !worstIndexes.Contains(k))
                    middleIndexes.Add(k);
            }
            var avg = sum / 90;
            Ao100List.Add(avg);
            for (int k = 100; k < Times.Count; k++)
            {
                if(bestIndexes.Contains(k - 100))
                {
                    bestIndexes.Remove(k - 100);
                    double min = middleIndexes.Min(x => Times[x]);
                    int minIdx = middleIndexes.First(x => Times[x] == min);
                    sum -= min;
                    bestIndexes.Add(minIdx);
                    middleIndexes.Remove(minIdx);
                }
                else if(worstIndexes.Contains(k - 100))
                {
                    worstIndexes.Remove(k - 100);
                    double max = middleIndexes.Max(x => Times[x]);
                    int maxIdx = middleIndexes.First(x => Times[x] == max);
                    sum -= max;
                    worstIndexes.Add(maxIdx);
                    middleIndexes.Remove(maxIdx);
                }
                else
                {
                    middleIndexes.Remove(k - 100);
                    sum -= Times[k - 100];
                }
                double maxBest = bestIndexes.Max(x => Times[x]);
                double minWorst = worstIndexes.Min(x => Times[x]);
                if(Times[k] < maxBest)
                {
                    int maxIdx = bestIndexes.First(x => Times[x] == maxBest);
                    bestIndexes.Remove(maxIdx);
                    bestIndexes.Add(k);
                    middleIndexes.Add(maxIdx);
                    sum += Times[maxIdx];
                }
                else if(Times[k] > minWorst)
                {
                    int minIdx = worstIndexes.First(x => Times[x] == minWorst);
                    worstIndexes.Remove(minIdx);
                    worstIndexes.Add(k);
                    middleIndexes.Add(minIdx);
                    sum += Times[minIdx];
                }
                else
                {
                    middleIndexes.Add(k);
                    sum += Times[k];
                }
                Ao100List.Add(sum / 90);
            }

        }

        public double CalcStdDev()
        {
            double ret = 0;
            if (Times.Count > 1)
            {
                //Compute the Average
                double avg = Times.Average();

                //Perform the Sum of (value-avg)^2
                double sum = Times.Sum(d => (d - avg) * (d - avg));

                //Put it all together
                ret = Math.Sqrt(sum / Times.Count);
            }
            return ret;

        }

        // indexes in unsorted times, excluding high index
        public double calcAverage(int lowIdx, int highIdx)
        {
            List<double> inRange = new List<double>();
            for(int k = lowIdx; k < highIdx; k++)
            {
                inRange.Add(Times[k]);
            }
            inRange.Sort();
            int numNotCounting = (int)Math.Ceiling(((double)highIdx - lowIdx) / 20);
            double sum = 0;
            for(int k = numNotCounting; k < inRange.Count - numNotCounting; k++)
            {
                sum += inRange[k];
            }
            return sum / (inRange.Count - 2 * numNotCounting);
         }

        public double calcMean()
        { 
            return Times.Average();
        }

        private void CalcTimeButton_Click(object sender, EventArgs e)
        {
            if (Times == null)
                return;
            if (!double.TryParse(RankInput.Text, out double rank))
                return;
            if (rank >= 100 || rank < 0)
                return;
            TimeInput.Text = CalcTime(rank).ToString();
        }

        private void CalcRankButton_Click(object sender, EventArgs e)
        {
            if (Times == null)
                return;
            if (!double.TryParse(TimeInput.Text, out double time))
                return;
            RankInput.Text = CalcRank(time).ToString("F2");
        }

        private void ConsecutiveButton_Click(object sender, EventArgs e)
        {
            if (Times == null)
                return;
            if (!double.TryParse(ConsecutiveInput.Text, out double time))
                return;
            int max = 0;
            int num = 0;
            for(int k = 0; k < Times.Count; k++)
            {
                if(Times[k] < time)
                {
                    num++;
                    max = Math.Max(num, max);
                }
                else
                {
                    num = 0;
                }
            }
            ConsecutiveLabel.Text = max.ToString();
        }

        private void ShowAo12ChartButton_Click(object sender, EventArgs e)
        {
            if (Times == null || Times.Count <= 12)
                return;
            double min = (Math.Floor(Ao12List.Min() * 2) - 1) / 2.0;
            double max = (Math.Ceiling(Ao12List.Max() * 2) + 1) / 2.0;
            var form = new LineChartForm(Ao12List, min, max);
            form.Show();
        }

        private void ShowAo100ChartButton_Click(object sender, EventArgs e)
        {
            if (Times == null || Times.Count <= 100)
                return;
            double min = (Math.Floor(Ao100List.Min() * 10) - 1) / 10.0;
            double max = (Math.Ceiling(Ao100List.Max() * 10) + 1) / 10.0;
            var form = new LineChartForm(Ao100List, min, max);
            form.Show();
        }
    }
}
