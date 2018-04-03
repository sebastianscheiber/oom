using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using static System.Console;

namespace lesson6
{
    public static class PushExampleWithSubject
    {
        public static void Run()
        {
            var source = new Subject<int>();

            source
                .Sample(TimeSpan.FromSeconds(1.0))
                .Subscribe(x => WriteLine($"received {x}"))
                ;

            var t = new Thread(() =>
            {
                var i = 0;
                while (true)
                {
                    Thread.Sleep(250);
                    source.OnNext(i);
                    WriteLine($"sent {i}");
                    i++;
                }
            });
            t.Start();
        }
    }
}
