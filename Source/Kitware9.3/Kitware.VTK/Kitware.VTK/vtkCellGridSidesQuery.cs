using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridSidesQuery
	/// </summary>
	/// <remarks>
	///    Compute external faces of a cell-grid.
	/// </remarks>
	// Token: 0x02000A24 RID: 2596
	public class vtkCellGridSidesQuery : vtkCellGridQuery
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B0E0 RID: 110816 RVA: 0x0025C353 File Offset: 0x0025A553
		static vtkCellGridSidesQuery()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridSidesQuery.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridSidesQuery"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B0E1 RID: 110817 RVA: 0x0025C37B File Offset: 0x0025A57B
		public vtkCellGridSidesQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B0E2 RID: 110818
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridSidesQuery_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0E3 RID: 110819 RVA: 0x0025C38C File Offset: 0x0025A58C
		public new static vtkCellGridSidesQuery New()
		{
			vtkCellGridSidesQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridSidesQuery.vtkCellGridSidesQuery_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridSidesQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0E4 RID: 110820 RVA: 0x0025C3E0 File Offset: 0x0025A5E0
		public vtkCellGridSidesQuery() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridSidesQuery.vtkCellGridSidesQuery_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B0E5 RID: 110821 RVA: 0x0025C424 File Offset: 0x0025A624
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B0E6 RID: 110822
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridSidesQuery_Finalize_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0E7 RID: 110823 RVA: 0x0025C42F File Offset: 0x0025A62F
		public override void FinalizeWrapper()
		{
			vtkCellGridSidesQuery.vtkCellGridSidesQuery_Finalize_01(base.GetCppThis());
		}

		// Token: 0x0601B0E8 RID: 110824
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridSidesQuery_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0E9 RID: 110825 RVA: 0x0025C440 File Offset: 0x0025A640
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridSidesQuery.vtkCellGridSidesQuery_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601B0EA RID: 110826
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridSidesQuery_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0EB RID: 110827 RVA: 0x0025C460 File Offset: 0x0025A660
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridSidesQuery.vtkCellGridSidesQuery_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601B0EC RID: 110828
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridSidesQuery_GetPreserveRenderableCells_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0ED RID: 110829 RVA: 0x0025C47C File Offset: 0x0025A67C
		public virtual int GetPreserveRenderableCells()
		{
			return vtkCellGridSidesQuery.vtkCellGridSidesQuery_GetPreserveRenderableCells_04(base.GetCppThis());
		}

		// Token: 0x0601B0EE RID: 110830
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridSidesQuery_Initialize_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0EF RID: 110831 RVA: 0x0025C49B File Offset: 0x0025A69B
		public override void Initialize()
		{
			vtkCellGridSidesQuery.vtkCellGridSidesQuery_Initialize_05(base.GetCppThis());
		}

		// Token: 0x0601B0F0 RID: 110832
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridSidesQuery_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0F1 RID: 110833 RVA: 0x0025C4AC File Offset: 0x0025A6AC
		public override int IsA(string type)
		{
			return vtkCellGridSidesQuery.vtkCellGridSidesQuery_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B0F2 RID: 110834
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGridSidesQuery_IsAnotherPassRequired_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0F3 RID: 110835 RVA: 0x0025C4CC File Offset: 0x0025A6CC
		public override bool IsAnotherPassRequired()
		{
			return vtkCellGridSidesQuery.vtkCellGridSidesQuery_IsAnotherPassRequired_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0601B0F4 RID: 110836
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridSidesQuery_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0F5 RID: 110837 RVA: 0x0025C4F4 File Offset: 0x0025A6F4
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridSidesQuery.vtkCellGridSidesQuery_IsTypeOf_08(type);
		}

		// Token: 0x0601B0F6 RID: 110838
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridSidesQuery_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0F7 RID: 110839 RVA: 0x0025C510 File Offset: 0x0025A710
		public new vtkCellGridSidesQuery NewInstance()
		{
			vtkCellGridSidesQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridSidesQuery.vtkCellGridSidesQuery_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridSidesQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B0F8 RID: 110840
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridSidesQuery_PreserveRenderableCellsOff_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0F9 RID: 110841 RVA: 0x0025C56A File Offset: 0x0025A76A
		public virtual void PreserveRenderableCellsOff()
		{
			vtkCellGridSidesQuery.vtkCellGridSidesQuery_PreserveRenderableCellsOff_11(base.GetCppThis());
		}

		// Token: 0x0601B0FA RID: 110842
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridSidesQuery_PreserveRenderableCellsOn_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0FB RID: 110843 RVA: 0x0025C579 File Offset: 0x0025A779
		public virtual void PreserveRenderableCellsOn()
		{
			vtkCellGridSidesQuery.vtkCellGridSidesQuery_PreserveRenderableCellsOn_12(base.GetCppThis());
		}

		// Token: 0x0601B0FC RID: 110844
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridSidesQuery_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0FD RID: 110845 RVA: 0x0025C588 File Offset: 0x0025A788
		public new static vtkCellGridSidesQuery SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridSidesQuery vtkCellGridSidesQuery = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridSidesQuery.vtkCellGridSidesQuery_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridSidesQuery = (vtkCellGridSidesQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridSidesQuery.Register(null);
				}
			}
			return vtkCellGridSidesQuery;
		}

		// Token: 0x0601B0FE RID: 110846
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridSidesQuery_SetPreserveRenderableCells_14(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0FF RID: 110847 RVA: 0x0025C607 File Offset: 0x0025A807
		public virtual void SetPreserveRenderableCells(int _arg)
		{
			vtkCellGridSidesQuery.vtkCellGridSidesQuery_SetPreserveRenderableCells_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B100 RID: 110848
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridSidesQuery_StartPass_15(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B101 RID: 110849 RVA: 0x0025C617 File Offset: 0x0025A817
		public override void StartPass()
		{
			vtkCellGridSidesQuery.vtkCellGridSidesQuery_StartPass_15(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D3A RID: 7482
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridSidesQuery";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D3B RID: 7483
		public new static readonly string MRClassNameKey = "class vtkCellGridSidesQuery";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000A25 RID: 2597
		public enum PassWork
		{
			/// <summary>enum member</summary>
			// Token: 0x04001D3D RID: 7485
			GenerateSideSets = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001D3E RID: 7486
			HashSides = 0
		}
	}
}
