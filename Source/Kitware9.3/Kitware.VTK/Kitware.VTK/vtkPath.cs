using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPath
	/// </summary>
	/// <remarks>
	///    concrete dataset representing a path defined by Bezier
	/// curves.
	///
	/// vtkPath provides a container for paths composed of line segments,
	/// 2nd-order (quadratic) and 3rd-order (cubic) Bezier curves.
	/// </remarks>
	// Token: 0x02000A8F RID: 2703
	public class vtkPath : vtkPointSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C562 RID: 116066 RVA: 0x0027CE93 File Offset: 0x0027B093
		static vtkPath()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPath"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C563 RID: 116067 RVA: 0x0027CEBB File Offset: 0x0027B0BB
		public vtkPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C564 RID: 116068
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C565 RID: 116069 RVA: 0x0027CECC File Offset: 0x0027B0CC
		public new static vtkPath New()
		{
			vtkPath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPath.vtkPath_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C566 RID: 116070 RVA: 0x0027CF20 File Offset: 0x0027B120
		public vtkPath() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPath.vtkPath_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C567 RID: 116071 RVA: 0x0027CF64 File Offset: 0x0027B164
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C568 RID: 116072
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPath_Allocate_01(HandleRef pThis, long size, int extSize);

		/// <summary>
		/// Method allocates initial storage for points. Use this method before the
		/// method vtkPath::InsertNextPoint().
		/// </summary>
		// Token: 0x0601C569 RID: 116073 RVA: 0x0027CF6F File Offset: 0x0027B16F
		public void Allocate(long size, int extSize)
		{
			vtkPath.vtkPath_Allocate_01(base.GetCppThis(), size, extSize);
		}

		// Token: 0x0601C56A RID: 116074
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPath_GetCell_02(HandleRef pThis, long arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// vtkPath doesn't use cells. These methods return trivial values.
		/// </summary>
		// Token: 0x0601C56B RID: 116075 RVA: 0x0027CF80 File Offset: 0x0027B180
		public override vtkCell GetCell(long arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPath.vtkPath_GetCell_02(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601C56C RID: 116076
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPath_GetCell_03(HandleRef pThis, long arg0, HandleRef arg1);

		/// <summary>
		/// vtkPath doesn't use cells. These methods return trivial values.
		/// </summary>
		// Token: 0x0601C56D RID: 116077 RVA: 0x0027CFF0 File Offset: 0x0027B1F0
		public override void GetCell(long arg0, vtkGenericCell arg1)
		{
			vtkPath.vtkPath_GetCell_03(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601C56E RID: 116078
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPath_GetCellPoints_04(HandleRef pThis, long arg0, HandleRef ptIds);

		/// <summary>
		/// vtkPath doesn't use cells, this method just clears ptIds.
		/// </summary>
		// Token: 0x0601C56F RID: 116079 RVA: 0x0027D020 File Offset: 0x0027B220
		public override void GetCellPoints(long arg0, vtkIdList ptIds)
		{
			vtkPath.vtkPath_GetCellPoints_04(base.GetCppThis(), arg0, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601C570 RID: 116080
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPath_GetCellType_05(HandleRef pThis, long arg0);

		/// <summary>
		/// vtkPath doesn't use cells. These methods return trivial values.
		/// </summary>
		// Token: 0x0601C571 RID: 116081 RVA: 0x0027D050 File Offset: 0x0027B250
		public override int GetCellType(long arg0)
		{
			return vtkPath.vtkPath_GetCellType_05(base.GetCppThis(), arg0);
		}

		// Token: 0x0601C572 RID: 116082
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPath_GetCodes_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the array of control point codes:
		/// </summary>
		// Token: 0x0601C573 RID: 116083 RVA: 0x0027D070 File Offset: 0x0027B270
		public vtkIntArray GetCodes()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPath.vtkPath_GetCodes_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x0601C574 RID: 116084
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPath_GetData_07(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C575 RID: 116085 RVA: 0x0027D0E0 File Offset: 0x0027B2E0
		public new static vtkPath GetData(vtkInformation info)
		{
			vtkPath vtkPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPath.vtkPath_GetData_07((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPath = (vtkPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPath.Register(null);
				}
			}
			return vtkPath;
		}

		// Token: 0x0601C576 RID: 116086
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPath_GetData_08(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C577 RID: 116087 RVA: 0x0027D160 File Offset: 0x0027B360
		public new static vtkPath GetData(vtkInformationVector v, int i)
		{
			vtkPath vtkPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPath.vtkPath_GetData_08((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPath = (vtkPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPath.Register(null);
				}
			}
			return vtkPath;
		}

		// Token: 0x0601C578 RID: 116088
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPath_GetDataObjectType_09(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601C579 RID: 116089 RVA: 0x0027D1E0 File Offset: 0x0027B3E0
		public override int GetDataObjectType()
		{
			return vtkPath.vtkPath_GetDataObjectType_09(base.GetCppThis());
		}

		// Token: 0x0601C57A RID: 116090
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPath_GetMaxCellSize_10(HandleRef pThis);

		/// <summary>
		/// Return the maximum cell size in this poly data.
		/// </summary>
		// Token: 0x0601C57B RID: 116091 RVA: 0x0027D200 File Offset: 0x0027B400
		public override int GetMaxCellSize()
		{
			return vtkPath.vtkPath_GetMaxCellSize_10(base.GetCppThis());
		}

		// Token: 0x0601C57C RID: 116092
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPath_GetMaxSpatialDimension_11(HandleRef pThis);

		/// <summary>
		/// Get the maximum spatial dimensionality of the data
		/// which is the maximum dimension of all cells.
		/// </summary>
		// Token: 0x0601C57D RID: 116093 RVA: 0x0027D220 File Offset: 0x0027B420
		public override int GetMaxSpatialDimension()
		{
			return vtkPath.vtkPath_GetMaxSpatialDimension_11(base.GetCppThis());
		}

		// Token: 0x0601C57E RID: 116094
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPath_GetNumberOfCells_12(HandleRef pThis);

		/// <summary>
		/// vtkPath doesn't use cells. These methods return trivial values.
		/// </summary>
		// Token: 0x0601C57F RID: 116095 RVA: 0x0027D240 File Offset: 0x0027B440
		public override long GetNumberOfCells()
		{
			return vtkPath.vtkPath_GetNumberOfCells_12(base.GetCppThis());
		}

		// Token: 0x0601C580 RID: 116096
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPath_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C581 RID: 116097 RVA: 0x0027D260 File Offset: 0x0027B460
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPath.vtkPath_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601C582 RID: 116098
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPath_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C583 RID: 116099 RVA: 0x0027D280 File Offset: 0x0027B480
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPath.vtkPath_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601C584 RID: 116100
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPath_GetPointCells_15(HandleRef pThis, long ptId, HandleRef cellIds);

		/// <summary>
		/// vtkPath doesn't use cells, this method just clears cellIds.
		/// </summary>
		// Token: 0x0601C585 RID: 116101 RVA: 0x0027D29C File Offset: 0x0027B49C
		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkPath.vtkPath_GetPointCells_15(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601C586 RID: 116102
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPath_InsertNextPoint_16(HandleRef pThis, IntPtr pts, int code);

		/// <summary>
		/// Insert the next control point in the path.
		/// </summary>
		// Token: 0x0601C587 RID: 116103 RVA: 0x0027D2CC File Offset: 0x0027B4CC
		public void InsertNextPoint(IntPtr pts, int code)
		{
			vtkPath.vtkPath_InsertNextPoint_16(base.GetCppThis(), pts, code);
		}

		// Token: 0x0601C588 RID: 116104
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPath_InsertNextPoint_17(HandleRef pThis, double x, double y, double z, int code);

		/// <summary>
		/// Insert the next control point in the path.
		/// </summary>
		// Token: 0x0601C589 RID: 116105 RVA: 0x0027D2DD File Offset: 0x0027B4DD
		public void InsertNextPoint(double x, double y, double z, int code)
		{
			vtkPath.vtkPath_InsertNextPoint_17(base.GetCppThis(), x, y, z, code);
		}

		// Token: 0x0601C58A RID: 116106
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPath_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C58B RID: 116107 RVA: 0x0027D2F4 File Offset: 0x0027B4F4
		public override int IsA(string type)
		{
			return vtkPath.vtkPath_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0601C58C RID: 116108
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPath_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C58D RID: 116109 RVA: 0x0027D314 File Offset: 0x0027B514
		public new static int IsTypeOf(string type)
		{
			return vtkPath.vtkPath_IsTypeOf_19(type);
		}

		// Token: 0x0601C58E RID: 116110
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPath_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C58F RID: 116111 RVA: 0x0027D330 File Offset: 0x0027B530
		public new vtkPath NewInstance()
		{
			vtkPath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPath.vtkPath_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C590 RID: 116112
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPath_Reset_22(HandleRef pThis);

		/// <summary>
		/// Begin inserting data all over again. Memory is not freed but otherwise
		/// objects are returned to their initial state.
		/// </summary>
		// Token: 0x0601C591 RID: 116113 RVA: 0x0027D38A File Offset: 0x0027B58A
		public void Reset()
		{
			vtkPath.vtkPath_Reset_22(base.GetCppThis());
		}

		// Token: 0x0601C592 RID: 116114
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPath_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C593 RID: 116115 RVA: 0x0027D39C File Offset: 0x0027B59C
		public new static vtkPath SafeDownCast(vtkObjectBase o)
		{
			vtkPath vtkPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPath.vtkPath_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPath = (vtkPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPath.Register(null);
				}
			}
			return vtkPath;
		}

		// Token: 0x0601C594 RID: 116116
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPath_SetCodes_24(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the array of control point codes:
		/// </summary>
		// Token: 0x0601C595 RID: 116117 RVA: 0x0027D41C File Offset: 0x0027B61C
		public void SetCodes(vtkIntArray arg0)
		{
			vtkPath.vtkPath_SetCodes_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E1A RID: 7706
		public new const string MRFullTypeName = "Kitware.VTK.vtkPath";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E1B RID: 7707
		public new static readonly string MRClassNameKey = "class vtkPath";

		/// <summary>
		/// Enumeration of recognized control point types:
		/// - MOVE_TO: Point defining the origin of a new segment, not connected to
		/// the previous point.
		/// - LINE_TO: Draw a line from the previous point to the current one
		/// - CONIC_CURVE: 2nd order (conic/quadratic) point. Must appear
		/// in sets of 2, e.g. (0,0) MOVE_TO (0,1) CONIC_CURVE (1,2) CONIC_CURVE
		/// defines a quadratic Bezier curve that passes through (0,0) and (1,2)
		/// using (0,1) as a control (off) point.
		/// - CUBIC_CURVE: 3rd order (cubic) control point. Must appear in sets of
		/// 3, e.g. (0,0) MOVE_TO (0,1) CUBIC_CURVE (1,2) CUBIC_CURVE (4,0)
		/// CUBIC_CURVE defines a cubic Bezier curve that passes through (0,0)
		/// and (4,0), using (0,1) and (1,2) as control (off) points.
		/// </summary>
		// Token: 0x02000A90 RID: 2704
		public enum ControlPointType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001E1D RID: 7709
			CONIC_CURVE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001E1E RID: 7710
			CUBIC_CURVE,
			/// <summary>enum member</summary>
			// Token: 0x04001E1F RID: 7711
			LINE_TO = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001E20 RID: 7712
			MOVE_TO = 0
		}
	}
}
