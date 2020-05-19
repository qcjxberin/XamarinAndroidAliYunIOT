using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='OkUrlFactory']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("okhttp3/OkUrlFactory", DoNotGenerateAcw=true)]
	public sealed partial class OkUrlFactory : global::Java.Lang.Object, global::Java.Lang.ICloneable, global::Java.Net.IURLStreamHandlerFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/OkUrlFactory", typeof (OkUrlFactory));
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

		internal OkUrlFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='OkUrlFactory']/constructor[@name='OkUrlFactory' and count(parameter)=1 and parameter[1][@type='okhttp3.OkHttpClient']]"
		[Register (".ctor", "(Lokhttp3/OkHttpClient;)V", "")]
		public unsafe OkUrlFactory (global::Okhttp3.OkHttpClient client)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkUrlFactory']/method[@name='client' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkUrlFactory']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lokhttp3/OkUrlFactory;", "")]
		public unsafe global::Okhttp3.OkUrlFactory Clone ()
		{
			const string __id = "clone.()Lokhttp3/OkUrlFactory;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.OkUrlFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkUrlFactory']/method[@name='createURLStreamHandler' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createURLStreamHandler", "(Ljava/lang/String;)Ljava/net/URLStreamHandler;", "")]
		public unsafe global::Java.Net.URLStreamHandler CreateURLStreamHandler (string protocol)
		{
			const string __id = "createURLStreamHandler.(Ljava/lang/String;)Ljava/net/URLStreamHandler;";
			IntPtr native_protocol = JNIEnv.NewString (protocol);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_protocol);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.URLStreamHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_protocol);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkUrlFactory']/method[@name='open' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("open", "(Ljava/net/URL;)Ljava/net/HttpURLConnection;", "")]
		public unsafe global::Java.Net.HttpURLConnection Open (global::Java.Net.URL url)
		{
			const string __id = "open.(Ljava/net/URL;)Ljava/net/HttpURLConnection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkUrlFactory']/method[@name='setClient' and count(parameter)=1 and parameter[1][@type='okhttp3.OkHttpClient']]"
		[Register ("setClient", "(Lokhttp3/OkHttpClient;)Lokhttp3/OkUrlFactory;", "")]
		public unsafe global::Okhttp3.OkUrlFactory SetClient (global::Okhttp3.OkHttpClient client)
		{
			const string __id = "setClient.(Lokhttp3/OkHttpClient;)Lokhttp3/OkUrlFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.OkUrlFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
