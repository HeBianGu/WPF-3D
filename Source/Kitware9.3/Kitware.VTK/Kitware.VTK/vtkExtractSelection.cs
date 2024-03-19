using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractSelection
	/// </summary>
	/// <remarks>
	///    extract a subset from a vtkDataSet.
	///
	/// vtkExtractSelection extracts some subset of cells and points from
	/// its input dataobject. The dataobject is given on its first input port.
	/// The subset is described by the contents of the vtkSelection on its
	/// second input port.  Depending on the contents of the vtkSelection
	/// this will create various vtkSelectors to identify the
	/// selected elements.
	///
	/// This filter supports vtkCompositeDataSet (output is vtkMultiBlockDataSet),
	/// vtkTable and vtkDataSet (output is vtkUnstructuredGrid).
	/// Other types of input are not processed and the corresponding output is a
	/// default constructed object of the input type.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSelection vtkSelector vtkSelectionNode
	/// </seealso>
	// Token: 0x020006B8 RID: 1720
	public class vtkExtractSelection : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601257B RID: 75131 RVA: 0x0019B693 File Offset: 0x00199893
		static vtkExtractSelection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601257C RID: 75132 RVA: 0x0019B6BB File Offset: 0x001998BB
		public vtkExtractSelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601257D RID: 75133
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601257E RID: 75134 RVA: 0x0019B6CC File Offset: 0x001998CC
		public new static vtkExtractSelection New()
		{
			vtkExtractSelection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelection.vtkExtractSelection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601257F RID: 75135 RVA: 0x0019B720 File Offset: 0x00199920
		public vtkExtractSelection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractSelection.vtkExtractSelection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012580 RID: 75136 RVA: 0x0019B764 File Offset: 0x00199964
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012581 RID: 75137
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractSelection_GetHyperTreeGridToUnstructuredGrid_01(HandleRef pThis);

		/// <summary>
		/// Set/Get a flag controlling whether to output an Unstructured Grid (true) or an HyperTreeGrid
		/// (false) when input is a HyperTreeGrid
		///
		/// Default is set to false
		/// </summary>
		// Token: 0x06012582 RID: 75138 RVA: 0x0019B770 File Offset: 0x00199970
		public virtual bool GetHyperTreeGridToUnstructuredGrid()
		{
			return vtkExtractSelection.vtkExtractSelection_GetHyperTreeGridToUnstructuredGrid_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06012583 RID: 75139
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelection_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012584 RID: 75140 RVA: 0x0019B798 File Offset: 0x00199998
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSelection.vtkExtractSelection_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012585 RID: 75141
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelection_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012586 RID: 75142 RVA: 0x0019B7B8 File Offset: 0x001999B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSelection.vtkExtractSelection_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06012587 RID: 75143
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractSelection_GetPreserveTopology_04(HandleRef pThis);

		/// <summary>
		/// This flag tells the extraction filter not to extract a subset of the
		/// data, but instead to produce a vtkInsidedness array and add it to the
		/// input dataset. Default value is false(0).
		/// </summary>
		// Token: 0x06012588 RID: 75144 RVA: 0x0019B7D4 File Offset: 0x001999D4
		public virtual bool GetPreserveTopology()
		{
			return vtkExtractSelection.vtkExtractSelection_GetPreserveTopology_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06012589 RID: 75145
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelection_HyperTreeGridToUnstructuredGridOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get a flag controlling whether to output an Unstructured Grid (true) or an HyperTreeGrid
		/// (false) when input is a HyperTreeGrid
		///
		/// Default is set to false
		/// </summary>
		// Token: 0x0601258A RID: 75146 RVA: 0x0019B7FA File Offset: 0x001999FA
		public virtual void HyperTreeGridToUnstructuredGridOff()
		{
			vtkExtractSelection.vtkExtractSelection_HyperTreeGridToUnstructuredGridOff_05(base.GetCppThis());
		}

		// Token: 0x0601258B RID: 75147
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelection_HyperTreeGridToUnstructuredGridOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get a flag controlling whether to output an Unstructured Grid (true) or an HyperTreeGrid
		/// (false) when input is a HyperTreeGrid
		///
		/// Default is set to false
		/// </summary>
		// Token: 0x0601258C RID: 75148 RVA: 0x0019B809 File Offset: 0x00199A09
		public virtual void HyperTreeGridToUnstructuredGridOn()
		{
			vtkExtractSelection.vtkExtractSelection_HyperTreeGridToUnstructuredGridOn_06(base.GetCppThis());
		}

		// Token: 0x0601258D RID: 75149
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelection_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601258E RID: 75150 RVA: 0x0019B818 File Offset: 0x00199A18
		public override int IsA(string type)
		{
			return vtkExtractSelection.vtkExtractSelection_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601258F RID: 75151
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelection_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012590 RID: 75152 RVA: 0x0019B838 File Offset: 0x00199A38
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelection.vtkExtractSelection_IsTypeOf_08(type);
		}

		// Token: 0x06012591 RID: 75153
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelection_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012592 RID: 75154 RVA: 0x0019B854 File Offset: 0x00199A54
		public new vtkExtractSelection NewInstance()
		{
			vtkExtractSelection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelection.vtkExtractSelection_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012593 RID: 75155
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelection_PreserveTopologyOff_11(HandleRef pThis);

		/// <summary>
		/// This flag tells the extraction filter not to extract a subset of the
		/// data, but instead to produce a vtkInsidedness array and add it to the
		/// input dataset. Default value is false(0).
		/// </summary>
		// Token: 0x06012594 RID: 75156 RVA: 0x0019B8AE File Offset: 0x00199AAE
		public virtual void PreserveTopologyOff()
		{
			vtkExtractSelection.vtkExtractSelection_PreserveTopologyOff_11(base.GetCppThis());
		}

		// Token: 0x06012595 RID: 75157
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelection_PreserveTopologyOn_12(HandleRef pThis);

		/// <summary>
		/// This flag tells the extraction filter not to extract a subset of the
		/// data, but instead to produce a vtkInsidedness array and add it to the
		/// input dataset. Default value is false(0).
		/// </summary>
		// Token: 0x06012596 RID: 75158 RVA: 0x0019B8BD File Offset: 0x00199ABD
		public virtual void PreserveTopologyOn()
		{
			vtkExtractSelection.vtkExtractSelection_PreserveTopologyOn_12(base.GetCppThis());
		}

		// Token: 0x06012597 RID: 75159
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelection_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012598 RID: 75160 RVA: 0x0019B8CC File Offset: 0x00199ACC
		public new static vtkExtractSelection SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelection vtkExtractSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelection.vtkExtractSelection_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelection = (vtkExtractSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelection.Register(null);
				}
			}
			return vtkExtractSelection;
		}

		// Token: 0x06012599 RID: 75161
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelection_SetHyperTreeGridToUnstructuredGrid_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get a flag controlling whether to output an Unstructured Grid (true) or an HyperTreeGrid
		/// (false) when input is a HyperTreeGrid
		///
		/// Default is set to false
		/// </summary>
		// Token: 0x0601259A RID: 75162 RVA: 0x0019B94B File Offset: 0x00199B4B
		public virtual void SetHyperTreeGridToUnstructuredGrid(bool _arg)
		{
			vtkExtractSelection.vtkExtractSelection_SetHyperTreeGridToUnstructuredGrid_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601259B RID: 75163
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelection_SetPreserveTopology_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// This flag tells the extraction filter not to extract a subset of the
		/// data, but instead to produce a vtkInsidedness array and add it to the
		/// input dataset. Default value is false(0).
		/// </summary>
		// Token: 0x0601259C RID: 75164 RVA: 0x0019B963 File Offset: 0x00199B63
		public virtual void SetPreserveTopology(bool _arg)
		{
			vtkExtractSelection.vtkExtractSelection_SetPreserveTopology_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601259D RID: 75165
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelection_SetSelectionConnection_16(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Convenience method to specify the selection connection (2nd input
		/// port)
		/// </summary>
		// Token: 0x0601259E RID: 75166 RVA: 0x0019B97C File Offset: 0x00199B7C
		public void SetSelectionConnection(vtkAlgorithmOutput algOutput)
		{
			vtkExtractSelection.vtkExtractSelection_SetSelectionConnection_16(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400151E RID: 5406
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400151F RID: 5407
		public new static readonly string MRClassNameKey = "class vtkExtractSelection";
	}
}
