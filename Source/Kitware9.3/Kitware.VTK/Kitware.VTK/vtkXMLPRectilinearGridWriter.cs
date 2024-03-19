using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPRectilinearGridWriter
	/// </summary>
	/// <remarks>
	///    Write PVTK XML RectilinearGrid files.
	///
	/// vtkXMLPRectilinearGridWriter writes the PVTK XML RectilinearGrid
	/// file format.  One rectilinear grid input can be written into a
	/// parallel file format with any number of pieces spread across files.
	/// The standard extension for this writer's file format is "pvtr".
	/// This writer uses vtkXMLRectilinearGridWriter to write the
	/// individual piece files.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLRectilinearGridWriter
	/// </seealso>
	// Token: 0x0200014C RID: 332
	public class vtkXMLPRectilinearGridWriter : vtkXMLPStructuredDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003FA7 RID: 16295 RVA: 0x0005D543 File Offset: 0x0005B743
		static vtkXMLPRectilinearGridWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPRectilinearGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPRectilinearGridWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003FA8 RID: 16296 RVA: 0x0005D56B File Offset: 0x0005B76B
		public vtkXMLPRectilinearGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003FA9 RID: 16297
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPRectilinearGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FAA RID: 16298 RVA: 0x0005D57C File Offset: 0x0005B77C
		public new static vtkXMLPRectilinearGridWriter New()
		{
			vtkXMLPRectilinearGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPRectilinearGridWriter.vtkXMLPRectilinearGridWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPRectilinearGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FAB RID: 16299 RVA: 0x0005D5D0 File Offset: 0x0005B7D0
		public vtkXMLPRectilinearGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPRectilinearGridWriter.vtkXMLPRectilinearGridWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003FAC RID: 16300 RVA: 0x0005D614 File Offset: 0x0005B814
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003FAD RID: 16301
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPRectilinearGridWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06003FAE RID: 16302 RVA: 0x0005D620 File Offset: 0x0005B820
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLPRectilinearGridWriter.vtkXMLPRectilinearGridWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003FAF RID: 16303
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPRectilinearGridWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x06003FB0 RID: 16304 RVA: 0x0005D65C File Offset: 0x0005B85C
		public new vtkRectilinearGrid GetInput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPRectilinearGridWriter.vtkXMLPRectilinearGridWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x06003FB1 RID: 16305
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPRectilinearGridWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FB2 RID: 16306 RVA: 0x0005D6CC File Offset: 0x0005B8CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPRectilinearGridWriter.vtkXMLPRectilinearGridWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06003FB3 RID: 16307
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPRectilinearGridWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FB4 RID: 16308 RVA: 0x0005D6EC File Offset: 0x0005B8EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPRectilinearGridWriter.vtkXMLPRectilinearGridWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06003FB5 RID: 16309
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPRectilinearGridWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FB6 RID: 16310 RVA: 0x0005D708 File Offset: 0x0005B908
		public override int IsA(string type)
		{
			return vtkXMLPRectilinearGridWriter.vtkXMLPRectilinearGridWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06003FB7 RID: 16311
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPRectilinearGridWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FB8 RID: 16312 RVA: 0x0005D728 File Offset: 0x0005B928
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPRectilinearGridWriter.vtkXMLPRectilinearGridWriter_IsTypeOf_06(type);
		}

		// Token: 0x06003FB9 RID: 16313
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPRectilinearGridWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FBA RID: 16314 RVA: 0x0005D744 File Offset: 0x0005B944
		public new vtkXMLPRectilinearGridWriter NewInstance()
		{
			vtkXMLPRectilinearGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPRectilinearGridWriter.vtkXMLPRectilinearGridWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPRectilinearGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003FBB RID: 16315
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPRectilinearGridWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FBC RID: 16316 RVA: 0x0005D7A0 File Offset: 0x0005B9A0
		public new static vtkXMLPRectilinearGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPRectilinearGridWriter vtkXMLPRectilinearGridWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPRectilinearGridWriter.vtkXMLPRectilinearGridWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPRectilinearGridWriter = (vtkXMLPRectilinearGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPRectilinearGridWriter.Register(null);
				}
			}
			return vtkXMLPRectilinearGridWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006DC RID: 1756
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPRectilinearGridWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006DD RID: 1757
		public new static readonly string MRClassNameKey = "class vtkXMLPRectilinearGridWriter";
	}
}
