using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/interface[@name='IOnPushListener']"
	[Register ("com/aliyun/alink/linksdk/channel/core/persistent/event/IOnPushListener", "", "Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListenerInvoker")]
	public partial interface IOnPushListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/interface[@name='IOnPushListener']/method[@name='onCommand' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("onCommand", "(Ljava/lang/String;[B)V", "GetOnCommand_Ljava_lang_String_arrayBHandler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListenerInvoker, PublicChannelCoreBinding")]
		void OnCommand (string p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/interface[@name='IOnPushListener']/method[@name='shouldHandle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("shouldHandle", "(Ljava/lang/String;)Z", "GetShouldHandle_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListenerInvoker, PublicChannelCoreBinding")]
		bool ShouldHandle (string p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/event/IOnPushListener", DoNotGenerateAcw=true)]
	internal partial class IOnPushListenerInvoker : global::Java.Lang.Object, IOnPushListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/event/IOnPushListener", typeof (IOnPushListenerInvoker));

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

		public static IOnPushListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnPushListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.core.persistent.event.IOnPushListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnPushListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCommand_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetOnCommand_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_onCommand_Ljava_lang_String_arrayB == null)
				cb_onCommand_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCommand_Ljava_lang_String_arrayB);
			return cb_onCommand_Ljava_lang_String_arrayB;
		}

		static void n_OnCommand_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnCommand (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onCommand_Ljava_lang_String_arrayB;
		public unsafe void OnCommand (string p0, byte[] p1)
		{
			if (id_onCommand_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_onCommand_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "onCommand", "(Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCommand_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_shouldHandle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShouldHandle_Ljava_lang_String_Handler ()
		{
			if (cb_shouldHandle_Ljava_lang_String_ == null)
				cb_shouldHandle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ShouldHandle_Ljava_lang_String_);
			return cb_shouldHandle_Ljava_lang_String_;
		}

		static bool n_ShouldHandle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldHandle (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_shouldHandle_Ljava_lang_String_;
		public unsafe bool ShouldHandle (string p0)
		{
			if (id_shouldHandle_Ljava_lang_String_ == IntPtr.Zero)
				id_shouldHandle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "shouldHandle", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldHandle_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

	// event args for com.aliyun.alink.linksdk.channel.core.persistent.event.IOnPushListener.onCommand
	public partial class CommandEventArgs : global::System.EventArgs {

		public CommandEventArgs (string p0, byte[] p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		byte[] p1;
		public byte[] P1 {
			get { return p1; }
		}
	}

	// event args for com.aliyun.alink.linksdk.channel.core.persistent.event.IOnPushListener.shouldHandle
	public partial class ShouldHandleEventArgs : global::System.EventArgs {

		public ShouldHandleEventArgs (bool handled, string p0)
		{
			this.handled = handled;
			this.p0 = p0;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/channel/core/persistent/event/IOnPushListenerImplementor")]
	internal sealed partial class IOnPushListenerImplementor : global::Java.Lang.Object, IOnPushListener {

		object sender;

		public IOnPushListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/channel/core/persistent/event/IOnPushListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CommandEventArgs> OnCommandHandler;
#pragma warning restore 0649

		public void OnCommand (string p0, byte[] p1)
		{
			var __h = OnCommandHandler;
			if (__h != null)
				__h (sender, new CommandEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<ShouldHandleEventArgs> ShouldHandleHandler;
#pragma warning restore 0649

		public bool ShouldHandle (string p0)
		{
			var __h = ShouldHandleHandler;
			if (__h == null)
				return false;
			var __e = new ShouldHandleEventArgs (true, p0);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IOnPushListenerImplementor value)
		{
			return value.OnCommandHandler == null && value.ShouldHandleHandler == null;
		}
	}

}
