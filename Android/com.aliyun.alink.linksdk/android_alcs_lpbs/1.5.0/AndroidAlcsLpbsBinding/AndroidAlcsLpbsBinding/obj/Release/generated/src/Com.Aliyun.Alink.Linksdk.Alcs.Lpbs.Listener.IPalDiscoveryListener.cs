using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalDiscoveryListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListenerInvoker")]
	public partial interface IPalDiscoveryListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalDiscoveryListener']/method[@name='onDiscoveryDevice' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDiscoveryDeviceInfo']]"
		[Register ("onDiscoveryDevice", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryDeviceInfo;)V", "GetOnDiscoveryDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListenerInvoker, AndroidAlcsLpbsBinding")]
		void OnDiscoveryDevice (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalDiscoveryListener']/method[@name='onDiscoveryFinish' and count(parameter)=0]"
		[Register ("onDiscoveryFinish", "()V", "GetOnDiscoveryFinishHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListenerInvoker, AndroidAlcsLpbsBinding")]
		void OnDiscoveryFinish ();

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener", DoNotGenerateAcw=true)]
	internal partial class IPalDiscoveryListenerInvoker : global::Java.Lang.Object, IPalDiscoveryListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener", typeof (IPalDiscoveryListenerInvoker));

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

		public static IPalDiscoveryListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPalDiscoveryListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPalDiscoveryListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDiscoveryDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetOnDiscoveryDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Handler ()
		{
			if (cb_onDiscoveryDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_ == null)
				cb_onDiscoveryDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDiscoveryDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_);
			return cb_onDiscoveryDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_;
		}

		static void n_OnDiscoveryDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDiscoveryDevice (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDiscoveryDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_;
		public unsafe void OnDiscoveryDevice (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p0)
		{
			if (id_onDiscoveryDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_ == IntPtr.Zero)
				id_onDiscoveryDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_ = JNIEnv.GetMethodID (class_ref, "onDiscoveryDevice", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryDeviceInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDiscoveryDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_, __args);
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// event args for com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener.onDiscoveryDevice
	public partial class DiscoveryDeviceEventArgs : global::System.EventArgs {

		public DiscoveryDeviceEventArgs (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p0)
		{
			this.p0 = p0;
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p0;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListenerImplementor")]
	internal sealed partial class IPalDiscoveryListenerImplementor : global::Java.Lang.Object, IPalDiscoveryListener {

		object sender;

		public IPalDiscoveryListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DiscoveryDeviceEventArgs> OnDiscoveryDeviceHandler;
#pragma warning restore 0649

		public void OnDiscoveryDevice (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p0)
		{
			var __h = OnDiscoveryDeviceHandler;
			if (__h != null)
				__h (sender, new DiscoveryDeviceEventArgs (p0));
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

		internal static bool __IsEmpty (IPalDiscoveryListenerImplementor value)
		{
			return value.OnDiscoveryDeviceHandler == null && value.OnDiscoveryFinishHandler == null;
		}
	}

}
