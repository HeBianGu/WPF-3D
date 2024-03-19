using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridWriter
	/// </summary>
	/// <remarks>
	///    Write a cell-grid file.
	///
	/// Write a cell-grid object to a file. This is a simple JSON format for debugging purposes.
	/// </remarks>
	// Token: 0x020001DD RID: 477
	public class vtkCellGridWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005B04 RID: 23300 RVA: 0x00083C53 File Offset: 0x00081E53
		static vtkCellGridWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005B05 RID: 23301 RVA: 0x00083C7B File Offset: 0x00081E7B
		public vtkCellGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005B06 RID: 23302
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B07 RID: 23303 RVA: 0x00083C8C File Offset: 0x00081E8C
		public new static vtkCellGridWriter New()
		{
			vtkCellGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridWriter.vtkCellGridWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B08 RID: 23304 RVA: 0x00083CE0 File Offset: 0x00081EE0
		public vtkCellGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridWriter.vtkCellGridWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005B09 RID: 23305 RVA: 0x00083D24 File Offset: 0x00081F24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005B0A RID: 23306
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridWriter_GetFileName_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B0B RID: 23307 RVA: 0x00083D30 File Offset: 0x00081F30
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCellGridWriter.vtkCellGridWriter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005B0C RID: 23308
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B0D RID: 23309 RVA: 0x00083D6C File Offset: 0x00081F6C
		public new vtkCellGrid GetInput()
		{
			vtkCellGrid vtkCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridWriter.vtkCellGridWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGrid = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGrid.Register(null);
				}
			}
			return vtkCellGrid;
		}

		// Token: 0x06005B0E RID: 23310
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridWriter_GetInput_03(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B0F RID: 23311 RVA: 0x00083DDC File Offset: 0x00081FDC
		public new vtkCellGrid GetInput(int port)
		{
			vtkCellGrid vtkCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridWriter.vtkCellGridWriter_GetInput_03(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGrid = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGrid.Register(null);
				}
			}
			return vtkCellGrid;
		}

		// Token: 0x06005B10 RID: 23312
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B11 RID: 23313 RVA: 0x00083E4C File Offset: 0x0008204C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridWriter.vtkCellGridWriter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06005B12 RID: 23314
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridWriter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B13 RID: 23315 RVA: 0x00083E6C File Offset: 0x0008206C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridWriter.vtkCellGridWriter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06005B14 RID: 23316
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B15 RID: 23317 RVA: 0x00083E88 File Offset: 0x00082088
		public override int IsA(string type)
		{
			return vtkCellGridWriter.vtkCellGridWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06005B16 RID: 23318
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B17 RID: 23319 RVA: 0x00083EA8 File Offset: 0x000820A8
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridWriter.vtkCellGridWriter_IsTypeOf_07(type);
		}

		// Token: 0x06005B18 RID: 23320
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B19 RID: 23321 RVA: 0x00083EC4 File Offset: 0x000820C4
		public new vtkCellGridWriter NewInstance()
		{
			vtkCellGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridWriter.vtkCellGridWriter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005B1A RID: 23322
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B1B RID: 23323 RVA: 0x00083F20 File Offset: 0x00082120
		public new static vtkCellGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridWriter vtkCellGridWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridWriter.vtkCellGridWriter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridWriter = (vtkCellGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridWriter.Register(null);
				}
			}
			return vtkCellGridWriter;
		}

		// Token: 0x06005B1C RID: 23324
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridWriter_SetFileName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B1D RID: 23325 RVA: 0x00083F9F File Offset: 0x0008219F
		public virtual void SetFileName(string _arg)
		{
			vtkCellGridWriter.vtkCellGridWriter_SetFileName_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000883 RID: 2179
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000884 RID: 2180
		public new static readonly string MRClassNameKey = "class vtkCellGridWriter";
	}
}
