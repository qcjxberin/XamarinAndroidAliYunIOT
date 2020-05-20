using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http2 {

	[Register ("okhttp3/internal/http2/PushObserver", DoNotGenerateAcw=true)]
	public abstract class PushObserver : Java.Lang.Object {

		internal PushObserver ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='PushObserver']/field[@name='CANCEL']"
		[Register ("CANCEL")]
		public static global::Okhttp3.Internal.Http2.IPushObserver Cancel {
			get {
				const string __id = "CANCEL.Lokhttp3/internal/http2/PushObserver;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.IPushObserver> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/PushObserver", typeof (PushObserver));
	}

	[Register ("okhttp3/internal/http2/PushObserver", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'PushObserver' type. This type will be removed in a future release.", error: true)]
	public abstract class PushObserverConsts : PushObserver {

		private PushObserverConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='PushObserver']"
	[Register ("okhttp3/internal/http2/PushObserver", "", "Okhttp3.Internal.Http2.IPushObserverInvoker")]
	public partial interface IPushObserver : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='PushObserver']/method[@name='onHeaders' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;'] and parameter[3][@type='boolean']]"
		[Register ("onHeaders", "(ILjava/util/List;Z)Z", "GetOnHeaders_ILjava_util_List_ZHandler:Okhttp3.Internal.Http2.IPushObserverInvoker, OkHttpBinding")]
		bool OnHeaders (int p0, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='PushObserver']/method[@name='onRequest' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;']]"
		[Register ("onRequest", "(ILjava/util/List;)Z", "GetOnRequest_ILjava_util_List_Handler:Okhttp3.Internal.Http2.IPushObserverInvoker, OkHttpBinding")]
		bool OnRequest (int p0, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='PushObserver']/method[@name='onReset' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='okhttp3.internal.http2.ErrorCode']]"
		[Register ("onReset", "(ILokhttp3/internal/http2/ErrorCode;)V", "GetOnReset_ILokhttp3_internal_http2_ErrorCode_Handler:Okhttp3.Internal.Http2.IPushObserverInvoker, OkHttpBinding")]
		void OnReset (int p0, global::Okhttp3.Internal.Http2.ErrorCode p1);

	}

	[global::Android.Runtime.Register ("okhttp3/internal/http2/PushObserver", DoNotGenerateAcw=true)]
	internal partial class IPushObserverInvoker : global::Java.Lang.Object, IPushObserver {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/PushObserver", typeof (IPushObserverInvoker));

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

		public static IPushObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPushObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.http2.PushObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPushObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onHeaders_ILjava_util_List_Z;
#pragma warning disable 0169
		static Delegate GetOnHeaders_ILjava_util_List_ZHandler ()
		{
			if (cb_onHeaders_ILjava_util_List_Z == null)
				cb_onHeaders_ILjava_util_List_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool, bool>) n_OnHeaders_ILjava_util_List_Z);
			return cb_onHeaders_ILjava_util_List_Z;
		}

		static bool n_OnHeaders_ILjava_util_List_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, bool p2)
		{
			global::Okhttp3.Internal.Http2.IPushObserver __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.IPushObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnHeaders (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onHeaders_ILjava_util_List_Z;
		public unsafe bool OnHeaders (int p0, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> p1, bool p2)
		{
			if (id_onHeaders_ILjava_util_List_Z == IntPtr.Zero)
				id_onHeaders_ILjava_util_List_Z = JNIEnv.GetMethodID (class_ref, "onHeaders", "(ILjava/util/List;Z)Z");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onHeaders_ILjava_util_List_Z, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_onRequest_ILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnRequest_ILjava_util_List_Handler ()
		{
			if (cb_onRequest_ILjava_util_List_ == null)
				cb_onRequest_ILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnRequest_ILjava_util_List_);
			return cb_onRequest_ILjava_util_List_;
		}

		static bool n_OnRequest_ILjava_util_List_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Http2.IPushObserver __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.IPushObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnRequest (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onRequest_ILjava_util_List_;
		public unsafe bool OnRequest (int p0, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> p1)
		{
			if (id_onRequest_ILjava_util_List_ == IntPtr.Zero)
				id_onRequest_ILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "onRequest", "(ILjava/util/List;)Z");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onRequest_ILjava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_onReset_ILokhttp3_internal_http2_ErrorCode_;
#pragma warning disable 0169
		static Delegate GetOnReset_ILokhttp3_internal_http2_ErrorCode_Handler ()
		{
			if (cb_onReset_ILokhttp3_internal_http2_ErrorCode_ == null)
				cb_onReset_ILokhttp3_internal_http2_ErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnReset_ILokhttp3_internal_http2_ErrorCode_);
			return cb_onReset_ILokhttp3_internal_http2_ErrorCode_;
		}

		static void n_OnReset_ILokhttp3_internal_http2_ErrorCode_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Http2.IPushObserver __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.IPushObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Http2.ErrorCode p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnReset (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onReset_ILokhttp3_internal_http2_ErrorCode_;
		public unsafe void OnReset (int p0, global::Okhttp3.Internal.Http2.ErrorCode p1)
		{
			if (id_onReset_ILokhttp3_internal_http2_ErrorCode_ == IntPtr.Zero)
				id_onReset_ILokhttp3_internal_http2_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "onReset", "(ILokhttp3/internal/http2/ErrorCode;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReset_ILokhttp3_internal_http2_ErrorCode_, __args);
		}

	}

}
