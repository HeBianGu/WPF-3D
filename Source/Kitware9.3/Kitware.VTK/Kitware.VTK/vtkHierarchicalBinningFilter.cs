using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHierarchicalBinningFilter
	/// </summary>
	/// <remarks>
	///    uniform binning of points into
	/// a hierarchical structure
	///
	///
	/// vtkHierarchicalBinningFilter creates a spatial, hierarchical ordering of
	/// input points. This hierarchy is suitable for level-of-detail rendering, or
	/// multiresolution processing. Each level of the hierarchy is based on
	/// uniform binning of space, where deeper levels (and its bins) are
	/// repeatedly subdivided by a given branching factor. Points are associated
	/// with bins at different levels, with the number of points in each level
	/// proportional to the number of bins in that level. The output points are
	/// sorted according to a bin number, where the bin number is unique,
	/// monotonically increasing number representing the breadth first ordering of
	/// all of the levels and their bins. Thus all points in a bin (or even a level)
	/// are segmented into contiguous runs.
	///
	/// Note that points are associated with different bins using a pseudo random
	/// process. No points are repeated, and no new points are created, thus the
	/// effect of executing this filter is simply to reorder the input points.
	///
	/// The algorithm proceeds as follows: Given an initial bounding box, the
	/// space is uniformally subdivided into bins of (M x N x O) dimensions; in
	/// turn each subsequent level in the tree is further divided into (M x N x O)
	/// bins (note that level 0 is a single, root bin). Thus the number of bins at
	/// level L of the hierarchical tree is: Nbins=(M^L x N^L x O^L). Once the
	/// binning is created to a specified depth, then points are placed in the
	/// bins using a pseudo-random sampling proportional to the number of bins in each
	/// level. All input points are sorted in the order described above, with no
	/// points repeated.
	///
	/// The output of this filter are sorted points and associated point
	/// attributes represented by a vtkPolyData. In addition, an offset integral
	/// array is associated with the field data of the output, providing offsets
	/// into the points list via a breadth-first traversal order. Metadata
	/// describing the output is provided in the field data. Convenience functions
	/// are also provided here to access the data in a particular bin or across a
	/// level. (Using the offset array directly may result in higher performance.)
	///
	/// While any vtkPointSet type can be provided as input, the output is
	/// represented by an explicit representation of points via a
	/// vtkPolyData. This output polydata will populate its instance of vtkPoints,
	/// but no cells will be defined (i.e., no vtkVertex or vtkPolyVertex are
	/// contained in the output).
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointCloudFilter vtkQuadricClustering vtkStaticPointLocator
	/// </seealso>
	// Token: 0x02000446 RID: 1094
	public class vtkHierarchicalBinningFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CC1D RID: 52253 RVA: 0x0011C02B File Offset: 0x0011A22B
		static vtkHierarchicalBinningFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalBinningFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalBinningFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CC1E RID: 52254 RVA: 0x0011C053 File Offset: 0x0011A253
		public vtkHierarchicalBinningFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CC1F RID: 52255
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBinningFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC20 RID: 52256 RVA: 0x0011C064 File Offset: 0x0011A264
		public new static vtkHierarchicalBinningFilter New()
		{
			vtkHierarchicalBinningFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBinningFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC21 RID: 52257 RVA: 0x0011C0B8 File Offset: 0x0011A2B8
		public vtkHierarchicalBinningFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CC22 RID: 52258 RVA: 0x0011C0FC File Offset: 0x0011A2FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CC23 RID: 52259
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBinningFilter_AutomaticOff_01(HandleRef pThis);

		/// <summary>
		/// Specify whether to determine the determine the level divisions, and the bounding
		/// box automatically (by default this is on). If off, then the user must specify both
		/// the bounding box and bin divisions. (Computing the bounding box can be slow for
		/// large point clouds, manual specification can save time.)
		/// </summary>
		// Token: 0x0600CC24 RID: 52260 RVA: 0x0011C107 File Offset: 0x0011A307
		public virtual void AutomaticOff()
		{
			vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_AutomaticOff_01(base.GetCppThis());
		}

		// Token: 0x0600CC25 RID: 52261
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBinningFilter_AutomaticOn_02(HandleRef pThis);

		/// <summary>
		/// Specify whether to determine the determine the level divisions, and the bounding
		/// box automatically (by default this is on). If off, then the user must specify both
		/// the bounding box and bin divisions. (Computing the bounding box can be slow for
		/// large point clouds, manual specification can save time.)
		/// </summary>
		// Token: 0x0600CC26 RID: 52262 RVA: 0x0011C116 File Offset: 0x0011A316
		public virtual void AutomaticOn()
		{
			vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_AutomaticOn_02(base.GetCppThis());
		}

		// Token: 0x0600CC27 RID: 52263
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHierarchicalBinningFilter_GetAutomatic_03(HandleRef pThis);

		/// <summary>
		/// Specify whether to determine the determine the level divisions, and the bounding
		/// box automatically (by default this is on). If off, then the user must specify both
		/// the bounding box and bin divisions. (Computing the bounding box can be slow for
		/// large point clouds, manual specification can save time.)
		/// </summary>
		// Token: 0x0600CC28 RID: 52264 RVA: 0x0011C128 File Offset: 0x0011A328
		public virtual bool GetAutomatic()
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetAutomatic_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CC29 RID: 52265
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBinningFilter_GetBinBounds_04(HandleRef pThis, int globalBin, IntPtr bounds);

		/// <summary>
		/// Convenience methods for extracting useful information about a bin tree.
		/// Given a global bin number, return the bounds (xmin,xmax,ymin,ymax,zmin,zmax)
		/// for that bin. Invoke this method after the bin tree has been built.
		/// </summary>
		// Token: 0x0600CC2A RID: 52266 RVA: 0x0011C14E File Offset: 0x0011A34E
		public void GetBinBounds(int globalBin, IntPtr bounds)
		{
			vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetBinBounds_04(base.GetCppThis(), globalBin, bounds);
		}

		// Token: 0x0600CC2B RID: 52267
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalBinningFilter_GetBinOffset_05(HandleRef pThis, int globalBin, ref long npts);

		/// <summary>
		/// Convenience methods for extracting useful information about this bin
		/// tree.  Given a global bin number, return the point id and number of
		/// points for that bin. Invoke this method after the bin tree has been
		/// built.
		/// </summary>
		// Token: 0x0600CC2C RID: 52268 RVA: 0x0011C160 File Offset: 0x0011A360
		public long GetBinOffset(int globalBin, ref long npts)
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetBinOffset_05(base.GetCppThis(), globalBin, ref npts);
		}

		// Token: 0x0600CC2D RID: 52269
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBinningFilter_GetBounds_06(HandleRef pThis);

		/// <summary>
		/// Set the bounding box of the point cloud. If Automatic is enabled, then
		/// this is computed during filter execution. If manually specified
		/// (Automatic is off) then make sure the bounds is represented as
		/// (xmin,xmax, ymin,ymax, zmin,zmax). If the bounds specified is does not
		/// enclose the points, then points are clamped to lie in the bounding box.
		/// </summary>
		// Token: 0x0600CC2E RID: 52270 RVA: 0x0011C184 File Offset: 0x0011A384
		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600CC2F RID: 52271
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBinningFilter_GetBounds_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the bounding box of the point cloud. If Automatic is enabled, then
		/// this is computed during filter execution. If manually specified
		/// (Automatic is off) then make sure the bounds is represented as
		/// (xmin,xmax, ymin,ymax, zmin,zmax). If the bounds specified is does not
		/// enclose the points, then points are clamped to lie in the bounding box.
		/// </summary>
		// Token: 0x0600CC30 RID: 52272 RVA: 0x0011C1CC File Offset: 0x0011A3CC
		public virtual void GetBounds(IntPtr data)
		{
			vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetBounds_07(base.GetCppThis(), data);
		}

		// Token: 0x0600CC31 RID: 52273
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBinningFilter_GetDivisions_08(HandleRef pThis);

		/// <summary>
		/// Set the number of branching divisions in each binning direction. Each
		/// level of the tree is subdivided by this factor. The Divisions[i] must be
		/// &gt;= 1. Note: if Automatic subdivision is specified, the Divisions are
		/// set by the filter.
		/// </summary>
		// Token: 0x0600CC32 RID: 52274 RVA: 0x0011C1DC File Offset: 0x0011A3DC
		public virtual int[] GetDivisions()
		{
			IntPtr intPtr = vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetDivisions_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600CC33 RID: 52275
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBinningFilter_GetDivisions_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the number of branching divisions in each binning direction. Each
		/// level of the tree is subdivided by this factor. The Divisions[i] must be
		/// &gt;= 1. Note: if Automatic subdivision is specified, the Divisions are
		/// set by the filter.
		/// </summary>
		// Token: 0x0600CC34 RID: 52276 RVA: 0x0011C224 File Offset: 0x0011A424
		public virtual void GetDivisions(IntPtr data)
		{
			vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetDivisions_09(base.GetCppThis(), data);
		}

		// Token: 0x0600CC35 RID: 52277
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalBinningFilter_GetLevelOffset_10(HandleRef pThis, int level, ref long npts);

		/// <summary>
		/// Convenience methods for extracting useful information about this bin
		/// tree.  Given a level, return the beginning point id and number of points
		/// that level. Invoke this method after the bin tree has been built.
		/// </summary>
		// Token: 0x0600CC36 RID: 52278 RVA: 0x0011C234 File Offset: 0x0011A434
		public long GetLevelOffset(int level, ref long npts)
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetLevelOffset_10(base.GetCppThis(), level, ref npts);
		}

		// Token: 0x0600CC37 RID: 52279
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBinningFilter_GetLocalBinBounds_11(HandleRef pThis, int level, int localBin, IntPtr bounds);

		/// <summary>
		/// Convenience methods for extracting useful information about a bin tree.
		/// Given a level, and a local bin number, return the bounds
		/// (xmin,xmax,ymin,ymax,zmin,zmax) for that bin. Invoke this method after
		/// the bin tree has been built.
		/// </summary>
		// Token: 0x0600CC38 RID: 52280 RVA: 0x0011C255 File Offset: 0x0011A455
		public void GetLocalBinBounds(int level, int localBin, IntPtr bounds)
		{
			vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetLocalBinBounds_11(base.GetCppThis(), level, localBin, bounds);
		}

		// Token: 0x0600CC39 RID: 52281
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalBinningFilter_GetLocalBinOffset_12(HandleRef pThis, int level, int localBin, ref long npts);

		/// <summary>
		/// Convenience methods for extracting useful information about this bin
		/// tree.  Given a level, and the bin number in that level, return the
		/// offset point id and number of points for that bin. Invoke this method
		/// after the bin tree has been built.
		/// </summary>
		// Token: 0x0600CC3A RID: 52282 RVA: 0x0011C268 File Offset: 0x0011A468
		public long GetLocalBinOffset(int level, int localBin, ref long npts)
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetLocalBinOffset_12(base.GetCppThis(), level, localBin, ref npts);
		}

		// Token: 0x0600CC3B RID: 52283
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBinningFilter_GetNumberOfBins_13(HandleRef pThis, int level);

		/// <summary>
		/// Convenience methods for extracting useful information about this bin
		/// tree.  Return the number of bins in a particular level of the
		/// tree. Invoke this method after the bin tree has been built.
		/// </summary>
		// Token: 0x0600CC3C RID: 52284 RVA: 0x0011C28C File Offset: 0x0011A48C
		public int GetNumberOfBins(int level)
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetNumberOfBins_13(base.GetCppThis(), level);
		}

		// Token: 0x0600CC3D RID: 52285
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalBinningFilter_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC3E RID: 52286 RVA: 0x0011C2AC File Offset: 0x0011A4AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0600CC3F RID: 52287
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalBinningFilter_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC40 RID: 52288 RVA: 0x0011C2CC File Offset: 0x0011A4CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0600CC41 RID: 52289
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBinningFilter_GetNumberOfGlobalBins_16(HandleRef pThis);

		/// <summary>
		/// Convenience methods for extracting useful information about this bin
		/// tree.  Return the number of total bins across all levels (i.e., the
		/// total global bins). Invoke this method after the bin tree has been
		/// built.
		/// </summary>
		// Token: 0x0600CC42 RID: 52290 RVA: 0x0011C2E8 File Offset: 0x0011A4E8
		public int GetNumberOfGlobalBins()
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetNumberOfGlobalBins_16(base.GetCppThis());
		}

		// Token: 0x0600CC43 RID: 52291
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBinningFilter_GetNumberOfLevels_17(HandleRef pThis);

		/// <summary>
		/// Specify the number of levels in the spatial hierarchy. By default, the
		/// number of levels is three.
		/// </summary>
		// Token: 0x0600CC44 RID: 52292 RVA: 0x0011C308 File Offset: 0x0011A508
		public virtual int GetNumberOfLevels()
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetNumberOfLevels_17(base.GetCppThis());
		}

		// Token: 0x0600CC45 RID: 52293
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBinningFilter_GetNumberOfLevelsMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Specify the number of levels in the spatial hierarchy. By default, the
		/// number of levels is three.
		/// </summary>
		// Token: 0x0600CC46 RID: 52294 RVA: 0x0011C328 File Offset: 0x0011A528
		public virtual int GetNumberOfLevelsMaxValue()
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetNumberOfLevelsMaxValue_18(base.GetCppThis());
		}

		// Token: 0x0600CC47 RID: 52295
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBinningFilter_GetNumberOfLevelsMinValue_19(HandleRef pThis);

		/// <summary>
		/// Specify the number of levels in the spatial hierarchy. By default, the
		/// number of levels is three.
		/// </summary>
		// Token: 0x0600CC48 RID: 52296 RVA: 0x0011C348 File Offset: 0x0011A548
		public virtual int GetNumberOfLevelsMinValue()
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_GetNumberOfLevelsMinValue_19(base.GetCppThis());
		}

		// Token: 0x0600CC49 RID: 52297
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBinningFilter_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC4A RID: 52298 RVA: 0x0011C368 File Offset: 0x0011A568
		public override int IsA(string type)
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x0600CC4B RID: 52299
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBinningFilter_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC4C RID: 52300 RVA: 0x0011C388 File Offset: 0x0011A588
		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_IsTypeOf_21(type);
		}

		// Token: 0x0600CC4D RID: 52301
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBinningFilter_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC4E RID: 52302 RVA: 0x0011C3A4 File Offset: 0x0011A5A4
		public new vtkHierarchicalBinningFilter NewInstance()
		{
			vtkHierarchicalBinningFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBinningFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CC4F RID: 52303
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBinningFilter_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC50 RID: 52304 RVA: 0x0011C400 File Offset: 0x0011A600
		public new static vtkHierarchicalBinningFilter SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalBinningFilter vtkHierarchicalBinningFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBinningFilter = (vtkHierarchicalBinningFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBinningFilter.Register(null);
				}
			}
			return vtkHierarchicalBinningFilter;
		}

		// Token: 0x0600CC51 RID: 52305
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBinningFilter_SetAutomatic_25(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether to determine the determine the level divisions, and the bounding
		/// box automatically (by default this is on). If off, then the user must specify both
		/// the bounding box and bin divisions. (Computing the bounding box can be slow for
		/// large point clouds, manual specification can save time.)
		/// </summary>
		// Token: 0x0600CC52 RID: 52306 RVA: 0x0011C47F File Offset: 0x0011A67F
		public virtual void SetAutomatic(bool _arg)
		{
			vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_SetAutomatic_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CC53 RID: 52307
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBinningFilter_SetBounds_26(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set the bounding box of the point cloud. If Automatic is enabled, then
		/// this is computed during filter execution. If manually specified
		/// (Automatic is off) then make sure the bounds is represented as
		/// (xmin,xmax, ymin,ymax, zmin,zmax). If the bounds specified is does not
		/// enclose the points, then points are clamped to lie in the bounding box.
		/// </summary>
		// Token: 0x0600CC54 RID: 52308 RVA: 0x0011C497 File Offset: 0x0011A697
		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_SetBounds_26(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600CC55 RID: 52309
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBinningFilter_SetBounds_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the bounding box of the point cloud. If Automatic is enabled, then
		/// this is computed during filter execution. If manually specified
		/// (Automatic is off) then make sure the bounds is represented as
		/// (xmin,xmax, ymin,ymax, zmin,zmax). If the bounds specified is does not
		/// enclose the points, then points are clamped to lie in the bounding box.
		/// </summary>
		// Token: 0x0600CC56 RID: 52310 RVA: 0x0011C4AF File Offset: 0x0011A6AF
		public virtual void SetBounds(IntPtr _arg)
		{
			vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_SetBounds_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CC57 RID: 52311
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBinningFilter_SetDivisions_28(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set the number of branching divisions in each binning direction. Each
		/// level of the tree is subdivided by this factor. The Divisions[i] must be
		/// &gt;= 1. Note: if Automatic subdivision is specified, the Divisions are
		/// set by the filter.
		/// </summary>
		// Token: 0x0600CC58 RID: 52312 RVA: 0x0011C4BF File Offset: 0x0011A6BF
		public virtual void SetDivisions(int _arg1, int _arg2, int _arg3)
		{
			vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_SetDivisions_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600CC59 RID: 52313
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBinningFilter_SetDivisions_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the number of branching divisions in each binning direction. Each
		/// level of the tree is subdivided by this factor. The Divisions[i] must be
		/// &gt;= 1. Note: if Automatic subdivision is specified, the Divisions are
		/// set by the filter.
		/// </summary>
		// Token: 0x0600CC5A RID: 52314 RVA: 0x0011C4D1 File Offset: 0x0011A6D1
		public virtual void SetDivisions(IntPtr _arg)
		{
			vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_SetDivisions_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CC5B RID: 52315
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBinningFilter_SetNumberOfLevels_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of levels in the spatial hierarchy. By default, the
		/// number of levels is three.
		/// </summary>
		// Token: 0x0600CC5C RID: 52316 RVA: 0x0011C4E1 File Offset: 0x0011A6E1
		public virtual void SetNumberOfLevels(int _arg)
		{
			vtkHierarchicalBinningFilter.vtkHierarchicalBinningFilter_SetNumberOfLevels_30(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F19 RID: 3865
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalBinningFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F1A RID: 3866
		public new static readonly string MRClassNameKey = "class vtkHierarchicalBinningFilter";
	}
}
