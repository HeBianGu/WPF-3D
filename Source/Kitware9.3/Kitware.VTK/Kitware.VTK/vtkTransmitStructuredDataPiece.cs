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
	// Token: 0x0200047B RID: 1147
	public class vtkTransmitStructuredDataPiece : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D357 RID: 54103 RVA: 0x00126293 File Offset: 0x00124493
		static vtkTransmitStructuredDataPiece()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransmitStructuredDataPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransmitStructuredDataPiece"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D358 RID: 54104 RVA: 0x001262BB File Offset: 0x001244BB
		public vtkTransmitStructuredDataPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D359 RID: 54105
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitStructuredDataPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D35A RID: 54106 RVA: 0x001262CC File Offset: 0x001244CC
		public new static vtkTransmitStructuredDataPiece New()
		{
			vtkTransmitStructuredDataPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitStructuredDataPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D35B RID: 54107 RVA: 0x00126320 File Offset: 0x00124520
		public vtkTransmitStructuredDataPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D35C RID: 54108 RVA: 0x00126364 File Offset: 0x00124564
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D35D RID: 54109
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransmitStructuredDataPiece_CreateGhostCellsOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600D35E RID: 54110 RVA: 0x0012636F File Offset: 0x0012456F
		public virtual void CreateGhostCellsOff()
		{
			vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_CreateGhostCellsOff_01(base.GetCppThis());
		}

		// Token: 0x0600D35F RID: 54111
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransmitStructuredDataPiece_CreateGhostCellsOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600D360 RID: 54112 RVA: 0x0012637E File Offset: 0x0012457E
		public virtual void CreateGhostCellsOn()
		{
			vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_CreateGhostCellsOn_02(base.GetCppThis());
		}

		// Token: 0x0600D361 RID: 54113
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitStructuredDataPiece_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600D362 RID: 54114 RVA: 0x00126390 File Offset: 0x00124590
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_GetController_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600D363 RID: 54115
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitStructuredDataPiece_GetCreateGhostCells_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600D364 RID: 54116 RVA: 0x00126400 File Offset: 0x00124600
		public virtual int GetCreateGhostCells()
		{
			return vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_GetCreateGhostCells_04(base.GetCppThis());
		}

		// Token: 0x0600D365 RID: 54117
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransmitStructuredDataPiece_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D366 RID: 54118 RVA: 0x00126420 File Offset: 0x00124620
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600D367 RID: 54119
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransmitStructuredDataPiece_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D368 RID: 54120 RVA: 0x00126440 File Offset: 0x00124640
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600D369 RID: 54121
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitStructuredDataPiece_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D36A RID: 54122 RVA: 0x0012645C File Offset: 0x0012465C
		public override int IsA(string type)
		{
			return vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600D36B RID: 54123
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitStructuredDataPiece_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D36C RID: 54124 RVA: 0x0012647C File Offset: 0x0012467C
		public new static int IsTypeOf(string type)
		{
			return vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_IsTypeOf_08(type);
		}

		// Token: 0x0600D36D RID: 54125
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitStructuredDataPiece_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D36E RID: 54126 RVA: 0x00126498 File Offset: 0x00124698
		public new vtkTransmitStructuredDataPiece NewInstance()
		{
			vtkTransmitStructuredDataPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitStructuredDataPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D36F RID: 54127
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitStructuredDataPiece_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D370 RID: 54128 RVA: 0x001264F4 File Offset: 0x001246F4
		public new static vtkTransmitStructuredDataPiece SafeDownCast(vtkObjectBase o)
		{
			vtkTransmitStructuredDataPiece vtkTransmitStructuredDataPiece = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransmitStructuredDataPiece = (vtkTransmitStructuredDataPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransmitStructuredDataPiece.Register(null);
				}
			}
			return vtkTransmitStructuredDataPiece;
		}

		// Token: 0x0600D371 RID: 54129
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransmitStructuredDataPiece_SetController_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600D372 RID: 54130 RVA: 0x00126574 File Offset: 0x00124774
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_SetController_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D373 RID: 54131
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransmitStructuredDataPiece_SetCreateGhostCells_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600D374 RID: 54132 RVA: 0x001265A3 File Offset: 0x001247A3
		public virtual void SetCreateGhostCells(int _arg)
		{
			vtkTransmitStructuredDataPiece.vtkTransmitStructuredDataPiece_SetCreateGhostCells_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F9E RID: 3998
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransmitStructuredDataPiece";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F9F RID: 3999
		public new static readonly string MRClassNameKey = "class vtkTransmitStructuredDataPiece";
	}
}
