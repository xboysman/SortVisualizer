using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortVisualizer.Algorithms
{
    public class InsertionSort : SortAlgorithm
    {
        public InsertionSort(int[] array, Painter p) : base(array, p) { }

        public override async Task Sort()
        {
            for (int i = 1; i < this._array.Length; i++)
            {
                for (int j = i; j > 0 && this._array[j] < this._array[j - 1]; j--)
                {
                    await Painter.DrawBar(i, Color.LimeGreen);

                    await Painter.DrawBar(j, Color.Red);
                    await Painter.DrawBar(j - 1, Color.Red);
                    
                    Swap(j, j - 1);

                    await Painter.DrawBar(j, Color.Red);
                    await Painter.DrawBar(j - 1, Color.Red);

                    await Painter.DrawBar(j, Color.White);
                    await Painter.DrawBar(j - 1, Color.White);
                }

                await Painter.DrawBar(i, Color.White);
            }
        }
    }
}
