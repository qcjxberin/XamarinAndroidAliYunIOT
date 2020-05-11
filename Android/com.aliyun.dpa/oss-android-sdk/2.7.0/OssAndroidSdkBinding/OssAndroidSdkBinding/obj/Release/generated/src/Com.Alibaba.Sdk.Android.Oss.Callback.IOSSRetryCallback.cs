using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Callback {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.oss.callback']/interface[@name='OSSRetryCallback']"
	[Register ("com/alibaba/sdk/android/oss/callback/OSSRetryCallback", "", "Com.Alibaba.Sdk.Android.Oss.Callback.IOSSRetryCallbackInvoker")]
	public partial interface IOSSRetryCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.callback']/interface[@name='OSSRetryCallback']/method[@name='onRetryCallback' and count(parameter)=0]"
		[Register ("onRetryCallback", "()V", "GetOnRetryCallbackHandler:Com.Alibaba.Sdk.Android.Oss.Callback.IOSSRetryCallbackInvoker, OssAndroidSdkBinding")]
		void OnRetryCallback ();

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/callback/OSSRetryCallback", DoNotGenerateAcw=true)]
	internal partial class IOSSRetryCallbackInvoker : global::Java.Lang.Object, IOSSRetryCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/callback/OSSRetryCallback", typeof (IOSSRetryCallbackInvoker));

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

		public static IOSSRetryCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOSSRetryCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.oss.callback.OSSRetryCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOSSRetryCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRetryCallback;
#pragma warning disable 0169
		static Delegate GetOnRetryCallbackHandler ()
		{
			if (cb_onRetryCallback == null)
				cb_onRetryCallback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRetryCallback);
			return cb_onRetryCallback;
		}

		static void n_OnRetryCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSRetryCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSRetryCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRetryCallback ();
		}
#pragma warning restore 0169

		IntPtr id_onRetryCallback;
		public unsafe void OnRetryCallback ()
		{
			if (id_onRetryCallback == IntPtr.Zero)
				id_onRetryCallback = JNIEnv.GetMethodID (class_ref, "onRetryCallback", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRetryCallback);
		}

	}

}
