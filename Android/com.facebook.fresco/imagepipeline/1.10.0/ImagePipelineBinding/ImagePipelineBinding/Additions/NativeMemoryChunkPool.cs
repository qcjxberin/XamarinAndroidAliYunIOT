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
    public partial class NativeMemoryChunkPool
	{
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.memory']/class[@name='NativeMemoryChunkPool']/method[@name='alloc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("alloc", "(I)Lcom/facebook/imagepipeline/memory/NativeMemoryChunk;", "GetAlloc_IHandler")]
		public unsafe global::Com.Facebook.Imagepipeline.Memory.NativeMemoryChunk RawAlloc(int bucketedSize)
		{
			const string __id = "alloc.(I)Lcom/facebook/imagepipeline/memory/NativeMemoryChunk;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(bucketedSize);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Memory.NativeMemoryChunk>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
		protected override Java.Lang.Object Alloc(int p0)
		{
			return RawAlloc(p0);
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.memory']/class[@name='NativeMemoryChunkPool']/method[@name='free' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.memory.NativeMemoryChunk']]"
		[Register("free", "(Lcom/facebook/imagepipeline/memory/NativeMemoryChunk;)V", "GetFree_Lcom_facebook_imagepipeline_memory_NativeMemoryChunk_Handler")]
		public unsafe void RawFree(global::Com.Facebook.Imagepipeline.Memory.NativeMemoryChunk value)
		{
			const string __id = "free.(Lcom/facebook/imagepipeline/memory/NativeMemoryChunk;)V";
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
			RawFree((global::Com.Facebook.Imagepipeline.Memory.NativeMemoryChunk)p0);
		}
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.memory']/class[@name='NativeMemoryChunkPool']/method[@name='getBucketedSizeForValue' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.memory.NativeMemoryChunk']]"
		[Register("getBucketedSizeForValue", "(Lcom/facebook/imagepipeline/memory/NativeMemoryChunk;)I", "GetGetBucketedSizeForValue_Lcom_facebook_imagepipeline_memory_NativeMemoryChunk_Handler")]
		public unsafe int RawGetBucketedSizeForValue(global::Com.Facebook.Imagepipeline.Memory.NativeMemoryChunk value)
		{
			const string __id = "getBucketedSizeForValue.(Lcom/facebook/imagepipeline/memory/NativeMemoryChunk;)I";
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
			return RawGetBucketedSizeForValue((global::Com.Facebook.Imagepipeline.Memory.NativeMemoryChunk)p0);
		}
	}
}