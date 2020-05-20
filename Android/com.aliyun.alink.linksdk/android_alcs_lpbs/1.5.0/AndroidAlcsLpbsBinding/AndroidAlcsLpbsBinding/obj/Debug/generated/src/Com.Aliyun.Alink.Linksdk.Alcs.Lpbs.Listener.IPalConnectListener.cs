using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener {

	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListener", DoNotGenerateAcw=true)]
	public abstract class PalConnectListener : Java.Lang.Object {

		internal PalConnectListener ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalConnectListener']/field[@name='PAL_CONN_AUTHLISTEMPTY']"
		[Register ("PAL_CONN_AUTHLISTEMPTY")]
		public const int PalConnAuthlistempty = (int) 504;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalConnectListener']/field[@name='PAL_CONN_FAIL_UNKNOWN']"
		[Register ("PAL_CONN_FAIL_UNKNOWN")]
		public const int PalConnFailUnknown = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalConnectListener']/field[@name='PAL_CONN_ILLEGALSIGN']"
		[Register ("PAL_CONN_ILLEGALSIGN")]
		public const int PalConnIllegalsign = (int) 506;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalConnectListener']/field[@name='PAL_CONN_INVALIDPARAM']"
		[Register ("PAL_CONN_INVALIDPARAM")]
		public const int PalConnInvalidparam = (int) 503;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalConnectListener']/field[@name='PAL_CONN_OK']"
		[Register ("PAL_CONN_OK")]
		public const int PalConnOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalConnectListener']/field[@name='PAL_CONN_REVOCATE']"
		[Register ("PAL_CONN_REVOCATE")]
		public const int PalConnRevocate = (int) 501;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalConnectListener']/field[@name='PAL_CONN_UNMATCHPREFIX']"
		[Register ("PAL_CONN_UNMATCHPREFIX")]
		public const int PalConnUnmatchprefix = (int) 502;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalConnectListener']/field[@name='PAL_CONN_VERNOTSUPPORT']"
		[Register ("PAL_CONN_VERNOTSUPPORT")]
		public const int PalConnVernotsupport = (int) 505;
	}

	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListener", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'PalConnectListener' type. This type will be removed in a future release.", error: true)]
	public abstract class PalConnectListenerConsts : PalConnectListener {

		private PalConnectListenerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalConnectListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListenerInvoker")]
	public partial interface IPalConnectListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalConnectListener']/method[@name='onLoad' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("onLoad", "(ILjava/util/Map;Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)V", "GetOnLoad_ILjava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListenerInvoker, AndroidAlcsLpbsBinding")]
		void OnLoad (int p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p2);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListener", DoNotGenerateAcw=true)]
	internal partial class IPalConnectListenerInvoker : global::Java.Lang.Object, IPalConnectListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListener", typeof (IPalConnectListenerInvoker));

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

		public static IPalConnectListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPalConnectListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.listener.PalConnectListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPalConnectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLoad_ILjava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetOnLoad_ILjava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_onLoad_ILjava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_onLoad_ILjava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnLoad_ILjava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_onLoad_ILjava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static void n_OnLoad_ILjava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnLoad (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onLoad_ILjava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		public unsafe void OnLoad (int p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p2)
		{
			if (id_onLoad_ILjava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == IntPtr.Zero)
				id_onLoad_ILjava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNIEnv.GetMethodID (class_ref, "onLoad", "(ILjava/util/Map;Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoad_ILjava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.lpbs.listener.PalConnectListener.onLoad
	public partial class PalConnectEventArgs : global::System.EventArgs {

		public PalConnectEventArgs (int p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1;
		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> P1 {
			get { return p1; }
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p2;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListenerImplementor")]
	internal sealed partial class IPalConnectListenerImplementor : global::Java.Lang.Object, IPalConnectListener {

		object sender;

		public IPalConnectListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PalConnectEventArgs> Handler;
#pragma warning restore 0649

		public void OnLoad (int p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PalConnectEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IPalConnectListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
