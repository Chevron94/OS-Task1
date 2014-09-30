namespace Task1
{
    partial class Form1
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
            this.BufferView = new System.Windows.Forms.DataGridView();
            this.Workers_Logs = new System.Windows.Forms.ListBox();
            this.Readers_Logs = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.All_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.All_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.писательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Worker_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Worker1_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.Worker1_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.Worker_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Worker2_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.Worker2_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.читательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reader_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Reader1_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.Reader1_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.Reader_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Reader2_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.Reader2_Stop = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.BufferView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BufferView
            // 
            this.BufferView.AllowUserToAddRows = false;
            this.BufferView.AllowUserToDeleteRows = false;
            this.BufferView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BufferView.Location = new System.Drawing.Point(320, 27);
            this.BufferView.Name = "BufferView";
            this.BufferView.Size = new System.Drawing.Size(136, 300);
            this.BufferView.TabIndex = 0;
            // 
            // Workers_Logs
            // 
            this.Workers_Logs.FormattingEnabled = true;
            this.Workers_Logs.Location = new System.Drawing.Point(12, 27);
            this.Workers_Logs.Name = "Workers_Logs";
            this.Workers_Logs.Size = new System.Drawing.Size(302, 303);
            this.Workers_Logs.TabIndex = 3;
            // 
            // Readers_Logs
            // 
            this.Readers_Logs.FormattingEnabled = true;
            this.Readers_Logs.Location = new System.Drawing.Point(462, 27);
            this.Readers_Logs.Name = "Readers_Logs";
            this.Readers_Logs.Size = new System.Drawing.Size(302, 303);
            this.Readers_Logs.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.писательToolStripMenuItem,
            this.читательToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.All_Start,
            this.All_Stop});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // All_Start
            // 
            this.All_Start.Name = "All_Start";
            this.All_Start.Size = new System.Drawing.Size(112, 22);
            this.All_Start.Text = "Запуск";
            this.All_Start.Click += new System.EventHandler(this.All_Start_Click);
            // 
            // All_Stop
            // 
            this.All_Stop.Enabled = false;
            this.All_Stop.Name = "All_Stop";
            this.All_Stop.Size = new System.Drawing.Size(112, 22);
            this.All_Stop.Text = "Стоп";
            this.All_Stop.Click += new System.EventHandler(this.All_Stop_Click);
            // 
            // писательToolStripMenuItem
            // 
            this.писательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Worker_1,
            this.Worker_2});
            this.писательToolStripMenuItem.Name = "писательToolStripMenuItem";
            this.писательToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.писательToolStripMenuItem.Text = "Писатель";
            // 
            // Worker_1
            // 
            this.Worker_1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Worker1_Start,
            this.Worker1_Stop});
            this.Worker_1.Name = "Worker_1";
            this.Worker_1.Size = new System.Drawing.Size(152, 22);
            this.Worker_1.Text = "Писатель 1";
            // 
            // Worker1_Start
            // 
            this.Worker1_Start.Enabled = false;
            this.Worker1_Start.Name = "Worker1_Start";
            this.Worker1_Start.Size = new System.Drawing.Size(159, 22);
            this.Worker1_Start.Text = "Запустить";
            this.Worker1_Start.Click += new System.EventHandler(this.Worker1_Start_Click);
            // 
            // Worker1_Stop
            // 
            this.Worker1_Stop.Name = "Worker1_Stop";
            this.Worker1_Stop.Size = new System.Drawing.Size(159, 22);
            this.Worker1_Stop.Text = "Приостановить";
            this.Worker1_Stop.Click += new System.EventHandler(this.Worker1_Stop_Click);
            // 
            // Worker_2
            // 
            this.Worker_2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Worker2_Start,
            this.Worker2_Stop});
            this.Worker_2.Name = "Worker_2";
            this.Worker_2.Size = new System.Drawing.Size(152, 22);
            this.Worker_2.Text = "Писатель 2";
            // 
            // Worker2_Start
            // 
            this.Worker2_Start.Enabled = false;
            this.Worker2_Start.Name = "Worker2_Start";
            this.Worker2_Start.Size = new System.Drawing.Size(159, 22);
            this.Worker2_Start.Text = "Запустить";
            this.Worker2_Start.Click += new System.EventHandler(this.Worker2_Start_Click);
            // 
            // Worker2_Stop
            // 
            this.Worker2_Stop.Name = "Worker2_Stop";
            this.Worker2_Stop.Size = new System.Drawing.Size(159, 22);
            this.Worker2_Stop.Text = "Приостановить";
            this.Worker2_Stop.Click += new System.EventHandler(this.Worker2_Stop_Click);
            // 
            // читательToolStripMenuItem
            // 
            this.читательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reader_1,
            this.Reader_2});
            this.читательToolStripMenuItem.Name = "читательToolStripMenuItem";
            this.читательToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.читательToolStripMenuItem.Text = "Читатель";
            // 
            // Reader_1
            // 
            this.Reader_1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reader1_Start,
            this.Reader1_Stop});
            this.Reader_1.Name = "Reader_1";
            this.Reader_1.Size = new System.Drawing.Size(152, 22);
            this.Reader_1.Text = "Читатель 1";
            // 
            // Reader1_Start
            // 
            this.Reader1_Start.Enabled = false;
            this.Reader1_Start.Name = "Reader1_Start";
            this.Reader1_Start.Size = new System.Drawing.Size(159, 22);
            this.Reader1_Start.Text = "Запустить";
            this.Reader1_Start.Click += new System.EventHandler(this.Reader1_Start_Click);
            // 
            // Reader1_Stop
            // 
            this.Reader1_Stop.Name = "Reader1_Stop";
            this.Reader1_Stop.Size = new System.Drawing.Size(159, 22);
            this.Reader1_Stop.Text = "Приостановить";
            this.Reader1_Stop.Click += new System.EventHandler(this.Reader1_Stop_Click);
            // 
            // Reader_2
            // 
            this.Reader_2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reader2_Start,
            this.Reader2_Stop});
            this.Reader_2.Name = "Reader_2";
            this.Reader_2.Size = new System.Drawing.Size(152, 22);
            this.Reader_2.Text = "Читатель 2";
            // 
            // Reader2_Start
            // 
            this.Reader2_Start.Enabled = false;
            this.Reader2_Start.Name = "Reader2_Start";
            this.Reader2_Start.Size = new System.Drawing.Size(159, 22);
            this.Reader2_Start.Text = "Запустить";
            this.Reader2_Start.Click += new System.EventHandler(this.Reader2_Start_Click);
            // 
            // Reader2_Stop
            // 
            this.Reader2_Stop.Name = "Reader2_Stop";
            this.Reader2_Stop.Size = new System.Drawing.Size(159, 22);
            this.Reader2_Stop.Text = "Приостановить";
            this.Reader2_Stop.Click += new System.EventHandler(this.Reader2_Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 334);
            this.Controls.Add(this.Readers_Logs);
            this.Controls.Add(this.Workers_Logs);
            this.Controls.Add(this.BufferView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Читатели и писатели";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.BufferView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BufferView;
        private System.Windows.Forms.ListBox Workers_Logs;
        private System.Windows.Forms.ListBox Readers_Logs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem All_Start;
        private System.Windows.Forms.ToolStripMenuItem All_Stop;
        private System.Windows.Forms.ToolStripMenuItem писательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Worker_1;
        private System.Windows.Forms.ToolStripMenuItem Worker1_Start;
        private System.Windows.Forms.ToolStripMenuItem Worker1_Stop;
        private System.Windows.Forms.ToolStripMenuItem Worker_2;
        private System.Windows.Forms.ToolStripMenuItem Worker2_Start;
        private System.Windows.Forms.ToolStripMenuItem Worker2_Stop;
        private System.Windows.Forms.ToolStripMenuItem читательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Reader_1;
        private System.Windows.Forms.ToolStripMenuItem Reader1_Start;
        private System.Windows.Forms.ToolStripMenuItem Reader1_Stop;
        private System.Windows.Forms.ToolStripMenuItem Reader_2;
        private System.Windows.Forms.ToolStripMenuItem Reader2_Start;
        private System.Windows.Forms.ToolStripMenuItem Reader2_Stop;
    }
}

