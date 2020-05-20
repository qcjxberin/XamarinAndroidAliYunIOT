using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='JsonTreeWriter']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/JsonTreeWriter", DoNotGenerateAcw=true)]
	public sealed partial class JsonTreeWriter : global::Com.Google.Gson.Stream.JsonWriter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/bind/JsonTreeWriter", typeof (JsonTreeWriter));
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

		internal JsonTreeWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='JsonTreeWriter']/constructor[@name='JsonTreeWriter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonTreeWriter ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='JsonTreeWriter']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Get ()
		{
			const string __id = "get.()Lcom/google/gson/JsonElement;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
