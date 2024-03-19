using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkOpenGLGPUVolumeRayCastMapper
	/// </summary>
	/// <remarks>
	///  OpenGL implementation of volume rendering through ray-casting.
	///
	/// @section multi Multiple Inputs
	///
	/// When multiple inputs are rendered simultaneously, it is possible to
	/// composite overlapping areas correctly. Inputs are connected directly to
	/// the mapper and their parameters (transfer functions, transformations, etc.)
	/// are specified through standard vtkVolume instances. These vtkVolume
	/// instances are to be registered in a special vtkProp3D, vtkMultiVolume.
	///
	/// Structures related to a particular active input are stored in a helper
	/// class (vtkVolumeInputHelper) and helper structures are kept in a
	/// port-referenced map (VolumeInputMap). The order of the inputs in the
	/// map is important as it defines the order in which parameters are
	/// bound to uniform variables (transformation matrices, bias, scale and every
	/// other required rendering parameter).
	///
	/// A separate code path is used when rendering multiple-inputs in order to
	/// facilitate the co-existance of these two modes (single/multiple), due to
	/// current feature incompatibilities with multiple inputs (e.g. texture-streaming,
	/// cropping, etc.).
	///
	/// @note A limited set of the mapper features are currently supported for
	/// multiple inputs:
	///
	/// - Blending
	///   - Composite (front-to-back)
	///
	/// - Transfer functions (defined separately for per input)
	///   - 1D color
	///   - 1D scalar opacity
	///   - 1D gradient magnitude opacity
	///   - 2D scalar-gradient magnitude
	///
	/// - Point and cell data
	///   - With the limitation that all of the inputs are assumed to share the same
	///     name/id.
	///
	/// - Inputs
	///   - 1-component inputs with vtkVolumeProperty::IndependentComponentsOn()
	///   - 4-component inputs with vtkVolumeProperty::IndependentComponentsOff()
	///
	/// </remarks>
	/// <seealso>
	///  vtkGPUVolumeRayCastMapper vtkVolumeInputHelper vtkVolumeTexture
	/// vtkMultiVolume
	///
	/// </seealso>
	// Token: 0x020000D6 RID: 214
	public class vtkOpenGLGPUVolumeRayCastMapper : vtkGPUVolumeRayCastMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002D9F RID: 11679 RVA: 0x00042D09 File Offset: 0x00040F09
		static vtkOpenGLGPUVolumeRayCastMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLGPUVolumeRayCastMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLGPUVolumeRayCastMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002DA0 RID: 11680 RVA: 0x00042D31 File Offset: 0x00040F31
		public vtkOpenGLGPUVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002DA1 RID: 11681
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGPUVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DA2 RID: 11682 RVA: 0x00042D40 File Offset: 0x00040F40
		public new static vtkOpenGLGPUVolumeRayCastMapper New()
		{
			vtkOpenGLGPUVolumeRayCastMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DA3 RID: 11683 RVA: 0x00042D94 File Offset: 0x00040F94
		public vtkOpenGLGPUVolumeRayCastMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002DA4 RID: 11684 RVA: 0x00042DD8 File Offset: 0x00040FD8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002DA5 RID: 11685
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGPUVolumeRayCastMapper_GetColorImage_01(HandleRef pThis, HandleRef im);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DA6 RID: 11686 RVA: 0x00042DE4 File Offset: 0x00040FE4
		public override void GetColorImage(vtkImageData im)
		{
			vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_GetColorImage_01(base.GetCppThis(), (im == null) ? default(HandleRef) : im.GetCppThis());
		}

		// Token: 0x06002DA7 RID: 11687
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLGPUVolumeRayCastMapper_GetCurrentPass_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DA8 RID: 11688 RVA: 0x00042E14 File Offset: 0x00041014
		public virtual int GetCurrentPass()
		{
			return vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_GetCurrentPass_02(base.GetCppThis());
		}

		// Token: 0x06002DA9 RID: 11689
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGPUVolumeRayCastMapper_GetDepthImage_03(HandleRef pThis, HandleRef im);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DAA RID: 11690 RVA: 0x00042E34 File Offset: 0x00041034
		public override void GetDepthImage(vtkImageData im)
		{
			vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_GetDepthImage_03(base.GetCppThis(), (im == null) ? default(HandleRef) : im.GetCppThis());
		}

		// Token: 0x06002DAB RID: 11691
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DAC RID: 11692 RVA: 0x00042E64 File Offset: 0x00041064
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06002DAD RID: 11693
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DAE RID: 11694 RVA: 0x00042E84 File Offset: 0x00041084
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06002DAF RID: 11695
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLGPUVolumeRayCastMapper_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DB0 RID: 11696 RVA: 0x00042EA0 File Offset: 0x000410A0
		public override int IsA(string type)
		{
			return vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06002DB1 RID: 11697
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLGPUVolumeRayCastMapper_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DB2 RID: 11698 RVA: 0x00042EC0 File Offset: 0x000410C0
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_IsTypeOf_07(type);
		}

		// Token: 0x06002DB3 RID: 11699
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGPUVolumeRayCastMapper_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DB4 RID: 11700 RVA: 0x00042EDC File Offset: 0x000410DC
		public new vtkOpenGLGPUVolumeRayCastMapper NewInstance()
		{
			vtkOpenGLGPUVolumeRayCastMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002DB5 RID: 11701
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLGPUVolumeRayCastMapper_PreLoadData_10(HandleRef pThis, HandleRef ren, HandleRef vol);

		/// <summary>
		///  Load the volume texture into GPU memory.  Actual loading occurs
		///  in vtkVolumeTexture::LoadVolume.  The mapper by default loads data
		///  lazily (at render time), so it is most commonly not necessary to call
		///  this function.  This method is only exposed in order to support on-site
		///  loading which is useful in cases where the user needs to know a-priori
		///  whether loading will succeed or not.
		/// </summary>
		// Token: 0x06002DB6 RID: 11702 RVA: 0x00042F38 File Offset: 0x00041138
		public bool PreLoadData(vtkRenderer ren, vtkVolume vol)
		{
			return vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_PreLoadData_10(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis()) != 0;
		}

		// Token: 0x06002DB7 RID: 11703
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGPUVolumeRayCastMapper_ReleaseGraphicsResources_11(HandleRef pThis, HandleRef window);

		/// <summary>
		///  Load the volume texture into GPU memory.  Actual loading occurs
		///  in vtkVolumeTexture::LoadVolume.  The mapper by default loads data
		///  lazily (at render time), so it is most commonly not necessary to call
		///  this function.  This method is only exposed in order to support on-site
		///  loading which is useful in cases where the user needs to know a-priori
		///  whether loading will succeed or not.
		/// </summary>
		// Token: 0x06002DB8 RID: 11704 RVA: 0x00042F88 File Offset: 0x00041188
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_ReleaseGraphicsResources_11(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x06002DB9 RID: 11705
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGPUVolumeRayCastMapper_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DBA RID: 11706 RVA: 0x00042FB8 File Offset: 0x000411B8
		public new static vtkOpenGLGPUVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLGPUVolumeRayCastMapper vtkOpenGLGPUVolumeRayCastMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLGPUVolumeRayCastMapper = (vtkOpenGLGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLGPUVolumeRayCastMapper.Register(null);
				}
			}
			return vtkOpenGLGPUVolumeRayCastMapper;
		}

		// Token: 0x06002DBB RID: 11707
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGPUVolumeRayCastMapper_SetPartitions_13(HandleRef pThis, ushort x, ushort y, ushort z);

		/// <summary>
		/// Set a fixed number of partitions in which to split the volume
		/// during rendering. This will force by-block rendering without
		/// trying to compute an optimum number of partitions.
		/// </summary>
		// Token: 0x06002DBC RID: 11708 RVA: 0x00043037 File Offset: 0x00041237
		public void SetPartitions(ushort x, ushort y, ushort z)
		{
			vtkOpenGLGPUVolumeRayCastMapper.vtkOpenGLGPUVolumeRayCastMapper_SetPartitions_13(base.GetCppThis(), x, y, z);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005A7 RID: 1447
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLGPUVolumeRayCastMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005A8 RID: 1448
		public new static readonly string MRClassNameKey = "class vtkOpenGLGPUVolumeRayCastMapper";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020000D7 RID: 215
		public enum Passes
		{
			/// <summary>enum member</summary>
			// Token: 0x040005AA RID: 1450
			DepthPass = 1,
			/// <summary>enum member</summary>
			// Token: 0x040005AB RID: 1451
			RenderPass = 0
		}
	}
}
