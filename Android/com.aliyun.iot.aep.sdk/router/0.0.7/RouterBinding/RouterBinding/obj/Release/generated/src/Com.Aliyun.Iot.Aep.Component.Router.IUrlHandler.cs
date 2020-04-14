using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Component.Router {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/interface[@name='IUrlHandler']"
	[Register ("com/aliyun/iot/aep/component/router/IUrlHandler", "", "Com.Aliyun.Iot.Aep.Component.Router.IUrlHandlerInvoker")]
	public partial interface IUrlHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/interface[@name='IUrlHandler']/method[@name='onUrlHandle' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='boolean'] and parameter[5][@type='int']]"
		[Register ("onUrlHandle", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ZI)V", "GetOnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZIHandler:Com.Aliyun.Iot.Aep.Component.Router.IUrlHandlerInvoker, RouterBinding")]
		void OnUrlHandle (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2, bool p3, int p4);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/component/router/IUrlHandler", DoNotGenerateAcw=true)]
	internal partial class IUrlHandlerInvoker : global::Java.Lang.Object, IUrlHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/component/router/IUrlHandler", typeof (IUrlHandlerInvoker));

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

		public static IUrlHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUrlHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.component.router.IUrlHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUrlHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI;
#pragma warning disable 0169
		static Delegate GetOnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZIHandler ()
		{
			if (cb_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI == null)
				cb_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, int>) n_OnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI);
			return cb_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI;
		}

		static void n_OnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3, int p4)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnUrlHandle (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI;
		public unsafe void OnUrlHandle (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2, bool p3, int p4)
		{
			if (id_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI == IntPtr.Zero)
				id_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI = JNIEnv.GetMethodID (class_ref, "onUrlHandle", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ZI)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
