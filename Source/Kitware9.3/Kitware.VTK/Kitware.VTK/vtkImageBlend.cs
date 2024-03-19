using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageBlend
	/// </summary>
	/// <remarks>
	///    blend images together using alpha or opacity
	///
	/// vtkImageBlend takes L, LA, RGB, or RGBA images as input and blends them
	/// according to the alpha values and/or the opacity setting for each input.
	///
	/// The spacing, origin, extent, and number of components of the output are
	/// the same as those for the first input.  If the input has an alpha
	/// component, then this component is copied unchanged into the output.
	/// In addition, if the first input has either one component or two
	/// components i.e. if it is either L (greyscale) or LA (greyscale + alpha)
	/// then all other inputs must also be L or LA.
	///
	/// Different blending modes are available:
	///
	/// \em Normal (default) :
	/// This is the standard blending mode used by OpenGL and other graphics
	/// packages.  The output always has the same number of components
	/// and the same extent as the first input.  The alpha value of the first
	/// input is not used in the blending computation, instead it is copied
	/// directly to the output.
	///
	/// <code>
	/// output &lt;- input[0]
	/// foreach input i {
	///   foreach pixel px {
	///     r &lt;- input[i](px)(alpha) * opacity[i]
	///     f &lt;- (255 - r)
	///     output(px) &lt;- output(px) * f + input(px) * r
	///   }
	/// }
	/// </code>
	///
	/// \em Compound :
	/// Images are compounded together and each component is scaled by the sum of
	/// the alpha/opacity values. Use the CompoundThreshold method to set
	/// specify a threshold in compound mode. Pixels with opacity*alpha less
	/// or equal than this threshold are ignored.
	/// The alpha value of the first input, if present, is NOT copied to the alpha
	/// value of the output.  The output always has the same number of components
	/// and the same extent as the first input.
	/// If CompoundAlpha is set, the alpha value of the output is also computed using
	/// the alpha weighted blend calculation.
	///
	/// <code>
	/// output &lt;- 0
	/// foreach pixel px {
	///   sum &lt;- 0
	///   foreach input i {
	///     r &lt;- input[i](px)(alpha) * opacity(i)
	///     sum &lt;- sum + r
	///     if r &gt; threshold {
	///       output(px) &lt;- output(px) + input(px) * r
	///     }
	///   }
	///   output(px) &lt;- output(px) / sum
	/// }
	/// </code>
	/// </remarks>
	// Token: 0x0200084D RID: 2125
	public class vtkImageBlend : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016093 RID: 90259 RVA: 0x001F08F3 File Offset: 0x001EEAF3
		static vtkImageBlend()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageBlend.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageBlend"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016094 RID: 90260 RVA: 0x001F091B File Offset: 0x001EEB1B
		public vtkImageBlend(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016095 RID: 90261
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBlend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016096 RID: 90262 RVA: 0x001F092C File Offset: 0x001EEB2C
		public new static vtkImageBlend New()
		{
			vtkImageBlend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageBlend.vtkImageBlend_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageBlend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016097 RID: 90263 RVA: 0x001F0980 File Offset: 0x001EEB80
		public vtkImageBlend() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageBlend.vtkImageBlend_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016098 RID: 90264 RVA: 0x001F09C4 File Offset: 0x001EEBC4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016099 RID: 90265
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_CompoundAlphaOff_01(HandleRef pThis);

		/// <summary>
		/// Set whether to use the alpha weighted blending calculation on the alpha
		/// component. If false, the alpha component is set to the sum of the product
		/// of opacity and alpha from all inputs.
		/// </summary>
		// Token: 0x0601609A RID: 90266 RVA: 0x001F09CF File Offset: 0x001EEBCF
		public virtual void CompoundAlphaOff()
		{
			vtkImageBlend.vtkImageBlend_CompoundAlphaOff_01(base.GetCppThis());
		}

		// Token: 0x0601609B RID: 90267
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_CompoundAlphaOn_02(HandleRef pThis);

		/// <summary>
		/// Set whether to use the alpha weighted blending calculation on the alpha
		/// component. If false, the alpha component is set to the sum of the product
		/// of opacity and alpha from all inputs.
		/// </summary>
		// Token: 0x0601609C RID: 90268 RVA: 0x001F09DE File Offset: 0x001EEBDE
		public virtual void CompoundAlphaOn()
		{
			vtkImageBlend.vtkImageBlend_CompoundAlphaOn_02(base.GetCppThis());
		}

		// Token: 0x0601609D RID: 90269
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBlend_GetBlendMode_03(HandleRef pThis);

		/// <summary>
		/// Set the blend mode
		/// </summary>
		// Token: 0x0601609E RID: 90270 RVA: 0x001F09F0 File Offset: 0x001EEBF0
		public virtual int GetBlendMode()
		{
			return vtkImageBlend.vtkImageBlend_GetBlendMode_03(base.GetCppThis());
		}

		// Token: 0x0601609F RID: 90271
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBlend_GetBlendModeAsString_04(HandleRef pThis);

		/// <summary>
		/// Set the blend mode
		/// </summary>
		// Token: 0x060160A0 RID: 90272 RVA: 0x001F0A10 File Offset: 0x001EEC10
		public string GetBlendModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageBlend.vtkImageBlend_GetBlendModeAsString_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060160A1 RID: 90273
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBlend_GetBlendModeMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set the blend mode
		/// </summary>
		// Token: 0x060160A2 RID: 90274 RVA: 0x001F0A4C File Offset: 0x001EEC4C
		public virtual int GetBlendModeMaxValue()
		{
			return vtkImageBlend.vtkImageBlend_GetBlendModeMaxValue_05(base.GetCppThis());
		}

		// Token: 0x060160A3 RID: 90275
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBlend_GetBlendModeMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set the blend mode
		/// </summary>
		// Token: 0x060160A4 RID: 90276 RVA: 0x001F0A6C File Offset: 0x001EEC6C
		public virtual int GetBlendModeMinValue()
		{
			return vtkImageBlend.vtkImageBlend_GetBlendModeMinValue_06(base.GetCppThis());
		}

		// Token: 0x060160A5 RID: 90277
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBlend_GetCompoundAlpha_07(HandleRef pThis);

		/// <summary>
		/// Set whether to use the alpha weighted blending calculation on the alpha
		/// component. If false, the alpha component is set to the sum of the product
		/// of opacity and alpha from all inputs.
		/// </summary>
		// Token: 0x060160A6 RID: 90278 RVA: 0x001F0A8C File Offset: 0x001EEC8C
		public virtual int GetCompoundAlpha()
		{
			return vtkImageBlend.vtkImageBlend_GetCompoundAlpha_07(base.GetCppThis());
		}

		// Token: 0x060160A7 RID: 90279
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageBlend_GetCompoundThreshold_08(HandleRef pThis);

		/// <summary>
		/// Specify a threshold in compound mode. Pixels with opacity*alpha less
		/// or equal the threshold are ignored.
		/// </summary>
		// Token: 0x060160A8 RID: 90280 RVA: 0x001F0AAC File Offset: 0x001EECAC
		public virtual double GetCompoundThreshold()
		{
			return vtkImageBlend.vtkImageBlend_GetCompoundThreshold_08(base.GetCppThis());
		}

		// Token: 0x060160A9 RID: 90281
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBlend_GetInput_09(HandleRef pThis, int num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one input to this filter. This method is only for support of
		/// old-style pipeline connections.  When writing new code you should
		/// use vtkAlgorithm::GetInputConnection(0, num).
		/// </summary>
		// Token: 0x060160AA RID: 90282 RVA: 0x001F0ACC File Offset: 0x001EECCC
		public new vtkDataObject GetInput(int num)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageBlend.vtkImageBlend_GetInput_09(base.GetCppThis(), num, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x060160AB RID: 90283
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBlend_GetInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one input to this filter. This method is only for support of
		/// old-style pipeline connections.  When writing new code you should
		/// use vtkAlgorithm::GetInputConnection(0, num).
		/// </summary>
		// Token: 0x060160AC RID: 90284 RVA: 0x001F0B3C File Offset: 0x001EED3C
		public new vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageBlend.vtkImageBlend_GetInput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x060160AD RID: 90285
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageBlend_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060160AE RID: 90286 RVA: 0x001F0BAC File Offset: 0x001EEDAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageBlend.vtkImageBlend_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x060160AF RID: 90287
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageBlend_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060160B0 RID: 90288 RVA: 0x001F0BCC File Offset: 0x001EEDCC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageBlend.vtkImageBlend_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x060160B1 RID: 90289
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBlend_GetNumberOfInputs_13(HandleRef pThis);

		/// <summary>
		/// Get the number of inputs to this filter. This method is only for
		/// support of old-style pipeline connections.  When writing new code
		/// you should use vtkAlgorithm::GetNumberOfInputConnections(0).
		/// </summary>
		// Token: 0x060160B2 RID: 90290 RVA: 0x001F0BE8 File Offset: 0x001EEDE8
		public int GetNumberOfInputs()
		{
			return vtkImageBlend.vtkImageBlend_GetNumberOfInputs_13(base.GetCppThis());
		}

		// Token: 0x060160B3 RID: 90291
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageBlend_GetOpacity_14(HandleRef pThis, int idx);

		/// <summary>
		/// Set the opacity of an input image: the alpha values of the image are
		/// multiplied by the opacity.  The opacity of image idx=0 is ignored.
		/// </summary>
		// Token: 0x060160B4 RID: 90292 RVA: 0x001F0C08 File Offset: 0x001EEE08
		public double GetOpacity(int idx)
		{
			return vtkImageBlend.vtkImageBlend_GetOpacity_14(base.GetCppThis(), idx);
		}

		// Token: 0x060160B5 RID: 90293
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBlend_GetStencil_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set a stencil to apply when blending the data.
		/// </summary>
		// Token: 0x060160B6 RID: 90294 RVA: 0x001F0C28 File Offset: 0x001EEE28
		public vtkImageStencilData GetStencil()
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageBlend.vtkImageBlend_GetStencil_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		// Token: 0x060160B7 RID: 90295
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBlend_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060160B8 RID: 90296 RVA: 0x001F0C98 File Offset: 0x001EEE98
		public override int IsA(string type)
		{
			return vtkImageBlend.vtkImageBlend_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x060160B9 RID: 90297
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBlend_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060160BA RID: 90298 RVA: 0x001F0CB8 File Offset: 0x001EEEB8
		public new static int IsTypeOf(string type)
		{
			return vtkImageBlend.vtkImageBlend_IsTypeOf_17(type);
		}

		// Token: 0x060160BB RID: 90299
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBlend_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060160BC RID: 90300 RVA: 0x001F0CD4 File Offset: 0x001EEED4
		public new vtkImageBlend NewInstance()
		{
			vtkImageBlend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageBlend.vtkImageBlend_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageBlend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060160BD RID: 90301
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_ReplaceNthInputConnection_20(HandleRef pThis, int idx, HandleRef input);

		/// <summary>
		/// Replace one of the input connections with a new input.  You can
		/// only replace input connections that you previously created with
		/// AddInputConnection() or, in the case of the first input,
		/// with SetInputConnection().
		/// </summary>
		// Token: 0x060160BE RID: 90302 RVA: 0x001F0D30 File Offset: 0x001EEF30
		public virtual void ReplaceNthInputConnection(int idx, vtkAlgorithmOutput input)
		{
			vtkImageBlend.vtkImageBlend_ReplaceNthInputConnection_20(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x060160BF RID: 90303
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageBlend_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060160C0 RID: 90304 RVA: 0x001F0D60 File Offset: 0x001EEF60
		public new static vtkImageBlend SafeDownCast(vtkObjectBase o)
		{
			vtkImageBlend vtkImageBlend = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageBlend.vtkImageBlend_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageBlend = (vtkImageBlend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageBlend.Register(null);
				}
			}
			return vtkImageBlend;
		}

		// Token: 0x060160C1 RID: 90305
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_SetBlendMode_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the blend mode
		/// </summary>
		// Token: 0x060160C2 RID: 90306 RVA: 0x001F0DDF File Offset: 0x001EEFDF
		public virtual void SetBlendMode(int _arg)
		{
			vtkImageBlend.vtkImageBlend_SetBlendMode_22(base.GetCppThis(), _arg);
		}

		// Token: 0x060160C3 RID: 90307
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_SetBlendModeToCompound_23(HandleRef pThis);

		/// <summary>
		/// Set the blend mode
		/// </summary>
		// Token: 0x060160C4 RID: 90308 RVA: 0x001F0DEF File Offset: 0x001EEFEF
		public void SetBlendModeToCompound()
		{
			vtkImageBlend.vtkImageBlend_SetBlendModeToCompound_23(base.GetCppThis());
		}

		// Token: 0x060160C5 RID: 90309
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_SetBlendModeToNormal_24(HandleRef pThis);

		/// <summary>
		/// Set the blend mode
		/// </summary>
		// Token: 0x060160C6 RID: 90310 RVA: 0x001F0DFE File Offset: 0x001EEFFE
		public void SetBlendModeToNormal()
		{
			vtkImageBlend.vtkImageBlend_SetBlendModeToNormal_24(base.GetCppThis());
		}

		// Token: 0x060160C7 RID: 90311
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_SetCompoundAlpha_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to use the alpha weighted blending calculation on the alpha
		/// component. If false, the alpha component is set to the sum of the product
		/// of opacity and alpha from all inputs.
		/// </summary>
		// Token: 0x060160C8 RID: 90312 RVA: 0x001F0E0D File Offset: 0x001EF00D
		public virtual void SetCompoundAlpha(int _arg)
		{
			vtkImageBlend.vtkImageBlend_SetCompoundAlpha_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060160C9 RID: 90313
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_SetCompoundThreshold_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a threshold in compound mode. Pixels with opacity*alpha less
		/// or equal the threshold are ignored.
		/// </summary>
		// Token: 0x060160CA RID: 90314 RVA: 0x001F0E1D File Offset: 0x001EF01D
		public virtual void SetCompoundThreshold(double _arg)
		{
			vtkImageBlend.vtkImageBlend_SetCompoundThreshold_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060160CB RID: 90315
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_SetInputData_27(HandleRef pThis, int num, HandleRef input);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060160CC RID: 90316 RVA: 0x001F0E30 File Offset: 0x001EF030
		public new void SetInputData(int num, vtkDataObject input)
		{
			vtkImageBlend.vtkImageBlend_SetInputData_27(base.GetCppThis(), num, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x060160CD RID: 90317
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_SetInputData_28(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060160CE RID: 90318 RVA: 0x001F0E60 File Offset: 0x001EF060
		public new void SetInputData(vtkDataObject input)
		{
			vtkImageBlend.vtkImageBlend_SetInputData_28(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x060160CF RID: 90319
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_SetOpacity_29(HandleRef pThis, int idx, double opacity);

		/// <summary>
		/// Set the opacity of an input image: the alpha values of the image are
		/// multiplied by the opacity.  The opacity of image idx=0 is ignored.
		/// </summary>
		// Token: 0x060160D0 RID: 90320 RVA: 0x001F0E8F File Offset: 0x001EF08F
		public void SetOpacity(int idx, double opacity)
		{
			vtkImageBlend.vtkImageBlend_SetOpacity_29(base.GetCppThis(), idx, opacity);
		}

		// Token: 0x060160D1 RID: 90321
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_SetStencilConnection_30(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Set a stencil to apply when blending the data.
		/// Create a pipeline connection.
		/// </summary>
		// Token: 0x060160D2 RID: 90322 RVA: 0x001F0EA0 File Offset: 0x001EF0A0
		public void SetStencilConnection(vtkAlgorithmOutput algOutput)
		{
			vtkImageBlend.vtkImageBlend_SetStencilConnection_30(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x060160D3 RID: 90323
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBlend_SetStencilData_31(HandleRef pThis, HandleRef stencil);

		/// <summary>
		/// Set a stencil to apply when blending the data.
		/// </summary>
		// Token: 0x060160D4 RID: 90324 RVA: 0x001F0ED0 File Offset: 0x001EF0D0
		public void SetStencilData(vtkImageStencilData stencil)
		{
			vtkImageBlend.vtkImageBlend_SetStencilData_31(base.GetCppThis(), (stencil == null) ? default(HandleRef) : stencil.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018EE RID: 6382
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageBlend";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018EF RID: 6383
		public new static readonly string MRClassNameKey = "class vtkImageBlend";
	}
}
