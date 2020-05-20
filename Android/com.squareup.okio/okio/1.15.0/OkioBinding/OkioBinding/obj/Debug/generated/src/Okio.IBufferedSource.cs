using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']"
	[Register ("okio/BufferedSource", "", "Okio.IBufferedSourceInvoker")]
	public partial interface IBufferedSource : global::Java.Nio.Channels.IReadableByteChannel, global::Okio.ISource {

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='buffer' and count(parameter)=0]"
		[Register ("buffer", "()Lokio/Buffer;", "GetBufferHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		global::Okio.Buffer Buffer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='exhausted' and count(parameter)=0]"
		[Register ("exhausted", "()Z", "GetExhaustedHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		bool Exhausted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("indexOf", "(B)J", "GetIndexOf_BHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		long IndexOf (sbyte p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='long']]"
		[Register ("indexOf", "(BJ)J", "GetIndexOf_BJHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		long IndexOf (sbyte p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("indexOf", "(BJJ)J", "GetIndexOf_BJJHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		long IndexOf (sbyte p0, long p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("indexOf", "(Lokio/ByteString;)J", "GetIndexOf_Lokio_ByteString_Handler:Okio.IBufferedSourceInvoker, OkioBinding")]
		long IndexOf (global::Okio.ByteString p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='okio.ByteString'] and parameter[2][@type='long']]"
		[Register ("indexOf", "(Lokio/ByteString;J)J", "GetIndexOf_Lokio_ByteString_JHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		long IndexOf (global::Okio.ByteString p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='indexOfElement' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("indexOfElement", "(Lokio/ByteString;)J", "GetIndexOfElement_Lokio_ByteString_Handler:Okio.IBufferedSourceInvoker, OkioBinding")]
		long IndexOfElement (global::Okio.ByteString p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='indexOfElement' and count(parameter)=2 and parameter[1][@type='okio.ByteString'] and parameter[2][@type='long']]"
		[Register ("indexOfElement", "(Lokio/ByteString;J)J", "GetIndexOfElement_Lokio_ByteString_JHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		long IndexOfElement (global::Okio.ByteString p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='inputStream' and count(parameter)=0]"
		[Register ("inputStream", "()Ljava/io/InputStream;", "GetInputStreamHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		global::System.IO.Stream InputStream ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='rangeEquals' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='okio.ByteString']]"
		[Register ("rangeEquals", "(JLokio/ByteString;)Z", "GetRangeEquals_JLokio_ByteString_Handler:Okio.IBufferedSourceInvoker, OkioBinding")]
		bool RangeEquals (long p0, global::Okio.ByteString p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='rangeEquals' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='okio.ByteString'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("rangeEquals", "(JLokio/ByteString;II)Z", "GetRangeEquals_JLokio_ByteString_IIHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		bool RangeEquals (long p0, global::Okio.ByteString p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "GetRead_arrayBHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		int Read (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "GetRead_arrayBIIHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		int Read (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readAll' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register ("readAll", "(Lokio/Sink;)J", "GetReadAll_Lokio_Sink_Handler:Okio.IBufferedSourceInvoker, OkioBinding")]
		long ReadAll (global::Okio.ISink p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readByte' and count(parameter)=0]"
		[Register ("readByte", "()B", "GetReadByteHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		sbyte ReadByte ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readByteArray' and count(parameter)=0]"
		[Register ("readByteArray", "()[B", "GetReadByteArrayHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		byte[] ReadByteArray ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readByteArray' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("readByteArray", "(J)[B", "GetReadByteArray_JHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		byte[] ReadByteArray (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readByteString' and count(parameter)=0]"
		[Register ("readByteString", "()Lokio/ByteString;", "GetReadByteStringHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		global::Okio.ByteString ReadByteString ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readByteString' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("readByteString", "(J)Lokio/ByteString;", "GetReadByteString_JHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		global::Okio.ByteString ReadByteString (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readDecimalLong' and count(parameter)=0]"
		[Register ("readDecimalLong", "()J", "GetReadDecimalLongHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		long ReadDecimalLong ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readFully' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("readFully", "([B)V", "GetReadFully_arrayBHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		void ReadFully (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readFully' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("readFully", "(Lokio/Buffer;J)V", "GetReadFully_Lokio_Buffer_JHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		void ReadFully (global::Okio.Buffer p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readHexadecimalUnsignedLong' and count(parameter)=0]"
		[Register ("readHexadecimalUnsignedLong", "()J", "GetReadHexadecimalUnsignedLongHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		long ReadHexadecimalUnsignedLong ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readInt' and count(parameter)=0]"
		[Register ("readInt", "()I", "GetReadIntHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		int ReadInt ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readIntLe' and count(parameter)=0]"
		[Register ("readIntLe", "()I", "GetReadIntLeHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		int ReadIntLe ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readLong' and count(parameter)=0]"
		[Register ("readLong", "()J", "GetReadLongHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		long ReadLong ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readLongLe' and count(parameter)=0]"
		[Register ("readLongLe", "()J", "GetReadLongLeHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		long ReadLongLe ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readShort' and count(parameter)=0]"
		[Register ("readShort", "()S", "GetReadShortHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		short ReadShort ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readShortLe' and count(parameter)=0]"
		[Register ("readShortLe", "()S", "GetReadShortLeHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		short ReadShortLe ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readString' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("readString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;", "GetReadString_Ljava_nio_charset_Charset_Handler:Okio.IBufferedSourceInvoker, OkioBinding")]
		string ReadString (global::Java.Nio.Charset.Charset p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readString' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("readString", "(JLjava/nio/charset/Charset;)Ljava/lang/String;", "GetReadString_JLjava_nio_charset_Charset_Handler:Okio.IBufferedSourceInvoker, OkioBinding")]
		string ReadString (long p0, global::Java.Nio.Charset.Charset p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readUtf8' and count(parameter)=0]"
		[Register ("readUtf8", "()Ljava/lang/String;", "GetReadUtf8Handler:Okio.IBufferedSourceInvoker, OkioBinding")]
		string ReadUtf8 ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readUtf8' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("readUtf8", "(J)Ljava/lang/String;", "GetReadUtf8_JHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		string ReadUtf8 (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readUtf8CodePoint' and count(parameter)=0]"
		[Register ("readUtf8CodePoint", "()I", "GetReadUtf8CodePointHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		int ReadUtf8CodePoint ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readUtf8Line' and count(parameter)=0]"
		[Register ("readUtf8Line", "()Ljava/lang/String;", "GetReadUtf8LineHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		string ReadUtf8Line ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readUtf8LineStrict' and count(parameter)=0]"
		[Register ("readUtf8LineStrict", "()Ljava/lang/String;", "GetReadUtf8LineStrictHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		string ReadUtf8LineStrict ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='readUtf8LineStrict' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("readUtf8LineStrict", "(J)Ljava/lang/String;", "GetReadUtf8LineStrict_JHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		string ReadUtf8LineStrict (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='request' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("request", "(J)Z", "GetRequest_JHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		bool Request (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='require' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("require", "(J)V", "GetRequire_JHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		void Require (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='select' and count(parameter)=1 and parameter[1][@type='okio.Options']]"
		[Register ("select", "(Lokio/Options;)I", "GetSelect_Lokio_Options_Handler:Okio.IBufferedSourceInvoker, OkioBinding")]
		int Select (global::Okio.Options p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skip", "(J)V", "GetSkip_JHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		void Skip (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Okio.IBufferedSourceInvoker, OkioBinding")]
		void Close ();

	}

	[global::Android.Runtime.Register ("okio/BufferedSource", DoNotGenerateAcw=true)]
	internal partial class IBufferedSourceInvoker : global::Java.Lang.Object, IBufferedSource {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/BufferedSource", typeof (IBufferedSourceInvoker));

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

		public static IBufferedSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBufferedSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okio.BufferedSource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBufferedSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_exhausted;
#pragma warning disable 0169
		static Delegate GetExhaustedHandler ()
		{
			if (cb_exhausted == null)
				cb_exhausted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Exhausted);
			return cb_exhausted;
		}

		static bool n_Exhausted (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Exhausted ();
		}
#pragma warning restore 0169

		IntPtr id_exhausted;
		public unsafe bool Exhausted ()
		{
			if (id_exhausted == IntPtr.Zero)
				id_exhausted = JNIEnv.GetMethodID (class_ref, "exhausted", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_exhausted);
		}

		static Delegate cb_indexOf_B;
#pragma warning disable 0169
		static Delegate GetIndexOf_BHandler ()
		{
			if (cb_indexOf_B == null)
				cb_indexOf_B = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, long>) n_IndexOf_B);
			return cb_indexOf_B;
		}

		static long n_IndexOf_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexOf (p0);
		}
#pragma warning restore 0169

		IntPtr id_indexOf_B;
		public unsafe long IndexOf (sbyte p0)
		{
			if (id_indexOf_B == IntPtr.Zero)
				id_indexOf_B = JNIEnv.GetMethodID (class_ref, "indexOf", "(B)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_B, __args);
		}

		static Delegate cb_indexOf_BJ;
#pragma warning disable 0169
		static Delegate GetIndexOf_BJHandler ()
		{
			if (cb_indexOf_BJ == null)
				cb_indexOf_BJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, long, long>) n_IndexOf_BJ);
			return cb_indexOf_BJ;
		}

		static long n_IndexOf_BJ (IntPtr jnienv, IntPtr native__this, sbyte p0, long p1)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexOf (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_indexOf_BJ;
		public unsafe long IndexOf (sbyte p0, long p1)
		{
			if (id_indexOf_BJ == IntPtr.Zero)
				id_indexOf_BJ = JNIEnv.GetMethodID (class_ref, "indexOf", "(BJ)J");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_BJ, __args);
		}

		static Delegate cb_indexOf_BJJ;
#pragma warning disable 0169
		static Delegate GetIndexOf_BJJHandler ()
		{
			if (cb_indexOf_BJJ == null)
				cb_indexOf_BJJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, long, long, long>) n_IndexOf_BJJ);
			return cb_indexOf_BJJ;
		}

		static long n_IndexOf_BJJ (IntPtr jnienv, IntPtr native__this, sbyte p0, long p1, long p2)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexOf (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_indexOf_BJJ;
		public unsafe long IndexOf (sbyte p0, long p1, long p2)
		{
			if (id_indexOf_BJJ == IntPtr.Zero)
				id_indexOf_BJJ = JNIEnv.GetMethodID (class_ref, "indexOf", "(BJJ)J");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_BJJ, __args);
		}

		static Delegate cb_indexOf_Lokio_ByteString_;
#pragma warning disable 0169
		static Delegate GetIndexOf_Lokio_ByteString_Handler ()
		{
			if (cb_indexOf_Lokio_ByteString_ == null)
				cb_indexOf_Lokio_ByteString_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_IndexOf_Lokio_ByteString_);
			return cb_indexOf_Lokio_ByteString_;
		}

		static long n_IndexOf_Lokio_ByteString_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ByteString p0 = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.IndexOf (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_indexOf_Lokio_ByteString_;
		public unsafe long IndexOf (global::Okio.ByteString p0)
		{
			if (id_indexOf_Lokio_ByteString_ == IntPtr.Zero)
				id_indexOf_Lokio_ByteString_ = JNIEnv.GetMethodID (class_ref, "indexOf", "(Lokio/ByteString;)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_Lokio_ByteString_, __args);
			return __ret;
		}

		static Delegate cb_indexOf_Lokio_ByteString_J;
#pragma warning disable 0169
		static Delegate GetIndexOf_Lokio_ByteString_JHandler ()
		{
			if (cb_indexOf_Lokio_ByteString_J == null)
				cb_indexOf_Lokio_ByteString_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long>) n_IndexOf_Lokio_ByteString_J);
			return cb_indexOf_Lokio_ByteString_J;
		}

		static long n_IndexOf_Lokio_ByteString_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ByteString p0 = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.IndexOf (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_indexOf_Lokio_ByteString_J;
		public unsafe long IndexOf (global::Okio.ByteString p0, long p1)
		{
			if (id_indexOf_Lokio_ByteString_J == IntPtr.Zero)
				id_indexOf_Lokio_ByteString_J = JNIEnv.GetMethodID (class_ref, "indexOf", "(Lokio/ByteString;J)J");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_Lokio_ByteString_J, __args);
			return __ret;
		}

		static Delegate cb_indexOfElement_Lokio_ByteString_;
#pragma warning disable 0169
		static Delegate GetIndexOfElement_Lokio_ByteString_Handler ()
		{
			if (cb_indexOfElement_Lokio_ByteString_ == null)
				cb_indexOfElement_Lokio_ByteString_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_IndexOfElement_Lokio_ByteString_);
			return cb_indexOfElement_Lokio_ByteString_;
		}

		static long n_IndexOfElement_Lokio_ByteString_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ByteString p0 = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.IndexOfElement (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_indexOfElement_Lokio_ByteString_;
		public unsafe long IndexOfElement (global::Okio.ByteString p0)
		{
			if (id_indexOfElement_Lokio_ByteString_ == IntPtr.Zero)
				id_indexOfElement_Lokio_ByteString_ = JNIEnv.GetMethodID (class_ref, "indexOfElement", "(Lokio/ByteString;)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_indexOfElement_Lokio_ByteString_, __args);
			return __ret;
		}

		static Delegate cb_indexOfElement_Lokio_ByteString_J;
#pragma warning disable 0169
		static Delegate GetIndexOfElement_Lokio_ByteString_JHandler ()
		{
			if (cb_indexOfElement_Lokio_ByteString_J == null)
				cb_indexOfElement_Lokio_ByteString_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long>) n_IndexOfElement_Lokio_ByteString_J);
			return cb_indexOfElement_Lokio_ByteString_J;
		}

		static long n_IndexOfElement_Lokio_ByteString_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ByteString p0 = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.IndexOfElement (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_indexOfElement_Lokio_ByteString_J;
		public unsafe long IndexOfElement (global::Okio.ByteString p0, long p1)
		{
			if (id_indexOfElement_Lokio_ByteString_J == IntPtr.Zero)
				id_indexOfElement_Lokio_ByteString_J = JNIEnv.GetMethodID (class_ref, "indexOfElement", "(Lokio/ByteString;J)J");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_indexOfElement_Lokio_ByteString_J, __args);
			return __ret;
		}

		static Delegate cb_inputStream;
#pragma warning disable 0169
		static Delegate GetInputStreamHandler ()
		{
			if (cb_inputStream == null)
				cb_inputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InputStream);
			return cb_inputStream;
		}

		static IntPtr n_InputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream ());
		}
#pragma warning restore 0169

		IntPtr id_inputStream;
		public unsafe global::System.IO.Stream InputStream ()
		{
			if (id_inputStream == IntPtr.Zero)
				id_inputStream = JNIEnv.GetMethodID (class_ref, "inputStream", "()Ljava/io/InputStream;");
			return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_inputStream), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_rangeEquals_JLokio_ByteString_;
#pragma warning disable 0169
		static Delegate GetRangeEquals_JLokio_ByteString_Handler ()
		{
			if (cb_rangeEquals_JLokio_ByteString_ == null)
				cb_rangeEquals_JLokio_ByteString_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_RangeEquals_JLokio_ByteString_);
			return cb_rangeEquals_JLokio_ByteString_;
		}

		static bool n_RangeEquals_JLokio_ByteString_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ByteString p1 = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RangeEquals (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rangeEquals_JLokio_ByteString_;
		public unsafe bool RangeEquals (long p0, global::Okio.ByteString p1)
		{
			if (id_rangeEquals_JLokio_ByteString_ == IntPtr.Zero)
				id_rangeEquals_JLokio_ByteString_ = JNIEnv.GetMethodID (class_ref, "rangeEquals", "(JLokio/ByteString;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_rangeEquals_JLokio_ByteString_, __args);
			return __ret;
		}

		static Delegate cb_rangeEquals_JLokio_ByteString_II;
#pragma warning disable 0169
		static Delegate GetRangeEquals_JLokio_ByteString_IIHandler ()
		{
			if (cb_rangeEquals_JLokio_ByteString_II == null)
				cb_rangeEquals_JLokio_ByteString_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int, int, bool>) n_RangeEquals_JLokio_ByteString_II);
			return cb_rangeEquals_JLokio_ByteString_II;
		}

		static bool n_RangeEquals_JLokio_ByteString_II (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2, int p3)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ByteString p1 = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RangeEquals (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rangeEquals_JLokio_ByteString_II;
		public unsafe bool RangeEquals (long p0, global::Okio.ByteString p1, int p2, int p3)
		{
			if (id_rangeEquals_JLokio_ByteString_II == IntPtr.Zero)
				id_rangeEquals_JLokio_ByteString_II = JNIEnv.GetMethodID (class_ref, "rangeEquals", "(JLokio/ByteString;II)Z");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_rangeEquals_JLokio_ByteString_II, __args);
			return __ret;
		}

		static Delegate cb_read_arrayB;
#pragma warning disable 0169
		static Delegate GetRead_arrayBHandler ()
		{
			if (cb_read_arrayB == null)
				cb_read_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Read_arrayB);
			return cb_read_arrayB;
		}

		static int n_Read_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_arrayB;
		public unsafe int Read (byte[] p0)
		{
			if (id_read_arrayB == IntPtr.Zero)
				id_read_arrayB = JNIEnv.GetMethodID (class_ref, "read", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_read_arrayBII;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIIHandler ()
		{
			if (cb_read_arrayBII == null)
				cb_read_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_Read_arrayBII);
			return cb_read_arrayBII;
		}

		static int n_Read_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_arrayBII;
		public unsafe int Read (byte[] p0, int p1, int p2)
		{
			if (id_read_arrayBII == IntPtr.Zero)
				id_read_arrayBII = JNIEnv.GetMethodID (class_ref, "read", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_readAll_Lokio_Sink_;
#pragma warning disable 0169
		static Delegate GetReadAll_Lokio_Sink_Handler ()
		{
			if (cb_readAll_Lokio_Sink_ == null)
				cb_readAll_Lokio_Sink_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_ReadAll_Lokio_Sink_);
			return cb_readAll_Lokio_Sink_;
		}

		static long n_ReadAll_Lokio_Sink_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ISink p0 = (global::Okio.ISink)global::Java.Lang.Object.GetObject<global::Okio.ISink> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.ReadAll (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readAll_Lokio_Sink_;
		public unsafe long ReadAll (global::Okio.ISink p0)
		{
			if (id_readAll_Lokio_Sink_ == IntPtr.Zero)
				id_readAll_Lokio_Sink_ = JNIEnv.GetMethodID (class_ref, "readAll", "(Lokio/Sink;)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readAll_Lokio_Sink_, __args);
			return __ret;
		}

		static Delegate cb_readByte;
#pragma warning disable 0169
		static Delegate GetReadByteHandler ()
		{
			if (cb_readByte == null)
				cb_readByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_ReadByte);
			return cb_readByte;
		}

		static sbyte n_ReadByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadByte ();
		}
#pragma warning restore 0169

		IntPtr id_readByte;
		public unsafe sbyte ReadByte ()
		{
			if (id_readByte == IntPtr.Zero)
				id_readByte = JNIEnv.GetMethodID (class_ref, "readByte", "()B");
			return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_readByte);
		}

		static Delegate cb_readByteArray;
#pragma warning disable 0169
		static Delegate GetReadByteArrayHandler ()
		{
			if (cb_readByteArray == null)
				cb_readByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadByteArray);
			return cb_readByteArray;
		}

		static IntPtr n_ReadByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadByteArray ());
		}
#pragma warning restore 0169

		IntPtr id_readByteArray;
		public unsafe byte[] ReadByteArray ()
		{
			if (id_readByteArray == IntPtr.Zero)
				id_readByteArray = JNIEnv.GetMethodID (class_ref, "readByteArray", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_readByteArray_J;
#pragma warning disable 0169
		static Delegate GetReadByteArray_JHandler ()
		{
			if (cb_readByteArray_J == null)
				cb_readByteArray_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_ReadByteArray_J);
			return cb_readByteArray_J;
		}

		static IntPtr n_ReadByteArray_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadByteArray (p0));
		}
#pragma warning restore 0169

		IntPtr id_readByteArray_J;
		public unsafe byte[] ReadByteArray (long p0)
		{
			if (id_readByteArray_J == IntPtr.Zero)
				id_readByteArray_J = JNIEnv.GetMethodID (class_ref, "readByteArray", "(J)[B");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readByteArray_J, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_readByteString;
#pragma warning disable 0169
		static Delegate GetReadByteStringHandler ()
		{
			if (cb_readByteString == null)
				cb_readByteString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadByteString);
			return cb_readByteString;
		}

		static IntPtr n_ReadByteString (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadByteString ());
		}
#pragma warning restore 0169

		IntPtr id_readByteString;
		public unsafe global::Okio.ByteString ReadByteString ()
		{
			if (id_readByteString == IntPtr.Zero)
				id_readByteString = JNIEnv.GetMethodID (class_ref, "readByteString", "()Lokio/ByteString;");
			return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readByteString), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_readByteString_J;
#pragma warning disable 0169
		static Delegate GetReadByteString_JHandler ()
		{
			if (cb_readByteString_J == null)
				cb_readByteString_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_ReadByteString_J);
			return cb_readByteString_J;
		}

		static IntPtr n_ReadByteString_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadByteString (p0));
		}
#pragma warning restore 0169

		IntPtr id_readByteString_J;
		public unsafe global::Okio.ByteString ReadByteString (long p0)
		{
			if (id_readByteString_J == IntPtr.Zero)
				id_readByteString_J = JNIEnv.GetMethodID (class_ref, "readByteString", "(J)Lokio/ByteString;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readByteString_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_readDecimalLong;
#pragma warning disable 0169
		static Delegate GetReadDecimalLongHandler ()
		{
			if (cb_readDecimalLong == null)
				cb_readDecimalLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ReadDecimalLong);
			return cb_readDecimalLong;
		}

		static long n_ReadDecimalLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadDecimalLong ();
		}
#pragma warning restore 0169

		IntPtr id_readDecimalLong;
		public unsafe long ReadDecimalLong ()
		{
			if (id_readDecimalLong == IntPtr.Zero)
				id_readDecimalLong = JNIEnv.GetMethodID (class_ref, "readDecimalLong", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readDecimalLong);
		}

		static Delegate cb_readFully_arrayB;
#pragma warning disable 0169
		static Delegate GetReadFully_arrayBHandler ()
		{
			if (cb_readFully_arrayB == null)
				cb_readFully_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReadFully_arrayB);
			return cb_readFully_arrayB;
		}

		static void n_ReadFully_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ReadFully (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_readFully_arrayB;
		public unsafe void ReadFully (byte[] p0)
		{
			if (id_readFully_arrayB == IntPtr.Zero)
				id_readFully_arrayB = JNIEnv.GetMethodID (class_ref, "readFully", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readFully_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_readFully_Lokio_Buffer_J;
#pragma warning disable 0169
		static Delegate GetReadFully_Lokio_Buffer_JHandler ()
		{
			if (cb_readFully_Lokio_Buffer_J == null)
				cb_readFully_Lokio_Buffer_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_ReadFully_Lokio_Buffer_J);
			return cb_readFully_Lokio_Buffer_J;
		}

		static void n_ReadFully_Lokio_Buffer_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.Buffer p0 = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadFully (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_readFully_Lokio_Buffer_J;
		public unsafe void ReadFully (global::Okio.Buffer p0, long p1)
		{
			if (id_readFully_Lokio_Buffer_J == IntPtr.Zero)
				id_readFully_Lokio_Buffer_J = JNIEnv.GetMethodID (class_ref, "readFully", "(Lokio/Buffer;J)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readFully_Lokio_Buffer_J, __args);
		}

		static Delegate cb_readHexadecimalUnsignedLong;
#pragma warning disable 0169
		static Delegate GetReadHexadecimalUnsignedLongHandler ()
		{
			if (cb_readHexadecimalUnsignedLong == null)
				cb_readHexadecimalUnsignedLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ReadHexadecimalUnsignedLong);
			return cb_readHexadecimalUnsignedLong;
		}

		static long n_ReadHexadecimalUnsignedLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadHexadecimalUnsignedLong ();
		}
#pragma warning restore 0169

		IntPtr id_readHexadecimalUnsignedLong;
		public unsafe long ReadHexadecimalUnsignedLong ()
		{
			if (id_readHexadecimalUnsignedLong == IntPtr.Zero)
				id_readHexadecimalUnsignedLong = JNIEnv.GetMethodID (class_ref, "readHexadecimalUnsignedLong", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readHexadecimalUnsignedLong);
		}

		static Delegate cb_readInt;
#pragma warning disable 0169
		static Delegate GetReadIntHandler ()
		{
			if (cb_readInt == null)
				cb_readInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ReadInt);
			return cb_readInt;
		}

		static int n_ReadInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadInt ();
		}
#pragma warning restore 0169

		IntPtr id_readInt;
		public unsafe int ReadInt ()
		{
			if (id_readInt == IntPtr.Zero)
				id_readInt = JNIEnv.GetMethodID (class_ref, "readInt", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readInt);
		}

		static Delegate cb_readIntLe;
#pragma warning disable 0169
		static Delegate GetReadIntLeHandler ()
		{
			if (cb_readIntLe == null)
				cb_readIntLe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ReadIntLe);
			return cb_readIntLe;
		}

		static int n_ReadIntLe (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadIntLe ();
		}
#pragma warning restore 0169

		IntPtr id_readIntLe;
		public unsafe int ReadIntLe ()
		{
			if (id_readIntLe == IntPtr.Zero)
				id_readIntLe = JNIEnv.GetMethodID (class_ref, "readIntLe", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readIntLe);
		}

		static Delegate cb_readLong;
#pragma warning disable 0169
		static Delegate GetReadLongHandler ()
		{
			if (cb_readLong == null)
				cb_readLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ReadLong);
			return cb_readLong;
		}

		static long n_ReadLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadLong ();
		}
#pragma warning restore 0169

		IntPtr id_readLong;
		public unsafe long ReadLong ()
		{
			if (id_readLong == IntPtr.Zero)
				id_readLong = JNIEnv.GetMethodID (class_ref, "readLong", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readLong);
		}

		static Delegate cb_readLongLe;
#pragma warning disable 0169
		static Delegate GetReadLongLeHandler ()
		{
			if (cb_readLongLe == null)
				cb_readLongLe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ReadLongLe);
			return cb_readLongLe;
		}

		static long n_ReadLongLe (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadLongLe ();
		}
#pragma warning restore 0169

		IntPtr id_readLongLe;
		public unsafe long ReadLongLe ()
		{
			if (id_readLongLe == IntPtr.Zero)
				id_readLongLe = JNIEnv.GetMethodID (class_ref, "readLongLe", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readLongLe);
		}

		static Delegate cb_readShort;
#pragma warning disable 0169
		static Delegate GetReadShortHandler ()
		{
			if (cb_readShort == null)
				cb_readShort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_ReadShort);
			return cb_readShort;
		}

		static short n_ReadShort (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadShort ();
		}
#pragma warning restore 0169

		IntPtr id_readShort;
		public unsafe short ReadShort ()
		{
			if (id_readShort == IntPtr.Zero)
				id_readShort = JNIEnv.GetMethodID (class_ref, "readShort", "()S");
			return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_readShort);
		}

		static Delegate cb_readShortLe;
#pragma warning disable 0169
		static Delegate GetReadShortLeHandler ()
		{
			if (cb_readShortLe == null)
				cb_readShortLe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_ReadShortLe);
			return cb_readShortLe;
		}

		static short n_ReadShortLe (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadShortLe ();
		}
#pragma warning restore 0169

		IntPtr id_readShortLe;
		public unsafe short ReadShortLe ()
		{
			if (id_readShortLe == IntPtr.Zero)
				id_readShortLe = JNIEnv.GetMethodID (class_ref, "readShortLe", "()S");
			return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_readShortLe);
		}

		static Delegate cb_readString_Ljava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetReadString_Ljava_nio_charset_Charset_Handler ()
		{
			if (cb_readString_Ljava_nio_charset_Charset_ == null)
				cb_readString_Ljava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadString_Ljava_nio_charset_Charset_);
			return cb_readString_Ljava_nio_charset_Charset_;
		}

		static IntPtr n_ReadString_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ReadString (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readString_Ljava_nio_charset_Charset_;
		public unsafe string ReadString (global::Java.Nio.Charset.Charset p0)
		{
			if (id_readString_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_readString_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "readString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readString_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_readString_JLjava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetReadString_JLjava_nio_charset_Charset_Handler ()
		{
			if (cb_readString_JLjava_nio_charset_Charset_ == null)
				cb_readString_JLjava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_ReadString_JLjava_nio_charset_Charset_);
			return cb_readString_JLjava_nio_charset_Charset_;
		}

		static IntPtr n_ReadString_JLjava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ReadString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readString_JLjava_nio_charset_Charset_;
		public unsafe string ReadString (long p0, global::Java.Nio.Charset.Charset p1)
		{
			if (id_readString_JLjava_nio_charset_Charset_ == IntPtr.Zero)
				id_readString_JLjava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "readString", "(JLjava/nio/charset/Charset;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readString_JLjava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_readUtf8;
#pragma warning disable 0169
		static Delegate GetReadUtf8Handler ()
		{
			if (cb_readUtf8 == null)
				cb_readUtf8 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadUtf8);
			return cb_readUtf8;
		}

		static IntPtr n_ReadUtf8 (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadUtf8 ());
		}
#pragma warning restore 0169

		IntPtr id_readUtf8;
		public unsafe string ReadUtf8 ()
		{
			if (id_readUtf8 == IntPtr.Zero)
				id_readUtf8 = JNIEnv.GetMethodID (class_ref, "readUtf8", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readUtf8), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_readUtf8_J;
#pragma warning disable 0169
		static Delegate GetReadUtf8_JHandler ()
		{
			if (cb_readUtf8_J == null)
				cb_readUtf8_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_ReadUtf8_J);
			return cb_readUtf8_J;
		}

		static IntPtr n_ReadUtf8_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadUtf8 (p0));
		}
#pragma warning restore 0169

		IntPtr id_readUtf8_J;
		public unsafe string ReadUtf8 (long p0)
		{
			if (id_readUtf8_J == IntPtr.Zero)
				id_readUtf8_J = JNIEnv.GetMethodID (class_ref, "readUtf8", "(J)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readUtf8_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_readUtf8CodePoint;
#pragma warning disable 0169
		static Delegate GetReadUtf8CodePointHandler ()
		{
			if (cb_readUtf8CodePoint == null)
				cb_readUtf8CodePoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ReadUtf8CodePoint);
			return cb_readUtf8CodePoint;
		}

		static int n_ReadUtf8CodePoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadUtf8CodePoint ();
		}
#pragma warning restore 0169

		IntPtr id_readUtf8CodePoint;
		public unsafe int ReadUtf8CodePoint ()
		{
			if (id_readUtf8CodePoint == IntPtr.Zero)
				id_readUtf8CodePoint = JNIEnv.GetMethodID (class_ref, "readUtf8CodePoint", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readUtf8CodePoint);
		}

		static Delegate cb_readUtf8Line;
#pragma warning disable 0169
		static Delegate GetReadUtf8LineHandler ()
		{
			if (cb_readUtf8Line == null)
				cb_readUtf8Line = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadUtf8Line);
			return cb_readUtf8Line;
		}

		static IntPtr n_ReadUtf8Line (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadUtf8Line ());
		}
#pragma warning restore 0169

		IntPtr id_readUtf8Line;
		public unsafe string ReadUtf8Line ()
		{
			if (id_readUtf8Line == IntPtr.Zero)
				id_readUtf8Line = JNIEnv.GetMethodID (class_ref, "readUtf8Line", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readUtf8Line), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_readUtf8LineStrict;
#pragma warning disable 0169
		static Delegate GetReadUtf8LineStrictHandler ()
		{
			if (cb_readUtf8LineStrict == null)
				cb_readUtf8LineStrict = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadUtf8LineStrict);
			return cb_readUtf8LineStrict;
		}

		static IntPtr n_ReadUtf8LineStrict (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadUtf8LineStrict ());
		}
#pragma warning restore 0169

		IntPtr id_readUtf8LineStrict;
		public unsafe string ReadUtf8LineStrict ()
		{
			if (id_readUtf8LineStrict == IntPtr.Zero)
				id_readUtf8LineStrict = JNIEnv.GetMethodID (class_ref, "readUtf8LineStrict", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readUtf8LineStrict), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_readUtf8LineStrict_J;
#pragma warning disable 0169
		static Delegate GetReadUtf8LineStrict_JHandler ()
		{
			if (cb_readUtf8LineStrict_J == null)
				cb_readUtf8LineStrict_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_ReadUtf8LineStrict_J);
			return cb_readUtf8LineStrict_J;
		}

		static IntPtr n_ReadUtf8LineStrict_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadUtf8LineStrict (p0));
		}
#pragma warning restore 0169

		IntPtr id_readUtf8LineStrict_J;
		public unsafe string ReadUtf8LineStrict (long p0)
		{
			if (id_readUtf8LineStrict_J == IntPtr.Zero)
				id_readUtf8LineStrict_J = JNIEnv.GetMethodID (class_ref, "readUtf8LineStrict", "(J)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readUtf8LineStrict_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_request_J;
#pragma warning disable 0169
		static Delegate GetRequest_JHandler ()
		{
			if (cb_request_J == null)
				cb_request_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_Request_J);
			return cb_request_J;
		}

		static bool n_Request_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Request (p0);
		}
#pragma warning restore 0169

		IntPtr id_request_J;
		public unsafe bool Request (long p0)
		{
			if (id_request_J == IntPtr.Zero)
				id_request_J = JNIEnv.GetMethodID (class_ref, "request", "(J)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_request_J, __args);
		}

		static Delegate cb_require_J;
#pragma warning disable 0169
		static Delegate GetRequire_JHandler ()
		{
			if (cb_require_J == null)
				cb_require_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Require_J);
			return cb_require_J;
		}

		static void n_Require_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Require (p0);
		}
#pragma warning restore 0169

		IntPtr id_require_J;
		public unsafe void Require (long p0)
		{
			if (id_require_J == IntPtr.Zero)
				id_require_J = JNIEnv.GetMethodID (class_ref, "require", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_require_J, __args);
		}

		static Delegate cb_select_Lokio_Options_;
#pragma warning disable 0169
		static Delegate GetSelect_Lokio_Options_Handler ()
		{
			if (cb_select_Lokio_Options_ == null)
				cb_select_Lokio_Options_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Select_Lokio_Options_);
			return cb_select_Lokio_Options_;
		}

		static int n_Select_Lokio_Options_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.Options p0 = global::Java.Lang.Object.GetObject<global::Okio.Options> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Select (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_select_Lokio_Options_;
		public unsafe int Select (global::Okio.Options p0)
		{
			if (id_select_Lokio_Options_ == IntPtr.Zero)
				id_select_Lokio_Options_ = JNIEnv.GetMethodID (class_ref, "select", "(Lokio/Options;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_select_Lokio_Options_, __args);
			return __ret;
		}

		static Delegate cb_skip_J;
#pragma warning disable 0169
		static Delegate GetSkip_JHandler ()
		{
			if (cb_skip_J == null)
				cb_skip_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Skip_J);
			return cb_skip_J;
		}

		static void n_Skip_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Skip (p0);
		}
#pragma warning restore 0169

		IntPtr id_skip_J;
		public unsafe void Skip (long p0)
		{
			if (id_skip_J == IntPtr.Zero)
				id_skip_J = JNIEnv.GetMethodID (class_ref, "skip", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skip_J, __args);
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
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_read_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_read_Ljava_nio_ByteBuffer_ == null)
				cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Read_Ljava_nio_ByteBuffer_);
			return cb_read_Ljava_nio_ByteBuffer_;
		}

		static int n_Read_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dst)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer dst = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_dst, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Read (dst);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_Ljava_nio_ByteBuffer_;
		public unsafe global::System.Int32 Read (global::Java.Nio.ByteBuffer dst)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
			global::System.Int32 __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_nio_ByteBuffer_, __args);
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
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_read_Lokio_Buffer_J;
#pragma warning disable 0169
		static Delegate GetRead_Lokio_Buffer_JHandler ()
		{
			if (cb_read_Lokio_Buffer_J == null)
				cb_read_Lokio_Buffer_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long>) n_Read_Lokio_Buffer_J);
			return cb_read_Lokio_Buffer_J;
		}

		static long n_Read_Lokio_Buffer_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.Buffer p0 = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Read (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_Lokio_Buffer_J;
		public unsafe long Read (global::Okio.Buffer p0, long p1)
		{
			if (id_read_Lokio_Buffer_J == IntPtr.Zero)
				id_read_Lokio_Buffer_J = JNIEnv.GetMethodID (class_ref, "read", "(Lokio/Buffer;J)J");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_read_Lokio_Buffer_J, __args);
			return __ret;
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
			global::Okio.IBufferedSource __this = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
