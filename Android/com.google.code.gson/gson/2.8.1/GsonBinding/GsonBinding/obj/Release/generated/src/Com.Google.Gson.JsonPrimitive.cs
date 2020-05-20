using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']"
	[global::Android.Runtime.Register ("com/google/gson/JsonPrimitive", DoNotGenerateAcw=true)]
	public sealed partial class JsonPrimitive : global::Com.Google.Gson.JsonElement {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/JsonPrimitive", typeof (JsonPrimitive));
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

		internal JsonPrimitive (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/constructor[@name='JsonPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register (".ctor", "(Ljava/lang/Boolean;)V", "")]
		public unsafe JsonPrimitive (global::Java.Lang.Boolean @bool)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Boolean;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@bool == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @bool).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/constructor[@name='JsonPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Character']]"
		[Register (".ctor", "(Ljava/lang/Character;)V", "")]
		public unsafe JsonPrimitive (global::Java.Lang.Character c)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Character;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/constructor[@name='JsonPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register (".ctor", "(Ljava/lang/Number;)V", "")]
		public unsafe JsonPrimitive (global::Java.Lang.Number number)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Number;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/constructor[@name='JsonPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe JsonPrimitive (string @string)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		public unsafe bool IsBoolean {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/method[@name='isBoolean' and count(parameter)=0]"
			[Register ("isBoolean", "()Z", "")]
			get {
				const string __id = "isBoolean.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/method[@name='isNumber' and count(parameter)=0]"
			[Register ("isNumber", "()Z", "")]
			get {
				const string __id = "isNumber.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/method[@name='isString' and count(parameter)=0]"
			[Register ("isString", "()Z", "")]
			get {
				const string __id = "isString.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
