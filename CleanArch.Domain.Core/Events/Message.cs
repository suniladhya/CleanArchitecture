using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Core.Events
{
    /// <summary>
    /// A basic Event will contain a message
    /// </summary>
    public abstract class Message: IRequest<bool>
    {
        //Retrieve  only those who extend can set the message
        public string MessageType { get; protected set; }
        protected Message()
        {
            MessageType = GetType().Name; // gets the type of message
        }
    }
}
