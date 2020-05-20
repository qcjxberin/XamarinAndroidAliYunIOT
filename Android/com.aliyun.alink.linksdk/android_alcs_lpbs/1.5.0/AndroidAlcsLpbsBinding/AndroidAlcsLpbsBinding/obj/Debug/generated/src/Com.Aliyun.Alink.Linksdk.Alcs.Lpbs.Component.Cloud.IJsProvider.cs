using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IJsProvider']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IJsProvider", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsProviderInvoker")]
	public partial interface IJsProvider : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IJsProvider']/method[@name='queryJsCode' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IJsQeuryCallback']]"
		[Register ("queryJsCode", "(Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IJsQeuryCallback;)V", "GetQueryJsCode_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IJsQeuryCallback_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsProviderInvoker, AndroidAlcsLpbsBinding")]
		void QueryJsCode (string p0, string p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsQeuryCallback p2);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IJsProvider", DoNotGenerateAcw=true)]
	internal partial class IJsProviderInvoker : global::Java.Lang.Object, IJsProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IJsProvider", typeof (IJsProviderInvoker));

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

		public static IJsProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJsProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IJsProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJsProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_queryJsCode_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IJsQeuryCallback_;
#pragma warning disable 0169
		static Delegate GetQueryJsCode_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IJsQeuryCallback_Handler ()
		{
			if (cb_queryJsCode_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IJsQeuryCallback_ == null)
				cb_queryJsCode_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IJsQeuryCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryJsCode_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IJsQeuryCallback_);
			return cb_queryJsCode_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IJsQeuryCallback_;
		}

		static void n_QueryJsCode_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IJsQeuryCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsProvider __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsQeuryCallback p2 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsQeuryCallback)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsQeuryCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.QueryJsCode (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_queryJsCode_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IJsQeuryCallback_;
		public unsafe void QueryJsCode (string p0, string p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsQeuryCallback p2)
		{
			if (id_queryJsCode_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IJsQeuryCallback_ == IntPtr.Zero)
				id_queryJsCode_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IJsQeuryCallback_ = JNIEnv.GetMethodID (class_ref, "queryJsCode", "(Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IJsQeuryCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queryJsCode_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IJsQeuryCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
