using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']"
	[global::Android.Runtime.Register ("com/google/gson/TypeAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class TypeAdapter : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/TypeAdapter", typeof (TypeAdapter));
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

		protected TypeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/constructor[@name='TypeAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TypeAdapter ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("fromJson", "(Ljava/io/Reader;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object FromJson (global::Java.IO.Reader @in)
		{
			const string __id = "fromJson.(Ljava/io/Reader;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object FromJson (string json)
		{
			const string __id = "fromJson.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_json);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='fromJsonTree' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register ("fromJsonTree", "(Lcom/google/gson/JsonElement;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object FromJsonTree (global::Com.Google.Gson.JsonElement jsonTree)
		{
			const string __id = "fromJsonTree.(Lcom/google/gson/JsonElement;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonTree).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='nullSafe' and count(parameter)=0]"
		[Register ("nullSafe", "()Lcom/google/gson/TypeAdapter;", "")]
		public unsafe global::Com.Google.Gson.TypeAdapter NullSafe ()
		{
			const string __id = "nullSafe.()Lcom/google/gson/TypeAdapter;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_read_Lcom_google_gson_stream_JsonReader_;
#pragma warning disable 0169
		static Delegate GetRead_Lcom_google_gson_stream_JsonReader_Handler ()
		{
			if (cb_read_Lcom_google_gson_stream_JsonReader_ == null)
				cb_read_Lcom_google_gson_stream_JsonReader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Read_Lcom_google_gson_stream_JsonReader_);
			return cb_read_Lcom_google_gson_stream_JsonReader_;
		}

		static IntPtr n_Read_Lcom_google_gson_stream_JsonReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.TypeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.Stream.JsonReader p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Read (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;", "GetRead_Lcom_google_gson_stream_JsonReader_Handler")]
		public abstract global::Java.Lang.Object Read (global::Com.Google.Gson.Stream.JsonReader p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='java.io.Writer'] and parameter[2][@type='T']]"
		[Register ("toJson", "(Ljava/io/Writer;Ljava/lang/Object;)V", "")]
		public unsafe void ToJson (global::Java.IO.Writer @out, global::Java.Lang.Object value)
		{
			const string __id = "toJson.(Ljava/io/Writer;Ljava/lang/Object;)V";
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("toJson", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe string ToJson (global::Java.Lang.Object value)
		{
			const string __id = "toJson.(Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='toJsonTree' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("toJsonTree", "(Ljava/lang/Object;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement ToJsonTree (global::Java.Lang.Object value)
		{
			const string __id = "toJsonTree.(Ljava/lang/Object;)Lcom/google/gson/JsonElement;";
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
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

		static void n_Write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Gson.TypeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.Stream.JsonWriter p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='T']]"
		[Register ("write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V", "GetWrite_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_Handler")]
		public abstract void Write (global::Com.Google.Gson.Stream.JsonWriter p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/google/gson/TypeAdapter", DoNotGenerateAcw=true)]
	internal partial class TypeAdapterInvoker : TypeAdapter {

		public TypeAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/TypeAdapter", typeof (TypeAdapterInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;", "GetRead_Lcom_google_gson_stream_JsonReader_Handler")]
		public override unsafe global::Java.Lang.Object Read (global::Com.Google.Gson.Stream.JsonReader p0)
		{
			const string __id = "read.(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='T']]"
		[Register ("write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V", "GetWrite_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_Handler")]
		public override unsafe void Write (global::Com.Google.Gson.Stream.JsonWriter p0, global::Java.Lang.Object p1)
		{
			const string __id = "write.(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V";
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}
