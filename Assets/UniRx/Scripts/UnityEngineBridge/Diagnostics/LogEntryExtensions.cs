using System;
using System.Collections.Generic;
using System.Text;

#if UniRxLibrary
namespace UniRx.Unity.Diagnostics
#else
namespace UniRx.Diagnostics
#endif
{
    public static partial class LogEntryExtensions
    {
        public static IDisposable LogToUnityDebug(this IObservable<LogEntry> source)
        {
            return source.Subscribe(new UnityDebugSink());
        }
    }
}