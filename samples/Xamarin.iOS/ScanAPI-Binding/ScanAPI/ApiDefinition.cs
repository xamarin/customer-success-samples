using System;
using Foundation;
using ObjCRuntime;

namespace SoftScan
{
//	return Runtime.GetNSObject<ScanApiHelper> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sharedScanApiHelper")));

	partial interface Constants
	{
		// extern const char * kSktScanSoftScanContext;
		[Field ("kSktScanSoftScanContext")]
		IntPtr kSktScanSoftScanContext { get; }

		// extern const char * kSktScanSoftScanLayoutId;
		[Field ("kSktScanSoftScanLayoutId")]
		IntPtr kSktScanSoftScanLayoutId { get; }

		// extern const char * kSktScanSoftScanViewFinderId;
		[Field ("kSktScanSoftScanViewFinderId")]
		IntPtr kSktScanSoftScanViewFinderId { get; }

		// extern const char * kSktScanSoftScanFlashButtonId;
		[Field ("kSktScanSoftScanFlashButtonId")]
		IntPtr kSktScanSoftScanFlashButtonId { get; }

		// extern const char * kSktScanSoftScanCancelButton;
		[Field ("kSktScanSoftScanCancelButton")]
		IntPtr kSktScanSoftScanCancelButton { get; }

		// extern const char * kSktScanSoftScanFlashButton;
		[Field ("kSktScanSoftScanFlashButton")]
		IntPtr kSktScanSoftScanFlashButton { get; }

		// extern const char * kSktScanSoftScanDirectionText;
		[Field ("kSktScanSoftScanDirectionText")]
		IntPtr kSktScanSoftScanDirectionText { get; }
	}

	interface ISktScanSymbology {}

	// @protocol ISktScanSymbology
	[Protocol, Model]
	[BaseType (typeof (NSObject), Name = "ISktScanSymbology")]
	interface SktScanSymbology
	{
		// @required -(void)setID:(enum ESktScanSymbologyID)symid;
		[Abstract]
		[Export ("setID:")]
		void SetID (ESktScanSymbologyID symid);

		// @required -(enum ESktScanSymbologyID)getID;
		[Abstract]
		[Export ("getID")]
		ESktScanSymbologyID ID { get; }

		// @required -(void)setFlags:(enum ESktScanSymbologyFlags)flags;
		[Abstract]
		[Export ("setFlags:")]
		void SetFlags (ESktScanSymbologyFlags flags);

		// @required -(enum ESktScanSymbologyFlags)getFlags;
		[Abstract]
		[Export ("getFlags")]
		
		ESktScanSymbologyFlags Flags { get; }

		// @required -(void)setStatus:(enum ESktScanSymbologyStatus)status;
		[Abstract]
		[Export ("setStatus:")]
		void SetStatus (ESktScanSymbologyStatus status);

		// @required -(enum ESktScanSymbologyStatus)getStatus;
		[Abstract]
		[Export ("getStatus")]
		
		ESktScanSymbologyStatus Status { get; }

		// @required -(NSString *)getName;
		[Abstract]
		[Export ("getName")]

		string Name { get; }
	}

	interface ISktScanDecodedData {}

	// @protocol ISktScanDecodedData <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject), Name = "ISktScanDecodedData")]
	interface SktScanDecodedData
	{
		// @required -(enum ESktScanSymbologyID)ID;
		[Abstract]
		[Export ("ID")]
		
		ESktScanSymbologyID ID { get; }

		// @required -(NSString *)Name;
		[Abstract]
		[Export ("Name")]
		
		string Name { get; }

		// @required -(uint8_t *)getData;
		[Abstract]
		[Export ("getData")]
		
		IntPtr Data { get; }

		// @required -(uint32_t)getDataSize;
		[Abstract]
		[Export ("getDataSize")]
		
		uint DataSize { get; }
	}

	interface ISktScanEvent { }

	// @protocol ISktScanEvent
	[Protocol, Model]
	[BaseType (typeof (NSObject), Name = "ISktScanEvent")]
	interface SktScanEvent
	{
		// @required -(enum ESktScanEventID)ID;
		[Abstract]
		[Export ("ID")]
		
		ESktScanEventID ID { get; }

		// @required -(enum ESktEventDataType)getDataType;
		[Abstract]
		[Export ("getDataType")]
		
		ESktEventDataType DataType { get; }

		// @required -(NSString *)getDataString;
		[Abstract]
		[Export ("getDataString")]
		
		string DataString { get; }

		// @required -(uint8_t)getDataByte;
		[Abstract]
		[Export ("getDataByte")]
		
		byte DataByte { get; }

		// @required -(uint8_t *)getDataArrayValue;
		[Abstract]
		[Export ("getDataArrayValue")]
		
		IntPtr DataArrayValue { get; }

		// @required -(uint32_t)getDataArraySize;
		[Abstract]
		[Export ("getDataArraySize")]
		
		uint DataArraySize { get; }

		// @required -(uint32_t)getDataLong;
		[Abstract]
		[Export ("getDataLong")]
		
		uint DataLong { get; }

		// @required -(id<ISktScanDecodedData>)getDataDecodedData;
		[Abstract]
		[Export ("getDataDecodedData")]
		
		ISktScanDecodedData DataDecodedData ();
	}

	interface ISktScanMsg { }

