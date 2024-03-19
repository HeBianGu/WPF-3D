using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotPoints3D
	/// </summary>
	/// <remarks>
	///    3D scatter plot.
	///
	///
	/// 3D scatter plot.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPlotLine3D
	/// vtkPlotPoints
	///
	/// </seealso>
	// Token: 0x02000665 RID: 1637
	public class vtkPlotPoints3D : vtkPlot3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011AAF RID: 72367 RVA: 0x0018B13B File Offset: 0x0018933B
		static vtkPlotPoints3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotPoints3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotPoints3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011AB0 RID: 72368 RVA: 0x0018B163 File Offset: 0x00189363
		public vtkPlotPoints3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011AB1 RID: 72369
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotPoints3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AB2 RID: 72370 RVA: 0x0018B174 File Offset: 0x00189374
		public new static vtkPlotPoints3D New()
		{
			vtkPlotPoints3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotPoints3D.vtkPlotPoints3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotPoints3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AB3 RID: 72371 RVA: 0x0018B1C8 File Offset: 0x001893C8
		public vtkPlotPoints3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotPoints3D.vtkPlotPoints3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011AB4 RID: 72372 RVA: 0x0018B20C File Offset: 0x0018940C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011AB5 RID: 72373
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotPoints3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AB6 RID: 72374 RVA: 0x0018B218 File Offset: 0x00189418
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotPoints3D.vtkPlotPoints3D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06011AB7 RID: 72375
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotPoints3D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AB8 RID: 72376 RVA: 0x0018B238 File Offset: 0x00189438
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotPoints3D.vtkPlotPoints3D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06011AB9 RID: 72377
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotPoints3D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011ABA RID: 72378 RVA: 0x0018B254 File Offset: 0x00189454
		public override int IsA(string type)
		{
			return vtkPlotPoints3D.vtkPlotPoints3D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06011ABB RID: 72379
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotPoints3D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011ABC RID: 72380 RVA: 0x0018B274 File Offset: 0x00189474
		public new static int IsTypeOf(string type)
		{
			return vtkPlotPoints3D.vtkPlotPoints3D_IsTypeOf_04(type);
		}

		// Token: 0x06011ABD RID: 72381
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotPoints3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011ABE RID: 72382 RVA: 0x0018B290 File Offset: 0x00189490
		public new vtkPlotPoints3D NewInstance()
		{
			vtkPlotPoints3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotPoints3D.vtkPlotPoints3D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotPoints3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011ABF RID: 72383
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotPoints3D_Paint_07(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the XY plot, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x06011AC0 RID: 72384 RVA: 0x0018B2EC File Offset: 0x001894EC
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotPoints3D.vtkPlotPoints3D_Paint_07(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011AC1 RID: 72385
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotPoints3D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AC2 RID: 72386 RVA: 0x0018B328 File Offset: 0x00189528
		public new static vtkPlotPoints3D SafeDownCast(vtkObjectBase o)
		{
			vtkPlotPoints3D vtkPlotPoints3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotPoints3D.vtkPlotPoints3D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotPoints3D = (vtkPlotPoints3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotPoints3D.Register(null);
				}
			}
			return vtkPlotPoints3D;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001463 RID: 5219
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotPoints3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001464 RID: 5220
		public new static readonly string MRClassNameKey = "class vtkPlotPoints3D";
	}
}
