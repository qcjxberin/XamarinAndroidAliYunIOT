using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage", DoNotGenerateAcw=true)]
	public abstract partial class AlcsCoAPMessage : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/field[@name='MAX_MID']"
		[Register ("MAX_MID")]
		public const int MaxMid = (int) 65535;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/field[@name='NONE']"
		[Register ("NONE")]
		public const int None = (int) -1;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage", typeof (AlcsCoAPMessage));
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

		protected AlcsCoAPMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/constructor[@name='AlcsCoAPMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe AlcsCoAPMessage ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/constructor[@name='AlcsCoAPMessage' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPConstant.Type']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;)V", "")]
		public unsafe AlcsCoAPMessage (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isAcknowledged;
#pragma warning disable 0169
		static Delegate GetIsAcknowledgedHandler ()
		{
			if (cb_isAcknowledged == null)
				cb_isAcknowledged = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAcknowledged);
			return cb_isAcknowledged;
		}

		static bool n_IsAcknowledged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Acknowledged;
		}
#pragma warning restore 0169

		static Delegate cb_setAcknowledged_Z;
#pragma warning disable 0169
		static Delegate GetSetAcknowledged_ZHandler ()
		{
			if (cb_setAcknowledged_Z == null)
				cb_setAcknowledged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAcknowledged_Z);
			return cb_setAcknowledged_Z;
		}

		static void n_SetAcknowledged_Z (IntPtr jnienv, IntPtr native__this, bool acknowledged)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Acknowledged = acknowledged;
		}
#pragma warning restore 0169

		public virtual unsafe bool Acknowledged {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='isAcknowledged' and count(parameter)=0]"
			[Register ("isAcknowledged", "()Z", "GetIsAcknowledgedHandler")]
			get {
				const string __id = "isAcknowledged.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setAcknowledged' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAcknowledged", "(Z)V", "GetSetAcknowledged_ZHandler")]
			set {
				const string __id = "setAcknowledged.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCanceled;
#pragma warning disable 0169
		static Delegate GetIsCanceledHandler ()
		{
			if (cb_isCanceled == null)
				cb_isCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCanceled);
			return cb_isCanceled;
		}

		static bool n_IsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Canceled;
		}
#pragma warning restore 0169

		static Delegate cb_setCanceled_Z;
#pragma warning disable 0169
		static Delegate GetSetCanceled_ZHandler ()
		{
			if (cb_setCanceled_Z == null)
				cb_setCanceled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCanceled_Z);
			return cb_setCanceled_Z;
		}

		static void n_SetCanceled_Z (IntPtr jnienv, IntPtr native__this, bool canceled)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Canceled = canceled;
		}
#pragma warning restore 0169

		public virtual unsafe bool Canceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler")]
			get {
				const string __id = "isCanceled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setCanceled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCanceled", "(Z)V", "GetSetCanceled_ZHandler")]
			set {
				const string __id = "setCanceled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDestination;
#pragma warning disable 0169
		static Delegate GetGetDestinationHandler ()
		{
			if (cb_getDestination == null)
				cb_getDestination = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDestination);
			return cb_getDestination;
		}

		static IntPtr n_GetDestination (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Destination);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.InetAddress Destination {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getDestination' and count(parameter)=0]"
			[Register ("getDestination", "()Ljava/net/InetAddress;", "GetGetDestinationHandler")]
			get {
				const string __id = "getDestination.()Ljava/net/InetAddress;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDestinationPort;
#pragma warning disable 0169
		static Delegate GetGetDestinationPortHandler ()
		{
			if (cb_getDestinationPort == null)
				cb_getDestinationPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDestinationPort);
			return cb_getDestinationPort;
		}

		static int n_GetDestinationPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DestinationPort;
		}
#pragma warning restore 0169

		public virtual unsafe int DestinationPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getDestinationPort' and count(parameter)=0]"
			[Register ("getDestinationPort", "()I", "GetGetDestinationPortHandler")]
			get {
				const string __id = "getDestinationPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDuplicate;
#pragma warning disable 0169
		static Delegate GetIsDuplicateHandler ()
		{
			if (cb_isDuplicate == null)
				cb_isDuplicate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDuplicate);
			return cb_isDuplicate;
		}

		static bool n_IsDuplicate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duplicate;
		}
