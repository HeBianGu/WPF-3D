using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRotationFilter
	/// </summary>
	/// <remarks>
	///    Duplicates a data set by rotation about an axis
	///
	/// The vtkRotationFilter duplicates a data set by rotation about one of the
	/// 3 axis of the dataset's reference.
	/// Since it converts data sets into unstructured grids, it is not efficient
	/// for structured data sets.
	///
	/// @par Thanks:
	/// Theophane Foggia of The Swiss National Supercomputing Centre (CSCS)
	/// for creating and contributing this filter
	/// </remarks>
	// Token: 0x020008D9 RID: 2265
	public class vtkRotationFilter : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060176B1 RID: 95921 RVA: 0x0020DB77 File Offset: 0x0020BD77
		static vtkRotationFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRotationFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRotationFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060176B2 RID: 95922 RVA: 0x0020DB9F File Offset: 0x0020BD9F
		public vtkRotationFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060176B3 RID: 95923
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRotationFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060176B4 RID: 95924 RVA: 0x0020DBB0 File Offset: 0x0020BDB0
		public new static vtkRotationFilter New()
		{
			vtkRotationFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRotationFilter.vtkRotationFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRotationFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060176B5 RID: 95925 RVA: 0x0020DC04 File Offset: 0x0020BE04
		public vtkRotationFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRotationFilter.vtkRotationFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060176B6 RID: 95926 RVA: 0x0020DC48 File Offset: 0x0020BE48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060176B7 RID: 95927
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_CopyInputOff_01(HandleRef pThis);

		/// <summary>
		/// If on (the default), copy the input geometry to the output. If off,
		/// the output will only contain the rotation.
		/// </summary>
		// Token: 0x060176B8 RID: 95928 RVA: 0x0020DC53 File Offset: 0x0020BE53
		public virtual void CopyInputOff()
		{
			vtkRotationFilter.vtkRotationFilter_CopyInputOff_01(base.GetCppThis());
		}

		// Token: 0x060176B9 RID: 95929
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_CopyInputOn_02(HandleRef pThis);

		/// <summary>
		/// If on (the default), copy the input geometry to the output. If off,
		/// the output will only contain the rotation.
		/// </summary>
		// Token: 0x060176BA RID: 95930 RVA: 0x0020DC62 File Offset: 0x0020BE62
		public virtual void CopyInputOn()
		{
			vtkRotationFilter.vtkRotationFilter_CopyInputOn_02(base.GetCppThis());
		}

		// Token: 0x060176BB RID: 95931
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRotationFilter_GetAngle_03(HandleRef pThis);

		/// <summary>
		/// Set the rotation angle to use.
		/// </summary>
		// Token: 0x060176BC RID: 95932 RVA: 0x0020DC74 File Offset: 0x0020BE74
		public virtual double GetAngle()
		{
			return vtkRotationFilter.vtkRotationFilter_GetAngle_03(base.GetCppThis());
		}

		// Token: 0x060176BD RID: 95933
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationFilter_GetAxis_04(HandleRef pThis);

		/// <summary>
		/// Set the axis of rotation to use. It is set by default to Z.
		/// </summary>
		// Token: 0x060176BE RID: 95934 RVA: 0x0020DC94 File Offset: 0x0020BE94
		public virtual int GetAxis()
		{
			return vtkRotationFilter.vtkRotationFilter_GetAxis_04(base.GetCppThis());
		}

		// Token: 0x060176BF RID: 95935
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationFilter_GetAxisMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set the axis of rotation to use. It is set by default to Z.
		/// </summary>
		// Token: 0x060176C0 RID: 95936 RVA: 0x0020DCB4 File Offset: 0x0020BEB4
		public virtual int GetAxisMaxValue()
		{
			return vtkRotationFilter.vtkRotationFilter_GetAxisMaxValue_05(base.GetCppThis());
		}

		// Token: 0x060176C1 RID: 95937
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationFilter_GetAxisMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set the axis of rotation to use. It is set by default to Z.
		/// </summary>
		// Token: 0x060176C2 RID: 95938 RVA: 0x0020DCD4 File Offset: 0x0020BED4
		public virtual int GetAxisMinValue()
		{
			return vtkRotationFilter.vtkRotationFilter_GetAxisMinValue_06(base.GetCppThis());
		}

		// Token: 0x060176C3 RID: 95939
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRotationFilter_GetCenter_07(HandleRef pThis);

		/// <summary>
		/// Set the rotation center coordinates.
		/// </summary>
		// Token: 0x060176C4 RID: 95940 RVA: 0x0020DCF4 File Offset: 0x0020BEF4
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkRotationFilter.vtkRotationFilter_GetCenter_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060176C5 RID: 95941
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_GetCenter_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the rotation center coordinates.
		/// </summary>
		// Token: 0x060176C6 RID: 95942 RVA: 0x0020DD3C File Offset: 0x0020BF3C
		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkRotationFilter.vtkRotationFilter_GetCenter_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060176C7 RID: 95943
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_GetCenter_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the rotation center coordinates.
		/// </summary>
		// Token: 0x060176C8 RID: 95944 RVA: 0x0020DD4E File Offset: 0x0020BF4E
		public virtual void GetCenter(IntPtr _arg)
		{
			vtkRotationFilter.vtkRotationFilter_GetCenter_09(base.GetCppThis(), _arg);
		}

		// Token: 0x060176C9 RID: 95945
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationFilter_GetCopyInput_10(HandleRef pThis);

		/// <summary>
		/// If on (the default), copy the input geometry to the output. If off,
		/// the output will only contain the rotation.
		/// </summary>
		// Token: 0x060176CA RID: 95946 RVA: 0x0020DD60 File Offset: 0x0020BF60
		public virtual int GetCopyInput()
		{
			return vtkRotationFilter.vtkRotationFilter_GetCopyInput_10(base.GetCppThis());
		}

		// Token: 0x060176CB RID: 95947
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationFilter_GetNumberOfCopies_11(HandleRef pThis);

		/// <summary>
		/// Set the number of copies to create. The source will be rotated N times
		/// and a new polydata copy of the original created at each angular position
		/// All copies will be appended to form a single output
		/// </summary>
		// Token: 0x060176CC RID: 95948 RVA: 0x0020DD80 File Offset: 0x0020BF80
		public virtual int GetNumberOfCopies()
		{
			return vtkRotationFilter.vtkRotationFilter_GetNumberOfCopies_11(base.GetCppThis());
		}

		// Token: 0x060176CD RID: 95949
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRotationFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060176CE RID: 95950 RVA: 0x0020DDA0 File Offset: 0x0020BFA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRotationFilter.vtkRotationFilter_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x060176CF RID: 95951
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRotationFilter_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060176D0 RID: 95952 RVA: 0x0020DDC0 File Offset: 0x0020BFC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRotationFilter.vtkRotationFilter_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x060176D1 RID: 95953
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationFilter_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060176D2 RID: 95954 RVA: 0x0020DDDC File Offset: 0x0020BFDC
		public override int IsA(string type)
		{
			return vtkRotationFilter.vtkRotationFilter_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x060176D3 RID: 95955
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationFilter_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060176D4 RID: 95956 RVA: 0x0020DDFC File Offset: 0x0020BFFC
		public new static int IsTypeOf(string type)
		{
			return vtkRotationFilter.vtkRotationFilter_IsTypeOf_15(type);
		}

		// Token: 0x060176D5 RID: 95957
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRotationFilter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060176D6 RID: 95958 RVA: 0x0020DE18 File Offset: 0x0020C018
		public new vtkRotationFilter NewInstance()
		{
			vtkRotationFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRotationFilter.vtkRotationFilter_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRotationFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060176D7 RID: 95959
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRotationFilter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060176D8 RID: 95960 RVA: 0x0020DE74 File Offset: 0x0020C074
		public new static vtkRotationFilter SafeDownCast(vtkObjectBase o)
		{
			vtkRotationFilter vtkRotationFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRotationFilter.vtkRotationFilter_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRotationFilter = (vtkRotationFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRotationFilter.Register(null);
				}
			}
			return vtkRotationFilter;
		}

		// Token: 0x060176D9 RID: 95961
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_SetAngle_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the rotation angle to use.
		/// </summary>
		// Token: 0x060176DA RID: 95962 RVA: 0x0020DEF3 File Offset: 0x0020C0F3
		public virtual void SetAngle(double _arg)
		{
			vtkRotationFilter.vtkRotationFilter_SetAngle_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060176DB RID: 95963
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_SetAxis_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the axis of rotation to use. It is set by default to Z.
		/// </summary>
		// Token: 0x060176DC RID: 95964 RVA: 0x0020DF03 File Offset: 0x0020C103
		public virtual void SetAxis(int _arg)
		{
			vtkRotationFilter.vtkRotationFilter_SetAxis_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060176DD RID: 95965
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_SetAxisToX_21(HandleRef pThis);

		/// <summary>
		/// Set the axis of rotation to use. It is set by default to Z.
		/// </summary>
		// Token: 0x060176DE RID: 95966 RVA: 0x0020DF13 File Offset: 0x0020C113
		public void SetAxisToX()
		{
			vtkRotationFilter.vtkRotationFilter_SetAxisToX_21(base.GetCppThis());
		}

		// Token: 0x060176DF RID: 95967
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_SetAxisToY_22(HandleRef pThis);

		/// <summary>
		/// Set the axis of rotation to use. It is set by default to Z.
		/// </summary>
		// Token: 0x060176E0 RID: 95968 RVA: 0x0020DF22 File Offset: 0x0020C122
		public void SetAxisToY()
		{
			vtkRotationFilter.vtkRotationFilter_SetAxisToY_22(base.GetCppThis());
		}

		// Token: 0x060176E1 RID: 95969
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_SetAxisToZ_23(HandleRef pThis);

		/// <summary>
		/// Set the axis of rotation to use. It is set by default to Z.
		/// </summary>
		// Token: 0x060176E2 RID: 95970 RVA: 0x0020DF31 File Offset: 0x0020C131
		public void SetAxisToZ()
		{
			vtkRotationFilter.vtkRotationFilter_SetAxisToZ_23(base.GetCppThis());
		}

		// Token: 0x060176E3 RID: 95971
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_SetCenter_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the rotation center coordinates.
		/// </summary>
		// Token: 0x060176E4 RID: 95972 RVA: 0x0020DF40 File Offset: 0x0020C140
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkRotationFilter.vtkRotationFilter_SetCenter_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060176E5 RID: 95973
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_SetCenter_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the rotation center coordinates.
		/// </summary>
		// Token: 0x060176E6 RID: 95974 RVA: 0x0020DF52 File Offset: 0x0020C152
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkRotationFilter.vtkRotationFilter_SetCenter_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060176E7 RID: 95975
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_SetCopyInput_26(HandleRef pThis, int _arg);

		/// <summary>
		/// If on (the default), copy the input geometry to the output. If off,
		/// the output will only contain the rotation.
		/// </summary>
		// Token: 0x060176E8 RID: 95976 RVA: 0x0020DF62 File Offset: 0x0020C162
		public virtual void SetCopyInput(int _arg)
		{
			vtkRotationFilter.vtkRotationFilter_SetCopyInput_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060176E9 RID: 95977
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationFilter_SetNumberOfCopies_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of copies to create. The source will be rotated N times
		/// and a new polydata copy of the original created at each angular position
		/// All copies will be appended to form a single output
		/// </summary>
		// Token: 0x060176EA RID: 95978 RVA: 0x0020DF72 File Offset: 0x0020C172
		public virtual void SetNumberOfCopies(int _arg)
		{
			vtkRotationFilter.vtkRotationFilter_SetNumberOfCopies_27(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A25 RID: 6693
		public new const string MRFullTypeName = "Kitware.VTK.vtkRotationFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A26 RID: 6694
		public new static readonly string MRClassNameKey = "class vtkRotationFilter";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020008DA RID: 2266
		public enum RotationAxis
		{
			/// <summary>enum member</summary>
			// Token: 0x04001A28 RID: 6696
			USE_X,
			/// <summary>enum member</summary>
			// Token: 0x04001A29 RID: 6697
			USE_Y,
			/// <summary>enum member</summary>
			// Token: 0x04001A2A RID: 6698
			USE_Z
		}
	}
}
