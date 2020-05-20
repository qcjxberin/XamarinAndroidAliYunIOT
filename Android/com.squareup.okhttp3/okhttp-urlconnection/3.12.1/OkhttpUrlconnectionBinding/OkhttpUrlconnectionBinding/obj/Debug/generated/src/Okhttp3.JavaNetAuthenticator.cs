using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='JavaNetAuthenticator']"
	[global::Android.Runtime.Register ("okhttp3/JavaNetAuthenticator", DoNotGenerateAcw=true)]
	public sealed partial class JavaNetAuthenticator : global::Java.Lang.Object, global::Okhttp3.IAuthenticator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/JavaNetAuthenticator", typeof (JavaNetAuthenticator));
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

		internal JavaNetAuthenticator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='JavaNetAuthenticator']/constructor[@name='JavaNetAuthenticator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JavaNetAuthenticator ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='JavaNetAuthenticator']/method[@name='authenticate' and count(parameter)=2 and parameter[1][@type='okhttp3.Route'] and parameter[2][@type='okhttp3.Response']]"
		[Register ("authenticate", "(Lokhttp3/Route;Lokhttp3/Response;)Lokhttp3/Request;", "")]
		public unsafe global::Okhttp3.Request Authenticate (global::Okhttp3.Route route, global::Okhttp3.Response response)
		{
			const string __id = "authenticate.(Lokhttp3/Route;Lokhttp3/Response;)Lokhttp3/Request;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((route == null) ? IntPtr.Zero : ((global::Java.Lang.Object) route).Handle);
				__args [1] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
