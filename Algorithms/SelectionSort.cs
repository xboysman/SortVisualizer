using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortVisualizer.Algorithms
{
    public class SelectionSort : SortAlgorithm
    {
        public SelectionSort(int[] array, Painter p) : base(array, p) { }

        public override async Task Sort()
        {
            for (int i = 0; i < this._array.Length - 1; i++)
            {
                // Find the index of minimum element in unsorted array 
                int start = i;
                int minIndex = await IndexMinValue(start);

                await Painter.DrawBar(minIndex, Color.LimeGreen);
                await Painter.DrawBar(i, Color.LimeGreen);

                // Swap the found minimum element with the first 
                Swap(minIndex, i);

                await Painter.DrawBar(minIndex, Color.LimeGreen);
                await Painter.DrawBar(i, Color.LimeGreen);

                await Painter.DrawBar(minIndex, Color.White);
                await Painter.DrawBar(i, Color.White);
            }
        }

        private async Task<int> IndexMinValue(int start)
        {
            int minPos = start;
            for (int j = start + 1; j < this._array.Length; j++)
            {
                await Painter.DrawBar(minPos, Color.LimeGreen);
                await Painter.DrawBar(j, Color.Red);

                if (this._array[j] < this._array[minPos])
                {
                    await Painter.DrawBar(j, Color.LimeGreen);
                    await Painter.DrawBar(minPos, Color.White);

                    minPos = j;

                    await Painter.DrawBar(minPos, Color.LimeGreen);
                }

                await Painter.DrawBar(j, Color.White);
                //await Painter.DrawBar(minPos, Color.White);
            }

            return minPos;
        }
    }
}
