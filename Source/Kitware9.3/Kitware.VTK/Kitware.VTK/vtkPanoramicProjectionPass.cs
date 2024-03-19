using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPanoramicProjectionPass
	/// </summary>
	/// <remarks>
	///    Render pass that render the scene in a cubemap and project
	/// these six renderings to a single quad.
	/// There are currently two different projections implemented (Equirectangular and Azimuthal).
	/// This pass can be used to produce images that can be visualize with specific devices that re-maps
	/// the distorted image to a panoramic view (for instance VR headsets, domes, panoramic screens)
	///
	/// Note that it is often necessary to disable frustum cullers in order to render
	/// properly objects that are behind the camera.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x020005E0 RID: 1504
	public class vtkPanoramicProjectionPass : vtkImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601067F RID: 67199 RVA: 0x0016DDBB File Offset: 0x0016BFBB
		static vtkPanoramicProjectionPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPanoramicProjectionPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPanoramicProjectionPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010680 RID: 67200 RVA: 0x0016DDE3 File Offset: 0x0016BFE3
		public vtkPanoramicProjectionPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010681 RID: 67201
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPanoramicProjectionPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010682 RID: 67202 RVA: 0x0016DDF4 File Offset: 0x0016BFF4
		public new static vtkPanoramicProjectionPass New()
		{
			vtkPanoramicProjectionPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPanoramicProjectionPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010683 RID: 67203 RVA: 0x0016DE48 File Offset: 0x0016C048
		public vtkPanoramicProjectionPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010684 RID: 67204 RVA: 0x0016DE8C File Offset: 0x0016C08C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010685 RID: 67205
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPanoramicProjectionPass_GetAngle_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the vertical angle of projection.
		/// 180 degrees is a half sphere, 360 degrees is a full sphere,
		/// but any values in the range (90;360) can be set.
		/// Default is 180 degrees.
		/// </summary>
		// Token: 0x06010686 RID: 67206 RVA: 0x0016DE98 File Offset: 0x0016C098
		public virtual double GetAngle()
		{
			return vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_GetAngle_01(base.GetCppThis());
		}

		// Token: 0x06010687 RID: 67207
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPanoramicProjectionPass_GetAngleMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the vertical angle of projection.
		/// 180 degrees is a half sphere, 360 degrees is a full sphere,
		/// but any values in the range (90;360) can be set.
		/// Default is 180 degrees.
		/// </summary>
		// Token: 0x06010688 RID: 67208 RVA: 0x0016DEB8 File Offset: 0x0016C0B8
		public virtual double GetAngleMaxValue()
		{
			return vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_GetAngleMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06010689 RID: 67209
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPanoramicProjectionPass_GetAngleMinValue_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the vertical angle of projection.
		/// 180 degrees is a half sphere, 360 degrees is a full sphere,
		/// but any values in the range (90;360) can be set.
		/// Default is 180 degrees.
		/// </summary>
		// Token: 0x0601068A RID: 67210 RVA: 0x0016DED8 File Offset: 0x0016C0D8
		public virtual double GetAngleMinValue()
		{
			return vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_GetAngleMinValue_03(base.GetCppThis());
		}

		// Token: 0x0601068B RID: 67211
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPanoramicProjectionPass_GetCubeResolution_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the cubemap textures resolution used to render (offscreen) all directions.
		/// Default is 300.
		/// </summary>
		// Token: 0x0601068C RID: 67212 RVA: 0x0016DEF8 File Offset: 0x0016C0F8
		public virtual uint GetCubeResolution()
		{
			return vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_GetCubeResolution_04(base.GetCppThis());
		}

		// Token: 0x0601068D RID: 67213
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPanoramicProjectionPass_GetInterpolate_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the interpolation mode.
		/// If true, the projection of the cubemap use hardware interpolation.
		/// Default is off.
		/// </summary>
		// Token: 0x0601068E RID: 67214 RVA: 0x0016DF18 File Offset: 0x0016C118
		public virtual bool GetInterpolate()
		{
			return vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_GetInterpolate_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601068F RID: 67215
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPanoramicProjectionPass_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010690 RID: 67216 RVA: 0x0016DF40 File Offset: 0x0016C140
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06010691 RID: 67217
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPanoramicProjectionPass_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010692 RID: 67218 RVA: 0x0016DF60 File Offset: 0x0016C160
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06010693 RID: 67219
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPanoramicProjectionPass_GetProjectionType_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the type of projection.
		/// Equirectangular projection maps meridians to vertical straight lines and circles of latitude to
		/// horizontal straight lines.
		/// Azimuthal equidistant projection maps all points of the scene based on their distance to the
		/// view direction. This projection produces a fisheye effect.
		/// Default is Equirectangular.
		/// </summary>
		// Token: 0x06010694 RID: 67220 RVA: 0x0016DF7C File Offset: 0x0016C17C
		public virtual int GetProjectionType()
		{
			return vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_GetProjectionType_08(base.GetCppThis());
		}

		// Token: 0x06010695 RID: 67221
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPanoramicProjectionPass_GetProjectionTypeMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Get/Set the type of projection.
		/// Equirectangular projection maps meridians to vertical straight lines and circles of latitude to
		/// horizontal straight lines.
		/// Azimuthal equidistant projection maps all points of the scene based on their distance to the
		/// view direction. This projection produces a fisheye effect.
		/// Default is Equirectangular.
		/// </summary>
		// Token: 0x06010696 RID: 67222 RVA: 0x0016DF9C File Offset: 0x0016C19C
		public virtual int GetProjectionTypeMaxValue()
		{
			return vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_GetProjectionTypeMaxValue_09(base.GetCppThis());
		}

		// Token: 0x06010697 RID: 67223
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPanoramicProjectionPass_GetProjectionTypeMinValue_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the type of projection.
		/// Equirectangular projection maps meridians to vertical straight lines and circles of latitude to
		/// horizontal straight lines.
		/// Azimuthal equidistant projection maps all points of the scene based on their distance to the
		/// view direction. This projection produces a fisheye effect.
		/// Default is Equirectangular.
		/// </summary>
		// Token: 0x06010698 RID: 67224 RVA: 0x0016DFBC File Offset: 0x0016C1BC
		public virtual int GetProjectionTypeMinValue()
		{
			return vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_GetProjectionTypeMinValue_10(base.GetCppThis());
		}

		// Token: 0x06010699 RID: 67225
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPanoramicProjectionPass_InterpolateOff_11(HandleRef pThis);

		/// <summary>
		/// Get/Set the interpolation mode.
		/// If true, the projection of the cubemap use hardware interpolation.
		/// Default is off.
		/// </summary>
		// Token: 0x0601069A RID: 67226 RVA: 0x0016DFDB File Offset: 0x0016C1DB
		public virtual void InterpolateOff()
		{
			vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_InterpolateOff_11(base.GetCppThis());
		}

		// Token: 0x0601069B RID: 67227
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPanoramicProjectionPass_InterpolateOn_12(HandleRef pThis);

		/// <summary>
		/// Get/Set the interpolation mode.
		/// If true, the projection of the cubemap use hardware interpolation.
		/// Default is off.
		/// </summary>
		// Token: 0x0601069C RID: 67228 RVA: 0x0016DFEA File Offset: 0x0016C1EA
		public virtual void InterpolateOn()
		{
			vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_InterpolateOn_12(base.GetCppThis());
		}

		// Token: 0x0601069D RID: 67229
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPanoramicProjectionPass_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601069E RID: 67230 RVA: 0x0016DFFC File Offset: 0x0016C1FC
		public override int IsA(string type)
		{
			return vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0601069F RID: 67231
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPanoramicProjectionPass_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106A0 RID: 67232 RVA: 0x0016E01C File Offset: 0x0016C21C
		public new static int IsTypeOf(string type)
		{
			return vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_IsTypeOf_14(type);
		}

		// Token: 0x060106A1 RID: 67233
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPanoramicProjectionPass_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106A2 RID: 67234 RVA: 0x0016E038 File Offset: 0x0016C238
		public new vtkPanoramicProjectionPass NewInstance()
		{
			vtkPanoramicProjectionPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPanoramicProjectionPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060106A3 RID: 67235
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPanoramicProjectionPass_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own resources.
		/// </summary>
		// Token: 0x060106A4 RID: 67236 RVA: 0x0016E094 File Offset: 0x0016C294
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_ReleaseGraphicsResources_17(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x060106A5 RID: 67237
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPanoramicProjectionPass_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106A6 RID: 67238 RVA: 0x0016E0C4 File Offset: 0x0016C2C4
		public new static vtkPanoramicProjectionPass SafeDownCast(vtkObjectBase o)
		{
			vtkPanoramicProjectionPass vtkPanoramicProjectionPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPanoramicProjectionPass = (vtkPanoramicProjectionPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPanoramicProjectionPass.Register(null);
				}
			}
			return vtkPanoramicProjectionPass;
		}

		// Token: 0x060106A7 RID: 67239
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPanoramicProjectionPass_SetAngle_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the vertical angle of projection.
		/// 180 degrees is a half sphere, 360 degrees is a full sphere,
		/// but any values in the range (90;360) can be set.
		/// Default is 180 degrees.
		/// </summary>
		// Token: 0x060106A8 RID: 67240 RVA: 0x0016E143 File Offset: 0x0016C343
		public virtual void SetAngle(double _arg)
		{
			vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_SetAngle_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060106A9 RID: 67241
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPanoramicProjectionPass_SetCubeResolution_20(HandleRef pThis, uint _arg);

		/// <summary>
		/// Get/Set the cubemap textures resolution used to render (offscreen) all directions.
		/// Default is 300.
		/// </summary>
		// Token: 0x060106AA RID: 67242 RVA: 0x0016E153 File Offset: 0x0016C353
		public virtual void SetCubeResolution(uint _arg)
		{
			vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_SetCubeResolution_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060106AB RID: 67243
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPanoramicProjectionPass_SetInterpolate_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set the interpolation mode.
		/// If true, the projection of the cubemap use hardware interpolation.
		/// Default is off.
		/// </summary>
		// Token: 0x060106AC RID: 67244 RVA: 0x0016E163 File Offset: 0x0016C363
		public virtual void SetInterpolate(bool _arg)
		{
			vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_SetInterpolate_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060106AD RID: 67245
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPanoramicProjectionPass_SetProjectionType_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the type of projection.
		/// Equirectangular projection maps meridians to vertical straight lines and circles of latitude to
		/// horizontal straight lines.
		/// Azimuthal equidistant projection maps all points of the scene based on their distance to the
		/// view direction. This projection produces a fisheye effect.
		/// Default is Equirectangular.
		/// </summary>
		// Token: 0x060106AE RID: 67246 RVA: 0x0016E17B File Offset: 0x0016C37B
		public virtual void SetProjectionType(int _arg)
		{
			vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_SetProjectionType_22(base.GetCppThis(), _arg);
		}

		// Token: 0x060106AF RID: 67247
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPanoramicProjectionPass_SetProjectionTypeToAzimuthal_23(HandleRef pThis);

		/// <summary>
		/// Get/Set the type of projection.
		/// Equirectangular projection maps meridians to vertical straight lines and circles of latitude to
		/// horizontal straight lines.
		/// Azimuthal equidistant projection maps all points of the scene based on their distance to the
		/// view direction. This projection produces a fisheye effect.
		/// Default is Equirectangular.
		/// </summary>
		// Token: 0x060106B0 RID: 67248 RVA: 0x0016E18B File Offset: 0x0016C38B
		public void SetProjectionTypeToAzimuthal()
		{
			vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_SetProjectionTypeToAzimuthal_23(base.GetCppThis());
		}

		// Token: 0x060106B1 RID: 67249
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPanoramicProjectionPass_SetProjectionTypeToEquirectangular_24(HandleRef pThis);

		/// <summary>
		/// Get/Set the type of projection.
		/// Equirectangular projection maps meridians to vertical straight lines and circles of latitude to
		/// horizontal straight lines.
		/// Azimuthal equidistant projection maps all points of the scene based on their distance to the
		/// view direction. This projection produces a fisheye effect.
		/// Default is Equirectangular.
		/// </summary>
		// Token: 0x060106B2 RID: 67250 RVA: 0x0016E19A File Offset: 0x0016C39A
		public void SetProjectionTypeToEquirectangular()
		{
			vtkPanoramicProjectionPass.vtkPanoramicProjectionPass_SetProjectionTypeToEquirectangular_24(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400130B RID: 4875
		public new const string MRFullTypeName = "Kitware.VTK.vtkPanoramicProjectionPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400130C RID: 4876
		public new static readonly string MRClassNameKey = "class vtkPanoramicProjectionPass";

		/// <summary>
		/// Enumeration of projection types.
		/// </summary>
		// Token: 0x020005E1 RID: 1505
		public enum Azimuthal_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400130E RID: 4878
			Azimuthal = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400130F RID: 4879
			Equirectangular = 1
		}
	}
}
