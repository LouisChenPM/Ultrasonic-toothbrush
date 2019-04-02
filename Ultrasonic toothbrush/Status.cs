using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrasonic_toothbrush
{
    class Status
    {

        public static AllStatus now;
        public static int Step=0;

        public  enum AllStatus
        {
          Scaning,
          Connecting,
          StopReal1,
         StopReal2,
            Disconnecting,
            UpLoadData,
            StopRealData,
            DelingData,
            VoltageGot,
            PowerOffDone,
            PowerOnStart,
            PowerOnDone
        }
    }
}
