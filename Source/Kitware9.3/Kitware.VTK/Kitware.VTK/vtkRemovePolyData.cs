using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRemovePolyData
	/// </summary>
	/// <remarks>
	///    Removes vtkPolyData cells from an input vtkPolyData
	///
	/// vtkRemovePolyData is a filter that removes cells from an input vtkPolyData
	/// (defined in the first input #0), and produces an output vtkPolyData (which
	/// may be empty).  The cells to remove are specified in the following ways:
	/// 1) a list of cell ids can be provided; 2) a list of point ids can be
	/// provided - any cell using one or more of the points indicated is removed;
	/// and 3) one or more additional vtkPolyData inputs can be provided -
	/// matching cells are deleted. These three methods can be used in combination
	/// if desired. Point and cell attribute data associated with the remaining
	/// cells are copied to the output.
	///
	/// @warning
	/// The filter vtkAppendPolyData enables appending multiple input
	/// vtkPolyData's together. So vtkAppendPolyData functions as an
	/// approximate inverse operation to vtkRemovePolyData.
	///
	/// @warning
	/// The output point type is the same as the (first) input point type.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAppendPolyData
	/// </seealso>
	// Token: 0x020008D8 RID: 2264
	public class vtkRemovePolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017689 RID: 95881 RVA: 0x0020D697 File Offset: 0x0020B897
		static vtkRemovePolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRemovePolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRemovePolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601768A RID: 95882 RVA: 0x0020D6BF File Offset: 0x0020B8BF
		public vtkRemovePolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601768B RID: 95883
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemovePolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, obtain information, and print information.
		///
		/// </summary>
		// Token: 0x0601768C RID: 95884 RVA: 0x0020D6D0 File Offset: 0x0020B8D0
		public new static vtkRemovePolyData New()
		{
			vtkRemovePolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemovePolyData.vtkRemovePolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemovePolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods to instantiate, obtain information, and print information.
		///
		/// </summary>
		// Token: 0x0601768D RID: 95885 RVA: 0x0020D724 File Offset: 0x0020B924
		public vtkRemovePolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRemovePolyData.vtkRemovePolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601768E RID: 95886 RVA: 0x0020D768 File Offset: 0x0020B968
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601768F RID: 95887
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRemovePolyData_ExactMatchOff_01(HandleRef pThis);

		/// <summary>
		/// ExactMatch controls how the matching of cells when additional input
		/// vtkPolyDatas are provided. When ExactMatch is enabled, then if any
		/// input0 cell Ci uses all of the point ids in cells specified in inputs
		/// [1,N) Cn, and the number of point ids in Ci == Cn, then a match occurs
		/// and the cell is marked for deletion. Without ExactMatch enabled, if Ci
		/// uses all of the points in Cn, even though the cell connectivity list
		/// sizes are not the same size, a match occurs. This can be used to perform
		/// tricks like marking all of the cells that use a point or edge to be
		/// deleted. ExactMatch is disabled by default since it takes a extra
		/// computation time.
		/// </summary>
		// Token: 0x06017690 RID: 95888 RVA: 0x0020D773 File Offset: 0x0020B973
		public virtual void ExactMatchOff()
		{
			vtkRemovePolyData.vtkRemovePolyData_ExactMatchOff_01(base.GetCppThis());
		}

		// Token: 0x06017691 RID: 95889
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRemovePolyData_ExactMatchOn_02(HandleRef pThis);

		/// <summary>
		/// ExactMatch controls how the matching of cells when additional input
		/// vtkPolyDatas are provided. When ExactMatch is enabled, then if any
		/// input0 cell Ci uses all of the point ids in cells specified in inputs
		/// [1,N) Cn, and the number of point ids in Ci == Cn, then a match occurs
		/// and the cell is marked for deletion. Without ExactMatch enabled, if Ci
		/// uses all of the points in Cn, even though the cell connectivity list
		/// sizes are not the same size, a match occurs. This can be used to perform
		/// tricks like marking all of the cells that use a point or edge to be
		/// deleted. ExactMatch is disabled by default since it takes a extra
		/// computation time.
		/// </summary>
		// Token: 0x06017692 RID: 95890 RVA: 0x0020D782 File Offset: 0x0020B982
		public virtual void ExactMatchOn()
		{
			vtkRemovePolyData.vtkRemovePolyData_ExactMatchOn_02(base.GetCppThis());
		}

		// Token: 0x06017693 RID: 95891
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemovePolyData_GetCellIds_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the list of cell ids to delete. These are cell ids of the input
		/// polydata - note that polydata with mixed cell types (e.g., verts, lines,
		/// polys, and/or strips), the cell ids begin with the vertex cells, then
		/// line cells, then polygonal cells, and finally triangle strips.
		/// </summary>
		// Token: 0x06017694 RID: 95892 RVA: 0x0020D794 File Offset: 0x0020B994
		public virtual vtkIdTypeArray GetCellIds()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemovePolyData.vtkRemovePolyData_GetCellIds_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x06017695 RID: 95893
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRemovePolyData_GetExactMatch_04(HandleRef pThis);

		/// <summary>
		/// ExactMatch controls how the matching of cells when additional input
		/// vtkPolyDatas are provided. When ExactMatch is enabled, then if any
		/// input0 cell Ci uses all of the point ids in cells specified in inputs
		/// [1,N) Cn, and the number of point ids in Ci == Cn, then a match occurs
		/// and the cell is marked for deletion. Without ExactMatch enabled, if Ci
		/// uses all of the points in Cn, even though the cell connectivity list
		/// sizes are not the same size, a match occurs. This can be used to perform
		/// tricks like marking all of the cells that use a point or edge to be
		/// deleted. ExactMatch is disabled by default since it takes a extra
		/// computation time.
		/// </summary>
		// Token: 0x06017696 RID: 95894 RVA: 0x0020D804 File Offset: 0x0020BA04
		public virtual bool GetExactMatch()
		{
			return vtkRemovePolyData.vtkRemovePolyData_GetExactMatch_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06017697 RID: 95895
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemovePolyData_GetInput_05(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get any input of this filter.
		/// </summary>
		// Token: 0x06017698 RID: 95896 RVA: 0x0020D82C File Offset: 0x0020BA2C
		public new vtkPolyData GetInput(int idx)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemovePolyData.vtkRemovePolyData_GetInput_05(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06017699 RID: 95897
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemovePolyData_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get any input of this filter.
		/// </summary>
		// Token: 0x0601769A RID: 95898 RVA: 0x0020D89C File Offset: 0x0020BA9C
		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemovePolyData.vtkRemovePolyData_GetInput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0601769B RID: 95899
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRemovePolyData_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, obtain information, and print information.
		///
		/// </summary>
		// Token: 0x0601769C RID: 95900 RVA: 0x0020D90C File Offset: 0x0020BB0C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRemovePolyData.vtkRemovePolyData_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601769D RID: 95901
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRemovePolyData_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, obtain information, and print information.
		///
		/// </summary>
		// Token: 0x0601769E RID: 95902 RVA: 0x0020D92C File Offset: 0x0020BB2C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRemovePolyData.vtkRemovePolyData_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601769F RID: 95903
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemovePolyData_GetPointIds_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the list of points ids to delete. Any cells using any of the
		/// points listed are removed.
		/// </summary>
		// Token: 0x060176A0 RID: 95904 RVA: 0x0020D948 File Offset: 0x0020BB48
		public virtual vtkIdTypeArray GetPointIds()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemovePolyData.vtkRemovePolyData_GetPointIds_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x060176A1 RID: 95905
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRemovePolyData_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, obtain information, and print information.
		///
		/// </summary>
		// Token: 0x060176A2 RID: 95906 RVA: 0x0020D9B8 File Offset: 0x0020BBB8
		public override int IsA(string type)
		{
			return vtkRemovePolyData.vtkRemovePolyData_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060176A3 RID: 95907
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRemovePolyData_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, obtain information, and print information.
		///
		/// </summary>
		// Token: 0x060176A4 RID: 95908 RVA: 0x0020D9D8 File Offset: 0x0020BBD8
		public new static int IsTypeOf(string type)
		{
			return vtkRemovePolyData.vtkRemovePolyData_IsTypeOf_11(type);
		}

		// Token: 0x060176A5 RID: 95909
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemovePolyData_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, obtain information, and print information.
		///
		/// </summary>
		// Token: 0x060176A6 RID: 95910 RVA: 0x0020D9F4 File Offset: 0x0020BBF4
		public new vtkRemovePolyData NewInstance()
		{
			vtkRemovePolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemovePolyData.vtkRemovePolyData_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemovePolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060176A7 RID: 95911
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRemovePolyData_RemoveInputData_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove a vtkPolyData dataset from the list of data.
		/// </summary>
		// Token: 0x060176A8 RID: 95912 RVA: 0x0020DA50 File Offset: 0x0020BC50
		public void RemoveInputData(vtkPolyData arg0)
		{
			vtkRemovePolyData.vtkRemovePolyData_RemoveInputData_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060176A9 RID: 95913
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemovePolyData_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, obtain information, and print information.
		///
		/// </summary>
		// Token: 0x060176AA RID: 95914 RVA: 0x0020DA80 File Offset: 0x0020BC80
		public new static vtkRemovePolyData SafeDownCast(vtkObjectBase o)
		{
			vtkRemovePolyData vtkRemovePolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemovePolyData.vtkRemovePolyData_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRemovePolyData = (vtkRemovePolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRemovePolyData.Register(null);
				}
			}
			return vtkRemovePolyData;
		}

		// Token: 0x060176AB RID: 95915
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRemovePolyData_SetCellIds_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the list of cell ids to delete. These are cell ids of the input
		/// polydata - note that polydata with mixed cell types (e.g., verts, lines,
		/// polys, and/or strips), the cell ids begin with the vertex cells, then
		/// line cells, then polygonal cells, and finally triangle strips.
		/// </summary>
		// Token: 0x060176AC RID: 95916 RVA: 0x0020DB00 File Offset: 0x0020BD00
		public void SetCellIds(vtkIdTypeArray arg0)
		{
			vtkRemovePolyData.vtkRemovePolyData_SetCellIds_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060176AD RID: 95917
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRemovePolyData_SetExactMatch_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// ExactMatch controls how the matching of cells when additional input
		/// vtkPolyDatas are provided. When ExactMatch is enabled, then if any
		/// input0 cell Ci uses all of the point ids in cells specified in inputs
		/// [1,N) Cn, and the number of point ids in Ci == Cn, then a match occurs
		/// and the cell is marked for deletion. Without ExactMatch enabled, if Ci
		/// uses all of the points in Cn, even though the cell connectivity list
		/// sizes are not the same size, a match occurs. This can be used to perform
		/// tricks like marking all of the cells that use a point or edge to be
		/// deleted. ExactMatch is disabled by default since it takes a extra
		/// computation time.
		/// </summary>
		// Token: 0x060176AE RID: 95918 RVA: 0x0020DB2F File Offset: 0x0020BD2F
		public virtual void SetExactMatch(bool _arg)
		{
			vtkRemovePolyData.vtkRemovePolyData_SetExactMatch_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060176AF RID: 95919
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRemovePolyData_SetPointIds_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the list of points ids to delete. Any cells using any of the
		/// points listed are removed.
		/// </summary>
		// Token: 0x060176B0 RID: 95920 RVA: 0x0020DB48 File Offset: 0x0020BD48
		public void SetPointIds(vtkIdTypeArray arg0)
		{
			vtkRemovePolyData.vtkRemovePolyData_SetPointIds_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A23 RID: 6691
		public new const string MRFullTypeName = "Kitware.VTK.vtkRemovePolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A24 RID: 6692
		public new static readonly string MRClassNameKey = "class vtkRemovePolyData";
	}
}
