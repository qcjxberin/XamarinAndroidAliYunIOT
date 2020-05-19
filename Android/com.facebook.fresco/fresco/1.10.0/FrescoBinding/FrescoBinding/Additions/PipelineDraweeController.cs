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
using Com.Facebook.Drawee.Interfaces;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline
{
    public partial class PipelineDraweeController : global::Com.Facebook.Drawee.Controller.AbstractDraweeController
    {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='getImageInfo' and count(parameter)=1 and parameter[1][@type='com.facebook.common.references.CloseableReference&lt;com.facebook.imagepipeline.image.CloseableImage&gt;']]"
		[Register("getImageInfo", "(Lcom/facebook/common/references/CloseableReference;)Lcom/facebook/imagepipeline/image/ImageInfo;", "GetGetImageInfo_Lcom_facebook_common_references_CloseableReference_Handler")]
		public unsafe global::Com.Facebook.Imagepipeline.Image.IImageInfo RawGetImageInfo(global::Com.Facebook.Common.References.CloseableReference image)
		{
			const string __id = "getImageInfo.(Lcom/facebook/common/references/CloseableReference;)Lcom/facebook/imagepipeline/image/ImageInfo;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object)image).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.IImageInfo>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		protected override Java.Lang.Object GetImageInfo(Java.Lang.Object p0)
		{
			return (Java.Lang.Object)RawGetImageInfo((global::Com.Facebook.Common.References.CloseableReference)p0);
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='createDrawable' and count(parameter)=1 and parameter[1][@type='com.facebook.common.references.CloseableReference&lt;com.facebook.imagepipeline.image.CloseableImage&gt;']]"
		[Register("createDrawable", "(Lcom/facebook/common/references/CloseableReference;)Landroid/graphics/drawable/Drawable;", "GetCreateDrawable_Lcom_facebook_common_references_CloseableReference_Handler")]
		public unsafe global::Android.Graphics.Drawables.Drawable RawCreateDrawable(global::Com.Facebook.Common.References.CloseableReference image)
		{
			const string __id = "createDrawable.(Lcom/facebook/common/references/CloseableReference;)Landroid/graphics/drawable/Drawable;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object)image).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
		protected override Android.Graphics.Drawables.Drawable CreateDrawable(Java.Lang.Object p0)
		{
			return RawCreateDrawable((global::Com.Facebook.Common.References.CloseableReference)p0);
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='releaseImage' and count(parameter)=1 and parameter[1][@type='com.facebook.common.references.CloseableReference&lt;com.facebook.imagepipeline.image.CloseableImage&gt;']]"
		[Register("releaseImage", "(Lcom/facebook/common/references/CloseableReference;)V", "GetReleaseImage_Lcom_facebook_common_references_CloseableReference_Handler")]
		public unsafe void RawReleaseImage(global::Com.Facebook.Common.References.CloseableReference image)
		{
			const string __id = "releaseImage.(Lcom/facebook/common/references/CloseableReference;)V";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object)image).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
			}
		}

		protected override void ReleaseImage(Java.Lang.Object p0)
		{
			RawReleaseImage((global::Com.Facebook.Common.References.CloseableReference)p0);
		}
	}
}