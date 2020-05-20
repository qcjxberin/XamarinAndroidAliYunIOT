using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine {

	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/jsengine/IJSEngine", DoNotGenerateAcw=true)]
	public abstract class JSEngine : Java.Lang.Object {

		internal JSEngine ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.jsengine']/interface[@name='IJSEngine']/field[@name='PROTOCAL_TO_RAWDATA_FUNCNAME']"
		[Register ("PROTOCAL_TO_RAWDATA_FUNCNAME")]
		public const string ProtocalToRawdataFuncname = (string) "protocolToRawData";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.jsengine']/interface[@name='IJSEngine']/field[@name='RAWDATA_TO_PROTOCAL_FUNCNAME']"
		[Register ("RAWDATA_TO_PROTOCAL_FUNCNAME")]
		public const string RawdataToProtocalFuncname = (string) "rawDataToProtocol";
	}

	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/jsengine/IJSEngine", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'JSEngine' type. This type will be removed in a future release.", error: true)]
	public abstract class JSEngineConsts : JSEngine {

		private JSEngineConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.jsengine']/interface[@name='IJSEngine']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/jsengine/IJSEngine", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngineInvoker")]
	public partial interface IJSEngine : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.jsengine']/interface[@name='IJSEngine']/method[@name='protocolToRawData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("protocolToRawData", "(Ljava/lang/String;Ljava/lang/String;)[B", "GetProtocolToRawData_Ljava_lang_String_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngineInvoker, AndroidAlcsLpbsBinding")]
		byte[] ProtocolToRawData (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.jsengine']/interface[@name='IJSEngine']/method[@name='rawDataToProtocol' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("rawDataToProtocol", "(Ljava/lang/String;[B)Ljava/lang/String;", "GetRawDataToProtocol_Ljava_lang_String_arrayBHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngineInvoker, AndroidAlcsLpbsBinding")]
		string RawDataToProtocol (string p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/jsengine/IJSEngine", DoNotGenerateAcw=true)]
	internal partial class IJSEngineInvoker : global::Java.Lang.Object, IJSEngine {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/component/jsengine/IJSEngine", typeof (IJSEngineInvoker));

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

		public static IJSEngine GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJSEngine> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.component.jsengine.IJSEngine"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJSEngineInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_protocolToRawData_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProtocolToRawData_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_protocolToRawData_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_protocolToRawData_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ProtocolToRawData_Ljava_lang_String_Ljava_lang_String_);
			return cb_protocolToRawData_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ProtocolToRawData_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngine __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ProtocolToRawData (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_protocolToRawData_Ljava_lang_String_Ljava_lang_String_;
		public unsafe byte[] ProtocolToRawData (string p0, string p1)
		{
			if (id_protocolToRawData_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_protocolToRawData_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "protocolToRawData", "(Ljava/lang/String;Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_protocolToRawData_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_rawDataToProtocol_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetRawDataToProtocol_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_rawDataToProtocol_Ljava_lang_String_arrayB == null)
				cb_rawDataToProtocol_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RawDataToProtocol_Ljava_lang_String_arrayB);
			return cb_rawDataToProtocol_Ljava_lang_String_arrayB;
		}

		static IntPtr n_RawDataToProtocol_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngine __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.RawDataToProtocol (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rawDataToProtocol_Ljava_lang_String_arrayB;
		public unsafe string RawDataToProtocol (string p0, byte[] p1)
		{
			if (id_rawDataToProtocol_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_rawDataToProtocol_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "rawDataToProtocol", "(Ljava/lang/String;[B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rawDataToProtocol_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

	}

}
