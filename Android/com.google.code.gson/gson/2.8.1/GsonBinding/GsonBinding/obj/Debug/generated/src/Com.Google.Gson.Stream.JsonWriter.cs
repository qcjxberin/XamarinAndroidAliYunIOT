using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']"
	[global::Android.Runtime.Register ("com/google/gson/stream/JsonWriter", DoNotGenerateAcw=true)]
	public partial class JsonWriter : global::Java.Lang.Object, global::Java.IO.ICloseable, global::Java.IO.IFlushable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/stream/JsonWriter", typeof (JsonWriter));
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

		protected JsonWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/constructor[@name='JsonWriter' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register (".ctor", "(Ljava/io/Writer;)V", "")]
		public unsafe JsonWriter (global::Java.IO.Writer @out)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Writer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool HtmlSafe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='isHtmlSafe' and count(parameter)=0]"
			[Register ("isHtmlSafe", "()Z", "")]
			get {
				const string __id = "isHtmlSafe.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='setHtmlSafe' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHtmlSafe", "(Z)V", "")]
			set {
				const string __id = "setHtmlSafe.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool Lenient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='isLenient' and count(parameter)=0]"
			[Register ("isLenient", "()Z", "GetIsLenientHandler")]
			get {
				const string __id = "isLenient.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='setLenient' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLenient", "(Z)V", "")]
			set {
				const string __id = "setLenient.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool SerializeNulls {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='getSerializeNulls' and count(parameter)=0]"
			[Register ("getSerializeNulls", "()Z", "")]
			get {
				const string __id = "getSerializeNulls.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='setSerializeNulls' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSerializeNulls", "(Z)V", "")]
			set {
				const string __id = "setSerializeNulls.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_beginArray;
#pragma warning disable 0169
		static Delegate GetBeginArrayHandler ()
		{
			if (cb_beginArray == null)
				cb_beginArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BeginArray);
			return cb_beginArray;
		}

		static IntPtr n_BeginArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeginArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='beginArray' and count(parameter)=0]"
		[Register ("beginArray", "()Lcom/google/gson/stream/JsonWriter;", "GetBeginArrayHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter BeginArray ()
		{
			const string __id = "beginArray.()Lcom/google/gson/stream/JsonWriter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_beginObject;
#pragma warning disable 0169
		static Delegate GetBeginObjectHandler ()
		{
			if (cb_beginObject == null)
				cb_beginObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BeginObject);
			return cb_beginObject;
		}

		static IntPtr n_BeginObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeginObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='beginObject' and count(parameter)=0]"
		[Register ("beginObject", "()Lcom/google/gson/stream/JsonWriter;", "GetBeginObjectHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter BeginObject ()
		{
			const string __id = "beginObject.()Lcom/google/gson/stream/JsonWriter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_endArray;
#pragma warning disable 0169
		static Delegate GetEndArrayHandler ()
		{
			if (cb_endArray == null)
				cb_endArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EndArray);
			return cb_endArray;
		}

		static IntPtr n_EndArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='endArray' and count(parameter)=0]"
		[Register ("endArray", "()Lcom/google/gson/stream/JsonWriter;", "GetEndArrayHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter EndArray ()
		{
			const string __id = "endArray.()Lcom/google/gson/stream/JsonWriter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_endObject;
#pragma warning disable 0169
		static Delegate GetEndObjectHandler ()
		{
			if (cb_endObject == null)
				cb_endObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EndObject);
			return cb_endObject;
		}

		static IntPtr n_EndObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='endObject' and count(parameter)=0]"
		[Register ("endObject", "()Lcom/google/gson/stream/JsonWriter;", "GetEndObjectHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter EndObject ()
		{
			const string __id = "endObject.()Lcom/google/gson/stream/JsonWriter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_jsonValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetJsonValue_Ljava_lang_String_Handler ()
		{
			if (cb_jsonValue_Ljava_lang_String_ == null)
				cb_jsonValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_JsonValue_Ljava_lang_String_);
			return cb_jsonValue_Ljava_lang_String_;
		}

		static IntPtr n_JsonValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.JsonValue (value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='jsonValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("jsonValue", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;", "GetJsonValue_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter JsonValue (string value)
		{
			const string __id = "jsonValue.(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_name_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetName_Ljava_lang_String_Handler ()
		{
			if (cb_name_Ljava_lang_String_ == null)
				cb_name_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Name_Ljava_lang_String_);
			return cb_name_Ljava_lang_String_;
		}

		static IntPtr n_Name_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Name (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='name' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("name", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;", "GetName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Name (string name)
		{
			const string __id = "name.(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_nullValue;
#pragma warning disable 0169
		static Delegate GetNullValueHandler ()
		{
			if (cb_nullValue == null)
				cb_nullValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NullValue);
			return cb_nullValue;
		}

		static IntPtr n_NullValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NullValue ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='nullValue' and count(parameter)=0]"
		[Register ("nullValue", "()Lcom/google/gson/stream/JsonWriter;", "GetNullValueHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter NullValue ()
		{
			const string __id = "nullValue.()Lcom/google/gson/stream/JsonWriter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='setIndent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setIndent", "(Ljava/lang/String;)V", "")]
		public unsafe void SetIndent (string indent)
		{
			const string __id = "setIndent.(Ljava/lang/String;)V";
			IntPtr native_indent = JNIEnv.NewString (indent);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_indent);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_indent);
			}
		}

		static Delegate cb_value_Z;
#pragma warning disable 0169
		static Delegate GetValue_ZHandler ()
		{
			if (cb_value_Z == null)
				cb_value_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_Value_Z);
			return cb_value_Z;
		}

		static IntPtr n_Value_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value (value));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='value' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("value", "(Z)Lcom/google/gson/stream/JsonWriter;", "GetValue_ZHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Value (bool value)
		{
			const string __id = "value.(Z)Lcom/google/gson/stream/JsonWriter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_value_D;
#pragma warning disable 0169
		static Delegate GetValue_DHandler ()
		{
			if (cb_value_D == null)
				cb_value_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_Value_D);
			return cb_value_D;
		}

		static IntPtr n_Value_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value (value));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='value' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("value", "(D)Lcom/google/gson/stream/JsonWriter;", "GetValue_DHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Value (double value)
		{
			const string __id = "value.(D)Lcom/google/gson/stream/JsonWriter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_value_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetValue_Ljava_lang_Boolean_Handler ()
		{
			if (cb_value_Ljava_lang_Boolean_ == null)
				cb_value_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Value_Ljava_lang_Boolean_);
			return cb_value_Ljava_lang_Boolean_;
		}

		static IntPtr n_Value_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean value = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Value (value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='value' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("value", "(Ljava/lang/Boolean;)Lcom/google/gson/stream/JsonWriter;", "GetValue_Ljava_lang_Boolean_Handler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Value (global::Java.Lang.Boolean value)
		{
			const string __id = "value.(Ljava/lang/Boolean;)Lcom/google/gson/stream/JsonWriter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_value_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetValue_Ljava_lang_Number_Handler ()
		{
			if (cb_value_Ljava_lang_Number_ == null)
				cb_value_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Value_Ljava_lang_Number_);
			return cb_value_Ljava_lang_Number_;
		}

		static IntPtr n_Value_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number value = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Value (value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='value' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("value", "(Ljava/lang/Number;)Lcom/google/gson/stream/JsonWriter;", "GetValue_Ljava_lang_Number_Handler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Value (global::Java.Lang.Number value)
		{
			const string __id = "value.(Ljava/lang/Number;)Lcom/google/gson/stream/JsonWriter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_value_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetValue_Ljava_lang_String_Handler ()
		{
			if (cb_value_Ljava_lang_String_ == null)
				cb_value_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Value_Ljava_lang_String_);
			return cb_value_Ljava_lang_String_;
		}

		static IntPtr n_Value_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Value (value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='value' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("value", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;", "GetValue_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Value (string value)
		{
			const string __id = "value.(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_value_J;
#pragma warning disable 0169
		static Delegate GetValue_JHandler ()
		{
			if (cb_value_J == null)
				cb_value_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Value_J);
			return cb_value_J;
		}

		static IntPtr n_Value_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value (value));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='value' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("value", "(J)Lcom/google/gson/stream/JsonWriter;", "GetValue_JHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Value (long value)
		{
			const string __id = "value.(J)Lcom/google/gson/stream/JsonWriter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
