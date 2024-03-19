using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDuplicatePolyData
	/// </summary>
	/// <remarks>
	///    For distributed tiled displays.
	///
	/// This filter collects poly data and duplicates it on every node.
	/// Converts data parallel so every node has a complete copy of the data.
	/// The filter is used at the end of a pipeline for driving a tiled
	/// display.
	/// </remarks>
	// Token: 0x020004FF RID: 1279
	public class vtkDuplicatePolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E62C RID: 58924 RVA: 0x001408F8 File Offset: 0x0013EAF8
		static vtkDuplicatePolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDuplicatePolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDuplicatePolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E62D RID: 58925 RVA: 0x00140920 File Offset: 0x0013EB20
		public vtkDuplicatePolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E62E RID: 58926
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDuplicatePolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E62F RID: 58927 RVA: 0x00140930 File Offset: 0x0013EB30
		public new static vtkDuplicatePolyData New()
		{
			vtkDuplicatePolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDuplicatePolyData.vtkDuplicatePolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDuplicatePolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E630 RID: 58928 RVA: 0x00140984 File Offset: 0x0013EB84
		public vtkDuplicatePolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDuplicatePolyData.vtkDuplicatePolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E631 RID: 58929 RVA: 0x001409C8 File Offset: 0x0013EBC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E632 RID: 58930
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDuplicatePolyData_GetClientFlag_01(HandleRef pThis);

		/// <summary>
		/// This duplicate filter works in client server mode when this
		/// controller is set.  We have a client flag to differentiate the
		/// client and server because the socket controller is odd:
		/// Proth processes think their id is 0.
		/// </summary>
		// Token: 0x0600E633 RID: 58931 RVA: 0x001409D4 File Offset: 0x0013EBD4
		public virtual int GetClientFlag()
		{
			return vtkDuplicatePolyData.vtkDuplicatePolyData_GetClientFlag_01(base.GetCppThis());
		}

		// Token: 0x0600E634 RID: 58932
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDuplicatePolyData_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600E635 RID: 58933 RVA: 0x001409F4 File Offset: 0x0013EBF4
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDuplicatePolyData.vtkDuplicatePolyData_GetController_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E636 RID: 58934
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDuplicatePolyData_GetMemorySize_03(HandleRef pThis);

		/// <summary>
		/// This returns to size of the output (on this process).
		/// This method is not really used.  It is needed to have
		/// the same API as vtkCollectPolyData.
		/// </summary>
		// Token: 0x0600E637 RID: 58935 RVA: 0x00140A64 File Offset: 0x0013EC64
		public virtual uint GetMemorySize()
		{
			return vtkDuplicatePolyData.vtkDuplicatePolyData_GetMemorySize_03(base.GetCppThis());
		}

		// Token: 0x0600E638 RID: 58936
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDuplicatePolyData_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E639 RID: 58937 RVA: 0x00140A84 File Offset: 0x0013EC84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDuplicatePolyData.vtkDuplicatePolyData_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E63A RID: 58938
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDuplicatePolyData_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E63B RID: 58939 RVA: 0x00140AA4 File Offset: 0x0013ECA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDuplicatePolyData.vtkDuplicatePolyData_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600E63C RID: 58940
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDuplicatePolyData_GetSocketController_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This duplicate filter works in client server mode when this
		/// controller is set.  We have a client flag to differentiate the
		/// client and server because the socket controller is odd:
		/// Proth processes think their id is 0.
		/// </summary>
		// Token: 0x0600E63D RID: 58941 RVA: 0x00140AC0 File Offset: 0x0013ECC0
		public vtkSocketController GetSocketController()
		{
			vtkSocketController vtkSocketController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDuplicatePolyData.vtkDuplicatePolyData_GetSocketController_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E63E RID: 58942
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDuplicatePolyData_GetSynchronous_07(HandleRef pThis);

		/// <summary>
		/// This flag causes sends and receives to be matched.
		/// When this flag is off, two sends occur then two receives.
		/// I want to see if it makes a difference in performance.
		/// The flag is on by default.
		/// </summary>
		// Token: 0x0600E63F RID: 58943 RVA: 0x00140B30 File Offset: 0x0013ED30
		public virtual int GetSynchronous()
		{
			return vtkDuplicatePolyData.vtkDuplicatePolyData_GetSynchronous_07(base.GetCppThis());
		}

		// Token: 0x0600E640 RID: 58944
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDuplicatePolyData_InitializeSchedule_08(HandleRef pThis, int numProcs);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600E641 RID: 58945 RVA: 0x00140B4F File Offset: 0x0013ED4F
		public void InitializeSchedule(int numProcs)
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_InitializeSchedule_08(base.GetCppThis(), numProcs);
		}

		// Token: 0x0600E642 RID: 58946
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDuplicatePolyData_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E643 RID: 58947 RVA: 0x00140B60 File Offset: 0x0013ED60
		public override int IsA(string type)
		{
			return vtkDuplicatePolyData.vtkDuplicatePolyData_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600E644 RID: 58948
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDuplicatePolyData_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E645 RID: 58949 RVA: 0x00140B80 File Offset: 0x0013ED80
		public new static int IsTypeOf(string type)
		{
			return vtkDuplicatePolyData.vtkDuplicatePolyData_IsTypeOf_10(type);
		}

		// Token: 0x0600E646 RID: 58950
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDuplicatePolyData_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E647 RID: 58951 RVA: 0x00140B9C File Offset: 0x0013ED9C
		public new vtkDuplicatePolyData NewInstance()
		{
			vtkDuplicatePolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDuplicatePolyData.vtkDuplicatePolyData_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDuplicatePolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E648 RID: 58952
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDuplicatePolyData_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E649 RID: 58953 RVA: 0x00140BF8 File Offset: 0x0013EDF8
		public new static vtkDuplicatePolyData SafeDownCast(vtkObjectBase o)
		{
			vtkDuplicatePolyData vtkDuplicatePolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDuplicatePolyData.vtkDuplicatePolyData_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDuplicatePolyData = (vtkDuplicatePolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDuplicatePolyData.Register(null);
				}
			}
			return vtkDuplicatePolyData;
		}

		// Token: 0x0600E64A RID: 58954
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDuplicatePolyData_SetClientFlag_14(HandleRef pThis, int _arg);

		/// <summary>
		/// This duplicate filter works in client server mode when this
		/// controller is set.  We have a client flag to differentiate the
		/// client and server because the socket controller is odd:
		/// Proth processes think their id is 0.
		/// </summary>
		// Token: 0x0600E64B RID: 58955 RVA: 0x00140C77 File Offset: 0x0013EE77
		public virtual void SetClientFlag(int _arg)
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_SetClientFlag_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E64C RID: 58956
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDuplicatePolyData_SetController_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600E64D RID: 58957 RVA: 0x00140C88 File Offset: 0x0013EE88
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_SetController_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600E64E RID: 58958
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDuplicatePolyData_SetSocketController_16(HandleRef pThis, HandleRef controller);

		/// <summary>
		/// This duplicate filter works in client server mode when this
		/// controller is set.  We have a client flag to differentiate the
		/// client and server because the socket controller is odd:
		/// Proth processes think their id is 0.
		/// </summary>
		// Token: 0x0600E64F RID: 58959 RVA: 0x00140CB8 File Offset: 0x0013EEB8
		public void SetSocketController(vtkSocketController controller)
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_SetSocketController_16(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		// Token: 0x0600E650 RID: 58960
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDuplicatePolyData_SetSynchronous_17(HandleRef pThis, int _arg);

		/// <summary>
		/// This flag causes sends and receives to be matched.
		/// When this flag is off, two sends occur then two receives.
		/// I want to see if it makes a difference in performance.
		/// The flag is on by default.
		/// </summary>
		// Token: 0x0600E651 RID: 58961 RVA: 0x00140CE7 File Offset: 0x0013EEE7
		public virtual void SetSynchronous(int _arg)
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_SetSynchronous_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E652 RID: 58962
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDuplicatePolyData_SynchronousOff_18(HandleRef pThis);

		/// <summary>
		/// This flag causes sends and receives to be matched.
		/// When this flag is off, two sends occur then two receives.
		/// I want to see if it makes a difference in performance.
		/// The flag is on by default.
		/// </summary>
		// Token: 0x0600E653 RID: 58963 RVA: 0x00140CF7 File Offset: 0x0013EEF7
		public virtual void SynchronousOff()
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_SynchronousOff_18(base.GetCppThis());
		}

		// Token: 0x0600E654 RID: 58964
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDuplicatePolyData_SynchronousOn_19(HandleRef pThis);

		/// <summary>
		/// This flag causes sends and receives to be matched.
		/// When this flag is off, two sends occur then two receives.
		/// I want to see if it makes a difference in performance.
		/// The flag is on by default.
		/// </summary>
		// Token: 0x0600E655 RID: 58965 RVA: 0x00140D06 File Offset: 0x0013EF06
		public virtual void SynchronousOn()
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_SynchronousOn_19(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010E7 RID: 4327
		public new const string MRFullTypeName = "Kitware.VTK.vtkDuplicatePolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010E8 RID: 4328
		public new static readonly string MRClassNameKey = "class vtkDuplicatePolyData";
	}
}
