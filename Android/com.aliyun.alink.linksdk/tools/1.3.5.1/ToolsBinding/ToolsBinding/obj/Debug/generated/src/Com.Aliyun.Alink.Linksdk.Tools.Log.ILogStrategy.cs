using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Log {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/interface[@name='ILogStrategy']"
	[Register ("com/aliyun/alink/linksdk/tools/log/ILogStrategy", "", "Com.Aliyun.Alink.Linksdk.Tools.Log.ILogStrategyInvoker")]
	public partial interface ILogStrategy : IJavaObject, IJavaPeerable {

		bool IsSupport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/interface[@name='ILogStrategy']/method[@name='isSupport' and count(parameter)=0]"
			[Register ("isSupport", "()Z", "GetIsSupportHandler:Com.Aliyun.Alink.Linksdk.Tools.Log.ILogStrategyInvoker, ToolsBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/interface[@name='ILogStrategy']/method[@name='log' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("log", "(ILjava/lang/String;Ljava/lang/String;)V", "GetLog_ILjava_lang_String_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Tools.Log.ILogStrategyInvoker, ToolsBinding")]
		void Log (int p0, string p1, string p2);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/log/ILogStrategy", DoNotGenerateAcw=true)]
	internal partial class ILogStrategyInvoker : global::Java.Lang.Object, ILogStrategy {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/log/ILogStrategy", typeof (ILogStrategyInvoker));

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

		public static ILogStrategy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogStrategy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.tools.log.ILogStrategy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILogStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isSupport;
#pragma warning disable 0169
		static Delegate GetIsSupportHandler ()
		{
			if (cb_isSupport == null)
				cb_isSupport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupport);
			return cb_isSupport;
		}

		static bool n_IsSupport (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupport;
		}
#pragma warning restore 0169

		IntPtr id_isSupport;
		public unsafe bool IsSupport {
			get {
				if (id_isSupport == IntPtr.Zero)
					id_isSupport = JNIEnv.GetMethodID (class_ref, "isSupport", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupport);
			}
		}

		static Delegate cb_log_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_log_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_log_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Log_ILjava_lang_String_Ljava_lang_String_);
			return cb_log_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_Log_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_log_ILjava_lang_String_Ljava_lang_String_;
		public unsafe void Log (int p0, string p1, string p2)
		{
			if (id_log_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_log_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "log", "(ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_ILjava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

}
