using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLTableReader
	/// </summary>
	/// <remarks>
	///    Read VTK XML Table files.
	///
	/// vtkXMLTableReader provides a functionality for reading .vtt files as
	/// vtkTable
	///
	/// </remarks>
	// Token: 0x020006E7 RID: 1767
	public class vtkXMLTableReader : vtkXMLReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012A63 RID: 76387 RVA: 0x001A37CF File Offset: 0x001A19CF
		static vtkXMLTableReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLTableReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLTableReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012A64 RID: 76388 RVA: 0x001A37F7 File Offset: 0x001A19F7
		public vtkXMLTableReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012A65 RID: 76389
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTableReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A66 RID: 76390 RVA: 0x001A3808 File Offset: 0x001A1A08
		public new static vtkXMLTableReader New()
		{
			vtkXMLTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLTableReader.vtkXMLTableReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A67 RID: 76391 RVA: 0x001A385C File Offset: 0x001A1A5C
		public vtkXMLTableReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLTableReader.vtkXMLTableReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012A68 RID: 76392 RVA: 0x001A38A0 File Offset: 0x001A1AA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012A69 RID: 76393
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTableReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		/// <summary>
		/// For the specified port, copy the information this reader sets up in
		/// SetupOutputInformation to outInfo
		/// </summary>
		// Token: 0x06012A6A RID: 76394 RVA: 0x001A38AC File Offset: 0x001A1AAC
		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLTableReader.vtkXMLTableReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		// Token: 0x06012A6B RID: 76395
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLTableReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A6C RID: 76396 RVA: 0x001A38DC File Offset: 0x001A1ADC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLTableReader.vtkXMLTableReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012A6D RID: 76397
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLTableReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A6E RID: 76398 RVA: 0x001A38FC File Offset: 0x001A1AFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLTableReader.vtkXMLTableReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06012A6F RID: 76399
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLTableReader_GetNumberOfPieces_04(HandleRef pThis);

		/// <summary>
		/// Get the number of pieces in the file
		/// </summary>
		// Token: 0x06012A70 RID: 76400 RVA: 0x001A3918 File Offset: 0x001A1B18
		public long GetNumberOfPieces()
		{
			return vtkXMLTableReader.vtkXMLTableReader_GetNumberOfPieces_04(base.GetCppThis());
		}

		// Token: 0x06012A71 RID: 76401
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLTableReader_GetNumberOfRows_05(HandleRef pThis);

		/// <summary>
		/// Get the number of rows in the output.
		/// </summary>
		// Token: 0x06012A72 RID: 76402 RVA: 0x001A3938 File Offset: 0x001A1B38
		public long GetNumberOfRows()
		{
			return vtkXMLTableReader.vtkXMLTableReader_GetNumberOfRows_05(base.GetCppThis());
		}

		// Token: 0x06012A73 RID: 76403
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTableReader_GetOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012A74 RID: 76404 RVA: 0x001A3958 File Offset: 0x001A1B58
		public vtkTable GetOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLTableReader.vtkXMLTableReader_GetOutput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012A75 RID: 76405
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTableReader_GetOutput_07(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012A76 RID: 76406 RVA: 0x001A39C8 File Offset: 0x001A1BC8
		public vtkTable GetOutput(int idx)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLTableReader.vtkXMLTableReader_GetOutput_07(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012A77 RID: 76407
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLTableReader_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A78 RID: 76408 RVA: 0x001A3A38 File Offset: 0x001A1C38
		public override int IsA(string type)
		{
			return vtkXMLTableReader.vtkXMLTableReader_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06012A79 RID: 76409
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLTableReader_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A7A RID: 76410 RVA: 0x001A3A58 File Offset: 0x001A1C58
		public new static int IsTypeOf(string type)
		{
			return vtkXMLTableReader.vtkXMLTableReader_IsTypeOf_09(type);
		}

		// Token: 0x06012A7B RID: 76411
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTableReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A7C RID: 76412 RVA: 0x001A3A74 File Offset: 0x001A1C74
		public new vtkXMLTableReader NewInstance()
		{
			vtkXMLTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLTableReader.vtkXMLTableReader_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012A7D RID: 76413
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTableReader_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A7E RID: 76414 RVA: 0x001A3AD0 File Offset: 0x001A1CD0
		public new static vtkXMLTableReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLTableReader vtkXMLTableReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLTableReader.vtkXMLTableReader_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLTableReader = (vtkXMLTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLTableReader.Register(null);
				}
			}
			return vtkXMLTableReader;
		}

		// Token: 0x06012A7F RID: 76415
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTableReader_SetupUpdateExtent_13(HandleRef pThis, int piece, int numberOfPieces);

		/// <summary>
		/// Setup the reader as if the given update extent were requested by
		/// its output.  This can be used after an UpdateInformation to
		/// validate GetNumberOfPoints() and GetNumberOfCells() without
		/// actually reading data.
		/// </summary>
		// Token: 0x06012A80 RID: 76416 RVA: 0x001A3B4F File Offset: 0x001A1D4F
		public void SetupUpdateExtent(int piece, int numberOfPieces)
		{
			vtkXMLTableReader.vtkXMLTableReader_SetupUpdateExtent_13(base.GetCppThis(), piece, numberOfPieces);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400157F RID: 5503
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLTableReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001580 RID: 5504
		public new static readonly string MRClassNameKey = "class vtkXMLTableReader";
	}
}