#pragma warning restore 0169

		static Delegate cb_setDuplicate_Z;
#pragma warning disable 0169
		static Delegate GetSetDuplicate_ZHandler ()
		{
			if (cb_setDuplicate_Z == null)
				cb_setDuplicate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDuplicate_Z);
			return cb_setDuplicate_Z;
		}

		static void n_SetDuplicate_Z (IntPtr jnienv, IntPtr native__this, bool duplicate)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Duplicate = duplicate;
		}
#pragma warning restore 0169

		public virtual unsafe bool Duplicate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='isDuplicate' and count(parameter)=0]"
			[Register ("isDuplicate", "()Z", "GetIsDuplicateHandler")]
			get {
				const string __id = "isDuplicate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setDuplicate' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDuplicate", "(Z)V", "GetSetDuplicate_ZHandler")]
			set {
				const string __id = "setDuplicate.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_hasEmptyToken;
#pragma warning disable 0169
		static Delegate GetHasEmptyTokenHandler ()
		{
			if (cb_hasEmptyToken == null)
				cb_hasEmptyToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasEmptyToken);
			return cb_hasEmptyToken;
		}

		static bool n_HasEmptyToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasEmptyToken;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasEmptyToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='hasEmptyToken' and count(parameter)=0]"
			[Register ("hasEmptyToken", "()Z", "GetHasEmptyTokenHandler")]
			get {
				const string __id = "hasEmptyToken.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasMID;
#pragma warning disable 0169
		static Delegate GetHasMIDHandler ()
		{
			if (cb_hasMID == null)
				cb_hasMID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasMID);
			return cb_hasMID;
		}

		static bool n_HasMID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasMID;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasMID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='hasMID' and count(parameter)=0]"
			[Register ("hasMID", "()Z", "GetHasMIDHandler")]
			get {
				const string __id = "hasMID.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isConfirmable;
#pragma warning disable 0169
		static Delegate GetIsConfirmableHandler ()
		{
			if (cb_isConfirmable == null)
				cb_isConfirmable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConfirmable);
			return cb_isConfirmable;
		}

		static bool n_IsConfirmable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConfirmable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConfirmable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='isConfirmable' and count(parameter)=0]"
			[Register ("isConfirmable", "()Z", "GetIsConfirmableHandler")]
			get {
				const string __id = "isConfirmable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMID;
#pragma warning disable 0169
		static Delegate GetGetMIDHandler ()
		{
			if (cb_getMID == null)
				cb_getMID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMID);
			return cb_getMID;
		}

		static int n_GetMID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MID;
		}
#pragma warning restore 0169

		public virtual unsafe int MID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getMID' and count(parameter)=0]"
			[Register ("getMID", "()I", "GetGetMIDHandler")]
			get {
				const string __id = "getMID.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOptions;
#pragma warning disable 0169
		static Delegate GetGetOptionsHandler ()
		{
			if (cb_getOptions == null)
				cb_getOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOptions);
			return cb_getOptions;
		}

		static IntPtr n_GetOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Options);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet Options {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getOptions' and count(parameter)=0]"
			[Register ("getOptions", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetGetOptionsHandler")]
			get {
				const string __id = "getOptions.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPayloadSize;
#pragma warning disable 0169
		static Delegate GetGetPayloadSizeHandler ()
		{
			if (cb_getPayloadSize == null)
				cb_getPayloadSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPayloadSize);
			return cb_getPayloadSize;
		}

		static int n_GetPayloadSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PayloadSize;
		}
#pragma warning restore 0169

		public virtual unsafe int PayloadSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getPayloadSize' and count(parameter)=0]"
			[Register ("getPayloadSize", "()I", "GetGetPayloadSizeHandler")]
			get {
				const string __id = "getPayloadSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPayloadString;
#pragma warning disable 0169
		static Delegate GetGetPayloadStringHandler ()
		{
			if (cb_getPayloadString == null)
				cb_getPayloadString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPayloadString);
			return cb_getPayloadString;
		}

		static IntPtr n_GetPayloadString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PayloadString);
		}
