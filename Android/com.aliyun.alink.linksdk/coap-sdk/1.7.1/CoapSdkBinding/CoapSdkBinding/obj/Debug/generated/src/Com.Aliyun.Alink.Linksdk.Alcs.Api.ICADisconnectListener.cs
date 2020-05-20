using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICADisconnectListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/api/ICADisconnectListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Api.ICADisconnectListenerInvoker")]
	public partial interface ICADisconnectListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICADisconnectListener']/method[@name='onDisConnect' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo']]"
		[Register ("onDisConnect", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)V", "GetOnDisConnect_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Api.ICADisconnectListenerInvoker, CoapSdkBinding")]
		void OnDisConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/ICADisconnectListener", DoNotGenerateAcw=true)]
	internal partial class ICADisconnectListenerInvoker : global::Java.Lang.Object, ICADisconnectListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/ICADisconnectListener", typeof (ICADisconnectListenerInvoker));

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

		public static ICADisconnectListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICADisconnectListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.api.ICADisconnectListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICADisconnectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDisConnect_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_;
#pragma warning disable 0169
		static Delegate GetOnDisConnect_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_Handler ()
		{
			if (cb_onDisConnect_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ == null)
				cb_onDisConnect_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDisConnect_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_);
			return cb_onDisConnect_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_;
		}

		static void n_OnDisConnect_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICADisconnectListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICADisconnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisConnect (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDisConnect_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_;
		public unsafe void OnDisConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0)
		{
			if (id_onDisConnect_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ == IntPtr.Zero)
				id_onDisConnect_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_ = JNIEnv.GetMethodID (class_ref, "onDisConnect", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisConnect_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICADeviceInfo_, __args);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.api.ICADisconnectListener.onDisConnect
	public partial class CADisconnectEventArgs : global::System.EventArgs {

		public CADisconnectEventArgs (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0)
		{
			this.p0 = p0;
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/api/ICADisconnectListenerImplementor")]
	internal sealed partial class ICADisconnectListenerImplementor : global::Java.Lang.Object, ICADisconnectListener {

		object sender;

		public ICADisconnectListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/api/ICADisconnectListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CADisconnectEventArgs> Handler;
#pragma warning restore 0649

		public void OnDisConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CADisconnectEventArgs (p0));
		}

		internal static bool __IsEmpty (ICADisconnectListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
