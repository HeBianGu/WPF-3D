using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkControlPointsItem
	/// </summary>
	/// <remarks>
	///    Abstract class for control points items.
	///
	/// vtkControlPointsItem provides control point painting and management for
	/// subclasses that provide points (typically control points of a transfer
	/// function)
	/// </remarks>
	/// <seealso>
	///
	/// vtkScalarsToColorsItem
	/// vtkPiecewiseControlPointsItem
	/// </seealso>
	// Token: 0x02000646 RID: 1606
	public abstract class vtkControlPointsItem : vtkPlot
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601165E RID: 71262 RVA: 0x0018453A File Offset: 0x0018273A
		static vtkControlPointsItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkControlPointsItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkControlPointsItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601165F RID: 71263 RVA: 0x00184562 File Offset: 0x00182762
		public vtkControlPointsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011660 RID: 71264 RVA: 0x00184570 File Offset: 0x00182770
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011661 RID: 71265
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkControlPointsItem_AddPoint_01(HandleRef pThis, IntPtr newPos);

		/// <summary>
		/// Add a point to the function. Returns the index of the point (0 based),
		/// or -1 on error.
		/// Subclasses should reimplement this function to do the actual work.
		/// </summary>
		// Token: 0x06011662 RID: 71266 RVA: 0x0018457C File Offset: 0x0018277C
		public virtual long AddPoint(IntPtr newPos)
		{
			return vtkControlPointsItem.vtkControlPointsItem_AddPoint_01(base.GetCppThis(), newPos);
		}

		// Token: 0x06011663 RID: 71267
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_DeselectAllPoints_02(HandleRef pThis);

		/// <summary>
		/// Unselect all the previously selected points
		/// </summary>
		// Token: 0x06011664 RID: 71268 RVA: 0x0018459C File Offset: 0x0018279C
		public void DeselectAllPoints()
		{
			vtkControlPointsItem.vtkControlPointsItem_DeselectAllPoints_02(base.GetCppThis());
		}

		// Token: 0x06011665 RID: 71269
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_DeselectPoint_03(HandleRef pThis, long pointId);

		/// <summary>
		/// Unselect a point by its ID
		/// </summary>
		// Token: 0x06011666 RID: 71270 RVA: 0x001845AB File Offset: 0x001827AB
		public void DeselectPoint(long pointId)
		{
			vtkControlPointsItem.vtkControlPointsItem_DeselectPoint_03(base.GetCppThis(), pointId);
		}

		// Token: 0x06011667 RID: 71271
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_DeselectPoint_04(HandleRef pThis, IntPtr currentPoint);

		/// <summary>
		/// Utility function that unselects a point providing its coordinates.
		/// To be found, the position of the point must be no further away than its
		/// painted point size
		/// </summary>
		// Token: 0x06011668 RID: 71272 RVA: 0x001845BB File Offset: 0x001827BB
		public void DeselectPoint(IntPtr currentPoint)
		{
			vtkControlPointsItem.vtkControlPointsItem_DeselectPoint_04(base.GetCppThis(), currentPoint);
		}

		// Token: 0x06011669 RID: 71273
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_DrawPointsOff_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the flag to draw points.
		/// Default is true.
		/// </summary>
		// Token: 0x0601166A RID: 71274 RVA: 0x001845CB File Offset: 0x001827CB
		public virtual void DrawPointsOff()
		{
			vtkControlPointsItem.vtkControlPointsItem_DrawPointsOff_05(base.GetCppThis());
		}

		// Token: 0x0601166B RID: 71275
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_DrawPointsOn_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the flag to draw points.
		/// Default is true.
		/// </summary>
		// Token: 0x0601166C RID: 71276 RVA: 0x001845DA File Offset: 0x001827DA
		public virtual void DrawPointsOn()
		{
			vtkControlPointsItem.vtkControlPointsItem_DrawPointsOn_06(base.GetCppThis());
		}

		// Token: 0x0601166D RID: 71277
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkControlPointsItem_FindPoint_07(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Returns the vtkIdType of the point given its coordinates and a tolerance
		/// based on the screen point size.
		/// </summary>
		// Token: 0x0601166E RID: 71278 RVA: 0x001845EC File Offset: 0x001827EC
		public long FindPoint(IntPtr pos)
		{
			return vtkControlPointsItem.vtkControlPointsItem_FindPoint_07(base.GetCppThis(), pos);
		}

		// Token: 0x0601166F RID: 71279
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkControlPointsItem_GetAddPointItem_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Item dedicated to add point, to be added below all other items.
		/// Used only if UseAddPointItem is set to true.
		/// </summary>
		// Token: 0x06011670 RID: 71280 RVA: 0x0018460C File Offset: 0x0018280C
		public vtkPlot GetAddPointItem()
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkControlPointsItem.vtkControlPointsItem_GetAddPointItem_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011671 RID: 71281
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_GetBounds_09(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Bounds of the item, typically the bound of all the control points
		/// except if custom bounds have been set \sa SetUserBounds.
		/// </summary>
		// Token: 0x06011672 RID: 71282 RVA: 0x0018467B File Offset: 0x0018287B
		public override void GetBounds(IntPtr bounds)
		{
			vtkControlPointsItem.vtkControlPointsItem_GetBounds_09(base.GetCppThis(), bounds);
		}

		// Token: 0x06011673 RID: 71283
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_GetControlPoint_10(HandleRef pThis, long index, IntPtr point);

		/// <summary>
		/// Returns the x and y coordinates as well as the midpoint and sharpness
		/// of the control point corresponding to the index.
		/// point must be a double array of size 4.
		/// </summary>
		// Token: 0x06011674 RID: 71284 RVA: 0x0018468B File Offset: 0x0018288B
		public virtual void GetControlPoint(long index, IntPtr point)
		{
			vtkControlPointsItem.vtkControlPointsItem_GetControlPoint_10(base.GetCppThis(), index, point);
		}

		// Token: 0x06011675 RID: 71285
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkControlPointsItem_GetControlPointId_11(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Returns the id of the control point exactly matching pos, -1 if not found.
		/// </summary>
		// Token: 0x06011676 RID: 71286 RVA: 0x0018469C File Offset: 0x0018289C
		public long GetControlPointId(IntPtr pos)
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetControlPointId_11(base.GetCppThis(), pos);
		}

		// Token: 0x06011677 RID: 71287
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_GetControlPointsIds_12(HandleRef pThis, HandleRef ids, byte excludeFirstAndLast);

		/// <summary>
		/// Utility function that returns an array of all the control points IDs
		/// Typically: [0, 1, 2, ... n -1] where n is the point count
		/// Can exclude the first and last point ids from the array.
		/// </summary>
		// Token: 0x06011678 RID: 71288 RVA: 0x001846BC File Offset: 0x001828BC
		public void GetControlPointsIds(vtkIdTypeArray ids, bool excludeFirstAndLast)
		{
			vtkControlPointsItem.vtkControlPointsItem_GetControlPointsIds_12(base.GetCppThis(), (ids == null) ? default(HandleRef) : ids.GetCppThis(), excludeFirstAndLast ? (byte)1 : (byte)0);
		}

		// Token: 0x06011679 RID: 71289
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkControlPointsItem_GetCurrentPoint_13(HandleRef pThis);

		/// <summary>
		/// Returns the current point ID selected or -1 if there is no point current.
		/// No current point by default.
		/// </summary>
		// Token: 0x0601167A RID: 71290 RVA: 0x001846F4 File Offset: 0x001828F4
		public long GetCurrentPoint()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetCurrentPoint_13(base.GetCppThis());
		}

		// Token: 0x0601167B RID: 71291
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkControlPointsItem_GetDrawPoints_14(HandleRef pThis);

		/// <summary>
		/// Get/Set the flag to draw points.
		/// Default is true.
		/// </summary>
		// Token: 0x0601167C RID: 71292 RVA: 0x00184714 File Offset: 0x00182914
		public virtual bool GetDrawPoints()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetDrawPoints_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0601167D RID: 71293
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkControlPointsItem_GetEndPointsMovable_15(HandleRef pThis);

		/// <summary>
		/// If EndPointsMovable is false, the two end points will not
		/// be moved. True by default.
		/// </summary>
		// Token: 0x0601167E RID: 71294 RVA: 0x0018473C File Offset: 0x0018293C
		public virtual bool GetEndPointsMovable()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetEndPointsMovable_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0601167F RID: 71295
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkControlPointsItem_GetEndPointsRemovable_16(HandleRef pThis);

		/// <summary>
		/// If EndPointsRemovable is false, the two end points will not
		/// be removed. True by default.
		/// </summary>
		// Token: 0x06011680 RID: 71296 RVA: 0x00184764 File Offset: 0x00182964
		public virtual bool GetEndPointsRemovable()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetEndPointsRemovable_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06011681 RID: 71297
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkControlPointsItem_GetEndPointsXMovable_17(HandleRef pThis);

		/// <summary>
		/// If EndPointsMovable is false, the two end points will not
		/// be moved. True by default.
		/// </summary>
		// Token: 0x06011682 RID: 71298 RVA: 0x0018478C File Offset: 0x0018298C
		public virtual bool GetEndPointsXMovable()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetEndPointsXMovable_17(base.GetCppThis()) != 0;
		}

		// Token: 0x06011683 RID: 71299
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkControlPointsItem_GetEndPointsYMovable_18(HandleRef pThis);

		/// <summary>
		/// If EndPointsMovable is false, the two end points will not
		/// be moved. True by default.
		/// </summary>
		// Token: 0x06011684 RID: 71300 RVA: 0x001847B4 File Offset: 0x001829B4
		public virtual bool GetEndPointsYMovable()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetEndPointsYMovable_18(base.GetCppThis()) != 0;
		}

		// Token: 0x06011685 RID: 71301
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkControlPointsItem_GetLabelFormat_19(HandleRef pThis);

		/// <summary>
		/// Get/Set the label format. Default is "%.4f, %.4f".
		/// </summary>
		// Token: 0x06011686 RID: 71302 RVA: 0x001847DC File Offset: 0x001829DC
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkControlPointsItem.vtkControlPointsItem_GetLabelFormat_19(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011687 RID: 71303
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkControlPointsItem_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011688 RID: 71304 RVA: 0x00184818 File Offset: 0x00182A18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x06011689 RID: 71305
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkControlPointsItem_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601168A RID: 71306 RVA: 0x00184838 File Offset: 0x00182A38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x0601168B RID: 71307
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkControlPointsItem_GetNumberOfPoints_22(HandleRef pThis);

		/// <summary>
		/// Returns the total number of points
		/// </summary>
		// Token: 0x0601168C RID: 71308 RVA: 0x00184854 File Offset: 0x00182A54
		public virtual long GetNumberOfPoints()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetNumberOfPoints_22(base.GetCppThis());
		}

		// Token: 0x0601168D RID: 71309
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkControlPointsItem_GetNumberOfSelectedPoints_23(HandleRef pThis);

		/// <summary>
		/// Return the number of selected points.
		/// </summary>
		// Token: 0x0601168E RID: 71310 RVA: 0x00184874 File Offset: 0x00182A74
		public long GetNumberOfSelectedPoints()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetNumberOfSelectedPoints_23(base.GetCppThis());
		}

		// Token: 0x0601168F RID: 71311
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkControlPointsItem_GetScreenPointRadius_24(HandleRef pThis);

		/// <summary>
		/// Get/set the radius for screen points.
		/// Default is 6.f
		/// </summary>
		// Token: 0x06011690 RID: 71312 RVA: 0x00184894 File Offset: 0x00182A94
		public virtual float GetScreenPointRadius()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetScreenPointRadius_24(base.GetCppThis());
		}

		// Token: 0x06011691 RID: 71313
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkControlPointsItem_GetSelectedPointBrush_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Depending on the control points item, the brush might not be taken into
		/// account.
		/// </summary>
		// Token: 0x06011692 RID: 71314 RVA: 0x001848B4 File Offset: 0x00182AB4
		public virtual vtkBrush GetSelectedPointBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkControlPointsItem.vtkControlPointsItem_GetSelectedPointBrush_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrush = (vtkBrush)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrush.Register(null);
				}
			}
			return vtkBrush;
		}

		// Token: 0x06011693 RID: 71315
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkControlPointsItem_GetSelectedPointPen_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Gets the selected point pen and brush.
		/// </summary>
		// Token: 0x06011694 RID: 71316 RVA: 0x00184924 File Offset: 0x00182B24
		public virtual vtkPen GetSelectedPointPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkControlPointsItem.vtkControlPointsItem_GetSelectedPointPen_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		// Token: 0x06011695 RID: 71317
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkControlPointsItem_GetShowLabels_27(HandleRef pThis);

		/// <summary>
		/// When set to true, labels are shown on the current control point and the end
		/// points. Default is false.
		/// </summary>
		// Token: 0x06011696 RID: 71318 RVA: 0x00184994 File Offset: 0x00182B94
		public virtual bool GetShowLabels()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetShowLabels_27(base.GetCppThis()) != 0;
		}

		// Token: 0x06011697 RID: 71319
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkControlPointsItem_GetStrokeMode_28(HandleRef pThis);

		/// <summary>
		/// Controls whether or not control points are drawn (true) or clicked and
		/// moved (false).
		/// False by default.
		/// </summary>
		// Token: 0x06011698 RID: 71320 RVA: 0x001849BC File Offset: 0x00182BBC
		public virtual bool GetStrokeMode()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetStrokeMode_28(base.GetCppThis()) != 0;
		}

		// Token: 0x06011699 RID: 71321
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkControlPointsItem_GetSwitchPointsMode_29(HandleRef pThis);

		/// <summary>
		/// If DrawPoints is false, SwitchPoints controls the behavior when a control
		/// point is dragged past another point. The crossed point becomes current
		/// (true) or the current point is blocked/stopped (false).
		/// False by default.
		/// </summary>
		// Token: 0x0601169A RID: 71322 RVA: 0x001849E4 File Offset: 0x00182BE4
		public virtual bool GetSwitchPointsMode()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetSwitchPointsMode_29(base.GetCppThis()) != 0;
		}

		// Token: 0x0601169B RID: 71323
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkControlPointsItem_GetUseAddPointItem_30(HandleRef pThis);

		/// <summary>
		/// When enabled, a dedicated item is used to determine if a point should
		/// be added when clicking anywhere.
		/// This item can be recovered with GetAddPointItem and can this be placed
		/// below all other items. False by default.
		/// </summary>
		// Token: 0x0601169C RID: 71324 RVA: 0x00184A0C File Offset: 0x00182C0C
		public virtual bool GetUseAddPointItem()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetUseAddPointItem_30(base.GetCppThis()) != 0;
		}

		// Token: 0x0601169D RID: 71325
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkControlPointsItem_GetUserBounds_31(HandleRef pThis);

		/// <summary>
		/// Set custom bounds, except if bounds are invalid, bounds will be
		/// automatically computed based on the range of the control points
		/// Invalid bounds by default.
		/// </summary>
		// Token: 0x0601169E RID: 71326 RVA: 0x00184A34 File Offset: 0x00182C34
		public virtual double[] GetUserBounds()
		{
			IntPtr intPtr = vtkControlPointsItem.vtkControlPointsItem_GetUserBounds_31(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601169F RID: 71327
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_GetUserBounds_32(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set custom bounds, except if bounds are invalid, bounds will be
		/// automatically computed based on the range of the control points
		/// Invalid bounds by default.
		/// </summary>
		// Token: 0x060116A0 RID: 71328 RVA: 0x00184A7C File Offset: 0x00182C7C
		public virtual void GetUserBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkControlPointsItem.vtkControlPointsItem_GetUserBounds_32(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x060116A1 RID: 71329
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_GetUserBounds_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set custom bounds, except if bounds are invalid, bounds will be
		/// automatically computed based on the range of the control points
		/// Invalid bounds by default.
		/// </summary>
		// Token: 0x060116A2 RID: 71330 RVA: 0x00184A90 File Offset: 0x00182C90
		public virtual void GetUserBounds(IntPtr _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_GetUserBounds_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060116A3 RID: 71331
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkControlPointsItem_GetValidBounds_34(HandleRef pThis);

		/// <summary>
		/// Controls the valid range for the values.
		/// An invalid value (0, -1, 0., -1, 0, -1.) indicates that the valid
		/// range is the current bounds. It is the default behavior.
		/// </summary>
		// Token: 0x060116A4 RID: 71332 RVA: 0x00184AA0 File Offset: 0x00182CA0
		public virtual double[] GetValidBounds()
		{
			IntPtr intPtr = vtkControlPointsItem.vtkControlPointsItem_GetValidBounds_34(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060116A5 RID: 71333
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_GetValidBounds_35(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Controls the valid range for the values.
		/// An invalid value (0, -1, 0., -1, 0, -1.) indicates that the valid
		/// range is the current bounds. It is the default behavior.
		/// </summary>
		// Token: 0x060116A6 RID: 71334 RVA: 0x00184AE8 File Offset: 0x00182CE8
		public virtual void GetValidBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkControlPointsItem.vtkControlPointsItem_GetValidBounds_35(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x060116A7 RID: 71335
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_GetValidBounds_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Controls the valid range for the values.
		/// An invalid value (0, -1, 0., -1, 0, -1.) indicates that the valid
		/// range is the current bounds. It is the default behavior.
		/// </summary>
		// Token: 0x060116A8 RID: 71336 RVA: 0x00184AFC File Offset: 0x00182CFC
		public virtual void GetValidBounds(IntPtr _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_GetValidBounds_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060116A9 RID: 71337
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkControlPointsItem_IsA_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060116AA RID: 71338 RVA: 0x00184B0C File Offset: 0x00182D0C
		public override int IsA(string type)
		{
			return vtkControlPointsItem.vtkControlPointsItem_IsA_37(base.GetCppThis(), type);
		}

		// Token: 0x060116AB RID: 71339
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkControlPointsItem_IsOverPoint_38(HandleRef pThis, IntPtr pos, long pointId);

		/// <summary>
		/// Returns true if pos is above the pointId point, false otherwise.
		/// It uses the size of the drawn point. To search what point is under the pos,
		/// use the more efficient \sa FindPoint() instead.
		/// </summary>
		// Token: 0x060116AC RID: 71340 RVA: 0x00184B2C File Offset: 0x00182D2C
		public bool IsOverPoint(IntPtr pos, long pointId)
		{
			return vtkControlPointsItem.vtkControlPointsItem_IsOverPoint_38(base.GetCppThis(), pos, pointId) != 0;
		}

		// Token: 0x060116AD RID: 71341
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkControlPointsItem_IsTypeOf_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060116AE RID: 71342 RVA: 0x00184B54 File Offset: 0x00182D54
		public new static int IsTypeOf(string type)
		{
			return vtkControlPointsItem.vtkControlPointsItem_IsTypeOf_39(type);
		}

		// Token: 0x060116AF RID: 71343
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_MovePoints_40(HandleRef pThis, HandleRef translation, HandleRef pointIds);

		/// <summary>
		/// Move the points referred by pointIds by a given translation.
		/// The new positions won't be outside the bounds.
		/// MovePoints is typically called with GetControlPointsIds() or GetSelection().
		/// Warning: if you pass this-&gt;GetSelection(), the array is deleted after
		/// each individual point move. Increase the reference count of the array.
		/// See also MoveAllPoints()
		/// </summary>
		// Token: 0x060116B0 RID: 71344 RVA: 0x00184B70 File Offset: 0x00182D70
		public void MovePoints(vtkVector2f translation, vtkIdTypeArray pointIds)
		{
			vtkControlPointsItem.vtkControlPointsItem_MovePoints_40(base.GetCppThis(), (translation == null) ? default(HandleRef) : translation.GetCppThis(), (pointIds == null) ? default(HandleRef) : pointIds.GetCppThis());
		}

		// Token: 0x060116B1 RID: 71345
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_MovePoints_41(HandleRef pThis, HandleRef translation, byte dontMoveFirstAndLast);

		/// <summary>
		/// Utility function to move all the control points of the given translation
		/// If dontMoveFirstAndLast is true, then the first and last points won't be
		/// moved.
		/// </summary>
		// Token: 0x060116B2 RID: 71346 RVA: 0x00184BB4 File Offset: 0x00182DB4
		public void MovePoints(vtkVector2f translation, bool dontMoveFirstAndLast)
		{
			vtkControlPointsItem.vtkControlPointsItem_MovePoints_41(base.GetCppThis(), (translation == null) ? default(HandleRef) : translation.GetCppThis(), dontMoveFirstAndLast ? (byte)1 : (byte)0);
		}

		// Token: 0x060116B3 RID: 71347
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkControlPointsItem_NewInstance_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060116B4 RID: 71348 RVA: 0x00184BEC File Offset: 0x00182DEC
		public new vtkControlPointsItem NewInstance()
		{
			vtkControlPointsItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkControlPointsItem.vtkControlPointsItem_NewInstance_42(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkControlPointsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060116B5 RID: 71349
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkControlPointsItem_Paint_43(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint the points with a fixed size (cosmetic) which doesn't depend
		/// on the scene zoom factor. Selected and unselected points are drawn
		/// with a different color.
		/// </summary>
		// Token: 0x060116B6 RID: 71350 RVA: 0x00184C48 File Offset: 0x00182E48
		public override bool Paint(vtkContext2D painter)
		{
			return vtkControlPointsItem.vtkControlPointsItem_Paint_43(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060116B7 RID: 71351
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_RemoveCurrentPoint_44(HandleRef pThis);

		/// <summary>
		/// Remove the current point.
		/// </summary>
		// Token: 0x060116B8 RID: 71352 RVA: 0x00184C83 File Offset: 0x00182E83
		public void RemoveCurrentPoint()
		{
			vtkControlPointsItem.vtkControlPointsItem_RemoveCurrentPoint_44(base.GetCppThis());
		}

		// Token: 0x060116B9 RID: 71353
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkControlPointsItem_RemovePoint_45(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Remove a point of the function. Returns the index of the point (0 based),
		/// or -1 on error.
		/// Subclasses should reimplement this function to do the actual work.
		/// </summary>
		// Token: 0x060116BA RID: 71354 RVA: 0x00184C94 File Offset: 0x00182E94
		public virtual long RemovePoint(IntPtr pos)
		{
			return vtkControlPointsItem.vtkControlPointsItem_RemovePoint_45(base.GetCppThis(), pos);
		}

		// Token: 0x060116BB RID: 71355
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkControlPointsItem_RemovePoint_46(HandleRef pThis, long pointId);

		/// <summary>
		/// Remove a point give its id. It is a utility function that internally call
		/// the virtual method RemovePoint(double*) and return its result.
		/// </summary>
		// Token: 0x060116BC RID: 71356 RVA: 0x00184CB4 File Offset: 0x00182EB4
		public long RemovePoint(long pointId)
		{
			return vtkControlPointsItem.vtkControlPointsItem_RemovePoint_46(base.GetCppThis(), pointId);
		}

		// Token: 0x060116BD RID: 71357
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_ResetBounds_47(HandleRef pThis);

		/// <summary>
		/// Recompute the bounds next time they are requested.
		/// You shouldn't have to call it but it is provided for rare cases.
		/// </summary>
		// Token: 0x060116BE RID: 71358 RVA: 0x00184CD4 File Offset: 0x00182ED4
		public void ResetBounds()
		{
			vtkControlPointsItem.vtkControlPointsItem_ResetBounds_47(base.GetCppThis());
		}

		// Token: 0x060116BF RID: 71359
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkControlPointsItem_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060116C0 RID: 71360 RVA: 0x00184CE4 File Offset: 0x00182EE4
		public new static vtkControlPointsItem SafeDownCast(vtkObjectBase o)
		{
			vtkControlPointsItem vtkControlPointsItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkControlPointsItem.vtkControlPointsItem_SafeDownCast_48((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkControlPointsItem = (vtkControlPointsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkControlPointsItem.Register(null);
				}
			}
			return vtkControlPointsItem;
		}

		// Token: 0x060116C1 RID: 71361
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SelectAllPoints_49(HandleRef pThis);

		/// <summary>
		/// Select all the points
		/// </summary>
		// Token: 0x060116C2 RID: 71362 RVA: 0x00184D63 File Offset: 0x00182F63
		public void SelectAllPoints()
		{
			vtkControlPointsItem.vtkControlPointsItem_SelectAllPoints_49(base.GetCppThis());
		}

		// Token: 0x060116C3 RID: 71363
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SelectPoint_50(HandleRef pThis, long pointId);

		/// <summary>
		/// Select a point by its ID
		/// </summary>
		// Token: 0x060116C4 RID: 71364 RVA: 0x00184D72 File Offset: 0x00182F72
		public void SelectPoint(long pointId)
		{
			vtkControlPointsItem.vtkControlPointsItem_SelectPoint_50(base.GetCppThis(), pointId);
		}

		// Token: 0x060116C5 RID: 71365
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SelectPoint_51(HandleRef pThis, IntPtr currentPoint);

		/// <summary>
		/// Utility function that selects a point providing its coordinates.
		/// To be found, the position of the point must be no further away than its
		/// painted point size
		/// </summary>
		// Token: 0x060116C6 RID: 71366 RVA: 0x00184D82 File Offset: 0x00182F82
		public void SelectPoint(IntPtr currentPoint)
		{
			vtkControlPointsItem.vtkControlPointsItem_SelectPoint_51(base.GetCppThis(), currentPoint);
		}

		// Token: 0x060116C7 RID: 71367
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkControlPointsItem_SelectPoints_52(HandleRef pThis, HandleRef min, HandleRef max);

		/// <summary>
		/// Select all points in the specified rectangle.
		/// </summary>
		// Token: 0x060116C8 RID: 71368 RVA: 0x00184D94 File Offset: 0x00182F94
		public override bool SelectPoints(vtkVector2f min, vtkVector2f max)
		{
			return vtkControlPointsItem.vtkControlPointsItem_SelectPoints_52(base.GetCppThis(), (min == null) ? default(HandleRef) : min.GetCppThis(), (max == null) ? default(HandleRef) : max.GetCppThis()) != 0;
		}

		// Token: 0x060116C9 RID: 71369
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetControlPoint_53(HandleRef pThis, long index, IntPtr point);

		/// <summary>
		/// Sets the x and y coordinates as well as the midpoint and sharpness
		/// of the control point corresponding to the index.
		/// </summary>
		// Token: 0x060116CA RID: 71370 RVA: 0x00184DE4 File Offset: 0x00182FE4
		public virtual void SetControlPoint(long index, IntPtr point)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetControlPoint_53(base.GetCppThis(), index, point);
		}

		// Token: 0x060116CB RID: 71371
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetCurrentPoint_54(HandleRef pThis, long index);

		/// <summary>
		/// Sets the current point selected.
		/// </summary>
		// Token: 0x060116CC RID: 71372 RVA: 0x00184DF5 File Offset: 0x00182FF5
		public void SetCurrentPoint(long index)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetCurrentPoint_54(base.GetCppThis(), index);
		}

		// Token: 0x060116CD RID: 71373
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetDrawPoints_55(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set the flag to draw points.
		/// Default is true.
		/// </summary>
		// Token: 0x060116CE RID: 71374 RVA: 0x00184E05 File Offset: 0x00183005
		public virtual void SetDrawPoints(bool _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetDrawPoints_55(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060116CF RID: 71375
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetEndPointsRemovable_56(HandleRef pThis, byte _arg);

		/// <summary>
		/// If EndPointsRemovable is false, the two end points will not
		/// be removed. True by default.
		/// </summary>
		// Token: 0x060116D0 RID: 71376 RVA: 0x00184E1D File Offset: 0x0018301D
		public virtual void SetEndPointsRemovable(bool _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetEndPointsRemovable_56(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060116D1 RID: 71377
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetEndPointsXMovable_57(HandleRef pThis, byte _arg);

		/// <summary>
		/// If EndPointsMovable is false, the two end points will not
		/// be moved. True by default.
		/// </summary>
		// Token: 0x060116D2 RID: 71378 RVA: 0x00184E35 File Offset: 0x00183035
		public virtual void SetEndPointsXMovable(bool _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetEndPointsXMovable_57(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060116D3 RID: 71379
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetEndPointsYMovable_58(HandleRef pThis, byte _arg);

		/// <summary>
		/// If EndPointsMovable is false, the two end points will not
		/// be moved. True by default.
		/// </summary>
		// Token: 0x060116D4 RID: 71380 RVA: 0x00184E4D File Offset: 0x0018304D
		public virtual void SetEndPointsYMovable(bool _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetEndPointsYMovable_58(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060116D5 RID: 71381
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetLabelFormat_59(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the label format. Default is "%.4f, %.4f".
		/// </summary>
		// Token: 0x060116D6 RID: 71382 RVA: 0x00184E65 File Offset: 0x00183065
		public virtual void SetLabelFormat(string _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetLabelFormat_59(base.GetCppThis(), _arg);
		}

		// Token: 0x060116D7 RID: 71383
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetScreenPointRadius_60(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/set the radius for screen points.
		/// Default is 6.f
		/// </summary>
		// Token: 0x060116D8 RID: 71384 RVA: 0x00184E75 File Offset: 0x00183075
		public virtual void SetScreenPointRadius(float _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetScreenPointRadius_60(base.GetCppThis(), _arg);
		}

		// Token: 0x060116D9 RID: 71385
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetShowLabels_61(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true, labels are shown on the current control point and the end
		/// points. Default is false.
		/// </summary>
		// Token: 0x060116DA RID: 71386 RVA: 0x00184E85 File Offset: 0x00183085
		public virtual void SetShowLabels(bool _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetShowLabels_61(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060116DB RID: 71387
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetStrokeMode_62(HandleRef pThis, byte _arg);

		/// <summary>
		/// Controls whether or not control points are drawn (true) or clicked and
		/// moved (false).
		/// False by default.
		/// </summary>
		// Token: 0x060116DC RID: 71388 RVA: 0x00184E9D File Offset: 0x0018309D
		public virtual void SetStrokeMode(bool _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetStrokeMode_62(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060116DD RID: 71389
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetSwitchPointsMode_63(HandleRef pThis, byte _arg);

		/// <summary>
		/// If DrawPoints is false, SwitchPoints controls the behavior when a control
		/// point is dragged past another point. The crossed point becomes current
		/// (true) or the current point is blocked/stopped (false).
		/// False by default.
		/// </summary>
		// Token: 0x060116DE RID: 71390 RVA: 0x00184EB5 File Offset: 0x001830B5
		public virtual void SetSwitchPointsMode(bool _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetSwitchPointsMode_63(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060116DF RID: 71391
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetUseAddPointItem_64(HandleRef pThis, byte _arg);

		/// <summary>
		/// When enabled, a dedicated item is used to determine if a point should
		/// be added when clicking anywhere.
		/// This item can be recovered with GetAddPointItem and can this be placed
		/// below all other items. False by default.
		/// </summary>
		// Token: 0x060116E0 RID: 71392 RVA: 0x00184ECD File Offset: 0x001830CD
		public virtual void SetUseAddPointItem(bool _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetUseAddPointItem_64(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060116E1 RID: 71393
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetUserBounds_65(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set custom bounds, except if bounds are invalid, bounds will be
		/// automatically computed based on the range of the control points
		/// Invalid bounds by default.
		/// </summary>
		// Token: 0x060116E2 RID: 71394 RVA: 0x00184EE5 File Offset: 0x001830E5
		public virtual void SetUserBounds(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetUserBounds_65(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x060116E3 RID: 71395
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetUserBounds_66(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set custom bounds, except if bounds are invalid, bounds will be
		/// automatically computed based on the range of the control points
		/// Invalid bounds by default.
		/// </summary>
		// Token: 0x060116E4 RID: 71396 RVA: 0x00184EF9 File Offset: 0x001830F9
		public virtual void SetUserBounds(IntPtr _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetUserBounds_66(base.GetCppThis(), _arg);
		}

		// Token: 0x060116E5 RID: 71397
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetValidBounds_67(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Controls the valid range for the values.
		/// An invalid value (0, -1, 0., -1, 0, -1.) indicates that the valid
		/// range is the current bounds. It is the default behavior.
		/// </summary>
		// Token: 0x060116E6 RID: 71398 RVA: 0x00184F09 File Offset: 0x00183109
		public virtual void SetValidBounds(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetValidBounds_67(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x060116E7 RID: 71399
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SetValidBounds_68(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Controls the valid range for the values.
		/// An invalid value (0, -1, 0., -1, 0, -1.) indicates that the valid
		/// range is the current bounds. It is the default behavior.
		/// </summary>
		// Token: 0x060116E8 RID: 71400 RVA: 0x00184F1D File Offset: 0x0018311D
		public virtual void SetValidBounds(IntPtr _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetValidBounds_68(base.GetCppThis(), _arg);
		}

		// Token: 0x060116E9 RID: 71401
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SpreadPoints_69(HandleRef pThis, float factor, HandleRef pointIds);

		/// <summary>
		/// Spread the points referred by pointIds
		/// If factor &gt; 0, points are moved away from each other.
		/// If factor &lt; 0, points are moved closer to each other
		/// SpreadPoints is typically called with GetControlPointsIds() or GetSelection().
		/// Warning: if you pass this-&gt;GetSelection(), the array is deleted after
		/// each individual point move. Increase the reference count of the array.
		/// </summary>
		// Token: 0x060116EA RID: 71402 RVA: 0x00184F30 File Offset: 0x00183130
		public void SpreadPoints(float factor, vtkIdTypeArray pointIds)
		{
			vtkControlPointsItem.vtkControlPointsItem_SpreadPoints_69(base.GetCppThis(), factor, (pointIds == null) ? default(HandleRef) : pointIds.GetCppThis());
		}

		// Token: 0x060116EB RID: 71403
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_SpreadPoints_70(HandleRef pThis, float factor, byte dontSpreadFirstAndLast);

		/// <summary>
		/// Utility function to spread all the control points of a given factor
		/// If dontSpreadFirstAndLast is true, then the first and last points won't be
		/// spread.
		/// </summary>
		// Token: 0x060116EC RID: 71404 RVA: 0x00184F60 File Offset: 0x00183160
		public void SpreadPoints(float factor, bool dontSpreadFirstAndLast)
		{
			vtkControlPointsItem.vtkControlPointsItem_SpreadPoints_70(base.GetCppThis(), factor, dontSpreadFirstAndLast ? (byte)1 : (byte)0);
		}

		// Token: 0x060116ED RID: 71405
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_ToggleSelectPoint_71(HandleRef pThis, long pointId);

		/// <summary>
		/// Toggle the selection of a point by its ID. If the point was selected then
		/// unselect it, otherwise select it.
		/// </summary>
		// Token: 0x060116EE RID: 71406 RVA: 0x00184F79 File Offset: 0x00183179
		public void ToggleSelectPoint(long pointId)
		{
			vtkControlPointsItem.vtkControlPointsItem_ToggleSelectPoint_71(base.GetCppThis(), pointId);
		}

		// Token: 0x060116EF RID: 71407
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_ToggleSelectPoint_72(HandleRef pThis, IntPtr currentPoint);

		/// <summary>
		/// Utility function that toggles the selection a point providing its
		/// coordinates. To be found, the position of the point must be no further
		/// away than its painted point size
		/// </summary>
		// Token: 0x060116F0 RID: 71408 RVA: 0x00184F89 File Offset: 0x00183189
		public void ToggleSelectPoint(IntPtr currentPoint)
		{
			vtkControlPointsItem.vtkControlPointsItem_ToggleSelectPoint_72(base.GetCppThis(), currentPoint);
		}

		// Token: 0x060116F1 RID: 71409
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_UseAddPointItemOff_73(HandleRef pThis);

		/// <summary>
		/// When enabled, a dedicated item is used to determine if a point should
		/// be added when clicking anywhere.
		/// This item can be recovered with GetAddPointItem and can this be placed
		/// below all other items. False by default.
		/// </summary>
		// Token: 0x060116F2 RID: 71410 RVA: 0x00184F99 File Offset: 0x00183199
		public virtual void UseAddPointItemOff()
		{
			vtkControlPointsItem.vtkControlPointsItem_UseAddPointItemOff_73(base.GetCppThis());
		}

		// Token: 0x060116F3 RID: 71411
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkControlPointsItem_UseAddPointItemOn_74(HandleRef pThis);

		/// <summary>
		/// When enabled, a dedicated item is used to determine if a point should
		/// be added when clicking anywhere.
		/// This item can be recovered with GetAddPointItem and can this be placed
		/// below all other items. False by default.
		/// </summary>
		// Token: 0x060116F4 RID: 71412 RVA: 0x00184FA8 File Offset: 0x001831A8
		public virtual void UseAddPointItemOn()
		{
			vtkControlPointsItem.vtkControlPointsItem_UseAddPointItemOn_74(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001416 RID: 5142
		public new const string MRFullTypeName = "Kitware.VTK.vtkControlPointsItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001417 RID: 5143
		public new static readonly string MRClassNameKey = "class vtkControlPointsItem";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000647 RID: 1607
		public enum CurrentPointChangedEvent_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001419 RID: 5145
			CurrentPointChangedEvent = 1000,
			/// <summary>enum member</summary>
			// Token: 0x0400141A RID: 5146
			CurrentPointEditEvent
		}
	}
}