#pragma warning restore 0169

		public virtual unsafe string PayloadString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getPayloadString' and count(parameter)=0]"
			[Register ("getPayloadString", "()Ljava/lang/String;", "GetGetPayloadStringHandler")]
			get {
				const string __id = "getPayloadString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPayloadTracingString;
#pragma warning disable 0169
		static Delegate GetGetPayloadTracingStringHandler ()
		{
			if (cb_getPayloadTracingString == null)
				cb_getPayloadTracingString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPayloadTracingString);
			return cb_getPayloadTracingString;
		}

		static IntPtr n_GetPayloadTracingString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PayloadTracingString);
		}
#pragma warning restore 0169

		protected virtual unsafe string PayloadTracingString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getPayloadTracingString' and count(parameter)=0]"
			[Register ("getPayloadTracingString", "()Ljava/lang/String;", "GetGetPayloadTracingStringHandler")]
			get {
				const string __id = "getPayloadTracingString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRawCode;
#pragma warning disable 0169
		static Delegate GetGetRawCodeHandler ()
		{
			if (cb_getRawCode == null)
				cb_getRawCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRawCode);
			return cb_getRawCode;
		}

		static int n_GetRawCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RawCode;
		}
#pragma warning restore 0169

		public abstract int RawCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getRawCode' and count(parameter)=0]"
			[Register ("getRawCode", "()I", "GetGetRawCodeHandler")] get;
		}

		static Delegate cb_getRawType;
#pragma warning disable 0169
		static Delegate GetGetRawTypeHandler ()
		{
			if (cb_getRawType == null)
				cb_getRawType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRawType);
			return cb_getRawType;
		}

		static int n_GetRawType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RawType;
		}
#pragma warning restore 0169

		public virtual unsafe int RawType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getRawType' and count(parameter)=0]"
			[Register ("getRawType", "()I", "GetGetRawTypeHandler")]
			get {
				const string __id = "getRawType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRejected;
#pragma warning disable 0169
		static Delegate GetIsRejectedHandler ()
		{
			if (cb_isRejected == null)
				cb_isRejected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRejected);
			return cb_isRejected;
		}

		static bool n_IsRejected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rejected;
		}
#pragma warning restore 0169

		static Delegate cb_setRejected_Z;
#pragma warning disable 0169
		static Delegate GetSetRejected_ZHandler ()
		{
			if (cb_setRejected_Z == null)
				cb_setRejected_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRejected_Z);
			return cb_setRejected_Z;
		}

		static void n_SetRejected_Z (IntPtr jnienv, IntPtr native__this, bool rejected)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Rejected = rejected;
		}
#pragma warning restore 0169

		public virtual unsafe bool Rejected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='isRejected' and count(parameter)=0]"
			[Register ("isRejected", "()Z", "GetIsRejectedHandler")]
			get {
				const string __id = "isRejected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setRejected' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRejected", "(Z)V", "GetSetRejected_ZHandler")]
			set {
				const string __id = "setRejected.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSendError;
#pragma warning disable 0169
		static Delegate GetGetSendErrorHandler ()
		{
			if (cb_getSendError == null)
				cb_getSendError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSendError);
			return cb_getSendError;
		}

		static IntPtr n_GetSendError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SendError);
		}
#pragma warning restore 0169

		static Delegate cb_setSendError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetSetSendError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_setSendError_Ljava_lang_Throwable_ == null)
				cb_setSendError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSendError_Ljava_lang_Throwable_);
			return cb_setSendError_Ljava_lang_Throwable_;
		}

		static void n_SetSendError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sendError)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable sendError = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_sendError, JniHandleOwnership.DoNotTransfer);
			__this.SendError = sendError;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Throwable SendError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getSendError' and count(parameter)=0]"
			[Register ("getSendError", "()Ljava/lang/Throwable;", "GetGetSendErrorHandler")]
			get {
				const string __id = "getSendError.()Ljava/lang/Throwable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setSendError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("setSendError", "(Ljava/lang/Throwable;)V", "GetSetSendError_Ljava_lang_Throwable_Handler")]
			set {
				const string __id = "setSendError.(Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSent;
#pragma warning disable 0169
		static Delegate GetIsSentHandler ()
		{
			if (cb_isSent == null)
				cb_isSent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSent);
			return cb_isSent;
		}

		static bool n_IsSent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sent;
		}
#pragma warning restore 0169

		static Delegate cb_setSent_Z;
