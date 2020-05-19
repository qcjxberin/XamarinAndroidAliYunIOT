using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Facebook.React.Uimanager;
using Java.Interop;

namespace Com.Facebook.React.Views.Text.Frescosupport
{
    public partial class FrescoBasedReactTextInlineImageViewManager
    {
		static Delegate cb_createViewInstance_Lcom_facebook_react_uimanager_ThemedReactContext_;
#pragma warning disable 0169
		static Delegate GetCreateViewInstance_Lcom_facebook_react_uimanager_ThemedReactContext_Handler()
		{
			if (cb_createViewInstance_Lcom_facebook_react_uimanager_ThemedReactContext_ == null)
				cb_createViewInstance_Lcom_facebook_react_uimanager_ThemedReactContext_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_CreateViewInstance_Lcom_facebook_react_uimanager_ThemedReactContext_);
			return cb_createViewInstance_Lcom_facebook_react_uimanager_ThemedReactContext_;
		}

		static IntPtr n_CreateViewInstance_Lcom_facebook_react_uimanager_ThemedReactContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Facebook.React.Views.Text.Frescosupport.FrescoBasedReactTextInlineImageViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.React.Views.Text.Frescosupport.FrescoBasedReactTextInlineImageViewManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.React.Uimanager.ThemedReactContext context = global::Java.Lang.Object.GetObject<global::Com.Facebook.React.Uimanager.ThemedReactContext>(native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.CreateViewInstance(context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.react.views.text.frescosupport']/class[@name='FrescoBasedReactTextInlineImageViewManager']/method[@name='createViewInstance' and count(parameter)=1 and parameter[1][@type='com.facebook.react.uimanager.ThemedReactContext']]"
		[Register("createViewInstance", "(Lcom/facebook/react/uimanager/ThemedReactContext;)Landroid/view/View;", "GetCreateViewInstance_Lcom_facebook_react_uimanager_ThemedReactContext_Handler")]
		public unsafe global::Android.Views.View RawCreateViewInstance(global::Com.Facebook.React.Uimanager.ThemedReactContext context)
		{
			const string __id = "createViewInstance.(Lcom/facebook/react/uimanager/ThemedReactContext;)Landroid/view/View;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		protected override Java.Lang.Object CreateViewInstance(ThemedReactContext p0)
		{
			return RawCreateViewInstance(p0);
		}

		static Delegate cb_updateExtraData_Landroid_view_View_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUpdateExtraData_Landroid_view_View_Ljava_lang_Object_Handler()
		{
			if (cb_updateExtraData_Landroid_view_View_Ljava_lang_Object_ == null)
				cb_updateExtraData_Landroid_view_View_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr>)n_UpdateExtraData_Landroid_view_View_Ljava_lang_Object_);
			return cb_updateExtraData_Landroid_view_View_Ljava_lang_Object_;
		}

		static void n_UpdateExtraData_Landroid_view_View_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_root, IntPtr native_extraData)
		{
			global::Com.Facebook.React.Views.Text.Frescosupport.FrescoBasedReactTextInlineImageViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.React.Views.Text.Frescosupport.FrescoBasedReactTextInlineImageViewManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View root = global::Java.Lang.Object.GetObject<global::Android.Views.View>(native_root, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object extraData = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_extraData, JniHandleOwnership.DoNotTransfer);
			__this.UpdateExtraData(root, extraData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.react.views.text.frescosupport']/class[@name='FrescoBasedReactTextInlineImageViewManager']/method[@name='updateExtraData' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object']]"
		[Register("updateExtraData", "(Landroid/view/View;Ljava/lang/Object;)V", "GetUpdateExtraData_Landroid_view_View_Ljava_lang_Object_Handler")]
		public unsafe void RawUpdateExtraData(global::Android.Views.View root, global::Java.Lang.Object extraData)
		{
			const string __id = "updateExtraData.(Landroid/view/View;Ljava/lang/Object;)V";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[2];
				__args[0] = new JniArgumentValue((root == null) ? IntPtr.Zero : ((global::Java.Lang.Object)root).Handle);
				__args[1] = new JniArgumentValue((extraData == null) ? IntPtr.Zero : ((global::Java.Lang.Object)extraData).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
			}
		}

		public override void UpdateExtraData(Java.Lang.Object p0, Java.Lang.Object p1)
		{
			RawUpdateExtraData(p0 as Android.Views.View, p1);
		}
	}
}