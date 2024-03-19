using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGLTFImporter
	/// </summary>
	/// <remarks>
	///    Import a GLTF file.
	///
	/// vtkGLTFImporter is a concrete subclass of vtkImporter that reads glTF 2.0
	/// files.
	///
	/// The GL Transmission Format (glTF) is an API-neutral runtime asset delivery format.
	/// A glTF asset is represented by:
	/// - A JSON-formatted file (.gltf) containing a full scene description: node hierarchy, materials,
	///   cameras, as well as descriptor information for meshes, animations, and other constructs
	/// - Binary files (.bin) containing geometry and animation data, and other buffer-based data
	/// - Image files (.jpg, .png) for textures
	///
	/// This importer supports all physically-based rendering material features, with the exception of
	/// alpha masking and mirrored texture wrapping, which are not supported.
	///
	///
	/// This importer does not support materials that use multiple
	/// sets of texture coordinates. Only the first set will be used in this case.
	///
	/// This importer does not support animations, morphing and skinning. If you would like to use
	/// animations, morphing or skinning, please consider using vtkGLTFReader.
	///
	/// This importer only supports assets that use the 2.x version of the glTF specification.
	///
	/// For the full glTF specification, see:
	/// https://github.com/KhronosGroup/glTF/tree/master/specification/2.0
	///
	/// Note: array sizes should not exceed INT_MAX
	///
	/// Supported extensions:
	/// - KHR_lights_punctual :
	///   The importer supports the KHR_lights_punctual extension except for this feature:
	///   - VTK does not support changing the falloff of the cone with innerConeAngle and outerConeAngle.
	///     The importer uses outerConeAngle and ignores innerConeAngle as specified for this situation.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImporter
	/// vtkGLTFReader
	/// </seealso>
	// Token: 0x02000186 RID: 390
	public class vtkGLTFImporter : vtkImporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004AED RID: 19181 RVA: 0x0006D143 File Offset: 0x0006B343
		static vtkGLTFImporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLTFImporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLTFImporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004AEE RID: 19182 RVA: 0x0006D16B File Offset: 0x0006B36B
		public vtkGLTFImporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004AEF RID: 19183
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFImporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004AF0 RID: 19184 RVA: 0x0006D17C File Offset: 0x0006B37C
		public new static vtkGLTFImporter New()
		{
			vtkGLTFImporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFImporter.vtkGLTFImporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLTFImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004AF1 RID: 19185 RVA: 0x0006D1D0 File Offset: 0x0006B3D0
		public vtkGLTFImporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGLTFImporter.vtkGLTFImporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004AF2 RID: 19186 RVA: 0x0006D214 File Offset: 0x0006B414
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004AF3 RID: 19187
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFImporter_DisableAnimation_01(HandleRef pThis, long animationIndex);

		/// <summary>
		/// Enable/Disable/Get the status of specific animations
		/// </summary>
		// Token: 0x06004AF4 RID: 19188 RVA: 0x0006D21F File Offset: 0x0006B41F
		public override void DisableAnimation(long animationIndex)
		{
			vtkGLTFImporter.vtkGLTFImporter_DisableAnimation_01(base.GetCppThis(), animationIndex);
		}

		// Token: 0x06004AF5 RID: 19189
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFImporter_EnableAnimation_02(HandleRef pThis, long animationIndex);

		/// <summary>
		/// Enable/Disable/Get the status of specific animations
		/// </summary>
		// Token: 0x06004AF6 RID: 19190 RVA: 0x0006D22F File Offset: 0x0006B42F
		public override void EnableAnimation(long animationIndex)
		{
			vtkGLTFImporter.vtkGLTFImporter_EnableAnimation_02(base.GetCppThis(), animationIndex);
		}

		// Token: 0x06004AF7 RID: 19191
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkGLTFImporter_GetAnimationName_03(HandleRef pThis, long animationIndex);

		/// <summary>
		/// Return the name of the animation.
		/// </summary>
		// Token: 0x06004AF8 RID: 19192 RVA: 0x0006D240 File Offset: 0x0006B440
		public override string GetAnimationName(long animationIndex)
		{
			return vtkGLTFImporter.vtkGLTFImporter_GetAnimationName_03(base.GetCppThis(), animationIndex);
		}

		// Token: 0x06004AF9 RID: 19193
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkGLTFImporter_GetCameraName_04(HandleRef pThis, long camIndex);

		/// <summary>
		/// Get the name of a camera.
		/// </summary>
		// Token: 0x06004AFA RID: 19194 RVA: 0x0006D260 File Offset: 0x0006B460
		public override string GetCameraName(long camIndex)
		{
			return vtkGLTFImporter.vtkGLTFImporter_GetCameraName_04(base.GetCppThis(), camIndex);
		}

		// Token: 0x06004AFB RID: 19195
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFImporter_GetFileName_05(HandleRef pThis);

		/// <summary>
		/// Specify the name of the file to read.
		/// </summary>
		// Token: 0x06004AFC RID: 19196 RVA: 0x0006D280 File Offset: 0x0006B480
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGLTFImporter.vtkGLTFImporter_GetFileName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004AFD RID: 19197
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFImporter_GetNumberOfAnimations_06(HandleRef pThis);

		/// <summary>
		/// Get the number of available animations.
		/// </summary>
		// Token: 0x06004AFE RID: 19198 RVA: 0x0006D2BC File Offset: 0x0006B4BC
		public override long GetNumberOfAnimations()
		{
			return vtkGLTFImporter.vtkGLTFImporter_GetNumberOfAnimations_06(base.GetCppThis());
		}

		// Token: 0x06004AFF RID: 19199
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFImporter_GetNumberOfCameras_07(HandleRef pThis);

		/// <summary>
		/// Get the number of available cameras.
		/// </summary>
		// Token: 0x06004B00 RID: 19200 RVA: 0x0006D2DC File Offset: 0x0006B4DC
		public override long GetNumberOfCameras()
		{
			return vtkGLTFImporter.vtkGLTFImporter_GetNumberOfCameras_07(base.GetCppThis());
		}

		// Token: 0x06004B01 RID: 19201
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFImporter_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B02 RID: 19202 RVA: 0x0006D2FC File Offset: 0x0006B4FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGLTFImporter.vtkGLTFImporter_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06004B03 RID: 19203
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFImporter_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B04 RID: 19204 RVA: 0x0006D31C File Offset: 0x0006B51C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGLTFImporter.vtkGLTFImporter_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06004B05 RID: 19205
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkGLTFImporter_GetOutputsDescription_10(HandleRef pThis);

		/// <summary>
		/// Get a printable string describing all outputs
		/// </summary>
		// Token: 0x06004B06 RID: 19206 RVA: 0x0006D338 File Offset: 0x0006B538
		public override string GetOutputsDescription()
		{
			return vtkGLTFImporter.vtkGLTFImporter_GetOutputsDescription_10(base.GetCppThis());
		}

		// Token: 0x06004B07 RID: 19207
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFImporter_GetTemporalInformation_11(HandleRef pThis, long animationIndex, double frameRate, ref int nbTimeSteps, IntPtr timeRange, HandleRef timeSteps);

		/// <summary>
		/// Get temporal information for the provided animationIndex and frameRate.
		/// frameRate is used to define the number of frames for one second of simulation,
		/// set to zero if timeSteps are not needed.
		/// If animation is present in the dataset, timeRange will be set by this method, return true.
		/// If animation is present and frameRate &gt; 0, nbTimeSteps and timeSteps will also be set, return
		/// true. If animation is not present, return false.
		/// </summary>
		// Token: 0x06004B08 RID: 19208 RVA: 0x0006D358 File Offset: 0x0006B558
		public override bool GetTemporalInformation(long animationIndex, double frameRate, ref int nbTimeSteps, IntPtr timeRange, vtkDoubleArray timeSteps)
		{
			return vtkGLTFImporter.vtkGLTFImporter_GetTemporalInformation_11(base.GetCppThis(), animationIndex, frameRate, ref nbTimeSteps, timeRange, (timeSteps == null) ? default(HandleRef) : timeSteps.GetCppThis()) != 0;
		}

		// Token: 0x06004B09 RID: 19209
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLTFImporter_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B0A RID: 19210 RVA: 0x0006D39C File Offset: 0x0006B59C
		public override int IsA(string type)
		{
			return vtkGLTFImporter.vtkGLTFImporter_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06004B0B RID: 19211
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFImporter_IsAnimationEnabled_13(HandleRef pThis, long animationIndex);

		/// <summary>
		/// Enable/Disable/Get the status of specific animations
		/// </summary>
		// Token: 0x06004B0C RID: 19212 RVA: 0x0006D3BC File Offset: 0x0006B5BC
		public override bool IsAnimationEnabled(long animationIndex)
		{
			return vtkGLTFImporter.vtkGLTFImporter_IsAnimationEnabled_13(base.GetCppThis(), animationIndex) != 0;
		}

		// Token: 0x06004B0D RID: 19213
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLTFImporter_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B0E RID: 19214 RVA: 0x0006D3E4 File Offset: 0x0006B5E4
		public new static int IsTypeOf(string type)
		{
			return vtkGLTFImporter.vtkGLTFImporter_IsTypeOf_14(type);
		}

		// Token: 0x06004B0F RID: 19215
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFImporter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B10 RID: 19216 RVA: 0x0006D400 File Offset: 0x0006B600
		public new vtkGLTFImporter NewInstance()
		{
			vtkGLTFImporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFImporter.vtkGLTFImporter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLTFImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004B11 RID: 19217
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFImporter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B12 RID: 19218 RVA: 0x0006D45C File Offset: 0x0006B65C
		public new static vtkGLTFImporter SafeDownCast(vtkObjectBase o)
		{
			vtkGLTFImporter vtkGLTFImporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFImporter.vtkGLTFImporter_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLTFImporter = (vtkGLTFImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLTFImporter.Register(null);
				}
			}
			return vtkGLTFImporter;
		}

		// Token: 0x06004B13 RID: 19219
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFImporter_SetCamera_18(HandleRef pThis, long camIndex);

		/// <summary>
		/// Enable a specific camera.
		/// If a negative index is provided, no camera from the importer is used.
		/// </summary>
		// Token: 0x06004B14 RID: 19220 RVA: 0x0006D4DB File Offset: 0x0006B6DB
		public override void SetCamera(long camIndex)
		{
			vtkGLTFImporter.vtkGLTFImporter_SetCamera_18(base.GetCppThis(), camIndex);
		}

		// Token: 0x06004B15 RID: 19221
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFImporter_SetFileName_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the file to read.
		/// </summary>
		// Token: 0x06004B16 RID: 19222 RVA: 0x0006D4EB File Offset: 0x0006B6EB
		public virtual void SetFileName(string _arg)
		{
			vtkGLTFImporter.vtkGLTFImporter_SetFileName_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06004B17 RID: 19223
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFImporter_UpdateTimeStep_20(HandleRef pThis, double timeValue);

		/// <summary>
		/// update timestep
		/// </summary>
		// Token: 0x06004B18 RID: 19224 RVA: 0x0006D4FB File Offset: 0x0006B6FB
		public override void UpdateTimeStep(double timeValue)
		{
			vtkGLTFImporter.vtkGLTFImporter_UpdateTimeStep_20(base.GetCppThis(), timeValue);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400075D RID: 1885
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLTFImporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400075E RID: 1886
		public new static readonly string MRClassNameKey = "class vtkGLTFImporter";
	}
}
