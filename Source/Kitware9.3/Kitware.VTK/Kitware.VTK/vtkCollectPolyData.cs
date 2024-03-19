using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCollectPolyData
	/// </summary>
	/// <remarks>
	///    Collect distributed polydata.
	///
	/// This filter has code to collect polydat from across processes onto node 0.
	/// Collection can be turned on or off using the "PassThrough" flag.
	/// </remarks>
	// Token: 0x020004FA RID: 1274
	public class vtkCollectPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E55A RID: 58714 RVA: 0x0013F6B3 File Offset: 0x0013D8B3
		static vtkCollectPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollectPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollectPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E55B RID: 58715 RVA: 0x0013F6DB File Offset: 0x0013D8DB
		public vtkCollectPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E55C RID: 58716
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E55D RID: 58717 RVA: 0x0013F6EC File Offset: 0x0013D8EC
		public new static vtkCollectPolyData New()
		{
			vtkCollectPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectPolyData.vtkCollectPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollectPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E55E RID: 58718 RVA: 0x0013F740 File Offset: 0x0013D940
		public vtkCollectPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCollectPolyData.vtkCollectPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E55F RID: 58719 RVA: 0x0013F784 File Offset: 0x0013D984
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E560 RID: 58720
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectPolyData_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600E561 RID: 58721 RVA: 0x0013F790 File Offset: 0x0013D990
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectPolyData.vtkCollectPolyData_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E562 RID: 58722
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollectPolyData_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E563 RID: 58723 RVA: 0x0013F800 File Offset: 0x0013DA00
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCollectPolyData.vtkCollectPolyData_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E564 RID: 58724
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollectPolyData_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E565 RID: 58725 RVA: 0x0013F820 File Offset: 0x0013DA20
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCollectPolyData.vtkCollectPolyData_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E566 RID: 58726
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectPolyData_GetPassThrough_04(HandleRef pThis);

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x0600E567 RID: 58727 RVA: 0x0013F83C File Offset: 0x0013DA3C
		public virtual int GetPassThrough()
		{
			return vtkCollectPolyData.vtkCollectPolyData_GetPassThrough_04(base.GetCppThis());
		}

		// Token: 0x0600E568 RID: 58728
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectPolyData_GetSocketController_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When this filter is being used in client-server mode,
		/// this is the controller used to communicate between
		/// client and server.  Client should not set the other controller.
		/// </summary>
		// Token: 0x0600E569 RID: 58729 RVA: 0x0013F85C File Offset: 0x0013DA5C
		public virtual vtkSocketController GetSocketController()
		{
			vtkSocketController vtkSocketController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectPolyData.vtkCollectPolyData_GetSocketController_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E56A RID: 58730
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectPolyData_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E56B RID: 58731 RVA: 0x0013F8CC File Offset: 0x0013DACC
		public override int IsA(string type)
		{
			return vtkCollectPolyData.vtkCollectPolyData_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600E56C RID: 58732
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectPolyData_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E56D RID: 58733 RVA: 0x0013F8EC File Offset: 0x0013DAEC
		public new static int IsTypeOf(string type)
		{
			return vtkCollectPolyData.vtkCollectPolyData_IsTypeOf_07(type);
		}

		// Token: 0x0600E56E RID: 58734
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectPolyData_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E56F RID: 58735 RVA: 0x0013F908 File Offset: 0x0013DB08
		public new vtkCollectPolyData NewInstance()
		{
			vtkCollectPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectPolyData.vtkCollectPolyData_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollectPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E570 RID: 58736
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectPolyData_PassThroughOff_10(HandleRef pThis);

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x0600E571 RID: 58737 RVA: 0x0013F962 File Offset: 0x0013DB62
		public virtual void PassThroughOff()
		{
			vtkCollectPolyData.vtkCollectPolyData_PassThroughOff_10(base.GetCppThis());
		}

		// Token: 0x0600E572 RID: 58738
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectPolyData_PassThroughOn_11(HandleRef pThis);

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x0600E573 RID: 58739 RVA: 0x0013F971 File Offset: 0x0013DB71
		public virtual void PassThroughOn()
		{
			vtkCollectPolyData.vtkCollectPolyData_PassThroughOn_11(base.GetCppThis());
		}

		// Token: 0x0600E574 RID: 58740
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectPolyData_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E575 RID: 58741 RVA: 0x0013F980 File Offset: 0x0013DB80
		public new static vtkCollectPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkCollectPolyData vtkCollectPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectPolyData.vtkCollectPolyData_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollectPolyData = (vtkCollectPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollectPolyData.Register(null);
				}
			}
			return vtkCollectPolyData;
		}

		// Token: 0x0600E576 RID: 58742
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectPolyData_SetController_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600E577 RID: 58743 RVA: 0x0013FA00 File Offset: 0x0013DC00
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkCollectPolyData.vtkCollectPolyData_SetController_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600E578 RID: 58744
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectPolyData_SetPassThrough_14(HandleRef pThis, int _arg);

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x0600E579 RID: 58745 RVA: 0x0013FA2F File Offset: 0x0013DC2F
		public virtual void SetPassThrough(int _arg)
		{
			vtkCollectPolyData.vtkCollectPolyData_SetPassThrough_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E57A RID: 58746
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectPolyData_SetSocketController_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// When this filter is being used in client-server mode,
		/// this is the controller used to communicate between
		/// client and server.  Client should not set the other controller.
		/// </summary>
		// Token: 0x0600E57B RID: 58747 RVA: 0x0013FA40 File Offset: 0x0013DC40
		public virtual void SetSocketController(vtkSocketController arg0)
		{
			vtkCollectPolyData.vtkCollectPolyData_SetSocketController_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010DB RID: 4315
		public new const string MRFullTypeName = "Kitware.VTK.vtkCollectPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010DC RID: 4316
		public new static readonly string MRClassNameKey = "class vtkCollectPolyData";
	}
}
