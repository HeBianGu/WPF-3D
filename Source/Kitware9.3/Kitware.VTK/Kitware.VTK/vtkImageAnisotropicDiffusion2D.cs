using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageAnisotropicDiffusion2D
	/// </summary>
	/// <remarks>
	///    edge preserving smoothing.
	///
	///
	/// vtkImageAnisotropicDiffusion2D diffuses a 2d image iteratively.
	/// The neighborhood of the diffusion is determined by the instance
	/// flags. If "Edges" is on the 4 edge connected voxels
	/// are included, and if "Corners" is on, the 4 corner connected voxels
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
	/// vtkImageAnisotropicDiffusion3D
	/// </seealso>
	// Token: 0x0200047D RID: 1149
	public class vtkImageAnisotropicDiffusion2D : vtkImageSpatialAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D387 RID: 54151 RVA: 0x001267E3 File Offset: 0x001249E3
		static vtkImageAnisotropicDiffusion2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageAnisotropicDiffusion2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAnisotropicDiffusion2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D388 RID: 54152 RVA: 0x0012680B File Offset: 0x00124A0B
		public vtkImageAnisotropicDiffusion2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D389 RID: 54153
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAnisotropicDiffusion2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D38A RID: 54154 RVA: 0x0012681C File Offset: 0x00124A1C
		public new static vtkImageAnisotropicDiffusion2D New()
		{
			vtkImageAnisotropicDiffusion2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAnisotropicDiffusion2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D38B RID: 54155 RVA: 0x00126870 File Offset: 0x00124A70
		public vtkImageAnisotropicDiffusion2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D38C RID: 54156 RVA: 0x001268B4 File Offset: 0x00124AB4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D38D RID: 54157
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_CornersOff_01(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D38E RID: 54158 RVA: 0x001268BF File Offset: 0x00124ABF
		public virtual void CornersOff()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_CornersOff_01(base.GetCppThis());
		}

		// Token: 0x0600D38F RID: 54159
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_CornersOn_02(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D390 RID: 54160 RVA: 0x001268CE File Offset: 0x00124ACE
		public virtual void CornersOn()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_CornersOn_02(base.GetCppThis());
		}

		// Token: 0x0600D391 RID: 54161
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_EdgesOff_03(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D392 RID: 54162 RVA: 0x001268DD File Offset: 0x00124ADD
		public virtual void EdgesOff()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_EdgesOff_03(base.GetCppThis());
		}

		// Token: 0x0600D393 RID: 54163
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_EdgesOn_04(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D394 RID: 54164 RVA: 0x001268EC File Offset: 0x00124AEC
		public virtual void EdgesOn()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_EdgesOn_04(base.GetCppThis());
		}

		// Token: 0x0600D395 RID: 54165
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_FacesOff_05(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D396 RID: 54166 RVA: 0x001268FB File Offset: 0x00124AFB
		public virtual void FacesOff()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_FacesOff_05(base.GetCppThis());
		}

		// Token: 0x0600D397 RID: 54167
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_FacesOn_06(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D398 RID: 54168 RVA: 0x0012690A File Offset: 0x00124B0A
		public virtual void FacesOn()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_FacesOn_06(base.GetCppThis());
		}

		// Token: 0x0600D399 RID: 54169
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion2D_GetCorners_07(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D39A RID: 54170 RVA: 0x0012691C File Offset: 0x00124B1C
		public virtual int GetCorners()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetCorners_07(base.GetCppThis());
		}

		// Token: 0x0600D39B RID: 54171
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageAnisotropicDiffusion2D_GetDiffusionFactor_08(HandleRef pThis);

		/// <summary>
		/// The diffusion factor specifies how much neighboring pixels effect each other.
		/// No diffusion occurs with a factor of 0, and a diffusion factor of 1 causes
		/// the pixel to become the average of all its neighbors.
		/// </summary>
		// Token: 0x0600D39C RID: 54172 RVA: 0x0012693C File Offset: 0x00124B3C
		public virtual double GetDiffusionFactor()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetDiffusionFactor_08(base.GetCppThis());
		}

		// Token: 0x0600D39D RID: 54173
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageAnisotropicDiffusion2D_GetDiffusionThreshold_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the difference threshold that stops diffusion.
		/// when the difference between two pixel is greater than this threshold,
		/// the pixels are not diffused.  This causes diffusion to avoid sharp edges.
		/// If the GradientMagnitudeThreshold is set, then gradient magnitude is used
		/// for comparison instead of pixel differences.
		/// </summary>
		// Token: 0x0600D39E RID: 54174 RVA: 0x0012695C File Offset: 0x00124B5C
		public virtual double GetDiffusionThreshold()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetDiffusionThreshold_09(base.GetCppThis());
		}

		// Token: 0x0600D39F RID: 54175
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion2D_GetEdges_10(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3A0 RID: 54176 RVA: 0x0012697C File Offset: 0x00124B7C
		public virtual int GetEdges()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetEdges_10(base.GetCppThis());
		}

		// Token: 0x0600D3A1 RID: 54177
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion2D_GetFaces_11(HandleRef pThis);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3A2 RID: 54178 RVA: 0x0012699C File Offset: 0x00124B9C
		public virtual int GetFaces()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetFaces_11(base.GetCppThis());
		}

		// Token: 0x0600D3A3 RID: 54179
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion2D_GetGradientMagnitudeThreshold_12(HandleRef pThis);

		/// <summary>
		/// Switch between gradient magnitude threshold and pixel gradient threshold.
		/// </summary>
		// Token: 0x0600D3A4 RID: 54180 RVA: 0x001269BC File Offset: 0x00124BBC
		public virtual int GetGradientMagnitudeThreshold()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetGradientMagnitudeThreshold_12(base.GetCppThis());
		}

		// Token: 0x0600D3A5 RID: 54181
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAnisotropicDiffusion2D_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3A6 RID: 54182 RVA: 0x001269DC File Offset: 0x00124BDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0600D3A7 RID: 54183
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAnisotropicDiffusion2D_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3A8 RID: 54184 RVA: 0x001269FC File Offset: 0x00124BFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0600D3A9 RID: 54185
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion2D_GetNumberOfIterations_15(HandleRef pThis);

		/// <summary>
		/// Get the number of iterations.
		/// </summary>
		// Token: 0x0600D3AA RID: 54186 RVA: 0x00126A18 File Offset: 0x00124C18
		public virtual int GetNumberOfIterations()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetNumberOfIterations_15(base.GetCppThis());
		}

		// Token: 0x0600D3AB RID: 54187
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_GradientMagnitudeThresholdOff_16(HandleRef pThis);

		/// <summary>
		/// Switch between gradient magnitude threshold and pixel gradient threshold.
		/// </summary>
		// Token: 0x0600D3AC RID: 54188 RVA: 0x00126A37 File Offset: 0x00124C37
		public virtual void GradientMagnitudeThresholdOff()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GradientMagnitudeThresholdOff_16(base.GetCppThis());
		}

		// Token: 0x0600D3AD RID: 54189
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_GradientMagnitudeThresholdOn_17(HandleRef pThis);

		/// <summary>
		/// Switch between gradient magnitude threshold and pixel gradient threshold.
		/// </summary>
		// Token: 0x0600D3AE RID: 54190 RVA: 0x00126A46 File Offset: 0x00124C46
		public virtual void GradientMagnitudeThresholdOn()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GradientMagnitudeThresholdOn_17(base.GetCppThis());
		}

		// Token: 0x0600D3AF RID: 54191
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion2D_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3B0 RID: 54192 RVA: 0x00126A58 File Offset: 0x00124C58
		public override int IsA(string type)
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600D3B1 RID: 54193
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAnisotropicDiffusion2D_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3B2 RID: 54194 RVA: 0x00126A78 File Offset: 0x00124C78
		public new static int IsTypeOf(string type)
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_IsTypeOf_19(type);
		}

		// Token: 0x0600D3B3 RID: 54195
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAnisotropicDiffusion2D_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3B4 RID: 54196 RVA: 0x00126A94 File Offset: 0x00124C94
		public new vtkImageAnisotropicDiffusion2D NewInstance()
		{
			vtkImageAnisotropicDiffusion2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAnisotropicDiffusion2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D3B5 RID: 54197
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAnisotropicDiffusion2D_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D3B6 RID: 54198 RVA: 0x00126AF0 File Offset: 0x00124CF0
		public new static vtkImageAnisotropicDiffusion2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageAnisotropicDiffusion2D vtkImageAnisotropicDiffusion2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageAnisotropicDiffusion2D = (vtkImageAnisotropicDiffusion2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageAnisotropicDiffusion2D.Register(null);
				}
			}
			return vtkImageAnisotropicDiffusion2D;
		}

		// Token: 0x0600D3B7 RID: 54199
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetCorners_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3B8 RID: 54200 RVA: 0x00126B6F File Offset: 0x00124D6F
		public virtual void SetCorners(int _arg)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetCorners_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D3B9 RID: 54201
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetDiffusionFactor_24(HandleRef pThis, double _arg);

		/// <summary>
		/// The diffusion factor specifies how much neighboring pixels effect each other.
		/// No diffusion occurs with a factor of 0, and a diffusion factor of 1 causes
		/// the pixel to become the average of all its neighbors.
		/// </summary>
		// Token: 0x0600D3BA RID: 54202 RVA: 0x00126B7F File Offset: 0x00124D7F
		public virtual void SetDiffusionFactor(double _arg)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetDiffusionFactor_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D3BB RID: 54203
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetDiffusionThreshold_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the difference threshold that stops diffusion.
		/// when the difference between two pixel is greater than this threshold,
		/// the pixels are not diffused.  This causes diffusion to avoid sharp edges.
		/// If the GradientMagnitudeThreshold is set, then gradient magnitude is used
		/// for comparison instead of pixel differences.
		/// </summary>
		// Token: 0x0600D3BC RID: 54204 RVA: 0x00126B8F File Offset: 0x00124D8F
		public virtual void SetDiffusionThreshold(double _arg)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetDiffusionThreshold_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D3BD RID: 54205
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetEdges_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3BE RID: 54206 RVA: 0x00126B9F File Offset: 0x00124D9F
		public virtual void SetEdges(int _arg)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetEdges_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D3BF RID: 54207
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetFaces_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
		/// </summary>
		// Token: 0x0600D3C0 RID: 54208 RVA: 0x00126BAF File Offset: 0x00124DAF
		public virtual void SetFaces(int _arg)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetFaces_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D3C1 RID: 54209
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetGradientMagnitudeThreshold_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Switch between gradient magnitude threshold and pixel gradient threshold.
		/// </summary>
		// Token: 0x0600D3C2 RID: 54210 RVA: 0x00126BBF File Offset: 0x00124DBF
		public virtual void SetGradientMagnitudeThreshold(int _arg)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetGradientMagnitudeThreshold_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D3C3 RID: 54211
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetNumberOfIterations_29(HandleRef pThis, int num);

		/// <summary>
		/// This method sets the number of iterations which also affects the
		/// input neighborhood needed to compute one output pixel.  Each iteration
		/// requires an extra pixel layer on the neighborhood.  This is only relevant
		/// when you are trying to stream or are requesting a sub extent of the "wholeExtent".
		/// </summary>
		// Token: 0x0600D3C4 RID: 54212 RVA: 0x00126BCF File Offset: 0x00124DCF
		public void SetNumberOfIterations(int num)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetNumberOfIterations_29(base.GetCppThis(), num);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FA2 RID: 4002
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageAnisotropicDiffusion2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FA3 RID: 4003
		public new static readonly string MRClassNameKey = "class vtkImageAnisotropicDiffusion2D";
	}
}
