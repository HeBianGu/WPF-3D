using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractSelectedIds
	/// </summary>
	/// <remarks>
	///    extract a list of cells from a dataset
	///
	/// vtkExtractSelectedIds extracts a set of cells and points from within a
	/// vtkDataSet. The set of ids to extract are listed within a vtkSelection.
	/// This filter adds a scalar array called vtkOriginalCellIds that says what
	/// input cell produced each output cell. This is an example of a Pedigree ID
	/// which helps to trace back results. Depending on whether the selection has
	/// GLOBALIDS, VALUES or INDICES, the selection will use the contents of the
	/// array named in the GLOBALIDS DataSetAttribute, and arbitrary array, or the
	/// position (tuple id or number) within the cell or point array.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSelection vtkExtractSelection
	///
	/// @deprecated vtkExtractSelectedIds is deprecated in VTK 9.2 and will be removed.
	/// Use `vtkExtractSelection` instead of `vtkExtractSelectedIds`.
	///
	/// Example using vtkExtractSelectedIds:
	///
	/// vtkNew&lt;vtkExtractSelectedIds&gt; selFilter;
	/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
	/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
	///
	/// Example using vtkExtractSelection:
	///
	/// vtkNew&lt;vtkExtractSelection&gt; selFilter;
	/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
	/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
	/// </seealso>
	// Token: 0x020006B3 RID: 1715
	public class vtkExtractSelectedIds : vtkExtractSelectionBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601250B RID: 75019 RVA: 0x0019A987 File Offset: 0x00198B87
		static vtkExtractSelectedIds()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedIds.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedIds"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601250C RID: 75020 RVA: 0x0019A9AF File Offset: 0x00198BAF
		public vtkExtractSelectedIds(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601250D RID: 75021
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedIds_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601250E RID: 75022 RVA: 0x0019A9C0 File Offset: 0x00198BC0
		public new static vtkExtractSelectedIds New()
		{
			vtkExtractSelectedIds result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedIds.vtkExtractSelectedIds_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedIds)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601250F RID: 75023 RVA: 0x0019AA14 File Offset: 0x00198C14
		public vtkExtractSelectedIds() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractSelectedIds.vtkExtractSelectedIds_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012510 RID: 75024 RVA: 0x0019AA58 File Offset: 0x00198C58
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012511 RID: 75025
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedIds_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012512 RID: 75026 RVA: 0x0019AA64 File Offset: 0x00198C64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSelectedIds.vtkExtractSelectedIds_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012513 RID: 75027
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedIds_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012514 RID: 75028 RVA: 0x0019AA84 File Offset: 0x00198C84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSelectedIds.vtkExtractSelectedIds_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012515 RID: 75029
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedIds_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012516 RID: 75030 RVA: 0x0019AAA0 File Offset: 0x00198CA0
		public override int IsA(string type)
		{
			return vtkExtractSelectedIds.vtkExtractSelectedIds_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012517 RID: 75031
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedIds_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012518 RID: 75032 RVA: 0x0019AAC0 File Offset: 0x00198CC0
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedIds.vtkExtractSelectedIds_IsTypeOf_04(type);
		}

		// Token: 0x06012519 RID: 75033
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedIds_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601251A RID: 75034 RVA: 0x0019AADC File Offset: 0x00198CDC
		public new vtkExtractSelectedIds NewInstance()
		{
			vtkExtractSelectedIds result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedIds.vtkExtractSelectedIds_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedIds)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601251B RID: 75035
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedIds_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601251C RID: 75036 RVA: 0x0019AB38 File Offset: 0x00198D38
		public new static vtkExtractSelectedIds SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedIds vtkExtractSelectedIds = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedIds.vtkExtractSelectedIds_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedIds = (vtkExtractSelectedIds)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedIds.Register(null);
				}
			}
			return vtkExtractSelectedIds;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001514 RID: 5396
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedIds";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001515 RID: 5397
		public new static readonly string MRClassNameKey = "class vtkExtractSelectedIds";
	}
}
