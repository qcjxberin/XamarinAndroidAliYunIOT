using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']"
	[global::Android.Runtime.Register ("com/google/gson/LongSerializationPolicy", DoNotGenerateAcw=true)]
	public abstract partial class LongSerializationPolicy : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Google.Gson.LongSerializationPolicy Default {
			get {
				const string __id = "DEFAULT.Lcom/google/gson/LongSerializationPolicy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.LongSerializationPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']/field[@name='STRING']"
		[Register ("STRING")]
		public static global::Com.Google.Gson.LongSerializationPolicy String {
			get {
				const string __id = "STRING.Lcom/google/gson/LongSerializationPolicy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.LongSerializationPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/LongSerializationPolicy", typeof (LongSerializationPolicy));
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

		protected LongSerializationPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_serialize_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSerialize_Ljava_lang_Long_Handler ()
		{
			if (cb_serialize_Ljava_lang_Long_ == null)
				cb_serialize_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Serialize_Ljava_lang_Long_);
			return cb_serialize_Ljava_lang_Long_;
		}

		static IntPtr n_Serialize_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.LongSerializationPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.LongSerializationPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Serialize (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("serialize", "(Ljava/lang/Long;)Lcom/google/gson/JsonElement;", "GetSerialize_Ljava_lang_Long_Handler")]
		public abstract global::Com.Google.Gson.JsonElement Serialize (global::Java.Lang.Long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/gson/LongSerializationPolicy;", "")]
		public static unsafe global::Com.Google.Gson.LongSerializationPolicy ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/gson/LongSerializationPolicy;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.LongSerializationPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/gson/LongSerializationPolicy;", "")]
		public static unsafe global::Com.Google.Gson.LongSerializationPolicy[] Values ()
		{
			const string __id = "values.()[Lcom/google/gson/LongSerializationPolicy;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Google.Gson.LongSerializationPolicy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Gson.LongSerializationPolicy));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/gson/LongSerializationPolicy", DoNotGenerateAcw=true)]
	internal partial class LongSerializationPolicyInvoker : LongSerializationPolicy {

		public LongSerializationPolicyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/LongSerializationPolicy", typeof (LongSerializationPolicyInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("serialize", "(Ljava/lang/Long;)Lcom/google/gson/JsonElement;", "GetSerialize_Ljava_lang_Long_Handler")]
		public override unsafe global::Com.Google.Gson.JsonElement Serialize (global::Java.Lang.Long p0)
		{
			const string __id = "serialize.(Ljava/lang/Long;)Lcom/google/gson/JsonElement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
