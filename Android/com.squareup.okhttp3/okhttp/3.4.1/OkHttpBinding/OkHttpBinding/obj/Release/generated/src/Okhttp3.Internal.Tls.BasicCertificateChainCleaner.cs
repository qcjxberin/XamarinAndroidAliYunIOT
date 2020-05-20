using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Tls {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='BasicCertificateChainCleaner']"
	[global::Android.Runtime.Register ("okhttp3/internal/tls/BasicCertificateChainCleaner", DoNotGenerateAcw=true)]
	public sealed partial class BasicCertificateChainCleaner : global::Okhttp3.Internal.Tls.CertificateChainCleaner {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/tls/BasicCertificateChainCleaner", typeof (BasicCertificateChainCleaner));
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

		internal BasicCertificateChainCleaner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='BasicCertificateChainCleaner']/constructor[@name='BasicCertificateChainCleaner' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.tls.TrustRootIndex']]"
		[Register (".ctor", "(Lokhttp3/internal/tls/TrustRootIndex;)V", "")]
		public unsafe BasicCertificateChainCleaner (global::Okhttp3.Internal.Tls.TrustRootIndex trustRootIndex)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/internal/tls/TrustRootIndex;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((trustRootIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trustRootIndex).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='BasicCertificateChainCleaner']/method[@name='clean' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.security.cert.Certificate&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("clean", "(Ljava/util/List;Ljava/lang/String;)Ljava/util/List;", "")]
		public override unsafe global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> Clean (global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> chain, string hostname)
		{
			const string __id = "clean.(Ljava/util/List;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_chain = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (chain);
			IntPtr native_hostname = JNIEnv.NewString (hostname);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_chain);
				__args [1] = new JniArgumentValue (native_hostname);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_chain);
				JNIEnv.DeleteLocalRef (native_hostname);
			}
		}

	}
}
