using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLRectilinearGridWriter
	/// </summary>
	/// <remarks>
	///    Write VTK XML RectilinearGrid files.
	///
	/// vtkXMLRectilinearGridWriter writes the VTK XML RectilinearGrid
	/// file format.  One rectilinear grid input can be written into one
	/// file in any number of streamed pieces.  The standard extension for
	/// this writer's file format is "vtr".  This writer is also used to
	/// write a single piece of the parallel file format.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPRectilinearGridWriter
	/// </seealso>
	// Token: 0x020006E4 RID: 1764
	public class vtkXMLRectilinearGridWriter : vtkXMLStructuredDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012A21 RID: 76321 RVA: 0x001A2F07 File Offset: 0x001A1107
		static vtkXMLRectilinearGridWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLRectilinearGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLRectilinearGridWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012A22 RID: 76322 RVA: 0x001A2F2F File Offset: 0x001A112F
		public vtkXMLRectilinearGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012A23 RID: 76323
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLRectilinearGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A24 RID: 76324 RVA: 0x001A2F40 File Offset: 0x001A1140
		public new static vtkXMLRectilinearGridWriter New()
		{
			vtkXMLRectilinearGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLRectilinearGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A25 RID: 76325 RVA: 0x001A2F94 File Offset: 0x001A1194
		public vtkXMLRectilinearGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012A26 RID: 76326 RVA: 0x001A2FD8 File Offset: 0x001A11D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012A27 RID: 76327
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLRectilinearGridWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06012A28 RID: 76328 RVA: 0x001A2FE4 File Offset: 0x001A11E4
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012A29 RID: 76329
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLRectilinearGridWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x06012A2A RID: 76330 RVA: 0x001A3020 File Offset: 0x001A1220
		public new vtkRectilinearGrid GetInput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012A2B RID: 76331
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLRectilinearGridWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A2C RID: 76332 RVA: 0x001A3090 File Offset: 0x001A1290
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012A2D RID: 76333
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLRectilinearGridWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A2E RID: 76334 RVA: 0x001A30B0 File Offset: 0x001A12B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012A2F RID: 76335
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLRectilinearGridWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A30 RID: 76336 RVA: 0x001A30CC File Offset: 0x001A12CC
		public override int IsA(string type)
		{
			return vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012A31 RID: 76337
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLRectilinearGridWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A32 RID: 76338 RVA: 0x001A30EC File Offset: 0x001A12EC
		public new static int IsTypeOf(string type)
		{
			return vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_IsTypeOf_06(type);
		}

		// Token: 0x06012A33 RID: 76339
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLRectilinearGridWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A34 RID: 76340 RVA: 0x001A3108 File Offset: 0x001A1308
		public new vtkXMLRectilinearGridWriter NewInstance()
		{
			vtkXMLRectilinearGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLRectilinearGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012A35 RID: 76341
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLRectilinearGridWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A36 RID: 76342 RVA: 0x001A3164 File Offset: 0x001A1364
		public new static vtkXMLRectilinearGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLRectilinearGridWriter vtkXMLRectilinearGridWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLRectilinearGridWriter = (vtkXMLRectilinearGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLRectilinearGridWriter.Register(null);
				}
			}
			return vtkXMLRectilinearGridWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001579 RID: 5497
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLRectilinearGridWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400157A RID: 5498
		public new static readonly string MRClassNameKey = "class vtkXMLRectilinearGridWriter";
	}
}
