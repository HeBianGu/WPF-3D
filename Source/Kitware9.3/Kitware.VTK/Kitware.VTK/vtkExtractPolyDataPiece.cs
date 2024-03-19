using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractPolyDataPiece
	/// </summary>
	/// <remarks>
	///    Return specified piece, including specified
	/// number of ghost levels.
	/// </remarks>
	// Token: 0x02000501 RID: 1281
	public class vtkExtractPolyDataPiece : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E6A2 RID: 59042 RVA: 0x00141307 File Offset: 0x0013F507
		static vtkExtractPolyDataPiece()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractPolyDataPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractPolyDataPiece"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E6A3 RID: 59043 RVA: 0x0014132F File Offset: 0x0013F52F
		public vtkExtractPolyDataPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E6A4 RID: 59044
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPolyDataPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6A5 RID: 59045 RVA: 0x00141340 File Offset: 0x0013F540
		public new static vtkExtractPolyDataPiece New()
		{
			vtkExtractPolyDataPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPolyDataPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6A6 RID: 59046 RVA: 0x00141394 File Offset: 0x0013F594
		public vtkExtractPolyDataPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E6A7 RID: 59047 RVA: 0x001413D8 File Offset: 0x0013F5D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E6A8 RID: 59048
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataPiece_CreateGhostCellsOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600E6A9 RID: 59049 RVA: 0x001413E3 File Offset: 0x0013F5E3
		public virtual void CreateGhostCellsOff()
		{
			vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_CreateGhostCellsOff_01(base.GetCppThis());
		}

		// Token: 0x0600E6AA RID: 59050
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataPiece_CreateGhostCellsOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600E6AB RID: 59051 RVA: 0x001413F2 File Offset: 0x0013F5F2
		public virtual void CreateGhostCellsOn()
		{
			vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_CreateGhostCellsOn_02(base.GetCppThis());
		}

		// Token: 0x0600E6AC RID: 59052
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPolyDataPiece_GetCreateGhostCells_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600E6AD RID: 59053 RVA: 0x00141404 File Offset: 0x0013F604
		public virtual int GetCreateGhostCells()
		{
			return vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_GetCreateGhostCells_03(base.GetCppThis());
		}

		// Token: 0x0600E6AE RID: 59054
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractPolyDataPiece_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6AF RID: 59055 RVA: 0x00141424 File Offset: 0x0013F624
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E6B0 RID: 59056
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractPolyDataPiece_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6B1 RID: 59057 RVA: 0x00141444 File Offset: 0x0013F644
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600E6B2 RID: 59058
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPolyDataPiece_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6B3 RID: 59059 RVA: 0x00141460 File Offset: 0x0013F660
		public override int IsA(string type)
		{
			return vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600E6B4 RID: 59060
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPolyDataPiece_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6B5 RID: 59061 RVA: 0x00141480 File Offset: 0x0013F680
		public new static int IsTypeOf(string type)
		{
			return vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_IsTypeOf_07(type);
		}

		// Token: 0x0600E6B6 RID: 59062
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPolyDataPiece_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6B7 RID: 59063 RVA: 0x0014149C File Offset: 0x0013F69C
		public new vtkExtractPolyDataPiece NewInstance()
		{
			vtkExtractPolyDataPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPolyDataPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E6B8 RID: 59064
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPolyDataPiece_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6B9 RID: 59065 RVA: 0x001414F8 File Offset: 0x0013F6F8
		public new static vtkExtractPolyDataPiece SafeDownCast(vtkObjectBase o)
		{
			vtkExtractPolyDataPiece vtkExtractPolyDataPiece = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractPolyDataPiece = (vtkExtractPolyDataPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractPolyDataPiece.Register(null);
				}
			}
			return vtkExtractPolyDataPiece;
		}

		// Token: 0x0600E6BA RID: 59066
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataPiece_SetCreateGhostCells_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off creating ghost cells (on by default).
		/// </summary>
		// Token: 0x0600E6BB RID: 59067 RVA: 0x00141577 File Offset: 0x0013F777
		public virtual void SetCreateGhostCells(int _arg)
		{
			vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_SetCreateGhostCells_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010EB RID: 4331
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractPolyDataPiece";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010EC RID: 4332
		public new static readonly string MRClassNameKey = "class vtkExtractPolyDataPiece";
	}
}
