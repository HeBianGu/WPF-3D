using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPieceRequestFilter
	/// </summary>
	/// <remarks>
	///    Sets the piece request for upstream filters.
	///
	/// Sends the piece and number of pieces to upstream filters; passes the input
	/// to the output unmodified.
	/// </remarks>
	// Token: 0x02000515 RID: 1301
	public class vtkPieceRequestFilter : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E89C RID: 59548 RVA: 0x001445DB File Offset: 0x001427DB
		static vtkPieceRequestFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPieceRequestFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPieceRequestFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E89D RID: 59549 RVA: 0x00144603 File Offset: 0x00142803
		public vtkPieceRequestFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E89E RID: 59550
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieceRequestFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E89F RID: 59551 RVA: 0x00144614 File Offset: 0x00142814
		public new static vtkPieceRequestFilter New()
		{
			vtkPieceRequestFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieceRequestFilter.vtkPieceRequestFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPieceRequestFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8A0 RID: 59552 RVA: 0x00144668 File Offset: 0x00142868
		public vtkPieceRequestFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPieceRequestFilter.vtkPieceRequestFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E8A1 RID: 59553 RVA: 0x001446AC File Offset: 0x001428AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E8A2 RID: 59554
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPieceRequestFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8A3 RID: 59555 RVA: 0x001446B8 File Offset: 0x001428B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E8A4 RID: 59556
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPieceRequestFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8A5 RID: 59557 RVA: 0x001446D8 File Offset: 0x001428D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E8A6 RID: 59558
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieceRequestFilter_GetNumberOfPieces_03(HandleRef pThis);

		/// <summary>
		/// The total number of pieces.
		/// </summary>
		// Token: 0x0600E8A7 RID: 59559 RVA: 0x001446F4 File Offset: 0x001428F4
		public virtual int GetNumberOfPieces()
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetNumberOfPieces_03(base.GetCppThis());
		}

		// Token: 0x0600E8A8 RID: 59560
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieceRequestFilter_GetNumberOfPiecesMaxValue_04(HandleRef pThis);

		/// <summary>
		/// The total number of pieces.
		/// </summary>
		// Token: 0x0600E8A9 RID: 59561 RVA: 0x00144714 File Offset: 0x00142914
		public virtual int GetNumberOfPiecesMaxValue()
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetNumberOfPiecesMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600E8AA RID: 59562
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieceRequestFilter_GetNumberOfPiecesMinValue_05(HandleRef pThis);

		/// <summary>
		/// The total number of pieces.
		/// </summary>
		// Token: 0x0600E8AB RID: 59563 RVA: 0x00144734 File Offset: 0x00142934
		public virtual int GetNumberOfPiecesMinValue()
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetNumberOfPiecesMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600E8AC RID: 59564
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieceRequestFilter_GetOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0600E8AD RID: 59565 RVA: 0x00144754 File Offset: 0x00142954
		public vtkDataObject GetOutput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieceRequestFilter.vtkPieceRequestFilter_GetOutput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0600E8AE RID: 59566
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieceRequestFilter_GetOutput_07(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0600E8AF RID: 59567 RVA: 0x001447C4 File Offset: 0x001429C4
		public vtkDataObject GetOutput(int arg0)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieceRequestFilter.vtkPieceRequestFilter_GetOutput_07(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0600E8B0 RID: 59568
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieceRequestFilter_GetPiece_08(HandleRef pThis);

		/// <summary>
		/// The piece to extract.
		/// </summary>
		// Token: 0x0600E8B1 RID: 59569 RVA: 0x00144834 File Offset: 0x00142A34
		public virtual int GetPiece()
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetPiece_08(base.GetCppThis());
		}

		// Token: 0x0600E8B2 RID: 59570
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieceRequestFilter_GetPieceMaxValue_09(HandleRef pThis);

		/// <summary>
		/// The piece to extract.
		/// </summary>
		// Token: 0x0600E8B3 RID: 59571 RVA: 0x00144854 File Offset: 0x00142A54
		public virtual int GetPieceMaxValue()
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetPieceMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600E8B4 RID: 59572
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieceRequestFilter_GetPieceMinValue_10(HandleRef pThis);

		/// <summary>
		/// The piece to extract.
		/// </summary>
		// Token: 0x0600E8B5 RID: 59573 RVA: 0x00144874 File Offset: 0x00142A74
		public virtual int GetPieceMinValue()
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetPieceMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600E8B6 RID: 59574
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieceRequestFilter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8B7 RID: 59575 RVA: 0x00144894 File Offset: 0x00142A94
		public override int IsA(string type)
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600E8B8 RID: 59576
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieceRequestFilter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8B9 RID: 59577 RVA: 0x001448B4 File Offset: 0x00142AB4
		public new static int IsTypeOf(string type)
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_IsTypeOf_12(type);
		}

		// Token: 0x0600E8BA RID: 59578
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieceRequestFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8BB RID: 59579 RVA: 0x001448D0 File Offset: 0x00142AD0
		public new vtkPieceRequestFilter NewInstance()
		{
			vtkPieceRequestFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieceRequestFilter.vtkPieceRequestFilter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPieceRequestFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E8BC RID: 59580
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieceRequestFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8BD RID: 59581 RVA: 0x0014492C File Offset: 0x00142B2C
		public new static vtkPieceRequestFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPieceRequestFilter vtkPieceRequestFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieceRequestFilter.vtkPieceRequestFilter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPieceRequestFilter = (vtkPieceRequestFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPieceRequestFilter.Register(null);
				}
			}
			return vtkPieceRequestFilter;
		}

		// Token: 0x0600E8BE RID: 59582
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieceRequestFilter_SetInputData_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set an input of this algorithm.
		/// </summary>
		// Token: 0x0600E8BF RID: 59583 RVA: 0x001449AC File Offset: 0x00142BAC
		public void SetInputData(vtkDataObject arg0)
		{
			vtkPieceRequestFilter.vtkPieceRequestFilter_SetInputData_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600E8C0 RID: 59584
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieceRequestFilter_SetInputData_17(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Set an input of this algorithm.
		/// </summary>
		// Token: 0x0600E8C1 RID: 59585 RVA: 0x001449DC File Offset: 0x00142BDC
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkPieceRequestFilter.vtkPieceRequestFilter_SetInputData_17(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600E8C2 RID: 59586
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieceRequestFilter_SetNumberOfPieces_18(HandleRef pThis, int _arg);

		/// <summary>
		/// The total number of pieces.
		/// </summary>
		// Token: 0x0600E8C3 RID: 59587 RVA: 0x00144A0C File Offset: 0x00142C0C
		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkPieceRequestFilter.vtkPieceRequestFilter_SetNumberOfPieces_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E8C4 RID: 59588
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieceRequestFilter_SetPiece_19(HandleRef pThis, int _arg);

		/// <summary>
		/// The piece to extract.
		/// </summary>
		// Token: 0x0600E8C5 RID: 59589 RVA: 0x00144A1C File Offset: 0x00142C1C
		public virtual void SetPiece(int _arg)
		{
			vtkPieceRequestFilter.vtkPieceRequestFilter_SetPiece_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001114 RID: 4372
		public new const string MRFullTypeName = "Kitware.VTK.vtkPieceRequestFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001115 RID: 4373
		public new static readonly string MRClassNameKey = "class vtkPieceRequestFilter";
	}
}
