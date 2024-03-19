using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLPolyDataMapper
	/// </summary>
	/// <remarks>
	///    PolyDataMapper using OpenGL to render.
	///
	/// PolyDataMapper that uses a OpenGL to do the actual rendering.
	/// </remarks>
	// Token: 0x02000100 RID: 256
	public class vtkOpenGLPolyDataMapper : vtkPolyDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060034DC RID: 13532 RVA: 0x0004D490 File Offset: 0x0004B690
		static vtkOpenGLPolyDataMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLPolyDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLPolyDataMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060034DD RID: 13533 RVA: 0x0004D4B8 File Offset: 0x0004B6B8
		public vtkOpenGLPolyDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060034DE RID: 13534
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPolyDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060034DF RID: 13535 RVA: 0x0004D4C8 File Offset: 0x0004B6C8
		public new static vtkOpenGLPolyDataMapper New()
		{
			vtkOpenGLPolyDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060034E0 RID: 13536 RVA: 0x0004D51C File Offset: 0x0004B71C
		public vtkOpenGLPolyDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060034E1 RID: 13537 RVA: 0x0004D560 File Offset: 0x0004B760
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060034E2 RID: 13538
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkOpenGLPolyDataMapper_GenerateHash_01(HandleRef pThis, HandleRef polydata);

		/// <summary>
		/// Unique hash based on availability of scalars, normals, tcoords, lookup tables
		/// and related attributes that distinguish the rendering requirements of different
		/// polydata.
		/// </summary>
		// Token: 0x060034E3 RID: 13539 RVA: 0x0004D56C File Offset: 0x0004B76C
		public override ulong GenerateHash(vtkPolyData polydata)
		{
			return vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_GenerateHash_01(base.GetCppThis(), (polydata == null) ? default(HandleRef) : polydata.GetCppThis());
		}

		// Token: 0x060034E4 RID: 13540
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPolyDataMapper_GetCellIdArrayName_02(HandleRef pThis);

		/// <summary>
		/// By default, this class uses the dataset's point and cell ids during
		/// rendering. However, one can override those by specifying cell and point
		/// data arrays to use instead. Currently, only vtkIdType array is supported.
		/// Set to NULL string (default) to use the point ids instead.
		/// </summary>
		// Token: 0x060034E5 RID: 13541 RVA: 0x0004D5A0 File Offset: 0x0004B7A0
		public virtual string GetCellIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_GetCellIdArrayName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060034E6 RID: 13542
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPolyDataMapper_GetCompositeIdArrayName_03(HandleRef pThis);

		/// <summary>
		/// Generally, this class can render the composite id when iterating
		/// over composite datasets. However in some cases (as in AMR), the rendered
		/// structure may not correspond to the input data, in which case we need
		/// to provide a cell array that can be used to render in the composite id in
		/// selection passes. Set to NULL (default) to not override the composite id
		/// color set by vtkCompositePainter if any.
		/// The array *MUST* be a cell array and of type vtkUnsignedIntArray.
		/// </summary>
		// Token: 0x060034E7 RID: 13543 RVA: 0x0004D5DC File Offset: 0x0004B7DC
		public virtual string GetCompositeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_GetCompositeIdArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060034E8 RID: 13544
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLPolyDataMapper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060034E9 RID: 13545 RVA: 0x0004D618 File Offset: 0x0004B818
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060034EA RID: 13546
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLPolyDataMapper_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060034EB RID: 13547 RVA: 0x0004D638 File Offset: 0x0004B838
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060034EC RID: 13548
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPolyDataMapper_GetPointIdArrayName_06(HandleRef pThis);

		/// <summary>
		/// By default, this class uses the dataset's point and cell ids during
		/// rendering. However, one can override those by specifying cell and point
		/// data arrays to use instead. Currently, only vtkIdType array is supported.
		/// Set to NULL string (default) to use the point ids instead.
		/// </summary>
		// Token: 0x060034ED RID: 13549 RVA: 0x0004D654 File Offset: 0x0004B854
		public virtual string GetPointIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_GetPointIdArrayName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060034EE RID: 13550
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLPolyDataMapper_GetPopulateSelectionSettings_07(HandleRef pThis);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x060034EF RID: 13551 RVA: 0x0004D690 File Offset: 0x0004B890
		public virtual int GetPopulateSelectionSettings()
		{
			return vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_GetPopulateSelectionSettings_07(base.GetCppThis());
		}

		// Token: 0x060034F0 RID: 13552
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPolyDataMapper_GetProcessIdArrayName_08(HandleRef pThis);

		/// <summary>
		/// If this class should override the process id using a data-array,
		/// set this variable to the name of the array to use. It must be a
		/// point-array.
		/// </summary>
		// Token: 0x060034F1 RID: 13553 RVA: 0x0004D6B0 File Offset: 0x0004B8B0
		public virtual string GetProcessIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_GetProcessIdArrayName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060034F2 RID: 13554
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLPolyDataMapper_GetSupportsSelection_09(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Used by vtkHardwareSelector to determine if the prop supports hardware
		/// selection.
		/// </summary>
		// Token: 0x060034F3 RID: 13555 RVA: 0x0004D6EC File Offset: 0x0004B8EC
		public override bool GetSupportsSelection()
		{
			return vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_GetSupportsSelection_09(base.GetCppThis()) != 0;
		}

		// Token: 0x060034F4 RID: 13556
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLPolyDataMapper_GetUseProgramPointSize_10(HandleRef pThis);

		/// <summary>
		/// Allow the shader code to set the point size (with gl_PointSize variable)
		/// instead of using the one defined by the property. Note that this flag is
		/// not available on OpenGLES as the feature is enabled by default. With
		/// OpenGL, the feature is turned off by default.
		/// Warning: on MacOS, enabling the feature result in non point drawing
		/// if the shaders do not set the point size.
		/// </summary>
		// Token: 0x060034F5 RID: 13557 RVA: 0x0004D714 File Offset: 0x0004B914
		public virtual bool GetUseProgramPointSize()
		{
			return vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_GetUseProgramPointSize_10(base.GetCppThis()) != 0;
		}

		// Token: 0x060034F6 RID: 13558
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPolyDataMapper_GetVBOs_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make a shallow copy of this mapper.
		/// </summary>
		// Token: 0x060034F7 RID: 13559 RVA: 0x0004D73C File Offset: 0x0004B93C
		public virtual vtkOpenGLVertexBufferObjectGroup GetVBOs()
		{
			vtkOpenGLVertexBufferObjectGroup vtkOpenGLVertexBufferObjectGroup = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_GetVBOs_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLVertexBufferObjectGroup = (vtkOpenGLVertexBufferObjectGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLVertexBufferObjectGroup.Register(null);
				}
			}
			return vtkOpenGLVertexBufferObjectGroup;
		}

		// Token: 0x060034F8 RID: 13560
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLPolyDataMapper_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060034F9 RID: 13561 RVA: 0x0004D7AC File Offset: 0x0004B9AC
		public override int IsA(string type)
		{
			return vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x060034FA RID: 13562
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLPolyDataMapper_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060034FB RID: 13563 RVA: 0x0004D7CC File Offset: 0x0004B9CC
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_IsTypeOf_13(type);
		}

		// Token: 0x060034FC RID: 13564
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_MapDataArrayToMultiTextureAttribute_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string tname, [MarshalAs(UnmanagedType.LPUTF8Str)] string dataArrayName, int fieldAssociation, int componentno);

		/// <summary>
		/// Select a data array from the point/cell data
		/// and map it to a generic vertex attribute.
		/// vertexAttributeName is the name of the vertex attribute.
		/// dataArrayName is the name of the data array.
		/// fieldAssociation indicates when the data array is a point data array or
		/// cell data array (vtkDataObject::FIELD_ASSOCIATION_POINTS or
		/// (vtkDataObject::FIELD_ASSOCIATION_CELLS).
		/// componentno indicates which component from the data array must be passed as
		/// the attribute. If -1, then all components are passed.
		/// </summary>
		// Token: 0x060034FD RID: 13565 RVA: 0x0004D7E6 File Offset: 0x0004B9E6
		public override void MapDataArrayToMultiTextureAttribute(string tname, string dataArrayName, int fieldAssociation, int componentno)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_MapDataArrayToMultiTextureAttribute_14(base.GetCppThis(), tname, dataArrayName, fieldAssociation, componentno);
		}

		// Token: 0x060034FE RID: 13566
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_MapDataArrayToVertexAttribute_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexAttributeName, [MarshalAs(UnmanagedType.LPUTF8Str)] string dataArrayName, int fieldAssociation, int componentno);

		/// <summary>
		/// Select a data array from the point/cell data
		/// and map it to a generic vertex attribute.
		/// vertexAttributeName is the name of the vertex attribute.
		/// dataArrayName is the name of the data array.
		/// fieldAssociation indicates when the data array is a point data array or
		/// cell data array (vtkDataObject::FIELD_ASSOCIATION_POINTS or
		/// (vtkDataObject::FIELD_ASSOCIATION_CELLS).
		/// componentno indicates which component from the data array must be passed as
		/// the attribute. If -1, then all components are passed.
		/// </summary>
		// Token: 0x060034FF RID: 13567 RVA: 0x0004D7FA File Offset: 0x0004B9FA
		public override void MapDataArrayToVertexAttribute(string vertexAttributeName, string dataArrayName, int fieldAssociation, int componentno)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_MapDataArrayToVertexAttribute_15(base.GetCppThis(), vertexAttributeName, dataArrayName, fieldAssociation, componentno);
		}

		// Token: 0x06003500 RID: 13568
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPolyDataMapper_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003501 RID: 13569 RVA: 0x0004D810 File Offset: 0x0004BA10
		public new vtkOpenGLPolyDataMapper NewInstance()
		{
			vtkOpenGLPolyDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003502 RID: 13570
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06003503 RID: 13571 RVA: 0x0004D86C File Offset: 0x0004BA6C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_ReleaseGraphicsResources_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003504 RID: 13572
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_RemoveAllVertexAttributeMappings_19(HandleRef pThis);

		/// <summary>
		/// Remove all vertex attributes.
		/// </summary>
		// Token: 0x06003505 RID: 13573 RVA: 0x0004D89B File Offset: 0x0004BA9B
		public override void RemoveAllVertexAttributeMappings()
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_RemoveAllVertexAttributeMappings_19(base.GetCppThis());
		}

		// Token: 0x06003506 RID: 13574
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_RemoveVertexAttributeMapping_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexAttributeName);

		/// <summary>
		/// Remove a vertex attribute mapping.
		/// </summary>
		// Token: 0x06003507 RID: 13575 RVA: 0x0004D8AA File Offset: 0x0004BAAA
		public override void RemoveVertexAttributeMapping(string vertexAttributeName)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_RemoveVertexAttributeMapping_20(base.GetCppThis(), vertexAttributeName);
		}

		// Token: 0x06003508 RID: 13576
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_RenderPiece_21(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		/// Implemented by sub classes. Actual rendering is done here.
		/// </summary>
		// Token: 0x06003509 RID: 13577 RVA: 0x0004D8BC File Offset: 0x0004BABC
		public override void RenderPiece(vtkRenderer ren, vtkActor act)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_RenderPiece_21(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x0600350A RID: 13578
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_RenderPieceDraw_22(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		/// Implemented by sub classes. Actual rendering is done here.
		/// </summary>
		// Token: 0x0600350B RID: 13579 RVA: 0x0004D900 File Offset: 0x0004BB00
		public virtual void RenderPieceDraw(vtkRenderer ren, vtkActor act)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_RenderPieceDraw_22(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x0600350C RID: 13580
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_RenderPieceFinish_23(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		/// Implemented by sub classes. Actual rendering is done here.
		/// </summary>
		// Token: 0x0600350D RID: 13581 RVA: 0x0004D944 File Offset: 0x0004BB44
		public virtual void RenderPieceFinish(vtkRenderer ren, vtkActor act)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_RenderPieceFinish_23(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x0600350E RID: 13582
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_RenderPieceStart_24(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		/// Implemented by sub classes. Actual rendering is done here.
		/// </summary>
		// Token: 0x0600350F RID: 13583 RVA: 0x0004D988 File Offset: 0x0004BB88
		public virtual void RenderPieceStart(vtkRenderer ren, vtkActor act)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_RenderPieceStart_24(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x06003510 RID: 13584
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPolyDataMapper_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003511 RID: 13585 RVA: 0x0004D9CC File Offset: 0x0004BBCC
		public new static vtkOpenGLPolyDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLPolyDataMapper vtkOpenGLPolyDataMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLPolyDataMapper = (vtkOpenGLPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLPolyDataMapper.Register(null);
				}
			}
			return vtkOpenGLPolyDataMapper;
		}

		// Token: 0x06003512 RID: 13586
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_SetCellIdArrayName_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// By default, this class uses the dataset's point and cell ids during
		/// rendering. However, one can override those by specifying cell and point
		/// data arrays to use instead. Currently, only vtkIdType array is supported.
		/// Set to NULL string (default) to use the point ids instead.
		/// </summary>
		// Token: 0x06003513 RID: 13587 RVA: 0x0004DA4B File Offset: 0x0004BC4B
		public virtual void SetCellIdArrayName(string _arg)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_SetCellIdArrayName_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06003514 RID: 13588
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_SetCompositeIdArrayName_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Generally, this class can render the composite id when iterating
		/// over composite datasets. However in some cases (as in AMR), the rendered
		/// structure may not correspond to the input data, in which case we need
		/// to provide a cell array that can be used to render in the composite id in
		/// selection passes. Set to NULL (default) to not override the composite id
		/// color set by vtkCompositePainter if any.
		/// The array *MUST* be a cell array and of type vtkUnsignedIntArray.
		/// </summary>
		// Token: 0x06003515 RID: 13589 RVA: 0x0004DA5B File Offset: 0x0004BC5B
		public virtual void SetCompositeIdArrayName(string _arg)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_SetCompositeIdArrayName_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06003516 RID: 13590
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_SetPointIdArrayName_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// By default, this class uses the dataset's point and cell ids during
		/// rendering. However, one can override those by specifying cell and point
		/// data arrays to use instead. Currently, only vtkIdType array is supported.
		/// Set to NULL string (default) to use the point ids instead.
		/// </summary>
		// Token: 0x06003517 RID: 13591 RVA: 0x0004DA6B File Offset: 0x0004BC6B
		public virtual void SetPointIdArrayName(string _arg)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_SetPointIdArrayName_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06003518 RID: 13592
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_SetPopulateSelectionSettings_29(HandleRef pThis, int v);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06003519 RID: 13593 RVA: 0x0004DA7B File Offset: 0x0004BC7B
		public void SetPopulateSelectionSettings(int v)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_SetPopulateSelectionSettings_29(base.GetCppThis(), v);
		}

		// Token: 0x0600351A RID: 13594
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_SetProcessIdArrayName_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If this class should override the process id using a data-array,
		/// set this variable to the name of the array to use. It must be a
		/// point-array.
		/// </summary>
		// Token: 0x0600351B RID: 13595 RVA: 0x0004DA8B File Offset: 0x0004BC8B
		public virtual void SetProcessIdArrayName(string _arg)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_SetProcessIdArrayName_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600351C RID: 13596
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_SetUseProgramPointSize_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Allow the shader code to set the point size (with gl_PointSize variable)
		/// instead of using the one defined by the property. Note that this flag is
		/// not available on OpenGLES as the feature is enabled by default. With
		/// OpenGL, the feature is turned off by default.
		/// Warning: on MacOS, enabling the feature result in non point drawing
		/// if the shaders do not set the point size.
		/// </summary>
		// Token: 0x0600351D RID: 13597 RVA: 0x0004DA9B File Offset: 0x0004BC9B
		public virtual void SetUseProgramPointSize(bool _arg)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_SetUseProgramPointSize_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600351E RID: 13598
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_SetVBOShiftScaleMethod_32(HandleRef pThis, int method);

		/// <summary>
		///   the VBO's shift+scale transform.
		/// </summary>
		// Token: 0x0600351F RID: 13599 RVA: 0x0004DAB3 File Offset: 0x0004BCB3
		public override void SetVBOShiftScaleMethod(int method)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_SetVBOShiftScaleMethod_32(base.GetCppThis(), method);
		}

		// Token: 0x06003520 RID: 13600
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_ShallowCopy_33(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Make a shallow copy of this mapper.
		/// </summary>
		// Token: 0x06003521 RID: 13601 RVA: 0x0004DAC4 File Offset: 0x0004BCC4
		public override void ShallowCopy(vtkAbstractMapper m)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_ShallowCopy_33(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x06003522 RID: 13602
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_UseProgramPointSizeOff_34(HandleRef pThis);

		/// <summary>
		/// Allow the shader code to set the point size (with gl_PointSize variable)
		/// instead of using the one defined by the property. Note that this flag is
		/// not available on OpenGLES as the feature is enabled by default. With
		/// OpenGL, the feature is turned off by default.
		/// Warning: on MacOS, enabling the feature result in non point drawing
		/// if the shaders do not set the point size.
		/// </summary>
		// Token: 0x06003523 RID: 13603 RVA: 0x0004DAF3 File Offset: 0x0004BCF3
		public virtual void UseProgramPointSizeOff()
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_UseProgramPointSizeOff_34(base.GetCppThis());
		}

		// Token: 0x06003524 RID: 13604
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper_UseProgramPointSizeOn_35(HandleRef pThis);

		/// <summary>
		/// Allow the shader code to set the point size (with gl_PointSize variable)
		/// instead of using the one defined by the property. Note that this flag is
		/// not available on OpenGLES as the feature is enabled by default. With
		/// OpenGL, the feature is turned off by default.
		/// Warning: on MacOS, enabling the feature result in non point drawing
		/// if the shaders do not set the point size.
		/// </summary>
		// Token: 0x06003525 RID: 13605 RVA: 0x0004DB02 File Offset: 0x0004BD02
		public virtual void UseProgramPointSizeOn()
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_UseProgramPointSizeOn_35(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000632 RID: 1586
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLPolyDataMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000633 RID: 1587
		public new static readonly string MRClassNameKey = "class vtkOpenGLPolyDataMapper";

		/// <summary>
		/// Allow the shader code to set the point size (with gl_PointSize variable)
		/// instead of using the one defined by the property. Note that this flag is
		/// not available on OpenGLES as the feature is enabled by default. With
		/// OpenGL, the feature is turned off by default.
		/// Warning: on MacOS, enabling the feature result in non point drawing
		/// if the shaders do not set the point size.
		/// </summary>
		// Token: 0x02000101 RID: 257
		public enum PrimitiveTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x04000635 RID: 1589
			PrimitiveEnd = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000636 RID: 1590
			PrimitiveLines = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000637 RID: 1591
			PrimitivePoints = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000638 RID: 1592
			PrimitiveStart = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000639 RID: 1593
			PrimitiveTriStrips = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400063A RID: 1594
			PrimitiveTris = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400063B RID: 1595
			PrimitiveVertices = 4
		}
	}
}
