using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/GeneratePresignedUrlRequest", DoNotGenerateAcw=true)]
	public partial class GeneratePresignedUrlRequest : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/GeneratePresignedUrlRequest", typeof (GeneratePresignedUrlRequest));
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

		protected GeneratePresignedUrlRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/constructor[@name='GeneratePresignedUrlRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GeneratePresignedUrlRequest (string bucketName, string key)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_key);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/constructor[@name='GeneratePresignedUrlRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;J)V", "")]
		public unsafe GeneratePresignedUrlRequest (string bucketName, string key, long expiration)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (expiration);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/constructor[@name='GeneratePresignedUrlRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='com.alibaba.sdk.android.oss.common.HttpMethod']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;JLcom/alibaba/sdk/android/oss/common/HttpMethod;)V", "")]
		public unsafe GeneratePresignedUrlRequest (string bucketName, string key, long expiration, global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod method)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;JLcom/alibaba/sdk/android/oss/common/HttpMethod;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (expiration);
				__args [3] = new JniArgumentValue ((method == null) ? IntPtr.Zero : ((global::Java.Lang.Object) method).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_key);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			__this.BucketName = bucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='getBucketName' and count(parameter)=0]"
			[Register ("getBucketName", "()Ljava/lang/String;", "GetGetBucketNameHandler")]
			get {
				const string __id = "getBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='setBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getContentMD5;
#pragma warning disable 0169
		static Delegate GetGetContentMD5Handler ()
		{
			if (cb_getContentMD5 == null)
				cb_getContentMD5 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentMD5);
			return cb_getContentMD5;
		}

		static IntPtr n_GetContentMD5 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentMD5);
		}
#pragma warning restore 0169

		static Delegate cb_setContentMD5_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentMD5_Ljava_lang_String_Handler ()
		{
			if (cb_setContentMD5_Ljava_lang_String_ == null)
				cb_setContentMD5_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentMD5_Ljava_lang_String_);
			return cb_setContentMD5_Ljava_lang_String_;
		}

		static void n_SetContentMD5_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contentMD5)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string contentMD5 = JNIEnv.GetString (native_contentMD5, JniHandleOwnership.DoNotTransfer);
			__this.ContentMD5 = contentMD5;
		}
#pragma warning restore 0169

		public virtual unsafe string ContentMD5 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='getContentMD5' and count(parameter)=0]"
			[Register ("getContentMD5", "()Ljava/lang/String;", "GetGetContentMD5Handler")]
			get {
				const string __id = "getContentMD5.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='setContentMD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentMD5", "(Ljava/lang/String;)V", "GetSetContentMD5_Ljava_lang_String_Handler")]
			set {
				const string __id = "setContentMD5.(Ljava/lang/String;)V";
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

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		static Delegate cb_setContentType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentType_Ljava_lang_String_Handler ()
		{
			if (cb_setContentType_Ljava_lang_String_ == null)
				cb_setContentType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentType_Ljava_lang_String_);
			return cb_setContentType_Ljava_lang_String_;
		}

		static void n_SetContentType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contentType)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string contentType = JNIEnv.GetString (native_contentType, JniHandleOwnership.DoNotTransfer);
			__this.ContentType = contentType;
		}
#pragma warning restore 0169

		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				const string __id = "getContentType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentType", "(Ljava/lang/String;)V", "GetSetContentType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setContentType.(Ljava/lang/String;)V";
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

		static Delegate cb_getExpiration;
#pragma warning disable 0169
		static Delegate GetGetExpirationHandler ()
		{
			if (cb_getExpiration == null)
				cb_getExpiration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExpiration);
			return cb_getExpiration;
		}

		static long n_GetExpiration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Expiration;
		}
#pragma warning restore 0169

		static Delegate cb_setExpiration_J;
#pragma warning disable 0169
		static Delegate GetSetExpiration_JHandler ()
		{
			if (cb_setExpiration_J == null)
				cb_setExpiration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetExpiration_J);
			return cb_setExpiration_J;
		}

		static void n_SetExpiration_J (IntPtr jnienv, IntPtr native__this, long expiration)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Expiration = expiration;
		}
#pragma warning restore 0169

		public virtual unsafe long Expiration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='getExpiration' and count(parameter)=0]"
			[Register ("getExpiration", "()J", "GetGetExpirationHandler")]
			get {
				const string __id = "getExpiration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='setExpiration' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setExpiration", "(J)V", "GetSetExpiration_JHandler")]
			set {
				const string __id = "setExpiration.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		static Delegate cb_setKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKey_Ljava_lang_String_Handler ()
		{
			if (cb_setKey_Ljava_lang_String_ == null)
				cb_setKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKey_Ljava_lang_String_);
			return cb_setKey_Ljava_lang_String_;
		}

		static void n_SetKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Key = key;
		}
