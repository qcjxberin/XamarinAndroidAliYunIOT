using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonNull']"
	[global::Android.Runtime.Register ("com/google/gson/JsonNull", DoNotGenerateAcw=true)]
	public sealed partial class JsonNull : global::Com.Google.Gson.JsonElement {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='JsonNull']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Google.Gson.JsonNull Instance {
			get {
				const string __id = "INSTANCE.Lcom/google/gson/JsonNull;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonNull> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/JsonNull", typeof (JsonNull));
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

		internal JsonNull (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonNull']/constructor[@name='JsonNull' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		[Obsolete (@"deprecated")]
		public unsafe JsonNull ()
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

	}
}
