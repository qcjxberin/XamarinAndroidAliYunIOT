using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/interface[@name='IHeartBeatHandler']"
	[Register ("com/aliyun/alink/linksdk/alcs/api/client/IHeartBeatHandler", "", "Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandlerInvoker")]
	public partial interface IHeartBeatHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/interface[@name='IHeartBeatHandler']/method[@name='onBeat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onBeat", "(Ljava/lang/String;I)V", "GetOnBeat_Ljava_lang_String_IHandler:Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandlerInvoker, CoapSdkBinding")]
		void OnBeat (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/interface[@name='IHeartBeatHandler']/method[@name='onTimeout' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onTimeout", "(Ljava/lang/String;I)V", "GetOnTimeout_Ljava_lang_String_IHandler:Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandlerInvoker, CoapSdkBinding")]
		void OnTimeout (string p0, int p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/client/IHeartBeatHandler", DoNotGenerateAcw=true)]
	internal partial class IHeartBeatHandlerInvoker : global::Java.Lang.Object, IHeartBeatHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/client/IHeartBeatHandler", typeof (IHeartBeatHandlerInvoker));

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

		public static IHeartBeatHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHeartBeatHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.api.client.IHeartBeatHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHeartBeatHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBeat_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnBeat_Ljava_lang_String_IHandler ()
		{
			if (cb_onBeat_Ljava_lang_String_I == null)
				cb_onBeat_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBeat_Ljava_lang_String_I);
			return cb_onBeat_Ljava_lang_String_I;
		}

		static void n_OnBeat_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBeat (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onBeat_Ljava_lang_String_I;
		public unsafe void OnBeat (string p0, int p1)
		{
			if (id_onBeat_Ljava_lang_String_I == IntPtr.Zero)
				id_onBeat_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onBeat", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBeat_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onTimeout_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnTimeout_Ljava_lang_String_IHandler ()
		{
			if (cb_onTimeout_Ljava_lang_String_I == null)
				cb_onTimeout_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnTimeout_Ljava_lang_String_I);
			return cb_onTimeout_Ljava_lang_String_I;
		}

		static void n_OnTimeout_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTimeout (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onTimeout_Ljava_lang_String_I;
		public unsafe void OnTimeout (string p0, int p1)
		{
			if (id_onTimeout_Ljava_lang_String_I == IntPtr.Zero)
				id_onTimeout_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onTimeout", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTimeout_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
