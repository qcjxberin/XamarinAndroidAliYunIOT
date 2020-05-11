using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ExtensionRequestOperation']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ExtensionRequestOperation", DoNotGenerateAcw=true)]
	public partial class ExtensionRequestOperation : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ExtensionRequestOperation", typeof (ExtensionRequestOperation));
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

		protected ExtensionRequestOperation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ExtensionRequestOperation']/constructor[@name='ExtensionRequestOperation' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.InternalRequestOperation']]"
		[Register (".ctor", "(Lcom/alibaba/sdk/android/oss/internal/InternalRequestOperation;)V", "")]
		public unsafe ExtensionRequestOperation (global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation apiOperation)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/alibaba/sdk/android/oss/internal/InternalRequestOperation;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((apiOperation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apiOperation).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_abortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
#pragma warning disable 0169
		static Delegate GetAbortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Handler ()
		{
			if (cb_abortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ == null)
				cb_abortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AbortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_);
			return cb_abortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
		}

		static void n_AbortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ExtensionRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ExtensionRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.AbortResumableUpload (request);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ExtensionRequestOperation']/method[@name='abortResumableUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest']]"
		[Register ("abortResumableUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;)V", "GetAbortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Handler")]
		public virtual unsafe void AbortResumableUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request)
		{
			const string __id = "abortResumableUpload.(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_doesObjectExist_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoesObjectExist_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_doesObjectExist_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_doesObjectExist_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_DoesObjectExist_Ljava_lang_String_Ljava_lang_String_);
			return cb_doesObjectExist_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_DoesObjectExist_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucketName, IntPtr native_objectKey)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ExtensionRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ExtensionRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			string objectKey = JNIEnv.GetString (native_objectKey, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DoesObjectExist (bucketName, objectKey);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ExtensionRequestOperation']/method[@name='doesObjectExist' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("doesObjectExist", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetDoesObjectExist_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool DoesObjectExist (string bucketName, string objectKey)
		{
			const string __id = "doesObjectExist.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_objectKey);
			}
		}

		static Delegate cb_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_MultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ExtensionRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ExtensionRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MultipartUpload (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ExtensionRequestOperation']/method[@name='multipartUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.MultipartUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.MultipartUploadRequest, com.alibaba.sdk.android.oss.model.CompleteMultipartUploadResult&gt;']]"
		[Register ("multipartUpload", "(Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask MultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "multipartUpload.(Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_ResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ExtensionRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ExtensionRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResumableUpload (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ExtensionRequestOperation']/method[@name='resumableUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ResumableUploadRequest, com.alibaba.sdk.android.oss.model.ResumableUploadResult&gt;']]"
		[Register ("resumableUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask ResumableUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "resumableUpload.(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_SequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ExtensionRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ExtensionRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SequenceUpload (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ExtensionRequestOperation']/method[@name='sequenceUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ResumableUploadRequest, com.alibaba.sdk.android.oss.model.ResumableUploadResult&gt;']]"
		[Register ("sequenceUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask SequenceUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "sequenceUpload.(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
