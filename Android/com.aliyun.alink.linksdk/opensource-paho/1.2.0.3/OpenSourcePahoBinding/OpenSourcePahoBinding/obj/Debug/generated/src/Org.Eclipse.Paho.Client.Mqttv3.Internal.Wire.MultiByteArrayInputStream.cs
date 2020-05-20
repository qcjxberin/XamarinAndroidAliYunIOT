using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteArrayInputStream']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MultiByteArrayInputStream", DoNotGenerateAcw=true)]
	public partial class MultiByteArrayInputStream : global::Java.IO.InputStream {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/MultiByteArrayInputStream", typeof (MultiByteArrayInputStream));
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

		protected MultiByteArrayInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteArrayInputStream']/constructor[@name='MultiByteArrayInputStream' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register (".ctor", "([BII[BII)V", "")]
		public unsafe MultiByteArrayInputStream (byte[] bytesA, int offsetA, int lengthA, byte[] bytesB, int offsetB, int lengthB)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BII[BII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bytesA = JNIEnv.NewArray (bytesA);
			IntPtr native_bytesB = JNIEnv.NewArray (bytesB);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_bytesA);
				__args [1] = new JniArgumentValue (offsetA);
				__args [2] = new JniArgumentValue (lengthA);
				__args [3] = new JniArgumentValue (native_bytesB);
				__args [4] = new JniArgumentValue (offsetB);
				__args [5] = new JniArgumentValue (lengthB);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (bytesA != null) {
					JNIEnv.CopyArray (native_bytesA, bytesA);
					JNIEnv.DeleteLocalRef (native_bytesA);
				}
				if (bytesB != null) {
					JNIEnv.CopyArray (native_bytesB, bytesB);
					JNIEnv.DeleteLocalRef (native_bytesB);
				}
			}
		}

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read);
			return cb_read;
		}

		static int n_Read (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteArrayInputStream __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteArrayInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteArrayInputStream']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()I", "GetReadHandler")]
		public override unsafe int Read ()
		{
			const string __id = "read.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
