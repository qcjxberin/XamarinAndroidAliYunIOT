using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Tracker {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/interface[@name='ISDKTracker']"
	[Register ("com/aliyun/alink/linksdk/tools/tracker/ISDKTracker", "", "Com.Aliyun.Alink.Linksdk.Tools.Tracker.ISDKTrackerInvoker")]
	public partial interface ISDKTracker : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/interface[@name='ISDKTracker']/method[@name='sendEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("sendEvent", "(Ljava/lang/String;Ljava/util/Map;)V", "GetSendEvent_Ljava_lang_String_Ljava_util_Map_Handler:Com.Aliyun.Alink.Linksdk.Tools.Tracker.ISDKTrackerInvoker, ToolsBinding")]
		void SendEvent (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/tracker/ISDKTracker", DoNotGenerateAcw=true)]
	internal partial class ISDKTrackerInvoker : global::Java.Lang.Object, ISDKTracker {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/tracker/ISDKTracker", typeof (ISDKTrackerInvoker));

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

		public static ISDKTracker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISDKTracker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.tools.tracker.ISDKTracker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISDKTrackerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_sendEvent_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendEvent_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_sendEvent_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_sendEvent_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendEvent_Ljava_lang_String_Ljava_util_Map_);
			return cb_sendEvent_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_SendEvent_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.ISDKTracker __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.ISDKTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendEvent (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendEvent_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void SendEvent (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_sendEvent_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_sendEvent_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendEvent", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendEvent_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
