using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVoxelModeller
	/// </summary>
	/// <remarks>
	///    convert an arbitrary dataset to a voxel representation
	///
	/// vtkVoxelModeller is a filter that converts an arbitrary data set to a
	/// structured point (i.e., voxel) representation. It is very similar to
	/// vtkImplicitModeller, except that it doesn't record distance; instead it
	/// records occupancy. By default it supports a compact output of 0/1
	/// VTK_BIT. Other vtk scalar types can be specified. The Foreground and
	/// Background values of the output can also be specified.
	/// NOTE: Not all vtk filters/readers/writers support the VTK_BIT
	/// scalar type. You may want to use VTK_CHAR as an alternative.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitModeller
	/// </seealso>
	// Token: 0x020003EC RID: 1004
	public class vtkVoxelModeller : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C057 RID: 49239 RVA: 0x0010BF17 File Offset: 0x0010A117
		static vtkVoxelModeller()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVoxelModeller.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoxelModeller"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C058 RID: 49240 RVA: 0x0010BF3F File Offset: 0x0010A13F
		public vtkVoxelModeller(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C059 RID: 49241
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelModeller_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkVoxelModeller with its sample dimensions
		/// set to (50,50,50), and so that the model bounds are
		/// automatically computed from its input. The maximum distance is set to
		/// examine the whole grid. This could be made much faster, and probably
		/// will be in the future.
		/// </summary>
		// Token: 0x0600C05A RID: 49242 RVA: 0x0010BF50 File Offset: 0x0010A150
		public new static vtkVoxelModeller New()
		{
			vtkVoxelModeller result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxelModeller.vtkVoxelModeller_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoxelModeller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct an instance of vtkVoxelModeller with its sample dimensions
		/// set to (50,50,50), and so that the model bounds are
		/// automatically computed from its input. The maximum distance is set to
		/// examine the whole grid. This could be made much faster, and probably
		/// will be in the future.
		/// </summary>
		// Token: 0x0600C05B RID: 49243 RVA: 0x0010BFA4 File Offset: 0x0010A1A4
		public vtkVoxelModeller() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVoxelModeller.vtkVoxelModeller_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C05C RID: 49244 RVA: 0x0010BFE8 File Offset: 0x0010A1E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C05D RID: 49245
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVoxelModeller_ComputeModelBounds_01(HandleRef pThis, IntPtr origin, IntPtr spacing);

		/// <summary>
		/// Compute the ModelBounds based on the input geometry.
		/// </summary>
		// Token: 0x0600C05E RID: 49246 RVA: 0x0010BFF4 File Offset: 0x0010A1F4
		public double ComputeModelBounds(IntPtr origin, IntPtr spacing)
		{
			return vtkVoxelModeller.vtkVoxelModeller_ComputeModelBounds_01(base.GetCppThis(), origin, spacing);
		}

		// Token: 0x0600C05F RID: 49247
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVoxelModeller_GetBackgroundValue_02(HandleRef pThis);

		/// <summary>
		/// Set the Foreground/Background values of the output. The
		/// Foreground value is set when a voxel is occupied. The Background
		/// value is set when a voxel is not occupied.
		/// The default ForegroundValue is 1. The default BackgroundValue is
		/// 0.
		/// </summary>
		// Token: 0x0600C060 RID: 49248 RVA: 0x0010C018 File Offset: 0x0010A218
		public virtual double GetBackgroundValue()
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetBackgroundValue_02(base.GetCppThis());
		}

		// Token: 0x0600C061 RID: 49249
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVoxelModeller_GetForegroundValue_03(HandleRef pThis);

		/// <summary>
		/// Set the Foreground/Background values of the output. The
		/// Foreground value is set when a voxel is occupied. The Background
		/// value is set when a voxel is not occupied.
		/// The default ForegroundValue is 1. The default BackgroundValue is
		/// 0.
		/// </summary>
		// Token: 0x0600C062 RID: 49250 RVA: 0x0010C038 File Offset: 0x0010A238
		public virtual double GetForegroundValue()
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetForegroundValue_03(base.GetCppThis());
		}

		// Token: 0x0600C063 RID: 49251
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVoxelModeller_GetMaximumDistance_04(HandleRef pThis);

		/// <summary>
		/// Specify distance away from surface of input geometry to sample. Smaller
		/// values make large increases in performance. Default is 1.0.
		/// </summary>
		// Token: 0x0600C064 RID: 49252 RVA: 0x0010C058 File Offset: 0x0010A258
		public virtual double GetMaximumDistance()
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetMaximumDistance_04(base.GetCppThis());
		}

		// Token: 0x0600C065 RID: 49253
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVoxelModeller_GetMaximumDistanceMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Specify distance away from surface of input geometry to sample. Smaller
		/// values make large increases in performance. Default is 1.0.
		/// </summary>
		// Token: 0x0600C066 RID: 49254 RVA: 0x0010C078 File Offset: 0x0010A278
		public virtual double GetMaximumDistanceMaxValue()
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetMaximumDistanceMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600C067 RID: 49255
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVoxelModeller_GetMaximumDistanceMinValue_06(HandleRef pThis);

		/// <summary>
		/// Specify distance away from surface of input geometry to sample. Smaller
		/// values make large increases in performance. Default is 1.0.
		/// </summary>
		// Token: 0x0600C068 RID: 49256 RVA: 0x0010C098 File Offset: 0x0010A298
		public virtual double GetMaximumDistanceMinValue()
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetMaximumDistanceMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600C069 RID: 49257
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelModeller_GetModelBounds_07(HandleRef pThis);

		/// <summary>
		/// Specify the position in space to perform the voxelization.
		/// Default is (0, 0, 0, 0, 0, 0)
		/// </summary>
		// Token: 0x0600C06A RID: 49258 RVA: 0x0010C0B8 File Offset: 0x0010A2B8
		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkVoxelModeller.vtkVoxelModeller_GetModelBounds_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C06B RID: 49259
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_GetModelBounds_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the position in space to perform the voxelization.
		/// Default is (0, 0, 0, 0, 0, 0)
		/// </summary>
		// Token: 0x0600C06C RID: 49260 RVA: 0x0010C100 File Offset: 0x0010A300
		public virtual void GetModelBounds(IntPtr data)
		{
			vtkVoxelModeller.vtkVoxelModeller_GetModelBounds_08(base.GetCppThis(), data);
		}

		// Token: 0x0600C06D RID: 49261
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoxelModeller_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C06E RID: 49262 RVA: 0x0010C110 File Offset: 0x0010A310
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0600C06F RID: 49263
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoxelModeller_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C070 RID: 49264 RVA: 0x0010C130 File Offset: 0x0010A330
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0600C071 RID: 49265
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelModeller_GetSampleDimensions_11(HandleRef pThis);

		/// <summary>
		/// Set the i-j-k dimensions on which to sample the distance function.
		/// Default is (50, 50, 50)
		/// </summary>
		// Token: 0x0600C072 RID: 49266 RVA: 0x0010C14C File Offset: 0x0010A34C
		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkVoxelModeller.vtkVoxelModeller_GetSampleDimensions_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C073 RID: 49267
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_GetSampleDimensions_12(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the i-j-k dimensions on which to sample the distance function.
		/// Default is (50, 50, 50)
		/// </summary>
		// Token: 0x0600C074 RID: 49268 RVA: 0x0010C194 File Offset: 0x0010A394
		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkVoxelModeller.vtkVoxelModeller_GetSampleDimensions_12(base.GetCppThis(), data);
		}

		// Token: 0x0600C075 RID: 49269
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxelModeller_GetScalarType_13(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C076 RID: 49270 RVA: 0x0010C1A4 File Offset: 0x0010A3A4
		public virtual int GetScalarType()
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetScalarType_13(base.GetCppThis());
		}

		// Token: 0x0600C077 RID: 49271
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxelModeller_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C078 RID: 49272 RVA: 0x0010C1C4 File Offset: 0x0010A3C4
		public override int IsA(string type)
		{
			return vtkVoxelModeller.vtkVoxelModeller_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0600C079 RID: 49273
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxelModeller_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C07A RID: 49274 RVA: 0x0010C1E4 File Offset: 0x0010A3E4
		public new static int IsTypeOf(string type)
		{
			return vtkVoxelModeller.vtkVoxelModeller_IsTypeOf_15(type);
		}

		// Token: 0x0600C07B RID: 49275
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelModeller_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C07C RID: 49276 RVA: 0x0010C200 File Offset: 0x0010A400
		public new vtkVoxelModeller NewInstance()
		{
			vtkVoxelModeller result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxelModeller.vtkVoxelModeller_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoxelModeller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C07D RID: 49277
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelModeller_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C07E RID: 49278 RVA: 0x0010C25C File Offset: 0x0010A45C
		public new static vtkVoxelModeller SafeDownCast(vtkObjectBase o)
		{
			vtkVoxelModeller vtkVoxelModeller = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxelModeller.vtkVoxelModeller_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVoxelModeller = (vtkVoxelModeller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVoxelModeller.Register(null);
				}
			}
			return vtkVoxelModeller;
		}

		// Token: 0x0600C07F RID: 49279
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetBackgroundValue_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the Foreground/Background values of the output. The
		/// Foreground value is set when a voxel is occupied. The Background
		/// value is set when a voxel is not occupied.
		/// The default ForegroundValue is 1. The default BackgroundValue is
		/// 0.
		/// </summary>
		// Token: 0x0600C080 RID: 49280 RVA: 0x0010C2DB File Offset: 0x0010A4DB
		public virtual void SetBackgroundValue(double _arg)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetBackgroundValue_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C081 RID: 49281
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetForegroundValue_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the Foreground/Background values of the output. The
		/// Foreground value is set when a voxel is occupied. The Background
		/// value is set when a voxel is not occupied.
		/// The default ForegroundValue is 1. The default BackgroundValue is
		/// 0.
		/// </summary>
		// Token: 0x0600C082 RID: 49282 RVA: 0x0010C2EB File Offset: 0x0010A4EB
		public virtual void SetForegroundValue(double _arg)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetForegroundValue_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C083 RID: 49283
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetMaximumDistance_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify distance away from surface of input geometry to sample. Smaller
		/// values make large increases in performance. Default is 1.0.
		/// </summary>
		// Token: 0x0600C084 RID: 49284 RVA: 0x0010C2FB File Offset: 0x0010A4FB
		public virtual void SetMaximumDistance(double _arg)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetMaximumDistance_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C085 RID: 49285
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetModelBounds_22(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Specify the position in space to perform the voxelization.
		/// Default is (0, 0, 0, 0, 0, 0)
		/// </summary>
		// Token: 0x0600C086 RID: 49286 RVA: 0x0010C30B File Offset: 0x0010A50B
		public void SetModelBounds(IntPtr bounds)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetModelBounds_22(base.GetCppThis(), bounds);
		}

		// Token: 0x0600C087 RID: 49287
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetModelBounds_23(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Specify the position in space to perform the voxelization.
		/// Default is (0, 0, 0, 0, 0, 0)
		/// </summary>
		// Token: 0x0600C088 RID: 49288 RVA: 0x0010C31B File Offset: 0x0010A51B
		public void SetModelBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetModelBounds_23(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x0600C089 RID: 49289
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetSampleDimensions_24(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Set the i-j-k dimensions on which to sample the distance function.
		/// Default is (50, 50, 50)
		/// </summary>
		// Token: 0x0600C08A RID: 49290 RVA: 0x0010C333 File Offset: 0x0010A533
		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetSampleDimensions_24(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0600C08B RID: 49291
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetSampleDimensions_25(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set the i-j-k dimensions on which to sample the distance function.
		/// Default is (50, 50, 50)
		/// </summary>
		// Token: 0x0600C08C RID: 49292 RVA: 0x0010C345 File Offset: 0x0010A545
		public void SetSampleDimensions(IntPtr dim)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetSampleDimensions_25(base.GetCppThis(), dim);
		}

		// Token: 0x0600C08D RID: 49293
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetScalarType_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C08E RID: 49294 RVA: 0x0010C355 File Offset: 0x0010A555
		public virtual void SetScalarType(int _arg)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarType_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C08F RID: 49295
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetScalarTypeToBit_27(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C090 RID: 49296 RVA: 0x0010C365 File Offset: 0x0010A565
		public void SetScalarTypeToBit()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToBit_27(base.GetCppThis());
		}

		// Token: 0x0600C091 RID: 49297
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetScalarTypeToChar_28(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C092 RID: 49298 RVA: 0x0010C374 File Offset: 0x0010A574
		public void SetScalarTypeToChar()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToChar_28(base.GetCppThis());
		}

		// Token: 0x0600C093 RID: 49299
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetScalarTypeToDouble_29(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C094 RID: 49300 RVA: 0x0010C383 File Offset: 0x0010A583
		public void SetScalarTypeToDouble()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToDouble_29(base.GetCppThis());
		}

		// Token: 0x0600C095 RID: 49301
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetScalarTypeToFloat_30(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C096 RID: 49302 RVA: 0x0010C392 File Offset: 0x0010A592
		public void SetScalarTypeToFloat()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToFloat_30(base.GetCppThis());
		}

		// Token: 0x0600C097 RID: 49303
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetScalarTypeToInt_31(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C098 RID: 49304 RVA: 0x0010C3A1 File Offset: 0x0010A5A1
		public void SetScalarTypeToInt()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToInt_31(base.GetCppThis());
		}

		// Token: 0x0600C099 RID: 49305
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetScalarTypeToLong_32(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C09A RID: 49306 RVA: 0x0010C3B0 File Offset: 0x0010A5B0
		public void SetScalarTypeToLong()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToLong_32(base.GetCppThis());
		}

		// Token: 0x0600C09B RID: 49307
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetScalarTypeToShort_33(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C09C RID: 49308 RVA: 0x0010C3BF File Offset: 0x0010A5BF
		public void SetScalarTypeToShort()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToShort_33(base.GetCppThis());
		}

		// Token: 0x0600C09D RID: 49309
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetScalarTypeToUnsignedChar_34(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C09E RID: 49310 RVA: 0x0010C3CE File Offset: 0x0010A5CE
		public void SetScalarTypeToUnsignedChar()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToUnsignedChar_34(base.GetCppThis());
		}

		// Token: 0x0600C09F RID: 49311
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetScalarTypeToUnsignedInt_35(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C0A0 RID: 49312 RVA: 0x0010C3DD File Offset: 0x0010A5DD
		public void SetScalarTypeToUnsignedInt()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToUnsignedInt_35(base.GetCppThis());
		}

		// Token: 0x0600C0A1 RID: 49313
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetScalarTypeToUnsignedLong_36(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C0A2 RID: 49314 RVA: 0x0010C3EC File Offset: 0x0010A5EC
		public void SetScalarTypeToUnsignedLong()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToUnsignedLong_36(base.GetCppThis());
		}

		// Token: 0x0600C0A3 RID: 49315
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelModeller_SetScalarTypeToUnsignedShort_37(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output image. The default is
		/// VTK_BIT.
		/// NOTE: Not all filters/readers/writers support the VTK_BIT
		/// scalar type. You may want to use VTK_CHAR as an alternative.
		/// </summary>
		// Token: 0x0600C0A4 RID: 49316 RVA: 0x0010C3FB File Offset: 0x0010A5FB
		public void SetScalarTypeToUnsignedShort()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToUnsignedShort_37(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E45 RID: 3653
		public new const string MRFullTypeName = "Kitware.VTK.vtkVoxelModeller";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E46 RID: 3654
		public new static readonly string MRClassNameKey = "class vtkVoxelModeller";
	}
}
