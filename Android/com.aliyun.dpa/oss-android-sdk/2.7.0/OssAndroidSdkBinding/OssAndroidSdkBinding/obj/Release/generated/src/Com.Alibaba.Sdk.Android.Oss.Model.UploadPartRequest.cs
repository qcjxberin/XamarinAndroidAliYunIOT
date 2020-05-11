using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/UploadPartRequest", DoNotGenerateAcw=true)]
	public partial class UploadPartRequest : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/UploadPartRequest", typeof (UploadPartRequest));
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

		protected UploadPartRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/constructor[@name='UploadPartRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UploadPartRequest ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/constructor[@name='UploadPartRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe UploadPartRequest (string bucketName, string objectKey, string uploadId, int partNumber)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			IntPtr native_uploadId = JNIEnv.NewString (uploadId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				__args [2] = new JniArgumentValue (native_uploadId);
				__args [3] = new JniArgumentValue (partNumber);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_objectKey);
				JNIEnv.DeleteLocalRef (native_uploadId);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			__this.BucketName = bucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='getBucketName' and count(parameter)=0]"
			[Register ("getBucketName", "()Ljava/lang/String;", "GetGetBucketNameHandler")]
			get {
				const string __id = "getBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='setBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getMd5Digest;
#pragma warning disable 0169
		static Delegate GetGetMd5DigestHandler ()
		{
			if (cb_getMd5Digest == null)
				cb_getMd5Digest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMd5Digest);
			return cb_getMd5Digest;
		}

		static IntPtr n_GetMd5Digest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Md5Digest);
		}
#pragma warning restore 0169

		static Delegate cb_setMd5Digest_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMd5Digest_Ljava_lang_String_Handler ()
		{
			if (cb_setMd5Digest_Ljava_lang_String_ == null)
				cb_setMd5Digest_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMd5Digest_Ljava_lang_String_);
			return cb_setMd5Digest_Ljava_lang_String_;
		}

		static void n_SetMd5Digest_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_md5Digest)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string md5Digest = JNIEnv.GetString (native_md5Digest, JniHandleOwnership.DoNotTransfer);
			__this.Md5Digest = md5Digest;
		}
#pragma warning restore 0169

		public virtual unsafe string Md5Digest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='getMd5Digest' and count(parameter)=0]"
			[Register ("getMd5Digest", "()Ljava/lang/String;", "GetGetMd5DigestHandler")]
			get {
				const string __id = "getMd5Digest.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='setMd5Digest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMd5Digest", "(Ljava/lang/String;)V", "GetSetMd5Digest_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMd5Digest.(Ljava/lang/String;)V";
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string objectKey = JNIEnv.GetString (native_objectKey, JniHandleOwnership.DoNotTransfer);
			__this.ObjectKey = objectKey;
		}
#pragma warning restore 0169

		public virtual unsafe string ObjectKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='getObjectKey' and count(parameter)=0]"
			[Register ("getObjectKey", "()Ljava/lang/String;", "GetGetObjectKeyHandler")]
			get {
				const string __id = "getObjectKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='setObjectKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getPartNumber;
#pragma warning disable 0169
		static Delegate GetGetPartNumberHandler ()
		{
			if (cb_getPartNumber == null)
				cb_getPartNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPartNumber);
			return cb_getPartNumber;
		}

		static int n_GetPartNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PartNumber;
		}
#pragma warning restore 0169

		static Delegate cb_setPartNumber_I;
#pragma warning disable 0169
		static Delegate GetSetPartNumber_IHandler ()
		{
			if (cb_setPartNumber_I == null)
				cb_setPartNumber_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPartNumber_I);
			return cb_setPartNumber_I;
		}

		static void n_SetPartNumber_I (IntPtr jnienv, IntPtr native__this, int partNumber)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PartNumber = partNumber;
		}
#pragma warning restore 0169

		public virtual unsafe int PartNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='getPartNumber' and count(parameter)=0]"
			[Register ("getPartNumber", "()I", "GetGetPartNumberHandler")]
			get {
				const string __id = "getPartNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='setPartNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPartNumber", "(I)V", "GetSetPartNumber_IHandler")]
			set {
				const string __id = "setPartNumber.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback progressCallback = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback> (native_progressCallback, JniHandleOwnership.DoNotTransfer);
			__this.ProgressCallback = progressCallback;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback ProgressCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='getProgressCallback' and count(parameter)=0]"
			[Register ("getProgressCallback", "()Lcom/alibaba/sdk/android/oss/callback/OSSProgressCallback;", "GetGetProgressCallbackHandler")]
			get {
				const string __id = "getProgressCallback.()Lcom/alibaba/sdk/android/oss/callback/OSSProgressCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='setProgressCallback' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.callback.OSSProgressCallback&lt;com.alibaba.sdk.android.oss.model.UploadPartRequest&gt;']]"
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

		static Delegate cb_getUploadId;
#pragma warning disable 0169
		static Delegate GetGetUploadIdHandler ()
		{
			if (cb_getUploadId == null)
				cb_getUploadId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUploadId);
			return cb_getUploadId;
		}

		static IntPtr n_GetUploadId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UploadId);
		}
#pragma warning restore 0169

		static Delegate cb_setUploadId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUploadId_Ljava_lang_String_Handler ()
		{
			if (cb_setUploadId_Ljava_lang_String_ == null)
				cb_setUploadId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUploadId_Ljava_lang_String_);
			return cb_setUploadId_Ljava_lang_String_;
		}

		static void n_SetUploadId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uploadId)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uploadId = JNIEnv.GetString (native_uploadId, JniHandleOwnership.DoNotTransfer);
			__this.UploadId = uploadId;
		}
#pragma warning restore 0169

		public virtual unsafe string UploadId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='getUploadId' and count(parameter)=0]"
			[Register ("getUploadId", "()Ljava/lang/String;", "GetGetUploadIdHandler")]
			get {
				const string __id = "getUploadId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='setUploadId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUploadId", "(Ljava/lang/String;)V", "GetSetUploadId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUploadId.(Ljava/lang/String;)V";
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

		static Delegate cb_getPartContent;
#pragma warning disable 0169
		static Delegate GetGetPartContentHandler ()
		{
			if (cb_getPartContent == null)
				cb_getPartContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPartContent);
			return cb_getPartContent;
		}

		static IntPtr n_GetPartContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPartContent ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='getPartContent' and count(parameter)=0]"
		[Register ("getPartContent", "()[B", "GetGetPartContentHandler")]
		public virtual unsafe byte[] GetPartContent ()
		{
			const string __id = "getPartContent.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setPartContent_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPartContent_arrayBHandler ()
		{
			if (cb_setPartContent_arrayB == null)
				cb_setPartContent_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPartContent_arrayB);
			return cb_setPartContent_arrayB;
		}

		static void n_SetPartContent_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_partContent)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] partContent = (byte[]) JNIEnv.GetArray (native_partContent, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPartContent (partContent);
			if (partContent != null)
				JNIEnv.CopyArray (partContent, native_partContent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='UploadPartRequest']/method[@name='setPartContent' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPartContent", "([B)V", "GetSetPartContent_arrayBHandler")]
		public virtual unsafe void SetPartContent (byte[] partContent)
		{
			const string __id = "setPartContent.([B)V";
			IntPtr native_partContent = JNIEnv.NewArray (partContent);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_partContent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (partContent != null) {
					JNIEnv.CopyArray (native_partContent, partContent);
					JNIEnv.DeleteLocalRef (native_partContent);
				}
			}
		}

	}
}
