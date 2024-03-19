using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMultiBlockDataGroupFilter
	/// </summary>
	/// <remarks>
	///    collects multiple inputs into one multi-group dataset
	///
	/// vtkMultiBlockDataGroupFilter is an M to 1 filter that merges multiple
	/// input into one multi-group dataset. It will assign each input to
	/// one group of the multi-group dataset and will assign each update piece
	/// as a sub-block. For example, if there are two inputs and four update
	/// pieces, the output contains two groups with four datasets each.
	///
	/// `vtkGroupDataSetsFilter` is a newer filter that can be used for similar
	/// use-cases and is more flexible. It is recommended that new code uses
	/// vtkGroupDataSetsFilter instead of this one.
	/// </remarks>
	// Token: 0x020008BD RID: 2237
	public class vtkMultiBlockDataGroupFilter : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060172FA RID: 94970 RVA: 0x00208B09 File Offset: 0x00206D09
		static vtkMultiBlockDataGroupFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiBlockDataGroupFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockDataGroupFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060172FB RID: 94971 RVA: 0x00208B31 File Offset: 0x00206D31
		public vtkMultiBlockDataGroupFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060172FC RID: 94972
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataGroupFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with PointIds and CellIds on; and ids being generated
		/// as scalars.
		/// </summary>
		// Token: 0x060172FD RID: 94973 RVA: 0x00208B40 File Offset: 0x00206D40
		public new static vtkMultiBlockDataGroupFilter New()
		{
			vtkMultiBlockDataGroupFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockDataGroupFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with PointIds and CellIds on; and ids being generated
		/// as scalars.
		/// </summary>
		// Token: 0x060172FE RID: 94974 RVA: 0x00208B94 File Offset: 0x00206D94
		public vtkMultiBlockDataGroupFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060172FF RID: 94975 RVA: 0x00208BD8 File Offset: 0x00206DD8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017300 RID: 94976
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockDataGroupFilter_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06017301 RID: 94977 RVA: 0x00208BE4 File Offset: 0x00206DE4
		public void AddInputData(vtkDataObject arg0)
		{
			vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06017302 RID: 94978
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockDataGroupFilter_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06017303 RID: 94979 RVA: 0x00208C14 File Offset: 0x00206E14
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06017304 RID: 94980
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockDataGroupFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017305 RID: 94981 RVA: 0x00208C44 File Offset: 0x00206E44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06017306 RID: 94982
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockDataGroupFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017307 RID: 94983 RVA: 0x00208C64 File Offset: 0x00206E64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06017308 RID: 94984
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockDataGroupFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017309 RID: 94985 RVA: 0x00208C80 File Offset: 0x00206E80
		public override int IsA(string type)
		{
			return vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601730A RID: 94986
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockDataGroupFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601730B RID: 94987 RVA: 0x00208CA0 File Offset: 0x00206EA0
		public new static int IsTypeOf(string type)
		{
			return vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_IsTypeOf_06(type);
		}

		// Token: 0x0601730C RID: 94988
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataGroupFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601730D RID: 94989 RVA: 0x00208CBC File Offset: 0x00206EBC
		public new vtkMultiBlockDataGroupFilter NewInstance()
		{
			vtkMultiBlockDataGroupFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockDataGroupFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601730E RID: 94990
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataGroupFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601730F RID: 94991 RVA: 0x00208D18 File Offset: 0x00206F18
		public new static vtkMultiBlockDataGroupFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMultiBlockDataGroupFilter vtkMultiBlockDataGroupFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataGroupFilter = (vtkMultiBlockDataGroupFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataGroupFilter.Register(null);
				}
			}
			return vtkMultiBlockDataGroupFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019E8 RID: 6632
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockDataGroupFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019E9 RID: 6633
		public new static readonly string MRClassNameKey = "class vtkMultiBlockDataGroupFilter";
	}
}
