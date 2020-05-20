using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/ReflectiveTypeAdapterFactory", DoNotGenerateAcw=true)]
	public sealed partial class ReflectiveTypeAdapterFactory : global::Java.Lang.Object, global::Com.Google.Gson.ITypeAdapterFactory {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory.Adapter']"
		[global::Android.Runtime.Register ("com/google/gson/internal/bind/ReflectiveTypeAdapterFactory$Adapter", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public sealed partial class Adapter : global::Com.Google.Gson.TypeAdapter {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/bind/ReflectiveTypeAdapterFactory$Adapter", typeof (Adapter));
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

			internal Adapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory.Adapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory.Adapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='T']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory.BoundField']"
		[global::Android.Runtime.Register ("com/google/gson/internal/bind/ReflectiveTypeAdapterFactory$BoundField", DoNotGenerateAcw=true)]
		public abstract partial class BoundField : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/bind/ReflectiveTypeAdapterFactory$BoundField", typeof (BoundField));
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

			protected BoundField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory.BoundField']/constructor[@name='ReflectiveTypeAdapterFactory.BoundField' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
			[Register (".ctor", "(Ljava/lang/String;ZZ)V", "")]
			protected unsafe BoundField (string name, bool serialized, bool deserialized)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;ZZ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (serialized);
					__args [2] = new JniArgumentValue (deserialized);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

		}

		[global::Android.Runtime.Register ("com/google/gson/internal/bind/ReflectiveTypeAdapterFactory$BoundField", DoNotGenerateAcw=true)]
		internal partial class BoundFieldInvoker : BoundField {

			public BoundFieldInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/bind/ReflectiveTypeAdapterFactory$BoundField", typeof (BoundFieldInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/bind/ReflectiveTypeAdapterFactory", typeof (ReflectiveTypeAdapterFactory));
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

		internal ReflectiveTypeAdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory']/constructor[@name='ReflectiveTypeAdapterFactory' and count(parameter)=4 and parameter[1][@type='com.google.gson.internal.ConstructorConstructor'] and parameter[2][@type='com.google.gson.FieldNamingStrategy'] and parameter[3][@type='com.google.gson.internal.Excluder'] and parameter[4][@type='com.google.gson.internal.bind.JsonAdapterAnnotationTypeAdapterFactory']]"
		[Register (".ctor", "(Lcom/google/gson/internal/ConstructorConstructor;Lcom/google/gson/FieldNamingStrategy;Lcom/google/gson/internal/Excluder;Lcom/google/gson/internal/bind/JsonAdapterAnnotationTypeAdapterFactory;)V", "")]
		public unsafe ReflectiveTypeAdapterFactory (global::Com.Google.Gson.Internal.ConstructorConstructor constructorConstructor, global::Com.Google.Gson.IFieldNamingStrategy fieldNamingPolicy, global::Com.Google.Gson.Internal.Excluder excluder, global::Com.Google.Gson.Internal.Bind.JsonAdapterAnnotationTypeAdapterFactory jsonAdapterFactory)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/gson/internal/ConstructorConstructor;Lcom/google/gson/FieldNamingStrategy;Lcom/google/gson/internal/Excluder;Lcom/google/gson/internal/bind/JsonAdapterAnnotationTypeAdapterFactory;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((constructorConstructor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) constructorConstructor).Handle);
				__args [1] = new JniArgumentValue ((fieldNamingPolicy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fieldNamingPolicy).Handle);
				__args [2] = new JniArgumentValue ((excluder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) excluder).Handle);
				__args [3] = new JniArgumentValue ((jsonAdapterFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonAdapterFactory).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.google.gson.Gson'] and parameter[2][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("create", "(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter Create (global::Com.Google.Gson.Gson gson, global::Com.Google.Gson.Reflect.TypeToken type)
		{
			const string __id = "create.(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((gson == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gson).Handle);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory']/method[@name='excludeField' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='boolean']]"
		[Register ("excludeField", "(Ljava/lang/reflect/Field;Z)Z", "")]
		public unsafe bool ExcludeField (global::Java.Lang.Reflect.Field f, bool serialize)
		{
			const string __id = "excludeField.(Ljava/lang/reflect/Field;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (serialize);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
