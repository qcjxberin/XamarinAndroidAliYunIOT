using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/DisconnectedBufferOptions", DoNotGenerateAcw=true)]
	public partial class DisconnectedBufferOptions : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/field[@name='DELETE_OLDEST_MESSAGES_DEFAULT']"
		[Register ("DELETE_OLDEST_MESSAGES_DEFAULT")]
		public const bool DeleteOldestMessagesDefault = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/field[@name='DISCONNECTED_BUFFER_ENABLED_DEFAULT']"
		[Register ("DISCONNECTED_BUFFER_ENABLED_DEFAULT")]
		public const bool DisconnectedBufferEnabledDefault = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/field[@name='DISCONNECTED_BUFFER_SIZE_DEFAULT']"
		[Register ("DISCONNECTED_BUFFER_SIZE_DEFAULT")]
		public const int DisconnectedBufferSizeDefault = (int) 5000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/field[@name='PERSIST_DISCONNECTED_BUFFER_DEFAULT']"
		[Register ("PERSIST_DISCONNECTED_BUFFER_DEFAULT")]
		public const bool PersistDisconnectedBufferDefault = (bool) false;
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/DisconnectedBufferOptions", typeof (DisconnectedBufferOptions));
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

		protected DisconnectedBufferOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/constructor[@name='DisconnectedBufferOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DisconnectedBufferOptions ()
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

		static Delegate cb_isBufferEnabled;
#pragma warning disable 0169
		static Delegate GetIsBufferEnabledHandler ()
		{
			if (cb_isBufferEnabled == null)
				cb_isBufferEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBufferEnabled);
			return cb_isBufferEnabled;
		}

		static bool n_IsBufferEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setBufferEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetBufferEnabled_ZHandler ()
		{
			if (cb_setBufferEnabled_Z == null)
				cb_setBufferEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBufferEnabled_Z);
			return cb_setBufferEnabled_Z;
		}

		static void n_SetBufferEnabled_Z (IntPtr jnienv, IntPtr native__this, bool bufferEnabled)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BufferEnabled = bufferEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool BufferEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/method[@name='isBufferEnabled' and count(parameter)=0]"
			[Register ("isBufferEnabled", "()Z", "GetIsBufferEnabledHandler")]
			get {
				const string __id = "isBufferEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/method[@name='setBufferEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBufferEnabled", "(Z)V", "GetSetBufferEnabled_ZHandler")]
			set {
				const string __id = "setBufferEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBufferSize;
#pragma warning disable 0169
		static Delegate GetGetBufferSizeHandler ()
		{
			if (cb_getBufferSize == null)
				cb_getBufferSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBufferSize);
			return cb_getBufferSize;
		}

		static int n_GetBufferSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferSize;
		}
#pragma warning restore 0169

		static Delegate cb_setBufferSize_I;
#pragma warning disable 0169
		static Delegate GetSetBufferSize_IHandler ()
		{
			if (cb_setBufferSize_I == null)
				cb_setBufferSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBufferSize_I);
			return cb_setBufferSize_I;
		}

		static void n_SetBufferSize_I (IntPtr jnienv, IntPtr native__this, int bufferSize)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BufferSize = bufferSize;
		}
#pragma warning restore 0169

		public virtual unsafe int BufferSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/method[@name='getBufferSize' and count(parameter)=0]"
			[Register ("getBufferSize", "()I", "GetGetBufferSizeHandler")]
			get {
				const string __id = "getBufferSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/method[@name='setBufferSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBufferSize", "(I)V", "GetSetBufferSize_IHandler")]
			set {
				const string __id = "setBufferSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDeleteOldestMessages;
#pragma warning disable 0169
		static Delegate GetIsDeleteOldestMessagesHandler ()
		{
			if (cb_isDeleteOldestMessages == null)
				cb_isDeleteOldestMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeleteOldestMessages);
			return cb_isDeleteOldestMessages;
		}

		static bool n_IsDeleteOldestMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeleteOldestMessages;
		}
#pragma warning restore 0169

		static Delegate cb_setDeleteOldestMessages_Z;
#pragma warning disable 0169
		static Delegate GetSetDeleteOldestMessages_ZHandler ()
		{
			if (cb_setDeleteOldestMessages_Z == null)
				cb_setDeleteOldestMessages_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDeleteOldestMessages_Z);
			return cb_setDeleteOldestMessages_Z;
		}

		static void n_SetDeleteOldestMessages_Z (IntPtr jnienv, IntPtr native__this, bool deleteOldestMessages)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteOldestMessages = deleteOldestMessages;
		}
#pragma warning restore 0169

		public virtual unsafe bool DeleteOldestMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/method[@name='isDeleteOldestMessages' and count(parameter)=0]"
			[Register ("isDeleteOldestMessages", "()Z", "GetIsDeleteOldestMessagesHandler")]
			get {
				const string __id = "isDeleteOldestMessages.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/method[@name='setDeleteOldestMessages' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDeleteOldestMessages", "(Z)V", "GetSetDeleteOldestMessages_ZHandler")]
			set {
				const string __id = "setDeleteOldestMessages.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isPersistBuffer;
#pragma warning disable 0169
		static Delegate GetIsPersistBufferHandler ()
		{
			if (cb_isPersistBuffer == null)
				cb_isPersistBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPersistBuffer);
			return cb_isPersistBuffer;
		}

		static bool n_IsPersistBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PersistBuffer;
		}
#pragma warning restore 0169

		static Delegate cb_setPersistBuffer_Z;
#pragma warning disable 0169
		static Delegate GetSetPersistBuffer_ZHandler ()
		{
			if (cb_setPersistBuffer_Z == null)
				cb_setPersistBuffer_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPersistBuffer_Z);
			return cb_setPersistBuffer_Z;
		}

		static void n_SetPersistBuffer_Z (IntPtr jnienv, IntPtr native__this, bool persistBuffer)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PersistBuffer = persistBuffer;
		}
#pragma warning restore 0169

		public virtual unsafe bool PersistBuffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/method[@name='isPersistBuffer' and count(parameter)=0]"
			[Register ("isPersistBuffer", "()Z", "GetIsPersistBufferHandler")]
			get {
				const string __id = "isPersistBuffer.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='DisconnectedBufferOptions']/method[@name='setPersistBuffer' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPersistBuffer", "(Z)V", "GetSetPersistBuffer_ZHandler")]
			set {
				const string __id = "setPersistBuffer.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
