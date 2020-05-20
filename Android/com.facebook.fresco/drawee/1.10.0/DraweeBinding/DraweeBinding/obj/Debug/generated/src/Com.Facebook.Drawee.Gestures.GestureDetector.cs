using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.gestures']/class[@name='GestureDetector']"
	[global::Android.Runtime.Register ("com/facebook/drawee/gestures/GestureDetector", DoNotGenerateAcw=true)]
	public partial class GestureDetector : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.gestures']/interface[@name='GestureDetector.ClickListener']"
		[Register ("com/facebook/drawee/gestures/GestureDetector$ClickListener", "", "Com.Facebook.Drawee.Gestures.GestureDetector/IClickListenerInvoker")]
		public partial interface IClickListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.gestures']/interface[@name='GestureDetector.ClickListener']/method[@name='onClick' and count(parameter)=0]"
			[Register ("onClick", "()Z", "GetOnClickHandler:Com.Facebook.Drawee.Gestures.GestureDetector/IClickListenerInvoker, DraweeBinding")]
			bool OnClick ();

		}

		[global::Android.Runtime.Register ("com/facebook/drawee/gestures/GestureDetector$ClickListener", DoNotGenerateAcw=true)]
		internal partial class IClickListenerInvoker : global::Java.Lang.Object, IClickListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/gestures/GestureDetector$ClickListener", typeof (IClickListenerInvoker));

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

			public static IClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.gestures.GestureDetector.ClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onClick;
#pragma warning disable 0169
			static Delegate GetOnClickHandler ()
			{
				if (cb_onClick == null)
					cb_onClick = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnClick);
				return cb_onClick;
			}

			static bool n_OnClick (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnClick ();
			}
#pragma warning restore 0169

			IntPtr id_onClick;
			public unsafe bool OnClick ()
			{
				if (id_onClick == IntPtr.Zero)
					id_onClick = JNIEnv.GetMethodID (class_ref, "onClick", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onClick);
			}

		}

		// event args for com.facebook.drawee.gestures.GestureDetector.ClickListener.onClick
		public partial class ClickEventArgs : global::System.EventArgs {

			public ClickEventArgs (bool handled)
			{
				this.handled = handled;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/facebook/drawee/gestures/GestureDetector_ClickListenerImplementor")]
		internal sealed partial class IClickListenerImplementor : global::Java.Lang.Object, IClickListener {

			object sender;

			public IClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/drawee/gestures/GestureDetector_ClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnClick ()
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new ClickEventArgs (true);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/gestures/GestureDetector", typeof (GestureDetector));
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

		protected GestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.gestures']/class[@name='GestureDetector']/constructor[@name='GestureDetector' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe GestureDetector (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isCapturingGesture;
#pragma warning disable 0169
		static Delegate GetIsCapturingGestureHandler ()
		{
			if (cb_isCapturingGesture == null)
				cb_isCapturingGesture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCapturingGesture);
			return cb_isCapturingGesture;
		}

		static bool n_IsCapturingGesture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Gestures.GestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Gestures.GestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCapturingGesture;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCapturingGesture {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.gestures']/class[@name='GestureDetector']/method[@name='isCapturingGesture' and count(parameter)=0]"
			[Register ("isCapturingGesture", "()Z", "GetIsCapturingGestureHandler")]
			get {
				const string __id = "isCapturingGesture.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Gestures.GestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Gestures.GestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.gestures']/class[@name='GestureDetector']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			const string __id = "init.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.gestures']/class[@name='GestureDetector']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("newInstance", "(Landroid/content/Context;)Lcom/facebook/drawee/gestures/GestureDetector;", "")]
		public static unsafe global::Com.Facebook.Drawee.Gestures.GestureDetector NewInstance (global::Android.Content.Context context)
		{
			const string __id = "newInstance.(Landroid/content/Context;)Lcom/facebook/drawee/gestures/GestureDetector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Gestures.GestureDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Facebook.Drawee.Gestures.GestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Gestures.GestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.gestures']/class[@name='GestureDetector']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouchEvent (global::Android.Views.MotionEvent e)
		{
			const string __id = "onTouchEvent.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Gestures.GestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Gestures.GestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.gestures']/class[@name='GestureDetector']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setClickListener_Lcom_facebook_drawee_gestures_GestureDetector_ClickListener_;
#pragma warning disable 0169
		static Delegate GetSetClickListener_Lcom_facebook_drawee_gestures_GestureDetector_ClickListener_Handler ()
		{
			if (cb_setClickListener_Lcom_facebook_drawee_gestures_GestureDetector_ClickListener_ == null)
				cb_setClickListener_Lcom_facebook_drawee_gestures_GestureDetector_ClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClickListener_Lcom_facebook_drawee_gestures_GestureDetector_ClickListener_);
			return cb_setClickListener_Lcom_facebook_drawee_gestures_GestureDetector_ClickListener_;
		}

		static void n_SetClickListener_Lcom_facebook_drawee_gestures_GestureDetector_ClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clickListener)
		{
			global::Com.Facebook.Drawee.Gestures.GestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Gestures.GestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListener clickListener = (global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListener> (native_clickListener, JniHandleOwnership.DoNotTransfer);
			__this.SetClickListener (clickListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.gestures']/class[@name='GestureDetector']/method[@name='setClickListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.gestures.GestureDetector.ClickListener']]"
		[Register ("setClickListener", "(Lcom/facebook/drawee/gestures/GestureDetector$ClickListener;)V", "GetSetClickListener_Lcom_facebook_drawee_gestures_GestureDetector_ClickListener_Handler")]
		public virtual unsafe void SetClickListener (global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListener clickListener)
		{
			const string __id = "setClickListener.(Lcom/facebook/drawee/gestures/GestureDetector$ClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clickListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Facebook.Drawee.Gestures.GestureDetector.IClickListener"
		public event EventHandler<global::Com.Facebook.Drawee.Gestures.GestureDetector.ClickEventArgs> Click {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListener, global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListenerImplementor>(
						ref weak_implementor_SetClickListener,
						__CreateIClickListenerImplementor,
						SetClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListener, global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListenerImplementor>(
						ref weak_implementor_SetClickListener,
						global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListenerImplementor.__IsEmpty,
						__v => SetClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetClickListener;

		global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListenerImplementor __CreateIClickListenerImplementor ()
		{
			return new global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListenerImplementor (this);
		}
#endregion
	}
}
