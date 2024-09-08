using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_World_Cup_Stats
{
	public class ExceptionHandler
	{
        public ExceptionHandler()
        {
            LoggingService.Log("ExceptionHandler initialized");
        }
        public void HandleException(string message, Exception ex)
		{
			MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
