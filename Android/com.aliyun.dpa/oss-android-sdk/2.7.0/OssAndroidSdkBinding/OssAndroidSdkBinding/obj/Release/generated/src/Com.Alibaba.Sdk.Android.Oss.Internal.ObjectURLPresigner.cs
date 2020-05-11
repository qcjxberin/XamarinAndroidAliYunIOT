using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ObjectURLPresigner']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ObjectURLPresigner", DoNotGenerateAcw=true)]
	public partial class ObjectURLPresigner : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ObjectURLPresigner", typeof (ObjectURLPresigner));
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

		protected ObjectURLPresigner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ObjectURLPresigner']/constructor[@name='ObjectURLPresigner' and count(parameter)=3 and parameter[1][@type='java.net.URI'] and parameter[2][@type='com.alibaba.sdk.android.oss.common.auth.OSSCredentialProvider'] and parameter[3][@type='com.alibaba.sdk.android.oss.ClientConfiguration']]"
		[Register (".ctor", "(Ljava/net/URI;Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;Lcom/alibaba/sdk/android/oss/ClientConfiguration;)V", "")]
		public unsafe ObjectURLPresigner (global::Java.Net.URI endpoint, global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider credentialProvider, global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration conf)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URI;Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;Lcom/alibaba/sdk/android/oss/ClientConfiguration;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((endpoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endpoint).Handle);
				__args [1] = new JniArgumentValue ((credentialProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentialProvider).Handle);
				__args [2] = new JniArgumentValue ((conf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conf).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_presignConstrainedURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_;
#pragma warning disable 0169
		static Delegate GetPresignConstrainedURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_Handler ()
		{
			if (cb_presignConstrainedURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_ == null)
				cb_presignConstrainedURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PresignConstrainedURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_);
			return cb_presignConstrainedURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_;
		}

		static IntPtr n_PresignConstrainedURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ObjectURLPresigner __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ObjectURLPresigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest request = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PresignConstrainedURL (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ObjectURLPresigner']/method[@name='presignConstrainedURL' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GeneratePresignedUrlRequest']]"
		[Register ("presignConstrainedURL", "(Lcom/alibaba/sdk/android/oss/model/GeneratePresignedUrlRequest;)Ljava/lang/String;", "GetPresignConstrainedURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_Handler")]
		public virtual unsafe string PresignConstrainedURL (global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest request)
		{
			const string __id = "presignConstrainedURL.(Lcom/alibaba/sdk/android/oss/model/GeneratePresignedUrlRequest;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_presignConstrainedURL_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPresignConstrainedURL_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_presignConstrainedURL_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_presignConstrainedURL_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_PresignConstrainedURL_Ljava_lang_String_Ljava_lang_String_J);
			return cb_presignConstrainedURL_Ljava_lang_String_Ljava_lang_String_J;
		}

		static IntPtr n_PresignConstrainedURL_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_bucketName, IntPtr native_objectKey, long expiredTimeInSeconds)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ObjectURLPresigner __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ObjectURLPresigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			string objectKey = JNIEnv.GetString (native_objectKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PresignConstrainedURL (bucketName, objectKey, expiredTimeInSeconds));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ObjectURLPresigner']/method[@name='presignConstrainedURL' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("presignConstrainedURL", "(Ljava/lang/String;Ljava/lang/String;J)Ljava/lang/String;", "GetPresignConstrainedURL_Ljava_lang_String_Ljava_lang_String_JHandler")]
		public virtual unsafe string PresignConstrainedURL (string bucketName, string objectKey, long expiredTimeInSeconds)
		{
			const string __id = "presignConstrainedURL.(Ljava/lang/String;Ljava/lang/String;J)Ljava/lang/String;";
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

		static Delegate cb_presignPublicURL_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPresignPublicURL_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_presignPublicURL_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_presignPublicURL_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PresignPublicURL_Ljava_lang_String_Ljava_lang_String_);
			return cb_presignPublicURL_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_PresignPublicURL_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucketName, IntPtr native_objectKey)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ObjectURLPresigner __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ObjectURLPresigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			string objectKey = JNIEnv.GetString (native_objectKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PresignPublicURL (bucketName, objectKey));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ObjectURLPresigner']/method[@name='presignPublicURL' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("presignPublicURL", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetPresignPublicURL_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string PresignPublicURL (string bucketName, string objectKey)
		{
			const string __id = "presignPublicURL.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
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

	}
}
