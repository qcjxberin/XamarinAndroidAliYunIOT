using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Tls {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='BasicTrustRootIndex']"
	[global::Android.Runtime.Register ("okhttp3/internal/tls/BasicTrustRootIndex", DoNotGenerateAcw=true)]
	public sealed partial class BasicTrustRootIndex : global::Java.Lang.Object, global::Okhttp3.Internal.Tls.ITrustRootIndex {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/tls/BasicTrustRootIndex", typeof (BasicTrustRootIndex));
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='BasicTrustRootIndex']/constructor[@name='BasicTrustRootIndex' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate...']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='BasicTrustRootIndex']/method[@name='findByIssuerAndSignature' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("findByIssuerAndSignature", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;", "")]
		public unsafe global::Java.Security.Cert.X509Certificate FindByIssuerAndSignature (global::Java.Security.Cert.X509Certificate cert)
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
}
