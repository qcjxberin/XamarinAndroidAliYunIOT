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

namespace Com.Facebook.React.Views.Text
{
    public partial class ReactRawTextManager
    {
		static Delegate cb_updateExtraData_Landroid_view_View_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUpdateExtraData_Landroid_view_View_Ljava_lang_Object_Handler()
		{
			if (cb_updateExtraData_Landroid_view_View_Ljava_lang_Object_ == null)
				cb_updateExtraData_Landroid_view_View_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr>)n_UpdateExtraData_Landroid_view_View_Ljava_lang_Object_);
			return cb_updateExtraData_Landroid_view_View_Ljava_lang_Object_;
		}

		static void n_UpdateExtraData_Landroid_view_View_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_extraData)
		{
			global::Com.Facebook.React.Views.Text.ReactRawTextManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.React.Views.Text.ReactRawTextManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View>(native_view, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object extraData = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_extraData, JniHandleOwnership.DoNotTransfer);
			__this.UpdateExtraData(view, extraData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.react.views.text']/class[@name='ReactRawTextManager']/method[@name='updateExtraData' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object']]"
		[Register("updateExtraData", "(Landroid/view/View;Ljava/lang/Object;)V", "GetUpdateExtraData_Landroid_view_View_Ljava_lang_Object_Handler")]
		public unsafe void RawUpdateExtraData(global::Android.Views.View view, global::Java.Lang.Object extraData)
		{
			const string __id = "updateExtraData.(Landroid/view/View;Ljava/lang/Object;)V";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[2];
				__args[0] = new JniArgumentValue((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object)view).Handle);
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

		protected override Java.Lang.Object CreateViewInstance(ThemedReactContext p0)
		{
			return RawCreateViewInstance(p0);
		}
	}
}