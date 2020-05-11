using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Auth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/interface[@name='OSSCredentialProvider']"
	[Register ("com/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider", "", "Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProviderInvoker")]
	public partial interface IOSSCredentialProvider : IJavaObject, IJavaPeerable {

		global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken FederationToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/interface[@name='OSSCredentialProvider']/method[@name='getFederationToken' and count(parameter)=0]"
			[Register ("getFederationToken", "()Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;", "GetGetFederationTokenHandler:Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProviderInvoker, OssAndroidSdkBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider", DoNotGenerateAcw=true)]
	internal partial class IOSSCredentialProviderInvoker : global::Java.Lang.Object, IOSSCredentialProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider", typeof (IOSSCredentialProviderInvoker));

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

		public static IOSSCredentialProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOSSCredentialProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.oss.common.auth.OSSCredentialProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOSSCredentialProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FederationToken);
		}
#pragma warning restore 0169

		IntPtr id_getFederationToken;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken FederationToken {
			get {
				if (id_getFederationToken == IntPtr.Zero)
					id_getFederationToken = JNIEnv.GetMethodID (class_ref, "getFederationToken", "()Lcom/alibaba/sdk/android/oss/common/auth/OSSFederationToken;");
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.OSSFederationToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFederationToken), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
