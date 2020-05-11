using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/BaseMultipartUploadTask", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Request extends com.alibaba.sdk.android.oss.model.MultipartUploadRequest", "Result extends com.alibaba.sdk.android.oss.model.CompleteMultipartUploadResult"})]
	public abstract partial class BaseMultipartUploadTask : global::Java.Lang.Object, global::Java.Util.Concurrent.ICallable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='CPU_SIZE']"
		[Register ("CPU_SIZE")]
		protected int CpuSize {
			get {
				const string __id = "CPU_SIZE.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "CPU_SIZE.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='KEEP_ALIVE_TIME']"
		[Register ("KEEP_ALIVE_TIME")]
		protected int KeepAliveTime {
			get {
				const string __id = "KEEP_ALIVE_TIME.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "KEEP_ALIVE_TIME.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='MAX_CORE_POOL_SIZE']"
		[Register ("MAX_CORE_POOL_SIZE")]
		protected int MaxCorePoolSize {
			get {
				const string __id = "MAX_CORE_POOL_SIZE.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "MAX_CORE_POOL_SIZE.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='MAX_IMUM_POOL_SIZE']"
		[Register ("MAX_IMUM_POOL_SIZE")]
		protected int MaxImumPoolSize {
			get {
				const string __id = "MAX_IMUM_POOL_SIZE.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "MAX_IMUM_POOL_SIZE.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='MAX_QUEUE_SIZE']"
		[Register ("MAX_QUEUE_SIZE")]
		protected int MaxQueueSize {
			get {
				const string __id = "MAX_QUEUE_SIZE.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "MAX_QUEUE_SIZE.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mApiOperation']"
		[Register ("mApiOperation")]
		protected global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation MApiOperation {
			get {
				const string __id = "mApiOperation.Lcom/alibaba/sdk/android/oss/internal/InternalRequestOperation;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mApiOperation.Lcom/alibaba/sdk/android/oss/internal/InternalRequestOperation;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mCheckCRC64']"
		[Register ("mCheckCRC64")]
		protected bool MCheckCRC64 {
			get {
				const string __id = "mCheckCRC64.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mCheckCRC64.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mCompletedCallback']"
		[Register ("mCompletedCallback")]
		protected global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback MCompletedCallback {
			get {
				const string __id = "mCompletedCallback.Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCompletedCallback.Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext MContext {
			get {
				const string __id = "mContext.Lcom/alibaba/sdk/android/oss/network/ExecutionContext;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContext.Lcom/alibaba/sdk/android/oss/network/ExecutionContext;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mFileLength']"
		[Register ("mFileLength")]
		protected long MFileLength {
			get {
				const string __id = "mFileLength.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mFileLength.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mIsCancel']"
		[Register ("mIsCancel")]
		protected bool MIsCancel {
			get {
				const string __id = "mIsCancel.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIsCancel.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mLock']"
		[Register ("mLock")]
		protected global::Java.Lang.Object MLock {
			get {
				const string __id = "mLock.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLock.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mPartETags']"
		[Register ("mPartETags")]
		protected global::System.Collections.IList MPartETags {
			get {
				const string __id = "mPartETags.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPartETags.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mPartExceptionCount']"
		[Register ("mPartExceptionCount")]
		protected int MPartExceptionCount {
			get {
				const string __id = "mPartExceptionCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mPartExceptionCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mPoolExecutor']"
		[Register ("mPoolExecutor")]
		protected global::Java.Util.Concurrent.ThreadPoolExecutor MPoolExecutor {
			get {
				const string __id = "mPoolExecutor.Ljava/util/concurrent/ThreadPoolExecutor;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ThreadPoolExecutor> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPoolExecutor.Ljava/util/concurrent/ThreadPoolExecutor;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mProgressCallback']"
		[Register ("mProgressCallback")]
		protected global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback MProgressCallback {
			get {
				const string __id = "mProgressCallback.Lcom/alibaba/sdk/android/oss/callback/OSSProgressCallback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSProgressCallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mProgressCallback.Lcom/alibaba/sdk/android/oss/callback/OSSProgressCallback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mRequest']"
		[Register ("mRequest")]
		protected global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest MRequest {
			get {
				const string __id = "mRequest.Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRequest.Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mRunPartTaskCount']"
		[Register ("mRunPartTaskCount")]
		protected int MRunPartTaskCount {
			get {
				const string __id = "mRunPartTaskCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mRunPartTaskCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mUploadException']"
		[Register ("mUploadException")]
		protected global::Java.Lang.Exception MUploadException {
			get {
				const string __id = "mUploadException.Ljava/lang/Exception;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mUploadException.Ljava/lang/Exception;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mUploadFile']"
		[Register ("mUploadFile")]
		protected global::Java.IO.File MUploadFile {
			get {
				const string __id = "mUploadFile.Ljava/io/File;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mUploadFile.Ljava/io/File;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mUploadId']"
		[Register ("mUploadId")]
		protected string MUploadId {
			get {
				const string __id = "mUploadId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mUploadId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/field[@name='mUploadedLength']"
		[Register ("mUploadedLength")]
		protected long MUploadedLength {
			get {
				const string __id = "mUploadedLength.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mUploadedLength.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/BaseMultipartUploadTask", typeof (BaseMultipartUploadTask));
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

		protected BaseMultipartUploadTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/constructor[@name='BaseMultipartUploadTask' and count(parameter)=4 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.InternalRequestOperation'] and parameter[2][@type='Request'] and parameter[3][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;Request, Result&gt;'] and parameter[4][@type='com.alibaba.sdk.android.oss.network.ExecutionContext']]"
		[Register (".ctor", "(Lcom/alibaba/sdk/android/oss/internal/InternalRequestOperation;Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;Lcom/alibaba/sdk/android/oss/network/ExecutionContext;)V", "")]
		public unsafe BaseMultipartUploadTask (global::Com.Alibaba.Sdk.Android.Oss.Internal.InternalRequestOperation operation, global::Java.Lang.Object request, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback completedCallback, global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/alibaba/sdk/android/oss/internal/InternalRequestOperation;Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;Lcom/alibaba/sdk/android/oss/network/ExecutionContext;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_request = JNIEnv.ToLocalJniHandle (request);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((operation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) operation).Handle);
				__args [1] = new JniArgumentValue (native_request);
				__args [2] = new JniArgumentValue ((completedCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completedCallback).Handle);
				__args [3] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_request);
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
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AbortThisUpload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='abortThisUpload' and count(parameter)=0]"
		[Register ("abortThisUpload", "()V", "GetAbortThisUploadHandler")]
		protected abstract void AbortThisUpload ();

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;", "GetCallHandler")]
		public virtual unsafe global::Java.Lang.Object Call ()
		{
			const string __id = "call.()Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_checkCancel;
#pragma warning disable 0169
		static Delegate GetCheckCancelHandler ()
		{
			if (cb_checkCancel == null)
				cb_checkCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckCancel);
			return cb_checkCancel;
		}

		static void n_CheckCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckCancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='checkCancel' and count(parameter)=0]"
		[Register ("checkCancel", "()V", "GetCheckCancelHandler")]
		protected virtual unsafe void CheckCancel ()
		{
			const string __id = "checkCancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_checkException;
#pragma warning disable 0169
		static Delegate GetCheckExceptionHandler ()
		{
			if (cb_checkException == null)
				cb_checkException = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckException);
			return cb_checkException;
		}

		static void n_CheckException (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckException ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='checkException' and count(parameter)=0]"
		[Register ("checkException", "()V", "GetCheckExceptionHandler")]
		protected virtual unsafe void CheckException ()
		{
			const string __id = "checkException.()V";
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
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] partAttr = (int[]) JNIEnv.GetArray (native_partAttr, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.CheckPartSize (partAttr);
			if (partAttr != null)
				JNIEnv.CopyArray (partAttr, native_partAttr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='checkPartSize' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("checkPartSize", "([I)V", "GetCheckPartSize_arrayIHandler")]
		protected virtual unsafe void CheckPartSize (int[] partAttr)
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

		static Delegate cb_checkWaitCondition_I;
#pragma warning disable 0169
		static Delegate GetCheckWaitCondition_IHandler ()
		{
			if (cb_checkWaitCondition_I == null)
				cb_checkWaitCondition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_CheckWaitCondition_I);
			return cb_checkWaitCondition_I;
		}

		static bool n_CheckWaitCondition_I (IntPtr jnienv, IntPtr native__this, int partNum)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckWaitCondition (partNum);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='checkWaitCondition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkWaitCondition", "(I)Z", "GetCheckWaitCondition_IHandler")]
		protected virtual unsafe bool CheckWaitCondition (int partNum)
		{
			const string __id = "checkWaitCondition.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (partNum);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_completeMultipartUploadResult;
#pragma warning disable 0169
		static Delegate GetCompleteMultipartUploadResultHandler ()
		{
			if (cb_completeMultipartUploadResult == null)
				cb_completeMultipartUploadResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CompleteMultipartUploadResult);
			return cb_completeMultipartUploadResult;
		}

		static IntPtr n_CompleteMultipartUploadResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CompleteMultipartUploadResult ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='completeMultipartUploadResult' and count(parameter)=0]"
		[Register ("completeMultipartUploadResult", "()Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;", "GetCompleteMultipartUploadResultHandler")]
		protected virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult CompleteMultipartUploadResult ()
		{
			const string __id = "completeMultipartUploadResult.()Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_doMultipartUpload;
#pragma warning disable 0169
		static Delegate GetDoMultipartUploadHandler ()
		{
			if (cb_doMultipartUpload == null)
				cb_doMultipartUpload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DoMultipartUpload);
			return cb_doMultipartUpload;
		}

		static IntPtr n_DoMultipartUpload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DoMultipartUpload ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='doMultipartUpload' and count(parameter)=0]"
		[Register ("doMultipartUpload", "()Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;", "GetDoMultipartUploadHandler")]
		protected abstract global::Java.Lang.Object DoMultipartUpload ();

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
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitMultipartUploadId ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='initMultipartUploadId' and count(parameter)=0]"
		[Register ("initMultipartUploadId", "()V", "GetInitMultipartUploadIdHandler")]
		protected abstract void InitMultipartUploadId ();

		static Delegate cb_notifyMultipartThread;
#pragma warning disable 0169
		static Delegate GetNotifyMultipartThreadHandler ()
		{
			if (cb_notifyMultipartThread == null)
				cb_notifyMultipartThread = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyMultipartThread);
			return cb_notifyMultipartThread;
		}

		static void n_NotifyMultipartThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyMultipartThread ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='notifyMultipartThread' and count(parameter)=0]"
		[Register ("notifyMultipartThread", "()V", "GetNotifyMultipartThreadHandler")]
		protected virtual unsafe void NotifyMultipartThread ()
		{
			const string __id = "notifyMultipartThread.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onProgressCallback_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_JJ;
#pragma warning disable 0169
		static Delegate GetOnProgressCallback_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_JJHandler ()
		{
			if (cb_onProgressCallback_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_JJ == null)
				cb_onProgressCallback_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, long>) n_OnProgressCallback_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_JJ);
			return cb_onProgressCallback_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_JJ;
		}

		static void n_OnProgressCallback_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, long currentSize, long totalSize)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object request = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.OnProgressCallback (request, currentSize, totalSize);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='onProgressCallback' and count(parameter)=3 and parameter[1][@type='Request'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onProgressCallback", "(Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;JJ)V", "GetOnProgressCallback_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_JJHandler")]
		protected virtual unsafe void OnProgressCallback (global::Java.Lang.Object request, long currentSize, long totalSize)
		{
			const string __id = "onProgressCallback.(Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;JJ)V";
			IntPtr native_request = JNIEnv.ToLocalJniHandle (request);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_request);
				__args [1] = new JniArgumentValue (currentSize);
				__args [2] = new JniArgumentValue (totalSize);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_request);
			}
		}

		static Delegate cb_preUploadPart_III;
#pragma warning disable 0169
		static Delegate GetPreUploadPart_IIIHandler ()
		{
			if (cb_preUploadPart_III == null)
				cb_preUploadPart_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_PreUploadPart_III);
			return cb_preUploadPart_III;
		}

		static void n_PreUploadPart_III (IntPtr jnienv, IntPtr native__this, int readIndex, int byteCount, int partNumber)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreUploadPart (readIndex, byteCount, partNumber);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='preUploadPart' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("preUploadPart", "(III)V", "GetPreUploadPart_IIIHandler")]
		protected virtual unsafe void PreUploadPart (int readIndex, int byteCount, int partNumber)
		{
			const string __id = "preUploadPart.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (readIndex);
				__args [1] = new JniArgumentValue (byteCount);
				__args [2] = new JniArgumentValue (partNumber);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		static void n_ProcessException_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessException (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='processException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("processException", "(Ljava/lang/Exception;)V", "GetProcessException_Ljava_lang_Exception_Handler")]
		protected abstract void ProcessException (global::Java.Lang.Exception p0);

		static Delegate cb_releasePool;
#pragma warning disable 0169
		static Delegate GetReleasePoolHandler ()
		{
			if (cb_releasePool == null)
				cb_releasePool = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleasePool);
			return cb_releasePool;
		}

		static void n_ReleasePool (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleasePool ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='releasePool' and count(parameter)=0]"
		[Register ("releasePool", "()V", "GetReleasePoolHandler")]
		protected virtual unsafe void ReleasePool ()
		{
			const string __id = "releasePool.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_uploadPart_III;
#pragma warning disable 0169
		static Delegate GetUploadPart_IIIHandler ()
		{
			if (cb_uploadPart_III == null)
				cb_uploadPart_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_UploadPart_III);
			return cb_uploadPart_III;
		}

		static void n_UploadPart_III (IntPtr jnienv, IntPtr native__this, int readIndex, int byteCount, int partNumber)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UploadPart (readIndex, byteCount, partNumber);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='uploadPart' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("uploadPart", "(III)V", "GetUploadPart_IIIHandler")]
		protected virtual unsafe void UploadPart (int readIndex, int byteCount, int partNumber)
		{
			const string __id = "uploadPart.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (readIndex);
				__args [1] = new JniArgumentValue (byteCount);
				__args [2] = new JniArgumentValue (partNumber);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_uploadPartFinish_Lcom_alibaba_sdk_android_oss_model_PartETag_;
#pragma warning disable 0169
		static Delegate GetUploadPartFinish_Lcom_alibaba_sdk_android_oss_model_PartETag_Handler ()
		{
			if (cb_uploadPartFinish_Lcom_alibaba_sdk_android_oss_model_PartETag_ == null)
				cb_uploadPartFinish_Lcom_alibaba_sdk_android_oss_model_PartETag_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UploadPartFinish_Lcom_alibaba_sdk_android_oss_model_PartETag_);
			return cb_uploadPartFinish_Lcom_alibaba_sdk_android_oss_model_PartETag_;
		}

		static void n_UploadPartFinish_Lcom_alibaba_sdk_android_oss_model_PartETag_ (IntPtr jnienv, IntPtr native__this, IntPtr native_partETag)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag partETag = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag> (native_partETag, JniHandleOwnership.DoNotTransfer);
			__this.UploadPartFinish (partETag);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='uploadPartFinish' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.PartETag']]"
		[Register ("uploadPartFinish", "(Lcom/alibaba/sdk/android/oss/model/PartETag;)V", "GetUploadPartFinish_Lcom_alibaba_sdk_android_oss_model_PartETag_Handler")]
		protected virtual unsafe void UploadPartFinish (global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag partETag)
		{
			const string __id = "uploadPartFinish.(Lcom/alibaba/sdk/android/oss/model/PartETag;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((partETag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) partETag).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/BaseMultipartUploadTask", DoNotGenerateAcw=true)]
	internal partial class BaseMultipartUploadTaskInvoker : BaseMultipartUploadTask {

		public BaseMultipartUploadTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/BaseMultipartUploadTask", typeof (BaseMultipartUploadTaskInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='abortThisUpload' and count(parameter)=0]"
		[Register ("abortThisUpload", "()V", "GetAbortThisUploadHandler")]
		protected override unsafe void AbortThisUpload ()
		{
			const string __id = "abortThisUpload.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='doMultipartUpload' and count(parameter)=0]"
		[Register ("doMultipartUpload", "()Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;", "GetDoMultipartUploadHandler")]
		protected override unsafe global::Java.Lang.Object DoMultipartUpload ()
		{
			const string __id = "doMultipartUpload.()Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='initMultipartUploadId' and count(parameter)=0]"
		[Register ("initMultipartUploadId", "()V", "GetInitMultipartUploadIdHandler")]
		protected override unsafe void InitMultipartUploadId ()
		{
			const string __id = "initMultipartUploadId.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='BaseMultipartUploadTask']/method[@name='processException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("processException", "(Ljava/lang/Exception;)V", "GetProcessException_Ljava_lang_Exception_Handler")]
		protected override unsafe void ProcessException (global::Java.Lang.Exception p0)
		{
			const string __id = "processException.(Ljava/lang/Exception;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
