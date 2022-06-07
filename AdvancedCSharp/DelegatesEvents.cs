using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Demo
    {
        public event EventHandler<int> MyEvent;

        public void Handler(object sender, int arg)
        {
            Console.WriteLine($"got event and arg is: {arg}");
        }
    }
    public static class DelegatesEvents
    {
        public static void Run()
        {
            var demo = new Demo();

            var eventInfo = typeof(Demo).GetEvent("MyEvent");
            var handlerMethod = demo.GetType().GetMethod("Handler");

            var handler = Delegate.CreateDelegate(
                eventInfo.EventHandlerType,
                null,
                handlerMethod
                );

            eventInfo.AddEventHandler(demo, handler);

            //demo.MyEvent.Invoke(null, 333);
        }
    }
}