	// @protocol ISktScanMsg
	[Protocol, Model]
	[BaseType (typeof (NSObject), Name = "ISktScanMsg")]
	interface SktScanMsg
	{
		// @required -(enum ESktScanMsgID)MsgID;
		[Abstract]
		[Export ("MsgID")]
		
		ESktScanMsgID MsgID { get; }

		// @required -(SKTRESULT)Result;
		[Abstract]
		[Export ("Result")]
		
		nint Result { get; }

		// @required -(NSString *)DeviceName;
		[Abstract]
		[Export ("DeviceName")]
		
		string DeviceName { get; }

		// @required -(id<ISktScanDevice>)hDevice;
		[Abstract]
		[Export ("hDevice")]
		
		SktScanDevice HDevice { get; }

		// @required -(uint32_t)DeviceType;
		[Abstract]
		[Export ("DeviceType")]
		
		uint DeviceType { get; }

		// @required -(NSString *)DeviceGuid;
		[Abstract]
		[Export ("DeviceGuid")]
		
		string DeviceGuid { get; }

		// @required -(id<ISktScanEvent>)Event;
		[Abstract]
		[Export ("Event")]
		
		ISktScanEvent Event ();
	}

	interface ISktScanVerion {}

	// @protocol ISktScanVersion
	[Protocol, Model]
	[BaseType (typeof (NSObject), Name = "ISktScanVersion")]
	interface SktScanVersion
	{
		// @required -(unsigned long)getMajor;
		[Abstract]
		[Export ("getMajor")]
		
		nuint Major { get; }

		// @required -(unsigned long)getMiddle;
		[Abstract]
		[Export ("getMiddle")]
		
		nuint Middle { get; }

		// @required -(unsigned long)getMinor;
		[Abstract]
		[Export ("getMinor")]
		
		nuint Minor { get; }

		// @required -(unsigned long)getBuild;
		[Abstract]
		[Export ("getBuild")]
		
		nuint Build { get; }

		// @required -(unsigned short)getMonth;
		[Abstract]
		[Export ("getMonth")]
		
		ushort Month { get; }

		// @required -(unsigned short)getDay;
		[Abstract]
		[Export ("getDay")]
		
		ushort Day { get; }

		// @required -(unsigned short)getYear;
		[Abstract]
		[Export ("getYear")]
		
		ushort Year { get; }

		// @required -(unsigned short)getHour;
		[Abstract]
		[Export ("getHour")]
		
		ushort Hour { get; }

		// @required -(unsigned short)getMinute;
		[Abstract]
		[Export ("getMinute")]
		
		ushort Minute { get; }
	}

	interface ISktScanProperty {}

	// @protocol ISktScanProperty
	[Protocol, Model]
	[BaseType (typeof (NSObject), Name = "ISktScanProperty")]
	interface SktScanProperty
	{
		// @required -(void)setID:(long)Propid;
		[Abstract]
		[Export ("setID:")]
		void SetID (nint Propid);

		// @required -(long)getID;
		[Abstract]
		[Export ("getID")]
		
		nint ID { get; }

		// @required -(void)setType:(enum ESktScanPropType)type;
		[Abstract]
		[Export ("setType:")]
		void SetType (ESktScanPropType type);

		// @required -(enum ESktScanPropType)getType;
		[Abstract]
		[Export ("getType")]
		
		ESktScanPropType Type { get; }

		// @required -(void)setByte:(unsigned char)uchar;
		[Abstract]
		[Export ("setByte:")]
		void SetByte (byte uchar);

		// @required -(unsigned char)getByte;
		[Abstract]
		[Export ("getByte")]
		
		byte Byte { get; }

		// @required -(void)setUlong:(unsigned long)ulong;
		[Abstract]
		[Export ("setUlong:")]
		void SetUlong (nuint tuLong);

		// @required -(unsigned long)getUlong;
		[Abstract]
		[Export ("getUlong")]
		
		nuint Ulong { get; }

		// @required -(void)setString:(NSString *)string;
		[Abstract]
		[Export ("setString:")]
		void SetString (string tString);

		// @required -(NSString *)getString;
		[Abstract]
		[Export ("getString")]
		
		string String { get; }

		// @required -(void)setArray:(unsigned char *)values Length:(int)length;
		[Abstract]
		[Export ("setArray:Length:")]
		void SetArray (IntPtr values, int length);

		// @required -(const unsigned char *)getArrayValue;
		[Abstract]
		[Export ("getArrayValue")]
		
		IntPtr ArrayValue { get; }

		// @required -(int)getArraySize;
		[Abstract]
		[Export ("getArraySize")]
		
		int ArraySize { get; }

		// @required -(id<ISktScanVersion>)Version;
		[Abstract]
		[Export ("Version")]
		
		SktScanVersion Version { get; }

		// @required -(id<ISktScanSymbology>)Symbology;
		[Abstract]
		[Export ("Symbology")]
		
		ISktScanSymbology Symbology { get; }

		// @required -(void)setObject:(id)object;
		[Abstract]
		[Export ("setObject:")]
		void SetObject (NSObject tObject);

		// @required -(NSObject *)getContext;
		[Abstract]
		[Export ("getContext")]
		
		NSObject Context { get; }

		// @required -(void)setContext:(NSObject *)context;
		[Abstract]
		[Export ("setContext:")]
		void SetContext (NSObject context);
	}

	//[Protocol, Model]	
	//[BaseType (typeof (NSObject))]
	interface ISktScanObject {}

