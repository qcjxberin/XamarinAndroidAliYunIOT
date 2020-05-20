using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Jsengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.jsengine']/class[@name='V8JsEngine']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/jsengine/V8JsEngine", DoNotGenerateAcw=true)]
	public partial class V8JsEngine : global::Java.Lang.Object, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngine {


		public static class InterfaceConsts {

			// The following are fields from: com.aliyun.alink.linksdk.alcs.lpbs.component.jsengine.IJSEngine

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.jsengine']/interface[@name='IJSEngine']/field[@name='PROTOCAL_TO_RAWDATA_FUNCNAME']"
			[Register ("PROTOCAL_TO_RAWDATA_FUNCNAME")]
			public const string ProtocalToRawdataFuncname = (string) "protocolToRawData";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.jsengine']/interface[@name='IJSEngine']/field[@name='RAWDATA_TO_PROTOCAL_FUNCNAME']"
			[Register ("RAWDATA_TO_PROTOCAL_FUNCNAME")]
			public const string RawdataToProtocalFuncname = (string) "rawDataToProtocol";
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/jsengine/V8JsEngine", typeof (V8JsEngine));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected V8JsEngine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.jsengine']/class[@name='V8JsEngine']/constructor[@name='V8JsEngine' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe V8JsEngine ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_callJsFunction_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCallJsFunction_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_callJsFunction_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_callJsFunction_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CallJsFunction_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_callJsFunction_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_CallJsFunction_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.V8JsEngine __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.V8JsEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CallJsFunction (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.jsengine']/class[@name='V8JsEngine']/method[@name='callJsFunction' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("callJsFunction", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "GetCallJsFunction_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object CallJsFunction (string p0, string p1, global::Java.Lang.Object[] p2)
		{
			const string __id = "callJsFunction.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.V8JsEngine __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.V8JsEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ProtocolToRawData (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.jsengine']/class[@name='V8JsEngine']/method[@name='protocolToRawData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("protocolToRawData", "(Ljava/lang/String;Ljava/lang/String;)[B", "GetProtocolToRawData_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe byte[] ProtocolToRawData (string p0, string p1)
		{
			const string __id = "protocolToRawData.(Ljava/lang/String;Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.V8JsEngine __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.V8JsEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.RawDataToProtocol (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.jsengine']/class[@name='V8JsEngine']/method[@name='rawDataToProtocol' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("rawDataToProtocol", "(Ljava/lang/String;[B)Ljava/lang/String;", "GetRawDataToProtocol_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe string RawDataToProtocol (string p0, byte[] p1)
		{
			const string __id = "rawDataToProtocol.(Ljava/lang/String;[B)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
