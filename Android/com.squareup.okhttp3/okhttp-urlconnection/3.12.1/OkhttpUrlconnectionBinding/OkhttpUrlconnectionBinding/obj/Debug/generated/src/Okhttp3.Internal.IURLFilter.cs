using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal']/interface[@name='URLFilter']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("okhttp3/internal/URLFilter", "", "Okhttp3.Internal.IURLFilterInvoker")]
	public partial interface IURLFilter : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/interface[@name='URLFilter']/method[@name='checkURLPermitted' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("checkURLPermitted", "(Ljava/net/URL;)V", "GetCheckURLPermitted_Ljava_net_URL_Handler:Okhttp3.Internal.IURLFilterInvoker, OkhttpUrlconnectionBinding")]
		void CheckURLPermitted (global::Java.Net.URL p0);

	}

	[global::Android.Runtime.Register ("okhttp3/internal/URLFilter", DoNotGenerateAcw=true)]
	internal partial class IURLFilterInvoker : global::Java.Lang.Object, IURLFilter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/URLFilter", typeof (IURLFilterInvoker));

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

		public static IURLFilter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IURLFilter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.URLFilter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IURLFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_checkURLPermitted_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetCheckURLPermitted_Ljava_net_URL_Handler ()
		{
			if (cb_checkURLPermitted_Ljava_net_URL_ == null)
				cb_checkURLPermitted_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CheckURLPermitted_Ljava_net_URL_);
			return cb_checkURLPermitted_Ljava_net_URL_;
		}

		static void n_CheckURLPermitted_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.IURLFilter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IURLFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CheckURLPermitted (p0);
		}
#pragma warning restore 0169

		IntPtr id_checkURLPermitted_Ljava_net_URL_;
		public unsafe void CheckURLPermitted (global::Java.Net.URL p0)
		{
			if (id_checkURLPermitted_Ljava_net_URL_ == IntPtr.Zero)
				id_checkURLPermitted_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "checkURLPermitted", "(Ljava/net/URL;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkURLPermitted_Ljava_net_URL_, __args);
		}

	}

}
