using System;
using System.Collections.Generic;

using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace SecuritySampleApp
{
	//Establish the Model for the Lane
	public class LaneModel
	{
		string _isOpenSettingsKey;
		string _ipAddressSettingsKey;
		string _needsMaintenanceSettingsKey;

		public LaneModel(int id)
		{
			ID = id;

			_needsMaintenanceSettingsKey = $"{SettingsConstants.NeedsMaintenanceKey}{ID}";
			_isOpenSettingsKey = $"{SettingsConstants.IsOpenKey}{ID}";
			_ipAddressSettingsKey = $"{SettingsConstants.IPAddressKey}{ID}";
		}

		protected static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

		public int ID { get; set; }

		public bool IsOpen
		{
			get
			{
				return AppSettings.GetValueOrDefault<bool>(_isOpenSettingsKey, SettingsConstants.DefaultBool);
			}
			set
			{
				SaveToSettings(_isOpenSettingsKey, value);
			}
		}


		public bool NeedsMaintenance
		{
			get
			{
				return AppSettings.GetValueOrDefault<bool>(_needsMaintenanceSettingsKey, SettingsConstants.DefaultBool);
			}
			set
			{
				SaveToSettings(_needsMaintenanceSettingsKey, value);
			}
		}

		public string IPAddress
		{
			get
			{
				return AppSettings.GetValueOrDefault<string>(_ipAddressSettingsKey, SettingsConstants.DefaultString);
			}
			set
			{
				SaveToSettings(_ipAddressSettingsKey, value);
			}
		}

		void SaveToSettings<T>(string key, T value)
		{
			AppSettings.AddOrUpdateValue<T>(key, value);
		}
	}
}

