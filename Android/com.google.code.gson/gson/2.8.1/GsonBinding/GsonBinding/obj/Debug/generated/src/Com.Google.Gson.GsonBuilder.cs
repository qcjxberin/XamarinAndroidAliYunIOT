using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']"
	[global::Android.Runtime.Register ("com/google/gson/GsonBuilder", DoNotGenerateAcw=true)]
	public sealed partial class GsonBuilder : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/GsonBuilder", typeof (GsonBuilder));
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

		internal GsonBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/constructor[@name='GsonBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GsonBuilder ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='addDeserializationExclusionStrategy' and count(parameter)=1 and parameter[1][@type='com.google.gson.ExclusionStrategy']]"
		[Register ("addDeserializationExclusionStrategy", "(Lcom/google/gson/ExclusionStrategy;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder AddDeserializationExclusionStrategy (global::Com.Google.Gson.IExclusionStrategy strategy)
		{
			const string __id = "addDeserializationExclusionStrategy.(Lcom/google/gson/ExclusionStrategy;)Lcom/google/gson/GsonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='addSerializationExclusionStrategy' and count(parameter)=1 and parameter[1][@type='com.google.gson.ExclusionStrategy']]"
		[Register ("addSerializationExclusionStrategy", "(Lcom/google/gson/ExclusionStrategy;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder AddSerializationExclusionStrategy (global::Com.Google.Gson.IExclusionStrategy strategy)
		{
			const string __id = "addSerializationExclusionStrategy.(Lcom/google/gson/ExclusionStrategy;)Lcom/google/gson/GsonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/google/gson/Gson;", "")]
		public unsafe global::Com.Google.Gson.Gson Create ()
		{
			const string __id = "create.()Lcom/google/gson/Gson;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Gson> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='disableHtmlEscaping' and count(parameter)=0]"
		[Register ("disableHtmlEscaping", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder DisableHtmlEscaping ()
		{
			const string __id = "disableHtmlEscaping.()Lcom/google/gson/GsonBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='disableInnerClassSerialization' and count(parameter)=0]"
		[Register ("disableInnerClassSerialization", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder DisableInnerClassSerialization ()
		{
			const string __id = "disableInnerClassSerialization.()Lcom/google/gson/GsonBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='enableComplexMapKeySerialization' and count(parameter)=0]"
		[Register ("enableComplexMapKeySerialization", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder EnableComplexMapKeySerialization ()
		{
			const string __id = "enableComplexMapKeySerialization.()Lcom/google/gson/GsonBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='excludeFieldsWithModifiers' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("excludeFieldsWithModifiers", "([I)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder ExcludeFieldsWithModifiers (params int[] modifiers)
		{
			const string __id = "excludeFieldsWithModifiers.([I)Lcom/google/gson/GsonBuilder;";
			IntPtr native_modifiers = JNIEnv.NewArray (modifiers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_modifiers);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (modifiers != null) {
					JNIEnv.CopyArray (native_modifiers, modifiers);
					JNIEnv.DeleteLocalRef (native_modifiers);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='excludeFieldsWithoutExposeAnnotation' and count(parameter)=0]"
		[Register ("excludeFieldsWithoutExposeAnnotation", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder ExcludeFieldsWithoutExposeAnnotation ()
		{
			const string __id = "excludeFieldsWithoutExposeAnnotation.()Lcom/google/gson/GsonBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='generateNonExecutableJson' and count(parameter)=0]"
		[Register ("generateNonExecutableJson", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder GenerateNonExecutableJson ()
		{
			const string __id = "generateNonExecutableJson.()Lcom/google/gson/GsonBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='registerTypeAdapter' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.Object']]"
		[Register ("registerTypeAdapter", "(Ljava/lang/reflect/Type;Ljava/lang/Object;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder RegisterTypeAdapter (global::Java.Lang.Reflect.IType type, global::Java.Lang.Object typeAdapter)
		{
			const string __id = "registerTypeAdapter.(Ljava/lang/reflect/Type;Ljava/lang/Object;)Lcom/google/gson/GsonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue ((typeAdapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeAdapter).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='registerTypeAdapterFactory' and count(parameter)=1 and parameter[1][@type='com.google.gson.TypeAdapterFactory']]"
		[Register ("registerTypeAdapterFactory", "(Lcom/google/gson/TypeAdapterFactory;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder RegisterTypeAdapterFactory (global::Com.Google.Gson.ITypeAdapterFactory factory)
		{
			const string __id = "registerTypeAdapterFactory.(Lcom/google/gson/TypeAdapterFactory;)Lcom/google/gson/GsonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((factory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) factory).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='registerTypeHierarchyAdapter' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("registerTypeHierarchyAdapter", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder RegisterTypeHierarchyAdapter (global::Java.Lang.Class baseType, global::Java.Lang.Object typeAdapter)
		{
			const string __id = "registerTypeHierarchyAdapter.(Ljava/lang/Class;Ljava/lang/Object;)Lcom/google/gson/GsonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((baseType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baseType).Handle);
				__args [1] = new JniArgumentValue ((typeAdapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeAdapter).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='serializeNulls' and count(parameter)=0]"
		[Register ("serializeNulls", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SerializeNulls ()
		{
			const string __id = "serializeNulls.()Lcom/google/gson/GsonBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='serializeSpecialFloatingPointValues' and count(parameter)=0]"
		[Register ("serializeSpecialFloatingPointValues", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SerializeSpecialFloatingPointValues ()
		{
			const string __id = "serializeSpecialFloatingPointValues.()Lcom/google/gson/GsonBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setDateFormat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDateFormat", "(I)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetDateFormat (int style)
		{
			const string __id = "setDateFormat.(I)Lcom/google/gson/GsonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (style);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setDateFormat' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setDateFormat", "(II)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetDateFormat (int dateStyle, int timeStyle)
		{
			const string __id = "setDateFormat.(II)Lcom/google/gson/GsonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (dateStyle);
				__args [1] = new JniArgumentValue (timeStyle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setDateFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDateFormat", "(Ljava/lang/String;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetDateFormat (string pattern)
		{
			const string __id = "setDateFormat.(Ljava/lang/String;)Lcom/google/gson/GsonBuilder;";
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_pattern);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setExclusionStrategies' and count(parameter)=1 and parameter[1][@type='com.google.gson.ExclusionStrategy...']]"
		[Register ("setExclusionStrategies", "([Lcom/google/gson/ExclusionStrategy;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetExclusionStrategies (params global::Com.Google.Gson.IExclusionStrategy[] strategies)
		{
			const string __id = "setExclusionStrategies.([Lcom/google/gson/ExclusionStrategy;)Lcom/google/gson/GsonBuilder;";
			IntPtr native_strategies = JNIEnv.NewArray (strategies);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_strategies);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (strategies != null) {
					JNIEnv.CopyArray (native_strategies, strategies);
					JNIEnv.DeleteLocalRef (native_strategies);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setFieldNamingPolicy' and count(parameter)=1 and parameter[1][@type='com.google.gson.FieldNamingPolicy']]"
		[Register ("setFieldNamingPolicy", "(Lcom/google/gson/FieldNamingPolicy;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetFieldNamingPolicy (global::Com.Google.Gson.FieldNamingPolicy namingConvention)
		{
			const string __id = "setFieldNamingPolicy.(Lcom/google/gson/FieldNamingPolicy;)Lcom/google/gson/GsonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((namingConvention == null) ? IntPtr.Zero : ((global::Java.Lang.Object) namingConvention).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setFieldNamingStrategy' and count(parameter)=1 and parameter[1][@type='com.google.gson.FieldNamingStrategy']]"
		[Register ("setFieldNamingStrategy", "(Lcom/google/gson/FieldNamingStrategy;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetFieldNamingStrategy (global::Com.Google.Gson.IFieldNamingStrategy fieldNamingStrategy)
		{
			const string __id = "setFieldNamingStrategy.(Lcom/google/gson/FieldNamingStrategy;)Lcom/google/gson/GsonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fieldNamingStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fieldNamingStrategy).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setLenient' and count(parameter)=0]"
		[Register ("setLenient", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetLenient ()
		{
			const string __id = "setLenient.()Lcom/google/gson/GsonBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setLongSerializationPolicy' and count(parameter)=1 and parameter[1][@type='com.google.gson.LongSerializationPolicy']]"
		[Register ("setLongSerializationPolicy", "(Lcom/google/gson/LongSerializationPolicy;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetLongSerializationPolicy (global::Com.Google.Gson.LongSerializationPolicy serializationPolicy)
		{
			const string __id = "setLongSerializationPolicy.(Lcom/google/gson/LongSerializationPolicy;)Lcom/google/gson/GsonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((serializationPolicy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serializationPolicy).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setPrettyPrinting' and count(parameter)=0]"
		[Register ("setPrettyPrinting", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetPrettyPrinting ()
		{
			const string __id = "setPrettyPrinting.()Lcom/google/gson/GsonBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setVersion", "(D)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetVersion (double ignoreVersionsAfter)
		{
			const string __id = "setVersion.(D)Lcom/google/gson/GsonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ignoreVersionsAfter);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