#pragma warning disable 0169
		static Delegate GetSetSent_ZHandler ()
		{
			if (cb_setSent_Z == null)
				cb_setSent_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSent_Z);
			return cb_setSent_Z;
		}

		static void n_SetSent_Z (IntPtr jnienv, IntPtr native__this, bool sent)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sent = sent;
		}
#pragma warning restore 0169

		public virtual unsafe bool Sent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='isSent' and count(parameter)=0]"
			[Register ("isSent", "()Z", "GetIsSentHandler")]
			get {
				const string __id = "isSent.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setSent' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSent", "(Z)V", "GetSetSent_ZHandler")]
			set {
				const string __id = "setSent.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSource;
#pragma warning disable 0169
		static Delegate GetGetSourceHandler ()
		{
			if (cb_getSource == null)
				cb_getSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSource);
			return cb_getSource;
		}

		static IntPtr n_GetSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Source);
		}
#pragma warning restore 0169

		static Delegate cb_setSource_Ljava_net_InetAddress_;
#pragma warning disable 0169
		static Delegate GetSetSource_Ljava_net_InetAddress_Handler ()
		{
			if (cb_setSource_Ljava_net_InetAddress_ == null)
				cb_setSource_Ljava_net_InetAddress_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSource_Ljava_net_InetAddress_);
			return cb_setSource_Ljava_net_InetAddress_;
		}

		static void n_SetSource_Ljava_net_InetAddress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetAddress source = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_source, JniHandleOwnership.DoNotTransfer);
			__this.Source = source;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.InetAddress Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()Ljava/net/InetAddress;", "GetGetSourceHandler")]
			get {
				const string __id = "getSource.()Ljava/net/InetAddress;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setSource' and count(parameter)=1 and parameter[1][@type='java.net.InetAddress']]"
			[Register ("setSource", "(Ljava/net/InetAddress;)V", "GetSetSource_Ljava_net_InetAddress_Handler")]
			set {
				const string __id = "setSource.(Ljava/net/InetAddress;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSourcePort;
#pragma warning disable 0169
		static Delegate GetGetSourcePortHandler ()
		{
			if (cb_getSourcePort == null)
				cb_getSourcePort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSourcePort);
			return cb_getSourcePort;
		}

		static int n_GetSourcePort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SourcePort;
		}
#pragma warning restore 0169

		static Delegate cb_setSourcePort_I;
#pragma warning disable 0169
		static Delegate GetSetSourcePort_IHandler ()
		{
			if (cb_setSourcePort_I == null)
				cb_setSourcePort_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSourcePort_I);
			return cb_setSourcePort_I;
		}

		static void n_SetSourcePort_I (IntPtr jnienv, IntPtr native__this, int sourcePort)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SourcePort = sourcePort;
		}
#pragma warning restore 0169

		public virtual unsafe int SourcePort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getSourcePort' and count(parameter)=0]"
			[Register ("getSourcePort", "()I", "GetGetSourcePortHandler")]
			get {
				const string __id = "getSourcePort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setSourcePort' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSourcePort", "(I)V", "GetSetSourcePort_IHandler")]
			set {
				const string __id = "setSourcePort.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTimedOut;
#pragma warning disable 0169
		static Delegate GetIsTimedOutHandler ()
		{
			if (cb_isTimedOut == null)
				cb_isTimedOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTimedOut);
			return cb_isTimedOut;
		}

		static bool n_IsTimedOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimedOut;
		}
#pragma warning restore 0169

		static Delegate cb_setTimedOut_Z;
#pragma warning disable 0169
		static Delegate GetSetTimedOut_ZHandler ()
		{
			if (cb_setTimedOut_Z == null)
				cb_setTimedOut_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTimedOut_Z);
			return cb_setTimedOut_Z;
		}

		static void n_SetTimedOut_Z (IntPtr jnienv, IntPtr native__this, bool timedOut)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TimedOut = timedOut;
		}
