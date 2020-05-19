using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Tls {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='TrustRootIndex']"
	[global::Android.Runtime.Register ("okhttp3/internal/tls/TrustRootIndex", DoNotGenerateAcw=true)]
	public abstract partial class TrustRootIndex : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='TrustRootIndex.AndroidTrustRootIndex']"
		[global::Android.Runtime.Register ("okhttp3/internal/tls/TrustRootIndex$AndroidTrustRootIndex", DoNotGenerateAcw=true)]
		public sealed partial class AndroidTrustRootIndex : global::Okhttp3.Internal.Tls.TrustRootIndex {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/tls/TrustRootIndex$AndroidTrustRootIndex", typeof (AndroidTrustRootIndex));
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

			internal AndroidTrustRootIndex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='TrustRootIndex.AndroidTrustRootIndex']/method[@name='findByIssuerAndSignature' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
			[Register ("findByIssuerAndSignature", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;", "")]
			public override unsafe global::Java.Security.Cert.X509Certificate FindByIssuerAndSignature (global::Java.Security.Cert.X509Certificate cert)
			{
				const string __id = "findByIssuerAndSignature.(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((cert == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cert).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='TrustRootIndex.BasicTrustRootIndex']"
		[global::Android.Runtime.Register ("okhttp3/internal/tls/TrustRootIndex$BasicTrustRootIndex", DoNotGenerateAcw=true)]
		public sealed partial class BasicTrustRootIndex : global::Okhttp3.Internal.Tls.TrustRootIndex {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/tls/TrustRootIndex$BasicTrustRootIndex", typeof (BasicTrustRootIndex));
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

			internal BasicTrustRootIndex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='TrustRootIndex.BasicTrustRootIndex']/constructor[@name='TrustRootIndex.BasicTrustRootIndex' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate...']]"
			[Register (".ctor", "([Ljava/security/cert/X509Certificate;)V", "")]
			public unsafe BasicTrustRootIndex (params global::Java.Security.Cert.X509Certificate[] caCerts)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "([Ljava/security/cert/X509Certificate;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_caCerts = JNIEnv.NewArray (caCerts);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_caCerts);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (caCerts != null) {
						JNIEnv.CopyArray (native_caCerts, caCerts);
						JNIEnv.DeleteLocalRef (native_caCerts);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='TrustRootIndex.BasicTrustRootIndex']/method[@name='findByIssuerAndSignature' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
			[Register ("findByIssuerAndSignature", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;", "")]
			public override unsafe global::Java.Security.Cert.X509Certificate FindByIssuerAndSignature (global::Java.Security.Cert.X509Certificate cert)
			{
				const string __id = "findByIssuerAndSignature.(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((cert == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cert).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/tls/TrustRootIndex", typeof (TrustRootIndex));
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

		protected TrustRootIndex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='TrustRootIndex']/constructor[@name='TrustRootIndex' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TrustRootIndex ()
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

		static Delegate cb_findByIssuerAndSignature_Ljava_security_cert_X509Certificate_;
#pragma warning disable 0169
		static Delegate GetFindByIssuerAndSignature_Ljava_security_cert_X509Certificate_Handler ()
		{
			if (cb_findByIssuerAndSignature_Ljava_security_cert_X509Certificate_ == null)
				cb_findByIssuerAndSignature_Ljava_security_cert_X509Certificate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindByIssuerAndSignature_Ljava_security_cert_X509Certificate_);
			return cb_findByIssuerAndSignature_Ljava_security_cert_X509Certificate_;
		}

		static IntPtr n_FindByIssuerAndSignature_Ljava_security_cert_X509Certificate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.Tls.TrustRootIndex __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.TrustRootIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.Cert.X509Certificate p0 = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindByIssuerAndSignature (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='TrustRootIndex']/method[@name='findByIssuerAndSignature' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("findByIssuerAndSignature", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;", "GetFindByIssuerAndSignature_Ljava_security_cert_X509Certificate_Handler")]
		public abstract global::Java.Security.Cert.X509Certificate FindByIssuerAndSignature (global::Java.Security.Cert.X509Certificate p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='TrustRootIndex']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate...']]"
		[Register ("get", "([Ljava/security/cert/X509Certificate;)Lokhttp3/internal/tls/TrustRootIndex;", "")]
		public static unsafe global::Okhttp3.Internal.Tls.TrustRootIndex Get (params global::Java.Security.Cert.X509Certificate[] caCerts)
		{
			const string __id = "get.([Ljava/security/cert/X509Certificate;)Lokhttp3/internal/tls/TrustRootIndex;";
			IntPtr native_caCerts = JNIEnv.NewArray (caCerts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_caCerts);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.TrustRootIndex> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (caCerts != null) {
					JNIEnv.CopyArray (native_caCerts, caCerts);
					JNIEnv.DeleteLocalRef (native_caCerts);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='TrustRootIndex']/method[@name='get' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.X509TrustManager']]"
		[Register ("get", "(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/TrustRootIndex;", "")]
		public static unsafe global::Okhttp3.Internal.Tls.TrustRootIndex Get (global::Javax.Net.Ssl.IX509TrustManager trustManager)
		{
			const string __id = "get.(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/TrustRootIndex;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((trustManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trustManager).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.TrustRootIndex> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("okhttp3/internal/tls/TrustRootIndex", DoNotGenerateAcw=true)]
	internal partial class TrustRootIndexInvoker : TrustRootIndex {

		public TrustRootIndexInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/tls/TrustRootIndex", typeof (TrustRootIndexInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='TrustRootIndex']/method[@name='findByIssuerAndSignature' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("findByIssuerAndSignature", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;", "GetFindByIssuerAndSignature_Ljava_security_cert_X509Certificate_Handler")]
		public override unsafe global::Java.Security.Cert.X509Certificate FindByIssuerAndSignature (global::Java.Security.Cert.X509Certificate p0)
		{
			const string __id = "findByIssuerAndSignature.(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
