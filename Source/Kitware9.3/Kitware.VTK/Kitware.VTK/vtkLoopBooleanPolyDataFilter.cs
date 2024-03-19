using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLoopBooleanPolyDataFilter
	///
	///
	/// Computes the boundary of the union, intersection, or difference
	/// volume computed from the volumes defined by two input surfaces. The
	/// two surfaces do not need to be manifold, but if they are not,
	/// unexpected results may be obtained. The resulting surface is
	/// available in the first output of the filter. The second output
	/// contains a set of polylines that represent the intersection between
	/// the two input surfaces.
	/// The filter uses vtkIntersectionPolyDataFilter. Must have information
	/// about the cells on mesh that the intersection lines touch. Filter assumes
	/// this information is given.
	/// The output result will have data about the Original Surface,
	/// BoundaryPoints, Boundary Cells,
	/// Free Edges, and Bad Triangles
	/// </summary>
	// Token: 0x020008B5 RID: 2229
	public class vtkLoopBooleanPolyDataFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060171C8 RID: 94664 RVA: 0x002073BF File Offset: 0x002055BF
		static vtkLoopBooleanPolyDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLoopBooleanPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLoopBooleanPolyDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060171C9 RID: 94665 RVA: 0x002073E7 File Offset: 0x002055E7
		public vtkLoopBooleanPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060171CA RID: 94666
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLoopBooleanPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060171CB RID: 94667 RVA: 0x002073F8 File Offset: 0x002055F8
		public new static vtkLoopBooleanPolyDataFilter New()
		{
			vtkLoopBooleanPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLoopBooleanPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060171CC RID: 94668 RVA: 0x0020744C File Offset: 0x0020564C
		public vtkLoopBooleanPolyDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060171CD RID: 94669 RVA: 0x00207490 File Offset: 0x00205690
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060171CE RID: 94670
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLoopBooleanPolyDataFilter_GetNoIntersectionOutput_01(HandleRef pThis);

		/// <summary>
		/// ONLY USED IF NO INTERSECTION BETWEEN SURFACES
		/// Variable to determine what is output if no intersection occurs.
		/// 0 = neither (default), 1 = first, 2 = second, 3 = both
		/// </summary>
		// Token: 0x060171CF RID: 94671 RVA: 0x0020749C File Offset: 0x0020569C
		public virtual int GetNoIntersectionOutput()
		{
			return vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_GetNoIntersectionOutput_01(base.GetCppThis());
		}

		// Token: 0x060171D0 RID: 94672
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLoopBooleanPolyDataFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060171D1 RID: 94673 RVA: 0x002074BC File Offset: 0x002056BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060171D2 RID: 94674
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLoopBooleanPolyDataFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060171D3 RID: 94675 RVA: 0x002074DC File Offset: 0x002056DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060171D4 RID: 94676
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLoopBooleanPolyDataFilter_GetNumberOfIntersectionLines_04(HandleRef pThis);

		/// <summary>
		/// Integer describing the number of intersection points and lines
		/// </summary>
		// Token: 0x060171D5 RID: 94677 RVA: 0x002074F8 File Offset: 0x002056F8
		public virtual int GetNumberOfIntersectionLines()
		{
			return vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_GetNumberOfIntersectionLines_04(base.GetCppThis());
		}

		// Token: 0x060171D6 RID: 94678
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLoopBooleanPolyDataFilter_GetNumberOfIntersectionPoints_05(HandleRef pThis);

		/// <summary>
		/// Integer describing the number of intersection points and lines
		/// </summary>
		// Token: 0x060171D7 RID: 94679 RVA: 0x00207518 File Offset: 0x00205718
		public virtual int GetNumberOfIntersectionPoints()
		{
			return vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_GetNumberOfIntersectionPoints_05(base.GetCppThis());
		}

		// Token: 0x060171D8 RID: 94680
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLoopBooleanPolyDataFilter_GetOperation_06(HandleRef pThis);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060171D9 RID: 94681 RVA: 0x00207538 File Offset: 0x00205738
		public virtual int GetOperation()
		{
			return vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_GetOperation_06(base.GetCppThis());
		}

		// Token: 0x060171DA RID: 94682
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLoopBooleanPolyDataFilter_GetOperationMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060171DB RID: 94683 RVA: 0x00207558 File Offset: 0x00205758
		public virtual int GetOperationMaxValue()
		{
			return vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_GetOperationMaxValue_07(base.GetCppThis());
		}

		// Token: 0x060171DC RID: 94684
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLoopBooleanPolyDataFilter_GetOperationMinValue_08(HandleRef pThis);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060171DD RID: 94685 RVA: 0x00207578 File Offset: 0x00205778
		public virtual int GetOperationMinValue()
		{
			return vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_GetOperationMinValue_08(base.GetCppThis());
		}

		// Token: 0x060171DE RID: 94686
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLoopBooleanPolyDataFilter_GetStatus_09(HandleRef pThis);

		/// <summary>
		/// Check the status of the filter after update. If the status is zero,
		/// there was an error in the operation. If status is one, everything
		/// went smoothly
		/// </summary>
		// Token: 0x060171DF RID: 94687 RVA: 0x00207598 File Offset: 0x00205798
		public virtual int GetStatus()
		{
			return vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_GetStatus_09(base.GetCppThis());
		}

		// Token: 0x060171E0 RID: 94688
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLoopBooleanPolyDataFilter_GetTolerance_10(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for geometric tests
		/// </summary>
		// Token: 0x060171E1 RID: 94689 RVA: 0x002075B8 File Offset: 0x002057B8
		public virtual double GetTolerance()
		{
			return vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_GetTolerance_10(base.GetCppThis());
		}

		// Token: 0x060171E2 RID: 94690
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLoopBooleanPolyDataFilter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060171E3 RID: 94691 RVA: 0x002075D8 File Offset: 0x002057D8
		public override int IsA(string type)
		{
			return vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x060171E4 RID: 94692
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLoopBooleanPolyDataFilter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060171E5 RID: 94693 RVA: 0x002075F8 File Offset: 0x002057F8
		public new static int IsTypeOf(string type)
		{
			return vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_IsTypeOf_12(type);
		}

		// Token: 0x060171E6 RID: 94694
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLoopBooleanPolyDataFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060171E7 RID: 94695 RVA: 0x00207614 File Offset: 0x00205814
		public new vtkLoopBooleanPolyDataFilter NewInstance()
		{
			vtkLoopBooleanPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLoopBooleanPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060171E8 RID: 94696
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLoopBooleanPolyDataFilter_NoIntersectionOutputOff_15(HandleRef pThis);

		/// <summary>
		/// ONLY USED IF NO INTERSECTION BETWEEN SURFACES
		/// Variable to determine what is output if no intersection occurs.
		/// 0 = neither (default), 1 = first, 2 = second, 3 = both
		/// </summary>
		// Token: 0x060171E9 RID: 94697 RVA: 0x0020766E File Offset: 0x0020586E
		public virtual void NoIntersectionOutputOff()
		{
			vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_NoIntersectionOutputOff_15(base.GetCppThis());
		}

		// Token: 0x060171EA RID: 94698
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLoopBooleanPolyDataFilter_NoIntersectionOutputOn_16(HandleRef pThis);

		/// <summary>
		/// ONLY USED IF NO INTERSECTION BETWEEN SURFACES
		/// Variable to determine what is output if no intersection occurs.
		/// 0 = neither (default), 1 = first, 2 = second, 3 = both
		/// </summary>
		// Token: 0x060171EB RID: 94699 RVA: 0x0020767D File Offset: 0x0020587D
		public virtual void NoIntersectionOutputOn()
		{
			vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_NoIntersectionOutputOn_16(base.GetCppThis());
		}

		// Token: 0x060171EC RID: 94700
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLoopBooleanPolyDataFilter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060171ED RID: 94701 RVA: 0x0020768C File Offset: 0x0020588C
		public new static vtkLoopBooleanPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkLoopBooleanPolyDataFilter vtkLoopBooleanPolyDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLoopBooleanPolyDataFilter = (vtkLoopBooleanPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLoopBooleanPolyDataFilter.Register(null);
				}
			}
			return vtkLoopBooleanPolyDataFilter;
		}

		// Token: 0x060171EE RID: 94702
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLoopBooleanPolyDataFilter_SetNoIntersectionOutput_18(HandleRef pThis, int _arg);

		/// <summary>
		/// ONLY USED IF NO INTERSECTION BETWEEN SURFACES
		/// Variable to determine what is output if no intersection occurs.
		/// 0 = neither (default), 1 = first, 2 = second, 3 = both
		/// </summary>
		// Token: 0x060171EF RID: 94703 RVA: 0x0020770B File Offset: 0x0020590B
		public virtual void SetNoIntersectionOutput(int _arg)
		{
			vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_SetNoIntersectionOutput_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060171F0 RID: 94704
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLoopBooleanPolyDataFilter_SetOperation_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060171F1 RID: 94705 RVA: 0x0020771B File Offset: 0x0020591B
		public virtual void SetOperation(int _arg)
		{
			vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_SetOperation_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060171F2 RID: 94706
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLoopBooleanPolyDataFilter_SetOperationToDifference_20(HandleRef pThis);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060171F3 RID: 94707 RVA: 0x0020772B File Offset: 0x0020592B
		public void SetOperationToDifference()
		{
			vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_SetOperationToDifference_20(base.GetCppThis());
		}

		// Token: 0x060171F4 RID: 94708
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLoopBooleanPolyDataFilter_SetOperationToIntersection_21(HandleRef pThis);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060171F5 RID: 94709 RVA: 0x0020773A File Offset: 0x0020593A
		public void SetOperationToIntersection()
		{
			vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_SetOperationToIntersection_21(base.GetCppThis());
		}

		// Token: 0x060171F6 RID: 94710
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLoopBooleanPolyDataFilter_SetOperationToUnion_22(HandleRef pThis);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060171F7 RID: 94711 RVA: 0x00207749 File Offset: 0x00205949
		public void SetOperationToUnion()
		{
			vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_SetOperationToUnion_22(base.GetCppThis());
		}

		// Token: 0x060171F8 RID: 94712
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLoopBooleanPolyDataFilter_SetTolerance_23(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the tolerance for geometric tests
		/// </summary>
		// Token: 0x060171F9 RID: 94713 RVA: 0x00207758 File Offset: 0x00205958
		public virtual void SetTolerance(double _arg)
		{
			vtkLoopBooleanPolyDataFilter.vtkLoopBooleanPolyDataFilter_SetTolerance_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019D3 RID: 6611
		public new const string MRFullTypeName = "Kitware.VTK.vtkLoopBooleanPolyDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019D4 RID: 6612
		public new static readonly string MRClassNameKey = "class vtkLoopBooleanPolyDataFilter";

		/// <summary>
		/// ONLY USED IF NO INTERSECTION BETWEEN SURFACES
		/// Variable to determine what is output if no intersection occurs.
		/// 0 = neither (default), 1 = first, 2 = second, 3 = both
		/// </summary>
		// Token: 0x020008B6 RID: 2230
		public enum NoIntersectionOutputType
		{
			/// <summary>enum member</summary>
			// Token: 0x040019D6 RID: 6614
			VTK_BOTH = 3,
			/// <summary>enum member</summary>
			// Token: 0x040019D7 RID: 6615
			VTK_FIRST = 1,
			/// <summary>enum member</summary>
			// Token: 0x040019D8 RID: 6616
			VTK_NEITHER = 0,
			/// <summary>enum member</summary>
			// Token: 0x040019D9 RID: 6617
			VTK_SECOND = 2
		}

		/// <summary>
		/// ONLY USED IF NO INTERSECTION BETWEEN SURFACES
		/// Variable to determine what is output if no intersection occurs.
		/// 0 = neither (default), 1 = first, 2 = second, 3 = both
		/// </summary>
		// Token: 0x020008B7 RID: 2231
		public enum OperationType
		{
			/// <summary>enum member</summary>
			// Token: 0x040019DB RID: 6619
			VTK_DIFFERENCE = 2,
			/// <summary>enum member</summary>
			// Token: 0x040019DC RID: 6620
			VTK_INTERSECTION = 1,
			/// <summary>enum member</summary>
			// Token: 0x040019DD RID: 6621
			VTK_UNION = 0
		}
	}
}
