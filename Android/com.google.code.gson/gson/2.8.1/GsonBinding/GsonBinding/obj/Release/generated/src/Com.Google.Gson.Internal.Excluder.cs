using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']"
	[global::Android.Runtime.Register ("com/google/gson/internal/Excluder", DoNotGenerateAcw=true)]
	public sealed partial class Excluder : global::Java.Lang.Object, global::Com.Google.Gson.ITypeAdapterFactory, global::Java.Lang.ICloneable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Google.Gson.Internal.Excluder Default {
			get {
				const string __id = "DEFAULT.Lcom/google/gson/internal/Excluder;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/Excluder", typeof (Excluder));
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

		internal Excluder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/constructor[@name='Excluder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Excluder ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.google.gson.Gson'] and parameter[2][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='disableInnerClassSerialization' and count(parameter)=0]"
		[Register ("disableInnerClassSerialization", "()Lcom/google/gson/internal/Excluder;", "")]
		public unsafe global::Com.Google.Gson.Internal.Excluder DisableInnerClassSerialization ()
		{
			const string __id = "disableInnerClassSerialization.()Lcom/google/gson/internal/Excluder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='excludeClass' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='boolean']]"
		[Register ("excludeClass", "(Ljava/lang/Class;Z)Z", "")]
		public unsafe bool ExcludeClass (global::Java.Lang.Class clazz, bool serialize)
		{
			const string __id = "excludeClass.(Ljava/lang/Class;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (serialize);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='excludeField' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='boolean']]"
		[Register ("excludeField", "(Ljava/lang/reflect/Field;Z)Z", "")]
		public unsafe bool ExcludeField (global::Java.Lang.Reflect.Field field, bool serialize)
		{
			const string __id = "excludeField.(Ljava/lang/reflect/Field;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((field == null) ? IntPtr.Zero : ((global::Java.Lang.Object) field).Handle);
				__args [1] = new JniArgumentValue (serialize);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='excludeFieldsWithoutExposeAnnotation' and count(parameter)=0]"
		[Register ("excludeFieldsWithoutExposeAnnotation", "()Lcom/google/gson/internal/Excluder;", "")]
		public unsafe global::Com.Google.Gson.Internal.Excluder ExcludeFieldsWithoutExposeAnnotation ()
		{
			const string __id = "excludeFieldsWithoutExposeAnnotation.()Lcom/google/gson/internal/Excluder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='withExclusionStrategy' and count(parameter)=3 and parameter[1][@type='com.google.gson.ExclusionStrategy'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("withExclusionStrategy", "(Lcom/google/gson/ExclusionStrategy;ZZ)Lcom/google/gson/internal/Excluder;", "")]
		public unsafe global::Com.Google.Gson.Internal.Excluder WithExclusionStrategy (global::Com.Google.Gson.IExclusionStrategy exclusionStrategy, bool serialization, bool deserialization)
		{
			const string __id = "withExclusionStrategy.(Lcom/google/gson/ExclusionStrategy;ZZ)Lcom/google/gson/internal/Excluder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((exclusionStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exclusionStrategy).Handle);
				__args [1] = new JniArgumentValue (serialization);
				__args [2] = new JniArgumentValue (deserialization);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='withModifiers' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("withModifiers", "([I)Lcom/google/gson/internal/Excluder;", "")]
		public unsafe global::Com.Google.Gson.Internal.Excluder WithModifiers (params int[] modifiers)
		{
			const string __id = "withModifiers.([I)Lcom/google/gson/internal/Excluder;";
			IntPtr native_modifiers = JNIEnv.NewArray (modifiers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_modifiers);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (modifiers != null) {
					JNIEnv.CopyArray (native_modifiers, modifiers);
					JNIEnv.DeleteLocalRef (native_modifiers);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='withVersion' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("withVersion", "(D)Lcom/google/gson/internal/Excluder;", "")]
		public unsafe global::Com.Google.Gson.Internal.Excluder WithVersion (double ignoreVersionsAfter)
		{
			const string __id = "withVersion.(D)Lcom/google/gson/internal/Excluder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ignoreVersionsAfter);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
