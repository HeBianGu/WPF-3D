using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellCenterDepthSort
	/// </summary>
	/// <remarks>
	///    A simple implementation of vtkCellDepthSort.
	///
	///
	/// vtkCellCenterDepthSort is a simple and fast implementation of depth
	/// sort, but it only provides approximate results.  The sorting algorithm
	/// finds the centroids of all the cells.  It then performs the dot product
	/// of the centroids against a vector pointing in the direction of the
	/// camera transformed into object space.  It then performs an ordinary sort
	/// on the result.
	///
	/// </remarks>
	// Token: 0x020007CF RID: 1999
	public class vtkCellCenterDepthSort : vtkVisibilitySort
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601470D RID: 83725 RVA: 0x001CF1F6 File Offset: 0x001CD3F6
		static vtkCellCenterDepthSort()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellCenterDepthSort.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellCenterDepthSort"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601470E RID: 83726 RVA: 0x001CF21E File Offset: 0x001CD41E
		public vtkCellCenterDepthSort(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601470F RID: 83727
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellCenterDepthSort_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014710 RID: 83728 RVA: 0x001CF22C File Offset: 0x001CD42C
		public new static vtkCellCenterDepthSort New()
		{
			vtkCellCenterDepthSort result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellCenterDepthSort.vtkCellCenterDepthSort_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellCenterDepthSort)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014711 RID: 83729 RVA: 0x001CF280 File Offset: 0x001CD480
		public vtkCellCenterDepthSort() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellCenterDepthSort.vtkCellCenterDepthSort_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014712 RID: 83730 RVA: 0x001CF2C4 File Offset: 0x001CD4C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014713 RID: 83731
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellCenterDepthSort_GetNextCells_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014714 RID: 83732 RVA: 0x001CF2D0 File Offset: 0x001CD4D0
		public override vtkIdTypeArray GetNextCells()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellCenterDepthSort.vtkCellCenterDepthSort_GetNextCells_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06014715 RID: 83733
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellCenterDepthSort_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014716 RID: 83734 RVA: 0x001CF340 File Offset: 0x001CD540
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellCenterDepthSort.vtkCellCenterDepthSort_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06014717 RID: 83735
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellCenterDepthSort_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014718 RID: 83736 RVA: 0x001CF360 File Offset: 0x001CD560
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellCenterDepthSort.vtkCellCenterDepthSort_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06014719 RID: 83737
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellCenterDepthSort_InitTraversal_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601471A RID: 83738 RVA: 0x001CF37A File Offset: 0x001CD57A
		public override void InitTraversal()
		{
			vtkCellCenterDepthSort.vtkCellCenterDepthSort_InitTraversal_04(base.GetCppThis());
		}

		// Token: 0x0601471B RID: 83739
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCenterDepthSort_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601471C RID: 83740 RVA: 0x001CF38C File Offset: 0x001CD58C
		public override int IsA(string type)
		{
			return vtkCellCenterDepthSort.vtkCellCenterDepthSort_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601471D RID: 83741
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCenterDepthSort_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601471E RID: 83742 RVA: 0x001CF3AC File Offset: 0x001CD5AC
		public new static int IsTypeOf(string type)
		{
			return vtkCellCenterDepthSort.vtkCellCenterDepthSort_IsTypeOf_06(type);
		}

		// Token: 0x0601471F RID: 83743
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellCenterDepthSort_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014720 RID: 83744 RVA: 0x001CF3C8 File Offset: 0x001CD5C8
		public new vtkCellCenterDepthSort NewInstance()
		{
			vtkCellCenterDepthSort result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellCenterDepthSort.vtkCellCenterDepthSort_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellCenterDepthSort)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014721 RID: 83745
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellCenterDepthSort_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014722 RID: 83746 RVA: 0x001CF424 File Offset: 0x001CD624
		public new static vtkCellCenterDepthSort SafeDownCast(vtkObjectBase o)
		{
			vtkCellCenterDepthSort vtkCellCenterDepthSort = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellCenterDepthSort.vtkCellCenterDepthSort_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellCenterDepthSort = (vtkCellCenterDepthSort)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellCenterDepthSort.Register(null);
				}
			}
			return vtkCellCenterDepthSort;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017BF RID: 6079
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellCenterDepthSort";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017C0 RID: 6080
		public new static readonly string MRClassNameKey = "class vtkCellCenterDepthSort";
	}
}
