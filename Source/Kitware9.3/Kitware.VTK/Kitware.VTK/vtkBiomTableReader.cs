using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBiomTableReader
	/// </summary>
	/// <remarks>
	///    read vtkTable from a .biom input file
	///
	/// vtkBiomTableReader is a source object that reads ASCII biom data files.
	/// The output of this reader is a single vtkTable data object.
	/// </remarks>
	/// <seealso>
	///
	/// vtkTable vtkTableReader vtkDataReader
	/// </seealso>
	// Token: 0x02000195 RID: 405
	public class vtkBiomTableReader : vtkTableReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004F79 RID: 20345 RVA: 0x000736D3 File Offset: 0x000718D3
		static vtkBiomTableReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiomTableReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiomTableReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004F7A RID: 20346 RVA: 0x000736FB File Offset: 0x000718FB
		public vtkBiomTableReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004F7B RID: 20347
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiomTableReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F7C RID: 20348 RVA: 0x0007370C File Offset: 0x0007190C
		public new static vtkBiomTableReader New()
		{
			vtkBiomTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiomTableReader.vtkBiomTableReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiomTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F7D RID: 20349 RVA: 0x00073760 File Offset: 0x00071960
		public vtkBiomTableReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBiomTableReader.vtkBiomTableReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004F7E RID: 20350 RVA: 0x000737A4 File Offset: 0x000719A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004F7F RID: 20351
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiomTableReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F80 RID: 20352 RVA: 0x000737B0 File Offset: 0x000719B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBiomTableReader.vtkBiomTableReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06004F81 RID: 20353
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiomTableReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F82 RID: 20354 RVA: 0x000737D0 File Offset: 0x000719D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBiomTableReader.vtkBiomTableReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06004F83 RID: 20355
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiomTableReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06004F84 RID: 20356 RVA: 0x000737EC File Offset: 0x000719EC
		public new vtkTable GetOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiomTableReader.vtkBiomTableReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004F85 RID: 20357
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiomTableReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06004F86 RID: 20358 RVA: 0x0007385C File Offset: 0x00071A5C
		public new vtkTable GetOutput(int idx)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiomTableReader.vtkBiomTableReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004F87 RID: 20359
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiomTableReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F88 RID: 20360 RVA: 0x000738CC File Offset: 0x00071ACC
		public override int IsA(string type)
		{
			return vtkBiomTableReader.vtkBiomTableReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06004F89 RID: 20361
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiomTableReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F8A RID: 20362 RVA: 0x000738EC File Offset: 0x00071AEC
		public new static int IsTypeOf(string type)
		{
			return vtkBiomTableReader.vtkBiomTableReader_IsTypeOf_06(type);
		}

		// Token: 0x06004F8B RID: 20363
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiomTableReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F8C RID: 20364 RVA: 0x00073908 File Offset: 0x00071B08
		public new vtkBiomTableReader NewInstance()
		{
			vtkBiomTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiomTableReader.vtkBiomTableReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiomTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004F8D RID: 20365
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiomTableReader_ReadMeshSimple_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06004F8E RID: 20366 RVA: 0x00073964 File Offset: 0x00071B64
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkBiomTableReader.vtkBiomTableReader_ReadMeshSimple_09(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06004F8F RID: 20367
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiomTableReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F90 RID: 20368 RVA: 0x0007399C File Offset: 0x00071B9C
		public new static vtkBiomTableReader SafeDownCast(vtkObjectBase o)
		{
			vtkBiomTableReader vtkBiomTableReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiomTableReader.vtkBiomTableReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiomTableReader = (vtkBiomTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiomTableReader.Register(null);
				}
			}
			return vtkBiomTableReader;
		}

		// Token: 0x06004F91 RID: 20369
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiomTableReader_SetOutput_11(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06004F92 RID: 20370 RVA: 0x00073A1C File Offset: 0x00071C1C
		public new void SetOutput(vtkTable output)
		{
			vtkBiomTableReader.vtkBiomTableReader_SetOutput_11(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400078D RID: 1933
		public new const string MRFullTypeName = "Kitware.VTK.vtkBiomTableReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400078E RID: 1934
		public new static readonly string MRClassNameKey = "class vtkBiomTableReader";
	}
}
