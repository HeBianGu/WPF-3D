using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRRenderer
	/// </summary>
	/// <remarks>
	///    Renderer class for VR/AR context.
	///
	/// vtkVRRenderer is an abstract vtkRenderer class that is meant to be used in VR context.
	/// It defines a floor actor with a grid fading with the distance, as well as a
	/// cross-like marker that can be attached to the tip of a controller (can be
	/// used e.g. to help place points).
	///
	/// Subclasses must define MakeCamera().
	/// </remarks>
	// Token: 0x020000AF RID: 175
	public abstract class vtkVRRenderer : vtkOpenGLRenderer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060026C3 RID: 9923 RVA: 0x0003946D File Offset: 0x0003766D
		static vtkVRRenderer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRRenderer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRRenderer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060026C4 RID: 9924 RVA: 0x00039495 File Offset: 0x00037695
		public vtkVRRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060026C5 RID: 9925 RVA: 0x000394A3 File Offset: 0x000376A3
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060026C6 RID: 9926
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderer_DeviceRender_01(HandleRef pThis);

		/// <summary>
		/// Render the floor using GetFloorTransform
		/// </summary>
		// Token: 0x060026C7 RID: 9927 RVA: 0x000394AE File Offset: 0x000376AE
		public override void DeviceRender()
		{
			vtkVRRenderer.vtkVRRenderer_DeviceRender_01(base.GetCppThis());
		}

		// Token: 0x060026C8 RID: 9928
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderer_GetFloorTransform_02(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Store in \p transform the floor transform.
		/// </summary>
		// Token: 0x060026C9 RID: 9929 RVA: 0x000394C0 File Offset: 0x000376C0
		public virtual void GetFloorTransform(vtkTransform transform)
		{
			vtkVRRenderer.vtkVRRenderer_GetFloorTransform_02(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x060026CA RID: 9930
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRRenderer_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026CB RID: 9931 RVA: 0x000394F0 File Offset: 0x000376F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRRenderer.vtkVRRenderer_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060026CC RID: 9932
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRRenderer_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026CD RID: 9933 RVA: 0x00039510 File Offset: 0x00037710
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRRenderer.vtkVRRenderer_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060026CE RID: 9934
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRRenderer_GetShowFloor_05(HandleRef pThis);

		/// <summary>
		/// Set/get whether to show a white floor corresponding to the physical floor.
		/// Default is false.
		/// </summary>
		// Token: 0x060026CF RID: 9935 RVA: 0x0003952C File Offset: 0x0003772C
		public virtual bool GetShowFloor()
		{
			return vtkVRRenderer.vtkVRRenderer_GetShowFloor_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060026D0 RID: 9936
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRRenderer_GetShowLeftMarker_06(HandleRef pThis);

		/// <summary>
		/// Set/get whether to display a white cross marker at the tip of the left controller.
		/// Default is false.
		/// </summary>
		// Token: 0x060026D1 RID: 9937 RVA: 0x00039554 File Offset: 0x00037754
		public virtual bool GetShowLeftMarker()
		{
			return vtkVRRenderer.vtkVRRenderer_GetShowLeftMarker_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060026D2 RID: 9938
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRRenderer_GetShowRightMarker_07(HandleRef pThis);

		/// <summary>
		/// Set/get whether to display a white cross marker at the tip of the right controller.
		/// Default is false.
		/// </summary>
		// Token: 0x060026D3 RID: 9939 RVA: 0x0003957C File Offset: 0x0003777C
		public virtual bool GetShowRightMarker()
		{
			return vtkVRRenderer.vtkVRRenderer_GetShowRightMarker_07(base.GetCppThis()) != 0;
		}

		// Token: 0x060026D4 RID: 9940
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRRenderer_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026D5 RID: 9941 RVA: 0x000395A4 File Offset: 0x000377A4
		public override int IsA(string type)
		{
			return vtkVRRenderer.vtkVRRenderer_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060026D6 RID: 9942
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRRenderer_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026D7 RID: 9943 RVA: 0x000395C4 File Offset: 0x000377C4
		public new static int IsTypeOf(string type)
		{
			return vtkVRRenderer.vtkVRRenderer_IsTypeOf_09(type);
		}

		// Token: 0x060026D8 RID: 9944
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderer_MakeCamera_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Abstract function that creates a new Camera suitable for use with this type of Renderer.
		/// </summary>
		// Token: 0x060026D9 RID: 9945 RVA: 0x000395E0 File Offset: 0x000377E0
		public override vtkCamera MakeCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderer.vtkVRRenderer_MakeCamera_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x060026DA RID: 9946
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderer_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026DB RID: 9947 RVA: 0x00039650 File Offset: 0x00037850
		public new vtkVRRenderer NewInstance()
		{
			vtkVRRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderer.vtkVRRenderer_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060026DC RID: 9948
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderer_ResetCamera_12(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Automatically set up the camera based on a specified bounding box
		/// (xmin,xmax, ymin,ymax, zmin,zmax). Camera will reposition itself so
		/// that its focal point is the center of the bounding box, and adjust its
		/// distance and position to preserve its initial view plane normal
		/// (i.e., vector defined from camera position to focal point). Note: if
		/// the view plane is parallel to the view up axis, the view up axis will
		/// be reset to one of the three coordinate axes.
		/// </summary>
		// Token: 0x060026DD RID: 9949 RVA: 0x000396AA File Offset: 0x000378AA
		public override void ResetCamera(IntPtr bounds)
		{
			vtkVRRenderer.vtkVRRenderer_ResetCamera_12(base.GetCppThis(), bounds);
		}

		// Token: 0x060026DE RID: 9950
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderer_ResetCameraClippingRange_13(HandleRef pThis);

		/// <summary>
		/// Reset the camera clipping range based on a bounding box.
		/// </summary>
		// Token: 0x060026DF RID: 9951 RVA: 0x000396BA File Offset: 0x000378BA
		public override void ResetCameraClippingRange()
		{
			vtkVRRenderer.vtkVRRenderer_ResetCameraClippingRange_13(base.GetCppThis());
		}

		// Token: 0x060026E0 RID: 9952
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderer_ResetCameraClippingRange_14(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Reset the camera clipping range based on a bounding box.
		/// </summary>
		// Token: 0x060026E1 RID: 9953 RVA: 0x000396C9 File Offset: 0x000378C9
		public override void ResetCameraClippingRange(IntPtr bounds)
		{
			vtkVRRenderer.vtkVRRenderer_ResetCameraClippingRange_14(base.GetCppThis(), bounds);
		}

		// Token: 0x060026E2 RID: 9954
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderer_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026E3 RID: 9955 RVA: 0x000396DC File Offset: 0x000378DC
		public new static vtkVRRenderer SafeDownCast(vtkObjectBase o)
		{
			vtkVRRenderer vtkVRRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderer.vtkVRRenderer_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRRenderer = (vtkVRRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRRenderer.Register(null);
				}
			}
			return vtkVRRenderer;
		}

		// Token: 0x060026E4 RID: 9956
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderer_SetShowFloor_16(HandleRef pThis, byte value);

		/// <summary>
		/// Set/get whether to show a white floor corresponding to the physical floor.
		/// Default is false.
		/// </summary>
		// Token: 0x060026E5 RID: 9957 RVA: 0x0003975B File Offset: 0x0003795B
		public virtual void SetShowFloor(bool value)
		{
			vtkVRRenderer.vtkVRRenderer_SetShowFloor_16(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		// Token: 0x060026E6 RID: 9958
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderer_SetShowLeftMarker_17(HandleRef pThis, byte value);

		/// <summary>
		/// Set/get whether to display a white cross marker at the tip of the left controller.
		/// Default is false.
		/// </summary>
		// Token: 0x060026E7 RID: 9959 RVA: 0x00039773 File Offset: 0x00037973
		public virtual void SetShowLeftMarker(bool value)
		{
			vtkVRRenderer.vtkVRRenderer_SetShowLeftMarker_17(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		// Token: 0x060026E8 RID: 9960
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderer_SetShowRightMarker_18(HandleRef pThis, byte value);

		/// <summary>
		/// Set/get whether to display a white cross marker at the tip of the right controller.
		/// Default is false.
		/// </summary>
		// Token: 0x060026E9 RID: 9961 RVA: 0x0003978B File Offset: 0x0003798B
		public virtual void SetShowRightMarker(bool value)
		{
			vtkVRRenderer.vtkVRRenderer_SetShowRightMarker_18(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000547 RID: 1351
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRRenderer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000548 RID: 1352
		public new static readonly string MRClassNameKey = "class vtkVRRenderer";
	}
}
