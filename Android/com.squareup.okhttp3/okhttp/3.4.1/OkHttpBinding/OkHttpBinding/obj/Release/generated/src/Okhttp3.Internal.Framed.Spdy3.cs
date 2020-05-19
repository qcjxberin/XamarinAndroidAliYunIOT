using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Framed {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3']"
	[global::Android.Runtime.Register ("okhttp3/internal/framed/Spdy3", DoNotGenerateAcw=true)]
	public sealed partial class Spdy3 : global::Java.Lang.Object, global::Okhttp3.Internal.Framed.IVariant {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Reader']"
		[global::Android.Runtime.Register ("okhttp3/internal/framed/Spdy3$Reader", DoNotGenerateAcw=true)]
		public sealed partial class Reader : global::Java.Lang.Object, global::Okhttp3.Internal.Framed.IFrameReader {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/Spdy3$Reader", typeof (Reader));
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

			internal Reader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Reader']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Reader']/method[@name='nextFrame' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.FrameReader.Handler']]"
			[Register ("nextFrame", "(Lokhttp3/internal/framed/FrameReader$Handler;)Z", "")]
			public unsafe bool NextFrame (global::Okhttp3.Internal.Framed.IFrameReaderHandler handler)
			{
				const string __id = "nextFrame.(Lokhttp3/internal/framed/FrameReader$Handler;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Reader']/method[@name='readConnectionPreface' and count(parameter)=0]"
			[Register ("readConnectionPreface", "()V", "")]
			public unsafe void ReadConnectionPreface ()
			{
				const string __id = "readConnectionPreface.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']"
		[global::Android.Runtime.Register ("okhttp3/internal/framed/Spdy3$Writer", DoNotGenerateAcw=true)]
		public sealed partial class Writer : global::Java.Lang.Object, global::Okhttp3.Internal.Framed.IFrameWriter {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/Spdy3$Writer", typeof (Writer));
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

			internal Writer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='applyAndAckSettings' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.Settings']]"
			[Register ("applyAndAckSettings", "(Lokhttp3/internal/framed/Settings;)V", "")]
			public unsafe void ApplyAndAckSettings (global::Okhttp3.Internal.Framed.Settings peerSettings)
			{
				const string __id = "applyAndAckSettings.(Lokhttp3/internal/framed/Settings;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((peerSettings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) peerSettings).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='connectionPreface' and count(parameter)=0]"
			[Register ("connectionPreface", "()V", "")]
			public unsafe void ConnectionPreface ()
			{
				const string __id = "connectionPreface.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='flush' and count(parameter)=0]"
			[Register ("flush", "()V", "")]
			public unsafe void Flush ()
			{
				const string __id = "flush.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='goAway' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='okhttp3.internal.framed.ErrorCode'] and parameter[3][@type='byte[]']]"
			[Register ("goAway", "(ILokhttp3/internal/framed/ErrorCode;[B)V", "")]
			public unsafe void GoAway (int lastGoodStreamId, global::Okhttp3.Internal.Framed.ErrorCode errorCode, byte[] ignored)
			{
				const string __id = "goAway.(ILokhttp3/internal/framed/ErrorCode;[B)V";
				IntPtr native_ignored = JNIEnv.NewArray (ignored);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (lastGoodStreamId);
					__args [1] = new JniArgumentValue ((errorCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCode).Handle);
					__args [2] = new JniArgumentValue (native_ignored);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					if (ignored != null) {
						JNIEnv.CopyArray (native_ignored, ignored);
						JNIEnv.DeleteLocalRef (native_ignored);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='headers' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;']]"
			[Register ("headers", "(ILjava/util/List;)V", "")]
			public unsafe void Headers (int streamId, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> headerBlock)
			{
				const string __id = "headers.(ILjava/util/List;)V";
				IntPtr native_headerBlock = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (headerBlock);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (streamId);
					__args [1] = new JniArgumentValue (native_headerBlock);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_headerBlock);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='maxDataLength' and count(parameter)=0]"
			[Register ("maxDataLength", "()I", "")]
			public unsafe int MaxDataLength ()
			{
				const string __id = "maxDataLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='ping' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("ping", "(ZII)V", "")]
			public unsafe void Ping (bool reply, int payload1, int payload2)
			{
				const string __id = "ping.(ZII)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (reply);
					__args [1] = new JniArgumentValue (payload1);
					__args [2] = new JniArgumentValue (payload2);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='pushPromise' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;']]"
			[Register ("pushPromise", "(IILjava/util/List;)V", "")]
			public unsafe void PushPromise (int streamId, int promisedStreamId, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> requestHeaders)
			{
				const string __id = "pushPromise.(IILjava/util/List;)V";
				IntPtr native_requestHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (requestHeaders);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (streamId);
					__args [1] = new JniArgumentValue (promisedStreamId);
					__args [2] = new JniArgumentValue (native_requestHeaders);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_requestHeaders);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='rstStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='okhttp3.internal.framed.ErrorCode']]"
			[Register ("rstStream", "(ILokhttp3/internal/framed/ErrorCode;)V", "")]
			public unsafe void RstStream (int streamId, global::Okhttp3.Internal.Framed.ErrorCode errorCode)
			{
				const string __id = "rstStream.(ILokhttp3/internal/framed/ErrorCode;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (streamId);
					__args [1] = new JniArgumentValue ((errorCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCode).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='settings' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.Settings']]"
			[Register ("settings", "(Lokhttp3/internal/framed/Settings;)V", "")]
			public unsafe void Settings (global::Okhttp3.Internal.Framed.Settings settings)
			{
				const string __id = "settings.(Lokhttp3/internal/framed/Settings;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((settings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) settings).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='synReply' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;']]"
			[Register ("synReply", "(ZILjava/util/List;)V", "")]
			public unsafe void SynReply (bool outFinished, int streamId, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> headerBlock)
			{
				const string __id = "synReply.(ZILjava/util/List;)V";
				IntPtr native_headerBlock = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (headerBlock);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (outFinished);
					__args [1] = new JniArgumentValue (streamId);
					__args [2] = new JniArgumentValue (native_headerBlock);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_headerBlock);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='synStream' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;']]"
			[Register ("synStream", "(ZZIILjava/util/List;)V", "")]
			public unsafe void SynStream (bool outFinished, bool inFinished, int streamId, int associatedStreamId, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> headerBlock)
			{
				const string __id = "synStream.(ZZIILjava/util/List;)V";
				IntPtr native_headerBlock = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (headerBlock);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (outFinished);
					__args [1] = new JniArgumentValue (inFinished);
					__args [2] = new JniArgumentValue (streamId);
					__args [3] = new JniArgumentValue (associatedStreamId);
					__args [4] = new JniArgumentValue (native_headerBlock);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_headerBlock);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3.Writer']/method[@name='windowUpdate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
			[Register ("windowUpdate", "(IJ)V", "")]
			public unsafe void WindowUpdate (int streamId, long increment)
			{
				const string __id = "windowUpdate.(IJ)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (streamId);
					__args [1] = new JniArgumentValue (increment);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/Spdy3", typeof (Spdy3));
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

		internal Spdy3 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3']/constructor[@name='Spdy3' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Spdy3 ()
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

		public unsafe global::Okhttp3.Protocol Protocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='Spdy3']/method[@name='getProtocol' and count(parameter)=0]"
			[Register ("getProtocol", "()Lokhttp3/Protocol;", "")]
			get {
				const string __id = "getProtocol.()Lokhttp3/Protocol;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
