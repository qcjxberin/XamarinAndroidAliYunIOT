using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica {

	[Register ("com/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener", DoNotGenerateAcw=true)]
	public abstract class CADiscoveryListener : Java.Lang.Object {

		internal CADiscoveryListener ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/interface[@name='ICADiscoveryListener']/field[@name='PAL_DLCP_RAW']"
		[Register ("PAL_DLCP_RAW")]
		public const string PalDlcpRaw = (string) "dlcp-raw";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/interface[@name='ICADiscoveryListener']/field[@name='PAL_LINKKIT_ICA']"
		[Register ("PAL_LINKKIT_ICA")]
		public const string PalLinkkitIca = (string) "ali-ica";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/interface[@name='ICADiscoveryListener']/field[@name='PAL_LINKKIT_RAW']"
		[Register ("PAL_LINKKIT_RAW")]
		public const string PalLinkkitRaw = (string) "linkkit-raw";
	}

	[Register ("com/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'CADiscoveryListener' type. This type will be removed in a future release.", error: true)]
	public abstract class CADiscoveryListenerConsts : CADiscoveryListener {

		private CADiscoveryListenerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/interface[@name='ICADiscoveryListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica.ICADiscoveryListenerInvoker")]
	public partial interface ICADiscoveryListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/interface[@name='ICADiscoveryListener']/method[@name='onDiscoveryDevice' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo']]"
		[Register ("onDiscoveryDevice", "(Ljava/lang/String;ILjava/lang/String;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)V", "GetOnDiscoveryDevice_Ljava_lang_String_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica.ICADiscoveryListenerInvoker, CoapSdkBinding")]
		void OnDiscoveryDevice (string p0, int p1, string p2, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/interface[@name='ICADiscoveryListener']/method[@name='onDiscoveryFinish' and count(parameter)=0]"
		[Register ("onDiscoveryFinish", "()V", "GetOnDiscoveryFinishHandler:Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica.ICADiscoveryListenerInvoker, CoapSdkBinding")]
		void OnDiscoveryFinish ();

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener", DoNotGenerateAcw=true)]
	internal partial class ICADiscoveryListenerInvoker : global::Java.Lang.Object, ICADiscoveryListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener", typeof (ICADiscoveryListenerInvoker));

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

		public static ICADiscoveryListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICADiscoveryListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.pal.ica.ICADiscoveryListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICADiscoveryListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDiscoveryDevice_Ljava_lang_String_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_;
#pragma warning disable 0169
		static Delegate GetOnDiscoveryDevice_Ljava_lang_String_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_Handler ()
		{
			if (cb_onDiscoveryDevice_Ljava_lang_String_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ == null)
				cb_onDiscoveryDevice_Ljava_lang_String_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnDiscoveryDevice_Ljava_lang_String_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_);
			return cb_onDiscoveryDevice_Ljava_lang_String_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_;
		}

		static void n_OnDiscoveryDevice_Ljava_lang_String_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica.ICADiscoveryListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica.ICADiscoveryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p3 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnDiscoveryDevice (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onDiscoveryDevice_Ljava_lang_String_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_;
		public unsafe void OnDiscoveryDevice (string p0, int p1, string p2, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p3)
		{
			if (id_onDiscoveryDevice_Ljava_lang_String_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ == IntPtr.Zero)
				id_onDiscoveryDevice_Ljava_lang_String_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ = JNIEnv.GetMethodID (class_ref, "onDiscoveryDevice", "(Ljava/lang/String;ILjava/lang/String;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDiscoveryDevice_Ljava_lang_String_ILjava_lang_String_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onDiscoveryFinish;
#pragma warning disable 0169
		static Delegate GetOnDiscoveryFinishHandler ()
		{
			if (cb_onDiscoveryFinish == null)
				cb_onDiscoveryFinish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDiscoveryFinish);
			return cb_onDiscoveryFinish;
		}

		static void n_OnDiscoveryFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica.ICADiscoveryListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica.ICADiscoveryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDiscoveryFinish ();
		}
#pragma warning restore 0169

		IntPtr id_onDiscoveryFinish;
		public unsafe void OnDiscoveryFinish ()
		{
			if (id_onDiscoveryFinish == IntPtr.Zero)
				id_onDiscoveryFinish = JNIEnv.GetMethodID (class_ref, "onDiscoveryFinish", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDiscoveryFinish);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.pal.ica.ICADiscoveryListener.onDiscoveryDevice
	public partial class DiscoveryDeviceEventArgs : global::System.EventArgs {

		public DiscoveryDeviceEventArgs (string p0, int p1, string p2, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p3;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListenerImplementor")]
	internal sealed partial class ICADiscoveryListenerImplementor : global::Java.Lang.Object, ICADiscoveryListener {

		object sender;

		public ICADiscoveryListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DiscoveryDeviceEventArgs> OnDiscoveryDeviceHandler;
#pragma warning restore 0649

		public void OnDiscoveryDevice (string p0, int p1, string p2, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p3)
		{
			var __h = OnDiscoveryDeviceHandler;
			if (__h != null)
				__h (sender, new DiscoveryDeviceEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler OnDiscoveryFinishHandler;
#pragma warning restore 0649

		public void OnDiscoveryFinish ()
		{
			var __h = OnDiscoveryFinishHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ICADiscoveryListenerImplementor value)
		{
			return value.OnDiscoveryDeviceHandler == null && value.OnDiscoveryFinishHandler == null;
		}
	}

}
