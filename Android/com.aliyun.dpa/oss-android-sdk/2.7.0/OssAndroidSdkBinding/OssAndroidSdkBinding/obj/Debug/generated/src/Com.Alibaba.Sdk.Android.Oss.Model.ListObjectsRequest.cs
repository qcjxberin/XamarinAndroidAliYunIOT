using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/ListObjectsRequest", DoNotGenerateAcw=true)]
	public partial class ListObjectsRequest : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/ListObjectsRequest", typeof (ListObjectsRequest));
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

		protected ListObjectsRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/constructor[@name='ListObjectsRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ListObjectsRequest ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/constructor[@name='ListObjectsRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ListObjectsRequest (string bucketName)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/constructor[@name='ListObjectsRequest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V", "")]
		public unsafe ListObjectsRequest (string bucketName, string prefix, string marker, string delimiter, global::Java.Lang.Integer maxKeys)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_marker = JNIEnv.NewString (marker);
			IntPtr native_delimiter = JNIEnv.NewString (delimiter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_prefix);
				__args [2] = new JniArgumentValue (native_marker);
				__args [3] = new JniArgumentValue (native_delimiter);
				__args [4] = new JniArgumentValue ((maxKeys == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxKeys).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_marker);
				JNIEnv.DeleteLocalRef (native_delimiter);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			__this.BucketName = bucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/method[@name='getBucketName' and count(parameter)=0]"
			[Register ("getBucketName", "()Ljava/lang/String;", "GetGetBucketNameHandler")]
			get {
				const string __id = "getBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/method[@name='setBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getDelimiter;
#pragma warning disable 0169
		static Delegate GetGetDelimiterHandler ()
		{
			if (cb_getDelimiter == null)
				cb_getDelimiter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDelimiter);
			return cb_getDelimiter;
		}

		static IntPtr n_GetDelimiter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Delimiter);
		}
#pragma warning restore 0169

		static Delegate cb_setDelimiter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDelimiter_Ljava_lang_String_Handler ()
		{
			if (cb_setDelimiter_Ljava_lang_String_ == null)
				cb_setDelimiter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDelimiter_Ljava_lang_String_);
			return cb_setDelimiter_Ljava_lang_String_;
		}

		static void n_SetDelimiter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_delimiter)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string delimiter = JNIEnv.GetString (native_delimiter, JniHandleOwnership.DoNotTransfer);
			__this.Delimiter = delimiter;
		}
#pragma warning restore 0169

		public virtual unsafe string Delimiter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/method[@name='getDelimiter' and count(parameter)=0]"
			[Register ("getDelimiter", "()Ljava/lang/String;", "GetGetDelimiterHandler")]
			get {
				const string __id = "getDelimiter.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/method[@name='setDelimiter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDelimiter", "(Ljava/lang/String;)V", "GetSetDelimiter_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDelimiter.(Ljava/lang/String;)V";
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

		static Delegate cb_getEncodingType;
#pragma warning disable 0169
		static Delegate GetGetEncodingTypeHandler ()
		{
			if (cb_getEncodingType == null)
				cb_getEncodingType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncodingType);
			return cb_getEncodingType;
		}

		static IntPtr n_GetEncodingType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EncodingType);
		}
#pragma warning restore 0169

		static Delegate cb_setEncodingType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEncodingType_Ljava_lang_String_Handler ()
		{
			if (cb_setEncodingType_Ljava_lang_String_ == null)
				cb_setEncodingType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEncodingType_Ljava_lang_String_);
			return cb_setEncodingType_Ljava_lang_String_;
		}

		static void n_SetEncodingType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encodingType)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string encodingType = JNIEnv.GetString (native_encodingType, JniHandleOwnership.DoNotTransfer);
			__this.EncodingType = encodingType;
		}
