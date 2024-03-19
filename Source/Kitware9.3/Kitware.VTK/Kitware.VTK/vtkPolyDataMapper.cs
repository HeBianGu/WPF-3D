using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataMapper
	/// </summary>
	/// <remarks>
	///    map vtkPolyData to graphics primitives
	///
	/// vtkPolyDataMapper is a class that maps polygonal data (i.e., vtkPolyData)
	/// to graphics primitives. vtkPolyDataMapper serves as a superclass for
	/// device-specific poly data mappers, that actually do the mapping to the
	/// rendering/graphics hardware/software.
	/// </remarks>
	// Token: 0x020000FE RID: 254
	public class vtkPolyDataMapper : vtkMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600347E RID: 13438 RVA: 0x0004CD9F File Offset: 0x0004AF9F
		static vtkPolyDataMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600347F RID: 13439 RVA: 0x0004CDC7 File Offset: 0x0004AFC7
		public vtkPolyDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003480 RID: 13440
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003481 RID: 13441 RVA: 0x0004CDD8 File Offset: 0x0004AFD8
		public new static vtkPolyDataMapper New()
		{
			vtkPolyDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapper.vtkPolyDataMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003482 RID: 13442 RVA: 0x0004CE2C File Offset: 0x0004B02C
		public vtkPolyDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataMapper.vtkPolyDataMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003483 RID: 13443 RVA: 0x0004CE70 File Offset: 0x0004B070
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003484 RID: 13444
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPolyDataMapper_GenerateHash_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// This hash integer is computed by concrete graphics implementation of this class.
		/// For two different polydata instances, concrete implementations MUST return identical value,
		/// if both the polydata can be batched together for device uploads.
		///
		/// @note: For example, the OpenGL impl is capable of grouping polydata
		/// that are similar in terms of the availability of scalars, normals and tcoords.
		/// </summary>
		// Token: 0x06003485 RID: 13445 RVA: 0x0004CE7C File Offset: 0x0004B07C
		public virtual ulong GenerateHash(vtkPolyData arg0)
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GenerateHash_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003486 RID: 13446
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper_GetBounds_02(HandleRef pThis);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06003487 RID: 13447 RVA: 0x0004CEB0 File Offset: 0x0004B0B0
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkPolyDataMapper.vtkPolyDataMapper_GetBounds_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06003488 RID: 13448
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_GetBounds_03(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06003489 RID: 13449 RVA: 0x0004CEF8 File Offset: 0x0004B0F8
		public override void GetBounds(IntPtr bounds)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_GetBounds_03(base.GetCppThis(), bounds);
		}

		// Token: 0x0600348A RID: 13450
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper_GetGhostLevel_04(HandleRef pThis);

		/// <summary>
		/// Set the number of ghost cells to return.
		/// </summary>
		// Token: 0x0600348B RID: 13451 RVA: 0x0004CF08 File Offset: 0x0004B108
		public virtual int GetGhostLevel()
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetGhostLevel_04(base.GetCppThis());
		}

		// Token: 0x0600348C RID: 13452
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper_GetInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the input data to map.
		/// </summary>
		// Token: 0x0600348D RID: 13453 RVA: 0x0004CF28 File Offset: 0x0004B128
		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapper.vtkPolyDataMapper_GetInput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600348E RID: 13454
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataMapper_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600348F RID: 13455 RVA: 0x0004CF98 File Offset: 0x0004B198
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06003490 RID: 13456
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataMapper_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003491 RID: 13457 RVA: 0x0004CFB8 File Offset: 0x0004B1B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06003492 RID: 13458
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper_GetNumberOfPieces_08(HandleRef pThis);

		/// <summary>
		/// If you want only a part of the data, specify by setting the piece.
		/// </summary>
		// Token: 0x06003493 RID: 13459 RVA: 0x0004CFD4 File Offset: 0x0004B1D4
		public virtual int GetNumberOfPieces()
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetNumberOfPieces_08(base.GetCppThis());
		}

		// Token: 0x06003494 RID: 13460
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper_GetNumberOfSubPieces_09(HandleRef pThis);

		/// <summary>
		/// If you want only a part of the data, specify by setting the piece.
		/// </summary>
		// Token: 0x06003495 RID: 13461 RVA: 0x0004CFF4 File Offset: 0x0004B1F4
		public virtual int GetNumberOfSubPieces()
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetNumberOfSubPieces_09(base.GetCppThis());
		}

		// Token: 0x06003496 RID: 13462
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataMapper_GetPauseShiftScale_10(HandleRef pThis);

		/// <summary>
		///
		/// For large datasets, re-uploading the VBO during user interaction
		/// can cause stutters in the framerate. Interactors can use this
		/// method to force UpdateCameraShiftScale to return immediately
		/// (without changes) while users are zooming/rotating/etc. and then
		/// re-enable shift-scale just before a still render.
		///
		/// This setting has no effect unless the shift-scale method is set
		/// to NEAR_PLANE_SHIFT_SCALE or FOCAL_POINT_SHIFT_SCALE.
		///
		/// Changing this setting does **not** mark the mapper as modified as
		/// that would force a VBO upload – defeating its own purpose.
		/// </summary>
		// Token: 0x06003497 RID: 13463 RVA: 0x0004D014 File Offset: 0x0004B214
		public virtual bool GetPauseShiftScale()
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetPauseShiftScale_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06003498 RID: 13464
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper_GetPiece_11(HandleRef pThis);

		/// <summary>
		/// If you want only a part of the data, specify by setting the piece.
		/// </summary>
		// Token: 0x06003499 RID: 13465 RVA: 0x0004D03C File Offset: 0x0004B23C
		public virtual int GetPiece()
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetPiece_11(base.GetCppThis());
		}

		// Token: 0x0600349A RID: 13466
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataMapper_GetSeamlessU_12(HandleRef pThis);

		/// <summary>
		/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
		/// texture coordinates (u,v).
		///
		/// @note Implementation taken from the work of Marco Tarini:
		/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
		/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
		/// </summary>
		// Token: 0x0600349B RID: 13467 RVA: 0x0004D05C File Offset: 0x0004B25C
		public virtual bool GetSeamlessU()
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetSeamlessU_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0600349C RID: 13468
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataMapper_GetSeamlessV_13(HandleRef pThis);

		/// <summary>
		/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
		/// texture coordinates (u,v).
		///
		/// @note Implementation taken from the work of Marco Tarini:
		/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
		/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
		/// </summary>
		// Token: 0x0600349D RID: 13469 RVA: 0x0004D084 File Offset: 0x0004B284
		public virtual bool GetSeamlessV()
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetSeamlessV_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600349E RID: 13470
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper_GetVBOShiftScaleMethod_14(HandleRef pThis);

		/// <summary>
		///   the VBO's shift+scale transform.
		/// </summary>
		// Token: 0x0600349F RID: 13471 RVA: 0x0004D0AC File Offset: 0x0004B2AC
		public virtual int GetVBOShiftScaleMethod()
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetVBOShiftScaleMethod_14(base.GetCppThis());
		}

		// Token: 0x060034A0 RID: 13472
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060034A1 RID: 13473 RVA: 0x0004D0CC File Offset: 0x0004B2CC
		public override int IsA(string type)
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x060034A2 RID: 13474
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060034A3 RID: 13475 RVA: 0x0004D0EC File Offset: 0x0004B2EC
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_IsTypeOf_16(type);
		}

		// Token: 0x060034A4 RID: 13476
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_MapDataArrayToMultiTextureAttribute_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string textureName, [MarshalAs(UnmanagedType.LPUTF8Str)] string dataArrayName, int fieldAssociation, int componentno);

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
		/// Currently only point data is supported.
		/// </summary>
		// Token: 0x060034A5 RID: 13477 RVA: 0x0004D106 File Offset: 0x0004B306
		public virtual void MapDataArrayToMultiTextureAttribute(string textureName, string dataArrayName, int fieldAssociation, int componentno)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_MapDataArrayToMultiTextureAttribute_17(base.GetCppThis(), textureName, dataArrayName, fieldAssociation, componentno);
		}

		// Token: 0x060034A6 RID: 13478
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_MapDataArrayToVertexAttribute_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexAttributeName, [MarshalAs(UnmanagedType.LPUTF8Str)] string dataArrayName, int fieldAssociation, int componentno);

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
		/// Currently only point data is supported.
		/// </summary>
		// Token: 0x060034A7 RID: 13479 RVA: 0x0004D11A File Offset: 0x0004B31A
		public virtual void MapDataArrayToVertexAttribute(string vertexAttributeName, string dataArrayName, int fieldAssociation, int componentno)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_MapDataArrayToVertexAttribute_18(base.GetCppThis(), vertexAttributeName, dataArrayName, fieldAssociation, componentno);
		}

		// Token: 0x060034A8 RID: 13480
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060034A9 RID: 13481 RVA: 0x0004D130 File Offset: 0x0004B330
		public new vtkPolyDataMapper NewInstance()
		{
			vtkPolyDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapper.vtkPolyDataMapper_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060034AA RID: 13482
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_PauseShiftScaleOff_21(HandleRef pThis);

		/// <summary>
		///
		/// For large datasets, re-uploading the VBO during user interaction
		/// can cause stutters in the framerate. Interactors can use this
		/// method to force UpdateCameraShiftScale to return immediately
		/// (without changes) while users are zooming/rotating/etc. and then
		/// re-enable shift-scale just before a still render.
		///
		/// This setting has no effect unless the shift-scale method is set
		/// to NEAR_PLANE_SHIFT_SCALE or FOCAL_POINT_SHIFT_SCALE.
		///
		/// Changing this setting does **not** mark the mapper as modified as
		/// that would force a VBO upload – defeating its own purpose.
		/// </summary>
		// Token: 0x060034AB RID: 13483 RVA: 0x0004D18A File Offset: 0x0004B38A
		public virtual void PauseShiftScaleOff()
		{
			vtkPolyDataMapper.vtkPolyDataMapper_PauseShiftScaleOff_21(base.GetCppThis());
		}

		// Token: 0x060034AC RID: 13484
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_PauseShiftScaleOn_22(HandleRef pThis);

		/// <summary>
		///
		/// For large datasets, re-uploading the VBO during user interaction
		/// can cause stutters in the framerate. Interactors can use this
		/// method to force UpdateCameraShiftScale to return immediately
		/// (without changes) while users are zooming/rotating/etc. and then
		/// re-enable shift-scale just before a still render.
		///
		/// This setting has no effect unless the shift-scale method is set
		/// to NEAR_PLANE_SHIFT_SCALE or FOCAL_POINT_SHIFT_SCALE.
		///
		/// Changing this setting does **not** mark the mapper as modified as
		/// that would force a VBO upload – defeating its own purpose.
		/// </summary>
		// Token: 0x060034AD RID: 13485 RVA: 0x0004D199 File Offset: 0x0004B399
		public virtual void PauseShiftScaleOn()
		{
			vtkPolyDataMapper.vtkPolyDataMapper_PauseShiftScaleOn_22(base.GetCppThis());
		}

		// Token: 0x060034AE RID: 13486
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_RemoveAllVertexAttributeMappings_23(HandleRef pThis);

		/// <summary>
		/// Remove all vertex attributes.
		/// </summary>
		// Token: 0x060034AF RID: 13487 RVA: 0x0004D1A8 File Offset: 0x0004B3A8
		public virtual void RemoveAllVertexAttributeMappings()
		{
			vtkPolyDataMapper.vtkPolyDataMapper_RemoveAllVertexAttributeMappings_23(base.GetCppThis());
		}

		// Token: 0x060034B0 RID: 13488
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_RemoveVertexAttributeMapping_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexAttributeName);

		/// <summary>
		/// Remove a vertex attribute mapping.
		/// </summary>
		// Token: 0x060034B1 RID: 13489 RVA: 0x0004D1B7 File Offset: 0x0004B3B7
		public virtual void RemoveVertexAttributeMapping(string vertexAttributeName)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_RemoveVertexAttributeMapping_24(base.GetCppThis(), vertexAttributeName);
		}

		// Token: 0x060034B2 RID: 13490
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_Render_25(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		/// This calls RenderPiece (in a for loop if streaming is necessary).
		/// </summary>
		// Token: 0x060034B3 RID: 13491 RVA: 0x0004D1C8 File Offset: 0x0004B3C8
		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_Render_25(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x060034B4 RID: 13492
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_RenderPiece_26(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Implemented by sub classes. Actual rendering is done here.
		/// </summary>
		// Token: 0x060034B5 RID: 13493 RVA: 0x0004D20C File Offset: 0x0004B40C
		public virtual void RenderPiece(vtkRenderer arg0, vtkActor arg1)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_RenderPiece_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060034B6 RID: 13494
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060034B7 RID: 13495 RVA: 0x0004D250 File Offset: 0x0004B450
		public new static vtkPolyDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataMapper vtkPolyDataMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapper.vtkPolyDataMapper_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataMapper = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataMapper.Register(null);
				}
			}
			return vtkPolyDataMapper;
		}

		// Token: 0x060034B8 RID: 13496
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SeamlessUOff_28(HandleRef pThis);

		/// <summary>
		/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
		/// texture coordinates (u,v).
		///
		/// @note Implementation taken from the work of Marco Tarini:
		/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
		/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
		/// </summary>
		// Token: 0x060034B9 RID: 13497 RVA: 0x0004D2CF File Offset: 0x0004B4CF
		public virtual void SeamlessUOff()
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SeamlessUOff_28(base.GetCppThis());
		}

		// Token: 0x060034BA RID: 13498
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SeamlessUOn_29(HandleRef pThis);

		/// <summary>
		/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
		/// texture coordinates (u,v).
		///
		/// @note Implementation taken from the work of Marco Tarini:
		/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
		/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
		/// </summary>
		// Token: 0x060034BB RID: 13499 RVA: 0x0004D2DE File Offset: 0x0004B4DE
		public virtual void SeamlessUOn()
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SeamlessUOn_29(base.GetCppThis());
		}

		// Token: 0x060034BC RID: 13500
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SeamlessVOff_30(HandleRef pThis);

		/// <summary>
		/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
		/// texture coordinates (u,v).
		///
		/// @note Implementation taken from the work of Marco Tarini:
		/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
		/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
		/// </summary>
		// Token: 0x060034BD RID: 13501 RVA: 0x0004D2ED File Offset: 0x0004B4ED
		public virtual void SeamlessVOff()
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SeamlessVOff_30(base.GetCppThis());
		}

		// Token: 0x060034BE RID: 13502
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SeamlessVOn_31(HandleRef pThis);

		/// <summary>
		/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
		/// texture coordinates (u,v).
		///
		/// @note Implementation taken from the work of Marco Tarini:
		/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
		/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
		/// </summary>
		// Token: 0x060034BF RID: 13503 RVA: 0x0004D2FC File Offset: 0x0004B4FC
		public virtual void SeamlessVOn()
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SeamlessVOn_31(base.GetCppThis());
		}

		// Token: 0x060034C0 RID: 13504
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SetGhostLevel_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of ghost cells to return.
		/// </summary>
		// Token: 0x060034C1 RID: 13505 RVA: 0x0004D30B File Offset: 0x0004B50B
		public virtual void SetGhostLevel(int _arg)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetGhostLevel_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060034C2 RID: 13506
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SetInputData_33(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the input data to map.
		/// </summary>
		// Token: 0x060034C3 RID: 13507 RVA: 0x0004D31C File Offset: 0x0004B51C
		public void SetInputData(vtkPolyData arg0)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetInputData_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060034C4 RID: 13508
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SetNumberOfPieces_34(HandleRef pThis, int _arg);

		/// <summary>
		/// If you want only a part of the data, specify by setting the piece.
		/// </summary>
		// Token: 0x060034C5 RID: 13509 RVA: 0x0004D34B File Offset: 0x0004B54B
		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetNumberOfPieces_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060034C6 RID: 13510
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SetNumberOfSubPieces_35(HandleRef pThis, int _arg);

		/// <summary>
		/// If you want only a part of the data, specify by setting the piece.
		/// </summary>
		// Token: 0x060034C7 RID: 13511 RVA: 0x0004D35B File Offset: 0x0004B55B
		public virtual void SetNumberOfSubPieces(int _arg)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetNumberOfSubPieces_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060034C8 RID: 13512
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SetPauseShiftScale_36(HandleRef pThis, byte pauseShiftScale);

		/// <summary>
		///
		/// For large datasets, re-uploading the VBO during user interaction
		/// can cause stutters in the framerate. Interactors can use this
		/// method to force UpdateCameraShiftScale to return immediately
		/// (without changes) while users are zooming/rotating/etc. and then
		/// re-enable shift-scale just before a still render.
		///
		/// This setting has no effect unless the shift-scale method is set
		/// to NEAR_PLANE_SHIFT_SCALE or FOCAL_POINT_SHIFT_SCALE.
		///
		/// Changing this setting does **not** mark the mapper as modified as
		/// that would force a VBO upload – defeating its own purpose.
		/// </summary>
		// Token: 0x060034C9 RID: 13513 RVA: 0x0004D36B File Offset: 0x0004B56B
		public virtual void SetPauseShiftScale(bool pauseShiftScale)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetPauseShiftScale_36(base.GetCppThis(), pauseShiftScale ? (byte)1 : (byte)0);
		}

		// Token: 0x060034CA RID: 13514
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SetPiece_37(HandleRef pThis, int _arg);

		/// <summary>
		/// If you want only a part of the data, specify by setting the piece.
		/// </summary>
		// Token: 0x060034CB RID: 13515 RVA: 0x0004D383 File Offset: 0x0004B583
		public virtual void SetPiece(int _arg)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetPiece_37(base.GetCppThis(), _arg);
		}

		// Token: 0x060034CC RID: 13516
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SetSeamlessU_38(HandleRef pThis, byte _arg);

		/// <summary>
		/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
		/// texture coordinates (u,v).
		///
		/// @note Implementation taken from the work of Marco Tarini:
		/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
		/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
		/// </summary>
		// Token: 0x060034CD RID: 13517 RVA: 0x0004D393 File Offset: 0x0004B593
		public virtual void SetSeamlessU(bool _arg)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetSeamlessU_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060034CE RID: 13518
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SetSeamlessV_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
		/// texture coordinates (u,v).
		///
		/// @note Implementation taken from the work of Marco Tarini:
		/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
		/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
		/// </summary>
		// Token: 0x060034CF RID: 13519 RVA: 0x0004D3AB File Offset: 0x0004B5AB
		public virtual void SetSeamlessV(bool _arg)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetSeamlessV_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060034D0 RID: 13520
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_SetVBOShiftScaleMethod_40(HandleRef pThis, int arg0);

		/// <summary>
		///   the VBO's shift+scale transform.
		/// </summary>
		// Token: 0x060034D1 RID: 13521 RVA: 0x0004D3C3 File Offset: 0x0004B5C3
		public virtual void SetVBOShiftScaleMethod(int arg0)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetVBOShiftScaleMethod_40(base.GetCppThis(), arg0);
		}

		// Token: 0x060034D2 RID: 13522
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_ShallowCopy_41(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Make a shallow copy of this mapper.
		/// </summary>
		// Token: 0x060034D3 RID: 13523 RVA: 0x0004D3D4 File Offset: 0x0004B5D4
		public override void ShallowCopy(vtkAbstractMapper m)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_ShallowCopy_41(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x060034D4 RID: 13524
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_Update_42(HandleRef pThis, int port);

		/// <summary>
		/// Bring this algorithm's outputs up-to-date.
		/// </summary>
		// Token: 0x060034D5 RID: 13525 RVA: 0x0004D403 File Offset: 0x0004B603
		public override void Update(int port)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_Update_42(base.GetCppThis(), port);
		}

		// Token: 0x060034D6 RID: 13526
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper_Update_43(HandleRef pThis);

		/// <summary>
		/// Bring this algorithm's outputs up-to-date.
		/// </summary>
		// Token: 0x060034D7 RID: 13527 RVA: 0x0004D413 File Offset: 0x0004B613
		public override void Update()
		{
			vtkPolyDataMapper.vtkPolyDataMapper_Update_43(base.GetCppThis());
		}

		// Token: 0x060034D8 RID: 13528
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper_Update_44(HandleRef pThis, int port, HandleRef requests);

		/// <summary>
		/// Bring this algorithm's outputs up-to-date.
		/// </summary>
		// Token: 0x060034D9 RID: 13529 RVA: 0x0004D424 File Offset: 0x0004B624
		public override int Update(int port, vtkInformationVector requests)
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_Update_44(base.GetCppThis(), port, (requests == null) ? default(HandleRef) : requests.GetCppThis());
		}

		// Token: 0x060034DA RID: 13530
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper_Update_45(HandleRef pThis, HandleRef requests);

		/// <summary>
		/// Bring this algorithm's outputs up-to-date.
		/// </summary>
		// Token: 0x060034DB RID: 13531 RVA: 0x0004D45C File Offset: 0x0004B65C
		public override int Update(vtkInformation requests)
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_Update_45(base.GetCppThis(), (requests == null) ? default(HandleRef) : requests.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000628 RID: 1576
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000629 RID: 1577
		public new static readonly string MRClassNameKey = "class vtkPolyDataMapper";

		/// <summary>
		///
		/// By default, shift and scale vectors are enabled
		/// whenever CreateVBO is called with points whose
		/// bounds are many bbox-lengths away from the origin.
		///
		/// Shifting and scaling may be completely disabled,
		/// or manually specified, or left at the default.
		///
		/// Manual specification is for the case when you
		/// will be calling AppendVBO instead of just CreateVBO
		/// and know better bounds than the what CreateVBO
		/// might produce.
		///
		/// The automatic method tells CreatVBO to compute shift and
		/// scale vectors that remap the points to the unit cube.
		///
		/// The camera method will shift scale the VBO so that the visible
		/// part of the data has reasonable values.
		/// </summary>
		// Token: 0x020000FF RID: 255
		public enum ShiftScaleMethodType
		{
			/// <summary>enum member</summary>
			// Token: 0x0400062B RID: 1579
			ALWAYS_AUTO_SHIFT_SCALE = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400062C RID: 1580
			AUTO_SHIFT = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400062D RID: 1581
			AUTO_SHIFT_SCALE = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400062E RID: 1582
			DISABLE_SHIFT_SCALE = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400062F RID: 1583
			FOCAL_POINT_SHIFT_SCALE = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000630 RID: 1584
			MANUAL_SHIFT_SCALE = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000631 RID: 1585
			NEAR_PLANE_SHIFT_SCALE = 5
		}
	}
}
