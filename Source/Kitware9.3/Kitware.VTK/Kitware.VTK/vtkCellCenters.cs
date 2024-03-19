using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellCenters
	/// </summary>
	/// <remarks>
	///    generate points at center of cells
	///
	/// vtkCellCenters is a filter that takes as input any dataset and
	/// generates on output points at the center of the cells in the dataset.
	/// These points can be used for placing glyphs (vtkGlyph3D) or labeling
	/// (vtkLabeledDataMapper). (The center is the parametric center of the
	/// cell, not necessarily the geometric or bounding box center.) The cell
	/// attributes will be associated with the points on output.
	///
	/// @warning
	/// You can choose to generate just points or points and vertex cells.
	/// Vertex cells are drawn during rendering; points are not. Use the ivar
	/// VertexCells to generate cells.
	///
	/// @note
	/// Empty cells will be ignored but will require a one by one cell to
	/// point data copy that will make the processing slower.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGlyph3D vtkLabeledDataMapper
	/// </seealso>
	// Token: 0x02000947 RID: 2375
	public class vtkCellCenters : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060189DE RID: 100830 RVA: 0x00226529 File Offset: 0x00224729
		static vtkCellCenters()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellCenters.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellCenters"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060189DF RID: 100831 RVA: 0x00226551 File Offset: 0x00224751
		public vtkCellCenters(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060189E0 RID: 100832
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellCenters_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with vertex cell generation turned off.
		/// </summary>
		// Token: 0x060189E1 RID: 100833 RVA: 0x00226560 File Offset: 0x00224760
		public new static vtkCellCenters New()
		{
			vtkCellCenters result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellCenters.vtkCellCenters_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellCenters)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with vertex cell generation turned off.
		/// </summary>
		// Token: 0x060189E2 RID: 100834 RVA: 0x002265B4 File Offset: 0x002247B4
		public vtkCellCenters() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellCenters.vtkCellCenters_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060189E3 RID: 100835 RVA: 0x002265F8 File Offset: 0x002247F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060189E4 RID: 100836
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellCenters_ComputeCellCenters_01(HandleRef dataset, HandleRef centers);

		/// <summary>
		/// Compute centers of cells from a dataset, storing them in the centers array.
		/// </summary>
		// Token: 0x060189E5 RID: 100837 RVA: 0x00226604 File Offset: 0x00224804
		public static void ComputeCellCenters(vtkDataSet dataset, vtkDoubleArray centers)
		{
			vtkCellCenters.vtkCellCenters_ComputeCellCenters_01((dataset == null) ? default(HandleRef) : dataset.GetCppThis(), (centers == null) ? default(HandleRef) : centers.GetCppThis());
		}

		// Token: 0x060189E6 RID: 100838
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellCenters_CopyArraysOff_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable whether input cell data arrays should be passed through (or
		/// copied) as output point data arrays. Default is `true` i.e. the arrays will
		/// be propagated.
		/// </summary>
		// Token: 0x060189E7 RID: 100839 RVA: 0x00226642 File Offset: 0x00224842
		public virtual void CopyArraysOff()
		{
			vtkCellCenters.vtkCellCenters_CopyArraysOff_02(base.GetCppThis());
		}

		// Token: 0x060189E8 RID: 100840
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellCenters_CopyArraysOn_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable whether input cell data arrays should be passed through (or
		/// copied) as output point data arrays. Default is `true` i.e. the arrays will
		/// be propagated.
		/// </summary>
		// Token: 0x060189E9 RID: 100841 RVA: 0x00226651 File Offset: 0x00224851
		public virtual void CopyArraysOn()
		{
			vtkCellCenters.vtkCellCenters_CopyArraysOn_03(base.GetCppThis());
		}

		// Token: 0x060189EA RID: 100842
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellCenters_GetCopyArrays_04(HandleRef pThis);

		/// <summary>
		/// Enable/disable whether input cell data arrays should be passed through (or
		/// copied) as output point data arrays. Default is `true` i.e. the arrays will
		/// be propagated.
		/// </summary>
		// Token: 0x060189EB RID: 100843 RVA: 0x00226660 File Offset: 0x00224860
		public virtual bool GetCopyArrays()
		{
			return vtkCellCenters.vtkCellCenters_GetCopyArrays_04(base.GetCppThis()) != 0;
		}

		// Token: 0x060189EC RID: 100844
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellCenters_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060189ED RID: 100845 RVA: 0x00226688 File Offset: 0x00224888
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellCenters.vtkCellCenters_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060189EE RID: 100846
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellCenters_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060189EF RID: 100847 RVA: 0x002266A8 File Offset: 0x002248A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellCenters.vtkCellCenters_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060189F0 RID: 100848
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellCenters_GetVertexCells_07(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of vertex cells. The default
		/// is Off.
		/// </summary>
		// Token: 0x060189F1 RID: 100849 RVA: 0x002266C4 File Offset: 0x002248C4
		public virtual bool GetVertexCells()
		{
			return vtkCellCenters.vtkCellCenters_GetVertexCells_07(base.GetCppThis()) != 0;
		}

		// Token: 0x060189F2 RID: 100850
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCenters_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060189F3 RID: 100851 RVA: 0x002266EC File Offset: 0x002248EC
		public override int IsA(string type)
		{
			return vtkCellCenters.vtkCellCenters_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060189F4 RID: 100852
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCenters_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060189F5 RID: 100853 RVA: 0x0022670C File Offset: 0x0022490C
		public new static int IsTypeOf(string type)
		{
			return vtkCellCenters.vtkCellCenters_IsTypeOf_09(type);
		}

		// Token: 0x060189F6 RID: 100854
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellCenters_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060189F7 RID: 100855 RVA: 0x00226728 File Offset: 0x00224928
		public new vtkCellCenters NewInstance()
		{
			vtkCellCenters result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellCenters.vtkCellCenters_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellCenters)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060189F8 RID: 100856
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellCenters_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060189F9 RID: 100857 RVA: 0x00226784 File Offset: 0x00224984
		public new static vtkCellCenters SafeDownCast(vtkObjectBase o)
		{
			vtkCellCenters vtkCellCenters = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellCenters.vtkCellCenters_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellCenters = (vtkCellCenters)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellCenters.Register(null);
				}
			}
			return vtkCellCenters;
		}

		// Token: 0x060189FA RID: 100858
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellCenters_SetCopyArrays_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable whether input cell data arrays should be passed through (or
		/// copied) as output point data arrays. Default is `true` i.e. the arrays will
		/// be propagated.
		/// </summary>
		// Token: 0x060189FB RID: 100859 RVA: 0x00226803 File Offset: 0x00224A03
		public virtual void SetCopyArrays(bool _arg)
		{
			vtkCellCenters.vtkCellCenters_SetCopyArrays_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060189FC RID: 100860
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellCenters_SetVertexCells_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable the generation of vertex cells. The default
		/// is Off.
		/// </summary>
		// Token: 0x060189FD RID: 100861 RVA: 0x0022681B File Offset: 0x00224A1B
		public virtual void SetVertexCells(bool _arg)
		{
			vtkCellCenters.vtkCellCenters_SetVertexCells_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060189FE RID: 100862
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellCenters_VertexCellsOff_15(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of vertex cells. The default
		/// is Off.
		/// </summary>
		// Token: 0x060189FF RID: 100863 RVA: 0x00226833 File Offset: 0x00224A33
		public virtual void VertexCellsOff()
		{
			vtkCellCenters.vtkCellCenters_VertexCellsOff_15(base.GetCppThis());
		}

		// Token: 0x06018A00 RID: 100864
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellCenters_VertexCellsOn_16(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of vertex cells. The default
		/// is Off.
		/// </summary>
		// Token: 0x06018A01 RID: 100865 RVA: 0x00226842 File Offset: 0x00224A42
		public virtual void VertexCellsOn()
		{
			vtkCellCenters.vtkCellCenters_VertexCellsOn_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B42 RID: 6978
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellCenters";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B43 RID: 6979
		public new static readonly string MRClassNameKey = "class vtkCellCenters";
	}
}
