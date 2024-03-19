using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCutMaterial
	/// </summary>
	/// <remarks>
	///    Automatically computes the cut plane for a material array pair.
	///
	/// vtkCutMaterial computes a cut plane based on an up vector, center of the bounding box
	/// and the location of the maximum variable value.
	///  These computed values are available so that they can be used to set the camera
	/// for the best view of the plane.
	/// </remarks>
	// Token: 0x020004FC RID: 1276
	public class vtkCutMaterial : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E59E RID: 58782 RVA: 0x0013FE2B File Offset: 0x0013E02B
		static vtkCutMaterial()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCutMaterial.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCutMaterial"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E59F RID: 58783 RVA: 0x0013FE53 File Offset: 0x0013E053
		public vtkCutMaterial(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E5A0 RID: 58784
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutMaterial_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5A1 RID: 58785 RVA: 0x0013FE64 File Offset: 0x0013E064
		public new static vtkCutMaterial New()
		{
			vtkCutMaterial result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCutMaterial)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5A2 RID: 58786 RVA: 0x0013FEB8 File Offset: 0x0013E0B8
		public vtkCutMaterial() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCutMaterial.vtkCutMaterial_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E5A3 RID: 58787 RVA: 0x0013FEFC File Offset: 0x0013E0FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E5A4 RID: 58788
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutMaterial_GetArrayName_01(HandleRef pThis);

		/// <summary>
		/// For now, we just use the cell values.
		/// The array name to cut.
		/// </summary>
		// Token: 0x0600E5A5 RID: 58789 RVA: 0x0013FF08 File Offset: 0x0013E108
		public virtual string GetArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCutMaterial.vtkCutMaterial_GetArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600E5A6 RID: 58790
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutMaterial_GetCenterPoint_02(HandleRef pThis);

		/// <summary>
		/// Accesses to the values computed during the execute method.  They
		/// could be used to get a good camera view for the resulting plane.
		/// </summary>
		// Token: 0x0600E5A7 RID: 58791 RVA: 0x0013FF44 File Offset: 0x0013E144
		public virtual double[] GetCenterPoint()
		{
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_GetCenterPoint_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E5A8 RID: 58792
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_GetCenterPoint_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Accesses to the values computed during the execute method.  They
		/// could be used to get a good camera view for the resulting plane.
		/// </summary>
		// Token: 0x0600E5A9 RID: 58793 RVA: 0x0013FF8C File Offset: 0x0013E18C
		public virtual void GetCenterPoint(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCutMaterial.vtkCutMaterial_GetCenterPoint_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E5AA RID: 58794
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_GetCenterPoint_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Accesses to the values computed during the execute method.  They
		/// could be used to get a good camera view for the resulting plane.
		/// </summary>
		// Token: 0x0600E5AB RID: 58795 RVA: 0x0013FF9E File Offset: 0x0013E19E
		public virtual void GetCenterPoint(IntPtr _arg)
		{
			vtkCutMaterial.vtkCutMaterial_GetCenterPoint_04(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E5AC RID: 58796
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutMaterial_GetMaterial_05(HandleRef pThis);

		/// <summary>
		/// Material to probe.
		/// </summary>
		// Token: 0x0600E5AD RID: 58797 RVA: 0x0013FFB0 File Offset: 0x0013E1B0
		public virtual int GetMaterial()
		{
			return vtkCutMaterial.vtkCutMaterial_GetMaterial_05(base.GetCppThis());
		}

		// Token: 0x0600E5AE RID: 58798
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutMaterial_GetMaterialArrayName_06(HandleRef pThis);

		/// <summary>
		/// Cell array that contains the material values.
		/// </summary>
		// Token: 0x0600E5AF RID: 58799 RVA: 0x0013FFD0 File Offset: 0x0013E1D0
		public virtual string GetMaterialArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCutMaterial.vtkCutMaterial_GetMaterialArrayName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600E5B0 RID: 58800
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutMaterial_GetMaximumPoint_07(HandleRef pThis);

		/// <summary>
		/// Accesses to the values computed during the execute method.  They
		/// could be used to get a good camera view for the resulting plane.
		/// </summary>
		// Token: 0x0600E5B1 RID: 58801 RVA: 0x0014000C File Offset: 0x0013E20C
		public virtual double[] GetMaximumPoint()
		{
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_GetMaximumPoint_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E5B2 RID: 58802
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_GetMaximumPoint_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Accesses to the values computed during the execute method.  They
		/// could be used to get a good camera view for the resulting plane.
		/// </summary>
		// Token: 0x0600E5B3 RID: 58803 RVA: 0x00140054 File Offset: 0x0013E254
		public virtual void GetMaximumPoint(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCutMaterial.vtkCutMaterial_GetMaximumPoint_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E5B4 RID: 58804
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_GetMaximumPoint_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Accesses to the values computed during the execute method.  They
		/// could be used to get a good camera view for the resulting plane.
		/// </summary>
		// Token: 0x0600E5B5 RID: 58805 RVA: 0x00140066 File Offset: 0x0013E266
		public virtual void GetMaximumPoint(IntPtr _arg)
		{
			vtkCutMaterial.vtkCutMaterial_GetMaximumPoint_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E5B6 RID: 58806
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutMaterial_GetNormal_10(HandleRef pThis);

		/// <summary>
		/// Accesses to the values computed during the execute method.  They
		/// could be used to get a good camera view for the resulting plane.
		/// </summary>
		// Token: 0x0600E5B7 RID: 58807 RVA: 0x00140078 File Offset: 0x0013E278
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_GetNormal_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E5B8 RID: 58808
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_GetNormal_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Accesses to the values computed during the execute method.  They
		/// could be used to get a good camera view for the resulting plane.
		/// </summary>
		// Token: 0x0600E5B9 RID: 58809 RVA: 0x001400C0 File Offset: 0x0013E2C0
		public virtual void GetNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCutMaterial.vtkCutMaterial_GetNormal_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E5BA RID: 58810
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_GetNormal_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Accesses to the values computed during the execute method.  They
		/// could be used to get a good camera view for the resulting plane.
		/// </summary>
		// Token: 0x0600E5BB RID: 58811 RVA: 0x001400D2 File Offset: 0x0013E2D2
		public virtual void GetNormal(IntPtr _arg)
		{
			vtkCutMaterial.vtkCutMaterial_GetNormal_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E5BC RID: 58812
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCutMaterial_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5BD RID: 58813 RVA: 0x001400E4 File Offset: 0x0013E2E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCutMaterial.vtkCutMaterial_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0600E5BE RID: 58814
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCutMaterial_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5BF RID: 58815 RVA: 0x00140104 File Offset: 0x0013E304
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCutMaterial.vtkCutMaterial_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0600E5C0 RID: 58816
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutMaterial_GetUpVector_15(HandleRef pThis);

		/// <summary>
		/// The last piece of information that specifies the plane.
		/// </summary>
		// Token: 0x0600E5C1 RID: 58817 RVA: 0x00140120 File Offset: 0x0013E320
		public virtual double[] GetUpVector()
		{
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_GetUpVector_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E5C2 RID: 58818
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_GetUpVector_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The last piece of information that specifies the plane.
		/// </summary>
		// Token: 0x0600E5C3 RID: 58819 RVA: 0x00140168 File Offset: 0x0013E368
		public virtual void GetUpVector(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCutMaterial.vtkCutMaterial_GetUpVector_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E5C4 RID: 58820
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_GetUpVector_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The last piece of information that specifies the plane.
		/// </summary>
		// Token: 0x0600E5C5 RID: 58821 RVA: 0x0014017A File Offset: 0x0013E37A
		public virtual void GetUpVector(IntPtr _arg)
		{
			vtkCutMaterial.vtkCutMaterial_GetUpVector_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E5C6 RID: 58822
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutMaterial_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5C7 RID: 58823 RVA: 0x0014018C File Offset: 0x0013E38C
		public override int IsA(string type)
		{
			return vtkCutMaterial.vtkCutMaterial_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600E5C8 RID: 58824
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutMaterial_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5C9 RID: 58825 RVA: 0x001401AC File Offset: 0x0013E3AC
		public new static int IsTypeOf(string type)
		{
			return vtkCutMaterial.vtkCutMaterial_IsTypeOf_19(type);
		}

		// Token: 0x0600E5CA RID: 58826
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutMaterial_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5CB RID: 58827 RVA: 0x001401C8 File Offset: 0x0013E3C8
		public new vtkCutMaterial NewInstance()
		{
			vtkCutMaterial result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCutMaterial)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E5CC RID: 58828
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutMaterial_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5CD RID: 58829 RVA: 0x00140224 File Offset: 0x0013E424
		public new static vtkCutMaterial SafeDownCast(vtkObjectBase o)
		{
			vtkCutMaterial vtkCutMaterial = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCutMaterial = (vtkCutMaterial)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCutMaterial.Register(null);
				}
			}
			return vtkCutMaterial;
		}

		// Token: 0x0600E5CE RID: 58830
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_SetArrayName_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// For now, we just use the cell values.
		/// The array name to cut.
		/// </summary>
		// Token: 0x0600E5CF RID: 58831 RVA: 0x001402A3 File Offset: 0x0013E4A3
		public virtual void SetArrayName(string _arg)
		{
			vtkCutMaterial.vtkCutMaterial_SetArrayName_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E5D0 RID: 58832
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_SetMaterial_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Material to probe.
		/// </summary>
		// Token: 0x0600E5D1 RID: 58833 RVA: 0x001402B3 File Offset: 0x0013E4B3
		public virtual void SetMaterial(int _arg)
		{
			vtkCutMaterial.vtkCutMaterial_SetMaterial_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E5D2 RID: 58834
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_SetMaterialArrayName_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Cell array that contains the material values.
		/// </summary>
		// Token: 0x0600E5D3 RID: 58835 RVA: 0x001402C3 File Offset: 0x0013E4C3
		public virtual void SetMaterialArrayName(string _arg)
		{
			vtkCutMaterial.vtkCutMaterial_SetMaterialArrayName_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E5D4 RID: 58836
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_SetUpVector_26(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The last piece of information that specifies the plane.
		/// </summary>
		// Token: 0x0600E5D5 RID: 58837 RVA: 0x001402D3 File Offset: 0x0013E4D3
		public virtual void SetUpVector(double _arg1, double _arg2, double _arg3)
		{
			vtkCutMaterial.vtkCutMaterial_SetUpVector_26(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E5D6 RID: 58838
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutMaterial_SetUpVector_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The last piece of information that specifies the plane.
		/// </summary>
		// Token: 0x0600E5D7 RID: 58839 RVA: 0x001402E5 File Offset: 0x0013E4E5
		public virtual void SetUpVector(IntPtr _arg)
		{
			vtkCutMaterial.vtkCutMaterial_SetUpVector_27(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010DF RID: 4319
		public new const string MRFullTypeName = "Kitware.VTK.vtkCutMaterial";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010E0 RID: 4320
		public new static readonly string MRClassNameKey = "class vtkCutMaterial";
	}
}
