using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Huc {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection']"
	[global::Android.Runtime.Register ("okhttp3/internal/huc/OkHttpURLConnection", DoNotGenerateAcw=true)]
	public sealed partial class OkHttpURLConnection : global::Java.Net.HttpURLConnection, global::Okhttp3.ICallback {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection']/field[@name='RESPONSE_SOURCE']"
		[Register ("RESPONSE_SOURCE")]
		public static string ResponseSource {
			get {
				const string __id = "RESPONSE_SOURCE.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection']/field[@name='SELECTED_PROTOCOL']"
		[Register ("SELECTED_PROTOCOL")]
		public static string SelectedProtocol {
			get {
				const string __id = "SELECTED_PROTOCOL.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection.NetworkInterceptor']"
		[global::Android.Runtime.Register ("okhttp3/internal/huc/OkHttpURLConnection$NetworkInterceptor", DoNotGenerateAcw=true)]
		public sealed partial class NetworkInterceptor : global::Java.Lang.Object, global::Okhttp3.IInterceptor {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/huc/OkHttpURLConnection$NetworkInterceptor", typeof (NetworkInterceptor));
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

			internal NetworkInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection.NetworkInterceptor']/method[@name='intercept' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor.Chain']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection.NetworkInterceptor']/method[@name='proceed' and count(parameter)=0]"
			[Register ("proceed", "()V", "")]
			public unsafe void Proceed ()
			{
				const string __id = "proceed.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection.UnexpectedException']"
		[global::Android.Runtime.Register ("okhttp3/internal/huc/OkHttpURLConnection$UnexpectedException", DoNotGenerateAcw=true)]
		public sealed partial class UnexpectedException : global::Java.IO.IOException {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/huc/OkHttpURLConnection$UnexpectedException", typeof (UnexpectedException));
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

			internal UnexpectedException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/huc/OkHttpURLConnection", typeof (OkHttpURLConnection));
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

		internal OkHttpURLConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection']/constructor[@name='OkHttpURLConnection' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='okhttp3.OkHttpClient']]"
		[Register (".ctor", "(Ljava/net/URL;Lokhttp3/OkHttpClient;)V", "")]
		public unsafe OkHttpURLConnection (global::Java.Net.URL url, global::Okhttp3.OkHttpClient client)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URL;Lokhttp3/OkHttpClient;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection']/constructor[@name='OkHttpURLConnection' and count(parameter)=3 and parameter[1][@type='java.net.URL'] and parameter[2][@type='okhttp3.OkHttpClient'] and parameter[3][@type='okhttp3.internal.URLFilter']]"
		[Register (".ctor", "(Ljava/net/URL;Lokhttp3/OkHttpClient;Lokhttp3/internal/URLFilter;)V", "")]
		public unsafe OkHttpURLConnection (global::Java.Net.URL url, global::Okhttp3.OkHttpClient client, global::Okhttp3.Internal.IURLFilter urlFilter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URL;Lokhttp3/OkHttpClient;Lokhttp3/internal/URLFilter;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [2] = new JniArgumentValue ((urlFilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) urlFilter).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "")]
		public override unsafe void Connect ()
		{
			const string __id = "connect.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "")]
		public override unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='java.io.IOException']]"
		[Register ("onFailure", "(Lokhttp3/Call;Ljava/io/IOException;)V", "")]
		public unsafe void OnFailure (global::Okhttp3.ICall call, global::Java.IO.IOException e)
		{
			const string __id = "onFailure.(Lokhttp3/Call;Ljava/io/IOException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection']/method[@name='onResponse' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='okhttp3.Response']]"
		[Register ("onResponse", "(Lokhttp3/Call;Lokhttp3/Response;)V", "")]
		public unsafe void OnResponse (global::Okhttp3.ICall call, global::Okhttp3.Response response)
		{
			const string __id = "onResponse.(Lokhttp3/Call;Lokhttp3/Response;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpURLConnection']/method[@name='usingProxy' and count(parameter)=0]"
		[Register ("usingProxy", "()Z", "")]
		public override unsafe bool UsingProxy ()
		{
			const string __id = "usingProxy.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
