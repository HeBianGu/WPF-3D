using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageBSplineInterpolator
	/// </summary>
	/// <remarks>
	///    perform b-spline interpolation on images
	///
	/// vtkImageBSplineInterpolator can be used to perform b-spline interpolation
	/// on images that have been filtered with vtkImageBSplineCoefficients.  The
	/// b-spline interpolants provide the maximum possible degree of continuity
	/// for a given kernel size, but require that the image data be pre-filtered
	/// to generate b-spline coefficients before the interpolation is performed.
	/// Interpolating data that has not been pre-filtered will give incorrect
	/// results.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageReslice vtkImageBSplineCoefficients vtkBSplineTransform
	/// @par Thanks:
	/// This class was written by David Gobbi at the Seaman Family MR Research
	/// Centre, Foothills Medical Centre, Calgary, Alberta.
	/// DG Gobbi and YP Starreveld,
	/// "Uniform B-Splines for the VTK Imaging Pipeline,"
	/// VTK Journal, 2011,
	/// http://hdl.handle.net/10380/3252
	/// </seealso>
	// Token: 0x02000850 RID: 2128
	public class vtkImageBSplineInterpolator : vtkAbstractImageInterpolator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016128 RID: 90408 RVA: 0x001F14BF File Offset: 0x001EF6BF
		static vtkImageBSplineInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageBSplineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageBSplineInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016129 RID: 90409 RVA: 0x001F14E7 File Offset: 0x001EF6E7
		public vtkImageBSplineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601612A RID: 90410
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBSplineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601612B RID: 90411 RVA: 0x001F14F8 File Offset: 0x001EF6F8
		public new static vtkImageBSplineInterpolator New()
		{
			vtkImageBSplineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageBSplineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601612C RID: 90412 RVA: 0x001F154C File Offset: 0x001EF74C
		public vtkImageBSplineInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601612D RID: 90413 RVA: 0x001F1590 File Offset: 0x001EF790
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601612E RID: 90414
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineInterpolator_ComputeSupportSize_01(HandleRef pThis, IntPtr matrix, IntPtr size);

		/// <summary>
		/// Get the support size for use in computing update extents.  If the data
		/// will be sampled on a regular grid, then pass a matrix describing the
		/// structured coordinate transformation between the output and the input.
		/// Otherwise, pass nullptr as the matrix to retrieve the full kernel size.
		/// </summary>
		// Token: 0x0601612F RID: 90415 RVA: 0x001F159B File Offset: 0x001EF79B
		public override void ComputeSupportSize(IntPtr matrix, IntPtr size)
		{
			vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_ComputeSupportSize_01(base.GetCppThis(), matrix, size);
		}

		// Token: 0x06016130 RID: 90416
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageBSplineInterpolator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016131 RID: 90417 RVA: 0x001F15AC File Offset: 0x001EF7AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06016132 RID: 90418
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageBSplineInterpolator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016133 RID: 90419 RVA: 0x001F15CC File Offset: 0x001EF7CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06016134 RID: 90420
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineInterpolator_GetSplineDegree_04(HandleRef pThis);

		/// <summary>
		/// Set the degree of the spline polynomial.  The default value is 3,
		/// and the maximum is 9.  The data must be pre-filtered for the same
		/// degree of polynomial with vtkImageBSplineCoefficients.
		/// </summary>
		// Token: 0x06016135 RID: 90421 RVA: 0x001F15E8 File Offset: 0x001EF7E8
		public int GetSplineDegree()
		{
			return vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_GetSplineDegree_04(base.GetCppThis());
		}

		// Token: 0x06016136 RID: 90422
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineInterpolator_GetSplineDegreeMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set the degree of the spline polynomial.  The default value is 3,
		/// and the maximum is 9.  The data must be pre-filtered for the same
		/// degree of polynomial with vtkImageBSplineCoefficients.
		/// </summary>
		// Token: 0x06016137 RID: 90423 RVA: 0x001F1608 File Offset: 0x001EF808
		public int GetSplineDegreeMaxValue()
		{
			return vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_GetSplineDegreeMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06016138 RID: 90424
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineInterpolator_GetSplineDegreeMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set the degree of the spline polynomial.  The default value is 3,
		/// and the maximum is 9.  The data must be pre-filtered for the same
		/// degree of polynomial with vtkImageBSplineCoefficients.
		/// </summary>
		// Token: 0x06016139 RID: 90425 RVA: 0x001F1628 File Offset: 0x001EF828
		public int GetSplineDegreeMinValue()
		{
			return vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_GetSplineDegreeMinValue_06(base.GetCppThis());
		}

		// Token: 0x0601613A RID: 90426
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineInterpolator_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601613B RID: 90427 RVA: 0x001F1648 File Offset: 0x001EF848
		public override int IsA(string type)
		{
			return vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601613C RID: 90428
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageBSplineInterpolator_IsSeparable_08(HandleRef pThis);

		/// <summary>
		/// Returns true if the interpolator supports weight precomputation.
		/// This will always return true for this interpolator.
		/// </summary>
		// Token: 0x0601613D RID: 90429 RVA: 0x001F1668 File Offset: 0x001EF868
		public override bool IsSeparable()
		{
			return vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_IsSeparable_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0601613E RID: 90430
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineInterpolator_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601613F RID: 90431 RVA: 0x001F1690 File Offset: 0x001EF890
		public new static int IsTypeOf(string type)
		{
			return vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_IsTypeOf_09(type);
		}

		// Token: 0x06016140 RID: 90432
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBSplineInterpolator_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016141 RID: 90433 RVA: 0x001F16AC File Offset: 0x001EF8AC
		public new vtkImageBSplineInterpolator NewInstance()
		{
			vtkImageBSplineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageBSplineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016142 RID: 90434
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBSplineInterpolator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016143 RID: 90435 RVA: 0x001F1708 File Offset: 0x001EF908
		public new static vtkImageBSplineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkImageBSplineInterpolator vtkImageBSplineInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageBSplineInterpolator = (vtkImageBSplineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageBSplineInterpolator.Register(null);
				}
			}
			return vtkImageBSplineInterpolator;
		}

		// Token: 0x06016144 RID: 90436
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineInterpolator_SetSplineDegree_13(HandleRef pThis, int degree);

		/// <summary>
		/// Set the degree of the spline polynomial.  The default value is 3,
		/// and the maximum is 9.  The data must be pre-filtered for the same
		/// degree of polynomial with vtkImageBSplineCoefficients.
		/// </summary>
		// Token: 0x06016145 RID: 90437 RVA: 0x001F1787 File Offset: 0x001EF987
		public void SetSplineDegree(int degree)
		{
			vtkImageBSplineInterpolator.vtkImageBSplineInterpolator_SetSplineDegree_13(base.GetCppThis(), degree);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018F4 RID: 6388
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageBSplineInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018F5 RID: 6389
		public new static readonly string MRClassNameKey = "class vtkImageBSplineInterpolator";
	}
}
