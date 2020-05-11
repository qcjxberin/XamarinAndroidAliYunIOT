using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='LogThreadPoolManager']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/LogThreadPoolManager", DoNotGenerateAcw=true)]
	public partial class LogThreadPoolManager : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='LogThreadPoolManager']/field[@name='mTaskHandler']"
		[Register ("mTaskHandler")]
		protected global::Java.Util.Concurrent.IScheduledFuture MTaskHandler {
			get {
				const string __id = "mTaskHandler.Ljava/util/concurrent/ScheduledFuture;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTaskHandler.Ljava/util/concurrent/ScheduledFuture;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/LogThreadPoolManager", typeof (LogThreadPoolManager));
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

		protected LogThreadPoolManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addExecuteTask_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetAddExecuteTask_Ljava_lang_Runnable_Handler ()
		{
			if (cb_addExecuteTask_Ljava_lang_Runnable_ == null)
				cb_addExecuteTask_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddExecuteTask_Ljava_lang_Runnable_);
			return cb_addExecuteTask_Ljava_lang_Runnable_;
		}

		static void n_AddExecuteTask_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.LogThreadPoolManager __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.LogThreadPoolManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable task = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_task, JniHandleOwnership.DoNotTransfer);
			__this.AddExecuteTask (task);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='LogThreadPoolManager']/method[@name='addExecuteTask' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("addExecuteTask", "(Ljava/lang/Runnable;)V", "GetAddExecuteTask_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void AddExecuteTask (global::Java.Lang.IRunnable task)
		{
			const string __id = "addExecuteTask.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((task == null) ? IntPtr.Zero : ((global::Java.Lang.Object) task).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='LogThreadPoolManager']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/alibaba/sdk/android/oss/common/LogThreadPoolManager;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.LogThreadPoolManager NewInstance ()
		{
			const string __id = "newInstance.()Lcom/alibaba/sdk/android/oss/common/LogThreadPoolManager;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.LogThreadPoolManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
