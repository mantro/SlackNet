using System;
using System.Threading.Tasks;
using SlackNet.Events;

namespace SlackNet.AspNetCore
{
    class ResolvedEventCallbackHandler<TEvent> : ResolvedHandler<IEventHandler>, IEventHandler
        where TEvent : Event
    {
        public ResolvedEventCallbackHandler(IServiceProvider serviceProvider, Func<IServiceProvider, IEventHandler> getHandler)
            : base(serviceProvider, getHandler) { }

        public Task Handle(EventCallback eventCallback) =>
            eventCallback.Event is TEvent
                ? ResolvedHandle(h => h.Handle(eventCallback))
                : Task.CompletedTask;
    }
}