using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Stream", DoNotGenerateAcw=true)]
	public sealed partial class Http2Stream : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Http2Stream", typeof (Http2Stream));
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

		internal Http2Stream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Okhttp3.Internal.Http2.Http2Connection Connection {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='getConnection' and count(parameter)=0]"
			[Register ("getConnection", "()Lokhttp3/internal/http2/Http2Connection;", "")]
			get {
				const string __id = "getConnection.()Lokhttp3/internal/http2/Http2Connection;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Okhttp3.Internal.Http2.ErrorCode ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Lokhttp3/internal/http2/ErrorCode;", "")]
			get {
				const string __id = "getErrorCode.()Lokhttp3/internal/http2/ErrorCode;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "")]
			get {
				const string __id = "getId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsLocallyInitiated {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='isLocallyInitiated' and count(parameter)=0]"
			[Register ("isLocallyInitiated", "()Z", "")]
			get {
				const string __id = "isLocallyInitiated.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "")]
			get {
				const string __id = "isOpen.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='close' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.ErrorCode']]"
		[Register ("close", "(Lokhttp3/internal/http2/ErrorCode;)V", "")]
		public unsafe void Close (global::Okhttp3.Internal.Http2.ErrorCode rstStatusCode)
		{
			const string __id = "close.(Lokhttp3/internal/http2/ErrorCode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rstStatusCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rstStatusCode).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='closeLater' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.ErrorCode']]"
		[Register ("closeLater", "(Lokhttp3/internal/http2/ErrorCode;)V", "")]
		public unsafe void CloseLater (global::Okhttp3.Internal.Http2.ErrorCode errorCode)
		{
			const string __id = "closeLater.(Lokhttp3/internal/http2/ErrorCode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCode).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='takeHeaders' and count(parameter)=0]"
		[Register ("takeHeaders", "()Lokhttp3/Headers;", "")]
		public unsafe global::Okhttp3.Headers TakeHeaders ()
		{
			const string __id = "takeHeaders.()Lokhttp3/Headers;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='writeHeaders' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;'] and parameter[2][@type='boolean']]"
		[Register ("writeHeaders", "(Ljava/util/List;Z)V", "")]
		public unsafe void WriteHeaders (global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> responseHeaders, bool @out)
		{
			const string __id = "writeHeaders.(Ljava/util/List;Z)V";
			IntPtr native_responseHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (responseHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_responseHeaders);
				__args [1] = new JniArgumentValue (@out);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_responseHeaders);
			}
		}

	}
}
