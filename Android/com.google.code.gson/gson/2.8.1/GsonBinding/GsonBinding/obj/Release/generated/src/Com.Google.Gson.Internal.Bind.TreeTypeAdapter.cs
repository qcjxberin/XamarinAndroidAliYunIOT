using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/TreeTypeAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class TreeTypeAdapter : global::Com.Google.Gson.TypeAdapter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/bind/TreeTypeAdapter", typeof (TreeTypeAdapter));
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

		internal TreeTypeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']/constructor[@name='TreeTypeAdapter' and count(parameter)=5 and parameter[1][@type='com.google.gson.JsonSerializer&lt;T&gt;'] and parameter[2][@type='com.google.gson.JsonDeserializer&lt;T&gt;'] and parameter[3][@type='com.google.gson.Gson'] and parameter[4][@type='com.google.gson.reflect.TypeToken&lt;T&gt;'] and parameter[5][@type='com.google.gson.TypeAdapterFactory']]"
		[Register (".ctor", "(Lcom/google/gson/JsonSerializer;Lcom/google/gson/JsonDeserializer;Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;Lcom/google/gson/TypeAdapterFactory;)V", "")]
		public unsafe TreeTypeAdapter (global::Com.Google.Gson.IJsonSerializer serializer, global::Com.Google.Gson.IJsonDeserializer deserializer, global::Com.Google.Gson.Gson gson, global::Com.Google.Gson.Reflect.TypeToken typeToken, global::Com.Google.Gson.ITypeAdapterFactory skipPast)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/gson/JsonSerializer;Lcom/google/gson/JsonDeserializer;Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;Lcom/google/gson/TypeAdapterFactory;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((serializer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serializer).Handle);
				__args [1] = new JniArgumentValue ((deserializer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deserializer).Handle);
				__args [2] = new JniArgumentValue ((gson == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gson).Handle);
				__args [3] = new JniArgumentValue ((typeToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeToken).Handle);
				__args [4] = new JniArgumentValue ((skipPast == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skipPast).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']/method[@name='newFactory' and count(parameter)=2 and parameter[1][@type='com.google.gson.reflect.TypeToken&lt;?&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("newFactory", "(Lcom/google/gson/reflect/TypeToken;Ljava/lang/Object;)Lcom/google/gson/TypeAdapterFactory;", "")]
		public static unsafe global::Com.Google.Gson.ITypeAdapterFactory NewFactory (global::Com.Google.Gson.Reflect.TypeToken exactType, global::Java.Lang.Object typeAdapter)
		{
			const string __id = "newFactory.(Lcom/google/gson/reflect/TypeToken;Ljava/lang/Object;)Lcom/google/gson/TypeAdapterFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((exactType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exactType).Handle);
				__args [1] = new JniArgumentValue ((typeAdapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeAdapter).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']/method[@name='newFactoryWithMatchRawType' and count(parameter)=2 and parameter[1][@type='com.google.gson.reflect.TypeToken&lt;?&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("newFactoryWithMatchRawType", "(Lcom/google/gson/reflect/TypeToken;Ljava/lang/Object;)Lcom/google/gson/TypeAdapterFactory;", "")]
		public static unsafe global::Com.Google.Gson.ITypeAdapterFactory NewFactoryWithMatchRawType (global::Com.Google.Gson.Reflect.TypeToken exactType, global::Java.Lang.Object typeAdapter)
		{
			const string __id = "newFactoryWithMatchRawType.(Lcom/google/gson/reflect/TypeToken;Ljava/lang/Object;)Lcom/google/gson/TypeAdapterFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((exactType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exactType).Handle);
				__args [1] = new JniArgumentValue ((typeAdapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeAdapter).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']/method[@name='newTypeHierarchyFactory' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("newTypeHierarchyFactory", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/google/gson/TypeAdapterFactory;", "")]
		public static unsafe global::Com.Google.Gson.ITypeAdapterFactory NewTypeHierarchyFactory (global::Java.Lang.Class hierarchyType, global::Java.Lang.Object typeAdapter)
		{
			const string __id = "newTypeHierarchyFactory.(Ljava/lang/Class;Ljava/lang/Object;)Lcom/google/gson/TypeAdapterFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((hierarchyType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hierarchyType).Handle);
				__args [1] = new JniArgumentValue ((typeAdapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeAdapter).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object Read (global::Com.Google.Gson.Stream.JsonReader @in)
		{
			const string __id = "read.(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='T']]"
		[Register ("write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V", "")]
		public override unsafe void Write (global::Com.Google.Gson.Stream.JsonWriter @out, global::Java.Lang.Object value)
		{
			const string __id = "write.(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V";
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