	// @protocol ISktScanObject
	[Protocol, Model]
	[BaseType (typeof (NSObject), Name = "ISktScanObject")]
	interface SktScanObject
	{
		// @required -(id<ISktScanMsg>)Msg;
		[Abstract]
		[Export ("Msg")]
		ISktScanMsg Msg ();

		// @required -(id<ISktScanProperty>)Property;
		[Abstract]
		[Export ("Property")]
		ISktScanProperty Property ();
	}

	interface ISktScanApi {}

	// @protocol ISktScanApi <ISktScanDevice>
	[Protocol, Model]
	[BaseType (typeof (NSObject), Name= "ISktScanApi")]
	interface SktScanApi : SktScanDevice
	{
		// @required -(SKTRESULT)waitForScanObject:(id<ISktScanObject>)scanObj TimeOut:(unsigned long)ulTimeOut;
		[Abstract]
		[Export ("waitForScanObject:TimeOut:")]
		nint WaitForScanObject (ISktScanObject scanObj, nuint ulTimeOut);

		// @required -(SKTRESULT)releaseScanObject:(id<ISktScanObject>)scanObj;
		[Abstract]
		[Export ("releaseScanObject:")]
		nint ReleaseScanObject (ISktScanObject scanObj);
	}

	interface IScanAPIObjectDelegate {}

	// @protocol ScanAPIObjectDelegate
	[Protocol, Model]
	[BaseType (typeof(NSObject), Name = "IScanAPIObjectDelegate")]
	interface ScanAPIObjectDelegate
	{
		// @required -(id)startController;
		[Abstract]
		[Export ("startController")]
		
		NSObject StartController { get; }
	}

	interface ISktScanInterface {}

	// @protocol ISktScanDevice
	[Protocol, Model]
	[BaseType (typeof(NSObject), Name = "ISktScanInterface")]
	interface SktScanDevice
	{
		// @required -(SKTRESULT)open:(NSString *)devicename;
		[Abstract]
		[Export ("open:")]
		nint Open (string devicename);

		// @required -(SKTRESULT)close;
		[Abstract]
		[Export ("close")]
		
		nint Close { get; }

		// @required -(SKTRESULT)getProperty:(id<ISktScanObject>)pScanObj;
		[Abstract]
		[Export ("getProperty:")]
		nint GetProperty (ISktScanObject pScanObj);

		// @required -(SKTRESULT)setProperty:(id<ISktScanObject>)pScanObj;
		[Abstract]
		[Export ("setProperty:")]
		nint SetProperty (ISktScanObject pScanObj);
	}

	// @interface SktClassFactory : NSObject
	[BaseType (typeof(NSObject))]
	interface SktClassFactory
	{
		// +(id<ISktScanObject>)createScanObject;
		[Static]
		[Export ("createScanObject")]
		ISktScanObject CreateScanObject ();

		// +(void)releaseScanObject:(id<ISktScanObject>)scanObj;
		[Static]
		[Export ("releaseScanObject:")]
		void ReleaseScanObject (ISktScanObject scanObj);

		// +(id<ISktScanApi>)createScanApiInstance;
		[Static]
		[Export ("createScanApiInstance")]
		ISktScanApi CreateScanApiInstance ();

		// +(void)releaseScanApiInstance:(id<ISktScanApi>)scanApi;
		[Static]
		[Export ("releaseScanApiInstance:")]
		void ReleaseScanApiInstance (ISktScanApi scanApi);

		// +(id<ISktScanDevice>)createDeviceInstance:(id<ISktScanApi>)scanApi;
		[Static]
		[Export ("createDeviceInstance:")]
		SktScanDevice CreateDeviceInstance (ISktScanApi scanApi);

		// +(void)releaseDeviceInstance:(id<ISktScanDevice>)deviceInstance;
		[Static]
		[Export ("releaseDeviceInstance:")]
		void ReleaseDeviceInstance (SktScanDevice deviceInstance);
	}


	interface INotification {}

	// @protocol Notification
	[Protocol, Model]
	[BaseType (typeof(NSObject), Name = "INotification")]
	interface Notification
	{
		// @required -(void)OnNotify:(DeviceInfo *)deviceinfo notificationType:(enum ENotificationType)type;
		[Abstract]
		[Export ("OnNotify:notificationType:")]
		void NotificationType (DeviceInfo deviceinfo, ENotificationType type);
	}

	// @interface SymbologyInfo : NSObject
	[BaseType (typeof(NSObject), Name = "SymbologyInfo")]
	interface SymbologyInfo
	{
		// -(SymbologyInfo *)initWithSymbology:(id<ISktScanSymbology>)symbology;
		[Export ("initWithSymbology:")]
		IntPtr Constructor (ISktScanSymbology symbology);

		// -(NSString *)getName;
		[Export ("getName")]
		
		string Name { get; }

		// -(void)setName:(NSString *)name;
		[Export ("setName:")]
		void SetName (string name);

		// -(enum ESktScanSymbologyID)getId;
		[Export ("getId")]
		
		ESktScanSymbologyID Id { get; }

		// -(void)setId:(enum ESktScanSymbologyID)symbologyId;
		[Export ("setId:")]
		void SetId (ESktScanSymbologyID symbologyId);

		// -(BOOL)isEnabled;
		[Export ("isEnabled")]
		
		bool IsEnabled { get; }

