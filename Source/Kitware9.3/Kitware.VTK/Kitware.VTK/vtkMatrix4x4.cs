using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMatrix4x4
	/// </summary>
	/// <remarks>
	///    represent and manipulate 4x4 transformation matrices
	///
	/// vtkMatrix4x4 is a class to represent and manipulate 4x4 matrices.
	/// Specifically, it is designed to work on 4x4 transformation matrices
	/// found in 3D rendering using homogeneous coordinates [x y z w].
	/// Many of the methods take an array of 16 doubles in row-major format.
	/// Note that OpenGL stores matrices in column-major format, so the matrix
	/// contents must be transposed when they are moved between OpenGL and VTK.
	/// </remarks>
	/// <seealso>
	///
	/// vtkTransform
	/// </seealso>
	// Token: 0x02000B1C RID: 2844
	public class vtkMatrix4x4 : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DD6C RID: 122220 RVA: 0x002A21C1 File Offset: 0x002A03C1
		static vtkMatrix4x4()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMatrix4x4.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrix4x4"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DD6D RID: 122221 RVA: 0x002A21E9 File Offset: 0x002A03E9
		public vtkMatrix4x4(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DD6E RID: 122222
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrix4x4_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a 4x4 identity matrix.
		/// </summary>
		// Token: 0x0601DD6F RID: 122223 RVA: 0x002A21F8 File Offset: 0x002A03F8
		public new static vtkMatrix4x4 New()
		{
			vtkMatrix4x4 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrix4x4.vtkMatrix4x4_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a 4x4 identity matrix.
		/// </summary>
		// Token: 0x0601DD70 RID: 122224 RVA: 0x002A224C File Offset: 0x002A044C
		public vtkMatrix4x4() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMatrix4x4.vtkMatrix4x4_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DD71 RID: 122225 RVA: 0x002A2290 File Offset: 0x002A0490
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DD72 RID: 122226
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Adjoint_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Compute adjoint of the matrix and put it into out.
		/// </summary>
		// Token: 0x0601DD73 RID: 122227 RVA: 0x002A229C File Offset: 0x002A049C
		public void Adjoint(vtkMatrix4x4 arg0, vtkMatrix4x4 arg1)
		{
			vtkMatrix4x4.vtkMatrix4x4_Adjoint_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601DD74 RID: 122228
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Adjoint_02(IntPtr inElements, IntPtr outElements);

		/// <summary>
		/// Compute adjoint of the matrix and put it into out.
		/// </summary>
		// Token: 0x0601DD75 RID: 122229 RVA: 0x002A22E0 File Offset: 0x002A04E0
		public static void Adjoint(IntPtr inElements, IntPtr outElements)
		{
			vtkMatrix4x4.vtkMatrix4x4_Adjoint_02(inElements, outElements);
		}

		// Token: 0x0601DD76 RID: 122230
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_DeepCopy_03(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Set the elements of the matrix to the same values as the elements
		/// of the given source matrix.
		/// </summary>
		// Token: 0x0601DD77 RID: 122231 RVA: 0x002A22EC File Offset: 0x002A04EC
		public void DeepCopy(vtkMatrix4x4 source)
		{
			vtkMatrix4x4.vtkMatrix4x4_DeepCopy_03(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DD78 RID: 122232
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_DeepCopy_04(IntPtr destination, HandleRef source);

		/// <summary>
		/// Set the elements of the given destination buffer to the same values
		/// as the elements of the given source matrix.
		/// </summary>
		// Token: 0x0601DD79 RID: 122233 RVA: 0x002A231C File Offset: 0x002A051C
		public static void DeepCopy(IntPtr destination, vtkMatrix4x4 source)
		{
			vtkMatrix4x4.vtkMatrix4x4_DeepCopy_04(destination, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DD7A RID: 122234
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_DeepCopy_05(IntPtr destination, IntPtr source);

		/// <summary>
		/// Copies the given source buffer to the given destination buffer.
		/// The memory ranges must not overlap.  Does not affect any matrix.
		/// </summary>
		// Token: 0x0601DD7B RID: 122235 RVA: 0x002A2346 File Offset: 0x002A0546
		public static void DeepCopy(IntPtr destination, IntPtr source)
		{
			vtkMatrix4x4.vtkMatrix4x4_DeepCopy_05(destination, source);
		}

		// Token: 0x0601DD7C RID: 122236
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_DeepCopy_06(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Non-static member function. Assigns *to* the matrix *from*
		/// the given elements array.
		/// </summary>
		// Token: 0x0601DD7D RID: 122237 RVA: 0x002A2351 File Offset: 0x002A0551
		public void DeepCopy(IntPtr elements)
		{
			vtkMatrix4x4.vtkMatrix4x4_DeepCopy_06(base.GetCppThis(), elements);
		}

		// Token: 0x0601DD7E RID: 122238
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMatrix4x4_Determinant_07(HandleRef pThis);

		/// <summary>
		/// Compute the determinant of the matrix and return it.
		/// </summary>
		// Token: 0x0601DD7F RID: 122239 RVA: 0x002A2364 File Offset: 0x002A0564
		public double Determinant()
		{
			return vtkMatrix4x4.vtkMatrix4x4_Determinant_07(base.GetCppThis());
		}

		// Token: 0x0601DD80 RID: 122240
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMatrix4x4_Determinant_08(IntPtr elements);

		/// <summary>
		/// Compute the determinant of the matrix and return it.
		/// </summary>
		// Token: 0x0601DD81 RID: 122241 RVA: 0x002A2384 File Offset: 0x002A0584
		public static double Determinant(IntPtr elements)
		{
			return vtkMatrix4x4.vtkMatrix4x4_Determinant_08(elements);
		}

		// Token: 0x0601DD82 RID: 122242
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrix4x4_GetData_09(HandleRef pThis);

		/// <summary>
		/// Returns the raw double array holding the matrix.
		/// </summary>
		// Token: 0x0601DD83 RID: 122243 RVA: 0x002A23A0 File Offset: 0x002A05A0
		public IntPtr GetData()
		{
			return vtkMatrix4x4.vtkMatrix4x4_GetData_09(base.GetCppThis());
		}

		// Token: 0x0601DD84 RID: 122244
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMatrix4x4_GetElement_10(HandleRef pThis, int i, int j);

		/// <summary>
		/// Returns the element i,j from the matrix.
		/// </summary>
		// Token: 0x0601DD85 RID: 122245 RVA: 0x002A23C0 File Offset: 0x002A05C0
		public double GetElement(int i, int j)
		{
			return vtkMatrix4x4.vtkMatrix4x4_GetElement_10(base.GetCppThis(), i, j);
		}

		// Token: 0x0601DD86 RID: 122246
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatrix4x4_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct a 4x4 identity matrix.
		/// </summary>
		// Token: 0x0601DD87 RID: 122247 RVA: 0x002A23E4 File Offset: 0x002A05E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMatrix4x4.vtkMatrix4x4_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0601DD88 RID: 122248
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatrix4x4_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct a 4x4 identity matrix.
		/// </summary>
		// Token: 0x0601DD89 RID: 122249 RVA: 0x002A2404 File Offset: 0x002A0604
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMatrix4x4.vtkMatrix4x4_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0601DD8A RID: 122250
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Identity_13(HandleRef pThis);

		/// <summary>
		/// Set equal to Identity matrix
		/// </summary>
		// Token: 0x0601DD8B RID: 122251 RVA: 0x002A241E File Offset: 0x002A061E
		public void Identity()
		{
			vtkMatrix4x4.vtkMatrix4x4_Identity_13(base.GetCppThis());
		}

		// Token: 0x0601DD8C RID: 122252
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Identity_14(IntPtr elements);

		/// <summary>
		/// Set equal to Identity matrix
		/// </summary>
		// Token: 0x0601DD8D RID: 122253 RVA: 0x002A242D File Offset: 0x002A062D
		public static void Identity(IntPtr elements)
		{
			vtkMatrix4x4.vtkMatrix4x4_Identity_14(elements);
		}

		// Token: 0x0601DD8E RID: 122254
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Invert_15(HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Matrix Inversion (adapted from Richard Carling in "Graphics Gems,"
		/// Academic Press, 1990).
		/// </summary>
		// Token: 0x0601DD8F RID: 122255 RVA: 0x002A2438 File Offset: 0x002A0638
		public static void Invert(vtkMatrix4x4 arg0, vtkMatrix4x4 arg1)
		{
			vtkMatrix4x4.vtkMatrix4x4_Invert_15((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601DD90 RID: 122256
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Invert_16(HandleRef pThis);

		/// <summary>
		/// Matrix Inversion (adapted from Richard Carling in "Graphics Gems,"
		/// Academic Press, 1990).
		/// </summary>
		// Token: 0x0601DD91 RID: 122257 RVA: 0x002A2476 File Offset: 0x002A0676
		public void Invert()
		{
			vtkMatrix4x4.vtkMatrix4x4_Invert_16(base.GetCppThis());
		}

		// Token: 0x0601DD92 RID: 122258
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Invert_17(IntPtr inElements, IntPtr outElements);

		/// <summary>
		/// Matrix Inversion (adapted from Richard Carling in "Graphics Gems,"
		/// Academic Press, 1990).
		/// </summary>
		// Token: 0x0601DD93 RID: 122259 RVA: 0x002A2485 File Offset: 0x002A0685
		public static void Invert(IntPtr inElements, IntPtr outElements)
		{
			vtkMatrix4x4.vtkMatrix4x4_Invert_17(inElements, outElements);
		}

		// Token: 0x0601DD94 RID: 122260
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatrix4x4_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct a 4x4 identity matrix.
		/// </summary>
		// Token: 0x0601DD95 RID: 122261 RVA: 0x002A2490 File Offset: 0x002A0690
		public override int IsA(string type)
		{
			return vtkMatrix4x4.vtkMatrix4x4_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0601DD96 RID: 122262
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMatrix4x4_IsIdentity_19(HandleRef pThis);

		/// <summary>
		/// Returns true if this matrix is equal to the identity matrix.
		/// </summary>
		// Token: 0x0601DD97 RID: 122263 RVA: 0x002A24B0 File Offset: 0x002A06B0
		public bool IsIdentity()
		{
			return vtkMatrix4x4.vtkMatrix4x4_IsIdentity_19(base.GetCppThis()) != 0;
		}

		// Token: 0x0601DD98 RID: 122264
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatrix4x4_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct a 4x4 identity matrix.
		/// </summary>
		// Token: 0x0601DD99 RID: 122265 RVA: 0x002A24D8 File Offset: 0x002A06D8
		public new static int IsTypeOf(string type)
		{
			return vtkMatrix4x4.vtkMatrix4x4_IsTypeOf_20(type);
		}

		// Token: 0x0601DD9A RID: 122266
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_MatrixFromRotation_21(double angle, double x, double y, double z, HandleRef result);

		/// <summary>
		/// Construct a matrix from a rotation
		/// </summary>
		// Token: 0x0601DD9B RID: 122267 RVA: 0x002A24F4 File Offset: 0x002A06F4
		public static void MatrixFromRotation(double angle, double x, double y, double z, vtkMatrix4x4 result)
		{
			vtkMatrix4x4.vtkMatrix4x4_MatrixFromRotation_21(angle, x, y, z, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601DD9C RID: 122268
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_MatrixFromRotation_22(double angle, double x, double y, double z, IntPtr matrix);

		/// <summary>
		/// Construct a matrix from a rotation
		/// </summary>
		// Token: 0x0601DD9D RID: 122269 RVA: 0x002A2523 File Offset: 0x002A0723
		public static void MatrixFromRotation(double angle, double x, double y, double z, IntPtr matrix)
		{
			vtkMatrix4x4.vtkMatrix4x4_MatrixFromRotation_22(angle, x, y, z, matrix);
		}

		// Token: 0x0601DD9E RID: 122270
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Multiply4x4_23(HandleRef a, HandleRef b, HandleRef c);

		/// <summary>
		/// Multiplies matrices a and b and stores the result in c.
		/// </summary>
		// Token: 0x0601DD9F RID: 122271 RVA: 0x002A2534 File Offset: 0x002A0734
		public static void Multiply4x4(vtkMatrix4x4 a, vtkMatrix4x4 b, vtkMatrix4x4 c)
		{
			vtkMatrix4x4.vtkMatrix4x4_Multiply4x4_23((a == null) ? default(HandleRef) : a.GetCppThis(), (b == null) ? default(HandleRef) : b.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0601DDA0 RID: 122272
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Multiply4x4_24(IntPtr a, IntPtr b, IntPtr c);

		/// <summary>
		/// Multiplies matrices a and b and stores the result in c.
		/// </summary>
		// Token: 0x0601DDA1 RID: 122273 RVA: 0x002A2587 File Offset: 0x002A0787
		public static void Multiply4x4(IntPtr a, IntPtr b, IntPtr c)
		{
			vtkMatrix4x4.vtkMatrix4x4_Multiply4x4_24(a, b, c);
		}

		// Token: 0x0601DDA2 RID: 122274
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_MultiplyAndTranspose4x4_25(IntPtr a, IntPtr b, IntPtr c);

		/// <summary>
		/// Multiplies matrices a and b and stores the result in c.
		/// </summary>
		// Token: 0x0601DDA3 RID: 122275 RVA: 0x002A2593 File Offset: 0x002A0793
		public static void MultiplyAndTranspose4x4(IntPtr a, IntPtr b, IntPtr c)
		{
			vtkMatrix4x4.vtkMatrix4x4_MultiplyAndTranspose4x4_25(a, b, c);
		}

		// Token: 0x0601DDA4 RID: 122276
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrix4x4_MultiplyDoublePoint_26(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// For use in Java or Python.
		/// </summary>
		// Token: 0x0601DDA5 RID: 122277 RVA: 0x002A25A0 File Offset: 0x002A07A0
		public double[] MultiplyDoublePoint(IntPtr arg0)
		{
			IntPtr intPtr = vtkMatrix4x4.vtkMatrix4x4_MultiplyDoublePoint_26(base.GetCppThis(), arg0);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DDA6 RID: 122278
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrix4x4_MultiplyFloatPoint_27(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// For use in Java or Python.
		/// </summary>
		// Token: 0x0601DDA7 RID: 122279 RVA: 0x002A25EC File Offset: 0x002A07EC
		public float[] MultiplyFloatPoint(IntPtr arg0)
		{
			IntPtr intPtr = vtkMatrix4x4.vtkMatrix4x4_MultiplyFloatPoint_27(base.GetCppThis(), arg0);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DDA8 RID: 122280
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_MultiplyPoint_28(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Multiply a homogeneous coordinate by this matrix, i.e. out = A*in.
		/// The in[4] and out[4] can be the same array.
		/// </summary>
		// Token: 0x0601DDA9 RID: 122281 RVA: 0x002A2635 File Offset: 0x002A0835
		public void MultiplyPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkMatrix4x4.vtkMatrix4x4_MultiplyPoint_28(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601DDAA RID: 122282
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_MultiplyPoint_29(IntPtr elements, IntPtr arg1, IntPtr arg2);

		/// <summary>
		/// Multiply a homogeneous coordinate by this matrix, i.e. out = A*in.
		/// The in[4] and out[4] can be the same array.
		/// </summary>
		// Token: 0x0601DDAB RID: 122283 RVA: 0x002A2646 File Offset: 0x002A0846
		public static void MultiplyPoint(IntPtr elements, IntPtr arg1, IntPtr arg2)
		{
			vtkMatrix4x4.vtkMatrix4x4_MultiplyPoint_29(elements, arg1, arg2);
		}

		// Token: 0x0601DDAC RID: 122284
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrix4x4_MultiplyPoint_30(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// For use in Java or Python.
		/// </summary>
		// Token: 0x0601DDAD RID: 122285 RVA: 0x002A2654 File Offset: 0x002A0854
		public float[] MultiplyPoint(IntPtr arg0)
		{
			IntPtr intPtr = vtkMatrix4x4.vtkMatrix4x4_MultiplyPoint_30(base.GetCppThis(), arg0);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DDAE RID: 122286
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrix4x4_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a 4x4 identity matrix.
		/// </summary>
		// Token: 0x0601DDAF RID: 122287 RVA: 0x002A26A0 File Offset: 0x002A08A0
		public new vtkMatrix4x4 NewInstance()
		{
			vtkMatrix4x4 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrix4x4.vtkMatrix4x4_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DDB0 RID: 122288
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_PoseToMatrix_33(IntPtr pos, IntPtr ori, HandleRef mat);

		/// <summary>
		/// Given an orientation and position this function will fill in a matrix
		/// representing the transformation from the pose to whatever space the pose was
		/// defined in. For example if the position and orientation are in world
		/// coordinates then this method would set the matrix to be PoseToWorld
		/// </summary>
		// Token: 0x0601DDB1 RID: 122289 RVA: 0x002A26FC File Offset: 0x002A08FC
		public static void PoseToMatrix(IntPtr pos, IntPtr ori, vtkMatrix4x4 mat)
		{
			vtkMatrix4x4.vtkMatrix4x4_PoseToMatrix_33(pos, ori, (mat == null) ? default(HandleRef) : mat.GetCppThis());
		}

		// Token: 0x0601DDB2 RID: 122290
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrix4x4_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a 4x4 identity matrix.
		/// </summary>
		// Token: 0x0601DDB3 RID: 122291 RVA: 0x002A2728 File Offset: 0x002A0928
		public new static vtkMatrix4x4 SafeDownCast(vtkObjectBase o)
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrix4x4.vtkMatrix4x4_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x0601DDB4 RID: 122292
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_SetElement_35(HandleRef pThis, int i, int j, double value);

		/// <summary>
		/// Sets the element i,j in the matrix.
		/// </summary>
		// Token: 0x0601DDB5 RID: 122293 RVA: 0x002A27A7 File Offset: 0x002A09A7
		public void SetElement(int i, int j, double value)
		{
			vtkMatrix4x4.vtkMatrix4x4_SetElement_35(base.GetCppThis(), i, j, value);
		}

		// Token: 0x0601DDB6 RID: 122294
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Transpose_36(HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Transpose the matrix and put it into out.
		/// </summary>
		// Token: 0x0601DDB7 RID: 122295 RVA: 0x002A27BC File Offset: 0x002A09BC
		public static void Transpose(vtkMatrix4x4 arg0, vtkMatrix4x4 arg1)
		{
			vtkMatrix4x4.vtkMatrix4x4_Transpose_36((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601DDB8 RID: 122296
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Transpose_37(HandleRef pThis);

		/// <summary>
		/// Transpose the matrix and put it into out.
		/// </summary>
		// Token: 0x0601DDB9 RID: 122297 RVA: 0x002A27FA File Offset: 0x002A09FA
		public void Transpose()
		{
			vtkMatrix4x4.vtkMatrix4x4_Transpose_37(base.GetCppThis());
		}

		// Token: 0x0601DDBA RID: 122298
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Transpose_38(IntPtr inElements, IntPtr outElements);

		/// <summary>
		/// Transpose the matrix and put it into out.
		/// </summary>
		// Token: 0x0601DDBB RID: 122299 RVA: 0x002A2809 File Offset: 0x002A0A09
		public static void Transpose(IntPtr inElements, IntPtr outElements)
		{
			vtkMatrix4x4.vtkMatrix4x4_Transpose_38(inElements, outElements);
		}

		// Token: 0x0601DDBC RID: 122300
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Zero_39(HandleRef pThis);

		/// <summary>
		/// Set all of the elements to zero.
		/// </summary>
		// Token: 0x0601DDBD RID: 122301 RVA: 0x002A2814 File Offset: 0x002A0A14
		public void Zero()
		{
			vtkMatrix4x4.vtkMatrix4x4_Zero_39(base.GetCppThis());
		}

		// Token: 0x0601DDBE RID: 122302
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix4x4_Zero_40(IntPtr elements);

		/// <summary>
		/// Set all of the elements to zero.
		/// </summary>
		// Token: 0x0601DDBF RID: 122303 RVA: 0x002A2823 File Offset: 0x002A0A23
		public static void Zero(IntPtr elements)
		{
			vtkMatrix4x4.vtkMatrix4x4_Zero_40(elements);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F79 RID: 8057
		public new const string MRFullTypeName = "Kitware.VTK.vtkMatrix4x4";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F7A RID: 8058
		public new static readonly string MRClassNameKey = "class vtkMatrix4x4";
	}
}
