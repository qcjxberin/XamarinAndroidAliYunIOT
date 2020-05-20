using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttPersistable']"
	[Register ("org/eclipse/paho/client/mqttv3/MqttPersistable", "", "Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistableInvoker")]
	public partial interface IMqttPersistable : IJavaObject, IJavaPeerable {

		int HeaderLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttPersistable']/method[@name='getHeaderLength' and count(parameter)=0]"
			[Register ("getHeaderLength", "()I", "GetGetHeaderLengthHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistableInvoker, OpenSourcePahoBinding")] get;
		}

		int HeaderOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttPersistable']/method[@name='getHeaderOffset' and count(parameter)=0]"
			[Register ("getHeaderOffset", "()I", "GetGetHeaderOffsetHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistableInvoker, OpenSourcePahoBinding")] get;
		}

		int PayloadLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttPersistable']/method[@name='getPayloadLength' and count(parameter)=0]"
			[Register ("getPayloadLength", "()I", "GetGetPayloadLengthHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistableInvoker, OpenSourcePahoBinding")] get;
		}

		int PayloadOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttPersistable']/method[@name='getPayloadOffset' and count(parameter)=0]"
			[Register ("getPayloadOffset", "()I", "GetGetPayloadOffsetHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistableInvoker, OpenSourcePahoBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttPersistable']/method[@name='getHeaderBytes' and count(parameter)=0]"
		[Register ("getHeaderBytes", "()[B", "GetGetHeaderBytesHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistableInvoker, OpenSourcePahoBinding")]
		byte[] GetHeaderBytes ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttPersistable']/method[@name='getPayloadBytes' and count(parameter)=0]"
		[Register ("getPayloadBytes", "()[B", "GetGetPayloadBytesHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistableInvoker, OpenSourcePahoBinding")]
		byte[] GetPayloadBytes ();

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttPersistable", DoNotGenerateAcw=true)]
	internal partial class IMqttPersistableInvoker : global::Java.Lang.Object, IMqttPersistable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttPersistable", typeof (IMqttPersistableInvoker));

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

		public static IMqttPersistable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMqttPersistable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.MqttPersistable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMqttPersistableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getHeaderLength;
#pragma warning disable 0169
		static Delegate GetGetHeaderLengthHandler ()
		{
			if (cb_getHeaderLength == null)
				cb_getHeaderLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderLength);
			return cb_getHeaderLength;
		}

		static int n_GetHeaderLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderLength;
		}
#pragma warning restore 0169

		IntPtr id_getHeaderLength;
		public unsafe int HeaderLength {
			get {
				if (id_getHeaderLength == IntPtr.Zero)
					id_getHeaderLength = JNIEnv.GetMethodID (class_ref, "getHeaderLength", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderLength);
			}
		}

		static Delegate cb_getHeaderOffset;
#pragma warning disable 0169
		static Delegate GetGetHeaderOffsetHandler ()
		{
			if (cb_getHeaderOffset == null)
				cb_getHeaderOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderOffset);
			return cb_getHeaderOffset;
		}

		static int n_GetHeaderOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderOffset;
		}
#pragma warning restore 0169

		IntPtr id_getHeaderOffset;
		public unsafe int HeaderOffset {
			get {
				if (id_getHeaderOffset == IntPtr.Zero)
					id_getHeaderOffset = JNIEnv.GetMethodID (class_ref, "getHeaderOffset", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderOffset);
			}
		}

		static Delegate cb_getPayloadLength;
#pragma warning disable 0169
		static Delegate GetGetPayloadLengthHandler ()
		{
			if (cb_getPayloadLength == null)
				cb_getPayloadLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPayloadLength);
			return cb_getPayloadLength;
		}

		static int n_GetPayloadLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PayloadLength;
		}
#pragma warning restore 0169

		IntPtr id_getPayloadLength;
		public unsafe int PayloadLength {
			get {
				if (id_getPayloadLength == IntPtr.Zero)
					id_getPayloadLength = JNIEnv.GetMethodID (class_ref, "getPayloadLength", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPayloadLength);
			}
		}

		static Delegate cb_getPayloadOffset;
#pragma warning disable 0169
		static Delegate GetGetPayloadOffsetHandler ()
		{
			if (cb_getPayloadOffset == null)
				cb_getPayloadOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPayloadOffset);
			return cb_getPayloadOffset;
		}

		static int n_GetPayloadOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PayloadOffset;
		}
#pragma warning restore 0169

		IntPtr id_getPayloadOffset;
		public unsafe int PayloadOffset {
			get {
				if (id_getPayloadOffset == IntPtr.Zero)
					id_getPayloadOffset = JNIEnv.GetMethodID (class_ref, "getPayloadOffset", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPayloadOffset);
			}
		}

		static Delegate cb_getHeaderBytes;
#pragma warning disable 0169
		static Delegate GetGetHeaderBytesHandler ()
		{
			if (cb_getHeaderBytes == null)
				cb_getHeaderBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaderBytes);
			return cb_getHeaderBytes;
		}

		static IntPtr n_GetHeaderBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHeaderBytes ());
		}
#pragma warning restore 0169

		IntPtr id_getHeaderBytes;
		public unsafe byte[] GetHeaderBytes ()
		{
			if (id_getHeaderBytes == IntPtr.Zero)
				id_getHeaderBytes = JNIEnv.GetMethodID (class_ref, "getHeaderBytes", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getPayloadBytes;
#pragma warning disable 0169
		static Delegate GetGetPayloadBytesHandler ()
		{
			if (cb_getPayloadBytes == null)
				cb_getPayloadBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPayloadBytes);
			return cb_getPayloadBytes;
		}

		static IntPtr n_GetPayloadBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayloadBytes ());
		}
#pragma warning restore 0169

		IntPtr id_getPayloadBytes;
		public unsafe byte[] GetPayloadBytes ()
		{
			if (id_getPayloadBytes == IntPtr.Zero)
				id_getPayloadBytes = JNIEnv.GetMethodID (class_ref, "getPayloadBytes", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPayloadBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

	}

}