		// -(void)setEnabled:(BOOL)enabled;
		[Export ("setEnabled:")]
		void SetEnabled (bool enabled);
	}

	// @interface DecodedDataInfo : NSObject
	[BaseType (typeof(NSObject), Name = "DecodedDataInfo")]
	interface DecodedDataInfo
	{
		// -(DecodedDataInfo *)initWithDecodedData:(id<ISktScanDecodedData>)decodedData;
		[Export ("initWithDecodedData:")]
		IntPtr Constructor (ISktScanDecodedData decodedData);

		// -(NSString *)getSymbologyName;
		[Export ("getSymbologyName")]
		
		string SymbologyName { get; }

		// -(void)setSymbologyName:(NSString *)symbologyName;
		[Export ("setSymbologyName:")]
		void SetSymbologyName (string symbologyName);

		// -(uint8_t *)getData;
		[Export ("getData")]

		IntPtr Data { get; }

		// -(void)setData:(uint8_t *)data Length:(int)length;
		[Export ("setData:Length:")]
		void SetData (IntPtr data, int length);

		// -(int)getLength;
		[Export ("getLength")]
		
		int Length { get; }

		// -(void)setLength:(int)length;
		[Export ("setLength:")]
		void SetLength (int length);
	}

	// @interface DeviceInfo : NSObject
	[BaseType (typeof(NSObject), Name = "DeviceInfo")]
	interface DeviceInfo
	{
		// -(DeviceInfo *)init:(id<ISktScanDevice>)device name:(NSString *)name type:(long)type;
		[Export ("init:name:type:")]
		IntPtr Constructor (SktScanDevice device, string name, nint type);

		// -(id<ISktScanDevice>)getSktScanDevice;
		[Export ("getSktScanDevice")]
		
		SktScanDevice SktScanDevice { get; }

		// -(void)setNotification:(id)notification;
		[Export ("setNotification:")]
		void SetNotification (NSObject notification);

		// -(id)getNotification;
		[Export ("getNotification")]
		
		NSObject Notification { get; }

		// -(NSString *)getName;
		[Export ("getName")]
		
		string Name { get; }

		// -(void)setName:(NSString *)name;
		[Export ("setName:")]
		void SetName (string name);

		// -(NSString *)getBdAddress;
		[Export ("getBdAddress")]
		
		string BdAddress { get; }

		// -(void)setBdAddress:(NSString *)bdAddress;
		[Export ("setBdAddress:")]
		void SetBdAddress (string bdAddress);

		// -(NSString *)getTypeString;
		[Export ("getTypeString")]
		
		string TypeString { get; }

		// -(void)setType:(long)type;
		[Export ("setType:")]
		void SetType (nint type);

		// -(long)getType;
		[Export ("getType")]
		
		nint Type { get; }

		// -(NSString *)getFirmwareVersion;
		[Export ("getFirmwareVersion")]
		
		string FirmwareVersion { get; }

		// -(void)setFirmwareVersion:(NSString *)version;
		[Export ("setFirmwareVersion:")]
		void SetFirmwareVersion (string version);

		// -(NSString *)getBatteryLevel;
		[Export ("getBatteryLevel")]
		
		string BatteryLevel { get; }

		// -(void)setBatteryLevel:(NSString *)level;
		[Export ("setBatteryLevel:")]
		void SetBatteryLevel (string level);

		// -(NSString *)getStandConfig;
		[Export ("getStandConfig")]
		
		string StandConfig { get; }

		// -(void)setStandConfig:(NSString *)level;
		[Export ("setStandConfig:")]
		void SetStandConfig (string level);

		// -(int)getLocalDecodeAction;
		[Export ("getLocalDecodeAction")]
		
		int LocalDecodeAction { get; }

		// -(void)setLocalDecodeAction:(int)decodeAction;
		[Export ("setLocalDecodeAction:")]
		void SetLocalDecodeAction (int decodeAction);

		// -(BOOL)getRumbleSupport;
		[Export ("getRumbleSupport")]
		
		bool RumbleSupport { get; }

		// -(void)setRumbleSupport:(BOOL)support;
		[Export ("setRumbleSupport:")]
		void SetRumbleSupport (bool support);

		// -(NSString *)getPostamble;
		[Export ("getPostamble")]
		
		string Postamble { get; }

		// -(void)setPostamble:(NSString *)postamble;
		[Export ("setPostamble:")]
		void SetPostamble (string postamble);

		// -(void)setDecodeData:(id<ISktScanDecodedData>)decodedData;
		[Export ("setDecodeData:")]
		void SetDecodeData (ISktScanDecodedData decodedData);

		// -(DecodedDataInfo *)getDecodedData;
		[Export ("getDecodedData")]
		
		DecodedDataInfo DecodedData { get; }

		// -(SymbologyInfo *)getSymbologyInfo:(int)index;
		[Export ("getSymbologyInfo:")]
		SymbologyInfo GetSymbologyInfo (int index);

		// -(void)addSymbologyInfo:(id<ISktScanSymbology>)symbologyInfo;
		[Export ("addSymbologyInfo:")]
		void AddSymbologyInfo (ISktScanSymbology symbologyInfo);

		// -(int)getSymbologyCount;
		[Export ("getSymbologyCount")]
		
		int SymbologyCount { get; }

		// -(void)setPropertyError:(long)propertyId Error:(long)error;
		[Export ("setPropertyError:Error:")]
		void SetPropertyError (nint propertyId, nint error);

