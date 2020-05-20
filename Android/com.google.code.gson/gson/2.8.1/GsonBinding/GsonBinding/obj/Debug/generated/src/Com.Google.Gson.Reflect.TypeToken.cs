using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']"
	[global::Android.Runtime.Register ("com/google/gson/reflect/TypeToken", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class TypeToken : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/reflect/TypeToken", typeof (TypeToken));
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

		protected TypeToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/constructor[@name='TypeToken' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe TypeToken ()
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

		public unsafe global::Java.Lang.Class RawType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='getRawType' and count(parameter)=0]"
			[Register ("getRawType", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getRawType.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Reflect.IType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/reflect/Type;", "")]
			get {
				const string __id = "getType.()Ljava/lang/reflect/Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed unsafe bool Equals (global::Java.Lang.Object o)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("get", "(Ljava/lang/Class;)Lcom/google/gson/reflect/TypeToken;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Google.Gson.Reflect.TypeToken Get (global::Java.Lang.Class type)
		{
			const string __id = "get.(Ljava/lang/Class;)Lcom/google/gson/reflect/TypeToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("get", "(Ljava/lang/reflect/Type;)Lcom/google/gson/reflect/TypeToken;", "")]
		public static unsafe global::Com.Google.Gson.Reflect.TypeToken Get (global::Java.Lang.Reflect.IType type)
		{
			const string __id = "get.(Ljava/lang/reflect/Type;)Lcom/google/gson/reflect/TypeToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='getArray' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("getArray", "(Ljava/lang/reflect/Type;)Lcom/google/gson/reflect/TypeToken;", "")]
		public static unsafe global::Com.Google.Gson.Reflect.TypeToken GetArray (global::Java.Lang.Reflect.IType componentType)
		{
			const string __id = "getArray.(Ljava/lang/reflect/Type;)Lcom/google/gson/reflect/TypeToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((componentType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) componentType).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='getParameterized' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.reflect.Type...']]"
		[Register ("getParameterized", "(Ljava/lang/reflect/Type;[Ljava/lang/reflect/Type;)Lcom/google/gson/reflect/TypeToken;", "")]
		public static unsafe global::Com.Google.Gson.Reflect.TypeToken GetParameterized (global::Java.Lang.Reflect.IType rawType, params global::Java.Lang.Reflect.IType[] typeArguments)
		{
			const string __id = "getParameterized.(Ljava/lang/reflect/Type;[Ljava/lang/reflect/Type;)Lcom/google/gson/reflect/TypeToken;";
			IntPtr native_typeArguments = JNIEnv.NewArray (typeArguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rawType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rawType).Handle);
				__args [1] = new JniArgumentValue (native_typeArguments);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (typeArguments != null) {
					JNIEnv.CopyArray (native_typeArguments, typeArguments);
					JNIEnv.DeleteLocalRef (native_typeArguments);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed unsafe int GetHashCode ()
		{
			const string __id = "hashCode.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isAssignableFrom_Lcom_google_gson_reflect_TypeToken_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIsAssignableFrom_Lcom_google_gson_reflect_TypeToken_Handler ()
		{
			if (cb_isAssignableFrom_Lcom_google_gson_reflect_TypeToken_ == null)
				cb_isAssignableFrom_Lcom_google_gson_reflect_TypeToken_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAssignableFrom_Lcom_google_gson_reflect_TypeToken_);
			return cb_isAssignableFrom_Lcom_google_gson_reflect_TypeToken_;
		}

		[Obsolete]
		static bool n_IsAssignableFrom_Lcom_google_gson_reflect_TypeToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			global::Com.Google.Gson.Reflect.TypeToken __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.Reflect.TypeToken token = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (native_token, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAssignableFrom (token);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='isAssignableFrom' and count(parameter)=1 and parameter[1][@type='com.google.gson.reflect.TypeToken&lt;?&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("isAssignableFrom", "(Lcom/google/gson/reflect/TypeToken;)Z", "GetIsAssignableFrom_Lcom_google_gson_reflect_TypeToken_Handler")]
		public virtual unsafe bool IsAssignableFrom (global::Com.Google.Gson.Reflect.TypeToken token)
		{
			const string __id = "isAssignableFrom.(Lcom/google/gson/reflect/TypeToken;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isAssignableFrom_Ljava_lang_Class_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIsAssignableFrom_Ljava_lang_Class_Handler ()
		{
			if (cb_isAssignableFrom_Ljava_lang_Class_ == null)
				cb_isAssignableFrom_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAssignableFrom_Ljava_lang_Class_);
			return cb_isAssignableFrom_Ljava_lang_Class_;
		}

		[Obsolete]
		static bool n_IsAssignableFrom_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cls)
		{
			global::Com.Google.Gson.Reflect.TypeToken __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class cls = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_cls, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAssignableFrom (cls);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='isAssignableFrom' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("isAssignableFrom", "(Ljava/lang/Class;)Z", "GetIsAssignableFrom_Ljava_lang_Class_Handler")]
		public virtual unsafe bool IsAssignableFrom (global::Java.Lang.Class cls)
		{
			const string __id = "isAssignableFrom.(Ljava/lang/Class;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cls == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cls).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isAssignableFrom_Ljava_lang_reflect_Type_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIsAssignableFrom_Ljava_lang_reflect_Type_Handler ()
		{
			if (cb_isAssignableFrom_Ljava_lang_reflect_Type_ == null)
				cb_isAssignableFrom_Ljava_lang_reflect_Type_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAssignableFrom_Ljava_lang_reflect_Type_);
			return cb_isAssignableFrom_Ljava_lang_reflect_Type_;
		}

		[Obsolete]
		static bool n_IsAssignableFrom_Ljava_lang_reflect_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_from)
		{
			global::Com.Google.Gson.Reflect.TypeToken __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.IType from = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_from, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAssignableFrom (from);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='isAssignableFrom' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Obsolete (@"deprecated")]
		[Register ("isAssignableFrom", "(Ljava/lang/reflect/Type;)Z", "GetIsAssignableFrom_Ljava_lang_reflect_Type_Handler")]
		public virtual unsafe bool IsAssignableFrom (global::Java.Lang.Reflect.IType from)
		{
			const string __id = "isAssignableFrom.(Ljava/lang/reflect/Type;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((from == null) ? IntPtr.Zero : ((global::Java.Lang.Object) from).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
