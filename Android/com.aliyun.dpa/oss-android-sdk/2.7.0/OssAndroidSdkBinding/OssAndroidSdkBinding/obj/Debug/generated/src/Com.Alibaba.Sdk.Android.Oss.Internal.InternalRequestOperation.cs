using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/InternalRequestOperation", DoNotGenerateAcw=true)]
	public partial class InternalRequestOperation : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/InternalRequestOperation", typeof (InternalRequestOperation));
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

		protected InternalRequestOperation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/constructor[@name='InternalRequestOperation' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.net.URI'] and parameter[3][@type='com.alibaba.sdk.android.oss.common.auth.OSSCredentialProvider'] and parameter[4][@type='com.alibaba.sdk.android.oss.ClientConfiguration']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/net/URI;Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;Lcom/alibaba/sdk/android/oss/ClientConfiguration;)V", "")]
		public unsafe InternalRequestOperation (global::Android.Content.Context context, global::Java.Net.URI endpoint, global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider credentialProvider, global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration conf)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/net/URI;Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;Lcom/alibaba/sdk/android/oss/ClientConfiguration;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((endpoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endpoint).Handle);
				__args [2] = new JniArgumentValue ((credentialProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentialProvider).Handle);
				__args [3] = new JniArgumentValue ((conf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conf).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getApplicationContext;
#pragma warning disable 0169
		static Delegate GetGetApplicationContextHandler ()
		{
			if (cb_getApplicationContext == null)
				cb_getApplicationContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationContext);
			return cb_getApplicationContext;
		}

		static IntPtr n_GetApplicationContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApplicationContext);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='getApplicationContext' and count(parameter)=0]"
			[Register ("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get {
				const string __id = "getApplicationContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConf;
#pragma warning disable 0169
		static Delegate GetGetConfHandler ()
		{
			if (cb_getConf == null)
				cb_getConf = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConf);
			return cb_getConf;
		}

		static IntPtr n_GetConf (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Conf);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration Conf {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='getConf' and count(parameter)=0]"
			[Register ("getConf", "()Lcom/alibaba/sdk/android/oss/ClientConfiguration;", "GetGetConfHandler")]
			get {
				const string __id = "getConf.()Lcom/alibaba/sdk/android/oss/ClientConfiguration;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInnerClient;
#pragma warning disable 0169
		static Delegate GetGetInnerClientHandler ()
		{
			if (cb_getInnerClient == null)
				cb_getInnerClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInnerClient);
			return cb_getInnerClient;
		}

		static IntPtr n_GetInnerClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InnerClient);
		}
