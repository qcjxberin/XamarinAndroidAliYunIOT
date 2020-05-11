using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='HeadObjectResult']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/HeadObjectResult", DoNotGenerateAcw=true)]
	public partial class HeadObjectResult : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/HeadObjectResult", typeof (HeadObjectResult));
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

		protected HeadObjectResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='HeadObjectResult']/constructor[@name='HeadObjectResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HeadObjectResult ()
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

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		static Delegate cb_setMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_;
#pragma warning disable 0169
		static Delegate GetSetMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_Handler ()
		{
			if (cb_setMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_ == null)
				cb_setMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_);
			return cb_setMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_;
		}

		static void n_SetMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_metadata)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata metadata = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (native_metadata, JniHandleOwnership.DoNotTransfer);
			__this.Metadata = metadata;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='HeadObjectResult']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;", "GetGetMetadataHandler")]
			get {
				const string __id = "getMetadata.()Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='HeadObjectResult']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ObjectMetadata']]"
			[Register ("setMetadata", "(Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V", "GetSetMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_Handler")]
			set {
				const string __id = "setMetadata.(Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
