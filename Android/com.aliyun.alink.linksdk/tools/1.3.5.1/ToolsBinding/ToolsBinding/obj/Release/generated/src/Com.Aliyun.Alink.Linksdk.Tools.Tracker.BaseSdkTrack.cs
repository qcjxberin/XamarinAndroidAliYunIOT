using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Tracker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/class[@name='BaseSdkTrack']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/tracker/BaseSdkTrack", DoNotGenerateAcw=true)]
	public partial class BaseSdkTrack : global::Java.Lang.Object, global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.ISDKTracker, global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.IValidityChecker {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/class[@name='BaseSdkTrack']/field[@name='isSupportTrack']"
		[Register ("isSupportTrack")]
		protected bool IsSupportTrack {
			get {
				const string __id = "isSupportTrack.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isSupportTrack.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/tracker/BaseSdkTrack", typeof (BaseSdkTrack));
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

		protected BaseSdkTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/class[@name='BaseSdkTrack']/constructor[@name='BaseSdkTrack' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseSdkTrack ()
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
			global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.BaseSdkTrack __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.BaseSdkTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupport;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSupport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/class[@name='BaseSdkTrack']/method[@name='isSupport' and count(parameter)=0]"
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

		static Delegate cb_sendEvent_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendEvent_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_sendEvent_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_sendEvent_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendEvent_Ljava_lang_String_Ljava_util_Map_);
			return cb_sendEvent_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_SendEvent_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventName, IntPtr native__params)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.BaseSdkTrack __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.BaseSdkTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eventName = JNIEnv.GetString (native_eventName, JniHandleOwnership.DoNotTransfer);
			var @params = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native__params, JniHandleOwnership.DoNotTransfer);
			__this.SendEvent (eventName, @params);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/class[@name='BaseSdkTrack']/method[@name='sendEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("sendEvent", "(Ljava/lang/String;Ljava/util/Map;)V", "GetSendEvent_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void SendEvent (string eventName, global::System.Collections.Generic.IDictionary<string, string> @params)
		{
			const string __id = "sendEvent.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_eventName = JNIEnv.NewString (eventName);
			IntPtr native__params = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_eventName);
				__args [1] = new JniArgumentValue (native__params);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventName);
				JNIEnv.DeleteLocalRef (native__params);
			}
		}

	}
}
