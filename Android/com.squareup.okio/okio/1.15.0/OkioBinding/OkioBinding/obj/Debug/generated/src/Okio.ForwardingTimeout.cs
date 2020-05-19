using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='ForwardingTimeout']"
	[global::Android.Runtime.Register ("okio/ForwardingTimeout", DoNotGenerateAcw=true)]
	public partial class ForwardingTimeout : global::Okio.Timeout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/ForwardingTimeout", typeof (ForwardingTimeout));
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

		protected ForwardingTimeout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='ForwardingTimeout']/constructor[@name='ForwardingTimeout' and count(parameter)=1 and parameter[1][@type='okio.Timeout']]"
		[Register (".ctor", "(Lokio/Timeout;)V", "")]
		public unsafe ForwardingTimeout (global::Okio.Timeout @delegate)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokio/Timeout;)V";

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

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingTimeout']/method[@name='delegate' and count(parameter)=0]"
		[Register ("delegate", "()Lokio/Timeout;", "")]
		public unsafe global::Okio.Timeout Delegate ()
		{
			const string __id = "delegate.()Lokio/Timeout;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingTimeout']/method[@name='setDelegate' and count(parameter)=1 and parameter[1][@type='okio.Timeout']]"
		[Register ("setDelegate", "(Lokio/Timeout;)Lokio/ForwardingTimeout;", "")]
		public unsafe global::Okio.ForwardingTimeout SetDelegate (global::Okio.Timeout @delegate)
		{
			const string __id = "setDelegate.(Lokio/Timeout;)Lokio/ForwardingTimeout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@delegate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @delegate).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ForwardingTimeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
