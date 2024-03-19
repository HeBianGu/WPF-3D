using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLStructuredGridWriter
	/// </summary>
	/// <remarks>
	///    Write VTK XML StructuredGrid files.
	///
	/// vtkXMLStructuredGridWriter writes the VTK XML StructuredGrid file
	/// format.  One structured grid input can be written into one file in
	/// any number of streamed pieces.  The standard extension for this
	/// writer's file format is "vts".  This writer is also used to write a
	/// single piece of the parallel file format.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPStructuredGridWriter
	/// </seealso>
	// Token: 0x020006E6 RID: 1766
	public class vtkXMLStructuredGridWriter : vtkXMLStructuredDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012A4D RID: 76365 RVA: 0x001A34F3 File Offset: 0x001A16F3
		static vtkXMLStructuredGridWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLStructuredGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLStructuredGridWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012A4E RID: 76366 RVA: 0x001A351B File Offset: 0x001A171B
		public vtkXMLStructuredGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012A4F RID: 76367
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A50 RID: 76368 RVA: 0x001A352C File Offset: 0x001A172C
		public new static vtkXMLStructuredGridWriter New()
		{
			vtkXMLStructuredGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLStructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A51 RID: 76369 RVA: 0x001A3580 File Offset: 0x001A1780
		public vtkXMLStructuredGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012A52 RID: 76370 RVA: 0x001A35C4 File Offset: 0x001A17C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012A53 RID: 76371
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredGridWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06012A54 RID: 76372 RVA: 0x001A35D0 File Offset: 0x001A17D0
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012A55 RID: 76373
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredGridWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x06012A56 RID: 76374 RVA: 0x001A360C File Offset: 0x001A180C
		public new vtkStructuredGrid GetInput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012A57 RID: 76375
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLStructuredGridWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A58 RID: 76376 RVA: 0x001A367C File Offset: 0x001A187C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012A59 RID: 76377
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLStructuredGridWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A5A RID: 76378 RVA: 0x001A369C File Offset: 0x001A189C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012A5B RID: 76379
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLStructuredGridWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A5C RID: 76380 RVA: 0x001A36B8 File Offset: 0x001A18B8
		public override int IsA(string type)
		{
			return vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012A5D RID: 76381
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLStructuredGridWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A5E RID: 76382 RVA: 0x001A36D8 File Offset: 0x001A18D8
		public new static int IsTypeOf(string type)
		{
			return vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_IsTypeOf_06(type);
		}

		// Token: 0x06012A5F RID: 76383
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredGridWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A60 RID: 76384 RVA: 0x001A36F4 File Offset: 0x001A18F4
		public new vtkXMLStructuredGridWriter NewInstance()
		{
			vtkXMLStructuredGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLStructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012A61 RID: 76385
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredGridWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A62 RID: 76386 RVA: 0x001A3750 File Offset: 0x001A1950
		public new static vtkXMLStructuredGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLStructuredGridWriter vtkXMLStructuredGridWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLStructuredGridWriter = (vtkXMLStructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLStructuredGridWriter.Register(null);
				}
			}
			return vtkXMLStructuredGridWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400157D RID: 5501
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLStructuredGridWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400157E RID: 5502
		public new static readonly string MRClassNameKey = "class vtkXMLStructuredGridWriter";
	}
}
