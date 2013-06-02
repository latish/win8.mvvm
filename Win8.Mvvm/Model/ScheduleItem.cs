using System;
using GalaSoft.MvvmLight;

namespace Win8.Mvvm.Model
{
	public class ScheduleItem:ObservableObject
	{
		/// <summary>
		/// The <see cref="DateTime" /> property's name.
		/// </summary>
		public const string DateTimePropertyName = "DateTime";

		private DateTime _dateTime = DateTime.MinValue;

		/// <summary>
		/// Sets and gets the DateTime property.
		/// Changes to that property's value raise the PropertyChanged event. 
		/// </summary>
		public DateTime DateTime
		{
			get
			{
				return _dateTime;
			}
			set
			{
				Set(DateTimePropertyName, ref _dateTime, value);
			}
		}

		/// <summary>
		/// The <see cref="Title" /> property's name.
		/// </summary>
		public const string TitlePropertyName = "Title";

		private string _title = "";

		/// <summary>
		/// Sets and gets the Title property.
		/// Changes to that property's value raise the PropertyChanged event. 
		/// </summary>
		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				Set(TitlePropertyName, ref _title, value);
			}
		}

		/// <summary>
		/// The <see cref="SpeakerFirstName" /> property's name.
		/// </summary>
		public const string SpeakerFirstNamePropertyName = "SpeakerFirstName";

		private string _speakerFirstName = "";

		/// <summary>
		/// Sets and gets the SpeakerFirstName property.
		/// Changes to that property's value raise the PropertyChanged event. 
		/// </summary>
		public string SpeakerFirstName
		{
			get
			{
				return _speakerFirstName;
			}
			set
			{
				Set(SpeakerFirstNamePropertyName, ref _speakerFirstName, value);
			}
		}

		/// <summary>
		/// The <see cref="SpeakerLastName" /> property's name.
		/// </summary>
		public const string SpeakerLastNamePropertyName = "SpeakerLastName";

		private string _speakerLastName = "";

		/// <summary>
		/// Sets and gets the SpeakerLastName property.
		/// Changes to that property's value raise the PropertyChanged event. 
		/// </summary>
		public string SpeakerLastName
		{
			get
			{
				return _speakerLastName;
			}
			set
			{
				Set(SpeakerLastNamePropertyName, ref _speakerLastName, value);
			}
		}
	}
}
