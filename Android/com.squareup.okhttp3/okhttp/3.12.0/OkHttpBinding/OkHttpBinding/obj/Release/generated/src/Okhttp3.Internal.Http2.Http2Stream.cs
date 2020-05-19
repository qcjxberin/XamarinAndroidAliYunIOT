using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Stream", DoNotGenerateAcw=true)]
	public sealed partial class Http2Stream : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream.FramingSink']"
		[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Stream$FramingSink", DoNotGenerateAcw=true)]
		public sealed partial class FramingSink : global::Java.Lang.Object, global::Okio.ISink {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Http2Stream$FramingSink", typeof (FramingSink));
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

			internal FramingSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream.FramingSink']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream.FramingSink']/method[@name='flush' and count(parameter)=0]"
			[Register ("flush", "()V", "")]
			public unsafe void Flush ()
			{
				const string __id = "flush.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream.FramingSink']/method[@name='timeout' and count(parameter)=0]"
			[Register ("timeout", "()Lokio/Timeout;", "")]
			public unsafe global::Okio.Timeout Timeout ()
			{
				const string __id = "timeout.()Lokio/Timeout;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream.FramingSink']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
			[Register ("write", "(Lokio/Buffer;J)V", "")]
			public unsafe void Write (global::Okio.Buffer source, long byteCount)
			{
				const string __id = "write.(Lokio/Buffer;J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
					__args [1] = new JniArgumentValue (byteCount);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream.StreamTimeout']"
		[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Stream$StreamTimeout", DoNotGenerateAcw=true)]
		public partial class StreamTimeout : global::Okio.AsyncTimeout {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Http2Stream$StreamTimeout", typeof (StreamTimeout));
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

			protected StreamTimeout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_exitAndThrowIfTimedOut;
#pragma warning disable 0169
			static Delegate GetExitAndThrowIfTimedOutHandler ()
			{
				if (cb_exitAndThrowIfTimedOut == null)
					cb_exitAndThrowIfTimedOut = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ExitAndThrowIfTimedOut);
				return cb_exitAndThrowIfTimedOut;
			}

			static void n_ExitAndThrowIfTimedOut (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Internal.Http2.Http2Stream.StreamTimeout __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Stream.StreamTimeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ExitAndThrowIfTimedOut ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream.StreamTimeout']/method[@name='exitAndThrowIfTimedOut' and count(parameter)=0]"
			[Register ("exitAndThrowIfTimedOut", "()V", "GetExitAndThrowIfTimedOutHandler")]
			public virtual unsafe void ExitAndThrowIfTimedOut ()
			{
				const string __id = "exitAndThrowIfTimedOut.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

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

		public unsafe global::Okio.ISink Sink {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='getSink' and count(parameter)=0]"
			[Register ("getSink", "()Lokio/Sink;", "")]
			get {
				const string __id = "getSink.()Lokio/Sink;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okio.ISink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Okio.ISource Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()Lokio/Source;", "")]
			get {
				const string __id = "getSource.()Lokio/Source;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okio.ISource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='readTimeout' and count(parameter)=0]"
		[Register ("readTimeout", "()Lokio/Timeout;", "")]
		public unsafe global::Okio.Timeout ReadTimeout ()
		{
			const string __id = "readTimeout.()Lokio/Timeout;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='writeTimeout' and count(parameter)=0]"
		[Register ("writeTimeout", "()Lokio/Timeout;", "")]
		public unsafe global::Okio.Timeout WriteTimeout ()
		{
			const string __id = "writeTimeout.()Lokio/Timeout;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
