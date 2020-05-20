using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;

namespace Com.Facebook.Imagepipeline.Core
{
    public partial class ImagePipelineExperiments
    {
        public partial interface IProducerFactoryMethod : IJavaObject, IJavaPeerable
        {
            private const string signature = "(Landroid/content/Context;Lcom/facebook/common/memory/ByteArrayPool;Lcom/facebook/imagepipeline/decoder/ImageDecoder;Lcom/facebook/imagepipeline/decoder/ProgressiveJpegConfig;ZZZLcom/facebook/imagepipeline/core/ExecutorSupplier;Lcom/facebook/common/memory/PooledByteBufferFactory;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/imagepipeline/cache/BufferedDiskCache;Lcom/facebook/imagepipeline/cache/BufferedDiskCache;Lcom/facebook/imagepipeline/cache/CacheKeyFactory;Lcom/facebook/imagepipeline/bitmaps/PlatformBitmapFactory;IIZ)Lcom/facebook/imagepipeline/core/ProducerFactory;";
            [Register("createProducerFactory",signature, "_CreateProducerFactory_Connector_:Com.Facebook.Imagepipeline.Core.ImagePipelineExperiments.IProducerFactoryMethodInvoker,ImagePipelineBinding")]            
            Com.Facebook.Imagepipeline.Core.ProducerFactory CreateProducerFactory(
                Android.Content.Context context,
                Com.Facebook.Common.Memory.IByteArrayPool byteArrayPool,
                Com.Facebook.Imagepipeline.Decoder.IImageDecoder imageDecoder,
                Com.Facebook.Imagepipeline.Decoder.IProgressiveJpegConfig progressiveJpegConfig,
                bool z, bool z2, bool z3, 
                Com.Facebook.Imagepipeline.Core.IExecutorSupplier executorSupplier,
                Com.Facebook.Common.Memory.IPooledByteBufferFactory pooledByteBufferFactory,
                Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache,
                Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache2,
                Com.Facebook.Imagepipeline.Cache.BufferedDiskCache bufferedDiskCache,
                Com.Facebook.Imagepipeline.Cache.BufferedDiskCache bufferedDiskCache2,
                Com.Facebook.Imagepipeline.Cache.ICacheKeyFactory cacheKeyFactory,
                Com.Facebook.Imagepipeline.Bitmaps.PlatformBitmapFactory platformBitmapFactory, 
                int i, int i2, bool z4);
            
        }

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        delegate IntPtr _JniMarshal_PPLLLLZZZLLLLLLLLIIZ_L(
        IntPtr jnienv, IntPtr classOrThis,
        Android.Content.Context context,
        Com.Facebook.Common.Memory.IByteArrayPool byteArrayPool,
        Com.Facebook.Imagepipeline.Decoder.IImageDecoder imageDecoder,
        Com.Facebook.Imagepipeline.Decoder.IProgressiveJpegConfig progressiveJpegConfig,
        bool z, bool z2, bool z3,
        Com.Facebook.Imagepipeline.Core.IExecutorSupplier executorSupplier,
        Com.Facebook.Common.Memory.IPooledByteBufferFactory pooledByteBufferFactory,
        Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache,
        Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache2,
        Com.Facebook.Imagepipeline.Cache.BufferedDiskCache bufferedDiskCache,
        Com.Facebook.Imagepipeline.Cache.BufferedDiskCache bufferedDiskCache2,
        Com.Facebook.Imagepipeline.Cache.ICacheKeyFactory cacheKeyFactory,
        Com.Facebook.Imagepipeline.Bitmaps.PlatformBitmapFactory platformBitmapFactory,
        int i, int i2, bool z4
            );

