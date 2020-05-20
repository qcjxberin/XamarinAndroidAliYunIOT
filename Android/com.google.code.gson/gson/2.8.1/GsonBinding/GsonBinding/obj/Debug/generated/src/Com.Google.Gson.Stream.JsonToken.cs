using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']"
	[global::Android.Runtime.Register ("com/google/gson/stream/JsonToken", DoNotGenerateAcw=true)]
	public sealed partial class JsonToken : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='BEGIN_ARRAY']"
		[Register ("BEGIN_ARRAY")]
		public static global::Com.Google.Gson.Stream.JsonToken BeginArray {
			get {
				const string __id = "BEGIN_ARRAY.Lcom/google/gson/stream/JsonToken;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='BEGIN_OBJECT']"
		[Register ("BEGIN_OBJECT")]
		public static global::Com.Google.Gson.Stream.JsonToken BeginObject {
			get {
				const string __id = "BEGIN_OBJECT.Lcom/google/gson/stream/JsonToken;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='BOOLEAN']"
		[Register ("BOOLEAN")]
		public static global::Com.Google.Gson.Stream.JsonToken Boolean {
			get {
				const string __id = "BOOLEAN.Lcom/google/gson/stream/JsonToken;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='END_ARRAY']"
		[Register ("END_ARRAY")]
		public static global::Com.Google.Gson.Stream.JsonToken EndArray {
			get {
				const string __id = "END_ARRAY.Lcom/google/gson/stream/JsonToken;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='END_DOCUMENT']"
		[Register ("END_DOCUMENT")]
		public static global::Com.Google.Gson.Stream.JsonToken EndDocument {
			get {
				const string __id = "END_DOCUMENT.Lcom/google/gson/stream/JsonToken;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='END_OBJECT']"
		[Register ("END_OBJECT")]
		public static global::Com.Google.Gson.Stream.JsonToken EndObject {
			get {
				const string __id = "END_OBJECT.Lcom/google/gson/stream/JsonToken;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='NAME']"
		[Register ("NAME")]
		public static global::Com.Google.Gson.Stream.JsonToken Name {
			get {
				const string __id = "NAME.Lcom/google/gson/stream/JsonToken;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='NULL']"
		[Register ("NULL")]
		public static global::Com.Google.Gson.Stream.JsonToken Null {
			get {
				const string __id = "NULL.Lcom/google/gson/stream/JsonToken;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='NUMBER']"
		[Register ("NUMBER")]
		public static global::Com.Google.Gson.Stream.JsonToken Number {
			get {
				const string __id = "NUMBER.Lcom/google/gson/stream/JsonToken;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='STRING']"
		[Register ("STRING")]
		public static global::Com.Google.Gson.Stream.JsonToken String {
			get {
				const string __id = "STRING.Lcom/google/gson/stream/JsonToken;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/stream/JsonToken", typeof (JsonToken));
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

		internal JsonToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonToken;", "")]
		public static unsafe global::Com.Google.Gson.Stream.JsonToken ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/gson/stream/JsonToken;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/gson/stream/JsonToken;", "")]
		public static unsafe global::Com.Google.Gson.Stream.JsonToken[] Values ()
		{
			const string __id = "values.()[Lcom/google/gson/stream/JsonToken;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Google.Gson.Stream.JsonToken[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Gson.Stream.JsonToken));
			} finally {
			}
		}

	}
}
