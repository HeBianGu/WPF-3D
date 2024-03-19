using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTubeFilter
	/// </summary>
	/// <remarks>
	///    filter that generates tubes around lines
	///
	/// vtkTubeFilter is a filter that generates a tube around each input line.
	/// The tubes are made up of triangle strips and rotate around the tube with
	/// the rotation of the line normals. (If no normals are present, they are
	/// computed automatically.) The radius of the tube can be set to vary with
	/// scalar or vector value. If the radius varies with scalar value the radius
	/// is linearly adjusted. If the radius varies by vector, a mass flux preserving
	/// variation is used. If the radius varies by vector norm, the radius is
	/// linearly adjusted to its norm. The number of sides for the tube also
	/// can be specified. You can also specify which of the sides are visible. This
	/// is useful for generating interesting striping effects. Other options
	/// include the ability to cap the tube and generate texture coordinates.
	/// Texture coordinates can be used with an associated texture map to create
	/// interesting effects such as marking the tube with stripes corresponding
	/// to length or time.
	///
	/// This filter is typically used to create thick or dramatic lines. Another
	/// common use is to combine this filter with vtkStreamTracer to generate
	/// streamtubes.
	///
	/// @warning
	/// The number of tube sides must be greater than 3. If you wish to use fewer
	/// sides (i.e., a ribbon), use vtkRibbonFilter.
	///
	/// @warning
	/// The input line must not have duplicate points, or normals at points that
	/// are parallel to the incoming/outgoing line segments. (Duplicate points
	/// can be removed with vtkCleanPolyData.) If a line does not meet this
	/// criteria, then that line is not tubed.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRibbonFilter vtkStreamTracer vtkTubeBender
	///
	/// @par Thanks:
	/// Michael Finch for absolute scalar radius
	/// </seealso>
	// Token: 0x020009BB RID: 2491
	public class vtkTubeFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A033 RID: 106547 RVA: 0x00241307 File Offset: 0x0023F507
		static vtkTubeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTubeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTubeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A034 RID: 106548 RVA: 0x0024132F File Offset: 0x0023F52F
		public vtkTubeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A035 RID: 106549
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTubeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with radius 0.5, radius variation turned off, the
		/// number of sides set to 3, and radius factor of 10.
		/// </summary>
		// Token: 0x0601A036 RID: 106550 RVA: 0x00241340 File Offset: 0x0023F540
		public new static vtkTubeFilter New()
		{
			vtkTubeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTubeFilter.vtkTubeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTubeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with radius 0.5, radius variation turned off, the
		/// number of sides set to 3, and radius factor of 10.
		/// </summary>
		// Token: 0x0601A037 RID: 106551 RVA: 0x00241394 File Offset: 0x0023F594
		public vtkTubeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTubeFilter.vtkTubeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A038 RID: 106552 RVA: 0x002413D8 File Offset: 0x0023F5D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A039 RID: 106553
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_CappingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether to cap the ends with polygons. Initial value is off.
		/// </summary>
		// Token: 0x0601A03A RID: 106554 RVA: 0x002413E3 File Offset: 0x0023F5E3
		public virtual void CappingOff()
		{
			vtkTubeFilter.vtkTubeFilter_CappingOff_01(base.GetCppThis());
		}

		// Token: 0x0601A03B RID: 106555
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_CappingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether to cap the ends with polygons. Initial value is off.
		/// </summary>
		// Token: 0x0601A03C RID: 106556 RVA: 0x002413F2 File Offset: 0x0023F5F2
		public virtual void CappingOn()
		{
			vtkTubeFilter.vtkTubeFilter_CappingOn_02(base.GetCppThis());
		}

		// Token: 0x0601A03D RID: 106557
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetCapping_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether to cap the ends with polygons. Initial value is off.
		/// </summary>
		// Token: 0x0601A03E RID: 106558 RVA: 0x00241404 File Offset: 0x0023F604
		public virtual int GetCapping()
		{
			return vtkTubeFilter.vtkTubeFilter_GetCapping_03(base.GetCppThis());
		}

		// Token: 0x0601A03F RID: 106559
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTubeFilter_GetDefaultNormal_04(HandleRef pThis);

		/// <summary>
		/// Set the default normal to use if no normals are supplied, and the
		/// DefaultNormalOn is set.
		/// </summary>
		// Token: 0x0601A040 RID: 106560 RVA: 0x00241424 File Offset: 0x0023F624
		public virtual double[] GetDefaultNormal()
		{
			IntPtr intPtr = vtkTubeFilter.vtkTubeFilter_GetDefaultNormal_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601A041 RID: 106561
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_GetDefaultNormal_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the default normal to use if no normals are supplied, and the
		/// DefaultNormalOn is set.
		/// </summary>
		// Token: 0x0601A042 RID: 106562 RVA: 0x0024146C File Offset: 0x0023F66C
		public virtual void GetDefaultNormal(IntPtr data)
		{
			vtkTubeFilter.vtkTubeFilter_GetDefaultNormal_05(base.GetCppThis(), data);
		}

		// Token: 0x0601A043 RID: 106563
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetGenerateTCoords_06(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the tube with length textures, etc. If you
		/// use scalars to create the texture, the scalars are assumed to be
		/// monotonically increasing (or decreasing).
		/// </summary>
		// Token: 0x0601A044 RID: 106564 RVA: 0x0024147C File Offset: 0x0023F67C
		public virtual int GetGenerateTCoords()
		{
			return vtkTubeFilter.vtkTubeFilter_GetGenerateTCoords_06(base.GetCppThis());
		}

		// Token: 0x0601A045 RID: 106565
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTubeFilter_GetGenerateTCoordsAsString_07(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the tube with length textures, etc. If you
		/// use scalars to create the texture, the scalars are assumed to be
		/// monotonically increasing (or decreasing).
		/// </summary>
		// Token: 0x0601A046 RID: 106566 RVA: 0x0024149C File Offset: 0x0023F69C
		public string GetGenerateTCoordsAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkTubeFilter.vtkTubeFilter_GetGenerateTCoordsAsString_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601A047 RID: 106567
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetGenerateTCoordsMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the tube with length textures, etc. If you
		/// use scalars to create the texture, the scalars are assumed to be
		/// monotonically increasing (or decreasing).
		/// </summary>
		// Token: 0x0601A048 RID: 106568 RVA: 0x002414D8 File Offset: 0x0023F6D8
		public virtual int GetGenerateTCoordsMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetGenerateTCoordsMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0601A049 RID: 106569
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetGenerateTCoordsMinValue_09(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the tube with length textures, etc. If you
		/// use scalars to create the texture, the scalars are assumed to be
		/// monotonically increasing (or decreasing).
		/// </summary>
		// Token: 0x0601A04A RID: 106570 RVA: 0x002414F8 File Offset: 0x0023F6F8
		public virtual int GetGenerateTCoordsMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetGenerateTCoordsMinValue_09(base.GetCppThis());
		}

		// Token: 0x0601A04B RID: 106571
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTubeFilter_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A04C RID: 106572 RVA: 0x00241518 File Offset: 0x0023F718
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTubeFilter.vtkTubeFilter_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601A04D RID: 106573
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTubeFilter_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A04E RID: 106574 RVA: 0x00241538 File Offset: 0x0023F738
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTubeFilter.vtkTubeFilter_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601A04F RID: 106575
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetNumberOfSides_12(HandleRef pThis);

		/// <summary>
		/// Set the number of sides for the tube. At a minimum, number of sides is 3.
		/// </summary>
		// Token: 0x0601A050 RID: 106576 RVA: 0x00241554 File Offset: 0x0023F754
		public virtual int GetNumberOfSides()
		{
			return vtkTubeFilter.vtkTubeFilter_GetNumberOfSides_12(base.GetCppThis());
		}

		// Token: 0x0601A051 RID: 106577
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetNumberOfSidesMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set the number of sides for the tube. At a minimum, number of sides is 3.
		/// </summary>
		// Token: 0x0601A052 RID: 106578 RVA: 0x00241574 File Offset: 0x0023F774
		public virtual int GetNumberOfSidesMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetNumberOfSidesMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0601A053 RID: 106579
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetNumberOfSidesMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set the number of sides for the tube. At a minimum, number of sides is 3.
		/// </summary>
		// Token: 0x0601A054 RID: 106580 RVA: 0x00241594 File Offset: 0x0023F794
		public virtual int GetNumberOfSidesMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetNumberOfSidesMinValue_14(base.GetCppThis());
		}

		// Token: 0x0601A055 RID: 106581
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetOffset_15(HandleRef pThis);

		/// <summary>
		/// Control the striping of the tubes. The offset sets the
		/// first tube side that is visible. Offset is generally used with
		/// OnRatio to create nifty striping effects.
		/// </summary>
		// Token: 0x0601A056 RID: 106582 RVA: 0x002415B4 File Offset: 0x0023F7B4
		public virtual int GetOffset()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOffset_15(base.GetCppThis());
		}

		// Token: 0x0601A057 RID: 106583
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetOffsetMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Control the striping of the tubes. The offset sets the
		/// first tube side that is visible. Offset is generally used with
		/// OnRatio to create nifty striping effects.
		/// </summary>
		// Token: 0x0601A058 RID: 106584 RVA: 0x002415D4 File Offset: 0x0023F7D4
		public virtual int GetOffsetMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOffsetMaxValue_16(base.GetCppThis());
		}

		// Token: 0x0601A059 RID: 106585
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetOffsetMinValue_17(HandleRef pThis);

		/// <summary>
		/// Control the striping of the tubes. The offset sets the
		/// first tube side that is visible. Offset is generally used with
		/// OnRatio to create nifty striping effects.
		/// </summary>
		// Token: 0x0601A05A RID: 106586 RVA: 0x002415F4 File Offset: 0x0023F7F4
		public virtual int GetOffsetMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOffsetMinValue_17(base.GetCppThis());
		}

		// Token: 0x0601A05B RID: 106587
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetOnRatio_18(HandleRef pThis);

		/// <summary>
		/// Control the striping of the tubes. If OnRatio is greater than 1,
		/// then every nth tube side is turned on, beginning with the Offset
		/// side.
		/// </summary>
		// Token: 0x0601A05C RID: 106588 RVA: 0x00241614 File Offset: 0x0023F814
		public virtual int GetOnRatio()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOnRatio_18(base.GetCppThis());
		}

		// Token: 0x0601A05D RID: 106589
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetOnRatioMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Control the striping of the tubes. If OnRatio is greater than 1,
		/// then every nth tube side is turned on, beginning with the Offset
		/// side.
		/// </summary>
		// Token: 0x0601A05E RID: 106590 RVA: 0x00241634 File Offset: 0x0023F834
		public virtual int GetOnRatioMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOnRatioMaxValue_19(base.GetCppThis());
		}

		// Token: 0x0601A05F RID: 106591
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetOnRatioMinValue_20(HandleRef pThis);

		/// <summary>
		/// Control the striping of the tubes. If OnRatio is greater than 1,
		/// then every nth tube side is turned on, beginning with the Offset
		/// side.
		/// </summary>
		// Token: 0x0601A060 RID: 106592 RVA: 0x00241654 File Offset: 0x0023F854
		public virtual int GetOnRatioMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOnRatioMinValue_20(base.GetCppThis());
		}

		// Token: 0x0601A061 RID: 106593
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetOutputPointsPrecision_21(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0601A062 RID: 106594 RVA: 0x00241674 File Offset: 0x0023F874
		public virtual int GetOutputPointsPrecision()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOutputPointsPrecision_21(base.GetCppThis());
		}

		// Token: 0x0601A063 RID: 106595
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTubeFilter_GetRadius_22(HandleRef pThis);

		/// <summary>
		/// Set the minimum tube radius (minimum because the tube radius may vary).
		/// </summary>
		// Token: 0x0601A064 RID: 106596 RVA: 0x00241694 File Offset: 0x0023F894
		public virtual double GetRadius()
		{
			return vtkTubeFilter.vtkTubeFilter_GetRadius_22(base.GetCppThis());
		}

		// Token: 0x0601A065 RID: 106597
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTubeFilter_GetRadiusFactor_23(HandleRef pThis);

		/// <summary>
		/// Set the maximum tube radius in terms of a multiple of the minimum radius.
		/// </summary>
		// Token: 0x0601A066 RID: 106598 RVA: 0x002416B4 File Offset: 0x0023F8B4
		public virtual double GetRadiusFactor()
		{
			return vtkTubeFilter.vtkTubeFilter_GetRadiusFactor_23(base.GetCppThis());
		}

		// Token: 0x0601A067 RID: 106599
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTubeFilter_GetRadiusMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Set the minimum tube radius (minimum because the tube radius may vary).
		/// </summary>
		// Token: 0x0601A068 RID: 106600 RVA: 0x002416D4 File Offset: 0x0023F8D4
		public virtual double GetRadiusMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetRadiusMaxValue_24(base.GetCppThis());
		}

		// Token: 0x0601A069 RID: 106601
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTubeFilter_GetRadiusMinValue_25(HandleRef pThis);

		/// <summary>
		/// Set the minimum tube radius (minimum because the tube radius may vary).
		/// </summary>
		// Token: 0x0601A06A RID: 106602 RVA: 0x002416F4 File Offset: 0x0023F8F4
		public virtual double GetRadiusMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetRadiusMinValue_25(base.GetCppThis());
		}

		// Token: 0x0601A06B RID: 106603
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetSidesShareVertices_26(HandleRef pThis);

		/// <summary>
		/// Set a boolean to control whether tube sides should share vertices.
		/// This creates independent strips, with constant normals so the
		/// tube is always faceted in appearance.
		/// </summary>
		// Token: 0x0601A06C RID: 106604 RVA: 0x00241714 File Offset: 0x0023F914
		public virtual int GetSidesShareVertices()
		{
			return vtkTubeFilter.vtkTubeFilter_GetSidesShareVertices_26(base.GetCppThis());
		}

		// Token: 0x0601A06D RID: 106605
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTubeFilter_GetTextureLength_27(HandleRef pThis);

		/// <summary>
		/// Control the conversion of units during the texture coordinates
		/// calculation. The TextureLength indicates what length (whether
		/// calculated from scalars or length) is mapped to the [0,1)
		/// texture space.
		/// </summary>
		// Token: 0x0601A06E RID: 106606 RVA: 0x00241734 File Offset: 0x0023F934
		public virtual double GetTextureLength()
		{
			return vtkTubeFilter.vtkTubeFilter_GetTextureLength_27(base.GetCppThis());
		}

		// Token: 0x0601A06F RID: 106607
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTubeFilter_GetTextureLengthMaxValue_28(HandleRef pThis);

		/// <summary>
		/// Control the conversion of units during the texture coordinates
		/// calculation. The TextureLength indicates what length (whether
		/// calculated from scalars or length) is mapped to the [0,1)
		/// texture space.
		/// </summary>
		// Token: 0x0601A070 RID: 106608 RVA: 0x00241754 File Offset: 0x0023F954
		public virtual double GetTextureLengthMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetTextureLengthMaxValue_28(base.GetCppThis());
		}

		// Token: 0x0601A071 RID: 106609
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTubeFilter_GetTextureLengthMinValue_29(HandleRef pThis);

		/// <summary>
		/// Control the conversion of units during the texture coordinates
		/// calculation. The TextureLength indicates what length (whether
		/// calculated from scalars or length) is mapped to the [0,1)
		/// texture space.
		/// </summary>
		// Token: 0x0601A072 RID: 106610 RVA: 0x00241774 File Offset: 0x0023F974
		public virtual double GetTextureLengthMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetTextureLengthMinValue_29(base.GetCppThis());
		}

		// Token: 0x0601A073 RID: 106611
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetUseDefaultNormal_30(HandleRef pThis);

		/// <summary>
		/// Set a boolean to control whether to use default normals.
		/// DefaultNormalOn is set.
		/// </summary>
		// Token: 0x0601A074 RID: 106612 RVA: 0x00241794 File Offset: 0x0023F994
		public virtual int GetUseDefaultNormal()
		{
			return vtkTubeFilter.vtkTubeFilter_GetUseDefaultNormal_30(base.GetCppThis());
		}

		// Token: 0x0601A075 RID: 106613
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetVaryRadius_31(HandleRef pThis);

		/// <summary>
		/// Turn on/off the variation of tube radius with scalar value.
		/// </summary>
		// Token: 0x0601A076 RID: 106614 RVA: 0x002417B4 File Offset: 0x0023F9B4
		public virtual int GetVaryRadius()
		{
			return vtkTubeFilter.vtkTubeFilter_GetVaryRadius_31(base.GetCppThis());
		}

		// Token: 0x0601A077 RID: 106615
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTubeFilter_GetVaryRadiusAsString_32(HandleRef pThis);

		/// <summary>
		/// Turn on/off the variation of tube radius with scalar value.
		/// </summary>
		// Token: 0x0601A078 RID: 106616 RVA: 0x002417D4 File Offset: 0x0023F9D4
		public string GetVaryRadiusAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkTubeFilter.vtkTubeFilter_GetVaryRadiusAsString_32(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601A079 RID: 106617
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetVaryRadiusMaxValue_33(HandleRef pThis);

		/// <summary>
		/// Turn on/off the variation of tube radius with scalar value.
		/// </summary>
		// Token: 0x0601A07A RID: 106618 RVA: 0x00241810 File Offset: 0x0023FA10
		public virtual int GetVaryRadiusMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetVaryRadiusMaxValue_33(base.GetCppThis());
		}

		// Token: 0x0601A07B RID: 106619
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_GetVaryRadiusMinValue_34(HandleRef pThis);

		/// <summary>
		/// Turn on/off the variation of tube radius with scalar value.
		/// </summary>
		// Token: 0x0601A07C RID: 106620 RVA: 0x00241830 File Offset: 0x0023FA30
		public virtual int GetVaryRadiusMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetVaryRadiusMinValue_34(base.GetCppThis());
		}

		// Token: 0x0601A07D RID: 106621
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A07E RID: 106622 RVA: 0x00241850 File Offset: 0x0023FA50
		public override int IsA(string type)
		{
			return vtkTubeFilter.vtkTubeFilter_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x0601A07F RID: 106623
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeFilter_IsTypeOf_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A080 RID: 106624 RVA: 0x00241870 File Offset: 0x0023FA70
		public new static int IsTypeOf(string type)
		{
			return vtkTubeFilter.vtkTubeFilter_IsTypeOf_36(type);
		}

		// Token: 0x0601A081 RID: 106625
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTubeFilter_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A082 RID: 106626 RVA: 0x0024188C File Offset: 0x0023FA8C
		public new vtkTubeFilter NewInstance()
		{
			vtkTubeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTubeFilter.vtkTubeFilter_NewInstance_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTubeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A083 RID: 106627
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTubeFilter_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A084 RID: 106628 RVA: 0x002418E8 File Offset: 0x0023FAE8
		public new static vtkTubeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTubeFilter vtkTubeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTubeFilter.vtkTubeFilter_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTubeFilter = (vtkTubeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTubeFilter.Register(null);
				}
			}
			return vtkTubeFilter;
		}

		// Token: 0x0601A085 RID: 106629
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetCapping_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off whether to cap the ends with polygons. Initial value is off.
		/// </summary>
		// Token: 0x0601A086 RID: 106630 RVA: 0x00241967 File Offset: 0x0023FB67
		public virtual void SetCapping(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetCapping_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A087 RID: 106631
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetDefaultNormal_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the default normal to use if no normals are supplied, and the
		/// DefaultNormalOn is set.
		/// </summary>
		// Token: 0x0601A088 RID: 106632 RVA: 0x00241977 File Offset: 0x0023FB77
		public virtual void SetDefaultNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkTubeFilter.vtkTubeFilter_SetDefaultNormal_41(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601A089 RID: 106633
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetDefaultNormal_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the default normal to use if no normals are supplied, and the
		/// DefaultNormalOn is set.
		/// </summary>
		// Token: 0x0601A08A RID: 106634 RVA: 0x00241989 File Offset: 0x0023FB89
		public virtual void SetDefaultNormal(IntPtr _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetDefaultNormal_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A08B RID: 106635
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetGenerateTCoords_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the tube with length textures, etc. If you
		/// use scalars to create the texture, the scalars are assumed to be
		/// monotonically increasing (or decreasing).
		/// </summary>
		// Token: 0x0601A08C RID: 106636 RVA: 0x00241999 File Offset: 0x0023FB99
		public virtual void SetGenerateTCoords(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetGenerateTCoords_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A08D RID: 106637
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetGenerateTCoordsToNormalizedLength_44(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the tube with length textures, etc. If you
		/// use scalars to create the texture, the scalars are assumed to be
		/// monotonically increasing (or decreasing).
		/// </summary>
		// Token: 0x0601A08E RID: 106638 RVA: 0x002419A9 File Offset: 0x0023FBA9
		public void SetGenerateTCoordsToNormalizedLength()
		{
			vtkTubeFilter.vtkTubeFilter_SetGenerateTCoordsToNormalizedLength_44(base.GetCppThis());
		}

		// Token: 0x0601A08F RID: 106639
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetGenerateTCoordsToOff_45(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the tube with length textures, etc. If you
		/// use scalars to create the texture, the scalars are assumed to be
		/// monotonically increasing (or decreasing).
		/// </summary>
		// Token: 0x0601A090 RID: 106640 RVA: 0x002419B8 File Offset: 0x0023FBB8
		public void SetGenerateTCoordsToOff()
		{
			vtkTubeFilter.vtkTubeFilter_SetGenerateTCoordsToOff_45(base.GetCppThis());
		}

		// Token: 0x0601A091 RID: 106641
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetGenerateTCoordsToUseLength_46(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the tube with length textures, etc. If you
		/// use scalars to create the texture, the scalars are assumed to be
		/// monotonically increasing (or decreasing).
		/// </summary>
		// Token: 0x0601A092 RID: 106642 RVA: 0x002419C7 File Offset: 0x0023FBC7
		public void SetGenerateTCoordsToUseLength()
		{
			vtkTubeFilter.vtkTubeFilter_SetGenerateTCoordsToUseLength_46(base.GetCppThis());
		}

		// Token: 0x0601A093 RID: 106643
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetGenerateTCoordsToUseScalars_47(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the tube with length textures, etc. If you
		/// use scalars to create the texture, the scalars are assumed to be
		/// monotonically increasing (or decreasing).
		/// </summary>
		// Token: 0x0601A094 RID: 106644 RVA: 0x002419D6 File Offset: 0x0023FBD6
		public void SetGenerateTCoordsToUseScalars()
		{
			vtkTubeFilter.vtkTubeFilter_SetGenerateTCoordsToUseScalars_47(base.GetCppThis());
		}

		// Token: 0x0601A095 RID: 106645
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetNumberOfSides_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of sides for the tube. At a minimum, number of sides is 3.
		/// </summary>
		// Token: 0x0601A096 RID: 106646 RVA: 0x002419E5 File Offset: 0x0023FBE5
		public virtual void SetNumberOfSides(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetNumberOfSides_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A097 RID: 106647
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetOffset_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the striping of the tubes. The offset sets the
		/// first tube side that is visible. Offset is generally used with
		/// OnRatio to create nifty striping effects.
		/// </summary>
		// Token: 0x0601A098 RID: 106648 RVA: 0x002419F5 File Offset: 0x0023FBF5
		public virtual void SetOffset(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetOffset_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A099 RID: 106649
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetOnRatio_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the striping of the tubes. If OnRatio is greater than 1,
		/// then every nth tube side is turned on, beginning with the Offset
		/// side.
		/// </summary>
		// Token: 0x0601A09A RID: 106650 RVA: 0x00241A05 File Offset: 0x0023FC05
		public virtual void SetOnRatio(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetOnRatio_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A09B RID: 106651
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetOutputPointsPrecision_51(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0601A09C RID: 106652 RVA: 0x00241A15 File Offset: 0x0023FC15
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetOutputPointsPrecision_51(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A09D RID: 106653
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetRadius_52(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the minimum tube radius (minimum because the tube radius may vary).
		/// </summary>
		// Token: 0x0601A09E RID: 106654 RVA: 0x00241A25 File Offset: 0x0023FC25
		public virtual void SetRadius(double _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetRadius_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A09F RID: 106655
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetRadiusFactor_53(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the maximum tube radius in terms of a multiple of the minimum radius.
		/// </summary>
		// Token: 0x0601A0A0 RID: 106656 RVA: 0x00241A35 File Offset: 0x0023FC35
		public virtual void SetRadiusFactor(double _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetRadiusFactor_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0A1 RID: 106657
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetSidesShareVertices_54(HandleRef pThis, int _arg);

		/// <summary>
		/// Set a boolean to control whether tube sides should share vertices.
		/// This creates independent strips, with constant normals so the
		/// tube is always faceted in appearance.
		/// </summary>
		// Token: 0x0601A0A2 RID: 106658 RVA: 0x00241A45 File Offset: 0x0023FC45
		public virtual void SetSidesShareVertices(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetSidesShareVertices_54(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0A3 RID: 106659
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetTextureLength_55(HandleRef pThis, double _arg);

		/// <summary>
		/// Control the conversion of units during the texture coordinates
		/// calculation. The TextureLength indicates what length (whether
		/// calculated from scalars or length) is mapped to the [0,1)
		/// texture space.
		/// </summary>
		// Token: 0x0601A0A4 RID: 106660 RVA: 0x00241A55 File Offset: 0x0023FC55
		public virtual void SetTextureLength(double _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetTextureLength_55(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0A5 RID: 106661
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetUseDefaultNormal_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Set a boolean to control whether to use default normals.
		/// DefaultNormalOn is set.
		/// </summary>
		// Token: 0x0601A0A6 RID: 106662 RVA: 0x00241A65 File Offset: 0x0023FC65
		public virtual void SetUseDefaultNormal(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetUseDefaultNormal_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0A7 RID: 106663
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetVaryRadius_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the variation of tube radius with scalar value.
		/// </summary>
		// Token: 0x0601A0A8 RID: 106664 RVA: 0x00241A75 File Offset: 0x0023FC75
		public virtual void SetVaryRadius(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetVaryRadius_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0A9 RID: 106665
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusByAbsoluteScalar_58(HandleRef pThis);

		/// <summary>
		/// Turn on/off the variation of tube radius with scalar value.
		/// </summary>
		// Token: 0x0601A0AA RID: 106666 RVA: 0x00241A85 File Offset: 0x0023FC85
		public void SetVaryRadiusToVaryRadiusByAbsoluteScalar()
		{
			vtkTubeFilter.vtkTubeFilter_SetVaryRadiusToVaryRadiusByAbsoluteScalar_58(base.GetCppThis());
		}

		// Token: 0x0601A0AB RID: 106667
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusByScalar_59(HandleRef pThis);

		/// <summary>
		/// Turn on/off the variation of tube radius with scalar value.
		/// </summary>
		// Token: 0x0601A0AC RID: 106668 RVA: 0x00241A94 File Offset: 0x0023FC94
		public void SetVaryRadiusToVaryRadiusByScalar()
		{
			vtkTubeFilter.vtkTubeFilter_SetVaryRadiusToVaryRadiusByScalar_59(base.GetCppThis());
		}

		// Token: 0x0601A0AD RID: 106669
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusByVector_60(HandleRef pThis);

		/// <summary>
		/// Turn on/off the variation of tube radius with scalar value.
		/// </summary>
		// Token: 0x0601A0AE RID: 106670 RVA: 0x00241AA3 File Offset: 0x0023FCA3
		public void SetVaryRadiusToVaryRadiusByVector()
		{
			vtkTubeFilter.vtkTubeFilter_SetVaryRadiusToVaryRadiusByVector_60(base.GetCppThis());
		}

		// Token: 0x0601A0AF RID: 106671
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusByVectorNorm_61(HandleRef pThis);

		/// <summary>
		/// Turn on/off the variation of tube radius with scalar value.
		/// </summary>
		// Token: 0x0601A0B0 RID: 106672 RVA: 0x00241AB2 File Offset: 0x0023FCB2
		public void SetVaryRadiusToVaryRadiusByVectorNorm()
		{
			vtkTubeFilter.vtkTubeFilter_SetVaryRadiusToVaryRadiusByVectorNorm_61(base.GetCppThis());
		}

		// Token: 0x0601A0B1 RID: 106673
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusOff_62(HandleRef pThis);

		/// <summary>
		/// Turn on/off the variation of tube radius with scalar value.
		/// </summary>
		// Token: 0x0601A0B2 RID: 106674 RVA: 0x00241AC1 File Offset: 0x0023FCC1
		public void SetVaryRadiusToVaryRadiusOff()
		{
			vtkTubeFilter.vtkTubeFilter_SetVaryRadiusToVaryRadiusOff_62(base.GetCppThis());
		}

		// Token: 0x0601A0B3 RID: 106675
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SidesShareVerticesOff_63(HandleRef pThis);

		/// <summary>
		/// Set a boolean to control whether tube sides should share vertices.
		/// This creates independent strips, with constant normals so the
		/// tube is always faceted in appearance.
		/// </summary>
		// Token: 0x0601A0B4 RID: 106676 RVA: 0x00241AD0 File Offset: 0x0023FCD0
		public virtual void SidesShareVerticesOff()
		{
			vtkTubeFilter.vtkTubeFilter_SidesShareVerticesOff_63(base.GetCppThis());
		}

		// Token: 0x0601A0B5 RID: 106677
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_SidesShareVerticesOn_64(HandleRef pThis);

		/// <summary>
		/// Set a boolean to control whether tube sides should share vertices.
		/// This creates independent strips, with constant normals so the
		/// tube is always faceted in appearance.
		/// </summary>
		// Token: 0x0601A0B6 RID: 106678 RVA: 0x00241ADF File Offset: 0x0023FCDF
		public virtual void SidesShareVerticesOn()
		{
			vtkTubeFilter.vtkTubeFilter_SidesShareVerticesOn_64(base.GetCppThis());
		}

		// Token: 0x0601A0B7 RID: 106679
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_UseDefaultNormalOff_65(HandleRef pThis);

		/// <summary>
		/// Set a boolean to control whether to use default normals.
		/// DefaultNormalOn is set.
		/// </summary>
		// Token: 0x0601A0B8 RID: 106680 RVA: 0x00241AEE File Offset: 0x0023FCEE
		public virtual void UseDefaultNormalOff()
		{
			vtkTubeFilter.vtkTubeFilter_UseDefaultNormalOff_65(base.GetCppThis());
		}

		// Token: 0x0601A0B9 RID: 106681
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeFilter_UseDefaultNormalOn_66(HandleRef pThis);

		/// <summary>
		/// Set a boolean to control whether to use default normals.
		/// DefaultNormalOn is set.
		/// </summary>
		// Token: 0x0601A0BA RID: 106682 RVA: 0x00241AFD File Offset: 0x0023FCFD
		public virtual void UseDefaultNormalOn()
		{
			vtkTubeFilter.vtkTubeFilter_UseDefaultNormalOn_66(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C3C RID: 7228
		public new const string MRFullTypeName = "Kitware.VTK.vtkTubeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C3D RID: 7229
		public new static readonly string MRClassNameKey = "class vtkTubeFilter";
	}
}
