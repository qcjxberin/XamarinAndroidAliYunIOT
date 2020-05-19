using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Facebook.Common.Memory;
using Java.Interop;

namespace Com.Facebook.Imagepipeline.Memory
{
	public partial class NativePooledByteBufferFactory
	{

		public IPooledByteBuffer NewByteBuffer(byte[] p0)
		{
			return RawNewByteBuffer(p0);
		}

		public IPooledByteBuffer NewByteBuffer(int p0) 
		{
			return RawNewByteBuffer(p0);
		}

		public IPooledByteBuffer NewByteBuffer(Stream p0) 
		{
			return RawNewByteBuffer(p0);
		}

		public IPooledByteBuffer NewByteBuffer(Stream p0, int p1)
		{
			return RawNewByteBuffer(p0, p1);
		}

		public PooledByteBufferOutputStream NewOutputStream() 
		{
			return RawNewOutputStream();
		}

		public PooledByteBufferOutputStream NewOutputStream(int p0) 
		{
			return RawNewOutputStream(p0);
		}
	}
}