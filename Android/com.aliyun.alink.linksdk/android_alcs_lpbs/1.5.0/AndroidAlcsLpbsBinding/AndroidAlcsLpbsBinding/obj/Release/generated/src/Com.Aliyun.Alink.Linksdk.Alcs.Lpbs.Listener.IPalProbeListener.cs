using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalProbeListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalProbeListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListenerInvoker")]
	public partial interface IPalProbeListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalProbeListener']/method[@name='onComplete' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalProbeResult']]"
		[Register ("onComplete", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalProbeResult;)V", "GetOnComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalProbeResult_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListenerInvoker, AndroidAlcsLpbsBinding")]
		void OnComplete (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalProbeResult p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalProbeListener", DoNotGenerateAcw=true)]
	internal partial class IPalProbeListenerInvoker : global::Java.Lang.Object, IPalProbeListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalProbeListener", typeof (IPalProbeListenerInvoker));

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

		public static IPalProbeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPalProbeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.listener.PalProbeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPalProbeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalProbeResult_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalProbeResult_Handler ()
		{
			if (cb_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalProbeResult_ == null)
				cb_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalProbeResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalProbeResult_);
			return cb_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalProbeResult_;
		}

		static void n_OnComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalProbeResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalProbeResult p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalProbeResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalProbeResult_;
		public unsafe void OnComplete (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalProbeResult p1)
		{
			if (id_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalProbeResult_ == IntPtr.Zero)
				id_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalProbeResult_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalProbeResult;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalProbeResult_, __args);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.lpbs.listener.PalProbeListener.onComplete
	public partial class PalProbeEventArgs : global::System.EventArgs {

		public PalProbeEventArgs (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalProbeResult p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo P0 {
			get { return p0; }
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalProbeResult p1;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalProbeResult P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/lpbs/listener/PalProbeListenerImplementor")]
	internal sealed partial class IPalProbeListenerImplementor : global::Java.Lang.Object, IPalProbeListener {

		object sender;

		public IPalProbeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/lpbs/listener/PalProbeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PalProbeEventArgs> Handler;
#pragma warning restore 0649

		public void OnComplete (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalProbeResult p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PalProbeEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IPalProbeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
