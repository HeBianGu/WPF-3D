using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkClipVolume
	/// </summary>
	/// <remarks>
	///    clip volume data with user-specified implicit function or input scalar data
	///
	/// vtkClipVolume is a filter that clips volume data (i.e., vtkImageData)
	/// using either: any subclass of vtkImplicitFunction or the input scalar
	/// data. The clipping operation cuts through the cells of the
	/// dataset--converting 3D image data into a 3D unstructured grid--returning
	/// everything inside of the specified implicit function (or greater than the
	/// scalar value). During the clipping the filter will produce pieces of a
	/// cell. (Compare this with vtkExtractGeometry or vtkGeometryFilter, which
	/// produces entire, uncut cells.) The output of this filter is a 3D
	/// unstructured grid (e.g., tetrahedra or other 3D cell types).
	///
	/// To use this filter, you must decide if you will be clipping with an
	/// implicit function, or whether you will be using the input scalar data.  If
	/// you want to clip with an implicit function, you must first define and then
	/// set the implicit function with the SetClipFunction() method. Otherwise,
	/// you must make sure input scalar data is available. You can also specify a
	/// scalar value, which is used to decide what is inside and outside of the
	/// implicit function. You can also reverse the sense of what inside/outside
	/// is by setting the InsideOut instance variable. (The cutting algorithm
	/// proceeds by computing an implicit function value or using the input scalar
	/// data for each point in the dataset. This is compared to the scalar value
	/// to determine inside/outside.)
	///
	/// This filter can be configured to compute a second output. The
	/// second output is the portion of the volume that is clipped away. Set the
	/// GenerateClippedData boolean on if you wish to access this output data.
	///
	/// The filter will produce an unstructured grid of entirely tetrahedra or a
	/// mixed grid of tetrahedra and other 3D cell types (e.g., wedges). Control
	/// this behavior by setting the Mixed3DCellGeneration. By default the
	/// Mixed3DCellGeneration is on and a combination of cell types will be
	/// produced. Note that producing mixed cell types is a faster than producing
	/// only tetrahedra.
	///
	/// @warning
	/// This filter is designed to function with 3D structured points. Clipping
	/// 2D images should be done by converting the image to polygonal data
	/// and using vtkClipPolyData,
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunction vtkClipPolyData vtkGeometryFilter vtkExtractGeometry
	/// </seealso>
	// Token: 0x02000884 RID: 2180
	public class vtkClipVolume : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016A36 RID: 92726 RVA: 0x001FD777 File Offset: 0x001FB977
		static vtkClipVolume()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClipVolume.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipVolume"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016A37 RID: 92727 RVA: 0x001FD79F File Offset: 0x001FB99F
		public vtkClipVolume(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016A38 RID: 92728
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipVolume_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with user-specified implicit function; InsideOut turned off;
		/// value set to 0.0; and generate clip scalars turned off.
		/// </summary>
		// Token: 0x06016A39 RID: 92729 RVA: 0x001FD7B0 File Offset: 0x001FB9B0
		public new static vtkClipVolume New()
		{
			vtkClipVolume result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipVolume.vtkClipVolume_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with user-specified implicit function; InsideOut turned off;
		/// value set to 0.0; and generate clip scalars turned off.
		/// </summary>
		// Token: 0x06016A3A RID: 92730 RVA: 0x001FD804 File Offset: 0x001FBA04
		public vtkClipVolume() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkClipVolume.vtkClipVolume_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016A3B RID: 92731 RVA: 0x001FD848 File Offset: 0x001FBA48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016A3C RID: 92732
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified. The
		/// locator is used to merge coincident points.
		/// </summary>
		// Token: 0x06016A3D RID: 92733 RVA: 0x001FD853 File Offset: 0x001FBA53
		public void CreateDefaultLocator()
		{
			vtkClipVolume.vtkClipVolume_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x06016A3E RID: 92734
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_GenerateClipScalarsOff_02(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// </summary>
		// Token: 0x06016A3F RID: 92735 RVA: 0x001FD862 File Offset: 0x001FBA62
		public virtual void GenerateClipScalarsOff()
		{
			vtkClipVolume.vtkClipVolume_GenerateClipScalarsOff_02(base.GetCppThis());
		}

		// Token: 0x06016A40 RID: 92736
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_GenerateClipScalarsOn_03(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// </summary>
		// Token: 0x06016A41 RID: 92737 RVA: 0x001FD871 File Offset: 0x001FBA71
		public virtual void GenerateClipScalarsOn()
		{
			vtkClipVolume.vtkClipVolume_GenerateClipScalarsOn_03(base.GetCppThis());
		}

		// Token: 0x06016A42 RID: 92738
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_GenerateClippedOutputOff_04(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the unstructured grid that's been clipped away.
		/// </summary>
		// Token: 0x06016A43 RID: 92739 RVA: 0x001FD880 File Offset: 0x001FBA80
		public virtual void GenerateClippedOutputOff()
		{
			vtkClipVolume.vtkClipVolume_GenerateClippedOutputOff_04(base.GetCppThis());
		}

		// Token: 0x06016A44 RID: 92740
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_GenerateClippedOutputOn_05(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the unstructured grid that's been clipped away.
		/// </summary>
		// Token: 0x06016A45 RID: 92741 RVA: 0x001FD88F File Offset: 0x001FBA8F
		public virtual void GenerateClippedOutputOn()
		{
			vtkClipVolume.vtkClipVolume_GenerateClippedOutputOn_05(base.GetCppThis());
		}

		// Token: 0x06016A46 RID: 92742
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipVolume_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function with which to perform the clipping. If you
		/// do not define an implicit function, then the input scalar data will be
		/// used for clipping.
		/// </summary>
		// Token: 0x06016A47 RID: 92743 RVA: 0x001FD8A0 File Offset: 0x001FBAA0
		public virtual vtkImplicitFunction GetClipFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipVolume.vtkClipVolume_GetClipFunction_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06016A48 RID: 92744
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipVolume_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the clipped output.
		/// </summary>
		// Token: 0x06016A49 RID: 92745 RVA: 0x001FD910 File Offset: 0x001FBB10
		public vtkUnstructuredGrid GetClippedOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipVolume.vtkClipVolume_GetClippedOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x06016A4A RID: 92746
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipVolume_GetGenerateClipScalars_08(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// </summary>
		// Token: 0x06016A4B RID: 92747 RVA: 0x001FD980 File Offset: 0x001FBB80
		public virtual int GetGenerateClipScalars()
		{
			return vtkClipVolume.vtkClipVolume_GetGenerateClipScalars_08(base.GetCppThis());
		}

		// Token: 0x06016A4C RID: 92748
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipVolume_GetGenerateClippedOutput_09(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the unstructured grid that's been clipped away.
		/// </summary>
		// Token: 0x06016A4D RID: 92749 RVA: 0x001FD9A0 File Offset: 0x001FBBA0
		public virtual int GetGenerateClippedOutput()
		{
			return vtkClipVolume.vtkClipVolume_GetGenerateClippedOutput_09(base.GetCppThis());
		}

		// Token: 0x06016A4E RID: 92750
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipVolume_GetInsideOut_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered inside the
		/// implicit function if its value is greater than the Value ivar. When
		/// InsideOutside is turned on, a vertex is considered inside the implicit
		/// function if its implicit function value is less than or equal to the
		/// Value ivar.  InsideOut is off by default.
		/// </summary>
		// Token: 0x06016A4F RID: 92751 RVA: 0x001FD9C0 File Offset: 0x001FBBC0
		public virtual int GetInsideOut()
		{
			return vtkClipVolume.vtkClipVolume_GetInsideOut_10(base.GetCppThis());
		}

		// Token: 0x06016A50 RID: 92752
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipVolume_GetLocator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / Get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06016A51 RID: 92753 RVA: 0x001FD9E0 File Offset: 0x001FBBE0
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipVolume.vtkClipVolume_GetLocator_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		// Token: 0x06016A52 RID: 92754
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkClipVolume_GetMTime_12(HandleRef pThis);

		/// <summary>
		/// Return the mtime also considering the locator and clip function.
		/// </summary>
		// Token: 0x06016A53 RID: 92755 RVA: 0x001FDA50 File Offset: 0x001FBC50
		public override ulong GetMTime()
		{
			return vtkClipVolume.vtkClipVolume_GetMTime_12(base.GetCppThis());
		}

		// Token: 0x06016A54 RID: 92756
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClipVolume_GetMergeTolerance_13(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the corners of voxels. This tolerance is used to prevent the generation
		/// of degenerate tetrahedra.
		/// </summary>
		// Token: 0x06016A55 RID: 92757 RVA: 0x001FDA70 File Offset: 0x001FBC70
		public virtual double GetMergeTolerance()
		{
			return vtkClipVolume.vtkClipVolume_GetMergeTolerance_13(base.GetCppThis());
		}

		// Token: 0x06016A56 RID: 92758
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClipVolume_GetMergeToleranceMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the corners of voxels. This tolerance is used to prevent the generation
		/// of degenerate tetrahedra.
		/// </summary>
		// Token: 0x06016A57 RID: 92759 RVA: 0x001FDA90 File Offset: 0x001FBC90
		public virtual double GetMergeToleranceMaxValue()
		{
			return vtkClipVolume.vtkClipVolume_GetMergeToleranceMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06016A58 RID: 92760
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClipVolume_GetMergeToleranceMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the corners of voxels. This tolerance is used to prevent the generation
		/// of degenerate tetrahedra.
		/// </summary>
		// Token: 0x06016A59 RID: 92761 RVA: 0x001FDAB0 File Offset: 0x001FBCB0
		public virtual double GetMergeToleranceMinValue()
		{
			return vtkClipVolume.vtkClipVolume_GetMergeToleranceMinValue_15(base.GetCppThis());
		}

		// Token: 0x06016A5A RID: 92762
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipVolume_GetMixed3DCellGeneration_16(HandleRef pThis);

		/// <summary>
		/// Control whether the filter produces a mix of 3D cell types on output, or
		/// whether the output cells are all tetrahedra. By default, a mixed set of
		/// cells (e.g., tetrahedra and wedges) is produced. (Note: mixed type
		/// generation is faster and less overall data is generated.)
		/// </summary>
		// Token: 0x06016A5B RID: 92763 RVA: 0x001FDAD0 File Offset: 0x001FBCD0
		public virtual int GetMixed3DCellGeneration()
		{
			return vtkClipVolume.vtkClipVolume_GetMixed3DCellGeneration_16(base.GetCppThis());
		}

		// Token: 0x06016A5C RID: 92764
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClipVolume_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A5D RID: 92765 RVA: 0x001FDAF0 File Offset: 0x001FBCF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkClipVolume.vtkClipVolume_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x06016A5E RID: 92766
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClipVolume_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A5F RID: 92767 RVA: 0x001FDB10 File Offset: 0x001FBD10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkClipVolume.vtkClipVolume_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x06016A60 RID: 92768
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClipVolume_GetValue_19(HandleRef pThis);

		/// <summary>
		/// Set the clipping value of the implicit function (if clipping with
		/// implicit function) or scalar value (if clipping with scalars). The
		/// default value is 0.0.
		/// </summary>
		// Token: 0x06016A61 RID: 92769 RVA: 0x001FDB2C File Offset: 0x001FBD2C
		public virtual double GetValue()
		{
			return vtkClipVolume.vtkClipVolume_GetValue_19(base.GetCppThis());
		}

		// Token: 0x06016A62 RID: 92770
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_InsideOutOff_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered inside the
		/// implicit function if its value is greater than the Value ivar. When
		/// InsideOutside is turned on, a vertex is considered inside the implicit
		/// function if its implicit function value is less than or equal to the
		/// Value ivar.  InsideOut is off by default.
		/// </summary>
		// Token: 0x06016A63 RID: 92771 RVA: 0x001FDB4B File Offset: 0x001FBD4B
		public virtual void InsideOutOff()
		{
			vtkClipVolume.vtkClipVolume_InsideOutOff_20(base.GetCppThis());
		}

		// Token: 0x06016A64 RID: 92772
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_InsideOutOn_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered inside the
		/// implicit function if its value is greater than the Value ivar. When
		/// InsideOutside is turned on, a vertex is considered inside the implicit
		/// function if its implicit function value is less than or equal to the
		/// Value ivar.  InsideOut is off by default.
		/// </summary>
		// Token: 0x06016A65 RID: 92773 RVA: 0x001FDB5A File Offset: 0x001FBD5A
		public virtual void InsideOutOn()
		{
			vtkClipVolume.vtkClipVolume_InsideOutOn_21(base.GetCppThis());
		}

		// Token: 0x06016A66 RID: 92774
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipVolume_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A67 RID: 92775 RVA: 0x001FDB6C File Offset: 0x001FBD6C
		public override int IsA(string type)
		{
			return vtkClipVolume.vtkClipVolume_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06016A68 RID: 92776
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipVolume_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A69 RID: 92777 RVA: 0x001FDB8C File Offset: 0x001FBD8C
		public new static int IsTypeOf(string type)
		{
			return vtkClipVolume.vtkClipVolume_IsTypeOf_23(type);
		}

		// Token: 0x06016A6A RID: 92778
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_Mixed3DCellGenerationOff_24(HandleRef pThis);

		/// <summary>
		/// Control whether the filter produces a mix of 3D cell types on output, or
		/// whether the output cells are all tetrahedra. By default, a mixed set of
		/// cells (e.g., tetrahedra and wedges) is produced. (Note: mixed type
		/// generation is faster and less overall data is generated.)
		/// </summary>
		// Token: 0x06016A6B RID: 92779 RVA: 0x001FDBA6 File Offset: 0x001FBDA6
		public virtual void Mixed3DCellGenerationOff()
		{
			vtkClipVolume.vtkClipVolume_Mixed3DCellGenerationOff_24(base.GetCppThis());
		}

		// Token: 0x06016A6C RID: 92780
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_Mixed3DCellGenerationOn_25(HandleRef pThis);

		/// <summary>
		/// Control whether the filter produces a mix of 3D cell types on output, or
		/// whether the output cells are all tetrahedra. By default, a mixed set of
		/// cells (e.g., tetrahedra and wedges) is produced. (Note: mixed type
		/// generation is faster and less overall data is generated.)
		/// </summary>
		// Token: 0x06016A6D RID: 92781 RVA: 0x001FDBB5 File Offset: 0x001FBDB5
		public virtual void Mixed3DCellGenerationOn()
		{
			vtkClipVolume.vtkClipVolume_Mixed3DCellGenerationOn_25(base.GetCppThis());
		}

		// Token: 0x06016A6E RID: 92782
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipVolume_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A6F RID: 92783 RVA: 0x001FDBC4 File Offset: 0x001FBDC4
		public new vtkClipVolume NewInstance()
		{
			vtkClipVolume result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipVolume.vtkClipVolume_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016A70 RID: 92784
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipVolume_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A71 RID: 92785 RVA: 0x001FDC20 File Offset: 0x001FBE20
		public new static vtkClipVolume SafeDownCast(vtkObjectBase o)
		{
			vtkClipVolume vtkClipVolume = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipVolume.vtkClipVolume_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipVolume = (vtkClipVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipVolume.Register(null);
				}
			}
			return vtkClipVolume;
		}

		// Token: 0x06016A72 RID: 92786
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_SetClipFunction_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function with which to perform the clipping. If you
		/// do not define an implicit function, then the input scalar data will be
		/// used for clipping.
		/// </summary>
		// Token: 0x06016A73 RID: 92787 RVA: 0x001FDCA0 File Offset: 0x001FBEA0
		public virtual void SetClipFunction(vtkImplicitFunction arg0)
		{
			vtkClipVolume.vtkClipVolume_SetClipFunction_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06016A74 RID: 92788
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_SetGenerateClipScalars_30(HandleRef pThis, int _arg);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// </summary>
		// Token: 0x06016A75 RID: 92789 RVA: 0x001FDCCF File Offset: 0x001FBECF
		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkClipVolume.vtkClipVolume_SetGenerateClipScalars_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06016A76 RID: 92790
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_SetGenerateClippedOutput_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the unstructured grid that's been clipped away.
		/// </summary>
		// Token: 0x06016A77 RID: 92791 RVA: 0x001FDCDF File Offset: 0x001FBEDF
		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkClipVolume.vtkClipVolume_SetGenerateClippedOutput_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06016A78 RID: 92792
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_SetInsideOut_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered inside the
		/// implicit function if its value is greater than the Value ivar. When
		/// InsideOutside is turned on, a vertex is considered inside the implicit
		/// function if its implicit function value is less than or equal to the
		/// Value ivar.  InsideOut is off by default.
		/// </summary>
		// Token: 0x06016A79 RID: 92793 RVA: 0x001FDCEF File Offset: 0x001FBEEF
		public virtual void SetInsideOut(int _arg)
		{
			vtkClipVolume.vtkClipVolume_SetInsideOut_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06016A7A RID: 92794
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_SetLocator_33(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / Get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06016A7B RID: 92795 RVA: 0x001FDD00 File Offset: 0x001FBF00
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkClipVolume.vtkClipVolume_SetLocator_33(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x06016A7C RID: 92796
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_SetMergeTolerance_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the corners of voxels. This tolerance is used to prevent the generation
		/// of degenerate tetrahedra.
		/// </summary>
		// Token: 0x06016A7D RID: 92797 RVA: 0x001FDD2F File Offset: 0x001FBF2F
		public virtual void SetMergeTolerance(double _arg)
		{
			vtkClipVolume.vtkClipVolume_SetMergeTolerance_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06016A7E RID: 92798
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_SetMixed3DCellGeneration_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether the filter produces a mix of 3D cell types on output, or
		/// whether the output cells are all tetrahedra. By default, a mixed set of
		/// cells (e.g., tetrahedra and wedges) is produced. (Note: mixed type
		/// generation is faster and less overall data is generated.)
		/// </summary>
		// Token: 0x06016A7F RID: 92799 RVA: 0x001FDD3F File Offset: 0x001FBF3F
		public virtual void SetMixed3DCellGeneration(int _arg)
		{
			vtkClipVolume.vtkClipVolume_SetMixed3DCellGeneration_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06016A80 RID: 92800
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipVolume_SetValue_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the clipping value of the implicit function (if clipping with
		/// implicit function) or scalar value (if clipping with scalars). The
		/// default value is 0.0.
		/// </summary>
		// Token: 0x06016A81 RID: 92801 RVA: 0x001FDD4F File Offset: 0x001FBF4F
		public virtual void SetValue(double _arg)
		{
			vtkClipVolume.vtkClipVolume_SetValue_36(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001969 RID: 6505
		public new const string MRFullTypeName = "Kitware.VTK.vtkClipVolume";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400196A RID: 6506
		public new static readonly string MRClassNameKey = "class vtkClipVolume";
	}
}
