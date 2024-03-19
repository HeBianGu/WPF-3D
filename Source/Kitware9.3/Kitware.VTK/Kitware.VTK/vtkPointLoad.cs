using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointLoad
	/// </summary>
	/// <remarks>
	///    compute stress tensors given point load on semi-infinite domain
	///
	/// vtkPointLoad is a source object that computes stress tensors on a volume.
	/// The tensors are computed from the application of a point load on a
	/// semi-infinite domain. (The analytical results are adapted from Saada - see
	/// text.) It also is possible to compute effective stress scalars if desired.
	/// This object serves as a specialized data generator for some of the examples
	/// in the text.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTensorGlyph vtkHyperStreamline vtkGlyphPackingFilter
	/// </seealso>
	// Token: 0x020003E6 RID: 998
	public class vtkPointLoad : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BF2B RID: 48939 RVA: 0x0010A75B File Offset: 0x0010895B
		static vtkPointLoad()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointLoad.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointLoad"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BF2C RID: 48940 RVA: 0x0010A783 File Offset: 0x00108983
		public vtkPointLoad(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600BF2D RID: 48941
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointLoad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with ModelBounds=(-1,1,-1,1,-1,1), SampleDimensions=(50,50,50),
		/// and LoadValue = 1.
		/// </summary>
		// Token: 0x0600BF2E RID: 48942 RVA: 0x0010A794 File Offset: 0x00108994
		public new static vtkPointLoad New()
		{
			vtkPointLoad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointLoad.vtkPointLoad_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointLoad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with ModelBounds=(-1,1,-1,1,-1,1), SampleDimensions=(50,50,50),
		/// and LoadValue = 1.
		/// </summary>
		// Token: 0x0600BF2F RID: 48943 RVA: 0x0010A7E8 File Offset: 0x001089E8
		public vtkPointLoad() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointLoad.vtkPointLoad_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BF30 RID: 48944 RVA: 0x0010A82C File Offset: 0x00108A2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BF31 RID: 48945
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLoad_ComputeEffectiveStressOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off computation of effective stress scalar. These methods do
		/// nothing. The effective stress is always computed.
		/// </summary>
		// Token: 0x0600BF32 RID: 48946 RVA: 0x0010A837 File Offset: 0x00108A37
		public void ComputeEffectiveStressOff()
		{
			vtkPointLoad.vtkPointLoad_ComputeEffectiveStressOff_01(base.GetCppThis());
		}

		// Token: 0x0600BF33 RID: 48947
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLoad_ComputeEffectiveStressOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off computation of effective stress scalar. These methods do
		/// nothing. The effective stress is always computed.
		/// </summary>
		// Token: 0x0600BF34 RID: 48948 RVA: 0x0010A846 File Offset: 0x00108A46
		public void ComputeEffectiveStressOn()
		{
			vtkPointLoad.vtkPointLoad_ComputeEffectiveStressOn_02(base.GetCppThis());
		}

		// Token: 0x0600BF35 RID: 48949
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointLoad_GetComputeEffectiveStress_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off computation of effective stress scalar. These methods do
		/// nothing. The effective stress is always computed.
		/// </summary>
		// Token: 0x0600BF36 RID: 48950 RVA: 0x0010A858 File Offset: 0x00108A58
		public int GetComputeEffectiveStress()
		{
			return vtkPointLoad.vtkPointLoad_GetComputeEffectiveStress_03(base.GetCppThis());
		}

		// Token: 0x0600BF37 RID: 48951
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointLoad_GetLoadValue_04(HandleRef pThis);

		/// <summary>
		/// Set/Get value of applied load.
		/// </summary>
		// Token: 0x0600BF38 RID: 48952 RVA: 0x0010A878 File Offset: 0x00108A78
		public virtual double GetLoadValue()
		{
			return vtkPointLoad.vtkPointLoad_GetLoadValue_04(base.GetCppThis());
		}

		// Token: 0x0600BF39 RID: 48953
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointLoad_GetModelBounds_05(HandleRef pThis);

		/// <summary>
		/// Specify the region in space over which the tensors are computed. The point
		/// load is assumed to be applied at top center of the volume.
		/// </summary>
		// Token: 0x0600BF3A RID: 48954 RVA: 0x0010A898 File Offset: 0x00108A98
		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkPointLoad.vtkPointLoad_GetModelBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BF3B RID: 48955
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLoad_GetModelBounds_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the region in space over which the tensors are computed. The point
		/// load is assumed to be applied at top center of the volume.
		/// </summary>
		// Token: 0x0600BF3C RID: 48956 RVA: 0x0010A8E0 File Offset: 0x00108AE0
		public virtual void GetModelBounds(IntPtr data)
		{
			vtkPointLoad.vtkPointLoad_GetModelBounds_06(base.GetCppThis(), data);
		}

		// Token: 0x0600BF3D RID: 48957
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointLoad_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x0600BF3E RID: 48958 RVA: 0x0010A8F0 File Offset: 0x00108AF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointLoad.vtkPointLoad_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600BF3F RID: 48959
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointLoad_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x0600BF40 RID: 48960 RVA: 0x0010A910 File Offset: 0x00108B10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointLoad.vtkPointLoad_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600BF41 RID: 48961
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointLoad_GetPoissonsRatio_09(HandleRef pThis);

		/// <summary>
		/// Set/Get Poisson's ratio.
		/// </summary>
		// Token: 0x0600BF42 RID: 48962 RVA: 0x0010A92C File Offset: 0x00108B2C
		public virtual double GetPoissonsRatio()
		{
			return vtkPointLoad.vtkPointLoad_GetPoissonsRatio_09(base.GetCppThis());
		}

		// Token: 0x0600BF43 RID: 48963
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointLoad_GetSampleDimensions_10(HandleRef pThis);

		/// <summary>
		/// Specify the dimensions of the volume. A stress tensor will be computed for
		/// each point in the volume.
		/// </summary>
		// Token: 0x0600BF44 RID: 48964 RVA: 0x0010A94C File Offset: 0x00108B4C
		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkPointLoad.vtkPointLoad_GetSampleDimensions_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BF45 RID: 48965
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLoad_GetSampleDimensions_11(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the dimensions of the volume. A stress tensor will be computed for
		/// each point in the volume.
		/// </summary>
		// Token: 0x0600BF46 RID: 48966 RVA: 0x0010A994 File Offset: 0x00108B94
		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkPointLoad.vtkPointLoad_GetSampleDimensions_11(base.GetCppThis(), data);
		}

		// Token: 0x0600BF47 RID: 48967
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointLoad_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x0600BF48 RID: 48968 RVA: 0x0010A9A4 File Offset: 0x00108BA4
		public override int IsA(string type)
		{
			return vtkPointLoad.vtkPointLoad_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600BF49 RID: 48969
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointLoad_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x0600BF4A RID: 48970 RVA: 0x0010A9C4 File Offset: 0x00108BC4
		public new static int IsTypeOf(string type)
		{
			return vtkPointLoad.vtkPointLoad_IsTypeOf_13(type);
		}

		// Token: 0x0600BF4B RID: 48971
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointLoad_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x0600BF4C RID: 48972 RVA: 0x0010A9E0 File Offset: 0x00108BE0
		public new vtkPointLoad NewInstance()
		{
			vtkPointLoad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointLoad.vtkPointLoad_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointLoad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BF4D RID: 48973
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointLoad_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x0600BF4E RID: 48974 RVA: 0x0010AA3C File Offset: 0x00108C3C
		public new static vtkPointLoad SafeDownCast(vtkObjectBase o)
		{
			vtkPointLoad vtkPointLoad = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointLoad.vtkPointLoad_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointLoad = (vtkPointLoad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointLoad.Register(null);
				}
			}
			return vtkPointLoad;
		}

		// Token: 0x0600BF4F RID: 48975
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLoad_SetComputeEffectiveStress_17(HandleRef pThis, int arg0);

		/// <summary>
		/// Turn on/off computation of effective stress scalar. These methods do
		/// nothing. The effective stress is always computed.
		/// </summary>
		// Token: 0x0600BF50 RID: 48976 RVA: 0x0010AABB File Offset: 0x00108CBB
		public void SetComputeEffectiveStress(int arg0)
		{
			vtkPointLoad.vtkPointLoad_SetComputeEffectiveStress_17(base.GetCppThis(), arg0);
		}

		// Token: 0x0600BF51 RID: 48977
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLoad_SetLoadValue_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get value of applied load.
		/// </summary>
		// Token: 0x0600BF52 RID: 48978 RVA: 0x0010AACB File Offset: 0x00108CCB
		public virtual void SetLoadValue(double _arg)
		{
			vtkPointLoad.vtkPointLoad_SetLoadValue_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BF53 RID: 48979
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLoad_SetModelBounds_19(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Specify the region in space over which the tensors are computed. The point
		/// load is assumed to be applied at top center of the volume.
		/// </summary>
		// Token: 0x0600BF54 RID: 48980 RVA: 0x0010AADB File Offset: 0x00108CDB
		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkPointLoad.vtkPointLoad_SetModelBounds_19(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600BF55 RID: 48981
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLoad_SetModelBounds_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the region in space over which the tensors are computed. The point
		/// load is assumed to be applied at top center of the volume.
		/// </summary>
		// Token: 0x0600BF56 RID: 48982 RVA: 0x0010AAF3 File Offset: 0x00108CF3
		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkPointLoad.vtkPointLoad_SetModelBounds_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BF57 RID: 48983
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLoad_SetPoissonsRatio_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get Poisson's ratio.
		/// </summary>
		// Token: 0x0600BF58 RID: 48984 RVA: 0x0010AB03 File Offset: 0x00108D03
		public virtual void SetPoissonsRatio(double _arg)
		{
			vtkPointLoad.vtkPointLoad_SetPoissonsRatio_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BF59 RID: 48985
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLoad_SetSampleDimensions_22(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Specify the dimensions of the volume. A stress tensor will be computed for
		/// each point in the volume.
		/// </summary>
		// Token: 0x0600BF5A RID: 48986 RVA: 0x0010AB13 File Offset: 0x00108D13
		public void SetSampleDimensions(IntPtr dim)
		{
			vtkPointLoad.vtkPointLoad_SetSampleDimensions_22(base.GetCppThis(), dim);
		}

		// Token: 0x0600BF5B RID: 48987
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLoad_SetSampleDimensions_23(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Specify the dimensions of the volume. A stress tensor will be computed for
		/// each point in the volume.
		/// </summary>
		// Token: 0x0600BF5C RID: 48988 RVA: 0x0010AB23 File Offset: 0x00108D23
		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkPointLoad.vtkPointLoad_SetSampleDimensions_23(base.GetCppThis(), i, j, k);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E39 RID: 3641
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointLoad";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E3A RID: 3642
		public new static readonly string MRClassNameKey = "class vtkPointLoad";
	}
}
