using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ArrayTypeAdapter']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/ArrayTypeAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
	public sealed partial class ArrayTypeAdapter : global::Com.Google.Gson.TypeAdapter {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ArrayTypeAdapter']/field[@name='FACTORY']"
		[Register ("FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory Factory {
			get {
				const string __id = "FACTORY.Lcom/google/gson/TypeAdapterFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/bind/ArrayTypeAdapter", typeof (ArrayTypeAdapter));
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

		internal ArrayTypeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ArrayTypeAdapter']/constructor[@name='ArrayTypeAdapter' and count(parameter)=3 and parameter[1][@type='com.google.gson.Gson'] and parameter[2][@type='com.google.gson.TypeAdapter&lt;E&gt;'] and parameter[3][@type='java.lang.Class&lt;E&gt;']]"
		[Register (".ctor", "(Lcom/google/gson/Gson;Lcom/google/gson/TypeAdapter;Ljava/lang/Class;)V", "")]
		public unsafe ArrayTypeAdapter (global::Com.Google.Gson.Gson context, global::Com.Google.Gson.TypeAdapter componentTypeAdapter, global::Java.Lang.Class componentType)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/gson/Gson;Lcom/google/gson/TypeAdapter;Ljava/lang/Class;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((componentTypeAdapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) componentTypeAdapter).Handle);
				__args [2] = new JniArgumentValue ((componentType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) componentType).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ArrayTypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object Read (global::Com.Google.Gson.Stream.JsonReader @in)
		{
			const string __id = "read.(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ArrayTypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='java.lang.Object']]"
		[Register ("write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V", "")]
		public override unsafe void Write (global::Com.Google.Gson.Stream.JsonWriter @out, global::Java.Lang.Object array)
		{
			const string __id = "write.(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue ((array == null) ? IntPtr.Zero : ((global::Java.Lang.Object) array).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
