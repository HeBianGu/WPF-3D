using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGlyphSource2D
	/// </summary>
	/// <remarks>
	///    create 2D glyphs represented by vtkPolyData
	///
	/// vtkGlyphSource2D can generate a family of 2D glyphs each of which lies
	/// in the x-y plane (i.e., the z-coordinate is zero). The class is a helper
	/// class to be used with vtkGlyph2D and vtkXYPlotActor.
	///
	/// To use this class, specify the glyph type to use and its
	/// attributes. Attributes include its position (i.e., center point), scale,
	/// color, and whether the symbol is filled or not (a polygon or closed line
	/// sequence). You can also put a short line through the glyph running from -x
	/// to +x (the glyph looks like it's on a line), or a cross.
	///
	/// The simple arrow can also be double pointed and point inwards.
	/// </remarks>
	// Token: 0x0200082B RID: 2091
	public class vtkGlyphSource2D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060159AE RID: 88494 RVA: 0x001E85A5 File Offset: 0x001E67A5
		static vtkGlyphSource2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGlyphSource2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlyphSource2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060159AF RID: 88495 RVA: 0x001E85CD File Offset: 0x001E67CD
		public vtkGlyphSource2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060159B0 RID: 88496
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyphSource2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vertex glyph centered at the origin, scale 1.0, white in
		/// color, filled, with line segment passing through the point.
		/// </summary>
		// Token: 0x060159B1 RID: 88497 RVA: 0x001E85DC File Offset: 0x001E67DC
		public new static vtkGlyphSource2D New()
		{
			vtkGlyphSource2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyphSource2D.vtkGlyphSource2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vertex glyph centered at the origin, scale 1.0, white in
		/// color, filled, with line segment passing through the point.
		/// </summary>
		// Token: 0x060159B2 RID: 88498 RVA: 0x001E8630 File Offset: 0x001E6830
		public vtkGlyphSource2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGlyphSource2D.vtkGlyphSource2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060159B3 RID: 88499 RVA: 0x001E8674 File Offset: 0x001E6874
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060159B4 RID: 88500
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_CrossOff_01(HandleRef pThis);

		/// <summary>
		/// Specify whether a cross is drawn as part of the glyph. (This
		/// is in addition to the glyph. If the glyph type is set to
		/// "Cross" there is no need to enable this flag.)
		/// </summary>
		// Token: 0x060159B5 RID: 88501 RVA: 0x001E867F File Offset: 0x001E687F
		public virtual void CrossOff()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_CrossOff_01(base.GetCppThis());
		}

		// Token: 0x060159B6 RID: 88502
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_CrossOn_02(HandleRef pThis);

		/// <summary>
		/// Specify whether a cross is drawn as part of the glyph. (This
		/// is in addition to the glyph. If the glyph type is set to
		/// "Cross" there is no need to enable this flag.)
		/// </summary>
		// Token: 0x060159B7 RID: 88503 RVA: 0x001E868E File Offset: 0x001E688E
		public virtual void CrossOn()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_CrossOn_02(base.GetCppThis());
		}

		// Token: 0x060159B8 RID: 88504
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_DashOff_03(HandleRef pThis);

		/// <summary>
		/// Specify whether a short line segment is drawn through the
		/// glyph. (This is in addition to the glyph. If the glyph type
		/// is set to "Dash" there is no need to enable this flag.)
		/// </summary>
		// Token: 0x060159B9 RID: 88505 RVA: 0x001E869D File Offset: 0x001E689D
		public virtual void DashOff()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_DashOff_03(base.GetCppThis());
		}

		// Token: 0x060159BA RID: 88506
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_DashOn_04(HandleRef pThis);

		/// <summary>
		/// Specify whether a short line segment is drawn through the
		/// glyph. (This is in addition to the glyph. If the glyph type
		/// is set to "Dash" there is no need to enable this flag.)
		/// </summary>
		// Token: 0x060159BB RID: 88507 RVA: 0x001E86AC File Offset: 0x001E68AC
		public virtual void DashOn()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_DashOn_04(base.GetCppThis());
		}

		// Token: 0x060159BC RID: 88508
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_DoublePointedOff_05(HandleRef pThis);

		/// <summary>
		/// Specify whether the arrow glyph should have two opposite tips.
		/// Only applicable for VTK_ARROW_GLYPH.
		/// Default is false.
		/// </summary>
		// Token: 0x060159BD RID: 88509 RVA: 0x001E86BB File Offset: 0x001E68BB
		public virtual void DoublePointedOff()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_DoublePointedOff_05(base.GetCppThis());
		}

		// Token: 0x060159BE RID: 88510
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_DoublePointedOn_06(HandleRef pThis);

		/// <summary>
		/// Specify whether the arrow glyph should have two opposite tips.
		/// Only applicable for VTK_ARROW_GLYPH.
		/// Default is false.
		/// </summary>
		// Token: 0x060159BF RID: 88511 RVA: 0x001E86CA File Offset: 0x001E68CA
		public virtual void DoublePointedOn()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_DoublePointedOn_06(base.GetCppThis());
		}

		// Token: 0x060159C0 RID: 88512
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_FilledOff_07(HandleRef pThis);

		/// <summary>
		/// Specify whether the glyph is filled (a polygon) or not (a
		/// closed polygon defined by line segments). This only applies
		/// to 2D closed glyphs.
		/// </summary>
		// Token: 0x060159C1 RID: 88513 RVA: 0x001E86D9 File Offset: 0x001E68D9
		public virtual void FilledOff()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_FilledOff_07(base.GetCppThis());
		}

		// Token: 0x060159C2 RID: 88514
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_FilledOn_08(HandleRef pThis);

		/// <summary>
		/// Specify whether the glyph is filled (a polygon) or not (a
		/// closed polygon defined by line segments). This only applies
		/// to 2D closed glyphs.
		/// </summary>
		// Token: 0x060159C3 RID: 88515 RVA: 0x001E86E8 File Offset: 0x001E68E8
		public virtual void FilledOn()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_FilledOn_08(base.GetCppThis());
		}

		// Token: 0x060159C4 RID: 88516
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyphSource2D_GetCenter_09(HandleRef pThis);

		/// <summary>
		/// Set the center of the glyph. By default the center is (0,0,0).
		/// </summary>
		// Token: 0x060159C5 RID: 88517 RVA: 0x001E86F8 File Offset: 0x001E68F8
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkGlyphSource2D.vtkGlyphSource2D_GetCenter_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060159C6 RID: 88518
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_GetCenter_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the center of the glyph. By default the center is (0,0,0).
		/// </summary>
		// Token: 0x060159C7 RID: 88519 RVA: 0x001E8740 File Offset: 0x001E6940
		public virtual void GetCenter(IntPtr data)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_GetCenter_10(base.GetCppThis(), data);
		}

		// Token: 0x060159C8 RID: 88520
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyphSource2D_GetColor_11(HandleRef pThis);

		/// <summary>
		/// Set the color of the glyph. The default color is white.
		/// </summary>
		// Token: 0x060159C9 RID: 88521 RVA: 0x001E8750 File Offset: 0x001E6950
		public virtual double[] GetColor()
		{
			IntPtr intPtr = vtkGlyphSource2D.vtkGlyphSource2D_GetColor_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060159CA RID: 88522
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_GetColor_12(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the color of the glyph. The default color is white.
		/// </summary>
		// Token: 0x060159CB RID: 88523 RVA: 0x001E8798 File Offset: 0x001E6998
		public virtual void GetColor(IntPtr data)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_GetColor_12(base.GetCppThis(), data);
		}

		// Token: 0x060159CC RID: 88524
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyphSource2D_GetCross_13(HandleRef pThis);

		/// <summary>
		/// Specify whether a cross is drawn as part of the glyph. (This
		/// is in addition to the glyph. If the glyph type is set to
		/// "Cross" there is no need to enable this flag.)
		/// </summary>
		// Token: 0x060159CD RID: 88525 RVA: 0x001E87A8 File Offset: 0x001E69A8
		public virtual int GetCross()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetCross_13(base.GetCppThis());
		}

		// Token: 0x060159CE RID: 88526
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyphSource2D_GetDash_14(HandleRef pThis);

		/// <summary>
		/// Specify whether a short line segment is drawn through the
		/// glyph. (This is in addition to the glyph. If the glyph type
		/// is set to "Dash" there is no need to enable this flag.)
		/// </summary>
		// Token: 0x060159CF RID: 88527 RVA: 0x001E87C8 File Offset: 0x001E69C8
		public virtual int GetDash()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetDash_14(base.GetCppThis());
		}

		// Token: 0x060159D0 RID: 88528
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGlyphSource2D_GetDoublePointed_15(HandleRef pThis);

		/// <summary>
		/// Specify whether the arrow glyph should have two opposite tips.
		/// Only applicable for VTK_ARROW_GLYPH.
		/// Default is false.
		/// </summary>
		// Token: 0x060159D1 RID: 88529 RVA: 0x001E87E8 File Offset: 0x001E69E8
		public virtual bool GetDoublePointed()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetDoublePointed_15(base.GetCppThis()) != 0;
		}

		// Token: 0x060159D2 RID: 88530
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyphSource2D_GetFilled_16(HandleRef pThis);

		/// <summary>
		/// Specify whether the glyph is filled (a polygon) or not (a
		/// closed polygon defined by line segments). This only applies
		/// to 2D closed glyphs.
		/// </summary>
		// Token: 0x060159D3 RID: 88531 RVA: 0x001E8810 File Offset: 0x001E6A10
		public virtual int GetFilled()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetFilled_16(base.GetCppThis());
		}

		// Token: 0x060159D4 RID: 88532
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyphSource2D_GetGlyphType_17(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x060159D5 RID: 88533 RVA: 0x001E8830 File Offset: 0x001E6A30
		public virtual int GetGlyphType()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetGlyphType_17(base.GetCppThis());
		}

		// Token: 0x060159D6 RID: 88534
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyphSource2D_GetGlyphTypeMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x060159D7 RID: 88535 RVA: 0x001E8850 File Offset: 0x001E6A50
		public virtual int GetGlyphTypeMaxValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetGlyphTypeMaxValue_18(base.GetCppThis());
		}

		// Token: 0x060159D8 RID: 88536
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyphSource2D_GetGlyphTypeMinValue_19(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x060159D9 RID: 88537 RVA: 0x001E8870 File Offset: 0x001E6A70
		public virtual int GetGlyphTypeMinValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetGlyphTypeMinValue_19(base.GetCppThis());
		}

		// Token: 0x060159DA RID: 88538
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGlyphSource2D_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060159DB RID: 88539 RVA: 0x001E8890 File Offset: 0x001E6A90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x060159DC RID: 88540
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGlyphSource2D_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060159DD RID: 88541 RVA: 0x001E88B0 File Offset: 0x001E6AB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x060159DE RID: 88542
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyphSource2D_GetOutputPointsPrecision_22(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x060159DF RID: 88543 RVA: 0x001E88CC File Offset: 0x001E6ACC
		public virtual int GetOutputPointsPrecision()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetOutputPointsPrecision_22(base.GetCppThis());
		}

		// Token: 0x060159E0 RID: 88544
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGlyphSource2D_GetPointInwards_23(HandleRef pThis);

		/// <summary>
		/// Specify whether the arrow glyph should have its tip(s) pointing inwards.
		/// Only applicable for VTK_ARROW_GLYPH.
		/// Default is false.
		/// </summary>
		// Token: 0x060159E1 RID: 88545 RVA: 0x001E88EC File Offset: 0x001E6AEC
		public virtual bool GetPointInwards()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetPointInwards_23(base.GetCppThis()) != 0;
		}

		// Token: 0x060159E2 RID: 88546
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyphSource2D_GetResolution_24(HandleRef pThis);

		/// <summary>
		/// Specify the number of points that form the circular glyph.
		/// </summary>
		// Token: 0x060159E3 RID: 88547 RVA: 0x001E8914 File Offset: 0x001E6B14
		public virtual int GetResolution()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetResolution_24(base.GetCppThis());
		}

		// Token: 0x060159E4 RID: 88548
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyphSource2D_GetResolutionMaxValue_25(HandleRef pThis);

		/// <summary>
		/// Specify the number of points that form the circular glyph.
		/// </summary>
		// Token: 0x060159E5 RID: 88549 RVA: 0x001E8934 File Offset: 0x001E6B34
		public virtual int GetResolutionMaxValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetResolutionMaxValue_25(base.GetCppThis());
		}

		// Token: 0x060159E6 RID: 88550
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyphSource2D_GetResolutionMinValue_26(HandleRef pThis);

		/// <summary>
		/// Specify the number of points that form the circular glyph.
		/// </summary>
		// Token: 0x060159E7 RID: 88551 RVA: 0x001E8954 File Offset: 0x001E6B54
		public virtual int GetResolutionMinValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetResolutionMinValue_26(base.GetCppThis());
		}

		// Token: 0x060159E8 RID: 88552
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGlyphSource2D_GetRotationAngle_27(HandleRef pThis);

		/// <summary>
		/// Specify an angle (in degrees) to rotate the glyph around
		/// the z-axis. Using this ivar, it is possible to generate
		/// rotated glyphs (e.g., crosses, arrows, etc.)
		/// </summary>
		// Token: 0x060159E9 RID: 88553 RVA: 0x001E8974 File Offset: 0x001E6B74
		public virtual double GetRotationAngle()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetRotationAngle_27(base.GetCppThis());
		}

		// Token: 0x060159EA RID: 88554
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGlyphSource2D_GetScale_28(HandleRef pThis);

		/// <summary>
		/// Set the scale of the glyph. Note that the glyphs are designed
		/// to fit in the (1,1) rectangle.
		/// </summary>
		// Token: 0x060159EB RID: 88555 RVA: 0x001E8994 File Offset: 0x001E6B94
		public virtual double GetScale()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetScale_28(base.GetCppThis());
		}

		// Token: 0x060159EC RID: 88556
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGlyphSource2D_GetScale2_29(HandleRef pThis);

		/// <summary>
		/// Set the scale of optional portions of the glyph (e.g., the
		/// dash and cross is DashOn() and CrossOn()).
		/// </summary>
		// Token: 0x060159ED RID: 88557 RVA: 0x001E89B4 File Offset: 0x001E6BB4
		public virtual double GetScale2()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetScale2_29(base.GetCppThis());
		}

		// Token: 0x060159EE RID: 88558
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGlyphSource2D_GetScale2MaxValue_30(HandleRef pThis);

		/// <summary>
		/// Set the scale of optional portions of the glyph (e.g., the
		/// dash and cross is DashOn() and CrossOn()).
		/// </summary>
		// Token: 0x060159EF RID: 88559 RVA: 0x001E89D4 File Offset: 0x001E6BD4
		public virtual double GetScale2MaxValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetScale2MaxValue_30(base.GetCppThis());
		}

		// Token: 0x060159F0 RID: 88560
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGlyphSource2D_GetScale2MinValue_31(HandleRef pThis);

		/// <summary>
		/// Set the scale of optional portions of the glyph (e.g., the
		/// dash and cross is DashOn() and CrossOn()).
		/// </summary>
		// Token: 0x060159F1 RID: 88561 RVA: 0x001E89F4 File Offset: 0x001E6BF4
		public virtual double GetScale2MinValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetScale2MinValue_31(base.GetCppThis());
		}

		// Token: 0x060159F2 RID: 88562
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGlyphSource2D_GetScaleMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Set the scale of the glyph. Note that the glyphs are designed
		/// to fit in the (1,1) rectangle.
		/// </summary>
		// Token: 0x060159F3 RID: 88563 RVA: 0x001E8A14 File Offset: 0x001E6C14
		public virtual double GetScaleMaxValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetScaleMaxValue_32(base.GetCppThis());
		}

		// Token: 0x060159F4 RID: 88564
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGlyphSource2D_GetScaleMinValue_33(HandleRef pThis);

		/// <summary>
		/// Set the scale of the glyph. Note that the glyphs are designed
		/// to fit in the (1,1) rectangle.
		/// </summary>
		// Token: 0x060159F5 RID: 88565 RVA: 0x001E8A34 File Offset: 0x001E6C34
		public virtual double GetScaleMinValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetScaleMinValue_33(base.GetCppThis());
		}

		// Token: 0x060159F6 RID: 88566
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGlyphSource2D_GetTipLength_34(HandleRef pThis);

		/// <summary>
		/// Set/get the length of the tip(s) for VTK_ARROW_GLYPH.
		/// If DoublePointed is on, the length is capped at 0.5.
		/// Default is 0.3.
		/// </summary>
		// Token: 0x060159F7 RID: 88567 RVA: 0x001E8A54 File Offset: 0x001E6C54
		public virtual double GetTipLength()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetTipLength_34(base.GetCppThis());
		}

		// Token: 0x060159F8 RID: 88568
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGlyphSource2D_GetTipLengthMaxValue_35(HandleRef pThis);

		/// <summary>
		/// Set/get the length of the tip(s) for VTK_ARROW_GLYPH.
		/// If DoublePointed is on, the length is capped at 0.5.
		/// Default is 0.3.
		/// </summary>
		// Token: 0x060159F9 RID: 88569 RVA: 0x001E8A74 File Offset: 0x001E6C74
		public virtual double GetTipLengthMaxValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetTipLengthMaxValue_35(base.GetCppThis());
		}

		// Token: 0x060159FA RID: 88570
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGlyphSource2D_GetTipLengthMinValue_36(HandleRef pThis);

		/// <summary>
		/// Set/get the length of the tip(s) for VTK_ARROW_GLYPH.
		/// If DoublePointed is on, the length is capped at 0.5.
		/// Default is 0.3.
		/// </summary>
		// Token: 0x060159FB RID: 88571 RVA: 0x001E8A94 File Offset: 0x001E6C94
		public virtual double GetTipLengthMinValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetTipLengthMinValue_36(base.GetCppThis());
		}

		// Token: 0x060159FC RID: 88572
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyphSource2D_IsA_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060159FD RID: 88573 RVA: 0x001E8AB4 File Offset: 0x001E6CB4
		public override int IsA(string type)
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_IsA_37(base.GetCppThis(), type);
		}

		// Token: 0x060159FE RID: 88574
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyphSource2D_IsTypeOf_38([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060159FF RID: 88575 RVA: 0x001E8AD4 File Offset: 0x001E6CD4
		public new static int IsTypeOf(string type)
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_IsTypeOf_38(type);
		}

		// Token: 0x06015A00 RID: 88576
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyphSource2D_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015A01 RID: 88577 RVA: 0x001E8AF0 File Offset: 0x001E6CF0
		public new vtkGlyphSource2D NewInstance()
		{
			vtkGlyphSource2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyphSource2D.vtkGlyphSource2D_NewInstance_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015A02 RID: 88578
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_PointInwardsOff_41(HandleRef pThis);

		/// <summary>
		/// Specify whether the arrow glyph should have its tip(s) pointing inwards.
		/// Only applicable for VTK_ARROW_GLYPH.
		/// Default is false.
		/// </summary>
		// Token: 0x06015A03 RID: 88579 RVA: 0x001E8B4A File Offset: 0x001E6D4A
		public virtual void PointInwardsOff()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_PointInwardsOff_41(base.GetCppThis());
		}

		// Token: 0x06015A04 RID: 88580
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_PointInwardsOn_42(HandleRef pThis);

		/// <summary>
		/// Specify whether the arrow glyph should have its tip(s) pointing inwards.
		/// Only applicable for VTK_ARROW_GLYPH.
		/// Default is false.
		/// </summary>
		// Token: 0x06015A05 RID: 88581 RVA: 0x001E8B59 File Offset: 0x001E6D59
		public virtual void PointInwardsOn()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_PointInwardsOn_42(base.GetCppThis());
		}

		// Token: 0x06015A06 RID: 88582
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyphSource2D_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015A07 RID: 88583 RVA: 0x001E8B68 File Offset: 0x001E6D68
		public new static vtkGlyphSource2D SafeDownCast(vtkObjectBase o)
		{
			vtkGlyphSource2D vtkGlyphSource2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyphSource2D.vtkGlyphSource2D_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlyphSource2D = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlyphSource2D.Register(null);
				}
			}
			return vtkGlyphSource2D;
		}

		// Token: 0x06015A08 RID: 88584
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetCenter_44(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the center of the glyph. By default the center is (0,0,0).
		/// </summary>
		// Token: 0x06015A09 RID: 88585 RVA: 0x001E8BE7 File Offset: 0x001E6DE7
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetCenter_44(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015A0A RID: 88586
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetCenter_45(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the center of the glyph. By default the center is (0,0,0).
		/// </summary>
		// Token: 0x06015A0B RID: 88587 RVA: 0x001E8BF9 File Offset: 0x001E6DF9
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetCenter_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06015A0C RID: 88588
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetColor_46(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the color of the glyph. The default color is white.
		/// </summary>
		// Token: 0x06015A0D RID: 88589 RVA: 0x001E8C09 File Offset: 0x001E6E09
		public virtual void SetColor(double _arg1, double _arg2, double _arg3)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetColor_46(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015A0E RID: 88590
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetColor_47(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color of the glyph. The default color is white.
		/// </summary>
		// Token: 0x06015A0F RID: 88591 RVA: 0x001E8C1B File Offset: 0x001E6E1B
		public virtual void SetColor(IntPtr _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetColor_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06015A10 RID: 88592
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetCross_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether a cross is drawn as part of the glyph. (This
		/// is in addition to the glyph. If the glyph type is set to
		/// "Cross" there is no need to enable this flag.)
		/// </summary>
		// Token: 0x06015A11 RID: 88593 RVA: 0x001E8C2B File Offset: 0x001E6E2B
		public virtual void SetCross(int _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetCross_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06015A12 RID: 88594
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetDash_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether a short line segment is drawn through the
		/// glyph. (This is in addition to the glyph. If the glyph type
		/// is set to "Dash" there is no need to enable this flag.)
		/// </summary>
		// Token: 0x06015A13 RID: 88595 RVA: 0x001E8C3B File Offset: 0x001E6E3B
		public virtual void SetDash(int _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetDash_49(base.GetCppThis(), _arg);
		}

		// Token: 0x06015A14 RID: 88596
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetDoublePointed_50(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether the arrow glyph should have two opposite tips.
		/// Only applicable for VTK_ARROW_GLYPH.
		/// Default is false.
		/// </summary>
		// Token: 0x06015A15 RID: 88597 RVA: 0x001E8C4B File Offset: 0x001E6E4B
		public virtual void SetDoublePointed(bool _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetDoublePointed_50(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06015A16 RID: 88598
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetFilled_51(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether the glyph is filled (a polygon) or not (a
		/// closed polygon defined by line segments). This only applies
		/// to 2D closed glyphs.
		/// </summary>
		// Token: 0x06015A17 RID: 88599 RVA: 0x001E8C63 File Offset: 0x001E6E63
		public virtual void SetFilled(int _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetFilled_51(base.GetCppThis(), _arg);
		}

		// Token: 0x06015A18 RID: 88600
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphType_52(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A19 RID: 88601 RVA: 0x001E8C73 File Offset: 0x001E6E73
		public virtual void SetGlyphType(int _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphType_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06015A1A RID: 88602
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToArrow_53(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A1B RID: 88603 RVA: 0x001E8C83 File Offset: 0x001E6E83
		public void SetGlyphTypeToArrow()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToArrow_53(base.GetCppThis());
		}

		// Token: 0x06015A1C RID: 88604
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToCircle_54(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A1D RID: 88605 RVA: 0x001E8C92 File Offset: 0x001E6E92
		public void SetGlyphTypeToCircle()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToCircle_54(base.GetCppThis());
		}

		// Token: 0x06015A1E RID: 88606
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToCross_55(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A1F RID: 88607 RVA: 0x001E8CA1 File Offset: 0x001E6EA1
		public void SetGlyphTypeToCross()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToCross_55(base.GetCppThis());
		}

		// Token: 0x06015A20 RID: 88608
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToDash_56(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A21 RID: 88609 RVA: 0x001E8CB0 File Offset: 0x001E6EB0
		public void SetGlyphTypeToDash()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToDash_56(base.GetCppThis());
		}

		// Token: 0x06015A22 RID: 88610
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToDiamond_57(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A23 RID: 88611 RVA: 0x001E8CBF File Offset: 0x001E6EBF
		public void SetGlyphTypeToDiamond()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToDiamond_57(base.GetCppThis());
		}

		// Token: 0x06015A24 RID: 88612
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToEdgeArrow_58(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A25 RID: 88613 RVA: 0x001E8CCE File Offset: 0x001E6ECE
		public void SetGlyphTypeToEdgeArrow()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToEdgeArrow_58(base.GetCppThis());
		}

		// Token: 0x06015A26 RID: 88614
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToHookedArrow_59(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A27 RID: 88615 RVA: 0x001E8CDD File Offset: 0x001E6EDD
		public void SetGlyphTypeToHookedArrow()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToHookedArrow_59(base.GetCppThis());
		}

		// Token: 0x06015A28 RID: 88616
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToNone_60(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A29 RID: 88617 RVA: 0x001E8CEC File Offset: 0x001E6EEC
		public void SetGlyphTypeToNone()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToNone_60(base.GetCppThis());
		}

		// Token: 0x06015A2A RID: 88618
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToSquare_61(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A2B RID: 88619 RVA: 0x001E8CFB File Offset: 0x001E6EFB
		public void SetGlyphTypeToSquare()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToSquare_61(base.GetCppThis());
		}

		// Token: 0x06015A2C RID: 88620
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToThickArrow_62(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A2D RID: 88621 RVA: 0x001E8D0A File Offset: 0x001E6F0A
		public void SetGlyphTypeToThickArrow()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToThickArrow_62(base.GetCppThis());
		}

		// Token: 0x06015A2E RID: 88622
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToThickCross_63(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A2F RID: 88623 RVA: 0x001E8D19 File Offset: 0x001E6F19
		public void SetGlyphTypeToThickCross()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToThickCross_63(base.GetCppThis());
		}

		// Token: 0x06015A30 RID: 88624
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToTriangle_64(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A31 RID: 88625 RVA: 0x001E8D28 File Offset: 0x001E6F28
		public void SetGlyphTypeToTriangle()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToTriangle_64(base.GetCppThis());
		}

		// Token: 0x06015A32 RID: 88626
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToVertex_65(HandleRef pThis);

		/// <summary>
		/// Specify the type of glyph to generate.
		/// </summary>
		// Token: 0x06015A33 RID: 88627 RVA: 0x001E8D37 File Offset: 0x001E6F37
		public void SetGlyphTypeToVertex()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToVertex_65(base.GetCppThis());
		}

		// Token: 0x06015A34 RID: 88628
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetOutputPointsPrecision_66(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015A35 RID: 88629 RVA: 0x001E8D46 File Offset: 0x001E6F46
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetOutputPointsPrecision_66(base.GetCppThis(), _arg);
		}

		// Token: 0x06015A36 RID: 88630
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetPointInwards_67(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether the arrow glyph should have its tip(s) pointing inwards.
		/// Only applicable for VTK_ARROW_GLYPH.
		/// Default is false.
		/// </summary>
		// Token: 0x06015A37 RID: 88631 RVA: 0x001E8D56 File Offset: 0x001E6F56
		public virtual void SetPointInwards(bool _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetPointInwards_67(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06015A38 RID: 88632
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetResolution_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of points that form the circular glyph.
		/// </summary>
		// Token: 0x06015A39 RID: 88633 RVA: 0x001E8D6E File Offset: 0x001E6F6E
		public virtual void SetResolution(int _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetResolution_68(base.GetCppThis(), _arg);
		}

		// Token: 0x06015A3A RID: 88634
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetRotationAngle_69(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify an angle (in degrees) to rotate the glyph around
		/// the z-axis. Using this ivar, it is possible to generate
		/// rotated glyphs (e.g., crosses, arrows, etc.)
		/// </summary>
		// Token: 0x06015A3B RID: 88635 RVA: 0x001E8D7E File Offset: 0x001E6F7E
		public virtual void SetRotationAngle(double _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetRotationAngle_69(base.GetCppThis(), _arg);
		}

		// Token: 0x06015A3C RID: 88636
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetScale_70(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the scale of the glyph. Note that the glyphs are designed
		/// to fit in the (1,1) rectangle.
		/// </summary>
		// Token: 0x06015A3D RID: 88637 RVA: 0x001E8D8E File Offset: 0x001E6F8E
		public virtual void SetScale(double _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetScale_70(base.GetCppThis(), _arg);
		}

		// Token: 0x06015A3E RID: 88638
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetScale2_71(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the scale of optional portions of the glyph (e.g., the
		/// dash and cross is DashOn() and CrossOn()).
		/// </summary>
		// Token: 0x06015A3F RID: 88639 RVA: 0x001E8D9E File Offset: 0x001E6F9E
		public virtual void SetScale2(double _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetScale2_71(base.GetCppThis(), _arg);
		}

		// Token: 0x06015A40 RID: 88640
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyphSource2D_SetTipLength_72(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the length of the tip(s) for VTK_ARROW_GLYPH.
		/// If DoublePointed is on, the length is capped at 0.5.
		/// Default is 0.3.
		/// </summary>
		// Token: 0x06015A41 RID: 88641 RVA: 0x001E8DAE File Offset: 0x001E6FAE
		public virtual void SetTipLength(double _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetTipLength_72(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018A0 RID: 6304
		public new const string MRFullTypeName = "Kitware.VTK.vtkGlyphSource2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018A1 RID: 6305
		public new static readonly string MRClassNameKey = "class vtkGlyphSource2D";
	}
}
