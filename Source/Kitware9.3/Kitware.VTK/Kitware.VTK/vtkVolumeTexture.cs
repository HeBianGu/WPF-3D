using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///   vtkVolumeTexture
	/// </summary>
	/// <remarks>
	///   Creates and manages the volume texture rendered by
	/// vtkOpenGLGPUVolumeRayCastMapper.
	///
	/// Wraps a vtkTextureObject for which it selects the appropriate format
	/// (depending on the input vtkDataArray type, number of components, etc.) and
	/// loads input data. The class maintains a set of members of interest to the
	/// parent mapper, such as:
	///
	/// * Active vtkDataArray scalar range.
	/// * Volume's scale and bias (pixel transfer functions).
	/// * HandleLargeDataType flag.
	/// * Texture to data transformations.
	/// * Block extents
	/// * Block loaded bounds
	///
	/// This class supports streaming the volume data in separate blocks to make it
	/// fit in graphics memory (sometimes referred to as bricking). The data is split
	/// into a user-defined number of blocks in such a way that a single sub-block
	/// (brick) fits completely into GPU memory.  A stride is passed to OpenGL so
	/// that it can access the underlying vtkDataArray adequately for each of the
	/// blocks to be streamed into GPU memory (back-to-front for correct
	/// composition).
	///
	/// Streaming the volume as separate texture bricks certainly imposes a
	/// performance trade-off but acts as a graphics memory expansion scheme for
	/// devices that would not be able to render higher resoulution volumes
	/// otherwise.
	///
	/// @warning There are certain caveats when texture streaming is enabled, given
	/// the locality constraint that rendering a single block imposes.
	///
	/// - Quality might suffer near the block seams with ShadeOn() (gradient
	/// computation at the boundaries needs adjustment).
	///
	/// - Not all of the features supported by the mapper currently work correctly.
	///   This is a list of known issues:
	///   - Blending modes such as average and additive might compute a different
	///      value near the edges.
	///
	/// - Future work will extend the API to be able to compute an ideal number of
	///   partitions and extents based on the platform capabilities.
	///
	/// @warning This is an internal class of vtkOpenGLGPUVolumeRayCastMapper. It
	/// assumes there is an active OpenGL context in methods involving GL calls
	/// (MakeCurrent() is expected to be called in the mapper beforehand).
	/// </remarks>
	// Token: 0x020000E0 RID: 224
	public class vtkVolumeTexture : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002ED5 RID: 11989 RVA: 0x00044786 File Offset: 0x00042986
		static vtkVolumeTexture()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeTexture"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002ED6 RID: 11990 RVA: 0x000447AE File Offset: 0x000429AE
		public vtkVolumeTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002ED7 RID: 11991
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002ED8 RID: 11992 RVA: 0x000447BC File Offset: 0x000429BC
		public new static vtkVolumeTexture New()
		{
			vtkVolumeTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeTexture.vtkVolumeTexture_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002ED9 RID: 11993 RVA: 0x00044810 File Offset: 0x00042A10
		public vtkVolumeTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolumeTexture.vtkVolumeTexture_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002EDA RID: 11994 RVA: 0x00044854 File Offset: 0x00042A54
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002EDB RID: 11995
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeTexture_GetLoadedScalars_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the scale and bias values given a VTK scalar type and a finite range.
		/// The scale and bias values computed using this method can be useful for
		/// custom shader code. For example, when looking up color values through the
		/// transfer function texture, the scalar value must be scaled and offset.
		/// </summary>
		// Token: 0x06002EDC RID: 11996 RVA: 0x00044860 File Offset: 0x00042A60
		public vtkDataArray GetLoadedScalars()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeTexture.vtkVolumeTexture_GetLoadedScalars_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x06002EDD RID: 11997
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeTexture_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// LoadedBounds are corrected for cell-data (if that is the case). So they
		/// are not equivalent to vtkDataSet::GetBounds().
		/// </summary>
		// Token: 0x06002EDE RID: 11998 RVA: 0x000448D0 File Offset: 0x00042AD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumeTexture.vtkVolumeTexture_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06002EDF RID: 11999
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeTexture_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// LoadedBounds are corrected for cell-data (if that is the case). So they
		/// are not equivalent to vtkDataSet::GetBounds().
		/// </summary>
		// Token: 0x06002EE0 RID: 12000 RVA: 0x000448F0 File Offset: 0x00042AF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumeTexture.vtkVolumeTexture_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06002EE1 RID: 12001
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeTexture_GetScaleAndBias_04(int scalarType, IntPtr scalarRange, ref float scale, ref float bias);

		/// <summary>
		/// Get the scale and bias values given a VTK scalar type and a finite range.
		/// The scale and bias values computed using this method can be useful for
		/// custom shader code. For example, when looking up color values through the
		/// transfer function texture, the scalar value must be scaled and offset.
		/// </summary>
		// Token: 0x06002EE2 RID: 12002 RVA: 0x0004490A File Offset: 0x00042B0A
		public static void GetScaleAndBias(int scalarType, IntPtr scalarRange, ref float scale, ref float bias)
		{
			vtkVolumeTexture.vtkVolumeTexture_GetScaleAndBias_04(scalarType, scalarRange, ref scale, ref bias);
		}

		// Token: 0x06002EE3 RID: 12003
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeTexture_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// LoadedBounds are corrected for cell-data (if that is the case). So they
		/// are not equivalent to vtkDataSet::GetBounds().
		/// </summary>
		// Token: 0x06002EE4 RID: 12004 RVA: 0x00044918 File Offset: 0x00042B18
		public override int IsA(string type)
		{
			return vtkVolumeTexture.vtkVolumeTexture_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06002EE5 RID: 12005
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeTexture_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// LoadedBounds are corrected for cell-data (if that is the case). So they
		/// are not equivalent to vtkDataSet::GetBounds().
		/// </summary>
		// Token: 0x06002EE6 RID: 12006 RVA: 0x00044938 File Offset: 0x00042B38
		public new static int IsTypeOf(string type)
		{
			return vtkVolumeTexture.vtkVolumeTexture_IsTypeOf_06(type);
		}

		// Token: 0x06002EE7 RID: 12007
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVolumeTexture_LoadVolume_07(HandleRef pThis, HandleRef ren, HandleRef data, HandleRef scalars, int isCell, int interpolation);

		/// <summary>
		/// Loads the data array into the texture in the case only a single block is
		/// is defined. Does not load when the input data is divided in multiple blocks
		/// (in which case they will be loaded into GPU memory by GetNextBlock()).
		/// Requires an active OpenGL context.
		/// </summary>
		// Token: 0x06002EE8 RID: 12008 RVA: 0x00044954 File Offset: 0x00042B54
		public bool LoadVolume(vtkRenderer ren, vtkDataSet data, vtkDataArray scalars, int isCell, int interpolation)
		{
			return vtkVolumeTexture.vtkVolumeTexture_LoadVolume_07(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), isCell, interpolation) != 0;
		}

		// Token: 0x06002EE9 RID: 12009
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeTexture_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// LoadedBounds are corrected for cell-data (if that is the case). So they
		/// are not equivalent to vtkDataSet::GetBounds().
		/// </summary>
		// Token: 0x06002EEA RID: 12010 RVA: 0x000449C0 File Offset: 0x00042BC0
		public new vtkVolumeTexture NewInstance()
		{
			vtkVolumeTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeTexture.vtkVolumeTexture_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002EEB RID: 12011
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeTexture_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Clean-up acquired graphics resources.
		/// </summary>
		// Token: 0x06002EEC RID: 12012 RVA: 0x00044A1C File Offset: 0x00042C1C
		public void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkVolumeTexture.vtkVolumeTexture_ReleaseGraphicsResources_10(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x06002EED RID: 12013
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeTexture_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// LoadedBounds are corrected for cell-data (if that is the case). So they
		/// are not equivalent to vtkDataSet::GetBounds().
		/// </summary>
		// Token: 0x06002EEE RID: 12014 RVA: 0x00044A4C File Offset: 0x00042C4C
		public new static vtkVolumeTexture SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeTexture vtkVolumeTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeTexture.vtkVolumeTexture_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeTexture = (vtkVolumeTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeTexture.Register(null);
				}
			}
			return vtkVolumeTexture;
		}

		// Token: 0x06002EEF RID: 12015
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeTexture_SetPartitions_12(HandleRef pThis, int x, int y, int z);

		/// <summary>
		///  Set a number of blocks per axis.
		/// </summary>
		// Token: 0x06002EF0 RID: 12016 RVA: 0x00044ACB File Offset: 0x00042CCB
		public void SetPartitions(int x, int y, int z)
		{
			vtkVolumeTexture.vtkVolumeTexture_SetPartitions_12(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06002EF1 RID: 12017
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeTexture_SortBlocksBackToFront_13(HandleRef pThis, HandleRef ren, HandleRef volumeMat);

		/// <summary>
		/// If streaming the data array as separate blocks, sort them back to front.
		/// This method does nothing if there is a single block.
		/// </summary>
		// Token: 0x06002EF2 RID: 12018 RVA: 0x00044AE0 File Offset: 0x00042CE0
		public void SortBlocksBackToFront(vtkRenderer ren, vtkMatrix4x4 volumeMat)
		{
			vtkVolumeTexture.vtkVolumeTexture_SortBlocksBackToFront_13(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (volumeMat == null) ? default(HandleRef) : volumeMat.GetCppThis());
		}

		// Token: 0x06002EF3 RID: 12019
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeTexture_UpdateVolume_14(HandleRef pThis, HandleRef property);

		/// <summary>
		/// It currently only calls SetInterpolation internally. Requires an active OpenGL
		/// context.
		/// </summary>
		// Token: 0x06002EF4 RID: 12020 RVA: 0x00044B24 File Offset: 0x00042D24
		public void UpdateVolume(vtkVolumeProperty property)
		{
			vtkVolumeTexture.vtkVolumeTexture_UpdateVolume_14(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005C4 RID: 1476
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeTexture";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005C5 RID: 1477
		public new static readonly string MRClassNameKey = "class vtkVolumeTexture";
	}
}
