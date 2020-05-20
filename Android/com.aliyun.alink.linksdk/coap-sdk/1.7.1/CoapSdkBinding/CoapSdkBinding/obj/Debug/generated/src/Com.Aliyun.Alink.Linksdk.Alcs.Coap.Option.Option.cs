using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/option/Option", DoNotGenerateAcw=true)]
	public partial class Option : global::Java.Lang.Object, global::Java.Lang.IComparable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/option/Option", typeof (Option));
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

		protected Option (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/constructor[@name='Option' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Option ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/constructor[@name='Option' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Option (int number)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/constructor[@name='Option' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(I[B)V", "")]
		public unsafe Option (int number, byte[] opaque)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_opaque = JNIEnv.NewArray (opaque);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (number);
				__args [1] = new JniArgumentValue (native_opaque);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (opaque != null) {
					JNIEnv.CopyArray (native_opaque, opaque);
					JNIEnv.DeleteLocalRef (native_opaque);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/constructor[@name='Option' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Option (int number, int val)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (number);
				__args [1] = new JniArgumentValue (val);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/constructor[@name='Option' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe Option (int number, string str)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (number);
				__args [1] = new JniArgumentValue (native_str);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/constructor[@name='Option' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register (".ctor", "(IJ)V", "")]
		public unsafe Option (int number, long val)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (number);
				__args [1] = new JniArgumentValue (val);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getIntegerValue;
#pragma warning disable 0169
		static Delegate GetGetIntegerValueHandler ()
		{
			if (cb_getIntegerValue == null)
				cb_getIntegerValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIntegerValue);
			return cb_getIntegerValue;
		}

		static int n_GetIntegerValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IntegerValue;
		}
#pragma warning restore 0169

		static Delegate cb_setIntegerValue_I;
#pragma warning disable 0169
		static Delegate GetSetIntegerValue_IHandler ()
		{
			if (cb_setIntegerValue_I == null)
				cb_setIntegerValue_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIntegerValue_I);
			return cb_setIntegerValue_I;
		}

		static void n_SetIntegerValue_I (IntPtr jnienv, IntPtr native__this, int val)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IntegerValue = val;
		}
#pragma warning restore 0169

		public virtual unsafe int IntegerValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='getIntegerValue' and count(parameter)=0]"
			[Register ("getIntegerValue", "()I", "GetGetIntegerValueHandler")]
			get {
				const string __id = "getIntegerValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='setIntegerValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIntegerValue", "(I)V", "GetSetIntegerValue_IHandler")]
			set {
				const string __id = "setIntegerValue.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCritical;
#pragma warning disable 0169
		static Delegate GetIsCriticalHandler ()
		{
			if (cb_isCritical == null)
				cb_isCritical = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCritical);
			return cb_isCritical;
		}

		static bool n_IsCritical (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCritical;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCritical {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='isCritical' and count(parameter)=0]"
			[Register ("isCritical", "()Z", "GetIsCriticalHandler")]
			get {
				const string __id = "isCritical.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isNoCacheKey;
#pragma warning disable 0169
		static Delegate GetIsNoCacheKeyHandler ()
		{
			if (cb_isNoCacheKey == null)
				cb_isNoCacheKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNoCacheKey);
			return cb_isNoCacheKey;
		}

		static bool n_IsNoCacheKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNoCacheKey;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNoCacheKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='isNoCacheKey' and count(parameter)=0]"
			[Register ("isNoCacheKey", "()Z", "GetIsNoCacheKeyHandler")]
			get {
				const string __id = "isNoCacheKey.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isUnSafe;
#pragma warning disable 0169
		static Delegate GetIsUnSafeHandler ()
		{
			if (cb_isUnSafe == null)
				cb_isUnSafe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUnSafe);
			return cb_isUnSafe;
		}

		static bool n_IsUnSafe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnSafe;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsUnSafe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='isUnSafe' and count(parameter)=0]"
			[Register ("isUnSafe", "()Z", "GetIsUnSafeHandler")]
			get {
				const string __id = "isUnSafe.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLength;
#pragma warning disable 0169
		static Delegate GetGetLengthHandler ()
		{
			if (cb_getLength == null)
				cb_getLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLength);
			return cb_getLength;
		}

		static int n_GetLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length;
		}
#pragma warning restore 0169

		public virtual unsafe int Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='getLength' and count(parameter)=0]"
			[Register ("getLength", "()I", "GetGetLengthHandler")]
			get {
				const string __id = "getLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLongValue;
#pragma warning disable 0169
		static Delegate GetGetLongValueHandler ()
		{
			if (cb_getLongValue == null)
				cb_getLongValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLongValue);
			return cb_getLongValue;
		}

		static long n_GetLongValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongValue;
		}
#pragma warning restore 0169

		static Delegate cb_setLongValue_J;
