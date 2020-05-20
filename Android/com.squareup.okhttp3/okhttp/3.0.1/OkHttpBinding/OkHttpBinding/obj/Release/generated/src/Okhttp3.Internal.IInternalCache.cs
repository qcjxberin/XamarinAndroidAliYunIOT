using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal']/interface[@name='InternalCache']"
	[Register ("okhttp3/internal/InternalCache", "", "Okhttp3.Internal.IInternalCacheInvoker")]
	public partial interface IInternalCache : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/interface[@name='InternalCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("get", "(Lokhttp3/Request;)Lokhttp3/Response;", "GetGet_Lokhttp3_Request_Handler:Okhttp3.Internal.IInternalCacheInvoker, OkHttpBinding")]
		global::Okhttp3.Response Get (global::Okhttp3.Request p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/interface[@name='InternalCache']/method[@name='put' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("put", "(Lokhttp3/Response;)Lokhttp3/internal/http/CacheRequest;", "GetPut_Lokhttp3_Response_Handler:Okhttp3.Internal.IInternalCacheInvoker, OkHttpBinding")]
		global::Okhttp3.Internal.Http.ICacheRequest Put (global::Okhttp3.Response p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/interface[@name='InternalCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("remove", "(Lokhttp3/Request;)V", "GetRemove_Lokhttp3_Request_Handler:Okhttp3.Internal.IInternalCacheInvoker, OkHttpBinding")]
		void Remove (global::Okhttp3.Request p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/interface[@name='InternalCache']/method[@name='trackConditionalCacheHit' and count(parameter)=0]"
		[Register ("trackConditionalCacheHit", "()V", "GetTrackConditionalCacheHitHandler:Okhttp3.Internal.IInternalCacheInvoker, OkHttpBinding")]
		void TrackConditionalCacheHit ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/interface[@name='InternalCache']/method[@name='trackResponse' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http.CacheStrategy']]"
		[Register ("trackResponse", "(Lokhttp3/internal/http/CacheStrategy;)V", "GetTrackResponse_Lokhttp3_internal_http_CacheStrategy_Handler:Okhttp3.Internal.IInternalCacheInvoker, OkHttpBinding")]
		void TrackResponse (global::Okhttp3.Internal.Http.CacheStrategy p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/interface[@name='InternalCache']/method[@name='update' and count(parameter)=2 and parameter[1][@type='okhttp3.Response'] and parameter[2][@type='okhttp3.Response']]"
		[Register ("update", "(Lokhttp3/Response;Lokhttp3/Response;)V", "GetUpdate_Lokhttp3_Response_Lokhttp3_Response_Handler:Okhttp3.Internal.IInternalCacheInvoker, OkHttpBinding")]
		void Update (global::Okhttp3.Response p0, global::Okhttp3.Response p1);

	}

	[global::Android.Runtime.Register ("okhttp3/internal/InternalCache", DoNotGenerateAcw=true)]
	internal partial class IInternalCacheInvoker : global::Java.Lang.Object, IInternalCache {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/InternalCache", typeof (IInternalCacheInvoker));

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

		public static IInternalCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInternalCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.InternalCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInternalCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_get_Lokhttp3_Request_;
#pragma warning disable 0169
		static Delegate GetGet_Lokhttp3_Request_Handler ()
		{
			if (cb_get_Lokhttp3_Request_ == null)
				cb_get_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Lokhttp3_Request_);
			return cb_get_Lokhttp3_Request_;
		}

		static IntPtr n_Get_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.IInternalCache __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IInternalCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Request p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Lokhttp3_Request_;
		public unsafe global::Okhttp3.Response Get (global::Okhttp3.Request p0)
		{
			if (id_get_Lokhttp3_Request_ == IntPtr.Zero)
				id_get_Lokhttp3_Request_ = JNIEnv.GetMethodID (class_ref, "get", "(Lokhttp3/Request;)Lokhttp3/Response;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Okhttp3.Response __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Lokhttp3_Request_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_put_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetPut_Lokhttp3_Response_Handler ()
		{
			if (cb_put_Lokhttp3_Response_ == null)
				cb_put_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Lokhttp3_Response_);
			return cb_put_Lokhttp3_Response_;
		}

		static IntPtr n_Put_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.IInternalCache __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IInternalCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Response p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_put_Lokhttp3_Response_;
		public unsafe global::Okhttp3.Internal.Http.ICacheRequest Put (global::Okhttp3.Response p0)
		{
			if (id_put_Lokhttp3_Response_ == IntPtr.Zero)
				id_put_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "put", "(Lokhttp3/Response;)Lokhttp3/internal/http/CacheRequest;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Okhttp3.Internal.Http.ICacheRequest __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.ICacheRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_put_Lokhttp3_Response_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_remove_Lokhttp3_Request_;
#pragma warning disable 0169
		static Delegate GetRemove_Lokhttp3_Request_Handler ()
		{
			if (cb_remove_Lokhttp3_Request_ == null)
				cb_remove_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Lokhttp3_Request_);
			return cb_remove_Lokhttp3_Request_;
		}

		static void n_Remove_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.IInternalCache __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IInternalCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Request p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		IntPtr id_remove_Lokhttp3_Request_;
		public unsafe void Remove (global::Okhttp3.Request p0)
		{
			if (id_remove_Lokhttp3_Request_ == IntPtr.Zero)
				id_remove_Lokhttp3_Request_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lokhttp3/Request;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lokhttp3_Request_, __args);
		}

		static Delegate cb_trackConditionalCacheHit;
#pragma warning disable 0169
		static Delegate GetTrackConditionalCacheHitHandler ()
		{
			if (cb_trackConditionalCacheHit == null)
				cb_trackConditionalCacheHit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TrackConditionalCacheHit);
			return cb_trackConditionalCacheHit;
		}

		static void n_TrackConditionalCacheHit (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.Internal.IInternalCache __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IInternalCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrackConditionalCacheHit ();
		}
#pragma warning restore 0169

		IntPtr id_trackConditionalCacheHit;
		public unsafe void TrackConditionalCacheHit ()
		{
			if (id_trackConditionalCacheHit == IntPtr.Zero)
				id_trackConditionalCacheHit = JNIEnv.GetMethodID (class_ref, "trackConditionalCacheHit", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackConditionalCacheHit);
		}

		static Delegate cb_trackResponse_Lokhttp3_internal_http_CacheStrategy_;
#pragma warning disable 0169
		static Delegate GetTrackResponse_Lokhttp3_internal_http_CacheStrategy_Handler ()
		{
			if (cb_trackResponse_Lokhttp3_internal_http_CacheStrategy_ == null)
				cb_trackResponse_Lokhttp3_internal_http_CacheStrategy_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TrackResponse_Lokhttp3_internal_http_CacheStrategy_);
			return cb_trackResponse_Lokhttp3_internal_http_CacheStrategy_;
		}

		static void n_TrackResponse_Lokhttp3_internal_http_CacheStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.IInternalCache __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IInternalCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Http.CacheStrategy p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.CacheStrategy> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_trackResponse_Lokhttp3_internal_http_CacheStrategy_;
		public unsafe void TrackResponse (global::Okhttp3.Internal.Http.CacheStrategy p0)
		{
			if (id_trackResponse_Lokhttp3_internal_http_CacheStrategy_ == IntPtr.Zero)
				id_trackResponse_Lokhttp3_internal_http_CacheStrategy_ = JNIEnv.GetMethodID (class_ref, "trackResponse", "(Lokhttp3/internal/http/CacheStrategy;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackResponse_Lokhttp3_internal_http_CacheStrategy_, __args);
		}

		static Delegate cb_update_Lokhttp3_Response_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lokhttp3_Response_Lokhttp3_Response_Handler ()
		{
			if (cb_update_Lokhttp3_Response_Lokhttp3_Response_ == null)
				cb_update_Lokhttp3_Response_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Lokhttp3_Response_Lokhttp3_Response_);
			return cb_update_Lokhttp3_Response_Lokhttp3_Response_;
		}

		static void n_Update_Lokhttp3_Response_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.IInternalCache __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IInternalCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Response p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Response p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_update_Lokhttp3_Response_Lokhttp3_Response_;
		public unsafe void Update (global::Okhttp3.Response p0, global::Okhttp3.Response p1)
		{
			if (id_update_Lokhttp3_Response_Lokhttp3_Response_ == IntPtr.Zero)
				id_update_Lokhttp3_Response_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "update", "(Lokhttp3/Response;Lokhttp3/Response;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_Lokhttp3_Response_Lokhttp3_Response_, __args);
		}

	}

}
