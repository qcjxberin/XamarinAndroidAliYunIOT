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
using Com.Facebook.Common.Memory;

namespace Com.Facebook.Imagepipeline.Memory
{
    public partial class NativePooledByteBufferOutputStream
    {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.memory']/class[@name='NativePooledByteBufferOutputStream']/method[@name='toByteBuffer' and count(parameter)=0]"
		[Register("toByteBuffer", "()Lcom/facebook/imagepipeline/memory/NativePooledByteBuffer;", "GetToByteBufferHandler")]
		public unsafe global::Com.Facebook.Imagepipeline.Memory.NativePooledByteBuffer RawToByteBuffer()
		{
			const string __id = "toByteBuffer.()Lcom/facebook/imagepipeline/memory/NativePooledByteBuffer;";
			try
			{
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Memory.NativePooledByteBuffer>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		public override IPooledByteBuffer ToByteBuffer()
		{
			return RawToByteBuffer();
		}
	}
}