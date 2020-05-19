using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	[Register ("okhttp3/internal/http/HttpCodec", DoNotGenerateAcw=true)]
	public abstract class HttpCodec : Java.Lang.Object {

		internal HttpCodec ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='HttpCodec']/field[@name='DISCARD_STREAM_TIMEOUT_MILLIS']"
		[Register ("DISCARD_STREAM_TIMEOUT_MILLIS")]
		public const int DiscardStreamTimeoutMillis = (int) 100;
	}

	[Register ("okhttp3/internal/http/HttpCodec", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'HttpCodec' type. This type will be removed in a future release.", error: true)]
	public abstract class HttpCodecConsts : HttpCodec {

		private HttpCodecConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='HttpCodec']"
	[Register ("okhttp3/internal/http/HttpCodec", "", "Okhttp3.Internal.Http.IHttpCodecInvoker")]
	public partial interface IHttpCodec : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='HttpCodec']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Okhttp3.Internal.Http.IHttpCodecInvoker, OkHttpBinding")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='HttpCodec']/method[@name='createRequestBody' and count(parameter)=2 and parameter[1][@type='okhttp3.Request'] and parameter[2][@type='long']]"
		[Register ("createRequestBody", "(Lokhttp3/Request;J)Lokio/Sink;", "GetCreateRequestBody_Lokhttp3_Request_JHandler:Okhttp3.Internal.Http.IHttpCodecInvoker, OkHttpBinding")]
		global::Okio.ISink CreateRequestBody (global::Okhttp3.Request p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='HttpCodec']/method[@name='finishRequest' and count(parameter)=0]"
		[Register ("finishRequest", "()V", "GetFinishRequestHandler:Okhttp3.Internal.Http.IHttpCodecInvoker, OkHttpBinding")]
		void FinishRequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='HttpCodec']/method[@name='flushRequest' and count(parameter)=0]"
		[Register ("flushRequest", "()V", "GetFlushRequestHandler:Okhttp3.Internal.Http.IHttpCodecInvoker, OkHttpBinding")]
		void FlushRequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='HttpCodec']/method[@name='openResponseBody' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("openResponseBody", "(Lokhttp3/Response;)Lokhttp3/ResponseBody;", "GetOpenResponseBody_Lokhttp3_Response_Handler:Okhttp3.Internal.Http.IHttpCodecInvoker, OkHttpBinding")]
		global::Okhttp3.ResponseBody OpenResponseBody (global::Okhttp3.Response p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='HttpCodec']/method[@name='readResponseHeaders' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("readResponseHeaders", "(Z)Lokhttp3/Response$Builder;", "GetReadResponseHeaders_ZHandler:Okhttp3.Internal.Http.IHttpCodecInvoker, OkHttpBinding")]
		global::Okhttp3.Response.Builder ReadResponseHeaders (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='HttpCodec']/method[@name='writeRequestHeaders' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("writeRequestHeaders", "(Lokhttp3/Request;)V", "GetWriteRequestHeaders_Lokhttp3_Request_Handler:Okhttp3.Internal.Http.IHttpCodecInvoker, OkHttpBinding")]
		void WriteRequestHeaders (global::Okhttp3.Request p0);

	}

	[global::Android.Runtime.Register ("okhttp3/internal/http/HttpCodec", DoNotGenerateAcw=true)]
	internal partial class IHttpCodecInvoker : global::Java.Lang.Object, IHttpCodec {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/HttpCodec", typeof (IHttpCodecInvoker));

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

		public static IHttpCodec GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpCodec> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.http.HttpCodec"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpCodecInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.Internal.Http.IHttpCodec __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IHttpCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

		static Delegate cb_createRequestBody_Lokhttp3_Request_J;
#pragma warning disable 0169
		static Delegate GetCreateRequestBody_Lokhttp3_Request_JHandler ()
		{
			if (cb_createRequestBody_Lokhttp3_Request_J == null)
				cb_createRequestBody_Lokhttp3_Request_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_CreateRequestBody_Lokhttp3_Request_J);
			return cb_createRequestBody_Lokhttp3_Request_J;
		}

		static IntPtr n_CreateRequestBody_Lokhttp3_Request_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Okhttp3.Internal.Http.IHttpCodec __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IHttpCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Request p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateRequestBody (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createRequestBody_Lokhttp3_Request_J;
		public unsafe global::Okio.ISink CreateRequestBody (global::Okhttp3.Request p0, long p1)
		{
			if (id_createRequestBody_Lokhttp3_Request_J == IntPtr.Zero)
				id_createRequestBody_Lokhttp3_Request_J = JNIEnv.GetMethodID (class_ref, "createRequestBody", "(Lokhttp3/Request;J)Lokio/Sink;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			global::Okio.ISink __ret = global::Java.Lang.Object.GetObject<global::Okio.ISink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createRequestBody_Lokhttp3_Request_J, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_finishRequest;
#pragma warning disable 0169
		static Delegate GetFinishRequestHandler ()
		{
			if (cb_finishRequest == null)
				cb_finishRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinishRequest);
			return cb_finishRequest;
		}

		static void n_FinishRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.Internal.Http.IHttpCodec __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IHttpCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishRequest ();
		}
#pragma warning restore 0169

		IntPtr id_finishRequest;
		public unsafe void FinishRequest ()
		{
			if (id_finishRequest == IntPtr.Zero)
				id_finishRequest = JNIEnv.GetMethodID (class_ref, "finishRequest", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finishRequest);
		}

		static Delegate cb_flushRequest;
#pragma warning disable 0169
		static Delegate GetFlushRequestHandler ()
		{
			if (cb_flushRequest == null)
				cb_flushRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FlushRequest);
			return cb_flushRequest;
		}

		static void n_FlushRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.Internal.Http.IHttpCodec __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IHttpCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FlushRequest ();
		}
