using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='CallServerInterceptor']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/CallServerInterceptor", DoNotGenerateAcw=true)]
	public sealed partial class CallServerInterceptor : global::Java.Lang.Object, global::Okhttp3.IInterceptor {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='CallServerInterceptor.CountingSink']"
		[global::Android.Runtime.Register ("okhttp3/internal/http/CallServerInterceptor$CountingSink", DoNotGenerateAcw=true)]
		public sealed partial class CountingSink : global::Okio.ForwardingSink {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/CallServerInterceptor$CountingSink", typeof (CountingSink));
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

			internal CountingSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/CallServerInterceptor", typeof (CallServerInterceptor));
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

		internal CallServerInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='CallServerInterceptor']/constructor[@name='CallServerInterceptor' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe CallServerInterceptor (bool forWebSocket)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (forWebSocket);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='CallServerInterceptor']/method[@name='intercept' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor.Chain']]"
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
