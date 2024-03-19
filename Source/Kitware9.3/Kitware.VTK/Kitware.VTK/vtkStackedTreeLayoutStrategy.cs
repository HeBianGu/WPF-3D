using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStackedTreeLayoutStrategy
	/// </summary>
	/// <remarks>
	///    lays out tree in stacked boxes or rings
	///
	///
	/// Performs a tree ring layout or "icicle" layout on a tree.
	/// This involves assigning a sector region to each vertex in the tree,
	/// and placing that information in a data array with four components per
	/// tuple representing (innerRadius, outerRadius, startAngle, endAngle).
	///
	/// This class may be assigned as the layout strategy to vtkAreaLayout.
	///
	/// @par Thanks:
	/// Thanks to Jason Shepherd from Sandia National Laboratories
	/// for help developing this class.
	/// </remarks>
	// Token: 0x020002A0 RID: 672
	public class vtkStackedTreeLayoutStrategy : vtkAreaLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007914 RID: 30996 RVA: 0x000AE96B File Offset: 0x000ACB6B
		static vtkStackedTreeLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStackedTreeLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStackedTreeLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007915 RID: 30997 RVA: 0x000AE993 File Offset: 0x000ACB93
		public vtkStackedTreeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007916 RID: 30998
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStackedTreeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007917 RID: 30999 RVA: 0x000AE9A4 File Offset: 0x000ACBA4
		public new static vtkStackedTreeLayoutStrategy New()
		{
			vtkStackedTreeLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStackedTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007918 RID: 31000 RVA: 0x000AE9F8 File Offset: 0x000ACBF8
		public vtkStackedTreeLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007919 RID: 31001 RVA: 0x000AEA3C File Offset: 0x000ACC3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600791A RID: 31002
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStackedTreeLayoutStrategy_FindVertex_01(HandleRef pThis, HandleRef tree, HandleRef array, IntPtr pnt);

		/// <summary>
		/// Returns the vertex id that contains pnt (or -1 if no one contains it).
		/// </summary>
		// Token: 0x0600791B RID: 31003 RVA: 0x000AEA48 File Offset: 0x000ACC48
		public override long FindVertex(vtkTree tree, vtkDataArray array, IntPtr pnt)
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_FindVertex_01(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis(), pnt);
		}

		// Token: 0x0600791C RID: 31004
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStackedTreeLayoutStrategy_GetInteriorLogSpacingValue_02(HandleRef pThis);

		/// <summary>
		/// The spacing of tree levels in the edge routing tree.
		/// Levels near zero give more space
		/// to levels near the root, while levels near one (the default)
		/// create evenly-spaced levels. Levels above one give more space
		/// to levels near the leaves.
		/// </summary>
		// Token: 0x0600791D RID: 31005 RVA: 0x000AEA94 File Offset: 0x000ACC94
		public virtual double GetInteriorLogSpacingValue()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetInteriorLogSpacingValue_02(base.GetCppThis());
		}

		// Token: 0x0600791E RID: 31006
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStackedTreeLayoutStrategy_GetInteriorRadius_03(HandleRef pThis);

		/// <summary>
		/// Define the tree ring's interior radius.
		/// </summary>
		// Token: 0x0600791F RID: 31007 RVA: 0x000AEAB4 File Offset: 0x000ACCB4
		public virtual double GetInteriorRadius()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetInteriorRadius_03(base.GetCppThis());
		}

		// Token: 0x06007920 RID: 31008
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStackedTreeLayoutStrategy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007921 RID: 31009 RVA: 0x000AEAD4 File Offset: 0x000ACCD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06007922 RID: 31010
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStackedTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007923 RID: 31011 RVA: 0x000AEAF4 File Offset: 0x000ACCF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06007924 RID: 31012
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStackedTreeLayoutStrategy_GetReverse_06(HandleRef pThis);

		/// <summary>
		/// Define whether to reverse the order of the tree stacks from
		/// low to high.
		/// </summary>
		// Token: 0x06007925 RID: 31013 RVA: 0x000AEB10 File Offset: 0x000ACD10
		public virtual bool GetReverse()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetReverse_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06007926 RID: 31014
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStackedTreeLayoutStrategy_GetRingThickness_07(HandleRef pThis);

		/// <summary>
		/// Define the thickness of each of the tree rings.
		/// </summary>
		// Token: 0x06007927 RID: 31015 RVA: 0x000AEB38 File Offset: 0x000ACD38
		public virtual double GetRingThickness()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetRingThickness_07(base.GetCppThis());
		}

		// Token: 0x06007928 RID: 31016
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStackedTreeLayoutStrategy_GetRootEndAngle_08(HandleRef pThis);

		/// <summary>
		/// Define the end angle for the root node.
		/// NOTE: It is assumed that the root end angle is greater than the
		/// root start angle and subtends no more than 360 degrees.
		/// </summary>
		// Token: 0x06007929 RID: 31017 RVA: 0x000AEB58 File Offset: 0x000ACD58
		public virtual double GetRootEndAngle()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetRootEndAngle_08(base.GetCppThis());
		}

		// Token: 0x0600792A RID: 31018
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStackedTreeLayoutStrategy_GetRootStartAngle_09(HandleRef pThis);

		/// <summary>
		/// Define the start angle for the root node.
		/// NOTE: It is assumed that the root end angle is greater than the
		/// root start angle and subtends no more than 360 degrees.
		/// </summary>
		// Token: 0x0600792B RID: 31019 RVA: 0x000AEB78 File Offset: 0x000ACD78
		public virtual double GetRootStartAngle()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetRootStartAngle_09(base.GetCppThis());
		}

		// Token: 0x0600792C RID: 31020
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStackedTreeLayoutStrategy_GetUseRectangularCoordinates_10(HandleRef pThis);

		/// <summary>
		/// Define whether or not rectangular coordinates are being used
		/// (as opposed to polar coordinates).
		/// </summary>
		// Token: 0x0600792D RID: 31021 RVA: 0x000AEB98 File Offset: 0x000ACD98
		public virtual bool GetUseRectangularCoordinates()
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_GetUseRectangularCoordinates_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0600792E RID: 31022
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStackedTreeLayoutStrategy_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600792F RID: 31023 RVA: 0x000AEBC0 File Offset: 0x000ACDC0
		public override int IsA(string type)
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06007930 RID: 31024
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStackedTreeLayoutStrategy_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007931 RID: 31025 RVA: 0x000AEBE0 File Offset: 0x000ACDE0
		public new static int IsTypeOf(string type)
		{
			return vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_IsTypeOf_12(type);
		}

		// Token: 0x06007932 RID: 31026
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_Layout_13(HandleRef pThis, HandleRef inputTree, HandleRef sectorArray, HandleRef sizeArray);

		/// <summary>
		/// Perform the layout of the input tree, and store the sector
		/// bounds of each vertex as a tuple
		/// (innerRadius, outerRadius, startAngle, endAngle)
		/// in a data array.
		/// </summary>
		// Token: 0x06007933 RID: 31027 RVA: 0x000AEBFC File Offset: 0x000ACDFC
		public override void Layout(vtkTree inputTree, vtkDataArray sectorArray, vtkDataArray sizeArray)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_Layout_13(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (sectorArray == null) ? default(HandleRef) : sectorArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis());
		}

		// Token: 0x06007934 RID: 31028
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_LayoutEdgePoints_14(HandleRef pThis, HandleRef inputTree, HandleRef sectorArray, HandleRef sizeArray, HandleRef edgeRoutingTree);

		/// <summary>
		/// Fill edgeRoutingTree with points suitable for routing edges of
		/// an overlaid graph.
		/// </summary>
		// Token: 0x06007935 RID: 31029 RVA: 0x000AEC58 File Offset: 0x000ACE58
		public override void LayoutEdgePoints(vtkTree inputTree, vtkDataArray sectorArray, vtkDataArray sizeArray, vtkTree edgeRoutingTree)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_LayoutEdgePoints_14(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (sectorArray == null) ? default(HandleRef) : sectorArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis(), (edgeRoutingTree == null) ? default(HandleRef) : edgeRoutingTree.GetCppThis());
		}

		// Token: 0x06007936 RID: 31030
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStackedTreeLayoutStrategy_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007937 RID: 31031 RVA: 0x000AECC8 File Offset: 0x000ACEC8
		public new vtkStackedTreeLayoutStrategy NewInstance()
		{
			vtkStackedTreeLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStackedTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007938 RID: 31032
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_ReverseOff_17(HandleRef pThis);

		/// <summary>
		/// Define whether to reverse the order of the tree stacks from
		/// low to high.
		/// </summary>
		// Token: 0x06007939 RID: 31033 RVA: 0x000AED22 File Offset: 0x000ACF22
		public virtual void ReverseOff()
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_ReverseOff_17(base.GetCppThis());
		}

		// Token: 0x0600793A RID: 31034
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_ReverseOn_18(HandleRef pThis);

		/// <summary>
		/// Define whether to reverse the order of the tree stacks from
		/// low to high.
		/// </summary>
		// Token: 0x0600793B RID: 31035 RVA: 0x000AED31 File Offset: 0x000ACF31
		public virtual void ReverseOn()
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_ReverseOn_18(base.GetCppThis());
		}

		// Token: 0x0600793C RID: 31036
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStackedTreeLayoutStrategy_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600793D RID: 31037 RVA: 0x000AED40 File Offset: 0x000ACF40
		public new static vtkStackedTreeLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkStackedTreeLayoutStrategy vtkStackedTreeLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStackedTreeLayoutStrategy = (vtkStackedTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStackedTreeLayoutStrategy.Register(null);
				}
			}
			return vtkStackedTreeLayoutStrategy;
		}

		// Token: 0x0600793E RID: 31038
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_SetInteriorLogSpacingValue_20(HandleRef pThis, double _arg);

		/// <summary>
		/// The spacing of tree levels in the edge routing tree.
		/// Levels near zero give more space
		/// to levels near the root, while levels near one (the default)
		/// create evenly-spaced levels. Levels above one give more space
		/// to levels near the leaves.
		/// </summary>
		// Token: 0x0600793F RID: 31039 RVA: 0x000AEDBF File Offset: 0x000ACFBF
		public virtual void SetInteriorLogSpacingValue(double _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetInteriorLogSpacingValue_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06007940 RID: 31040
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_SetInteriorRadius_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Define the tree ring's interior radius.
		/// </summary>
		// Token: 0x06007941 RID: 31041 RVA: 0x000AEDCF File Offset: 0x000ACFCF
		public virtual void SetInteriorRadius(double _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetInteriorRadius_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06007942 RID: 31042
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_SetReverse_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Define whether to reverse the order of the tree stacks from
		/// low to high.
		/// </summary>
		// Token: 0x06007943 RID: 31043 RVA: 0x000AEDDF File Offset: 0x000ACFDF
		public virtual void SetReverse(bool _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetReverse_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06007944 RID: 31044
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_SetRingThickness_23(HandleRef pThis, double _arg);

		/// <summary>
		/// Define the thickness of each of the tree rings.
		/// </summary>
		// Token: 0x06007945 RID: 31045 RVA: 0x000AEDF7 File Offset: 0x000ACFF7
		public virtual void SetRingThickness(double _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetRingThickness_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06007946 RID: 31046
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_SetRootEndAngle_24(HandleRef pThis, double _arg);

		/// <summary>
		/// Define the end angle for the root node.
		/// NOTE: It is assumed that the root end angle is greater than the
		/// root start angle and subtends no more than 360 degrees.
		/// </summary>
		// Token: 0x06007947 RID: 31047 RVA: 0x000AEE07 File Offset: 0x000AD007
		public virtual void SetRootEndAngle(double _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetRootEndAngle_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06007948 RID: 31048
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_SetRootStartAngle_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Define the start angle for the root node.
		/// NOTE: It is assumed that the root end angle is greater than the
		/// root start angle and subtends no more than 360 degrees.
		/// </summary>
		// Token: 0x06007949 RID: 31049 RVA: 0x000AEE17 File Offset: 0x000AD017
		public virtual void SetRootStartAngle(double _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetRootStartAngle_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600794A RID: 31050
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_SetUseRectangularCoordinates_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Define whether or not rectangular coordinates are being used
		/// (as opposed to polar coordinates).
		/// </summary>
		// Token: 0x0600794B RID: 31051 RVA: 0x000AEE27 File Offset: 0x000AD027
		public virtual void SetUseRectangularCoordinates(bool _arg)
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_SetUseRectangularCoordinates_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600794C RID: 31052
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_UseRectangularCoordinatesOff_27(HandleRef pThis);

		/// <summary>
		/// Define whether or not rectangular coordinates are being used
		/// (as opposed to polar coordinates).
		/// </summary>
		// Token: 0x0600794D RID: 31053 RVA: 0x000AEE3F File Offset: 0x000AD03F
		public virtual void UseRectangularCoordinatesOff()
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_UseRectangularCoordinatesOff_27(base.GetCppThis());
		}

		// Token: 0x0600794E RID: 31054
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStackedTreeLayoutStrategy_UseRectangularCoordinatesOn_28(HandleRef pThis);

		/// <summary>
		/// Define whether or not rectangular coordinates are being used
		/// (as opposed to polar coordinates).
		/// </summary>
		// Token: 0x0600794F RID: 31055 RVA: 0x000AEE4E File Offset: 0x000AD04E
		public virtual void UseRectangularCoordinatesOn()
		{
			vtkStackedTreeLayoutStrategy.vtkStackedTreeLayoutStrategy_UseRectangularCoordinatesOn_28(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A50 RID: 2640
		public new const string MRFullTypeName = "Kitware.VTK.vtkStackedTreeLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A51 RID: 2641
		public new static readonly string MRClassNameKey = "class vtkStackedTreeLayoutStrategy";
	}
}
