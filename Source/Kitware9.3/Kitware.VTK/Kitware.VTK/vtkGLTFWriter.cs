using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGLTFWriter
	/// </summary>
	/// <remarks>
	///    export a scene into GLTF 2.0 format.
	///
	/// vtkGLTFWriter is a concrete subclass of vtkWriter that writes GLTF
	/// 2.0 files. Its input is a multiblock dataset as it is produced by
	/// the CityGML reader. The dataset contains a list of buildings, a mesh
	/// or a point cloud.
	///
	/// For buildings, each building is made of pieces (polydata), each
	/// piece could potentially have several textures. The mesh input
	/// is the same as one building. The point cloud input, is the same as
	/// mesh input but with Verts cells instead of Polys.
	///
	/// Materials, including textures, are described as fields in the
	/// polydata. If InlineData is false, we only refer to textures files
	/// referred in the data, otherwise we read the textures and save them
	/// encoded in the file.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCityGMLReader
	/// vtkPolyData
	/// </seealso>
	// Token: 0x02000205 RID: 517
	public class vtkGLTFWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060062E4 RID: 25316 RVA: 0x0008E643 File Offset: 0x0008C843
		static vtkGLTFWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLTFWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLTFWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060062E5 RID: 25317 RVA: 0x0008E66B File Offset: 0x0008C86B
		public vtkGLTFWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060062E6 RID: 25318
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060062E7 RID: 25319 RVA: 0x0008E67C File Offset: 0x0008C87C
		public new static vtkGLTFWriter New()
		{
			vtkGLTFWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFWriter.vtkGLTFWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLTFWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060062E8 RID: 25320 RVA: 0x0008E6D0 File Offset: 0x0008C8D0
		public vtkGLTFWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGLTFWriter.vtkGLTFWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060062E9 RID: 25321 RVA: 0x0008E714 File Offset: 0x0008C914
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060062EA RID: 25322
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_CopyTexturesOff_01(HandleRef pThis);

		/// <summary>
		/// If true we copy the textures the the same directory where FileName is saved.
		/// Default is false.
		/// @sa TextureBaseDirectory
		/// </summary>
		// Token: 0x060062EB RID: 25323 RVA: 0x0008E71F File Offset: 0x0008C91F
		public virtual void CopyTexturesOff()
		{
			vtkGLTFWriter.vtkGLTFWriter_CopyTexturesOff_01(base.GetCppThis());
		}

		// Token: 0x060062EC RID: 25324
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_CopyTexturesOn_02(HandleRef pThis);

		/// <summary>
		/// If true we copy the textures the the same directory where FileName is saved.
		/// Default is false.
		/// @sa TextureBaseDirectory
		/// </summary>
		// Token: 0x060062ED RID: 25325 RVA: 0x0008E72E File Offset: 0x0008C92E
		public virtual void CopyTexturesOn()
		{
			vtkGLTFWriter.vtkGLTFWriter_CopyTexturesOn_02(base.GetCppThis());
		}

		// Token: 0x060062EE RID: 25326
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFWriter_GetBinary_03(HandleRef pThis);

		/// <summary>
		/// If true, save as GLB (Binary GLTF).
		/// This is set by using .glb extension for FileName
		/// and unset for any other extension (usually .gltf)
		/// </summary>
		// Token: 0x060062EF RID: 25327 RVA: 0x0008E740 File Offset: 0x0008C940
		public virtual bool GetBinary()
		{
			return vtkGLTFWriter.vtkGLTFWriter_GetBinary_03(base.GetCppThis()) != 0;
		}

		// Token: 0x060062F0 RID: 25328
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFWriter_GetCopyTextures_04(HandleRef pThis);

		/// <summary>
		/// If true we copy the textures the the same directory where FileName is saved.
		/// Default is false.
		/// @sa TextureBaseDirectory
		/// </summary>
		// Token: 0x060062F1 RID: 25329 RVA: 0x0008E768 File Offset: 0x0008C968
		public virtual bool GetCopyTextures()
		{
			return vtkGLTFWriter.vtkGLTFWriter_GetCopyTextures_04(base.GetCppThis()) != 0;
		}

		// Token: 0x060062F2 RID: 25330
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFWriter_GetFileName_05(HandleRef pThis);

		/// <summary>
		/// Specify the name of the GLTF file to write.
		/// </summary>
		// Token: 0x060062F3 RID: 25331 RVA: 0x0008E790 File Offset: 0x0008C990
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGLTFWriter.vtkGLTFWriter_GetFileName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060062F4 RID: 25332
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFWriter_GetInlineData_06(HandleRef pThis);

		/// <summary>
		/// Should the binary data be included in the json file as a base64
		/// string.
		/// </summary>
		// Token: 0x060062F5 RID: 25333 RVA: 0x0008E7CC File Offset: 0x0008C9CC
		public virtual bool GetInlineData()
		{
			return vtkGLTFWriter.vtkGLTFWriter_GetInlineData_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060062F6 RID: 25334
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFWriter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060062F7 RID: 25335 RVA: 0x0008E7F4 File Offset: 0x0008C9F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGLTFWriter.vtkGLTFWriter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060062F8 RID: 25336
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLTFWriter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060062F9 RID: 25337 RVA: 0x0008E814 File Offset: 0x0008CA14
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGLTFWriter.vtkGLTFWriter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060062FA RID: 25338
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFWriter_GetPropertyTextureFile_09(HandleRef pThis);

		/// <summary>
		/// Specify the property texture file.
		/// This is a json file described by
		///             https://github.com/CesiumGS/3d-tiles/tree/main/specification/Metadata
		///             and
		///             https://github.com/CesiumGS/glTF/tree/3d-tiles-next/extensions/2.0/Vendor/EXT_structural_metadata
		/// </summary>
		// Token: 0x060062FB RID: 25339 RVA: 0x0008E830 File Offset: 0x0008CA30
		public virtual string GetPropertyTextureFile()
		{
			string s = Marshal.PtrToStringAnsi(vtkGLTFWriter.vtkGLTFWriter_GetPropertyTextureFile_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060062FC RID: 25340
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFWriter_GetRelativeCoordinates_10(HandleRef pThis);

		/// <summary>
		/// Save mesh point coordinates relative to the bounding box origin
		/// and add the corresponding translation to the root node.  This is
		/// especially important for 3D Tiles as points are stored as
		/// cartesian coordinates relative to the earth center so they are
		/// stored as doubles. As GLTF can only store floats not setting this
		/// variable on results in a loss of precision of about a meter.
		/// Note that the translation information is stored in json which can
		/// store doubles.
		/// </summary>
		// Token: 0x060062FD RID: 25341 RVA: 0x0008E86C File Offset: 0x0008CA6C
		public virtual bool GetRelativeCoordinates()
		{
			return vtkGLTFWriter.vtkGLTFWriter_GetRelativeCoordinates_10(base.GetCppThis()) != 0;
		}

		// Token: 0x060062FE RID: 25342
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFWriter_GetSaveActivePointColor_11(HandleRef pThis);

		/// <summary>
		/// If true, the writer looks at the active scalar and if it finds a
		/// 3 or 4 component, float, unsigned char or unsigned short it
		/// stores a RGB or RGBA attribute called COLOR_0 in the GLTF
		/// file. The default is false.  Note a float component has to be
		/// bewtween [0, 1] while the unsigned chars and unsigned short are
		/// OpenGL normalized integers (are either between [0, 255] for
		/// unsigned char, they are between [0, 65536] for unsigned short - they
		/// are used to quantize a float between [0, 1]).
		/// </summary>
		// Token: 0x060062FF RID: 25343 RVA: 0x0008E894 File Offset: 0x0008CA94
		public virtual bool GetSaveActivePointColor()
		{
			return vtkGLTFWriter.vtkGLTFWriter_GetSaveActivePointColor_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06006300 RID: 25344
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFWriter_GetSaveBatchId_12(HandleRef pThis);

		/// <summary>
		/// It looks for point arrays called
		/// _BATCHID in the data and it saves it in the
		/// GLTF file if found.
		/// _BATCHID is an index used in 3D Tiles b3dm format. This format stores
		/// a binary gltf with a mesh that has several objects (buildings).
		/// Objects are indexed from 0 to number of objects - 1, all points
		/// of an objects have the same index. These index values are stored
		/// in _BATCHID
		/// </summary>
		// Token: 0x06006301 RID: 25345 RVA: 0x0008E8BC File Offset: 0x0008CABC
		public virtual bool GetSaveBatchId()
		{
			return vtkGLTFWriter.vtkGLTFWriter_GetSaveBatchId_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06006302 RID: 25346
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFWriter_GetSaveNormal_13(HandleRef pThis);

		/// <summary>
		/// It looks for the normals point attribute and saves it in the
		/// GLTF file if found with the name NORMAL
		/// Cesium needs this to render buildings correctly
		/// if there is no texture.
		/// </summary>
		// Token: 0x06006303 RID: 25347 RVA: 0x0008E8E4 File Offset: 0x0008CAE4
		public virtual bool GetSaveNormal()
		{
			return vtkGLTFWriter.vtkGLTFWriter_GetSaveNormal_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06006304 RID: 25348
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLTFWriter_GetSaveTextures_14(HandleRef pThis);

		/// <summary>
		/// If true (default) we save textures. We only include a reference
		/// to the texture file unless CopyTextures is true or you want to
		/// include the binary data in the json file using InlineData in
		/// which case we have to load the texture in memory and save it
		/// encoded in the json file.
		/// @sa TextureBaseDirectory
		/// </summary>
		// Token: 0x06006305 RID: 25349 RVA: 0x0008E90C File Offset: 0x0008CB0C
		public virtual bool GetSaveTextures()
		{
			return vtkGLTFWriter.vtkGLTFWriter_GetSaveTextures_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06006306 RID: 25350
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFWriter_GetTextureBaseDirectory_15(HandleRef pThis);

		/// <summary>
		/// Specify the base directory for texture files.
		/// </summary>
		// Token: 0x06006307 RID: 25351 RVA: 0x0008E934 File Offset: 0x0008CB34
		public virtual string GetTextureBaseDirectory()
		{
			string s = Marshal.PtrToStringAnsi(vtkGLTFWriter.vtkGLTFWriter_GetTextureBaseDirectory_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006308 RID: 25352
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_InlineDataOff_16(HandleRef pThis);

		/// <summary>
		/// Should the binary data be included in the json file as a base64
		/// string.
		/// </summary>
		// Token: 0x06006309 RID: 25353 RVA: 0x0008E96E File Offset: 0x0008CB6E
		public virtual void InlineDataOff()
		{
			vtkGLTFWriter.vtkGLTFWriter_InlineDataOff_16(base.GetCppThis());
		}

		// Token: 0x0600630A RID: 25354
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_InlineDataOn_17(HandleRef pThis);

		/// <summary>
		/// Should the binary data be included in the json file as a base64
		/// string.
		/// </summary>
		// Token: 0x0600630B RID: 25355 RVA: 0x0008E97D File Offset: 0x0008CB7D
		public virtual void InlineDataOn()
		{
			vtkGLTFWriter.vtkGLTFWriter_InlineDataOn_17(base.GetCppThis());
		}

		// Token: 0x0600630C RID: 25356
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLTFWriter_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600630D RID: 25357 RVA: 0x0008E98C File Offset: 0x0008CB8C
		public override int IsA(string type)
		{
			return vtkGLTFWriter.vtkGLTFWriter_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600630E RID: 25358
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLTFWriter_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600630F RID: 25359 RVA: 0x0008E9AC File Offset: 0x0008CBAC
		public new static int IsTypeOf(string type)
		{
			return vtkGLTFWriter.vtkGLTFWriter_IsTypeOf_19(type);
		}

		// Token: 0x06006310 RID: 25360
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFWriter_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006311 RID: 25361 RVA: 0x0008E9C8 File Offset: 0x0008CBC8
		public new vtkGLTFWriter NewInstance()
		{
			vtkGLTFWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFWriter.vtkGLTFWriter_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLTFWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006312 RID: 25362
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_RelativeCoordinatesOff_22(HandleRef pThis);

		/// <summary>
		/// Save mesh point coordinates relative to the bounding box origin
		/// and add the corresponding translation to the root node.  This is
		/// especially important for 3D Tiles as points are stored as
		/// cartesian coordinates relative to the earth center so they are
		/// stored as doubles. As GLTF can only store floats not setting this
		/// variable on results in a loss of precision of about a meter.
		/// Note that the translation information is stored in json which can
		/// store doubles.
		/// </summary>
		// Token: 0x06006313 RID: 25363 RVA: 0x0008EA22 File Offset: 0x0008CC22
		public virtual void RelativeCoordinatesOff()
		{
			vtkGLTFWriter.vtkGLTFWriter_RelativeCoordinatesOff_22(base.GetCppThis());
		}

		// Token: 0x06006314 RID: 25364
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_RelativeCoordinatesOn_23(HandleRef pThis);

		/// <summary>
		/// Save mesh point coordinates relative to the bounding box origin
		/// and add the corresponding translation to the root node.  This is
		/// especially important for 3D Tiles as points are stored as
		/// cartesian coordinates relative to the earth center so they are
		/// stored as doubles. As GLTF can only store floats not setting this
		/// variable on results in a loss of precision of about a meter.
		/// Note that the translation information is stored in json which can
		/// store doubles.
		/// </summary>
		// Token: 0x06006315 RID: 25365 RVA: 0x0008EA31 File Offset: 0x0008CC31
		public virtual void RelativeCoordinatesOn()
		{
			vtkGLTFWriter.vtkGLTFWriter_RelativeCoordinatesOn_23(base.GetCppThis());
		}

		// Token: 0x06006316 RID: 25366
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLTFWriter_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006317 RID: 25367 RVA: 0x0008EA40 File Offset: 0x0008CC40
		public new static vtkGLTFWriter SafeDownCast(vtkObjectBase o)
		{
			vtkGLTFWriter vtkGLTFWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLTFWriter.vtkGLTFWriter_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLTFWriter = (vtkGLTFWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLTFWriter.Register(null);
				}
			}
			return vtkGLTFWriter;
		}

		// Token: 0x06006318 RID: 25368
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SaveActivePointColorOff_25(HandleRef pThis);

		/// <summary>
		/// If true, the writer looks at the active scalar and if it finds a
		/// 3 or 4 component, float, unsigned char or unsigned short it
		/// stores a RGB or RGBA attribute called COLOR_0 in the GLTF
		/// file. The default is false.  Note a float component has to be
		/// bewtween [0, 1] while the unsigned chars and unsigned short are
		/// OpenGL normalized integers (are either between [0, 255] for
		/// unsigned char, they are between [0, 65536] for unsigned short - they
		/// are used to quantize a float between [0, 1]).
		/// </summary>
		// Token: 0x06006319 RID: 25369 RVA: 0x0008EABF File Offset: 0x0008CCBF
		public virtual void SaveActivePointColorOff()
		{
			vtkGLTFWriter.vtkGLTFWriter_SaveActivePointColorOff_25(base.GetCppThis());
		}

		// Token: 0x0600631A RID: 25370
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SaveActivePointColorOn_26(HandleRef pThis);

		/// <summary>
		/// If true, the writer looks at the active scalar and if it finds a
		/// 3 or 4 component, float, unsigned char or unsigned short it
		/// stores a RGB or RGBA attribute called COLOR_0 in the GLTF
		/// file. The default is false.  Note a float component has to be
		/// bewtween [0, 1] while the unsigned chars and unsigned short are
		/// OpenGL normalized integers (are either between [0, 255] for
		/// unsigned char, they are between [0, 65536] for unsigned short - they
		/// are used to quantize a float between [0, 1]).
		/// </summary>
		// Token: 0x0600631B RID: 25371 RVA: 0x0008EACE File Offset: 0x0008CCCE
		public virtual void SaveActivePointColorOn()
		{
			vtkGLTFWriter.vtkGLTFWriter_SaveActivePointColorOn_26(base.GetCppThis());
		}

		// Token: 0x0600631C RID: 25372
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SaveBatchIdOff_27(HandleRef pThis);

		/// <summary>
		/// It looks for point arrays called
		/// _BATCHID in the data and it saves it in the
		/// GLTF file if found.
		/// _BATCHID is an index used in 3D Tiles b3dm format. This format stores
		/// a binary gltf with a mesh that has several objects (buildings).
		/// Objects are indexed from 0 to number of objects - 1, all points
		/// of an objects have the same index. These index values are stored
		/// in _BATCHID
		/// </summary>
		// Token: 0x0600631D RID: 25373 RVA: 0x0008EADD File Offset: 0x0008CCDD
		public virtual void SaveBatchIdOff()
		{
			vtkGLTFWriter.vtkGLTFWriter_SaveBatchIdOff_27(base.GetCppThis());
		}

		// Token: 0x0600631E RID: 25374
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SaveBatchIdOn_28(HandleRef pThis);

		/// <summary>
		/// It looks for point arrays called
		/// _BATCHID in the data and it saves it in the
		/// GLTF file if found.
		/// _BATCHID is an index used in 3D Tiles b3dm format. This format stores
		/// a binary gltf with a mesh that has several objects (buildings).
		/// Objects are indexed from 0 to number of objects - 1, all points
		/// of an objects have the same index. These index values are stored
		/// in _BATCHID
		/// </summary>
		// Token: 0x0600631F RID: 25375 RVA: 0x0008EAEC File Offset: 0x0008CCEC
		public virtual void SaveBatchIdOn()
		{
			vtkGLTFWriter.vtkGLTFWriter_SaveBatchIdOn_28(base.GetCppThis());
		}

		// Token: 0x06006320 RID: 25376
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SaveNormalOff_29(HandleRef pThis);

		/// <summary>
		/// It looks for the normals point attribute and saves it in the
		/// GLTF file if found with the name NORMAL
		/// Cesium needs this to render buildings correctly
		/// if there is no texture.
		/// </summary>
		// Token: 0x06006321 RID: 25377 RVA: 0x0008EAFB File Offset: 0x0008CCFB
		public virtual void SaveNormalOff()
		{
			vtkGLTFWriter.vtkGLTFWriter_SaveNormalOff_29(base.GetCppThis());
		}

		// Token: 0x06006322 RID: 25378
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SaveNormalOn_30(HandleRef pThis);

		/// <summary>
		/// It looks for the normals point attribute and saves it in the
		/// GLTF file if found with the name NORMAL
		/// Cesium needs this to render buildings correctly
		/// if there is no texture.
		/// </summary>
		// Token: 0x06006323 RID: 25379 RVA: 0x0008EB0A File Offset: 0x0008CD0A
		public virtual void SaveNormalOn()
		{
			vtkGLTFWriter.vtkGLTFWriter_SaveNormalOn_30(base.GetCppThis());
		}

		// Token: 0x06006324 RID: 25380
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SaveTexturesOff_31(HandleRef pThis);

		/// <summary>
		/// If true (default) we save textures. We only include a reference
		/// to the texture file unless CopyTextures is true or you want to
		/// include the binary data in the json file using InlineData in
		/// which case we have to load the texture in memory and save it
		/// encoded in the json file.
		/// @sa TextureBaseDirectory
		/// </summary>
		// Token: 0x06006325 RID: 25381 RVA: 0x0008EB19 File Offset: 0x0008CD19
		public virtual void SaveTexturesOff()
		{
			vtkGLTFWriter.vtkGLTFWriter_SaveTexturesOff_31(base.GetCppThis());
		}

		// Token: 0x06006326 RID: 25382
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SaveTexturesOn_32(HandleRef pThis);

		/// <summary>
		/// If true (default) we save textures. We only include a reference
		/// to the texture file unless CopyTextures is true or you want to
		/// include the binary data in the json file using InlineData in
		/// which case we have to load the texture in memory and save it
		/// encoded in the json file.
		/// @sa TextureBaseDirectory
		/// </summary>
		// Token: 0x06006327 RID: 25383 RVA: 0x0008EB28 File Offset: 0x0008CD28
		public virtual void SaveTexturesOn()
		{
			vtkGLTFWriter.vtkGLTFWriter_SaveTexturesOn_32(base.GetCppThis());
		}

		// Token: 0x06006328 RID: 25384
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SetCopyTextures_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true we copy the textures the the same directory where FileName is saved.
		/// Default is false.
		/// @sa TextureBaseDirectory
		/// </summary>
		// Token: 0x06006329 RID: 25385 RVA: 0x0008EB37 File Offset: 0x0008CD37
		public virtual void SetCopyTextures(bool _arg)
		{
			vtkGLTFWriter.vtkGLTFWriter_SetCopyTextures_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600632A RID: 25386
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SetFileName_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the GLTF file to write.
		/// </summary>
		// Token: 0x0600632B RID: 25387 RVA: 0x0008EB4F File Offset: 0x0008CD4F
		public virtual void SetFileName(string _arg)
		{
			vtkGLTFWriter.vtkGLTFWriter_SetFileName_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600632C RID: 25388
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SetInlineData_35(HandleRef pThis, byte _arg);

		/// <summary>
		/// Should the binary data be included in the json file as a base64
		/// string.
		/// </summary>
		// Token: 0x0600632D RID: 25389 RVA: 0x0008EB5F File Offset: 0x0008CD5F
		public virtual void SetInlineData(bool _arg)
		{
			vtkGLTFWriter.vtkGLTFWriter_SetInlineData_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600632E RID: 25390
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SetPropertyTextureFile_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the property texture file.
		/// This is a json file described by
		///             https://github.com/CesiumGS/3d-tiles/tree/main/specification/Metadata
		///             and
		///             https://github.com/CesiumGS/glTF/tree/3d-tiles-next/extensions/2.0/Vendor/EXT_structural_metadata
		/// </summary>
		// Token: 0x0600632F RID: 25391 RVA: 0x0008EB77 File Offset: 0x0008CD77
		public virtual void SetPropertyTextureFile(string _arg)
		{
			vtkGLTFWriter.vtkGLTFWriter_SetPropertyTextureFile_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06006330 RID: 25392
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SetRelativeCoordinates_37(HandleRef pThis, byte _arg);

		/// <summary>
		/// Save mesh point coordinates relative to the bounding box origin
		/// and add the corresponding translation to the root node.  This is
		/// especially important for 3D Tiles as points are stored as
		/// cartesian coordinates relative to the earth center so they are
		/// stored as doubles. As GLTF can only store floats not setting this
		/// variable on results in a loss of precision of about a meter.
		/// Note that the translation information is stored in json which can
		/// store doubles.
		/// </summary>
		// Token: 0x06006331 RID: 25393 RVA: 0x0008EB87 File Offset: 0x0008CD87
		public virtual void SetRelativeCoordinates(bool _arg)
		{
			vtkGLTFWriter.vtkGLTFWriter_SetRelativeCoordinates_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06006332 RID: 25394
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SetSaveActivePointColor_38(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, the writer looks at the active scalar and if it finds a
		/// 3 or 4 component, float, unsigned char or unsigned short it
		/// stores a RGB or RGBA attribute called COLOR_0 in the GLTF
		/// file. The default is false.  Note a float component has to be
		/// bewtween [0, 1] while the unsigned chars and unsigned short are
		/// OpenGL normalized integers (are either between [0, 255] for
		/// unsigned char, they are between [0, 65536] for unsigned short - they
		/// are used to quantize a float between [0, 1]).
		/// </summary>
		// Token: 0x06006333 RID: 25395 RVA: 0x0008EB9F File Offset: 0x0008CD9F
		public virtual void SetSaveActivePointColor(bool _arg)
		{
			vtkGLTFWriter.vtkGLTFWriter_SetSaveActivePointColor_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06006334 RID: 25396
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SetSaveBatchId_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// It looks for point arrays called
		/// _BATCHID in the data and it saves it in the
		/// GLTF file if found.
		/// _BATCHID is an index used in 3D Tiles b3dm format. This format stores
		/// a binary gltf with a mesh that has several objects (buildings).
		/// Objects are indexed from 0 to number of objects - 1, all points
		/// of an objects have the same index. These index values are stored
		/// in _BATCHID
		/// </summary>
		// Token: 0x06006335 RID: 25397 RVA: 0x0008EBB7 File Offset: 0x0008CDB7
		public virtual void SetSaveBatchId(bool _arg)
		{
			vtkGLTFWriter.vtkGLTFWriter_SetSaveBatchId_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06006336 RID: 25398
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SetSaveNormal_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// It looks for the normals point attribute and saves it in the
		/// GLTF file if found with the name NORMAL
		/// Cesium needs this to render buildings correctly
		/// if there is no texture.
		/// </summary>
		// Token: 0x06006337 RID: 25399 RVA: 0x0008EBCF File Offset: 0x0008CDCF
		public virtual void SetSaveNormal(bool _arg)
		{
			vtkGLTFWriter.vtkGLTFWriter_SetSaveNormal_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06006338 RID: 25400
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SetSaveTextures_41(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true (default) we save textures. We only include a reference
		/// to the texture file unless CopyTextures is true or you want to
		/// include the binary data in the json file using InlineData in
		/// which case we have to load the texture in memory and save it
		/// encoded in the json file.
		/// @sa TextureBaseDirectory
		/// </summary>
		// Token: 0x06006339 RID: 25401 RVA: 0x0008EBE7 File Offset: 0x0008CDE7
		public virtual void SetSaveTextures(bool _arg)
		{
			vtkGLTFWriter.vtkGLTFWriter_SetSaveTextures_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600633A RID: 25402
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLTFWriter_SetTextureBaseDirectory_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the base directory for texture files.
		/// </summary>
		// Token: 0x0600633B RID: 25403 RVA: 0x0008EBFF File Offset: 0x0008CDFF
		public virtual void SetTextureBaseDirectory(string _arg)
		{
			vtkGLTFWriter.vtkGLTFWriter_SetTextureBaseDirectory_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600633C RID: 25404
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkGLTFWriter_WriteToString_43(HandleRef pThis);

		/// <summary>
		/// Write the result to a string instead of a file
		/// </summary>
		// Token: 0x0600633D RID: 25405 RVA: 0x0008EC10 File Offset: 0x0008CE10
		public string WriteToString()
		{
			return vtkGLTFWriter.vtkGLTFWriter_WriteToString_43(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008E1 RID: 2273
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLTFWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008E2 RID: 2274
		public new static readonly string MRClassNameKey = "class vtkGLTFWriter";
	}
}
