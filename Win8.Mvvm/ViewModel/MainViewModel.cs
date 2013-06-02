using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Win8.Mvvm.Services;

namespace Win8.Mvvm.ViewModel
{

	public class MainViewModel : ViewModelBase
	{
		private readonly IDataService _dataService;
		private RelayCommand _refreshCommand;

		public MainViewModel(IDataService dataService)
		{
			_dataService = dataService;
			Items = new ObservableCollection<ScheduleItemViewModel>();

		}

		public ObservableCollection<ScheduleItemViewModel> Items { get; private set; }

		public RelayCommand RefreshCommand
		{
			get
			{
				return _refreshCommand
					 ?? (_refreshCommand = new RelayCommand(ExecuteRefreshCommand));
			}
		}

		private void ExecuteRefreshCommand()
		{
			var items = _dataService.GetSchedule();

			if (items != null)
			{
				Items.Clear();
				foreach (var scheduleItem in items)
					Items.Add(new ScheduleItemViewModel(scheduleItem));
			}
		}
	}
}