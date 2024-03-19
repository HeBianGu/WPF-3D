using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransmitRectilinearGridPiece
	/// </summary>
	/// <remarks>
	///    Redistributes data produced
	/// by serial readers
	///
	///
	/// This filter can be used to redistribute data from producers that can't
	/// produce data in parallel. All data is produced on first process and
	/// the distributed to others using the multiprocess controller.
	///
	/// Note that this class is legacy. The superclass does all the work and
	/// can be used directly instead.
	/// </remarks>
	// Token: 0x0200053D RID: 1341
	public class vtkTransmitStructuredGridPiece : vtkTransmitStructuredDataPiece
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EED9 RID: 61145 RVA: 0x0014CEA3 File Offset: 0x0014B0A3
		static vtkTransmitStructuredGridPiece()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransmitStructuredGridPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransmitStructuredGridPiece"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EEDA RID: 61146 RVA: 0x0014CECB File Offset: 0x0014B0CB
		public vtkTransmitStructuredGridPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EEDB RID: 61147
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitStructuredGridPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEDC RID: 61148 RVA: 0x0014CEDC File Offset: 0x0014B0DC
		public new static vtkTransmitStructuredGridPiece New()
		{
			vtkTransmitStructuredGridPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitStructuredGridPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEDD RID: 61149 RVA: 0x0014CF30 File Offset: 0x0014B130
		public vtkTransmitStructuredGridPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EEDE RID: 61150 RVA: 0x0014CF74 File Offset: 0x0014B174
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EEDF RID: 61151
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransmitStructuredGridPiece_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEE0 RID: 61152 RVA: 0x0014CF80 File Offset: 0x0014B180
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600EEE1 RID: 61153
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransmitStructuredGridPiece_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEE2 RID: 61154 RVA: 0x0014CFA0 File Offset: 0x0014B1A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600EEE3 RID: 61155
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitStructuredGridPiece_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEE4 RID: 61156 RVA: 0x0014CFBC File Offset: 0x0014B1BC
		public override int IsA(string type)
		{
			return vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600EEE5 RID: 61157
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitStructuredGridPiece_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEE6 RID: 61158 RVA: 0x0014CFDC File Offset: 0x0014B1DC
		public new static int IsTypeOf(string type)
		{
			return vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_IsTypeOf_04(type);
		}

		// Token: 0x0600EEE7 RID: 61159
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitStructuredGridPiece_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEE8 RID: 61160 RVA: 0x0014CFF8 File Offset: 0x0014B1F8
		public new vtkTransmitStructuredGridPiece NewInstance()
		{
			vtkTransmitStructuredGridPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitStructuredGridPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EEE9 RID: 61161
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitStructuredGridPiece_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEEA RID: 61162 RVA: 0x0014D054 File Offset: 0x0014B254
		public new static vtkTransmitStructuredGridPiece SafeDownCast(vtkObjectBase o)
		{
			vtkTransmitStructuredGridPiece vtkTransmitStructuredGridPiece = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransmitStructuredGridPiece = (vtkTransmitStructuredGridPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransmitStructuredGridPiece.Register(null);
				}
			}
			return vtkTransmitStructuredGridPiece;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001172 RID: 4466
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransmitStructuredGridPiece";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001173 RID: 4467
		public new static readonly string MRClassNameKey = "class vtkTransmitStructuredGridPiece";
	}
}
