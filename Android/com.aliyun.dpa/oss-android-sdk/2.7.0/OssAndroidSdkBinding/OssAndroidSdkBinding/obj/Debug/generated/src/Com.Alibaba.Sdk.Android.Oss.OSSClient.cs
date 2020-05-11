using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/OSSClient", DoNotGenerateAcw=true)]
	public partial class OSSClient : global::Java.Lang.Object, global::Com.Alibaba.Sdk.Android.Oss.IOSS {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/OSSClient", typeof (OSSClient));
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

		protected OSSClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/constructor[@name='OSSClient' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.sdk.android.oss.common.auth.OSSCredentialProvider']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;)V", "")]
		public unsafe OSSClient (global::Android.Content.Context context, string endpoint, global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider credentialProvider)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_endpoint = JNIEnv.NewString (endpoint);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_endpoint);
				__args [2] = new JniArgumentValue ((credentialProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentialProvider).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_endpoint);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/constructor[@name='OSSClient' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.sdk.android.oss.common.auth.OSSCredentialProvider'] and parameter[4][@type='com.alibaba.sdk.android.oss.ClientConfiguration']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;Lcom/alibaba/sdk/android/oss/ClientConfiguration;)V", "")]
		public unsafe OSSClient (global::Android.Content.Context context, string endpoint, global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider credentialProvider, global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration conf)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;Lcom/alibaba/sdk/android/oss/ClientConfiguration;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_endpoint = JNIEnv.NewString (endpoint);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_endpoint);
				__args [2] = new JniArgumentValue ((credentialProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentialProvider).Handle);
				__args [3] = new JniArgumentValue ((conf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conf).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_endpoint);
			}
		}

		static Delegate cb_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_;
