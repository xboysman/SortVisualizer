using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualizer.Algorithms
{
    public class QuickSort : SortAlgorithm
    {
        public QuickSort(int[] array, Painter p) : base(array, p) { }

        public override async Task Sort()
        {
            await quickSort(this._array, 0, this._array.Length - 1);
        }

        private async Task quickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivot = await Partition(array, low, high);

                if (pivot > 1)
                    await quickSort(array, low, pivot-1);

                await Painter.DrawBar(pivot, Color.LimeGreen);

                if (pivot + 1 < high)
                    await quickSort(array, pivot + 1, high);

                await Painter.DrawBar(pivot, Color.LimeGreen);
            }
        }

        private async Task<int> Partition(int[] array, int low, int high)
        {
            int pivot = array[low];

            while (true)
            {
                while (array[low] < pivot)
                {
                    await Painter.DrawBar(high, Color.Aqua);

                    await Painter.DrawBar(low, Color.Purple);
                    low++;
                    await Painter.DrawBar(low-1, Color.White);
                }

                while (array[high] > pivot)
                {
                    await Painter.DrawBar(low, Color.Aqua);

                    await Painter.DrawBar(high, Color.Gold);
                    high--;
                    await Painter.DrawBar(high + 1, Color.White);
                }

                await Painter.DrawBar(low, Color.Red);
                await Painter.DrawBar(high, Color.Red);

                if (low < high)
                {
                    Swap(low, high);

                    await Painter.DrawBar(low, Color.Red);
                    await Painter.DrawBar(high, Color.Red);
                }
                else
                {
                    await Painter.DrawBar(low, Color.White);
                    await Painter.DrawBar(high, Color.White);
                    return high;
                }

                    
            }
        }
    }
}
