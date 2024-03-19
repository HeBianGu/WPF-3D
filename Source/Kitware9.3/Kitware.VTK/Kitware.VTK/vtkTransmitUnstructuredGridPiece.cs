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
	/// </remarks>
	// Token: 0x0200053E RID: 1342
	public class vtkTransmitUnstructuredGridPiece : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EEEB RID: 61163 RVA: 0x0014D0D3 File Offset: 0x0014B2D3
		static vtkTransmitUnstructuredGridPiece()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransmitUnstructuredGridPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransmitUnstructuredGridPiece"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EEEC RID: 61164 RVA: 0x0014D0FB File Offset: 0x0014B2FB
		public vtkTransmitUnstructuredGridPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EEED RID: 61165
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitUnstructuredGridPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEEE RID: 61166 RVA: 0x0014D10C File Offset: 0x0014B30C
		public new static vtkTransmitUnstructuredGridPiece New()
		{
			vtkTransmitUnstructuredGridPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitUnstructuredGridPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEEF RID: 61167 RVA: 0x0014D160 File Offset: 0x0014B360
		public vtkTransmitUnstructuredGridPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EEF0 RID: 61168 RVA: 0x0014D1A4 File Offset: 0x0014B3A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EEF1 RID: 61169
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransmitUnstructuredGridPiece_CreateGhostCellsOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600EEF2 RID: 61170 RVA: 0x0014D1AF File Offset: 0x0014B3AF
		public virtual void CreateGhostCellsOff()
		{
			vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_CreateGhostCellsOff_01(base.GetCppThis());
		}

		// Token: 0x0600EEF3 RID: 61171
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransmitUnstructuredGridPiece_CreateGhostCellsOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600EEF4 RID: 61172 RVA: 0x0014D1BE File Offset: 0x0014B3BE
		public virtual void CreateGhostCellsOn()
		{
			vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_CreateGhostCellsOn_02(base.GetCppThis());
		}

		// Token: 0x0600EEF5 RID: 61173
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitUnstructuredGridPiece_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600EEF6 RID: 61174 RVA: 0x0014D1D0 File Offset: 0x0014B3D0
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_GetController_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600EEF7 RID: 61175
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitUnstructuredGridPiece_GetCreateGhostCells_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600EEF8 RID: 61176 RVA: 0x0014D240 File Offset: 0x0014B440
		public virtual int GetCreateGhostCells()
		{
			return vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_GetCreateGhostCells_04(base.GetCppThis());
		}

		// Token: 0x0600EEF9 RID: 61177
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransmitUnstructuredGridPiece_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEFA RID: 61178 RVA: 0x0014D260 File Offset: 0x0014B460
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600EEFB RID: 61179
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransmitUnstructuredGridPiece_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEFC RID: 61180 RVA: 0x0014D280 File Offset: 0x0014B480
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600EEFD RID: 61181
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitUnstructuredGridPiece_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEFE RID: 61182 RVA: 0x0014D29C File Offset: 0x0014B49C
		public override int IsA(string type)
		{
			return vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600EEFF RID: 61183
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitUnstructuredGridPiece_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF00 RID: 61184 RVA: 0x0014D2BC File Offset: 0x0014B4BC
		public new static int IsTypeOf(string type)
		{
			return vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_IsTypeOf_08(type);
		}

		// Token: 0x0600EF01 RID: 61185
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitUnstructuredGridPiece_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF02 RID: 61186 RVA: 0x0014D2D8 File Offset: 0x0014B4D8
		public new vtkTransmitUnstructuredGridPiece NewInstance()
		{
			vtkTransmitUnstructuredGridPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitUnstructuredGridPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EF03 RID: 61187
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitUnstructuredGridPiece_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF04 RID: 61188 RVA: 0x0014D334 File Offset: 0x0014B534
		public new static vtkTransmitUnstructuredGridPiece SafeDownCast(vtkObjectBase o)
		{
			vtkTransmitUnstructuredGridPiece vtkTransmitUnstructuredGridPiece = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransmitUnstructuredGridPiece = (vtkTransmitUnstructuredGridPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransmitUnstructuredGridPiece.Register(null);
				}
			}
			return vtkTransmitUnstructuredGridPiece;
		}

		// Token: 0x0600EF05 RID: 61189
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransmitUnstructuredGridPiece_SetController_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600EF06 RID: 61190 RVA: 0x0014D3B4 File Offset: 0x0014B5B4
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_SetController_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600EF07 RID: 61191
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransmitUnstructuredGridPiece_SetCreateGhostCells_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600EF08 RID: 61192 RVA: 0x0014D3E3 File Offset: 0x0014B5E3
		public virtual void SetCreateGhostCells(int _arg)
		{
			vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_SetCreateGhostCells_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001174 RID: 4468
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransmitUnstructuredGridPiece";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001175 RID: 4469
		public new static readonly string MRClassNameKey = "class vtkTransmitUnstructuredGridPiece";
	}
}
