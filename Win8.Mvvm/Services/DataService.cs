using System;
using System.Collections.Generic;
using Win8.Mvvm.Model;

namespace Win8.Mvvm.Services
{
	public class DataService : IDataService
	{
		public List<ScheduleItem> GetSchedule()
		{
			return GetHardcodedData();
		}

		private static List<ScheduleItem> GetHardcodedData()
		{
            return new List<ScheduleItem>();
			//return new List<ScheduleItem>
			//			 {
			//				 new ScheduleItem{Title = "Breakfast", DateTime = new DateTime(2013,6,8,8,30,0)},
			//				 new ScheduleItem{Title = "Install Fest & Design Principles", DateTime = new DateTime(2013,6,8,9,0,0), SpeakerFirstName = "Ryan", SpeakerLastName = "LowderMilk"},
			//				 new ScheduleItem{Title = "Hello World C#", DateTime = new DateTime(2013,6,8,10,0,0), SpeakerFirstName = "Tim", SpeakerLastName = "Rayburn"},
			//				 new ScheduleItem{Title = "Hello World JS", DateTime = new DateTime(2013,6,8,11,0,0), SpeakerFirstName = "Teresa", SpeakerLastName = "Burger"},
			//				 new ScheduleItem{Title = "Lunch", DateTime = new DateTime(2013,6,8,12,0,0), SpeakerFirstName = "", SpeakerLastName = ""},
			//				 new ScheduleItem{Title = "MVVM", DateTime = new DateTime(2013,6,8,13,0,0), SpeakerFirstName = "Latish", SpeakerLastName = "Sehgal"},
			//				 new ScheduleItem{Title = "HTTP Client", DateTime = new DateTime(2013,6,8,14,0,0), SpeakerFirstName = "Jef", SpeakerLastName = "Newsom"},
			//				 new ScheduleItem{Title = "Search, Share and Tiles", DateTime = new DateTime(2013,6,8,15,0,0), SpeakerFirstName = "Michael", SpeakerLastName = "Perry"},
			//				 new ScheduleItem{Title = "Code", DateTime = new DateTime(2013,6,8,16,0,0)},
			//				 new ScheduleItem{Title = "Presentations", DateTime = new DateTime(2013,6,8,17,0,0)},
			//				 new ScheduleItem{Title = "Judging", DateTime = new DateTime(2013,6,8,17,30,0)}
			//			 };
		}
	}
}
