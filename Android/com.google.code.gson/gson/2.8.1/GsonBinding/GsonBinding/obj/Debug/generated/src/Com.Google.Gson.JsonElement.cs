using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']"
	[global::Android.Runtime.Register ("com/google/gson/JsonElement", DoNotGenerateAcw=true)]
	public abstract partial class JsonElement : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/JsonElement", typeof (JsonElement));
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

		protected JsonElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/constructor[@name='JsonElement' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonElement ()
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

		static Delegate cb_getAsBigDecimal;
#pragma warning disable 0169
		static Delegate GetGetAsBigDecimalHandler ()
		{
			if (cb_getAsBigDecimal == null)
				cb_getAsBigDecimal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsBigDecimal);
			return cb_getAsBigDecimal;
		}

		static IntPtr n_GetAsBigDecimal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBigDecimal);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Math.BigDecimal AsBigDecimal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsBigDecimal' and count(parameter)=0]"
			[Register ("getAsBigDecimal", "()Ljava/math/BigDecimal;", "GetGetAsBigDecimalHandler")]
			get {
				const string __id = "getAsBigDecimal.()Ljava/math/BigDecimal;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsBigInteger;
#pragma warning disable 0169
		static Delegate GetGetAsBigIntegerHandler ()
		{
			if (cb_getAsBigInteger == null)
				cb_getAsBigInteger = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsBigInteger);
			return cb_getAsBigInteger;
		}

		static IntPtr n_GetAsBigInteger (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBigInteger);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Math.BigInteger AsBigInteger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsBigInteger' and count(parameter)=0]"
			[Register ("getAsBigInteger", "()Ljava/math/BigInteger;", "GetGetAsBigIntegerHandler")]
			get {
				const string __id = "getAsBigInteger.()Ljava/math/BigInteger;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsBoolean;
#pragma warning disable 0169
		static Delegate GetGetAsBooleanHandler ()
		{
			if (cb_getAsBoolean == null)
				cb_getAsBoolean = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAsBoolean);
			return cb_getAsBoolean;
		}

		static bool n_GetAsBoolean (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsBoolean;
		}
#pragma warning restore 0169

		public virtual unsafe bool AsBoolean {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsBoolean' and count(parameter)=0]"
			[Register ("getAsBoolean", "()Z", "GetGetAsBooleanHandler")]
			get {
				const string __id = "getAsBoolean.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAsByte;
#pragma warning disable 0169
		static Delegate GetGetAsByteHandler ()
		{
			if (cb_getAsByte == null)
				cb_getAsByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetAsByte);
			return cb_getAsByte;
		}

		static sbyte n_GetAsByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsByte;
		}
#pragma warning restore 0169

		public virtual unsafe sbyte AsByte {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsByte' and count(parameter)=0]"
			[Register ("getAsByte", "()B", "GetGetAsByteHandler")]
			get {
				const string __id = "getAsByte.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAsCharacter;
#pragma warning disable 0169
		static Delegate GetGetAsCharacterHandler ()
		{
			if (cb_getAsCharacter == null)
				cb_getAsCharacter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char>) n_GetAsCharacter);
			return cb_getAsCharacter;
		}

		static char n_GetAsCharacter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsCharacter;
		}
#pragma warning restore 0169

		public virtual unsafe char AsCharacter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsCharacter' and count(parameter)=0]"
			[Register ("getAsCharacter", "()C", "GetGetAsCharacterHandler")]
			get {
				const string __id = "getAsCharacter.()C";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualCharMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAsDouble;
#pragma warning disable 0169
		static Delegate GetGetAsDoubleHandler ()
		{
			if (cb_getAsDouble == null)
				cb_getAsDouble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetAsDouble);
			return cb_getAsDouble;
		}

		static double n_GetAsDouble (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsDouble;
		}
