using CleanArch.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Core.Bus
{
    //It will be used to design the messaging System
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T Command) where T : Command;
    }
}
