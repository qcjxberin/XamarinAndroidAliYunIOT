using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/interface[@name='ResponseParser']"
	[Register ("com/alibaba/sdk/android/oss/internal/ResponseParser", "", "Com.Alibaba.Sdk.Android.Oss.Internal.IResponseParserInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.alibaba.sdk.android.oss.model.OSSResult"})]
	public partial interface IResponseParser : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/interface[@name='ResponseParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage']]"
		[Register ("parse", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;)Lcom/alibaba/sdk/android/oss/model/OSSResult;", "GetParse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_Handler:Com.Alibaba.Sdk.Android.Oss.Internal.IResponseParserInvoker, OssAndroidSdkBinding")]
		global::Java.Lang.Object Parse (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage p0);

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParser", DoNotGenerateAcw=true)]
	internal partial class IResponseParserInvoker : global::Java.Lang.Object, IResponseParser {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParser", typeof (IResponseParserInvoker));

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

		public static IResponseParser GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResponseParser> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.oss.internal.ResponseParser"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResponseParserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_;
#pragma warning disable 0169
		static Delegate GetParse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_Handler ()
		{
			if (cb_parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_ == null)
				cb_parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_);
			return cb_parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_;
		}

		static IntPtr n_Parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.IResponseParser __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.IResponseParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_;
		public unsafe global::Java.Lang.Object Parse (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage p0)
		{
			if (id_parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_ == IntPtr.Zero)
				id_parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;)Lcom/alibaba/sdk/android/oss/model/OSSResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
