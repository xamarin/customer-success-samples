using System;
using System.Runtime.InteropServices;

namespace SoftScan
{
	public enum ESktScanMsgID : uint
	{
		IdNotInitialized,
		IdDeviceArrival,
		IdDeviceRemoval,
		IdTerminate,
		SetComplete,
		GetComplete,
		Event,
		LastID
	}

	public enum ESktScanEventID : uint
	{
		Error,
		DecodedData,
		Power,
		Buttons,
		BatteryLevel,
		ListenerStarted,
		LastID
	}

	public enum ESktEventDataType : uint
	{
		None,
		Byte,
		Ulong,
		Array,
		String,
		DecodedData,
		LastID
	}

	public enum ESktScanSymbologyID : uint
	{
		NotSpecified,
		AustraliaPost,
		Aztec,
		BooklandEan,
		BritishPost,
		CanadaPost,
		Chinese2of5,
		Codabar,
		CodablockA,
		CodablockF,
		Code11,
		Code39,
		Code39Extended,
		Code39Trioptic,
		Code93,
		Code128,
		DataMatrix,
		DutchPost,
		Ean8,
		Ean13,
		Ean128,
		Ean128Irregular,
		EanUccCompositeAB,
		EanUccCompositeC,
		Gs1Databar,
		Gs1DatabarLimited,
		Gs1DatabarExpanded,
		Interleaved2of5,
		Isbt128,
		JapanPost,
		Matrix2of5,
		Maxicode,
		Msi,
		Pdf417,
		Pdf417Micro,
		Planet,
		Plessey,
		Postnet,
		QRCode,
		Standard2of5,
		Telepen,
		Tlc39,
		UpcA,
		UpcE0,
		UpcE1,
		UspsIntelligentMail,
		DirectPartMarking,
		HanXin,
		LastSymbologyID
	}

	public enum ESktScanPropType : uint
	{
		None,
		NotApplicable,
		Byte,
		Ulong,
		Array,
		String,
		Version,
		Symbology,
		Enum,
		Object,
		LastType
	}

	// identifies what the symbology struct contains
	public enum ESktScanSymbologyFlags : uint
	{
		Status = 1,
		Param = 2
	}

	// identifies the status of a symbology
	public enum ESktScanSymbologyStatus : uint
	{
		Disable = 0,
		Enable = 1,
		NotSupported = 2
	}


	public enum kSktScanGroup : uint
	{
		General,
		LocalFunctions
	}

	public enum kSktScan : uint
	{
		EnableSoftScan = 0,
		DisableSoftScan = 1,
		SoftScanNotSupported = 2,
		SoftScanSupported = 3,

		IdAbort,
		IdVersion,
		IdDeviceVersion,
		IdInterfaceVersion,
		IdConfiguration,
		IdDataConfirmationMode,
		IdDataConfirmationAction,
		IdMonitorMode,
		IdSoftScanStatus,
		IdSymbologyInfo,
		IdDataEditingProfile,
		IdDataEditingCurrentProfile,
		IdDataEditingTriggerSymbologies,
		IdDataEditingTriggerMinLength,
		IdDataEditingTriggerMaxLength,
		IdDataEditingTriggerStartsBy,
		IdDataEditingTriggerEndsWith,
		IdDataEditingTriggerContains,
		IdDataEditingOperation,
		IdDataEditingImportExport,
		IdDeviceInterfaceVersion,
		IdDeviceType,
		IdDeviceSpecific,
		IdDeviceSymbology,
		IdDeviceTrigger,
		IdDeviceApplyConfig,
		IdDevicePreamble,
		IdDevicePostamble,
		IdDeviceCapabilities,
		IdDeviceChangeId,
		IdDeviceDataFormat,
		LastDeviceGeneralGroup,
		LastGeneralGroup,
		IdDeviceFriendlyName,
		IdDeviceSecurityMode,
		IdDevicePinCode,
		IdDeviceDeletePairingBonding,
		IdDeviceRestoreFactoryDefaults,
		IdDeviceSetPowerOff,
		IdDeviceButtonsStatus,
		IdDeviceSoundConfig,
		IdDeviceTimers,
		IdDeviceLocalAcknowledgement,
		IdDeviceDataConfirmation,
		IdDeviceBatteryLevel,
		IdDeviceLocalDecodeAction,
		IdDeviceBluetoothAddress,
		IdDeviceStatisticCounters,
		IdDeviceRumbleConfig,
		IdDeviceProfileConfig,
		IdDeviceDisconnect,
		IdDeviceDataStore,
		IdDeviceNotifications,
		IdDeviceConnectReason,
		IdDevicePowerState,
		IdDeviceStartUpRoleSPP,
		IdDeviceConnectionBeepConfig,
		IdDeviceFlash,
		IdDeviceOverlayView,
		IdDeviceStandConfig,
		LastDeviceLocalFunctions
	}

