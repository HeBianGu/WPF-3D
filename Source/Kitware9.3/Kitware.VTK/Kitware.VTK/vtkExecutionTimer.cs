using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExecutionTimer
	/// </summary>
	/// <remarks>
	///    Time filter execution
	///
	///
	///
	/// This object monitors a single filter for StartEvent and EndEvent.
	/// Each time it hears StartEvent it records the time.  Each time it
	/// hears EndEvent it measures the elapsed time (both CPU and
	/// wall-clock) since the most recent StartEvent.  Internally we use
	/// vtkTimerLog for measurements.
	///
	/// By default we simply store the elapsed time.  You are welcome to
	/// subclass and override TimerFinished() to do anything you want.
	/// </remarks>
	// Token: 0x0200095F RID: 2399
	public class vtkExecutionTimer : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018F68 RID: 102248 RVA: 0x0022CF64 File Offset: 0x0022B164
		static vtkExecutionTimer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExecutionTimer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExecutionTimer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018F69 RID: 102249 RVA: 0x0022CF8C File Offset: 0x0022B18C
		public vtkExecutionTimer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018F6A RID: 102250
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutionTimer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a new timer with no attached filter.  Use SetFilter()
		/// to specify the vtkAlgorithm whose execution you want to time.
		/// </summary>
		// Token: 0x06018F6B RID: 102251 RVA: 0x0022CF9C File Offset: 0x0022B19C
		public new static vtkExecutionTimer New()
		{
			vtkExecutionTimer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutionTimer.vtkExecutionTimer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExecutionTimer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a new timer with no attached filter.  Use SetFilter()
		/// to specify the vtkAlgorithm whose execution you want to time.
		/// </summary>
		// Token: 0x06018F6C RID: 102252 RVA: 0x0022CFF0 File Offset: 0x0022B1F0
		public vtkExecutionTimer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExecutionTimer.vtkExecutionTimer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018F6D RID: 102253 RVA: 0x0022D034 File Offset: 0x0022B234
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018F6E RID: 102254
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExecutionTimer_GetElapsedCPUTime_01(HandleRef pThis);

		/// <summary>
		/// Get the total CPU time (in seconds) that elapsed between
		/// StartEvent and EndEvent.  This is undefined before the filter has
		/// finished executing.
		/// </summary>
		// Token: 0x06018F6F RID: 102255 RVA: 0x0022D040 File Offset: 0x0022B240
		public virtual double GetElapsedCPUTime()
		{
			return vtkExecutionTimer.vtkExecutionTimer_GetElapsedCPUTime_01(base.GetCppThis());
		}

		// Token: 0x06018F70 RID: 102256
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExecutionTimer_GetElapsedWallClockTime_02(HandleRef pThis);

		/// <summary>
		/// Get the total wall clock time (in seconds) that elapsed between
		/// StartEvent and EndEvent.  This is undefined before the filter has
		/// finished executing.
		/// </summary>
		// Token: 0x06018F71 RID: 102257 RVA: 0x0022D060 File Offset: 0x0022B260
		public virtual double GetElapsedWallClockTime()
		{
			return vtkExecutionTimer.vtkExecutionTimer_GetElapsedWallClockTime_02(base.GetCppThis());
		}

		// Token: 0x06018F72 RID: 102258
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutionTimer_GetFilter_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the filter to be monitored.  The only real constraint
		/// here is that the vtkExecutive associated with the filter must
		/// fire StartEvent and EndEvent before and after the filter is
		/// executed.  All VTK executives should do this.
		/// </summary>
		// Token: 0x06018F73 RID: 102259 RVA: 0x0022D080 File Offset: 0x0022B280
		public virtual vtkAlgorithm GetFilter()
		{
			vtkAlgorithm vtkAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutionTimer.vtkExecutionTimer_GetFilter_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithm = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithm.Register(null);
				}
			}
			return vtkAlgorithm;
		}

		// Token: 0x06018F74 RID: 102260
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExecutionTimer_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F75 RID: 102261 RVA: 0x0022D0F0 File Offset: 0x0022B2F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExecutionTimer.vtkExecutionTimer_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06018F76 RID: 102262
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExecutionTimer_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F77 RID: 102263 RVA: 0x0022D110 File Offset: 0x0022B310
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExecutionTimer.vtkExecutionTimer_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06018F78 RID: 102264
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutionTimer_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F79 RID: 102265 RVA: 0x0022D12C File Offset: 0x0022B32C
		public override int IsA(string type)
		{
			return vtkExecutionTimer.vtkExecutionTimer_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06018F7A RID: 102266
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutionTimer_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F7B RID: 102267 RVA: 0x0022D14C File Offset: 0x0022B34C
		public new static int IsTypeOf(string type)
		{
			return vtkExecutionTimer.vtkExecutionTimer_IsTypeOf_07(type);
		}

		// Token: 0x06018F7C RID: 102268
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutionTimer_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F7D RID: 102269 RVA: 0x0022D168 File Offset: 0x0022B368
		public new vtkExecutionTimer NewInstance()
		{
			vtkExecutionTimer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutionTimer.vtkExecutionTimer_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExecutionTimer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018F7E RID: 102270
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutionTimer_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F7F RID: 102271 RVA: 0x0022D1C4 File Offset: 0x0022B3C4
		public new static vtkExecutionTimer SafeDownCast(vtkObjectBase o)
		{
			vtkExecutionTimer vtkExecutionTimer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutionTimer.vtkExecutionTimer_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutionTimer = (vtkExecutionTimer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutionTimer.Register(null);
				}
			}
			return vtkExecutionTimer;
		}

		// Token: 0x06018F80 RID: 102272
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutionTimer_SetFilter_11(HandleRef pThis, HandleRef filter);

		/// <summary>
		/// Set/get the filter to be monitored.  The only real constraint
		/// here is that the vtkExecutive associated with the filter must
		/// fire StartEvent and EndEvent before and after the filter is
		/// executed.  All VTK executives should do this.
		/// </summary>
		// Token: 0x06018F81 RID: 102273 RVA: 0x0022D244 File Offset: 0x0022B444
		public void SetFilter(vtkAlgorithm filter)
		{
			vtkExecutionTimer.vtkExecutionTimer_SetFilter_11(base.GetCppThis(), (filter == null) ? default(HandleRef) : filter.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B77 RID: 7031
		public new const string MRFullTypeName = "Kitware.VTK.vtkExecutionTimer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B78 RID: 7032
		public new static readonly string MRClassNameKey = "class vtkExecutionTimer";
	}
}
