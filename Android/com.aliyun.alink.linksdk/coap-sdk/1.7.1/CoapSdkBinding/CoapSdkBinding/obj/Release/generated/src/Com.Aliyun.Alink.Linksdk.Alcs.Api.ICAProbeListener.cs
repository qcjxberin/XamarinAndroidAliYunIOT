using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api {

	[Register ("com/aliyun/alink/linksdk/alcs/api/ICAProbeListener", DoNotGenerateAcw=true)]
	public abstract class CAProbeListener : Java.Lang.Object {

		internal CAProbeListener ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAProbeListener']/field[@name='ALCS_SEND_OK']"
		[Register ("ALCS_SEND_OK")]
		public const int AlcsSendOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAProbeListener']/field[@name='ALCS_SEND_RSPERROR']"
		[Register ("ALCS_SEND_RSPERROR")]
		public const int AlcsSendRsperror = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAProbeListener']/field[@name='ALCS_SEND_TIMEOUT']"
		[Register ("ALCS_SEND_TIMEOUT")]
		public const int AlcsSendTimeout = (int) 1;
	}

	[Register ("com/aliyun/alink/linksdk/alcs/api/ICAProbeListener", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'CAProbeListener' type. This type will be removed in a future release.", error: true)]
	public abstract class CAProbeListenerConsts : CAProbeListener {

		private CAProbeListenerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAProbeListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/api/ICAProbeListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAProbeListenerInvoker")]
	public partial interface ICAProbeListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAProbeListener']/method[@name='onComplete' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo'] and parameter[2][@type='int']]"
		[Register ("onComplete", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;I)V", "GetOnComplete_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_IHandler:Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAProbeListenerInvoker, CoapSdkBinding")]
		void OnComplete (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0, int p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/ICAProbeListener", DoNotGenerateAcw=true)]
	internal partial class ICAProbeListenerInvoker : global::Java.Lang.Object, ICAProbeListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/ICAProbeListener", typeof (ICAProbeListenerInvoker));

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

		public static ICAProbeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICAProbeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.api.ICAProbeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICAProbeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onComplete_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_I;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_IHandler ()
		{
			if (cb_onComplete_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_I == null)
				cb_onComplete_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnComplete_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_I);
			return cb_onComplete_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_I;
		}

		static void n_OnComplete_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAProbeListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAProbeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_I;
		public unsafe void OnComplete (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0, int p1)
		{
			if (id_onComplete_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_I == IntPtr.Zero)
				id_onComplete_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_I = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_I, __args);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.api.ICAProbeListener.onComplete
	public partial class CAProbeEventArgs : global::System.EventArgs {

		public CAProbeEventArgs (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/api/ICAProbeListenerImplementor")]
	internal sealed partial class ICAProbeListenerImplementor : global::Java.Lang.Object, ICAProbeListener {

		object sender;

		public ICAProbeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/api/ICAProbeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CAProbeEventArgs> Handler;
#pragma warning restore 0649

		public void OnComplete (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CAProbeEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ICAProbeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
