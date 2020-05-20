using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"javax/annotation",
					},
					new Converter<string, Type>[]{
						lookup_javax_annotation_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_javax_annotation_mappings;
		static Type lookup_javax_annotation_package (string klass)
		{
			if (package_javax_annotation_mappings == null) {
				package_javax_annotation_mappings = new string[]{
					"javax/annotation/MatchesPattern$Checker:Javax.Annotation.MatchesPatternChecker",
					"javax/annotation/Nonnegative$Checker:Javax.Annotation.NonnegativeChecker",
					"javax/annotation/Nonnull$Checker:Javax.Annotation.NonnullChecker",
					"javax/annotation/RegEx$Checker:Javax.Annotation.RegExChecker",
				};
			}

			return Lookup (package_javax_annotation_mappings, klass);
		}
	}
}
