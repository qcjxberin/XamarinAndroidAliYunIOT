using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionPool']"
	[global::Android.Runtime.Register ("okhttp3/ConnectionPool", DoNotGenerateAcw=true)]
	public sealed partial class ConnectionPool : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/ConnectionPool", typeof (ConnectionPool));
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

		internal ConnectionPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionPool']/constructor[@name='ConnectionPool' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectionPool ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionPool']/constructor[@name='ConnectionPool' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register (".ctor", "(IJLjava/util/concurrent/TimeUnit;)V", "")]
		public unsafe ConnectionPool (int maxIdleConnections, long keepAliveDuration, global::Java.Util.Concurrent.TimeUnit timeUnit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IJLjava/util/concurrent/TimeUnit;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (maxIdleConnections);
				__args [1] = new JniArgumentValue (keepAliveDuration);
				__args [2] = new JniArgumentValue ((timeUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeUnit).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionPool']/method[@name='connectionCount' and count(parameter)=0]"
		[Register ("connectionCount", "()I", "")]
		public unsafe int ConnectionCount ()
		{
			const string __id = "connectionCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionPool']/method[@name='evictAll' and count(parameter)=0]"
		[Register ("evictAll", "()V", "")]
		public unsafe void EvictAll ()
		{
			const string __id = "evictAll.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionPool']/method[@name='idleConnectionCount' and count(parameter)=0]"
		[Register ("idleConnectionCount", "()I", "")]
		public unsafe int IdleConnectionCount ()
		{
			const string __id = "idleConnectionCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
