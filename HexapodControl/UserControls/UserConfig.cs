using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexapodControl
{
    public partial class UserConfig : UserControl
    {
        public UserConfig()
        {
            
            InitializeComponent();
            List<Control> c = new List<Control>();
            c.Add(new UserConfigIMU());
            c.Add(new UserConfigBehavior());
            c.Add(new UserConfigBody());
            c.Add(new UserConfigUltrason());
            c.Add(new UserConfigLeg());
            for (int i = 0; i < 18; i++)
            {
                c.Add(new UserConfigServo(i));
            }


            flowLayoutPanelConfig.Controls.AddRange( c.ToArray() );

        }
    }
}
