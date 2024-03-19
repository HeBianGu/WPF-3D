using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataTransferHelper
	/// </summary>
	/// <remarks>
	///    is a helper class that aids in transferring
	///  data between CPU memory and GPU memory.
	///
	///
	///  vtkDataTransferHelper is a helper class that aids in transferring data
	///  between the CPU memory and the GPU memory. The data in GPU memory is
	///  stored as textures which that in CPU memory is stored as vtkDataArray.
	///  vtkDataTransferHelper provides API to transfer only a sub-extent of CPU
	///  structured data to/from the GPU.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkPixelBufferObject vtkTextureObject vtkOpenGLExtensionManager
	/// </seealso>
	// Token: 0x02000580 RID: 1408
	public class vtkDataTransferHelper : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F937 RID: 63799 RVA: 0x0015A594 File Offset: 0x00158794
		static vtkDataTransferHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataTransferHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataTransferHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F938 RID: 63800 RVA: 0x0015A5BC File Offset: 0x001587BC
		public vtkDataTransferHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F939 RID: 63801
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataTransferHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F93A RID: 63802 RVA: 0x0015A5CC File Offset: 0x001587CC
		public new static vtkDataTransferHelper New()
		{
			vtkDataTransferHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataTransferHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F93B RID: 63803 RVA: 0x0015A620 File Offset: 0x00158820
		public vtkDataTransferHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataTransferHelper.vtkDataTransferHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F93C RID: 63804 RVA: 0x0015A664 File Offset: 0x00158864
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F93D RID: 63805
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataTransferHelper_Download_01(HandleRef pThis);

		/// <summary>
		/// old comment:
		/// Download Extent from GPU data buffer to CPU.
		/// GPU data size must exactly match Extent.
		/// CPU data buffer will be resized to match WholeExtent in which only the
		/// Extent will be filled with the GPU data.
		/// new comment:
		/// Download GPUExtent from GPU texture to CPU vtkDataArray.
		/// If Array is not provided, it will be created with the size of CPUExtent.
		/// But only the tuples covered by GPUExtent will be download. In this case,
		/// if GPUExtent does not cover all GPUExtent, some of the vtkDataArray will
		/// be uninitialized.
		/// Reminder: A=&gt;B &lt;=&gt; !A||B
		/// \pre texture_exists: texture!=0
		/// \pre array_not_empty: array==0 || array-&gt;GetNumberOfTuples()&gt;0
		/// \pre valid_cpu_extent: this-&gt;GetCPUExtentIsValid()
		/// \pre valid_cpu_extent_size: array==0 ||
		/// (CPUExtent[1]-CPUExtent[0]+1)*(CPUExtent[3]-CPUExtent[2]+1)*(CPUExtent[5]-CPUExtent[4]+1)==array-&gt;GetNumberOfTuples()
		/// \pre valid_gpu_extent: this-&gt;GetGPUExtentIsValid()
		/// \pre gpu_extent_in_cpu_extent: CPUExtent[0]&lt;=GPUExtent[0] &amp;&amp; GPUExtent[1]&lt;=CPUExtent[1] &amp;&amp;
		/// CPUExtent[2]&lt;=GPUExtent[2] &amp;&amp; GPUExtent[3]&lt;=CPUExtent[3] &amp;&amp; CPUExtent[4]&lt;=GPUExtent[4] &amp;&amp;
		/// GPUExtent[5]&lt;=CPUExtent[5] \pre gpu_texture_size: !this-&gt;GetTextureExtentIsValid() ||
		/// (GPUExtent[1]-GPUExtent[0]+1)*(GPUExtent[3]-GPUExtent[2]+1)*(GPUExtent[5]-GPUExtent[4]+1)==(TextureExtent[1]-TextureExtent[0]+1)*(TextureExtent[3]-TextureExtent[2]+1)*(TextureExtent[5]-TextureExtent[4]+1)
		/// \pre valid_components: array==0 || array-&gt;GetNumberOfComponents()&lt;=4
		/// \pre components_match: array==0 || (texture-&gt;GetComponents()==array-&gt;GetNumberOfComponents())
		/// </summary>
		// Token: 0x0600F93E RID: 63806 RVA: 0x0015A670 File Offset: 0x00158870
		public bool Download()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_Download_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F93F RID: 63807
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataTransferHelper_DownloadAsync1_02(HandleRef pThis);

		/// <summary>
		/// Splits the download in two operations
		/// * Asynchronously download from texture memory to PBO (DownloadAsync1()).
		/// * Copy from pbo to user array (DownloadAsync2()).
		/// </summary>
		// Token: 0x0600F940 RID: 63808 RVA: 0x0015A698 File Offset: 0x00158898
		public bool DownloadAsync1()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_DownloadAsync1_02(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F941 RID: 63809
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataTransferHelper_DownloadAsync2_03(HandleRef pThis);

		/// <summary>
		/// Splits the download in two operations
		/// * Asynchronously download from texture memory to PBO (DownloadAsync1()).
		/// * Copy from pbo to user array (DownloadAsync2()).
		/// </summary>
		// Token: 0x0600F942 RID: 63810 RVA: 0x0015A6C0 File Offset: 0x001588C0
		public bool DownloadAsync2()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_DownloadAsync2_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F943 RID: 63811
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataTransferHelper_GetArray_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the CPU data buffer. Initial value is 0.
		/// </summary>
		// Token: 0x0600F944 RID: 63812 RVA: 0x0015A6E8 File Offset: 0x001588E8
		public virtual vtkDataArray GetArray()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_GetArray_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600F945 RID: 63813
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataTransferHelper_GetCPUExtent_05(HandleRef pThis);

		/// <summary>
		/// Set the CPU data extent. The extent matches the vtkDataArray size.
		/// If the vtkDataArray comes from an vtkImageData and it is part of the
		/// point data, it is usually the vtkImageData extent.
		/// It can be on cell data too, but in this case it does not match the
		/// vtkImageData extent.
		/// If the vtkDataArray comes from a vtkDataSet, just
		/// set it to a one-dimenstional extent equal to the number of tuples.
		/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
		/// </summary>
		// Token: 0x0600F946 RID: 63814 RVA: 0x0015A758 File Offset: 0x00158958
		public virtual int[] GetCPUExtent()
		{
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_GetCPUExtent_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F947 RID: 63815
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_GetCPUExtent_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set the CPU data extent. The extent matches the vtkDataArray size.
		/// If the vtkDataArray comes from an vtkImageData and it is part of the
		/// point data, it is usually the vtkImageData extent.
		/// It can be on cell data too, but in this case it does not match the
		/// vtkImageData extent.
		/// If the vtkDataArray comes from a vtkDataSet, just
		/// set it to a one-dimenstional extent equal to the number of tuples.
		/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
		/// </summary>
		// Token: 0x0600F948 RID: 63816 RVA: 0x0015A7A0 File Offset: 0x001589A0
		public virtual void GetCPUExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_GetCPUExtent_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0600F949 RID: 63817
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_GetCPUExtent_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the CPU data extent. The extent matches the vtkDataArray size.
		/// If the vtkDataArray comes from an vtkImageData and it is part of the
		/// point data, it is usually the vtkImageData extent.
		/// It can be on cell data too, but in this case it does not match the
		/// vtkImageData extent.
		/// If the vtkDataArray comes from a vtkDataSet, just
		/// set it to a one-dimenstional extent equal to the number of tuples.
		/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
		/// </summary>
		// Token: 0x0600F94A RID: 63818 RVA: 0x0015A7B8 File Offset: 0x001589B8
		public virtual void GetCPUExtent(IntPtr _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_GetCPUExtent_07(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F94B RID: 63819
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataTransferHelper_GetCPUExtentIsValid_08(HandleRef pThis);

		/// <summary>
		/// Tells if CPUExtent is valid. True if min extent&lt;=max extent.
		/// </summary>
		// Token: 0x0600F94C RID: 63820 RVA: 0x0015A7C8 File Offset: 0x001589C8
		public bool GetCPUExtentIsValid()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetCPUExtentIsValid_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F94D RID: 63821
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataTransferHelper_GetContext_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
		/// This does not increase the reference count of the
		/// context to avoid reference loops.
		/// SetContext() may raise an error if the OpenGL context does not support the
		/// required OpenGL extensions.
		/// </summary>
		// Token: 0x0600F94E RID: 63822 RVA: 0x0015A7F0 File Offset: 0x001589F0
		public vtkRenderWindow GetContext()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_GetContext_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x0600F94F RID: 63823
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataTransferHelper_GetExtentIsValid_10(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Tells if the given extent (6 int) is valid. True if min
		/// extent&lt;=max extent.
		/// \pre extent_exists: extent!=0
		/// </summary>
		// Token: 0x0600F950 RID: 63824 RVA: 0x0015A860 File Offset: 0x00158A60
		public bool GetExtentIsValid(IntPtr extent)
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetExtentIsValid_10(base.GetCppThis(), extent) != 0;
		}

		// Token: 0x0600F951 RID: 63825
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataTransferHelper_GetGPUExtent_11(HandleRef pThis);

		/// <summary>
		/// Set the GPU data extent. This is the sub-extent to copy from or to the GPU.
		/// This extent matches the size of the data to transfer.
		/// GPUExtent and TextureExtent don't have to match (GPUExtent can be 1D
		/// whereas TextureExtent is 2D) but the number of elements have to match.
		/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
		/// </summary>
		// Token: 0x0600F952 RID: 63826 RVA: 0x0015A888 File Offset: 0x00158A88
		public virtual int[] GetGPUExtent()
		{
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_GetGPUExtent_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F953 RID: 63827
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_GetGPUExtent_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set the GPU data extent. This is the sub-extent to copy from or to the GPU.
		/// This extent matches the size of the data to transfer.
		/// GPUExtent and TextureExtent don't have to match (GPUExtent can be 1D
		/// whereas TextureExtent is 2D) but the number of elements have to match.
		/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
		/// </summary>
		// Token: 0x0600F954 RID: 63828 RVA: 0x0015A8D0 File Offset: 0x00158AD0
		public virtual void GetGPUExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_GetGPUExtent_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0600F955 RID: 63829
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_GetGPUExtent_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the GPU data extent. This is the sub-extent to copy from or to the GPU.
		/// This extent matches the size of the data to transfer.
		/// GPUExtent and TextureExtent don't have to match (GPUExtent can be 1D
		/// whereas TextureExtent is 2D) but the number of elements have to match.
		/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
		/// </summary>
		// Token: 0x0600F956 RID: 63830 RVA: 0x0015A8E8 File Offset: 0x00158AE8
		public virtual void GetGPUExtent(IntPtr _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_GetGPUExtent_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F957 RID: 63831
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataTransferHelper_GetGPUExtentIsValid_14(HandleRef pThis);

		/// <summary>
		/// Tells if GPUExtent is valid. True if min extent&lt;=max extent.
		/// </summary>
		// Token: 0x0600F958 RID: 63832 RVA: 0x0015A8F8 File Offset: 0x00158AF8
		public bool GetGPUExtentIsValid()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetGPUExtentIsValid_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F959 RID: 63833
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataTransferHelper_GetMinTextureDimension_15(HandleRef pThis);

		/// <summary>
		/// Define the minimal dimension of the texture regardless of the dimensions
		/// of the TextureExtent. Initial value is 1.
		/// A texture extent can have a given dimension 0D (one value), 1D, 2D or 3D.
		/// By default 0D and 1D are translated into a 1D texture, 2D is translated
		/// into a 2D texture, 3D is translated into a 3D texture. To make life easier
		/// when writing GLSL code and use only one type of sampler (ex: sampler2d),
		/// the default behavior can be changed by forcing a type of texture with
		/// this ivar.
		/// 1: default behavior. Initial value.
		/// 2: force 0D and 1D to be in a 2D texture
		/// 3: force 0D, 1D and 2D texture to be in a 3D texture.
		/// </summary>
		// Token: 0x0600F95A RID: 63834 RVA: 0x0015A920 File Offset: 0x00158B20
		public virtual int GetMinTextureDimension()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetMinTextureDimension_15(base.GetCppThis());
		}

		// Token: 0x0600F95B RID: 63835
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataTransferHelper_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F95C RID: 63836 RVA: 0x0015A940 File Offset: 0x00158B40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0600F95D RID: 63837
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataTransferHelper_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F95E RID: 63838 RVA: 0x0015A960 File Offset: 0x00158B60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0600F95F RID: 63839
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataTransferHelper_GetShaderSupportsTextureInt_18(HandleRef pThis);

		/// <summary>
		/// Splits the download in two operations
		/// * Asynchronously download from texture memory to PBO (DownloadAsync1()).
		/// * Copy from pbo to user array (DownloadAsync2()).
		/// </summary>
		// Token: 0x0600F960 RID: 63840 RVA: 0x0015A97C File Offset: 0x00158B7C
		public bool GetShaderSupportsTextureInt()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetShaderSupportsTextureInt_18(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F961 RID: 63841
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataTransferHelper_GetTextureExtent_19(HandleRef pThis);

		/// <summary>
		/// Set the texture data extent. This is the extent of the texture image that
		/// will receive the data. This extent matches the size of the data to
		/// transfer. If it is set to an invalid extent, GPUExtent is used.
		/// See more comment on GPUExtent.
		/// Initial value is an invalid extent.
		/// </summary>
		// Token: 0x0600F962 RID: 63842 RVA: 0x0015A9A4 File Offset: 0x00158BA4
		public virtual int[] GetTextureExtent()
		{
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_GetTextureExtent_19(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F963 RID: 63843
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_GetTextureExtent_20(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set the texture data extent. This is the extent of the texture image that
		/// will receive the data. This extent matches the size of the data to
		/// transfer. If it is set to an invalid extent, GPUExtent is used.
		/// See more comment on GPUExtent.
		/// Initial value is an invalid extent.
		/// </summary>
		// Token: 0x0600F964 RID: 63844 RVA: 0x0015A9EC File Offset: 0x00158BEC
		public virtual void GetTextureExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_GetTextureExtent_20(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0600F965 RID: 63845
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_GetTextureExtent_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the texture data extent. This is the extent of the texture image that
		/// will receive the data. This extent matches the size of the data to
		/// transfer. If it is set to an invalid extent, GPUExtent is used.
		/// See more comment on GPUExtent.
		/// Initial value is an invalid extent.
		/// </summary>
		// Token: 0x0600F966 RID: 63846 RVA: 0x0015AA04 File Offset: 0x00158C04
		public virtual void GetTextureExtent(IntPtr _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_GetTextureExtent_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F967 RID: 63847
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataTransferHelper_GetTextureExtentIsValid_22(HandleRef pThis);

		/// <summary>
		/// Tells if TextureExtent is valid. True if min extent&lt;=max extent.
		/// </summary>
		// Token: 0x0600F968 RID: 63848 RVA: 0x0015AA14 File Offset: 0x00158C14
		public bool GetTextureExtentIsValid()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetTextureExtentIsValid_22(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F969 RID: 63849
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataTransferHelper_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F96A RID: 63850 RVA: 0x0015AA3C File Offset: 0x00158C3C
		public override int IsA(string type)
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0600F96B RID: 63851
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataTransferHelper_IsSupported_24(HandleRef renWin);

		/// <summary>
		/// Returns if the context supports the required extensions.
		/// </summary>
		// Token: 0x0600F96C RID: 63852 RVA: 0x0015AA5C File Offset: 0x00158C5C
		public static bool IsSupported(vtkRenderWindow renWin)
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_IsSupported_24((renWin == null) ? default(HandleRef) : renWin.GetCppThis()) != 0;
		}

		// Token: 0x0600F96D RID: 63853
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataTransferHelper_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F96E RID: 63854 RVA: 0x0015AA94 File Offset: 0x00158C94
		public new static int IsTypeOf(string type)
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_IsTypeOf_25(type);
		}

		// Token: 0x0600F96F RID: 63855
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataTransferHelper_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F970 RID: 63856 RVA: 0x0015AAB0 File Offset: 0x00158CB0
		public new vtkDataTransferHelper NewInstance()
		{
			vtkDataTransferHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataTransferHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F971 RID: 63857
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataTransferHelper_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F972 RID: 63858 RVA: 0x0015AB0C File Offset: 0x00158D0C
		public new static vtkDataTransferHelper SafeDownCast(vtkObjectBase o)
		{
			vtkDataTransferHelper vtkDataTransferHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataTransferHelper = (vtkDataTransferHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataTransferHelper.Register(null);
				}
			}
			return vtkDataTransferHelper;
		}

		// Token: 0x0600F973 RID: 63859
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_SetArray_29(HandleRef pThis, HandleRef array);

		/// <summary>
		/// Get/Set the CPU data buffer. Initial value is 0.
		/// </summary>
		// Token: 0x0600F974 RID: 63860 RVA: 0x0015AB8C File Offset: 0x00158D8C
		public void SetArray(vtkDataArray array)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetArray_29(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		// Token: 0x0600F975 RID: 63861
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_SetCPUExtent_30(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set the CPU data extent. The extent matches the vtkDataArray size.
		/// If the vtkDataArray comes from an vtkImageData and it is part of the
		/// point data, it is usually the vtkImageData extent.
		/// It can be on cell data too, but in this case it does not match the
		/// vtkImageData extent.
		/// If the vtkDataArray comes from a vtkDataSet, just
		/// set it to a one-dimenstional extent equal to the number of tuples.
		/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
		/// </summary>
		// Token: 0x0600F976 RID: 63862 RVA: 0x0015ABBB File Offset: 0x00158DBB
		public virtual void SetCPUExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetCPUExtent_30(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600F977 RID: 63863
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_SetCPUExtent_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the CPU data extent. The extent matches the vtkDataArray size.
		/// If the vtkDataArray comes from an vtkImageData and it is part of the
		/// point data, it is usually the vtkImageData extent.
		/// It can be on cell data too, but in this case it does not match the
		/// vtkImageData extent.
		/// If the vtkDataArray comes from a vtkDataSet, just
		/// set it to a one-dimenstional extent equal to the number of tuples.
		/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
		/// </summary>
		// Token: 0x0600F978 RID: 63864 RVA: 0x0015ABD3 File Offset: 0x00158DD3
		public virtual void SetCPUExtent(IntPtr _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetCPUExtent_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F979 RID: 63865
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_SetContext_32(HandleRef pThis, HandleRef context);

		/// <summary>
		/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
		/// This does not increase the reference count of the
		/// context to avoid reference loops.
		/// SetContext() may raise an error if the OpenGL context does not support the
		/// required OpenGL extensions.
		/// </summary>
		// Token: 0x0600F97A RID: 63866 RVA: 0x0015ABE4 File Offset: 0x00158DE4
		public void SetContext(vtkRenderWindow context)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetContext_32(base.GetCppThis(), (context == null) ? default(HandleRef) : context.GetCppThis());
		}

		// Token: 0x0600F97B RID: 63867
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_SetGPUExtent_33(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set the GPU data extent. This is the sub-extent to copy from or to the GPU.
		/// This extent matches the size of the data to transfer.
		/// GPUExtent and TextureExtent don't have to match (GPUExtent can be 1D
		/// whereas TextureExtent is 2D) but the number of elements have to match.
		/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
		/// </summary>
		// Token: 0x0600F97C RID: 63868 RVA: 0x0015AC13 File Offset: 0x00158E13
		public virtual void SetGPUExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetGPUExtent_33(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600F97D RID: 63869
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_SetGPUExtent_34(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the GPU data extent. This is the sub-extent to copy from or to the GPU.
		/// This extent matches the size of the data to transfer.
		/// GPUExtent and TextureExtent don't have to match (GPUExtent can be 1D
		/// whereas TextureExtent is 2D) but the number of elements have to match.
		/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
		/// </summary>
		// Token: 0x0600F97E RID: 63870 RVA: 0x0015AC2B File Offset: 0x00158E2B
		public virtual void SetGPUExtent(IntPtr _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetGPUExtent_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F97F RID: 63871
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_SetMinTextureDimension_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Define the minimal dimension of the texture regardless of the dimensions
		/// of the TextureExtent. Initial value is 1.
		/// A texture extent can have a given dimension 0D (one value), 1D, 2D or 3D.
		/// By default 0D and 1D are translated into a 1D texture, 2D is translated
		/// into a 2D texture, 3D is translated into a 3D texture. To make life easier
		/// when writing GLSL code and use only one type of sampler (ex: sampler2d),
		/// the default behavior can be changed by forcing a type of texture with
		/// this ivar.
		/// 1: default behavior. Initial value.
		/// 2: force 0D and 1D to be in a 2D texture
		/// 3: force 0D, 1D and 2D texture to be in a 3D texture.
		/// </summary>
		// Token: 0x0600F980 RID: 63872 RVA: 0x0015AC3B File Offset: 0x00158E3B
		public virtual void SetMinTextureDimension(int _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetMinTextureDimension_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F981 RID: 63873
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_SetShaderSupportsTextureInt_36(HandleRef pThis, byte value);

		/// <summary>
		/// Splits the download in two operations
		/// * Asynchronously download from texture memory to PBO (DownloadAsync1()).
		/// * Copy from pbo to user array (DownloadAsync2()).
		/// </summary>
		// Token: 0x0600F982 RID: 63874 RVA: 0x0015AC4B File Offset: 0x00158E4B
		public void SetShaderSupportsTextureInt(bool value)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetShaderSupportsTextureInt_36(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F983 RID: 63875
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_SetTextureExtent_37(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set the texture data extent. This is the extent of the texture image that
		/// will receive the data. This extent matches the size of the data to
		/// transfer. If it is set to an invalid extent, GPUExtent is used.
		/// See more comment on GPUExtent.
		/// Initial value is an invalid extent.
		/// </summary>
		// Token: 0x0600F984 RID: 63876 RVA: 0x0015AC63 File Offset: 0x00158E63
		public virtual void SetTextureExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetTextureExtent_37(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600F985 RID: 63877
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataTransferHelper_SetTextureExtent_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the texture data extent. This is the extent of the texture image that
		/// will receive the data. This extent matches the size of the data to
		/// transfer. If it is set to an invalid extent, GPUExtent is used.
		/// See more comment on GPUExtent.
		/// Initial value is an invalid extent.
		/// </summary>
		// Token: 0x0600F986 RID: 63878 RVA: 0x0015AC7B File Offset: 0x00158E7B
		public virtual void SetTextureExtent(IntPtr _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetTextureExtent_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F987 RID: 63879
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataTransferHelper_Upload_39(HandleRef pThis, int components, IntPtr componentList);

		/// <summary>
		/// Old comment.
		/// Upload Extent from CPU data buffer to GPU.
		/// The WholeExtent must match the Array size.
		/// New comment.
		/// Upload GPUExtent from CPU vtkDataArray to GPU texture.
		/// It is possible to send a subset of the components or to specify and
		/// order of components or both. If components=0, componentList is ignored
		/// and all components are passed, a texture cannot have more than 4
		/// components.
		/// \pre array_exists: array!=0
		/// \pre array_not_empty: array-&gt;GetNumberOfTuples()&gt;0
		/// \pre valid_cpu_extent: this-&gt;GetCPUExtentIsValid()
		/// \pre valid_cpu_extent_size:
		/// (CPUExtent[1]-CPUExtent[0]+1)*(CPUExtent[3]-CPUExtent[2]+1)*(CPUExtent[5]-CPUExtent[4]+1)==array-&gt;GetNumberOfTuples()
		/// \pre valid_gpu_extent: this-&gt;GetGPUExtentIsValid()
		/// \pre gpu_extent_in_cpu_extent: CPUExtent[0]&lt;=GPUExtent[0] &amp;&amp; GPUExtent[1]&lt;=CPUExtent[1] &amp;&amp;
		/// CPUExtent[2]&lt;=GPUExtent[2] &amp;&amp; GPUExtent[3]&lt;=CPUExtent[3] &amp;&amp; CPUExtent[4]&lt;=GPUExtent[4] &amp;&amp;
		/// GPUExtent[5]&lt;=CPUExtent[5] \pre gpu_texture_size: !this-&gt;GetTextureExtentIsValid() ||
		/// (GPUExtent[1]-GPUExtent[0]+1)*(GPUExtent[3]-GPUExtent[2]+1)*(GPUExtent[5]-GPUExtent[4]+1)==(TextureExtent[1]-TextureExtent[0]+1)*(TextureExtent[3]-TextureExtent[2]+1)*(TextureExtent[5]-TextureExtent[4]+1)
		/// \pre texture_can_exist_or_not: texture==0 || texture!=0
		/// \pre valid_components: (components==0 &amp;&amp; componentList==0 &amp;&amp; array-&gt;GetNumberOfComponents()&lt;=4)
		/// || (components&gt;=1 &amp;&amp; components&lt;=array-&gt;GetNumberOfComponents() &amp;&amp; components&lt;=4 &amp;&amp;
		/// componentList!=0)
		/// </summary>
		// Token: 0x0600F988 RID: 63880 RVA: 0x0015AC8C File Offset: 0x00158E8C
		public bool Upload(int components, IntPtr componentList)
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_Upload_39(base.GetCppThis(), components, componentList) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001219 RID: 4633
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataTransferHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400121A RID: 4634
		public new static readonly string MRClassNameKey = "class vtkDataTransferHelper";
	}
}
