using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridMapper
	/// </summary>
	/// <remarks>
	///    map a vtkCellGrid to graphics primitives.
	///
	/// This mapper is a prototype to help enhance VTK visualization capabilities for
	/// Discontinuous Galerkin fields.
	/// It requires a `vtkCellGrid` input.
	///
	/// A vtkCellGrid does not couple the fields with geometric degrees of freedom, unlike
	/// vtkDataSet. This is useful to render Discontinuous Galerkin fields where two points
	/// sharing a common face might not have the same field value (discontinuous).
	///
	/// Cell grids can also define functions in novel function spaces such as the H(Curl)
	/// and H(Div) spaces.
	/// </remarks>
	// Token: 0x02000128 RID: 296
	public class vtkCellGridMapper : vtkMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003C12 RID: 15378 RVA: 0x0005777F File Offset: 0x0005597F
		static vtkCellGridMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003C13 RID: 15379 RVA: 0x000577A7 File Offset: 0x000559A7
		public vtkCellGridMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003C14 RID: 15380
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C15 RID: 15381 RVA: 0x000577B8 File Offset: 0x000559B8
		public new static vtkCellGridMapper New()
		{
			vtkCellGridMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridMapper.vtkCellGridMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C16 RID: 15382 RVA: 0x0005780C File Offset: 0x00055A0C
		public vtkCellGridMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridMapper.vtkCellGridMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003C17 RID: 15383 RVA: 0x00057850 File Offset: 0x00055A50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003C18 RID: 15384
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridMapper_GetBounds_01(HandleRef pThis);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06003C19 RID: 15385 RVA: 0x0005785C File Offset: 0x00055A5C
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCellGridMapper.vtkCellGridMapper_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06003C1A RID: 15386
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridMapper_GetBounds_02(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06003C1B RID: 15387 RVA: 0x000578A4 File Offset: 0x00055AA4
		public override void GetBounds(IntPtr bounds)
		{
			vtkCellGridMapper.vtkCellGridMapper_GetBounds_02(base.GetCppThis(), bounds);
		}

		// Token: 0x06003C1C RID: 15388
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridMapper_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the input data to map.
		/// </summary>
		// Token: 0x06003C1D RID: 15389 RVA: 0x000578B4 File Offset: 0x00055AB4
		public new vtkCellGrid GetInput()
		{
			vtkCellGrid vtkCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridMapper.vtkCellGridMapper_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGrid = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGrid.Register(null);
				}
			}
			return vtkCellGrid;
		}

		// Token: 0x06003C1E RID: 15390
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridMapper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C1F RID: 15391 RVA: 0x00057924 File Offset: 0x00055B24
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridMapper.vtkCellGridMapper_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06003C20 RID: 15392
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridMapper_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C21 RID: 15393 RVA: 0x00057944 File Offset: 0x00055B44
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridMapper.vtkCellGridMapper_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06003C22 RID: 15394
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridMapper_GetVisualizeBasisFunction_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C23 RID: 15395 RVA: 0x00057960 File Offset: 0x00055B60
		public virtual int GetVisualizeBasisFunction()
		{
			return vtkCellGridMapper.vtkCellGridMapper_GetVisualizeBasisFunction_06(base.GetCppThis());
		}

		// Token: 0x06003C24 RID: 15396
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridMapper_GetVisualizePCoords_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C25 RID: 15397 RVA: 0x00057980 File Offset: 0x00055B80
		public virtual int GetVisualizePCoords()
		{
			return vtkCellGridMapper.vtkCellGridMapper_GetVisualizePCoords_07(base.GetCppThis());
		}

		// Token: 0x06003C26 RID: 15398
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGridMapper_HasTranslucentPolygonalGeometry_08(HandleRef pThis);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06003C27 RID: 15399 RVA: 0x000579A0 File Offset: 0x00055BA0
		public override bool HasTranslucentPolygonalGeometry()
		{
			return vtkCellGridMapper.vtkCellGridMapper_HasTranslucentPolygonalGeometry_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06003C28 RID: 15400
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridMapper_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C29 RID: 15401 RVA: 0x000579C8 File Offset: 0x00055BC8
		public override int IsA(string type)
		{
			return vtkCellGridMapper.vtkCellGridMapper_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06003C2A RID: 15402
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridMapper_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C2B RID: 15403 RVA: 0x000579E8 File Offset: 0x00055BE8
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridMapper.vtkCellGridMapper_IsTypeOf_10(type);
		}

		// Token: 0x06003C2C RID: 15404
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridMapper_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C2D RID: 15405 RVA: 0x00057A04 File Offset: 0x00055C04
		public new vtkCellGridMapper NewInstance()
		{
			vtkCellGridMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridMapper.vtkCellGridMapper_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003C2E RID: 15406
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridMapper_PrepareColormap_13(HandleRef pThis, HandleRef cmap);

		/// <summary>
		/// Bring this algorithm's outputs up-to-date.
		/// </summary>
		// Token: 0x06003C2F RID: 15407 RVA: 0x00057A60 File Offset: 0x00055C60
		public void PrepareColormap(vtkScalarsToColors cmap)
		{
			vtkCellGridMapper.vtkCellGridMapper_PrepareColormap_13(base.GetCppThis(), (cmap == null) ? default(HandleRef) : cmap.GetCppThis());
		}

		// Token: 0x06003C30 RID: 15408
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridMapper_Render_14(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Implemented by sub classes. Actual rendering is done here.
		/// </summary>
		// Token: 0x06003C31 RID: 15409 RVA: 0x00057A90 File Offset: 0x00055C90
		public override void Render(vtkRenderer arg0, vtkActor arg1)
		{
			vtkCellGridMapper.vtkCellGridMapper_Render_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06003C32 RID: 15410
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridMapper_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C33 RID: 15411 RVA: 0x00057AD4 File Offset: 0x00055CD4
		public new static vtkCellGridMapper SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridMapper vtkCellGridMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridMapper.vtkCellGridMapper_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridMapper = (vtkCellGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridMapper.Register(null);
				}
			}
			return vtkCellGridMapper;
		}

		// Token: 0x06003C34 RID: 15412
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridMapper_SetInputData_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the input data to map.
		/// </summary>
		// Token: 0x06003C35 RID: 15413 RVA: 0x00057B54 File Offset: 0x00055D54
		public void SetInputData(vtkCellGrid arg0)
		{
			vtkCellGridMapper.vtkCellGridMapper_SetInputData_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003C36 RID: 15414
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridMapper_SetVisualizeBasisFunction_17(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C37 RID: 15415 RVA: 0x00057B83 File Offset: 0x00055D83
		public virtual void SetVisualizeBasisFunction(int _arg)
		{
			vtkCellGridMapper.vtkCellGridMapper_SetVisualizeBasisFunction_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06003C38 RID: 15416
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridMapper_SetVisualizePCoords_18(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C39 RID: 15417 RVA: 0x00057B93 File Offset: 0x00055D93
		public virtual void SetVisualizePCoords(int _arg)
		{
			vtkCellGridMapper.vtkCellGridMapper_SetVisualizePCoords_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06003C3A RID: 15418
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridMapper_Update_19(HandleRef pThis, int port);

		/// <summary>
		/// Bring this algorithm's outputs up-to-date.
		/// </summary>
		// Token: 0x06003C3B RID: 15419 RVA: 0x00057BA3 File Offset: 0x00055DA3
		public override void Update(int port)
		{
			vtkCellGridMapper.vtkCellGridMapper_Update_19(base.GetCppThis(), port);
		}

		// Token: 0x06003C3C RID: 15420
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridMapper_Update_20(HandleRef pThis);

		/// <summary>
		/// Bring this algorithm's outputs up-to-date.
		/// </summary>
		// Token: 0x06003C3D RID: 15421 RVA: 0x00057BB3 File Offset: 0x00055DB3
		public override void Update()
		{
			vtkCellGridMapper.vtkCellGridMapper_Update_20(base.GetCppThis());
		}

		// Token: 0x06003C3E RID: 15422
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridMapper_Update_21(HandleRef pThis, int port, HandleRef requests);

		/// <summary>
		/// Bring this algorithm's outputs up-to-date.
		/// </summary>
		// Token: 0x06003C3F RID: 15423 RVA: 0x00057BC4 File Offset: 0x00055DC4
		public override int Update(int port, vtkInformationVector requests)
		{
			return vtkCellGridMapper.vtkCellGridMapper_Update_21(base.GetCppThis(), port, (requests == null) ? default(HandleRef) : requests.GetCppThis());
		}

		// Token: 0x06003C40 RID: 15424
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridMapper_Update_22(HandleRef pThis, HandleRef requests);

		/// <summary>
		/// Bring this algorithm's outputs up-to-date.
		/// </summary>
		// Token: 0x06003C41 RID: 15425 RVA: 0x00057BFC File Offset: 0x00055DFC
		public override int Update(vtkInformation requests)
		{
			return vtkCellGridMapper.vtkCellGridMapper_Update_22(base.GetCppThis(), (requests == null) ? default(HandleRef) : requests.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000689 RID: 1673
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400068A RID: 1674
		public new static readonly string MRClassNameKey = "class vtkCellGridMapper";
	}
}
