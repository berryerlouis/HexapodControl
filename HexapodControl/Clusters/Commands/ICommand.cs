using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    public interface ICommandReceive
    {
        // Receive update from subject
        void receivedResponse(HexapodResponse response);
    }
    public interface ICommands
    {
        // Attach an observer to the subject.
        void setObserver(ICommandReceive observer);

        // Detach an observer from the subject.
        void removeObserver(ICommandReceive observer);
        
        void notify(HexapodResponse response);
    }
}
