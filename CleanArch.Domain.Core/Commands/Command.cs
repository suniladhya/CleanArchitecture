using CleanArch.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Core.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Command : Message
    {
        //Only those who extend it , can set it
        public DateTime TimeStamp { get;protected set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
