using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IJsQeuryCallback']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IJsQeuryCallback", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsQeuryCallbackInvoker")]
	public partial interface IJsQeuryCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IJsQeuryCallback']/method[@name='onLoad' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onLoad", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnLoad_Ljava_lang_String_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsQeuryCallbackInvoker, AndroidAlcsLpbsBinding")]
		void OnLoad (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IJsQeuryCallback", DoNotGenerateAcw=true)]
	internal partial class IJsQeuryCallbackInvoker : global::Java.Lang.Object, IJsQeuryCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IJsQeuryCallback", typeof (IJsQeuryCallbackInvoker));

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

		public static IJsQeuryCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJsQeuryCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IJsQeuryCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJsQeuryCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLoad_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnLoad_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onLoad_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onLoad_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLoad_Ljava_lang_String_Ljava_lang_String_);
			return cb_onLoad_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnLoad_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsQeuryCallback __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsQeuryCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLoad (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onLoad_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnLoad (string p0, string p1)
		{
			if (id_onLoad_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onLoad_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onLoad", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoad_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
