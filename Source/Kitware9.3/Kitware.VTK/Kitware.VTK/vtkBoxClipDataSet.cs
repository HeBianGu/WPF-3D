using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBoxClipDataSet
	/// </summary>
	/// <remarks>
	///    clip an unstructured grid
	///
	///
	/// Clipping means that is actually 'cuts' through the cells of the dataset,
	/// returning tetrahedral cells inside of the box.
	/// The output of this filter is an unstructured grid.
	///
	/// This filter can be configured to compute a second output. The
	/// second output is the part of the cell that is clipped away. Set the
	/// GenerateClippedData boolean on if you wish to access this output data.
	///
	/// The vtkBoxClipDataSet will triangulate all types of 3D cells (i.e, create tetrahedra).
	/// This is necessary to preserve compatibility across face neighbors.
	///
	/// To use this filter,you can decide if you will be clipping with a box or a hexahedral box.
	/// 1) Set orientation
	///    if(SetOrientation(0)): box (parallel with coordinate axis)
	///       SetBoxClip(xmin,xmax,ymin,ymax,zmin,zmax)
	///    if(SetOrientation(1)): hexahedral box (Default)
	///       SetBoxClip(n[0],o[0],n[1],o[1],n[2],o[2],n[3],o[3],n[4],o[4],n[5],o[5])
	///       PlaneNormal[] normal of each plane
	///       PlanePoint[] point on the plane
	/// 2) Apply the GenerateClipScalarsOn()
	/// 3) Execute clipping  Update();
	/// </remarks>
	// Token: 0x02000879 RID: 2169
	public class vtkBoxClipDataSet : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060167E0 RID: 92128 RVA: 0x001FA0E0 File Offset: 0x001F82E0
		static vtkBoxClipDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoxClipDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxClipDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060167E1 RID: 92129 RVA: 0x001FA108 File Offset: 0x001F8308
		public vtkBoxClipDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060167E2 RID: 92130
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxClipDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Constructor of the clipping box. The initial box is (0,1,0,1,0,1).
		/// The hexahedral box and the parallel box parameters are set to match this
		/// box.
		/// </summary>
		// Token: 0x060167E3 RID: 92131 RVA: 0x001FA118 File Offset: 0x001F8318
		public new static vtkBoxClipDataSet New()
		{
			vtkBoxClipDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxClipDataSet.vtkBoxClipDataSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxClipDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Constructor of the clipping box. The initial box is (0,1,0,1,0,1).
		/// The hexahedral box and the parallel box parameters are set to match this
		/// box.
		/// </summary>
		// Token: 0x060167E4 RID: 92132 RVA: 0x001FA16C File Offset: 0x001F836C
		public vtkBoxClipDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBoxClipDataSet.vtkBoxClipDataSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060167E5 RID: 92133 RVA: 0x001FA1B0 File Offset: 0x001F83B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060167E6 RID: 92134
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_CellGrid_01(HandleRef pThis, long typeobj, long npts, IntPtr cellIds, HandleRef newCellArray);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x060167E7 RID: 92135 RVA: 0x001FA1BC File Offset: 0x001F83BC
		public void CellGrid(long typeobj, long npts, IntPtr cellIds, vtkCellArray newCellArray)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_CellGrid_01(base.GetCppThis(), typeobj, npts, cellIds, (newCellArray == null) ? default(HandleRef) : newCellArray.GetCppThis());
		}

		// Token: 0x060167E8 RID: 92136
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_ClipBox_02(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef tets, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x060167E9 RID: 92137 RVA: 0x001FA1F0 File Offset: 0x001F83F0
		public void ClipBox(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipBox_02(base.GetCppThis(), (newPoints == null) ? default(HandleRef) : newPoints.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tets == null) ? default(HandleRef) : tets.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		// Token: 0x060167EA RID: 92138
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_ClipBox0D_03(HandleRef pThis, HandleRef cell, HandleRef locator, HandleRef verts, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x060167EB RID: 92139 RVA: 0x001FA2C0 File Offset: 0x001F84C0
		public void ClipBox0D(vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipBox0D_03(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		// Token: 0x060167EC RID: 92140
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_ClipBox1D_04(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef lines, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x060167ED RID: 92141 RVA: 0x001FA378 File Offset: 0x001F8578
		public void ClipBox1D(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray lines, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipBox1D_04(base.GetCppThis(), (newPoints == null) ? default(HandleRef) : newPoints.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		// Token: 0x060167EE RID: 92142
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_ClipBox2D_05(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef tets, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x060167EF RID: 92143 RVA: 0x001FA448 File Offset: 0x001F8648
		public void ClipBox2D(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipBox2D_05(base.GetCppThis(), (newPoints == null) ? default(HandleRef) : newPoints.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tets == null) ? default(HandleRef) : tets.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		// Token: 0x060167F0 RID: 92144
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_ClipHexahedron_06(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef tets, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x060167F1 RID: 92145 RVA: 0x001FA518 File Offset: 0x001F8718
		public void ClipHexahedron(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipHexahedron_06(base.GetCppThis(), (newPoints == null) ? default(HandleRef) : newPoints.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tets == null) ? default(HandleRef) : tets.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		// Token: 0x060167F2 RID: 92146
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_ClipHexahedron0D_07(HandleRef pThis, HandleRef cell, HandleRef locator, HandleRef verts, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x060167F3 RID: 92147 RVA: 0x001FA5E8 File Offset: 0x001F87E8
		public void ClipHexahedron0D(vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipHexahedron0D_07(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		// Token: 0x060167F4 RID: 92148
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_ClipHexahedron1D_08(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef lines, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x060167F5 RID: 92149 RVA: 0x001FA6A0 File Offset: 0x001F88A0
		public void ClipHexahedron1D(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray lines, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipHexahedron1D_08(base.GetCppThis(), (newPoints == null) ? default(HandleRef) : newPoints.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		// Token: 0x060167F6 RID: 92150
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_ClipHexahedron2D_09(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef tets, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x060167F7 RID: 92151 RVA: 0x001FA770 File Offset: 0x001F8970
		public void ClipHexahedron2D(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipHexahedron2D_09(base.GetCppThis(), (newPoints == null) ? default(HandleRef) : newPoints.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tets == null) ? default(HandleRef) : tets.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		// Token: 0x060167F8 RID: 92152
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_CreateDefaultLocator_10(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified. The
		/// locator is used to merge coincident points.
		/// </summary>
		// Token: 0x060167F9 RID: 92153 RVA: 0x001FA83E File Offset: 0x001F8A3E
		public void CreateDefaultLocator()
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_CreateDefaultLocator_10(base.GetCppThis());
		}

		// Token: 0x060167FA RID: 92154
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_CreateTetra_11(HandleRef pThis, long npts, IntPtr cellIds, HandleRef newCellArray);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x060167FB RID: 92155 RVA: 0x001FA850 File Offset: 0x001F8A50
		public void CreateTetra(long npts, IntPtr cellIds, vtkCellArray newCellArray)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_CreateTetra_11(base.GetCppThis(), npts, cellIds, (newCellArray == null) ? default(HandleRef) : newCellArray.GetCppThis());
		}

		// Token: 0x060167FC RID: 92156
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_GenerateClipScalarsOff_12(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated, and not the input scalar data.
		/// </summary>
		// Token: 0x060167FD RID: 92157 RVA: 0x001FA881 File Offset: 0x001F8A81
		public virtual void GenerateClipScalarsOff()
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_GenerateClipScalarsOff_12(base.GetCppThis());
		}

		// Token: 0x060167FE RID: 92158
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_GenerateClipScalarsOn_13(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated, and not the input scalar data.
		/// </summary>
		// Token: 0x060167FF RID: 92159 RVA: 0x001FA890 File Offset: 0x001F8A90
		public virtual void GenerateClipScalarsOn()
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_GenerateClipScalarsOn_13(base.GetCppThis());
		}

		// Token: 0x06016800 RID: 92160
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_GenerateClippedOutputOff_14(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// </summary>
		// Token: 0x06016801 RID: 92161 RVA: 0x001FA89F File Offset: 0x001F8A9F
		public virtual void GenerateClippedOutputOff()
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_GenerateClippedOutputOff_14(base.GetCppThis());
		}

		// Token: 0x06016802 RID: 92162
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_GenerateClippedOutputOn_15(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// </summary>
		// Token: 0x06016803 RID: 92163 RVA: 0x001FA8AE File Offset: 0x001F8AAE
		public virtual void GenerateClippedOutputOn()
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_GenerateClippedOutputOn_15(base.GetCppThis());
		}

		// Token: 0x06016804 RID: 92164
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxClipDataSet_GetClippedOutput_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the Clipped output.
		/// </summary>
		// Token: 0x06016805 RID: 92165 RVA: 0x001FA8C0 File Offset: 0x001F8AC0
		public vtkUnstructuredGrid GetClippedOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxClipDataSet.vtkBoxClipDataSet_GetClippedOutput_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06016806 RID: 92166
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxClipDataSet_GetGenerateClipScalars_17(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated, and not the input scalar data.
		/// </summary>
		// Token: 0x06016807 RID: 92167 RVA: 0x001FA930 File Offset: 0x001F8B30
		public virtual int GetGenerateClipScalars()
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_GetGenerateClipScalars_17(base.GetCppThis());
		}

		// Token: 0x06016808 RID: 92168
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxClipDataSet_GetGenerateClippedOutput_18(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// </summary>
		// Token: 0x06016809 RID: 92169 RVA: 0x001FA950 File Offset: 0x001F8B50
		public virtual int GetGenerateClippedOutput()
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_GetGenerateClippedOutput_18(base.GetCppThis());
		}

		// Token: 0x0601680A RID: 92170
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxClipDataSet_GetLocator_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a spatial locator for merging points. By default, an
		/// instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0601680B RID: 92171 RVA: 0x001FA970 File Offset: 0x001F8B70
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxClipDataSet.vtkBoxClipDataSet_GetLocator_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601680C RID: 92172
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkBoxClipDataSet_GetMTime_20(HandleRef pThis);

		/// <summary>
		/// Return the mtime also considering the locator.
		/// </summary>
		// Token: 0x0601680D RID: 92173 RVA: 0x001FA9E0 File Offset: 0x001F8BE0
		public override ulong GetMTime()
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_GetMTime_20(base.GetCppThis());
		}

		// Token: 0x0601680E RID: 92174
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoxClipDataSet_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601680F RID: 92175 RVA: 0x001FAA00 File Offset: 0x001F8C00
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x06016810 RID: 92176
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoxClipDataSet_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016811 RID: 92177 RVA: 0x001FAA20 File Offset: 0x001F8C20
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x06016812 RID: 92178
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxClipDataSet_GetNumberOfOutputs_23(HandleRef pThis);

		/// <summary>
		/// Return the Clipped output.
		/// </summary>
		// Token: 0x06016813 RID: 92179 RVA: 0x001FAA3C File Offset: 0x001F8C3C
		public virtual int GetNumberOfOutputs()
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_GetNumberOfOutputs_23(base.GetCppThis());
		}

		// Token: 0x06016814 RID: 92180
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkBoxClipDataSet_GetOrientation_24(HandleRef pThis);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x06016815 RID: 92181 RVA: 0x001FAA5C File Offset: 0x001F8C5C
		public virtual uint GetOrientation()
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_GetOrientation_24(base.GetCppThis());
		}

		// Token: 0x06016816 RID: 92182
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_InterpolateEdge_25(HandleRef attributes, long toId, long fromId1, long fromId2, double t);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x06016817 RID: 92183 RVA: 0x001FAA7C File Offset: 0x001F8C7C
		public static void InterpolateEdge(vtkDataSetAttributes attributes, long toId, long fromId1, long fromId2, double t)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_InterpolateEdge_25((attributes == null) ? default(HandleRef) : attributes.GetCppThis(), toId, fromId1, fromId2, t);
		}

		// Token: 0x06016818 RID: 92184
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxClipDataSet_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016819 RID: 92185 RVA: 0x001FAAAC File Offset: 0x001F8CAC
		public override int IsA(string type)
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x0601681A RID: 92186
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxClipDataSet_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601681B RID: 92187 RVA: 0x001FAACC File Offset: 0x001F8CCC
		public new static int IsTypeOf(string type)
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_IsTypeOf_27(type);
		}

		// Token: 0x0601681C RID: 92188
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_MinEdgeF_28(HandleRef pThis, IntPtr id_v, IntPtr cellIds, IntPtr edgF);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x0601681D RID: 92189 RVA: 0x001FAAE6 File Offset: 0x001F8CE6
		public void MinEdgeF(IntPtr id_v, IntPtr cellIds, IntPtr edgF)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_MinEdgeF_28(base.GetCppThis(), id_v, cellIds, edgF);
		}

		// Token: 0x0601681E RID: 92190
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxClipDataSet_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601681F RID: 92191 RVA: 0x001FAAF8 File Offset: 0x001F8CF8
		public new vtkBoxClipDataSet NewInstance()
		{
			vtkBoxClipDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxClipDataSet.vtkBoxClipDataSet_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxClipDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016820 RID: 92192
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_PyramidToTetra_31(HandleRef pThis, IntPtr pyramId, IntPtr cellIds, HandleRef newCellArray);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x06016821 RID: 92193 RVA: 0x001FAB54 File Offset: 0x001F8D54
		public void PyramidToTetra(IntPtr pyramId, IntPtr cellIds, vtkCellArray newCellArray)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_PyramidToTetra_31(base.GetCppThis(), pyramId, cellIds, (newCellArray == null) ? default(HandleRef) : newCellArray.GetCppThis());
		}

		// Token: 0x06016822 RID: 92194
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxClipDataSet_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016823 RID: 92195 RVA: 0x001FAB88 File Offset: 0x001F8D88
		public new static vtkBoxClipDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkBoxClipDataSet vtkBoxClipDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxClipDataSet.vtkBoxClipDataSet_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoxClipDataSet = (vtkBoxClipDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoxClipDataSet.Register(null);
				}
			}
			return vtkBoxClipDataSet;
		}

		// Token: 0x06016824 RID: 92196
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_SetBoxClip_33(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Specify the Box with which to perform the clipping.
		/// If the box is not parallel to axis, you need to especify
		/// normal vector of each plane and a point on the plane.
		/// </summary>
		// Token: 0x06016825 RID: 92197 RVA: 0x001FAC07 File Offset: 0x001F8E07
		public void SetBoxClip(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_SetBoxClip_33(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x06016826 RID: 92198
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_SetBoxClip_34(HandleRef pThis, IntPtr n0, IntPtr o0, IntPtr n1, IntPtr o1, IntPtr n2, IntPtr o2, IntPtr n3, IntPtr o3, IntPtr n4, IntPtr o4, IntPtr n5, IntPtr o5);

		/// <summary>
		/// Specify the Box with which to perform the clipping.
		/// If the box is not parallel to axis, you need to especify
		/// normal vector of each plane and a point on the plane.
		/// </summary>
		// Token: 0x06016827 RID: 92199 RVA: 0x001FAC20 File Offset: 0x001F8E20
		public void SetBoxClip(IntPtr n0, IntPtr o0, IntPtr n1, IntPtr o1, IntPtr n2, IntPtr o2, IntPtr n3, IntPtr o3, IntPtr n4, IntPtr o4, IntPtr n5, IntPtr o5)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_SetBoxClip_34(base.GetCppThis(), n0, o0, n1, o1, n2, o2, n3, o3, n4, o4, n5, o5);
		}

		// Token: 0x06016828 RID: 92200
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_SetGenerateClipScalars_35(HandleRef pThis, int _arg);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated, and not the input scalar data.
		/// </summary>
		// Token: 0x06016829 RID: 92201 RVA: 0x001FAC4F File Offset: 0x001F8E4F
		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_SetGenerateClipScalars_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0601682A RID: 92202
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_SetGenerateClippedOutput_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// </summary>
		// Token: 0x0601682B RID: 92203 RVA: 0x001FAC5F File Offset: 0x001F8E5F
		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_SetGenerateClippedOutput_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0601682C RID: 92204
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_SetLocator_37(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a spatial locator for merging points. By default, an
		/// instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0601682D RID: 92205 RVA: 0x001FAC70 File Offset: 0x001F8E70
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_SetLocator_37(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0601682E RID: 92206
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_SetOrientation_38(HandleRef pThis, uint _arg);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x0601682F RID: 92207 RVA: 0x001FAC9F File Offset: 0x001F8E9F
		public virtual void SetOrientation(uint _arg)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_SetOrientation_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06016830 RID: 92208
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxClipDataSet_WedgeToTetra_39(HandleRef pThis, IntPtr wedgeId, IntPtr cellIds, HandleRef newCellArray);

		/// <summary>
		/// Tells if clipping happens with a box parallel with coordinate axis
		/// (0) or with an hexahedral box (1). Initial value is 1.
		/// </summary>
		// Token: 0x06016831 RID: 92209 RVA: 0x001FACB0 File Offset: 0x001F8EB0
		public void WedgeToTetra(IntPtr wedgeId, IntPtr cellIds, vtkCellArray newCellArray)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_WedgeToTetra_39(base.GetCppThis(), wedgeId, cellIds, (newCellArray == null) ? default(HandleRef) : newCellArray.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400194A RID: 6474
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoxClipDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400194B RID: 6475
		public new static readonly string MRClassNameKey = "class vtkBoxClipDataSet";
	}
}
