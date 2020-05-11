using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/CopyObjectRequest", DoNotGenerateAcw=true)]
	public partial class CopyObjectRequest : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/CopyObjectRequest", typeof (CopyObjectRequest));
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

		protected CopyObjectRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/constructor[@name='CopyObjectRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe CopyObjectRequest (string sourceBucketName, string sourceKey, string destinationBucketName, string destinationKey)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sourceBucketName = JNIEnv.NewString (sourceBucketName);
			IntPtr native_sourceKey = JNIEnv.NewString (sourceKey);
			IntPtr native_destinationBucketName = JNIEnv.NewString (destinationBucketName);
			IntPtr native_destinationKey = JNIEnv.NewString (destinationKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_sourceBucketName);
				__args [1] = new JniArgumentValue (native_sourceKey);
				__args [2] = new JniArgumentValue (native_destinationBucketName);
				__args [3] = new JniArgumentValue (native_destinationKey);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceBucketName);
				JNIEnv.DeleteLocalRef (native_sourceKey);
				JNIEnv.DeleteLocalRef (native_destinationBucketName);
				JNIEnv.DeleteLocalRef (native_destinationKey);
			}
		}

		static Delegate cb_getDestinationBucketName;
#pragma warning disable 0169
		static Delegate GetGetDestinationBucketNameHandler ()
		{
			if (cb_getDestinationBucketName == null)
				cb_getDestinationBucketName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDestinationBucketName);
			return cb_getDestinationBucketName;
		}

		static IntPtr n_GetDestinationBucketName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DestinationBucketName);
		}
#pragma warning restore 0169

		static Delegate cb_setDestinationBucketName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDestinationBucketName_Ljava_lang_String_Handler ()
		{
			if (cb_setDestinationBucketName_Ljava_lang_String_ == null)
				cb_setDestinationBucketName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDestinationBucketName_Ljava_lang_String_);
			return cb_setDestinationBucketName_Ljava_lang_String_;
		}

		static void n_SetDestinationBucketName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_destinationBucketName)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string destinationBucketName = JNIEnv.GetString (native_destinationBucketName, JniHandleOwnership.DoNotTransfer);
			__this.DestinationBucketName = destinationBucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string DestinationBucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='getDestinationBucketName' and count(parameter)=0]"
			[Register ("getDestinationBucketName", "()Ljava/lang/String;", "GetGetDestinationBucketNameHandler")]
			get {
				const string __id = "getDestinationBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='setDestinationBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDestinationBucketName", "(Ljava/lang/String;)V", "GetSetDestinationBucketName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDestinationBucketName.(Ljava/lang/String;)V";
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

		static Delegate cb_getDestinationKey;
#pragma warning disable 0169
		static Delegate GetGetDestinationKeyHandler ()
		{
			if (cb_getDestinationKey == null)
				cb_getDestinationKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDestinationKey);
			return cb_getDestinationKey;
		}

		static IntPtr n_GetDestinationKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DestinationKey);
		}
#pragma warning restore 0169

		static Delegate cb_setDestinationKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDestinationKey_Ljava_lang_String_Handler ()
		{
			if (cb_setDestinationKey_Ljava_lang_String_ == null)
				cb_setDestinationKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDestinationKey_Ljava_lang_String_);
			return cb_setDestinationKey_Ljava_lang_String_;
		}

		static void n_SetDestinationKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_destinationKey)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string destinationKey = JNIEnv.GetString (native_destinationKey, JniHandleOwnership.DoNotTransfer);
			__this.DestinationKey = destinationKey;
		}
#pragma warning restore 0169

		public virtual unsafe string DestinationKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='getDestinationKey' and count(parameter)=0]"
			[Register ("getDestinationKey", "()Ljava/lang/String;", "GetGetDestinationKeyHandler")]
			get {
				const string __id = "getDestinationKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='setDestinationKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDestinationKey", "(Ljava/lang/String;)V", "GetSetDestinationKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDestinationKey.(Ljava/lang/String;)V";
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

		static Delegate cb_getMatchingETagConstraints;
#pragma warning disable 0169
		static Delegate GetGetMatchingETagConstraintsHandler ()
		{
			if (cb_getMatchingETagConstraints == null)
				cb_getMatchingETagConstraints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMatchingETagConstraints);
			return cb_getMatchingETagConstraints;
		}

		static IntPtr n_GetMatchingETagConstraints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.MatchingETagConstraints);
		}
