using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='Range']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/Range", DoNotGenerateAcw=true)]
	public partial class Range : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='Range']/field[@name='INFINITE']"
		[Register ("INFINITE")]
		public const long Infinite = (long) -1;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/Range", typeof (Range));
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

		protected Range (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='Range']/constructor[@name='Range' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register (".ctor", "(JJ)V", "")]
		public unsafe Range (long begin, long end)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (begin);
				__args [1] = new JniArgumentValue (end);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBegin;
#pragma warning disable 0169
		static Delegate GetGetBeginHandler ()
		{
			if (cb_getBegin == null)
				cb_getBegin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBegin);
			return cb_getBegin;
		}

		static long n_GetBegin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.Range __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.Range> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Begin;
		}
#pragma warning restore 0169

		static Delegate cb_setBegin_J;
#pragma warning disable 0169
		static Delegate GetSetBegin_JHandler ()
		{
			if (cb_setBegin_J == null)
				cb_setBegin_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBegin_J);
			return cb_setBegin_J;
		}

		static void n_SetBegin_J (IntPtr jnienv, IntPtr native__this, long begin)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.Range __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.Range> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Begin = begin;
		}
#pragma warning restore 0169

		public virtual unsafe long Begin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='Range']/method[@name='getBegin' and count(parameter)=0]"
			[Register ("getBegin", "()J", "GetGetBeginHandler")]
			get {
				const string __id = "getBegin.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='Range']/method[@name='setBegin' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setBegin", "(J)V", "GetSetBegin_JHandler")]
			set {
				const string __id = "setBegin.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEnd;
#pragma warning disable 0169
		static Delegate GetGetEndHandler ()
		{
			if (cb_getEnd == null)
				cb_getEnd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetEnd);
			return cb_getEnd;
		}

		static long n_GetEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.Range __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.Range> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.End;
		}
#pragma warning restore 0169

		static Delegate cb_setEnd_J;
#pragma warning disable 0169
		static Delegate GetSetEnd_JHandler ()
		{
			if (cb_setEnd_J == null)
				cb_setEnd_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetEnd_J);
			return cb_setEnd_J;
		}

		static void n_SetEnd_J (IntPtr jnienv, IntPtr native__this, long end)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.Range __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.Range> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End = end;
		}
#pragma warning restore 0169

		public virtual unsafe long End {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='Range']/method[@name='getEnd' and count(parameter)=0]"
			[Register ("getEnd", "()J", "GetGetEndHandler")]
			get {
				const string __id = "getEnd.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='Range']/method[@name='setEnd' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setEnd", "(J)V", "GetSetEnd_JHandler")]
			set {
				const string __id = "setEnd.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_checkIsValid;
#pragma warning disable 0169
		static Delegate GetCheckIsValidHandler ()
		{
			if (cb_checkIsValid == null)
				cb_checkIsValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckIsValid);
			return cb_checkIsValid;
		}

		static bool n_CheckIsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.Range __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.Range> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckIsValid ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='Range']/method[@name='checkIsValid' and count(parameter)=0]"
		[Register ("checkIsValid", "()Z", "GetCheckIsValidHandler")]
		public virtual unsafe bool CheckIsValid ()
		{
			const string __id = "checkIsValid.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
