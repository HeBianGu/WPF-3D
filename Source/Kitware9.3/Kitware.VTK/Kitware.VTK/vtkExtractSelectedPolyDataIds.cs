using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractSelectedPolyDataIds
	/// </summary>
	/// <remarks>
	///    extract a list of cells from a polydata
	///
	/// vtkExtractSelectedPolyDataIds extracts all cells in vtkSelection from a
	/// vtkPolyData.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSelection
	///
	/// @deprecated vtkExtractSelectedPolyDataIds is deprecated in VTK 9.2 and will be removed.
	/// Use `vtkExtractSelection` instead of `vtkExtractSelectedPolyDataIds`.
	///
	/// Example using vtkExtractSelectedPolyDataIds:
	///
	/// vtkNew&lt;vtkExtractSelectedPolyDataIds&gt; selFilter;
	/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
	/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
	///
	/// Example using vtkExtractSelection:
	///
	/// vtkNew&lt;vtkExtractSelection&gt; selFilter;
	/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
	/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
	///
	/// convert selFilter's output from vtkUnstructuredGrid to vtkPolydata
	/// </seealso>
	// Token: 0x020006B5 RID: 1717
	public class vtkExtractSelectedPolyDataIds : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601252F RID: 75055 RVA: 0x0019ADE7 File Offset: 0x00198FE7
		static vtkExtractSelectedPolyDataIds()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedPolyDataIds.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedPolyDataIds"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012530 RID: 75056 RVA: 0x0019AE0F File Offset: 0x0019900F
		public vtkExtractSelectedPolyDataIds(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012531 RID: 75057
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedPolyDataIds_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012532 RID: 75058 RVA: 0x0019AE20 File Offset: 0x00199020
		public new static vtkExtractSelectedPolyDataIds New()
		{
			vtkExtractSelectedPolyDataIds result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedPolyDataIds)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012533 RID: 75059 RVA: 0x0019AE74 File Offset: 0x00199074
		public vtkExtractSelectedPolyDataIds() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012534 RID: 75060 RVA: 0x0019AEB8 File Offset: 0x001990B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012535 RID: 75061
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedPolyDataIds_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012536 RID: 75062 RVA: 0x0019AEC4 File Offset: 0x001990C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012537 RID: 75063
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedPolyDataIds_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012538 RID: 75064 RVA: 0x0019AEE4 File Offset: 0x001990E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012539 RID: 75065
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedPolyDataIds_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601253A RID: 75066 RVA: 0x0019AF00 File Offset: 0x00199100
		public override int IsA(string type)
		{
			return vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601253B RID: 75067
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedPolyDataIds_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601253C RID: 75068 RVA: 0x0019AF20 File Offset: 0x00199120
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_IsTypeOf_04(type);
		}

		// Token: 0x0601253D RID: 75069
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedPolyDataIds_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601253E RID: 75070 RVA: 0x0019AF3C File Offset: 0x0019913C
		public new vtkExtractSelectedPolyDataIds NewInstance()
		{
			vtkExtractSelectedPolyDataIds result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedPolyDataIds)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601253F RID: 75071
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedPolyDataIds_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012540 RID: 75072 RVA: 0x0019AF98 File Offset: 0x00199198
		public new static vtkExtractSelectedPolyDataIds SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedPolyDataIds vtkExtractSelectedPolyDataIds = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedPolyDataIds = (vtkExtractSelectedPolyDataIds)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedPolyDataIds.Register(null);
				}
			}
			return vtkExtractSelectedPolyDataIds;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001518 RID: 5400
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedPolyDataIds";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001519 RID: 5401
		public new static readonly string MRClassNameKey = "class vtkExtractSelectedPolyDataIds";
	}
}
