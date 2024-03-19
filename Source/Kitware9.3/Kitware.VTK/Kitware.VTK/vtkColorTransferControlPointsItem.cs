using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkColorTransferControlPointsItem
	/// </summary>
	/// <remarks>
	///    Control points for
	/// vtkColorTransferFunction.
	///
	/// vtkColorTransferControlPointsItem draws the control points of a vtkColorTransferFunction.
	/// </remarks>
	/// <seealso>
	///
	/// vtkControlPointsItem
	/// vtkColorTransferFunctionItem
	/// vtkCompositeTransferFunctionItem
	/// </seealso>
	// Token: 0x02000648 RID: 1608
	public class vtkColorTransferControlPointsItem : vtkControlPointsItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060116F5 RID: 71413 RVA: 0x00184FB7 File Offset: 0x001831B7
		static vtkColorTransferControlPointsItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColorTransferControlPointsItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorTransferControlPointsItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060116F6 RID: 71414 RVA: 0x00184FDF File Offset: 0x001831DF
		public vtkColorTransferControlPointsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060116F7 RID: 71415
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferControlPointsItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a piecewise control points object
		/// </summary>
		// Token: 0x060116F8 RID: 71416 RVA: 0x00184FF0 File Offset: 0x001831F0
		public new static vtkColorTransferControlPointsItem New()
		{
			vtkColorTransferControlPointsItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorTransferControlPointsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a piecewise control points object
		/// </summary>
		// Token: 0x060116F9 RID: 71417 RVA: 0x00185044 File Offset: 0x00183244
		public vtkColorTransferControlPointsItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060116FA RID: 71418 RVA: 0x00185088 File Offset: 0x00183288
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060116FB RID: 71419
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorTransferControlPointsItem_AddPoint_01(HandleRef pThis, IntPtr newPos);

		/// <summary>
		/// Add a point to the function. Returns the index of the point (0 based),
		/// or -1 on error.
		/// Subclasses should reimplement this function to do the actual work.
		/// </summary>
		// Token: 0x060116FC RID: 71420 RVA: 0x00185094 File Offset: 0x00183294
		public override long AddPoint(IntPtr newPos)
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_AddPoint_01(base.GetCppThis(), newPos);
		}

		// Token: 0x060116FD RID: 71421
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkColorTransferControlPointsItem_GetColorFill_02(HandleRef pThis);

		/// <summary>
		/// If ColorFill is true, the control point brush color is set with the
		/// matching color in the color transfer function.
		/// False by default.
		/// </summary>
		// Token: 0x060116FE RID: 71422 RVA: 0x001850B4 File Offset: 0x001832B4
		public virtual bool GetColorFill()
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_GetColorFill_02(base.GetCppThis()) != 0;
		}

		// Token: 0x060116FF RID: 71423
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferControlPointsItem_GetColorTransferFunction_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the piecewise function
		/// </summary>
		// Token: 0x06011700 RID: 71424 RVA: 0x001850DC File Offset: 0x001832DC
		public virtual vtkColorTransferFunction GetColorTransferFunction()
		{
			vtkColorTransferFunction vtkColorTransferFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_GetColorTransferFunction_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferFunction = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferFunction.Register(null);
				}
			}
			return vtkColorTransferFunction;
		}

		// Token: 0x06011701 RID: 71425
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferControlPointsItem_GetControlPoint_04(HandleRef pThis, long index, IntPtr point);

		/// <summary>
		/// Returns the x and y coordinates as well as the midpoint and sharpness
		/// of the control point corresponding to the index.
		/// Note: The y (point[1]) is always 0.5
		/// </summary>
		// Token: 0x06011702 RID: 71426 RVA: 0x0018514B File Offset: 0x0018334B
		public override void GetControlPoint(long index, IntPtr point)
		{
			vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_GetControlPoint_04(base.GetCppThis(), index, point);
		}

		// Token: 0x06011703 RID: 71427
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorTransferControlPointsItem_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011704 RID: 71428 RVA: 0x0018515C File Offset: 0x0018335C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06011705 RID: 71429
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorTransferControlPointsItem_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011706 RID: 71430 RVA: 0x0018517C File Offset: 0x0018337C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06011707 RID: 71431
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorTransferControlPointsItem_GetNumberOfPoints_07(HandleRef pThis);

		/// <summary>
		/// Return the number of points in the color transfer function.
		/// </summary>
		// Token: 0x06011708 RID: 71432 RVA: 0x00185198 File Offset: 0x00183398
		public override long GetNumberOfPoints()
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_GetNumberOfPoints_07(base.GetCppThis());
		}

		// Token: 0x06011709 RID: 71433
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferControlPointsItem_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601170A RID: 71434 RVA: 0x001851B8 File Offset: 0x001833B8
		public override int IsA(string type)
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601170B RID: 71435
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferControlPointsItem_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601170C RID: 71436 RVA: 0x001851D8 File Offset: 0x001833D8
		public new static int IsTypeOf(string type)
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_IsTypeOf_09(type);
		}

		// Token: 0x0601170D RID: 71437
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferControlPointsItem_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601170E RID: 71438 RVA: 0x001851F4 File Offset: 0x001833F4
		public new vtkColorTransferControlPointsItem NewInstance()
		{
			vtkColorTransferControlPointsItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorTransferControlPointsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601170F RID: 71439
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorTransferControlPointsItem_RemovePoint_12(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Remove a point of the function. Returns the index of the point (0 based),
		/// or -1 on error.
		/// Subclasses should reimplement this function to do the actual work.
		/// </summary>
		// Token: 0x06011710 RID: 71440 RVA: 0x00185250 File Offset: 0x00183450
		public override long RemovePoint(IntPtr pos)
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_RemovePoint_12(base.GetCppThis(), pos);
		}

		// Token: 0x06011711 RID: 71441
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferControlPointsItem_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011712 RID: 71442 RVA: 0x00185270 File Offset: 0x00183470
		public new static vtkColorTransferControlPointsItem SafeDownCast(vtkObjectBase o)
		{
			vtkColorTransferControlPointsItem vtkColorTransferControlPointsItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferControlPointsItem = (vtkColorTransferControlPointsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferControlPointsItem.Register(null);
				}
			}
			return vtkColorTransferControlPointsItem;
		}

		// Token: 0x06011713 RID: 71443
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferControlPointsItem_SetColorFill_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// If ColorFill is true, the control point brush color is set with the
		/// matching color in the color transfer function.
		/// False by default.
		/// </summary>
		// Token: 0x06011714 RID: 71444 RVA: 0x001852EF File Offset: 0x001834EF
		public virtual void SetColorFill(bool _arg)
		{
			vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_SetColorFill_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011715 RID: 71445
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferControlPointsItem_SetColorTransferFunction_15(HandleRef pThis, HandleRef function);

		/// <summary>
		/// Set the piecewise function to draw its points
		/// </summary>
		// Token: 0x06011716 RID: 71446 RVA: 0x00185308 File Offset: 0x00183508
		public void SetColorTransferFunction(vtkColorTransferFunction function)
		{
			vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_SetColorTransferFunction_15(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06011717 RID: 71447
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferControlPointsItem_SetControlPoint_16(HandleRef pThis, long index, IntPtr point);

		/// <summary>
		/// Sets the x and y coordinates as well as the midpoint and sharpness
		/// of the control point corresponding to the index.
		/// Changing the y has no effect, it will always be 0.5
		/// </summary>
		// Token: 0x06011718 RID: 71448 RVA: 0x00185337 File Offset: 0x00183537
		public override void SetControlPoint(long index, IntPtr point)
		{
			vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_SetControlPoint_16(base.GetCppThis(), index, point);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400141B RID: 5147
		public new const string MRFullTypeName = "Kitware.VTK.vtkColorTransferControlPointsItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400141C RID: 5148
		public new static readonly string MRClassNameKey = "class vtkColorTransferControlPointsItem";
	}
}
