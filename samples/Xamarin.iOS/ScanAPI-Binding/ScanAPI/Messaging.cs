using System;
using System.Drawing;
using System.Runtime.InteropServices;

using AudioToolbox;
using AudioUnit;
using AVFoundation;
using CoreAnimation;
using CoreGraphics;
using CoreMedia;
using Foundation;

namespace MonoTouch.ObjCRuntime {
	internal static class Messaging {
		const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";

		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_bool (IntPtr receiver, IntPtr selector, bool arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_rbool (IntPtr receiver, IntPtr selector, ref bool arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_rint (IntPtr receiver, IntPtr selector, ref int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_rfloat (IntPtr receiver, IntPtr selector, ref float arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_rdouble (IntPtr receiver, IntPtr selector, ref double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_rintptr (IntPtr receiver, IntPtr selector, ref IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_cgsize (IntPtr receiver, IntPtr selector, CGSize arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_cgpoint (IntPtr receiver, IntPtr selector, CGPoint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_cgrect (IntPtr receiver, IntPtr selector, CGRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_nsrange (IntPtr receiver, IntPtr selector, NSRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_intptr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_cgpoint_intptr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_intptr_intptr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_intptr_intptr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_intptr_intptr_double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_intptr_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_cgsize (IntPtr receiver, IntPtr selector, CGSize arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_cgrect (IntPtr receiver, IntPtr selector, CGRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_intptr_intptr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_intptr_intptr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_intptr_intptr_double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void void_objc_msgSend_stret_rcgsize (ref CGSize stret, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void void_objc_msgSend_stret_rcgrect (ref CGRect stret, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void void_objc_msgSend_stret_rnsrange (ref NSRange stret, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void void_objc_msgSend_stret_rcgsize_cgpoint_intptr (ref CGSize stret, IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void void_objc_msgSendSuper_stret_rcgrect (ref CGRect stret, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr intptr_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr intptr_objc_msgSend_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr intptr_objc_msgSend_float (IntPtr receiver, IntPtr selector, float arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr intptr_objc_msgSend_cgrect (IntPtr receiver, IntPtr selector, CGRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr intptr_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr intptr_objc_msgSendSuper_cgrect (IntPtr receiver, IntPtr selector, CGRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr intptr_objc_msgSendSuper_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static CGSize cgsize_objc_msgSend_cgpoint_intptr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static CGSize cgsize_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr intptr_objc_msgsend_intptr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static Boolean Boolean_objc_msgSend_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, Double arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static Boolean Boolean_objc_msgSendSuper_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, Double arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, Double arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_IntPtr_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt32_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt32_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_CMTime_CGAffineTransform_CGAffineTransform_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, CGAffineTransform arg2, CGAffineTransform arg3, CMTimeRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_CMTime_CGAffineTransform_CGAffineTransform_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, CGAffineTransform arg2, CGAffineTransform arg3, CMTimeRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_CMTime_CMTime_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_CMTime_CMTime_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_CMTime_float_float_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, float arg2, float arg3, CMTimeRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_CMTime_float_float_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, float arg2, float arg3, CMTimeRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Double_float (IntPtr receiver, IntPtr selector, double arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Double_float (IntPtr receiver, IntPtr selector, double arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt32_UInt32 (IntPtr receiver, IntPtr selector, uint arg1, uint arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt32_UInt32 (IntPtr receiver, IntPtr selector, uint arg1, uint arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_bool_int_IntPtr (System.IntPtr receiver, System.IntPtr selector, bool arg1, int arg2, System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_bool_IntPtr (System.IntPtr receiver, System.IntPtr selector, bool arg1, System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_bool_IntPtr_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, bool arg1, System.IntPtr arg2, System.IntPtr arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_CMTimeRange_IntPtr_CMTime_IntPtr (System.IntPtr receiver, System.IntPtr selector, CMTimeRange arg1, System.IntPtr arg2, CMTime arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_float_IntPtr (System.IntPtr receiver, System.IntPtr selector, float arg1, System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_bool_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, bool arg2, System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_bool_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, bool arg2, System.IntPtr arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_int_bool_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, int arg2, bool arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_int_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, int arg2, System.IntPtr arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_CMTime_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, CMTime arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, int arg3, System.IntPtr arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_int_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, System.IntPtr arg3, int arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_int_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, System.IntPtr arg3, int arg4, System.IntPtr arg5, System.IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, System.IntPtr arg3, System.IntPtr arg4, System.IntPtr arg5, System.IntPtr arg6, System.IntPtr arg7, System.IntPtr arg8);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_bool_int_IntPtr (System.IntPtr receiver, System.IntPtr selector, bool arg1, int arg2, System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_bool_IntPtr (System.IntPtr receiver, System.IntPtr selector, bool arg1, System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_bool_IntPtr_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, bool arg1, System.IntPtr arg2, System.IntPtr arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_CMTimeRange_IntPtr_CMTime_IntPtr (System.IntPtr receiver, System.IntPtr selector, CMTimeRange arg1, System.IntPtr arg2, CMTime arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_float_IntPtr (System.IntPtr receiver, System.IntPtr selector, float arg1, System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_bool_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, bool arg2, System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, bool arg2, System.IntPtr arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_int_bool_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, int arg2, bool arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, int arg2, System.IntPtr arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_CMTime_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, CMTime arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, int arg3, System.IntPtr arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, System.IntPtr arg3, int arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, System.IntPtr arg3, int arg4, System.IntPtr arg5, System.IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, System.IntPtr arg3, System.IntPtr arg4, System.IntPtr arg5, System.IntPtr arg6, System.IntPtr arg7, System.IntPtr arg8);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_IntPtr_int_int_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, int arg3, int arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_IntPtr_int_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, int arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_IntPtr_int_int_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, int arg3, int arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, int arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static System.IntPtr IntPtr_objc_msgSend_CMTime_out_CMTime_IntPtr (System.IntPtr receiver, System.IntPtr selector, CMTime arg1, out CMTime arg2, System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static System.IntPtr IntPtr_objc_msgSend_int_int_IntPtr_bool_IntPtr (System.IntPtr receiver, System.IntPtr selector, int arg1, int arg2, System.IntPtr arg3, bool arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static System.IntPtr IntPtr_objc_msgSend_int_IntPtr_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, int arg1, System.IntPtr arg2, System.IntPtr arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static System.IntPtr IntPtr_objc_msgSend_int_IntPtr_ref_NSRange_ref_NSRange_IntPtr (System.IntPtr receiver, System.IntPtr selector, int arg1, System.IntPtr arg2, ref NSRange arg3, ref NSRange arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static System.IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr_out_Boolean_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, int arg2, System.IntPtr arg3, out bool arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static System.IntPtr IntPtr_objc_msgSend_IntPtr_int_ref_NSPropertyListFormat_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, int arg2, ref NSPropertyListFormat arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, System.IntPtr arg3, System.IntPtr arg4, System.IntPtr arg5, System.IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static System.IntPtr IntPtr_objc_msgSend_IntPtr_RectangleF_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.Drawing.RectangleF arg2, System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static System.IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_int_IntPtr (System.IntPtr receiver, System.IntPtr selector, NSRange arg1, System.IntPtr arg2, int arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static System.IntPtr IntPtr_objc_msgSendSuper_CMTime_out_CMTime_IntPtr (System.IntPtr receiver, System.IntPtr selector, CMTime arg1, out CMTime arg2, System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static System.IntPtr IntPtr_objc_msgSendSuper_int_int_IntPtr_bool_IntPtr (System.IntPtr receiver, System.IntPtr selector, int arg1, int arg2, System.IntPtr arg3, bool arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static System.IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, int arg1, System.IntPtr arg2, System.IntPtr arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static System.IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_ref_NSRange_ref_NSRange_IntPtr (System.IntPtr receiver, System.IntPtr selector, int arg1, System.IntPtr arg2, ref NSRange arg3, ref NSRange arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_out_Boolean_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, int arg2, System.IntPtr arg3, out bool arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_ref_NSPropertyListFormat_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, int arg2, ref NSPropertyListFormat arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, System.IntPtr arg3, System.IntPtr arg4, System.IntPtr arg5, System.IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_RectangleF_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.Drawing.RectangleF arg2, System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static System.IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_int_IntPtr (System.IntPtr receiver, System.IntPtr selector, NSRange arg1, System.IntPtr arg2, int arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void RectangleF_objc_msgSend_stret_IntPtr_IntPtr_IntPtr (out System.Drawing.RectangleF retval, System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_IntPtr_IntPtr (out System.Drawing.RectangleF retval, System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static uint UInt32_objc_msgSend_IntPtr_Int64_UInt32_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, long arg2, uint arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static uint UInt32_objc_msgSend_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static uint UInt32_objc_msgSendSuper_IntPtr_Int64_UInt32_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, long arg2, uint arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static uint UInt32_objc_msgSendSuper_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_IntPtr_int_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, int arg2, System.IntPtr arg3, int arg4, System.IntPtr arg5, System.IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, int arg2, System.IntPtr arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_ref_RectangleF_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, ref System.Drawing.RectangleF arg2, System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_IntPtr_int_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, int arg2, System.IntPtr arg3, int arg4, System.IntPtr arg5, System.IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, int arg2, System.IntPtr arg3, System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_ref_RectangleF_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, ref System.Drawing.RectangleF arg2, System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_UInt32_UInt32_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, uint arg3, uint arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_UInt32_UInt32_IntPtr (System.IntPtr receiver, System.IntPtr selector, System.IntPtr arg1, System.IntPtr arg2, uint arg3, uint arg4, System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CMTime_objc_msgSend_stret (out CMTime retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CMTime_objc_msgSendSuper_stret (out CMTime retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Double Double_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Double Double_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt32 UInt32_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt32 UInt32_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, global::System.UInt32 arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, global::System.UInt32 arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void Vector3_objc_msgSend_stret (out global::OpenTK.Vector3 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void Vector3_objc_msgSendSuper_stret (out global::OpenTK.Vector3 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Vector3 (IntPtr receiver, IntPtr selector, global::OpenTK.Vector3 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Vector3 (IntPtr receiver, IntPtr selector, global::OpenTK.Vector3 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void AVAudio3DVectorOrientation_objc_msgSend_stret (out AVAudio3DVectorOrientation retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void AVAudio3DVectorOrientation_objc_msgSendSuper_stret (out AVAudio3DVectorOrientation retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static AVAudio3DVectorOrientation AVAudio3DVectorOrientation_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static AVAudio3DVectorOrientation AVAudio3DVectorOrientation_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_AVAudio3DVectorOrientation (IntPtr receiver, IntPtr selector, AVAudio3DVectorOrientation arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_AVAudio3DVectorOrientation (IntPtr receiver, IntPtr selector, AVAudio3DVectorOrientation arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void AVAudio3DAngularOrientation_objc_msgSend_stret (out AVAudio3DAngularOrientation retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void AVAudio3DAngularOrientation_objc_msgSendSuper_stret (out AVAudio3DAngularOrientation retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_AVAudio3DAngularOrientation (IntPtr receiver, IntPtr selector, AVAudio3DAngularOrientation arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_AVAudio3DAngularOrientation (IntPtr receiver, IntPtr selector, AVAudio3DAngularOrientation arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static float float_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static float float_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_float (IntPtr receiver, IntPtr selector, float arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_float (IntPtr receiver, IntPtr selector, float arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, bool arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Int64 Int64_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Int64 Int64_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, global::System.Int64 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, global::System.Int64 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, bool arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, bool arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, bool arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, bool arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void AudioStreamBasicDescription_objc_msgSend_stret (out AudioStreamBasicDescription retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void AudioStreamBasicDescription_objc_msgSendSuper_stret (out AudioStreamBasicDescription retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_ref_AudioStreamBasicDescription (IntPtr receiver, IntPtr selector, ref AudioStreamBasicDescription arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_ref_AudioStreamBasicDescription (IntPtr receiver, IntPtr selector, ref AudioStreamBasicDescription arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_ref_AudioStreamBasicDescription_IntPtr (IntPtr receiver, IntPtr selector, ref AudioStreamBasicDescription arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_ref_AudioStreamBasicDescription_IntPtr (IntPtr receiver, IntPtr selector, ref AudioStreamBasicDescription arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_Double_UInt32 (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_Double_UInt32 (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_UInt32_Double_UInt32_bool (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.Double arg2, global::System.UInt32 arg3, bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_UInt32_Double_UInt32_bool (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.Double arg2, global::System.UInt32 arg3, bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_UInt32_Double_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.Double arg2, bool arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_UInt32_Double_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.Double arg2, bool arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt32_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt32_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static float float_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static float float_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_Int64_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Int64 arg2, global::System.UInt32 arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_Int64_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Int64 arg2, global::System.UInt32 arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_Double_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_Double_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_bool_int_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, int arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_bool_int_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, int arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_Double_ref_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_Double_ref_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_int_ref_IntPtr (IntPtr receiver, IntPtr selector, int arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_int_ref_IntPtr (IntPtr receiver, IntPtr selector, int arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_float_ref_IntPtr (IntPtr receiver, IntPtr selector, float arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_float_ref_IntPtr (IntPtr receiver, IntPtr selector, float arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_byte_byte_byte (IntPtr receiver, IntPtr selector, byte arg1, byte arg2, byte arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_byte_byte_byte (IntPtr receiver, IntPtr selector, byte arg1, byte arg2, byte arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_byte_byte (IntPtr receiver, IntPtr selector, byte arg1, byte arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_byte_byte (IntPtr receiver, IntPtr selector, byte arg1, byte arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt16_byte (IntPtr receiver, IntPtr selector, global::System.UInt16 arg1, byte arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt16_byte (IntPtr receiver, IntPtr selector, global::System.UInt16 arg1, byte arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_byte_byte_byte_byte (IntPtr receiver, IntPtr selector, byte arg1, byte arg2, byte arg3, byte arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_byte_byte_byte_byte (IntPtr receiver, IntPtr selector, byte arg1, byte arg2, byte arg3, byte arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_byte_byte_byte_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, byte arg2, byte arg3, byte arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_byte_byte_byte_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, byte arg2, byte arg3, byte arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt64 UInt64_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt64 UInt64_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void AudioTimeStamp_objc_msgSend_stret (out AudioTimeStamp retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void AudioTimeStamp_objc_msgSendSuper_stret (out AudioTimeStamp retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_ref_AudioTimeStamp_Double (IntPtr receiver, IntPtr selector, ref AudioTimeStamp arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_ref_AudioTimeStamp_Double (IntPtr receiver, IntPtr selector, ref AudioTimeStamp arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_Int64_Double (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_Int64_Double (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_UInt64_Int64_Double (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1, global::System.Int64 arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_UInt64_Int64_Double (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1, global::System.Int64 arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt64 UInt64_objc_msgSend_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt64 UInt64_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Double Double_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Double Double_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CGAffineTransform_objc_msgSend_stret (out CGAffineTransform retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CGAffineTransform_objc_msgSendSuper_stret (out CGAffineTransform retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_CMTime_out_CMTime_ref_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, out CMTime arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_CMTime_out_CMTime_ref_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, out CMTime arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CMTimeRange_objc_msgSend_stret (out CMTimeRange retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CMTimeRange_objc_msgSendSuper_stret (out CMTimeRange retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CMTimeRange (IntPtr receiver, IntPtr selector, CMTimeRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CMTimeRange (IntPtr receiver, IntPtr selector, CMTimeRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CGAffineTransform (IntPtr receiver, IntPtr selector, CGAffineTransform arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CGAffineTransform (IntPtr receiver, IntPtr selector, CGAffineTransform arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_CMTime (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTime arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_CMTime (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTime arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CMTime_objc_msgSend_stret_CMTime (out CMTime retval, IntPtr receiver, IntPtr selector, CMTime arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CMTime_objc_msgSendSuper_stret_CMTime (out CMTime retval, IntPtr receiver, IntPtr selector, CMTime arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_CMTimeRange_IntPtr_CMTime_ref_IntPtr (IntPtr receiver, IntPtr selector, CMTimeRange arg1, IntPtr arg2, CMTime arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_CMTimeRange_IntPtr_CMTime_ref_IntPtr (IntPtr receiver, IntPtr selector, CMTimeRange arg1, IntPtr arg2, CMTime arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CMTimeRange_CMTime (IntPtr receiver, IntPtr selector, CMTimeRange arg1, CMTime arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CMTimeRange_CMTime (IntPtr receiver, IntPtr selector, CMTimeRange arg1, CMTime arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_CMTime_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CMTime arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_CMTime_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CMTime arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CMTimeMapping_objc_msgSend_stret (out CMTimeMapping retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CMTimeMapping_objc_msgSendSuper_stret (out CMTimeMapping retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_CMTimeRange_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, CMTimeRange arg3, CMTimeRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_CMTimeRange_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, CMTimeRange arg3, CMTimeRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_CMTimeRange (IntPtr receiver, IntPtr selector, CMTimeRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_CMTimeRange (IntPtr receiver, IntPtr selector, CMTimeRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_CMTime_ref_Single_ref_Single_ref_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, ref float arg2, ref float arg3, ref CMTimeRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_CMTime_ref_Single_ref_Single_ref_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, ref float arg2, ref float arg3, ref CMTimeRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_float_float_CMTimeRange (IntPtr receiver, IntPtr selector, float arg1, float arg2, CMTimeRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_float_float_CMTimeRange (IntPtr receiver, IntPtr selector, float arg1, float arg2, CMTimeRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_float_CMTime (IntPtr receiver, IntPtr selector, float arg1, CMTime arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_float_CMTime (IntPtr receiver, IntPtr selector, float arg1, CMTime arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_CMTimeRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_CMTimeRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void AVPixelAspectRatio_objc_msgSend_stret (out AVPixelAspectRatio retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void AVPixelAspectRatio_objc_msgSendSuper_stret (out AVPixelAspectRatio retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static AVPixelAspectRatio AVPixelAspectRatio_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static AVPixelAspectRatio AVPixelAspectRatio_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void AVEdgeWidths_objc_msgSend_stret (out AVEdgeWidths retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void AVEdgeWidths_objc_msgSendSuper_stret (out AVEdgeWidths retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_CMTime_ref_CGAffineTransform_ref_CGAffineTransform_ref_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, ref CGAffineTransform arg2, ref CGAffineTransform arg3, ref CMTimeRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_CMTime_ref_CGAffineTransform_ref_CGAffineTransform_ref_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, ref CGAffineTransform arg2, ref CGAffineTransform arg3, ref CMTimeRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_CMTime_ref_RectangleF_ref_RectangleF_ref_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, ref global::System.Drawing.RectangleF arg2, ref global::System.Drawing.RectangleF arg3, ref CMTimeRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_CMTime_ref_RectangleF_ref_RectangleF_ref_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, ref global::System.Drawing.RectangleF arg2, ref global::System.Drawing.RectangleF arg3, ref CMTimeRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CGAffineTransform_CGAffineTransform_CMTimeRange (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CGAffineTransform arg2, CMTimeRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CGAffineTransform_CGAffineTransform_CMTimeRange (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CGAffineTransform arg2, CMTimeRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CGAffineTransform_CMTime (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CMTime arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CGAffineTransform_CMTime (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CMTime arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_RectangleF_CMTimeRange (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, CMTimeRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_RectangleF_CMTimeRange (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, CMTimeRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_CMTime (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, CMTime arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_CMTime (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, CMTime arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_RectangleF (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_RectangleF (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void PointF_objc_msgSend_stret_PointF (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void PointF_objc_msgSendSuper_stret_PointF (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSend_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_CMTime_float (IntPtr receiver, IntPtr selector, CMTime arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_CMTime_float (IntPtr receiver, IntPtr selector, CMTime arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float (IntPtr receiver, IntPtr selector, float arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float (IntPtr receiver, IntPtr selector, float arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void PointF_objc_msgSend_stret (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void PointF_objc_msgSendSuper_stret (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void AVCaptureWhiteBalanceGains_objc_msgSend_stret (out AVCaptureWhiteBalanceGains retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void AVCaptureWhiteBalanceGains_objc_msgSendSuper_stret (out AVCaptureWhiteBalanceGains retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CMTime_float_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, float arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CMTime_float_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, float arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_float_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_float_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_AVCaptureWhiteBalanceGains_IntPtr (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_AVCaptureWhiteBalanceGains_IntPtr (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void AVCaptureWhiteBalanceChromaticityValues_objc_msgSend_stret_AVCaptureWhiteBalanceGains (out AVCaptureWhiteBalanceChromaticityValues retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void AVCaptureWhiteBalanceChromaticityValues_objc_msgSendSuper_stret_AVCaptureWhiteBalanceGains (out AVCaptureWhiteBalanceChromaticityValues retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static AVCaptureWhiteBalanceChromaticityValues AVCaptureWhiteBalanceChromaticityValues_objc_msgSend_AVCaptureWhiteBalanceGains (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static AVCaptureWhiteBalanceChromaticityValues AVCaptureWhiteBalanceChromaticityValues_objc_msgSendSuper_AVCaptureWhiteBalanceGains (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void AVCaptureWhiteBalanceGains_objc_msgSend_stret_AVCaptureWhiteBalanceChromaticityValues (out AVCaptureWhiteBalanceGains retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceChromaticityValues arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void AVCaptureWhiteBalanceGains_objc_msgSendSuper_stret_AVCaptureWhiteBalanceChromaticityValues (out AVCaptureWhiteBalanceGains retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceChromaticityValues arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void AVCaptureWhiteBalanceTemperatureAndTintValues_objc_msgSend_stret_AVCaptureWhiteBalanceGains (out AVCaptureWhiteBalanceTemperatureAndTintValues retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void AVCaptureWhiteBalanceTemperatureAndTintValues_objc_msgSendSuper_stret_AVCaptureWhiteBalanceGains (out AVCaptureWhiteBalanceTemperatureAndTintValues retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static AVCaptureWhiteBalanceTemperatureAndTintValues AVCaptureWhiteBalanceTemperatureAndTintValues_objc_msgSend_AVCaptureWhiteBalanceGains (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static AVCaptureWhiteBalanceTemperatureAndTintValues AVCaptureWhiteBalanceTemperatureAndTintValues_objc_msgSendSuper_AVCaptureWhiteBalanceGains (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void AVCaptureWhiteBalanceGains_objc_msgSend_stret_AVCaptureWhiteBalanceTemperatureAndTintValues (out AVCaptureWhiteBalanceGains retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceTemperatureAndTintValues arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void AVCaptureWhiteBalanceGains_objc_msgSendSuper_stret_AVCaptureWhiteBalanceTemperatureAndTintValues (out AVCaptureWhiteBalanceGains retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceTemperatureAndTintValues arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void Size_objc_msgSend_stret (out global::System.Drawing.Size retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void Size_objc_msgSendSuper_stret (out global::System.Drawing.Size retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.Size Size_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.Size Size_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_CMTime_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_CMTime_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CMTime_CMTime_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CMTime_CMTime_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CMTime_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CMTime_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CMTime_CMTime_CMTime_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CMTime_CMTime_CMTime_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_float_CMTime_CMTime (IntPtr receiver, IntPtr selector, float arg1, CMTime arg2, CMTime arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_float_CMTime_CMTime (IntPtr receiver, IntPtr selector, float arg1, CMTime arg2, CMTime arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CMTime_objc_msgSend_stret_Double (out CMTime retval, IntPtr receiver, IntPtr selector, global::System.Double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CMTime_objc_msgSendSuper_stret_Double (out CMTime retval, IntPtr receiver, IntPtr selector, global::System.Double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CMTime_objc_msgSend_stret_Int64 (out CMTime retval, IntPtr receiver, IntPtr selector, global::System.Int64 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CMTime_objc_msgSendSuper_stret_Int64 (out CMTime retval, IntPtr receiver, IntPtr selector, global::System.Int64 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_CMTime_ref_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1, ref CMTime arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_CMTime_ref_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1, ref CMTime arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_CMTime (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, CMTime arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_CMTime (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, CMTime arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CATransform3D_objc_msgSend_stret (out CATransform3D retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CATransform3D_objc_msgSendSuper_stret (out CATransform3D retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CATransform3D (IntPtr receiver, IntPtr selector, CATransform3D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CATransform3D (IntPtr receiver, IntPtr selector, CATransform3D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void PointF_objc_msgSend_stret_PointF_IntPtr (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void PointF_objc_msgSendSuper_stret_PointF_IntPtr (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSend_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_RectangleF_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_RectangleF_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Double Double_objc_msgSend_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Double Double_objc_msgSendSuper_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt64 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt64 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt64 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt64 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_ref_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_ref_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, ref IntPtr arg8);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, ref IntPtr arg8);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.RectangleF arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.RectangleF arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_PointF_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, global::System.Drawing.RectangleF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_PointF_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, global::System.Drawing.RectangleF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_RectangleF_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, global::System.Drawing.RectangleF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_RectangleF_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, global::System.Drawing.RectangleF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_RectangleF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_RectangleF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_int_RectangleF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.IntPtr arg2, int arg3, global::System.Drawing.RectangleF arg4, int arg5, IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_int_RectangleF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.IntPtr arg2, int arg3, global::System.Drawing.RectangleF arg4, int arg5, IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_RectangleF_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_RectangleF_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_SizeF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.Drawing.SizeF arg3, int arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_SizeF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.Drawing.SizeF arg3, int arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UInt32_SizeF_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.Drawing.SizeF arg2, bool arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UInt32_SizeF_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.Drawing.SizeF arg2, bool arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_int_SizeF_bool_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.SizeF arg2, bool arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_int_SizeF_bool_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.SizeF arg2, bool arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_CGAffineTransform (IntPtr receiver, IntPtr selector, CGAffineTransform arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_CGAffineTransform (IntPtr receiver, IntPtr selector, CGAffineTransform arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_IntPtr_RectangleF (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_RectangleF (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CGAffineTransform_objc_msgSend_stret_int (out CGAffineTransform retval, IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CGAffineTransform_objc_msgSendSuper_stret_int (out CGAffineTransform retval, IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_RectangleF_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_RectangleF_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_RectangleF_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_RectangleF_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static float float_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static float float_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CLLocationCoordinate2D_objc_msgSend_stret (out global::CoreLocation.CLLocationCoordinate2D retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CLLocationCoordinate2D_objc_msgSendSuper_stret (out global::CoreLocation.CLLocationCoordinate2D retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_Double_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_Double_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, global::System.Double arg2, global::System.Double arg3, global::System.Double arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, global::System.Double arg2, global::System.Double arg3, global::System.Double arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Double Double_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Double Double_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, global::System.Double arg2, global::System.Double arg3, global::System.Double arg4, global::System.Double arg5, global::System.Double arg6, IntPtr arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, global::System.Double arg2, global::System.Double arg3, global::System.Double arg4, global::System.Double arg5, global::System.Double arg6, IntPtr arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Double_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Double_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_IntPtr (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, global::System.Double arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_IntPtr (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, global::System.Double arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_UInt16_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt16 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt16_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt16 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_UInt16_UInt16_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt16 arg2, global::System.UInt16 arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt16_UInt16_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt16 arg2, global::System.UInt16 arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_int_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_int_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_int_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_int_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_int_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_int_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_int_out_NSRange (IntPtr receiver, IntPtr selector, int arg1, out NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_int_out_NSRange (IntPtr receiver, IntPtr selector, int arg1, out NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_out_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, out NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_out_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, out NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_out_NSRange_NSRange (IntPtr receiver, IntPtr selector, int arg1, out NSRange arg2, NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_out_NSRange_NSRange (IntPtr receiver, IntPtr selector, int arg1, out NSRange arg2, NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_out_NSRange_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, out NSRange arg3, NSRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_out_NSRange_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, out NSRange arg3, NSRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_NSRange_int_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_NSRange_int_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_NSRange_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_NSRange_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.UInt32 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.UInt32 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_SizeF_UInt32_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, global::System.UInt32 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_SizeF_UInt32_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, global::System.UInt32 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_int_IntPtr_int (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_int_IntPtr_int (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_int_int_IntPtr_int (IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3, IntPtr arg4, int arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_int_int_IntPtr_int (IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3, IntPtr arg4, int arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_int_int_int_int_int_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_int_int_int_int_int_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_out_Int32_out_Int32_out_Int32_out_Int32_IntPtr (IntPtr receiver, IntPtr selector, out int arg1, out int arg2, out int arg3, out int arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_out_Int32_out_Int32_out_Int32_out_Int32_IntPtr (IntPtr receiver, IntPtr selector, out int arg1, out int arg2, out int arg3, out int arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_ref_IntPtr_out_Double_int_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, out global::System.Double arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_ref_IntPtr_out_Double_int_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, out global::System.Double arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_ref_IntPtr_out_Double_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, out global::System.Double arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_ref_IntPtr_out_Double_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, out global::System.Double arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_Char (IntPtr receiver, IntPtr selector, global::System.Char arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_Char (IntPtr receiver, IntPtr selector, global::System.Char arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_byte (IntPtr receiver, IntPtr selector, byte arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_byte (IntPtr receiver, IntPtr selector, byte arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_Double_int (IntPtr receiver, IntPtr selector, global::System.Double arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_Double_int (IntPtr receiver, IntPtr selector, global::System.Double arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_Double_ref_NSMassFormatterUnit (IntPtr receiver, IntPtr selector, global::System.Double arg1, ref NSMassFormatterUnit arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_Double_ref_NSMassFormatterUnit (IntPtr receiver, IntPtr selector, global::System.Double arg1, ref NSMassFormatterUnit arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Int64_IntPtr (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Int64_IntPtr (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static float float_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static float float_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Int64 Int64_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Int64 Int64_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_out_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, out global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_out_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, out global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4, int arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4, int arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_bool (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.UInt32 arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_bool (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.UInt32 arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void NSRange_objc_msgSend_stret_IntPtr_int_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void NSRange_objc_msgSendSuper_stret_IntPtr_int_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static NSRange NSRange_objc_msgSend_IntPtr_int_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static NSRange NSRange_objc_msgSendSuper_IntPtr_int_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_Int64_int (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_Int64_int (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, global::System.Int64 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, global::System.Int64 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_Double_out_NSEnergyFormatterUnit (IntPtr receiver, IntPtr selector, global::System.Double arg1, out NSEnergyFormatterUnit arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_Double_out_NSEnergyFormatterUnit (IntPtr receiver, IntPtr selector, global::System.Double arg1, out NSEnergyFormatterUnit arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_NSRange (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_NSRange (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_Double_ref_NSLengthFormatterUnit (IntPtr receiver, IntPtr selector, global::System.Double arg1, ref NSLengthFormatterUnit arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_Double_ref_NSLengthFormatterUnit (IntPtr receiver, IntPtr selector, global::System.Double arg1, ref NSLengthFormatterUnit arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_ref_NSRange (IntPtr receiver, IntPtr selector, int arg1, ref NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_ref_NSRange (IntPtr receiver, IntPtr selector, int arg1, ref NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_NSRange_int (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_NSRange_int (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_NSRange_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_NSRange_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void NSRange_objc_msgSend_stret_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void NSRange_objc_msgSendSuper_stret_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static NSRange NSRange_objc_msgSend_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static NSRange NSRange_objc_msgSendSuper_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_IntPtr_ref_NSRange_ref_NSRange (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, ref NSRange arg3, ref NSRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_ref_NSRange_ref_NSRange (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, ref NSRange arg3, ref NSRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, int arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, int arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_IntPtr_ref_NSRange_ref_NSRange_ref_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, ref NSRange arg3, ref NSRange arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_ref_NSRange_ref_NSRange_ref_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, ref NSRange arg3, ref NSRange arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_Double_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, bool arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_Double_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, bool arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_Double_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, bool arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_Double_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, bool arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr_out_Boolean_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, out bool arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_out_Boolean_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, out bool arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_Int64_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Int64 arg2, global::System.Int64 arg3, global::System.Int64 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_Int64_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Int64 arg2, global::System.Int64 arg3, global::System.Int64 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Int64 arg2, global::System.Int64 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Int64 arg2, global::System.Int64 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_Int64_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Int64 arg3, global::System.Int64 arg4, global::System.Int64 arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_Int64_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Int64 arg3, global::System.Int64 arg4, global::System.Int64 arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Int64 arg3, global::System.Int64 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Int64 arg3, global::System.Int64 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt32_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, ref IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt32_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, ref IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_IntPtr_float_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_IntPtr_float_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_IntPtr_float_int (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_IntPtr_float_int (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_IntPtr_SizeF (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_IntPtr_SizeF (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_IntPtr_SizeF_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_IntPtr_SizeF_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_IntPtr_SizeF_int (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_IntPtr_SizeF_int (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_IntPtr_float_ref_Single_float_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, ref float arg3, float arg4, int arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_IntPtr_float_ref_Single_float_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, ref float arg3, float arg4, int arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_IntPtr_float_ref_Single_float_int (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, ref float arg3, float arg4, int arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_IntPtr_float_ref_Single_float_int (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, ref float arg3, float arg4, int arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_PointF_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_PointF_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_PointF_float_IntPtr_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, IntPtr arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_PointF_float_IntPtr_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, IntPtr arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_PointF_float_IntPtr_int (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, IntPtr arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_PointF_float_IntPtr_int (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, IntPtr arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_PointF_float_IntPtr_float_int_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, IntPtr arg3, float arg4, int arg5, int arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_PointF_float_IntPtr_float_int_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, IntPtr arg3, float arg4, int arg5, int arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_PointF_float_IntPtr_float_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, IntPtr arg3, float arg4, int arg5, int arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_PointF_float_IntPtr_float_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, IntPtr arg3, float arg4, int arg5, int arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_PointF_float_IntPtr_float_ref_Single_int_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, IntPtr arg3, float arg4, ref float arg5, int arg6, int arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_PointF_float_IntPtr_float_ref_Single_int_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, IntPtr arg3, float arg4, ref float arg5, int arg6, int arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_PointF_float_IntPtr_float_ref_Single_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, IntPtr arg3, float arg4, ref float arg5, int arg6, int arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_PointF_float_IntPtr_float_ref_Single_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, IntPtr arg3, float arg4, ref float arg5, int arg6, int arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_RectangleF_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_RectangleF_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_RectangleF_IntPtr_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_RectangleF_IntPtr_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_RectangleF_IntPtr_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_RectangleF_IntPtr_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_RectangleF_IntPtr_int_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_RectangleF_IntPtr_int_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_RectangleF_IntPtr_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_RectangleF_IntPtr_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Char Char_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Char Char_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_UInt32_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, NSRange arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_UInt32_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, NSRange arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_out_Boolean (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, out bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_out_Boolean (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, out bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_out_UInt32_out_UInt32_out_UInt32_NSRange (IntPtr receiver, IntPtr selector, out global::System.UInt32 arg1, out global::System.UInt32 arg2, out global::System.UInt32 arg3, NSRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_out_UInt32_out_UInt32_out_UInt32_NSRange (IntPtr receiver, IntPtr selector, out global::System.UInt32 arg1, out global::System.UInt32 arg2, out global::System.UInt32 arg3, NSRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, NSRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, NSRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt32 UInt32_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt32 UInt32_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt32 UInt32_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt32 UInt32_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt32_int (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt32_int (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void UIEdgeInsets_objc_msgSend_stret (out global::UIKit.UIEdgeInsets retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void UIEdgeInsets_objc_msgSendSuper_stret (out global::UIKit.UIEdgeInsets retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void UIOffset_objc_msgSend_stret (out global::UIKit.UIOffset retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void UIOffset_objc_msgSendSuper_stret (out global::UIKit.UIOffset retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::UIKit.UIOffset UIOffset_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::UIKit.UIOffset UIOffset_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CGVector_objc_msgSend_stret (out CGVector retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CGVector_objc_msgSendSuper_stret (out CGVector retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static CGVector CGVector_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static CGVector CGVector_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void MKCoordinateSpan_objc_msgSend_stret (out global::MapKit.MKCoordinateSpan retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void MKCoordinateSpan_objc_msgSendSuper_stret (out global::MapKit.MKCoordinateSpan retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SCNVector3_objc_msgSend_stret (out global::SceneKit.SCNVector3 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SCNVector3_objc_msgSendSuper_stret (out global::SceneKit.SCNVector3 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SCNVector4_objc_msgSend_stret (out global::SceneKit.SCNVector4 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SCNVector4_objc_msgSendSuper_stret (out global::SceneKit.SCNVector4 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SCNMatrix4_objc_msgSend_stret (out global::SceneKit.SCNMatrix4 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SCNMatrix4_objc_msgSendSuper_stret (out global::SceneKit.SCNMatrix4 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_CMTimeMapping (IntPtr receiver, IntPtr selector, CMTimeMapping arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_CMTimeMapping (IntPtr receiver, IntPtr selector, CMTimeMapping arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UIEdgeInsets (IntPtr receiver, IntPtr selector, global::UIKit.UIEdgeInsets arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UIEdgeInsets (IntPtr receiver, IntPtr selector, global::UIKit.UIEdgeInsets arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UIOffset (IntPtr receiver, IntPtr selector, global::UIKit.UIOffset arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UIOffset (IntPtr receiver, IntPtr selector, global::UIKit.UIOffset arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_CGVector (IntPtr receiver, IntPtr selector, CGVector arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_CGVector (IntPtr receiver, IntPtr selector, CGVector arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_MKCoordinateSpan (IntPtr receiver, IntPtr selector, global::MapKit.MKCoordinateSpan arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_MKCoordinateSpan (IntPtr receiver, IntPtr selector, global::MapKit.MKCoordinateSpan arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_CATransform3D (IntPtr receiver, IntPtr selector, CATransform3D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_CATransform3D (IntPtr receiver, IntPtr selector, CATransform3D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_SCNVector3 (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_SCNVector3 (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_SCNVector4 (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_SCNVector4 (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_SCNMatrix4 (IntPtr receiver, IntPtr selector, global::SceneKit.SCNMatrix4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_SCNMatrix4 (IntPtr receiver, IntPtr selector, global::SceneKit.SCNMatrix4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.SByte SByte_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.SByte SByte_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static byte byte_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static byte byte_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static short short_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static short short_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt16 UInt16_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt16 UInt16_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void NSDecimal_objc_msgSend_stret (out NSDecimal retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void NSDecimal_objc_msgSendSuper_stret (out NSDecimal retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_SByte (IntPtr receiver, IntPtr selector, global::System.SByte arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_SByte (IntPtr receiver, IntPtr selector, global::System.SByte arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_byte (IntPtr receiver, IntPtr selector, byte arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_byte (IntPtr receiver, IntPtr selector, byte arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_short (IntPtr receiver, IntPtr selector, short arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_short (IntPtr receiver, IntPtr selector, short arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_UInt16 (IntPtr receiver, IntPtr selector, global::System.UInt16 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_UInt16 (IntPtr receiver, IntPtr selector, global::System.UInt16 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_bool (IntPtr receiver, IntPtr selector, bool arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, bool arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_Int64_short_bool (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, short arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_Int64_short_bool (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, short arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_NSDecimal (IntPtr receiver, IntPtr selector, NSDecimal arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_NSDecimal (IntPtr receiver, IntPtr selector, NSDecimal arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_short_IntPtr (IntPtr receiver, IntPtr selector, short arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_short_IntPtr (IntPtr receiver, IntPtr selector, short arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_UInt32_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3, IntPtr arg4, global::System.UInt32 arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_UInt32_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3, IntPtr arg4, global::System.UInt32 arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_UInt32_int (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_UInt32_int (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void NSOperatingSystemVersion_objc_msgSend_stret (out NSOperatingSystemVersion retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void NSOperatingSystemVersion_objc_msgSendSuper_stret (out NSOperatingSystemVersion retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UInt64_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_NSOperatingSystemVersion (IntPtr receiver, IntPtr selector, NSOperatingSystemVersion arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_NSOperatingSystemVersion (IntPtr receiver, IntPtr selector, NSOperatingSystemVersion arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_IntPtr_int_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, int arg4, ref IntPtr arg5, IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_IntPtr_int_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, int arg4, ref IntPtr arg5, IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_bool_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_bool_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_ref_Boolean (IntPtr receiver, IntPtr selector, IntPtr arg1, ref bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_ref_Boolean (IntPtr receiver, IntPtr selector, IntPtr arg1, ref bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_int_IntPtr_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3, bool arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_int_IntPtr_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3, bool arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_int_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, ref IntPtr arg5, ref IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, ref IntPtr arg5, ref IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_bool_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_bool_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_out_NSURLRelationship_int_int_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, out NSUrlRelationship arg1, int arg2, int arg3, IntPtr arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_out_NSURLRelationship_int_int_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, out NSUrlRelationship arg1, int arg2, int arg3, IntPtr arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_out_NSURLRelationship_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, out NSUrlRelationship arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_out_NSURLRelationship_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, out NSUrlRelationship arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_int_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_int_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_IntPtr_int_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_IntPtr_int_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_ref_NSPropertyListFormat_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref NSPropertyListFormat arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_ref_NSPropertyListFormat_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref NSPropertyListFormat arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void Vector3d_objc_msgSend_stret (out global::OpenTK.Vector3d retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void Vector3d_objc_msgSendSuper_stret (out global::OpenTK.Vector3d retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void Quaterniond_objc_msgSend_stret (out global::OpenTK.Quaterniond retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void Quaterniond_objc_msgSendSuper_stret (out global::OpenTK.Quaterniond retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, global::System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, global::System.IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void NSRange_objc_msgSend_stret (out NSRange retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void NSRange_objc_msgSendSuper_stret (out NSRange retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static NSRange NSRange_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static NSRange NSRange_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_IntPtr_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, global::System.Double arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_IntPtr_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, global::System.Double arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, global::System.Double arg5, IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, global::System.Double arg5, IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void IntPtr_objc_msgSend_stret (IntPtr retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void IntPtr_objc_msgSendSuper_stret (IntPtr retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Vector4 (IntPtr receiver, IntPtr selector, global::OpenTK.Vector4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Vector4 (IntPtr receiver, IntPtr selector, global::OpenTK.Vector4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void Matrix3_objc_msgSend_stret (out global::OpenTK.Matrix3 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void Matrix3_objc_msgSendSuper_stret (out global::OpenTK.Matrix3 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Matrix4 (IntPtr receiver, IntPtr selector, global::OpenTK.Matrix4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Matrix4 (IntPtr receiver, IntPtr selector, global::OpenTK.Matrix4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Matrix3 (IntPtr receiver, IntPtr selector, global::OpenTK.Matrix3 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Matrix3 (IntPtr receiver, IntPtr selector, global::OpenTK.Matrix3 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_SizeF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_SizeF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void MKMapRect_objc_msgSend_stret (out global::MapKit.MKMapRect retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void MKMapRect_objc_msgSendSuper_stret (out global::MapKit.MKMapRect retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_MKMapRect (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_MKMapRect (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_bool_bool (IntPtr receiver, IntPtr selector, bool arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_bool_bool (IntPtr receiver, IntPtr selector, bool arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_MKMapRect (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_MKMapRect (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void MKCoordinateRegion_objc_msgSend_stret (out global::MapKit.MKCoordinateRegion retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void MKCoordinateRegion_objc_msgSendSuper_stret (out global::MapKit.MKCoordinateRegion retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MKCoordinateRegion (IntPtr receiver, IntPtr selector, global::MapKit.MKCoordinateRegion arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MKCoordinateRegion (IntPtr receiver, IntPtr selector, global::MapKit.MKCoordinateRegion arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MKMapRect (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MKMapRect (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MKCoordinateRegion_bool (IntPtr receiver, IntPtr selector, global::MapKit.MKCoordinateRegion arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MKCoordinateRegion_bool (IntPtr receiver, IntPtr selector, global::MapKit.MKCoordinateRegion arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CLLocationCoordinate2D_bool (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CLLocationCoordinate2D_bool (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void MKCoordinateRegion_objc_msgSend_stret_MKCoordinateRegion (out global::MapKit.MKCoordinateRegion retval, IntPtr receiver, IntPtr selector, global::MapKit.MKCoordinateRegion arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void MKCoordinateRegion_objc_msgSendSuper_stret_MKCoordinateRegion (out global::MapKit.MKCoordinateRegion retval, IntPtr receiver, IntPtr selector, global::MapKit.MKCoordinateRegion arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void PointF_objc_msgSend_stret_CLLocationCoordinate2D_IntPtr (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void PointF_objc_msgSendSuper_stret_CLLocationCoordinate2D_IntPtr (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSend_CLLocationCoordinate2D_IntPtr (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CLLocationCoordinate2D_objc_msgSend_stret_PointF_IntPtr (out global::CoreLocation.CLLocationCoordinate2D retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CLLocationCoordinate2D_objc_msgSendSuper_stret_PointF_IntPtr (out global::CoreLocation.CLLocationCoordinate2D retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_MKCoordinateRegion_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::MapKit.MKCoordinateRegion arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_MKCoordinateRegion_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::MapKit.MKCoordinateRegion arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void MKCoordinateRegion_objc_msgSend_stret_RectangleF_IntPtr (out global::MapKit.MKCoordinateRegion retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void MKCoordinateRegion_objc_msgSendSuper_stret_RectangleF_IntPtr (out global::MapKit.MKCoordinateRegion retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void MKMapRect_objc_msgSend_stret_MKMapRect (out global::MapKit.MKMapRect retval, IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void MKMapRect_objc_msgSendSuper_stret_MKMapRect (out global::MapKit.MKMapRect retval, IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MKMapRect_UIEdgeInsets_bool (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1, global::UIKit.UIEdgeInsets arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MKMapRect_UIEdgeInsets_bool (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1, global::UIKit.UIEdgeInsets arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MKMapRect_bool (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MKMapRect_bool (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void MKMapRect_objc_msgSend_stret_MKMapRect_UIEdgeInsets (out global::MapKit.MKMapRect retval, IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1, global::UIKit.UIEdgeInsets arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void MKMapRect_objc_msgSendSuper_stret_MKMapRect_UIEdgeInsets (out global::MapKit.MKMapRect retval, IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1, global::UIKit.UIEdgeInsets arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_IntPtr (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void PointF_objc_msgSend_stret_MKMapPoint (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::MapKit.MKMapPoint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void PointF_objc_msgSendSuper_stret_MKMapPoint (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::MapKit.MKMapPoint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSend_MKMapPoint (IntPtr receiver, IntPtr selector, global::MapKit.MKMapPoint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_MKMapPoint (IntPtr receiver, IntPtr selector, global::MapKit.MKMapPoint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void MKMapPoint_objc_msgSend_stret_PointF (out global::MapKit.MKMapPoint retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void MKMapPoint_objc_msgSendSuper_stret_PointF (out global::MapKit.MKMapPoint retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_MKMapRect (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_MKMapRect (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void MKMapRect_objc_msgSend_stret_RectangleF (out global::MapKit.MKMapRect retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void MKMapRect_objc_msgSendSuper_stret_RectangleF (out global::MapKit.MKMapRect retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_MKMapRect_float (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_MKMapRect_float (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MKMapRect_float_IntPtr (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1, float arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MKMapRect_float_IntPtr (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1, float arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MKMapRect_float (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MKMapRect_float (IntPtr receiver, IntPtr selector, global::MapKit.MKMapRect arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_CLLocationCoordinate2D_Double (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, global::CoreLocation.CLLocationCoordinate2D arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_CLLocationCoordinate2D_Double (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, global::CoreLocation.CLLocationCoordinate2D arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void PointF_objc_msgSend_stret_CLLocationCoordinate2D (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void PointF_objc_msgSendSuper_stret_CLLocationCoordinate2D (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSend_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_MKTileOverlayPath (IntPtr receiver, IntPtr selector, global::MapKit.MKTileOverlayPath arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_MKTileOverlayPath (IntPtr receiver, IntPtr selector, global::MapKit.MKTileOverlayPath arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MKTileOverlayPath_IntPtr (IntPtr receiver, IntPtr selector, global::MapKit.MKTileOverlayPath arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MKTileOverlayPath_IntPtr (IntPtr receiver, IntPtr selector, global::MapKit.MKTileOverlayPath arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_IntPtr_IntPtr_ref_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_IntPtr_ref_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.RectangleF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.RectangleF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_ref_SCNVector3_ref_SCNVector3 (IntPtr receiver, IntPtr selector, ref global::SceneKit.SCNVector3 arg1, ref global::SceneKit.SCNVector3 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_ref_SCNVector3_ref_SCNVector3 (IntPtr receiver, IntPtr selector, ref global::SceneKit.SCNVector3 arg1, ref global::SceneKit.SCNVector3 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_ref_SCNVector3_ref_SCNVector3 (IntPtr receiver, IntPtr selector, ref global::SceneKit.SCNVector3 arg1, ref global::SceneKit.SCNVector3 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_ref_SCNVector3_ref_SCNVector3 (IntPtr receiver, IntPtr selector, ref global::SceneKit.SCNVector3 arg1, ref global::SceneKit.SCNVector3 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_ref_SCNVector3_ref_Single (IntPtr receiver, IntPtr selector, ref global::SceneKit.SCNVector3 arg1, ref float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_ref_SCNVector3_ref_Single (IntPtr receiver, IntPtr selector, ref global::SceneKit.SCNVector3 arg1, ref float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_SCNMatrix4 (IntPtr receiver, IntPtr selector, global::SceneKit.SCNMatrix4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_SCNMatrix4 (IntPtr receiver, IntPtr selector, global::SceneKit.SCNMatrix4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_bool_int_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, bool arg4, int arg5, int arg6, int arg7, int arg8);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_bool_int_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, bool arg4, int arg5, int arg6, int arg7, int arg8);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void PointF_objc_msgSend_stret_int (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void PointF_objc_msgSendSuper_stret_int (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_SCNVector3 (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_SCNVector3 (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_SCNVector4 (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_SCNVector4 (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SCNQuaternion_objc_msgSend_stret (out global::SceneKit.SCNQuaternion retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SCNQuaternion_objc_msgSendSuper_stret (out global::SceneKit.SCNQuaternion retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_SCNQuaternion (IntPtr receiver, IntPtr selector, global::SceneKit.SCNQuaternion arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_SCNQuaternion (IntPtr receiver, IntPtr selector, global::SceneKit.SCNQuaternion arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SCNVector3_objc_msgSend_stret_SCNVector3_IntPtr (out global::SceneKit.SCNVector3 retval, IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SCNVector3_objc_msgSendSuper_stret_SCNVector3_IntPtr (out global::SceneKit.SCNVector3 retval, IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SCNMatrix4_objc_msgSend_stret_SCNMatrix4_IntPtr (out global::SceneKit.SCNMatrix4 retval, IntPtr receiver, IntPtr selector, global::SceneKit.SCNMatrix4 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SCNMatrix4_objc_msgSendSuper_stret_SCNMatrix4_IntPtr (out global::SceneKit.SCNMatrix4 retval, IntPtr receiver, IntPtr selector, global::SceneKit.SCNMatrix4 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_SCNVector3_SCNVector3_IntPtr (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1, global::SceneKit.SCNVector3 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_SCNVector3_SCNVector3_IntPtr (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1, global::SceneKit.SCNVector3 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SCNVector3_objc_msgSend_stret_SCNVector3 (out global::SceneKit.SCNVector3 retval, IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SCNVector3_objc_msgSendSuper_stret_SCNVector3 (out global::SceneKit.SCNVector3 retval, IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_SCNMatrix4 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::SceneKit.SCNMatrix4 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_SCNMatrix4 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::SceneKit.SCNMatrix4 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_float_UInt32 (IntPtr receiver, IntPtr selector, float arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_float_UInt32 (IntPtr receiver, IntPtr selector, float arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_float_float_Double (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, global::System.Double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_float_float_Double (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, global::System.Double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_SCNVector3_Double (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_SCNVector3_Double (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_SCNVector3_Double (IntPtr receiver, IntPtr selector, float arg1, global::SceneKit.SCNVector3 arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_SCNVector3_Double (IntPtr receiver, IntPtr selector, float arg1, global::SceneKit.SCNVector3 arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_float_float_Double_bool (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, global::System.Double arg4, bool arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_float_float_Double_bool (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, global::System.Double arg4, bool arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_SCNVector4_Double (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector4 arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_SCNVector4_Double (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector4 arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_Double (IntPtr receiver, IntPtr selector, float arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_Double (IntPtr receiver, IntPtr selector, float arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_SCNVector3_bool (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_SCNVector3_bool (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_SCNVector3_SCNVector3_bool (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1, global::SceneKit.SCNVector3 arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_SCNVector3_SCNVector3_bool (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector3 arg1, global::SceneKit.SCNVector3 arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_SCNVector4_bool (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector4 arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_SCNVector4_bool (IntPtr receiver, IntPtr selector, global::SceneKit.SCNVector4 arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_SCNMatrix4_SCNMatrix4_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::SceneKit.SCNMatrix4 arg2, global::SceneKit.SCNMatrix4 arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_SCNMatrix4_SCNMatrix4_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::SceneKit.SCNMatrix4 arg2, global::SceneKit.SCNMatrix4 arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_SCNVector3_SCNVector3_IntPtr_SCNVector3_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::SceneKit.SCNVector3 arg2, global::SceneKit.SCNVector3 arg3, IntPtr arg4, global::SceneKit.SCNVector3 arg5, global::SceneKit.SCNVector3 arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_SCNVector3_SCNVector3_IntPtr_SCNVector3_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::SceneKit.SCNVector3 arg2, global::SceneKit.SCNVector3 arg3, IntPtr arg4, global::SceneKit.SCNVector3 arg5, global::SceneKit.SCNVector3 arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_SCNVector3_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::SceneKit.SCNVector3 arg2, global::SceneKit.SCNVector3 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_SCNVector3_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::SceneKit.SCNVector3 arg2, global::SceneKit.SCNVector3 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_SCNVector3_IntPtr_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::SceneKit.SCNVector3 arg2, IntPtr arg3, global::SceneKit.SCNVector3 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_SCNVector3_IntPtr_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::SceneKit.SCNVector3 arg2, IntPtr arg3, global::SceneKit.SCNVector3 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::SceneKit.SCNVector3 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::SceneKit.SCNVector3 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_float_int (IntPtr receiver, IntPtr selector, float arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_float_int (IntPtr receiver, IntPtr selector, float arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void Vector3_objc_msgSend_stret_Vector3 (out global::OpenTK.Vector3 retval, IntPtr receiver, IntPtr selector, global::OpenTK.Vector3 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void Vector3_objc_msgSendSuper_stret_Vector3 (out global::OpenTK.Vector3 retval, IntPtr receiver, IntPtr selector, global::OpenTK.Vector3 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void PointF_objc_msgSend_stret_IntPtr (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void PointF_objc_msgSendSuper_stret_IntPtr (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void Vector4_objc_msgSend_stret (out global::OpenTK.Vector4 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void Vector4_objc_msgSendSuper_stret (out global::OpenTK.Vector4 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_Vector4 (IntPtr receiver, IntPtr selector, global::OpenTK.Vector4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_Vector4 (IntPtr receiver, IntPtr selector, global::OpenTK.Vector4 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.SizeF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.SizeF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_float_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_float_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CGVector (IntPtr receiver, IntPtr selector, CGVector arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CGVector (IntPtr receiver, IntPtr selector, CGVector arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_RectangleF_float (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_RectangleF_float (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_SizeF_float (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_SizeF_float (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_ref_PointF_UInt32 (IntPtr receiver, IntPtr selector, ref global::System.Drawing.PointF arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_ref_PointF_UInt32 (IntPtr receiver, IntPtr selector, ref global::System.Drawing.PointF arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_PointF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_PointF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_PointF_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_PointF_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_Double (IntPtr receiver, IntPtr selector, int arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_Double (IntPtr receiver, IntPtr selector, int arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_SizeF_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, global::System.UInt32 arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_SizeF_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, global::System.UInt32 arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_SizeF (IntPtr receiver, IntPtr selector, float arg1, global::System.Drawing.SizeF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_SizeF (IntPtr receiver, IntPtr selector, float arg1, global::System.Drawing.SizeF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_SizeF_bool (IntPtr receiver, IntPtr selector, float arg1, global::System.Drawing.SizeF arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_SizeF_bool (IntPtr receiver, IntPtr selector, float arg1, global::System.Drawing.SizeF arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_SizeF_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_SizeF_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_SizeF_UInt32 (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_SizeF_UInt32 (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void Vector2_objc_msgSend_stret (out global::OpenTK.Vector2 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void Vector2_objc_msgSendSuper_stret (out global::OpenTK.Vector2 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::OpenTK.Vector2 Vector2_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::OpenTK.Vector2 Vector2_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Vector2 (IntPtr receiver, IntPtr selector, global::OpenTK.Vector2 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Vector2 (IntPtr receiver, IntPtr selector, global::OpenTK.Vector2 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void Matrix2_objc_msgSend_stret (out global::OpenTK.Matrix2 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void Matrix2_objc_msgSendSuper_stret (out global::OpenTK.Matrix2 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Matrix2 (IntPtr receiver, IntPtr selector, global::OpenTK.Matrix2 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Matrix2 (IntPtr receiver, IntPtr selector, global::OpenTK.Matrix2 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void Matrix4_objc_msgSend_stret (out global::OpenTK.Matrix4 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void Matrix4_objc_msgSendSuper_stret (out global::OpenTK.Matrix4 retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_Vector2 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::OpenTK.Vector2 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_Vector2 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::OpenTK.Vector2 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_Vector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::OpenTK.Vector3 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_Vector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::OpenTK.Vector3 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_Vector4 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::OpenTK.Vector4 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_Vector4 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::OpenTK.Vector4 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_Matrix2 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::OpenTK.Matrix2 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_Matrix2 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::OpenTK.Matrix2 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_Matrix3 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::OpenTK.Matrix3 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_Matrix3 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::OpenTK.Matrix3 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_Matrix4 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::OpenTK.Matrix4 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_Matrix4 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::OpenTK.Matrix4 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_float_Double (IntPtr receiver, IntPtr selector, float arg1, float arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_float_Double (IntPtr receiver, IntPtr selector, float arg1, float arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_CGVector_Double (IntPtr receiver, IntPtr selector, CGVector arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_CGVector_Double (IntPtr receiver, IntPtr selector, CGVector arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_PointF_Double (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_PointF_Double (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_Double_bool (IntPtr receiver, IntPtr selector, float arg1, global::System.Double arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_Double_bool (IntPtr receiver, IntPtr selector, float arg1, global::System.Double arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_Double_bool_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2, bool arg3, bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_Double_bool_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2, bool arg3, bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_float_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_float_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_bool_bool_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, global::System.Double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool_bool_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, global::System.Double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_bool_bool_float (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, float arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool_bool_float (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, float arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_PointF_IntPtr_Double (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_PointF_IntPtr_Double (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_PointF_IntPtr_float (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_PointF_IntPtr_float (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_float_PointF (IntPtr receiver, IntPtr selector, float arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_float_PointF (IntPtr receiver, IntPtr selector, float arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_SizeF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_SizeF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CGVector_PointF (IntPtr receiver, IntPtr selector, CGVector arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CGVector_PointF (IntPtr receiver, IntPtr selector, CGVector arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_float_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, global::System.Drawing.SizeF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_float_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, global::System.Drawing.SizeF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_PointF_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_PointF_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.PointF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.PointF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_PointF_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.PointF arg3, global::System.Drawing.PointF arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_PointF_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.PointF arg3, global::System.Drawing.PointF arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_PointF_CGVector (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.PointF arg3, CGVector arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_PointF_CGVector (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.PointF arg3, CGVector arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.IntPtr arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.IntPtr arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_Int64_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.Int64 arg2, global::System.UInt32 arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_Int64_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.Int64 arg2, global::System.UInt32 arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CMAcceleration_objc_msgSend_stret (out global::CoreMotion.CMAcceleration retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CMAcceleration_objc_msgSendSuper_stret (out global::CoreMotion.CMAcceleration retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CMRotationMatrix_objc_msgSend_stret (out global::CoreMotion.CMRotationMatrix retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CMRotationMatrix_objc_msgSendSuper_stret (out global::CoreMotion.CMRotationMatrix retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CMQuaternion_objc_msgSend_stret (out global::CoreMotion.CMQuaternion retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CMQuaternion_objc_msgSendSuper_stret (out global::CoreMotion.CMQuaternion retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CMRotationRate_objc_msgSend_stret (out global::CoreMotion.CMRotationRate retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CMRotationRate_objc_msgSendSuper_stret (out global::CoreMotion.CMRotationRate retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CMCalibratedMagneticField_objc_msgSend_stret (out global::CoreMotion.CMCalibratedMagneticField retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CMCalibratedMagneticField_objc_msgSendSuper_stret (out global::CoreMotion.CMCalibratedMagneticField retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CMMagneticField_objc_msgSend_stret (out global::CoreMotion.CMMagneticField retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CMMagneticField_objc_msgSendSuper_stret (out global::CoreMotion.CMMagneticField retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_int_int_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_int_int_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, global::System.UInt32 arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, global::System.UInt32 arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr_Double_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2, IntPtr arg3, global::System.Double arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr_IntPtr_Double_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2, IntPtr arg3, global::System.Double arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_RectangleF_RectangleF_float (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_RectangleF_RectangleF_float (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_float_float_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, float arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_float_float_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, float arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MTLSize_MTLSize (IntPtr receiver, IntPtr selector, global::Metal.MTLSize arg1, global::Metal.MTLSize arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MTLSize_MTLSize (IntPtr receiver, IntPtr selector, global::Metal.MTLSize arg1, global::Metal.MTLSize arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.IntPtr arg2, global::System.IntPtr arg3, NSRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.IntPtr arg2, global::System.IntPtr arg3, NSRange arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32_UInt32_MTLOrigin_MTLSize_IntPtr_UInt32_UInt32_MTLOrigin (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, global::Metal.MTLOrigin arg4, global::Metal.MTLSize arg5, IntPtr arg6, global::System.UInt32 arg7, global::System.UInt32 arg8, global::Metal.MTLOrigin arg9);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32_UInt32_MTLOrigin_MTLSize_IntPtr_UInt32_UInt32_MTLOrigin (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, global::Metal.MTLOrigin arg4, global::Metal.MTLSize arg5, IntPtr arg6, global::System.UInt32 arg7, global::System.UInt32 arg8, global::Metal.MTLOrigin arg9);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32_UInt32_UInt32_MTLSize_IntPtr_UInt32_UInt32_MTLOrigin (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, global::System.UInt32 arg4, global::Metal.MTLSize arg5, IntPtr arg6, global::System.UInt32 arg7, global::System.UInt32 arg8, global::Metal.MTLOrigin arg9);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32_UInt32_UInt32_MTLSize_IntPtr_UInt32_UInt32_MTLOrigin (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, global::System.UInt32 arg4, global::Metal.MTLSize arg5, IntPtr arg6, global::System.UInt32 arg7, global::System.UInt32 arg8, global::Metal.MTLOrigin arg9);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32_UInt32_MTLOrigin_MTLSize_IntPtr_UInt32_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, global::Metal.MTLOrigin arg4, global::Metal.MTLSize arg5, IntPtr arg6, global::System.UInt32 arg7, global::System.UInt32 arg8, global::System.UInt32 arg9);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32_UInt32_MTLOrigin_MTLSize_IntPtr_UInt32_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, global::Metal.MTLOrigin arg4, global::Metal.MTLSize arg5, IntPtr arg6, global::System.UInt32 arg7, global::System.UInt32 arg8, global::System.UInt32 arg9);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_NSRange_byte (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, byte arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_NSRange_byte (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, byte arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3, global::System.UInt32 arg4, global::System.UInt32 arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3, global::System.UInt32 arg4, global::System.UInt32 arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, ref IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, ref IntPtr arg3, ref IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32_UInt32_MTLRegion_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, global::Metal.MTLRegion arg4, global::System.UInt32 arg5, global::System.UInt32 arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32_UInt32_MTLRegion_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, global::Metal.MTLRegion arg4, global::System.UInt32 arg5, global::System.UInt32 arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32_MTLRegion_UInt32 (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.UInt32 arg2, global::Metal.MTLRegion arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32_MTLRegion_UInt32 (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.UInt32 arg2, global::Metal.MTLRegion arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MTLRegion_UInt32_UInt32_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::Metal.MTLRegion arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, global::System.IntPtr arg4, global::System.UInt32 arg5, global::System.UInt32 arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MTLRegion_UInt32_UInt32_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::Metal.MTLRegion arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, global::System.IntPtr arg4, global::System.UInt32 arg5, global::System.UInt32 arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MTLRegion_UInt32_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, global::Metal.MTLRegion arg1, global::System.UInt32 arg2, global::System.IntPtr arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MTLRegion_UInt32_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, global::Metal.MTLRegion arg1, global::System.UInt32 arg2, global::System.IntPtr arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UInt32_UInt32_UInt32_bool (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32_UInt32_bool (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UInt32_UInt32_bool (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32_bool (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MTLViewport (IntPtr receiver, IntPtr selector, global::Metal.MTLViewport arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MTLViewport (IntPtr receiver, IntPtr selector, global::Metal.MTLViewport arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MTLScissorRect (IntPtr receiver, IntPtr selector, global::Metal.MTLScissorRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MTLScissorRect (IntPtr receiver, IntPtr selector, global::Metal.MTLScissorRect arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt32_UInt32_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt32_UInt32_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt32_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt32_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt32_UInt32_UInt32_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, IntPtr arg4, global::System.UInt32 arg5, global::System.UInt32 arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt32_UInt32_UInt32_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, IntPtr arg4, global::System.UInt32 arg5, global::System.UInt32 arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UInt32_UInt32_UInt32_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, IntPtr arg4, global::System.UInt32 arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UInt32_UInt32_UInt32_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, IntPtr arg4, global::System.UInt32 arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void MTLClearColor_objc_msgSend_stret (out global::Metal.MTLClearColor retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void MTLClearColor_objc_msgSendSuper_stret (out global::Metal.MTLClearColor retval, IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_MTLClearColor (IntPtr receiver, IntPtr selector, global::Metal.MTLClearColor arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_MTLClearColor (IntPtr receiver, IntPtr selector, global::Metal.MTLClearColor arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.Double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.Double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void UIEdgeInsets_objc_msgSend_stret_UIEdgeInsets (out global::UIKit.UIEdgeInsets retval, IntPtr receiver, IntPtr selector, global::UIKit.UIEdgeInsets arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void UIEdgeInsets_objc_msgSendSuper_stret_UIEdgeInsets (out global::UIKit.UIEdgeInsets retval, IntPtr receiver, IntPtr selector, global::UIKit.UIEdgeInsets arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_SizeF_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, int arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_SizeF_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, int arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_SizeF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_SizeF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_int_IntPtr_int_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4, int arg5, float arg6, float arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int_IntPtr_int_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4, int arg5, float arg6, float arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_int_float_IntPtr (IntPtr receiver, IntPtr selector, int arg1, float arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_int_float_IntPtr (IntPtr receiver, IntPtr selector, int arg1, float arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_RectangleF_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_RectangleF_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_IntPtr_RectangleF_PointF_UInt32 (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, global::System.Drawing.PointF arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_RectangleF_PointF_UInt32 (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, global::System.Drawing.PointF arg3, global::System.UInt32 arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_RectangleF_UInt32_int_out_RectangleF (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.UInt32 arg2, int arg3, out global::System.Drawing.RectangleF arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_RectangleF_UInt32_int_out_RectangleF (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.UInt32 arg2, int arg3, out global::System.Drawing.RectangleF arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_NSRange_int (IntPtr receiver, IntPtr selector, int arg1, NSRange arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_NSRange_int (IntPtr receiver, IntPtr selector, int arg1, NSRange arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_NSRange_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_NSRange_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_NSRange_int_out_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, out NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_NSRange_int_out_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, out NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_NSRange_out_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1, out NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_NSRange_out_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1, out NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_NSRange_int_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3, int arg4, NSRange arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_NSRange_int_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3, int arg4, NSRange arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.IntPtr arg2, global::System.IntPtr arg3, IntPtr arg4, NSRange arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.IntPtr arg2, global::System.IntPtr arg3, IntPtr arg4, NSRange arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt16 UInt16_objc_msgSend_UInt32_ref_Boolean (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, ref bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt16 UInt16_objc_msgSendSuper_UInt32_ref_Boolean (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, ref bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt16 UInt16_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt16 UInt16_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt32 UInt32_objc_msgSend_NSRange_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, global::System.IntPtr arg2, global::System.IntPtr arg3, global::System.IntPtr arg4, global::System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt32 UInt32_objc_msgSendSuper_NSRange_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, global::System.IntPtr arg2, global::System.IntPtr arg3, global::System.IntPtr arg4, global::System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_NSRange_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, NSRange arg2, global::System.Drawing.RectangleF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_NSRange_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, NSRange arg2, global::System.Drawing.RectangleF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_PointF_NSRange (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_PointF_NSRange (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_bool_UInt32 (IntPtr receiver, IntPtr selector, bool arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_bool_UInt32 (IntPtr receiver, IntPtr selector, bool arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_SizeF_NSRange (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_SizeF_NSRange (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, NSRange arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_ref_UInt32_ref_UInt32 (IntPtr receiver, IntPtr selector, ref global::System.UInt32 arg1, ref global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_ref_UInt32_ref_UInt32 (IntPtr receiver, IntPtr selector, ref global::System.UInt32 arg1, ref global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_UInt32_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_UInt32_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void PointF_objc_msgSend_stret_UInt32 (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void PointF_objc_msgSendSuper_stret_UInt32 (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_UInt32 (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_UInt32 (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void NSRange_objc_msgSend_stret_UInt32 (out NSRange retval, IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void NSRange_objc_msgSendSuper_stret_UInt32 (out NSRange retval, IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static NSRange NSRange_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static NSRange NSRange_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void NSRange_objc_msgSend_stret_NSRange_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1, global::System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void NSRange_objc_msgSendSuper_stret_NSRange_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1, global::System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static NSRange NSRange_objc_msgSend_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, global::System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static NSRange NSRange_objc_msgSendSuper_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, global::System.IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void NSRange_objc_msgSend_stret_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void NSRange_objc_msgSendSuper_stret_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static NSRange NSRange_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static NSRange NSRange_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_NSRange_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_NSRange_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void NSRange_objc_msgSend_stret_RectangleF_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void NSRange_objc_msgSendSuper_stret_RectangleF_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static NSRange NSRange_objc_msgSend_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static NSRange NSRange_objc_msgSendSuper_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt32 UInt32_objc_msgSend_PointF_IntPtr_ref_Single (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2, ref float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt32 UInt32_objc_msgSendSuper_PointF_IntPtr_ref_Single (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2, ref float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt32 UInt32_objc_msgSend_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt32 UInt32_objc_msgSendSuper_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static float float_objc_msgSend_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static float float_objc_msgSendSuper_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt32 UInt32_objc_msgSend_UInt32_bool_bool_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, bool arg2, bool arg3, global::System.IntPtr arg4, global::System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt32 UInt32_objc_msgSendSuper_UInt32_bool_bool_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, bool arg2, bool arg3, global::System.IntPtr arg4, global::System.IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_NSRange_NSRange_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, NSRange arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_NSRange_NSRange_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, NSRange arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_NSRange_PointF (IntPtr receiver, IntPtr selector, NSRange arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_NSRange_PointF (IntPtr receiver, IntPtr selector, NSRange arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr_CGAffineTransform_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.IntPtr arg2, global::System.UInt32 arg3, IntPtr arg4, CGAffineTransform arg5, IntPtr arg6, IntPtr arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr_CGAffineTransform_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.IntPtr arg2, global::System.UInt32 arg3, IntPtr arg4, CGAffineTransform arg5, IntPtr arg6, IntPtr arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_NSRange_int_float_RectangleF_NSRange_PointF (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, float arg3, global::System.Drawing.RectangleF arg4, NSRange arg5, global::System.Drawing.PointF arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_NSRange_int_float_RectangleF_NSRange_PointF (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, float arg3, global::System.Drawing.RectangleF arg4, NSRange arg5, global::System.Drawing.PointF arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_NSRange_int_RectangleF_NSRange_PointF (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, global::System.Drawing.RectangleF arg3, NSRange arg4, global::System.Drawing.PointF arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_NSRange_int_RectangleF_NSRange_PointF (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, global::System.Drawing.RectangleF arg3, NSRange arg4, global::System.Drawing.PointF arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.IntPtr arg2, global::System.IntPtr arg3, global::System.IntPtr arg4, IntPtr arg5, NSRange arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.IntPtr arg2, global::System.IntPtr arg3, global::System.IntPtr arg4, IntPtr arg5, NSRange arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static float float_objc_msgSend_IntPtr_UInt32_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.Drawing.RectangleF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static float float_objc_msgSendSuper_IntPtr_UInt32_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.Drawing.RectangleF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_IntPtr_int_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_IntPtr_int_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_IntPtr_UInt32_IntPtr_RectangleF_PointF_UInt32 (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3, global::System.Drawing.RectangleF arg4, global::System.Drawing.PointF arg5, global::System.UInt32 arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_UInt32_IntPtr_RectangleF_PointF_UInt32 (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3, global::System.Drawing.RectangleF arg4, global::System.Drawing.PointF arg5, global::System.UInt32 arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.SizeF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.SizeF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CGVector_IntPtr (IntPtr receiver, IntPtr selector, CGVector arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CGVector_IntPtr (IntPtr receiver, IntPtr selector, CGVector arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_SizeF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_SizeF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_CGAffineTransform_IntPtr (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_CGAffineTransform_IntPtr (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UIEdgeInsets_IntPtr (IntPtr receiver, IntPtr selector, global::UIKit.UIEdgeInsets arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UIEdgeInsets_IntPtr (IntPtr receiver, IntPtr selector, global::UIKit.UIEdgeInsets arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UIOffset_IntPtr (IntPtr receiver, IntPtr selector, global::UIKit.UIOffset arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UIOffset_IntPtr (IntPtr receiver, IntPtr selector, global::UIKit.UIOffset arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CGVector_objc_msgSend_stret_IntPtr (out CGVector retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CGVector_objc_msgSendSuper_stret_IntPtr (out CGVector retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static CGVector CGVector_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static CGVector CGVector_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void CGAffineTransform_objc_msgSend_stret_IntPtr (out CGAffineTransform retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void CGAffineTransform_objc_msgSendSuper_stret_IntPtr (out CGAffineTransform retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void UIEdgeInsets_objc_msgSend_stret_IntPtr (out global::UIKit.UIEdgeInsets retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void UIEdgeInsets_objc_msgSendSuper_stret_IntPtr (out global::UIKit.UIEdgeInsets retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void UIOffset_objc_msgSend_stret_IntPtr (out global::UIKit.UIOffset retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void UIOffset_objc_msgSendSuper_stret_IntPtr (out global::UIKit.UIOffset retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::UIKit.UIOffset UIOffset_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::UIKit.UIOffset UIOffset_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, global::System.IntPtr arg5, global::System.IntPtr arg6, global::System.IntPtr arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, global::System.IntPtr arg5, global::System.IntPtr arg6, global::System.IntPtr arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_bool_int (IntPtr receiver, IntPtr selector, bool arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_bool_int (IntPtr receiver, IntPtr selector, bool arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_UIOffset_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::UIKit.UIOffset arg2, global::System.Drawing.PointF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_UIOffset_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::UIKit.UIOffset arg2, global::System.Drawing.PointF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_UIOffset_IntPtr_UIOffset (IntPtr receiver, IntPtr selector, IntPtr arg1, global::UIKit.UIOffset arg2, IntPtr arg3, global::UIKit.UIOffset arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_UIOffset_IntPtr_UIOffset (IntPtr receiver, IntPtr selector, IntPtr arg1, global::UIKit.UIOffset arg2, IntPtr arg3, global::UIKit.UIOffset arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UIEdgeInsets (IntPtr receiver, IntPtr selector, global::UIKit.UIEdgeInsets arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UIEdgeInsets (IntPtr receiver, IntPtr selector, global::UIKit.UIEdgeInsets arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UIOffset_int (IntPtr receiver, IntPtr selector, global::UIKit.UIOffset arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UIOffset_int (IntPtr receiver, IntPtr selector, global::UIKit.UIOffset arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void UIOffset_objc_msgSend_stret_int (out global::UIKit.UIOffset retval, IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void UIOffset_objc_msgSendSuper_stret_int (out global::UIKit.UIOffset retval, IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::UIKit.UIOffset UIOffset_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::UIKit.UIOffset UIOffset_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, int arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UInt32_int_int (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, int arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UInt32_int_int (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, int arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_bool_int (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_bool_int (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_PointF_ref_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, ref global::System.Drawing.PointF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_PointF_ref_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, ref global::System.Drawing.PointF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_IntPtr_IntPtr_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_IntPtr_IntPtr_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void UIEdgeInsets_objc_msgSend_stret_IntPtr_IntPtr_int (out global::UIKit.UIEdgeInsets retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void UIEdgeInsets_objc_msgSendSuper_stret_IntPtr_IntPtr_int (out global::UIKit.UIEdgeInsets retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static float float_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static float float_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_IntPtr_IntPtr_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_IntPtr_IntPtr_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void PointF_objc_msgSend_stret_PointF_PointF (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void PointF_objc_msgSendSuper_stret_PointF_PointF (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSend_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_out_Single_out_Single (IntPtr receiver, IntPtr selector, out float arg1, out float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_out_Single_out_Single (IntPtr receiver, IntPtr selector, out float arg1, out float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_PointF_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, global::System.Drawing.PointF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_PointF_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, global::System.Drawing.PointF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.Drawing.PointF arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.Drawing.PointF arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_int_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, ref IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_CGAffineTransform (IntPtr receiver, IntPtr selector, IntPtr arg1, CGAffineTransform arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGAffineTransform (IntPtr receiver, IntPtr selector, IntPtr arg1, CGAffineTransform arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void PointF_objc_msgSend_stret_int_IntPtr (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void PointF_objc_msgSendSuper_stret_int_IntPtr (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSend_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_float_int (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_float_int (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_PointF_int_float (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, int arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_PointF_int_float (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, int arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_int_float (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_int_float (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_UIEdgeInsets_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, global::UIKit.UIEdgeInsets arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_UIEdgeInsets_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, global::UIKit.UIEdgeInsets arg2, global::System.Double arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UIEdgeInsets_int (IntPtr receiver, IntPtr selector, global::UIKit.UIEdgeInsets arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UIEdgeInsets_int (IntPtr receiver, IntPtr selector, global::UIKit.UIEdgeInsets arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_UIEdgeInsets_int_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, global::UIKit.UIEdgeInsets arg2, int arg3, global::System.Double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_UIEdgeInsets_int_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, global::UIKit.UIEdgeInsets arg2, int arg3, global::System.Double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_PointF_float_float_float_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, float arg3, float arg4, bool arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_PointF_float_float_float_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, float arg3, float arg4, bool arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_RectangleF_UInt32_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.UInt32 arg2, global::System.Drawing.SizeF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_RectangleF_UInt32_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.UInt32 arg2, global::System.Drawing.SizeF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_PointF_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, global::System.Drawing.PointF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_PointF_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, global::System.Drawing.PointF arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_float (IntPtr receiver, IntPtr selector, int arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_float (IntPtr receiver, IntPtr selector, int arg1, float arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_float (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, int arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_float (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, int arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_PointF_float_float_float_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, float arg3, float arg4, bool arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_PointF_float_float_float_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, float arg3, float arg4, bool arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_RectangleF_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_RectangleF_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_RectangleF_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_RectangleF_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_bool (IntPtr receiver, IntPtr selector, bool arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, bool arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_bool_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_bool_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_int_bool (IntPtr receiver, IntPtr selector, int arg1, int arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_int_bool (IntPtr receiver, IntPtr selector, int arg1, int arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static float float_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static float float_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_float_bool (IntPtr receiver, IntPtr selector, float arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_float_bool (IntPtr receiver, IntPtr selector, float arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_PointF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_PointF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UIOffset (IntPtr receiver, IntPtr selector, global::UIKit.UIOffset arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UIOffset (IntPtr receiver, IntPtr selector, global::UIKit.UIOffset arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_int_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_int_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.UInt32 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_int_UInt32 (IntPtr receiver, IntPtr selector, int arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_int_UInt32 (IntPtr receiver, IntPtr selector, int arg1, global::System.UInt32 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_SizeF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_SizeF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, int arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_UInt32_UInt32_int (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32_int (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_UIOffset_int_int (IntPtr receiver, IntPtr selector, global::UIKit.UIOffset arg1, int arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_UIOffset_int_int (IntPtr receiver, IntPtr selector, global::UIKit.UIOffset arg1, int arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void UIOffset_objc_msgSend_stret_int_int (out global::UIKit.UIOffset retval, IntPtr receiver, IntPtr selector, int arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void UIOffset_objc_msgSendSuper_stret_int_int (out global::UIKit.UIOffset retval, IntPtr receiver, IntPtr selector, int arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::UIKit.UIOffset UIOffset_objc_msgSend_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::UIKit.UIOffset UIOffset_objc_msgSendSuper_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSend_RectangleF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.IntPtr IntPtr_objc_msgSendSuper_RectangleF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static float float_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static float float_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_SizeF (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_SizeF (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_IntPtr_bool (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_IntPtr_bool (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Double_Double_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2, int arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Double_Double_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2, int arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_Double_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3, int arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_Double_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3, int arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_Double_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2, int arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_Double_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2, int arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Double_Double_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2, global::System.UInt32 arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Double_Double_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2, global::System.UInt32 arg3, IntPtr arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_RectangleF_bool_UIEdgeInsets (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, bool arg2, global::UIKit.UIEdgeInsets arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_RectangleF_bool_UIEdgeInsets (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, bool arg2, global::UIKit.UIEdgeInsets arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_RectangleF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_RectangleF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_Double_Double_float_float_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2, float arg3, float arg4, int arg5, IntPtr arg6, IntPtr arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_Double_Double_float_float_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2, float arg3, float arg4, int arg5, IntPtr arg6, IntPtr arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void SizeF_objc_msgSend_stret_SizeF_float_float (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, float arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void SizeF_objc_msgSendSuper_stret_SizeF_float_float (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, float arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSend_SizeF_float_float (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, float arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_SizeF_float_float (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, float arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_Double (IntPtr receiver, IntPtr selector, int arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_Double (IntPtr receiver, IntPtr selector, int arg1, global::System.Double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_IntPtr_Double_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3, int arg4, IntPtr arg5, IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_IntPtr_Double_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3, int arg4, IntPtr arg5, IntPtr arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void NSRange_objc_msgSend_stret_IntPtr_NSRange_int_bool_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, int arg3, bool arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void NSRange_objc_msgSendSuper_stret_IntPtr_NSRange_int_bool_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, int arg3, bool arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static NSRange NSRange_objc_msgSend_IntPtr_NSRange_int_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, int arg3, bool arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static NSRange NSRange_objc_msgSendSuper_IntPtr_NSRange_int_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, int arg3, bool arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_SizeF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_SizeF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, bool arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_IntPtr_UInt32_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, global::System.UInt32 arg3, bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_IntPtr_UInt32_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, global::System.UInt32 arg3, bool arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_UInt32_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_UInt32_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_ref_RectangleF_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref global::System.Drawing.RectangleF arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_ref_RectangleF_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref global::System.Drawing.RectangleF arg2, ref IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_IntPtr_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_IntPtr_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static bool bool_objc_msgSend_RectangleF_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, bool arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static bool bool_objc_msgSendSuper_RectangleF_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, bool arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_int_RectangleF (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.RectangleF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_int_RectangleF (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.RectangleF arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, bool arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, bool arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static void void_objc_msgSend_RectangleF_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.UInt32 arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static void void_objc_msgSendSuper_RectangleF_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.UInt32 arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		internal extern static void RectangleF_objc_msgSend_stret_SizeF_UInt32_IntPtr_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, global::System.UInt32 arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		internal extern static void RectangleF_objc_msgSendSuper_stret_SizeF_UInt32_IntPtr_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, global::System.UInt32 arg2, IntPtr arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		internal extern static int int_objc_msgSend_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		internal extern static int int_objc_msgSendSuper_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
	}
}
