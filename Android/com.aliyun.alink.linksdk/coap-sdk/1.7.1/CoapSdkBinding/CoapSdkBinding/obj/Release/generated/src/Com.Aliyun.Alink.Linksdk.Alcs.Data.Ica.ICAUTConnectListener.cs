using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAUTConnectListener']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/data/ica/ICAUTConnectListener", DoNotGenerateAcw=true)]
	public partial class ICAUTConnectListener : global::Java.Lang.Object, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAConnectListener {


		public static class InterfaceConsts {

			// The following are fields from: com.aliyun.alink.linksdk.alcs.api.ICAConnectListener

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAConnectListener']/field[@name='ALCS_CONN_AUTHLISTEMPTY']"
			[Register ("ALCS_CONN_AUTHLISTEMPTY")]
			public const int AlcsConnAuthlistempty = (int) 504;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAConnectListener']/field[@name='ALCS_CONN_ILLEGALSIGN']"
			[Register ("ALCS_CONN_ILLEGALSIGN")]
			public const int AlcsConnIllegalsign = (int) 506;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAConnectListener']/field[@name='ALCS_CONN_INVALIDPARAM']"
			[Register ("ALCS_CONN_INVALIDPARAM")]
			public const int AlcsConnInvalidparam = (int) 503;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAConnectListener']/field[@name='ALCS_CONN_OK']"
			[Register ("ALCS_CONN_OK")]
			public const int AlcsConnOk = (int) 200;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAConnectListener']/field[@name='ALCS_CONN_REVOCATE']"
			[Register ("ALCS_CONN_REVOCATE")]
			public const int AlcsConnRevocate = (int) 501;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAConnectListener']/field[@name='ALCS_CONN_UNMATCHPREFIX']"
			[Register ("ALCS_CONN_UNMATCHPREFIX")]
			public const int AlcsConnUnmatchprefix = (int) 502;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAConnectListener']/field[@name='ALCS_CONN_VERNOTSUPPORT']"
			[Register ("ALCS_CONN_VERNOTSUPPORT")]
			public const int AlcsConnVernotsupport = (int) 505;
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/data/ica/ICAUTConnectListener", typeof (ICAUTConnectListener));
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

		protected ICAUTConnectListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAUTConnectListener']/constructor[@name='ICAUTConnectListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.api.ICAConnectListener'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICAUTPointEx']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/api/ICAConnectListener;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAUTPointEx;)V", "")]
		public unsafe ICAUTConnectListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAConnectListener listener, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAUTPointEx icautPointEx)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/api/ICAConnectListener;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAUTPointEx;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue ((icautPointEx == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icautPointEx).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_;
#pragma warning disable 0169
		static Delegate GetOnLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_Handler ()
		{
			if (cb_onLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ == null)
				cb_onLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_);
			return cb_onLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_;
		}

		static void n_OnLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ (IntPtr jnienv, IntPtr native__this, int errorCode, IntPtr native_msg, IntPtr native_deviceInfo)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAUTConnectListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAUTConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo deviceInfo = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo> (native_deviceInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnLoad (errorCode, msg, deviceInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAUTConnectListener']/method[@name='onLoad' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo']]"
		[Register ("onLoad", "(ILjava/lang/String;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)V", "GetOnLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_Handler")]
		public virtual unsafe void OnLoad (int errorCode, string msg, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo deviceInfo)
		{
			const string __id = "onLoad.(ILjava/lang/String;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (errorCode);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((deviceInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceInfo).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}
}
