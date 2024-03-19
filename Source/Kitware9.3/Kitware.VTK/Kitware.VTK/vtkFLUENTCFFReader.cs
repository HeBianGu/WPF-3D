using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFLUENTCFFReader
	/// </summary>
	/// <remarks>
	///    reads a dataset in Fluent CFF file format
	///
	/// vtkFLUENTCFFReader creates an unstructured grid dataset. It reads .cas.h5 and
	/// .dat.h5 files stored in FLUENT CFF format (hdf5).
	///
	/// @par Thanks:
	/// Original author : Arthur Piquet
	///
	/// This class is based on the vtkFLUENTReader class from Brian W. Dotson &amp;
	/// Terry E. Jordan (Department of Energy, National Energy Technology
	/// Laboratory) &amp; Douglas McCorkle (Iowa State University)
	///
	/// This class reads the HDF5 data in Fluent Format (face type structure)
	/// and converts it to VTK Format (cell type structure).
	/// This class could be improved for memory performance but the developer
	/// will need to rewrite entirely the structure of the class.
	/// Some piece of functionality lack in the HDF reading (overset, AMR tree,
	/// interface), no file available in order to code/test the structure.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFLUENTReader
	/// </seealso>
	// Token: 0x0200018C RID: 396
	public class vtkFLUENTCFFReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004D2D RID: 19757 RVA: 0x000707B3 File Offset: 0x0006E9B3
		static vtkFLUENTCFFReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFLUENTCFFReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFLUENTCFFReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004D2E RID: 19758 RVA: 0x000707DB File Offset: 0x0006E9DB
		public vtkFLUENTCFFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004D2F RID: 19759
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFLUENTCFFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004D30 RID: 19760 RVA: 0x000707EC File Offset: 0x0006E9EC
		public new static vtkFLUENTCFFReader New()
		{
			vtkFLUENTCFFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFLUENTCFFReader.vtkFLUENTCFFReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFLUENTCFFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004D31 RID: 19761 RVA: 0x00070840 File Offset: 0x0006EA40
		public vtkFLUENTCFFReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFLUENTCFFReader.vtkFLUENTCFFReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004D32 RID: 19762 RVA: 0x00070884 File Offset: 0x0006EA84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004D33 RID: 19763
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFLUENTCFFReader_DisableAllCellArrays_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off all cell arrays.
		/// </summary>
		// Token: 0x06004D34 RID: 19764 RVA: 0x0007088F File Offset: 0x0006EA8F
		public void DisableAllCellArrays()
		{
			vtkFLUENTCFFReader.vtkFLUENTCFFReader_DisableAllCellArrays_01(base.GetCppThis());
		}

		// Token: 0x06004D35 RID: 19765
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFLUENTCFFReader_EnableAllCellArrays_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off all cell arrays.
		/// </summary>
		// Token: 0x06004D36 RID: 19766 RVA: 0x0007089E File Offset: 0x0006EA9E
		public void EnableAllCellArrays()
		{
			vtkFLUENTCFFReader.vtkFLUENTCFFReader_EnableAllCellArrays_02(base.GetCppThis());
		}

		// Token: 0x06004D37 RID: 19767
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFLUENTCFFReader_GetCellArrayName_03(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the cell array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x06004D38 RID: 19768 RVA: 0x000708B0 File Offset: 0x0006EAB0
		public string GetCellArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkFLUENTCFFReader.vtkFLUENTCFFReader_GetCellArrayName_03(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004D39 RID: 19769
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFLUENTCFFReader_GetCellArrayStatus_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06004D3A RID: 19770 RVA: 0x000708EC File Offset: 0x0006EAEC
		public int GetCellArrayStatus(string name)
		{
			return vtkFLUENTCFFReader.vtkFLUENTCFFReader_GetCellArrayStatus_04(base.GetCppThis(), name);
		}

		// Token: 0x06004D3B RID: 19771
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkFLUENTCFFReader_GetFileName_05(HandleRef pThis);

		/// <summary>
		/// Specify the file name of the Fluent case file to read.
		/// </summary>
		// Token: 0x06004D3C RID: 19772 RVA: 0x0007090C File Offset: 0x0006EB0C
		public virtual string GetFileName()
		{
			return vtkFLUENTCFFReader.vtkFLUENTCFFReader_GetFileName_05(base.GetCppThis());
		}

		// Token: 0x06004D3D RID: 19773
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFLUENTCFFReader_GetNumberOfCellArrays_06(HandleRef pThis);

		/// <summary>
		/// Get the number of cell arrays available in the input.
		/// </summary>
		// Token: 0x06004D3E RID: 19774 RVA: 0x0007092C File Offset: 0x0006EB2C
		public int GetNumberOfCellArrays()
		{
			return vtkFLUENTCFFReader.vtkFLUENTCFFReader_GetNumberOfCellArrays_06(base.GetCppThis());
		}

		// Token: 0x06004D3F RID: 19775
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFLUENTCFFReader_GetNumberOfCells_07(HandleRef pThis);

		/// <summary>
		/// Get the total number of cells. The number of cells is only valid after a
		/// successful read of the data file is performed. Initial value is 0.
		/// </summary>
		// Token: 0x06004D40 RID: 19776 RVA: 0x0007094C File Offset: 0x0006EB4C
		public virtual long GetNumberOfCells()
		{
			return vtkFLUENTCFFReader.vtkFLUENTCFFReader_GetNumberOfCells_07(base.GetCppThis());
		}

		// Token: 0x06004D41 RID: 19777
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFLUENTCFFReader_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004D42 RID: 19778 RVA: 0x0007096C File Offset: 0x0006EB6C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFLUENTCFFReader.vtkFLUENTCFFReader_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06004D43 RID: 19779
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFLUENTCFFReader_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004D44 RID: 19780 RVA: 0x0007098C File Offset: 0x0006EB8C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFLUENTCFFReader.vtkFLUENTCFFReader_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06004D45 RID: 19781
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFLUENTCFFReader_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004D46 RID: 19782 RVA: 0x000709A8 File Offset: 0x0006EBA8
		public override int IsA(string type)
		{
			return vtkFLUENTCFFReader.vtkFLUENTCFFReader_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06004D47 RID: 19783
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFLUENTCFFReader_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004D48 RID: 19784 RVA: 0x000709C8 File Offset: 0x0006EBC8
		public new static int IsTypeOf(string type)
		{
			return vtkFLUENTCFFReader.vtkFLUENTCFFReader_IsTypeOf_11(type);
		}

		// Token: 0x06004D49 RID: 19785
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFLUENTCFFReader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004D4A RID: 19786 RVA: 0x000709E4 File Offset: 0x0006EBE4
		public new vtkFLUENTCFFReader NewInstance()
		{
			vtkFLUENTCFFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFLUENTCFFReader.vtkFLUENTCFFReader_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFLUENTCFFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004D4B RID: 19787
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFLUENTCFFReader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004D4C RID: 19788 RVA: 0x00070A40 File Offset: 0x0006EC40
		public new static vtkFLUENTCFFReader SafeDownCast(vtkObjectBase o)
		{
			vtkFLUENTCFFReader vtkFLUENTCFFReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFLUENTCFFReader.vtkFLUENTCFFReader_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFLUENTCFFReader = (vtkFLUENTCFFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFLUENTCFFReader.Register(null);
				}
			}
			return vtkFLUENTCFFReader;
		}

		// Token: 0x06004D4D RID: 19789
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFLUENTCFFReader_SetCellArrayStatus_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06004D4E RID: 19790 RVA: 0x00070ABF File Offset: 0x0006ECBF
		public void SetCellArrayStatus(string name, int status)
		{
			vtkFLUENTCFFReader.vtkFLUENTCFFReader_SetCellArrayStatus_15(base.GetCppThis(), name, status);
		}

		// Token: 0x06004D4F RID: 19791
		[DllImport("Kitware.VTK.IOFLUENTCFF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFLUENTCFFReader_SetFileName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the file name of the Fluent case file to read.
		/// </summary>
		// Token: 0x06004D50 RID: 19792 RVA: 0x00070AD0 File Offset: 0x0006ECD0
		public virtual void SetFileName(string _arg)
		{
			vtkFLUENTCFFReader.vtkFLUENTCFFReader_SetFileName_16(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000779 RID: 1913
		public new const string MRFullTypeName = "Kitware.VTK.vtkFLUENTCFFReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400077A RID: 1914
		public new static readonly string MRClassNameKey = "class vtkFLUENTCFFReader";
	}
}
