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
using Java.Interop;

namespace Com.Facebook.React.Views.Art
{
    public partial class ARTRenderableViewManager
    {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.react.views.art']/class[@name='ARTRenderableViewManager']/method[@name='updateExtraData' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object']]"
		[Register("updateExtraData", "(Landroid/view/View;Ljava/lang/Object;)V", "GetRawUpdateExtraData_Landroid_view_View_Ljava_lang_Object_Handler")]
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