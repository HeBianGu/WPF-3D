using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIntersectionPolyDataFilter
	///
	///
	/// vtkIntersectionPolyDataFilter computes the intersection between two
	/// vtkPolyData objects. The first output is a set of lines that marks
	/// the intersection of the input vtkPolyData objects. This contains five
	/// different attached data arrays:
	///
	/// SurfaceID: Point data array that contains information about the origin
	/// surface of each point
	///
	/// Input0CellID: Cell data array that contains the original
	/// cell ID number on the first input mesh
	///
	/// Input1CellID: Cell data array that contains the original
	/// cell ID number on the second input mesh
	///
	/// NewCell0ID: Cell data array that contains information about which cells
	/// of the remeshed first input surface it touches (If split)
	///
	/// NewCell1ID: Cell data array that contains information about which cells
	/// on the remeshed second input surface it touches (If split)
	///
	/// The second and third outputs are the first and second input vtkPolyData,
	/// respectively. Optionally, the two output vtkPolyData can be split
	/// along the intersection lines by remeshing. Optionally, the surface
	/// can be cleaned and checked at the end of the remeshing.
	/// If the meshes are split, The output vtkPolyDatas contain three possible
	/// data arrays:
	///
	/// IntersectionPoint: This is a boolean indicating whether or not the point is
	/// on the boundary of the two input objects
	///
	/// BadTriangle: If the surface is cleaned and checked, this is a cell data array
	/// indicating whether or not the cell has edges with multiple neighbors
	/// A manifold surface will have 0 everywhere for this array!
	///
	/// FreeEdge: If the surface is cleaned and checked, this is a cell data array
	/// indicating if the cell has any free edges. A watertight surface will have
	/// 0 everywhere for this array!
	///
	/// @author Adam Updegrove updega2@gmail.com
	///
	/// @warning This filter is not designed to perform 2D boolean operations,
	/// and in fact relies on the inputs having no co-planar, overlapping cells.
	/// </summary>
	// Token: 0x020008B1 RID: 2225
	public class vtkIntersectionPolyDataFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017132 RID: 94514 RVA: 0x0020683B File Offset: 0x00204A3B
		static vtkIntersectionPolyDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIntersectionPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIntersectionPolyDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017133 RID: 94515 RVA: 0x00206863 File Offset: 0x00204A63
		public vtkIntersectionPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017134 RID: 94516
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIntersectionPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017135 RID: 94517 RVA: 0x00206874 File Offset: 0x00204A74
		public new static vtkIntersectionPolyDataFilter New()
		{
			vtkIntersectionPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIntersectionPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017136 RID: 94518 RVA: 0x002068C8 File Offset: 0x00204AC8
		public vtkIntersectionPolyDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017137 RID: 94519 RVA: 0x0020690C File Offset: 0x00204B0C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017138 RID: 94520
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_CheckInputOff_01(HandleRef pThis);

		/// <summary>
		/// If on, the normals of the input will be checked. Default: OFF
		/// </summary>
		// Token: 0x06017139 RID: 94521 RVA: 0x00206917 File Offset: 0x00204B17
		public virtual void CheckInputOff()
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_CheckInputOff_01(base.GetCppThis());
		}

		// Token: 0x0601713A RID: 94522
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_CheckInputOn_02(HandleRef pThis);

		/// <summary>
		/// If on, the normals of the input will be checked. Default: OFF
		/// </summary>
		// Token: 0x0601713B RID: 94523 RVA: 0x00206926 File Offset: 0x00204B26
		public virtual void CheckInputOn()
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_CheckInputOn_02(base.GetCppThis());
		}

		// Token: 0x0601713C RID: 94524
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_CheckMeshOff_03(HandleRef pThis);

		/// <summary>
		/// If on, the output remeshed surfaces will be checked for bad cells and
		/// free edges. Default: ON
		/// </summary>
		// Token: 0x0601713D RID: 94525 RVA: 0x00206935 File Offset: 0x00204B35
		public virtual void CheckMeshOff()
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_CheckMeshOff_03(base.GetCppThis());
		}

		// Token: 0x0601713E RID: 94526
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_CheckMeshOn_04(HandleRef pThis);

		/// <summary>
		/// If on, the output remeshed surfaces will be checked for bad cells and
		/// free edges. Default: ON
		/// </summary>
		// Token: 0x0601713F RID: 94527 RVA: 0x00206944 File Offset: 0x00204B44
		public virtual void CheckMeshOn()
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_CheckMeshOn_04(base.GetCppThis());
		}

		// Token: 0x06017140 RID: 94528
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_CleanAndCheckInput_05(HandleRef pd, double tolerance);

		/// <summary>
		/// Function to clean and check the inputs
		/// </summary>
		// Token: 0x06017141 RID: 94529 RVA: 0x00206954 File Offset: 0x00204B54
		public static void CleanAndCheckInput(vtkPolyData pd, double tolerance)
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_CleanAndCheckInput_05((pd == null) ? default(HandleRef) : pd.GetCppThis(), tolerance);
		}

		// Token: 0x06017142 RID: 94530
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_CleanAndCheckSurface_06(HandleRef pd, IntPtr stats, double tolerance);

		/// <summary>
		/// Function to clean and check the output surfaces for bad triangles and
		/// free edges
		/// </summary>
		// Token: 0x06017143 RID: 94531 RVA: 0x00206980 File Offset: 0x00204B80
		public static void CleanAndCheckSurface(vtkPolyData pd, IntPtr stats, double tolerance)
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_CleanAndCheckSurface_06((pd == null) ? default(HandleRef) : pd.GetCppThis(), stats, tolerance);
		}

		// Token: 0x06017144 RID: 94532
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_ComputeIntersectionPointArrayOff_07(HandleRef pThis);

		/// <summary>
		/// If on, the output split surfaces will contain information about which
		/// points are on the intersection of the two inputs. Default: ON
		/// </summary>
		// Token: 0x06017145 RID: 94533 RVA: 0x002069AB File Offset: 0x00204BAB
		public virtual void ComputeIntersectionPointArrayOff()
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_ComputeIntersectionPointArrayOff_07(base.GetCppThis());
		}

		// Token: 0x06017146 RID: 94534
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_ComputeIntersectionPointArrayOn_08(HandleRef pThis);

		/// <summary>
		/// If on, the output split surfaces will contain information about which
		/// points are on the intersection of the two inputs. Default: ON
		/// </summary>
		// Token: 0x06017147 RID: 94535 RVA: 0x002069BA File Offset: 0x00204BBA
		public virtual void ComputeIntersectionPointArrayOn()
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_ComputeIntersectionPointArrayOn_08(base.GetCppThis());
		}

		// Token: 0x06017148 RID: 94536
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntersectionPolyDataFilter_GetCheckInput_09(HandleRef pThis);

		/// <summary>
		/// If on, the normals of the input will be checked. Default: OFF
		/// </summary>
		// Token: 0x06017149 RID: 94537 RVA: 0x002069CC File Offset: 0x00204BCC
		public virtual int GetCheckInput()
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_GetCheckInput_09(base.GetCppThis());
		}

		// Token: 0x0601714A RID: 94538
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntersectionPolyDataFilter_GetCheckMesh_10(HandleRef pThis);

		/// <summary>
		/// If on, the output remeshed surfaces will be checked for bad cells and
		/// free edges. Default: ON
		/// </summary>
		// Token: 0x0601714B RID: 94539 RVA: 0x002069EC File Offset: 0x00204BEC
		public virtual int GetCheckMesh()
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_GetCheckMesh_10(base.GetCppThis());
		}

		// Token: 0x0601714C RID: 94540
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntersectionPolyDataFilter_GetComputeIntersectionPointArray_11(HandleRef pThis);

		/// <summary>
		/// If on, the output split surfaces will contain information about which
		/// points are on the intersection of the two inputs. Default: ON
		/// </summary>
		// Token: 0x0601714D RID: 94541 RVA: 0x00206A0C File Offset: 0x00204C0C
		public virtual int GetComputeIntersectionPointArray()
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_GetComputeIntersectionPointArray_11(base.GetCppThis());
		}

		// Token: 0x0601714E RID: 94542
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIntersectionPolyDataFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601714F RID: 94543 RVA: 0x00206A2C File Offset: 0x00204C2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06017150 RID: 94544
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIntersectionPolyDataFilter_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017151 RID: 94545 RVA: 0x00206A4C File Offset: 0x00204C4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06017152 RID: 94546
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntersectionPolyDataFilter_GetNumberOfIntersectionLines_14(HandleRef pThis);

		/// <summary>
		/// Integer describing the number of intersection points and lines
		/// </summary>
		// Token: 0x06017153 RID: 94547 RVA: 0x00206A68 File Offset: 0x00204C68
		public virtual int GetNumberOfIntersectionLines()
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_GetNumberOfIntersectionLines_14(base.GetCppThis());
		}

		// Token: 0x06017154 RID: 94548
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntersectionPolyDataFilter_GetNumberOfIntersectionPoints_15(HandleRef pThis);

		/// <summary>
		/// Integer describing the number of intersection points and lines
		/// </summary>
		// Token: 0x06017155 RID: 94549 RVA: 0x00206A88 File Offset: 0x00204C88
		public virtual int GetNumberOfIntersectionPoints()
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_GetNumberOfIntersectionPoints_15(base.GetCppThis());
		}

		// Token: 0x06017156 RID: 94550
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIntersectionPolyDataFilter_GetRelativeSubtriangleArea_16(HandleRef pThis);

		/// <summary>
		/// When discretizing polygons, the minimum ratio of the smallest acceptable
		/// triangle area w.r.t. the area of the polygon
		///
		/// </summary>
		// Token: 0x06017157 RID: 94551 RVA: 0x00206AA8 File Offset: 0x00204CA8
		public virtual double GetRelativeSubtriangleArea()
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_GetRelativeSubtriangleArea_16(base.GetCppThis());
		}

		// Token: 0x06017158 RID: 94552
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntersectionPolyDataFilter_GetSplitFirstOutput_17(HandleRef pThis);

		/// <summary>
		/// If on, the second output will be the first input mesh split by the
		/// intersection with the second input mesh. Defaults to on.
		/// </summary>
		// Token: 0x06017159 RID: 94553 RVA: 0x00206AC8 File Offset: 0x00204CC8
		public virtual int GetSplitFirstOutput()
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_GetSplitFirstOutput_17(base.GetCppThis());
		}

		// Token: 0x0601715A RID: 94554
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntersectionPolyDataFilter_GetSplitSecondOutput_18(HandleRef pThis);

		/// <summary>
		/// If on, the third output will be the second input mesh split by the
		/// intersection with the first input mesh. Defaults to on.
		/// </summary>
		// Token: 0x0601715B RID: 94555 RVA: 0x00206AE8 File Offset: 0x00204CE8
		public virtual int GetSplitSecondOutput()
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_GetSplitSecondOutput_18(base.GetCppThis());
		}

		// Token: 0x0601715C RID: 94556
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntersectionPolyDataFilter_GetStatus_19(HandleRef pThis);

		/// <summary>
		/// Check the status of the filter after update. If the status is zero,
		/// there was an error in the operation. If status is one, everything
		/// went smoothly
		/// </summary>
		// Token: 0x0601715D RID: 94557 RVA: 0x00206B08 File Offset: 0x00204D08
		public virtual int GetStatus()
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_GetStatus_19(base.GetCppThis());
		}

		// Token: 0x0601715E RID: 94558
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIntersectionPolyDataFilter_GetTolerance_20(HandleRef pThis);

		/// <summary>
		/// The tolerance for geometric tests in the filter
		/// </summary>
		// Token: 0x0601715F RID: 94559 RVA: 0x00206B28 File Offset: 0x00204D28
		public virtual double GetTolerance()
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_GetTolerance_20(base.GetCppThis());
		}

		// Token: 0x06017160 RID: 94560
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntersectionPolyDataFilter_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017161 RID: 94561 RVA: 0x00206B48 File Offset: 0x00204D48
		public override int IsA(string type)
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x06017162 RID: 94562
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntersectionPolyDataFilter_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017163 RID: 94563 RVA: 0x00206B68 File Offset: 0x00204D68
		public new static int IsTypeOf(string type)
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_IsTypeOf_22(type);
		}

		// Token: 0x06017164 RID: 94564
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIntersectionPolyDataFilter_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017165 RID: 94565 RVA: 0x00206B84 File Offset: 0x00204D84
		public new vtkIntersectionPolyDataFilter NewInstance()
		{
			vtkIntersectionPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIntersectionPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017166 RID: 94566
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIntersectionPolyDataFilter_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017167 RID: 94567 RVA: 0x00206BE0 File Offset: 0x00204DE0
		public new static vtkIntersectionPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkIntersectionPolyDataFilter vtkIntersectionPolyDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntersectionPolyDataFilter = (vtkIntersectionPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntersectionPolyDataFilter.Register(null);
				}
			}
			return vtkIntersectionPolyDataFilter;
		}

		// Token: 0x06017168 RID: 94568
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_SetCheckInput_26(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the normals of the input will be checked. Default: OFF
		/// </summary>
		// Token: 0x06017169 RID: 94569 RVA: 0x00206C5F File Offset: 0x00204E5F
		public virtual void SetCheckInput(int _arg)
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_SetCheckInput_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0601716A RID: 94570
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_SetCheckMesh_27(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the output remeshed surfaces will be checked for bad cells and
		/// free edges. Default: ON
		/// </summary>
		// Token: 0x0601716B RID: 94571 RVA: 0x00206C6F File Offset: 0x00204E6F
		public virtual void SetCheckMesh(int _arg)
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_SetCheckMesh_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0601716C RID: 94572
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_SetComputeIntersectionPointArray_28(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the output split surfaces will contain information about which
		/// points are on the intersection of the two inputs. Default: ON
		/// </summary>
		// Token: 0x0601716D RID: 94573 RVA: 0x00206C7F File Offset: 0x00204E7F
		public virtual void SetComputeIntersectionPointArray(int _arg)
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_SetComputeIntersectionPointArray_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0601716E RID: 94574
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_SetRelativeSubtriangleArea_29(HandleRef pThis, double _arg);

		/// <summary>
		/// When discretizing polygons, the minimum ratio of the smallest acceptable
		/// triangle area w.r.t. the area of the polygon
		///
		/// </summary>
		// Token: 0x0601716F RID: 94575 RVA: 0x00206C8F File Offset: 0x00204E8F
		public virtual void SetRelativeSubtriangleArea(double _arg)
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_SetRelativeSubtriangleArea_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06017170 RID: 94576
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_SetSplitFirstOutput_30(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the second output will be the first input mesh split by the
		/// intersection with the second input mesh. Defaults to on.
		/// </summary>
		// Token: 0x06017171 RID: 94577 RVA: 0x00206C9F File Offset: 0x00204E9F
		public virtual void SetSplitFirstOutput(int _arg)
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_SetSplitFirstOutput_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06017172 RID: 94578
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_SetSplitSecondOutput_31(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the third output will be the second input mesh split by the
		/// intersection with the first input mesh. Defaults to on.
		/// </summary>
		// Token: 0x06017173 RID: 94579 RVA: 0x00206CAF File Offset: 0x00204EAF
		public virtual void SetSplitSecondOutput(int _arg)
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_SetSplitSecondOutput_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06017174 RID: 94580
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_SetTolerance_32(HandleRef pThis, double _arg);

		/// <summary>
		/// The tolerance for geometric tests in the filter
		/// </summary>
		// Token: 0x06017175 RID: 94581 RVA: 0x00206CBF File Offset: 0x00204EBF
		public virtual void SetTolerance(double _arg)
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_SetTolerance_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06017176 RID: 94582
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_SplitFirstOutputOff_33(HandleRef pThis);

		/// <summary>
		/// If on, the second output will be the first input mesh split by the
		/// intersection with the second input mesh. Defaults to on.
		/// </summary>
		// Token: 0x06017177 RID: 94583 RVA: 0x00206CCF File Offset: 0x00204ECF
		public virtual void SplitFirstOutputOff()
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_SplitFirstOutputOff_33(base.GetCppThis());
		}

		// Token: 0x06017178 RID: 94584
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_SplitFirstOutputOn_34(HandleRef pThis);

		/// <summary>
		/// If on, the second output will be the first input mesh split by the
		/// intersection with the second input mesh. Defaults to on.
		/// </summary>
		// Token: 0x06017179 RID: 94585 RVA: 0x00206CDE File Offset: 0x00204EDE
		public virtual void SplitFirstOutputOn()
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_SplitFirstOutputOn_34(base.GetCppThis());
		}

		// Token: 0x0601717A RID: 94586
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_SplitSecondOutputOff_35(HandleRef pThis);

		/// <summary>
		/// If on, the third output will be the second input mesh split by the
		/// intersection with the first input mesh. Defaults to on.
		/// </summary>
		// Token: 0x0601717B RID: 94587 RVA: 0x00206CED File Offset: 0x00204EED
		public virtual void SplitSecondOutputOff()
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_SplitSecondOutputOff_35(base.GetCppThis());
		}

		// Token: 0x0601717C RID: 94588
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionPolyDataFilter_SplitSecondOutputOn_36(HandleRef pThis);

		/// <summary>
		/// If on, the third output will be the second input mesh split by the
		/// intersection with the first input mesh. Defaults to on.
		/// </summary>
		// Token: 0x0601717D RID: 94589 RVA: 0x00206CFC File Offset: 0x00204EFC
		public virtual void SplitSecondOutputOn()
		{
			vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_SplitSecondOutputOn_36(base.GetCppThis());
		}

		// Token: 0x0601717E RID: 94590
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntersectionPolyDataFilter_TriangleTriangleIntersection_37(IntPtr p1, IntPtr q1, IntPtr r1, IntPtr p2, IntPtr q2, IntPtr r2, ref int coplanar, IntPtr pt1, IntPtr pt2, IntPtr surfaceid, double tolerance);

		/// <summary>
		/// Given two triangles defined by points (p1, q1, r1) and (p2, q2,
		/// r2), returns whether the two triangles intersect. If they do,
		/// the endpoints of the line forming the intersection are returned
		/// in pt1 and pt2. The parameter coplanar is set to 1 if the
		/// triangles are coplanar and 0 otherwise. The surfaceid array
		/// is filled with the surface on which the first and second
		/// intersection points resides, respectively. A geometric tolerance
		/// can be specified in the last argument.
		/// </summary>
		// Token: 0x0601717F RID: 94591 RVA: 0x00206D0C File Offset: 0x00204F0C
		public static int TriangleTriangleIntersection(IntPtr p1, IntPtr q1, IntPtr r1, IntPtr p2, IntPtr q2, IntPtr r2, ref int coplanar, IntPtr pt1, IntPtr pt2, IntPtr surfaceid, double tolerance)
		{
			return vtkIntersectionPolyDataFilter.vtkIntersectionPolyDataFilter_TriangleTriangleIntersection_37(p1, q1, r1, p2, q2, r2, ref coplanar, pt1, pt2, surfaceid, tolerance);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019C8 RID: 6600
		public new const string MRFullTypeName = "Kitware.VTK.vtkIntersectionPolyDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019C9 RID: 6601
		public new static readonly string MRClassNameKey = "class vtkIntersectionPolyDataFilter";
	}
}
