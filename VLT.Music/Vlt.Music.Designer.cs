namespace VLT.Music
{
    partial class VltMusic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VltMusic));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPlayingSong = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtH1 = new System.Windows.Forms.NumericUpDown();
            this.txtM1 = new System.Windows.Forms.NumericUpDown();
            this.txtH2 = new System.Windows.Forms.NumericUpDown();
            this.txtM2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmdLoadList2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(15, 12);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(75, 23);
            this.cmdLoad.TabIndex = 1;
            this.cmdLoad.Text = "Folder 1";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(587, 12);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(75, 23);
            this.cmdPlay.TabIndex = 1;
            this.cmdPlay.Text = "Play";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Sound\\m1";
            // 
            // lblPlayingSong
            // 
            this.lblPlayingSong.AutoSize = true;
            this.lblPlayingSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayingSong.Location = new System.Drawing.Point(155, 70);
            this.lblPlayingSong.Name = "lblPlayingSong";
            this.lblPlayingSong.Size = new System.Drawing.Size(47, 15);
            this.lblPlayingSong.TabIndex = 2;
            this.lblPlayingSong.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(15, 70);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 15);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label1";
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.SelectedPath = "C:\\Sound\\m2";
            // 
            // txtH1
            // 
            this.txtH1.Location = new System.Drawing.Point(408, 12);
            this.txtH1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtH1.Name = "txtH1";
            this.txtH1.Size = new System.Drawing.Size(41, 20);
            this.txtH1.TabIndex = 5;
            this.txtH1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtM1
            // 
            this.txtM1.Location = new System.Drawing.Point(455, 12);
            this.txtM1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtM1.Name = "txtM1";
            this.txtM1.Size = new System.Drawing.Size(41, 20);
            this.txtM1.TabIndex = 5;
            this.txtM1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // txtH2
            // 
            this.txtH2.Location = new System.Drawing.Point(408, 40);
            this.txtH2.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtH2.Name = "txtH2";
            this.txtH2.Size = new System.Drawing.Size(41, 20);
            this.txtH2.TabIndex = 5;
            this.txtH2.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // txtM2
            // 
            this.txtM2.Location = new System.Drawing.Point(455, 40);
            this.txtM2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtM2.Name = "txtM2";
            this.txtM2.Size = new System.Drawing.Size(41, 20);
            this.txtM2.TabIndex = 5;
            this.txtM2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(305, 20);
            this.textBox2.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 99);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(648, 71);
            this.dataGridView2.TabIndex = 7;
            // 
            // cmdLoadList2
            // 
            this.cmdLoadList2.Location = new System.Drawing.Point(15, 41);
            this.cmdLoadList2.Name = "cmdLoadList2";
            this.cmdLoadList2.Size = new System.Drawing.Size(75, 23);
            this.cmdLoadList2.TabIndex = 4;
            this.cmdLoadList2.Text = "Folder 2";
            this.cmdLoadList2.UseVisualStyleBackColor = true;
            this.cmdLoadList2.Click += new System.EventHandler(this.cmdLoadList2_Click);
            // 
            // VltMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 405);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtM2);
            this.Controls.Add(this.txtM1);
            this.Controls.Add(this.txtH2);
            this.Controls.Add(this.txtH1);
            this.Controls.Add(this.cmdLoadList2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPlayingSong);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VltMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vietluxtour Music";
            this.Load += new System.EventHandler(this.VltMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblPlayingSong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.NumericUpDown txtH1;
        private System.Windows.Forms.NumericUpDown txtM1;
        private System.Windows.Forms.NumericUpDown txtH2;
        private System.Windows.Forms.NumericUpDown txtM2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button cmdLoadList2;
    }
}

