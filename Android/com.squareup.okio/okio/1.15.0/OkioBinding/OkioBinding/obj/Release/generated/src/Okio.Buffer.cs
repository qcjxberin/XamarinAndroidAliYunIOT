using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='Buffer']"
	[global::Android.Runtime.Register ("okio/Buffer", DoNotGenerateAcw=true)]
	public sealed partial class Buffer : global::Java.Lang.Object, global::Java.Lang.ICloneable, global::Java.Nio.Channels.IByteChannel, global::Okio.IBufferedSink, global::Okio.IBufferedSource {

		// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']"
		[global::Android.Runtime.Register ("okio/Buffer$UnsafeCursor", DoNotGenerateAcw=true)]
		public sealed partial class UnsafeCursor : global::Java.Lang.Object, global::Java.IO.ICloseable {



			// Metadata.xml XPath field reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']/field[@name='buffer']"
			[Register ("buffer")]
			public global::Okio.Buffer Buffer {
				get {
					const string __id = "buffer.Lokio/Buffer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "buffer.Lokio/Buffer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']/field[@name='data']"
			[Register ("data")]
			public IList<byte> Data {
				get {
					const string __id = "data.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "data.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']/field[@name='end']"
			[Register ("end")]
			public int End {
				get {
					const string __id = "end.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "end.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']/field[@name='offset']"
			[Register ("offset")]
			public long Offset {
				get {
					const string __id = "offset.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "offset.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']/field[@name='readWrite']"
			[Register ("readWrite")]
			public bool ReadWrite {
				get {
					const string __id = "readWrite.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "readWrite.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']/field[@name='start']"
			[Register ("start")]
			public int Start {
				get {
					const string __id = "start.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "start.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("okio/Buffer$UnsafeCursor", typeof (UnsafeCursor));
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

			internal UnsafeCursor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']/constructor[@name='Buffer.UnsafeCursor' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe UnsafeCursor ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']/method[@name='expandBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("expandBuffer", "(I)J", "")]
			public unsafe long ExpandBuffer (int minByteCount)
			{
				const string __id = "expandBuffer.(I)J";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (minByteCount);
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']/method[@name='next' and count(parameter)=0]"
			[Register ("next", "()I", "")]
			public unsafe int Next ()
			{
				const string __id = "next.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']/method[@name='resizeBuffer' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("resizeBuffer", "(J)J", "")]
			public unsafe long ResizeBuffer (long newSize)
			{
				const string __id = "resizeBuffer.(J)J";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (newSize);
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer.UnsafeCursor']/method[@name='seek' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("seek", "(J)I", "")]
			public unsafe int Seek (long offset)
			{
				const string __id = "seek.(J)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (offset);
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/Buffer", typeof (Buffer));
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

		internal Buffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='Buffer']/constructor[@name='Buffer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Buffer ()
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

		public unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='isOpen' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='buffer' and count(parameter)=0]"
		[Register ("buffer", "()Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer InvokeBuffer ()
		{
			const string __id = "buffer.()Lokio/Buffer;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer Clone ()
		{
			const string __id = "clone.()Lokio/Buffer;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='completeSegmentByteCount' and count(parameter)=0]"
		[Register ("completeSegmentByteCount", "()J", "")]
		public unsafe long CompleteSegmentByteCount ()
		{
			const string __id = "completeSegmentByteCount.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='copyTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("copyTo", "(Ljava/io/OutputStream;)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer CopyTo (global::System.IO.Stream @out)
		{
			const string __id = "copyTo.(Ljava/io/OutputStream;)Lokio/Buffer;";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__out);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='copyTo' and count(parameter)=3 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("copyTo", "(Ljava/io/OutputStream;JJ)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer CopyTo (global::System.IO.Stream @out, long offset, long byteCount)
		{
			const string __id = "copyTo.(Ljava/io/OutputStream;JJ)Lokio/Buffer;";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native__out);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='copyTo' and count(parameter)=3 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("copyTo", "(Lokio/Buffer;JJ)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer CopyTo (global::Okio.Buffer @out, long offset, long byteCount)
		{
			const string __id = "copyTo.(Lokio/Buffer;JJ)Lokio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='emit' and count(parameter)=0]"
		[Register ("emit", "()Lokio/BufferedSink;", "")]
		public unsafe global::Okio.IBufferedSink Emit ()
		{
			const string __id = "emit.()Lokio/BufferedSink;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='emitCompleteSegments' and count(parameter)=0]"
		[Register ("emitCompleteSegments", "()Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer EmitCompleteSegments ()
		{
			const string __id = "emitCompleteSegments.()Lokio/Buffer;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='exhausted' and count(parameter)=0]"
		[Register ("exhausted", "()Z", "")]
		public unsafe bool Exhausted ()
		{
			const string __id = "exhausted.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='getByte' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getByte", "(J)B", "")]
		public unsafe sbyte GetByte (long pos)
		{
			const string __id = "getByte.(J)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pos);
				var __rm = _members.InstanceMethods.InvokeNonvirtualSByteMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='hmacSha1' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("hmacSha1", "(Lokio/ByteString;)Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString HmacSha1 (global::Okio.ByteString key)
		{
			const string __id = "hmacSha1.(Lokio/ByteString;)Lokio/ByteString;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='hmacSha256' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("hmacSha256", "(Lokio/ByteString;)Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString HmacSha256 (global::Okio.ByteString key)
		{
			const string __id = "hmacSha256.(Lokio/ByteString;)Lokio/ByteString;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='hmacSha512' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("hmacSha512", "(Lokio/ByteString;)Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString HmacSha512 (global::Okio.ByteString key)
		{
			const string __id = "hmacSha512.(Lokio/ByteString;)Lokio/ByteString;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("indexOf", "(B)J", "")]
		public unsafe long IndexOf (sbyte b)
		{
			const string __id = "indexOf.(B)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='long']]"
		[Register ("indexOf", "(BJ)J", "")]
		public unsafe long IndexOf (sbyte b, long fromIndex)
		{
			const string __id = "indexOf.(BJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (b);
				__args [1] = new JniArgumentValue (fromIndex);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("indexOf", "(BJJ)J", "")]
		public unsafe long IndexOf (sbyte b, long fromIndex, long toIndex)
		{
			const string __id = "indexOf.(BJJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (b);
				__args [1] = new JniArgumentValue (fromIndex);
				__args [2] = new JniArgumentValue (toIndex);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("indexOf", "(Lokio/ByteString;)J", "")]
		public unsafe long IndexOf (global::Okio.ByteString bytes)
		{
			const string __id = "indexOf.(Lokio/ByteString;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bytes).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='okio.ByteString'] and parameter[2][@type='long']]"
		[Register ("indexOf", "(Lokio/ByteString;J)J", "")]
		public unsafe long IndexOf (global::Okio.ByteString bytes, long fromIndex)
		{
			const string __id = "indexOf.(Lokio/ByteString;J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bytes).Handle);
				__args [1] = new JniArgumentValue (fromIndex);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOfElement' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("indexOfElement", "(Lokio/ByteString;)J", "")]
		public unsafe long IndexOfElement (global::Okio.ByteString targetBytes)
		{
			const string __id = "indexOfElement.(Lokio/ByteString;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((targetBytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetBytes).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOfElement' and count(parameter)=2 and parameter[1][@type='okio.ByteString'] and parameter[2][@type='long']]"
		[Register ("indexOfElement", "(Lokio/ByteString;J)J", "")]
		public unsafe long IndexOfElement (global::Okio.ByteString targetBytes, long fromIndex)
		{
			const string __id = "indexOfElement.(Lokio/ByteString;J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((targetBytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetBytes).Handle);
				__args [1] = new JniArgumentValue (fromIndex);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='inputStream' and count(parameter)=0]"
		[Register ("inputStream", "()Ljava/io/InputStream;", "")]
		public unsafe global::System.IO.Stream InputStream ()
		{
			const string __id = "inputStream.()Ljava/io/InputStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='md5' and count(parameter)=0]"
		[Register ("md5", "()Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString Md5 ()
		{
			const string __id = "md5.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='outputStream' and count(parameter)=0]"
		[Register ("outputStream", "()Ljava/io/OutputStream;", "")]
		public unsafe global::System.IO.Stream OutputStream ()
		{
			const string __id = "outputStream.()Ljava/io/OutputStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='rangeEquals' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='okio.ByteString']]"
		[Register ("rangeEquals", "(JLokio/ByteString;)Z", "")]
		public unsafe bool RangeEquals (long offset, global::Okio.ByteString bytes)
		{
			const string __id = "rangeEquals.(JLokio/ByteString;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (offset);
				__args [1] = new JniArgumentValue ((bytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bytes).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='rangeEquals' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='okio.ByteString'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("rangeEquals", "(JLokio/ByteString;II)Z", "")]
		public unsafe bool RangeEquals (long offset, global::Okio.ByteString bytes, int bytesOffset, int byteCount)
		{
			const string __id = "rangeEquals.(JLokio/ByteString;II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (offset);
				__args [1] = new JniArgumentValue ((bytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bytes).Handle);
				__args [2] = new JniArgumentValue (bytesOffset);
				__args [3] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "")]
		public unsafe int Read (byte[] sink)
		{
			const string __id = "read.([B)I";
			IntPtr native_sink = JNIEnv.NewArray (sink);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sink);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (sink != null) {
					JNIEnv.CopyArray (native_sink, sink);
					JNIEnv.DeleteLocalRef (native_sink);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "")]
		public unsafe int Read (byte[] sink, int offset, int byteCount)
		{
			const string __id = "read.([BII)I";
			IntPtr native_sink = JNIEnv.NewArray (sink);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_sink);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (sink != null) {
					JNIEnv.CopyArray (native_sink, sink);
					JNIEnv.DeleteLocalRef (native_sink);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)I", "")]
		public unsafe int Read (global::Java.Nio.ByteBuffer sink)
		{
			const string __id = "read.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='read' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("read", "(Lokio/Buffer;J)J", "")]
		public unsafe long Read (global::Okio.Buffer sink, long byteCount)
		{
			const string __id = "read.(Lokio/Buffer;J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				__args [1] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readAll' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register ("readAll", "(Lokio/Sink;)J", "")]
		public unsafe long ReadAll (global::Okio.ISink sink)
		{
			const string __id = "readAll.(Lokio/Sink;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readAndWriteUnsafe' and count(parameter)=0]"
		[Register ("readAndWriteUnsafe", "()Lokio/Buffer$UnsafeCursor;", "")]
		public unsafe global::Okio.Buffer.UnsafeCursor ReadAndWriteUnsafe ()
		{
			const string __id = "readAndWriteUnsafe.()Lokio/Buffer$UnsafeCursor;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer.UnsafeCursor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readAndWriteUnsafe' and count(parameter)=1 and parameter[1][@type='okio.Buffer.UnsafeCursor']]"
		[Register ("readAndWriteUnsafe", "(Lokio/Buffer$UnsafeCursor;)Lokio/Buffer$UnsafeCursor;", "")]
		public unsafe global::Okio.Buffer.UnsafeCursor ReadAndWriteUnsafe (global::Okio.Buffer.UnsafeCursor unsafeCursor)
		{
			const string __id = "readAndWriteUnsafe.(Lokio/Buffer$UnsafeCursor;)Lokio/Buffer$UnsafeCursor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((unsafeCursor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unsafeCursor).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer.UnsafeCursor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readByte' and count(parameter)=0]"
		[Register ("readByte", "()B", "")]
		public unsafe sbyte ReadByte ()
		{
			const string __id = "readByte.()B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractSByteMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readByteArray' and count(parameter)=0]"
		[Register ("readByteArray", "()[B", "")]
		public unsafe byte[] ReadByteArray ()
		{
			const string __id = "readByteArray.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readByteArray' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("readByteArray", "(J)[B", "")]
		public unsafe byte[] ReadByteArray (long byteCount)
		{
			const string __id = "readByteArray.(J)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readByteString' and count(parameter)=0]"
		[Register ("readByteString", "()Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString ReadByteString ()
		{
			const string __id = "readByteString.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readByteString' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("readByteString", "(J)Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString ReadByteString (long byteCount)
		{
			const string __id = "readByteString.(J)Lokio/ByteString;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readDecimalLong' and count(parameter)=0]"
		[Register ("readDecimalLong", "()J", "")]
		public unsafe long ReadDecimalLong ()
		{
			const string __id = "readDecimalLong.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readFrom", "(Ljava/io/InputStream;)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer ReadFrom (global::System.IO.Stream @in)
		{
			const string __id = "readFrom.(Ljava/io/InputStream;)Lokio/Buffer;";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readFrom' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long']]"
		[Register ("readFrom", "(Ljava/io/InputStream;J)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer ReadFrom (global::System.IO.Stream @in, long byteCount)
		{
			const string __id = "readFrom.(Ljava/io/InputStream;J)Lokio/Buffer;";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__in);
				__args [1] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readFully' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("readFully", "([B)V", "")]
		public unsafe void ReadFully (byte[] sink)
		{
			const string __id = "readFully.([B)V";
			IntPtr native_sink = JNIEnv.NewArray (sink);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sink);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (sink != null) {
					JNIEnv.CopyArray (native_sink, sink);
					JNIEnv.DeleteLocalRef (native_sink);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readFully' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("readFully", "(Lokio/Buffer;J)V", "")]
		public unsafe void ReadFully (global::Okio.Buffer sink, long byteCount)
		{
			const string __id = "readFully.(Lokio/Buffer;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				__args [1] = new JniArgumentValue (byteCount);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readHexadecimalUnsignedLong' and count(parameter)=0]"
		[Register ("readHexadecimalUnsignedLong", "()J", "")]
		public unsafe long ReadHexadecimalUnsignedLong ()
		{
			const string __id = "readHexadecimalUnsignedLong.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readInt' and count(parameter)=0]"
		[Register ("readInt", "()I", "")]
		public unsafe int ReadInt ()
		{
			const string __id = "readInt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readIntLe' and count(parameter)=0]"
		[Register ("readIntLe", "()I", "")]
		public unsafe int ReadIntLe ()
		{
			const string __id = "readIntLe.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readLong' and count(parameter)=0]"
		[Register ("readLong", "()J", "")]
		public unsafe long ReadLong ()
		{
			const string __id = "readLong.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readLongLe' and count(parameter)=0]"
		[Register ("readLongLe", "()J", "")]
		public unsafe long ReadLongLe ()
		{
			const string __id = "readLongLe.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readShort' and count(parameter)=0]"
		[Register ("readShort", "()S", "")]
		public unsafe short ReadShort ()
		{
			const string __id = "readShort.()S";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt16Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readShortLe' and count(parameter)=0]"
		[Register ("readShortLe", "()S", "")]
		public unsafe short ReadShortLe ()
		{
			const string __id = "readShortLe.()S";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt16Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readString' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("readString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public unsafe string ReadString (global::Java.Nio.Charset.Charset charset)
		{
			const string __id = "readString.(Ljava/nio/charset/Charset;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((charset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) charset).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readString' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("readString", "(JLjava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public unsafe string ReadString (long byteCount, global::Java.Nio.Charset.Charset charset)
		{
			const string __id = "readString.(JLjava/nio/charset/Charset;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (byteCount);
				__args [1] = new JniArgumentValue ((charset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) charset).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUnsafe' and count(parameter)=0]"
		[Register ("readUnsafe", "()Lokio/Buffer$UnsafeCursor;", "")]
		public unsafe global::Okio.Buffer.UnsafeCursor ReadUnsafe ()
		{
			const string __id = "readUnsafe.()Lokio/Buffer$UnsafeCursor;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer.UnsafeCursor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUnsafe' and count(parameter)=1 and parameter[1][@type='okio.Buffer.UnsafeCursor']]"
		[Register ("readUnsafe", "(Lokio/Buffer$UnsafeCursor;)Lokio/Buffer$UnsafeCursor;", "")]
		public unsafe global::Okio.Buffer.UnsafeCursor ReadUnsafe (global::Okio.Buffer.UnsafeCursor unsafeCursor)
		{
			const string __id = "readUnsafe.(Lokio/Buffer$UnsafeCursor;)Lokio/Buffer$UnsafeCursor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((unsafeCursor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unsafeCursor).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer.UnsafeCursor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUtf8' and count(parameter)=0]"
		[Register ("readUtf8", "()Ljava/lang/String;", "")]
		public unsafe string ReadUtf8 ()
		{
			const string __id = "readUtf8.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUtf8' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("readUtf8", "(J)Ljava/lang/String;", "")]
		public unsafe string ReadUtf8 (long byteCount)
		{
			const string __id = "readUtf8.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUtf8CodePoint' and count(parameter)=0]"
		[Register ("readUtf8CodePoint", "()I", "")]
		public unsafe int ReadUtf8CodePoint ()
		{
			const string __id = "readUtf8CodePoint.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUtf8Line' and count(parameter)=0]"
		[Register ("readUtf8Line", "()Ljava/lang/String;", "")]
		public unsafe string ReadUtf8Line ()
		{
			const string __id = "readUtf8Line.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUtf8LineStrict' and count(parameter)=0]"
		[Register ("readUtf8LineStrict", "()Ljava/lang/String;", "")]
		public unsafe string ReadUtf8LineStrict ()
		{
			const string __id = "readUtf8LineStrict.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUtf8LineStrict' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("readUtf8LineStrict", "(J)Ljava/lang/String;", "")]
		public unsafe string ReadUtf8LineStrict (long limit)
		{
			const string __id = "readUtf8LineStrict.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='request' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("request", "(J)Z", "")]
		public unsafe bool Request (long byteCount)
		{
			const string __id = "request.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='require' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("require", "(J)V", "")]
		public unsafe void Require (long byteCount)
		{
			const string __id = "require.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (byteCount);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='select' and count(parameter)=1 and parameter[1][@type='okio.Options']]"
		[Register ("select", "(Lokio/Options;)I", "")]
		public unsafe int Select (global::Okio.Options options)
		{
			const string __id = "select.(Lokio/Options;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='sha1' and count(parameter)=0]"
		[Register ("sha1", "()Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString Sha1 ()
		{
			const string __id = "sha1.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='sha256' and count(parameter)=0]"
		[Register ("sha256", "()Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString Sha256 ()
		{
			const string __id = "sha256.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='sha512' and count(parameter)=0]"
		[Register ("sha512", "()Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString Sha512 ()
		{
			const string __id = "sha512.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()J", "")]
		public unsafe long Size ()
		{
			const string __id = "size.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skip", "(J)V", "")]
		public unsafe void Skip (long byteCount)
		{
			const string __id = "skip.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (byteCount);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='snapshot' and count(parameter)=0]"
		[Register ("snapshot", "()Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString Snapshot ()
		{
			const string __id = "snapshot.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='snapshot' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("snapshot", "(I)Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString Snapshot (int byteCount)
		{
			const string __id = "snapshot.(I)Lokio/ByteString;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='timeout' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer Write (byte[] source)
		{
			const string __id = "write.([B)Lokio/Buffer;";
			IntPtr native_source = JNIEnv.NewArray (source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_source);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (source != null) {
					JNIEnv.CopyArray (native_source, source);
					JNIEnv.DeleteLocalRef (native_source);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write", "([BII)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer Write (byte[] source, int offset, int byteCount)
		{
			const string __id = "write.([BII)Lokio/Buffer;";
			IntPtr native_source = JNIEnv.NewArray (source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_source);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (source != null) {
					JNIEnv.CopyArray (native_source, source);
					JNIEnv.DeleteLocalRef (native_source);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;)I", "")]
		public unsafe int Write (global::Java.Nio.ByteBuffer source)
		{
			const string __id = "write.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='write' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("write", "(Lokio/ByteString;)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer Write (global::Okio.ByteString byteString)
		{
			const string __id = "write.(Lokio/ByteString;)Lokio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((byteString == null) ? IntPtr.Zero : ((global::Java.Lang.Object) byteString).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Source'] and parameter[2][@type='long']]"
		[Register ("write", "(Lokio/Source;J)Lokio/BufferedSink;", "")]
		public unsafe global::Okio.IBufferedSink Write (global::Okio.ISource source, long byteCount)
		{
			const string __id = "write.(Lokio/Source;J)Lokio/BufferedSink;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeAll' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register ("writeAll", "(Lokio/Source;)J", "")]
		public unsafe long WriteAll (global::Okio.ISource source)
		{
			const string __id = "writeAll.(Lokio/Source;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeByte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeByte", "(I)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteByte (int b)
		{
			const string __id = "writeByte.(I)Lokio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeDecimalLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeDecimalLong", "(J)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteDecimalLong (long v)
		{
			const string __id = "writeDecimalLong.(J)Lokio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (v);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeHexadecimalUnsignedLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeHexadecimalUnsignedLong", "(J)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteHexadecimalUnsignedLong (long v)
		{
			const string __id = "writeHexadecimalUnsignedLong.(J)Lokio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (v);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeInt", "(I)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteInt (int i)
		{
			const string __id = "writeInt.(I)Lokio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeIntLe' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeIntLe", "(I)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteIntLe (int i)
		{
			const string __id = "writeIntLe.(I)Lokio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeLong", "(J)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteLong (long v)
		{
			const string __id = "writeLong.(J)Lokio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (v);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeLongLe' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeLongLe", "(J)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteLongLe (long v)
		{
			const string __id = "writeLongLe.(J)Lokio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (v);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeShort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeShort", "(I)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteShort (int s)
		{
			const string __id = "writeShort.(I)Lokio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (s);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeShortLe' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeShortLe", "(I)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteShortLe (int s)
		{
			const string __id = "writeShortLe.(I)Lokio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (s);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeString' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.nio.charset.Charset']]"
		[Register ("writeString", "(Ljava/lang/String;IILjava/nio/charset/Charset;)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteString (string @string, int beginIndex, int endIndex, global::Java.Nio.Charset.Charset charset)
		{
			const string __id = "writeString.(Ljava/lang/String;IILjava/nio/charset/Charset;)Lokio/Buffer;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native__string);
				__args [1] = new JniArgumentValue (beginIndex);
				__args [2] = new JniArgumentValue (endIndex);
				__args [3] = new JniArgumentValue ((charset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) charset).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("writeString", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteString (string @string, global::Java.Nio.Charset.Charset charset)
		{
			const string __id = "writeString.(Ljava/lang/String;Ljava/nio/charset/Charset;)Lokio/Buffer;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__string);
				__args [1] = new JniArgumentValue ((charset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) charset).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteTo (global::System.IO.Stream @out)
		{
			const string __id = "writeTo.(Ljava/io/OutputStream;)Lokio/Buffer;";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__out);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeTo' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='long']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;J)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteTo (global::System.IO.Stream @out, long byteCount)
		{
			const string __id = "writeTo.(Ljava/io/OutputStream;J)Lokio/Buffer;";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__out);
				__args [1] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeUtf8' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeUtf8", "(Ljava/lang/String;)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteUtf8 (string @string)
		{
			const string __id = "writeUtf8.(Ljava/lang/String;)Lokio/Buffer;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeUtf8' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("writeUtf8", "(Ljava/lang/String;II)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteUtf8 (string @string, int beginIndex, int endIndex)
		{
			const string __id = "writeUtf8.(Ljava/lang/String;II)Lokio/Buffer;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native__string);
				__args [1] = new JniArgumentValue (beginIndex);
				__args [2] = new JniArgumentValue (endIndex);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeUtf8CodePoint' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeUtf8CodePoint", "(I)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer WriteUtf8CodePoint (int codePoint)
		{
			const string __id = "writeUtf8CodePoint.(I)Lokio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (codePoint);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
