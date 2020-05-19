using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='CacheRequest']"
	[Register ("okhttp3/internal/http/CacheRequest", "", "Okhttp3.Internal.Http.ICacheRequestInvoker")]
	public partial interface ICacheRequest : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='CacheRequest']/method[@name='abort' and count(parameter)=0]"
		[Register ("abort", "()V", "GetAbortHandler:Okhttp3.Internal.Http.ICacheRequestInvoker, OkHttpBinding")]
		void Abort ();

	}

	[global::Android.Runtime.Register ("okhttp3/internal/http/CacheRequest", DoNotGenerateAcw=true)]
	internal partial class ICacheRequestInvoker : global::Java.Lang.Object, ICacheRequest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/CacheRequest", typeof (ICacheRequestInvoker));

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

		public static ICacheRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICacheRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.http.CacheRequest"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICacheRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_abort;
#pragma warning disable 0169
		static Delegate GetAbortHandler ()
		{
			if (cb_abort == null)
				cb_abort = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Abort);
			return cb_abort;
		}

		static void n_Abort (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.Internal.Http.ICacheRequest __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.ICacheRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Abort ();
		}
#pragma warning restore 0169

		IntPtr id_abort;
		public unsafe void Abort ()
		{
			if (id_abort == IntPtr.Zero)
				id_abort = JNIEnv.GetMethodID (class_ref, "abort", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_abort);
		}

	}

}