#pragma warning disable 0169
		static Delegate GetAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Handler ()
		{
			if (cb_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_ == null)
				cb_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_);
			return cb_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_;
		}

		static IntPtr n_AbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AbortMultipartUpload (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='abortMultipartUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.AbortMultipartUploadRequest']]"
		[Register ("abortMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadResult;", "GetAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadResult AbortMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest request)
		{
			const string __id = "abortMultipartUpload.(Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.AbortResumableUpload (request);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='abortResumableUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest']]"
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

		static Delegate cb_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_;
#pragma warning disable 0169
		static Delegate GetAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Handler ()
		{
			if (cb_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_ == null)
				cb_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_);
			return cb_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_;
		}

		static IntPtr n_AppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendObject (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='appendObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.AppendObjectRequest']]"
		[Register ("appendObject", "(Lcom/alibaba/sdk/android/oss/model/AppendObjectRequest;)Lcom/alibaba/sdk/android/oss/model/AppendObjectResult;", "GetAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult AppendObject (global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest request)
		{
			const string __id = "appendObject.(Lcom/alibaba/sdk/android/oss/model/AppendObjectRequest;)Lcom/alibaba/sdk/android/oss/model/AppendObjectResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncAbortMultipartUpload (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncAbortMultipartUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.AbortMultipartUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.AbortMultipartUploadRequest, com.alibaba.sdk.android.oss.model.AbortMultipartUploadResult&gt;']]"
		[Register ("asyncAbortMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncAbortMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncAbortMultipartUpload.(Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncAppendObject (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncAppendObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.AppendObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.AppendObjectRequest, com.alibaba.sdk.android.oss.model.AppendObjectResult&gt;']]"
		[Register ("asyncAppendObject", "(Lcom/alibaba/sdk/android/oss/model/AppendObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncAppendObject (global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncAppendObject.(Lcom/alibaba/sdk/android/oss/model/AppendObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncCompleteMultipartUpload (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncCompleteMultipartUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CompleteMultipartUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.CompleteMultipartUploadRequest, com.alibaba.sdk.android.oss.model.CompleteMultipartUploadResult&gt;']]"
		[Register ("asyncCompleteMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncCompleteMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncCompleteMultipartUpload.(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncCopyObject (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncCopyObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CopyObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.CopyObjectRequest, com.alibaba.sdk.android.oss.model.CopyObjectResult&gt;']]"
		[Register ("asyncCopyObject", "(Lcom/alibaba/sdk/android/oss/model/CopyObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncCopyObject (global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncCopyObject.(Lcom/alibaba/sdk/android/oss/model/CopyObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncCreateBucket (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncCreateBucket' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CreateBucketRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.CreateBucketRequest, com.alibaba.sdk.android.oss.model.CreateBucketResult&gt;']]"
		[Register ("asyncCreateBucket", "(Lcom/alibaba/sdk/android/oss/model/CreateBucketRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncCreateBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncCreateBucket.(Lcom/alibaba/sdk/android/oss/model/CreateBucketRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncDeleteBucket (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncDeleteBucket' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.DeleteBucketRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.DeleteBucketRequest, com.alibaba.sdk.android.oss.model.DeleteBucketResult&gt;']]"
		[Register ("asyncDeleteBucket", "(Lcom/alibaba/sdk/android/oss/model/DeleteBucketRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncDeleteBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncDeleteBucket.(Lcom/alibaba/sdk/android/oss/model/DeleteBucketRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncDeleteObject (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncDeleteObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.DeleteObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.DeleteObjectRequest, com.alibaba.sdk.android.oss.model.DeleteObjectResult&gt;']]"
		[Register ("asyncDeleteObject", "(Lcom/alibaba/sdk/android/oss/model/DeleteObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncDeleteObject (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncDeleteObject.(Lcom/alibaba/sdk/android/oss/model/DeleteObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncGetBucketACL (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncGetBucketACL' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GetBucketACLRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.GetBucketACLRequest, com.alibaba.sdk.android.oss.model.GetBucketACLResult&gt;']]"
		[Register ("asyncGetBucketACL", "(Lcom/alibaba/sdk/android/oss/model/GetBucketACLRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncGetBucketACL (global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncGetBucketACL.(Lcom/alibaba/sdk/android/oss/model/GetBucketACLRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncGetObject (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncGetObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GetObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.GetObjectRequest, com.alibaba.sdk.android.oss.model.GetObjectResult&gt;']]"
		[Register ("asyncGetObject", "(Lcom/alibaba/sdk/android/oss/model/GetObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncGetObject (global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncGetObject.(Lcom/alibaba/sdk/android/oss/model/GetObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncHeadObject (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncHeadObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.HeadObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.HeadObjectRequest, com.alibaba.sdk.android.oss.model.HeadObjectResult&gt;']]"
		[Register ("asyncHeadObject", "(Lcom/alibaba/sdk/android/oss/model/HeadObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncHeadObject (global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncHeadObject.(Lcom/alibaba/sdk/android/oss/model/HeadObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncInitMultipartUpload (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncInitMultipartUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.InitiateMultipartUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.InitiateMultipartUploadRequest, com.alibaba.sdk.android.oss.model.InitiateMultipartUploadResult&gt;']]"
		[Register ("asyncInitMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncInitMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncInitMultipartUpload.(Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncListObjects (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncListObjects' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ListObjectsRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ListObjectsRequest, com.alibaba.sdk.android.oss.model.ListObjectsResult&gt;']]"
		[Register ("asyncListObjects", "(Lcom/alibaba/sdk/android/oss/model/ListObjectsRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncListObjects (global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncListObjects.(Lcom/alibaba/sdk/android/oss/model/ListObjectsRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncListParts (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncListParts' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ListPartsRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ListPartsRequest, com.alibaba.sdk.android.oss.model.ListPartsResult&gt;']]"
		[Register ("asyncListParts", "(Lcom/alibaba/sdk/android/oss/model/ListPartsRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncListParts (global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncListParts.(Lcom/alibaba/sdk/android/oss/model/ListPartsRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncMultipartUpload (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncMultipartUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.MultipartUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.MultipartUploadRequest, com.alibaba.sdk.android.oss.model.CompleteMultipartUploadResult&gt;']]"
		[Register ("asyncMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncMultipartUpload.(Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncPutObject (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncPutObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.PutObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.PutObjectRequest, com.alibaba.sdk.android.oss.model.PutObjectResult&gt;']]"
		[Register ("asyncPutObject", "(Lcom/alibaba/sdk/android/oss/model/PutObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncPutObject (global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncPutObject.(Lcom/alibaba/sdk/android/oss/model/PutObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncResumableUpload (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncResumableUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ResumableUploadRequest, com.alibaba.sdk.android.oss.model.ResumableUploadResult&gt;']]"
		[Register ("asyncResumableUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncResumableUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncResumableUpload.(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncSequenceUpload (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncSequenceUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ResumableUploadRequest, com.alibaba.sdk.android.oss.model.ResumableUploadResult&gt;']]"
		[Register ("asyncSequenceUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncSequenceUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncSequenceUpload.(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncTriggerCallback (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncTriggerCallback' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.TriggerCallbackRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.TriggerCallbackRequest, com.alibaba.sdk.android.oss.model.TriggerCallbackResult&gt;']]"
		[Register ("asyncTriggerCallback", "(Lcom/alibaba/sdk/android/oss/model/TriggerCallbackRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncTriggerCallback (global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncTriggerCallback.(Lcom/alibaba/sdk/android/oss/model/TriggerCallbackRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncUploadPart (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='asyncUploadPart' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.UploadPartRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.UploadPartRequest, com.alibaba.sdk.android.oss.model.UploadPartResult&gt;']]"
		[Register ("asyncUploadPart", "(Lcom/alibaba/sdk/android/oss/model/UploadPartRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncUploadPart (global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "asyncUploadPart.(Lcom/alibaba/sdk/android/oss/model/UploadPartRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_;
#pragma warning disable 0169
		static Delegate GetCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Handler ()
		{
			if (cb_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_ == null)
				cb_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_);
			return cb_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_;
		}

		static IntPtr n_CompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CompleteMultipartUpload (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='completeMultipartUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CompleteMultipartUploadRequest']]"
		[Register ("completeMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;", "GetCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult CompleteMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest request)
		{
			const string __id = "completeMultipartUpload.(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_;
#pragma warning disable 0169
		static Delegate GetCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Handler ()
		{
			if (cb_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_ == null)
				cb_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_);
			return cb_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_;
		}

		static IntPtr n_CopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CopyObject (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='copyObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CopyObjectRequest']]"
		[Register ("copyObject", "(Lcom/alibaba/sdk/android/oss/model/CopyObjectRequest;)Lcom/alibaba/sdk/android/oss/model/CopyObjectResult;", "GetCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult CopyObject (global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest request)
		{
			const string __id = "copyObject.(Lcom/alibaba/sdk/android/oss/model/CopyObjectRequest;)Lcom/alibaba/sdk/android/oss/model/CopyObjectResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_;
#pragma warning disable 0169
		static Delegate GetCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Handler ()
		{
			if (cb_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_ == null)
				cb_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_);
			return cb_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_;
		}

		static IntPtr n_CreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateBucket (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='createBucket' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CreateBucketRequest']]"
		[Register ("createBucket", "(Lcom/alibaba/sdk/android/oss/model/CreateBucketRequest;)Lcom/alibaba/sdk/android/oss/model/CreateBucketResult;", "GetCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketResult CreateBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest request)
		{
			const string __id = "createBucket.(Lcom/alibaba/sdk/android/oss/model/CreateBucketRequest;)Lcom/alibaba/sdk/android/oss/model/CreateBucketResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_;
#pragma warning disable 0169
		static Delegate GetDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Handler ()
		{
			if (cb_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_ == null)
				cb_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_);
			return cb_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_;
		}

		static IntPtr n_DeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteBucket (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='deleteBucket' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.DeleteBucketRequest']]"
		[Register ("deleteBucket", "(Lcom/alibaba/sdk/android/oss/model/DeleteBucketRequest;)Lcom/alibaba/sdk/android/oss/model/DeleteBucketResult;", "GetDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketResult DeleteBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest request)
		{
			const string __id = "deleteBucket.(Lcom/alibaba/sdk/android/oss/model/DeleteBucketRequest;)Lcom/alibaba/sdk/android/oss/model/DeleteBucketResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_;
#pragma warning disable 0169
		static Delegate GetDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Handler ()
		{
			if (cb_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_ == null)
				cb_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_);
			return cb_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_;
		}

		static IntPtr n_DeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteObject (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='deleteObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.DeleteObjectRequest']]"
		[Register ("deleteObject", "(Lcom/alibaba/sdk/android/oss/model/DeleteObjectRequest;)Lcom/alibaba/sdk/android/oss/model/DeleteObjectResult;", "GetDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectResult DeleteObject (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest request)
		{
			const string __id = "deleteObject.(Lcom/alibaba/sdk/android/oss/model/DeleteObjectRequest;)Lcom/alibaba/sdk/android/oss/model/DeleteObjectResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			string objectKey = JNIEnv.GetString (native_objectKey, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DoesObjectExist (bucketName, objectKey);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='doesObjectExist' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_;
#pragma warning disable 0169
		static Delegate GetGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Handler ()
		{
			if (cb_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_ == null)
				cb_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_);
			return cb_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_;
		}

		static IntPtr n_GetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBucketACL (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='getBucketACL' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GetBucketACLRequest']]"
		[Register ("getBucketACL", "(Lcom/alibaba/sdk/android/oss/model/GetBucketACLRequest;)Lcom/alibaba/sdk/android/oss/model/GetBucketACLResult;", "GetGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult GetBucketACL (global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest request)
		{
			const string __id = "getBucketACL.(Lcom/alibaba/sdk/android/oss/model/GetBucketACLRequest;)Lcom/alibaba/sdk/android/oss/model/GetBucketACLResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_;
#pragma warning disable 0169
		static Delegate GetGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Handler ()
		{
			if (cb_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_ == null)
				cb_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_);
			return cb_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_;
		}

		static IntPtr n_GetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetObject (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='getObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GetObjectRequest']]"
		[Register ("getObject", "(Lcom/alibaba/sdk/android/oss/model/GetObjectRequest;)Lcom/alibaba/sdk/android/oss/model/GetObjectResult;", "GetGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult GetObject (global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest request)
		{
			const string __id = "getObject.(Lcom/alibaba/sdk/android/oss/model/GetObjectRequest;)Lcom/alibaba/sdk/android/oss/model/GetObjectResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_;
#pragma warning disable 0169
		static Delegate GetHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Handler ()
		{
			if (cb_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_ == null)
				cb_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_HeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_);
			return cb_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_;
		}

		static IntPtr n_HeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HeadObject (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='headObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.HeadObjectRequest']]"
		[Register ("headObject", "(Lcom/alibaba/sdk/android/oss/model/HeadObjectRequest;)Lcom/alibaba/sdk/android/oss/model/HeadObjectResult;", "GetHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult HeadObject (global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest request)
		{
			const string __id = "headObject.(Lcom/alibaba/sdk/android/oss/model/HeadObjectRequest;)Lcom/alibaba/sdk/android/oss/model/HeadObjectResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_;
#pragma warning disable 0169
		static Delegate GetInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Handler ()
		{
			if (cb_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_ == null)
				cb_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_);
			return cb_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_;
		}

		static IntPtr n_InitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InitMultipartUpload (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='initMultipartUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.InitiateMultipartUploadRequest']]"
		[Register ("initMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadResult;", "GetInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadResult InitMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest request)
		{
			const string __id = "initMultipartUpload.(Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_;
#pragma warning disable 0169
		static Delegate GetListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Handler ()
		{
			if (cb_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_ == null)
				cb_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_);
			return cb_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_;
		}

		static IntPtr n_ListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListObjects (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='listObjects' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ListObjectsRequest']]"
		[Register ("listObjects", "(Lcom/alibaba/sdk/android/oss/model/ListObjectsRequest;)Lcom/alibaba/sdk/android/oss/model/ListObjectsResult;", "GetListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult ListObjects (global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest request)
		{
			const string __id = "listObjects.(Lcom/alibaba/sdk/android/oss/model/ListObjectsRequest;)Lcom/alibaba/sdk/android/oss/model/ListObjectsResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_;
#pragma warning disable 0169
		static Delegate GetListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Handler ()
		{
			if (cb_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_ == null)
				cb_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_);
			return cb_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_;
		}

		static IntPtr n_ListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListParts (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='listParts' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ListPartsRequest']]"
		[Register ("listParts", "(Lcom/alibaba/sdk/android/oss/model/ListPartsRequest;)Lcom/alibaba/sdk/android/oss/model/ListPartsResult;", "GetListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult ListParts (global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest request)
		{
			const string __id = "listParts.(Lcom/alibaba/sdk/android/oss/model/ListPartsRequest;)Lcom/alibaba/sdk/android/oss/model/ListPartsResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_;
#pragma warning disable 0169
		static Delegate GetMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Handler ()
		{
			if (cb_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_ == null)
				cb_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_);
			return cb_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_;
		}

		static IntPtr n_MultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MultipartUpload (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='multipartUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.MultipartUploadRequest']]"
		[Register ("multipartUpload", "(Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;", "GetMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult MultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest request)
		{
			const string __id = "multipartUpload.(Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_presignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_;
#pragma warning disable 0169
		static Delegate GetPresignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_Handler ()
		{
			if (cb_presignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_ == null)
				cb_presignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PresignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_);
			return cb_presignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_;
		}

		static IntPtr n_PresignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PresignConstrainedObjectURL (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='presignConstrainedObjectURL' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GeneratePresignedUrlRequest']]"
		[Register ("presignConstrainedObjectURL", "(Lcom/alibaba/sdk/android/oss/model/GeneratePresignedUrlRequest;)Ljava/lang/String;", "GetPresignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_Handler")]
		public virtual unsafe string PresignConstrainedObjectURL (global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest request)
		{
			const string __id = "presignConstrainedObjectURL.(Lcom/alibaba/sdk/android/oss/model/GeneratePresignedUrlRequest;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_presignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPresignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_presignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_presignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_PresignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J);
			return cb_presignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J;
		}

		static IntPtr n_PresignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_bucketName, IntPtr native_objectKey, long expiredTimeInSeconds)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			string objectKey = JNIEnv.GetString (native_objectKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PresignConstrainedObjectURL (bucketName, objectKey, expiredTimeInSeconds));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='presignConstrainedObjectURL' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("presignConstrainedObjectURL", "(Ljava/lang/String;Ljava/lang/String;J)Ljava/lang/String;", "GetPresignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_JHandler")]
		public virtual unsafe string PresignConstrainedObjectURL (string bucketName, string objectKey, long expiredTimeInSeconds)
		{
			const string __id = "presignConstrainedObjectURL.(Ljava/lang/String;Ljava/lang/String;J)Ljava/lang/String;";
			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				__args [2] = new JniArgumentValue (expiredTimeInSeconds);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_objectKey);
			}
		}

		static Delegate cb_presignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPresignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_presignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_presignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PresignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_);
			return cb_presignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_PresignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucketName, IntPtr native_objectKey)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			string objectKey = JNIEnv.GetString (native_objectKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PresignPublicObjectURL (bucketName, objectKey));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='presignPublicObjectURL' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("presignPublicObjectURL", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetPresignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string PresignPublicObjectURL (string bucketName, string objectKey)
		{
			const string __id = "presignPublicObjectURL.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_objectKey);
			}
		}

		static Delegate cb_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_;
#pragma warning disable 0169
		static Delegate GetPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Handler ()
		{
			if (cb_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_ == null)
				cb_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_);
			return cb_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_;
		}

		static IntPtr n_PutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutObject (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='putObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.PutObjectRequest']]"
		[Register ("putObject", "(Lcom/alibaba/sdk/android/oss/model/PutObjectRequest;)Lcom/alibaba/sdk/android/oss/model/PutObjectResult;", "GetPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult PutObject (global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest request)
		{
			const string __id = "putObject.(Lcom/alibaba/sdk/android/oss/model/PutObjectRequest;)Lcom/alibaba/sdk/android/oss/model/PutObjectResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
#pragma warning disable 0169
		static Delegate GetResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Handler ()
		{
			if (cb_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ == null)
				cb_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_);
			return cb_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
		}

		static IntPtr n_ResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResumableUpload (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='resumableUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest']]"
		[Register ("resumableUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;)Lcom/alibaba/sdk/android/oss/model/ResumableUploadResult;", "GetResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult ResumableUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request)
		{
			const string __id = "resumableUpload.(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;)Lcom/alibaba/sdk/android/oss/model/ResumableUploadResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
#pragma warning disable 0169
		static Delegate GetSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Handler ()
		{
			if (cb_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ == null)
				cb_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_);
			return cb_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
		}

		static IntPtr n_SequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SequenceUpload (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='sequenceUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest']]"
		[Register ("sequenceUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;)Lcom/alibaba/sdk/android/oss/model/ResumableUploadResult;", "GetSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult SequenceUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request)
		{
			const string __id = "sequenceUpload.(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;)Lcom/alibaba/sdk/android/oss/model/ResumableUploadResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_;
#pragma warning disable 0169
		static Delegate GetTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Handler ()
		{
			if (cb_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_ == null)
				cb_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_);
			return cb_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_;
		}

		static IntPtr n_TriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TriggerCallback (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='triggerCallback' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.TriggerCallbackRequest']]"
		[Register ("triggerCallback", "(Lcom/alibaba/sdk/android/oss/model/TriggerCallbackRequest;)Lcom/alibaba/sdk/android/oss/model/TriggerCallbackResult;", "GetTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackResult TriggerCallback (global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest request)
		{
			const string __id = "triggerCallback.(Lcom/alibaba/sdk/android/oss/model/TriggerCallbackRequest;)Lcom/alibaba/sdk/android/oss/model/TriggerCallbackResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_updateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_;
#pragma warning disable 0169
		static Delegate GetUpdateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_Handler ()
		{
			if (cb_updateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ == null)
				cb_updateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_);
			return cb_updateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_;
		}

		static void n_UpdateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credentialProvider)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider credentialProvider = (global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider> (native_credentialProvider, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCredentialProvider (credentialProvider);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='updateCredentialProvider' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.common.auth.OSSCredentialProvider']]"
		[Register ("updateCredentialProvider", "(Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;)V", "GetUpdateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_Handler")]
		public virtual unsafe void UpdateCredentialProvider (global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider credentialProvider)
		{
			const string __id = "updateCredentialProvider.(Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((credentialProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentialProvider).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_;
#pragma warning disable 0169
		static Delegate GetUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Handler ()
		{
			if (cb_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_ == null)
				cb_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_);
			return cb_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_;
		}

		static IntPtr n_UploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.OSSClient __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.OSSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UploadPart (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='OSSClient']/method[@name='uploadPart' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.UploadPartRequest']]"
		[Register ("uploadPart", "(Lcom/alibaba/sdk/android/oss/model/UploadPartRequest;)Lcom/alibaba/sdk/android/oss/model/UploadPartResult;", "GetUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartResult UploadPart (global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest request)
		{
			const string __id = "uploadPart.(Lcom/alibaba/sdk/android/oss/model/UploadPartRequest;)Lcom/alibaba/sdk/android/oss/model/UploadPartResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
