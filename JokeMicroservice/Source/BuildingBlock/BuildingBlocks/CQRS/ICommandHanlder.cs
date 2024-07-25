using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    public interface ICommandHanlder<in TCommand , TResponse> : IRequestHandler<TCommand , TResponse>
        where TCommand: ICommand<TResponse>
    {
    }
    public interface ICommandHanlder<in TCommand> : ICommandHanlder<TCommand , Unit>
        where TCommand : ICommand<Unit>
    {

    }
}
