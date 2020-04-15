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

namespace Com.Facebook.Imagepipeline.Datasource
{
    public abstract partial class BaseListBitmapDataSubscriber : global::Com.Facebook.Datasource.BaseDataSubscriber
    {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.datasource']/class[@name='BaseListBitmapDataSubscriber']/method[@name='onNewResultImpl' and count(parameter)=1 and parameter[1][@type='com.facebook.datasource.DataSource&lt;java.util.List&lt;com.facebook.common.references.CloseableReference&lt;com.facebook.imagepipeline.image.CloseableImage&gt;&gt;&gt;']]"
		[Register("onNewResultImpl", "(Lcom/facebook/datasource/DataSource;)V", "GetOnNewResultImpl_Lcom_facebook_datasource_DataSource_Handler")]
		protected override unsafe void OnNewResultImpl(global::Com.Facebook.Datasource.IDataSource dataSource)
		{
			const string __id = "onNewResultImpl.(Lcom/facebook/datasource/DataSource;)V";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((dataSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object)dataSource).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
			}
		}
	}
}