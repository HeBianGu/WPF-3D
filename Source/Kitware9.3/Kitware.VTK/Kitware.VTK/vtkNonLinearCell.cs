using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNonLinearCell
	/// </summary>
	/// <remarks>
	///    abstract superclass for non-linear cells
	///
	/// vtkNonLinearCell is an abstract superclass for non-linear cell types.
	/// Cells that are a direct subclass of vtkCell or vtkCell3D are linear;
	/// cells that are a subclass of vtkNonLinearCell have non-linear interpolation
	/// functions. Non-linear cells require special treatment when tessellating
	/// or converting to graphics primitives. Note that the linearity of the cell
	/// is a function of whether the cell needs tessellation, which does not
	/// strictly correlate with interpolation order (e.g., vtkHexahedron has
	/// non-linear interpolation functions (a product of three linear functions
	/// in r-s-t) even thought vtkHexahedron is considered linear.)
	/// </remarks>
	// Token: 0x020009FE RID: 2558
	public abstract class vtkNonLinearCell : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A8D1 RID: 108753 RVA: 0x0024E7D5 File Offset: 0x0024C9D5
		static vtkNonLinearCell()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNonLinearCell.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNonLinearCell"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A8D2 RID: 108754 RVA: 0x0024E7FD File Offset: 0x0024C9FD
		public vtkNonLinearCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A8D3 RID: 108755 RVA: 0x0024E80B File Offset: 0x0024CA0B
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A8D4 RID: 108756
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNonLinearCell_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A8D5 RID: 108757 RVA: 0x0024E818 File Offset: 0x0024CA18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNonLinearCell.vtkNonLinearCell_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A8D6 RID: 108758
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNonLinearCell_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A8D7 RID: 108759 RVA: 0x0024E838 File Offset: 0x0024CA38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNonLinearCell.vtkNonLinearCell_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A8D8 RID: 108760
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNonLinearCell_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A8D9 RID: 108761 RVA: 0x0024E854 File Offset: 0x0024CA54
		public override int IsA(string type)
		{
			return vtkNonLinearCell.vtkNonLinearCell_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A8DA RID: 108762
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNonLinearCell_IsLinear_04(HandleRef pThis);

		/// <summary>
		/// Non-linear cells require special treatment (tessellation) when
		/// converting to graphics primitives (during mapping). The vtkCell
		/// API IsLinear() is modified to indicate this requirement.
		/// </summary>
		// Token: 0x0601A8DB RID: 108763 RVA: 0x0024E874 File Offset: 0x0024CA74
		public override int IsLinear()
		{
			return vtkNonLinearCell.vtkNonLinearCell_IsLinear_04(base.GetCppThis());
		}

		// Token: 0x0601A8DC RID: 108764
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNonLinearCell_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A8DD RID: 108765 RVA: 0x0024E894 File Offset: 0x0024CA94
		public new static int IsTypeOf(string type)
		{
			return vtkNonLinearCell.vtkNonLinearCell_IsTypeOf_05(type);
		}

		// Token: 0x0601A8DE RID: 108766
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonLinearCell_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A8DF RID: 108767 RVA: 0x0024E8B0 File Offset: 0x0024CAB0
		public new vtkNonLinearCell NewInstance()
		{
			vtkNonLinearCell result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonLinearCell.vtkNonLinearCell_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNonLinearCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A8E0 RID: 108768
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonLinearCell_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A8E1 RID: 108769 RVA: 0x0024E90C File Offset: 0x0024CB0C
		public new static vtkNonLinearCell SafeDownCast(vtkObjectBase o)
		{
			vtkNonLinearCell vtkNonLinearCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonLinearCell.vtkNonLinearCell_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNonLinearCell = (vtkNonLinearCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNonLinearCell.Register(null);
				}
			}
			return vtkNonLinearCell;
		}

		// Token: 0x0601A8E2 RID: 108770
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkNonLinearCell_StableClip_08(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip the cell based on the input cellScalars and the
		/// specified value. The output of the clip operation will be one or
		/// more cells of the same topological dimension as the original cell.
		/// For more information see vtkCell::Clip.
		///
		/// This method differs from the vtkCell::Clip function in such a way
		/// that it tells more information about how the clipped cell was
		/// handled. For 2D cells vtkCell::Clip is expected to return either
		/// triangles, quads or polygon, and for 3D cells either tetras or
		/// wedges. However, it is interesting (especially for non linear cells)
		/// to be able to return the same cell type when the cell is totally
		/// inside or outside the clipping function. This Clip function
		/// resolves exactly this issue by returning a bool : if StableClip
		/// returns true then the newly inserted cell is the same type as the
		/// current cell, otherwise it will be one of the "expected" types
		/// as returned by vtkCell::Clip.
		///
		/// Note: This function could also benefit being moved to vtkCell but
		/// requires much more work to be supported by all cell types.
		///
		/// @see vtkCell::Clip
		/// </summary>
		// Token: 0x0601A8E3 RID: 108771 RVA: 0x0024E98C File Offset: 0x0024CB8C
		public virtual bool StableClip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			return vtkNonLinearCell.vtkNonLinearCell_StableClip_08(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CD4 RID: 7380
		public new const string MRFullTypeName = "Kitware.VTK.vtkNonLinearCell";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CD5 RID: 7381
		public new static readonly string MRClassNameKey = "class vtkNonLinearCell";
	}
}
