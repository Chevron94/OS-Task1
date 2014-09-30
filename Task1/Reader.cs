using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task1
{
    class Reader:Base
    {
        ListBox Log;
        public Reader(ref Stack AResource, int acapacity, ref ListBox aLog)
        {
            this.Resourse = AResource;
            this.capacity = acapacity;
            Log = aLog;
        }

        protected override bool CanEnter()
        {
            return Resourse.Count > 0;
        }
        protected override void DoWork(int num)
        {
            Message tmp = Resourse.Pop();
            Log.Invoke(new Action(()=>Log.Items.Add("Читатель " + num.ToString() + " извлек сообщение номер " + tmp.nummessage.ToString())));
            Application.DoEvents();
        }
    }
}
