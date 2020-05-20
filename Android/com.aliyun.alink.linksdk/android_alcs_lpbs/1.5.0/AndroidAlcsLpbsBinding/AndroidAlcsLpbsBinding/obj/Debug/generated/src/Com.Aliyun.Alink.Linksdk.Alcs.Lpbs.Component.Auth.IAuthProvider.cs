using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth {

	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider", DoNotGenerateAcw=true)]
	public abstract class AuthProvider : Java.Lang.Object {

		internal AuthProvider ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.auth']/interface[@name='IAuthProvider']/field[@name='AUTH_PATH_PRODUCT_IDTOKEY']"
		[Register ("AUTH_PATH_PRODUCT_IDTOKEY")]
		public const string AuthPathProductIdtokey = (string) "productIdToProductKey";
	}

	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AuthProvider' type. This type will be removed in a future release.", error: true)]
	public abstract class AuthProviderConsts : AuthProvider {

		private AuthProviderConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.auth']/interface[@name='IAuthProvider']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProviderInvoker")]
	public partial interface IAuthProvider : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.auth']/interface[@name='IAuthProvider']/method[@name='queryAuthInfo' and count(parameter)=4 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.auth.IAuthProviderListener']]"
		[Register ("queryAuthInfo", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Ljava/lang/String;Ljava/lang/Object;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProviderListener;)V", "GetQueryAuthInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProviderListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProviderInvoker, AndroidAlcsLpbsBinding")]
		void QueryAuthInfo (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, string p1, global::Java.Lang.Object p2, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProviderListener p3);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider", DoNotGenerateAcw=true)]
	internal partial class IAuthProviderInvoker : global::Java.Lang.Object, IAuthProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider", typeof (IAuthProviderInvoker));

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

		public static IAuthProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.component.auth.IAuthProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_queryAuthInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProviderListener_;
#pragma warning disable 0169
		static Delegate GetQueryAuthInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProviderListener_Handler ()
		{
			if (cb_queryAuthInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProviderListener_ == null)
				cb_queryAuthInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProviderListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryAuthInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProviderListener_);
			return cb_queryAuthInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProviderListener_;
		}

		static void n_QueryAuthInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProviderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProviderListener p3 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProviderListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProviderListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.QueryAuthInfo (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_queryAuthInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProviderListener_;
		public unsafe void QueryAuthInfo (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, string p1, global::Java.Lang.Object p2, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProviderListener p3)
		{
			if (id_queryAuthInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProviderListener_ == IntPtr.Zero)
				id_queryAuthInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProviderListener_ = JNIEnv.GetMethodID (class_ref, "queryAuthInfo", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Ljava/lang/String;Ljava/lang/Object;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProviderListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queryAuthInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProviderListener_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