#pragma warning restore 0169

		public virtual unsafe double AsDouble {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsDouble' and count(parameter)=0]"
			[Register ("getAsDouble", "()D", "GetGetAsDoubleHandler")]
			get {
				const string __id = "getAsDouble.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAsFloat;
#pragma warning disable 0169
		static Delegate GetGetAsFloatHandler ()
		{
			if (cb_getAsFloat == null)
				cb_getAsFloat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAsFloat);
			return cb_getAsFloat;
		}

		static float n_GetAsFloat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsFloat;
		}
#pragma warning restore 0169

		public virtual unsafe float AsFloat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsFloat' and count(parameter)=0]"
			[Register ("getAsFloat", "()F", "GetGetAsFloatHandler")]
			get {
				const string __id = "getAsFloat.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAsInt;
#pragma warning disable 0169
		static Delegate GetGetAsIntHandler ()
		{
			if (cb_getAsInt == null)
				cb_getAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAsInt);
			return cb_getAsInt;
		}

		static int n_GetAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsInt;
		}
#pragma warning restore 0169

		public virtual unsafe int AsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsInt' and count(parameter)=0]"
			[Register ("getAsInt", "()I", "GetGetAsIntHandler")]
			get {
				const string __id = "getAsInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAsJsonArray;
#pragma warning disable 0169
		static Delegate GetGetAsJsonArrayHandler ()
		{
			if (cb_getAsJsonArray == null)
				cb_getAsJsonArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsJsonArray);
			return cb_getAsJsonArray;
		}

		static IntPtr n_GetAsJsonArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJsonArray);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Google.Gson.JsonArray AsJsonArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsJsonArray' and count(parameter)=0]"
			[Register ("getAsJsonArray", "()Lcom/google/gson/JsonArray;", "GetGetAsJsonArrayHandler")]
			get {
				const string __id = "getAsJsonArray.()Lcom/google/gson/JsonArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsJsonNull;
#pragma warning disable 0169
		static Delegate GetGetAsJsonNullHandler ()
		{
			if (cb_getAsJsonNull == null)
				cb_getAsJsonNull = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsJsonNull);
			return cb_getAsJsonNull;
		}

		static IntPtr n_GetAsJsonNull (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJsonNull);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Google.Gson.JsonNull AsJsonNull {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsJsonNull' and count(parameter)=0]"
			[Register ("getAsJsonNull", "()Lcom/google/gson/JsonNull;", "GetGetAsJsonNullHandler")]
			get {
				const string __id = "getAsJsonNull.()Lcom/google/gson/JsonNull;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonNull> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsJsonObject;
#pragma warning disable 0169
		static Delegate GetGetAsJsonObjectHandler ()
		{
			if (cb_getAsJsonObject == null)
				cb_getAsJsonObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsJsonObject);
			return cb_getAsJsonObject;
		}

		static IntPtr n_GetAsJsonObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJsonObject);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Google.Gson.JsonObject AsJsonObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsJsonObject' and count(parameter)=0]"
			[Register ("getAsJsonObject", "()Lcom/google/gson/JsonObject;", "GetGetAsJsonObjectHandler")]
			get {
				const string __id = "getAsJsonObject.()Lcom/google/gson/JsonObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsJsonPrimitive;
#pragma warning disable 0169
		static Delegate GetGetAsJsonPrimitiveHandler ()
		{
			if (cb_getAsJsonPrimitive == null)
				cb_getAsJsonPrimitive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsJsonPrimitive);
			return cb_getAsJsonPrimitive;
		}

		static IntPtr n_GetAsJsonPrimitive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJsonPrimitive);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Google.Gson.JsonPrimitive AsJsonPrimitive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsJsonPrimitive' and count(parameter)=0]"
			[Register ("getAsJsonPrimitive", "()Lcom/google/gson/JsonPrimitive;", "GetGetAsJsonPrimitiveHandler")]
			get {
				const string __id = "getAsJsonPrimitive.()Lcom/google/gson/JsonPrimitive;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonPrimitive> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsLong;
#pragma warning disable 0169
		static Delegate GetGetAsLongHandler ()
		{
			if (cb_getAsLong == null)
				cb_getAsLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAsLong);
			return cb_getAsLong;
		}

		static long n_GetAsLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsLong;
		}
