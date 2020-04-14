using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Apiclient.Biz {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/class[@name='ApiClientBiz']"
	[global::Android.Runtime.Register ("com/aliyun/alink/apiclient/biz/ApiClientBiz", DoNotGenerateAcw=true)]
	public partial class ApiClientBiz : global::Java.Lang.Object, global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBiz {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/apiclient/biz/ApiClientBiz", typeof (ApiClientBiz));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ApiClientBiz (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Aliyun.Alink.Apiclient.Biz.ApiClientBiz Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/class[@name='ApiClientBiz']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/alink/apiclient/biz/ApiClientBiz;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/alink/apiclient/biz/ApiClientBiz;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.ApiClientBiz> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setApiClientBiz_Lcom_aliyun_alink_apiclient_biz_IApiClientBiz_;
#pragma warning disable 0169
		static Delegate GetSetApiClientBiz_Lcom_aliyun_alink_apiclient_biz_IApiClientBiz_Handler ()
		{
			if (cb_setApiClientBiz_Lcom_aliyun_alink_apiclient_biz_IApiClientBiz_ == null)
				cb_setApiClientBiz_Lcom_aliyun_alink_apiclient_biz_IApiClientBiz_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApiClientBiz_Lcom_aliyun_alink_apiclient_biz_IApiClientBiz_);
			return cb_setApiClientBiz_Lcom_aliyun_alink_apiclient_biz_IApiClientBiz_;
		}

		static void n_SetApiClientBiz_Lcom_aliyun_alink_apiclient_biz_IApiClientBiz_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Apiclient.Biz.ApiClientBiz __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.ApiClientBiz> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBiz p0 = (global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBiz)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBiz> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetApiClientBiz (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/class[@name='ApiClientBiz']/method[@name='setApiClientBiz' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.apiclient.biz.IApiClientBiz']]"
		[Register ("setApiClientBiz", "(Lcom/aliyun/alink/apiclient/biz/IApiClientBiz;)V", "GetSetApiClientBiz_Lcom_aliyun_alink_apiclient_biz_IApiClientBiz_Handler")]
		public virtual unsafe void SetApiClientBiz (global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBiz p0)
		{
			const string __id = "setApiClientBiz.(Lcom/aliyun/alink/apiclient/biz/IApiClientBiz;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			global::Com.Aliyun.Alink.Apiclient.Biz.ApiClientBiz __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.ApiClientBiz> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback p4 = (global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.UsageTrack (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/class[@name='ApiClientBiz']/method[@name='usageTrack' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map'] and parameter[5][@type='com.aliyun.alink.apiclient.biz.IApiClientBizCallback']]"
		[Register ("usageTrack", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Lcom/aliyun/alink/apiclient/biz/IApiClientBizCallback;)V", "GetUsageTrack_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Lcom_aliyun_alink_apiclient_biz_IApiClientBizCallback_Handler")]
		public virtual unsafe void UsageTrack (string p0, string p1, string p2, global::System.Collections.IDictionary p3, global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback p4)
		{
			const string __id = "usageTrack.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Lcom/aliyun/alink/apiclient/biz/IApiClientBizCallback;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
