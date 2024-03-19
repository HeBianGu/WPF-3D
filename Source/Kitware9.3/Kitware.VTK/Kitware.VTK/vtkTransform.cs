using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransform
	/// </summary>
	/// <remarks>
	///    describes linear transformations via a 4x4 matrix
	///
	/// A vtkTransform can be used to describe the full range of linear (also
	/// known as affine) coordinate transformations in three dimensions,
	/// which are internally represented as a 4x4 homogeneous transformation
	/// matrix.  When you create a new vtkTransform, it is always initialized
	/// to the identity transformation.
	/// &lt;P&gt;The SetInput() method allows you to set another transform,
	/// instead of the identity transform, to be the base transformation.
	/// There is a pipeline mechanism to ensure that when the input is
	/// modified, the current transformation will be updated accordingly.
	/// This pipeline mechanism is also supported by the Concatenate() method.
	/// &lt;P&gt;Most of the methods for manipulating this transformation,
	/// e.g. Translate, Rotate, and Concatenate, can operate in either
	/// PreMultiply (the default) or PostMultiply mode.  In PreMultiply
	/// mode, the translation, concatenation, etc. will occur before any
	/// transformations which are represented by the current matrix.  In
	/// PostMultiply mode, the additional transformation will occur after
	/// any transformations represented by the current matrix.
	/// &lt;P&gt;This class performs all of its operations in a right handed
	/// coordinate system with right handed rotations. Some other graphics
	/// libraries use left handed coordinate systems and rotations.
	/// </remarks>
	/// <seealso>
	///
	/// vtkPerspectiveTransform vtkGeneralTransform vtkMatrix4x4
	/// vtkTransformCollection vtkTransformFilter vtkTransformPolyDataFilter
	/// vtkImageReslice
	/// </seealso>
	// Token: 0x02000B0F RID: 2831
	public class vtkTransform : vtkLinearTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DBD9 RID: 121817 RVA: 0x002A00C3 File Offset: 0x0029E2C3
		static vtkTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DBDA RID: 121818 RVA: 0x002A00EB File Offset: 0x0029E2EB
		public vtkTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DBDB RID: 121819
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBDC RID: 121820 RVA: 0x002A00FC File Offset: 0x0029E2FC
		public new static vtkTransform New()
		{
			vtkTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransform.vtkTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBDD RID: 121821 RVA: 0x002A0150 File Offset: 0x0029E350
		public vtkTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransform.vtkTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DBDE RID: 121822 RVA: 0x002A0194 File Offset: 0x0029E394
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DBDF RID: 121823
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransform_CircuitCheck_01(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Check for self-reference.  Will return true if concatenating
		/// with the specified transform, setting it to be our inverse,
		/// or setting it to be our input will create a circular reference.
		/// CircuitCheck is automatically called by SetInput(), SetInverse(),
		/// and Concatenate(vtkXTransform *).  Avoid using this function,
		/// it is experimental.
		/// </summary>
		// Token: 0x0601DBE0 RID: 121824 RVA: 0x002A01A0 File Offset: 0x0029E3A0
		public override int CircuitCheck(vtkAbstractTransform transform)
		{
			return vtkTransform.vtkTransform_CircuitCheck_01(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x0601DBE1 RID: 121825
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_Concatenate_02(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Concatenates the matrix with the current transformation according
		/// to PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DBE2 RID: 121826 RVA: 0x002A01D4 File Offset: 0x0029E3D4
		public void Concatenate(vtkMatrix4x4 matrix)
		{
			vtkTransform.vtkTransform_Concatenate_02(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x0601DBE3 RID: 121827
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_Concatenate_03(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Concatenates the matrix with the current transformation according
		/// to PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DBE4 RID: 121828 RVA: 0x002A0203 File Offset: 0x0029E403
		public void Concatenate(IntPtr elements)
		{
			vtkTransform.vtkTransform_Concatenate_03(base.GetCppThis(), elements);
		}

		// Token: 0x0601DBE5 RID: 121829
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_Concatenate_04(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Concatenate the specified transform with the current transformation
		/// according to PreMultiply or PostMultiply semantics.
		/// The concatenation is pipelined, meaning that if any of the
		/// transformations are changed, even after Concatenate() is called,
		/// those changes will be reflected when you call TransformPoint().
		/// </summary>
		// Token: 0x0601DBE6 RID: 121830 RVA: 0x002A0214 File Offset: 0x0029E414
		public void Concatenate(vtkLinearTransform transform)
		{
			vtkTransform.vtkTransform_Concatenate_04(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x0601DBE7 RID: 121831
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform_GetConcatenatedTransform_05(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one of the concatenated transformations as a vtkAbstractTransform.
		/// These transformations are applied, in series, every time the
		/// transformation of a coordinate occurs.  This method is provided
		/// to make it possible to decompose a transformation into its
		/// constituents, for example to save a transformation to a file.
		/// </summary>
		// Token: 0x0601DBE8 RID: 121832 RVA: 0x002A0244 File Offset: 0x0029E444
		public vtkLinearTransform GetConcatenatedTransform(int i)
		{
			vtkLinearTransform vtkLinearTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransform.vtkTransform_GetConcatenatedTransform_05(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DBE9 RID: 121833
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the input for this transformation.  This will be used as the
		/// base transformation if it is set.  This method allows you to build
		/// a transform pipeline: if the input is modified, then this transformation
		/// will automatically update accordingly.  Note that the InverseFlag,
		/// controlled via Inverse(), determines whether this transformation
		/// will use the Input or the inverse of the Input.
		/// </summary>
		// Token: 0x0601DBEA RID: 121834 RVA: 0x002A02B4 File Offset: 0x0029E4B4
		public vtkLinearTransform GetInput()
		{
			vtkLinearTransform vtkLinearTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransform.vtkTransform_GetInput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DBEB RID: 121835
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_GetInverse_07(HandleRef pThis, HandleRef inverse);

		/// <summary>
		/// Return a matrix which is the inverse of the current transformation
		/// matrix.
		/// </summary>
		// Token: 0x0601DBEC RID: 121836 RVA: 0x002A0324 File Offset: 0x0029E524
		public void GetInverse(vtkMatrix4x4 inverse)
		{
			vtkTransform.vtkTransform_GetInverse_07(base.GetCppThis(), (inverse == null) ? default(HandleRef) : inverse.GetCppThis());
		}

		// Token: 0x0601DBED RID: 121837
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform_GetInverse_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Check for self-reference.  Will return true if concatenating
		/// with the specified transform, setting it to be our inverse,
		/// or setting it to be our input will create a circular reference.
		/// CircuitCheck is automatically called by SetInput(), SetInverse(),
		/// and Concatenate(vtkXTransform *).  Avoid using this function,
		/// it is experimental.
		/// </summary>
		// Token: 0x0601DBEE RID: 121838 RVA: 0x002A0354 File Offset: 0x0029E554
		public new vtkAbstractTransform GetInverse()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransform.vtkTransform_GetInverse_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DBEF RID: 121839
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransform_GetInverseFlag_09(HandleRef pThis);

		/// <summary>
		/// Get the inverse flag of the transformation.  This controls
		/// whether it is the Input or the inverse of the Input that
		/// is used as the base transformation.  The InverseFlag is
		/// flipped every time Inverse() is called.  The InverseFlag
		/// is off when a transform is first created.
		/// </summary>
		// Token: 0x0601DBF0 RID: 121840 RVA: 0x002A03C4 File Offset: 0x0029E5C4
		public int GetInverseFlag()
		{
			return vtkTransform.vtkTransform_GetInverseFlag_09(base.GetCppThis());
		}

		// Token: 0x0601DBF1 RID: 121841
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTransform_GetMTime_10(HandleRef pThis);

		/// <summary>
		/// Override GetMTime to account for input and concatenation.
		/// </summary>
		// Token: 0x0601DBF2 RID: 121842 RVA: 0x002A03E4 File Offset: 0x0029E5E4
		public override ulong GetMTime()
		{
			return vtkTransform.vtkTransform_GetMTime_10(base.GetCppThis());
		}

		// Token: 0x0601DBF3 RID: 121843
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransform_GetNumberOfConcatenatedTransforms_11(HandleRef pThis);

		/// <summary>
		/// Get the total number of transformations that are linked into this
		/// one via Concatenate() operations or via SetInput().
		/// </summary>
		// Token: 0x0601DBF4 RID: 121844 RVA: 0x002A0404 File Offset: 0x0029E604
		public int GetNumberOfConcatenatedTransforms()
		{
			return vtkTransform.vtkTransform_GetNumberOfConcatenatedTransforms_11(base.GetCppThis());
		}

		// Token: 0x0601DBF5 RID: 121845
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransform_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBF6 RID: 121846 RVA: 0x002A0424 File Offset: 0x0029E624
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransform.vtkTransform_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0601DBF7 RID: 121847
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransform_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBF8 RID: 121848 RVA: 0x002A0444 File Offset: 0x0029E644
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransform.vtkTransform_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0601DBF9 RID: 121849
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_GetOrientation_14(HandleRef pThis, IntPtr orient);

		/// <summary>
		/// Get the x, y, z orientation angles from the transformation matrix as an
		/// array of three floating point values.
		/// </summary>
		// Token: 0x0601DBFA RID: 121850 RVA: 0x002A045E File Offset: 0x0029E65E
		public void GetOrientation(IntPtr orient)
		{
			vtkTransform.vtkTransform_GetOrientation_14(base.GetCppThis(), orient);
		}

		// Token: 0x0601DBFB RID: 121851
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform_GetOrientation_15(HandleRef pThis);

		/// <summary>
		/// Get the x, y, z orientation angles from the transformation matrix as an
		/// array of three floating point values.
		/// </summary>
		// Token: 0x0601DBFC RID: 121852 RVA: 0x002A0470 File Offset: 0x0029E670
		public double[] GetOrientation()
		{
			IntPtr intPtr = vtkTransform.vtkTransform_GetOrientation_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DBFD RID: 121853
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_GetOrientation_16(IntPtr orient, HandleRef matrix);

		/// <summary>
		/// Convenience function to get the x, y, z orientation angles from
		/// a transformation matrix as an array of three floating point values.
		/// </summary>
		// Token: 0x0601DBFE RID: 121854 RVA: 0x002A04B8 File Offset: 0x0029E6B8
		public static void GetOrientation(IntPtr orient, vtkMatrix4x4 matrix)
		{
			vtkTransform.vtkTransform_GetOrientation_16(orient, (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x0601DBFF RID: 121855
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_GetOrientationWXYZ_17(HandleRef pThis, IntPtr wxyz);

		/// <summary>
		/// Return the wxyz angle+axis representing the current orientation.
		/// The angle is in degrees and the axis is a unit vector.
		/// </summary>
		// Token: 0x0601DC00 RID: 121856 RVA: 0x002A04E2 File Offset: 0x0029E6E2
		public void GetOrientationWXYZ(IntPtr wxyz)
		{
			vtkTransform.vtkTransform_GetOrientationWXYZ_17(base.GetCppThis(), wxyz);
		}

		// Token: 0x0601DC01 RID: 121857
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform_GetOrientationWXYZ_18(HandleRef pThis);

		/// <summary>
		/// Return the wxyz angle+axis representing the current orientation.
		/// The angle is in degrees and the axis is a unit vector.
		/// </summary>
		// Token: 0x0601DC02 RID: 121858 RVA: 0x002A04F4 File Offset: 0x0029E6F4
		public double[] GetOrientationWXYZ()
		{
			IntPtr intPtr = vtkTransform.vtkTransform_GetOrientationWXYZ_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DC03 RID: 121859
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_GetPosition_19(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Return the position from the current transformation matrix as an array
		/// of three floating point numbers. This is simply returning the translation
		/// component of the 4x4 matrix.
		/// </summary>
		// Token: 0x0601DC04 RID: 121860 RVA: 0x002A053C File Offset: 0x0029E73C
		public void GetPosition(IntPtr pos)
		{
			vtkTransform.vtkTransform_GetPosition_19(base.GetCppThis(), pos);
		}

		// Token: 0x0601DC05 RID: 121861
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform_GetPosition_20(HandleRef pThis);

		/// <summary>
		/// Return the position from the current transformation matrix as an array
		/// of three floating point numbers. This is simply returning the translation
		/// component of the 4x4 matrix.
		/// </summary>
		// Token: 0x0601DC06 RID: 121862 RVA: 0x002A054C File Offset: 0x0029E74C
		public double[] GetPosition()
		{
			IntPtr intPtr = vtkTransform.vtkTransform_GetPosition_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DC07 RID: 121863
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_GetScale_21(HandleRef pThis, IntPtr scale);

		/// <summary>
		/// Return the scale factors of the current transformation matrix as
		/// an array of three float numbers.  These scale factors are not necessarily
		/// about the x, y, and z axes unless unless the scale transformation was
		/// applied before any rotations.
		/// </summary>
		// Token: 0x0601DC08 RID: 121864 RVA: 0x002A0594 File Offset: 0x0029E794
		public void GetScale(IntPtr scale)
		{
			vtkTransform.vtkTransform_GetScale_21(base.GetCppThis(), scale);
		}

		// Token: 0x0601DC09 RID: 121865
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform_GetScale_22(HandleRef pThis);

		/// <summary>
		/// Return the scale factors of the current transformation matrix as
		/// an array of three float numbers.  These scale factors are not necessarily
		/// about the x, y, and z axes unless unless the scale transformation was
		/// applied before any rotations.
		/// </summary>
		// Token: 0x0601DC0A RID: 121866 RVA: 0x002A05A4 File Offset: 0x0029E7A4
		public double[] GetScale()
		{
			IntPtr intPtr = vtkTransform.vtkTransform_GetScale_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DC0B RID: 121867
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_GetTranspose_23(HandleRef pThis, HandleRef transpose);

		/// <summary>
		/// Return a matrix which is the transpose of the current transformation
		/// matrix.  This is equivalent to the inverse if and only if the
		/// transformation is a pure rotation with no translation or scale.
		/// </summary>
		// Token: 0x0601DC0C RID: 121868 RVA: 0x002A05EC File Offset: 0x0029E7EC
		public void GetTranspose(vtkMatrix4x4 transpose)
		{
			vtkTransform.vtkTransform_GetTranspose_23(base.GetCppThis(), (transpose == null) ? default(HandleRef) : transpose.GetCppThis());
		}

		// Token: 0x0601DC0D RID: 121869
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_Identity_24(HandleRef pThis);

		/// <summary>
		/// Set the transformation to the identity transformation.  If
		/// the transform has an Input, then the transformation will be
		/// reset so that it is the same as the Input.
		/// </summary>
		// Token: 0x0601DC0E RID: 121870 RVA: 0x002A061B File Offset: 0x0029E81B
		public void Identity()
		{
			vtkTransform.vtkTransform_Identity_24(base.GetCppThis());
		}

		// Token: 0x0601DC0F RID: 121871
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_Inverse_25(HandleRef pThis);

		/// <summary>
		/// Invert the transformation.  This will also set a flag so that
		/// the transformation will use the inverse of its Input, if an Input
		/// has been set.
		/// </summary>
		// Token: 0x0601DC10 RID: 121872 RVA: 0x002A062A File Offset: 0x0029E82A
		public override void Inverse()
		{
			vtkTransform.vtkTransform_Inverse_25(base.GetCppThis());
		}

		// Token: 0x0601DC11 RID: 121873
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransform_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC12 RID: 121874 RVA: 0x002A063C File Offset: 0x0029E83C
		public override int IsA(string type)
		{
			return vtkTransform.vtkTransform_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x0601DC13 RID: 121875
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransform_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC14 RID: 121876 RVA: 0x002A065C File Offset: 0x0029E85C
		public new static int IsTypeOf(string type)
		{
			return vtkTransform.vtkTransform_IsTypeOf_27(type);
		}

		// Token: 0x0601DC15 RID: 121877
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform_MakeTransform_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make a new transform of the same type.
		/// </summary>
		// Token: 0x0601DC16 RID: 121878 RVA: 0x002A0678 File Offset: 0x0029E878
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransform.vtkTransform_MakeTransform_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DC17 RID: 121879
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_MultiplyPoint_29(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Use this method only if you wish to compute the transformation in
		/// homogeneous (x,y,z,w) coordinates, otherwise use TransformPoint().
		/// This method calls this-&gt;GetMatrix()-&gt;MultiplyPoint().
		/// </summary>
		// Token: 0x0601DC18 RID: 121880 RVA: 0x002A06D2 File Offset: 0x0029E8D2
		public void MultiplyPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkTransform.vtkTransform_MultiplyPoint_29(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601DC19 RID: 121881
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC1A RID: 121882 RVA: 0x002A06E4 File Offset: 0x0029E8E4
		public new vtkTransform NewInstance()
		{
			vtkTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransform.vtkTransform_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DC1B RID: 121883
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_Pop_32(HandleRef pThis);

		/// <summary>
		/// Deletes the transformation on the top of the stack and sets the top
		/// to the next transformation on the stack.
		/// </summary>
		// Token: 0x0601DC1C RID: 121884 RVA: 0x002A073E File Offset: 0x0029E93E
		public void Pop()
		{
			vtkTransform.vtkTransform_Pop_32(base.GetCppThis());
		}

		// Token: 0x0601DC1D RID: 121885
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_PostMultiply_33(HandleRef pThis);

		/// <summary>
		/// Sets the internal state of the transform to PostMultiply. All subsequent
		/// operations will occur after those already represented in the
		/// current transformation.  In homogeneous matrix notation, M = A*M where
		/// M is the current transformation matrix and A is the applied matrix.
		/// The default is PreMultiply.
		/// </summary>
		// Token: 0x0601DC1E RID: 121886 RVA: 0x002A074D File Offset: 0x0029E94D
		public void PostMultiply()
		{
			vtkTransform.vtkTransform_PostMultiply_33(base.GetCppThis());
		}

		// Token: 0x0601DC1F RID: 121887
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_PreMultiply_34(HandleRef pThis);

		/// <summary>
		/// Sets the internal state of the transform to PreMultiply. All subsequent
		/// operations will occur before those already represented in the
		/// current transformation.  In homogeneous matrix notation, M = M*A where
		/// M is the current transformation matrix and A is the applied matrix.
		/// The default is PreMultiply.
		/// </summary>
		// Token: 0x0601DC20 RID: 121888 RVA: 0x002A075C File Offset: 0x0029E95C
		public void PreMultiply()
		{
			vtkTransform.vtkTransform_PreMultiply_34(base.GetCppThis());
		}

		// Token: 0x0601DC21 RID: 121889
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_Push_35(HandleRef pThis);

		/// <summary>
		/// Pushes the current transformation onto the transformation stack.
		/// </summary>
		// Token: 0x0601DC22 RID: 121890 RVA: 0x002A076B File Offset: 0x0029E96B
		public void Push()
		{
			vtkTransform.vtkTransform_Push_35(base.GetCppThis());
		}

		// Token: 0x0601DC23 RID: 121891
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_RotateWXYZ_36(HandleRef pThis, double angle, double x, double y, double z);

		/// <summary>
		/// Create a rotation matrix and concatenate it with the current
		/// transformation according to PreMultiply or PostMultiply semantics.
		/// The angle is in degrees, and (x,y,z) specifies the axis that the
		/// rotation will be performed around.
		/// </summary>
		// Token: 0x0601DC24 RID: 121892 RVA: 0x002A077A File Offset: 0x0029E97A
		public void RotateWXYZ(double angle, double x, double y, double z)
		{
			vtkTransform.vtkTransform_RotateWXYZ_36(base.GetCppThis(), angle, x, y, z);
		}

		// Token: 0x0601DC25 RID: 121893
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_RotateWXYZ_37(HandleRef pThis, double angle, IntPtr axis);

		/// <summary>
		/// Create a rotation matrix and concatenate it with the current
		/// transformation according to PreMultiply or PostMultiply semantics.
		/// The angle is in degrees, and (x,y,z) specifies the axis that the
		/// rotation will be performed around.
		/// </summary>
		// Token: 0x0601DC26 RID: 121894 RVA: 0x002A078E File Offset: 0x0029E98E
		public void RotateWXYZ(double angle, IntPtr axis)
		{
			vtkTransform.vtkTransform_RotateWXYZ_37(base.GetCppThis(), angle, axis);
		}

		// Token: 0x0601DC27 RID: 121895
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_RotateX_38(HandleRef pThis, double angle);

		/// <summary>
		/// Create a rotation matrix about the X, Y, or Z axis and concatenate
		/// it with the current transformation according to PreMultiply or
		/// PostMultiply semantics.  The angle is expressed in degrees.
		/// </summary>
		// Token: 0x0601DC28 RID: 121896 RVA: 0x002A079F File Offset: 0x0029E99F
		public void RotateX(double angle)
		{
			vtkTransform.vtkTransform_RotateX_38(base.GetCppThis(), angle);
		}

		// Token: 0x0601DC29 RID: 121897
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_RotateY_39(HandleRef pThis, double angle);

		/// <summary>
		/// Create a rotation matrix about the X, Y, or Z axis and concatenate
		/// it with the current transformation according to PreMultiply or
		/// PostMultiply semantics.  The angle is expressed in degrees.
		/// </summary>
		// Token: 0x0601DC2A RID: 121898 RVA: 0x002A07AF File Offset: 0x0029E9AF
		public void RotateY(double angle)
		{
			vtkTransform.vtkTransform_RotateY_39(base.GetCppThis(), angle);
		}

		// Token: 0x0601DC2B RID: 121899
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_RotateZ_40(HandleRef pThis, double angle);

		/// <summary>
		/// Create a rotation matrix about the X, Y, or Z axis and concatenate
		/// it with the current transformation according to PreMultiply or
		/// PostMultiply semantics.  The angle is expressed in degrees.
		/// </summary>
		// Token: 0x0601DC2C RID: 121900 RVA: 0x002A07BF File Offset: 0x0029E9BF
		public void RotateZ(double angle)
		{
			vtkTransform.vtkTransform_RotateZ_40(base.GetCppThis(), angle);
		}

		// Token: 0x0601DC2D RID: 121901
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC2E RID: 121902 RVA: 0x002A07D0 File Offset: 0x0029E9D0
		public new static vtkTransform SafeDownCast(vtkObjectBase o)
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransform.vtkTransform_SafeDownCast_41((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x0601DC2F RID: 121903
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_Scale_42(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Create a scale matrix (i.e. set the diagonal elements to x, y, z)
		/// and concatenate it with the current transformation according to
		/// PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DC30 RID: 121904 RVA: 0x002A084F File Offset: 0x0029EA4F
		public void Scale(double x, double y, double z)
		{
			vtkTransform.vtkTransform_Scale_42(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601DC31 RID: 121905
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_Scale_43(HandleRef pThis, IntPtr s);

		/// <summary>
		/// Create a scale matrix (i.e. set the diagonal elements to x, y, z)
		/// and concatenate it with the current transformation according to
		/// PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DC32 RID: 121906 RVA: 0x002A0861 File Offset: 0x0029EA61
		public void Scale(IntPtr s)
		{
			vtkTransform.vtkTransform_Scale_43(base.GetCppThis(), s);
		}

		// Token: 0x0601DC33 RID: 121907
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_SetInput_44(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the input for this transformation.  This will be used as the
		/// base transformation if it is set.  This method allows you to build
		/// a transform pipeline: if the input is modified, then this transformation
		/// will automatically update accordingly.  Note that the InverseFlag,
		/// controlled via Inverse(), determines whether this transformation
		/// will use the Input or the inverse of the Input.
		/// </summary>
		// Token: 0x0601DC34 RID: 121908 RVA: 0x002A0874 File Offset: 0x0029EA74
		public void SetInput(vtkLinearTransform input)
		{
			vtkTransform.vtkTransform_SetInput_44(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601DC35 RID: 121909
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_SetMatrix_45(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Set the current matrix directly. Note: First, the current
		/// matrix is set to the identity, then the input matrix is concatenated.
		/// </summary>
		// Token: 0x0601DC36 RID: 121910 RVA: 0x002A08A4 File Offset: 0x0029EAA4
		public void SetMatrix(vtkMatrix4x4 matrix)
		{
			vtkTransform.vtkTransform_SetMatrix_45(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x0601DC37 RID: 121911
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_SetMatrix_46(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Set the current matrix directly. Note: First, the current
		/// matrix is set to the identity, then the input matrix is concatenated.
		/// </summary>
		// Token: 0x0601DC38 RID: 121912 RVA: 0x002A08D3 File Offset: 0x0029EAD3
		public void SetMatrix(IntPtr elements)
		{
			vtkTransform.vtkTransform_SetMatrix_46(base.GetCppThis(), elements);
		}

		// Token: 0x0601DC39 RID: 121913
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_Translate_47(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Create a translation matrix and concatenate it with the current
		/// transformation according to PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DC3A RID: 121914 RVA: 0x002A08E3 File Offset: 0x0029EAE3
		public void Translate(double x, double y, double z)
		{
			vtkTransform.vtkTransform_Translate_47(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601DC3B RID: 121915
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform_Translate_48(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Create a translation matrix and concatenate it with the current
		/// transformation according to PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DC3C RID: 121916 RVA: 0x002A08F5 File Offset: 0x0029EAF5
		public void Translate(IntPtr x)
		{
			vtkTransform.vtkTransform_Translate_48(base.GetCppThis(), x);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F4F RID: 8015
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F50 RID: 8016
		public new static readonly string MRClassNameKey = "class vtkTransform";
	}
}