#pragma warning restore 0169

		public virtual unsafe long AsLong {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsLong' and count(parameter)=0]"
			[Register ("getAsLong", "()J", "GetGetAsLongHandler")]
			get {
				const string __id = "getAsLong.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAsNumber;
#pragma warning disable 0169
		static Delegate GetGetAsNumberHandler ()
		{
			if (cb_getAsNumber == null)
				cb_getAsNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsNumber);
			return cb_getAsNumber;
		}

		static IntPtr n_GetAsNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsNumber);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Number AsNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsNumber' and count(parameter)=0]"
			[Register ("getAsNumber", "()Ljava/lang/Number;", "GetGetAsNumberHandler")]
			get {
				const string __id = "getAsNumber.()Ljava/lang/Number;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsShort;
#pragma warning disable 0169
		static Delegate GetGetAsShortHandler ()
		{
			if (cb_getAsShort == null)
				cb_getAsShort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetAsShort);
			return cb_getAsShort;
		}

		static short n_GetAsShort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsShort;
		}
#pragma warning restore 0169

		public virtual unsafe short AsShort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsShort' and count(parameter)=0]"
			[Register ("getAsShort", "()S", "GetGetAsShortHandler")]
			get {
				const string __id = "getAsShort.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAsString;
#pragma warning disable 0169
		static Delegate GetGetAsStringHandler ()
		{
			if (cb_getAsString == null)
				cb_getAsString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsString);
			return cb_getAsString;
		}

		static IntPtr n_GetAsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AsString);
		}
#pragma warning restore 0169

		public virtual unsafe string AsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsString' and count(parameter)=0]"
			[Register ("getAsString", "()Ljava/lang/String;", "GetGetAsStringHandler")]
			get {
				const string __id = "getAsString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isJsonArray;
#pragma warning disable 0169
		static Delegate GetIsJsonArrayHandler ()
		{
			if (cb_isJsonArray == null)
				cb_isJsonArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsJsonArray);
			return cb_isJsonArray;
		}

		static bool n_IsJsonArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsJsonArray;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsJsonArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='isJsonArray' and count(parameter)=0]"
			[Register ("isJsonArray", "()Z", "GetIsJsonArrayHandler")]
			get {
				const string __id = "isJsonArray.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isJsonNull;
#pragma warning disable 0169
		static Delegate GetIsJsonNullHandler ()
		{
			if (cb_isJsonNull == null)
				cb_isJsonNull = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsJsonNull);
			return cb_isJsonNull;
		}

		static bool n_IsJsonNull (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsJsonNull;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsJsonNull {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='isJsonNull' and count(parameter)=0]"
			[Register ("isJsonNull", "()Z", "GetIsJsonNullHandler")]
			get {
				const string __id = "isJsonNull.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isJsonObject;
#pragma warning disable 0169
		static Delegate GetIsJsonObjectHandler ()
		{
			if (cb_isJsonObject == null)
				cb_isJsonObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsJsonObject);
			return cb_isJsonObject;
		}

		static bool n_IsJsonObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsJsonObject;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsJsonObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='isJsonObject' and count(parameter)=0]"
			[Register ("isJsonObject", "()Z", "GetIsJsonObjectHandler")]
			get {
				const string __id = "isJsonObject.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isJsonPrimitive;
#pragma warning disable 0169
		static Delegate GetIsJsonPrimitiveHandler ()
		{
			if (cb_isJsonPrimitive == null)
				cb_isJsonPrimitive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsJsonPrimitive);
			return cb_isJsonPrimitive;
		}

		static bool n_IsJsonPrimitive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsJsonPrimitive;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsJsonPrimitive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='isJsonPrimitive' and count(parameter)=0]"
			[Register ("isJsonPrimitive", "()Z", "GetIsJsonPrimitiveHandler")]
			get {
				const string __id = "isJsonPrimitive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/gson/JsonElement", DoNotGenerateAcw=true)]
	internal partial class JsonElementInvoker : JsonElement {

		public JsonElementInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/JsonElement", typeof (JsonElementInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