#pragma warning restore 0169

		public virtual unsafe global::Okhttp3.OkHttpClient InnerClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='getInnerClient' and count(parameter)=0]"
			[Register ("getInnerClient", "()Lokhttp3/OkHttpClient;", "GetGetInnerClientHandler")]
			get {
				const string __id = "getInnerClient.()Lokhttp3/OkHttpClient;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AbortMultipartUpload (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='abortMultipartUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.AbortMultipartUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.AbortMultipartUploadRequest, com.alibaba.sdk.android.oss.model.AbortMultipartUploadResult&gt;']]"
		[Register ("abortMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AbortMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "abortMultipartUpload.(Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendObject (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='appendObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.AppendObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.AppendObjectRequest, com.alibaba.sdk.android.oss.model.AppendObjectResult&gt;']]"
		[Register ("appendObject", "(Lcom/alibaba/sdk/android/oss/model/AppendObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AppendObject (global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "appendObject.(Lcom/alibaba/sdk/android/oss/model/AppendObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_;
#pragma warning disable 0169
		static Delegate GetAsyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Handler ()
		{
			if (cb_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_ == null)
				cb_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_);
			return cb_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_;
		}

		static IntPtr n_AsyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncTriggerCallback (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='asyncTriggerCallback' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.TriggerCallbackRequest']]"
		[Register ("asyncTriggerCallback", "(Lcom/alibaba/sdk/android/oss/model/TriggerCallbackRequest;)Lcom/alibaba/sdk/android/oss/model/TriggerCallbackResult;", "GetAsyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackResult AsyncTriggerCallback (global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest request)
		{
			const string __id = "asyncTriggerCallback.(Lcom/alibaba/sdk/android/oss/model/TriggerCallbackRequest;)Lcom/alibaba/sdk/android/oss/model/TriggerCallbackResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_CompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CompleteMultipartUpload (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='completeMultipartUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CompleteMultipartUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.CompleteMultipartUploadRequest, com.alibaba.sdk.android.oss.model.CompleteMultipartUploadResult&gt;']]"
		[Register ("completeMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask CompleteMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "completeMultipartUpload.(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_CopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CopyObject (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='copyObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CopyObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.CopyObjectRequest, com.alibaba.sdk.android.oss.model.CopyObjectResult&gt;']]"
		[Register ("copyObject", "(Lcom/alibaba/sdk/android/oss/model/CopyObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask CopyObject (global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "copyObject.(Lcom/alibaba/sdk/android/oss/model/CopyObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_CreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateBucket (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='createBucket' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CreateBucketRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.CreateBucketRequest, com.alibaba.sdk.android.oss.model.CreateBucketResult&gt;']]"
		[Register ("createBucket", "(Lcom/alibaba/sdk/android/oss/model/CreateBucketRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask CreateBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "createBucket.(Lcom/alibaba/sdk/android/oss/model/CreateBucketRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_DeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteBucket (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='deleteBucket' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.DeleteBucketRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.DeleteBucketRequest, com.alibaba.sdk.android.oss.model.DeleteBucketResult&gt;']]"
		[Register ("deleteBucket", "(Lcom/alibaba/sdk/android/oss/model/DeleteBucketRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask DeleteBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "deleteBucket.(Lcom/alibaba/sdk/android/oss/model/DeleteBucketRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_DeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteObject (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='deleteObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.DeleteObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.DeleteObjectRequest, com.alibaba.sdk.android.oss.model.DeleteObjectResult&gt;']]"
		[Register ("deleteObject", "(Lcom/alibaba/sdk/android/oss/model/DeleteObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask DeleteObject (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "deleteObject.(Lcom/alibaba/sdk/android/oss/model/DeleteObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_GetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBucketACL (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='getBucketACL' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GetBucketACLRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.GetBucketACLRequest, com.alibaba.sdk.android.oss.model.GetBucketACLResult&gt;']]"
		[Register ("getBucketACL", "(Lcom/alibaba/sdk/android/oss/model/GetBucketACLRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask GetBucketACL (global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "getBucketACL.(Lcom/alibaba/sdk/android/oss/model/GetBucketACLRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_GetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetObject (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='getObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GetObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.GetObjectRequest, com.alibaba.sdk.android.oss.model.GetObjectResult&gt;']]"
		[Register ("getObject", "(Lcom/alibaba/sdk/android/oss/model/GetObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask GetObject (global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "getObject.(Lcom/alibaba/sdk/android/oss/model/GetObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_HeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HeadObject (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='headObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.HeadObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.HeadObjectRequest, com.alibaba.sdk.android.oss.model.HeadObjectResult&gt;']]"
		[Register ("headObject", "(Lcom/alibaba/sdk/android/oss/model/HeadObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask HeadObject (global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "headObject.(Lcom/alibaba/sdk/android/oss/model/HeadObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_InitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InitMultipartUpload (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='initMultipartUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.InitiateMultipartUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.InitiateMultipartUploadRequest, com.alibaba.sdk.android.oss.model.InitiateMultipartUploadResult&gt;']]"
		[Register ("initMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask InitMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "initMultipartUpload.(Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_ListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListObjects (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='listObjects' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ListObjectsRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ListObjectsRequest, com.alibaba.sdk.android.oss.model.ListObjectsResult&gt;']]"
		[Register ("listObjects", "(Lcom/alibaba/sdk/android/oss/model/ListObjectsRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask ListObjects (global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "listObjects.(Lcom/alibaba/sdk/android/oss/model/ListObjectsRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_ListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListParts (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='listParts' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ListPartsRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ListPartsRequest, com.alibaba.sdk.android.oss.model.ListPartsResult&gt;']]"
		[Register ("listParts", "(Lcom/alibaba/sdk/android/oss/model/ListPartsRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask ListParts (global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "listParts.(Lcom/alibaba/sdk/android/oss/model/ListPartsRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_PutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutObject (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='putObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.PutObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.PutObjectRequest, com.alibaba.sdk.android.oss.model.PutObjectResult&gt;']]"
		[Register ("putObject", "(Lcom/alibaba/sdk/android/oss/model/PutObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask PutObject (global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "putObject.(Lcom/alibaba/sdk/android/oss/model/PutObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_;
#pragma warning disable 0169
		static Delegate GetSetCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_Handler ()
		{
			if (cb_setCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ == null)
				cb_setCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_);
			return cb_setCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_;
		}

		static void n_SetCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credentialProvider)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider credentialProvider = (global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider> (native_credentialProvider, JniHandleOwnership.DoNotTransfer);
			__this.SetCredentialProvider (credentialProvider);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='setCredentialProvider' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.common.auth.OSSCredentialProvider']]"
		[Register ("setCredentialProvider", "(Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;)V", "GetSetCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_Handler")]
		public virtual unsafe void SetCredentialProvider (global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider credentialProvider)
		{
			const string __id = "setCredentialProvider.(Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((credentialProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentialProvider).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_syncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_;
#pragma warning disable 0169
		static Delegate GetSyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Handler ()
		{
			if (cb_syncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_ == null)
				cb_syncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_);
			return cb_syncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_;
		}

		static IntPtr n_SyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SyncAppendObject (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='syncAppendObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.AppendObjectRequest']]"
		[Register ("syncAppendObject", "(Lcom/alibaba/sdk/android/oss/model/AppendObjectRequest;)Lcom/alibaba/sdk/android/oss/model/AppendObjectResult;", "GetSyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult SyncAppendObject (global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest request)
		{
			const string __id = "syncAppendObject.(Lcom/alibaba/sdk/android/oss/model/AppendObjectRequest;)Lcom/alibaba/sdk/android/oss/model/AppendObjectResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_syncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_;
#pragma warning disable 0169
		static Delegate GetSyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Handler ()
		{
			if (cb_syncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_ == null)
				cb_syncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_);
			return cb_syncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_;
		}

		static IntPtr n_SyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SyncCompleteMultipartUpload (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='syncCompleteMultipartUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CompleteMultipartUploadRequest']]"
		[Register ("syncCompleteMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;", "GetSyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult SyncCompleteMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest request)
		{
			const string __id = "syncCompleteMultipartUpload.(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_syncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_;
#pragma warning disable 0169
		static Delegate GetSyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Handler ()
		{
			if (cb_syncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_ == null)
				cb_syncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_);
			return cb_syncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_;
		}

		static IntPtr n_SyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SyncPutObject (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='syncPutObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.PutObjectRequest']]"
		[Register ("syncPutObject", "(Lcom/alibaba/sdk/android/oss/model/PutObjectRequest;)Lcom/alibaba/sdk/android/oss/model/PutObjectResult;", "GetSyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult SyncPutObject (global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest request)
		{
			const string __id = "syncPutObject.(Lcom/alibaba/sdk/android/oss/model/PutObjectRequest;)Lcom/alibaba/sdk/android/oss/model/PutObjectResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_syncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_;
#pragma warning disable 0169
		static Delegate GetSyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Handler ()
		{
			if (cb_syncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_ == null)
				cb_syncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_);
			return cb_syncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_;
		}

		static IntPtr n_SyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SyncUploadPart (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='syncUploadPart' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.UploadPartRequest']]"
		[Register ("syncUploadPart", "(Lcom/alibaba/sdk/android/oss/model/UploadPartRequest;)Lcom/alibaba/sdk/android/oss/model/UploadPartResult;", "GetSyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartResult SyncUploadPart (global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest request)
		{
			const string __id = "syncUploadPart.(Lcom/alibaba/sdk/android/oss/model/UploadPartRequest;)Lcom/alibaba/sdk/android/oss/model/UploadPartResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_TriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_TriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TriggerCallback (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='triggerCallback' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.TriggerCallbackRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.TriggerCallbackRequest, com.alibaba.sdk.android.oss.model.TriggerCallbackResult&gt;']]"
		[Register ("triggerCallback", "(Lcom/alibaba/sdk/android/oss/model/TriggerCallbackRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask TriggerCallback (global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "triggerCallback.(Lcom/alibaba/sdk/android/oss/model/TriggerCallbackRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_UploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UploadPart (request, completedCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='InternalRequestOperation']/method[@name='uploadPart' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.UploadPartRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.UploadPartRequest, com.alibaba.sdk.android.oss.model.UploadPartResult&gt;']]"
		[Register ("uploadPart", "(Lcom/alibaba/sdk/android/oss/model/UploadPartRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask UploadPart (global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback)
		{
			const string __id = "uploadPart.(Lcom/alibaba/sdk/android/oss/model/UploadPartRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;";
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
