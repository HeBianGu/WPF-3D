using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTableToPolyData
	/// </summary>
	/// <remarks>
	///    filter used to convert a vtkTable to a vtkPolyData
	/// consisting of vertices.
	///
	/// vtkTableToPolyData is a filter used to convert a vtkTable  to a vtkPolyData
	/// consisting of vertices.
	/// </remarks>
	// Token: 0x020008ED RID: 2285
	public class vtkTableToPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601795D RID: 96605 RVA: 0x00211553 File Offset: 0x0020F753
		static vtkTableToPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601795E RID: 96606 RVA: 0x0021157B File Offset: 0x0020F77B
		public vtkTableToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601795F RID: 96607
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017960 RID: 96608 RVA: 0x0021158C File Offset: 0x0020F78C
		public new static vtkTableToPolyData New()
		{
			vtkTableToPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToPolyData.vtkTableToPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017961 RID: 96609 RVA: 0x002115E0 File Offset: 0x0020F7E0
		public vtkTableToPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTableToPolyData.vtkTableToPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017962 RID: 96610 RVA: 0x00211624 File Offset: 0x0020F824
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017963 RID: 96611
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_Create2DPointsOff_01(HandleRef pThis);

		/// <summary>
		/// Specify whether the points of the polydata are 3D or 2D. If this is set to
		/// true then the Z Column will be ignored and the z value of each point on the
		/// polydata will be set to 0. By default this will be off.
		/// </summary>
		// Token: 0x06017964 RID: 96612 RVA: 0x0021162F File Offset: 0x0020F82F
		public virtual void Create2DPointsOff()
		{
			vtkTableToPolyData.vtkTableToPolyData_Create2DPointsOff_01(base.GetCppThis());
		}

		// Token: 0x06017965 RID: 96613
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_Create2DPointsOn_02(HandleRef pThis);

		/// <summary>
		/// Specify whether the points of the polydata are 3D or 2D. If this is set to
		/// true then the Z Column will be ignored and the z value of each point on the
		/// polydata will be set to 0. By default this will be off.
		/// </summary>
		// Token: 0x06017966 RID: 96614 RVA: 0x0021163E File Offset: 0x0020F83E
		public virtual void Create2DPointsOn()
		{
			vtkTableToPolyData.vtkTableToPolyData_Create2DPointsOn_02(base.GetCppThis());
		}

		// Token: 0x06017967 RID: 96615
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTableToPolyData_GetCreate2DPoints_03(HandleRef pThis);

		/// <summary>
		/// Specify whether the points of the polydata are 3D or 2D. If this is set to
		/// true then the Z Column will be ignored and the z value of each point on the
		/// polydata will be set to 0. By default this will be off.
		/// </summary>
		// Token: 0x06017968 RID: 96616 RVA: 0x00211650 File Offset: 0x0020F850
		public virtual bool GetCreate2DPoints()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetCreate2DPoints_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06017969 RID: 96617
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToPolyData_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601796A RID: 96618 RVA: 0x00211678 File Offset: 0x0020F878
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601796B RID: 96619
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToPolyData_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601796C RID: 96620 RVA: 0x00211698 File Offset: 0x0020F898
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601796D RID: 96621
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTableToPolyData_GetPreserveCoordinateColumnsAsDataArrays_06(HandleRef pThis);

		/// <summary>
		/// Allow user to keep columns specified as X,Y,Z as Data arrays.
		/// By default this will be off.
		/// </summary>
		// Token: 0x0601796E RID: 96622 RVA: 0x002116B4 File Offset: 0x0020F8B4
		public virtual bool GetPreserveCoordinateColumnsAsDataArrays()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetPreserveCoordinateColumnsAsDataArrays_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0601796F RID: 96623
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToPolyData_GetXColumn_07(HandleRef pThis);

		/// <summary>
		/// Set the name of the column to use as the X coordinate for the points.
		/// </summary>
		// Token: 0x06017970 RID: 96624 RVA: 0x002116DC File Offset: 0x0020F8DC
		public virtual string GetXColumn()
		{
			string s = Marshal.PtrToStringAnsi(vtkTableToPolyData.vtkTableToPolyData_GetXColumn_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017971 RID: 96625
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetXColumnIndex_08(HandleRef pThis);

		/// <summary>
		/// Set the index of the column to use as the X coordinate for the points.
		/// </summary>
		// Token: 0x06017972 RID: 96626 RVA: 0x00211718 File Offset: 0x0020F918
		public virtual int GetXColumnIndex()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetXColumnIndex_08(base.GetCppThis());
		}

		// Token: 0x06017973 RID: 96627
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetXColumnIndexMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set the index of the column to use as the X coordinate for the points.
		/// </summary>
		// Token: 0x06017974 RID: 96628 RVA: 0x00211738 File Offset: 0x0020F938
		public virtual int GetXColumnIndexMaxValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetXColumnIndexMaxValue_09(base.GetCppThis());
		}

		// Token: 0x06017975 RID: 96629
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetXColumnIndexMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set the index of the column to use as the X coordinate for the points.
		/// </summary>
		// Token: 0x06017976 RID: 96630 RVA: 0x00211758 File Offset: 0x0020F958
		public virtual int GetXColumnIndexMinValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetXColumnIndexMinValue_10(base.GetCppThis());
		}

		// Token: 0x06017977 RID: 96631
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetXComponent_11(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetXColumn() to
		/// use as the xcoordinate in case the column is a multi-component array.
		/// Default is 0.
		/// </summary>
		// Token: 0x06017978 RID: 96632 RVA: 0x00211778 File Offset: 0x0020F978
		public virtual int GetXComponent()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetXComponent_11(base.GetCppThis());
		}

		// Token: 0x06017979 RID: 96633
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetXComponentMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetXColumn() to
		/// use as the xcoordinate in case the column is a multi-component array.
		/// Default is 0.
		/// </summary>
		// Token: 0x0601797A RID: 96634 RVA: 0x00211798 File Offset: 0x0020F998
		public virtual int GetXComponentMaxValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetXComponentMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0601797B RID: 96635
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetXComponentMinValue_13(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetXColumn() to
		/// use as the xcoordinate in case the column is a multi-component array.
		/// Default is 0.
		/// </summary>
		// Token: 0x0601797C RID: 96636 RVA: 0x002117B8 File Offset: 0x0020F9B8
		public virtual int GetXComponentMinValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetXComponentMinValue_13(base.GetCppThis());
		}

		// Token: 0x0601797D RID: 96637
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToPolyData_GetYColumn_14(HandleRef pThis);

		/// <summary>
		/// Set the name of the column to use as the Y coordinate for the points.
		/// Default is 0.
		/// </summary>
		// Token: 0x0601797E RID: 96638 RVA: 0x002117D8 File Offset: 0x0020F9D8
		public virtual string GetYColumn()
		{
			string s = Marshal.PtrToStringAnsi(vtkTableToPolyData.vtkTableToPolyData_GetYColumn_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601797F RID: 96639
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetYColumnIndex_15(HandleRef pThis);

		/// <summary>
		/// Set the index of the column to use as the Y coordinate for the points.
		/// </summary>
		// Token: 0x06017980 RID: 96640 RVA: 0x00211814 File Offset: 0x0020FA14
		public virtual int GetYColumnIndex()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetYColumnIndex_15(base.GetCppThis());
		}

		// Token: 0x06017981 RID: 96641
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetYColumnIndexMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set the index of the column to use as the Y coordinate for the points.
		/// </summary>
		// Token: 0x06017982 RID: 96642 RVA: 0x00211834 File Offset: 0x0020FA34
		public virtual int GetYColumnIndexMaxValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetYColumnIndexMaxValue_16(base.GetCppThis());
		}

		// Token: 0x06017983 RID: 96643
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetYColumnIndexMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set the index of the column to use as the Y coordinate for the points.
		/// </summary>
		// Token: 0x06017984 RID: 96644 RVA: 0x00211854 File Offset: 0x0020FA54
		public virtual int GetYColumnIndexMinValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetYColumnIndexMinValue_17(base.GetCppThis());
		}

		// Token: 0x06017985 RID: 96645
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetYComponent_18(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetYColumn() to
		/// use as the Ycoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x06017986 RID: 96646 RVA: 0x00211874 File Offset: 0x0020FA74
		public virtual int GetYComponent()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetYComponent_18(base.GetCppThis());
		}

		// Token: 0x06017987 RID: 96647
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetYComponentMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetYColumn() to
		/// use as the Ycoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x06017988 RID: 96648 RVA: 0x00211894 File Offset: 0x0020FA94
		public virtual int GetYComponentMaxValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetYComponentMaxValue_19(base.GetCppThis());
		}

		// Token: 0x06017989 RID: 96649
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetYComponentMinValue_20(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetYColumn() to
		/// use as the Ycoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x0601798A RID: 96650 RVA: 0x002118B4 File Offset: 0x0020FAB4
		public virtual int GetYComponentMinValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetYComponentMinValue_20(base.GetCppThis());
		}

		// Token: 0x0601798B RID: 96651
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToPolyData_GetZColumn_21(HandleRef pThis);

		/// <summary>
		/// Set the name of the column to use as the Z coordinate for the points.
		/// Default is 0.
		/// </summary>
		// Token: 0x0601798C RID: 96652 RVA: 0x002118D4 File Offset: 0x0020FAD4
		public virtual string GetZColumn()
		{
			string s = Marshal.PtrToStringAnsi(vtkTableToPolyData.vtkTableToPolyData_GetZColumn_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601798D RID: 96653
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetZColumnIndex_22(HandleRef pThis);

		/// <summary>
		/// Set the index of the column to use as the Z coordinate for the points.
		/// </summary>
		// Token: 0x0601798E RID: 96654 RVA: 0x00211910 File Offset: 0x0020FB10
		public virtual int GetZColumnIndex()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetZColumnIndex_22(base.GetCppThis());
		}

		// Token: 0x0601798F RID: 96655
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetZColumnIndexMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Set the index of the column to use as the Z coordinate for the points.
		/// </summary>
		// Token: 0x06017990 RID: 96656 RVA: 0x00211930 File Offset: 0x0020FB30
		public virtual int GetZColumnIndexMaxValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetZColumnIndexMaxValue_23(base.GetCppThis());
		}

		// Token: 0x06017991 RID: 96657
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetZColumnIndexMinValue_24(HandleRef pThis);

		/// <summary>
		/// Set the index of the column to use as the Z coordinate for the points.
		/// </summary>
		// Token: 0x06017992 RID: 96658 RVA: 0x00211950 File Offset: 0x0020FB50
		public virtual int GetZColumnIndexMinValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetZColumnIndexMinValue_24(base.GetCppThis());
		}

		// Token: 0x06017993 RID: 96659
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetZComponent_25(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetZColumn() to
		/// use as the Zcoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x06017994 RID: 96660 RVA: 0x00211970 File Offset: 0x0020FB70
		public virtual int GetZComponent()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetZComponent_25(base.GetCppThis());
		}

		// Token: 0x06017995 RID: 96661
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetZComponentMaxValue_26(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetZColumn() to
		/// use as the Zcoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x06017996 RID: 96662 RVA: 0x00211990 File Offset: 0x0020FB90
		public virtual int GetZComponentMaxValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetZComponentMaxValue_26(base.GetCppThis());
		}

		// Token: 0x06017997 RID: 96663
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_GetZComponentMinValue_27(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetZColumn() to
		/// use as the Zcoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x06017998 RID: 96664 RVA: 0x002119B0 File Offset: 0x0020FBB0
		public virtual int GetZComponentMinValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetZComponentMinValue_27(base.GetCppThis());
		}

		// Token: 0x06017999 RID: 96665
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601799A RID: 96666 RVA: 0x002119D0 File Offset: 0x0020FBD0
		public override int IsA(string type)
		{
			return vtkTableToPolyData.vtkTableToPolyData_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x0601799B RID: 96667
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToPolyData_IsTypeOf_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601799C RID: 96668 RVA: 0x002119F0 File Offset: 0x0020FBF0
		public new static int IsTypeOf(string type)
		{
			return vtkTableToPolyData.vtkTableToPolyData_IsTypeOf_29(type);
		}

		// Token: 0x0601799D RID: 96669
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToPolyData_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601799E RID: 96670 RVA: 0x00211A0C File Offset: 0x0020FC0C
		public new vtkTableToPolyData NewInstance()
		{
			vtkTableToPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToPolyData.vtkTableToPolyData_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601799F RID: 96671
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_PreserveCoordinateColumnsAsDataArraysOff_32(HandleRef pThis);

		/// <summary>
		/// Allow user to keep columns specified as X,Y,Z as Data arrays.
		/// By default this will be off.
		/// </summary>
		// Token: 0x060179A0 RID: 96672 RVA: 0x00211A66 File Offset: 0x0020FC66
		public virtual void PreserveCoordinateColumnsAsDataArraysOff()
		{
			vtkTableToPolyData.vtkTableToPolyData_PreserveCoordinateColumnsAsDataArraysOff_32(base.GetCppThis());
		}

		// Token: 0x060179A1 RID: 96673
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_PreserveCoordinateColumnsAsDataArraysOn_33(HandleRef pThis);

		/// <summary>
		/// Allow user to keep columns specified as X,Y,Z as Data arrays.
		/// By default this will be off.
		/// </summary>
		// Token: 0x060179A2 RID: 96674 RVA: 0x00211A75 File Offset: 0x0020FC75
		public virtual void PreserveCoordinateColumnsAsDataArraysOn()
		{
			vtkTableToPolyData.vtkTableToPolyData_PreserveCoordinateColumnsAsDataArraysOn_33(base.GetCppThis());
		}

		// Token: 0x060179A3 RID: 96675
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToPolyData_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060179A4 RID: 96676 RVA: 0x00211A84 File Offset: 0x0020FC84
		public new static vtkTableToPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkTableToPolyData vtkTableToPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToPolyData.vtkTableToPolyData_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToPolyData = (vtkTableToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToPolyData.Register(null);
				}
			}
			return vtkTableToPolyData;
		}

		// Token: 0x060179A5 RID: 96677
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_SetCreate2DPoints_35(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether the points of the polydata are 3D or 2D. If this is set to
		/// true then the Z Column will be ignored and the z value of each point on the
		/// polydata will be set to 0. By default this will be off.
		/// </summary>
		// Token: 0x060179A6 RID: 96678 RVA: 0x00211B03 File Offset: 0x0020FD03
		public virtual void SetCreate2DPoints(bool _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetCreate2DPoints_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060179A7 RID: 96679
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_SetPreserveCoordinateColumnsAsDataArrays_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Allow user to keep columns specified as X,Y,Z as Data arrays.
		/// By default this will be off.
		/// </summary>
		// Token: 0x060179A8 RID: 96680 RVA: 0x00211B1B File Offset: 0x0020FD1B
		public virtual void SetPreserveCoordinateColumnsAsDataArrays(bool _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetPreserveCoordinateColumnsAsDataArrays_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060179A9 RID: 96681
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_SetXColumn_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the column to use as the X coordinate for the points.
		/// </summary>
		// Token: 0x060179AA RID: 96682 RVA: 0x00211B33 File Offset: 0x0020FD33
		public virtual void SetXColumn(string _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetXColumn_37(base.GetCppThis(), _arg);
		}

		// Token: 0x060179AB RID: 96683
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_SetXColumnIndex_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the index of the column to use as the X coordinate for the points.
		/// </summary>
		// Token: 0x060179AC RID: 96684 RVA: 0x00211B43 File Offset: 0x0020FD43
		public virtual void SetXColumnIndex(int _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetXColumnIndex_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060179AD RID: 96685
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_SetXComponent_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the component for the column specified using SetXColumn() to
		/// use as the xcoordinate in case the column is a multi-component array.
		/// Default is 0.
		/// </summary>
		// Token: 0x060179AE RID: 96686 RVA: 0x00211B53 File Offset: 0x0020FD53
		public virtual void SetXComponent(int _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetXComponent_39(base.GetCppThis(), _arg);
		}

		// Token: 0x060179AF RID: 96687
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_SetYColumn_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the column to use as the Y coordinate for the points.
		/// Default is 0.
		/// </summary>
		// Token: 0x060179B0 RID: 96688 RVA: 0x00211B63 File Offset: 0x0020FD63
		public virtual void SetYColumn(string _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetYColumn_40(base.GetCppThis(), _arg);
		}

		// Token: 0x060179B1 RID: 96689
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_SetYColumnIndex_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the index of the column to use as the Y coordinate for the points.
		/// </summary>
		// Token: 0x060179B2 RID: 96690 RVA: 0x00211B73 File Offset: 0x0020FD73
		public virtual void SetYColumnIndex(int _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetYColumnIndex_41(base.GetCppThis(), _arg);
		}

		// Token: 0x060179B3 RID: 96691
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_SetYComponent_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the component for the column specified using SetYColumn() to
		/// use as the Ycoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x060179B4 RID: 96692 RVA: 0x00211B83 File Offset: 0x0020FD83
		public virtual void SetYComponent(int _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetYComponent_42(base.GetCppThis(), _arg);
		}

		// Token: 0x060179B5 RID: 96693
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_SetZColumn_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the column to use as the Z coordinate for the points.
		/// Default is 0.
		/// </summary>
		// Token: 0x060179B6 RID: 96694 RVA: 0x00211B93 File Offset: 0x0020FD93
		public virtual void SetZColumn(string _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetZColumn_43(base.GetCppThis(), _arg);
		}

		// Token: 0x060179B7 RID: 96695
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_SetZColumnIndex_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the index of the column to use as the Z coordinate for the points.
		/// </summary>
		// Token: 0x060179B8 RID: 96696 RVA: 0x00211BA3 File Offset: 0x0020FDA3
		public virtual void SetZColumnIndex(int _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetZColumnIndex_44(base.GetCppThis(), _arg);
		}

		// Token: 0x060179B9 RID: 96697
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToPolyData_SetZComponent_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the component for the column specified using SetZColumn() to
		/// use as the Zcoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x060179BA RID: 96698 RVA: 0x00211BB3 File Offset: 0x0020FDB3
		public virtual void SetZComponent(int _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetZComponent_45(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A59 RID: 6745
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A5A RID: 6746
		public new static readonly string MRClassNameKey = "class vtkTableToPolyData";
	}
}
