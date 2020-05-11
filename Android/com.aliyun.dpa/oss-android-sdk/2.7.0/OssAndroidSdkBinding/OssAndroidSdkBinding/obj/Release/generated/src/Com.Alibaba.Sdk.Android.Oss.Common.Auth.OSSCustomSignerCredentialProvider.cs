using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSCustomSignerCredentialProvider']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/auth/OSSCustomSignerCredentialProvider", DoNotGenerateAcw=true)]
	public abstract partial class OSSCustomSignerCredentialProvider : global::Java.Lang.Object, global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/auth/OSSCustomSignerCredentialProvider", typeof (OSSCustomSignerCredentialProvider));
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

		protected OSSCustomSignerCredentialProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSCustomSignerCredentialProvider']/constructor[@name='OSSCustomSignerCredentialProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSSCustomSignerCredentialProvider ()
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
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSCustomSignerCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSCustomSignerCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FederationToken);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken FederationToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSCustomSignerCredentialProvider']/method[@name='getFederationToken' and count(parameter)=0]"
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

		static Delegate cb_signContent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSignContent_Ljava_lang_String_Handler ()
		{
			if (cb_signContent_Ljava_lang_String_ == null)
				cb_signContent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SignContent_Ljava_lang_String_);
			return cb_signContent_Ljava_lang_String_;
		}

		static IntPtr n_SignContent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSCustomSignerCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSCustomSignerCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SignContent (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSCustomSignerCredentialProvider']/method[@name='signContent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("signContent", "(Ljava/lang/String;)Ljava/lang/String;", "GetSignContent_Ljava_lang_String_Handler")]
		public abstract string SignContent (string p0);

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/auth/OSSCustomSignerCredentialProvider", DoNotGenerateAcw=true)]
	internal partial class OSSCustomSignerCredentialProviderInvoker : OSSCustomSignerCredentialProvider {

		public OSSCustomSignerCredentialProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/auth/OSSCustomSignerCredentialProvider", typeof (OSSCustomSignerCredentialProviderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSCustomSignerCredentialProvider']/method[@name='signContent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("signContent", "(Ljava/lang/String;)Ljava/lang/String;", "GetSignContent_Ljava_lang_String_Handler")]
		public override unsafe string SignContent (string p0)
		{
			const string __id = "signContent.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
