using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']"
	[Register ("com/facebook/drawee/interfaces/SimpleDraweeControllerBuilder", "", "Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilderInvoker")]
	public partial interface ISimpleDraweeControllerBuilder : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/facebook/drawee/interfaces/DraweeController;", "GetBuildHandler:Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilderInvoker, DraweeBinding")]
		global::Com.Facebook.Drawee.Interfaces.IDraweeController Build ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='setCallerContext' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setCallerContext", "(Ljava/lang/Object;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;", "GetSetCallerContext_Ljava_lang_Object_Handler:Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilderInvoker, DraweeBinding")]
		global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetCallerContext (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='setOldController' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController']]"
		[Register ("setOldController", "(Lcom/facebook/drawee/interfaces/DraweeController;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;", "GetSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_Handler:Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilderInvoker, DraweeBinding")]
		global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetOldController (global::Com.Facebook.Drawee.Interfaces.IDraweeController p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("setUri", "(Landroid/net/Uri;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;", "GetSetUri_Landroid_net_Uri_Handler:Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilderInvoker, DraweeBinding")]
		global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetUri (global::Android.Net.Uri p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUri", "(Ljava/lang/String;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;", "GetSetUri_Ljava_lang_String_Handler:Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilderInvoker, DraweeBinding")]
		global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetUri (string p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/interfaces/SimpleDraweeControllerBuilder", DoNotGenerateAcw=true)]
	internal partial class ISimpleDraweeControllerBuilderInvoker : global::Java.Lang.Object, ISimpleDraweeControllerBuilder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/interfaces/SimpleDraweeControllerBuilder", typeof (ISimpleDraweeControllerBuilderInvoker));

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

		public static ISimpleDraweeControllerBuilder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISimpleDraweeControllerBuilder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.interfaces.SimpleDraweeControllerBuilder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISimpleDraweeControllerBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		IntPtr id_build;
		public unsafe global::Com.Facebook.Drawee.Interfaces.IDraweeController Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/facebook/drawee/interfaces/DraweeController;");
			return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setCallerContext_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetCallerContext_Ljava_lang_Object_Handler ()
		{
			if (cb_setCallerContext_Ljava_lang_Object_ == null)
				cb_setCallerContext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCallerContext_Ljava_lang_Object_);
			return cb_setCallerContext_Ljava_lang_Object_;
		}

		static IntPtr n_SetCallerContext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCallerContext (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setCallerContext_Ljava_lang_Object_;
		public unsafe global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetCallerContext (global::Java.Lang.Object p0)
		{
			if (id_setCallerContext_Ljava_lang_Object_ == IntPtr.Zero)
				id_setCallerContext_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setCallerContext", "(Ljava/lang/Object;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCallerContext_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setOldController_Lcom_facebook_drawee_interfaces_DraweeController_;
#pragma warning disable 0169
		static Delegate GetSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_Handler ()
		{
			if (cb_setOldController_Lcom_facebook_drawee_interfaces_DraweeController_ == null)
				cb_setOldController_Lcom_facebook_drawee_interfaces_DraweeController_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOldController_Lcom_facebook_drawee_interfaces_DraweeController_);
			return cb_setOldController_Lcom_facebook_drawee_interfaces_DraweeController_;
		}

		static IntPtr n_SetOldController_Lcom_facebook_drawee_interfaces_DraweeController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController p0 = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOldController (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setOldController_Lcom_facebook_drawee_interfaces_DraweeController_;
		public unsafe global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetOldController (global::Com.Facebook.Drawee.Interfaces.IDraweeController p0)
		{
			if (id_setOldController_Lcom_facebook_drawee_interfaces_DraweeController_ == IntPtr.Zero)
				id_setOldController_Lcom_facebook_drawee_interfaces_DraweeController_ = JNIEnv.GetMethodID (class_ref, "setOldController", "(Lcom/facebook/drawee/interfaces/DraweeController;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOldController_Lcom_facebook_drawee_interfaces_DraweeController_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setUri_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetUri_Landroid_net_Uri_Handler ()
		{
			if (cb_setUri_Landroid_net_Uri_ == null)
				cb_setUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUri_Landroid_net_Uri_);
			return cb_setUri_Landroid_net_Uri_;
		}

		static IntPtr n_SetUri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setUri_Landroid_net_Uri_;
		public unsafe global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetUri (global::Android.Net.Uri p0)
		{
			if (id_setUri_Landroid_net_Uri_ == IntPtr.Zero)
				id_setUri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setUri", "(Landroid/net/Uri;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUri_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUri_Ljava_lang_String_Handler ()
		{
			if (cb_setUri_Ljava_lang_String_ == null)
				cb_setUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUri_Ljava_lang_String_);
			return cb_setUri_Ljava_lang_String_;
		}

		static IntPtr n_SetUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setUri_Ljava_lang_String_;
		public unsafe global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetUri (string p0)
		{
			if (id_setUri_Ljava_lang_String_ == IntPtr.Zero)
				id_setUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUri", "(Ljava/lang/String;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
