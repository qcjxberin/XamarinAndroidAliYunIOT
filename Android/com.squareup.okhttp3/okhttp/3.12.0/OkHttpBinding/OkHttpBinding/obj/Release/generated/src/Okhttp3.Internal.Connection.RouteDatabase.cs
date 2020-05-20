using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteDatabase']"
	[global::Android.Runtime.Register ("okhttp3/internal/connection/RouteDatabase", DoNotGenerateAcw=true)]
	public sealed partial class RouteDatabase : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/connection/RouteDatabase", typeof (RouteDatabase));
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

		internal RouteDatabase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteDatabase']/constructor[@name='RouteDatabase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RouteDatabase ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteDatabase']/method[@name='connected' and count(parameter)=1 and parameter[1][@type='okhttp3.Route']]"
		[Register ("connected", "(Lokhttp3/Route;)V", "")]
		public unsafe void Connected (global::Okhttp3.Route route)
		{
			const string __id = "connected.(Lokhttp3/Route;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((route == null) ? IntPtr.Zero : ((global::Java.Lang.Object) route).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteDatabase']/method[@name='failed' and count(parameter)=1 and parameter[1][@type='okhttp3.Route']]"
		[Register ("failed", "(Lokhttp3/Route;)V", "")]
		public unsafe void Failed (global::Okhttp3.Route failedRoute)
		{
			const string __id = "failed.(Lokhttp3/Route;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((failedRoute == null) ? IntPtr.Zero : ((global::Java.Lang.Object) failedRoute).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteDatabase']/method[@name='shouldPostpone' and count(parameter)=1 and parameter[1][@type='okhttp3.Route']]"
		[Register ("shouldPostpone", "(Lokhttp3/Route;)Z", "")]
		public unsafe bool ShouldPostpone (global::Okhttp3.Route route)
		{
			const string __id = "shouldPostpone.(Lokhttp3/Route;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((route == null) ? IntPtr.Zero : ((global::Java.Lang.Object) route).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
