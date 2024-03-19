using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPCellDataToPointData
	/// </summary>
	/// <remarks>
	///    Compute point arrays from cell arrays.
	///
	/// This class is deprecated. Use `vtkCellDataToPointData` which now supports
	/// the `PieceInvariant` flag.
	/// </remarks>
	// Token: 0x0200050C RID: 1292
	public class vtkPCellDataToPointData : vtkCellDataToPointData
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E7BC RID: 59324 RVA: 0x00142CD3 File Offset: 0x00140ED3
		static vtkPCellDataToPointData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPCellDataToPointData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCellDataToPointData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E7BD RID: 59325 RVA: 0x00142CFB File Offset: 0x00140EFB
		public vtkPCellDataToPointData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E7BE RID: 59326
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCellDataToPointData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7BF RID: 59327 RVA: 0x00142D0C File Offset: 0x00140F0C
		public new static vtkPCellDataToPointData New()
		{
			vtkPCellDataToPointData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCellDataToPointData.vtkPCellDataToPointData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCellDataToPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7C0 RID: 59328 RVA: 0x00142D60 File Offset: 0x00140F60
		public vtkPCellDataToPointData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPCellDataToPointData.vtkPCellDataToPointData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E7C1 RID: 59329 RVA: 0x00142DA4 File Offset: 0x00140FA4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E7C2 RID: 59330
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPCellDataToPointData_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7C3 RID: 59331 RVA: 0x00142DB0 File Offset: 0x00140FB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPCellDataToPointData.vtkPCellDataToPointData_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E7C4 RID: 59332
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPCellDataToPointData_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7C5 RID: 59333 RVA: 0x00142DD0 File Offset: 0x00140FD0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPCellDataToPointData.vtkPCellDataToPointData_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E7C6 RID: 59334
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCellDataToPointData_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7C7 RID: 59335 RVA: 0x00142DEC File Offset: 0x00140FEC
		public override int IsA(string type)
		{
			return vtkPCellDataToPointData.vtkPCellDataToPointData_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E7C8 RID: 59336
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCellDataToPointData_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7C9 RID: 59337 RVA: 0x00142E0C File Offset: 0x0014100C
		public new static int IsTypeOf(string type)
		{
			return vtkPCellDataToPointData.vtkPCellDataToPointData_IsTypeOf_04(type);
		}

		// Token: 0x0600E7CA RID: 59338
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCellDataToPointData_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7CB RID: 59339 RVA: 0x00142E28 File Offset: 0x00141028
		public new vtkPCellDataToPointData NewInstance()
		{
			vtkPCellDataToPointData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCellDataToPointData.vtkPCellDataToPointData_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCellDataToPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E7CC RID: 59340
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCellDataToPointData_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7CD RID: 59341 RVA: 0x00142E84 File Offset: 0x00141084
		public new static vtkPCellDataToPointData SafeDownCast(vtkObjectBase o)
		{
			vtkPCellDataToPointData vtkPCellDataToPointData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCellDataToPointData.vtkPCellDataToPointData_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPCellDataToPointData = (vtkPCellDataToPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPCellDataToPointData.Register(null);
				}
			}
			return vtkPCellDataToPointData;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001102 RID: 4354
		public new const string MRFullTypeName = "Kitware.VTK.vtkPCellDataToPointData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001103 RID: 4355
		public new static readonly string MRClassNameKey = "class vtkPCellDataToPointData";
	}
}
