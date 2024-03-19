using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridWriter
	/// </summary>
	/// <remarks>
	///    write vtk unstructured grid data file
	///
	/// vtkUnstructuredGridWriter is a source object that writes ASCII or binary
	/// unstructured grid data files in vtk format. See text for format details.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	// Token: 0x0200071A RID: 1818
	public class vtkUnstructuredGridWriter : vtkDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013098 RID: 77976 RVA: 0x001AE617 File Offset: 0x001AC817
		static vtkUnstructuredGridWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013099 RID: 77977 RVA: 0x001AE63F File Offset: 0x001AC83F
		public vtkUnstructuredGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601309A RID: 77978
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601309B RID: 77979 RVA: 0x001AE650 File Offset: 0x001AC850
		public new static vtkUnstructuredGridWriter New()
		{
			vtkUnstructuredGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridWriter.vtkUnstructuredGridWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601309C RID: 77980 RVA: 0x001AE6A4 File Offset: 0x001AC8A4
		public vtkUnstructuredGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridWriter.vtkUnstructuredGridWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601309D RID: 77981 RVA: 0x001AE6E8 File Offset: 0x001AC8E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601309E RID: 77982
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridWriter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x0601309F RID: 77983 RVA: 0x001AE6F4 File Offset: 0x001AC8F4
		public new vtkUnstructuredGridBase GetInput()
		{
			vtkUnstructuredGridBase vtkUnstructuredGridBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridWriter.vtkUnstructuredGridWriter_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridBase = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridBase.Register(null);
				}
			}
			return vtkUnstructuredGridBase;
		}

		// Token: 0x060130A0 RID: 77984
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridWriter_GetInput_02(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x060130A1 RID: 77985 RVA: 0x001AE764 File Offset: 0x001AC964
		public new vtkUnstructuredGridBase GetInput(int port)
		{
			vtkUnstructuredGridBase vtkUnstructuredGridBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridWriter.vtkUnstructuredGridWriter_GetInput_02(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridBase = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridBase.Register(null);
				}
			}
			return vtkUnstructuredGridBase;
		}

		// Token: 0x060130A2 RID: 77986
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130A3 RID: 77987 RVA: 0x001AE7D4 File Offset: 0x001AC9D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridWriter.vtkUnstructuredGridWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060130A4 RID: 77988
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130A5 RID: 77989 RVA: 0x001AE7F4 File Offset: 0x001AC9F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridWriter.vtkUnstructuredGridWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060130A6 RID: 77990
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130A7 RID: 77991 RVA: 0x001AE810 File Offset: 0x001ACA10
		public override int IsA(string type)
		{
			return vtkUnstructuredGridWriter.vtkUnstructuredGridWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060130A8 RID: 77992
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130A9 RID: 77993 RVA: 0x001AE830 File Offset: 0x001ACA30
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridWriter.vtkUnstructuredGridWriter_IsTypeOf_06(type);
		}

		// Token: 0x060130AA RID: 77994
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130AB RID: 77995 RVA: 0x001AE84C File Offset: 0x001ACA4C
		public new vtkUnstructuredGridWriter NewInstance()
		{
			vtkUnstructuredGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridWriter.vtkUnstructuredGridWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060130AC RID: 77996
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130AD RID: 77997 RVA: 0x001AE8A8 File Offset: 0x001ACAA8
		public new static vtkUnstructuredGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridWriter vtkUnstructuredGridWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridWriter.vtkUnstructuredGridWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridWriter = (vtkUnstructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridWriter.Register(null);
				}
			}
			return vtkUnstructuredGridWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001600 RID: 5632
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001601 RID: 5633
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridWriter";
	}
}
