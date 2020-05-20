using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='ForwardingSource']"
	[global::Android.Runtime.Register ("okio/ForwardingSource", DoNotGenerateAcw=true)]
	public abstract partial class ForwardingSource : global::Java.Lang.Object, global::Okio.ISource {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/ForwardingSource", typeof (ForwardingSource));
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

		protected ForwardingSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='ForwardingSource']/constructor[@name='ForwardingSource' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register (".ctor", "(Lokio/Source;)V", "")]
		public unsafe ForwardingSource (global::Okio.ISource @delegate)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokio/Source;)V";

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
			global::Okio.ForwardingSource __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSource']/method[@name='delegate' and count(parameter)=0]"
		[Register ("delegate", "()Lokio/Source;", "")]
		public unsafe global::Okio.ISource Delegate ()
		{
			const string __id = "delegate.()Lokio/Source;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ISource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_read_Lokio_Buffer_J;
#pragma warning disable 0169
		static Delegate GetRead_Lokio_Buffer_JHandler ()
		{
			if (cb_read_Lokio_Buffer_J == null)
				cb_read_Lokio_Buffer_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long>) n_Read_Lokio_Buffer_J);
			return cb_read_Lokio_Buffer_J;
		}

		static long n_Read_Lokio_Buffer_J (IntPtr jnienv, IntPtr native__this, IntPtr native_sink, long byteCount)
		{
			global::Okio.ForwardingSource __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.Buffer sink = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (native_sink, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Read (sink, byteCount);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSource']/method[@name='read' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("read", "(Lokio/Buffer;J)J", "GetRead_Lokio_Buffer_JHandler")]
		public virtual unsafe long Read (global::Okio.Buffer sink, long byteCount)
		{
			const string __id = "read.(Lokio/Buffer;J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				__args [1] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
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
			global::Okio.ForwardingSource __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Timeout ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSource']/method[@name='timeout' and count(parameter)=0]"
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

	}

	[global::Android.Runtime.Register ("okio/ForwardingSource", DoNotGenerateAcw=true)]
	internal partial class ForwardingSourceInvoker : ForwardingSource {

		public ForwardingSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/ForwardingSource", typeof (ForwardingSourceInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
