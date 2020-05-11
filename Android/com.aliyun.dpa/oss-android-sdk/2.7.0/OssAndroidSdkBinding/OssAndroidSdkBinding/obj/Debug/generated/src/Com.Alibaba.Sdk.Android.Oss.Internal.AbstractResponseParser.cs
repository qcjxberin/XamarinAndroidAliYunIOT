using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='AbstractResponseParser']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/AbstractResponseParser", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.alibaba.sdk.android.oss.model.OSSResult"})]
	public abstract partial class AbstractResponseParser : global::Java.Lang.Object, global::Com.Alibaba.Sdk.Android.Oss.Internal.IResponseParser {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/AbstractResponseParser", typeof (AbstractResponseParser));
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

		protected AbstractResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='AbstractResponseParser']/constructor[@name='AbstractResponseParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractResponseParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_needCloseResponse;
#pragma warning disable 0169
		static Delegate GetNeedCloseResponseHandler ()
		{
			if (cb_needCloseResponse == null)
				cb_needCloseResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NeedCloseResponse);
			return cb_needCloseResponse;
		}

		static bool n_NeedCloseResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedCloseResponse ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='AbstractResponseParser']/method[@name='needCloseResponse' and count(parameter)=0]"
		[Register ("needCloseResponse", "()Z", "GetNeedCloseResponseHandler")]
		public virtual unsafe bool NeedCloseResponse ()
		{
			const string __id = "needCloseResponse.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_;
#pragma warning disable 0169
		static Delegate GetParse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_Handler ()
		{
			if (cb_parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_ == null)
				cb_parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_);
			return cb_parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_;
		}

		static IntPtr n_Parse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage> (native_response, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (response));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='AbstractResponseParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage']]"
		[Register ("parse", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;)Lcom/alibaba/sdk/android/oss/model/OSSResult;", "GetParse_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_Handler")]
		public virtual unsafe global::Java.Lang.Object Parse (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response)
		{
			const string __id = "parse.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;)Lcom/alibaba/sdk/android/oss/model/OSSResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='AbstractResponseParser']/method[@name='safeCloseResponse' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage']]"
		[Register ("safeCloseResponse", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;)V", "")]
		public static unsafe void SafeCloseResponse (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response)
		{
			const string __id = "safeCloseResponse.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_setCRC_Lcom_alibaba_sdk_android_oss_model_OSSResult_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_;
#pragma warning disable 0169
		static Delegate GetSetCRC_Lcom_alibaba_sdk_android_oss_model_OSSResult_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_Handler ()
		{
			if (cb_setCRC_Lcom_alibaba_sdk_android_oss_model_OSSResult_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_ == null)
				cb_setCRC_Lcom_alibaba_sdk_android_oss_model_OSSResult_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCRC_Lcom_alibaba_sdk_android_oss_model_OSSResult_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_);
			return cb_setCRC_Lcom_alibaba_sdk_android_oss_model_OSSResult_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_;
		}

		static void n_SetCRC_Lcom_alibaba_sdk_android_oss_model_OSSResult_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result, IntPtr native_response)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object result = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_result, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.SetCRC (result, response);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='AbstractResponseParser']/method[@name='setCRC' and count(parameter)=2 and parameter[1][@type='Result'] and parameter[2][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage']]"
		[Register ("setCRC", "(Lcom/alibaba/sdk/android/oss/model/OSSResult;Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;)V", "GetSetCRC_Lcom_alibaba_sdk_android_oss_model_OSSResult_Lcom_alibaba_sdk_android_oss_internal_ResponseMessage_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Result extends com.alibaba.sdk.android.oss.model.OSSResult"})]
		public virtual unsafe void SetCRC (global::Java.Lang.Object result, global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response)
		{
			const string __id = "setCRC.(Lcom/alibaba/sdk/android/oss/model/OSSResult;Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;)V";
			IntPtr native_result = JNIEnv.ToLocalJniHandle (result);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_result);
				__args [1] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_result);
			}
		}

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/AbstractResponseParser", DoNotGenerateAcw=true)]
	internal partial class AbstractResponseParserInvoker : AbstractResponseParser, global::Com.Alibaba.Sdk.Android.Oss.Internal.IResponseParser {

		public AbstractResponseParserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/AbstractResponseParser", typeof (AbstractResponseParserInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
