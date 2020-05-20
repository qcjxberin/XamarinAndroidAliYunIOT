using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']"
	[global::Android.Runtime.Register ("com/google/gson/Gson", DoNotGenerateAcw=true)]
	public sealed partial class Gson : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='Gson.FutureTypeAdapter']"
		[global::Android.Runtime.Register ("com/google/gson/Gson$FutureTypeAdapter", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial class FutureTypeAdapter : global::Com.Google.Gson.TypeAdapter {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/Gson$FutureTypeAdapter", typeof (FutureTypeAdapter));
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

			protected FutureTypeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_read_Lcom_google_gson_stream_JsonReader_;
#pragma warning disable 0169
			static Delegate GetRead_Lcom_google_gson_stream_JsonReader_Handler ()
			{
				if (cb_read_Lcom_google_gson_stream_JsonReader_ == null)
					cb_read_Lcom_google_gson_stream_JsonReader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Read_Lcom_google_gson_stream_JsonReader_);
				return cb_read_Lcom_google_gson_stream_JsonReader_;
			}

			static IntPtr n_Read_Lcom_google_gson_stream_JsonReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
			{
				global::Com.Google.Gson.Gson.FutureTypeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Gson.FutureTypeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Gson.Stream.JsonReader @in = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (native__in, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Read (@in));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson.FutureTypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
			[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;", "GetRead_Lcom_google_gson_stream_JsonReader_Handler")]
			public override unsafe global::Java.Lang.Object Read (global::Com.Google.Gson.Stream.JsonReader @in)
			{
				const string __id = "read.(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setDelegate_Lcom_google_gson_TypeAdapter_;
#pragma warning disable 0169
			static Delegate GetSetDelegate_Lcom_google_gson_TypeAdapter_Handler ()
			{
				if (cb_setDelegate_Lcom_google_gson_TypeAdapter_ == null)
					cb_setDelegate_Lcom_google_gson_TypeAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDelegate_Lcom_google_gson_TypeAdapter_);
				return cb_setDelegate_Lcom_google_gson_TypeAdapter_;
			}

			static void n_SetDelegate_Lcom_google_gson_TypeAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_typeAdapter)
			{
				global::Com.Google.Gson.Gson.FutureTypeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Gson.FutureTypeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Gson.TypeAdapter typeAdapter = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (native_typeAdapter, JniHandleOwnership.DoNotTransfer);
				__this.SetDelegate (typeAdapter);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson.FutureTypeAdapter']/method[@name='setDelegate' and count(parameter)=1 and parameter[1][@type='com.google.gson.TypeAdapter&lt;T&gt;']]"
			[Register ("setDelegate", "(Lcom/google/gson/TypeAdapter;)V", "GetSetDelegate_Lcom_google_gson_TypeAdapter_Handler")]
			public virtual unsafe void SetDelegate (global::Com.Google.Gson.TypeAdapter typeAdapter)
			{
				const string __id = "setDelegate.(Lcom/google/gson/TypeAdapter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((typeAdapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeAdapter).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetWrite_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_Handler ()
			{
				if (cb_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ == null)
					cb_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_);
				return cb_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_;
			}

			static void n_Write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out, IntPtr native_value)
			{
				global::Com.Google.Gson.Gson.FutureTypeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Gson.FutureTypeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Gson.Stream.JsonWriter @out = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (native__out, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
				__this.Write (@out, value);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson.FutureTypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='T']]"
			[Register ("write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V", "GetWrite_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_Handler")]
			public override unsafe void Write (global::Com.Google.Gson.Stream.JsonWriter @out, global::Java.Lang.Object value)
			{
				const string __id = "write.(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V";
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
					__args [1] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/Gson", typeof (Gson));
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

		internal Gson (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/constructor[@name='Gson' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Gson ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='excluder' and count(parameter)=0]"
		[Register ("excluder", "()Lcom/google/gson/internal/Excluder;", "")]
		public unsafe global::Com.Google.Gson.Internal.Excluder Excluder ()
		{
			const string __id = "excluder.()Lcom/google/gson/internal/Excluder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fieldNamingStrategy' and count(parameter)=0]"
		[Register ("fieldNamingStrategy", "()Lcom/google/gson/FieldNamingStrategy;", "")]
		public unsafe global::Com.Google.Gson.IFieldNamingStrategy FieldNamingStrategy ()
		{
			const string __id = "fieldNamingStrategy.()Lcom/google/gson/FieldNamingStrategy;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IFieldNamingStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("fromJson", "(Lcom/google/gson/JsonElement;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Com.Google.Gson.JsonElement json, global::Java.Lang.Class classOfT)
		{
			const string __id = "fromJson.(Lcom/google/gson/JsonElement;Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((json == null) ? IntPtr.Zero : ((global::Java.Lang.Object) json).Handle);
				__args [1] = new JniArgumentValue ((classOfT == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classOfT).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Com.Google.Gson.JsonElement json, global::Java.Lang.Reflect.IType typeOfT)
		{
			const string __id = "fromJson.(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((json == null) ? IntPtr.Zero : ((global::Java.Lang.Object) json).Handle);
				__args [1] = new JniArgumentValue ((typeOfT == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeOfT).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonReader'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Lcom/google/gson/stream/JsonReader;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Com.Google.Gson.Stream.JsonReader reader, global::Java.Lang.Reflect.IType typeOfT)
		{
			const string __id = "fromJson.(Lcom/google/gson/stream/JsonReader;Ljava/lang/reflect/Type;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue ((typeOfT == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeOfT).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("fromJson", "(Ljava/io/Reader;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Java.IO.Reader json, global::Java.Lang.Class classOfT)
		{
			const string __id = "fromJson.(Ljava/io/Reader;Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((json == null) ? IntPtr.Zero : ((global::Java.Lang.Object) json).Handle);
				__args [1] = new JniArgumentValue ((classOfT == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classOfT).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Ljava/io/Reader;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Java.IO.Reader json, global::Java.Lang.Reflect.IType typeOfT)
		{
			const string __id = "fromJson.(Ljava/io/Reader;Ljava/lang/reflect/Type;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((json == null) ? IntPtr.Zero : ((global::Java.Lang.Object) json).Handle);
				__args [1] = new JniArgumentValue ((typeOfT == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeOfT).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("fromJson", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (string json, global::Java.Lang.Class classOfT)
		{
			const string __id = "fromJson.(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;";
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_json);
				__args [1] = new JniArgumentValue ((classOfT == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classOfT).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (string json, global::Java.Lang.Reflect.IType typeOfT)
		{
			const string __id = "fromJson.(Ljava/lang/String;Ljava/lang/reflect/Type;)Ljava/lang/Object;";
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_json);
				__args [1] = new JniArgumentValue ((typeOfT == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeOfT).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='getAdapter' and count(parameter)=1 and parameter[1][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("getAdapter", "(Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter GetAdapter (global::Com.Google.Gson.Reflect.TypeToken type)
		{
			const string __id = "getAdapter.(Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='getAdapter' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getAdapter", "(Ljava/lang/Class;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter GetAdapter (global::Java.Lang.Class type)
		{
			const string __id = "getAdapter.(Ljava/lang/Class;)Lcom/google/gson/TypeAdapter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='getDelegateAdapter' and count(parameter)=2 and parameter[1][@type='com.google.gson.TypeAdapterFactory'] and parameter[2][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("getDelegateAdapter", "(Lcom/google/gson/TypeAdapterFactory;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter GetDelegateAdapter (global::Com.Google.Gson.ITypeAdapterFactory skipPast, global::Com.Google.Gson.Reflect.TypeToken type)
		{
			const string __id = "getDelegateAdapter.(Lcom/google/gson/TypeAdapterFactory;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((skipPast == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skipPast).Handle);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='htmlSafe' and count(parameter)=0]"
		[Register ("htmlSafe", "()Z", "")]
		public unsafe bool HtmlSafe ()
		{
			const string __id = "htmlSafe.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='newJsonReader' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("newJsonReader", "(Ljava/io/Reader;)Lcom/google/gson/stream/JsonReader;", "")]
		public unsafe global::Com.Google.Gson.Stream.JsonReader NewJsonReader (global::Java.IO.Reader reader)
		{
			const string __id = "newJsonReader.(Ljava/io/Reader;)Lcom/google/gson/stream/JsonReader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='newJsonWriter' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register ("newJsonWriter", "(Ljava/io/Writer;)Lcom/google/gson/stream/JsonWriter;", "")]
		public unsafe global::Com.Google.Gson.Stream.JsonWriter NewJsonWriter (global::Java.IO.Writer writer)
		{
			const string __id = "newJsonWriter.(Ljava/io/Writer;)Lcom/google/gson/stream/JsonWriter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='serializeNulls' and count(parameter)=0]"
		[Register ("serializeNulls", "()Z", "")]
		public unsafe bool SerializeNulls ()
		{
			const string __id = "serializeNulls.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register ("toJson", "(Lcom/google/gson/JsonElement;)Ljava/lang/String;", "")]
		public unsafe string ToJson (global::Com.Google.Gson.JsonElement jsonElement)
		{
			const string __id = "toJson.(Lcom/google/gson/JsonElement;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonElement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonElement).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='com.google.gson.stream.JsonWriter']]"
		[Register ("toJson", "(Lcom/google/gson/JsonElement;Lcom/google/gson/stream/JsonWriter;)V", "")]
		public unsafe void ToJson (global::Com.Google.Gson.JsonElement jsonElement, global::Com.Google.Gson.Stream.JsonWriter writer)
		{
			const string __id = "toJson.(Lcom/google/gson/JsonElement;Lcom/google/gson/stream/JsonWriter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((jsonElement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonElement).Handle);
				__args [1] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.Appendable']]"
		[Register ("toJson", "(Lcom/google/gson/JsonElement;Ljava/lang/Appendable;)V", "")]
		public unsafe void ToJson (global::Com.Google.Gson.JsonElement jsonElement, global::Java.Lang.IAppendable writer)
		{
			const string __id = "toJson.(Lcom/google/gson/JsonElement;Ljava/lang/Appendable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((jsonElement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonElement).Handle);
				__args [1] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toJson", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe string ToJson (global::Java.Lang.Object src)
		{
			const string __id = "toJson.(Ljava/lang/Object;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Appendable']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/Appendable;)V", "")]
		public unsafe void ToJson (global::Java.Lang.Object src, global::Java.Lang.IAppendable writer)
		{
			const string __id = "toJson.(Ljava/lang/Object;Ljava/lang/Appendable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Ljava/lang/String;", "")]
		public unsafe string ToJson (global::Java.Lang.Object src, global::Java.Lang.Reflect.IType typeOfSrc)
		{
			const string __id = "toJson.(Ljava/lang/Object;Ljava/lang/reflect/Type;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue ((typeOfSrc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeOfSrc).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='com.google.gson.stream.JsonWriter']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Lcom/google/gson/stream/JsonWriter;)V", "")]
		public unsafe void ToJson (global::Java.Lang.Object src, global::Java.Lang.Reflect.IType typeOfSrc, global::Com.Google.Gson.Stream.JsonWriter writer)
		{
			const string __id = "toJson.(Ljava/lang/Object;Ljava/lang/reflect/Type;Lcom/google/gson/stream/JsonWriter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue ((typeOfSrc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeOfSrc).Handle);
				__args [2] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='java.lang.Appendable']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/Appendable;)V", "")]
		public unsafe void ToJson (global::Java.Lang.Object src, global::Java.Lang.Reflect.IType typeOfSrc, global::Java.Lang.IAppendable writer)
		{
			const string __id = "toJson.(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/Appendable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue ((typeOfSrc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeOfSrc).Handle);
				__args [2] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJsonTree' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toJsonTree", "(Ljava/lang/Object;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement ToJsonTree (global::Java.Lang.Object src)
		{
			const string __id = "toJsonTree.(Ljava/lang/Object;)Lcom/google/gson/JsonElement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJsonTree' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("toJsonTree", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement ToJsonTree (global::Java.Lang.Object src, global::Java.Lang.Reflect.IType typeOfSrc)
		{
			const string __id = "toJsonTree.(Ljava/lang/Object;Ljava/lang/reflect/Type;)Lcom/google/gson/JsonElement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue ((typeOfSrc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeOfSrc).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
