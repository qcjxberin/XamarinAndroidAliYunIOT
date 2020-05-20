using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Jsengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.jsengine']/class[@name='RhinoJsEngine']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/jsengine/RhinoJsEngine", DoNotGenerateAcw=true)]
	public partial class RhinoJsEngine : global::Java.Lang.Object, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngine {


		public static class InterfaceConsts {

			// The following are fields from: com.aliyun.alink.linksdk.alcs.lpbs.component.jsengine.IJSEngine

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.jsengine']/interface[@name='IJSEngine']/field[@name='PROTOCAL_TO_RAWDATA_FUNCNAME']"
			[Register ("PROTOCAL_TO_RAWDATA_FUNCNAME")]
			public const string ProtocalToRawdataFuncname = (string) "protocolToRawData";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.jsengine']/interface[@name='IJSEngine']/field[@name='RAWDATA_TO_PROTOCAL_FUNCNAME']"
			[Register ("RAWDATA_TO_PROTOCAL_FUNCNAME")]
			public const string RawdataToProtocalFuncname = (string) "rawDataToProtocol";
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/jsengine/RhinoJsEngine", typeof (RhinoJsEngine));
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

		protected RhinoJsEngine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.RhinoJsEngine Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.jsengine']/class[@name='RhinoJsEngine']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/alink/linksdk/alcs/jsengine/RhinoJsEngine;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/alink/linksdk/alcs/jsengine/RhinoJsEngine;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.RhinoJsEngine> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_callJsFunction_Lorg_mozilla_javascript_Context_Lorg_mozilla_javascript_ScriptableObject_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCallJsFunction_Lorg_mozilla_javascript_Context_Lorg_mozilla_javascript_ScriptableObject_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_callJsFunction_Lorg_mozilla_javascript_Context_Lorg_mozilla_javascript_ScriptableObject_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_callJsFunction_Lorg_mozilla_javascript_Context_Lorg_mozilla_javascript_ScriptableObject_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CallJsFunction_Lorg_mozilla_javascript_Context_Lorg_mozilla_javascript_ScriptableObject_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_callJsFunction_Lorg_mozilla_javascript_Context_Lorg_mozilla_javascript_ScriptableObject_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_CallJsFunction_Lorg_mozilla_javascript_Context_Lorg_mozilla_javascript_ScriptableObject_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.RhinoJsEngine __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.RhinoJsEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Mozilla.Javascript.Context p0 = global::Java.Lang.Object.GetObject<global::Org.Mozilla.Javascript.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Mozilla.Javascript.ScriptableObject p1 = global::Java.Lang.Object.GetObject<global::Org.Mozilla.Javascript.ScriptableObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p4 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CallJsFunction (p0, p1, p2, p3, p4));
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.jsengine']/class[@name='RhinoJsEngine']/method[@name='callJsFunction' and count(parameter)=5 and parameter[1][@type='org.mozilla.javascript.Context'] and parameter[2][@type='org.mozilla.javascript.ScriptableObject'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object[]']]"
		[Register ("callJsFunction", "(Lorg/mozilla/javascript/Context;Lorg/mozilla/javascript/ScriptableObject;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "GetCallJsFunction_Lorg_mozilla_javascript_Context_Lorg_mozilla_javascript_ScriptableObject_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object CallJsFunction (global::Org.Mozilla.Javascript.Context p0, global::Org.Mozilla.Javascript.ScriptableObject p1, string p2, string p3, global::Java.Lang.Object[] p4)
		{
			const string __id = "callJsFunction.(Lorg/mozilla/javascript/Context;Lorg/mozilla/javascript/ScriptableObject;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.RhinoJsEngine __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.RhinoJsEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ProtocolToRawData (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.jsengine']/class[@name='RhinoJsEngine']/method[@name='protocolToRawData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.RhinoJsEngine __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Jsengine.RhinoJsEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.RawDataToProtocol (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.jsengine']/class[@name='RhinoJsEngine']/method[@name='rawDataToProtocol' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
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
