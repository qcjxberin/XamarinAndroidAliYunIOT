using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Framed {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='HeadersMode']"
	[global::Android.Runtime.Register ("okhttp3/internal/framed/HeadersMode", DoNotGenerateAcw=true)]
	public sealed partial class HeadersMode : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='HeadersMode']/field[@name='HTTP_20_HEADERS']"
		[Register ("HTTP_20_HEADERS")]
		public static global::Okhttp3.Internal.Framed.HeadersMode Http20Headers {
			get {
				const string __id = "HTTP_20_HEADERS.Lokhttp3/internal/framed/HeadersMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.HeadersMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='HeadersMode']/field[@name='SPDY_HEADERS']"
		[Register ("SPDY_HEADERS")]
		public static global::Okhttp3.Internal.Framed.HeadersMode SpdyHeaders {
			get {
				const string __id = "SPDY_HEADERS.Lokhttp3/internal/framed/HeadersMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.HeadersMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='HeadersMode']/field[@name='SPDY_REPLY']"
		[Register ("SPDY_REPLY")]
		public static global::Okhttp3.Internal.Framed.HeadersMode SpdyReply {
			get {
				const string __id = "SPDY_REPLY.Lokhttp3/internal/framed/HeadersMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.HeadersMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='HeadersMode']/field[@name='SPDY_SYN_STREAM']"
		[Register ("SPDY_SYN_STREAM")]
		public static global::Okhttp3.Internal.Framed.HeadersMode SpdySynStream {
			get {
				const string __id = "SPDY_SYN_STREAM.Lokhttp3/internal/framed/HeadersMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.HeadersMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/HeadersMode", typeof (HeadersMode));
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

		internal HeadersMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='HeadersMode']/method[@name='failIfHeadersAbsent' and count(parameter)=0]"
		[Register ("failIfHeadersAbsent", "()Z", "")]
		public unsafe bool FailIfHeadersAbsent ()
		{
			const string __id = "failIfHeadersAbsent.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='HeadersMode']/method[@name='failIfHeadersPresent' and count(parameter)=0]"
		[Register ("failIfHeadersPresent", "()Z", "")]
		public unsafe bool FailIfHeadersPresent ()
		{
			const string __id = "failIfHeadersPresent.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='HeadersMode']/method[@name='failIfStreamAbsent' and count(parameter)=0]"
		[Register ("failIfStreamAbsent", "()Z", "")]
		public unsafe bool FailIfStreamAbsent ()
		{
			const string __id = "failIfStreamAbsent.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='HeadersMode']/method[@name='failIfStreamPresent' and count(parameter)=0]"
		[Register ("failIfStreamPresent", "()Z", "")]
		public unsafe bool FailIfStreamPresent ()
		{
			const string __id = "failIfStreamPresent.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='HeadersMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lokhttp3/internal/framed/HeadersMode;", "")]
		public static unsafe global::Okhttp3.Internal.Framed.HeadersMode ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lokhttp3/internal/framed/HeadersMode;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.HeadersMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='HeadersMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lokhttp3/internal/framed/HeadersMode;", "")]
		public static unsafe global::Okhttp3.Internal.Framed.HeadersMode[] Values ()
		{
			const string __id = "values.()[Lokhttp3/internal/framed/HeadersMode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Okhttp3.Internal.Framed.HeadersMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Okhttp3.Internal.Framed.HeadersMode));
			} finally {
			}
		}

	}
}
