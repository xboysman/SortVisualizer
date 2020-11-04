using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualizer.Algorithms
{
    public class ShellSort : SortAlgorithm
    {
        public ShellSort(int[] array, Painter p) : base(array, p) { }


        // COLORS NOT DONE
        public override async Task Sort()
        {
            int i, j, k, m, len;

            len = this._array.Length;

            // The intervals for the shell sort must be sorted, ascending
            int[] intervals = GenerateIntervals(len);

            for (k = intervals.Length - 1; k >= 0; k--)
            {
                int interval = intervals[k];
                for (m = 0; m < interval; m++)
                    for (j = m + interval; j < len; j += interval)
                        for (i = j; i >= interval && this._array[i] < this._array[i - interval]; i -= interval)
                        {
                            await Painter.DrawBar(i, Color.Red);
                            await Painter.DrawBar(i - interval, Color.Red);

                            Swap(i, i - interval);

                            await Painter.DrawBar(i, Color.Red);
                            await Painter.DrawBar(i - interval, Color.Red);

                            await Painter.DrawBar(i, Color.White);
                            await Painter.DrawBar(i - interval, Color.White);
                        }
            }
        }

        private static int[] GenerateIntervals(int n)
        {
            // no sorting will be needed
            if (n < 2)
                return new int[0];

            int t = Math.Max(1, (int)Math.Log(n, 3) - 1);
            int[] intervals = new int[t];
            intervals[0] = 1;
            for (int i = 1; i < t; i++)
                intervals[i] = 3 * intervals[i - 1] + 1;

            return intervals;
        }
    }
}
