using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Framed {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Ping']"
	[global::Android.Runtime.Register ("okhttp3/internal/framed/Ping", DoNotGenerateAcw=true)]
	public sealed partial class Ping : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/Ping", typeof (Ping));
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

		internal Ping (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Ping']/method[@name='roundTripTime' and count(parameter)=0]"
		[Register ("roundTripTime", "()J", "")]
		public unsafe long RoundTripTime ()
		{
			const string __id = "roundTripTime.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Ping']/method[@name='roundTripTime' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("roundTripTime", "(JLjava/util/concurrent/TimeUnit;)J", "")]
		public unsafe long RoundTripTime (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "roundTripTime.(JLjava/util/concurrent/TimeUnit;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
