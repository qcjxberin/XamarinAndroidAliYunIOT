using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ResourceBundleCatalog']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/ResourceBundleCatalog", DoNotGenerateAcw=true)]
	public partial class ResourceBundleCatalog : global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MessageCatalog {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/ResourceBundleCatalog", typeof (ResourceBundleCatalog));
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

		protected ResourceBundleCatalog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ResourceBundleCatalog']/constructor[@name='ResourceBundleCatalog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResourceBundleCatalog ()
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

		static Delegate cb_getLocalizedMessage_I;
#pragma warning disable 0169
		static Delegate GetGetLocalizedMessage_IHandler ()
		{
			if (cb_getLocalizedMessage_I == null)
				cb_getLocalizedMessage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetLocalizedMessage_I);
			return cb_getLocalizedMessage_I;
		}

		static IntPtr n_GetLocalizedMessage_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ResourceBundleCatalog __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ResourceBundleCatalog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetLocalizedMessage (id));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ResourceBundleCatalog']/method[@name='getLocalizedMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLocalizedMessage", "(I)Ljava/lang/String;", "GetGetLocalizedMessage_IHandler")]
		protected override unsafe string GetLocalizedMessage (int id)
		{
			const string __id = "getLocalizedMessage.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
