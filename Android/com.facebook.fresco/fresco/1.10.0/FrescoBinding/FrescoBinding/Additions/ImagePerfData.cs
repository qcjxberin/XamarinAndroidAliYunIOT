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
using Com.Facebook.Imagepipeline.Image;
using Com.Facebook.Imagepipeline.Request;

namespace Com.Facebook.Drawee.Backends.Pipeline.Info
{   
    public partial class ImagePerfData : global::Java.Lang.Object
    {
        private const string ctorSignature = "(" +
               "Ljava/lang/String;" +
               "Ljava/lang/String;" +
               "Lcom/facebook/imagepipeline/request/ImageRequest;" +
               "Lcom/facebook/common/internal/Objects;" +
               "Lcom/facebook/imagepipeline/image/ImageInfo;" +
               "JJJJJJJIZZZ)V";
        static IntPtr id_ctor_I;
        [Register(".ctor", ctorSignature, "")]
        public unsafe ImagePerfData(
            Java.Lang.String p1,
            Java.Lang.String p2,
            Com.Facebook.Imagepipeline.Request.ImageRequest p3,
            Com.Facebook.Common.Internal.Objects p4,
            Com.Facebook.Imagepipeline.Image.IImageInfo p5,
            long p6,
            long p7,
            long p8,
            long p9,
            long p10,
            long p11,
            long p12,
            int p13,
            bool p14,
            bool p15,
            bool p16) 
            :base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (Handle != IntPtr.Zero)
                return;
            if (GetType() != typeof(ImagePerfData))
            {
                SetHandle(
                       Android.Runtime.JNIEnv.CreateInstance(GetType(), ctorSignature,
                       new JValue(p1),
                       new JValue(p2),
                       new JValue(p3),
                       new JValue(p4),
                       new JValue(p5),
                       new JValue(p6),
                       new JValue(p7),
                       new JValue(p8),
                       new JValue(p9),
                       new JValue(p10),
                       new JValue(p11),
                       new JValue(p12),
                       new JValue(p13),
                       new JValue(p14),
                       new JValue(p15),
                       new JValue(p16)),
                       JniHandleOwnership.TransferLocalRef);
                return;
            }
            if (id_ctor_I == IntPtr.Zero)
                id_ctor_I = JNIEnv.GetMethodID(class_ref, "<init>", ctorSignature);
            SetHandle(
                    JNIEnv.NewObject(class_ref, id_ctor_I,
                    new JValue(p1),
                    new JValue(p2),
                    new JValue(p3),
                    new JValue(p4),
                    new JValue(p5),
                    new JValue(p6),
                    new JValue(p7),
                    new JValue(p8),
                    new JValue(p9),
                    new JValue(p10),
                    new JValue(p11),
                    new JValue(p12),
                    new JValue(p13),
                    new JValue(p14),
                    new JValue(p15),
                    new JValue(p16)),
                    JniHandleOwnership.TransferLocalRef);
        }
    }
}