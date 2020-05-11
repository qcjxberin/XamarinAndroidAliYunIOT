using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectRequest']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/GetObjectRequest", DoNotGenerateAcw=true)]
	public partial class GetObjectRequest : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/GetObjectRequest", typeof (GetObjectRequest));
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

		protected GetObjectRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectRequest']/constructor[@name='GetObjectRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GetObjectRequest (string bucketName, string objectKey)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_objectKey);
			}
		}

		static Delegate cb_getBucketName;
#pragma warning disable 0169
		static Delegate GetGetBucketNameHandler ()
		{
			if (cb_getBucketName == null)
				cb_getBucketName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBucketName);
			return cb_getBucketName;
		}

		static IntPtr n_GetBucketName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BucketName);
		}
#pragma warning restore 0169

		static Delegate cb_setBucketName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBucketName_Ljava_lang_String_Handler ()
		{
			if (cb_setBucketName_Ljava_lang_String_ == null)
				cb_setBucketName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBucketName_Ljava_lang_String_);
			return cb_setBucketName_Ljava_lang_String_;
		}

		static void n_SetBucketName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucketName)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			__this.BucketName = bucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectRequest']/method[@name='getBucketName' and count(parameter)=0]"
			[Register ("getBucketName", "()Ljava/lang/String;", "GetGetBucketNameHandler")]
			get {
				const string __id = "getBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectRequest']/method[@name='setBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBucketName", "(Ljava/lang/String;)V", "GetSetBucketName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBucketName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getObjectKey;
#pragma warning disable 0169
		static Delegate GetGetObjectKeyHandler ()
		{
			if (cb_getObjectKey == null)
				cb_getObjectKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObjectKey);
			return cb_getObjectKey;
		}

		static IntPtr n_GetObjectKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ObjectKey);
		}
#pragma warning restore 0169

		static Delegate cb_setObjectKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetObjectKey_Ljava_lang_String_Handler ()
		{
			if (cb_setObjectKey_Ljava_lang_String_ == null)
				cb_setObjectKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObjectKey_Ljava_lang_String_);
			return cb_setObjectKey_Ljava_lang_String_;
		}

		static void n_SetObjectKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectKey)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string objectKey = JNIEnv.GetString (native_objectKey, JniHandleOwnership.DoNotTransfer);
			__this.ObjectKey = objectKey;
		}
#pragma warning restore 0169

		public virtual unsafe string ObjectKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectRequest']/method[@name='getObjectKey' and count(parameter)=0]"
			[Register ("getObjectKey", "()Ljava/lang/String;", "GetGetObjectKeyHandler")]
			get {
				const string __id = "getObjectKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectRequest']/method[@name='setObjectKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setObjectKey", "(Ljava/lang/String;)V", "GetSetObjectKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setObjectKey.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getProgressListener;
#pragma warning disable 0169
		static Delegate GetGetProgressListenerHandler ()
		{
			if (cb_getProgressListener == null)
				cb_getProgressListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProgressListener);
			return cb_getProgressListener;
		}

		static IntPtr n_GetProgressListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProgressListener);
		}
#pragma warning restore 0169

		static Delegate cb_setProgressListener_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_;
#pragma warning disable 0169
		static Delegate GetSetProgressListener_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_Handler ()
		{
			if (cb_setProgressListener_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_ == null)
				cb_setProgressListener_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProgressListener_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_);
			return cb_setProgressListener_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_;
		}

		static void n_SetProgressListener_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_progressListener)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback progressListener = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback> (native_progressListener, JniHandleOwnership.DoNotTransfer);
			__this.ProgressListener = progressListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback ProgressListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectRequest']/method[@name='getProgressListener' and count(parameter)=0]"
			[Register ("getProgressListener", "()Lcom/alibaba/sdk/android/oss/callback/OSSProgressCallback;", "GetGetProgressListenerHandler")]
			get {
				const string __id = "getProgressListener.()Lcom/alibaba/sdk/android/oss/callback/OSSProgressCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectRequest']/method[@name='setProgressListener' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.callback.OSSProgressCallback&lt;com.alibaba.sdk.android.oss.model.GetObjectRequest&gt;']]"
			[Register ("setProgressListener", "(Lcom/alibaba/sdk/android/oss/callback/OSSProgressCallback;)V", "GetSetProgressListener_Lcom_alibaba_sdk_android_oss_callback_OSSProgressCallback_Handler")]
			set {
				const string __id = "setProgressListener.(Lcom/alibaba/sdk/android/oss/callback/OSSProgressCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRange;
#pragma warning disable 0169
		static Delegate GetGetRangeHandler ()
		{
			if (cb_getRange == null)
				cb_getRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRange);
			return cb_getRange;
		}

		static IntPtr n_GetRange (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Range);
		}
