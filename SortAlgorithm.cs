using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualizer
{
    public abstract class SortAlgorithm
    {
        protected int[] _array;
        public Painter Painter;

        public SortAlgorithm(int[] array, Painter p)
        {
            this._array = array;
            this.Painter = p;
        }

        public virtual Task Sort() 
        {
            return Task.FromResult(default(Task));
        }

        public bool IsSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                if (array[i] > array[i + 1])
                    return false;

            return true;
        }

        public void Swap(int i, int j)
        {
            int temp = this._array[i];
            this._array[i] = this._array[j];
            this._array[j] = temp;
        }
    }
}