#pragma warning restore 0169

		public virtual unsafe bool TimedOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='isTimedOut' and count(parameter)=0]"
			[Register ("isTimedOut", "()Z", "GetIsTimedOutHandler")]
			get {
				const string __id = "isTimedOut.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setTimedOut' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTimedOut", "(Z)V", "GetSetTimedOut_ZHandler")]
			set {
				const string __id = "setTimedOut.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		static Delegate cb_setTimestamp_J;
#pragma warning disable 0169
		static Delegate GetSetTimestamp_JHandler ()
		{
			if (cb_setTimestamp_J == null)
				cb_setTimestamp_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimestamp_J);
			return cb_setTimestamp_J;
		}

		static void n_SetTimestamp_J (IntPtr jnienv, IntPtr native__this, long timestamp)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timestamp = timestamp;
		}
#pragma warning restore 0169

		public virtual unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
			get {
				const string __id = "getTimestamp.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTimestamp", "(J)V", "GetSetTimestamp_JHandler")]
			set {
				const string __id = "setTimestamp.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTokenString;
#pragma warning disable 0169
		static Delegate GetGetTokenStringHandler ()
		{
			if (cb_getTokenString == null)
				cb_getTokenString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenString);
			return cb_getTokenString;
		}

		static IntPtr n_GetTokenString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenString);
		}
