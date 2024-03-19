using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLandmarkTransform
	/// </summary>
	/// <remarks>
	///    a linear transform specified by two corresponding point sets
	///
	/// A vtkLandmarkTransform is defined by two sets of landmarks, the
	/// transform computed gives the best fit mapping one onto the other, in a
	/// least squares sense. The indices are taken to correspond, so point 1
	/// in the first set will get mapped close to point 1 in the second set,
	/// etc. Call SetSourceLandmarks and SetTargetLandmarks to specify the two
	/// sets of landmarks, ensure they have the same number of points.
	/// @warning
	/// Whenever you add, subtract, or set points you must call Modified()
	/// on the vtkPoints object, or the transformation might not update.
	/// </remarks>
	/// <seealso>
	///
	/// vtkLinearTransform
	/// </seealso>
	// Token: 0x02000B09 RID: 2825
	public class vtkLandmarkTransform : vtkLinearTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DAD1 RID: 121553 RVA: 0x0029E738 File Offset: 0x0029C938
		static vtkLandmarkTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLandmarkTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLandmarkTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DAD2 RID: 121554 RVA: 0x0029E760 File Offset: 0x0029C960
		public vtkLandmarkTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DAD3 RID: 121555
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLandmarkTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAD4 RID: 121556 RVA: 0x0029E770 File Offset: 0x0029C970
		public new static vtkLandmarkTransform New()
		{
			vtkLandmarkTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLandmarkTransform.vtkLandmarkTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLandmarkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAD5 RID: 121557 RVA: 0x0029E7C4 File Offset: 0x0029C9C4
		public vtkLandmarkTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLandmarkTransform.vtkLandmarkTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DAD6 RID: 121558 RVA: 0x0029E808 File Offset: 0x0029CA08
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DAD7 RID: 121559
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkLandmarkTransform_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// Get the MTime.
		/// </summary>
		// Token: 0x0601DAD8 RID: 121560 RVA: 0x0029E814 File Offset: 0x0029CA14
		public override ulong GetMTime()
		{
			return vtkLandmarkTransform.vtkLandmarkTransform_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x0601DAD9 RID: 121561
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLandmarkTransform_GetMode_02(HandleRef pThis);

		/// <summary>
		/// Get the current transformation mode.
		/// </summary>
		// Token: 0x0601DADA RID: 121562 RVA: 0x0029E834 File Offset: 0x0029CA34
		public virtual int GetMode()
		{
			return vtkLandmarkTransform.vtkLandmarkTransform_GetMode_02(base.GetCppThis());
		}

		// Token: 0x0601DADB RID: 121563
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLandmarkTransform_GetModeAsString_03(HandleRef pThis);

		/// <summary>
		/// Get the current transformation mode.
		/// </summary>
		// Token: 0x0601DADC RID: 121564 RVA: 0x0029E854 File Offset: 0x0029CA54
		public string GetModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkLandmarkTransform.vtkLandmarkTransform_GetModeAsString_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601DADD RID: 121565
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLandmarkTransform_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DADE RID: 121566 RVA: 0x0029E890 File Offset: 0x0029CA90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLandmarkTransform.vtkLandmarkTransform_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601DADF RID: 121567
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLandmarkTransform_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAE0 RID: 121568 RVA: 0x0029E8B0 File Offset: 0x0029CAB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLandmarkTransform.vtkLandmarkTransform_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601DAE1 RID: 121569
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLandmarkTransform_GetSourceLandmarks_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the source and target landmark sets. The two sets must have
		/// the same number of points.  If you add or change points in these objects,
		/// you must call Modified() on them or the transformation might not update.
		/// </summary>
		// Token: 0x0601DAE2 RID: 121570 RVA: 0x0029E8CC File Offset: 0x0029CACC
		public virtual vtkPoints GetSourceLandmarks()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLandmarkTransform.vtkLandmarkTransform_GetSourceLandmarks_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0601DAE3 RID: 121571
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLandmarkTransform_GetTargetLandmarks_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the source and target landmark sets. The two sets must have
		/// the same number of points.  If you add or change points in these objects,
		/// you must call Modified() on them or the transformation might not update.
		/// </summary>
		// Token: 0x0601DAE4 RID: 121572 RVA: 0x0029E93C File Offset: 0x0029CB3C
		public virtual vtkPoints GetTargetLandmarks()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLandmarkTransform.vtkLandmarkTransform_GetTargetLandmarks_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0601DAE5 RID: 121573
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLandmarkTransform_Inverse_08(HandleRef pThis);

		/// <summary>
		/// Invert the transformation.  This is done by switching the
		/// source and target landmarks.
		/// </summary>
		// Token: 0x0601DAE6 RID: 121574 RVA: 0x0029E9AB File Offset: 0x0029CBAB
		public override void Inverse()
		{
			vtkLandmarkTransform.vtkLandmarkTransform_Inverse_08(base.GetCppThis());
		}

		// Token: 0x0601DAE7 RID: 121575
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLandmarkTransform_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAE8 RID: 121576 RVA: 0x0029E9BC File Offset: 0x0029CBBC
		public override int IsA(string type)
		{
			return vtkLandmarkTransform.vtkLandmarkTransform_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601DAE9 RID: 121577
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLandmarkTransform_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAEA RID: 121578 RVA: 0x0029E9DC File Offset: 0x0029CBDC
		public new static int IsTypeOf(string type)
		{
			return vtkLandmarkTransform.vtkLandmarkTransform_IsTypeOf_10(type);
		}

		// Token: 0x0601DAEB RID: 121579
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLandmarkTransform_MakeTransform_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make another transform of the same type.
		/// </summary>
		// Token: 0x0601DAEC RID: 121580 RVA: 0x0029E9F8 File Offset: 0x0029CBF8
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLandmarkTransform.vtkLandmarkTransform_MakeTransform_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DAED RID: 121581
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLandmarkTransform_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAEE RID: 121582 RVA: 0x0029EA54 File Offset: 0x0029CC54
		public new vtkLandmarkTransform NewInstance()
		{
			vtkLandmarkTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLandmarkTransform.vtkLandmarkTransform_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLandmarkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DAEF RID: 121583
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLandmarkTransform_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DAF0 RID: 121584 RVA: 0x0029EAB0 File Offset: 0x0029CCB0
		public new static vtkLandmarkTransform SafeDownCast(vtkObjectBase o)
		{
			vtkLandmarkTransform vtkLandmarkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLandmarkTransform.vtkLandmarkTransform_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLandmarkTransform = (vtkLandmarkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLandmarkTransform.Register(null);
				}
			}
			return vtkLandmarkTransform;
		}

		// Token: 0x0601DAF1 RID: 121585
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLandmarkTransform_SetMode_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of degrees of freedom to constrain the solution to.
		/// Rigidbody (VTK_LANDMARK_RIGIDBODY): rotation and translation only.
		/// Similarity (VTK_LANDMARK_SIMILARITY): rotation, translation and
		/// isotropic scaling.
		/// Affine (VTK_LANDMARK_AFFINE): collinearity is preserved.
		/// Ratios of distances along a line are preserved.
		/// The default is similarity.
		/// </summary>
		// Token: 0x0601DAF2 RID: 121586 RVA: 0x0029EB2F File Offset: 0x0029CD2F
		public virtual void SetMode(int _arg)
		{
			vtkLandmarkTransform.vtkLandmarkTransform_SetMode_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DAF3 RID: 121587
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLandmarkTransform_SetModeToAffine_16(HandleRef pThis);

		/// <summary>
		/// Set the number of degrees of freedom to constrain the solution to.
		/// Rigidbody (VTK_LANDMARK_RIGIDBODY): rotation and translation only.
		/// Similarity (VTK_LANDMARK_SIMILARITY): rotation, translation and
		/// isotropic scaling.
		/// Affine (VTK_LANDMARK_AFFINE): collinearity is preserved.
		/// Ratios of distances along a line are preserved.
		/// The default is similarity.
		/// </summary>
		// Token: 0x0601DAF4 RID: 121588 RVA: 0x0029EB3F File Offset: 0x0029CD3F
		public void SetModeToAffine()
		{
			vtkLandmarkTransform.vtkLandmarkTransform_SetModeToAffine_16(base.GetCppThis());
		}

		// Token: 0x0601DAF5 RID: 121589
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLandmarkTransform_SetModeToRigidBody_17(HandleRef pThis);

		/// <summary>
		/// Set the number of degrees of freedom to constrain the solution to.
		/// Rigidbody (VTK_LANDMARK_RIGIDBODY): rotation and translation only.
		/// Similarity (VTK_LANDMARK_SIMILARITY): rotation, translation and
		/// isotropic scaling.
		/// Affine (VTK_LANDMARK_AFFINE): collinearity is preserved.
		/// Ratios of distances along a line are preserved.
		/// The default is similarity.
		/// </summary>
		// Token: 0x0601DAF6 RID: 121590 RVA: 0x0029EB4E File Offset: 0x0029CD4E
		public void SetModeToRigidBody()
		{
			vtkLandmarkTransform.vtkLandmarkTransform_SetModeToRigidBody_17(base.GetCppThis());
		}

		// Token: 0x0601DAF7 RID: 121591
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLandmarkTransform_SetModeToSimilarity_18(HandleRef pThis);

		/// <summary>
		/// Set the number of degrees of freedom to constrain the solution to.
		/// Rigidbody (VTK_LANDMARK_RIGIDBODY): rotation and translation only.
		/// Similarity (VTK_LANDMARK_SIMILARITY): rotation, translation and
		/// isotropic scaling.
		/// Affine (VTK_LANDMARK_AFFINE): collinearity is preserved.
		/// Ratios of distances along a line are preserved.
		/// The default is similarity.
		/// </summary>
		// Token: 0x0601DAF8 RID: 121592 RVA: 0x0029EB5D File Offset: 0x0029CD5D
		public void SetModeToSimilarity()
		{
			vtkLandmarkTransform.vtkLandmarkTransform_SetModeToSimilarity_18(base.GetCppThis());
		}

		// Token: 0x0601DAF9 RID: 121593
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLandmarkTransform_SetSourceLandmarks_19(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the source and target landmark sets. The two sets must have
		/// the same number of points.  If you add or change points in these objects,
		/// you must call Modified() on them or the transformation might not update.
		/// </summary>
		// Token: 0x0601DAFA RID: 121594 RVA: 0x0029EB6C File Offset: 0x0029CD6C
		public void SetSourceLandmarks(vtkPoints source)
		{
			vtkLandmarkTransform.vtkLandmarkTransform_SetSourceLandmarks_19(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DAFB RID: 121595
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLandmarkTransform_SetTargetLandmarks_20(HandleRef pThis, HandleRef target);

		/// <summary>
		/// Specify the source and target landmark sets. The two sets must have
		/// the same number of points.  If you add or change points in these objects,
		/// you must call Modified() on them or the transformation might not update.
		/// </summary>
		// Token: 0x0601DAFC RID: 121596 RVA: 0x0029EB9C File Offset: 0x0029CD9C
		public void SetTargetLandmarks(vtkPoints target)
		{
			vtkLandmarkTransform.vtkLandmarkTransform_SetTargetLandmarks_20(base.GetCppThis(), (target == null) ? default(HandleRef) : target.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F43 RID: 8003
		public new const string MRFullTypeName = "Kitware.VTK.vtkLandmarkTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F44 RID: 8004
		public new static readonly string MRClassNameKey = "class vtkLandmarkTransform";
	}
}