#pragma warning disable 0169
		static Delegate GetSetLongValue_JHandler ()
		{
			if (cb_setLongValue_J == null)
				cb_setLongValue_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLongValue_J);
			return cb_setLongValue_J;
		}

		static void n_SetLongValue_J (IntPtr jnienv, IntPtr native__this, long val)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LongValue = val;
		}
#pragma warning restore 0169

		public virtual unsafe long LongValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='getLongValue' and count(parameter)=0]"
			[Register ("getLongValue", "()J", "GetGetLongValueHandler")]
			get {
				const string __id = "getLongValue.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='setLongValue' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLongValue", "(J)V", "GetSetLongValue_JHandler")]
			set {
				const string __id = "setLongValue.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNumber;
#pragma warning disable 0169
		static Delegate GetGetNumberHandler ()
		{
			if (cb_getNumber == null)
				cb_getNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumber);
			return cb_getNumber;
		}

		static int n_GetNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Number;
		}
#pragma warning restore 0169

		static Delegate cb_setNumber_I;
#pragma warning disable 0169
		static Delegate GetSetNumber_IHandler ()
		{
			if (cb_setNumber_I == null)
				cb_setNumber_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumber_I);
			return cb_setNumber_I;
		}

		static void n_SetNumber_I (IntPtr jnienv, IntPtr native__this, int number)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Number = number;
		}
#pragma warning restore 0169

		public virtual unsafe int Number {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='getNumber' and count(parameter)=0]"
			[Register ("getNumber", "()I", "GetGetNumberHandler")]
			get {
				const string __id = "getNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='setNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumber", "(I)V", "GetSetNumber_IHandler")]
			set {
				const string __id = "setNumber.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStringValue;
#pragma warning disable 0169
		static Delegate GetGetStringValueHandler ()
		{
			if (cb_getStringValue == null)
				cb_getStringValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStringValue);
			return cb_getStringValue;
		}

		static IntPtr n_GetStringValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StringValue);
		}
#pragma warning restore 0169

		static Delegate cb_setStringValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStringValue_Ljava_lang_String_Handler ()
		{
			if (cb_setStringValue_Ljava_lang_String_ == null)
				cb_setStringValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStringValue_Ljava_lang_String_);
			return cb_setStringValue_Ljava_lang_String_;
		}

		static void n_SetStringValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			__this.StringValue = str;
		}
#pragma warning restore 0169

		public virtual unsafe string StringValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='getStringValue' and count(parameter)=0]"
			[Register ("getStringValue", "()Ljava/lang/String;", "GetGetStringValueHandler")]
			get {
				const string __id = "getStringValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='setStringValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStringValue", "(Ljava/lang/String;)V", "GetSetStringValue_Ljava_lang_String_Handler")]
			set {
				const string __id = "setStringValue.(Ljava/lang/String;)V";
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

		static Delegate cb_compareTo_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_;
#pragma warning disable 0169
		static Delegate GetRawCompareTo_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_Handler ()
		{
			if (cb_compareTo_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_ == null)
				cb_compareTo_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_RawCompareTo_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_);
			return cb_compareTo_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_;
		}

		static int n_RawCompareTo_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option o = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (native_o, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RawCompareTo (o);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.option.Option']]"
		[Register ("compareTo", "(Lcom/aliyun/alink/linksdk/alcs/coap/option/Option;)I", "GetRawCompareTo_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_Handler")]
		public virtual unsafe int RawCompareTo (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option o)
		{
			const string __id = "compareTo.(Lcom/aliyun/alink/linksdk/alcs/coap/option/Option;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValue ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='getValue' and count(parameter)=0]"
		[Register ("getValue", "()[B", "GetGetValueHandler")]
		public virtual unsafe byte[] GetValue ()
		{
			const string __id = "getValue.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setValue_arrayB;
#pragma warning disable 0169
		static Delegate GetSetValue_arrayBHandler ()
		{
			if (cb_setValue_arrayB == null)
				cb_setValue_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_arrayB);
			return cb_setValue_arrayB;
		}

		static void n_SetValue_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetValue (value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setValue", "([B)V", "GetSetValue_arrayBHandler")]
		public virtual unsafe void SetValue (byte[] value)
		{
			const string __id = "setValue.([B)V";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_toValueString;
#pragma warning disable 0169
		static Delegate GetToValueStringHandler ()
		{
			if (cb_toValueString == null)
				cb_toValueString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToValueString);
			return cb_toValueString;
		}

		static IntPtr n_ToValueString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToValueString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='Option']/method[@name='toValueString' and count(parameter)=0]"
		[Register ("toValueString", "()Ljava/lang/String;", "GetToValueStringHandler")]
		public virtual unsafe string ToValueString ()
		{
			const string __id = "toValueString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
