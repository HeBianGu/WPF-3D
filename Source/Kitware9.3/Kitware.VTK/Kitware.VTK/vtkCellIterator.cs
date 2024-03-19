using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellIterator
	/// </summary>
	/// <remarks>
	///    Efficient cell iterator for vtkDataSet topologies.
	///
	///
	/// vtkCellIterator provides a method for traversing cells in a data set. Call
	/// the vtkDataSet::NewCellIterator() method to use this class.
	///
	/// The cell is represented as a set of three pieces of information: The cell
	/// type, the ids of the points constituting the cell, and the points themselves.
	/// This iterator fetches these as needed. If only the cell type is used,
	/// the type is not looked up until GetCellType is called, and the point
	/// information is left uninitialized. This allows efficient screening of cells,
	/// since expensive point lookups may be skipped depending on the cell type/etc.
	///
	/// An example usage of this class:
	/// ~~~
	/// void myWorkerFunction(vtkDataSet *ds)
	/// {
	///   vtkCellIterator *it = ds-&gt;NewCellIterator();
	///   for (it-&gt;InitTraversal(); !it-&gt;IsDoneWithTraversal(); it-&gt;GoToNextCell())
	///     {
	///     if (it-&gt;GetCellType() != VTK_TETRA)
	///       {
	///       continue; // Skip non-tetrahedral cells
	///       }
	///
	///     vtkIdList *pointIds = it-&gt;GetPointIds();
	///     // Do screening on the point ids, maybe figure out scalar range and skip
	///        cells that do not lie in a certain range?
	///
	///     vtkPoints *points = it-&gt;GetPoints();
	///     // Do work using the cell points, or ...
	///
	///     vtkGenericCell *cell = ...;
	///     it-&gt;GetCell(cell);
	///     // ... do work with a vtkCell.
	///     }
	///   it-&gt;Delete();
	/// }
	/// ~~~
	///
	/// The example above pulls in bits of information as needed to filter out cells
	/// that aren't relevant. The least expensive lookups are performed first
	/// (cell type, then point ids, then points/full cell) to prevent wasted cycles
	/// fetching unnecessary data. Also note that at the end of the loop, the
	/// iterator must be deleted as these iterators are vtkObject subclasses.
	/// </remarks>
	// Token: 0x02000A26 RID: 2598
	public abstract class vtkCellIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B102 RID: 110850 RVA: 0x0025C626 File Offset: 0x0025A826
		static vtkCellIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B103 RID: 110851 RVA: 0x0025C64E File Offset: 0x0025A84E
		public vtkCellIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B104 RID: 110852 RVA: 0x0025C65C File Offset: 0x0025A85C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B105 RID: 110853
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellIterator_GetCell_01(HandleRef pThis, HandleRef cell);

		/// <summary>
		/// Write the current full cell information into the argument.
		/// This is usually a very expensive call, and should be avoided when possible.
		/// This should only be called when IsDoneWithTraversal() returns false.
		/// </summary>
		// Token: 0x0601B106 RID: 110854 RVA: 0x0025C668 File Offset: 0x0025A868
		public void GetCell(vtkGenericCell cell)
		{
			vtkCellIterator.vtkCellIterator_GetCell_01(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601B107 RID: 110855
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellIterator_GetCellDimension_02(HandleRef pThis);

		/// <summary>
		/// Get the current cell dimension (0, 1, 2, or 3). This should only be called
		/// when IsDoneWithTraversal() returns false.
		/// </summary>
		// Token: 0x0601B108 RID: 110856 RVA: 0x0025C698 File Offset: 0x0025A898
		public int GetCellDimension()
		{
			return vtkCellIterator.vtkCellIterator_GetCellDimension_02(base.GetCppThis());
		}

		// Token: 0x0601B109 RID: 110857
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellIterator_GetCellId_03(HandleRef pThis);

		/// <summary>
		/// Get the id of the current cell.
		/// </summary>
		// Token: 0x0601B10A RID: 110858 RVA: 0x0025C6B8 File Offset: 0x0025A8B8
		public virtual long GetCellId()
		{
			return vtkCellIterator.vtkCellIterator_GetCellId_03(base.GetCppThis());
		}

		// Token: 0x0601B10B RID: 110859
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellIterator_GetCellType_04(HandleRef pThis);

		/// <summary>
		/// Get the current cell type (e.g. VTK_LINE, VTK_VERTEX, VTK_TETRA, etc).
		/// This should only be called when IsDoneWithTraversal() returns false.
		/// </summary>
		// Token: 0x0601B10C RID: 110860 RVA: 0x0025C6D8 File Offset: 0x0025A8D8
		public int GetCellType()
		{
			return vtkCellIterator.vtkCellIterator_GetCellType_04(base.GetCppThis());
		}

		// Token: 0x0601B10D RID: 110861
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellIterator_GetFaces_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the faces for a polyhedral cell. This is only valid when CellType
		/// is VTK_POLYHEDRON.
		/// </summary>
		// Token: 0x0601B10E RID: 110862 RVA: 0x0025C6F8 File Offset: 0x0025A8F8
		public vtkIdList GetFaces()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellIterator.vtkCellIterator_GetFaces_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x0601B10F RID: 110863
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellIterator_GetNumberOfFaces_06(HandleRef pThis);

		/// <summary>
		/// Return the number of faces in the current cell.
		/// This should only be called when IsDoneWithTraversal() returns false.
		/// </summary>
		// Token: 0x0601B110 RID: 110864 RVA: 0x0025C768 File Offset: 0x0025A968
		public long GetNumberOfFaces()
		{
			return vtkCellIterator.vtkCellIterator_GetNumberOfFaces_06(base.GetCppThis());
		}

		// Token: 0x0601B111 RID: 110865
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellIterator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B112 RID: 110866 RVA: 0x0025C788 File Offset: 0x0025A988
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellIterator.vtkCellIterator_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601B113 RID: 110867
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellIterator_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B114 RID: 110868 RVA: 0x0025C7A8 File Offset: 0x0025A9A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellIterator.vtkCellIterator_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601B115 RID: 110869
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellIterator_GetNumberOfPoints_09(HandleRef pThis);

		/// <summary>
		/// Return the number of points in the current cell.
		/// This should only be called when IsDoneWithTraversal() returns false.
		/// </summary>
		// Token: 0x0601B116 RID: 110870 RVA: 0x0025C7C4 File Offset: 0x0025A9C4
		public long GetNumberOfPoints()
		{
			return vtkCellIterator.vtkCellIterator_GetNumberOfPoints_09(base.GetCppThis());
		}

		// Token: 0x0601B117 RID: 110871
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellIterator_GetPointIds_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the ids of the points in the current cell.
		/// This should only be called when IsDoneWithTraversal() returns false.
		/// </summary>
		// Token: 0x0601B118 RID: 110872 RVA: 0x0025C7E4 File Offset: 0x0025A9E4
		public vtkIdList GetPointIds()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellIterator.vtkCellIterator_GetPointIds_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x0601B119 RID: 110873
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellIterator_GetPoints_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the points in the current cell.
		/// This is usually a very expensive call, and should be avoided when possible.
		/// This should only be called when IsDoneWithTraversal() returns false.
		/// </summary>
		// Token: 0x0601B11A RID: 110874 RVA: 0x0025C854 File Offset: 0x0025AA54
		public vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellIterator.vtkCellIterator_GetPoints_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0601B11B RID: 110875
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellIterator_GoToNextCell_12(HandleRef pThis);

		/// <summary>
		/// Increment to next cell. Always safe to call.
		/// </summary>
		// Token: 0x0601B11C RID: 110876 RVA: 0x0025C8C3 File Offset: 0x0025AAC3
		public void GoToNextCell()
		{
			vtkCellIterator.vtkCellIterator_GoToNextCell_12(base.GetCppThis());
		}

		// Token: 0x0601B11D RID: 110877
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellIterator_InitTraversal_13(HandleRef pThis);

		/// <summary>
		/// Reset to the first cell.
		/// </summary>
		// Token: 0x0601B11E RID: 110878 RVA: 0x0025C8D2 File Offset: 0x0025AAD2
		public void InitTraversal()
		{
			vtkCellIterator.vtkCellIterator_InitTraversal_13(base.GetCppThis());
		}

		// Token: 0x0601B11F RID: 110879
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellIterator_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B120 RID: 110880 RVA: 0x0025C8E4 File Offset: 0x0025AAE4
		public override int IsA(string type)
		{
			return vtkCellIterator.vtkCellIterator_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0601B121 RID: 110881
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellIterator_IsDoneWithTraversal_15(HandleRef pThis);

		/// <summary>
		/// Returns false while the iterator is valid. Always safe to call.
		/// </summary>
		// Token: 0x0601B122 RID: 110882 RVA: 0x0025C904 File Offset: 0x0025AB04
		public virtual bool IsDoneWithTraversal()
		{
			return vtkCellIterator.vtkCellIterator_IsDoneWithTraversal_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0601B123 RID: 110883
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellIterator_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B124 RID: 110884 RVA: 0x0025C92C File Offset: 0x0025AB2C
		public new static int IsTypeOf(string type)
		{
			return vtkCellIterator.vtkCellIterator_IsTypeOf_16(type);
		}

		// Token: 0x0601B125 RID: 110885
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellIterator_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B126 RID: 110886 RVA: 0x0025C948 File Offset: 0x0025AB48
		public new vtkCellIterator NewInstance()
		{
			vtkCellIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellIterator.vtkCellIterator_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B127 RID: 110887
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellIterator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B128 RID: 110888 RVA: 0x0025C9A4 File Offset: 0x0025ABA4
		public new static vtkCellIterator SafeDownCast(vtkObjectBase o)
		{
			vtkCellIterator vtkCellIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellIterator.vtkCellIterator_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellIterator = (vtkCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellIterator.Register(null);
				}
			}
			return vtkCellIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D3F RID: 7487
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D40 RID: 7488
		public new static readonly string MRClassNameKey = "class vtkCellIterator";
	}
}
