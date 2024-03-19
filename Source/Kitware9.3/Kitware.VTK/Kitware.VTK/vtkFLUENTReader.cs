using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFLUENTReader
	/// </summary>
	/// <remarks>
	///    reads a dataset in Fluent file format
	///
	/// vtkFLUENTReader creates an unstructured grid dataset. It reads .cas and
	/// .dat files stored in FLUENT native format.
	///
	/// @par Thanks:
	/// Thanks to Brian W. Dotson &amp; Terry E. Jordan (Department of Energy, National
	/// Energy Technology Laboratory) &amp; Douglas McCorkle (Iowa State University)
	/// who developed this class.
	/// Please address all comments to Brian Dotson (brian.dotson@netl.doe.gov) &amp;
	/// </remarks>
	/// <seealso>
	/// Terry Jordan (terry.jordan.netl.doe.gov)
	/// &amp; Doug McCorkle (mccdo@iastate.edu)
	///
	///
	///
	/// vtkGAMBITReader
	/// </seealso>
	// Token: 0x020001FE RID: 510
	public class vtkFLUENTReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006232 RID: 25138 RVA: 0x0008D5CA File Offset: 0x0008B7CA
		static vtkFLUENTReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFLUENTReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFLUENTReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006233 RID: 25139 RVA: 0x0008D5F2 File Offset: 0x0008B7F2
		public vtkFLUENTReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006234 RID: 25140
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFLUENTReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006235 RID: 25141 RVA: 0x0008D600 File Offset: 0x0008B800
		public new static vtkFLUENTReader New()
		{
			vtkFLUENTReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFLUENTReader.vtkFLUENTReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFLUENTReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006236 RID: 25142 RVA: 0x0008D654 File Offset: 0x0008B854
		public vtkFLUENTReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFLUENTReader.vtkFLUENTReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006237 RID: 25143 RVA: 0x0008D698 File Offset: 0x0008B898
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006238 RID: 25144
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFLUENTReader_DisableAllCellArrays_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off all cell arrays.
		/// </summary>
		// Token: 0x06006239 RID: 25145 RVA: 0x0008D6A3 File Offset: 0x0008B8A3
		public void DisableAllCellArrays()
		{
			vtkFLUENTReader.vtkFLUENTReader_DisableAllCellArrays_01(base.GetCppThis());
		}

		// Token: 0x0600623A RID: 25146
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFLUENTReader_EnableAllCellArrays_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off all cell arrays.
		/// </summary>
		// Token: 0x0600623B RID: 25147 RVA: 0x0008D6B2 File Offset: 0x0008B8B2
		public void EnableAllCellArrays()
		{
			vtkFLUENTReader.vtkFLUENTReader_EnableAllCellArrays_02(base.GetCppThis());
		}

		// Token: 0x0600623C RID: 25148
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFLUENTReader_GetCellArrayName_03(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the cell array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x0600623D RID: 25149 RVA: 0x0008D6C4 File Offset: 0x0008B8C4
		public string GetCellArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkFLUENTReader.vtkFLUENTReader_GetCellArrayName_03(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600623E RID: 25150
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFLUENTReader_GetCellArrayStatus_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x0600623F RID: 25151 RVA: 0x0008D700 File Offset: 0x0008B900
		public int GetCellArrayStatus(string name)
		{
			return vtkFLUENTReader.vtkFLUENTReader_GetCellArrayStatus_04(base.GetCppThis(), name);
		}

		// Token: 0x06006240 RID: 25152
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFLUENTReader_GetDataByteOrder_05(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian. Not used when reading
		/// text files.
		/// </summary>
		// Token: 0x06006241 RID: 25153 RVA: 0x0008D720 File Offset: 0x0008B920
		public int GetDataByteOrder()
		{
			return vtkFLUENTReader.vtkFLUENTReader_GetDataByteOrder_05(base.GetCppThis());
		}

		// Token: 0x06006242 RID: 25154
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFLUENTReader_GetDataByteOrderAsString_06(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian. Not used when reading
		/// text files.
		/// </summary>
		// Token: 0x06006243 RID: 25155 RVA: 0x0008D740 File Offset: 0x0008B940
		public string GetDataByteOrderAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkFLUENTReader.vtkFLUENTReader_GetDataByteOrderAsString_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006244 RID: 25156
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFLUENTReader_GetFileName_07(HandleRef pThis);

		/// <summary>
		/// Specify the file name of the Fluent case file to read.
		/// </summary>
		// Token: 0x06006245 RID: 25157 RVA: 0x0008D77C File Offset: 0x0008B97C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkFLUENTReader.vtkFLUENTReader_GetFileName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006246 RID: 25158
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFLUENTReader_GetNumberOfCellArrays_08(HandleRef pThis);

		/// <summary>
		/// Get the number of cell arrays available in the input.
		/// </summary>
		// Token: 0x06006247 RID: 25159 RVA: 0x0008D7B8 File Offset: 0x0008B9B8
		public int GetNumberOfCellArrays()
		{
			return vtkFLUENTReader.vtkFLUENTReader_GetNumberOfCellArrays_08(base.GetCppThis());
		}

		// Token: 0x06006248 RID: 25160
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFLUENTReader_GetNumberOfCells_09(HandleRef pThis);

		/// <summary>
		/// Get the total number of cells. The number of cells is only valid after a
		/// successful read of the data file is performed. Initial value is 0.
		/// </summary>
		// Token: 0x06006249 RID: 25161 RVA: 0x0008D7D8 File Offset: 0x0008B9D8
		public virtual long GetNumberOfCells()
		{
			return vtkFLUENTReader.vtkFLUENTReader_GetNumberOfCells_09(base.GetCppThis());
		}

		// Token: 0x0600624A RID: 25162
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFLUENTReader_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600624B RID: 25163 RVA: 0x0008D7F8 File Offset: 0x0008B9F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFLUENTReader.vtkFLUENTReader_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0600624C RID: 25164
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFLUENTReader_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600624D RID: 25165 RVA: 0x0008D818 File Offset: 0x0008BA18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFLUENTReader.vtkFLUENTReader_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0600624E RID: 25166
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFLUENTReader_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600624F RID: 25167 RVA: 0x0008D834 File Offset: 0x0008BA34
		public override int IsA(string type)
		{
			return vtkFLUENTReader.vtkFLUENTReader_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06006250 RID: 25168
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFLUENTReader_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006251 RID: 25169 RVA: 0x0008D854 File Offset: 0x0008BA54
		public new static int IsTypeOf(string type)
		{
			return vtkFLUENTReader.vtkFLUENTReader_IsTypeOf_13(type);
		}

		// Token: 0x06006252 RID: 25170
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFLUENTReader_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006253 RID: 25171 RVA: 0x0008D870 File Offset: 0x0008BA70
		public new vtkFLUENTReader NewInstance()
		{
			vtkFLUENTReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFLUENTReader.vtkFLUENTReader_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFLUENTReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006254 RID: 25172
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFLUENTReader_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006255 RID: 25173 RVA: 0x0008D8CC File Offset: 0x0008BACC
		public new static vtkFLUENTReader SafeDownCast(vtkObjectBase o)
		{
			vtkFLUENTReader vtkFLUENTReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFLUENTReader.vtkFLUENTReader_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFLUENTReader = (vtkFLUENTReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFLUENTReader.Register(null);
				}
			}
			return vtkFLUENTReader;
		}

		// Token: 0x06006256 RID: 25174
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFLUENTReader_SetCellArrayStatus_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06006257 RID: 25175 RVA: 0x0008D94B File Offset: 0x0008BB4B
		public void SetCellArrayStatus(string name, int status)
		{
			vtkFLUENTReader.vtkFLUENTReader_SetCellArrayStatus_17(base.GetCppThis(), name, status);
		}

		// Token: 0x06006258 RID: 25176
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFLUENTReader_SetDataByteOrder_18(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian. Not used when reading
		/// text files.
		/// </summary>
		// Token: 0x06006259 RID: 25177 RVA: 0x0008D95C File Offset: 0x0008BB5C
		public void SetDataByteOrder(int arg0)
		{
			vtkFLUENTReader.vtkFLUENTReader_SetDataByteOrder_18(base.GetCppThis(), arg0);
		}

		// Token: 0x0600625A RID: 25178
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFLUENTReader_SetDataByteOrderToBigEndian_19(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian. Not used when reading
		/// text files.
		/// </summary>
		// Token: 0x0600625B RID: 25179 RVA: 0x0008D96C File Offset: 0x0008BB6C
		public void SetDataByteOrderToBigEndian()
		{
			vtkFLUENTReader.vtkFLUENTReader_SetDataByteOrderToBigEndian_19(base.GetCppThis());
		}

		// Token: 0x0600625C RID: 25180
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFLUENTReader_SetDataByteOrderToLittleEndian_20(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian. Not used when reading
		/// text files.
		/// </summary>
		// Token: 0x0600625D RID: 25181 RVA: 0x0008D97B File Offset: 0x0008BB7B
		public void SetDataByteOrderToLittleEndian()
		{
			vtkFLUENTReader.vtkFLUENTReader_SetDataByteOrderToLittleEndian_20(base.GetCppThis());
		}

		// Token: 0x0600625E RID: 25182
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFLUENTReader_SetFileName_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the file name of the Fluent case file to read.
		/// </summary>
		// Token: 0x0600625F RID: 25183 RVA: 0x0008D98A File Offset: 0x0008BB8A
		public virtual void SetFileName(string _arg)
		{
			vtkFLUENTReader.vtkFLUENTReader_SetFileName_21(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008C6 RID: 2246
		public new const string MRFullTypeName = "Kitware.VTK.vtkFLUENTReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008C7 RID: 2247
		public new static readonly string MRClassNameKey = "class vtkFLUENTReader";
	}
}
