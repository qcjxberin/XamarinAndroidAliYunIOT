using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Credential.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.listener']/interface[@name='OnReqCompanyCallback']"
	[Register ("com/aliyun/iot/aep/sdk/credential/listener/OnReqCompanyCallback", "", "Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IOnReqCompanyCallbackInvoker")]
	public partial interface IOnReqCompanyCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.listener']/interface[@name='OnReqCompanyCallback']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;com.aliyun.iot.aep.sdk.credential.data.CompanyData&gt;']]"
		[Register ("onSuccess", "(ILjava/util/List;)V", "GetOnSuccess_ILjava_util_List_Handler:Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IOnReqCompanyCallbackInvoker, IotCredentialBinding")]
		void OnSuccess (int p0, global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.CompanyData> p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/credential/listener/OnReqCompanyCallback", DoNotGenerateAcw=true)]
	internal partial class IOnReqCompanyCallbackInvoker : global::Java.Lang.Object, IOnReqCompanyCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/credential/listener/OnReqCompanyCallback", typeof (IOnReqCompanyCallbackInvoker));

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

		public static IOnReqCompanyCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnReqCompanyCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.credential.listener.OnReqCompanyCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnReqCompanyCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSuccess_ILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_ILjava_util_List_Handler ()
		{
			if (cb_onSuccess_ILjava_util_List_ == null)
				cb_onSuccess_ILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnSuccess_ILjava_util_List_);
			return cb_onSuccess_ILjava_util_List_;
		}

		static void n_OnSuccess_ILjava_util_List_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IOnReqCompanyCallback __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IOnReqCompanyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.CompanyData>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_ILjava_util_List_;
		public unsafe void OnSuccess (int p0, global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.CompanyData> p1)
		{
			if (id_onSuccess_ILjava_util_List_ == IntPtr.Zero)
				id_onSuccess_ILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(ILjava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.CompanyData>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_ILjava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
