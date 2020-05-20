using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/interface[@name='DestinationProvider']"
	[Register ("org/eclipse/paho/client/mqttv3/internal/DestinationProvider", "", "Org.Eclipse.Paho.Client.Mqttv3.Internal.IDestinationProviderInvoker")]
	public partial interface IDestinationProvider : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/interface[@name='DestinationProvider']/method[@name='getTopic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTopic", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttTopic;", "GetGetTopic_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.Internal.IDestinationProviderInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic GetTopic (string p0);

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/DestinationProvider", DoNotGenerateAcw=true)]
	internal partial class IDestinationProviderInvoker : global::Java.Lang.Object, IDestinationProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/DestinationProvider", typeof (IDestinationProviderInvoker));

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

		public static IDestinationProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDestinationProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.internal.DestinationProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDestinationProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getTopic_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTopic_Ljava_lang_String_Handler ()
		{
			if (cb_getTopic_Ljava_lang_String_ == null)
				cb_getTopic_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTopic_Ljava_lang_String_);
			return cb_getTopic_Ljava_lang_String_;
		}

		static IntPtr n_GetTopic_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDestinationProvider __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDestinationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTopic (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getTopic_Ljava_lang_String_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic GetTopic (string p0)
		{
			if (id_getTopic_Ljava_lang_String_ == IntPtr.Zero)
				id_getTopic_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTopic", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttTopic;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTopic_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
