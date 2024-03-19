using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVoxelGrid
	/// </summary>
	/// <remarks>
	///    subsample points using uniform binning
	///
	///
	/// vtkVoxelGrid is a filter that subsamples a point cloud based on a regular
	/// binning of space. Basically the algorithm operates by dividing space into
	/// a volume of M x N x O bins, and then for each bin averaging all of the
	/// points positions into a single representative point. Several strategies for
	/// computing the binning can be used: 1) manual configuration of a requiring
	/// specifying bin dimensions (the bounds are calculated from the data); 2) by
	/// explicit specification of the bin size in world coordinates (x-y-z
	/// lengths); and 3) an automatic process in which the user specifies an
	/// approximate, average number of points per bin and dimensions and bin size
	/// are computed automatically. (Note that under the hood a
	/// vtkStaticPointLocator is used.)
	///
	/// While any vtkPointSet type can be provided as input, the output is
	/// represented by an explicit representation of points via a
	/// vtkPolyData. This output polydata will populate its instance of vtkPoints,
	/// but no cells will be defined (i.e., no vtkVertex or vtkPolyVertex are
	/// contained in the output).
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkStaticPointLocator vtkPointCloudFilter vtkQuadricClustering
	/// </seealso>
	// Token: 0x02000467 RID: 1127
	public class vtkVoxelGrid : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D160 RID: 53600 RVA: 0x0012327B File Offset: 0x0012147B
		static vtkVoxelGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVoxelGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoxelGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D161 RID: 53601 RVA: 0x001232A3 File Offset: 0x001214A3
		public vtkVoxelGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D162 RID: 53602
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D163 RID: 53603 RVA: 0x001232B4 File Offset: 0x001214B4
		public new static vtkVoxelGrid New()
		{
			vtkVoxelGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxelGrid.vtkVoxelGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoxelGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D164 RID: 53604 RVA: 0x00123308 File Offset: 0x00121508
		public vtkVoxelGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVoxelGrid.vtkVoxelGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D165 RID: 53605 RVA: 0x0012334C File Offset: 0x0012154C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D166 RID: 53606
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxelGrid_GetConfigurationStyle_01(HandleRef pThis);

		/// <summary>
		/// Configure how the filter is to operate. The user can choose to manually
		/// specify the binning volume (by setting its dimensions via MANUAL style); or
		/// specify a leaf bin size in the x-y-z directions (SPECIFY_LEAF_SIZE); or
		/// in AUTOMATIC style, use a rough average number of points in each bin
		/// guide the bin size and binning volume dimensions. By default, AUTOMATIC
		/// configuration style is used.
		/// </summary>
		// Token: 0x0600D167 RID: 53607 RVA: 0x00123358 File Offset: 0x00121558
		public virtual int GetConfigurationStyle()
		{
			return vtkVoxelGrid.vtkVoxelGrid_GetConfigurationStyle_01(base.GetCppThis());
		}

		// Token: 0x0600D168 RID: 53608
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelGrid_GetDivisions_02(HandleRef pThis);

		/// <summary>
		/// Set the number of divisions in x-y-z directions (the binning volume
		/// dimensions). This data member is used when the configuration style is
		/// set to MANUAL. Note that these values may be adjusted if &lt;1 or too
		/// large.
		/// </summary>
		// Token: 0x0600D169 RID: 53609 RVA: 0x00123378 File Offset: 0x00121578
		public virtual int[] GetDivisions()
		{
			IntPtr intPtr = vtkVoxelGrid.vtkVoxelGrid_GetDivisions_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D16A RID: 53610
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelGrid_GetDivisions_03(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the number of divisions in x-y-z directions (the binning volume
		/// dimensions). This data member is used when the configuration style is
		/// set to MANUAL. Note that these values may be adjusted if &lt;1 or too
		/// large.
		/// </summary>
		// Token: 0x0600D16B RID: 53611 RVA: 0x001233C0 File Offset: 0x001215C0
		public virtual void GetDivisions(IntPtr data)
		{
			vtkVoxelGrid.vtkVoxelGrid_GetDivisions_03(base.GetCppThis(), data);
		}

		// Token: 0x0600D16C RID: 53612
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelGrid_GetKernel_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify an interpolation kernel to combine the point attributes. By
		/// default a vtkLinearKernel is used (i.e., average values). The
		/// interpolation kernel changes the basis of the interpolation.
		/// </summary>
		// Token: 0x0600D16D RID: 53613 RVA: 0x001233D0 File Offset: 0x001215D0
		public virtual vtkInterpolationKernel GetKernel()
		{
			vtkInterpolationKernel vtkInterpolationKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxelGrid.vtkVoxelGrid_GetKernel_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInterpolationKernel = (vtkInterpolationKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInterpolationKernel.Register(null);
				}
			}
			return vtkInterpolationKernel;
		}

		// Token: 0x0600D16E RID: 53614
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelGrid_GetLeafSize_05(HandleRef pThis);

		/// <summary>
		/// Set the bin size in the x-y-z directions. This data member is
		/// used when the configuration style is set to SPECIFY_LEAF_SIZE. The class will
		/// use these x-y-z lengths, within the bounding box of the point cloud,
		/// to determine the binning dimensions.
		/// </summary>
		// Token: 0x0600D16F RID: 53615 RVA: 0x00123440 File Offset: 0x00121640
		public virtual double[] GetLeafSize()
		{
			IntPtr intPtr = vtkVoxelGrid.vtkVoxelGrid_GetLeafSize_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D170 RID: 53616
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelGrid_GetLeafSize_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the bin size in the x-y-z directions. This data member is
		/// used when the configuration style is set to SPECIFY_LEAF_SIZE. The class will
		/// use these x-y-z lengths, within the bounding box of the point cloud,
		/// to determine the binning dimensions.
		/// </summary>
		// Token: 0x0600D171 RID: 53617 RVA: 0x00123488 File Offset: 0x00121688
		public virtual void GetLeafSize(IntPtr data)
		{
			vtkVoxelGrid.vtkVoxelGrid_GetLeafSize_06(base.GetCppThis(), data);
		}

		// Token: 0x0600D172 RID: 53618
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoxelGrid_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D173 RID: 53619 RVA: 0x00123498 File Offset: 0x00121698
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVoxelGrid.vtkVoxelGrid_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600D174 RID: 53620
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoxelGrid_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D175 RID: 53621 RVA: 0x001234B8 File Offset: 0x001216B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVoxelGrid.vtkVoxelGrid_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600D176 RID: 53622
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxelGrid_GetNumberOfPointsPerBin_09(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each bin. Larger values
		/// result in higher rates of subsampling. This data member is used when the
		/// configuration style is set to AUTOMATIC. The class will automatically
		/// determine the binning dimensions in the x-y-z directions.
		/// </summary>
		// Token: 0x0600D177 RID: 53623 RVA: 0x001234D4 File Offset: 0x001216D4
		public virtual int GetNumberOfPointsPerBin()
		{
			return vtkVoxelGrid.vtkVoxelGrid_GetNumberOfPointsPerBin_09(base.GetCppThis());
		}

		// Token: 0x0600D178 RID: 53624
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxelGrid_GetNumberOfPointsPerBinMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each bin. Larger values
		/// result in higher rates of subsampling. This data member is used when the
		/// configuration style is set to AUTOMATIC. The class will automatically
		/// determine the binning dimensions in the x-y-z directions.
		/// </summary>
		// Token: 0x0600D179 RID: 53625 RVA: 0x001234F4 File Offset: 0x001216F4
		public virtual int GetNumberOfPointsPerBinMaxValue()
		{
			return vtkVoxelGrid.vtkVoxelGrid_GetNumberOfPointsPerBinMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600D17A RID: 53626
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxelGrid_GetNumberOfPointsPerBinMinValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each bin. Larger values
		/// result in higher rates of subsampling. This data member is used when the
		/// configuration style is set to AUTOMATIC. The class will automatically
		/// determine the binning dimensions in the x-y-z directions.
		/// </summary>
		// Token: 0x0600D17B RID: 53627 RVA: 0x00123514 File Offset: 0x00121714
		public virtual int GetNumberOfPointsPerBinMinValue()
		{
			return vtkVoxelGrid.vtkVoxelGrid_GetNumberOfPointsPerBinMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600D17C RID: 53628
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxelGrid_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D17D RID: 53629 RVA: 0x00123534 File Offset: 0x00121734
		public override int IsA(string type)
		{
			return vtkVoxelGrid.vtkVoxelGrid_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600D17E RID: 53630
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxelGrid_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D17F RID: 53631 RVA: 0x00123554 File Offset: 0x00121754
		public new static int IsTypeOf(string type)
		{
			return vtkVoxelGrid.vtkVoxelGrid_IsTypeOf_13(type);
		}

		// Token: 0x0600D180 RID: 53632
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelGrid_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D181 RID: 53633 RVA: 0x00123570 File Offset: 0x00121770
		public new vtkVoxelGrid NewInstance()
		{
			vtkVoxelGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxelGrid.vtkVoxelGrid_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoxelGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D182 RID: 53634
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelGrid_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D183 RID: 53635 RVA: 0x001235CC File Offset: 0x001217CC
		public new static vtkVoxelGrid SafeDownCast(vtkObjectBase o)
		{
			vtkVoxelGrid vtkVoxelGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxelGrid.vtkVoxelGrid_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVoxelGrid = (vtkVoxelGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVoxelGrid.Register(null);
				}
			}
			return vtkVoxelGrid;
		}

		// Token: 0x0600D184 RID: 53636
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelGrid_SetConfigurationStyle_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Configure how the filter is to operate. The user can choose to manually
		/// specify the binning volume (by setting its dimensions via MANUAL style); or
		/// specify a leaf bin size in the x-y-z directions (SPECIFY_LEAF_SIZE); or
		/// in AUTOMATIC style, use a rough average number of points in each bin
		/// guide the bin size and binning volume dimensions. By default, AUTOMATIC
		/// configuration style is used.
		/// </summary>
		// Token: 0x0600D185 RID: 53637 RVA: 0x0012364B File Offset: 0x0012184B
		public virtual void SetConfigurationStyle(int _arg)
		{
			vtkVoxelGrid.vtkVoxelGrid_SetConfigurationStyle_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D186 RID: 53638
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelGrid_SetConfigurationStyleToAutomatic_18(HandleRef pThis);

		/// <summary>
		/// Configure how the filter is to operate. The user can choose to manually
		/// specify the binning volume (by setting its dimensions via MANUAL style); or
		/// specify a leaf bin size in the x-y-z directions (SPECIFY_LEAF_SIZE); or
		/// in AUTOMATIC style, use a rough average number of points in each bin
		/// guide the bin size and binning volume dimensions. By default, AUTOMATIC
		/// configuration style is used.
		/// </summary>
		// Token: 0x0600D187 RID: 53639 RVA: 0x0012365B File Offset: 0x0012185B
		public void SetConfigurationStyleToAutomatic()
		{
			vtkVoxelGrid.vtkVoxelGrid_SetConfigurationStyleToAutomatic_18(base.GetCppThis());
		}

		// Token: 0x0600D188 RID: 53640
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelGrid_SetConfigurationStyleToLeafSize_19(HandleRef pThis);

		/// <summary>
		/// Configure how the filter is to operate. The user can choose to manually
		/// specify the binning volume (by setting its dimensions via MANUAL style); or
		/// specify a leaf bin size in the x-y-z directions (SPECIFY_LEAF_SIZE); or
		/// in AUTOMATIC style, use a rough average number of points in each bin
		/// guide the bin size and binning volume dimensions. By default, AUTOMATIC
		/// configuration style is used.
		/// </summary>
		// Token: 0x0600D189 RID: 53641 RVA: 0x0012366A File Offset: 0x0012186A
		public void SetConfigurationStyleToLeafSize()
		{
			vtkVoxelGrid.vtkVoxelGrid_SetConfigurationStyleToLeafSize_19(base.GetCppThis());
		}

		// Token: 0x0600D18A RID: 53642
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelGrid_SetConfigurationStyleToManual_20(HandleRef pThis);

		/// <summary>
		/// Configure how the filter is to operate. The user can choose to manually
		/// specify the binning volume (by setting its dimensions via MANUAL style); or
		/// specify a leaf bin size in the x-y-z directions (SPECIFY_LEAF_SIZE); or
		/// in AUTOMATIC style, use a rough average number of points in each bin
		/// guide the bin size and binning volume dimensions. By default, AUTOMATIC
		/// configuration style is used.
		/// </summary>
		// Token: 0x0600D18B RID: 53643 RVA: 0x00123679 File Offset: 0x00121879
		public void SetConfigurationStyleToManual()
		{
			vtkVoxelGrid.vtkVoxelGrid_SetConfigurationStyleToManual_20(base.GetCppThis());
		}

		// Token: 0x0600D18C RID: 53644
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelGrid_SetDivisions_21(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set the number of divisions in x-y-z directions (the binning volume
		/// dimensions). This data member is used when the configuration style is
		/// set to MANUAL. Note that these values may be adjusted if &lt;1 or too
		/// large.
		/// </summary>
		// Token: 0x0600D18D RID: 53645 RVA: 0x00123688 File Offset: 0x00121888
		public virtual void SetDivisions(int _arg1, int _arg2, int _arg3)
		{
			vtkVoxelGrid.vtkVoxelGrid_SetDivisions_21(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600D18E RID: 53646
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelGrid_SetDivisions_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the number of divisions in x-y-z directions (the binning volume
		/// dimensions). This data member is used when the configuration style is
		/// set to MANUAL. Note that these values may be adjusted if &lt;1 or too
		/// large.
		/// </summary>
		// Token: 0x0600D18F RID: 53647 RVA: 0x0012369A File Offset: 0x0012189A
		public virtual void SetDivisions(IntPtr _arg)
		{
			vtkVoxelGrid.vtkVoxelGrid_SetDivisions_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D190 RID: 53648
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelGrid_SetKernel_23(HandleRef pThis, HandleRef kernel);

		/// <summary>
		/// Specify an interpolation kernel to combine the point attributes. By
		/// default a vtkLinearKernel is used (i.e., average values). The
		/// interpolation kernel changes the basis of the interpolation.
		/// </summary>
		// Token: 0x0600D191 RID: 53649 RVA: 0x001236AC File Offset: 0x001218AC
		public void SetKernel(vtkInterpolationKernel kernel)
		{
			vtkVoxelGrid.vtkVoxelGrid_SetKernel_23(base.GetCppThis(), (kernel == null) ? default(HandleRef) : kernel.GetCppThis());
		}

		// Token: 0x0600D192 RID: 53650
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelGrid_SetLeafSize_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the bin size in the x-y-z directions. This data member is
		/// used when the configuration style is set to SPECIFY_LEAF_SIZE. The class will
		/// use these x-y-z lengths, within the bounding box of the point cloud,
		/// to determine the binning dimensions.
		/// </summary>
		// Token: 0x0600D193 RID: 53651 RVA: 0x001236DB File Offset: 0x001218DB
		public virtual void SetLeafSize(double _arg1, double _arg2, double _arg3)
		{
			vtkVoxelGrid.vtkVoxelGrid_SetLeafSize_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600D194 RID: 53652
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelGrid_SetLeafSize_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the bin size in the x-y-z directions. This data member is
		/// used when the configuration style is set to SPECIFY_LEAF_SIZE. The class will
		/// use these x-y-z lengths, within the bounding box of the point cloud,
		/// to determine the binning dimensions.
		/// </summary>
		// Token: 0x0600D195 RID: 53653 RVA: 0x001236ED File Offset: 0x001218ED
		public virtual void SetLeafSize(IntPtr _arg)
		{
			vtkVoxelGrid.vtkVoxelGrid_SetLeafSize_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D196 RID: 53654
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelGrid_SetNumberOfPointsPerBin_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the average number of points in each bin. Larger values
		/// result in higher rates of subsampling. This data member is used when the
		/// configuration style is set to AUTOMATIC. The class will automatically
		/// determine the binning dimensions in the x-y-z directions.
		/// </summary>
		// Token: 0x0600D197 RID: 53655 RVA: 0x001236FD File Offset: 0x001218FD
		public virtual void SetNumberOfPointsPerBin(int _arg)
		{
			vtkVoxelGrid.vtkVoxelGrid_SetNumberOfPointsPerBin_26(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F6D RID: 3949
		public new const string MRFullTypeName = "Kitware.VTK.vtkVoxelGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F6E RID: 3950
		public new static readonly string MRClassNameKey = "class vtkVoxelGrid";

		/// <summary>
		/// This enum is used to configure the operation of the filter.
		/// </summary>
		// Token: 0x02000468 RID: 1128
		public enum Style
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F70 RID: 3952
			AUTOMATIC = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000F71 RID: 3953
			MANUAL = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000F72 RID: 3954
			SPECIFY_LEAF_SIZE
		}
	}
}
