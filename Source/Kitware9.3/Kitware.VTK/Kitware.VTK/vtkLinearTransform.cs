using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLinearTransform
	/// </summary>
	/// <remarks>
	///    abstract superclass for linear transformations
	///
	/// vtkLinearTransform provides a generic interface for linear
	/// (affine or 12 degree-of-freedom) geometric transformations.
	///
	/// @warning
	/// Portions of this class (i.e., when transforming arrays of points and/or
	/// associated attributes such as normals and vectors) has been threaded with
	/// vtkSMPTools. Using TBB or other non-sequential type (set in the CMake
	/// variable VTK_SMP_IMPLEMENTATION_TYPE) may improve performance
	/// significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTransform vtkIdentityTransform
	/// </seealso>
	// Token: 0x02000A73 RID: 2675
	public abstract class vtkLinearTransform : vtkHomogeneousTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C031 RID: 114737 RVA: 0x00274138 File Offset: 0x00272338
		static vtkLinearTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinearTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C032 RID: 114738 RVA: 0x00274160 File Offset: 0x00272360
		public vtkLinearTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C033 RID: 114739 RVA: 0x0027416E File Offset: 0x0027236E
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C034 RID: 114740
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_GetLinearInverse_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Just like GetInverse, but it includes a typecast to
		/// vtkLinearTransform.
		/// </summary>
		// Token: 0x0601C035 RID: 114741 RVA: 0x0027417C File Offset: 0x0027237C
		public vtkLinearTransform GetLinearInverse()
		{
			vtkLinearTransform vtkLinearTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_GetLinearInverse_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearTransform = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearTransform.Register(null);
				}
			}
			return vtkLinearTransform;
		}

		// Token: 0x0601C036 RID: 114742
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearTransform_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C037 RID: 114743 RVA: 0x002741EC File Offset: 0x002723EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLinearTransform.vtkLinearTransform_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601C038 RID: 114744
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearTransform_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C039 RID: 114745 RVA: 0x0027420C File Offset: 0x0027240C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLinearTransform.vtkLinearTransform_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601C03A RID: 114746
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransform_InternalTransformNormal_04(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// This will calculate the transformation without calling Update.
		/// Meant for use only within other VTK classes.
		/// </summary>
		// Token: 0x0601C03B RID: 114747 RVA: 0x00274226 File Offset: 0x00272426
		public virtual void InternalTransformNormal(IntPtr arg0, IntPtr arg1)
		{
			vtkLinearTransform.vtkLinearTransform_InternalTransformNormal_04(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601C03C RID: 114748
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransform_InternalTransformPoint_05(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// This will calculate the transformation without calling Update.
		/// Meant for use only within other VTK classes.
		/// </summary>
		// Token: 0x0601C03D RID: 114749 RVA: 0x00274237 File Offset: 0x00272437
		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkLinearTransform.vtkLinearTransform_InternalTransformPoint_05(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601C03E RID: 114750
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransform_InternalTransformVector_06(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// This will calculate the transformation without calling Update.
		/// Meant for use only within other VTK classes.
		/// </summary>
		// Token: 0x0601C03F RID: 114751 RVA: 0x00274248 File Offset: 0x00272448
		public virtual void InternalTransformVector(IntPtr arg0, IntPtr arg1)
		{
			vtkLinearTransform.vtkLinearTransform_InternalTransformVector_06(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601C040 RID: 114752
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearTransform_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C041 RID: 114753 RVA: 0x0027425C File Offset: 0x0027245C
		public override int IsA(string type)
		{
			return vtkLinearTransform.vtkLinearTransform_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601C042 RID: 114754
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearTransform_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C043 RID: 114755 RVA: 0x0027427C File Offset: 0x0027247C
		public new static int IsTypeOf(string type)
		{
			return vtkLinearTransform.vtkLinearTransform_IsTypeOf_08(type);
		}

		// Token: 0x0601C044 RID: 114756
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C045 RID: 114757 RVA: 0x00274298 File Offset: 0x00272498
		public new vtkLinearTransform NewInstance()
		{
			vtkLinearTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C046 RID: 114758
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C047 RID: 114759 RVA: 0x002742F4 File Offset: 0x002724F4
		public new static vtkLinearTransform SafeDownCast(vtkObjectBase o)
		{
			vtkLinearTransform vtkLinearTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearTransform = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearTransform.Register(null);
				}
			}
			return vtkLinearTransform;
		}

		// Token: 0x0601C048 RID: 114760
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_TransformDoubleNormal_11(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Apply the transformation to a double-precision (x,y,z) normal.
		/// Use this if you are programming in python or Java.
		/// </summary>
		// Token: 0x0601C049 RID: 114761 RVA: 0x00274374 File Offset: 0x00272574
		public double[] TransformDoubleNormal(double x, double y, double z)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformDoubleNormal_11(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C04A RID: 114762
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_TransformDoubleNormal_12(HandleRef pThis, IntPtr normal);

		/// <summary>
		/// Apply the transformation to a double-precision (x,y,z) normal.
		/// Use this if you are programming in python or Java.
		/// </summary>
		// Token: 0x0601C04B RID: 114763 RVA: 0x002743C0 File Offset: 0x002725C0
		public double[] TransformDoubleNormal(IntPtr normal)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformDoubleNormal_12(base.GetCppThis(), normal);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C04C RID: 114764
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_TransformDoubleVector_13(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Apply the transformation to a double-precision (x,y,z) vector.
		/// Use this if you are programming in python or Java.
		/// </summary>
		// Token: 0x0601C04D RID: 114765 RVA: 0x0027440C File Offset: 0x0027260C
		public double[] TransformDoubleVector(double x, double y, double z)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformDoubleVector_13(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C04E RID: 114766
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_TransformDoubleVector_14(HandleRef pThis, IntPtr vec);

		/// <summary>
		/// Apply the transformation to a double-precision (x,y,z) vector.
		/// Use this if you are programming in python or Java.
		/// </summary>
		// Token: 0x0601C04F RID: 114767 RVA: 0x00274458 File Offset: 0x00272658
		public double[] TransformDoubleVector(IntPtr vec)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformDoubleVector_14(base.GetCppThis(), vec);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C050 RID: 114768
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_TransformFloatNormal_15(HandleRef pThis, float x, float y, float z);

		/// <summary>
		/// Apply the transformation to an (x,y,z) normal.
		/// Use this if you are programming in python or Java.
		/// </summary>
		// Token: 0x0601C051 RID: 114769 RVA: 0x002744A4 File Offset: 0x002726A4
		public float[] TransformFloatNormal(float x, float y, float z)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformFloatNormal_15(base.GetCppThis(), x, y, z);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C052 RID: 114770
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_TransformFloatNormal_16(HandleRef pThis, IntPtr normal);

		/// <summary>
		/// Apply the transformation to an (x,y,z) normal.
		/// Use this if you are programming in python or Java.
		/// </summary>
		// Token: 0x0601C053 RID: 114771 RVA: 0x002744F0 File Offset: 0x002726F0
		public float[] TransformFloatNormal(IntPtr normal)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformFloatNormal_16(base.GetCppThis(), normal);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C054 RID: 114772
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_TransformFloatVector_17(HandleRef pThis, float x, float y, float z);

		/// <summary>
		/// Apply the transformation to an (x,y,z) vector.
		/// Use this if you are programming in python or Java.
		/// </summary>
		// Token: 0x0601C055 RID: 114773 RVA: 0x0027453C File Offset: 0x0027273C
		public float[] TransformFloatVector(float x, float y, float z)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformFloatVector_17(base.GetCppThis(), x, y, z);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C056 RID: 114774
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_TransformFloatVector_18(HandleRef pThis, IntPtr vec);

		/// <summary>
		/// Apply the transformation to an (x,y,z) vector.
		/// Use this if you are programming in python or Java.
		/// </summary>
		// Token: 0x0601C057 RID: 114775 RVA: 0x00274588 File Offset: 0x00272788
		public float[] TransformFloatVector(IntPtr vec)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformFloatVector_18(base.GetCppThis(), vec);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C058 RID: 114776
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransform_TransformNormal_19(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Apply the transformation to a normal.
		/// You can use the same array to store both the input and output.
		/// </summary>
		// Token: 0x0601C059 RID: 114777 RVA: 0x002745D1 File Offset: 0x002727D1
		public void TransformNormal(IntPtr arg0, IntPtr arg1)
		{
			vtkLinearTransform.vtkLinearTransform_TransformNormal_19(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601C05A RID: 114778
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_TransformNormal_20(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Synonymous with TransformDoubleNormal(x,y,z).
		/// Use this if you are programming in python or Java.
		/// </summary>
		// Token: 0x0601C05B RID: 114779 RVA: 0x002745E4 File Offset: 0x002727E4
		public double[] TransformNormal(double x, double y, double z)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformNormal_20(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C05C RID: 114780
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_TransformNormal_21(HandleRef pThis, IntPtr normal);

		/// <summary>
		/// Synonymous with TransformDoubleNormal(x,y,z).
		/// Use this if you are programming in python or Java.
		/// </summary>
		// Token: 0x0601C05D RID: 114781 RVA: 0x00274630 File Offset: 0x00272830
		public double[] TransformNormal(IntPtr normal)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformNormal_21(base.GetCppThis(), normal);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C05E RID: 114782
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransform_TransformNormals_22(HandleRef pThis, HandleRef inNms, HandleRef outNms);

		/// <summary>
		/// Apply the transformation to a series of normals, and append the
		/// results to outNms.
		/// </summary>
		// Token: 0x0601C05F RID: 114783 RVA: 0x0027467C File Offset: 0x0027287C
		public virtual void TransformNormals(vtkDataArray inNms, vtkDataArray outNms)
		{
			vtkLinearTransform.vtkLinearTransform_TransformNormals_22(base.GetCppThis(), (inNms == null) ? default(HandleRef) : inNms.GetCppThis(), (outNms == null) ? default(HandleRef) : outNms.GetCppThis());
		}

		// Token: 0x0601C060 RID: 114784
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransform_TransformPoints_23(HandleRef pThis, HandleRef inPts, HandleRef outPts);

		/// <summary>
		/// Apply the transformation to a series of points, and append the
		/// results to outPts.
		/// </summary>
		// Token: 0x0601C061 RID: 114785 RVA: 0x002746C0 File Offset: 0x002728C0
		public override void TransformPoints(vtkPoints inPts, vtkPoints outPts)
		{
			vtkLinearTransform.vtkLinearTransform_TransformPoints_23(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis());
		}

		// Token: 0x0601C062 RID: 114786
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_TransformVector_24(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Synonymous with TransformDoubleVector(x,y,z).
		/// Use this if you are programming in python or Java.
		/// </summary>
		// Token: 0x0601C063 RID: 114787 RVA: 0x00274704 File Offset: 0x00272904
		public double[] TransformVector(double x, double y, double z)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformVector_24(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C064 RID: 114788
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransform_TransformVector_25(HandleRef pThis, IntPtr normal);

		/// <summary>
		/// Synonymous with TransformDoubleVector(x,y,z).
		/// Use this if you are programming in python or Java.
		/// </summary>
		// Token: 0x0601C065 RID: 114789 RVA: 0x00274750 File Offset: 0x00272950
		public double[] TransformVector(IntPtr normal)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformVector_25(base.GetCppThis(), normal);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C066 RID: 114790
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransform_TransformVector_26(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Apply the transformation to a vector.
		/// You can use the same array to store both the input and output.
		/// </summary>
		// Token: 0x0601C067 RID: 114791 RVA: 0x00274799 File Offset: 0x00272999
		public void TransformVector(IntPtr arg0, IntPtr arg1)
		{
			vtkLinearTransform.vtkLinearTransform_TransformVector_26(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601C068 RID: 114792
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransform_TransformVectors_27(HandleRef pThis, HandleRef inVrs, HandleRef outVrs);

		/// <summary>
		/// Apply the transformation to a series of vectors, and append the
		/// results to outVrs.
		/// </summary>
		// Token: 0x0601C069 RID: 114793 RVA: 0x002747AC File Offset: 0x002729AC
		public virtual void TransformVectors(vtkDataArray inVrs, vtkDataArray outVrs)
		{
			vtkLinearTransform.vtkLinearTransform_TransformVectors_27(base.GetCppThis(), (inVrs == null) ? default(HandleRef) : inVrs.GetCppThis(), (outVrs == null) ? default(HandleRef) : outVrs.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DDD RID: 7645
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinearTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DDE RID: 7646
		public new static readonly string MRClassNameKey = "class vtkLinearTransform";
	}
}
