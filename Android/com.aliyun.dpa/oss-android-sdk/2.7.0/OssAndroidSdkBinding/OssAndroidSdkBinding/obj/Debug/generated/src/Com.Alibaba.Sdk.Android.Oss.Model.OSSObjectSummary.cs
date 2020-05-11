using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/OSSObjectSummary", DoNotGenerateAcw=true)]
	public partial class OSSObjectSummary : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/OSSObjectSummary", typeof (OSSObjectSummary));
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

		protected OSSObjectSummary (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/constructor[@name='OSSObjectSummary' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSSObjectSummary ()
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			__this.BucketName = bucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='getBucketName' and count(parameter)=0]"
			[Register ("getBucketName", "()Ljava/lang/String;", "GetGetBucketNameHandler")]
			get {
				const string __id = "getBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='setBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getETag;
#pragma warning disable 0169
		static Delegate GetGetETagHandler ()
		{
			if (cb_getETag == null)
				cb_getETag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetETag);
			return cb_getETag;
		}

		static IntPtr n_GetETag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ETag);
		}
#pragma warning restore 0169

		static Delegate cb_setETag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetETag_Ljava_lang_String_Handler ()
		{
			if (cb_setETag_Ljava_lang_String_ == null)
				cb_setETag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetETag_Ljava_lang_String_);
			return cb_setETag_Ljava_lang_String_;
		}

		static void n_SetETag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eTag)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eTag = JNIEnv.GetString (native_eTag, JniHandleOwnership.DoNotTransfer);
			__this.ETag = eTag;
		}
#pragma warning restore 0169

		public virtual unsafe string ETag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='getETag' and count(parameter)=0]"
			[Register ("getETag", "()Ljava/lang/String;", "GetGetETagHandler")]
			get {
				const string __id = "getETag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='setETag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setETag", "(Ljava/lang/String;)V", "GetSetETag_Ljava_lang_String_Handler")]
			set {
				const string __id = "setETag.(Ljava/lang/String;)V";
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

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		static Delegate cb_setKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKey_Ljava_lang_String_Handler ()
		{
			if (cb_setKey_Ljava_lang_String_ == null)
				cb_setKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKey_Ljava_lang_String_);
			return cb_setKey_Ljava_lang_String_;
		}

		static void n_SetKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Key = key;
		}
#pragma warning restore 0169

		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				const string __id = "getKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='setKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKey", "(Ljava/lang/String;)V", "GetSetKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setKey.(Ljava/lang/String;)V";
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

		static Delegate cb_getLastModified;
#pragma warning disable 0169
		static Delegate GetGetLastModifiedHandler ()
		{
			if (cb_getLastModified == null)
				cb_getLastModified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastModified);
			return cb_getLastModified;
		}

		static IntPtr n_GetLastModified (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastModified);
		}
#pragma warning restore 0169

		static Delegate cb_setLastModified_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetLastModified_Ljava_util_Date_Handler ()
		{
			if (cb_setLastModified_Ljava_util_Date_ == null)
				cb_setLastModified_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastModified_Ljava_util_Date_);
			return cb_setLastModified_Ljava_util_Date_;
		}

		static void n_SetLastModified_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lastModified)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date lastModified = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_lastModified, JniHandleOwnership.DoNotTransfer);
			__this.LastModified = lastModified;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date LastModified {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='getLastModified' and count(parameter)=0]"
			[Register ("getLastModified", "()Ljava/util/Date;", "GetGetLastModifiedHandler")]
			get {
				const string __id = "getLastModified.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='setLastModified' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setLastModified", "(Ljava/util/Date;)V", "GetSetLastModified_Ljava_util_Date_Handler")]
			set {
				const string __id = "setLastModified.(Ljava/util/Date;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Owner);
		}
#pragma warning restore 0169

		static Delegate cb_setOwner_Lcom_alibaba_sdk_android_oss_model_Owner_;
#pragma warning disable 0169
		static Delegate GetSetOwner_Lcom_alibaba_sdk_android_oss_model_Owner_Handler ()
		{
			if (cb_setOwner_Lcom_alibaba_sdk_android_oss_model_Owner_ == null)
				cb_setOwner_Lcom_alibaba_sdk_android_oss_model_Owner_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOwner_Lcom_alibaba_sdk_android_oss_model_Owner_);
			return cb_setOwner_Lcom_alibaba_sdk_android_oss_model_Owner_;
		}

		static void n_SetOwner_Lcom_alibaba_sdk_android_oss_model_Owner_ (IntPtr jnienv, IntPtr native__this, IntPtr native_owner)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.Owner owner = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.Owner> (native_owner, JniHandleOwnership.DoNotTransfer);
			__this.Owner = owner;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.Owner Owner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='getOwner' and count(parameter)=0]"
			[Register ("getOwner", "()Lcom/alibaba/sdk/android/oss/model/Owner;", "GetGetOwnerHandler")]
			get {
				const string __id = "getOwner.()Lcom/alibaba/sdk/android/oss/model/Owner;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.Owner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='setOwner' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.Owner']]"
			[Register ("setOwner", "(Lcom/alibaba/sdk/android/oss/model/Owner;)V", "GetSetOwner_Lcom_alibaba_sdk_android_oss_model_Owner_Handler")]
			set {
				const string __id = "setOwner.(Lcom/alibaba/sdk/android/oss/model/Owner;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSize);
			return cb_getSize;
		}

		static long n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static Delegate cb_setSize_J;
#pragma warning disable 0169
		static Delegate GetSetSize_JHandler ()
		{
			if (cb_setSize_J == null)
				cb_setSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSize_J);
			return cb_setSize_J;
		}

		static void n_SetSize_J (IntPtr jnienv, IntPtr native__this, long size)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Size = size;
		}
#pragma warning restore 0169

		public virtual unsafe long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSize", "(J)V", "GetSetSize_JHandler")]
			set {
				const string __id = "setSize.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStorageClass;
#pragma warning disable 0169
		static Delegate GetGetStorageClassHandler ()
		{
			if (cb_getStorageClass == null)
				cb_getStorageClass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStorageClass);
			return cb_getStorageClass;
		}

		static IntPtr n_GetStorageClass (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StorageClass);
		}
#pragma warning restore 0169

		static Delegate cb_setStorageClass_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStorageClass_Ljava_lang_String_Handler ()
		{
			if (cb_setStorageClass_Ljava_lang_String_ == null)
				cb_setStorageClass_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStorageClass_Ljava_lang_String_);
			return cb_setStorageClass_Ljava_lang_String_;
		}

		static void n_SetStorageClass_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storageClass)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string storageClass = JNIEnv.GetString (native_storageClass, JniHandleOwnership.DoNotTransfer);
			__this.StorageClass = storageClass;
		}
#pragma warning restore 0169

		public virtual unsafe string StorageClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='getStorageClass' and count(parameter)=0]"
			[Register ("getStorageClass", "()Ljava/lang/String;", "GetGetStorageClassHandler")]
			get {
				const string __id = "getStorageClass.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='setStorageClass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStorageClass", "(Ljava/lang/String;)V", "GetSetStorageClass_Ljava_lang_String_Handler")]
			set {
				const string __id = "setStorageClass.(Ljava/lang/String;)V";
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
			__this.Type = type;
		}
#pragma warning restore 0169

		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSObjectSummary']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setType.(Ljava/lang/String;)V";
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
