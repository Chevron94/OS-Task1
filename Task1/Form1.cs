using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Task1
{
    public partial class Form1 : Form
    {
        const int capacity = 10;
        public Form1()
        {
            InitializeComponent();
            int CellWidth = 65;
            BufferView.ColumnCount = 2;
            BufferView.Columns[0].HeaderText = "Номер Писателя";
            BufferView.Columns[1].HeaderText = "Номер Сообщения";
            BufferView.RowHeadersWidth = 4;
            BufferView.Columns[0].Width = CellWidth;
            BufferView.Columns[1].Width = CellWidth;
            Resource = new Stack(BufferView);
            Reader = new Reader(ref Resource, capacity,ref Readers_Logs);
            Worker = new Worker(ref Resource, capacity,ref Workers_Logs);
            WorkerThread1 = new Thread(new ParameterizedThreadStart(Worker.Working));
            WorkerThread2 = new Thread(new ParameterizedThreadStart(Worker.Working));
            ReaderThread1 = new Thread(new ParameterizedThreadStart(Reader.Working));
            ReaderThread2 = new Thread(new ParameterizedThreadStart(Reader.Working));
           // System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            Application.Idle += MyIdle;
        }
        Reader Reader;
        Worker Worker;
        Stack Resource;
        Thread WorkerThread1;
        Thread WorkerThread2;
        Thread ReaderThread1;
        Thread ReaderThread2;

        void MyIdle(object sender, EventArgs e)
        {
            All_Start.Enabled = (!WorkerThread2.IsAlive) && (!WorkerThread1.IsAlive) && (!ReaderThread2.IsAlive) && (!ReaderThread1.IsAlive);
            All_Stop.Enabled = !All_Start.Enabled;
            Reader_1.Enabled = ReaderThread1.IsAlive;
            Reader_2.Enabled = ReaderThread2.IsAlive;
            Worker_1.Enabled = WorkerThread1.IsAlive;
            Worker_2.Enabled = WorkerThread2.IsAlive;
        }
        private void All_Start_Click(object sender, EventArgs e)
        {
            WorkerThread1 = new Thread(new ParameterizedThreadStart(Worker.Working));
            ReaderThread1 = new Thread(new ParameterizedThreadStart(Reader.Working));
            WorkerThread2 = new Thread(new ParameterizedThreadStart(Worker.Working));
            ReaderThread2 = new Thread(new ParameterizedThreadStart(Reader.Working));
            WorkerThread1.Start(1);
            WorkerThread2.Start(2);
            ReaderThread1.Start(1);
            ReaderThread2.Start(2);

        }

        private void All_Stop_Click(object sender, EventArgs e)
        {
            if (Worker1_Start.Enabled)
                Worker1_Start.PerformClick();
            if (Worker2_Start.Enabled)
                Worker2_Start.PerformClick();
            if (Reader1_Start.Enabled)
                Reader1_Start.PerformClick();
            if (Reader2_Start.Enabled)
                Reader2_Start.PerformClick();
            Worker.Run = false;
            Reader.Run = false;
            WorkerThread1.Abort();
            WorkerThread2.Abort();
            ReaderThread1.Abort();
            ReaderThread2.Abort();
        }

        private void Worker1_Start_Click(object sender, EventArgs e)
        {
            //WorkerThread1 = new Thread(new ParameterizedThreadStart(Worker.Working));
            //WorkerThread1.Start(1);
            WorkerThread1.Resume();
            Worker1_Start.Enabled = false;
            Worker1_Stop.Enabled = true;
        }

        private void Worker1_Stop_Click(object sender, EventArgs e)
        {
            //WorkerThread1.Abort();
            WorkerThread1.Suspend();
            Worker1_Stop.Enabled = false;
            Worker1_Start.Enabled = true;
        }

        private void Reader1_Start_Click(object sender, EventArgs e)
        {
            //ReaderThread1 = new Thread(new ParameterizedThreadStart(Reader.Working));
            //ReaderThread1.Start(1);
            ReaderThread1.Resume();
            Reader1_Start.Enabled = false;
            Reader1_Stop.Enabled = true;
        }

        private void Reader1_Stop_Click(object sender, EventArgs e)
        {
            //ReaderThread1.Abort();
            ReaderThread1.Suspend();
            Reader1_Start.Enabled = true;
            Reader1_Stop.Enabled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Worker1_Start.Enabled)
                Worker1_Start.PerformClick();
            if (Worker2_Start.Enabled)
                Worker2_Start.PerformClick();
            if (Reader1_Start.Enabled)
                Reader1_Start.PerformClick();
            if (Reader2_Start.Enabled)
                Reader2_Start.PerformClick();
            Worker.Run = false;
            Reader.Run = false;
            WorkerThread1.Abort();
            WorkerThread2.Abort();
            ReaderThread1.Abort();
            ReaderThread2.Abort();
        }

        private void Worker2_Start_Click(object sender, EventArgs e)
        {
           // WorkerThread2 = new Thread(new ParameterizedThreadStart(Worker.Working));
           // WorkerThread2.Start(2);
            WorkerThread2.Resume();
            Worker2_Start.Enabled = false;
            Worker2_Stop.Enabled = true;
        }

        private void Worker2_Stop_Click(object sender, EventArgs e)
        {
            //WorkerThread2.Abort();
            WorkerThread2.Suspend();
            Worker2_Start.Enabled = true;
            Worker2_Stop.Enabled = false;
        }

        private void Reader2_Start_Click(object sender, EventArgs e)
        {
           // ReaderThread2 = new Thread(new ParameterizedThreadStart(Reader.Working));
           // ReaderThread2.Start(2);
            ReaderThread2.Resume();
            Reader2_Start.Enabled = false;
            Reader2_Stop.Enabled = true;
        }

        private void Reader2_Stop_Click(object sender, EventArgs e)
        {
            //ReaderThread2.Abort();
            ReaderThread2.Suspend();
            Reader2_Start.Enabled = true;
            Reader2_Stop.Enabled = false;
        }

    }
}
