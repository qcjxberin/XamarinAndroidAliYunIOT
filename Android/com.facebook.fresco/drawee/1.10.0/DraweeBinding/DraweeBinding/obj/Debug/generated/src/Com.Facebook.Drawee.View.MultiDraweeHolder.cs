using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']"
	[global::Android.Runtime.Register ("com/facebook/drawee/view/MultiDraweeHolder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"DH extends com.facebook.drawee.interfaces.DraweeHierarchy"})]
	public partial class MultiDraweeHolder : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/view/MultiDraweeHolder", typeof (MultiDraweeHolder));
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

		protected MultiDraweeHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']/constructor[@name='MultiDraweeHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MultiDraweeHolder ()
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

		static Delegate cb_add_Lcom_facebook_drawee_view_DraweeHolder_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_facebook_drawee_view_DraweeHolder_Handler ()
		{
			if (cb_add_Lcom_facebook_drawee_view_DraweeHolder_ == null)
				cb_add_Lcom_facebook_drawee_view_DraweeHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lcom_facebook_drawee_view_DraweeHolder_);
			return cb_add_Lcom_facebook_drawee_view_DraweeHolder_;
		}

		static void n_Add_Lcom_facebook_drawee_view_DraweeHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			global::Com.Facebook.Drawee.View.MultiDraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.MultiDraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.View.DraweeHolder holder = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.Add (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.view.DraweeHolder&lt;DH&gt;']]"
		[Register ("add", "(Lcom/facebook/drawee/view/DraweeHolder;)V", "GetAdd_Lcom_facebook_drawee_view_DraweeHolder_Handler")]
		public virtual unsafe void Add (global::Com.Facebook.Drawee.View.DraweeHolder holder)
		{
			const string __id = "add.(Lcom/facebook/drawee/view/DraweeHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_add_ILcom_facebook_drawee_view_DraweeHolder_;
#pragma warning disable 0169
		static Delegate GetAdd_ILcom_facebook_drawee_view_DraweeHolder_Handler ()
		{
			if (cb_add_ILcom_facebook_drawee_view_DraweeHolder_ == null)
				cb_add_ILcom_facebook_drawee_view_DraweeHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Add_ILcom_facebook_drawee_view_DraweeHolder_);
			return cb_add_ILcom_facebook_drawee_view_DraweeHolder_;
		}

		static void n_Add_ILcom_facebook_drawee_view_DraweeHolder_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_holder)
		{
			global::Com.Facebook.Drawee.View.MultiDraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.MultiDraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.View.DraweeHolder holder = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.Add (index, holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.facebook.drawee.view.DraweeHolder&lt;DH&gt;']]"
		[Register ("add", "(ILcom/facebook/drawee/view/DraweeHolder;)V", "GetAdd_ILcom_facebook_drawee_view_DraweeHolder_Handler")]
		public virtual unsafe void Add (int index, global::Com.Facebook.Drawee.View.DraweeHolder holder)
		{
			const string __id = "add.(ILcom/facebook/drawee/view/DraweeHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.MultiDraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.MultiDraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			global::Com.Facebook.Drawee.View.MultiDraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.MultiDraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public virtual unsafe void Draw (global::Android.Graphics.Canvas canvas)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Facebook.Drawee.View.MultiDraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.MultiDraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lcom/facebook/drawee/view/DraweeHolder;", "GetGet_IHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.View.DraweeHolder Get (int index)
		{
			const string __id = "get.(I)Lcom/facebook/drawee/view/DraweeHolder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onAttach;
#pragma warning disable 0169
		static Delegate GetOnAttachHandler ()
		{
			if (cb_onAttach == null)
				cb_onAttach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAttach);
			return cb_onAttach;
		}

		static void n_OnAttach (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.MultiDraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.MultiDraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAttach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']/method[@name='onAttach' and count(parameter)=0]"
		[Register ("onAttach", "()V", "GetOnAttachHandler")]
		public virtual unsafe void OnAttach ()
		{
			const string __id = "onAttach.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onDetach;
#pragma warning disable 0169
		static Delegate GetOnDetachHandler ()
		{
			if (cb_onDetach == null)
				cb_onDetach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDetach);
			return cb_onDetach;
		}

		static void n_OnDetach (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.MultiDraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.MultiDraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDetach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']/method[@name='onDetach' and count(parameter)=0]"
		[Register ("onDetach", "()V", "GetOnDetachHandler")]
		public virtual unsafe void OnDetach ()
		{
			const string __id = "onDetach.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Com.Facebook.Drawee.View.MultiDraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.MultiDraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
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

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Remove_I);
			return cb_remove_I;
		}

		static void n_Remove_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Facebook.Drawee.View.MultiDraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.MultiDraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)V", "GetRemove_IHandler")]
		public virtual unsafe void Remove (int index)
		{
			const string __id = "remove.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.MultiDraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.MultiDraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_verifyDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetVerifyDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_verifyDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_verifyDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_VerifyDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_verifyDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static bool n_VerifyDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_who)
		{
			global::Com.Facebook.Drawee.View.MultiDraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.MultiDraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable who = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_who, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.VerifyDrawable (who);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='MultiDraweeHolder']/method[@name='verifyDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", "GetVerifyDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe bool VerifyDrawable (global::Android.Graphics.Drawables.Drawable who)
		{
			const string __id = "verifyDrawable.(Landroid/graphics/drawable/Drawable;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((who == null) ? IntPtr.Zero : ((global::Java.Lang.Object) who).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
