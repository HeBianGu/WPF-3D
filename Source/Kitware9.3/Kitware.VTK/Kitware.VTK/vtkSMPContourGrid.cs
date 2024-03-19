﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSMPContourGrid
	/// </summary>
	/// <remarks>
	///    a subclass of vtkContourGrid that works in parallel
	/// vtkSMPContourGrid performs the same functionality as vtkContourGrid but does
	/// it using multiple threads. This will probably be merged with vtkContourGrid
	/// in the future.
	/// </remarks>
	// Token: 0x0200041E RID: 1054
	public class vtkSMPContourGrid : vtkContourGrid
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C6BC RID: 50876 RVA: 0x001146EA File Offset: 0x001128EA
		static vtkSMPContourGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSMPContourGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSMPContourGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C6BD RID: 50877 RVA: 0x00114712 File Offset: 0x00112912
		public vtkSMPContourGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C6BE RID: 50878
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSMPContourGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Constructor.
		/// </summary>
		// Token: 0x0600C6BF RID: 50879 RVA: 0x00114720 File Offset: 0x00112920
		public new static vtkSMPContourGrid New()
		{
			vtkSMPContourGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSMPContourGrid.vtkSMPContourGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSMPContourGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		// Token: 0x0600C6C0 RID: 50880 RVA: 0x00114774 File Offset: 0x00112974
		public vtkSMPContourGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSMPContourGrid.vtkSMPContourGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C6C1 RID: 50881 RVA: 0x001147B8 File Offset: 0x001129B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C6C2 RID: 50882
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSMPContourGrid_GetMergePieces_01(HandleRef pThis);

		/// <summary>
		/// If MergePieces is true (default), this filter will merge all
		/// pieces generated by processing the input with multiple threads.
		/// The output will be a vtkPolyData. Note that this has a slight overhead
		/// which becomes more significant as the number of threads used grows.
		/// If MergePieces is false, this filter will generate a vtkMultiBlock
		/// of vtkPolyData where the number of pieces will be equal to the number
		/// of threads used.
		/// </summary>
		// Token: 0x0600C6C3 RID: 50883 RVA: 0x001147C4 File Offset: 0x001129C4
		public virtual bool GetMergePieces()
		{
			return vtkSMPContourGrid.vtkSMPContourGrid_GetMergePieces_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C6C4 RID: 50884
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSMPContourGrid_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C6C5 RID: 50885 RVA: 0x001147EC File Offset: 0x001129EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSMPContourGrid.vtkSMPContourGrid_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C6C6 RID: 50886
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSMPContourGrid_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C6C7 RID: 50887 RVA: 0x0011480C File Offset: 0x00112A0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSMPContourGrid.vtkSMPContourGrid_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C6C8 RID: 50888
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSMPContourGrid_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C6C9 RID: 50889 RVA: 0x00114828 File Offset: 0x00112A28
		public override int IsA(string type)
		{
			return vtkSMPContourGrid.vtkSMPContourGrid_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C6CA RID: 50890
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSMPContourGrid_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C6CB RID: 50891 RVA: 0x00114848 File Offset: 0x00112A48
		public new static int IsTypeOf(string type)
		{
			return vtkSMPContourGrid.vtkSMPContourGrid_IsTypeOf_05(type);
		}

		// Token: 0x0600C6CC RID: 50892
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSMPContourGrid_MergePiecesOff_06(HandleRef pThis);

		/// <summary>
		/// If MergePieces is true (default), this filter will merge all
		/// pieces generated by processing the input with multiple threads.
		/// The output will be a vtkPolyData. Note that this has a slight overhead
		/// which becomes more significant as the number of threads used grows.
		/// If MergePieces is false, this filter will generate a vtkMultiBlock
		/// of vtkPolyData where the number of pieces will be equal to the number
		/// of threads used.
		/// </summary>
		// Token: 0x0600C6CD RID: 50893 RVA: 0x00114862 File Offset: 0x00112A62
		public virtual void MergePiecesOff()
		{
			vtkSMPContourGrid.vtkSMPContourGrid_MergePiecesOff_06(base.GetCppThis());
		}

		// Token: 0x0600C6CE RID: 50894
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSMPContourGrid_MergePiecesOn_07(HandleRef pThis);

		/// <summary>
		/// If MergePieces is true (default), this filter will merge all
		/// pieces generated by processing the input with multiple threads.
		/// The output will be a vtkPolyData. Note that this has a slight overhead
		/// which becomes more significant as the number of threads used grows.
		/// If MergePieces is false, this filter will generate a vtkMultiBlock
		/// of vtkPolyData where the number of pieces will be equal to the number
		/// of threads used.
		/// </summary>
		// Token: 0x0600C6CF RID: 50895 RVA: 0x00114871 File Offset: 0x00112A71
		public virtual void MergePiecesOn()
		{
			vtkSMPContourGrid.vtkSMPContourGrid_MergePiecesOn_07(base.GetCppThis());
		}

		// Token: 0x0600C6D0 RID: 50896
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSMPContourGrid_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C6D1 RID: 50897 RVA: 0x00114880 File Offset: 0x00112A80
		public new vtkSMPContourGrid NewInstance()
		{
			vtkSMPContourGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSMPContourGrid.vtkSMPContourGrid_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSMPContourGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C6D2 RID: 50898
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSMPContourGrid_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C6D3 RID: 50899 RVA: 0x001148DC File Offset: 0x00112ADC
		public new static vtkSMPContourGrid SafeDownCast(vtkObjectBase o)
		{
			vtkSMPContourGrid vtkSMPContourGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSMPContourGrid.vtkSMPContourGrid_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSMPContourGrid = (vtkSMPContourGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSMPContourGrid.Register(null);
				}
			}
			return vtkSMPContourGrid;
		}

		// Token: 0x0600C6D4 RID: 50900
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSMPContourGrid_SetMergePieces_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// If MergePieces is true (default), this filter will merge all
		/// pieces generated by processing the input with multiple threads.
		/// The output will be a vtkPolyData. Note that this has a slight overhead
		/// which becomes more significant as the number of threads used grows.
		/// If MergePieces is false, this filter will generate a vtkMultiBlock
		/// of vtkPolyData where the number of pieces will be equal to the number
		/// of threads used.
		/// </summary>
		// Token: 0x0600C6D5 RID: 50901 RVA: 0x0011495B File Offset: 0x00112B5B
		public virtual void SetMergePieces(bool _arg)
		{
			vtkSMPContourGrid.vtkSMPContourGrid_SetMergePieces_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ECD RID: 3789
		public new const string MRFullTypeName = "Kitware.VTK.vtkSMPContourGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ECE RID: 3790
		public new static readonly string MRClassNameKey = "class vtkSMPContourGrid";
	}
}
