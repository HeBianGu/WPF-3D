using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPiecewiseFunctionShiftScale
	///
	///
	/// </summary>
	// Token: 0x020009DF RID: 2527
	public class vtkPiecewiseFunctionShiftScale : vtkPiecewiseFunctionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A4C8 RID: 107720 RVA: 0x002481FF File Offset: 0x002463FF
		static vtkPiecewiseFunctionShiftScale()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPiecewiseFunctionShiftScale.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewiseFunctionShiftScale"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A4C9 RID: 107721 RVA: 0x00248227 File Offset: 0x00246427
		public vtkPiecewiseFunctionShiftScale(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A4CA RID: 107722
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionShiftScale_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4CB RID: 107723 RVA: 0x00248238 File Offset: 0x00246438
		public new static vtkPiecewiseFunctionShiftScale New()
		{
			vtkPiecewiseFunctionShiftScale result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunctionShiftScale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4CC RID: 107724 RVA: 0x0024828C File Offset: 0x0024648C
		public vtkPiecewiseFunctionShiftScale() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A4CD RID: 107725 RVA: 0x002482D0 File Offset: 0x002464D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A4CE RID: 107726
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewiseFunctionShiftScale_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4CF RID: 107727 RVA: 0x002482DC File Offset: 0x002464DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A4D0 RID: 107728
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewiseFunctionShiftScale_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4D1 RID: 107729 RVA: 0x002482FC File Offset: 0x002464FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A4D2 RID: 107730
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPiecewiseFunctionShiftScale_GetPositionScale_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4D3 RID: 107731 RVA: 0x00248318 File Offset: 0x00246518
		public virtual double GetPositionScale()
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_GetPositionScale_03(base.GetCppThis());
		}

		// Token: 0x0601A4D4 RID: 107732
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPiecewiseFunctionShiftScale_GetPositionShift_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4D5 RID: 107733 RVA: 0x00248338 File Offset: 0x00246538
		public virtual double GetPositionShift()
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_GetPositionShift_04(base.GetCppThis());
		}

		// Token: 0x0601A4D6 RID: 107734
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPiecewiseFunctionShiftScale_GetValueScale_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4D7 RID: 107735 RVA: 0x00248358 File Offset: 0x00246558
		public virtual double GetValueScale()
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_GetValueScale_05(base.GetCppThis());
		}

		// Token: 0x0601A4D8 RID: 107736
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPiecewiseFunctionShiftScale_GetValueShift_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4D9 RID: 107737 RVA: 0x00248378 File Offset: 0x00246578
		public virtual double GetValueShift()
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_GetValueShift_06(base.GetCppThis());
		}

		// Token: 0x0601A4DA RID: 107738
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunctionShiftScale_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4DB RID: 107739 RVA: 0x00248398 File Offset: 0x00246598
		public override int IsA(string type)
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601A4DC RID: 107740
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunctionShiftScale_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4DD RID: 107741 RVA: 0x002483B8 File Offset: 0x002465B8
		public new static int IsTypeOf(string type)
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_IsTypeOf_08(type);
		}

		// Token: 0x0601A4DE RID: 107742
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionShiftScale_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4DF RID: 107743 RVA: 0x002483D4 File Offset: 0x002465D4
		public new vtkPiecewiseFunctionShiftScale NewInstance()
		{
			vtkPiecewiseFunctionShiftScale result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunctionShiftScale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A4E0 RID: 107744
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionShiftScale_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4E1 RID: 107745 RVA: 0x00248430 File Offset: 0x00246630
		public new static vtkPiecewiseFunctionShiftScale SafeDownCast(vtkObjectBase o)
		{
			vtkPiecewiseFunctionShiftScale vtkPiecewiseFunctionShiftScale = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunctionShiftScale = (vtkPiecewiseFunctionShiftScale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunctionShiftScale.Register(null);
				}
			}
			return vtkPiecewiseFunctionShiftScale;
		}

		// Token: 0x0601A4E2 RID: 107746
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunctionShiftScale_SetPositionScale_12(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4E3 RID: 107747 RVA: 0x002484AF File Offset: 0x002466AF
		public virtual void SetPositionScale(double _arg)
		{
			vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_SetPositionScale_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A4E4 RID: 107748
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunctionShiftScale_SetPositionShift_13(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4E5 RID: 107749 RVA: 0x002484BF File Offset: 0x002466BF
		public virtual void SetPositionShift(double _arg)
		{
			vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_SetPositionShift_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A4E6 RID: 107750
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunctionShiftScale_SetValueScale_14(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4E7 RID: 107751 RVA: 0x002484CF File Offset: 0x002466CF
		public virtual void SetValueScale(double _arg)
		{
			vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_SetValueScale_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A4E8 RID: 107752
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunctionShiftScale_SetValueShift_15(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4E9 RID: 107753 RVA: 0x002484DF File Offset: 0x002466DF
		public virtual void SetValueShift(double _arg)
		{
			vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_SetValueShift_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C8E RID: 7310
		public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewiseFunctionShiftScale";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C8F RID: 7311
		public new static readonly string MRClassNameKey = "class vtkPiecewiseFunctionShiftScale";
	}
}
