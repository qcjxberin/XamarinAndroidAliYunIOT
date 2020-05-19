using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']"
	[global::Android.Runtime.Register ("okio/ForwardingSink", DoNotGenerateAcw=true)]
	public abstract partial class ForwardingSink : global::Java.Lang.Object, global::Okio.ISink {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/ForwardingSink", typeof (ForwardingSink));
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

		protected ForwardingSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']/constructor[@name='ForwardingSink' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register (".ctor", "(Lokio/Sink;)V", "")]
		public unsafe ForwardingSink (global::Okio.ISink @delegate)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokio/Sink;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@delegate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @delegate).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ForwardingSink __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']/method[@name='delegate' and count(parameter)=0]"
		[Register ("delegate", "()Lokio/Sink;", "")]
		public unsafe global::Okio.ISink Delegate ()
		{
			const string __id = "delegate.()Lokio/Sink;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ISink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ForwardingSink __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_timeout;
#pragma warning disable 0169
		static Delegate GetTimeoutHandler ()
		{
			if (cb_timeout == null)
				cb_timeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Timeout);
			return cb_timeout;
		}

		static IntPtr n_Timeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ForwardingSink __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Timeout ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']/method[@name='timeout' and count(parameter)=0]"
		[Register ("timeout", "()Lokio/Timeout;", "GetTimeoutHandler")]
		public virtual unsafe global::Okio.Timeout Timeout ()
		{
			const string __id = "timeout.()Lokio/Timeout;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_write_Lokio_Buffer_J;
#pragma warning disable 0169
		static Delegate GetWrite_Lokio_Buffer_JHandler ()
		{
			if (cb_write_Lokio_Buffer_J == null)
				cb_write_Lokio_Buffer_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_Write_Lokio_Buffer_J);
			return cb_write_Lokio_Buffer_J;
		}

		static void n_Write_Lokio_Buffer_J (IntPtr jnienv, IntPtr native__this, IntPtr native_source, long byteCount)
		{
			global::Okio.ForwardingSink __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.Buffer source = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (native_source, JniHandleOwnership.DoNotTransfer);
			__this.Write (source, byteCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("write", "(Lokio/Buffer;J)V", "GetWrite_Lokio_Buffer_JHandler")]
		public virtual unsafe void Write (global::Okio.Buffer source, long byteCount)
		{
			const string __id = "write.(Lokio/Buffer;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue (byteCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("okio/ForwardingSink", DoNotGenerateAcw=true)]
	internal partial class ForwardingSinkInvoker : ForwardingSink {

		public ForwardingSinkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/ForwardingSink", typeof (ForwardingSinkInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
