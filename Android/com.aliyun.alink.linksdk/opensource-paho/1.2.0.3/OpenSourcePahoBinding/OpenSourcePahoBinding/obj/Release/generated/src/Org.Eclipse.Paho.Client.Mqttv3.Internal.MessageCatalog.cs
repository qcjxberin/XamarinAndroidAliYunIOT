using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MessageCatalog']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/MessageCatalog", DoNotGenerateAcw=true)]
	public abstract partial class MessageCatalog : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/MessageCatalog", typeof (MessageCatalog));
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

		protected MessageCatalog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MessageCatalog']/constructor[@name='MessageCatalog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageCatalog ()
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

		static IntPtr n_GetLocalizedMessage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MessageCatalog __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MessageCatalog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetLocalizedMessage (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MessageCatalog']/method[@name='getLocalizedMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLocalizedMessage", "(I)Ljava/lang/String;", "GetGetLocalizedMessage_IHandler")]
		protected abstract string GetLocalizedMessage (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MessageCatalog']/method[@name='getMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMessage", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetMessage (int id)
		{
			const string __id = "getMessage.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/MessageCatalog", DoNotGenerateAcw=true)]
	internal partial class MessageCatalogInvoker : MessageCatalog {

		public MessageCatalogInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/MessageCatalog", typeof (MessageCatalogInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MessageCatalog']/method[@name='getLocalizedMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLocalizedMessage", "(I)Ljava/lang/String;", "GetGetLocalizedMessage_IHandler")]
		protected override unsafe string GetLocalizedMessage (int p0)
		{
			const string __id = "getLocalizedMessage.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
