using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams']"
	[global::Android.Runtime.Register ("com/google/gson/internal/Streams", DoNotGenerateAcw=true)]
	public sealed partial class Streams : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/Streams", typeof (Streams));
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

		internal Streams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("parse", "(Lcom/google/gson/stream/JsonReader;)Lcom/google/gson/JsonElement;", "")]
		public static unsafe global::Com.Google.Gson.JsonElement Parse (global::Com.Google.Gson.Stream.JsonReader reader)
		{
			const string __id = "parse.(Lcom/google/gson/stream/JsonReader;)Lcom/google/gson/JsonElement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='com.google.gson.stream.JsonWriter']]"
		[Register ("write", "(Lcom/google/gson/JsonElement;Lcom/google/gson/stream/JsonWriter;)V", "")]
		public static unsafe void Write (global::Com.Google.Gson.JsonElement element, global::Com.Google.Gson.Stream.JsonWriter writer)
		{
			const string __id = "write.(Lcom/google/gson/JsonElement;Lcom/google/gson/stream/JsonWriter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((element == null) ? IntPtr.Zero : ((global::Java.Lang.Object) element).Handle);
				__args [1] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams']/method[@name='writerForAppendable' and count(parameter)=1 and parameter[1][@type='java.lang.Appendable']]"
		[Register ("writerForAppendable", "(Ljava/lang/Appendable;)Ljava/io/Writer;", "")]
		public static unsafe global::Java.IO.Writer WriterForAppendable (global::Java.Lang.IAppendable appendable)
		{
			const string __id = "writerForAppendable.(Ljava/lang/Appendable;)Ljava/io/Writer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((appendable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) appendable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
