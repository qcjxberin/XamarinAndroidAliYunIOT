using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Sdk.Tools.Tracker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.tracker']/class[@name='BoneLinkTracker']"
	[global::Android.Runtime.Register ("com/aliyun/iot/sdk/tools/tracker/BoneLinkTracker", DoNotGenerateAcw=true)]
	public partial class BoneLinkTracker : global::Com.Aliyun.Iot.Sdk.Tools.D {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.tracker']/class[@name='BoneLinkTracker']/field[@name='TRACK_START']"
		[Register ("TRACK_START")]
		public const string TrackStart = (string) "DeviceListClick";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/sdk/tools/tracker/BoneLinkTracker", typeof (BoneLinkTracker));
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

		protected BoneLinkTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.tracker']/class[@name='BoneLinkTracker']/constructor[@name='BoneLinkTracker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BoneLinkTracker ()
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

		static Delegate cb_getTrackId;
#pragma warning disable 0169
		static Delegate GetGetTrackIdHandler ()
		{
			if (cb_getTrackId == null)
				cb_getTrackId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackId);
			return cb_getTrackId;
		}

		static IntPtr n_GetTrackId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Tracker.BoneLinkTracker __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Tracker.BoneLinkTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TrackId);
		}
#pragma warning restore 0169

		public virtual unsafe string TrackId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.tracker']/class[@name='BoneLinkTracker']/method[@name='getTrackId' and count(parameter)=0]"
			[Register ("getTrackId", "()Ljava/lang/String;", "GetGetTrackIdHandler")]
			get {
				const string __id = "getTrackId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_commit;
#pragma warning disable 0169
		static Delegate GetCommitHandler ()
		{
			if (cb_commit == null)
				cb_commit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Commit);
			return cb_commit;
		}

		static void n_Commit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Tracker.BoneLinkTracker __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Tracker.BoneLinkTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Commit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.tracker']/class[@name='BoneLinkTracker']/method[@name='commit' and count(parameter)=0]"
		[Register ("commit", "()V", "GetCommitHandler")]
		public virtual unsafe void Commit ()
		{
			const string __id = "commit.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_start_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStart_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_start_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_start_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Start_Ljava_lang_String_Ljava_util_Map_);
			return cb_start_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Start_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Tracker.BoneLinkTracker __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Tracker.BoneLinkTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Start (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.tracker']/class[@name='BoneLinkTracker']/method[@name='start' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("start", "(Ljava/lang/String;Ljava/util/Map;)V", "GetStart_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void Start (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			const string __id = "start.(Ljava/lang/String;Ljava/util/Map;)V";
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
