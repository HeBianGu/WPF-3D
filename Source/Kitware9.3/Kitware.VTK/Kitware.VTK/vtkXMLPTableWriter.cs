using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPTableWriter
	/// </summary>
	/// <remarks>
	///    Write PVTK XML UnstructuredGrid files.
	///
	/// vtkXMLPTableWriter writes the PVTK XML Table
	/// file format.  One table input can be written into a
	/// parallel file format with any number of pieces spread across files.
	/// The standard extension for this writer's file format is "pvtt".
	/// This writer uses vtkXMLTableWriter to write the
	/// individual piece files.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLTableWriter
	/// </seealso>
	// Token: 0x0200014E RID: 334
	public class vtkXMLPTableWriter : vtkXMLPDataObjectWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003FD3 RID: 16339 RVA: 0x0005DAFB File Offset: 0x0005BCFB
		static vtkXMLPTableWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPTableWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPTableWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003FD4 RID: 16340 RVA: 0x0005DB23 File Offset: 0x0005BD23
		public vtkXMLPTableWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003FD5 RID: 16341
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPTableWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FD6 RID: 16342 RVA: 0x0005DB34 File Offset: 0x0005BD34
		public new static vtkXMLPTableWriter New()
		{
			vtkXMLPTableWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPTableWriter.vtkXMLPTableWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPTableWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FD7 RID: 16343 RVA: 0x0005DB88 File Offset: 0x0005BD88
		public vtkXMLPTableWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPTableWriter.vtkXMLPTableWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003FD8 RID: 16344 RVA: 0x0005DBCC File Offset: 0x0005BDCC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003FD9 RID: 16345
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPTableWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06003FDA RID: 16346 RVA: 0x0005DBD8 File Offset: 0x0005BDD8
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLPTableWriter.vtkXMLPTableWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003FDB RID: 16347
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPTableWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x06003FDC RID: 16348 RVA: 0x0005DC14 File Offset: 0x0005BE14
		public new vtkTable GetInput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPTableWriter.vtkXMLPTableWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003FDD RID: 16349
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPTableWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FDE RID: 16350 RVA: 0x0005DC84 File Offset: 0x0005BE84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPTableWriter.vtkXMLPTableWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06003FDF RID: 16351
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPTableWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FE0 RID: 16352 RVA: 0x0005DCA4 File Offset: 0x0005BEA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPTableWriter.vtkXMLPTableWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06003FE1 RID: 16353
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPTableWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FE2 RID: 16354 RVA: 0x0005DCC0 File Offset: 0x0005BEC0
		public override int IsA(string type)
		{
			return vtkXMLPTableWriter.vtkXMLPTableWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06003FE3 RID: 16355
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPTableWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FE4 RID: 16356 RVA: 0x0005DCE0 File Offset: 0x0005BEE0
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPTableWriter.vtkXMLPTableWriter_IsTypeOf_06(type);
		}

		// Token: 0x06003FE5 RID: 16357
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPTableWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FE6 RID: 16358 RVA: 0x0005DCFC File Offset: 0x0005BEFC
		public new vtkXMLPTableWriter NewInstance()
		{
			vtkXMLPTableWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPTableWriter.vtkXMLPTableWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPTableWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003FE7 RID: 16359
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPTableWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FE8 RID: 16360 RVA: 0x0005DD58 File Offset: 0x0005BF58
		public new static vtkXMLPTableWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPTableWriter vtkXMLPTableWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPTableWriter.vtkXMLPTableWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPTableWriter = (vtkXMLPTableWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPTableWriter.Register(null);
				}
			}
			return vtkXMLPTableWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006E0 RID: 1760
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPTableWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006E1 RID: 1761
		public new static readonly string MRClassNameKey = "class vtkXMLPTableWriter";
	}
}