	public enum ESktScanDataConfirmationMode : uint
	{
		Off,
		Device,
		ScanAPI,
		App
	}

	public enum ESktScanDeviceDataAcknowledgment : uint
	{
		ff,
		n
	}

	public enum ESktScanSecurityMode : uint
	{
		None,
		Authentication,
		AuthenticationEncryption
	}

	public enum kSktScanTrigger : uint
	{
		Start = 1,
		Stop,
		Enable,
		Disable,
		ContinuousScan
	}

	public enum kSktScanDeletePairing : uint
	{
		Current = 0,
		All = 1
	}

	public enum kSktScanSoundActionType : uint
	{
		GoodScan,
		GoodScanLocal,
		BadScan,
		BadScanLocal
	}

	public enum kSktScanSoundFrequency : uint
	{
		None = 0,
		Low,
		Medium,
		High,
		Last
	}

	public enum kSktScanRumbleActionType : uint
	{
		GoodScan,
		GoodScanLocal,
		BadScan,
		BadScanLocal
	}

	public enum kSktScanLocalDecodeAction : uint
	{
		None = 0,
		Beep = 1,
		Flash = 2,
		Rumble = 4
	}

	public enum kSktScanDataConfirmationLed : uint
	{
		None = 0,
		Green = 1,
		Red = 2
	}

	public enum kSktScanDataConfirmationBeep : uint
	{
		None = 0,
		Good = 1,
		Bad = 2
	}

	public enum kSktScanDataConfirmationRumble : uint
	{
		None = 0,
		Good = 1,
		Bad = 2
	}

	public enum kSktScanFlashO : uint
	{
		ff = 0,
		n = 1
	}


	public enum kSktScanPowerStatus : uint
	{
		Unknown = 0,
		OnBattery = 1,
		OnCradle = 2,
		OnAc = 4
	}

	public enum kSktScanMonitor : uint
	{
		DbgLevel = 1,
		DbgChannel,
		DbgFileLineLevel,
		Last
	}

	public enum kSktScanCapability : uint
	{
		General = 1,
		LocalFunctions = 2
	}

	public enum SktScanCapability: uint
	{
		SktScanCapabilityGeneralLocalFunctions = 1
	}

	public enum kSktScanCapabilityLocalFunction : uint
	{
		Rumble = 1,
		ChangeID = 2
	}

	public enum kSktScanCounter : uint
	{
		CounterUnknown = 0,
		CounterConnect = 1,
		CounterDisconnect = 2,
		CounterUnbond = 3,
		CounterFactoryReset = 4,
		CounterScans = 5,
		CounterScanButtonUp = 6,
		CounterScanButtonDown = 7,
		CounterPowerButtonUp = 8,
		CounterPowerButtonDown = 9,
		CounterPowerOnACTimeInMinutes = 10,
		CounterPowerOnBatTimeInMinutes = 11,
		CounterRfcommSend = 12,
		CounterRfcommReceive = 13,
		CounterRfcommReceiveDiscarded = 14,
		CounterUartSend = 15,
		CounterUartReceive = 16,
		CounterUartReceiveDiscarded = 17,
		CounterButtonLeftPress = 18,
		CounterButtonLeftRelease = 19,
		CounterButtonRightPress = 20,
		CounterButtonRightRelease = 21,
		CounterRingUnitDetachEvents = 22,
		CounterRingUnitAttachEvents = 23,
		CounterDecodedBytes = 24,
		CounterAbnormalShutDowns = 25,
		CounterBatteryChargeCycles = 26,
		CounterBatteryChangeCount = 27,
		CounterPowerOn = 28,
		CounterPowerOff = 29,
		StandModeChange = 30,
		CounterLast
	}

