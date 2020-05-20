using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonParser']"
	[global::Android.Runtime.Register ("com/google/gson/JsonParser", DoNotGenerateAcw=true)]
	public sealed partial class JsonParser : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/JsonParser", typeof (JsonParser));
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

		internal JsonParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonParser']/constructor[@name='JsonParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonParser ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("parse", "(Lcom/google/gson/stream/JsonReader;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Parse (global::Com.Google.Gson.Stream.JsonReader json)
		{
			const string __id = "parse.(Lcom/google/gson/stream/JsonReader;)Lcom/google/gson/JsonElement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((json == null) ? IntPtr.Zero : ((global::Java.Lang.Object) json).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("parse", "(Ljava/io/Reader;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Parse (global::Java.IO.Reader json)
		{
			const string __id = "parse.(Ljava/io/Reader;)Lcom/google/gson/JsonElement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((json == null) ? IntPtr.Zero : ((global::Java.Lang.Object) json).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Parse (string json)
		{
			const string __id = "parse.(Ljava/lang/String;)Lcom/google/gson/JsonElement;";
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_json);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

	}
}
