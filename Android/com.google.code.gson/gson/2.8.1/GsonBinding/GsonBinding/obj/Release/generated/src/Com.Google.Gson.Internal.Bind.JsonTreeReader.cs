using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='JsonTreeReader']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/JsonTreeReader", DoNotGenerateAcw=true)]
	public sealed partial class JsonTreeReader : global::Com.Google.Gson.Stream.JsonReader {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/bind/JsonTreeReader", typeof (JsonTreeReader));
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

		internal JsonTreeReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='JsonTreeReader']/constructor[@name='JsonTreeReader' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register (".ctor", "(Lcom/google/gson/JsonElement;)V", "")]
		public unsafe JsonTreeReader (global::Com.Google.Gson.JsonElement element)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/gson/JsonElement;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((element == null) ? IntPtr.Zero : ((global::Java.Lang.Object) element).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='JsonTreeReader']/method[@name='promoteNameToValue' and count(parameter)=0]"
		[Register ("promoteNameToValue", "()V", "")]
		public unsafe void PromoteNameToValue ()
		{
			const string __id = "promoteNameToValue.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
