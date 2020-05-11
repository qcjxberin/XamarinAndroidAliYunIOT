using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ExecutionContext']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/network/ExecutionContext", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Request extends com.alibaba.sdk.android.oss.model.OSSRequest", "Result extends com.alibaba.sdk.android.oss.model.OSSResult"})]
	public partial class ExecutionContext : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/network/ExecutionContext", typeof (ExecutionContext));
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

		protected ExecutionContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApplicationContext);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ExecutionContext']/method[@name='getApplicationContext' and count(parameter)=0]"
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

		static Delegate cb_getCancellationHandler;
#pragma warning disable 0169
		static Delegate GetGetCancellationHandlerHandler ()
		{
			if (cb_getCancellationHandler == null)
				cb_getCancellationHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCancellationHandler);
			return cb_getCancellationHandler;
		}

		static IntPtr n_GetCancellationHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CancellationHandler);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Network.CancellationHandler CancellationHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ExecutionContext']/method[@name='getCancellationHandler' and count(parameter)=0]"
			[Register ("getCancellationHandler", "()Lcom/alibaba/sdk/android/oss/network/CancellationHandler;", "GetGetCancellationHandlerHandler")]
			get {
				const string __id = "getCancellationHandler.()Lcom/alibaba/sdk/android/oss/network/CancellationHandler;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.CancellationHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCompletedCallback;
#pragma warning disable 0169
		static Delegate GetGetCompletedCallbackHandler ()
		{
			if (cb_getCompletedCallback == null)
				cb_getCompletedCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCompletedCallback);
			return cb_getCompletedCallback;
		}

		static IntPtr n_GetCompletedCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CompletedCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setCompletedCallback_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetSetCompletedCallback_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_setCompletedCallback_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_setCompletedCallback_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCompletedCallback_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_setCompletedCallback_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static void n_SetCompletedCallback_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_completedCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_completedCallback, JniHandleOwnership.DoNotTransfer);
			__this.CompletedCallback = completedCallback;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback CompletedCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ExecutionContext']/method[@name='getCompletedCallback' and count(parameter)=0]"
			[Register ("getCompletedCallback", "()Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;", "GetGetCompletedCallbackHandler")]
			get {
				const string __id = "getCompletedCallback.()Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ExecutionContext']/method[@name='setCompletedCallback' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;Request, Result&gt;']]"
			[Register ("setCompletedCallback", "(Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)V", "GetSetCompletedCallback_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler")]
			set {
				const string __id = "setCompletedCallback.(Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProgressCallback;
#pragma warning disable 0169
		static Delegate GetGetProgressCallbackHandler ()
		{
			if (cb_getProgressCallback == null)
				cb_getProgressCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProgressCallback);
			return cb_getProgressCallback;
		}

		static IntPtr n_GetProgressCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProgressCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setProgressCallback_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_;
#pragma warning disable 0169
		static Delegate GetSetProgressCallback_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_Handler ()
		{
			if (cb_setProgressCallback_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_ == null)
				cb_setProgressCallback_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProgressCallback_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_);
			return cb_setProgressCallback_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_;
		}

		static void n_SetProgressCallback_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_progressCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback progressCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback> (native_progressCallback, JniHandleOwnership.DoNotTransfer);
			__this.ProgressCallback = progressCallback;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback ProgressCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ExecutionContext']/method[@name='getProgressCallback' and count(parameter)=0]"
			[Register ("getProgressCallback", "()Lcom/alibaba/sdk/android/oss/callback/OSSProgressCallback;", "GetGetProgressCallbackHandler")]
			get {
				const string __id = "getProgressCallback.()Lcom/alibaba/sdk/android/oss/callback/OSSProgressCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ExecutionContext']/method[@name='setProgressCallback' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.callback.OSSProgressCallback']]"
			[Register ("setProgressCallback", "(Lcom/alibaba/sdk/android/oss/callback/OSSProgressCallback;)V", "GetSetProgressCallback_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_Handler")]
			set {
				const string __id = "setProgressCallback.(Lcom/alibaba/sdk/android/oss/callback/OSSProgressCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		static Delegate cb_setRequest_Lcom_alibaba_sdk_android_oss_model_OSSRequest_;
#pragma warning disable 0169
		static Delegate GetSetRequest_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Handler ()
		{
			if (cb_setRequest_Lcom_alibaba_sdk_android_oss_model_OSSRequest_ == null)
				cb_setRequest_Lcom_alibaba_sdk_android_oss_model_OSSRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequest_Lcom_alibaba_sdk_android_oss_model_OSSRequest_);
			return cb_setRequest_Lcom_alibaba_sdk_android_oss_model_OSSRequest_;
		}

		static void n_SetRequest_Lcom_alibaba_sdk_android_oss_model_OSSRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object request = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.Request = request;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ExecutionContext']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/alibaba/sdk/android/oss/model/OSSRequest;", "GetGetRequestHandler")]
			get {
				const string __id = "getRequest.()Lcom/alibaba/sdk/android/oss/model/OSSRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ExecutionContext']/method[@name='setRequest' and count(parameter)=1 and parameter[1][@type='Request']]"
			[Register ("setRequest", "(Lcom/alibaba/sdk/android/oss/model/OSSRequest;)V", "GetSetRequest_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Handler")]
			set {
				const string __id = "setRequest.(Lcom/alibaba/sdk/android/oss/model/OSSRequest;)V";
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRetryCallback;
#pragma warning disable 0169
		static Delegate GetGetRetryCallbackHandler ()
		{
			if (cb_getRetryCallback == null)
				cb_getRetryCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRetryCallback);
			return cb_getRetryCallback;
		}

		static IntPtr n_GetRetryCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RetryCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setRetryCallback_Lcom_alibaba_sdk_android_oss_callback_OSSRetryCallback_;
#pragma warning disable 0169
		static Delegate GetSetRetryCallback_Lcom_alibaba_sdk_android_oss_callback_OSSRetryCallback_Handler ()
		{
			if (cb_setRetryCallback_Lcom_alibaba_sdk_android_oss_callback_OSSRetryCallback_ == null)
				cb_setRetryCallback_Lcom_alibaba_sdk_android_oss_callback_OSSRetryCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRetryCallback_Lcom_alibaba_sdk_android_oss_callback_OSSRetryCallback_);
			return cb_setRetryCallback_Lcom_alibaba_sdk_android_oss_callback_OSSRetryCallback_;
		}

		static void n_SetRetryCallback_Lcom_alibaba_sdk_android_oss_callback_OSSRetryCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_retryCallback)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSRetryCallback retryCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSRetryCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSRetryCallback> (native_retryCallback, JniHandleOwnership.DoNotTransfer);
			__this.RetryCallback = retryCallback;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSRetryCallback RetryCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ExecutionContext']/method[@name='getRetryCallback' and count(parameter)=0]"
			[Register ("getRetryCallback", "()Lcom/alibaba/sdk/android/oss/callback/OSSRetryCallback;", "GetGetRetryCallbackHandler")]
			get {
				const string __id = "getRetryCallback.()Lcom/alibaba/sdk/android/oss/callback/OSSRetryCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSRetryCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ExecutionContext']/method[@name='setRetryCallback' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.callback.OSSRetryCallback']]"
			[Register ("setRetryCallback", "(Lcom/alibaba/sdk/android/oss/callback/OSSRetryCallback;)V", "GetSetRetryCallback_Lcom_alibaba_sdk_android_oss_callback_OSSRetryCallback_Handler")]
			set {
				const string __id = "setRetryCallback.(Lcom/alibaba/sdk/android/oss/callback/OSSRetryCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
