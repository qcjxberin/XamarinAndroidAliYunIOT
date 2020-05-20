using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/FadeDrawable", DoNotGenerateAcw=true)]
	public partial class FadeDrawable : global::Com.Facebook.Drawee.Drawable.ArrayDrawable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/field[@name='TRANSITION_NONE']"
		[Register ("TRANSITION_NONE")]
		public const int TransitionNone = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/field[@name='TRANSITION_RUNNING']"
		[Register ("TRANSITION_RUNNING")]
		public const int TransitionRunning = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/field[@name='TRANSITION_STARTING']"
		[Register ("TRANSITION_STARTING")]
		public const int TransitionStarting = (int) 0;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/FadeDrawable", typeof (FadeDrawable));
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

		protected FadeDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/constructor[@name='FadeDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable[]']]"
		[Register (".ctor", "([Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe FadeDrawable (global::Android.Graphics.Drawables.Drawable[] layers)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Landroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_layers = JNIEnv.NewArray (layers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_layers);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (layers != null) {
					JNIEnv.CopyArray (native_layers, layers);
					JNIEnv.DeleteLocalRef (native_layers);
				}
			}
		}

		static Delegate cb_getCurrentTimeMs;
#pragma warning disable 0169
		static Delegate GetGetCurrentTimeMsHandler ()
		{
			if (cb_getCurrentTimeMs == null)
				cb_getCurrentTimeMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCurrentTimeMs);
			return cb_getCurrentTimeMs;
		}

		static long n_GetCurrentTimeMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTimeMs;
		}
#pragma warning restore 0169

		protected virtual unsafe long CurrentTimeMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='getCurrentTimeMs' and count(parameter)=0]"
			[Register ("getCurrentTimeMs", "()J", "GetGetCurrentTimeMsHandler")]
			get {
				const string __id = "getCurrentTimeMs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTransitionDuration;
#pragma warning disable 0169
		static Delegate GetGetTransitionDurationHandler ()
		{
			if (cb_getTransitionDuration == null)
				cb_getTransitionDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTransitionDuration);
			return cb_getTransitionDuration;
		}

		static int n_GetTransitionDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TransitionDuration;
		}
#pragma warning restore 0169

		static Delegate cb_setTransitionDuration_I;
#pragma warning disable 0169
		static Delegate GetSetTransitionDuration_IHandler ()
		{
			if (cb_setTransitionDuration_I == null)
				cb_setTransitionDuration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTransitionDuration_I);
			return cb_setTransitionDuration_I;
		}

		static void n_SetTransitionDuration_I (IntPtr jnienv, IntPtr native__this, int durationMs)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TransitionDuration = durationMs;
		}
#pragma warning restore 0169

		public virtual unsafe int TransitionDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='getTransitionDuration' and count(parameter)=0]"
			[Register ("getTransitionDuration", "()I", "GetGetTransitionDurationHandler")]
			get {
				const string __id = "getTransitionDuration.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='setTransitionDuration' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTransitionDuration", "(I)V", "GetSetTransitionDuration_IHandler")]
			set {
				const string __id = "setTransitionDuration.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTransitionState;
#pragma warning disable 0169
		static Delegate GetGetTransitionStateHandler ()
		{
			if (cb_getTransitionState == null)
				cb_getTransitionState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTransitionState);
			return cb_getTransitionState;
		}

		static int n_GetTransitionState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TransitionState;
		}
