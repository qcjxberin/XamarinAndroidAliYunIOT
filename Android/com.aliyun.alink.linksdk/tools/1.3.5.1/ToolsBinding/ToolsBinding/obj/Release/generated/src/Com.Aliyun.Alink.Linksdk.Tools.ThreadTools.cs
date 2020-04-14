using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ThreadTools']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/ThreadTools", DoNotGenerateAcw=true)]
	public partial class ThreadTools : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ThreadTools.LoopHandler']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/ThreadTools$LoopHandler", DoNotGenerateAcw=true)]
		public sealed partial class LoopHandler : global::Android.OS.Handler {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/ThreadTools$LoopHandler", typeof (LoopHandler));
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

			internal LoopHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ThreadTools.LoopHandler']/constructor[@name='ThreadTools.LoopHandler' and count(parameter)=1 and parameter[1][@type='android.os.Looper']]"
			[Register (".ctor", "(Landroid/os/Looper;)V", "")]
			public unsafe LoopHandler (global::Android.OS.Looper looper)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/os/Looper;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((looper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) looper).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ThreadTools.LoopHandler']/method[@name='enqueue' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("enqueue", "(Ljava/lang/Runnable;)V", "")]
			public unsafe void Enqueue (global::Java.Lang.IRunnable runnable)
			{
				const string __id = "enqueue.(Ljava/lang/Runnable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((runnable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) runnable).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ThreadTools.LoopHandler']/method[@name='enqueue' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='int']]"
			[Register ("enqueue", "(Ljava/lang/Runnable;I)V", "")]
			public unsafe void Enqueue (global::Java.Lang.IRunnable runnable, int delay)
			{
				const string __id = "enqueue.(Ljava/lang/Runnable;I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((runnable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) runnable).Handle);
					__args [1] = new JniArgumentValue (delay);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/ThreadTools", typeof (ThreadTools));
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

		protected ThreadTools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ThreadTools']/constructor[@name='ThreadTools' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadTools ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ThreadTools']/method[@name='getProcessName' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getProcessName", "(Landroid/content/Context;I)Ljava/lang/String;", "")]
		public static unsafe string GetProcessName (global::Android.Content.Context context, int pid)
		{
			const string __id = "getProcessName.(Landroid/content/Context;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (pid);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ThreadTools']/method[@name='isAppBroughtToBackgroundByTask' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("isAppBroughtToBackgroundByTask", "(Landroid/app/Application;)Z", "")]
		public static unsafe bool IsAppBroughtToBackgroundByTask (global::Android.App.Application app)
		{
			const string __id = "isAppBroughtToBackgroundByTask.(Landroid/app/Application;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ThreadTools']/method[@name='runOnUiThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runOnUiThread", "(Ljava/lang/Runnable;)V", "")]
		public static unsafe void RunOnUiThread (global::Java.Lang.IRunnable runnable)
		{
			const string __id = "runOnUiThread.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((runnable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) runnable).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ThreadTools']/method[@name='submitTask' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='boolean']]"
		[Register ("submitTask", "(Ljava/lang/Runnable;Z)V", "")]
		public static unsafe void SubmitTask (global::Java.Lang.IRunnable r, bool isRunOnUIThread)
		{
			const string __id = "submitTask.(Ljava/lang/Runnable;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				__args [1] = new JniArgumentValue (isRunOnUIThread);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ThreadTools']/method[@name='submitTask' and count(parameter)=3 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("submitTask", "(Ljava/lang/Runnable;ZI)V", "")]
		public static unsafe void SubmitTask (global::Java.Lang.IRunnable r, bool isRunOnUIThread, int delayInMillion)
		{
			const string __id = "submitTask.(Ljava/lang/Runnable;ZI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				__args [1] = new JniArgumentValue (isRunOnUIThread);
				__args [2] = new JniArgumentValue (delayInMillion);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
