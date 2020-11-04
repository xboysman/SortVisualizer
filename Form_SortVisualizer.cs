using SortVisualizer.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualizer
{
    public partial class Form_SortVisualizer : Form
    {
        Graphics g;
        Painter painter;

        public Form_SortVisualizer()
        {
            InitializeComponent();

            g = panel1.CreateGraphics();

            List<string> SortList = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => typeof(SortAlgorithm).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => x.Name)
                .ToList();

            foreach (string algorithmName in SortList)
                comboBox_Sort.Items.Add(algorithmName);

            comboBox_Sort.SelectedIndex = 0;
        }

        SortAlgorithm sortAlg;

        private async void button_Start_Click(object sender, EventArgs e)
        {
            if (RandomValues == null) Reset();

            // START BUTTON
            if (button_Start.Text == "Start")
            {
                painter = new Painter(RandomValues, g, MaxWidth, MaxHeight);

                // Pick Sortin Algorithm Name from ComboBox
                string SortAlgorithmName = comboBox_Sort.SelectedItem.ToString();

                // Get the Sorting Algorithm Class
                Type t = Type.GetType("SortVisualizer.Algorithms." + SortAlgorithmName);

                // Get the Constructor of the Algorithm Class
                ConstructorInfo[] ctors = t.GetConstructors();

                // Call Up the Contructor of the Algoritm Class (Create New Instance)   |   xAlgorithm HAS TO HAVE ONLY ONE CONSTRUCTOR!!!
                sortAlg = (SortAlgorithm)ctors[0].Invoke(new object[] { this.RandomValues, this.painter });

                // Set the Speed of Sorting in Miliseconds
                sortAlg.Painter.Speed = hScrollBar_Speed.Value;

                try
                {
                    // Set the UI
                    ControlsEnabled(false);
                    button_Start.Text = "Stop";
                    label_Status.Text = "Sorting";

                    // New Task Run 
                    await Task.Run(async () => 
                    {
                        // Async Function Sort
                        await sortAlg.Sort();

                        if (sortAlg.IsSorted(RandomValues))
                        {
                            // Slow Down the Speed of the Painter for Better Visualization of Sorted List
                            this.painter.Speed = 80;

                            // Get Back to Main Thread and Change the Text of the Speed Label
                            label_Speed.BeginInvoke(new InvokeDelegate(LabelSpeedChange));

                            // Show the Sorted Array
                            await painter.DrawSorted();
                        }
                            
                    });
                }
                catch(TaskCanceledException taskEx)
                {
                    // Set the UI
                    label_Status.Text = taskEx.Message;     // Sorting was canceled!
                    button_Start.Text = "Start";
                    ControlsEnabled(true);
                }
                finally
                {
                    // Dispose the token
                    sortAlg.Painter.myToken.Dispose();
                }

                // Check If the Values are Sorted
                if (sortAlg.IsSorted(this.RandomValues))
                {
                    // Set the UI
                    label_Status.Text = "Sorted";
                    button_Start.Text = "Start";
                    ControlsEnabled(true);
                }
                    
            }
            // STOP BUTTON
            else if (button_Start.Text == "Stop")
            {
                // Set the token IsCancellationRequested (false) => true
                sortAlg.Painter.myToken.Cancel();
            }
        }

        private void ControlsEnabled(bool enabled)
        {
            button_RandomValues.Enabled = enabled;
            trackBar_Entries.Enabled = enabled;
            comboBox_Sort.Enabled = enabled;
        }

        private void button_RandomValues_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            // ARRAY PRESET
            ArrayPreset();

            // FILL ARRAY WITH RANDOM NUMBERES
            FillArrayWithRandomNumbers();

            // CREATE NEW PAINTER ==> GIVE HIM A PICTURE(RANDOMVALUES) | WALL(G) | WALL WIDTH | WALL HEIGHT
            painter = new Painter(RandomValues, g, panel1.Width, panel1.Height);

            // FILL BACKGROUND WITH COLOR && DRAW BARS
            painter.DrawBackGround(Color.Black, Color.White);

            // SET THE UI
            if (label_Status.Text != "Unsorted") label_Status.Text = "Unsorted";
            if (button_Start.Text != "Start") button_Start.Text = "Start";
        }

        private void hScrollBar_Speed_Scroll(object sender, ScrollEventArgs e)
        {
            if (sortAlg != null)
                sortAlg.Painter.Speed = hScrollBar_Speed.Value;

            label_Speed.Text = $"{hScrollBar_Speed.Value} ms";
        }

        private void trackBar_Entries_Scroll(object sender, EventArgs e)
        {
            switch (trackBar_Entries.Value)
            {
                case 1:
                    NumberEntries = 10;
                    break;
                case 2:
                    NumberEntries = 20;
                    break;
                case 3:
                    NumberEntries = 50;
                    break;
                case 4:
                    NumberEntries = 100;
                    break;
                case 5:
                    NumberEntries = 250;
                    break;
                case 6:
                    NumberEntries = 500;
                    break;
            }

            Reset();
        }

        private delegate void InvokeDelegate();

        private void LabelSpeedChange()
        {
            hScrollBar_Speed.Value = this.painter.Speed;
            label_Speed.Text = $"{hScrollBar_Speed.Value} ms";
        }

        #region Painter Preset
        private int[] RandomValues;
        private int NumberEntries = 10;
        private int MaxHeight;
        private int MaxWidth;

        private void ArrayPreset()
        {
            RandomValues = new int[NumberEntries];
            MaxWidth = panel1.Width;
            MaxHeight = panel1.Height;
        }

        private void FillArrayWithRandomNumbers()
        {
            Random rnd = new Random();
            int index = 0;

            while (index < RandomValues.Length)
            {
                int newNumber = rnd.Next(1, MaxHeight+1);

                if (!Array.Exists(RandomValues, element => element == newNumber))
                {
                    RandomValues[index] = newNumber;
                    index++;
                }
            }
        }

        #endregion
    }
}