#pragma warning restore 0169

		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				const string __id = "getKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='setKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKey", "(Ljava/lang/String;)V", "GetSetKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setKey.(Ljava/lang/String;)V";
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

		static Delegate cb_getMethod;
#pragma warning disable 0169
		static Delegate GetGetMethodHandler ()
		{
			if (cb_getMethod == null)
				cb_getMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethod);
			return cb_getMethod;
		}

		static IntPtr n_GetMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Method);
		}
#pragma warning restore 0169

		static Delegate cb_setMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_;
#pragma warning disable 0169
		static Delegate GetSetMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_Handler ()
		{
			if (cb_setMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_ == null)
				cb_setMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_);
			return cb_setMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_;
		}

		static void n_SetMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_method)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod method = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod> (native_method, JniHandleOwnership.DoNotTransfer);
			__this.Method = method;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()Lcom/alibaba/sdk/android/oss/common/HttpMethod;", "GetGetMethodHandler")]
			get {
				const string __id = "getMethod.()Lcom/alibaba/sdk/android/oss/common/HttpMethod;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='setMethod' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.common.HttpMethod']]"
			[Register ("setMethod", "(Lcom/alibaba/sdk/android/oss/common/HttpMethod;)V", "GetSetMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_Handler")]
			set {
				const string __id = "setMethod.(Lcom/alibaba/sdk/android/oss/common/HttpMethod;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProcess;
#pragma warning disable 0169
		static Delegate GetGetProcessHandler ()
		{
			if (cb_getProcess == null)
				cb_getProcess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProcess);
			return cb_getProcess;
		}

		static IntPtr n_GetProcess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Process);
		}
#pragma warning restore 0169

		static Delegate cb_setProcess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProcess_Ljava_lang_String_Handler ()
		{
			if (cb_setProcess_Ljava_lang_String_ == null)
				cb_setProcess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProcess_Ljava_lang_String_);
			return cb_setProcess_Ljava_lang_String_;
		}

		static void n_SetProcess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_process)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string process = JNIEnv.GetString (native_process, JniHandleOwnership.DoNotTransfer);
			__this.Process = process;
		}
#pragma warning restore 0169

		public virtual unsafe string Process {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='getProcess' and count(parameter)=0]"
			[Register ("getProcess", "()Ljava/lang/String;", "GetGetProcessHandler")]
			get {
				const string __id = "getProcess.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='setProcess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProcess", "(Ljava/lang/String;)V", "GetSetProcess_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProcess.(Ljava/lang/String;)V";
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

		static Delegate cb_getQueryParameter;
#pragma warning disable 0169
		static Delegate GetGetQueryParameterHandler ()
		{
			if (cb_getQueryParameter == null)
				cb_getQueryParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQueryParameter);
			return cb_getQueryParameter;
		}

		static IntPtr n_GetQueryParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.QueryParameter);
		}
#pragma warning restore 0169

		static Delegate cb_setQueryParameter_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetQueryParameter_Ljava_util_Map_Handler ()
		{
			if (cb_setQueryParameter_Ljava_util_Map_ == null)
				cb_setQueryParameter_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetQueryParameter_Ljava_util_Map_);
			return cb_setQueryParameter_Ljava_util_Map_;
		}

		static void n_SetQueryParameter_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_queryParam)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var queryParam = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_queryParam, JniHandleOwnership.DoNotTransfer);
			__this.QueryParameter = queryParam;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> QueryParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='getQueryParameter' and count(parameter)=0]"
			[Register ("getQueryParameter", "()Ljava/util/Map;", "GetGetQueryParameterHandler")]
			get {
				const string __id = "getQueryParameter.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='setQueryParameter' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setQueryParameter", "(Ljava/util/Map;)V", "GetSetQueryParameter_Ljava_util_Map_Handler")]
			set {
				const string __id = "setQueryParameter.(Ljava/util/Map;)V";
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

		static Delegate cb_addQueryParameter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddQueryParameter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addQueryParameter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addQueryParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddQueryParameter_Ljava_lang_String_Ljava_lang_String_);
			return cb_addQueryParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddQueryParameter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AddQueryParameter (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GeneratePresignedUrlRequest']/method[@name='addQueryParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddQueryParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddQueryParameter (string key, string value)
		{
			const string __id = "addQueryParameter.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
