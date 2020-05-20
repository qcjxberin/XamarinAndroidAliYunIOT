using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Controller {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.controller']/interface[@name='ControllerViewportVisibilityListener']"
	[Register ("com/facebook/drawee/controller/ControllerViewportVisibilityListener", "", "Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListenerInvoker")]
	public partial interface IControllerViewportVisibilityListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/interface[@name='ControllerViewportVisibilityListener']/method[@name='onDraweeViewportEntry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onDraweeViewportEntry", "(Ljava/lang/String;)V", "GetOnDraweeViewportEntry_Ljava_lang_String_Handler:Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListenerInvoker, DraweeBinding")]
		void OnDraweeViewportEntry (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/interface[@name='ControllerViewportVisibilityListener']/method[@name='onDraweeViewportExit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onDraweeViewportExit", "(Ljava/lang/String;)V", "GetOnDraweeViewportExit_Ljava_lang_String_Handler:Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListenerInvoker, DraweeBinding")]
		void OnDraweeViewportExit (string p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/controller/ControllerViewportVisibilityListener", DoNotGenerateAcw=true)]
	internal partial class IControllerViewportVisibilityListenerInvoker : global::Java.Lang.Object, IControllerViewportVisibilityListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/controller/ControllerViewportVisibilityListener", typeof (IControllerViewportVisibilityListenerInvoker));

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

		public static IControllerViewportVisibilityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IControllerViewportVisibilityListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.controller.ControllerViewportVisibilityListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IControllerViewportVisibilityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDraweeViewportEntry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDraweeViewportEntry_Ljava_lang_String_Handler ()
		{
			if (cb_onDraweeViewportEntry_Ljava_lang_String_ == null)
				cb_onDraweeViewportEntry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDraweeViewportEntry_Ljava_lang_String_);
			return cb_onDraweeViewportEntry_Ljava_lang_String_;
		}

		static void n_OnDraweeViewportEntry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDraweeViewportEntry (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDraweeViewportEntry_Ljava_lang_String_;
		public unsafe void OnDraweeViewportEntry (string p0)
		{
			if (id_onDraweeViewportEntry_Ljava_lang_String_ == IntPtr.Zero)
				id_onDraweeViewportEntry_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDraweeViewportEntry", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDraweeViewportEntry_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDraweeViewportExit_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDraweeViewportExit_Ljava_lang_String_Handler ()
		{
			if (cb_onDraweeViewportExit_Ljava_lang_String_ == null)
				cb_onDraweeViewportExit_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDraweeViewportExit_Ljava_lang_String_);
			return cb_onDraweeViewportExit_Ljava_lang_String_;
		}

		static void n_OnDraweeViewportExit_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDraweeViewportExit (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDraweeViewportExit_Ljava_lang_String_;
		public unsafe void OnDraweeViewportExit (string p0)
		{
			if (id_onDraweeViewportExit_Ljava_lang_String_ == IntPtr.Zero)
				id_onDraweeViewportExit_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDraweeViewportExit", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDraweeViewportExit_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.facebook.drawee.controller.ControllerViewportVisibilityListener.onDraweeViewportEntry
	public partial class DraweeViewportEntryEventArgs : global::System.EventArgs {

		public DraweeViewportEntryEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	// event args for com.facebook.drawee.controller.ControllerViewportVisibilityListener.onDraweeViewportExit
	public partial class DraweeViewportExitEventArgs : global::System.EventArgs {

		public DraweeViewportExitEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/facebook/drawee/controller/ControllerViewportVisibilityListenerImplementor")]
	internal sealed partial class IControllerViewportVisibilityListenerImplementor : global::Java.Lang.Object, IControllerViewportVisibilityListener {

		object sender;

		public IControllerViewportVisibilityListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/drawee/controller/ControllerViewportVisibilityListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DraweeViewportEntryEventArgs> OnDraweeViewportEntryHandler;
#pragma warning restore 0649

		public void OnDraweeViewportEntry (string p0)
		{
			var __h = OnDraweeViewportEntryHandler;
			if (__h != null)
				__h (sender, new DraweeViewportEntryEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<DraweeViewportExitEventArgs> OnDraweeViewportExitHandler;
#pragma warning restore 0649

		public void OnDraweeViewportExit (string p0)
		{
			var __h = OnDraweeViewportExitHandler;
			if (__h != null)
				__h (sender, new DraweeViewportExitEventArgs (p0));
		}

		internal static bool __IsEmpty (IControllerViewportVisibilityListenerImplementor value)
		{
			return value.OnDraweeViewportEntryHandler == null && value.OnDraweeViewportExitHandler == null;
		}
	}

}
