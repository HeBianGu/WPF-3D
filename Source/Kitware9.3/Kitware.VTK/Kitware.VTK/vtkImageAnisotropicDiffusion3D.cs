using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageAnisotropicDiffusion3D
	/// </summary>
	/// <remarks>
	///    edge preserving smoothing.
	///
	///
	/// vtkImageAnisotropicDiffusion3D diffuses an volume iteratively.
	/// The neighborhood of the diffusion is determined by the instance
	/// flags. if "Faces" is on, the 6 voxels adjoined by faces are included
	/// in the neighborhood.  If "Edges" is on the 12 edge connected voxels
	/// are included, and if "Corners" is on, the 8 corner connected voxels
	/// are included.  "DiffusionFactor" determines how far a pixel value
	/// moves toward its neighbors, and is insensitive to the number of
	/// neighbors chosen.  The diffusion is anisotropic because it only occurs
	/// when a gradient measure is below "GradientThreshold".  Two gradient measures
	/// exist and are toggled by the "GradientMagnitudeThreshold" flag.
	/// When "GradientMagnitudeThreshold" is on, the magnitude of the gradient,
	/// computed by central differences, above "DiffusionThreshold"
	/// a voxel is not modified.  The alternative measure examines each
	/// neighbor independently.  The gradient between the voxel and the neighbor
	/// must be below the "DiffusionThreshold" for diffusion to occur with
	/// THAT neighbor.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageAnisotropicDiffusion2D
	/// </seealso>
	// Token: 0x0200047E RID: 1150
	public class vtkImageAnisotropicDiffusion3D : vtkImageSpatialAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D3C5 RID: 54213 RVA: 0x00126BDF File Offset: 0x00124DDF
		static vtkImageAnisotropicDiffusion3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageAnisotropicDiffusion3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAnisotropicDiffusion3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D3C6 RID: 54214 RVA: 0x00126C07 File Offset: 0x00124E07
		public vtkImageAnisotropicDiffusion3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D3C7 RID: 54215
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAnisotropicDiffusion3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3C8 RID: 54216 RVA: 0x00126C18 File Offset: 0x00124E18
		public new static vtkImageAnisotropicDiffusion3D New()
		{
			vtkImageAnisotropicDiffusion3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAnisotropicDiffusion3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3C9 RID: 54217 RVA: 0x00126C6C File Offset: 0x00124E6C
		public vtkImageAnisotropicDiffusion3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D3CA RID: 54218 RVA: 0x00126CB0 File Offset: 0x00124EB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D3CB RID: 54219
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_CornersOff_01(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3CC RID: 54220 RVA: 0x00126CBB File Offset: 0x00124EBB
		public virtual void CornersOff()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_CornersOff_01(base.GetCppThis());
		}

		// Token: 0x0600D3CD RID: 54221
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_CornersOn_02(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3CE RID: 54222 RVA: 0x00126CCA File Offset: 0x00124ECA
		public virtual void CornersOn()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_CornersOn_02(base.GetCppThis());
		}

		// Token: 0x0600D3CF RID: 54223
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_EdgesOff_03(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3D0 RID: 54224 RVA: 0x00126CD9 File Offset: 0x00124ED9
		public virtual void EdgesOff()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_EdgesOff_03(base.GetCppThis());
		}

		// Token: 0x0600D3D1 RID: 54225
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_EdgesOn_04(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3D2 RID: 54226 RVA: 0x00126CE8 File Offset: 0x00124EE8
		public virtual void EdgesOn()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_EdgesOn_04(base.GetCppThis());
		}

		// Token: 0x0600D3D3 RID: 54227
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_FacesOff_05(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3D4 RID: 54228 RVA: 0x00126CF7 File Offset: 0x00124EF7
		public virtual void FacesOff()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_FacesOff_05(base.GetCppThis());
		}

		// Token: 0x0600D3D5 RID: 54229
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_FacesOn_06(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3D6 RID: 54230 RVA: 0x00126D06 File Offset: 0x00124F06
		public virtual void FacesOn()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_FacesOn_06(base.GetCppThis());
		}

		// Token: 0x0600D3D7 RID: 54231
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion3D_GetCorners_07(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3D8 RID: 54232 RVA: 0x00126D18 File Offset: 0x00124F18
		public virtual int GetCorners()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetCorners_07(base.GetCppThis());
		}

		// Token: 0x0600D3D9 RID: 54233
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageAnisotropicDiffusion3D_GetDiffusionFactor_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the difference factor
		/// </summary>
		// Token: 0x0600D3DA RID: 54234 RVA: 0x00126D38 File Offset: 0x00124F38
		public virtual double GetDiffusionFactor()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetDiffusionFactor_08(base.GetCppThis());
		}

		// Token: 0x0600D3DB RID: 54235
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageAnisotropicDiffusion3D_GetDiffusionThreshold_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the difference threshold that stops diffusion.
		/// when the difference between two pixel is greater than this threshold,
		/// the pixels are not diffused.  This causes diffusion to avoid sharp edges.
		/// If the GradientMagnitudeThreshold is set, then gradient magnitude is used
		/// for comparison instead of pixel differences.
		/// </summary>
		// Token: 0x0600D3DC RID: 54236 RVA: 0x00126D58 File Offset: 0x00124F58
		public virtual double GetDiffusionThreshold()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetDiffusionThreshold_09(base.GetCppThis());
		}

		// Token: 0x0600D3DD RID: 54237
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion3D_GetEdges_10(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3DE RID: 54238 RVA: 0x00126D78 File Offset: 0x00124F78
		public virtual int GetEdges()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetEdges_10(base.GetCppThis());
		}

		// Token: 0x0600D3DF RID: 54239
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion3D_GetFaces_11(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3E0 RID: 54240 RVA: 0x00126D98 File Offset: 0x00124F98
		public virtual int GetFaces()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetFaces_11(base.GetCppThis());
		}

		// Token: 0x0600D3E1 RID: 54241
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion3D_GetGradientMagnitudeThreshold_12(HandleRef pThis);

		/// <summary>
		/// Switch between gradient magnitude threshold and pixel gradient threshold.
		/// </summary>
		// Token: 0x0600D3E2 RID: 54242 RVA: 0x00126DB8 File Offset: 0x00124FB8
		public virtual int GetGradientMagnitudeThreshold()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetGradientMagnitudeThreshold_12(base.GetCppThis());
		}

		// Token: 0x0600D3E3 RID: 54243
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAnisotropicDiffusion3D_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3E4 RID: 54244 RVA: 0x00126DD8 File Offset: 0x00124FD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0600D3E5 RID: 54245
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAnisotropicDiffusion3D_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3E6 RID: 54246 RVA: 0x00126DF8 File Offset: 0x00124FF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0600D3E7 RID: 54247
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion3D_GetNumberOfIterations_15(HandleRef pThis);

		/// <summary>
		/// Get the number of iterations.
		/// </summary>
		// Token: 0x0600D3E8 RID: 54248 RVA: 0x00126E14 File Offset: 0x00125014
		public virtual int GetNumberOfIterations()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetNumberOfIterations_15(base.GetCppThis());
		}

		// Token: 0x0600D3E9 RID: 54249
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_GradientMagnitudeThresholdOff_16(HandleRef pThis);

		/// <summary>
		/// Switch between gradient magnitude threshold and pixel gradient threshold.
		/// </summary>
		// Token: 0x0600D3EA RID: 54250 RVA: 0x00126E33 File Offset: 0x00125033
		public virtual void GradientMagnitudeThresholdOff()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GradientMagnitudeThresholdOff_16(base.GetCppThis());
		}

		// Token: 0x0600D3EB RID: 54251
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_GradientMagnitudeThresholdOn_17(HandleRef pThis);

		/// <summary>
		/// Switch between gradient magnitude threshold and pixel gradient threshold.
		/// </summary>
		// Token: 0x0600D3EC RID: 54252 RVA: 0x00126E42 File Offset: 0x00125042
		public virtual void GradientMagnitudeThresholdOn()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GradientMagnitudeThresholdOn_17(base.GetCppThis());
		}

		// Token: 0x0600D3ED RID: 54253
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion3D_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3EE RID: 54254 RVA: 0x00126E54 File Offset: 0x00125054
		public override int IsA(string type)
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600D3EF RID: 54255
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion3D_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3F0 RID: 54256 RVA: 0x00126E74 File Offset: 0x00125074
		public new static int IsTypeOf(string type)
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_IsTypeOf_19(type);
		}

		// Token: 0x0600D3F1 RID: 54257
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAnisotropicDiffusion3D_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3F2 RID: 54258 RVA: 0x00126E90 File Offset: 0x00125090
		public new vtkImageAnisotropicDiffusion3D NewInstance()
		{
			vtkImageAnisotropicDiffusion3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAnisotropicDiffusion3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D3F3 RID: 54259
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAnisotropicDiffusion3D_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3F4 RID: 54260 RVA: 0x00126EEC File Offset: 0x001250EC
		public new static vtkImageAnisotropicDiffusion3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageAnisotropicDiffusion3D vtkImageAnisotropicDiffusion3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageAnisotropicDiffusion3D = (vtkImageAnisotropicDiffusion3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageAnisotropicDiffusion3D.Register(null);
				}
			}
			return vtkImageAnisotropicDiffusion3D;
		}

		// Token: 0x0600D3F5 RID: 54261
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetCorners_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3F6 RID: 54262 RVA: 0x00126F6B File Offset: 0x0012516B
		public virtual void SetCorners(int _arg)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetCorners_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D3F7 RID: 54263
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetDiffusionFactor_24(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the difference factor
		/// </summary>
		// Token: 0x0600D3F8 RID: 54264 RVA: 0x00126F7B File Offset: 0x0012517B
		public virtual void SetDiffusionFactor(double _arg)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetDiffusionFactor_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D3F9 RID: 54265
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetDiffusionThreshold_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the difference threshold that stops diffusion.
		/// when the difference between two pixel is greater than this threshold,
		/// the pixels are not diffused.  This causes diffusion to avoid sharp edges.
		/// If the GradientMagnitudeThreshold is set, then gradient magnitude is used
		/// for comparison instead of pixel differences.
		/// </summary>
		// Token: 0x0600D3FA RID: 54266 RVA: 0x00126F8B File Offset: 0x0012518B
		public virtual void SetDiffusionThreshold(double _arg)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetDiffusionThreshold_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D3FB RID: 54267
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetEdges_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3FC RID: 54268 RVA: 0x00126F9B File Offset: 0x0012519B
		public virtual void SetEdges(int _arg)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetEdges_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D3FD RID: 54269
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetFaces_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3FE RID: 54270 RVA: 0x00126FAB File Offset: 0x001251AB
		public virtual void SetFaces(int _arg)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetFaces_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D3FF RID: 54271
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetGradientMagnitudeThreshold_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Switch between gradient magnitude threshold and pixel gradient threshold.
		/// </summary>
		// Token: 0x0600D400 RID: 54272 RVA: 0x00126FBB File Offset: 0x001251BB
		public virtual void SetGradientMagnitudeThreshold(int _arg)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetGradientMagnitudeThreshold_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D401 RID: 54273
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetNumberOfIterations_29(HandleRef pThis, int num);

		/// <summary>
		/// This method sets the number of iterations which also affects the
		/// input neighborhood needed to compute one output pixel.  Each iterations
		/// requires an extra pixel layer on the neighborhood.  This is only relevant
		/// when you are trying to stream or are requesting a sub extent of the "wholeExtent".
		/// </summary>
		// Token: 0x0600D402 RID: 54274 RVA: 0x00126FCB File Offset: 0x001251CB
		public void SetNumberOfIterations(int num)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetNumberOfIterations_29(base.GetCppThis(), num);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FA4 RID: 4004
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageAnisotropicDiffusion3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FA5 RID: 4005
		public new static readonly string MRClassNameKey = "class vtkImageAnisotropicDiffusion3D";
	}
}
