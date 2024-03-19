using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkThinPlateSplineTransform
	/// </summary>
	/// <remarks>
	///    a nonlinear warp transformation
	///
	/// vtkThinPlateSplineTransform describes a nonlinear warp transform defined
	/// by a set of source and target landmarks. Any point on the mesh close to a
	/// source landmark will be moved to a place close to the corresponding target
	/// landmark. The points in between are interpolated smoothly using
	/// Bookstein's Thin Plate Spline algorithm.
	///
	/// To obtain a correct TPS warp, use the R2LogR kernel if your data is 2D, and
	/// the R kernel if your data is 3D. Or you can specify your own RBF. (Hence this
	/// class is more general than a pure TPS transform.)
	/// @warning
	/// 1) The inverse transform is calculated using an iterative method,
	/// and is several times more expensive than the forward transform.
	/// 2) Whenever you add, subtract, or set points you must call Modified()
	/// on the vtkPoints object, or the transformation might not update.
	/// 3) Collinear point configurations (except those that lie in the XY plane)
	/// result in an unstable transformation. Forward transform can be computed
	/// for any configuration by disabling bulk transform regularization.
	/// </remarks>
	/// <seealso>
	///
	/// vtkGridTransform vtkGeneralTransform
	/// </seealso>
	// Token: 0x02000B0E RID: 2830
	public class vtkThinPlateSplineTransform : vtkWarpTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DBA5 RID: 121765 RVA: 0x0029FBBF File Offset: 0x0029DDBF
		static vtkThinPlateSplineTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThinPlateSplineTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThinPlateSplineTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DBA6 RID: 121766 RVA: 0x0029FBE7 File Offset: 0x0029DDE7
		public vtkThinPlateSplineTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DBA7 RID: 121767
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThinPlateSplineTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBA8 RID: 121768 RVA: 0x0029FBF8 File Offset: 0x0029DDF8
		public new static vtkThinPlateSplineTransform New()
		{
			vtkThinPlateSplineTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThinPlateSplineTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBA9 RID: 121769 RVA: 0x0029FC4C File Offset: 0x0029DE4C
		public vtkThinPlateSplineTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DBAA RID: 121770 RVA: 0x0029FC90 File Offset: 0x0029DE90
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DBAB RID: 121771
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThinPlateSplineTransform_GetBasis_01(HandleRef pThis);

		/// <summary>
		/// Specify the radial basis function to use.  The default is
		/// R2LogR which is appropriate for 2D. Use |R| (SetBasisToR)
		/// if your data is 3D. Alternatively specify your own basis function,
		/// however this will mean that the transform will no longer be a true
		/// thin-plate spline.
		/// </summary>
		// Token: 0x0601DBAC RID: 121772 RVA: 0x0029FC9C File Offset: 0x0029DE9C
		public virtual int GetBasis()
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetBasis_01(base.GetCppThis());
		}

		// Token: 0x0601DBAD RID: 121773
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThinPlateSplineTransform_GetBasisAsString_02(HandleRef pThis);

		/// <summary>
		/// Specify the radial basis function to use.  The default is
		/// R2LogR which is appropriate for 2D. Use |R| (SetBasisToR)
		/// if your data is 3D. Alternatively specify your own basis function,
		/// however this will mean that the transform will no longer be a true
		/// thin-plate spline.
		/// </summary>
		// Token: 0x0601DBAE RID: 121774 RVA: 0x0029FCBC File Offset: 0x0029DEBC
		public string GetBasisAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetBasisAsString_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601DBAF RID: 121775
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkThinPlateSplineTransform_GetMTime_03(HandleRef pThis);

		/// <summary>
		/// Get the MTime.
		/// </summary>
		// Token: 0x0601DBB0 RID: 121776 RVA: 0x0029FCF8 File Offset: 0x0029DEF8
		public override ulong GetMTime()
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetMTime_03(base.GetCppThis());
		}

		// Token: 0x0601DBB1 RID: 121777
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThinPlateSplineTransform_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBB2 RID: 121778 RVA: 0x0029FD18 File Offset: 0x0029DF18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601DBB3 RID: 121779
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThinPlateSplineTransform_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBB4 RID: 121780 RVA: 0x0029FD38 File Offset: 0x0029DF38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601DBB5 RID: 121781
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkThinPlateSplineTransform_GetRegularizeBulkTransform_06(HandleRef pThis);

		/// <summary>
		/// Get/set whether the bulk linear transformation matrix is regularized.
		///
		/// If regularization is enabled: If all landmark points are on the
		/// XY plane then forward and inverse transforms are computed correctly.
		/// For other coplanar configurations, both forward an inverse transform
		/// computation is unstable.
		///
		/// If regularization is disabled: Forward transform is computed correctly
		/// for all point configurations. Inverse transform computation is unstable
		/// if source and/or target points are coplanar.
		///
		/// If landmarks points are not coplanar then this setting has no effect.
		///
		/// The default is true.
		/// </summary>
		// Token: 0x0601DBB6 RID: 121782 RVA: 0x0029FD54 File Offset: 0x0029DF54
		public virtual bool GetRegularizeBulkTransform()
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetRegularizeBulkTransform_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0601DBB7 RID: 121783
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkThinPlateSplineTransform_GetSigma_07(HandleRef pThis);

		/// <summary>
		/// Specify the 'stiffness' of the spline. The default is 1.0.
		/// </summary>
		// Token: 0x0601DBB8 RID: 121784 RVA: 0x0029FD7C File Offset: 0x0029DF7C
		public virtual double GetSigma()
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetSigma_07(base.GetCppThis());
		}

		// Token: 0x0601DBB9 RID: 121785
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThinPlateSplineTransform_GetSourceLandmarks_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the source landmarks for the warp.  If you add or change the
		/// vtkPoints object, you must call Modified() on it or the transformation
		/// might not update.
		/// </summary>
		// Token: 0x0601DBBA RID: 121786 RVA: 0x0029FD9C File Offset: 0x0029DF9C
		public virtual vtkPoints GetSourceLandmarks()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetSourceLandmarks_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DBBB RID: 121787
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThinPlateSplineTransform_GetTargetLandmarks_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the target landmarks for the warp.  If you add or change the
		/// vtkPoints object, you must call Modified() on it or the transformation
		/// might not update.
		/// </summary>
		// Token: 0x0601DBBC RID: 121788 RVA: 0x0029FE0C File Offset: 0x0029E00C
		public virtual vtkPoints GetTargetLandmarks()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetTargetLandmarks_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DBBD RID: 121789
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThinPlateSplineTransform_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBBE RID: 121790 RVA: 0x0029FE7C File Offset: 0x0029E07C
		public override int IsA(string type)
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601DBBF RID: 121791
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThinPlateSplineTransform_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBC0 RID: 121792 RVA: 0x0029FE9C File Offset: 0x0029E09C
		public new static int IsTypeOf(string type)
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_IsTypeOf_11(type);
		}

		// Token: 0x0601DBC1 RID: 121793
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThinPlateSplineTransform_MakeTransform_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make another transform of the same type.
		/// </summary>
		// Token: 0x0601DBC2 RID: 121794 RVA: 0x0029FEB8 File Offset: 0x0029E0B8
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_MakeTransform_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DBC3 RID: 121795
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThinPlateSplineTransform_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBC4 RID: 121796 RVA: 0x0029FF14 File Offset: 0x0029E114
		public new vtkThinPlateSplineTransform NewInstance()
		{
			vtkThinPlateSplineTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThinPlateSplineTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DBC5 RID: 121797
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThinPlateSplineTransform_RegularizeBulkTransformOff_15(HandleRef pThis);

		/// <summary>
		/// Get/set whether the bulk linear transformation matrix is regularized.
		///
		/// If regularization is enabled: If all landmark points are on the
		/// XY plane then forward and inverse transforms are computed correctly.
		/// For other coplanar configurations, both forward an inverse transform
		/// computation is unstable.
		///
		/// If regularization is disabled: Forward transform is computed correctly
		/// for all point configurations. Inverse transform computation is unstable
		/// if source and/or target points are coplanar.
		///
		/// If landmarks points are not coplanar then this setting has no effect.
		///
		/// The default is true.
		/// </summary>
		// Token: 0x0601DBC6 RID: 121798 RVA: 0x0029FF6E File Offset: 0x0029E16E
		public virtual void RegularizeBulkTransformOff()
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_RegularizeBulkTransformOff_15(base.GetCppThis());
		}

		// Token: 0x0601DBC7 RID: 121799
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThinPlateSplineTransform_RegularizeBulkTransformOn_16(HandleRef pThis);

		/// <summary>
		/// Get/set whether the bulk linear transformation matrix is regularized.
		///
		/// If regularization is enabled: If all landmark points are on the
		/// XY plane then forward and inverse transforms are computed correctly.
		/// For other coplanar configurations, both forward an inverse transform
		/// computation is unstable.
		///
		/// If regularization is disabled: Forward transform is computed correctly
		/// for all point configurations. Inverse transform computation is unstable
		/// if source and/or target points are coplanar.
		///
		/// If landmarks points are not coplanar then this setting has no effect.
		///
		/// The default is true.
		/// </summary>
		// Token: 0x0601DBC8 RID: 121800 RVA: 0x0029FF7D File Offset: 0x0029E17D
		public virtual void RegularizeBulkTransformOn()
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_RegularizeBulkTransformOn_16(base.GetCppThis());
		}

		// Token: 0x0601DBC9 RID: 121801
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThinPlateSplineTransform_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBCA RID: 121802 RVA: 0x0029FF8C File Offset: 0x0029E18C
		public new static vtkThinPlateSplineTransform SafeDownCast(vtkObjectBase o)
		{
			vtkThinPlateSplineTransform vtkThinPlateSplineTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThinPlateSplineTransform = (vtkThinPlateSplineTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThinPlateSplineTransform.Register(null);
				}
			}
			return vtkThinPlateSplineTransform;
		}

		// Token: 0x0601DBCB RID: 121803
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThinPlateSplineTransform_SetBasis_18(HandleRef pThis, int basis);

		/// <summary>
		/// Specify the radial basis function to use.  The default is
		/// R2LogR which is appropriate for 2D. Use |R| (SetBasisToR)
		/// if your data is 3D. Alternatively specify your own basis function,
		/// however this will mean that the transform will no longer be a true
		/// thin-plate spline.
		/// </summary>
		// Token: 0x0601DBCC RID: 121804 RVA: 0x002A000B File Offset: 0x0029E20B
		public void SetBasis(int basis)
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetBasis_18(base.GetCppThis(), basis);
		}

		// Token: 0x0601DBCD RID: 121805
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThinPlateSplineTransform_SetBasisToR_19(HandleRef pThis);

		/// <summary>
		/// Specify the radial basis function to use.  The default is
		/// R2LogR which is appropriate for 2D. Use |R| (SetBasisToR)
		/// if your data is 3D. Alternatively specify your own basis function,
		/// however this will mean that the transform will no longer be a true
		/// thin-plate spline.
		/// </summary>
		// Token: 0x0601DBCE RID: 121806 RVA: 0x002A001B File Offset: 0x0029E21B
		public void SetBasisToR()
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetBasisToR_19(base.GetCppThis());
		}

		// Token: 0x0601DBCF RID: 121807
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThinPlateSplineTransform_SetBasisToR2LogR_20(HandleRef pThis);

		/// <summary>
		/// Specify the radial basis function to use.  The default is
		/// R2LogR which is appropriate for 2D. Use |R| (SetBasisToR)
		/// if your data is 3D. Alternatively specify your own basis function,
		/// however this will mean that the transform will no longer be a true
		/// thin-plate spline.
		/// </summary>
		// Token: 0x0601DBD0 RID: 121808 RVA: 0x002A002A File Offset: 0x0029E22A
		public void SetBasisToR2LogR()
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetBasisToR2LogR_20(base.GetCppThis());
		}

		// Token: 0x0601DBD1 RID: 121809
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThinPlateSplineTransform_SetRegularizeBulkTransform_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/set whether the bulk linear transformation matrix is regularized.
		///
		/// If regularization is enabled: If all landmark points are on the
		/// XY plane then forward and inverse transforms are computed correctly.
		/// For other coplanar configurations, both forward an inverse transform
		/// computation is unstable.
		///
		/// If regularization is disabled: Forward transform is computed correctly
		/// for all point configurations. Inverse transform computation is unstable
		/// if source and/or target points are coplanar.
		///
		/// If landmarks points are not coplanar then this setting has no effect.
		///
		/// The default is true.
		/// </summary>
		// Token: 0x0601DBD2 RID: 121810 RVA: 0x002A0039 File Offset: 0x0029E239
		public virtual void SetRegularizeBulkTransform(bool _arg)
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetRegularizeBulkTransform_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601DBD3 RID: 121811
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThinPlateSplineTransform_SetSigma_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the 'stiffness' of the spline. The default is 1.0.
		/// </summary>
		// Token: 0x0601DBD4 RID: 121812 RVA: 0x002A0051 File Offset: 0x0029E251
		public virtual void SetSigma(double _arg)
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetSigma_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DBD5 RID: 121813
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThinPlateSplineTransform_SetSourceLandmarks_23(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Set the source landmarks for the warp.  If you add or change the
		/// vtkPoints object, you must call Modified() on it or the transformation
		/// might not update.
		/// </summary>
		// Token: 0x0601DBD6 RID: 121814 RVA: 0x002A0064 File Offset: 0x0029E264
		public void SetSourceLandmarks(vtkPoints source)
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetSourceLandmarks_23(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DBD7 RID: 121815
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThinPlateSplineTransform_SetTargetLandmarks_24(HandleRef pThis, HandleRef target);

		/// <summary>
		/// Set the target landmarks for the warp.  If you add or change the
		/// vtkPoints object, you must call Modified() on it or the transformation
		/// might not update.
		/// </summary>
		// Token: 0x0601DBD8 RID: 121816 RVA: 0x002A0094 File Offset: 0x0029E294
		public void SetTargetLandmarks(vtkPoints target)
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetTargetLandmarks_24(base.GetCppThis(), (target == null) ? default(HandleRef) : target.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F4D RID: 8013
		public new const string MRFullTypeName = "Kitware.VTK.vtkThinPlateSplineTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F4E RID: 8014
		public new static readonly string MRClassNameKey = "class vtkThinPlateSplineTransform";
	}
}
