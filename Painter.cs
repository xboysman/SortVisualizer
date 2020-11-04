using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace SortVisualizer
{
    public class Painter
    {
        public int Speed { get; set; } = 500;
        public CancellationTokenSource myToken { get; set; } = new CancellationTokenSource();

        public int[] _array;

        protected Graphics _g;

        protected int[] _positionX;

        protected int _barWidth;
        protected int _barHeight;

        protected int _maxWidth;
        protected int _maxHeight;

        private readonly int pX = 5;

        public Painter(int[] array, Graphics g, int maxwidth, int maxheight)
        {
            this._array = array;
            this._g = g;

            this._maxWidth = maxwidth;
            this._maxHeight = maxheight;

            this._positionX = new int[this._array.Length];

            // BAR WIDTH SET
            int tempWidth = this._maxWidth / this._array.Length;
            this._barWidth = tempWidth / 2;

            // X-POSITIONS SET
            for (int i = 0; i < this._array.Length; i++)
            {
                this._positionX[i] = pX;
                pX += (this._barWidth * 2);
            }
        }

        public void DrawBackGround(Color backcolor, Color forecolor)
        {
            // FILL BACKGROUND WITH COLOR
            _g.FillRectangle(new SolidBrush(backcolor), 0, 0, this._maxWidth, this._maxHeight);

            // DRAW ALL BARS
            for (int i = 0; i < this._array.Length; i++)
                this._g.FillRectangle(new SolidBrush(forecolor), this._positionX[i], this._maxHeight - this._array[i], this._barWidth, this._maxHeight);
        }

        public async Task DrawBar(int index, Color color)
        {
            // UPPER BLACK BODY
            this._g.FillRectangle(new SolidBrush(Color.Black), this._positionX[index], 0, this._barWidth, this._maxHeight);

            // LOWER COLOR BODY
            this._g.FillRectangle(new SolidBrush(color), this._positionX[index], this._maxHeight - this._array[index], this._barWidth, this._maxHeight);

            await Task.Delay(this.Speed, this.myToken.Token);
        }

        public async Task DrawSorted()
        {
            for (int i = 0; i < this._array.Length; i++)
                await DrawBar(i, Color.LimeGreen);                
        }

    }
}
