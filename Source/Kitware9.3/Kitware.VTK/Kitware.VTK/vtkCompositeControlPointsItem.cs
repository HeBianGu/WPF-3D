using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeControlPointsItem
	/// </summary>
	/// <remarks>
	///    Control points for
	/// vtkCompositeFunction.
	///
	/// vtkCompositeControlPointsItem draws the control points of a vtkPiecewiseFunction
	/// and a vtkColorTransferFunction.
	/// </remarks>
	/// <seealso>
	///
	/// vtkControlPointsItem
	/// vtkColorTransferControlPointsItem
	/// vtkCompositeTransferFunctionItem
	/// vtkPiecewisePointHandleItem
	/// </seealso>
	// Token: 0x0200064B RID: 1611
	public class vtkCompositeControlPointsItem : vtkColorTransferControlPointsItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601175A RID: 71514 RVA: 0x00185A73 File Offset: 0x00183C73
		static vtkCompositeControlPointsItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeControlPointsItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeControlPointsItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601175B RID: 71515 RVA: 0x00185A9B File Offset: 0x00183C9B
		public vtkCompositeControlPointsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601175C RID: 71516
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeControlPointsItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a piecewise control points object
		/// </summary>
		// Token: 0x0601175D RID: 71517 RVA: 0x00185AAC File Offset: 0x00183CAC
		public new static vtkCompositeControlPointsItem New()
		{
			vtkCompositeControlPointsItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeControlPointsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a piecewise control points object
		/// </summary>
		// Token: 0x0601175E RID: 71518 RVA: 0x00185B00 File Offset: 0x00183D00
		public vtkCompositeControlPointsItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601175F RID: 71519 RVA: 0x00185B44 File Offset: 0x00183D44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011760 RID: 71520
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeControlPointsItem_AddPoint_01(HandleRef pThis, IntPtr newPos);

		/// <summary>
		/// Add a point to the function. Returns the index of the point (0 based),
		/// or -1 on error.
		/// Subclasses should reimplement this function to do the actual work.
		/// </summary>
		// Token: 0x06011761 RID: 71521 RVA: 0x00185B50 File Offset: 0x00183D50
		public override long AddPoint(IntPtr newPos)
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_AddPoint_01(base.GetCppThis(), newPos);
		}

		// Token: 0x06011762 RID: 71522
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeControlPointsItem_GetControlPoint_02(HandleRef pThis, long index, IntPtr point);

		/// <summary>
		/// Returns the x and y coordinates as well as the midpoint and sharpness
		/// of the control point corresponding to the index.
		/// point must be a double array of size 4.
		/// The values will be recovered from the opacity function when available.
		/// </summary>
		// Token: 0x06011763 RID: 71523 RVA: 0x00185B70 File Offset: 0x00183D70
		public override void GetControlPoint(long index, IntPtr point)
		{
			vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_GetControlPoint_02(base.GetCppThis(), index, point);
		}

		// Token: 0x06011764 RID: 71524
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeControlPointsItem_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011765 RID: 71525 RVA: 0x00185B84 File Offset: 0x00183D84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06011766 RID: 71526
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeControlPointsItem_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011767 RID: 71527 RVA: 0x00185BA4 File Offset: 0x00183DA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06011768 RID: 71528
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeControlPointsItem_GetNumberOfPoints_05(HandleRef pThis);

		/// <summary>
		/// Returns the total number of points, either from
		/// using the superclass implementation or the opacity function
		/// when available
		/// </summary>
		// Token: 0x06011769 RID: 71529 RVA: 0x00185BC0 File Offset: 0x00183DC0
		public override long GetNumberOfPoints()
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_GetNumberOfPoints_05(base.GetCppThis());
		}

		// Token: 0x0601176A RID: 71530
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeControlPointsItem_GetOpacityFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Utility function that calls SetPiecewiseFunction()
		/// </summary>
		// Token: 0x0601176B RID: 71531 RVA: 0x00185BE0 File Offset: 0x00183DE0
		public virtual vtkPiecewiseFunction GetOpacityFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_GetOpacityFunction_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601176C RID: 71532
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeControlPointsItem_GetPointsFunction_07(HandleRef pThis);

		/// <summary>
		/// PointsFunction controls whether the points represent the
		/// ColorTransferFunction, OpacityTransferFunction or both.
		/// If ColorPointsFunction, only the points of the ColorTransfer function are
		/// used.
		/// If OpacityPointsFunction, only the points of the Opacity function are used
		/// If ColorAndOpacityPointsFunction, the points of both functions are shared
		/// by both functions.
		/// ColorAndOpacityPointsFunction by default.
		/// Note: Set the mode before the functions are set. ColorPointsFunction is
		/// not fully supported.
		/// </summary>
		// Token: 0x0601176D RID: 71533 RVA: 0x00185C50 File Offset: 0x00183E50
		public virtual int GetPointsFunction()
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_GetPointsFunction_07(base.GetCppThis());
		}

		// Token: 0x0601176E RID: 71534
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeControlPointsItem_GetUseOpacityPointHandles_08(HandleRef pThis);

		/// <summary>
		/// If UseOpacityPointHandles is true, when the current point is
		/// double clicked, a vtkPiecewisePointHandleItem will show up so
		/// that the sharpness and mid point can be adjusted in the scene
		/// with those handles
		/// False by default.
		/// </summary>
		// Token: 0x0601176F RID: 71535 RVA: 0x00185C70 File Offset: 0x00183E70
		public virtual bool GetUseOpacityPointHandles()
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_GetUseOpacityPointHandles_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06011770 RID: 71536
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeControlPointsItem_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011771 RID: 71537 RVA: 0x00185C98 File Offset: 0x00183E98
		public override int IsA(string type)
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06011772 RID: 71538
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeControlPointsItem_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011773 RID: 71539 RVA: 0x00185CB8 File Offset: 0x00183EB8
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_IsTypeOf_10(type);
		}

		// Token: 0x06011774 RID: 71540
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeControlPointsItem_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011775 RID: 71541 RVA: 0x00185CD4 File Offset: 0x00183ED4
		public new vtkCompositeControlPointsItem NewInstance()
		{
			vtkCompositeControlPointsItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeControlPointsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011776 RID: 71542
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeControlPointsItem_RemovePoint_13(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Remove a point of the function. Returns the index of the point (0 based),
		/// or -1 on error.
		/// Subclasses should reimplement this function to do the actual work.
		/// </summary>
		// Token: 0x06011777 RID: 71543 RVA: 0x00185D30 File Offset: 0x00183F30
		public override long RemovePoint(IntPtr pos)
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_RemovePoint_13(base.GetCppThis(), pos);
		}

		// Token: 0x06011778 RID: 71544
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeControlPointsItem_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011779 RID: 71545 RVA: 0x00185D50 File Offset: 0x00183F50
		public new static vtkCompositeControlPointsItem SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeControlPointsItem vtkCompositeControlPointsItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeControlPointsItem = (vtkCompositeControlPointsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeControlPointsItem.Register(null);
				}
			}
			return vtkCompositeControlPointsItem;
		}

		// Token: 0x0601177A RID: 71546
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeControlPointsItem_SetColorTransferFunction_15(HandleRef pThis, HandleRef function);

		/// <summary>
		/// Set the color transfer function to draw its points
		/// </summary>
		// Token: 0x0601177B RID: 71547 RVA: 0x00185DD0 File Offset: 0x00183FD0
		public new virtual void SetColorTransferFunction(vtkColorTransferFunction function)
		{
			vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_SetColorTransferFunction_15(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x0601177C RID: 71548
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeControlPointsItem_SetControlPoint_16(HandleRef pThis, long index, IntPtr point);

		/// <summary>
		/// Sets the x and y coordinates as well as the midpoint and sharpness,
		/// of the control point corresponding to the index, either using the superclass
		/// implementation or the opacity function when available.
		/// The provided point should be a double array of size 4.
		/// </summary>
		// Token: 0x0601177D RID: 71549 RVA: 0x00185DFF File Offset: 0x00183FFF
		public override void SetControlPoint(long index, IntPtr point)
		{
			vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_SetControlPoint_16(base.GetCppThis(), index, point);
		}

		// Token: 0x0601177E RID: 71550
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeControlPointsItem_SetOpacityFunction_17(HandleRef pThis, HandleRef opacity);

		/// <summary>
		/// Utility function that calls SetPiecewiseFunction()
		/// </summary>
		// Token: 0x0601177F RID: 71551 RVA: 0x00185E10 File Offset: 0x00184010
		public void SetOpacityFunction(vtkPiecewiseFunction opacity)
		{
			vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_SetOpacityFunction_17(base.GetCppThis(), (opacity == null) ? default(HandleRef) : opacity.GetCppThis());
		}

		// Token: 0x06011780 RID: 71552
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeControlPointsItem_SetPointsFunction_18(HandleRef pThis, int _arg);

		/// <summary>
		/// PointsFunction controls whether the points represent the
		/// ColorTransferFunction, OpacityTransferFunction or both.
		/// If ColorPointsFunction, only the points of the ColorTransfer function are
		/// used.
		/// If OpacityPointsFunction, only the points of the Opacity function are used
		/// If ColorAndOpacityPointsFunction, the points of both functions are shared
		/// by both functions.
		/// ColorAndOpacityPointsFunction by default.
		/// Note: Set the mode before the functions are set. ColorPointsFunction is
		/// not fully supported.
		/// </summary>
		// Token: 0x06011781 RID: 71553 RVA: 0x00185E3F File Offset: 0x0018403F
		public virtual void SetPointsFunction(int _arg)
		{
			vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_SetPointsFunction_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06011782 RID: 71554
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeControlPointsItem_SetUseOpacityPointHandles_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// If UseOpacityPointHandles is true, when the current point is
		/// double clicked, a vtkPiecewisePointHandleItem will show up so
		/// that the sharpness and mid point can be adjusted in the scene
		/// with those handles
		/// False by default.
		/// </summary>
		// Token: 0x06011783 RID: 71555 RVA: 0x00185E4F File Offset: 0x0018404F
		public virtual void SetUseOpacityPointHandles(bool _arg)
		{
			vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_SetUseOpacityPointHandles_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001421 RID: 5153
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeControlPointsItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001422 RID: 5154
		public new static readonly string MRClassNameKey = "class vtkCompositeControlPointsItem";

		/// <summary>
		/// Utility function that calls SetPiecewiseFunction()
		/// </summary>
		// Token: 0x0200064C RID: 1612
		public enum PointsFunctionType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001424 RID: 5156
			ColorAndOpacityPointsFunction = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001425 RID: 5157
			ColorPointsFunction = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001426 RID: 5158
			OpacityPointsFunction
		}
	}
}
