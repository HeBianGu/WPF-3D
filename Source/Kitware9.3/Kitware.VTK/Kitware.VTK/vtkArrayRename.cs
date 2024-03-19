using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArrayRename
	/// </summary>
	/// <remarks>
	///    Rename data arrays.
	///
	///  This class takes any vtkDataObject as input, shallow copies its content to
	///  the output and renames its data arrays.
	///
	///  For each attributes type, array name should be unique.
	///
	///  Supported attributes type are the following: POINT, CELL, FIELD, VERTEX, EDGE and ROW.
	/// </remarks>
	// Token: 0x0200093E RID: 2366
	public class vtkArrayRename : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601885A RID: 100442 RVA: 0x00224873 File Offset: 0x00222A73
		static vtkArrayRename()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayRename.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayRename"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601885B RID: 100443 RVA: 0x0022489B File Offset: 0x00222A9B
		public vtkArrayRename(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601885C RID: 100444
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601885D RID: 100445 RVA: 0x002248AC File Offset: 0x00222AAC
		public new static vtkArrayRename New()
		{
			vtkArrayRename result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayRename.vtkArrayRename_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayRename)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601885E RID: 100446 RVA: 0x00224900 File Offset: 0x00222B00
		public vtkArrayRename() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArrayRename.vtkArrayRename_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601885F RID: 100447 RVA: 0x00224944 File Offset: 0x00222B44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018860 RID: 100448
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_ClearAll_01(HandleRef pThis);

		/// <summary>
		/// Clear name mappings for all attribute types.
		/// </summary>
		// Token: 0x06018861 RID: 100449 RVA: 0x0022494F File Offset: 0x00222B4F
		public void ClearAll()
		{
			vtkArrayRename.vtkArrayRename_ClearAll_01(base.GetCppThis());
		}

		// Token: 0x06018862 RID: 100450
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_ClearCellMapping_02(HandleRef pThis);

		/// <summary>
		/// Get / Set array name mapping for CellData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018863 RID: 100451 RVA: 0x0022495E File Offset: 0x00222B5E
		public void ClearCellMapping()
		{
			vtkArrayRename.vtkArrayRename_ClearCellMapping_02(base.GetCppThis());
		}

		// Token: 0x06018864 RID: 100452
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_ClearEdgeMapping_03(HandleRef pThis);

		/// <summary>
		/// Get / Set array name mapping for EdgeData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018865 RID: 100453 RVA: 0x0022496D File Offset: 0x00222B6D
		public void ClearEdgeMapping()
		{
			vtkArrayRename.vtkArrayRename_ClearEdgeMapping_03(base.GetCppThis());
		}

		// Token: 0x06018866 RID: 100454
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_ClearFieldMapping_04(HandleRef pThis);

		/// <summary>
		/// Get / Set array name mapping for FieldData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018867 RID: 100455 RVA: 0x0022497C File Offset: 0x00222B7C
		public void ClearFieldMapping()
		{
			vtkArrayRename.vtkArrayRename_ClearFieldMapping_04(base.GetCppThis());
		}

		// Token: 0x06018868 RID: 100456
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_ClearMapping_05(HandleRef pThis, int attributeType);

		/// <summary>
		/// Clear mapping for the specified attribute type.
		/// </summary>
		// Token: 0x06018869 RID: 100457 RVA: 0x0022498B File Offset: 0x00222B8B
		public void ClearMapping(int attributeType)
		{
			vtkArrayRename.vtkArrayRename_ClearMapping_05(base.GetCppThis(), attributeType);
		}

		// Token: 0x0601886A RID: 100458
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_ClearPointMapping_06(HandleRef pThis);

		/// <summary>
		/// Get / Set array name mapping for PointData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x0601886B RID: 100459 RVA: 0x0022499B File Offset: 0x00222B9B
		public void ClearPointMapping()
		{
			vtkArrayRename.vtkArrayRename_ClearPointMapping_06(base.GetCppThis());
		}

		// Token: 0x0601886C RID: 100460
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_ClearRowMapping_07(HandleRef pThis);

		/// <summary>
		/// Get / Set array name mapping for RowData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x0601886D RID: 100461 RVA: 0x002249AA File Offset: 0x00222BAA
		public void ClearRowMapping()
		{
			vtkArrayRename.vtkArrayRename_ClearRowMapping_07(base.GetCppThis());
		}

		// Token: 0x0601886E RID: 100462
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_ClearVertexMapping_08(HandleRef pThis);

		/// <summary>
		/// Get / Set array name mapping for VertexData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x0601886F RID: 100463 RVA: 0x002249B9 File Offset: 0x00222BB9
		public void ClearVertexMapping()
		{
			vtkArrayRename.vtkArrayRename_ClearVertexMapping_08(base.GetCppThis());
		}

		// Token: 0x06018870 RID: 100464
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetArrayNewName_09(HandleRef pThis, int attributeType, int idx);

		/// <summary>
		/// Get the new array name from \p idx in \p attributeType field data.
		/// </summary>
		// Token: 0x06018871 RID: 100465 RVA: 0x002249C8 File Offset: 0x00222BC8
		public string GetArrayNewName(int attributeType, int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetArrayNewName_09(base.GetCppThis(), attributeType, idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018872 RID: 100466
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetArrayOriginalName_10(HandleRef pThis, int attributeType, int idx);

		/// <summary>
		/// Get the input array name from \p idx in \p attributeType field data.
		/// </summary>
		// Token: 0x06018873 RID: 100467 RVA: 0x00224A04 File Offset: 0x00222C04
		public string GetArrayOriginalName(int attributeType, int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetArrayOriginalName_10(base.GetCppThis(), attributeType, idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018874 RID: 100468
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetCellArrayNewName_11(HandleRef pThis, int idx);

		/// <summary>
		/// Get / Set array name mapping for CellData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018875 RID: 100469 RVA: 0x00224A40 File Offset: 0x00222C40
		public string GetCellArrayNewName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetCellArrayNewName_11(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018876 RID: 100470
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetCellArrayOriginalName_12(HandleRef pThis, int idx);

		/// <summary>
		/// Get / Set array name mapping for CellData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018877 RID: 100471 RVA: 0x00224A7C File Offset: 0x00222C7C
		public string GetCellArrayOriginalName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetCellArrayOriginalName_12(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018878 RID: 100472
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetEdgeArrayNewName_13(HandleRef pThis, int idx);

		/// <summary>
		/// Get / Set array name mapping for EdgeData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018879 RID: 100473 RVA: 0x00224AB8 File Offset: 0x00222CB8
		public string GetEdgeArrayNewName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetEdgeArrayNewName_13(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601887A RID: 100474
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetEdgeArrayOriginalName_14(HandleRef pThis, int idx);

		/// <summary>
		/// Get / Set array name mapping for EdgeData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x0601887B RID: 100475 RVA: 0x00224AF4 File Offset: 0x00222CF4
		public string GetEdgeArrayOriginalName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetEdgeArrayOriginalName_14(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601887C RID: 100476
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetFieldArrayNewName_15(HandleRef pThis, int idx);

		/// <summary>
		/// Get / Set array name mapping for FieldData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x0601887D RID: 100477 RVA: 0x00224B30 File Offset: 0x00222D30
		public string GetFieldArrayNewName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetFieldArrayNewName_15(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601887E RID: 100478
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetFieldArrayOriginalName_16(HandleRef pThis, int idx);

		/// <summary>
		/// Get / Set array name mapping for FieldData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x0601887F RID: 100479 RVA: 0x00224B6C File Offset: 0x00222D6C
		public string GetFieldArrayOriginalName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetFieldArrayOriginalName_16(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018880 RID: 100480
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayRename_GetNumberOfArrays_17(HandleRef pThis, int attributeType);

		/// <summary>
		/// Get number of arrays for specified attribute type.
		/// </summary>
		// Token: 0x06018881 RID: 100481 RVA: 0x00224BA8 File Offset: 0x00222DA8
		public int GetNumberOfArrays(int attributeType)
		{
			return vtkArrayRename.vtkArrayRename_GetNumberOfArrays_17(base.GetCppThis(), attributeType);
		}

		// Token: 0x06018882 RID: 100482
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayRename_GetNumberOfCellArrays_18(HandleRef pThis);

		/// <summary>
		/// Get / Set array name mapping for CellData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018883 RID: 100483 RVA: 0x00224BC8 File Offset: 0x00222DC8
		public int GetNumberOfCellArrays()
		{
			return vtkArrayRename.vtkArrayRename_GetNumberOfCellArrays_18(base.GetCppThis());
		}

		// Token: 0x06018884 RID: 100484
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayRename_GetNumberOfEdgeArrays_19(HandleRef pThis);

		/// <summary>
		/// Get / Set array name mapping for EdgeData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018885 RID: 100485 RVA: 0x00224BE8 File Offset: 0x00222DE8
		public int GetNumberOfEdgeArrays()
		{
			return vtkArrayRename.vtkArrayRename_GetNumberOfEdgeArrays_19(base.GetCppThis());
		}

		// Token: 0x06018886 RID: 100486
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayRename_GetNumberOfFieldArrays_20(HandleRef pThis);

		/// <summary>
		/// Get / Set array name mapping for FieldData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018887 RID: 100487 RVA: 0x00224C08 File Offset: 0x00222E08
		public int GetNumberOfFieldArrays()
		{
			return vtkArrayRename.vtkArrayRename_GetNumberOfFieldArrays_20(base.GetCppThis());
		}

		// Token: 0x06018888 RID: 100488
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayRename_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018889 RID: 100489 RVA: 0x00224C28 File Offset: 0x00222E28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArrayRename.vtkArrayRename_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x0601888A RID: 100490
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayRename_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601888B RID: 100491 RVA: 0x00224C48 File Offset: 0x00222E48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArrayRename.vtkArrayRename_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x0601888C RID: 100492
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayRename_GetNumberOfPointArrays_23(HandleRef pThis);

		/// <summary>
		/// Get / Set array name mapping for PointData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x0601888D RID: 100493 RVA: 0x00224C64 File Offset: 0x00222E64
		public int GetNumberOfPointArrays()
		{
			return vtkArrayRename.vtkArrayRename_GetNumberOfPointArrays_23(base.GetCppThis());
		}

		// Token: 0x0601888E RID: 100494
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayRename_GetNumberOfRowArrays_24(HandleRef pThis);

		/// <summary>
		/// Get / Set array name mapping for RowData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x0601888F RID: 100495 RVA: 0x00224C84 File Offset: 0x00222E84
		public int GetNumberOfRowArrays()
		{
			return vtkArrayRename.vtkArrayRename_GetNumberOfRowArrays_24(base.GetCppThis());
		}

		// Token: 0x06018890 RID: 100496
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayRename_GetNumberOfVertexArrays_25(HandleRef pThis);

		/// <summary>
		/// Get / Set array name mapping for VertexData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018891 RID: 100497 RVA: 0x00224CA4 File Offset: 0x00222EA4
		public int GetNumberOfVertexArrays()
		{
			return vtkArrayRename.vtkArrayRename_GetNumberOfVertexArrays_25(base.GetCppThis());
		}

		// Token: 0x06018892 RID: 100498
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetPointArrayNewName_26(HandleRef pThis, int idx);

		/// <summary>
		/// Get / Set array name mapping for PointData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018893 RID: 100499 RVA: 0x00224CC4 File Offset: 0x00222EC4
		public string GetPointArrayNewName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetPointArrayNewName_26(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018894 RID: 100500
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetPointArrayOriginalName_27(HandleRef pThis, int idx);

		/// <summary>
		/// Get / Set array name mapping for PointData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018895 RID: 100501 RVA: 0x00224D00 File Offset: 0x00222F00
		public string GetPointArrayOriginalName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetPointArrayOriginalName_27(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018896 RID: 100502
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetRowArrayNewName_28(HandleRef pThis, int idx);

		/// <summary>
		/// Get / Set array name mapping for RowData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018897 RID: 100503 RVA: 0x00224D3C File Offset: 0x00222F3C
		public string GetRowArrayNewName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetRowArrayNewName_28(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018898 RID: 100504
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetRowArrayOriginalName_29(HandleRef pThis, int idx);

		/// <summary>
		/// Get / Set array name mapping for RowData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x06018899 RID: 100505 RVA: 0x00224D78 File Offset: 0x00222F78
		public string GetRowArrayOriginalName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetRowArrayOriginalName_29(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601889A RID: 100506
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetVertexArrayNewName_30(HandleRef pThis, int idx);

		/// <summary>
		/// Get / Set array name mapping for VertexData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x0601889B RID: 100507 RVA: 0x00224DB4 File Offset: 0x00222FB4
		public string GetVertexArrayNewName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetVertexArrayNewName_30(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601889C RID: 100508
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_GetVertexArrayOriginalName_31(HandleRef pThis, int idx);

		/// <summary>
		/// Get / Set array name mapping for VertexData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x0601889D RID: 100509 RVA: 0x00224DF0 File Offset: 0x00222FF0
		public string GetVertexArrayOriginalName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayRename.vtkArrayRename_GetVertexArrayOriginalName_31(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601889E RID: 100510
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayRename_IsA_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601889F RID: 100511 RVA: 0x00224E2C File Offset: 0x0022302C
		public override int IsA(string type)
		{
			return vtkArrayRename.vtkArrayRename_IsA_32(base.GetCppThis(), type);
		}

		// Token: 0x060188A0 RID: 100512
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayRename_IsTypeOf_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188A1 RID: 100513 RVA: 0x00224E4C File Offset: 0x0022304C
		public new static int IsTypeOf(string type)
		{
			return vtkArrayRename.vtkArrayRename_IsTypeOf_33(type);
		}

		// Token: 0x060188A2 RID: 100514
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188A3 RID: 100515 RVA: 0x00224E68 File Offset: 0x00223068
		public new vtkArrayRename NewInstance()
		{
			vtkArrayRename result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayRename.vtkArrayRename_NewInstance_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayRename)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060188A4 RID: 100516
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayRename_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188A5 RID: 100517 RVA: 0x00224EC4 File Offset: 0x002230C4
		public new static vtkArrayRename SafeDownCast(vtkObjectBase o)
		{
			vtkArrayRename vtkArrayRename = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayRename.vtkArrayRename_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayRename = (vtkArrayRename)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayRename.Register(null);
				}
			}
			return vtkArrayRename;
		}

		// Token: 0x060188A6 RID: 100518
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetArrayName_37(HandleRef pThis, int attributeType, int idx, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Set the new array name from \p idx in \p attributeType field data.
		/// </summary>
		// Token: 0x060188A7 RID: 100519 RVA: 0x00224F43 File Offset: 0x00223143
		public void SetArrayName(int attributeType, int idx, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetArrayName_37(base.GetCppThis(), attributeType, idx, newName);
		}

		// Token: 0x060188A8 RID: 100520
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetArrayName_38(HandleRef pThis, int attributeType, [MarshalAs(UnmanagedType.LPUTF8Str)] string inputName, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Set the new array name from \p inputName in \p attributeType field data.
		/// </summary>
		// Token: 0x060188A9 RID: 100521 RVA: 0x00224F55 File Offset: 0x00223155
		public void SetArrayName(int attributeType, string inputName, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetArrayName_38(base.GetCppThis(), attributeType, inputName, newName);
		}

		// Token: 0x060188AA RID: 100522
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetCellArrayName_39(HandleRef pThis, int idx, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Get / Set array name mapping for CellData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x060188AB RID: 100523 RVA: 0x00224F67 File Offset: 0x00223167
		public void SetCellArrayName(int idx, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetCellArrayName_39(base.GetCppThis(), idx, newName);
		}

		// Token: 0x060188AC RID: 100524
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetCellArrayName_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string inputName, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Get / Set array name mapping for CellData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x060188AD RID: 100525 RVA: 0x00224F78 File Offset: 0x00223178
		public void SetCellArrayName(string inputName, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetCellArrayName_40(base.GetCppThis(), inputName, newName);
		}

		// Token: 0x060188AE RID: 100526
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetEdgeArrayName_41(HandleRef pThis, int idx, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Get / Set array name mapping for EdgeData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x060188AF RID: 100527 RVA: 0x00224F89 File Offset: 0x00223189
		public void SetEdgeArrayName(int idx, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetEdgeArrayName_41(base.GetCppThis(), idx, newName);
		}

		// Token: 0x060188B0 RID: 100528
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetEdgeArrayName_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string inputName, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Get / Set array name mapping for EdgeData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x060188B1 RID: 100529 RVA: 0x00224F9A File Offset: 0x0022319A
		public void SetEdgeArrayName(string inputName, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetEdgeArrayName_42(base.GetCppThis(), inputName, newName);
		}

		// Token: 0x060188B2 RID: 100530
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetFieldArrayName_43(HandleRef pThis, int idx, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Get / Set array name mapping for FieldData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x060188B3 RID: 100531 RVA: 0x00224FAB File Offset: 0x002231AB
		public void SetFieldArrayName(int idx, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetFieldArrayName_43(base.GetCppThis(), idx, newName);
		}

		// Token: 0x060188B4 RID: 100532
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetFieldArrayName_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string inputName, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Get / Set array name mapping for FieldData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x060188B5 RID: 100533 RVA: 0x00224FBC File Offset: 0x002231BC
		public void SetFieldArrayName(string inputName, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetFieldArrayName_44(base.GetCppThis(), inputName, newName);
		}

		// Token: 0x060188B6 RID: 100534
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetPointArrayName_45(HandleRef pThis, int idx, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Get / Set array name mapping for PointData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x060188B7 RID: 100535 RVA: 0x00224FCD File Offset: 0x002231CD
		public void SetPointArrayName(int idx, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetPointArrayName_45(base.GetCppThis(), idx, newName);
		}

		// Token: 0x060188B8 RID: 100536
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetPointArrayName_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string inputName, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Get / Set array name mapping for PointData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x060188B9 RID: 100537 RVA: 0x00224FDE File Offset: 0x002231DE
		public void SetPointArrayName(string inputName, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetPointArrayName_46(base.GetCppThis(), inputName, newName);
		}

		// Token: 0x060188BA RID: 100538
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetRowArrayName_47(HandleRef pThis, int idx, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Get / Set array name mapping for RowData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x060188BB RID: 100539 RVA: 0x00224FEF File Offset: 0x002231EF
		public void SetRowArrayName(int idx, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetRowArrayName_47(base.GetCppThis(), idx, newName);
		}

		// Token: 0x060188BC RID: 100540
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetRowArrayName_48(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string inputName, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Get / Set array name mapping for RowData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x060188BD RID: 100541 RVA: 0x00225000 File Offset: 0x00223200
		public void SetRowArrayName(string inputName, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetRowArrayName_48(base.GetCppThis(), inputName, newName);
		}

		// Token: 0x060188BE RID: 100542
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetVertexArrayName_49(HandleRef pThis, int idx, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Get / Set array name mapping for VertexData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x060188BF RID: 100543 RVA: 0x00225011 File Offset: 0x00223211
		public void SetVertexArrayName(int idx, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetVertexArrayName_49(base.GetCppThis(), idx, newName);
		}

		// Token: 0x060188C0 RID: 100544
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayRename_SetVertexArrayName_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string inputName, [MarshalAs(UnmanagedType.LPUTF8Str)] string newName);

		/// <summary>
		/// Get / Set array name mapping for VertexData.
		/// Forwarded to the corresponding generic method:
		/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
		/// </summary>
		// Token: 0x060188C1 RID: 100545 RVA: 0x00225022 File Offset: 0x00223222
		public void SetVertexArrayName(string inputName, string newName)
		{
			vtkArrayRename.vtkArrayRename_SetVertexArrayName_50(base.GetCppThis(), inputName, newName);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B28 RID: 6952
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayRename";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B29 RID: 6953
		public new static readonly string MRClassNameKey = "class vtkArrayRename";
	}
}