		// -(long)getPropertyErrorId;
		[Export ("getPropertyErrorId")]
		
		nint PropertyErrorId { get; }

		// -(long)getPropertyError;
		[Export ("getPropertyError")]
		
		nint PropertyError { get; }

		// -(void)setHealthValues:(short *)healthValues Size:(int)size;
		[Export ("setHealthValues:Size:")]
		void SetHealthValues (IntPtr healthValues, int size);

		// -(short *)getHealthValues;
		[Export ("getHealthValues")]
		
		IntPtr HealthValues { get; }

		// -(int)getHealthValuesSize;
		[Export ("getHealthValuesSize")]
		
		int HealthValuesSize { get; }

		// -(void)setHealth:(int)health;
		[Export ("setHealth:")]
		void SetHealth (int health);

		// -(int)getHealth;
		[Export ("getHealth")]
		
		int Health { get; }
	}

	interface ICommandContextDelegate {}

	// @protocol CommandContextDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject), Name = "ICommandContextDelegate")]
	interface CommandContextDelegate
	{
		// @required -(void)run:(id<ISktScanObject>)scanObj;
		[Abstract]
		[Export ("run:")]
		void Run (ISktScanObject scanObj);
	}

	// @interface CommandContext : NSObject
	[BaseType (typeof(NSObject), Name = "CommandContext")]
	interface CommandContext
	{
		// @property (readwrite, nonatomic) int retry;
		[Export ("retry")]
		int Retry { get; set; }

		// @property (readwrite, nonatomic) enum eStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		eStatus Status { get; set; }

		// -(id)initWithParam:(BOOL)getOperation ScanObj:(id<ISktScanObject>)scanObj ScanDevice:(id<ISktScanDevice>)scanDevice Device:(DeviceInfo *)device Target:(id)target Response:(SEL)response;
		[Export ("initWithParam:ScanObj:ScanDevice:Device:Target:Response:")]
		IntPtr Constructor (bool getOperation, ISktScanObject scanObj, SktScanDevice scanDevice, DeviceInfo device, NSObject target, Selector response);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(id<ISktScanDevice>)getScanDevice;
		[Export ("getScanDevice")]
		
		SktScanDevice ScanDevice { get; }

		// -(id<ISktScanObject>)getScanObject;
		[Export ("getScanObject")]
		
		ISktScanObject ScanObject { get; }

		// -(SKTRESULT)doCallback:(id<ISktScanObject>)scanObj;
		[Export ("doCallback:")]
		nint DoCallback (ISktScanObject scanObj);

		// -(SKTRESULT)doCommand;
		[Export ("doCommand")]
		
		nint DoCommand { get; }
	}

	interface IScanApiHelperDelegate {}

	// @protocol ScanApiHelperDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject), Name = "IScanApiHelperDelegate")]
	interface ScanApiHelperDelegate
	{
		// @optional -(void)onDeviceArrival:(SKTRESULT)result device:(IDeviceInfo *)deviceInfo;
		[Export ("onDeviceArrival:device:")]
		void OnDeviceArrival (nint result, DeviceInfo deviceInfo);

		// @optional -(void)onDeviceRemoval:(IDeviceInfo *)deviceRemoved;
		[Export ("onDeviceRemoval:")]
		void OnDeviceRemoval (DeviceInfo deviceRemoved);

		// @optional -(void)onError:(SKTRESULT)result;
		[Export ("onError:")]
		void OnError (nint result);

		// @optional -(void)onScanApiInitializeComplete:(SKTRESULT)result;
		[Export ("onScanApiInitializeComplete:")]
		void OnScanApiInitializeComplete (nint result);

		// @optional -(void)onScanApiTerminated;
		[Export ("onScanApiTerminated")]
		void OnScanApiTerminated ();

		// @optional -(void)onErrorRetrievingScanObject:(SKTRESULT)result;
		[Export ("onErrorRetrievingScanObject:")]
		void OnErrorRetrievingScanObject (nint result);

		// @optional -(void)onDecodedDataResult:(long)result device:(DeviceInfo *)device decodedData:(id<ISktScanDecodedData>)decodedData;
		[Export ("onDecodedDataResult:device:decodedData:")]
		void OnDecodedDataResult (nint result, DeviceInfo device, ISktScanDecodedData decodedData);

		// @optional -(void)onDecodedData:(DeviceInfo *)device decodedData:(id<ISktScanDecodedData>)decodedData;
		[Export ("onDecodedData:decodedData:")]
		void OnDecodedData (DeviceInfo device, ISktScanDecodedData decodedData);
	}

	// @interface ScanApiHelper : NSObject
	[BaseType (typeof(NSObject), Name = "ScanApiHelper")]
	interface ScanApiHelper
	{
		// +(ScanApiHelper *)sharedScanApiHelper;
		[Static]
		[Export ("sharedScanApiHelper")]
		ScanApiHelper SharedScanApiHelper { get; }

		// -(void)pushDelegate:(id<ScanApiHelperDelegate>)delegate;
		[Export ("pushDelegate:")]
		void PushDelegate (ScanApiHelperDelegate Delegate);

		// -(void)popDelegate:(id<ScanApiHelperDelegate>)delegate;
		[Export ("popDelegate:")]
		void PopDelegate (ScanApiHelperDelegate Delegate);

