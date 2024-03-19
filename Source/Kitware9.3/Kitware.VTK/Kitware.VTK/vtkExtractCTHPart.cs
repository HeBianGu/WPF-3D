using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractCTHPart
	/// </summary>
	/// <remarks>
	///    Generates surface of a CTH volume fraction.
	///
	/// vtkExtractCTHPart is a filter that is specialized for creating
	/// visualizations for a CTH simulation. CTH datasets comprise of either
	/// vtkNonOverlappingAMR or a multiblock of non-overlapping rectilinear grids
	/// with cell-data. Certain cell-arrays in the dataset identify the fraction of
	/// a particular material present in a given cell. This goal with this filter is
	/// to extract a surface contour demarcating the surface where the volume
	/// fraction for a particular material is equal to the user chosen value.
	///
	/// To achieve that, this filter first converts the cell-data to point-data and
	/// then simply apply vtkContourFilter filter to extract the contour.
	///
	/// vtkExtractCTHPart also provides the user with an option to clip the resultant
	/// contour using a vtkPlane. Internally, it uses vtkClipClosedSurface to clip
	/// the contour using the vtkPlane provided.
	///
	/// The output of this filter is a vtkMultiBlockDataSet with one block
	/// corresponding to each volume-fraction array requested. Each block itself is a
	/// vtkPolyData for the contour generated on the current process (which may be
	/// null, for processes where no contour is generated).
	/// </remarks>
	// Token: 0x02000500 RID: 1280
	public class vtkExtractCTHPart : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E656 RID: 58966 RVA: 0x00140D15 File Offset: 0x0013EF15
		static vtkExtractCTHPart()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractCTHPart.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractCTHPart"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E657 RID: 58967 RVA: 0x00140D3D File Offset: 0x0013EF3D
		public vtkExtractCTHPart(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E658 RID: 58968
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCTHPart_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E659 RID: 58969 RVA: 0x00140D4C File Offset: 0x0013EF4C
		public new static vtkExtractCTHPart New()
		{
			vtkExtractCTHPart result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCTHPart.vtkExtractCTHPart_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractCTHPart)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E65A RID: 58970 RVA: 0x00140DA0 File Offset: 0x0013EFA0
		public vtkExtractCTHPart() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractCTHPart.vtkExtractCTHPart_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E65B RID: 58971 RVA: 0x00140DE4 File Offset: 0x0013EFE4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E65C RID: 58972
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_AddVolumeArrayName_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Select cell-data arrays (volume-fraction arrays) to contour with.
		/// </summary>
		// Token: 0x0600E65D RID: 58973 RVA: 0x00140DEF File Offset: 0x0013EFEF
		public void AddVolumeArrayName(string arg0)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_AddVolumeArrayName_01(base.GetCppThis(), arg0);
		}

		// Token: 0x0600E65E RID: 58974
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_CappingOff_02(HandleRef pThis);

		/// <summary>
		/// On by default, enables logic to cap the material volume.
		/// </summary>
		// Token: 0x0600E65F RID: 58975 RVA: 0x00140DFF File Offset: 0x0013EFFF
		public virtual void CappingOff()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_CappingOff_02(base.GetCppThis());
		}

		// Token: 0x0600E660 RID: 58976
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_CappingOn_03(HandleRef pThis);

		/// <summary>
		/// On by default, enables logic to cap the material volume.
		/// </summary>
		// Token: 0x0600E661 RID: 58977 RVA: 0x00140E0E File Offset: 0x0013F00E
		public virtual void CappingOn()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_CappingOn_03(base.GetCppThis());
		}

		// Token: 0x0600E662 RID: 58978
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_GenerateSolidGeometryOff_04(HandleRef pThis);

		/// <summary>
		/// Generate solid geometry as results instead of 2D contours.
		/// When set to true, GenerateTriangles flag will be ignored.
		/// False by default.
		/// </summary>
		// Token: 0x0600E663 RID: 58979 RVA: 0x00140E1D File Offset: 0x0013F01D
		public virtual void GenerateSolidGeometryOff()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_GenerateSolidGeometryOff_04(base.GetCppThis());
		}

		// Token: 0x0600E664 RID: 58980
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_GenerateSolidGeometryOn_05(HandleRef pThis);

		/// <summary>
		/// Generate solid geometry as results instead of 2D contours.
		/// When set to true, GenerateTriangles flag will be ignored.
		/// False by default.
		/// </summary>
		// Token: 0x0600E665 RID: 58981 RVA: 0x00140E2C File Offset: 0x0013F02C
		public virtual void GenerateSolidGeometryOn()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_GenerateSolidGeometryOn_05(base.GetCppThis());
		}

		// Token: 0x0600E666 RID: 58982
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_GenerateTrianglesOff_06(HandleRef pThis);

		/// <summary>
		/// Triangulate results. When set to false, the internal cut and contour filters
		/// are told not to triangulate results if possible. true by default.
		/// </summary>
		// Token: 0x0600E667 RID: 58983 RVA: 0x00140E3B File Offset: 0x0013F03B
		public virtual void GenerateTrianglesOff()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_GenerateTrianglesOff_06(base.GetCppThis());
		}

		// Token: 0x0600E668 RID: 58984
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_GenerateTrianglesOn_07(HandleRef pThis);

		/// <summary>
		/// Triangulate results. When set to false, the internal cut and contour filters
		/// are told not to triangulate results if possible. true by default.
		/// </summary>
		// Token: 0x0600E669 RID: 58985 RVA: 0x00140E4A File Offset: 0x0013F04A
		public virtual void GenerateTrianglesOn()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_GenerateTrianglesOn_07(base.GetCppThis());
		}

		// Token: 0x0600E66A RID: 58986
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractCTHPart_GetCapping_08(HandleRef pThis);

		/// <summary>
		/// On by default, enables logic to cap the material volume.
		/// </summary>
		// Token: 0x0600E66B RID: 58987 RVA: 0x00140E5C File Offset: 0x0013F05C
		public virtual bool GetCapping()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetCapping_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E66C RID: 58988
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCTHPart_GetClipPlane_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set, get or manipulate the implicit clipping plane.
		/// </summary>
		// Token: 0x0600E66D RID: 58989 RVA: 0x00140E84 File Offset: 0x0013F084
		public virtual vtkPlane GetClipPlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCTHPart.vtkExtractCTHPart_GetClipPlane_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x0600E66E RID: 58990
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCTHPart_GetController_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the parallel controller. By default, the value returned by
		/// vtkMultiBlockDataSetAlgorithm::GetGlobalController() when the object is
		/// instantiated is used.
		/// </summary>
		// Token: 0x0600E66F RID: 58991 RVA: 0x00140EF4 File Offset: 0x0013F0F4
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCTHPart.vtkExtractCTHPart_GetController_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600E670 RID: 58992
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractCTHPart_GetGenerateSolidGeometry_11(HandleRef pThis);

		/// <summary>
		/// Generate solid geometry as results instead of 2D contours.
		/// When set to true, GenerateTriangles flag will be ignored.
		/// False by default.
		/// </summary>
		// Token: 0x0600E671 RID: 58993 RVA: 0x00140F64 File Offset: 0x0013F164
		public virtual bool GetGenerateSolidGeometry()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetGenerateSolidGeometry_11(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E672 RID: 58994
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractCTHPart_GetGenerateTriangles_12(HandleRef pThis);

		/// <summary>
		/// Triangulate results. When set to false, the internal cut and contour filters
		/// are told not to triangulate results if possible. true by default.
		/// </summary>
		// Token: 0x0600E673 RID: 58995 RVA: 0x00140F8C File Offset: 0x0013F18C
		public virtual bool GetGenerateTriangles()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetGenerateTriangles_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E674 RID: 58996
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkExtractCTHPart_GetMTime_13(HandleRef pThis);

		/// <summary>
		/// Look at clip plane to compute MTime.
		/// </summary>
		// Token: 0x0600E675 RID: 58997 RVA: 0x00140FB4 File Offset: 0x0013F1B4
		public override ulong GetMTime()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetMTime_13(base.GetCppThis());
		}

		// Token: 0x0600E676 RID: 58998
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractCTHPart_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E677 RID: 58999 RVA: 0x00140FD4 File Offset: 0x0013F1D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0600E678 RID: 59000
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractCTHPart_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E679 RID: 59001 RVA: 0x00140FF4 File Offset: 0x0013F1F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0600E67A RID: 59002
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractCTHPart_GetNumberOfVolumeArrayNames_16(HandleRef pThis);

		/// <summary>
		/// Select cell-data arrays (volume-fraction arrays) to contour with.
		/// </summary>
		// Token: 0x0600E67B RID: 59003 RVA: 0x00141010 File Offset: 0x0013F210
		public int GetNumberOfVolumeArrayNames()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetNumberOfVolumeArrayNames_16(base.GetCppThis());
		}

		// Token: 0x0600E67C RID: 59004
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractCTHPart_GetRemoveGhostCells_17(HandleRef pThis);

		/// <summary>
		/// When set to false, the output surfaces will not hide contours extracted from
		/// ghost cells. This results in overlapping contours but overcomes holes.
		/// Default is set to true.
		/// </summary>
		// Token: 0x0600E67D RID: 59005 RVA: 0x00141030 File Offset: 0x0013F230
		public virtual bool GetRemoveGhostCells()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetRemoveGhostCells_17(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E67E RID: 59006
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCTHPart_GetVolumeArrayName_18(HandleRef pThis, int idx);

		/// <summary>
		/// Select cell-data arrays (volume-fraction arrays) to contour with.
		/// </summary>
		// Token: 0x0600E67F RID: 59007 RVA: 0x00141058 File Offset: 0x0013F258
		public string GetVolumeArrayName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkExtractCTHPart.vtkExtractCTHPart_GetVolumeArrayName_18(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600E680 RID: 59008
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExtractCTHPart_GetVolumeFractionSurfaceValue_19(HandleRef pThis);

		/// <summary>
		/// Set and get the volume fraction surface value. This value should be
		/// between 0 and 1
		/// </summary>
		// Token: 0x0600E681 RID: 59009 RVA: 0x00141094 File Offset: 0x0013F294
		public virtual double GetVolumeFractionSurfaceValue()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetVolumeFractionSurfaceValue_19(base.GetCppThis());
		}

		// Token: 0x0600E682 RID: 59010
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExtractCTHPart_GetVolumeFractionSurfaceValueMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Set and get the volume fraction surface value. This value should be
		/// between 0 and 1
		/// </summary>
		// Token: 0x0600E683 RID: 59011 RVA: 0x001410B4 File Offset: 0x0013F2B4
		public virtual double GetVolumeFractionSurfaceValueMaxValue()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetVolumeFractionSurfaceValueMaxValue_20(base.GetCppThis());
		}

		// Token: 0x0600E684 RID: 59012
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExtractCTHPart_GetVolumeFractionSurfaceValueMinValue_21(HandleRef pThis);

		/// <summary>
		/// Set and get the volume fraction surface value. This value should be
		/// between 0 and 1
		/// </summary>
		// Token: 0x0600E685 RID: 59013 RVA: 0x001410D4 File Offset: 0x0013F2D4
		public virtual double GetVolumeFractionSurfaceValueMinValue()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetVolumeFractionSurfaceValueMinValue_21(base.GetCppThis());
		}

		// Token: 0x0600E686 RID: 59014
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractCTHPart_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E687 RID: 59015 RVA: 0x001410F4 File Offset: 0x0013F2F4
		public override int IsA(string type)
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0600E688 RID: 59016
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractCTHPart_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E689 RID: 59017 RVA: 0x00141114 File Offset: 0x0013F314
		public new static int IsTypeOf(string type)
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_IsTypeOf_23(type);
		}

		// Token: 0x0600E68A RID: 59018
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCTHPart_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E68B RID: 59019 RVA: 0x00141130 File Offset: 0x0013F330
		public new vtkExtractCTHPart NewInstance()
		{
			vtkExtractCTHPart result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCTHPart.vtkExtractCTHPart_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractCTHPart)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E68C RID: 59020
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_RemoveGhostCellsOff_26(HandleRef pThis);

		/// <summary>
		/// When set to false, the output surfaces will not hide contours extracted from
		/// ghost cells. This results in overlapping contours but overcomes holes.
		/// Default is set to true.
		/// </summary>
		// Token: 0x0600E68D RID: 59021 RVA: 0x0014118A File Offset: 0x0013F38A
		public virtual void RemoveGhostCellsOff()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_RemoveGhostCellsOff_26(base.GetCppThis());
		}

		// Token: 0x0600E68E RID: 59022
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_RemoveGhostCellsOn_27(HandleRef pThis);

		/// <summary>
		/// When set to false, the output surfaces will not hide contours extracted from
		/// ghost cells. This results in overlapping contours but overcomes holes.
		/// Default is set to true.
		/// </summary>
		// Token: 0x0600E68F RID: 59023 RVA: 0x00141199 File Offset: 0x0013F399
		public virtual void RemoveGhostCellsOn()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_RemoveGhostCellsOn_27(base.GetCppThis());
		}

		// Token: 0x0600E690 RID: 59024
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_RemoveVolumeArrayNames_28(HandleRef pThis);

		/// <summary>
		/// Select cell-data arrays (volume-fraction arrays) to contour with.
		/// </summary>
		// Token: 0x0600E691 RID: 59025 RVA: 0x001411A8 File Offset: 0x0013F3A8
		public void RemoveVolumeArrayNames()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_RemoveVolumeArrayNames_28(base.GetCppThis());
		}

		// Token: 0x0600E692 RID: 59026
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCTHPart_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E693 RID: 59027 RVA: 0x001411B8 File Offset: 0x0013F3B8
		public new static vtkExtractCTHPart SafeDownCast(vtkObjectBase o)
		{
			vtkExtractCTHPart vtkExtractCTHPart = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCTHPart.vtkExtractCTHPart_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractCTHPart = (vtkExtractCTHPart)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractCTHPart.Register(null);
				}
			}
			return vtkExtractCTHPart;
		}

		// Token: 0x0600E694 RID: 59028
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_SetCapping_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// On by default, enables logic to cap the material volume.
		/// </summary>
		// Token: 0x0600E695 RID: 59029 RVA: 0x00141237 File Offset: 0x0013F437
		public virtual void SetCapping(bool _arg)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_SetCapping_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E696 RID: 59030
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_SetClipPlane_31(HandleRef pThis, HandleRef clipPlane);

		/// <summary>
		/// Set, get or manipulate the implicit clipping plane.
		/// </summary>
		// Token: 0x0600E697 RID: 59031 RVA: 0x00141250 File Offset: 0x0013F450
		public void SetClipPlane(vtkPlane clipPlane)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_SetClipPlane_31(base.GetCppThis(), (clipPlane == null) ? default(HandleRef) : clipPlane.GetCppThis());
		}

		// Token: 0x0600E698 RID: 59032
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_SetController_32(HandleRef pThis, HandleRef controller);

		/// <summary>
		/// Get/Set the parallel controller. By default, the value returned by
		/// vtkMultiBlockDataSetAlgorithm::GetGlobalController() when the object is
		/// instantiated is used.
		/// </summary>
		// Token: 0x0600E699 RID: 59033 RVA: 0x00141280 File Offset: 0x0013F480
		public void SetController(vtkMultiProcessController controller)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_SetController_32(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		// Token: 0x0600E69A RID: 59034
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_SetGenerateSolidGeometry_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Generate solid geometry as results instead of 2D contours.
		/// When set to true, GenerateTriangles flag will be ignored.
		/// False by default.
		/// </summary>
		// Token: 0x0600E69B RID: 59035 RVA: 0x001412AF File Offset: 0x0013F4AF
		public virtual void SetGenerateSolidGeometry(bool _arg)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_SetGenerateSolidGeometry_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E69C RID: 59036
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_SetGenerateTriangles_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Triangulate results. When set to false, the internal cut and contour filters
		/// are told not to triangulate results if possible. true by default.
		/// </summary>
		// Token: 0x0600E69D RID: 59037 RVA: 0x001412C7 File Offset: 0x0013F4C7
		public virtual void SetGenerateTriangles(bool _arg)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_SetGenerateTriangles_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E69E RID: 59038
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_SetRemoveGhostCells_35(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to false, the output surfaces will not hide contours extracted from
		/// ghost cells. This results in overlapping contours but overcomes holes.
		/// Default is set to true.
		/// </summary>
		// Token: 0x0600E69F RID: 59039 RVA: 0x001412DF File Offset: 0x0013F4DF
		public virtual void SetRemoveGhostCells(bool _arg)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_SetRemoveGhostCells_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E6A0 RID: 59040
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCTHPart_SetVolumeFractionSurfaceValue_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Set and get the volume fraction surface value. This value should be
		/// between 0 and 1
		/// </summary>
		// Token: 0x0600E6A1 RID: 59041 RVA: 0x001412F7 File Offset: 0x0013F4F7
		public virtual void SetVolumeFractionSurfaceValue(double _arg)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_SetVolumeFractionSurfaceValue_36(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010E9 RID: 4329
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractCTHPart";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010EA RID: 4330
		public new static readonly string MRClassNameKey = "class vtkExtractCTHPart";
	}
}
