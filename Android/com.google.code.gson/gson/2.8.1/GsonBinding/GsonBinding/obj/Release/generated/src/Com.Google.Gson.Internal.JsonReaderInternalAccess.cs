using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JsonReaderInternalAccess']"
	[global::Android.Runtime.Register ("com/google/gson/internal/JsonReaderInternalAccess", DoNotGenerateAcw=true)]
	public abstract partial class JsonReaderInternalAccess : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JsonReaderInternalAccess']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Google.Gson.Internal.JsonReaderInternalAccess Instance {
			get {
				const string __id = "INSTANCE.Lcom/google/gson/internal/JsonReaderInternalAccess;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.JsonReaderInternalAccess> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "INSTANCE.Lcom/google/gson/internal/JsonReaderInternalAccess;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/JsonReaderInternalAccess", typeof (JsonReaderInternalAccess));
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

		protected JsonReaderInternalAccess (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JsonReaderInternalAccess']/constructor[@name='JsonReaderInternalAccess' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonReaderInternalAccess ()
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

		static Delegate cb_promoteNameToValue_Lcom_google_gson_stream_JsonReader_;
#pragma warning disable 0169
		static Delegate GetPromoteNameToValue_Lcom_google_gson_stream_JsonReader_Handler ()
		{
			if (cb_promoteNameToValue_Lcom_google_gson_stream_JsonReader_ == null)
				cb_promoteNameToValue_Lcom_google_gson_stream_JsonReader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PromoteNameToValue_Lcom_google_gson_stream_JsonReader_);
			return cb_promoteNameToValue_Lcom_google_gson_stream_JsonReader_;
		}

		static void n_PromoteNameToValue_Lcom_google_gson_stream_JsonReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.Internal.JsonReaderInternalAccess __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.JsonReaderInternalAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.Stream.JsonReader p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PromoteNameToValue (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JsonReaderInternalAccess']/method[@name='promoteNameToValue' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("promoteNameToValue", "(Lcom/google/gson/stream/JsonReader;)V", "GetPromoteNameToValue_Lcom_google_gson_stream_JsonReader_Handler")]
		public abstract void PromoteNameToValue (global::Com.Google.Gson.Stream.JsonReader p0);

	}

	[global::Android.Runtime.Register ("com/google/gson/internal/JsonReaderInternalAccess", DoNotGenerateAcw=true)]
	internal partial class JsonReaderInternalAccessInvoker : JsonReaderInternalAccess {

		public JsonReaderInternalAccessInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/JsonReaderInternalAccess", typeof (JsonReaderInternalAccessInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JsonReaderInternalAccess']/method[@name='promoteNameToValue' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("promoteNameToValue", "(Lcom/google/gson/stream/JsonReader;)V", "GetPromoteNameToValue_Lcom_google_gson_stream_JsonReader_Handler")]
		public override unsafe void PromoteNameToValue (global::Com.Google.Gson.Stream.JsonReader p0)
		{
			const string __id = "promoteNameToValue.(Lcom/google/gson/stream/JsonReader;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
