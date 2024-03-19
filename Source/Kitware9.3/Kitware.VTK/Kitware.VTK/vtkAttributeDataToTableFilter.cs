using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAttributeDataToTableFilter
	/// </summary>
	/// <remarks>
	///    this filter produces a
	/// vtkTable from the chosen attribute in the input data object.
	///
	/// vtkAttributeDataToTableFilter is a filter that produces a vtkTable from the
	/// chosen attribute in the input dataobject. This filter can accept composite
	/// datasets. If the input is a composite dataset, the output is a multiblock
	/// with vtkTable leaves.
	/// </remarks>
	// Token: 0x02000942 RID: 2370
	public class vtkAttributeDataToTableFilter : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060188F4 RID: 100596 RVA: 0x00225517 File Offset: 0x00223717
		static vtkAttributeDataToTableFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAttributeDataToTableFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAttributeDataToTableFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060188F5 RID: 100597 RVA: 0x0022553F File Offset: 0x0022373F
		public vtkAttributeDataToTableFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060188F6 RID: 100598
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeDataToTableFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188F7 RID: 100599 RVA: 0x00225550 File Offset: 0x00223750
		public new static vtkAttributeDataToTableFilter New()
		{
			vtkAttributeDataToTableFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributeDataToTableFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188F8 RID: 100600 RVA: 0x002255A4 File Offset: 0x002237A4
		public vtkAttributeDataToTableFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060188F9 RID: 100601 RVA: 0x002255E8 File Offset: 0x002237E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060188FA RID: 100602
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToTableFilter_AddMetaDataOff_01(HandleRef pThis);

		/// <summary>
		/// It is possible for this filter to add additional meta-data to the field
		/// data such as point coordinates (when point attributes are selected and
		/// input is pointset) or structured coordinates etc. To enable this addition
		/// of extra information, turn this flag on. Off by default.
		/// </summary>
		// Token: 0x060188FB RID: 100603 RVA: 0x002255F3 File Offset: 0x002237F3
		public virtual void AddMetaDataOff()
		{
			vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_AddMetaDataOff_01(base.GetCppThis());
		}

		// Token: 0x060188FC RID: 100604
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToTableFilter_AddMetaDataOn_02(HandleRef pThis);

		/// <summary>
		/// It is possible for this filter to add additional meta-data to the field
		/// data such as point coordinates (when point attributes are selected and
		/// input is pointset) or structured coordinates etc. To enable this addition
		/// of extra information, turn this flag on. Off by default.
		/// </summary>
		// Token: 0x060188FD RID: 100605 RVA: 0x00225602 File Offset: 0x00223802
		public virtual void AddMetaDataOn()
		{
			vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_AddMetaDataOn_02(base.GetCppThis());
		}

		// Token: 0x060188FE RID: 100606
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToTableFilter_GenerateCellConnectivityOff_03(HandleRef pThis);

		/// <summary>
		/// When set to true (default is false) the connectivity of each cell will be added by
		/// adding a new column for each point.
		/// </summary>
		// Token: 0x060188FF RID: 100607 RVA: 0x00225611 File Offset: 0x00223811
		public virtual void GenerateCellConnectivityOff()
		{
			vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_GenerateCellConnectivityOff_03(base.GetCppThis());
		}

		// Token: 0x06018900 RID: 100608
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToTableFilter_GenerateCellConnectivityOn_04(HandleRef pThis);

		/// <summary>
		/// When set to true (default is false) the connectivity of each cell will be added by
		/// adding a new column for each point.
		/// </summary>
		// Token: 0x06018901 RID: 100609 RVA: 0x00225620 File Offset: 0x00223820
		public virtual void GenerateCellConnectivityOn()
		{
			vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_GenerateCellConnectivityOn_04(base.GetCppThis());
		}

		// Token: 0x06018902 RID: 100610
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToTableFilter_GenerateOriginalIdsOff_05(HandleRef pThis);

		/// <summary>
		/// When set (default) the vtkOriginalIndices array will be added to the
		/// output. Can be overridden by setting this flag to 0.
		/// This is only respected when AddMetaData is true.
		/// </summary>
		// Token: 0x06018903 RID: 100611 RVA: 0x0022562F File Offset: 0x0022382F
		public virtual void GenerateOriginalIdsOff()
		{
			vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_GenerateOriginalIdsOff_05(base.GetCppThis());
		}

		// Token: 0x06018904 RID: 100612
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToTableFilter_GenerateOriginalIdsOn_06(HandleRef pThis);

		/// <summary>
		/// When set (default) the vtkOriginalIndices array will be added to the
		/// output. Can be overridden by setting this flag to 0.
		/// This is only respected when AddMetaData is true.
		/// </summary>
		// Token: 0x06018905 RID: 100613 RVA: 0x0022563E File Offset: 0x0022383E
		public virtual void GenerateOriginalIdsOn()
		{
			vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_GenerateOriginalIdsOn_06(base.GetCppThis());
		}

		// Token: 0x06018906 RID: 100614
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAttributeDataToTableFilter_GetAddMetaData_07(HandleRef pThis);

		/// <summary>
		/// It is possible for this filter to add additional meta-data to the field
		/// data such as point coordinates (when point attributes are selected and
		/// input is pointset) or structured coordinates etc. To enable this addition
		/// of extra information, turn this flag on. Off by default.
		/// </summary>
		// Token: 0x06018907 RID: 100615 RVA: 0x00225650 File Offset: 0x00223850
		public virtual bool GetAddMetaData()
		{
			return vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_GetAddMetaData_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06018908 RID: 100616
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeDataToTableFilter_GetFieldAssociation_08(HandleRef pThis);

		/// <summary>
		/// Select the attribute type. Accepted values are
		/// \li vtkDataObject::FIELD_ASSOCIATION_POINTS,
		/// \li vtkDataObject::FIELD_ASSOCIATION_CELLS,
		/// \li vtkDataObject::FIELD_ASSOCIATION_NONE,
		/// \li vtkDataObject::FIELD_ASSOCIATION_VERTICES,
		/// \li vtkDataObject::FIELD_ASSOCIATION_EDGES,
		/// \li vtkDataObject::FIELD_ASSOCIATION_ROWS
		/// If value is vtkDataObject::FIELD_ASSOCIATION_NONE, then FieldData
		/// associated with the input dataobject is extracted.
		///
		/// Default is vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// </summary>
		// Token: 0x06018909 RID: 100617 RVA: 0x00225678 File Offset: 0x00223878
		public virtual int GetFieldAssociation()
		{
			return vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_GetFieldAssociation_08(base.GetCppThis());
		}

		// Token: 0x0601890A RID: 100618
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAttributeDataToTableFilter_GetGenerateCellConnectivity_09(HandleRef pThis);

		/// <summary>
		/// When set to true (default is false) the connectivity of each cell will be added by
		/// adding a new column for each point.
		/// </summary>
		// Token: 0x0601890B RID: 100619 RVA: 0x00225698 File Offset: 0x00223898
		public virtual bool GetGenerateCellConnectivity()
		{
			return vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_GetGenerateCellConnectivity_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0601890C RID: 100620
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAttributeDataToTableFilter_GetGenerateOriginalIds_10(HandleRef pThis);

		/// <summary>
		/// When set (default) the vtkOriginalIndices array will be added to the
		/// output. Can be overridden by setting this flag to 0.
		/// This is only respected when AddMetaData is true.
		/// </summary>
		// Token: 0x0601890D RID: 100621 RVA: 0x002256C0 File Offset: 0x002238C0
		public virtual bool GetGenerateOriginalIds()
		{
			return vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_GetGenerateOriginalIds_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0601890E RID: 100622
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAttributeDataToTableFilter_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601890F RID: 100623 RVA: 0x002256E8 File Offset: 0x002238E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06018910 RID: 100624
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAttributeDataToTableFilter_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018911 RID: 100625 RVA: 0x00225708 File Offset: 0x00223908
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06018912 RID: 100626
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeDataToTableFilter_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018913 RID: 100627 RVA: 0x00225724 File Offset: 0x00223924
		public override int IsA(string type)
		{
			return vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06018914 RID: 100628
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeDataToTableFilter_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018915 RID: 100629 RVA: 0x00225744 File Offset: 0x00223944
		public new static int IsTypeOf(string type)
		{
			return vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_IsTypeOf_14(type);
		}

		// Token: 0x06018916 RID: 100630
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeDataToTableFilter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018917 RID: 100631 RVA: 0x00225760 File Offset: 0x00223960
		public new vtkAttributeDataToTableFilter NewInstance()
		{
			vtkAttributeDataToTableFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributeDataToTableFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018918 RID: 100632
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeDataToTableFilter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018919 RID: 100633 RVA: 0x002257BC File Offset: 0x002239BC
		public new static vtkAttributeDataToTableFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAttributeDataToTableFilter vtkAttributeDataToTableFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAttributeDataToTableFilter = (vtkAttributeDataToTableFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAttributeDataToTableFilter.Register(null);
				}
			}
			return vtkAttributeDataToTableFilter;
		}

		// Token: 0x0601891A RID: 100634
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToTableFilter_SetAddMetaData_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// It is possible for this filter to add additional meta-data to the field
		/// data such as point coordinates (when point attributes are selected and
		/// input is pointset) or structured coordinates etc. To enable this addition
		/// of extra information, turn this flag on. Off by default.
		/// </summary>
		// Token: 0x0601891B RID: 100635 RVA: 0x0022583B File Offset: 0x00223A3B
		public virtual void SetAddMetaData(bool _arg)
		{
			vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_SetAddMetaData_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601891C RID: 100636
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToTableFilter_SetFieldAssociation_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Select the attribute type. Accepted values are
		/// \li vtkDataObject::FIELD_ASSOCIATION_POINTS,
		/// \li vtkDataObject::FIELD_ASSOCIATION_CELLS,
		/// \li vtkDataObject::FIELD_ASSOCIATION_NONE,
		/// \li vtkDataObject::FIELD_ASSOCIATION_VERTICES,
		/// \li vtkDataObject::FIELD_ASSOCIATION_EDGES,
		/// \li vtkDataObject::FIELD_ASSOCIATION_ROWS
		/// If value is vtkDataObject::FIELD_ASSOCIATION_NONE, then FieldData
		/// associated with the input dataobject is extracted.
		///
		/// Default is vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// </summary>
		// Token: 0x0601891D RID: 100637 RVA: 0x00225853 File Offset: 0x00223A53
		public virtual void SetFieldAssociation(int _arg)
		{
			vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_SetFieldAssociation_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0601891E RID: 100638
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToTableFilter_SetGenerateCellConnectivity_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default is false) the connectivity of each cell will be added by
		/// adding a new column for each point.
		/// </summary>
		// Token: 0x0601891F RID: 100639 RVA: 0x00225863 File Offset: 0x00223A63
		public virtual void SetGenerateCellConnectivity(bool _arg)
		{
			vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_SetGenerateCellConnectivity_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06018920 RID: 100640
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToTableFilter_SetGenerateOriginalIds_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set (default) the vtkOriginalIndices array will be added to the
		/// output. Can be overridden by setting this flag to 0.
		/// This is only respected when AddMetaData is true.
		/// </summary>
		// Token: 0x06018921 RID: 100641 RVA: 0x0022587B File Offset: 0x00223A7B
		public virtual void SetGenerateOriginalIds(bool _arg)
		{
			vtkAttributeDataToTableFilter.vtkAttributeDataToTableFilter_SetGenerateOriginalIds_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B34 RID: 6964
		public new const string MRFullTypeName = "Kitware.VTK.vtkAttributeDataToTableFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B35 RID: 6965
		public new static readonly string MRClassNameKey = "class vtkAttributeDataToTableFilter";
	}
}
