using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='CountingInputStream']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/CountingInputStream", DoNotGenerateAcw=true)]
	public partial class CountingInputStream : global::Java.IO.InputStream {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/CountingInputStream", typeof (CountingInputStream));
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

		protected CountingInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='CountingInputStream']/constructor[@name='CountingInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe CountingInputStream (global::System.IO.Stream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		static Delegate cb_getCounter;
#pragma warning disable 0169
		static Delegate GetGetCounterHandler ()
		{
			if (cb_getCounter == null)
				cb_getCounter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCounter);
			return cb_getCounter;
		}

		static int n_GetCounter (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.CountingInputStream __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.CountingInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Counter;
		}
#pragma warning restore 0169

		public virtual unsafe int Counter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='CountingInputStream']/method[@name='getCounter' and count(parameter)=0]"
			[Register ("getCounter", "()I", "GetGetCounterHandler")]
			get {
				const string __id = "getCounter.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.CountingInputStream __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.CountingInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='CountingInputStream']/method[@name='read' and count(parameter)=0]"
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

		static Delegate cb_resetCounter;
#pragma warning disable 0169
		static Delegate GetResetCounterHandler ()
		{
			if (cb_resetCounter == null)
				cb_resetCounter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetCounter);
			return cb_resetCounter;
		}

		static void n_ResetCounter (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.CountingInputStream __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.CountingInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetCounter ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='CountingInputStream']/method[@name='resetCounter' and count(parameter)=0]"
		[Register ("resetCounter", "()V", "GetResetCounterHandler")]
		public virtual unsafe void ResetCounter ()
		{
			const string __id = "resetCounter.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
