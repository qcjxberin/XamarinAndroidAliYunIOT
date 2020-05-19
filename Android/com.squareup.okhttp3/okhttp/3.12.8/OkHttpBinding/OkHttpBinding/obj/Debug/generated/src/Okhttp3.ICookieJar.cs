using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	[Register ("okhttp3/CookieJar", DoNotGenerateAcw=true)]
	public abstract class CookieJar : Java.Lang.Object {

		internal CookieJar ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/interface[@name='CookieJar']/field[@name='NO_COOKIES']"
		[Register ("NO_COOKIES")]
		public static global::Okhttp3.ICookieJar NoCookies {
			get {
				const string __id = "NO_COOKIES.Lokhttp3/CookieJar;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ICookieJar> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/CookieJar", typeof (CookieJar));
	}

	[Register ("okhttp3/CookieJar", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'CookieJar' type. This type will be removed in a future release.", error: true)]
	public abstract class CookieJarConsts : CookieJar {

		private CookieJarConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3']/interface[@name='CookieJar']"
	[Register ("okhttp3/CookieJar", "", "Okhttp3.ICookieJarInvoker")]
	public partial interface ICookieJar : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='CookieJar']/method[@name='loadForRequest' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
		[Register ("loadForRequest", "(Lokhttp3/HttpUrl;)Ljava/util/List;", "GetLoadForRequest_Lokhttp3_HttpUrl_Handler:Okhttp3.ICookieJarInvoker, OkHttpBinding")]
		global::System.Collections.Generic.IList<global::Okhttp3.Cookie> LoadForRequest (global::Okhttp3.HttpUrl p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='CookieJar']/method[@name='saveFromResponse' and count(parameter)=2 and parameter[1][@type='okhttp3.HttpUrl'] and parameter[2][@type='java.util.List&lt;okhttp3.Cookie&gt;']]"
		[Register ("saveFromResponse", "(Lokhttp3/HttpUrl;Ljava/util/List;)V", "GetSaveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_Handler:Okhttp3.ICookieJarInvoker, OkHttpBinding")]
		void SaveFromResponse (global::Okhttp3.HttpUrl p0, global::System.Collections.Generic.IList<global::Okhttp3.Cookie> p1);

	}

	[global::Android.Runtime.Register ("okhttp3/CookieJar", DoNotGenerateAcw=true)]
	internal partial class ICookieJarInvoker : global::Java.Lang.Object, ICookieJar {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/CookieJar", typeof (ICookieJarInvoker));

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

		public static ICookieJar GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICookieJar> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.CookieJar"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICookieJarInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_loadForRequest_Lokhttp3_HttpUrl_;
#pragma warning disable 0169
		static Delegate GetLoadForRequest_Lokhttp3_HttpUrl_Handler ()
		{
			if (cb_loadForRequest_Lokhttp3_HttpUrl_ == null)
				cb_loadForRequest_Lokhttp3_HttpUrl_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadForRequest_Lokhttp3_HttpUrl_);
			return cb_loadForRequest_Lokhttp3_HttpUrl_;
		}

		static IntPtr n_LoadForRequest_Lokhttp3_HttpUrl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.ICookieJar __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ICookieJar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.HttpUrl p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Okhttp3.Cookie>.ToLocalJniHandle (__this.LoadForRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadForRequest_Lokhttp3_HttpUrl_;
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.Cookie> LoadForRequest (global::Okhttp3.HttpUrl p0)
		{
			if (id_loadForRequest_Lokhttp3_HttpUrl_ == IntPtr.Zero)
				id_loadForRequest_Lokhttp3_HttpUrl_ = JNIEnv.GetMethodID (class_ref, "loadForRequest", "(Lokhttp3/HttpUrl;)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::System.Collections.Generic.IList<global::Okhttp3.Cookie> __ret = global::Android.Runtime.JavaList<global::Okhttp3.Cookie>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadForRequest_Lokhttp3_HttpUrl_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSaveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_Handler ()
		{
			if (cb_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_ == null)
				cb_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_);
			return cb_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_;
		}

		static void n_SaveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.ICookieJar __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ICookieJar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.HttpUrl p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Okhttp3.Cookie>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveFromResponse (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_;
		public unsafe void SaveFromResponse (global::Okhttp3.HttpUrl p0, global::System.Collections.Generic.IList<global::Okhttp3.Cookie> p1)
		{
			if (id_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_ == IntPtr.Zero)
				id_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "saveFromResponse", "(Lokhttp3/HttpUrl;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Okhttp3.Cookie>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
