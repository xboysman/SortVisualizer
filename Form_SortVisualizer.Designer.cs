namespace SortVisualizer
{
    partial class Form_SortVisualizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_RandomValues = new System.Windows.Forms.Button();
            this.comboBox_Sort = new System.Windows.Forms.ComboBox();
            this.hScrollBar_Speed = new System.Windows.Forms.HScrollBar();
            this.label_Speed = new System.Windows.Forms.Label();
            this.lbl_Entries = new System.Windows.Forms.Label();
            this.lbl_Algorithm = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.trackBar_Entries = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Entries)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 500);
            this.panel1.TabIndex = 0;
            // 
            // button_Start
            // 
            this.button_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Start.Location = new System.Drawing.Point(606, 504);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(140, 21);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_RandomValues
            // 
            this.button_RandomValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_RandomValues.Location = new System.Drawing.Point(460, 504);
            this.button_RandomValues.Name = "button_RandomValues";
            this.button_RandomValues.Size = new System.Drawing.Size(140, 22);
            this.button_RandomValues.TabIndex = 2;
            this.button_RandomValues.Text = "Random Values";
            this.button_RandomValues.UseVisualStyleBackColor = true;
            this.button_RandomValues.Click += new System.EventHandler(this.button_RandomValues_Click);
            // 
            // comboBox_Sort
            // 
            this.comboBox_Sort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_Sort.FormattingEnabled = true;
            this.comboBox_Sort.Location = new System.Drawing.Point(92, 504);
            this.comboBox_Sort.Name = "comboBox_Sort";
            this.comboBox_Sort.Size = new System.Drawing.Size(140, 21);
            this.comboBox_Sort.TabIndex = 0;
            // 
            // hScrollBar_Speed
            // 
            this.hScrollBar_Speed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar_Speed.LargeChange = 50;
            this.hScrollBar_Speed.Location = new System.Drawing.Point(71, 534);
            this.hScrollBar_Speed.Maximum = 1049;
            this.hScrollBar_Speed.Name = "hScrollBar_Speed";
            this.hScrollBar_Speed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hScrollBar_Speed.Size = new System.Drawing.Size(920, 21);
            this.hScrollBar_Speed.TabIndex = 3;
            this.hScrollBar_Speed.Value = 500;
            this.hScrollBar_Speed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Speed_Scroll);
            // 
            // label_Speed
            // 
            this.label_Speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Speed.AutoSize = true;
            this.label_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Speed.Location = new System.Drawing.Point(12, 536);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(49, 16);
            this.label_Speed.TabIndex = 4;
            this.label_Speed.Text = "Speed";
            // 
            // lbl_Entries
            // 
            this.lbl_Entries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Entries.AutoSize = true;
            this.lbl_Entries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Entries.Location = new System.Drawing.Point(239, 504);
            this.lbl_Entries.Name = "lbl_Entries";
            this.lbl_Entries.Size = new System.Drawing.Size(66, 18);
            this.lbl_Entries.TabIndex = 6;
            this.lbl_Entries.Text = "Quantity:";
            // 
            // lbl_Algorithm
            // 
            this.lbl_Algorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Algorithm.AutoSize = true;
            this.lbl_Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Algorithm.Location = new System.Drawing.Point(12, 504);
            this.lbl_Algorithm.Name = "lbl_Algorithm";
            this.lbl_Algorithm.Size = new System.Drawing.Size(74, 18);
            this.lbl_Algorithm.TabIndex = 7;
            this.lbl_Algorithm.Text = "Algorithm:";
            // 
            // label_Status
            // 
            this.label_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Status.Location = new System.Drawing.Point(814, 504);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(0, 18);
            this.label_Status.TabIndex = 8;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Status.Location = new System.Drawing.Point(752, 504);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(54, 18);
            this.lbl_Status.TabIndex = 8;
            this.lbl_Status.Text = "Status:";
            // 
            // trackBar_Entries
            // 
            this.trackBar_Entries.AutoSize = false;
            this.trackBar_Entries.LargeChange = 1;
            this.trackBar_Entries.Location = new System.Drawing.Point(311, 504);
            this.trackBar_Entries.Maximum = 6;
            this.trackBar_Entries.Minimum = 1;
            this.trackBar_Entries.Name = "trackBar_Entries";
            this.trackBar_Entries.Size = new System.Drawing.Size(143, 21);
            this.trackBar_Entries.SmallChange = 100;
            this.trackBar_Entries.TabIndex = 0;
            this.trackBar_Entries.Value = 1;
            this.trackBar_Entries.Scroll += new System.EventHandler(this.trackBar_Entries_Scroll);
            // 
            // Form_SortVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 561);
            this.Controls.Add(this.trackBar_Entries);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.lbl_Algorithm);
            this.Controls.Add(this.lbl_Entries);
            this.Controls.Add(this.label_Speed);
            this.Controls.Add(this.hScrollBar_Speed);
            this.Controls.Add(this.comboBox_Sort);
            this.Controls.Add(this.button_RandomValues);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_SortVisualizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Entries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_RandomValues;
        private System.Windows.Forms.ComboBox comboBox_Sort;
        private System.Windows.Forms.HScrollBar hScrollBar_Speed;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.Label lbl_Entries;
        private System.Windows.Forms.Label lbl_Algorithm;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TrackBar trackBar_Entries;
    }
}