#pragma warning restore 0169

		public virtual unsafe string TokenString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getTokenString' and count(parameter)=0]"
			[Register ("getTokenString", "()Ljava/lang/String;", "GetGetTokenStringHandler")]
			get {
				const string __id = "getTokenString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getBytes;
#pragma warning disable 0169
		static Delegate GetGetBytesHandler ()
		{
			if (cb_getBytes == null)
				cb_getBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBytes);
			return cb_getBytes;
		}

		static IntPtr n_GetBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getBytes' and count(parameter)=0]"
		[Register ("getBytes", "()[B", "GetGetBytesHandler")]
		public virtual unsafe byte[] GetBytes ()
		{
			const string __id = "getBytes.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getPayload;
#pragma warning disable 0169
		static Delegate GetGetPayloadHandler ()
		{
			if (cb_getPayload == null)
				cb_getPayload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPayload);
			return cb_getPayload;
		}

		static IntPtr n_GetPayload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayload ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getPayload' and count(parameter)=0]"
		[Register ("getPayload", "()[B", "GetGetPayloadHandler")]
		public virtual unsafe byte[] GetPayload ()
		{
			const string __id = "getPayload.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetToken ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getToken' and count(parameter)=0]"
		[Register ("getToken", "()[B", "GetGetTokenHandler")]
		public virtual unsafe byte[] GetToken ()
		{
			const string __id = "getToken.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_hasBlock_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_;
#pragma warning disable 0169
		static Delegate GetHasBlock_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_Handler ()
		{
			if (cb_hasBlock_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_ == null)
				cb_hasBlock_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasBlock_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_);
			return cb_hasBlock_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_;
		}

		static bool n_HasBlock_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_block2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption block2 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption> (native_block2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasBlock (block2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='hasBlock' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.option.BlockOption']]"
		[Register ("hasBlock", "(Lcom/aliyun/alink/linksdk/alcs/coap/option/BlockOption;)Z", "GetHasBlock_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_Handler")]
		public virtual unsafe bool HasBlock (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption block2)
		{
			const string __id = "hasBlock.(Lcom/aliyun/alink/linksdk/alcs/coap/option/BlockOption;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((block2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) block2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isMulticast;
#pragma warning disable 0169
		static Delegate GetIsMulticastHandler ()
		{
			if (cb_isMulticast == null)
				cb_isMulticast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IsMulticast);
			return cb_isMulticast;
		}

		static int n_IsMulticast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMulticast ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='isMulticast' and count(parameter)=0]"
		[Register ("isMulticast", "()I", "GetIsMulticastHandler")]
		public virtual unsafe int IsMulticast ()
		{
			const string __id = "isMulticast.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeMID;
#pragma warning disable 0169
		static Delegate GetRemoveMIDHandler ()
		{
			if (cb_removeMID == null)
				cb_removeMID = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveMID);
			return cb_removeMID;
		}

		static void n_RemoveMID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMID ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='removeMID' and count(parameter)=0]"
		[Register ("removeMID", "()V", "GetRemoveMIDHandler")]
		public virtual unsafe void RemoveMID ()
		{
			const string __id = "removeMID.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setBytes_arrayB;
#pragma warning disable 0169
		static Delegate GetSetBytes_arrayBHandler ()
		{
			if (cb_setBytes_arrayB == null)
				cb_setBytes_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBytes_arrayB);
			return cb_setBytes_arrayB;
		}

		static void n_SetBytes_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetBytes (bytes);
			if (bytes != null)
				JNIEnv.CopyArray (bytes, native_bytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setBytes", "([B)V", "GetSetBytes_arrayBHandler")]
		public virtual unsafe void SetBytes (byte[] bytes)
		{
			const string __id = "setBytes.([B)V";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static Delegate cb_setConfirmable_Z;
#pragma warning disable 0169
		static Delegate GetSetConfirmable_ZHandler ()
		{
			if (cb_setConfirmable_Z == null)
				cb_setConfirmable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetConfirmable_Z);
			return cb_setConfirmable_Z;
		}

		static IntPtr n_SetConfirmable_Z (IntPtr jnienv, IntPtr native__this, bool con)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetConfirmable (con));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setConfirmable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setConfirmable", "(Z)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;", "GetSetConfirmable_ZHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage SetConfirmable (bool con)
		{
			const string __id = "setConfirmable.(Z)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (con);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDestination_Ljava_net_InetAddress_;
#pragma warning disable 0169
		static Delegate GetSetDestination_Ljava_net_InetAddress_Handler ()
		{
			if (cb_setDestination_Ljava_net_InetAddress_ == null)
				cb_setDestination_Ljava_net_InetAddress_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDestination_Ljava_net_InetAddress_);
			return cb_setDestination_Ljava_net_InetAddress_;
		}

		static IntPtr n_SetDestination_Ljava_net_InetAddress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_destination)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetAddress destination = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_destination, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDestination (destination));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setDestination' and count(parameter)=1 and parameter[1][@type='java.net.InetAddress']]"
		[Register ("setDestination", "(Ljava/net/InetAddress;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;", "GetSetDestination_Ljava_net_InetAddress_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage SetDestination (global::Java.Net.InetAddress destination)
		{
			const string __id = "setDestination.(Ljava/net/InetAddress;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((destination == null) ? IntPtr.Zero : ((global::Java.Lang.Object) destination).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDestinationPort_I;
#pragma warning disable 0169
		static Delegate GetSetDestinationPort_IHandler ()
		{
			if (cb_setDestinationPort_I == null)
				cb_setDestinationPort_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetDestinationPort_I);
			return cb_setDestinationPort_I;
		}

		static IntPtr n_SetDestinationPort_I (IntPtr jnienv, IntPtr native__this, int destinationPort)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDestinationPort (destinationPort));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setDestinationPort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDestinationPort", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;", "GetSetDestinationPort_IHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage SetDestinationPort (int destinationPort)
		{
			const string __id = "setDestinationPort.(I)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (destinationPort);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMID_I;
#pragma warning disable 0169
		static Delegate GetSetMID_IHandler ()
		{
			if (cb_setMID_I == null)
				cb_setMID_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMID_I);
			return cb_setMID_I;
		}

		static IntPtr n_SetMID_I (IntPtr jnienv, IntPtr native__this, int mid)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMID (mid));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setMID' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMID", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;", "GetSetMID_IHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage SetMID (int mid)
		{
			const string __id = "setMID.(I)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mid);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMulticast_I;
#pragma warning disable 0169
		static Delegate GetSetMulticast_IHandler ()
		{
			if (cb_setMulticast_I == null)
				cb_setMulticast_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMulticast_I);
			return cb_setMulticast_I;
		}

		static void n_SetMulticast_I (IntPtr jnienv, IntPtr native__this, int multicast)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMulticast (multicast);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setMulticast' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMulticast", "(I)V", "GetSetMulticast_IHandler")]
		public virtual unsafe void SetMulticast (int multicast)
		{
			const string __id = "setMulticast.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (multicast);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOptions_Lcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_;
#pragma warning disable 0169
		static Delegate GetSetOptions_Lcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_Handler ()
		{
			if (cb_setOptions_Lcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_ == null)
				cb_setOptions_Lcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOptions_Lcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_);
			return cb_setOptions_Lcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_;
		}

		static IntPtr n_SetOptions_Lcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet options = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOptions (options));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.option.OptionSet']]"
		[Register ("setOptions", "(Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;", "GetSetOptions_Lcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage SetOptions (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet options)
		{
			const string __id = "setOptions.(Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPayload_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPayload_arrayBHandler ()
		{
			if (cb_setPayload_arrayB == null)
				cb_setPayload_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPayload_arrayB);
			return cb_setPayload_arrayB;
		}

		static void n_SetPayload_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_payload)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] payload = (byte[]) JNIEnv.GetArray (native_payload, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPayload (payload);
			if (payload != null)
				JNIEnv.CopyArray (payload, native_payload);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setPayload' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPayload", "([B)V", "GetSetPayload_arrayBHandler")]
		public virtual unsafe void SetPayload (byte[] payload)
		{
			const string __id = "setPayload.([B)V";
			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_payload);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
				}
			}
		}

		static Delegate cb_setPayload_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPayload_Ljava_lang_String_Handler ()
		{
			if (cb_setPayload_Ljava_lang_String_ == null)
				cb_setPayload_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPayload_Ljava_lang_String_);
			return cb_setPayload_Ljava_lang_String_;
		}

		static IntPtr n_SetPayload_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_payload)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string payload = JNIEnv.GetString (native_payload, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPayload (payload));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setPayload' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPayload", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;", "GetSetPayload_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage SetPayload (string payload)
		{
			const string __id = "setPayload.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;";
			IntPtr native_payload = JNIEnv.NewString (payload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_payload);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_payload);
			}
		}

		static Delegate cb_setToken_arrayB;