#pragma warning restore 0169

		static Delegate cb_setMatchingETagConstraints_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetMatchingETagConstraints_Ljava_util_List_Handler ()
		{
			if (cb_setMatchingETagConstraints_Ljava_util_List_ == null)
				cb_setMatchingETagConstraints_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMatchingETagConstraints_Ljava_util_List_);
			return cb_setMatchingETagConstraints_Ljava_util_List_;
		}

		static void n_SetMatchingETagConstraints_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_matchingETagConstraints)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matchingETagConstraints = global::Android.Runtime.JavaList<string>.FromJniHandle (native_matchingETagConstraints, JniHandleOwnership.DoNotTransfer);
			__this.MatchingETagConstraints = matchingETagConstraints;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> MatchingETagConstraints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='getMatchingETagConstraints' and count(parameter)=0]"
			[Register ("getMatchingETagConstraints", "()Ljava/util/List;", "GetGetMatchingETagConstraintsHandler")]
			get {
				const string __id = "getMatchingETagConstraints.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='setMatchingETagConstraints' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setMatchingETagConstraints", "(Ljava/util/List;)V", "GetSetMatchingETagConstraints_Ljava_util_List_Handler")]
			set {
				const string __id = "setMatchingETagConstraints.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getModifiedSinceConstraint;
#pragma warning disable 0169
		static Delegate GetGetModifiedSinceConstraintHandler ()
		{
			if (cb_getModifiedSinceConstraint == null)
				cb_getModifiedSinceConstraint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModifiedSinceConstraint);
			return cb_getModifiedSinceConstraint;
		}

		static IntPtr n_GetModifiedSinceConstraint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ModifiedSinceConstraint);
		}
#pragma warning restore 0169

		static Delegate cb_setModifiedSinceConstraint_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetModifiedSinceConstraint_Ljava_util_Date_Handler ()
		{
			if (cb_setModifiedSinceConstraint_Ljava_util_Date_ == null)
				cb_setModifiedSinceConstraint_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetModifiedSinceConstraint_Ljava_util_Date_);
			return cb_setModifiedSinceConstraint_Ljava_util_Date_;
		}

		static void n_SetModifiedSinceConstraint_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_modifiedSinceConstraint)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date modifiedSinceConstraint = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_modifiedSinceConstraint, JniHandleOwnership.DoNotTransfer);
			__this.ModifiedSinceConstraint = modifiedSinceConstraint;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date ModifiedSinceConstraint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='getModifiedSinceConstraint' and count(parameter)=0]"
			[Register ("getModifiedSinceConstraint", "()Ljava/util/Date;", "GetGetModifiedSinceConstraintHandler")]
			get {
				const string __id = "getModifiedSinceConstraint.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='setModifiedSinceConstraint' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setModifiedSinceConstraint", "(Ljava/util/Date;)V", "GetSetModifiedSinceConstraint_Ljava_util_Date_Handler")]
			set {
				const string __id = "setModifiedSinceConstraint.(Ljava/util/Date;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNewObjectMetadata;
#pragma warning disable 0169
		static Delegate GetGetNewObjectMetadataHandler ()
		{
			if (cb_getNewObjectMetadata == null)
				cb_getNewObjectMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNewObjectMetadata);
			return cb_getNewObjectMetadata;
		}

		static IntPtr n_GetNewObjectMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewObjectMetadata);
		}
#pragma warning restore 0169

		static Delegate cb_setNewObjectMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_;
#pragma warning disable 0169
		static Delegate GetSetNewObjectMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_Handler ()
		{
			if (cb_setNewObjectMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_ == null)
				cb_setNewObjectMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNewObjectMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_);
			return cb_setNewObjectMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_;
		}

		static void n_SetNewObjectMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newObjectMetadata)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata newObjectMetadata = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (native_newObjectMetadata, JniHandleOwnership.DoNotTransfer);
			__this.NewObjectMetadata = newObjectMetadata;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata NewObjectMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='getNewObjectMetadata' and count(parameter)=0]"
			[Register ("getNewObjectMetadata", "()Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;", "GetGetNewObjectMetadataHandler")]
			get {
				const string __id = "getNewObjectMetadata.()Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='setNewObjectMetadata' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ObjectMetadata']]"
			[Register ("setNewObjectMetadata", "(Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V", "GetSetNewObjectMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_Handler")]
			set {
				const string __id = "setNewObjectMetadata.(Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNonmatchingEtagConstraints;
#pragma warning disable 0169
		static Delegate GetGetNonmatchingEtagConstraintsHandler ()
		{
			if (cb_getNonmatchingEtagConstraints == null)
				cb_getNonmatchingEtagConstraints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNonmatchingEtagConstraints);
			return cb_getNonmatchingEtagConstraints;
		}

		static IntPtr n_GetNonmatchingEtagConstraints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.NonmatchingEtagConstraints);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> NonmatchingEtagConstraints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='getNonmatchingEtagConstraints' and count(parameter)=0]"
			[Register ("getNonmatchingEtagConstraints", "()Ljava/util/List;", "GetGetNonmatchingEtagConstraintsHandler")]
			get {
				const string __id = "getNonmatchingEtagConstraints.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServerSideEncryption;
#pragma warning disable 0169
		static Delegate GetGetServerSideEncryptionHandler ()
		{
			if (cb_getServerSideEncryption == null)
				cb_getServerSideEncryption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerSideEncryption);
			return cb_getServerSideEncryption;
		}

		static IntPtr n_GetServerSideEncryption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerSideEncryption);
		}
