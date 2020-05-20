using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/ErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCode : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='CANCEL']"
		[Register ("CANCEL")]
		public static global::Okhttp3.Internal.Http2.ErrorCode Cancel {
			get {
				const string __id = "CANCEL.Lokhttp3/internal/http2/ErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='COMPRESSION_ERROR']"
		[Register ("COMPRESSION_ERROR")]
		public static global::Okhttp3.Internal.Http2.ErrorCode CompressionError {
			get {
				const string __id = "COMPRESSION_ERROR.Lokhttp3/internal/http2/ErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='CONNECT_ERROR']"
		[Register ("CONNECT_ERROR")]
		public static global::Okhttp3.Internal.Http2.ErrorCode ConnectError {
			get {
				const string __id = "CONNECT_ERROR.Lokhttp3/internal/http2/ErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='ENHANCE_YOUR_CALM']"
		[Register ("ENHANCE_YOUR_CALM")]
		public static global::Okhttp3.Internal.Http2.ErrorCode EnhanceYourCalm {
			get {
				const string __id = "ENHANCE_YOUR_CALM.Lokhttp3/internal/http2/ErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='FLOW_CONTROL_ERROR']"
		[Register ("FLOW_CONTROL_ERROR")]
		public static global::Okhttp3.Internal.Http2.ErrorCode FlowControlError {
			get {
				const string __id = "FLOW_CONTROL_ERROR.Lokhttp3/internal/http2/ErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='HTTP_1_1_REQUIRED']"
		[Register ("HTTP_1_1_REQUIRED")]
		public static global::Okhttp3.Internal.Http2.ErrorCode Http11Required {
			get {
				const string __id = "HTTP_1_1_REQUIRED.Lokhttp3/internal/http2/ErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='INADEQUATE_SECURITY']"
		[Register ("INADEQUATE_SECURITY")]
		public static global::Okhttp3.Internal.Http2.ErrorCode InadequateSecurity {
			get {
				const string __id = "INADEQUATE_SECURITY.Lokhttp3/internal/http2/ErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public static global::Okhttp3.Internal.Http2.ErrorCode InternalError {
			get {
				const string __id = "INTERNAL_ERROR.Lokhttp3/internal/http2/ErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='NO_ERROR']"
		[Register ("NO_ERROR")]
		public static global::Okhttp3.Internal.Http2.ErrorCode NoError {
			get {
				const string __id = "NO_ERROR.Lokhttp3/internal/http2/ErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='PROTOCOL_ERROR']"
		[Register ("PROTOCOL_ERROR")]
		public static global::Okhttp3.Internal.Http2.ErrorCode ProtocolError {
			get {
				const string __id = "PROTOCOL_ERROR.Lokhttp3/internal/http2/ErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='REFUSED_STREAM']"
		[Register ("REFUSED_STREAM")]
		public static global::Okhttp3.Internal.Http2.ErrorCode RefusedStream {
			get {
				const string __id = "REFUSED_STREAM.Lokhttp3/internal/http2/ErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='httpCode']"
		[Register ("httpCode")]
		public int HttpCode {
			get {
				const string __id = "httpCode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "httpCode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/ErrorCode", typeof (ErrorCode));
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

		internal ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/method[@name='fromHttp2' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromHttp2", "(I)Lokhttp3/internal/http2/ErrorCode;", "")]
		public static unsafe global::Okhttp3.Internal.Http2.ErrorCode FromHttp2 (int code)
		{
			const string __id = "fromHttp2.(I)Lokhttp3/internal/http2/ErrorCode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lokhttp3/internal/http2/ErrorCode;", "")]
		public static unsafe global::Okhttp3.Internal.Http2.ErrorCode ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lokhttp3/internal/http2/ErrorCode;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lokhttp3/internal/http2/ErrorCode;", "")]
		public static unsafe global::Okhttp3.Internal.Http2.ErrorCode[] Values ()
		{
			const string __id = "values.()[Lokhttp3/internal/http2/ErrorCode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Okhttp3.Internal.Http2.ErrorCode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Okhttp3.Internal.Http2.ErrorCode));
			} finally {
			}
		}

	}
}
