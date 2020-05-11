using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationCredentialProvider']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/auth/OSSFederationCredentialProvider", DoNotGenerateAcw=true)]
	public abstract partial class OSSFederationCredentialProvider : global::Java.Lang.Object, global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/auth/OSSFederationCredentialProvider", typeof (OSSFederationCredentialProvider));
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

		protected OSSFederationCredentialProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationCredentialProvider']/constructor[@name='OSSFederationCredentialProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSSFederationCredentialProvider ()
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

		static Delegate cb_getCachedToken;
#pragma warning disable 0169
		static Delegate GetGetCachedTokenHandler ()
		{
			if (cb_getCachedToken == null)
				cb_getCachedToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedToken);
			return cb_getCachedToken;
		}

		static IntPtr n_GetCachedToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedToken);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken CachedToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationCredentialProvider']/method[@name='getCachedToken' and count(parameter)=0]"
			[Register ("getCachedToken", "()Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;", "GetGetCachedTokenHandler")]
			get {
				const string __id = "getCachedToken.()Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FederationToken);
		}
#pragma warning restore 0169

		public abstract global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken FederationToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationCredentialProvider']/method[@name='getFederationToken' and count(parameter)=0]"
			[Register ("getFederationToken", "()Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;", "GetGetFederationTokenHandler")] get;
		}

		static Delegate cb_getValidFederationToken;
#pragma warning disable 0169
		static Delegate GetGetValidFederationTokenHandler ()
		{
			if (cb_getValidFederationToken == null)
				cb_getValidFederationToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValidFederationToken);
			return cb_getValidFederationToken;
		}

		static IntPtr n_GetValidFederationToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValidFederationToken);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken ValidFederationToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationCredentialProvider']/method[@name='getValidFederationToken' and count(parameter)=0]"
			[Register ("getValidFederationToken", "()Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;", "GetGetValidFederationTokenHandler")]
			get {
				const string __id = "getValidFederationToken.()Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/auth/OSSFederationCredentialProvider", DoNotGenerateAcw=true)]
	internal partial class OSSFederationCredentialProviderInvoker : OSSFederationCredentialProvider {

		public OSSFederationCredentialProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/auth/OSSFederationCredentialProvider", typeof (OSSFederationCredentialProviderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken FederationToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='OSSFederationCredentialProvider']/method[@name='getFederationToken' and count(parameter)=0]"
			[Register ("getFederationToken", "()Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;", "GetGetFederationTokenHandler")]
			get {
				const string __id = "getFederationToken.()Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
