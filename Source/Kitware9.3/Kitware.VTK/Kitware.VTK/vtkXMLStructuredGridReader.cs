using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLStructuredGridReader
	/// </summary>
	/// <remarks>
	///    Read VTK XML StructuredGrid files.
	///
	/// vtkXMLStructuredGridReader reads the VTK XML StructuredGrid file
	/// format.  One structured grid file can be read to produce one
	/// output.  Streaming is supported.  The standard extension for this
	/// reader's file format is "vts".  This reader is also used to read a
	/// single piece of the parallel file format.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPStructuredGridReader
	/// </seealso>
	// Token: 0x020006E5 RID: 1765
	public class vtkXMLStructuredGridReader : vtkXMLStructuredDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012A37 RID: 76343 RVA: 0x001A31E3 File Offset: 0x001A13E3
		static vtkXMLStructuredGridReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLStructuredGridReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLStructuredGridReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012A38 RID: 76344 RVA: 0x001A320B File Offset: 0x001A140B
		public vtkXMLStructuredGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012A39 RID: 76345
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A3A RID: 76346 RVA: 0x001A321C File Offset: 0x001A141C
		public new static vtkXMLStructuredGridReader New()
		{
			vtkXMLStructuredGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredGridReader.vtkXMLStructuredGridReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLStructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A3B RID: 76347 RVA: 0x001A3270 File Offset: 0x001A1470
		public vtkXMLStructuredGridReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLStructuredGridReader.vtkXMLStructuredGridReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012A3C RID: 76348 RVA: 0x001A32B4 File Offset: 0x001A14B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012A3D RID: 76349
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLStructuredGridReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A3E RID: 76350 RVA: 0x001A32C0 File Offset: 0x001A14C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLStructuredGridReader.vtkXMLStructuredGridReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012A3F RID: 76351
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLStructuredGridReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A40 RID: 76352 RVA: 0x001A32E0 File Offset: 0x001A14E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLStructuredGridReader.vtkXMLStructuredGridReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012A41 RID: 76353
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredGridReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012A42 RID: 76354 RVA: 0x001A32FC File Offset: 0x001A14FC
		public vtkStructuredGrid GetOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredGridReader.vtkXMLStructuredGridReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012A43 RID: 76355
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredGridReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012A44 RID: 76356 RVA: 0x001A336C File Offset: 0x001A156C
		public vtkStructuredGrid GetOutput(int idx)
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredGridReader.vtkXMLStructuredGridReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012A45 RID: 76357
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLStructuredGridReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A46 RID: 76358 RVA: 0x001A33DC File Offset: 0x001A15DC
		public override int IsA(string type)
		{
			return vtkXMLStructuredGridReader.vtkXMLStructuredGridReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012A47 RID: 76359
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLStructuredGridReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A48 RID: 76360 RVA: 0x001A33FC File Offset: 0x001A15FC
		public new static int IsTypeOf(string type)
		{
			return vtkXMLStructuredGridReader.vtkXMLStructuredGridReader_IsTypeOf_06(type);
		}

		// Token: 0x06012A49 RID: 76361
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredGridReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A4A RID: 76362 RVA: 0x001A3418 File Offset: 0x001A1618
		public new vtkXMLStructuredGridReader NewInstance()
		{
			vtkXMLStructuredGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredGridReader.vtkXMLStructuredGridReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLStructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012A4B RID: 76363
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredGridReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A4C RID: 76364 RVA: 0x001A3474 File Offset: 0x001A1674
		public new static vtkXMLStructuredGridReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLStructuredGridReader vtkXMLStructuredGridReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredGridReader.vtkXMLStructuredGridReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLStructuredGridReader = (vtkXMLStructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLStructuredGridReader.Register(null);
				}
			}
			return vtkXMLStructuredGridReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400157B RID: 5499
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLStructuredGridReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400157C RID: 5500
		public new static readonly string MRClassNameKey = "class vtkXMLStructuredGridReader";
	}
}
