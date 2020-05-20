using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteInteger']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MultiByteInteger", DoNotGenerateAcw=true)]
	public partial class MultiByteInteger : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/MultiByteInteger", typeof (MultiByteInteger));
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

		protected MultiByteInteger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteInteger']/constructor[@name='MultiByteInteger' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe MultiByteInteger (long value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteInteger']/constructor[@name='MultiByteInteger' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register (".ctor", "(JI)V", "")]
		public unsafe MultiByteInteger (long value, int length)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue (length);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getEncodedLength;
#pragma warning disable 0169
		static Delegate GetGetEncodedLengthHandler ()
		{
			if (cb_getEncodedLength == null)
				cb_getEncodedLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEncodedLength);
			return cb_getEncodedLength;
		}

		static int n_GetEncodedLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EncodedLength;
		}
#pragma warning restore 0169

		public virtual unsafe int EncodedLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteInteger']/method[@name='getEncodedLength' and count(parameter)=0]"
			[Register ("getEncodedLength", "()I", "GetGetEncodedLengthHandler")]
			get {
				const string __id = "getEncodedLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetValue);
			return cb_getValue;
		}

		static long n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Value;
		}
#pragma warning restore 0169

		public virtual unsafe long Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteInteger']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()J", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
