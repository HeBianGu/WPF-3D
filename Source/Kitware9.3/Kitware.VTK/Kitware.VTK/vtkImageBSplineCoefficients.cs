using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageBSplineCoefficients
	/// </summary>
	/// <remarks>
	///    convert image to b-spline knots
	///
	/// vtkImageBSplineCoefficients prepares an image for b-spline
	/// interpolation by converting the image values into b-spline
	/// knot coefficients.  It is a necessary pre-filtering step
	/// before applying b-spline interpolation with vtkImageReslice.
	///
	/// This class is based on code provided by Philippe Thevenaz of
	/// EPFL, Lausanne, Switzerland.  Please acknowledge his contribution
	/// by citing the following paper:
	/// [1] P. Thevenaz, T. Blu, M. Unser, "Interpolation Revisited,"
	///     IEEE Transactions on Medical Imaging 19(7):739-758, 2000.
	///
	/// The clamped boundary condition (which is the default) is taken
	/// from code presented in the following paper:
	/// [2] D. Ruijters, P. Thevenaz,
	///     "GPU Prefilter for Accurate Cubic B-spline Interpolation,"
	///     The Computer Journal, doi: 10.1093/comjnl/bxq086, 2010.
	///
	/// @par Thanks:
	/// This class was written by David Gobbi at the Seaman Family MR Research
	/// Centre, Foothills Medical Centre, Calgary, Alberta.
	/// DG Gobbi and YP Starreveld,
	/// "Uniform B-Splines for the VTK Imaging Pipeline,"
	/// VTK Journal, 2011,
	/// http://hdl.handle.net/10380/3252
	/// </remarks>
	// Token: 0x0200084E RID: 2126
	public class vtkImageBSplineCoefficients : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060160D5 RID: 90325 RVA: 0x001F0EFF File Offset: 0x001EF0FF
		static vtkImageBSplineCoefficients()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageBSplineCoefficients.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageBSplineCoefficients"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060160D6 RID: 90326 RVA: 0x001F0F27 File Offset: 0x001EF127
		public vtkImageBSplineCoefficients(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060160D7 RID: 90327
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBSplineCoefficients_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060160D8 RID: 90328 RVA: 0x001F0F38 File Offset: 0x001EF138
		public new static vtkImageBSplineCoefficients New()
		{
			vtkImageBSplineCoefficients result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageBSplineCoefficients)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060160D9 RID: 90329 RVA: 0x001F0F8C File Offset: 0x001EF18C
		public vtkImageBSplineCoefficients() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060160DA RID: 90330 RVA: 0x001F0FD0 File Offset: 0x001EF1D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060160DB RID: 90331
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineCoefficients_BypassOff_01(HandleRef pThis);

		/// <summary>
		/// Bypass the filter, do not do any processing.  If this is on,
		/// then the output data will reference the input data directly,
		/// and the output type will be the same as the input type.  This
		/// is useful a downstream filter sometimes uses b-spline interpolation
		/// and sometimes uses other forms of interpolation.
		/// </summary>
		// Token: 0x060160DC RID: 90332 RVA: 0x001F0FDB File Offset: 0x001EF1DB
		public virtual void BypassOff()
		{
			vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_BypassOff_01(base.GetCppThis());
		}

		// Token: 0x060160DD RID: 90333
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineCoefficients_BypassOn_02(HandleRef pThis);

		/// <summary>
		/// Bypass the filter, do not do any processing.  If this is on,
		/// then the output data will reference the input data directly,
		/// and the output type will be the same as the input type.  This
		/// is useful a downstream filter sometimes uses b-spline interpolation
		/// and sometimes uses other forms of interpolation.
		/// </summary>
		// Token: 0x060160DE RID: 90334 RVA: 0x001F0FEA File Offset: 0x001EF1EA
		public virtual void BypassOn()
		{
			vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_BypassOn_02(base.GetCppThis());
		}

		// Token: 0x060160DF RID: 90335
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineCoefficients_CheckBounds_03(HandleRef pThis, IntPtr point);

		/// <summary>
		/// Check a point against the image bounds.  Return 0 if out of bounds,
		/// and 1 if inside bounds.  Calling Evaluate on a point outside the
		/// bounds will not generate an error, but the value returned will
		/// depend on the BorderMode.
		/// </summary>
		// Token: 0x060160E0 RID: 90336 RVA: 0x001F0FFC File Offset: 0x001EF1FC
		public int CheckBounds(IntPtr point)
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_CheckBounds_03(base.GetCppThis(), point);
		}

		// Token: 0x060160E1 RID: 90337
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineCoefficients_Evaluate_04(HandleRef pThis, IntPtr point, IntPtr value);

		/// <summary>
		/// Interpolate a value from the image.  You must call Update() before
		/// calling this method for the first time.  The first signature can
		/// return multiple components, while the second signature is for use
		/// on single-component images.
		/// </summary>
		// Token: 0x060160E2 RID: 90338 RVA: 0x001F101C File Offset: 0x001EF21C
		public void Evaluate(IntPtr point, IntPtr value)
		{
			vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_Evaluate_04(base.GetCppThis(), point, value);
		}

		// Token: 0x060160E3 RID: 90339
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageBSplineCoefficients_Evaluate_05(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Interpolate a value from the image.  You must call Update() before
		/// calling this method for the first time.  The first signature can
		/// return multiple components, while the second signature is for use
		/// on single-component images.
		/// </summary>
		// Token: 0x060160E4 RID: 90340 RVA: 0x001F1030 File Offset: 0x001EF230
		public double Evaluate(double x, double y, double z)
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_Evaluate_05(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060160E5 RID: 90341
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageBSplineCoefficients_Evaluate_06(HandleRef pThis, IntPtr point);

		/// <summary>
		/// Interpolate a value from the image.  You must call Update() before
		/// calling this method for the first time.  The first signature can
		/// return multiple components, while the second signature is for use
		/// on single-component images.
		/// </summary>
		// Token: 0x060160E6 RID: 90342 RVA: 0x001F1054 File Offset: 0x001EF254
		public double Evaluate(IntPtr point)
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_Evaluate_06(base.GetCppThis(), point);
		}

		// Token: 0x060160E7 RID: 90343
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageBorderMode vtkImageBSplineCoefficients_GetBorderMode_07(HandleRef pThis);

		/// <summary>
		/// Set the border mode.  The filter that is used to create the
		/// coefficients must repeat the image somehow to make a theoretically
		/// infinite input.  The default is to clamp values that are off the
		/// edge of the image, to the value at the closest point on the edge.
		/// The other ways of virtually extending the image are to produce
		/// mirrored copies, which results in optimal smoothness at the boundary,
		/// or to repeat the image, which results in a cyclic or periodic spline.
		/// </summary>
		// Token: 0x060160E8 RID: 90344 RVA: 0x001F1074 File Offset: 0x001EF274
		public virtual vtkImageBorderMode GetBorderMode()
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetBorderMode_07(base.GetCppThis());
		}

		// Token: 0x060160E9 RID: 90345
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBSplineCoefficients_GetBorderModeAsString_08(HandleRef pThis);

		/// <summary>
		/// Set the border mode.  The filter that is used to create the
		/// coefficients must repeat the image somehow to make a theoretically
		/// infinite input.  The default is to clamp values that are off the
		/// edge of the image, to the value at the closest point on the edge.
		/// The other ways of virtually extending the image are to produce
		/// mirrored copies, which results in optimal smoothness at the boundary,
		/// or to repeat the image, which results in a cyclic or periodic spline.
		/// </summary>
		// Token: 0x060160EA RID: 90346 RVA: 0x001F1094 File Offset: 0x001EF294
		public string GetBorderModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetBorderModeAsString_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060160EB RID: 90347
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageBorderMode vtkImageBSplineCoefficients_GetBorderModeMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set the border mode.  The filter that is used to create the
		/// coefficients must repeat the image somehow to make a theoretically
		/// infinite input.  The default is to clamp values that are off the
		/// edge of the image, to the value at the closest point on the edge.
		/// The other ways of virtually extending the image are to produce
		/// mirrored copies, which results in optimal smoothness at the boundary,
		/// or to repeat the image, which results in a cyclic or periodic spline.
		/// </summary>
		// Token: 0x060160EC RID: 90348 RVA: 0x001F10D0 File Offset: 0x001EF2D0
		public virtual vtkImageBorderMode GetBorderModeMaxValue()
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetBorderModeMaxValue_09(base.GetCppThis());
		}

		// Token: 0x060160ED RID: 90349
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageBorderMode vtkImageBSplineCoefficients_GetBorderModeMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set the border mode.  The filter that is used to create the
		/// coefficients must repeat the image somehow to make a theoretically
		/// infinite input.  The default is to clamp values that are off the
		/// edge of the image, to the value at the closest point on the edge.
		/// The other ways of virtually extending the image are to produce
		/// mirrored copies, which results in optimal smoothness at the boundary,
		/// or to repeat the image, which results in a cyclic or periodic spline.
		/// </summary>
		// Token: 0x060160EE RID: 90350 RVA: 0x001F10F0 File Offset: 0x001EF2F0
		public virtual vtkImageBorderMode GetBorderModeMinValue()
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetBorderModeMinValue_10(base.GetCppThis());
		}

		// Token: 0x060160EF RID: 90351
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineCoefficients_GetBypass_11(HandleRef pThis);

		/// <summary>
		/// Bypass the filter, do not do any processing.  If this is on,
		/// then the output data will reference the input data directly,
		/// and the output type will be the same as the input type.  This
		/// is useful a downstream filter sometimes uses b-spline interpolation
		/// and sometimes uses other forms of interpolation.
		/// </summary>
		// Token: 0x060160F0 RID: 90352 RVA: 0x001F1110 File Offset: 0x001EF310
		public virtual int GetBypass()
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetBypass_11(base.GetCppThis());
		}

		// Token: 0x060160F1 RID: 90353
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageBSplineCoefficients_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060160F2 RID: 90354 RVA: 0x001F1130 File Offset: 0x001EF330
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x060160F3 RID: 90355
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageBSplineCoefficients_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060160F4 RID: 90356 RVA: 0x001F1150 File Offset: 0x001EF350
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x060160F5 RID: 90357
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineCoefficients_GetOutputScalarType_14(HandleRef pThis);

		/// <summary>
		/// Set the scalar type of the output.  Default is float.
		/// Floating-point output is used to avoid overflow, since the
		/// range of the output values is larger than the input values.
		/// </summary>
		// Token: 0x060160F6 RID: 90358 RVA: 0x001F116C File Offset: 0x001EF36C
		public virtual int GetOutputScalarType()
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetOutputScalarType_14(base.GetCppThis());
		}

		// Token: 0x060160F7 RID: 90359
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBSplineCoefficients_GetOutputScalarTypeAsString_15(HandleRef pThis);

		/// <summary>
		/// Set the scalar type of the output.  Default is float.
		/// Floating-point output is used to avoid overflow, since the
		/// range of the output values is larger than the input values.
		/// </summary>
		// Token: 0x060160F8 RID: 90360 RVA: 0x001F118C File Offset: 0x001EF38C
		public string GetOutputScalarTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetOutputScalarTypeAsString_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060160F9 RID: 90361
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineCoefficients_GetOutputScalarTypeMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set the scalar type of the output.  Default is float.
		/// Floating-point output is used to avoid overflow, since the
		/// range of the output values is larger than the input values.
		/// </summary>
		// Token: 0x060160FA RID: 90362 RVA: 0x001F11C8 File Offset: 0x001EF3C8
		public virtual int GetOutputScalarTypeMaxValue()
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetOutputScalarTypeMaxValue_16(base.GetCppThis());
		}

		// Token: 0x060160FB RID: 90363
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineCoefficients_GetOutputScalarTypeMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set the scalar type of the output.  Default is float.
		/// Floating-point output is used to avoid overflow, since the
		/// range of the output values is larger than the input values.
		/// </summary>
		// Token: 0x060160FC RID: 90364 RVA: 0x001F11E8 File Offset: 0x001EF3E8
		public virtual int GetOutputScalarTypeMinValue()
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetOutputScalarTypeMinValue_17(base.GetCppThis());
		}

		// Token: 0x060160FD RID: 90365
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineCoefficients_GetSplineDegree_18(HandleRef pThis);

		/// <summary>
		/// Set the degree of the spline polynomial.  The default value is 3,
		/// and the maximum is 9.
		/// </summary>
		// Token: 0x060160FE RID: 90366 RVA: 0x001F1208 File Offset: 0x001EF408
		public virtual int GetSplineDegree()
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetSplineDegree_18(base.GetCppThis());
		}

		// Token: 0x060160FF RID: 90367
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineCoefficients_GetSplineDegreeMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set the degree of the spline polynomial.  The default value is 3,
		/// and the maximum is 9.
		/// </summary>
		// Token: 0x06016100 RID: 90368 RVA: 0x001F1228 File Offset: 0x001EF428
		public virtual int GetSplineDegreeMaxValue()
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetSplineDegreeMaxValue_19(base.GetCppThis());
		}

		// Token: 0x06016101 RID: 90369
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineCoefficients_GetSplineDegreeMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set the degree of the spline polynomial.  The default value is 3,
		/// and the maximum is 9.
		/// </summary>
		// Token: 0x06016102 RID: 90370 RVA: 0x001F1248 File Offset: 0x001EF448
		public virtual int GetSplineDegreeMinValue()
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_GetSplineDegreeMinValue_20(base.GetCppThis());
		}

		// Token: 0x06016103 RID: 90371
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineCoefficients_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016104 RID: 90372 RVA: 0x001F1268 File Offset: 0x001EF468
		public override int IsA(string type)
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x06016105 RID: 90373
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineCoefficients_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016106 RID: 90374 RVA: 0x001F1288 File Offset: 0x001EF488
		public new static int IsTypeOf(string type)
		{
			return vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_IsTypeOf_22(type);
		}

		// Token: 0x06016107 RID: 90375
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBSplineCoefficients_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016108 RID: 90376 RVA: 0x001F12A4 File Offset: 0x001EF4A4
		public new vtkImageBSplineCoefficients NewInstance()
		{
			vtkImageBSplineCoefficients result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageBSplineCoefficients)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016109 RID: 90377
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBSplineCoefficients_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601610A RID: 90378 RVA: 0x001F1300 File Offset: 0x001EF500
		public new static vtkImageBSplineCoefficients SafeDownCast(vtkObjectBase o)
		{
			vtkImageBSplineCoefficients vtkImageBSplineCoefficients = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageBSplineCoefficients = (vtkImageBSplineCoefficients)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageBSplineCoefficients.Register(null);
				}
			}
			return vtkImageBSplineCoefficients;
		}

		// Token: 0x0601610B RID: 90379
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineCoefficients_SetBorderMode_26(HandleRef pThis, vtkImageBorderMode _arg);

		/// <summary>
		/// Set the border mode.  The filter that is used to create the
		/// coefficients must repeat the image somehow to make a theoretically
		/// infinite input.  The default is to clamp values that are off the
		/// edge of the image, to the value at the closest point on the edge.
		/// The other ways of virtually extending the image are to produce
		/// mirrored copies, which results in optimal smoothness at the boundary,
		/// or to repeat the image, which results in a cyclic or periodic spline.
		/// </summary>
		// Token: 0x0601610C RID: 90380 RVA: 0x001F137F File Offset: 0x001EF57F
		public virtual void SetBorderMode(vtkImageBorderMode _arg)
		{
			vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_SetBorderMode_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0601610D RID: 90381
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineCoefficients_SetBorderModeToClamp_27(HandleRef pThis);

		/// <summary>
		/// Set the border mode.  The filter that is used to create the
		/// coefficients must repeat the image somehow to make a theoretically
		/// infinite input.  The default is to clamp values that are off the
		/// edge of the image, to the value at the closest point on the edge.
		/// The other ways of virtually extending the image are to produce
		/// mirrored copies, which results in optimal smoothness at the boundary,
		/// or to repeat the image, which results in a cyclic or periodic spline.
		/// </summary>
		// Token: 0x0601610E RID: 90382 RVA: 0x001F138F File Offset: 0x001EF58F
		public void SetBorderModeToClamp()
		{
			vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_SetBorderModeToClamp_27(base.GetCppThis());
		}

		// Token: 0x0601610F RID: 90383
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineCoefficients_SetBorderModeToMirror_28(HandleRef pThis);

		/// <summary>
		/// Set the border mode.  The filter that is used to create the
		/// coefficients must repeat the image somehow to make a theoretically
		/// infinite input.  The default is to clamp values that are off the
		/// edge of the image, to the value at the closest point on the edge.
		/// The other ways of virtually extending the image are to produce
		/// mirrored copies, which results in optimal smoothness at the boundary,
		/// or to repeat the image, which results in a cyclic or periodic spline.
		/// </summary>
		// Token: 0x06016110 RID: 90384 RVA: 0x001F139E File Offset: 0x001EF59E
		public void SetBorderModeToMirror()
		{
			vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_SetBorderModeToMirror_28(base.GetCppThis());
		}

		// Token: 0x06016111 RID: 90385
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineCoefficients_SetBorderModeToRepeat_29(HandleRef pThis);

		/// <summary>
		/// Set the border mode.  The filter that is used to create the
		/// coefficients must repeat the image somehow to make a theoretically
		/// infinite input.  The default is to clamp values that are off the
		/// edge of the image, to the value at the closest point on the edge.
		/// The other ways of virtually extending the image are to produce
		/// mirrored copies, which results in optimal smoothness at the boundary,
		/// or to repeat the image, which results in a cyclic or periodic spline.
		/// </summary>
		// Token: 0x06016112 RID: 90386 RVA: 0x001F13AD File Offset: 0x001EF5AD
		public void SetBorderModeToRepeat()
		{
			vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_SetBorderModeToRepeat_29(base.GetCppThis());
		}

		// Token: 0x06016113 RID: 90387
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineCoefficients_SetBypass_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Bypass the filter, do not do any processing.  If this is on,
		/// then the output data will reference the input data directly,
		/// and the output type will be the same as the input type.  This
		/// is useful a downstream filter sometimes uses b-spline interpolation
		/// and sometimes uses other forms of interpolation.
		/// </summary>
		// Token: 0x06016114 RID: 90388 RVA: 0x001F13BC File Offset: 0x001EF5BC
		public virtual void SetBypass(int _arg)
		{
			vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_SetBypass_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06016115 RID: 90389
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineCoefficients_SetOutputScalarType_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the scalar type of the output.  Default is float.
		/// Floating-point output is used to avoid overflow, since the
		/// range of the output values is larger than the input values.
		/// </summary>
		// Token: 0x06016116 RID: 90390 RVA: 0x001F13CC File Offset: 0x001EF5CC
		public virtual void SetOutputScalarType(int _arg)
		{
			vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_SetOutputScalarType_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06016117 RID: 90391
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineCoefficients_SetOutputScalarTypeToDouble_32(HandleRef pThis);

		/// <summary>
		/// Set the scalar type of the output.  Default is float.
		/// Floating-point output is used to avoid overflow, since the
		/// range of the output values is larger than the input values.
		/// </summary>
		// Token: 0x06016118 RID: 90392 RVA: 0x001F13DC File Offset: 0x001EF5DC
		public void SetOutputScalarTypeToDouble()
		{
			vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_SetOutputScalarTypeToDouble_32(base.GetCppThis());
		}

		// Token: 0x06016119 RID: 90393
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineCoefficients_SetOutputScalarTypeToFloat_33(HandleRef pThis);

		/// <summary>
		/// Set the scalar type of the output.  Default is float.
		/// Floating-point output is used to avoid overflow, since the
		/// range of the output values is larger than the input values.
		/// </summary>
		// Token: 0x0601611A RID: 90394 RVA: 0x001F13EB File Offset: 0x001EF5EB
		public void SetOutputScalarTypeToFloat()
		{
			vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_SetOutputScalarTypeToFloat_33(base.GetCppThis());
		}

		// Token: 0x0601611B RID: 90395
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineCoefficients_SetSplineDegree_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the degree of the spline polynomial.  The default value is 3,
		/// and the maximum is 9.
		/// </summary>
		// Token: 0x0601611C RID: 90396 RVA: 0x001F13FA File Offset: 0x001EF5FA
		public virtual void SetSplineDegree(int _arg)
		{
			vtkImageBSplineCoefficients.vtkImageBSplineCoefficients_SetSplineDegree_34(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018F0 RID: 6384
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageBSplineCoefficients";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018F1 RID: 6385
		public new static readonly string MRClassNameKey = "class vtkImageBSplineCoefficients";
	}
}
