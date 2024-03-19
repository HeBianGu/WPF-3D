using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMapper
	/// </summary>
	/// <remarks>
	///    abstract class specifies interface to map data to graphics primitives
	///
	/// vtkMapper is an abstract class to specify interface between data and
	/// graphics primitives. Subclasses of vtkMapper map data through a
	/// lookuptable and control the creation of rendering primitives that
	/// interface to the graphics library. The mapping can be controlled by
	/// supplying a lookup table and specifying a scalar range to map data
	/// through.
	///
	/// There are several important control mechanisms affecting the behavior of
	/// this object. The ScalarVisibility flag controls whether scalar data (if
	/// any) controls the color of the associated actor(s) that refer to the
	/// mapper. The ScalarMode ivar is used to determine whether scalar point data
	/// or cell data is used to color the object. By default, point data scalars
	/// are used unless there are none, in which cell scalars are used. Or you can
	/// explicitly control whether to use point or cell scalar data. Finally, the
	/// mapping of scalars through the lookup table varies depending on the
	/// setting of the ColorMode flag. See the documentation for the appropriate
	/// methods for an explanation.
	///
	/// Another important feature of the mapper is the ability to shift the
	/// z-buffer to resolve coincident topology. For example, if you'd like to
	/// draw a mesh with some edges a different color, and the edges lie on the
	/// mesh, this feature can be useful to get nice looking lines. (See the
	/// ResolveCoincidentTopology-related methods.)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataSetMapper vtkPolyDataMapper
	/// </seealso>
	// Token: 0x020000FD RID: 253
	public abstract class vtkMapper : vtkAbstractMapper3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060033A5 RID: 13221 RVA: 0x0004BEC9 File Offset: 0x0004A0C9
		static vtkMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060033A6 RID: 13222 RVA: 0x0004BEF1 File Offset: 0x0004A0F1
		public vtkMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060033A7 RID: 13223 RVA: 0x0004BEFF File Offset: 0x0004A0FF
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060033A8 RID: 13224
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_CanUseTextureMapForColoring_01(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Returns if we can use texture maps for scalar coloring. Note this doesn't
		/// say we "will" use scalar coloring. It says, if we do use scalar coloring,
		/// we will use a texture.
		/// When rendering multiblock datasets, if any 2 blocks provide different
		/// lookup tables for the scalars, then also we cannot use textures. This case
		/// can be handled if required.
		/// </summary>
		// Token: 0x060033A9 RID: 13225 RVA: 0x0004BF0C File Offset: 0x0004A10C
		public virtual int CanUseTextureMapForColoring(vtkDataObject input)
		{
			return vtkMapper.vtkMapper_CanUseTextureMapForColoring_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x060033AA RID: 13226
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_ClearColorArrays_02(HandleRef pThis);

		/// <summary>
		/// Call to force a rebuild of color result arrays on next MapScalars.
		/// Necessary when using arrays in the case of multiblock data.
		/// </summary>
		// Token: 0x060033AB RID: 13227 RVA: 0x0004BF40 File Offset: 0x0004A140
		public void ClearColorArrays()
		{
			vtkMapper.vtkMapper_ClearColorArrays_02(base.GetCppThis());
		}

		// Token: 0x060033AC RID: 13228
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_ColorByArrayComponent_03(HandleRef pThis, int arrayNum, int component);

		/// <summary>
		/// Legacy:
		/// These methods used to be used to specify the array component.
		/// It is better to do this in the lookup table.
		/// </summary>
		// Token: 0x060033AD RID: 13229 RVA: 0x0004BF4F File Offset: 0x0004A14F
		public void ColorByArrayComponent(int arrayNum, int component)
		{
			vtkMapper.vtkMapper_ColorByArrayComponent_03(base.GetCppThis(), arrayNum, component);
		}

		// Token: 0x060033AE RID: 13230
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_ColorByArrayComponent_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int component);

		/// <summary>
		/// Legacy:
		/// These methods used to be used to specify the array component.
		/// It is better to do this in the lookup table.
		/// </summary>
		// Token: 0x060033AF RID: 13231 RVA: 0x0004BF60 File Offset: 0x0004A160
		public void ColorByArrayComponent(string arrayName, int component)
		{
			vtkMapper.vtkMapper_ColorByArrayComponent_04(base.GetCppThis(), arrayName, component);
		}

		// Token: 0x060033B0 RID: 13232
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_CreateDefaultLookupTable_05(HandleRef pThis);

		/// <summary>
		/// Create default lookup table. Generally used to create one when none
		/// is available with the scalar data.
		/// </summary>
		// Token: 0x060033B1 RID: 13233 RVA: 0x0004BF71 File Offset: 0x0004A171
		public virtual void CreateDefaultLookupTable()
		{
			vtkMapper.vtkMapper_CreateDefaultLookupTable_05(base.GetCppThis());
		}

		// Token: 0x060033B2 RID: 13234
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_GetArrayAccessMode_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the array name or number and component to color by.
		/// </summary>
		// Token: 0x060033B3 RID: 13235 RVA: 0x0004BF80 File Offset: 0x0004A180
		public virtual int GetArrayAccessMode()
		{
			return vtkMapper.vtkMapper_GetArrayAccessMode_06(base.GetCppThis());
		}

		// Token: 0x060033B4 RID: 13236
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_GetArrayComponent_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the array name or number and component to color by.
		/// </summary>
		// Token: 0x060033B5 RID: 13237 RVA: 0x0004BFA0 File Offset: 0x0004A1A0
		public virtual int GetArrayComponent()
		{
			return vtkMapper.vtkMapper_GetArrayComponent_07(base.GetCppThis());
		}

		// Token: 0x060033B6 RID: 13238
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_GetArrayId_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the array name or number and component to color by.
		/// </summary>
		// Token: 0x060033B7 RID: 13239 RVA: 0x0004BFC0 File Offset: 0x0004A1C0
		public virtual int GetArrayId()
		{
			return vtkMapper.vtkMapper_GetArrayId_08(base.GetCppThis());
		}

		// Token: 0x060033B8 RID: 13240
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_GetArrayName_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the array name or number and component to color by.
		/// </summary>
		// Token: 0x060033B9 RID: 13241 RVA: 0x0004BFE0 File Offset: 0x0004A1E0
		public virtual string GetArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMapper.vtkMapper_GetArrayName_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060033BA RID: 13242
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_GetBounds_10(HandleRef pThis);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x060033BB RID: 13243 RVA: 0x0004C01C File Offset: 0x0004A21C
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkMapper.vtkMapper_GetBounds_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060033BC RID: 13244
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_GetBounds_11(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x060033BD RID: 13245 RVA: 0x0004C064 File Offset: 0x0004A264
		public override void GetBounds(IntPtr bounds)
		{
			vtkMapper.vtkMapper_GetBounds_11(base.GetCppThis(), bounds);
		}

		// Token: 0x060033BE RID: 13246
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_GetCoincidentTopologyLineOffsetParameters_12(HandleRef pThis, ref double factor, ref double units);

		/// <summary>
		/// Get the net parameters for handling coincident topology
		/// obtained by summing the global values with the relative values.
		/// </summary>
		// Token: 0x060033BF RID: 13247 RVA: 0x0004C074 File Offset: 0x0004A274
		public void GetCoincidentTopologyLineOffsetParameters(ref double factor, ref double units)
		{
			vtkMapper.vtkMapper_GetCoincidentTopologyLineOffsetParameters_12(base.GetCppThis(), ref factor, ref units);
		}

		// Token: 0x060033C0 RID: 13248
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_GetCoincidentTopologyPointOffsetParameter_13(HandleRef pThis, ref double units);

		/// <summary>
		/// Get the net parameters for handling coincident topology
		/// obtained by summing the global values with the relative values.
		/// </summary>
		// Token: 0x060033C1 RID: 13249 RVA: 0x0004C085 File Offset: 0x0004A285
		public void GetCoincidentTopologyPointOffsetParameter(ref double units)
		{
			vtkMapper.vtkMapper_GetCoincidentTopologyPointOffsetParameter_13(base.GetCppThis(), ref units);
		}

		// Token: 0x060033C2 RID: 13250
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_GetCoincidentTopologyPolygonOffsetParameters_14(HandleRef pThis, ref double factor, ref double units);

		/// <summary>
		/// Get the net parameters for handling coincident topology
		/// obtained by summing the global values with the relative values.
		/// </summary>
		// Token: 0x060033C3 RID: 13251 RVA: 0x0004C095 File Offset: 0x0004A295
		public void GetCoincidentTopologyPolygonOffsetParameters(ref double factor, ref double units)
		{
			vtkMapper.vtkMapper_GetCoincidentTopologyPolygonOffsetParameters_14(base.GetCppThis(), ref factor, ref units);
		}

		// Token: 0x060033C4 RID: 13252
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_GetColorCoordinates_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Provide read access to the color texture coordinate array
		/// </summary>
		// Token: 0x060033C5 RID: 13253 RVA: 0x0004C0A8 File Offset: 0x0004A2A8
		public vtkFloatArray GetColorCoordinates()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_GetColorCoordinates_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		// Token: 0x060033C6 RID: 13254
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_GetColorMapColors_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Provide read access to the color array
		/// </summary>
		// Token: 0x060033C7 RID: 13255 RVA: 0x0004C118 File Offset: 0x0004A318
		public vtkUnsignedCharArray GetColorMapColors()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_GetColorMapColors_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x060033C8 RID: 13256
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_GetColorMode_17(HandleRef pThis);

		/// <summary>
		/// default (ColorModeToDefault), unsigned char scalars are treated
		/// as colors, and NOT mapped through the lookup table, while
		/// everything else is.  ColorModeToDirectScalar extends
		/// ColorModeToDefault such that all integer types are treated as
		/// colors with values in the range 0-255 and floating types are
		/// treated as colors with values in the range 0.0-1.0.  Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped
		/// through the lookup table.  (Note that for multi-component
		/// scalars, the particular component to use for mapping can be
		/// specified using the SelectColorArray() method.)
		/// </summary>
		// Token: 0x060033C9 RID: 13257 RVA: 0x0004C188 File Offset: 0x0004A388
		public virtual int GetColorMode()
		{
			return vtkMapper.vtkMapper_GetColorMode_17(base.GetCppThis());
		}

		// Token: 0x060033CA RID: 13258
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_GetColorModeAsString_18(HandleRef pThis);

		/// <summary>
		/// Return the method of coloring scalar data.
		/// </summary>
		// Token: 0x060033CB RID: 13259 RVA: 0x0004C1A8 File Offset: 0x0004A3A8
		public string GetColorModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkMapper.vtkMapper_GetColorModeAsString_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060033CC RID: 13260
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_GetColorTextureMap_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Provide read access to the color texture array
		/// </summary>
		// Token: 0x060033CD RID: 13261 RVA: 0x0004C1E4 File Offset: 0x0004A3E4
		public vtkImageData GetColorTextureMap()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_GetColorTextureMap_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060033CE RID: 13262
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMapper_GetFieldDataTupleId_20(HandleRef pThis);

		/// <summary>
		/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
		/// you can specify which array to use for coloring using these methods.
		/// The lookup table will decide how to convert vectors to colors.
		/// </summary>
		// Token: 0x060033CF RID: 13263 RVA: 0x0004C254 File Offset: 0x0004A454
		public virtual long GetFieldDataTupleId()
		{
			return vtkMapper.vtkMapper_GetFieldDataTupleId_20(base.GetCppThis());
		}

		// Token: 0x060033D0 RID: 13264
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_GetInput_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input as a vtkDataSet.  This method is overridden in
		/// the specialized mapper classes to return more specific data types.
		/// </summary>
		// Token: 0x060033D1 RID: 13265 RVA: 0x0004C274 File Offset: 0x0004A474
		public vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_GetInput_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x060033D2 RID: 13266
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_GetInputAsDataSet_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this mapper as a vtkDataSet, instead of as a
		/// more specialized data type that the subclass may return from
		/// GetInput().  This method is provided for use in the wrapper languages,
		/// C++ programmers should use GetInput() instead.
		/// </summary>
		// Token: 0x060033D3 RID: 13267 RVA: 0x0004C2E4 File Offset: 0x0004A4E4
		public vtkDataSet GetInputAsDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_GetInputAsDataSet_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x060033D4 RID: 13268
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_GetInterpolateScalarsBeforeMapping_23(HandleRef pThis);

		/// <summary>
		/// By default, vertex color is used to map colors to a surface.
		/// Colors are interpolated after being mapped.
		/// This option avoids color interpolation by using a one dimensional
		/// texture map for the colors.
		/// </summary>
		// Token: 0x060033D5 RID: 13269 RVA: 0x0004C354 File Offset: 0x0004A554
		public virtual int GetInterpolateScalarsBeforeMapping()
		{
			return vtkMapper.vtkMapper_GetInterpolateScalarsBeforeMapping_23(base.GetCppThis());
		}

		// Token: 0x060033D6 RID: 13270
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_GetLookupTable_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x060033D7 RID: 13271 RVA: 0x0004C374 File Offset: 0x0004A574
		public vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_GetLookupTable_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x060033D8 RID: 13272
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMapper_GetMTime_25(HandleRef pThis);

		/// <summary>
		/// Overload standard modified time function. If lookup table is modified,
		/// then this object is modified as well.
		/// </summary>
		// Token: 0x060033D9 RID: 13273 RVA: 0x0004C3E4 File Offset: 0x0004A5E4
		public override ulong GetMTime()
		{
			return vtkMapper.vtkMapper_GetMTime_25(base.GetCppThis());
		}

		// Token: 0x060033DA RID: 13274
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMapper_GetNumberOfGenerationsFromBase_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060033DB RID: 13275 RVA: 0x0004C404 File Offset: 0x0004A604
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMapper.vtkMapper_GetNumberOfGenerationsFromBase_26(base.GetCppThis(), type);
		}

		// Token: 0x060033DC RID: 13276
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMapper_GetNumberOfGenerationsFromBaseType_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060033DD RID: 13277 RVA: 0x0004C424 File Offset: 0x0004A624
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMapper.vtkMapper_GetNumberOfGenerationsFromBaseType_27(type);
		}

		// Token: 0x060033DE RID: 13278
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_GetRelativeCoincidentTopologyLineOffsetParameters_28(HandleRef pThis, ref double factor, ref double units);

		/// <summary>
		/// Used to set the line offset values relative to the global
		/// Used when ResolveCoincidentTopology is set to PolygonOffset.
		/// </summary>
		// Token: 0x060033DF RID: 13279 RVA: 0x0004C43E File Offset: 0x0004A63E
		public void GetRelativeCoincidentTopologyLineOffsetParameters(ref double factor, ref double units)
		{
			vtkMapper.vtkMapper_GetRelativeCoincidentTopologyLineOffsetParameters_28(base.GetCppThis(), ref factor, ref units);
		}

		// Token: 0x060033E0 RID: 13280
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_GetRelativeCoincidentTopologyPointOffsetParameter_29(HandleRef pThis, ref double units);

		/// <summary>
		/// Used to set the point offset value relative to the global
		/// Used when ResolveCoincidentTopology is set to PolygonOffset.
		/// </summary>
		// Token: 0x060033E1 RID: 13281 RVA: 0x0004C44F File Offset: 0x0004A64F
		public void GetRelativeCoincidentTopologyPointOffsetParameter(ref double units)
		{
			vtkMapper.vtkMapper_GetRelativeCoincidentTopologyPointOffsetParameter_29(base.GetCppThis(), ref units);
		}

		// Token: 0x060033E2 RID: 13282
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_GetRelativeCoincidentTopologyPolygonOffsetParameters_30(HandleRef pThis, ref double factor, ref double units);

		/// <summary>
		/// Used to set the polygon offset values relative to the global
		/// Used when ResolveCoincidentTopology is set to PolygonOffset.
		/// </summary>
		// Token: 0x060033E3 RID: 13283 RVA: 0x0004C45F File Offset: 0x0004A65F
		public void GetRelativeCoincidentTopologyPolygonOffsetParameters(ref double factor, ref double units)
		{
			vtkMapper.vtkMapper_GetRelativeCoincidentTopologyPolygonOffsetParameters_30(base.GetCppThis(), ref factor, ref units);
		}

		// Token: 0x060033E4 RID: 13284
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMapper_GetRenderTime_31(HandleRef pThis);

		/// <summary>
		/// This instance variable is used by vtkLODActor to determine which
		/// mapper to use.  It is an estimate of the time necessary to render.
		/// Setting the render time does not modify the mapper.
		/// </summary>
		// Token: 0x060033E5 RID: 13285 RVA: 0x0004C470 File Offset: 0x0004A670
		public virtual double GetRenderTime()
		{
			return vtkMapper.vtkMapper_GetRenderTime_31(base.GetCppThis());
		}

		// Token: 0x060033E6 RID: 13286
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_GetResolveCoincidentTopology_32();

		/// <summary>
		/// Set/Get a global flag that controls whether coincident topology (e.g., a
		/// line on top of a polygon) is shifted to avoid z-buffer resolution (and
		/// hence rendering problems). If not off, there are two methods to choose
		/// from. PolygonOffset uses graphics systems calls to shift polygons, lines
		/// and points from each other. ShiftZBuffer is a legacy method that used to
		/// remap the z-buffer to distinguish vertices, lines, and polygons, but
		/// does not always produce acceptable results. You should only use the
		/// PolygonOffset method (or none) at this point.
		/// </summary>
		// Token: 0x060033E7 RID: 13287 RVA: 0x0004C490 File Offset: 0x0004A690
		public static int GetResolveCoincidentTopology()
		{
			return vtkMapper.vtkMapper_GetResolveCoincidentTopology_32();
		}

		// Token: 0x060033E8 RID: 13288
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_GetResolveCoincidentTopologyLineOffsetParameters_33(ref double factor, ref double units);

		/// <summary>
		/// Used to set the line offset scale factor and units.
		/// Used when ResolveCoincidentTopology is set to PolygonOffset.
		/// These are global variables.
		/// </summary>
		// Token: 0x060033E9 RID: 13289 RVA: 0x0004C4A9 File Offset: 0x0004A6A9
		public static void GetResolveCoincidentTopologyLineOffsetParameters(ref double factor, ref double units)
		{
			vtkMapper.vtkMapper_GetResolveCoincidentTopologyLineOffsetParameters_33(ref factor, ref units);
		}

		// Token: 0x060033EA RID: 13290
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_GetResolveCoincidentTopologyPointOffsetParameter_34(ref double units);

		/// <summary>
		/// Used to set the point offset value
		/// Used when ResolveCoincidentTopology is set to PolygonOffset.
		/// These are global variables.
		/// </summary>
		// Token: 0x060033EB RID: 13291 RVA: 0x0004C4B4 File Offset: 0x0004A6B4
		public static void GetResolveCoincidentTopologyPointOffsetParameter(ref double units)
		{
			vtkMapper.vtkMapper_GetResolveCoincidentTopologyPointOffsetParameter_34(ref units);
		}

		// Token: 0x060033EC RID: 13292
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_GetResolveCoincidentTopologyPolygonOffsetFaces_35();

		/// <summary>
		/// Used when ResolveCoincidentTopology is set to PolygonOffset. The polygon
		/// offset can be applied either to the solid polygonal faces or the
		/// lines/vertices. When set (default), the offset is applied to the faces
		/// otherwise it is applied to lines and vertices.
		/// This is a global variable.
		/// </summary>
		// Token: 0x060033ED RID: 13293 RVA: 0x0004C4C0 File Offset: 0x0004A6C0
		public static int GetResolveCoincidentTopologyPolygonOffsetFaces()
		{
			return vtkMapper.vtkMapper_GetResolveCoincidentTopologyPolygonOffsetFaces_35();
		}

		// Token: 0x060033EE RID: 13294
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_GetResolveCoincidentTopologyPolygonOffsetParameters_36(ref double factor, ref double units);

		/// <summary>
		/// Used to set the polygon offset scale factor and units.
		/// Used when ResolveCoincidentTopology is set to PolygonOffset.
		/// These are global variables.
		/// </summary>
		// Token: 0x060033EF RID: 13295 RVA: 0x0004C4D9 File Offset: 0x0004A6D9
		public static void GetResolveCoincidentTopologyPolygonOffsetParameters(ref double factor, ref double units)
		{
			vtkMapper.vtkMapper_GetResolveCoincidentTopologyPolygonOffsetParameters_36(ref factor, ref units);
		}

		// Token: 0x060033F0 RID: 13296
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMapper_GetResolveCoincidentTopologyZShift_37();

		/// <summary>
		/// Used to set the z-shift if ResolveCoincidentTopology is set to
		/// ShiftZBuffer. This is a global variable.
		/// </summary>
		// Token: 0x060033F1 RID: 13297 RVA: 0x0004C4E4 File Offset: 0x0004A6E4
		public static double GetResolveCoincidentTopologyZShift()
		{
			return vtkMapper.vtkMapper_GetResolveCoincidentTopologyZShift_37();
		}

		// Token: 0x060033F2 RID: 13298
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_GetScalarMode_38(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectColorArray before you call
		/// GetColors.
		/// </summary>
		// Token: 0x060033F3 RID: 13299 RVA: 0x0004C500 File Offset: 0x0004A700
		public virtual int GetScalarMode()
		{
			return vtkMapper.vtkMapper_GetScalarMode_38(base.GetCppThis());
		}

		// Token: 0x060033F4 RID: 13300
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_GetScalarModeAsString_39(HandleRef pThis);

		/// <summary>
		/// Return the method for obtaining scalar data.
		/// </summary>
		// Token: 0x060033F5 RID: 13301 RVA: 0x0004C520 File Offset: 0x0004A720
		public string GetScalarModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkMapper.vtkMapper_GetScalarModeAsString_39(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060033F6 RID: 13302
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_GetScalarRange_40(HandleRef pThis);

		/// <summary>
		/// Specify range in terms of scalar minimum and maximum (smin,smax). These
		/// values are used to map scalars into lookup table. Has no effect when
		/// UseLookupTableScalarRange is true.
		/// </summary>
		// Token: 0x060033F7 RID: 13303 RVA: 0x0004C55C File Offset: 0x0004A75C
		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkMapper.vtkMapper_GetScalarRange_40(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060033F8 RID: 13304
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_GetScalarRange_41(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify range in terms of scalar minimum and maximum (smin,smax). These
		/// values are used to map scalars into lookup table. Has no effect when
		/// UseLookupTableScalarRange is true.
		/// </summary>
		// Token: 0x060033F9 RID: 13305 RVA: 0x0004C5A4 File Offset: 0x0004A7A4
		public virtual void GetScalarRange(IntPtr data)
		{
			vtkMapper.vtkMapper_GetScalarRange_41(base.GetCppThis(), data);
		}

		// Token: 0x060033FA RID: 13306
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_GetScalarVisibility_42(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x060033FB RID: 13307 RVA: 0x0004C5B4 File Offset: 0x0004A7B4
		public virtual int GetScalarVisibility()
		{
			return vtkMapper.vtkMapper_GetScalarVisibility_42(base.GetCppThis());
		}

		// Token: 0x060033FC RID: 13308
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_GetSelection_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get selection used to display particular points or cells in a second pass.
		/// This can be use to efficiently display a selection.
		/// </summary>
		// Token: 0x060033FD RID: 13309 RVA: 0x0004C5D4 File Offset: 0x0004A7D4
		public virtual vtkSelection GetSelection()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_GetSelection_43(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x060033FE RID: 13310
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_GetStatic_44(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether the mapper's data is static. Static data
		/// means that the mapper does not propagate updates down the pipeline, greatly
		/// decreasing the time it takes to update many mappers. This should only be
		/// used if the data never changes.
		/// </summary>
		// Token: 0x060033FF RID: 13311 RVA: 0x0004C644 File Offset: 0x0004A844
		public virtual int GetStatic()
		{
			return vtkMapper.vtkMapper_GetStatic_44(base.GetCppThis());
		}

		// Token: 0x06003400 RID: 13312
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMapper_GetSupportsSelection_45(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Used by vtkHardwareSelector to determine if the prop supports hardware
		/// selection.
		/// </summary>
		// Token: 0x06003401 RID: 13313 RVA: 0x0004C664 File Offset: 0x0004A864
		public virtual bool GetSupportsSelection()
		{
			return vtkMapper.vtkMapper_GetSupportsSelection_45(base.GetCppThis()) != 0;
		}

		// Token: 0x06003402 RID: 13314
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_GetUseLookupTableScalarRange_46(HandleRef pThis);

		/// <summary>
		/// Control whether the mapper sets the lookuptable range based on its
		/// own ScalarRange, or whether it will use the LookupTable ScalarRange
		/// regardless of it's own setting. By default the Mapper is allowed to set
		/// the LookupTable range, but users who are sharing LookupTables between
		/// mappers/actors will probably wish to force the mapper to use the
		/// LookupTable unchanged.
		/// </summary>
		// Token: 0x06003403 RID: 13315 RVA: 0x0004C68C File Offset: 0x0004A88C
		public virtual int GetUseLookupTableScalarRange()
		{
			return vtkMapper.vtkMapper_GetUseLookupTableScalarRange_46(base.GetCppThis());
		}

		// Token: 0x06003404 RID: 13316
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMapper_HasOpaqueGeometry_47(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06003405 RID: 13317 RVA: 0x0004C6AC File Offset: 0x0004A8AC
		public virtual bool HasOpaqueGeometry()
		{
			return vtkMapper.vtkMapper_HasOpaqueGeometry_47(base.GetCppThis()) != 0;
		}

		// Token: 0x06003406 RID: 13318
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMapper_HasTranslucentPolygonalGeometry_48(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06003407 RID: 13319 RVA: 0x0004C6D4 File Offset: 0x0004A8D4
		public virtual bool HasTranslucentPolygonalGeometry()
		{
			return vtkMapper.vtkMapper_HasTranslucentPolygonalGeometry_48(base.GetCppThis()) != 0;
		}

		// Token: 0x06003408 RID: 13320
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_InterpolateScalarsBeforeMappingOff_49(HandleRef pThis);

		/// <summary>
		/// By default, vertex color is used to map colors to a surface.
		/// Colors are interpolated after being mapped.
		/// This option avoids color interpolation by using a one dimensional
		/// texture map for the colors.
		/// </summary>
		// Token: 0x06003409 RID: 13321 RVA: 0x0004C6FA File Offset: 0x0004A8FA
		public virtual void InterpolateScalarsBeforeMappingOff()
		{
			vtkMapper.vtkMapper_InterpolateScalarsBeforeMappingOff_49(base.GetCppThis());
		}

		// Token: 0x0600340A RID: 13322
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_InterpolateScalarsBeforeMappingOn_50(HandleRef pThis);

		/// <summary>
		/// By default, vertex color is used to map colors to a surface.
		/// Colors are interpolated after being mapped.
		/// This option avoids color interpolation by using a one dimensional
		/// texture map for the colors.
		/// </summary>
		// Token: 0x0600340B RID: 13323 RVA: 0x0004C709 File Offset: 0x0004A909
		public virtual void InterpolateScalarsBeforeMappingOn()
		{
			vtkMapper.vtkMapper_InterpolateScalarsBeforeMappingOn_50(base.GetCppThis());
		}

		// Token: 0x0600340C RID: 13324
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_IsA_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600340D RID: 13325 RVA: 0x0004C718 File Offset: 0x0004A918
		public override int IsA(string type)
		{
			return vtkMapper.vtkMapper_IsA_51(base.GetCppThis(), type);
		}

		// Token: 0x0600340E RID: 13326
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper_IsTypeOf_52([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600340F RID: 13327 RVA: 0x0004C738 File Offset: 0x0004A938
		public new static int IsTypeOf(string type)
		{
			return vtkMapper.vtkMapper_IsTypeOf_52(type);
		}

		// Token: 0x06003410 RID: 13328
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_MapScalars_53(HandleRef pThis, double alpha, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Map the scalars (if there are any scalars and ScalarVisibility is on)
		/// through the lookup table, returning an unsigned char RGBA array. This is
		/// typically done as part of the rendering process. The alpha parameter
		/// allows the blending of the scalars with an additional alpha (typically
		/// which comes from a vtkActor, etc.)
		/// </summary>
		// Token: 0x06003411 RID: 13329 RVA: 0x0004C754 File Offset: 0x0004A954
		public virtual vtkUnsignedCharArray MapScalars(double alpha)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_MapScalars_53(base.GetCppThis(), alpha, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06003412 RID: 13330
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_MapScalars_54(HandleRef pThis, double alpha, ref int cellFlag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Map the scalars (if there are any scalars and ScalarVisibility is on)
		/// through the lookup table, returning an unsigned char RGBA array. This is
		/// typically done as part of the rendering process. The alpha parameter
		/// allows the blending of the scalars with an additional alpha (typically
		/// which comes from a vtkActor, etc.)
		/// </summary>
		// Token: 0x06003413 RID: 13331 RVA: 0x0004C7C4 File Offset: 0x0004A9C4
		public virtual vtkUnsignedCharArray MapScalars(double alpha, ref int cellFlag)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_MapScalars_54(base.GetCppThis(), alpha, ref cellFlag, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06003414 RID: 13332
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_MapScalars_55(HandleRef pThis, HandleRef input, double alpha, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Map the scalars (if there are any scalars and ScalarVisibility is on)
		/// through the lookup table, returning an unsigned char RGBA array. This is
		/// typically done as part of the rendering process. The alpha parameter
		/// allows the blending of the scalars with an additional alpha (typically
		/// which comes from a vtkActor, etc.)
		/// </summary>
		// Token: 0x06003415 RID: 13333 RVA: 0x0004C838 File Offset: 0x0004AA38
		public virtual vtkUnsignedCharArray MapScalars(vtkDataSet input, double alpha)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_MapScalars_55(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), alpha, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06003416 RID: 13334
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_MapScalars_56(HandleRef pThis, HandleRef input, double alpha, ref int cellFlag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Map the scalars (if there are any scalars and ScalarVisibility is on)
		/// through the lookup table, returning an unsigned char RGBA array. This is
		/// typically done as part of the rendering process. The alpha parameter
		/// allows the blending of the scalars with an additional alpha (typically
		/// which comes from a vtkActor, etc.)
		/// </summary>
		// Token: 0x06003417 RID: 13335 RVA: 0x0004C8C0 File Offset: 0x0004AAC0
		public virtual vtkUnsignedCharArray MapScalars(vtkDataSet input, double alpha, ref int cellFlag)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_MapScalars_56(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), alpha, ref cellFlag, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06003418 RID: 13336
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_NewInstance_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003419 RID: 13337 RVA: 0x0004C948 File Offset: 0x0004AB48
		public new vtkMapper NewInstance()
		{
			vtkMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_NewInstance_57(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600341A RID: 13338
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_ReleaseGraphicsResources_58(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600341B RID: 13339 RVA: 0x0004C9A4 File Offset: 0x0004ABA4
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkMapper.vtkMapper_ReleaseGraphicsResources_58(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600341C RID: 13340
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_Render_59(HandleRef pThis, HandleRef ren, HandleRef a);

		/// <summary>
		/// Method initiates the mapping process. Generally sent by the actor
		/// as each frame is rendered.
		/// </summary>
		// Token: 0x0600341D RID: 13341 RVA: 0x0004C9D4 File Offset: 0x0004ABD4
		public virtual void Render(vtkRenderer ren, vtkActor a)
		{
			vtkMapper.vtkMapper_Render_59(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x0600341E RID: 13342
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper_SafeDownCast_60(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600341F RID: 13343 RVA: 0x0004CA18 File Offset: 0x0004AC18
		public new static vtkMapper SafeDownCast(vtkObjectBase o)
		{
			vtkMapper vtkMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper.vtkMapper_SafeDownCast_60((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapper = (vtkMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapper.Register(null);
				}
			}
			return vtkMapper;
		}

		// Token: 0x06003420 RID: 13344
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_ScalarVisibilityOff_61(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x06003421 RID: 13345 RVA: 0x0004CA97 File Offset: 0x0004AC97
		public virtual void ScalarVisibilityOff()
		{
			vtkMapper.vtkMapper_ScalarVisibilityOff_61(base.GetCppThis());
		}

		// Token: 0x06003422 RID: 13346
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_ScalarVisibilityOn_62(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x06003423 RID: 13347 RVA: 0x0004CAA6 File Offset: 0x0004ACA6
		public virtual void ScalarVisibilityOn()
		{
			vtkMapper.vtkMapper_ScalarVisibilityOn_62(base.GetCppThis());
		}

		// Token: 0x06003424 RID: 13348
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SelectColorArray_63(HandleRef pThis, int arrayNum);

		/// <summary>
		/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
		/// you can specify which array to use for coloring using these methods.
		/// The lookup table will decide how to convert vectors to colors.
		/// </summary>
		// Token: 0x06003425 RID: 13349 RVA: 0x0004CAB5 File Offset: 0x0004ACB5
		public void SelectColorArray(int arrayNum)
		{
			vtkMapper.vtkMapper_SelectColorArray_63(base.GetCppThis(), arrayNum);
		}

		// Token: 0x06003426 RID: 13350
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SelectColorArray_64(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
		/// you can specify which array to use for coloring using these methods.
		/// The lookup table will decide how to convert vectors to colors.
		/// </summary>
		// Token: 0x06003427 RID: 13351 RVA: 0x0004CAC5 File Offset: 0x0004ACC5
		public void SelectColorArray(string arrayName)
		{
			vtkMapper.vtkMapper_SelectColorArray_64(base.GetCppThis(), arrayName);
		}

		// Token: 0x06003428 RID: 13352
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetArrayAccessMode_65(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the array name or number and component to color by.
		/// </summary>
		// Token: 0x06003429 RID: 13353 RVA: 0x0004CAD5 File Offset: 0x0004ACD5
		public virtual void SetArrayAccessMode(int _arg)
		{
			vtkMapper.vtkMapper_SetArrayAccessMode_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0600342A RID: 13354
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetArrayComponent_66(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the array name or number and component to color by.
		/// </summary>
		// Token: 0x0600342B RID: 13355 RVA: 0x0004CAE5 File Offset: 0x0004ACE5
		public virtual void SetArrayComponent(int _arg)
		{
			vtkMapper.vtkMapper_SetArrayComponent_66(base.GetCppThis(), _arg);
		}

		// Token: 0x0600342C RID: 13356
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetArrayId_67(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the array name or number and component to color by.
		/// </summary>
		// Token: 0x0600342D RID: 13357 RVA: 0x0004CAF5 File Offset: 0x0004ACF5
		public virtual void SetArrayId(int _arg)
		{
			vtkMapper.vtkMapper_SetArrayId_67(base.GetCppThis(), _arg);
		}

		// Token: 0x0600342E RID: 13358
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetArrayName_68(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the array name or number and component to color by.
		/// </summary>
		// Token: 0x0600342F RID: 13359 RVA: 0x0004CB05 File Offset: 0x0004AD05
		public virtual void SetArrayName(string _arg)
		{
			vtkMapper.vtkMapper_SetArrayName_68(base.GetCppThis(), _arg);
		}

		// Token: 0x06003430 RID: 13360
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetColorMode_69(HandleRef pThis, int _arg);

		/// <summary>
		/// default (ColorModeToDefault), unsigned char scalars are treated
		/// as colors, and NOT mapped through the lookup table, while
		/// everything else is.  ColorModeToDirectScalar extends
		/// ColorModeToDefault such that all integer types are treated as
		/// colors with values in the range 0-255 and floating types are
		/// treated as colors with values in the range 0.0-1.0.  Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped
		/// through the lookup table.  (Note that for multi-component
		/// scalars, the particular component to use for mapping can be
		/// specified using the SelectColorArray() method.)
		/// </summary>
		// Token: 0x06003431 RID: 13361 RVA: 0x0004CB15 File Offset: 0x0004AD15
		public virtual void SetColorMode(int _arg)
		{
			vtkMapper.vtkMapper_SetColorMode_69(base.GetCppThis(), _arg);
		}

		// Token: 0x06003432 RID: 13362
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetColorModeToDefault_70(HandleRef pThis);

		/// <summary>
		/// default (ColorModeToDefault), unsigned char scalars are treated
		/// as colors, and NOT mapped through the lookup table, while
		/// everything else is.  ColorModeToDirectScalar extends
		/// ColorModeToDefault such that all integer types are treated as
		/// colors with values in the range 0-255 and floating types are
		/// treated as colors with values in the range 0.0-1.0.  Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped
		/// through the lookup table.  (Note that for multi-component
		/// scalars, the particular component to use for mapping can be
		/// specified using the SelectColorArray() method.)
		/// </summary>
		// Token: 0x06003433 RID: 13363 RVA: 0x0004CB25 File Offset: 0x0004AD25
		public void SetColorModeToDefault()
		{
			vtkMapper.vtkMapper_SetColorModeToDefault_70(base.GetCppThis());
		}

		// Token: 0x06003434 RID: 13364
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetColorModeToDirectScalars_71(HandleRef pThis);

		/// <summary>
		/// default (ColorModeToDefault), unsigned char scalars are treated
		/// as colors, and NOT mapped through the lookup table, while
		/// everything else is.  ColorModeToDirectScalar extends
		/// ColorModeToDefault such that all integer types are treated as
		/// colors with values in the range 0-255 and floating types are
		/// treated as colors with values in the range 0.0-1.0.  Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped
		/// through the lookup table.  (Note that for multi-component
		/// scalars, the particular component to use for mapping can be
		/// specified using the SelectColorArray() method.)
		/// </summary>
		// Token: 0x06003435 RID: 13365 RVA: 0x0004CB34 File Offset: 0x0004AD34
		public void SetColorModeToDirectScalars()
		{
			vtkMapper.vtkMapper_SetColorModeToDirectScalars_71(base.GetCppThis());
		}

		// Token: 0x06003436 RID: 13366
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetColorModeToMapScalars_72(HandleRef pThis);

		/// <summary>
		/// default (ColorModeToDefault), unsigned char scalars are treated
		/// as colors, and NOT mapped through the lookup table, while
		/// everything else is.  ColorModeToDirectScalar extends
		/// ColorModeToDefault such that all integer types are treated as
		/// colors with values in the range 0-255 and floating types are
		/// treated as colors with values in the range 0.0-1.0.  Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped
		/// through the lookup table.  (Note that for multi-component
		/// scalars, the particular component to use for mapping can be
		/// specified using the SelectColorArray() method.)
		/// </summary>
		// Token: 0x06003437 RID: 13367 RVA: 0x0004CB43 File Offset: 0x0004AD43
		public void SetColorModeToMapScalars()
		{
			vtkMapper.vtkMapper_SetColorModeToMapScalars_72(base.GetCppThis());
		}

		// Token: 0x06003438 RID: 13368
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetFieldDataTupleId_73(HandleRef pThis, long _arg);

		/// <summary>
		/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
		/// you can specify which array to use for coloring using these methods.
		/// The lookup table will decide how to convert vectors to colors.
		/// </summary>
		// Token: 0x06003439 RID: 13369 RVA: 0x0004CB52 File Offset: 0x0004AD52
		public virtual void SetFieldDataTupleId(long _arg)
		{
			vtkMapper.vtkMapper_SetFieldDataTupleId_73(base.GetCppThis(), _arg);
		}

		// Token: 0x0600343A RID: 13370
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetInterpolateScalarsBeforeMapping_74(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, vertex color is used to map colors to a surface.
		/// Colors are interpolated after being mapped.
		/// This option avoids color interpolation by using a one dimensional
		/// texture map for the colors.
		/// </summary>
		// Token: 0x0600343B RID: 13371 RVA: 0x0004CB62 File Offset: 0x0004AD62
		public virtual void SetInterpolateScalarsBeforeMapping(int _arg)
		{
			vtkMapper.vtkMapper_SetInterpolateScalarsBeforeMapping_74(base.GetCppThis(), _arg);
		}

		// Token: 0x0600343C RID: 13372
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetLookupTable_75(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x0600343D RID: 13373 RVA: 0x0004CB74 File Offset: 0x0004AD74
		public void SetLookupTable(vtkScalarsToColors lut)
		{
			vtkMapper.vtkMapper_SetLookupTable_75(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x0600343E RID: 13374
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetRelativeCoincidentTopologyLineOffsetParameters_76(HandleRef pThis, double factor, double units);

		/// <summary>
		/// Used to set the line offset values relative to the global
		/// Used when ResolveCoincidentTopology is set to PolygonOffset.
		/// </summary>
		// Token: 0x0600343F RID: 13375 RVA: 0x0004CBA3 File Offset: 0x0004ADA3
		public void SetRelativeCoincidentTopologyLineOffsetParameters(double factor, double units)
		{
			vtkMapper.vtkMapper_SetRelativeCoincidentTopologyLineOffsetParameters_76(base.GetCppThis(), factor, units);
		}

		// Token: 0x06003440 RID: 13376
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetRelativeCoincidentTopologyPointOffsetParameter_77(HandleRef pThis, double units);

		/// <summary>
		/// Used to set the point offset value relative to the global
		/// Used when ResolveCoincidentTopology is set to PolygonOffset.
		/// </summary>
		// Token: 0x06003441 RID: 13377 RVA: 0x0004CBB4 File Offset: 0x0004ADB4
		public void SetRelativeCoincidentTopologyPointOffsetParameter(double units)
		{
			vtkMapper.vtkMapper_SetRelativeCoincidentTopologyPointOffsetParameter_77(base.GetCppThis(), units);
		}

		// Token: 0x06003442 RID: 13378
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetRelativeCoincidentTopologyPolygonOffsetParameters_78(HandleRef pThis, double factor, double units);

		/// <summary>
		/// Used to set the polygon offset values relative to the global
		/// Used when ResolveCoincidentTopology is set to PolygonOffset.
		/// </summary>
		// Token: 0x06003443 RID: 13379 RVA: 0x0004CBC4 File Offset: 0x0004ADC4
		public void SetRelativeCoincidentTopologyPolygonOffsetParameters(double factor, double units)
		{
			vtkMapper.vtkMapper_SetRelativeCoincidentTopologyPolygonOffsetParameters_78(base.GetCppThis(), factor, units);
		}

		// Token: 0x06003444 RID: 13380
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetRenderTime_79(HandleRef pThis, double time);

		/// <summary>
		/// This instance variable is used by vtkLODActor to determine which
		/// mapper to use.  It is an estimate of the time necessary to render.
		/// Setting the render time does not modify the mapper.
		/// </summary>
		// Token: 0x06003445 RID: 13381 RVA: 0x0004CBD5 File Offset: 0x0004ADD5
		public void SetRenderTime(double time)
		{
			vtkMapper.vtkMapper_SetRenderTime_79(base.GetCppThis(), time);
		}

		// Token: 0x06003446 RID: 13382
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetResolveCoincidentTopology_80(int val);

		/// <summary>
		/// Set/Get a global flag that controls whether coincident topology (e.g., a
		/// line on top of a polygon) is shifted to avoid z-buffer resolution (and
		/// hence rendering problems). If not off, there are two methods to choose
		/// from. PolygonOffset uses graphics systems calls to shift polygons, lines
		/// and points from each other. ShiftZBuffer is a legacy method that used to
		/// remap the z-buffer to distinguish vertices, lines, and polygons, but
		/// does not always produce acceptable results. You should only use the
		/// PolygonOffset method (or none) at this point.
		/// </summary>
		// Token: 0x06003447 RID: 13383 RVA: 0x0004CBE5 File Offset: 0x0004ADE5
		public static void SetResolveCoincidentTopology(int val)
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopology_80(val);
		}

		// Token: 0x06003448 RID: 13384
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyLineOffsetParameters_81(double factor, double units);

		/// <summary>
		/// Used to set the line offset scale factor and units.
		/// Used when ResolveCoincidentTopology is set to PolygonOffset.
		/// These are global variables.
		/// </summary>
		// Token: 0x06003449 RID: 13385 RVA: 0x0004CBEF File Offset: 0x0004ADEF
		public static void SetResolveCoincidentTopologyLineOffsetParameters(double factor, double units)
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyLineOffsetParameters_81(factor, units);
		}

		// Token: 0x0600344A RID: 13386
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyPointOffsetParameter_82(double units);

		/// <summary>
		/// Used to set the point offset value
		/// Used when ResolveCoincidentTopology is set to PolygonOffset.
		/// These are global variables.
		/// </summary>
		// Token: 0x0600344B RID: 13387 RVA: 0x0004CBFA File Offset: 0x0004ADFA
		public static void SetResolveCoincidentTopologyPointOffsetParameter(double units)
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyPointOffsetParameter_82(units);
		}

		// Token: 0x0600344C RID: 13388
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyPolygonOffsetFaces_83(int faces);

		/// <summary>
		/// Used when ResolveCoincidentTopology is set to PolygonOffset. The polygon
		/// offset can be applied either to the solid polygonal faces or the
		/// lines/vertices. When set (default), the offset is applied to the faces
		/// otherwise it is applied to lines and vertices.
		/// This is a global variable.
		/// </summary>
		// Token: 0x0600344D RID: 13389 RVA: 0x0004CC04 File Offset: 0x0004AE04
		public static void SetResolveCoincidentTopologyPolygonOffsetFaces(int faces)
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyPolygonOffsetFaces_83(faces);
		}

		// Token: 0x0600344E RID: 13390
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyPolygonOffsetParameters_84(double factor, double units);

		/// <summary>
		/// Used to set the polygon offset scale factor and units.
		/// Used when ResolveCoincidentTopology is set to PolygonOffset.
		/// These are global variables.
		/// </summary>
		// Token: 0x0600344F RID: 13391 RVA: 0x0004CC0E File Offset: 0x0004AE0E
		public static void SetResolveCoincidentTopologyPolygonOffsetParameters(double factor, double units)
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyPolygonOffsetParameters_84(factor, units);
		}

		// Token: 0x06003450 RID: 13392
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyToDefault_85();

		/// <summary>
		/// Set/Get a global flag that controls whether coincident topology (e.g., a
		/// line on top of a polygon) is shifted to avoid z-buffer resolution (and
		/// hence rendering problems). If not off, there are two methods to choose
		/// from. PolygonOffset uses graphics systems calls to shift polygons, lines
		/// and points from each other. ShiftZBuffer is a legacy method that used to
		/// remap the z-buffer to distinguish vertices, lines, and polygons, but
		/// does not always produce acceptable results. You should only use the
		/// PolygonOffset method (or none) at this point.
		/// </summary>
		// Token: 0x06003451 RID: 13393 RVA: 0x0004CC19 File Offset: 0x0004AE19
		public static void SetResolveCoincidentTopologyToDefault()
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyToDefault_85();
		}

		// Token: 0x06003452 RID: 13394
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyToOff_86();

		/// <summary>
		/// Set/Get a global flag that controls whether coincident topology (e.g., a
		/// line on top of a polygon) is shifted to avoid z-buffer resolution (and
		/// hence rendering problems). If not off, there are two methods to choose
		/// from. PolygonOffset uses graphics systems calls to shift polygons, lines
		/// and points from each other. ShiftZBuffer is a legacy method that used to
		/// remap the z-buffer to distinguish vertices, lines, and polygons, but
		/// does not always produce acceptable results. You should only use the
		/// PolygonOffset method (or none) at this point.
		/// </summary>
		// Token: 0x06003453 RID: 13395 RVA: 0x0004CC22 File Offset: 0x0004AE22
		public static void SetResolveCoincidentTopologyToOff()
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyToOff_86();
		}

		// Token: 0x06003454 RID: 13396
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyToPolygonOffset_87();

		/// <summary>
		/// Set/Get a global flag that controls whether coincident topology (e.g., a
		/// line on top of a polygon) is shifted to avoid z-buffer resolution (and
		/// hence rendering problems). If not off, there are two methods to choose
		/// from. PolygonOffset uses graphics systems calls to shift polygons, lines
		/// and points from each other. ShiftZBuffer is a legacy method that used to
		/// remap the z-buffer to distinguish vertices, lines, and polygons, but
		/// does not always produce acceptable results. You should only use the
		/// PolygonOffset method (or none) at this point.
		/// </summary>
		// Token: 0x06003455 RID: 13397 RVA: 0x0004CC2B File Offset: 0x0004AE2B
		public static void SetResolveCoincidentTopologyToPolygonOffset()
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyToPolygonOffset_87();
		}

		// Token: 0x06003456 RID: 13398
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyToShiftZBuffer_88();

		/// <summary>
		/// Set/Get a global flag that controls whether coincident topology (e.g., a
		/// line on top of a polygon) is shifted to avoid z-buffer resolution (and
		/// hence rendering problems). If not off, there are two methods to choose
		/// from. PolygonOffset uses graphics systems calls to shift polygons, lines
		/// and points from each other. ShiftZBuffer is a legacy method that used to
		/// remap the z-buffer to distinguish vertices, lines, and polygons, but
		/// does not always produce acceptable results. You should only use the
		/// PolygonOffset method (or none) at this point.
		/// </summary>
		// Token: 0x06003457 RID: 13399 RVA: 0x0004CC34 File Offset: 0x0004AE34
		public static void SetResolveCoincidentTopologyToShiftZBuffer()
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyToShiftZBuffer_88();
		}

		// Token: 0x06003458 RID: 13400
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyZShift_89(double val);

		/// <summary>
		/// Used to set the z-shift if ResolveCoincidentTopology is set to
		/// ShiftZBuffer. This is a global variable.
		/// </summary>
		// Token: 0x06003459 RID: 13401 RVA: 0x0004CC3D File Offset: 0x0004AE3D
		public static void SetResolveCoincidentTopologyZShift(double val)
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyZShift_89(val);
		}

		// Token: 0x0600345A RID: 13402
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetScalarMode_90(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectColorArray before you call
		/// GetColors.
		/// </summary>
		// Token: 0x0600345B RID: 13403 RVA: 0x0004CC47 File Offset: 0x0004AE47
		public virtual void SetScalarMode(int _arg)
		{
			vtkMapper.vtkMapper_SetScalarMode_90(base.GetCppThis(), _arg);
		}

		// Token: 0x0600345C RID: 13404
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetScalarModeToDefault_91(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectColorArray before you call
		/// GetColors.
		/// </summary>
		// Token: 0x0600345D RID: 13405 RVA: 0x0004CC57 File Offset: 0x0004AE57
		public void SetScalarModeToDefault()
		{
			vtkMapper.vtkMapper_SetScalarModeToDefault_91(base.GetCppThis());
		}

		// Token: 0x0600345E RID: 13406
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetScalarModeToUseCellData_92(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectColorArray before you call
		/// GetColors.
		/// </summary>
		// Token: 0x0600345F RID: 13407 RVA: 0x0004CC66 File Offset: 0x0004AE66
		public void SetScalarModeToUseCellData()
		{
			vtkMapper.vtkMapper_SetScalarModeToUseCellData_92(base.GetCppThis());
		}

		// Token: 0x06003460 RID: 13408
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetScalarModeToUseCellFieldData_93(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectColorArray before you call
		/// GetColors.
		/// </summary>
		// Token: 0x06003461 RID: 13409 RVA: 0x0004CC75 File Offset: 0x0004AE75
		public void SetScalarModeToUseCellFieldData()
		{
			vtkMapper.vtkMapper_SetScalarModeToUseCellFieldData_93(base.GetCppThis());
		}

		// Token: 0x06003462 RID: 13410
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetScalarModeToUseFieldData_94(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectColorArray before you call
		/// GetColors.
		/// </summary>
		// Token: 0x06003463 RID: 13411 RVA: 0x0004CC84 File Offset: 0x0004AE84
		public void SetScalarModeToUseFieldData()
		{
			vtkMapper.vtkMapper_SetScalarModeToUseFieldData_94(base.GetCppThis());
		}

		// Token: 0x06003464 RID: 13412
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetScalarModeToUsePointData_95(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectColorArray before you call
		/// GetColors.
		/// </summary>
		// Token: 0x06003465 RID: 13413 RVA: 0x0004CC93 File Offset: 0x0004AE93
		public void SetScalarModeToUsePointData()
		{
			vtkMapper.vtkMapper_SetScalarModeToUsePointData_95(base.GetCppThis());
		}

		// Token: 0x06003466 RID: 13414
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetScalarModeToUsePointFieldData_96(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectColorArray before you call
		/// GetColors.
		/// </summary>
		// Token: 0x06003467 RID: 13415 RVA: 0x0004CCA2 File Offset: 0x0004AEA2
		public void SetScalarModeToUsePointFieldData()
		{
			vtkMapper.vtkMapper_SetScalarModeToUsePointFieldData_96(base.GetCppThis());
		}

		// Token: 0x06003468 RID: 13416
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetScalarRange_97(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify range in terms of scalar minimum and maximum (smin,smax). These
		/// values are used to map scalars into lookup table. Has no effect when
		/// UseLookupTableScalarRange is true.
		/// </summary>
		// Token: 0x06003469 RID: 13417 RVA: 0x0004CCB1 File Offset: 0x0004AEB1
		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkMapper.vtkMapper_SetScalarRange_97(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600346A RID: 13418
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetScalarRange_98(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify range in terms of scalar minimum and maximum (smin,smax). These
		/// values are used to map scalars into lookup table. Has no effect when
		/// UseLookupTableScalarRange is true.
		/// </summary>
		// Token: 0x0600346B RID: 13419 RVA: 0x0004CCC2 File Offset: 0x0004AEC2
		public void SetScalarRange(IntPtr _arg)
		{
			vtkMapper.vtkMapper_SetScalarRange_98(base.GetCppThis(), _arg);
		}

		// Token: 0x0600346C RID: 13420
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetScalarVisibility_99(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x0600346D RID: 13421 RVA: 0x0004CCD2 File Offset: 0x0004AED2
		public virtual void SetScalarVisibility(int _arg)
		{
			vtkMapper.vtkMapper_SetScalarVisibility_99(base.GetCppThis(), _arg);
		}

		// Token: 0x0600346E RID: 13422
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetSelection_100(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get selection used to display particular points or cells in a second pass.
		/// This can be use to efficiently display a selection.
		/// </summary>
		// Token: 0x0600346F RID: 13423 RVA: 0x0004CCE4 File Offset: 0x0004AEE4
		public virtual void SetSelection(vtkSelection arg0)
		{
			vtkMapper.vtkMapper_SetSelection_100(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003470 RID: 13424
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetStatic_101(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off flag to control whether the mapper's data is static. Static data
		/// means that the mapper does not propagate updates down the pipeline, greatly
		/// decreasing the time it takes to update many mappers. This should only be
		/// used if the data never changes.
		/// </summary>
		// Token: 0x06003471 RID: 13425 RVA: 0x0004CD13 File Offset: 0x0004AF13
		public virtual void SetStatic(int _arg)
		{
			vtkMapper.vtkMapper_SetStatic_101(base.GetCppThis(), _arg);
		}

		// Token: 0x06003472 RID: 13426
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_SetUseLookupTableScalarRange_102(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether the mapper sets the lookuptable range based on its
		/// own ScalarRange, or whether it will use the LookupTable ScalarRange
		/// regardless of it's own setting. By default the Mapper is allowed to set
		/// the LookupTable range, but users who are sharing LookupTables between
		/// mappers/actors will probably wish to force the mapper to use the
		/// LookupTable unchanged.
		/// </summary>
		// Token: 0x06003473 RID: 13427 RVA: 0x0004CD23 File Offset: 0x0004AF23
		public virtual void SetUseLookupTableScalarRange(int _arg)
		{
			vtkMapper.vtkMapper_SetUseLookupTableScalarRange_102(base.GetCppThis(), _arg);
		}

		// Token: 0x06003474 RID: 13428
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_ShallowCopy_103(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Make a shallow copy of this mapper.
		/// </summary>
		// Token: 0x06003475 RID: 13429 RVA: 0x0004CD34 File Offset: 0x0004AF34
		public override void ShallowCopy(vtkAbstractMapper m)
		{
			vtkMapper.vtkMapper_ShallowCopy_103(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x06003476 RID: 13430
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_StaticOff_104(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether the mapper's data is static. Static data
		/// means that the mapper does not propagate updates down the pipeline, greatly
		/// decreasing the time it takes to update many mappers. This should only be
		/// used if the data never changes.
		/// </summary>
		// Token: 0x06003477 RID: 13431 RVA: 0x0004CD63 File Offset: 0x0004AF63
		public virtual void StaticOff()
		{
			vtkMapper.vtkMapper_StaticOff_104(base.GetCppThis());
		}

		// Token: 0x06003478 RID: 13432
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_StaticOn_105(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether the mapper's data is static. Static data
		/// means that the mapper does not propagate updates down the pipeline, greatly
		/// decreasing the time it takes to update many mappers. This should only be
		/// used if the data never changes.
		/// </summary>
		// Token: 0x06003479 RID: 13433 RVA: 0x0004CD72 File Offset: 0x0004AF72
		public virtual void StaticOn()
		{
			vtkMapper.vtkMapper_StaticOn_105(base.GetCppThis());
		}

		// Token: 0x0600347A RID: 13434
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_UseLookupTableScalarRangeOff_106(HandleRef pThis);

		/// <summary>
		/// Control whether the mapper sets the lookuptable range based on its
		/// own ScalarRange, or whether it will use the LookupTable ScalarRange
		/// regardless of it's own setting. By default the Mapper is allowed to set
		/// the LookupTable range, but users who are sharing LookupTables between
		/// mappers/actors will probably wish to force the mapper to use the
		/// LookupTable unchanged.
		/// </summary>
		// Token: 0x0600347B RID: 13435 RVA: 0x0004CD81 File Offset: 0x0004AF81
		public virtual void UseLookupTableScalarRangeOff()
		{
			vtkMapper.vtkMapper_UseLookupTableScalarRangeOff_106(base.GetCppThis());
		}

		// Token: 0x0600347C RID: 13436
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper_UseLookupTableScalarRangeOn_107(HandleRef pThis);

		/// <summary>
		/// Control whether the mapper sets the lookuptable range based on its
		/// own ScalarRange, or whether it will use the LookupTable ScalarRange
		/// regardless of it's own setting. By default the Mapper is allowed to set
		/// the LookupTable range, but users who are sharing LookupTables between
		/// mappers/actors will probably wish to force the mapper to use the
		/// LookupTable unchanged.
		/// </summary>
		// Token: 0x0600347D RID: 13437 RVA: 0x0004CD90 File Offset: 0x0004AF90
		public virtual void UseLookupTableScalarRangeOn()
		{
			vtkMapper.vtkMapper_UseLookupTableScalarRangeOn_107(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000626 RID: 1574
		public new const string MRFullTypeName = "Kitware.VTK.vtkMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000627 RID: 1575
		public new static readonly string MRClassNameKey = "class vtkMapper";
	}
}
