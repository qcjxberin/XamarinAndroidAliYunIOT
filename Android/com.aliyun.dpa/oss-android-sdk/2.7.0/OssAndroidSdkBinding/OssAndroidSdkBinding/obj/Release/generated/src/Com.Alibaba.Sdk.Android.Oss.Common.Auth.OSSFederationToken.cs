using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationToken']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/auth/OSSFederationToken", DoNotGenerateAcw=true)]
	public partial class OSSFederationToken : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/auth/OSSFederationToken", typeof (OSSFederationToken));
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

		protected OSSFederationToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationToken']/constructor[@name='OSSFederationToken' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe OSSFederationToken (string tempAK, string tempSK, string securityToken, string expirationInGMTFormat)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tempAK = JNIEnv.NewString (tempAK);
			IntPtr native_tempSK = JNIEnv.NewString (tempSK);
			IntPtr native_securityToken = JNIEnv.NewString (securityToken);
			IntPtr native_expirationInGMTFormat = JNIEnv.NewString (expirationInGMTFormat);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_tempAK);
				__args [1] = new JniArgumentValue (native_tempSK);
				__args [2] = new JniArgumentValue (native_securityToken);
				__args [3] = new JniArgumentValue (native_expirationInGMTFormat);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tempAK);
				JNIEnv.DeleteLocalRef (native_tempSK);
				JNIEnv.DeleteLocalRef (native_securityToken);
				JNIEnv.DeleteLocalRef (native_expirationInGMTFormat);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationToken']/constructor[@name='OSSFederationToken' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", "")]
		public unsafe OSSFederationToken (string tempAK, string tempSK, string securityToken, long expiration)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tempAK = JNIEnv.NewString (tempAK);
			IntPtr native_tempSK = JNIEnv.NewString (tempSK);
			IntPtr native_securityToken = JNIEnv.NewString (securityToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_tempAK);
				__args [1] = new JniArgumentValue (native_tempSK);
				__args [2] = new JniArgumentValue (native_securityToken);
				__args [3] = new JniArgumentValue (expiration);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tempAK);
				JNIEnv.DeleteLocalRef (native_tempSK);
				JNIEnv.DeleteLocalRef (native_securityToken);
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
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Expiration = expiration;
		}
#pragma warning restore 0169

		public virtual unsafe long Expiration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationToken']/method[@name='getExpiration' and count(parameter)=0]"
			[Register ("getExpiration", "()J", "GetGetExpirationHandler")]
			get {
				const string __id = "getExpiration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationToken']/method[@name='setExpiration' and count(parameter)=1 and parameter[1][@type='long']]"
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
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string securityToken = JNIEnv.GetString (native_securityToken, JniHandleOwnership.DoNotTransfer);
			__this.SecurityToken = securityToken;
		}
#pragma warning restore 0169

		public virtual unsafe string SecurityToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationToken']/method[@name='getSecurityToken' and count(parameter)=0]"
			[Register ("getSecurityToken", "()Ljava/lang/String;", "GetGetSecurityTokenHandler")]
			get {
				const string __id = "getSecurityToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationToken']/method[@name='setSecurityToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getTempAK;
#pragma warning disable 0169
		static Delegate GetGetTempAKHandler ()
		{
			if (cb_getTempAK == null)
				cb_getTempAK = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTempAK);
			return cb_getTempAK;
		}

		static IntPtr n_GetTempAK (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TempAK);
		}
#pragma warning restore 0169

		public virtual unsafe string TempAK {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationToken']/method[@name='getTempAK' and count(parameter)=0]"
			[Register ("getTempAK", "()Ljava/lang/String;", "GetGetTempAKHandler")]
			get {
				const string __id = "getTempAK.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTempSK;
#pragma warning disable 0169
		static Delegate GetGetTempSKHandler ()
		{
			if (cb_getTempSK == null)
				cb_getTempSK = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTempSK);
			return cb_getTempSK;
		}

		static IntPtr n_GetTempSK (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TempSK);
		}
#pragma warning restore 0169

		public virtual unsafe string TempSK {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationToken']/method[@name='getTempSK' and count(parameter)=0]"
			[Register ("getTempSK", "()Ljava/lang/String;", "GetGetTempSKHandler")]
			get {
				const string __id = "getTempSK.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setExpirationInGMTFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExpirationInGMTFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setExpirationInGMTFormat_Ljava_lang_String_ == null)
				cb_setExpirationInGMTFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpirationInGMTFormat_Ljava_lang_String_);
			return cb_setExpirationInGMTFormat_Ljava_lang_String_;
		}

		static void n_SetExpirationInGMTFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_expirationInGMTFormat)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string expirationInGMTFormat = JNIEnv.GetString (native_expirationInGMTFormat, JniHandleOwnership.DoNotTransfer);
			__this.SetExpirationInGMTFormat (expirationInGMTFormat);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationToken']/method[@name='setExpirationInGMTFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setExpirationInGMTFormat", "(Ljava/lang/String;)V", "GetSetExpirationInGMTFormat_Ljava_lang_String_Handler")]
		public virtual unsafe void SetExpirationInGMTFormat (string expirationInGMTFormat)
		{
			const string __id = "setExpirationInGMTFormat.(Ljava/lang/String;)V";
			IntPtr native_expirationInGMTFormat = JNIEnv.NewString (expirationInGMTFormat);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_expirationInGMTFormat);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_expirationInGMTFormat);
			}
		}

		static Delegate cb_setTempAk_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTempAk_Ljava_lang_String_Handler ()
		{
			if (cb_setTempAk_Ljava_lang_String_ == null)
				cb_setTempAk_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTempAk_Ljava_lang_String_);
			return cb_setTempAk_Ljava_lang_String_;
		}

		static void n_SetTempAk_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tempAk)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tempAk = JNIEnv.GetString (native_tempAk, JniHandleOwnership.DoNotTransfer);
			__this.SetTempAk (tempAk);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationToken']/method[@name='setTempAk' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTempAk", "(Ljava/lang/String;)V", "GetSetTempAk_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTempAk (string tempAk)
		{
			const string __id = "setTempAk.(Ljava/lang/String;)V";
			IntPtr native_tempAk = JNIEnv.NewString (tempAk);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tempAk);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tempAk);
			}
		}

		static Delegate cb_setTempSk_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTempSk_Ljava_lang_String_Handler ()
		{
			if (cb_setTempSk_Ljava_lang_String_ == null)
				cb_setTempSk_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTempSk_Ljava_lang_String_);
			return cb_setTempSk_Ljava_lang_String_;
		}

		static void n_SetTempSk_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tempSk)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tempSk = JNIEnv.GetString (native_tempSk, JniHandleOwnership.DoNotTransfer);
			__this.SetTempSk (tempSk);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationToken']/method[@name='setTempSk' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTempSk", "(Ljava/lang/String;)V", "GetSetTempSk_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTempSk (string tempSk)
		{
			const string __id = "setTempSk.(Ljava/lang/String;)V";
			IntPtr native_tempSk = JNIEnv.NewString (tempSk);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tempSk);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tempSk);
			}
		}

	}
}