	public enum kSktScanDisconnect : uint
	{
		StartProfile = 0,
		DisableRadio = 1
	}

	public enum kSktScanProfileSelect : uint
	{
		None = 0,
		Spp = 1,
		Hid = 2
	}

	public enum kSktScanProfileConfig : uint
	{
		None = 0,
		Acceptor = 1,
		Initiator = 2
	}

	public enum kSktScanNotifications : uint
	{
		ScanButtonPress = 1 << 0,
		ScanButtonRelease = 1 << 1,
		PowerButtonPress = 1 << 2,
		PowerButtonRelease = 1 << 3,
		PowerState = 1 << 4,
		BatteryLevelChange = 1 << 5
	}

	public enum kSktScanTimer : uint
	{
		TriggerAutoLockTimeout = 1,
		PowerOffDisconnected = 2,
		PowerOffConnected = 4
	}

	public enum kSktScanDataFormat : uint
	{
		Raw = 0,
		Packet = 1
	}

	public enum kSktScanTriggerMode : uint
	{
		LocalOnly = 1,
		RemoteAndLocal = 2,
		AutoLock = 3,
		NormalLock = 4,
		Presentation = 5
	}

	public enum kSktScanConnectReason : uint
	{
		Unknown = 0,
		PowerOn = 1,
		Barcode = 2,
		UserAction = 3,
		HostChange = 4,
		Retry = 5
	}

	public enum kSktScanStartUpRoleSPP : uint
	{
		Acceptor = 0,
		LastRole = 1
	}

	public enum kSktScanConnectBeepConfig : uint
	{
		NoBeep = 0,
		Beep = 1
	}

	public enum kSktScanStandConfig : uint
	{
		MobileMode = 0,
		StandMode = 1,
		DetectMode = 2,
		AutoMode = 3
	}

	public enum kSktScanDeviceTypeInterface : uint
	{
		None,
		Sd,
		Cf,
		Bluetooth,
		Serial
	}

	public enum kSktScanDeviceType : uint
	{
		ProductIdNone = 0,
		ProductId7,
		ProductId7x,
		ProductId9,
		ProductId7xi,
		ProductIdSoftScan,
		ProductId8ci,
		ProductId8qi,
		Unknown
	}

	/*static class CFunctions
	{
		// extern SKTRESULT SktScanOpen (const char * lpszDeviceName, SKTHANDLE * pHandle);
		[DllImport ("__Internal")]
		static extern unsafe nint SktScanOpen (sbyte* lpszDeviceName, void** pHandle);

		// extern SKTRESULT SktScanClose (SKTHANDLE Handle);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe nint SktScanClose (void* Handle);

		// extern SKTRESULT SktScanGet (SKTHANDLE Handle, TSktScanObject * pScanObj);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe nint SktScanGet (void* Handle, TSktScanObject* pScanObj);

		// extern SKTRESULT SktScanSet (SKTHANDLE Handle, TSktScanObject * pScanObj);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe nint SktScanSet (void* Handle, TSktScanObject* pScanObj);

		// extern SKTRESULT SktScanWait (SKTHANDLE Handle, TSktScanObject ** ppScanObj, unsigned long ulTimeout);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe nint SktScanWait (void* Handle, TSktScanObject** ppScanObj, nuint ulTimeout);

		// extern SKTRESULT SktScanRelease (SKTHANDLE Handle, TSktScanObject * pScanObj);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe nint SktScanRelease (void* Handle, TSktScanObject* pScanObj);
	}*/

