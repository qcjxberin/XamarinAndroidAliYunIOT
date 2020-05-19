using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='Timeout']"
	[global::Android.Runtime.Register ("okio/Timeout", DoNotGenerateAcw=true)]
	public partial class Timeout : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='okio']/class[@name='Timeout']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Okio.Timeout None {
			get {
				const string __id = "NONE.Lokio/Timeout;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/Timeout", typeof (Timeout));
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

		protected Timeout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='Timeout']/constructor[@name='Timeout' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Timeout ()
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

		static Delegate cb_hasDeadline;
#pragma warning disable 0169
		static Delegate GetHasDeadlineHandler ()
		{
			if (cb_hasDeadline == null)
				cb_hasDeadline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDeadline);
			return cb_hasDeadline;
		}

		static bool n_HasDeadline (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDeadline;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasDeadline {
			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='hasDeadline' and count(parameter)=0]"
			[Register ("hasDeadline", "()Z", "GetHasDeadlineHandler")]
			get {
				const string __id = "hasDeadline.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_clearDeadline;
#pragma warning disable 0169
		static Delegate GetClearDeadlineHandler ()
		{
			if (cb_clearDeadline == null)
				cb_clearDeadline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearDeadline);
			return cb_clearDeadline;
		}

		static IntPtr n_ClearDeadline (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClearDeadline ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='clearDeadline' and count(parameter)=0]"
		[Register ("clearDeadline", "()Lokio/Timeout;", "GetClearDeadlineHandler")]
		public virtual unsafe global::Okio.Timeout ClearDeadline ()
		{
			const string __id = "clearDeadline.()Lokio/Timeout;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clearTimeout;
#pragma warning disable 0169
		static Delegate GetClearTimeoutHandler ()
		{
			if (cb_clearTimeout == null)
				cb_clearTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearTimeout);
			return cb_clearTimeout;
		}

		static IntPtr n_ClearTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClearTimeout ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='clearTimeout' and count(parameter)=0]"
		[Register ("clearTimeout", "()Lokio/Timeout;", "GetClearTimeoutHandler")]
		public virtual unsafe global::Okio.Timeout ClearTimeout ()
		{
			const string __id = "clearTimeout.()Lokio/Timeout;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='deadline' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("deadline", "(JLjava/util/concurrent/TimeUnit;)Lokio/Timeout;", "")]
		public unsafe global::Okio.Timeout Deadline (long duration, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "deadline.(JLjava/util/concurrent/TimeUnit;)Lokio/Timeout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (duration);
				__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deadlineNanoTime;
#pragma warning disable 0169
		static Delegate GetDeadlineNanoTimeHandler ()
		{
			if (cb_deadlineNanoTime == null)
				cb_deadlineNanoTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_DeadlineNanoTime);
			return cb_deadlineNanoTime;
		}

		static long n_DeadlineNanoTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeadlineNanoTime ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='deadlineNanoTime' and count(parameter)=0]"
		[Register ("deadlineNanoTime", "()J", "GetDeadlineNanoTimeHandler")]
		public virtual unsafe long DeadlineNanoTime ()
		{
			const string __id = "deadlineNanoTime.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_deadlineNanoTime_J;
#pragma warning disable 0169
		static Delegate GetDeadlineNanoTime_JHandler ()
		{
			if (cb_deadlineNanoTime_J == null)
				cb_deadlineNanoTime_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_DeadlineNanoTime_J);
			return cb_deadlineNanoTime_J;
		}

		static IntPtr n_DeadlineNanoTime_J (IntPtr jnienv, IntPtr native__this, long deadlineNanoTime)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeadlineNanoTime (deadlineNanoTime));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='deadlineNanoTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("deadlineNanoTime", "(J)Lokio/Timeout;", "GetDeadlineNanoTime_JHandler")]
		public virtual unsafe global::Okio.Timeout DeadlineNanoTime (long deadlineNanoTime)
		{
			const string __id = "deadlineNanoTime.(J)Lokio/Timeout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (deadlineNanoTime);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_throwIfReached;
#pragma warning disable 0169
		static Delegate GetThrowIfReachedHandler ()
		{
			if (cb_throwIfReached == null)
				cb_throwIfReached = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ThrowIfReached);
			return cb_throwIfReached;
		}

		static void n_ThrowIfReached (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ThrowIfReached ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='throwIfReached' and count(parameter)=0]"
		[Register ("throwIfReached", "()V", "GetThrowIfReachedHandler")]
		public virtual unsafe void ThrowIfReached ()
		{
			const string __id = "throwIfReached.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_timeout_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetInvokeTimeout_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_timeout_JLjava_util_concurrent_TimeUnit_ == null)
				cb_timeout_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_InvokeTimeout_JLjava_util_concurrent_TimeUnit_);
			return cb_timeout_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_InvokeTimeout_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeTimeout (timeout, unit));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='timeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;)Lokio/Timeout;", "GetInvokeTimeout_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::Okio.Timeout InvokeTimeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "timeout.(JLjava/util/concurrent/TimeUnit;)Lokio/Timeout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_timeoutNanos;
#pragma warning disable 0169
		static Delegate GetTimeoutNanosHandler ()
		{
			if (cb_timeoutNanos == null)
				cb_timeoutNanos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_TimeoutNanos);
			return cb_timeoutNanos;
		}

		static long n_TimeoutNanos (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeoutNanos ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='timeoutNanos' and count(parameter)=0]"
		[Register ("timeoutNanos", "()J", "GetTimeoutNanosHandler")]
		public virtual unsafe long TimeoutNanos ()
		{
			const string __id = "timeoutNanos.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='waitUntilNotified' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("waitUntilNotified", "(Ljava/lang/Object;)V", "")]
		public unsafe void WaitUntilNotified (global::Java.Lang.Object monitor)
		{
			const string __id = "waitUntilNotified.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
