using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
	public class LogEntry
	{
		public DateTime Timestamp { get; set; }
		public string Message { get; set; }
	}

	public static class LoggingService
	{
		private static readonly List<LogEntry> _logs = new List<LogEntry>();
		public static event EventHandler<LogEntry> LogAdded;

		public static void Log(string message)
		{
			var logEntry = new LogEntry
			{
				Timestamp = DateTime.Now,
				Message = message
			};
			_logs.Add(logEntry);
			LogAdded?.Invoke(null, logEntry);
		}

		public static IEnumerable<LogEntry> GetLogs()
		{
			return _logs.AsReadOnly();
		}

		public static void ClearLogs()
		{
			_logs.Clear();
		}
	}
}
