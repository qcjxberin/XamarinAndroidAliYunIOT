using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='Okio']"
	[global::Android.Runtime.Register ("okio/Okio", DoNotGenerateAcw=true)]
	public sealed partial class Okio : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/Okio", typeof (Okio));
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

		internal Okio (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='appendingSink' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("appendingSink", "(Ljava/io/File;)Lokio/Sink;", "")]
		public static unsafe global::Okio.ISink AppendingSink (global::Java.IO.File file)
		{
			const string __id = "appendingSink.(Ljava/io/File;)Lokio/Sink;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ISink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='blackhole' and count(parameter)=0]"
		[Register ("blackhole", "()Lokio/Sink;", "")]
		public static unsafe global::Okio.ISink Blackhole ()
		{
			const string __id = "blackhole.()Lokio/Sink;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ISink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='buffer' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register ("buffer", "(Lokio/Sink;)Lokio/BufferedSink;", "")]
		public static unsafe global::Okio.IBufferedSink Buffer (global::Okio.ISink sink)
		{
			const string __id = "buffer.(Lokio/Sink;)Lokio/BufferedSink;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='buffer' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register ("buffer", "(Lokio/Source;)Lokio/BufferedSource;", "")]
		public static unsafe global::Okio.IBufferedSource Buffer (global::Okio.ISource source)
		{
			const string __id = "buffer.(Lokio/Source;)Lokio/BufferedSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='sink' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("sink", "(Ljava/io/File;)Lokio/Sink;", "")]
		public static unsafe global::Okio.ISink Sink (global::Java.IO.File file)
		{
			const string __id = "sink.(Ljava/io/File;)Lokio/Sink;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ISink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='sink' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("sink", "(Ljava/io/OutputStream;)Lokio/Sink;", "")]
		public static unsafe global::Okio.ISink Sink (global::System.IO.Stream @out)
		{
			const string __id = "sink.(Ljava/io/OutputStream;)Lokio/Sink;";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__out);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ISink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='sink' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("sink", "(Ljava/net/Socket;)Lokio/Sink;", "")]
		public static unsafe global::Okio.ISink Sink (global::Java.Net.Socket socket)
		{
			const string __id = "sink.(Ljava/net/Socket;)Lokio/Sink;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((socket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socket).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ISink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='sink' and count(parameter)=2 and parameter[1][@type='java.nio.file.Path'] and parameter[2][@type='java.nio.file.OpenOption...']]"
		[Register ("sink", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Lokio/Sink;", "")]
		public static unsafe global::Okio.ISink Sink (global::Java.Nio.FileNio.IPath path, params global::Java.Nio.FileNio.IOpenOption[] options)
		{
			const string __id = "sink.(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Lokio/Sink;";
			IntPtr native_options = JNIEnv.NewArray (options);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				__args [1] = new JniArgumentValue (native_options);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ISink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (options != null) {
					JNIEnv.CopyArray (native_options, options);
					JNIEnv.DeleteLocalRef (native_options);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='source' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("source", "(Ljava/io/File;)Lokio/Source;", "")]
		public static unsafe global::Okio.ISource Source (global::Java.IO.File file)
		{
			const string __id = "source.(Ljava/io/File;)Lokio/Source;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ISource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='source' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("source", "(Ljava/io/InputStream;)Lokio/Source;", "")]
		public static unsafe global::Okio.ISource Source (global::System.IO.Stream @in)
		{
			const string __id = "source.(Ljava/io/InputStream;)Lokio/Source;";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ISource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='source' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("source", "(Ljava/net/Socket;)Lokio/Source;", "")]
		public static unsafe global::Okio.ISource Source (global::Java.Net.Socket socket)
		{
			const string __id = "source.(Ljava/net/Socket;)Lokio/Source;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((socket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socket).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ISource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='source' and count(parameter)=2 and parameter[1][@type='java.nio.file.Path'] and parameter[2][@type='java.nio.file.OpenOption...']]"
		[Register ("source", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Lokio/Source;", "")]
		public static unsafe global::Okio.ISource Source (global::Java.Nio.FileNio.IPath path, params global::Java.Nio.FileNio.IOpenOption[] options)
		{
			const string __id = "source.(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Lokio/Source;";
			IntPtr native_options = JNIEnv.NewArray (options);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				__args [1] = new JniArgumentValue (native_options);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ISource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (options != null) {
					JNIEnv.CopyArray (native_options, options);
					JNIEnv.DeleteLocalRef (native_options);
				}
			}
		}

	}
}
