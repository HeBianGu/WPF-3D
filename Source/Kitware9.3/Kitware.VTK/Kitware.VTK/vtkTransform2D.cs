using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransform2D
	/// </summary>
	/// <remarks>
	///    describes linear transformations via a 3x3 matrix
	///
	/// A vtkTransform2D can be used to describe the full range of linear (also
	/// known as affine) coordinate transformations in two dimensions,
	/// which are internally represented as a 3x3 homogeneous transformation
	/// matrix.  When you create a new vtkTransform2D, it is always initialized
	/// to the identity transformation.
	///
	/// All multiplicitive operations (Translate, Rotate, Scale, etc) are
	/// post-multiplied in this class (i.e. add them in the reverse of the order
	/// that they should be applied).
	///
	/// This class performs all of its operations in a right handed
	/// coordinate system with right handed rotations. Some other graphics
	/// libraries use left handed coordinate systems and rotations.
	/// </remarks>
	// Token: 0x02000B10 RID: 2832
	public class vtkTransform2D : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DC3D RID: 121917 RVA: 0x002A0905 File Offset: 0x0029EB05
		static vtkTransform2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransform2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransform2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DC3E RID: 121918 RVA: 0x002A092D File Offset: 0x0029EB2D
		public vtkTransform2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DC3F RID: 121919
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC40 RID: 121920 RVA: 0x002A093C File Offset: 0x0029EB3C
		public new static vtkTransform2D New()
		{
			vtkTransform2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransform2D.vtkTransform2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC41 RID: 121921 RVA: 0x002A0990 File Offset: 0x0029EB90
		public vtkTransform2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransform2D.vtkTransform2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DC42 RID: 121922 RVA: 0x002A09D4 File Offset: 0x0029EBD4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DC43 RID: 121923
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_GetInverse_01(HandleRef pThis, HandleRef inverse);

		/// <summary>
		/// Return a matrix which is the inverse of the current transformation
		/// matrix.
		/// </summary>
		// Token: 0x0601DC44 RID: 121924 RVA: 0x002A09E0 File Offset: 0x0029EBE0
		public void GetInverse(vtkMatrix3x3 inverse)
		{
			vtkTransform2D.vtkTransform2D_GetInverse_01(base.GetCppThis(), (inverse == null) ? default(HandleRef) : inverse.GetCppThis());
		}

		// Token: 0x0601DC45 RID: 121925
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTransform2D_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Override GetMTime to account for input and concatenation.
		/// </summary>
		// Token: 0x0601DC46 RID: 121926 RVA: 0x002A0A10 File Offset: 0x0029EC10
		public override ulong GetMTime()
		{
			return vtkTransform2D.vtkTransform2D_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x0601DC47 RID: 121927
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform2D_GetMatrix_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the underlying 3x3 matrix.
		/// </summary>
		// Token: 0x0601DC48 RID: 121928 RVA: 0x002A0A30 File Offset: 0x0029EC30
		public virtual vtkMatrix3x3 GetMatrix()
		{
			vtkMatrix3x3 vtkMatrix3x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransform2D.vtkTransform2D_GetMatrix_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix3x = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix3x.Register(null);
				}
			}
			return vtkMatrix3x;
		}

		// Token: 0x0601DC49 RID: 121929
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_GetMatrix_04(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Get the underlying 3x3 matrix.
		/// </summary>
		// Token: 0x0601DC4A RID: 121930 RVA: 0x002A0AA0 File Offset: 0x0029ECA0
		public void GetMatrix(vtkMatrix3x3 matrix)
		{
			vtkTransform2D.vtkTransform2D_GetMatrix_04(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x0601DC4B RID: 121931
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransform2D_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC4C RID: 121932 RVA: 0x002A0AD0 File Offset: 0x0029ECD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransform2D.vtkTransform2D_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601DC4D RID: 121933
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransform2D_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC4E RID: 121934 RVA: 0x002A0AF0 File Offset: 0x0029ECF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransform2D.vtkTransform2D_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601DC4F RID: 121935
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_GetPosition_07(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Return the position from the current transformation matrix as an array
		/// of two floating point numbers. This is simply returning the translation
		/// component of the 3x3 matrix.
		/// </summary>
		// Token: 0x0601DC50 RID: 121936 RVA: 0x002A0B0A File Offset: 0x0029ED0A
		public void GetPosition(IntPtr pos)
		{
			vtkTransform2D.vtkTransform2D_GetPosition_07(base.GetCppThis(), pos);
		}

		// Token: 0x0601DC51 RID: 121937
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_GetScale_08(HandleRef pThis, IntPtr scale);

		/// <summary>
		/// Return the x and y scale from the current transformation matrix as an array
		/// of two floating point numbers. This is simply returning the scale
		/// component of the 3x3 matrix.
		/// </summary>
		// Token: 0x0601DC52 RID: 121938 RVA: 0x002A0B1A File Offset: 0x0029ED1A
		public void GetScale(IntPtr scale)
		{
			vtkTransform2D.vtkTransform2D_GetScale_08(base.GetCppThis(), scale);
		}

		// Token: 0x0601DC53 RID: 121939
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_GetTranspose_09(HandleRef pThis, HandleRef transpose);

		/// <summary>
		/// Return a matrix which is the transpose of the current transformation
		/// matrix.  This is equivalent to the inverse if and only if the
		/// transformation is a pure rotation with no translation or scale.
		/// </summary>
		// Token: 0x0601DC54 RID: 121940 RVA: 0x002A0B2C File Offset: 0x0029ED2C
		public void GetTranspose(vtkMatrix3x3 transpose)
		{
			vtkTransform2D.vtkTransform2D_GetTranspose_09(base.GetCppThis(), (transpose == null) ? default(HandleRef) : transpose.GetCppThis());
		}

		// Token: 0x0601DC55 RID: 121941
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_Identity_10(HandleRef pThis);

		/// <summary>
		/// Set the transformation to the identity transformation.
		/// </summary>
		// Token: 0x0601DC56 RID: 121942 RVA: 0x002A0B5B File Offset: 0x0029ED5B
		public void Identity()
		{
			vtkTransform2D.vtkTransform2D_Identity_10(base.GetCppThis());
		}

		// Token: 0x0601DC57 RID: 121943
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_Inverse_11(HandleRef pThis);

		/// <summary>
		/// Invert the transformation.
		/// </summary>
		// Token: 0x0601DC58 RID: 121944 RVA: 0x002A0B6A File Offset: 0x0029ED6A
		public void Inverse()
		{
			vtkTransform2D.vtkTransform2D_Inverse_11(base.GetCppThis());
		}

		// Token: 0x0601DC59 RID: 121945
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_InverseTransformPoints_12(HandleRef pThis, IntPtr inPts, IntPtr outPts, int n);

		/// <summary>
		/// Apply the transformation to a series of points, and append the
		/// results to outPts. Where n is the number of points, and the float pointers
		/// are of length 2*n.
		/// </summary>
		// Token: 0x0601DC5A RID: 121946 RVA: 0x002A0B79 File Offset: 0x0029ED79
		public void InverseTransformPoints(IntPtr inPts, IntPtr outPts, int n)
		{
			vtkTransform2D.vtkTransform2D_InverseTransformPoints_12(base.GetCppThis(), inPts, outPts, n);
		}

		// Token: 0x0601DC5B RID: 121947
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_InverseTransformPoints_13(HandleRef pThis, HandleRef inPts, HandleRef outPts);

		/// <summary>
		/// Apply the transformation to a series of points, and append the
		/// results to outPts.
		/// </summary>
		// Token: 0x0601DC5C RID: 121948 RVA: 0x002A0B8C File Offset: 0x0029ED8C
		public void InverseTransformPoints(vtkPoints2D inPts, vtkPoints2D outPts)
		{
			vtkTransform2D.vtkTransform2D_InverseTransformPoints_13(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis());
		}

		// Token: 0x0601DC5D RID: 121949
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransform2D_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC5E RID: 121950 RVA: 0x002A0BD0 File Offset: 0x0029EDD0
		public override int IsA(string type)
		{
			return vtkTransform2D.vtkTransform2D_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0601DC5F RID: 121951
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransform2D_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC60 RID: 121952 RVA: 0x002A0BF0 File Offset: 0x0029EDF0
		public new static int IsTypeOf(string type)
		{
			return vtkTransform2D.vtkTransform2D_IsTypeOf_15(type);
		}

		// Token: 0x0601DC61 RID: 121953
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_MultiplyPoint_16(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Use this method only if you wish to compute the transformation in
		/// homogeneous (x,y,w) coordinates, otherwise use TransformPoint().
		/// This method calls this-&gt;GetMatrix()-&gt;MultiplyPoint().
		/// </summary>
		// Token: 0x0601DC62 RID: 121954 RVA: 0x002A0C0A File Offset: 0x0029EE0A
		public void MultiplyPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkTransform2D.vtkTransform2D_MultiplyPoint_16(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601DC63 RID: 121955
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform2D_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC64 RID: 121956 RVA: 0x002A0C1C File Offset: 0x0029EE1C
		public new vtkTransform2D NewInstance()
		{
			vtkTransform2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransform2D.vtkTransform2D_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DC65 RID: 121957
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_Rotate_19(HandleRef pThis, double angle);

		/// <summary>
		/// Create a rotation matrix and concatenate it with the current
		/// transformation. The angle is in degrees.
		/// </summary>
		// Token: 0x0601DC66 RID: 121958 RVA: 0x002A0C76 File Offset: 0x0029EE76
		public void Rotate(double angle)
		{
			vtkTransform2D.vtkTransform2D_Rotate_19(base.GetCppThis(), angle);
		}

		// Token: 0x0601DC67 RID: 121959
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransform2D_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC68 RID: 121960 RVA: 0x002A0C88 File Offset: 0x0029EE88
		public new static vtkTransform2D SafeDownCast(vtkObjectBase o)
		{
			vtkTransform2D vtkTransform2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransform2D.vtkTransform2D_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform2D = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform2D.Register(null);
				}
			}
			return vtkTransform2D;
		}

		// Token: 0x0601DC69 RID: 121961
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_Scale_21(HandleRef pThis, double x, double y);

		/// <summary>
		/// Create a scale matrix (i.e. set the diagonal elements to x, y)
		/// and concatenate it with the current transformation.
		/// </summary>
		// Token: 0x0601DC6A RID: 121962 RVA: 0x002A0D07 File Offset: 0x0029EF07
		public void Scale(double x, double y)
		{
			vtkTransform2D.vtkTransform2D_Scale_21(base.GetCppThis(), x, y);
		}

		// Token: 0x0601DC6B RID: 121963
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_Scale_22(HandleRef pThis, IntPtr s);

		/// <summary>
		/// Create a scale matrix (i.e. set the diagonal elements to x, y)
		/// and concatenate it with the current transformation.
		/// </summary>
		// Token: 0x0601DC6C RID: 121964 RVA: 0x002A0D18 File Offset: 0x0029EF18
		public void Scale(IntPtr s)
		{
			vtkTransform2D.vtkTransform2D_Scale_22(base.GetCppThis(), s);
		}

		// Token: 0x0601DC6D RID: 121965
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_SetMatrix_23(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Set the current matrix directly.
		/// </summary>
		// Token: 0x0601DC6E RID: 121966 RVA: 0x002A0D28 File Offset: 0x0029EF28
		public void SetMatrix(vtkMatrix3x3 matrix)
		{
			vtkTransform2D.vtkTransform2D_SetMatrix_23(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x0601DC6F RID: 121967
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_SetMatrix_24(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Set the current matrix directly.
		/// </summary>
		// Token: 0x0601DC70 RID: 121968 RVA: 0x002A0D57 File Offset: 0x0029EF57
		public void SetMatrix(IntPtr elements)
		{
			vtkTransform2D.vtkTransform2D_SetMatrix_24(base.GetCppThis(), elements);
		}

		// Token: 0x0601DC71 RID: 121969
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_TransformPoints_25(HandleRef pThis, IntPtr inPts, IntPtr outPts, int n);

		/// <summary>
		/// Apply the transformation to a series of points, and append the
		/// results to outPts. Where n is the number of points, and the float pointers
		/// are of length 2*n.
		/// </summary>
		// Token: 0x0601DC72 RID: 121970 RVA: 0x002A0D67 File Offset: 0x0029EF67
		public void TransformPoints(IntPtr inPts, IntPtr outPts, int n)
		{
			vtkTransform2D.vtkTransform2D_TransformPoints_25(base.GetCppThis(), inPts, outPts, n);
		}

		// Token: 0x0601DC73 RID: 121971
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_TransformPoints_26(HandleRef pThis, HandleRef inPts, HandleRef outPts);

		/// <summary>
		/// Apply the transformation to a series of points, and append the
		/// results to outPts.
		/// </summary>
		// Token: 0x0601DC74 RID: 121972 RVA: 0x002A0D7C File Offset: 0x0029EF7C
		public void TransformPoints(vtkPoints2D inPts, vtkPoints2D outPts)
		{
			vtkTransform2D.vtkTransform2D_TransformPoints_26(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis());
		}

		// Token: 0x0601DC75 RID: 121973
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_Translate_27(HandleRef pThis, double x, double y);

		/// <summary>
		/// Create a translation matrix and concatenate it with the current
		/// transformation.
		/// </summary>
		// Token: 0x0601DC76 RID: 121974 RVA: 0x002A0DC0 File Offset: 0x0029EFC0
		public void Translate(double x, double y)
		{
			vtkTransform2D.vtkTransform2D_Translate_27(base.GetCppThis(), x, y);
		}

		// Token: 0x0601DC77 RID: 121975
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransform2D_Translate_28(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Create a translation matrix and concatenate it with the current
		/// transformation.
		/// </summary>
		// Token: 0x0601DC78 RID: 121976 RVA: 0x002A0DD1 File Offset: 0x0029EFD1
		public void Translate(IntPtr x)
		{
			vtkTransform2D.vtkTransform2D_Translate_28(base.GetCppThis(), x);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F51 RID: 8017
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransform2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F52 RID: 8018
		public new static readonly string MRClassNameKey = "class vtkTransform2D";
	}
}