        partial class IProducerFactoryMethodInvoker 
        {            
            IntPtr id_CreateProducerFactory_x1;
            public unsafe Com.Facebook.Imagepipeline.Core.ProducerFactory CreateProducerFactory(
                Android.Content.Context context,
                Com.Facebook.Common.Memory.IByteArrayPool byteArrayPool,
                Com.Facebook.Imagepipeline.Decoder.IImageDecoder imageDecoder,
                Com.Facebook.Imagepipeline.Decoder.IProgressiveJpegConfig progressiveJpegConfig,
                bool z, bool z2, bool z3,
                Com.Facebook.Imagepipeline.Core.IExecutorSupplier executorSupplier,
                Com.Facebook.Common.Memory.IPooledByteBufferFactory pooledByteBufferFactory,
                Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache,
                Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache2,
                Com.Facebook.Imagepipeline.Cache.BufferedDiskCache bufferedDiskCache,
                Com.Facebook.Imagepipeline.Cache.BufferedDiskCache bufferedDiskCache2,
                Com.Facebook.Imagepipeline.Cache.ICacheKeyFactory cacheKeyFactory,
                Com.Facebook.Imagepipeline.Bitmaps.PlatformBitmapFactory platformBitmapFactory,
                int i, int i2, bool z4)
            {
                if (id_CreateProducerFactory_x1 == IntPtr.Zero)
                    id_CreateProducerFactory_x1 = JNIEnv.GetMethodID(class_ref, "createProducerFactory", "(Landroid/content/Context;Lcom/facebook/common/memory/ByteArrayPool;Lcom/facebook/imagepipeline/decoder/ImageDecoder;Lcom/facebook/imagepipeline/decoder/ProgressiveJpegConfig;ZZZLcom/facebook/imagepipeline/core/ExecutorSupplier;Lcom/facebook/common/memory/PooledByteBufferFactory;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/imagepipeline/cache/BufferedDiskCache;Lcom/facebook/imagepipeline/cache/BufferedDiskCache;Lcom/facebook/imagepipeline/cache/CacheKeyFactory;Lcom/facebook/imagepipeline/bitmaps/PlatformBitmapFactory;IIZ)Lcom/facebook/imagepipeline/core/ProducerFactory;");

                JValue* __args = stackalloc JValue[18];
                __args[0] = new JValue(context);
                __args[1] = new JValue(byteArrayPool);
                __args[2] = new JValue(imageDecoder);
                __args[3] = new JValue(progressiveJpegConfig);
                __args[4] = new JValue(z);
                __args[5] = new JValue(z2);
                __args[6] = new JValue(z3);
                __args[7] = new JValue(executorSupplier);
                __args[8] = new JValue(pooledByteBufferFactory);
                __args[9] = new JValue(memoryCache);
                __args[10] = new JValue(memoryCache2);
                __args[11] = new JValue(bufferedDiskCache);
                __args[12] = new JValue(bufferedDiskCache2);
                __args[13] = new JValue(cacheKeyFactory);
                __args[14] = new JValue(platformBitmapFactory);
                __args[15] = new JValue(i);
                __args[16] = new JValue(i2);
                __args[17] = new JValue(z4);
                IntPtr r = JNIEnv.CallObjectMethod(this.Handle, id_CreateProducerFactory_x1, __args);
                return global::Java.Lang.Object.GetObject<Com.Facebook.Imagepipeline.Core.ProducerFactory>(r, JniHandleOwnership.TransferLocalRef);
            }

