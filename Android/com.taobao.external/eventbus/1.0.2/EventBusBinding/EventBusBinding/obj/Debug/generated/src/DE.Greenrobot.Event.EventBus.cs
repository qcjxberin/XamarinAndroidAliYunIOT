using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace DE.Greenrobot.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']"
	[global::Android.Runtime.Register ("de/greenrobot/event/EventBus", DoNotGenerateAcw=true)]
	public partial class EventBus : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				const string __id = "TAG.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "TAG.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus.BooleanWrapper']"
		[global::Android.Runtime.Register ("de/greenrobot/event/EventBus$BooleanWrapper", DoNotGenerateAcw=true)]
		public sealed partial class BooleanWrapper : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/EventBus$BooleanWrapper", typeof (BooleanWrapper));
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

			internal BooleanWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='de.greenrobot.event']/interface[@name='EventBus.PostCallback']"
		[Register ("de/greenrobot/event/EventBus$PostCallback", "", "DE.Greenrobot.Event.EventBus/IPostCallbackInvoker")]
		public partial interface IPostCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/interface[@name='EventBus.PostCallback']/method[@name='onPostCompleted' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;de.greenrobot.event.SubscriberExceptionEvent&gt;']]"
			[Register ("onPostCompleted", "(Ljava/util/List;)V", "GetOnPostCompleted_Ljava_util_List_Handler:DE.Greenrobot.Event.EventBus/IPostCallbackInvoker, EventBus")]
			void OnPostCompleted (global::System.Collections.Generic.IList<global::DE.Greenrobot.Event.SubscriberExceptionEvent> p0);

		}

		[global::Android.Runtime.Register ("de/greenrobot/event/EventBus$PostCallback", DoNotGenerateAcw=true)]
		internal partial class IPostCallbackInvoker : global::Java.Lang.Object, IPostCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/EventBus$PostCallback", typeof (IPostCallbackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IPostCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPostCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "de.greenrobot.event.EventBus.PostCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPostCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPostCompleted_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetOnPostCompleted_Ljava_util_List_Handler ()
			{
				if (cb_onPostCompleted_Ljava_util_List_ == null)
					cb_onPostCompleted_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostCompleted_Ljava_util_List_);
				return cb_onPostCompleted_Ljava_util_List_;
			}

			static void n_OnPostCompleted_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::DE.Greenrobot.Event.EventBus.IPostCallback __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus.IPostCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::DE.Greenrobot.Event.SubscriberExceptionEvent>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPostCompleted (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPostCompleted_Ljava_util_List_;
			public unsafe void OnPostCompleted (global::System.Collections.Generic.IList<global::DE.Greenrobot.Event.SubscriberExceptionEvent> p0)
			{
				if (id_onPostCompleted_Ljava_util_List_ == IntPtr.Zero)
					id_onPostCompleted_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onPostCompleted", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::DE.Greenrobot.Event.SubscriberExceptionEvent>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPostCompleted_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/EventBus", typeof (EventBus));
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

		protected EventBus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/constructor[@name='EventBus' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventBus ()
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

		public static unsafe global::DE.Greenrobot.Event.EventBus Default {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='getDefault' and count(parameter)=0]"
			[Register ("getDefault", "()Lde/greenrobot/event/EventBus;", "")]
			get {
				const string __id = "getDefault.()Lde/greenrobot/event/EventBus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='clearCaches' and count(parameter)=0]"
		[Register ("clearCaches", "()V", "")]
		public static unsafe void ClearCaches ()
		{
			const string __id = "clearCaches.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='clearSkipMethodNameVerifications' and count(parameter)=0]"
		[Register ("clearSkipMethodNameVerifications", "()V", "")]
		public static unsafe void ClearSkipMethodNameVerifications ()
		{
			const string __id = "clearSkipMethodNameVerifications.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		static Delegate cb_configureLogSubscriberExceptions_Z;
#pragma warning disable 0169
		static Delegate GetConfigureLogSubscriberExceptions_ZHandler ()
		{
			if (cb_configureLogSubscriberExceptions_Z == null)
				cb_configureLogSubscriberExceptions_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ConfigureLogSubscriberExceptions_Z);
			return cb_configureLogSubscriberExceptions_Z;
		}

		static void n_ConfigureLogSubscriberExceptions_Z (IntPtr jnienv, IntPtr native__this, bool logSubscriberExceptions)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureLogSubscriberExceptions (logSubscriberExceptions);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='configureLogSubscriberExceptions' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("configureLogSubscriberExceptions", "(Z)V", "GetConfigureLogSubscriberExceptions_ZHandler")]
		public virtual unsafe void ConfigureLogSubscriberExceptions (bool logSubscriberExceptions)
		{
			const string __id = "configureLogSubscriberExceptions.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (logSubscriberExceptions);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getStickyEvent_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetStickyEvent_Ljava_lang_Class_Handler ()
		{
			if (cb_getStickyEvent_Ljava_lang_Class_ == null)
				cb_getStickyEvent_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStickyEvent_Ljava_lang_Class_);
			return cb_getStickyEvent_Ljava_lang_Class_;
		}

		static IntPtr n_GetStickyEvent_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventType)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetStickyEvent (eventType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='getStickyEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getStickyEvent", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetGetStickyEvent_Ljava_lang_Class_Handler")]
		public virtual unsafe global::Java.Lang.Object GetStickyEvent (global::Java.Lang.Class eventType)
		{
			const string __id = "getStickyEvent.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_post_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_Object_Handler ()
		{
			if (cb_post_Ljava_lang_Object_ == null)
				cb_post_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Post_Ljava_lang_Object_);
			return cb_post_Ljava_lang_Object_;
		}

		static void n_Post_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Post (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='post' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("post", "(Ljava/lang/Object;)V", "GetPost_Ljava_lang_Object_Handler")]
		public virtual unsafe void Post (global::Java.Lang.Object e)
		{
			const string __id = "post.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_postSticky_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPostSticky_Ljava_lang_Object_Handler ()
		{
			if (cb_postSticky_Ljava_lang_Object_ == null)
				cb_postSticky_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PostSticky_Ljava_lang_Object_);
			return cb_postSticky_Ljava_lang_Object_;
		}

		static void n_PostSticky_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.PostSticky (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='postSticky' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("postSticky", "(Ljava/lang/Object;)V", "GetPostSticky_Ljava_lang_Object_Handler")]
		public virtual unsafe void PostSticky (global::Java.Lang.Object e)
		{
			const string __id = "postSticky.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_register_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_Object_Handler ()
		{
			if (cb_register_Ljava_lang_Object_ == null)
				cb_register_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Register_Ljava_lang_Object_);
			return cb_register_Ljava_lang_Object_;
		}

		static void n_Register_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			__this.Register (subscriber);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='register' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("register", "(Ljava/lang/Object;)V", "GetRegister_Ljava_lang_Object_Handler")]
		public virtual unsafe void Register (global::Java.Lang.Object subscriber)
		{
			const string __id = "register.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_register_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_Handler ()
		{
			if (cb_register_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_ == null)
				cb_register_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_);
			return cb_register_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_;
		}

		static void n_Register_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber, IntPtr native_eventType, IntPtr native_moreEventTypes)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class[] moreEventTypes = (global::Java.Lang.Class[]) JNIEnv.GetArray (native_moreEventTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Class));
			__this.Register (subscriber, eventType, moreEventTypes);
			if (moreEventTypes != null)
				JNIEnv.CopyArray (moreEventTypes, native_moreEventTypes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='register' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("register", "(Ljava/lang/Object;Ljava/lang/Class;[Ljava/lang/Class;)V", "GetRegister_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_Handler")]
		public virtual unsafe void Register (global::Java.Lang.Object subscriber, global::Java.Lang.Class eventType, params global::Java.Lang.Class[] moreEventTypes)
		{
			const string __id = "register.(Ljava/lang/Object;Ljava/lang/Class;[Ljava/lang/Class;)V";
			IntPtr native_moreEventTypes = JNIEnv.NewArray (moreEventTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				__args [1] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				__args [2] = new JniArgumentValue (native_moreEventTypes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (moreEventTypes != null) {
					JNIEnv.CopyArray (native_moreEventTypes, moreEventTypes);
					JNIEnv.DeleteLocalRef (native_moreEventTypes);
				}
			}
		}

		static Delegate cb_register_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_register_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_register_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Ljava_lang_Object_Ljava_lang_String_);
			return cb_register_Ljava_lang_Object_Ljava_lang_String_;
		}

		static void n_Register_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber, IntPtr native_methodName)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			string methodName = JNIEnv.GetString (native_methodName, JniHandleOwnership.DoNotTransfer);
			__this.Register (subscriber, methodName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='register' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("register", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetRegister_Ljava_lang_Object_Ljava_lang_String_Handler")]
		public virtual unsafe void Register (global::Java.Lang.Object subscriber, string methodName)
		{
			const string __id = "register.(Ljava/lang/Object;Ljava/lang/String;)V";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		static Delegate cb_register_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_Handler ()
		{
			if (cb_register_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_ == null)
				cb_register_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_);
			return cb_register_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_;
		}

		static void n_Register_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber, IntPtr native_methodName, IntPtr native_eventType, IntPtr native_moreEventTypes)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			string methodName = JNIEnv.GetString (native_methodName, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class[] moreEventTypes = (global::Java.Lang.Class[]) JNIEnv.GetArray (native_moreEventTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Class));
			__this.Register (subscriber, methodName, eventType, moreEventTypes);
			if (moreEventTypes != null)
				JNIEnv.CopyArray (moreEventTypes, native_moreEventTypes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='register' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;'] and parameter[4][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("register", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;)V", "GetRegister_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_Handler")]
		public virtual unsafe void Register (global::Java.Lang.Object subscriber, string methodName, global::Java.Lang.Class eventType, params global::Java.Lang.Class[] moreEventTypes)
		{
			const string __id = "register.(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;)V";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_moreEventTypes = JNIEnv.NewArray (moreEventTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				__args [3] = new JniArgumentValue (native_moreEventTypes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (moreEventTypes != null) {
					JNIEnv.CopyArray (native_moreEventTypes, moreEventTypes);
					JNIEnv.DeleteLocalRef (native_moreEventTypes);
				}
			}
		}

		static Delegate cb_registerSticky_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRegisterSticky_Ljava_lang_Object_Handler ()
		{
			if (cb_registerSticky_Ljava_lang_Object_ == null)
				cb_registerSticky_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterSticky_Ljava_lang_Object_);
			return cb_registerSticky_Ljava_lang_Object_;
		}

		static void n_RegisterSticky_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			__this.RegisterSticky (subscriber);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='registerSticky' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("registerSticky", "(Ljava/lang/Object;)V", "GetRegisterSticky_Ljava_lang_Object_Handler")]
		public virtual unsafe void RegisterSticky (global::Java.Lang.Object subscriber)
		{
			const string __id = "registerSticky.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_registerSticky_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetRegisterSticky_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_Handler ()
		{
			if (cb_registerSticky_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_ == null)
				cb_registerSticky_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterSticky_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_);
			return cb_registerSticky_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_;
		}

		static void n_RegisterSticky_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber, IntPtr native_eventType, IntPtr native_moreEventTypes)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class[] moreEventTypes = (global::Java.Lang.Class[]) JNIEnv.GetArray (native_moreEventTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Class));
			__this.RegisterSticky (subscriber, eventType, moreEventTypes);
			if (moreEventTypes != null)
				JNIEnv.CopyArray (moreEventTypes, native_moreEventTypes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='registerSticky' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("registerSticky", "(Ljava/lang/Object;Ljava/lang/Class;[Ljava/lang/Class;)V", "GetRegisterSticky_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_Class_Handler")]
		public virtual unsafe void RegisterSticky (global::Java.Lang.Object subscriber, global::Java.Lang.Class eventType, params global::Java.Lang.Class[] moreEventTypes)
		{
			const string __id = "registerSticky.(Ljava/lang/Object;Ljava/lang/Class;[Ljava/lang/Class;)V";
			IntPtr native_moreEventTypes = JNIEnv.NewArray (moreEventTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				__args [1] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				__args [2] = new JniArgumentValue (native_moreEventTypes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (moreEventTypes != null) {
					JNIEnv.CopyArray (native_moreEventTypes, moreEventTypes);
					JNIEnv.DeleteLocalRef (native_moreEventTypes);
				}
			}
		}

		static Delegate cb_registerSticky_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterSticky_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_registerSticky_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_registerSticky_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterSticky_Ljava_lang_Object_Ljava_lang_String_);
			return cb_registerSticky_Ljava_lang_Object_Ljava_lang_String_;
		}

		static void n_RegisterSticky_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber, IntPtr native_methodName)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			string methodName = JNIEnv.GetString (native_methodName, JniHandleOwnership.DoNotTransfer);
			__this.RegisterSticky (subscriber, methodName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='registerSticky' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("registerSticky", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetRegisterSticky_Ljava_lang_Object_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterSticky (global::Java.Lang.Object subscriber, string methodName)
		{
			const string __id = "registerSticky.(Ljava/lang/Object;Ljava/lang/String;)V";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		static Delegate cb_registerSticky_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetRegisterSticky_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_Handler ()
		{
			if (cb_registerSticky_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_ == null)
				cb_registerSticky_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterSticky_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_);
			return cb_registerSticky_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_;
		}

		static void n_RegisterSticky_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber, IntPtr native_methodName, IntPtr native_eventType, IntPtr native_moreEventTypes)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			string methodName = JNIEnv.GetString (native_methodName, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class[] moreEventTypes = (global::Java.Lang.Class[]) JNIEnv.GetArray (native_moreEventTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Class));
			__this.RegisterSticky (subscriber, methodName, eventType, moreEventTypes);
			if (moreEventTypes != null)
				JNIEnv.CopyArray (moreEventTypes, native_moreEventTypes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='registerSticky' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;'] and parameter[4][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("registerSticky", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;)V", "GetRegisterSticky_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_Handler")]
		public virtual unsafe void RegisterSticky (global::Java.Lang.Object subscriber, string methodName, global::Java.Lang.Class eventType, params global::Java.Lang.Class[] moreEventTypes)
		{
			const string __id = "registerSticky.(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;)V";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_moreEventTypes = JNIEnv.NewArray (moreEventTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				__args [3] = new JniArgumentValue (native_moreEventTypes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (moreEventTypes != null) {
					JNIEnv.CopyArray (native_moreEventTypes, moreEventTypes);
					JNIEnv.DeleteLocalRef (native_moreEventTypes);
				}
			}
		}

		static Delegate cb_removeStickyEvent_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetRemoveStickyEvent_Ljava_lang_Class_Handler ()
		{
			if (cb_removeStickyEvent_Ljava_lang_Class_ == null)
				cb_removeStickyEvent_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveStickyEvent_Ljava_lang_Class_);
			return cb_removeStickyEvent_Ljava_lang_Class_;
		}

		static IntPtr n_RemoveStickyEvent_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventType)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveStickyEvent (eventType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='removeStickyEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("removeStickyEvent", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetRemoveStickyEvent_Ljava_lang_Class_Handler")]
		public virtual unsafe global::Java.Lang.Object RemoveStickyEvent (global::Java.Lang.Class eventType)
		{
			const string __id = "removeStickyEvent.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeStickyEvent_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveStickyEvent_Ljava_lang_Object_Handler ()
		{
			if (cb_removeStickyEvent_Ljava_lang_Object_ == null)
				cb_removeStickyEvent_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveStickyEvent_Ljava_lang_Object_);
			return cb_removeStickyEvent_Ljava_lang_Object_;
		}

		static bool n_RemoveStickyEvent_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveStickyEvent (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='removeStickyEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeStickyEvent", "(Ljava/lang/Object;)Z", "GetRemoveStickyEvent_Ljava_lang_Object_Handler")]
		public virtual unsafe bool RemoveStickyEvent (global::Java.Lang.Object e)
		{
			const string __id = "removeStickyEvent.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='skipMethodNameVerificationFor' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("skipMethodNameVerificationFor", "(Ljava/lang/Class;)V", "")]
		public static unsafe void SkipMethodNameVerificationFor (global::Java.Lang.Class clazz)
		{
			const string __id = "skipMethodNameVerificationFor.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_unregister_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUnregister_Ljava_lang_Object_Handler ()
		{
			if (cb_unregister_Ljava_lang_Object_ == null)
				cb_unregister_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unregister_Ljava_lang_Object_);
			return cb_unregister_Ljava_lang_Object_;
		}

		static void n_Unregister_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			__this.Unregister (subscriber);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='unregister' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("unregister", "(Ljava/lang/Object;)V", "GetUnregister_Ljava_lang_Object_Handler")]
		public virtual unsafe void Unregister (global::Java.Lang.Object subscriber)
		{
			const string __id = "unregister.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unregister_Ljava_lang_Object_arrayLjava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetUnregister_Ljava_lang_Object_arrayLjava_lang_Class_Handler ()
		{
			if (cb_unregister_Ljava_lang_Object_arrayLjava_lang_Class_ == null)
				cb_unregister_Ljava_lang_Object_arrayLjava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Unregister_Ljava_lang_Object_arrayLjava_lang_Class_);
			return cb_unregister_Ljava_lang_Object_arrayLjava_lang_Class_;
		}

		static void n_Unregister_Ljava_lang_Object_arrayLjava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber, IntPtr native_eventTypes)
		{
			global::DE.Greenrobot.Event.EventBus __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class[] eventTypes = (global::Java.Lang.Class[]) JNIEnv.GetArray (native_eventTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Class));
			__this.Unregister (subscriber, eventTypes);
			if (eventTypes != null)
				JNIEnv.CopyArray (eventTypes, native_eventTypes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='EventBus']/method[@name='unregister' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("unregister", "(Ljava/lang/Object;[Ljava/lang/Class;)V", "GetUnregister_Ljava_lang_Object_arrayLjava_lang_Class_Handler")]
		public virtual unsafe void Unregister (global::Java.Lang.Object subscriber, params global::Java.Lang.Class[] eventTypes)
		{
			const string __id = "unregister.(Ljava/lang/Object;[Ljava/lang/Class;)V";
			IntPtr native_eventTypes = JNIEnv.NewArray (eventTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				__args [1] = new JniArgumentValue (native_eventTypes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (eventTypes != null) {
					JNIEnv.CopyArray (native_eventTypes, eventTypes);
					JNIEnv.DeleteLocalRef (native_eventTypes);
				}
			}
		}

	}
}
