using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSelectionSource
	/// </summary>
	/// <remarks>
	///    Generate selection from given set of ids
	///
	/// vtkSelectionSource generates a vtkSelection from a set of
	/// (piece id, cell id) pairs. It will only generate the selection values
	/// that match UPDATE_PIECE_NUMBER (i.e. piece == UPDATE_PIECE_NUMBER).
	/// vtkSelectionSource can generate a vtkSelection with one or many
	/// vtkSelectionNodes.
	///
	/// To generate only one vtkSelectionNode, use the functions which don't pass a nodeId
	/// to set/get the node information. To generate more than one vtkSelectionNode, use the
	/// SetNumberOfNodes/RemoveNode to manipulate the number of nodes,
	/// and use the functions that pass the nodeId to set the node information
	/// The different nodes can have different contentType per node but the
	/// fieldType/elementType is common across all nodes.
	///
	/// To define the relation between the nodes you can use SetExpression. If non-empty,
	/// the expression is a boolean expression that defines how the selection nodes present
	/// in the selection are to be combined together to form the selection. If no expression
	/// is specified and there are multiple selection nodes, then the default
	/// expression simply combines all the selection nodes using an `or` operator.
	///
	/// User-supplied, application-specific selections (with a ContentType of
	/// vtkSelectionNode::USER) are not supported.
	/// </remarks>
	// Token: 0x02000841 RID: 2113
	public class vtkSelectionSource : vtkSelectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015D9C RID: 89500 RVA: 0x001ED3AF File Offset: 0x001EB5AF
		static vtkSelectionSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSelectionSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectionSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015D9D RID: 89501 RVA: 0x001ED3D7 File Offset: 0x001EB5D7
		public vtkSelectionSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015D9E RID: 89502
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015D9F RID: 89503 RVA: 0x001ED3E8 File Offset: 0x001EB5E8
		public new static vtkSelectionSource New()
		{
			vtkSelectionSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionSource.vtkSelectionSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectionSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015DA0 RID: 89504 RVA: 0x001ED43C File Offset: 0x001EB63C
		public vtkSelectionSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSelectionSource.vtkSelectionSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015DA1 RID: 89505 RVA: 0x001ED480 File Offset: 0x001EB680
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015DA2 RID: 89506
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddBlock_01(HandleRef pThis, uint nodeId, long block);

		/// <summary>
		/// Add the flat-index/composite index for a block.
		/// </summary>
		// Token: 0x06015DA3 RID: 89507 RVA: 0x001ED48B File Offset: 0x001EB68B
		public void AddBlock(uint nodeId, long block)
		{
			vtkSelectionSource.vtkSelectionSource_AddBlock_01(base.GetCppThis(), nodeId, block);
		}

		// Token: 0x06015DA4 RID: 89508
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddBlock_02(HandleRef pThis, long blockno);

		/// <summary>
		/// Add the flat-index/composite index for a block.
		/// </summary>
		// Token: 0x06015DA5 RID: 89509 RVA: 0x001ED49C File Offset: 0x001EB69C
		public void AddBlock(long blockno)
		{
			vtkSelectionSource.vtkSelectionSource_AddBlock_02(base.GetCppThis(), blockno);
		}

		// Token: 0x06015DA6 RID: 89510
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddBlockSelector_03(HandleRef pThis, uint nodeId, [MarshalAs(UnmanagedType.LPUTF8Str)] string block);

		/// <summary>
		/// Add/Remove block-selectors to make selections with
		/// vtkSelectionNode::BLOCK_SELECTORS as the content-type.
		/// </summary>
		// Token: 0x06015DA7 RID: 89511 RVA: 0x001ED4AC File Offset: 0x001EB6AC
		public void AddBlockSelector(uint nodeId, string block)
		{
			vtkSelectionSource.vtkSelectionSource_AddBlockSelector_03(base.GetCppThis(), nodeId, block);
		}

		// Token: 0x06015DA8 RID: 89512
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddBlockSelector_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Remove block-selectors to make selections with
		/// vtkSelectionNode::BLOCK_SELECTORS as the content-type.
		/// </summary>
		// Token: 0x06015DA9 RID: 89513 RVA: 0x001ED4BD File Offset: 0x001EB6BD
		public void AddBlockSelector(string selector)
		{
			vtkSelectionSource.vtkSelectionSource_AddBlockSelector_04(base.GetCppThis(), selector);
		}

		// Token: 0x06015DAA RID: 89514
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddID_05(HandleRef pThis, uint nodeId, long piece, long id);

		/// <summary>
		/// Add a (piece, id) to the selection set. The source will generate
		/// only the ids for which piece == UPDATE_PIECE_NUMBER.
		/// If piece == -1, the id applies to all pieces.
		/// </summary>
		// Token: 0x06015DAB RID: 89515 RVA: 0x001ED4CD File Offset: 0x001EB6CD
		public void AddID(uint nodeId, long piece, long id)
		{
			vtkSelectionSource.vtkSelectionSource_AddID_05(base.GetCppThis(), nodeId, piece, id);
		}

		// Token: 0x06015DAC RID: 89516
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddID_06(HandleRef pThis, long piece, long id);

		/// <summary>
		/// Add a (piece, id) to the selection set. The source will generate
		/// only the ids for which piece == UPDATE_PIECE_NUMBER.
		/// If piece == -1, the id applies to all pieces.
		/// </summary>
		// Token: 0x06015DAD RID: 89517 RVA: 0x001ED4DF File Offset: 0x001EB6DF
		public void AddID(long piece, long id)
		{
			vtkSelectionSource.vtkSelectionSource_AddID_06(base.GetCppThis(), piece, id);
		}

		// Token: 0x06015DAE RID: 89518
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddLocation_07(HandleRef pThis, uint nodeId, double x, double y, double z);

		/// <summary>
		/// Add a point in world space to probe at.
		/// </summary>
		// Token: 0x06015DAF RID: 89519 RVA: 0x001ED4F0 File Offset: 0x001EB6F0
		public void AddLocation(uint nodeId, double x, double y, double z)
		{
			vtkSelectionSource.vtkSelectionSource_AddLocation_07(base.GetCppThis(), nodeId, x, y, z);
		}

		// Token: 0x06015DB0 RID: 89520
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddLocation_08(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Add a point in world space to probe at.
		/// </summary>
		// Token: 0x06015DB1 RID: 89521 RVA: 0x001ED504 File Offset: 0x001EB704
		public void AddLocation(double x, double y, double z)
		{
			vtkSelectionSource.vtkSelectionSource_AddLocation_08(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06015DB2 RID: 89522
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddSelector_09(HandleRef pThis, uint nodeId, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// For selector-based selection qualification. Note, this should not
		/// be confused with block-selectors used to select blocks using selectors.
		/// These here are qualifiers i.e. they limit the selected items.
		/// </summary>
		// Token: 0x06015DB3 RID: 89523 RVA: 0x001ED516 File Offset: 0x001EB716
		public void AddSelector(uint nodeId, string selector)
		{
			vtkSelectionSource.vtkSelectionSource_AddSelector_09(base.GetCppThis(), nodeId, selector);
		}

		// Token: 0x06015DB4 RID: 89524
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddSelector_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// For selector-based selection qualification. Note, this should not
		/// be confused with block-selectors used to select blocks using selectors.
		/// These here are qualifiers i.e. they limit the selected items.
		/// </summary>
		// Token: 0x06015DB5 RID: 89525 RVA: 0x001ED527 File Offset: 0x001EB727
		public void AddSelector(string selector)
		{
			vtkSelectionSource.vtkSelectionSource_AddSelector_10(base.GetCppThis(), selector);
		}

		// Token: 0x06015DB6 RID: 89526
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddStringID_11(HandleRef pThis, uint nodeId, long piece, [MarshalAs(UnmanagedType.LPUTF8Str)] string id);

		/// <summary>
		/// Add a (piece, id) to the selection set. The source will generate
		/// only the ids for which piece == UPDATE_PIECE_NUMBER.
		/// If piece == -1, the id applies to all pieces.
		/// </summary>
		// Token: 0x06015DB7 RID: 89527 RVA: 0x001ED537 File Offset: 0x001EB737
		public void AddStringID(uint nodeId, long piece, string id)
		{
			vtkSelectionSource.vtkSelectionSource_AddStringID_11(base.GetCppThis(), nodeId, piece, id);
		}

		// Token: 0x06015DB8 RID: 89528
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddStringID_12(HandleRef pThis, long piece, [MarshalAs(UnmanagedType.LPUTF8Str)] string id);

		/// <summary>
		/// Add a (piece, id) to the selection set. The source will generate
		/// only the ids for which piece == UPDATE_PIECE_NUMBER.
		/// If piece == -1, the id applies to all pieces.
		/// </summary>
		// Token: 0x06015DB9 RID: 89529 RVA: 0x001ED549 File Offset: 0x001EB749
		public void AddStringID(long piece, string id)
		{
			vtkSelectionSource.vtkSelectionSource_AddStringID_12(base.GetCppThis(), piece, id);
		}

		// Token: 0x06015DBA RID: 89530
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddThreshold_13(HandleRef pThis, uint nodeId, double min, double max);

		/// <summary>
		/// Add a value range to threshold within.
		/// </summary>
		// Token: 0x06015DBB RID: 89531 RVA: 0x001ED55A File Offset: 0x001EB75A
		public void AddThreshold(uint nodeId, double min, double max)
		{
			vtkSelectionSource.vtkSelectionSource_AddThreshold_13(base.GetCppThis(), nodeId, min, max);
		}

		// Token: 0x06015DBC RID: 89532
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_AddThreshold_14(HandleRef pThis, double min, double max);

		/// <summary>
		/// Add a value range to threshold within.
		/// </summary>
		// Token: 0x06015DBD RID: 89533 RVA: 0x001ED56C File Offset: 0x001EB76C
		public void AddThreshold(double min, double max)
		{
			vtkSelectionSource.vtkSelectionSource_AddThreshold_14(base.GetCppThis(), min, max);
		}

		// Token: 0x06015DBE RID: 89534
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetArrayComponent_15(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Set/Get the component number for the array specified by ArrayName.
		///
		/// The default is component 0. Use -1 for magnitude.
		/// </summary>
		// Token: 0x06015DBF RID: 89535 RVA: 0x001ED580 File Offset: 0x001EB780
		public int GetArrayComponent(uint nodeId)
		{
			return vtkSelectionSource.vtkSelectionSource_GetArrayComponent_15(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015DC0 RID: 89536
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetArrayComponent_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the component number for the array specified by ArrayName.
		///
		/// The default is component 0. Use -1 for magnitude.
		/// </summary>
		// Token: 0x06015DC1 RID: 89537 RVA: 0x001ED5A0 File Offset: 0x001EB7A0
		public int GetArrayComponent()
		{
			return vtkSelectionSource.vtkSelectionSource_GetArrayComponent_16(base.GetCppThis());
		}

		// Token: 0x06015DC2 RID: 89538
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionSource_GetArrayName_17(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Get/Set the name used for the SelectionList in the generated
		/// vtkSelectionNode.
		/// </summary>
		// Token: 0x06015DC3 RID: 89539 RVA: 0x001ED5C0 File Offset: 0x001EB7C0
		public string GetArrayName(uint nodeId)
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectionSource.vtkSelectionSource_GetArrayName_17(base.GetCppThis(), nodeId));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015DC4 RID: 89540
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionSource_GetArrayName_18(HandleRef pThis);

		/// <summary>
		/// Get/Set the name used for the SelectionList in the generated
		/// vtkSelectionNode.
		/// </summary>
		// Token: 0x06015DC5 RID: 89541 RVA: 0x001ED5FC File Offset: 0x001EB7FC
		public string GetArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectionSource.vtkSelectionSource_GetArrayName_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015DC6 RID: 89542
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionSource_GetAssemblyName_19(HandleRef pThis, uint nodeId);

		/// <summary>
		/// For selector-based selection qualification. Note, this should not
		/// be confused with block-selectors used to select blocks using selectors.
		/// These here are qualifiers i.e. they limit the selected items.
		/// </summary>
		// Token: 0x06015DC7 RID: 89543 RVA: 0x001ED638 File Offset: 0x001EB838
		public string GetAssemblyName(uint nodeId)
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectionSource.vtkSelectionSource_GetAssemblyName_19(base.GetCppThis(), nodeId));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015DC8 RID: 89544
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionSource_GetAssemblyName_20(HandleRef pThis);

		/// <summary>
		/// For selector-based selection qualification. Note, this should not
		/// be confused with block-selectors used to select blocks using selectors.
		/// These here are qualifiers i.e. they limit the selected items.
		/// </summary>
		// Token: 0x06015DC9 RID: 89545 RVA: 0x001ED674 File Offset: 0x001EB874
		public string GetAssemblyName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectionSource.vtkSelectionSource_GetAssemblyName_20(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015DCA RID: 89546
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetCompositeIndex_21(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Set/Get the CompositeIndex.
		/// If CompositeIndex &lt; 0 then COMPOSITE_INDEX() is not added to the output.
		///
		/// The default is -1.
		/// </summary>
		// Token: 0x06015DCB RID: 89547 RVA: 0x001ED6B0 File Offset: 0x001EB8B0
		public int GetCompositeIndex(uint nodeId)
		{
			return vtkSelectionSource.vtkSelectionSource_GetCompositeIndex_21(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015DCC RID: 89548
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetCompositeIndex_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the CompositeIndex.
		/// If CompositeIndex &lt; 0 then COMPOSITE_INDEX() is not added to the output.
		///
		/// The default is -1.
		/// </summary>
		// Token: 0x06015DCD RID: 89549 RVA: 0x001ED6D0 File Offset: 0x001EB8D0
		public int GetCompositeIndex()
		{
			return vtkSelectionSource.vtkSelectionSource_GetCompositeIndex_22(base.GetCppThis());
		}

		// Token: 0x06015DCE RID: 89550
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetContainingCells_23(HandleRef pThis, uint nodeId);

		/// <summary>
		/// When extracting by points, extract the cells that contain the
		/// passing points.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06015DCF RID: 89551 RVA: 0x001ED6F0 File Offset: 0x001EB8F0
		public int GetContainingCells(uint nodeId)
		{
			return vtkSelectionSource.vtkSelectionSource_GetContainingCells_23(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015DD0 RID: 89552
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetContainingCells_24(HandleRef pThis);

		/// <summary>
		/// When extracting by points, extract the cells that contain the
		/// passing points.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06015DD1 RID: 89553 RVA: 0x001ED710 File Offset: 0x001EB910
		public int GetContainingCells()
		{
			return vtkSelectionSource.vtkSelectionSource_GetContainingCells_24(base.GetCppThis());
		}

		// Token: 0x06015DD2 RID: 89554
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetContentType_25(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Set/Get the content type.
		/// Possible values are as defined by
		/// vtkSelectionNode::SelectionContent.
		///
		/// The default is vtkSelectionNode::SelectionContent::INDICES.
		/// </summary>
		// Token: 0x06015DD3 RID: 89555 RVA: 0x001ED730 File Offset: 0x001EB930
		public int GetContentType(uint nodeId)
		{
			return vtkSelectionSource.vtkSelectionSource_GetContentType_25(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015DD4 RID: 89556
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetContentType_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the content type.
		/// Possible values are as defined by
		/// vtkSelectionNode::SelectionContent.
		///
		/// The default is vtkSelectionNode::SelectionContent::INDICES.
		/// </summary>
		// Token: 0x06015DD5 RID: 89557 RVA: 0x001ED750 File Offset: 0x001EB950
		public int GetContentType()
		{
			return vtkSelectionSource.vtkSelectionSource_GetContentType_26(base.GetCppThis());
		}

		// Token: 0x06015DD6 RID: 89558
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetContentTypeMaxValue_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the content type.
		/// Possible values are as defined by
		/// vtkSelectionNode::SelectionContent.
		///
		/// The default is vtkSelectionNode::SelectionContent::INDICES.
		/// </summary>
		// Token: 0x06015DD7 RID: 89559 RVA: 0x001ED770 File Offset: 0x001EB970
		public int GetContentTypeMaxValue()
		{
			return vtkSelectionSource.vtkSelectionSource_GetContentTypeMaxValue_27(base.GetCppThis());
		}

		// Token: 0x06015DD8 RID: 89560
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetContentTypeMinValue_28(HandleRef pThis);

		/// <summary>
		/// Set/Get the content type.
		/// Possible values are as defined by
		/// vtkSelectionNode::SelectionContent.
		///
		/// The default is vtkSelectionNode::SelectionContent::INDICES.
		/// </summary>
		// Token: 0x06015DD9 RID: 89561 RVA: 0x001ED790 File Offset: 0x001EB990
		public int GetContentTypeMinValue()
		{
			return vtkSelectionSource.vtkSelectionSource_GetContentTypeMinValue_28(base.GetCppThis());
		}

		// Token: 0x06015DDA RID: 89562
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetElementType_29(HandleRef pThis);

		/// <summary>
		/// Set/Get which types of elements are being selected.
		/// Accepted values are defined in `vtkDataObject::AttributeTypes`. Note,
		/// `vtkDataObject::FIELD` and `vtkDataObject::POINT_THEN_CELL` are not
		/// supported.
		///
		/// The default is vtkDataObject::AttributeTypes::Cell.
		/// </summary>
		// Token: 0x06015DDB RID: 89563 RVA: 0x001ED7B0 File Offset: 0x001EB9B0
		public virtual int GetElementType()
		{
			return vtkSelectionSource.vtkSelectionSource_GetElementType_29(base.GetCppThis());
		}

		// Token: 0x06015DDC RID: 89564
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetElementTypeMaxValue_30(HandleRef pThis);

		/// <summary>
		/// Set/Get which types of elements are being selected.
		/// Accepted values are defined in `vtkDataObject::AttributeTypes`. Note,
		/// `vtkDataObject::FIELD` and `vtkDataObject::POINT_THEN_CELL` are not
		/// supported.
		///
		/// The default is vtkDataObject::AttributeTypes::Cell.
		/// </summary>
		// Token: 0x06015DDD RID: 89565 RVA: 0x001ED7D0 File Offset: 0x001EB9D0
		public virtual int GetElementTypeMaxValue()
		{
			return vtkSelectionSource.vtkSelectionSource_GetElementTypeMaxValue_30(base.GetCppThis());
		}

		// Token: 0x06015DDE RID: 89566
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetElementTypeMinValue_31(HandleRef pThis);

		/// <summary>
		/// Set/Get which types of elements are being selected.
		/// Accepted values are defined in `vtkDataObject::AttributeTypes`. Note,
		/// `vtkDataObject::FIELD` and `vtkDataObject::POINT_THEN_CELL` are not
		/// supported.
		///
		/// The default is vtkDataObject::AttributeTypes::Cell.
		/// </summary>
		// Token: 0x06015DDF RID: 89567 RVA: 0x001ED7F0 File Offset: 0x001EB9F0
		public virtual int GetElementTypeMinValue()
		{
			return vtkSelectionSource.vtkSelectionSource_GetElementTypeMinValue_31(base.GetCppThis());
		}

		// Token: 0x06015DE0 RID: 89568
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionSource_GetExpression_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the expression that defines the boolean expression to combine the
		/// selection nodes. Expression consists of node name identifiers, `|` for
		/// boolean-or, '^' for boolean-xor, '&amp;' for boolean and, '!' for boolean not,
		/// and parenthesis `(` and `)`. If you want to set the expression, be sure to
		/// define the node names. If no expression is specified and there are multiple
		/// selection nodes, then the default expression simply combines all the selection
		/// nodes using an `or` operator.
		///
		/// `SetExpression` does not validate the expression. It will be validated in
		/// `internally.
		/// </summary>
		// Token: 0x06015DE1 RID: 89569 RVA: 0x001ED810 File Offset: 0x001EBA10
		public virtual string GetExpression()
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectionSource.vtkSelectionSource_GetExpression_32(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015DE2 RID: 89570
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetFieldType_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the field type for the generated selection.
		/// Possible values are as defined by
		/// vtkSelectionNode::SelectionField.
		///
		/// The default is vtkSelectionNode::SelectionField::CELL.
		/// </summary>
		// Token: 0x06015DE3 RID: 89571 RVA: 0x001ED84C File Offset: 0x001EBA4C
		public virtual int GetFieldType()
		{
			return vtkSelectionSource.vtkSelectionSource_GetFieldType_33(base.GetCppThis());
		}

		// Token: 0x06015DE4 RID: 89572
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetFieldTypeMaxValue_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the field type for the generated selection.
		/// Possible values are as defined by
		/// vtkSelectionNode::SelectionField.
		///
		/// The default is vtkSelectionNode::SelectionField::CELL.
		/// </summary>
		// Token: 0x06015DE5 RID: 89573 RVA: 0x001ED86C File Offset: 0x001EBA6C
		public virtual int GetFieldTypeMaxValue()
		{
			return vtkSelectionSource.vtkSelectionSource_GetFieldTypeMaxValue_34(base.GetCppThis());
		}

		// Token: 0x06015DE6 RID: 89574
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetFieldTypeMinValue_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the field type for the generated selection.
		/// Possible values are as defined by
		/// vtkSelectionNode::SelectionField.
		///
		/// The default is vtkSelectionNode::SelectionField::CELL.
		/// </summary>
		// Token: 0x06015DE7 RID: 89575 RVA: 0x001ED88C File Offset: 0x001EBA8C
		public virtual int GetFieldTypeMinValue()
		{
			return vtkSelectionSource.vtkSelectionSource_GetFieldTypeMinValue_35(base.GetCppThis());
		}

		// Token: 0x06015DE8 RID: 89576
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetFieldTypeOption_36(HandleRef pThis);

		/// <summary>
		/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
		///
		/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
		/// vtkSelectionNode::SelectionField.
		///
		/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
		/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
		/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
		/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
		///
		/// The default is FIELD_TYPE.
		/// </summary>
		// Token: 0x06015DE9 RID: 89577 RVA: 0x001ED8AC File Offset: 0x001EBAAC
		public virtual int GetFieldTypeOption()
		{
			return vtkSelectionSource.vtkSelectionSource_GetFieldTypeOption_36(base.GetCppThis());
		}

		// Token: 0x06015DEA RID: 89578
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetFieldTypeOptionMaxValue_37(HandleRef pThis);

		/// <summary>
		/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
		///
		/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
		/// vtkSelectionNode::SelectionField.
		///
		/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
		/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
		/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
		/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
		///
		/// The default is FIELD_TYPE.
		/// </summary>
		// Token: 0x06015DEB RID: 89579 RVA: 0x001ED8CC File Offset: 0x001EBACC
		public virtual int GetFieldTypeOptionMaxValue()
		{
			return vtkSelectionSource.vtkSelectionSource_GetFieldTypeOptionMaxValue_37(base.GetCppThis());
		}

		// Token: 0x06015DEC RID: 89580
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetFieldTypeOptionMinValue_38(HandleRef pThis);

		/// <summary>
		/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
		///
		/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
		/// vtkSelectionNode::SelectionField.
		///
		/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
		/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
		/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
		/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
		///
		/// The default is FIELD_TYPE.
		/// </summary>
		// Token: 0x06015DED RID: 89581 RVA: 0x001ED8EC File Offset: 0x001EBAEC
		public virtual int GetFieldTypeOptionMinValue()
		{
			return vtkSelectionSource.vtkSelectionSource_GetFieldTypeOptionMinValue_38(base.GetCppThis());
		}

		// Token: 0x06015DEE RID: 89582
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetHierarchicalIndex_39(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Set/Get the Hierarchical/HierarchicalIndex.
		/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
		/// and HIERARCHICAL_INDEX() keys are not added to the output.
		///
		/// The default for both is -1.
		/// </summary>
		// Token: 0x06015DEF RID: 89583 RVA: 0x001ED90C File Offset: 0x001EBB0C
		public int GetHierarchicalIndex(uint nodeId)
		{
			return vtkSelectionSource.vtkSelectionSource_GetHierarchicalIndex_39(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015DF0 RID: 89584
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetHierarchicalIndex_40(HandleRef pThis);

		/// <summary>
		/// Set/Get the Hierarchical/HierarchicalIndex.
		/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
		/// and HIERARCHICAL_INDEX() keys are not added to the output.
		///
		/// The default for both is -1.
		/// </summary>
		// Token: 0x06015DF1 RID: 89585 RVA: 0x001ED92C File Offset: 0x001EBB2C
		public int GetHierarchicalIndex()
		{
			return vtkSelectionSource.vtkSelectionSource_GetHierarchicalIndex_40(base.GetCppThis());
		}

		// Token: 0x06015DF2 RID: 89586
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetHierarchicalLevel_41(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Set/Get the Hierarchical/HierarchicalIndex.
		/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
		/// and HIERARCHICAL_INDEX() keys are not added to the output.
		///
		/// The default for both is -1.
		/// </summary>
		// Token: 0x06015DF3 RID: 89587 RVA: 0x001ED94C File Offset: 0x001EBB4C
		public int GetHierarchicalLevel(uint nodeId)
		{
			return vtkSelectionSource.vtkSelectionSource_GetHierarchicalLevel_41(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015DF4 RID: 89588
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetHierarchicalLevel_42(HandleRef pThis);

		/// <summary>
		/// Set/Get the Hierarchical/HierarchicalIndex.
		/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
		/// and HIERARCHICAL_INDEX() keys are not added to the output.
		///
		/// The default for both is -1.
		/// </summary>
		// Token: 0x06015DF5 RID: 89589 RVA: 0x001ED96C File Offset: 0x001EBB6C
		public int GetHierarchicalLevel()
		{
			return vtkSelectionSource.vtkSelectionSource_GetHierarchicalLevel_42(base.GetCppThis());
		}

		// Token: 0x06015DF6 RID: 89590
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetInverse_43(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Determines whether the selection describes what to include or exclude.
		///
		/// The Default is 0, meaning include.
		/// </summary>
		// Token: 0x06015DF7 RID: 89591 RVA: 0x001ED98C File Offset: 0x001EBB8C
		public int GetInverse(uint nodeId)
		{
			return vtkSelectionSource.vtkSelectionSource_GetInverse_43(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015DF8 RID: 89592
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetInverse_44(HandleRef pThis);

		/// <summary>
		/// Determines whether the selection describes what to include or exclude.
		///
		/// The Default is 0, meaning include.
		/// </summary>
		// Token: 0x06015DF9 RID: 89593 RVA: 0x001ED9AC File Offset: 0x001EBBAC
		public int GetInverse()
		{
			return vtkSelectionSource.vtkSelectionSource_GetInverse_44(base.GetCppThis());
		}

		// Token: 0x06015DFA RID: 89594
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionSource_GetNodeName_45(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Set/Get the node name.
		///
		/// If you want to set the Expression, be sure to define the node names.
		///
		/// If the node name is not defined, a default node name is created atomically
		/// at each execution of the filter to guarantee uniqueness. GetNodeName()
		/// will return a non-empty name only if you have defined it before.
		/// </summary>
		// Token: 0x06015DFB RID: 89595 RVA: 0x001ED9CC File Offset: 0x001EBBCC
		public string GetNodeName(uint nodeId)
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectionSource.vtkSelectionSource_GetNodeName_45(base.GetCppThis(), nodeId));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015DFC RID: 89596
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionSource_GetNodeName_46(HandleRef pThis);

		/// <summary>
		/// Set/Get the node name.
		///
		/// If you want to set the Expression, be sure to define the node names.
		///
		/// If the node name is not defined, a default node name is created atomically
		/// at each execution of the filter to guarantee uniqueness. GetNodeName()
		/// will return a non-empty name only if you have defined it before.
		/// </summary>
		// Token: 0x06015DFD RID: 89597 RVA: 0x001EDA08 File Offset: 0x001EBC08
		public string GetNodeName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectionSource.vtkSelectionSource_GetNodeName_46(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015DFE RID: 89598
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelectionSource_GetNumberOfGenerationsFromBase_47(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015DFF RID: 89599 RVA: 0x001EDA44 File Offset: 0x001EBC44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSelectionSource.vtkSelectionSource_GetNumberOfGenerationsFromBase_47(base.GetCppThis(), type);
		}

		// Token: 0x06015E00 RID: 89600
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelectionSource_GetNumberOfGenerationsFromBaseType_48([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015E01 RID: 89601 RVA: 0x001EDA64 File Offset: 0x001EBC64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSelectionSource.vtkSelectionSource_GetNumberOfGenerationsFromBaseType_48(type);
		}

		// Token: 0x06015E02 RID: 89602
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetNumberOfLayers_49(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Set/Get the number of layers to extract connected to the selected elements.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x06015E03 RID: 89603 RVA: 0x001EDA80 File Offset: 0x001EBC80
		public int GetNumberOfLayers(uint nodeId)
		{
			return vtkSelectionSource.vtkSelectionSource_GetNumberOfLayers_49(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015E04 RID: 89604
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetNumberOfLayers_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of layers to extract connected to the selected elements.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x06015E05 RID: 89605 RVA: 0x001EDAA0 File Offset: 0x001EBCA0
		public int GetNumberOfLayers()
		{
			return vtkSelectionSource.vtkSelectionSource_GetNumberOfLayers_50(base.GetCppThis());
		}

		// Token: 0x06015E06 RID: 89606
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetNumberOfLayersMaxValue_51(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of layers to extract connected to the selected elements.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x06015E07 RID: 89607 RVA: 0x001EDAC0 File Offset: 0x001EBCC0
		public int GetNumberOfLayersMaxValue()
		{
			return vtkSelectionSource.vtkSelectionSource_GetNumberOfLayersMaxValue_51(base.GetCppThis());
		}

		// Token: 0x06015E08 RID: 89608
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetNumberOfLayersMinValue_52(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of layers to extract connected to the selected elements.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x06015E09 RID: 89609 RVA: 0x001EDAE0 File Offset: 0x001EBCE0
		public int GetNumberOfLayersMinValue()
		{
			return vtkSelectionSource.vtkSelectionSource_GetNumberOfLayersMinValue_52(base.GetCppThis());
		}

		// Token: 0x06015E0A RID: 89610
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkSelectionSource_GetNumberOfNodes_53(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of nodes that will be created for the generated selection.
		///
		/// The default is 1.
		/// </summary>
		// Token: 0x06015E0B RID: 89611 RVA: 0x001EDB00 File Offset: 0x001EBD00
		public uint GetNumberOfNodes()
		{
			return vtkSelectionSource.vtkSelectionSource_GetNumberOfNodes_53(base.GetCppThis());
		}

		// Token: 0x06015E0C RID: 89612
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetProcessID_54(HandleRef pThis);

		/// <summary>
		/// Set/Get which process to limit the selection to. `-1` is treated as
		/// all processes.
		///
		/// The default is -1.
		/// </summary>
		// Token: 0x06015E0D RID: 89613 RVA: 0x001EDB20 File Offset: 0x001EBD20
		public virtual int GetProcessID()
		{
			return vtkSelectionSource.vtkSelectionSource_GetProcessID_54(base.GetCppThis());
		}

		// Token: 0x06015E0E RID: 89614
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetProcessIDMaxValue_55(HandleRef pThis);

		/// <summary>
		/// Set/Get which process to limit the selection to. `-1` is treated as
		/// all processes.
		///
		/// The default is -1.
		/// </summary>
		// Token: 0x06015E0F RID: 89615 RVA: 0x001EDB40 File Offset: 0x001EBD40
		public virtual int GetProcessIDMaxValue()
		{
			return vtkSelectionSource.vtkSelectionSource_GetProcessIDMaxValue_55(base.GetCppThis());
		}

		// Token: 0x06015E10 RID: 89616
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_GetProcessIDMinValue_56(HandleRef pThis);

		/// <summary>
		/// Set/Get which process to limit the selection to. `-1` is treated as
		/// all processes.
		///
		/// The default is -1.
		/// </summary>
		// Token: 0x06015E11 RID: 89617 RVA: 0x001EDB60 File Offset: 0x001EBD60
		public virtual int GetProcessIDMinValue()
		{
			return vtkSelectionSource.vtkSelectionSource_GetProcessIDMinValue_56(base.GetCppThis());
		}

		// Token: 0x06015E12 RID: 89618
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionSource_GetQueryString_57(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Set/Get the query expression string.
		/// </summary>
		// Token: 0x06015E13 RID: 89619 RVA: 0x001EDB80 File Offset: 0x001EBD80
		public string GetQueryString(uint nodeId)
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectionSource.vtkSelectionSource_GetQueryString_57(base.GetCppThis(), nodeId));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015E14 RID: 89620
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionSource_GetQueryString_58(HandleRef pThis);

		/// <summary>
		/// Set/Get the query expression string.
		/// </summary>
		// Token: 0x06015E15 RID: 89621 RVA: 0x001EDBBC File Offset: 0x001EBDBC
		public string GetQueryString()
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectionSource.vtkSelectionSource_GetQueryString_58(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015E16 RID: 89622
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSelectionSource_GetRemoveIntermediateLayers_59(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Set/Get the number of layers related flag to remove intermediate layers
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06015E17 RID: 89623 RVA: 0x001EDBF8 File Offset: 0x001EBDF8
		public bool GetRemoveIntermediateLayers(uint nodeId)
		{
			return vtkSelectionSource.vtkSelectionSource_GetRemoveIntermediateLayers_59(base.GetCppThis(), nodeId) != 0;
		}

		// Token: 0x06015E18 RID: 89624
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSelectionSource_GetRemoveIntermediateLayers_60(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of layers related flag to remove intermediate layers
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06015E19 RID: 89625 RVA: 0x001EDC20 File Offset: 0x001EBE20
		public bool GetRemoveIntermediateLayers()
		{
			return vtkSelectionSource.vtkSelectionSource_GetRemoveIntermediateLayers_60(base.GetCppThis()) != 0;
		}

		// Token: 0x06015E1A RID: 89626
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSelectionSource_GetRemoveSeed_61(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Set/Get the number of layers related flag to remove seed selection
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06015E1B RID: 89627 RVA: 0x001EDC48 File Offset: 0x001EBE48
		public bool GetRemoveSeed(uint nodeId)
		{
			return vtkSelectionSource.vtkSelectionSource_GetRemoveSeed_61(base.GetCppThis(), nodeId) != 0;
		}

		// Token: 0x06015E1C RID: 89628
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSelectionSource_GetRemoveSeed_62(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of layers related flag to remove seed selection
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06015E1D RID: 89629 RVA: 0x001EDC70 File Offset: 0x001EBE70
		public bool GetRemoveSeed()
		{
			return vtkSelectionSource.vtkSelectionSource_GetRemoveSeed_62(base.GetCppThis()) != 0;
		}

		// Token: 0x06015E1E RID: 89630
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_IsA_63(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015E1F RID: 89631 RVA: 0x001EDC98 File Offset: 0x001EBE98
		public override int IsA(string type)
		{
			return vtkSelectionSource.vtkSelectionSource_IsA_63(base.GetCppThis(), type);
		}

		// Token: 0x06015E20 RID: 89632
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionSource_IsTypeOf_64([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015E21 RID: 89633 RVA: 0x001EDCB8 File Offset: 0x001EBEB8
		public new static int IsTypeOf(string type)
		{
			return vtkSelectionSource.vtkSelectionSource_IsTypeOf_64(type);
		}

		// Token: 0x06015E22 RID: 89634
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionSource_NewInstance_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015E23 RID: 89635 RVA: 0x001EDCD4 File Offset: 0x001EBED4
		public new vtkSelectionSource NewInstance()
		{
			vtkSelectionSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionSource.vtkSelectionSource_NewInstance_66(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectionSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015E24 RID: 89636
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllBlockSelectors_67(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Add/Remove block-selectors to make selections with
		/// vtkSelectionNode::BLOCK_SELECTORS as the content-type.
		/// </summary>
		// Token: 0x06015E25 RID: 89637 RVA: 0x001EDD2E File Offset: 0x001EBF2E
		public void RemoveAllBlockSelectors(uint nodeId)
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllBlockSelectors_67(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015E26 RID: 89638
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllBlockSelectors_68(HandleRef pThis);

		/// <summary>
		/// Add/Remove block-selectors to make selections with
		/// vtkSelectionNode::BLOCK_SELECTORS as the content-type.
		/// </summary>
		// Token: 0x06015E27 RID: 89639 RVA: 0x001EDD3E File Offset: 0x001EBF3E
		public void RemoveAllBlockSelectors()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllBlockSelectors_68(base.GetCppThis());
		}

		// Token: 0x06015E28 RID: 89640
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllBlocks_69(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Remove all blocks added with AddBlock.
		/// </summary>
		// Token: 0x06015E29 RID: 89641 RVA: 0x001EDD4D File Offset: 0x001EBF4D
		public void RemoveAllBlocks(uint nodeId)
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllBlocks_69(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015E2A RID: 89642
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllBlocks_70(HandleRef pThis);

		/// <summary>
		/// Remove all blocks added with AddBlock.
		/// </summary>
		// Token: 0x06015E2B RID: 89643 RVA: 0x001EDD5D File Offset: 0x001EBF5D
		public void RemoveAllBlocks()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllBlocks_70(base.GetCppThis());
		}

		// Token: 0x06015E2C RID: 89644
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllIDs_71(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Removes all IDs.
		/// </summary>
		// Token: 0x06015E2D RID: 89645 RVA: 0x001EDD6C File Offset: 0x001EBF6C
		public void RemoveAllIDs(uint nodeId)
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllIDs_71(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015E2E RID: 89646
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllIDs_72(HandleRef pThis);

		/// <summary>
		/// Removes all IDs.
		/// </summary>
		// Token: 0x06015E2F RID: 89647 RVA: 0x001EDD7C File Offset: 0x001EBF7C
		public void RemoveAllIDs()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllIDs_72(base.GetCppThis());
		}

		// Token: 0x06015E30 RID: 89648
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllLocations_73(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Remove all locations added with AddLocation.
		/// </summary>
		// Token: 0x06015E31 RID: 89649 RVA: 0x001EDD8B File Offset: 0x001EBF8B
		public void RemoveAllLocations(uint nodeId)
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllLocations_73(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015E32 RID: 89650
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllLocations_74(HandleRef pThis);

		/// <summary>
		/// Remove all locations added with AddLocation.
		/// </summary>
		// Token: 0x06015E33 RID: 89651 RVA: 0x001EDD9B File Offset: 0x001EBF9B
		public void RemoveAllLocations()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllLocations_74(base.GetCppThis());
		}

		// Token: 0x06015E34 RID: 89652
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllNodes_75(HandleRef pThis);

		/// <summary>
		/// Remove all selection nodes.
		/// </summary>
		// Token: 0x06015E35 RID: 89653 RVA: 0x001EDDAA File Offset: 0x001EBFAA
		public virtual void RemoveAllNodes()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllNodes_75(base.GetCppThis());
		}

		// Token: 0x06015E36 RID: 89654
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllSelectors_76(HandleRef pThis, uint nodeId);

		/// <summary>
		/// For selector-based selection qualification. Note, this should not
		/// be confused with block-selectors used to select blocks using selectors.
		/// These here are qualifiers i.e. they limit the selected items.
		/// </summary>
		// Token: 0x06015E37 RID: 89655 RVA: 0x001EDDB9 File Offset: 0x001EBFB9
		public void RemoveAllSelectors(uint nodeId)
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllSelectors_76(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015E38 RID: 89656
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllSelectors_77(HandleRef pThis);

		/// <summary>
		/// For selector-based selection qualification. Note, this should not
		/// be confused with block-selectors used to select blocks using selectors.
		/// These here are qualifiers i.e. they limit the selected items.
		/// </summary>
		// Token: 0x06015E39 RID: 89657 RVA: 0x001EDDC9 File Offset: 0x001EBFC9
		public void RemoveAllSelectors()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllSelectors_77(base.GetCppThis());
		}

		// Token: 0x06015E3A RID: 89658
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllStringIDs_78(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Removes all IDs.
		/// </summary>
		// Token: 0x06015E3B RID: 89659 RVA: 0x001EDDD8 File Offset: 0x001EBFD8
		public void RemoveAllStringIDs(uint nodeId)
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllStringIDs_78(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015E3C RID: 89660
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllStringIDs_79(HandleRef pThis);

		/// <summary>
		/// Removes all IDs.
		/// </summary>
		// Token: 0x06015E3D RID: 89661 RVA: 0x001EDDE8 File Offset: 0x001EBFE8
		public void RemoveAllStringIDs()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllStringIDs_79(base.GetCppThis());
		}

		// Token: 0x06015E3E RID: 89662
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllThresholds_80(HandleRef pThis, uint nodeId);

		/// <summary>
		/// Remove all thresholds added with AddThreshold.
		/// </summary>
		// Token: 0x06015E3F RID: 89663 RVA: 0x001EDDF7 File Offset: 0x001EBFF7
		public void RemoveAllThresholds(uint nodeId)
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllThresholds_80(base.GetCppThis(), nodeId);
		}

		// Token: 0x06015E40 RID: 89664
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveAllThresholds_81(HandleRef pThis);

		/// <summary>
		/// Remove all thresholds added with AddThreshold.
		/// </summary>
		// Token: 0x06015E41 RID: 89665 RVA: 0x001EDE07 File Offset: 0x001EC007
		public void RemoveAllThresholds()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllThresholds_81(base.GetCppThis());
		}

		// Token: 0x06015E42 RID: 89666
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveNode_82(HandleRef pThis, uint idx);

		/// <summary>
		/// Remove a selection node.
		/// </summary>
		// Token: 0x06015E43 RID: 89667 RVA: 0x001EDE16 File Offset: 0x001EC016
		public void RemoveNode(uint idx)
		{
			vtkSelectionSource.vtkSelectionSource_RemoveNode_82(base.GetCppThis(), idx);
		}

		// Token: 0x06015E44 RID: 89668
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_RemoveNode_83(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Remove a selection node.
		/// </summary>
		// Token: 0x06015E45 RID: 89669 RVA: 0x001EDE26 File Offset: 0x001EC026
		public void RemoveNode(string name)
		{
			vtkSelectionSource.vtkSelectionSource_RemoveNode_83(base.GetCppThis(), name);
		}

		// Token: 0x06015E46 RID: 89670
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionSource_SafeDownCast_84(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015E47 RID: 89671 RVA: 0x001EDE38 File Offset: 0x001EC038
		public new static vtkSelectionSource SafeDownCast(vtkObjectBase o)
		{
			vtkSelectionSource vtkSelectionSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionSource.vtkSelectionSource_SafeDownCast_84((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelectionSource = (vtkSelectionSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelectionSource.Register(null);
				}
			}
			return vtkSelectionSource;
		}

		// Token: 0x06015E48 RID: 89672
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetArrayComponent_85(HandleRef pThis, uint nodeId, int component);

		/// <summary>
		/// Set/Get the component number for the array specified by ArrayName.
		///
		/// The default is component 0. Use -1 for magnitude.
		/// </summary>
		// Token: 0x06015E49 RID: 89673 RVA: 0x001EDEB7 File Offset: 0x001EC0B7
		public void SetArrayComponent(uint nodeId, int component)
		{
			vtkSelectionSource.vtkSelectionSource_SetArrayComponent_85(base.GetCppThis(), nodeId, component);
		}

		// Token: 0x06015E4A RID: 89674
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetArrayComponent_86(HandleRef pThis, int component);

		/// <summary>
		/// Set/Get the component number for the array specified by ArrayName.
		///
		/// The default is component 0. Use -1 for magnitude.
		/// </summary>
		// Token: 0x06015E4B RID: 89675 RVA: 0x001EDEC8 File Offset: 0x001EC0C8
		public void SetArrayComponent(int component)
		{
			vtkSelectionSource.vtkSelectionSource_SetArrayComponent_86(base.GetCppThis(), component);
		}

		// Token: 0x06015E4C RID: 89676
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetArrayName_87(HandleRef pThis, uint nodeId, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set the name used for the SelectionList in the generated
		/// vtkSelectionNode.
		/// </summary>
		// Token: 0x06015E4D RID: 89677 RVA: 0x001EDED8 File Offset: 0x001EC0D8
		public void SetArrayName(uint nodeId, string name)
		{
			vtkSelectionSource.vtkSelectionSource_SetArrayName_87(base.GetCppThis(), nodeId, name);
		}

		// Token: 0x06015E4E RID: 89678
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetArrayName_88(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set the name used for the SelectionList in the generated
		/// vtkSelectionNode.
		/// </summary>
		// Token: 0x06015E4F RID: 89679 RVA: 0x001EDEE9 File Offset: 0x001EC0E9
		public void SetArrayName(string name)
		{
			vtkSelectionSource.vtkSelectionSource_SetArrayName_88(base.GetCppThis(), name);
		}

		// Token: 0x06015E50 RID: 89680
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetAssemblyName_89(HandleRef pThis, uint nodeId, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// For selector-based selection qualification. Note, this should not
		/// be confused with block-selectors used to select blocks using selectors.
		/// These here are qualifiers i.e. they limit the selected items.
		/// </summary>
		// Token: 0x06015E51 RID: 89681 RVA: 0x001EDEF9 File Offset: 0x001EC0F9
		public void SetAssemblyName(uint nodeId, string name)
		{
			vtkSelectionSource.vtkSelectionSource_SetAssemblyName_89(base.GetCppThis(), nodeId, name);
		}

		// Token: 0x06015E52 RID: 89682
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetAssemblyName_90(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// For selector-based selection qualification. Note, this should not
		/// be confused with block-selectors used to select blocks using selectors.
		/// These here are qualifiers i.e. they limit the selected items.
		/// </summary>
		// Token: 0x06015E53 RID: 89683 RVA: 0x001EDF0A File Offset: 0x001EC10A
		public void SetAssemblyName(string name)
		{
			vtkSelectionSource.vtkSelectionSource_SetAssemblyName_90(base.GetCppThis(), name);
		}

		// Token: 0x06015E54 RID: 89684
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetCompositeIndex_91(HandleRef pThis, uint nodeId, int index);

		/// <summary>
		/// Set/Get the CompositeIndex.
		/// If CompositeIndex &lt; 0 then COMPOSITE_INDEX() is not added to the output.
		///
		/// The default is -1.
		/// </summary>
		// Token: 0x06015E55 RID: 89685 RVA: 0x001EDF1A File Offset: 0x001EC11A
		public void SetCompositeIndex(uint nodeId, int index)
		{
			vtkSelectionSource.vtkSelectionSource_SetCompositeIndex_91(base.GetCppThis(), nodeId, index);
		}

		// Token: 0x06015E56 RID: 89686
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetCompositeIndex_92(HandleRef pThis, int compositeIndex);

		/// <summary>
		/// Set/Get the CompositeIndex.
		/// If CompositeIndex &lt; 0 then COMPOSITE_INDEX() is not added to the output.
		///
		/// The default is -1.
		/// </summary>
		// Token: 0x06015E57 RID: 89687 RVA: 0x001EDF2B File Offset: 0x001EC12B
		public void SetCompositeIndex(int compositeIndex)
		{
			vtkSelectionSource.vtkSelectionSource_SetCompositeIndex_92(base.GetCppThis(), compositeIndex);
		}

		// Token: 0x06015E58 RID: 89688
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetContainingCells_93(HandleRef pThis, uint nodeId, int containingCells);

		/// <summary>
		/// When extracting by points, extract the cells that contain the
		/// passing points.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06015E59 RID: 89689 RVA: 0x001EDF3B File Offset: 0x001EC13B
		public void SetContainingCells(uint nodeId, int containingCells)
		{
			vtkSelectionSource.vtkSelectionSource_SetContainingCells_93(base.GetCppThis(), nodeId, containingCells);
		}

		// Token: 0x06015E5A RID: 89690
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetContainingCells_94(HandleRef pThis, int containingCells);

		/// <summary>
		/// When extracting by points, extract the cells that contain the
		/// passing points.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06015E5B RID: 89691 RVA: 0x001EDF4C File Offset: 0x001EC14C
		public void SetContainingCells(int containingCells)
		{
			vtkSelectionSource.vtkSelectionSource_SetContainingCells_94(base.GetCppThis(), containingCells);
		}

		// Token: 0x06015E5C RID: 89692
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetContentType_95(HandleRef pThis, uint nodeId, int type);

		/// <summary>
		/// Set/Get the content type.
		/// Possible values are as defined by
		/// vtkSelectionNode::SelectionContent.
		///
		/// The default is vtkSelectionNode::SelectionContent::INDICES.
		/// </summary>
		// Token: 0x06015E5D RID: 89693 RVA: 0x001EDF5C File Offset: 0x001EC15C
		public void SetContentType(uint nodeId, int type)
		{
			vtkSelectionSource.vtkSelectionSource_SetContentType_95(base.GetCppThis(), nodeId, type);
		}

		// Token: 0x06015E5E RID: 89694
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetContentType_96(HandleRef pThis, int contentType);

		/// <summary>
		/// Set/Get the content type.
		/// Possible values are as defined by
		/// vtkSelectionNode::SelectionContent.
		///
		/// The default is vtkSelectionNode::SelectionContent::INDICES.
		/// </summary>
		// Token: 0x06015E5F RID: 89695 RVA: 0x001EDF6D File Offset: 0x001EC16D
		public void SetContentType(int contentType)
		{
			vtkSelectionSource.vtkSelectionSource_SetContentType_96(base.GetCppThis(), contentType);
		}

		// Token: 0x06015E60 RID: 89696
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetElementType_97(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get which types of elements are being selected.
		/// Accepted values are defined in `vtkDataObject::AttributeTypes`. Note,
		/// `vtkDataObject::FIELD` and `vtkDataObject::POINT_THEN_CELL` are not
		/// supported.
		///
		/// The default is vtkDataObject::AttributeTypes::Cell.
		/// </summary>
		// Token: 0x06015E61 RID: 89697 RVA: 0x001EDF7D File Offset: 0x001EC17D
		public virtual void SetElementType(int _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetElementType_97(base.GetCppThis(), _arg);
		}

		// Token: 0x06015E62 RID: 89698
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetExpression_98(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get the expression that defines the boolean expression to combine the
		/// selection nodes. Expression consists of node name identifiers, `|` for
		/// boolean-or, '^' for boolean-xor, '&amp;' for boolean and, '!' for boolean not,
		/// and parenthesis `(` and `)`. If you want to set the expression, be sure to
		/// define the node names. If no expression is specified and there are multiple
		/// selection nodes, then the default expression simply combines all the selection
		/// nodes using an `or` operator.
		///
		/// `SetExpression` does not validate the expression. It will be validated in
		/// `internally.
		/// </summary>
		// Token: 0x06015E63 RID: 89699 RVA: 0x001EDF8D File Offset: 0x001EC18D
		public virtual void SetExpression(string arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetExpression_98(base.GetCppThis(), arg);
		}

		// Token: 0x06015E64 RID: 89700
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetFieldType_99(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the field type for the generated selection.
		/// Possible values are as defined by
		/// vtkSelectionNode::SelectionField.
		///
		/// The default is vtkSelectionNode::SelectionField::CELL.
		/// </summary>
		// Token: 0x06015E65 RID: 89701 RVA: 0x001EDF9D File Offset: 0x001EC19D
		public virtual void SetFieldType(int _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetFieldType_99(base.GetCppThis(), _arg);
		}

		// Token: 0x06015E66 RID: 89702
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetFieldTypeOption_100(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
		///
		/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
		/// vtkSelectionNode::SelectionField.
		///
		/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
		/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
		/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
		/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
		///
		/// The default is FIELD_TYPE.
		/// </summary>
		// Token: 0x06015E67 RID: 89703 RVA: 0x001EDFAD File Offset: 0x001EC1AD
		public virtual void SetFieldTypeOption(int _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetFieldTypeOption_100(base.GetCppThis(), _arg);
		}

		// Token: 0x06015E68 RID: 89704
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetFieldTypeOptionToElementType_101(HandleRef pThis);

		/// <summary>
		/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
		///
		/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
		/// vtkSelectionNode::SelectionField.
		///
		/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
		/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
		/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
		/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
		///
		/// The default is FIELD_TYPE.
		/// </summary>
		// Token: 0x06015E69 RID: 89705 RVA: 0x001EDFBD File Offset: 0x001EC1BD
		public virtual void SetFieldTypeOptionToElementType()
		{
			vtkSelectionSource.vtkSelectionSource_SetFieldTypeOptionToElementType_101(base.GetCppThis());
		}

		// Token: 0x06015E6A RID: 89706
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetFieldTypeOptionToFieldType_102(HandleRef pThis);

		/// <summary>
		/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
		///
		/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
		/// vtkSelectionNode::SelectionField.
		///
		/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
		/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
		/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
		/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
		///
		/// The default is FIELD_TYPE.
		/// </summary>
		// Token: 0x06015E6B RID: 89707 RVA: 0x001EDFCC File Offset: 0x001EC1CC
		public virtual void SetFieldTypeOptionToFieldType()
		{
			vtkSelectionSource.vtkSelectionSource_SetFieldTypeOptionToFieldType_102(base.GetCppThis());
		}

		// Token: 0x06015E6C RID: 89708
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetFrustum_103(HandleRef pThis, uint nodeId, IntPtr vertices);

		/// <summary>
		/// Set a frustum to choose within.
		/// </summary>
		// Token: 0x06015E6D RID: 89709 RVA: 0x001EDFDB File Offset: 0x001EC1DB
		public void SetFrustum(uint nodeId, IntPtr vertices)
		{
			vtkSelectionSource.vtkSelectionSource_SetFrustum_103(base.GetCppThis(), nodeId, vertices);
		}

		// Token: 0x06015E6E RID: 89710
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetFrustum_104(HandleRef pThis, IntPtr vertices);

		/// <summary>
		/// Set a frustum to choose within.
		/// </summary>
		// Token: 0x06015E6F RID: 89711 RVA: 0x001EDFEC File Offset: 0x001EC1EC
		public void SetFrustum(IntPtr vertices)
		{
			vtkSelectionSource.vtkSelectionSource_SetFrustum_104(base.GetCppThis(), vertices);
		}

		// Token: 0x06015E70 RID: 89712
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetHierarchicalIndex_105(HandleRef pThis, uint nodeId, int index);

		/// <summary>
		/// Set/Get the Hierarchical/HierarchicalIndex.
		/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
		/// and HIERARCHICAL_INDEX() keys are not added to the output.
		///
		/// The default for both is -1.
		/// </summary>
		// Token: 0x06015E71 RID: 89713 RVA: 0x001EDFFC File Offset: 0x001EC1FC
		public void SetHierarchicalIndex(uint nodeId, int index)
		{
			vtkSelectionSource.vtkSelectionSource_SetHierarchicalIndex_105(base.GetCppThis(), nodeId, index);
		}

		// Token: 0x06015E72 RID: 89714
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetHierarchicalIndex_106(HandleRef pThis, int index);

		/// <summary>
		/// Set/Get the Hierarchical/HierarchicalIndex.
		/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
		/// and HIERARCHICAL_INDEX() keys are not added to the output.
		///
		/// The default for both is -1.
		/// </summary>
		// Token: 0x06015E73 RID: 89715 RVA: 0x001EE00D File Offset: 0x001EC20D
		public void SetHierarchicalIndex(int index)
		{
			vtkSelectionSource.vtkSelectionSource_SetHierarchicalIndex_106(base.GetCppThis(), index);
		}

		// Token: 0x06015E74 RID: 89716
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetHierarchicalLevel_107(HandleRef pThis, uint nodeId, int level);

		/// <summary>
		/// Set/Get the Hierarchical/HierarchicalIndex.
		/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
		/// and HIERARCHICAL_INDEX() keys are not added to the output.
		///
		/// The default for both is -1.
		/// </summary>
		// Token: 0x06015E75 RID: 89717 RVA: 0x001EE01D File Offset: 0x001EC21D
		public void SetHierarchicalLevel(uint nodeId, int level)
		{
			vtkSelectionSource.vtkSelectionSource_SetHierarchicalLevel_107(base.GetCppThis(), nodeId, level);
		}

		// Token: 0x06015E76 RID: 89718
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetHierarchicalLevel_108(HandleRef pThis, int level);

		/// <summary>
		/// Set/Get the Hierarchical/HierarchicalIndex.
		/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
		/// and HIERARCHICAL_INDEX() keys are not added to the output.
		///
		/// The default for both is -1.
		/// </summary>
		// Token: 0x06015E77 RID: 89719 RVA: 0x001EE02E File Offset: 0x001EC22E
		public void SetHierarchicalLevel(int level)
		{
			vtkSelectionSource.vtkSelectionSource_SetHierarchicalLevel_108(base.GetCppThis(), level);
		}

		// Token: 0x06015E78 RID: 89720
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetInverse_109(HandleRef pThis, uint nodeId, int inverse);

		/// <summary>
		/// Determines whether the selection describes what to include or exclude.
		///
		/// The Default is 0, meaning include.
		/// </summary>
		// Token: 0x06015E79 RID: 89721 RVA: 0x001EE03E File Offset: 0x001EC23E
		public void SetInverse(uint nodeId, int inverse)
		{
			vtkSelectionSource.vtkSelectionSource_SetInverse_109(base.GetCppThis(), nodeId, inverse);
		}

		// Token: 0x06015E7A RID: 89722
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetInverse_110(HandleRef pThis, int inverse);

		/// <summary>
		/// Determines whether the selection describes what to include or exclude.
		///
		/// The Default is 0, meaning include.
		/// </summary>
		// Token: 0x06015E7B RID: 89723 RVA: 0x001EE04F File Offset: 0x001EC24F
		public void SetInverse(int inverse)
		{
			vtkSelectionSource.vtkSelectionSource_SetInverse_110(base.GetCppThis(), inverse);
		}

		// Token: 0x06015E7C RID: 89724
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetNodeName_111(HandleRef pThis, uint nodeId, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the node name.
		///
		/// If you want to set the Expression, be sure to define the node names.
		///
		/// If the node name is not defined, a default node name is created atomically
		/// at each execution of the filter to guarantee uniqueness. GetNodeName()
		/// will return a non-empty name only if you have defined it before.
		/// </summary>
		// Token: 0x06015E7D RID: 89725 RVA: 0x001EE05F File Offset: 0x001EC25F
		public void SetNodeName(uint nodeId, string name)
		{
			vtkSelectionSource.vtkSelectionSource_SetNodeName_111(base.GetCppThis(), nodeId, name);
		}

		// Token: 0x06015E7E RID: 89726
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetNodeName_112(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the node name.
		///
		/// If you want to set the Expression, be sure to define the node names.
		///
		/// If the node name is not defined, a default node name is created atomically
		/// at each execution of the filter to guarantee uniqueness. GetNodeName()
		/// will return a non-empty name only if you have defined it before.
		/// </summary>
		// Token: 0x06015E7F RID: 89727 RVA: 0x001EE070 File Offset: 0x001EC270
		public void SetNodeName(string name)
		{
			vtkSelectionSource.vtkSelectionSource_SetNodeName_112(base.GetCppThis(), name);
		}

		// Token: 0x06015E80 RID: 89728
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetNumberOfLayers_113(HandleRef pThis, uint nodeId, int numberOfLayers);

		/// <summary>
		/// Set/Get the number of layers to extract connected to the selected elements.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x06015E81 RID: 89729 RVA: 0x001EE080 File Offset: 0x001EC280
		public void SetNumberOfLayers(uint nodeId, int numberOfLayers)
		{
			vtkSelectionSource.vtkSelectionSource_SetNumberOfLayers_113(base.GetCppThis(), nodeId, numberOfLayers);
		}

		// Token: 0x06015E82 RID: 89730
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetNumberOfLayers_114(HandleRef pThis, int numberOfLayers);

		/// <summary>
		/// Set/Get the number of layers to extract connected to the selected elements.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x06015E83 RID: 89731 RVA: 0x001EE091 File Offset: 0x001EC291
		public void SetNumberOfLayers(int numberOfLayers)
		{
			vtkSelectionSource.vtkSelectionSource_SetNumberOfLayers_114(base.GetCppThis(), numberOfLayers);
		}

		// Token: 0x06015E84 RID: 89732
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetNumberOfNodes_115(HandleRef pThis, uint numberOfNodes);

		/// <summary>
		/// Set/Get the number of nodes that will be created for the generated selection.
		///
		/// The default is 1.
		/// </summary>
		// Token: 0x06015E85 RID: 89733 RVA: 0x001EE0A1 File Offset: 0x001EC2A1
		public void SetNumberOfNodes(uint numberOfNodes)
		{
			vtkSelectionSource.vtkSelectionSource_SetNumberOfNodes_115(base.GetCppThis(), numberOfNodes);
		}

		// Token: 0x06015E86 RID: 89734
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetProcessID_116(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get which process to limit the selection to. `-1` is treated as
		/// all processes.
		///
		/// The default is -1.
		/// </summary>
		// Token: 0x06015E87 RID: 89735 RVA: 0x001EE0B1 File Offset: 0x001EC2B1
		public virtual void SetProcessID(int _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetProcessID_116(base.GetCppThis(), _arg);
		}

		// Token: 0x06015E88 RID: 89736
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetQueryString_117(HandleRef pThis, uint nodeId, [MarshalAs(UnmanagedType.LPUTF8Str)] string queryString);

		/// <summary>
		/// Set/Get the query expression string.
		/// </summary>
		// Token: 0x06015E89 RID: 89737 RVA: 0x001EE0C1 File Offset: 0x001EC2C1
		public void SetQueryString(uint nodeId, string queryString)
		{
			vtkSelectionSource.vtkSelectionSource_SetQueryString_117(base.GetCppThis(), nodeId, queryString);
		}

		// Token: 0x06015E8A RID: 89738
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetQueryString_118(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string query);

		/// <summary>
		/// Set/Get the query expression string.
		/// </summary>
		// Token: 0x06015E8B RID: 89739 RVA: 0x001EE0D2 File Offset: 0x001EC2D2
		public void SetQueryString(string query)
		{
			vtkSelectionSource.vtkSelectionSource_SetQueryString_118(base.GetCppThis(), query);
		}

		// Token: 0x06015E8C RID: 89740
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetRemoveIntermediateLayers_119(HandleRef pThis, uint nodeId, byte RemoveIntermediateLayers);

		/// <summary>
		/// Set/Get the number of layers related flag to remove intermediate layers
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06015E8D RID: 89741 RVA: 0x001EE0E2 File Offset: 0x001EC2E2
		public void SetRemoveIntermediateLayers(uint nodeId, bool RemoveIntermediateLayers)
		{
			vtkSelectionSource.vtkSelectionSource_SetRemoveIntermediateLayers_119(base.GetCppThis(), nodeId, RemoveIntermediateLayers ? (byte)1 : (byte)0);
		}

		// Token: 0x06015E8E RID: 89742
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetRemoveIntermediateLayers_120(HandleRef pThis, byte RemoveIntermediateLayers);

		/// <summary>
		/// Set/Get the number of layers related flag to remove intermediate layers
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06015E8F RID: 89743 RVA: 0x001EE0FB File Offset: 0x001EC2FB
		public void SetRemoveIntermediateLayers(bool RemoveIntermediateLayers)
		{
			vtkSelectionSource.vtkSelectionSource_SetRemoveIntermediateLayers_120(base.GetCppThis(), RemoveIntermediateLayers ? (byte)1 : (byte)0);
		}

		// Token: 0x06015E90 RID: 89744
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetRemoveSeed_121(HandleRef pThis, uint nodeId, byte RemoveSeed);

		/// <summary>
		/// Set/Get the number of layers related flag to remove seed selection
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06015E91 RID: 89745 RVA: 0x001EE113 File Offset: 0x001EC313
		public void SetRemoveSeed(uint nodeId, bool RemoveSeed)
		{
			vtkSelectionSource.vtkSelectionSource_SetRemoveSeed_121(base.GetCppThis(), nodeId, RemoveSeed ? (byte)1 : (byte)0);
		}

		// Token: 0x06015E92 RID: 89746
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionSource_SetRemoveSeed_122(HandleRef pThis, byte RemoveSeed);

		/// <summary>
		/// Set/Get the number of layers related flag to remove seed selection
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06015E93 RID: 89747 RVA: 0x001EE12C File Offset: 0x001EC32C
		public void SetRemoveSeed(bool RemoveSeed)
		{
			vtkSelectionSource.vtkSelectionSource_SetRemoveSeed_122(base.GetCppThis(), RemoveSeed ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018D5 RID: 6357
		public new const string MRFullTypeName = "Kitware.VTK.vtkSelectionSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018D6 RID: 6358
		public new static readonly string MRClassNameKey = "class vtkSelectionSource";

		/// <summary>
		/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
		///
		/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
		/// vtkSelectionNode::SelectionField.
		///
		/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
		/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
		/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
		/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
		///
		/// The default is FIELD_TYPE.
		/// </summary>
		// Token: 0x02000842 RID: 2114
		public enum FieldTypeOptions
		{
			/// <summary>enum member</summary>
			// Token: 0x040018D8 RID: 6360
			ELEMENT_TYPE = 1,
			/// <summary>enum member</summary>
			// Token: 0x040018D9 RID: 6361
			FIELD_TYPE = 0
		}
	}
}
