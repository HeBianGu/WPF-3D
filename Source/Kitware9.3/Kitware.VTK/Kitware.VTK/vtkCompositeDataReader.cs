using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeDataReader
	/// </summary>
	/// <remarks>
	///    read vtkCompositeDataSet data file.
	///
	/// @warning
	/// This is an experimental format. Use XML-based formats for writing composite
	/// datasets. Saving composite dataset in legacy VTK format is expected to change
	/// in future including changes to the file layout.
	/// </remarks>
	// Token: 0x02000703 RID: 1795
	public class vtkCompositeDataReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012E1A RID: 77338 RVA: 0x001A941B File Offset: 0x001A761B
		static vtkCompositeDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012E1B RID: 77339 RVA: 0x001A9443 File Offset: 0x001A7643
		public vtkCompositeDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012E1C RID: 77340
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E1D RID: 77341 RVA: 0x001A9454 File Offset: 0x001A7654
		public new static vtkCompositeDataReader New()
		{
			vtkCompositeDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataReader.vtkCompositeDataReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E1E RID: 77342 RVA: 0x001A94A8 File Offset: 0x001A76A8
		public vtkCompositeDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeDataReader.vtkCompositeDataReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012E1F RID: 77343 RVA: 0x001A94EC File Offset: 0x001A76EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012E20 RID: 77344
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E21 RID: 77345 RVA: 0x001A94F8 File Offset: 0x001A76F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeDataReader.vtkCompositeDataReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012E22 RID: 77346
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E23 RID: 77347 RVA: 0x001A9518 File Offset: 0x001A7718
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeDataReader.vtkCompositeDataReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012E24 RID: 77348
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06012E25 RID: 77349 RVA: 0x001A9534 File Offset: 0x001A7734
		public vtkCompositeDataSet GetOutput()
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataReader.vtkCompositeDataReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x06012E26 RID: 77350
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06012E27 RID: 77351 RVA: 0x001A95A4 File Offset: 0x001A77A4
		public vtkCompositeDataSet GetOutput(int idx)
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataReader.vtkCompositeDataReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x06012E28 RID: 77352
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E29 RID: 77353 RVA: 0x001A9614 File Offset: 0x001A7814
		public override int IsA(string type)
		{
			return vtkCompositeDataReader.vtkCompositeDataReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012E2A RID: 77354
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E2B RID: 77355 RVA: 0x001A9634 File Offset: 0x001A7834
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataReader.vtkCompositeDataReader_IsTypeOf_06(type);
		}

		// Token: 0x06012E2C RID: 77356
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E2D RID: 77357 RVA: 0x001A9650 File Offset: 0x001A7850
		public new vtkCompositeDataReader NewInstance()
		{
			vtkCompositeDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataReader.vtkCompositeDataReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012E2E RID: 77358
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataReader_ReadMeshSimple_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06012E2F RID: 77359 RVA: 0x001A96AC File Offset: 0x001A78AC
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkCompositeDataReader.vtkCompositeDataReader_ReadMeshSimple_09(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06012E30 RID: 77360
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E31 RID: 77361 RVA: 0x001A96E4 File Offset: 0x001A78E4
		public new static vtkCompositeDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataReader vtkCompositeDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataReader.vtkCompositeDataReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataReader = (vtkCompositeDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataReader.Register(null);
				}
			}
			return vtkCompositeDataReader;
		}

		// Token: 0x06012E32 RID: 77362
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataReader_SetOutput_11(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06012E33 RID: 77363 RVA: 0x001A9764 File Offset: 0x001A7964
		public void SetOutput(vtkCompositeDataSet output)
		{
			vtkCompositeDataReader.vtkCompositeDataReader_SetOutput_11(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015D2 RID: 5586
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015D3 RID: 5587
		public new static readonly string MRClassNameKey = "class vtkCompositeDataReader";
	}
}