#pragma warning disable 0169
		static Delegate GetSetToken_arrayBHandler ()
		{
			if (cb_setToken_arrayB == null)
				cb_setToken_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToken_arrayB);
			return cb_setToken_arrayB;
		}

		static void n_SetToken_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] token = (byte[]) JNIEnv.GetArray (native_token, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetToken (token);
			if (token != null)
				JNIEnv.CopyArray (token, native_token);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setToken", "([B)V", "GetSetToken_arrayBHandler")]
		public virtual unsafe void SetToken (byte[] token)
		{
			const string __id = "setToken.([B)V";
			IntPtr native_token = JNIEnv.NewArray (token);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_token);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (token != null) {
					JNIEnv.CopyArray (native_token, token);
					JNIEnv.DeleteLocalRef (native_token);
				}
			}
		}

		static Delegate cb_setToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToken_Ljava_lang_String_Handler ()
		{
			if (cb_setToken_Ljava_lang_String_ == null)
				cb_setToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToken_Ljava_lang_String_);
			return cb_setToken_Ljava_lang_String_;
		}

		static void n_SetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string token = JNIEnv.GetString (native_token, JniHandleOwnership.DoNotTransfer);
			__this.SetToken (token);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setToken", "(Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Handler")]
		public virtual unsafe void SetToken (string token)
		{
			const string __id = "setToken.(Ljava/lang/String;)V";
			IntPtr native_token = JNIEnv.NewString (token);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_token);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_token);
			}
		}

		static Delegate cb_setType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_;
#pragma warning disable 0169
		static Delegate GetSetType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_Handler ()
		{
			if (cb_setType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_ == null)
				cb_setType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_);
			return cb_setType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_;
		}

		static IntPtr n_SetType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type type = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type> (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetType (type));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPConstant.Type']]"
		[Register ("setType", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;", "GetSetType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage SetType (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type type)
		{
			const string __id = "setType.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setType_I;
#pragma warning disable 0169
		static Delegate GetSetType_IHandler ()
		{
			if (cb_setType_I == null)
				cb_setType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetType_I);
			return cb_setType_I;
		}

		static void n_SetType_I (IntPtr jnienv, IntPtr native__this, int type)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetType (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setType", "(I)V", "GetSetType_IHandler")]
		public virtual unsafe void SetType (int type)
		{
			const string __id = "setType.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage", DoNotGenerateAcw=true)]
	internal partial class AlcsCoAPMessageInvoker : AlcsCoAPMessage {

		public AlcsCoAPMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPMessage", typeof (AlcsCoAPMessageInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int RawCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPMessage']/method[@name='getRawCode' and count(parameter)=0]"
			[Register ("getRawCode", "()I", "GetGetRawCodeHandler")]
			get {
				const string __id = "getRawCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

}
