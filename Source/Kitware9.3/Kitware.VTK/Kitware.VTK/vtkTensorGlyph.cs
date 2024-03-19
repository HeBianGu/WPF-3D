using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTensorGlyph
	/// </summary>
	/// <remarks>
	///    scale and orient glyph(s) according to eigenvalues and eigenvectors of symmetrical part
	/// of tensor
	///
	/// vtkTensorGlyph is a filter that copies a geometric representation
	/// (specified as polygonal data) to every input point. The geometric
	/// representation, or glyph, can be scaled and/or rotated according to
	/// the tensor at the input point. Scaling and rotation is controlled
	/// by the eigenvalues/eigenvectors of the symmetrical part of the tensor
	/// as follows:
	/// For each tensor, the eigenvalues (and associated eigenvectors) are sorted
	/// to determine the major, medium, and minor eigenvalues/eigenvectors.
	/// The eigenvalue decomposition only makes sense for symmetric tensors,
	/// hence the need to only consider the symmetric part of the tensor, which is
	/// 1/2 (T + T.transposed()).
	///
	/// If the boolean variable ThreeGlyphs is not set the major eigenvalue
	/// scales the glyph in the x-direction, the medium in the y-direction,
	/// and the minor in the z-direction. Then, the glyph is rotated so
	/// that the glyph's local x-axis lies along the major eigenvector,
	/// y-axis along the medium eigenvector, and z-axis along the minor.
	///
	/// If the boolean variable ThreeGlyphs is set three glyphs are produced,
	/// each of them oriented along an eigenvector and scaled according to the
	/// corresponding eigenvector.
	///
	/// If the boolean variable Symmetric is set each glyph is mirrored (2 or 6
	/// glyphs will be produced)
	///
	/// The x-axis of the source glyph will correspond to the eigenvector
	/// on output. Point (0,0,0) in the source will be placed in the data point.
	/// Variable Length will normally correspond to the distance from the
	/// origin to the tip of the source glyph along the x-axis,
	/// but can be changed to produce other results when Symmetric is on,
	/// e.g. glyphs that do not touch or that overlap.
	///
	/// Please note that when Symmetric is false it will generally be better
	/// to place the source glyph from (-0.5,0,0) to (0.5,0,0), i.e. centered
	/// at the origin. When symmetric is true the placement from (0,0,0) to
	/// (1,0,0) will generally be more convenient.
	///
	/// A scale factor is provided to control the amount of scaling. Also, you
	/// can turn off scaling completely if desired. The boolean variable
	/// ClampScaling controls the maximum scaling (in conjunction with
	/// MaxScaleFactor.) This is useful in certain applications where
	/// singularities or large order of magnitude differences exist in
	/// the eigenvalues.
	///
	/// If the boolean variable ColorGlyphs is set to true the glyphs are
	/// colored.  The glyphs can be colored using the input scalars
	/// (SetColorModeToScalars), which is the default, or colored using the
	/// eigenvalues (SetColorModeToEigenvalues).
	///
	/// Another instance variable, ExtractEigenvalues, has been provided to
	/// control extraction of eigenvalues/eigenvectors. If this boolean is
	/// false, then eigenvalues/eigenvectors are not extracted, and the
	/// columns of the tensor are taken as the eigenvectors (the norm of
	/// column, always positive, is the eigenvalue).  This allows
	/// additional capability over the vtkGlyph3D object. That is, the
	/// glyph can be oriented in three directions instead of one.
	///
	/// @par Thanks:
	/// Thanks to Jose Paulo Moitinho de Almeida for enhancements.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGlyph3D vtkPointLoad vtkHyperStreamline
	/// </seealso>
	// Token: 0x020009B2 RID: 2482
	public class vtkTensorGlyph : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019ED9 RID: 106201 RVA: 0x0023F92D File Offset: 0x0023DB2D
		static vtkTensorGlyph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTensorGlyph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensorGlyph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019EDA RID: 106202 RVA: 0x0023F955 File Offset: 0x0023DB55
		public vtkTensorGlyph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019EDB RID: 106203
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorGlyph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.Construct object with scaling on and scale factor
		/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
		/// data, and logarithmic scaling is turned off.
		/// </summary>
		// Token: 0x06019EDC RID: 106204 RVA: 0x0023F964 File Offset: 0x0023DB64
		public new static vtkTensorGlyph New()
		{
			vtkTensorGlyph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorGlyph.vtkTensorGlyph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorGlyph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.Construct object with scaling on and scale factor
		/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
		/// data, and logarithmic scaling is turned off.
		/// </summary>
		// Token: 0x06019EDD RID: 106205 RVA: 0x0023F9B8 File Offset: 0x0023DBB8
		public vtkTensorGlyph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTensorGlyph.vtkTensorGlyph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019EDE RID: 106206 RVA: 0x0023F9FC File Offset: 0x0023DBFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019EDF RID: 106207
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_ClampScalingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off scalar clamping. If scalar clamping is on, the ivar
		/// MaxScaleFactor is used to control the maximum scale factor. (This is
		/// useful to prevent uncontrolled scaling near singularities.)
		/// </summary>
		// Token: 0x06019EE0 RID: 106208 RVA: 0x0023FA07 File Offset: 0x0023DC07
		public virtual void ClampScalingOff()
		{
			vtkTensorGlyph.vtkTensorGlyph_ClampScalingOff_01(base.GetCppThis());
		}

		// Token: 0x06019EE1 RID: 106209
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_ClampScalingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off scalar clamping. If scalar clamping is on, the ivar
		/// MaxScaleFactor is used to control the maximum scale factor. (This is
		/// useful to prevent uncontrolled scaling near singularities.)
		/// </summary>
		// Token: 0x06019EE2 RID: 106210 RVA: 0x0023FA16 File Offset: 0x0023DC16
		public virtual void ClampScalingOn()
		{
			vtkTensorGlyph.vtkTensorGlyph_ClampScalingOn_02(base.GetCppThis());
		}

		// Token: 0x06019EE3 RID: 106211
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_ColorGlyphsOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off coloring of glyph with input scalar data or
		/// eigenvalues. If false, or input scalar data not present, then the
		/// scalars from the source object are passed through the filter.
		/// </summary>
		// Token: 0x06019EE4 RID: 106212 RVA: 0x0023FA25 File Offset: 0x0023DC25
		public virtual void ColorGlyphsOff()
		{
			vtkTensorGlyph.vtkTensorGlyph_ColorGlyphsOff_03(base.GetCppThis());
		}

		// Token: 0x06019EE5 RID: 106213
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_ColorGlyphsOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off coloring of glyph with input scalar data or
		/// eigenvalues. If false, or input scalar data not present, then the
		/// scalars from the source object are passed through the filter.
		/// </summary>
		// Token: 0x06019EE6 RID: 106214 RVA: 0x0023FA34 File Offset: 0x0023DC34
		public virtual void ColorGlyphsOn()
		{
			vtkTensorGlyph.vtkTensorGlyph_ColorGlyphsOn_04(base.GetCppThis());
		}

		// Token: 0x06019EE7 RID: 106215
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_ExtractEigenvaluesOff_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off extraction of eigenvalues from tensor.
		/// </summary>
		// Token: 0x06019EE8 RID: 106216 RVA: 0x0023FA43 File Offset: 0x0023DC43
		public virtual void ExtractEigenvaluesOff()
		{
			vtkTensorGlyph.vtkTensorGlyph_ExtractEigenvaluesOff_05(base.GetCppThis());
		}

		// Token: 0x06019EE9 RID: 106217
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_ExtractEigenvaluesOn_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off extraction of eigenvalues from tensor.
		/// </summary>
		// Token: 0x06019EEA RID: 106218 RVA: 0x0023FA52 File Offset: 0x0023DC52
		public virtual void ExtractEigenvaluesOn()
		{
			vtkTensorGlyph.vtkTensorGlyph_ExtractEigenvaluesOn_06(base.GetCppThis());
		}

		// Token: 0x06019EEB RID: 106219
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorGlyph_GetClampScaling_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off scalar clamping. If scalar clamping is on, the ivar
		/// MaxScaleFactor is used to control the maximum scale factor. (This is
		/// useful to prevent uncontrolled scaling near singularities.)
		/// </summary>
		// Token: 0x06019EEC RID: 106220 RVA: 0x0023FA64 File Offset: 0x0023DC64
		public virtual int GetClampScaling()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetClampScaling_07(base.GetCppThis());
		}

		// Token: 0x06019EED RID: 106221
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorGlyph_GetColorGlyphs_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off coloring of glyph with input scalar data or
		/// eigenvalues. If false, or input scalar data not present, then the
		/// scalars from the source object are passed through the filter.
		/// </summary>
		// Token: 0x06019EEE RID: 106222 RVA: 0x0023FA84 File Offset: 0x0023DC84
		public virtual int GetColorGlyphs()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetColorGlyphs_08(base.GetCppThis());
		}

		// Token: 0x06019EEF RID: 106223
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorGlyph_GetColorMode_09(HandleRef pThis);

		/// <summary>
		/// Set the color mode to be used for the glyphs.  This can be set to
		/// use the input scalars (default) or to use the eigenvalues at the
		/// point.  If ThreeGlyphs is set and the eigenvalues are chosen for
		/// coloring then each glyph is colored by the corresponding
		/// eigenvalue and if not set the color corresponding to the largest
		/// eigenvalue is chosen.  The recognized values are:
		/// COLOR_BY_SCALARS = 0 (default)
		/// COLOR_BY_EIGENVALUES = 1
		/// </summary>
		// Token: 0x06019EF0 RID: 106224 RVA: 0x0023FAA4 File Offset: 0x0023DCA4
		public virtual int GetColorMode()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetColorMode_09(base.GetCppThis());
		}

		// Token: 0x06019EF1 RID: 106225
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorGlyph_GetColorModeMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set the color mode to be used for the glyphs.  This can be set to
		/// use the input scalars (default) or to use the eigenvalues at the
		/// point.  If ThreeGlyphs is set and the eigenvalues are chosen for
		/// coloring then each glyph is colored by the corresponding
		/// eigenvalue and if not set the color corresponding to the largest
		/// eigenvalue is chosen.  The recognized values are:
		/// COLOR_BY_SCALARS = 0 (default)
		/// COLOR_BY_EIGENVALUES = 1
		/// </summary>
		// Token: 0x06019EF2 RID: 106226 RVA: 0x0023FAC4 File Offset: 0x0023DCC4
		public virtual int GetColorModeMaxValue()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetColorModeMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06019EF3 RID: 106227
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorGlyph_GetColorModeMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set the color mode to be used for the glyphs.  This can be set to
		/// use the input scalars (default) or to use the eigenvalues at the
		/// point.  If ThreeGlyphs is set and the eigenvalues are chosen for
		/// coloring then each glyph is colored by the corresponding
		/// eigenvalue and if not set the color corresponding to the largest
		/// eigenvalue is chosen.  The recognized values are:
		/// COLOR_BY_SCALARS = 0 (default)
		/// COLOR_BY_EIGENVALUES = 1
		/// </summary>
		// Token: 0x06019EF4 RID: 106228 RVA: 0x0023FAE4 File Offset: 0x0023DCE4
		public virtual int GetColorModeMinValue()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetColorModeMinValue_11(base.GetCppThis());
		}

		// Token: 0x06019EF5 RID: 106229
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorGlyph_GetExtractEigenvalues_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off extraction of eigenvalues from tensor.
		/// </summary>
		// Token: 0x06019EF6 RID: 106230 RVA: 0x0023FB04 File Offset: 0x0023DD04
		public virtual int GetExtractEigenvalues()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetExtractEigenvalues_12(base.GetCppThis());
		}

		// Token: 0x06019EF7 RID: 106231
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTensorGlyph_GetLength_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance, along x, from the origin to the end of the
		/// source glyph. It is used to draw the symmetric glyphs.
		/// </summary>
		// Token: 0x06019EF8 RID: 106232 RVA: 0x0023FB24 File Offset: 0x0023DD24
		public virtual double GetLength()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetLength_13(base.GetCppThis());
		}

		// Token: 0x06019EF9 RID: 106233
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTensorGlyph_GetMaxScaleFactor_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum allowable scale factor. This value is compared to the
		/// combination of the scale factor times the eigenvalue. If less, the scale
		/// factor is reset to the MaxScaleFactor. The boolean ClampScaling has to
		/// be "on" for this to work.
		/// </summary>
		// Token: 0x06019EFA RID: 106234 RVA: 0x0023FB44 File Offset: 0x0023DD44
		public virtual double GetMaxScaleFactor()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetMaxScaleFactor_14(base.GetCppThis());
		}

		// Token: 0x06019EFB RID: 106235
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorGlyph_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.Construct object with scaling on and scale factor
		/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
		/// data, and logarithmic scaling is turned off.
		/// </summary>
		// Token: 0x06019EFC RID: 106236 RVA: 0x0023FB64 File Offset: 0x0023DD64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x06019EFD RID: 106237
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorGlyph_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.Construct object with scaling on and scale factor
		/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
		/// data, and logarithmic scaling is turned off.
		/// </summary>
		// Token: 0x06019EFE RID: 106238 RVA: 0x0023FB84 File Offset: 0x0023DD84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x06019EFF RID: 106239
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTensorGlyph_GetScaleFactor_17(HandleRef pThis);

		/// <summary>
		/// Specify scale factor to scale object by. (Scale factor always affects
		/// output even if scaling is off.)
		/// </summary>
		// Token: 0x06019F00 RID: 106240 RVA: 0x0023FBA0 File Offset: 0x0023DDA0
		public virtual double GetScaleFactor()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetScaleFactor_17(base.GetCppThis());
		}

		// Token: 0x06019F01 RID: 106241
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorGlyph_GetScaling_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off scaling of glyph with eigenvalues.
		/// </summary>
		// Token: 0x06019F02 RID: 106242 RVA: 0x0023FBC0 File Offset: 0x0023DDC0
		public virtual int GetScaling()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetScaling_18(base.GetCppThis());
		}

		// Token: 0x06019F03 RID: 106243
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorGlyph_GetSource_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the geometry to copy to each point.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetSourceConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x06019F04 RID: 106244 RVA: 0x0023FBE0 File Offset: 0x0023DDE0
		public vtkPolyData GetSource()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorGlyph.vtkTensorGlyph_GetSource_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019F05 RID: 106245
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorGlyph_GetSymmetric_20(HandleRef pThis);

		/// <summary>
		/// Turn on/off drawing a mirror of each glyph
		/// </summary>
		// Token: 0x06019F06 RID: 106246 RVA: 0x0023FC50 File Offset: 0x0023DE50
		public virtual int GetSymmetric()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetSymmetric_20(base.GetCppThis());
		}

		// Token: 0x06019F07 RID: 106247
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorGlyph_GetThreeGlyphs_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off drawing three glyphs
		/// </summary>
		// Token: 0x06019F08 RID: 106248 RVA: 0x0023FC70 File Offset: 0x0023DE70
		public virtual int GetThreeGlyphs()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetThreeGlyphs_21(base.GetCppThis());
		}

		// Token: 0x06019F09 RID: 106249
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorGlyph_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.Construct object with scaling on and scale factor
		/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
		/// data, and logarithmic scaling is turned off.
		/// </summary>
		// Token: 0x06019F0A RID: 106250 RVA: 0x0023FC90 File Offset: 0x0023DE90
		public override int IsA(string type)
		{
			return vtkTensorGlyph.vtkTensorGlyph_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06019F0B RID: 106251
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorGlyph_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.Construct object with scaling on and scale factor
		/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
		/// data, and logarithmic scaling is turned off.
		/// </summary>
		// Token: 0x06019F0C RID: 106252 RVA: 0x0023FCB0 File Offset: 0x0023DEB0
		public new static int IsTypeOf(string type)
		{
			return vtkTensorGlyph.vtkTensorGlyph_IsTypeOf_23(type);
		}

		// Token: 0x06019F0D RID: 106253
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorGlyph_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.Construct object with scaling on and scale factor
		/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
		/// data, and logarithmic scaling is turned off.
		/// </summary>
		// Token: 0x06019F0E RID: 106254 RVA: 0x0023FCCC File Offset: 0x0023DECC
		public new vtkTensorGlyph NewInstance()
		{
			vtkTensorGlyph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorGlyph.vtkTensorGlyph_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorGlyph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019F0F RID: 106255
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorGlyph_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.Construct object with scaling on and scale factor
		/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
		/// data, and logarithmic scaling is turned off.
		/// </summary>
		// Token: 0x06019F10 RID: 106256 RVA: 0x0023FD28 File Offset: 0x0023DF28
		public new static vtkTensorGlyph SafeDownCast(vtkObjectBase o)
		{
			vtkTensorGlyph vtkTensorGlyph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorGlyph.vtkTensorGlyph_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTensorGlyph = (vtkTensorGlyph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTensorGlyph.Register(null);
				}
			}
			return vtkTensorGlyph;
		}

		// Token: 0x06019F11 RID: 106257
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_ScalingOff_27(HandleRef pThis);

		/// <summary>
		/// Turn on/off scaling of glyph with eigenvalues.
		/// </summary>
		// Token: 0x06019F12 RID: 106258 RVA: 0x0023FDA7 File Offset: 0x0023DFA7
		public virtual void ScalingOff()
		{
			vtkTensorGlyph.vtkTensorGlyph_ScalingOff_27(base.GetCppThis());
		}

		// Token: 0x06019F13 RID: 106259
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_ScalingOn_28(HandleRef pThis);

		/// <summary>
		/// Turn on/off scaling of glyph with eigenvalues.
		/// </summary>
		// Token: 0x06019F14 RID: 106260 RVA: 0x0023FDB6 File Offset: 0x0023DFB6
		public virtual void ScalingOn()
		{
			vtkTensorGlyph.vtkTensorGlyph_ScalingOn_28(base.GetCppThis());
		}

		// Token: 0x06019F15 RID: 106261
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetClampScaling_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off scalar clamping. If scalar clamping is on, the ivar
		/// MaxScaleFactor is used to control the maximum scale factor. (This is
		/// useful to prevent uncontrolled scaling near singularities.)
		/// </summary>
		// Token: 0x06019F16 RID: 106262 RVA: 0x0023FDC5 File Offset: 0x0023DFC5
		public virtual void SetClampScaling(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetClampScaling_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F17 RID: 106263
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetColorGlyphs_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off coloring of glyph with input scalar data or
		/// eigenvalues. If false, or input scalar data not present, then the
		/// scalars from the source object are passed through the filter.
		/// </summary>
		// Token: 0x06019F18 RID: 106264 RVA: 0x0023FDD5 File Offset: 0x0023DFD5
		public virtual void SetColorGlyphs(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetColorGlyphs_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F19 RID: 106265
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetColorMode_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the color mode to be used for the glyphs.  This can be set to
		/// use the input scalars (default) or to use the eigenvalues at the
		/// point.  If ThreeGlyphs is set and the eigenvalues are chosen for
		/// coloring then each glyph is colored by the corresponding
		/// eigenvalue and if not set the color corresponding to the largest
		/// eigenvalue is chosen.  The recognized values are:
		/// COLOR_BY_SCALARS = 0 (default)
		/// COLOR_BY_EIGENVALUES = 1
		/// </summary>
		// Token: 0x06019F1A RID: 106266 RVA: 0x0023FDE5 File Offset: 0x0023DFE5
		public virtual void SetColorMode(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetColorMode_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F1B RID: 106267
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetColorModeToEigenvalues_32(HandleRef pThis);

		/// <summary>
		/// Set the color mode to be used for the glyphs.  This can be set to
		/// use the input scalars (default) or to use the eigenvalues at the
		/// point.  If ThreeGlyphs is set and the eigenvalues are chosen for
		/// coloring then each glyph is colored by the corresponding
		/// eigenvalue and if not set the color corresponding to the largest
		/// eigenvalue is chosen.  The recognized values are:
		/// COLOR_BY_SCALARS = 0 (default)
		/// COLOR_BY_EIGENVALUES = 1
		/// </summary>
		// Token: 0x06019F1C RID: 106268 RVA: 0x0023FDF5 File Offset: 0x0023DFF5
		public void SetColorModeToEigenvalues()
		{
			vtkTensorGlyph.vtkTensorGlyph_SetColorModeToEigenvalues_32(base.GetCppThis());
		}

		// Token: 0x06019F1D RID: 106269
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetColorModeToScalars_33(HandleRef pThis);

		/// <summary>
		/// Set the color mode to be used for the glyphs.  This can be set to
		/// use the input scalars (default) or to use the eigenvalues at the
		/// point.  If ThreeGlyphs is set and the eigenvalues are chosen for
		/// coloring then each glyph is colored by the corresponding
		/// eigenvalue and if not set the color corresponding to the largest
		/// eigenvalue is chosen.  The recognized values are:
		/// COLOR_BY_SCALARS = 0 (default)
		/// COLOR_BY_EIGENVALUES = 1
		/// </summary>
		// Token: 0x06019F1E RID: 106270 RVA: 0x0023FE04 File Offset: 0x0023E004
		public void SetColorModeToScalars()
		{
			vtkTensorGlyph.vtkTensorGlyph_SetColorModeToScalars_33(base.GetCppThis());
		}

		// Token: 0x06019F1F RID: 106271
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetExtractEigenvalues_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off extraction of eigenvalues from tensor.
		/// </summary>
		// Token: 0x06019F20 RID: 106272 RVA: 0x0023FE13 File Offset: 0x0023E013
		public virtual void SetExtractEigenvalues(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetExtractEigenvalues_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F21 RID: 106273
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetLength_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the distance, along x, from the origin to the end of the
		/// source glyph. It is used to draw the symmetric glyphs.
		/// </summary>
		// Token: 0x06019F22 RID: 106274 RVA: 0x0023FE23 File Offset: 0x0023E023
		public virtual void SetLength(double _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetLength_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F23 RID: 106275
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetMaxScaleFactor_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the maximum allowable scale factor. This value is compared to the
		/// combination of the scale factor times the eigenvalue. If less, the scale
		/// factor is reset to the MaxScaleFactor. The boolean ClampScaling has to
		/// be "on" for this to work.
		/// </summary>
		// Token: 0x06019F24 RID: 106276 RVA: 0x0023FE33 File Offset: 0x0023E033
		public virtual void SetMaxScaleFactor(double _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetMaxScaleFactor_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F25 RID: 106277
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetScaleFactor_37(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify scale factor to scale object by. (Scale factor always affects
		/// output even if scaling is off.)
		/// </summary>
		// Token: 0x06019F26 RID: 106278 RVA: 0x0023FE43 File Offset: 0x0023E043
		public virtual void SetScaleFactor(double _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetScaleFactor_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F27 RID: 106279
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetScaling_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off scaling of glyph with eigenvalues.
		/// </summary>
		// Token: 0x06019F28 RID: 106280 RVA: 0x0023FE53 File Offset: 0x0023E053
		public virtual void SetScaling(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetScaling_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F29 RID: 106281
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetSourceConnection_39(HandleRef pThis, int id, HandleRef algOutput);

		/// <summary>
		/// Specify a source object at a specified table location. New style.
		/// Source connection is stored in port 1. This method is equivalent
		/// to SetInputConnection(1, id, outputPort).
		/// </summary>
		// Token: 0x06019F2A RID: 106282 RVA: 0x0023FE64 File Offset: 0x0023E064
		public void SetSourceConnection(int id, vtkAlgorithmOutput algOutput)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetSourceConnection_39(base.GetCppThis(), id, (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06019F2B RID: 106283
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetSourceConnection_40(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify a source object at a specified table location. New style.
		/// Source connection is stored in port 1. This method is equivalent
		/// to SetInputConnection(1, id, outputPort).
		/// </summary>
		// Token: 0x06019F2C RID: 106284 RVA: 0x0023FE94 File Offset: 0x0023E094
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetSourceConnection_40(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06019F2D RID: 106285
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetSourceData_41(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the geometry to copy to each point.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetSourceConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x06019F2E RID: 106286 RVA: 0x0023FEC4 File Offset: 0x0023E0C4
		public void SetSourceData(vtkPolyData source)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetSourceData_41(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x06019F2F RID: 106287
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetSymmetric_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off drawing a mirror of each glyph
		/// </summary>
		// Token: 0x06019F30 RID: 106288 RVA: 0x0023FEF3 File Offset: 0x0023E0F3
		public virtual void SetSymmetric(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetSymmetric_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F31 RID: 106289
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SetThreeGlyphs_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off drawing three glyphs
		/// </summary>
		// Token: 0x06019F32 RID: 106290 RVA: 0x0023FF03 File Offset: 0x0023E103
		public virtual void SetThreeGlyphs(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetThreeGlyphs_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F33 RID: 106291
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SymmetricOff_44(HandleRef pThis);

		/// <summary>
		/// Turn on/off drawing a mirror of each glyph
		/// </summary>
		// Token: 0x06019F34 RID: 106292 RVA: 0x0023FF13 File Offset: 0x0023E113
		public virtual void SymmetricOff()
		{
			vtkTensorGlyph.vtkTensorGlyph_SymmetricOff_44(base.GetCppThis());
		}

		// Token: 0x06019F35 RID: 106293
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_SymmetricOn_45(HandleRef pThis);

		/// <summary>
		/// Turn on/off drawing a mirror of each glyph
		/// </summary>
		// Token: 0x06019F36 RID: 106294 RVA: 0x0023FF22 File Offset: 0x0023E122
		public virtual void SymmetricOn()
		{
			vtkTensorGlyph.vtkTensorGlyph_SymmetricOn_45(base.GetCppThis());
		}

		// Token: 0x06019F37 RID: 106295
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_ThreeGlyphsOff_46(HandleRef pThis);

		/// <summary>
		/// Turn on/off drawing three glyphs
		/// </summary>
		// Token: 0x06019F38 RID: 106296 RVA: 0x0023FF31 File Offset: 0x0023E131
		public virtual void ThreeGlyphsOff()
		{
			vtkTensorGlyph.vtkTensorGlyph_ThreeGlyphsOff_46(base.GetCppThis());
		}

		// Token: 0x06019F39 RID: 106297
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorGlyph_ThreeGlyphsOn_47(HandleRef pThis);

		/// <summary>
		/// Turn on/off drawing three glyphs
		/// </summary>
		// Token: 0x06019F3A RID: 106298 RVA: 0x0023FF40 File Offset: 0x0023E140
		public virtual void ThreeGlyphsOn()
		{
			vtkTensorGlyph.vtkTensorGlyph_ThreeGlyphsOn_47(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C27 RID: 7207
		public new const string MRFullTypeName = "Kitware.VTK.vtkTensorGlyph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C28 RID: 7208
		public new static readonly string MRClassNameKey = "class vtkTensorGlyph";

		/// <summary>
		/// Turn on/off coloring of glyph with input scalar data or
		/// eigenvalues. If false, or input scalar data not present, then the
		/// scalars from the source object are passed through the filter.
		/// </summary>
		// Token: 0x020009B3 RID: 2483
		public enum COLOR_BY_EIGENVALUES_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001C2A RID: 7210
			COLOR_BY_EIGENVALUES = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001C2B RID: 7211
			COLOR_BY_SCALARS = 0
		}
	}
}
