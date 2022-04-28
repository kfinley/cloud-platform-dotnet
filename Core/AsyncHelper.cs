using System;
using System.Threading;
using System.Threading.Tasks;

namespace Core {
  //
  //  This class is based on the AsyncHelper from Microsoft.AspNet.Identity and uses the best practices approach
  //  for calling async methods from non-async methods.
  //
  public static class AsyncHelper {

    private static readonly TaskFactory _taskFactory = new TaskFactory(CancellationToken.None,
                                                                        TaskCreationOptions.None,
                                                                        TaskContinuationOptions.None,
                                                                        TaskScheduler.Default);
    public static TResult RunSync<TResult>(Func<Task<TResult>> func)
        => _taskFactory
            .StartNew(func)
            .Unwrap()
            .GetAwaiter()
            .GetResult();

    public static void RunSync(Func<Task> func)
        => _taskFactory
            .StartNew(func)
            .Unwrap()
            .GetAwaiter()
            .GetResult();
  }
}
