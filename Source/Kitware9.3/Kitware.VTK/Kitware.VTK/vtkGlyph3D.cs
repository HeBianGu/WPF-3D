using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGlyph3D
	/// </summary>
	/// <remarks>
	///    copy oriented and scaled glyph geometry to every input point
	///
	/// vtkGlyph3D is a filter that copies a geometric representation (called
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
	/// @warning
	/// You can set what arrays to use for the scalars, vectors, normals, and
	/// color scalars by using the SetInputArrayToProcess methods in
	/// vtkAlgorithm. The first array is scalars, the next vectors, the next
	/// normals and finally color scalars.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTensorGlyph
	/// </seealso>
	// Token: 0x0200096C RID: 2412
	public class vtkGlyph3D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060191F2 RID: 102898 RVA: 0x0023049B File Offset: 0x0022E69B
		static vtkGlyph3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGlyph3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlyph3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060191F3 RID: 102899 RVA: 0x002304C3 File Offset: 0x0022E6C3
		public vtkGlyph3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060191F4 RID: 102900
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with scaling on, scaling mode is by scalar value,
		/// scale factor = 1.0, the range is (0,1), orient geometry is on, and
		/// orientation is by vector. Clamping and indexing are turned off. No
		/// initial sources are defined.
		/// </summary>
		// Token: 0x060191F5 RID: 102901 RVA: 0x002304D4 File Offset: 0x0022E6D4
		public new static vtkGlyph3D New()
		{
			vtkGlyph3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyph3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with scaling on, scaling mode is by scalar value,
		/// scale factor = 1.0, the range is (0,1), orient geometry is on, and
		/// orientation is by vector. Clamping and indexing are turned off. No
		/// initial sources are defined.
		/// </summary>
		// Token: 0x060191F6 RID: 102902 RVA: 0x00230528 File Offset: 0x0022E728
		public vtkGlyph3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGlyph3D.vtkGlyph3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060191F7 RID: 102903 RVA: 0x0023056C File Offset: 0x0022E76C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060191F8 RID: 102904
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_ClampingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
		/// vector magnitude if ScaleByVector() is enabled.)
		/// </summary>
		// Token: 0x060191F9 RID: 102905 RVA: 0x00230577 File Offset: 0x0022E777
		public virtual void ClampingOff()
		{
			vtkGlyph3D.vtkGlyph3D_ClampingOff_01(base.GetCppThis());
		}

		// Token: 0x060191FA RID: 102906
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_ClampingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
		/// vector magnitude if ScaleByVector() is enabled.)
		/// </summary>
		// Token: 0x060191FB RID: 102907 RVA: 0x00230586 File Offset: 0x0022E786
		public virtual void ClampingOn()
		{
			vtkGlyph3D.vtkGlyph3D_ClampingOn_02(base.GetCppThis());
		}

		// Token: 0x060191FC RID: 102908
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_FillCellDataOff_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of cell data as part of the output.
		/// The cell data at each cell will match the point data of the input
		/// at the glyphed point.
		/// </summary>
		// Token: 0x060191FD RID: 102909 RVA: 0x00230595 File Offset: 0x0022E795
		public virtual void FillCellDataOff()
		{
			vtkGlyph3D.vtkGlyph3D_FillCellDataOff_03(base.GetCppThis());
		}

		// Token: 0x060191FE RID: 102910
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_FillCellDataOn_04(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of cell data as part of the output.
		/// The cell data at each cell will match the point data of the input
		/// at the glyphed point.
		/// </summary>
		// Token: 0x060191FF RID: 102911 RVA: 0x002305A4 File Offset: 0x0022E7A4
		public virtual void FillCellDataOn()
		{
			vtkGlyph3D.vtkGlyph3D_FillCellDataOn_04(base.GetCppThis());
		}

		// Token: 0x06019200 RID: 102912
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_GeneratePointIdsOff_05(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of point ids as part of the output. The
		/// point ids are the id of the input generating point. The point ids are
		/// stored in the output point field data and named "InputPointIds". Point
		/// generation is useful for debugging and pick operations.
		/// </summary>
		// Token: 0x06019201 RID: 102913 RVA: 0x002305B3 File Offset: 0x0022E7B3
		public virtual void GeneratePointIdsOff()
		{
			vtkGlyph3D.vtkGlyph3D_GeneratePointIdsOff_05(base.GetCppThis());
		}

		// Token: 0x06019202 RID: 102914
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_GeneratePointIdsOn_06(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of point ids as part of the output. The
		/// point ids are the id of the input generating point. The point ids are
		/// stored in the output point field data and named "InputPointIds". Point
		/// generation is useful for debugging and pick operations.
		/// </summary>
		// Token: 0x06019203 RID: 102915 RVA: 0x002305C2 File Offset: 0x0022E7C2
		public virtual void GeneratePointIdsOn()
		{
			vtkGlyph3D.vtkGlyph3D_GeneratePointIdsOn_06(base.GetCppThis());
		}

		// Token: 0x06019204 RID: 102916
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_GetClamping_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
		/// vector magnitude if ScaleByVector() is enabled.)
		/// </summary>
		// Token: 0x06019205 RID: 102917 RVA: 0x002305D4 File Offset: 0x0022E7D4
		public virtual int GetClamping()
		{
			return vtkGlyph3D.vtkGlyph3D_GetClamping_07(base.GetCppThis());
		}

		// Token: 0x06019206 RID: 102918
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_GetColorMode_08(HandleRef pThis);

		/// <summary>
		/// Either color by scale, scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x06019207 RID: 102919 RVA: 0x002305F4 File Offset: 0x0022E7F4
		public virtual int GetColorMode()
		{
			return vtkGlyph3D.vtkGlyph3D_GetColorMode_08(base.GetCppThis());
		}

		// Token: 0x06019208 RID: 102920
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_GetColorModeAsString_09(HandleRef pThis);

		/// <summary>
		/// Either color by scale, scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x06019209 RID: 102921 RVA: 0x00230614 File Offset: 0x0022E814
		public string GetColorModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGlyph3D.vtkGlyph3D_GetColorModeAsString_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601920A RID: 102922
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_GetFillCellData_10(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of cell data as part of the output.
		/// The cell data at each cell will match the point data of the input
		/// at the glyphed point.
		/// </summary>
		// Token: 0x0601920B RID: 102923 RVA: 0x00230650 File Offset: 0x0022E850
		public virtual int GetFillCellData()
		{
			return vtkGlyph3D.vtkGlyph3D_GetFillCellData_10(base.GetCppThis());
		}

		// Token: 0x0601920C RID: 102924
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_GetFollowedCameraPosition_11(HandleRef pThis);

		/// <summary>
		/// Set/Get point position glyphs will face towards. Used if vector mode is
		/// VTK_FOLLOW_CAMERA_DIRECTION.
		/// </summary>
		// Token: 0x0601920D RID: 102925 RVA: 0x00230670 File Offset: 0x0022E870
		public virtual double[] GetFollowedCameraPosition()
		{
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_GetFollowedCameraPosition_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601920E RID: 102926
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_GetFollowedCameraPosition_12(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get point position glyphs will face towards. Used if vector mode is
		/// VTK_FOLLOW_CAMERA_DIRECTION.
		/// </summary>
		// Token: 0x0601920F RID: 102927 RVA: 0x002306B8 File Offset: 0x0022E8B8
		public virtual void GetFollowedCameraPosition(IntPtr data)
		{
			vtkGlyph3D.vtkGlyph3D_GetFollowedCameraPosition_12(base.GetCppThis(), data);
		}

		// Token: 0x06019210 RID: 102928
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_GetFollowedCameraViewUp_13(HandleRef pThis);

		/// <summary>
		/// Set/Get glyphs up direction. Used if vector mode is VTK_FOLLOW_CAMERA_DIRECTION.
		/// </summary>
		// Token: 0x06019211 RID: 102929 RVA: 0x002306C8 File Offset: 0x0022E8C8
		public virtual double[] GetFollowedCameraViewUp()
		{
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_GetFollowedCameraViewUp_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06019212 RID: 102930
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_GetFollowedCameraViewUp_14(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get glyphs up direction. Used if vector mode is VTK_FOLLOW_CAMERA_DIRECTION.
		/// </summary>
		// Token: 0x06019213 RID: 102931 RVA: 0x00230710 File Offset: 0x0022E910
		public virtual void GetFollowedCameraViewUp(IntPtr data)
		{
			vtkGlyph3D.vtkGlyph3D_GetFollowedCameraViewUp_14(base.GetCppThis(), data);
		}

		// Token: 0x06019214 RID: 102932
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_GetGeneratePointIds_15(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of point ids as part of the output. The
		/// point ids are the id of the input generating point. The point ids are
		/// stored in the output point field data and named "InputPointIds". Point
		/// generation is useful for debugging and pick operations.
		/// </summary>
		// Token: 0x06019215 RID: 102933 RVA: 0x00230720 File Offset: 0x0022E920
		public virtual int GetGeneratePointIds()
		{
			return vtkGlyph3D.vtkGlyph3D_GetGeneratePointIds_15(base.GetCppThis());
		}

		// Token: 0x06019216 RID: 102934
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_GetIndexMode_16(HandleRef pThis);

		/// <summary>
		/// Index into table of sources by scalar, by vector/normal magnitude, or
		/// no indexing. If indexing is turned off, then the first source glyph in
		/// the table of glyphs is used. Note that indexing mode will only use the
		/// InputScalarsSelection array and not the InputColorScalarsSelection
		/// as the scalar source if an array is specified.
		/// </summary>
		// Token: 0x06019217 RID: 102935 RVA: 0x00230740 File Offset: 0x0022E940
		public virtual int GetIndexMode()
		{
			return vtkGlyph3D.vtkGlyph3D_GetIndexMode_16(base.GetCppThis());
		}

		// Token: 0x06019218 RID: 102936
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_GetIndexModeAsString_17(HandleRef pThis);

		/// <summary>
		/// Index into table of sources by scalar, by vector/normal magnitude, or
		/// no indexing. If indexing is turned off, then the first source glyph in
		/// the table of glyphs is used. Note that indexing mode will only use the
		/// InputScalarsSelection array and not the InputColorScalarsSelection
		/// as the scalar source if an array is specified.
		/// </summary>
		// Token: 0x06019219 RID: 102937 RVA: 0x00230760 File Offset: 0x0022E960
		public string GetIndexModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGlyph3D.vtkGlyph3D_GetIndexModeAsString_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601921A RID: 102938
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGlyph3D_GetMTime_18(HandleRef pThis);

		/// <summary>
		/// Overridden to include SourceTransform's MTime.
		/// </summary>
		// Token: 0x0601921B RID: 102939 RVA: 0x0023079C File Offset: 0x0022E99C
		public override ulong GetMTime()
		{
			return vtkGlyph3D.vtkGlyph3D_GetMTime_18(base.GetCppThis());
		}

		// Token: 0x0601921C RID: 102940
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGlyph3D_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601921D RID: 102941 RVA: 0x002307BC File Offset: 0x0022E9BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGlyph3D.vtkGlyph3D_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0601921E RID: 102942
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGlyph3D_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601921F RID: 102943 RVA: 0x002307DC File Offset: 0x0022E9DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGlyph3D.vtkGlyph3D_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x06019220 RID: 102944
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_GetOrient_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off orienting of input geometry along vector/normal.
		/// </summary>
		// Token: 0x06019221 RID: 102945 RVA: 0x002307F8 File Offset: 0x0022E9F8
		public virtual int GetOrient()
		{
			return vtkGlyph3D.vtkGlyph3D_GetOrient_21(base.GetCppThis());
		}

		// Token: 0x06019222 RID: 102946
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_GetOutputPointsPrecision_22(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019223 RID: 102947 RVA: 0x00230818 File Offset: 0x0022EA18
		public virtual int GetOutputPointsPrecision()
		{
			return vtkGlyph3D.vtkGlyph3D_GetOutputPointsPrecision_22(base.GetCppThis());
		}

		// Token: 0x06019224 RID: 102948
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_GetPointIdsName_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the PointIds array if generated. By default the Ids
		/// are named "InputPointIds", but this can be changed with this function.
		/// </summary>
		// Token: 0x06019225 RID: 102949 RVA: 0x00230838 File Offset: 0x0022EA38
		public virtual string GetPointIdsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGlyph3D.vtkGlyph3D_GetPointIdsName_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06019226 RID: 102950
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_GetRange_24(HandleRef pThis);

		/// <summary>
		/// Specify range to map scalar values into.
		/// </summary>
		// Token: 0x06019227 RID: 102951 RVA: 0x00230874 File Offset: 0x0022EA74
		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_GetRange_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06019228 RID: 102952
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_GetRange_25(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify range to map scalar values into.
		/// </summary>
		// Token: 0x06019229 RID: 102953 RVA: 0x002308BC File Offset: 0x0022EABC
		public virtual void GetRange(IntPtr data)
		{
			vtkGlyph3D.vtkGlyph3D_GetRange_25(base.GetCppThis(), data);
		}

		// Token: 0x0601922A RID: 102954
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGlyph3D_GetScaleFactor_26(HandleRef pThis);

		/// <summary>
		/// Specify scale factor to scale object by.
		/// </summary>
		// Token: 0x0601922B RID: 102955 RVA: 0x002308CC File Offset: 0x0022EACC
		public virtual double GetScaleFactor()
		{
			return vtkGlyph3D.vtkGlyph3D_GetScaleFactor_26(base.GetCppThis());
		}

		// Token: 0x0601922C RID: 102956
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_GetScaleMode_27(HandleRef pThis);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0601922D RID: 102957 RVA: 0x002308EC File Offset: 0x0022EAEC
		public virtual int GetScaleMode()
		{
			return vtkGlyph3D.vtkGlyph3D_GetScaleMode_27(base.GetCppThis());
		}

		// Token: 0x0601922E RID: 102958
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_GetScaleModeAsString_28(HandleRef pThis);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0601922F RID: 102959 RVA: 0x0023090C File Offset: 0x0022EB0C
		public string GetScaleModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGlyph3D.vtkGlyph3D_GetScaleModeAsString_28(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06019230 RID: 102960
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_GetScaling_29(HandleRef pThis);

		/// <summary>
		/// Turn on/off scaling of source geometry.
		/// </summary>
		// Token: 0x06019231 RID: 102961 RVA: 0x00230948 File Offset: 0x0022EB48
		public virtual int GetScaling()
		{
			return vtkGlyph3D.vtkGlyph3D_GetScaling_29(base.GetCppThis());
		}

		// Token: 0x06019232 RID: 102962
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_GetSource_30(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to a source object at a specified table location.
		/// </summary>
		// Token: 0x06019233 RID: 102963 RVA: 0x00230968 File Offset: 0x0022EB68
		public vtkPolyData GetSource(int id)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_GetSource_30(base.GetCppThis(), id, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019234 RID: 102964
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_GetSourceTransform_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When set, this is use to transform the source polydata before using it to
		/// generate the glyph. This is useful if one wanted to reorient the source,
		/// for example.
		/// </summary>
		// Token: 0x06019235 RID: 102965 RVA: 0x002309D8 File Offset: 0x0022EBD8
		public virtual vtkTransform GetSourceTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_GetSourceTransform_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x06019236 RID: 102966
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_GetVectorMode_32(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x06019237 RID: 102967 RVA: 0x00230A48 File Offset: 0x0022EC48
		public virtual int GetVectorMode()
		{
			return vtkGlyph3D.vtkGlyph3D_GetVectorMode_32(base.GetCppThis());
		}

		// Token: 0x06019238 RID: 102968
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_GetVectorModeAsString_33(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x06019239 RID: 102969 RVA: 0x00230A68 File Offset: 0x0022EC68
		public string GetVectorModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGlyph3D.vtkGlyph3D_GetVectorModeAsString_33(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601923A RID: 102970
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_IsA_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601923B RID: 102971 RVA: 0x00230AA4 File Offset: 0x0022ECA4
		public override int IsA(string type)
		{
			return vtkGlyph3D.vtkGlyph3D_IsA_34(base.GetCppThis(), type);
		}

		// Token: 0x0601923C RID: 102972
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_IsPointVisible_35(HandleRef pThis, HandleRef arg0, long arg1);

		/// <summary>
		/// This can be overwritten by subclass to return 0 when a point is
		/// blanked. Default implementation is to always return 1;
		/// </summary>
		// Token: 0x0601923D RID: 102973 RVA: 0x00230AC4 File Offset: 0x0022ECC4
		public virtual int IsPointVisible(vtkDataSet arg0, long arg1)
		{
			return vtkGlyph3D.vtkGlyph3D_IsPointVisible_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), arg1);
		}

		// Token: 0x0601923E RID: 102974
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3D_IsTypeOf_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601923F RID: 102975 RVA: 0x00230AFC File Offset: 0x0022ECFC
		public new static int IsTypeOf(string type)
		{
			return vtkGlyph3D.vtkGlyph3D_IsTypeOf_36(type);
		}

		// Token: 0x06019240 RID: 102976
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019241 RID: 102977 RVA: 0x00230B18 File Offset: 0x0022ED18
		public new vtkGlyph3D NewInstance()
		{
			vtkGlyph3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_NewInstance_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyph3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019242 RID: 102978
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_OrientOff_39(HandleRef pThis);

		/// <summary>
		/// Turn on/off orienting of input geometry along vector/normal.
		/// </summary>
		// Token: 0x06019243 RID: 102979 RVA: 0x00230B72 File Offset: 0x0022ED72
		public virtual void OrientOff()
		{
			vtkGlyph3D.vtkGlyph3D_OrientOff_39(base.GetCppThis());
		}

		// Token: 0x06019244 RID: 102980
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_OrientOn_40(HandleRef pThis);

		/// <summary>
		/// Turn on/off orienting of input geometry along vector/normal.
		/// </summary>
		// Token: 0x06019245 RID: 102981 RVA: 0x00230B81 File Offset: 0x0022ED81
		public virtual void OrientOn()
		{
			vtkGlyph3D.vtkGlyph3D_OrientOn_40(base.GetCppThis());
		}

		// Token: 0x06019246 RID: 102982
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3D_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019247 RID: 102983 RVA: 0x00230B90 File Offset: 0x0022ED90
		public new static vtkGlyph3D SafeDownCast(vtkObjectBase o)
		{
			vtkGlyph3D vtkGlyph3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_SafeDownCast_41((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlyph3D = (vtkGlyph3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlyph3D.Register(null);
				}
			}
			return vtkGlyph3D;
		}

		// Token: 0x06019248 RID: 102984
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_ScalingOff_42(HandleRef pThis);

		/// <summary>
		/// Turn on/off scaling of source geometry.
		/// </summary>
		// Token: 0x06019249 RID: 102985 RVA: 0x00230C0F File Offset: 0x0022EE0F
		public virtual void ScalingOff()
		{
			vtkGlyph3D.vtkGlyph3D_ScalingOff_42(base.GetCppThis());
		}

		// Token: 0x0601924A RID: 102986
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_ScalingOn_43(HandleRef pThis);

		/// <summary>
		/// Turn on/off scaling of source geometry.
		/// </summary>
		// Token: 0x0601924B RID: 102987 RVA: 0x00230C1E File Offset: 0x0022EE1E
		public virtual void ScalingOn()
		{
			vtkGlyph3D.vtkGlyph3D_ScalingOn_43(base.GetCppThis());
		}

		// Token: 0x0601924C RID: 102988
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetClamping_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
		/// vector magnitude if ScaleByVector() is enabled.)
		/// </summary>
		// Token: 0x0601924D RID: 102989 RVA: 0x00230C2D File Offset: 0x0022EE2D
		public virtual void SetClamping(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetClamping_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0601924E RID: 102990
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetColorMode_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Either color by scale, scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0601924F RID: 102991 RVA: 0x00230C3D File Offset: 0x0022EE3D
		public virtual void SetColorMode(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetColorMode_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06019250 RID: 102992
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetColorModeToColorByScalar_46(HandleRef pThis);

		/// <summary>
		/// Either color by scale, scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x06019251 RID: 102993 RVA: 0x00230C4D File Offset: 0x0022EE4D
		public void SetColorModeToColorByScalar()
		{
			vtkGlyph3D.vtkGlyph3D_SetColorModeToColorByScalar_46(base.GetCppThis());
		}

		// Token: 0x06019252 RID: 102994
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetColorModeToColorByScale_47(HandleRef pThis);

		/// <summary>
		/// Either color by scale, scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x06019253 RID: 102995 RVA: 0x00230C5C File Offset: 0x0022EE5C
		public void SetColorModeToColorByScale()
		{
			vtkGlyph3D.vtkGlyph3D_SetColorModeToColorByScale_47(base.GetCppThis());
		}

		// Token: 0x06019254 RID: 102996
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetColorModeToColorByVector_48(HandleRef pThis);

		/// <summary>
		/// Either color by scale, scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x06019255 RID: 102997 RVA: 0x00230C6B File Offset: 0x0022EE6B
		public void SetColorModeToColorByVector()
		{
			vtkGlyph3D.vtkGlyph3D_SetColorModeToColorByVector_48(base.GetCppThis());
		}

		// Token: 0x06019256 RID: 102998
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetFillCellData_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable the generation of cell data as part of the output.
		/// The cell data at each cell will match the point data of the input
		/// at the glyphed point.
		/// </summary>
		// Token: 0x06019257 RID: 102999 RVA: 0x00230C7A File Offset: 0x0022EE7A
		public virtual void SetFillCellData(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetFillCellData_49(base.GetCppThis(), _arg);
		}

		// Token: 0x06019258 RID: 103000
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetFollowedCameraPosition_50(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get point position glyphs will face towards. Used if vector mode is
		/// VTK_FOLLOW_CAMERA_DIRECTION.
		/// </summary>
		// Token: 0x06019259 RID: 103001 RVA: 0x00230C8A File Offset: 0x0022EE8A
		public virtual void SetFollowedCameraPosition(IntPtr data)
		{
			vtkGlyph3D.vtkGlyph3D_SetFollowedCameraPosition_50(base.GetCppThis(), data);
		}

		// Token: 0x0601925A RID: 103002
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetFollowedCameraViewUp_51(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get glyphs up direction. Used if vector mode is VTK_FOLLOW_CAMERA_DIRECTION.
		/// </summary>
		// Token: 0x0601925B RID: 103003 RVA: 0x00230C9A File Offset: 0x0022EE9A
		public virtual void SetFollowedCameraViewUp(IntPtr data)
		{
			vtkGlyph3D.vtkGlyph3D_SetFollowedCameraViewUp_51(base.GetCppThis(), data);
		}

		// Token: 0x0601925C RID: 103004
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetGeneratePointIds_52(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable the generation of point ids as part of the output. The
		/// point ids are the id of the input generating point. The point ids are
		/// stored in the output point field data and named "InputPointIds". Point
		/// generation is useful for debugging and pick operations.
		/// </summary>
		// Token: 0x0601925D RID: 103005 RVA: 0x00230CAA File Offset: 0x0022EEAA
		public virtual void SetGeneratePointIds(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetGeneratePointIds_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0601925E RID: 103006
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetIndexMode_53(HandleRef pThis, int _arg);

		/// <summary>
		/// Index into table of sources by scalar, by vector/normal magnitude, or
		/// no indexing. If indexing is turned off, then the first source glyph in
		/// the table of glyphs is used. Note that indexing mode will only use the
		/// InputScalarsSelection array and not the InputColorScalarsSelection
		/// as the scalar source if an array is specified.
		/// </summary>
		// Token: 0x0601925F RID: 103007 RVA: 0x00230CBA File Offset: 0x0022EEBA
		public virtual void SetIndexMode(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetIndexMode_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06019260 RID: 103008
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetIndexModeToOff_54(HandleRef pThis);

		/// <summary>
		/// Index into table of sources by scalar, by vector/normal magnitude, or
		/// no indexing. If indexing is turned off, then the first source glyph in
		/// the table of glyphs is used. Note that indexing mode will only use the
		/// InputScalarsSelection array and not the InputColorScalarsSelection
		/// as the scalar source if an array is specified.
		/// </summary>
		// Token: 0x06019261 RID: 103009 RVA: 0x00230CCA File Offset: 0x0022EECA
		public void SetIndexModeToOff()
		{
			vtkGlyph3D.vtkGlyph3D_SetIndexModeToOff_54(base.GetCppThis());
		}

		// Token: 0x06019262 RID: 103010
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetIndexModeToScalar_55(HandleRef pThis);

		/// <summary>
		/// Index into table of sources by scalar, by vector/normal magnitude, or
		/// no indexing. If indexing is turned off, then the first source glyph in
		/// the table of glyphs is used. Note that indexing mode will only use the
		/// InputScalarsSelection array and not the InputColorScalarsSelection
		/// as the scalar source if an array is specified.
		/// </summary>
		// Token: 0x06019263 RID: 103011 RVA: 0x00230CD9 File Offset: 0x0022EED9
		public void SetIndexModeToScalar()
		{
			vtkGlyph3D.vtkGlyph3D_SetIndexModeToScalar_55(base.GetCppThis());
		}

		// Token: 0x06019264 RID: 103012
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetIndexModeToVector_56(HandleRef pThis);

		/// <summary>
		/// Index into table of sources by scalar, by vector/normal magnitude, or
		/// no indexing. If indexing is turned off, then the first source glyph in
		/// the table of glyphs is used. Note that indexing mode will only use the
		/// InputScalarsSelection array and not the InputColorScalarsSelection
		/// as the scalar source if an array is specified.
		/// </summary>
		// Token: 0x06019265 RID: 103013 RVA: 0x00230CE8 File Offset: 0x0022EEE8
		public void SetIndexModeToVector()
		{
			vtkGlyph3D.vtkGlyph3D_SetIndexModeToVector_56(base.GetCppThis());
		}

		// Token: 0x06019266 RID: 103014
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetOrient_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off orienting of input geometry along vector/normal.
		/// </summary>
		// Token: 0x06019267 RID: 103015 RVA: 0x00230CF7 File Offset: 0x0022EEF7
		public virtual void SetOrient(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetOrient_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06019268 RID: 103016
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetOutputPointsPrecision_58(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019269 RID: 103017 RVA: 0x00230D07 File Offset: 0x0022EF07
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetOutputPointsPrecision_58(base.GetCppThis(), _arg);
		}

		// Token: 0x0601926A RID: 103018
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetPointIdsName_59(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the PointIds array if generated. By default the Ids
		/// are named "InputPointIds", but this can be changed with this function.
		/// </summary>
		// Token: 0x0601926B RID: 103019 RVA: 0x00230D17 File Offset: 0x0022EF17
		public virtual void SetPointIdsName(string _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetPointIdsName_59(base.GetCppThis(), _arg);
		}

		// Token: 0x0601926C RID: 103020
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetRange_60(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify range to map scalar values into.
		/// </summary>
		// Token: 0x0601926D RID: 103021 RVA: 0x00230D27 File Offset: 0x0022EF27
		public virtual void SetRange(double _arg1, double _arg2)
		{
			vtkGlyph3D.vtkGlyph3D_SetRange_60(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601926E RID: 103022
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetRange_61(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify range to map scalar values into.
		/// </summary>
		// Token: 0x0601926F RID: 103023 RVA: 0x00230D38 File Offset: 0x0022EF38
		public void SetRange(IntPtr _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetRange_61(base.GetCppThis(), _arg);
		}

		// Token: 0x06019270 RID: 103024
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetScaleFactor_62(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify scale factor to scale object by.
		/// </summary>
		// Token: 0x06019271 RID: 103025 RVA: 0x00230D48 File Offset: 0x0022EF48
		public virtual void SetScaleFactor(double _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetScaleFactor_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06019272 RID: 103026
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetScaleMode_63(HandleRef pThis, int _arg);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x06019273 RID: 103027 RVA: 0x00230D58 File Offset: 0x0022EF58
		public virtual void SetScaleMode(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetScaleMode_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06019274 RID: 103028
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetScaleModeToDataScalingOff_64(HandleRef pThis);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x06019275 RID: 103029 RVA: 0x00230D68 File Offset: 0x0022EF68
		public void SetScaleModeToDataScalingOff()
		{
			vtkGlyph3D.vtkGlyph3D_SetScaleModeToDataScalingOff_64(base.GetCppThis());
		}

		// Token: 0x06019276 RID: 103030
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetScaleModeToScaleByScalar_65(HandleRef pThis);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x06019277 RID: 103031 RVA: 0x00230D77 File Offset: 0x0022EF77
		public void SetScaleModeToScaleByScalar()
		{
			vtkGlyph3D.vtkGlyph3D_SetScaleModeToScaleByScalar_65(base.GetCppThis());
		}

		// Token: 0x06019278 RID: 103032
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetScaleModeToScaleByVector_66(HandleRef pThis);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x06019279 RID: 103033 RVA: 0x00230D86 File Offset: 0x0022EF86
		public void SetScaleModeToScaleByVector()
		{
			vtkGlyph3D.vtkGlyph3D_SetScaleModeToScaleByVector_66(base.GetCppThis());
		}

		// Token: 0x0601927A RID: 103034
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetScaleModeToScaleByVectorComponents_67(HandleRef pThis);

		/// <summary>
		/// Either scale by scalar or by vector/normal magnitude.
		/// </summary>
		// Token: 0x0601927B RID: 103035 RVA: 0x00230D95 File Offset: 0x0022EF95
		public void SetScaleModeToScaleByVectorComponents()
		{
			vtkGlyph3D.vtkGlyph3D_SetScaleModeToScaleByVectorComponents_67(base.GetCppThis());
		}

		// Token: 0x0601927C RID: 103036
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetScaling_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off scaling of source geometry.
		/// </summary>
		// Token: 0x0601927D RID: 103037 RVA: 0x00230DA4 File Offset: 0x0022EFA4
		public virtual void SetScaling(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetScaling_68(base.GetCppThis(), _arg);
		}

		// Token: 0x0601927E RID: 103038
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetSourceConnection_69(HandleRef pThis, int id, HandleRef algOutput);

		/// <summary>
		/// Specify a source object at a specified table location. New style.
		/// Source connection is stored in port 1. This method is equivalent
		/// to SetInputConnection(1, id, outputPort).
		/// </summary>
		// Token: 0x0601927F RID: 103039 RVA: 0x00230DB4 File Offset: 0x0022EFB4
		public void SetSourceConnection(int id, vtkAlgorithmOutput algOutput)
		{
			vtkGlyph3D.vtkGlyph3D_SetSourceConnection_69(base.GetCppThis(), id, (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06019280 RID: 103040
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetSourceConnection_70(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify a source object at a specified table location. New style.
		/// Source connection is stored in port 1. This method is equivalent
		/// to SetInputConnection(1, id, outputPort).
		/// </summary>
		// Token: 0x06019281 RID: 103041 RVA: 0x00230DE4 File Offset: 0x0022EFE4
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkGlyph3D.vtkGlyph3D_SetSourceConnection_70(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06019282 RID: 103042
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetSourceData_71(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Set the source to use for the glyph.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetSourceConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x06019283 RID: 103043 RVA: 0x00230E14 File Offset: 0x0022F014
		public void SetSourceData(vtkPolyData pd)
		{
			vtkGlyph3D.vtkGlyph3D_SetSourceData_71(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06019284 RID: 103044
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetSourceData_72(HandleRef pThis, int id, HandleRef pd);

		/// <summary>
		/// Specify a source object at a specified table location.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetSourceConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x06019285 RID: 103045 RVA: 0x00230E44 File Offset: 0x0022F044
		public void SetSourceData(int id, vtkPolyData pd)
		{
			vtkGlyph3D.vtkGlyph3D_SetSourceData_72(base.GetCppThis(), id, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06019286 RID: 103046
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetSourceTransform_73(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// When set, this is use to transform the source polydata before using it to
		/// generate the glyph. This is useful if one wanted to reorient the source,
		/// for example.
		/// </summary>
		// Token: 0x06019287 RID: 103047 RVA: 0x00230E74 File Offset: 0x0022F074
		public void SetSourceTransform(vtkTransform arg0)
		{
			vtkGlyph3D.vtkGlyph3D_SetSourceTransform_73(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06019288 RID: 103048
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetVectorMode_74(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x06019289 RID: 103049 RVA: 0x00230EA3 File Offset: 0x0022F0A3
		public virtual void SetVectorMode(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetVectorMode_74(base.GetCppThis(), _arg);
		}

		// Token: 0x0601928A RID: 103050
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetVectorModeToFollowCameraDirection_75(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x0601928B RID: 103051 RVA: 0x00230EB3 File Offset: 0x0022F0B3
		public void SetVectorModeToFollowCameraDirection()
		{
			vtkGlyph3D.vtkGlyph3D_SetVectorModeToFollowCameraDirection_75(base.GetCppThis());
		}

		// Token: 0x0601928C RID: 103052
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetVectorModeToUseNormal_76(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x0601928D RID: 103053 RVA: 0x00230EC2 File Offset: 0x0022F0C2
		public void SetVectorModeToUseNormal()
		{
			vtkGlyph3D.vtkGlyph3D_SetVectorModeToUseNormal_76(base.GetCppThis());
		}

		// Token: 0x0601928E RID: 103054
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetVectorModeToUseVector_77(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x0601928F RID: 103055 RVA: 0x00230ED1 File Offset: 0x0022F0D1
		public void SetVectorModeToUseVector()
		{
			vtkGlyph3D.vtkGlyph3D_SetVectorModeToUseVector_77(base.GetCppThis());
		}

		// Token: 0x06019290 RID: 103056
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3D_SetVectorModeToVectorRotationOff_78(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x06019291 RID: 103057 RVA: 0x00230EE0 File Offset: 0x0022F0E0
		public void SetVectorModeToVectorRotationOff()
		{
			vtkGlyph3D.vtkGlyph3D_SetVectorModeToVectorRotationOff_78(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B91 RID: 7057
		public new const string MRFullTypeName = "Kitware.VTK.vtkGlyph3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B92 RID: 7058
		public new static readonly string MRClassNameKey = "class vtkGlyph3D";
	}
}
