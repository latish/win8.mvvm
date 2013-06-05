using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Win8.Mvvm.Services;

namespace Win8.Mvvm.ViewModel
{

	public class MainViewModel
	{
		private readonly IDataService _dataService;

		public MainViewModel(IDataService dataService)
		{
			_dataService = dataService;
		}
	}
}