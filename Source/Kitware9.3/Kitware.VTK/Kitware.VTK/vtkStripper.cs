using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStripper
	/// </summary>
	/// <remarks>
	///    create triangle strips and/or poly-lines
	///
	///
	/// vtkStripper is a filter that generates triangle strips and/or poly-lines
	/// from input polygons, triangle strips, and lines. Input polygons are
	/// assembled into triangle strips only if they are triangles; other types of
	/// polygons are passed through to the output and not stripped. (Use
	/// vtkTriangleFilter to triangulate non-triangular polygons prior to running
	/// this filter if you need to strip all the data.) The filter will pass
	/// through (to the output) vertices if they are present in the input
	/// polydata. Also note that if triangle strips or polylines are defined in
	/// the input they are passed through and not joined nor extended. (If you wish
	/// to strip these use vtkTriangleFilter to fragment the input into triangles
	/// and lines prior to running vtkStripper.)
	///
	/// The ivar MaximumLength can be used to control the maximum
	/// allowable triangle strip and poly-line length.
	///
	/// By default, this filter discards any cell data associated with the input.
	/// Thus is because the cell structure changes and and the old cell data
	/// is no longer valid. When PassCellDataAsFieldData flag is set,
	/// the cell data is passed as FieldData to the output using the following rule:
	/// 1) for every cell in the output that is not a triangle strip,
	///    the cell data is inserted once per cell in the output field data.
	/// 2) for every triangle strip cell in the output:
	///    ii) 1 tuple is inserted for every point(j|j&gt;=2) in the strip.
	///    This is the cell data for the cell formed by (j-2, j-1, j) in
	///    the input.
	/// The field data order is same as cell data i.e. (verts,line,polys,tsrips).
	///
	/// If there is a ghost cell array in the input, the ghost array is discarded.
	/// Any cell tagged as ghost is skipped when stripping. Ghost points are kept.
	///
	/// @warning
	/// If triangle strips or poly-lines exist in the input data they will
	/// be passed through to the output data. This filter will only construct
	/// triangle strips if triangle polygons are available; and will only
	/// construct poly-lines if lines are available.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTriangleFilter
	/// </seealso>
	// Token: 0x020009A7 RID: 2471
	public class vtkStripper : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019CC7 RID: 105671 RVA: 0x0023D3DF File Offset: 0x0023B5DF
		static vtkStripper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStripper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStripper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019CC8 RID: 105672 RVA: 0x0023D407 File Offset: 0x0023B607
		public vtkStripper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019CC9 RID: 105673
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStripper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with MaximumLength set to 1000.
		/// </summary>
		// Token: 0x06019CCA RID: 105674 RVA: 0x0023D418 File Offset: 0x0023B618
		public new static vtkStripper New()
		{
			vtkStripper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStripper.vtkStripper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStripper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with MaximumLength set to 1000.
		/// </summary>
		// Token: 0x06019CCB RID: 105675 RVA: 0x0023D46C File Offset: 0x0023B66C
		public vtkStripper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStripper.vtkStripper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019CCC RID: 105676 RVA: 0x0023D4B0 File Offset: 0x0023B6B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019CCD RID: 105677
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStripper_GetJoinContiguousSegments_01(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal segments will be joined if they are
		/// contiguous. This is useful after slicing a surface. The default
		/// is off.
		/// </summary>
		// Token: 0x06019CCE RID: 105678 RVA: 0x0023D4BC File Offset: 0x0023B6BC
		public virtual int GetJoinContiguousSegments()
		{
			return vtkStripper.vtkStripper_GetJoinContiguousSegments_01(base.GetCppThis());
		}

		// Token: 0x06019CCF RID: 105679
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStripper_GetMaximumLength_02(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of triangles in a triangle strip,
		/// and/or the maximum number of lines in a poly-line.
		/// </summary>
		// Token: 0x06019CD0 RID: 105680 RVA: 0x0023D4DC File Offset: 0x0023B6DC
		public virtual int GetMaximumLength()
		{
			return vtkStripper.vtkStripper_GetMaximumLength_02(base.GetCppThis());
		}

		// Token: 0x06019CD1 RID: 105681
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStripper_GetMaximumLengthMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of triangles in a triangle strip,
		/// and/or the maximum number of lines in a poly-line.
		/// </summary>
		// Token: 0x06019CD2 RID: 105682 RVA: 0x0023D4FC File Offset: 0x0023B6FC
		public virtual int GetMaximumLengthMaxValue()
		{
			return vtkStripper.vtkStripper_GetMaximumLengthMaxValue_03(base.GetCppThis());
		}

		// Token: 0x06019CD3 RID: 105683
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStripper_GetMaximumLengthMinValue_04(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of triangles in a triangle strip,
		/// and/or the maximum number of lines in a poly-line.
		/// </summary>
		// Token: 0x06019CD4 RID: 105684 RVA: 0x0023D51C File Offset: 0x0023B71C
		public virtual int GetMaximumLengthMinValue()
		{
			return vtkStripper.vtkStripper_GetMaximumLengthMinValue_04(base.GetCppThis());
		}

		// Token: 0x06019CD5 RID: 105685
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStripper_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019CD6 RID: 105686 RVA: 0x0023D53C File Offset: 0x0023B73C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStripper.vtkStripper_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06019CD7 RID: 105687
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStripper_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019CD8 RID: 105688 RVA: 0x0023D55C File Offset: 0x0023B75C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStripper.vtkStripper_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06019CD9 RID: 105689
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStripper_GetPassCellDataAsFieldData_07(HandleRef pThis);

		/// <summary>
		/// Enable/Disable passing of the CellData in the input to
		/// the output as FieldData. Note the field data is transformed.
		/// </summary>
		// Token: 0x06019CDA RID: 105690 RVA: 0x0023D578 File Offset: 0x0023B778
		public virtual int GetPassCellDataAsFieldData()
		{
			return vtkStripper.vtkStripper_GetPassCellDataAsFieldData_07(base.GetCppThis());
		}

		// Token: 0x06019CDB RID: 105691
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStripper_GetPassThroughCellIds_08(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06019CDC RID: 105692 RVA: 0x0023D598 File Offset: 0x0023B798
		public virtual int GetPassThroughCellIds()
		{
			return vtkStripper.vtkStripper_GetPassThroughCellIds_08(base.GetCppThis());
		}

		// Token: 0x06019CDD RID: 105693
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStripper_GetPassThroughPointIds_09(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a pointdata array that
		/// holds the point index of the original vertex that produced each output
		/// vertex. This is useful for picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06019CDE RID: 105694 RVA: 0x0023D5B8 File Offset: 0x0023B7B8
		public virtual int GetPassThroughPointIds()
		{
			return vtkStripper.vtkStripper_GetPassThroughPointIds_09(base.GetCppThis());
		}

		// Token: 0x06019CDF RID: 105695
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStripper_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019CE0 RID: 105696 RVA: 0x0023D5D8 File Offset: 0x0023B7D8
		public override int IsA(string type)
		{
			return vtkStripper.vtkStripper_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06019CE1 RID: 105697
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStripper_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019CE2 RID: 105698 RVA: 0x0023D5F8 File Offset: 0x0023B7F8
		public new static int IsTypeOf(string type)
		{
			return vtkStripper.vtkStripper_IsTypeOf_11(type);
		}

		// Token: 0x06019CE3 RID: 105699
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_JoinContiguousSegmentsOff_12(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal segments will be joined if they are
		/// contiguous. This is useful after slicing a surface. The default
		/// is off.
		/// </summary>
		// Token: 0x06019CE4 RID: 105700 RVA: 0x0023D612 File Offset: 0x0023B812
		public virtual void JoinContiguousSegmentsOff()
		{
			vtkStripper.vtkStripper_JoinContiguousSegmentsOff_12(base.GetCppThis());
		}

		// Token: 0x06019CE5 RID: 105701
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_JoinContiguousSegmentsOn_13(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal segments will be joined if they are
		/// contiguous. This is useful after slicing a surface. The default
		/// is off.
		/// </summary>
		// Token: 0x06019CE6 RID: 105702 RVA: 0x0023D621 File Offset: 0x0023B821
		public virtual void JoinContiguousSegmentsOn()
		{
			vtkStripper.vtkStripper_JoinContiguousSegmentsOn_13(base.GetCppThis());
		}

		// Token: 0x06019CE7 RID: 105703
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStripper_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019CE8 RID: 105704 RVA: 0x0023D630 File Offset: 0x0023B830
		public new vtkStripper NewInstance()
		{
			vtkStripper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStripper.vtkStripper_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStripper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019CE9 RID: 105705
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_PassCellDataAsFieldDataOff_16(HandleRef pThis);

		/// <summary>
		/// Enable/Disable passing of the CellData in the input to
		/// the output as FieldData. Note the field data is transformed.
		/// </summary>
		// Token: 0x06019CEA RID: 105706 RVA: 0x0023D68A File Offset: 0x0023B88A
		public virtual void PassCellDataAsFieldDataOff()
		{
			vtkStripper.vtkStripper_PassCellDataAsFieldDataOff_16(base.GetCppThis());
		}

		// Token: 0x06019CEB RID: 105707
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_PassCellDataAsFieldDataOn_17(HandleRef pThis);

		/// <summary>
		/// Enable/Disable passing of the CellData in the input to
		/// the output as FieldData. Note the field data is transformed.
		/// </summary>
		// Token: 0x06019CEC RID: 105708 RVA: 0x0023D699 File Offset: 0x0023B899
		public virtual void PassCellDataAsFieldDataOn()
		{
			vtkStripper.vtkStripper_PassCellDataAsFieldDataOn_17(base.GetCppThis());
		}

		// Token: 0x06019CED RID: 105709
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_PassThroughCellIdsOff_18(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06019CEE RID: 105710 RVA: 0x0023D6A8 File Offset: 0x0023B8A8
		public virtual void PassThroughCellIdsOff()
		{
			vtkStripper.vtkStripper_PassThroughCellIdsOff_18(base.GetCppThis());
		}

		// Token: 0x06019CEF RID: 105711
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_PassThroughCellIdsOn_19(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06019CF0 RID: 105712 RVA: 0x0023D6B7 File Offset: 0x0023B8B7
		public virtual void PassThroughCellIdsOn()
		{
			vtkStripper.vtkStripper_PassThroughCellIdsOn_19(base.GetCppThis());
		}

		// Token: 0x06019CF1 RID: 105713
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_PassThroughPointIdsOff_20(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a pointdata array that
		/// holds the point index of the original vertex that produced each output
		/// vertex. This is useful for picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06019CF2 RID: 105714 RVA: 0x0023D6C6 File Offset: 0x0023B8C6
		public virtual void PassThroughPointIdsOff()
		{
			vtkStripper.vtkStripper_PassThroughPointIdsOff_20(base.GetCppThis());
		}

		// Token: 0x06019CF3 RID: 105715
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_PassThroughPointIdsOn_21(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a pointdata array that
		/// holds the point index of the original vertex that produced each output
		/// vertex. This is useful for picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06019CF4 RID: 105716 RVA: 0x0023D6D5 File Offset: 0x0023B8D5
		public virtual void PassThroughPointIdsOn()
		{
			vtkStripper.vtkStripper_PassThroughPointIdsOn_21(base.GetCppThis());
		}

		// Token: 0x06019CF5 RID: 105717
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStripper_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019CF6 RID: 105718 RVA: 0x0023D6E4 File Offset: 0x0023B8E4
		public new static vtkStripper SafeDownCast(vtkObjectBase o)
		{
			vtkStripper vtkStripper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStripper.vtkStripper_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStripper = (vtkStripper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStripper.Register(null);
				}
			}
			return vtkStripper;
		}

		// Token: 0x06019CF7 RID: 105719
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_SetJoinContiguousSegments_23(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the output polygonal segments will be joined if they are
		/// contiguous. This is useful after slicing a surface. The default
		/// is off.
		/// </summary>
		// Token: 0x06019CF8 RID: 105720 RVA: 0x0023D763 File Offset: 0x0023B963
		public virtual void SetJoinContiguousSegments(int _arg)
		{
			vtkStripper.vtkStripper_SetJoinContiguousSegments_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06019CF9 RID: 105721
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_SetMaximumLength_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the maximum number of triangles in a triangle strip,
		/// and/or the maximum number of lines in a poly-line.
		/// </summary>
		// Token: 0x06019CFA RID: 105722 RVA: 0x0023D773 File Offset: 0x0023B973
		public virtual void SetMaximumLength(int _arg)
		{
			vtkStripper.vtkStripper_SetMaximumLength_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06019CFB RID: 105723
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_SetPassCellDataAsFieldData_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable passing of the CellData in the input to
		/// the output as FieldData. Note the field data is transformed.
		/// </summary>
		// Token: 0x06019CFC RID: 105724 RVA: 0x0023D783 File Offset: 0x0023B983
		public virtual void SetPassCellDataAsFieldData(int _arg)
		{
			vtkStripper.vtkStripper_SetPassCellDataAsFieldData_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06019CFD RID: 105725
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_SetPassThroughCellIds_26(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06019CFE RID: 105726 RVA: 0x0023D793 File Offset: 0x0023B993
		public virtual void SetPassThroughCellIds(int _arg)
		{
			vtkStripper.vtkStripper_SetPassThroughCellIds_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06019CFF RID: 105727
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStripper_SetPassThroughPointIds_27(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the output polygonal dataset will have a pointdata array that
		/// holds the point index of the original vertex that produced each output
		/// vertex. This is useful for picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06019D00 RID: 105728 RVA: 0x0023D7A3 File Offset: 0x0023B9A3
		public virtual void SetPassThroughPointIds(int _arg)
		{
			vtkStripper.vtkStripper_SetPassThroughPointIds_27(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C0B RID: 7179
		public new const string MRFullTypeName = "Kitware.VTK.vtkStripper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C0C RID: 7180
		public new static readonly string MRClassNameKey = "class vtkStripper";
	}
}
