using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3']/interface[@name='Callback']"
	[Register ("okhttp3/Callback", "", "Okhttp3.ICallbackInvoker")]
	public partial interface ICallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Callback']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='java.io.IOException']]"
		[Register ("onFailure", "(Lokhttp3/Call;Ljava/io/IOException;)V", "GetOnFailure_Lokhttp3_Call_Ljava_io_IOException_Handler:Okhttp3.ICallbackInvoker, OkHttpBinding")]
		void OnFailure (global::Okhttp3.ICall p0, global::Java.IO.IOException p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Callback']/method[@name='onResponse' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='okhttp3.Response']]"
		[Register ("onResponse", "(Lokhttp3/Call;Lokhttp3/Response;)V", "GetOnResponse_Lokhttp3_Call_Lokhttp3_Response_Handler:Okhttp3.ICallbackInvoker, OkHttpBinding")]
		void OnResponse (global::Okhttp3.ICall p0, global::Okhttp3.Response p1);

	}

	[global::Android.Runtime.Register ("okhttp3/Callback", DoNotGenerateAcw=true)]
	internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Callback", typeof (ICallbackInvoker));

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

		public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.Callback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Lokhttp3_Call_Ljava_io_IOException_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lokhttp3_Call_Ljava_io_IOException_Handler ()
		{
			if (cb_onFailure_Lokhttp3_Call_Ljava_io_IOException_ == null)
				cb_onFailure_Lokhttp3_Call_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Lokhttp3_Call_Ljava_io_IOException_);
			return cb_onFailure_Lokhttp3_Call_Ljava_io_IOException_;
		}

		static void n_OnFailure_Lokhttp3_Call_Ljava_io_IOException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.ICallback __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall p0 = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.IOException p1 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Lokhttp3_Call_Ljava_io_IOException_;
		public unsafe void OnFailure (global::Okhttp3.ICall p0, global::Java.IO.IOException p1)
		{
			if (id_onFailure_Lokhttp3_Call_Ljava_io_IOException_ == IntPtr.Zero)
				id_onFailure_Lokhttp3_Call_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lokhttp3/Call;Ljava/io/IOException;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lokhttp3_Call_Ljava_io_IOException_, __args);
		}

		static Delegate cb_onResponse_Lokhttp3_Call_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetOnResponse_Lokhttp3_Call_Lokhttp3_Response_Handler ()
		{
			if (cb_onResponse_Lokhttp3_Call_Lokhttp3_Response_ == null)
				cb_onResponse_Lokhttp3_Call_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResponse_Lokhttp3_Call_Lokhttp3_Response_);
			return cb_onResponse_Lokhttp3_Call_Lokhttp3_Response_;
		}

		static void n_OnResponse_Lokhttp3_Call_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.ICallback __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall p0 = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Response p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onResponse_Lokhttp3_Call_Lokhttp3_Response_;
		public unsafe void OnResponse (global::Okhttp3.ICall p0, global::Okhttp3.Response p1)
		{
			if (id_onResponse_Lokhttp3_Call_Lokhttp3_Response_ == IntPtr.Zero)
				id_onResponse_Lokhttp3_Call_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Lokhttp3/Call;Lokhttp3/Response;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Lokhttp3_Call_Lokhttp3_Response_, __args);
		}

	}

}
