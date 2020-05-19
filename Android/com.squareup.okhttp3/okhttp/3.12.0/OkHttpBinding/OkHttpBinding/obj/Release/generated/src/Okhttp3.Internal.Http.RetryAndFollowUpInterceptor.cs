using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/RetryAndFollowUpInterceptor", DoNotGenerateAcw=true)]
	public sealed partial class RetryAndFollowUpInterceptor : global::Java.Lang.Object, global::Okhttp3.IInterceptor {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/RetryAndFollowUpInterceptor", typeof (RetryAndFollowUpInterceptor));
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

		internal RetryAndFollowUpInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']/constructor[@name='RetryAndFollowUpInterceptor' and count(parameter)=2 and parameter[1][@type='okhttp3.OkHttpClient'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lokhttp3/OkHttpClient;Z)V", "")]
		public unsafe RetryAndFollowUpInterceptor (global::Okhttp3.OkHttpClient client, bool forWebSocket)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/OkHttpClient;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue (forWebSocket);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "")]
			get {
				const string __id = "isCanceled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']/method[@name='intercept' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor.Chain']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']/method[@name='setCallStackTrace' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setCallStackTrace", "(Ljava/lang/Object;)V", "")]
		public unsafe void SetCallStackTrace (global::Java.Lang.Object callStackTrace)
		{
			const string __id = "setCallStackTrace.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((callStackTrace == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callStackTrace).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']/method[@name='streamAllocation' and count(parameter)=0]"
		[Register ("streamAllocation", "()Lokhttp3/internal/connection/StreamAllocation;", "")]
		public unsafe global::Okhttp3.Internal.Connection.StreamAllocation StreamAllocation ()
		{
			const string __id = "streamAllocation.()Lokhttp3/internal/connection/StreamAllocation;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.StreamAllocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
