using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']"
	[global::Android.Runtime.Register ("okhttp3/ConnectionSpec", DoNotGenerateAcw=true)]
	public sealed partial class ConnectionSpec : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/field[@name='CLEARTEXT']"
		[Register ("CLEARTEXT")]
		public static global::Okhttp3.ConnectionSpec Cleartext {
			get {
				const string __id = "CLEARTEXT.Lokhttp3/ConnectionSpec;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/field[@name='COMPATIBLE_TLS']"
		[Register ("COMPATIBLE_TLS")]
		public static global::Okhttp3.ConnectionSpec CompatibleTls {
			get {
				const string __id = "COMPATIBLE_TLS.Lokhttp3/ConnectionSpec;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/field[@name='MODERN_TLS']"
		[Register ("MODERN_TLS")]
		public static global::Okhttp3.ConnectionSpec ModernTls {
			get {
				const string __id = "MODERN_TLS.Lokhttp3/ConnectionSpec;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/field[@name='RESTRICTED_TLS']"
		[Register ("RESTRICTED_TLS")]
		public static global::Okhttp3.ConnectionSpec RestrictedTls {
			get {
				const string __id = "RESTRICTED_TLS.Lokhttp3/ConnectionSpec;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']"
		[global::Android.Runtime.Register ("okhttp3/ConnectionSpec$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/ConnectionSpec$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/constructor[@name='ConnectionSpec.Builder' and count(parameter)=1 and parameter[1][@type='okhttp3.ConnectionSpec']]"
			[Register (".ctor", "(Lokhttp3/ConnectionSpec;)V", "")]
			public unsafe Builder (global::Okhttp3.ConnectionSpec connectionSpec)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lokhttp3/ConnectionSpec;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((connectionSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionSpec).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='allEnabledCipherSuites' and count(parameter)=0]"
			[Register ("allEnabledCipherSuites", "()Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder AllEnabledCipherSuites ()
			{
				const string __id = "allEnabledCipherSuites.()Lokhttp3/ConnectionSpec$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='allEnabledTlsVersions' and count(parameter)=0]"
			[Register ("allEnabledTlsVersions", "()Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder AllEnabledTlsVersions ()
			{
				const string __id = "allEnabledTlsVersions.()Lokhttp3/ConnectionSpec$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/ConnectionSpec;", "")]
			public unsafe global::Okhttp3.ConnectionSpec Build ()
			{
				const string __id = "build.()Lokhttp3/ConnectionSpec;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='cipherSuites' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
			[Register ("cipherSuites", "([Ljava/lang/String;)Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder CipherSuites (params string[] cipherSuites)
			{
				const string __id = "cipherSuites.([Ljava/lang/String;)Lokhttp3/ConnectionSpec$Builder;";
				IntPtr native_cipherSuites = JNIEnv.NewArray (cipherSuites);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_cipherSuites);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (cipherSuites != null) {
						JNIEnv.CopyArray (native_cipherSuites, cipherSuites);
						JNIEnv.DeleteLocalRef (native_cipherSuites);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='cipherSuites' and count(parameter)=1 and parameter[1][@type='okhttp3.CipherSuite...']]"
			[Register ("cipherSuites", "([Lokhttp3/CipherSuite;)Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder CipherSuites (params global::Okhttp3.CipherSuite[] cipherSuites)
			{
				const string __id = "cipherSuites.([Lokhttp3/CipherSuite;)Lokhttp3/ConnectionSpec$Builder;";
				IntPtr native_cipherSuites = JNIEnv.NewArray (cipherSuites);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_cipherSuites);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (cipherSuites != null) {
						JNIEnv.CopyArray (native_cipherSuites, cipherSuites);
						JNIEnv.DeleteLocalRef (native_cipherSuites);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='supportsTlsExtensions' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("supportsTlsExtensions", "(Z)Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder SupportsTlsExtensions (bool supportsTlsExtensions)
			{
				const string __id = "supportsTlsExtensions.(Z)Lokhttp3/ConnectionSpec$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (supportsTlsExtensions);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='tlsVersions' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
			[Register ("tlsVersions", "([Ljava/lang/String;)Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder TlsVersions (params string[] tlsVersions)
			{
				const string __id = "tlsVersions.([Ljava/lang/String;)Lokhttp3/ConnectionSpec$Builder;";
				IntPtr native_tlsVersions = JNIEnv.NewArray (tlsVersions);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_tlsVersions);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (tlsVersions != null) {
						JNIEnv.CopyArray (native_tlsVersions, tlsVersions);
						JNIEnv.DeleteLocalRef (native_tlsVersions);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='tlsVersions' and count(parameter)=1 and parameter[1][@type='okhttp3.TlsVersion...']]"
			[Register ("tlsVersions", "([Lokhttp3/TlsVersion;)Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder TlsVersions (params global::Okhttp3.TlsVersion[] tlsVersions)
			{
				const string __id = "tlsVersions.([Lokhttp3/TlsVersion;)Lokhttp3/ConnectionSpec$Builder;";
				IntPtr native_tlsVersions = JNIEnv.NewArray (tlsVersions);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_tlsVersions);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (tlsVersions != null) {
						JNIEnv.CopyArray (native_tlsVersions, tlsVersions);
						JNIEnv.DeleteLocalRef (native_tlsVersions);
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/ConnectionSpec", typeof (ConnectionSpec));
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

		internal ConnectionSpec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool IsTls {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/method[@name='isTls' and count(parameter)=0]"
			[Register ("isTls", "()Z", "")]
			get {
				const string __id = "isTls.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/method[@name='cipherSuites' and count(parameter)=0]"
		[Register ("cipherSuites", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.CipherSuite> CipherSuites ()
		{
			const string __id = "cipherSuites.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Okhttp3.CipherSuite>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/method[@name='isCompatible' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocket']]"
		[Register ("isCompatible", "(Ljavax/net/ssl/SSLSocket;)Z", "")]
		public unsafe bool IsCompatible (global::Javax.Net.Ssl.SSLSocket socket)
		{
			const string __id = "isCompatible.(Ljavax/net/ssl/SSLSocket;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((socket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socket).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/method[@name='supportsTlsExtensions' and count(parameter)=0]"
		[Register ("supportsTlsExtensions", "()Z", "")]
		public unsafe bool SupportsTlsExtensions ()
		{
			const string __id = "supportsTlsExtensions.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/method[@name='tlsVersions' and count(parameter)=0]"
		[Register ("tlsVersions", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.TlsVersion> TlsVersions ()
		{
			const string __id = "tlsVersions.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Okhttp3.TlsVersion>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
