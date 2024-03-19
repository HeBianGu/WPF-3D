using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPiecewiseControlPointsItem
	/// </summary>
	/// <remarks>
	///    Control points for
	/// vtkPiecewiseFunction.
	///
	/// vtkPiecewiseControlPointsItem draws the control points of a vtkPiecewiseFunction.
	/// </remarks>
	/// <seealso>
	///
	/// vtkControlPointsItem
	/// vtkPiecewiseFunctionItem
	/// vtkCompositeTransferFunctionItem
	/// </seealso>
	// Token: 0x02000652 RID: 1618
	public class vtkPiecewiseControlPointsItem : vtkControlPointsItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601180A RID: 71690 RVA: 0x00186CE7 File Offset: 0x00184EE7
		static vtkPiecewiseControlPointsItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPiecewiseControlPointsItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewiseControlPointsItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601180B RID: 71691 RVA: 0x00186D0F File Offset: 0x00184F0F
		public vtkPiecewiseControlPointsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601180C RID: 71692
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseControlPointsItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a piecewise control points object
		/// </summary>
		// Token: 0x0601180D RID: 71693 RVA: 0x00186D20 File Offset: 0x00184F20
		public new static vtkPiecewiseControlPointsItem New()
		{
			vtkPiecewiseControlPointsItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseControlPointsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a piecewise control points object
		/// </summary>
		// Token: 0x0601180E RID: 71694 RVA: 0x00186D74 File Offset: 0x00184F74
		public vtkPiecewiseControlPointsItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601180F RID: 71695 RVA: 0x00186DB8 File Offset: 0x00184FB8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011810 RID: 71696
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewiseControlPointsItem_AddPoint_01(HandleRef pThis, IntPtr newPos);

		/// <summary>
		/// Add a point to the function. Returns the index of the point (0 based),
		/// or -1 on error.
		/// Subclasses should reimplement this function to do the actual work.
		/// </summary>
		// Token: 0x06011811 RID: 71697 RVA: 0x00186DC4 File Offset: 0x00184FC4
		public override long AddPoint(IntPtr newPos)
		{
			return vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_AddPoint_01(base.GetCppThis(), newPos);
		}

		// Token: 0x06011812 RID: 71698
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewiseControlPointsItem_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011813 RID: 71699 RVA: 0x00186DE4 File Offset: 0x00184FE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06011814 RID: 71700
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewiseControlPointsItem_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011815 RID: 71701 RVA: 0x00186E04 File Offset: 0x00185004
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06011816 RID: 71702
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseControlPointsItem_GetPiecewiseFunction_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the piecewise function
		/// </summary>
		// Token: 0x06011817 RID: 71703 RVA: 0x00186E20 File Offset: 0x00185020
		public virtual vtkPiecewiseFunction GetPiecewiseFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_GetPiecewiseFunction_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x06011818 RID: 71704
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseControlPointsItem_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011819 RID: 71705 RVA: 0x00186E90 File Offset: 0x00185090
		public override int IsA(string type)
		{
			return vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601181A RID: 71706
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseControlPointsItem_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601181B RID: 71707 RVA: 0x00186EB0 File Offset: 0x001850B0
		public new static int IsTypeOf(string type)
		{
			return vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_IsTypeOf_06(type);
		}

		// Token: 0x0601181C RID: 71708
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseControlPointsItem_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601181D RID: 71709 RVA: 0x00186ECC File Offset: 0x001850CC
		public new vtkPiecewiseControlPointsItem NewInstance()
		{
			vtkPiecewiseControlPointsItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseControlPointsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601181E RID: 71710
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewiseControlPointsItem_RemovePoint_09(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Remove a point of the function. Returns the index of the point (0 based),
		/// or -1 on error.
		/// Subclasses should reimplement this function to do the actual work.
		/// </summary>
		// Token: 0x0601181F RID: 71711 RVA: 0x00186F28 File Offset: 0x00185128
		public override long RemovePoint(IntPtr pos)
		{
			return vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_RemovePoint_09(base.GetCppThis(), pos);
		}

		// Token: 0x06011820 RID: 71712
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseControlPointsItem_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011821 RID: 71713 RVA: 0x00186F48 File Offset: 0x00185148
		public new static vtkPiecewiseControlPointsItem SafeDownCast(vtkObjectBase o)
		{
			vtkPiecewiseControlPointsItem vtkPiecewiseControlPointsItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseControlPointsItem = (vtkPiecewiseControlPointsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseControlPointsItem.Register(null);
				}
			}
			return vtkPiecewiseControlPointsItem;
		}

		// Token: 0x06011822 RID: 71714
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseControlPointsItem_SetPiecewiseFunction_11(HandleRef pThis, HandleRef function);

		/// <summary>
		/// Set the piecewise function to draw its points
		/// </summary>
		// Token: 0x06011823 RID: 71715 RVA: 0x00186FC8 File Offset: 0x001851C8
		public virtual void SetPiecewiseFunction(vtkPiecewiseFunction function)
		{
			vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_SetPiecewiseFunction_11(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001434 RID: 5172
		public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewiseControlPointsItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001435 RID: 5173
		public new static readonly string MRClassNameKey = "class vtkPiecewiseControlPointsItem";
	}
}
