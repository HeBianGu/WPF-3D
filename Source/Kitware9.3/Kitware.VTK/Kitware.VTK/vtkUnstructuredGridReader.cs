using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridReader
	/// </summary>
	/// <remarks>
	///    read vtk unstructured grid data file
	///
	/// vtkUnstructuredGridReader is a source object that reads ASCII or binary
	/// unstructured grid data files in vtk format. (see text for format details).
	/// The output of this reader is a single vtkUnstructuredGrid data object.
	/// The superclass of this class, vtkDataReader, provides many methods for
	/// controlling the reading of the data file, see vtkDataReader for more
	/// information.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	/// <seealso>
	///
	/// vtkUnstructuredGrid vtkDataReader
	/// </seealso>
	// Token: 0x02000719 RID: 1817
	public class vtkUnstructuredGridReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601307E RID: 77950 RVA: 0x001AE29F File Offset: 0x001AC49F
		static vtkUnstructuredGridReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601307F RID: 77951 RVA: 0x001AE2C7 File Offset: 0x001AC4C7
		public vtkUnstructuredGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013080 RID: 77952
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013081 RID: 77953 RVA: 0x001AE2D8 File Offset: 0x001AC4D8
		public new static vtkUnstructuredGridReader New()
		{
			vtkUnstructuredGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridReader.vtkUnstructuredGridReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013082 RID: 77954 RVA: 0x001AE32C File Offset: 0x001AC52C
		public vtkUnstructuredGridReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridReader.vtkUnstructuredGridReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013083 RID: 77955 RVA: 0x001AE370 File Offset: 0x001AC570
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013084 RID: 77956
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013085 RID: 77957 RVA: 0x001AE37C File Offset: 0x001AC57C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridReader.vtkUnstructuredGridReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06013086 RID: 77958
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013087 RID: 77959 RVA: 0x001AE39C File Offset: 0x001AC59C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridReader.vtkUnstructuredGridReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06013088 RID: 77960
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06013089 RID: 77961 RVA: 0x001AE3B8 File Offset: 0x001AC5B8
		public vtkUnstructuredGrid GetOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridReader.vtkUnstructuredGridReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601308A RID: 77962
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x0601308B RID: 77963 RVA: 0x001AE428 File Offset: 0x001AC628
		public vtkUnstructuredGrid GetOutput(int idx)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridReader.vtkUnstructuredGridReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601308C RID: 77964
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601308D RID: 77965 RVA: 0x001AE498 File Offset: 0x001AC698
		public override int IsA(string type)
		{
			return vtkUnstructuredGridReader.vtkUnstructuredGridReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601308E RID: 77966
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601308F RID: 77967 RVA: 0x001AE4B8 File Offset: 0x001AC6B8
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridReader.vtkUnstructuredGridReader_IsTypeOf_06(type);
		}

		// Token: 0x06013090 RID: 77968
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013091 RID: 77969 RVA: 0x001AE4D4 File Offset: 0x001AC6D4
		public new vtkUnstructuredGridReader NewInstance()
		{
			vtkUnstructuredGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridReader.vtkUnstructuredGridReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013092 RID: 77970
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridReader_ReadMeshSimple_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06013093 RID: 77971 RVA: 0x001AE530 File Offset: 0x001AC730
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkUnstructuredGridReader.vtkUnstructuredGridReader_ReadMeshSimple_09(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06013094 RID: 77972
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013095 RID: 77973 RVA: 0x001AE568 File Offset: 0x001AC768
		public new static vtkUnstructuredGridReader SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridReader vtkUnstructuredGridReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridReader.vtkUnstructuredGridReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridReader = (vtkUnstructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridReader.Register(null);
				}
			}
			return vtkUnstructuredGridReader;
		}

		// Token: 0x06013096 RID: 77974
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridReader_SetOutput_11(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06013097 RID: 77975 RVA: 0x001AE5E8 File Offset: 0x001AC7E8
		public void SetOutput(vtkUnstructuredGrid output)
		{
			vtkUnstructuredGridReader.vtkUnstructuredGridReader_SetOutput_11(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015FE RID: 5630
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015FF RID: 5631
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridReader";
	}
}
