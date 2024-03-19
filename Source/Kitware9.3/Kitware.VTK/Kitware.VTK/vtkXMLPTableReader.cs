using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPTableReader
	/// </summary>
	/// <remarks>
	///    Read PVTK XML Table files.
	///
	/// vtkXMLPTableReader reads the PVTK XML Table
	/// file format.  This reads the parallel format's summary file and
	/// then uses vtkXMLTableReader to read data from the
	/// individual Table piece files.  Streaming is supported.
	/// The standard extension for this reader's file format is "pvtt".
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLTableReader
	/// </seealso>
	// Token: 0x020006DB RID: 1755
	public class vtkXMLPTableReader : vtkXMLPDataObjectReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012947 RID: 76103 RVA: 0x001A1587 File Offset: 0x0019F787
		static vtkXMLPTableReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPTableReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPTableReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012948 RID: 76104 RVA: 0x001A15AF File Offset: 0x0019F7AF
		public vtkXMLPTableReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012949 RID: 76105
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPTableReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601294A RID: 76106 RVA: 0x001A15C0 File Offset: 0x0019F7C0
		public new static vtkXMLPTableReader New()
		{
			vtkXMLPTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPTableReader.vtkXMLPTableReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601294B RID: 76107 RVA: 0x001A1614 File Offset: 0x0019F814
		public vtkXMLPTableReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPTableReader.vtkXMLPTableReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601294C RID: 76108 RVA: 0x001A1658 File Offset: 0x0019F858
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601294D RID: 76109
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPTableReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		/// <summary>
		/// For the specified port, copy the information this reader sets up in
		/// SetupOutputInformation to outInfo
		/// </summary>
		// Token: 0x0601294E RID: 76110 RVA: 0x001A1664 File Offset: 0x0019F864
		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLPTableReader.vtkXMLPTableReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		// Token: 0x0601294F RID: 76111
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPTableReader_GetColumnArrayName_02(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the column with the given index in
		/// the input.
		/// </summary>
		// Token: 0x06012950 RID: 76112 RVA: 0x001A1694 File Offset: 0x0019F894
		public new string GetColumnArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLPTableReader.vtkXMLPTableReader_GetColumnArrayName_02(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012951 RID: 76113
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPTableReader_GetColumnArrayStatus_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the column array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06012952 RID: 76114 RVA: 0x001A16D0 File Offset: 0x0019F8D0
		public new int GetColumnArrayStatus(string name)
		{
			return vtkXMLPTableReader.vtkXMLPTableReader_GetColumnArrayStatus_03(base.GetCppThis(), name);
		}

		// Token: 0x06012953 RID: 76115
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPTableReader_GetColumnSelection_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x06012954 RID: 76116 RVA: 0x001A16F0 File Offset: 0x0019F8F0
		public virtual vtkDataArraySelection GetColumnSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPTableReader.vtkXMLPTableReader_GetColumnSelection_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06012955 RID: 76117
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPTableReader_GetNumberOfColumnArrays_05(HandleRef pThis);

		/// <summary>
		/// Get the number of columns arrays available in the input.
		/// </summary>
		// Token: 0x06012956 RID: 76118 RVA: 0x001A1760 File Offset: 0x0019F960
		public new int GetNumberOfColumnArrays()
		{
			return vtkXMLPTableReader.vtkXMLPTableReader_GetNumberOfColumnArrays_05(base.GetCppThis());
		}

		// Token: 0x06012957 RID: 76119
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPTableReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012958 RID: 76120 RVA: 0x001A1780 File Offset: 0x0019F980
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPTableReader.vtkXMLPTableReader_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06012959 RID: 76121
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPTableReader_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601295A RID: 76122 RVA: 0x001A17A0 File Offset: 0x0019F9A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPTableReader.vtkXMLPTableReader_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601295B RID: 76123
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPTableReader_GetOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x0601295C RID: 76124 RVA: 0x001A17BC File Offset: 0x0019F9BC
		public vtkTable GetOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPTableReader.vtkXMLPTableReader_GetOutput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x0601295D RID: 76125
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPTableReader_GetOutput_09(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x0601295E RID: 76126 RVA: 0x001A182C File Offset: 0x0019FA2C
		public vtkTable GetOutput(int idx)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPTableReader.vtkXMLPTableReader_GetOutput_09(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x0601295F RID: 76127
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPTableReader_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012960 RID: 76128 RVA: 0x001A189C File Offset: 0x0019FA9C
		public override int IsA(string type)
		{
			return vtkXMLPTableReader.vtkXMLPTableReader_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06012961 RID: 76129
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPTableReader_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012962 RID: 76130 RVA: 0x001A18BC File Offset: 0x0019FABC
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPTableReader.vtkXMLPTableReader_IsTypeOf_11(type);
		}

		// Token: 0x06012963 RID: 76131
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPTableReader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012964 RID: 76132 RVA: 0x001A18D8 File Offset: 0x0019FAD8
		public new vtkXMLPTableReader NewInstance()
		{
			vtkXMLPTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPTableReader.vtkXMLPTableReader_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012965 RID: 76133
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPTableReader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012966 RID: 76134 RVA: 0x001A1934 File Offset: 0x0019FB34
		public new static vtkXMLPTableReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPTableReader vtkXMLPTableReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPTableReader.vtkXMLPTableReader_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPTableReader = (vtkXMLPTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPTableReader.Register(null);
				}
			}
			return vtkXMLPTableReader;
		}

		// Token: 0x06012967 RID: 76135
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPTableReader_SetColumnArrayStatus_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the column array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06012968 RID: 76136 RVA: 0x001A19B3 File Offset: 0x0019FBB3
		public new void SetColumnArrayStatus(string name, int status)
		{
			vtkXMLPTableReader.vtkXMLPTableReader_SetColumnArrayStatus_15(base.GetCppThis(), name, status);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001567 RID: 5479
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPTableReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001568 RID: 5480
		public new static readonly string MRClassNameKey = "class vtkXMLPTableReader";
	}
}
