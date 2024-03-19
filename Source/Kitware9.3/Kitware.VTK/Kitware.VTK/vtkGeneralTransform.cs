using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGeneralTransform
	/// </summary>
	/// <remarks>
	///    allows operations on any transforms
	///
	/// vtkGeneralTransform is like vtkTransform and vtkPerspectiveTransform,
	/// but it will work with any vtkAbstractTransform as input.  It is
	/// not as efficient as the other two, however, because arbitrary
	/// transformations cannot be concatenated by matrix multiplication.
	/// Transform concatenation is simulated by passing each input point
	/// through each transform in turn.
	/// </remarks>
	/// <seealso>
	///
	/// vtkTransform vtkPerspectiveTransform
	/// </seealso>
	// Token: 0x02000B07 RID: 2823
	public class vtkGeneralTransform : vtkAbstractTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DA67 RID: 121447 RVA: 0x0029DDFB File Offset: 0x0029BFFB
		static vtkGeneralTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeneralTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeneralTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DA68 RID: 121448 RVA: 0x0029DE23 File Offset: 0x0029C023
		public vtkGeneralTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DA69 RID: 121449
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeneralTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA6A RID: 121450 RVA: 0x0029DE34 File Offset: 0x0029C034
		public new static vtkGeneralTransform New()
		{
			vtkGeneralTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeneralTransform.vtkGeneralTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeneralTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA6B RID: 121451 RVA: 0x0029DE88 File Offset: 0x0029C088
		public vtkGeneralTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGeneralTransform.vtkGeneralTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DA6C RID: 121452 RVA: 0x0029DECC File Offset: 0x0029C0CC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DA6D RID: 121453
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeneralTransform_CircuitCheck_01(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Check for self-reference.  Will return true if concatenating
		/// with the specified transform, setting it to be our inverse,
		/// or setting it to be our input will create a circular reference.
		/// CircuitCheck is automatically called by SetInput(), SetInverse(),
		/// and Concatenate(vtkXTransform *).  Avoid using this function,
		/// it is experimental.
		/// </summary>
		// Token: 0x0601DA6E RID: 121454 RVA: 0x0029DED8 File Offset: 0x0029C0D8
		public override int CircuitCheck(vtkAbstractTransform transform)
		{
			return vtkGeneralTransform.vtkGeneralTransform_CircuitCheck_01(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x0601DA6F RID: 121455
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_Concatenate_02(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Concatenates the matrix with the current transformation according
		/// to PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DA70 RID: 121456 RVA: 0x0029DF0C File Offset: 0x0029C10C
		public void Concatenate(vtkMatrix4x4 matrix)
		{
			vtkGeneralTransform.vtkGeneralTransform_Concatenate_02(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x0601DA71 RID: 121457
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_Concatenate_03(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Concatenates the matrix with the current transformation according
		/// to PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DA72 RID: 121458 RVA: 0x0029DF3B File Offset: 0x0029C13B
		public void Concatenate(IntPtr elements)
		{
			vtkGeneralTransform.vtkGeneralTransform_Concatenate_03(base.GetCppThis(), elements);
		}

		// Token: 0x0601DA73 RID: 121459
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_Concatenate_04(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Concatenate the specified transform with the current transformation
		/// according to PreMultiply or PostMultiply semantics.
		/// The concatenation is pipelined, meaning that if any of the
		/// transformations are changed, even after Concatenate() is called,
		/// those changes will be reflected when you call TransformPoint().
		/// </summary>
		// Token: 0x0601DA74 RID: 121460 RVA: 0x0029DF4C File Offset: 0x0029C14C
		public void Concatenate(vtkAbstractTransform transform)
		{
			vtkGeneralTransform.vtkGeneralTransform_Concatenate_04(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x0601DA75 RID: 121461
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeneralTransform_GetConcatenatedTransform_05(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one of the concatenated transformations as a vtkAbstractTransform.
		/// These transformations are applied, in series, every time the
		/// transformation of a coordinate occurs.  This method is provided
		/// to make it possible to decompose a transformation into its
		/// constituents, for example to save a transformation to a file.
		/// </summary>
		// Token: 0x0601DA76 RID: 121462 RVA: 0x0029DF7C File Offset: 0x0029C17C
		public vtkAbstractTransform GetConcatenatedTransform(int i)
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeneralTransform.vtkGeneralTransform_GetConcatenatedTransform_05(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DA77 RID: 121463
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeneralTransform_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the input for this transformation.  This will be used as the
		/// base transformation if it is set.  This method allows you to build
		/// a transform pipeline: if the input is modified, then this transformation
		/// will automatically update accordingly.  Note that the InverseFlag,
		/// controlled via Inverse(), determines whether this transformation
		/// will use the Input or the inverse of the Input.
		/// </summary>
		// Token: 0x0601DA78 RID: 121464 RVA: 0x0029DFEC File Offset: 0x0029C1EC
		public vtkAbstractTransform GetInput()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeneralTransform.vtkGeneralTransform_GetInput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DA79 RID: 121465
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeneralTransform_GetInverseFlag_07(HandleRef pThis);

		/// <summary>
		/// Get the inverse flag of the transformation.  This controls
		/// whether it is the Input or the inverse of the Input that
		/// is used as the base transformation.  The InverseFlag is
		/// flipped every time Inverse() is called.  The InverseFlag
		/// is off when a transform is first created.
		/// </summary>
		// Token: 0x0601DA7A RID: 121466 RVA: 0x0029E05C File Offset: 0x0029C25C
		public int GetInverseFlag()
		{
			return vtkGeneralTransform.vtkGeneralTransform_GetInverseFlag_07(base.GetCppThis());
		}

		// Token: 0x0601DA7B RID: 121467
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGeneralTransform_GetMTime_08(HandleRef pThis);

		/// <summary>
		/// Override GetMTime to account for input and concatenation.
		/// </summary>
		// Token: 0x0601DA7C RID: 121468 RVA: 0x0029E07C File Offset: 0x0029C27C
		public override ulong GetMTime()
		{
			return vtkGeneralTransform.vtkGeneralTransform_GetMTime_08(base.GetCppThis());
		}

		// Token: 0x0601DA7D RID: 121469
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeneralTransform_GetNumberOfConcatenatedTransforms_09(HandleRef pThis);

		/// <summary>
		/// Get the total number of transformations that are linked into this
		/// one via Concatenate() operations or via SetInput().
		/// </summary>
		// Token: 0x0601DA7E RID: 121470 RVA: 0x0029E09C File Offset: 0x0029C29C
		public int GetNumberOfConcatenatedTransforms()
		{
			return vtkGeneralTransform.vtkGeneralTransform_GetNumberOfConcatenatedTransforms_09(base.GetCppThis());
		}

		// Token: 0x0601DA7F RID: 121471
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeneralTransform_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA80 RID: 121472 RVA: 0x0029E0BC File Offset: 0x0029C2BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGeneralTransform.vtkGeneralTransform_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601DA81 RID: 121473
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeneralTransform_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA82 RID: 121474 RVA: 0x0029E0DC File Offset: 0x0029C2DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGeneralTransform.vtkGeneralTransform_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601DA83 RID: 121475
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_Identity_12(HandleRef pThis);

		/// <summary>
		/// Set this transformation to the identity transformation.  If
		/// the transform has an Input, then the transformation will be
		/// reset so that it is the same as the Input.
		/// </summary>
		// Token: 0x0601DA84 RID: 121476 RVA: 0x0029E0F6 File Offset: 0x0029C2F6
		public void Identity()
		{
			vtkGeneralTransform.vtkGeneralTransform_Identity_12(base.GetCppThis());
		}

		// Token: 0x0601DA85 RID: 121477
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_InternalTransformPoint_13(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// This will calculate the transformation without calling Update.
		/// Meant for use only within other VTK classes.
		/// </summary>
		// Token: 0x0601DA86 RID: 121478 RVA: 0x0029E105 File Offset: 0x0029C305
		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkGeneralTransform.vtkGeneralTransform_InternalTransformPoint_13(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601DA87 RID: 121479
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_Inverse_14(HandleRef pThis);

		/// <summary>
		/// Invert the transformation.  This will also set a flag so that
		/// the transformation will use the inverse of its Input, if an Input
		/// has been set.
		/// </summary>
		// Token: 0x0601DA88 RID: 121480 RVA: 0x0029E116 File Offset: 0x0029C316
		public override void Inverse()
		{
			vtkGeneralTransform.vtkGeneralTransform_Inverse_14(base.GetCppThis());
		}

		// Token: 0x0601DA89 RID: 121481
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeneralTransform_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA8A RID: 121482 RVA: 0x0029E128 File Offset: 0x0029C328
		public override int IsA(string type)
		{
			return vtkGeneralTransform.vtkGeneralTransform_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0601DA8B RID: 121483
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeneralTransform_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA8C RID: 121484 RVA: 0x0029E148 File Offset: 0x0029C348
		public new static int IsTypeOf(string type)
		{
			return vtkGeneralTransform.vtkGeneralTransform_IsTypeOf_16(type);
		}

		// Token: 0x0601DA8D RID: 121485
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeneralTransform_MakeTransform_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make another transform of the same type.
		/// </summary>
		// Token: 0x0601DA8E RID: 121486 RVA: 0x0029E164 File Offset: 0x0029C364
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeneralTransform.vtkGeneralTransform_MakeTransform_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DA8F RID: 121487
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeneralTransform_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA90 RID: 121488 RVA: 0x0029E1C0 File Offset: 0x0029C3C0
		public new vtkGeneralTransform NewInstance()
		{
			vtkGeneralTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeneralTransform.vtkGeneralTransform_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeneralTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DA91 RID: 121489
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_Pop_20(HandleRef pThis);

		/// <summary>
		/// Deletes the transformation on the top of the stack and sets the top
		/// to the next transformation on the stack.
		/// </summary>
		// Token: 0x0601DA92 RID: 121490 RVA: 0x0029E21A File Offset: 0x0029C41A
		public void Pop()
		{
			vtkGeneralTransform.vtkGeneralTransform_Pop_20(base.GetCppThis());
		}

		// Token: 0x0601DA93 RID: 121491
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_PostMultiply_21(HandleRef pThis);

		/// <summary>
		/// Sets the internal state of the transform to PostMultiply. All subsequent
		/// operations will occur after those already represented in the
		/// current transformation.  In homogeneous matrix notation, M = A*M where
		/// M is the current transformation matrix and A is the applied matrix.
		/// The default is PreMultiply.
		/// </summary>
		// Token: 0x0601DA94 RID: 121492 RVA: 0x0029E229 File Offset: 0x0029C429
		public void PostMultiply()
		{
			vtkGeneralTransform.vtkGeneralTransform_PostMultiply_21(base.GetCppThis());
		}

		// Token: 0x0601DA95 RID: 121493
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_PreMultiply_22(HandleRef pThis);

		/// <summary>
		/// Sets the internal state of the transform to PreMultiply. All subsequent
		/// operations will occur before those already represented in the
		/// current transformation.  In homogeneous matrix notation, M = M*A where
		/// M is the current transformation matrix and A is the applied matrix.
		/// The default is PreMultiply.
		/// </summary>
		// Token: 0x0601DA96 RID: 121494 RVA: 0x0029E238 File Offset: 0x0029C438
		public void PreMultiply()
		{
			vtkGeneralTransform.vtkGeneralTransform_PreMultiply_22(base.GetCppThis());
		}

		// Token: 0x0601DA97 RID: 121495
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_Push_23(HandleRef pThis);

		/// <summary>
		/// Pushes the current transformation onto the transformation stack.
		/// </summary>
		// Token: 0x0601DA98 RID: 121496 RVA: 0x0029E247 File Offset: 0x0029C447
		public void Push()
		{
			vtkGeneralTransform.vtkGeneralTransform_Push_23(base.GetCppThis());
		}

		// Token: 0x0601DA99 RID: 121497
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_RotateWXYZ_24(HandleRef pThis, double angle, double x, double y, double z);

		/// <summary>
		/// Create a rotation matrix and concatenate it with the current
		/// transformation according to PreMultiply or PostMultiply semantics.
		/// The angle is in degrees, and (x,y,z) specifies the axis that the
		/// rotation will be performed around.
		/// </summary>
		// Token: 0x0601DA9A RID: 121498 RVA: 0x0029E256 File Offset: 0x0029C456
		public void RotateWXYZ(double angle, double x, double y, double z)
		{
			vtkGeneralTransform.vtkGeneralTransform_RotateWXYZ_24(base.GetCppThis(), angle, x, y, z);
		}

		// Token: 0x0601DA9B RID: 121499
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_RotateWXYZ_25(HandleRef pThis, double angle, IntPtr axis);

		/// <summary>
		/// Create a rotation matrix and concatenate it with the current
		/// transformation according to PreMultiply or PostMultiply semantics.
		/// The angle is in degrees, and (x,y,z) specifies the axis that the
		/// rotation will be performed around.
		/// </summary>
		// Token: 0x0601DA9C RID: 121500 RVA: 0x0029E26A File Offset: 0x0029C46A
		public void RotateWXYZ(double angle, IntPtr axis)
		{
			vtkGeneralTransform.vtkGeneralTransform_RotateWXYZ_25(base.GetCppThis(), angle, axis);
		}

		// Token: 0x0601DA9D RID: 121501
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_RotateX_26(HandleRef pThis, double angle);

		/// <summary>
		/// Create a rotation matrix about the X, Y, or Z axis and concatenate
		/// it with the current transformation according to PreMultiply or
		/// PostMultiply semantics.  The angle is expressed in degrees.
		/// </summary>
		// Token: 0x0601DA9E RID: 121502 RVA: 0x0029E27B File Offset: 0x0029C47B
		public void RotateX(double angle)
		{
			vtkGeneralTransform.vtkGeneralTransform_RotateX_26(base.GetCppThis(), angle);
		}

		// Token: 0x0601DA9F RID: 121503
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_RotateY_27(HandleRef pThis, double angle);

		/// <summary>
		/// Create a rotation matrix about the X, Y, or Z axis and concatenate
		/// it with the current transformation according to PreMultiply or
		/// PostMultiply semantics.  The angle is expressed in degrees.
		/// </summary>
		// Token: 0x0601DAA0 RID: 121504 RVA: 0x0029E28B File Offset: 0x0029C48B
		public void RotateY(double angle)
		{
			vtkGeneralTransform.vtkGeneralTransform_RotateY_27(base.GetCppThis(), angle);
		}

		// Token: 0x0601DAA1 RID: 121505
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_RotateZ_28(HandleRef pThis, double angle);

		/// <summary>
		/// Create a rotation matrix about the X, Y, or Z axis and concatenate
		/// it with the current transformation according to PreMultiply or
		/// PostMultiply semantics.  The angle is expressed in degrees.
		/// </summary>
		// Token: 0x0601DAA2 RID: 121506 RVA: 0x0029E29B File Offset: 0x0029C49B
		public void RotateZ(double angle)
		{
			vtkGeneralTransform.vtkGeneralTransform_RotateZ_28(base.GetCppThis(), angle);
		}

		// Token: 0x0601DAA3 RID: 121507
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeneralTransform_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAA4 RID: 121508 RVA: 0x0029E2AC File Offset: 0x0029C4AC
		public new static vtkGeneralTransform SafeDownCast(vtkObjectBase o)
		{
			vtkGeneralTransform vtkGeneralTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeneralTransform.vtkGeneralTransform_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeneralTransform = (vtkGeneralTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeneralTransform.Register(null);
				}
			}
			return vtkGeneralTransform;
		}

		// Token: 0x0601DAA5 RID: 121509
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_Scale_30(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Create a scale matrix (i.e. set the diagonal elements to x, y, z)
		/// and concatenate it with the current transformation according to
		/// PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DAA6 RID: 121510 RVA: 0x0029E32B File Offset: 0x0029C52B
		public void Scale(double x, double y, double z)
		{
			vtkGeneralTransform.vtkGeneralTransform_Scale_30(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601DAA7 RID: 121511
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_Scale_31(HandleRef pThis, IntPtr s);

		/// <summary>
		/// Create a scale matrix (i.e. set the diagonal elements to x, y, z)
		/// and concatenate it with the current transformation according to
		/// PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DAA8 RID: 121512 RVA: 0x0029E33D File Offset: 0x0029C53D
		public void Scale(IntPtr s)
		{
			vtkGeneralTransform.vtkGeneralTransform_Scale_31(base.GetCppThis(), s);
		}

		// Token: 0x0601DAA9 RID: 121513
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_SetInput_32(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the input for this transformation.  This will be used as the
		/// base transformation if it is set.  This method allows you to build
		/// a transform pipeline: if the input is modified, then this transformation
		/// will automatically update accordingly.  Note that the InverseFlag,
		/// controlled via Inverse(), determines whether this transformation
		/// will use the Input or the inverse of the Input.
		/// </summary>
		// Token: 0x0601DAAA RID: 121514 RVA: 0x0029E350 File Offset: 0x0029C550
		public void SetInput(vtkAbstractTransform input)
		{
			vtkGeneralTransform.vtkGeneralTransform_SetInput_32(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601DAAB RID: 121515
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_Translate_33(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Create a translation matrix and concatenate it with the current
		/// transformation according to PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DAAC RID: 121516 RVA: 0x0029E37F File Offset: 0x0029C57F
		public void Translate(double x, double y, double z)
		{
			vtkGeneralTransform.vtkGeneralTransform_Translate_33(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601DAAD RID: 121517
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralTransform_Translate_34(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Create a translation matrix and concatenate it with the current
		/// transformation according to PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DAAE RID: 121518 RVA: 0x0029E391 File Offset: 0x0029C591
		public void Translate(IntPtr x)
		{
			vtkGeneralTransform.vtkGeneralTransform_Translate_34(base.GetCppThis(), x);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F3F RID: 7999
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeneralTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F40 RID: 8000
		public new static readonly string MRClassNameKey = "class vtkGeneralTransform";
	}
}
