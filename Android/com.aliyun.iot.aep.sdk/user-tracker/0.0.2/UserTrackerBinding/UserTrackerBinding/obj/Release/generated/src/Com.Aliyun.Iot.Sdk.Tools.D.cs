using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Sdk.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='d']"
	[global::Android.Runtime.Register ("com/aliyun/iot/sdk/tools/d", DoNotGenerateAcw=true)]
	public partial class D : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='d']/field[@name='TRACK_TYPE']"
		[Register ("TRACK_TYPE")]
		public const string TrackType = (string) "Discrete";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/sdk/tools/d", typeof (D));
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

		protected D (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='d']/constructor[@name='d' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe D ()
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

		static Delegate cb_isSupport;
#pragma warning disable 0169
		static Delegate GetIsSupportHandler ()
		{
			if (cb_isSupport == null)
				cb_isSupport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupport);
			return cb_isSupport;
		}

		static bool n_IsSupport (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.D __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupport;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSupport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='d']/method[@name='isSupport' and count(parameter)=0]"
			[Register ("isSupport", "()Z", "GetIsSupportHandler")]
			get {
				const string __id = "isSupport.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_record_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetRecord_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_record_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_record_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Record_Ljava_lang_String_Ljava_util_Map_);
			return cb_record_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Record_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.D __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Record (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='d']/method[@name='record' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("record", "(Ljava/lang/String;Ljava/util/Map;)V", "GetRecord_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void Record (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			const string __id = "record.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
