using System;
using System.Collections.Generic;
using System.Text;

namespace WzorzecAdapter
{
    class Adapter : AktualneZadanie
    {
        readonly StareDane a = new StareDane();
        readonly NoweDane a2 = new NoweDane();

        public override void info()
        {
            a.pokazInformacje();
            a2.pokazInformacje();
        }
    }
}
