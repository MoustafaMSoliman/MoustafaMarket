using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace MoustafaMarket.Infrastructure.Persistence;

internal class SlowQueryInterceptor : DbCommandInterceptor
{
    private const int _slowQueryThreshold = 200;
    public override DbDataReader ReaderExecuted(DbCommand command, CommandExecutedEventData eventData, DbDataReader result)
    {
        if (eventData.Duration.Microseconds > _slowQueryThreshold)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");

            Console.WriteLine($"Slow Query {eventData.Duration.TotalNanoseconds} ms , {command.CommandText}");
        }
        return base.ReaderExecuted(command, eventData, result);
    }
}
