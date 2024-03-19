using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkColorTransferFunction
	/// </summary>
	/// <remarks>
	///    Defines a transfer function for mapping a
	/// property to an RGB color value.
	///
	///
	/// vtkColorTransferFunction is a color mapping in RGB or HSV space that
	/// uses piecewise hermite functions to allow interpolation that can be
	/// piecewise constant, piecewise linear, or somewhere in-between
	/// (a modified piecewise hermite function that squishes the function
	/// according to a sharpness parameter). The function also allows for
	/// the specification of the midpoint (the place where the function
	/// reaches the average of the two bounding nodes) as a normalize distance
	/// between nodes.
	/// See the description of class vtkPiecewiseFunction for an explanation of
	/// midpoint and sharpness.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPiecewiseFunction
	/// </seealso>
	// Token: 0x020007D2 RID: 2002
	public class vtkColorTransferFunction : vtkScalarsToColors
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014755 RID: 83797 RVA: 0x001CFA23 File Offset: 0x001CDC23
		static vtkColorTransferFunction()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColorTransferFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorTransferFunction"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014756 RID: 83798 RVA: 0x001CFA4B File Offset: 0x001CDC4B
		public vtkColorTransferFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014757 RID: 83799
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014758 RID: 83800 RVA: 0x001CFA5C File Offset: 0x001CDC5C
		public new static vtkColorTransferFunction New()
		{
			vtkColorTransferFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014759 RID: 83801 RVA: 0x001CFAB0 File Offset: 0x001CDCB0
		public vtkColorTransferFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkColorTransferFunction.vtkColorTransferFunction_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601475A RID: 83802 RVA: 0x001CFAF4 File Offset: 0x001CDCF4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601475B RID: 83803
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_AddHSVPoint_01(HandleRef pThis, double x, double h, double s, double v);

		/// <summary>
		/// Add/Remove a point to/from the function defined in RGB or HSV
		/// Return the index of the point (0 based), or -1 on error.
		/// See the description of class vtkPiecewiseFunction for an explanation of
		/// midpoint and sharpness.
		/// </summary>
		// Token: 0x0601475C RID: 83804 RVA: 0x001CFB00 File Offset: 0x001CDD00
		public int AddHSVPoint(double x, double h, double s, double v)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_AddHSVPoint_01(base.GetCppThis(), x, h, s, v);
		}

		// Token: 0x0601475D RID: 83805
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_AddHSVPoint_02(HandleRef pThis, double x, double h, double s, double v, double midpoint, double sharpness);

		/// <summary>
		/// Add/Remove a point to/from the function defined in RGB or HSV
		/// Return the index of the point (0 based), or -1 on error.
		/// See the description of class vtkPiecewiseFunction for an explanation of
		/// midpoint and sharpness.
		/// </summary>
		// Token: 0x0601475E RID: 83806 RVA: 0x001CFB24 File Offset: 0x001CDD24
		public int AddHSVPoint(double x, double h, double s, double v, double midpoint, double sharpness)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_AddHSVPoint_02(base.GetCppThis(), x, h, s, v, midpoint, sharpness);
		}

		// Token: 0x0601475F RID: 83807
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_AddHSVSegment_03(HandleRef pThis, double x1, double h1, double s1, double v1, double x2, double h2, double s2, double v2);

		/// <summary>
		/// Add two points to the function and remove all the points
		/// between them
		/// </summary>
		// Token: 0x06014760 RID: 83808 RVA: 0x001CFB4C File Offset: 0x001CDD4C
		public void AddHSVSegment(double x1, double h1, double s1, double v1, double x2, double h2, double s2, double v2)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_AddHSVSegment_03(base.GetCppThis(), x1, h1, s1, v1, x2, h2, s2, v2);
		}

		// Token: 0x06014761 RID: 83809
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_AddRGBPoint_04(HandleRef pThis, double x, double r, double g, double b);

		/// <summary>
		/// Add/Remove a point to/from the function defined in RGB or HSV
		/// Return the index of the point (0 based), or -1 on error.
		/// See the description of class vtkPiecewiseFunction for an explanation of
		/// midpoint and sharpness.
		/// </summary>
		// Token: 0x06014762 RID: 83810 RVA: 0x001CFB74 File Offset: 0x001CDD74
		public int AddRGBPoint(double x, double r, double g, double b)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_AddRGBPoint_04(base.GetCppThis(), x, r, g, b);
		}

		// Token: 0x06014763 RID: 83811
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_AddRGBPoint_05(HandleRef pThis, double x, double r, double g, double b, double midpoint, double sharpness);

		/// <summary>
		/// Add/Remove a point to/from the function defined in RGB or HSV
		/// Return the index of the point (0 based), or -1 on error.
		/// See the description of class vtkPiecewiseFunction for an explanation of
		/// midpoint and sharpness.
		/// </summary>
		// Token: 0x06014764 RID: 83812 RVA: 0x001CFB98 File Offset: 0x001CDD98
		public int AddRGBPoint(double x, double r, double g, double b, double midpoint, double sharpness)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_AddRGBPoint_05(base.GetCppThis(), x, r, g, b, midpoint, sharpness);
		}

		// Token: 0x06014765 RID: 83813
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_AddRGBPoints_06(HandleRef pThis, HandleRef x, HandleRef rgbColors);

		/// <summary>
		/// Add/Remove a point to/from the function defined in RGB or HSV
		/// Return the index of the point (0 based), or -1 on error.
		/// See the description of class vtkPiecewiseFunction for an explanation of
		/// midpoint and sharpness.
		/// </summary>
		// Token: 0x06014766 RID: 83814 RVA: 0x001CFBC0 File Offset: 0x001CDDC0
		public int AddRGBPoints(vtkDoubleArray x, vtkDoubleArray rgbColors)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_AddRGBPoints_06(base.GetCppThis(), (x == null) ? default(HandleRef) : x.GetCppThis(), (rgbColors == null) ? default(HandleRef) : rgbColors.GetCppThis());
		}

		// Token: 0x06014767 RID: 83815
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_AddRGBPoints_07(HandleRef pThis, HandleRef x, HandleRef rgbColors, double midpoint, double sharpness);

		/// <summary>
		/// Add/Remove a point to/from the function defined in RGB or HSV
		/// Return the index of the point (0 based), or -1 on error.
		/// See the description of class vtkPiecewiseFunction for an explanation of
		/// midpoint and sharpness.
		/// </summary>
		// Token: 0x06014768 RID: 83816 RVA: 0x001CFC0C File Offset: 0x001CDE0C
		public int AddRGBPoints(vtkDoubleArray x, vtkDoubleArray rgbColors, double midpoint, double sharpness)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_AddRGBPoints_07(base.GetCppThis(), (x == null) ? default(HandleRef) : x.GetCppThis(), (rgbColors == null) ? default(HandleRef) : rgbColors.GetCppThis(), midpoint, sharpness);
		}

		// Token: 0x06014769 RID: 83817
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_AddRGBSegment_08(HandleRef pThis, double x1, double r1, double g1, double b1, double x2, double r2, double g2, double b2);

		/// <summary>
		/// Add two points to the function and remove all the points
		/// between them
		/// </summary>
		// Token: 0x0601476A RID: 83818 RVA: 0x001CFC58 File Offset: 0x001CDE58
		public void AddRGBSegment(double x1, double r1, double g1, double b1, double x2, double r2, double g2, double b2)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_AddRGBSegment_08(base.GetCppThis(), x1, r1, g1, b1, x2, r2, g2, b2);
		}

		// Token: 0x0601476B RID: 83819
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_AdjustRange_09(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Remove all points out of the new range, and make sure there is a point
		/// at each end of that range.
		/// Returns 1 on success, 0 otherwise.
		/// </summary>
		// Token: 0x0601476C RID: 83820 RVA: 0x001CFC80 File Offset: 0x001CDE80
		public int AdjustRange(IntPtr range)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_AdjustRange_09(base.GetCppThis(), range);
		}

		// Token: 0x0601476D RID: 83821
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_AllowDuplicateScalarsOff_10(HandleRef pThis);

		/// <summary>
		/// Toggle whether to allow duplicate scalar values in the color transfer
		/// function (off by default).
		/// </summary>
		// Token: 0x0601476E RID: 83822 RVA: 0x001CFCA0 File Offset: 0x001CDEA0
		public virtual void AllowDuplicateScalarsOff()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_AllowDuplicateScalarsOff_10(base.GetCppThis());
		}

		// Token: 0x0601476F RID: 83823
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_AllowDuplicateScalarsOn_11(HandleRef pThis);

		/// <summary>
		/// Toggle whether to allow duplicate scalar values in the color transfer
		/// function (off by default).
		/// </summary>
		// Token: 0x06014770 RID: 83824 RVA: 0x001CFCAF File Offset: 0x001CDEAF
		public virtual void AllowDuplicateScalarsOn()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_AllowDuplicateScalarsOn_11(base.GetCppThis());
		}

		// Token: 0x06014771 RID: 83825
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_BuildFunctionFromTable_12(HandleRef pThis, double x1, double x2, int size, IntPtr table);

		/// <summary>
		/// Construct a color transfer function from a table. Unlike
		/// FillFromDataPointer(), the \p table parameter's layout is assumed
		/// to be [R1, G1, B1, R2, G2, B2, ..., Rn, Gn, Bn], and it is
		/// assumed to be a block of memory of size [3*size]. After calling
		/// this method, the function range will be [x1, x2], the function
		/// will have \p size nodes, and function values will be regularly spaced
		/// between x1 and x2.
		/// </summary>
		// Token: 0x06014772 RID: 83826 RVA: 0x001CFCBE File Offset: 0x001CDEBE
		public void BuildFunctionFromTable(double x1, double x2, int size, IntPtr table)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_BuildFunctionFromTable_12(base.GetCppThis(), x1, x2, size, table);
		}

		// Token: 0x06014773 RID: 83827
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_ClampingOff_13(HandleRef pThis);

		/// <summary>
		/// Sets/gets whether clamping is used. If on, scalar values below
		/// the lower range value set for the transfer function will be
		/// mapped to the first node color, and scalar values above the upper
		/// range value set for the transfer function will be mapped to the
		/// last node color. If off, values outside the range are mapped to
		/// black.
		/// </summary>
		// Token: 0x06014774 RID: 83828 RVA: 0x001CFCD2 File Offset: 0x001CDED2
		public virtual void ClampingOff()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_ClampingOff_13(base.GetCppThis());
		}

		// Token: 0x06014775 RID: 83829
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_ClampingOn_14(HandleRef pThis);

		/// <summary>
		/// Sets/gets whether clamping is used. If on, scalar values below
		/// the lower range value set for the transfer function will be
		/// mapped to the first node color, and scalar values above the upper
		/// range value set for the transfer function will be mapped to the
		/// last node color. If off, values outside the range are mapped to
		/// black.
		/// </summary>
		// Token: 0x06014776 RID: 83830 RVA: 0x001CFCE1 File Offset: 0x001CDEE1
		public virtual void ClampingOn()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_ClampingOn_14(base.GetCppThis());
		}

		// Token: 0x06014777 RID: 83831
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_DeepCopy_15(HandleRef pThis, HandleRef f);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014778 RID: 83832 RVA: 0x001CFCF0 File Offset: 0x001CDEF0
		public override void DeepCopy(vtkScalarsToColors f)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_DeepCopy_15(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		// Token: 0x06014779 RID: 83833
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_EstimateMinNumberOfSamples_16(HandleRef pThis, ref double x1, ref double x2);

		/// <summary>
		/// Estimates the minimum size of a table such that it would correctly sample this function.
		/// The returned value should be passed as parameter 'n' when calling GetTable().
		/// </summary>
		// Token: 0x0601477A RID: 83834 RVA: 0x001CFD20 File Offset: 0x001CDF20
		public int EstimateMinNumberOfSamples(ref double x1, ref double x2)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_EstimateMinNumberOfSamples_16(base.GetCppThis(), ref x1, ref x2);
		}

		// Token: 0x0601477B RID: 83835
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_FillFromDataPointer_17(HandleRef pThis, int n, IntPtr ptr);

		/// <summary>
		/// Defines the nodes from an array \a ptr with the layout [X1, R1,
		/// G1, B1, X2, R2, G2, B2, ..., Xn, Rn, Gn, Bn] where n is the
		/// number of nodes.
		/// </summary>
		// Token: 0x0601477C RID: 83836 RVA: 0x001CFD41 File Offset: 0x001CDF41
		public void FillFromDataPointer(int n, IntPtr ptr)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_FillFromDataPointer_17(base.GetCppThis(), n, ptr);
		}

		// Token: 0x0601477D RID: 83837
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunction_GetAboveRangeColor_18(HandleRef pThis);

		/// <summary>
		/// Set the color to use when a value above the range is
		/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x0601477E RID: 83838 RVA: 0x001CFD54 File Offset: 0x001CDF54
		public virtual double[] GetAboveRangeColor()
		{
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_GetAboveRangeColor_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601477F RID: 83839
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_GetAboveRangeColor_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the color to use when a value above the range is
		/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06014780 RID: 83840 RVA: 0x001CFD9C File Offset: 0x001CDF9C
		public virtual void GetAboveRangeColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetAboveRangeColor_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06014781 RID: 83841
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_GetAboveRangeColor_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color to use when a value above the range is
		/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06014782 RID: 83842 RVA: 0x001CFDAE File Offset: 0x001CDFAE
		public virtual void GetAboveRangeColor(IntPtr _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetAboveRangeColor_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06014783 RID: 83843
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetAllowDuplicateScalars_21(HandleRef pThis);

		/// <summary>
		/// Toggle whether to allow duplicate scalar values in the color transfer
		/// function (off by default).
		/// </summary>
		// Token: 0x06014784 RID: 83844 RVA: 0x001CFDC0 File Offset: 0x001CDFC0
		public virtual int GetAllowDuplicateScalars()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetAllowDuplicateScalars_21(base.GetCppThis());
		}

		// Token: 0x06014785 RID: 83845
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunction_GetBelowRangeColor_22(HandleRef pThis);

		/// <summary>
		/// Set the color to use when a value below the range is
		/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06014786 RID: 83846 RVA: 0x001CFDE0 File Offset: 0x001CDFE0
		public virtual double[] GetBelowRangeColor()
		{
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_GetBelowRangeColor_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014787 RID: 83847
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_GetBelowRangeColor_23(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the color to use when a value below the range is
		/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06014788 RID: 83848 RVA: 0x001CFE28 File Offset: 0x001CE028
		public virtual void GetBelowRangeColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetBelowRangeColor_23(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06014789 RID: 83849
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_GetBelowRangeColor_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color to use when a value below the range is
		/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x0601478A RID: 83850 RVA: 0x001CFE3A File Offset: 0x001CE03A
		public virtual void GetBelowRangeColor(IntPtr _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetBelowRangeColor_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0601478B RID: 83851
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkColorTransferFunction_GetBlueValue_25(HandleRef pThis, double x);

		/// <summary>
		/// Get the color components individually.
		/// </summary>
		// Token: 0x0601478C RID: 83852 RVA: 0x001CFE4C File Offset: 0x001CE04C
		public double GetBlueValue(double x)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetBlueValue_25(base.GetCppThis(), x);
		}

		// Token: 0x0601478D RID: 83853
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetClamping_26(HandleRef pThis);

		/// <summary>
		/// Sets/gets whether clamping is used. If on, scalar values below
		/// the lower range value set for the transfer function will be
		/// mapped to the first node color, and scalar values above the upper
		/// range value set for the transfer function will be mapped to the
		/// last node color. If off, values outside the range are mapped to
		/// black.
		/// </summary>
		// Token: 0x0601478E RID: 83854 RVA: 0x001CFE6C File Offset: 0x001CE06C
		public virtual int GetClamping()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetClamping_26(base.GetCppThis());
		}

		// Token: 0x0601478F RID: 83855
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetClampingMaxValue_27(HandleRef pThis);

		/// <summary>
		/// Sets/gets whether clamping is used. If on, scalar values below
		/// the lower range value set for the transfer function will be
		/// mapped to the first node color, and scalar values above the upper
		/// range value set for the transfer function will be mapped to the
		/// last node color. If off, values outside the range are mapped to
		/// black.
		/// </summary>
		// Token: 0x06014790 RID: 83856 RVA: 0x001CFE8C File Offset: 0x001CE08C
		public virtual int GetClampingMaxValue()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetClampingMaxValue_27(base.GetCppThis());
		}

		// Token: 0x06014791 RID: 83857
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetClampingMinValue_28(HandleRef pThis);

		/// <summary>
		/// Sets/gets whether clamping is used. If on, scalar values below
		/// the lower range value set for the transfer function will be
		/// mapped to the first node color, and scalar values above the upper
		/// range value set for the transfer function will be mapped to the
		/// last node color. If off, values outside the range are mapped to
		/// black.
		/// </summary>
		// Token: 0x06014792 RID: 83858 RVA: 0x001CFEAC File Offset: 0x001CE0AC
		public virtual int GetClampingMinValue()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetClampingMinValue_28(base.GetCppThis());
		}

		// Token: 0x06014793 RID: 83859
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunction_GetColor_29(HandleRef pThis, double x);

		/// <summary>
		/// Returns an RGB color for the specified scalar value
		/// </summary>
		// Token: 0x06014794 RID: 83860 RVA: 0x001CFECC File Offset: 0x001CE0CC
		public new double[] GetColor(double x)
		{
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_GetColor_29(base.GetCppThis(), x);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014795 RID: 83861
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_GetColor_30(HandleRef pThis, double x, IntPtr rgb);

		/// <summary>
		/// Returns an RGB color for the specified scalar value
		/// </summary>
		// Token: 0x06014796 RID: 83862 RVA: 0x001CFF15 File Offset: 0x001CE115
		public override void GetColor(double x, IntPtr rgb)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetColor_30(base.GetCppThis(), x, rgb);
		}

		// Token: 0x06014797 RID: 83863
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetColorSpace_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x06014798 RID: 83864 RVA: 0x001CFF28 File Offset: 0x001CE128
		public virtual int GetColorSpace()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetColorSpace_31(base.GetCppThis());
		}

		// Token: 0x06014799 RID: 83865
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetColorSpaceMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x0601479A RID: 83866 RVA: 0x001CFF48 File Offset: 0x001CE148
		public virtual int GetColorSpaceMaxValue()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetColorSpaceMaxValue_32(base.GetCppThis());
		}

		// Token: 0x0601479B RID: 83867
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetColorSpaceMinValue_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x0601479C RID: 83868 RVA: 0x001CFF68 File Offset: 0x001CE168
		public virtual int GetColorSpaceMinValue()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetColorSpaceMinValue_33(base.GetCppThis());
		}

		// Token: 0x0601479D RID: 83869
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunction_GetDataPointer_34(HandleRef pThis);

		/// <summary>
		/// Returns a pointer to an array of all node values in an
		/// interleaved array with the layout [X1, R1, G1, B1, X2, R2, G2,
		/// B2, ..., Xn, Rn, Gn, Bn] where n is the number of nodes defining
		/// the transfer function. The returned pointer points to an array
		/// that is managed by this class, so callers should not free it.
		/// </summary>
		// Token: 0x0601479E RID: 83870 RVA: 0x001CFF88 File Offset: 0x001CE188
		public IntPtr GetDataPointer()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetDataPointer_34(base.GetCppThis());
		}

		// Token: 0x0601479F RID: 83871
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkColorTransferFunction_GetGreenValue_35(HandleRef pThis, double x);

		/// <summary>
		/// Get the color components individually.
		/// </summary>
		// Token: 0x060147A0 RID: 83872 RVA: 0x001CFFA8 File Offset: 0x001CE1A8
		public double GetGreenValue(double x)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetGreenValue_35(base.GetCppThis(), x);
		}

		// Token: 0x060147A1 RID: 83873
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetHSVWrap_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x060147A2 RID: 83874 RVA: 0x001CFFC8 File Offset: 0x001CE1C8
		public virtual int GetHSVWrap()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetHSVWrap_36(base.GetCppThis());
		}

		// Token: 0x060147A3 RID: 83875
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_GetIndexedColor_37(HandleRef pThis, long idx, IntPtr rgba);

		/// <summary>
		/// Return a color given an integer index.
		///
		/// This is used to assign colors to annotations (given an offset into the list of annotations).
		/// If there are no control points or \a idx &lt; 0, then NanColor is returned.
		/// </summary>
		// Token: 0x060147A4 RID: 83876 RVA: 0x001CFFE7 File Offset: 0x001CE1E7
		public override void GetIndexedColor(long idx, IntPtr rgba)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetIndexedColor_37(base.GetCppThis(), idx, rgba);
		}

		// Token: 0x060147A5 RID: 83877
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunction_GetNanColor_38(HandleRef pThis);

		/// <summary>
		/// Set the RGB color to use when a NaN (not a number) is
		/// encountered.  This is an RGB 3-tuple color of doubles in the
		/// range [0,1].
		/// </summary>
		// Token: 0x060147A6 RID: 83878 RVA: 0x001CFFF8 File Offset: 0x001CE1F8
		public virtual double[] GetNanColor()
		{
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_GetNanColor_38(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060147A7 RID: 83879
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_GetNanColor_39(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the RGB color to use when a NaN (not a number) is
		/// encountered.  This is an RGB 3-tuple color of doubles in the
		/// range [0,1].
		/// </summary>
		// Token: 0x060147A8 RID: 83880 RVA: 0x001D0040 File Offset: 0x001CE240
		public virtual void GetNanColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetNanColor_39(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060147A9 RID: 83881
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_GetNanColor_40(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the RGB color to use when a NaN (not a number) is
		/// encountered.  This is an RGB 3-tuple color of doubles in the
		/// range [0,1].
		/// </summary>
		// Token: 0x060147AA RID: 83882 RVA: 0x001D0052 File Offset: 0x001CE252
		public virtual void GetNanColor(IntPtr _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetNanColor_40(base.GetCppThis(), _arg);
		}

		// Token: 0x060147AB RID: 83883
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkColorTransferFunction_GetNanOpacity_41(HandleRef pThis);

		/// <summary>
		/// Get/Set the opacity to use when a NaN (not a number) is
		/// encountered. This a double in the range [0,1].
		/// </summary>
		// Token: 0x060147AC RID: 83884 RVA: 0x001D0064 File Offset: 0x001CE264
		public virtual double GetNanOpacity()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetNanOpacity_41(base.GetCppThis());
		}

		// Token: 0x060147AD RID: 83885
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetNodeValue_42(HandleRef pThis, int index, IntPtr val);

		/// <summary>
		/// For the node specified by index, set/get the
		/// location (X), R, G, and B values, midpoint, and
		/// sharpness values at the node.
		/// </summary>
		// Token: 0x060147AE RID: 83886 RVA: 0x001D0084 File Offset: 0x001CE284
		public int GetNodeValue(int index, IntPtr val)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetNodeValue_42(base.GetCppThis(), index, val);
		}

		// Token: 0x060147AF RID: 83887
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorTransferFunction_GetNumberOfAvailableColors_43(HandleRef pThis);

		/// <summary>
		/// Get the number of available colors for mapping to.
		/// </summary>
		// Token: 0x060147B0 RID: 83888 RVA: 0x001D00A8 File Offset: 0x001CE2A8
		public override long GetNumberOfAvailableColors()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetNumberOfAvailableColors_43(base.GetCppThis());
		}

		// Token: 0x060147B1 RID: 83889
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorTransferFunction_GetNumberOfGenerationsFromBase_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060147B2 RID: 83890 RVA: 0x001D00C8 File Offset: 0x001CE2C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetNumberOfGenerationsFromBase_44(base.GetCppThis(), type);
		}

		// Token: 0x060147B3 RID: 83891
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorTransferFunction_GetNumberOfGenerationsFromBaseType_45([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060147B4 RID: 83892 RVA: 0x001D00E8 File Offset: 0x001CE2E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetNumberOfGenerationsFromBaseType_45(type);
		}

		// Token: 0x060147B5 RID: 83893
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunction_GetRange_46(HandleRef pThis);

		/// <summary>
		/// Returns min and max position of all function points.
		/// </summary>
		// Token: 0x060147B6 RID: 83894 RVA: 0x001D0104 File Offset: 0x001CE304
		public override double[] GetRange()
		{
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_GetRange_46(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060147B7 RID: 83895
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_GetRange_47(HandleRef pThis, ref double arg1, ref double arg2);

		/// <summary>
		/// Returns min and max position of all function points.
		/// </summary>
		// Token: 0x060147B8 RID: 83896 RVA: 0x001D014C File Offset: 0x001CE34C
		public virtual void GetRange(ref double arg1, ref double arg2)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetRange_47(base.GetCppThis(), ref arg1, ref arg2);
		}

		// Token: 0x060147B9 RID: 83897
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_GetRange_48(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Returns min and max position of all function points.
		/// </summary>
		// Token: 0x060147BA RID: 83898 RVA: 0x001D015D File Offset: 0x001CE35D
		public virtual void GetRange(IntPtr _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetRange_48(base.GetCppThis(), _arg);
		}

		// Token: 0x060147BB RID: 83899
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkColorTransferFunction_GetRedValue_49(HandleRef pThis, double x);

		/// <summary>
		/// Get the color components individually.
		/// </summary>
		// Token: 0x060147BC RID: 83900 RVA: 0x001D0170 File Offset: 0x001CE370
		public double GetRedValue(double x)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetRedValue_49(base.GetCppThis(), x);
		}

		// Token: 0x060147BD RID: 83901
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetScale_50(HandleRef pThis);

		/// <summary>
		/// Set the type of scale to use, linear or logarithmic.  The default
		/// is linear.  If the scale is logarithmic, and the range contains
		/// zero, the color mapping will be linear.
		/// </summary>
		// Token: 0x060147BE RID: 83902 RVA: 0x001D0190 File Offset: 0x001CE390
		public virtual int GetScale()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetScale_50(base.GetCppThis());
		}

		// Token: 0x060147BF RID: 83903
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetSize_51(HandleRef pThis);

		/// <summary>
		/// How many nodes define this function?
		/// </summary>
		// Token: 0x060147C0 RID: 83904 RVA: 0x001D01B0 File Offset: 0x001CE3B0
		public int GetSize()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetSize_51(base.GetCppThis());
		}

		// Token: 0x060147C1 RID: 83905
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_GetTable_52(HandleRef pThis, double x1, double x2, int n, IntPtr table);

		/// <summary>
		/// Fills in a table of \a n colors mapped from \a values mapped with
		/// even spacing between x1 and x2, inclusive.
		///
		/// Note that \a GetTable ignores \a IndexedLookup
		/// </summary>
		// Token: 0x060147C2 RID: 83906 RVA: 0x001D01CF File Offset: 0x001CE3CF
		public void GetTable(double x1, double x2, int n, IntPtr table)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetTable_52(base.GetCppThis(), x1, x2, n, table);
		}

		// Token: 0x060147C3 RID: 83907
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunction_GetTable_53(HandleRef pThis, double x1, double x2, int n);

		/// <summary>
		/// Fills in a table of \a n colors mapped from \a values mapped with
		/// even spacing between x1 and x2, inclusive.
		///
		/// Note that \a GetTable ignores \a IndexedLookup
		/// </summary>
		// Token: 0x060147C4 RID: 83908 RVA: 0x001D01E4 File Offset: 0x001CE3E4
		public IntPtr GetTable(double x1, double x2, int n)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetTable_53(base.GetCppThis(), x1, x2, n);
		}

		// Token: 0x060147C5 RID: 83909
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetUseAboveRangeColor_54(HandleRef pThis);

		/// <summary>
		/// Set whether the below range color should be used.
		/// </summary>
		// Token: 0x060147C6 RID: 83910 RVA: 0x001D0208 File Offset: 0x001CE408
		public virtual int GetUseAboveRangeColor()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetUseAboveRangeColor_54(base.GetCppThis());
		}

		// Token: 0x060147C7 RID: 83911
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_GetUseBelowRangeColor_55(HandleRef pThis);

		/// <summary>
		/// Set whether the below range color should be used.
		/// </summary>
		// Token: 0x060147C8 RID: 83912 RVA: 0x001D0228 File Offset: 0x001CE428
		public virtual int GetUseBelowRangeColor()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetUseBelowRangeColor_55(base.GetCppThis());
		}

		// Token: 0x060147C9 RID: 83913
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_HSVWrapOff_56(HandleRef pThis);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x060147CA RID: 83914 RVA: 0x001D0247 File Offset: 0x001CE447
		public virtual void HSVWrapOff()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_HSVWrapOff_56(base.GetCppThis());
		}

		// Token: 0x060147CB RID: 83915
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_HSVWrapOn_57(HandleRef pThis);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x060147CC RID: 83916 RVA: 0x001D0256 File Offset: 0x001CE456
		public virtual void HSVWrapOn()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_HSVWrapOn_57(base.GetCppThis());
		}

		// Token: 0x060147CD RID: 83917
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_IsA_58(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060147CE RID: 83918 RVA: 0x001D0268 File Offset: 0x001CE468
		public override int IsA(string type)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_IsA_58(base.GetCppThis(), type);
		}

		// Token: 0x060147CF RID: 83919
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_IsTypeOf_59([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060147D0 RID: 83920 RVA: 0x001D0288 File Offset: 0x001CE488
		public new static int IsTypeOf(string type)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_IsTypeOf_59(type);
		}

		// Token: 0x060147D1 RID: 83921
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_MapScalarsThroughTable2_60(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement);

		/// <summary>
		/// Map a set of scalars through the lookup table.
		/// </summary>
		// Token: 0x060147D2 RID: 83922 RVA: 0x001D02A2 File Offset: 0x001CE4A2
		public override void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_MapScalarsThroughTable2_60(base.GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputIncrement);
		}

		// Token: 0x060147D3 RID: 83923
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunction_MapValue_61(HandleRef pThis, double v);

		/// <summary>
		/// Map one value through the lookup table.
		/// </summary>
		// Token: 0x060147D4 RID: 83924 RVA: 0x001D02BC File Offset: 0x001CE4BC
		public override IntPtr MapValue(double v)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_MapValue_61(base.GetCppThis(), v);
		}

		// Token: 0x060147D5 RID: 83925
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunction_NewInstance_63(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060147D6 RID: 83926 RVA: 0x001D02DC File Offset: 0x001CE4DC
		public new vtkColorTransferFunction NewInstance()
		{
			vtkColorTransferFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_NewInstance_63(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060147D7 RID: 83927
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_RemoveAllPoints_64(HandleRef pThis);

		/// <summary>
		/// Remove all points
		/// </summary>
		// Token: 0x060147D8 RID: 83928 RVA: 0x001D0336 File Offset: 0x001CE536
		public void RemoveAllPoints()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_RemoveAllPoints_64(base.GetCppThis());
		}

		// Token: 0x060147D9 RID: 83929
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_RemovePoint_65(HandleRef pThis, double x);

		/// <summary>
		/// Add/Remove a point to/from the function defined in RGB or HSV
		/// Return the index of the point (0 based), or -1 on error.
		/// See the description of class vtkPiecewiseFunction for an explanation of
		/// midpoint and sharpness.
		/// </summary>
		// Token: 0x060147DA RID: 83930 RVA: 0x001D0348 File Offset: 0x001CE548
		public int RemovePoint(double x)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_RemovePoint_65(base.GetCppThis(), x);
		}

		// Token: 0x060147DB RID: 83931
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunction_SafeDownCast_66(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060147DC RID: 83932 RVA: 0x001D0368 File Offset: 0x001CE568
		public new static vtkColorTransferFunction SafeDownCast(vtkObjectBase o)
		{
			vtkColorTransferFunction vtkColorTransferFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_SafeDownCast_66((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferFunction = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferFunction.Register(null);
				}
			}
			return vtkColorTransferFunction;
		}

		// Token: 0x060147DD RID: 83933
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetAboveRangeColor_67(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the color to use when a value above the range is
		/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x060147DE RID: 83934 RVA: 0x001D03E7 File Offset: 0x001CE5E7
		public virtual void SetAboveRangeColor(double _arg1, double _arg2, double _arg3)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetAboveRangeColor_67(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060147DF RID: 83935
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetAboveRangeColor_68(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color to use when a value above the range is
		/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x060147E0 RID: 83936 RVA: 0x001D03F9 File Offset: 0x001CE5F9
		public virtual void SetAboveRangeColor(IntPtr _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetAboveRangeColor_68(base.GetCppThis(), _arg);
		}

		// Token: 0x060147E1 RID: 83937
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetAllowDuplicateScalars_69(HandleRef pThis, int _arg);

		/// <summary>
		/// Toggle whether to allow duplicate scalar values in the color transfer
		/// function (off by default).
		/// </summary>
		// Token: 0x060147E2 RID: 83938 RVA: 0x001D0409 File Offset: 0x001CE609
		public virtual void SetAllowDuplicateScalars(int _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetAllowDuplicateScalars_69(base.GetCppThis(), _arg);
		}

		// Token: 0x060147E3 RID: 83939
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetBelowRangeColor_70(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the color to use when a value below the range is
		/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x060147E4 RID: 83940 RVA: 0x001D0419 File Offset: 0x001CE619
		public virtual void SetBelowRangeColor(double _arg1, double _arg2, double _arg3)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetBelowRangeColor_70(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060147E5 RID: 83941
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetBelowRangeColor_71(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color to use when a value below the range is
		/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x060147E6 RID: 83942 RVA: 0x001D042B File Offset: 0x001CE62B
		public virtual void SetBelowRangeColor(IntPtr _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetBelowRangeColor_71(base.GetCppThis(), _arg);
		}

		// Token: 0x060147E7 RID: 83943
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetClamping_72(HandleRef pThis, int _arg);

		/// <summary>
		/// Sets/gets whether clamping is used. If on, scalar values below
		/// the lower range value set for the transfer function will be
		/// mapped to the first node color, and scalar values above the upper
		/// range value set for the transfer function will be mapped to the
		/// last node color. If off, values outside the range are mapped to
		/// black.
		/// </summary>
		// Token: 0x060147E8 RID: 83944 RVA: 0x001D043B File Offset: 0x001CE63B
		public virtual void SetClamping(int _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetClamping_72(base.GetCppThis(), _arg);
		}

		// Token: 0x060147E9 RID: 83945
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetColorSpace_73(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x060147EA RID: 83946 RVA: 0x001D044B File Offset: 0x001CE64B
		public virtual void SetColorSpace(int _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetColorSpace_73(base.GetCppThis(), _arg);
		}

		// Token: 0x060147EB RID: 83947
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetColorSpaceToDiverging_74(HandleRef pThis);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x060147EC RID: 83948 RVA: 0x001D045B File Offset: 0x001CE65B
		public void SetColorSpaceToDiverging()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetColorSpaceToDiverging_74(base.GetCppThis());
		}

		// Token: 0x060147ED RID: 83949
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetColorSpaceToHSV_75(HandleRef pThis);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x060147EE RID: 83950 RVA: 0x001D046A File Offset: 0x001CE66A
		public void SetColorSpaceToHSV()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetColorSpaceToHSV_75(base.GetCppThis());
		}

		// Token: 0x060147EF RID: 83951
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetColorSpaceToLab_76(HandleRef pThis);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x060147F0 RID: 83952 RVA: 0x001D0479 File Offset: 0x001CE679
		public void SetColorSpaceToLab()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetColorSpaceToLab_76(base.GetCppThis());
		}

		// Token: 0x060147F1 RID: 83953
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetColorSpaceToLabCIEDE2000_77(HandleRef pThis);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x060147F2 RID: 83954 RVA: 0x001D0488 File Offset: 0x001CE688
		public void SetColorSpaceToLabCIEDE2000()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetColorSpaceToLabCIEDE2000_77(base.GetCppThis());
		}

		// Token: 0x060147F3 RID: 83955
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetColorSpaceToRGB_78(HandleRef pThis);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x060147F4 RID: 83956 RVA: 0x001D0497 File Offset: 0x001CE697
		public void SetColorSpaceToRGB()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetColorSpaceToRGB_78(base.GetCppThis());
		}

		// Token: 0x060147F5 RID: 83957
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetColorSpaceToStep_79(HandleRef pThis);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x060147F6 RID: 83958 RVA: 0x001D04A6 File Offset: 0x001CE6A6
		public void SetColorSpaceToStep()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetColorSpaceToStep_79(base.GetCppThis());
		}

		// Token: 0x060147F7 RID: 83959
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetHSVWrap_80(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
		/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
		/// in Hue (going back through 0 if that is the shortest way around the hue
		/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
		/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
		/// it will take the shortest path in the Lab color space with respect to the
		/// CIE Delta E 2000 color distance measure. Diverging is a special
		/// mode where colors will pass through white when interpolating between two
		/// saturated colors. Step is a mode where the color of an interval is the
		/// color of the second color of the interval.
		/// </summary>
		// Token: 0x060147F8 RID: 83960 RVA: 0x001D04B5 File Offset: 0x001CE6B5
		public virtual void SetHSVWrap(int _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetHSVWrap_80(base.GetCppThis(), _arg);
		}

		// Token: 0x060147F9 RID: 83961
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetNanColor_81(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the RGB color to use when a NaN (not a number) is
		/// encountered.  This is an RGB 3-tuple color of doubles in the
		/// range [0,1].
		/// </summary>
		// Token: 0x060147FA RID: 83962 RVA: 0x001D04C5 File Offset: 0x001CE6C5
		public virtual void SetNanColor(double _arg1, double _arg2, double _arg3)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetNanColor_81(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060147FB RID: 83963
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetNanColor_82(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the RGB color to use when a NaN (not a number) is
		/// encountered.  This is an RGB 3-tuple color of doubles in the
		/// range [0,1].
		/// </summary>
		// Token: 0x060147FC RID: 83964 RVA: 0x001D04D7 File Offset: 0x001CE6D7
		public virtual void SetNanColor(IntPtr _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetNanColor_82(base.GetCppThis(), _arg);
		}

		// Token: 0x060147FD RID: 83965
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetNanColorRGBA_83(HandleRef pThis, double r, double g, double b, double a);

		/// <summary>
		/// Set the RGBA color to use when a NaN (not a number) is
		/// encountered.  This is an RGBA 4-tuple color of doubles in the
		/// range [0,1].
		/// </summary>
		// Token: 0x060147FE RID: 83966 RVA: 0x001D04E7 File Offset: 0x001CE6E7
		public virtual void SetNanColorRGBA(double r, double g, double b, double a)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetNanColorRGBA_83(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x060147FF RID: 83967
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetNanColorRGBA_84(HandleRef pThis, IntPtr rgba);

		/// <summary>
		/// Set the RGBA color to use when a NaN (not a number) is
		/// encountered.  This is an RGBA 4-tuple color of doubles in the
		/// range [0,1].
		/// </summary>
		// Token: 0x06014800 RID: 83968 RVA: 0x001D04FB File Offset: 0x001CE6FB
		public void SetNanColorRGBA(IntPtr rgba)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetNanColorRGBA_84(base.GetCppThis(), rgba);
		}

		// Token: 0x06014801 RID: 83969
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetNanOpacity_85(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the opacity to use when a NaN (not a number) is
		/// encountered. This a double in the range [0,1].
		/// </summary>
		// Token: 0x06014802 RID: 83970 RVA: 0x001D050B File Offset: 0x001CE70B
		public virtual void SetNanOpacity(double _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetNanOpacity_85(base.GetCppThis(), _arg);
		}

		// Token: 0x06014803 RID: 83971
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunction_SetNodeValue_86(HandleRef pThis, int index, IntPtr val);

		/// <summary>
		/// For the node specified by index, set/get the
		/// location (X), R, G, and B values, midpoint, and
		/// sharpness values at the node.
		/// </summary>
		// Token: 0x06014804 RID: 83972 RVA: 0x001D051C File Offset: 0x001CE71C
		public int SetNodeValue(int index, IntPtr val)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_SetNodeValue_86(base.GetCppThis(), index, val);
		}

		// Token: 0x06014805 RID: 83973
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetScale_87(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the type of scale to use, linear or logarithmic.  The default
		/// is linear.  If the scale is logarithmic, and the range contains
		/// zero, the color mapping will be linear.
		/// </summary>
		// Token: 0x06014806 RID: 83974 RVA: 0x001D053D File Offset: 0x001CE73D
		public virtual void SetScale(int _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetScale_87(base.GetCppThis(), _arg);
		}

		// Token: 0x06014807 RID: 83975
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetScaleToLinear_88(HandleRef pThis);

		/// <summary>
		/// Set the type of scale to use, linear or logarithmic.  The default
		/// is linear.  If the scale is logarithmic, and the range contains
		/// zero, the color mapping will be linear.
		/// </summary>
		// Token: 0x06014808 RID: 83976 RVA: 0x001D054D File Offset: 0x001CE74D
		public void SetScaleToLinear()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetScaleToLinear_88(base.GetCppThis());
		}

		// Token: 0x06014809 RID: 83977
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetScaleToLog10_89(HandleRef pThis);

		/// <summary>
		/// Set the type of scale to use, linear or logarithmic.  The default
		/// is linear.  If the scale is logarithmic, and the range contains
		/// zero, the color mapping will be linear.
		/// </summary>
		// Token: 0x0601480A RID: 83978 RVA: 0x001D055C File Offset: 0x001CE75C
		public void SetScaleToLog10()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetScaleToLog10_89(base.GetCppThis());
		}

		// Token: 0x0601480B RID: 83979
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetUseAboveRangeColor_90(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether the below range color should be used.
		/// </summary>
		// Token: 0x0601480C RID: 83980 RVA: 0x001D056B File Offset: 0x001CE76B
		public virtual void SetUseAboveRangeColor(int _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetUseAboveRangeColor_90(base.GetCppThis(), _arg);
		}

		// Token: 0x0601480D RID: 83981
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_SetUseBelowRangeColor_91(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether the below range color should be used.
		/// </summary>
		// Token: 0x0601480E RID: 83982 RVA: 0x001D057B File Offset: 0x001CE77B
		public virtual void SetUseBelowRangeColor(int _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetUseBelowRangeColor_91(base.GetCppThis(), _arg);
		}

		// Token: 0x0601480F RID: 83983
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_ShallowCopy_92(HandleRef pThis, HandleRef f);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014810 RID: 83984 RVA: 0x001D058C File Offset: 0x001CE78C
		public void ShallowCopy(vtkColorTransferFunction f)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_ShallowCopy_92(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		// Token: 0x06014811 RID: 83985
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_UseAboveRangeColorOff_93(HandleRef pThis);

		/// <summary>
		/// Set whether the below range color should be used.
		/// </summary>
		// Token: 0x06014812 RID: 83986 RVA: 0x001D05BB File Offset: 0x001CE7BB
		public virtual void UseAboveRangeColorOff()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_UseAboveRangeColorOff_93(base.GetCppThis());
		}

		// Token: 0x06014813 RID: 83987
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_UseAboveRangeColorOn_94(HandleRef pThis);

		/// <summary>
		/// Set whether the below range color should be used.
		/// </summary>
		// Token: 0x06014814 RID: 83988 RVA: 0x001D05CA File Offset: 0x001CE7CA
		public virtual void UseAboveRangeColorOn()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_UseAboveRangeColorOn_94(base.GetCppThis());
		}

		// Token: 0x06014815 RID: 83989
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_UseBelowRangeColorOff_95(HandleRef pThis);

		/// <summary>
		/// Set whether the below range color should be used.
		/// </summary>
		// Token: 0x06014816 RID: 83990 RVA: 0x001D05D9 File Offset: 0x001CE7D9
		public virtual void UseBelowRangeColorOff()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_UseBelowRangeColorOff_95(base.GetCppThis());
		}

		// Token: 0x06014817 RID: 83991
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunction_UseBelowRangeColorOn_96(HandleRef pThis);

		/// <summary>
		/// Set whether the below range color should be used.
		/// </summary>
		// Token: 0x06014818 RID: 83992 RVA: 0x001D05E8 File Offset: 0x001CE7E8
		public virtual void UseBelowRangeColorOn()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_UseBelowRangeColorOn_96(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017CA RID: 6090
		public new const string MRFullTypeName = "Kitware.VTK.vtkColorTransferFunction";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017CB RID: 6091
		public new static readonly string MRClassNameKey = "class vtkColorTransferFunction";
	}
}
