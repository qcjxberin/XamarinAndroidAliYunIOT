using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Log {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/interface[@name='ILogUpload']"
	[Register ("com/aliyun/alink/linksdk/tools/log/ILogUpload", "", "Com.Aliyun.Alink.Linksdk.Tools.Log.ILogUploadInvoker")]
	public partial interface ILogUpload : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/interface[@name='ILogUpload']/method[@name='fileUpload' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("fileUpload", "(Ljava/lang/String;Ljava/lang/String;)V", "GetFileUpload_Ljava_lang_String_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Tools.Log.ILogUploadInvoker, ToolsBinding")]
		void FileUpload (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/interface[@name='ILogUpload']/method[@name='realTimeUpload' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("realTimeUpload", "(ILjava/lang/String;Ljava/lang/String;)V", "GetRealTimeUpload_ILjava_lang_String_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Tools.Log.ILogUploadInvoker, ToolsBinding")]
		void RealTimeUpload (int p0, string p1, string p2);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/log/ILogUpload", DoNotGenerateAcw=true)]
	internal partial class ILogUploadInvoker : global::Java.Lang.Object, ILogUpload {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/log/ILogUpload", typeof (ILogUploadInvoker));

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

		public static ILogUpload GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogUpload> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.tools.log.ILogUpload"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILogUploadInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_fileUpload_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFileUpload_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_fileUpload_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_fileUpload_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_FileUpload_Ljava_lang_String_Ljava_lang_String_);
			return cb_fileUpload_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_FileUpload_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogUpload __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogUpload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.FileUpload (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_fileUpload_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void FileUpload (string p0, string p1)
		{
			if (id_fileUpload_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_fileUpload_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "fileUpload", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fileUpload_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_realTimeUpload_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRealTimeUpload_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_realTimeUpload_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_realTimeUpload_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_RealTimeUpload_ILjava_lang_String_Ljava_lang_String_);
			return cb_realTimeUpload_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_RealTimeUpload_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogUpload __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogUpload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RealTimeUpload (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_realTimeUpload_ILjava_lang_String_Ljava_lang_String_;
		public unsafe void RealTimeUpload (int p0, string p1, string p2)
		{
			if (id_realTimeUpload_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_realTimeUpload_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "realTimeUpload", "(ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_realTimeUpload_ILjava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

}
