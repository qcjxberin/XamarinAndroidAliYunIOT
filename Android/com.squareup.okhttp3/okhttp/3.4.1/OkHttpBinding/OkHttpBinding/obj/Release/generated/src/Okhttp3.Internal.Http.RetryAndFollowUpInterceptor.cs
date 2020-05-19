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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']/constructor[@name='RetryAndFollowUpInterceptor' and count(parameter)=1 and parameter[1][@type='okhttp3.OkHttpClient']]"
		[Register (".ctor", "(Lokhttp3/OkHttpClient;)V", "")]
		public unsafe RetryAndFollowUpInterceptor (global::Okhttp3.OkHttpClient client)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/OkHttpClient;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool ForWebSocket {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']/method[@name='isForWebSocket' and count(parameter)=0]"
			[Register ("isForWebSocket", "()Z", "")]
			get {
				const string __id = "isForWebSocket.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']/method[@name='setForWebSocket' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setForWebSocket", "(Z)V", "")]
			set {
				const string __id = "setForWebSocket.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']/method[@name='client' and count(parameter)=0]"
		[Register ("client", "()Lokhttp3/OkHttpClient;", "")]
		public unsafe global::Okhttp3.OkHttpClient Client ()
		{
			const string __id = "client.()Lokhttp3/OkHttpClient;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
