using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SortVisualizer.Algorithms
{
    public class BubbleSort : SortAlgorithm
    {
        public BubbleSort(int[] array, Painter p) : base(array, p) { }

        public override async Task Sort()
        {
            for (int i = 0; i < this._array.Length - 1; i++)
            {
                for (int j = 0; j < this._array.Length - (1 + i); j++)
                {
                    await Painter.DrawBar(j, Color.Red);
                    await Painter.DrawBar(j + 1, Color.Red);

                    if (this._array[j] > this._array[j + 1])
                    {
                        await Painter.DrawBar(j, Color.LimeGreen);
                        await Painter.DrawBar(j + 1, Color.LimeGreen);
                        Swap(j, j + 1);
                        await Painter.DrawBar(j, Color.LimeGreen);
                        await Painter.DrawBar(j + 1, Color.LimeGreen);
                    }

                    await Painter.DrawBar(j, Color.White);
                    await Painter.DrawBar(j + 1, Color.White);
                }
            }
        }

        
    }
}
