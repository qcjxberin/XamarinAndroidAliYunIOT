using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']"
	[Register ("okio/BufferedSink", "", "Okio.IBufferedSinkInvoker")]
	public partial interface IBufferedSink : global::Java.Nio.Channels.IWritableByteChannel, global::Okio.ISink {

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='buffer' and count(parameter)=0]"
		[Register ("buffer", "()Lokio/Buffer;", "GetBufferHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.Buffer Buffer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='emit' and count(parameter)=0]"
		[Register ("emit", "()Lokio/BufferedSink;", "GetEmitHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink Emit ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='emitCompleteSegments' and count(parameter)=0]"
		[Register ("emitCompleteSegments", "()Lokio/BufferedSink;", "GetEmitCompleteSegmentsHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink EmitCompleteSegments ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		void Flush ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='outputStream' and count(parameter)=0]"
		[Register ("outputStream", "()Ljava/io/OutputStream;", "GetOutputStreamHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::System.IO.Stream OutputStream ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)Lokio/BufferedSink;", "GetWrite_arrayBHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink Write (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write", "([BII)Lokio/BufferedSink;", "GetWrite_arrayBIIHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink Write (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='write' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("write", "(Lokio/ByteString;)Lokio/BufferedSink;", "GetWrite_Lokio_ByteString_Handler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink Write (global::Okio.ByteString p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Source'] and parameter[2][@type='long']]"
		[Register ("write", "(Lokio/Source;J)Lokio/BufferedSink;", "GetWrite_Lokio_Source_JHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink Write (global::Okio.ISource p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeAll' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register ("writeAll", "(Lokio/Source;)J", "GetWriteAll_Lokio_Source_Handler:Okio.IBufferedSinkInvoker, OkioBinding")]
		long WriteAll (global::Okio.ISource p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeByte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeByte", "(I)Lokio/BufferedSink;", "GetWriteByte_IHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteByte (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeDecimalLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeDecimalLong", "(J)Lokio/BufferedSink;", "GetWriteDecimalLong_JHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteDecimalLong (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeHexadecimalUnsignedLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeHexadecimalUnsignedLong", "(J)Lokio/BufferedSink;", "GetWriteHexadecimalUnsignedLong_JHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteHexadecimalUnsignedLong (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeInt", "(I)Lokio/BufferedSink;", "GetWriteInt_IHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteInt (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeIntLe' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeIntLe", "(I)Lokio/BufferedSink;", "GetWriteIntLe_IHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteIntLe (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeLong", "(J)Lokio/BufferedSink;", "GetWriteLong_JHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteLong (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeLongLe' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeLongLe", "(J)Lokio/BufferedSink;", "GetWriteLongLe_JHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteLongLe (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeShort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeShort", "(I)Lokio/BufferedSink;", "GetWriteShort_IHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteShort (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeShortLe' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeShortLe", "(I)Lokio/BufferedSink;", "GetWriteShortLe_IHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteShortLe (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeString' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.nio.charset.Charset']]"
		[Register ("writeString", "(Ljava/lang/String;IILjava/nio/charset/Charset;)Lokio/BufferedSink;", "GetWriteString_Ljava_lang_String_IILjava_nio_charset_Charset_Handler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteString (string p0, int p1, int p2, global::Java.Nio.Charset.Charset p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("writeString", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Lokio/BufferedSink;", "GetWriteString_Ljava_lang_String_Ljava_nio_charset_Charset_Handler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteString (string p0, global::Java.Nio.Charset.Charset p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeUtf8' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeUtf8", "(Ljava/lang/String;)Lokio/BufferedSink;", "GetWriteUtf8_Ljava_lang_String_Handler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteUtf8 (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeUtf8' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("writeUtf8", "(Ljava/lang/String;II)Lokio/BufferedSink;", "GetWriteUtf8_Ljava_lang_String_IIHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteUtf8 (string p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='writeUtf8CodePoint' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeUtf8CodePoint", "(I)Lokio/BufferedSink;", "GetWriteUtf8CodePoint_IHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		global::Okio.IBufferedSink WriteUtf8CodePoint (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Okio.IBufferedSinkInvoker, OkioBinding")]
		void Close ();

	}

	[global::Android.Runtime.Register ("okio/BufferedSink", DoNotGenerateAcw=true)]
	internal partial class IBufferedSinkInvoker : global::Java.Lang.Object, IBufferedSink {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/BufferedSink", typeof (IBufferedSinkInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IBufferedSink GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBufferedSink> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okio.BufferedSink"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBufferedSinkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_buffer;
#pragma warning disable 0169
		static Delegate GetBufferHandler ()
		{
			if (cb_buffer == null)
				cb_buffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Buffer);
			return cb_buffer;
		}

		static IntPtr n_Buffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Buffer ());
		}
#pragma warning restore 0169

		IntPtr id_buffer;
		public unsafe global::Okio.Buffer Buffer ()
		{
			if (id_buffer == IntPtr.Zero)
				id_buffer = JNIEnv.GetMethodID (class_ref, "buffer", "()Lokio/Buffer;");
			return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_emit;
#pragma warning disable 0169
		static Delegate GetEmitHandler ()
		{
			if (cb_emit == null)
				cb_emit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Emit);
			return cb_emit;
		}

		static IntPtr n_Emit (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Emit ());
		}
#pragma warning restore 0169

		IntPtr id_emit;
		public unsafe global::Okio.IBufferedSink Emit ()
		{
			if (id_emit == IntPtr.Zero)
				id_emit = JNIEnv.GetMethodID (class_ref, "emit", "()Lokio/BufferedSink;");
			return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_emit), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_emitCompleteSegments;
#pragma warning disable 0169
		static Delegate GetEmitCompleteSegmentsHandler ()
		{
			if (cb_emitCompleteSegments == null)
				cb_emitCompleteSegments = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EmitCompleteSegments);
			return cb_emitCompleteSegments;
		}

		static IntPtr n_EmitCompleteSegments (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EmitCompleteSegments ());
		}
#pragma warning restore 0169

		IntPtr id_emitCompleteSegments;
		public unsafe global::Okio.IBufferedSink EmitCompleteSegments ()
		{
			if (id_emitCompleteSegments == IntPtr.Zero)
				id_emitCompleteSegments = JNIEnv.GetMethodID (class_ref, "emitCompleteSegments", "()Lokio/BufferedSink;");
			return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_emitCompleteSegments), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		IntPtr id_flush;
		public unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
		}

		static Delegate cb_outputStream;
#pragma warning disable 0169
		static Delegate GetOutputStreamHandler ()
		{
			if (cb_outputStream == null)
				cb_outputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OutputStream);
			return cb_outputStream;
		}

		static IntPtr n_OutputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream ());
		}
#pragma warning restore 0169

		IntPtr id_outputStream;
		public unsafe global::System.IO.Stream OutputStream ()
		{
			if (id_outputStream == IntPtr.Zero)
				id_outputStream = JNIEnv.GetMethodID (class_ref, "outputStream", "()Ljava/io/OutputStream;");
			return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_outputStream), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_write_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBHandler ()
		{
			if (cb_write_arrayB == null)
				cb_write_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Write_arrayB);
			return cb_write_arrayB;
		}

		static IntPtr n_Write_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Write (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_write_arrayB;
		public unsafe global::Okio.IBufferedSink Write (byte[] p0)
		{
			if (id_write_arrayB == IntPtr.Zero)
				id_write_arrayB = JNIEnv.GetMethodID (class_ref, "write", "([B)Lokio/BufferedSink;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_write_arrayB, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_write_arrayBII;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBIIHandler ()
		{
			if (cb_write_arrayBII == null)
				cb_write_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Write_arrayBII);
			return cb_write_arrayBII;
		}

		static IntPtr n_Write_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Write (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_write_arrayBII;
		public unsafe global::Okio.IBufferedSink Write (byte[] p0, int p1, int p2)
		{
			if (id_write_arrayBII == IntPtr.Zero)
				id_write_arrayBII = JNIEnv.GetMethodID (class_ref, "write", "([BII)Lokio/BufferedSink;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_write_arrayBII, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_write_Lokio_ByteString_;
#pragma warning disable 0169
		static Delegate GetWrite_Lokio_ByteString_Handler ()
		{
			if (cb_write_Lokio_ByteString_ == null)
				cb_write_Lokio_ByteString_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Write_Lokio_ByteString_);
			return cb_write_Lokio_ByteString_;
		}

		static IntPtr n_Write_Lokio_ByteString_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ByteString p0 = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Write (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_write_Lokio_ByteString_;
		public unsafe global::Okio.IBufferedSink Write (global::Okio.ByteString p0)
		{
			if (id_write_Lokio_ByteString_ == IntPtr.Zero)
				id_write_Lokio_ByteString_ = JNIEnv.GetMethodID (class_ref, "write", "(Lokio/ByteString;)Lokio/BufferedSink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_write_Lokio_ByteString_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_write_Lokio_Source_J;
#pragma warning disable 0169
		static Delegate GetWrite_Lokio_Source_JHandler ()
		{
			if (cb_write_Lokio_Source_J == null)
				cb_write_Lokio_Source_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_Write_Lokio_Source_J);
			return cb_write_Lokio_Source_J;
		}

		static IntPtr n_Write_Lokio_Source_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ISource p0 = (global::Okio.ISource)global::Java.Lang.Object.GetObject<global::Okio.ISource> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Write (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_write_Lokio_Source_J;
		public unsafe global::Okio.IBufferedSink Write (global::Okio.ISource p0, long p1)
		{
			if (id_write_Lokio_Source_J == IntPtr.Zero)
				id_write_Lokio_Source_J = JNIEnv.GetMethodID (class_ref, "write", "(Lokio/Source;J)Lokio/BufferedSink;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_write_Lokio_Source_J, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_writeAll_Lokio_Source_;
#pragma warning disable 0169
		static Delegate GetWriteAll_Lokio_Source_Handler ()
		{
			if (cb_writeAll_Lokio_Source_ == null)
				cb_writeAll_Lokio_Source_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_WriteAll_Lokio_Source_);
			return cb_writeAll_Lokio_Source_;
		}

		static long n_WriteAll_Lokio_Source_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ISource p0 = (global::Okio.ISource)global::Java.Lang.Object.GetObject<global::Okio.ISource> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.WriteAll (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeAll_Lokio_Source_;
		public unsafe long WriteAll (global::Okio.ISource p0)
		{
			if (id_writeAll_Lokio_Source_ == IntPtr.Zero)
				id_writeAll_Lokio_Source_ = JNIEnv.GetMethodID (class_ref, "writeAll", "(Lokio/Source;)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_writeAll_Lokio_Source_, __args);
			return __ret;
		}

		static Delegate cb_writeByte_I;
#pragma warning disable 0169
		static Delegate GetWriteByte_IHandler ()
		{
			if (cb_writeByte_I == null)
				cb_writeByte_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WriteByte_I);
			return cb_writeByte_I;
		}

		static IntPtr n_WriteByte_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteByte (p0));
		}
#pragma warning restore 0169

		IntPtr id_writeByte_I;
		public unsafe global::Okio.IBufferedSink WriteByte (int p0)
		{
			if (id_writeByte_I == IntPtr.Zero)
				id_writeByte_I = JNIEnv.GetMethodID (class_ref, "writeByte", "(I)Lokio/BufferedSink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeByte_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeDecimalLong_J;
#pragma warning disable 0169
		static Delegate GetWriteDecimalLong_JHandler ()
		{
			if (cb_writeDecimalLong_J == null)
				cb_writeDecimalLong_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_WriteDecimalLong_J);
			return cb_writeDecimalLong_J;
		}

		static IntPtr n_WriteDecimalLong_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteDecimalLong (p0));
		}
#pragma warning restore 0169

		IntPtr id_writeDecimalLong_J;
		public unsafe global::Okio.IBufferedSink WriteDecimalLong (long p0)
		{
			if (id_writeDecimalLong_J == IntPtr.Zero)
				id_writeDecimalLong_J = JNIEnv.GetMethodID (class_ref, "writeDecimalLong", "(J)Lokio/BufferedSink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeDecimalLong_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeHexadecimalUnsignedLong_J;
#pragma warning disable 0169
		static Delegate GetWriteHexadecimalUnsignedLong_JHandler ()
		{
			if (cb_writeHexadecimalUnsignedLong_J == null)
				cb_writeHexadecimalUnsignedLong_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_WriteHexadecimalUnsignedLong_J);
			return cb_writeHexadecimalUnsignedLong_J;
		}

		static IntPtr n_WriteHexadecimalUnsignedLong_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteHexadecimalUnsignedLong (p0));
		}
#pragma warning restore 0169

		IntPtr id_writeHexadecimalUnsignedLong_J;
		public unsafe global::Okio.IBufferedSink WriteHexadecimalUnsignedLong (long p0)
		{
			if (id_writeHexadecimalUnsignedLong_J == IntPtr.Zero)
				id_writeHexadecimalUnsignedLong_J = JNIEnv.GetMethodID (class_ref, "writeHexadecimalUnsignedLong", "(J)Lokio/BufferedSink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeHexadecimalUnsignedLong_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeInt_I;
#pragma warning disable 0169
		static Delegate GetWriteInt_IHandler ()
		{
			if (cb_writeInt_I == null)
				cb_writeInt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WriteInt_I);
			return cb_writeInt_I;
		}

		static IntPtr n_WriteInt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteInt (p0));
		}
#pragma warning restore 0169

		IntPtr id_writeInt_I;
		public unsafe global::Okio.IBufferedSink WriteInt (int p0)
		{
			if (id_writeInt_I == IntPtr.Zero)
				id_writeInt_I = JNIEnv.GetMethodID (class_ref, "writeInt", "(I)Lokio/BufferedSink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeInt_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeIntLe_I;
#pragma warning disable 0169
		static Delegate GetWriteIntLe_IHandler ()
		{
			if (cb_writeIntLe_I == null)
				cb_writeIntLe_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WriteIntLe_I);
			return cb_writeIntLe_I;
		}

		static IntPtr n_WriteIntLe_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteIntLe (p0));
		}
#pragma warning restore 0169

		IntPtr id_writeIntLe_I;
		public unsafe global::Okio.IBufferedSink WriteIntLe (int p0)
		{
			if (id_writeIntLe_I == IntPtr.Zero)
				id_writeIntLe_I = JNIEnv.GetMethodID (class_ref, "writeIntLe", "(I)Lokio/BufferedSink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeIntLe_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeLong_J;
#pragma warning disable 0169
		static Delegate GetWriteLong_JHandler ()
		{
			if (cb_writeLong_J == null)
				cb_writeLong_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_WriteLong_J);
			return cb_writeLong_J;
		}

		static IntPtr n_WriteLong_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteLong (p0));
		}
#pragma warning restore 0169

		IntPtr id_writeLong_J;
		public unsafe global::Okio.IBufferedSink WriteLong (long p0)
		{
			if (id_writeLong_J == IntPtr.Zero)
				id_writeLong_J = JNIEnv.GetMethodID (class_ref, "writeLong", "(J)Lokio/BufferedSink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeLong_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeLongLe_J;
#pragma warning disable 0169
		static Delegate GetWriteLongLe_JHandler ()
		{
			if (cb_writeLongLe_J == null)
				cb_writeLongLe_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_WriteLongLe_J);
			return cb_writeLongLe_J;
		}

		static IntPtr n_WriteLongLe_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteLongLe (p0));
		}
#pragma warning restore 0169

		IntPtr id_writeLongLe_J;
		public unsafe global::Okio.IBufferedSink WriteLongLe (long p0)
		{
			if (id_writeLongLe_J == IntPtr.Zero)
				id_writeLongLe_J = JNIEnv.GetMethodID (class_ref, "writeLongLe", "(J)Lokio/BufferedSink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeLongLe_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeShort_I;
#pragma warning disable 0169
		static Delegate GetWriteShort_IHandler ()
		{
			if (cb_writeShort_I == null)
				cb_writeShort_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WriteShort_I);
			return cb_writeShort_I;
		}

		static IntPtr n_WriteShort_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteShort (p0));
		}
#pragma warning restore 0169

		IntPtr id_writeShort_I;
		public unsafe global::Okio.IBufferedSink WriteShort (int p0)
		{
			if (id_writeShort_I == IntPtr.Zero)
				id_writeShort_I = JNIEnv.GetMethodID (class_ref, "writeShort", "(I)Lokio/BufferedSink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeShort_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeShortLe_I;
#pragma warning disable 0169
		static Delegate GetWriteShortLe_IHandler ()
		{
			if (cb_writeShortLe_I == null)
				cb_writeShortLe_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WriteShortLe_I);
			return cb_writeShortLe_I;
		}

		static IntPtr n_WriteShortLe_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteShortLe (p0));
		}
#pragma warning restore 0169

		IntPtr id_writeShortLe_I;
		public unsafe global::Okio.IBufferedSink WriteShortLe (int p0)
		{
			if (id_writeShortLe_I == IntPtr.Zero)
				id_writeShortLe_I = JNIEnv.GetMethodID (class_ref, "writeShortLe", "(I)Lokio/BufferedSink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeShortLe_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeString_Ljava_lang_String_IILjava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetWriteString_Ljava_lang_String_IILjava_nio_charset_Charset_Handler ()
		{
			if (cb_writeString_Ljava_lang_String_IILjava_nio_charset_Charset_ == null)
				cb_writeString_Ljava_lang_String_IILjava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_WriteString_Ljava_lang_String_IILjava_nio_charset_Charset_);
			return cb_writeString_Ljava_lang_String_IILjava_nio_charset_Charset_;
		}

		static IntPtr n_WriteString_Ljava_lang_String_IILjava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset p3 = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WriteString (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeString_Ljava_lang_String_IILjava_nio_charset_Charset_;
		public unsafe global::Okio.IBufferedSink WriteString (string p0, int p1, int p2, global::Java.Nio.Charset.Charset p3)
		{
			if (id_writeString_Ljava_lang_String_IILjava_nio_charset_Charset_ == IntPtr.Zero)
				id_writeString_Ljava_lang_String_IILjava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "writeString", "(Ljava/lang/String;IILjava/nio/charset/Charset;)Lokio/BufferedSink;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeString_Ljava_lang_String_IILjava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_writeString_Ljava_lang_String_Ljava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetWriteString_Ljava_lang_String_Ljava_nio_charset_Charset_Handler ()
		{
			if (cb_writeString_Ljava_lang_String_Ljava_nio_charset_Charset_ == null)
				cb_writeString_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteString_Ljava_lang_String_Ljava_nio_charset_Charset_);
			return cb_writeString_Ljava_lang_String_Ljava_nio_charset_Charset_;
		}

		static IntPtr n_WriteString_Ljava_lang_String_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WriteString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeString_Ljava_lang_String_Ljava_nio_charset_Charset_;
		public unsafe global::Okio.IBufferedSink WriteString (string p0, global::Java.Nio.Charset.Charset p1)
		{
			if (id_writeString_Ljava_lang_String_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_writeString_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "writeString", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Lokio/BufferedSink;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeString_Ljava_lang_String_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_writeUtf8_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteUtf8_Ljava_lang_String_Handler ()
		{
			if (cb_writeUtf8_Ljava_lang_String_ == null)
				cb_writeUtf8_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteUtf8_Ljava_lang_String_);
			return cb_writeUtf8_Ljava_lang_String_;
		}

		static IntPtr n_WriteUtf8_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WriteUtf8 (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeUtf8_Ljava_lang_String_;
		public unsafe global::Okio.IBufferedSink WriteUtf8 (string p0)
		{
			if (id_writeUtf8_Ljava_lang_String_ == IntPtr.Zero)
				id_writeUtf8_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeUtf8", "(Ljava/lang/String;)Lokio/BufferedSink;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeUtf8_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_writeUtf8_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetWriteUtf8_Ljava_lang_String_IIHandler ()
		{
			if (cb_writeUtf8_Ljava_lang_String_II == null)
				cb_writeUtf8_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_WriteUtf8_Ljava_lang_String_II);
			return cb_writeUtf8_Ljava_lang_String_II;
		}

		static IntPtr n_WriteUtf8_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WriteUtf8 (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeUtf8_Ljava_lang_String_II;
		public unsafe global::Okio.IBufferedSink WriteUtf8 (string p0, int p1, int p2)
		{
			if (id_writeUtf8_Ljava_lang_String_II == IntPtr.Zero)
				id_writeUtf8_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "writeUtf8", "(Ljava/lang/String;II)Lokio/BufferedSink;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeUtf8_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_writeUtf8CodePoint_I;
#pragma warning disable 0169
		static Delegate GetWriteUtf8CodePoint_IHandler ()
		{
			if (cb_writeUtf8CodePoint_I == null)
				cb_writeUtf8CodePoint_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WriteUtf8CodePoint_I);
			return cb_writeUtf8CodePoint_I;
		}

		static IntPtr n_WriteUtf8CodePoint_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteUtf8CodePoint (p0));
		}
#pragma warning restore 0169

		IntPtr id_writeUtf8CodePoint_I;
		public unsafe global::Okio.IBufferedSink WriteUtf8CodePoint (int p0)
		{
			if (id_writeUtf8CodePoint_I == IntPtr.Zero)
				id_writeUtf8CodePoint_I = JNIEnv.GetMethodID (class_ref, "writeUtf8CodePoint", "(I)Lokio/BufferedSink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeUtf8CodePoint_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_write_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_write_Ljava_nio_ByteBuffer_ == null)
				cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_nio_ByteBuffer_);
			return cb_write_Ljava_nio_ByteBuffer_;
		}

		static int n_Write_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer src = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_src, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Write (src);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_write_Ljava_nio_ByteBuffer_;
		public unsafe global::System.Int32 Write (global::Java.Nio.ByteBuffer src)
		{
			if (id_write_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_write_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/ByteBuffer;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
			global::System.Int32 __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_ByteBuffer_, __args);
			return __ret;
		}

		static Delegate cb_isOpen;
#pragma warning disable 0169
		static Delegate GetIsOpenHandler ()
		{
			if (cb_isOpen == null)
				cb_isOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpen);
			return cb_isOpen;
		}

		static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		IntPtr id_isOpen;
		public unsafe global::System.Boolean IsOpen {
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen);
			}
		}

		static Delegate cb_timeout;
#pragma warning disable 0169
		static Delegate GetTimeoutHandler ()
		{
			if (cb_timeout == null)
				cb_timeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Timeout);
			return cb_timeout;
		}

		static IntPtr n_Timeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Timeout ());
		}
#pragma warning restore 0169

		IntPtr id_timeout;
		public unsafe global::Okio.Timeout Timeout ()
		{
			if (id_timeout == IntPtr.Zero)
				id_timeout = JNIEnv.GetMethodID (class_ref, "timeout", "()Lokio/Timeout;");
			return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_write_Lokio_Buffer_J;
#pragma warning disable 0169
		static Delegate GetWrite_Lokio_Buffer_JHandler ()
		{
			if (cb_write_Lokio_Buffer_J == null)
				cb_write_Lokio_Buffer_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_Write_Lokio_Buffer_J);
			return cb_write_Lokio_Buffer_J;
		}

		static void n_Write_Lokio_Buffer_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Okio.IBufferedSink __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.Buffer p0 = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_write_Lokio_Buffer_J;
		public unsafe void Write (global::Okio.Buffer p0, long p1)
		{
			if (id_write_Lokio_Buffer_J == IntPtr.Zero)
				id_write_Lokio_Buffer_J = JNIEnv.GetMethodID (class_ref, "write", "(Lokio/Buffer;J)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lokio_Buffer_J, __args);
		}

	}

}
