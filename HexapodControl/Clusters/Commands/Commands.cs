using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    class Commands
    {
        List<Command> commands = new List<Command>();

        public Commands()
        {

        }
        
        public void setCommand(Command command)
        {
            this.commands.Add(command);
        }
        public void setCommands(List<Command> commands)
        {
            this.commands.AddRange(commands);
        }
        public string getCommandName(int cmdId)
        {
            return commands[cmdId].getCmdName();
        }
        public Command getCommandByName(string cmdName)
        {
            foreach (Command c in commands)
            {
                if (c.getCmdName() == cmdName)
                {
                    return c;
                }
            }
            return null;
        }

        public List<Command> getCommands()
        {
            return commands;
        }

        public void ExcecuteCommand(HexapodResponse frame)
        {
            //notify all cluster
            //many frame and one ok frame
            for (int i = 0; i < this.commands.Count; i++)
            {
                //depending from the response if only OK we take the sending frame to know cluster and command
                if (this.commands[i].getCmdId() == ((frame.GetResponses().Count > 1) ?
                        frame.GetResponses()[0].cmdId :
                        frame.GetSentFrame() != null ?
                            frame.GetSentFrame().cmdId :
                            frame.GetResponses()[0].cmdId)
                        )
                {
                    this.commands[i].receivedResponse(frame);
                    return;
                }
            }
        }
    }
}
