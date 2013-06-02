using GalaSoft.MvvmLight;
using Win8.Mvvm.Model;

namespace Win8.Mvvm.ViewModel
{
	public class ScheduleItemViewModel:ViewModelBase
	{
		public ScheduleItem Item { get; private set; }

		public ScheduleItemViewModel(ScheduleItem item)
		{
			Item = item;
			Item.PropertyChanged += Item_PropertyChanged;
		}

		void Item_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == ScheduleItem.SpeakerFirstNamePropertyName ||
			    e.PropertyName == ScheduleItem.SpeakerLastNamePropertyName)
			{
				RaisePropertyChanged(()=>SpeakerName);
                return;
			}

            if (e.PropertyName == ScheduleItem.DateTimePropertyName)
            {
	            RaisePropertyChanged(()=>Time);
                return;
            }

		}

		public string SpeakerName
		{
			get { return string.Format("{0} {1}", Item.SpeakerFirstName, Item.SpeakerLastName); }
		}

		public string Time
		{
			get { return Item.DateTime.ToString("hh:mm"); }
		}
	}
}
