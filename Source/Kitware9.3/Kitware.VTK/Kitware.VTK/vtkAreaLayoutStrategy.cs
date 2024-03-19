using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAreaLayoutStrategy
	/// </summary>
	/// <remarks>
	///    abstract superclass for all area layout strategies
	///
	///
	/// All subclasses of this class perform a area layout on a tree.
	/// This involves assigning a region to each vertex in the tree,
	/// and placing that information in a data array with four components per
	/// tuple representing (innerRadius, outerRadius, startAngle, endAngle).
	///
	/// Instances of subclasses of this class may be assigned as the layout
	/// strategy to vtkAreaLayout
	///
	/// @par Thanks:
	/// Thanks to Jason Shepherd from Sandia National Laboratories
	/// for help developing this class.
	/// </remarks>
	// Token: 0x0200027B RID: 635
	public abstract class vtkAreaLayoutStrategy : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600736C RID: 29548 RVA: 0x000A6D57 File Offset: 0x000A4F57
		static vtkAreaLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAreaLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAreaLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600736D RID: 29549 RVA: 0x000A6D7F File Offset: 0x000A4F7F
		public vtkAreaLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600736E RID: 29550 RVA: 0x000A6D8D File Offset: 0x000A4F8D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600736F RID: 29551
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAreaLayoutStrategy_FindVertex_01(HandleRef pThis, HandleRef tree, HandleRef array, IntPtr pnt);

		/// <summary>
		/// Returns the vertex id that contains pnt (or -1 if no one contains it)
		/// </summary>
		// Token: 0x06007370 RID: 29552 RVA: 0x000A6D98 File Offset: 0x000A4F98
		public virtual long FindVertex(vtkTree tree, vtkDataArray array, IntPtr pnt)
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_FindVertex_01(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis(), pnt);
		}

		// Token: 0x06007371 RID: 29553
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAreaLayoutStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007372 RID: 29554 RVA: 0x000A6DE4 File Offset: 0x000A4FE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06007373 RID: 29555
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAreaLayoutStrategy_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007374 RID: 29556 RVA: 0x000A6E04 File Offset: 0x000A5004
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06007375 RID: 29557
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAreaLayoutStrategy_GetShrinkPercentage_04(HandleRef pThis);

		/// <summary>
		/// Returns the vertex id that contains pnt (or -1 if no one contains it)
		/// </summary>
		// Token: 0x06007376 RID: 29558 RVA: 0x000A6E20 File Offset: 0x000A5020
		public virtual double GetShrinkPercentage()
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_GetShrinkPercentage_04(base.GetCppThis());
		}

		// Token: 0x06007377 RID: 29559
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAreaLayoutStrategy_GetShrinkPercentageMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Returns the vertex id that contains pnt (or -1 if no one contains it)
		/// </summary>
		// Token: 0x06007378 RID: 29560 RVA: 0x000A6E40 File Offset: 0x000A5040
		public virtual double GetShrinkPercentageMaxValue()
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_GetShrinkPercentageMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06007379 RID: 29561
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAreaLayoutStrategy_GetShrinkPercentageMinValue_06(HandleRef pThis);

		/// <summary>
		/// Returns the vertex id that contains pnt (or -1 if no one contains it)
		/// </summary>
		// Token: 0x0600737A RID: 29562 RVA: 0x000A6E60 File Offset: 0x000A5060
		public virtual double GetShrinkPercentageMinValue()
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_GetShrinkPercentageMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600737B RID: 29563
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAreaLayoutStrategy_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600737C RID: 29564 RVA: 0x000A6E80 File Offset: 0x000A5080
		public override int IsA(string type)
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600737D RID: 29565
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAreaLayoutStrategy_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600737E RID: 29566 RVA: 0x000A6EA0 File Offset: 0x000A50A0
		public new static int IsTypeOf(string type)
		{
			return vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_IsTypeOf_08(type);
		}

		// Token: 0x0600737F RID: 29567
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaLayoutStrategy_Layout_09(HandleRef pThis, HandleRef inputTree, HandleRef areaArray, HandleRef sizeArray);

		/// <summary>
		/// Perform the layout of the input tree, and store the sector
		/// bounds of each vertex as a tuple in a data array.
		/// For radial layout, this is
		/// (innerRadius, outerRadius, startAngle, endAngle).
		/// For rectangular layout, this is
		/// (xmin, xmax, ymin, ymax).
		///
		/// The sizeArray may be nullptr, or may contain the desired
		/// size of each vertex in the tree.
		/// </summary>
		// Token: 0x06007380 RID: 29568 RVA: 0x000A6EBC File Offset: 0x000A50BC
		public virtual void Layout(vtkTree inputTree, vtkDataArray areaArray, vtkDataArray sizeArray)
		{
			vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_Layout_09(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (areaArray == null) ? default(HandleRef) : areaArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis());
		}

		// Token: 0x06007381 RID: 29569
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaLayoutStrategy_LayoutEdgePoints_10(HandleRef pThis, HandleRef inputTree, HandleRef areaArray, HandleRef sizeArray, HandleRef edgeRoutingTree);

		/// <summary>
		/// Perform the layout of the input tree, and store the sector
		/// bounds of each vertex as a tuple in a data array.
		/// For radial layout, this is
		/// (innerRadius, outerRadius, startAngle, endAngle).
		/// For rectangular layout, this is
		/// (xmin, xmax, ymin, ymax).
		///
		/// The sizeArray may be nullptr, or may contain the desired
		/// size of each vertex in the tree.
		/// </summary>
		// Token: 0x06007382 RID: 29570 RVA: 0x000A6F18 File Offset: 0x000A5118
		public virtual void LayoutEdgePoints(vtkTree inputTree, vtkDataArray areaArray, vtkDataArray sizeArray, vtkTree edgeRoutingTree)
		{
			vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_LayoutEdgePoints_10(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (areaArray == null) ? default(HandleRef) : areaArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis(), (edgeRoutingTree == null) ? default(HandleRef) : edgeRoutingTree.GetCppThis());
		}

		// Token: 0x06007383 RID: 29571
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaLayoutStrategy_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007384 RID: 29572 RVA: 0x000A6F88 File Offset: 0x000A5188
		public new vtkAreaLayoutStrategy NewInstance()
		{
			vtkAreaLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAreaLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007385 RID: 29573
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaLayoutStrategy_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007386 RID: 29574 RVA: 0x000A6FE4 File Offset: 0x000A51E4
		public new static vtkAreaLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkAreaLayoutStrategy vtkAreaLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007387 RID: 29575
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaLayoutStrategy_SetShrinkPercentage_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Returns the vertex id that contains pnt (or -1 if no one contains it)
		/// </summary>
		// Token: 0x06007388 RID: 29576 RVA: 0x000A7063 File Offset: 0x000A5263
		public virtual void SetShrinkPercentage(double _arg)
		{
			vtkAreaLayoutStrategy.vtkAreaLayoutStrategy_SetShrinkPercentage_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A04 RID: 2564
		public new const string MRFullTypeName = "Kitware.VTK.vtkAreaLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A05 RID: 2565
		public new static readonly string MRClassNameKey = "class vtkAreaLayoutStrategy";
	}
}
