using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']"
	[global::Android.Runtime.Register ("okio/AsyncTimeout", DoNotGenerateAcw=true)]
	public partial class AsyncTimeout : global::Okio.Timeout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/AsyncTimeout", typeof (AsyncTimeout));
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

		protected AsyncTimeout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/constructor[@name='AsyncTimeout' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncTimeout ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/method[@name='enter' and count(parameter)=0]"
		[Register ("enter", "()V", "")]
		public unsafe void Enter ()
		{
			const string __id = "enter.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/method[@name='exit' and count(parameter)=0]"
		[Register ("exit", "()Z", "")]
		public unsafe bool Exit ()
		{
			const string __id = "exit.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_newTimeoutException_Ljava_io_IOException_;
#pragma warning disable 0169
		static Delegate GetNewTimeoutException_Ljava_io_IOException_Handler ()
		{
			if (cb_newTimeoutException_Ljava_io_IOException_ == null)
				cb_newTimeoutException_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewTimeoutException_Ljava_io_IOException_);
			return cb_newTimeoutException_Ljava_io_IOException_;
		}

		static IntPtr n_NewTimeoutException_Ljava_io_IOException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			global::Okio.AsyncTimeout __this = global::Java.Lang.Object.GetObject<global::Okio.AsyncTimeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.IOException cause = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_cause, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewTimeoutException (cause));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/method[@name='newTimeoutException' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("newTimeoutException", "(Ljava/io/IOException;)Ljava/io/IOException;", "GetNewTimeoutException_Ljava_io_IOException_Handler")]
		protected virtual unsafe global::Java.IO.IOException NewTimeoutException (global::Java.IO.IOException cause)
		{
			const string __id = "newTimeoutException.(Ljava/io/IOException;)Ljava/io/IOException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/method[@name='sink' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register ("sink", "(Lokio/Sink;)Lokio/Sink;", "")]
		public unsafe global::Okio.ISink Sink (global::Okio.ISink sink)
		{
			const string __id = "sink.(Lokio/Sink;)Lokio/Sink;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ISink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/method[@name='source' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register ("source", "(Lokio/Source;)Lokio/Source;", "")]
		public unsafe global::Okio.ISource Source (global::Okio.ISource source)
		{
			const string __id = "source.(Lokio/Source;)Lokio/Source;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ISource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_timedOut;
#pragma warning disable 0169
		static Delegate GetTimedOutHandler ()
		{
			if (cb_timedOut == null)
				cb_timedOut = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TimedOut);
			return cb_timedOut;
		}

		static void n_TimedOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.AsyncTimeout __this = global::Java.Lang.Object.GetObject<global::Okio.AsyncTimeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TimedOut ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/method[@name='timedOut' and count(parameter)=0]"
		[Register ("timedOut", "()V", "GetTimedOutHandler")]
		protected virtual unsafe void TimedOut ()
		{
			const string __id = "timedOut.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
