using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericGlyph3DFilter
	/// </summary>
	/// <remarks>
	///    copy oriented and scaled glyph geometry to every input point
	///
	/// vtkGenericGlyph3DFilter is a filter that copies a geometric representation (called
	/// a glyph) to every point in the input dataset. The glyph is defined with
	/// polygonal data from a source filter input. The glyph may be oriented
	/// along the input vectors or normals, and it may be scaled according to
	/// scalar data or vector magnitude. More than one glyph may be used by
	/// creating a table of source objects, each defining a different glyph. If a
	/// table of glyphs is defined, then the table can be indexed into by using
	/// either scalar value or vector magnitude.
	///
	/// To use this object you'll have to provide an input dataset and a source
	/// to define the glyph. Then decide whether you want to scale the glyph and
	/// how to scale the glyph (using scalar value or vector magnitude). Next
	/// decide whether you want to orient the glyph, and whether to use the
	/// vector data or normal data to orient it. Finally, decide whether to use a
	/// table of glyphs, or just a single glyph. If you use a table of glyphs,
	/// you'll have to decide whether to index into it with scalar value or with
	/// vector magnitude.
	///
	/// @warning
	/// Contrary to vtkGlyph3D, the only way to specify which attributes will be
	/// used for scaling, coloring and orienting is through SelectInputScalars(),
	/// SelectInputVectors() and SelectInputNormals().
	///
	/// @warning
	/// The scaling of the glyphs is controlled by the ScaleFactor ivar multiplied
	/// by the scalar value at each point (if VTK_SCALE_BY_SCALAR is set), or
	/// multiplied by the vector magnitude (if VTK_SCALE_BY_VECTOR is set),
	/// Alternatively (if VTK_SCALE_BY_VECTORCOMPONENTS is set), the scaling
	/// may be specified for x,y,z using the vector components. The
	/// scale factor can be further controlled by enabling clamping using the
	/// Clamping ivar. If clamping is enabled, the scale is normalized by the
	/// Range ivar, and then multiplied by the scale factor. The normalization
	/// process includes clamping the scale value between (0,1).
	///
	/// @warning
	/// Typically this object operates on input data with scalar and/or vector
	/// data. However, scalar and/or vector aren't necessary, and it can be used
	/// to copy data from a single source to each point. In this case the scale
	/// factor can be used to uniformly scale the glyphs.
	///
	/// @warning
	/// The object uses "vector" data to scale glyphs, orient glyphs, and/or index
	/// into a table of glyphs. You can choose to use either the vector or normal
	/// data at each input point. Use the method SetVectorModeToUseVector() to use
	/// the vector input data, and SetVectorModeToUseNormal() to use the
	/// normal input data.
	///
	/// @warning
	/// If you do use a table of glyphs, make sure to set the Range ivar to make
	/// sure the index into the glyph table is computed correctly.
	///
	/// @warning
	/// You can turn off scaling of the glyphs completely by using the Scaling
	/// ivar. You can also turn off scaling due to data (either vector or scalar)
	/// by using the SetScaleModeToDataScalingOff() method.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTensorGlyph
	/// </seealso>
	// Token: 0x0200049D RID: 1181
	public class vtkGenericGlyph3DFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D9A0 RID: 55712 RVA: 0x0012E387 File Offset: 0x0012C587
		static vtkGenericGlyph3DFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericGlyph3DFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericGlyph3DFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D9A1 RID: 55713 RVA: 0x0012E3AF File Offset: 0x0012C5AF
		public vtkGenericGlyph3DFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D9A2 RID: 55714
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with scaling on, scaling mode is by scalar value,
		/// scale factor = 1.0, the range is (0,1), orient geometry is on, and
		/// orientation is by vector. Clamping and indexing are turned off. No
		/// initial sources are defined.
		/// </summary>
		// Token: 0x0600D9A3 RID: 55715 RVA: 0x0012E3C0 File Offset: 0x0012C5C0
		public new static vtkGenericGlyph3DFilter New()
		{
			vtkGenericGlyph3DFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericGlyph3DFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with scaling on, scaling mode is by scalar value,
		/// scale factor = 1.0, the range is (0,1), orient geometry is on, and
		/// orientation is by vector. Clamping and indexing are turned off. No
		/// initial sources are defined.
		/// </summary>
		// Token: 0x0600D9A4 RID: 55716 RVA: 0x0012E414 File Offset: 0x0012C614
		public vtkGenericGlyph3DFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D9A5 RID: 55717 RVA: 0x0012E458 File Offset: 0x0012C658
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D9A6 RID: 55718
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_ClampingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
		/// vector magnitude if ScaleByVector() is enabled.)
		/// </summary>
		// Token: 0x0600D9A7 RID: 55719 RVA: 0x0012E463 File Offset: 0x0012C663
		public virtual void ClampingOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_ClampingOff_01(base.GetCppThis());
		}

		// Token: 0x0600D9A8 RID: 55720
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_ClampingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
		/// vector magnitude if ScaleByVector() is enabled.)
		/// </summary>
		// Token: 0x0600D9A9 RID: 55721 RVA: 0x0012E472 File Offset: 0x0012C672
		public virtual void ClampingOn()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_ClampingOn_02(base.GetCppThis());
		}

		// Token: 0x0600D9AA RID: 55722
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_GeneratePointIdsOff_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of point ids as part of the output. The
		/// point ids are the id of the input generating point. The point ids are
		/// stored in the output point field data and named "InputPointIds". Point
		/// generation is useful for debugging and pick operations.
		/// </summary>
		// Token: 0x0600D9AB RID: 55723 RVA: 0x0012E481 File Offset: 0x0012C681
		public virtual void GeneratePointIdsOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GeneratePointIdsOff_03(base.GetCppThis());
		}

		// Token: 0x0600D9AC RID: 55724
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_GeneratePointIdsOn_04(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of point ids as part of the output. The
		/// point ids are the id of the input generating point. The point ids are
		/// stored in the output point field data and named "InputPointIds". Point
		/// generation is useful for debugging and pick operations.
		/// </summary>
		// Token: 0x0600D9AD RID: 55725 RVA: 0x0012E490 File Offset: 0x0012C690
		public virtual void GeneratePointIdsOn()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GeneratePointIdsOn_04(base.GetCppThis());
		}

		// Token: 0x0600D9AE RID: 55726
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGlyph3DFilter_GetClamping_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
		/// vector magnitude if ScaleByVector() is enabled.)
		/// </summary>
		// Token: 0x0600D9AF RID: 55727 RVA: 0x0012E4A0 File Offset: 0x0012C6A0
		public virtual int GetClamping()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetClamping_05(base.GetCppThis());
		}

		// Token: 0x0600D9B0 RID: 55728
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGlyph3DFilter_GetColorMode_06(HandleRef pThis);

		/// <summary>
		/// Either color by scale, scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600D9B1 RID: 55729 RVA: 0x0012E4C0 File Offset: 0x0012C6C0
		public virtual int GetColorMode()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetColorMode_06(base.GetCppThis());
		}

		// Token: 0x0600D9B2 RID: 55730
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetColorModeAsString_07(HandleRef pThis);

		/// <summary>
		/// Either color by scale, scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600D9B3 RID: 55731 RVA: 0x0012E4E0 File Offset: 0x0012C6E0
		public string GetColorModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetColorModeAsString_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D9B4 RID: 55732
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGlyph3DFilter_GetGeneratePointIds_08(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of point ids as part of the output. The
		/// point ids are the id of the input generating point. The point ids are
		/// stored in the output point field data and named "InputPointIds". Point
		/// generation is useful for debugging and pick operations.
		/// </summary>
		// Token: 0x0600D9B5 RID: 55733 RVA: 0x0012E51C File Offset: 0x0012C71C
		public virtual int GetGeneratePointIds()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetGeneratePointIds_08(base.GetCppThis());
		}

		// Token: 0x0600D9B6 RID: 55734
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGlyph3DFilter_GetIndexMode_09(HandleRef pThis);

		/// <summary>
		/// Index into table of sources by scalar, by vector/normal magnitude, or
		/// no indexing. If indexing is turned off, then the first source glyph in
		/// the table of glyphs is used.
		/// </summary>
		// Token: 0x0600D9B7 RID: 55735 RVA: 0x0012E53C File Offset: 0x0012C73C
		public virtual int GetIndexMode()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetIndexMode_09(base.GetCppThis());
		}

		// Token: 0x0600D9B8 RID: 55736
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetIndexModeAsString_10(HandleRef pThis);

		/// <summary>
		/// Index into table of sources by scalar, by vector/normal magnitude, or
		/// no indexing. If indexing is turned off, then the first source glyph in
		/// the table of glyphs is used.
		/// </summary>
		// Token: 0x0600D9B9 RID: 55737 RVA: 0x0012E55C File Offset: 0x0012C75C
		public string GetIndexModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetIndexModeAsString_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D9BA RID: 55738
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetInputNormalsSelection_11(HandleRef pThis);

		/// <summary>
		/// If you want to use an arbitrary normals array, then set its name here.
		/// By default this in nullptr and the filter will use the active normal array.
		/// </summary>
		// Token: 0x0600D9BB RID: 55739 RVA: 0x0012E598 File Offset: 0x0012C798
		public virtual string GetInputNormalsSelection()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetInputNormalsSelection_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D9BC RID: 55740
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetInputScalarsSelection_12(HandleRef pThis);

		/// <summary>
		/// If you want to use an arbitrary scalars array, then set its name here.
		/// By default this in nullptr and the filter will use the active scalar array.
		/// </summary>
		// Token: 0x0600D9BD RID: 55741 RVA: 0x0012E5D4 File Offset: 0x0012C7D4
		public virtual string GetInputScalarsSelection()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetInputScalarsSelection_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D9BE RID: 55742
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetInputVectorsSelection_13(HandleRef pThis);

		/// <summary>
		/// If you want to use an arbitrary vectors array, then set its name here.
		/// By default this in nullptr and the filter will use the active vector array.
		/// </summary>
		// Token: 0x0600D9BF RID: 55743 RVA: 0x0012E610 File Offset: 0x0012C810
		public virtual string GetInputVectorsSelection()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetInputVectorsSelection_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D9C0 RID: 55744
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGlyph3DFilter_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D9C1 RID: 55745 RVA: 0x0012E64C File Offset: 0x0012C84C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0600D9C2 RID: 55746
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGlyph3DFilter_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D9C3 RID: 55747 RVA: 0x0012E66C File Offset: 0x0012C86C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0600D9C4 RID: 55748
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGlyph3DFilter_GetOrient_16(HandleRef pThis);

		/// <summary>
		/// Turn on/off orienting of input geometry along vector/normal.
		/// </summary>
		// Token: 0x0600D9C5 RID: 55749 RVA: 0x0012E688 File Offset: 0x0012C888
		public virtual int GetOrient()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetOrient_16(base.GetCppThis());
		}

		// Token: 0x0600D9C6 RID: 55750
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetPointIdsName_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the PointIds array if generated. By default the Ids
		/// are named "InputPointIds", but this can be changed with this function.
		/// </summary>
		// Token: 0x0600D9C7 RID: 55751 RVA: 0x0012E6A8 File Offset: 0x0012C8A8
		public virtual string GetPointIdsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetPointIdsName_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D9C8 RID: 55752
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetRange_18(HandleRef pThis);

		/// <summary>
		/// Specify range to map scalar values into.
		/// </summary>
		// Token: 0x0600D9C9 RID: 55753 RVA: 0x0012E6E4 File Offset: 0x0012C8E4
		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetRange_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D9CA RID: 55754
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_GetRange_19(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify range to map scalar values into.
		/// </summary>
		// Token: 0x0600D9CB RID: 55755 RVA: 0x0012E72C File Offset: 0x0012C92C
		public virtual void GetRange(IntPtr data)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetRange_19(base.GetCppThis(), data);
		}

		// Token: 0x0600D9CC RID: 55756
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericGlyph3DFilter_GetScaleFactor_20(HandleRef pThis);

		/// <summary>
		/// Specify scale factor to scale object by.
		/// </summary>
		// Token: 0x0600D9CD RID: 55757 RVA: 0x0012E73C File Offset: 0x0012C93C
		public virtual double GetScaleFactor()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetScaleFactor_20(base.GetCppThis());
		}

		// Token: 0x0600D9CE RID: 55758
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGlyph3DFilter_GetScaleMode_21(HandleRef pThis);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600D9CF RID: 55759 RVA: 0x0012E75C File Offset: 0x0012C95C
		public virtual int GetScaleMode()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetScaleMode_21(base.GetCppThis());
		}

		// Token: 0x0600D9D0 RID: 55760
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetScaleModeAsString_22(HandleRef pThis);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600D9D1 RID: 55761 RVA: 0x0012E77C File Offset: 0x0012C97C
		public string GetScaleModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetScaleModeAsString_22(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D9D2 RID: 55762
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGlyph3DFilter_GetScaling_23(HandleRef pThis);

		/// <summary>
		/// Turn on/off scaling of source geometry.
		/// </summary>
		// Token: 0x0600D9D3 RID: 55763 RVA: 0x0012E7B8 File Offset: 0x0012C9B8
		public virtual int GetScaling()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetScaling_23(base.GetCppThis());
		}

		// Token: 0x0600D9D4 RID: 55764
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetSource_24(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to a source object at a specified table location.
		/// </summary>
		// Token: 0x0600D9D5 RID: 55765 RVA: 0x0012E7D8 File Offset: 0x0012C9D8
		public vtkPolyData GetSource(int id)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetSource_24(base.GetCppThis(), id, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600D9D6 RID: 55766
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGlyph3DFilter_GetVectorMode_25(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x0600D9D7 RID: 55767 RVA: 0x0012E848 File Offset: 0x0012CA48
		public virtual int GetVectorMode()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetVectorMode_25(base.GetCppThis());
		}

		// Token: 0x0600D9D8 RID: 55768
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetVectorModeAsString_26(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x0600D9D9 RID: 55769 RVA: 0x0012E868 File Offset: 0x0012CA68
		public string GetVectorModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetVectorModeAsString_26(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D9DA RID: 55770
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGlyph3DFilter_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D9DB RID: 55771 RVA: 0x0012E8A4 File Offset: 0x0012CAA4
		public override int IsA(string type)
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x0600D9DC RID: 55772
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGlyph3DFilter_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D9DD RID: 55773 RVA: 0x0012E8C4 File Offset: 0x0012CAC4
		public new static int IsTypeOf(string type)
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_IsTypeOf_28(type);
		}

		// Token: 0x0600D9DE RID: 55774
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D9DF RID: 55775 RVA: 0x0012E8E0 File Offset: 0x0012CAE0
		public new vtkGenericGlyph3DFilter NewInstance()
		{
			vtkGenericGlyph3DFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericGlyph3DFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D9E0 RID: 55776
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_OrientOff_31(HandleRef pThis);

		/// <summary>
		/// Turn on/off orienting of input geometry along vector/normal.
		/// </summary>
		// Token: 0x0600D9E1 RID: 55777 RVA: 0x0012E93A File Offset: 0x0012CB3A
		public virtual void OrientOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_OrientOff_31(base.GetCppThis());
		}

		// Token: 0x0600D9E2 RID: 55778
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_OrientOn_32(HandleRef pThis);

		/// <summary>
		/// Turn on/off orienting of input geometry along vector/normal.
		/// </summary>
		// Token: 0x0600D9E3 RID: 55779 RVA: 0x0012E949 File Offset: 0x0012CB49
		public virtual void OrientOn()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_OrientOn_32(base.GetCppThis());
		}

		// Token: 0x0600D9E4 RID: 55780
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGlyph3DFilter_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D9E5 RID: 55781 RVA: 0x0012E958 File Offset: 0x0012CB58
		public new static vtkGenericGlyph3DFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericGlyph3DFilter vtkGenericGlyph3DFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericGlyph3DFilter = (vtkGenericGlyph3DFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericGlyph3DFilter.Register(null);
				}
			}
			return vtkGenericGlyph3DFilter;
		}

		// Token: 0x0600D9E6 RID: 55782
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_ScalingOff_34(HandleRef pThis);

		/// <summary>
		/// Turn on/off scaling of source geometry.
		/// </summary>
		// Token: 0x0600D9E7 RID: 55783 RVA: 0x0012E9D7 File Offset: 0x0012CBD7
		public virtual void ScalingOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_ScalingOff_34(base.GetCppThis());
		}

		// Token: 0x0600D9E8 RID: 55784
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_ScalingOn_35(HandleRef pThis);

		/// <summary>
		/// Turn on/off scaling of source geometry.
		/// </summary>
		// Token: 0x0600D9E9 RID: 55785 RVA: 0x0012E9E6 File Offset: 0x0012CBE6
		public virtual void ScalingOn()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_ScalingOn_35(base.GetCppThis());
		}

		// Token: 0x0600D9EA RID: 55786
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SelectInputNormals_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName);

		/// <summary>
		/// If you want to use an arbitrary normals array, then set its name here.
		/// By default this in nullptr and the filter will use the active normal array.
		/// </summary>
		// Token: 0x0600D9EB RID: 55787 RVA: 0x0012E9F5 File Offset: 0x0012CBF5
		public void SelectInputNormals(string fieldName)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SelectInputNormals_36(base.GetCppThis(), fieldName);
		}

		// Token: 0x0600D9EC RID: 55788
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SelectInputScalars_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName);

		/// <summary>
		/// If you want to use an arbitrary scalars array, then set its name here.
		/// By default this in nullptr and the filter will use the active scalar array.
		/// </summary>
		// Token: 0x0600D9ED RID: 55789 RVA: 0x0012EA05 File Offset: 0x0012CC05
		public void SelectInputScalars(string fieldName)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SelectInputScalars_37(base.GetCppThis(), fieldName);
		}

		// Token: 0x0600D9EE RID: 55790
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SelectInputVectors_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName);

		/// <summary>
		/// If you want to use an arbitrary vectors array, then set its name here.
		/// By default this in nullptr and the filter will use the active vector array.
		/// </summary>
		// Token: 0x0600D9EF RID: 55791 RVA: 0x0012EA15 File Offset: 0x0012CC15
		public void SelectInputVectors(string fieldName)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SelectInputVectors_38(base.GetCppThis(), fieldName);
		}

		// Token: 0x0600D9F0 RID: 55792
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetClamping_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
		/// vector magnitude if ScaleByVector() is enabled.)
		/// </summary>
		// Token: 0x0600D9F1 RID: 55793 RVA: 0x0012EA25 File Offset: 0x0012CC25
		public virtual void SetClamping(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetClamping_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D9F2 RID: 55794
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetColorMode_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Either color by scale, scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600D9F3 RID: 55795 RVA: 0x0012EA35 File Offset: 0x0012CC35
		public virtual void SetColorMode(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetColorMode_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D9F4 RID: 55796
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetColorModeToColorByScalar_41(HandleRef pThis);

		/// <summary>
		/// Either color by scale, scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600D9F5 RID: 55797 RVA: 0x0012EA45 File Offset: 0x0012CC45
		public void SetColorModeToColorByScalar()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetColorModeToColorByScalar_41(base.GetCppThis());
		}

		// Token: 0x0600D9F6 RID: 55798
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetColorModeToColorByScale_42(HandleRef pThis);

		/// <summary>
		/// Either color by scale, scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600D9F7 RID: 55799 RVA: 0x0012EA54 File Offset: 0x0012CC54
		public void SetColorModeToColorByScale()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetColorModeToColorByScale_42(base.GetCppThis());
		}

		// Token: 0x0600D9F8 RID: 55800
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetColorModeToColorByVector_43(HandleRef pThis);

		/// <summary>
		/// Either color by scale, scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600D9F9 RID: 55801 RVA: 0x0012EA63 File Offset: 0x0012CC63
		public void SetColorModeToColorByVector()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetColorModeToColorByVector_43(base.GetCppThis());
		}

		// Token: 0x0600D9FA RID: 55802
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetGeneratePointIds_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable the generation of point ids as part of the output. The
		/// point ids are the id of the input generating point. The point ids are
		/// stored in the output point field data and named "InputPointIds". Point
		/// generation is useful for debugging and pick operations.
		/// </summary>
		// Token: 0x0600D9FB RID: 55803 RVA: 0x0012EA72 File Offset: 0x0012CC72
		public virtual void SetGeneratePointIds(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetGeneratePointIds_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D9FC RID: 55804
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetIndexMode_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Index into table of sources by scalar, by vector/normal magnitude, or
		/// no indexing. If indexing is turned off, then the first source glyph in
		/// the table of glyphs is used.
		/// </summary>
		// Token: 0x0600D9FD RID: 55805 RVA: 0x0012EA82 File Offset: 0x0012CC82
		public virtual void SetIndexMode(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetIndexMode_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D9FE RID: 55806
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetIndexModeToOff_46(HandleRef pThis);

		/// <summary>
		/// Index into table of sources by scalar, by vector/normal magnitude, or
		/// no indexing. If indexing is turned off, then the first source glyph in
		/// the table of glyphs is used.
		/// </summary>
		// Token: 0x0600D9FF RID: 55807 RVA: 0x0012EA92 File Offset: 0x0012CC92
		public void SetIndexModeToOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetIndexModeToOff_46(base.GetCppThis());
		}

		// Token: 0x0600DA00 RID: 55808
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetIndexModeToScalar_47(HandleRef pThis);

		/// <summary>
		/// Index into table of sources by scalar, by vector/normal magnitude, or
		/// no indexing. If indexing is turned off, then the first source glyph in
		/// the table of glyphs is used.
		/// </summary>
		// Token: 0x0600DA01 RID: 55809 RVA: 0x0012EAA1 File Offset: 0x0012CCA1
		public void SetIndexModeToScalar()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetIndexModeToScalar_47(base.GetCppThis());
		}

		// Token: 0x0600DA02 RID: 55810
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetIndexModeToVector_48(HandleRef pThis);

		/// <summary>
		/// Index into table of sources by scalar, by vector/normal magnitude, or
		/// no indexing. If indexing is turned off, then the first source glyph in
		/// the table of glyphs is used.
		/// </summary>
		// Token: 0x0600DA03 RID: 55811 RVA: 0x0012EAB0 File Offset: 0x0012CCB0
		public void SetIndexModeToVector()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetIndexModeToVector_48(base.GetCppThis());
		}

		// Token: 0x0600DA04 RID: 55812
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetOrient_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off orienting of input geometry along vector/normal.
		/// </summary>
		// Token: 0x0600DA05 RID: 55813 RVA: 0x0012EABF File Offset: 0x0012CCBF
		public virtual void SetOrient(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetOrient_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DA06 RID: 55814
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetPointIdsName_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the PointIds array if generated. By default the Ids
		/// are named "InputPointIds", but this can be changed with this function.
		/// </summary>
		// Token: 0x0600DA07 RID: 55815 RVA: 0x0012EACF File Offset: 0x0012CCCF
		public virtual void SetPointIdsName(string _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetPointIdsName_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DA08 RID: 55816
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetRange_51(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify range to map scalar values into.
		/// </summary>
		// Token: 0x0600DA09 RID: 55817 RVA: 0x0012EADF File Offset: 0x0012CCDF
		public virtual void SetRange(double _arg1, double _arg2)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetRange_51(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600DA0A RID: 55818
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetRange_52(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify range to map scalar values into.
		/// </summary>
		// Token: 0x0600DA0B RID: 55819 RVA: 0x0012EAF0 File Offset: 0x0012CCF0
		public void SetRange(IntPtr _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetRange_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DA0C RID: 55820
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetScaleFactor_53(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify scale factor to scale object by.
		/// </summary>
		// Token: 0x0600DA0D RID: 55821 RVA: 0x0012EB00 File Offset: 0x0012CD00
		public virtual void SetScaleFactor(double _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaleFactor_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DA0E RID: 55822
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetScaleMode_54(HandleRef pThis, int _arg);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600DA0F RID: 55823 RVA: 0x0012EB10 File Offset: 0x0012CD10
		public virtual void SetScaleMode(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaleMode_54(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DA10 RID: 55824
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetScaleModeToDataScalingOff_55(HandleRef pThis);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600DA11 RID: 55825 RVA: 0x0012EB20 File Offset: 0x0012CD20
		public void SetScaleModeToDataScalingOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaleModeToDataScalingOff_55(base.GetCppThis());
		}

		// Token: 0x0600DA12 RID: 55826
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetScaleModeToScaleByScalar_56(HandleRef pThis);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600DA13 RID: 55827 RVA: 0x0012EB2F File Offset: 0x0012CD2F
		public void SetScaleModeToScaleByScalar()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaleModeToScaleByScalar_56(base.GetCppThis());
		}

		// Token: 0x0600DA14 RID: 55828
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetScaleModeToScaleByVector_57(HandleRef pThis);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600DA15 RID: 55829 RVA: 0x0012EB3E File Offset: 0x0012CD3E
		public void SetScaleModeToScaleByVector()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaleModeToScaleByVector_57(base.GetCppThis());
		}

		// Token: 0x0600DA16 RID: 55830
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetScaleModeToScaleByVectorComponents_58(HandleRef pThis);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0600DA17 RID: 55831 RVA: 0x0012EB4D File Offset: 0x0012CD4D
		public void SetScaleModeToScaleByVectorComponents()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaleModeToScaleByVectorComponents_58(base.GetCppThis());
		}

		// Token: 0x0600DA18 RID: 55832
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetScaling_59(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off scaling of source geometry.
		/// </summary>
		// Token: 0x0600DA19 RID: 55833 RVA: 0x0012EB5C File Offset: 0x0012CD5C
		public virtual void SetScaling(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaling_59(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DA1A RID: 55834
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetSourceData_60(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Set the source to use for the glyph.
		/// </summary>
		// Token: 0x0600DA1B RID: 55835 RVA: 0x0012EB6C File Offset: 0x0012CD6C
		public void SetSourceData(vtkPolyData pd)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetSourceData_60(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600DA1C RID: 55836
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetSourceData_61(HandleRef pThis, int id, HandleRef pd);

		/// <summary>
		/// Specify a source object at a specified table location.
		/// </summary>
		// Token: 0x0600DA1D RID: 55837 RVA: 0x0012EB9C File Offset: 0x0012CD9C
		public void SetSourceData(int id, vtkPolyData pd)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetSourceData_61(base.GetCppThis(), id, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600DA1E RID: 55838
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetVectorMode_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x0600DA1F RID: 55839 RVA: 0x0012EBCC File Offset: 0x0012CDCC
		public virtual void SetVectorMode(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetVectorMode_62(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DA20 RID: 55840
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetVectorModeToUseNormal_63(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x0600DA21 RID: 55841 RVA: 0x0012EBDC File Offset: 0x0012CDDC
		public void SetVectorModeToUseNormal()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetVectorModeToUseNormal_63(base.GetCppThis());
		}

		// Token: 0x0600DA22 RID: 55842
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetVectorModeToUseVector_64(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x0600DA23 RID: 55843 RVA: 0x0012EBEB File Offset: 0x0012CDEB
		public void SetVectorModeToUseVector()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetVectorModeToUseVector_64(base.GetCppThis());
		}

		// Token: 0x0600DA24 RID: 55844
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGlyph3DFilter_SetVectorModeToVectorRotationOff_65(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x0600DA25 RID: 55845 RVA: 0x0012EBFA File Offset: 0x0012CDFA
		public void SetVectorModeToVectorRotationOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetVectorModeToVectorRotationOff_65(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FE2 RID: 4066
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericGlyph3DFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FE3 RID: 4067
		public new static readonly string MRClassNameKey = "class vtkGenericGlyph3DFilter";
	}
}
