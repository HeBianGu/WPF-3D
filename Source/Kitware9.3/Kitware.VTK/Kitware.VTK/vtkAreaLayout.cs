using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAreaLayout
	/// </summary>
	/// <remarks>
	///    layout a vtkTree into a tree map
	///
	///
	/// vtkAreaLayout assigns sector regions to each vertex in the tree,
	/// creating a tree ring.  The data is added as a data array with four
	/// components per tuple representing the location and size of the
	/// sector using the format (StartAngle, EndAngle, innerRadius, outerRadius).
	///
	/// This algorithm relies on a helper class to perform the actual layout.
	/// This helper class is a subclass of vtkAreaLayoutStrategy.
	///
	/// @par Thanks:
	/// Thanks to Jason Shepherd from Sandia National Laboratories
	/// for help developing this class.
	/// </remarks>
	// Token: 0x0200027A RID: 634
	public class vtkAreaLayout : vtkTreeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007342 RID: 29506 RVA: 0x000A697B File Offset: 0x000A4B7B
		static vtkAreaLayout()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAreaLayout.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAreaLayout"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007343 RID: 29507 RVA: 0x000A69A3 File Offset: 0x000A4BA3
		public vtkAreaLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007344 RID: 29508
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007345 RID: 29509 RVA: 0x000A69B4 File Offset: 0x000A4BB4
		public new static vtkAreaLayout New()
		{
			vtkAreaLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaLayout.vtkAreaLayout_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAreaLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007346 RID: 29510 RVA: 0x000A6A08 File Offset: 0x000A4C08
		public vtkAreaLayout() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAreaLayout.vtkAreaLayout_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007347 RID: 29511 RVA: 0x000A6A4C File Offset: 0x000A4C4C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007348 RID: 29512
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaLayout_EdgeRoutingPointsOff_01(HandleRef pThis);

		/// <summary>
		/// Whether to output a second output tree with vertex locations
		/// appropriate for routing bundled edges. Default is on.
		/// </summary>
		// Token: 0x06007349 RID: 29513 RVA: 0x000A6A57 File Offset: 0x000A4C57
		public virtual void EdgeRoutingPointsOff()
		{
			vtkAreaLayout.vtkAreaLayout_EdgeRoutingPointsOff_01(base.GetCppThis());
		}

		// Token: 0x0600734A RID: 29514
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaLayout_EdgeRoutingPointsOn_02(HandleRef pThis);

		/// <summary>
		/// Whether to output a second output tree with vertex locations
		/// appropriate for routing bundled edges. Default is on.
		/// </summary>
		// Token: 0x0600734B RID: 29515 RVA: 0x000A6A66 File Offset: 0x000A4C66
		public virtual void EdgeRoutingPointsOn()
		{
			vtkAreaLayout.vtkAreaLayout_EdgeRoutingPointsOn_02(base.GetCppThis());
		}

		// Token: 0x0600734C RID: 29516
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAreaLayout_FindVertex_03(HandleRef pThis, IntPtr pnt);

		/// <summary>
		/// Get the vertex whose area contains the point, or return -1
		/// if no vertex area covers the point.
		/// </summary>
		// Token: 0x0600734D RID: 29517 RVA: 0x000A6A78 File Offset: 0x000A4C78
		public long FindVertex(IntPtr pnt)
		{
			return vtkAreaLayout.vtkAreaLayout_FindVertex_03(base.GetCppThis(), pnt);
		}

		// Token: 0x0600734E RID: 29518
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaLayout_GetAreaArrayName_04(HandleRef pThis);

		/// <summary>
		/// The name for the array created for the area for each vertex.
		/// The rectangles are stored in a quadruple float array
		/// (startAngle, endAngle, innerRadius, outerRadius).
		/// For rectangular layouts, this is (minx, maxx, miny, maxy).
		/// </summary>
		// Token: 0x0600734F RID: 29519 RVA: 0x000A6A98 File Offset: 0x000A4C98
		public virtual string GetAreaArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAreaLayout.vtkAreaLayout_GetAreaArrayName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007350 RID: 29520
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaLayout_GetBoundingArea_05(HandleRef pThis, long id, IntPtr sinfo);

		/// <summary>
		/// The bounding area information for a certain vertex id.
		/// </summary>
		// Token: 0x06007351 RID: 29521 RVA: 0x000A6AD2 File Offset: 0x000A4CD2
		public void GetBoundingArea(long id, IntPtr sinfo)
		{
			vtkAreaLayout.vtkAreaLayout_GetBoundingArea_05(base.GetCppThis(), id, sinfo);
		}

		// Token: 0x06007352 RID: 29522
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAreaLayout_GetEdgeRoutingPoints_06(HandleRef pThis);

		/// <summary>
		/// Whether to output a second output tree with vertex locations
		/// appropriate for routing bundled edges. Default is on.
		/// </summary>
		// Token: 0x06007353 RID: 29523 RVA: 0x000A6AE4 File Offset: 0x000A4CE4
		public virtual bool GetEdgeRoutingPoints()
		{
			return vtkAreaLayout.vtkAreaLayout_GetEdgeRoutingPoints_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06007354 RID: 29524
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaLayout_GetLayoutStrategy_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The strategy to use when laying out the tree map.
		/// </summary>
		// Token: 0x06007355 RID: 29525 RVA: 0x000A6B0C File Offset: 0x000A4D0C
		public virtual vtkAreaLayoutStrategy GetLayoutStrategy()
		{
			vtkAreaLayoutStrategy vtkAreaLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaLayout.vtkAreaLayout_GetLayoutStrategy_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaLayoutStrategy = (vtkAreaLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaLayoutStrategy.Register(null);
				}
			}
			return vtkAreaLayoutStrategy;
		}

		// Token: 0x06007356 RID: 29526
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAreaLayout_GetMTime_08(HandleRef pThis);

		/// <summary>
		/// Get the modification time of the layout algorithm.
		/// </summary>
		// Token: 0x06007357 RID: 29527 RVA: 0x000A6B7C File Offset: 0x000A4D7C
		public override ulong GetMTime()
		{
			return vtkAreaLayout.vtkAreaLayout_GetMTime_08(base.GetCppThis());
		}

		// Token: 0x06007358 RID: 29528
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAreaLayout_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007359 RID: 29529 RVA: 0x000A6B9C File Offset: 0x000A4D9C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAreaLayout.vtkAreaLayout_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0600735A RID: 29530
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAreaLayout_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600735B RID: 29531 RVA: 0x000A6BBC File Offset: 0x000A4DBC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAreaLayout.vtkAreaLayout_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0600735C RID: 29532
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAreaLayout_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600735D RID: 29533 RVA: 0x000A6BD8 File Offset: 0x000A4DD8
		public override int IsA(string type)
		{
			return vtkAreaLayout.vtkAreaLayout_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600735E RID: 29534
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAreaLayout_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600735F RID: 29535 RVA: 0x000A6BF8 File Offset: 0x000A4DF8
		public new static int IsTypeOf(string type)
		{
			return vtkAreaLayout.vtkAreaLayout_IsTypeOf_12(type);
		}

		// Token: 0x06007360 RID: 29536
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaLayout_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007361 RID: 29537 RVA: 0x000A6C14 File Offset: 0x000A4E14
		public new vtkAreaLayout NewInstance()
		{
			vtkAreaLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaLayout.vtkAreaLayout_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAreaLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007362 RID: 29538
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaLayout_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007363 RID: 29539 RVA: 0x000A6C70 File Offset: 0x000A4E70
		public new static vtkAreaLayout SafeDownCast(vtkObjectBase o)
		{
			vtkAreaLayout vtkAreaLayout = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaLayout.vtkAreaLayout_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaLayout = (vtkAreaLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaLayout.Register(null);
				}
			}
			return vtkAreaLayout;
		}

		// Token: 0x06007364 RID: 29540
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaLayout_SetAreaArrayName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name for the array created for the area for each vertex.
		/// The rectangles are stored in a quadruple float array
		/// (startAngle, endAngle, innerRadius, outerRadius).
		/// For rectangular layouts, this is (minx, maxx, miny, maxy).
		/// </summary>
		// Token: 0x06007365 RID: 29541 RVA: 0x000A6CEF File Offset: 0x000A4EEF
		public virtual void SetAreaArrayName(string _arg)
		{
			vtkAreaLayout.vtkAreaLayout_SetAreaArrayName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06007366 RID: 29542
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaLayout_SetEdgeRoutingPoints_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to output a second output tree with vertex locations
		/// appropriate for routing bundled edges. Default is on.
		/// </summary>
		// Token: 0x06007367 RID: 29543 RVA: 0x000A6CFF File Offset: 0x000A4EFF
		public virtual void SetEdgeRoutingPoints(bool _arg)
		{
			vtkAreaLayout.vtkAreaLayout_SetEdgeRoutingPoints_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06007368 RID: 29544
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaLayout_SetLayoutStrategy_18(HandleRef pThis, HandleRef strategy);

		/// <summary>
		/// The strategy to use when laying out the tree map.
		/// </summary>
		// Token: 0x06007369 RID: 29545 RVA: 0x000A6D18 File Offset: 0x000A4F18
		public void SetLayoutStrategy(vtkAreaLayoutStrategy strategy)
		{
			vtkAreaLayout.vtkAreaLayout_SetLayoutStrategy_18(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		// Token: 0x0600736A RID: 29546
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaLayout_SetSizeArrayName_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array name to use for retrieving the relative size of each vertex.
		/// If this array is not found, use constant size for each vertex.
		/// </summary>
		// Token: 0x0600736B RID: 29547 RVA: 0x000A6D47 File Offset: 0x000A4F47
		public virtual void SetSizeArrayName(string name)
		{
			vtkAreaLayout.vtkAreaLayout_SetSizeArrayName_19(base.GetCppThis(), name);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A02 RID: 2562
		public new const string MRFullTypeName = "Kitware.VTK.vtkAreaLayout";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A03 RID: 2563
		public new static readonly string MRClassNameKey = "class vtkAreaLayout";
	}
}
