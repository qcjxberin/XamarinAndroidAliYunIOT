using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteException']"
	[global::Android.Runtime.Register ("okhttp3/internal/connection/RouteException", DoNotGenerateAcw=true)]
	public sealed partial class RouteException : global::Java.Lang.RuntimeException {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/connection/RouteException", typeof (RouteException));
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

		internal RouteException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteException']/constructor[@name='RouteException' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register (".ctor", "(Ljava/io/IOException;)V", "")]
		public unsafe RouteException (global::Java.IO.IOException cause)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/IOException;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::Java.IO.IOException FirstConnectException {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteException']/method[@name='getFirstConnectException' and count(parameter)=0]"
			[Register ("getFirstConnectException", "()Ljava/io/IOException;", "")]
			get {
				const string __id = "getFirstConnectException.()Ljava/io/IOException;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.IO.IOException LastConnectException {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteException']/method[@name='getLastConnectException' and count(parameter)=0]"
			[Register ("getLastConnectException", "()Ljava/io/IOException;", "")]
			get {
				const string __id = "getLastConnectException.()Ljava/io/IOException;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteException']/method[@name='addConnectException' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("addConnectException", "(Ljava/io/IOException;)V", "")]
		public unsafe void AddConnectException (global::Java.IO.IOException e)
		{
			const string __id = "addConnectException.(Ljava/io/IOException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
