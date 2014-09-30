using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Task1
{
    struct Message
    {
        public int numworker;
        public int nummessage;
    }

    class Node 
    {
        public Message Info;
        public Node Next; 
        public Node(Message info) 
        {
            this.Info = info;
            this.Next = null;
        }

    }
    class Stack
    {
        Node Head;
        int count;
        int all_count;
        DataGridView dgv;
        public Stack() 
        {
            Head = null;
            count = 0;
            all_count = 0;
        }
        public Stack(DataGridView adgv)
        {
            dgv = adgv;
            Print_To_DGV();
        }

        public void Print_To_DGV()
        {
            Node tmp = Head;
            dgv.Invoke(new Action(()=>
                {
                    dgv.RowCount = Math.Max(Count, 1);
                    if (count == 0)
                    {
                        dgv.Rows[0].Cells[0].Value = "";
                        dgv.Rows[0].Cells[1].Value = ""; 
                    }
                    else
                        for (int i = 0; i < count; i++)
                        {
                            dgv.Rows[i].Cells[0].Value = tmp.Info.numworker;
                            dgv.Rows[i].Cells[1].Value = tmp.Info.nummessage;
                            tmp = tmp.Next;
                        }
                }));
        }

        public bool IsEmpty()   
        {
            return Head == null;
        }
        public void Push(Message info) 
        {
            Node p = new Node(info);
            p.Next = Head;
            Head = p;
            count++;
            all_count++;
            Print_To_DGV();
            Application.DoEvents();
        }
        public Message Pop()   
        {
            Node tmp;
            if (!IsEmpty())
            {
                tmp = Head;
                Head = Head.Next;
                count--;
                Print_To_DGV();
                Application.DoEvents();
                return tmp.Info;
            }
            else throw(new ArgumentNullException());
        }

        public void Clear() 
        {
            while (!IsEmpty())
                Pop();
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int All_Count
        {
            get
            {
                return all_count;
            }
        }
    }

    abstract class Base
    {
        public bool Run = true;
        protected Stack Resourse;
        protected int capacity;
        static object locker = new object();

        protected abstract void DoWork(int num);
        protected abstract bool CanEnter();
        public void Working(object obj)
        {
            //Thread.Sleep(300);
            while (Run)
            {
                lock (locker)
                    {
                        if (CanEnter())
                        {
                            DoWork((int)obj);
                            Application.DoEvents();
                            //Thread.Sleep(300);
                        }
                    }
                Thread.Sleep(1000);
            }
        }
    }
}
