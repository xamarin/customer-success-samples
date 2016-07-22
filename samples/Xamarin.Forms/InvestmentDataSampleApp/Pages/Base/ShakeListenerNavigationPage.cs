using System;

using Xamarin.Forms;

using DeviceMotion.Plugin;
using DeviceMotion.Plugin.Abstractions;
using System.Diagnostics;

namespace InvestmentDataSampleApp
{
	public class ShakeListenerNavigationPage : NavigationPage
	{
		bool _hasUpdated;
		DateTime _lastUpdate;
		double _lastX, _lastY, _lastZ;

		const int ShakeDetectionTimeLapse = 250;
		readonly double ShakeThreshold;

		public ShakeListenerNavigationPage(Page root) : base(root)
		{
			if (Device.OS == TargetPlatform.iOS)
				ShakeThreshold = 20;
			else if (Device.OS == TargetPlatform.Android)
				ShakeThreshold = 800;
			
			#region Implement ShakeListener
			CrossDeviceMotion.Current.Start(MotionSensorType.Accelerometer, MotionSensorDelay.Default);

			CrossDeviceMotion.Current.SensorValueChanged += (s, a) =>
			{
				if (a.SensorType == MotionSensorType.Accelerometer)
				{
					double x = ((MotionVector)a.Value).X;
					double y = ((MotionVector)a.Value).Y;
					double z = ((MotionVector)a.Value).Z;

					var curTime = DateTime.Now;
					if (_hasUpdated == false)
					{
						_hasUpdated = true;
						_lastUpdate = curTime;
						_lastX = x;
						_lastY = y;
						_lastZ = z;
					}
					else
					{
						if ((curTime - _lastUpdate).TotalMilliseconds > ShakeDetectionTimeLapse)
						{
							var diffTime = (curTime - _lastUpdate).TotalMilliseconds;
							_lastUpdate = curTime;
							var total = x + y + z - _lastX - _lastY - _lastZ;
							var speed = Math.Abs(total) / diffTime * 10000;

							Debug.WriteLine($"Speed: {speed}");

							if (speed > ShakeThreshold)
							{
								HandleShake();
							}

							_lastX = x;
							_lastY = y;
							_lastZ = z;
						}
					}
				}

			};
			#endregion
		}

		public void HandleShake()
		{
			Device.BeginInvokeOnMainThread(() => DisplayAlert("Shake Detected", "You shook your device!", "Ok"));
		}


	}
}
