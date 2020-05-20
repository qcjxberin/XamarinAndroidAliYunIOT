using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']"
	[global::Android.Runtime.Register ("com/google/gson/FieldNamingPolicy", DoNotGenerateAcw=true)]
	public abstract partial class FieldNamingPolicy : global::Java.Lang.Enum, global::Com.Google.Gson.IFieldNamingStrategy {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/field[@name='IDENTITY']"
		[Register ("IDENTITY")]
		public static global::Com.Google.Gson.FieldNamingPolicy Identity {
			get {
				const string __id = "IDENTITY.Lcom/google/gson/FieldNamingPolicy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/field[@name='LOWER_CASE_WITH_DASHES']"
		[Register ("LOWER_CASE_WITH_DASHES")]
		public static global::Com.Google.Gson.FieldNamingPolicy LowerCaseWithDashes {
			get {
				const string __id = "LOWER_CASE_WITH_DASHES.Lcom/google/gson/FieldNamingPolicy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/field[@name='LOWER_CASE_WITH_UNDERSCORES']"
		[Register ("LOWER_CASE_WITH_UNDERSCORES")]
		public static global::Com.Google.Gson.FieldNamingPolicy LowerCaseWithUnderscores {
			get {
				const string __id = "LOWER_CASE_WITH_UNDERSCORES.Lcom/google/gson/FieldNamingPolicy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/field[@name='UPPER_CAMEL_CASE']"
		[Register ("UPPER_CAMEL_CASE")]
		public static global::Com.Google.Gson.FieldNamingPolicy UpperCamelCase {
			get {
				const string __id = "UPPER_CAMEL_CASE.Lcom/google/gson/FieldNamingPolicy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/field[@name='UPPER_CAMEL_CASE_WITH_SPACES']"
		[Register ("UPPER_CAMEL_CASE_WITH_SPACES")]
		public static global::Com.Google.Gson.FieldNamingPolicy UpperCamelCaseWithSpaces {
			get {
				const string __id = "UPPER_CAMEL_CASE_WITH_SPACES.Lcom/google/gson/FieldNamingPolicy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/FieldNamingPolicy", typeof (FieldNamingPolicy));
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

		protected FieldNamingPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/gson/FieldNamingPolicy;", "")]
		public static unsafe global::Com.Google.Gson.FieldNamingPolicy ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/gson/FieldNamingPolicy;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/gson/FieldNamingPolicy;", "")]
		public static unsafe global::Com.Google.Gson.FieldNamingPolicy[] Values ()
		{
			const string __id = "values.()[Lcom/google/gson/FieldNamingPolicy;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Google.Gson.FieldNamingPolicy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Gson.FieldNamingPolicy));
			} finally {
			}
		}

		static Delegate cb_translateName_Ljava_lang_reflect_Field_;
#pragma warning disable 0169
		static Delegate GetTranslateName_Ljava_lang_reflect_Field_Handler ()
		{
			if (cb_translateName_Ljava_lang_reflect_Field_ == null)
				cb_translateName_Ljava_lang_reflect_Field_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TranslateName_Ljava_lang_reflect_Field_);
			return cb_translateName_Ljava_lang_reflect_Field_;
		}

		static IntPtr n_TranslateName_Ljava_lang_reflect_Field_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.FieldNamingPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.Field p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.TranslateName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='FieldNamingStrategy']/method[@name='translateName' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register ("translateName", "(Ljava/lang/reflect/Field;)Ljava/lang/String;", "GetTranslateName_Ljava_lang_reflect_Field_Handler")]
		public abstract string TranslateName (global::Java.Lang.Reflect.Field p0);

	}

	[global::Android.Runtime.Register ("com/google/gson/FieldNamingPolicy", DoNotGenerateAcw=true)]
	internal partial class FieldNamingPolicyInvoker : FieldNamingPolicy {

		public FieldNamingPolicyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/FieldNamingPolicy", typeof (FieldNamingPolicyInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='FieldNamingStrategy']/method[@name='translateName' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register ("translateName", "(Ljava/lang/reflect/Field;)Ljava/lang/String;", "GetTranslateName_Ljava_lang_reflect_Field_Handler")]
		public override unsafe string TranslateName (global::Java.Lang.Reflect.Field p0)
		{
			const string __id = "translateName.(Ljava/lang/reflect/Field;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
