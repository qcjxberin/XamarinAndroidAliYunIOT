using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSRequest']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/OSSRequest", DoNotGenerateAcw=true)]
	public partial class OSSRequest : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSRequest.CRC64Config']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/OSSRequest$CRC64Config", DoNotGenerateAcw=true)]
		public sealed partial class CRC64Config : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSRequest.CRC64Config']/field[@name='NO']"
			[Register ("NO")]
			public static global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest.CRC64Config No {
				get {
					const string __id = "NO.Lcom/alibaba/sdk/android/oss/model/OSSRequest$CRC64Config;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest.CRC64Config> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSRequest.CRC64Config']/field[@name='NULL']"
			[Register ("NULL")]
			public static global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest.CRC64Config Null {
				get {
					const string __id = "NULL.Lcom/alibaba/sdk/android/oss/model/OSSRequest$CRC64Config;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest.CRC64Config> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSRequest.CRC64Config']/field[@name='YES']"
			[Register ("YES")]
			public static global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest.CRC64Config Yes {
				get {
					const string __id = "YES.Lcom/alibaba/sdk/android/oss/model/OSSRequest$CRC64Config;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest.CRC64Config> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/OSSRequest$CRC64Config", typeof (CRC64Config));
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

			internal CRC64Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSRequest.CRC64Config']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/oss/model/OSSRequest$CRC64Config;", "")]
			public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest.CRC64Config ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/alibaba/sdk/android/oss/model/OSSRequest$CRC64Config;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest.CRC64Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSRequest.CRC64Config']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/alibaba/sdk/android/oss/model/OSSRequest$CRC64Config;", "")]
			public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest.CRC64Config[] Values ()
			{
				const string __id = "values.()[Lcom/alibaba/sdk/android/oss/model/OSSRequest$CRC64Config;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest.CRC64Config[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest.CRC64Config));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/OSSRequest", typeof (OSSRequest));
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

		protected OSSRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSRequest']/constructor[@name='OSSRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSSRequest ()
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

		static Delegate cb_getCRC64;
#pragma warning disable 0169
		static Delegate GetGetCRC64Handler ()
		{
			if (cb_getCRC64 == null)
				cb_getCRC64 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCRC64);
			return cb_getCRC64;
		}

		static IntPtr n_GetCRC64 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CRC64);
		}
#pragma warning restore 0169

		static Delegate cb_setCRC64_Ljava_lang_Enum_;
#pragma warning disable 0169
		static Delegate GetSetCRC64_Ljava_lang_Enum_Handler ()
		{
			if (cb_setCRC64_Ljava_lang_Enum_ == null)
				cb_setCRC64_Ljava_lang_Enum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCRC64_Ljava_lang_Enum_);
			return cb_setCRC64_Ljava_lang_Enum_;
		}

		static void n_SetCRC64_Ljava_lang_Enum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_CRC64)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Enum CRC64 = global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (native_CRC64, JniHandleOwnership.DoNotTransfer);
			__this.CRC64 = CRC64;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Enum CRC64 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSRequest']/method[@name='getCRC64' and count(parameter)=0]"
			[Register ("getCRC64", "()Ljava/lang/Enum;", "GetGetCRC64Handler")]
			get {
				const string __id = "getCRC64.()Ljava/lang/Enum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSRequest']/method[@name='setCRC64' and count(parameter)=1 and parameter[1][@type='java.lang.Enum']]"
			[Register ("setCRC64", "(Ljava/lang/Enum;)V", "GetSetCRC64_Ljava_lang_Enum_Handler")]
			set {
				const string __id = "setCRC64.(Ljava/lang/Enum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAuthorizationRequired;
#pragma warning disable 0169
		static Delegate GetIsAuthorizationRequiredHandler ()
		{
			if (cb_isAuthorizationRequired == null)
				cb_isAuthorizationRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthorizationRequired);
			return cb_isAuthorizationRequired;
		}

		static bool n_IsAuthorizationRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthorizationRequired;
		}
#pragma warning restore 0169

		static Delegate cb_setIsAuthorizationRequired_Z;
#pragma warning disable 0169
		static Delegate GetSetIsAuthorizationRequired_ZHandler ()
		{
			if (cb_setIsAuthorizationRequired_Z == null)
				cb_setIsAuthorizationRequired_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsAuthorizationRequired_Z);
			return cb_setIsAuthorizationRequired_Z;
		}

		static void n_SetIsAuthorizationRequired_Z (IntPtr jnienv, IntPtr native__this, bool isAuthorizationRequired)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsAuthorizationRequired = isAuthorizationRequired;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAuthorizationRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSRequest']/method[@name='isAuthorizationRequired' and count(parameter)=0]"
			[Register ("isAuthorizationRequired", "()Z", "GetIsAuthorizationRequiredHandler")]
			get {
				const string __id = "isAuthorizationRequired.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSRequest']/method[@name='setIsAuthorizationRequired' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsAuthorizationRequired", "(Z)V", "GetSetIsAuthorizationRequired_ZHandler")]
			set {
				const string __id = "setIsAuthorizationRequired.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
