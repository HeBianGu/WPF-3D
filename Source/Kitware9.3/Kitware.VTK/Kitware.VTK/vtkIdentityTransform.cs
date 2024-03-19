using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIdentityTransform
	/// </summary>
	/// <remarks>
	///    a transform that doesn't do anything
	///
	/// vtkIdentityTransform is a transformation which will simply pass coordinate
	/// data unchanged.  All other transform types can also do this, however,
	/// the vtkIdentityTransform does so with much greater efficiency.
	/// </remarks>
	/// <seealso>
	///
	/// vtkLinearTransform
	/// </seealso>
	// Token: 0x02000B08 RID: 2824
	public class vtkIdentityTransform : vtkLinearTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DAAF RID: 121519 RVA: 0x0029E3A1 File Offset: 0x0029C5A1
		static vtkIdentityTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIdentityTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIdentityTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DAB0 RID: 121520 RVA: 0x0029E3C9 File Offset: 0x0029C5C9
		public vtkIdentityTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DAB1 RID: 121521
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdentityTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAB2 RID: 121522 RVA: 0x0029E3D8 File Offset: 0x0029C5D8
		public new static vtkIdentityTransform New()
		{
			vtkIdentityTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdentityTransform.vtkIdentityTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdentityTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAB3 RID: 121523 RVA: 0x0029E42C File Offset: 0x0029C62C
		public vtkIdentityTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIdentityTransform.vtkIdentityTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DAB4 RID: 121524 RVA: 0x0029E470 File Offset: 0x0029C670
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DAB5 RID: 121525
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdentityTransform_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAB6 RID: 121526 RVA: 0x0029E47C File Offset: 0x0029C67C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIdentityTransform.vtkIdentityTransform_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601DAB7 RID: 121527
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdentityTransform_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAB8 RID: 121528 RVA: 0x0029E49C File Offset: 0x0029C69C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIdentityTransform.vtkIdentityTransform_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601DAB9 RID: 121529
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdentityTransform_InternalTransformNormal_03(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// This will calculate the transformation without calling Update.
		/// Meant for use only within other VTK classes.
		/// </summary>
		// Token: 0x0601DABA RID: 121530 RVA: 0x0029E4B6 File Offset: 0x0029C6B6
		public override void InternalTransformNormal(IntPtr arg0, IntPtr arg1)
		{
			vtkIdentityTransform.vtkIdentityTransform_InternalTransformNormal_03(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601DABB RID: 121531
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdentityTransform_InternalTransformPoint_04(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// This will calculate the transformation without calling Update.
		/// Meant for use only within other VTK classes.
		/// </summary>
		// Token: 0x0601DABC RID: 121532 RVA: 0x0029E4C7 File Offset: 0x0029C6C7
		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkIdentityTransform.vtkIdentityTransform_InternalTransformPoint_04(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601DABD RID: 121533
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdentityTransform_InternalTransformVector_05(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// This will calculate the transformation without calling Update.
		/// Meant for use only within other VTK classes.
		/// </summary>
		// Token: 0x0601DABE RID: 121534 RVA: 0x0029E4D8 File Offset: 0x0029C6D8
		public override void InternalTransformVector(IntPtr arg0, IntPtr arg1)
		{
			vtkIdentityTransform.vtkIdentityTransform_InternalTransformVector_05(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601DABF RID: 121535
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdentityTransform_Inverse_06(HandleRef pThis);

		/// <summary>
		/// Apply the transformation to a combination of points, normals
		/// and vectors.
		/// </summary>
		// Token: 0x0601DAC0 RID: 121536 RVA: 0x0029E4E9 File Offset: 0x0029C6E9
		public override void Inverse()
		{
			vtkIdentityTransform.vtkIdentityTransform_Inverse_06(base.GetCppThis());
		}

		// Token: 0x0601DAC1 RID: 121537
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdentityTransform_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAC2 RID: 121538 RVA: 0x0029E4F8 File Offset: 0x0029C6F8
		public override int IsA(string type)
		{
			return vtkIdentityTransform.vtkIdentityTransform_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601DAC3 RID: 121539
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdentityTransform_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAC4 RID: 121540 RVA: 0x0029E518 File Offset: 0x0029C718
		public new static int IsTypeOf(string type)
		{
			return vtkIdentityTransform.vtkIdentityTransform_IsTypeOf_08(type);
		}

		// Token: 0x0601DAC5 RID: 121541
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdentityTransform_MakeTransform_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make a transform of the same type.  This will actually
		/// return the same transform.
		/// </summary>
		// Token: 0x0601DAC6 RID: 121542 RVA: 0x0029E534 File Offset: 0x0029C734
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdentityTransform.vtkIdentityTransform_MakeTransform_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DAC7 RID: 121543
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdentityTransform_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAC8 RID: 121544 RVA: 0x0029E590 File Offset: 0x0029C790
		public new vtkIdentityTransform NewInstance()
		{
			vtkIdentityTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdentityTransform.vtkIdentityTransform_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdentityTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DAC9 RID: 121545
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdentityTransform_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DACA RID: 121546 RVA: 0x0029E5EC File Offset: 0x0029C7EC
		public new static vtkIdentityTransform SafeDownCast(vtkObjectBase o)
		{
			vtkIdentityTransform vtkIdentityTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdentityTransform.vtkIdentityTransform_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdentityTransform = (vtkIdentityTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdentityTransform.Register(null);
				}
			}
			return vtkIdentityTransform;
		}

		// Token: 0x0601DACB RID: 121547
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdentityTransform_TransformNormals_13(HandleRef pThis, HandleRef inNms, HandleRef outNms);

		/// <summary>
		/// Apply the transformation to a series of normals, and append the
		/// results to outNms.
		/// </summary>
		// Token: 0x0601DACC RID: 121548 RVA: 0x0029E66C File Offset: 0x0029C86C
		public override void TransformNormals(vtkDataArray inNms, vtkDataArray outNms)
		{
			vtkIdentityTransform.vtkIdentityTransform_TransformNormals_13(base.GetCppThis(), (inNms == null) ? default(HandleRef) : inNms.GetCppThis(), (outNms == null) ? default(HandleRef) : outNms.GetCppThis());
		}

		// Token: 0x0601DACD RID: 121549
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdentityTransform_TransformPoints_14(HandleRef pThis, HandleRef inPts, HandleRef outPts);

		/// <summary>
		/// Apply the transformation to a series of points, and append the
		/// results to outPts.
		/// </summary>
		// Token: 0x0601DACE RID: 121550 RVA: 0x0029E6B0 File Offset: 0x0029C8B0
		public override void TransformPoints(vtkPoints inPts, vtkPoints outPts)
		{
			vtkIdentityTransform.vtkIdentityTransform_TransformPoints_14(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis());
		}

		// Token: 0x0601DACF RID: 121551
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdentityTransform_TransformVectors_15(HandleRef pThis, HandleRef inVrs, HandleRef outVrs);

		/// <summary>
		/// Apply the transformation to a series of vectors, and append the
		/// results to outVrs.
		/// </summary>
		// Token: 0x0601DAD0 RID: 121552 RVA: 0x0029E6F4 File Offset: 0x0029C8F4
		public override void TransformVectors(vtkDataArray inVrs, vtkDataArray outVrs)
		{
			vtkIdentityTransform.vtkIdentityTransform_TransformVectors_15(base.GetCppThis(), (inVrs == null) ? default(HandleRef) : inVrs.GetCppThis(), (outVrs == null) ? default(HandleRef) : outVrs.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F41 RID: 8001
		public new const string MRFullTypeName = "Kitware.VTK.vtkIdentityTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F42 RID: 8002
		public new static readonly string MRClassNameKey = "class vtkIdentityTransform";
	}
}
