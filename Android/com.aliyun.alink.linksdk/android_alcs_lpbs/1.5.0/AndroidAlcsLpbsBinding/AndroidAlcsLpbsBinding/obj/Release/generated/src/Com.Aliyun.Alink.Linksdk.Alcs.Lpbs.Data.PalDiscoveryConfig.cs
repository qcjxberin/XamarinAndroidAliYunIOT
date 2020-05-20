using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalDiscoveryConfig']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryConfig", DoNotGenerateAcw=true)]
	public partial class PalDiscoveryConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalDiscoveryConfig']/field[@name='DISCOVERY_PLUGINID_BREEZE']"
		[Register ("DISCOVERY_PLUGINID_BREEZE")]
		public const string DiscoveryPluginidBreeze = (string) "com.aliyun.iot.breeze.lpbs";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalDiscoveryConfig']/field[@name='DISCOVERY_PLUGINID_ICA']"
		[Register ("DISCOVERY_PLUGINID_ICA")]
		public const string DiscoveryPluginidIca = (string) "iot_ica";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalDiscoveryConfig']/field[@name='DISCOVERY_STRATEGY_LOWENERGY']"
		[Register ("DISCOVERY_STRATEGY_LOWENERGY")]
		public const int DiscoveryStrategyLowenergy = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalDiscoveryConfig']/field[@name='DISCOVERY_STRATEGY_LOWLATENCY']"
		[Register ("DISCOVERY_STRATEGY_LOWLATENCY")]
		public const int DiscoveryStrategyLowlatency = (int) 1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalDiscoveryConfig']/field[@name='mDiscoveryStrategy']"
		[Register ("mDiscoveryStrategy")]
		public int MDiscoveryStrategy {
			get {
				const string __id = "mDiscoveryStrategy.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mDiscoveryStrategy.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalDiscoveryConfig']/field[@name='mPluginIdList']"
		[Register ("mPluginIdList")]
		public global::System.Collections.IList MPluginIdList {
			get {
				const string __id = "mPluginIdList.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPluginIdList.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryConfig", typeof (PalDiscoveryConfig));
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

		protected PalDiscoveryConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalDiscoveryConfig']/constructor[@name='PalDiscoveryConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PalDiscoveryConfig ()
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

	}
}
