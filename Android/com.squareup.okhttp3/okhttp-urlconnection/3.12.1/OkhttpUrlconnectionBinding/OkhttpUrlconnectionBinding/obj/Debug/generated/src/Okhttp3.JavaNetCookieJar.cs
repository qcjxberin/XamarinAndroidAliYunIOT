using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='JavaNetCookieJar']"
	[global::Android.Runtime.Register ("okhttp3/JavaNetCookieJar", DoNotGenerateAcw=true)]
	public sealed partial class JavaNetCookieJar : global::Java.Lang.Object, global::Okhttp3.ICookieJar {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/JavaNetCookieJar", typeof (JavaNetCookieJar));
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

		internal JavaNetCookieJar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='JavaNetCookieJar']/constructor[@name='JavaNetCookieJar' and count(parameter)=1 and parameter[1][@type='java.net.CookieHandler']]"
		[Register (".ctor", "(Ljava/net/CookieHandler;)V", "")]
		public unsafe JavaNetCookieJar (global::Java.Net.CookieHandler cookieHandler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/CookieHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cookieHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cookieHandler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='JavaNetCookieJar']/method[@name='loadForRequest' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
		[Register ("loadForRequest", "(Lokhttp3/HttpUrl;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.Cookie> LoadForRequest (global::Okhttp3.HttpUrl url)
		{
			const string __id = "loadForRequest.(Lokhttp3/HttpUrl;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Okhttp3.Cookie>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='JavaNetCookieJar']/method[@name='saveFromResponse' and count(parameter)=2 and parameter[1][@type='okhttp3.HttpUrl'] and parameter[2][@type='java.util.List&lt;okhttp3.Cookie&gt;']]"
		[Register ("saveFromResponse", "(Lokhttp3/HttpUrl;Ljava/util/List;)V", "")]
		public unsafe void SaveFromResponse (global::Okhttp3.HttpUrl url, global::System.Collections.Generic.IList<global::Okhttp3.Cookie> cookies)
		{
			const string __id = "saveFromResponse.(Lokhttp3/HttpUrl;Ljava/util/List;)V";
			IntPtr native_cookies = global::Android.Runtime.JavaList<global::Okhttp3.Cookie>.ToLocalJniHandle (cookies);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue (native_cookies);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cookies);
			}
		}

	}
}
