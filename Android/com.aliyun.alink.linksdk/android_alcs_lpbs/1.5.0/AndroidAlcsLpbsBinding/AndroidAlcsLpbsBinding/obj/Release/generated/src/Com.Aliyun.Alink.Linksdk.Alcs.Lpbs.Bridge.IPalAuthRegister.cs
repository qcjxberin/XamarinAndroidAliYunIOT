using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalAuthRegister']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalAuthRegister", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalAuthRegisterInvoker")]
	public partial interface IPalAuthRegister : IJavaObject, IJavaPeerable {

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider Provider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalAuthRegister']/method[@name='getProvider' and count(parameter)=0]"
			[Register ("getProvider", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider;", "GetGetProviderHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalAuthRegisterInvoker, AndroidAlcsLpbsBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalAuthRegister']/method[@name='setAuthProvider' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.auth.IAuthProvider']]"
		[Register ("setAuthProvider", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider;)Z", "GetSetAuthProvider_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalAuthRegisterInvoker, AndroidAlcsLpbsBinding")]
		bool SetAuthProvider (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalAuthRegister", DoNotGenerateAcw=true)]
	internal partial class IPalAuthRegisterInvoker : global::Java.Lang.Object, IPalAuthRegister {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalAuthRegister", typeof (IPalAuthRegisterInvoker));

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

		public static IPalAuthRegister GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPalAuthRegister> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.bridge.IPalAuthRegister"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPalAuthRegisterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getProvider;
#pragma warning disable 0169
		static Delegate GetGetProviderHandler ()
		{
			if (cb_getProvider == null)
				cb_getProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProvider);
			return cb_getProvider;
		}

		static IntPtr n_GetProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalAuthRegister __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalAuthRegister> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Provider);
		}
#pragma warning restore 0169

		IntPtr id_getProvider;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider Provider {
			get {
				if (id_getProvider == IntPtr.Zero)
					id_getProvider = JNIEnv.GetMethodID (class_ref, "getProvider", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider;");
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_setAuthProvider_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_;
#pragma warning disable 0169
		static Delegate GetSetAuthProvider_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_Handler ()
		{
			if (cb_setAuthProvider_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_ == null)
				cb_setAuthProvider_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetAuthProvider_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_);
			return cb_setAuthProvider_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_;
		}

		static bool n_SetAuthProvider_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalAuthRegister __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalAuthRegister> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetAuthProvider (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setAuthProvider_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_;
		public unsafe bool SetAuthProvider (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider p0)
		{
			if (id_setAuthProvider_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_ == IntPtr.Zero)
				id_setAuthProvider_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_ = JNIEnv.GetMethodID (class_ref, "setAuthProvider", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setAuthProvider_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_, __args);
			return __ret;
		}

	}

}
