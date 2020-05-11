using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSStsTokenCredentialProvider']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/auth/OSSStsTokenCredentialProvider", DoNotGenerateAcw=true)]
	public partial class OSSStsTokenCredentialProvider : global::Java.Lang.Object, global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/auth/OSSStsTokenCredentialProvider", typeof (OSSStsTokenCredentialProvider));
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

		protected OSSStsTokenCredentialProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSStsTokenCredentialProvider']/constructor[@name='OSSStsTokenCredentialProvider' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.common.auth.OSSFederationToken']]"
		[Register (".ctor", "(Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;)V", "")]
		public unsafe OSSStsTokenCredentialProvider (global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken token)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSStsTokenCredentialProvider']/constructor[@name='OSSStsTokenCredentialProvider' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe OSSStsTokenCredentialProvider (string accessKeyId, string secretKeyId, string securityToken)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_accessKeyId = JNIEnv.NewString (accessKeyId);
			IntPtr native_secretKeyId = JNIEnv.NewString (secretKeyId);
			IntPtr native_securityToken = JNIEnv.NewString (securityToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_accessKeyId);
				__args [1] = new JniArgumentValue (native_secretKeyId);
				__args [2] = new JniArgumentValue (native_securityToken);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_accessKeyId);
				JNIEnv.DeleteLocalRef (native_secretKeyId);
				JNIEnv.DeleteLocalRef (native_securityToken);
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
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string accessKeyId = JNIEnv.GetString (native_accessKeyId, JniHandleOwnership.DoNotTransfer);
			__this.AccessKeyId = accessKeyId;
		}
#pragma warning restore 0169

		public virtual unsafe string AccessKeyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSStsTokenCredentialProvider']/method[@name='getAccessKeyId' and count(parameter)=0]"
			[Register ("getAccessKeyId", "()Ljava/lang/String;", "GetGetAccessKeyIdHandler")]
			get {
				const string __id = "getAccessKeyId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSStsTokenCredentialProvider']/method[@name='setAccessKeyId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FederationToken);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken FederationToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSStsTokenCredentialProvider']/method[@name='getFederationToken' and count(parameter)=0]"
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

		static Delegate cb_getSecretKeyId;
#pragma warning disable 0169
		static Delegate GetGetSecretKeyIdHandler ()
		{
			if (cb_getSecretKeyId == null)
				cb_getSecretKeyId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecretKeyId);
			return cb_getSecretKeyId;
		}

		static IntPtr n_GetSecretKeyId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecretKeyId);
		}
#pragma warning restore 0169

		static Delegate cb_setSecretKeyId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecretKeyId_Ljava_lang_String_Handler ()
		{
			if (cb_setSecretKeyId_Ljava_lang_String_ == null)
				cb_setSecretKeyId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecretKeyId_Ljava_lang_String_);
			return cb_setSecretKeyId_Ljava_lang_String_;
		}

		static void n_SetSecretKeyId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_secretKeyId)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string secretKeyId = JNIEnv.GetString (native_secretKeyId, JniHandleOwnership.DoNotTransfer);
			__this.SecretKeyId = secretKeyId;
		}
#pragma warning restore 0169

		public virtual unsafe string SecretKeyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSStsTokenCredentialProvider']/method[@name='getSecretKeyId' and count(parameter)=0]"
			[Register ("getSecretKeyId", "()Ljava/lang/String;", "GetGetSecretKeyIdHandler")]
			get {
				const string __id = "getSecretKeyId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSStsTokenCredentialProvider']/method[@name='setSecretKeyId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecretKeyId", "(Ljava/lang/String;)V", "GetSetSecretKeyId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSecretKeyId.(Ljava/lang/String;)V";
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

		static Delegate cb_getSecurityToken;
#pragma warning disable 0169
		static Delegate GetGetSecurityTokenHandler ()
		{
			if (cb_getSecurityToken == null)
				cb_getSecurityToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecurityToken);
			return cb_getSecurityToken;
		}

		static IntPtr n_GetSecurityToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecurityToken);
		}
#pragma warning restore 0169

		static Delegate cb_setSecurityToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecurityToken_Ljava_lang_String_Handler ()
		{
			if (cb_setSecurityToken_Ljava_lang_String_ == null)
				cb_setSecurityToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecurityToken_Ljava_lang_String_);
			return cb_setSecurityToken_Ljava_lang_String_;
		}

		static void n_SetSecurityToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_securityToken)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSStsTokenCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string securityToken = JNIEnv.GetString (native_securityToken, JniHandleOwnership.DoNotTransfer);
			__this.SecurityToken = securityToken;
		}
#pragma warning restore 0169

		public virtual unsafe string SecurityToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSStsTokenCredentialProvider']/method[@name='getSecurityToken' and count(parameter)=0]"
			[Register ("getSecurityToken", "()Ljava/lang/String;", "GetGetSecurityTokenHandler")]
			get {
				const string __id = "getSecurityToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSStsTokenCredentialProvider']/method[@name='setSecurityToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecurityToken", "(Ljava/lang/String;)V", "GetSetSecurityToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSecurityToken.(Ljava/lang/String;)V";
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
