using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Tls {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.tls']/interface[@name='TrustRootIndex']"
	[Register ("okhttp3/internal/tls/TrustRootIndex", "", "Okhttp3.Internal.Tls.ITrustRootIndexInvoker")]
	public partial interface ITrustRootIndex : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/interface[@name='TrustRootIndex']/method[@name='findByIssuerAndSignature' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("findByIssuerAndSignature", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;", "GetFindByIssuerAndSignature_Ljava_security_cert_X509Certificate_Handler:Okhttp3.Internal.Tls.ITrustRootIndexInvoker, OkHttpBinding")]
		global::Java.Security.Cert.X509Certificate FindByIssuerAndSignature (global::Java.Security.Cert.X509Certificate p0);

	}

	[global::Android.Runtime.Register ("okhttp3/internal/tls/TrustRootIndex", DoNotGenerateAcw=true)]
	internal partial class ITrustRootIndexInvoker : global::Java.Lang.Object, ITrustRootIndex {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/tls/TrustRootIndex", typeof (ITrustRootIndexInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITrustRootIndex GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrustRootIndex> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.tls.TrustRootIndex"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrustRootIndexInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Okhttp3.Internal.Tls.ITrustRootIndex __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.ITrustRootIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.Cert.X509Certificate p0 = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindByIssuerAndSignature (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_findByIssuerAndSignature_Ljava_security_cert_X509Certificate_;
		public unsafe global::Java.Security.Cert.X509Certificate FindByIssuerAndSignature (global::Java.Security.Cert.X509Certificate p0)
		{
			if (id_findByIssuerAndSignature_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_findByIssuerAndSignature_Ljava_security_cert_X509Certificate_ = JNIEnv.GetMethodID (class_ref, "findByIssuerAndSignature", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Java.Security.Cert.X509Certificate __ret = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_findByIssuerAndSignature_Ljava_security_cert_X509Certificate_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
