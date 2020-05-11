using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CreateBucketRequest']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/CreateBucketRequest", DoNotGenerateAcw=true)]
	public partial class CreateBucketRequest : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/CreateBucketRequest", typeof (CreateBucketRequest));
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

		protected CreateBucketRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CreateBucketRequest']/constructor[@name='CreateBucketRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe CreateBucketRequest (string bucketName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bucketName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
			}
		}

		static Delegate cb_getBucketACL;
#pragma warning disable 0169
		static Delegate GetGetBucketACLHandler ()
		{
			if (cb_getBucketACL == null)
				cb_getBucketACL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBucketACL);
			return cb_getBucketACL;
		}

		static IntPtr n_GetBucketACL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BucketACL);
		}
#pragma warning restore 0169

		static Delegate cb_setBucketACL_Lcom_alibaba_sdk_android_oss_model_CannedAccessControlList_;
#pragma warning disable 0169
		static Delegate GetSetBucketACL_Lcom_alibaba_sdk_android_oss_model_CannedAccessControlList_Handler ()
		{
			if (cb_setBucketACL_Lcom_alibaba_sdk_android_oss_model_CannedAccessControlList_ == null)
				cb_setBucketACL_Lcom_alibaba_sdk_android_oss_model_CannedAccessControlList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBucketACL_Lcom_alibaba_sdk_android_oss_model_CannedAccessControlList_);
			return cb_setBucketACL_Lcom_alibaba_sdk_android_oss_model_CannedAccessControlList_;
		}

		static void n_SetBucketACL_Lcom_alibaba_sdk_android_oss_model_CannedAccessControlList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucketACL)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList bucketACL = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList> (native_bucketACL, JniHandleOwnership.DoNotTransfer);
			__this.BucketACL = bucketACL;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList BucketACL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CreateBucketRequest']/method[@name='getBucketACL' and count(parameter)=0]"
			[Register ("getBucketACL", "()Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;", "GetGetBucketACLHandler")]
			get {
				const string __id = "getBucketACL.()Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CreateBucketRequest']/method[@name='setBucketACL' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CannedAccessControlList']]"
			[Register ("setBucketACL", "(Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;)V", "GetSetBucketACL_Lcom_alibaba_sdk_android_oss_model_CannedAccessControlList_Handler")]
			set {
				const string __id = "setBucketACL.(Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBucketName;
#pragma warning disable 0169
		static Delegate GetGetBucketNameHandler ()
		{
			if (cb_getBucketName == null)
				cb_getBucketName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBucketName);
			return cb_getBucketName;
		}

		static IntPtr n_GetBucketName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BucketName);
		}
#pragma warning restore 0169

		static Delegate cb_setBucketName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBucketName_Ljava_lang_String_Handler ()
		{
			if (cb_setBucketName_Ljava_lang_String_ == null)
				cb_setBucketName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBucketName_Ljava_lang_String_);
			return cb_setBucketName_Ljava_lang_String_;
		}

		static void n_SetBucketName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucketName)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			__this.BucketName = bucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CreateBucketRequest']/method[@name='getBucketName' and count(parameter)=0]"
			[Register ("getBucketName", "()Ljava/lang/String;", "GetGetBucketNameHandler")]
			get {
				const string __id = "getBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CreateBucketRequest']/method[@name='setBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBucketName", "(Ljava/lang/String;)V", "GetSetBucketName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBucketName.(Ljava/lang/String;)V";
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

		static Delegate cb_getLocationConstraint;
#pragma warning disable 0169
		static Delegate GetGetLocationConstraintHandler ()
		{
			if (cb_getLocationConstraint == null)
				cb_getLocationConstraint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationConstraint);
			return cb_getLocationConstraint;
		}

		static IntPtr n_GetLocationConstraint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocationConstraint);
		}
#pragma warning restore 0169

		static Delegate cb_setLocationConstraint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLocationConstraint_Ljava_lang_String_Handler ()
		{
			if (cb_setLocationConstraint_Ljava_lang_String_ == null)
				cb_setLocationConstraint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocationConstraint_Ljava_lang_String_);
			return cb_setLocationConstraint_Ljava_lang_String_;
		}

		static void n_SetLocationConstraint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_locationConstraint)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string locationConstraint = JNIEnv.GetString (native_locationConstraint, JniHandleOwnership.DoNotTransfer);
			__this.LocationConstraint = locationConstraint;
		}
#pragma warning restore 0169

		public virtual unsafe string LocationConstraint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CreateBucketRequest']/method[@name='getLocationConstraint' and count(parameter)=0]"
			[Register ("getLocationConstraint", "()Ljava/lang/String;", "GetGetLocationConstraintHandler")]
			get {
				const string __id = "getLocationConstraint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CreateBucketRequest']/method[@name='setLocationConstraint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocationConstraint", "(Ljava/lang/String;)V", "GetSetLocationConstraint_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLocationConstraint.(Ljava/lang/String;)V";
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
