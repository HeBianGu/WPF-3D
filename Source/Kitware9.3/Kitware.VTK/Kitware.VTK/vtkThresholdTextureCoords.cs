using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkThresholdTextureCoords
	/// </summary>
	/// <remarks>
	///    compute 1D, 2D, or 3D texture coordinates based on scalar threshold
	///
	/// vtkThresholdTextureCoords is a filter that generates texture coordinates for
	/// any input dataset type given a threshold criterion. The criterion can take
	/// three forms: 1) greater than a particular value (ThresholdByUpper());
	/// 2) less than a particular value (ThresholdByLower(); or 3) between two
	/// values (ThresholdBetween(). If the threshold criterion is satisfied,
	/// the "in" texture coordinate will be set (this can be specified by the
	/// user). If the threshold criterion is not satisfied the "out" is set.
	///
	/// @warning
	/// There is a texture map - texThres.vtk - that can be used in conjunction
	/// with this filter. This map defines a "transparent" region for texture
	/// coordinates 0&lt;=r&lt;0.5, and an opaque full intensity map for texture
	/// coordinates 0.5&lt;r&lt;=1.0. There is a small transition region for r=0.5.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkThreshold vtkThresholdPoints vtkTextureMapToPlane vtkTextureMapToSphere
	/// vtkTextureMapToCylinder
	/// </seealso>
	// Token: 0x02000543 RID: 1347
	public class vtkThresholdTextureCoords : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EFD3 RID: 61395 RVA: 0x0014E525 File Offset: 0x0014C725
		static vtkThresholdTextureCoords()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThresholdTextureCoords.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThresholdTextureCoords"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EFD4 RID: 61396 RVA: 0x0014E54D File Offset: 0x0014C74D
		public vtkThresholdTextureCoords(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EFD5 RID: 61397
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdTextureCoords_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EFD6 RID: 61398 RVA: 0x0014E55C File Offset: 0x0014C75C
		public new static vtkThresholdTextureCoords New()
		{
			vtkThresholdTextureCoords result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdTextureCoords.vtkThresholdTextureCoords_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdTextureCoords)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EFD7 RID: 61399 RVA: 0x0014E5B0 File Offset: 0x0014C7B0
		public vtkThresholdTextureCoords() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkThresholdTextureCoords.vtkThresholdTextureCoords_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EFD8 RID: 61400 RVA: 0x0014E5F4 File Offset: 0x0014C7F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EFD9 RID: 61401
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdTextureCoords_GetInTextureCoord_01(HandleRef pThis);

		/// <summary>
		/// Set the texture coordinate value for point satisfying threshold criterion.
		/// </summary>
		// Token: 0x0600EFDA RID: 61402 RVA: 0x0014E600 File Offset: 0x0014C800
		public virtual double[] GetInTextureCoord()
		{
			IntPtr intPtr = vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetInTextureCoord_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EFDB RID: 61403
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTextureCoords_GetInTextureCoord_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the texture coordinate value for point satisfying threshold criterion.
		/// </summary>
		// Token: 0x0600EFDC RID: 61404 RVA: 0x0014E648 File Offset: 0x0014C848
		public virtual void GetInTextureCoord(IntPtr data)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetInTextureCoord_02(base.GetCppThis(), data);
		}

		// Token: 0x0600EFDD RID: 61405
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkThresholdTextureCoords_GetLowerThreshold_03(HandleRef pThis);

		/// <summary>
		/// Return the upper and lower thresholds.
		/// </summary>
		// Token: 0x0600EFDE RID: 61406 RVA: 0x0014E658 File Offset: 0x0014C858
		public virtual double GetLowerThreshold()
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetLowerThreshold_03(base.GetCppThis());
		}

		// Token: 0x0600EFDF RID: 61407
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThresholdTextureCoords_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EFE0 RID: 61408 RVA: 0x0014E678 File Offset: 0x0014C878
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600EFE1 RID: 61409
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThresholdTextureCoords_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EFE2 RID: 61410 RVA: 0x0014E698 File Offset: 0x0014C898
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600EFE3 RID: 61411
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdTextureCoords_GetOutTextureCoord_06(HandleRef pThis);

		/// <summary>
		/// Set the texture coordinate value for point NOT satisfying threshold
		/// criterion.
		/// </summary>
		// Token: 0x0600EFE4 RID: 61412 RVA: 0x0014E6B4 File Offset: 0x0014C8B4
		public virtual double[] GetOutTextureCoord()
		{
			IntPtr intPtr = vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetOutTextureCoord_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EFE5 RID: 61413
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTextureCoords_GetOutTextureCoord_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the texture coordinate value for point NOT satisfying threshold
		/// criterion.
		/// </summary>
		// Token: 0x0600EFE6 RID: 61414 RVA: 0x0014E6FC File Offset: 0x0014C8FC
		public virtual void GetOutTextureCoord(IntPtr data)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetOutTextureCoord_07(base.GetCppThis(), data);
		}

		// Token: 0x0600EFE7 RID: 61415
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdTextureCoords_GetTextureDimension_08(HandleRef pThis);

		/// <summary>
		/// Set the desired dimension of the texture map.
		/// </summary>
		// Token: 0x0600EFE8 RID: 61416 RVA: 0x0014E70C File Offset: 0x0014C90C
		public virtual int GetTextureDimension()
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetTextureDimension_08(base.GetCppThis());
		}

		// Token: 0x0600EFE9 RID: 61417
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdTextureCoords_GetTextureDimensionMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set the desired dimension of the texture map.
		/// </summary>
		// Token: 0x0600EFEA RID: 61418 RVA: 0x0014E72C File Offset: 0x0014C92C
		public virtual int GetTextureDimensionMaxValue()
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetTextureDimensionMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600EFEB RID: 61419
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdTextureCoords_GetTextureDimensionMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set the desired dimension of the texture map.
		/// </summary>
		// Token: 0x0600EFEC RID: 61420 RVA: 0x0014E74C File Offset: 0x0014C94C
		public virtual int GetTextureDimensionMinValue()
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetTextureDimensionMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600EFED RID: 61421
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkThresholdTextureCoords_GetUpperThreshold_11(HandleRef pThis);

		/// <summary>
		/// Return the upper and lower thresholds.
		/// </summary>
		// Token: 0x0600EFEE RID: 61422 RVA: 0x0014E76C File Offset: 0x0014C96C
		public virtual double GetUpperThreshold()
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetUpperThreshold_11(base.GetCppThis());
		}

		// Token: 0x0600EFEF RID: 61423
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdTextureCoords_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EFF0 RID: 61424 RVA: 0x0014E78C File Offset: 0x0014C98C
		public override int IsA(string type)
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600EFF1 RID: 61425
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdTextureCoords_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EFF2 RID: 61426 RVA: 0x0014E7AC File Offset: 0x0014C9AC
		public new static int IsTypeOf(string type)
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_IsTypeOf_13(type);
		}

		// Token: 0x0600EFF3 RID: 61427
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdTextureCoords_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EFF4 RID: 61428 RVA: 0x0014E7C8 File Offset: 0x0014C9C8
		public new vtkThresholdTextureCoords NewInstance()
		{
			vtkThresholdTextureCoords result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdTextureCoords.vtkThresholdTextureCoords_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdTextureCoords)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EFF5 RID: 61429
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdTextureCoords_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EFF6 RID: 61430 RVA: 0x0014E824 File Offset: 0x0014CA24
		public new static vtkThresholdTextureCoords SafeDownCast(vtkObjectBase o)
		{
			vtkThresholdTextureCoords vtkThresholdTextureCoords = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdTextureCoords.vtkThresholdTextureCoords_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThresholdTextureCoords = (vtkThresholdTextureCoords)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThresholdTextureCoords.Register(null);
				}
			}
			return vtkThresholdTextureCoords;
		}

		// Token: 0x0600EFF7 RID: 61431
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTextureCoords_SetInTextureCoord_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the texture coordinate value for point satisfying threshold criterion.
		/// </summary>
		// Token: 0x0600EFF8 RID: 61432 RVA: 0x0014E8A3 File Offset: 0x0014CAA3
		public virtual void SetInTextureCoord(double _arg1, double _arg2, double _arg3)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_SetInTextureCoord_17(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600EFF9 RID: 61433
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTextureCoords_SetInTextureCoord_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the texture coordinate value for point satisfying threshold criterion.
		/// </summary>
		// Token: 0x0600EFFA RID: 61434 RVA: 0x0014E8B5 File Offset: 0x0014CAB5
		public virtual void SetInTextureCoord(IntPtr _arg)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_SetInTextureCoord_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EFFB RID: 61435
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTextureCoords_SetOutTextureCoord_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the texture coordinate value for point NOT satisfying threshold
		/// criterion.
		/// </summary>
		// Token: 0x0600EFFC RID: 61436 RVA: 0x0014E8C5 File Offset: 0x0014CAC5
		public virtual void SetOutTextureCoord(double _arg1, double _arg2, double _arg3)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_SetOutTextureCoord_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600EFFD RID: 61437
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTextureCoords_SetOutTextureCoord_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the texture coordinate value for point NOT satisfying threshold
		/// criterion.
		/// </summary>
		// Token: 0x0600EFFE RID: 61438 RVA: 0x0014E8D7 File Offset: 0x0014CAD7
		public virtual void SetOutTextureCoord(IntPtr _arg)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_SetOutTextureCoord_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EFFF RID: 61439
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTextureCoords_SetTextureDimension_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the desired dimension of the texture map.
		/// </summary>
		// Token: 0x0600F000 RID: 61440 RVA: 0x0014E8E7 File Offset: 0x0014CAE7
		public virtual void SetTextureDimension(int _arg)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_SetTextureDimension_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F001 RID: 61441
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTextureCoords_ThresholdBetween_22(HandleRef pThis, double lower, double upper);

		/// <summary>
		/// Criterion is cells whose scalars are between lower and upper thresholds.
		/// </summary>
		// Token: 0x0600F002 RID: 61442 RVA: 0x0014E8F7 File Offset: 0x0014CAF7
		public void ThresholdBetween(double lower, double upper)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_ThresholdBetween_22(base.GetCppThis(), lower, upper);
		}

		// Token: 0x0600F003 RID: 61443
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTextureCoords_ThresholdByLower_23(HandleRef pThis, double lower);

		/// <summary>
		/// Criterion is cells whose scalars are less than lower threshold.
		/// </summary>
		// Token: 0x0600F004 RID: 61444 RVA: 0x0014E908 File Offset: 0x0014CB08
		public void ThresholdByLower(double lower)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_ThresholdByLower_23(base.GetCppThis(), lower);
		}

		// Token: 0x0600F005 RID: 61445
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTextureCoords_ThresholdByUpper_24(HandleRef pThis, double upper);

		/// <summary>
		/// Criterion is cells whose scalars are less than upper threshold.
		/// </summary>
		// Token: 0x0600F006 RID: 61446 RVA: 0x0014E918 File Offset: 0x0014CB18
		public void ThresholdByUpper(double upper)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_ThresholdByUpper_24(base.GetCppThis(), upper);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400117E RID: 4478
		public new const string MRFullTypeName = "Kitware.VTK.vtkThresholdTextureCoords";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400117F RID: 4479
		public new static readonly string MRClassNameKey = "class vtkThresholdTextureCoords";
	}
}
