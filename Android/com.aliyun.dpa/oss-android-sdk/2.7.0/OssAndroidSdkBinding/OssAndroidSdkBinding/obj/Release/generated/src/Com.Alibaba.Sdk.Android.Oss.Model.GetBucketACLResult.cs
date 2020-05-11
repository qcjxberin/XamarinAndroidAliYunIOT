using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetBucketACLResult']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/GetBucketACLResult", DoNotGenerateAcw=true)]
	public partial class GetBucketACLResult : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/GetBucketACLResult", typeof (GetBucketACLResult));
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

		protected GetBucketACLResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetBucketACLResult']/constructor[@name='GetBucketACLResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetBucketACLResult ()
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BucketACL);
		}
#pragma warning restore 0169

		static Delegate cb_setBucketACL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBucketACL_Ljava_lang_String_Handler ()
		{
			if (cb_setBucketACL_Ljava_lang_String_ == null)
				cb_setBucketACL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBucketACL_Ljava_lang_String_);
			return cb_setBucketACL_Ljava_lang_String_;
		}

		static void n_SetBucketACL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucketACL)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketACL = JNIEnv.GetString (native_bucketACL, JniHandleOwnership.DoNotTransfer);
			__this.BucketACL = bucketACL;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketACL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetBucketACLResult']/method[@name='getBucketACL' and count(parameter)=0]"
			[Register ("getBucketACL", "()Ljava/lang/String;", "GetGetBucketACLHandler")]
			get {
				const string __id = "getBucketACL.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetBucketACLResult']/method[@name='setBucketACL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBucketACL", "(Ljava/lang/String;)V", "GetSetBucketACL_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBucketACL.(Ljava/lang/String;)V";
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

		static Delegate cb_getBucketOwner;
#pragma warning disable 0169
		static Delegate GetGetBucketOwnerHandler ()
		{
			if (cb_getBucketOwner == null)
				cb_getBucketOwner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBucketOwner);
			return cb_getBucketOwner;
		}

		static IntPtr n_GetBucketOwner (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BucketOwner);
		}
#pragma warning restore 0169

		static Delegate cb_setBucketOwner_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBucketOwner_Ljava_lang_String_Handler ()
		{
			if (cb_setBucketOwner_Ljava_lang_String_ == null)
				cb_setBucketOwner_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBucketOwner_Ljava_lang_String_);
			return cb_setBucketOwner_Ljava_lang_String_;
		}

		static void n_SetBucketOwner_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ownerName)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ownerName = JNIEnv.GetString (native_ownerName, JniHandleOwnership.DoNotTransfer);
			__this.BucketOwner = ownerName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketOwner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetBucketACLResult']/method[@name='getBucketOwner' and count(parameter)=0]"
			[Register ("getBucketOwner", "()Ljava/lang/String;", "GetGetBucketOwnerHandler")]
			get {
				const string __id = "getBucketOwner.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetBucketACLResult']/method[@name='setBucketOwner' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBucketOwner", "(Ljava/lang/String;)V", "GetSetBucketOwner_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBucketOwner.(Ljava/lang/String;)V";
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

		static Delegate cb_getBucketOwnerID;
#pragma warning disable 0169
		static Delegate GetGetBucketOwnerIDHandler ()
		{
			if (cb_getBucketOwnerID == null)
				cb_getBucketOwnerID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBucketOwnerID);
			return cb_getBucketOwnerID;
		}

		static IntPtr n_GetBucketOwnerID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BucketOwnerID);
		}
#pragma warning restore 0169

		static Delegate cb_setBucketOwnerID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBucketOwnerID_Ljava_lang_String_Handler ()
		{
			if (cb_setBucketOwnerID_Ljava_lang_String_ == null)
				cb_setBucketOwnerID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBucketOwnerID_Ljava_lang_String_);
			return cb_setBucketOwnerID_Ljava_lang_String_;
		}

		static void n_SetBucketOwnerID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			__this.BucketOwnerID = id;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketOwnerID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetBucketACLResult']/method[@name='getBucketOwnerID' and count(parameter)=0]"
			[Register ("getBucketOwnerID", "()Ljava/lang/String;", "GetGetBucketOwnerIDHandler")]
			get {
				const string __id = "getBucketOwnerID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetBucketACLResult']/method[@name='setBucketOwnerID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBucketOwnerID", "(Ljava/lang/String;)V", "GetSetBucketOwnerID_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBucketOwnerID.(Ljava/lang/String;)V";
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

		static Delegate cb_getOwner;
#pragma warning disable 0169
		static Delegate GetGetOwnerHandler ()
		{
			if (cb_getOwner == null)
				cb_getOwner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwner);
			return cb_getOwner;
		}

		static IntPtr n_GetOwner (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Owner);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.Owner Owner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetBucketACLResult']/method[@name='getOwner' and count(parameter)=0]"
			[Register ("getOwner", "()Lcom/alibaba/sdk/android/oss/model/Owner;", "GetGetOwnerHandler")]
			get {
				const string __id = "getOwner.()Lcom/alibaba/sdk/android/oss/model/Owner;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.Owner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
