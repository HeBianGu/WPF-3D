using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeCellGridReader
	/// </summary>
	/// <remarks>
	///    Read a cell-grid file.
	///
	/// vtkCompositeCellGridReader is a concrete subclass of
	/// vtkReaderAlgorithm that reads data into multiple vtkCellGrid instances.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkReaderAlgorithm
	/// vtkCellGridImporter
	/// </seealso>
	// Token: 0x020001DE RID: 478
	public class vtkCompositeCellGridReader : vtkReaderAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005B1E RID: 23326 RVA: 0x00083FAF File Offset: 0x000821AF
		static vtkCompositeCellGridReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeCellGridReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeCellGridReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005B1F RID: 23327 RVA: 0x00083FD7 File Offset: 0x000821D7
		public vtkCompositeCellGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005B20 RID: 23328
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCellGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B21 RID: 23329 RVA: 0x00083FE8 File Offset: 0x000821E8
		public new static vtkCompositeCellGridReader New()
		{
			vtkCompositeCellGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeCellGridReader.vtkCompositeCellGridReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeCellGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B22 RID: 23330 RVA: 0x0008403C File Offset: 0x0008223C
		public vtkCompositeCellGridReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeCellGridReader.vtkCompositeCellGridReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005B23 RID: 23331 RVA: 0x00084080 File Offset: 0x00082280
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005B24 RID: 23332
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCellGridReader_GetCellAttributeSelection_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the name of the file from which to read data.
		/// </summary>
		// Token: 0x06005B25 RID: 23333 RVA: 0x0008408C File Offset: 0x0008228C
		public vtkDataArraySelection GetCellAttributeSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeCellGridReader.vtkCompositeCellGridReader_GetCellAttributeSelection_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005B26 RID: 23334
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCellGridReader_GetCellTypeSelection_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the name of the file from which to read data.
		/// </summary>
		// Token: 0x06005B27 RID: 23335 RVA: 0x000840FC File Offset: 0x000822FC
		public vtkDataArraySelection GetCellTypeSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeCellGridReader.vtkCompositeCellGridReader_GetCellTypeSelection_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005B28 RID: 23336
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCellGridReader_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the file from which to read data.
		/// </summary>
		// Token: 0x06005B29 RID: 23337 RVA: 0x0008416C File Offset: 0x0008236C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCompositeCellGridReader.vtkCompositeCellGridReader_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005B2A RID: 23338
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkCompositeCellGridReader_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the file from which to read data.
		/// </summary>
		// Token: 0x06005B2B RID: 23339 RVA: 0x000841A8 File Offset: 0x000823A8
		public override ulong GetMTime()
		{
			return vtkCompositeCellGridReader.vtkCompositeCellGridReader_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x06005B2C RID: 23340
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeCellGridReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B2D RID: 23341 RVA: 0x000841C8 File Offset: 0x000823C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeCellGridReader.vtkCompositeCellGridReader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06005B2E RID: 23342
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeCellGridReader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B2F RID: 23343 RVA: 0x000841E8 File Offset: 0x000823E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeCellGridReader.vtkCompositeCellGridReader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06005B30 RID: 23344
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeCellGridReader_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B31 RID: 23345 RVA: 0x00084204 File Offset: 0x00082404
		public override int IsA(string type)
		{
			return vtkCompositeCellGridReader.vtkCompositeCellGridReader_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06005B32 RID: 23346
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeCellGridReader_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B33 RID: 23347 RVA: 0x00084224 File Offset: 0x00082424
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeCellGridReader.vtkCompositeCellGridReader_IsTypeOf_08(type);
		}

		// Token: 0x06005B34 RID: 23348
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCellGridReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B35 RID: 23349 RVA: 0x00084240 File Offset: 0x00082440
		public new vtkCompositeCellGridReader NewInstance()
		{
			vtkCompositeCellGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeCellGridReader.vtkCompositeCellGridReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeCellGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005B36 RID: 23350
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCellGridReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B37 RID: 23351 RVA: 0x0008429C File Offset: 0x0008249C
		public new static vtkCompositeCellGridReader SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeCellGridReader vtkCompositeCellGridReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeCellGridReader.vtkCompositeCellGridReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeCellGridReader = (vtkCompositeCellGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeCellGridReader.Register(null);
				}
			}
			return vtkCompositeCellGridReader;
		}

		// Token: 0x06005B38 RID: 23352
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridReader_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the file from which to read data.
		/// </summary>
		// Token: 0x06005B39 RID: 23353 RVA: 0x0008431B File Offset: 0x0008251B
		public virtual void SetFileName(string _arg)
		{
			vtkCompositeCellGridReader.vtkCompositeCellGridReader_SetFileName_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000885 RID: 2181
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeCellGridReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000886 RID: 2182
		public new static readonly string MRClassNameKey = "class vtkCompositeCellGridReader";
	}
}
