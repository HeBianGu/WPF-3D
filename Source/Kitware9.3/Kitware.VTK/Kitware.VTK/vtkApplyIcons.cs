using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkApplyIcons
	/// </summary>
	/// <remarks>
	///    apply icons to a data set.
	///
	///
	/// vtkApplyIcons performs a iconing of the dataset using default icons,
	/// lookup tables, annotations, and/or a selection. The output is a
	/// vtkIntArray containing the icon index for each
	/// element in the dataset. The first input is the dataset to be iconed, which
	/// may be a vtkTable, vtkGraph subclass, or vtkDataSet subclass.
	///
	/// The second (optional) input is a vtkAnnotationLayers object, which stores
	/// a list of annotation layers, with each layer holding a list of
	/// vtkAnnotation objects. The annotation specifies a subset of data along with
	/// other properties, including icon. For annotations with icon properties,
	/// this algorithm will use the icon index of annotated elements,
	/// using a "top one wins" strategy.
	///
	/// The third (optional) input is a vtkSelection object, meant for specifying
	/// the current selection. You can control the icon of the selection, or whether
	/// there is a set of selected icons at a particular offset in the icon sheet.
	///
	/// The algorithm takes an input array, specified with
	/// SetInputArrayToProcess(0, 0, 0, vtkDataObject::FIELD_ASSOCIATION_POINTS, name)
	/// This sets data arrays to use to icon the data with
	/// the associated lookup table. For vtkGraph and vtkTable inputs, you would use
	/// FIELD_ASSOCIATION_VERTICES, FIELD_ASSOCIATION_EDGES, or
	/// FIELD_ASSOCIATION_ROWS as appropriate. The icon array will be added to the same
	/// set of attributes that the input array came from. If there is no input array,
	/// the icon array will be applied to the attributes associated with the
	/// AttributeType parameter.
	///
	/// Icons are assigned with the following priorities:
	/// &lt;ol&gt;
	/// &lt;li&gt; If an item is part of the selection, it is glyphed with that icon.
	/// &lt;li&gt; Otherwise, if the item is part of an annotation, it is glyphed
	///      with the icon of the final (top) annotation in the set of layers.
	/// &lt;li&gt; Otherwise, if a lookup table is used, it is glyphed using the
	///      lookup table icon for the data value of the element.
	/// &lt;li&gt; Otherwise it will be glyphed with the default icon.
	/// &lt;/ol&gt;
	/// </remarks>
	// Token: 0x0200005E RID: 94
	public class vtkApplyIcons : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001118 RID: 4376 RVA: 0x0001EB5D File Offset: 0x0001CD5D
		static vtkApplyIcons()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkApplyIcons.MRClassNameKey, Type.GetType("Kitware.VTK.vtkApplyIcons"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001119 RID: 4377 RVA: 0x0001EB85 File Offset: 0x0001CD85
		public vtkApplyIcons(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600111A RID: 4378
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyIcons_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600111B RID: 4379 RVA: 0x0001EB94 File Offset: 0x0001CD94
		public new static vtkApplyIcons New()
		{
			vtkApplyIcons result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkApplyIcons.vtkApplyIcons_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkApplyIcons)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600111C RID: 4380 RVA: 0x0001EBE8 File Offset: 0x0001CDE8
		public vtkApplyIcons() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkApplyIcons.vtkApplyIcons_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600111D RID: 4381 RVA: 0x0001EC2C File Offset: 0x0001CE2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600111E RID: 4382
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_ClearAllIconTypes_01(HandleRef pThis);

		/// <summary>
		/// Edits the lookup table to use for point icons. This is only used if
		/// input array 0 is set and UsePointLookupTable is on.
		/// </summary>
		// Token: 0x0600111F RID: 4383 RVA: 0x0001EC37 File Offset: 0x0001CE37
		public void ClearAllIconTypes()
		{
			vtkApplyIcons.vtkApplyIcons_ClearAllIconTypes_01(base.GetCppThis());
		}

		// Token: 0x06001120 RID: 4384
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkApplyIcons_GetAttributeType_02(HandleRef pThis);

		/// <summary>
		/// The attribute type to append the icon array to, used only if the
		/// input array is not specified or does not exist. This is set to one
		/// of the AttributeTypes enum in vtkDataObject (e.g. POINT, CELL, VERTEX
		/// EDGE, FIELD).
		/// </summary>
		// Token: 0x06001121 RID: 4385 RVA: 0x0001EC48 File Offset: 0x0001CE48
		public virtual int GetAttributeType()
		{
			return vtkApplyIcons.vtkApplyIcons_GetAttributeType_02(base.GetCppThis());
		}

		// Token: 0x06001122 RID: 4386
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkApplyIcons_GetDefaultIcon_03(HandleRef pThis);

		/// <summary>
		/// The default point icon for all unannotated, unselected elements
		/// of the data. This is used if UsePointLookupTable is off.
		/// </summary>
		// Token: 0x06001123 RID: 4387 RVA: 0x0001EC68 File Offset: 0x0001CE68
		public virtual int GetDefaultIcon()
		{
			return vtkApplyIcons.vtkApplyIcons_GetDefaultIcon_03(base.GetCppThis());
		}

		// Token: 0x06001124 RID: 4388
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyIcons_GetIconOutputArrayName_04(HandleRef pThis);

		/// <summary>
		/// The output array name for the point icon index array.
		/// Default is "vtkApplyIcons icon".
		/// </summary>
		// Token: 0x06001125 RID: 4389 RVA: 0x0001EC88 File Offset: 0x0001CE88
		public virtual string GetIconOutputArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkApplyIcons.vtkApplyIcons_GetIconOutputArrayName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001126 RID: 4390
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkApplyIcons_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001127 RID: 4391 RVA: 0x0001ECC4 File Offset: 0x0001CEC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkApplyIcons.vtkApplyIcons_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06001128 RID: 4392
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkApplyIcons_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001129 RID: 4393 RVA: 0x0001ECE4 File Offset: 0x0001CEE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkApplyIcons.vtkApplyIcons_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600112A RID: 4394
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkApplyIcons_GetSelectedIcon_07(HandleRef pThis);

		/// <summary>
		/// The point icon for all selected elements of the data.
		/// This is used if the annotation input has a current selection.
		/// </summary>
		// Token: 0x0600112B RID: 4395 RVA: 0x0001ED00 File Offset: 0x0001CF00
		public virtual int GetSelectedIcon()
		{
			return vtkApplyIcons.vtkApplyIcons_GetSelectedIcon_07(base.GetCppThis());
		}

		// Token: 0x0600112C RID: 4396
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkApplyIcons_GetSelectionMode_08(HandleRef pThis);

		/// <summary>
		/// Changes the behavior of the icon to use for selected items.
		/// &lt;ul&gt;
		/// &lt;li&gt;SELECTED_ICON uses SelectedIcon as the icon for all selected elements.
		/// &lt;li&gt;SELECTED_OFFSET uses SelectedIcon as an offset to add to all selected elements.
		/// &lt;li&gt;ANNOTATION_ICON uses the ICON_INDEX() property of the current annotation.
		/// &lt;li&gt;IGNORE_SELECTION does not change the icon based on the current selection.
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600112D RID: 4397 RVA: 0x0001ED20 File Offset: 0x0001CF20
		public virtual int GetSelectionMode()
		{
			return vtkApplyIcons.vtkApplyIcons_GetSelectionMode_08(base.GetCppThis());
		}

		// Token: 0x0600112E RID: 4398
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkApplyIcons_GetUseLookupTable_09(HandleRef pThis);

		/// <summary>
		/// If on, uses the point lookup table to set the colors of unannotated,
		/// unselected elements of the data.
		/// </summary>
		// Token: 0x0600112F RID: 4399 RVA: 0x0001ED40 File Offset: 0x0001CF40
		public virtual bool GetUseLookupTable()
		{
			return vtkApplyIcons.vtkApplyIcons_GetUseLookupTable_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06001130 RID: 4400
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkApplyIcons_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001131 RID: 4401 RVA: 0x0001ED68 File Offset: 0x0001CF68
		public override int IsA(string type)
		{
			return vtkApplyIcons.vtkApplyIcons_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06001132 RID: 4402
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkApplyIcons_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001133 RID: 4403 RVA: 0x0001ED88 File Offset: 0x0001CF88
		public new static int IsTypeOf(string type)
		{
			return vtkApplyIcons.vtkApplyIcons_IsTypeOf_11(type);
		}

		// Token: 0x06001134 RID: 4404
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyIcons_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001135 RID: 4405 RVA: 0x0001EDA4 File Offset: 0x0001CFA4
		public new vtkApplyIcons NewInstance()
		{
			vtkApplyIcons result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkApplyIcons.vtkApplyIcons_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkApplyIcons)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001136 RID: 4406
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyIcons_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001137 RID: 4407 RVA: 0x0001EE00 File Offset: 0x0001D000
		public new static vtkApplyIcons SafeDownCast(vtkObjectBase o)
		{
			vtkApplyIcons vtkApplyIcons = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkApplyIcons.vtkApplyIcons_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkApplyIcons = (vtkApplyIcons)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkApplyIcons.Register(null);
				}
			}
			return vtkApplyIcons;
		}

		// Token: 0x06001138 RID: 4408
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetAttributeType_15(HandleRef pThis, int _arg);

		/// <summary>
		/// The attribute type to append the icon array to, used only if the
		/// input array is not specified or does not exist. This is set to one
		/// of the AttributeTypes enum in vtkDataObject (e.g. POINT, CELL, VERTEX
		/// EDGE, FIELD).
		/// </summary>
		// Token: 0x06001139 RID: 4409 RVA: 0x0001EE7F File Offset: 0x0001D07F
		public virtual void SetAttributeType(int _arg)
		{
			vtkApplyIcons.vtkApplyIcons_SetAttributeType_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600113A RID: 4410
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetDefaultIcon_16(HandleRef pThis, int _arg);

		/// <summary>
		/// The default point icon for all unannotated, unselected elements
		/// of the data. This is used if UsePointLookupTable is off.
		/// </summary>
		// Token: 0x0600113B RID: 4411 RVA: 0x0001EE8F File Offset: 0x0001D08F
		public virtual void SetDefaultIcon(int _arg)
		{
			vtkApplyIcons.vtkApplyIcons_SetDefaultIcon_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600113C RID: 4412
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetIconOutputArrayName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The output array name for the point icon index array.
		/// Default is "vtkApplyIcons icon".
		/// </summary>
		// Token: 0x0600113D RID: 4413 RVA: 0x0001EE9F File Offset: 0x0001D09F
		public virtual void SetIconOutputArrayName(string _arg)
		{
			vtkApplyIcons.vtkApplyIcons_SetIconOutputArrayName_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600113E RID: 4414
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetIconType_18(HandleRef pThis, HandleRef v, int icon);

		/// <summary>
		/// Edits the lookup table to use for point icons. This is only used if
		/// input array 0 is set and UsePointLookupTable is on.
		/// </summary>
		// Token: 0x0600113F RID: 4415 RVA: 0x0001EEB0 File Offset: 0x0001D0B0
		public void SetIconType(vtkVariant v, int icon)
		{
			vtkApplyIcons.vtkApplyIcons_SetIconType_18(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis(), icon);
		}

		// Token: 0x06001140 RID: 4416
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetIconType_19(HandleRef pThis, double v, int icon);

		/// <summary>
		/// Edits the lookup table to use for point icons. This is only used if
		/// input array 0 is set and UsePointLookupTable is on.
		/// </summary>
		// Token: 0x06001141 RID: 4417 RVA: 0x0001EEE0 File Offset: 0x0001D0E0
		public void SetIconType(double v, int icon)
		{
			vtkApplyIcons.vtkApplyIcons_SetIconType_19(base.GetCppThis(), v, icon);
		}

		// Token: 0x06001142 RID: 4418
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetIconType_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string v, int icon);

		/// <summary>
		/// Edits the lookup table to use for point icons. This is only used if
		/// input array 0 is set and UsePointLookupTable is on.
		/// </summary>
		// Token: 0x06001143 RID: 4419 RVA: 0x0001EEF1 File Offset: 0x0001D0F1
		public void SetIconType(string v, int icon)
		{
			vtkApplyIcons.vtkApplyIcons_SetIconType_20(base.GetCppThis(), v, icon);
		}

		// Token: 0x06001144 RID: 4420
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetSelectedIcon_21(HandleRef pThis, int _arg);

		/// <summary>
		/// The point icon for all selected elements of the data.
		/// This is used if the annotation input has a current selection.
		/// </summary>
		// Token: 0x06001145 RID: 4421 RVA: 0x0001EF02 File Offset: 0x0001D102
		public virtual void SetSelectedIcon(int _arg)
		{
			vtkApplyIcons.vtkApplyIcons_SetSelectedIcon_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06001146 RID: 4422
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetSelectionMode_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Changes the behavior of the icon to use for selected items.
		/// &lt;ul&gt;
		/// &lt;li&gt;SELECTED_ICON uses SelectedIcon as the icon for all selected elements.
		/// &lt;li&gt;SELECTED_OFFSET uses SelectedIcon as an offset to add to all selected elements.
		/// &lt;li&gt;ANNOTATION_ICON uses the ICON_INDEX() property of the current annotation.
		/// &lt;li&gt;IGNORE_SELECTION does not change the icon based on the current selection.
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001147 RID: 4423 RVA: 0x0001EF12 File Offset: 0x0001D112
		public virtual void SetSelectionMode(int _arg)
		{
			vtkApplyIcons.vtkApplyIcons_SetSelectionMode_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06001148 RID: 4424
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetSelectionModeToAnnotationIcon_23(HandleRef pThis);

		/// <summary>
		/// Changes the behavior of the icon to use for selected items.
		/// &lt;ul&gt;
		/// &lt;li&gt;SELECTED_ICON uses SelectedIcon as the icon for all selected elements.
		/// &lt;li&gt;SELECTED_OFFSET uses SelectedIcon as an offset to add to all selected elements.
		/// &lt;li&gt;ANNOTATION_ICON uses the ICON_INDEX() property of the current annotation.
		/// &lt;li&gt;IGNORE_SELECTION does not change the icon based on the current selection.
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001149 RID: 4425 RVA: 0x0001EF22 File Offset: 0x0001D122
		public virtual void SetSelectionModeToAnnotationIcon()
		{
			vtkApplyIcons.vtkApplyIcons_SetSelectionModeToAnnotationIcon_23(base.GetCppThis());
		}

		// Token: 0x0600114A RID: 4426
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetSelectionModeToIgnoreSelection_24(HandleRef pThis);

		/// <summary>
		/// Changes the behavior of the icon to use for selected items.
		/// &lt;ul&gt;
		/// &lt;li&gt;SELECTED_ICON uses SelectedIcon as the icon for all selected elements.
		/// &lt;li&gt;SELECTED_OFFSET uses SelectedIcon as an offset to add to all selected elements.
		/// &lt;li&gt;ANNOTATION_ICON uses the ICON_INDEX() property of the current annotation.
		/// &lt;li&gt;IGNORE_SELECTION does not change the icon based on the current selection.
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600114B RID: 4427 RVA: 0x0001EF31 File Offset: 0x0001D131
		public virtual void SetSelectionModeToIgnoreSelection()
		{
			vtkApplyIcons.vtkApplyIcons_SetSelectionModeToIgnoreSelection_24(base.GetCppThis());
		}

		// Token: 0x0600114C RID: 4428
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetSelectionModeToSelectedIcon_25(HandleRef pThis);

		/// <summary>
		/// Changes the behavior of the icon to use for selected items.
		/// &lt;ul&gt;
		/// &lt;li&gt;SELECTED_ICON uses SelectedIcon as the icon for all selected elements.
		/// &lt;li&gt;SELECTED_OFFSET uses SelectedIcon as an offset to add to all selected elements.
		/// &lt;li&gt;ANNOTATION_ICON uses the ICON_INDEX() property of the current annotation.
		/// &lt;li&gt;IGNORE_SELECTION does not change the icon based on the current selection.
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600114D RID: 4429 RVA: 0x0001EF40 File Offset: 0x0001D140
		public virtual void SetSelectionModeToSelectedIcon()
		{
			vtkApplyIcons.vtkApplyIcons_SetSelectionModeToSelectedIcon_25(base.GetCppThis());
		}

		// Token: 0x0600114E RID: 4430
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetSelectionModeToSelectedOffset_26(HandleRef pThis);

		/// <summary>
		/// Changes the behavior of the icon to use for selected items.
		/// &lt;ul&gt;
		/// &lt;li&gt;SELECTED_ICON uses SelectedIcon as the icon for all selected elements.
		/// &lt;li&gt;SELECTED_OFFSET uses SelectedIcon as an offset to add to all selected elements.
		/// &lt;li&gt;ANNOTATION_ICON uses the ICON_INDEX() property of the current annotation.
		/// &lt;li&gt;IGNORE_SELECTION does not change the icon based on the current selection.
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600114F RID: 4431 RVA: 0x0001EF4F File Offset: 0x0001D14F
		public virtual void SetSelectionModeToSelectedOffset()
		{
			vtkApplyIcons.vtkApplyIcons_SetSelectionModeToSelectedOffset_26(base.GetCppThis());
		}

		// Token: 0x06001150 RID: 4432
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_SetUseLookupTable_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, uses the point lookup table to set the colors of unannotated,
		/// unselected elements of the data.
		/// </summary>
		// Token: 0x06001151 RID: 4433 RVA: 0x0001EF5E File Offset: 0x0001D15E
		public virtual void SetUseLookupTable(bool _arg)
		{
			vtkApplyIcons.vtkApplyIcons_SetUseLookupTable_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001152 RID: 4434
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_UseLookupTableOff_28(HandleRef pThis);

		/// <summary>
		/// If on, uses the point lookup table to set the colors of unannotated,
		/// unselected elements of the data.
		/// </summary>
		// Token: 0x06001153 RID: 4435 RVA: 0x0001EF76 File Offset: 0x0001D176
		public virtual void UseLookupTableOff()
		{
			vtkApplyIcons.vtkApplyIcons_UseLookupTableOff_28(base.GetCppThis());
		}

		// Token: 0x06001154 RID: 4436
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyIcons_UseLookupTableOn_29(HandleRef pThis);

		/// <summary>
		/// If on, uses the point lookup table to set the colors of unannotated,
		/// unselected elements of the data.
		/// </summary>
		// Token: 0x06001155 RID: 4437 RVA: 0x0001EF85 File Offset: 0x0001D185
		public virtual void UseLookupTableOn()
		{
			vtkApplyIcons.vtkApplyIcons_UseLookupTableOn_29(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400043C RID: 1084
		public new const string MRFullTypeName = "Kitware.VTK.vtkApplyIcons";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400043D RID: 1085
		public new static readonly string MRClassNameKey = "class vtkApplyIcons";

		/// <summary>
		/// The output array name for the point icon index array.
		/// Default is "vtkApplyIcons icon".
		/// </summary>
		// Token: 0x0200005F RID: 95
		public enum ANNOTATION_ICON_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400043F RID: 1087
			ANNOTATION_ICON = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000440 RID: 1088
			IGNORE_SELECTION,
			/// <summary>enum member</summary>
			// Token: 0x04000441 RID: 1089
			SELECTED_ICON = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000442 RID: 1090
			SELECTED_OFFSET
		}
	}
}
