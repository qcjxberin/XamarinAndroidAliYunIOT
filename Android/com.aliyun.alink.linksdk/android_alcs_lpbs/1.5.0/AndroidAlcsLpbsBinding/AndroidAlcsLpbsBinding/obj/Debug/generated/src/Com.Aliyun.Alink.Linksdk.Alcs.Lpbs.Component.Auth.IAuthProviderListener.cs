using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.auth']/interface[@name='IAuthProviderListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProviderListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProviderListenerInvoker")]
	public partial interface IAuthProviderListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.auth']/interface[@name='IAuthProviderListener']/method[@name='onComplete' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onComplete", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Ljava/lang/Object;)V", "GetOnComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_Object_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProviderListenerInvoker, AndroidAlcsLpbsBinding")]
		void OnComplete (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProviderListener", DoNotGenerateAcw=true)]
	internal partial class IAuthProviderListenerInvoker : global::Java.Lang.Object, IAuthProviderListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProviderListener", typeof (IAuthProviderListenerInvoker));

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

		public static IAuthProviderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthProviderListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.component.auth.IAuthProviderListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthProviderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_Object_Handler ()
		{
			if (cb_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_Object_ == null)
				cb_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_Object_);
			return cb_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_Object_;
		}

		static void n_OnComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProviderListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProviderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_Object_;
		public unsafe void OnComplete (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Java.Lang.Object p1)
		{
			if (id_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_Object_ == IntPtr.Zero)
				id_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_Object_, __args);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.lpbs.component.auth.IAuthProviderListener.onComplete
	public partial class AuthProviderEventArgs : global::System.EventArgs {

		public AuthProviderEventArgs (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Java.Lang.Object p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo P0 {
			get { return p0; }
		}

		global::Java.Lang.Object p1;
		public global::Java.Lang.Object P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProviderListenerImplementor")]
	internal sealed partial class IAuthProviderListenerImplementor : global::Java.Lang.Object, IAuthProviderListener {

		object sender;

		public IAuthProviderListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProviderListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AuthProviderEventArgs> Handler;
#pragma warning restore 0649

		public void OnComplete (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Java.Lang.Object p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AuthProviderEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IAuthProviderListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
