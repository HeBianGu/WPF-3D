using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetToDataObjectFilter
	/// </summary>
	/// <remarks>
	///    map dataset into data object (i.e., a field)
	///
	/// vtkDataSetToDataObjectFilter is an class that transforms a dataset into
	/// data object (i.e., a field). The field will have labeled data arrays
	/// corresponding to the topology, geometry, field data, and point and cell
	/// attribute data.
	///
	/// You can control what portions of the dataset are converted into the
	/// output data object's field data. The instance variables Geometry,
	/// Topology, FieldData, PointData, and CellData are flags that control
	/// whether the dataset's geometry (e.g., points, spacing, origin);
	/// topology (e.g., cell connectivity, dimensions); the field data
	/// associated with the dataset's superclass data object; the dataset's
	/// point data attributes; and the dataset's cell data attributes. (Note:
	/// the data attributes include scalars, vectors, tensors, normals, texture
	/// coordinates, and field data.)
	///
	/// The names used to create the field data are as follows. For vtkPolyData,
	/// "Points", "Verts", "Lines", "Polys", and "Strips". For vtkUnstructuredGrid,
	/// "Cells" and "CellTypes". For vtkStructuredPoints, "Dimensions", "Spacing",
	/// and "Origin". For vtkStructuredGrid, "Points" and "Dimensions". For
	/// vtkRectilinearGrid, "XCoordinates", "YCoordinates", and "ZCoordinates".
	/// for point attribute data, "PointScalars", "PointVectors", etc. For cell
	/// attribute data, "CellScalars", "CellVectors", etc. Field data arrays retain
	/// their original name.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataObject vtkFieldData vtkDataObjectToDataSetFilter
	/// </seealso>
	// Token: 0x02000959 RID: 2393
	public class vtkDataSetToDataObjectFilter : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018D9C RID: 101788 RVA: 0x0022AF47 File Offset: 0x00229147
		static vtkDataSetToDataObjectFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetToDataObjectFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetToDataObjectFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018D9D RID: 101789 RVA: 0x0022AF6F File Offset: 0x0022916F
		public vtkDataSetToDataObjectFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018D9E RID: 101790
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetToDataObjectFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object to transform all data into a data object.
		/// </summary>
		// Token: 0x06018D9F RID: 101791 RVA: 0x0022AF80 File Offset: 0x00229180
		public new static vtkDataSetToDataObjectFilter New()
		{
			vtkDataSetToDataObjectFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetToDataObjectFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object to transform all data into a data object.
		/// </summary>
		// Token: 0x06018DA0 RID: 101792 RVA: 0x0022AFD4 File Offset: 0x002291D4
		public vtkDataSetToDataObjectFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018DA1 RID: 101793 RVA: 0x0022B018 File Offset: 0x00229218
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018DA2 RID: 101794
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_CellDataOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset cell data to a data object.
		/// </summary>
		// Token: 0x06018DA3 RID: 101795 RVA: 0x0022B023 File Offset: 0x00229223
		public virtual void CellDataOff()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_CellDataOff_01(base.GetCppThis());
		}

		// Token: 0x06018DA4 RID: 101796
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_CellDataOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset cell data to a data object.
		/// </summary>
		// Token: 0x06018DA5 RID: 101797 RVA: 0x0022B032 File Offset: 0x00229232
		public virtual void CellDataOn()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_CellDataOn_02(base.GetCppThis());
		}

		// Token: 0x06018DA6 RID: 101798
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_FieldDataOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset field data to a data object.
		/// </summary>
		// Token: 0x06018DA7 RID: 101799 RVA: 0x0022B041 File Offset: 0x00229241
		public virtual void FieldDataOff()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_FieldDataOff_03(base.GetCppThis());
		}

		// Token: 0x06018DA8 RID: 101800
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_FieldDataOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset field data to a data object.
		/// </summary>
		// Token: 0x06018DA9 RID: 101801 RVA: 0x0022B050 File Offset: 0x00229250
		public virtual void FieldDataOn()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_FieldDataOn_04(base.GetCppThis());
		}

		// Token: 0x06018DAA RID: 101802
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_GeometryOff_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset geometry to a data object.
		/// </summary>
		// Token: 0x06018DAB RID: 101803 RVA: 0x0022B05F File Offset: 0x0022925F
		public virtual void GeometryOff()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GeometryOff_05(base.GetCppThis());
		}

		// Token: 0x06018DAC RID: 101804
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_GeometryOn_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset geometry to a data object.
		/// </summary>
		// Token: 0x06018DAD RID: 101805 RVA: 0x0022B06E File Offset: 0x0022926E
		public virtual void GeometryOn()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GeometryOn_06(base.GetCppThis());
		}

		// Token: 0x06018DAE RID: 101806
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetToDataObjectFilter_GetCellData_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset cell data to a data object.
		/// </summary>
		// Token: 0x06018DAF RID: 101807 RVA: 0x0022B080 File Offset: 0x00229280
		public virtual int GetCellData()
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetCellData_07(base.GetCppThis());
		}

		// Token: 0x06018DB0 RID: 101808
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetToDataObjectFilter_GetFieldData_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset field data to a data object.
		/// </summary>
		// Token: 0x06018DB1 RID: 101809 RVA: 0x0022B0A0 File Offset: 0x002292A0
		public virtual int GetFieldData()
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetFieldData_08(base.GetCppThis());
		}

		// Token: 0x06018DB2 RID: 101810
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetToDataObjectFilter_GetGeometry_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset geometry to a data object.
		/// </summary>
		// Token: 0x06018DB3 RID: 101811 RVA: 0x0022B0C0 File Offset: 0x002292C0
		public virtual int GetGeometry()
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetGeometry_09(base.GetCppThis());
		}

		// Token: 0x06018DB4 RID: 101812
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetToDataObjectFilter_GetLegacyTopology_10(HandleRef pThis);

		/// <summary>
		/// If LegacyTopology and Topology are both true, print out the legacy topology
		/// arrays. Default is true.
		/// </summary>
		// Token: 0x06018DB5 RID: 101813 RVA: 0x0022B0E0 File Offset: 0x002292E0
		public virtual int GetLegacyTopology()
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetLegacyTopology_10(base.GetCppThis());
		}

		// Token: 0x06018DB6 RID: 101814
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetToDataObjectFilter_GetModernTopology_11(HandleRef pThis);

		/// <summary>
		/// If ModernTopology and Topology are both true, print out the modern topology
		/// arrays. Default is true.
		/// </summary>
		// Token: 0x06018DB7 RID: 101815 RVA: 0x0022B100 File Offset: 0x00229300
		public virtual int GetModernTopology()
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetModernTopology_11(base.GetCppThis());
		}

		// Token: 0x06018DB8 RID: 101816
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetToDataObjectFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018DB9 RID: 101817 RVA: 0x0022B120 File Offset: 0x00229320
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06018DBA RID: 101818
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetToDataObjectFilter_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018DBB RID: 101819 RVA: 0x0022B140 File Offset: 0x00229340
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06018DBC RID: 101820
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetToDataObjectFilter_GetPointData_14(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset point data to a data object.
		/// </summary>
		// Token: 0x06018DBD RID: 101821 RVA: 0x0022B15C File Offset: 0x0022935C
		public virtual int GetPointData()
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetPointData_14(base.GetCppThis());
		}

		// Token: 0x06018DBE RID: 101822
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetToDataObjectFilter_GetTopology_15(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset topology to a data object.
		/// </summary>
		// Token: 0x06018DBF RID: 101823 RVA: 0x0022B17C File Offset: 0x0022937C
		public virtual int GetTopology()
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetTopology_15(base.GetCppThis());
		}

		// Token: 0x06018DC0 RID: 101824
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetToDataObjectFilter_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018DC1 RID: 101825 RVA: 0x0022B19C File Offset: 0x0022939C
		public override int IsA(string type)
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06018DC2 RID: 101826
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetToDataObjectFilter_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018DC3 RID: 101827 RVA: 0x0022B1BC File Offset: 0x002293BC
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_IsTypeOf_17(type);
		}

		// Token: 0x06018DC4 RID: 101828
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_LegacyTopologyOff_18(HandleRef pThis);

		/// <summary>
		/// If LegacyTopology and Topology are both true, print out the legacy topology
		/// arrays. Default is true.
		/// </summary>
		// Token: 0x06018DC5 RID: 101829 RVA: 0x0022B1D6 File Offset: 0x002293D6
		public virtual void LegacyTopologyOff()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_LegacyTopologyOff_18(base.GetCppThis());
		}

		// Token: 0x06018DC6 RID: 101830
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_LegacyTopologyOn_19(HandleRef pThis);

		/// <summary>
		/// If LegacyTopology and Topology are both true, print out the legacy topology
		/// arrays. Default is true.
		/// </summary>
		// Token: 0x06018DC7 RID: 101831 RVA: 0x0022B1E5 File Offset: 0x002293E5
		public virtual void LegacyTopologyOn()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_LegacyTopologyOn_19(base.GetCppThis());
		}

		// Token: 0x06018DC8 RID: 101832
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_ModernTopologyOff_20(HandleRef pThis);

		/// <summary>
		/// If ModernTopology and Topology are both true, print out the modern topology
		/// arrays. Default is true.
		/// </summary>
		// Token: 0x06018DC9 RID: 101833 RVA: 0x0022B1F4 File Offset: 0x002293F4
		public virtual void ModernTopologyOff()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_ModernTopologyOff_20(base.GetCppThis());
		}

		// Token: 0x06018DCA RID: 101834
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_ModernTopologyOn_21(HandleRef pThis);

		/// <summary>
		/// If ModernTopology and Topology are both true, print out the modern topology
		/// arrays. Default is true.
		/// </summary>
		// Token: 0x06018DCB RID: 101835 RVA: 0x0022B203 File Offset: 0x00229403
		public virtual void ModernTopologyOn()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_ModernTopologyOn_21(base.GetCppThis());
		}

		// Token: 0x06018DCC RID: 101836
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetToDataObjectFilter_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018DCD RID: 101837 RVA: 0x0022B214 File Offset: 0x00229414
		public new vtkDataSetToDataObjectFilter NewInstance()
		{
			vtkDataSetToDataObjectFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetToDataObjectFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018DCE RID: 101838
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_PointDataOff_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset point data to a data object.
		/// </summary>
		// Token: 0x06018DCF RID: 101839 RVA: 0x0022B26E File Offset: 0x0022946E
		public virtual void PointDataOff()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_PointDataOff_24(base.GetCppThis());
		}

		// Token: 0x06018DD0 RID: 101840
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_PointDataOn_25(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset point data to a data object.
		/// </summary>
		// Token: 0x06018DD1 RID: 101841 RVA: 0x0022B27D File Offset: 0x0022947D
		public virtual void PointDataOn()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_PointDataOn_25(base.GetCppThis());
		}

		// Token: 0x06018DD2 RID: 101842
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetToDataObjectFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018DD3 RID: 101843 RVA: 0x0022B28C File Offset: 0x0022948C
		public new static vtkDataSetToDataObjectFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetToDataObjectFilter vtkDataSetToDataObjectFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetToDataObjectFilter = (vtkDataSetToDataObjectFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetToDataObjectFilter.Register(null);
				}
			}
			return vtkDataSetToDataObjectFilter;
		}

		// Token: 0x06018DD4 RID: 101844
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_SetCellData_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the conversion of dataset cell data to a data object.
		/// </summary>
		// Token: 0x06018DD5 RID: 101845 RVA: 0x0022B30B File Offset: 0x0022950B
		public virtual void SetCellData(int _arg)
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SetCellData_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06018DD6 RID: 101846
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_SetFieldData_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the conversion of dataset field data to a data object.
		/// </summary>
		// Token: 0x06018DD7 RID: 101847 RVA: 0x0022B31B File Offset: 0x0022951B
		public virtual void SetFieldData(int _arg)
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SetFieldData_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06018DD8 RID: 101848
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_SetGeometry_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the conversion of dataset geometry to a data object.
		/// </summary>
		// Token: 0x06018DD9 RID: 101849 RVA: 0x0022B32B File Offset: 0x0022952B
		public virtual void SetGeometry(int _arg)
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SetGeometry_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06018DDA RID: 101850
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_SetLegacyTopology_30(HandleRef pThis, int _arg);

		/// <summary>
		/// If LegacyTopology and Topology are both true, print out the legacy topology
		/// arrays. Default is true.
		/// </summary>
		// Token: 0x06018DDB RID: 101851 RVA: 0x0022B33B File Offset: 0x0022953B
		public virtual void SetLegacyTopology(int _arg)
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SetLegacyTopology_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06018DDC RID: 101852
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_SetModernTopology_31(HandleRef pThis, int _arg);

		/// <summary>
		/// If ModernTopology and Topology are both true, print out the modern topology
		/// arrays. Default is true.
		/// </summary>
		// Token: 0x06018DDD RID: 101853 RVA: 0x0022B34B File Offset: 0x0022954B
		public virtual void SetModernTopology(int _arg)
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SetModernTopology_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06018DDE RID: 101854
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_SetPointData_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the conversion of dataset point data to a data object.
		/// </summary>
		// Token: 0x06018DDF RID: 101855 RVA: 0x0022B35B File Offset: 0x0022955B
		public virtual void SetPointData(int _arg)
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SetPointData_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06018DE0 RID: 101856
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_SetTopology_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the conversion of dataset topology to a data object.
		/// </summary>
		// Token: 0x06018DE1 RID: 101857 RVA: 0x0022B36B File Offset: 0x0022956B
		public virtual void SetTopology(int _arg)
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SetTopology_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06018DE2 RID: 101858
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_TopologyOff_34(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset topology to a data object.
		/// </summary>
		// Token: 0x06018DE3 RID: 101859 RVA: 0x0022B37B File Offset: 0x0022957B
		public virtual void TopologyOff()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_TopologyOff_34(base.GetCppThis());
		}

		// Token: 0x06018DE4 RID: 101860
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetToDataObjectFilter_TopologyOn_35(HandleRef pThis);

		/// <summary>
		/// Turn on/off the conversion of dataset topology to a data object.
		/// </summary>
		// Token: 0x06018DE5 RID: 101861 RVA: 0x0022B38A File Offset: 0x0022958A
		public virtual void TopologyOn()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_TopologyOn_35(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B6B RID: 7019
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetToDataObjectFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B6C RID: 7020
		public new static readonly string MRClassNameKey = "class vtkDataSetToDataObjectFilter";
	}
}
