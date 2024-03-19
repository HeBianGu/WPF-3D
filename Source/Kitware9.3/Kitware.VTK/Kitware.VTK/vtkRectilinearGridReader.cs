using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearGridReader
	/// </summary>
	/// <remarks>
	///    read vtk rectilinear grid data file
	///
	/// vtkRectilinearGridReader is a source object that reads ASCII or binary
	/// rectilinear grid data files in vtk format (see text for format details).
	/// The output of this reader is a single vtkRectilinearGrid data object.
	/// The superclass of this class, vtkDataReader, provides many methods for
	/// controlling the reading of the data file, see vtkDataReader for more
	/// information.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	/// <seealso>
	///
	/// vtkRectilinearGrid vtkDataReader
	/// </seealso>
	// Token: 0x0200070E RID: 1806
	public class vtkRectilinearGridReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012F5E RID: 77662 RVA: 0x001ABED7 File Offset: 0x001AA0D7
		static vtkRectilinearGridReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012F5F RID: 77663 RVA: 0x001ABEFF File Offset: 0x001AA0FF
		public vtkRectilinearGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012F60 RID: 77664
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F61 RID: 77665 RVA: 0x001ABF10 File Offset: 0x001AA110
		public new static vtkRectilinearGridReader New()
		{
			vtkRectilinearGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridReader.vtkRectilinearGridReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F62 RID: 77666 RVA: 0x001ABF64 File Offset: 0x001AA164
		public vtkRectilinearGridReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearGridReader.vtkRectilinearGridReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012F63 RID: 77667 RVA: 0x001ABFA8 File Offset: 0x001AA1A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012F64 RID: 77668
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F65 RID: 77669 RVA: 0x001ABFB4 File Offset: 0x001AA1B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearGridReader.vtkRectilinearGridReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012F66 RID: 77670
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F67 RID: 77671 RVA: 0x001ABFD4 File Offset: 0x001AA1D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearGridReader.vtkRectilinearGridReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012F68 RID: 77672
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get and set the output of this reader.
		/// </summary>
		// Token: 0x06012F69 RID: 77673 RVA: 0x001ABFF0 File Offset: 0x001AA1F0
		public vtkRectilinearGrid GetOutput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridReader.vtkRectilinearGridReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012F6A RID: 77674
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get and set the output of this reader.
		/// </summary>
		// Token: 0x06012F6B RID: 77675 RVA: 0x001AC060 File Offset: 0x001AA260
		public vtkRectilinearGrid GetOutput(int idx)
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridReader.vtkRectilinearGridReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012F6C RID: 77676
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F6D RID: 77677 RVA: 0x001AC0D0 File Offset: 0x001AA2D0
		public override int IsA(string type)
		{
			return vtkRectilinearGridReader.vtkRectilinearGridReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012F6E RID: 77678
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F6F RID: 77679 RVA: 0x001AC0F0 File Offset: 0x001AA2F0
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridReader.vtkRectilinearGridReader_IsTypeOf_06(type);
		}

		// Token: 0x06012F70 RID: 77680
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F71 RID: 77681 RVA: 0x001AC10C File Offset: 0x001AA30C
		public new vtkRectilinearGridReader NewInstance()
		{
			vtkRectilinearGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridReader.vtkRectilinearGridReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012F72 RID: 77682
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridReader_ReadMeshSimple_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06012F73 RID: 77683 RVA: 0x001AC168 File Offset: 0x001AA368
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkRectilinearGridReader.vtkRectilinearGridReader_ReadMeshSimple_09(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06012F74 RID: 77684
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridReader_ReadMetaDataSimple_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef metadata);

		/// <summary>
		/// Read the meta information from the file (WHOLE_EXTENT).
		/// </summary>
		// Token: 0x06012F75 RID: 77685 RVA: 0x001AC1A0 File Offset: 0x001AA3A0
		public override int ReadMetaDataSimple(string fname, vtkInformation metadata)
		{
			return vtkRectilinearGridReader.vtkRectilinearGridReader_ReadMetaDataSimple_10(base.GetCppThis(), fname, (metadata == null) ? default(HandleRef) : metadata.GetCppThis());
		}

		// Token: 0x06012F76 RID: 77686
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F77 RID: 77687 RVA: 0x001AC1D8 File Offset: 0x001AA3D8
		public new static vtkRectilinearGridReader SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridReader vtkRectilinearGridReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridReader.vtkRectilinearGridReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridReader = (vtkRectilinearGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridReader.Register(null);
				}
			}
			return vtkRectilinearGridReader;
		}

		// Token: 0x06012F78 RID: 77688
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridReader_SetOutput_12(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Get and set the output of this reader.
		/// </summary>
		// Token: 0x06012F79 RID: 77689 RVA: 0x001AC258 File Offset: 0x001AA458
		public void SetOutput(vtkRectilinearGrid output)
		{
			vtkRectilinearGridReader.vtkRectilinearGridReader_SetOutput_12(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015E8 RID: 5608
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015E9 RID: 5609
		public new static readonly string MRClassNameKey = "class vtkRectilinearGridReader";
	}
}
