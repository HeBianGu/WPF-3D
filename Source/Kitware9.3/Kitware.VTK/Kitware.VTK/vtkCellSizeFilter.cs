using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellSizeFilter
	/// </summary>
	/// <remarks>
	///    Computes cell sizes.
	///
	/// Computes the cell sizes for all types of cells in VTK. For triangles,
	/// quads, tets and hexes the static methods in vtkMeshQuality are used.
	/// This is done through Verdict for higher accuracy.
	/// Other cell types are individually done analytically where possible
	/// and breaking into triangles or tets when not possible. When cells are
	/// broken into triangles or tets the accuracy may be diminished. By default
	/// all sizes are computed but vertex count, length, area and volumetric cells
	/// can each be optionally ignored. Individual arrays are used for each
	/// requested size (e.g. if length and volume are requested there will be
	/// two arrays outputted from this filter). The 4 arrays can be individually
	/// named with defaults of VertexCount, Length, Area and Volme. For dimensions
	/// of cells that do not have their size computed, a value of 0 will be given.
	/// For cells that should have their size computed but can't, the filter will return -1.
	/// The ComputeSum option will sum the cell sizes (excluding ghost cells)
	/// and put the value into vtkFieldData arrays named with the corresponding cell
	/// data array name. For composite datasets the total sum over all blocks will
	/// also be added to the top-level block's field data for the summation.
	/// </remarks>
	// Token: 0x020008FF RID: 2303
	public class vtkCellSizeFilter : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017CBF RID: 97471 RVA: 0x002159D8 File Offset: 0x00213BD8
		static vtkCellSizeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellSizeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellSizeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017CC0 RID: 97472 RVA: 0x00215A00 File Offset: 0x00213C00
		public vtkCellSizeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017CC1 RID: 97473
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellSizeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017CC2 RID: 97474 RVA: 0x00215A10 File Offset: 0x00213C10
		public new static vtkCellSizeFilter New()
		{
			vtkCellSizeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellSizeFilter.vtkCellSizeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellSizeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017CC3 RID: 97475 RVA: 0x00215A64 File Offset: 0x00213C64
		public vtkCellSizeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellSizeFilter.vtkCellSizeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017CC4 RID: 97476 RVA: 0x00215AA8 File Offset: 0x00213CA8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017CC5 RID: 97477
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_ComputeAreaOff_01(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to compute sizes for 2D cells
		/// cells. The computed value is the area of the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CC6 RID: 97478 RVA: 0x00215AB3 File Offset: 0x00213CB3
		public virtual void ComputeAreaOff()
		{
			vtkCellSizeFilter.vtkCellSizeFilter_ComputeAreaOff_01(base.GetCppThis());
		}

		// Token: 0x06017CC7 RID: 97479
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_ComputeAreaOn_02(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to compute sizes for 2D cells
		/// cells. The computed value is the area of the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CC8 RID: 97480 RVA: 0x00215AC2 File Offset: 0x00213CC2
		public virtual void ComputeAreaOn()
		{
			vtkCellSizeFilter.vtkCellSizeFilter_ComputeAreaOn_02(base.GetCppThis());
		}

		// Token: 0x06017CC9 RID: 97481
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_ComputeLengthOff_03(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to compute sizes for 1D cells
		/// cells. The computed value is the length of the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CCA RID: 97482 RVA: 0x00215AD1 File Offset: 0x00213CD1
		public virtual void ComputeLengthOff()
		{
			vtkCellSizeFilter.vtkCellSizeFilter_ComputeLengthOff_03(base.GetCppThis());
		}

		// Token: 0x06017CCB RID: 97483
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_ComputeLengthOn_04(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to compute sizes for 1D cells
		/// cells. The computed value is the length of the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CCC RID: 97484 RVA: 0x00215AE0 File Offset: 0x00213CE0
		public virtual void ComputeLengthOn()
		{
			vtkCellSizeFilter.vtkCellSizeFilter_ComputeLengthOn_04(base.GetCppThis());
		}

		// Token: 0x06017CCD RID: 97485
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_ComputeSumOff_05(HandleRef pThis);

		/// <summary>
		/// Specify whether to sum the computed sizes and put the result in
		/// a field data array. This option is disabled by default.
		/// </summary>
		// Token: 0x06017CCE RID: 97486 RVA: 0x00215AEF File Offset: 0x00213CEF
		public virtual void ComputeSumOff()
		{
			vtkCellSizeFilter.vtkCellSizeFilter_ComputeSumOff_05(base.GetCppThis());
		}

		// Token: 0x06017CCF RID: 97487
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_ComputeSumOn_06(HandleRef pThis);

		/// <summary>
		/// Specify whether to sum the computed sizes and put the result in
		/// a field data array. This option is disabled by default.
		/// </summary>
		// Token: 0x06017CD0 RID: 97488 RVA: 0x00215AFE File Offset: 0x00213CFE
		public virtual void ComputeSumOn()
		{
			vtkCellSizeFilter.vtkCellSizeFilter_ComputeSumOn_06(base.GetCppThis());
		}

		// Token: 0x06017CD1 RID: 97489
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_ComputeVertexCountOff_07(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to compute sizes for vertex and polyvertex
		/// cells. The computed value is the number of points in the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CD2 RID: 97490 RVA: 0x00215B0D File Offset: 0x00213D0D
		public virtual void ComputeVertexCountOff()
		{
			vtkCellSizeFilter.vtkCellSizeFilter_ComputeVertexCountOff_07(base.GetCppThis());
		}

		// Token: 0x06017CD3 RID: 97491
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_ComputeVertexCountOn_08(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to compute sizes for vertex and polyvertex
		/// cells. The computed value is the number of points in the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CD4 RID: 97492 RVA: 0x00215B1C File Offset: 0x00213D1C
		public virtual void ComputeVertexCountOn()
		{
			vtkCellSizeFilter.vtkCellSizeFilter_ComputeVertexCountOn_08(base.GetCppThis());
		}

		// Token: 0x06017CD5 RID: 97493
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_ComputeVolumeOff_09(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to compute sizes for 3D cells
		/// cells. The computed value is the volume of the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CD6 RID: 97494 RVA: 0x00215B2B File Offset: 0x00213D2B
		public virtual void ComputeVolumeOff()
		{
			vtkCellSizeFilter.vtkCellSizeFilter_ComputeVolumeOff_09(base.GetCppThis());
		}

		// Token: 0x06017CD7 RID: 97495
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_ComputeVolumeOn_10(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to compute sizes for 3D cells
		/// cells. The computed value is the volume of the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CD8 RID: 97496 RVA: 0x00215B3A File Offset: 0x00213D3A
		public virtual void ComputeVolumeOn()
		{
			vtkCellSizeFilter.vtkCellSizeFilter_ComputeVolumeOn_10(base.GetCppThis());
		}

		// Token: 0x06017CD9 RID: 97497
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellSizeFilter_GetAreaArrayName_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the computed arrays. Default names are VertexCount,
		/// Length, Area and Volume.
		/// </summary>
		// Token: 0x06017CDA RID: 97498 RVA: 0x00215B4C File Offset: 0x00213D4C
		public virtual string GetAreaArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCellSizeFilter.vtkCellSizeFilter_GetAreaArrayName_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017CDB RID: 97499
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellSizeFilter_GetComputeArea_12(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to compute sizes for 2D cells
		/// cells. The computed value is the area of the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CDC RID: 97500 RVA: 0x00215B88 File Offset: 0x00213D88
		public virtual bool GetComputeArea()
		{
			return vtkCellSizeFilter.vtkCellSizeFilter_GetComputeArea_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06017CDD RID: 97501
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellSizeFilter_GetComputeLength_13(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to compute sizes for 1D cells
		/// cells. The computed value is the length of the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CDE RID: 97502 RVA: 0x00215BB0 File Offset: 0x00213DB0
		public virtual bool GetComputeLength()
		{
			return vtkCellSizeFilter.vtkCellSizeFilter_GetComputeLength_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06017CDF RID: 97503
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellSizeFilter_GetComputeSum_14(HandleRef pThis);

		/// <summary>
		/// Specify whether to sum the computed sizes and put the result in
		/// a field data array. This option is disabled by default.
		/// </summary>
		// Token: 0x06017CE0 RID: 97504 RVA: 0x00215BD8 File Offset: 0x00213DD8
		public virtual bool GetComputeSum()
		{
			return vtkCellSizeFilter.vtkCellSizeFilter_GetComputeSum_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06017CE1 RID: 97505
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellSizeFilter_GetComputeVertexCount_15(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to compute sizes for vertex and polyvertex
		/// cells. The computed value is the number of points in the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CE2 RID: 97506 RVA: 0x00215C00 File Offset: 0x00213E00
		public virtual bool GetComputeVertexCount()
		{
			return vtkCellSizeFilter.vtkCellSizeFilter_GetComputeVertexCount_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06017CE3 RID: 97507
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellSizeFilter_GetComputeVolume_16(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to compute sizes for 3D cells
		/// cells. The computed value is the volume of the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CE4 RID: 97508 RVA: 0x00215C28 File Offset: 0x00213E28
		public virtual bool GetComputeVolume()
		{
			return vtkCellSizeFilter.vtkCellSizeFilter_GetComputeVolume_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06017CE5 RID: 97509
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellSizeFilter_GetLengthArrayName_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the computed arrays. Default names are VertexCount,
		/// Length, Area and Volume.
		/// </summary>
		// Token: 0x06017CE6 RID: 97510 RVA: 0x00215C50 File Offset: 0x00213E50
		public virtual string GetLengthArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCellSizeFilter.vtkCellSizeFilter_GetLengthArrayName_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017CE7 RID: 97511
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellSizeFilter_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017CE8 RID: 97512 RVA: 0x00215C8C File Offset: 0x00213E8C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellSizeFilter.vtkCellSizeFilter_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06017CE9 RID: 97513
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellSizeFilter_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017CEA RID: 97514 RVA: 0x00215CAC File Offset: 0x00213EAC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellSizeFilter.vtkCellSizeFilter_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06017CEB RID: 97515
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellSizeFilter_GetVertexCountArrayName_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the computed arrays. Default names are VertexCount,
		/// Length, Area and Volume.
		/// </summary>
		// Token: 0x06017CEC RID: 97516 RVA: 0x00215CC8 File Offset: 0x00213EC8
		public virtual string GetVertexCountArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCellSizeFilter.vtkCellSizeFilter_GetVertexCountArrayName_20(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017CED RID: 97517
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellSizeFilter_GetVolumeArrayName_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the computed arrays. Default names are VertexCount,
		/// Length, Area and Volume.
		/// </summary>
		// Token: 0x06017CEE RID: 97518 RVA: 0x00215D04 File Offset: 0x00213F04
		public virtual string GetVolumeArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCellSizeFilter.vtkCellSizeFilter_GetVolumeArrayName_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017CEF RID: 97519
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellSizeFilter_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017CF0 RID: 97520 RVA: 0x00215D40 File Offset: 0x00213F40
		public override int IsA(string type)
		{
			return vtkCellSizeFilter.vtkCellSizeFilter_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06017CF1 RID: 97521
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellSizeFilter_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017CF2 RID: 97522 RVA: 0x00215D60 File Offset: 0x00213F60
		public new static int IsTypeOf(string type)
		{
			return vtkCellSizeFilter.vtkCellSizeFilter_IsTypeOf_23(type);
		}

		// Token: 0x06017CF3 RID: 97523
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellSizeFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017CF4 RID: 97524 RVA: 0x00215D7C File Offset: 0x00213F7C
		public new vtkCellSizeFilter NewInstance()
		{
			vtkCellSizeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellSizeFilter.vtkCellSizeFilter_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellSizeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017CF5 RID: 97525
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellSizeFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017CF6 RID: 97526 RVA: 0x00215DD8 File Offset: 0x00213FD8
		public new static vtkCellSizeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkCellSizeFilter vtkCellSizeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellSizeFilter.vtkCellSizeFilter_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellSizeFilter = (vtkCellSizeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellSizeFilter.Register(null);
				}
			}
			return vtkCellSizeFilter;
		}

		// Token: 0x06017CF7 RID: 97527
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_SetAreaArrayName_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the computed arrays. Default names are VertexCount,
		/// Length, Area and Volume.
		/// </summary>
		// Token: 0x06017CF8 RID: 97528 RVA: 0x00215E57 File Offset: 0x00214057
		public virtual void SetAreaArrayName(string _arg)
		{
			vtkCellSizeFilter.vtkCellSizeFilter_SetAreaArrayName_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06017CF9 RID: 97529
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_SetComputeArea_28(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether or not to compute sizes for 2D cells
		/// cells. The computed value is the area of the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CFA RID: 97530 RVA: 0x00215E67 File Offset: 0x00214067
		public virtual void SetComputeArea(bool _arg)
		{
			vtkCellSizeFilter.vtkCellSizeFilter_SetComputeArea_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017CFB RID: 97531
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_SetComputeLength_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether or not to compute sizes for 1D cells
		/// cells. The computed value is the length of the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017CFC RID: 97532 RVA: 0x00215E7F File Offset: 0x0021407F
		public virtual void SetComputeLength(bool _arg)
		{
			vtkCellSizeFilter.vtkCellSizeFilter_SetComputeLength_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017CFD RID: 97533
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_SetComputeSum_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether to sum the computed sizes and put the result in
		/// a field data array. This option is disabled by default.
		/// </summary>
		// Token: 0x06017CFE RID: 97534 RVA: 0x00215E97 File Offset: 0x00214097
		public virtual void SetComputeSum(bool _arg)
		{
			vtkCellSizeFilter.vtkCellSizeFilter_SetComputeSum_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017CFF RID: 97535
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_SetComputeVertexCount_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether or not to compute sizes for vertex and polyvertex
		/// cells. The computed value is the number of points in the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017D00 RID: 97536 RVA: 0x00215EAF File Offset: 0x002140AF
		public virtual void SetComputeVertexCount(bool _arg)
		{
			vtkCellSizeFilter.vtkCellSizeFilter_SetComputeVertexCount_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017D01 RID: 97537
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_SetComputeVolume_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether or not to compute sizes for 3D cells
		/// cells. The computed value is the volume of the cell.
		/// This option is enabled by default.
		/// </summary>
		// Token: 0x06017D02 RID: 97538 RVA: 0x00215EC7 File Offset: 0x002140C7
		public virtual void SetComputeVolume(bool _arg)
		{
			vtkCellSizeFilter.vtkCellSizeFilter_SetComputeVolume_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017D03 RID: 97539
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_SetLengthArrayName_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the computed arrays. Default names are VertexCount,
		/// Length, Area and Volume.
		/// </summary>
		// Token: 0x06017D04 RID: 97540 RVA: 0x00215EDF File Offset: 0x002140DF
		public virtual void SetLengthArrayName(string _arg)
		{
			vtkCellSizeFilter.vtkCellSizeFilter_SetLengthArrayName_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06017D05 RID: 97541
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_SetVertexCountArrayName_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the computed arrays. Default names are VertexCount,
		/// Length, Area and Volume.
		/// </summary>
		// Token: 0x06017D06 RID: 97542 RVA: 0x00215EEF File Offset: 0x002140EF
		public virtual void SetVertexCountArrayName(string _arg)
		{
			vtkCellSizeFilter.vtkCellSizeFilter_SetVertexCountArrayName_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06017D07 RID: 97543
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellSizeFilter_SetVolumeArrayName_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the computed arrays. Default names are VertexCount,
		/// Length, Area and Volume.
		/// </summary>
		// Token: 0x06017D08 RID: 97544 RVA: 0x00215EFF File Offset: 0x002140FF
		public virtual void SetVolumeArrayName(string _arg)
		{
			vtkCellSizeFilter.vtkCellSizeFilter_SetVolumeArrayName_35(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A7D RID: 6781
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellSizeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A7E RID: 6782
		public new static readonly string MRClassNameKey = "class vtkCellSizeFilter";
	}
}
