using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractRectilinearGrid
	/// </summary>
	/// <remarks>
	///    Extract a sub grid (VOI) from the structured rectilinear dataset.
	///
	/// vtkExtractRectilinearGrid rounds out the set of filters that extract
	/// a subgrid out of a larger structured data set.  RIght now, this filter
	/// only supports extracting a VOI.  In the future, it might support
	/// strides like the vtkExtract grid filter.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExtractGrid vtkImageClip vtkGeometryFilter vtkExtractGeometry vtkExtractVOI
	/// vtkStructuredGridGeometryFilter
	/// </seealso>
	// Token: 0x020006B0 RID: 1712
	public class vtkExtractRectilinearGrid : vtkRectilinearGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060124B6 RID: 74934 RVA: 0x0019A1CB File Offset: 0x001983CB
		static vtkExtractRectilinearGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractRectilinearGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractRectilinearGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060124B7 RID: 74935 RVA: 0x0019A1F3 File Offset: 0x001983F3
		public vtkExtractRectilinearGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060124B8 RID: 74936
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractRectilinearGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124B9 RID: 74937 RVA: 0x0019A204 File Offset: 0x00198404
		public new static vtkExtractRectilinearGrid New()
		{
			vtkExtractRectilinearGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124BA RID: 74938 RVA: 0x0019A258 File Offset: 0x00198458
		public vtkExtractRectilinearGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060124BB RID: 74939 RVA: 0x0019A29C File Offset: 0x0019849C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060124BC RID: 74940
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractRectilinearGrid_GetIncludeBoundary_01(HandleRef pThis);

		/// <summary>
		/// Control whether to enforce that the "boundary" of the grid is output in
		/// the subsampling process. (This ivar only has effect when the SampleRate
		/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
		/// on, the subsampling will always include the boundary of the grid even
		/// though the sample rate is not an even multiple of the grid
		/// dimensions. (By default IncludeBoundary is off.)
		/// </summary>
		// Token: 0x060124BD RID: 74941 RVA: 0x0019A2A8 File Offset: 0x001984A8
		public virtual int GetIncludeBoundary()
		{
			return vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_GetIncludeBoundary_01(base.GetCppThis());
		}

		// Token: 0x060124BE RID: 74942
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractRectilinearGrid_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124BF RID: 74943 RVA: 0x0019A2C8 File Offset: 0x001984C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060124C0 RID: 74944
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractRectilinearGrid_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124C1 RID: 74945 RVA: 0x0019A2E8 File Offset: 0x001984E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060124C2 RID: 74946
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractRectilinearGrid_GetSampleRate_04(HandleRef pThis);

		/// <summary>
		/// Set the sampling rate in the i, j, and k directions. If the rate is &gt; 1,
		/// then the resulting VOI will be subsampled representation of the input.
		/// For example, if the SampleRate=(2,2,2), every other point will be
		/// selected, resulting in a volume 1/8th the original size.
		/// Initial value is (1,1,1).
		/// </summary>
		// Token: 0x060124C3 RID: 74947 RVA: 0x0019A304 File Offset: 0x00198504
		public virtual int[] GetSampleRate()
		{
			IntPtr intPtr = vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_GetSampleRate_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060124C4 RID: 74948
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractRectilinearGrid_GetSampleRate_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the sampling rate in the i, j, and k directions. If the rate is &gt; 1,
		/// then the resulting VOI will be subsampled representation of the input.
		/// For example, if the SampleRate=(2,2,2), every other point will be
		/// selected, resulting in a volume 1/8th the original size.
		/// Initial value is (1,1,1).
		/// </summary>
		// Token: 0x060124C5 RID: 74949 RVA: 0x0019A34C File Offset: 0x0019854C
		public virtual void GetSampleRate(IntPtr data)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_GetSampleRate_05(base.GetCppThis(), data);
		}

		// Token: 0x060124C6 RID: 74950
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractRectilinearGrid_GetVOI_06(HandleRef pThis);

		/// <summary>
		/// Specify i-j-k (min,max) pairs to extract. The resulting structured grid
		/// dataset can be of any topological dimension (i.e., point, line, plane,
		/// or 3D grid).
		/// </summary>
		// Token: 0x060124C7 RID: 74951 RVA: 0x0019A35C File Offset: 0x0019855C
		public virtual int[] GetVOI()
		{
			IntPtr intPtr = vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_GetVOI_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060124C8 RID: 74952
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractRectilinearGrid_GetVOI_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify i-j-k (min,max) pairs to extract. The resulting structured grid
		/// dataset can be of any topological dimension (i.e., point, line, plane,
		/// or 3D grid).
		/// </summary>
		// Token: 0x060124C9 RID: 74953 RVA: 0x0019A3A4 File Offset: 0x001985A4
		public virtual void GetVOI(IntPtr data)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_GetVOI_07(base.GetCppThis(), data);
		}

		// Token: 0x060124CA RID: 74954
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractRectilinearGrid_IncludeBoundaryOff_08(HandleRef pThis);

		/// <summary>
		/// Control whether to enforce that the "boundary" of the grid is output in
		/// the subsampling process. (This ivar only has effect when the SampleRate
		/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
		/// on, the subsampling will always include the boundary of the grid even
		/// though the sample rate is not an even multiple of the grid
		/// dimensions. (By default IncludeBoundary is off.)
		/// </summary>
		// Token: 0x060124CB RID: 74955 RVA: 0x0019A3B4 File Offset: 0x001985B4
		public virtual void IncludeBoundaryOff()
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_IncludeBoundaryOff_08(base.GetCppThis());
		}

		// Token: 0x060124CC RID: 74956
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractRectilinearGrid_IncludeBoundaryOn_09(HandleRef pThis);

		/// <summary>
		/// Control whether to enforce that the "boundary" of the grid is output in
		/// the subsampling process. (This ivar only has effect when the SampleRate
		/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
		/// on, the subsampling will always include the boundary of the grid even
		/// though the sample rate is not an even multiple of the grid
		/// dimensions. (By default IncludeBoundary is off.)
		/// </summary>
		// Token: 0x060124CD RID: 74957 RVA: 0x0019A3C3 File Offset: 0x001985C3
		public virtual void IncludeBoundaryOn()
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_IncludeBoundaryOn_09(base.GetCppThis());
		}

		// Token: 0x060124CE RID: 74958
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractRectilinearGrid_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124CF RID: 74959 RVA: 0x0019A3D4 File Offset: 0x001985D4
		public override int IsA(string type)
		{
			return vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060124D0 RID: 74960
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractRectilinearGrid_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124D1 RID: 74961 RVA: 0x0019A3F4 File Offset: 0x001985F4
		public new static int IsTypeOf(string type)
		{
			return vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_IsTypeOf_11(type);
		}

		// Token: 0x060124D2 RID: 74962
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractRectilinearGrid_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124D3 RID: 74963 RVA: 0x0019A410 File Offset: 0x00198610
		public new vtkExtractRectilinearGrid NewInstance()
		{
			vtkExtractRectilinearGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060124D4 RID: 74964
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractRectilinearGrid_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124D5 RID: 74965 RVA: 0x0019A46C File Offset: 0x0019866C
		public new static vtkExtractRectilinearGrid SafeDownCast(vtkObjectBase o)
		{
			vtkExtractRectilinearGrid vtkExtractRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractRectilinearGrid = (vtkExtractRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractRectilinearGrid.Register(null);
				}
			}
			return vtkExtractRectilinearGrid;
		}

		// Token: 0x060124D6 RID: 74966
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractRectilinearGrid_SetIncludeBoundary_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether to enforce that the "boundary" of the grid is output in
		/// the subsampling process. (This ivar only has effect when the SampleRate
		/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
		/// on, the subsampling will always include the boundary of the grid even
		/// though the sample rate is not an even multiple of the grid
		/// dimensions. (By default IncludeBoundary is off.)
		/// </summary>
		// Token: 0x060124D7 RID: 74967 RVA: 0x0019A4EB File Offset: 0x001986EB
		public virtual void SetIncludeBoundary(int _arg)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_SetIncludeBoundary_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060124D8 RID: 74968
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractRectilinearGrid_SetSampleRate_16(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set the sampling rate in the i, j, and k directions. If the rate is &gt; 1,
		/// then the resulting VOI will be subsampled representation of the input.
		/// For example, if the SampleRate=(2,2,2), every other point will be
		/// selected, resulting in a volume 1/8th the original size.
		/// Initial value is (1,1,1).
		/// </summary>
		// Token: 0x060124D9 RID: 74969 RVA: 0x0019A4FB File Offset: 0x001986FB
		public virtual void SetSampleRate(int _arg1, int _arg2, int _arg3)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_SetSampleRate_16(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060124DA RID: 74970
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractRectilinearGrid_SetSampleRate_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the sampling rate in the i, j, and k directions. If the rate is &gt; 1,
		/// then the resulting VOI will be subsampled representation of the input.
		/// For example, if the SampleRate=(2,2,2), every other point will be
		/// selected, resulting in a volume 1/8th the original size.
		/// Initial value is (1,1,1).
		/// </summary>
		// Token: 0x060124DB RID: 74971 RVA: 0x0019A50D File Offset: 0x0019870D
		public virtual void SetSampleRate(IntPtr _arg)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_SetSampleRate_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060124DC RID: 74972
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractRectilinearGrid_SetVOI_18(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Specify i-j-k (min,max) pairs to extract. The resulting structured grid
		/// dataset can be of any topological dimension (i.e., point, line, plane,
		/// or 3D grid).
		/// </summary>
		// Token: 0x060124DD RID: 74973 RVA: 0x0019A51D File Offset: 0x0019871D
		public virtual void SetVOI(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_SetVOI_18(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x060124DE RID: 74974
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractRectilinearGrid_SetVOI_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify i-j-k (min,max) pairs to extract. The resulting structured grid
		/// dataset can be of any topological dimension (i.e., point, line, plane,
		/// or 3D grid).
		/// </summary>
		// Token: 0x060124DF RID: 74975 RVA: 0x0019A535 File Offset: 0x00198735
		public virtual void SetVOI(IntPtr _arg)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_SetVOI_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400150E RID: 5390
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractRectilinearGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400150F RID: 5391
		public new static readonly string MRClassNameKey = "class vtkExtractRectilinearGrid";
	}
}
