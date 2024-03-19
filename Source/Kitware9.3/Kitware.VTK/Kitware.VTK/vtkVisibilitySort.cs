using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVisibilitySort
	/// </summary>
	/// <remarks>
	///    Abstract class that can sort cell data along a viewpoint.
	///
	///
	/// vtkVisibilitySort encapsulates a method for depth sorting the cells of a
	/// vtkDataSet for a given viewpoint.  It should be noted that subclasses
	/// are not required to give an absolutely correct sorting.  Many types of
	/// unstructured grids may have sorting cycles, meaning that there is no
	/// possible correct sorting.  Some subclasses also only give an approximate
	/// sorting in the interest of speed.
	///
	/// @attention
	/// The Input field of this class tends to causes reference cycles.  To help
	/// break these cycles, garbage collection is enabled on this object and the
	/// input parameter is traced.  For this to work, though, an object in the
	/// loop holding the visibility sort should also report that to the garbage
	/// collector.
	///
	/// </remarks>
	// Token: 0x020007CD RID: 1997
	public abstract class vtkVisibilitySort : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060146DA RID: 83674 RVA: 0x001CECAB File Offset: 0x001CCEAB
		static vtkVisibilitySort()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVisibilitySort.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVisibilitySort"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060146DB RID: 83675 RVA: 0x001CECD3 File Offset: 0x001CCED3
		public vtkVisibilitySort(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060146DC RID: 83676 RVA: 0x001CECE1 File Offset: 0x001CCEE1
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060146DD RID: 83677
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVisibilitySort_GetCamera_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the camera that specifies the viewing parameters.
		/// </summary>
		// Token: 0x060146DE RID: 83678 RVA: 0x001CECEC File Offset: 0x001CCEEC
		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_GetCamera_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x060146DF RID: 83679
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVisibilitySort_GetDirection_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the sorting direction.  Be default, the direction is set
		/// to back to front.
		/// </summary>
		// Token: 0x060146E0 RID: 83680 RVA: 0x001CED5C File Offset: 0x001CCF5C
		public virtual int GetDirection()
		{
			return vtkVisibilitySort.vtkVisibilitySort_GetDirection_02(base.GetCppThis());
		}

		// Token: 0x060146E1 RID: 83681
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVisibilitySort_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the data set containing the cells to sort.
		/// </summary>
		// Token: 0x060146E2 RID: 83682 RVA: 0x001CED7C File Offset: 0x001CCF7C
		public virtual vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x060146E3 RID: 83683
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVisibilitySort_GetInverseModelTransform_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the matrix that transforms from object space to world space.
		/// Generally, you get this matrix from a call to GetMatrix of a vtkProp3D
		/// (vtkActor).
		/// </summary>
		// Token: 0x060146E4 RID: 83684 RVA: 0x001CEDEC File Offset: 0x001CCFEC
		public virtual vtkMatrix4x4 GetInverseModelTransform()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_GetInverseModelTransform_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x060146E5 RID: 83685
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVisibilitySort_GetMaxCellsReturned_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of cells that GetNextCells will return
		/// in one invocation.
		/// </summary>
		// Token: 0x060146E6 RID: 83686 RVA: 0x001CEE5C File Offset: 0x001CD05C
		public virtual int GetMaxCellsReturned()
		{
			return vtkVisibilitySort.vtkVisibilitySort_GetMaxCellsReturned_05(base.GetCppThis());
		}

		// Token: 0x060146E7 RID: 83687
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVisibilitySort_GetMaxCellsReturnedMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of cells that GetNextCells will return
		/// in one invocation.
		/// </summary>
		// Token: 0x060146E8 RID: 83688 RVA: 0x001CEE7C File Offset: 0x001CD07C
		public virtual int GetMaxCellsReturnedMaxValue()
		{
			return vtkVisibilitySort.vtkVisibilitySort_GetMaxCellsReturnedMaxValue_06(base.GetCppThis());
		}

		// Token: 0x060146E9 RID: 83689
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVisibilitySort_GetMaxCellsReturnedMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of cells that GetNextCells will return
		/// in one invocation.
		/// </summary>
		// Token: 0x060146EA RID: 83690 RVA: 0x001CEE9C File Offset: 0x001CD09C
		public virtual int GetMaxCellsReturnedMinValue()
		{
			return vtkVisibilitySort.vtkVisibilitySort_GetMaxCellsReturnedMinValue_07(base.GetCppThis());
		}

		// Token: 0x060146EB RID: 83691
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVisibilitySort_GetModelTransform_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the matrix that transforms from object space to world space.
		/// Generally, you get this matrix from a call to GetMatrix of a vtkProp3D
		/// (vtkActor).
		/// </summary>
		// Token: 0x060146EC RID: 83692 RVA: 0x001CEEBC File Offset: 0x001CD0BC
		public virtual vtkMatrix4x4 GetModelTransform()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_GetModelTransform_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x060146ED RID: 83693
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVisibilitySort_GetNextCells_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// To facilitate incremental sorting algorithms, the cells are retrieved
		/// in an iteration process.  That is, call InitTraversal to start the
		/// iteration and call GetNextCells to get the cell IDs in order.
		/// However, for efficiencies sake, GetNextCells returns an ordered list
		/// of several id's in once call (but not necessarily all).  GetNextCells
		/// will return NULL once the entire sorted list is output.  The
		/// vtkIdTypeArray returned from GetNextCells is a cached array, so do not
		/// delete it.  At the same note, do not expect the array to be valid
		/// after subsequent calls to GetNextCells.
		/// </summary>
		// Token: 0x060146EE RID: 83694 RVA: 0x001CEF2C File Offset: 0x001CD12C
		public virtual vtkIdTypeArray GetNextCells()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_GetNextCells_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060146EF RID: 83695
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVisibilitySort_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060146F0 RID: 83696 RVA: 0x001CEF9C File Offset: 0x001CD19C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVisibilitySort.vtkVisibilitySort_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060146F1 RID: 83697
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVisibilitySort_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060146F2 RID: 83698 RVA: 0x001CEFBC File Offset: 0x001CD1BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVisibilitySort.vtkVisibilitySort_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060146F3 RID: 83699
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVisibilitySort_InitTraversal_12(HandleRef pThis);

		/// <summary>
		/// To facilitate incremental sorting algorithms, the cells are retrieved
		/// in an iteration process.  That is, call InitTraversal to start the
		/// iteration and call GetNextCells to get the cell IDs in order.
		/// However, for efficiencies sake, GetNextCells returns an ordered list
		/// of several id's in once call (but not necessarily all).  GetNextCells
		/// will return NULL once the entire sorted list is output.  The
		/// vtkIdTypeArray returned from GetNextCells is a cached array, so do not
		/// delete it.  At the same note, do not expect the array to be valid
		/// after subsequent calls to GetNextCells.
		/// </summary>
		// Token: 0x060146F4 RID: 83700 RVA: 0x001CEFD6 File Offset: 0x001CD1D6
		public virtual void InitTraversal()
		{
			vtkVisibilitySort.vtkVisibilitySort_InitTraversal_12(base.GetCppThis());
		}

		// Token: 0x060146F5 RID: 83701
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVisibilitySort_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060146F6 RID: 83702 RVA: 0x001CEFE8 File Offset: 0x001CD1E8
		public override int IsA(string type)
		{
			return vtkVisibilitySort.vtkVisibilitySort_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x060146F7 RID: 83703
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVisibilitySort_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060146F8 RID: 83704 RVA: 0x001CF008 File Offset: 0x001CD208
		public new static int IsTypeOf(string type)
		{
			return vtkVisibilitySort.vtkVisibilitySort_IsTypeOf_14(type);
		}

		// Token: 0x060146F9 RID: 83705
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVisibilitySort_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060146FA RID: 83706 RVA: 0x001CF024 File Offset: 0x001CD224
		public new vtkVisibilitySort NewInstance()
		{
			vtkVisibilitySort result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVisibilitySort)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060146FB RID: 83707
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVisibilitySort_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060146FC RID: 83708 RVA: 0x001CF080 File Offset: 0x001CD280
		public new static vtkVisibilitySort SafeDownCast(vtkObjectBase o)
		{
			vtkVisibilitySort vtkVisibilitySort = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVisibilitySort = (vtkVisibilitySort)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVisibilitySort.Register(null);
				}
			}
			return vtkVisibilitySort;
		}

		// Token: 0x060146FD RID: 83709
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVisibilitySort_SetCamera_17(HandleRef pThis, HandleRef camera);

		/// <summary>
		/// Set/Get the camera that specifies the viewing parameters.
		/// </summary>
		// Token: 0x060146FE RID: 83710 RVA: 0x001CF100 File Offset: 0x001CD300
		public virtual void SetCamera(vtkCamera camera)
		{
			vtkVisibilitySort.vtkVisibilitySort_SetCamera_17(base.GetCppThis(), (camera == null) ? default(HandleRef) : camera.GetCppThis());
		}

		// Token: 0x060146FF RID: 83711
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVisibilitySort_SetDirection_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the sorting direction.  Be default, the direction is set
		/// to back to front.
		/// </summary>
		// Token: 0x06014700 RID: 83712 RVA: 0x001CF12F File Offset: 0x001CD32F
		public virtual void SetDirection(int _arg)
		{
			vtkVisibilitySort.vtkVisibilitySort_SetDirection_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06014701 RID: 83713
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVisibilitySort_SetDirectionToBackToFront_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the sorting direction.  Be default, the direction is set
		/// to back to front.
		/// </summary>
		// Token: 0x06014702 RID: 83714 RVA: 0x001CF13F File Offset: 0x001CD33F
		public void SetDirectionToBackToFront()
		{
			vtkVisibilitySort.vtkVisibilitySort_SetDirectionToBackToFront_19(base.GetCppThis());
		}

		// Token: 0x06014703 RID: 83715
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVisibilitySort_SetDirectionToFrontToBack_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the sorting direction.  Be default, the direction is set
		/// to back to front.
		/// </summary>
		// Token: 0x06014704 RID: 83716 RVA: 0x001CF14E File Offset: 0x001CD34E
		public void SetDirectionToFrontToBack()
		{
			vtkVisibilitySort.vtkVisibilitySort_SetDirectionToFrontToBack_20(base.GetCppThis());
		}

		// Token: 0x06014705 RID: 83717
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVisibilitySort_SetInput_21(HandleRef pThis, HandleRef data);

		/// <summary>
		/// Set/Get the data set containing the cells to sort.
		/// </summary>
		// Token: 0x06014706 RID: 83718 RVA: 0x001CF160 File Offset: 0x001CD360
		public virtual void SetInput(vtkDataSet data)
		{
			vtkVisibilitySort.vtkVisibilitySort_SetInput_21(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x06014707 RID: 83719
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVisibilitySort_SetMaxCellsReturned_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of cells that GetNextCells will return
		/// in one invocation.
		/// </summary>
		// Token: 0x06014708 RID: 83720 RVA: 0x001CF18F File Offset: 0x001CD38F
		public virtual void SetMaxCellsReturned(int _arg)
		{
			vtkVisibilitySort.vtkVisibilitySort_SetMaxCellsReturned_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06014709 RID: 83721
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVisibilitySort_SetModelTransform_23(HandleRef pThis, HandleRef mat);

		/// <summary>
		/// Set/Get the matrix that transforms from object space to world space.
		/// Generally, you get this matrix from a call to GetMatrix of a vtkProp3D
		/// (vtkActor).
		/// </summary>
		// Token: 0x0601470A RID: 83722 RVA: 0x001CF1A0 File Offset: 0x001CD3A0
		public virtual void SetModelTransform(vtkMatrix4x4 mat)
		{
			vtkVisibilitySort.vtkVisibilitySort_SetModelTransform_23(base.GetCppThis(), (mat == null) ? default(HandleRef) : mat.GetCppThis());
		}

		// Token: 0x0601470B RID: 83723
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVisibilitySort_UsesGarbageCollector_24(HandleRef pThis);

		/// <summary>
		/// Overwritten to enable garbage collection.
		/// </summary>
		// Token: 0x0601470C RID: 83724 RVA: 0x001CF1D0 File Offset: 0x001CD3D0
		public override bool UsesGarbageCollector()
		{
			return vtkVisibilitySort.vtkVisibilitySort_UsesGarbageCollector_24(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017BA RID: 6074
		public new const string MRFullTypeName = "Kitware.VTK.vtkVisibilitySort";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017BB RID: 6075
		public new static readonly string MRClassNameKey = "class vtkVisibilitySort";

		/// <summary>
		/// Set/Get the sorting direction.  Be default, the direction is set
		/// to back to front.
		/// </summary>
		// Token: 0x020007CE RID: 1998
		public enum BACK_TO_FRONT_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040017BD RID: 6077
			BACK_TO_FRONT,
			/// <summary>enum member</summary>
			// Token: 0x040017BE RID: 6078
			FRONT_TO_BACK
		}
	}
}