            static unsafe IntPtr n_CreateProducerFactory_x1(
                IntPtr jnienv, IntPtr native__this,
                Android.Content.Context context,
                Com.Facebook.Common.Memory.IByteArrayPool byteArrayPool,
                Com.Facebook.Imagepipeline.Decoder.IImageDecoder imageDecoder,
                Com.Facebook.Imagepipeline.Decoder.IProgressiveJpegConfig progressiveJpegConfig,
                bool z, bool z2, bool z3,
                Com.Facebook.Imagepipeline.Core.IExecutorSupplier executorSupplier,
                Com.Facebook.Common.Memory.IPooledByteBufferFactory pooledByteBufferFactory,
                Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache,
                Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache2,
                Com.Facebook.Imagepipeline.Cache.BufferedDiskCache bufferedDiskCache,
                Com.Facebook.Imagepipeline.Cache.BufferedDiskCache bufferedDiskCache2,
                Com.Facebook.Imagepipeline.Cache.ICacheKeyFactory cacheKeyFactory,
                Com.Facebook.Imagepipeline.Bitmaps.PlatformBitmapFactory platformBitmapFactory,
                int i, int i2, bool z4)
            {
                IProducerFactoryMethod __this = global::Java.Lang.Object.GetObject<IProducerFactoryMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                Com.Facebook.Imagepipeline.Core.ProducerFactory rv = __this.CreateProducerFactory(
                    context,
                    byteArrayPool,
                    imageDecoder,
                    progressiveJpegConfig,
                    z, z2, z3,
                    executorSupplier,
                    pooledByteBufferFactory,
                    memoryCache,
                    memoryCache2,
                    bufferedDiskCache,
                    bufferedDiskCache2,
                    cacheKeyFactory,
                    platformBitmapFactory,
                    i, i2, z4
                    );

                IntPtr __ret = JNIEnv.ToLocalJniHandle(rv);
                return __ret;
            }

