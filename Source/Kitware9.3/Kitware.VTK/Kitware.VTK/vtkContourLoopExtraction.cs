using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContourLoopExtraction
	/// </summary>
	/// <remarks>
	///    extract closed loops (polygons) from lines and polylines
	///
	/// This filter takes an input consisting of lines and polylines and
	/// constructs polygons (i.e., closed loops) from them. It combines some of
	/// the capability of connectivity filters and the line stripper to produce
	/// manifold loops that are suitable for geometric operations. For example,
	/// the vtkCookieCutter works well with this filter.
	///
	/// Note that the input structure for this filter consists of points and line
	/// or polyline cells. All other topological types (verts, polygons, triangle
	/// strips) are ignored. The output of this filter is by default manifold
	/// polygons. Note however, that optionally polyline loops may also be output
	/// if requested.
	///
	/// @warning
	/// Although the loops are constructed in 3-space, a normal vector must be
	/// supplied to help choose a turn direction when multiple choices are
	/// possible. By default the normal vector is n={0,0,1} but may be user
	/// specified. Note also that some filters require that the loops are located
	/// in the z=constant or z=0 plane. Hence a transform filter of some sort may
	/// be necesssary to project the loops to a plane.
	///
	/// @warning
	/// Note that lines that do not close in on themselves can be optionally
	/// forced closed. This occurs when for example, 2D contours end and begin at
	/// the boundaries of data. By forcing closure, the last point is joined to
	/// the first point (with boundary points possibly added). Note that there are
	/// different closure modes: 1) do not close (and hence reject the polygon);
	/// 2) close along the dataset boundaries (i.e., the bounding box of a dataset
	/// used to generate the contour lines); and 3) close all open loops by
	/// connectiong the first and last point. If Option #2 is chosen, only loops
	/// that start and end on either a horizontal or vertical boundary are closed.
	///
	/// @warning
	/// Scalar thresholding can be enabled. If enabled, then only those loops with
	/// *any" scalar point data within the thresholded range are extracted.
	///
	/// @warning
	/// Any detached lines forming degenerate loops of defined by two points or
	/// less are discarded. Non-manifold junctions are broken into separate,
	/// independent loops.
	///
	/// @warning
	/// Boundary closure only works if the end points are both on a vertical
	/// boundary or horizontal boundary. Otherwise new points would have to be
	/// added which this filter does not (currently) do.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCookieCutter vtkFlyingEdges2D vtkMarchingSquares vtkFeatureEdges
	/// vtkConnectivityFilter vtkPolyDataConnectivityFilter
	/// vtkDiscreteFlyingEdges2D vtkStripper vtkImprintFilter
	/// vtkCleanPolyData vtkStaticCleanPolyData
	/// </seealso>
	// Token: 0x0200054D RID: 1357
	public class vtkContourLoopExtraction : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F17F RID: 61823 RVA: 0x00150820 File Offset: 0x0014EA20
		static vtkContourLoopExtraction()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourLoopExtraction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourLoopExtraction"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F180 RID: 61824 RVA: 0x00150848 File Offset: 0x0014EA48
		public vtkContourLoopExtraction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F181 RID: 61825
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourLoopExtraction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F182 RID: 61826 RVA: 0x00150858 File Offset: 0x0014EA58
		public new static vtkContourLoopExtraction New()
		{
			vtkContourLoopExtraction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourLoopExtraction.vtkContourLoopExtraction_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourLoopExtraction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F183 RID: 61827 RVA: 0x001508AC File Offset: 0x0014EAAC
		public vtkContourLoopExtraction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContourLoopExtraction.vtkContourLoopExtraction_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F184 RID: 61828 RVA: 0x001508F0 File Offset: 0x0014EAF0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F185 RID: 61829
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_CleanPointsOff_01(HandleRef pThis);

		/// <summary>
		/// Indicate whether to clean the output points. Cleaning means discarding
		/// any points that are unused by the output polylines or polygons. This
		/// results in a potential renumbering of the points. By default, cleaning
		/// points is on. (This feature is useful because some filters output
		/// points in addition to those used to represent output lines and
		/// polylines, and this method is faster than using
		/// vtkCleanPolyData/vtkStaticCleanPolyData).
		/// </summary>
		// Token: 0x0600F186 RID: 61830 RVA: 0x001508FB File Offset: 0x0014EAFB
		public virtual void CleanPointsOff()
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_CleanPointsOff_01(base.GetCppThis());
		}

		// Token: 0x0600F187 RID: 61831
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_CleanPointsOn_02(HandleRef pThis);

		/// <summary>
		/// Indicate whether to clean the output points. Cleaning means discarding
		/// any points that are unused by the output polylines or polygons. This
		/// results in a potential renumbering of the points. By default, cleaning
		/// points is on. (This feature is useful because some filters output
		/// points in addition to those used to represent output lines and
		/// polylines, and this method is faster than using
		/// vtkCleanPolyData/vtkStaticCleanPolyData).
		/// </summary>
		// Token: 0x0600F188 RID: 61832 RVA: 0x0015090A File Offset: 0x0014EB0A
		public virtual void CleanPointsOn()
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_CleanPointsOn_02(base.GetCppThis());
		}

		// Token: 0x0600F189 RID: 61833
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContourLoopExtraction_GetCleanPoints_03(HandleRef pThis);

		/// <summary>
		/// Indicate whether to clean the output points. Cleaning means discarding
		/// any points that are unused by the output polylines or polygons. This
		/// results in a potential renumbering of the points. By default, cleaning
		/// points is on. (This feature is useful because some filters output
		/// points in addition to those used to represent output lines and
		/// polylines, and this method is faster than using
		/// vtkCleanPolyData/vtkStaticCleanPolyData).
		/// </summary>
		// Token: 0x0600F18A RID: 61834 RVA: 0x0015091C File Offset: 0x0014EB1C
		public virtual bool GetCleanPoints()
		{
			return vtkContourLoopExtraction.vtkContourLoopExtraction_GetCleanPoints_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F18B RID: 61835
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourLoopExtraction_GetLoopClosure_04(HandleRef pThis);

		/// <summary>
		/// Specify whether to close loops or not. All non-closed loops can be
		/// rejected; boundary loops (end points lie on vertical or horizontal
		/// porions of the boundary) can be closed (default); or all loops can be
		/// forced closed by connecting first and last points.
		/// </summary>
		// Token: 0x0600F18C RID: 61836 RVA: 0x00150944 File Offset: 0x0014EB44
		public virtual int GetLoopClosure()
		{
			return vtkContourLoopExtraction.vtkContourLoopExtraction_GetLoopClosure_04(base.GetCppThis());
		}

		// Token: 0x0600F18D RID: 61837
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourLoopExtraction_GetLoopClosureAsString_05(HandleRef pThis);

		/// <summary>
		/// Specify whether to close loops or not. All non-closed loops can be
		/// rejected; boundary loops (end points lie on vertical or horizontal
		/// porions of the boundary) can be closed (default); or all loops can be
		/// forced closed by connecting first and last points.
		/// </summary>
		// Token: 0x0600F18E RID: 61838 RVA: 0x00150964 File Offset: 0x0014EB64
		public string GetLoopClosureAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkContourLoopExtraction.vtkContourLoopExtraction_GetLoopClosureAsString_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600F18F RID: 61839
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourLoopExtraction_GetLoopClosureMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Specify whether to close loops or not. All non-closed loops can be
		/// rejected; boundary loops (end points lie on vertical or horizontal
		/// porions of the boundary) can be closed (default); or all loops can be
		/// forced closed by connecting first and last points.
		/// </summary>
		// Token: 0x0600F190 RID: 61840 RVA: 0x001509A0 File Offset: 0x0014EBA0
		public virtual int GetLoopClosureMaxValue()
		{
			return vtkContourLoopExtraction.vtkContourLoopExtraction_GetLoopClosureMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0600F191 RID: 61841
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourLoopExtraction_GetLoopClosureMinValue_07(HandleRef pThis);

		/// <summary>
		/// Specify whether to close loops or not. All non-closed loops can be
		/// rejected; boundary loops (end points lie on vertical or horizontal
		/// porions of the boundary) can be closed (default); or all loops can be
		/// forced closed by connecting first and last points.
		/// </summary>
		// Token: 0x0600F192 RID: 61842 RVA: 0x001509C0 File Offset: 0x0014EBC0
		public virtual int GetLoopClosureMinValue()
		{
			return vtkContourLoopExtraction.vtkContourLoopExtraction_GetLoopClosureMinValue_07(base.GetCppThis());
		}

		// Token: 0x0600F193 RID: 61843
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourLoopExtraction_GetNormal_08(HandleRef pThis);

		/// <summary>
		/// Set the normal vector used to orient the algorithm (controlling turns
		/// around the loop). By default the normal points in the +z direction.
		/// </summary>
		// Token: 0x0600F194 RID: 61844 RVA: 0x001509E0 File Offset: 0x0014EBE0
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkContourLoopExtraction.vtkContourLoopExtraction_GetNormal_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F195 RID: 61845
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_GetNormal_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the normal vector used to orient the algorithm (controlling turns
		/// around the loop). By default the normal points in the +z direction.
		/// </summary>
		// Token: 0x0600F196 RID: 61846 RVA: 0x00150A28 File Offset: 0x0014EC28
		public virtual void GetNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_GetNormal_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600F197 RID: 61847
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_GetNormal_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the normal vector used to orient the algorithm (controlling turns
		/// around the loop). By default the normal points in the +z direction.
		/// </summary>
		// Token: 0x0600F198 RID: 61848 RVA: 0x00150A3A File Offset: 0x0014EC3A
		public virtual void GetNormal(IntPtr _arg)
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_GetNormal_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F199 RID: 61849
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourLoopExtraction_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F19A RID: 61850 RVA: 0x00150A4C File Offset: 0x0014EC4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContourLoopExtraction.vtkContourLoopExtraction_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600F19B RID: 61851
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourLoopExtraction_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F19C RID: 61852 RVA: 0x00150A6C File Offset: 0x0014EC6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContourLoopExtraction.vtkContourLoopExtraction_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600F19D RID: 61853
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourLoopExtraction_GetOutputMode_13(HandleRef pThis);

		/// <summary>
		/// Specify the form of the output. Polygons can be output (default);
		/// polylines can be output (the first and last point is repeated); or both
		/// can be output.
		/// </summary>
		// Token: 0x0600F19E RID: 61854 RVA: 0x00150A88 File Offset: 0x0014EC88
		public virtual int GetOutputMode()
		{
			return vtkContourLoopExtraction.vtkContourLoopExtraction_GetOutputMode_13(base.GetCppThis());
		}

		// Token: 0x0600F19F RID: 61855
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourLoopExtraction_GetOutputModeAsString_14(HandleRef pThis);

		/// <summary>
		/// Specify the form of the output. Polygons can be output (default);
		/// polylines can be output (the first and last point is repeated); or both
		/// can be output.
		/// </summary>
		// Token: 0x0600F1A0 RID: 61856 RVA: 0x00150AA8 File Offset: 0x0014ECA8
		public string GetOutputModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkContourLoopExtraction.vtkContourLoopExtraction_GetOutputModeAsString_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600F1A1 RID: 61857
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourLoopExtraction_GetOutputModeMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Specify the form of the output. Polygons can be output (default);
		/// polylines can be output (the first and last point is repeated); or both
		/// can be output.
		/// </summary>
		// Token: 0x0600F1A2 RID: 61858 RVA: 0x00150AE4 File Offset: 0x0014ECE4
		public virtual int GetOutputModeMaxValue()
		{
			return vtkContourLoopExtraction.vtkContourLoopExtraction_GetOutputModeMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0600F1A3 RID: 61859
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourLoopExtraction_GetOutputModeMinValue_16(HandleRef pThis);

		/// <summary>
		/// Specify the form of the output. Polygons can be output (default);
		/// polylines can be output (the first and last point is repeated); or both
		/// can be output.
		/// </summary>
		// Token: 0x0600F1A4 RID: 61860 RVA: 0x00150B04 File Offset: 0x0014ED04
		public virtual int GetOutputModeMinValue()
		{
			return vtkContourLoopExtraction.vtkContourLoopExtraction_GetOutputModeMinValue_16(base.GetCppThis());
		}

		// Token: 0x0600F1A5 RID: 61861
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourLoopExtraction_GetScalarRange_17(HandleRef pThis);

		/// <summary>
		/// Set the scalar range to use to extract loop based on scalar
		/// thresholding.  If any scalar, point data, in the loop falls into the
		/// scalar range given, then the loop is extracted.
		/// </summary>
		// Token: 0x0600F1A6 RID: 61862 RVA: 0x00150B24 File Offset: 0x0014ED24
		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkContourLoopExtraction.vtkContourLoopExtraction_GetScalarRange_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F1A7 RID: 61863
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_GetScalarRange_18(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set the scalar range to use to extract loop based on scalar
		/// thresholding.  If any scalar, point data, in the loop falls into the
		/// scalar range given, then the loop is extracted.
		/// </summary>
		// Token: 0x0600F1A8 RID: 61864 RVA: 0x00150B6C File Offset: 0x0014ED6C
		public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_GetScalarRange_18(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600F1A9 RID: 61865
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_GetScalarRange_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range to use to extract loop based on scalar
		/// thresholding.  If any scalar, point data, in the loop falls into the
		/// scalar range given, then the loop is extracted.
		/// </summary>
		// Token: 0x0600F1AA RID: 61866 RVA: 0x00150B7D File Offset: 0x0014ED7D
		public virtual void GetScalarRange(IntPtr _arg)
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_GetScalarRange_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F1AB RID: 61867
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContourLoopExtraction_GetScalarThresholding_20(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of loops based on scalar thresholding.  Loops
		/// with scalar values in a specified range can be extracted. If no scalars
		/// are available from the input than this data member is ignored.
		/// </summary>
		// Token: 0x0600F1AC RID: 61868 RVA: 0x00150B90 File Offset: 0x0014ED90
		public virtual bool GetScalarThresholding()
		{
			return vtkContourLoopExtraction.vtkContourLoopExtraction_GetScalarThresholding_20(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F1AD RID: 61869
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourLoopExtraction_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F1AE RID: 61870 RVA: 0x00150BB8 File Offset: 0x0014EDB8
		public override int IsA(string type)
		{
			return vtkContourLoopExtraction.vtkContourLoopExtraction_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x0600F1AF RID: 61871
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourLoopExtraction_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F1B0 RID: 61872 RVA: 0x00150BD8 File Offset: 0x0014EDD8
		public new static int IsTypeOf(string type)
		{
			return vtkContourLoopExtraction.vtkContourLoopExtraction_IsTypeOf_22(type);
		}

		// Token: 0x0600F1B1 RID: 61873
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourLoopExtraction_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F1B2 RID: 61874 RVA: 0x00150BF4 File Offset: 0x0014EDF4
		public new vtkContourLoopExtraction NewInstance()
		{
			vtkContourLoopExtraction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourLoopExtraction.vtkContourLoopExtraction_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourLoopExtraction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F1B3 RID: 61875
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourLoopExtraction_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F1B4 RID: 61876 RVA: 0x00150C50 File Offset: 0x0014EE50
		public new static vtkContourLoopExtraction SafeDownCast(vtkObjectBase o)
		{
			vtkContourLoopExtraction vtkContourLoopExtraction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourLoopExtraction.vtkContourLoopExtraction_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourLoopExtraction = (vtkContourLoopExtraction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourLoopExtraction.Register(null);
				}
			}
			return vtkContourLoopExtraction;
		}

		// Token: 0x0600F1B5 RID: 61877
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_ScalarThresholdingOff_26(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of loops based on scalar thresholding.  Loops
		/// with scalar values in a specified range can be extracted. If no scalars
		/// are available from the input than this data member is ignored.
		/// </summary>
		// Token: 0x0600F1B6 RID: 61878 RVA: 0x00150CCF File Offset: 0x0014EECF
		public virtual void ScalarThresholdingOff()
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_ScalarThresholdingOff_26(base.GetCppThis());
		}

		// Token: 0x0600F1B7 RID: 61879
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_ScalarThresholdingOn_27(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of loops based on scalar thresholding.  Loops
		/// with scalar values in a specified range can be extracted. If no scalars
		/// are available from the input than this data member is ignored.
		/// </summary>
		// Token: 0x0600F1B8 RID: 61880 RVA: 0x00150CDE File Offset: 0x0014EEDE
		public virtual void ScalarThresholdingOn()
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_ScalarThresholdingOn_27(base.GetCppThis());
		}

		// Token: 0x0600F1B9 RID: 61881
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetCleanPoints_28(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to clean the output points. Cleaning means discarding
		/// any points that are unused by the output polylines or polygons. This
		/// results in a potential renumbering of the points. By default, cleaning
		/// points is on. (This feature is useful because some filters output
		/// points in addition to those used to represent output lines and
		/// polylines, and this method is faster than using
		/// vtkCleanPolyData/vtkStaticCleanPolyData).
		/// </summary>
		// Token: 0x0600F1BA RID: 61882 RVA: 0x00150CED File Offset: 0x0014EEED
		public virtual void SetCleanPoints(bool _arg)
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetCleanPoints_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F1BB RID: 61883
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetLoopClosure_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to close loops or not. All non-closed loops can be
		/// rejected; boundary loops (end points lie on vertical or horizontal
		/// porions of the boundary) can be closed (default); or all loops can be
		/// forced closed by connecting first and last points.
		/// </summary>
		// Token: 0x0600F1BC RID: 61884 RVA: 0x00150D05 File Offset: 0x0014EF05
		public virtual void SetLoopClosure(int _arg)
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetLoopClosure_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F1BD RID: 61885
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetLoopClosureToAll_30(HandleRef pThis);

		/// <summary>
		/// Specify whether to close loops or not. All non-closed loops can be
		/// rejected; boundary loops (end points lie on vertical or horizontal
		/// porions of the boundary) can be closed (default); or all loops can be
		/// forced closed by connecting first and last points.
		/// </summary>
		// Token: 0x0600F1BE RID: 61886 RVA: 0x00150D15 File Offset: 0x0014EF15
		public void SetLoopClosureToAll()
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetLoopClosureToAll_30(base.GetCppThis());
		}

		// Token: 0x0600F1BF RID: 61887
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetLoopClosureToBoundary_31(HandleRef pThis);

		/// <summary>
		/// Specify whether to close loops or not. All non-closed loops can be
		/// rejected; boundary loops (end points lie on vertical or horizontal
		/// porions of the boundary) can be closed (default); or all loops can be
		/// forced closed by connecting first and last points.
		/// </summary>
		// Token: 0x0600F1C0 RID: 61888 RVA: 0x00150D24 File Offset: 0x0014EF24
		public void SetLoopClosureToBoundary()
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetLoopClosureToBoundary_31(base.GetCppThis());
		}

		// Token: 0x0600F1C1 RID: 61889
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetLoopClosureToOff_32(HandleRef pThis);

		/// <summary>
		/// Specify whether to close loops or not. All non-closed loops can be
		/// rejected; boundary loops (end points lie on vertical or horizontal
		/// porions of the boundary) can be closed (default); or all loops can be
		/// forced closed by connecting first and last points.
		/// </summary>
		// Token: 0x0600F1C2 RID: 61890 RVA: 0x00150D33 File Offset: 0x0014EF33
		public void SetLoopClosureToOff()
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetLoopClosureToOff_32(base.GetCppThis());
		}

		// Token: 0x0600F1C3 RID: 61891
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetNormal_33(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the normal vector used to orient the algorithm (controlling turns
		/// around the loop). By default the normal points in the +z direction.
		/// </summary>
		// Token: 0x0600F1C4 RID: 61892 RVA: 0x00150D42 File Offset: 0x0014EF42
		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetNormal_33(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F1C5 RID: 61893
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetNormal_34(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the normal vector used to orient the algorithm (controlling turns
		/// around the loop). By default the normal points in the +z direction.
		/// </summary>
		// Token: 0x0600F1C6 RID: 61894 RVA: 0x00150D54 File Offset: 0x0014EF54
		public virtual void SetNormal(IntPtr _arg)
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetNormal_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F1C7 RID: 61895
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetOutputMode_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the form of the output. Polygons can be output (default);
		/// polylines can be output (the first and last point is repeated); or both
		/// can be output.
		/// </summary>
		// Token: 0x0600F1C8 RID: 61896 RVA: 0x00150D64 File Offset: 0x0014EF64
		public virtual void SetOutputMode(int _arg)
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetOutputMode_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F1C9 RID: 61897
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetOutputModeToBoth_36(HandleRef pThis);

		/// <summary>
		/// Specify the form of the output. Polygons can be output (default);
		/// polylines can be output (the first and last point is repeated); or both
		/// can be output.
		/// </summary>
		// Token: 0x0600F1CA RID: 61898 RVA: 0x00150D74 File Offset: 0x0014EF74
		public void SetOutputModeToBoth()
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetOutputModeToBoth_36(base.GetCppThis());
		}

		// Token: 0x0600F1CB RID: 61899
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetOutputModeToPolygons_37(HandleRef pThis);

		/// <summary>
		/// Specify the form of the output. Polygons can be output (default);
		/// polylines can be output (the first and last point is repeated); or both
		/// can be output.
		/// </summary>
		// Token: 0x0600F1CC RID: 61900 RVA: 0x00150D83 File Offset: 0x0014EF83
		public void SetOutputModeToPolygons()
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetOutputModeToPolygons_37(base.GetCppThis());
		}

		// Token: 0x0600F1CD RID: 61901
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetOutputModeToPolylines_38(HandleRef pThis);

		/// <summary>
		/// Specify the form of the output. Polygons can be output (default);
		/// polylines can be output (the first and last point is repeated); or both
		/// can be output.
		/// </summary>
		// Token: 0x0600F1CE RID: 61902 RVA: 0x00150D92 File Offset: 0x0014EF92
		public void SetOutputModeToPolylines()
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetOutputModeToPolylines_38(base.GetCppThis());
		}

		// Token: 0x0600F1CF RID: 61903
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetScalarRange_39(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the scalar range to use to extract loop based on scalar
		/// thresholding.  If any scalar, point data, in the loop falls into the
		/// scalar range given, then the loop is extracted.
		/// </summary>
		// Token: 0x0600F1D0 RID: 61904 RVA: 0x00150DA1 File Offset: 0x0014EFA1
		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetScalarRange_39(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600F1D1 RID: 61905
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetScalarRange_40(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range to use to extract loop based on scalar
		/// thresholding.  If any scalar, point data, in the loop falls into the
		/// scalar range given, then the loop is extracted.
		/// </summary>
		// Token: 0x0600F1D2 RID: 61906 RVA: 0x00150DB2 File Offset: 0x0014EFB2
		public void SetScalarRange(IntPtr _arg)
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetScalarRange_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F1D3 RID: 61907
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLoopExtraction_SetScalarThresholding_41(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the extraction of loops based on scalar thresholding.  Loops
		/// with scalar values in a specified range can be extracted. If no scalars
		/// are available from the input than this data member is ignored.
		/// </summary>
		// Token: 0x0600F1D4 RID: 61908 RVA: 0x00150DC2 File Offset: 0x0014EFC2
		public virtual void SetScalarThresholding(bool _arg)
		{
			vtkContourLoopExtraction.vtkContourLoopExtraction_SetScalarThresholding_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001194 RID: 4500
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourLoopExtraction";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001195 RID: 4501
		public new static readonly string MRClassNameKey = "class vtkContourLoopExtraction";
	}
}
