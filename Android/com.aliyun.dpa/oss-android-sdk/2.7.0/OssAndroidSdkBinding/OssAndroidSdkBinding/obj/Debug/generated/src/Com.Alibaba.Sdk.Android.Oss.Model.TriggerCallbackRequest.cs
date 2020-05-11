using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='TriggerCallbackRequest']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/TriggerCallbackRequest", DoNotGenerateAcw=true)]
	public partial class TriggerCallbackRequest : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/TriggerCallbackRequest", typeof (TriggerCallbackRequest));
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

		protected TriggerCallbackRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='TriggerCallbackRequest']/constructor[@name='TriggerCallbackRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;)V", "")]
		public unsafe TriggerCallbackRequest (string bucketName, string objectKey, global::System.Collections.Generic.IDictionary<string, string> callbackParam, global::System.Collections.Generic.IDictionary<string, string> callbackVars)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			IntPtr native_callbackParam = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (callbackParam);
			IntPtr native_callbackVars = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (callbackVars);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				__args [2] = new JniArgumentValue (native_callbackParam);
				__args [3] = new JniArgumentValue (native_callbackVars);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_objectKey);
				JNIEnv.DeleteLocalRef (native_callbackParam);
				JNIEnv.DeleteLocalRef (native_callbackVars);
			}
		}

		static Delegate cb_getBucketName;
#pragma warning disable 0169
		static Delegate GetGetBucketNameHandler ()
		{
			if (cb_getBucketName == null)
				cb_getBucketName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBucketName);
			return cb_getBucketName;
		}

		static IntPtr n_GetBucketName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BucketName);
		}
#pragma warning restore 0169

		static Delegate cb_setBucketName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBucketName_Ljava_lang_String_Handler ()
		{
			if (cb_setBucketName_Ljava_lang_String_ == null)
				cb_setBucketName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBucketName_Ljava_lang_String_);
			return cb_setBucketName_Ljava_lang_String_;
		}

		static void n_SetBucketName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucketName)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			__this.BucketName = bucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='TriggerCallbackRequest']/method[@name='getBucketName' and count(parameter)=0]"
			[Register ("getBucketName", "()Ljava/lang/String;", "GetGetBucketNameHandler")]
			get {
				const string __id = "getBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='TriggerCallbackRequest']/method[@name='setBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBucketName", "(Ljava/lang/String;)V", "GetSetBucketName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBucketName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCallbackParam;
#pragma warning disable 0169
		static Delegate GetGetCallbackParamHandler ()
		{
			if (cb_getCallbackParam == null)
				cb_getCallbackParam = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallbackParam);
			return cb_getCallbackParam;
		}

		static IntPtr n_GetCallbackParam (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CallbackParam);
		}
#pragma warning restore 0169

		static Delegate cb_setCallbackParam_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetCallbackParam_Ljava_util_Map_Handler ()
		{
			if (cb_setCallbackParam_Ljava_util_Map_ == null)
				cb_setCallbackParam_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallbackParam_Ljava_util_Map_);
			return cb_setCallbackParam_Ljava_util_Map_;
		}

		static void n_SetCallbackParam_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callbackParam)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var callbackParam = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_callbackParam, JniHandleOwnership.DoNotTransfer);
			__this.CallbackParam = callbackParam;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> CallbackParam {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='TriggerCallbackRequest']/method[@name='getCallbackParam' and count(parameter)=0]"
			[Register ("getCallbackParam", "()Ljava/util/Map;", "GetGetCallbackParamHandler")]
			get {
				const string __id = "getCallbackParam.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='TriggerCallbackRequest']/method[@name='setCallbackParam' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setCallbackParam", "(Ljava/util/Map;)V", "GetSetCallbackParam_Ljava_util_Map_Handler")]
			set {
				const string __id = "setCallbackParam.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCallbackVars;
#pragma warning disable 0169
		static Delegate GetGetCallbackVarsHandler ()
		{
			if (cb_getCallbackVars == null)
				cb_getCallbackVars = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallbackVars);
			return cb_getCallbackVars;
		}

		static IntPtr n_GetCallbackVars (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CallbackVars);
		}
#pragma warning restore 0169

		static Delegate cb_setCallbackVars_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetCallbackVars_Ljava_util_Map_Handler ()
		{
			if (cb_setCallbackVars_Ljava_util_Map_ == null)
				cb_setCallbackVars_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallbackVars_Ljava_util_Map_);
			return cb_setCallbackVars_Ljava_util_Map_;
		}

		static void n_SetCallbackVars_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callbackVars)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var callbackVars = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_callbackVars, JniHandleOwnership.DoNotTransfer);
			__this.CallbackVars = callbackVars;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> CallbackVars {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='TriggerCallbackRequest']/method[@name='getCallbackVars' and count(parameter)=0]"
			[Register ("getCallbackVars", "()Ljava/util/Map;", "GetGetCallbackVarsHandler")]
			get {
				const string __id = "getCallbackVars.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='TriggerCallbackRequest']/method[@name='setCallbackVars' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setCallbackVars", "(Ljava/util/Map;)V", "GetSetCallbackVars_Ljava_util_Map_Handler")]
			set {
				const string __id = "setCallbackVars.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getObjectKey;
#pragma warning disable 0169
		static Delegate GetGetObjectKeyHandler ()
		{
			if (cb_getObjectKey == null)
				cb_getObjectKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObjectKey);
			return cb_getObjectKey;
		}

		static IntPtr n_GetObjectKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ObjectKey);
		}
#pragma warning restore 0169

		static Delegate cb_setObjectKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetObjectKey_Ljava_lang_String_Handler ()
		{
			if (cb_setObjectKey_Ljava_lang_String_ == null)
				cb_setObjectKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObjectKey_Ljava_lang_String_);
			return cb_setObjectKey_Ljava_lang_String_;
		}

		static void n_SetObjectKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectKey)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string objectKey = JNIEnv.GetString (native_objectKey, JniHandleOwnership.DoNotTransfer);
			__this.ObjectKey = objectKey;
		}
#pragma warning restore 0169

		public virtual unsafe string ObjectKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='TriggerCallbackRequest']/method[@name='getObjectKey' and count(parameter)=0]"
			[Register ("getObjectKey", "()Ljava/lang/String;", "GetGetObjectKeyHandler")]
			get {
				const string __id = "getObjectKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='TriggerCallbackRequest']/method[@name='setObjectKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setObjectKey", "(Ljava/lang/String;)V", "GetSetObjectKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setObjectKey.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