#pragma warning restore 0169

		IntPtr id_flushRequest;
		public unsafe void FlushRequest ()
		{
			if (id_flushRequest == IntPtr.Zero)
				id_flushRequest = JNIEnv.GetMethodID (class_ref, "flushRequest", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flushRequest);
		}

		static Delegate cb_openResponseBody_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetOpenResponseBody_Lokhttp3_Response_Handler ()
		{
			if (cb_openResponseBody_Lokhttp3_Response_ == null)
				cb_openResponseBody_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenResponseBody_Lokhttp3_Response_);
			return cb_openResponseBody_Lokhttp3_Response_;
		}

		static IntPtr n_OpenResponseBody_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.Http.IHttpCodec __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IHttpCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Response p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenResponseBody (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_openResponseBody_Lokhttp3_Response_;
		public unsafe global::Okhttp3.ResponseBody OpenResponseBody (global::Okhttp3.Response p0)
		{
			if (id_openResponseBody_Lokhttp3_Response_ == IntPtr.Zero)
				id_openResponseBody_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "openResponseBody", "(Lokhttp3/Response;)Lokhttp3/ResponseBody;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Okhttp3.ResponseBody __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openResponseBody_Lokhttp3_Response_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_readResponseHeaders_Z;
#pragma warning disable 0169
		static Delegate GetReadResponseHeaders_ZHandler ()
		{
			if (cb_readResponseHeaders_Z == null)
				cb_readResponseHeaders_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ReadResponseHeaders_Z);
			return cb_readResponseHeaders_Z;
		}

		static IntPtr n_ReadResponseHeaders_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Okhttp3.Internal.Http.IHttpCodec __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IHttpCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadResponseHeaders (p0));
		}
#pragma warning restore 0169

		IntPtr id_readResponseHeaders_Z;
		public unsafe global::Okhttp3.Response.Builder ReadResponseHeaders (bool p0)
		{
			if (id_readResponseHeaders_Z == IntPtr.Zero)
				id_readResponseHeaders_Z = JNIEnv.GetMethodID (class_ref, "readResponseHeaders", "(Z)Lokhttp3/Response$Builder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readResponseHeaders_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeRequestHeaders_Lokhttp3_Request_;
#pragma warning disable 0169
		static Delegate GetWriteRequestHeaders_Lokhttp3_Request_Handler ()
		{
			if (cb_writeRequestHeaders_Lokhttp3_Request_ == null)
				cb_writeRequestHeaders_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteRequestHeaders_Lokhttp3_Request_);
			return cb_writeRequestHeaders_Lokhttp3_Request_;
		}

		static void n_WriteRequestHeaders_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.Http.IHttpCodec __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IHttpCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Request p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteRequestHeaders (p0);
		}
#pragma warning restore 0169

		IntPtr id_writeRequestHeaders_Lokhttp3_Request_;
		public unsafe void WriteRequestHeaders (global::Okhttp3.Request p0)
		{
			if (id_writeRequestHeaders_Lokhttp3_Request_ == IntPtr.Zero)
				id_writeRequestHeaders_Lokhttp3_Request_ = JNIEnv.GetMethodID (class_ref, "writeRequestHeaders", "(Lokhttp3/Request;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeRequestHeaders_Lokhttp3_Request_, __args);
		}

	}

}
