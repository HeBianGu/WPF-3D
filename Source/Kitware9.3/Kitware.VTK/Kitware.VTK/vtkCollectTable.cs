using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCollectTable
	/// </summary>
	/// <remarks>
	///    Collect distributed table.
	///
	/// This filter has code to collect a table from across processes onto node 0.
	/// Collection can be turned on or off using the "PassThrough" flag.
	/// </remarks>
	// Token: 0x020004FB RID: 1275
	public class vtkCollectTable : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E57C RID: 58748 RVA: 0x0013FA6F File Offset: 0x0013DC6F
		static vtkCollectTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollectTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollectTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E57D RID: 58749 RVA: 0x0013FA97 File Offset: 0x0013DC97
		public vtkCollectTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E57E RID: 58750
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E57F RID: 58751 RVA: 0x0013FAA8 File Offset: 0x0013DCA8
		public new static vtkCollectTable New()
		{
			vtkCollectTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectTable.vtkCollectTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollectTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E580 RID: 58752 RVA: 0x0013FAFC File Offset: 0x0013DCFC
		public vtkCollectTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCollectTable.vtkCollectTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E581 RID: 58753 RVA: 0x0013FB40 File Offset: 0x0013DD40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E582 RID: 58754
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectTable_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600E583 RID: 58755 RVA: 0x0013FB4C File Offset: 0x0013DD4C
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectTable.vtkCollectTable_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600E584 RID: 58756
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollectTable_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E585 RID: 58757 RVA: 0x0013FBBC File Offset: 0x0013DDBC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCollectTable.vtkCollectTable_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E586 RID: 58758
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollectTable_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E587 RID: 58759 RVA: 0x0013FBDC File Offset: 0x0013DDDC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCollectTable.vtkCollectTable_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E588 RID: 58760
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectTable_GetPassThrough_04(HandleRef pThis);

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x0600E589 RID: 58761 RVA: 0x0013FBF8 File Offset: 0x0013DDF8
		public virtual int GetPassThrough()
		{
			return vtkCollectTable.vtkCollectTable_GetPassThrough_04(base.GetCppThis());
		}

		// Token: 0x0600E58A RID: 58762
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectTable_GetSocketController_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When this filter is being used in client-server mode,
		/// this is the controller used to communicate between
		/// client and server.  Client should not set the other controller.
		/// </summary>
		// Token: 0x0600E58B RID: 58763 RVA: 0x0013FC18 File Offset: 0x0013DE18
		public virtual vtkSocketController GetSocketController()
		{
			vtkSocketController vtkSocketController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectTable.vtkCollectTable_GetSocketController_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocketController = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocketController.Register(null);
				}
			}
			return vtkSocketController;
		}

		// Token: 0x0600E58C RID: 58764
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectTable_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E58D RID: 58765 RVA: 0x0013FC88 File Offset: 0x0013DE88
		public override int IsA(string type)
		{
			return vtkCollectTable.vtkCollectTable_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600E58E RID: 58766
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectTable_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E58F RID: 58767 RVA: 0x0013FCA8 File Offset: 0x0013DEA8
		public new static int IsTypeOf(string type)
		{
			return vtkCollectTable.vtkCollectTable_IsTypeOf_07(type);
		}

		// Token: 0x0600E590 RID: 58768
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectTable_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E591 RID: 58769 RVA: 0x0013FCC4 File Offset: 0x0013DEC4
		public new vtkCollectTable NewInstance()
		{
			vtkCollectTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectTable.vtkCollectTable_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollectTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E592 RID: 58770
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectTable_PassThroughOff_10(HandleRef pThis);

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x0600E593 RID: 58771 RVA: 0x0013FD1E File Offset: 0x0013DF1E
		public virtual void PassThroughOff()
		{
			vtkCollectTable.vtkCollectTable_PassThroughOff_10(base.GetCppThis());
		}

		// Token: 0x0600E594 RID: 58772
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectTable_PassThroughOn_11(HandleRef pThis);

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x0600E595 RID: 58773 RVA: 0x0013FD2D File Offset: 0x0013DF2D
		public virtual void PassThroughOn()
		{
			vtkCollectTable.vtkCollectTable_PassThroughOn_11(base.GetCppThis());
		}

		// Token: 0x0600E596 RID: 58774
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectTable_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E597 RID: 58775 RVA: 0x0013FD3C File Offset: 0x0013DF3C
		public new static vtkCollectTable SafeDownCast(vtkObjectBase o)
		{
			vtkCollectTable vtkCollectTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectTable.vtkCollectTable_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollectTable = (vtkCollectTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollectTable.Register(null);
				}
			}
			return vtkCollectTable;
		}

		// Token: 0x0600E598 RID: 58776
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectTable_SetController_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600E599 RID: 58777 RVA: 0x0013FDBC File Offset: 0x0013DFBC
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkCollectTable.vtkCollectTable_SetController_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600E59A RID: 58778
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectTable_SetPassThrough_14(HandleRef pThis, int _arg);

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x0600E59B RID: 58779 RVA: 0x0013FDEB File Offset: 0x0013DFEB
		public virtual void SetPassThrough(int _arg)
		{
			vtkCollectTable.vtkCollectTable_SetPassThrough_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E59C RID: 58780
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectTable_SetSocketController_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// When this filter is being used in client-server mode,
		/// this is the controller used to communicate between
		/// client and server.  Client should not set the other controller.
		/// </summary>
		// Token: 0x0600E59D RID: 58781 RVA: 0x0013FDFC File Offset: 0x0013DFFC
		public virtual void SetSocketController(vtkSocketController arg0)
		{
			vtkCollectTable.vtkCollectTable_SetSocketController_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010DD RID: 4317
		public new const string MRFullTypeName = "Kitware.VTK.vtkCollectTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010DE RID: 4318
		public new static readonly string MRClassNameKey = "class vtkCollectTable";
	}
}
