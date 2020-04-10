using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SlackNet.Events;

namespace SlackNet.AspNetCore
{
    class SlackEventsService : ISlackEvents
    {
        private readonly ISlackEvents _events = new SlackEvents();

        public SlackEventsService(IEnumerable<IEventHandler> eventHandlers)
        {
            foreach (var handler in eventHandlers)
                AddHandler((dynamic)handler);
        }

        public async Task Handle(EventCallback eventCallback) => await _events.Handle(eventCallback);

        public IObservable<EventCallback> RawEvents => _events.RawEvents;

        public IObservable<T> Events<T>() where T : Event => _events.Events<T>();

        public void AddHandler<T>(IEventHandler<T> handler) where T : Event => _events.AddHandler(handler);
    }
}