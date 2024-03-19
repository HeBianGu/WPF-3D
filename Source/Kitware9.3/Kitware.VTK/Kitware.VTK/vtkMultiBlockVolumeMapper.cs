using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkMultiBlockVolumeMapper
	/// \brief Mapper to render volumes defined as vtkMultiBlockDataSet.
	///
	/// vtkMultiBlockVolumeMapper renders vtkMultiBlockDataSet instances containing
	/// vtkImageData blocks (all of the blocks are expected to be vtkImageData). Bounds
	/// containing the full set of blocks are computed so that vtkRenderer can adjust the
	/// clipping planes appropriately.
	///
	/// This mapper creates an instance of vtkSmartVolumeMapper per block to which
	/// it defers the actual rendering.  At render time, blocks (mappers) are sorted
	/// back-to-front and each block is rendered independently.  It attempts to load all
	/// of the blocks at the same time but tries to catch allocation errors in which case
	/// it falls back to using a single mapper instance and reloading data for each block.
	///
	/// Jittering is used to alleviate seam artifacts at the block edges due to the
	/// discontinuous resolution between blocks.  Jittering is enabled by default.
	/// Jittering is only supported in GPURenderMode.
	///
	/// </summary>
	// Token: 0x020000D2 RID: 210
	public class vtkMultiBlockVolumeMapper : vtkVolumeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002C79 RID: 11385 RVA: 0x0004194B File Offset: 0x0003FB4B
		static vtkMultiBlockVolumeMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiBlockVolumeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockVolumeMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002C7A RID: 11386 RVA: 0x00041973 File Offset: 0x0003FB73
		public vtkMultiBlockVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002C7B RID: 11387
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockVolumeMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C7C RID: 11388 RVA: 0x00041984 File Offset: 0x0003FB84
		public new static vtkMultiBlockVolumeMapper New()
		{
			vtkMultiBlockVolumeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C7D RID: 11389 RVA: 0x000419D8 File Offset: 0x0003FBD8
		public vtkMultiBlockVolumeMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002C7E RID: 11390 RVA: 0x00041A1C File Offset: 0x0003FC1C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002C7F RID: 11391
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockVolumeMapper_GetBounds_01(HandleRef pThis);

		/// <summary>
		///  \brief API Superclass
		///  \sa vtkAbstractVolumeMapper
		/// </summary>
		// Token: 0x06002C80 RID: 11392 RVA: 0x00041A28 File Offset: 0x0003FC28
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002C81 RID: 11393
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMultiBlockVolumeMapper_GetGlobalIlluminationReach_02(HandleRef pThis);

		/// <summary>
		/// @copydoc vtkSmartVolumeMapper::SetGlobalIlluminationReach(float)
		/// </summary>
		// Token: 0x06002C82 RID: 11394 RVA: 0x00041A70 File Offset: 0x0003FC70
		public virtual float GetGlobalIlluminationReach()
		{
			return vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_GetGlobalIlluminationReach_02(base.GetCppThis());
		}

		// Token: 0x06002C83 RID: 11395
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockVolumeMapper_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C84 RID: 11396 RVA: 0x00041A90 File Offset: 0x0003FC90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06002C85 RID: 11397
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockVolumeMapper_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C86 RID: 11398 RVA: 0x00041AB0 File Offset: 0x0003FCB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06002C87 RID: 11399
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockVolumeMapper_GetVectorComponent_05(HandleRef pThis);

		/// <summary>
		/// VectorMode interface exposed from vtkSmartVolumeMapper.
		/// </summary>
		// Token: 0x06002C88 RID: 11400 RVA: 0x00041ACC File Offset: 0x0003FCCC
		public virtual int GetVectorComponent()
		{
			return vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_GetVectorComponent_05(base.GetCppThis());
		}

		// Token: 0x06002C89 RID: 11401
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockVolumeMapper_GetVectorMode_06(HandleRef pThis);

		/// <summary>
		/// VectorMode interface exposed from vtkSmartVolumeMapper.
		/// </summary>
		// Token: 0x06002C8A RID: 11402 RVA: 0x00041AEC File Offset: 0x0003FCEC
		public virtual int GetVectorMode()
		{
			return vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_GetVectorMode_06(base.GetCppThis());
		}

		// Token: 0x06002C8B RID: 11403
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMultiBlockVolumeMapper_GetVolumetricScatteringBlending_07(HandleRef pThis);

		/// <summary>
		/// @copydoc vtkSmartVolumeMapper::SetVolumetricScatteringBlending(float)
		/// </summary>
		// Token: 0x06002C8C RID: 11404 RVA: 0x00041B0C File Offset: 0x0003FD0C
		public virtual float GetVolumetricScatteringBlending()
		{
			return vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_GetVolumetricScatteringBlending_07(base.GetCppThis());
		}

		// Token: 0x06002C8D RID: 11405
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockVolumeMapper_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C8E RID: 11406 RVA: 0x00041B2C File Offset: 0x0003FD2C
		public override int IsA(string type)
		{
			return vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06002C8F RID: 11407
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockVolumeMapper_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C90 RID: 11408 RVA: 0x00041B4C File Offset: 0x0003FD4C
		public new static int IsTypeOf(string type)
		{
			return vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_IsTypeOf_09(type);
		}

		// Token: 0x06002C91 RID: 11409
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockVolumeMapper_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C92 RID: 11410 RVA: 0x00041B68 File Offset: 0x0003FD68
		public new vtkMultiBlockVolumeMapper NewInstance()
		{
			vtkMultiBlockVolumeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002C93 RID: 11411
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_ReleaseGraphicsResources_12(HandleRef pThis, HandleRef window);

		/// <summary>
		/// \warning Internal method - not intended for general use, do
		/// NOT use this method outside of the rendering process.
		/// </summary>
		// Token: 0x06002C94 RID: 11412 RVA: 0x00041BC4 File Offset: 0x0003FDC4
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_ReleaseGraphicsResources_12(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x06002C95 RID: 11413
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_Render_13(HandleRef pThis, HandleRef ren, HandleRef vol);

		/// <summary>
		/// Render the current dataset.
		///
		/// \warning Internal method - not intended for general use, do
		/// NOT use this method outside of the rendering process.
		/// </summary>
		// Token: 0x06002C96 RID: 11414 RVA: 0x00041BF4 File Offset: 0x0003FDF4
		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_Render_13(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x06002C97 RID: 11415
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockVolumeMapper_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C98 RID: 11416 RVA: 0x00041C38 File Offset: 0x0003FE38
		public new static vtkMultiBlockVolumeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkMultiBlockVolumeMapper vtkMultiBlockVolumeMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockVolumeMapper = (vtkMultiBlockVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockVolumeMapper.Register(null);
				}
			}
			return vtkMultiBlockVolumeMapper;
		}

		// Token: 0x06002C99 RID: 11417
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SelectScalarArray_15(HandleRef pThis, int arrayNum);

		/// <summary>
		///  \brief API Superclass
		///  \sa vtkAbstractVolumeMapper
		/// </summary>
		// Token: 0x06002C9A RID: 11418 RVA: 0x00041CB7 File Offset: 0x0003FEB7
		public override void SelectScalarArray(int arrayNum)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SelectScalarArray_15(base.GetCppThis(), arrayNum);
		}

		// Token: 0x06002C9B RID: 11419
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SelectScalarArray_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		///  \brief API Superclass
		///  \sa vtkAbstractVolumeMapper
		/// </summary>
		// Token: 0x06002C9C RID: 11420 RVA: 0x00041CC7 File Offset: 0x0003FEC7
		public override void SelectScalarArray(string arrayName)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SelectScalarArray_16(base.GetCppThis(), arrayName);
		}

		// Token: 0x06002C9D RID: 11421
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetArrayAccessMode_17(HandleRef pThis, int accessMode);

		/// <summary>
		///  \brief API Superclass
		///  \sa vtkAbstractVolumeMapper
		/// </summary>
		// Token: 0x06002C9E RID: 11422 RVA: 0x00041CD7 File Offset: 0x0003FED7
		public override void SetArrayAccessMode(int accessMode)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetArrayAccessMode_17(base.GetCppThis(), accessMode);
		}

		// Token: 0x06002C9F RID: 11423
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetBlendMode_18(HandleRef pThis, int mode);

		/// <summary>
		/// Blending mode API from vtkVolumeMapper
		/// \sa vtkVolumeMapper::SetBlendMode
		/// </summary>
		// Token: 0x06002CA0 RID: 11424 RVA: 0x00041CE7 File Offset: 0x0003FEE7
		public override void SetBlendMode(int mode)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetBlendMode_18(base.GetCppThis(), mode);
		}

		// Token: 0x06002CA1 RID: 11425
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetComputeNormalFromOpacity_19(HandleRef pThis, byte val);

		/// <summary>
		/// ComputeNormalFromOpacity exposed
		/// \sa vtkVolumeMapper::SetComputeNormalFromOpacity
		/// </summary>
		// Token: 0x06002CA2 RID: 11426 RVA: 0x00041CF7 File Offset: 0x0003FEF7
		public override void SetComputeNormalFromOpacity(bool val)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetComputeNormalFromOpacity_19(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		// Token: 0x06002CA3 RID: 11427
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetCropping_20(HandleRef pThis, int mode);

		/// <summary>
		/// Cropping API from vtkVolumeMapper
		/// \sa vtkVolumeMapper::SetCropping
		/// </summary>
		// Token: 0x06002CA4 RID: 11428 RVA: 0x00041D0F File Offset: 0x0003FF0F
		public override void SetCropping(int mode)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetCropping_20(base.GetCppThis(), mode);
		}

		// Token: 0x06002CA5 RID: 11429
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetCroppingRegionFlags_21(HandleRef pThis, int mode);

		/// <summary>
		/// \sa vtkVolumeMapper::SetCroppingRegionFlags
		/// </summary>
		// Token: 0x06002CA6 RID: 11430 RVA: 0x00041D1F File Offset: 0x0003FF1F
		public override void SetCroppingRegionFlags(int mode)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetCroppingRegionFlags_21(base.GetCppThis(), mode);
		}

		// Token: 0x06002CA7 RID: 11431
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetCroppingRegionPlanes_22(HandleRef pThis, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6);

		/// <summary>
		/// \sa vtkVolumeMapper::SetCroppingRegionPlanes
		/// </summary>
		// Token: 0x06002CA8 RID: 11432 RVA: 0x00041D2F File Offset: 0x0003FF2F
		public override void SetCroppingRegionPlanes(double arg1, double arg2, double arg3, double arg4, double arg5, double arg6)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetCroppingRegionPlanes_22(base.GetCppThis(), arg1, arg2, arg3, arg4, arg5, arg6);
		}

		// Token: 0x06002CA9 RID: 11433
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetCroppingRegionPlanes_23(HandleRef pThis, IntPtr planes);

		/// <summary>
		/// \sa vtkVolumeMapper::SetCroppingRegionPlanes
		/// </summary>
		// Token: 0x06002CAA RID: 11434 RVA: 0x00041D47 File Offset: 0x0003FF47
		public override void SetCroppingRegionPlanes(IntPtr planes)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetCroppingRegionPlanes_23(base.GetCppThis(), planes);
		}

		// Token: 0x06002CAB RID: 11435
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetGlobalIlluminationReach_24(HandleRef pThis, float val);

		/// <summary>
		/// @copydoc vtkSmartVolumeMapper::SetGlobalIlluminationReach(float)
		/// </summary>
		// Token: 0x06002CAC RID: 11436 RVA: 0x00041D57 File Offset: 0x0003FF57
		public void SetGlobalIlluminationReach(float val)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetGlobalIlluminationReach_24(base.GetCppThis(), val);
		}

		// Token: 0x06002CAD RID: 11437
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetRequestedRenderMode_25(HandleRef pThis, int arg0);

		/// <summary>
		/// Forwarded to internal vtkSmartVolumeMappers used.
		/// @sa vtkSmartVolumeMapper::SetRequestedRenderMode.
		/// </summary>
		// Token: 0x06002CAE RID: 11438 RVA: 0x00041D67 File Offset: 0x0003FF67
		public void SetRequestedRenderMode(int arg0)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetRequestedRenderMode_25(base.GetCppThis(), arg0);
		}

		// Token: 0x06002CAF RID: 11439
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetScalarMode_26(HandleRef pThis, int ScalarMode);

		/// <summary>
		///  \brief API Superclass
		///  \sa vtkAbstractVolumeMapper
		/// </summary>
		// Token: 0x06002CB0 RID: 11440 RVA: 0x00041D77 File Offset: 0x0003FF77
		public override void SetScalarMode(int ScalarMode)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetScalarMode_26(base.GetCppThis(), ScalarMode);
		}

		// Token: 0x06002CB1 RID: 11441
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetTransfer2DYAxisArray_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string a);

		/// <summary>
		/// \sa vtkSmartVolumeMapper::SetTransfer2DYAxisArray
		/// </summary>
		// Token: 0x06002CB2 RID: 11442 RVA: 0x00041D87 File Offset: 0x0003FF87
		public void SetTransfer2DYAxisArray(string a)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetTransfer2DYAxisArray_27(base.GetCppThis(), a);
		}

		// Token: 0x06002CB3 RID: 11443
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetVectorComponent_28(HandleRef pThis, int component);

		/// <summary>
		/// VectorMode interface exposed from vtkSmartVolumeMapper.
		/// </summary>
		// Token: 0x06002CB4 RID: 11444 RVA: 0x00041D97 File Offset: 0x0003FF97
		public void SetVectorComponent(int component)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetVectorComponent_28(base.GetCppThis(), component);
		}

		// Token: 0x06002CB5 RID: 11445
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetVectorMode_29(HandleRef pThis, int mode);

		/// <summary>
		/// VectorMode interface exposed from vtkSmartVolumeMapper.
		/// </summary>
		// Token: 0x06002CB6 RID: 11446 RVA: 0x00041DA7 File Offset: 0x0003FFA7
		public void SetVectorMode(int mode)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetVectorMode_29(base.GetCppThis(), mode);
		}

		// Token: 0x06002CB7 RID: 11447
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockVolumeMapper_SetVolumetricScatteringBlending_30(HandleRef pThis, float val);

		/// <summary>
		/// @copydoc vtkSmartVolumeMapper::SetVolumetricScatteringBlending(float)
		/// </summary>
		// Token: 0x06002CB8 RID: 11448 RVA: 0x00041DB7 File Offset: 0x0003FFB7
		public void SetVolumetricScatteringBlending(float val)
		{
			vtkMultiBlockVolumeMapper.vtkMultiBlockVolumeMapper_SetVolumetricScatteringBlending_30(base.GetCppThis(), val);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400059D RID: 1437
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockVolumeMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400059E RID: 1438
		public new static readonly string MRClassNameKey = "class vtkMultiBlockVolumeMapper";
	}
}
