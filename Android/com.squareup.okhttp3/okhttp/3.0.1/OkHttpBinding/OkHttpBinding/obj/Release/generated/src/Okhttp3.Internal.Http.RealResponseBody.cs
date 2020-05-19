using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealResponseBody']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/RealResponseBody", DoNotGenerateAcw=true)]
	public sealed partial class RealResponseBody : global::Okhttp3.ResponseBody {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/RealResponseBody", typeof (RealResponseBody));
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

		internal RealResponseBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealResponseBody']/method[@name='contentLength' and count(parameter)=0]"
		[Register ("contentLength", "()J", "")]
		public override unsafe long ContentLength ()
		{
			const string __id = "contentLength.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealResponseBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Lokhttp3/MediaType;", "")]
		public override unsafe global::Okhttp3.MediaType ContentType ()
		{
			const string __id = "contentType.()Lokhttp3/MediaType;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