		// -(void)setDelegate:(id<ScanApiHelperDelegate>)delegate;
		[Export ("setDelegate:")]
		void SetDelegate (ScanApiHelperDelegate Delegate);

		// -(void)setNoDeviceText:(NSString *)noDeviceText;
		[Export ("setNoDeviceText:")]
		void SetNoDeviceText (string noDeviceText);

		// -(NSDictionary *)getDevicesList;
		[Export ("getDevicesList")]
		
		NSDictionary DevicesList { get; }

		// -(DeviceInfo *)getDeviceInfoFromScanObject:(id<ISktScanObject>)scanObj;
		[Export ("getDeviceInfoFromScanObject:")]
		DeviceInfo GetDeviceInfoFromScanObject (ISktScanObject scanObj);

		// -(BOOL)isDeviceConnected;
		[Export ("isDeviceConnected")]
		
		bool IsDeviceConnected { get; }

		// -(BOOL)isScanApiOpen;
		[Export ("isScanApiOpen")]
		
		bool IsScanApiOpen { get; }

		// -(void)open;
		[Export ("open")]
		void Open ();

		// -(void)close;
		[Export ("close")]
		void Close ();

		// -(SKTRESULT)doScanApiReceive;
		[Export ("doScanApiReceive")]
		
		nint DoScanApiReceive ();

		// -(void)removeCommand:(DeviceInfo *)deviceInfo;
		[Export ("removeCommand:")]
		void RemoveCommand (DeviceInfo deviceInfo);

		// -(void)postGetScanApiVersion:(id)target Response:(SEL)response;
		[Export ("postGetScanApiVersion:Response:")]
		void PostGetScanApiVersion (NSObject target, Selector response);

		// -(void)postSetConfirmationMode:(unsigned char)mode Target:(id)target Response:(SEL)response;
		[Export ("postSetConfirmationMode:Target:Response:")]
		void PostSetConfirmationMode (byte mode, NSObject target, Selector response);

		// -(void)postScanApiAbort:(id)target Response:(SEL)response;
		[Export ("postScanApiAbort:Response:")]
		void PostScanApiAbort (NSObject target, Selector response);

		// -(void)postSetDataConfirmation:(DeviceInfo *)deviceInfo Target:(id)target Response:(SEL)response;
		[Export ("postSetDataConfirmation:Target:Response:")]
		void PostSetDataConfirmation (DeviceInfo deviceInfo, NSObject target, Selector response);

		// -(void)postSetSoftScanStatus:(unsigned char)action Target:(id)target Response:(SEL)response;
		[Export ("postSetSoftScanStatus:Target:Response:")]
		void PostSetSoftScanStatus (byte action, NSObject target, Selector response);

		// -(void)postGetSoftScanStatus:(id)target Response:(SEL)response;
		[Export ("postGetSoftScanStatus:Response:")]
		void PostGetSoftScanStatus (NSObject target, Selector response);

		// -(void)postGetBtAddress:(DeviceInfo *)deviceInfo Target:(id)target Response:(SEL)response;
		[Export ("postGetBtAddress:Target:Response:")]
		void PostGetBtAddress (DeviceInfo deviceInfo, NSObject target, Selector response);

		// -(void)postGetDeviceType:(DeviceInfo *)deviceInfo Target:(id)target Response:(SEL)response;
		[Export ("postGetDeviceType:Target:Response:")]
		void PostGetDeviceType (DeviceInfo deviceInfo, NSObject target, Selector response);

		// -(void)postGetFirmwareVersion:(DeviceInfo *)deviceInfo Target:(id)target Response:(SEL)response;
		[Export ("postGetFirmwareVersion:Target:Response:")]
		void PostGetFirmwareVersion (DeviceInfo deviceInfo, NSObject target, Selector response);

		// -(void)postGetBattery:(DeviceInfo *)deviceInfo Target:(id)target Response:(SEL)response;
		[Export ("postGetBattery:Target:Response:")]
		void PostGetBattery (DeviceInfo deviceInfo, NSObject target, Selector response);

		// -(void)postGetStandConfig:(DeviceInfo *)deviceInfo Target:(id)target Response:(SEL)response;
		[Export ("postGetStandConfig:Target:Response:")]
		void PostGetStandConfig (DeviceInfo deviceInfo, NSObject target, Selector response);

		// -(void)postSetStandConfig:(DeviceInfo *)deviceInfo StandConfig:(long)standConfig Target:(id)target Response:(SEL)response;
		[Export ("postSetStandConfig:StandConfig:Target:Response:")]
		void PostSetStandConfig (DeviceInfo deviceInfo, nint standConfig, NSObject target, Selector response);

		// -(void)postGetDecodeAction:(DeviceInfo *)deviceInfo Target:(id)target Response:(SEL)response;
		[Export ("postGetDecodeAction:Target:Response:")]
		void PostGetDecodeAction (DeviceInfo deviceInfo, NSObject target, Selector response);

		// -(void)postGetCapabilitiesDevice:(DeviceInfo *)deviceInfo Target:(id)target Response:(SEL)response;
		[Export ("postGetCapabilitiesDevice:Target:Response:")]
		void PostGetCapabilitiesDevice (DeviceInfo deviceInfo, NSObject target, Selector response);

		// -(void)postGetPostambleDevice:(DeviceInfo *)deviceInfo Target:(id)target Response:(SEL)response;
		[Export ("postGetPostambleDevice:Target:Response:")]
		void PostGetPostambleDevice (DeviceInfo deviceInfo, NSObject target, Selector response);

