using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMatrix3x3
	/// </summary>
	/// <remarks>
	///    represent and manipulate 3x3 transformation matrices
	///
	/// vtkMatrix3x3 is a class to represent and manipulate 3x3 matrices.
	/// Specifically, it is designed to work on 3x3 transformation matrices
	/// found in 2D rendering using homogeneous coordinates [x y w].
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTransform2D
	/// </seealso>
	// Token: 0x02000B1B RID: 2843
	public class vtkMatrix3x3 : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DD26 RID: 122150 RVA: 0x002A1CAF File Offset: 0x0029FEAF
		static vtkMatrix3x3()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMatrix3x3.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrix3x3"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DD27 RID: 122151 RVA: 0x002A1CD7 File Offset: 0x0029FED7
		public vtkMatrix3x3(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DD28 RID: 122152
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrix3x3_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a 3x3 identity matrix.
		/// </summary>
		// Token: 0x0601DD29 RID: 122153 RVA: 0x002A1CE8 File Offset: 0x0029FEE8
		public new static vtkMatrix3x3 New()
		{
			vtkMatrix3x3 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrix3x3.vtkMatrix3x3_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a 3x3 identity matrix.
		/// </summary>
		// Token: 0x0601DD2A RID: 122154 RVA: 0x002A1D3C File Offset: 0x0029FF3C
		public vtkMatrix3x3() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMatrix3x3.vtkMatrix3x3_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DD2B RID: 122155 RVA: 0x002A1D80 File Offset: 0x0029FF80
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DD2C RID: 122156
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Adjoint_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Compute adjoint of the matrix and put it into out.
		/// </summary>
		// Token: 0x0601DD2D RID: 122157 RVA: 0x002A1D8C File Offset: 0x0029FF8C
		public void Adjoint(vtkMatrix3x3 arg0, vtkMatrix3x3 arg1)
		{
			vtkMatrix3x3.vtkMatrix3x3_Adjoint_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601DD2E RID: 122158
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Adjoint_02(IntPtr inElements, IntPtr outElements);

		/// <summary>
		/// Compute adjoint of the matrix and put it into out.
		/// </summary>
		// Token: 0x0601DD2F RID: 122159 RVA: 0x002A1DD0 File Offset: 0x0029FFD0
		public static void Adjoint(IntPtr inElements, IntPtr outElements)
		{
			vtkMatrix3x3.vtkMatrix3x3_Adjoint_02(inElements, outElements);
		}

		// Token: 0x0601DD30 RID: 122160
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_DeepCopy_03(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Set the elements of the matrix to the same values as the elements
		/// of the source Matrix.
		/// </summary>
		// Token: 0x0601DD31 RID: 122161 RVA: 0x002A1DDC File Offset: 0x0029FFDC
		public void DeepCopy(vtkMatrix3x3 source)
		{
			vtkMatrix3x3.vtkMatrix3x3_DeepCopy_03(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DD32 RID: 122162
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_DeepCopy_04(IntPtr elements, HandleRef source);

		/// <summary>
		/// Set the elements of the matrix to the same values as the elements
		/// of the source Matrix.
		/// </summary>
		// Token: 0x0601DD33 RID: 122163 RVA: 0x002A1E0C File Offset: 0x002A000C
		public static void DeepCopy(IntPtr elements, vtkMatrix3x3 source)
		{
			vtkMatrix3x3.vtkMatrix3x3_DeepCopy_04(elements, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DD34 RID: 122164
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_DeepCopy_05(IntPtr elements, IntPtr newElements);

		/// <summary>
		/// Set the elements of the matrix to the same values as the elements
		/// of the source Matrix.
		/// </summary>
		// Token: 0x0601DD35 RID: 122165 RVA: 0x002A1E36 File Offset: 0x002A0036
		public static void DeepCopy(IntPtr elements, IntPtr newElements)
		{
			vtkMatrix3x3.vtkMatrix3x3_DeepCopy_05(elements, newElements);
		}

		// Token: 0x0601DD36 RID: 122166
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_DeepCopy_06(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Non-static member function. Assigns *from* elements array
		/// </summary>
		// Token: 0x0601DD37 RID: 122167 RVA: 0x002A1E41 File Offset: 0x002A0041
		public void DeepCopy(IntPtr elements)
		{
			vtkMatrix3x3.vtkMatrix3x3_DeepCopy_06(base.GetCppThis(), elements);
		}

		// Token: 0x0601DD38 RID: 122168
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMatrix3x3_Determinant_07(HandleRef pThis);

		/// <summary>
		/// Compute the determinant of the matrix and return it.
		/// </summary>
		// Token: 0x0601DD39 RID: 122169 RVA: 0x002A1E54 File Offset: 0x002A0054
		public double Determinant()
		{
			return vtkMatrix3x3.vtkMatrix3x3_Determinant_07(base.GetCppThis());
		}

		// Token: 0x0601DD3A RID: 122170
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMatrix3x3_Determinant_08(IntPtr elements);

		/// <summary>
		/// Compute the determinant of the matrix and return it.
		/// </summary>
		// Token: 0x0601DD3B RID: 122171 RVA: 0x002A1E74 File Offset: 0x002A0074
		public static double Determinant(IntPtr elements)
		{
			return vtkMatrix3x3.vtkMatrix3x3_Determinant_08(elements);
		}

		// Token: 0x0601DD3C RID: 122172
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrix3x3_GetData_09(HandleRef pThis);

		/// <summary>
		/// Return a pointer to the first element of the matrix (double[9]).
		/// </summary>
		// Token: 0x0601DD3D RID: 122173 RVA: 0x002A1E90 File Offset: 0x002A0090
		public IntPtr GetData()
		{
			return vtkMatrix3x3.vtkMatrix3x3_GetData_09(base.GetCppThis());
		}

		// Token: 0x0601DD3E RID: 122174
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMatrix3x3_GetElement_10(HandleRef pThis, int i, int j);

		/// <summary>
		/// Returns the element i,j from the matrix.
		/// </summary>
		// Token: 0x0601DD3F RID: 122175 RVA: 0x002A1EB0 File Offset: 0x002A00B0
		public double GetElement(int i, int j)
		{
			return vtkMatrix3x3.vtkMatrix3x3_GetElement_10(base.GetCppThis(), i, j);
		}

		// Token: 0x0601DD40 RID: 122176
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatrix3x3_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct a 3x3 identity matrix.
		/// </summary>
		// Token: 0x0601DD41 RID: 122177 RVA: 0x002A1ED4 File Offset: 0x002A00D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMatrix3x3.vtkMatrix3x3_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0601DD42 RID: 122178
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatrix3x3_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct a 3x3 identity matrix.
		/// </summary>
		// Token: 0x0601DD43 RID: 122179 RVA: 0x002A1EF4 File Offset: 0x002A00F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMatrix3x3.vtkMatrix3x3_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0601DD44 RID: 122180
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Identity_13(HandleRef pThis);

		/// <summary>
		/// Set equal to Identity matrix
		/// </summary>
		// Token: 0x0601DD45 RID: 122181 RVA: 0x002A1F0E File Offset: 0x002A010E
		public void Identity()
		{
			vtkMatrix3x3.vtkMatrix3x3_Identity_13(base.GetCppThis());
		}

		// Token: 0x0601DD46 RID: 122182
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Identity_14(IntPtr elements);

		/// <summary>
		/// Set equal to Identity matrix
		/// </summary>
		// Token: 0x0601DD47 RID: 122183 RVA: 0x002A1F1D File Offset: 0x002A011D
		public static void Identity(IntPtr elements)
		{
			vtkMatrix3x3.vtkMatrix3x3_Identity_14(elements);
		}

		// Token: 0x0601DD48 RID: 122184
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Invert_15(HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Matrix Inversion (adapted from Richard Carling in "Graphics Gems,"
		/// Academic Press, 1990).
		/// </summary>
		// Token: 0x0601DD49 RID: 122185 RVA: 0x002A1F28 File Offset: 0x002A0128
		public static void Invert(vtkMatrix3x3 arg0, vtkMatrix3x3 arg1)
		{
			vtkMatrix3x3.vtkMatrix3x3_Invert_15((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601DD4A RID: 122186
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Invert_16(HandleRef pThis);

		/// <summary>
		/// Matrix Inversion (adapted from Richard Carling in "Graphics Gems,"
		/// Academic Press, 1990).
		/// </summary>
		// Token: 0x0601DD4B RID: 122187 RVA: 0x002A1F66 File Offset: 0x002A0166
		public void Invert()
		{
			vtkMatrix3x3.vtkMatrix3x3_Invert_16(base.GetCppThis());
		}

		// Token: 0x0601DD4C RID: 122188
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Invert_17(IntPtr inElements, IntPtr outElements);

		/// <summary>
		/// Matrix Inversion (adapted from Richard Carling in "Graphics Gems,"
		/// Academic Press, 1990).
		/// </summary>
		// Token: 0x0601DD4D RID: 122189 RVA: 0x002A1F75 File Offset: 0x002A0175
		public static void Invert(IntPtr inElements, IntPtr outElements)
		{
			vtkMatrix3x3.vtkMatrix3x3_Invert_17(inElements, outElements);
		}

		// Token: 0x0601DD4E RID: 122190
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatrix3x3_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct a 3x3 identity matrix.
		/// </summary>
		// Token: 0x0601DD4F RID: 122191 RVA: 0x002A1F80 File Offset: 0x002A0180
		public override int IsA(string type)
		{
			return vtkMatrix3x3.vtkMatrix3x3_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0601DD50 RID: 122192
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMatrix3x3_IsIdentity_19(HandleRef pThis);

		/// <summary>
		/// Returns the element i,j from the matrix.
		/// </summary>
		// Token: 0x0601DD51 RID: 122193 RVA: 0x002A1FA0 File Offset: 0x002A01A0
		public bool IsIdentity()
		{
			return vtkMatrix3x3.vtkMatrix3x3_IsIdentity_19(base.GetCppThis()) != 0;
		}

		// Token: 0x0601DD52 RID: 122194
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatrix3x3_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct a 3x3 identity matrix.
		/// </summary>
		// Token: 0x0601DD53 RID: 122195 RVA: 0x002A1FC8 File Offset: 0x002A01C8
		public new static int IsTypeOf(string type)
		{
			return vtkMatrix3x3.vtkMatrix3x3_IsTypeOf_20(type);
		}

		// Token: 0x0601DD54 RID: 122196
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Multiply3x3_21(HandleRef a, HandleRef b, HandleRef c);

		/// <summary>
		/// Multiplies matrices a and b and stores the result in c (c=a*b).
		/// </summary>
		// Token: 0x0601DD55 RID: 122197 RVA: 0x002A1FE4 File Offset: 0x002A01E4
		public static void Multiply3x3(vtkMatrix3x3 a, vtkMatrix3x3 b, vtkMatrix3x3 c)
		{
			vtkMatrix3x3.vtkMatrix3x3_Multiply3x3_21((a == null) ? default(HandleRef) : a.GetCppThis(), (b == null) ? default(HandleRef) : b.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0601DD56 RID: 122198
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Multiply3x3_22(IntPtr a, IntPtr b, IntPtr c);

		/// <summary>
		/// Multiplies matrices a and b and stores the result in c (c=a*b).
		/// </summary>
		// Token: 0x0601DD57 RID: 122199 RVA: 0x002A2037 File Offset: 0x002A0237
		public static void Multiply3x3(IntPtr a, IntPtr b, IntPtr c)
		{
			vtkMatrix3x3.vtkMatrix3x3_Multiply3x3_22(a, b, c);
		}

		// Token: 0x0601DD58 RID: 122200
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_MultiplyPoint_23(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Multiply a homogeneous coordinate by this matrix, i.e. out = A*in.
		/// The in[3] and out[3] can be the same array.
		/// </summary>
		// Token: 0x0601DD59 RID: 122201 RVA: 0x002A2043 File Offset: 0x002A0243
		public void MultiplyPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkMatrix3x3.vtkMatrix3x3_MultiplyPoint_23(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601DD5A RID: 122202
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_MultiplyPoint_24(IntPtr elements, IntPtr arg1, IntPtr arg2);

		/// <summary>
		/// Multiply a homogeneous coordinate by this matrix, i.e. out = A*in.
		/// The in[3] and out[3] can be the same array.
		/// </summary>
		// Token: 0x0601DD5B RID: 122203 RVA: 0x002A2054 File Offset: 0x002A0254
		public static void MultiplyPoint(IntPtr elements, IntPtr arg1, IntPtr arg2)
		{
			vtkMatrix3x3.vtkMatrix3x3_MultiplyPoint_24(elements, arg1, arg2);
		}

		// Token: 0x0601DD5C RID: 122204
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrix3x3_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a 3x3 identity matrix.
		/// </summary>
		// Token: 0x0601DD5D RID: 122205 RVA: 0x002A2060 File Offset: 0x002A0260
		public new vtkMatrix3x3 NewInstance()
		{
			vtkMatrix3x3 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrix3x3.vtkMatrix3x3_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DD5E RID: 122206
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrix3x3_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a 3x3 identity matrix.
		/// </summary>
		// Token: 0x0601DD5F RID: 122207 RVA: 0x002A20BC File Offset: 0x002A02BC
		public new static vtkMatrix3x3 SafeDownCast(vtkObjectBase o)
		{
			vtkMatrix3x3 vtkMatrix3x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrix3x3.vtkMatrix3x3_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DD60 RID: 122208
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_SetElement_28(HandleRef pThis, int i, int j, double value);

		/// <summary>
		/// Sets the element i,j in the matrix.
		/// </summary>
		// Token: 0x0601DD61 RID: 122209 RVA: 0x002A213B File Offset: 0x002A033B
		public void SetElement(int i, int j, double value)
		{
			vtkMatrix3x3.vtkMatrix3x3_SetElement_28(base.GetCppThis(), i, j, value);
		}

		// Token: 0x0601DD62 RID: 122210
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Transpose_29(HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Transpose the matrix and put it into out.
		/// </summary>
		// Token: 0x0601DD63 RID: 122211 RVA: 0x002A2150 File Offset: 0x002A0350
		public static void Transpose(vtkMatrix3x3 arg0, vtkMatrix3x3 arg1)
		{
			vtkMatrix3x3.vtkMatrix3x3_Transpose_29((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601DD64 RID: 122212
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Transpose_30(HandleRef pThis);

		/// <summary>
		/// Transpose the matrix and put it into out.
		/// </summary>
		// Token: 0x0601DD65 RID: 122213 RVA: 0x002A218E File Offset: 0x002A038E
		public void Transpose()
		{
			vtkMatrix3x3.vtkMatrix3x3_Transpose_30(base.GetCppThis());
		}

		// Token: 0x0601DD66 RID: 122214
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Transpose_31(IntPtr inElements, IntPtr outElements);

		/// <summary>
		/// Transpose the matrix and put it into out.
		/// </summary>
		// Token: 0x0601DD67 RID: 122215 RVA: 0x002A219D File Offset: 0x002A039D
		public static void Transpose(IntPtr inElements, IntPtr outElements)
		{
			vtkMatrix3x3.vtkMatrix3x3_Transpose_31(inElements, outElements);
		}

		// Token: 0x0601DD68 RID: 122216
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Zero_32(HandleRef pThis);

		/// <summary>
		/// Set all of the elements to zero.
		/// </summary>
		// Token: 0x0601DD69 RID: 122217 RVA: 0x002A21A8 File Offset: 0x002A03A8
		public void Zero()
		{
			vtkMatrix3x3.vtkMatrix3x3_Zero_32(base.GetCppThis());
		}

		// Token: 0x0601DD6A RID: 122218
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrix3x3_Zero_33(IntPtr elements);

		/// <summary>
		/// Set all of the elements to zero.
		/// </summary>
		// Token: 0x0601DD6B RID: 122219 RVA: 0x002A21B7 File Offset: 0x002A03B7
		public static void Zero(IntPtr elements)
		{
			vtkMatrix3x3.vtkMatrix3x3_Zero_33(elements);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F77 RID: 8055
		public new const string MRFullTypeName = "Kitware.VTK.vtkMatrix3x3";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F78 RID: 8056
		public new static readonly string MRClassNameKey = "class vtkMatrix3x3";
	}
}
