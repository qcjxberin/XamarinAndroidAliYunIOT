using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Framed {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedStream']"
	[global::Android.Runtime.Register ("okhttp3/internal/framed/FramedStream", DoNotGenerateAcw=true)]
	public sealed partial class FramedStream : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/FramedStream", typeof (FramedStream));
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

		internal FramedStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Okhttp3.Internal.Framed.FramedConnection Connection {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedStream']/method[@name='getConnection' and count(parameter)=0]"
			[Register ("getConnection", "()Lokhttp3/internal/framed/FramedConnection;", "")]
			get {
				const string __id = "getConnection.()Lokhttp3/internal/framed/FramedConnection;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Okhttp3.Internal.Framed.ErrorCode ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedStream']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Lokhttp3/internal/framed/ErrorCode;", "")]
			get {
				const string __id = "getErrorCode.()Lokhttp3/internal/framed/ErrorCode;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.ErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedStream']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedStream']/method[@name='isLocallyInitiated' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedStream']/method[@name='isOpen' and count(parameter)=0]"
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

		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> RequestHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedStream']/method[@name='getRequestHeaders' and count(parameter)=0]"
			[Register ("getRequestHeaders", "()Ljava/util/List;", "")]
			get {
				const string __id = "getRequestHeaders.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> ResponseHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedStream']/method[@name='getResponseHeaders' and count(parameter)=0]"
			[Register ("getResponseHeaders", "()Ljava/util/List;", "")]
			get {
				const string __id = "getResponseHeaders.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedStream']/method[@name='close' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.ErrorCode']]"
		[Register ("close", "(Lokhttp3/internal/framed/ErrorCode;)V", "")]
		public unsafe void Close (global::Okhttp3.Internal.Framed.ErrorCode rstStatusCode)
		{
			const string __id = "close.(Lokhttp3/internal/framed/ErrorCode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rstStatusCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rstStatusCode).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedStream']/method[@name='closeLater' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.ErrorCode']]"
		[Register ("closeLater", "(Lokhttp3/internal/framed/ErrorCode;)V", "")]
		public unsafe void CloseLater (global::Okhttp3.Internal.Framed.ErrorCode errorCode)
		{
			const string __id = "closeLater.(Lokhttp3/internal/framed/ErrorCode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCode).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedStream']/method[@name='reply' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;'] and parameter[2][@type='boolean']]"
		[Register ("reply", "(Ljava/util/List;Z)V", "")]
		public unsafe void Reply (global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> responseHeaders, bool @out)
		{
			const string __id = "reply.(Ljava/util/List;Z)V";
			IntPtr native_responseHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (responseHeaders);
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
