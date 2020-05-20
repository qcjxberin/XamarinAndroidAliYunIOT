using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api {

	[Register ("com/aliyun/alink/linksdk/alcs/api/ICAConnectListener", DoNotGenerateAcw=true)]
	public abstract class CAConnectListener : Java.Lang.Object {

		internal CAConnectListener ()
		{
		}

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

	[Register ("com/aliyun/alink/linksdk/alcs/api/ICAConnectListener", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'CAConnectListener' type. This type will be removed in a future release.", error: true)]
	public abstract class CAConnectListenerConsts : CAConnectListener {

		private CAConnectListenerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAConnectListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/api/ICAConnectListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAConnectListenerInvoker")]
	public partial interface ICAConnectListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAConnectListener']/method[@name='onLoad' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo']]"
		[Register ("onLoad", "(ILjava/lang/String;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)V", "GetOnLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAConnectListenerInvoker, CoapSdkBinding")]
		void OnLoad (int p0, string p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p2);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/ICAConnectListener", DoNotGenerateAcw=true)]
	internal partial class ICAConnectListenerInvoker : global::Java.Lang.Object, ICAConnectListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/ICAConnectListener", typeof (ICAConnectListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ICAConnectListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICAConnectListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.api.ICAConnectListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICAConnectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_;
#pragma warning disable 0169
		static Delegate GetOnLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_Handler ()
		{
			if (cb_onLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ == null)
				cb_onLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_);
			return cb_onLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_;
		}

		static void n_OnLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAConnectListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnLoad (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_;
		public unsafe void OnLoad (int p0, string p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p2)
		{
			if (id_onLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ == IntPtr.Zero)
				id_onLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ = JNIEnv.GetMethodID (class_ref, "onLoad", "(ILjava/lang/String;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoad_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.api.ICAConnectListener.onLoad
	public partial class CAConnectEventArgs : global::System.EventArgs {

		public CAConnectEventArgs (int p0, string p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p2;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/api/ICAConnectListenerImplementor")]
	internal sealed partial class ICAConnectListenerImplementor : global::Java.Lang.Object, ICAConnectListener {

		object sender;

		public ICAConnectListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/api/ICAConnectListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CAConnectEventArgs> Handler;
#pragma warning restore 0649

		public void OnLoad (int p0, string p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CAConnectEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (ICAConnectListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
