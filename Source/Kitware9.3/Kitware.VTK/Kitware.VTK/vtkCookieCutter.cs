﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCookieCutter
	/// </summary>
	/// <remarks>
	///    cut vtkPolyData defined on the 2D plane with one or more polygons
	///
	/// This filter crops an input vtkPolyData consisting of cells (i.e., points,
	/// lines, polygons, and triangle strips) with trim loops specified by a second
	/// input containing polygons and/or polylines. The input vtkPolyData and the
	/// loops must lie on the same plane. Note that this filter can handle concave
	/// polygons and/or loops. It may produce multiple output polygons for each
	/// polygon/loop interaction. Similarly, it may produce multiple line segments
	/// and so on. (The input to cookie cut (input0) is referred to as the input
	/// mesh, while the loops used to cut the input mesh (input1) are referred to
	/// as the trim loops.)
	///
	/// The filter has the option to pass through and generate point and cell
	/// data.  If PassCellData is enabled, then the cell data associated with the
	/// cropped cells, or cells passed through from the input mesh, are passed
	/// through to the output. If PassPointData is enabled, then in similar
	/// fashion the point data is passed through; however new points generated by
	/// intersection may have point data interpolated in one of two ways. First,
	/// the input mesh edges are interpolated at the new intersection points to
	/// generate point data, or the trim loop edges are interpolated at the new
	/// intersection points to generate point data. Note: for PassPointData and
	/// point interpolation to function, the filter requires that the point data
	/// attributes (from the mesh and trim loop) are exactly the same. If they are
	/// not, then a set intersection operation is performed which uses the point
	/// data arrays common to both the mesh and trim loops.
	///
	/// @warning
	/// The mesh and trim loops must lie on the same plane and the plane may be
	/// arbitrarily oriented. If not on the same plane, tolerancing issues can
	/// produce erratic results.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImprintFilter
	/// </seealso>
	// Token: 0x0200054E RID: 1358
	public class vtkCookieCutter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F1D5 RID: 61909 RVA: 0x00150DDA File Offset: 0x0014EFDA
		static vtkCookieCutter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCookieCutter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCookieCutter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F1D6 RID: 61910 RVA: 0x00150E02 File Offset: 0x0014F002
		public vtkCookieCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F1D7 RID: 61911
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCookieCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F1D8 RID: 61912 RVA: 0x00150E10 File Offset: 0x0014F010
		public new static vtkCookieCutter New()
		{
			vtkCookieCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCookieCutter.vtkCookieCutter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCookieCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F1D9 RID: 61913 RVA: 0x00150E64 File Offset: 0x0014F064
		public vtkCookieCutter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCookieCutter.vtkCookieCutter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F1DA RID: 61914 RVA: 0x00150EA8 File Offset: 0x0014F0A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F1DB RID: 61915
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified. The
		/// locator is used to merge coincident points.
		/// </summary>
		// Token: 0x0600F1DC RID: 61916 RVA: 0x00150EB3 File Offset: 0x0014F0B3
		public void CreateDefaultLocator()
		{
			vtkCookieCutter.vtkCookieCutter_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x0600F1DD RID: 61917
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCookieCutter_GetLocator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a spatial locator for merging points. By default, an
		/// instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600F1DE RID: 61918 RVA: 0x00150EC4 File Offset: 0x0014F0C4
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCookieCutter.vtkCookieCutter_GetLocator_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600F1DF RID: 61919
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCookieCutter_GetLoops_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the a second vtkPolyData input which defines trim loops used to
		/// cut the input polygonal data. These loops must be manifold, i.e., do not
		/// self intersect. The loops are defined from the polygons and polylines
		/// defined in this second input.
		/// </summary>
		// Token: 0x0600F1E0 RID: 61920 RVA: 0x00150F34 File Offset: 0x0014F134
		public vtkDataObject GetLoops()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCookieCutter.vtkCookieCutter_GetLoops_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600F1E1 RID: 61921
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCookieCutter_GetLoopsConnection_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the a second vtkPolyData input which defines trim loops used to
		/// cut the input polygonal data. These loops must be manifold, i.e., do not
		/// self intersect. The loops are defined from the polygons and polylines
		/// defined in this second input. Note that if polylines are used, they are
		/// assumed to be closed.
		/// </summary>
		// Token: 0x0600F1E2 RID: 61922 RVA: 0x00150FA4 File Offset: 0x0014F1A4
		public vtkAlgorithmOutput GetLoopsConnection()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCookieCutter.vtkCookieCutter_GetLoopsConnection_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x0600F1E3 RID: 61923
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCookieCutter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F1E4 RID: 61924 RVA: 0x00151014 File Offset: 0x0014F214
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCookieCutter.vtkCookieCutter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600F1E5 RID: 61925
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCookieCutter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F1E6 RID: 61926 RVA: 0x00151034 File Offset: 0x0014F234
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCookieCutter.vtkCookieCutter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600F1E7 RID: 61927
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCookieCutter_GetPassCellData_07(HandleRef pThis);

		/// <summary>
		/// Indicate whether cell data from the input mesh is to be passed through
		/// to the output mesh. By default, PassCellData is enabled.
		/// </summary>
		// Token: 0x0600F1E8 RID: 61928 RVA: 0x00151050 File Offset: 0x0014F250
		public virtual bool GetPassCellData()
		{
			return vtkCookieCutter.vtkCookieCutter_GetPassCellData_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F1E9 RID: 61929
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCookieCutter_GetPassPointData_08(HandleRef pThis);

		/// <summary>
		/// Indicate whether point data from the input mesh are to be passed through
		/// and/or interpolated to the output mesh. By default, PassPointData is
		/// enabled. Note: both the input mesh points and the trim
		/// loops, must have identical point data. Otherwise, a set operation will
		/// be performed to process just the point data arrays common to both the
		/// mesh point data and loops point data.
		/// </summary>
		// Token: 0x0600F1EA RID: 61930 RVA: 0x00151078 File Offset: 0x0014F278
		public virtual bool GetPassPointData()
		{
			return vtkCookieCutter.vtkCookieCutter_GetPassPointData_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F1EB RID: 61931
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCookieCutter_GetPointInterpolation_09(HandleRef pThis);

		/// <summary>
		/// If PassPointData is on, indicate how new point data is to generated at
		/// the intersection points between the input mesh edges and the trim edges
		/// (trim edges form the loops). By default, PointInterpolation is set to
		/// USE_MESH_EDGES.
		/// </summary>
		// Token: 0x0600F1EC RID: 61932 RVA: 0x001510A0 File Offset: 0x0014F2A0
		public virtual int GetPointInterpolation()
		{
			return vtkCookieCutter.vtkCookieCutter_GetPointInterpolation_09(base.GetCppThis());
		}

		// Token: 0x0600F1ED RID: 61933
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCookieCutter_GetPointInterpolationMaxValue_10(HandleRef pThis);

		/// <summary>
		/// If PassPointData is on, indicate how new point data is to generated at
		/// the intersection points between the input mesh edges and the trim edges
		/// (trim edges form the loops). By default, PointInterpolation is set to
		/// USE_MESH_EDGES.
		/// </summary>
		// Token: 0x0600F1EE RID: 61934 RVA: 0x001510C0 File Offset: 0x0014F2C0
		public virtual int GetPointInterpolationMaxValue()
		{
			return vtkCookieCutter.vtkCookieCutter_GetPointInterpolationMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600F1EF RID: 61935
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCookieCutter_GetPointInterpolationMinValue_11(HandleRef pThis);

		/// <summary>
		/// If PassPointData is on, indicate how new point data is to generated at
		/// the intersection points between the input mesh edges and the trim edges
		/// (trim edges form the loops). By default, PointInterpolation is set to
		/// USE_MESH_EDGES.
		/// </summary>
		// Token: 0x0600F1F0 RID: 61936 RVA: 0x001510E0 File Offset: 0x0014F2E0
		public virtual int GetPointInterpolationMinValue()
		{
			return vtkCookieCutter.vtkCookieCutter_GetPointInterpolationMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600F1F1 RID: 61937
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCookieCutter_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F1F2 RID: 61938 RVA: 0x00151100 File Offset: 0x0014F300
		public override int IsA(string type)
		{
			return vtkCookieCutter.vtkCookieCutter_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600F1F3 RID: 61939
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCookieCutter_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F1F4 RID: 61940 RVA: 0x00151120 File Offset: 0x0014F320
		public new static int IsTypeOf(string type)
		{
			return vtkCookieCutter.vtkCookieCutter_IsTypeOf_13(type);
		}

		// Token: 0x0600F1F5 RID: 61941
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCookieCutter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F1F6 RID: 61942 RVA: 0x0015113C File Offset: 0x0014F33C
		public new vtkCookieCutter NewInstance()
		{
			vtkCookieCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCookieCutter.vtkCookieCutter_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCookieCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F1F7 RID: 61943
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_PassCellDataOff_16(HandleRef pThis);

		/// <summary>
		/// Indicate whether cell data from the input mesh is to be passed through
		/// to the output mesh. By default, PassCellData is enabled.
		/// </summary>
		// Token: 0x0600F1F8 RID: 61944 RVA: 0x00151196 File Offset: 0x0014F396
		public virtual void PassCellDataOff()
		{
			vtkCookieCutter.vtkCookieCutter_PassCellDataOff_16(base.GetCppThis());
		}

		// Token: 0x0600F1F9 RID: 61945
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_PassCellDataOn_17(HandleRef pThis);

		/// <summary>
		/// Indicate whether cell data from the input mesh is to be passed through
		/// to the output mesh. By default, PassCellData is enabled.
		/// </summary>
		// Token: 0x0600F1FA RID: 61946 RVA: 0x001511A5 File Offset: 0x0014F3A5
		public virtual void PassCellDataOn()
		{
			vtkCookieCutter.vtkCookieCutter_PassCellDataOn_17(base.GetCppThis());
		}

		// Token: 0x0600F1FB RID: 61947
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_PassPointDataOff_18(HandleRef pThis);

		/// <summary>
		/// Indicate whether point data from the input mesh are to be passed through
		/// and/or interpolated to the output mesh. By default, PassPointData is
		/// enabled. Note: both the input mesh points and the trim
		/// loops, must have identical point data. Otherwise, a set operation will
		/// be performed to process just the point data arrays common to both the
		/// mesh point data and loops point data.
		/// </summary>
		// Token: 0x0600F1FC RID: 61948 RVA: 0x001511B4 File Offset: 0x0014F3B4
		public virtual void PassPointDataOff()
		{
			vtkCookieCutter.vtkCookieCutter_PassPointDataOff_18(base.GetCppThis());
		}

		// Token: 0x0600F1FD RID: 61949
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_PassPointDataOn_19(HandleRef pThis);

		/// <summary>
		/// Indicate whether point data from the input mesh are to be passed through
		/// and/or interpolated to the output mesh. By default, PassPointData is
		/// enabled. Note: both the input mesh points and the trim
		/// loops, must have identical point data. Otherwise, a set operation will
		/// be performed to process just the point data arrays common to both the
		/// mesh point data and loops point data.
		/// </summary>
		// Token: 0x0600F1FE RID: 61950 RVA: 0x001511C3 File Offset: 0x0014F3C3
		public virtual void PassPointDataOn()
		{
			vtkCookieCutter.vtkCookieCutter_PassPointDataOn_19(base.GetCppThis());
		}

		// Token: 0x0600F1FF RID: 61951
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCookieCutter_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print and provide type information.
		/// </summary>
		// Token: 0x0600F200 RID: 61952 RVA: 0x001511D4 File Offset: 0x0014F3D4
		public new static vtkCookieCutter SafeDownCast(vtkObjectBase o)
		{
			vtkCookieCutter vtkCookieCutter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCookieCutter.vtkCookieCutter_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCookieCutter = (vtkCookieCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCookieCutter.Register(null);
				}
			}
			return vtkCookieCutter;
		}

		// Token: 0x0600F201 RID: 61953
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_SetLocator_21(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a spatial locator for merging points. By default, an
		/// instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600F202 RID: 61954 RVA: 0x00151254 File Offset: 0x0014F454
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkCookieCutter.vtkCookieCutter_SetLocator_21(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600F203 RID: 61955
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_SetLoopsConnection_22(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the a second vtkPolyData input which defines trim loops used to
		/// cut the input polygonal data. These loops must be manifold, i.e., do not
		/// self intersect. The loops are defined from the polygons and polylines
		/// defined in this second input. Note that if polylines are used, they are
		/// assumed to be closed.
		/// </summary>
		// Token: 0x0600F204 RID: 61956 RVA: 0x00151284 File Offset: 0x0014F484
		public void SetLoopsConnection(vtkAlgorithmOutput algOutput)
		{
			vtkCookieCutter.vtkCookieCutter_SetLoopsConnection_22(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600F205 RID: 61957
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_SetLoopsData_23(HandleRef pThis, HandleRef loops);

		/// <summary>
		/// Specify the a second vtkPolyData input which defines trim loops used to
		/// cut the input polygonal data. These loops must be manifold, i.e., do not
		/// self intersect. The loops are defined from the polygons and polylines
		/// defined in this second input.
		/// </summary>
		// Token: 0x0600F206 RID: 61958 RVA: 0x001512B4 File Offset: 0x0014F4B4
		public void SetLoopsData(vtkDataObject loops)
		{
			vtkCookieCutter.vtkCookieCutter_SetLoopsData_23(base.GetCppThis(), (loops == null) ? default(HandleRef) : loops.GetCppThis());
		}

		// Token: 0x0600F207 RID: 61959
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_SetPassCellData_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether cell data from the input mesh is to be passed through
		/// to the output mesh. By default, PassCellData is enabled.
		/// </summary>
		// Token: 0x0600F208 RID: 61960 RVA: 0x001512E3 File Offset: 0x0014F4E3
		public virtual void SetPassCellData(bool _arg)
		{
			vtkCookieCutter.vtkCookieCutter_SetPassCellData_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F209 RID: 61961
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_SetPassPointData_25(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether point data from the input mesh are to be passed through
		/// and/or interpolated to the output mesh. By default, PassPointData is
		/// enabled. Note: both the input mesh points and the trim
		/// loops, must have identical point data. Otherwise, a set operation will
		/// be performed to process just the point data arrays common to both the
		/// mesh point data and loops point data.
		/// </summary>
		// Token: 0x0600F20A RID: 61962 RVA: 0x001512FB File Offset: 0x0014F4FB
		public virtual void SetPassPointData(bool _arg)
		{
			vtkCookieCutter.vtkCookieCutter_SetPassPointData_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F20B RID: 61963
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_SetPointInterpolation_26(HandleRef pThis, int _arg);

		/// <summary>
		/// If PassPointData is on, indicate how new point data is to generated at
		/// the intersection points between the input mesh edges and the trim edges
		/// (trim edges form the loops). By default, PointInterpolation is set to
		/// USE_MESH_EDGES.
		/// </summary>
		// Token: 0x0600F20C RID: 61964 RVA: 0x00151313 File Offset: 0x0014F513
		public virtual void SetPointInterpolation(int _arg)
		{
			vtkCookieCutter.vtkCookieCutter_SetPointInterpolation_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F20D RID: 61965
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_SetPointInterpolationToLoopEdges_27(HandleRef pThis);

		/// <summary>
		/// If PassPointData is on, indicate how new point data is to generated at
		/// the intersection points between the input mesh edges and the trim edges
		/// (trim edges form the loops). By default, PointInterpolation is set to
		/// USE_MESH_EDGES.
		/// </summary>
		// Token: 0x0600F20E RID: 61966 RVA: 0x00151323 File Offset: 0x0014F523
		public void SetPointInterpolationToLoopEdges()
		{
			vtkCookieCutter.vtkCookieCutter_SetPointInterpolationToLoopEdges_27(base.GetCppThis());
		}

		// Token: 0x0600F20F RID: 61967
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCookieCutter_SetPointInterpolationToMeshEdges_28(HandleRef pThis);

		/// <summary>
		/// If PassPointData is on, indicate how new point data is to generated at
		/// the intersection points between the input mesh edges and the trim edges
		/// (trim edges form the loops). By default, PointInterpolation is set to
		/// USE_MESH_EDGES.
		/// </summary>
		// Token: 0x0600F210 RID: 61968 RVA: 0x00151332 File Offset: 0x0014F532
		public void SetPointInterpolationToMeshEdges()
		{
			vtkCookieCutter.vtkCookieCutter_SetPointInterpolationToMeshEdges_28(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001196 RID: 4502
		public new const string MRFullTypeName = "Kitware.VTK.vtkCookieCutter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001197 RID: 4503
		public new static readonly string MRClassNameKey = "class vtkCookieCutter";

		/// <summary>
		/// Indicate whether point data from the input mesh are to be passed through
		/// and/or interpolated to the output mesh. By default, PassPointData is
		/// enabled. Note: both the input mesh points and the trim
		/// loops, must have identical point data. Otherwise, a set operation will
		/// be performed to process just the point data arrays common to both the
		/// mesh point data and loops point data.
		/// </summary>
		// Token: 0x0200054F RID: 1359
		public enum PointInterpolationType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001199 RID: 4505
			USE_LOOP_EDGES = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400119A RID: 4506
			USE_MESH_EDGES = 0
		}
	}
}
