using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAggregateDataSetFilter
	/// </summary>
	/// <remarks>
	///    Aggregates data sets to a reduced number of processes.
	///
	/// This class allows polydata and unstructured grids to be aggregated
	/// over a smaller set of processes. The derived vtkDIYAggregateDataSetFilter
	/// will operate on image data, rectilinear grids and structured grids.
	/// </remarks>
	// Token: 0x020004F4 RID: 1268
	public class vtkAggregateDataSetFilter : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E48B RID: 58507 RVA: 0x0013E567 File Offset: 0x0013C767
		static vtkAggregateDataSetFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAggregateDataSetFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAggregateDataSetFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E48C RID: 58508 RVA: 0x0013E58F File Offset: 0x0013C78F
		public vtkAggregateDataSetFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E48D RID: 58509
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAggregateDataSetFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E48E RID: 58510 RVA: 0x0013E5A0 File Offset: 0x0013C7A0
		public new static vtkAggregateDataSetFilter New()
		{
			vtkAggregateDataSetFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAggregateDataSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E48F RID: 58511 RVA: 0x0013E5F4 File Offset: 0x0013C7F4
		public vtkAggregateDataSetFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E490 RID: 58512 RVA: 0x0013E638 File Offset: 0x0013C838
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E491 RID: 58513
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAggregateDataSetFilter_GetMergePoints_01(HandleRef pThis);

		/// <summary>
		/// Get/Set if the filter should merge coincidental points
		/// Note 1: The filter will only merge points if the ghost cell array doesn't exist
		/// Note 2: This option is only taken into account with vtkUnstructuredGrid objects
		/// Defaults to On
		/// </summary>
		// Token: 0x0600E492 RID: 58514 RVA: 0x0013E644 File Offset: 0x0013C844
		public virtual bool GetMergePoints()
		{
			return vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_GetMergePoints_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E493 RID: 58515
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAggregateDataSetFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E494 RID: 58516 RVA: 0x0013E66C File Offset: 0x0013C86C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E495 RID: 58517
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAggregateDataSetFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E496 RID: 58518 RVA: 0x0013E68C File Offset: 0x0013C88C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E497 RID: 58519
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAggregateDataSetFilter_GetNumberOfTargetProcesses_04(HandleRef pThis);

		/// <summary>
		/// Number of target processes. Valid values are between 1 and the total
		/// number of processes. The default is 1. If a value is passed in that
		/// is less than 1 than NumberOfTargetProcesses is changed/kept at 1.
		/// If a value is passed in that is greater than the total number of
		/// processes then NumberOfTargetProcesses is changed/kept at the
		/// total number of processes. This is useful for scripting use cases
		/// where later on the script is run with more processes than the
		/// current amount.
		/// </summary>
		// Token: 0x0600E498 RID: 58520 RVA: 0x0013E6A8 File Offset: 0x0013C8A8
		public virtual int GetNumberOfTargetProcesses()
		{
			return vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_GetNumberOfTargetProcesses_04(base.GetCppThis());
		}

		// Token: 0x0600E499 RID: 58521
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAggregateDataSetFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E49A RID: 58522 RVA: 0x0013E6C8 File Offset: 0x0013C8C8
		public override int IsA(string type)
		{
			return vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600E49B RID: 58523
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAggregateDataSetFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E49C RID: 58524 RVA: 0x0013E6E8 File Offset: 0x0013C8E8
		public new static int IsTypeOf(string type)
		{
			return vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_IsTypeOf_06(type);
		}

		// Token: 0x0600E49D RID: 58525
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAggregateDataSetFilter_MergePointsOff_07(HandleRef pThis);

		/// <summary>
		/// Get/Set if the filter should merge coincidental points
		/// Note 1: The filter will only merge points if the ghost cell array doesn't exist
		/// Note 2: This option is only taken into account with vtkUnstructuredGrid objects
		/// Defaults to On
		/// </summary>
		// Token: 0x0600E49E RID: 58526 RVA: 0x0013E702 File Offset: 0x0013C902
		public virtual void MergePointsOff()
		{
			vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_MergePointsOff_07(base.GetCppThis());
		}

		// Token: 0x0600E49F RID: 58527
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAggregateDataSetFilter_MergePointsOn_08(HandleRef pThis);

		/// <summary>
		/// Get/Set if the filter should merge coincidental points
		/// Note 1: The filter will only merge points if the ghost cell array doesn't exist
		/// Note 2: This option is only taken into account with vtkUnstructuredGrid objects
		/// Defaults to On
		/// </summary>
		// Token: 0x0600E4A0 RID: 58528 RVA: 0x0013E711 File Offset: 0x0013C911
		public virtual void MergePointsOn()
		{
			vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_MergePointsOn_08(base.GetCppThis());
		}

		// Token: 0x0600E4A1 RID: 58529
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAggregateDataSetFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4A2 RID: 58530 RVA: 0x0013E720 File Offset: 0x0013C920
		public new vtkAggregateDataSetFilter NewInstance()
		{
			vtkAggregateDataSetFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAggregateDataSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E4A3 RID: 58531
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAggregateDataSetFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4A4 RID: 58532 RVA: 0x0013E77C File Offset: 0x0013C97C
		public new static vtkAggregateDataSetFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAggregateDataSetFilter vtkAggregateDataSetFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAggregateDataSetFilter = (vtkAggregateDataSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAggregateDataSetFilter.Register(null);
				}
			}
			return vtkAggregateDataSetFilter;
		}

		// Token: 0x0600E4A5 RID: 58533
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAggregateDataSetFilter_SetMergePoints_12(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set if the filter should merge coincidental points
		/// Note 1: The filter will only merge points if the ghost cell array doesn't exist
		/// Note 2: This option is only taken into account with vtkUnstructuredGrid objects
		/// Defaults to On
		/// </summary>
		// Token: 0x0600E4A6 RID: 58534 RVA: 0x0013E7FB File Offset: 0x0013C9FB
		public virtual void SetMergePoints(bool _arg)
		{
			vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_SetMergePoints_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E4A7 RID: 58535
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAggregateDataSetFilter_SetNumberOfTargetProcesses_13(HandleRef pThis, int arg0);

		/// <summary>
		/// Number of target processes. Valid values are between 1 and the total
		/// number of processes. The default is 1. If a value is passed in that
		/// is less than 1 than NumberOfTargetProcesses is changed/kept at 1.
		/// If a value is passed in that is greater than the total number of
		/// processes then NumberOfTargetProcesses is changed/kept at the
		/// total number of processes. This is useful for scripting use cases
		/// where later on the script is run with more processes than the
		/// current amount.
		/// </summary>
		// Token: 0x0600E4A8 RID: 58536 RVA: 0x0013E813 File Offset: 0x0013CA13
		public void SetNumberOfTargetProcesses(int arg0)
		{
			vtkAggregateDataSetFilter.vtkAggregateDataSetFilter_SetNumberOfTargetProcesses_13(base.GetCppThis(), arg0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010CD RID: 4301
		public new const string MRFullTypeName = "Kitware.VTK.vtkAggregateDataSetFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010CE RID: 4302
		public new static readonly string MRClassNameKey = "class vtkAggregateDataSetFilter";
	}
}
