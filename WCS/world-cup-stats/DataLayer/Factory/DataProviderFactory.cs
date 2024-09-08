using DataLayer.Interfaces;
using DataLayer.Models;
using DataLayer.Providers;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Factory
{
	public static class DataProviderFactory
	{
		public static IDataProvider CreateDataProvider(ISettingsManager settingsManager)
		{
			Settings settings = settingsManager.GetSettingsAsync().GetAwaiter().GetResult();
			LoggingService.Log($"Creating data provider of type: {settings.DataSourceType}");
			return settings.DataSourceType.ToLower() switch
			{
				"api" => new ApiDataProvider(),
				"json" => new JsonDataProvider(),
				_ => throw new ArgumentException("Invalid data source type", nameof(settings.DataSourceType)),
			};
		}

		public static IDataProvider CreateDataProvider(string dataSource)
		{
			return dataSource.ToLower() switch
			{
				"api" => new ApiDataProvider(),
				"json" => new JsonDataProvider(),
				_ => throw new ArgumentException("Invalid data source type:", dataSource),
			};
		}
	}
}
