using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTecplotReader
	/// </summary>
	/// <remarks>
	///    A concrete class to read an ASCII Tecplot file.
	///
	///
	///  vtkTecplotReader parses an ASCII Tecplot file to get a vtkMultiBlockDataSet
	///  object made up of several vtkDataSet objects, of which each is of type
	///  either vtkStructuredGrid or vtkUnstructuredGrid. Each vtkDataSet object
	///  maintains the geometry, topology, and some associated attributes describing
	///  physical properties.
	///
	///  Tecplot treats 3D coordinates (only one or two coordinates might be
	///  explicitly specified in a file) as variables too, whose names (e.g.,
	///  'X' / 'x' / 'I', 'Y' / 'y' / 'J', 'Z' / 'z' / 'K') are provided in the
	///  variables list (the 'VARIABLES' section). These names are then followed
	///  in the list by those of other traditional variables or attributes (node-
	///  based and / or cell-based data with the mode specified via token 'VAR
	///  LOCATION', to be extracted to create vtkPointData and / or vtkCellData).
	///  Each zone described afterwards (in the 'ZONE's section) provides the
	///  specific values of the aforementioned variables (including 3D coordinates),
	///  in the same order as indicated by the variable-names list, through either
	///  POINT-packing (i.e., tuple-based storage) or BLOCK-packing (component-based
	///  storage). In particular, the first / description line of each zone tells
	///  the type of all the constituent cells as the connectivity / topology
	///  information. In other words, the entire dataset is made up of multiple zones
	///  (blocks), of which each maintains a set of cells of the same type ('BRICK',
	///  'TRIANGLE', 'QUADRILATERAL', 'TETRAHEDRON', and 'POINT' in Tecplot terms).
	///  In addition, the description line of each zone specifies the zone name,
	///  dimensionality information (size of each dimension for a structured zone),
	///  number of nodes, and number of cells. Information about the file format is
	///  available at http://download.tecplot.com/360/dataformat.pdf.
	///
	/// @warning
	///  vtkTecplotReader is currently a simplified ASCII Tecplot reader and some
	///  functionalities (e.g., extraction of sections 'GEOMETRY', 'TEXT', and 'DATA
	///  SETAUXDATA', access to multiple time steps, in addition to the construction
	///  of vtkRectilinearGrid and vtkImageData objects) are not supported.
	///
	/// @par Thanks:
	///  This class is a VTK implementation of VisIt's ASCII Tecplot reader.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkPoints vtkStructuredGrid vtkUnstructuredGrid vtkPointData vtkCellData
	///  vtkDataSet vtkMultiBlockDataSet
	/// </seealso>
	// Token: 0x02000214 RID: 532
	public class vtkTecplotReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600655C RID: 25948 RVA: 0x00091CE5 File Offset: 0x0008FEE5
		static vtkTecplotReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTecplotReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTecplotReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600655D RID: 25949 RVA: 0x00091D0D File Offset: 0x0008FF0D
		public vtkTecplotReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600655E RID: 25950
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTecplotReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600655F RID: 25951 RVA: 0x00091D1C File Offset: 0x0008FF1C
		public new static vtkTecplotReader New()
		{
			vtkTecplotReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTecplotReader.vtkTecplotReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTecplotReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006560 RID: 25952 RVA: 0x00091D70 File Offset: 0x0008FF70
		public vtkTecplotReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTecplotReader.vtkTecplotReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006561 RID: 25953 RVA: 0x00091DB4 File Offset: 0x0008FFB4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006562 RID: 25954
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTecplotReader_GetBlockName_01(HandleRef pThis, int blockIdx);

		/// <summary>
		/// Get the name of a block specified by a zero-based index. nullptr is returned
		/// for an invalid block index.
		/// </summary>
		// Token: 0x06006563 RID: 25955 RVA: 0x00091DC0 File Offset: 0x0008FFC0
		public string GetBlockName(int blockIdx)
		{
			string s = Marshal.PtrToStringAnsi(vtkTecplotReader.vtkTecplotReader_GetBlockName_01(base.GetCppThis(), blockIdx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006564 RID: 25956
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTecplotReader_GetDataArrayName_02(HandleRef pThis, int arrayIdx);

		/// <summary>
		/// Get the name of a data array specified by the zero-based index (arrayIdx).
		/// </summary>
		// Token: 0x06006565 RID: 25957 RVA: 0x00091DFC File Offset: 0x0008FFFC
		public string GetDataArrayName(int arrayIdx)
		{
			string s = Marshal.PtrToStringAnsi(vtkTecplotReader.vtkTecplotReader_GetDataArrayName_02(base.GetCppThis(), arrayIdx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006566 RID: 25958
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTecplotReader_GetDataArrayStatus_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arayName);

		/// <summary>
		/// Get the status of a specific data array (0: un-selected; 1: selected).
		/// </summary>
		// Token: 0x06006567 RID: 25959 RVA: 0x00091E38 File Offset: 0x00090038
		public int GetDataArrayStatus(string arayName)
		{
			return vtkTecplotReader.vtkTecplotReader_GetDataArrayStatus_03(base.GetCppThis(), arayName);
		}

		// Token: 0x06006568 RID: 25960
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTecplotReader_GetDataAttributeName_04(HandleRef pThis, int attrIndx);

		/// <summary>
		/// Get the name of a zero-based data attribute (not 3D coordinates). nullptr is
		/// returned for an invalid attribute index.
		/// </summary>
		// Token: 0x06006569 RID: 25961 RVA: 0x00091E58 File Offset: 0x00090058
		public string GetDataAttributeName(int attrIndx)
		{
			string s = Marshal.PtrToStringAnsi(vtkTecplotReader.vtkTecplotReader_GetDataAttributeName_04(base.GetCppThis(), attrIndx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600656A RID: 25962
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTecplotReader_GetDataTitle_05(HandleRef pThis);

		/// <summary>
		/// Get the Tecplot data title.
		/// </summary>
		// Token: 0x0600656B RID: 25963 RVA: 0x00091E94 File Offset: 0x00090094
		public string GetDataTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkTecplotReader.vtkTecplotReader_GetDataTitle_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600656C RID: 25964
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTecplotReader_GetNumberOfBlocks_06(HandleRef pThis);

		/// <summary>
		/// Get the number of blocks (i.e., zones in Tecplot terms).
		/// </summary>
		// Token: 0x0600656D RID: 25965 RVA: 0x00091ED0 File Offset: 0x000900D0
		public int GetNumberOfBlocks()
		{
			return vtkTecplotReader.vtkTecplotReader_GetNumberOfBlocks_06(base.GetCppThis());
		}

		// Token: 0x0600656E RID: 25966
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTecplotReader_GetNumberOfDataArrays_07(HandleRef pThis);

		/// <summary>
		/// Get the number of all data attributes (point data and cell data).
		/// </summary>
		// Token: 0x0600656F RID: 25967 RVA: 0x00091EF0 File Offset: 0x000900F0
		public int GetNumberOfDataArrays()
		{
			return vtkTecplotReader.vtkTecplotReader_GetNumberOfDataArrays_07(base.GetCppThis());
		}

		// Token: 0x06006570 RID: 25968
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTecplotReader_GetNumberOfDataAttributes_08(HandleRef pThis);

		/// <summary>
		/// Get the number of standard data attributes (node-based and cell-based),
		/// excluding 3D coordinates.
		/// </summary>
		// Token: 0x06006571 RID: 25969 RVA: 0x00091F10 File Offset: 0x00090110
		public int GetNumberOfDataAttributes()
		{
			return vtkTecplotReader.vtkTecplotReader_GetNumberOfDataAttributes_08(base.GetCppThis());
		}

		// Token: 0x06006572 RID: 25970
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTecplotReader_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006573 RID: 25971 RVA: 0x00091F30 File Offset: 0x00090130
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTecplotReader.vtkTecplotReader_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06006574 RID: 25972
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTecplotReader_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006575 RID: 25973 RVA: 0x00091F50 File Offset: 0x00090150
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTecplotReader.vtkTecplotReader_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06006576 RID: 25974
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTecplotReader_GetNumberOfVariables_11(HandleRef pThis);

		/// <summary>
		/// Get the number of all variables (including 3D coordinates).
		/// </summary>
		// Token: 0x06006577 RID: 25975 RVA: 0x00091F6C File Offset: 0x0009016C
		public virtual int GetNumberOfVariables()
		{
			return vtkTecplotReader.vtkTecplotReader_GetNumberOfVariables_11(base.GetCppThis());
		}

		// Token: 0x06006578 RID: 25976
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTecplotReader_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006579 RID: 25977 RVA: 0x00091F8C File Offset: 0x0009018C
		public override int IsA(string type)
		{
			return vtkTecplotReader.vtkTecplotReader_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600657A RID: 25978
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTecplotReader_IsDataAttributeCellBased_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string attrName);

		/// <summary>
		/// Get the type (0 for node-based and 1 for cell-based) of a specified data
		/// attribute (not 3D coordinates). -1 is returned for an invalid attribute
		/// name.
		/// </summary>
		// Token: 0x0600657B RID: 25979 RVA: 0x00091FAC File Offset: 0x000901AC
		public int IsDataAttributeCellBased(string attrName)
		{
			return vtkTecplotReader.vtkTecplotReader_IsDataAttributeCellBased_13(base.GetCppThis(), attrName);
		}

		// Token: 0x0600657C RID: 25980
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTecplotReader_IsDataAttributeCellBased_14(HandleRef pThis, int attrIndx);

		/// <summary>
		/// Get the type (0 for node-based and 1 for cell-based) of a specified data
		/// attribute (not 3D coordinates). -1 is returned for an invalid attribute
		/// index.
		/// </summary>
		// Token: 0x0600657D RID: 25981 RVA: 0x00091FCC File Offset: 0x000901CC
		public int IsDataAttributeCellBased(int attrIndx)
		{
			return vtkTecplotReader.vtkTecplotReader_IsDataAttributeCellBased_14(base.GetCppThis(), attrIndx);
		}

		// Token: 0x0600657E RID: 25982
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTecplotReader_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600657F RID: 25983 RVA: 0x00091FEC File Offset: 0x000901EC
		public new static int IsTypeOf(string type)
		{
			return vtkTecplotReader.vtkTecplotReader_IsTypeOf_15(type);
		}

		// Token: 0x06006580 RID: 25984
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTecplotReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006581 RID: 25985 RVA: 0x00092008 File Offset: 0x00090208
		public new vtkTecplotReader NewInstance()
		{
			vtkTecplotReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTecplotReader.vtkTecplotReader_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTecplotReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006582 RID: 25986
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTecplotReader_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006583 RID: 25987 RVA: 0x00092064 File Offset: 0x00090264
		public new static vtkTecplotReader SafeDownCast(vtkObjectBase o)
		{
			vtkTecplotReader vtkTecplotReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTecplotReader.vtkTecplotReader_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTecplotReader = (vtkTecplotReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTecplotReader.Register(null);
				}
			}
			return vtkTecplotReader;
		}

		// Token: 0x06006584 RID: 25988
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotReader_SetDataArrayStatus_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arayName, int bChecked);

		/// <summary>
		/// Set the status of a specific data array (0: de-select; 1: select) specified
		/// by the name.
		/// </summary>
		// Token: 0x06006585 RID: 25989 RVA: 0x000920E3 File Offset: 0x000902E3
		public void SetDataArrayStatus(string arayName, int bChecked)
		{
			vtkTecplotReader.vtkTecplotReader_SetDataArrayStatus_19(base.GetCppThis(), arayName, bChecked);
		}

		// Token: 0x06006586 RID: 25990
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotReader_SetFileName_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fileName);

		/// <summary>
		/// Specify a Tecplot ASCII file for data loading.
		/// </summary>
		// Token: 0x06006587 RID: 25991 RVA: 0x000920F4 File Offset: 0x000902F4
		public void SetFileName(string fileName)
		{
			vtkTecplotReader.vtkTecplotReader_SetFileName_20(base.GetCppThis(), fileName);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400090B RID: 2315
		public new const string MRFullTypeName = "Kitware.VTK.vtkTecplotReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400090C RID: 2316
		public new static readonly string MRClassNameKey = "class vtkTecplotReader";
	}
}
