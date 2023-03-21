using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.CronJobs
{
    public class ServiceJob : BackgroundService
    {
        private readonly ILogger<ServiceJob> _logger;
        private readonly IServiceProvider _serviceProvider;

        public ServiceJob(
            ILogger<ServiceJob> logger,
            IServiceProvider serviceProvider
        )
        {
            this._logger = logger;
            this._serviceProvider = serviceProvider;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _serviceProvider.CreateAsyncScope())
                {
                    System.Console.WriteLine("ARRANDO JOB");
                }

                this._logger.LogWarning("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000 * 5, stoppingToken);
            }
        }
    }
}