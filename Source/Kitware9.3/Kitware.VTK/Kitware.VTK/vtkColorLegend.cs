using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkColorLegend
	/// </summary>
	/// <remarks>
	///    Legend item to display vtkScalarsToColors.
	///
	/// vtkColorLegend is an item that will display the vtkScalarsToColors
	/// using a 1D texture, and a vtkAxis to show both the color and numerical range.
	/// </remarks>
	// Token: 0x02000643 RID: 1603
	public class vtkColorLegend : vtkChartLegend
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011591 RID: 71057 RVA: 0x00183106 File Offset: 0x00181306
		static vtkColorLegend()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColorLegend.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorLegend"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011592 RID: 71058 RVA: 0x0018312E File Offset: 0x0018132E
		public vtkColorLegend(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011593 RID: 71059
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorLegend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011594 RID: 71060 RVA: 0x0018313C File Offset: 0x0018133C
		public new static vtkColorLegend New()
		{
			vtkColorLegend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorLegend.vtkColorLegend_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorLegend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011595 RID: 71061 RVA: 0x00183190 File Offset: 0x00181390
		public vtkColorLegend() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkColorLegend.vtkColorLegend_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011596 RID: 71062 RVA: 0x001831D4 File Offset: 0x001813D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011597 RID: 71063
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorLegend_DrawBorderOff_01(HandleRef pThis);

		/// <summary>
		/// Toggle whether or not a border should be drawn around this legend.
		/// The default behavior is to not draw a border.
		/// </summary>
		// Token: 0x06011598 RID: 71064 RVA: 0x001831DF File Offset: 0x001813DF
		public virtual void DrawBorderOff()
		{
			vtkColorLegend.vtkColorLegend_DrawBorderOff_01(base.GetCppThis());
		}

		// Token: 0x06011599 RID: 71065
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorLegend_DrawBorderOn_02(HandleRef pThis);

		/// <summary>
		/// Toggle whether or not a border should be drawn around this legend.
		/// The default behavior is to not draw a border.
		/// </summary>
		// Token: 0x0601159A RID: 71066 RVA: 0x001831EE File Offset: 0x001813EE
		public virtual void DrawBorderOn()
		{
			vtkColorLegend.vtkColorLegend_DrawBorderOn_02(base.GetCppThis());
		}

		// Token: 0x0601159B RID: 71067
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorLegend_GetBoundingRect_03(HandleRef pThis, HandleRef painter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Request the space the legend requires to be drawn. This is returned as a
		/// vtkRect4f, with the corner being the offset from Point, and the width/
		/// height being the total width/height required by the axis. In order to
		/// ensure the numbers are correct, Update() should be called first.
		/// </summary>
		// Token: 0x0601159C RID: 71068 RVA: 0x00183200 File Offset: 0x00181400
		public override vtkRectf GetBoundingRect(vtkContext2D painter)
		{
			vtkRectf result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorLegend.vtkColorLegend_GetBoundingRect_03(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601159D RID: 71069
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorLegend_GetBounds_04(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Bounds of the item, by default (0, 1, 0, 1) but it mainly depends on the
		/// range of the vtkScalarsToColors function.
		/// </summary>
		// Token: 0x0601159E RID: 71070 RVA: 0x00183270 File Offset: 0x00181470
		public virtual void GetBounds(IntPtr bounds)
		{
			vtkColorLegend.vtkColorLegend_GetBounds_04(base.GetCppThis(), bounds);
		}

		// Token: 0x0601159F RID: 71071
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkColorLegend_GetDrawBorder_05(HandleRef pThis);

		/// <summary>
		/// Toggle whether or not a border should be drawn around this legend.
		/// The default behavior is to not draw a border.
		/// </summary>
		// Token: 0x060115A0 RID: 71072 RVA: 0x00183280 File Offset: 0x00181480
		public virtual bool GetDrawBorder()
		{
			return vtkColorLegend.vtkColorLegend_GetDrawBorder_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060115A1 RID: 71073
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorLegend_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060115A2 RID: 71074 RVA: 0x001832A8 File Offset: 0x001814A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkColorLegend.vtkColorLegend_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060115A3 RID: 71075
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorLegend_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060115A4 RID: 71076 RVA: 0x001832C8 File Offset: 0x001814C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkColorLegend.vtkColorLegend_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060115A5 RID: 71077
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorLegend_GetOrientation_08(HandleRef pThis);

		/// <summary>
		/// Set/get the orientation of the legend.
		/// Valid orientations are VERTICAL (default) and HORIZONTAL.
		/// </summary>
		// Token: 0x060115A6 RID: 71078 RVA: 0x001832E4 File Offset: 0x001814E4
		public virtual int GetOrientation()
		{
			return vtkColorLegend.vtkColorLegend_GetOrientation_08(base.GetCppThis());
		}

		// Token: 0x060115A7 RID: 71079
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorLegend_GetPosition_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the origin, width, and height of the scalar bar drawn by this
		/// legend.
		/// </summary>
		// Token: 0x060115A8 RID: 71080 RVA: 0x00183304 File Offset: 0x00181504
		public virtual vtkRectf GetPosition()
		{
			vtkRectf result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorLegend.vtkColorLegend_GetPosition_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060115A9 RID: 71081
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkColorLegend_GetTitle_10(HandleRef pThis);

		/// <summary>
		/// Get/set the title text of the legend.
		/// </summary>
		// Token: 0x060115AA RID: 71082 RVA: 0x00183360 File Offset: 0x00181560
		public virtual string GetTitle()
		{
			return vtkColorLegend.vtkColorLegend_GetTitle_10(base.GetCppThis());
		}

		// Token: 0x060115AB RID: 71083
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorLegend_GetTransferFunction_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the transfer function that is used to draw the scalar bar
		/// within this legend.
		/// </summary>
		// Token: 0x060115AC RID: 71084 RVA: 0x00183380 File Offset: 0x00181580
		public virtual vtkScalarsToColors GetTransferFunction()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorLegend.vtkColorLegend_GetTransferFunction_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x060115AD RID: 71085
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorLegend_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060115AE RID: 71086 RVA: 0x001833F0 File Offset: 0x001815F0
		public override int IsA(string type)
		{
			return vtkColorLegend.vtkColorLegend_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x060115AF RID: 71087
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorLegend_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060115B0 RID: 71088 RVA: 0x00183410 File Offset: 0x00181610
		public new static int IsTypeOf(string type)
		{
			return vtkColorLegend.vtkColorLegend_IsTypeOf_13(type);
		}

		// Token: 0x060115B1 RID: 71089
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorLegend_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060115B2 RID: 71090 RVA: 0x0018342C File Offset: 0x0018162C
		public new vtkColorLegend NewInstance()
		{
			vtkColorLegend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorLegend.vtkColorLegend_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorLegend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060115B3 RID: 71091
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkColorLegend_Paint_16(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint the texture into a rectangle defined by the bounds. If
		/// MaskAboveCurve is true and a shape has been provided by a subclass, it
		/// draws the texture into the shape
		/// </summary>
		// Token: 0x060115B4 RID: 71092 RVA: 0x00183488 File Offset: 0x00181688
		public override bool Paint(vtkContext2D painter)
		{
			return vtkColorLegend.vtkColorLegend_Paint_16(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060115B5 RID: 71093
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorLegend_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060115B6 RID: 71094 RVA: 0x001834C4 File Offset: 0x001816C4
		public new static vtkColorLegend SafeDownCast(vtkObjectBase o)
		{
			vtkColorLegend vtkColorLegend = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorLegend.vtkColorLegend_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorLegend = (vtkColorLegend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorLegend.Register(null);
				}
			}
			return vtkColorLegend;
		}

		// Token: 0x060115B7 RID: 71095
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorLegend_SetDrawBorder_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// Toggle whether or not a border should be drawn around this legend.
		/// The default behavior is to not draw a border.
		/// </summary>
		// Token: 0x060115B8 RID: 71096 RVA: 0x00183543 File Offset: 0x00181743
		public virtual void SetDrawBorder(bool _arg)
		{
			vtkColorLegend.vtkColorLegend_SetDrawBorder_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060115B9 RID: 71097
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorLegend_SetOrientation_19(HandleRef pThis, int orientation);

		/// <summary>
		/// Set/get the orientation of the legend.
		/// Valid orientations are VERTICAL (default) and HORIZONTAL.
		/// </summary>
		// Token: 0x060115BA RID: 71098 RVA: 0x0018355B File Offset: 0x0018175B
		public virtual void SetOrientation(int orientation)
		{
			vtkColorLegend.vtkColorLegend_SetOrientation_19(base.GetCppThis(), orientation);
		}

		// Token: 0x060115BB RID: 71099
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorLegend_SetPoint_20(HandleRef pThis, float x, float y);

		/// <summary>
		/// Set the point this legend is anchored to.
		/// </summary>
		// Token: 0x060115BC RID: 71100 RVA: 0x0018356B File Offset: 0x0018176B
		public override void SetPoint(float x, float y)
		{
			vtkColorLegend.vtkColorLegend_SetPoint_20(base.GetCppThis(), x, y);
		}

		// Token: 0x060115BD RID: 71101
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorLegend_SetPosition_21(HandleRef pThis, HandleRef pos);

		/// <summary>
		/// Set the origin, width, and height of the scalar bar drawn by this legend.
		/// This method overrides the anchor point, as well as any horizontal and
		/// vertical alignment that has been set for this legend.  If this is a
		/// problem for you, use SetPoint() and SetTextureSize() instead.
		/// </summary>
		// Token: 0x060115BE RID: 71102 RVA: 0x0018357C File Offset: 0x0018177C
		public virtual void SetPosition(vtkRectf pos)
		{
			vtkColorLegend.vtkColorLegend_SetPosition_21(base.GetCppThis(), (pos == null) ? default(HandleRef) : pos.GetCppThis());
		}

		// Token: 0x060115BF RID: 71103
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorLegend_SetTextureSize_22(HandleRef pThis, float w, float h);

		/// <summary>
		/// Set the size of the scalar bar drawn by this legend.
		/// </summary>
		// Token: 0x060115C0 RID: 71104 RVA: 0x001835AB File Offset: 0x001817AB
		public virtual void SetTextureSize(float w, float h)
		{
			vtkColorLegend.vtkColorLegend_SetTextureSize_22(base.GetCppThis(), w, h);
		}

		// Token: 0x060115C1 RID: 71105
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorLegend_SetTitle_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string title);

		/// <summary>
		/// Get/set the title text of the legend.
		/// </summary>
		// Token: 0x060115C2 RID: 71106 RVA: 0x001835BC File Offset: 0x001817BC
		public virtual void SetTitle(string title)
		{
			vtkColorLegend.vtkColorLegend_SetTitle_23(base.GetCppThis(), title);
		}

		// Token: 0x060115C3 RID: 71107
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorLegend_SetTransferFunction_24(HandleRef pThis, HandleRef transfer);

		/// <summary>
		/// Set/Get the transfer function that is used to draw the scalar bar
		/// within this legend.
		/// </summary>
		// Token: 0x060115C4 RID: 71108 RVA: 0x001835CC File Offset: 0x001817CC
		public virtual void SetTransferFunction(vtkScalarsToColors transfer)
		{
			vtkColorLegend.vtkColorLegend_SetTransferFunction_24(base.GetCppThis(), (transfer == null) ? default(HandleRef) : transfer.GetCppThis());
		}

		// Token: 0x060115C5 RID: 71109
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorLegend_Update_25(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x060115C6 RID: 71110 RVA: 0x001835FB File Offset: 0x001817FB
		public override void Update()
		{
			vtkColorLegend.vtkColorLegend_Update_25(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400140F RID: 5135
		public new const string MRFullTypeName = "Kitware.VTK.vtkColorLegend";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001410 RID: 5136
		public new static readonly string MRClassNameKey = "class vtkColorLegend";

		/// <summary>
		/// Enum of legend orientation types
		/// </summary>
		// Token: 0x02000644 RID: 1604
		public enum HORIZONTAL_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001412 RID: 5138
			HORIZONTAL = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001413 RID: 5139
			VERTICAL = 0
		}
	}
}
