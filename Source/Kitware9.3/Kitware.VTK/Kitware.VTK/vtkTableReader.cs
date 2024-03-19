using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTableReader
	/// </summary>
	/// <remarks>
	///    read vtkTable data file
	///
	/// vtkTableReader is a source object that reads ASCII or binary
	/// vtkTable data files in vtk format. (see text for format details).
	/// The output of this reader is a single vtkTable data object.
	/// The superclass of this class, vtkDataReader, provides many methods for
	/// controlling the reading of the data file, see vtkDataReader for more
	/// information.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	/// <seealso>
	///
	/// vtkTable vtkDataReader vtkTableWriter
	/// </seealso>
	// Token: 0x02000194 RID: 404
	public class vtkTableReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004F5F RID: 20319 RVA: 0x0007335C File Offset: 0x0007155C
		static vtkTableReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004F60 RID: 20320 RVA: 0x00073384 File Offset: 0x00071584
		public vtkTableReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004F61 RID: 20321
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F62 RID: 20322 RVA: 0x00073394 File Offset: 0x00071594
		public new static vtkTableReader New()
		{
			vtkTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableReader.vtkTableReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F63 RID: 20323 RVA: 0x000733E8 File Offset: 0x000715E8
		public vtkTableReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTableReader.vtkTableReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004F64 RID: 20324 RVA: 0x0007342C File Offset: 0x0007162C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004F65 RID: 20325
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F66 RID: 20326 RVA: 0x00073438 File Offset: 0x00071638
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTableReader.vtkTableReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06004F67 RID: 20327
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F68 RID: 20328 RVA: 0x00073458 File Offset: 0x00071658
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTableReader.vtkTableReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06004F69 RID: 20329
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06004F6A RID: 20330 RVA: 0x00073474 File Offset: 0x00071674
		public vtkTable GetOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableReader.vtkTableReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x06004F6B RID: 20331
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06004F6C RID: 20332 RVA: 0x000734E4 File Offset: 0x000716E4
		public vtkTable GetOutput(int idx)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableReader.vtkTableReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x06004F6D RID: 20333
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F6E RID: 20334 RVA: 0x00073554 File Offset: 0x00071754
		public override int IsA(string type)
		{
			return vtkTableReader.vtkTableReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06004F6F RID: 20335
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F70 RID: 20336 RVA: 0x00073574 File Offset: 0x00071774
		public new static int IsTypeOf(string type)
		{
			return vtkTableReader.vtkTableReader_IsTypeOf_06(type);
		}

		// Token: 0x06004F71 RID: 20337
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F72 RID: 20338 RVA: 0x00073590 File Offset: 0x00071790
		public new vtkTableReader NewInstance()
		{
			vtkTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableReader.vtkTableReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004F73 RID: 20339
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableReader_ReadMeshSimple_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06004F74 RID: 20340 RVA: 0x000735EC File Offset: 0x000717EC
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkTableReader.vtkTableReader_ReadMeshSimple_09(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06004F75 RID: 20341
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F76 RID: 20342 RVA: 0x00073624 File Offset: 0x00071824
		public new static vtkTableReader SafeDownCast(vtkObjectBase o)
		{
			vtkTableReader vtkTableReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableReader.vtkTableReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableReader = (vtkTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableReader.Register(null);
				}
			}
			return vtkTableReader;
		}

		// Token: 0x06004F77 RID: 20343
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableReader_SetOutput_11(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06004F78 RID: 20344 RVA: 0x000736A4 File Offset: 0x000718A4
		public void SetOutput(vtkTable output)
		{
			vtkTableReader.vtkTableReader_SetOutput_11(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400078B RID: 1931
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400078C RID: 1932
		public new static readonly string MRClassNameKey = "class vtkTableReader";
	}
}