#pragma warning restore 0169

		static Delegate cb_setServerSideEncryption_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServerSideEncryption_Ljava_lang_String_Handler ()
		{
			if (cb_setServerSideEncryption_Ljava_lang_String_ == null)
				cb_setServerSideEncryption_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServerSideEncryption_Ljava_lang_String_);
			return cb_setServerSideEncryption_Ljava_lang_String_;
		}

		static void n_SetServerSideEncryption_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverSideEncryption)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string serverSideEncryption = JNIEnv.GetString (native_serverSideEncryption, JniHandleOwnership.DoNotTransfer);
			__this.ServerSideEncryption = serverSideEncryption;
		}
#pragma warning restore 0169

		public virtual unsafe string ServerSideEncryption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='getServerSideEncryption' and count(parameter)=0]"
			[Register ("getServerSideEncryption", "()Ljava/lang/String;", "GetGetServerSideEncryptionHandler")]
			get {
				const string __id = "getServerSideEncryption.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='setServerSideEncryption' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServerSideEncryption", "(Ljava/lang/String;)V", "GetSetServerSideEncryption_Ljava_lang_String_Handler")]
			set {
				const string __id = "setServerSideEncryption.(Ljava/lang/String;)V";
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

		static Delegate cb_getSourceBucketName;
#pragma warning disable 0169
		static Delegate GetGetSourceBucketNameHandler ()
		{
			if (cb_getSourceBucketName == null)
				cb_getSourceBucketName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSourceBucketName);
			return cb_getSourceBucketName;
		}

		static IntPtr n_GetSourceBucketName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SourceBucketName);
		}
#pragma warning restore 0169

		static Delegate cb_setSourceBucketName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSourceBucketName_Ljava_lang_String_Handler ()
		{
			if (cb_setSourceBucketName_Ljava_lang_String_ == null)
				cb_setSourceBucketName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSourceBucketName_Ljava_lang_String_);
			return cb_setSourceBucketName_Ljava_lang_String_;
		}

		static void n_SetSourceBucketName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceBucketName)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceBucketName = JNIEnv.GetString (native_sourceBucketName, JniHandleOwnership.DoNotTransfer);
			__this.SourceBucketName = sourceBucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string SourceBucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='getSourceBucketName' and count(parameter)=0]"
			[Register ("getSourceBucketName", "()Ljava/lang/String;", "GetGetSourceBucketNameHandler")]
			get {
				const string __id = "getSourceBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='setSourceBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSourceBucketName", "(Ljava/lang/String;)V", "GetSetSourceBucketName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSourceBucketName.(Ljava/lang/String;)V";
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

		static Delegate cb_getSourceKey;
#pragma warning disable 0169
		static Delegate GetGetSourceKeyHandler ()
		{
			if (cb_getSourceKey == null)
				cb_getSourceKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSourceKey);
			return cb_getSourceKey;
		}

		static IntPtr n_GetSourceKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SourceKey);
		}
#pragma warning restore 0169

		static Delegate cb_setSourceKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSourceKey_Ljava_lang_String_Handler ()
		{
			if (cb_setSourceKey_Ljava_lang_String_ == null)
				cb_setSourceKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSourceKey_Ljava_lang_String_);
			return cb_setSourceKey_Ljava_lang_String_;
		}

		static void n_SetSourceKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceKey)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceKey = JNIEnv.GetString (native_sourceKey, JniHandleOwnership.DoNotTransfer);
			__this.SourceKey = sourceKey;
		}
#pragma warning restore 0169

		public virtual unsafe string SourceKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='getSourceKey' and count(parameter)=0]"
			[Register ("getSourceKey", "()Ljava/lang/String;", "GetGetSourceKeyHandler")]
			get {
				const string __id = "getSourceKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='setSourceKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSourceKey", "(Ljava/lang/String;)V", "GetSetSourceKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSourceKey.(Ljava/lang/String;)V";
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

		static Delegate cb_getUnmodifiedSinceConstraint;
#pragma warning disable 0169
		static Delegate GetGetUnmodifiedSinceConstraintHandler ()
		{
			if (cb_getUnmodifiedSinceConstraint == null)
				cb_getUnmodifiedSinceConstraint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnmodifiedSinceConstraint);
			return cb_getUnmodifiedSinceConstraint;
		}

		static IntPtr n_GetUnmodifiedSinceConstraint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnmodifiedSinceConstraint);
		}
