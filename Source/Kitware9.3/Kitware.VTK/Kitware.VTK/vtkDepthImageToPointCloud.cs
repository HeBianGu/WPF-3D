using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDepthImageToPointCloud
	/// </summary>
	/// <remarks>
	///    convert a depth image into a point cloud
	///
	///
	/// vtkDepthImageToPointCloud is a filter that acquires its input
	/// from a depth image and converts it to point cloud represented as a
	/// vtkPolyData. This can then be used in a visualization pipeline.
	///
	/// The filter takes two input images, one of which is optional. The first
	/// image is a (required) depth image containing z-buffer values. The second
	/// image is an (optional) scalar image. The information in the z-buffer
	/// image, plus a specified camera, is used to generate x-y-z coordinates of
	/// the output point cloud (i.e., the points in a vtkPolyData). The second
	/// scalar image is (optionally) output as scalars to the output point
	/// cloud. Note that the depth image must be a single component image, with
	/// values ranging between the near and far clipping range [-1,1].
	///
	/// Note that if only a single input is provided, then the input is
	/// interpreted in one of two ways. First, if the "ZBuffer" point data is
	/// provided, then the input image is assumed to be color scalars with the
	/// depth data provided in the "ZBuffer" data array. (This is consistent with
	/// the vtkRendererSource filter with DepthValues enabled.) Otherwise, the
	/// input image is assumed to be a depth image.
	///
	/// It is (optionally) possible to cull points located on the near and far
	/// clipping planes. This may better simulate the generation of a scanned
	/// object point cloud.
	///
	/// @warning
	/// For the camera to transform the image depths into a point cloud, this
	/// filter makes assumptions about the origin of the depth image (and
	/// associated color scalar image). This class performs point by point
	/// transformation. The view matrix is used to transform each pixel. IMPORTANT
	/// NOTE: The transformation occurs by normalizing the image pixels into the
	/// (-1,1) view space (depth values are passed through). The process follows the
	/// vtkCoordinate class which is the standard for VTK rendering
	/// transformations. Subtle differences in whether the lower left pixel origin
	/// are at the center of the pixel versus the lower-left corner of the pixel
	/// will make slight differences in how pixels are transformed. (Similarly for
	/// the upper right pixel as well). This half pixel difference can cause
	/// transformation issues. (The code is commented appropriately.)
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRendererSource vtkWindowToImageFilter vtkCamera vtkPolyData
	/// vtkCoordinate
	/// </seealso>
	// Token: 0x0200010E RID: 270
	public class vtkDepthImageToPointCloud : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060036D9 RID: 14041 RVA: 0x00050378 File Offset: 0x0004E578
		static vtkDepthImageToPointCloud()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDepthImageToPointCloud.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDepthImageToPointCloud"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060036DA RID: 14042 RVA: 0x000503A0 File Offset: 0x0004E5A0
		public vtkDepthImageToPointCloud(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060036DB RID: 14043
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthImageToPointCloud_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x060036DC RID: 14044 RVA: 0x000503B0 File Offset: 0x0004E5B0
		public new static vtkDepthImageToPointCloud New()
		{
			vtkDepthImageToPointCloud result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthImageToPointCloud)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x060036DD RID: 14045 RVA: 0x00050404 File Offset: 0x0004E604
		public vtkDepthImageToPointCloud() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060036DE RID: 14046 RVA: 0x00050448 File Offset: 0x0004E648
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060036DF RID: 14047
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_CullFarPointsOff_01(HandleRef pThis);

		/// <summary>
		/// Indicate whether to cull points that are located on the far clipping
		/// plane. These typically are points that are part of the background. By
		/// default this is enabled.
		/// </summary>
		// Token: 0x060036E0 RID: 14048 RVA: 0x00050453 File Offset: 0x0004E653
		public virtual void CullFarPointsOff()
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_CullFarPointsOff_01(base.GetCppThis());
		}

		// Token: 0x060036E1 RID: 14049
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_CullFarPointsOn_02(HandleRef pThis);

		/// <summary>
		/// Indicate whether to cull points that are located on the far clipping
		/// plane. These typically are points that are part of the background. By
		/// default this is enabled.
		/// </summary>
		// Token: 0x060036E2 RID: 14050 RVA: 0x00050462 File Offset: 0x0004E662
		public virtual void CullFarPointsOn()
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_CullFarPointsOn_02(base.GetCppThis());
		}

		// Token: 0x060036E3 RID: 14051
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_CullNearPointsOff_03(HandleRef pThis);

		/// <summary>
		/// Indicate whether to cull points that are located on the near clipping
		/// plane. These typically are points that are part of the clipped foreground. By
		/// default this is disabled.
		/// </summary>
		// Token: 0x060036E4 RID: 14052 RVA: 0x00050471 File Offset: 0x0004E671
		public virtual void CullNearPointsOff()
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_CullNearPointsOff_03(base.GetCppThis());
		}

		// Token: 0x060036E5 RID: 14053
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_CullNearPointsOn_04(HandleRef pThis);

		/// <summary>
		/// Indicate whether to cull points that are located on the near clipping
		/// plane. These typically are points that are part of the clipped foreground. By
		/// default this is disabled.
		/// </summary>
		// Token: 0x060036E6 RID: 14054 RVA: 0x00050480 File Offset: 0x0004E680
		public virtual void CullNearPointsOn()
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_CullNearPointsOn_04(base.GetCppThis());
		}

		// Token: 0x060036E7 RID: 14055
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthImageToPointCloud_GetCamera_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the camera being used to generate the point cloud from the
		/// depth image.
		/// </summary>
		// Token: 0x060036E8 RID: 14056 RVA: 0x00050490 File Offset: 0x0004E690
		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_GetCamera_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060036E9 RID: 14057
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDepthImageToPointCloud_GetCullFarPoints_06(HandleRef pThis);

		/// <summary>
		/// Indicate whether to cull points that are located on the far clipping
		/// plane. These typically are points that are part of the background. By
		/// default this is enabled.
		/// </summary>
		// Token: 0x060036EA RID: 14058 RVA: 0x00050500 File Offset: 0x0004E700
		public virtual bool GetCullFarPoints()
		{
			return vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_GetCullFarPoints_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060036EB RID: 14059
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDepthImageToPointCloud_GetCullNearPoints_07(HandleRef pThis);

		/// <summary>
		/// Indicate whether to cull points that are located on the near clipping
		/// plane. These typically are points that are part of the clipped foreground. By
		/// default this is disabled.
		/// </summary>
		// Token: 0x060036EC RID: 14060 RVA: 0x00050528 File Offset: 0x0004E728
		public virtual bool GetCullNearPoints()
		{
			return vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_GetCullNearPoints_07(base.GetCppThis()) != 0;
		}

		// Token: 0x060036ED RID: 14061
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDepthImageToPointCloud_GetMTime_08(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the camera.
		/// </summary>
		// Token: 0x060036EE RID: 14062 RVA: 0x00050550 File Offset: 0x0004E750
		public override ulong GetMTime()
		{
			return vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_GetMTime_08(base.GetCppThis());
		}

		// Token: 0x060036EF RID: 14063
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDepthImageToPointCloud_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x060036F0 RID: 14064 RVA: 0x00050570 File Offset: 0x0004E770
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x060036F1 RID: 14065
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDepthImageToPointCloud_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x060036F2 RID: 14066 RVA: 0x00050590 File Offset: 0x0004E790
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x060036F3 RID: 14067
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthImageToPointCloud_GetOutputPointsPrecision_11(HandleRef pThis);

		/// <summary>
		/// Set the desired precision for the output points.
		/// See vtkAlgorithm::DesiredOutputPrecision for the available choices.
		/// The default is double precision.
		/// </summary>
		// Token: 0x060036F4 RID: 14068 RVA: 0x000505AC File Offset: 0x0004E7AC
		public virtual int GetOutputPointsPrecision()
		{
			return vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_GetOutputPointsPrecision_11(base.GetCppThis());
		}

		// Token: 0x060036F5 RID: 14069
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDepthImageToPointCloud_GetProduceColorScalars_12(HandleRef pThis);

		/// <summary>
		/// Indicate whether to output color scalar values along with the
		/// point cloud (assuming that the scalar values are available on
		/// input). By default this is enabled.
		/// </summary>
		// Token: 0x060036F6 RID: 14070 RVA: 0x000505CC File Offset: 0x0004E7CC
		public virtual bool GetProduceColorScalars()
		{
			return vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_GetProduceColorScalars_12(base.GetCppThis()) != 0;
		}

		// Token: 0x060036F7 RID: 14071
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDepthImageToPointCloud_GetProduceVertexCellArray_13(HandleRef pThis);

		/// <summary>
		/// Indicate whether to output a vertex cell array (i.e., Verts) in the
		/// output point cloud. Some filters require this vertex cells to be
		/// defined in order to execute properly. For example some mappers will
		/// only render points if the vertex cells are defined.
		/// </summary>
		// Token: 0x060036F8 RID: 14072 RVA: 0x000505F4 File Offset: 0x0004E7F4
		public virtual bool GetProduceVertexCellArray()
		{
			return vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_GetProduceVertexCellArray_13(base.GetCppThis()) != 0;
		}

		// Token: 0x060036F9 RID: 14073
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthImageToPointCloud_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x060036FA RID: 14074 RVA: 0x0005061C File Offset: 0x0004E81C
		public override int IsA(string type)
		{
			return vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x060036FB RID: 14075
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthImageToPointCloud_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x060036FC RID: 14076 RVA: 0x0005063C File Offset: 0x0004E83C
		public new static int IsTypeOf(string type)
		{
			return vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_IsTypeOf_15(type);
		}

		// Token: 0x060036FD RID: 14077
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthImageToPointCloud_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x060036FE RID: 14078 RVA: 0x00050658 File Offset: 0x0004E858
		public new vtkDepthImageToPointCloud NewInstance()
		{
			vtkDepthImageToPointCloud result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthImageToPointCloud)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060036FF RID: 14079
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_ProduceColorScalarsOff_18(HandleRef pThis);

		/// <summary>
		/// Indicate whether to output color scalar values along with the
		/// point cloud (assuming that the scalar values are available on
		/// input). By default this is enabled.
		/// </summary>
		// Token: 0x06003700 RID: 14080 RVA: 0x000506B2 File Offset: 0x0004E8B2
		public virtual void ProduceColorScalarsOff()
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_ProduceColorScalarsOff_18(base.GetCppThis());
		}

		// Token: 0x06003701 RID: 14081
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_ProduceColorScalarsOn_19(HandleRef pThis);

		/// <summary>
		/// Indicate whether to output color scalar values along with the
		/// point cloud (assuming that the scalar values are available on
		/// input). By default this is enabled.
		/// </summary>
		// Token: 0x06003702 RID: 14082 RVA: 0x000506C1 File Offset: 0x0004E8C1
		public virtual void ProduceColorScalarsOn()
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_ProduceColorScalarsOn_19(base.GetCppThis());
		}

		// Token: 0x06003703 RID: 14083
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_ProduceVertexCellArrayOff_20(HandleRef pThis);

		/// <summary>
		/// Indicate whether to output a vertex cell array (i.e., Verts) in the
		/// output point cloud. Some filters require this vertex cells to be
		/// defined in order to execute properly. For example some mappers will
		/// only render points if the vertex cells are defined.
		/// </summary>
		// Token: 0x06003704 RID: 14084 RVA: 0x000506D0 File Offset: 0x0004E8D0
		public virtual void ProduceVertexCellArrayOff()
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_ProduceVertexCellArrayOff_20(base.GetCppThis());
		}

		// Token: 0x06003705 RID: 14085
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_ProduceVertexCellArrayOn_21(HandleRef pThis);

		/// <summary>
		/// Indicate whether to output a vertex cell array (i.e., Verts) in the
		/// output point cloud. Some filters require this vertex cells to be
		/// defined in order to execute properly. For example some mappers will
		/// only render points if the vertex cells are defined.
		/// </summary>
		// Token: 0x06003706 RID: 14086 RVA: 0x000506DF File Offset: 0x0004E8DF
		public virtual void ProduceVertexCellArrayOn()
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_ProduceVertexCellArrayOn_21(base.GetCppThis());
		}

		// Token: 0x06003707 RID: 14087
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthImageToPointCloud_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x06003708 RID: 14088 RVA: 0x000506F0 File Offset: 0x0004E8F0
		public new static vtkDepthImageToPointCloud SafeDownCast(vtkObjectBase o)
		{
			vtkDepthImageToPointCloud vtkDepthImageToPointCloud = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDepthImageToPointCloud = (vtkDepthImageToPointCloud)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDepthImageToPointCloud.Register(null);
				}
			}
			return vtkDepthImageToPointCloud;
		}

		// Token: 0x06003709 RID: 14089
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_SetCamera_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Indicates what camera was used to generate the depth image. The camera
		/// parameters define a transformation which is used to perform coordinate
		/// conversion into the 3D x-y-z space of the point cloud.
		/// </summary>
		// Token: 0x0600370A RID: 14090 RVA: 0x00050770 File Offset: 0x0004E970
		public void SetCamera(vtkCamera arg0)
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_SetCamera_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600370B RID: 14091
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_SetCullFarPoints_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to cull points that are located on the far clipping
		/// plane. These typically are points that are part of the background. By
		/// default this is enabled.
		/// </summary>
		// Token: 0x0600370C RID: 14092 RVA: 0x0005079F File Offset: 0x0004E99F
		public virtual void SetCullFarPoints(bool _arg)
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_SetCullFarPoints_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600370D RID: 14093
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_SetCullNearPoints_25(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to cull points that are located on the near clipping
		/// plane. These typically are points that are part of the clipped foreground. By
		/// default this is disabled.
		/// </summary>
		// Token: 0x0600370E RID: 14094 RVA: 0x000507B7 File Offset: 0x0004E9B7
		public virtual void SetCullNearPoints(bool _arg)
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_SetCullNearPoints_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600370F RID: 14095
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_SetOutputPointsPrecision_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the desired precision for the output points.
		/// See vtkAlgorithm::DesiredOutputPrecision for the available choices.
		/// The default is double precision.
		/// </summary>
		// Token: 0x06003710 RID: 14096 RVA: 0x000507CF File Offset: 0x0004E9CF
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_SetOutputPointsPrecision_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06003711 RID: 14097
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_SetProduceColorScalars_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to output color scalar values along with the
		/// point cloud (assuming that the scalar values are available on
		/// input). By default this is enabled.
		/// </summary>
		// Token: 0x06003712 RID: 14098 RVA: 0x000507DF File Offset: 0x0004E9DF
		public virtual void SetProduceColorScalars(bool _arg)
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_SetProduceColorScalars_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003713 RID: 14099
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthImageToPointCloud_SetProduceVertexCellArray_28(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to output a vertex cell array (i.e., Verts) in the
		/// output point cloud. Some filters require this vertex cells to be
		/// defined in order to execute properly. For example some mappers will
		/// only render points if the vertex cells are defined.
		/// </summary>
		// Token: 0x06003714 RID: 14100 RVA: 0x000507F7 File Offset: 0x0004E9F7
		public virtual void SetProduceVertexCellArray(bool _arg)
		{
			vtkDepthImageToPointCloud.vtkDepthImageToPointCloud_SetProduceVertexCellArray_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000654 RID: 1620
		public new const string MRFullTypeName = "Kitware.VTK.vtkDepthImageToPointCloud";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000655 RID: 1621
		public new static readonly string MRClassNameKey = "class vtkDepthImageToPointCloud";
	}
}
