using System.Collections.Generic;
using Win8.Mvvm.Model;

namespace Win8.Mvvm.Services
{
	public interface IDataService
	{
		List<ScheduleItem> GetSchedule();
	}
}