		// -(void)postSetPostambleDevice:(DeviceInfo *)deviceInfo Postamble:(NSString *)postamble Target:(id)target Response:(SEL)response;
		[Export ("postSetPostambleDevice:Postamble:Target:Response:")]
		void PostSetPostambleDevice (DeviceInfo deviceInfo, string postamble, NSObject target, Selector response);

		// -(void)postGetSymbologyInfo:(DeviceInfo *)deviceInfo SymbologyId:(int)symbologyId Target:(id)target Response:(SEL)response;
		[Export ("postGetSymbologyInfo:SymbologyId:Target:Response:")]
		void PostGetSymbologyInfo (DeviceInfo deviceInfo, int symbologyId, NSObject target, Selector response);

		// -(void)postSetSymbologyInfo:(DeviceInfo *)deviceInfo SymbologyId:(int)symbologyId Status:(BOOL)status Target:(id)target Response:(SEL)response;
		[Export ("postSetSymbologyInfo:SymbologyId:Status:Target:Response:")]
		void PostSetSymbologyInfo (DeviceInfo deviceInfo, int symbologyId, bool status, NSObject target, Selector response);

		// -(void)postGetFriendlyName:(DeviceInfo *)deviceInfo Target:(id)target Response:(SEL)response;
		[Export ("postGetFriendlyName:Target:Response:")]
		void PostGetFriendlyName (DeviceInfo deviceInfo, NSObject target, Selector response);

		// -(void)postSetFriendlyName:(DeviceInfo *)deviceInfo FriendlyName:(NSString *)friendlyName Target:(id)target Response:(SEL)response;
		[Export ("postSetFriendlyName:FriendlyName:Target:Response:")]
		void PostSetFriendlyName (DeviceInfo deviceInfo, string friendlyName, NSObject target, Selector response);

		// -(void)postSetDecodeAction:(DeviceInfo *)deviceInfo DecodeAction:(int)decodeAction Target:(id)target Response:(SEL)response;
		[Export ("postSetDecodeAction:DecodeAction:Target:Response:")]
		void PostSetDecodeAction (DeviceInfo deviceInfo, int decodeAction, NSObject target, Selector response);

		// -(void)postSetOverlayView:(DeviceInfo *)deviceInfo OverlayView:(id)overlayview Target:(id)target Response:(SEL)response;
		[Export ("postSetOverlayView:OverlayView:Target:Response:")]
		void PostSetOverlayView (DeviceInfo deviceInfo, NSObject overlayview, NSObject target, Selector response);

		// -(void)postSetTriggerDevice:(DeviceInfo *)deviceInfo Action:(unsigned char)action Target:(id)target Response:(SEL)response;
		[Export ("postSetTriggerDevice:Action:Target:Response:")]
		void PostSetTriggerDevice (DeviceInfo deviceInfo, byte action, NSObject target, Selector response);

		// -(void)postGetDataEditingProfiles:(id)target Response:(SEL)response;
		[Export ("postGetDataEditingProfiles:Response:")]
		void PostGetDataEditingProfiles (NSObject target, Selector response);

		// -(void)postSetDataEditingProfiles:(NSString *)profiles Target:(id)target Response:(SEL)response;
		[Export ("postSetDataEditingProfiles:Target:Response:")]
		void PostSetDataEditingProfiles (string profiles, NSObject target, Selector response);

		// -(void)postGetDataEditingCurrentProfile:(id)target Response:(SEL)response;
		[Export ("postGetDataEditingCurrentProfile:Response:")]
		void PostGetDataEditingCurrentProfile (NSObject target, Selector response);

		// -(void)postSetDataEditingCurrentProfile:(NSString *)profile Target:(id)target Response:(SEL)response;
		[Export ("postSetDataEditingCurrentProfile:Target:Response:")]
		void PostSetDataEditingCurrentProfile (string profile, NSObject target, Selector response);

		// -(void)postGetDataEditingTriggerSymbology:(NSString *)profile Target:(id)target Response:(SEL)response;
		[Export ("postGetDataEditingTriggerSymbology:Target:Response:")]
		void PostGetDataEditingTriggerSymbology (string profile, NSObject target, Selector response);

		// -(void)postSetDataEditingTriggerSymbology:(NSString *)profileAndSymbology Target:(id)target Response:(SEL)response;
		[Export ("postSetDataEditingTriggerSymbology:Target:Response:")]
		void PostSetDataEditingTriggerSymbology (string profileAndSymbology, NSObject target, Selector response);

		// -(void)postGetDataEditingTriggerMinLength:(NSString *)profile Target:(id)target Response:(SEL)response;
		[Export ("postGetDataEditingTriggerMinLength:Target:Response:")]
		void PostGetDataEditingTriggerMinLength (string profile, NSObject target, Selector response);

		// -(void)postSetDataEditingTriggerMinLength:(NSString *)profileAndLength Target:(id)target Response:(SEL)response;
		[Export ("postSetDataEditingTriggerMinLength:Target:Response:")]
		void PostSetDataEditingTriggerMinLength (string profileAndLength, NSObject target, Selector response);

		// -(void)postGetDataEditingTriggerMaxLength:(NSString *)profile Target:(id)target Response:(SEL)response;
		[Export ("postGetDataEditingTriggerMaxLength:Target:Response:")]
		void PostGetDataEditingTriggerMaxLength (string profile, NSObject target, Selector response);

