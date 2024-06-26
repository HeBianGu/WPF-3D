﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRuledSurfaceFilter
	/// </summary>
	/// <remarks>
	///    generates a surface from a set of lines
	///
	/// vtkRuledSurfaceFilter is a filter that generates a surface from a set of
	/// lines. The lines are assumed to be "parallel" in the sense that they do
	/// not intersect and remain somewhat close to one another. A surface is
	/// generated by connecting the points defining each pair of lines with
	/// straight lines. This creates a strip for each pair of lines (i.e., a
	/// triangulation is created from two generating lines). The filter can handle
	/// an arbitrary number of lines, with lines i and i+1 assumed connected.
	/// Note that there are several different approaches for creating the ruled
	/// surface, the method for creating the surface can either use the input
	/// points or resample from the polylines (using a user-specified resolution).
	///
	/// This filter offers some other important features. A DistanceFactor ivar is
	/// used to decide when two lines are too far apart to connect. (The factor is
	/// a multiple of the distance between the first two points of the two lines
	/// defining the strip.) If the distance between the two generating lines
	/// becomes too great, then the surface is not generated in that
	/// region. (Note: if the lines separate and then merge, then a hole can be
	/// generated in the surface.) In addition, the Offset and OnRation ivars can
	/// be used to create nifty striped surfaces. Closed surfaces (e.g., tubes) can
	/// be created by setting the CloseSurface ivar. (The surface can be closed
	/// in the other direction by repeating the first and last point in the
	/// polylines defining the surface.)
	///
	/// An important use of this filter is to combine it with vtkStreamTracer to
	/// generate stream surfaces. It can also be used to create surfaces from
	/// contours.
	///
	/// @warning
	/// The number of lines must be greater than two if a surface is to be
	/// generated.  sides (i.e., a ribbon), use vtkRibbonFilter.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRibbonFilter vtkStreamTracer
	/// </seealso>
	// Token: 0x0200056C RID: 1388
	public class vtkRuledSurfaceFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F5BA RID: 62906 RVA: 0x00155C61 File Offset: 0x00153E61
		static vtkRuledSurfaceFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRuledSurfaceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRuledSurfaceFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F5BB RID: 62907 RVA: 0x00155C89 File Offset: 0x00153E89
		public vtkRuledSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F5BC RID: 62908
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRuledSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with OnRatio=1, Offset=0. DistanceFactor=3.0,
		/// CloseSurface off, and PassLines off.
		/// </summary>
		// Token: 0x0600F5BD RID: 62909 RVA: 0x00155C98 File Offset: 0x00153E98
		public new static vtkRuledSurfaceFilter New()
		{
			vtkRuledSurfaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRuledSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with OnRatio=1, Offset=0. DistanceFactor=3.0,
		/// CloseSurface off, and PassLines off.
		/// </summary>
		// Token: 0x0600F5BE RID: 62910 RVA: 0x00155CEC File Offset: 0x00153EEC
		public vtkRuledSurfaceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F5BF RID: 62911 RVA: 0x00155D30 File Offset: 0x00153F30
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F5C0 RID: 62912
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_CloseSurfaceOff_01(HandleRef pThis);

		/// <summary>
		/// Indicate whether the surface is to be closed. If this boolean is
		/// on, then the first and last polyline are used to generate a stripe
		/// that closes the surface. (Note: to close the surface in the other
		/// direction, repeat the first point in the polyline as the last
		/// point in the polyline.)
		/// </summary>
		// Token: 0x0600F5C1 RID: 62913 RVA: 0x00155D3B File Offset: 0x00153F3B
		public virtual void CloseSurfaceOff()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_CloseSurfaceOff_01(base.GetCppThis());
		}

		// Token: 0x0600F5C2 RID: 62914
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_CloseSurfaceOn_02(HandleRef pThis);

		/// <summary>
		/// Indicate whether the surface is to be closed. If this boolean is
		/// on, then the first and last polyline are used to generate a stripe
		/// that closes the surface. (Note: to close the surface in the other
		/// direction, repeat the first point in the polyline as the last
		/// point in the polyline.)
		/// </summary>
		// Token: 0x0600F5C3 RID: 62915 RVA: 0x00155D4A File Offset: 0x00153F4A
		public virtual void CloseSurfaceOn()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_CloseSurfaceOn_02(base.GetCppThis());
		}

		// Token: 0x0600F5C4 RID: 62916
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_GetCloseSurface_03(HandleRef pThis);

		/// <summary>
		/// Indicate whether the surface is to be closed. If this boolean is
		/// on, then the first and last polyline are used to generate a stripe
		/// that closes the surface. (Note: to close the surface in the other
		/// direction, repeat the first point in the polyline as the last
		/// point in the polyline.)
		/// </summary>
		// Token: 0x0600F5C5 RID: 62917 RVA: 0x00155D5C File Offset: 0x00153F5C
		public virtual int GetCloseSurface()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetCloseSurface_03(base.GetCppThis());
		}

		// Token: 0x0600F5C6 RID: 62918
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRuledSurfaceFilter_GetDistanceFactor_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls tearing of the surface.
		/// </summary>
		// Token: 0x0600F5C7 RID: 62919 RVA: 0x00155D7C File Offset: 0x00153F7C
		public virtual double GetDistanceFactor()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetDistanceFactor_04(base.GetCppThis());
		}

		// Token: 0x0600F5C8 RID: 62920
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRuledSurfaceFilter_GetDistanceFactorMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls tearing of the surface.
		/// </summary>
		// Token: 0x0600F5C9 RID: 62921 RVA: 0x00155D9C File Offset: 0x00153F9C
		public virtual double GetDistanceFactorMaxValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetDistanceFactorMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600F5CA RID: 62922
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRuledSurfaceFilter_GetDistanceFactorMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls tearing of the surface.
		/// </summary>
		// Token: 0x0600F5CB RID: 62923 RVA: 0x00155DBC File Offset: 0x00153FBC
		public virtual double GetDistanceFactorMinValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetDistanceFactorMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600F5CC RID: 62924
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRuledSurfaceFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F5CD RID: 62925 RVA: 0x00155DDC File Offset: 0x00153FDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600F5CE RID: 62926
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRuledSurfaceFilter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F5CF RID: 62927 RVA: 0x00155DFC File Offset: 0x00153FFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600F5D0 RID: 62928
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_GetOffset_09(HandleRef pThis);

		/// <summary>
		/// Control the striping of the ruled surface. The offset sets the
		/// first stripe that is visible. Offset is generally used with
		/// OnRatio to create nifty striping effects.
		/// </summary>
		// Token: 0x0600F5D1 RID: 62929 RVA: 0x00155E18 File Offset: 0x00154018
		public virtual int GetOffset()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOffset_09(base.GetCppThis());
		}

		// Token: 0x0600F5D2 RID: 62930
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_GetOffsetMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Control the striping of the ruled surface. The offset sets the
		/// first stripe that is visible. Offset is generally used with
		/// OnRatio to create nifty striping effects.
		/// </summary>
		// Token: 0x0600F5D3 RID: 62931 RVA: 0x00155E38 File Offset: 0x00154038
		public virtual int GetOffsetMaxValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOffsetMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600F5D4 RID: 62932
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_GetOffsetMinValue_11(HandleRef pThis);

		/// <summary>
		/// Control the striping of the ruled surface. The offset sets the
		/// first stripe that is visible. Offset is generally used with
		/// OnRatio to create nifty striping effects.
		/// </summary>
		// Token: 0x0600F5D5 RID: 62933 RVA: 0x00155E58 File Offset: 0x00154058
		public virtual int GetOffsetMinValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOffsetMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600F5D6 RID: 62934
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_GetOnRatio_12(HandleRef pThis);

		/// <summary>
		/// Control the striping of the ruled surface. If OnRatio is greater
		/// than 1, then every nth strip is turned on, beginning with the Offset
		/// strip.
		/// </summary>
		// Token: 0x0600F5D7 RID: 62935 RVA: 0x00155E78 File Offset: 0x00154078
		public virtual int GetOnRatio()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOnRatio_12(base.GetCppThis());
		}

		// Token: 0x0600F5D8 RID: 62936
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_GetOnRatioMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Control the striping of the ruled surface. If OnRatio is greater
		/// than 1, then every nth strip is turned on, beginning with the Offset
		/// strip.
		/// </summary>
		// Token: 0x0600F5D9 RID: 62937 RVA: 0x00155E98 File Offset: 0x00154098
		public virtual int GetOnRatioMaxValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOnRatioMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0600F5DA RID: 62938
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_GetOnRatioMinValue_14(HandleRef pThis);

		/// <summary>
		/// Control the striping of the ruled surface. If OnRatio is greater
		/// than 1, then every nth strip is turned on, beginning with the Offset
		/// strip.
		/// </summary>
		// Token: 0x0600F5DB RID: 62939 RVA: 0x00155EB8 File Offset: 0x001540B8
		public virtual int GetOnRatioMinValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOnRatioMinValue_14(base.GetCppThis());
		}

		// Token: 0x0600F5DC RID: 62940
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_GetOrientLoops_15(HandleRef pThis);

		/// <summary>
		/// Indicate whether the starting points of the loops need to be determined.
		/// If set to 0, then its assumes that the 0th point of each loop should be
		/// always connected
		/// By default the loops are not oriented.
		/// </summary>
		// Token: 0x0600F5DD RID: 62941 RVA: 0x00155ED8 File Offset: 0x001540D8
		public virtual int GetOrientLoops()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOrientLoops_15(base.GetCppThis());
		}

		// Token: 0x0600F5DE RID: 62942
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_GetPassLines_16(HandleRef pThis);

		/// <summary>
		/// Indicate whether the generating lines are to be passed to the output.
		/// By default lines are not passed to the output.
		/// </summary>
		// Token: 0x0600F5DF RID: 62943 RVA: 0x00155EF8 File Offset: 0x001540F8
		public virtual int GetPassLines()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetPassLines_16(base.GetCppThis());
		}

		// Token: 0x0600F5E0 RID: 62944
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRuledSurfaceFilter_GetResolution_17(HandleRef pThis);

		/// <summary>
		/// If the ruled surface generation mode is RESAMPLE, then these parameters
		/// are used to determine the resample rate. Resolution[0] defines the
		/// resolution in the direction of the polylines; Resolution[1] defines
		/// the resolution across the polylines (i.e., direction orthogonal to
		/// Resolution[0]).
		/// </summary>
		// Token: 0x0600F5E1 RID: 62945 RVA: 0x00155F18 File Offset: 0x00154118
		public virtual int[] GetResolution()
		{
			IntPtr intPtr = vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetResolution_17(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F5E2 RID: 62946
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_GetResolution_18(HandleRef pThis, IntPtr data);

		/// <summary>
		/// If the ruled surface generation mode is RESAMPLE, then these parameters
		/// are used to determine the resample rate. Resolution[0] defines the
		/// resolution in the direction of the polylines; Resolution[1] defines
		/// the resolution across the polylines (i.e., direction orthogonal to
		/// Resolution[0]).
		/// </summary>
		// Token: 0x0600F5E3 RID: 62947 RVA: 0x00155F60 File Offset: 0x00154160
		public virtual void GetResolution(IntPtr data)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetResolution_18(base.GetCppThis(), data);
		}

		// Token: 0x0600F5E4 RID: 62948
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_GetRuledMode_19(HandleRef pThis);

		/// <summary>
		/// Set the mode by which to create the ruled surface. (Dramatically
		/// different results are possible depending on the chosen mode.) The
		/// resample mode evenly resamples the polylines (based on length) and
		/// generates triangle strips. The point walk mode uses the existing
		/// points and walks around the polyline using existing points.
		/// </summary>
		// Token: 0x0600F5E5 RID: 62949 RVA: 0x00155F70 File Offset: 0x00154170
		public virtual int GetRuledMode()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetRuledMode_19(base.GetCppThis());
		}

		// Token: 0x0600F5E6 RID: 62950
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRuledSurfaceFilter_GetRuledModeAsString_20(HandleRef pThis);

		/// <summary>
		/// Set the mode by which to create the ruled surface. (Dramatically
		/// different results are possible depending on the chosen mode.) The
		/// resample mode evenly resamples the polylines (based on length) and
		/// generates triangle strips. The point walk mode uses the existing
		/// points and walks around the polyline using existing points.
		/// </summary>
		// Token: 0x0600F5E7 RID: 62951 RVA: 0x00155F90 File Offset: 0x00154190
		public string GetRuledModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetRuledModeAsString_20(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600F5E8 RID: 62952
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_GetRuledModeMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Set the mode by which to create the ruled surface. (Dramatically
		/// different results are possible depending on the chosen mode.) The
		/// resample mode evenly resamples the polylines (based on length) and
		/// generates triangle strips. The point walk mode uses the existing
		/// points and walks around the polyline using existing points.
		/// </summary>
		// Token: 0x0600F5E9 RID: 62953 RVA: 0x00155FCC File Offset: 0x001541CC
		public virtual int GetRuledModeMaxValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetRuledModeMaxValue_21(base.GetCppThis());
		}

		// Token: 0x0600F5EA RID: 62954
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_GetRuledModeMinValue_22(HandleRef pThis);

		/// <summary>
		/// Set the mode by which to create the ruled surface. (Dramatically
		/// different results are possible depending on the chosen mode.) The
		/// resample mode evenly resamples the polylines (based on length) and
		/// generates triangle strips. The point walk mode uses the existing
		/// points and walks around the polyline using existing points.
		/// </summary>
		// Token: 0x0600F5EB RID: 62955 RVA: 0x00155FEC File Offset: 0x001541EC
		public virtual int GetRuledModeMinValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetRuledModeMinValue_22(base.GetCppThis());
		}

		// Token: 0x0600F5EC RID: 62956
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F5ED RID: 62957 RVA: 0x0015600C File Offset: 0x0015420C
		public override int IsA(string type)
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0600F5EE RID: 62958
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRuledSurfaceFilter_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F5EF RID: 62959 RVA: 0x0015602C File Offset: 0x0015422C
		public new static int IsTypeOf(string type)
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_IsTypeOf_24(type);
		}

		// Token: 0x0600F5F0 RID: 62960
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRuledSurfaceFilter_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F5F1 RID: 62961 RVA: 0x00156048 File Offset: 0x00154248
		public new vtkRuledSurfaceFilter NewInstance()
		{
			vtkRuledSurfaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRuledSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F5F2 RID: 62962
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_OrientLoopsOff_27(HandleRef pThis);

		/// <summary>
		/// Indicate whether the starting points of the loops need to be determined.
		/// If set to 0, then its assumes that the 0th point of each loop should be
		/// always connected
		/// By default the loops are not oriented.
		/// </summary>
		// Token: 0x0600F5F3 RID: 62963 RVA: 0x001560A2 File Offset: 0x001542A2
		public virtual void OrientLoopsOff()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_OrientLoopsOff_27(base.GetCppThis());
		}

		// Token: 0x0600F5F4 RID: 62964
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_OrientLoopsOn_28(HandleRef pThis);

		/// <summary>
		/// Indicate whether the starting points of the loops need to be determined.
		/// If set to 0, then its assumes that the 0th point of each loop should be
		/// always connected
		/// By default the loops are not oriented.
		/// </summary>
		// Token: 0x0600F5F5 RID: 62965 RVA: 0x001560B1 File Offset: 0x001542B1
		public virtual void OrientLoopsOn()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_OrientLoopsOn_28(base.GetCppThis());
		}

		// Token: 0x0600F5F6 RID: 62966
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_PassLinesOff_29(HandleRef pThis);

		/// <summary>
		/// Indicate whether the generating lines are to be passed to the output.
		/// By default lines are not passed to the output.
		/// </summary>
		// Token: 0x0600F5F7 RID: 62967 RVA: 0x001560C0 File Offset: 0x001542C0
		public virtual void PassLinesOff()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_PassLinesOff_29(base.GetCppThis());
		}

		// Token: 0x0600F5F8 RID: 62968
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_PassLinesOn_30(HandleRef pThis);

		/// <summary>
		/// Indicate whether the generating lines are to be passed to the output.
		/// By default lines are not passed to the output.
		/// </summary>
		// Token: 0x0600F5F9 RID: 62969 RVA: 0x001560CF File Offset: 0x001542CF
		public virtual void PassLinesOn()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_PassLinesOn_30(base.GetCppThis());
		}

		// Token: 0x0600F5FA RID: 62970
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRuledSurfaceFilter_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F5FB RID: 62971 RVA: 0x001560E0 File Offset: 0x001542E0
		public new static vtkRuledSurfaceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkRuledSurfaceFilter vtkRuledSurfaceFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRuledSurfaceFilter = (vtkRuledSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRuledSurfaceFilter.Register(null);
				}
			}
			return vtkRuledSurfaceFilter;
		}

		// Token: 0x0600F5FC RID: 62972
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_SetCloseSurface_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether the surface is to be closed. If this boolean is
		/// on, then the first and last polyline are used to generate a stripe
		/// that closes the surface. (Note: to close the surface in the other
		/// direction, repeat the first point in the polyline as the last
		/// point in the polyline.)
		/// </summary>
		// Token: 0x0600F5FD RID: 62973 RVA: 0x0015615F File Offset: 0x0015435F
		public virtual void SetCloseSurface(int _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetCloseSurface_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F5FE RID: 62974
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_SetDistanceFactor_33(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the factor that controls tearing of the surface.
		/// </summary>
		// Token: 0x0600F5FF RID: 62975 RVA: 0x0015616F File Offset: 0x0015436F
		public virtual void SetDistanceFactor(double _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetDistanceFactor_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F600 RID: 62976
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_SetOffset_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the striping of the ruled surface. The offset sets the
		/// first stripe that is visible. Offset is generally used with
		/// OnRatio to create nifty striping effects.
		/// </summary>
		// Token: 0x0600F601 RID: 62977 RVA: 0x0015617F File Offset: 0x0015437F
		public virtual void SetOffset(int _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetOffset_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F602 RID: 62978
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_SetOnRatio_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the striping of the ruled surface. If OnRatio is greater
		/// than 1, then every nth strip is turned on, beginning with the Offset
		/// strip.
		/// </summary>
		// Token: 0x0600F603 RID: 62979 RVA: 0x0015618F File Offset: 0x0015438F
		public virtual void SetOnRatio(int _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetOnRatio_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F604 RID: 62980
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_SetOrientLoops_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether the starting points of the loops need to be determined.
		/// If set to 0, then its assumes that the 0th point of each loop should be
		/// always connected
		/// By default the loops are not oriented.
		/// </summary>
		// Token: 0x0600F605 RID: 62981 RVA: 0x0015619F File Offset: 0x0015439F
		public virtual void SetOrientLoops(int _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetOrientLoops_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F606 RID: 62982
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_SetPassLines_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether the generating lines are to be passed to the output.
		/// By default lines are not passed to the output.
		/// </summary>
		// Token: 0x0600F607 RID: 62983 RVA: 0x001561AF File Offset: 0x001543AF
		public virtual void SetPassLines(int _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetPassLines_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F608 RID: 62984
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_SetResolution_38(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// If the ruled surface generation mode is RESAMPLE, then these parameters
		/// are used to determine the resample rate. Resolution[0] defines the
		/// resolution in the direction of the polylines; Resolution[1] defines
		/// the resolution across the polylines (i.e., direction orthogonal to
		/// Resolution[0]).
		/// </summary>
		// Token: 0x0600F609 RID: 62985 RVA: 0x001561BF File Offset: 0x001543BF
		public virtual void SetResolution(int _arg1, int _arg2)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetResolution_38(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600F60A RID: 62986
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_SetResolution_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// If the ruled surface generation mode is RESAMPLE, then these parameters
		/// are used to determine the resample rate. Resolution[0] defines the
		/// resolution in the direction of the polylines; Resolution[1] defines
		/// the resolution across the polylines (i.e., direction orthogonal to
		/// Resolution[0]).
		/// </summary>
		// Token: 0x0600F60B RID: 62987 RVA: 0x001561D0 File Offset: 0x001543D0
		public void SetResolution(IntPtr _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetResolution_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F60C RID: 62988
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_SetRuledMode_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the mode by which to create the ruled surface. (Dramatically
		/// different results are possible depending on the chosen mode.) The
		/// resample mode evenly resamples the polylines (based on length) and
		/// generates triangle strips. The point walk mode uses the existing
		/// points and walks around the polyline using existing points.
		/// </summary>
		// Token: 0x0600F60D RID: 62989 RVA: 0x001561E0 File Offset: 0x001543E0
		public virtual void SetRuledMode(int _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetRuledMode_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F60E RID: 62990
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_SetRuledModeToPointWalk_41(HandleRef pThis);

		/// <summary>
		/// Set the mode by which to create the ruled surface. (Dramatically
		/// different results are possible depending on the chosen mode.) The
		/// resample mode evenly resamples the polylines (based on length) and
		/// generates triangle strips. The point walk mode uses the existing
		/// points and walks around the polyline using existing points.
		/// </summary>
		// Token: 0x0600F60F RID: 62991 RVA: 0x001561F0 File Offset: 0x001543F0
		public void SetRuledModeToPointWalk()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetRuledModeToPointWalk_41(base.GetCppThis());
		}

		// Token: 0x0600F610 RID: 62992
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRuledSurfaceFilter_SetRuledModeToResample_42(HandleRef pThis);

		/// <summary>
		/// Set the mode by which to create the ruled surface. (Dramatically
		/// different results are possible depending on the chosen mode.) The
		/// resample mode evenly resamples the polylines (based on length) and
		/// generates triangle strips. The point walk mode uses the existing
		/// points and walks around the polyline using existing points.
		/// </summary>
		// Token: 0x0600F611 RID: 62993 RVA: 0x001561FF File Offset: 0x001543FF
		public void SetRuledModeToResample()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetRuledModeToResample_42(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011E9 RID: 4585
		public new const string MRFullTypeName = "Kitware.VTK.vtkRuledSurfaceFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011EA RID: 4586
		public new static readonly string MRClassNameKey = "class vtkRuledSurfaceFilter";
	}
}
