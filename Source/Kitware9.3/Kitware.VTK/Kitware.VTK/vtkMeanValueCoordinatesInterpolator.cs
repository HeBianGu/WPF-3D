using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMeanValueCoordinatesInterpolator
	/// </summary>
	/// <remarks>
	///    compute interpolation computes
	/// for closed triangular mesh
	///
	/// vtkMeanValueCoordinatesInterpolator computes interpolation weights for a
	/// closed, manifold polyhedron mesh.  Once computed, the interpolation
	/// weights can be used to interpolate data anywhere interior or exterior to
	/// the mesh. This work implements two MVC algorithms. The first one is for
	/// triangular meshes which is documented in the Siggraph 2005 paper by Tao Ju,
	/// Scot Schaefer and Joe Warren from Rice University "Mean Value Coordinates
	/// for Closed Triangular Meshes". The second one is for general polyhedron
	/// mesh which is documented in the Eurographics Symposium on Geometry Processing
	/// 2006 paper by Torsten Langer, Alexander Belyaev and Hans-Peter Seidel from
	/// MPI Informatik "Spherical Barycentric Coordinates".
	/// The filter will automatically choose which algorithm to use based on whether
	/// the input mesh is triangulated or not.
	///
	/// In VTK this class was initially created to interpolate data across
	/// polyhedral cells. In addition, the class can be used to interpolate
	/// data values from a polyhedron mesh, and to smoothly deform a mesh from
	/// an associated control mesh.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyhedralCell
	/// </seealso>
	// Token: 0x02000A81 RID: 2689
	public class vtkMeanValueCoordinatesInterpolator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C270 RID: 115312 RVA: 0x00277D21 File Offset: 0x00275F21
		static vtkMeanValueCoordinatesInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMeanValueCoordinatesInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMeanValueCoordinatesInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C271 RID: 115313 RVA: 0x00277D49 File Offset: 0x00275F49
		public vtkMeanValueCoordinatesInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C272 RID: 115314
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeanValueCoordinatesInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiable class methods.
		/// </summary>
		// Token: 0x0601C273 RID: 115315 RVA: 0x00277D58 File Offset: 0x00275F58
		public new static vtkMeanValueCoordinatesInterpolator New()
		{
			vtkMeanValueCoordinatesInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMeanValueCoordinatesInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard instantiable class methods.
		/// </summary>
		// Token: 0x0601C274 RID: 115316 RVA: 0x00277DAC File Offset: 0x00275FAC
		public vtkMeanValueCoordinatesInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C275 RID: 115317 RVA: 0x00277DF0 File Offset: 0x00275FF0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C276 RID: 115318
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeanValueCoordinatesInterpolator_ComputeInterpolationWeights_01(IntPtr x, HandleRef pts, HandleRef tris, IntPtr weights);

		/// <summary>
		/// Method to generate interpolation weights for a point x[3] from a list of
		/// triangles.  In this version of the method, the triangles are defined by
		/// a vtkPoints array plus a vtkIdList, where the vtkIdList is organized
		/// such that three ids in order define a triangle.  Note that number of weights
		/// must equal the number of points.
		/// </summary>
		// Token: 0x0601C277 RID: 115319 RVA: 0x00277DFC File Offset: 0x00275FFC
		public static void ComputeInterpolationWeights(IntPtr x, vtkPoints pts, vtkIdList tris, IntPtr weights)
		{
			vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_ComputeInterpolationWeights_01(x, (pts == null) ? default(HandleRef) : pts.GetCppThis(), (tris == null) ? default(HandleRef) : tris.GetCppThis(), weights);
		}

		// Token: 0x0601C278 RID: 115320
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeanValueCoordinatesInterpolator_ComputeInterpolationWeights_02(IntPtr x, HandleRef pts, HandleRef tris, IntPtr weights);

		/// <summary>
		/// Method to generate interpolation weights for a point x[3] from a list of
		/// polygonal faces.  In this version of the method, the faces are defined by
		/// a vtkPoints array plus a vtkCellArray, where the vtkCellArray contains all
		/// faces and is of format [nFace0Pts, pid1, pid2, pid3,..., nFace1Pts, pid1,
		/// pid2, pid3,...].  Note: the number of weights must equal the number of points.
		/// </summary>
		// Token: 0x0601C279 RID: 115321 RVA: 0x00277E3C File Offset: 0x0027603C
		public static void ComputeInterpolationWeights(IntPtr x, vtkPoints pts, vtkCellArray tris, IntPtr weights)
		{
			vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_ComputeInterpolationWeights_02(x, (pts == null) ? default(HandleRef) : pts.GetCppThis(), (tris == null) ? default(HandleRef) : tris.GetCppThis(), weights);
		}

		// Token: 0x0601C27A RID: 115322
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMeanValueCoordinatesInterpolator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiable class methods.
		/// </summary>
		// Token: 0x0601C27B RID: 115323 RVA: 0x00277E7C File Offset: 0x0027607C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601C27C RID: 115324
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMeanValueCoordinatesInterpolator_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiable class methods.
		/// </summary>
		// Token: 0x0601C27D RID: 115325 RVA: 0x00277E9C File Offset: 0x0027609C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601C27E RID: 115326
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeanValueCoordinatesInterpolator_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiable class methods.
		/// </summary>
		// Token: 0x0601C27F RID: 115327 RVA: 0x00277EB8 File Offset: 0x002760B8
		public override int IsA(string type)
		{
			return vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601C280 RID: 115328
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeanValueCoordinatesInterpolator_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiable class methods.
		/// </summary>
		// Token: 0x0601C281 RID: 115329 RVA: 0x00277ED8 File Offset: 0x002760D8
		public new static int IsTypeOf(string type)
		{
			return vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_IsTypeOf_06(type);
		}

		// Token: 0x0601C282 RID: 115330
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeanValueCoordinatesInterpolator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiable class methods.
		/// </summary>
		// Token: 0x0601C283 RID: 115331 RVA: 0x00277EF4 File Offset: 0x002760F4
		public new vtkMeanValueCoordinatesInterpolator NewInstance()
		{
			vtkMeanValueCoordinatesInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMeanValueCoordinatesInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C284 RID: 115332
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeanValueCoordinatesInterpolator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiable class methods.
		/// </summary>
		// Token: 0x0601C285 RID: 115333 RVA: 0x00277F50 File Offset: 0x00276150
		public new static vtkMeanValueCoordinatesInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkMeanValueCoordinatesInterpolator vtkMeanValueCoordinatesInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMeanValueCoordinatesInterpolator = (vtkMeanValueCoordinatesInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMeanValueCoordinatesInterpolator.Register(null);
				}
			}
			return vtkMeanValueCoordinatesInterpolator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DFE RID: 7678
		public new const string MRFullTypeName = "Kitware.VTK.vtkMeanValueCoordinatesInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DFF RID: 7679
		public new static readonly string MRClassNameKey = "class vtkMeanValueCoordinatesInterpolator";
	}
}
