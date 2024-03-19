using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractUnstructuredGridPiece
	/// </summary>
	/// <remarks>
	///    Return specified piece, including specified
	/// number of ghost levels.
	/// </remarks>
	// Token: 0x02000502 RID: 1282
	public class vtkExtractUnstructuredGridPiece : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E6BC RID: 59068 RVA: 0x00141587 File Offset: 0x0013F787
		static vtkExtractUnstructuredGridPiece()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractUnstructuredGridPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractUnstructuredGridPiece"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E6BD RID: 59069 RVA: 0x001415AF File Offset: 0x0013F7AF
		public vtkExtractUnstructuredGridPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E6BE RID: 59070
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractUnstructuredGridPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6BF RID: 59071 RVA: 0x001415C0 File Offset: 0x0013F7C0
		public new static vtkExtractUnstructuredGridPiece New()
		{
			vtkExtractUnstructuredGridPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractUnstructuredGridPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6C0 RID: 59072 RVA: 0x00141614 File Offset: 0x0013F814
		public vtkExtractUnstructuredGridPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E6C1 RID: 59073 RVA: 0x00141658 File Offset: 0x0013F858
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E6C2 RID: 59074
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGridPiece_CreateGhostCellsOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600E6C3 RID: 59075 RVA: 0x00141663 File Offset: 0x0013F863
		public virtual void CreateGhostCellsOff()
		{
			vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_CreateGhostCellsOff_01(base.GetCppThis());
		}

		// Token: 0x0600E6C4 RID: 59076
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGridPiece_CreateGhostCellsOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600E6C5 RID: 59077 RVA: 0x00141672 File Offset: 0x0013F872
		public virtual void CreateGhostCellsOn()
		{
			vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_CreateGhostCellsOn_02(base.GetCppThis());
		}

		// Token: 0x0600E6C6 RID: 59078
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractUnstructuredGridPiece_GetCreateGhostCells_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600E6C7 RID: 59079 RVA: 0x00141684 File Offset: 0x0013F884
		public virtual int GetCreateGhostCells()
		{
			return vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_GetCreateGhostCells_03(base.GetCppThis());
		}

		// Token: 0x0600E6C8 RID: 59080
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGridPiece_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6C9 RID: 59081 RVA: 0x001416A4 File Offset: 0x0013F8A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E6CA RID: 59082
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGridPiece_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6CB RID: 59083 RVA: 0x001416C4 File Offset: 0x0013F8C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600E6CC RID: 59084
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractUnstructuredGridPiece_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6CD RID: 59085 RVA: 0x001416E0 File Offset: 0x0013F8E0
		public override int IsA(string type)
		{
			return vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600E6CE RID: 59086
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractUnstructuredGridPiece_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6CF RID: 59087 RVA: 0x00141700 File Offset: 0x0013F900
		public new static int IsTypeOf(string type)
		{
			return vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_IsTypeOf_07(type);
		}

		// Token: 0x0600E6D0 RID: 59088
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractUnstructuredGridPiece_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6D1 RID: 59089 RVA: 0x0014171C File Offset: 0x0013F91C
		public new vtkExtractUnstructuredGridPiece NewInstance()
		{
			vtkExtractUnstructuredGridPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractUnstructuredGridPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E6D2 RID: 59090
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractUnstructuredGridPiece_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6D3 RID: 59091 RVA: 0x00141778 File Offset: 0x0013F978
		public new static vtkExtractUnstructuredGridPiece SafeDownCast(vtkObjectBase o)
		{
			vtkExtractUnstructuredGridPiece vtkExtractUnstructuredGridPiece = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractUnstructuredGridPiece = (vtkExtractUnstructuredGridPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractUnstructuredGridPiece.Register(null);
				}
			}
			return vtkExtractUnstructuredGridPiece;
		}

		// Token: 0x0600E6D4 RID: 59092
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGridPiece_SetCreateGhostCells_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600E6D5 RID: 59093 RVA: 0x001417F7 File Offset: 0x0013F9F7
		public virtual void SetCreateGhostCells(int _arg)
		{
			vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_SetCreateGhostCells_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010ED RID: 4333
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractUnstructuredGridPiece";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010EE RID: 4334
		public new static readonly string MRClassNameKey = "class vtkExtractUnstructuredGridPiece";
	}
}
