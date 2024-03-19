using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotLine
	/// </summary>
	/// <remarks>
	///    Class for drawing an XY line plot given two columns from
	/// a vtkTable.
	///
	///
	///
	/// </remarks>
	// Token: 0x02000664 RID: 1636
	public class vtkPlotLine : vtkPlotPoints
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011A91 RID: 72337 RVA: 0x0018AE22 File Offset: 0x00189022
		static vtkPlotLine()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotLine.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotLine"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011A92 RID: 72338 RVA: 0x0018AE4A File Offset: 0x0018904A
		public vtkPlotLine(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011A93 RID: 72339
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotLine_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x06011A94 RID: 72340 RVA: 0x0018AE58 File Offset: 0x00189058
		public new static vtkPlotLine New()
		{
			vtkPlotLine result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotLine.vtkPlotLine_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x06011A95 RID: 72341 RVA: 0x0018AEAC File Offset: 0x001890AC
		public vtkPlotLine() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotLine.vtkPlotLine_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011A96 RID: 72342 RVA: 0x0018AEF0 File Offset: 0x001890F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011A97 RID: 72343
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotLine_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A98 RID: 72344 RVA: 0x0018AEFC File Offset: 0x001890FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotLine.vtkPlotLine_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06011A99 RID: 72345
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotLine_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A9A RID: 72346 RVA: 0x0018AF1C File Offset: 0x0018911C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotLine.vtkPlotLine_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06011A9B RID: 72347
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotLine_GetPolyLine_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether the points define a poly line
		/// (true) or multiple line segments (false).
		/// If true (default), a segment is drawn between each points
		/// (e.g. [P1P2, P2P3, P3P4...].) If false, a segment is drawn for each pair
		/// of points (e.g. [P1P2, P3P4,...].)
		/// </summary>
		// Token: 0x06011A9C RID: 72348 RVA: 0x0018AF38 File Offset: 0x00189138
		public virtual bool GetPolyLine()
		{
			return vtkPlotLine.vtkPlotLine_GetPolyLine_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06011A9D RID: 72349
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotLine_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A9E RID: 72350 RVA: 0x0018AF60 File Offset: 0x00189160
		public override int IsA(string type)
		{
			return vtkPlotLine.vtkPlotLine_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011A9F RID: 72351
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotLine_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AA0 RID: 72352 RVA: 0x0018AF80 File Offset: 0x00189180
		public new static int IsTypeOf(string type)
		{
			return vtkPlotLine.vtkPlotLine_IsTypeOf_05(type);
		}

		// Token: 0x06011AA1 RID: 72353
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotLine_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AA2 RID: 72354 RVA: 0x0018AF9C File Offset: 0x0018919C
		public new vtkPlotLine NewInstance()
		{
			vtkPlotLine result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotLine.vtkPlotLine_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011AA3 RID: 72355
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotLine_Paint_08(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the XY plot, called whenever the chart needs to be drawn.
		/// </summary>
		// Token: 0x06011AA4 RID: 72356 RVA: 0x0018AFF8 File Offset: 0x001891F8
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotLine.vtkPlotLine_Paint_08(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011AA5 RID: 72357
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotLine_PaintLegend_09(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

		/// <summary>
		/// Paint legend event for the XY plot, called whenever the legend needs the
		/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
		/// corner of the rect (elements 0 and 1) and with width x height (elements 2
		/// and 3). The plot can choose how to fill the space supplied.
		/// </summary>
		// Token: 0x06011AA6 RID: 72358 RVA: 0x0018B034 File Offset: 0x00189234
		public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
		{
			return vtkPlotLine.vtkPlotLine_PaintLegend_09(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), legendIndex) != 0;
		}

		// Token: 0x06011AA7 RID: 72359
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotLine_PolyLineOff_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether the points define a poly line
		/// (true) or multiple line segments (false).
		/// If true (default), a segment is drawn between each points
		/// (e.g. [P1P2, P2P3, P3P4...].) If false, a segment is drawn for each pair
		/// of points (e.g. [P1P2, P3P4,...].)
		/// </summary>
		// Token: 0x06011AA8 RID: 72360 RVA: 0x0018B085 File Offset: 0x00189285
		public virtual void PolyLineOff()
		{
			vtkPlotLine.vtkPlotLine_PolyLineOff_10(base.GetCppThis());
		}

		// Token: 0x06011AA9 RID: 72361
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotLine_PolyLineOn_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether the points define a poly line
		/// (true) or multiple line segments (false).
		/// If true (default), a segment is drawn between each points
		/// (e.g. [P1P2, P2P3, P3P4...].) If false, a segment is drawn for each pair
		/// of points (e.g. [P1P2, P3P4,...].)
		/// </summary>
		// Token: 0x06011AAA RID: 72362 RVA: 0x0018B094 File Offset: 0x00189294
		public virtual void PolyLineOn()
		{
			vtkPlotLine.vtkPlotLine_PolyLineOn_11(base.GetCppThis());
		}

		// Token: 0x06011AAB RID: 72363
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotLine_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AAC RID: 72364 RVA: 0x0018B0A4 File Offset: 0x001892A4
		public new static vtkPlotLine SafeDownCast(vtkObjectBase o)
		{
			vtkPlotLine vtkPlotLine = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotLine.vtkPlotLine_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotLine = (vtkPlotLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotLine.Register(null);
				}
			}
			return vtkPlotLine;
		}

		// Token: 0x06011AAD RID: 72365
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotLine_SetPolyLine_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off flag to control whether the points define a poly line
		/// (true) or multiple line segments (false).
		/// If true (default), a segment is drawn between each points
		/// (e.g. [P1P2, P2P3, P3P4...].) If false, a segment is drawn for each pair
		/// of points (e.g. [P1P2, P3P4,...].)
		/// </summary>
		// Token: 0x06011AAE RID: 72366 RVA: 0x0018B123 File Offset: 0x00189323
		public virtual void SetPolyLine(bool _arg)
		{
			vtkPlotLine.vtkPlotLine_SetPolyLine_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001461 RID: 5217
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotLine";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001462 RID: 5218
		public new static readonly string MRClassNameKey = "class vtkPlotLine";
	}
}
