using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']"
	[global::Android.Runtime.Register ("okhttp3/internal/Util", DoNotGenerateAcw=true)]
	public sealed partial class Util : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='EMPTY_BYTE_ARRAY']"
		[Register ("EMPTY_BYTE_ARRAY")]
		public static IList<byte> EmptyByteArray {
			get {
				const string __id = "EMPTY_BYTE_ARRAY.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='EMPTY_REQUEST']"
		[Register ("EMPTY_REQUEST")]
		public static global::Okhttp3.RequestBody EmptyRequest {
			get {
				const string __id = "EMPTY_REQUEST.Lokhttp3/RequestBody;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='EMPTY_RESPONSE']"
		[Register ("EMPTY_RESPONSE")]
		public static global::Okhttp3.ResponseBody EmptyResponse {
			get {
				const string __id = "EMPTY_RESPONSE.Lokhttp3/ResponseBody;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='EMPTY_STRING_ARRAY']"
		[Register ("EMPTY_STRING_ARRAY")]
		public static IList<string> EmptyStringArray {
			get {
				const string __id = "EMPTY_STRING_ARRAY.[Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='ISO_8859_1']"
		[Register ("ISO_8859_1")]
		public static global::Java.Nio.Charset.Charset Iso88591 {
			get {
				const string __id = "ISO_8859_1.Ljava/nio/charset/Charset;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='NATURAL_ORDER']"
		[Register ("NATURAL_ORDER")]
		public static global::Java.Util.IComparator NaturalOrder {
			get {
				const string __id = "NATURAL_ORDER.Ljava/util/Comparator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='UTC']"
		[Register ("UTC")]
		public static global::Java.Util.TimeZone Utc {
			get {
				const string __id = "UTC.Ljava/util/TimeZone;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='UTF_8']"
		[Register ("UTF_8")]
		public static global::Java.Nio.Charset.Charset Utf8 {
			get {
				const string __id = "UTF_8.Ljava/nio/charset/Charset;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/Util", typeof (Util));
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

		internal Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='addSuppressedIfPossible' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("addSuppressedIfPossible", "(Ljava/lang/Throwable;Ljava/lang/Throwable;)V", "")]
		public static unsafe void AddSuppressedIfPossible (global::Java.Lang.Throwable e, global::Java.Lang.Throwable suppressed)
		{
			const string __id = "addSuppressedIfPossible.(Ljava/lang/Throwable;Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				__args [1] = new JniArgumentValue ((suppressed == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) suppressed).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='assertionError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("assertionError", "(Ljava/lang/String;Ljava/lang/Exception;)Ljava/lang/AssertionError;", "")]
		public static unsafe global::Java.Lang.AssertionError AssertionError (string message, global::Java.Lang.Exception e)
		{
			const string __id = "assertionError.(Ljava/lang/String;Ljava/lang/Exception;)Ljava/lang/AssertionError;";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.AssertionError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='canonicalizeHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("canonicalizeHost", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CanonicalizeHost (string host)
		{
			const string __id = "canonicalizeHost.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_host);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='checkDuration' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("checkDuration", "(Ljava/lang/String;JLjava/util/concurrent/TimeUnit;)I", "")]
		public static unsafe int CheckDuration (string name, long duration, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "checkDuration.(Ljava/lang/String;JLjava/util/concurrent/TimeUnit;)I";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (duration);
				__args [2] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='checkOffsetAndCount' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("checkOffsetAndCount", "(JJJ)V", "")]
		public static unsafe void CheckOffsetAndCount (long arrayLength, long offset, long count)
		{
			const string __id = "checkOffsetAndCount.(JJJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (arrayLength);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (count);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeQuietly", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseQuietly (global::Java.IO.ICloseable closeable)
		{
			const string __id = "closeQuietly.(Ljava/io/Closeable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((closeable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) closeable).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.net.ServerSocket']]"
		[Register ("closeQuietly", "(Ljava/net/ServerSocket;)V", "")]
		public static unsafe void CloseQuietly (global::Java.Net.ServerSocket serverSocket)
		{
			const string __id = "closeQuietly.(Ljava/net/ServerSocket;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((serverSocket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serverSocket).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("closeQuietly", "(Ljava/net/Socket;)V", "")]
		public static unsafe void CloseQuietly (global::Java.Net.Socket socket)
		{
			const string __id = "closeQuietly.(Ljava/net/Socket;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((socket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socket).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='concat' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("concat", "([Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] Concat (string[] array, string value)
		{
			const string __id = "concat.([Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='decodeHexDigit' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("decodeHexDigit", "(C)I", "")]
		public static unsafe int DecodeHexDigit (char c)
		{
			const string __id = "decodeHexDigit.(C)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='delimiterOffset' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='char']]"
		[Register ("delimiterOffset", "(Ljava/lang/String;IIC)I", "")]
		public static unsafe int DelimiterOffset (string input, int pos, int limit, char delimiter)
		{
			const string __id = "delimiterOffset.(Ljava/lang/String;IIC)I";
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue (limit);
				__args [3] = new JniArgumentValue (delimiter);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='delimiterOffset' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("delimiterOffset", "(Ljava/lang/String;IILjava/lang/String;)I", "")]
		public static unsafe int DelimiterOffset (string input, int pos, int limit, string delimiters)
		{
			const string __id = "delimiterOffset.(Ljava/lang/String;IILjava/lang/String;)I";
			IntPtr native_input = JNIEnv.NewString (input);
			IntPtr native_delimiters = JNIEnv.NewString (delimiters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue (limit);
				__args [3] = new JniArgumentValue (native_delimiters);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_delimiters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='equal' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("equal", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool Equal (global::Java.Lang.Object a, global::Java.Lang.Object b)
		{
			const string __id = "equal.(Ljava/lang/Object;Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string Format (string format, params global::Java.Lang.Object[] args)
		{
			const string __id = "format.(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='hostHeader' and count(parameter)=2 and parameter[1][@type='okhttp3.HttpUrl'] and parameter[2][@type='boolean']]"
		[Register ("hostHeader", "(Lokhttp3/HttpUrl;Z)Ljava/lang/String;", "")]
		public static unsafe string HostHeader (global::Okhttp3.HttpUrl url, bool includeDefaultPort)
		{
			const string __id = "hostHeader.(Lokhttp3/HttpUrl;Z)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue (includeDefaultPort);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='immutableList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register ("immutableList", "(Ljava/util/List;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList ImmutableList (global::System.Collections.IList list)
		{
			const string __id = "immutableList.(Ljava/util/List;)Ljava/util/List;";
			IntPtr native_list = global::Android.Runtime.JavaList.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_list);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='immutableList' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("immutableList", "([Ljava/lang/Object;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList ImmutableList (params global::Java.Lang.Object[] elements)
		{
			const string __id = "immutableList.([Ljava/lang/Object;)Ljava/util/List;";
			IntPtr native_elements = JNIEnv.NewArray (elements);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_elements);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (elements != null) {
					JNIEnv.CopyArray (native_elements, elements);
					JNIEnv.DeleteLocalRef (native_elements);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='immutableMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;K, V&gt;']]"
		[Register ("immutableMap", "(Ljava/util/Map;)Ljava/util/Map;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe global::System.Collections.IDictionary ImmutableMap (global::System.Collections.IDictionary map)
		{
			const string __id = "immutableMap.(Ljava/util/Map;)Ljava/util/Map;";
			IntPtr native_map = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (map);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_map);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='java.util.Comparator&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("indexOf", "(Ljava/util/Comparator;[Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int IndexOf (global::Java.Util.IComparator comparator, string[] array, string value)
		{
			const string __id = "indexOf.(Ljava/util/Comparator;[Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				__args [1] = new JniArgumentValue (native_array);
				__args [2] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='indexOfControlOrNonAscii' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("indexOfControlOrNonAscii", "(Ljava/lang/String;)I", "")]
		public static unsafe int IndexOfControlOrNonAscii (string input)
		{
			const string __id = "indexOfControlOrNonAscii.(Ljava/lang/String;)I";
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='intersect' and count(parameter)=3 and parameter[1][@type='java.util.Comparator&lt;? super java.lang.String&gt;'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("intersect", "(Ljava/util/Comparator;[Ljava/lang/String;[Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] Intersect (global::Java.Util.IComparator comparator, string[] first, string[] second)
		{
			const string __id = "intersect.(Ljava/util/Comparator;[Ljava/lang/String;[Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_first = JNIEnv.NewArray (first);
			IntPtr native_second = JNIEnv.NewArray (second);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				__args [1] = new JniArgumentValue (native_first);
				__args [2] = new JniArgumentValue (native_second);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				if (first != null) {
					JNIEnv.CopyArray (native_first, first);
					JNIEnv.DeleteLocalRef (native_first);
				}
				if (second != null) {
					JNIEnv.CopyArray (native_second, second);
					JNIEnv.DeleteLocalRef (native_second);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='isAndroidGetsocknameError' and count(parameter)=1 and parameter[1][@type='java.lang.AssertionError']]"
		[Register ("isAndroidGetsocknameError", "(Ljava/lang/AssertionError;)Z", "")]
		public static unsafe bool IsAndroidGetsocknameError (global::Java.Lang.AssertionError e)
		{
			const string __id = "isAndroidGetsocknameError.(Ljava/lang/AssertionError;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='nonEmptyIntersection' and count(parameter)=3 and parameter[1][@type='java.util.Comparator&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("nonEmptyIntersection", "(Ljava/util/Comparator;[Ljava/lang/String;[Ljava/lang/String;)Z", "")]
		public static unsafe bool NonEmptyIntersection (global::Java.Util.IComparator comparator, string[] first, string[] second)
		{
			const string __id = "nonEmptyIntersection.(Ljava/util/Comparator;[Ljava/lang/String;[Ljava/lang/String;)Z";
			IntPtr native_first = JNIEnv.NewArray (first);
			IntPtr native_second = JNIEnv.NewArray (second);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				__args [1] = new JniArgumentValue (native_first);
				__args [2] = new JniArgumentValue (native_second);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (first != null) {
					JNIEnv.CopyArray (native_first, first);
					JNIEnv.DeleteLocalRef (native_first);
				}
				if (second != null) {
					JNIEnv.CopyArray (native_second, second);
					JNIEnv.DeleteLocalRef (native_second);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='platformTrustManager' and count(parameter)=0]"
		[Register ("platformTrustManager", "()Ljavax/net/ssl/X509TrustManager;", "")]
		public static unsafe global::Javax.Net.Ssl.IX509TrustManager PlatformTrustManager ()
		{
			const string __id = "platformTrustManager.()Ljavax/net/ssl/X509TrustManager;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IX509TrustManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='skipLeadingAsciiWhitespace' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("skipLeadingAsciiWhitespace", "(Ljava/lang/String;II)I", "")]
		public static unsafe int SkipLeadingAsciiWhitespace (string input, int pos, int limit)
		{
			const string __id = "skipLeadingAsciiWhitespace.(Ljava/lang/String;II)I";
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue (limit);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='skipTrailingAsciiWhitespace' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("skipTrailingAsciiWhitespace", "(Ljava/lang/String;II)I", "")]
		public static unsafe int SkipTrailingAsciiWhitespace (string input, int pos, int limit)
		{
			const string __id = "skipTrailingAsciiWhitespace.(Ljava/lang/String;II)I";
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue (limit);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='threadFactory' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("threadFactory", "(Ljava/lang/String;Z)Ljava/util/concurrent/ThreadFactory;", "")]
		public static unsafe global::Java.Util.Concurrent.IThreadFactory ThreadFactory (string name, bool daemon)
		{
			const string __id = "threadFactory.(Ljava/lang/String;Z)Ljava/util/concurrent/ThreadFactory;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (daemon);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IThreadFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='toHeaders' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;']]"
		[Register ("toHeaders", "(Ljava/util/List;)Lokhttp3/Headers;", "")]
		public static unsafe global::Okhttp3.Headers ToHeaders (global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> headerBlock)
		{
			const string __id = "toHeaders.(Ljava/util/List;)Lokhttp3/Headers;";
			IntPtr native_headerBlock = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (headerBlock);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headerBlock);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_headerBlock);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='trimSubstring' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("trimSubstring", "(Ljava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string TrimSubstring (string @string, int pos, int limit)
		{
			const string __id = "trimSubstring.(Ljava/lang/String;II)Ljava/lang/String;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native__string);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue (limit);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='verifyAsIpAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("verifyAsIpAddress", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool VerifyAsIpAddress (string host)
		{
			const string __id = "verifyAsIpAddress.(Ljava/lang/String;)Z";
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_host);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

	}
}
