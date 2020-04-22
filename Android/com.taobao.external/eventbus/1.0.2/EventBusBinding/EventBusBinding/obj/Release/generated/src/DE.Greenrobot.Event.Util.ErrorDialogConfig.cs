using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace DE.Greenrobot.Event.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogConfig']"
	[global::Android.Runtime.Register ("de/greenrobot/event/util/ErrorDialogConfig", DoNotGenerateAcw=true)]
	public partial class ErrorDialogConfig : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/util/ErrorDialogConfig", typeof (ErrorDialogConfig));
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

		protected ErrorDialogConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogConfig']/constructor[@name='ErrorDialogConfig' and count(parameter)=3 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/res/Resources;II)V", "")]
		public unsafe ErrorDialogConfig (global::Android.Content.Res.Resources resources, int defaultTitleId, int defaultMsgId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/res/Resources;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((resources == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resources).Handle);
				__args [1] = new JniArgumentValue (defaultTitleId);
				__args [2] = new JniArgumentValue (defaultMsgId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addMapping_Ljava_lang_Class_I;
#pragma warning disable 0169
		static Delegate GetAddMapping_Ljava_lang_Class_IHandler ()
		{
			if (cb_addMapping_Ljava_lang_Class_I == null)
				cb_addMapping_Ljava_lang_Class_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_AddMapping_Ljava_lang_Class_I);
			return cb_addMapping_Ljava_lang_Class_I;
		}

		static IntPtr n_AddMapping_Ljava_lang_Class_I (IntPtr jnienv, IntPtr native__this, IntPtr native_clazz, int msgId)
		{
			global::DE.Greenrobot.Event.Util.ErrorDialogConfig __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class clazz = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_clazz, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMapping (clazz, msgId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogConfig']/method[@name='addMapping' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? extends java.lang.Throwable&gt;'] and parameter[2][@type='int']]"
		[Register ("addMapping", "(Ljava/lang/Class;I)Lde/greenrobot/event/util/ErrorDialogConfig;", "GetAddMapping_Ljava_lang_Class_IHandler")]
		public virtual unsafe global::DE.Greenrobot.Event.Util.ErrorDialogConfig AddMapping (global::Java.Lang.Class clazz, int msgId)
		{
			const string __id = "addMapping.(Ljava/lang/Class;I)Lde/greenrobot/event/util/ErrorDialogConfig;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (msgId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disableExceptionLogging;
#pragma warning disable 0169
		static Delegate GetDisableExceptionLoggingHandler ()
		{
			if (cb_disableExceptionLogging == null)
				cb_disableExceptionLogging = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableExceptionLogging);
			return cb_disableExceptionLogging;
		}

		static void n_DisableExceptionLogging (IntPtr jnienv, IntPtr native__this)
		{
			global::DE.Greenrobot.Event.Util.ErrorDialogConfig __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableExceptionLogging ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogConfig']/method[@name='disableExceptionLogging' and count(parameter)=0]"
		[Register ("disableExceptionLogging", "()V", "GetDisableExceptionLoggingHandler")]
		public virtual unsafe void DisableExceptionLogging ()
		{
			const string __id = "disableExceptionLogging.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getMessageIdForThrowable_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetGetMessageIdForThrowable_Ljava_lang_Throwable_Handler ()
		{
			if (cb_getMessageIdForThrowable_Ljava_lang_Throwable_ == null)
				cb_getMessageIdForThrowable_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetMessageIdForThrowable_Ljava_lang_Throwable_);
			return cb_getMessageIdForThrowable_Ljava_lang_Throwable_;
		}

		static int n_GetMessageIdForThrowable_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_throwable)
		{
			global::DE.Greenrobot.Event.Util.ErrorDialogConfig __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetMessageIdForThrowable (throwable);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogConfig']/method[@name='getMessageIdForThrowable' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getMessageIdForThrowable", "(Ljava/lang/Throwable;)I", "GetGetMessageIdForThrowable_Ljava_lang_Throwable_Handler")]
		public virtual unsafe int GetMessageIdForThrowable (global::Java.Lang.Throwable throwable)
		{
			const string __id = "getMessageIdForThrowable.(Ljava/lang/Throwable;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setDefaultDialogIconId_I;
#pragma warning disable 0169
		static Delegate GetSetDefaultDialogIconId_IHandler ()
		{
			if (cb_setDefaultDialogIconId_I == null)
				cb_setDefaultDialogIconId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDefaultDialogIconId_I);
			return cb_setDefaultDialogIconId_I;
		}

		static void n_SetDefaultDialogIconId_I (IntPtr jnienv, IntPtr native__this, int defaultDialogIconId)
		{
			global::DE.Greenrobot.Event.Util.ErrorDialogConfig __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultDialogIconId (defaultDialogIconId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogConfig']/method[@name='setDefaultDialogIconId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDefaultDialogIconId", "(I)V", "GetSetDefaultDialogIconId_IHandler")]
		public virtual unsafe void SetDefaultDialogIconId (int defaultDialogIconId)
		{
			const string __id = "setDefaultDialogIconId.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (defaultDialogIconId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDefaultEventTypeOnDialogClosed_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSetDefaultEventTypeOnDialogClosed_Ljava_lang_Class_Handler ()
		{
			if (cb_setDefaultEventTypeOnDialogClosed_Ljava_lang_Class_ == null)
				cb_setDefaultEventTypeOnDialogClosed_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultEventTypeOnDialogClosed_Ljava_lang_Class_);
			return cb_setDefaultEventTypeOnDialogClosed_Ljava_lang_Class_;
		}

		static void n_SetDefaultEventTypeOnDialogClosed_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_defaultEventTypeOnDialogClosed)
		{
			global::DE.Greenrobot.Event.Util.ErrorDialogConfig __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class defaultEventTypeOnDialogClosed = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_defaultEventTypeOnDialogClosed, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultEventTypeOnDialogClosed (defaultEventTypeOnDialogClosed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogConfig']/method[@name='setDefaultEventTypeOnDialogClosed' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("setDefaultEventTypeOnDialogClosed", "(Ljava/lang/Class;)V", "GetSetDefaultEventTypeOnDialogClosed_Ljava_lang_Class_Handler")]
		public virtual unsafe void SetDefaultEventTypeOnDialogClosed (global::Java.Lang.Class defaultEventTypeOnDialogClosed)
		{
			const string __id = "setDefaultEventTypeOnDialogClosed.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((defaultEventTypeOnDialogClosed == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultEventTypeOnDialogClosed).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setEventBus_Lde_greenrobot_event_EventBus_;
#pragma warning disable 0169
		static Delegate GetSetEventBus_Lde_greenrobot_event_EventBus_Handler ()
		{
			if (cb_setEventBus_Lde_greenrobot_event_EventBus_ == null)
				cb_setEventBus_Lde_greenrobot_event_EventBus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventBus_Lde_greenrobot_event_EventBus_);
			return cb_setEventBus_Lde_greenrobot_event_EventBus_;
		}

		static void n_SetEventBus_Lde_greenrobot_event_EventBus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventBus)
		{
			global::DE.Greenrobot.Event.Util.ErrorDialogConfig __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::DE.Greenrobot.Event.EventBus eventBus = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (native_eventBus, JniHandleOwnership.DoNotTransfer);
			__this.SetEventBus (eventBus);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogConfig']/method[@name='setEventBus' and count(parameter)=1 and parameter[1][@type='de.greenrobot.event.EventBus']]"
		[Register ("setEventBus", "(Lde/greenrobot/event/EventBus;)V", "GetSetEventBus_Lde_greenrobot_event_EventBus_Handler")]
		public virtual unsafe void SetEventBus (global::DE.Greenrobot.Event.EventBus eventBus)
		{
			const string __id = "setEventBus.(Lde/greenrobot/event/EventBus;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventBus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventBus).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTagForLoggingExceptions_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTagForLoggingExceptions_Ljava_lang_String_Handler ()
		{
			if (cb_setTagForLoggingExceptions_Ljava_lang_String_ == null)
				cb_setTagForLoggingExceptions_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTagForLoggingExceptions_Ljava_lang_String_);
			return cb_setTagForLoggingExceptions_Ljava_lang_String_;
		}

		static void n_SetTagForLoggingExceptions_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tagForLoggingExceptions)
		{
			global::DE.Greenrobot.Event.Util.ErrorDialogConfig __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tagForLoggingExceptions = JNIEnv.GetString (native_tagForLoggingExceptions, JniHandleOwnership.DoNotTransfer);
			__this.SetTagForLoggingExceptions (tagForLoggingExceptions);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogConfig']/method[@name='setTagForLoggingExceptions' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTagForLoggingExceptions", "(Ljava/lang/String;)V", "GetSetTagForLoggingExceptions_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTagForLoggingExceptions (string tagForLoggingExceptions)
		{
			const string __id = "setTagForLoggingExceptions.(Ljava/lang/String;)V";
			IntPtr native_tagForLoggingExceptions = JNIEnv.NewString (tagForLoggingExceptions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tagForLoggingExceptions);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tagForLoggingExceptions);
			}
		}

	}
}
