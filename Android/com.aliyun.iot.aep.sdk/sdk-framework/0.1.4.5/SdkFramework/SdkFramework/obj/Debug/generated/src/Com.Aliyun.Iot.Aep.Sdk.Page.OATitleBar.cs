using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Page {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='OATitleBar']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/page/OATitleBar", DoNotGenerateAcw=true)]
	public partial class OATitleBar : global::Android.Widget.LinearLayout {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='OATitleBar']/field[@name='TYPE_IMAGE']"
		[Register ("TYPE_IMAGE")]
		public const int TypeImage = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='OATitleBar']/field[@name='TYPE_SIMPLE']"
		[Register ("TYPE_SIMPLE")]
		public const int TypeSimple = (int) 1;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/page/OATitleBar", typeof (OATitleBar));
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

		protected OATitleBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='OATitleBar']/constructor[@name='OATitleBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe OATitleBar (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='OATitleBar']/constructor[@name='OATitleBar' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe OATitleBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='OATitleBar']/constructor[@name='OATitleBar' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe OATitleBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBackClickListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetBackClickListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setBackClickListener_Landroid_view_View_OnClickListener_ == null)
				cb_setBackClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackClickListener_Landroid_view_View_OnClickListener_);
			return cb_setBackClickListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetBackClickListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onClickListener)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Page.OATitleBar __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Page.OATitleBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener onClickListener = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_onClickListener, JniHandleOwnership.DoNotTransfer);
			__this.SetBackClickListener (onClickListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='OATitleBar']/method[@name='setBackClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setBackClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetBackClickListener_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetBackClickListener (global::Android.Views.View.IOnClickListener onClickListener)
		{
			const string __id = "setBackClickListener.(Landroid/view/View$OnClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Page.OATitleBar __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Page.OATitleBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (title);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='OATitleBar']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTitle (string title)
		{
			const string __id = "setTitle.(Ljava/lang/String;)V";
			IntPtr native_title = JNIEnv.NewString (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_title);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
			}
		}

		static Delegate cb_setType_I;
#pragma warning disable 0169
		static Delegate GetSetType_IHandler ()
		{
			if (cb_setType_I == null)
				cb_setType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetType_I);
			return cb_setType_I;
		}

		static void n_SetType_I (IntPtr jnienv, IntPtr native__this, int type)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Page.OATitleBar __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Page.OATitleBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetType (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='OATitleBar']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setType", "(I)V", "GetSetType_IHandler")]
		public virtual unsafe void SetType (int type)
		{
			const string __id = "setType.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setmBtnBackVisible_I;
#pragma warning disable 0169
		static Delegate GetSetmBtnBackVisible_IHandler ()
		{
			if (cb_setmBtnBackVisible_I == null)
				cb_setmBtnBackVisible_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetmBtnBackVisible_I);
			return cb_setmBtnBackVisible_I;
		}

		static void n_SetmBtnBackVisible_I (IntPtr jnienv, IntPtr native__this, int visible)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Page.OATitleBar __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Page.OATitleBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmBtnBackVisible (visible);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='OATitleBar']/method[@name='setmBtnBackVisible' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setmBtnBackVisible", "(I)V", "GetSetmBtnBackVisible_IHandler")]
		public virtual unsafe void SetmBtnBackVisible (int visible)
		{
			const string __id = "setmBtnBackVisible.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (visible);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
