using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkMultiBlockUnstructuredGridVolumeMapper
	/// \brief Mapper to render volumes defined as vtkMultiBlockDataSet.
	///
	/// </summary>
	// Token: 0x020000CF RID: 207
	public class vtkMultiBlockUnstructuredGridVolumeMapper : vtkUnstructuredGridVolumeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002BEA RID: 11242 RVA: 0x00040EC7 File Offset: 0x0003F0C7
		static vtkMultiBlockUnstructuredGridVolumeMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiBlockUnstructuredGridVolumeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockUnstructuredGridVolumeMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002BEB RID: 11243 RVA: 0x00040EEF File Offset: 0x0003F0EF
		public vtkMultiBlockUnstructuredGridVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002BEC RID: 11244
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockUnstructuredGridVolumeMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BED RID: 11245 RVA: 0x00040F00 File Offset: 0x0003F100
		public new static vtkMultiBlockUnstructuredGridVolumeMapper New()
		{
			vtkMultiBlockUnstructuredGridVolumeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockUnstructuredGridVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BEE RID: 11246 RVA: 0x00040F54 File Offset: 0x0003F154
		public vtkMultiBlockUnstructuredGridVolumeMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002BEF RID: 11247 RVA: 0x00040F98 File Offset: 0x0003F198
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002BF0 RID: 11248
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockUnstructuredGridVolumeMapper_GetBounds_01(HandleRef pThis);

		/// <summary>
		///  \brief API Superclass
		///  \sa vtkAbstractVolumeMapper
		/// </summary>
		// Token: 0x06002BF1 RID: 11249 RVA: 0x00040FA4 File Offset: 0x0003F1A4
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002BF2 RID: 11250
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BF3 RID: 11251 RVA: 0x00040FEC File Offset: 0x0003F1EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06002BF4 RID: 11252
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BF5 RID: 11253 RVA: 0x0004100C File Offset: 0x0003F20C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06002BF6 RID: 11254
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMultiBlockUnstructuredGridVolumeMapper_GetUseFloatingPointFrameBuffer_04(HandleRef pThis);

		/// <summary>
		/// Set/get whether to use floating-point rendering buffers rather
		/// than the default.
		/// \sa vtkOpenGLProjectedTetrahedraMapper::setusefloatingpointframebuffer
		/// </summary>
		// Token: 0x06002BF7 RID: 11255 RVA: 0x00041028 File Offset: 0x0003F228
		public virtual bool GetUseFloatingPointFrameBuffer()
		{
			return vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_GetUseFloatingPointFrameBuffer_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06002BF8 RID: 11256
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockUnstructuredGridVolumeMapper_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BF9 RID: 11257 RVA: 0x00041050 File Offset: 0x0003F250
		public override int IsA(string type)
		{
			return vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06002BFA RID: 11258
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockUnstructuredGridVolumeMapper_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BFB RID: 11259 RVA: 0x00041070 File Offset: 0x0003F270
		public new static int IsTypeOf(string type)
		{
			return vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_IsTypeOf_06(type);
		}

		// Token: 0x06002BFC RID: 11260
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockUnstructuredGridVolumeMapper_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BFD RID: 11261 RVA: 0x0004108C File Offset: 0x0003F28C
		public new vtkMultiBlockUnstructuredGridVolumeMapper NewInstance()
		{
			vtkMultiBlockUnstructuredGridVolumeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockUnstructuredGridVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002BFE RID: 11262
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef window);

		/// <summary>
		/// \warning Internal method - not intended for general use, do
		/// NOT use this method outside of the rendering process.
		/// </summary>
		// Token: 0x06002BFF RID: 11263 RVA: 0x000410E8 File Offset: 0x0003F2E8
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_ReleaseGraphicsResources_09(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x06002C00 RID: 11264
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_Render_10(HandleRef pThis, HandleRef ren, HandleRef vol);

		/// <summary>
		/// Render the current dataset.
		///
		/// \warning Internal method - not intended for general use, do
		/// NOT use this method outside of the rendering process.
		/// </summary>
		// Token: 0x06002C01 RID: 11265 RVA: 0x00041118 File Offset: 0x0003F318
		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_Render_10(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x06002C02 RID: 11266
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockUnstructuredGridVolumeMapper_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C03 RID: 11267 RVA: 0x0004115C File Offset: 0x0003F35C
		public new static vtkMultiBlockUnstructuredGridVolumeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkMultiBlockUnstructuredGridVolumeMapper vtkMultiBlockUnstructuredGridVolumeMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockUnstructuredGridVolumeMapper = (vtkMultiBlockUnstructuredGridVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockUnstructuredGridVolumeMapper.Register(null);
				}
			}
			return vtkMultiBlockUnstructuredGridVolumeMapper;
		}

		// Token: 0x06002C04 RID: 11268
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_SelectScalarArray_12(HandleRef pThis, int arrayNum);

		/// <summary>
		///  \brief API Superclass
		///  \sa vtkAbstractVolumeMapper
		/// </summary>
		// Token: 0x06002C05 RID: 11269 RVA: 0x000411DB File Offset: 0x0003F3DB
		public override void SelectScalarArray(int arrayNum)
		{
			vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_SelectScalarArray_12(base.GetCppThis(), arrayNum);
		}

		// Token: 0x06002C06 RID: 11270
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_SelectScalarArray_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		///  \brief API Superclass
		///  \sa vtkAbstractVolumeMapper
		/// </summary>
		// Token: 0x06002C07 RID: 11271 RVA: 0x000411EB File Offset: 0x0003F3EB
		public override void SelectScalarArray(string arrayName)
		{
			vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_SelectScalarArray_13(base.GetCppThis(), arrayName);
		}

		// Token: 0x06002C08 RID: 11272
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_SetArrayAccessMode_14(HandleRef pThis, int accessMode);

		/// <summary>
		///  \brief API Superclass
		///  \sa vtkAbstractVolumeMapper
		/// </summary>
		// Token: 0x06002C09 RID: 11273 RVA: 0x000411FB File Offset: 0x0003F3FB
		public override void SetArrayAccessMode(int accessMode)
		{
			vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_SetArrayAccessMode_14(base.GetCppThis(), accessMode);
		}

		// Token: 0x06002C0A RID: 11274
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_SetBlendMode_15(HandleRef pThis, int mode);

		/// <summary>
		/// blending mode api from vtkUnstructuredGridVolumemapper
		/// \sa vtkvolumemapper::setblendmode
		/// </summary>
		// Token: 0x06002C0B RID: 11275 RVA: 0x0004120B File Offset: 0x0003F40B
		public override void SetBlendMode(int mode)
		{
			vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_SetBlendMode_15(base.GetCppThis(), mode);
		}

		// Token: 0x06002C0C RID: 11276
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_SetScalarMode_16(HandleRef pThis, int ScalarMode);

		/// <summary>
		///  \brief API Superclass
		///  \sa vtkAbstractVolumeMapper
		/// </summary>
		// Token: 0x06002C0D RID: 11277 RVA: 0x0004121B File Offset: 0x0003F41B
		public override void SetScalarMode(int ScalarMode)
		{
			vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_SetScalarMode_16(base.GetCppThis(), ScalarMode);
		}

		// Token: 0x06002C0E RID: 11278
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_SetUseFloatingPointFrameBuffer_17(HandleRef pThis, byte use);

		/// <summary>
		/// Set/get whether to use floating-point rendering buffers rather
		/// than the default.
		/// \sa vtkOpenGLProjectedTetrahedraMapper::setusefloatingpointframebuffer
		/// </summary>
		// Token: 0x06002C0F RID: 11279 RVA: 0x0004122B File Offset: 0x0003F42B
		public void SetUseFloatingPointFrameBuffer(bool use)
		{
			vtkMultiBlockUnstructuredGridVolumeMapper.vtkMultiBlockUnstructuredGridVolumeMapper_SetUseFloatingPointFrameBuffer_17(base.GetCppThis(), use ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000591 RID: 1425
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockUnstructuredGridVolumeMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000592 RID: 1426
		public new static readonly string MRClassNameKey = "class vtkMultiBlockUnstructuredGridVolumeMapper";
	}
}
