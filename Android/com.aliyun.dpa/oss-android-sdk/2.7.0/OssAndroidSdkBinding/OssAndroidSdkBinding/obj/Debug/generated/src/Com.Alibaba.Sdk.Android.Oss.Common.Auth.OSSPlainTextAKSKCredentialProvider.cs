using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSPlainTextAKSKCredentialProvider']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/auth/OSSPlainTextAKSKCredentialProvider", DoNotGenerateAcw=true)]
	public partial class OSSPlainTextAKSKCredentialProvider : global::Java.Lang.Object, global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/auth/OSSPlainTextAKSKCredentialProvider", typeof (OSSPlainTextAKSKCredentialProvider));
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

		protected OSSPlainTextAKSKCredentialProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSPlainTextAKSKCredentialProvider']/constructor[@name='OSSPlainTextAKSKCredentialProvider' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe OSSPlainTextAKSKCredentialProvider (string accessKeyId, string accessKeySecret)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_accessKeyId = JNIEnv.NewString (accessKeyId);
			IntPtr native_accessKeySecret = JNIEnv.NewString (accessKeySecret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_accessKeyId);
				__args [1] = new JniArgumentValue (native_accessKeySecret);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_accessKeyId);
				JNIEnv.DeleteLocalRef (native_accessKeySecret);
			}
		}

		static Delegate cb_getAccessKeyId;
#pragma warning disable 0169
		static Delegate GetGetAccessKeyIdHandler ()
		{
			if (cb_getAccessKeyId == null)
				cb_getAccessKeyId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessKeyId);
			return cb_getAccessKeyId;
		}

		static IntPtr n_GetAccessKeyId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSPlainTextAKSKCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSPlainTextAKSKCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessKeyId);
		}
#pragma warning restore 0169

		static Delegate cb_setAccessKeyId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessKeyId_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessKeyId_Ljava_lang_String_ == null)
				cb_setAccessKeyId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccessKeyId_Ljava_lang_String_);
			return cb_setAccessKeyId_Ljava_lang_String_;
		}

		static void n_SetAccessKeyId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accessKeyId)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSPlainTextAKSKCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSPlainTextAKSKCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string accessKeyId = JNIEnv.GetString (native_accessKeyId, JniHandleOwnership.DoNotTransfer);
			__this.AccessKeyId = accessKeyId;
		}
#pragma warning restore 0169

		public virtual unsafe string AccessKeyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSPlainTextAKSKCredentialProvider']/method[@name='getAccessKeyId' and count(parameter)=0]"
			[Register ("getAccessKeyId", "()Ljava/lang/String;", "GetGetAccessKeyIdHandler")]
			get {
				const string __id = "getAccessKeyId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSPlainTextAKSKCredentialProvider']/method[@name='setAccessKeyId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessKeyId", "(Ljava/lang/String;)V", "GetSetAccessKeyId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccessKeyId.(Ljava/lang/String;)V";
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

		static Delegate cb_getAccessKeySecret;
#pragma warning disable 0169
		static Delegate GetGetAccessKeySecretHandler ()
		{
			if (cb_getAccessKeySecret == null)
				cb_getAccessKeySecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessKeySecret);
			return cb_getAccessKeySecret;
		}

		static IntPtr n_GetAccessKeySecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSPlainTextAKSKCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSPlainTextAKSKCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessKeySecret);
		}
#pragma warning restore 0169

		static Delegate cb_setAccessKeySecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessKeySecret_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessKeySecret_Ljava_lang_String_ == null)
				cb_setAccessKeySecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccessKeySecret_Ljava_lang_String_);
			return cb_setAccessKeySecret_Ljava_lang_String_;
		}

		static void n_SetAccessKeySecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accessKeySecret)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSPlainTextAKSKCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSPlainTextAKSKCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string accessKeySecret = JNIEnv.GetString (native_accessKeySecret, JniHandleOwnership.DoNotTransfer);
			__this.AccessKeySecret = accessKeySecret;
		}
#pragma warning restore 0169

		public virtual unsafe string AccessKeySecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSPlainTextAKSKCredentialProvider']/method[@name='getAccessKeySecret' and count(parameter)=0]"
			[Register ("getAccessKeySecret", "()Ljava/lang/String;", "GetGetAccessKeySecretHandler")]
			get {
				const string __id = "getAccessKeySecret.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSPlainTextAKSKCredentialProvider']/method[@name='setAccessKeySecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessKeySecret", "(Ljava/lang/String;)V", "GetSetAccessKeySecret_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccessKeySecret.(Ljava/lang/String;)V";
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

		static Delegate cb_getFederationToken;
#pragma warning disable 0169
		static Delegate GetGetFederationTokenHandler ()
		{
			if (cb_getFederationToken == null)
				cb_getFederationToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFederationToken);
			return cb_getFederationToken;
		}

		static IntPtr n_GetFederationToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSPlainTextAKSKCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSPlainTextAKSKCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FederationToken);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken FederationToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSPlainTextAKSKCredentialProvider']/method[@name='getFederationToken' and count(parameter)=0]"
			[Register ("getFederationToken", "()Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;", "GetGetFederationTokenHandler")]
			get {
				const string __id = "getFederationToken.()Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
