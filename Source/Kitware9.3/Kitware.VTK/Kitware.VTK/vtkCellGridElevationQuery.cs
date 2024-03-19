using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridElevationQuery
	/// </summary>
	/// <remarks>
	///    Request a new vtkCellAttribute corresponding to "elevation".
	/// </remarks>
	// Token: 0x020004D0 RID: 1232
	public class vtkCellGridElevationQuery : vtkCellGridQuery
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E06E RID: 57454 RVA: 0x0013756B File Offset: 0x0013576B
		static vtkCellGridElevationQuery()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridElevationQuery.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridElevationQuery"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E06F RID: 57455 RVA: 0x00137593 File Offset: 0x00135793
		public vtkCellGridElevationQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E070 RID: 57456
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridElevationQuery_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E071 RID: 57457 RVA: 0x001375A4 File Offset: 0x001357A4
		public new static vtkCellGridElevationQuery New()
		{
			vtkCellGridElevationQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridElevationQuery.vtkCellGridElevationQuery_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridElevationQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E072 RID: 57458 RVA: 0x001375F8 File Offset: 0x001357F8
		public vtkCellGridElevationQuery() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridElevationQuery.vtkCellGridElevationQuery_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E073 RID: 57459 RVA: 0x0013763C File Offset: 0x0013583C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E074 RID: 57460
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevationQuery_Finalize_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E075 RID: 57461 RVA: 0x00137647 File Offset: 0x00135847
		public override void FinalizeWrapper()
		{
			vtkCellGridElevationQuery.vtkCellGridElevationQuery_Finalize_01(base.GetCppThis());
		}

		// Token: 0x0600E076 RID: 57462
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridElevationQuery_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E077 RID: 57463 RVA: 0x00137658 File Offset: 0x00135858
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridElevationQuery.vtkCellGridElevationQuery_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E078 RID: 57464
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridElevationQuery_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E079 RID: 57465 RVA: 0x00137678 File Offset: 0x00135878
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridElevationQuery.vtkCellGridElevationQuery_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E07A RID: 57466
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevationQuery_Initialize_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E07B RID: 57467 RVA: 0x00137692 File Offset: 0x00135892
		public override void Initialize()
		{
			vtkCellGridElevationQuery.vtkCellGridElevationQuery_Initialize_04(base.GetCppThis());
		}

		// Token: 0x0600E07C RID: 57468
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridElevationQuery_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E07D RID: 57469 RVA: 0x001376A4 File Offset: 0x001358A4
		public override int IsA(string type)
		{
			return vtkCellGridElevationQuery.vtkCellGridElevationQuery_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600E07E RID: 57470
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridElevationQuery_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E07F RID: 57471 RVA: 0x001376C4 File Offset: 0x001358C4
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridElevationQuery.vtkCellGridElevationQuery_IsTypeOf_06(type);
		}

		// Token: 0x0600E080 RID: 57472
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridElevationQuery_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E081 RID: 57473 RVA: 0x001376E0 File Offset: 0x001358E0
		public new vtkCellGridElevationQuery NewInstance()
		{
			vtkCellGridElevationQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridElevationQuery.vtkCellGridElevationQuery_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridElevationQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E082 RID: 57474
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridElevationQuery_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E083 RID: 57475 RVA: 0x0013773C File Offset: 0x0013593C
		public new static vtkCellGridElevationQuery SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridElevationQuery vtkCellGridElevationQuery = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridElevationQuery.vtkCellGridElevationQuery_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridElevationQuery = (vtkCellGridElevationQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridElevationQuery.Register(null);
				}
			}
			return vtkCellGridElevationQuery;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400107B RID: 4219
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridElevationQuery";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400107C RID: 4220
		public new static readonly string MRClassNameKey = "class vtkCellGridElevationQuery";
	}
}