#pragma warning restore 0169

		public virtual unsafe int TransitionState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='getTransitionState' and count(parameter)=0]"
			[Register ("getTransitionState", "()I", "GetGetTransitionStateHandler")]
			get {
				const string __id = "getTransitionState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_beginBatchMode;
#pragma warning disable 0169
		static Delegate GetBeginBatchModeHandler ()
		{
			if (cb_beginBatchMode == null)
				cb_beginBatchMode = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BeginBatchMode);
			return cb_beginBatchMode;
		}

		static void n_BeginBatchMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeginBatchMode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='beginBatchMode' and count(parameter)=0]"
		[Register ("beginBatchMode", "()V", "GetBeginBatchModeHandler")]
		public virtual unsafe void BeginBatchMode ()
		{
			const string __id = "beginBatchMode.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_endBatchMode;
#pragma warning disable 0169
		static Delegate GetEndBatchModeHandler ()
		{
			if (cb_endBatchMode == null)
				cb_endBatchMode = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndBatchMode);
			return cb_endBatchMode;
		}

		static void n_EndBatchMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndBatchMode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='endBatchMode' and count(parameter)=0]"
		[Register ("endBatchMode", "()V", "GetEndBatchModeHandler")]
		public virtual unsafe void EndBatchMode ()
		{
			const string __id = "endBatchMode.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fadeInAllLayers;
#pragma warning disable 0169
		static Delegate GetFadeInAllLayersHandler ()
		{
			if (cb_fadeInAllLayers == null)
				cb_fadeInAllLayers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FadeInAllLayers);
			return cb_fadeInAllLayers;
		}

		static void n_FadeInAllLayers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FadeInAllLayers ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='fadeInAllLayers' and count(parameter)=0]"
		[Register ("fadeInAllLayers", "()V", "GetFadeInAllLayersHandler")]
		public virtual unsafe void FadeInAllLayers ()
		{
			const string __id = "fadeInAllLayers.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fadeInLayer_I;
#pragma warning disable 0169
		static Delegate GetFadeInLayer_IHandler ()
		{
			if (cb_fadeInLayer_I == null)
				cb_fadeInLayer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_FadeInLayer_I);
			return cb_fadeInLayer_I;
		}

		static void n_FadeInLayer_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FadeInLayer (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='fadeInLayer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fadeInLayer", "(I)V", "GetFadeInLayer_IHandler")]
		public virtual unsafe void FadeInLayer (int index)
		{
			const string __id = "fadeInLayer.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_fadeOutAllLayers;
#pragma warning disable 0169
		static Delegate GetFadeOutAllLayersHandler ()
		{
			if (cb_fadeOutAllLayers == null)
				cb_fadeOutAllLayers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FadeOutAllLayers);
			return cb_fadeOutAllLayers;
		}

		static void n_FadeOutAllLayers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FadeOutAllLayers ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='fadeOutAllLayers' and count(parameter)=0]"
		[Register ("fadeOutAllLayers", "()V", "GetFadeOutAllLayersHandler")]
		public virtual unsafe void FadeOutAllLayers ()
		{
			const string __id = "fadeOutAllLayers.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fadeOutLayer_I;
#pragma warning disable 0169
		static Delegate GetFadeOutLayer_IHandler ()
		{
			if (cb_fadeOutLayer_I == null)
				cb_fadeOutLayer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_FadeOutLayer_I);
			return cb_fadeOutLayer_I;
		}

		static void n_FadeOutLayer_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FadeOutLayer (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='fadeOutLayer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fadeOutLayer", "(I)V", "GetFadeOutLayer_IHandler")]
		public virtual unsafe void FadeOutLayer (int index)
		{
			const string __id = "fadeOutLayer.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_fadeToLayer_I;
#pragma warning disable 0169
		static Delegate GetFadeToLayer_IHandler ()
		{
			if (cb_fadeToLayer_I == null)
				cb_fadeToLayer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_FadeToLayer_I);
			return cb_fadeToLayer_I;
		}

		static void n_FadeToLayer_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FadeToLayer (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='fadeToLayer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fadeToLayer", "(I)V", "GetFadeToLayer_IHandler")]
		public virtual unsafe void FadeToLayer (int index)
		{
			const string __id = "fadeToLayer.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_fadeUpToLayer_I;
#pragma warning disable 0169
		static Delegate GetFadeUpToLayer_IHandler ()
		{
			if (cb_fadeUpToLayer_I == null)
				cb_fadeUpToLayer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_FadeUpToLayer_I);
			return cb_fadeUpToLayer_I;
		}

		static void n_FadeUpToLayer_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FadeUpToLayer (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='fadeUpToLayer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fadeUpToLayer", "(I)V", "GetFadeUpToLayer_IHandler")]
		public virtual unsafe void FadeUpToLayer (int index)
		{
			const string __id = "fadeUpToLayer.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_finishTransitionImmediately;
#pragma warning disable 0169
		static Delegate GetFinishTransitionImmediatelyHandler ()
		{
			if (cb_finishTransitionImmediately == null)
				cb_finishTransitionImmediately = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinishTransitionImmediately);
			return cb_finishTransitionImmediately;
		}

		static void n_FinishTransitionImmediately (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishTransitionImmediately ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='finishTransitionImmediately' and count(parameter)=0]"
		[Register ("finishTransitionImmediately", "()V", "GetFinishTransitionImmediatelyHandler")]
		public virtual unsafe void FinishTransitionImmediately ()
		{
			const string __id = "finishTransitionImmediately.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_isLayerOn_I;
#pragma warning disable 0169
		static Delegate GetIsLayerOn_IHandler ()
		{
			if (cb_isLayerOn_I == null)
				cb_isLayerOn_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsLayerOn_I);
			return cb_isLayerOn_I;
		}

		static bool n_IsLayerOn_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLayerOn (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='isLayerOn' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLayerOn", "(I)Z", "GetIsLayerOn_IHandler")]
		public virtual unsafe bool IsLayerOn (int index)
		{
			const string __id = "isLayerOn.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
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
			global::Com.Facebook.Drawee.Drawable.FadeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.FadeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='FadeDrawable']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
