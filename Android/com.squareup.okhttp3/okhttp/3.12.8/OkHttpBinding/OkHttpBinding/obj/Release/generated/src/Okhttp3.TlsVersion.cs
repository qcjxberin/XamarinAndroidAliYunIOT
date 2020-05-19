using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']"
	[global::Android.Runtime.Register ("okhttp3/TlsVersion", DoNotGenerateAcw=true)]
	public sealed partial class TlsVersion : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/field[@name='SSL_3_0']"
		[Register ("SSL_3_0")]
		public static global::Okhttp3.TlsVersion Ssl30 {
			get {
				const string __id = "SSL_3_0.Lokhttp3/TlsVersion;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/field[@name='TLS_1_0']"
		[Register ("TLS_1_0")]
		public static global::Okhttp3.TlsVersion Tls10 {
			get {
				const string __id = "TLS_1_0.Lokhttp3/TlsVersion;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/field[@name='TLS_1_1']"
		[Register ("TLS_1_1")]
		public static global::Okhttp3.TlsVersion Tls11 {
			get {
				const string __id = "TLS_1_1.Lokhttp3/TlsVersion;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/field[@name='TLS_1_2']"
		[Register ("TLS_1_2")]
		public static global::Okhttp3.TlsVersion Tls12 {
			get {
				const string __id = "TLS_1_2.Lokhttp3/TlsVersion;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/field[@name='TLS_1_3']"
		[Register ("TLS_1_3")]
		public static global::Okhttp3.TlsVersion Tls13 {
			get {
				const string __id = "TLS_1_3.Lokhttp3/TlsVersion;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/TlsVersion", typeof (TlsVersion));
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

		internal TlsVersion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/method[@name='forJavaName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("forJavaName", "(Ljava/lang/String;)Lokhttp3/TlsVersion;", "")]
		public static unsafe global::Okhttp3.TlsVersion ForJavaName (string javaName)
		{
			const string __id = "forJavaName.(Ljava/lang/String;)Lokhttp3/TlsVersion;";
			IntPtr native_javaName = JNIEnv.NewString (javaName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_javaName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_javaName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/method[@name='javaName' and count(parameter)=0]"
		[Register ("javaName", "()Ljava/lang/String;", "")]
		public unsafe string JavaName ()
		{
			const string __id = "javaName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lokhttp3/TlsVersion;", "")]
		public static unsafe global::Okhttp3.TlsVersion ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lokhttp3/TlsVersion;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lokhttp3/TlsVersion;", "")]
		public static unsafe global::Okhttp3.TlsVersion[] Values ()
		{
			const string __id = "values.()[Lokhttp3/TlsVersion;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Okhttp3.TlsVersion[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Okhttp3.TlsVersion));
			} finally {
			}
		}

	}
}
