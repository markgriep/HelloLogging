using SerilogTimings;

namespace SerilogBlazorServer.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {


            using (Operation.Time("starting..."))
            {
				using (var op = Operation.Begin("Some task"))
				{
					System.Threading.Thread.Sleep(3000);

					var xxx = Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
					{
						Date = startDate.AddDays(index),
						TemperatureC = Random.Shared.Next(-20, 55),
						Summary = Summaries[Random.Shared.Next(Summaries.Length)]
					}).ToArray());
					op.Complete("completed", "asdf");
					return xxx;
				}
			}
		}
	}
}
