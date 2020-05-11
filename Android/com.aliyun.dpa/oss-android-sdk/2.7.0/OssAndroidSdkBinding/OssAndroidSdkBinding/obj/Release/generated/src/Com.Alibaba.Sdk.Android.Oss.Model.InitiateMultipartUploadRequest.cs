using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='InitiateMultipartUploadRequest']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/InitiateMultipartUploadRequest", DoNotGenerateAcw=true)]
	public partial class InitiateMultipartUploadRequest : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='InitiateMultipartUploadRequest']/field[@name='isSequential']"
		[Register ("isSequential")]
		public bool IsSequential {
			get {
				const string __id = "isSequential.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isSequential.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/InitiateMultipartUploadRequest", typeof (InitiateMultipartUploadRequest));
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

		protected InitiateMultipartUploadRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='InitiateMultipartUploadRequest']/constructor[@name='InitiateMultipartUploadRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe InitiateMultipartUploadRequest (string bucketName, string objectKey)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='InitiateMultipartUploadRequest']/constructor[@name='InitiateMultipartUploadRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.sdk.android.oss.model.ObjectMetadata']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V", "")]
		public unsafe InitiateMultipartUploadRequest (string bucketName, string objectKey, global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata metadata)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				__args [2] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			__this.BucketName = bucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='InitiateMultipartUploadRequest']/method[@name='getBucketName' and count(parameter)=0]"
			[Register ("getBucketName", "()Ljava/lang/String;", "GetGetBucketNameHandler")]
			get {
				const string __id = "getBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='InitiateMultipartUploadRequest']/method[@name='setBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		static Delegate cb_setMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_;
#pragma warning disable 0169
		static Delegate GetSetMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_Handler ()
		{
			if (cb_setMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_ == null)
				cb_setMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_);
			return cb_setMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_;
		}

		static void n_SetMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_metadata)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata metadata = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (native_metadata, JniHandleOwnership.DoNotTransfer);
			__this.Metadata = metadata;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='InitiateMultipartUploadRequest']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;", "GetGetMetadataHandler")]
			get {
				const string __id = "getMetadata.()Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='InitiateMultipartUploadRequest']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ObjectMetadata']]"
			[Register ("setMetadata", "(Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V", "GetSetMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_Handler")]
			set {
				const string __id = "setMetadata.(Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string objectKey = JNIEnv.GetString (native_objectKey, JniHandleOwnership.DoNotTransfer);
			__this.ObjectKey = objectKey;
		}
#pragma warning restore 0169

		public virtual unsafe string ObjectKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='InitiateMultipartUploadRequest']/method[@name='getObjectKey' and count(parameter)=0]"
			[Register ("getObjectKey", "()Ljava/lang/String;", "GetGetObjectKeyHandler")]
			get {
				const string __id = "getObjectKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='InitiateMultipartUploadRequest']/method[@name='setObjectKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
