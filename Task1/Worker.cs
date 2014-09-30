using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task1
{
    class Worker:Base
    {
        ListBox Log;
        public Worker(ref Stack AResource, int acapacity, ref ListBox aLog)
        {
            this.Resourse = AResource;
            this.capacity = acapacity;
            Log = aLog;
        }
        protected override bool CanEnter()
        {
            return Resourse.Count < capacity;
        }
        protected override void DoWork(int num)
        {
            Message tmp;
            tmp.numworker = num;
            tmp.nummessage = Resourse.All_Count;
            Resourse.Push(tmp);
            Log.Invoke(new Action(()=>Log.Items.Add("Писатель " + num.ToString() + " оставил сообщение номер " + tmp.nummessage.ToString())));
            Application.DoEvents();
        }
    }
}
