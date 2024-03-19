using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParallelCoordinatesView
	/// </summary>
	/// <remarks>
	///    view to be used with vtkParallelCoordinatesRepresentation
	///
	///
	///
	/// This class manages interaction with the vtkParallelCoordinatesRepresentation.  There are
	/// two inspection modes: axis manipulation and line selection.  In axis manipulation mode,
	/// PC axes can be dragged and reordered with the LMB, axis ranges can be increased/decreased
	/// by dragging up/down with the LMB, and RMB controls zoom and pan.
	///
	/// In line selection mode, there are three subclasses of selections: lasso, angle, and
	/// function selection.  Lasso selection lets the user brush a line and select all PC lines
	/// that pass nearby.  Angle selection lets the user draw a representative line between axes
	/// and select all lines that have similar orientation.  Function selection lets the user
	/// draw two representative lines between a pair of axes and select all lines that match
	/// the linear interpolation of those lines.
	///
	/// There are several self-explanatory operators for combining selections: ADD, SUBTRACT
	/// REPLACE, and INTERSECT.
	/// </remarks>
	// Token: 0x0200007D RID: 125
	public class vtkParallelCoordinatesView : vtkRenderView
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001772 RID: 6002 RVA: 0x00026D73 File Offset: 0x00024F73
		static vtkParallelCoordinatesView()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelCoordinatesView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesView"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001773 RID: 6003 RVA: 0x00026D9B File Offset: 0x00024F9B
		public vtkParallelCoordinatesView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001774 RID: 6004
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001775 RID: 6005 RVA: 0x00026DAC File Offset: 0x00024FAC
		public new static vtkParallelCoordinatesView New()
		{
			vtkParallelCoordinatesView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesView.vtkParallelCoordinatesView_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001776 RID: 6006 RVA: 0x00026E00 File Offset: 0x00025000
		public vtkParallelCoordinatesView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParallelCoordinatesView.vtkParallelCoordinatesView_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001777 RID: 6007 RVA: 0x00026E44 File Offset: 0x00025044
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001778 RID: 6008
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001779 RID: 6009 RVA: 0x00026E50 File Offset: 0x00025050
		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_ApplyViewTheme_01(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		// Token: 0x0600177A RID: 6010
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesView_GetBrushMode_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600177B RID: 6011 RVA: 0x00026E80 File Offset: 0x00025080
		public virtual int GetBrushMode()
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_GetBrushMode_02(base.GetCppThis());
		}

		// Token: 0x0600177C RID: 6012
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesView_GetBrushOperator_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600177D RID: 6013 RVA: 0x00026EA0 File Offset: 0x000250A0
		public virtual int GetBrushOperator()
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_GetBrushOperator_03(base.GetCppThis());
		}

		// Token: 0x0600177E RID: 6014
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesView_GetCurrentBrushClass_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600177F RID: 6015 RVA: 0x00026EC0 File Offset: 0x000250C0
		public virtual int GetCurrentBrushClass()
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_GetCurrentBrushClass_04(base.GetCppThis());
		}

		// Token: 0x06001780 RID: 6016
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesView_GetInspectMode_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001781 RID: 6017 RVA: 0x00026EE0 File Offset: 0x000250E0
		public virtual int GetInspectMode()
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_GetInspectMode_05(base.GetCppThis());
		}

		// Token: 0x06001782 RID: 6018
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesView_GetMaximumNumberOfBrushPoints_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001783 RID: 6019 RVA: 0x00026F00 File Offset: 0x00025100
		public virtual int GetMaximumNumberOfBrushPoints()
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_GetMaximumNumberOfBrushPoints_06(base.GetCppThis());
		}

		// Token: 0x06001784 RID: 6020
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelCoordinatesView_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001785 RID: 6021 RVA: 0x00026F20 File Offset: 0x00025120
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06001786 RID: 6022
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelCoordinatesView_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001787 RID: 6023 RVA: 0x00026F40 File Offset: 0x00025140
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06001788 RID: 6024
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesView_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001789 RID: 6025 RVA: 0x00026F5C File Offset: 0x0002515C
		public override int IsA(string type)
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600178A RID: 6026
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesView_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600178B RID: 6027 RVA: 0x00026F7C File Offset: 0x0002517C
		public new static int IsTypeOf(string type)
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_IsTypeOf_10(type);
		}

		// Token: 0x0600178C RID: 6028
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesView_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600178D RID: 6029 RVA: 0x00026F98 File Offset: 0x00025198
		public new vtkParallelCoordinatesView NewInstance()
		{
			vtkParallelCoordinatesView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesView.vtkParallelCoordinatesView_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600178E RID: 6030
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesView_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600178F RID: 6031 RVA: 0x00026FF4 File Offset: 0x000251F4
		public new static vtkParallelCoordinatesView SafeDownCast(vtkObjectBase o)
		{
			vtkParallelCoordinatesView vtkParallelCoordinatesView = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesView.vtkParallelCoordinatesView_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelCoordinatesView = (vtkParallelCoordinatesView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelCoordinatesView.Register(null);
				}
			}
			return vtkParallelCoordinatesView;
		}

		// Token: 0x06001790 RID: 6032
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetBrushMode_14(HandleRef pThis, int arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001791 RID: 6033 RVA: 0x00027073 File Offset: 0x00025273
		public void SetBrushMode(int arg0)
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushMode_14(base.GetCppThis(), arg0);
		}

		// Token: 0x06001792 RID: 6034
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetBrushModeToAngle_15(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001793 RID: 6035 RVA: 0x00027083 File Offset: 0x00025283
		public void SetBrushModeToAngle()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushModeToAngle_15(base.GetCppThis());
		}

		// Token: 0x06001794 RID: 6036
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetBrushModeToAxisThreshold_16(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001795 RID: 6037 RVA: 0x00027092 File Offset: 0x00025292
		public void SetBrushModeToAxisThreshold()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushModeToAxisThreshold_16(base.GetCppThis());
		}

		// Token: 0x06001796 RID: 6038
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetBrushModeToFunction_17(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001797 RID: 6039 RVA: 0x000270A1 File Offset: 0x000252A1
		public void SetBrushModeToFunction()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushModeToFunction_17(base.GetCppThis());
		}

		// Token: 0x06001798 RID: 6040
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetBrushModeToLasso_18(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001799 RID: 6041 RVA: 0x000270B0 File Offset: 0x000252B0
		public void SetBrushModeToLasso()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushModeToLasso_18(base.GetCppThis());
		}

		// Token: 0x0600179A RID: 6042
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetBrushOperator_19(HandleRef pThis, int arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600179B RID: 6043 RVA: 0x000270BF File Offset: 0x000252BF
		public void SetBrushOperator(int arg0)
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushOperator_19(base.GetCppThis(), arg0);
		}

		// Token: 0x0600179C RID: 6044
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetBrushOperatorToAdd_20(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600179D RID: 6045 RVA: 0x000270CF File Offset: 0x000252CF
		public void SetBrushOperatorToAdd()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushOperatorToAdd_20(base.GetCppThis());
		}

		// Token: 0x0600179E RID: 6046
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetBrushOperatorToIntersect_21(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600179F RID: 6047 RVA: 0x000270DE File Offset: 0x000252DE
		public void SetBrushOperatorToIntersect()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushOperatorToIntersect_21(base.GetCppThis());
		}

		// Token: 0x060017A0 RID: 6048
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetBrushOperatorToReplace_22(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060017A1 RID: 6049 RVA: 0x000270ED File Offset: 0x000252ED
		public void SetBrushOperatorToReplace()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushOperatorToReplace_22(base.GetCppThis());
		}

		// Token: 0x060017A2 RID: 6050
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetBrushOperatorToSubtract_23(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060017A3 RID: 6051 RVA: 0x000270FC File Offset: 0x000252FC
		public void SetBrushOperatorToSubtract()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushOperatorToSubtract_23(base.GetCppThis());
		}

		// Token: 0x060017A4 RID: 6052
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetCurrentBrushClass_24(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060017A5 RID: 6053 RVA: 0x0002710B File Offset: 0x0002530B
		public virtual void SetCurrentBrushClass(int _arg)
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetCurrentBrushClass_24(base.GetCppThis(), _arg);
		}

		// Token: 0x060017A6 RID: 6054
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetInpsectModeToSelectData_25(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060017A7 RID: 6055 RVA: 0x0002711B File Offset: 0x0002531B
		public void SetInpsectModeToSelectData()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetInpsectModeToSelectData_25(base.GetCppThis());
		}

		// Token: 0x060017A8 RID: 6056
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetInspectMode_26(HandleRef pThis, int arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060017A9 RID: 6057 RVA: 0x0002712A File Offset: 0x0002532A
		public void SetInspectMode(int arg0)
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetInspectMode_26(base.GetCppThis(), arg0);
		}

		// Token: 0x060017AA RID: 6058
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetInspectModeToManipulateAxes_27(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060017AB RID: 6059 RVA: 0x0002713A File Offset: 0x0002533A
		public void SetInspectModeToManipulateAxes()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetInspectModeToManipulateAxes_27(base.GetCppThis());
		}

		// Token: 0x060017AC RID: 6060
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesView_SetMaximumNumberOfBrushPoints_28(HandleRef pThis, int arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060017AD RID: 6061 RVA: 0x00027149 File Offset: 0x00025349
		public void SetMaximumNumberOfBrushPoints(int arg0)
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetMaximumNumberOfBrushPoints_28(base.GetCppThis(), arg0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400048E RID: 1166
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesView";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400048F RID: 1167
		public new static readonly string MRClassNameKey = "class vtkParallelCoordinatesView";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200007E RID: 126
		public enum VTK_BRUSH_ANGLE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000491 RID: 1169
			VTK_BRUSH_ANGLE = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000492 RID: 1170
			VTK_BRUSH_AXISTHRESHOLD = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000493 RID: 1171
			VTK_BRUSH_FUNCTION = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000494 RID: 1172
			VTK_BRUSH_LASSO = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000495 RID: 1173
			VTK_BRUSH_MODECOUNT = 4
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200007F RID: 127
		public enum VTK_BRUSHOPERATOR_ADD_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000497 RID: 1175
			VTK_BRUSHOPERATOR_ADD,
			/// <summary>enum member</summary>
			// Token: 0x04000498 RID: 1176
			VTK_BRUSHOPERATOR_INTERSECT = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000499 RID: 1177
			VTK_BRUSHOPERATOR_MODECOUNT = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400049A RID: 1178
			VTK_BRUSHOPERATOR_REPLACE = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400049B RID: 1179
			VTK_BRUSHOPERATOR_SUBTRACT = 1
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000080 RID: 128
		public enum VTK_INSPECT_MANIPULATE_AXES_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400049D RID: 1181
			VTK_INSPECT_MANIPULATE_AXES,
			/// <summary>enum member</summary>
			// Token: 0x0400049E RID: 1182
			VTK_INSPECT_MODECOUNT = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400049F RID: 1183
			VTK_INSPECT_SELECT_DATA = 1
		}
	}
}