#pragma warning restore 0169

		public virtual unsafe string EncodingType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/method[@name='getEncodingType' and count(parameter)=0]"
			[Register ("getEncodingType", "()Ljava/lang/String;", "GetGetEncodingTypeHandler")]
			get {
				const string __id = "getEncodingType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/method[@name='setEncodingType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEncodingType", "(Ljava/lang/String;)V", "GetSetEncodingType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setEncodingType.(Ljava/lang/String;)V";
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

		static Delegate cb_getMarker;
#pragma warning disable 0169
		static Delegate GetGetMarkerHandler ()
		{
			if (cb_getMarker == null)
				cb_getMarker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarker);
			return cb_getMarker;
		}

		static IntPtr n_GetMarker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Marker);
		}
#pragma warning restore 0169

		static Delegate cb_setMarker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMarker_Ljava_lang_String_Handler ()
		{
			if (cb_setMarker_Ljava_lang_String_ == null)
				cb_setMarker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMarker_Ljava_lang_String_);
			return cb_setMarker_Ljava_lang_String_;
		}

		static void n_SetMarker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string marker = JNIEnv.GetString (native_marker, JniHandleOwnership.DoNotTransfer);
			__this.Marker = marker;
		}
#pragma warning restore 0169

		public virtual unsafe string Marker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/method[@name='getMarker' and count(parameter)=0]"
			[Register ("getMarker", "()Ljava/lang/String;", "GetGetMarkerHandler")]
			get {
				const string __id = "getMarker.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/method[@name='setMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMarker", "(Ljava/lang/String;)V", "GetSetMarker_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMarker.(Ljava/lang/String;)V";
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

		static Delegate cb_getMaxKeys;
#pragma warning disable 0169
		static Delegate GetGetMaxKeysHandler ()
		{
			if (cb_getMaxKeys == null)
				cb_getMaxKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaxKeys);
			return cb_getMaxKeys;
		}

		static IntPtr n_GetMaxKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MaxKeys);
		}
#pragma warning restore 0169

		static Delegate cb_setMaxKeys_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetMaxKeys_Ljava_lang_Integer_Handler ()
		{
			if (cb_setMaxKeys_Ljava_lang_Integer_ == null)
				cb_setMaxKeys_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaxKeys_Ljava_lang_Integer_);
			return cb_setMaxKeys_Ljava_lang_Integer_;
		}

		static void n_SetMaxKeys_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_maxKeys)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer maxKeys = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_maxKeys, JniHandleOwnership.DoNotTransfer);
			__this.MaxKeys = maxKeys;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer MaxKeys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/method[@name='getMaxKeys' and count(parameter)=0]"
			[Register ("getMaxKeys", "()Ljava/lang/Integer;", "GetGetMaxKeysHandler")]
			get {
				const string __id = "getMaxKeys.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/method[@name='setMaxKeys' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setMaxKeys", "(Ljava/lang/Integer;)V", "GetSetMaxKeys_Ljava_lang_Integer_Handler")]
			set {
				const string __id = "setMaxKeys.(Ljava/lang/Integer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPrefix;
#pragma warning disable 0169
		static Delegate GetGetPrefixHandler ()
		{
			if (cb_getPrefix == null)
				cb_getPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrefix);
			return cb_getPrefix;
		}

		static IntPtr n_GetPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Prefix);
		}
#pragma warning restore 0169

		static Delegate cb_setPrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setPrefix_Ljava_lang_String_ == null)
				cb_setPrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrefix_Ljava_lang_String_);
			return cb_setPrefix_Ljava_lang_String_;
		}

		static void n_SetPrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			__this.Prefix = prefix;
		}
#pragma warning restore 0169

		public virtual unsafe string Prefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/method[@name='getPrefix' and count(parameter)=0]"
			[Register ("getPrefix", "()Ljava/lang/String;", "GetGetPrefixHandler")]
			get {
				const string __id = "getPrefix.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsRequest']/method[@name='setPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPrefix", "(Ljava/lang/String;)V", "GetSetPrefix_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPrefix.(Ljava/lang/String;)V";
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
