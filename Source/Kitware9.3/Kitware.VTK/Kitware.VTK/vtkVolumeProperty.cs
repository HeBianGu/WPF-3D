using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolumeProperty
	/// </summary>
	/// <remarks>
	///    represents the common properties for rendering a volume.
	///
	/// vtkVolumeProperty is used to represent common properties associated
	/// with volume rendering. This includes properties for determining the type
	/// of interpolation to use when sampling a volume, the color of a volume,
	/// the scalar opacity of a volume, the gradient opacity of a volume, and the
	/// shading parameters of a volume.
	///
	/// Color, scalar opacity and gradient magnitude opacity transfer functions
	/// can be set as either 3 separate 1D functions or as a single 2D transfer
	/// function.
	///
	/// - 1D Transfer functions (vtkVolumeProperty::TF_1D)
	/// Color, scalar opacity and gradient magnitude opacity are defined by 1
	/// vtkColorTransferFunction and 2 vtkPiecewiseFunctions respectively.
	/// When the scalar opacity or the gradient opacity of a volume is not set,
	/// then the function is defined to be a constant value of 1.0. When a
	/// scalar and gradient opacity are both set simultaneously, then the opacity
	/// is defined to be the product of the scalar opacity and gradient opacity
	/// transfer functions. 1D transfer functions is the legacy and default behavior.
	///
	/// - 2D Transfer functions (vtkVolumeProperty::TF_2D)
	/// Color and scalar/gradient magnitude opacity are defined by a 4-component
	/// vtkImageData instance mapping scalar value vs. gradient magnitude on its
	/// x and y axis respectively. This mode is only available if a 2D TF has been
	/// explicitly set (see SetTransferFunction2D).
	///
	/// Most properties can be set per "component" for volume mappers that
	/// support multiple independent components. If you are using 2 component
	/// data as LV or 4 component data as RGBV (as specified in the mapper)
	/// only the first scalar opacity and gradient opacity transfer functions
	/// will be used (and all color functions will be ignored). Omitting the
	/// index parameter on the Set/Get methods will access index = 0.
	///
	/// </remarks>
	/// <seealso>
	///  vtkPiecewiseFunction vtkColorTransferFunction
	/// </seealso>
	// Token: 0x02000809 RID: 2057
	public class vtkVolumeProperty : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060151C0 RID: 86464 RVA: 0x001DE1EB File Offset: 0x001DC3EB
		static vtkVolumeProperty()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeProperty"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060151C1 RID: 86465 RVA: 0x001DE213 File Offset: 0x001DC413
		public vtkVolumeProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060151C2 RID: 86466
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060151C3 RID: 86467 RVA: 0x001DE224 File Offset: 0x001DC424
		public new static vtkVolumeProperty New()
		{
			vtkVolumeProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060151C4 RID: 86468 RVA: 0x001DE278 File Offset: 0x001DC478
		public vtkVolumeProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolumeProperty.vtkVolumeProperty_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060151C5 RID: 86469 RVA: 0x001DE2BC File Offset: 0x001DC4BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060151C6 RID: 86470
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_DeepCopy_01(HandleRef pThis, HandleRef p);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060151C7 RID: 86471 RVA: 0x001DE2C8 File Offset: 0x001DC4C8
		public void DeepCopy(vtkVolumeProperty p)
		{
			vtkVolumeProperty.vtkVolumeProperty_DeepCopy_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x060151C8 RID: 86472
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_DisableGradientOpacityOff_02(HandleRef pThis, int index);

		/// <summary>
		/// Enable/Disable the gradient opacity function for the given component.
		/// If set to true, any call to GetGradientOpacity() will return a default
		/// function for this component. Note that the gradient opacity function is
		/// still stored, it is not set or reset and can be retrieved using
		/// GetStoredGradientOpacity().
		/// </summary>
		// Token: 0x060151C9 RID: 86473 RVA: 0x001DE2F7 File Offset: 0x001DC4F7
		public virtual void DisableGradientOpacityOff(int index)
		{
			vtkVolumeProperty.vtkVolumeProperty_DisableGradientOpacityOff_02(base.GetCppThis(), index);
		}

		// Token: 0x060151CA RID: 86474
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_DisableGradientOpacityOff_03(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the gradient opacity function for the given component.
		/// If set to true, any call to GetGradientOpacity() will return a default
		/// function for this component. Note that the gradient opacity function is
		/// still stored, it is not set or reset and can be retrieved using
		/// GetStoredGradientOpacity().
		/// </summary>
		// Token: 0x060151CB RID: 86475 RVA: 0x001DE307 File Offset: 0x001DC507
		public virtual void DisableGradientOpacityOff()
		{
			vtkVolumeProperty.vtkVolumeProperty_DisableGradientOpacityOff_03(base.GetCppThis());
		}

		// Token: 0x060151CC RID: 86476
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_DisableGradientOpacityOn_04(HandleRef pThis, int index);

		/// <summary>
		/// Enable/Disable the gradient opacity function for the given component.
		/// If set to true, any call to GetGradientOpacity() will return a default
		/// function for this component. Note that the gradient opacity function is
		/// still stored, it is not set or reset and can be retrieved using
		/// GetStoredGradientOpacity().
		/// </summary>
		// Token: 0x060151CD RID: 86477 RVA: 0x001DE316 File Offset: 0x001DC516
		public virtual void DisableGradientOpacityOn(int index)
		{
			vtkVolumeProperty.vtkVolumeProperty_DisableGradientOpacityOn_04(base.GetCppThis(), index);
		}

		// Token: 0x060151CE RID: 86478
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_DisableGradientOpacityOn_05(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the gradient opacity function for the given component.
		/// If set to true, any call to GetGradientOpacity() will return a default
		/// function for this component. Note that the gradient opacity function is
		/// still stored, it is not set or reset and can be retrieved using
		/// GetStoredGradientOpacity().
		/// </summary>
		// Token: 0x060151CF RID: 86479 RVA: 0x001DE326 File Offset: 0x001DC526
		public virtual void DisableGradientOpacityOn()
		{
			vtkVolumeProperty.vtkVolumeProperty_DisableGradientOpacityOn_05(base.GetCppThis());
		}

		// Token: 0x060151D0 RID: 86480
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeProperty_GetAmbient_06(HandleRef pThis, int index);

		/// <summary>
		/// Set/Get the ambient lighting coefficient.
		/// </summary>
		// Token: 0x060151D1 RID: 86481 RVA: 0x001DE338 File Offset: 0x001DC538
		public double GetAmbient(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetAmbient_06(base.GetCppThis(), index);
		}

		// Token: 0x060151D2 RID: 86482
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeProperty_GetAmbient_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the ambient lighting coefficient.
		/// </summary>
		// Token: 0x060151D3 RID: 86483 RVA: 0x001DE358 File Offset: 0x001DC558
		public double GetAmbient()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetAmbient_07(base.GetCppThis());
		}

		// Token: 0x060151D4 RID: 86484
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeProperty_GetClippedVoxelIntensity_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the intensity value for voxels in the clipped space for gradient
		/// computations (for shading and gradient based opacity modulation).
		/// By default, this is set to VTK_DOUBLE_MIN.
		///
		/// \note This value is only used when UseClippedVoxelIntensity is true.
		/// \note This property is only used by the vtkGPUVolumeRayCastMapper for now.
		/// \sa SetUseClippedVoxelIntensity
		/// </summary>
		// Token: 0x060151D5 RID: 86485 RVA: 0x001DE378 File Offset: 0x001DC578
		public virtual double GetClippedVoxelIntensity()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetClippedVoxelIntensity_08(base.GetCppThis());
		}

		// Token: 0x060151D6 RID: 86486
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetColorChannels_09(HandleRef pThis, int index);

		/// <summary>
		/// Get the number of color channels in the transfer function
		/// for the given component.
		/// </summary>
		// Token: 0x060151D7 RID: 86487 RVA: 0x001DE398 File Offset: 0x001DC598
		public int GetColorChannels(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetColorChannels_09(base.GetCppThis(), index);
		}

		// Token: 0x060151D8 RID: 86488
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetColorChannels_10(HandleRef pThis);

		/// <summary>
		/// Get the number of color channels in the transfer function
		/// for the given component.
		/// </summary>
		// Token: 0x060151D9 RID: 86489 RVA: 0x001DE3B8 File Offset: 0x001DC5B8
		public int GetColorChannels()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetColorChannels_10(base.GetCppThis());
		}

		// Token: 0x060151DA RID: 86490
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeProperty_GetComponentWeight_11(HandleRef pThis, int index);

		/// <summary>
		/// Set/Get the scalar component weights.
		/// Clamped between the range of (0.0, 1.0)
		/// </summary>
		// Token: 0x060151DB RID: 86491 RVA: 0x001DE3D8 File Offset: 0x001DC5D8
		public virtual double GetComponentWeight(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetComponentWeight_11(base.GetCppThis(), index);
		}

		// Token: 0x060151DC RID: 86492
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeProperty_GetDiffuse_12(HandleRef pThis, int index);

		/// <summary>
		/// Set/Get the diffuse lighting coefficient.
		/// </summary>
		// Token: 0x060151DD RID: 86493 RVA: 0x001DE3F8 File Offset: 0x001DC5F8
		public double GetDiffuse(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetDiffuse_12(base.GetCppThis(), index);
		}

		// Token: 0x060151DE RID: 86494
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeProperty_GetDiffuse_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the diffuse lighting coefficient.
		/// </summary>
		// Token: 0x060151DF RID: 86495 RVA: 0x001DE418 File Offset: 0x001DC618
		public double GetDiffuse()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetDiffuse_13(base.GetCppThis());
		}

		// Token: 0x060151E0 RID: 86496
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetDisableGradientOpacity_14(HandleRef pThis, int index);

		/// <summary>
		/// Enable/Disable the gradient opacity function for the given component.
		/// If set to true, any call to GetGradientOpacity() will return a default
		/// function for this component. Note that the gradient opacity function is
		/// still stored, it is not set or reset and can be retrieved using
		/// GetStoredGradientOpacity().
		/// </summary>
		// Token: 0x060151E1 RID: 86497 RVA: 0x001DE438 File Offset: 0x001DC638
		public virtual int GetDisableGradientOpacity(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetDisableGradientOpacity_14(base.GetCppThis(), index);
		}

		// Token: 0x060151E2 RID: 86498
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetDisableGradientOpacity_15(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the gradient opacity function for the given component.
		/// If set to true, any call to GetGradientOpacity() will return a default
		/// function for this component. Note that the gradient opacity function is
		/// still stored, it is not set or reset and can be retrieved using
		/// GetStoredGradientOpacity().
		/// </summary>
		// Token: 0x060151E3 RID: 86499 RVA: 0x001DE458 File Offset: 0x001DC658
		public virtual int GetDisableGradientOpacity()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetDisableGradientOpacity_15(base.GetCppThis());
		}

		// Token: 0x060151E4 RID: 86500
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetGradientOpacity_16(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the gradient magnitude opacity transfer function for
		/// the given component.
		/// If no transfer function has been set for this component, a default one
		/// is created and returned.
		/// This default function is always returned if DisableGradientOpacity is On
		/// for that component.
		/// </summary>
		// Token: 0x060151E5 RID: 86501 RVA: 0x001DE478 File Offset: 0x001DC678
		public vtkPiecewiseFunction GetGradientOpacity(int index)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetGradientOpacity_16(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x060151E6 RID: 86502
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetGradientOpacity_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the gradient magnitude opacity transfer function for
		/// the given component.
		/// If no transfer function has been set for this component, a default one
		/// is created and returned.
		/// This default function is always returned if DisableGradientOpacity is On
		/// for that component.
		/// </summary>
		// Token: 0x060151E7 RID: 86503 RVA: 0x001DE4E8 File Offset: 0x001DC6E8
		public vtkPiecewiseFunction GetGradientOpacity()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetGradientOpacity_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x060151E8 RID: 86504
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetGrayTransferFunction_18(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the gray transfer function.
		/// If no transfer function has been set for this component, a default one
		/// is created and returned.
		/// </summary>
		// Token: 0x060151E9 RID: 86505 RVA: 0x001DE558 File Offset: 0x001DC758
		public vtkPiecewiseFunction GetGrayTransferFunction(int index)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetGrayTransferFunction_18(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x060151EA RID: 86506
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetGrayTransferFunction_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the gray transfer function.
		/// If no transfer function has been set for this component, a default one
		/// is created and returned.
		/// </summary>
		// Token: 0x060151EB RID: 86507 RVA: 0x001DE5C8 File Offset: 0x001DC7C8
		public vtkPiecewiseFunction GetGrayTransferFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetGrayTransferFunction_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x060151EC RID: 86508
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetIndependentComponents_20(HandleRef pThis);

		/// <summary>
		/// Does the data have independent components, or do some define color
		/// only? If IndependentComponents is On (the default) then each component
		/// will be independently passed through a lookup table to determine RGBA,
		/// shaded. Some volume Mappers can handle 1 to 4 component
		/// unsigned char or unsigned short data (see each mapper header file to
		/// determine functionality). If IndependentComponents is Off, then you
		/// must have either 2 or 4 component data. For 2 component data, the
		/// first is passed through the first color transfer function and the
		/// second component is passed through the first scalar opacity (and
		/// gradient opacity) transfer function.
		/// Normals will be generated off of the second component. When using gradient
		/// based opacity modulation, the gradients are computed off of the
		/// second component. For 4 component
		/// data, the first three will directly represent RGB (no lookup table).
		/// The fourth component will be passed through the first scalar opacity
		/// transfer function for opacity and first gradient opacity transfer function
		/// for gradient based opacity modulation. Normals will be generated from the
		/// fourth component. When using gradient based opacity modulation, the
		/// gradients are computed off of the fourth component.
		/// </summary>
		// Token: 0x060151ED RID: 86509 RVA: 0x001DE638 File Offset: 0x001DC838
		public virtual int GetIndependentComponents()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetIndependentComponents_20(base.GetCppThis());
		}

		// Token: 0x060151EE RID: 86510
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetIndependentComponentsMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Does the data have independent components, or do some define color
		/// only? If IndependentComponents is On (the default) then each component
		/// will be independently passed through a lookup table to determine RGBA,
		/// shaded. Some volume Mappers can handle 1 to 4 component
		/// unsigned char or unsigned short data (see each mapper header file to
		/// determine functionality). If IndependentComponents is Off, then you
		/// must have either 2 or 4 component data. For 2 component data, the
		/// first is passed through the first color transfer function and the
		/// second component is passed through the first scalar opacity (and
		/// gradient opacity) transfer function.
		/// Normals will be generated off of the second component. When using gradient
		/// based opacity modulation, the gradients are computed off of the
		/// second component. For 4 component
		/// data, the first three will directly represent RGB (no lookup table).
		/// The fourth component will be passed through the first scalar opacity
		/// transfer function for opacity and first gradient opacity transfer function
		/// for gradient based opacity modulation. Normals will be generated from the
		/// fourth component. When using gradient based opacity modulation, the
		/// gradients are computed off of the fourth component.
		/// </summary>
		// Token: 0x060151EF RID: 86511 RVA: 0x001DE658 File Offset: 0x001DC858
		public virtual int GetIndependentComponentsMaxValue()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetIndependentComponentsMaxValue_21(base.GetCppThis());
		}

		// Token: 0x060151F0 RID: 86512
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetIndependentComponentsMinValue_22(HandleRef pThis);

		/// <summary>
		/// Does the data have independent components, or do some define color
		/// only? If IndependentComponents is On (the default) then each component
		/// will be independently passed through a lookup table to determine RGBA,
		/// shaded. Some volume Mappers can handle 1 to 4 component
		/// unsigned char or unsigned short data (see each mapper header file to
		/// determine functionality). If IndependentComponents is Off, then you
		/// must have either 2 or 4 component data. For 2 component data, the
		/// first is passed through the first color transfer function and the
		/// second component is passed through the first scalar opacity (and
		/// gradient opacity) transfer function.
		/// Normals will be generated off of the second component. When using gradient
		/// based opacity modulation, the gradients are computed off of the
		/// second component. For 4 component
		/// data, the first three will directly represent RGB (no lookup table).
		/// The fourth component will be passed through the first scalar opacity
		/// transfer function for opacity and first gradient opacity transfer function
		/// for gradient based opacity modulation. Normals will be generated from the
		/// fourth component. When using gradient based opacity modulation, the
		/// gradients are computed off of the fourth component.
		/// </summary>
		// Token: 0x060151F1 RID: 86513 RVA: 0x001DE678 File Offset: 0x001DC878
		public virtual int GetIndependentComponentsMinValue()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetIndependentComponentsMinValue_22(base.GetCppThis());
		}

		// Token: 0x060151F2 RID: 86514
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetInterpolationType_23(HandleRef pThis);

		/// <summary>
		/// Set the interpolation type for sampling a volume. Initial value is
		/// VTK_NEAREST_INTERPOLATION.
		/// </summary>
		// Token: 0x060151F3 RID: 86515 RVA: 0x001DE698 File Offset: 0x001DC898
		public virtual int GetInterpolationType()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetInterpolationType_23(base.GetCppThis());
		}

		// Token: 0x060151F4 RID: 86516
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetInterpolationTypeAsString_24(HandleRef pThis);

		/// <summary>
		/// Set the interpolation type for sampling a volume. Initial value is
		/// VTK_NEAREST_INTERPOLATION.
		/// </summary>
		// Token: 0x060151F5 RID: 86517 RVA: 0x001DE6B8 File Offset: 0x001DC8B8
		public string GetInterpolationTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkVolumeProperty.vtkVolumeProperty_GetInterpolationTypeAsString_24(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060151F6 RID: 86518
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetInterpolationTypeMaxValue_25(HandleRef pThis);

		/// <summary>
		/// Set the interpolation type for sampling a volume. Initial value is
		/// VTK_NEAREST_INTERPOLATION.
		/// </summary>
		// Token: 0x060151F7 RID: 86519 RVA: 0x001DE6F4 File Offset: 0x001DC8F4
		public virtual int GetInterpolationTypeMaxValue()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetInterpolationTypeMaxValue_25(base.GetCppThis());
		}

		// Token: 0x060151F8 RID: 86520
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetInterpolationTypeMinValue_26(HandleRef pThis);

		/// <summary>
		/// Set the interpolation type for sampling a volume. Initial value is
		/// VTK_NEAREST_INTERPOLATION.
		/// </summary>
		// Token: 0x060151F9 RID: 86521 RVA: 0x001DE714 File Offset: 0x001DC914
		public virtual int GetInterpolationTypeMinValue()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetInterpolationTypeMinValue_26(base.GetCppThis());
		}

		// Token: 0x060151FA RID: 86522
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetIsoSurfaceValues_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get contour values for isosurface blending mode.
		/// Do not affect other blending modes.
		/// </summary>
		// Token: 0x060151FB RID: 86523 RVA: 0x001DE734 File Offset: 0x001DC934
		public vtkContourValues GetIsoSurfaceValues()
		{
			vtkContourValues vtkContourValues = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetIsoSurfaceValues_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourValues = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourValues.Register(null);
				}
			}
			return vtkContourValues;
		}

		// Token: 0x060151FC RID: 86524
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetLabelColor_28(HandleRef pThis, int label, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the color transfer function for a label in the label map.
		/// </summary>
		// Token: 0x060151FD RID: 86525 RVA: 0x001DE7A4 File Offset: 0x001DC9A4
		public vtkColorTransferFunction GetLabelColor(int label)
		{
			vtkColorTransferFunction vtkColorTransferFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetLabelColor_28(base.GetCppThis(), label, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferFunction = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferFunction.Register(null);
				}
			}
			return vtkColorTransferFunction;
		}

		// Token: 0x060151FE RID: 86526
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetLabelGradientOpacity_29(HandleRef pThis, int label, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the gradient opacity function for a label in the label map.
		/// </summary>
		// Token: 0x060151FF RID: 86527 RVA: 0x001DE814 File Offset: 0x001DCA14
		public vtkPiecewiseFunction GetLabelGradientOpacity(int label)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetLabelGradientOpacity_29(base.GetCppThis(), label, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x06015200 RID: 86528
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetLabelScalarOpacity_30(HandleRef pThis, int label, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the opacity transfer function for a label in the label map.
		/// </summary>
		// Token: 0x06015201 RID: 86529 RVA: 0x001DE884 File Offset: 0x001DCA84
		public vtkPiecewiseFunction GetLabelScalarOpacity(int label)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetLabelScalarOpacity_30(base.GetCppThis(), label, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x06015202 RID: 86530
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkVolumeProperty_GetMTime_31(HandleRef pThis);

		/// <summary>
		/// Get the modified time for this object (or the properties registered
		/// with this object).
		/// </summary>
		// Token: 0x06015203 RID: 86531 RVA: 0x001DE8F4 File Offset: 0x001DCAF4
		public override ulong GetMTime()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetMTime_31(base.GetCppThis());
		}

		// Token: 0x06015204 RID: 86532
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeProperty_GetNumberOfGenerationsFromBase_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015205 RID: 86533 RVA: 0x001DE914 File Offset: 0x001DCB14
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetNumberOfGenerationsFromBase_32(base.GetCppThis(), type);
		}

		// Token: 0x06015206 RID: 86534
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeProperty_GetNumberOfGenerationsFromBaseType_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015207 RID: 86535 RVA: 0x001DE934 File Offset: 0x001DCB34
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetNumberOfGenerationsFromBaseType_33(type);
		}

		// Token: 0x06015208 RID: 86536
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkVolumeProperty_GetNumberOfLabels_34(HandleRef pThis);

		/// <summary>
		/// Get the number of labels that are provided with transfer functions using
		/// either SetLabelColor, SetLabelScalarOpacity or SetLabelGradientOpacity.
		/// </summary>
		// Token: 0x06015209 RID: 86537 RVA: 0x001DE950 File Offset: 0x001DCB50
		public ulong GetNumberOfLabels()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetNumberOfLabels_34(base.GetCppThis());
		}

		// Token: 0x0601520A RID: 86538
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetRGBTransferFunction_35(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the RGB transfer function for the given component.
		/// If no transfer function has been set for this component, a default one
		/// is created and returned.
		/// </summary>
		// Token: 0x0601520B RID: 86539 RVA: 0x001DE970 File Offset: 0x001DCB70
		public vtkColorTransferFunction GetRGBTransferFunction(int index)
		{
			vtkColorTransferFunction vtkColorTransferFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetRGBTransferFunction_35(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferFunction = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferFunction.Register(null);
				}
			}
			return vtkColorTransferFunction;
		}

		// Token: 0x0601520C RID: 86540
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetRGBTransferFunction_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the RGB transfer function for the given component.
		/// If no transfer function has been set for this component, a default one
		/// is created and returned.
		/// </summary>
		// Token: 0x0601520D RID: 86541 RVA: 0x001DE9E0 File Offset: 0x001DCBE0
		public vtkColorTransferFunction GetRGBTransferFunction()
		{
			vtkColorTransferFunction vtkColorTransferFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetRGBTransferFunction_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferFunction = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferFunction.Register(null);
				}
			}
			return vtkColorTransferFunction;
		}

		// Token: 0x0601520E RID: 86542
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetScalarOpacity_37(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the scalar opacity transfer function for the given component.
		/// If no transfer function has been set for this component, a default one
		/// is created and returned.
		/// </summary>
		// Token: 0x0601520F RID: 86543 RVA: 0x001DEA50 File Offset: 0x001DCC50
		public vtkPiecewiseFunction GetScalarOpacity(int index)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetScalarOpacity_37(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x06015210 RID: 86544
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetScalarOpacity_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the scalar opacity transfer function for the given component.
		/// If no transfer function has been set for this component, a default one
		/// is created and returned.
		/// </summary>
		// Token: 0x06015211 RID: 86545 RVA: 0x001DEAC0 File Offset: 0x001DCCC0
		public vtkPiecewiseFunction GetScalarOpacity()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetScalarOpacity_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x06015212 RID: 86546
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeProperty_GetScalarOpacityUnitDistance_39(HandleRef pThis, int index);

		/// <summary>
		/// Set/Get the unit distance on which the scalar opacity transfer function
		/// is defined. By default this is 1.0, meaning that over a distance of
		/// 1.0 units, a given opacity (from the transfer function) is accumulated.
		/// This is adjusted for the actual sampling distance during rendering.
		/// </summary>
		// Token: 0x06015213 RID: 86547 RVA: 0x001DEB30 File Offset: 0x001DCD30
		public double GetScalarOpacityUnitDistance(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetScalarOpacityUnitDistance_39(base.GetCppThis(), index);
		}

		// Token: 0x06015214 RID: 86548
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeProperty_GetScalarOpacityUnitDistance_40(HandleRef pThis);

		/// <summary>
		/// Set/Get the unit distance on which the scalar opacity transfer function
		/// is defined. By default this is 1.0, meaning that over a distance of
		/// 1.0 units, a given opacity (from the transfer function) is accumulated.
		/// This is adjusted for the actual sampling distance during rendering.
		/// </summary>
		// Token: 0x06015215 RID: 86549 RVA: 0x001DEB50 File Offset: 0x001DCD50
		public double GetScalarOpacityUnitDistance()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetScalarOpacityUnitDistance_40(base.GetCppThis());
		}

		// Token: 0x06015216 RID: 86550
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkVolumeProperty_GetScatteringAnisotropy_41(HandleRef pThis);

		/// <summary>
		/// Get/Set the volume's scattering anisotropy.
		/// The model used is Henyey-Greenstein. The value should
		/// be between -1.0 (back-scattering) and 1.0 (forward-scattering),
		/// so the default value of 0.0 corresponds to an isotropic
		/// volume. For now, it is only used in vtkGPUVolumeRayCastMapper.
		/// </summary>
		// Token: 0x06015217 RID: 86551 RVA: 0x001DEB70 File Offset: 0x001DCD70
		public virtual float GetScatteringAnisotropy()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetScatteringAnisotropy_41(base.GetCppThis());
		}

		// Token: 0x06015218 RID: 86552
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkVolumeProperty_GetScatteringAnisotropyMaxValue_42(HandleRef pThis);

		/// <summary>
		/// Get/Set the volume's scattering anisotropy.
		/// The model used is Henyey-Greenstein. The value should
		/// be between -1.0 (back-scattering) and 1.0 (forward-scattering),
		/// so the default value of 0.0 corresponds to an isotropic
		/// volume. For now, it is only used in vtkGPUVolumeRayCastMapper.
		/// </summary>
		// Token: 0x06015219 RID: 86553 RVA: 0x001DEB90 File Offset: 0x001DCD90
		public virtual float GetScatteringAnisotropyMaxValue()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetScatteringAnisotropyMaxValue_42(base.GetCppThis());
		}

		// Token: 0x0601521A RID: 86554
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkVolumeProperty_GetScatteringAnisotropyMinValue_43(HandleRef pThis);

		/// <summary>
		/// Get/Set the volume's scattering anisotropy.
		/// The model used is Henyey-Greenstein. The value should
		/// be between -1.0 (back-scattering) and 1.0 (forward-scattering),
		/// so the default value of 0.0 corresponds to an isotropic
		/// volume. For now, it is only used in vtkGPUVolumeRayCastMapper.
		/// </summary>
		// Token: 0x0601521B RID: 86555 RVA: 0x001DEBB0 File Offset: 0x001DCDB0
		public virtual float GetScatteringAnisotropyMinValue()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetScatteringAnisotropyMinValue_43(base.GetCppThis());
		}

		// Token: 0x0601521C RID: 86556
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetShade_44(HandleRef pThis, int index);

		/// <summary>
		/// Set/Get the shading of a volume. If shading is turned off, then
		/// the mapper for the volume will not perform shading calculations.
		/// If shading is turned on, the mapper may perform shading
		/// calculations - in some cases shading does not apply (for example,
		/// in a maximum intensity projection) and therefore shading will
		/// not be performed even if this flag is on. For a compositing type
		/// of mapper, turning shading off is generally the same as setting
		/// ambient=1, diffuse=0, specular=0. Shading can be independently
		/// turned on/off per component.
		///
		/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
		/// For minimum and maximum intensity blend modes, there is not necessarily one
		/// unique location along the ray through the volume where that minimum or
		/// maximum occurs. For average and additive blend modes, the value being
		/// visualized does not represent a location in the volume but rather a
		/// statistical measurement along the ray traversing through the volume, and
		/// hence shading is not applicable.
		/// \sa vtkVolumeMapper::BlendModes
		/// </summary>
		// Token: 0x0601521D RID: 86557 RVA: 0x001DEBD0 File Offset: 0x001DCDD0
		public int GetShade(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetShade_44(base.GetCppThis(), index);
		}

		// Token: 0x0601521E RID: 86558
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetShade_45(HandleRef pThis);

		/// <summary>
		/// Set/Get the shading of a volume. If shading is turned off, then
		/// the mapper for the volume will not perform shading calculations.
		/// If shading is turned on, the mapper may perform shading
		/// calculations - in some cases shading does not apply (for example,
		/// in a maximum intensity projection) and therefore shading will
		/// not be performed even if this flag is on. For a compositing type
		/// of mapper, turning shading off is generally the same as setting
		/// ambient=1, diffuse=0, specular=0. Shading can be independently
		/// turned on/off per component.
		///
		/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
		/// For minimum and maximum intensity blend modes, there is not necessarily one
		/// unique location along the ray through the volume where that minimum or
		/// maximum occurs. For average and additive blend modes, the value being
		/// visualized does not represent a location in the volume but rather a
		/// statistical measurement along the ray traversing through the volume, and
		/// hence shading is not applicable.
		/// \sa vtkVolumeMapper::BlendModes
		/// </summary>
		// Token: 0x0601521F RID: 86559 RVA: 0x001DEBF0 File Offset: 0x001DCDF0
		public int GetShade()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetShade_45(base.GetCppThis());
		}

		// Token: 0x06015220 RID: 86560
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetSliceFunction_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the function used for slicing.
		/// Currently, only vtkPlane is supported.
		/// </summary>
		// Token: 0x06015221 RID: 86561 RVA: 0x001DEC10 File Offset: 0x001DCE10
		public virtual vtkImplicitFunction GetSliceFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetSliceFunction_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x06015222 RID: 86562
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeProperty_GetSpecular_47(HandleRef pThis, int index);

		/// <summary>
		/// Set/Get the specular lighting coefficient.
		/// </summary>
		// Token: 0x06015223 RID: 86563 RVA: 0x001DEC80 File Offset: 0x001DCE80
		public double GetSpecular(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetSpecular_47(base.GetCppThis(), index);
		}

		// Token: 0x06015224 RID: 86564
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeProperty_GetSpecular_48(HandleRef pThis);

		/// <summary>
		/// Set/Get the specular lighting coefficient.
		/// </summary>
		// Token: 0x06015225 RID: 86565 RVA: 0x001DECA0 File Offset: 0x001DCEA0
		public double GetSpecular()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetSpecular_48(base.GetCppThis());
		}

		// Token: 0x06015226 RID: 86566
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeProperty_GetSpecularPower_49(HandleRef pThis, int index);

		/// <summary>
		/// Set/Get the specular power.
		/// </summary>
		// Token: 0x06015227 RID: 86567 RVA: 0x001DECC0 File Offset: 0x001DCEC0
		public double GetSpecularPower(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetSpecularPower_49(base.GetCppThis(), index);
		}

		// Token: 0x06015228 RID: 86568
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeProperty_GetSpecularPower_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the specular power.
		/// </summary>
		// Token: 0x06015229 RID: 86569 RVA: 0x001DECE0 File Offset: 0x001DCEE0
		public double GetSpecularPower()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetSpecularPower_50(base.GetCppThis());
		}

		// Token: 0x0601522A RID: 86570
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetStoredGradientOpacity_51(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Enable/Disable the gradient opacity function for the given component.
		/// If set to true, any call to GetGradientOpacity() will return a default
		/// function for this component. Note that the gradient opacity function is
		/// still stored, it is not set or reset and can be retrieved using
		/// GetStoredGradientOpacity().
		/// </summary>
		// Token: 0x0601522B RID: 86571 RVA: 0x001DED00 File Offset: 0x001DCF00
		public vtkPiecewiseFunction GetStoredGradientOpacity(int index)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetStoredGradientOpacity_51(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x0601522C RID: 86572
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetStoredGradientOpacity_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Enable/Disable the gradient opacity function for the given component.
		/// If set to true, any call to GetGradientOpacity() will return a default
		/// function for this component. Note that the gradient opacity function is
		/// still stored, it is not set or reset and can be retrieved using
		/// GetStoredGradientOpacity().
		/// </summary>
		// Token: 0x0601522D RID: 86573 RVA: 0x001DED70 File Offset: 0x001DCF70
		public vtkPiecewiseFunction GetStoredGradientOpacity()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetStoredGradientOpacity_52(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x0601522E RID: 86574
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetTransferFunction2D_53(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a 2D transfer function. Volume mappers interpret the x-axis of
		/// of this transfer function as scalar value and the y-axis as gradient
		/// magnitude. The value at (X, Y) corresponds to the color and opacity
		/// for a salar value of X and a gradient magnitude of Y.
		/// </summary>
		// Token: 0x0601522F RID: 86575 RVA: 0x001DEDE0 File Offset: 0x001DCFE0
		public vtkImageData GetTransferFunction2D(int index)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetTransferFunction2D_53(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06015230 RID: 86576
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_GetTransferFunction2D_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a 2D transfer function. Volume mappers interpret the x-axis of
		/// of this transfer function as scalar value and the y-axis as gradient
		/// magnitude. The value at (X, Y) corresponds to the color and opacity
		/// for a salar value of X and a gradient magnitude of Y.
		/// </summary>
		// Token: 0x06015231 RID: 86577 RVA: 0x001DEE50 File Offset: 0x001DD050
		public vtkImageData GetTransferFunction2D()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetTransferFunction2D_54(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06015232 RID: 86578
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetTransferFunctionMode_55(HandleRef pThis);

		/// <summary>
		/// Color-opacity transfer function mode. TF_1D is its default value.
		///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
		///  and gradient mag. opacity.
		///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
		///  opacity.
		/// </summary>
		// Token: 0x06015233 RID: 86579 RVA: 0x001DEEC0 File Offset: 0x001DD0C0
		public virtual int GetTransferFunctionMode()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetTransferFunctionMode_55(base.GetCppThis());
		}

		// Token: 0x06015234 RID: 86580
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetTransferFunctionModeMaxValue_56(HandleRef pThis);

		/// <summary>
		/// Color-opacity transfer function mode. TF_1D is its default value.
		///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
		///  and gradient mag. opacity.
		///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
		///  opacity.
		/// </summary>
		// Token: 0x06015235 RID: 86581 RVA: 0x001DEEE0 File Offset: 0x001DD0E0
		public virtual int GetTransferFunctionModeMaxValue()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetTransferFunctionModeMaxValue_56(base.GetCppThis());
		}

		// Token: 0x06015236 RID: 86582
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetTransferFunctionModeMinValue_57(HandleRef pThis);

		/// <summary>
		/// Color-opacity transfer function mode. TF_1D is its default value.
		///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
		///  and gradient mag. opacity.
		///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
		///  opacity.
		/// </summary>
		// Token: 0x06015237 RID: 86583 RVA: 0x001DEF00 File Offset: 0x001DD100
		public virtual int GetTransferFunctionModeMinValue()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetTransferFunctionModeMinValue_57(base.GetCppThis());
		}

		// Token: 0x06015238 RID: 86584
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_GetUseClippedVoxelIntensity_58(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to use a fixed intensity value for voxels in the clipped
		/// space for gradient calculations. When UseClippedVoxelIntensity is
		/// enabled, the ClippedVoxelIntensity value will be used as intensity of
		/// clipped voxels. By default, this is false.
		///
		/// \note This property is only used by the vtkGPUVolumeRayCastMapper for now.
		/// \sa SetClippedVoxelIntensity
		/// </summary>
		// Token: 0x06015239 RID: 86585 RVA: 0x001DEF20 File Offset: 0x001DD120
		public virtual int GetUseClippedVoxelIntensity()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetUseClippedVoxelIntensity_58(base.GetCppThis());
		}

		// Token: 0x0601523A RID: 86586
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVolumeProperty_HasGradientOpacity_59(HandleRef pThis, int index);

		/// <summary>
		/// Check whether or not we have the gradient opacity. Checking
		/// gradient opacity via GetDisableGradientOpacity or GetGradientOpacity
		/// will not work as in the former case,  GetDisableGradientOpacity returns
		/// false by default and in the later case, a default gradient opacity will be created.
		/// </summary>
		// Token: 0x0601523B RID: 86587 RVA: 0x001DEF40 File Offset: 0x001DD140
		public bool HasGradientOpacity(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_HasGradientOpacity_59(base.GetCppThis(), index) != 0;
		}

		// Token: 0x0601523C RID: 86588
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVolumeProperty_HasLabelGradientOpacity_60(HandleRef pThis);

		/// <summary>
		/// Check whether or not we have the gradient opacity. Checking
		/// gradient opacity via GetDisableGradientOpacity or GetGradientOpacity
		/// will not work as in the former case,  GetDisableGradientOpacity returns
		/// false by default and in the later case, a default gradient opacity will be created.
		/// </summary>
		// Token: 0x0601523D RID: 86589 RVA: 0x001DEF68 File Offset: 0x001DD168
		public bool HasLabelGradientOpacity()
		{
			return vtkVolumeProperty.vtkVolumeProperty_HasLabelGradientOpacity_60(base.GetCppThis()) != 0;
		}

		// Token: 0x0601523E RID: 86590
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_IndependentComponentsOff_61(HandleRef pThis);

		/// <summary>
		/// Does the data have independent components, or do some define color
		/// only? If IndependentComponents is On (the default) then each component
		/// will be independently passed through a lookup table to determine RGBA,
		/// shaded. Some volume Mappers can handle 1 to 4 component
		/// unsigned char or unsigned short data (see each mapper header file to
		/// determine functionality). If IndependentComponents is Off, then you
		/// must have either 2 or 4 component data. For 2 component data, the
		/// first is passed through the first color transfer function and the
		/// second component is passed through the first scalar opacity (and
		/// gradient opacity) transfer function.
		/// Normals will be generated off of the second component. When using gradient
		/// based opacity modulation, the gradients are computed off of the
		/// second component. For 4 component
		/// data, the first three will directly represent RGB (no lookup table).
		/// The fourth component will be passed through the first scalar opacity
		/// transfer function for opacity and first gradient opacity transfer function
		/// for gradient based opacity modulation. Normals will be generated from the
		/// fourth component. When using gradient based opacity modulation, the
		/// gradients are computed off of the fourth component.
		/// </summary>
		// Token: 0x0601523F RID: 86591 RVA: 0x001DEF8E File Offset: 0x001DD18E
		public virtual void IndependentComponentsOff()
		{
			vtkVolumeProperty.vtkVolumeProperty_IndependentComponentsOff_61(base.GetCppThis());
		}

		// Token: 0x06015240 RID: 86592
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_IndependentComponentsOn_62(HandleRef pThis);

		/// <summary>
		/// Does the data have independent components, or do some define color
		/// only? If IndependentComponents is On (the default) then each component
		/// will be independently passed through a lookup table to determine RGBA,
		/// shaded. Some volume Mappers can handle 1 to 4 component
		/// unsigned char or unsigned short data (see each mapper header file to
		/// determine functionality). If IndependentComponents is Off, then you
		/// must have either 2 or 4 component data. For 2 component data, the
		/// first is passed through the first color transfer function and the
		/// second component is passed through the first scalar opacity (and
		/// gradient opacity) transfer function.
		/// Normals will be generated off of the second component. When using gradient
		/// based opacity modulation, the gradients are computed off of the
		/// second component. For 4 component
		/// data, the first three will directly represent RGB (no lookup table).
		/// The fourth component will be passed through the first scalar opacity
		/// transfer function for opacity and first gradient opacity transfer function
		/// for gradient based opacity modulation. Normals will be generated from the
		/// fourth component. When using gradient based opacity modulation, the
		/// gradients are computed off of the fourth component.
		/// </summary>
		// Token: 0x06015241 RID: 86593 RVA: 0x001DEF9D File Offset: 0x001DD19D
		public virtual void IndependentComponentsOn()
		{
			vtkVolumeProperty.vtkVolumeProperty_IndependentComponentsOn_62(base.GetCppThis());
		}

		// Token: 0x06015242 RID: 86594
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_IsA_63(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015243 RID: 86595 RVA: 0x001DEFAC File Offset: 0x001DD1AC
		public override int IsA(string type)
		{
			return vtkVolumeProperty.vtkVolumeProperty_IsA_63(base.GetCppThis(), type);
		}

		// Token: 0x06015244 RID: 86596
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeProperty_IsTypeOf_64([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015245 RID: 86597 RVA: 0x001DEFCC File Offset: 0x001DD1CC
		public new static int IsTypeOf(string type)
		{
			return vtkVolumeProperty.vtkVolumeProperty_IsTypeOf_64(type);
		}

		// Token: 0x06015246 RID: 86598
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_NewInstance_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015247 RID: 86599 RVA: 0x001DEFE8 File Offset: 0x001DD1E8
		public new vtkVolumeProperty NewInstance()
		{
			vtkVolumeProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_NewInstance_66(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015248 RID: 86600
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeProperty_SafeDownCast_67(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015249 RID: 86601 RVA: 0x001DF044 File Offset: 0x001DD244
		public new static vtkVolumeProperty SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeProperty vtkVolumeProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_SafeDownCast_67((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeProperty = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeProperty.Register(null);
				}
			}
			return vtkVolumeProperty;
		}

		// Token: 0x0601524A RID: 86602
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetAmbient_68(HandleRef pThis, int index, double value);

		/// <summary>
		/// Set/Get the ambient lighting coefficient.
		/// </summary>
		// Token: 0x0601524B RID: 86603 RVA: 0x001DF0C3 File Offset: 0x001DD2C3
		public void SetAmbient(int index, double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetAmbient_68(base.GetCppThis(), index, value);
		}

		// Token: 0x0601524C RID: 86604
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetAmbient_69(HandleRef pThis, double value);

		/// <summary>
		/// Set/Get the ambient lighting coefficient.
		/// </summary>
		// Token: 0x0601524D RID: 86605 RVA: 0x001DF0D4 File Offset: 0x001DD2D4
		public void SetAmbient(double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetAmbient_69(base.GetCppThis(), value);
		}

		// Token: 0x0601524E RID: 86606
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetClippedVoxelIntensity_70(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the intensity value for voxels in the clipped space for gradient
		/// computations (for shading and gradient based opacity modulation).
		/// By default, this is set to VTK_DOUBLE_MIN.
		///
		/// \note This value is only used when UseClippedVoxelIntensity is true.
		/// \note This property is only used by the vtkGPUVolumeRayCastMapper for now.
		/// \sa SetUseClippedVoxelIntensity
		/// </summary>
		// Token: 0x0601524F RID: 86607 RVA: 0x001DF0E4 File Offset: 0x001DD2E4
		public virtual void SetClippedVoxelIntensity(double _arg)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetClippedVoxelIntensity_70(base.GetCppThis(), _arg);
		}

		// Token: 0x06015250 RID: 86608
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetColor_71(HandleRef pThis, int index, HandleRef function);

		/// <summary>
		/// Set the color of a volume to a gray level transfer function
		/// for the component indicated by index. This will set the
		/// color channels for this component to 1.
		/// </summary>
		// Token: 0x06015251 RID: 86609 RVA: 0x001DF0F4 File Offset: 0x001DD2F4
		public void SetColor(int index, vtkPiecewiseFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetColor_71(base.GetCppThis(), index, (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06015252 RID: 86610
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetColor_72(HandleRef pThis, HandleRef function);

		/// <summary>
		/// Set the color of a volume to a gray level transfer function
		/// for the component indicated by index. This will set the
		/// color channels for this component to 1.
		/// </summary>
		// Token: 0x06015253 RID: 86611 RVA: 0x001DF124 File Offset: 0x001DD324
		public void SetColor(vtkPiecewiseFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetColor_72(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06015254 RID: 86612
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetColor_73(HandleRef pThis, int index, HandleRef function);

		/// <summary>
		/// Set the color of a volume to an RGB transfer function
		/// for the component indicated by index. This will set the
		/// color channels for this component to 3.
		/// This will also recompute the color channels
		/// </summary>
		// Token: 0x06015255 RID: 86613 RVA: 0x001DF154 File Offset: 0x001DD354
		public void SetColor(int index, vtkColorTransferFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetColor_73(base.GetCppThis(), index, (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06015256 RID: 86614
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetColor_74(HandleRef pThis, HandleRef function);

		/// <summary>
		/// Set the color of a volume to an RGB transfer function
		/// for the component indicated by index. This will set the
		/// color channels for this component to 3.
		/// This will also recompute the color channels
		/// </summary>
		// Token: 0x06015257 RID: 86615 RVA: 0x001DF184 File Offset: 0x001DD384
		public void SetColor(vtkColorTransferFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetColor_74(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06015258 RID: 86616
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetComponentWeight_75(HandleRef pThis, int index, double value);

		/// <summary>
		/// Set/Get the scalar component weights.
		/// Clamped between the range of (0.0, 1.0)
		/// </summary>
		// Token: 0x06015259 RID: 86617 RVA: 0x001DF1B3 File Offset: 0x001DD3B3
		public virtual void SetComponentWeight(int index, double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetComponentWeight_75(base.GetCppThis(), index, value);
		}

		// Token: 0x0601525A RID: 86618
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetDiffuse_76(HandleRef pThis, int index, double value);

		/// <summary>
		/// Set/Get the diffuse lighting coefficient.
		/// </summary>
		// Token: 0x0601525B RID: 86619 RVA: 0x001DF1C4 File Offset: 0x001DD3C4
		public void SetDiffuse(int index, double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetDiffuse_76(base.GetCppThis(), index, value);
		}

		// Token: 0x0601525C RID: 86620
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetDiffuse_77(HandleRef pThis, double value);

		/// <summary>
		/// Set/Get the diffuse lighting coefficient.
		/// </summary>
		// Token: 0x0601525D RID: 86621 RVA: 0x001DF1D5 File Offset: 0x001DD3D5
		public void SetDiffuse(double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetDiffuse_77(base.GetCppThis(), value);
		}

		// Token: 0x0601525E RID: 86622
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetDisableGradientOpacity_78(HandleRef pThis, int index, int value);

		/// <summary>
		/// Enable/Disable the gradient opacity function for the given component.
		/// If set to true, any call to GetGradientOpacity() will return a default
		/// function for this component. Note that the gradient opacity function is
		/// still stored, it is not set or reset and can be retrieved using
		/// GetStoredGradientOpacity().
		/// </summary>
		// Token: 0x0601525F RID: 86623 RVA: 0x001DF1E5 File Offset: 0x001DD3E5
		public virtual void SetDisableGradientOpacity(int index, int value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetDisableGradientOpacity_78(base.GetCppThis(), index, value);
		}

		// Token: 0x06015260 RID: 86624
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetDisableGradientOpacity_79(HandleRef pThis, int value);

		/// <summary>
		/// Enable/Disable the gradient opacity function for the given component.
		/// If set to true, any call to GetGradientOpacity() will return a default
		/// function for this component. Note that the gradient opacity function is
		/// still stored, it is not set or reset and can be retrieved using
		/// GetStoredGradientOpacity().
		/// </summary>
		// Token: 0x06015261 RID: 86625 RVA: 0x001DF1F6 File Offset: 0x001DD3F6
		public virtual void SetDisableGradientOpacity(int value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetDisableGradientOpacity_79(base.GetCppThis(), value);
		}

		// Token: 0x06015262 RID: 86626
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetGradientOpacity_80(HandleRef pThis, int index, HandleRef function);

		/// <summary>
		/// Set the opacity of a volume to an opacity transfer function based
		/// on gradient magnitude for the given component.
		/// </summary>
		// Token: 0x06015263 RID: 86627 RVA: 0x001DF208 File Offset: 0x001DD408
		public void SetGradientOpacity(int index, vtkPiecewiseFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetGradientOpacity_80(base.GetCppThis(), index, (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06015264 RID: 86628
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetGradientOpacity_81(HandleRef pThis, HandleRef function);

		/// <summary>
		/// Set the opacity of a volume to an opacity transfer function based
		/// on gradient magnitude for the given component.
		/// </summary>
		// Token: 0x06015265 RID: 86629 RVA: 0x001DF238 File Offset: 0x001DD438
		public void SetGradientOpacity(vtkPiecewiseFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetGradientOpacity_81(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06015266 RID: 86630
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetIndependentComponents_82(HandleRef pThis, int _arg);

		/// <summary>
		/// Does the data have independent components, or do some define color
		/// only? If IndependentComponents is On (the default) then each component
		/// will be independently passed through a lookup table to determine RGBA,
		/// shaded. Some volume Mappers can handle 1 to 4 component
		/// unsigned char or unsigned short data (see each mapper header file to
		/// determine functionality). If IndependentComponents is Off, then you
		/// must have either 2 or 4 component data. For 2 component data, the
		/// first is passed through the first color transfer function and the
		/// second component is passed through the first scalar opacity (and
		/// gradient opacity) transfer function.
		/// Normals will be generated off of the second component. When using gradient
		/// based opacity modulation, the gradients are computed off of the
		/// second component. For 4 component
		/// data, the first three will directly represent RGB (no lookup table).
		/// The fourth component will be passed through the first scalar opacity
		/// transfer function for opacity and first gradient opacity transfer function
		/// for gradient based opacity modulation. Normals will be generated from the
		/// fourth component. When using gradient based opacity modulation, the
		/// gradients are computed off of the fourth component.
		/// </summary>
		// Token: 0x06015267 RID: 86631 RVA: 0x001DF267 File Offset: 0x001DD467
		public virtual void SetIndependentComponents(int _arg)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetIndependentComponents_82(base.GetCppThis(), _arg);
		}

		// Token: 0x06015268 RID: 86632
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetInterpolationType_83(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the interpolation type for sampling a volume. Initial value is
		/// VTK_NEAREST_INTERPOLATION.
		/// </summary>
		// Token: 0x06015269 RID: 86633 RVA: 0x001DF277 File Offset: 0x001DD477
		public virtual void SetInterpolationType(int _arg)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetInterpolationType_83(base.GetCppThis(), _arg);
		}

		// Token: 0x0601526A RID: 86634
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetInterpolationTypeToLinear_84(HandleRef pThis);

		/// <summary>
		/// Set the interpolation type for sampling a volume. Initial value is
		/// VTK_NEAREST_INTERPOLATION.
		/// </summary>
		// Token: 0x0601526B RID: 86635 RVA: 0x001DF287 File Offset: 0x001DD487
		public void SetInterpolationTypeToLinear()
		{
			vtkVolumeProperty.vtkVolumeProperty_SetInterpolationTypeToLinear_84(base.GetCppThis());
		}

		// Token: 0x0601526C RID: 86636
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetInterpolationTypeToNearest_85(HandleRef pThis);

		/// <summary>
		/// Set the interpolation type for sampling a volume. Initial value is
		/// VTK_NEAREST_INTERPOLATION.
		/// </summary>
		// Token: 0x0601526D RID: 86637 RVA: 0x001DF296 File Offset: 0x001DD496
		public void SetInterpolationTypeToNearest()
		{
			vtkVolumeProperty.vtkVolumeProperty_SetInterpolationTypeToNearest_85(base.GetCppThis());
		}

		// Token: 0x0601526E RID: 86638
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetLabelColor_86(HandleRef pThis, int label, HandleRef function);

		/// <summary>
		/// Set/Get the color transfer function for a label in the label map.
		/// </summary>
		// Token: 0x0601526F RID: 86639 RVA: 0x001DF2A8 File Offset: 0x001DD4A8
		public void SetLabelColor(int label, vtkColorTransferFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetLabelColor_86(base.GetCppThis(), label, (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06015270 RID: 86640
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetLabelGradientOpacity_87(HandleRef pThis, int label, HandleRef function);

		/// <summary>
		/// Set/Get the gradient opacity function for a label in the label map.
		/// </summary>
		// Token: 0x06015271 RID: 86641 RVA: 0x001DF2D8 File Offset: 0x001DD4D8
		public void SetLabelGradientOpacity(int label, vtkPiecewiseFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetLabelGradientOpacity_87(base.GetCppThis(), label, (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06015272 RID: 86642
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetLabelScalarOpacity_88(HandleRef pThis, int label, HandleRef function);

		/// <summary>
		/// Set/Get the opacity transfer function for a label in the label map.
		/// </summary>
		// Token: 0x06015273 RID: 86643 RVA: 0x001DF308 File Offset: 0x001DD508
		public void SetLabelScalarOpacity(int label, vtkPiecewiseFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetLabelScalarOpacity_88(base.GetCppThis(), label, (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06015274 RID: 86644
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetScalarOpacity_89(HandleRef pThis, int index, HandleRef function);

		/// <summary>
		/// Set the opacity of a volume to an opacity transfer function based
		/// on scalar value for the component indicated by index.
		/// </summary>
		// Token: 0x06015275 RID: 86645 RVA: 0x001DF338 File Offset: 0x001DD538
		public void SetScalarOpacity(int index, vtkPiecewiseFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetScalarOpacity_89(base.GetCppThis(), index, (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06015276 RID: 86646
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetScalarOpacity_90(HandleRef pThis, HandleRef function);

		/// <summary>
		/// Set the opacity of a volume to an opacity transfer function based
		/// on scalar value for the component indicated by index.
		/// </summary>
		// Token: 0x06015277 RID: 86647 RVA: 0x001DF368 File Offset: 0x001DD568
		public void SetScalarOpacity(vtkPiecewiseFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetScalarOpacity_90(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06015278 RID: 86648
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetScalarOpacityUnitDistance_91(HandleRef pThis, int index, double distance);

		/// <summary>
		/// Set/Get the unit distance on which the scalar opacity transfer function
		/// is defined. By default this is 1.0, meaning that over a distance of
		/// 1.0 units, a given opacity (from the transfer function) is accumulated.
		/// This is adjusted for the actual sampling distance during rendering.
		/// </summary>
		// Token: 0x06015279 RID: 86649 RVA: 0x001DF397 File Offset: 0x001DD597
		public void SetScalarOpacityUnitDistance(int index, double distance)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetScalarOpacityUnitDistance_91(base.GetCppThis(), index, distance);
		}

		// Token: 0x0601527A RID: 86650
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetScalarOpacityUnitDistance_92(HandleRef pThis, double distance);

		/// <summary>
		/// Set/Get the unit distance on which the scalar opacity transfer function
		/// is defined. By default this is 1.0, meaning that over a distance of
		/// 1.0 units, a given opacity (from the transfer function) is accumulated.
		/// This is adjusted for the actual sampling distance during rendering.
		/// </summary>
		// Token: 0x0601527B RID: 86651 RVA: 0x001DF3A8 File Offset: 0x001DD5A8
		public void SetScalarOpacityUnitDistance(double distance)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetScalarOpacityUnitDistance_92(base.GetCppThis(), distance);
		}

		// Token: 0x0601527C RID: 86652
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetScatteringAnisotropy_93(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set the volume's scattering anisotropy.
		/// The model used is Henyey-Greenstein. The value should
		/// be between -1.0 (back-scattering) and 1.0 (forward-scattering),
		/// so the default value of 0.0 corresponds to an isotropic
		/// volume. For now, it is only used in vtkGPUVolumeRayCastMapper.
		/// </summary>
		// Token: 0x0601527D RID: 86653 RVA: 0x001DF3B8 File Offset: 0x001DD5B8
		public virtual void SetScatteringAnisotropy(float _arg)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetScatteringAnisotropy_93(base.GetCppThis(), _arg);
		}

		// Token: 0x0601527E RID: 86654
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetShade_94(HandleRef pThis, int index, int value);

		/// <summary>
		/// Set/Get the shading of a volume. If shading is turned off, then
		/// the mapper for the volume will not perform shading calculations.
		/// If shading is turned on, the mapper may perform shading
		/// calculations - in some cases shading does not apply (for example,
		/// in a maximum intensity projection) and therefore shading will
		/// not be performed even if this flag is on. For a compositing type
		/// of mapper, turning shading off is generally the same as setting
		/// ambient=1, diffuse=0, specular=0. Shading can be independently
		/// turned on/off per component.
		///
		/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
		/// For minimum and maximum intensity blend modes, there is not necessarily one
		/// unique location along the ray through the volume where that minimum or
		/// maximum occurs. For average and additive blend modes, the value being
		/// visualized does not represent a location in the volume but rather a
		/// statistical measurement along the ray traversing through the volume, and
		/// hence shading is not applicable.
		/// \sa vtkVolumeMapper::BlendModes
		/// </summary>
		// Token: 0x0601527F RID: 86655 RVA: 0x001DF3C8 File Offset: 0x001DD5C8
		public void SetShade(int index, int value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetShade_94(base.GetCppThis(), index, value);
		}

		// Token: 0x06015280 RID: 86656
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetShade_95(HandleRef pThis, int value);

		/// <summary>
		/// Set/Get the shading of a volume. If shading is turned off, then
		/// the mapper for the volume will not perform shading calculations.
		/// If shading is turned on, the mapper may perform shading
		/// calculations - in some cases shading does not apply (for example,
		/// in a maximum intensity projection) and therefore shading will
		/// not be performed even if this flag is on. For a compositing type
		/// of mapper, turning shading off is generally the same as setting
		/// ambient=1, diffuse=0, specular=0. Shading can be independently
		/// turned on/off per component.
		///
		/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
		/// For minimum and maximum intensity blend modes, there is not necessarily one
		/// unique location along the ray through the volume where that minimum or
		/// maximum occurs. For average and additive blend modes, the value being
		/// visualized does not represent a location in the volume but rather a
		/// statistical measurement along the ray traversing through the volume, and
		/// hence shading is not applicable.
		/// \sa vtkVolumeMapper::BlendModes
		/// </summary>
		// Token: 0x06015281 RID: 86657 RVA: 0x001DF3D9 File Offset: 0x001DD5D9
		public void SetShade(int value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetShade_95(base.GetCppThis(), value);
		}

		// Token: 0x06015282 RID: 86658
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetSliceFunction_96(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Get/Set the function used for slicing.
		/// Currently, only vtkPlane is supported.
		/// </summary>
		// Token: 0x06015283 RID: 86659 RVA: 0x001DF3EC File Offset: 0x001DD5EC
		public virtual void SetSliceFunction(vtkImplicitFunction _arg)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetSliceFunction_96(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x06015284 RID: 86660
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetSpecular_97(HandleRef pThis, int index, double value);

		/// <summary>
		/// Set/Get the specular lighting coefficient.
		/// </summary>
		// Token: 0x06015285 RID: 86661 RVA: 0x001DF41B File Offset: 0x001DD61B
		public void SetSpecular(int index, double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetSpecular_97(base.GetCppThis(), index, value);
		}

		// Token: 0x06015286 RID: 86662
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetSpecular_98(HandleRef pThis, double value);

		/// <summary>
		/// Set/Get the specular lighting coefficient.
		/// </summary>
		// Token: 0x06015287 RID: 86663 RVA: 0x001DF42C File Offset: 0x001DD62C
		public void SetSpecular(double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetSpecular_98(base.GetCppThis(), value);
		}

		// Token: 0x06015288 RID: 86664
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetSpecularPower_99(HandleRef pThis, int index, double value);

		/// <summary>
		/// Set/Get the specular power.
		/// </summary>
		// Token: 0x06015289 RID: 86665 RVA: 0x001DF43C File Offset: 0x001DD63C
		public void SetSpecularPower(int index, double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetSpecularPower_99(base.GetCppThis(), index, value);
		}

		// Token: 0x0601528A RID: 86666
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetSpecularPower_100(HandleRef pThis, double value);

		/// <summary>
		/// Set/Get the specular power.
		/// </summary>
		// Token: 0x0601528B RID: 86667 RVA: 0x001DF44D File Offset: 0x001DD64D
		public void SetSpecularPower(double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetSpecularPower_100(base.GetCppThis(), value);
		}

		// Token: 0x0601528C RID: 86668
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetTransferFunction2D_101(HandleRef pThis, int index, HandleRef function);

		/// <summary>
		/// Set/Get a 2D transfer function. Volume mappers interpret the x-axis of
		/// of this transfer function as scalar value and the y-axis as gradient
		/// magnitude. The value at (X, Y) corresponds to the color and opacity
		/// for a salar value of X and a gradient magnitude of Y.
		/// </summary>
		// Token: 0x0601528D RID: 86669 RVA: 0x001DF460 File Offset: 0x001DD660
		public void SetTransferFunction2D(int index, vtkImageData function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetTransferFunction2D_101(base.GetCppThis(), index, (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x0601528E RID: 86670
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetTransferFunction2D_102(HandleRef pThis, HandleRef function);

		/// <summary>
		/// Set/Get a 2D transfer function. Volume mappers interpret the x-axis of
		/// of this transfer function as scalar value and the y-axis as gradient
		/// magnitude. The value at (X, Y) corresponds to the color and opacity
		/// for a salar value of X and a gradient magnitude of Y.
		/// </summary>
		// Token: 0x0601528F RID: 86671 RVA: 0x001DF490 File Offset: 0x001DD690
		public void SetTransferFunction2D(vtkImageData function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetTransferFunction2D_102(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06015290 RID: 86672
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetTransferFunctionMode_103(HandleRef pThis, int _arg);

		/// <summary>
		/// Color-opacity transfer function mode. TF_1D is its default value.
		///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
		///  and gradient mag. opacity.
		///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
		///  opacity.
		/// </summary>
		// Token: 0x06015291 RID: 86673 RVA: 0x001DF4BF File Offset: 0x001DD6BF
		public virtual void SetTransferFunctionMode(int _arg)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetTransferFunctionMode_103(base.GetCppThis(), _arg);
		}

		// Token: 0x06015292 RID: 86674
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetTransferFunctionModeTo1D_104(HandleRef pThis);

		/// <summary>
		/// Color-opacity transfer function mode. TF_1D is its default value.
		///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
		///  and gradient mag. opacity.
		///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
		///  opacity.
		/// </summary>
		// Token: 0x06015293 RID: 86675 RVA: 0x001DF4CF File Offset: 0x001DD6CF
		public void SetTransferFunctionModeTo1D()
		{
			vtkVolumeProperty.vtkVolumeProperty_SetTransferFunctionModeTo1D_104(base.GetCppThis());
		}

		// Token: 0x06015294 RID: 86676
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetTransferFunctionModeTo2D_105(HandleRef pThis);

		/// <summary>
		/// Color-opacity transfer function mode. TF_1D is its default value.
		///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
		///  and gradient mag. opacity.
		///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
		///  opacity.
		/// </summary>
		// Token: 0x06015295 RID: 86677 RVA: 0x001DF4DE File Offset: 0x001DD6DE
		public void SetTransferFunctionModeTo2D()
		{
			vtkVolumeProperty.vtkVolumeProperty_SetTransferFunctionModeTo2D_105(base.GetCppThis());
		}

		// Token: 0x06015296 RID: 86678
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_SetUseClippedVoxelIntensity_106(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether to use a fixed intensity value for voxels in the clipped
		/// space for gradient calculations. When UseClippedVoxelIntensity is
		/// enabled, the ClippedVoxelIntensity value will be used as intensity of
		/// clipped voxels. By default, this is false.
		///
		/// \note This property is only used by the vtkGPUVolumeRayCastMapper for now.
		/// \sa SetClippedVoxelIntensity
		/// </summary>
		// Token: 0x06015297 RID: 86679 RVA: 0x001DF4ED File Offset: 0x001DD6ED
		public virtual void SetUseClippedVoxelIntensity(int _arg)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetUseClippedVoxelIntensity_106(base.GetCppThis(), _arg);
		}

		// Token: 0x06015298 RID: 86680
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_ShadeOff_107(HandleRef pThis, int index);

		/// <summary>
		/// Set/Get the shading of a volume. If shading is turned off, then
		/// the mapper for the volume will not perform shading calculations.
		/// If shading is turned on, the mapper may perform shading
		/// calculations - in some cases shading does not apply (for example,
		/// in a maximum intensity projection) and therefore shading will
		/// not be performed even if this flag is on. For a compositing type
		/// of mapper, turning shading off is generally the same as setting
		/// ambient=1, diffuse=0, specular=0. Shading can be independently
		/// turned on/off per component.
		///
		/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
		/// For minimum and maximum intensity blend modes, there is not necessarily one
		/// unique location along the ray through the volume where that minimum or
		/// maximum occurs. For average and additive blend modes, the value being
		/// visualized does not represent a location in the volume but rather a
		/// statistical measurement along the ray traversing through the volume, and
		/// hence shading is not applicable.
		/// \sa vtkVolumeMapper::BlendModes
		/// </summary>
		// Token: 0x06015299 RID: 86681 RVA: 0x001DF4FD File Offset: 0x001DD6FD
		public void ShadeOff(int index)
		{
			vtkVolumeProperty.vtkVolumeProperty_ShadeOff_107(base.GetCppThis(), index);
		}

		// Token: 0x0601529A RID: 86682
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_ShadeOff_108(HandleRef pThis);

		/// <summary>
		/// Set/Get the shading of a volume. If shading is turned off, then
		/// the mapper for the volume will not perform shading calculations.
		/// If shading is turned on, the mapper may perform shading
		/// calculations - in some cases shading does not apply (for example,
		/// in a maximum intensity projection) and therefore shading will
		/// not be performed even if this flag is on. For a compositing type
		/// of mapper, turning shading off is generally the same as setting
		/// ambient=1, diffuse=0, specular=0. Shading can be independently
		/// turned on/off per component.
		///
		/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
		/// For minimum and maximum intensity blend modes, there is not necessarily one
		/// unique location along the ray through the volume where that minimum or
		/// maximum occurs. For average and additive blend modes, the value being
		/// visualized does not represent a location in the volume but rather a
		/// statistical measurement along the ray traversing through the volume, and
		/// hence shading is not applicable.
		/// \sa vtkVolumeMapper::BlendModes
		/// </summary>
		// Token: 0x0601529B RID: 86683 RVA: 0x001DF50D File Offset: 0x001DD70D
		public void ShadeOff()
		{
			vtkVolumeProperty.vtkVolumeProperty_ShadeOff_108(base.GetCppThis());
		}

		// Token: 0x0601529C RID: 86684
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_ShadeOn_109(HandleRef pThis, int index);

		/// <summary>
		/// Set/Get the shading of a volume. If shading is turned off, then
		/// the mapper for the volume will not perform shading calculations.
		/// If shading is turned on, the mapper may perform shading
		/// calculations - in some cases shading does not apply (for example,
		/// in a maximum intensity projection) and therefore shading will
		/// not be performed even if this flag is on. For a compositing type
		/// of mapper, turning shading off is generally the same as setting
		/// ambient=1, diffuse=0, specular=0. Shading can be independently
		/// turned on/off per component.
		///
		/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
		/// For minimum and maximum intensity blend modes, there is not necessarily one
		/// unique location along the ray through the volume where that minimum or
		/// maximum occurs. For average and additive blend modes, the value being
		/// visualized does not represent a location in the volume but rather a
		/// statistical measurement along the ray traversing through the volume, and
		/// hence shading is not applicable.
		/// \sa vtkVolumeMapper::BlendModes
		/// </summary>
		// Token: 0x0601529D RID: 86685 RVA: 0x001DF51C File Offset: 0x001DD71C
		public void ShadeOn(int index)
		{
			vtkVolumeProperty.vtkVolumeProperty_ShadeOn_109(base.GetCppThis(), index);
		}

		// Token: 0x0601529E RID: 86686
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_ShadeOn_110(HandleRef pThis);

		/// <summary>
		/// Set/Get the shading of a volume. If shading is turned off, then
		/// the mapper for the volume will not perform shading calculations.
		/// If shading is turned on, the mapper may perform shading
		/// calculations - in some cases shading does not apply (for example,
		/// in a maximum intensity projection) and therefore shading will
		/// not be performed even if this flag is on. For a compositing type
		/// of mapper, turning shading off is generally the same as setting
		/// ambient=1, diffuse=0, specular=0. Shading can be independently
		/// turned on/off per component.
		///
		/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
		/// For minimum and maximum intensity blend modes, there is not necessarily one
		/// unique location along the ray through the volume where that minimum or
		/// maximum occurs. For average and additive blend modes, the value being
		/// visualized does not represent a location in the volume but rather a
		/// statistical measurement along the ray traversing through the volume, and
		/// hence shading is not applicable.
		/// \sa vtkVolumeMapper::BlendModes
		/// </summary>
		// Token: 0x0601529F RID: 86687 RVA: 0x001DF52C File Offset: 0x001DD72C
		public void ShadeOn()
		{
			vtkVolumeProperty.vtkVolumeProperty_ShadeOn_110(base.GetCppThis());
		}

		// Token: 0x060152A0 RID: 86688
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_UpdateMTimes_111(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// UpdateMTimes performs a Modified() on all TimeStamps.
		/// This is used by vtkVolume when the property is set, so
		/// that any other object that might have been caching
		/// information for the property will rebuild.
		/// </summary>
		// Token: 0x060152A1 RID: 86689 RVA: 0x001DF53B File Offset: 0x001DD73B
		public void UpdateMTimes()
		{
			vtkVolumeProperty.vtkVolumeProperty_UpdateMTimes_111(base.GetCppThis());
		}

		// Token: 0x060152A2 RID: 86690
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_UseClippedVoxelIntensityOff_112(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to use a fixed intensity value for voxels in the clipped
		/// space for gradient calculations. When UseClippedVoxelIntensity is
		/// enabled, the ClippedVoxelIntensity value will be used as intensity of
		/// clipped voxels. By default, this is false.
		///
		/// \note This property is only used by the vtkGPUVolumeRayCastMapper for now.
		/// \sa SetClippedVoxelIntensity
		/// </summary>
		// Token: 0x060152A3 RID: 86691 RVA: 0x001DF54A File Offset: 0x001DD74A
		public virtual void UseClippedVoxelIntensityOff()
		{
			vtkVolumeProperty.vtkVolumeProperty_UseClippedVoxelIntensityOff_112(base.GetCppThis());
		}

		// Token: 0x060152A4 RID: 86692
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeProperty_UseClippedVoxelIntensityOn_113(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to use a fixed intensity value for voxels in the clipped
		/// space for gradient calculations. When UseClippedVoxelIntensity is
		/// enabled, the ClippedVoxelIntensity value will be used as intensity of
		/// clipped voxels. By default, this is false.
		///
		/// \note This property is only used by the vtkGPUVolumeRayCastMapper for now.
		/// \sa SetClippedVoxelIntensity
		/// </summary>
		// Token: 0x060152A5 RID: 86693 RVA: 0x001DF559 File Offset: 0x001DD759
		public virtual void UseClippedVoxelIntensityOn()
		{
			vtkVolumeProperty.vtkVolumeProperty_UseClippedVoxelIntensityOn_113(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001859 RID: 6233
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeProperty";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400185A RID: 6234
		public new static readonly string MRClassNameKey = "class vtkVolumeProperty";

		/// <summary>
		/// Color-opacity transfer function mode. TF_1D is its default value.
		///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
		///  and gradient mag. opacity.
		///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
		///  opacity.
		/// </summary>
		// Token: 0x0200080A RID: 2058
		public enum TransferMode
		{
			/// <summary>enum member</summary>
			// Token: 0x0400185C RID: 6236
			TF_1D,
			/// <summary>enum member</summary>
			// Token: 0x0400185D RID: 6237
			TF_2D
		}
	}
}
