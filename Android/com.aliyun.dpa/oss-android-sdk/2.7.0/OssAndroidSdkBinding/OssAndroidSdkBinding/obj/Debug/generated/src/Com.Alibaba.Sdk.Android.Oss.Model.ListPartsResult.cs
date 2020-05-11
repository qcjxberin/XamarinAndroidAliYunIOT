using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/ListPartsResult", DoNotGenerateAcw=true)]
	public partial class ListPartsResult : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/ListPartsResult", typeof (ListPartsResult));
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

		protected ListPartsResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/constructor[@name='ListPartsResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ListPartsResult ()
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			__this.BucketName = bucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='getBucketName' and count(parameter)=0]"
			[Register ("getBucketName", "()Ljava/lang/String;", "GetGetBucketNameHandler")]
			get {
				const string __id = "getBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='setBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Key = key;
		}
#pragma warning restore 0169

		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				const string __id = "getKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='setKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getMaxParts;
#pragma warning disable 0169
		static Delegate GetGetMaxPartsHandler ()
		{
			if (cb_getMaxParts == null)
				cb_getMaxParts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaxParts);
			return cb_getMaxParts;
		}

		static IntPtr n_GetMaxParts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MaxParts);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer MaxParts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='getMaxParts' and count(parameter)=0]"
			[Register ("getMaxParts", "()Ljava/lang/Integer;", "GetGetMaxPartsHandler")]
			get {
				const string __id = "getMaxParts.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNextPartNumberMarker;
#pragma warning disable 0169
		static Delegate GetGetNextPartNumberMarkerHandler ()
		{
			if (cb_getNextPartNumberMarker == null)
				cb_getNextPartNumberMarker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextPartNumberMarker);
			return cb_getNextPartNumberMarker;
		}

		static IntPtr n_GetNextPartNumberMarker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextPartNumberMarker);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer NextPartNumberMarker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='getNextPartNumberMarker' and count(parameter)=0]"
			[Register ("getNextPartNumberMarker", "()Ljava/lang/Integer;", "GetGetNextPartNumberMarkerHandler")]
			get {
				const string __id = "getNextPartNumberMarker.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPartNumberMarker;
#pragma warning disable 0169
		static Delegate GetGetPartNumberMarkerHandler ()
		{
			if (cb_getPartNumberMarker == null)
				cb_getPartNumberMarker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPartNumberMarker);
			return cb_getPartNumberMarker;
		}

		static IntPtr n_GetPartNumberMarker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PartNumberMarker);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer PartNumberMarker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='getPartNumberMarker' and count(parameter)=0]"
			[Register ("getPartNumberMarker", "()Ljava/lang/Integer;", "GetGetPartNumberMarkerHandler")]
			get {
				const string __id = "getPartNumberMarker.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getParts;
#pragma warning disable 0169
		static Delegate GetGetPartsHandler ()
		{
			if (cb_getParts == null)
				cb_getParts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParts);
			return cb_getParts;
		}

		static IntPtr n_GetParts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary>.ToLocalJniHandle (__this.Parts);
		}
#pragma warning restore 0169

		static Delegate cb_setParts_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetParts_Ljava_util_List_Handler ()
		{
			if (cb_setParts_Ljava_util_List_ == null)
				cb_setParts_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParts_Ljava_util_List_);
			return cb_setParts_Ljava_util_List_;
		}

		static void n_SetParts_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parts)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parts = global::Android.Runtime.JavaList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary>.FromJniHandle (native_parts, JniHandleOwnership.DoNotTransfer);
			__this.Parts = parts;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary> Parts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='getParts' and count(parameter)=0]"
			[Register ("getParts", "()Ljava/util/List;", "GetGetPartsHandler")]
			get {
				const string __id = "getParts.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='setParts' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.alibaba.sdk.android.oss.model.PartSummary&gt;']]"
			[Register ("setParts", "(Ljava/util/List;)V", "GetSetParts_Ljava_util_List_Handler")]
			set {
				const string __id = "setParts.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string storageClass = JNIEnv.GetString (native_storageClass, JniHandleOwnership.DoNotTransfer);
			__this.StorageClass = storageClass;
		}
#pragma warning restore 0169

		public virtual unsafe string StorageClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='getStorageClass' and count(parameter)=0]"
			[Register ("getStorageClass", "()Ljava/lang/String;", "GetGetStorageClassHandler")]
			get {
				const string __id = "getStorageClass.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='setStorageClass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_isTruncated;
#pragma warning disable 0169
		static Delegate GetIsTruncatedHandler ()
		{
			if (cb_isTruncated == null)
				cb_isTruncated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTruncated);
			return cb_isTruncated;
		}

		static bool n_IsTruncated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Truncated;
		}
