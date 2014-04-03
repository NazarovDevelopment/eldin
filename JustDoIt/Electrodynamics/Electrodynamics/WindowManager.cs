using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Threading;

namespace Electrodynamics
{
    public sealed class WindowManager
    {
        private static WindowManager _instance = new WindowManager();

        private WindowManager()
        {
            if (_instance != null)
                throw new InvalidOperationException("hui tebe, ya odin!");


        }

        public void CreateElectroStat()
        {
            Thread tr = new Thread(init);
            tr.Start();
        }

        private void init()
        {
            FormForEStatic newPP = new FormForEStatic();
            newPP.ShowDialog();
        }

        public static WindowManager Instance
        {
            get
            {
                return _instance;
            }
        }


    }
}
