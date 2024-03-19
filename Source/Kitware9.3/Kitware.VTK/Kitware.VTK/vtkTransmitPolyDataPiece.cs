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
	// Token: 0x0200053B RID: 1339
	public class vtkTransmitPolyDataPiece : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EEA9 RID: 61097 RVA: 0x0014C953 File Offset: 0x0014AB53
		static vtkTransmitPolyDataPiece()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransmitPolyDataPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransmitPolyDataPiece"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EEAA RID: 61098 RVA: 0x0014C97B File Offset: 0x0014AB7B
		public vtkTransmitPolyDataPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EEAB RID: 61099
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitPolyDataPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEAC RID: 61100 RVA: 0x0014C98C File Offset: 0x0014AB8C
		public new static vtkTransmitPolyDataPiece New()
		{
			vtkTransmitPolyDataPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitPolyDataPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEAD RID: 61101 RVA: 0x0014C9E0 File Offset: 0x0014ABE0
		public vtkTransmitPolyDataPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EEAE RID: 61102 RVA: 0x0014CA24 File Offset: 0x0014AC24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EEAF RID: 61103
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransmitPolyDataPiece_CreateGhostCellsOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600EEB0 RID: 61104 RVA: 0x0014CA2F File Offset: 0x0014AC2F
		public virtual void CreateGhostCellsOff()
		{
			vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_CreateGhostCellsOff_01(base.GetCppThis());
		}

		// Token: 0x0600EEB1 RID: 61105
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransmitPolyDataPiece_CreateGhostCellsOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600EEB2 RID: 61106 RVA: 0x0014CA3E File Offset: 0x0014AC3E
		public virtual void CreateGhostCellsOn()
		{
			vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_CreateGhostCellsOn_02(base.GetCppThis());
		}

		// Token: 0x0600EEB3 RID: 61107
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitPolyDataPiece_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600EEB4 RID: 61108 RVA: 0x0014CA50 File Offset: 0x0014AC50
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_GetController_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600EEB5 RID: 61109
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitPolyDataPiece_GetCreateGhostCells_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600EEB6 RID: 61110 RVA: 0x0014CAC0 File Offset: 0x0014ACC0
		public virtual int GetCreateGhostCells()
		{
			return vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_GetCreateGhostCells_04(base.GetCppThis());
		}

		// Token: 0x0600EEB7 RID: 61111
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransmitPolyDataPiece_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEB8 RID: 61112 RVA: 0x0014CAE0 File Offset: 0x0014ACE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600EEB9 RID: 61113
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransmitPolyDataPiece_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEBA RID: 61114 RVA: 0x0014CB00 File Offset: 0x0014AD00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600EEBB RID: 61115
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitPolyDataPiece_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEBC RID: 61116 RVA: 0x0014CB1C File Offset: 0x0014AD1C
		public override int IsA(string type)
		{
			return vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600EEBD RID: 61117
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitPolyDataPiece_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEBE RID: 61118 RVA: 0x0014CB3C File Offset: 0x0014AD3C
		public new static int IsTypeOf(string type)
		{
			return vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_IsTypeOf_08(type);
		}

		// Token: 0x0600EEBF RID: 61119
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitPolyDataPiece_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEC0 RID: 61120 RVA: 0x0014CB58 File Offset: 0x0014AD58
		public new vtkTransmitPolyDataPiece NewInstance()
		{
			vtkTransmitPolyDataPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitPolyDataPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EEC1 RID: 61121
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitPolyDataPiece_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEC2 RID: 61122 RVA: 0x0014CBB4 File Offset: 0x0014ADB4
		public new static vtkTransmitPolyDataPiece SafeDownCast(vtkObjectBase o)
		{
			vtkTransmitPolyDataPiece vtkTransmitPolyDataPiece = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransmitPolyDataPiece = (vtkTransmitPolyDataPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransmitPolyDataPiece.Register(null);
				}
			}
			return vtkTransmitPolyDataPiece;
		}

		// Token: 0x0600EEC3 RID: 61123
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransmitPolyDataPiece_SetController_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600EEC4 RID: 61124 RVA: 0x0014CC34 File Offset: 0x0014AE34
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_SetController_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600EEC5 RID: 61125
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransmitPolyDataPiece_SetCreateGhostCells_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600EEC6 RID: 61126 RVA: 0x0014CC63 File Offset: 0x0014AE63
		public virtual void SetCreateGhostCells(int _arg)
		{
			vtkTransmitPolyDataPiece.vtkTransmitPolyDataPiece_SetCreateGhostCells_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400116E RID: 4462
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransmitPolyDataPiece";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400116F RID: 4463
		public new static readonly string MRClassNameKey = "class vtkTransmitPolyDataPiece";
	}
}