		// -(void)postSetDataEditingTriggerMaxLength:(NSString *)profileAndLength Target:(id)target Response:(SEL)response;
		[Export ("postSetDataEditingTriggerMaxLength:Target:Response:")]
		void PostSetDataEditingTriggerMaxLength (string profileAndLength, NSObject target, Selector response);

		// -(void)postGetDataEditingTriggerStartsBy:(NSString *)profile Target:(id)target Response:(SEL)response;
		[Export ("postGetDataEditingTriggerStartsBy:Target:Response:")]
		void PostGetDataEditingTriggerStartsBy (string profile, NSObject target, Selector response);

		// -(void)postSetDataEditingTriggerStartsBy:(NSString *)profileAndString Target:(id)target Response:(SEL)response;
		[Export ("postSetDataEditingTriggerStartsBy:Target:Response:")]
		void PostSetDataEditingTriggerStartsBy (string profileAndString, NSObject target, Selector response);

		// -(void)postGetDataEditingTriggerEndsWith:(NSString *)profile Target:(id)target Response:(SEL)response;
		[Export ("postGetDataEditingTriggerEndsWith:Target:Response:")]
		void PostGetDataEditingTriggerEndsWith (string profile, NSObject target, Selector response);

		// -(void)postSetDataEditingTriggerEndsWith:(NSString *)profileAndString Target:(id)target Response:(SEL)response;
		[Export ("postSetDataEditingTriggerEndsWith:Target:Response:")]
		void PostSetDataEditingTriggerEndsWith (string profileAndString, NSObject target, Selector response);

		// -(void)postGetDataEditingTriggerContains:(NSString *)profile Target:(id)target Response:(SEL)response;
		[Export ("postGetDataEditingTriggerContains:Target:Response:")]
		void PostGetDataEditingTriggerContains (string profile, NSObject target, Selector response);

		// -(void)postSetDataEditingTriggerContains:(NSString *)profileAndString Target:(id)target Response:(SEL)response;
		[Export ("postSetDataEditingTriggerContains:Target:Response:")]
		void PostSetDataEditingTriggerContains (string profileAndString, NSObject target, Selector response);

		// -(void)postGetDataEditingOperations:(NSString *)profile Target:(id)target Response:(SEL)response;
		[Export ("postGetDataEditingOperations:Target:Response:")]
		void PostGetDataEditingOperations (string profile, NSObject target, Selector response);

		// -(void)postSetDataEditingOperations:(NSString *)profileAndOperations Target:(id)target Response:(SEL)response;
		[Export ("postSetDataEditingOperations:Target:Response:")]
		void PostSetDataEditingOperations (string profileAndOperations, NSObject target, Selector response);

		// -(void)postGetDataEditingExport:(NSString *)profile Target:(id)target Response:(SEL)response;
		[Export ("postGetDataEditingExport:Target:Response:")]
		void PostGetDataEditingExport (string profile, NSObject target, Selector response);

		// -(void)postSetDataEditingImport:(NSString *)profile Target:(id)target Response:(SEL)response;
		[Export ("postSetDataEditingImport:Target:Response:")]
		void PostSetDataEditingImport (string profile, NSObject target, Selector response);

		// -(void)postGetDeviceSpecific:(DeviceInfo *)deviceInfo Command:(unsigned char *)pCommand Length:(int)length Target:(id)target Response:(SEL)response;
		[Export ("postGetDeviceSpecific:Command:Length:Target:Response:")]
		void PostGetDeviceSpecific (DeviceInfo deviceInfo, IntPtr pCommand, int length, NSObject target, Selector response);

		// -(void)addCommand:(CommandContext *)command;
		[Export ("addCommand:")]
		void AddCommand (CommandContext command);

		// -(void)initializeScanAPIThread:(id)arg;
		[Export ("initializeScanAPIThread:")]
		void InitializeScanAPIThread (NSObject arg);

		// -(BOOL)handleScanObject:(id<ISktScanObject>)scanObj;
		[Export ("handleScanObject:")]
		bool HandleScanObject (ISktScanObject scanObj);

		// -(SKTRESULT)handleDeviceArrival:(id<ISktScanObject>)scanObj;
		[Export ("handleDeviceArrival:")]
		nint HandleDeviceArrival (ISktScanObject scanObj);

		// -(SKTRESULT)handleDeviceRemoval:(id<ISktScanObject>)scanObj;
		[Export ("handleDeviceRemoval:")]
		nint HandleDeviceRemoval (ISktScanObject scanObj);

		// -(SKTRESULT)handleSetOrGetComplete:(id<ISktScanObject>)scanObj;
		[Export ("handleSetOrGetComplete:")]
		nint HandleSetOrGetComplete (ISktScanObject scanObj);

		// -(SKTRESULT)handleEvent:(id<ISktScanObject>)scanObj;
		[Export ("handleEvent:")]
		nint HandleEvent (ISktScanObject scanObj);

		// -(SKTRESULT)handleDecodedData:(id<ISktScanObject>)scanObj;
		[Export ("handleDecodedData:")]
		nint HandleDecodedData (ISktScanObject scanObj);

		// -(SKTRESULT)sendNextCommand;
		[Export ("sendNextCommand")]
		
		nint SendNextCommand { get; }
	}
}