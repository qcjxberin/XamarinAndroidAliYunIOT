using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']"
	[global::Android.Runtime.Register ("okhttp3/Dispatcher", DoNotGenerateAcw=true)]
	public sealed partial class Dispatcher : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Dispatcher", typeof (Dispatcher));
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

		internal Dispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/constructor[@name='Dispatcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Dispatcher ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/constructor[@name='Dispatcher' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutorService']]"
		[Register (".ctor", "(Ljava/util/concurrent/ExecutorService;)V", "")]
		public unsafe Dispatcher (global::Java.Util.Concurrent.IExecutorService executorService)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/concurrent/ExecutorService;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe int MaxRequests {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='getMaxRequests' and count(parameter)=0]"
			[Register ("getMaxRequests", "()I", "")]
			get {
				const string __id = "getMaxRequests.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='setMaxRequests' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxRequests", "(I)V", "")]
			set {
				const string __id = "setMaxRequests.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int MaxRequestsPerHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='getMaxRequestsPerHost' and count(parameter)=0]"
			[Register ("getMaxRequestsPerHost", "()I", "")]
			get {
				const string __id = "getMaxRequestsPerHost.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='setMaxRequestsPerHost' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxRequestsPerHost", "(I)V", "")]
			set {
				const string __id = "setMaxRequestsPerHost.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='cancelAll' and count(parameter)=0]"
		[Register ("cancelAll", "()V", "")]
		public unsafe void CancelAll ()
		{
			const string __id = "cancelAll.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='executorService' and count(parameter)=0]"
		[Register ("executorService", "()Ljava/util/concurrent/ExecutorService;", "")]
		public unsafe global::Java.Util.Concurrent.IExecutorService ExecutorService ()
		{
			const string __id = "executorService.()Ljava/util/concurrent/ExecutorService;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='queuedCalls' and count(parameter)=0]"
		[Register ("queuedCalls", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.ICall> QueuedCalls ()
		{
			const string __id = "queuedCalls.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Okhttp3.ICall>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='queuedCallsCount' and count(parameter)=0]"
		[Register ("queuedCallsCount", "()I", "")]
		public unsafe int QueuedCallsCount ()
		{
			const string __id = "queuedCallsCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='runningCalls' and count(parameter)=0]"
		[Register ("runningCalls", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.ICall> RunningCalls ()
		{
			const string __id = "runningCalls.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Okhttp3.ICall>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='runningCallsCount' and count(parameter)=0]"
		[Register ("runningCallsCount", "()I", "")]
		public unsafe int RunningCallsCount ()
		{
			const string __id = "runningCallsCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='setIdleCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setIdleCallback", "(Ljava/lang/Runnable;)V", "")]
		public unsafe void SetIdleCallback (global::Java.Lang.IRunnable idleCallback)
		{
			const string __id = "setIdleCallback.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((idleCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) idleCallback).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
