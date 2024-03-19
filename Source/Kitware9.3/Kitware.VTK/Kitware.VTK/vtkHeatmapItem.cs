using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHeatmapItem
	/// </summary>
	/// <remarks>
	///    A 2D graphics item for rendering a heatmap
	///
	///
	/// This item draws a heatmap as a part of a vtkContextScene.
	///
	/// .SEE ALSO
	/// vtkTable
	/// </remarks>
	// Token: 0x0200006B RID: 107
	public class vtkHeatmapItem : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600137A RID: 4986 RVA: 0x0002196F File Offset: 0x0001FB6F
		static vtkHeatmapItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHeatmapItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHeatmapItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600137B RID: 4987 RVA: 0x00021997 File Offset: 0x0001FB97
		public vtkHeatmapItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600137C RID: 4988
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHeatmapItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600137D RID: 4989 RVA: 0x000219A8 File Offset: 0x0001FBA8
		public new static vtkHeatmapItem New()
		{
			vtkHeatmapItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHeatmapItem.vtkHeatmapItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHeatmapItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600137E RID: 4990 RVA: 0x000219FC File Offset: 0x0001FBFC
		public vtkHeatmapItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHeatmapItem.vtkHeatmapItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600137F RID: 4991 RVA: 0x00021A40 File Offset: 0x0001FC40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001380 RID: 4992
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeatmapItem_GetBounds_01(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this item as (Xmin,Xmax,Ymin,Ymax).
		/// </summary>
		// Token: 0x06001381 RID: 4993 RVA: 0x00021A4B File Offset: 0x0001FC4B
		public virtual void GetBounds(IntPtr bounds)
		{
			vtkHeatmapItem.vtkHeatmapItem_GetBounds_01(base.GetCppThis(), bounds);
		}

		// Token: 0x06001382 RID: 4994
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHeatmapItem_GetCellHeight_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the height of the cells in our heatmap.
		/// Default is 18 pixels.
		/// </summary>
		// Token: 0x06001383 RID: 4995 RVA: 0x00021A5C File Offset: 0x0001FC5C
		public virtual double GetCellHeight()
		{
			return vtkHeatmapItem.vtkHeatmapItem_GetCellHeight_02(base.GetCppThis());
		}

		// Token: 0x06001384 RID: 4996
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHeatmapItem_GetCellWidth_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the width of the cells in our heatmap.
		/// Default is 36 pixels.
		/// </summary>
		// Token: 0x06001385 RID: 4997 RVA: 0x00021A7C File Offset: 0x0001FC7C
		public virtual double GetCellWidth()
		{
			return vtkHeatmapItem.vtkHeatmapItem_GetCellWidth_03(base.GetCppThis());
		}

		// Token: 0x06001386 RID: 4998
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkHeatmapItem_GetColumnLabelWidth_04(HandleRef pThis);

		/// <summary>
		/// Get the width of the largest row or column label drawn by this
		/// heatmap.
		/// </summary>
		// Token: 0x06001387 RID: 4999 RVA: 0x00021A9C File Offset: 0x0001FC9C
		public virtual float GetColumnLabelWidth()
		{
			return vtkHeatmapItem.vtkHeatmapItem_GetColumnLabelWidth_04(base.GetCppThis());
		}

		// Token: 0x06001388 RID: 5000
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkHeatmapItem_GetNameColumn_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the column that specifies the name
		/// of this table's rows.  By default, we assume this
		/// column will be named "name".  If no such column can be
		/// found, we then assume that the 1st column in the table
		/// names the rows.
		/// </summary>
		// Token: 0x06001389 RID: 5001 RVA: 0x00021ABC File Offset: 0x0001FCBC
		public virtual string GetNameColumn()
		{
			return vtkHeatmapItem.vtkHeatmapItem_GetNameColumn_05(base.GetCppThis());
		}

		// Token: 0x0600138A RID: 5002
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHeatmapItem_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600138B RID: 5003 RVA: 0x00021ADC File Offset: 0x0001FCDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHeatmapItem.vtkHeatmapItem_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600138C RID: 5004
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHeatmapItem_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600138D RID: 5005 RVA: 0x00021AFC File Offset: 0x0001FCFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHeatmapItem.vtkHeatmapItem_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600138E RID: 5006
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHeatmapItem_GetOrientation_08(HandleRef pThis);

		/// <summary>
		/// Get the current heatmap orientation.
		/// </summary>
		// Token: 0x0600138F RID: 5007 RVA: 0x00021B18 File Offset: 0x0001FD18
		public int GetOrientation()
		{
			return vtkHeatmapItem.vtkHeatmapItem_GetOrientation_08(base.GetCppThis());
		}

		// Token: 0x06001390 RID: 5008
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHeatmapItem_GetPosition_09(HandleRef pThis);

		/// <summary>
		/// Get position of the heatmap.
		/// </summary>
		// Token: 0x06001391 RID: 5009 RVA: 0x00021B38 File Offset: 0x0001FD38
		public virtual float[] GetPosition()
		{
			IntPtr intPtr = vtkHeatmapItem.vtkHeatmapItem_GetPosition_09(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001392 RID: 5010
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeatmapItem_GetPosition_10(HandleRef pThis, ref float _arg1, ref float _arg2);

		/// <summary>
		/// Get position of the heatmap.
		/// </summary>
		// Token: 0x06001393 RID: 5011 RVA: 0x00021B80 File Offset: 0x0001FD80
		public virtual void GetPosition(ref float _arg1, ref float _arg2)
		{
			vtkHeatmapItem.vtkHeatmapItem_GetPosition_10(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06001394 RID: 5012
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeatmapItem_GetPosition_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get position of the heatmap.
		/// </summary>
		// Token: 0x06001395 RID: 5013 RVA: 0x00021B91 File Offset: 0x0001FD91
		public virtual void GetPosition(IntPtr _arg)
		{
			vtkHeatmapItem.vtkHeatmapItem_GetPosition_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06001396 RID: 5014
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHeatmapItem_GetPositionVector_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get position of the heatmap.
		/// </summary>
		// Token: 0x06001397 RID: 5015 RVA: 0x00021BA4 File Offset: 0x0001FDA4
		public vtkVector2f GetPositionVector()
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHeatmapItem.vtkHeatmapItem_GetPositionVector_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001398 RID: 5016
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkHeatmapItem_GetRowLabelWidth_13(HandleRef pThis);

		/// <summary>
		/// Get the width of the largest row or column label drawn by this
		/// heatmap.
		/// </summary>
		// Token: 0x06001399 RID: 5017 RVA: 0x00021C00 File Offset: 0x0001FE00
		public virtual float GetRowLabelWidth()
		{
			return vtkHeatmapItem.vtkHeatmapItem_GetRowLabelWidth_13(base.GetCppThis());
		}

		// Token: 0x0600139A RID: 5018
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHeatmapItem_GetRowNames_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the table that this item draws.
		/// </summary>
		// Token: 0x0600139B RID: 5019 RVA: 0x00021C20 File Offset: 0x0001FE20
		public vtkStringArray GetRowNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHeatmapItem.vtkHeatmapItem_GetRowNames_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x0600139C RID: 5020
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHeatmapItem_GetTable_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the table that this item draws.
		/// </summary>
		// Token: 0x0600139D RID: 5021 RVA: 0x00021C90 File Offset: 0x0001FE90
		public vtkTable GetTable()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHeatmapItem.vtkHeatmapItem_GetTable_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x0600139E RID: 5022
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHeatmapItem_GetTextAngleForOrientation_16(HandleRef pThis, int orientation);

		/// <summary>
		/// Get the angle that row labels should be rotated for the corresponding
		/// heatmap orientation.  For the default orientation (LEFT_TO_RIGHT), this
		/// is 0 degrees.
		/// </summary>
		// Token: 0x0600139F RID: 5023 RVA: 0x00021D00 File Offset: 0x0001FF00
		public double GetTextAngleForOrientation(int orientation)
		{
			return vtkHeatmapItem.vtkHeatmapItem_GetTextAngleForOrientation_16(base.GetCppThis(), orientation);
		}

		// Token: 0x060013A0 RID: 5024
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHeatmapItem_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060013A1 RID: 5025 RVA: 0x00021D20 File Offset: 0x0001FF20
		public override int IsA(string type)
		{
			return vtkHeatmapItem.vtkHeatmapItem_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x060013A2 RID: 5026
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHeatmapItem_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060013A3 RID: 5027 RVA: 0x00021D40 File Offset: 0x0001FF40
		public new static int IsTypeOf(string type)
		{
			return vtkHeatmapItem.vtkHeatmapItem_IsTypeOf_18(type);
		}

		// Token: 0x060013A4 RID: 5028
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeatmapItem_MarkRowAsBlank_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string rowName);

		/// <summary>
		/// Mark a row as blank, meaning that no cells will be drawn for it.
		/// Used by vtkTreeHeatmapItem to represent missing data.
		/// </summary>
		// Token: 0x060013A5 RID: 5029 RVA: 0x00021D5A File Offset: 0x0001FF5A
		public void MarkRowAsBlank(string rowName)
		{
			vtkHeatmapItem.vtkHeatmapItem_MarkRowAsBlank_19(base.GetCppThis(), rowName);
		}

		// Token: 0x060013A6 RID: 5030
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHeatmapItem_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060013A7 RID: 5031 RVA: 0x00021D6C File Offset: 0x0001FF6C
		public new vtkHeatmapItem NewInstance()
		{
			vtkHeatmapItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHeatmapItem.vtkHeatmapItem_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHeatmapItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060013A8 RID: 5032
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHeatmapItem_Paint_22(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paints the table as a heatmap.
		/// </summary>
		// Token: 0x060013A9 RID: 5033 RVA: 0x00021DC8 File Offset: 0x0001FFC8
		public override bool Paint(vtkContext2D painter)
		{
			return vtkHeatmapItem.vtkHeatmapItem_Paint_22(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060013AA RID: 5034
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHeatmapItem_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060013AB RID: 5035 RVA: 0x00021E04 File Offset: 0x00020004
		public new static vtkHeatmapItem SafeDownCast(vtkObjectBase o)
		{
			vtkHeatmapItem vtkHeatmapItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHeatmapItem.vtkHeatmapItem_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHeatmapItem = (vtkHeatmapItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHeatmapItem.Register(null);
				}
			}
			return vtkHeatmapItem;
		}

		// Token: 0x060013AC RID: 5036
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeatmapItem_SetCellHeight_24(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the height of the cells in our heatmap.
		/// Default is 18 pixels.
		/// </summary>
		// Token: 0x060013AD RID: 5037 RVA: 0x00021E83 File Offset: 0x00020083
		public virtual void SetCellHeight(double _arg)
		{
			vtkHeatmapItem.vtkHeatmapItem_SetCellHeight_24(base.GetCppThis(), _arg);
		}

		// Token: 0x060013AE RID: 5038
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeatmapItem_SetCellWidth_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the width of the cells in our heatmap.
		/// Default is 36 pixels.
		/// </summary>
		// Token: 0x060013AF RID: 5039 RVA: 0x00021E93 File Offset: 0x00020093
		public virtual void SetCellWidth(double _arg)
		{
			vtkHeatmapItem.vtkHeatmapItem_SetCellWidth_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060013B0 RID: 5040
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeatmapItem_SetNameColumn_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the column that specifies the name
		/// of this table's rows.  By default, we assume this
		/// column will be named "name".  If no such column can be
		/// found, we then assume that the 1st column in the table
		/// names the rows.
		/// </summary>
		// Token: 0x060013B1 RID: 5041 RVA: 0x00021EA3 File Offset: 0x000200A3
		public virtual void SetNameColumn(string _arg)
		{
			vtkHeatmapItem.vtkHeatmapItem_SetNameColumn_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060013B2 RID: 5042
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeatmapItem_SetOrientation_27(HandleRef pThis, int orientation);

		/// <summary>
		/// Set which way the table should face within the visualization.
		/// </summary>
		// Token: 0x060013B3 RID: 5043 RVA: 0x00021EB3 File Offset: 0x000200B3
		public void SetOrientation(int orientation)
		{
			vtkHeatmapItem.vtkHeatmapItem_SetOrientation_27(base.GetCppThis(), orientation);
		}

		// Token: 0x060013B4 RID: 5044
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeatmapItem_SetPosition_28(HandleRef pThis, float _arg1, float _arg2);

		/// <summary>
		/// Set the position of the heatmap.
		/// </summary>
		// Token: 0x060013B5 RID: 5045 RVA: 0x00021EC3 File Offset: 0x000200C3
		public virtual void SetPosition(float _arg1, float _arg2)
		{
			vtkHeatmapItem.vtkHeatmapItem_SetPosition_28(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060013B6 RID: 5046
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeatmapItem_SetPosition_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the position of the heatmap.
		/// </summary>
		// Token: 0x060013B7 RID: 5047 RVA: 0x00021ED4 File Offset: 0x000200D4
		public void SetPosition(IntPtr _arg)
		{
			vtkHeatmapItem.vtkHeatmapItem_SetPosition_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060013B8 RID: 5048
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeatmapItem_SetPosition_30(HandleRef pThis, HandleRef pos);

		/// <summary>
		/// Set the position of the heatmap.
		/// </summary>
		// Token: 0x060013B9 RID: 5049 RVA: 0x00021EE4 File Offset: 0x000200E4
		public void SetPosition(vtkVector2f pos)
		{
			vtkHeatmapItem.vtkHeatmapItem_SetPosition_30(base.GetCppThis(), (pos == null) ? default(HandleRef) : pos.GetCppThis());
		}

		// Token: 0x060013BA RID: 5050
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeatmapItem_SetTable_31(HandleRef pThis, HandleRef table);

		/// <summary>
		/// Set the table that this item draws.  The first column of the table
		/// must contain the names of the rows.
		/// </summary>
		// Token: 0x060013BB RID: 5051 RVA: 0x00021F14 File Offset: 0x00020114
		public virtual void SetTable(vtkTable table)
		{
			vtkHeatmapItem.vtkHeatmapItem_SetTable_31(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000461 RID: 1121
		public new const string MRFullTypeName = "Kitware.VTK.vtkHeatmapItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000462 RID: 1122
		public new static readonly string MRClassNameKey = "class vtkHeatmapItem";

		/// <summary>
		/// Enum for Orientation.
		/// </summary>
		// Token: 0x0200006C RID: 108
		public enum DOWN_TO_UP_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000464 RID: 1124
			DOWN_TO_UP = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000465 RID: 1125
			LEFT_TO_RIGHT = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000466 RID: 1126
			RIGHT_TO_LEFT = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000467 RID: 1127
			UP_TO_DOWN = 1
		}
	}
}
