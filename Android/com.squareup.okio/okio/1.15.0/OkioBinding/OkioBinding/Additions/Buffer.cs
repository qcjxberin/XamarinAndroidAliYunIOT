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

namespace Okio
{
    public sealed partial class Buffer : global::Java.Lang.Object, global::Java.Lang.ICloneable, global::Okio.IBufferedSink, global::Okio.IBufferedSource
    {
        unsafe global::Okio.Buffer global::Okio.IBufferedSink.Buffer() 
        {
            return InvokeBuffer();
        }
        unsafe global::Okio.Buffer global::Okio.IBufferedSource.Buffer()
        {
            return InvokeBuffer();
        }

        global::Okio.IBufferedSink global::Okio.IBufferedSink.EmitCompleteSegments() 
        {
            return EmitCompleteSegments();
        }

        global::Okio.IBufferedSink global::Okio.IBufferedSink.Write(byte[] p0)
        {
            return Write(p0);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.Write(byte[] p0, int p1, int p2)
        {
            return Write(p0, p1, p2);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.Write(global::Okio.ByteString p0)
        {
            return Write(p0);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteByte(int p0)
        {
            return WriteByte(p0);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteDecimalLong(long p0) 
        {
            return WriteDecimalLong(p0);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteHexadecimalUnsignedLong(long p0)
        {
            return WriteHexadecimalUnsignedLong(p0);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteInt(int p0) 
        {
            return WriteInt(p0);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteIntLe(int p0) 
        {
            return WriteIntLe(p0);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteLong(long p0) 
        {
            return WriteLong(p0);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteLongLe(long p0) 
        {
            return WriteLongLe(p0);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteShort(int p0) 
        {
            return WriteShort(p0);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteShortLe(int p0)
        {
            return WriteShortLe(p0);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteString(string p0, int p1, int p2, global::Java.Nio.Charset.Charset p3) 
        {
            return WriteString(p0, p1, p2, p3);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteString(string p0, global::Java.Nio.Charset.Charset p1)
        {
            return WriteString(p0, p1);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteUtf8(string p0) 
        {
            return WriteUtf8(p0);
        }
        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteUtf8(string p0, int p1, int p2) 
        {
            return WriteUtf8(p0, p1, p2);
        }


        global::Okio.IBufferedSink global::Okio.IBufferedSink.WriteUtf8CodePoint(int p0)
        {
            return WriteUtf8CodePoint(p0);
        }
    }
}