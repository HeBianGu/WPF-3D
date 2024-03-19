using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageTransform
	/// </summary>
	/// <remarks>
	///    helper class to transform output of non-axis-aligned images
	///
	/// vtkImageTransform is a helper class to transform the output of
	/// image filters (i.e., filter that input vtkImageData) by applying the
	/// Index to Physical transformation from the input image, which can
	/// include origin, spacing, direction. The transformation process is
	/// threaded with vtkSMPTools for performance.
	///
	/// Typically in application the single method TransformPointSet() is
	/// invoked to transform the output of an image algorithm (assuming
	/// that the image's direction/orientation matrix is
	/// non-identity). Note that vtkPointSets encompass vtkPolyData as well
	/// as vtkUnstructuredGrids. In the future other output types may be
	/// added. Note that specific methods for transforming points, normals,
	/// and vectors is also provided by this class in case additional
	/// output data arrays need to be transformed (since
	/// TransformPointSet() only processes data arrays labeled as points,
	/// normals, and vectors).
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	// Token: 0x02000A64 RID: 2660
	public class vtkImageTransform : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BDD3 RID: 114131 RVA: 0x0027069D File Offset: 0x0026E89D
		static vtkImageTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BDD4 RID: 114132 RVA: 0x002706C5 File Offset: 0x0026E8C5
		public vtkImageTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BDD5 RID: 114133
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type information, printing.
		/// </summary>
		// Token: 0x0601BDD6 RID: 114134 RVA: 0x002706D4 File Offset: 0x0026E8D4
		public new static vtkImageTransform New()
		{
			vtkImageTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTransform.vtkImageTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for construction, type information, printing.
		/// </summary>
		// Token: 0x0601BDD7 RID: 114135 RVA: 0x00270728 File Offset: 0x0026E928
		public vtkImageTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageTransform.vtkImageTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BDD8 RID: 114136 RVA: 0x0027076C File Offset: 0x0026E96C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BDD9 RID: 114137
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageTransform_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type information, printing.
		/// </summary>
		// Token: 0x0601BDDA RID: 114138 RVA: 0x00270778 File Offset: 0x0026E978
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageTransform.vtkImageTransform_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601BDDB RID: 114139
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageTransform_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type information, printing.
		/// </summary>
		// Token: 0x0601BDDC RID: 114140 RVA: 0x00270798 File Offset: 0x0026E998
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageTransform.vtkImageTransform_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601BDDD RID: 114141
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTransform_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type information, printing.
		/// </summary>
		// Token: 0x0601BDDE RID: 114142 RVA: 0x002707B4 File Offset: 0x0026E9B4
		public override int IsA(string type)
		{
			return vtkImageTransform.vtkImageTransform_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601BDDF RID: 114143
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTransform_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type information, printing.
		/// </summary>
		// Token: 0x0601BDE0 RID: 114144 RVA: 0x002707D4 File Offset: 0x0026E9D4
		public new static int IsTypeOf(string type)
		{
			return vtkImageTransform.vtkImageTransform_IsTypeOf_04(type);
		}

		// Token: 0x0601BDE1 RID: 114145
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTransform_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type information, printing.
		/// </summary>
		// Token: 0x0601BDE2 RID: 114146 RVA: 0x002707F0 File Offset: 0x0026E9F0
		public new vtkImageTransform NewInstance()
		{
			vtkImageTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTransform.vtkImageTransform_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BDE3 RID: 114147
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTransform_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type information, printing.
		/// </summary>
		// Token: 0x0601BDE4 RID: 114148 RVA: 0x0027084C File Offset: 0x0026EA4C
		public new static vtkImageTransform SafeDownCast(vtkObjectBase o)
		{
			vtkImageTransform vtkImageTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTransform.vtkImageTransform_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageTransform = (vtkImageTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageTransform.Register(null);
				}
			}
			return vtkImageTransform;
		}

		// Token: 0x0601BDE5 RID: 114149
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTransform_TransformNormals_08(HandleRef m3, IntPtr spacing, HandleRef da);

		/// <summary>
		/// Given three-component normals represented by a vtkDataArray,
		/// transform the normals using the matrix provided.
		/// </summary>
		// Token: 0x0601BDE6 RID: 114150 RVA: 0x002708CC File Offset: 0x0026EACC
		public static void TransformNormals(vtkMatrix3x3 m3, IntPtr spacing, vtkDataArray da)
		{
			vtkImageTransform.vtkImageTransform_TransformNormals_08((m3 == null) ? default(HandleRef) : m3.GetCppThis(), spacing, (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601BDE7 RID: 114151
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTransform_TransformPointSet_09(HandleRef im, HandleRef ps);

		/// <summary>
		/// Given a vtkImageData (and hence its associated orientation
		/// matrix), and an instance of vtkPointSet, transform its points, as
		/// well as any normals and vectors, associated with the
		/// vtkPointSet. This is a convenience function, internally it calls
		/// TranslatePoints(), TransformPoints(), TransformNormals(), and/or
		/// TransformVectors() as appropriate. Note that both the normals and
		/// vectors associated with the point and cell data are transformed
		/// unless the second signature is called, which controls whether to
		/// transform normals and/or vectors.
		/// </summary>
		// Token: 0x0601BDE8 RID: 114152 RVA: 0x0027090C File Offset: 0x0026EB0C
		public static void TransformPointSet(vtkImageData im, vtkPointSet ps)
		{
			vtkImageTransform.vtkImageTransform_TransformPointSet_09((im == null) ? default(HandleRef) : im.GetCppThis(), (ps == null) ? default(HandleRef) : ps.GetCppThis());
		}

		// Token: 0x0601BDE9 RID: 114153
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTransform_TransformPointSet_10(HandleRef im, HandleRef ps, byte transNormals, byte transVectors);

		/// <summary>
		/// Given a vtkImageData (and hence its associated orientation
		/// matrix), and an instance of vtkPointSet, transform its points, as
		/// well as any normals and vectors, associated with the
		/// vtkPointSet. This is a convenience function, internally it calls
		/// TranslatePoints(), TransformPoints(), TransformNormals(), and/or
		/// TransformVectors() as appropriate. Note that both the normals and
		/// vectors associated with the point and cell data are transformed
		/// unless the second signature is called, which controls whether to
		/// transform normals and/or vectors.
		/// </summary>
		// Token: 0x0601BDEA RID: 114154 RVA: 0x0027094C File Offset: 0x0026EB4C
		public static void TransformPointSet(vtkImageData im, vtkPointSet ps, bool transNormals, bool transVectors)
		{
			vtkImageTransform.vtkImageTransform_TransformPointSet_10((im == null) ? default(HandleRef) : im.GetCppThis(), (ps == null) ? default(HandleRef) : ps.GetCppThis(), transNormals ? (byte)1 : (byte)0, transVectors ? (byte)1 : (byte)0);
		}

		// Token: 0x0601BDEB RID: 114155
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTransform_TransformPoints_11(HandleRef m4, HandleRef da);

		/// <summary>
		/// Given x-y-z points represented by a vtkDataArray,
		/// transform the points using the matrix provided.
		/// </summary>
		// Token: 0x0601BDEC RID: 114156 RVA: 0x0027099C File Offset: 0x0026EB9C
		public static void TransformPoints(vtkMatrix4x4 m4, vtkDataArray da)
		{
			vtkImageTransform.vtkImageTransform_TransformPoints_11((m4 == null) ? default(HandleRef) : m4.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601BDED RID: 114157
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTransform_TransformVectors_12(HandleRef m3, IntPtr spacing, HandleRef da);

		/// <summary>
		/// Given three-component vectors represented by a vtkDataArray,
		/// transform the vectors using the matrix provided.
		/// </summary>
		// Token: 0x0601BDEE RID: 114158 RVA: 0x002709DC File Offset: 0x0026EBDC
		public static void TransformVectors(vtkMatrix3x3 m3, IntPtr spacing, vtkDataArray da)
		{
			vtkImageTransform.vtkImageTransform_TransformVectors_12((m3 == null) ? default(HandleRef) : m3.GetCppThis(), spacing, (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601BDEF RID: 114159
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTransform_TranslatePoints_13(IntPtr t, HandleRef da);

		/// <summary>
		/// Given x-y-z points represented by a vtkDataArray,
		/// translate the points using the image origin. This
		/// method is useful if there is no orientation or
		/// spacing to apply.
		/// </summary>
		// Token: 0x0601BDF0 RID: 114160 RVA: 0x00270A1C File Offset: 0x0026EC1C
		public static void TranslatePoints(IntPtr t, vtkDataArray da)
		{
			vtkImageTransform.vtkImageTransform_TranslatePoints_13(t, (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DBC RID: 7612
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DBD RID: 7613
		public new static readonly string MRClassNameKey = "class vtkImageTransform";
	}
}
