using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/ListObjectsResult", DoNotGenerateAcw=true)]
	public partial class ListObjectsResult : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/ListObjectsResult", typeof (ListObjectsResult));
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

		protected ListObjectsResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/constructor[@name='ListObjectsResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ListObjectsResult ()
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			__this.BucketName = bucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='getBucketName' and count(parameter)=0]"
			[Register ("getBucketName", "()Ljava/lang/String;", "GetGetBucketNameHandler")]
			get {
				const string __id = "getBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='setBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getCommonPrefixes;
#pragma warning disable 0169
		static Delegate GetGetCommonPrefixesHandler ()
		{
			if (cb_getCommonPrefixes == null)
				cb_getCommonPrefixes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCommonPrefixes);
			return cb_getCommonPrefixes;
		}

		static IntPtr n_GetCommonPrefixes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.CommonPrefixes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> CommonPrefixes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='getCommonPrefixes' and count(parameter)=0]"
			[Register ("getCommonPrefixes", "()Ljava/util/List;", "GetGetCommonPrefixesHandler")]
			get {
				const string __id = "getCommonPrefixes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string delimiter = JNIEnv.GetString (native_delimiter, JniHandleOwnership.DoNotTransfer);
			__this.Delimiter = delimiter;
		}
#pragma warning restore 0169

		public virtual unsafe string Delimiter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='getDelimiter' and count(parameter)=0]"
			[Register ("getDelimiter", "()Ljava/lang/String;", "GetGetDelimiterHandler")]
			get {
				const string __id = "getDelimiter.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='setDelimiter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string encodingType = JNIEnv.GetString (native_encodingType, JniHandleOwnership.DoNotTransfer);
			__this.EncodingType = encodingType;
		}
#pragma warning restore 0169

		public virtual unsafe string EncodingType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='getEncodingType' and count(parameter)=0]"
			[Register ("getEncodingType", "()Ljava/lang/String;", "GetGetEncodingTypeHandler")]
			get {
				const string __id = "getEncodingType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='setEncodingType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string marker = JNIEnv.GetString (native_marker, JniHandleOwnership.DoNotTransfer);
			__this.Marker = marker;
		}
#pragma warning restore 0169

		public virtual unsafe string Marker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='getMarker' and count(parameter)=0]"
			[Register ("getMarker", "()Ljava/lang/String;", "GetGetMarkerHandler")]
			get {
				const string __id = "getMarker.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='setMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
				cb_getMaxKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxKeys);
			return cb_getMaxKeys;
		}

		static int n_GetMaxKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxKeys;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxKeys_I;
#pragma warning disable 0169
		static Delegate GetSetMaxKeys_IHandler ()
		{
			if (cb_setMaxKeys_I == null)
				cb_setMaxKeys_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxKeys_I);
			return cb_setMaxKeys_I;
		}

		static void n_SetMaxKeys_I (IntPtr jnienv, IntPtr native__this, int maxKeys)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxKeys = maxKeys;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxKeys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='getMaxKeys' and count(parameter)=0]"
			[Register ("getMaxKeys", "()I", "GetGetMaxKeysHandler")]
			get {
				const string __id = "getMaxKeys.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='setMaxKeys' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxKeys", "(I)V", "GetSetMaxKeys_IHandler")]
			set {
				const string __id = "setMaxKeys.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNextMarker;
#pragma warning disable 0169
		static Delegate GetGetNextMarkerHandler ()
		{
			if (cb_getNextMarker == null)
				cb_getNextMarker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextMarker);
			return cb_getNextMarker;
		}

		static IntPtr n_GetNextMarker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextMarker);
		}
#pragma warning restore 0169

		static Delegate cb_setNextMarker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNextMarker_Ljava_lang_String_Handler ()
		{
			if (cb_setNextMarker_Ljava_lang_String_ == null)
				cb_setNextMarker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNextMarker_Ljava_lang_String_);
			return cb_setNextMarker_Ljava_lang_String_;
		}

		static void n_SetNextMarker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nextMarker)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string nextMarker = JNIEnv.GetString (native_nextMarker, JniHandleOwnership.DoNotTransfer);
			__this.NextMarker = nextMarker;
		}
#pragma warning restore 0169

		public virtual unsafe string NextMarker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='getNextMarker' and count(parameter)=0]"
			[Register ("getNextMarker", "()Ljava/lang/String;", "GetGetNextMarkerHandler")]
			get {
				const string __id = "getNextMarker.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='setNextMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNextMarker", "(Ljava/lang/String;)V", "GetSetNextMarker_Ljava_lang_String_Handler")]
			set {
				const string __id = "setNextMarker.(Ljava/lang/String;)V";
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

		static Delegate cb_getObjectSummaries;
#pragma warning disable 0169
		static Delegate GetGetObjectSummariesHandler ()
		{
			if (cb_getObjectSummaries == null)
				cb_getObjectSummaries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObjectSummaries);
			return cb_getObjectSummaries;
		}

		static IntPtr n_GetObjectSummaries (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary>.ToLocalJniHandle (__this.ObjectSummaries);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> ObjectSummaries {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='getObjectSummaries' and count(parameter)=0]"
			[Register ("getObjectSummaries", "()Ljava/util/List;", "GetGetObjectSummariesHandler")]
			get {
				const string __id = "getObjectSummaries.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			__this.Prefix = prefix;
		}
#pragma warning restore 0169

		public virtual unsafe string Prefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='getPrefix' and count(parameter)=0]"
			[Register ("getPrefix", "()Ljava/lang/String;", "GetGetPrefixHandler")]
			get {
				const string __id = "getPrefix.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='setPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Truncated = isTruncated;
		}
