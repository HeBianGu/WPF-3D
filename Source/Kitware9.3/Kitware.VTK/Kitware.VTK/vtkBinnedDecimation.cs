using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBinnedDecimation
	/// </summary>
	/// <remarks>
	///    reduce the number of triangles in a vtkPolyData mesh
	///
	/// vtkBinnedDecimation is a filter to reduce the number of triangles in a
	/// triangle mesh represented by vtkPolyData. It is similar to
	/// vtkQuadricClustering in concept, although it is performance accelerated:
	/// it does not use quadric error metrics to position points in the bins, plus
	/// it is threaded. (See vtkQuadricClustering for more information.) It also
	/// takes some short cuts in the interest of speed: it limits the binning
	/// resolution to no more than 2^31 bins; and it can (optionally) reuse the input
	/// points in the output (to save memory and computational costs).
	///
	/// A high-level overview of the algorithm is as follows. Points are binned
	/// into a regular grid subdivided in the x-y-z directions. The idea is to
	/// combine all the points within each bin into a single point which is then
	/// used by the output triangles. Four options are available to generate the
	/// output points. If the input points are to be reused as the output points,
	/// then all points in the same bin simply adopt the coordinates of one of the
	/// selected points in the bin (and thus all points in the bin take on the
	/// same output point id). Alternatively, if new output points are to be
	/// generated, then either one point is selected; the centers of occupied bins
	/// can be used as the output point coordinates; or an average position of all
	/// points falling into the bin can be used to generate the bin
	/// point. Finally, triangles are inserted into the output: triangles whose
	/// three, binned points lie in separate bins are sent to the output, while
	/// all others are discarded (i.e., triangles with two or more points in the
	/// same bin are not sent to the output).
	///
	/// To use this filter, specify the divisions defining the spatial subdivision
	/// in the x, y, and z directions. Of course you must also specify an input
	/// vtkPolyData / filter connection. Higher division levels generally produce
	/// results closer to the original mesh. Note that for performance reasons
	/// (i.e., related to memory), the maximum divisions in the x-y-z directions
	/// is limited in such a way (i.e., proportional scaling of divisions is used)
	/// so as to ensure that no more than 2^31 bins are used. Higher divisions have
	/// modest impact on the overall performance of the algorithm, although the
	/// resolution of the output vtkPolyData is affected significantly (i.e., many
	/// more triangles may be generated).
	///
	/// @warning
	/// This filter can drastically affect mesh topology, i.e., topology is not
	/// preserved.
	///
	/// @warning
	/// This filter and vtkQuadricClustering produce similar results, with
	/// vtkQuadricClustering theoretically producing better results. In practice
	/// however, vtkBinnedDecimation produces results that are visually close to
	/// vtkQuadricClustering at speeds approaching 10-100x faster (depending on
	/// the bin divisions, and how the output points are generated), and the
	/// algorithm requires much less memory. Note that the API of this filter is a
	/// subset of vtkQuadricClustering and can often be used interchangeably with
	/// vtkQuadricClustering.
	///
	/// @warning
	/// Algorithm 4) BIN_CENTERS uses a very different implementation strategy
	/// requiring a sort of all points. It scales better as the number of bins
	/// increases.
	///
	/// @warning
	/// For certain types of geometry (e.g., a mostly 2D plane with jitter in the
	/// normal direction), this decimator can perform badly. In this situation,
	/// set the number of bins in the normal direction to one.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential execution type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadricClustering vtkDecimatePro vtkDecimate vtkQuadricLODActor
	/// vtkTriangleFilter
	/// </seealso>
	// Token: 0x02000945 RID: 2373
	public class vtkBinnedDecimation : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601897A RID: 100730 RVA: 0x00225F0C File Offset: 0x0022410C
		static vtkBinnedDecimation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBinnedDecimation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBinnedDecimation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601897B RID: 100731 RVA: 0x00225F34 File Offset: 0x00224134
		public vtkBinnedDecimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601897C RID: 100732
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinnedDecimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x0601897D RID: 100733 RVA: 0x00225F44 File Offset: 0x00224144
		public new static vtkBinnedDecimation New()
		{
			vtkBinnedDecimation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBinnedDecimation.vtkBinnedDecimation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBinnedDecimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x0601897E RID: 100734 RVA: 0x00225F98 File Offset: 0x00224198
		public vtkBinnedDecimation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBinnedDecimation.vtkBinnedDecimation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601897F RID: 100735 RVA: 0x00225FDC File Offset: 0x002241DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018980 RID: 100736
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_AutoAdjustNumberOfDivisionsOff_01(HandleRef pThis);

		/// <summary>
		/// Enable automatic adjustment of number of divisions. If disabled, the
		/// number of divisions specified by the user is always used (as long as it
		/// is valid). The default is On.
		/// </summary>
		// Token: 0x06018981 RID: 100737 RVA: 0x00225FE7 File Offset: 0x002241E7
		public virtual void AutoAdjustNumberOfDivisionsOff()
		{
			vtkBinnedDecimation.vtkBinnedDecimation_AutoAdjustNumberOfDivisionsOff_01(base.GetCppThis());
		}

		// Token: 0x06018982 RID: 100738
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_AutoAdjustNumberOfDivisionsOn_02(HandleRef pThis);

		/// <summary>
		/// Enable automatic adjustment of number of divisions. If disabled, the
		/// number of divisions specified by the user is always used (as long as it
		/// is valid). The default is On.
		/// </summary>
		// Token: 0x06018983 RID: 100739 RVA: 0x00225FF6 File Offset: 0x002241F6
		public virtual void AutoAdjustNumberOfDivisionsOn()
		{
			vtkBinnedDecimation.vtkBinnedDecimation_AutoAdjustNumberOfDivisionsOn_02(base.GetCppThis());
		}

		// Token: 0x06018984 RID: 100740
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBinnedDecimation_GetAutoAdjustNumberOfDivisions_03(HandleRef pThis);

		/// <summary>
		/// Enable automatic adjustment of number of divisions. If disabled, the
		/// number of divisions specified by the user is always used (as long as it
		/// is valid). The default is On.
		/// </summary>
		// Token: 0x06018985 RID: 100741 RVA: 0x00226008 File Offset: 0x00224208
		public virtual bool GetAutoAdjustNumberOfDivisions()
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetAutoAdjustNumberOfDivisions_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06018986 RID: 100742
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinnedDecimation_GetDivisionOrigin_04(HandleRef pThis);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to
		/// match boundaries between pieces, then you should use these methods
		/// rather than SetNumberOfDivisions(). To use these methods, specify the
		/// origin and spacing of the spatial binning.
		/// </summary>
		// Token: 0x06018987 RID: 100743 RVA: 0x00226030 File Offset: 0x00224230
		public virtual double[] GetDivisionOrigin()
		{
			IntPtr intPtr = vtkBinnedDecimation.vtkBinnedDecimation_GetDivisionOrigin_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06018988 RID: 100744
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_GetDivisionOrigin_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to
		/// match boundaries between pieces, then you should use these methods
		/// rather than SetNumberOfDivisions(). To use these methods, specify the
		/// origin and spacing of the spatial binning.
		/// </summary>
		// Token: 0x06018989 RID: 100745 RVA: 0x00226078 File Offset: 0x00224278
		public virtual void GetDivisionOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_GetDivisionOrigin_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601898A RID: 100746
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_GetDivisionOrigin_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to
		/// match boundaries between pieces, then you should use these methods
		/// rather than SetNumberOfDivisions(). To use these methods, specify the
		/// origin and spacing of the spatial binning.
		/// </summary>
		// Token: 0x0601898B RID: 100747 RVA: 0x0022608A File Offset: 0x0022428A
		public virtual void GetDivisionOrigin(IntPtr _arg)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_GetDivisionOrigin_06(base.GetCppThis(), _arg);
		}

		// Token: 0x0601898C RID: 100748
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinnedDecimation_GetDivisionSpacing_07(HandleRef pThis);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to
		/// match boundaries between pieces, then you should use these methods
		/// rather than SetNumberOfDivisions(). To use these methods, specify the
		/// origin and spacing of the spatial binning.
		/// </summary>
		// Token: 0x0601898D RID: 100749 RVA: 0x0022609C File Offset: 0x0022429C
		public virtual double[] GetDivisionSpacing()
		{
			IntPtr intPtr = vtkBinnedDecimation.vtkBinnedDecimation_GetDivisionSpacing_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601898E RID: 100750
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_GetDivisionSpacing_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to
		/// match boundaries between pieces, then you should use these methods
		/// rather than SetNumberOfDivisions(). To use these methods, specify the
		/// origin and spacing of the spatial binning.
		/// </summary>
		// Token: 0x0601898F RID: 100751 RVA: 0x002260E4 File Offset: 0x002242E4
		public virtual void GetDivisionSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_GetDivisionSpacing_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06018990 RID: 100752
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_GetDivisionSpacing_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to
		/// match boundaries between pieces, then you should use these methods
		/// rather than SetNumberOfDivisions(). To use these methods, specify the
		/// origin and spacing of the spatial binning.
		/// </summary>
		// Token: 0x06018991 RID: 100753 RVA: 0x002260F6 File Offset: 0x002242F6
		public virtual void GetDivisionSpacing(IntPtr _arg)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_GetDivisionSpacing_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06018992 RID: 100754
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBinnedDecimation_GetLargeIds_10(HandleRef pThis);

		/// <summary>
		/// Return a flag indicating whether large ids were used during
		/// execution. The value of this flag is only valid after filter
		/// execution. The filter may use a smaller id type unless it must use
		/// vtkIdType to represent points and cell ids.
		/// </summary>
		// Token: 0x06018993 RID: 100755 RVA: 0x00226108 File Offset: 0x00224308
		public bool GetLargeIds()
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetLargeIds_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06018994 RID: 100756
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinnedDecimation_GetNumberOfDivisions_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions. The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
		/// enabled. Also, the maximum number of divisions is controlled so that no
		/// more than 2^31 bins are created. (If bin adjustment due to the limit on
		/// the number of bins is necessary, then a proportional scaling of the
		/// divisions in the x-y-z directions is used.) This API has been adopted
		/// to be consistent with vtkQuadricClustering.
		/// </summary>
		// Token: 0x06018995 RID: 100757 RVA: 0x00226130 File Offset: 0x00224330
		public IntPtr GetNumberOfDivisions()
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetNumberOfDivisions_11(base.GetCppThis());
		}

		// Token: 0x06018996 RID: 100758
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_GetNumberOfDivisions_12(HandleRef pThis, IntPtr div);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions. The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
		/// enabled. Also, the maximum number of divisions is controlled so that no
		/// more than 2^31 bins are created. (If bin adjustment due to the limit on
		/// the number of bins is necessary, then a proportional scaling of the
		/// divisions in the x-y-z directions is used.) This API has been adopted
		/// to be consistent with vtkQuadricClustering.
		/// </summary>
		// Token: 0x06018997 RID: 100759 RVA: 0x0022614F File Offset: 0x0022434F
		public void GetNumberOfDivisions(IntPtr div)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_GetNumberOfDivisions_12(base.GetCppThis(), div);
		}

		// Token: 0x06018998 RID: 100760
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBinnedDecimation_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x06018999 RID: 100761 RVA: 0x00226160 File Offset: 0x00224360
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601899A RID: 100762
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBinnedDecimation_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x0601899B RID: 100763 RVA: 0x00226180 File Offset: 0x00224380
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601899C RID: 100764
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinnedDecimation_GetNumberOfXDivisions_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions. The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
		/// enabled. Also, the maximum number of divisions is controlled so that no
		/// more than 2^31 bins are created. (If bin adjustment due to the limit on
		/// the number of bins is necessary, then a proportional scaling of the
		/// divisions in the x-y-z directions is used.) This API has been adopted
		/// to be consistent with vtkQuadricClustering.
		/// </summary>
		// Token: 0x0601899D RID: 100765 RVA: 0x0022619C File Offset: 0x0022439C
		public virtual int GetNumberOfXDivisions()
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetNumberOfXDivisions_15(base.GetCppThis());
		}

		// Token: 0x0601899E RID: 100766
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinnedDecimation_GetNumberOfYDivisions_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions. The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
		/// enabled. Also, the maximum number of divisions is controlled so that no
		/// more than 2^31 bins are created. (If bin adjustment due to the limit on
		/// the number of bins is necessary, then a proportional scaling of the
		/// divisions in the x-y-z directions is used.) This API has been adopted
		/// to be consistent with vtkQuadricClustering.
		/// </summary>
		// Token: 0x0601899F RID: 100767 RVA: 0x002261BC File Offset: 0x002243BC
		public virtual int GetNumberOfYDivisions()
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetNumberOfYDivisions_16(base.GetCppThis());
		}

		// Token: 0x060189A0 RID: 100768
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinnedDecimation_GetNumberOfZDivisions_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions. The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
		/// enabled. Also, the maximum number of divisions is controlled so that no
		/// more than 2^31 bins are created. (If bin adjustment due to the limit on
		/// the number of bins is necessary, then a proportional scaling of the
		/// divisions in the x-y-z directions is used.) This API has been adopted
		/// to be consistent with vtkQuadricClustering.
		/// </summary>
		// Token: 0x060189A1 RID: 100769 RVA: 0x002261DC File Offset: 0x002243DC
		public virtual int GetNumberOfZDivisions()
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetNumberOfZDivisions_17(base.GetCppThis());
		}

		// Token: 0x060189A2 RID: 100770
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinnedDecimation_GetPointGenerationMode_18(HandleRef pThis);

		/// <summary>
		/// Four options exist for generating output points. 1) Pass the input
		/// points through to the output; 2) select one of the input points in the bin and
		/// use that; 3) generate new points at the center of bins (only center bin
		/// points used by the output triangles are generated); and 4) generate new
		/// points from the average of all points falling into a bin and used by
		/// output triangles. Note that 1) can result in many, unused output points,
		/// but tends to be fastest for small numbers of bins. This can impact
		/// rendering memory usage as all points are typically pushed into the
		/// graphics hardware. Options 2-4 produce only points used by the output
		/// triangles but generally take longer (for small numbers of bins), with
		/// speeds slowing in order from options 2 through 4. In terms of quality,
		/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
		/// produce decent output, with option 3) (BIN_CENTERS) producing a
		/// voxelized-like result (which is quite useful for illustrative purposes).
		/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
		/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
		/// produces better results.
		/// </summary>
		// Token: 0x060189A3 RID: 100771 RVA: 0x002261FC File Offset: 0x002243FC
		public virtual int GetPointGenerationMode()
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetPointGenerationMode_18(base.GetCppThis());
		}

		// Token: 0x060189A4 RID: 100772
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinnedDecimation_GetPointGenerationModeMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Four options exist for generating output points. 1) Pass the input
		/// points through to the output; 2) select one of the input points in the bin and
		/// use that; 3) generate new points at the center of bins (only center bin
		/// points used by the output triangles are generated); and 4) generate new
		/// points from the average of all points falling into a bin and used by
		/// output triangles. Note that 1) can result in many, unused output points,
		/// but tends to be fastest for small numbers of bins. This can impact
		/// rendering memory usage as all points are typically pushed into the
		/// graphics hardware. Options 2-4 produce only points used by the output
		/// triangles but generally take longer (for small numbers of bins), with
		/// speeds slowing in order from options 2 through 4. In terms of quality,
		/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
		/// produce decent output, with option 3) (BIN_CENTERS) producing a
		/// voxelized-like result (which is quite useful for illustrative purposes).
		/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
		/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
		/// produces better results.
		/// </summary>
		// Token: 0x060189A5 RID: 100773 RVA: 0x0022621C File Offset: 0x0022441C
		public virtual int GetPointGenerationModeMaxValue()
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetPointGenerationModeMaxValue_19(base.GetCppThis());
		}

		// Token: 0x060189A6 RID: 100774
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinnedDecimation_GetPointGenerationModeMinValue_20(HandleRef pThis);

		/// <summary>
		/// Four options exist for generating output points. 1) Pass the input
		/// points through to the output; 2) select one of the input points in the bin and
		/// use that; 3) generate new points at the center of bins (only center bin
		/// points used by the output triangles are generated); and 4) generate new
		/// points from the average of all points falling into a bin and used by
		/// output triangles. Note that 1) can result in many, unused output points,
		/// but tends to be fastest for small numbers of bins. This can impact
		/// rendering memory usage as all points are typically pushed into the
		/// graphics hardware. Options 2-4 produce only points used by the output
		/// triangles but generally take longer (for small numbers of bins), with
		/// speeds slowing in order from options 2 through 4. In terms of quality,
		/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
		/// produce decent output, with option 3) (BIN_CENTERS) producing a
		/// voxelized-like result (which is quite useful for illustrative purposes).
		/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
		/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
		/// produces better results.
		/// </summary>
		// Token: 0x060189A7 RID: 100775 RVA: 0x0022623C File Offset: 0x0022443C
		public virtual int GetPointGenerationModeMinValue()
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetPointGenerationModeMinValue_20(base.GetCppThis());
		}

		// Token: 0x060189A8 RID: 100776
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBinnedDecimation_GetProduceCellData_21(HandleRef pThis);

		/// <summary>
		/// This flag directs the filter to copy cell data from input to output.
		/// This flag is off by default.
		/// </summary>
		// Token: 0x060189A9 RID: 100777 RVA: 0x0022625C File Offset: 0x0022445C
		public virtual bool GetProduceCellData()
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetProduceCellData_21(base.GetCppThis()) != 0;
		}

		// Token: 0x060189AA RID: 100778
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBinnedDecimation_GetProducePointData_22(HandleRef pThis);

		/// <summary>
		/// This flag directs the filter to produce output point data from the input
		/// point data (on by default). If the ProducePointData is set to
		/// INPUT_POINTS, point data is simply passed from input to output (since
		/// the points don't change). If the point generation mode is set to
		/// BIN_AVERAGES, then the average of all point data values within a bin
		/// are associated with the point generated in the bin. If the point
		/// generation mode is either BIN_POINTS or BIN_CENTERS, then the point
		/// data values from one of the points falling into the bin is used.
		/// </summary>
		// Token: 0x060189AB RID: 100779 RVA: 0x00226284 File Offset: 0x00224484
		public virtual bool GetProducePointData()
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_GetProducePointData_22(base.GetCppThis()) != 0;
		}

		// Token: 0x060189AC RID: 100780
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinnedDecimation_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x060189AD RID: 100781 RVA: 0x002262AC File Offset: 0x002244AC
		public override int IsA(string type)
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x060189AE RID: 100782
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinnedDecimation_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x060189AF RID: 100783 RVA: 0x002262CC File Offset: 0x002244CC
		public new static int IsTypeOf(string type)
		{
			return vtkBinnedDecimation.vtkBinnedDecimation_IsTypeOf_24(type);
		}

		// Token: 0x060189B0 RID: 100784
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinnedDecimation_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x060189B1 RID: 100785 RVA: 0x002262E8 File Offset: 0x002244E8
		public new vtkBinnedDecimation NewInstance()
		{
			vtkBinnedDecimation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBinnedDecimation.vtkBinnedDecimation_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBinnedDecimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060189B2 RID: 100786
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_ProduceCellDataOff_27(HandleRef pThis);

		/// <summary>
		/// This flag directs the filter to copy cell data from input to output.
		/// This flag is off by default.
		/// </summary>
		// Token: 0x060189B3 RID: 100787 RVA: 0x00226342 File Offset: 0x00224542
		public virtual void ProduceCellDataOff()
		{
			vtkBinnedDecimation.vtkBinnedDecimation_ProduceCellDataOff_27(base.GetCppThis());
		}

		// Token: 0x060189B4 RID: 100788
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_ProduceCellDataOn_28(HandleRef pThis);

		/// <summary>
		/// This flag directs the filter to copy cell data from input to output.
		/// This flag is off by default.
		/// </summary>
		// Token: 0x060189B5 RID: 100789 RVA: 0x00226351 File Offset: 0x00224551
		public virtual void ProduceCellDataOn()
		{
			vtkBinnedDecimation.vtkBinnedDecimation_ProduceCellDataOn_28(base.GetCppThis());
		}

		// Token: 0x060189B6 RID: 100790
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_ProducePointDataOff_29(HandleRef pThis);

		/// <summary>
		/// This flag directs the filter to produce output point data from the input
		/// point data (on by default). If the ProducePointData is set to
		/// INPUT_POINTS, point data is simply passed from input to output (since
		/// the points don't change). If the point generation mode is set to
		/// BIN_AVERAGES, then the average of all point data values within a bin
		/// are associated with the point generated in the bin. If the point
		/// generation mode is either BIN_POINTS or BIN_CENTERS, then the point
		/// data values from one of the points falling into the bin is used.
		/// </summary>
		// Token: 0x060189B7 RID: 100791 RVA: 0x00226360 File Offset: 0x00224560
		public virtual void ProducePointDataOff()
		{
			vtkBinnedDecimation.vtkBinnedDecimation_ProducePointDataOff_29(base.GetCppThis());
		}

		// Token: 0x060189B8 RID: 100792
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_ProducePointDataOn_30(HandleRef pThis);

		/// <summary>
		/// This flag directs the filter to produce output point data from the input
		/// point data (on by default). If the ProducePointData is set to
		/// INPUT_POINTS, point data is simply passed from input to output (since
		/// the points don't change). If the point generation mode is set to
		/// BIN_AVERAGES, then the average of all point data values within a bin
		/// are associated with the point generated in the bin. If the point
		/// generation mode is either BIN_POINTS or BIN_CENTERS, then the point
		/// data values from one of the points falling into the bin is used.
		/// </summary>
		// Token: 0x060189B9 RID: 100793 RVA: 0x0022636F File Offset: 0x0022456F
		public virtual void ProducePointDataOn()
		{
			vtkBinnedDecimation.vtkBinnedDecimation_ProducePointDataOn_30(base.GetCppThis());
		}

		// Token: 0x060189BA RID: 100794
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinnedDecimation_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x060189BB RID: 100795 RVA: 0x00226380 File Offset: 0x00224580
		public new static vtkBinnedDecimation SafeDownCast(vtkObjectBase o)
		{
			vtkBinnedDecimation vtkBinnedDecimation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBinnedDecimation.vtkBinnedDecimation_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBinnedDecimation = (vtkBinnedDecimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBinnedDecimation.Register(null);
				}
			}
			return vtkBinnedDecimation;
		}

		// Token: 0x060189BC RID: 100796
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetAutoAdjustNumberOfDivisions_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable automatic adjustment of number of divisions. If disabled, the
		/// number of divisions specified by the user is always used (as long as it
		/// is valid). The default is On.
		/// </summary>
		// Token: 0x060189BD RID: 100797 RVA: 0x002263FF File Offset: 0x002245FF
		public virtual void SetAutoAdjustNumberOfDivisions(bool _arg)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetAutoAdjustNumberOfDivisions_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060189BE RID: 100798
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetDivisionOrigin_33(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to
		/// match boundaries between pieces, then you should use these methods
		/// rather than SetNumberOfDivisions(). To use these methods, specify the
		/// origin and spacing of the spatial binning.
		/// </summary>
		// Token: 0x060189BF RID: 100799 RVA: 0x00226417 File Offset: 0x00224617
		public void SetDivisionOrigin(double x, double y, double z)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetDivisionOrigin_33(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060189C0 RID: 100800
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetDivisionOrigin_34(HandleRef pThis, IntPtr o);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to
		/// match boundaries between pieces, then you should use these methods
		/// rather than SetNumberOfDivisions(). To use these methods, specify the
		/// origin and spacing of the spatial binning.
		/// </summary>
		// Token: 0x060189C1 RID: 100801 RVA: 0x00226429 File Offset: 0x00224629
		public void SetDivisionOrigin(IntPtr o)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetDivisionOrigin_34(base.GetCppThis(), o);
		}

		// Token: 0x060189C2 RID: 100802
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetDivisionSpacing_35(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to
		/// match boundaries between pieces, then you should use these methods
		/// rather than SetNumberOfDivisions(). To use these methods, specify the
		/// origin and spacing of the spatial binning.
		/// </summary>
		// Token: 0x060189C3 RID: 100803 RVA: 0x00226439 File Offset: 0x00224639
		public void SetDivisionSpacing(double x, double y, double z)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetDivisionSpacing_35(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060189C4 RID: 100804
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetDivisionSpacing_36(HandleRef pThis, IntPtr s);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to
		/// match boundaries between pieces, then you should use these methods
		/// rather than SetNumberOfDivisions(). To use these methods, specify the
		/// origin and spacing of the spatial binning.
		/// </summary>
		// Token: 0x060189C5 RID: 100805 RVA: 0x0022644B File Offset: 0x0022464B
		public void SetDivisionSpacing(IntPtr s)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetDivisionSpacing_36(base.GetCppThis(), s);
		}

		// Token: 0x060189C6 RID: 100806
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetNumberOfDivisions_37(HandleRef pThis, IntPtr div);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions. The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
		/// enabled. Also, the maximum number of divisions is controlled so that no
		/// more than 2^31 bins are created. (If bin adjustment due to the limit on
		/// the number of bins is necessary, then a proportional scaling of the
		/// divisions in the x-y-z directions is used.) This API has been adopted
		/// to be consistent with vtkQuadricClustering.
		/// </summary>
		// Token: 0x060189C7 RID: 100807 RVA: 0x0022645B File Offset: 0x0022465B
		public void SetNumberOfDivisions(IntPtr div)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetNumberOfDivisions_37(base.GetCppThis(), div);
		}

		// Token: 0x060189C8 RID: 100808
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetNumberOfDivisions_38(HandleRef pThis, int div0, int div1, int div2);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions. The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
		/// enabled. Also, the maximum number of divisions is controlled so that no
		/// more than 2^31 bins are created. (If bin adjustment due to the limit on
		/// the number of bins is necessary, then a proportional scaling of the
		/// divisions in the x-y-z directions is used.) This API has been adopted
		/// to be consistent with vtkQuadricClustering.
		/// </summary>
		// Token: 0x060189C9 RID: 100809 RVA: 0x0022646B File Offset: 0x0022466B
		public void SetNumberOfDivisions(int div0, int div1, int div2)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetNumberOfDivisions_38(base.GetCppThis(), div0, div1, div2);
		}

		// Token: 0x060189CA RID: 100810
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetNumberOfXDivisions_39(HandleRef pThis, int num);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions. The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
		/// enabled. Also, the maximum number of divisions is controlled so that no
		/// more than 2^31 bins are created. (If bin adjustment due to the limit on
		/// the number of bins is necessary, then a proportional scaling of the
		/// divisions in the x-y-z directions is used.) This API has been adopted
		/// to be consistent with vtkQuadricClustering.
		/// </summary>
		// Token: 0x060189CB RID: 100811 RVA: 0x0022647D File Offset: 0x0022467D
		public void SetNumberOfXDivisions(int num)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetNumberOfXDivisions_39(base.GetCppThis(), num);
		}

		// Token: 0x060189CC RID: 100812
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetNumberOfYDivisions_40(HandleRef pThis, int num);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions. The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
		/// enabled. Also, the maximum number of divisions is controlled so that no
		/// more than 2^31 bins are created. (If bin adjustment due to the limit on
		/// the number of bins is necessary, then a proportional scaling of the
		/// divisions in the x-y-z directions is used.) This API has been adopted
		/// to be consistent with vtkQuadricClustering.
		/// </summary>
		// Token: 0x060189CD RID: 100813 RVA: 0x0022648D File Offset: 0x0022468D
		public void SetNumberOfYDivisions(int num)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetNumberOfYDivisions_40(base.GetCppThis(), num);
		}

		// Token: 0x060189CE RID: 100814
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetNumberOfZDivisions_41(HandleRef pThis, int num);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions. The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
		/// enabled. Also, the maximum number of divisions is controlled so that no
		/// more than 2^31 bins are created. (If bin adjustment due to the limit on
		/// the number of bins is necessary, then a proportional scaling of the
		/// divisions in the x-y-z directions is used.) This API has been adopted
		/// to be consistent with vtkQuadricClustering.
		/// </summary>
		// Token: 0x060189CF RID: 100815 RVA: 0x0022649D File Offset: 0x0022469D
		public void SetNumberOfZDivisions(int num)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetNumberOfZDivisions_41(base.GetCppThis(), num);
		}

		// Token: 0x060189D0 RID: 100816
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetPointGenerationMode_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Four options exist for generating output points. 1) Pass the input
		/// points through to the output; 2) select one of the input points in the bin and
		/// use that; 3) generate new points at the center of bins (only center bin
		/// points used by the output triangles are generated); and 4) generate new
		/// points from the average of all points falling into a bin and used by
		/// output triangles. Note that 1) can result in many, unused output points,
		/// but tends to be fastest for small numbers of bins. This can impact
		/// rendering memory usage as all points are typically pushed into the
		/// graphics hardware. Options 2-4 produce only points used by the output
		/// triangles but generally take longer (for small numbers of bins), with
		/// speeds slowing in order from options 2 through 4. In terms of quality,
		/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
		/// produce decent output, with option 3) (BIN_CENTERS) producing a
		/// voxelized-like result (which is quite useful for illustrative purposes).
		/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
		/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
		/// produces better results.
		/// </summary>
		// Token: 0x060189D1 RID: 100817 RVA: 0x002264AD File Offset: 0x002246AD
		public virtual void SetPointGenerationMode(int _arg)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetPointGenerationMode_42(base.GetCppThis(), _arg);
		}

		// Token: 0x060189D2 RID: 100818
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetPointGenerationModeToBinAverages_43(HandleRef pThis);

		/// <summary>
		/// Four options exist for generating output points. 1) Pass the input
		/// points through to the output; 2) select one of the input points in the bin and
		/// use that; 3) generate new points at the center of bins (only center bin
		/// points used by the output triangles are generated); and 4) generate new
		/// points from the average of all points falling into a bin and used by
		/// output triangles. Note that 1) can result in many, unused output points,
		/// but tends to be fastest for small numbers of bins. This can impact
		/// rendering memory usage as all points are typically pushed into the
		/// graphics hardware. Options 2-4 produce only points used by the output
		/// triangles but generally take longer (for small numbers of bins), with
		/// speeds slowing in order from options 2 through 4. In terms of quality,
		/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
		/// produce decent output, with option 3) (BIN_CENTERS) producing a
		/// voxelized-like result (which is quite useful for illustrative purposes).
		/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
		/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
		/// produces better results.
		/// </summary>
		// Token: 0x060189D3 RID: 100819 RVA: 0x002264BD File Offset: 0x002246BD
		public void SetPointGenerationModeToBinAverages()
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetPointGenerationModeToBinAverages_43(base.GetCppThis());
		}

		// Token: 0x060189D4 RID: 100820
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetPointGenerationModeToBinCenters_44(HandleRef pThis);

		/// <summary>
		/// Four options exist for generating output points. 1) Pass the input
		/// points through to the output; 2) select one of the input points in the bin and
		/// use that; 3) generate new points at the center of bins (only center bin
		/// points used by the output triangles are generated); and 4) generate new
		/// points from the average of all points falling into a bin and used by
		/// output triangles. Note that 1) can result in many, unused output points,
		/// but tends to be fastest for small numbers of bins. This can impact
		/// rendering memory usage as all points are typically pushed into the
		/// graphics hardware. Options 2-4 produce only points used by the output
		/// triangles but generally take longer (for small numbers of bins), with
		/// speeds slowing in order from options 2 through 4. In terms of quality,
		/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
		/// produce decent output, with option 3) (BIN_CENTERS) producing a
		/// voxelized-like result (which is quite useful for illustrative purposes).
		/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
		/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
		/// produces better results.
		/// </summary>
		// Token: 0x060189D5 RID: 100821 RVA: 0x002264CC File Offset: 0x002246CC
		public void SetPointGenerationModeToBinCenters()
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetPointGenerationModeToBinCenters_44(base.GetCppThis());
		}

		// Token: 0x060189D6 RID: 100822
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetPointGenerationModeToBinPoints_45(HandleRef pThis);

		/// <summary>
		/// Four options exist for generating output points. 1) Pass the input
		/// points through to the output; 2) select one of the input points in the bin and
		/// use that; 3) generate new points at the center of bins (only center bin
		/// points used by the output triangles are generated); and 4) generate new
		/// points from the average of all points falling into a bin and used by
		/// output triangles. Note that 1) can result in many, unused output points,
		/// but tends to be fastest for small numbers of bins. This can impact
		/// rendering memory usage as all points are typically pushed into the
		/// graphics hardware. Options 2-4 produce only points used by the output
		/// triangles but generally take longer (for small numbers of bins), with
		/// speeds slowing in order from options 2 through 4. In terms of quality,
		/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
		/// produce decent output, with option 3) (BIN_CENTERS) producing a
		/// voxelized-like result (which is quite useful for illustrative purposes).
		/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
		/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
		/// produces better results.
		/// </summary>
		// Token: 0x060189D7 RID: 100823 RVA: 0x002264DB File Offset: 0x002246DB
		public void SetPointGenerationModeToBinPoints()
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetPointGenerationModeToBinPoints_45(base.GetCppThis());
		}

		// Token: 0x060189D8 RID: 100824
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetPointGenerationModeToUseInputPoints_46(HandleRef pThis);

		/// <summary>
		/// Four options exist for generating output points. 1) Pass the input
		/// points through to the output; 2) select one of the input points in the bin and
		/// use that; 3) generate new points at the center of bins (only center bin
		/// points used by the output triangles are generated); and 4) generate new
		/// points from the average of all points falling into a bin and used by
		/// output triangles. Note that 1) can result in many, unused output points,
		/// but tends to be fastest for small numbers of bins. This can impact
		/// rendering memory usage as all points are typically pushed into the
		/// graphics hardware. Options 2-4 produce only points used by the output
		/// triangles but generally take longer (for small numbers of bins), with
		/// speeds slowing in order from options 2 through 4. In terms of quality,
		/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
		/// produce decent output, with option 3) (BIN_CENTERS) producing a
		/// voxelized-like result (which is quite useful for illustrative purposes).
		/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
		/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
		/// produces better results.
		/// </summary>
		// Token: 0x060189D9 RID: 100825 RVA: 0x002264EA File Offset: 0x002246EA
		public void SetPointGenerationModeToUseInputPoints()
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetPointGenerationModeToUseInputPoints_46(base.GetCppThis());
		}

		// Token: 0x060189DA RID: 100826
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetProduceCellData_47(HandleRef pThis, byte _arg);

		/// <summary>
		/// This flag directs the filter to copy cell data from input to output.
		/// This flag is off by default.
		/// </summary>
		// Token: 0x060189DB RID: 100827 RVA: 0x002264F9 File Offset: 0x002246F9
		public virtual void SetProduceCellData(bool _arg)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetProduceCellData_47(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060189DC RID: 100828
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinnedDecimation_SetProducePointData_48(HandleRef pThis, byte _arg);

		/// <summary>
		/// This flag directs the filter to produce output point data from the input
		/// point data (on by default). If the ProducePointData is set to
		/// INPUT_POINTS, point data is simply passed from input to output (since
		/// the points don't change). If the point generation mode is set to
		/// BIN_AVERAGES, then the average of all point data values within a bin
		/// are associated with the point generated in the bin. If the point
		/// generation mode is either BIN_POINTS or BIN_CENTERS, then the point
		/// data values from one of the points falling into the bin is used.
		/// </summary>
		// Token: 0x060189DD RID: 100829 RVA: 0x00226511 File Offset: 0x00224711
		public virtual void SetProducePointData(bool _arg)
		{
			vtkBinnedDecimation.vtkBinnedDecimation_SetProducePointData_48(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B3B RID: 6971
		public new const string MRFullTypeName = "Kitware.VTK.vtkBinnedDecimation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B3C RID: 6972
		public new static readonly string MRClassNameKey = "class vtkBinnedDecimation";

		/// <summary>
		/// Four options exist for generating output points. 1) Pass the input
		/// points through to the output; 2) select one of the input points in the bin and
		/// use that; 3) generate new points at the center of bins (only center bin
		/// points used by the output triangles are generated); and 4) generate new
		/// points from the average of all points falling into a bin and used by
		/// output triangles. Note that 1) can result in many, unused output points,
		/// but tends to be fastest for small numbers of bins. This can impact
		/// rendering memory usage as all points are typically pushed into the
		/// graphics hardware. Options 2-4 produce only points used by the output
		/// triangles but generally take longer (for small numbers of bins), with
		/// speeds slowing in order from options 2 through 4. In terms of quality,
		/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
		/// produce decent output, with option 3) (BIN_CENTERS) producing a
		/// voxelized-like result (which is quite useful for illustrative purposes).
		/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
		/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
		/// produces better results.
		/// </summary>
		// Token: 0x02000946 RID: 2374
		public enum BIN_AVERAGES_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001B3E RID: 6974
			BIN_AVERAGES = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001B3F RID: 6975
			BIN_CENTERS = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001B40 RID: 6976
			BIN_POINTS = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001B41 RID: 6977
			INPUT_POINTS = 1
		}
	}
}
