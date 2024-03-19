using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPUnstructuredGridWriter
	/// </summary>
	/// <remarks>
	///    Write PVTK XML UnstructuredGrid files.
	///
	/// vtkXMLPUnstructuredGridWriter writes the PVTK XML UnstructuredGrid
	/// file format.  One unstructured grid input can be written into a
	/// parallel file format with any number of pieces spread across files.
	/// The standard extension for this writer's file format is "pvtu".
	/// This writer uses vtkXMLUnstructuredGridWriter to write the
	/// individual piece files.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLUnstructuredGridWriter
	/// </seealso>
	// Token: 0x0200014F RID: 335
	public class vtkXMLPUnstructuredGridWriter : vtkXMLPUnstructuredDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003FE9 RID: 16361 RVA: 0x0005DDD7 File Offset: 0x0005BFD7
		static vtkXMLPUnstructuredGridWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPUnstructuredGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPUnstructuredGridWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003FEA RID: 16362 RVA: 0x0005DDFF File Offset: 0x0005BFFF
		public vtkXMLPUnstructuredGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003FEB RID: 16363
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FEC RID: 16364 RVA: 0x0005DE10 File Offset: 0x0005C010
		public new static vtkXMLPUnstructuredGridWriter New()
		{
			vtkXMLPUnstructuredGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPUnstructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FED RID: 16365 RVA: 0x0005DE64 File Offset: 0x0005C064
		public vtkXMLPUnstructuredGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003FEE RID: 16366 RVA: 0x0005DEA8 File Offset: 0x0005C0A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003FEF RID: 16367
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredGridWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06003FF0 RID: 16368 RVA: 0x0005DEB4 File Offset: 0x0005C0B4
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003FF1 RID: 16369
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredGridWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x06003FF2 RID: 16370 RVA: 0x0005DEF0 File Offset: 0x0005C0F0
		public new vtkUnstructuredGridBase GetInput()
		{
			vtkUnstructuredGridBase vtkUnstructuredGridBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridBase = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridBase.Register(null);
				}
			}
			return vtkUnstructuredGridBase;
		}

		// Token: 0x06003FF3 RID: 16371
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPUnstructuredGridWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FF4 RID: 16372 RVA: 0x0005DF60 File Offset: 0x0005C160
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06003FF5 RID: 16373
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPUnstructuredGridWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FF6 RID: 16374 RVA: 0x0005DF80 File Offset: 0x0005C180
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06003FF7 RID: 16375
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPUnstructuredGridWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FF8 RID: 16376 RVA: 0x0005DF9C File Offset: 0x0005C19C
		public override int IsA(string type)
		{
			return vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06003FF9 RID: 16377
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPUnstructuredGridWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FFA RID: 16378 RVA: 0x0005DFBC File Offset: 0x0005C1BC
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_IsTypeOf_06(type);
		}

		// Token: 0x06003FFB RID: 16379
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredGridWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FFC RID: 16380 RVA: 0x0005DFD8 File Offset: 0x0005C1D8
		public new vtkXMLPUnstructuredGridWriter NewInstance()
		{
			vtkXMLPUnstructuredGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPUnstructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003FFD RID: 16381
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredGridWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FFE RID: 16382 RVA: 0x0005E034 File Offset: 0x0005C234
		public new static vtkXMLPUnstructuredGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPUnstructuredGridWriter vtkXMLPUnstructuredGridWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPUnstructuredGridWriter = (vtkXMLPUnstructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPUnstructuredGridWriter.Register(null);
				}
			}
			return vtkXMLPUnstructuredGridWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006E2 RID: 1762
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPUnstructuredGridWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006E3 RID: 1763
		public new static readonly string MRClassNameKey = "class vtkXMLPUnstructuredGridWriter";
	}
}
