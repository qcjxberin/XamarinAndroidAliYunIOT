using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResumableUploadTask']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResumableUploadTask", DoNotGenerateAcw=true)]
	public partial class ResumableUploadTask : global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask, global::Java.Util.Concurrent.ICallable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResumableUploadTask", typeof (ResumableUploadTask));
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

		protected ResumableUploadTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResumableUploadTask']/constructor[@name='ResumableUploadTask' and count(parameter)=4 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ResumableUploadRequest, com.alibaba.sdk.android.oss.model.ResumableUploadResult&gt;'] and parameter[3][@type='com.alibaba.sdk.android.oss.network.ExecutionContext'] and parameter[4][@type='com.alibaba.sdk.android.oss.internal.InternalRequestOperation']]"
		[Register (".ctor", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;Lcom/alibaba/sdk/android/oss/network/ExecutionContext;Lcom/alibaba/sdk/android/oss/internal/InternalRequestOperation;)V", "")]
		public unsafe ResumableUploadTask (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback, global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext context, global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation apiOperation)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;Lcom/alibaba/sdk/android/oss/network/ExecutionContext;Lcom/alibaba/sdk/android/oss/internal/InternalRequestOperation;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [3] = new JniArgumentValue ((apiOperation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apiOperation).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_abortThisUpload;
#pragma warning disable 0169
		static Delegate GetAbortThisUploadHandler ()
		{
			if (cb_abortThisUpload == null)
				cb_abortThisUpload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AbortThisUpload);
			return cb_abortThisUpload;
		}

		static void n_AbortThisUpload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ResumableUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ResumableUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AbortThisUpload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResumableUploadTask']/method[@name='abortThisUpload' and count(parameter)=0]"
		[Register ("abortThisUpload", "()V", "GetAbortThisUploadHandler")]
		protected override unsafe void AbortThisUpload ()
		{
			const string __id = "abortThisUpload.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_checkPartSize_arrayI;
#pragma warning disable 0169
		static Delegate GetCheckPartSize_arrayIHandler ()
		{
			if (cb_checkPartSize_arrayI == null)
				cb_checkPartSize_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CheckPartSize_arrayI);
			return cb_checkPartSize_arrayI;
		}

		static void n_CheckPartSize_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_partAttr)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ResumableUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ResumableUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] partAttr = (int[]) JNIEnv.GetArray (native_partAttr, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.CheckPartSize (partAttr);
			if (partAttr != null)
				JNIEnv.CopyArray (partAttr, native_partAttr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResumableUploadTask']/method[@name='checkPartSize' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("checkPartSize", "([I)V", "GetCheckPartSize_arrayIHandler")]
		public virtual unsafe void CheckPartSize (int[] partAttr)
		{
			const string __id = "checkPartSize.([I)V";
			IntPtr native_partAttr = JNIEnv.NewArray (partAttr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_partAttr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (partAttr != null) {
					JNIEnv.CopyArray (native_partAttr, partAttr);
					JNIEnv.DeleteLocalRef (native_partAttr);
				}
			}
		}

		static Delegate cb_doMultipartUpload;
#pragma warning disable 0169
		static Delegate GetRawDoMultipartUploadHandler ()
		{
			if (cb_doMultipartUpload == null)
				cb_doMultipartUpload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RawDoMultipartUpload);
			return cb_doMultipartUpload;
		}

		static IntPtr n_RawDoMultipartUpload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ResumableUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ResumableUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawDoMultipartUpload ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResumableUploadTask']/method[@name='doMultipartUpload' and count(parameter)=0]"
		[Register ("doMultipartUpload", "()Lcom/alibaba/sdk/android/oss/model/ResumableUploadResult;", "GetRawDoMultipartUploadHandler")]
		protected virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult RawDoMultipartUpload ()
		{
			const string __id = "doMultipartUpload.()Lcom/alibaba/sdk/android/oss/model/ResumableUploadResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_initMultipartUploadId;
#pragma warning disable 0169
		static Delegate GetInitMultipartUploadIdHandler ()
		{
			if (cb_initMultipartUploadId == null)
				cb_initMultipartUploadId = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitMultipartUploadId);
			return cb_initMultipartUploadId;
		}

		static void n_InitMultipartUploadId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ResumableUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ResumableUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitMultipartUploadId ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResumableUploadTask']/method[@name='initMultipartUploadId' and count(parameter)=0]"
		[Register ("initMultipartUploadId", "()V", "GetInitMultipartUploadIdHandler")]
		protected override unsafe void InitMultipartUploadId ()
		{
			const string __id = "initMultipartUploadId.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_processException_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetProcessException_Ljava_lang_Exception_Handler ()
		{
			if (cb_processException_Ljava_lang_Exception_ == null)
				cb_processException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessException_Ljava_lang_Exception_);
			return cb_processException_Ljava_lang_Exception_;
		}

		static void n_ProcessException_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.ResumableUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.ResumableUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception e = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.ProcessException (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResumableUploadTask']/method[@name='processException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("processException", "(Ljava/lang/Exception;)V", "GetProcessException_Ljava_lang_Exception_Handler")]
		protected override unsafe void ProcessException (global::Java.Lang.Exception e)
		{
			const string __id = "processException.(Ljava/lang/Exception;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
