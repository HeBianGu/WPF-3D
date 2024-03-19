using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataToUnstructuredGrid
	/// </summary>
	/// <remarks>
	///    Filter which converts a polydata to unstructured grid.
	///
	/// This filter converts a polydata to an unstructured grid. The output is
	/// a vtkUnstructuredGrid with the same points as the input vtkPolyData.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	/// </remarks>
	// Token: 0x0200098E RID: 2446
	public class vtkPolyDataToUnstructuredGrid : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601981F RID: 104479 RVA: 0x002380EF File Offset: 0x002362EF
		static vtkPolyDataToUnstructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataToUnstructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataToUnstructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019820 RID: 104480 RVA: 0x00238117 File Offset: 0x00236317
		public vtkPolyDataToUnstructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019821 RID: 104481
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataToUnstructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019822 RID: 104482 RVA: 0x00238128 File Offset: 0x00236328
		public new static vtkPolyDataToUnstructuredGrid New()
		{
			vtkPolyDataToUnstructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataToUnstructuredGrid.vtkPolyDataToUnstructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataToUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019823 RID: 104483 RVA: 0x0023817C File Offset: 0x0023637C
		public vtkPolyDataToUnstructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataToUnstructuredGrid.vtkPolyDataToUnstructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019824 RID: 104484 RVA: 0x002381C0 File Offset: 0x002363C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019825 RID: 104485
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataToUnstructuredGrid_CanBeProcessedFast_01(HandleRef polyData);

		/// <summary>
		/// Check if a polydata has only 1 cell array populated, therefore it can be just shallow copied
		/// </summary>
		// Token: 0x06019826 RID: 104486 RVA: 0x002381CC File Offset: 0x002363CC
		public static bool CanBeProcessedFast(vtkPolyData polyData)
		{
			return vtkPolyDataToUnstructuredGrid.vtkPolyDataToUnstructuredGrid_CanBeProcessedFast_01((polyData == null) ? default(HandleRef) : polyData.GetCppThis()) != 0;
		}

		// Token: 0x06019827 RID: 104487
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataToUnstructuredGrid_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019828 RID: 104488 RVA: 0x00238204 File Offset: 0x00236404
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataToUnstructuredGrid.vtkPolyDataToUnstructuredGrid_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06019829 RID: 104489
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataToUnstructuredGrid_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601982A RID: 104490 RVA: 0x00238224 File Offset: 0x00236424
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataToUnstructuredGrid.vtkPolyDataToUnstructuredGrid_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601982B RID: 104491
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataToUnstructuredGrid_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601982C RID: 104492 RVA: 0x00238240 File Offset: 0x00236440
		public override int IsA(string type)
		{
			return vtkPolyDataToUnstructuredGrid.vtkPolyDataToUnstructuredGrid_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601982D RID: 104493
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataToUnstructuredGrid_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601982E RID: 104494 RVA: 0x00238260 File Offset: 0x00236460
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataToUnstructuredGrid.vtkPolyDataToUnstructuredGrid_IsTypeOf_05(type);
		}

		// Token: 0x0601982F RID: 104495
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataToUnstructuredGrid_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019830 RID: 104496 RVA: 0x0023827C File Offset: 0x0023647C
		public new vtkPolyDataToUnstructuredGrid NewInstance()
		{
			vtkPolyDataToUnstructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataToUnstructuredGrid.vtkPolyDataToUnstructuredGrid_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataToUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019831 RID: 104497
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataToUnstructuredGrid_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019832 RID: 104498 RVA: 0x002382D8 File Offset: 0x002364D8
		public new static vtkPolyDataToUnstructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataToUnstructuredGrid vtkPolyDataToUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataToUnstructuredGrid.vtkPolyDataToUnstructuredGrid_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataToUnstructuredGrid = (vtkPolyDataToUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataToUnstructuredGrid.Register(null);
				}
			}
			return vtkPolyDataToUnstructuredGrid;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BDD RID: 7133
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataToUnstructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BDE RID: 7134
		public new static readonly string MRClassNameKey = "class vtkPolyDataToUnstructuredGrid";
	}
}
