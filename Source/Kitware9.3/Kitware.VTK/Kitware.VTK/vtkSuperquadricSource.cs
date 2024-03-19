using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSuperquadricSource
	/// </summary>
	/// <remarks>
	///    create a polygonal superquadric centered
	/// at the origin
	///
	/// vtkSuperquadricSource creates a superquadric (represented by polygons) of
	/// specified size centered at the origin. The alignment of the axis of the
	/// superquadric along one of the global axes can be specified. The resolution
	/// (polygonal discretization)
	/// in both the latitude (phi) and longitude (theta) directions can be
	/// specified. Roundness parameters (PhiRoundness and ThetaRoundness) control
	/// the shape of the superquadric.  The Toroidal boolean controls whether
	/// a toroidal superquadric is produced.  If so, the Thickness parameter
	/// controls the thickness of the toroid:  0 is the thinnest allowable
	/// toroid, and 1 has a minimum sized hole.  The Scale parameters allow
	/// the superquadric to be scaled in x, y, and z (normal vectors are correctly
	/// generated in any case).  The Size parameter controls size of the
	/// superquadric.
	///
	/// This code is based on "Rigid physically based superquadrics", A. H. Barr,
	/// in "Graphics Gems III", David Kirk, ed., Academic Press, 1992.
	///
	/// @warning
	/// Resolution means the number of latitude or longitude lines for a complete
	/// superquadric. The resolution parameters are rounded to the nearest 4
	/// in phi and 8 in theta.
	///
	/// @warning
	/// Texture coordinates are not equally distributed around all superquadrics.
	///
	/// @warning
	/// The Size and Thickness parameters control coefficients of superquadric
	/// generation, and may do not exactly describe the size of the superquadric.
	///
	/// </remarks>
	// Token: 0x02000844 RID: 2116
	public class vtkSuperquadricSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015EBC RID: 89788 RVA: 0x001EE46F File Offset: 0x001EC66F
		static vtkSuperquadricSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSuperquadricSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSuperquadricSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015EBD RID: 89789 RVA: 0x001EE497 File Offset: 0x001EC697
		public vtkSuperquadricSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015EBE RID: 89790
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSuperquadricSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a default superquadric with a radius of 0.5, non-toroidal,
		/// spherical, and centered at the origin, with a scaling factor of 1 in each
		/// direction, a theta resolution and a phi resolutions of 16.
		/// </summary>
		// Token: 0x06015EBF RID: 89791 RVA: 0x001EE4A8 File Offset: 0x001EC6A8
		public new static vtkSuperquadricSource New()
		{
			vtkSuperquadricSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSuperquadricSource.vtkSuperquadricSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSuperquadricSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a default superquadric with a radius of 0.5, non-toroidal,
		/// spherical, and centered at the origin, with a scaling factor of 1 in each
		/// direction, a theta resolution and a phi resolutions of 16.
		/// </summary>
		// Token: 0x06015EC0 RID: 89792 RVA: 0x001EE4FC File Offset: 0x001EC6FC
		public vtkSuperquadricSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSuperquadricSource.vtkSuperquadricSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015EC1 RID: 89793 RVA: 0x001EE540 File Offset: 0x001EC740
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015EC2 RID: 89794
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSuperquadricSource_GetAxisOfSymmetry_01(HandleRef pThis);

		/// <summary>
		/// Set/Get axis of symmetry for superquadric (x axis: 0, y axis: 1, z axis: 2). Initial value
		/// is 1.
		/// </summary>
		// Token: 0x06015EC3 RID: 89795 RVA: 0x001EE54C File Offset: 0x001EC74C
		public virtual int GetAxisOfSymmetry()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetAxisOfSymmetry_01(base.GetCppThis());
		}

		// Token: 0x06015EC4 RID: 89796
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSuperquadricSource_GetCenter_02(HandleRef pThis);

		/// <summary>
		/// Set the center of the superquadric. Default is 0,0,0.
		/// </summary>
		// Token: 0x06015EC5 RID: 89797 RVA: 0x001EE56C File Offset: 0x001EC76C
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkSuperquadricSource.vtkSuperquadricSource_GetCenter_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015EC6 RID: 89798
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_GetCenter_03(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the center of the superquadric. Default is 0,0,0.
		/// </summary>
		// Token: 0x06015EC7 RID: 89799 RVA: 0x001EE5B4 File Offset: 0x001EC7B4
		public virtual void GetCenter(IntPtr data)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_GetCenter_03(base.GetCppThis(), data);
		}

		// Token: 0x06015EC8 RID: 89800
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSuperquadricSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create a default superquadric with a radius of 0.5, non-toroidal,
		/// spherical, and centered at the origin, with a scaling factor of 1 in each
		/// direction, a theta resolution and a phi resolutions of 16.
		/// </summary>
		// Token: 0x06015EC9 RID: 89801 RVA: 0x001EE5C4 File Offset: 0x001EC7C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06015ECA RID: 89802
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSuperquadricSource_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create a default superquadric with a radius of 0.5, non-toroidal,
		/// spherical, and centered at the origin, with a scaling factor of 1 in each
		/// direction, a theta resolution and a phi resolutions of 16.
		/// </summary>
		// Token: 0x06015ECB RID: 89803 RVA: 0x001EE5E4 File Offset: 0x001EC7E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06015ECC RID: 89804
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSuperquadricSource_GetOutputPointsPrecision_06(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015ECD RID: 89805 RVA: 0x001EE600 File Offset: 0x001EC800
		public virtual int GetOutputPointsPrecision()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetOutputPointsPrecision_06(base.GetCppThis());
		}

		// Token: 0x06015ECE RID: 89806
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSuperquadricSource_GetPhiResolution_07(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the latitude direction. Initial value is 16.
		/// </summary>
		// Token: 0x06015ECF RID: 89807 RVA: 0x001EE620 File Offset: 0x001EC820
		public virtual int GetPhiResolution()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetPhiResolution_07(base.GetCppThis());
		}

		// Token: 0x06015ED0 RID: 89808
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadricSource_GetPhiRoundness_08(HandleRef pThis);

		/// <summary>
		/// Set/Get Superquadric north/south roundness.
		/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x06015ED1 RID: 89809 RVA: 0x001EE640 File Offset: 0x001EC840
		public virtual double GetPhiRoundness()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetPhiRoundness_08(base.GetCppThis());
		}

		// Token: 0x06015ED2 RID: 89810
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSuperquadricSource_GetScale_09(HandleRef pThis);

		/// <summary>
		/// Set the scale factors of the superquadric. Default is 1,1,1.
		/// </summary>
		// Token: 0x06015ED3 RID: 89811 RVA: 0x001EE660 File Offset: 0x001EC860
		public virtual double[] GetScale()
		{
			IntPtr intPtr = vtkSuperquadricSource.vtkSuperquadricSource_GetScale_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015ED4 RID: 89812
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_GetScale_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the scale factors of the superquadric. Default is 1,1,1.
		/// </summary>
		// Token: 0x06015ED5 RID: 89813 RVA: 0x001EE6A8 File Offset: 0x001EC8A8
		public virtual void GetScale(IntPtr data)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_GetScale_10(base.GetCppThis(), data);
		}

		// Token: 0x06015ED6 RID: 89814
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadricSource_GetSize_11(HandleRef pThis);

		/// <summary>
		/// Set/Get Superquadric isotropic size. Initial value is 0.5;
		/// </summary>
		// Token: 0x06015ED7 RID: 89815 RVA: 0x001EE6B8 File Offset: 0x001EC8B8
		public virtual double GetSize()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetSize_11(base.GetCppThis());
		}

		// Token: 0x06015ED8 RID: 89816
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSuperquadricSource_GetThetaResolution_12(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the longitude direction. Initial value is 16.
		/// </summary>
		// Token: 0x06015ED9 RID: 89817 RVA: 0x001EE6D8 File Offset: 0x001EC8D8
		public virtual int GetThetaResolution()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetThetaResolution_12(base.GetCppThis());
		}

		// Token: 0x06015EDA RID: 89818
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadricSource_GetThetaRoundness_13(HandleRef pThis);

		/// <summary>
		/// Set/Get Superquadric east/west roundness.
		/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x06015EDB RID: 89819 RVA: 0x001EE6F8 File Offset: 0x001EC8F8
		public virtual double GetThetaRoundness()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetThetaRoundness_13(base.GetCppThis());
		}

		// Token: 0x06015EDC RID: 89820
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadricSource_GetThickness_14(HandleRef pThis);

		/// <summary>
		/// Set/Get Superquadric ring thickness (toroids only).
		/// Changing thickness maintains the outside diameter of the toroid.
		/// Initial value is 0.3333.
		/// </summary>
		// Token: 0x06015EDD RID: 89821 RVA: 0x001EE718 File Offset: 0x001EC918
		public virtual double GetThickness()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetThickness_14(base.GetCppThis());
		}

		// Token: 0x06015EDE RID: 89822
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadricSource_GetThicknessMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get Superquadric ring thickness (toroids only).
		/// Changing thickness maintains the outside diameter of the toroid.
		/// Initial value is 0.3333.
		/// </summary>
		// Token: 0x06015EDF RID: 89823 RVA: 0x001EE738 File Offset: 0x001EC938
		public virtual double GetThicknessMaxValue()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetThicknessMaxValue_15(base.GetCppThis());
		}

		// Token: 0x06015EE0 RID: 89824
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadricSource_GetThicknessMinValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get Superquadric ring thickness (toroids only).
		/// Changing thickness maintains the outside diameter of the toroid.
		/// Initial value is 0.3333.
		/// </summary>
		// Token: 0x06015EE1 RID: 89825 RVA: 0x001EE758 File Offset: 0x001EC958
		public virtual double GetThicknessMinValue()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetThicknessMinValue_16(base.GetCppThis());
		}

		// Token: 0x06015EE2 RID: 89826
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSuperquadricSource_GetToroidal_17(HandleRef pThis);

		/// <summary>
		/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
		/// Initial value is 0.
		/// </summary>
		// Token: 0x06015EE3 RID: 89827 RVA: 0x001EE778 File Offset: 0x001EC978
		public virtual int GetToroidal()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetToroidal_17(base.GetCppThis());
		}

		// Token: 0x06015EE4 RID: 89828
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSuperquadricSource_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create a default superquadric with a radius of 0.5, non-toroidal,
		/// spherical, and centered at the origin, with a scaling factor of 1 in each
		/// direction, a theta resolution and a phi resolutions of 16.
		/// </summary>
		// Token: 0x06015EE5 RID: 89829 RVA: 0x001EE798 File Offset: 0x001EC998
		public override int IsA(string type)
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06015EE6 RID: 89830
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSuperquadricSource_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create a default superquadric with a radius of 0.5, non-toroidal,
		/// spherical, and centered at the origin, with a scaling factor of 1 in each
		/// direction, a theta resolution and a phi resolutions of 16.
		/// </summary>
		// Token: 0x06015EE7 RID: 89831 RVA: 0x001EE7B8 File Offset: 0x001EC9B8
		public new static int IsTypeOf(string type)
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_IsTypeOf_19(type);
		}

		// Token: 0x06015EE8 RID: 89832
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSuperquadricSource_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a default superquadric with a radius of 0.5, non-toroidal,
		/// spherical, and centered at the origin, with a scaling factor of 1 in each
		/// direction, a theta resolution and a phi resolutions of 16.
		/// </summary>
		// Token: 0x06015EE9 RID: 89833 RVA: 0x001EE7D4 File Offset: 0x001EC9D4
		public new vtkSuperquadricSource NewInstance()
		{
			vtkSuperquadricSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSuperquadricSource.vtkSuperquadricSource_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSuperquadricSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015EEA RID: 89834
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSuperquadricSource_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a default superquadric with a radius of 0.5, non-toroidal,
		/// spherical, and centered at the origin, with a scaling factor of 1 in each
		/// direction, a theta resolution and a phi resolutions of 16.
		/// </summary>
		// Token: 0x06015EEB RID: 89835 RVA: 0x001EE830 File Offset: 0x001ECA30
		public new static vtkSuperquadricSource SafeDownCast(vtkObjectBase o)
		{
			vtkSuperquadricSource vtkSuperquadricSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSuperquadricSource.vtkSuperquadricSource_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSuperquadricSource = (vtkSuperquadricSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSuperquadricSource.Register(null);
				}
			}
			return vtkSuperquadricSource;
		}

		// Token: 0x06015EEC RID: 89836
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetAxisOfSymmetry_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get axis of symmetry for superquadric (x axis: 0, y axis: 1, z axis: 2). Initial value
		/// is 1.
		/// </summary>
		// Token: 0x06015EED RID: 89837 RVA: 0x001EE8AF File Offset: 0x001ECAAF
		public virtual void SetAxisOfSymmetry(int _arg)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetAxisOfSymmetry_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06015EEE RID: 89838
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetCenter_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the center of the superquadric. Default is 0,0,0.
		/// </summary>
		// Token: 0x06015EEF RID: 89839 RVA: 0x001EE8BF File Offset: 0x001ECABF
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetCenter_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015EF0 RID: 89840
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetCenter_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the center of the superquadric. Default is 0,0,0.
		/// </summary>
		// Token: 0x06015EF1 RID: 89841 RVA: 0x001EE8D1 File Offset: 0x001ECAD1
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetCenter_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06015EF2 RID: 89842
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetOutputPointsPrecision_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015EF3 RID: 89843 RVA: 0x001EE8E1 File Offset: 0x001ECAE1
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetOutputPointsPrecision_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06015EF4 RID: 89844
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetPhiResolution_27(HandleRef pThis, int i);

		/// <summary>
		/// Set the number of points in the latitude direction. Initial value is 16.
		/// </summary>
		// Token: 0x06015EF5 RID: 89845 RVA: 0x001EE8F1 File Offset: 0x001ECAF1
		public void SetPhiResolution(int i)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetPhiResolution_27(base.GetCppThis(), i);
		}

		// Token: 0x06015EF6 RID: 89846
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetPhiRoundness_28(HandleRef pThis, double e);

		/// <summary>
		/// Set/Get Superquadric north/south roundness.
		/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x06015EF7 RID: 89847 RVA: 0x001EE901 File Offset: 0x001ECB01
		public void SetPhiRoundness(double e)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetPhiRoundness_28(base.GetCppThis(), e);
		}

		// Token: 0x06015EF8 RID: 89848
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetScale_29(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the scale factors of the superquadric. Default is 1,1,1.
		/// </summary>
		// Token: 0x06015EF9 RID: 89849 RVA: 0x001EE911 File Offset: 0x001ECB11
		public virtual void SetScale(double _arg1, double _arg2, double _arg3)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetScale_29(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015EFA RID: 89850
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetScale_30(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scale factors of the superquadric. Default is 1,1,1.
		/// </summary>
		// Token: 0x06015EFB RID: 89851 RVA: 0x001EE923 File Offset: 0x001ECB23
		public virtual void SetScale(IntPtr _arg)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetScale_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06015EFC RID: 89852
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetSize_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get Superquadric isotropic size. Initial value is 0.5;
		/// </summary>
		// Token: 0x06015EFD RID: 89853 RVA: 0x001EE933 File Offset: 0x001ECB33
		public virtual void SetSize(double _arg)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetSize_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06015EFE RID: 89854
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetThetaResolution_32(HandleRef pThis, int i);

		/// <summary>
		/// Set the number of points in the longitude direction. Initial value is 16.
		/// </summary>
		// Token: 0x06015EFF RID: 89855 RVA: 0x001EE943 File Offset: 0x001ECB43
		public void SetThetaResolution(int i)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetThetaResolution_32(base.GetCppThis(), i);
		}

		// Token: 0x06015F00 RID: 89856
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetThetaRoundness_33(HandleRef pThis, double e);

		/// <summary>
		/// Set/Get Superquadric east/west roundness.
		/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x06015F01 RID: 89857 RVA: 0x001EE953 File Offset: 0x001ECB53
		public void SetThetaRoundness(double e)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetThetaRoundness_33(base.GetCppThis(), e);
		}

		// Token: 0x06015F02 RID: 89858
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetThickness_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get Superquadric ring thickness (toroids only).
		/// Changing thickness maintains the outside diameter of the toroid.
		/// Initial value is 0.3333.
		/// </summary>
		// Token: 0x06015F03 RID: 89859 RVA: 0x001EE963 File Offset: 0x001ECB63
		public virtual void SetThickness(double _arg)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetThickness_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06015F04 RID: 89860
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetToroidal_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
		/// Initial value is 0.
		/// </summary>
		// Token: 0x06015F05 RID: 89861 RVA: 0x001EE973 File Offset: 0x001ECB73
		public virtual void SetToroidal(int _arg)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetToroidal_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06015F06 RID: 89862
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetXAxisOfSymmetry_36(HandleRef pThis);

		/// <summary>
		/// Set/Get axis of symmetry for superquadric (x axis: 0, y axis: 1, z axis: 2). Initial value
		/// is 1.
		/// </summary>
		// Token: 0x06015F07 RID: 89863 RVA: 0x001EE983 File Offset: 0x001ECB83
		public void SetXAxisOfSymmetry()
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetXAxisOfSymmetry_36(base.GetCppThis());
		}

		// Token: 0x06015F08 RID: 89864
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetYAxisOfSymmetry_37(HandleRef pThis);

		/// <summary>
		/// Set/Get axis of symmetry for superquadric (x axis: 0, y axis: 1, z axis: 2). Initial value
		/// is 1.
		/// </summary>
		// Token: 0x06015F09 RID: 89865 RVA: 0x001EE992 File Offset: 0x001ECB92
		public void SetYAxisOfSymmetry()
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetYAxisOfSymmetry_37(base.GetCppThis());
		}

		// Token: 0x06015F0A RID: 89866
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_SetZAxisOfSymmetry_38(HandleRef pThis);

		/// <summary>
		/// Set/Get axis of symmetry for superquadric (x axis: 0, y axis: 1, z axis: 2). Initial value
		/// is 1.
		/// </summary>
		// Token: 0x06015F0B RID: 89867 RVA: 0x001EE9A1 File Offset: 0x001ECBA1
		public void SetZAxisOfSymmetry()
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetZAxisOfSymmetry_38(base.GetCppThis());
		}

		// Token: 0x06015F0C RID: 89868
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_ToroidalOff_39(HandleRef pThis);

		/// <summary>
		/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
		/// Initial value is 0.
		/// </summary>
		// Token: 0x06015F0D RID: 89869 RVA: 0x001EE9B0 File Offset: 0x001ECBB0
		public virtual void ToroidalOff()
		{
			vtkSuperquadricSource.vtkSuperquadricSource_ToroidalOff_39(base.GetCppThis());
		}

		// Token: 0x06015F0E RID: 89870
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadricSource_ToroidalOn_40(HandleRef pThis);

		/// <summary>
		/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
		/// Initial value is 0.
		/// </summary>
		// Token: 0x06015F0F RID: 89871 RVA: 0x001EE9BF File Offset: 0x001ECBBF
		public virtual void ToroidalOn()
		{
			vtkSuperquadricSource.vtkSuperquadricSource_ToroidalOn_40(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018DC RID: 6364
		public new const string MRFullTypeName = "Kitware.VTK.vtkSuperquadricSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018DD RID: 6365
		public new static readonly string MRClassNameKey = "class vtkSuperquadricSource";
	}
}
