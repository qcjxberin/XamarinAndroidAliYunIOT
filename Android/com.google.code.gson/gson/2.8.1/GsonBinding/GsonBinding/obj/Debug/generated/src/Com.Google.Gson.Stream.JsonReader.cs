using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']"
	[global::Android.Runtime.Register ("com/google/gson/stream/JsonReader", DoNotGenerateAcw=true)]
	public partial class JsonReader : global::Java.Lang.Object, global::Java.IO.ICloseable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/stream/JsonReader", typeof (JsonReader));
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

		protected JsonReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/constructor[@name='JsonReader' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register (".ctor", "(Ljava/io/Reader;)V", "")]
		public unsafe JsonReader (global::Java.IO.Reader @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool Lenient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='isLenient' and count(parameter)=0]"
			[Register ("isLenient", "()Z", "")]
			get {
				const string __id = "isLenient.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='setLenient' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		public virtual unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				const string __id = "getPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_beginArray;
#pragma warning disable 0169
		static Delegate GetBeginArrayHandler ()
		{
			if (cb_beginArray == null)
				cb_beginArray = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BeginArray);
			return cb_beginArray;
		}

		static void n_BeginArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeginArray ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='beginArray' and count(parameter)=0]"
		[Register ("beginArray", "()V", "GetBeginArrayHandler")]
		public virtual unsafe void BeginArray ()
		{
			const string __id = "beginArray.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_beginObject;
#pragma warning disable 0169
		static Delegate GetBeginObjectHandler ()
		{
			if (cb_beginObject == null)
				cb_beginObject = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BeginObject);
			return cb_beginObject;
		}

		static void n_BeginObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeginObject ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='beginObject' and count(parameter)=0]"
		[Register ("beginObject", "()V", "GetBeginObjectHandler")]
		public virtual unsafe void BeginObject ()
		{
			const string __id = "beginObject.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='close' and count(parameter)=0]"
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
				cb_endArray = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndArray);
			return cb_endArray;
		}

		static void n_EndArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndArray ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='endArray' and count(parameter)=0]"
		[Register ("endArray", "()V", "GetEndArrayHandler")]
		public virtual unsafe void EndArray ()
		{
			const string __id = "endArray.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_endObject;
#pragma warning disable 0169
		static Delegate GetEndObjectHandler ()
		{
			if (cb_endObject == null)
				cb_endObject = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndObject);
			return cb_endObject;
		}

		static void n_EndObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndObject ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='endObject' and count(parameter)=0]"
		[Register ("endObject", "()V", "GetEndObjectHandler")]
		public virtual unsafe void EndObject ()
		{
			const string __id = "endObject.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_nextBoolean;
#pragma warning disable 0169
		static Delegate GetNextBooleanHandler ()
		{
			if (cb_nextBoolean == null)
				cb_nextBoolean = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NextBoolean);
			return cb_nextBoolean;
		}

		static bool n_NextBoolean (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextBoolean ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextBoolean' and count(parameter)=0]"
		[Register ("nextBoolean", "()Z", "GetNextBooleanHandler")]
		public virtual unsafe bool NextBoolean ()
		{
			const string __id = "nextBoolean.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_nextDouble;
#pragma warning disable 0169
		static Delegate GetNextDoubleHandler ()
		{
			if (cb_nextDouble == null)
				cb_nextDouble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_NextDouble);
			return cb_nextDouble;
		}

		static double n_NextDouble (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextDouble ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextDouble' and count(parameter)=0]"
		[Register ("nextDouble", "()D", "GetNextDoubleHandler")]
		public virtual unsafe double NextDouble ()
		{
			const string __id = "nextDouble.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_nextInt;
#pragma warning disable 0169
		static Delegate GetNextIntHandler ()
		{
			if (cb_nextInt == null)
				cb_nextInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_NextInt);
			return cb_nextInt;
		}

		static int n_NextInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextInt ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextInt' and count(parameter)=0]"
		[Register ("nextInt", "()I", "GetNextIntHandler")]
		public virtual unsafe int NextInt ()
		{
			const string __id = "nextInt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_nextLong;
#pragma warning disable 0169
		static Delegate GetNextLongHandler ()
		{
			if (cb_nextLong == null)
				cb_nextLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_NextLong);
			return cb_nextLong;
		}

		static long n_NextLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextLong ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextLong' and count(parameter)=0]"
		[Register ("nextLong", "()J", "GetNextLongHandler")]
		public virtual unsafe long NextLong ()
		{
			const string __id = "nextLong.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_nextName;
#pragma warning disable 0169
		static Delegate GetNextNameHandler ()
		{
			if (cb_nextName == null)
				cb_nextName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NextName);
			return cb_nextName;
		}

		static IntPtr n_NextName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextName' and count(parameter)=0]"
		[Register ("nextName", "()Ljava/lang/String;", "GetNextNameHandler")]
		public virtual unsafe string NextName ()
		{
			const string __id = "nextName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nextNull;
#pragma warning disable 0169
		static Delegate GetNextNullHandler ()
		{
			if (cb_nextNull == null)
				cb_nextNull = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NextNull);
			return cb_nextNull;
		}

		static void n_NextNull (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NextNull ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextNull' and count(parameter)=0]"
		[Register ("nextNull", "()V", "GetNextNullHandler")]
		public virtual unsafe void NextNull ()
		{
			const string __id = "nextNull.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_nextString;
#pragma warning disable 0169
		static Delegate GetNextStringHandler ()
		{
			if (cb_nextString == null)
				cb_nextString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NextString);
			return cb_nextString;
		}

		static IntPtr n_NextString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextString' and count(parameter)=0]"
		[Register ("nextString", "()Ljava/lang/String;", "GetNextStringHandler")]
		public virtual unsafe string NextString ()
		{
			const string __id = "nextString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peek;
#pragma warning disable 0169
		static Delegate GetPeekHandler ()
		{
			if (cb_peek == null)
				cb_peek = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Peek);
			return cb_peek;
		}

		static IntPtr n_Peek (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Peek ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='peek' and count(parameter)=0]"
		[Register ("peek", "()Lcom/google/gson/stream/JsonToken;", "GetPeekHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonToken Peek ()
		{
			const string __id = "peek.()Lcom/google/gson/stream/JsonToken;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skipValue;
#pragma warning disable 0169
		static Delegate GetSkipValueHandler ()
		{
			if (cb_skipValue == null)
				cb_skipValue = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SkipValue);
			return cb_skipValue;
		}

		static void n_SkipValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SkipValue ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='skipValue' and count(parameter)=0]"
		[Register ("skipValue", "()V", "GetSkipValueHandler")]
		public virtual unsafe void SkipValue ()
		{
			const string __id = "skipValue.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