	public enum ENotificationType : uint
	{
		FriendlyName,
		BluetoothAddress,
		DeviceType,
		FirmwareVersion,
		Battery,
		StandConfig,
		LocalDecodeAction,
		Capabilities,
		Postamble,
		Symbology,
		DecodedData,
		SetPropertyError,
		Health
	}

	public enum kHealth : uint
	{
		NotSupported,
		Excellent,
		Bad
	}

	public enum eStatus : uint
	{
		Ready = 1,
		NotCompleted,
		Completed
	}


	// define an Array
	public struct TSktScanArray
	{
		nuint Size;

		unsafe byte* pData;
	}

	// define a string
	public struct TSktScanString
	{
		nuint nLength;

		unsafe sbyte* pValue;
	}

	// define a version
	public struct TSktScanVersion
	{
		nuint dwMajor;

		nuint dwMiddle;

		nuint dwMinor;

		nuint dwBuild;

		ushort wMonth;

		ushort wDay;

		ushort wYear;

		ushort wHour;

		ushort wMinute;
	}

	// define a decoded data structure
	public struct TSktScanDecodedData
	{
		ESktScanSymbologyID SymbologyID;

		TSktScanString SymbologyName;

		TSktScanString String;
	}

	// define Event Data received
	// when ScanAPI sends an Event to the application
	public struct TSktEventData
	{
		ESktEventDataType Type;

		[StructLayout (LayoutKind.Explicit)]
		public struct _Value
		{
			[FieldOffset (0)]
			byte Byte;

			[FieldOffset (0)]
			nuint Ulong;

			[FieldOffset (0)]
			TSktScanArray Array;

			[FieldOffset (0)]
			TSktScanString String;

			[FieldOffset (0)]
			TSktScanDecodedData DecodedData;
		}


		_Value Value;
	}

	// define a parameter of a Symbology
	public struct TSktScanSymbologyParam
	{
		nuint Reserved;
	}

	// Symbology information structure
	public struct TSktScanSymbology
	{
		ESktScanSymbologyID ID;

		ESktScanSymbologyFlags Flags;

		ESktScanSymbologyStatus Status;

		TSktScanSymbologyParam Param;

		TSktScanString Name;
	}

	// define a ScanObject Property
	public struct TSktScanProperty
	{
		nint ID;

		ESktScanPropType Type;

		[StructLayout (LayoutKind.Explicit)]
		public struct _Value
		{
			[FieldOffset (0)]
			byte Byte;

			[FieldOffset (0)]
			nuint Ulong;

			public struct _Array
			{
				nuint Size;

				unsafe byte* pData;
			}


			[FieldOffset (0)]
			_Array Array;

			[FieldOffset (0)]
			TSktScanString String;

			[FieldOffset (0)]
			TSktScanVersion Version;

			[FieldOffset (0)]
			TSktScanSymbology Symbology;

			[FieldOffset (0)]
			unsafe void* Object;
		}


		_Value Value;

		unsafe void* Context;
	}

	// defines an enumeration struture
	public struct TSktScanEnum
	{
		uint nCurrentIndex;

		uint nTotal;

		TSktScanProperty Property;
	}

	public struct TSktScanEvent
	{
		ESktScanEventID ID;

		TSktEventData Data;
	}

	public struct TSktScanDevice
	{
		sbyte[] szDeviceName;

		unsafe void* hDevice;

		nuint DeviceType;

		sbyte[] Guid;
	}

	// defines ScanObject struture
	// ScanObject is used to exchange data
	// between Application and ScanAPI or a device
	// by using the Set/Get/Wait API
	public struct TSktScanObject
	{
		public struct _Msg
		{
			ESktScanMsgID MsgID;

			nint Result;

			TSktScanDevice Device;

			TSktScanEvent Event;
		}


		_Msg Msg;

		TSktScanProperty Property;
	}
}