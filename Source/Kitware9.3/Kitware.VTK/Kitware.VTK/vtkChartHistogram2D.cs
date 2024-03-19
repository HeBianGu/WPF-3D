using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkChart2DHistogram
	/// </summary>
	/// <remarks>
	///    Chart for 2D histograms.
	///
	///
	/// This defines the interface for a 2D histogram chart.
	/// </remarks>
	// Token: 0x0200063D RID: 1597
	public class vtkChartHistogram2D : vtkChartXY
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011467 RID: 70759 RVA: 0x0018121B File Offset: 0x0017F41B
		static vtkChartHistogram2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChartHistogram2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartHistogram2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011468 RID: 70760 RVA: 0x00181243 File Offset: 0x0017F443
		public vtkChartHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011469 RID: 70761
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D histogram chart
		/// </summary>
		// Token: 0x0601146A RID: 70762 RVA: 0x00181254 File Offset: 0x0017F454
		public new static vtkChartHistogram2D New()
		{
			vtkChartHistogram2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartHistogram2D.vtkChartHistogram2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D histogram chart
		/// </summary>
		// Token: 0x0601146B RID: 70763 RVA: 0x001812A8 File Offset: 0x0017F4A8
		public vtkChartHistogram2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkChartHistogram2D.vtkChartHistogram2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601146C RID: 70764 RVA: 0x001812EC File Offset: 0x0017F4EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601146D RID: 70765
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartHistogram2D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601146E RID: 70766 RVA: 0x001812F8 File Offset: 0x0017F4F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkChartHistogram2D.vtkChartHistogram2D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601146F RID: 70767
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartHistogram2D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011470 RID: 70768 RVA: 0x00181318 File Offset: 0x0017F518
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkChartHistogram2D.vtkChartHistogram2D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06011471 RID: 70769
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartHistogram2D_GetPlot_03(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plot at the specified index, returns null if the index is invalid.
		/// </summary>
		// Token: 0x06011472 RID: 70770 RVA: 0x00181334 File Offset: 0x0017F534
		public override vtkPlot GetPlot(long index)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartHistogram2D.vtkChartHistogram2D_GetPlot_03(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlot = (vtkPlot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlot.Register(null);
				}
			}
			return vtkPlot;
		}

		// Token: 0x06011473 RID: 70771
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartHistogram2D_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011474 RID: 70772 RVA: 0x001813A4 File Offset: 0x0017F5A4
		public override int IsA(string type)
		{
			return vtkChartHistogram2D.vtkChartHistogram2D_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011475 RID: 70773
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartHistogram2D_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011476 RID: 70774 RVA: 0x001813C4 File Offset: 0x0017F5C4
		public new static int IsTypeOf(string type)
		{
			return vtkChartHistogram2D.vtkChartHistogram2D_IsTypeOf_05(type);
		}

		// Token: 0x06011477 RID: 70775
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartHistogram2D_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011478 RID: 70776 RVA: 0x001813E0 File Offset: 0x0017F5E0
		public new vtkChartHistogram2D NewInstance()
		{
			vtkChartHistogram2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartHistogram2D.vtkChartHistogram2D_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011479 RID: 70777
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartHistogram2D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601147A RID: 70778 RVA: 0x0018143C File Offset: 0x0017F63C
		public new static vtkChartHistogram2D SafeDownCast(vtkObjectBase o)
		{
			vtkChartHistogram2D vtkChartHistogram2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartHistogram2D.vtkChartHistogram2D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartHistogram2D = (vtkChartHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartHistogram2D.Register(null);
				}
			}
			return vtkChartHistogram2D;
		}

		// Token: 0x0601147B RID: 70779
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartHistogram2D_SetInputData_09(HandleRef pThis, HandleRef data, long z);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x0601147C RID: 70780 RVA: 0x001814BC File Offset: 0x0017F6BC
		public virtual void SetInputData(vtkImageData data, long z)
		{
			vtkChartHistogram2D.vtkChartHistogram2D_SetInputData_09(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), z);
		}

		// Token: 0x0601147D RID: 70781
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartHistogram2D_SetTransferFunction_10(HandleRef pThis, HandleRef function);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x0601147E RID: 70782 RVA: 0x001814EC File Offset: 0x0017F6EC
		public virtual void SetTransferFunction(vtkScalarsToColors function)
		{
			vtkChartHistogram2D.vtkChartHistogram2D_SetTransferFunction_10(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x0601147F RID: 70783
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartHistogram2D_Update_11(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x06011480 RID: 70784 RVA: 0x0018151B File Offset: 0x0017F71B
		public override void Update()
		{
			vtkChartHistogram2D.vtkChartHistogram2D_Update_11(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001402 RID: 5122
		public new const string MRFullTypeName = "Kitware.VTK.vtkChartHistogram2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001403 RID: 5123
		public new static readonly string MRClassNameKey = "class vtkChartHistogram2D";
	}
}
