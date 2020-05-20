using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	[Register ("okhttp3/Authenticator", DoNotGenerateAcw=true)]
	public abstract class Authenticator : Java.Lang.Object {

		internal Authenticator ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/interface[@name='Authenticator']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Okhttp3.IAuthenticator None {
			get {
				const string __id = "NONE.Lokhttp3/Authenticator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.IAuthenticator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Authenticator", typeof (Authenticator));
	}

	[Register ("okhttp3/Authenticator", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'Authenticator' type. This type will be removed in a future release.", error: true)]
	public abstract class AuthenticatorConsts : Authenticator {

		private AuthenticatorConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3']/interface[@name='Authenticator']"
	[Register ("okhttp3/Authenticator", "", "Okhttp3.IAuthenticatorInvoker")]
	public partial interface IAuthenticator : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Authenticator']/method[@name='authenticate' and count(parameter)=2 and parameter[1][@type='okhttp3.Route'] and parameter[2][@type='okhttp3.Response']]"
		[Register ("authenticate", "(Lokhttp3/Route;Lokhttp3/Response;)Lokhttp3/Request;", "GetAuthenticate_Lokhttp3_Route_Lokhttp3_Response_Handler:Okhttp3.IAuthenticatorInvoker, OkHttpBinding")]
		global::Okhttp3.Request Authenticate (global::Okhttp3.Route p0, global::Okhttp3.Response p1);

	}

	[global::Android.Runtime.Register ("okhttp3/Authenticator", DoNotGenerateAcw=true)]
	internal partial class IAuthenticatorInvoker : global::Java.Lang.Object, IAuthenticator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Authenticator", typeof (IAuthenticatorInvoker));

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

		public static IAuthenticator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthenticator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.Authenticator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthenticatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_authenticate_Lokhttp3_Route_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetAuthenticate_Lokhttp3_Route_Lokhttp3_Response_Handler ()
		{
			if (cb_authenticate_Lokhttp3_Route_Lokhttp3_Response_ == null)
				cb_authenticate_Lokhttp3_Route_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Authenticate_Lokhttp3_Route_Lokhttp3_Response_);
			return cb_authenticate_Lokhttp3_Route_Lokhttp3_Response_;
		}

		static IntPtr n_Authenticate_Lokhttp3_Route_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.IAuthenticator __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Route p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Route> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Response p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Authenticate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_authenticate_Lokhttp3_Route_Lokhttp3_Response_;
		public unsafe global::Okhttp3.Request Authenticate (global::Okhttp3.Route p0, global::Okhttp3.Response p1)
		{
			if (id_authenticate_Lokhttp3_Route_Lokhttp3_Response_ == IntPtr.Zero)
				id_authenticate_Lokhttp3_Route_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "authenticate", "(Lokhttp3/Route;Lokhttp3/Response;)Lokhttp3/Request;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Okhttp3.Request __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_authenticate_Lokhttp3_Route_Lokhttp3_Response_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
