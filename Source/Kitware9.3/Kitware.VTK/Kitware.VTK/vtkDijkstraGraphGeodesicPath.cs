using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDijkstraGraphGeodesicPath
	/// </summary>
	/// <remarks>
	///    Dijkstra algorithm to compute the graph geodesic.
	///
	/// Takes as input a polygonal mesh and performs a single source shortest
	/// path calculation. Dijkstra's algorithm is used. The implementation is
	/// similar to the one described in Introduction to Algorithms (Second Edition)
	/// by Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, and
	/// Cliff Stein, published by MIT Press and McGraw-Hill. Some minor
	/// enhancement are added though. All vertices are not pushed on the heap
	/// at start, instead a front set is maintained. The heap is implemented as
	/// a binary heap. The output of the filter is a set of lines describing
	/// the shortest path from StartVertex to EndVertex. If a path cannot be found
	/// the output will have no lines or points.
	///
	/// @warning
	/// The input polydata must have only triangle cells.
	///
	/// @par Thanks:
	/// The class was contributed by Rasmus Paulsen.
	/// www.imm.dtu.dk/~rrp/VTK . Also thanks to Alexandre Gouaillard and Shoaib
	/// Ghias for bug fixes and enhancements.
	/// </remarks>
	// Token: 0x02000552 RID: 1362
	public class vtkDijkstraGraphGeodesicPath : vtkGraphGeodesicPath
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F237 RID: 62007 RVA: 0x001516CB File Offset: 0x0014F8CB
		static vtkDijkstraGraphGeodesicPath()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDijkstraGraphGeodesicPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDijkstraGraphGeodesicPath"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F238 RID: 62008 RVA: 0x001516F3 File Offset: 0x0014F8F3
		public vtkDijkstraGraphGeodesicPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F239 RID: 62009
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDijkstraGraphGeodesicPath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class
		/// </summary>
		// Token: 0x0600F23A RID: 62010 RVA: 0x00151704 File Offset: 0x0014F904
		public new static vtkDijkstraGraphGeodesicPath New()
		{
			vtkDijkstraGraphGeodesicPath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDijkstraGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class
		/// </summary>
		// Token: 0x0600F23B RID: 62011 RVA: 0x00151758 File Offset: 0x0014F958
		public vtkDijkstraGraphGeodesicPath() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F23C RID: 62012 RVA: 0x0015179C File Offset: 0x0014F99C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F23D RID: 62013
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDijkstraGraphGeodesicPath_GetCumulativeWeights_01(HandleRef pThis, HandleRef weights);

		/// <summary>
		/// Fill the array with the cumulative weights.
		/// </summary>
		// Token: 0x0600F23E RID: 62014 RVA: 0x001517A8 File Offset: 0x0014F9A8
		public virtual void GetCumulativeWeights(vtkDoubleArray weights)
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetCumulativeWeights_01(base.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis());
		}

		// Token: 0x0600F23F RID: 62015
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDijkstraGraphGeodesicPath_GetIdList_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The vertex ids (of the input polydata) on the shortest path
		/// </summary>
		// Token: 0x0600F240 RID: 62016 RVA: 0x001517D8 File Offset: 0x0014F9D8
		public virtual vtkIdList GetIdList()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetIdList_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x0600F241 RID: 62017
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDijkstraGraphGeodesicPath_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F242 RID: 62018 RVA: 0x00151848 File Offset: 0x0014FA48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600F243 RID: 62019
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDijkstraGraphGeodesicPath_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F244 RID: 62020 RVA: 0x00151868 File Offset: 0x0014FA68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600F245 RID: 62021
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDijkstraGraphGeodesicPath_GetRepelPathFromVertices_05(HandleRef pThis);

		/// <summary>
		/// Use the input point to repel the path by assigning high costs.
		/// </summary>
		// Token: 0x0600F246 RID: 62022 RVA: 0x00151884 File Offset: 0x0014FA84
		public virtual int GetRepelPathFromVertices()
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetRepelPathFromVertices_05(base.GetCppThis());
		}

		// Token: 0x0600F247 RID: 62023
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDijkstraGraphGeodesicPath_GetRepelVertices_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify vtkPoints to use to repel the path from.
		/// </summary>
		// Token: 0x0600F248 RID: 62024 RVA: 0x001518A4 File Offset: 0x0014FAA4
		public virtual vtkPoints GetRepelVertices()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetRepelVertices_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0600F249 RID: 62025
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDijkstraGraphGeodesicPath_GetStopWhenEndReached_07(HandleRef pThis);

		/// <summary>
		/// Stop when the end vertex is reached
		/// or calculate shortest path to all vertices
		/// </summary>
		// Token: 0x0600F24A RID: 62026 RVA: 0x00151914 File Offset: 0x0014FB14
		public virtual int GetStopWhenEndReached()
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetStopWhenEndReached_07(base.GetCppThis());
		}

		// Token: 0x0600F24B RID: 62027
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDijkstraGraphGeodesicPath_GetUseScalarWeights_08(HandleRef pThis);

		/// <summary>
		/// Use scalar values in the edge weight (experimental)
		/// </summary>
		// Token: 0x0600F24C RID: 62028 RVA: 0x00151934 File Offset: 0x0014FB34
		public virtual int GetUseScalarWeights()
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetUseScalarWeights_08(base.GetCppThis());
		}

		// Token: 0x0600F24D RID: 62029
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDijkstraGraphGeodesicPath_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F24E RID: 62030 RVA: 0x00151954 File Offset: 0x0014FB54
		public override int IsA(string type)
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600F24F RID: 62031
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDijkstraGraphGeodesicPath_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F250 RID: 62032 RVA: 0x00151974 File Offset: 0x0014FB74
		public new static int IsTypeOf(string type)
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_IsTypeOf_10(type);
		}

		// Token: 0x0600F251 RID: 62033
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDijkstraGraphGeodesicPath_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F252 RID: 62034 RVA: 0x00151990 File Offset: 0x0014FB90
		public new vtkDijkstraGraphGeodesicPath NewInstance()
		{
			vtkDijkstraGraphGeodesicPath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDijkstraGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F253 RID: 62035
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDijkstraGraphGeodesicPath_RepelPathFromVerticesOff_13(HandleRef pThis);

		/// <summary>
		/// Use the input point to repel the path by assigning high costs.
		/// </summary>
		// Token: 0x0600F254 RID: 62036 RVA: 0x001519EA File Offset: 0x0014FBEA
		public virtual void RepelPathFromVerticesOff()
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_RepelPathFromVerticesOff_13(base.GetCppThis());
		}

		// Token: 0x0600F255 RID: 62037
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDijkstraGraphGeodesicPath_RepelPathFromVerticesOn_14(HandleRef pThis);

		/// <summary>
		/// Use the input point to repel the path by assigning high costs.
		/// </summary>
		// Token: 0x0600F256 RID: 62038 RVA: 0x001519F9 File Offset: 0x0014FBF9
		public virtual void RepelPathFromVerticesOn()
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_RepelPathFromVerticesOn_14(base.GetCppThis());
		}

		// Token: 0x0600F257 RID: 62039
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDijkstraGraphGeodesicPath_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F258 RID: 62040 RVA: 0x00151A08 File Offset: 0x0014FC08
		public new static vtkDijkstraGraphGeodesicPath SafeDownCast(vtkObjectBase o)
		{
			vtkDijkstraGraphGeodesicPath vtkDijkstraGraphGeodesicPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDijkstraGraphGeodesicPath = (vtkDijkstraGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDijkstraGraphGeodesicPath.Register(null);
				}
			}
			return vtkDijkstraGraphGeodesicPath;
		}

		// Token: 0x0600F259 RID: 62041
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDijkstraGraphGeodesicPath_SetRepelPathFromVertices_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Use the input point to repel the path by assigning high costs.
		/// </summary>
		// Token: 0x0600F25A RID: 62042 RVA: 0x00151A87 File Offset: 0x0014FC87
		public virtual void SetRepelPathFromVertices(int _arg)
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_SetRepelPathFromVertices_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F25B RID: 62043
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDijkstraGraphGeodesicPath_SetRepelVertices_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify vtkPoints to use to repel the path from.
		/// </summary>
		// Token: 0x0600F25C RID: 62044 RVA: 0x00151A98 File Offset: 0x0014FC98
		public virtual void SetRepelVertices(vtkPoints arg0)
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_SetRepelVertices_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600F25D RID: 62045
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDijkstraGraphGeodesicPath_SetStopWhenEndReached_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Stop when the end vertex is reached
		/// or calculate shortest path to all vertices
		/// </summary>
		// Token: 0x0600F25E RID: 62046 RVA: 0x00151AC7 File Offset: 0x0014FCC7
		public virtual void SetStopWhenEndReached(int _arg)
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_SetStopWhenEndReached_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F25F RID: 62047
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDijkstraGraphGeodesicPath_SetUseScalarWeights_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Use scalar values in the edge weight (experimental)
		/// </summary>
		// Token: 0x0600F260 RID: 62048 RVA: 0x00151AD7 File Offset: 0x0014FCD7
		public virtual void SetUseScalarWeights(int _arg)
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_SetUseScalarWeights_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F261 RID: 62049
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDijkstraGraphGeodesicPath_StopWhenEndReachedOff_20(HandleRef pThis);

		/// <summary>
		/// Stop when the end vertex is reached
		/// or calculate shortest path to all vertices
		/// </summary>
		// Token: 0x0600F262 RID: 62050 RVA: 0x00151AE7 File Offset: 0x0014FCE7
		public virtual void StopWhenEndReachedOff()
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_StopWhenEndReachedOff_20(base.GetCppThis());
		}

		// Token: 0x0600F263 RID: 62051
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDijkstraGraphGeodesicPath_StopWhenEndReachedOn_21(HandleRef pThis);

		/// <summary>
		/// Stop when the end vertex is reached
		/// or calculate shortest path to all vertices
		/// </summary>
		// Token: 0x0600F264 RID: 62052 RVA: 0x00151AF6 File Offset: 0x0014FCF6
		public virtual void StopWhenEndReachedOn()
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_StopWhenEndReachedOn_21(base.GetCppThis());
		}

		// Token: 0x0600F265 RID: 62053
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDijkstraGraphGeodesicPath_UseScalarWeightsOff_22(HandleRef pThis);

		/// <summary>
		/// Use scalar values in the edge weight (experimental)
		/// </summary>
		// Token: 0x0600F266 RID: 62054 RVA: 0x00151B05 File Offset: 0x0014FD05
		public virtual void UseScalarWeightsOff()
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_UseScalarWeightsOff_22(base.GetCppThis());
		}

		// Token: 0x0600F267 RID: 62055
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDijkstraGraphGeodesicPath_UseScalarWeightsOn_23(HandleRef pThis);

		/// <summary>
		/// Use scalar values in the edge weight (experimental)
		/// </summary>
		// Token: 0x0600F268 RID: 62056 RVA: 0x00151B14 File Offset: 0x0014FD14
		public virtual void UseScalarWeightsOn()
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_UseScalarWeightsOn_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400119F RID: 4511
		public new const string MRFullTypeName = "Kitware.VTK.vtkDijkstraGraphGeodesicPath";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011A0 RID: 4512
		public new static readonly string MRClassNameKey = "class vtkDijkstraGraphGeodesicPath";
	}
}