#pragma warning restore 0169

		static Delegate cb_setRange_Lcom_alibaba_sdk_android_oss_model_Range_;
#pragma warning disable 0169
		static Delegate GetSetRange_Lcom_alibaba_sdk_android_oss_model_Range_Handler ()
		{
			if (cb_setRange_Lcom_alibaba_sdk_android_oss_model_Range_ == null)
				cb_setRange_Lcom_alibaba_sdk_android_oss_model_Range_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRange_Lcom_alibaba_sdk_android_oss_model_Range_);
			return cb_setRange_Lcom_alibaba_sdk_android_oss_model_Range_;
		}

		static void n_SetRange_Lcom_alibaba_sdk_android_oss_model_Range_ (IntPtr jnienv, IntPtr native__this, IntPtr native_range)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.Range range = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.Range> (native_range, JniHandleOwnership.DoNotTransfer);
			__this.Range = range;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.Range Range {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectRequest']/method[@name='getRange' and count(parameter)=0]"
			[Register ("getRange", "()Lcom/alibaba/sdk/android/oss/model/Range;", "GetGetRangeHandler")]
			get {
				const string __id = "getRange.()Lcom/alibaba/sdk/android/oss/model/Range;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.Range> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectRequest']/method[@name='setRange' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.Range']]"
			[Register ("setRange", "(Lcom/alibaba/sdk/android/oss/model/Range;)V", "GetSetRange_Lcom_alibaba_sdk_android_oss_model_Range_Handler")]
			set {
				const string __id = "setRange.(Lcom/alibaba/sdk/android/oss/model/Range;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getxOssProcess;
#pragma warning disable 0169
		static Delegate GetGetxOssProcessHandler ()
		{
			if (cb_getxOssProcess == null)
				cb_getxOssProcess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetxOssProcess);
			return cb_getxOssProcess;
		}

		static IntPtr n_GetxOssProcess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetxOssProcess ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectRequest']/method[@name='getxOssProcess' and count(parameter)=0]"
		[Register ("getxOssProcess", "()Ljava/lang/String;", "GetGetxOssProcessHandler")]
		public virtual unsafe string GetxOssProcess ()
		{
			const string __id = "getxOssProcess.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setxOssProcess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetxOssProcess_Ljava_lang_String_Handler ()
		{
			if (cb_setxOssProcess_Ljava_lang_String_ == null)
				cb_setxOssProcess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetxOssProcess_Ljava_lang_String_);
			return cb_setxOssProcess_Ljava_lang_String_;
		}

		static void n_SetxOssProcess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_xOssProcess)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string xOssProcess = JNIEnv.GetString (native_xOssProcess, JniHandleOwnership.DoNotTransfer);
			__this.SetxOssProcess (xOssProcess);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectRequest']/method[@name='setxOssProcess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setxOssProcess", "(Ljava/lang/String;)V", "GetSetxOssProcess_Ljava_lang_String_Handler")]
		public virtual unsafe void SetxOssProcess (string xOssProcess)
		{
			const string __id = "setxOssProcess.(Ljava/lang/String;)V";
			IntPtr native_xOssProcess = JNIEnv.NewString (xOssProcess);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_xOssProcess);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_xOssProcess);
			}
		}

	}
}
