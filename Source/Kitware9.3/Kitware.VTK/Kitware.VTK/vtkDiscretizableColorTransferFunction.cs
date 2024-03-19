using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDiscretizableColorTransferFunction
	/// </summary>
	/// <remarks>
	///    a combination of
	/// vtkColorTransferFunction and vtkLookupTable.
	///
	/// This is a cross between a vtkColorTransferFunction and a vtkLookupTable
	/// selectively combining the functionality of both. This class is a
	/// vtkColorTransferFunction allowing users to specify the RGB control points
	/// that control the color transfer function. At the same time, by setting
	/// \a Discretize to 1 (true), one can force the transfer function to only have
	/// \a NumberOfValues discrete colors.
	///
	/// When \a IndexedLookup is true, this class behaves differently. The annotated
	/// values are considered to the be only valid values for which entries in the
	/// color table should be returned. The colors for annotated values are those
	/// specified using \a AddIndexedColors. Typically, there must be at least as many
	/// indexed colors specified as the annotations. For backwards compatibility, if
	/// no indexed-colors are specified, the colors in the lookup \a Table are assigned
	/// to annotated values by taking the modulus of their index in the list
	/// of annotations. If a scalar value is not present in \a AnnotatedValues,
	/// then \a NanColor will be used.
	///
	/// One can set a scalar opacity function to map scalars to color types handling
	/// transparency (VTK_RGBA, VTK_LUMINANCE_ALPHA). Opacity mapping is off by
	/// default. Call EnableOpacityMappingOn() to handle mapping of alpha values.
	///
	/// NOTE: One must call Build() after making any changes to the points
	/// in the ColorTransferFunction to ensure that the discrete and non-discrete
	/// versions match up.
	/// </remarks>
	// Token: 0x020007DA RID: 2010
	public class vtkDiscretizableColorTransferFunction : vtkColorTransferFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014A0C RID: 84492 RVA: 0x001D35F3 File Offset: 0x001D17F3
		static vtkDiscretizableColorTransferFunction()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDiscretizableColorTransferFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiscretizableColorTransferFunction"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014A0D RID: 84493 RVA: 0x001D361B File Offset: 0x001D181B
		public vtkDiscretizableColorTransferFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014A0E RID: 84494
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscretizableColorTransferFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A0F RID: 84495 RVA: 0x001D362C File Offset: 0x001D182C
		public new static vtkDiscretizableColorTransferFunction New()
		{
			vtkDiscretizableColorTransferFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscretizableColorTransferFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A10 RID: 84496 RVA: 0x001D3680 File Offset: 0x001D1880
		public vtkDiscretizableColorTransferFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014A11 RID: 84497 RVA: 0x001D36C4 File Offset: 0x001D18C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014A12 RID: 84498
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_Build_01(HandleRef pThis);

		/// <summary>
		/// Generate discretized lookup table, if applicable.
		/// This method must be called after changes to the ColorTransferFunction
		/// otherwise the discretized version will be inconsistent with the
		/// non-discretized one.
		/// </summary>
		// Token: 0x06014A13 RID: 84499 RVA: 0x001D36CF File Offset: 0x001D18CF
		public override void Build()
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_Build_01(base.GetCppThis());
		}

		// Token: 0x06014A14 RID: 84500
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_DiscretizeOff_02(HandleRef pThis);

		/// <summary>
		/// Set if the values are to be mapped after discretization. The
		/// number of discrete values is set by using SetNumberOfValues().
		/// Not set by default, i.e. color value is determined by
		/// interpolating at the scalar value.
		/// </summary>
		// Token: 0x06014A15 RID: 84501 RVA: 0x001D36DE File Offset: 0x001D18DE
		public virtual void DiscretizeOff()
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_DiscretizeOff_02(base.GetCppThis());
		}

		// Token: 0x06014A16 RID: 84502
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_DiscretizeOn_03(HandleRef pThis);

		/// <summary>
		/// Set if the values are to be mapped after discretization. The
		/// number of discrete values is set by using SetNumberOfValues().
		/// Not set by default, i.e. color value is determined by
		/// interpolating at the scalar value.
		/// </summary>
		// Token: 0x06014A17 RID: 84503 RVA: 0x001D36ED File Offset: 0x001D18ED
		public virtual void DiscretizeOn()
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_DiscretizeOn_03(base.GetCppThis());
		}

		// Token: 0x06014A18 RID: 84504
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_EnableOpacityMappingOff_04(HandleRef pThis);

		/// <summary>
		/// Enable/disable the usage of the scalar opacity function.
		/// </summary>
		// Token: 0x06014A19 RID: 84505 RVA: 0x001D36FC File Offset: 0x001D18FC
		public virtual void EnableOpacityMappingOff()
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_EnableOpacityMappingOff_04(base.GetCppThis());
		}

		// Token: 0x06014A1A RID: 84506
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_EnableOpacityMappingOn_05(HandleRef pThis);

		/// <summary>
		/// Enable/disable the usage of the scalar opacity function.
		/// </summary>
		// Token: 0x06014A1B RID: 84507 RVA: 0x001D370B File Offset: 0x001D190B
		public virtual void EnableOpacityMappingOn()
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_EnableOpacityMappingOn_05(base.GetCppThis());
		}

		// Token: 0x06014A1C RID: 84508
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_GetColor_06(HandleRef pThis, double v, IntPtr rgb);

		/// <summary>
		/// Map one value through the lookup table and return the color as
		/// an RGB array of doubles between 0 and 1.
		/// </summary>
		// Token: 0x06014A1D RID: 84509 RVA: 0x001D371A File Offset: 0x001D191A
		public override void GetColor(double v, IntPtr rgb)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetColor_06(base.GetCppThis(), v, rgb);
		}

		// Token: 0x06014A1E RID: 84510
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscretizableColorTransferFunction_GetDiscretize_07(HandleRef pThis);

		/// <summary>
		/// Set if the values are to be mapped after discretization. The
		/// number of discrete values is set by using SetNumberOfValues().
		/// Not set by default, i.e. color value is determined by
		/// interpolating at the scalar value.
		/// </summary>
		// Token: 0x06014A1F RID: 84511 RVA: 0x001D372C File Offset: 0x001D192C
		public virtual int GetDiscretize()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetDiscretize_07(base.GetCppThis());
		}

		// Token: 0x06014A20 RID: 84512
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDiscretizableColorTransferFunction_GetEnableOpacityMapping_08(HandleRef pThis);

		/// <summary>
		/// Enable/disable the usage of the scalar opacity function.
		/// </summary>
		// Token: 0x06014A21 RID: 84513 RVA: 0x001D374C File Offset: 0x001D194C
		public virtual bool GetEnableOpacityMapping()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetEnableOpacityMapping_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06014A22 RID: 84514
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_GetIndexedColor_09(HandleRef pThis, long i, IntPtr rgba);

		/// <summary>
		/// Get the "indexed color" assigned to an index.
		///
		/// The index is used in \a IndexedLookup mode to assign colors to annotations (in the order
		/// the annotations were set).
		/// Subclasses must implement this and interpret how to treat the index.
		/// vtkLookupTable simply returns GetTableValue(\a index % \a this-&gt;GetNumberOfTableValues()).
		/// vtkColorTransferFunction returns the color associated with node \a index % \a this-&gt;GetSize().
		///
		/// Note that implementations *must* set the opacity (alpha) component of the color, even if they
		/// do not provide opacity values in their colormaps. In that case, alpha = 1 should be used.
		/// </summary>
		// Token: 0x06014A23 RID: 84515 RVA: 0x001D3772 File Offset: 0x001D1972
		public override void GetIndexedColor(long i, IntPtr rgba)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetIndexedColor_09(base.GetCppThis(), i, rgba);
		}

		// Token: 0x06014A24 RID: 84516
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDiscretizableColorTransferFunction_GetMTime_10(HandleRef pThis);

		/// <summary>
		/// Overridden to include the ScalarOpacityFunction's MTime.
		/// </summary>
		// Token: 0x06014A25 RID: 84517 RVA: 0x001D3784 File Offset: 0x001D1984
		public override ulong GetMTime()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetMTime_10(base.GetCppThis());
		}

		// Token: 0x06014A26 RID: 84518
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscretizableColorTransferFunction_GetNumberOfAvailableColors_11(HandleRef pThis);

		/// <summary>
		/// Get the number of available colors for mapping to.
		/// </summary>
		// Token: 0x06014A27 RID: 84519 RVA: 0x001D37A4 File Offset: 0x001D19A4
		public override long GetNumberOfAvailableColors()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetNumberOfAvailableColors_11(base.GetCppThis());
		}

		// Token: 0x06014A28 RID: 84520
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscretizableColorTransferFunction_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A29 RID: 84521 RVA: 0x001D37C4 File Offset: 0x001D19C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06014A2A RID: 84522
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscretizableColorTransferFunction_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A2B RID: 84523 RVA: 0x001D37E4 File Offset: 0x001D19E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06014A2C RID: 84524
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDiscretizableColorTransferFunction_GetNumberOfIndexedColors_14(HandleRef pThis);

		/// <summary>
		/// Set the number of indexed colors. These are used when IndexedLookup is
		/// true. If no indexed colors are specified, for backwards compatibility,
		/// this class reverts to using the RGBPoints for colors.
		/// </summary>
		// Token: 0x06014A2D RID: 84525 RVA: 0x001D3800 File Offset: 0x001D1A00
		public uint GetNumberOfIndexedColors()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetNumberOfIndexedColors_14(base.GetCppThis());
		}

		// Token: 0x06014A2E RID: 84526
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscretizableColorTransferFunction_GetNumberOfValues_15(HandleRef pThis);

		/// <summary>
		/// Set the number of values i.e. colors to be generated in the
		/// discrete lookup table. This has no effect if Discretize is off.
		/// The default is 256.
		/// </summary>
		// Token: 0x06014A2F RID: 84527 RVA: 0x001D3820 File Offset: 0x001D1A20
		public virtual long GetNumberOfValues()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetNumberOfValues_15(base.GetCppThis());
		}

		// Token: 0x06014A30 RID: 84528
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiscretizableColorTransferFunction_GetOpacity_16(HandleRef pThis, double v);

		/// <summary>
		/// Return the opacity of a given scalar.
		/// </summary>
		// Token: 0x06014A31 RID: 84529 RVA: 0x001D3840 File Offset: 0x001D1A40
		public override double GetOpacity(double v)
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetOpacity_16(base.GetCppThis(), v);
		}

		// Token: 0x06014A32 RID: 84530
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscretizableColorTransferFunction_GetScalarOpacityFunction_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the opacity function to use.
		/// </summary>
		// Token: 0x06014A33 RID: 84531 RVA: 0x001D3860 File Offset: 0x001D1A60
		public virtual vtkPiecewiseFunction GetScalarOpacityFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetScalarOpacityFunction_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06014A34 RID: 84532
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscretizableColorTransferFunction_GetUseLogScale_18(HandleRef pThis);

		/// <summary>
		/// Get/Set if log scale must be used while mapping scalars
		/// to colors. The default is 0.
		/// </summary>
		// Token: 0x06014A35 RID: 84533 RVA: 0x001D38D0 File Offset: 0x001D1AD0
		public virtual int GetUseLogScale()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetUseLogScale_18(base.GetCppThis());
		}

		// Token: 0x06014A36 RID: 84534
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscretizableColorTransferFunction_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A37 RID: 84535 RVA: 0x001D38F0 File Offset: 0x001D1AF0
		public override int IsA(string type)
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x06014A38 RID: 84536
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscretizableColorTransferFunction_IsOpaque_20(HandleRef pThis);

		/// <summary>
		/// Returns the negation of \a EnableOpacityMapping.
		/// </summary>
		// Token: 0x06014A39 RID: 84537 RVA: 0x001D3910 File Offset: 0x001D1B10
		public override int IsOpaque()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_IsOpaque_20(base.GetCppThis());
		}

		// Token: 0x06014A3A RID: 84538
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscretizableColorTransferFunction_IsOpaque_21(HandleRef pThis, HandleRef scalars, int colorMode, int component);

		/// <summary>
		/// Returns the negation of \a EnableOpacityMapping.
		/// </summary>
		// Token: 0x06014A3B RID: 84539 RVA: 0x001D3930 File Offset: 0x001D1B30
		public override int IsOpaque(vtkAbstractArray scalars, int colorMode, int component)
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_IsOpaque_21(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), colorMode, component);
		}

		// Token: 0x06014A3C RID: 84540
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscretizableColorTransferFunction_IsOpaque_22(HandleRef pThis, HandleRef scalars, int colorMode, int component, HandleRef ghosts, byte ghostsToSkip);

		/// <summary>
		/// Returns the negation of \a EnableOpacityMapping.
		/// </summary>
		// Token: 0x06014A3D RID: 84541 RVA: 0x001D3968 File Offset: 0x001D1B68
		public override int IsOpaque(vtkAbstractArray scalars, int colorMode, int component, vtkUnsignedCharArray ghosts, byte ghostsToSkip)
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_IsOpaque_22(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), colorMode, component, (ghosts == null) ? default(HandleRef) : ghosts.GetCppThis(), ghostsToSkip);
		}

		// Token: 0x06014A3E RID: 84542
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscretizableColorTransferFunction_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A3F RID: 84543 RVA: 0x001D39B8 File Offset: 0x001D1BB8
		public new static int IsTypeOf(string type)
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_IsTypeOf_23(type);
		}

		// Token: 0x06014A40 RID: 84544
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_MapScalarsThroughTable2_24(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

		/// <summary>
		/// Map a set of scalars through the lookup table.
		/// Overridden to map the opacity value. This internal method is inherited
		/// from vtkScalarsToColors and should never be called directly.
		/// </summary>
		// Token: 0x06014A41 RID: 84545 RVA: 0x001D39D2 File Offset: 0x001D1BD2
		public override void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_MapScalarsThroughTable2_24(base.GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
		}

		// Token: 0x06014A42 RID: 84546
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscretizableColorTransferFunction_MapValue_25(HandleRef pThis, double v);

		/// <summary>
		/// Map one value through the lookup table and return a color defined
		/// as a RGBA unsigned char tuple (4 bytes).
		/// </summary>
		// Token: 0x06014A43 RID: 84547 RVA: 0x001D39EC File Offset: 0x001D1BEC
		public override IntPtr MapValue(double v)
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_MapValue_25(base.GetCppThis(), v);
		}

		// Token: 0x06014A44 RID: 84548
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscretizableColorTransferFunction_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A45 RID: 84549 RVA: 0x001D3A0C File Offset: 0x001D1C0C
		public new vtkDiscretizableColorTransferFunction NewInstance()
		{
			vtkDiscretizableColorTransferFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscretizableColorTransferFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014A46 RID: 84550
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscretizableColorTransferFunction_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A47 RID: 84551 RVA: 0x001D3A68 File Offset: 0x001D1C68
		public new static vtkDiscretizableColorTransferFunction SafeDownCast(vtkObjectBase o)
		{
			vtkDiscretizableColorTransferFunction vtkDiscretizableColorTransferFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDiscretizableColorTransferFunction = (vtkDiscretizableColorTransferFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDiscretizableColorTransferFunction.Register(null);
				}
			}
			return vtkDiscretizableColorTransferFunction;
		}

		// Token: 0x06014A48 RID: 84552
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetAlpha_29(HandleRef pThis, double alpha);

		/// <summary>
		/// Specify an additional opacity (alpha) value to blend with. Values
		/// != 1 modify the resulting color consistent with the requested
		/// form of the output. This is typically used by an actor in order to
		/// blend its opacity.
		/// Overridden to pass the alpha to the internal vtkLookupTable.
		/// </summary>
		// Token: 0x06014A49 RID: 84553 RVA: 0x001D3AE7 File Offset: 0x001D1CE7
		public override void SetAlpha(double alpha)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetAlpha_29(base.GetCppThis(), alpha);
		}

		// Token: 0x06014A4A RID: 84554
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetDiscretize_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set if the values are to be mapped after discretization. The
		/// number of discrete values is set by using SetNumberOfValues().
		/// Not set by default, i.e. color value is determined by
		/// interpolating at the scalar value.
		/// </summary>
		// Token: 0x06014A4B RID: 84555 RVA: 0x001D3AF7 File Offset: 0x001D1CF7
		public virtual void SetDiscretize(int _arg)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetDiscretize_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06014A4C RID: 84556
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetEnableOpacityMapping_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable the usage of the scalar opacity function.
		/// </summary>
		// Token: 0x06014A4D RID: 84557 RVA: 0x001D3B07 File Offset: 0x001D1D07
		public virtual void SetEnableOpacityMapping(bool _arg)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetEnableOpacityMapping_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06014A4E RID: 84558
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetIndexedColor_32(HandleRef pThis, uint index, double r, double g, double b, double a);

		/// <summary>
		/// Add colors to use when \a IndexedLookup is true.
		/// \a SetIndexedColor() will automatically call
		/// SetNumberOfIndexedColors(index+1) if the current number of indexed colors
		/// is not sufficient for the specified index and all will be initialized to
		/// the RGBA/RGB values passed to this call.
		/// </summary>
		// Token: 0x06014A4F RID: 84559 RVA: 0x001D3B1F File Offset: 0x001D1D1F
		public void SetIndexedColor(uint index, double r, double g, double b, double a)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetIndexedColor_32(base.GetCppThis(), index, r, g, b, a);
		}

		// Token: 0x06014A50 RID: 84560
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetIndexedColorRGB_33(HandleRef pThis, uint index, IntPtr rgb);

		/// <summary>
		/// Add colors to use when \a IndexedLookup is true.
		/// \a SetIndexedColor() will automatically call
		/// SetNumberOfIndexedColors(index+1) if the current number of indexed colors
		/// is not sufficient for the specified index and all will be initialized to
		/// the RGBA/RGB values passed to this call.
		/// </summary>
		// Token: 0x06014A51 RID: 84561 RVA: 0x001D3B35 File Offset: 0x001D1D35
		public void SetIndexedColorRGB(uint index, IntPtr rgb)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetIndexedColorRGB_33(base.GetCppThis(), index, rgb);
		}

		// Token: 0x06014A52 RID: 84562
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetIndexedColorRGBA_34(HandleRef pThis, uint index, IntPtr rgba);

		/// <summary>
		/// Add colors to use when \a IndexedLookup is true.
		/// \a SetIndexedColor() will automatically call
		/// SetNumberOfIndexedColors(index+1) if the current number of indexed colors
		/// is not sufficient for the specified index and all will be initialized to
		/// the RGBA/RGB values passed to this call.
		/// </summary>
		// Token: 0x06014A53 RID: 84563 RVA: 0x001D3B46 File Offset: 0x001D1D46
		public void SetIndexedColorRGBA(uint index, IntPtr rgba)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetIndexedColorRGBA_34(base.GetCppThis(), index, rgba);
		}

		// Token: 0x06014A54 RID: 84564
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetNanColor_35(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set the color to use when a NaN (not a number) is encountered.  This is an
		/// RGB 3-tuple color of doubles in the range [0, 1].
		/// Overridden to pass the NanColor to the internal vtkLookupTable.
		/// </summary>
		// Token: 0x06014A55 RID: 84565 RVA: 0x001D3B57 File Offset: 0x001D1D57
		public override void SetNanColor(double r, double g, double b)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetNanColor_35(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06014A56 RID: 84566
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetNanColor_36(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Set the color to use when a NaN (not a number) is encountered.  This is an
		/// RGB 3-tuple color of doubles in the range [0, 1].
		/// Overridden to pass the NanColor to the internal vtkLookupTable.
		/// </summary>
		// Token: 0x06014A57 RID: 84567 RVA: 0x001D3B69 File Offset: 0x001D1D69
		public override void SetNanColor(IntPtr rgb)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetNanColor_36(base.GetCppThis(), rgb);
		}

		// Token: 0x06014A58 RID: 84568
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetNanOpacity_37(HandleRef pThis, double a);

		/// <summary>
		/// Set the opacity to use when a NaN (not a number) is encountered.  This is an
		/// double in the range [0, 1].
		/// Overridden to pass the NanOpacity to the internal vtkLookupTable.
		/// </summary>
		// Token: 0x06014A59 RID: 84569 RVA: 0x001D3B79 File Offset: 0x001D1D79
		public override void SetNanOpacity(double a)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetNanOpacity_37(base.GetCppThis(), a);
		}

		// Token: 0x06014A5A RID: 84570
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetNumberOfIndexedColors_38(HandleRef pThis, uint count);

		/// <summary>
		/// Set the number of indexed colors. These are used when IndexedLookup is
		/// true. If no indexed colors are specified, for backwards compatibility,
		/// this class reverts to using the RGBPoints for colors.
		/// </summary>
		// Token: 0x06014A5B RID: 84571 RVA: 0x001D3B89 File Offset: 0x001D1D89
		public void SetNumberOfIndexedColors(uint count)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetNumberOfIndexedColors_38(base.GetCppThis(), count);
		}

		// Token: 0x06014A5C RID: 84572
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetNumberOfValues_39(HandleRef pThis, long _arg);

		/// <summary>
		/// Set the number of values i.e. colors to be generated in the
		/// discrete lookup table. This has no effect if Discretize is off.
		/// The default is 256.
		/// </summary>
		// Token: 0x06014A5D RID: 84573 RVA: 0x001D3B99 File Offset: 0x001D1D99
		public virtual void SetNumberOfValues(long _arg)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetNumberOfValues_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06014A5E RID: 84574
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetScalarOpacityFunction_40(HandleRef pThis, HandleRef function);

		/// <summary>
		/// Set/get the opacity function to use.
		/// </summary>
		// Token: 0x06014A5F RID: 84575 RVA: 0x001D3BAC File Offset: 0x001D1DAC
		public virtual void SetScalarOpacityFunction(vtkPiecewiseFunction function)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetScalarOpacityFunction_40(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		// Token: 0x06014A60 RID: 84576
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscretizableColorTransferFunction_SetUseLogScale_41(HandleRef pThis, int useLogScale);

		/// <summary>
		/// Get/Set if log scale must be used while mapping scalars
		/// to colors. The default is 0.
		/// </summary>
		// Token: 0x06014A61 RID: 84577 RVA: 0x001D3BDB File Offset: 0x001D1DDB
		public virtual void SetUseLogScale(int useLogScale)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetUseLogScale_41(base.GetCppThis(), useLogScale);
		}

		// Token: 0x06014A62 RID: 84578
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscretizableColorTransferFunction_UsingLogScale_42(HandleRef pThis);

		/// <summary>
		/// This should return 1 if the subclass is using log scale for
		/// mapping scalars to colors.
		/// </summary>
		// Token: 0x06014A63 RID: 84579 RVA: 0x001D3BEC File Offset: 0x001D1DEC
		public override int UsingLogScale()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_UsingLogScale_42(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017DA RID: 6106
		public new const string MRFullTypeName = "Kitware.VTK.vtkDiscretizableColorTransferFunction";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017DB RID: 6107
		public new static readonly string MRClassNameKey = "class vtkDiscretizableColorTransferFunction";
	}
}
