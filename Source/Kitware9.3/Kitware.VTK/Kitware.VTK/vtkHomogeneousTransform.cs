using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHomogeneousTransform
	/// </summary>
	/// <remarks>
	///    superclass for homogeneous transformations
	///
	/// vtkHomogeneousTransform provides a generic interface for homogeneous
	/// transformations, i.e. transformations which can be represented by
	/// multiplying a 4x4 matrix with a homogeneous coordinate.
	/// </remarks>
	/// <seealso>
	///
	/// vtkPerspectiveTransform vtkLinearTransform vtkIdentityTransform
	/// </seealso>
	// Token: 0x02000A72 RID: 2674
	public abstract class vtkHomogeneousTransform : vtkAbstractTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C018 RID: 114712 RVA: 0x00273E3C File Offset: 0x0027203C
		static vtkHomogeneousTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHomogeneousTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHomogeneousTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C019 RID: 114713 RVA: 0x00273E64 File Offset: 0x00272064
		public vtkHomogeneousTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C01A RID: 114714 RVA: 0x00273E72 File Offset: 0x00272072
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C01B RID: 114715
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHomogeneousTransform_GetHomogeneousInverse_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Just like GetInverse(), but includes typecast to vtkHomogeneousTransform.
		/// </summary>
		// Token: 0x0601C01C RID: 114716 RVA: 0x00273E80 File Offset: 0x00272080
		public vtkHomogeneousTransform GetHomogeneousInverse()
		{
			vtkHomogeneousTransform vtkHomogeneousTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHomogeneousTransform.vtkHomogeneousTransform_GetHomogeneousInverse_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHomogeneousTransform = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHomogeneousTransform.Register(null);
				}
			}
			return vtkHomogeneousTransform;
		}

		// Token: 0x0601C01D RID: 114717
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHomogeneousTransform_GetMatrix_02(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Get a copy of the internal transformation matrix.  The
		/// transform is Updated first, to guarantee that the matrix
		/// is valid.
		/// </summary>
		// Token: 0x0601C01E RID: 114718 RVA: 0x00273EF0 File Offset: 0x002720F0
		public void GetMatrix(vtkMatrix4x4 m)
		{
			vtkHomogeneousTransform.vtkHomogeneousTransform_GetMatrix_02(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x0601C01F RID: 114719
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHomogeneousTransform_GetMatrix_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to an internal vtkMatrix4x4 that represents
		/// the transformation.  An Update() is called on the transform
		/// to ensure that the matrix is up-to-date when you get it.
		/// You should not store the matrix pointer anywhere because it
		/// might become stale.
		/// </summary>
		// Token: 0x0601C020 RID: 114720 RVA: 0x00273F20 File Offset: 0x00272120
		public vtkMatrix4x4 GetMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHomogeneousTransform.vtkHomogeneousTransform_GetMatrix_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C021 RID: 114721
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHomogeneousTransform_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C022 RID: 114722 RVA: 0x00273F90 File Offset: 0x00272190
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHomogeneousTransform.vtkHomogeneousTransform_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601C023 RID: 114723
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHomogeneousTransform_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C024 RID: 114724 RVA: 0x00273FB0 File Offset: 0x002721B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHomogeneousTransform.vtkHomogeneousTransform_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601C025 RID: 114725
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHomogeneousTransform_InternalTransformPoint_06(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// This will calculate the transformation without calling Update.
		/// Meant for use only within other VTK classes.
		/// </summary>
		// Token: 0x0601C026 RID: 114726 RVA: 0x00273FCA File Offset: 0x002721CA
		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkHomogeneousTransform.vtkHomogeneousTransform_InternalTransformPoint_06(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601C027 RID: 114727
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHomogeneousTransform_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C028 RID: 114728 RVA: 0x00273FDC File Offset: 0x002721DC
		public override int IsA(string type)
		{
			return vtkHomogeneousTransform.vtkHomogeneousTransform_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601C029 RID: 114729
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHomogeneousTransform_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C02A RID: 114730 RVA: 0x00273FFC File Offset: 0x002721FC
		public new static int IsTypeOf(string type)
		{
			return vtkHomogeneousTransform.vtkHomogeneousTransform_IsTypeOf_08(type);
		}

		// Token: 0x0601C02B RID: 114731
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHomogeneousTransform_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C02C RID: 114732 RVA: 0x00274018 File Offset: 0x00272218
		public new vtkHomogeneousTransform NewInstance()
		{
			vtkHomogeneousTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHomogeneousTransform.vtkHomogeneousTransform_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C02D RID: 114733
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHomogeneousTransform_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C02E RID: 114734 RVA: 0x00274074 File Offset: 0x00272274
		public new static vtkHomogeneousTransform SafeDownCast(vtkObjectBase o)
		{
			vtkHomogeneousTransform vtkHomogeneousTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHomogeneousTransform.vtkHomogeneousTransform_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHomogeneousTransform = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHomogeneousTransform.Register(null);
				}
			}
			return vtkHomogeneousTransform;
		}

		// Token: 0x0601C02F RID: 114735
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHomogeneousTransform_TransformPoints_11(HandleRef pThis, HandleRef inPts, HandleRef outPts);

		/// <summary>
		/// Apply the transformation to a series of points, and append the
		/// results to outPts.
		/// </summary>
		// Token: 0x0601C030 RID: 114736 RVA: 0x002740F4 File Offset: 0x002722F4
		public override void TransformPoints(vtkPoints inPts, vtkPoints outPts)
		{
			vtkHomogeneousTransform.vtkHomogeneousTransform_TransformPoints_11(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DDB RID: 7643
		public new const string MRFullTypeName = "Kitware.VTK.vtkHomogeneousTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DDC RID: 7644
		public new static readonly string MRClassNameKey = "class vtkHomogeneousTransform";
	}
}