            static Delegate cb_CreateProducerFactory_x1;
            static Delegate _CreateProducerFactory_Connector_()
            {
                if (cb_CreateProducerFactory_x1 == null)
                    cb_CreateProducerFactory_x1 = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLLLLZZZLLLLLLLLIIZ_L)n_CreateProducerFactory_x1);
                return cb_CreateProducerFactory_x1;
            }
        }

        public partial class DefaultProducerFactoryMethod : global::Java.Lang.Object, global::Com.Facebook.Imagepipeline.Core.ImagePipelineExperiments.IProducerFactoryMethod
        {
            [Register("createProducerFactory", "(Landroid/content/Context;Lcom/facebook/common/memory/ByteArrayPool;Lcom/facebook/imagepipeline/decoder/ImageDecoder;Lcom/facebook/imagepipeline/decoder/ProgressiveJpegConfig;ZZZLcom/facebook/imagepipeline/core/ExecutorSupplier;Lcom/facebook/common/memory/PooledByteBufferFactory;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/imagepipeline/cache/BufferedDiskCache;Lcom/facebook/imagepipeline/cache/BufferedDiskCache;Lcom/facebook/imagepipeline/cache/CacheKeyFactory;Lcom/facebook/imagepipeline/bitmaps/PlatformBitmapFactory;IIZ)Lcom/facebook/imagepipeline/core/ProducerFactory;", "_CreateProducerFactory_Connector_C_")]
            public unsafe Com.Facebook.Imagepipeline.Core.ProducerFactory CreateProducerFactory(
                Android.Content.Context context,
                Com.Facebook.Common.Memory.IByteArrayPool byteArrayPool,
                Com.Facebook.Imagepipeline.Decoder.IImageDecoder imageDecoder,
                Com.Facebook.Imagepipeline.Decoder.IProgressiveJpegConfig progressiveJpegConfig,
                bool z, bool z2, bool z3,
                Com.Facebook.Imagepipeline.Core.IExecutorSupplier executorSupplier,
                Com.Facebook.Common.Memory.IPooledByteBufferFactory pooledByteBufferFactory,
                Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache,
                Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache2,
                Com.Facebook.Imagepipeline.Cache.BufferedDiskCache bufferedDiskCache,
                Com.Facebook.Imagepipeline.Cache.BufferedDiskCache bufferedDiskCache2,
                Com.Facebook.Imagepipeline.Cache.ICacheKeyFactory cacheKeyFactory,
                Com.Facebook.Imagepipeline.Bitmaps.PlatformBitmapFactory platformBitmapFactory,
                int i, int i2, bool z4)
            {
                const string __id = "CreateProducerFactory.(Landroid/content/Context;Lcom/facebook/common/memory/ByteArrayPool;Lcom/facebook/imagepipeline/decoder/ImageDecoder;Lcom/facebook/imagepipeline/decoder/ProgressiveJpegConfig;ZZZLcom/facebook/imagepipeline/core/ExecutorSupplier;Lcom/facebook/common/memory/PooledByteBufferFactory;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/imagepipeline/cache/BufferedDiskCache;Lcom/facebook/imagepipeline/cache/BufferedDiskCache;Lcom/facebook/imagepipeline/cache/CacheKeyFactory;Lcom/facebook/imagepipeline/bitmaps/PlatformBitmapFactory;IIZ)Lcom/facebook/imagepipeline/core/ProducerFactory;";
                JniArgumentValue* __args = stackalloc JniArgumentValue[18];
                __args[0] = new JniArgumentValue(context);
                __args[1] = new JniArgumentValue(byteArrayPool);
                __args[2] = new JniArgumentValue(imageDecoder);
                __args[3] = new JniArgumentValue(progressiveJpegConfig);
                __args[4] = new JniArgumentValue(z);
                __args[5] = new JniArgumentValue(z2);
                __args[6] = new JniArgumentValue(z3);
                __args[7] = new JniArgumentValue(executorSupplier);
                __args[8] = new JniArgumentValue(pooledByteBufferFactory);
                __args[9] = new JniArgumentValue(memoryCache);
                __args[10] = new JniArgumentValue(memoryCache2);
                __args[11] = new JniArgumentValue(bufferedDiskCache);
                __args[12] = new JniArgumentValue(bufferedDiskCache2);
                __args[13] = new JniArgumentValue(cacheKeyFactory);
                __args[14] = new JniArgumentValue(platformBitmapFactory);
                __args[15] = new JniArgumentValue(i);
                __args[16] = new JniArgumentValue(i2);
                __args[17] = new JniArgumentValue(z4);

                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                _members.InstanceMethods.InvokeNonvirtualVoidMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<Com.Facebook.Imagepipeline.Core.ProducerFactory>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }

            static unsafe IntPtr n_CreateProducerFactory_x1_c_(
                IntPtr jnienv, IntPtr native__this,
                Android.Content.Context context,
                Com.Facebook.Common.Memory.IByteArrayPool byteArrayPool,
                Com.Facebook.Imagepipeline.Decoder.IImageDecoder imageDecoder,
                Com.Facebook.Imagepipeline.Decoder.IProgressiveJpegConfig progressiveJpegConfig,
                bool z, bool z2, bool z3,
                Com.Facebook.Imagepipeline.Core.IExecutorSupplier executorSupplier,
                Com.Facebook.Common.Memory.IPooledByteBufferFactory pooledByteBufferFactory,
                Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache,
                Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache2,
                Com.Facebook.Imagepipeline.Cache.BufferedDiskCache bufferedDiskCache,
                Com.Facebook.Imagepipeline.Cache.BufferedDiskCache bufferedDiskCache2,
                Com.Facebook.Imagepipeline.Cache.ICacheKeyFactory cacheKeyFactory,
                Com.Facebook.Imagepipeline.Bitmaps.PlatformBitmapFactory platformBitmapFactory,
                int i, int i2, bool z4)
            {
                IProducerFactoryMethod __this = global::Java.Lang.Object.GetObject<IProducerFactoryMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                ProducerFactory rv = __this.CreateProducerFactory(
                        context,
                    byteArrayPool,
                    imageDecoder,
                    progressiveJpegConfig,
                    z, z2, z3,
                    executorSupplier,
                    pooledByteBufferFactory,
                    memoryCache,
                    memoryCache2,
                    bufferedDiskCache,
                    bufferedDiskCache2,
                    cacheKeyFactory,
                    platformBitmapFactory,
                    i, i2, z4);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(rv);
                return __ret;
            }

            static Delegate cb_RetrieveModel_x1_c;
            static Delegate _CreateProducerFactory_Connector_C_()
            {
                if (cb_RetrieveModel_x1_c == null)
                    cb_RetrieveModel_x1_c = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLLLLZZZLLLLLLLLIIZ_L)n_CreateProducerFactory_x1_c_);
                return cb_RetrieveModel_x1_c;
            }
        }
    }

    
}