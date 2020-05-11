using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='HmacSHA1Signature']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/auth/HmacSHA1Signature", DoNotGenerateAcw=true)]
	public partial class HmacSHA1Signature : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/auth/HmacSHA1Signature", typeof (HmacSHA1Signature));
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

		protected HmacSHA1Signature (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='HmacSHA1Signature']/constructor[@name='HmacSHA1Signature' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HmacSHA1Signature ()
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

		static Delegate cb_getAlgorithm;
#pragma warning disable 0169
		static Delegate GetGetAlgorithmHandler ()
		{
			if (cb_getAlgorithm == null)
				cb_getAlgorithm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlgorithm);
			return cb_getAlgorithm;
		}

		static IntPtr n_GetAlgorithm (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.HmacSHA1Signature __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.HmacSHA1Signature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Algorithm);
		}
#pragma warning restore 0169

		public virtual unsafe string Algorithm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='HmacSHA1Signature']/method[@name='getAlgorithm' and count(parameter)=0]"
			[Register ("getAlgorithm", "()Ljava/lang/String;", "GetGetAlgorithmHandler")]
			get {
				const string __id = "getAlgorithm.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.HmacSHA1Signature __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.HmacSHA1Signature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='HmacSHA1Signature']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_computeSignature_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetComputeSignature_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_computeSignature_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_computeSignature_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ComputeSignature_Ljava_lang_String_Ljava_lang_String_);
			return cb_computeSignature_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ComputeSignature_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_data)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.HmacSHA1Signature __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.HmacSHA1Signature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string data = JNIEnv.GetString (native_data, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ComputeSignature (key, data));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.auth']/class[@name='HmacSHA1Signature']/method[@name='computeSignature' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("computeSignature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetComputeSignature_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string ComputeSignature (string key, string data)
		{
			const string __id = "computeSignature.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

	}
}
