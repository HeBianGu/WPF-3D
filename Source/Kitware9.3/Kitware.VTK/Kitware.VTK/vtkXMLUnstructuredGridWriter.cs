using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLUnstructuredGridWriter
	/// </summary>
	/// <remarks>
	///    Write VTK XML UnstructuredGrid files.
	///
	/// vtkXMLUnstructuredGridWriter writes the VTK XML UnstructuredGrid
	/// file format.  One unstructured grid input can be written into one
	/// file in any number of streamed pieces (if supported by the rest of
	/// the pipeline).  The standard extension for this writer's file
	/// format is "vtu".  This writer is also used to write a single piece
	/// of the parallel file format.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPUnstructuredGridWriter
	/// </seealso>
	// Token: 0x020006EA RID: 1770
	public class vtkXMLUnstructuredGridWriter : vtkXMLUnstructuredDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012AB1 RID: 76465 RVA: 0x001A40FF File Offset: 0x001A22FF
		static vtkXMLUnstructuredGridWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLUnstructuredGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUnstructuredGridWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012AB2 RID: 76466 RVA: 0x001A4127 File Offset: 0x001A2327
		public vtkXMLUnstructuredGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012AB3 RID: 76467
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AB4 RID: 76468 RVA: 0x001A4138 File Offset: 0x001A2338
		public new static vtkXMLUnstructuredGridWriter New()
		{
			vtkXMLUnstructuredGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredGridWriter.vtkXMLUnstructuredGridWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUnstructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AB5 RID: 76469 RVA: 0x001A418C File Offset: 0x001A238C
		public vtkXMLUnstructuredGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLUnstructuredGridWriter.vtkXMLUnstructuredGridWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012AB6 RID: 76470 RVA: 0x001A41D0 File Offset: 0x001A23D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012AB7 RID: 76471
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredGridWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06012AB8 RID: 76472 RVA: 0x001A41DC File Offset: 0x001A23DC
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLUnstructuredGridWriter.vtkXMLUnstructuredGridWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012AB9 RID: 76473
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredGridWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x06012ABA RID: 76474 RVA: 0x001A4218 File Offset: 0x001A2418
		public new vtkUnstructuredGridBase GetInput()
		{
			vtkUnstructuredGridBase vtkUnstructuredGridBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredGridWriter.vtkXMLUnstructuredGridWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012ABB RID: 76475
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUnstructuredGridWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012ABC RID: 76476 RVA: 0x001A4288 File Offset: 0x001A2488
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLUnstructuredGridWriter.vtkXMLUnstructuredGridWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012ABD RID: 76477
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUnstructuredGridWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012ABE RID: 76478 RVA: 0x001A42A8 File Offset: 0x001A24A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLUnstructuredGridWriter.vtkXMLUnstructuredGridWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012ABF RID: 76479
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUnstructuredGridWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AC0 RID: 76480 RVA: 0x001A42C4 File Offset: 0x001A24C4
		public override int IsA(string type)
		{
			return vtkXMLUnstructuredGridWriter.vtkXMLUnstructuredGridWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012AC1 RID: 76481
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUnstructuredGridWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AC2 RID: 76482 RVA: 0x001A42E4 File Offset: 0x001A24E4
		public new static int IsTypeOf(string type)
		{
			return vtkXMLUnstructuredGridWriter.vtkXMLUnstructuredGridWriter_IsTypeOf_06(type);
		}

		// Token: 0x06012AC3 RID: 76483
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredGridWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AC4 RID: 76484 RVA: 0x001A4300 File Offset: 0x001A2500
		public new vtkXMLUnstructuredGridWriter NewInstance()
		{
			vtkXMLUnstructuredGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredGridWriter.vtkXMLUnstructuredGridWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUnstructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012AC5 RID: 76485
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredGridWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AC6 RID: 76486 RVA: 0x001A435C File Offset: 0x001A255C
		public new static vtkXMLUnstructuredGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLUnstructuredGridWriter vtkXMLUnstructuredGridWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredGridWriter.vtkXMLUnstructuredGridWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLUnstructuredGridWriter = (vtkXMLUnstructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLUnstructuredGridWriter.Register(null);
				}
			}
			return vtkXMLUnstructuredGridWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001585 RID: 5509
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUnstructuredGridWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001586 RID: 5510
		public new static readonly string MRClassNameKey = "class vtkXMLUnstructuredGridWriter";
	}
}
