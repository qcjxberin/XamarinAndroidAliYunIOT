using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner']"
	[global::Android.Runtime.Register ("okhttp3/CertificatePinner", DoNotGenerateAcw=true)]
	public sealed partial class CertificatePinner : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Okhttp3.CertificatePinner Default {
			get {
				const string __id = "DEFAULT.Lokhttp3/CertificatePinner;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CertificatePinner> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner.Builder']"
		[global::Android.Runtime.Register ("okhttp3/CertificatePinner$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/CertificatePinner$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner.Builder']/constructor[@name='CertificatePinner.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner.Builder']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
			[Register ("add", "(Ljava/lang/String;[Ljava/lang/String;)Lokhttp3/CertificatePinner$Builder;", "")]
			public unsafe global::Okhttp3.CertificatePinner.Builder Add (string pattern, params string[] pins)
			{
				const string __id = "add.(Ljava/lang/String;[Ljava/lang/String;)Lokhttp3/CertificatePinner$Builder;";
				IntPtr native_pattern = JNIEnv.NewString (pattern);
				IntPtr native_pins = JNIEnv.NewArray (pins);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_pattern);
					__args [1] = new JniArgumentValue (native_pins);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CertificatePinner.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_pattern);
					if (pins != null) {
						JNIEnv.CopyArray (native_pins, pins);
						JNIEnv.DeleteLocalRef (native_pins);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/CertificatePinner;", "")]
			public unsafe global::Okhttp3.CertificatePinner Build ()
			{
				const string __id = "build.()Lokhttp3/CertificatePinner;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CertificatePinner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner.Pin']"
		[global::Android.Runtime.Register ("okhttp3/CertificatePinner$Pin", DoNotGenerateAcw=true)]
		public sealed partial class Pin : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/CertificatePinner$Pin", typeof (Pin));
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

			internal Pin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/CertificatePinner", typeof (CertificatePinner));
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

		internal CertificatePinner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner']/method[@name='check' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.security.cert.Certificate...']]"
		[Obsolete (@"deprecated")]
		[Register ("check", "(Ljava/lang/String;[Ljava/security/cert/Certificate;)V", "")]
		public unsafe void Check (string hostname, params global::Java.Security.Cert.Certificate[] peerCertificates)
		{
			const string __id = "check.(Ljava/lang/String;[Ljava/security/cert/Certificate;)V";
			IntPtr native_hostname = JNIEnv.NewString (hostname);
			IntPtr native_peerCertificates = JNIEnv.NewArray (peerCertificates);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_hostname);
				__args [1] = new JniArgumentValue (native_peerCertificates);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_hostname);
				if (peerCertificates != null) {
					JNIEnv.CopyArray (native_peerCertificates, peerCertificates);
					JNIEnv.DeleteLocalRef (native_peerCertificates);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner']/method[@name='check' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.security.cert.Certificate&gt;']]"
		[Register ("check", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe void Check (string hostname, global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> peerCertificates)
		{
			const string __id = "check.(Ljava/lang/String;Ljava/util/List;)V";
			IntPtr native_hostname = JNIEnv.NewString (hostname);
			IntPtr native_peerCertificates = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (peerCertificates);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_hostname);
				__args [1] = new JniArgumentValue (native_peerCertificates);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_hostname);
				JNIEnv.DeleteLocalRef (native_peerCertificates);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner']/method[@name='pin' and count(parameter)=1 and parameter[1][@type='java.security.cert.Certificate']]"
		[Register ("pin", "(Ljava/security/cert/Certificate;)Ljava/lang/String;", "")]
		public static unsafe string InvokePin (global::Java.Security.Cert.Certificate certificate)
		{
			const string __id = "pin.(Ljava/security/cert/Certificate;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((certificate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) certificate).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
