using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='DateTypeAdapter']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/DateTypeAdapter", DoNotGenerateAcw=true)]
	public sealed partial class DateTypeAdapter : global::Com.Google.Gson.TypeAdapter {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='DateTypeAdapter']/field[@name='FACTORY']"
		[Register ("FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory Factory {
			get {
				const string __id = "FACTORY.Lcom/google/gson/TypeAdapterFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/bind/DateTypeAdapter", typeof (DateTypeAdapter));
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

		internal DateTypeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='DateTypeAdapter']/constructor[@name='DateTypeAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateTypeAdapter ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='DateTypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/util/Date;", "")]
		public unsafe global::Java.Util.Date RawRead (global::Com.Google.Gson.Stream.JsonReader @in)
		{
			const string __id = "read.(Lcom/google/gson/stream/JsonReader;)Ljava/util/Date;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='DateTypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='java.util.Date']]"
		[Register ("write", "(Lcom/google/gson/stream/JsonWriter;Ljava/util/Date;)V", "")]
		public unsafe void RawWrite (global::Com.Google.Gson.Stream.JsonWriter @out, global::Java.Util.Date value)
		{
			const string __id = "write.(Lcom/google/gson/stream/JsonWriter;Ljava/util/Date;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
