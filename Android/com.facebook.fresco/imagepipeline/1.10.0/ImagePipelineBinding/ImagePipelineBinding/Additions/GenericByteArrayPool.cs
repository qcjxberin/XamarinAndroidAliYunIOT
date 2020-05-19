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
    public partial class GenericByteArrayPool
    {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.memory']/class[@name='GenericByteArrayPool']/method[@name='free' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register("free", "([B)V", "GetFree_arrayBHandler")]
		public unsafe void RawFree(byte[] value)
		{
			const string __id = "free.([B)V";
			IntPtr native_value = JNIEnv.NewArray(value);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
				if (value != null)
				{
					JNIEnv.CopyArray(native_value, value);
					JNIEnv.DeleteLocalRef(native_value);
				}
			}
		}
		protected override void Free(Java.Lang.Object p0)
		{
			RawFree((byte[])p0);
		}
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.memory']/class[@name='GenericByteArrayPool']/method[@name='alloc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("alloc", "(I)[B", "GetAlloc_IHandler")]
		public unsafe byte[] RawAlloc(int bucketedSize)
		{
			const string __id = "alloc.(I)[B";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(bucketedSize);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return (byte[])JNIEnv.GetArray(__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
			}
		}
		protected override Java.Lang.Object Alloc(int p0)
		{
			return RawAlloc(p0);
		}
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.memory']/class[@name='GenericByteArrayPool']/method[@name='getBucketedSizeForValue' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register("getBucketedSizeForValue", "([B)I", "GetGetBucketedSizeForValue_arrayBHandler")]
		public unsafe int RawGetBucketedSizeForValue(byte[] value)
		{
			const string __id = "getBucketedSizeForValue.([B)I";
			IntPtr native_value = JNIEnv.NewArray(value);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, __args);
				return __rm;
			}
			finally
			{
				if (value != null)
				{
					JNIEnv.CopyArray(native_value, value);
					JNIEnv.DeleteLocalRef(native_value);
				}
			}
		}
		protected override int GetBucketedSizeForValue(Java.Lang.Object p0)
		{
			return RawGetBucketedSizeForValue((byte[])p0);
		}
	}
}