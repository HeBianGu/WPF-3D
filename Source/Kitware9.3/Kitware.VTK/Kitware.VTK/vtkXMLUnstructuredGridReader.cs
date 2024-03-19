using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLUnstructuredGridReader
	/// </summary>
	/// <remarks>
	///    Read VTK XML UnstructuredGrid files.
	///
	/// vtkXMLUnstructuredGridReader reads the VTK XML UnstructuredGrid
	/// file format.  One unstructured grid file can be read to produce one
	/// output.  Streaming is supported.  The standard extension for this
	/// reader's file format is "vtu".  This reader is also used to read a
	/// single piece of the parallel file format.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPUnstructuredGridReader
	/// </seealso>
	// Token: 0x020006E9 RID: 1769
	public class vtkXMLUnstructuredGridReader : vtkXMLUnstructuredDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012A9B RID: 76443 RVA: 0x001A3DEF File Offset: 0x001A1FEF
		static vtkXMLUnstructuredGridReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLUnstructuredGridReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUnstructuredGridReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012A9C RID: 76444 RVA: 0x001A3E17 File Offset: 0x001A2017
		public vtkXMLUnstructuredGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012A9D RID: 76445
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A9E RID: 76446 RVA: 0x001A3E28 File Offset: 0x001A2028
		public new static vtkXMLUnstructuredGridReader New()
		{
			vtkXMLUnstructuredGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredGridReader.vtkXMLUnstructuredGridReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUnstructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A9F RID: 76447 RVA: 0x001A3E7C File Offset: 0x001A207C
		public vtkXMLUnstructuredGridReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLUnstructuredGridReader.vtkXMLUnstructuredGridReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012AA0 RID: 76448 RVA: 0x001A3EC0 File Offset: 0x001A20C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012AA1 RID: 76449
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUnstructuredGridReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AA2 RID: 76450 RVA: 0x001A3ECC File Offset: 0x001A20CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLUnstructuredGridReader.vtkXMLUnstructuredGridReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012AA3 RID: 76451
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUnstructuredGridReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AA4 RID: 76452 RVA: 0x001A3EEC File Offset: 0x001A20EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLUnstructuredGridReader.vtkXMLUnstructuredGridReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012AA5 RID: 76453
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredGridReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012AA6 RID: 76454 RVA: 0x001A3F08 File Offset: 0x001A2108
		public vtkUnstructuredGrid GetOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredGridReader.vtkXMLUnstructuredGridReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x06012AA7 RID: 76455
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredGridReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012AA8 RID: 76456 RVA: 0x001A3F78 File Offset: 0x001A2178
		public vtkUnstructuredGrid GetOutput(int idx)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredGridReader.vtkXMLUnstructuredGridReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x06012AA9 RID: 76457
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUnstructuredGridReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AAA RID: 76458 RVA: 0x001A3FE8 File Offset: 0x001A21E8
		public override int IsA(string type)
		{
			return vtkXMLUnstructuredGridReader.vtkXMLUnstructuredGridReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012AAB RID: 76459
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUnstructuredGridReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AAC RID: 76460 RVA: 0x001A4008 File Offset: 0x001A2208
		public new static int IsTypeOf(string type)
		{
			return vtkXMLUnstructuredGridReader.vtkXMLUnstructuredGridReader_IsTypeOf_06(type);
		}

		// Token: 0x06012AAD RID: 76461
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredGridReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AAE RID: 76462 RVA: 0x001A4024 File Offset: 0x001A2224
		public new vtkXMLUnstructuredGridReader NewInstance()
		{
			vtkXMLUnstructuredGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredGridReader.vtkXMLUnstructuredGridReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUnstructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012AAF RID: 76463
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredGridReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AB0 RID: 76464 RVA: 0x001A4080 File Offset: 0x001A2280
		public new static vtkXMLUnstructuredGridReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLUnstructuredGridReader vtkXMLUnstructuredGridReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredGridReader.vtkXMLUnstructuredGridReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLUnstructuredGridReader = (vtkXMLUnstructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLUnstructuredGridReader.Register(null);
				}
			}
			return vtkXMLUnstructuredGridReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001583 RID: 5507
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUnstructuredGridReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001584 RID: 5508
		public new static readonly string MRClassNameKey = "class vtkXMLUnstructuredGridReader";
	}
}