#pragma warning restore 0169

		static Delegate cb_setTruncated_Z;
#pragma warning disable 0169
		static Delegate GetSetTruncated_ZHandler ()
		{
			if (cb_setTruncated_Z == null)
				cb_setTruncated_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTruncated_Z);
			return cb_setTruncated_Z;
		}

		static void n_SetTruncated_Z (IntPtr jnienv, IntPtr native__this, bool isTruncated)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Truncated = isTruncated;
		}
#pragma warning restore 0169

		public virtual unsafe bool Truncated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='isTruncated' and count(parameter)=0]"
			[Register ("isTruncated", "()Z", "GetIsTruncatedHandler")]
			get {
				const string __id = "isTruncated.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='setTruncated' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTruncated", "(Z)V", "GetSetTruncated_ZHandler")]
			set {
				const string __id = "setTruncated.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUploadId;
#pragma warning disable 0169
		static Delegate GetGetUploadIdHandler ()
		{
			if (cb_getUploadId == null)
				cb_getUploadId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUploadId);
			return cb_getUploadId;
		}

		static IntPtr n_GetUploadId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UploadId);
		}
#pragma warning restore 0169

		static Delegate cb_setUploadId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUploadId_Ljava_lang_String_Handler ()
		{
			if (cb_setUploadId_Ljava_lang_String_ == null)
				cb_setUploadId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUploadId_Ljava_lang_String_);
			return cb_setUploadId_Ljava_lang_String_;
		}

		static void n_SetUploadId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uploadId)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uploadId = JNIEnv.GetString (native_uploadId, JniHandleOwnership.DoNotTransfer);
			__this.UploadId = uploadId;
		}
#pragma warning restore 0169

		public virtual unsafe string UploadId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='getUploadId' and count(parameter)=0]"
			[Register ("getUploadId", "()Ljava/lang/String;", "GetGetUploadIdHandler")]
			get {
				const string __id = "getUploadId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='setUploadId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUploadId", "(Ljava/lang/String;)V", "GetSetUploadId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUploadId.(Ljava/lang/String;)V";
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

		static Delegate cb_setMaxParts_I;
#pragma warning disable 0169
		static Delegate GetSetMaxParts_IHandler ()
		{
			if (cb_setMaxParts_I == null)
				cb_setMaxParts_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxParts_I);
			return cb_setMaxParts_I;
		}

		static void n_SetMaxParts_I (IntPtr jnienv, IntPtr native__this, int maxParts)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxParts (maxParts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='setMaxParts' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxParts", "(I)V", "GetSetMaxParts_IHandler")]
		public virtual unsafe void SetMaxParts (int maxParts)
		{
			const string __id = "setMaxParts.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxParts);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setNextPartNumberMarker_I;
#pragma warning disable 0169
		static Delegate GetSetNextPartNumberMarker_IHandler ()
		{
			if (cb_setNextPartNumberMarker_I == null)
				cb_setNextPartNumberMarker_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNextPartNumberMarker_I);
			return cb_setNextPartNumberMarker_I;
		}

		static void n_SetNextPartNumberMarker_I (IntPtr jnienv, IntPtr native__this, int nextPartNumberMarker)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNextPartNumberMarker (nextPartNumberMarker);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='setNextPartNumberMarker' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNextPartNumberMarker", "(I)V", "GetSetNextPartNumberMarker_IHandler")]
		public virtual unsafe void SetNextPartNumberMarker (int nextPartNumberMarker)
		{
			const string __id = "setNextPartNumberMarker.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nextPartNumberMarker);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPartNumberMarker_I;
#pragma warning disable 0169
		static Delegate GetSetPartNumberMarker_IHandler ()
		{
			if (cb_setPartNumberMarker_I == null)
				cb_setPartNumberMarker_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPartNumberMarker_I);
			return cb_setPartNumberMarker_I;
		}

		static void n_SetPartNumberMarker_I (IntPtr jnienv, IntPtr native__this, int partNumberMarker)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPartNumberMarker (partNumberMarker);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListPartsResult']/method[@name='setPartNumberMarker' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPartNumberMarker", "(I)V", "GetSetPartNumberMarker_IHandler")]
		public virtual unsafe void SetPartNumberMarker (int partNumberMarker)
		{
			const string __id = "setPartNumberMarker.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (partNumberMarker);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
