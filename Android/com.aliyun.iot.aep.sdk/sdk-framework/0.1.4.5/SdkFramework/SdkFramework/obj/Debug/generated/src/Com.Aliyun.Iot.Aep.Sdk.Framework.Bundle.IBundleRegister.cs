using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Bundle {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.bundle']/interface[@name='IBundleRegister']"
	[Register ("com/aliyun/iot/aep/sdk/framework/bundle/IBundleRegister", "", "Com.Aliyun.Iot.Aep.Sdk.Framework.Bundle.IBundleRegisterInvoker")]
	public partial interface IBundleRegister : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.bundle']/interface[@name='IBundleRegister']/method[@name='registerPage' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.aliyun.iot.aep.sdk.framework.bundle.PageConfigure']]"
		[Register ("registerPage", "(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/bundle/PageConfigure;)V", "GetRegisterPage_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_bundle_PageConfigure_Handler:Com.Aliyun.Iot.Aep.Sdk.Framework.Bundle.IBundleRegisterInvoker, SdkFramework")]
		void RegisterPage (global::Android.App.Application p0, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Bundle.PageConfigure p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/bundle/IBundleRegister", DoNotGenerateAcw=true)]
	internal partial class IBundleRegisterInvoker : global::Java.Lang.Object, IBundleRegister {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/bundle/IBundleRegister", typeof (IBundleRegisterInvoker));

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

		public static IBundleRegister GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBundleRegister> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.framework.bundle.IBundleRegister"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBundleRegisterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_registerPage_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_bundle_PageConfigure_;
#pragma warning disable 0169
		static Delegate GetRegisterPage_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_bundle_PageConfigure_Handler ()
		{
			if (cb_registerPage_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_bundle_PageConfigure_ == null)
				cb_registerPage_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_bundle_PageConfigure_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterPage_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_bundle_PageConfigure_);
			return cb_registerPage_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_bundle_PageConfigure_;
		}

		static void n_RegisterPage_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_bundle_PageConfigure_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Bundle.IBundleRegister __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Bundle.IBundleRegister> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application p0 = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Bundle.PageConfigure p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Bundle.PageConfigure> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterPage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_registerPage_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_bundle_PageConfigure_;
		public unsafe void RegisterPage (global::Android.App.Application p0, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Bundle.PageConfigure p1)
		{
			if (id_registerPage_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_bundle_PageConfigure_ == IntPtr.Zero)
				id_registerPage_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_bundle_PageConfigure_ = JNIEnv.GetMethodID (class_ref, "registerPage", "(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/bundle/PageConfigure;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerPage_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_bundle_PageConfigure_, __args);
		}

	}

}
