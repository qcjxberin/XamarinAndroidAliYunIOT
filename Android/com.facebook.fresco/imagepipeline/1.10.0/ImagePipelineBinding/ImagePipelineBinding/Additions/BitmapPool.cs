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

namespace Com.Facebook.Imagepipeline.Memory
{
    public partial class BitmapPool
    {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.memory']/class[@name='BitmapPool']/method[@name='getBucketedSizeForValue' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register("getBucketedSizeForValue", "(Landroid/graphics/Bitmap;)I", "GetGetBucketedSizeForValue_Landroid_graphics_Bitmap_Handler")]
		public unsafe int RawGetBucketedSizeForValue(global::Android.Graphics.Bitmap value)
		{
			const string __id = "getBucketedSizeForValue.(Landroid/graphics/Bitmap;)I";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object)value).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, __args);
				return __rm;
			}
			finally
			{
			}
		}

		protected override int GetBucketedSizeForValue(Java.Lang.Object p0)
		{
			return RawGetBucketedSizeForValue((global::Android.Graphics.Bitmap)p0);
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.memory']/class[@name='BitmapPool']/method[@name='alloc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("alloc", "(I)Landroid/graphics/Bitmap;", "GetAlloc_IHandler")]
		public unsafe global::Android.Graphics.Bitmap RawAlloc(int size)
		{
			const string __id = "alloc.(I)Landroid/graphics/Bitmap;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(size);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		protected override Java.Lang.Object Alloc(int p0)
		{
			return RawAlloc(p0);
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.memory']/class[@name='BitmapPool']/method[@name='free' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register("free", "(Landroid/graphics/Bitmap;)V", "GetFree_Landroid_graphics_Bitmap_Handler")]
		public unsafe void RawFree(global::Android.Graphics.Bitmap value)
		{
			const string __id = "free.(Landroid/graphics/Bitmap;)V";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object)value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
			}
		}

		protected override void Free(Java.Lang.Object p0)
		{
			RawFree((global::Android.Graphics.Bitmap)p0);
		}
	}
}