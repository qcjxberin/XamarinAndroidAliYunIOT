using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']"
	[global::Android.Runtime.Register ("com/google/gson/JsonObject", DoNotGenerateAcw=true)]
	public sealed partial class JsonObject : global::Com.Google.Gson.JsonElement {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/JsonObject", typeof (JsonObject));
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

		internal JsonObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/constructor[@name='JsonObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonObject ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.gson.JsonElement']]"
		[Register ("add", "(Ljava/lang/String;Lcom/google/gson/JsonElement;)V", "")]
		public unsafe void Add (string property, global::Com.Google.Gson.JsonElement value)
		{
			const string __id = "add.(Ljava/lang/String;Lcom/google/gson/JsonElement;)V";
			IntPtr native_property = JNIEnv.NewString (property);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_property);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_property);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='addProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("addProperty", "(Ljava/lang/String;Ljava/lang/Boolean;)V", "")]
		public unsafe void AddProperty (string property, global::Java.Lang.Boolean value)
		{
			const string __id = "addProperty.(Ljava/lang/String;Ljava/lang/Boolean;)V";
			IntPtr native_property = JNIEnv.NewString (property);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_property);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_property);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='addProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Character']]"
		[Register ("addProperty", "(Ljava/lang/String;Ljava/lang/Character;)V", "")]
		public unsafe void AddProperty (string property, global::Java.Lang.Character value)
		{
			const string __id = "addProperty.(Ljava/lang/String;Ljava/lang/Character;)V";
			IntPtr native_property = JNIEnv.NewString (property);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_property);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_property);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='addProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number']]"
		[Register ("addProperty", "(Ljava/lang/String;Ljava/lang/Number;)V", "")]
		public unsafe void AddProperty (string property, global::Java.Lang.Number value)
		{
			const string __id = "addProperty.(Ljava/lang/String;Ljava/lang/Number;)V";
			IntPtr native_property = JNIEnv.NewString (property);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_property);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_property);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='addProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void AddProperty (string property, string value)
		{
			const string __id = "addProperty.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_property = JNIEnv.NewString (property);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_property);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_property);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='entrySet' and count(parameter)=0]"
		[Register ("entrySet", "()Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<global::Java.Util.IMapEntry> EntrySet ()
		{
			const string __id = "entrySet.()Ljava/util/Set;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Get (string memberName)
		{
			const string __id = "get.(Ljava/lang/String;)Lcom/google/gson/JsonElement;";
			IntPtr native_memberName = JNIEnv.NewString (memberName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_memberName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_memberName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='getAsJsonArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsJsonArray", "(Ljava/lang/String;)Lcom/google/gson/JsonArray;", "")]
		public unsafe global::Com.Google.Gson.JsonArray GetAsJsonArray (string memberName)
		{
			const string __id = "getAsJsonArray.(Ljava/lang/String;)Lcom/google/gson/JsonArray;";
			IntPtr native_memberName = JNIEnv.NewString (memberName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_memberName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_memberName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='getAsJsonObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsJsonObject", "(Ljava/lang/String;)Lcom/google/gson/JsonObject;", "")]
		public unsafe global::Com.Google.Gson.JsonObject GetAsJsonObject (string memberName)
		{
			const string __id = "getAsJsonObject.(Ljava/lang/String;)Lcom/google/gson/JsonObject;";
			IntPtr native_memberName = JNIEnv.NewString (memberName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_memberName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_memberName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='getAsJsonPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsJsonPrimitive", "(Ljava/lang/String;)Lcom/google/gson/JsonPrimitive;", "")]
		public unsafe global::Com.Google.Gson.JsonPrimitive GetAsJsonPrimitive (string memberName)
		{
			const string __id = "getAsJsonPrimitive.(Ljava/lang/String;)Lcom/google/gson/JsonPrimitive;";
			IntPtr native_memberName = JNIEnv.NewString (memberName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_memberName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonPrimitive> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_memberName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='has' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("has", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Has (string memberName)
		{
			const string __id = "has.(Ljava/lang/String;)Z";
			IntPtr native_memberName = JNIEnv.NewString (memberName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_memberName);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_memberName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='keySet' and count(parameter)=0]"
		[Register ("keySet", "()Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<string> KeySet ()
		{
			const string __id = "keySet.()Ljava/util/Set;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Remove (string property)
		{
			const string __id = "remove.(Ljava/lang/String;)Lcom/google/gson/JsonElement;";
			IntPtr native_property = JNIEnv.NewString (property);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_property);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_property);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
