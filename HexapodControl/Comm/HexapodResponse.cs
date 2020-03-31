using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    //response class
    public class HexapodResponse
    {
        public enum Status
        {
            NO_ERROR,
            ERROR,
        };

        public enum Error
        {
            NO_ERROR,
            TIMEOUT,
        };

        Protocol.Frame sentFrame = null;
        List<Protocol.Frame> response = new List<Protocol.Frame>();
        
        Status status = Status.NO_ERROR;
        Error error = Error.NO_ERROR;

        public Protocol.Frame GetSentFrame()
        {
            return this.sentFrame;
        }
        public List<Protocol.Frame> GetResponses()
        {
            return this.response;
        }
        public Status GetStatus()
        {
            return this.status;
        }
        public Error GetError()
        {
            return this.error;
        }
        public HexapodResponse(Protocol.Frame sentFrame, List<Protocol.Frame> response, Status status, Error error = Error.NO_ERROR)
        {
            this.sentFrame = sentFrame;
            this.status = status;
            this.error = error;
            if (response != null)
            {
                this.response.AddRange(response);
            }
        }
    }
}
