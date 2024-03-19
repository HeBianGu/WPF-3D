using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGLTFReader
	/// </summary>
	/// <remarks>
	///    Read a GLTF file.
	///
	/// vtkGLTFReader is a concrete subclass of vtkMultiBlockDataSetAlgorithm that reads glTF 2.0 files.
	///
	/// The GL Transmission Format (glTF) is an API-neutral runtime asset delivery format.
	/// A glTF asset is represented by:
	/// - A JSON-formatted file (.gltf) containing a full scene description: node hierarchy, materials,
	///   cameras, as well as descriptor information for meshes, animations, and other constructs
	/// - Binary files (.bin) containing geometry and animation data, and other buffer-based data
	/// - Image files (.jpg, .png) for textures
	///
	/// This reader currently outputs a vtkMultiBlockDataSet containing geometry information
	/// for the current selected scene, with animations, skins and morph targets applied, unless
	/// configured not to (see ApplyDeformationsToGeometry).
	///
	/// It is possible to get information about available scenes and animations by using the
	/// corresponding accessors.
	/// To use animations, first call SetFramerate with a non-zero value,
	/// then use EnableAnimation or DisableAnimation to configure which animations you would like to
	/// apply to the geometry.
	/// Finally, use UPDATE_TIME_STEPS to choose which frame to apply.
	/// If ApplyDeformationsToGeometry is set to true, the reader will apply the deformations, otherwise,
	/// animation transformation information will be saved to the dataset's FieldData.
	///
	/// Materials are currently not supported in this reader. If you would like to display materials,
	/// please try using vtkGLTFImporter.
	/// You could also use vtkGLTFReader::GetGLTFTexture, to access the image data that was loaded from
	/// the glTF 2.0 document.
	///
	/// This reader only supports assets that use the 2.x version of the glTF specification.
	///
	/// If Stream is not nullptr, it will have priority against FileName.
	///
	/// For the full glTF specification, see:
	/// https://github.com/KhronosGroup/glTF/tree/master/specification/2.0
	///
	/// Note: array sizes should not exceed INT_MAX
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMultiBlockDataSetAlgorithm
	/// vtkGLTFImporter
	/// </seealso>
	// Token: 0x02000204 RID: 516
	public class vtkGLTFReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600629E RID: 25246 RVA: 0x0008DFCF File Offset: 0x0008C1CF
		static vtkGLTFReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLTFReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLTFReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600629F RID: 25247 RVA: 0x0008DFF7 File Offset: 0x0008C1F7
		public vtkGLTFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060062A0 RID: 25248
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060062A1 RID: 25249 RVA: 0x0008E008 File Offset: 0x0008C208
		public new static vtkGLTFReader New()
		{
			vtkGLTFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFReader.vtkGLTFReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLTFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060062A2 RID: 25250 RVA: 0x0008E05C File Offset: 0x0008C25C
		public vtkGLTFReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGLTFReader.vtkGLTFReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060062A3 RID: 25251 RVA: 0x0008E0A0 File Offset: 0x0008C2A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060062A4 RID: 25252
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFReader_ApplyDeformationsToGeometryOff_01(HandleRef pThis);

		/// <summary>
		/// The model's skinning transforms are computed and added to the different vtkPolyData objects'
		/// field data.
		/// If this flag is set to true, the reader will apply those skinning transforms to the model's
		/// geometry.
		/// </summary>
		// Token: 0x060062A5 RID: 25253 RVA: 0x0008E0AB File Offset: 0x0008C2AB
		public virtual void ApplyDeformationsToGeometryOff()
		{
			vtkGLTFReader.vtkGLTFReader_ApplyDeformationsToGeometryOff_01(base.GetCppThis());
		}

		// Token: 0x060062A6 RID: 25254
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFReader_ApplyDeformationsToGeometryOn_02(HandleRef pThis);

		/// <summary>
		/// The model's skinning transforms are computed and added to the different vtkPolyData objects'
		/// field data.
		/// If this flag is set to true, the reader will apply those skinning transforms to the model's
		/// geometry.
		/// </summary>
		// Token: 0x060062A7 RID: 25255 RVA: 0x0008E0BA File Offset: 0x0008C2BA
		public virtual void ApplyDeformationsToGeometryOn()
		{
			vtkGLTFReader.vtkGLTFReader_ApplyDeformationsToGeometryOn_02(base.GetCppThis());
		}

		// Token: 0x060062A8 RID: 25256
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFReader_DisableAnimation_03(HandleRef pThis, long animationIndex);

		/// <summary>
		/// Enable/Disable an animation. The reader will apply all enabled animations to the model's
		/// transformations, at the specified time step. Use UPDATE_TIME_STEP to select which frame should
		/// be applied.
		/// </summary>
		// Token: 0x060062A9 RID: 25257 RVA: 0x0008E0C9 File Offset: 0x0008C2C9
		public void DisableAnimation(long animationIndex)
		{
			vtkGLTFReader.vtkGLTFReader_DisableAnimation_03(base.GetCppThis(), animationIndex);
		}

		// Token: 0x060062AA RID: 25258
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFReader_EnableAnimation_04(HandleRef pThis, long animationIndex);

		/// <summary>
		/// Enable/Disable an animation. The reader will apply all enabled animations to the model's
		/// transformations, at the specified time step. Use UPDATE_TIME_STEP to select which frame should
		/// be applied.
		/// </summary>
		// Token: 0x060062AB RID: 25259 RVA: 0x0008E0D9 File Offset: 0x0008C2D9
		public void EnableAnimation(long animationIndex)
		{
			vtkGLTFReader.vtkGLTFReader_EnableAnimation_04(base.GetCppThis(), animationIndex);
		}

		// Token: 0x060062AC RID: 25260
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFReader_GetAllSceneNames_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a list all scenes names as a vtkStringArray, with duplicate names numbered and empty names
		/// replaced by a generic name. All names are guaranteed to be unique, and their index in the array
		/// matches the glTF document's scene indices.
		/// </summary>
		// Token: 0x060062AD RID: 25261 RVA: 0x0008E0EC File Offset: 0x0008C2EC
		public vtkStringArray GetAllSceneNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFReader.vtkGLTFReader_GetAllSceneNames_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060062AE RID: 25262
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGLTFReader_GetAnimationDuration_06(HandleRef pThis, long animationIndex);

		/// <summary>
		/// glTF models can contain multiple animations, with various names and duration. glTF does not
		/// specify however any runtime behavior (order of playing, auto-start, loops, mapping of
		/// timelines, etc), which is why no animation is enabled by default.
		/// These accessors expose metadata information about a model's available animations.
		/// </summary>
		// Token: 0x060062AF RID: 25263 RVA: 0x0008E15C File Offset: 0x0008C35C
		public float GetAnimationDuration(long animationIndex)
		{
			return vtkGLTFReader.vtkGLTFReader_GetAnimationDuration_06(base.GetCppThis(), animationIndex);
		}

		// Token: 0x060062B0 RID: 25264
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkGLTFReader_GetAnimationName_07(HandleRef pThis, long animationIndex);

		/// <summary>
		/// glTF models can contain multiple animations, with various names and duration. glTF does not
		/// specify however any runtime behavior (order of playing, auto-start, loops, mapping of
		/// timelines, etc), which is why no animation is enabled by default.
		/// These accessors expose metadata information about a model's available animations.
		/// </summary>
		// Token: 0x060062B1 RID: 25265 RVA: 0x0008E17C File Offset: 0x0008C37C
		public string GetAnimationName(long animationIndex)
		{
			return vtkGLTFReader.vtkGLTFReader_GetAnimationName_07(base.GetCppThis(), animationIndex);
		}

		// Token: 0x060062B2 RID: 25266
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFReader_GetAnimationSelection_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkDataArraySelection object to enable/disable animations.
		/// </summary>
		// Token: 0x060062B3 RID: 25267 RVA: 0x0008E19C File Offset: 0x0008C39C
		public vtkDataArraySelection GetAnimationSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFReader.vtkGLTFReader_GetAnimationSelection_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x060062B4 RID: 25268
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFReader_GetApplyDeformationsToGeometry_09(HandleRef pThis);

		/// <summary>
		/// The model's skinning transforms are computed and added to the different vtkPolyData objects'
		/// field data.
		/// If this flag is set to true, the reader will apply those skinning transforms to the model's
		/// geometry.
		/// </summary>
		// Token: 0x060062B5 RID: 25269 RVA: 0x0008E20C File Offset: 0x0008C40C
		public virtual bool GetApplyDeformationsToGeometry()
		{
			return vtkGLTFReader.vtkGLTFReader_GetApplyDeformationsToGeometry_09(base.GetCppThis()) != 0;
		}

		// Token: 0x060062B6 RID: 25270
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFReader_GetCurrentScene_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the scene to be used by the reader
		/// </summary>
		// Token: 0x060062B7 RID: 25271 RVA: 0x0008E234 File Offset: 0x0008C434
		public virtual long GetCurrentScene()
		{
			return vtkGLTFReader.vtkGLTFReader_GetCurrentScene_10(base.GetCppThis());
		}

		// Token: 0x060062B8 RID: 25272
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFReader_GetFileName_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the file from which to read points.
		/// </summary>
		// Token: 0x060062B9 RID: 25273 RVA: 0x0008E254 File Offset: 0x0008C454
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGLTFReader.vtkGLTFReader_GetFileName_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060062BA RID: 25274
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkGLTFReader_GetFrameRate_12(HandleRef pThis);

		/// <summary>
		/// Get/Set the rate at which animations will be sampled:
		/// the glTF format does not have the concept of static timesteps.
		/// TimeSteps are generated, during the REQUEST_INFORMATION pass,
		/// as linearly interpolated time values between 0s and the animations' maximum durations,
		/// sampled at the specified frame rate.
		/// Use the TIME_STEPS information key to obtain integer indices to each of these steps.
		/// Set to 0 to not set any TIME_STEPS and only provide a TIME_RANGE.
		/// </summary>
		// Token: 0x060062BB RID: 25275 RVA: 0x0008E290 File Offset: 0x0008C490
		public virtual uint GetFrameRate()
		{
			return vtkGLTFReader.vtkGLTFReader_GetFrameRate_12(base.GetCppThis());
		}

		// Token: 0x060062BC RID: 25276
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFReader_GetNumberOfAnimations_13(HandleRef pThis);

		/// <summary>
		/// glTF models can contain multiple animations, with various names and duration. glTF does not
		/// specify however any runtime behavior (order of playing, auto-start, loops, mapping of
		/// timelines, etc), which is why no animation is enabled by default.
		/// These accessors expose metadata information about a model's available animations.
		/// </summary>
		// Token: 0x060062BD RID: 25277 RVA: 0x0008E2B0 File Offset: 0x0008C4B0
		public virtual long GetNumberOfAnimations()
		{
			return vtkGLTFReader.vtkGLTFReader_GetNumberOfAnimations_13(base.GetCppThis());
		}

		// Token: 0x060062BE RID: 25278
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFReader_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060062BF RID: 25279 RVA: 0x0008E2D0 File Offset: 0x0008C4D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGLTFReader.vtkGLTFReader_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x060062C0 RID: 25280
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFReader_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060062C1 RID: 25281 RVA: 0x0008E2F0 File Offset: 0x0008C4F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGLTFReader.vtkGLTFReader_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x060062C2 RID: 25282
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFReader_GetNumberOfScenes_16(HandleRef pThis);

		/// <summary>
		/// glTF models can contain multiple scene descriptions.
		/// These accessors expose metadata information about a model's available scenes.
		/// </summary>
		// Token: 0x060062C3 RID: 25283 RVA: 0x0008E30C File Offset: 0x0008C50C
		public virtual long GetNumberOfScenes()
		{
			return vtkGLTFReader.vtkGLTFReader_GetNumberOfScenes_16(base.GetCppThis());
		}

		// Token: 0x060062C4 RID: 25284
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFReader_GetNumberOfTextures_17(HandleRef pThis);

		/// <summary>
		/// Materials are not directly applied to this reader's output.
		/// Use GetGLTFTexture to access a specific texture's image data, and the indices present in the
		/// output dataset's field data to create vtkTextures and apply them to the geometry.
		/// </summary>
		// Token: 0x060062C5 RID: 25285 RVA: 0x0008E32C File Offset: 0x0008C52C
		public long GetNumberOfTextures()
		{
			return vtkGLTFReader.vtkGLTFReader_GetNumberOfTextures_17(base.GetCppThis());
		}

		// Token: 0x060062C6 RID: 25286
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkGLTFReader_GetSceneName_18(HandleRef pThis, long sceneIndex);

		/// <summary>
		/// glTF models can contain multiple scene descriptions.
		/// These accessors expose metadata information about a model's available scenes.
		/// </summary>
		// Token: 0x060062C7 RID: 25287 RVA: 0x0008E34C File Offset: 0x0008C54C
		public string GetSceneName(long sceneIndex)
		{
			return vtkGLTFReader.vtkGLTFReader_GetSceneName_18(base.GetCppThis(), sceneIndex);
		}

		// Token: 0x060062C8 RID: 25288
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFReader_GetStream_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the stream from which to read the glTF.
		/// If Stream is not nullptr, it will have priority against FileName
		/// </summary>
		// Token: 0x060062C9 RID: 25289 RVA: 0x0008E36C File Offset: 0x0008C56C
		public virtual vtkResourceStream GetStream()
		{
			vtkResourceStream vtkResourceStream = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFReader.vtkGLTFReader_GetStream_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResourceStream = (vtkResourceStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResourceStream.Register(null);
				}
			}
			return vtkResourceStream;
		}

		// Token: 0x060062CA RID: 25290
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFReader_GetURILoader_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the URI loader to use when reading from a Stream.
		/// `URILoader` will be used to locate and load other files referenced in the glTF file.
		/// If no URI loader is set when reading through a stream, only single file glTF can be read.
		/// </summary>
		// Token: 0x060062CB RID: 25291 RVA: 0x0008E3DC File Offset: 0x0008C5DC
		public virtual vtkURILoader GetURILoader()
		{
			vtkURILoader vtkURILoader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFReader.vtkGLTFReader_GetURILoader_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkURILoader = (vtkURILoader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkURILoader.Register(null);
				}
			}
			return vtkURILoader;
		}

		// Token: 0x060062CC RID: 25292
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLTFReader_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060062CD RID: 25293 RVA: 0x0008E44C File Offset: 0x0008C64C
		public override int IsA(string type)
		{
			return vtkGLTFReader.vtkGLTFReader_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x060062CE RID: 25294
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFReader_IsAnimationEnabled_22(HandleRef pThis, long animationIndex);

		/// <summary>
		/// Enable/Disable an animation. The reader will apply all enabled animations to the model's
		/// transformations, at the specified time step. Use UPDATE_TIME_STEP to select which frame should
		/// be applied.
		/// </summary>
		// Token: 0x060062CF RID: 25295 RVA: 0x0008E46C File Offset: 0x0008C66C
		public bool IsAnimationEnabled(long animationIndex)
		{
			return vtkGLTFReader.vtkGLTFReader_IsAnimationEnabled_22(base.GetCppThis(), animationIndex) != 0;
		}

		// Token: 0x060062D0 RID: 25296
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLTFReader_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060062D1 RID: 25297 RVA: 0x0008E494 File Offset: 0x0008C694
		public new static int IsTypeOf(string type)
		{
			return vtkGLTFReader.vtkGLTFReader_IsTypeOf_23(type);
		}

		// Token: 0x060062D2 RID: 25298
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFReader_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060062D3 RID: 25299 RVA: 0x0008E4B0 File Offset: 0x0008C6B0
		public new vtkGLTFReader NewInstance()
		{
			vtkGLTFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFReader.vtkGLTFReader_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLTFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060062D4 RID: 25300
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFReader_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060062D5 RID: 25301 RVA: 0x0008E50C File Offset: 0x0008C70C
		public new static vtkGLTFReader SafeDownCast(vtkObjectBase o)
		{
			vtkGLTFReader vtkGLTFReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFReader.vtkGLTFReader_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLTFReader = (vtkGLTFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLTFReader.Register(null);
				}
			}
			return vtkGLTFReader;
		}

		// Token: 0x060062D6 RID: 25302
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFReader_SetApplyDeformationsToGeometry_27(HandleRef pThis, byte flag);

		/// <summary>
		/// The model's skinning transforms are computed and added to the different vtkPolyData objects'
		/// field data.
		/// If this flag is set to true, the reader will apply those skinning transforms to the model's
		/// geometry.
		/// </summary>
		// Token: 0x060062D7 RID: 25303 RVA: 0x0008E58B File Offset: 0x0008C78B
		public void SetApplyDeformationsToGeometry(bool flag)
		{
			vtkGLTFReader.vtkGLTFReader_SetApplyDeformationsToGeometry_27(base.GetCppThis(), flag ? (byte)1 : (byte)0);
		}

		// Token: 0x060062D8 RID: 25304
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFReader_SetCurrentScene_28(HandleRef pThis, long _arg);

		/// <summary>
		/// Get/Set the scene to be used by the reader
		/// </summary>
		// Token: 0x060062D9 RID: 25305 RVA: 0x0008E5A3 File Offset: 0x0008C7A3
		public virtual void SetCurrentScene(long _arg)
		{
			vtkGLTFReader.vtkGLTFReader_SetCurrentScene_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060062DA RID: 25306
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFReader_SetFileName_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the file from which to read points.
		/// </summary>
		// Token: 0x060062DB RID: 25307 RVA: 0x0008E5B3 File Offset: 0x0008C7B3
		public virtual void SetFileName(string _arg)
		{
			vtkGLTFReader.vtkGLTFReader_SetFileName_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060062DC RID: 25308
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFReader_SetFrameRate_30(HandleRef pThis, uint _arg);

		/// <summary>
		/// Get/Set the rate at which animations will be sampled:
		/// the glTF format does not have the concept of static timesteps.
		/// TimeSteps are generated, during the REQUEST_INFORMATION pass,
		/// as linearly interpolated time values between 0s and the animations' maximum durations,
		/// sampled at the specified frame rate.
		/// Use the TIME_STEPS information key to obtain integer indices to each of these steps.
		/// Set to 0 to not set any TIME_STEPS and only provide a TIME_RANGE.
		/// </summary>
		// Token: 0x060062DD RID: 25309 RVA: 0x0008E5C3 File Offset: 0x0008C7C3
		public virtual void SetFrameRate(uint _arg)
		{
			vtkGLTFReader.vtkGLTFReader_SetFrameRate_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060062DE RID: 25310
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFReader_SetScene_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string scene);

		/// <summary>
		/// Get/Set the scene to be used by the reader
		/// </summary>
		// Token: 0x060062DF RID: 25311 RVA: 0x0008E5D3 File Offset: 0x0008C7D3
		public void SetScene(string scene)
		{
			vtkGLTFReader.vtkGLTFReader_SetScene_31(base.GetCppThis(), scene);
		}

		// Token: 0x060062E0 RID: 25312
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFReader_SetStream_32(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set/Get the stream from which to read the glTF.
		/// If Stream is not nullptr, it will have priority against FileName
		/// </summary>
		// Token: 0x060062E1 RID: 25313 RVA: 0x0008E5E4 File Offset: 0x0008C7E4
		public virtual void SetStream(vtkResourceStream _arg)
		{
			vtkGLTFReader.vtkGLTFReader_SetStream_32(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x060062E2 RID: 25314
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFReader_SetURILoader_33(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set/Get the URI loader to use when reading from a Stream.
		/// `URILoader` will be used to locate and load other files referenced in the glTF file.
		/// If no URI loader is set when reading through a stream, only single file glTF can be read.
		/// </summary>
		// Token: 0x060062E3 RID: 25315 RVA: 0x0008E614 File Offset: 0x0008C814
		public virtual void SetURILoader(vtkURILoader _arg)
		{
			vtkGLTFReader.vtkGLTFReader_SetURILoader_33(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008DF RID: 2271
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLTFReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008E0 RID: 2272
		public new static readonly string MRClassNameKey = "class vtkGLTFReader";
	}
}
