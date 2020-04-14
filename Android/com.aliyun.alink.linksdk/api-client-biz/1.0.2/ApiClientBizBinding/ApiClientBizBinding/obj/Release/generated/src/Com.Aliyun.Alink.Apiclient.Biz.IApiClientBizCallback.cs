using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Apiclient.Biz {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/interface[@name='IApiClientBizCallback']"
	[Register ("com/aliyun/alink/apiclient/biz/IApiClientBizCallback", "", "Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallbackInvoker")]
	public partial interface IApiClientBizCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/interface[@name='IApiClientBizCallback']/method[@name='onFail' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onFail", "(Ljava/lang/Exception;)V", "GetOnFail_Ljava_lang_Exception_Handler:Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallbackInvoker, ApiClientBizBinding")]
		void OnFail (global::Java.Lang.Exception p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/interface[@name='IApiClientBizCallback']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.apiclient.biz.IApiClientResponse']]"
		[Register ("onResponse", "(Lcom/aliyun/alink/apiclient/biz/IApiClientResponse;)V", "GetOnResponse_Lcom_aliyun_alink_apiclient_biz_IApiClientResponse_Handler:Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallbackInvoker, ApiClientBizBinding")]
		void OnResponse (global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/apiclient/biz/IApiClientBizCallback", DoNotGenerateAcw=true)]
	internal partial class IApiClientBizCallbackInvoker : global::Java.Lang.Object, IApiClientBizCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/apiclient/biz/IApiClientBizCallback", typeof (IApiClientBizCallbackInvoker));

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

		public static IApiClientBizCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiClientBizCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.apiclient.biz.IApiClientBizCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiClientBizCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFail_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnFail_Ljava_lang_Exception_Handler ()
		{
			if (cb_onFail_Ljava_lang_Exception_ == null)
				cb_onFail_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFail_Ljava_lang_Exception_);
			return cb_onFail_Ljava_lang_Exception_;
		}

		static void n_OnFail_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFail (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFail_Ljava_lang_Exception_;
		public unsafe void OnFail (global::Java.Lang.Exception p0)
		{
			if (id_onFail_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onFail_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onFail", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFail_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onResponse_Lcom_aliyun_alink_apiclient_biz_IApiClientResponse_;
#pragma warning disable 0169
		static Delegate GetOnResponse_Lcom_aliyun_alink_apiclient_biz_IApiClientResponse_Handler ()
		{
			if (cb_onResponse_Lcom_aliyun_alink_apiclient_biz_IApiClientResponse_ == null)
				cb_onResponse_Lcom_aliyun_alink_apiclient_biz_IApiClientResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponse_Lcom_aliyun_alink_apiclient_biz_IApiClientResponse_);
			return cb_onResponse_Lcom_aliyun_alink_apiclient_biz_IApiClientResponse_;
		}

		static void n_OnResponse_Lcom_aliyun_alink_apiclient_biz_IApiClientResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientBizCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse p0 = (global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResponse_Lcom_aliyun_alink_apiclient_biz_IApiClientResponse_;
		public unsafe void OnResponse (global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse p0)
		{
			if (id_onResponse_Lcom_aliyun_alink_apiclient_biz_IApiClientResponse_ == IntPtr.Zero)
				id_onResponse_Lcom_aliyun_alink_apiclient_biz_IApiClientResponse_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Lcom/aliyun/alink/apiclient/biz/IApiClientResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Lcom_aliyun_alink_apiclient_biz_IApiClientResponse_, __args);
		}

	}

}
