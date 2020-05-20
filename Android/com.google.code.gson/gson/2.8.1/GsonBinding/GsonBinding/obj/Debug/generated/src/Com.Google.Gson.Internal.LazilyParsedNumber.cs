using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LazilyParsedNumber']"
	[global::Android.Runtime.Register ("com/google/gson/internal/LazilyParsedNumber", DoNotGenerateAcw=true)]
	public sealed partial class LazilyParsedNumber : global::Java.Lang.Number {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/LazilyParsedNumber", typeof (LazilyParsedNumber));
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

		internal LazilyParsedNumber (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LazilyParsedNumber']/constructor[@name='LazilyParsedNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe LazilyParsedNumber (string value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LazilyParsedNumber']/method[@name='doubleValue' and count(parameter)=0]"
		[Register ("doubleValue", "()D", "")]
		public override unsafe double DoubleValue ()
		{
			const string __id = "doubleValue.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LazilyParsedNumber']/method[@name='floatValue' and count(parameter)=0]"
		[Register ("floatValue", "()F", "")]
		public override unsafe float FloatValue ()
		{
			const string __id = "floatValue.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LazilyParsedNumber']/method[@name='intValue' and count(parameter)=0]"
		[Register ("intValue", "()I", "")]
		public override unsafe int IntValue ()
		{
			const string __id = "intValue.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LazilyParsedNumber']/method[@name='longValue' and count(parameter)=0]"
		[Register ("longValue", "()J", "")]
		public override unsafe long LongValue ()
		{
			const string __id = "longValue.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
