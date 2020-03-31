using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    public interface IClusterReceive
    {
        // Receive update from subject
        void ReceivedResponse(HexapodResponse response);
    }
    public interface ICluster
    {
        // Attach an observer to the subject.
        void SetObserver(IClusterReceive observer);

        // Detach an observer from the subject.
        void RemoveObserver(IClusterReceive observer);
        
        void Notify(HexapodResponse response);
    }
}
