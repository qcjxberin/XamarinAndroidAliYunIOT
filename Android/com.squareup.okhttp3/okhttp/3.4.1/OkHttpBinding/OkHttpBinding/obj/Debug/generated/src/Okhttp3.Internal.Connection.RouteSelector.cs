using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteSelector']"
	[global::Android.Runtime.Register ("okhttp3/internal/connection/RouteSelector", DoNotGenerateAcw=true)]
	public sealed partial class RouteSelector : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/connection/RouteSelector", typeof (RouteSelector));
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

		internal RouteSelector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteSelector']/constructor[@name='RouteSelector' and count(parameter)=2 and parameter[1][@type='okhttp3.Address'] and parameter[2][@type='okhttp3.internal.connection.RouteDatabase']]"
		[Register (".ctor", "(Lokhttp3/Address;Lokhttp3/internal/connection/RouteDatabase;)V", "")]
		public unsafe RouteSelector (global::Okhttp3.Address address, global::Okhttp3.Internal.Connection.RouteDatabase routeDatabase)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/Address;Lokhttp3/internal/connection/RouteDatabase;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((address == null) ? IntPtr.Zero : ((global::Java.Lang.Object) address).Handle);
				__args [1] = new JniArgumentValue ((routeDatabase == null) ? IntPtr.Zero : ((global::Java.Lang.Object) routeDatabase).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteSelector']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteSelector']/method[@name='connectFailed' and count(parameter)=2 and parameter[1][@type='okhttp3.Route'] and parameter[2][@type='java.io.IOException']]"
		[Register ("connectFailed", "(Lokhttp3/Route;Ljava/io/IOException;)V", "")]
		public unsafe void ConnectFailed (global::Okhttp3.Route failedRoute, global::Java.IO.IOException failure)
		{
			const string __id = "connectFailed.(Lokhttp3/Route;Ljava/io/IOException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((failedRoute == null) ? IntPtr.Zero : ((global::Java.Lang.Object) failedRoute).Handle);
				__args [1] = new JniArgumentValue ((failure == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) failure).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteSelector']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Lokhttp3/Route;", "")]
		public unsafe global::Okhttp3.Route Next ()
		{
			const string __id = "next.()Lokhttp3/Route;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Route> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
