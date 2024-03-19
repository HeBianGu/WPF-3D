using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkSelectionNode
	/// </summary>
	/// <remarks>
	///  a node in a vtkSelection the defines the selection criteria.
	///
	/// vtkSelectionNode helps define the selection criteria in a vtkSelection.
	/// vtkSelection can comprise of multiple such vtkSelectionNode instances that
	/// help define the selection.
	///
	/// vtkSelectionNode has two components: a list of properties (stored in a
	/// vtkInformation) and a selection list (a vtkAbstractArray subclass). The
	/// properties help indicate how to interpret the values specified in a
	/// selection-list.
	///
	/// The properties can be broadly classified into three categories: core,
	/// qualifiers, and information. The core properties must be specified other wise the
	/// vtkSelectionNode is not considered valid. These are `FIELD_TYPE` and
	/// `CONTENT_TYPE`. `FIELD_TYPE` defines what kinds of entities are being selected.
	/// Since selections are used to select items in a data-object, these correspond to
	/// things like cells, points, nodes, edges, rows, etc. Supported FIELD_TYPE
	/// values are defined in `vtkSelectionNode::SelectionField`. `CONTENT_TYPE`
	/// defines the how the selection is described. Supported values are
	/// `vtkSelectionNode::SelectionContent`. For example, if CONTENT_TYPE is
	/// `INDICES`, then selection is described as ids for entities being selected.
	/// The ids themselves will be specified using the selection list. Thus, the
	/// CONTENT_TYPE dictates what the selection list comprises.
	///
	/// Qualifiers are used to further qualify the selection criteria. All qualifiers
	/// are optional. When present they restrict the selection. For example, when
	/// selecting elements from a composite-dataset, the `COMPOSITE_INDEX` qualifier
	/// can be specified of limit the selection to a specific dataset (or subtree).
	///
	/// Information properties are simply for informative purposes and generally used
	/// to provide information about the selection when the selection is created. For
	/// example, `PIXEL_COUNT` is used to indicate how many screen pixels resulted in
	/// creation of this selection node.
	///
	/// @section SelectionTypes Selection Types
	///
	/// `CONTENT_TYPE` property is one of the required properties that helps
	/// describe how the selection is defined. To set the content type, one can
	/// access the properties store using `vtkSelectionNode::GetProperties()` and
	/// then set the `CONTENT_TYPE` using the `vtkSelectionNode::CONTENT_TYPE()` key
	/// or simply use `vtkSelectionNode::SetContentType`.
	///
	/// * `vtkSelectionNode::GLOBALIDS`: indicates that the selection is defined
	///   using global ids. In VTK data-object, global ids are specified an `vtkIdTypeArray`
	///   added to a appropriate `vtkDataSetAttributes` and marked as global-ids
	///   using vtkDataSetAttributes API. Since global ids are expected to be unique
	///   for that element type over the entire dataset, it's a convenient way of
	///   defining selections. For this content-type, the selection list must be
	///   a single-component, `vtkIdTypeArray` that lists all the globals ids for
	///   the selected elements.
	///
	/// * `vtkSelectionNode::PEDIGREEIDS`: similar to `GLOBALIDS` except uses
	///   pedigree ids instead of global ids.
	///
	/// * `vtkSelectionNode::VALUES`: this type is used to define a selection based
	///   on array values. The selection list specifies the values to be selected.
	///   All elements with array values in the selection list are treated as
	///   selected. The qualifier COMPONENT_NUMBER is used to indicate which
	///   component to use for the checks. Use `-1` for magnitude. Current
	///   implementation does not support checking multiple-components or non-exact
	///   matches although support for both is conceivable in future.
	///   The selection list array name is used to specify the name of the array from
	///   the dataset to use for the checks. Thus, for defining a selection for a
	///   dataset where all `TEMP` values match those specified in the selection
	///   list, ensure that the selection list array's name is set to `TEMP` as well.
	///
	/// * `vtkSelectionNode::INDICES`: this is similar to global ids except in this
	///   case the selection list is simply the VTK element id which is 0-based
	///   index of that element in the particular dataset. Often with this type of
	///   selection, additional qualifiers such as `COMPOSITE_INDEX`,
	///   `BLOCK_SELECTORS`, `PROCESS_ID` etc. are needed to correctly identify the
	///   chosen element(s) in case of composite or distributed datasets.
	///
	/// * `vtkSelectionNode::FRUSTUM`: this type is used to define a frustum in world
	///   coordinates that identifies the selected elements. In this case, the
	///   selection list is a vtkDoubleArray with 32 values specifying the 8 frustum
	///   corners in homogeneous world coordinates.
	///
	/// * `vtkSelectionNode::LOCATIONS`: this is used to select points (or cells)
	///   near (or containing) specified locations. The selection list is a
	///   3-component vtkDoubleArray with coordinates for locations of interest.
	///
	/// * `vtkSelectionNode::THRESHOLDS`: this type is used to define a selection based
	///   on array value ranges. This is akin to thresholding. All elements with values in
	///   the specified ranges are to be treated as selected. For this content-type,
	///   the selection-list is a 2-component `vtkDataArray`-subclass that specifies
	///   where each tuple defines the min and max values for a range. The selection
	///   list can have multiple tuples to define multiple ranges. Elements with
	///   values in any of the specified ranges are treated as selected. The
	///   selection list array name is used to specify the name of the array from
	///   the dataset to use for the checks. Thus, for defining a selection for a
	///   dataset where all `TEMP` values are within a range, ensure that the
	///   selection list array's name is set to `TEMP` as well.
	///
	/// * `vtkSelectionNode::BLOCKS`: this type is used to select blocks in a
	///   composite dataset. The term blocks is used loosely here and can correspond
	///   to a block in a multiblock dataset or a partition in a partitioned-dataset.
	///   The selection list is an integral type vtkDataArray subclass that can be 1-
	///   or 2- component. If 1-component, it's interpreted as the composite-index
	///   (also called flat index) and can be applied to any composite-dataset to
	///   choose specific datasets. If 2-component, it's typically associated with
	///   vtkUniformGridAMR or vtkPartitionedDataSetCollection which support 2-tuple
	///   indexing to locate a dataset.
	///
	/// * `vtkSelectionNode::BLOCK_SELECTORS`: this is similar to BLOCKS, however
	///   instead of using indices to select datasets, here, the selection list is a
	///   vtkStringArray which lists selector expressions to select blocks in the
	///   composite dataset. By default, the selector expressions are applied to a
	///   vtkDataAssembly generated from the composite dataset that represents its
	///   hierarchy (see `vtkDataAssembly::GenerateHierarchy`). However, in case of
	///   vtkPartitionedDataSetCollection, one can select any other data assembly
	///   associated with the vtkPartitionedDataSetCollection by naming the array
	///   with the name of the assembly.
	///
	///   @note, currently vtkPartitionedDataSetCollection only supports a single
	///   vtkDataAssembly but this may change in the future.
	///
	/// * `vtkSelectionNode::QUERY`: this type is primarily added for ParaView where
	///   selection expression is specified as a query string. This is likely to
	///   change in the future and hence applications are discouraged from using this
	///   type.
	///
	/// @section Properties Properties
	///
	/// Following a properties that can be used to qualify the selection.
	///
	/// * `vtkSelectionNode::EPSILON()`: this is a qualifier that can be used to
	///   indicate a fuzz-factor when comparing values for equality. Currently, this
	///   is only used with content-type LOCATIONS, however, it can be expanded to
	///   other selection types in the future.
	///
	/// * `vtkSelectionNode::CONTAINING_CELLS()`: this qualifier is intended to be
	///   used with field-type `POINT`. When present, it indicates that while the
	///   selection criteria selects a collection of points the selection should be
	///   formed using cell containing the chosen points.
	///
	/// * `vtkSelectionNode::CONNECTED_LAYERS()`: a qualifier used to expand the
	///   definition of selected elements to connected elements for the specified
	///   number of layers. Layers can only be positive to grow the selection.
	///
	/// * `vtkSelectionNode::CONNECTED_LAYERS_REMOVE_SEED()`: this qualifier indicates
	///   that when using a number of CONNECTED_LAYERS &gt;= 1, the initial selection will
	///   not be kept.
	///
	/// * `vtkSelectionNode::CONNECTED_LAYERS_REMOVE_INTERMEDIATE_LAYERS()`: this qualifier
	///   indicates that when using a number of CONNECTED_LAYERS &gt;= 2, the intermediate layers
	///   will not be kept.
	///
	/// * `vtkSelectionNode::INVERSE()`: a qualifier that causes the selection to be
	///   inverted i.e. all elements not chosen by the criteria are to be treated
	///   as selected.
	///
	/// * `vtkSelectionNode::COMPONENT_NUMBER()`: for VALUES and THRESHOLDS selection
	///   types, this qualifier identifies the array component of interest. -1
	///   indicates magnitude.
	///
	/// * `vtkSelectionNode::PROCESS_ID()`: limits the selection to a particular
	///   rank in a distributed environment.
	///
	/// * `vtkSelectionNode::COMPOSITE_INDEX()`: a qualifier used to limit the
	///   selection to a specific composite index for a composite-dataset.
	///
	/// * `vtkSelectionNode::ASSEMBLY_NAME()`, `vtkSelectionNode::SELECTORS()`:
	///   similar to composite index, except uses data-assembly and selectors to
	///   limit the selection to a subset of nodes in a composite-dataset.
	///
	/// * `vtkSelectionNode::HIERARCHICAL_LEVEL()`,
	///   `vtkSelectionNode::HIERARCHICAL_INDEX()`: similar to composite index, except
	///   uses level and index for an AMR dataset so limit the selection to a
	///   specific AMR level or dataset.
	///
	/// Following for properties that are primarily intended to provide additional
	/// information when the selection is created.
	///
	/// * `vtkSelectionNode::ZBUFFER_VALUE()`: an information qualifier representing
	///   the z-depth for a particular selection when it was created.
	///
	/// * `vtkSelectionNode::PIXEL_COUNT()`: a qualifier used to provide a count for
	///   the number of pixels that resulted in this selection.
	///
	/// * `vtkSelectionNode::SOURCE()`, `vtkSelectionNode::SOURCE_ID()`: provides
	///   information about data producer or selection originator. The interpretation
	///   is very specific to the creator creating the selection and varies greatly
	///   with VTK.
	///
	/// * `vtkSelectionNode::PROP(), `vtkSelectionNode::PROP_ID()`: similar to
	///   SOURCE/SOURCE_ID except is used to represent a rendering prop from which
	///   the selection was created.
	///
	/// @warning
	/// No SelectionList is created by default. It should be assigned.
	///
	/// @section SelectionFieldMismatch vtkSelectionNode::SelectionField and
	/// vtkDataSetAttribute::AttributeTypes
	///
	/// Strictly speaking, vtkSelectionNode::SelectionField maps directly to
	/// vtkDataSetAttribute::AttributeTypes. However, the two enum values are not
	/// identical for historical reasons. Use
	/// `vtkSelectionNode::ConvertSelectionFieldToAttributeType` and
	/// `vtkSelectionNode::ConvertAttributeTypeToSelectionField` to convert between
	/// the two.
	/// </remarks>
	// Token: 0x02000ABC RID: 2748
	public class vtkSelectionNode : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CEEE RID: 118510 RVA: 0x0028C39B File Offset: 0x0028A59B
		static vtkSelectionNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSelectionNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectionNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CEEF RID: 118511 RVA: 0x0028C3C3 File Offset: 0x0028A5C3
		public vtkSelectionNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CEF0 RID: 118512
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CEF1 RID: 118513 RVA: 0x0028C3D4 File Offset: 0x0028A5D4
		public new static vtkSelectionNode New()
		{
			vtkSelectionNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectionNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CEF2 RID: 118514 RVA: 0x0028C428 File Offset: 0x0028A628
		public vtkSelectionNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSelectionNode.vtkSelectionNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CEF3 RID: 118515 RVA: 0x0028C46C File Offset: 0x0028A66C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CEF4 RID: 118516
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_ASSEMBLY_NAME_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Keys for selector-based identification of
		/// blocks to choose from a composite dataset. `ASSEMBLY_NAME` identifies the
		/// name for the assembly to use and `SELECTORS` provide a list of node
		/// selectors applied to the chosen assembly.
		///
		/// Use `vtkDataAssemblyUtilities::HierarchyName` as the assembly name
		/// to use the data hierarchy
		/// </summary>
		// Token: 0x0601CEF5 RID: 118517 RVA: 0x0028C478 File Offset: 0x0028A678
		public static vtkInformationStringKey ASSEMBLY_NAME()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_ASSEMBLY_NAME_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		// Token: 0x0601CEF6 RID: 118518
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_COMPONENT_NUMBER_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When ContentType==THRESHOLDS  or ContentType==VALUES
		/// i.e. threshold and value based selections, it is
		/// possible pick the component number using this key. If none is specified,
		/// the 0th component is used. If any number less than 0 is specified, then
		/// the magnitude is used.
		/// </summary>
		// Token: 0x0601CEF7 RID: 118519 RVA: 0x0028C4E4 File Offset: 0x0028A6E4
		public static vtkInformationIntegerKey COMPONENT_NUMBER()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_COMPONENT_NUMBER_02(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CEF8 RID: 118520
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_COMPOSITE_INDEX_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Used to identify a node in composite datasets.
		/// </summary>
		// Token: 0x0601CEF9 RID: 118521 RVA: 0x0028C550 File Offset: 0x0028A750
		public static vtkInformationIntegerKey COMPOSITE_INDEX()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_COMPOSITE_INDEX_03(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CEFA RID: 118522
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_CONNECTED_LAYERS_04(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When specified, this indicates how many layers of *connected* elements
		/// in addition to those chosen explicitly are being selected. Currently,
		/// this is only supported for cells and points.
		/// </summary>
		// Token: 0x0601CEFB RID: 118523 RVA: 0x0028C5BC File Offset: 0x0028A7BC
		public static vtkInformationIntegerKey CONNECTED_LAYERS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_CONNECTED_LAYERS_04(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CEFC RID: 118524
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_CONNECTED_LAYERS_REMOVE_INTERMEDIATE_LAYERS_05(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When specified and also using CONNECTED_LAYERS(), this indicates
		/// if the intermediate layers should be kept or not.
		/// </summary>
		// Token: 0x0601CEFD RID: 118525 RVA: 0x0028C628 File Offset: 0x0028A828
		public static vtkInformationIntegerKey CONNECTED_LAYERS_REMOVE_INTERMEDIATE_LAYERS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_CONNECTED_LAYERS_REMOVE_INTERMEDIATE_LAYERS_05(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CEFE RID: 118526
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_CONNECTED_LAYERS_REMOVE_SEED_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When specified and also using CONNECTED_LAYERS(), this indicates
		/// if the initial selection should be kept or not.
		/// </summary>
		// Token: 0x0601CEFF RID: 118527 RVA: 0x0028C694 File Offset: 0x0028A894
		public static vtkInformationIntegerKey CONNECTED_LAYERS_REMOVE_SEED()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_CONNECTED_LAYERS_REMOVE_SEED_06(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CF00 RID: 118528
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_CONTAINING_CELLS_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This flag tells the extraction filter, when FIELD_TYPE==POINT, that
		/// it should also extract the cells that contain any of the extracted points.
		/// </summary>
		// Token: 0x0601CF01 RID: 118529 RVA: 0x0028C700 File Offset: 0x0028A900
		public static vtkInformationIntegerKey CONTAINING_CELLS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_CONTAINING_CELLS_07(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CF02 RID: 118530
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_CONTENT_TYPE_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the (primary) property that describes the content of a selection
		/// node's data. This key takes on values from the SelectionContent enum.
		/// GetContentType() returns -1 if the content type is not set.
		///
		/// \sa vtkSelectionNode::SelectionContent
		/// </summary>
		// Token: 0x0601CF03 RID: 118531 RVA: 0x0028C76C File Offset: 0x0028A96C
		public static vtkInformationIntegerKey CONTENT_TYPE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_CONTENT_TYPE_08(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CF04 RID: 118532
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionNode_ConvertAttributeTypeToSelectionField_09(int val);

		/// <summary>
		/// Methods to convert vtkSelectionNode::SelectionField to
		/// vtkDataSetAttribute::AttributeTypes and vice-versa.
		/// </summary>
		// Token: 0x0601CF05 RID: 118533 RVA: 0x0028C7D8 File Offset: 0x0028A9D8
		public static int ConvertAttributeTypeToSelectionField(int val)
		{
			return vtkSelectionNode.vtkSelectionNode_ConvertAttributeTypeToSelectionField_09(val);
		}

		// Token: 0x0601CF06 RID: 118534
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionNode_ConvertSelectionFieldToAttributeType_10(int val);

		/// <summary>
		/// Methods to convert vtkSelectionNode::SelectionField to
		/// vtkDataSetAttribute::AttributeTypes and vice-versa.
		/// </summary>
		// Token: 0x0601CF07 RID: 118535 RVA: 0x0028C7F4 File Offset: 0x0028A9F4
		public static int ConvertSelectionFieldToAttributeType(int val)
		{
			return vtkSelectionNode.vtkSelectionNode_ConvertSelectionFieldToAttributeType_10(val);
		}

		// Token: 0x0601CF08 RID: 118536
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionNode_DeepCopy_11(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Copy properties, selection list and children of the input.
		/// </summary>
		// Token: 0x0601CF09 RID: 118537 RVA: 0x0028C810 File Offset: 0x0028AA10
		public virtual void DeepCopy(vtkSelectionNode src)
		{
			vtkSelectionNode.vtkSelectionNode_DeepCopy_11(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601CF0A RID: 118538
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_EPSILON_12(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// For location selection of points, if distance is greater than this reject.
		/// </summary>
		// Token: 0x0601CF0B RID: 118539 RVA: 0x0028C840 File Offset: 0x0028AA40
		public static vtkInformationDoubleKey EPSILON()
		{
			vtkInformationDoubleKey vtkInformationDoubleKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_EPSILON_12(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleKey = (vtkInformationDoubleKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleKey.Register(null);
				}
			}
			return vtkInformationDoubleKey;
		}

		// Token: 0x0601CF0C RID: 118540
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSelectionNode_EqualProperties_13(HandleRef pThis, HandleRef other, byte fullcompare);

		/// <summary>
		/// Compares Properties of self and other to ensure that they are exactly same.
		/// </summary>
		// Token: 0x0601CF0D RID: 118541 RVA: 0x0028C8AC File Offset: 0x0028AAAC
		public bool EqualProperties(vtkSelectionNode other, bool fullcompare)
		{
			return vtkSelectionNode.vtkSelectionNode_EqualProperties_13(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis(), fullcompare ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x0601CF0E RID: 118542
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_FIELD_TYPE_14(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Controls whether cell, point, or field data determine what is inside and out.
		/// The default is CELL.
		/// Vertex and edge types are also available for graph classes.
		/// GetFieldType() returns -1 if the field type is not set.
		/// </summary>
		// Token: 0x0601CF0F RID: 118543 RVA: 0x0028C8F0 File Offset: 0x0028AAF0
		public static vtkInformationIntegerKey FIELD_TYPE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_FIELD_TYPE_14(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CF10 RID: 118544
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionNode_GetContentType_15(HandleRef pThis);

		/// <summary>
		/// Get or set the content type of the selection.
		/// This is the same as setting the CONTENT_TYPE() key on the property.
		/// </summary>
		// Token: 0x0601CF11 RID: 118545 RVA: 0x0028C95C File Offset: 0x0028AB5C
		public virtual int GetContentType()
		{
			return vtkSelectionNode.vtkSelectionNode_GetContentType_15(base.GetCppThis());
		}

		// Token: 0x0601CF12 RID: 118546
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_GetContentTypeAsString_16(int type);

		/// <summary>
		/// Get the content type as a string.
		/// </summary>
		// Token: 0x0601CF13 RID: 118547 RVA: 0x0028C97C File Offset: 0x0028AB7C
		public static string GetContentTypeAsString(int type)
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectionNode.vtkSelectionNode_GetContentTypeAsString_16(type));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601CF14 RID: 118548
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionNode_GetFieldType_17(HandleRef pThis);

		/// <summary>
		/// Get or set the field type of the selection.
		/// This is the same as setting the FIELD_TYPE() key on the property.
		/// </summary>
		// Token: 0x0601CF15 RID: 118549 RVA: 0x0028C9B4 File Offset: 0x0028ABB4
		public virtual int GetFieldType()
		{
			return vtkSelectionNode.vtkSelectionNode_GetFieldType_17(base.GetCppThis());
		}

		// Token: 0x0601CF16 RID: 118550
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_GetFieldTypeAsString_18(int type);

		/// <summary>
		/// Get the field type as a string.
		/// </summary>
		// Token: 0x0601CF17 RID: 118551 RVA: 0x0028C9D4 File Offset: 0x0028ABD4
		public static string GetFieldTypeAsString(int type)
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectionNode.vtkSelectionNode_GetFieldTypeAsString_18(type));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601CF18 RID: 118552
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionNode_GetFieldTypeFromString_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Get field type from string. Returns NUM_FIELD_TYPES if not found.
		/// </summary>
		// Token: 0x0601CF19 RID: 118553 RVA: 0x0028CA0C File Offset: 0x0028AC0C
		public static int GetFieldTypeFromString(string type)
		{
			return vtkSelectionNode.vtkSelectionNode_GetFieldTypeFromString_19(type);
		}

		// Token: 0x0601CF1A RID: 118554
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSelectionNode_GetMTime_20(HandleRef pThis);

		/// <summary>
		/// Return the MTime taking into account changes to the properties
		/// </summary>
		// Token: 0x0601CF1B RID: 118555 RVA: 0x0028CA28 File Offset: 0x0028AC28
		public override ulong GetMTime()
		{
			return vtkSelectionNode.vtkSelectionNode_GetMTime_20(base.GetCppThis());
		}

		// Token: 0x0601CF1C RID: 118556
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelectionNode_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF1D RID: 118557 RVA: 0x0028CA48 File Offset: 0x0028AC48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSelectionNode.vtkSelectionNode_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x0601CF1E RID: 118558
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelectionNode_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF1F RID: 118559 RVA: 0x0028CA68 File Offset: 0x0028AC68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSelectionNode.vtkSelectionNode_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x0601CF20 RID: 118560
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_GetProperties_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the property map.
		/// </summary>
		// Token: 0x0601CF21 RID: 118561 RVA: 0x0028CA84 File Offset: 0x0028AC84
		public virtual vtkInformation GetProperties()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_GetProperties_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x0601CF22 RID: 118562
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_GetQueryString_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the query expression string.
		/// </summary>
		// Token: 0x0601CF23 RID: 118563 RVA: 0x0028CAF4 File Offset: 0x0028ACF4
		public virtual string GetQueryString()
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectionNode.vtkSelectionNode_GetQueryString_24(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601CF24 RID: 118564
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_GetSelectionData_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Sets the selection table.
		/// </summary>
		// Token: 0x0601CF25 RID: 118565 RVA: 0x0028CB30 File Offset: 0x0028AD30
		public virtual vtkDataSetAttributes GetSelectionData()
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_GetSelectionData_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601CF26 RID: 118566
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_GetSelectionList_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the selection list. The selection list is the container
		/// that stores values that indicate the selected items. What these values
		/// correspond to depends on the `ContentType`. `ContentType` may also dictate
		/// the type and form of the selection list array.
		/// </summary>
		// Token: 0x0601CF27 RID: 118567 RVA: 0x0028CBA0 File Offset: 0x0028ADA0
		public virtual vtkAbstractArray GetSelectionList()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_GetSelectionList_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x0601CF28 RID: 118568
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_HIERARCHICAL_INDEX_27(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Used to identify a dataset in a hiererchical box dataset.
		/// </summary>
		// Token: 0x0601CF29 RID: 118569 RVA: 0x0028CC10 File Offset: 0x0028AE10
		public static vtkInformationIntegerKey HIERARCHICAL_INDEX()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_HIERARCHICAL_INDEX_27(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CF2A RID: 118570
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_HIERARCHICAL_LEVEL_28(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Used to identify a dataset in a hiererchical box dataset.
		/// </summary>
		// Token: 0x0601CF2B RID: 118571 RVA: 0x0028CC7C File Offset: 0x0028AE7C
		public static vtkInformationIntegerKey HIERARCHICAL_LEVEL()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_HIERARCHICAL_LEVEL_28(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CF2C RID: 118572
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_INVERSE_29(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This flag tells the extraction filter to exclude the selection.
		/// </summary>
		// Token: 0x0601CF2D RID: 118573 RVA: 0x0028CCE8 File Offset: 0x0028AEE8
		public static vtkInformationIntegerKey INVERSE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_INVERSE_29(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CF2E RID: 118574
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionNode_Initialize_30(HandleRef pThis);

		/// <summary>
		/// Restore data object to initial state,
		/// </summary>
		// Token: 0x0601CF2F RID: 118575 RVA: 0x0028CD51 File Offset: 0x0028AF51
		public virtual void Initialize()
		{
			vtkSelectionNode.vtkSelectionNode_Initialize_30(base.GetCppThis());
		}

		// Token: 0x0601CF30 RID: 118576
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionNode_IsA_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF31 RID: 118577 RVA: 0x0028CD60 File Offset: 0x0028AF60
		public override int IsA(string type)
		{
			return vtkSelectionNode.vtkSelectionNode_IsA_31(base.GetCppThis(), type);
		}

		// Token: 0x0601CF32 RID: 118578
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectionNode_IsTypeOf_32([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF33 RID: 118579 RVA: 0x0028CD80 File Offset: 0x0028AF80
		public new static int IsTypeOf(string type)
		{
			return vtkSelectionNode.vtkSelectionNode_IsTypeOf_32(type);
		}

		// Token: 0x0601CF34 RID: 118580
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF35 RID: 118581 RVA: 0x0028CD9C File Offset: 0x0028AF9C
		public new vtkSelectionNode NewInstance()
		{
			vtkSelectionNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_NewInstance_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectionNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CF36 RID: 118582
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_PIXEL_COUNT_35(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A helper for visible cell selector, this is the number of pixels covered
		/// by the actor whose cells are listed in the selection.
		/// </summary>
		// Token: 0x0601CF37 RID: 118583 RVA: 0x0028CDF8 File Offset: 0x0028AFF8
		public static vtkInformationIntegerKey PIXEL_COUNT()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_PIXEL_COUNT_35(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CF38 RID: 118584
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_PROCESS_ID_36(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Process id the selection is on.
		/// </summary>
		// Token: 0x0601CF39 RID: 118585 RVA: 0x0028CE64 File Offset: 0x0028B064
		public static vtkInformationIntegerKey PROCESS_ID()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_PROCESS_ID_36(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CF3A RID: 118586
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_PROP_37(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Pointer to the prop the selection belongs to.
		/// </summary>
		// Token: 0x0601CF3B RID: 118587 RVA: 0x0028CED0 File Offset: 0x0028B0D0
		public static vtkInformationObjectBaseKey PROP()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_PROP_37(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		// Token: 0x0601CF3C RID: 118588
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_PROP_ID_38(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// ID of the prop the selection belongs to. What
		/// ID means is application specific.
		/// </summary>
		// Token: 0x0601CF3D RID: 118589 RVA: 0x0028CF3C File Offset: 0x0028B13C
		public static vtkInformationIntegerKey PROP_ID()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_PROP_ID_38(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CF3E RID: 118590
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_SELECTORS_39(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Keys for selector-based identification of
		/// blocks to choose from a composite dataset. `ASSEMBLY_NAME` identifies the
		/// name for the assembly to use and `SELECTORS` provide a list of node
		/// selectors applied to the chosen assembly.
		///
		/// Use `vtkDataAssemblyUtilities::HierarchyName` as the assembly name
		/// to use the data hierarchy
		/// </summary>
		// Token: 0x0601CF3F RID: 118591 RVA: 0x0028CFA8 File Offset: 0x0028B1A8
		public static vtkInformationStringVectorKey SELECTORS()
		{
			vtkInformationStringVectorKey vtkInformationStringVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_SELECTORS_39(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringVectorKey = (vtkInformationStringVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringVectorKey.Register(null);
				}
			}
			return vtkInformationStringVectorKey;
		}

		// Token: 0x0601CF40 RID: 118592
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_SOURCE_40(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Pointer to the data or algorithm the selection belongs to.
		/// </summary>
		// Token: 0x0601CF41 RID: 118593 RVA: 0x0028D014 File Offset: 0x0028B214
		public static vtkInformationObjectBaseKey SOURCE()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_SOURCE_40(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		// Token: 0x0601CF42 RID: 118594
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_SOURCE_ID_41(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// ID of the data or algorithm the selection belongs to. What
		/// ID means is application specific.
		/// </summary>
		// Token: 0x0601CF43 RID: 118595 RVA: 0x0028D080 File Offset: 0x0028B280
		public static vtkInformationIntegerKey SOURCE_ID()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_SOURCE_ID_41(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601CF44 RID: 118596
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF45 RID: 118597 RVA: 0x0028D0EC File Offset: 0x0028B2EC
		public new static vtkSelectionNode SafeDownCast(vtkObjectBase o)
		{
			vtkSelectionNode vtkSelectionNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelectionNode = (vtkSelectionNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelectionNode.Register(null);
				}
			}
			return vtkSelectionNode;
		}

		// Token: 0x0601CF46 RID: 118598
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionNode_SetContentType_43(HandleRef pThis, int type);

		/// <summary>
		/// Get or set the content type of the selection.
		/// This is the same as setting the CONTENT_TYPE() key on the property.
		/// </summary>
		// Token: 0x0601CF47 RID: 118599 RVA: 0x0028D16B File Offset: 0x0028B36B
		public virtual void SetContentType(int type)
		{
			vtkSelectionNode.vtkSelectionNode_SetContentType_43(base.GetCppThis(), type);
		}

		// Token: 0x0601CF48 RID: 118600
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionNode_SetFieldType_44(HandleRef pThis, int type);

		/// <summary>
		/// Get or set the field type of the selection.
		/// This is the same as setting the FIELD_TYPE() key on the property.
		/// </summary>
		// Token: 0x0601CF49 RID: 118601 RVA: 0x0028D17B File Offset: 0x0028B37B
		public virtual void SetFieldType(int type)
		{
			vtkSelectionNode.vtkSelectionNode_SetFieldType_44(base.GetCppThis(), type);
		}

		// Token: 0x0601CF4A RID: 118602
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionNode_SetQueryString_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the query expression string.
		/// </summary>
		// Token: 0x0601CF4B RID: 118603 RVA: 0x0028D18B File Offset: 0x0028B38B
		public virtual void SetQueryString(string _arg)
		{
			vtkSelectionNode.vtkSelectionNode_SetQueryString_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0601CF4C RID: 118604
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionNode_SetSelectionData_46(HandleRef pThis, HandleRef data);

		/// <summary>
		/// Sets the selection table.
		/// </summary>
		// Token: 0x0601CF4D RID: 118605 RVA: 0x0028D19C File Offset: 0x0028B39C
		public virtual void SetSelectionData(vtkDataSetAttributes data)
		{
			vtkSelectionNode.vtkSelectionNode_SetSelectionData_46(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x0601CF4E RID: 118606
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionNode_SetSelectionList_47(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the selection list. The selection list is the container
		/// that stores values that indicate the selected items. What these values
		/// correspond to depends on the `ContentType`. `ContentType` may also dictate
		/// the type and form of the selection list array.
		/// </summary>
		// Token: 0x0601CF4F RID: 118607 RVA: 0x0028D1CC File Offset: 0x0028B3CC
		public virtual void SetSelectionList(vtkAbstractArray arg0)
		{
			vtkSelectionNode.vtkSelectionNode_SetSelectionList_47(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601CF50 RID: 118608
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionNode_ShallowCopy_48(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Copy properties, selection list and children of the input.
		/// This is a shallow copy: selection lists and pointers in the
		/// properties are passed by reference.
		/// </summary>
		// Token: 0x0601CF51 RID: 118609 RVA: 0x0028D1FC File Offset: 0x0028B3FC
		public virtual void ShallowCopy(vtkSelectionNode src)
		{
			vtkSelectionNode.vtkSelectionNode_ShallowCopy_48(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601CF52 RID: 118610
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionNode_SubtractSelectionList_49(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Subtracts the items in the selection list, other, from this selection list.
		/// Assumes that both selections have identical properties (i.e., test with EqualProperties
		/// before using).
		/// </summary>
		// Token: 0x0601CF53 RID: 118611 RVA: 0x0028D22C File Offset: 0x0028B42C
		public void SubtractSelectionList(vtkSelectionNode other)
		{
			vtkSelectionNode.vtkSelectionNode_SubtractSelectionList_49(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601CF54 RID: 118612
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectionNode_UnionSelectionList_50(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Merges the selection list between self and the other. Assumes that both has
		/// identical properties.
		/// </summary>
		// Token: 0x0601CF55 RID: 118613 RVA: 0x0028D25C File Offset: 0x0028B45C
		public void UnionSelectionList(vtkSelectionNode other)
		{
			vtkSelectionNode.vtkSelectionNode_UnionSelectionList_50(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601CF56 RID: 118614
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectionNode_ZBUFFER_VALUE_51(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If present, closest zbuffer value of this selection
		/// </summary>
		// Token: 0x0601CF57 RID: 118615 RVA: 0x0028D28C File Offset: 0x0028B48C
		public static vtkInformationDoubleKey ZBUFFER_VALUE()
		{
			vtkInformationDoubleKey vtkInformationDoubleKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectionNode.vtkSelectionNode_ZBUFFER_VALUE_51(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleKey = (vtkInformationDoubleKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleKey.Register(null);
				}
			}
			return vtkInformationDoubleKey;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E83 RID: 7811
		public new const string MRFullTypeName = "Kitware.VTK.vtkSelectionNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E84 RID: 7812
		public new static readonly string MRClassNameKey = "class vtkSelectionNode";

		/// <summary>
		/// Indicate the means by which data is selected.
		/// In some cases this implies the type of data selected.
		/// </summary>
		// Token: 0x02000ABD RID: 2749
		public enum SelectionContent
		{
			/// <summary>enum member</summary>
			// Token: 0x04001E86 RID: 7814
			BLOCKS = 7,
			/// <summary>enum member</summary>
			// Token: 0x04001E87 RID: 7815
			BLOCK_SELECTORS,
			/// <summary>enum member</summary>
			// Token: 0x04001E88 RID: 7816
			FRUSTUM = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001E89 RID: 7817
			GLOBALIDS = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001E8A RID: 7818
			INDICES = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001E8B RID: 7819
			LOCATIONS = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001E8C RID: 7820
			NUM_CONTENT_TYPES = 11,
			/// <summary>enum member</summary>
			// Token: 0x04001E8D RID: 7821
			PEDIGREEIDS = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001E8E RID: 7822
			QUERY = 9,
			/// <summary>enum member</summary>
			// Token: 0x04001E8F RID: 7823
			THRESHOLDS = 6,
			/// <summary>enum member</summary>
			// Token: 0x04001E90 RID: 7824
			USER = 10,
			/// <summary>enum member</summary>
			// Token: 0x04001E91 RID: 7825
			VALUES = 2
		}

		/// <summary>
		/// Controls whether cell, point, or field data determine what is inside and out.
		/// The default is CELL.
		/// Vertex and edge types are also available for graph classes.
		/// GetFieldType() returns -1 if the field type is not set.
		/// </summary>
		// Token: 0x02000ABE RID: 2750
		public enum SelectionField
		{
			/// <summary>enum member</summary>
			// Token: 0x04001E93 RID: 7827
			CELL,
			/// <summary>enum member</summary>
			// Token: 0x04001E94 RID: 7828
			EDGE = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001E95 RID: 7829
			FIELD = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001E96 RID: 7830
			NUM_FIELD_TYPES = 6,
			/// <summary>enum member</summary>
			// Token: 0x04001E97 RID: 7831
			POINT = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001E98 RID: 7832
			ROW = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001E99 RID: 7833
			VERTEX = 3
		}
	}
}
