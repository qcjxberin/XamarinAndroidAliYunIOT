using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ResumableUploadRequest']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/ResumableUploadRequest", DoNotGenerateAcw=true)]
	public partial class ResumableUploadRequest : global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/ResumableUploadRequest", typeof (ResumableUploadRequest));
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

		protected ResumableUploadRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ResumableUploadRequest']/constructor[@name='ResumableUploadRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ResumableUploadRequest (string bucketName, string objectKey, string uploadFilePath)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			IntPtr native_uploadFilePath = JNIEnv.NewString (uploadFilePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				__args [2] = new JniArgumentValue (native_uploadFilePath);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_objectKey);
				JNIEnv.DeleteLocalRef (native_uploadFilePath);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ResumableUploadRequest']/constructor[@name='ResumableUploadRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.alibaba.sdk.android.oss.model.ObjectMetadata']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V", "")]
		public unsafe ResumableUploadRequest (string bucketName, string objectKey, string uploadFilePath, global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata metadata)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			IntPtr native_uploadFilePath = JNIEnv.NewString (uploadFilePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				__args [2] = new JniArgumentValue (native_uploadFilePath);
				__args [3] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_objectKey);
				JNIEnv.DeleteLocalRef (native_uploadFilePath);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ResumableUploadRequest']/constructor[@name='ResumableUploadRequest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.alibaba.sdk.android.oss.model.ObjectMetadata'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;Ljava/lang/String;)V", "")]
		public unsafe ResumableUploadRequest (string bucketName, string objectKey, string uploadFilePath, global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata metadata, string recordDirectory)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			IntPtr native_uploadFilePath = JNIEnv.NewString (uploadFilePath);
			IntPtr native_recordDirectory = JNIEnv.NewString (recordDirectory);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				__args [2] = new JniArgumentValue (native_uploadFilePath);
				__args [3] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
				__args [4] = new JniArgumentValue (native_recordDirectory);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_objectKey);
				JNIEnv.DeleteLocalRef (native_uploadFilePath);
				JNIEnv.DeleteLocalRef (native_recordDirectory);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ResumableUploadRequest']/constructor[@name='ResumableUploadRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ResumableUploadRequest (string bucketName, string objectKey, string uploadFilePath, string recordDirectory)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			IntPtr native_uploadFilePath = JNIEnv.NewString (uploadFilePath);
			IntPtr native_recordDirectory = JNIEnv.NewString (recordDirectory);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				__args [2] = new JniArgumentValue (native_uploadFilePath);
				__args [3] = new JniArgumentValue (native_recordDirectory);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_objectKey);
				JNIEnv.DeleteLocalRef (native_uploadFilePath);
				JNIEnv.DeleteLocalRef (native_recordDirectory);
			}
		}

		static Delegate cb_getRecordDirectory;
#pragma warning disable 0169
		static Delegate GetGetRecordDirectoryHandler ()
		{
			if (cb_getRecordDirectory == null)
				cb_getRecordDirectory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecordDirectory);
			return cb_getRecordDirectory;
		}

		static IntPtr n_GetRecordDirectory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RecordDirectory);
		}
#pragma warning restore 0169

		static Delegate cb_setRecordDirectory_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRecordDirectory_Ljava_lang_String_Handler ()
		{
			if (cb_setRecordDirectory_Ljava_lang_String_ == null)
				cb_setRecordDirectory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRecordDirectory_Ljava_lang_String_);
			return cb_setRecordDirectory_Ljava_lang_String_;
		}

		static void n_SetRecordDirectory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_recordDirectory)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string recordDirectory = JNIEnv.GetString (native_recordDirectory, JniHandleOwnership.DoNotTransfer);
			__this.RecordDirectory = recordDirectory;
		}
#pragma warning restore 0169

		public virtual unsafe string RecordDirectory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ResumableUploadRequest']/method[@name='getRecordDirectory' and count(parameter)=0]"
			[Register ("getRecordDirectory", "()Ljava/lang/String;", "GetGetRecordDirectoryHandler")]
			get {
				const string __id = "getRecordDirectory.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ResumableUploadRequest']/method[@name='setRecordDirectory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRecordDirectory", "(Ljava/lang/String;)V", "GetSetRecordDirectory_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRecordDirectory.(Ljava/lang/String;)V";
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

		static Delegate cb_deleteUploadOnCancelling;
#pragma warning disable 0169
		static Delegate GetDeleteUploadOnCancellingHandler ()
		{
			if (cb_deleteUploadOnCancelling == null)
				cb_deleteUploadOnCancelling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DeleteUploadOnCancelling);
			return cb_deleteUploadOnCancelling;
		}

		static IntPtr n_DeleteUploadOnCancelling (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeleteUploadOnCancelling ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ResumableUploadRequest']/method[@name='deleteUploadOnCancelling' and count(parameter)=0]"
		[Register ("deleteUploadOnCancelling", "()Ljava/lang/Boolean;", "GetDeleteUploadOnCancellingHandler")]
		public virtual unsafe global::Java.Lang.Boolean DeleteUploadOnCancelling ()
		{
			const string __id = "deleteUploadOnCancelling.()Ljava/lang/Boolean;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDeleteUploadOnCancelling_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetDeleteUploadOnCancelling_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setDeleteUploadOnCancelling_Ljava_lang_Boolean_ == null)
				cb_setDeleteUploadOnCancelling_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeleteUploadOnCancelling_Ljava_lang_Boolean_);
			return cb_setDeleteUploadOnCancelling_Ljava_lang_Boolean_;
		}

		static void n_SetDeleteUploadOnCancelling_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_deleteUploadOnCancelling)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean deleteUploadOnCancelling = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_deleteUploadOnCancelling, JniHandleOwnership.DoNotTransfer);
			__this.SetDeleteUploadOnCancelling (deleteUploadOnCancelling);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ResumableUploadRequest']/method[@name='setDeleteUploadOnCancelling' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setDeleteUploadOnCancelling", "(Ljava/lang/Boolean;)V", "GetSetDeleteUploadOnCancelling_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetDeleteUploadOnCancelling (global::Java.Lang.Boolean deleteUploadOnCancelling)
		{
			const string __id = "setDeleteUploadOnCancelling.(Ljava/lang/Boolean;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((deleteUploadOnCancelling == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deleteUploadOnCancelling).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
