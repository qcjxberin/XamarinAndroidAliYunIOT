using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Apiclient.Biz {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/interface[@name='IApiClientBiz']"
	[Register ("com/aliyun/alink/apiclient/biz/IApiClientBiz", "", "Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizInvoker")]
	public partial interface IApiClientBiz : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/interface[@name='IApiClientBiz']/method[@name='usageTrack' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map'] and parameter[5][@type='com.aliyun.alink.apiclient.biz.IApiClientBizCallback']]"
		[Register ("usageTrack", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Lcom/aliyun/alink/apiclient/biz/IApiClientBizCallback;)V", "GetUsageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_Handler:Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizInvoker, ApiClientBizBinding")]
		void UsageTrack (string p0, string p1, string p2, global::System.Collections.IDictionary p3, global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback p4);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/apiclient/biz/IApiClientBiz", DoNotGenerateAcw=true)]
	internal partial class IApiClientBizInvoker : global::Java.Lang.Object, IApiClientBiz {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/apiclient/biz/IApiClientBiz", typeof (IApiClientBizInvoker));

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

		public static IApiClientBiz GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiClientBiz> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.apiclient.biz.IApiClientBiz"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiClientBizInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_usageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_;
#pragma warning disable 0169
		static Delegate GetUsageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_Handler ()
		{
			if (cb_usageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_ == null)
				cb_usageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UsageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_);
			return cb_usageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_;
		}

		static void n_UsageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBiz __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBiz> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback p4 = (global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.UsageTrack (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_usageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_;
		public unsafe void UsageTrack (string p0, string p1, string p2, global::System.Collections.IDictionary p3, global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback p4)
		{
			if (id_usageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_ == IntPtr.Zero)
				id_usageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_ = JNIEnv.GetMethodID (class_ref, "usageTrack", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Lcom/aliyun/alink/apiclient/biz/IApiClientBizCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_usageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}

}
