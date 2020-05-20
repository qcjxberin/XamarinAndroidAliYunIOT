using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/interface[@name='IDisconnectedBufferCallback']"
	[Register ("org/eclipse/paho/client/mqttv3/internal/IDisconnectedBufferCallback", "", "Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallbackInvoker")]
	public partial interface IDisconnectedBufferCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/interface[@name='IDisconnectedBufferCallback']/method[@name='publishBufferedMessage' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.BufferedMessage']]"
		[Register ("publishBufferedMessage", "(Lorg/eclipse/paho/client/mqttv3/BufferedMessage;)V", "GetPublishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_Handler:Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallbackInvoker, OpenSourcePahoBinding")]
		void PublishBufferedMessage (global::Org.Eclipse.Paho.Client.Mqttv3.BufferedMessage p0);

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/IDisconnectedBufferCallback", DoNotGenerateAcw=true)]
	internal partial class IDisconnectedBufferCallbackInvoker : global::Java.Lang.Object, IDisconnectedBufferCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/IDisconnectedBufferCallback", typeof (IDisconnectedBufferCallbackInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IDisconnectedBufferCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDisconnectedBufferCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.internal.IDisconnectedBufferCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDisconnectedBufferCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_publishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_;
#pragma warning disable 0169
		static Delegate GetPublishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_Handler ()
		{
			if (cb_publishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_ == null)
				cb_publishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PublishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_);
			return cb_publishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_;
		}

		static void n_PublishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.BufferedMessage p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.BufferedMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PublishBufferedMessage (p0);
		}
#pragma warning restore 0169

		IntPtr id_publishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_;
		public unsafe void PublishBufferedMessage (global::Org.Eclipse.Paho.Client.Mqttv3.BufferedMessage p0)
		{
			if (id_publishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_ == IntPtr.Zero)
				id_publishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_ = JNIEnv.GetMethodID (class_ref, "publishBufferedMessage", "(Lorg/eclipse/paho/client/mqttv3/BufferedMessage;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_publishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_, __args);
		}

	}

}
