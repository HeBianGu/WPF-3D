using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPStructuredGridWriter
	/// </summary>
	/// <remarks>
	///    Write PVTK XML StructuredGrid files.
	///
	/// vtkXMLPStructuredGridWriter writes the PVTK XML StructuredGrid
	/// file format.  One structured grid input can be written into a
	/// parallel file format with any number of pieces spread across files.
	/// The standard extension for this writer's file format is "pvts".
	/// This writer uses vtkXMLStructuredGridWriter to write the individual
	/// piece files.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLStructuredGridWriter
	/// </seealso>
	// Token: 0x0200014D RID: 333
	public class vtkXMLPStructuredGridWriter : vtkXMLPStructuredDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003FBD RID: 16317 RVA: 0x0005D81F File Offset: 0x0005BA1F
		static vtkXMLPStructuredGridWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPStructuredGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPStructuredGridWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003FBE RID: 16318 RVA: 0x0005D847 File Offset: 0x0005BA47
		public vtkXMLPStructuredGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003FBF RID: 16319
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FC0 RID: 16320 RVA: 0x0005D858 File Offset: 0x0005BA58
		public new static vtkXMLPStructuredGridWriter New()
		{
			vtkXMLPStructuredGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredGridWriter.vtkXMLPStructuredGridWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPStructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FC1 RID: 16321 RVA: 0x0005D8AC File Offset: 0x0005BAAC
		public vtkXMLPStructuredGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPStructuredGridWriter.vtkXMLPStructuredGridWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003FC2 RID: 16322 RVA: 0x0005D8F0 File Offset: 0x0005BAF0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003FC3 RID: 16323
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredGridWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06003FC4 RID: 16324 RVA: 0x0005D8FC File Offset: 0x0005BAFC
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLPStructuredGridWriter.vtkXMLPStructuredGridWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003FC5 RID: 16325
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredGridWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x06003FC6 RID: 16326 RVA: 0x0005D938 File Offset: 0x0005BB38
		public new vtkStructuredGrid GetInput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredGridWriter.vtkXMLPStructuredGridWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x06003FC7 RID: 16327
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPStructuredGridWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FC8 RID: 16328 RVA: 0x0005D9A8 File Offset: 0x0005BBA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPStructuredGridWriter.vtkXMLPStructuredGridWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06003FC9 RID: 16329
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPStructuredGridWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FCA RID: 16330 RVA: 0x0005D9C8 File Offset: 0x0005BBC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPStructuredGridWriter.vtkXMLPStructuredGridWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06003FCB RID: 16331
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPStructuredGridWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FCC RID: 16332 RVA: 0x0005D9E4 File Offset: 0x0005BBE4
		public override int IsA(string type)
		{
			return vtkXMLPStructuredGridWriter.vtkXMLPStructuredGridWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06003FCD RID: 16333
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPStructuredGridWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FCE RID: 16334 RVA: 0x0005DA04 File Offset: 0x0005BC04
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPStructuredGridWriter.vtkXMLPStructuredGridWriter_IsTypeOf_06(type);
		}

		// Token: 0x06003FCF RID: 16335
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredGridWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FD0 RID: 16336 RVA: 0x0005DA20 File Offset: 0x0005BC20
		public new vtkXMLPStructuredGridWriter NewInstance()
		{
			vtkXMLPStructuredGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredGridWriter.vtkXMLPStructuredGridWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPStructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003FD1 RID: 16337
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredGridWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FD2 RID: 16338 RVA: 0x0005DA7C File Offset: 0x0005BC7C
		public new static vtkXMLPStructuredGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPStructuredGridWriter vtkXMLPStructuredGridWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredGridWriter.vtkXMLPStructuredGridWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPStructuredGridWriter = (vtkXMLPStructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPStructuredGridWriter.Register(null);
				}
			}
			return vtkXMLPStructuredGridWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006DE RID: 1758
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPStructuredGridWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006DF RID: 1759
		public new static readonly string MRClassNameKey = "class vtkXMLPStructuredGridWriter";
	}
}
