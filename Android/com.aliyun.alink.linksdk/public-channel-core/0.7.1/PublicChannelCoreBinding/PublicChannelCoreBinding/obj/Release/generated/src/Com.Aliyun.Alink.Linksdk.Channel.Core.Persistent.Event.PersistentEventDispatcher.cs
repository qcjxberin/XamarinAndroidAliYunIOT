using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/class[@name='PersistentEventDispatcher']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/event/PersistentEventDispatcher", DoNotGenerateAcw=true)]
	public partial class PersistentEventDispatcher : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/class[@name='PersistentEventDispatcher']/field[@name='a']"
		[Register ("a")]
		protected global::System.Collections.IDictionary A {
			get {
				const string __id = "a.Ljava/util/HashMap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Ljava/util/HashMap;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/class[@name='PersistentEventDispatcher']/field[@name='b']"
		[Register ("b")]
		protected global::System.Collections.IDictionary B {
			get {
				const string __id = "b.Ljava/util/HashMap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Ljava/util/HashMap;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/class[@name='PersistentEventDispatcher']/field[@name='c']"
		[Register ("c")]
		protected global::System.Collections.IDictionary C {
			get {
				const string __id = "c.Ljava/util/HashMap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Ljava/util/HashMap;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/event/PersistentEventDispatcher", typeof (PersistentEventDispatcher));
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

		protected PersistentEventDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/class[@name='PersistentEventDispatcher']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/alink/linksdk/channel/core/persistent/event/PersistentEventDispatcher;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/alink/linksdk/channel/core/persistent/event/PersistentEventDispatcher;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_broadcastMessage_ILjava_lang_String_arrayBILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBroadcastMessage_ILjava_lang_String_arrayBILjava_lang_String_Handler ()
		{
			if (cb_broadcastMessage_ILjava_lang_String_arrayBILjava_lang_String_ == null)
				cb_broadcastMessage_ILjava_lang_String_arrayBILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, int, IntPtr>) n_BroadcastMessage_ILjava_lang_String_arrayBILjava_lang_String_);
			return cb_broadcastMessage_ILjava_lang_String_arrayBILjava_lang_String_;
		}

		static void n_BroadcastMessage_ILjava_lang_String_arrayBILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3, IntPtr native_p4)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.BroadcastMessage (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/class[@name='PersistentEventDispatcher']/method[@name='broadcastMessage' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("broadcastMessage", "(ILjava/lang/String;[BILjava/lang/String;)V", "GetBroadcastMessage_ILjava_lang_String_arrayBILjava_lang_String_Handler")]
		public virtual unsafe void BroadcastMessage (int p0, string p1, byte[] p2, int p3, string p4)
		{
			const string __id = "broadcastMessage.(ILjava/lang/String;[BILjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_registerNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_Z;
#pragma warning disable 0169
		static Delegate GetRegisterNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_ZHandler ()
		{
			if (cb_registerNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_Z == null)
				cb_registerNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_RegisterNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_Z);
			return cb_registerNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_Z;
		}

		static void n_RegisterNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener p0 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterNetSessionStateListener (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/class[@name='PersistentEventDispatcher']/method[@name='registerNetSessionStateListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.persistent.event.INetSessionStateListener'] and parameter[2][@type='boolean']]"
		[Register ("registerNetSessionStateListener", "(Lcom/aliyun/alink/linksdk/channel/core/persistent/event/INetSessionStateListener;Z)V", "GetRegisterNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_ZHandler")]
		public virtual unsafe void RegisterNetSessionStateListener (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener p0, bool p1)
		{
			const string __id = "registerNetSessionStateListener.(Lcom/aliyun/alink/linksdk/channel/core/persistent/event/INetSessionStateListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_registerOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_Z;
#pragma warning disable 0169
		static Delegate GetRegisterOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_ZHandler ()
		{
			if (cb_registerOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_Z == null)
				cb_registerOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_RegisterOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_Z);
			return cb_registerOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_Z;
		}

		static void n_RegisterOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListener p0 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterOnPushListener (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/class[@name='PersistentEventDispatcher']/method[@name='registerOnPushListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.persistent.event.IOnPushListener'] and parameter[2][@type='boolean']]"
		[Register ("registerOnPushListener", "(Lcom/aliyun/alink/linksdk/channel/core/persistent/event/IOnPushListener;Z)V", "GetRegisterOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_ZHandler")]
		public virtual unsafe void RegisterOnPushListener (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListener p0, bool p1)
		{
			const string __id = "registerOnPushListener.(Lcom/aliyun/alink/linksdk/channel/core/persistent/event/IOnPushListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_registerOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_Z;
#pragma warning disable 0169
		static Delegate GetRegisterOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_ZHandler ()
		{
			if (cb_registerOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_Z == null)
				cb_registerOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_RegisterOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_Z);
			return cb_registerOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_Z;
		}

		static void n_RegisterOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener p0 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterOnTunnelStateListener (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/class[@name='PersistentEventDispatcher']/method[@name='registerOnTunnelStateListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.persistent.event.IConnectionStateListener'] and parameter[2][@type='boolean']]"
		[Register ("registerOnTunnelStateListener", "(Lcom/aliyun/alink/linksdk/channel/core/persistent/event/IConnectionStateListener;Z)V", "GetRegisterOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_ZHandler")]
		public virtual unsafe void RegisterOnTunnelStateListener (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener p0, bool p1)
		{
			const string __id = "registerOnTunnelStateListener.(Lcom/aliyun/alink/linksdk/channel/core/persistent/event/IConnectionStateListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unregisterNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_Handler ()
		{
			if (cb_unregisterNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_ == null)
				cb_unregisterNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_);
			return cb_unregisterNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_;
		}

		static void n_UnregisterNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener p0 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterNetSessionStateListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/class[@name='PersistentEventDispatcher']/method[@name='unregisterNetSessionStateListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.persistent.event.INetSessionStateListener']]"
		[Register ("unregisterNetSessionStateListener", "(Lcom/aliyun/alink/linksdk/channel/core/persistent/event/INetSessionStateListener;)V", "GetUnregisterNetSessionStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_INetSessionStateListener_Handler")]
		public virtual unsafe void UnregisterNetSessionStateListener (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener p0)
		{
			const string __id = "unregisterNetSessionStateListener.(Lcom/aliyun/alink/linksdk/channel/core/persistent/event/INetSessionStateListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unregisterOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_Handler ()
		{
			if (cb_unregisterOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_ == null)
				cb_unregisterOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_);
			return cb_unregisterOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_;
		}

		static void n_UnregisterOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListener p0 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterOnPushListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/class[@name='PersistentEventDispatcher']/method[@name='unregisterOnPushListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.persistent.event.IOnPushListener']]"
		[Register ("unregisterOnPushListener", "(Lcom/aliyun/alink/linksdk/channel/core/persistent/event/IOnPushListener;)V", "GetUnregisterOnPushListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IOnPushListener_Handler")]
		public virtual unsafe void UnregisterOnPushListener (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IOnPushListener p0)
		{
			const string __id = "unregisterOnPushListener.(Lcom/aliyun/alink/linksdk/channel/core/persistent/event/IOnPushListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unregisterOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_Handler ()
		{
			if (cb_unregisterOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_ == null)
				cb_unregisterOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_);
			return cb_unregisterOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_;
		}

		static void n_UnregisterOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.PersistentEventDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener p0 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterOnTunnelStateListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/class[@name='PersistentEventDispatcher']/method[@name='unregisterOnTunnelStateListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.persistent.event.IConnectionStateListener']]"
		[Register ("unregisterOnTunnelStateListener", "(Lcom/aliyun/alink/linksdk/channel/core/persistent/event/IConnectionStateListener;)V", "GetUnregisterOnTunnelStateListener_Lcom_aliyun_alink_linksdk_channel_core_persistent_event_IConnectionStateListener_Handler")]
		public virtual unsafe void UnregisterOnTunnelStateListener (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener p0)
		{
			const string __id = "unregisterOnTunnelStateListener.(Lcom/aliyun/alink/linksdk/channel/core/persistent/event/IConnectionStateListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
