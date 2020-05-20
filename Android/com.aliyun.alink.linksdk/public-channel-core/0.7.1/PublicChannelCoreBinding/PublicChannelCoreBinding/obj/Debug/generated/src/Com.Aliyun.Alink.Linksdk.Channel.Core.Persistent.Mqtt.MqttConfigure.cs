using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/mqtt/MqttConfigure", DoNotGenerateAcw=true)]
	public partial class MqttConfigure : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='DEFAULT_HOST']"
		[Register ("DEFAULT_HOST")]
		public const string DefaultHost = (string) "${productKey}.iot-as-mqtt.cn-shanghai.aliyuncs.com:1883";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='DEFAULT_ITLS_HOST']"
		[Register ("DEFAULT_ITLS_HOST")]
		public const string DefaultItlsHost = (string) "${productKey}.itls.cn-shanghai.aliyuncs.com:1883";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='DEFAULT_ROOTCRT']"
		[Register ("DEFAULT_ROOTCRT")]
		public const string DefaultRootcrt = (string) "root.crt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='MQTT_SECURE_MODE_ITLS']"
		[Register ("MQTT_SECURE_MODE_ITLS")]
		public const int MqttSecureModeItls = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='MQTT_SECURE_MODE_TCP']"
		[Register ("MQTT_SECURE_MODE_TCP")]
		public const int MqttSecureModeTcp = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='MQTT_SECURE_MODE_TLS']"
		[Register ("MQTT_SECURE_MODE_TLS")]
		public const int MqttSecureModeTls = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='SECURE_MODE']"
		[Register ("SECURE_MODE")]
		public static int SecureMode {
			get {
				const string __id = "SECURE_MODE.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "SECURE_MODE.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='SIGN_METHOD']"
		[Register ("SIGN_METHOD")]
		public const string SignMethod = (string) "hmacsha1";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='automaticReconnect']"
		[Register ("automaticReconnect")]
		public static bool AutomaticReconnect {
			get {
				const string __id = "automaticReconnect.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "automaticReconnect.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='cleanSession']"
		[Register ("cleanSession")]
		public static bool CleanSession {
			get {
				const string __id = "cleanSession.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "cleanSession.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='clientId']"
		[Register ("clientId")]
		public static string ClientId {
			get {
				const string __id = "clientId.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "clientId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='deviceName']"
		[Register ("deviceName")]
		public static string DeviceName {
			get {
				const string __id = "deviceName.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deviceName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='deviceSecret']"
		[Register ("deviceSecret")]
		public static string DeviceSecret {
			get {
				const string __id = "deviceSecret.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deviceSecret.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='disableNetworkCheckBeforeSend']"
		[Register ("disableNetworkCheckBeforeSend")]
		public static bool DisableNetworkCheckBeforeSend {
			get {
				const string __id = "disableNetworkCheckBeforeSend.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "disableNetworkCheckBeforeSend.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='isCheckRootCrt']"
		[Register ("isCheckRootCrt")]
		public static bool IsCheckRootCrt {
			get {
				const string __id = "isCheckRootCrt.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "isCheckRootCrt.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='itlsLogLevel']"
		[Register ("itlsLogLevel")]
		public static int ItlsLogLevel {
			get {
				const string __id = "itlsLogLevel.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "itlsLogLevel.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='itlsReadTimeout']"
		[Register ("itlsReadTimeout")]
		public static int ItlsReadTimeout {
			get {
				const string __id = "itlsReadTimeout.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "itlsReadTimeout.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='itlsWriteTimeout']"
		[Register ("itlsWriteTimeout")]
		public static int ItlsWriteTimeout {
			get {
				const string __id = "itlsWriteTimeout.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "itlsWriteTimeout.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='maxInflight']"
		[Register ("maxInflight")]
		public static int MaxInflight {
			get {
				const string __id = "maxInflight.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "maxInflight.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='mqttClientId']"
		[Register ("mqttClientId")]
		public static string MqttClientId {
			get {
				const string __id = "mqttClientId.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mqttClientId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='mqttHost']"
		[Register ("mqttHost")]
		public static string MqttHost {
			get {
				const string __id = "mqttHost.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mqttHost.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='mqttPassWord']"
		[Register ("mqttPassWord")]
		public static string MqttPassWord {
			get {
				const string __id = "mqttPassWord.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mqttPassWord.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='mqttRootCrtFile']"
		[Register ("mqttRootCrtFile")]
		public static global::System.IO.Stream MqttRootCrtFile {
			get {
				const string __id = "mqttRootCrtFile.Ljava/io/InputStream;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mqttRootCrtFile.Ljava/io/InputStream;";

				IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='mqttUserName']"
		[Register ("mqttUserName")]
		public static string MqttUserName {
			get {
				const string __id = "mqttUserName.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mqttUserName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='pingSender']"
		[Register ("pingSender")]
		public static global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender PingSender {
			get {
				const string __id = "pingSender.Lorg/eclipse/paho/client/mqttv3/MqttPingSender;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pingSender.Lorg/eclipse/paho/client/mqttv3/MqttPingSender;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='pingSenderType']"
		[Register ("pingSenderType")]
		public static string PingSenderType {
			get {
				const string __id = "pingSenderType.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pingSenderType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='productKey']"
		[Register ("productKey")]
		public static string ProductKey {
			get {
				const string __id = "productKey.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "productKey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/field[@name='productSecret']"
		[Register ("productSecret")]
		public static string ProductSecret {
			get {
				const string __id = "productSecret.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "productSecret.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/mqtt/MqttConfigure", typeof (MqttConfigure));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected MqttConfigure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/constructor[@name='MqttConfigure' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttConfigure ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe int KeepAliveInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/method[@name='getKeepAliveInterval' and count(parameter)=0]"
			[Register ("getKeepAliveInterval", "()I", "")]
			get {
				const string __id = "getKeepAliveInterval.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt']/class[@name='MqttConfigure']/method[@name='setKeepAliveInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setKeepAliveInterval", "(I)Z", "")]
		public static unsafe bool SetKeepAliveInterval (int p0)
		{
			const string __id = "setKeepAliveInterval.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
