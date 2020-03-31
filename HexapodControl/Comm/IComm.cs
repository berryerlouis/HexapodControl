using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    public interface ICommReceive
    {
        // Receive update from subject
        void DataReceived(HexapodResponse response);
    }
    public interface ICommSent
    {
        // Receive update from subject
        void DataSent(Protocol.Frame data);
    }
    public interface IComm
    {
        // Attach an observer to the subject.
        void SetObserverReceive(ICommReceive observer);

        // Detach an observer from the subject.
        void RemoveObserverReceive(ICommReceive observer);

        // Attach an observer to the subject.
        void SetObserverSent(ICommSent observer);

        // Detach an observer from the subject.
        void RemoveObserverSent(ICommSent observer);

        // Notify all observers about an event.
        void NotifyReceivedData(HexapodResponse response);
        void NotifySentData(Protocol.Frame data);
    }
}
