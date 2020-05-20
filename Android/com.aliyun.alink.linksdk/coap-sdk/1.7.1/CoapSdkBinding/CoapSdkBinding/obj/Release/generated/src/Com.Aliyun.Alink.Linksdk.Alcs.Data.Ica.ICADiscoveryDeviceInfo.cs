using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICADiscoveryDeviceInfo']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/data/ica/ICADiscoveryDeviceInfo", DoNotGenerateAcw=true)]
	public partial class ICADiscoveryDeviceInfo : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICADiscoveryDeviceInfo']/field[@name='addr']"
		[Register ("addr")]
		public string Addr {
			get {
				const string __id = "addr.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "addr.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICADiscoveryDeviceInfo']/field[@name='deviceInfo']"
		[Register ("deviceInfo")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo DeviceInfo {
			get {
				const string __id = "deviceInfo.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deviceInfo.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICADiscoveryDeviceInfo']/field[@name='pal']"
		[Register ("pal")]
		public string Pal {
			get {
				const string __id = "pal.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pal.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICADiscoveryDeviceInfo']/field[@name='port']"
		[Register ("port")]
		public int Port {
			get {
				const string __id = "port.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "port.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICADiscoveryDeviceInfo']/field[@name='tslData']"
		[Register ("tslData")]
		public string TslData {
			get {
				const string __id = "tslData.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tslData.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/data/ica/ICADiscoveryDeviceInfo", typeof (ICADiscoveryDeviceInfo));
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

		protected ICADiscoveryDeviceInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICADiscoveryDeviceInfo']/constructor[@name='ICADiscoveryDeviceInfo' and count(parameter)=4 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Ljava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe ICADiscoveryDeviceInfo (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo deviceInfo, string addr, int port, string pal)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Ljava/lang/String;ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_addr = JNIEnv.NewString (addr);
			IntPtr native_pal = JNIEnv.NewString (pal);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((deviceInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceInfo).Handle);
				__args [1] = new JniArgumentValue (native_addr);
				__args [2] = new JniArgumentValue (port);
				__args [3] = new JniArgumentValue (native_pal);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_addr);
				JNIEnv.DeleteLocalRef (native_pal);
			}
		}

		static Delegate cb_isDataNeedConvert;
#pragma warning disable 0169
		static Delegate GetIsDataNeedConvertHandler ()
		{
			if (cb_isDataNeedConvert == null)
				cb_isDataNeedConvert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDataNeedConvert);
			return cb_isDataNeedConvert;
		}

		static bool n_IsDataNeedConvert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADiscoveryDeviceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADiscoveryDeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDataNeedConvert;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDataNeedConvert {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICADiscoveryDeviceInfo']/method[@name='isDataNeedConvert' and count(parameter)=0]"
			[Register ("isDataNeedConvert", "()Z", "GetIsDataNeedConvertHandler")]
			get {
				const string __id = "isDataNeedConvert.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDataToCloud;
#pragma warning disable 0169
		static Delegate GetIsDataToCloudHandler ()
		{
			if (cb_isDataToCloud == null)
				cb_isDataToCloud = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDataToCloud);
			return cb_isDataToCloud;
		}

		static bool n_IsDataToCloud (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADiscoveryDeviceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADiscoveryDeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDataToCloud;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDataToCloud {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICADiscoveryDeviceInfo']/method[@name='isDataToCloud' and count(parameter)=0]"
			[Register ("isDataToCloud", "()Z", "GetIsDataToCloudHandler")]
			get {
				const string __id = "isDataToCloud.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPkDnNeedConvert;
#pragma warning disable 0169
		static Delegate GetIsPkDnNeedConvertHandler ()
		{
			if (cb_isPkDnNeedConvert == null)
				cb_isPkDnNeedConvert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPkDnNeedConvert);
			return cb_isPkDnNeedConvert;
		}

		static bool n_IsPkDnNeedConvert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADiscoveryDeviceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADiscoveryDeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPkDnNeedConvert;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPkDnNeedConvert {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICADiscoveryDeviceInfo']/method[@name='isPkDnNeedConvert' and count(parameter)=0]"
			[Register ("isPkDnNeedConvert", "()Z", "GetIsPkDnNeedConvertHandler")]
			get {
				const string __id = "isPkDnNeedConvert.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
