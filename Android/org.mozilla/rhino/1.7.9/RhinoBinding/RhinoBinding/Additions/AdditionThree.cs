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

namespace Org.Mozilla.Javascript.Typedarrays
{
    public partial class NativeUint8ClampedArray 
    {
        public override Java.Lang.Object Get(int index)
        {
            return RawGet(index);
        }

        public override Java.Lang.Object Set(int index, Java.Lang.Object element)
        {
            return RawSet(index, element as Java.Lang.Integer);
        }
    }
    public partial class NativeUint32Array
    {
        public override Java.Lang.Object Get(int index)
        {
            return RawGet(index);
        }

        public override Java.Lang.Object Set(int index, Java.Lang.Object element)
        {
            return RawSet(index, element as Java.Lang.Long);
        }
    }
    public partial class NativeUint16Array 
    {
        public override Java.Lang.Object Get(int index)
        {
            return RawGet(index);
        }

        public override Java.Lang.Object Set(int index, Java.Lang.Object element)
        {
            return RawSet(index, element as Java.Lang.Integer);
        }
    }
    public partial class NativeInt8Array 
    {
        public override Java.Lang.Object Get(int index)
        {
            return RawGet(index);
        }

        public override Java.Lang.Object Set(int index, Java.Lang.Object element)
        {
            return RawSet(index, element as Java.Lang.Byte);
        }
    }
    public partial class NativeInt32Array
    {
        public override Java.Lang.Object Get(int index)
        {
            return RawGet(index);
        }

        public override Java.Lang.Object Set(int index, Java.Lang.Object element)
        {
            return RawSet(index, element as Java.Lang.Integer);
        }
    }
    public partial class NativeInt16Array 
    {
        public override Java.Lang.Object Get(int index)
        {
            return RawGet(index);
        }

        public override Java.Lang.Object Set(int index, Java.Lang.Object element)
        {
            return RawSet(index, element as Java.Lang.Short);
        }
    }
    public partial class NativeFloat64Array
    {
        public override Java.Lang.Object Get(int index)
        {
            return RawGet(index);
        }

        public override Java.Lang.Object Set(int index, Java.Lang.Object element)
        {
            return RawSet(index, element as Java.Lang.Double);
        }
    }
    public partial class NativeFloat32Array 
    {
        public override Java.Lang.Object Get(int index)
        {
            return RawGet(index);
        }

        public override Java.Lang.Object Set(int index, Java.Lang.Object element)
        {
            return RawSet(index, element as Java.Lang.Float);
        }
    }
    public partial class NativeUint8Array 
    {
        public override Java.Lang.Object Get(int index)
        {
            return RawGet(index);
        }

        public override Java.Lang.Object Set(int index, Java.Lang.Object element)
        {
            return RawSet(index, element as Java.Lang.Integer);
        }
    }
}