#pragma warning restore 0169

		public virtual unsafe bool Truncated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='isTruncated' and count(parameter)=0]"
			[Register ("isTruncated", "()Z", "GetIsTruncatedHandler")]
			get {
				const string __id = "isTruncated.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='setTruncated' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_addCommonPrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddCommonPrefix_Ljava_lang_String_Handler ()
		{
			if (cb_addCommonPrefix_Ljava_lang_String_ == null)
				cb_addCommonPrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCommonPrefix_Ljava_lang_String_);
			return cb_addCommonPrefix_Ljava_lang_String_;
		}

		static void n_AddCommonPrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_commonPrefix)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string commonPrefix = JNIEnv.GetString (native_commonPrefix, JniHandleOwnership.DoNotTransfer);
			__this.AddCommonPrefix (commonPrefix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='addCommonPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addCommonPrefix", "(Ljava/lang/String;)V", "GetAddCommonPrefix_Ljava_lang_String_Handler")]
		public virtual unsafe void AddCommonPrefix (string commonPrefix)
		{
			const string __id = "addCommonPrefix.(Ljava/lang/String;)V";
			IntPtr native_commonPrefix = JNIEnv.NewString (commonPrefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_commonPrefix);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_commonPrefix);
			}
		}

		static Delegate cb_addObjectSummary_Lcom_alibaba_sdk_android_oss_model_OSSObjectSummary_;
#pragma warning disable 0169
		static Delegate GetAddObjectSummary_Lcom_alibaba_sdk_android_oss_model_OSSObjectSummary_Handler ()
		{
			if (cb_addObjectSummary_Lcom_alibaba_sdk_android_oss_model_OSSObjectSummary_ == null)
				cb_addObjectSummary_Lcom_alibaba_sdk_android_oss_model_OSSObjectSummary_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddObjectSummary_Lcom_alibaba_sdk_android_oss_model_OSSObjectSummary_);
			return cb_addObjectSummary_Lcom_alibaba_sdk_android_oss_model_OSSObjectSummary_;
		}

		static void n_AddObjectSummary_Lcom_alibaba_sdk_android_oss_model_OSSObjectSummary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectSummary)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary objectSummary = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary> (native_objectSummary, JniHandleOwnership.DoNotTransfer);
			__this.AddObjectSummary (objectSummary);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='addObjectSummary' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.OSSObjectSummary']]"
		[Register ("addObjectSummary", "(Lcom/alibaba/sdk/android/oss/model/OSSObjectSummary;)V", "GetAddObjectSummary_Lcom_alibaba_sdk_android_oss_model_OSSObjectSummary_Handler")]
		public virtual unsafe void AddObjectSummary (global::Com.Alibaba.Sdk.Android.Oss.Model.OSSObjectSummary objectSummary)
		{
			const string __id = "addObjectSummary.(Lcom/alibaba/sdk/android/oss/model/OSSObjectSummary;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objectSummary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectSummary).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_clearCommonPrefixes;
#pragma warning disable 0169
		static Delegate GetClearCommonPrefixesHandler ()
		{
			if (cb_clearCommonPrefixes == null)
				cb_clearCommonPrefixes = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearCommonPrefixes);
			return cb_clearCommonPrefixes;
		}

		static void n_ClearCommonPrefixes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearCommonPrefixes ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='clearCommonPrefixes' and count(parameter)=0]"
		[Register ("clearCommonPrefixes", "()V", "GetClearCommonPrefixesHandler")]
		public virtual unsafe void ClearCommonPrefixes ()
		{
			const string __id = "clearCommonPrefixes.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearObjectSummaries;
#pragma warning disable 0169
		static Delegate GetClearObjectSummariesHandler ()
		{
			if (cb_clearObjectSummaries == null)
				cb_clearObjectSummaries = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearObjectSummaries);
			return cb_clearObjectSummaries;
		}

		static void n_ClearObjectSummaries (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearObjectSummaries ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ListObjectsResult']/method[@name='clearObjectSummaries' and count(parameter)=0]"
		[Register ("clearObjectSummaries", "()V", "GetClearObjectSummariesHandler")]
		public virtual unsafe void ClearObjectSummaries ()
		{
			const string __id = "clearObjectSummaries.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
