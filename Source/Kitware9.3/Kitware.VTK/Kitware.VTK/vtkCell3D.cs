using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCell3D
	/// </summary>
	/// <remarks>
	///    abstract class to specify 3D cell interface
	///
	/// vtkCell3D is an abstract class that extends the interfaces for 3D data
	/// cells, and implements methods needed to satisfy the vtkCell API. The
	/// 3D cells include hexehedra, tetrahedra, wedge, pyramid, and voxel.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTetra vtkHexahedron vtkVoxel vtkWedge vtkPyramid
	/// </seealso>
	// Token: 0x02000A12 RID: 2578
	public abstract class vtkCell3D : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AD3F RID: 109887 RVA: 0x002560D7 File Offset: 0x002542D7
		static vtkCell3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCell3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCell3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AD40 RID: 109888 RVA: 0x002560FF File Offset: 0x002542FF
		public vtkCell3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AD41 RID: 109889 RVA: 0x0025610D File Offset: 0x0025430D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AD42 RID: 109890
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell3D_Clip_01(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Cut (or clip) the cell based on the input cellScalars and the specified
		/// value. The output of the clip operation will be one or more cells of the
		/// same topological dimension as the original cell.  The flag insideOut
		/// controls what part of the cell is considered inside - normally cell
		/// points whose scalar value is greater than "value" are considered
		/// inside. If insideOut is on, this is reversed. Also, if the output cell
		/// data is non-nullptr, the cell data from the clipped cell is passed to the
		/// generated contouring primitives. (Note: the CopyAllocate() method must
		/// be invoked on both the output cell and point data. The cellId refers to
		/// the cell from which the cell data is copied.)  (Satisfies vtkCell API.)
		/// </summary>
		// Token: 0x0601AD43 RID: 109891 RVA: 0x00256118 File Offset: 0x00254318
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkCell3D.vtkCell3D_Clip_01(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601AD44 RID: 109892
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell3D_Contour_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Computes the centroid of the cell.
		/// </summary>
		// Token: 0x0601AD45 RID: 109893 RVA: 0x002561D4 File Offset: 0x002543D4
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkCell3D.vtkCell3D_Contour_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601AD46 RID: 109894
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell3D_GetCellDimension_03(HandleRef pThis);

		/// <summary>
		/// The topological dimension of the cell. (Satisfies vtkCell API.)
		/// </summary>
		// Token: 0x0601AD47 RID: 109895 RVA: 0x002562BC File Offset: 0x002544BC
		public override int GetCellDimension()
		{
			return vtkCell3D.vtkCell3D_GetCellDimension_03(base.GetCppThis());
		}

		// Token: 0x0601AD48 RID: 109896
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCell3D_GetCentroid_04(HandleRef pThis, IntPtr centroid);

		/// <summary>
		/// Computes the centroid of the cell.
		/// </summary>
		// Token: 0x0601AD49 RID: 109897 RVA: 0x002562DC File Offset: 0x002544DC
		public virtual bool GetCentroid(IntPtr centroid)
		{
			return vtkCell3D.vtkCell3D_GetCentroid_04(base.GetCppThis(), centroid) != 0;
		}

		// Token: 0x0601AD4A RID: 109898
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCell3D_GetMergeTolerance_05(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the vertices of cells. This tolerance is used to prevent the generation
		/// of degenerate tetrahedra during clipping.
		/// </summary>
		// Token: 0x0601AD4B RID: 109899 RVA: 0x00256304 File Offset: 0x00254504
		public virtual double GetMergeTolerance()
		{
			return vtkCell3D.vtkCell3D_GetMergeTolerance_05(base.GetCppThis());
		}

		// Token: 0x0601AD4C RID: 109900
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCell3D_GetMergeToleranceMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the vertices of cells. This tolerance is used to prevent the generation
		/// of degenerate tetrahedra during clipping.
		/// </summary>
		// Token: 0x0601AD4D RID: 109901 RVA: 0x00256324 File Offset: 0x00254524
		public virtual double GetMergeToleranceMaxValue()
		{
			return vtkCell3D.vtkCell3D_GetMergeToleranceMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0601AD4E RID: 109902
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCell3D_GetMergeToleranceMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the vertices of cells. This tolerance is used to prevent the generation
		/// of degenerate tetrahedra during clipping.
		/// </summary>
		// Token: 0x0601AD4F RID: 109903 RVA: 0x00256344 File Offset: 0x00254544
		public virtual double GetMergeToleranceMinValue()
		{
			return vtkCell3D.vtkCell3D_GetMergeToleranceMinValue_07(base.GetCppThis());
		}

		// Token: 0x0601AD50 RID: 109904
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCell3D_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AD51 RID: 109905 RVA: 0x00256364 File Offset: 0x00254564
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCell3D.vtkCell3D_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601AD52 RID: 109906
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCell3D_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AD53 RID: 109907 RVA: 0x00256384 File Offset: 0x00254584
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCell3D.vtkCell3D_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601AD54 RID: 109908
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell3D_Inflate_10(HandleRef pThis, double dist);

		/// <summary>
		/// Inflates the cell. Each face is displaced following its normal by a
		/// distance of value `dist`. If dist is negative, then the cell shrinks.
		/// The resulting cell edges / faces are colinear / coplanar to their previous
		/// self.
		///
		/// Degenerate parts of the 3D cell are unchanged. This happens a points to
		/// which incident faces are homogeneous to a plane, to a line, or to a point.
		///
		/// \return 1 if inflation was successful, 0 if no inflation was performed
		/// </summary>
		// Token: 0x0601AD55 RID: 109909 RVA: 0x002563A0 File Offset: 0x002545A0
		public override int Inflate(double dist)
		{
			return vtkCell3D.vtkCell3D_Inflate_10(base.GetCppThis(), dist);
		}

		// Token: 0x0601AD56 RID: 109910
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell3D_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AD57 RID: 109911 RVA: 0x002563C0 File Offset: 0x002545C0
		public override int IsA(string type)
		{
			return vtkCell3D.vtkCell3D_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601AD58 RID: 109912
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCell3D_IsInsideOut_12(HandleRef pThis);

		/// <summary>
		/// Returns true if the normals of the vtkCell3D point inside the cell.
		///
		/// @warning This flag is not precomputed. It is advised for the return result of
		/// this method to be stored in a local boolean by the user if needed multiple times.
		/// </summary>
		// Token: 0x0601AD59 RID: 109913 RVA: 0x002563E0 File Offset: 0x002545E0
		public virtual bool IsInsideOut()
		{
			return vtkCell3D.vtkCell3D_IsInsideOut_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0601AD5A RID: 109914
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell3D_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AD5B RID: 109915 RVA: 0x00256408 File Offset: 0x00254608
		public new static int IsTypeOf(string type)
		{
			return vtkCell3D.vtkCell3D_IsTypeOf_13(type);
		}

		// Token: 0x0601AD5C RID: 109916
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCell3D_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AD5D RID: 109917 RVA: 0x00256424 File Offset: 0x00254624
		public new vtkCell3D NewInstance()
		{
			vtkCell3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCell3D.vtkCell3D_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCell3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AD5E RID: 109918
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCell3D_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AD5F RID: 109919 RVA: 0x00256480 File Offset: 0x00254680
		public new static vtkCell3D SafeDownCast(vtkObjectBase o)
		{
			vtkCell3D vtkCell3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCell3D.vtkCell3D_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell3D = (vtkCell3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell3D.Register(null);
				}
			}
			return vtkCell3D;
		}

		// Token: 0x0601AD60 RID: 109920
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell3D_SetMergeTolerance_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the vertices of cells. This tolerance is used to prevent the generation
		/// of degenerate tetrahedra during clipping.
		/// </summary>
		// Token: 0x0601AD61 RID: 109921 RVA: 0x002564FF File Offset: 0x002546FF
		public virtual void SetMergeTolerance(double _arg)
		{
			vtkCell3D.vtkCell3D_SetMergeTolerance_16(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CFC RID: 7420
		public new const string MRFullTypeName = "Kitware.VTK.vtkCell3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CFD RID: 7421
		public new static readonly string MRClassNameKey = "class vtkCell3D";
	}
}
