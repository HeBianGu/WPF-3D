using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageEuclideanDistance
	/// </summary>
	/// <remarks>
	///    computes 3D Euclidean DT
	///
	/// vtkImageEuclideanDistance implements the Euclidean DT using
	/// Saito's algorithm. The distance map produced contains the square of the
	/// Euclidean distance values.
	///
	/// The algorithm has a o(n^(D+1)) complexity over nxnx...xn images in D
	/// dimensions. It is very efficient on relatively small images. Cuisenaire's
	/// algorithms should be used instead if n &gt;&gt; 500. These are not implemented
	/// yet.
	///
	/// For the special case of images where the slice-size is a multiple of
	/// 2^N with a large N (typically for 256x256 slices), Saito's algorithm
	/// encounters a lot of cache conflicts during the 3rd iteration which can
	/// slow it very significantly. In that case, one should use
	/// vtkImageEuclideanDistance::SetAlgorithmToSaitoCached() instead for better performance.
	///
	/// References:
	///
	/// T. Saito and J.I. Toriwaki. New algorithms for Euclidean distance
	/// transformations of an n-dimensional digitised picture with applications.
	/// Pattern Recognition, 27(11). pp. 1551--1565, 1994.
	///
	/// O. Cuisenaire. Distance Transformation: fast algorithms and applications
	/// to medical image processing. PhD Thesis, Universite catholique de Louvain,
	/// October 1999. http://ltswww.epfl.ch/~cuisenai/papers/oc_thesis.pdf
	/// </remarks>
	// Token: 0x02000483 RID: 1155
	public class vtkImageEuclideanDistance : vtkImageDecomposeFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D48D RID: 54413 RVA: 0x00127C2F File Offset: 0x00125E2F
		static vtkImageEuclideanDistance()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageEuclideanDistance.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageEuclideanDistance"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D48E RID: 54414 RVA: 0x00127C57 File Offset: 0x00125E57
		public vtkImageEuclideanDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D48F RID: 54415
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageEuclideanDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D490 RID: 54416 RVA: 0x00127C68 File Offset: 0x00125E68
		public new static vtkImageEuclideanDistance New()
		{
			vtkImageEuclideanDistance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageEuclideanDistance.vtkImageEuclideanDistance_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageEuclideanDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D491 RID: 54417 RVA: 0x00127CBC File Offset: 0x00125EBC
		public vtkImageEuclideanDistance() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageEuclideanDistance.vtkImageEuclideanDistance_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D492 RID: 54418 RVA: 0x00127D00 File Offset: 0x00125F00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D493 RID: 54419
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEuclideanDistance_ConsiderAnisotropyOff_01(HandleRef pThis);

		/// <summary>
		/// Used to define whether Spacing should be used in the computation of the
		/// distances
		/// </summary>
		// Token: 0x0600D494 RID: 54420 RVA: 0x00127D0B File Offset: 0x00125F0B
		public virtual void ConsiderAnisotropyOff()
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_ConsiderAnisotropyOff_01(base.GetCppThis());
		}

		// Token: 0x0600D495 RID: 54421
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEuclideanDistance_ConsiderAnisotropyOn_02(HandleRef pThis);

		/// <summary>
		/// Used to define whether Spacing should be used in the computation of the
		/// distances
		/// </summary>
		// Token: 0x0600D496 RID: 54422 RVA: 0x00127D1A File Offset: 0x00125F1A
		public virtual void ConsiderAnisotropyOn()
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_ConsiderAnisotropyOn_02(base.GetCppThis());
		}

		// Token: 0x0600D497 RID: 54423
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageEuclideanDistance_GetAlgorithm_03(HandleRef pThis);

		/// <summary>
		/// Selects a Euclidean DT algorithm.
		/// 1. Saito
		/// 2. Saito-cached
		/// More algorithms will be added later on.
		/// </summary>
		// Token: 0x0600D498 RID: 54424 RVA: 0x00127D2C File Offset: 0x00125F2C
		public virtual int GetAlgorithm()
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_GetAlgorithm_03(base.GetCppThis());
		}

		// Token: 0x0600D499 RID: 54425
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageEuclideanDistance_GetConsiderAnisotropy_04(HandleRef pThis);

		/// <summary>
		/// Used to define whether Spacing should be used in the computation of the
		/// distances
		/// </summary>
		// Token: 0x0600D49A RID: 54426 RVA: 0x00127D4C File Offset: 0x00125F4C
		public virtual int GetConsiderAnisotropy()
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_GetConsiderAnisotropy_04(base.GetCppThis());
		}

		// Token: 0x0600D49B RID: 54427
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageEuclideanDistance_GetInitialize_05(HandleRef pThis);

		/// <summary>
		/// Used to set all non-zero voxels to MaximumDistance before starting
		/// the distance transformation. Setting Initialize off keeps the current
		/// value in the input image as starting point. This allows to superimpose
		/// several distance maps.
		/// </summary>
		// Token: 0x0600D49C RID: 54428 RVA: 0x00127D6C File Offset: 0x00125F6C
		public virtual int GetInitialize()
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_GetInitialize_05(base.GetCppThis());
		}

		// Token: 0x0600D49D RID: 54429
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageEuclideanDistance_GetMaximumDistance_06(HandleRef pThis);

		/// <summary>
		/// Any distance bigger than this-&gt;MaximumDistance will not ne computed but
		/// set to this-&gt;MaximumDistance instead.
		/// </summary>
		// Token: 0x0600D49E RID: 54430 RVA: 0x00127D8C File Offset: 0x00125F8C
		public virtual double GetMaximumDistance()
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_GetMaximumDistance_06(base.GetCppThis());
		}

		// Token: 0x0600D49F RID: 54431
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageEuclideanDistance_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4A0 RID: 54432 RVA: 0x00127DAC File Offset: 0x00125FAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600D4A1 RID: 54433
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageEuclideanDistance_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4A2 RID: 54434 RVA: 0x00127DCC File Offset: 0x00125FCC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600D4A3 RID: 54435
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEuclideanDistance_InitializeOff_09(HandleRef pThis);

		/// <summary>
		/// Used to set all non-zero voxels to MaximumDistance before starting
		/// the distance transformation. Setting Initialize off keeps the current
		/// value in the input image as starting point. This allows to superimpose
		/// several distance maps.
		/// </summary>
		// Token: 0x0600D4A4 RID: 54436 RVA: 0x00127DE6 File Offset: 0x00125FE6
		public virtual void InitializeOff()
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_InitializeOff_09(base.GetCppThis());
		}

		// Token: 0x0600D4A5 RID: 54437
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEuclideanDistance_InitializeOn_10(HandleRef pThis);

		/// <summary>
		/// Used to set all non-zero voxels to MaximumDistance before starting
		/// the distance transformation. Setting Initialize off keeps the current
		/// value in the input image as starting point. This allows to superimpose
		/// several distance maps.
		/// </summary>
		// Token: 0x0600D4A6 RID: 54438 RVA: 0x00127DF5 File Offset: 0x00125FF5
		public virtual void InitializeOn()
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_InitializeOn_10(base.GetCppThis());
		}

		// Token: 0x0600D4A7 RID: 54439
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageEuclideanDistance_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4A8 RID: 54440 RVA: 0x00127E04 File Offset: 0x00126004
		public override int IsA(string type)
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600D4A9 RID: 54441
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageEuclideanDistance_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4AA RID: 54442 RVA: 0x00127E24 File Offset: 0x00126024
		public new static int IsTypeOf(string type)
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_IsTypeOf_12(type);
		}

		// Token: 0x0600D4AB RID: 54443
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageEuclideanDistance_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4AC RID: 54444 RVA: 0x00127E40 File Offset: 0x00126040
		public new vtkImageEuclideanDistance NewInstance()
		{
			vtkImageEuclideanDistance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageEuclideanDistance.vtkImageEuclideanDistance_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageEuclideanDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D4AD RID: 54445
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageEuclideanDistance_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4AE RID: 54446 RVA: 0x00127E9C File Offset: 0x0012609C
		public new static vtkImageEuclideanDistance SafeDownCast(vtkObjectBase o)
		{
			vtkImageEuclideanDistance vtkImageEuclideanDistance = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageEuclideanDistance.vtkImageEuclideanDistance_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageEuclideanDistance = (vtkImageEuclideanDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageEuclideanDistance.Register(null);
				}
			}
			return vtkImageEuclideanDistance;
		}

		// Token: 0x0600D4AF RID: 54447
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEuclideanDistance_SetAlgorithm_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Selects a Euclidean DT algorithm.
		/// 1. Saito
		/// 2. Saito-cached
		/// More algorithms will be added later on.
		/// </summary>
		// Token: 0x0600D4B0 RID: 54448 RVA: 0x00127F1B File Offset: 0x0012611B
		public virtual void SetAlgorithm(int _arg)
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_SetAlgorithm_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D4B1 RID: 54449
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEuclideanDistance_SetAlgorithmToSaito_17(HandleRef pThis);

		/// <summary>
		/// Selects a Euclidean DT algorithm.
		/// 1. Saito
		/// 2. Saito-cached
		/// More algorithms will be added later on.
		/// </summary>
		// Token: 0x0600D4B2 RID: 54450 RVA: 0x00127F2B File Offset: 0x0012612B
		public void SetAlgorithmToSaito()
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_SetAlgorithmToSaito_17(base.GetCppThis());
		}

		// Token: 0x0600D4B3 RID: 54451
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEuclideanDistance_SetAlgorithmToSaitoCached_18(HandleRef pThis);

		/// <summary>
		/// Selects a Euclidean DT algorithm.
		/// 1. Saito
		/// 2. Saito-cached
		/// More algorithms will be added later on.
		/// </summary>
		// Token: 0x0600D4B4 RID: 54452 RVA: 0x00127F3A File Offset: 0x0012613A
		public void SetAlgorithmToSaitoCached()
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_SetAlgorithmToSaitoCached_18(base.GetCppThis());
		}

		// Token: 0x0600D4B5 RID: 54453
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEuclideanDistance_SetConsiderAnisotropy_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Used to define whether Spacing should be used in the computation of the
		/// distances
		/// </summary>
		// Token: 0x0600D4B6 RID: 54454 RVA: 0x00127F49 File Offset: 0x00126149
		public virtual void SetConsiderAnisotropy(int _arg)
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_SetConsiderAnisotropy_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D4B7 RID: 54455
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEuclideanDistance_SetInitialize_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Used to set all non-zero voxels to MaximumDistance before starting
		/// the distance transformation. Setting Initialize off keeps the current
		/// value in the input image as starting point. This allows to superimpose
		/// several distance maps.
		/// </summary>
		// Token: 0x0600D4B8 RID: 54456 RVA: 0x00127F59 File Offset: 0x00126159
		public virtual void SetInitialize(int _arg)
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_SetInitialize_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D4B9 RID: 54457
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEuclideanDistance_SetMaximumDistance_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Any distance bigger than this-&gt;MaximumDistance will not ne computed but
		/// set to this-&gt;MaximumDistance instead.
		/// </summary>
		// Token: 0x0600D4BA RID: 54458 RVA: 0x00127F69 File Offset: 0x00126169
		public virtual void SetMaximumDistance(double _arg)
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_SetMaximumDistance_21(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FAE RID: 4014
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageEuclideanDistance";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FAF RID: 4015
		public new static readonly string MRClassNameKey = "class vtkImageEuclideanDistance";
	}
}
