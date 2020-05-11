using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='AppendObjectResult']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/AppendObjectResult", DoNotGenerateAcw=true)]
	public partial class AppendObjectResult : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/AppendObjectResult", typeof (AppendObjectResult));
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

		protected AppendObjectResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='AppendObjectResult']/constructor[@name='AppendObjectResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppendObjectResult ()
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

		static Delegate cb_getNextPosition;
#pragma warning disable 0169
		static Delegate GetGetNextPositionHandler ()
		{
			if (cb_getNextPosition == null)
				cb_getNextPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNextPosition);
			return cb_getNextPosition;
		}

		static long n_GetNextPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextPosition;
		}
#pragma warning restore 0169

		public virtual unsafe long NextPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='AppendObjectResult']/method[@name='getNextPosition' and count(parameter)=0]"
			[Register ("getNextPosition", "()J", "GetGetNextPositionHandler")]
			get {
				const string __id = "getNextPosition.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getObjectCRC64;
#pragma warning disable 0169
		static Delegate GetGetObjectCRC64Handler ()
		{
			if (cb_getObjectCRC64 == null)
				cb_getObjectCRC64 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObjectCRC64);
			return cb_getObjectCRC64;
		}

		static IntPtr n_GetObjectCRC64 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ObjectCRC64);
		}
#pragma warning restore 0169

		static Delegate cb_setObjectCRC64_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetObjectCRC64_Ljava_lang_String_Handler ()
		{
			if (cb_setObjectCRC64_Ljava_lang_String_ == null)
				cb_setObjectCRC64_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObjectCRC64_Ljava_lang_String_);
			return cb_setObjectCRC64_Ljava_lang_String_;
		}

		static void n_SetObjectCRC64_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectCRC64)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string objectCRC64 = JNIEnv.GetString (native_objectCRC64, JniHandleOwnership.DoNotTransfer);
			__this.ObjectCRC64 = objectCRC64;
		}
#pragma warning restore 0169

		public virtual unsafe string ObjectCRC64 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='AppendObjectResult']/method[@name='getObjectCRC64' and count(parameter)=0]"
			[Register ("getObjectCRC64", "()Ljava/lang/String;", "GetGetObjectCRC64Handler")]
			get {
				const string __id = "getObjectCRC64.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='AppendObjectResult']/method[@name='setObjectCRC64' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setObjectCRC64", "(Ljava/lang/String;)V", "GetSetObjectCRC64_Ljava_lang_String_Handler")]
			set {
				const string __id = "setObjectCRC64.(Ljava/lang/String;)V";
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

		static Delegate cb_setNextPosition_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetNextPosition_Ljava_lang_Long_Handler ()
		{
			if (cb_setNextPosition_Ljava_lang_Long_ == null)
				cb_setNextPosition_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNextPosition_Ljava_lang_Long_);
			return cb_setNextPosition_Ljava_lang_Long_;
		}

		static void n_SetNextPosition_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nextPosition)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long nextPosition = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_nextPosition, JniHandleOwnership.DoNotTransfer);
			__this.SetNextPosition (nextPosition);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='AppendObjectResult']/method[@name='setNextPosition' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("setNextPosition", "(Ljava/lang/Long;)V", "GetSetNextPosition_Ljava_lang_Long_Handler")]
		public virtual unsafe void SetNextPosition (global::Java.Lang.Long nextPosition)
		{
			const string __id = "setNextPosition.(Ljava/lang/Long;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nextPosition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nextPosition).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
