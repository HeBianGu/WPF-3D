using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractGrid
	/// </summary>
	/// <remarks>
	///    select piece (e.g., volume of interest) and/or subsample structured grid dataset
	///
	///
	/// vtkExtractGrid is a filter that selects a portion of an input structured
	/// grid dataset, or subsamples an input dataset. (The selected portion of
	/// interested is referred to as the Volume Of Interest, or VOI.) The output of
	/// this filter is a structured grid dataset. The filter treats input data of
	/// any topological dimension (i.e., point, line, image, or volume) and can
	/// generate output data of any topological dimension.
	///
	/// To use this filter set the VOI ivar which are i-j-k min/max indices that
	/// specify a rectangular region in the data. (Note that these are 0-offset.)
	/// You can also specify a sampling rate to subsample the data.
	///
	/// Typical applications of this filter are to extract a plane from a grid for
	/// contouring, subsampling large grids to reduce data size, or extracting
	/// regions of a grid with interesting data.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGeometryFilter vtkExtractGeometry vtkExtractVOI
	/// vtkStructuredGridGeometryFilter
	/// </seealso>
	// Token: 0x020006AC RID: 1708
	public class vtkExtractGrid : vtkStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601242E RID: 74798 RVA: 0x0019959F File Offset: 0x0019779F
		static vtkExtractGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601242F RID: 74799 RVA: 0x001995C7 File Offset: 0x001977C7
		public vtkExtractGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012430 RID: 74800
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012431 RID: 74801 RVA: 0x001995D8 File Offset: 0x001977D8
		public new static vtkExtractGrid New()
		{
			vtkExtractGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractGrid.vtkExtractGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012432 RID: 74802 RVA: 0x0019962C File Offset: 0x0019782C
		public vtkExtractGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractGrid.vtkExtractGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012433 RID: 74803 RVA: 0x00199670 File Offset: 0x00197870
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012434 RID: 74804
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractGrid_GetIncludeBoundary_01(HandleRef pThis);

		/// <summary>
		/// Control whether to enforce that the "boundary" of the grid is output in
		/// the subsampling process. (This ivar only has effect when the SampleRate
		/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
		/// on, the subsampling will always include the boundary of the grid even
		/// though the sample rate is not an even multiple of the grid
		/// dimensions. (By default IncludeBoundary is off.)
		/// </summary>
		// Token: 0x06012435 RID: 74805 RVA: 0x0019967C File Offset: 0x0019787C
		public virtual int GetIncludeBoundary()
		{
			return vtkExtractGrid.vtkExtractGrid_GetIncludeBoundary_01(base.GetCppThis());
		}

		// Token: 0x06012436 RID: 74806
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractGrid_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012437 RID: 74807 RVA: 0x0019969C File Offset: 0x0019789C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractGrid.vtkExtractGrid_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012438 RID: 74808
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractGrid_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012439 RID: 74809 RVA: 0x001996BC File Offset: 0x001978BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractGrid.vtkExtractGrid_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601243A RID: 74810
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGrid_GetSampleRate_04(HandleRef pThis);

		/// <summary>
		/// Set the sampling rate in the i, j, and k directions. If the rate is &gt; 1,
		/// then the resulting VOI will be subsampled representation of the input.
		/// For example, if the SampleRate=(2,2,2), every other point will be
		/// selected, resulting in a volume 1/8th the original size.
		/// Initial value is (1,1,1).
		/// </summary>
		// Token: 0x0601243B RID: 74811 RVA: 0x001996D8 File Offset: 0x001978D8
		public virtual int[] GetSampleRate()
		{
			IntPtr intPtr = vtkExtractGrid.vtkExtractGrid_GetSampleRate_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601243C RID: 74812
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGrid_GetSampleRate_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the sampling rate in the i, j, and k directions. If the rate is &gt; 1,
		/// then the resulting VOI will be subsampled representation of the input.
		/// For example, if the SampleRate=(2,2,2), every other point will be
		/// selected, resulting in a volume 1/8th the original size.
		/// Initial value is (1,1,1).
		/// </summary>
		// Token: 0x0601243D RID: 74813 RVA: 0x00199720 File Offset: 0x00197920
		public virtual void GetSampleRate(IntPtr data)
		{
			vtkExtractGrid.vtkExtractGrid_GetSampleRate_05(base.GetCppThis(), data);
		}

		// Token: 0x0601243E RID: 74814
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGrid_GetVOI_06(HandleRef pThis);

		/// <summary>
		/// Specify i-j-k (min,max) pairs to extract. The resulting structured grid
		/// dataset can be of any topological dimension (i.e., point, line, plane,
		/// or 3D grid).
		/// </summary>
		// Token: 0x0601243F RID: 74815 RVA: 0x00199730 File Offset: 0x00197930
		public virtual int[] GetVOI()
		{
			IntPtr intPtr = vtkExtractGrid.vtkExtractGrid_GetVOI_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06012440 RID: 74816
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGrid_GetVOI_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify i-j-k (min,max) pairs to extract. The resulting structured grid
		/// dataset can be of any topological dimension (i.e., point, line, plane,
		/// or 3D grid).
		/// </summary>
		// Token: 0x06012441 RID: 74817 RVA: 0x00199778 File Offset: 0x00197978
		public virtual void GetVOI(IntPtr data)
		{
			vtkExtractGrid.vtkExtractGrid_GetVOI_07(base.GetCppThis(), data);
		}

		// Token: 0x06012442 RID: 74818
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGrid_IncludeBoundaryOff_08(HandleRef pThis);

		/// <summary>
		/// Control whether to enforce that the "boundary" of the grid is output in
		/// the subsampling process. (This ivar only has effect when the SampleRate
		/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
		/// on, the subsampling will always include the boundary of the grid even
		/// though the sample rate is not an even multiple of the grid
		/// dimensions. (By default IncludeBoundary is off.)
		/// </summary>
		// Token: 0x06012443 RID: 74819 RVA: 0x00199788 File Offset: 0x00197988
		public virtual void IncludeBoundaryOff()
		{
			vtkExtractGrid.vtkExtractGrid_IncludeBoundaryOff_08(base.GetCppThis());
		}

		// Token: 0x06012444 RID: 74820
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGrid_IncludeBoundaryOn_09(HandleRef pThis);

		/// <summary>
		/// Control whether to enforce that the "boundary" of the grid is output in
		/// the subsampling process. (This ivar only has effect when the SampleRate
		/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
		/// on, the subsampling will always include the boundary of the grid even
		/// though the sample rate is not an even multiple of the grid
		/// dimensions. (By default IncludeBoundary is off.)
		/// </summary>
		// Token: 0x06012445 RID: 74821 RVA: 0x00199797 File Offset: 0x00197997
		public virtual void IncludeBoundaryOn()
		{
			vtkExtractGrid.vtkExtractGrid_IncludeBoundaryOn_09(base.GetCppThis());
		}

		// Token: 0x06012446 RID: 74822
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractGrid_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012447 RID: 74823 RVA: 0x001997A8 File Offset: 0x001979A8
		public override int IsA(string type)
		{
			return vtkExtractGrid.vtkExtractGrid_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06012448 RID: 74824
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractGrid_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012449 RID: 74825 RVA: 0x001997C8 File Offset: 0x001979C8
		public new static int IsTypeOf(string type)
		{
			return vtkExtractGrid.vtkExtractGrid_IsTypeOf_11(type);
		}

		// Token: 0x0601244A RID: 74826
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGrid_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601244B RID: 74827 RVA: 0x001997E4 File Offset: 0x001979E4
		public new vtkExtractGrid NewInstance()
		{
			vtkExtractGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractGrid.vtkExtractGrid_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601244C RID: 74828
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGrid_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601244D RID: 74829 RVA: 0x00199840 File Offset: 0x00197A40
		public new static vtkExtractGrid SafeDownCast(vtkObjectBase o)
		{
			vtkExtractGrid vtkExtractGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractGrid.vtkExtractGrid_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractGrid = (vtkExtractGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractGrid.Register(null);
				}
			}
			return vtkExtractGrid;
		}

		// Token: 0x0601244E RID: 74830
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGrid_SetIncludeBoundary_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether to enforce that the "boundary" of the grid is output in
		/// the subsampling process. (This ivar only has effect when the SampleRate
		/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
		/// on, the subsampling will always include the boundary of the grid even
		/// though the sample rate is not an even multiple of the grid
		/// dimensions. (By default IncludeBoundary is off.)
		/// </summary>
		// Token: 0x0601244F RID: 74831 RVA: 0x001998BF File Offset: 0x00197ABF
		public virtual void SetIncludeBoundary(int _arg)
		{
			vtkExtractGrid.vtkExtractGrid_SetIncludeBoundary_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06012450 RID: 74832
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGrid_SetSampleRate_16(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set the sampling rate in the i, j, and k directions. If the rate is &gt; 1,
		/// then the resulting VOI will be subsampled representation of the input.
		/// For example, if the SampleRate=(2,2,2), every other point will be
		/// selected, resulting in a volume 1/8th the original size.
		/// Initial value is (1,1,1).
		/// </summary>
		// Token: 0x06012451 RID: 74833 RVA: 0x001998CF File Offset: 0x00197ACF
		public virtual void SetSampleRate(int _arg1, int _arg2, int _arg3)
		{
			vtkExtractGrid.vtkExtractGrid_SetSampleRate_16(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06012452 RID: 74834
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGrid_SetSampleRate_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the sampling rate in the i, j, and k directions. If the rate is &gt; 1,
		/// then the resulting VOI will be subsampled representation of the input.
		/// For example, if the SampleRate=(2,2,2), every other point will be
		/// selected, resulting in a volume 1/8th the original size.
		/// Initial value is (1,1,1).
		/// </summary>
		// Token: 0x06012453 RID: 74835 RVA: 0x001998E1 File Offset: 0x00197AE1
		public virtual void SetSampleRate(IntPtr _arg)
		{
			vtkExtractGrid.vtkExtractGrid_SetSampleRate_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06012454 RID: 74836
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGrid_SetVOI_18(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Specify i-j-k (min,max) pairs to extract. The resulting structured grid
		/// dataset can be of any topological dimension (i.e., point, line, plane,
		/// or 3D grid).
		/// </summary>
		// Token: 0x06012455 RID: 74837 RVA: 0x001998F1 File Offset: 0x00197AF1
		public virtual void SetVOI(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtractGrid.vtkExtractGrid_SetVOI_18(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06012456 RID: 74838
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGrid_SetVOI_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify i-j-k (min,max) pairs to extract. The resulting structured grid
		/// dataset can be of any topological dimension (i.e., point, line, plane,
		/// or 3D grid).
		/// </summary>
		// Token: 0x06012457 RID: 74839 RVA: 0x00199909 File Offset: 0x00197B09
		public virtual void SetVOI(IntPtr _arg)
		{
			vtkExtractGrid.vtkExtractGrid_SetVOI_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001506 RID: 5382
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001507 RID: 5383
		public new static readonly string MRClassNameKey = "class vtkExtractGrid";
	}
}
