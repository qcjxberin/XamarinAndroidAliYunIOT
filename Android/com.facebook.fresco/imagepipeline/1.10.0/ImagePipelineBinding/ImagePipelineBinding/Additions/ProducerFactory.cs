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

namespace Com.Facebook.Imagepipeline.Core
{
    public partial class ProducerFactory
    {
        private const string ctorSignature = "(" +
            "Landroid/content/Context;" +
            "Lcom/facebook/common/memory/ByteArrayPool;" +
            "Lcom/facebook/imagepipeline/decoder/ImageDecoder;" +
            "Lcom/facebook/imagepipeline/decoder/ProgressiveJpegConfig;" +
            "ZZZ"+
            "Lcom/facebook/imagepipeline/core/ExecutorSupplier;" +
            "Lcom/facebook/common/memory/PooledByteBufferFactory;" +
            "Lcom/facebook/imagepipeline/cache/MemoryCache;" +
            "Lcom/facebook/imagepipeline/cache/MemoryCache;" +
            "Lcom/facebook/imagepipeline/cache/BufferedDiskCache;" +
            "Lcom/facebook/imagepipeline/cache/BufferedDiskCache;" +
            "Lcom/facebook/imagepipeline/cache/CacheKeyFactory;" +
            "Lcom/facebook/imagepipeline/bitmaps/PlatformBitmapFactory;" +
            "IIZ" +
            ")V";

        static IntPtr id_ctor_I;

        [Register(".ctor", ctorSignature, "")]
        public unsafe ProducerFactory(
            Android.Content.Context i1,
            Com.Facebook.Common.Memory.IByteArrayPool i2,
            Com.Facebook.Imagepipeline.Decoder.IImageDecoder i3,
            Com.Facebook.Imagepipeline.Decoder.IProgressiveJpegConfig i4,
            bool i5,bool i6,bool i7,
            Com.Facebook.Imagepipeline.Core.IExecutorSupplier i8,
            Com.Facebook.Common.Memory.IPooledByteBufferFactory i9,
            Com.Facebook.Imagepipeline.Cache.IMemoryCache i10,
            Com.Facebook.Imagepipeline.Cache.IMemoryCache i11,
            Com.Facebook.Imagepipeline.Cache.BufferedDiskCache i12,
            Com.Facebook.Imagepipeline.Cache.BufferedDiskCache i13,
            Com.Facebook.Imagepipeline.Cache.ICacheKeyFactory i14,
            Com.Facebook.Imagepipeline.Bitmaps.PlatformBitmapFactory i15,
            int i16,int i17,bool i18)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (Handle != IntPtr.Zero)
                return;
            if (GetType() != typeof(ProducerFactory))
            {

                SetHandle(
                        Android.Runtime.JNIEnv.CreateInstance(GetType(), ctorSignature,
                        new JValue(i1),
                        new JValue(i2),
                        new JValue(i3),
                        new JValue(i4),
                        new JValue(i5),
                        new JValue(i6),
                        new JValue(i7),
                        new JValue(i8),
                        new JValue(i9),
                        new JValue(i10),
                        new JValue(i11),
                        new JValue(i12),
                        new JValue(i13),
                        new JValue(i14),
                        new JValue(i15),
                        new JValue(i16),
                        new JValue(i17),
                        new JValue(i18)),
                        JniHandleOwnership.TransferLocalRef);
                return;
            }
            if (id_ctor_I == IntPtr.Zero)
                id_ctor_I = JNIEnv.GetMethodID(class_ref, "<init>", ctorSignature);
            SetHandle(
                    JNIEnv.NewObject(class_ref, id_ctor_I,
                    new JValue(i1),
                    new JValue(i2),
                    new JValue(i3),
                    new JValue(i4),
                    new JValue(i5),
                    new JValue(i6),
                    new JValue(i7),
                    new JValue(i8),
                    new JValue(i9),
                    new JValue(i10),
                    new JValue(i11),
                    new JValue(i12),
                    new JValue(i13),
                    new JValue(i14),
                    new JValue(i15),
                    new JValue(i16),
                    new JValue(i17),
                    new JValue(i18)),
                    JniHandleOwnership.TransferLocalRef);
        }
    }
}