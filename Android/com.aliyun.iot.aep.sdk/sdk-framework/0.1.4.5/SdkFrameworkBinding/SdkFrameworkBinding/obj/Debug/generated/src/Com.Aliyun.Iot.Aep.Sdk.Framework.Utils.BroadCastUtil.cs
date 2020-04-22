using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='BroadCastUtil']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/utils/BroadCastUtil", DoNotGenerateAcw=true)]
	public partial class BroadCastUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/utils/BroadCastUtil", typeof (BroadCastUtil));
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

		protected BroadCastUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='BroadCastUtil']/constructor[@name='BroadCastUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BroadCastUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='BroadCastUtil']/method[@name='broadCast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("broadCast", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static unsafe void BroadCast (global::Android.Content.Context context, global::Android.Content.Intent intent)
		{
			const string __id = "broadCast.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='BroadCastUtil']/method[@name='broadCastSticky' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("broadCastSticky", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static unsafe void BroadCastSticky (global::Android.Content.Context context, global::Android.Content.Intent intent)
		{
			const string __id = "broadCastSticky.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='BroadCastUtil']/method[@name='register' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.BroadcastReceiver'] and parameter[3][@type='android.content.IntentFilter']]"
		[Register ("register", "(Landroid/content/Context;Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)V", "")]
		public static unsafe void Register (global::Android.Content.Context context, global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter)
		{
			const string __id = "register.(Landroid/content/Context;Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				__args [2] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='BroadCastUtil']/method[@name='unRegister' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.BroadcastReceiver']]"
		[Register ("unRegister", "(Landroid/content/Context;Landroid/content/BroadcastReceiver;)V", "")]
		public static unsafe void UnRegister (global::Android.Content.Context context, global::Android.Content.BroadcastReceiver receiver)
		{
			const string __id = "unRegister.(Landroid/content/Context;Landroid/content/BroadcastReceiver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
