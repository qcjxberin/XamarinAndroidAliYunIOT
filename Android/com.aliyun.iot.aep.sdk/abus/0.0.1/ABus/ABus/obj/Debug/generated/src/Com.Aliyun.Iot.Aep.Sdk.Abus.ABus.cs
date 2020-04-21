using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Abus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/abus/ABus", DoNotGenerateAcw=true)]
	public partial class ABus : global::Java.Lang.Object, global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/abus/ABus", typeof (ABus));
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

		protected ABus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/constructor[@name='ABus' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ABus ()
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

		static Delegate cb_attachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetAttachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_attachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_attachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_AttachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_);
			return cb_attachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_;
		}

		static void n_AttachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, int channelId, IntPtr native_listener, IntPtr native_methodName, IntPtr native_eventClass)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object listener = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_listener, JniHandleOwnership.DoNotTransfer);
			string methodName = JNIEnv.GetString (native_methodName, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class eventClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventClass, JniHandleOwnership.DoNotTransfer);
			__this.AttachListener (channelId, listener, methodName, eventClass);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/method[@name='attachListener' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Class&lt;? extends java.lang.Object&gt;']]"
		[Register ("attachListener", "(ILjava/lang/Object;Ljava/lang/String;Ljava/lang/Class;)V", "GetAttachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_Handler")]
		public virtual unsafe void AttachListener (int channelId, global::Java.Lang.Object listener, string methodName, global::Java.Lang.Class eventClass)
		{
			const string __id = "attachListener.(ILjava/lang/Object;Ljava/lang/String;Ljava/lang/Class;)V";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (channelId);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [2] = new JniArgumentValue (native_methodName);
				__args [3] = new JniArgumentValue ((eventClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventClass).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		static Delegate cb_blockChannel_IZ;
#pragma warning disable 0169
		static Delegate GetBlockChannel_IZHandler ()
		{
			if (cb_blockChannel_IZ == null)
				cb_blockChannel_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_BlockChannel_IZ);
			return cb_blockChannel_IZ;
		}

		static void n_BlockChannel_IZ (IntPtr jnienv, IntPtr native__this, int channelId, bool blocked)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BlockChannel (channelId, blocked);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/method[@name='blockChannel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("blockChannel", "(IZ)V", "GetBlockChannel_IZHandler")]
		public virtual unsafe void BlockChannel (int channelId, bool blocked)
		{
			const string __id = "blockChannel.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (channelId);
				__args [1] = new JniArgumentValue (blocked);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_cancelChannel_I;
#pragma warning disable 0169
		static Delegate GetCancelChannel_IHandler ()
		{
			if (cb_cancelChannel_I == null)
				cb_cancelChannel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_CancelChannel_I);
			return cb_cancelChannel_I;
		}

		static void n_CancelChannel_I (IntPtr jnienv, IntPtr native__this, int channelId)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelChannel (channelId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/method[@name='cancelChannel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("cancelChannel", "(I)V", "GetCancelChannel_IHandler")]
		public virtual unsafe void CancelChannel (int channelId)
		{
			const string __id = "cancelChannel.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (channelId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_delayEvent_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDelayEvent_ILjava_lang_Object_Handler ()
		{
			if (cb_delayEvent_ILjava_lang_Object_ == null)
				cb_delayEvent_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_DelayEvent_ILjava_lang_Object_);
			return cb_delayEvent_ILjava_lang_Object_;
		}

		static void n_DelayEvent_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int channelId, IntPtr native_e)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.DelayEvent (channelId, e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/method[@name='delayEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("delayEvent", "(ILjava/lang/Object;)V", "GetDelayEvent_ILjava_lang_Object_Handler")]
		public virtual unsafe void DelayEvent (int channelId, global::Java.Lang.Object e)
		{
			const string __id = "delayEvent.(ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (channelId);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_detachListener_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDetachListener_ILjava_lang_Object_Handler ()
		{
			if (cb_detachListener_ILjava_lang_Object_ == null)
				cb_detachListener_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_DetachListener_ILjava_lang_Object_);
			return cb_detachListener_ILjava_lang_Object_;
		}

		static void n_DetachListener_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int channelId, IntPtr native_listener)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object listener = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DetachListener (channelId, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/method[@name='detachListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("detachListener", "(ILjava/lang/Object;)V", "GetDetachListener_ILjava_lang_Object_Handler")]
		public virtual unsafe void DetachListener (int channelId, global::Java.Lang.Object listener)
		{
			const string __id = "detachListener.(ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (channelId);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_detachListener_ILjava_lang_Object_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetDetachListener_ILjava_lang_Object_Ljava_lang_Class_Handler ()
		{
			if (cb_detachListener_ILjava_lang_Object_Ljava_lang_Class_ == null)
				cb_detachListener_ILjava_lang_Object_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_DetachListener_ILjava_lang_Object_Ljava_lang_Class_);
			return cb_detachListener_ILjava_lang_Object_Ljava_lang_Class_;
		}

		static void n_DetachListener_ILjava_lang_Object_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, int channelId, IntPtr native_listener, IntPtr native_eventClass)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object listener = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_listener, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class eventClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventClass, JniHandleOwnership.DoNotTransfer);
			__this.DetachListener (channelId, listener, eventClass);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/method[@name='detachListener' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Class&lt;? extends java.lang.Object&gt;']]"
		[Register ("detachListener", "(ILjava/lang/Object;Ljava/lang/Class;)V", "GetDetachListener_ILjava_lang_Object_Ljava_lang_Class_Handler")]
		public virtual unsafe void DetachListener (int channelId, global::Java.Lang.Object listener, global::Java.Lang.Class eventClass)
		{
			const string __id = "detachListener.(ILjava/lang/Object;Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (channelId);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [2] = new JniArgumentValue ((eventClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventClass).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getChannelBlock_I;
#pragma warning disable 0169
		static Delegate GetGetChannelBlock_IHandler ()
		{
			if (cb_getChannelBlock_I == null)
				cb_getChannelBlock_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_GetChannelBlock_I);
			return cb_getChannelBlock_I;
		}

		static bool n_GetChannelBlock_I (IntPtr jnienv, IntPtr native__this, int channelId)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetChannelBlock (channelId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/method[@name='getChannelBlock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getChannelBlock", "(I)Z", "GetGetChannelBlock_IHandler")]
		public virtual unsafe bool GetChannelBlock (int channelId)
		{
			const string __id = "getChannelBlock.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (channelId);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_postDelayEvents_I;
#pragma warning disable 0169
		static Delegate GetPostDelayEvents_IHandler ()
		{
			if (cb_postDelayEvents_I == null)
				cb_postDelayEvents_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_PostDelayEvents_I);
			return cb_postDelayEvents_I;
		}

		static void n_PostDelayEvents_I (IntPtr jnienv, IntPtr native__this, int channelId)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostDelayEvents (channelId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/method[@name='postDelayEvents' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("postDelayEvents", "(I)V", "GetPostDelayEvents_IHandler")]
		public virtual unsafe void PostDelayEvents (int channelId)
		{
			const string __id = "postDelayEvents.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (channelId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_postEvent_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPostEvent_ILjava_lang_Object_Handler ()
		{
			if (cb_postEvent_ILjava_lang_Object_ == null)
				cb_postEvent_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_PostEvent_ILjava_lang_Object_);
			return cb_postEvent_ILjava_lang_Object_;
		}

		static void n_PostEvent_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int channelId, IntPtr native_e)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.PostEvent (channelId, e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/method[@name='postEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("postEvent", "(ILjava/lang/Object;)V", "GetPostEvent_ILjava_lang_Object_Handler")]
		public virtual unsafe void PostEvent (int channelId, global::Java.Lang.Object e)
		{
			const string __id = "postEvent.(ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (channelId);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeChannelBlock_I;
#pragma warning disable 0169
		static Delegate GetRemoveChannelBlock_IHandler ()
		{
			if (cb_removeChannelBlock_I == null)
				cb_removeChannelBlock_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveChannelBlock_I);
			return cb_removeChannelBlock_I;
		}

		static void n_RemoveChannelBlock_I (IntPtr jnienv, IntPtr native__this, int channelId)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveChannelBlock (channelId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/method[@name='removeChannelBlock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeChannelBlock", "(I)V", "GetRemoveChannelBlock_IHandler")]
		public virtual unsafe void RemoveChannelBlock (int channelId)
		{
			const string __id = "removeChannelBlock.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (channelId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeDelayChannel_I;
#pragma warning disable 0169
		static Delegate GetRemoveDelayChannel_IHandler ()
		{
			if (cb_removeDelayChannel_I == null)
				cb_removeDelayChannel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveDelayChannel_I);
			return cb_removeDelayChannel_I;
		}

		static void n_RemoveDelayChannel_I (IntPtr jnienv, IntPtr native__this, int channel)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveDelayChannel (channel);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/method[@name='removeDelayChannel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeDelayChannel", "(I)V", "GetRemoveDelayChannel_IHandler")]
		public virtual unsafe void RemoveDelayChannel (int channel)
		{
			const string __id = "removeDelayChannel.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (channel);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setChannelBlock_IZ;
#pragma warning disable 0169
		static Delegate GetSetChannelBlock_IZHandler ()
		{
			if (cb_setChannelBlock_IZ == null)
				cb_setChannelBlock_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetChannelBlock_IZ);
			return cb_setChannelBlock_IZ;
		}

		static void n_SetChannelBlock_IZ (IntPtr jnienv, IntPtr native__this, int channelId, bool blocked)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.ABus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChannelBlock (channelId, blocked);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='ABus']/method[@name='setChannelBlock' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setChannelBlock", "(IZ)V", "GetSetChannelBlock_IZHandler")]
		public virtual unsafe void SetChannelBlock (int channelId, bool blocked)
		{
			const string __id = "setChannelBlock.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (channelId);
				__args [1] = new JniArgumentValue (blocked);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
