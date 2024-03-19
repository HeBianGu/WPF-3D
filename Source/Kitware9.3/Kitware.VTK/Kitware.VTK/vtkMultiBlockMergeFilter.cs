using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMultiBlockMergeFilter
	/// </summary>
	/// <remarks>
	///    merges multiblock inputs into a single multiblock output
	///
	/// vtkMultiBlockMergeFilter is an M to 1 filter similar to
	/// vtkMultiBlockDataGroupFilter. However where as that class creates N groups
	/// in the output for N inputs, this creates 1 group in the output with N
	/// datasets inside it. In actuality if the inputs have M blocks, this will
	/// produce M blocks, each of which has N datasets. Inside the merged group,
	/// the i'th data set comes from the i'th data set in the i'th input.
	/// </remarks>
	// Token: 0x020008BE RID: 2238
	public class vtkMultiBlockMergeFilter : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017310 RID: 94992 RVA: 0x00208D97 File Offset: 0x00206F97
		static vtkMultiBlockMergeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiBlockMergeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockMergeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017311 RID: 94993 RVA: 0x00208DBF File Offset: 0x00206FBF
		public vtkMultiBlockMergeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017312 RID: 94994
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockMergeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with PointIds and CellIds on; and ids being generated
		/// as scalars.
		/// </summary>
		// Token: 0x06017313 RID: 94995 RVA: 0x00208DD0 File Offset: 0x00206FD0
		public new static vtkMultiBlockMergeFilter New()
		{
			vtkMultiBlockMergeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockMergeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with PointIds and CellIds on; and ids being generated
		/// as scalars.
		/// </summary>
		// Token: 0x06017314 RID: 94996 RVA: 0x00208E24 File Offset: 0x00207024
		public vtkMultiBlockMergeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017315 RID: 94997 RVA: 0x00208E68 File Offset: 0x00207068
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017316 RID: 94998
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockMergeFilter_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06017317 RID: 94999 RVA: 0x00208E74 File Offset: 0x00207074
		public void AddInputData(vtkDataObject arg0)
		{
			vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06017318 RID: 95000
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockMergeFilter_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06017319 RID: 95001 RVA: 0x00208EA4 File Offset: 0x002070A4
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601731A RID: 95002
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockMergeFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601731B RID: 95003 RVA: 0x00208ED4 File Offset: 0x002070D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601731C RID: 95004
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockMergeFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601731D RID: 95005 RVA: 0x00208EF4 File Offset: 0x002070F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601731E RID: 95006
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockMergeFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601731F RID: 95007 RVA: 0x00208F10 File Offset: 0x00207110
		public override int IsA(string type)
		{
			return vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06017320 RID: 95008
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockMergeFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017321 RID: 95009 RVA: 0x00208F30 File Offset: 0x00207130
		public new static int IsTypeOf(string type)
		{
			return vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_IsTypeOf_06(type);
		}

		// Token: 0x06017322 RID: 95010
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockMergeFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017323 RID: 95011 RVA: 0x00208F4C File Offset: 0x0020714C
		public new vtkMultiBlockMergeFilter NewInstance()
		{
			vtkMultiBlockMergeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockMergeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017324 RID: 95012
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockMergeFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017325 RID: 95013 RVA: 0x00208FA8 File Offset: 0x002071A8
		public new static vtkMultiBlockMergeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMultiBlockMergeFilter vtkMultiBlockMergeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockMergeFilter = (vtkMultiBlockMergeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockMergeFilter.Register(null);
				}
			}
			return vtkMultiBlockMergeFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019EA RID: 6634
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockMergeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019EB RID: 6635
		public new static readonly string MRClassNameKey = "class vtkMultiBlockMergeFilter";
	}
}
