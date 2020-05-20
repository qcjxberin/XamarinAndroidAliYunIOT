using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener {

	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener", DoNotGenerateAcw=true)]
	public abstract class PalDeviceStateListener : Java.Lang.Object {

		internal PalDeviceStateListener ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalDeviceStateListener']/field[@name='STATE_CONNECTED']"
		[Register ("STATE_CONNECTED")]
		public const int StateConnected = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalDeviceStateListener']/field[@name='STATE_CONNECTING']"
		[Register ("STATE_CONNECTING")]
		public const int StateConnecting = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalDeviceStateListener']/field[@name='STATE_DISCONNECTED']"
		[Register ("STATE_DISCONNECTED")]
		public const int StateDisconnected = (int) 0;
	}

	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'PalDeviceStateListener' type. This type will be removed in a future release.", error: true)]
	public abstract class PalDeviceStateListenerConsts : PalDeviceStateListener {

		private PalDeviceStateListenerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalDeviceStateListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListenerInvoker")]
	public partial interface IPalDeviceStateListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalDeviceStateListener']/method[@name='onDeviceStateChange' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='int']]"
		[Register ("onDeviceStateChange", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;I)V", "GetOnDeviceStateChange_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_IHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListenerInvoker, AndroidAlcsLpbsBinding")]
		void OnDeviceStateChange (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, int p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener", DoNotGenerateAcw=true)]
	internal partial class IPalDeviceStateListenerInvoker : global::Java.Lang.Object, IPalDeviceStateListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener", typeof (IPalDeviceStateListenerInvoker));

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

		public static IPalDeviceStateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPalDeviceStateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDeviceStateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPalDeviceStateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDeviceStateChange_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_I;
#pragma warning disable 0169
		static Delegate GetOnDeviceStateChange_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_IHandler ()
		{
			if (cb_onDeviceStateChange_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_I == null)
				cb_onDeviceStateChange_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnDeviceStateChange_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_I);
			return cb_onDeviceStateChange_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_I;
		}

		static void n_OnDeviceStateChange_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDeviceStateChange (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDeviceStateChange_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_I;
		public unsafe void OnDeviceStateChange (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, int p1)
		{
			if (id_onDeviceStateChange_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_I == IntPtr.Zero)
				id_onDeviceStateChange_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_I = JNIEnv.GetMethodID (class_ref, "onDeviceStateChange", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDeviceStateChange_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_I, __args);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDeviceStateListener.onDeviceStateChange
	public partial class PalDeviceStateEventArgs : global::System.EventArgs {

		public PalDeviceStateEventArgs (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListenerImplementor")]
	internal sealed partial class IPalDeviceStateListenerImplementor : global::Java.Lang.Object, IPalDeviceStateListener {

		object sender;

		public IPalDeviceStateListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PalDeviceStateEventArgs> Handler;
#pragma warning restore 0649

		public void OnDeviceStateChange (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PalDeviceStateEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IPalDeviceStateListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
