using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCesium3DTilesWriter
	/// </summary>
	/// <remarks>
	///    Writes a dataset into 3D Tiles format.
	///
	///
	/// Valid inputs include the vtkMultiBlockDataSet (as created by
	/// vtkCityGMLReader) storing 3D buildings, vtkPointSet storing a point
	/// cloud or vtkPolyData for storing a mesh.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCityGMLReader
	/// vtkMultiBlockDataSet
	/// vtkPolyData
	/// </seealso>
	// Token: 0x020001D5 RID: 469
	public class vtkCesium3DTilesWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005A10 RID: 23056 RVA: 0x00082507 File Offset: 0x00080707
		static vtkCesium3DTilesWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCesium3DTilesWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCesium3DTilesWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005A11 RID: 23057 RVA: 0x0008252F File Offset: 0x0008072F
		public vtkCesium3DTilesWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005A12 RID: 23058
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesium3DTilesWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A13 RID: 23059 RVA: 0x00082540 File Offset: 0x00080740
		public new static vtkCesium3DTilesWriter New()
		{
			vtkCesium3DTilesWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCesium3DTilesWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A14 RID: 23060 RVA: 0x00082594 File Offset: 0x00080794
		public vtkCesium3DTilesWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005A15 RID: 23061 RVA: 0x000825D8 File Offset: 0x000807D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005A16 RID: 23062
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_ContentGLTFOff_01(HandleRef pThis);

		/// <summary>
		/// What is the file type used to save tiles. If ContentGLTF is false
		/// (the default) we use B3DM for Buildings or Mesh and PNTS for
		/// PointCloud otherwise  we use GLB or GLTF (3DTILES_content_gltf
		/// extension, use GLB if ContentGLTFSaveGLB is true (default is true)).
		/// If the file type is B3DM, external programs are
		/// needed to convert GLB -&gt; B3DM.
		///
		/// </summary>
		// Token: 0x06005A17 RID: 23063 RVA: 0x000825E3 File Offset: 0x000807E3
		public virtual void ContentGLTFOff()
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_ContentGLTFOff_01(base.GetCppThis());
		}

		// Token: 0x06005A18 RID: 23064
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_ContentGLTFOn_02(HandleRef pThis);

		/// <summary>
		/// What is the file type used to save tiles. If ContentGLTF is false
		/// (the default) we use B3DM for Buildings or Mesh and PNTS for
		/// PointCloud otherwise  we use GLB or GLTF (3DTILES_content_gltf
		/// extension, use GLB if ContentGLTFSaveGLB is true (default is true)).
		/// If the file type is B3DM, external programs are
		/// needed to convert GLB -&gt; B3DM.
		///
		/// </summary>
		// Token: 0x06005A19 RID: 23065 RVA: 0x000825F2 File Offset: 0x000807F2
		public virtual void ContentGLTFOn()
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_ContentGLTFOn_02(base.GetCppThis());
		}

		// Token: 0x06005A1A RID: 23066
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_ContentGLTFSaveGLBOff_03(HandleRef pThis);

		/// <summary>
		/// What is the file type used to save tiles. If ContentGLTF is false
		/// (the default) we use B3DM for Buildings or Mesh and PNTS for
		/// PointCloud otherwise  we use GLB or GLTF (3DTILES_content_gltf
		/// extension, use GLB if ContentGLTFSaveGLB is true (default is true)).
		/// If the file type is B3DM, external programs are
		/// needed to convert GLB -&gt; B3DM.
		///
		/// </summary>
		// Token: 0x06005A1B RID: 23067 RVA: 0x00082601 File Offset: 0x00080801
		public virtual void ContentGLTFSaveGLBOff()
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_ContentGLTFSaveGLBOff_03(base.GetCppThis());
		}

		// Token: 0x06005A1C RID: 23068
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_ContentGLTFSaveGLBOn_04(HandleRef pThis);

		/// <summary>
		/// What is the file type used to save tiles. If ContentGLTF is false
		/// (the default) we use B3DM for Buildings or Mesh and PNTS for
		/// PointCloud otherwise  we use GLB or GLTF (3DTILES_content_gltf
		/// extension, use GLB if ContentGLTFSaveGLB is true (default is true)).
		/// If the file type is B3DM, external programs are
		/// needed to convert GLB -&gt; B3DM.
		///
		/// </summary>
		// Token: 0x06005A1D RID: 23069 RVA: 0x00082610 File Offset: 0x00080810
		public virtual void ContentGLTFSaveGLBOn()
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_ContentGLTFSaveGLBOn_04(base.GetCppThis());
		}

		// Token: 0x06005A1E RID: 23070
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesium3DTilesWriter_GetCRS_05(HandleRef pThis);

		/// <summary>
		/// Set the coordinate reference system (CRS) also known as spatial reference system (SRC),
		/// such as EPSG:2263. This string can also be a proj string such as
		/// "+proj=utm +zone=17 +datum=WGS84"
		/// </summary>
		// Token: 0x06005A1F RID: 23071 RVA: 0x00082620 File Offset: 0x00080820
		public virtual string GetCRS()
		{
			string s = Marshal.PtrToStringAnsi(vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetCRS_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005A20 RID: 23072
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCesium3DTilesWriter_GetContentGLTF_06(HandleRef pThis);

		/// <summary>
		/// What is the file type used to save tiles. If ContentGLTF is false
		/// (the default) we use B3DM for Buildings or Mesh and PNTS for
		/// PointCloud otherwise  we use GLB or GLTF (3DTILES_content_gltf
		/// extension, use GLB if ContentGLTFSaveGLB is true (default is true)).
		/// If the file type is B3DM, external programs are
		/// needed to convert GLB -&gt; B3DM.
		///
		/// </summary>
		// Token: 0x06005A21 RID: 23073 RVA: 0x0008265C File Offset: 0x0008085C
		public virtual bool GetContentGLTF()
		{
			return vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetContentGLTF_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06005A22 RID: 23074
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCesium3DTilesWriter_GetContentGLTFSaveGLB_07(HandleRef pThis);

		/// <summary>
		/// What is the file type used to save tiles. If ContentGLTF is false
		/// (the default) we use B3DM for Buildings or Mesh and PNTS for
		/// PointCloud otherwise  we use GLB or GLTF (3DTILES_content_gltf
		/// extension, use GLB if ContentGLTFSaveGLB is true (default is true)).
		/// If the file type is B3DM, external programs are
		/// needed to convert GLB -&gt; B3DM.
		///
		/// </summary>
		// Token: 0x06005A23 RID: 23075 RVA: 0x00082684 File Offset: 0x00080884
		public virtual bool GetContentGLTFSaveGLB()
		{
			return vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetContentGLTFSaveGLB_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06005A24 RID: 23076
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesium3DTilesWriter_GetDirectoryName_08(HandleRef pThis);

		/// <summary>
		/// Accessor for name of the directory where Cesium3DTiles data is written
		/// </summary>
		// Token: 0x06005A25 RID: 23077 RVA: 0x000826AC File Offset: 0x000808AC
		public virtual string GetDirectoryName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetDirectoryName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005A26 RID: 23078
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCesium3DTilesWriter_GetInputType_09(HandleRef pThis);

		/// <summary>
		/// Input is Buildings, Points or Mesh.
		/// </summary>
		// Token: 0x06005A27 RID: 23079 RVA: 0x000826E8 File Offset: 0x000808E8
		public virtual int GetInputType()
		{
			return vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetInputType_09(base.GetCppThis());
		}

		// Token: 0x06005A28 RID: 23080
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCesium3DTilesWriter_GetMergeTilePolyData_10(HandleRef pThis);

		/// <summary>
		/// Merge all meshes in each tile so we end up with one mesh per tile.
		/// If polydata has textures we merged textures as well such that
		/// the width of the resulting texture is less then MergedTextureWidth (this is
		/// measured in number of input textures). If MergedTextureWidth is not specified
		/// it is computed as sqrt of the number of input textures.
		/// Default is false which means that we expect an external program to merge
		/// the meshes in each tile to improve performance (such as meshoptimizer).
		/// otherwise we merge the polydata in VTK.
		/// @see
		/// https://meshoptimizer.org/
		/// </summary>
		// Token: 0x06005A29 RID: 23081 RVA: 0x00082708 File Offset: 0x00080908
		public virtual bool GetMergeTilePolyData()
		{
			return vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetMergeTilePolyData_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06005A2A RID: 23082
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCesium3DTilesWriter_GetMergedTextureWidth_11(HandleRef pThis);

		/// <summary>
		/// Merge all meshes in each tile so we end up with one mesh per tile.
		/// If polydata has textures we merged textures as well such that
		/// the width of the resulting texture is less then MergedTextureWidth (this is
		/// measured in number of input textures). If MergedTextureWidth is not specified
		/// it is computed as sqrt of the number of input textures.
		/// Default is false which means that we expect an external program to merge
		/// the meshes in each tile to improve performance (such as meshoptimizer).
		/// otherwise we merge the polydata in VTK.
		/// @see
		/// https://meshoptimizer.org/
		/// </summary>
		// Token: 0x06005A2B RID: 23083 RVA: 0x00082730 File Offset: 0x00080930
		public virtual int GetMergedTextureWidth()
		{
			return vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetMergedTextureWidth_11(base.GetCppThis());
		}

		// Token: 0x06005A2C RID: 23084
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCesium3DTilesWriter_GetNumberOfFeaturesPerTile_12(HandleRef pThis);

		/// <summary>
		/// Maximum number of buildings per tile in case of buildings input or
		/// the number of points per tile in case of point cloud input. Default is 100.
		/// </summary>
		// Token: 0x06005A2D RID: 23085 RVA: 0x00082750 File Offset: 0x00080950
		public virtual int GetNumberOfFeaturesPerTile()
		{
			return vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetNumberOfFeaturesPerTile_12(base.GetCppThis());
		}

		// Token: 0x06005A2E RID: 23086
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCesium3DTilesWriter_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A2F RID: 23087 RVA: 0x00082770 File Offset: 0x00080970
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06005A30 RID: 23088
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCesium3DTilesWriter_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A31 RID: 23089 RVA: 0x00082790 File Offset: 0x00080990
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06005A32 RID: 23090
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesium3DTilesWriter_GetOffset_15(HandleRef pThis);

		/// <summary>
		/// Data coordinates are relative to this origin. To get the actual
		/// coordinates data has to be translated with the Offset.
		/// </summary>
		// Token: 0x06005A33 RID: 23091 RVA: 0x000827AC File Offset: 0x000809AC
		public virtual double[] GetOffset()
		{
			IntPtr intPtr = vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetOffset_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005A34 RID: 23092
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_GetOffset_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Data coordinates are relative to this origin. To get the actual
		/// coordinates data has to be translated with the Offset.
		/// </summary>
		// Token: 0x06005A35 RID: 23093 RVA: 0x000827F4 File Offset: 0x000809F4
		public virtual void GetOffset(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetOffset_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06005A36 RID: 23094
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_GetOffset_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Data coordinates are relative to this origin. To get the actual
		/// coordinates data has to be translated with the Offset.
		/// </summary>
		// Token: 0x06005A37 RID: 23095 RVA: 0x00082806 File Offset: 0x00080A06
		public virtual void GetOffset(IntPtr _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetOffset_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06005A38 RID: 23096
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesium3DTilesWriter_GetPropertyTextureFile_18(HandleRef pThis);

		/// <summary>
		/// Optional property texture mapping for the whole dataset.
		/// This is a json file described in &lt;a
		///             href="https://github.com/CesiumGS/3d-tiles/tree/main/specification/Metadata"&gt;3D Metadata&lt;/a&gt; and
		///             &lt;a
		///             href="https://github.com/CesiumGS/glTF/tree/3d-tiles-next/extensions/2.0/Vendor/EXT_structural_metadata"&gt;EXT_structural_metadata&lt;/a&gt;
		/// @see vtkCityGMLReader
		/// </summary>
		// Token: 0x06005A39 RID: 23097 RVA: 0x00082818 File Offset: 0x00080A18
		public virtual string GetPropertyTextureFile()
		{
			string s = Marshal.PtrToStringAnsi(vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetPropertyTextureFile_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005A3A RID: 23098
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCesium3DTilesWriter_GetSaveTextures_19(HandleRef pThis);

		/// <summary>
		/// Save textures as part of the 3D Tiles dataset. Default true.
		/// Otherwise save only the mesh.
		/// </summary>
		// Token: 0x06005A3B RID: 23099 RVA: 0x00082854 File Offset: 0x00080A54
		public virtual bool GetSaveTextures()
		{
			return vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetSaveTextures_19(base.GetCppThis()) != 0;
		}

		// Token: 0x06005A3C RID: 23100
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCesium3DTilesWriter_GetSaveTiles_20(HandleRef pThis);

		/// <summary>
		/// Save the tiles (B3DMs) as part of the 3D Tiles dataset. Default true.
		/// Otherwise save only the tileset (JSON) file. This is mainly used for
		/// debugging. Default true.
		/// </summary>
		// Token: 0x06005A3D RID: 23101 RVA: 0x0008287C File Offset: 0x00080A7C
		public virtual bool GetSaveTiles()
		{
			return vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetSaveTiles_20(base.GetCppThis()) != 0;
		}

		// Token: 0x06005A3E RID: 23102
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesium3DTilesWriter_GetTextureBaseDirectory_21(HandleRef pThis);

		/// <summary>
		/// Path used to prefix all texture paths stored as fields in the input data.
		/// @see vtkCityGMLReader
		/// </summary>
		// Token: 0x06005A3F RID: 23103 RVA: 0x000828A4 File Offset: 0x00080AA4
		public virtual string GetTextureBaseDirectory()
		{
			string s = Marshal.PtrToStringAnsi(vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_GetTextureBaseDirectory_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005A40 RID: 23104
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCesium3DTilesWriter_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A41 RID: 23105 RVA: 0x000828E0 File Offset: 0x00080AE0
		public override int IsA(string type)
		{
			return vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06005A42 RID: 23106
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCesium3DTilesWriter_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A43 RID: 23107 RVA: 0x00082900 File Offset: 0x00080B00
		public new static int IsTypeOf(string type)
		{
			return vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_IsTypeOf_23(type);
		}

		// Token: 0x06005A44 RID: 23108
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_MergeTilePolyDataOff_24(HandleRef pThis);

		/// <summary>
		/// Merge all meshes in each tile so we end up with one mesh per tile.
		/// If polydata has textures we merged textures as well such that
		/// the width of the resulting texture is less then MergedTextureWidth (this is
		/// measured in number of input textures). If MergedTextureWidth is not specified
		/// it is computed as sqrt of the number of input textures.
		/// Default is false which means that we expect an external program to merge
		/// the meshes in each tile to improve performance (such as meshoptimizer).
		/// otherwise we merge the polydata in VTK.
		/// @see
		/// https://meshoptimizer.org/
		/// </summary>
		// Token: 0x06005A45 RID: 23109 RVA: 0x0008291A File Offset: 0x00080B1A
		public virtual void MergeTilePolyDataOff()
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_MergeTilePolyDataOff_24(base.GetCppThis());
		}

		// Token: 0x06005A46 RID: 23110
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_MergeTilePolyDataOn_25(HandleRef pThis);

		/// <summary>
		/// Merge all meshes in each tile so we end up with one mesh per tile.
		/// If polydata has textures we merged textures as well such that
		/// the width of the resulting texture is less then MergedTextureWidth (this is
		/// measured in number of input textures). If MergedTextureWidth is not specified
		/// it is computed as sqrt of the number of input textures.
		/// Default is false which means that we expect an external program to merge
		/// the meshes in each tile to improve performance (such as meshoptimizer).
		/// otherwise we merge the polydata in VTK.
		/// @see
		/// https://meshoptimizer.org/
		/// </summary>
		// Token: 0x06005A47 RID: 23111 RVA: 0x00082929 File Offset: 0x00080B29
		public virtual void MergeTilePolyDataOn()
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_MergeTilePolyDataOn_25(base.GetCppThis());
		}

		// Token: 0x06005A48 RID: 23112
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesium3DTilesWriter_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A49 RID: 23113 RVA: 0x00082938 File Offset: 0x00080B38
		public new vtkCesium3DTilesWriter NewInstance()
		{
			vtkCesium3DTilesWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCesium3DTilesWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005A4A RID: 23114
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesium3DTilesWriter_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A4B RID: 23115 RVA: 0x00082994 File Offset: 0x00080B94
		public new static vtkCesium3DTilesWriter SafeDownCast(vtkObjectBase o)
		{
			vtkCesium3DTilesWriter vtkCesium3DTilesWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCesium3DTilesWriter = (vtkCesium3DTilesWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCesium3DTilesWriter.Register(null);
				}
			}
			return vtkCesium3DTilesWriter;
		}

		// Token: 0x06005A4C RID: 23116
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SaveTexturesOff_29(HandleRef pThis);

		/// <summary>
		/// Save textures as part of the 3D Tiles dataset. Default true.
		/// Otherwise save only the mesh.
		/// </summary>
		// Token: 0x06005A4D RID: 23117 RVA: 0x00082A13 File Offset: 0x00080C13
		public virtual void SaveTexturesOff()
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SaveTexturesOff_29(base.GetCppThis());
		}

		// Token: 0x06005A4E RID: 23118
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SaveTexturesOn_30(HandleRef pThis);

		/// <summary>
		/// Save textures as part of the 3D Tiles dataset. Default true.
		/// Otherwise save only the mesh.
		/// </summary>
		// Token: 0x06005A4F RID: 23119 RVA: 0x00082A22 File Offset: 0x00080C22
		public virtual void SaveTexturesOn()
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SaveTexturesOn_30(base.GetCppThis());
		}

		// Token: 0x06005A50 RID: 23120
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SaveTilesOff_31(HandleRef pThis);

		/// <summary>
		/// Save the tiles (B3DMs) as part of the 3D Tiles dataset. Default true.
		/// Otherwise save only the tileset (JSON) file. This is mainly used for
		/// debugging. Default true.
		/// </summary>
		// Token: 0x06005A51 RID: 23121 RVA: 0x00082A31 File Offset: 0x00080C31
		public virtual void SaveTilesOff()
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SaveTilesOff_31(base.GetCppThis());
		}

		// Token: 0x06005A52 RID: 23122
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SaveTilesOn_32(HandleRef pThis);

		/// <summary>
		/// Save the tiles (B3DMs) as part of the 3D Tiles dataset. Default true.
		/// Otherwise save only the tileset (JSON) file. This is mainly used for
		/// debugging. Default true.
		/// </summary>
		// Token: 0x06005A53 RID: 23123 RVA: 0x00082A40 File Offset: 0x00080C40
		public virtual void SaveTilesOn()
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SaveTilesOn_32(base.GetCppThis());
		}

		// Token: 0x06005A54 RID: 23124
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetCRS_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the coordinate reference system (CRS) also known as spatial reference system (SRC),
		/// such as EPSG:2263. This string can also be a proj string such as
		/// "+proj=utm +zone=17 +datum=WGS84"
		/// </summary>
		// Token: 0x06005A55 RID: 23125 RVA: 0x00082A4F File Offset: 0x00080C4F
		public virtual void SetCRS(string _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetCRS_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06005A56 RID: 23126
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetContentGLTF_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// What is the file type used to save tiles. If ContentGLTF is false
		/// (the default) we use B3DM for Buildings or Mesh and PNTS for
		/// PointCloud otherwise  we use GLB or GLTF (3DTILES_content_gltf
		/// extension, use GLB if ContentGLTFSaveGLB is true (default is true)).
		/// If the file type is B3DM, external programs are
		/// needed to convert GLB -&gt; B3DM.
		///
		/// </summary>
		// Token: 0x06005A57 RID: 23127 RVA: 0x00082A5F File Offset: 0x00080C5F
		public virtual void SetContentGLTF(bool _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetContentGLTF_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005A58 RID: 23128
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetContentGLTFSaveGLB_35(HandleRef pThis, byte _arg);

		/// <summary>
		/// What is the file type used to save tiles. If ContentGLTF is false
		/// (the default) we use B3DM for Buildings or Mesh and PNTS for
		/// PointCloud otherwise  we use GLB or GLTF (3DTILES_content_gltf
		/// extension, use GLB if ContentGLTFSaveGLB is true (default is true)).
		/// If the file type is B3DM, external programs are
		/// needed to convert GLB -&gt; B3DM.
		///
		/// </summary>
		// Token: 0x06005A59 RID: 23129 RVA: 0x00082A77 File Offset: 0x00080C77
		public virtual void SetContentGLTFSaveGLB(bool _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetContentGLTFSaveGLB_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005A5A RID: 23130
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetDirectoryName_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Accessor for name of the directory where Cesium3DTiles data is written
		/// </summary>
		// Token: 0x06005A5B RID: 23131 RVA: 0x00082A8F File Offset: 0x00080C8F
		public virtual void SetDirectoryName(string _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetDirectoryName_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06005A5C RID: 23132
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetInputType_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Input is Buildings, Points or Mesh.
		/// </summary>
		// Token: 0x06005A5D RID: 23133 RVA: 0x00082A9F File Offset: 0x00080C9F
		public virtual void SetInputType(int _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetInputType_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06005A5E RID: 23134
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetMergeTilePolyData_38(HandleRef pThis, byte _arg);

		/// <summary>
		/// Merge all meshes in each tile so we end up with one mesh per tile.
		/// If polydata has textures we merged textures as well such that
		/// the width of the resulting texture is less then MergedTextureWidth (this is
		/// measured in number of input textures). If MergedTextureWidth is not specified
		/// it is computed as sqrt of the number of input textures.
		/// Default is false which means that we expect an external program to merge
		/// the meshes in each tile to improve performance (such as meshoptimizer).
		/// otherwise we merge the polydata in VTK.
		/// @see
		/// https://meshoptimizer.org/
		/// </summary>
		// Token: 0x06005A5F RID: 23135 RVA: 0x00082AAF File Offset: 0x00080CAF
		public virtual void SetMergeTilePolyData(bool _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetMergeTilePolyData_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005A60 RID: 23136
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetMergedTextureWidth_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Merge all meshes in each tile so we end up with one mesh per tile.
		/// If polydata has textures we merged textures as well such that
		/// the width of the resulting texture is less then MergedTextureWidth (this is
		/// measured in number of input textures). If MergedTextureWidth is not specified
		/// it is computed as sqrt of the number of input textures.
		/// Default is false which means that we expect an external program to merge
		/// the meshes in each tile to improve performance (such as meshoptimizer).
		/// otherwise we merge the polydata in VTK.
		/// @see
		/// https://meshoptimizer.org/
		/// </summary>
		// Token: 0x06005A61 RID: 23137 RVA: 0x00082AC7 File Offset: 0x00080CC7
		public virtual void SetMergedTextureWidth(int _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetMergedTextureWidth_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06005A62 RID: 23138
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetNumberOfFeaturesPerTile_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Maximum number of buildings per tile in case of buildings input or
		/// the number of points per tile in case of point cloud input. Default is 100.
		/// </summary>
		// Token: 0x06005A63 RID: 23139 RVA: 0x00082AD7 File Offset: 0x00080CD7
		public virtual void SetNumberOfFeaturesPerTile(int _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetNumberOfFeaturesPerTile_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06005A64 RID: 23140
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetOffset_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Data coordinates are relative to this origin. To get the actual
		/// coordinates data has to be translated with the Offset.
		/// </summary>
		// Token: 0x06005A65 RID: 23141 RVA: 0x00082AE7 File Offset: 0x00080CE7
		public virtual void SetOffset(double _arg1, double _arg2, double _arg3)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetOffset_41(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06005A66 RID: 23142
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetOffset_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Data coordinates are relative to this origin. To get the actual
		/// coordinates data has to be translated with the Offset.
		/// </summary>
		// Token: 0x06005A67 RID: 23143 RVA: 0x00082AF9 File Offset: 0x00080CF9
		public virtual void SetOffset(IntPtr _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetOffset_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06005A68 RID: 23144
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetPropertyTextureFile_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Optional property texture mapping for the whole dataset.
		/// This is a json file described in &lt;a
		///             href="https://github.com/CesiumGS/3d-tiles/tree/main/specification/Metadata"&gt;3D Metadata&lt;/a&gt; and
		///             &lt;a
		///             href="https://github.com/CesiumGS/glTF/tree/3d-tiles-next/extensions/2.0/Vendor/EXT_structural_metadata"&gt;EXT_structural_metadata&lt;/a&gt;
		/// @see vtkCityGMLReader
		/// </summary>
		// Token: 0x06005A69 RID: 23145 RVA: 0x00082B09 File Offset: 0x00080D09
		public virtual void SetPropertyTextureFile(string _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetPropertyTextureFile_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06005A6A RID: 23146
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetSaveTextures_44(HandleRef pThis, byte _arg);

		/// <summary>
		/// Save textures as part of the 3D Tiles dataset. Default true.
		/// Otherwise save only the mesh.
		/// </summary>
		// Token: 0x06005A6B RID: 23147 RVA: 0x00082B19 File Offset: 0x00080D19
		public virtual void SetSaveTextures(bool _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetSaveTextures_44(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005A6C RID: 23148
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetSaveTiles_45(HandleRef pThis, byte _arg);

		/// <summary>
		/// Save the tiles (B3DMs) as part of the 3D Tiles dataset. Default true.
		/// Otherwise save only the tileset (JSON) file. This is mainly used for
		/// debugging. Default true.
		/// </summary>
		// Token: 0x06005A6D RID: 23149 RVA: 0x00082B31 File Offset: 0x00080D31
		public virtual void SetSaveTiles(bool _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetSaveTiles_45(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005A6E RID: 23150
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesium3DTilesWriter_SetTextureBaseDirectory_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Path used to prefix all texture paths stored as fields in the input data.
		/// @see vtkCityGMLReader
		/// </summary>
		// Token: 0x06005A6F RID: 23151 RVA: 0x00082B49 File Offset: 0x00080D49
		public virtual void SetTextureBaseDirectory(string _arg)
		{
			vtkCesium3DTilesWriter.vtkCesium3DTilesWriter_SetTextureBaseDirectory_46(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000871 RID: 2161
		public new const string MRFullTypeName = "Kitware.VTK.vtkCesium3DTilesWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000872 RID: 2162
		public new static readonly string MRClassNameKey = "class vtkCesium3DTilesWriter";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020001D6 RID: 470
		public enum InputType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000874 RID: 2164
			Buildings,
			/// <summary>enum member</summary>
			// Token: 0x04000875 RID: 2165
			Mesh = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000876 RID: 2166
			Points = 1
		}
	}
}
