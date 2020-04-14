using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Sdk.Tools {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/interface[@name='MonitorHandler']"
	[Register ("com/aliyun/iot/sdk/tools/MonitorHandler", "", "Com.Aliyun.Iot.Sdk.Tools.IMonitorHandlerInvoker")]
	public partial interface IMonitorHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/interface[@name='MonitorHandler']/method[@name='handle' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("handle", "(BLjava/lang/String;Ljava/util/Map;)V", "GetHandle_BLjava_lang_String_Ljava_util_Map_Handler:Com.Aliyun.Iot.Sdk.Tools.IMonitorHandlerInvoker, UserTrackerBinding")]
		void Handle (sbyte p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/interface[@name='MonitorHandler']/method[@name='support' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='java.lang.String']]"
		[Register ("support", "(BLjava/lang/String;)Z", "GetSupport_BLjava_lang_String_Handler:Com.Aliyun.Iot.Sdk.Tools.IMonitorHandlerInvoker, UserTrackerBinding")]
		bool Support (sbyte p0, string p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/sdk/tools/MonitorHandler", DoNotGenerateAcw=true)]
	internal partial class IMonitorHandlerInvoker : global::Java.Lang.Object, IMonitorHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/sdk/tools/MonitorHandler", typeof (IMonitorHandlerInvoker));

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

		public static IMonitorHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMonitorHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.sdk.tools.MonitorHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMonitorHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handle_BLjava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetHandle_BLjava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_handle_BLjava_lang_String_Ljava_util_Map_ == null)
				cb_handle_BLjava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, IntPtr, IntPtr>) n_Handle_BLjava_lang_String_Ljava_util_Map_);
			return cb_handle_BLjava_lang_String_Ljava_util_Map_;
		}

		static void n_Handle_BLjava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.IMonitorHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.IMonitorHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Handle (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_handle_BLjava_lang_String_Ljava_util_Map_;
		public unsafe void Handle (sbyte p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_handle_BLjava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_handle_BLjava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "handle", "(BLjava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handle_BLjava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_support_BLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSupport_BLjava_lang_String_Handler ()
		{
			if (cb_support_BLjava_lang_String_ == null)
				cb_support_BLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, IntPtr, bool>) n_Support_BLjava_lang_String_);
			return cb_support_BLjava_lang_String_;
		}

		static bool n_Support_BLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.IMonitorHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.IMonitorHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Support (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_support_BLjava_lang_String_;
		public unsafe bool Support (sbyte p0, string p1)
		{
			if (id_support_BLjava_lang_String_ == IntPtr.Zero)
				id_support_BLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "support", "(BLjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_support_BLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
