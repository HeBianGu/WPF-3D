using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGLTFDocumentLoader
	/// </summary>
	/// <remarks>
	///    Deserialize a GLTF model file.
	///
	///
	/// vtkGLTFDocument loader is an internal utility class which defines data structures and functions
	/// with the purpose of deserializing a glTF model from a glTF file, loading its data from binary
	/// buffers and creating vtk objects with the extracted geometry.
	/// It contains an internal Model structure into which all loading is performed.
	///
	/// The GL Transmission Format (glTF) is an API-neutral runtime asset delivery format.
	/// A glTF asset is represented by:
	/// - A JSON-formatted file (.gltf) containing a full scene description: node hierarchy, materials,
	///   cameras, as well as descriptor information for meshes, animations, and other constructs
	/// - Binary files (.bin) containing geometry and animation data, and other buffer-based data
	/// - Image files (.jpg, .png) for textures
	///
	/// For the full specification, see:
	/// https://github.com/KhronosGroup/glTF/tree/master/specification/2.0
	/// </remarks>
	// Token: 0x02000200 RID: 512
	public class vtkGLTFDocumentLoader : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600627E RID: 25214 RVA: 0x0008DC93 File Offset: 0x0008BE93
		static vtkGLTFDocumentLoader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLTFDocumentLoader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLTFDocumentLoader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600627F RID: 25215 RVA: 0x0008DCBB File Offset: 0x0008BEBB
		public vtkGLTFDocumentLoader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006280 RID: 25216
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFDocumentLoader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006281 RID: 25217 RVA: 0x0008DCCC File Offset: 0x0008BECC
		public new static vtkGLTFDocumentLoader New()
		{
			vtkGLTFDocumentLoader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLTFDocumentLoader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006282 RID: 25218 RVA: 0x0008DD20 File Offset: 0x0008BF20
		public vtkGLTFDocumentLoader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006283 RID: 25219 RVA: 0x0008DD64 File Offset: 0x0008BF64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006284 RID: 25220
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFDocumentLoader_ApplyAnimation_01(HandleRef pThis, float t, int animationId, byte forceStep);

		/// <summary>
		/// Apply the specified animation, at the specified time value t, to the internal Model. Changes
		/// node transforms and morphing weights.
		/// </summary>
		// Token: 0x06006285 RID: 25221 RVA: 0x0008DD70 File Offset: 0x0008BF70
		public bool ApplyAnimation(float t, int animationId, bool forceStep)
		{
			return vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_ApplyAnimation_01(base.GetCppThis(), t, animationId, forceStep ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x06006286 RID: 25222
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFDocumentLoader_BuildGlobalTransforms_02(HandleRef pThis);

		/// <summary>
		/// Build all global transforms
		/// </summary>
		// Token: 0x06006287 RID: 25223 RVA: 0x0008DDA1 File Offset: 0x0008BFA1
		public void BuildGlobalTransforms()
		{
			vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_BuildGlobalTransforms_02(base.GetCppThis());
		}

		// Token: 0x06006288 RID: 25224
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFDocumentLoader_BuildModelVTKGeometry_03(HandleRef pThis);

		/// <summary>
		/// Converts the internal Model's loaded data into more convenient vtk objects.
		/// </summary>
		// Token: 0x06006289 RID: 25225 RVA: 0x0008DDB0 File Offset: 0x0008BFB0
		public bool BuildModelVTKGeometry()
		{
			return vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_BuildModelVTKGeometry_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600628A RID: 25226
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkGLTFDocumentLoader_GetNumberOfComponentsForType_04(vtkGLTFDocumentLoader.AccessorType type);

		/// <summary>
		/// Returns the number of components for a given accessor type.
		/// </summary>
		// Token: 0x0600628B RID: 25227 RVA: 0x0008DDD8 File Offset: 0x0008BFD8
		public static uint GetNumberOfComponentsForType(vtkGLTFDocumentLoader.AccessorType type)
		{
			return vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_GetNumberOfComponentsForType_04(type);
		}

		// Token: 0x0600628C RID: 25228
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFDocumentLoader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600628D RID: 25229 RVA: 0x0008DDF4 File Offset: 0x0008BFF4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600628E RID: 25230
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFDocumentLoader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600628F RID: 25231 RVA: 0x0008DE14 File Offset: 0x0008C014
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06006290 RID: 25232
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLTFDocumentLoader_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006291 RID: 25233 RVA: 0x0008DE30 File Offset: 0x0008C030
		public override int IsA(string type)
		{
			return vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06006292 RID: 25234
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLTFDocumentLoader_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006293 RID: 25235 RVA: 0x0008DE50 File Offset: 0x0008C050
		public new static int IsTypeOf(string type)
		{
			return vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_IsTypeOf_08(type);
		}

		// Token: 0x06006294 RID: 25236
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFDocumentLoader_LoadModelMetaDataFromFile_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string FileName);

		/// <summary>
		/// @brief Reset internal Model struct, and serialize glTF metadata (all json information) into it.
		///
		/// To load buffers, use LoadModelData.
		/// Input can either be a file (LoadModelMetaDataFromFile) or a stream + optional URI loader.
		///
		/// @return `true` if internal model is correctly filled, `false` otherwise.
		/// </summary>
		// Token: 0x06006295 RID: 25237 RVA: 0x0008DE6C File Offset: 0x0008C06C
		public bool LoadModelMetaDataFromFile(string FileName)
		{
			return vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_LoadModelMetaDataFromFile_09(base.GetCppThis(), FileName) != 0;
		}

		// Token: 0x06006296 RID: 25238
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFDocumentLoader_LoadModelMetaDataFromStream_10(HandleRef pThis, HandleRef stream, HandleRef loader);

		/// <summary>
		/// @brief Reset internal Model struct, and serialize glTF metadata (all json information) into it.
		///
		/// To load buffers, use LoadModelData.
		/// Input can either be a file (LoadModelMetaDataFromFile) or a stream + optional URI loader.
		///
		/// @return `true` if internal model is correctly filled, `false` otherwise.
		/// </summary>
		// Token: 0x06006297 RID: 25239 RVA: 0x0008DE94 File Offset: 0x0008C094
		public bool LoadModelMetaDataFromStream(vtkResourceStream stream, vtkURILoader loader)
		{
			return vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_LoadModelMetaDataFromStream_10(base.GetCppThis(), (stream == null) ? default(HandleRef) : stream.GetCppThis(), (loader == null) ? default(HandleRef) : loader.GetCppThis()) != 0;
		}

		// Token: 0x06006298 RID: 25240
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFDocumentLoader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006299 RID: 25241 RVA: 0x0008DEE4 File Offset: 0x0008C0E4
		public new vtkGLTFDocumentLoader NewInstance()
		{
			vtkGLTFDocumentLoader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLTFDocumentLoader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600629A RID: 25242
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFDocumentLoader_ResetAnimation_13(HandleRef pThis, int animationId);

		/// <summary>
		/// Restore the transforms that were modified by an animation to their initial state
		/// </summary>
		// Token: 0x0600629B RID: 25243 RVA: 0x0008DF3E File Offset: 0x0008C13E
		public void ResetAnimation(int animationId)
		{
			vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_ResetAnimation_13(base.GetCppThis(), animationId);
		}

		// Token: 0x0600629C RID: 25244
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFDocumentLoader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600629D RID: 25245 RVA: 0x0008DF50 File Offset: 0x0008C150
		public new static vtkGLTFDocumentLoader SafeDownCast(vtkObjectBase o)
		{
			vtkGLTFDocumentLoader vtkGLTFDocumentLoader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFDocumentLoader.vtkGLTFDocumentLoader_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLTFDocumentLoader = (vtkGLTFDocumentLoader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLTFDocumentLoader.Register(null);
				}
			}
			return vtkGLTFDocumentLoader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008CA RID: 2250
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLTFDocumentLoader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008CB RID: 2251
		public new static readonly string MRClassNameKey = "class vtkGLTFDocumentLoader";

		/// <summary>
		/// Defines an accessor's type. These are defined as strings in the glTF specification.
		/// Each type implies a specific number of components.
		/// </summary>
		// Token: 0x02000201 RID: 513
		public enum AccessorType
		{
			/// <summary>enum member</summary>
			// Token: 0x040008CD RID: 2253
			INVALID = 7,
			/// <summary>enum member</summary>
			// Token: 0x040008CE RID: 2254
			MAT2 = 4,
			/// <summary>enum member</summary>
			// Token: 0x040008CF RID: 2255
			MAT3,
			/// <summary>enum member</summary>
			// Token: 0x040008D0 RID: 2256
			MAT4,
			/// <summary>enum member</summary>
			// Token: 0x040008D1 RID: 2257
			SCALAR = 0,
			/// <summary>enum member</summary>
			// Token: 0x040008D2 RID: 2258
			VEC2,
			/// <summary>enum member</summary>
			// Token: 0x040008D3 RID: 2259
			VEC3,
			/// <summary>enum member</summary>
			// Token: 0x040008D4 RID: 2260
			VEC4
		}

		/// <summary>
		/// Define a type for different data components. Values match with the corresponding GLenum, as
		/// they are used in the glTF specification.
		/// </summary>
		// Token: 0x02000202 RID: 514
		public enum ComponentType
		{
			/// <summary>enum member</summary>
			// Token: 0x040008D6 RID: 2262
			BYTE = 5120,
			/// <summary>enum member</summary>
			// Token: 0x040008D7 RID: 2263
			FLOAT = 5126,
			/// <summary>enum member</summary>
			// Token: 0x040008D8 RID: 2264
			SHORT = 5122,
			/// <summary>enum member</summary>
			// Token: 0x040008D9 RID: 2265
			UNSIGNED_BYTE = 5121,
			/// <summary>enum member</summary>
			// Token: 0x040008DA RID: 2266
			UNSIGNED_INT = 5125,
			/// <summary>enum member</summary>
			// Token: 0x040008DB RID: 2267
			UNSIGNED_SHORT = 5123
		}

		/// <summary>
		/// Define an openGL draw target.
		/// </summary>
		// Token: 0x02000203 RID: 515
		public enum Target
		{
			/// <summary>enum member</summary>
			// Token: 0x040008DD RID: 2269
			ARRAY_BUFFER = 34962,
			/// <summary>enum member</summary>
			// Token: 0x040008DE RID: 2270
			ELEMENT_ARRAY_BUFFER
		}
	}
}
