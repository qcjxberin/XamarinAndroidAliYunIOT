using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap {

	[Register ("com/aliyun/alink/linksdk/alcs/coap/IAuthHandler", DoNotGenerateAcw=true)]
	public abstract class AuthHandler : Java.Lang.Object {

		internal AuthHandler ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAuthHandler']/field[@name='AUTH_ACCESS_TOKEN_INVALID']"
		[Register ("AUTH_ACCESS_TOKEN_INVALID")]
		public const int AuthAccessTokenInvalid = (int) 502;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAuthHandler']/field[@name='AUTH_ACCESS_TOKEN_REVOKE']"
		[Register ("AUTH_ACCESS_TOKEN_REVOKE")]
		public const int AuthAccessTokenRevoke = (int) 501;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAuthHandler']/field[@name='AUTH_AUTH_ILLEGALSIGN']"
		[Register ("AUTH_AUTH_ILLEGALSIGN")]
		public const int AuthAuthIllegalsign = (int) 506;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAuthHandler']/field[@name='AUTH_SUCCESS']"
		[Register ("AUTH_SUCCESS")]
		public const int AuthSuccess = (int) 200;
	}

	[Register ("com/aliyun/alink/linksdk/alcs/coap/IAuthHandler", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AuthHandler' type. This type will be removed in a future release.", error: true)]
	public abstract class AuthHandlerConsts : AuthHandler {

		private AuthHandlerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAuthHandler']"
	[Register ("com/aliyun/alink/linksdk/alcs/coap/IAuthHandler", "", "Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAuthHandlerInvoker")]
	public partial interface IAuthHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAuthHandler']/method[@name='onAuthResult' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onAuthResult", "(Ljava/lang/String;II)V", "GetOnAuthResult_Ljava_lang_String_IIHandler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAuthHandlerInvoker, CoapSdkBinding")]
		void OnAuthResult (string p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/IAuthHandler", DoNotGenerateAcw=true)]
	internal partial class IAuthHandlerInvoker : global::Java.Lang.Object, IAuthHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/IAuthHandler", typeof (IAuthHandlerInvoker));

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

		public static IAuthHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.coap.IAuthHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAuthResult_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetOnAuthResult_Ljava_lang_String_IIHandler ()
		{
			if (cb_onAuthResult_Ljava_lang_String_II == null)
				cb_onAuthResult_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnAuthResult_Ljava_lang_String_II);
			return cb_onAuthResult_Ljava_lang_String_II;
		}

		static void n_OnAuthResult_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAuthHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAuthHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthResult (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onAuthResult_Ljava_lang_String_II;
		public unsafe void OnAuthResult (string p0, int p1, int p2)
		{
			if (id_onAuthResult_Ljava_lang_String_II == IntPtr.Zero)
				id_onAuthResult_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "onAuthResult", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAuthResult_Ljava_lang_String_II, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
