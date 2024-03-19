using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuaternionInterpolator
	/// </summary>
	/// <remarks>
	///    interpolate a quaternion
	///
	/// This class is used to interpolate a series of quaternions representing
	/// the rotations of a 3D object.  The interpolation may be linear in form
	/// (using spherical linear interpolation SLERP), or via spline interpolation
	/// (using SQUAD). In either case the interpolation is specialized to
	/// quaternions since the interpolation occurs on the surface of the unit
	/// quaternion sphere.
	///
	/// To use this class, specify at least two pairs of (t,q[4]) with the
	/// AddQuaternion() method.  Next interpolate the tuples with the
	/// InterpolateQuaternion(t,q[4]) method, where "t" must be in the range of
	/// (t_min,t_max) parameter values specified by the AddQuaternion() method (t
	/// is clamped otherwise), and q[4] is filled in by the method.
	///
	/// There are several important background references. Ken Shoemake described
	/// the practical application of quaternions for the interpolation of rotation
	/// (K. Shoemake, "Animating rotation with quaternion curves", Computer
	/// Graphics (Siggraph '85) 19(3):245--254, 1985). Another fine reference
	/// (available on-line) is E. B. Dam, M. Koch, and M. Lillholm, Technical
	/// Report DIKU-TR-98/5, Dept. of Computer Science, University of Copenhagen,
	/// Denmark.
	///
	/// @warning
	/// Note that for two or less quaternions, Slerp (linear) interpolation is
	/// performed even if spline interpolation is requested. Also, the tangents to
	/// the first and last segments of spline interpolation are (arbitrarily)
	/// defined by repeating the first and last quaternions.
	///
	/// @warning
	/// There are several methods particular to quaternions (norms, products,
	/// etc.) implemented interior to this class. These may be moved to a separate
	/// quaternion class at some point.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuaternion
	/// </seealso>
	// Token: 0x02000B1E RID: 2846
	public class vtkQuaternionInterpolator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DDF8 RID: 122360 RVA: 0x002A2CC1 File Offset: 0x002A0EC1
		static vtkQuaternionInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuaternionInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuaternionInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DDF9 RID: 122361 RVA: 0x002A2CE9 File Offset: 0x002A0EE9
		public vtkQuaternionInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DDFA RID: 122362
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuaternionInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0601DDFB RID: 122363 RVA: 0x002A2CF8 File Offset: 0x002A0EF8
		public new static vtkQuaternionInterpolator New()
		{
			vtkQuaternionInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuaternionInterpolator.vtkQuaternionInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuaternionInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0601DDFC RID: 122364 RVA: 0x002A2D4C File Offset: 0x002A0F4C
		public vtkQuaternionInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuaternionInterpolator.vtkQuaternionInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DDFD RID: 122365 RVA: 0x002A2D90 File Offset: 0x002A0F90
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DDFE RID: 122366
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuaternionInterpolator_AddQuaternion_01(HandleRef pThis, double t, IntPtr q);

		/// <summary>
		/// Add another quaternion to the list of quaternions to be interpolated.
		/// Note that using the same time t value more than once replaces the
		/// previous quaternion at t. At least one quaternions must be added to
		/// define an interpolation functions.
		/// </summary>
		// Token: 0x0601DDFF RID: 122367 RVA: 0x002A2D9B File Offset: 0x002A0F9B
		public void AddQuaternion(double t, IntPtr q)
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_AddQuaternion_01(base.GetCppThis(), t, q);
		}

		// Token: 0x0601DE00 RID: 122368
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuaternionInterpolator_GetInterpolationType_02(HandleRef pThis);

		/// <summary>
		/// Specify which type of function to use for interpolation. By default
		/// (SetInterpolationTypeToSpline()), cubic spline interpolation using a
		/// modified Kochanek basis is employed. Otherwise, if
		/// SetInterpolationTypeToLinear() is invoked, linear spherical
		/// interpolation
		/// is used between each pair of quaternions.
		/// </summary>
		// Token: 0x0601DE01 RID: 122369 RVA: 0x002A2DAC File Offset: 0x002A0FAC
		public virtual int GetInterpolationType()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetInterpolationType_02(base.GetCppThis());
		}

		// Token: 0x0601DE02 RID: 122370
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuaternionInterpolator_GetInterpolationTypeMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Specify which type of function to use for interpolation. By default
		/// (SetInterpolationTypeToSpline()), cubic spline interpolation using a
		/// modified Kochanek basis is employed. Otherwise, if
		/// SetInterpolationTypeToLinear() is invoked, linear spherical
		/// interpolation
		/// is used between each pair of quaternions.
		/// </summary>
		// Token: 0x0601DE03 RID: 122371 RVA: 0x002A2DCC File Offset: 0x002A0FCC
		public virtual int GetInterpolationTypeMaxValue()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetInterpolationTypeMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0601DE04 RID: 122372
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuaternionInterpolator_GetInterpolationTypeMinValue_04(HandleRef pThis);

		/// <summary>
		/// Specify which type of function to use for interpolation. By default
		/// (SetInterpolationTypeToSpline()), cubic spline interpolation using a
		/// modified Kochanek basis is employed. Otherwise, if
		/// SetInterpolationTypeToLinear() is invoked, linear spherical
		/// interpolation
		/// is used between each pair of quaternions.
		/// </summary>
		// Token: 0x0601DE05 RID: 122373 RVA: 0x002A2DEC File Offset: 0x002A0FEC
		public virtual int GetInterpolationTypeMinValue()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetInterpolationTypeMinValue_04(base.GetCppThis());
		}

		// Token: 0x0601DE06 RID: 122374
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuaternionInterpolator_GetMaximumT_05(HandleRef pThis);

		/// <summary>
		/// Obtain some information about the interpolation range. The numbers
		/// returned (corresponding to parameter t, usually thought of as time)
		/// are undefined if the list of transforms is empty. This is a convenience
		/// method for interpolation.
		/// </summary>
		// Token: 0x0601DE07 RID: 122375 RVA: 0x002A2E0C File Offset: 0x002A100C
		public double GetMaximumT()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetMaximumT_05(base.GetCppThis());
		}

		// Token: 0x0601DE08 RID: 122376
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuaternionInterpolator_GetMinimumT_06(HandleRef pThis);

		/// <summary>
		/// Obtain some information about the interpolation range. The numbers
		/// returned (corresponding to parameter t, usually thought of as time)
		/// are undefined if the list of transforms is empty. This is a convenience
		/// method for interpolation.
		/// </summary>
		// Token: 0x0601DE09 RID: 122377 RVA: 0x002A2E2C File Offset: 0x002A102C
		public double GetMinimumT()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetMinimumT_06(base.GetCppThis());
		}

		// Token: 0x0601DE0A RID: 122378
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuaternionInterpolator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE0B RID: 122379 RVA: 0x002A2E4C File Offset: 0x002A104C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601DE0C RID: 122380
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuaternionInterpolator_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE0D RID: 122381 RVA: 0x002A2E6C File Offset: 0x002A106C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601DE0E RID: 122382
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuaternionInterpolator_GetNumberOfQuaternions_09(HandleRef pThis);

		/// <summary>
		/// Return the number of quaternions in the list of quaternions to be
		/// interpolated.
		/// </summary>
		// Token: 0x0601DE0F RID: 122383 RVA: 0x002A2E88 File Offset: 0x002A1088
		public int GetNumberOfQuaternions()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetNumberOfQuaternions_09(base.GetCppThis());
		}

		// Token: 0x0601DE10 RID: 122384
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuaternionInterpolator_GetSearchMethod_10(HandleRef pThis);

		/// <summary>
		/// Set / Get the search type method. 0 is a binary search method O(log(N))
		/// 1 is a linear search method O(N). Linear search method is kept because
		/// it can be faster than the dichotomous search method in specific cases
		/// </summary>
		// Token: 0x0601DE11 RID: 122385 RVA: 0x002A2EA8 File Offset: 0x002A10A8
		public int GetSearchMethod()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetSearchMethod_10(base.GetCppThis());
		}

		// Token: 0x0601DE12 RID: 122386
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuaternionInterpolator_Initialize_11(HandleRef pThis);

		/// <summary>
		/// Reset the class so that it contains no data; i.e., the array of (t,q[4])
		/// information is discarded.
		/// </summary>
		// Token: 0x0601DE13 RID: 122387 RVA: 0x002A2EC7 File Offset: 0x002A10C7
		public void Initialize()
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_Initialize_11(base.GetCppThis());
		}

		// Token: 0x0601DE14 RID: 122388
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuaternionInterpolator_InterpolateQuaternion_12(HandleRef pThis, double t, IntPtr q);

		/// <summary>
		/// Interpolate the list of quaternions and determine a new quaternion
		/// (i.e., fill in the quaternion provided). If t is outside the range of
		/// (min,max) values, then t is clamped to lie within the range.
		/// </summary>
		// Token: 0x0601DE15 RID: 122389 RVA: 0x002A2ED6 File Offset: 0x002A10D6
		public void InterpolateQuaternion(double t, IntPtr q)
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_InterpolateQuaternion_12(base.GetCppThis(), t, q);
		}

		// Token: 0x0601DE16 RID: 122390
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuaternionInterpolator_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE17 RID: 122391 RVA: 0x002A2EE8 File Offset: 0x002A10E8
		public override int IsA(string type)
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0601DE18 RID: 122392
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuaternionInterpolator_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE19 RID: 122393 RVA: 0x002A2F08 File Offset: 0x002A1108
		public new static int IsTypeOf(string type)
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_IsTypeOf_14(type);
		}

		// Token: 0x0601DE1A RID: 122394
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuaternionInterpolator_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE1B RID: 122395 RVA: 0x002A2F24 File Offset: 0x002A1124
		public new vtkQuaternionInterpolator NewInstance()
		{
			vtkQuaternionInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuaternionInterpolator.vtkQuaternionInterpolator_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuaternionInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DE1C RID: 122396
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuaternionInterpolator_RemoveQuaternion_17(HandleRef pThis, double t);

		/// <summary>
		/// Delete the quaternion at a particular parameter t. If there is no
		/// quaternion tuple defined at t, then the method does nothing.
		/// </summary>
		// Token: 0x0601DE1D RID: 122397 RVA: 0x002A2F7E File Offset: 0x002A117E
		public void RemoveQuaternion(double t)
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_RemoveQuaternion_17(base.GetCppThis(), t);
		}

		// Token: 0x0601DE1E RID: 122398
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuaternionInterpolator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE1F RID: 122399 RVA: 0x002A2F90 File Offset: 0x002A1190
		public new static vtkQuaternionInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkQuaternionInterpolator vtkQuaternionInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuaternionInterpolator.vtkQuaternionInterpolator_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuaternionInterpolator = (vtkQuaternionInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuaternionInterpolator.Register(null);
				}
			}
			return vtkQuaternionInterpolator;
		}

		// Token: 0x0601DE20 RID: 122400
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuaternionInterpolator_SetInterpolationType_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify which type of function to use for interpolation. By default
		/// (SetInterpolationTypeToSpline()), cubic spline interpolation using a
		/// modified Kochanek basis is employed. Otherwise, if
		/// SetInterpolationTypeToLinear() is invoked, linear spherical
		/// interpolation
		/// is used between each pair of quaternions.
		/// </summary>
		// Token: 0x0601DE21 RID: 122401 RVA: 0x002A300F File Offset: 0x002A120F
		public virtual void SetInterpolationType(int _arg)
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_SetInterpolationType_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DE22 RID: 122402
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuaternionInterpolator_SetInterpolationTypeToLinear_20(HandleRef pThis);

		/// <summary>
		/// Specify which type of function to use for interpolation. By default
		/// (SetInterpolationTypeToSpline()), cubic spline interpolation using a
		/// modified Kochanek basis is employed. Otherwise, if
		/// SetInterpolationTypeToLinear() is invoked, linear spherical
		/// interpolation
		/// is used between each pair of quaternions.
		/// </summary>
		// Token: 0x0601DE23 RID: 122403 RVA: 0x002A301F File Offset: 0x002A121F
		public void SetInterpolationTypeToLinear()
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_SetInterpolationTypeToLinear_20(base.GetCppThis());
		}

		// Token: 0x0601DE24 RID: 122404
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuaternionInterpolator_SetInterpolationTypeToSpline_21(HandleRef pThis);

		/// <summary>
		/// Specify which type of function to use for interpolation. By default
		/// (SetInterpolationTypeToSpline()), cubic spline interpolation using a
		/// modified Kochanek basis is employed. Otherwise, if
		/// SetInterpolationTypeToLinear() is invoked, linear spherical
		/// interpolation
		/// is used between each pair of quaternions.
		/// </summary>
		// Token: 0x0601DE25 RID: 122405 RVA: 0x002A302E File Offset: 0x002A122E
		public void SetInterpolationTypeToSpline()
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_SetInterpolationTypeToSpline_21(base.GetCppThis());
		}

		// Token: 0x0601DE26 RID: 122406
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuaternionInterpolator_SetSearchMethod_22(HandleRef pThis, int type);

		/// <summary>
		/// Set / Get the search type method. 0 is a binary search method O(log(N))
		/// 1 is a linear search method O(N). Linear search method is kept because
		/// it can be faster than the dichotomous search method in specific cases
		/// </summary>
		// Token: 0x0601DE27 RID: 122407 RVA: 0x002A303D File Offset: 0x002A123D
		public void SetSearchMethod(int type)
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_SetSearchMethod_22(base.GetCppThis(), type);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F7D RID: 8061
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuaternionInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F7E RID: 8062
		public new static readonly string MRClassNameKey = "class vtkQuaternionInterpolator";

		/// <summary>
		/// Enums to control the type of interpolation to use.
		/// </summary>
		// Token: 0x02000B1F RID: 2847
		public enum INTERPOLATION_TYPE_LINEAR_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001F80 RID: 8064
			INTERPOLATION_TYPE_LINEAR,
			/// <summary>enum member</summary>
			// Token: 0x04001F81 RID: 8065
			INTERPOLATION_TYPE_SPLINE
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x02000B20 RID: 2848
		public enum vtkQuaternionInterpolationSearchMethod
		{
			/// <summary>enum member</summary>
			// Token: 0x04001F83 RID: 8067
			BinarySearch,
			/// <summary>enum member</summary>
			// Token: 0x04001F84 RID: 8068
			LinearSearch,
			/// <summary>enum member</summary>
			// Token: 0x04001F85 RID: 8069
			MaxEnum
		}
	}
}
