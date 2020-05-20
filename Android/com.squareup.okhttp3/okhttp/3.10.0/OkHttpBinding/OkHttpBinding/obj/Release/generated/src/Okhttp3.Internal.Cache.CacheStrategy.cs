using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy']"
	[global::Android.Runtime.Register ("okhttp3/internal/cache/CacheStrategy", DoNotGenerateAcw=true)]
	public sealed partial class CacheStrategy : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy']/field[@name='cacheResponse']"
		[Register ("cacheResponse")]
		public global::Okhttp3.Response CacheResponse {
			get {
				const string __id = "cacheResponse.Lokhttp3/Response;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cacheResponse.Lokhttp3/Response;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy']/field[@name='networkRequest']"
		[Register ("networkRequest")]
		public global::Okhttp3.Request NetworkRequest {
			get {
				const string __id = "networkRequest.Lokhttp3/Request;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "networkRequest.Lokhttp3/Request;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy.Factory']"
		[global::Android.Runtime.Register ("okhttp3/internal/cache/CacheStrategy$Factory", DoNotGenerateAcw=true)]
		public partial class Factory : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/cache/CacheStrategy$Factory", typeof (Factory));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Factory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy.Factory']/constructor[@name='CacheStrategy.Factory' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='okhttp3.Request'] and parameter[3][@type='okhttp3.Response']]"
			[Register (".ctor", "(JLokhttp3/Request;Lokhttp3/Response;)V", "")]
			public unsafe Factory (long nowMillis, global::Okhttp3.Request request, global::Okhttp3.Response cacheResponse)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(JLokhttp3/Request;Lokhttp3/Response;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (nowMillis);
					__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
					__args [2] = new JniArgumentValue ((cacheResponse == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheResponse).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_get;
#pragma warning disable 0169
			static Delegate GetGetHandler ()
			{
				if (cb_get == null)
					cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
				return cb_get;
			}

			static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Internal.Cache.CacheStrategy.Factory __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Cache.CacheStrategy.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Get ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy.Factory']/method[@name='get' and count(parameter)=0]"
			[Register ("get", "()Lokhttp3/internal/cache/CacheStrategy;", "GetGetHandler")]
			public virtual unsafe global::Okhttp3.Internal.Cache.CacheStrategy Get ()
			{
				const string __id = "get.()Lokhttp3/internal/cache/CacheStrategy;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Cache.CacheStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/cache/CacheStrategy", typeof (CacheStrategy));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal CacheStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy']/method[@name='isCacheable' and count(parameter)=2 and parameter[1][@type='okhttp3.Response'] and parameter[2][@type='okhttp3.Request']]"
		[Register ("isCacheable", "(Lokhttp3/Response;Lokhttp3/Request;)Z", "")]
		public static unsafe bool IsCacheable (global::Okhttp3.Response response, global::Okhttp3.Request request)
		{
			const string __id = "isCacheable.(Lokhttp3/Response;Lokhttp3/Request;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
