using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredGridReader
	/// </summary>
	/// <remarks>
	///    read vtk structured grid data file
	///
	/// vtkStructuredGridReader is a source object that reads ASCII or binary
	/// structured grid data files in vtk format. (see text for format details).
	/// The output of this reader is a single vtkStructuredGrid data object.
	/// The superclass of this class, vtkDataReader, provides many methods for
	/// controlling the reading of the data file, see vtkDataReader for more
	/// information.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	/// <seealso>
	///
	/// vtkStructuredGrid vtkDataReader
	/// </seealso>
	// Token: 0x02000712 RID: 1810
	public class vtkStructuredGridReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012FC4 RID: 77764 RVA: 0x001ACACF File Offset: 0x001AACCF
		static vtkStructuredGridReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012FC5 RID: 77765 RVA: 0x001ACAF7 File Offset: 0x001AACF7
		public vtkStructuredGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012FC6 RID: 77766
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FC7 RID: 77767 RVA: 0x001ACB08 File Offset: 0x001AAD08
		public new static vtkStructuredGridReader New()
		{
			vtkStructuredGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridReader.vtkStructuredGridReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FC8 RID: 77768 RVA: 0x001ACB5C File Offset: 0x001AAD5C
		public vtkStructuredGridReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredGridReader.vtkStructuredGridReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012FC9 RID: 77769 RVA: 0x001ACBA0 File Offset: 0x001AADA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012FCA RID: 77770
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FCB RID: 77771 RVA: 0x001ACBAC File Offset: 0x001AADAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredGridReader.vtkStructuredGridReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012FCC RID: 77772
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FCD RID: 77773 RVA: 0x001ACBCC File Offset: 0x001AADCC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredGridReader.vtkStructuredGridReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012FCE RID: 77774
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06012FCF RID: 77775 RVA: 0x001ACBE8 File Offset: 0x001AADE8
		public vtkStructuredGrid GetOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridReader.vtkStructuredGridReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012FD0 RID: 77776
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06012FD1 RID: 77777 RVA: 0x001ACC58 File Offset: 0x001AAE58
		public vtkStructuredGrid GetOutput(int idx)
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridReader.vtkStructuredGridReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012FD2 RID: 77778
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FD3 RID: 77779 RVA: 0x001ACCC8 File Offset: 0x001AAEC8
		public override int IsA(string type)
		{
			return vtkStructuredGridReader.vtkStructuredGridReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012FD4 RID: 77780
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FD5 RID: 77781 RVA: 0x001ACCE8 File Offset: 0x001AAEE8
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridReader.vtkStructuredGridReader_IsTypeOf_06(type);
		}

		// Token: 0x06012FD6 RID: 77782
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FD7 RID: 77783 RVA: 0x001ACD04 File Offset: 0x001AAF04
		public new vtkStructuredGridReader NewInstance()
		{
			vtkStructuredGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridReader.vtkStructuredGridReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012FD8 RID: 77784
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridReader_ReadMeshSimple_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06012FD9 RID: 77785 RVA: 0x001ACD60 File Offset: 0x001AAF60
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkStructuredGridReader.vtkStructuredGridReader_ReadMeshSimple_09(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06012FDA RID: 77786
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridReader_ReadMetaDataSimple_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef metadata);

		/// <summary>
		/// Read the meta information from the file (WHOLE_EXTENT).
		/// </summary>
		// Token: 0x06012FDB RID: 77787 RVA: 0x001ACD98 File Offset: 0x001AAF98
		public override int ReadMetaDataSimple(string fname, vtkInformation metadata)
		{
			return vtkStructuredGridReader.vtkStructuredGridReader_ReadMetaDataSimple_10(base.GetCppThis(), fname, (metadata == null) ? default(HandleRef) : metadata.GetCppThis());
		}

		// Token: 0x06012FDC RID: 77788
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FDD RID: 77789 RVA: 0x001ACDD0 File Offset: 0x001AAFD0
		public new static vtkStructuredGridReader SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridReader vtkStructuredGridReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridReader.vtkStructuredGridReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridReader = (vtkStructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridReader.Register(null);
				}
			}
			return vtkStructuredGridReader;
		}

		// Token: 0x06012FDE RID: 77790
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridReader_SetOutput_12(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06012FDF RID: 77791 RVA: 0x001ACE50 File Offset: 0x001AB050
		public void SetOutput(vtkStructuredGrid output)
		{
			vtkStructuredGridReader.vtkStructuredGridReader_SetOutput_12(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015F0 RID: 5616
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015F1 RID: 5617
		public new static readonly string MRClassNameKey = "class vtkStructuredGridReader";
	}
}
