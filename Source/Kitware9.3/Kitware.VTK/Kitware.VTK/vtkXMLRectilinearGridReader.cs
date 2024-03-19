using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLRectilinearGridReader
	/// </summary>
	/// <remarks>
	///    Read VTK XML RectilinearGrid files.
	///
	/// vtkXMLRectilinearGridReader reads the VTK XML RectilinearGrid file
	/// format.  One rectilinear grid file can be read to produce one
	/// output.  Streaming is supported.  The standard extension for this
	/// reader's file format is "vtr".  This reader is also used to read a
	/// single piece of the parallel file format.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPRectilinearGridReader
	/// </seealso>
	// Token: 0x020006E3 RID: 1763
	public class vtkXMLRectilinearGridReader : vtkXMLStructuredDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012A0B RID: 76299 RVA: 0x001A2BF7 File Offset: 0x001A0DF7
		static vtkXMLRectilinearGridReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLRectilinearGridReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLRectilinearGridReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012A0C RID: 76300 RVA: 0x001A2C1F File Offset: 0x001A0E1F
		public vtkXMLRectilinearGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012A0D RID: 76301
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLRectilinearGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A0E RID: 76302 RVA: 0x001A2C30 File Offset: 0x001A0E30
		public new static vtkXMLRectilinearGridReader New()
		{
			vtkXMLRectilinearGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLRectilinearGridReader.vtkXMLRectilinearGridReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLRectilinearGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A0F RID: 76303 RVA: 0x001A2C84 File Offset: 0x001A0E84
		public vtkXMLRectilinearGridReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLRectilinearGridReader.vtkXMLRectilinearGridReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012A10 RID: 76304 RVA: 0x001A2CC8 File Offset: 0x001A0EC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012A11 RID: 76305
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLRectilinearGridReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A12 RID: 76306 RVA: 0x001A2CD4 File Offset: 0x001A0ED4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLRectilinearGridReader.vtkXMLRectilinearGridReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012A13 RID: 76307
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLRectilinearGridReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A14 RID: 76308 RVA: 0x001A2CF4 File Offset: 0x001A0EF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLRectilinearGridReader.vtkXMLRectilinearGridReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012A15 RID: 76309
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLRectilinearGridReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012A16 RID: 76310 RVA: 0x001A2D10 File Offset: 0x001A0F10
		public vtkRectilinearGrid GetOutput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLRectilinearGridReader.vtkXMLRectilinearGridReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012A17 RID: 76311
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLRectilinearGridReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012A18 RID: 76312 RVA: 0x001A2D80 File Offset: 0x001A0F80
		public vtkRectilinearGrid GetOutput(int idx)
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLRectilinearGridReader.vtkXMLRectilinearGridReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012A19 RID: 76313
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLRectilinearGridReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A1A RID: 76314 RVA: 0x001A2DF0 File Offset: 0x001A0FF0
		public override int IsA(string type)
		{
			return vtkXMLRectilinearGridReader.vtkXMLRectilinearGridReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012A1B RID: 76315
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLRectilinearGridReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A1C RID: 76316 RVA: 0x001A2E10 File Offset: 0x001A1010
		public new static int IsTypeOf(string type)
		{
			return vtkXMLRectilinearGridReader.vtkXMLRectilinearGridReader_IsTypeOf_06(type);
		}

		// Token: 0x06012A1D RID: 76317
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLRectilinearGridReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A1E RID: 76318 RVA: 0x001A2E2C File Offset: 0x001A102C
		public new vtkXMLRectilinearGridReader NewInstance()
		{
			vtkXMLRectilinearGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLRectilinearGridReader.vtkXMLRectilinearGridReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLRectilinearGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012A1F RID: 76319
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLRectilinearGridReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A20 RID: 76320 RVA: 0x001A2E88 File Offset: 0x001A1088
		public new static vtkXMLRectilinearGridReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLRectilinearGridReader vtkXMLRectilinearGridReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLRectilinearGridReader.vtkXMLRectilinearGridReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLRectilinearGridReader = (vtkXMLRectilinearGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLRectilinearGridReader.Register(null);
				}
			}
			return vtkXMLRectilinearGridReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001577 RID: 5495
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLRectilinearGridReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001578 RID: 5496
		public new static readonly string MRClassNameKey = "class vtkXMLRectilinearGridReader";
	}
}
