using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSAuthCredentialsProvider']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/auth/OSSAuthCredentialsProvider", DoNotGenerateAcw=true)]
	public partial class OSSAuthCredentialsProvider : global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationCredentialProvider {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/interface[@name='OSSAuthCredentialsProvider.AuthDecoder']"
		[Register ("com/alibaba/sdk/android/oss/common/auth/OSSAuthCredentialsProvider$AuthDecoder", "", "Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider/IAuthDecoderInvoker")]
		public partial interface IAuthDecoder : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/interface[@name='OSSAuthCredentialsProvider.AuthDecoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("decode", "(Ljava/lang/String;)Ljava/lang/String;", "GetDecode_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider/IAuthDecoderInvoker, OssAndroidSdkBinding")]
			string Decode (string p0);

		}

		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/auth/OSSAuthCredentialsProvider$AuthDecoder", DoNotGenerateAcw=true)]
		internal partial class IAuthDecoderInvoker : global::Java.Lang.Object, IAuthDecoder {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/auth/OSSAuthCredentialsProvider$AuthDecoder", typeof (IAuthDecoderInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IAuthDecoder GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAuthDecoder> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.oss.common.auth.OSSAuthCredentialsProvider.AuthDecoder"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAuthDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_decode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDecode_Ljava_lang_String_Handler ()
			{
				if (cb_decode_Ljava_lang_String_ == null)
					cb_decode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_String_);
				return cb_decode_Ljava_lang_String_;
			}

			static IntPtr n_Decode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider.IAuthDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider.IAuthDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.Decode (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_decode_Ljava_lang_String_;
			public unsafe string Decode (string p0)
			{
				if (id_decode_Ljava_lang_String_ == IntPtr.Zero)
					id_decode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/auth/OSSAuthCredentialsProvider", typeof (OSSAuthCredentialsProvider));
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

		protected OSSAuthCredentialsProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSAuthCredentialsProvider']/constructor[@name='OSSAuthCredentialsProvider' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe OSSAuthCredentialsProvider (string authServerUrl)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_authServerUrl = JNIEnv.NewString (authServerUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_authServerUrl);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_authServerUrl);
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
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FederationToken);
		}
#pragma warning restore 0169

		public override unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken FederationToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSAuthCredentialsProvider']/method[@name='getFederationToken' and count(parameter)=0]"
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

		static Delegate cb_setAuthServerUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthServerUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthServerUrl_Ljava_lang_String_ == null)
				cb_setAuthServerUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthServerUrl_Ljava_lang_String_);
			return cb_setAuthServerUrl_Ljava_lang_String_;
		}

		static void n_SetAuthServerUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authServerUrl)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string authServerUrl = JNIEnv.GetString (native_authServerUrl, JniHandleOwnership.DoNotTransfer);
			__this.SetAuthServerUrl (authServerUrl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSAuthCredentialsProvider']/method[@name='setAuthServerUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAuthServerUrl", "(Ljava/lang/String;)V", "GetSetAuthServerUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAuthServerUrl (string authServerUrl)
		{
			const string __id = "setAuthServerUrl.(Ljava/lang/String;)V";
			IntPtr native_authServerUrl = JNIEnv.NewString (authServerUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_authServerUrl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_authServerUrl);
			}
		}

		static Delegate cb_setDecoder_Lcom_alibaba_sdk_android_oss_common_auth_OSSAuthCredentialsProvider_AuthDecoder_;
#pragma warning disable 0169
		static Delegate GetSetDecoder_Lcom_alibaba_sdk_android_oss_common_auth_OSSAuthCredentialsProvider_AuthDecoder_Handler ()
		{
			if (cb_setDecoder_Lcom_alibaba_sdk_android_oss_common_auth_OSSAuthCredentialsProvider_AuthDecoder_ == null)
				cb_setDecoder_Lcom_alibaba_sdk_android_oss_common_auth_OSSAuthCredentialsProvider_AuthDecoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDecoder_Lcom_alibaba_sdk_android_oss_common_auth_OSSAuthCredentialsProvider_AuthDecoder_);
			return cb_setDecoder_Lcom_alibaba_sdk_android_oss_common_auth_OSSAuthCredentialsProvider_AuthDecoder_;
		}

		static void n_SetDecoder_Lcom_alibaba_sdk_android_oss_common_auth_OSSAuthCredentialsProvider_AuthDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_decoder)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider.IAuthDecoder decoder = (global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider.IAuthDecoder)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider.IAuthDecoder> (native_decoder, JniHandleOwnership.DoNotTransfer);
			__this.SetDecoder (decoder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSAuthCredentialsProvider']/method[@name='setDecoder' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.common.auth.OSSAuthCredentialsProvider.AuthDecoder']]"
		[Register ("setDecoder", "(Lcom/alibaba/sdk/android/oss/common/auth/OSSAuthCredentialsProvider$AuthDecoder;)V", "GetSetDecoder_Lcom_alibaba_sdk_android_oss_common_auth_OSSAuthCredentialsProvider_AuthDecoder_Handler")]
		public virtual unsafe void SetDecoder (global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSAuthCredentialsProvider.IAuthDecoder decoder)
		{
			const string __id = "setDecoder.(Lcom/alibaba/sdk/android/oss/common/auth/OSSAuthCredentialsProvider$AuthDecoder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((decoder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) decoder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
