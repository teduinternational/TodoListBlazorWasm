using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace TodoListBlazorWasm.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[] forecasts;

        [Inject] private  HttpClient Http { set; get; }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }

        public class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public string Summary { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }
    }
}
