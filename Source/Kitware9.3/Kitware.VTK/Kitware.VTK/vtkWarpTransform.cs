using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWarpTransform
	/// </summary>
	/// <remarks>
	///    superclass for nonlinear geometric transformations
	///
	/// vtkWarpTransform provides a generic interface for nonlinear
	/// warp transformations.
	/// </remarks>
	/// <seealso>
	///
	/// vtkThinPlateSplineTransform vtkGridTransform vtkGeneralTransform
	/// </seealso>
	// Token: 0x02000601 RID: 1537
	public abstract class vtkWarpTransform : vtkAbstractTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010B35 RID: 68405 RVA: 0x00174B57 File Offset: 0x00172D57
		static vtkWarpTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWarpTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010B36 RID: 68406 RVA: 0x00174B7F File Offset: 0x00172D7F
		public vtkWarpTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010B37 RID: 68407 RVA: 0x00174B8D File Offset: 0x00172D8D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010B38 RID: 68408
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpTransform_GetInverseFlag_01(HandleRef pThis);

		/// <summary>
		/// Get the inverse flag of the transformation.  This flag is
		/// set to zero when the transformation is first created, and
		/// is flipped each time Inverse() is called.
		/// </summary>
		// Token: 0x06010B39 RID: 68409 RVA: 0x00174B98 File Offset: 0x00172D98
		public virtual int GetInverseFlag()
		{
			return vtkWarpTransform.vtkWarpTransform_GetInverseFlag_01(base.GetCppThis());
		}

		// Token: 0x06010B3A RID: 68410
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpTransform_GetInverseIterations_02(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of iterations for the inverse
		/// transformation.  The default is 500, but usually only
		/// 2 to 5 iterations are used.  The inversion method
		/// is fairly robust, and it should converge for nearly all smooth
		/// transformations that do not fold back on themselves.
		/// </summary>
		// Token: 0x06010B3B RID: 68411 RVA: 0x00174BB8 File Offset: 0x00172DB8
		public virtual int GetInverseIterations()
		{
			return vtkWarpTransform.vtkWarpTransform_GetInverseIterations_02(base.GetCppThis());
		}

		// Token: 0x06010B3C RID: 68412
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWarpTransform_GetInverseTolerance_03(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for inverse transformation.
		/// The default is 0.001.
		/// </summary>
		// Token: 0x06010B3D RID: 68413 RVA: 0x00174BD8 File Offset: 0x00172DD8
		public virtual double GetInverseTolerance()
		{
			return vtkWarpTransform.vtkWarpTransform_GetInverseTolerance_03(base.GetCppThis());
		}

		// Token: 0x06010B3E RID: 68414
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWarpTransform_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B3F RID: 68415 RVA: 0x00174BF8 File Offset: 0x00172DF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWarpTransform.vtkWarpTransform_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06010B40 RID: 68416
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWarpTransform_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B41 RID: 68417 RVA: 0x00174C18 File Offset: 0x00172E18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWarpTransform.vtkWarpTransform_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06010B42 RID: 68418
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTransform_InternalTransformPoint_06(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// This will calculate the transformation without calling Update.
		/// Meant for use only within other VTK classes.
		/// </summary>
		// Token: 0x06010B43 RID: 68419 RVA: 0x00174C32 File Offset: 0x00172E32
		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkWarpTransform.vtkWarpTransform_InternalTransformPoint_06(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x06010B44 RID: 68420
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTransform_Inverse_07(HandleRef pThis);

		/// <summary>
		/// Invert the transformation.  Warp transformations are usually
		/// inverted using an iterative technique such as Newton's method.
		/// The inverse transform is usually around five or six times as
		/// computationally expensive as the forward transform.
		/// </summary>
		// Token: 0x06010B45 RID: 68421 RVA: 0x00174C43 File Offset: 0x00172E43
		public override void Inverse()
		{
			vtkWarpTransform.vtkWarpTransform_Inverse_07(base.GetCppThis());
		}

		// Token: 0x06010B46 RID: 68422
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpTransform_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B47 RID: 68423 RVA: 0x00174C54 File Offset: 0x00172E54
		public override int IsA(string type)
		{
			return vtkWarpTransform.vtkWarpTransform_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06010B48 RID: 68424
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpTransform_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B49 RID: 68425 RVA: 0x00174C74 File Offset: 0x00172E74
		public new static int IsTypeOf(string type)
		{
			return vtkWarpTransform.vtkWarpTransform_IsTypeOf_09(type);
		}

		// Token: 0x06010B4A RID: 68426
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpTransform_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B4B RID: 68427 RVA: 0x00174C90 File Offset: 0x00172E90
		public new vtkWarpTransform NewInstance()
		{
			vtkWarpTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpTransform.vtkWarpTransform_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010B4C RID: 68428
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpTransform_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B4D RID: 68429 RVA: 0x00174CEC File Offset: 0x00172EEC
		public new static vtkWarpTransform SafeDownCast(vtkObjectBase o)
		{
			vtkWarpTransform vtkWarpTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpTransform.vtkWarpTransform_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWarpTransform = (vtkWarpTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWarpTransform.Register(null);
				}
			}
			return vtkWarpTransform;
		}

		// Token: 0x06010B4E RID: 68430
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTransform_SetInverseIterations_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the maximum number of iterations for the inverse
		/// transformation.  The default is 500, but usually only
		/// 2 to 5 iterations are used.  The inversion method
		/// is fairly robust, and it should converge for nearly all smooth
		/// transformations that do not fold back on themselves.
		/// </summary>
		// Token: 0x06010B4F RID: 68431 RVA: 0x00174D6B File Offset: 0x00172F6B
		public virtual void SetInverseIterations(int _arg)
		{
			vtkWarpTransform.vtkWarpTransform_SetInverseIterations_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06010B50 RID: 68432
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTransform_SetInverseTolerance_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the tolerance for inverse transformation.
		/// The default is 0.001.
		/// </summary>
		// Token: 0x06010B51 RID: 68433 RVA: 0x00174D7B File Offset: 0x00172F7B
		public virtual void SetInverseTolerance(double _arg)
		{
			vtkWarpTransform.vtkWarpTransform_SetInverseTolerance_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06010B52 RID: 68434
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTransform_TemplateTransformInverse_14(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Do not use these methods.  They exists only as a work-around for
		/// internal templated functions (I really didn't want to make the
		/// Forward/Inverse methods public, is there a decent work around
		/// for this sort of thing?)
		/// </summary>
		// Token: 0x06010B53 RID: 68435 RVA: 0x00174D8B File Offset: 0x00172F8B
		public void TemplateTransformInverse(IntPtr arg0, IntPtr arg1)
		{
			vtkWarpTransform.vtkWarpTransform_TemplateTransformInverse_14(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x06010B54 RID: 68436
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTransform_TemplateTransformPoint_15(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Do not use these methods.  They exists only as a work-around for
		/// internal templated functions (I really didn't want to make the
		/// Forward/Inverse methods public, is there a decent work around
		/// for this sort of thing?)
		/// </summary>
		// Token: 0x06010B55 RID: 68437 RVA: 0x00174D9C File Offset: 0x00172F9C
		public void TemplateTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkWarpTransform.vtkWarpTransform_TemplateTransformPoint_15(base.GetCppThis(), arg0, arg1);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001358 RID: 4952
		public new const string MRFullTypeName = "Kitware.VTK.vtkWarpTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001359 RID: 4953
		public new static readonly string MRClassNameKey = "class vtkWarpTransform";
	}
}
