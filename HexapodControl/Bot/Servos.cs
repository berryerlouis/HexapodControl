using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    class Servos
    {
        public static int NB_SERVOS = 18;
        private static Servo[] servos = new Servo[NB_SERVOS];

        private static Servos servosSingleton;

        //constructor
        private Servos()
        {
            for (int i = 0; i < servos.Length; i++)
            {
                servos[i] = new Servo();
                servos[i].SetId(i);
                servos[i].SetMin(0);
                servos[i].SetPos(0);
                servos[i].SetMax(0);
                servos[i].SetEnable(true);
            }
        }

        public static Servos getInstance()
        {
            return (servosSingleton == null) ? servosSingleton = new Servos() : servosSingleton;
        }

        public Servo getServo(int servoId)
        {
            return servos[servoId];
        }
    }
}