#pragma warning restore 0169

		static Delegate cb_setUnmodifiedSinceConstraint_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetUnmodifiedSinceConstraint_Ljava_util_Date_Handler ()
		{
			if (cb_setUnmodifiedSinceConstraint_Ljava_util_Date_ == null)
				cb_setUnmodifiedSinceConstraint_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUnmodifiedSinceConstraint_Ljava_util_Date_);
			return cb_setUnmodifiedSinceConstraint_Ljava_util_Date_;
		}

		static void n_SetUnmodifiedSinceConstraint_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unmodifiedSinceConstraint)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date unmodifiedSinceConstraint = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_unmodifiedSinceConstraint, JniHandleOwnership.DoNotTransfer);
			__this.UnmodifiedSinceConstraint = unmodifiedSinceConstraint;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date UnmodifiedSinceConstraint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='getUnmodifiedSinceConstraint' and count(parameter)=0]"
			[Register ("getUnmodifiedSinceConstraint", "()Ljava/util/Date;", "GetGetUnmodifiedSinceConstraintHandler")]
			get {
				const string __id = "getUnmodifiedSinceConstraint.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='setUnmodifiedSinceConstraint' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setUnmodifiedSinceConstraint", "(Ljava/util/Date;)V", "GetSetUnmodifiedSinceConstraint_Ljava_util_Date_Handler")]
			set {
				const string __id = "setUnmodifiedSinceConstraint.(Ljava/util/Date;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_clearMatchingETagConstraints;
#pragma warning disable 0169
		static Delegate GetClearMatchingETagConstraintsHandler ()
		{
			if (cb_clearMatchingETagConstraints == null)
				cb_clearMatchingETagConstraints = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearMatchingETagConstraints);
			return cb_clearMatchingETagConstraints;
		}

		static void n_ClearMatchingETagConstraints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearMatchingETagConstraints ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='clearMatchingETagConstraints' and count(parameter)=0]"
		[Register ("clearMatchingETagConstraints", "()V", "GetClearMatchingETagConstraintsHandler")]
		public virtual unsafe void ClearMatchingETagConstraints ()
		{
			const string __id = "clearMatchingETagConstraints.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearNonmatchingETagConstraints;
#pragma warning disable 0169
		static Delegate GetClearNonmatchingETagConstraintsHandler ()
		{
			if (cb_clearNonmatchingETagConstraints == null)
				cb_clearNonmatchingETagConstraints = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearNonmatchingETagConstraints);
			return cb_clearNonmatchingETagConstraints;
		}

		static void n_ClearNonmatchingETagConstraints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearNonmatchingETagConstraints ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='clearNonmatchingETagConstraints' and count(parameter)=0]"
		[Register ("clearNonmatchingETagConstraints", "()V", "GetClearNonmatchingETagConstraintsHandler")]
		public virtual unsafe void ClearNonmatchingETagConstraints ()
		{
			const string __id = "clearNonmatchingETagConstraints.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setNonmatchingETagConstraints_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetNonmatchingETagConstraints_Ljava_util_List_Handler ()
		{
			if (cb_setNonmatchingETagConstraints_Ljava_util_List_ == null)
				cb_setNonmatchingETagConstraints_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNonmatchingETagConstraints_Ljava_util_List_);
			return cb_setNonmatchingETagConstraints_Ljava_util_List_;
		}

		static void n_SetNonmatchingETagConstraints_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nonmatchingEtagConstraints)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nonmatchingEtagConstraints = global::Android.Runtime.JavaList<string>.FromJniHandle (native_nonmatchingEtagConstraints, JniHandleOwnership.DoNotTransfer);
			__this.SetNonmatchingETagConstraints (nonmatchingEtagConstraints);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectRequest']/method[@name='setNonmatchingETagConstraints' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("setNonmatchingETagConstraints", "(Ljava/util/List;)V", "GetSetNonmatchingETagConstraints_Ljava_util_List_Handler")]
		public virtual unsafe void SetNonmatchingETagConstraints (global::System.Collections.Generic.IList<string> nonmatchingEtagConstraints)
		{
			const string __id = "setNonmatchingETagConstraints.(Ljava/util/List;)V";
			IntPtr native_nonmatchingEtagConstraints = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (nonmatchingEtagConstraints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_nonmatchingEtagConstraints);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_nonmatchingEtagConstraints);
			}
		}

	}
}
