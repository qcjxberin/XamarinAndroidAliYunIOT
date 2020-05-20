using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonStreamParser']"
	[global::Android.Runtime.Register ("com/google/gson/JsonStreamParser", DoNotGenerateAcw=true)]
	public sealed partial class JsonStreamParser : global::Java.Lang.Object, global::Java.Util.IIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/JsonStreamParser", typeof (JsonStreamParser));
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

		internal JsonStreamParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonStreamParser']/constructor[@name='JsonStreamParser' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register (".ctor", "(Ljava/io/Reader;)V", "")]
		public unsafe JsonStreamParser (global::Java.IO.Reader reader)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonStreamParser']/constructor[@name='JsonStreamParser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe JsonStreamParser (string json)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_json);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		public unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonStreamParser']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonStreamParser']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Next ()
		{
			const string __id = "next.()Lcom/google/gson/JsonElement;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonStreamParser']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "")]
		public unsafe void Remove ()
		{
			const string __id = "remove.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
