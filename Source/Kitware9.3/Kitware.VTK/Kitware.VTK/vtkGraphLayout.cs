using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphLayout
	/// </summary>
	/// <remarks>
	///    layout a graph in 2 or 3 dimensions
	///
	///
	/// This class is a shell for many graph layout strategies which may be set
	/// using the SetLayoutStrategy() function.  The layout strategies do the
	/// actual work.
	///
	/// .SECTION Thanks
	/// Thanks to Brian Wylie from Sandia National Laboratories for adding incremental
	/// layout capabilities.
	/// </remarks>
	// Token: 0x02000291 RID: 657
	public class vtkGraphLayout : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060076EE RID: 30446 RVA: 0x000AB8CB File Offset: 0x000A9ACB
		static vtkGraphLayout()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphLayout.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphLayout"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060076EF RID: 30447 RVA: 0x000AB8F3 File Offset: 0x000A9AF3
		public vtkGraphLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060076F0 RID: 30448
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076F1 RID: 30449 RVA: 0x000AB904 File Offset: 0x000A9B04
		public new static vtkGraphLayout New()
		{
			vtkGraphLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayout.vtkGraphLayout_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076F2 RID: 30450 RVA: 0x000AB958 File Offset: 0x000A9B58
		public vtkGraphLayout() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphLayout.vtkGraphLayout_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060076F3 RID: 30451 RVA: 0x000AB99C File Offset: 0x000A9B9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060076F4 RID: 30452
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayout_GetLayoutStrategy_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The layout strategy to use during graph layout.
		/// </summary>
		// Token: 0x060076F5 RID: 30453 RVA: 0x000AB9A8 File Offset: 0x000A9BA8
		public virtual vtkGraphLayoutStrategy GetLayoutStrategy()
		{
			vtkGraphLayoutStrategy vtkGraphLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayout.vtkGraphLayout_GetLayoutStrategy_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayoutStrategy = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayoutStrategy.Register(null);
				}
			}
			return vtkGraphLayoutStrategy;
		}

		// Token: 0x060076F6 RID: 30454
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGraphLayout_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Get the modification time of the layout algorithm.
		/// </summary>
		// Token: 0x060076F7 RID: 30455 RVA: 0x000ABA18 File Offset: 0x000A9C18
		public override ulong GetMTime()
		{
			return vtkGraphLayout.vtkGraphLayout_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x060076F8 RID: 30456
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphLayout_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076F9 RID: 30457 RVA: 0x000ABA38 File Offset: 0x000A9C38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphLayout.vtkGraphLayout_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060076FA RID: 30458
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphLayout_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076FB RID: 30459 RVA: 0x000ABA58 File Offset: 0x000A9C58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphLayout.vtkGraphLayout_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060076FC RID: 30460
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayout_GetTransform_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Transform the graph vertices after the layout.
		/// </summary>
		// Token: 0x060076FD RID: 30461 RVA: 0x000ABA74 File Offset: 0x000A9C74
		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayout.vtkGraphLayout_GetTransform_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x060076FE RID: 30462
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayout_GetUseTransform_06(HandleRef pThis);

		/// <summary>
		/// Whether to use the specified transform after layout.
		/// </summary>
		// Token: 0x060076FF RID: 30463 RVA: 0x000ABAE4 File Offset: 0x000A9CE4
		public virtual bool GetUseTransform()
		{
			return vtkGraphLayout.vtkGraphLayout_GetUseTransform_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06007700 RID: 30464
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGraphLayout_GetZRange_07(HandleRef pThis);

		/// <summary>
		/// Set the ZRange for the output data.
		/// If the initial layout is planar (i.e. all z coordinates are zero),
		/// the coordinates will be evenly spaced from 0.0 to ZRange.
		/// The default is zero, which has no effect.
		/// </summary>
		// Token: 0x06007701 RID: 30465 RVA: 0x000ABB0C File Offset: 0x000A9D0C
		public virtual double GetZRange()
		{
			return vtkGraphLayout.vtkGraphLayout_GetZRange_07(base.GetCppThis());
		}

		// Token: 0x06007702 RID: 30466
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayout_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007703 RID: 30467 RVA: 0x000ABB2C File Offset: 0x000A9D2C
		public override int IsA(string type)
		{
			return vtkGraphLayout.vtkGraphLayout_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06007704 RID: 30468
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayout_IsLayoutComplete_09(HandleRef pThis);

		/// <summary>
		/// Ask the layout algorithm if the layout is complete
		/// </summary>
		// Token: 0x06007705 RID: 30469 RVA: 0x000ABB4C File Offset: 0x000A9D4C
		public virtual int IsLayoutComplete()
		{
			return vtkGraphLayout.vtkGraphLayout_IsLayoutComplete_09(base.GetCppThis());
		}

		// Token: 0x06007706 RID: 30470
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayout_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007707 RID: 30471 RVA: 0x000ABB6C File Offset: 0x000A9D6C
		public new static int IsTypeOf(string type)
		{
			return vtkGraphLayout.vtkGraphLayout_IsTypeOf_10(type);
		}

		// Token: 0x06007708 RID: 30472
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayout_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007709 RID: 30473 RVA: 0x000ABB88 File Offset: 0x000A9D88
		public new vtkGraphLayout NewInstance()
		{
			vtkGraphLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayout.vtkGraphLayout_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600770A RID: 30474
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayout_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600770B RID: 30475 RVA: 0x000ABBE4 File Offset: 0x000A9DE4
		public new static vtkGraphLayout SafeDownCast(vtkObjectBase o)
		{
			vtkGraphLayout vtkGraphLayout = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayout.vtkGraphLayout_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayout = (vtkGraphLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayout.Register(null);
				}
			}
			return vtkGraphLayout;
		}

		// Token: 0x0600770C RID: 30476
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayout_SetLayoutStrategy_14(HandleRef pThis, HandleRef strategy);

		/// <summary>
		/// The layout strategy to use during graph layout.
		/// </summary>
		// Token: 0x0600770D RID: 30477 RVA: 0x000ABC64 File Offset: 0x000A9E64
		public void SetLayoutStrategy(vtkGraphLayoutStrategy strategy)
		{
			vtkGraphLayout.vtkGraphLayout_SetLayoutStrategy_14(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		// Token: 0x0600770E RID: 30478
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayout_SetTransform_15(HandleRef pThis, HandleRef t);

		/// <summary>
		/// Transform the graph vertices after the layout.
		/// </summary>
		// Token: 0x0600770F RID: 30479 RVA: 0x000ABC94 File Offset: 0x000A9E94
		public virtual void SetTransform(vtkAbstractTransform t)
		{
			vtkGraphLayout.vtkGraphLayout_SetTransform_15(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		// Token: 0x06007710 RID: 30480
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayout_SetUseTransform_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to use the specified transform after layout.
		/// </summary>
		// Token: 0x06007711 RID: 30481 RVA: 0x000ABCC3 File Offset: 0x000A9EC3
		public virtual void SetUseTransform(bool _arg)
		{
			vtkGraphLayout.vtkGraphLayout_SetUseTransform_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06007712 RID: 30482
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayout_SetZRange_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the ZRange for the output data.
		/// If the initial layout is planar (i.e. all z coordinates are zero),
		/// the coordinates will be evenly spaced from 0.0 to ZRange.
		/// The default is zero, which has no effect.
		/// </summary>
		// Token: 0x06007713 RID: 30483 RVA: 0x000ABCDB File Offset: 0x000A9EDB
		public virtual void SetZRange(double _arg)
		{
			vtkGraphLayout.vtkGraphLayout_SetZRange_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06007714 RID: 30484
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayout_UseTransformOff_18(HandleRef pThis);

		/// <summary>
		/// Whether to use the specified transform after layout.
		/// </summary>
		// Token: 0x06007715 RID: 30485 RVA: 0x000ABCEB File Offset: 0x000A9EEB
		public virtual void UseTransformOff()
		{
			vtkGraphLayout.vtkGraphLayout_UseTransformOff_18(base.GetCppThis());
		}

		// Token: 0x06007716 RID: 30486
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayout_UseTransformOn_19(HandleRef pThis);

		/// <summary>
		/// Whether to use the specified transform after layout.
		/// </summary>
		// Token: 0x06007717 RID: 30487 RVA: 0x000ABCFA File Offset: 0x000A9EFA
		public virtual void UseTransformOn()
		{
			vtkGraphLayout.vtkGraphLayout_UseTransformOn_19(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A30 RID: 2608
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphLayout";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A31 RID: 2609
		public new static readonly string MRClassNameKey = "class vtkGraphLayout";
	}
}
