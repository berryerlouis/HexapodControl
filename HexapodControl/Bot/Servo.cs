using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    class Servo
    {
        private bool enable = false;
        private int min { get; set; }
        private int pos  { get; set; }
        private int max  { get; set; }
        private int id { get; set; }

        public bool GetEnable()
        {
            return this.enable;
        }
        public void SetEnable(bool enable)
        {
            this.enable = enable;
        }
        public int GetMin()
        {
            return this.min;
        }
        public void SetMin(int min)
        {
            this.min = min;
        }
        public int GetPos()
        {
            return this.pos;
        }
        public void SetPos(int pos)
        {
            this.pos = pos;
        }
        public int GetMax()
        {
            return this.max;
        }
        public void SetMax(int max)
        {
            this.max = max;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
    }
}
