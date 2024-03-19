using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCirclePackFrontChainLayoutStrategy
	/// </summary>
	/// <remarks>
	///    layout a vtkTree into packed circles
	/// using the front chain algorithm.
	///
	///
	/// vtkCirclePackFrontChainLayoutStrategy assigns circles to each node of the input vtkTree
	/// using the front chain algorithm.  The algorithm packs circles by searching a "front
	/// chain" of circles around the perimeter of the circles that have already been packed for
	/// the current level in the tree hierarchy.  Searching the front chain is in general faster
	/// than searching all of the circles that have been packed at the current level.
	///
	/// WARNING:  The algorithm tends to break down and produce packings with overlapping
	/// circles when there is a large difference in the radii of the circles at a given
	/// level of the tree hierarchy.  Roughly on the order a 1000:1 ratio of circle radii.
	///
	/// Please see the following reference for more details on the algorithm.
	///
	/// Title: "Visualization of large hierarchical data by circle packing"
	/// Authors:  Weixin Wang, Hui Wang, Guozhong Dai, Hongan Wang
	/// Conference: Proceedings of the SIGCHI conference on Human Factors in computing systems
	/// Year: 2006
	///
	/// </remarks>
	// Token: 0x02000283 RID: 643
	public class vtkCirclePackFrontChainLayoutStrategy : vtkCirclePackLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007466 RID: 29798 RVA: 0x000A84CB File Offset: 0x000A66CB
		static vtkCirclePackFrontChainLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCirclePackFrontChainLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCirclePackFrontChainLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007467 RID: 29799 RVA: 0x000A84F3 File Offset: 0x000A66F3
		public vtkCirclePackFrontChainLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007468 RID: 29800
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackFrontChainLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007469 RID: 29801 RVA: 0x000A8504 File Offset: 0x000A6704
		public new static vtkCirclePackFrontChainLayoutStrategy New()
		{
			vtkCirclePackFrontChainLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCirclePackFrontChainLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600746A RID: 29802 RVA: 0x000A8558 File Offset: 0x000A6758
		public vtkCirclePackFrontChainLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600746B RID: 29803 RVA: 0x000A859C File Offset: 0x000A679C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600746C RID: 29804
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCirclePackFrontChainLayoutStrategy_GetHeight_01(HandleRef pThis);

		/// <summary>
		/// Width and Height define the size of the output window that the
		/// circle packing is placed inside.  Defaults to Width 1, Height 1
		/// </summary>
		// Token: 0x0600746D RID: 29805 RVA: 0x000A85A8 File Offset: 0x000A67A8
		public virtual int GetHeight()
		{
			return vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_GetHeight_01(base.GetCppThis());
		}

		// Token: 0x0600746E RID: 29806
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCirclePackFrontChainLayoutStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600746F RID: 29807 RVA: 0x000A85C8 File Offset: 0x000A67C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06007470 RID: 29808
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCirclePackFrontChainLayoutStrategy_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007471 RID: 29809 RVA: 0x000A85E8 File Offset: 0x000A67E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06007472 RID: 29810
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCirclePackFrontChainLayoutStrategy_GetWidth_04(HandleRef pThis);

		/// <summary>
		/// Width and Height define the size of the output window that the
		/// circle packing is placed inside.  Defaults to Width 1, Height 1
		/// </summary>
		// Token: 0x06007473 RID: 29811 RVA: 0x000A8604 File Offset: 0x000A6804
		public virtual int GetWidth()
		{
			return vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_GetWidth_04(base.GetCppThis());
		}

		// Token: 0x06007474 RID: 29812
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCirclePackFrontChainLayoutStrategy_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007475 RID: 29813 RVA: 0x000A8624 File Offset: 0x000A6824
		public override int IsA(string type)
		{
			return vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06007476 RID: 29814
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCirclePackFrontChainLayoutStrategy_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007477 RID: 29815 RVA: 0x000A8644 File Offset: 0x000A6844
		public new static int IsTypeOf(string type)
		{
			return vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_IsTypeOf_06(type);
		}

		// Token: 0x06007478 RID: 29816
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCirclePackFrontChainLayoutStrategy_Layout_07(HandleRef pThis, HandleRef inputTree, HandleRef areaArray, HandleRef sizeArray);

		/// <summary>
		/// Perform the layout of the input tree, and store the circle
		/// bounds of each vertex as a tuple in a data array.
		/// (Xcenter, Ycenter, Radius).
		/// </summary>
		// Token: 0x06007479 RID: 29817 RVA: 0x000A8660 File Offset: 0x000A6860
		public override void Layout(vtkTree inputTree, vtkDataArray areaArray, vtkDataArray sizeArray)
		{
			vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_Layout_07(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (areaArray == null) ? default(HandleRef) : areaArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis());
		}

		// Token: 0x0600747A RID: 29818
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackFrontChainLayoutStrategy_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600747B RID: 29819 RVA: 0x000A86BC File Offset: 0x000A68BC
		public new vtkCirclePackFrontChainLayoutStrategy NewInstance()
		{
			vtkCirclePackFrontChainLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCirclePackFrontChainLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600747C RID: 29820
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackFrontChainLayoutStrategy_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600747D RID: 29821 RVA: 0x000A8718 File Offset: 0x000A6918
		public new static vtkCirclePackFrontChainLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkCirclePackFrontChainLayoutStrategy vtkCirclePackFrontChainLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCirclePackFrontChainLayoutStrategy = (vtkCirclePackFrontChainLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCirclePackFrontChainLayoutStrategy.Register(null);
				}
			}
			return vtkCirclePackFrontChainLayoutStrategy;
		}

		// Token: 0x0600747E RID: 29822
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCirclePackFrontChainLayoutStrategy_SetHeight_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Width and Height define the size of the output window that the
		/// circle packing is placed inside.  Defaults to Width 1, Height 1
		/// </summary>
		// Token: 0x0600747F RID: 29823 RVA: 0x000A8797 File Offset: 0x000A6997
		public virtual void SetHeight(int _arg)
		{
			vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_SetHeight_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06007480 RID: 29824
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCirclePackFrontChainLayoutStrategy_SetWidth_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Width and Height define the size of the output window that the
		/// circle packing is placed inside.  Defaults to Width 1, Height 1
		/// </summary>
		// Token: 0x06007481 RID: 29825 RVA: 0x000A87A7 File Offset: 0x000A69A7
		public virtual void SetWidth(int _arg)
		{
			vtkCirclePackFrontChainLayoutStrategy.vtkCirclePackFrontChainLayoutStrategy_SetWidth_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A14 RID: 2580
		public new const string MRFullTypeName = "Kitware.VTK.vtkCirclePackFrontChainLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A15 RID: 2581
		public new static readonly string MRClassNameKey = "class vtkCirclePackFrontChainLayoutStrategy";
	}
}
