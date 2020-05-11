using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Callback {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.oss.callback']/interface[@name='OSSProgressCallback']"
	[Register ("com/alibaba/sdk/android/oss/callback/OSSProgressCallback", "", "Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IOSSProgressCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.callback']/interface[@name='OSSProgressCallback']/method[@name='onProgress' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onProgress", "(Ljava/lang/Object;JJ)V", "GetOnProgress_Ljava_lang_Object_JJHandler:Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallbackInvoker, OssAndroidSdkBinding")]
		void OnProgress (global::Java.Lang.Object p0, long p1, long p2);

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/callback/OSSProgressCallback", DoNotGenerateAcw=true)]
	internal partial class IOSSProgressCallbackInvoker : global::Java.Lang.Object, IOSSProgressCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/callback/OSSProgressCallback", typeof (IOSSProgressCallbackInvoker));

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

		public static IOSSProgressCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOSSProgressCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.oss.callback.OSSProgressCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOSSProgressCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onProgress_Ljava_lang_Object_JJ;
#pragma warning disable 0169
		static Delegate GetOnProgress_Ljava_lang_Object_JJHandler ()
		{
			if (cb_onProgress_Ljava_lang_Object_JJ == null)
				cb_onProgress_Ljava_lang_Object_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, long>) n_OnProgress_Ljava_lang_Object_JJ);
			return cb_onProgress_Ljava_lang_Object_JJ;
		}

		static void n_OnProgress_Ljava_lang_Object_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnProgress (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onProgress_Ljava_lang_Object_JJ;
		public unsafe void OnProgress (global::Java.Lang.Object p0, long p1, long p2)
		{
			if (id_onProgress_Ljava_lang_Object_JJ == IntPtr.Zero)
				id_onProgress_Ljava_lang_Object_JJ = JNIEnv.GetMethodID (class_ref, "onProgress", "(Ljava/lang/Object;JJ)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgress_Ljava_lang_Object_JJ, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
