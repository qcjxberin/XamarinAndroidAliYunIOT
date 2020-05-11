using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest", DoNotGenerateAcw=true)]
	public partial class CompleteMultipartUploadRequest : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest", typeof (CompleteMultipartUploadRequest));
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

		protected CompleteMultipartUploadRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/constructor[@name='CompleteMultipartUploadRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;com.alibaba.sdk.android.oss.model.PartETag&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe CompleteMultipartUploadRequest (string bucketName, string objectKey, string uploadId, global::System.Collections.Generic.IList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag> partETags)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			IntPtr native_uploadId = JNIEnv.NewString (uploadId);
			IntPtr native_partETags = global::Android.Runtime.JavaList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag>.ToLocalJniHandle (partETags);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				__args [2] = new JniArgumentValue (native_uploadId);
				__args [3] = new JniArgumentValue (native_partETags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_objectKey);
				JNIEnv.DeleteLocalRef (native_uploadId);
				JNIEnv.DeleteLocalRef (native_partETags);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			__this.BucketName = bucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='getBucketName' and count(parameter)=0]"
			[Register ("getBucketName", "()Ljava/lang/String;", "GetGetBucketNameHandler")]
			get {
				const string __id = "getBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='setBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getCallbackParam;
#pragma warning disable 0169
		static Delegate GetGetCallbackParamHandler ()
		{
			if (cb_getCallbackParam == null)
				cb_getCallbackParam = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallbackParam);
			return cb_getCallbackParam;
		}

		static IntPtr n_GetCallbackParam (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CallbackParam);
		}
#pragma warning restore 0169

		static Delegate cb_setCallbackParam_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetCallbackParam_Ljava_util_Map_Handler ()
		{
			if (cb_setCallbackParam_Ljava_util_Map_ == null)
				cb_setCallbackParam_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallbackParam_Ljava_util_Map_);
			return cb_setCallbackParam_Ljava_util_Map_;
		}

		static void n_SetCallbackParam_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callbackParam)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var callbackParam = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_callbackParam, JniHandleOwnership.DoNotTransfer);
			__this.CallbackParam = callbackParam;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> CallbackParam {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='getCallbackParam' and count(parameter)=0]"
			[Register ("getCallbackParam", "()Ljava/util/Map;", "GetGetCallbackParamHandler")]
			get {
				const string __id = "getCallbackParam.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='setCallbackParam' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setCallbackParam", "(Ljava/util/Map;)V", "GetSetCallbackParam_Ljava_util_Map_Handler")]
			set {
				const string __id = "setCallbackParam.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCallbackVars;
#pragma warning disable 0169
		static Delegate GetGetCallbackVarsHandler ()
		{
			if (cb_getCallbackVars == null)
				cb_getCallbackVars = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallbackVars);
			return cb_getCallbackVars;
		}

		static IntPtr n_GetCallbackVars (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CallbackVars);
		}
#pragma warning restore 0169

		static Delegate cb_setCallbackVars_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetCallbackVars_Ljava_util_Map_Handler ()
		{
			if (cb_setCallbackVars_Ljava_util_Map_ == null)
				cb_setCallbackVars_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallbackVars_Ljava_util_Map_);
			return cb_setCallbackVars_Ljava_util_Map_;
		}

		static void n_SetCallbackVars_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callbackVars)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var callbackVars = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_callbackVars, JniHandleOwnership.DoNotTransfer);
			__this.CallbackVars = callbackVars;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> CallbackVars {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='getCallbackVars' and count(parameter)=0]"
			[Register ("getCallbackVars", "()Ljava/util/Map;", "GetGetCallbackVarsHandler")]
			get {
				const string __id = "getCallbackVars.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='setCallbackVars' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setCallbackVars", "(Ljava/util/Map;)V", "GetSetCallbackVars_Ljava_util_Map_Handler")]
			set {
				const string __id = "setCallbackVars.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata metadata = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (native_metadata, JniHandleOwnership.DoNotTransfer);
			__this.Metadata = metadata;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;", "GetGetMetadataHandler")]
			get {
				const string __id = "getMetadata.()Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ObjectMetadata']]"
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string objectKey = JNIEnv.GetString (native_objectKey, JniHandleOwnership.DoNotTransfer);
			__this.ObjectKey = objectKey;
		}
#pragma warning restore 0169

		public virtual unsafe string ObjectKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='getObjectKey' and count(parameter)=0]"
			[Register ("getObjectKey", "()Ljava/lang/String;", "GetGetObjectKeyHandler")]
			get {
				const string __id = "getObjectKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='setObjectKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getPartETags;
#pragma warning disable 0169
		static Delegate GetGetPartETagsHandler ()
		{
			if (cb_getPartETags == null)
				cb_getPartETags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPartETags);
			return cb_getPartETags;
		}

		static IntPtr n_GetPartETags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag>.ToLocalJniHandle (__this.PartETags);
		}
#pragma warning restore 0169

		static Delegate cb_setPartETags_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPartETags_Ljava_util_List_Handler ()
		{
			if (cb_setPartETags_Ljava_util_List_ == null)
				cb_setPartETags_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPartETags_Ljava_util_List_);
			return cb_setPartETags_Ljava_util_List_;
		}

		static void n_SetPartETags_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_partETags)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var partETags = global::Android.Runtime.JavaList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag>.FromJniHandle (native_partETags, JniHandleOwnership.DoNotTransfer);
			__this.PartETags = partETags;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag> PartETags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='getPartETags' and count(parameter)=0]"
			[Register ("getPartETags", "()Ljava/util/List;", "GetGetPartETagsHandler")]
			get {
				const string __id = "getPartETags.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='setPartETags' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.alibaba.sdk.android.oss.model.PartETag&gt;']]"
			[Register ("setPartETags", "(Ljava/util/List;)V", "GetSetPartETags_Ljava_util_List_Handler")]
			set {
				const string __id = "setPartETags.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uploadId = JNIEnv.GetString (native_uploadId, JniHandleOwnership.DoNotTransfer);
			__this.UploadId = uploadId;
		}
#pragma warning restore 0169

		public virtual unsafe string UploadId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='getUploadId' and count(parameter)=0]"
			[Register ("getUploadId", "()Ljava/lang/String;", "GetGetUploadIdHandler")]
			get {
				const string __id = "getUploadId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CompleteMultipartUploadRequest']/method[@name='setUploadId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
