using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheInterceptor']"
	[global::Android.Runtime.Register ("okhttp3/internal/cache/CacheInterceptor", DoNotGenerateAcw=true)]
	public sealed partial class CacheInterceptor : global::Java.Lang.Object, global::Okhttp3.IInterceptor {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/cache/CacheInterceptor", typeof (CacheInterceptor));
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

		internal CacheInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheInterceptor']/constructor[@name='CacheInterceptor' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.cache.InternalCache']]"
		[Register (".ctor", "(Lokhttp3/internal/cache/InternalCache;)V", "")]
		public unsafe CacheInterceptor (global::Okhttp3.Internal.Cache.IInternalCache cache)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/internal/cache/InternalCache;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cache).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheInterceptor']/method[@name='intercept' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor.Chain']]"
		[Register ("intercept", "(Lokhttp3/Interceptor$Chain;)Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response Intercept (global::Okhttp3.IInterceptorChain chain)
		{
			const string __id = "intercept.(Lokhttp3/Interceptor$Chain;)Lokhttp3/Response;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((chain == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chain).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
