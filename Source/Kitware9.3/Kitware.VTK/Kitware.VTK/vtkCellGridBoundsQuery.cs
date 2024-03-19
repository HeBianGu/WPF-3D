using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridBoundsQuery
	/// </summary>
	/// <remarks>
	///    Compute the geometric bounds of a cell-grid.
	///
	/// If no cells are present, invalid bounds will be returned
	/// (i.e., bds[1] &lt; bds[0] after calling `GetBounds(bds)`).
	/// </remarks>
	// Token: 0x02000A1F RID: 2591
	public class vtkCellGridBoundsQuery : vtkCellGridQuery
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B058 RID: 110680 RVA: 0x0025B2EF File Offset: 0x002594EF
		static vtkCellGridBoundsQuery()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridBoundsQuery.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridBoundsQuery"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B059 RID: 110681 RVA: 0x0025B317 File Offset: 0x00259517
		public vtkCellGridBoundsQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B05A RID: 110682
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridBoundsQuery_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B05B RID: 110683 RVA: 0x0025B328 File Offset: 0x00259528
		public new static vtkCellGridBoundsQuery New()
		{
			vtkCellGridBoundsQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridBoundsQuery.vtkCellGridBoundsQuery_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridBoundsQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B05C RID: 110684 RVA: 0x0025B37C File Offset: 0x0025957C
		public vtkCellGridBoundsQuery() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridBoundsQuery.vtkCellGridBoundsQuery_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B05D RID: 110685 RVA: 0x0025B3C0 File Offset: 0x002595C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B05E RID: 110686
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridBoundsQuery_GetBounds_01(HandleRef pThis, IntPtr bds);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B05F RID: 110687 RVA: 0x0025B3CB File Offset: 0x002595CB
		public void GetBounds(IntPtr bds)
		{
			vtkCellGridBoundsQuery.vtkCellGridBoundsQuery_GetBounds_01(base.GetCppThis(), bds);
		}

		// Token: 0x0601B060 RID: 110688
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridBoundsQuery_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B061 RID: 110689 RVA: 0x0025B3DC File Offset: 0x002595DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridBoundsQuery.vtkCellGridBoundsQuery_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601B062 RID: 110690
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridBoundsQuery_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B063 RID: 110691 RVA: 0x0025B3FC File Offset: 0x002595FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridBoundsQuery.vtkCellGridBoundsQuery_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601B064 RID: 110692
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridBoundsQuery_Initialize_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B065 RID: 110693 RVA: 0x0025B416 File Offset: 0x00259616
		public override void Initialize()
		{
			vtkCellGridBoundsQuery.vtkCellGridBoundsQuery_Initialize_04(base.GetCppThis());
		}

		// Token: 0x0601B066 RID: 110694
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridBoundsQuery_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B067 RID: 110695 RVA: 0x0025B428 File Offset: 0x00259628
		public override int IsA(string type)
		{
			return vtkCellGridBoundsQuery.vtkCellGridBoundsQuery_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601B068 RID: 110696
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridBoundsQuery_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B069 RID: 110697 RVA: 0x0025B448 File Offset: 0x00259648
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridBoundsQuery.vtkCellGridBoundsQuery_IsTypeOf_06(type);
		}

		// Token: 0x0601B06A RID: 110698
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridBoundsQuery_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B06B RID: 110699 RVA: 0x0025B464 File Offset: 0x00259664
		public new vtkCellGridBoundsQuery NewInstance()
		{
			vtkCellGridBoundsQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridBoundsQuery.vtkCellGridBoundsQuery_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridBoundsQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B06C RID: 110700
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridBoundsQuery_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B06D RID: 110701 RVA: 0x0025B4C0 File Offset: 0x002596C0
		public new static vtkCellGridBoundsQuery SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridBoundsQuery vtkCellGridBoundsQuery = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridBoundsQuery.vtkCellGridBoundsQuery_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridBoundsQuery = (vtkCellGridBoundsQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridBoundsQuery.Register(null);
				}
			}
			return vtkCellGridBoundsQuery;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D2D RID: 7469
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridBoundsQuery";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D2E RID: 7470
		public new static readonly string MRClassNameKey = "class vtkCellGridBoundsQuery";
	}
}
