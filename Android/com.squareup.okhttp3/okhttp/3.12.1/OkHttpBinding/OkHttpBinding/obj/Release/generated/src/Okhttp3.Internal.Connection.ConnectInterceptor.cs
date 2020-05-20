using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='ConnectInterceptor']"
	[global::Android.Runtime.Register ("okhttp3/internal/connection/ConnectInterceptor", DoNotGenerateAcw=true)]
	public sealed partial class ConnectInterceptor : global::Java.Lang.Object, global::Okhttp3.IInterceptor {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='ConnectInterceptor']/field[@name='client']"
		[Register ("client")]
		public global::Okhttp3.OkHttpClient Client {
			get {
				const string __id = "client.Lokhttp3/OkHttpClient;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "client.Lokhttp3/OkHttpClient;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/connection/ConnectInterceptor", typeof (ConnectInterceptor));
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

		internal ConnectInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='ConnectInterceptor']/constructor[@name='ConnectInterceptor' and count(parameter)=1 and parameter[1][@type='okhttp3.OkHttpClient']]"
		[Register (".ctor", "(Lokhttp3/OkHttpClient;)V", "")]
		public unsafe ConnectInterceptor (global::Okhttp3.OkHttpClient client)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='ConnectInterceptor']/method[@name='intercept' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor.Chain']]"
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
