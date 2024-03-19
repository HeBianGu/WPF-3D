using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractTransform
	/// </summary>
	/// <remarks>
	///    superclass for all geometric transformations
	///
	/// vtkAbstractTransform is the superclass for all VTK geometric
	/// transformations.  The VTK transform hierarchy is split into two
	/// major branches: warp transformations and homogeneous (including linear)
	/// transformations.  The latter can be represented in terms of a 4x4
	/// transformation matrix, the former cannot.
	/// &lt;p&gt;Transformations can be pipelined through two mechanisms:
	/// &lt;p&gt;1) GetInverse() returns the pipelined
	/// inverse of a transformation i.e. if you modify the original transform,
	/// any transform previously returned by the GetInverse() method will
	/// automatically update itself according to the change.
	/// &lt;p&gt;2) You can do pipelined concatenation of transformations through
	/// the vtkGeneralTransform class, the vtkPerspectiveTransform class,
	/// or the vtkTransform class.
	/// </remarks>
	/// <seealso>
	///
	/// vtkGeneralTransform vtkWarpTransform vtkHomogeneousTransform
	/// vtkLinearTransform vtkIdentityTransform
	/// vtkTransformPolyDataFilter vtkTransformFilter vtkImageReslice
	/// vtkImplicitFunction
	/// </seealso>
	// Token: 0x02000276 RID: 630
	public abstract class vtkAbstractTransform : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060072A9 RID: 29353 RVA: 0x000A58D4 File Offset: 0x000A3AD4
		static vtkAbstractTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060072AA RID: 29354 RVA: 0x000A58FC File Offset: 0x000A3AFC
		public vtkAbstractTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060072AB RID: 29355
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractTransform_UnRegister_31(HandleRef pThis, HandleRef O);

		/// <summary>
		/// Needs a special UnRegister() implementation to avoid
		/// circular references.
		/// </summary>
		// Token: 0x060072AC RID: 29356 RVA: 0x000A590C File Offset: 0x000A3B0C
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkAbstractTransform.vtkAbstractTransform_UnRegister_31(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060072AD RID: 29357
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractTransform_CircuitCheck_01(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Check for self-reference.  Will return true if concatenating
		/// with the specified transform, setting it to be our inverse,
		/// or setting it to be our input will create a circular reference.
		/// CircuitCheck is automatically called by SetInput(), SetInverse(),
		/// and Concatenate(vtkXTransform *).  Avoid using this function,
		/// it is experimental.
		/// </summary>
		// Token: 0x060072AE RID: 29358 RVA: 0x000A5968 File Offset: 0x000A3B68
		public virtual int CircuitCheck(vtkAbstractTransform transform)
		{
			return vtkAbstractTransform.vtkAbstractTransform_CircuitCheck_01(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x060072AF RID: 29359
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractTransform_DeepCopy_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Copy this transform from another of the same type.
		/// </summary>
		// Token: 0x060072B0 RID: 29360 RVA: 0x000A599C File Offset: 0x000A3B9C
		public void DeepCopy(vtkAbstractTransform arg0)
		{
			vtkAbstractTransform.vtkAbstractTransform_DeepCopy_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060072B1 RID: 29361
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_GetInverse_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the inverse of this transform.  If you modify this transform,
		/// the returned inverse transform will automatically update.  If you
		/// want the inverse of a vtkTransform, you might want to use
		/// GetLinearInverse() instead which will type cast the result from
		/// vtkAbstractTransform to vtkLinearTransform.
		/// </summary>
		// Token: 0x060072B2 RID: 29362 RVA: 0x000A59CC File Offset: 0x000A3BCC
		public vtkAbstractTransform GetInverse()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_GetInverse_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x060072B3 RID: 29363
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAbstractTransform_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Override GetMTime necessary because of inverse transforms.
		/// </summary>
		// Token: 0x060072B4 RID: 29364 RVA: 0x000A5A3C File Offset: 0x000A3C3C
		public override ulong GetMTime()
		{
			return vtkAbstractTransform.vtkAbstractTransform_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x060072B5 RID: 29365
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractTransform_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060072B6 RID: 29366 RVA: 0x000A5A5C File Offset: 0x000A3C5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractTransform.vtkAbstractTransform_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060072B7 RID: 29367
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractTransform_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060072B8 RID: 29368 RVA: 0x000A5A7C File Offset: 0x000A3C7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractTransform.vtkAbstractTransform_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060072B9 RID: 29369
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractTransform_InternalTransformPoint_07(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// This will calculate the transformation without calling Update.
		/// Meant for use only within other VTK classes.
		/// </summary>
		// Token: 0x060072BA RID: 29370 RVA: 0x000A5A96 File Offset: 0x000A3C96
		public virtual void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkAbstractTransform.vtkAbstractTransform_InternalTransformPoint_07(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x060072BB RID: 29371
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractTransform_Inverse_08(HandleRef pThis);

		/// <summary>
		/// Invert the transformation.
		/// </summary>
		// Token: 0x060072BC RID: 29372 RVA: 0x000A5AA7 File Offset: 0x000A3CA7
		public virtual void Inverse()
		{
			vtkAbstractTransform.vtkAbstractTransform_Inverse_08(base.GetCppThis());
		}

		// Token: 0x060072BD RID: 29373
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractTransform_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060072BE RID: 29374 RVA: 0x000A5AB8 File Offset: 0x000A3CB8
		public override int IsA(string type)
		{
			return vtkAbstractTransform.vtkAbstractTransform_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060072BF RID: 29375
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractTransform_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060072C0 RID: 29376 RVA: 0x000A5AD8 File Offset: 0x000A3CD8
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractTransform.vtkAbstractTransform_IsTypeOf_10(type);
		}

		// Token: 0x060072C1 RID: 29377
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_MakeTransform_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make another transform of the same type.
		/// </summary>
		// Token: 0x060072C2 RID: 29378 RVA: 0x000A5AF4 File Offset: 0x000A3CF4
		public virtual vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_MakeTransform_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060072C3 RID: 29379
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060072C4 RID: 29380 RVA: 0x000A5B50 File Offset: 0x000A3D50
		public new vtkAbstractTransform NewInstance()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060072C5 RID: 29381
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060072C6 RID: 29382 RVA: 0x000A5BAC File Offset: 0x000A3DAC
		public new static vtkAbstractTransform SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x060072C7 RID: 29383
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractTransform_SetInverse_14(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Set a transformation that this transform will be the inverse of.
		/// This transform will automatically update to agree with the
		/// inverse transform that you set.
		/// </summary>
		// Token: 0x060072C8 RID: 29384 RVA: 0x000A5C2C File Offset: 0x000A3E2C
		public void SetInverse(vtkAbstractTransform transform)
		{
			vtkAbstractTransform.vtkAbstractTransform_SetInverse_14(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x060072C9 RID: 29385
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_TransformDoubleNormalAtPoint_15(HandleRef pThis, IntPtr point, IntPtr normal);

		/// <summary>
		/// Apply the transformation to a double-precision normal at the specified
		/// vertex.  If the transformation is a vtkLinearTransform, you can use
		/// TransformDoubleNormal() instead.
		/// </summary>
		// Token: 0x060072CA RID: 29386 RVA: 0x000A5C5C File Offset: 0x000A3E5C
		public double[] TransformDoubleNormalAtPoint(IntPtr point, IntPtr normal)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformDoubleNormalAtPoint_15(base.GetCppThis(), point, normal);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060072CB RID: 29387
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_TransformDoublePoint_16(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Apply the transformation to a double-precision (x,y,z) coordinate.
		/// Use this if you are programming in Python or Java.
		/// </summary>
		// Token: 0x060072CC RID: 29388 RVA: 0x000A5CA8 File Offset: 0x000A3EA8
		public double[] TransformDoublePoint(double x, double y, double z)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformDoublePoint_16(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060072CD RID: 29389
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_TransformDoublePoint_17(HandleRef pThis, IntPtr point);

		/// <summary>
		/// Apply the transformation to a double-precision (x,y,z) coordinate.
		/// Use this if you are programming in Python or Java.
		/// </summary>
		// Token: 0x060072CE RID: 29390 RVA: 0x000A5CF4 File Offset: 0x000A3EF4
		public double[] TransformDoublePoint(IntPtr point)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformDoublePoint_17(base.GetCppThis(), point);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060072CF RID: 29391
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_TransformDoubleVectorAtPoint_18(HandleRef pThis, IntPtr point, IntPtr vector);

		/// <summary>
		/// Apply the transformation to a double-precision vector at the specified
		/// vertex.  If the transformation is a vtkLinearTransform, you can use
		/// TransformDoubleVector() instead.
		/// </summary>
		// Token: 0x060072D0 RID: 29392 RVA: 0x000A5D40 File Offset: 0x000A3F40
		public double[] TransformDoubleVectorAtPoint(IntPtr point, IntPtr vector)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformDoubleVectorAtPoint_18(base.GetCppThis(), point, vector);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060072D1 RID: 29393
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_TransformFloatNormalAtPoint_19(HandleRef pThis, IntPtr point, IntPtr normal);

		/// <summary>
		/// Apply the transformation to a single-precision normal at the specified
		/// vertex.  If the transformation is a vtkLinearTransform, you can use
		/// TransformFloatNormal() instead.
		/// </summary>
		// Token: 0x060072D2 RID: 29394 RVA: 0x000A5D8C File Offset: 0x000A3F8C
		public float[] TransformFloatNormalAtPoint(IntPtr point, IntPtr normal)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformFloatNormalAtPoint_19(base.GetCppThis(), point, normal);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060072D3 RID: 29395
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_TransformFloatPoint_20(HandleRef pThis, float x, float y, float z);

		/// <summary>
		/// Apply the transformation to an (x,y,z) coordinate.
		/// Use this if you are programming in Python or Java.
		/// </summary>
		// Token: 0x060072D4 RID: 29396 RVA: 0x000A5DD8 File Offset: 0x000A3FD8
		public float[] TransformFloatPoint(float x, float y, float z)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformFloatPoint_20(base.GetCppThis(), x, y, z);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060072D5 RID: 29397
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_TransformFloatPoint_21(HandleRef pThis, IntPtr point);

		/// <summary>
		/// Apply the transformation to an (x,y,z) coordinate.
		/// Use this if you are programming in Python or Java.
		/// </summary>
		// Token: 0x060072D6 RID: 29398 RVA: 0x000A5E24 File Offset: 0x000A4024
		public float[] TransformFloatPoint(IntPtr point)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformFloatPoint_21(base.GetCppThis(), point);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060072D7 RID: 29399
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_TransformFloatVectorAtPoint_22(HandleRef pThis, IntPtr point, IntPtr vector);

		/// <summary>
		/// Apply the transformation to a single-precision vector at the specified
		/// vertex.  If the transformation is a vtkLinearTransform, you can use
		/// TransformFloatVector() instead.
		/// </summary>
		// Token: 0x060072D8 RID: 29400 RVA: 0x000A5E70 File Offset: 0x000A4070
		public float[] TransformFloatVectorAtPoint(IntPtr point, IntPtr vector)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformFloatVectorAtPoint_22(base.GetCppThis(), point, vector);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060072D9 RID: 29401
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractTransform_TransformNormalAtPoint_23(HandleRef pThis, IntPtr point, IntPtr arg1, IntPtr arg2);

		/// <summary>
		/// Apply the transformation to a normal at the specified vertex.  If the
		/// transformation is a vtkLinearTransform, you can use TransformNormal()
		/// instead.
		/// </summary>
		// Token: 0x060072DA RID: 29402 RVA: 0x000A5EBA File Offset: 0x000A40BA
		public void TransformNormalAtPoint(IntPtr point, IntPtr arg1, IntPtr arg2)
		{
			vtkAbstractTransform.vtkAbstractTransform_TransformNormalAtPoint_23(base.GetCppThis(), point, arg1, arg2);
		}

		// Token: 0x060072DB RID: 29403
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_TransformNormalAtPoint_24(HandleRef pThis, IntPtr point, IntPtr normal);

		/// <summary>
		/// Apply the transformation to a normal at the specified vertex.  If the
		/// transformation is a vtkLinearTransform, you can use TransformNormal()
		/// instead.
		/// </summary>
		// Token: 0x060072DC RID: 29404 RVA: 0x000A5ECC File Offset: 0x000A40CC
		public double[] TransformNormalAtPoint(IntPtr point, IntPtr normal)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformNormalAtPoint_24(base.GetCppThis(), point, normal);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060072DD RID: 29405
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractTransform_TransformPoint_25(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Apply the transformation to a coordinate.  You can use the same
		/// array to store both the input and output point.
		/// </summary>
		// Token: 0x060072DE RID: 29406 RVA: 0x000A5F16 File Offset: 0x000A4116
		public void TransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkAbstractTransform.vtkAbstractTransform_TransformPoint_25(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x060072DF RID: 29407
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_TransformPoint_26(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Apply the transformation to a double-precision coordinate.
		/// Use this if you are programming in Python or Java.
		/// </summary>
		// Token: 0x060072E0 RID: 29408 RVA: 0x000A5F28 File Offset: 0x000A4128
		public double[] TransformPoint(double x, double y, double z)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformPoint_26(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060072E1 RID: 29409
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_TransformPoint_27(HandleRef pThis, IntPtr point);

		/// <summary>
		/// Apply the transformation to a double-precision coordinate.
		/// Use this if you are programming in Python or Java.
		/// </summary>
		// Token: 0x060072E2 RID: 29410 RVA: 0x000A5F74 File Offset: 0x000A4174
		public double[] TransformPoint(IntPtr point)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformPoint_27(base.GetCppThis(), point);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060072E3 RID: 29411
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractTransform_TransformPoints_28(HandleRef pThis, HandleRef inPts, HandleRef outPts);

		/// <summary>
		/// Apply the transformation to a series of points, and append the
		/// results to outPts.
		/// </summary>
		// Token: 0x060072E4 RID: 29412 RVA: 0x000A5FC0 File Offset: 0x000A41C0
		public virtual void TransformPoints(vtkPoints inPts, vtkPoints outPts)
		{
			vtkAbstractTransform.vtkAbstractTransform_TransformPoints_28(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis());
		}

		// Token: 0x060072E5 RID: 29413
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractTransform_TransformVectorAtPoint_29(HandleRef pThis, IntPtr point, IntPtr arg1, IntPtr arg2);

		/// <summary>
		/// Apply the transformation to a vector at the specified vertex.  If the
		/// transformation is a vtkLinearTransform, you can use TransformVector()
		/// instead.
		/// </summary>
		// Token: 0x060072E6 RID: 29414 RVA: 0x000A6004 File Offset: 0x000A4204
		public void TransformVectorAtPoint(IntPtr point, IntPtr arg1, IntPtr arg2)
		{
			vtkAbstractTransform.vtkAbstractTransform_TransformVectorAtPoint_29(base.GetCppThis(), point, arg1, arg2);
		}

		// Token: 0x060072E7 RID: 29415
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractTransform_TransformVectorAtPoint_30(HandleRef pThis, IntPtr point, IntPtr vector);

		/// <summary>
		/// Apply the transformation to a vector at the specified vertex.  If the
		/// transformation is a vtkLinearTransform, you can use TransformVector()
		/// instead.
		/// </summary>
		// Token: 0x060072E8 RID: 29416 RVA: 0x000A6018 File Offset: 0x000A4218
		public double[] TransformVectorAtPoint(IntPtr point, IntPtr vector)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformVectorAtPoint_30(base.GetCppThis(), point, vector);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060072E9 RID: 29417
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractTransform_Update_32(HandleRef pThis);

		/// <summary>
		/// Update the transform to account for any changes which
		/// have been made.  You do not have to call this method
		/// yourself, it is called automatically whenever the
		/// transform needs an update.
		/// </summary>
		// Token: 0x060072EA RID: 29418 RVA: 0x000A6062 File Offset: 0x000A4262
		public void Update()
		{
			vtkAbstractTransform.vtkAbstractTransform_Update_32(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009FA RID: 2554
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009FB RID: 2555
		public new static readonly string MRClassNameKey = "class vtkAbstractTransform";
	}
}
