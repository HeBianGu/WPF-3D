using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTriangleMeshPointNormals
	/// </summary>
	/// <remarks>
	///    compute point normals for triangle mesh
	///
	/// vtkTriangleMeshPointNormals is a filter that computes point normals for
	/// a triangle mesh to enable high-performance rendering. It is a fast-path
	/// version of the vtkPolyDataNormals filter in order to be able to compute
	/// normals for triangle meshes deforming rapidly.
	///
	/// The computed normals (a vtkFloatArray) are set to be the active normals
	/// (using SetNormals()) of the PointData. The array name is "Normals", so
	/// they can be retrieved either with `output-&gt;GetPointData()-&gt;GetNormals()`
	/// or with `output-&gt;GetPointData()-&gt;GetArray("Normals")`.
	///
	/// The algorithm works by determining normals for each triangle and adding
	/// these vectors to the triangle points. The resulting vectors at each
	/// point are then normalized.
	///
	/// @warning
	/// Normals are computed only for triangular polygons: the filter can not
	/// handle meshes with other types of cells (Verts, Lines, Strips) or Polys
	/// with the wrong number of components (not equal to 3).
	///
	/// @warning
	/// Unlike the vtkPolyDataNormals filter, this filter does not apply any
	/// splitting nor checks for cell orientation consistency in order to speed
	/// up the computation. Moreover, normals are not calculated the exact same
	/// way as the vtkPolyDataNormals filter since the triangle normals are not
	/// normalized before being added to the point normals: those cell normals
	/// are therefore weighted by the triangle area. This is not more nor less
	/// correct than normalizing them before adding them, but it is much faster.
	///
	/// </remarks>
	/// <seealso>
	///
	/// If you do not need to do high-performance rendering, you should use
	/// vtkPolyDataNormals if your mesh is not only triangular, if you need to
	/// split vertices at sharp edges, or if you need to check that the cell
	/// orientations are consistent to flip inverted normals.
	///
	///
	/// If you still need high-performance rendering but your input polydata is
	/// not a triangular mesh and/or does not have consistent cell orientations
	/// (causing inverted normals), you can still use this filter by using
	/// vtkTriangleFilter and/or vtkCleanPolyData respectively beforehand. If
	/// your mesh is deforming rapidly, you should be deforming the output mesh
	/// of those two filters instead in order to only run them once.
	///
	/// </seealso>
	// Token: 0x020009B9 RID: 2489
	public class vtkTriangleMeshPointNormals : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A007 RID: 106503 RVA: 0x00240E37 File Offset: 0x0023F037
		static vtkTriangleMeshPointNormals()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriangleMeshPointNormals.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangleMeshPointNormals"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A008 RID: 106504 RVA: 0x00240E5F File Offset: 0x0023F05F
		public vtkTriangleMeshPointNormals(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A009 RID: 106505
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangleMeshPointNormals_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A00A RID: 106506 RVA: 0x00240E70 File Offset: 0x0023F070
		public new static vtkTriangleMeshPointNormals New()
		{
			vtkTriangleMeshPointNormals result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangleMeshPointNormals.vtkTriangleMeshPointNormals_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangleMeshPointNormals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A00B RID: 106507 RVA: 0x00240EC4 File Offset: 0x0023F0C4
		public vtkTriangleMeshPointNormals() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTriangleMeshPointNormals.vtkTriangleMeshPointNormals_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A00C RID: 106508 RVA: 0x00240F08 File Offset: 0x0023F108
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A00D RID: 106509
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriangleMeshPointNormals_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A00E RID: 106510 RVA: 0x00240F14 File Offset: 0x0023F114
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTriangleMeshPointNormals.vtkTriangleMeshPointNormals_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A00F RID: 106511
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriangleMeshPointNormals_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A010 RID: 106512 RVA: 0x00240F34 File Offset: 0x0023F134
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTriangleMeshPointNormals.vtkTriangleMeshPointNormals_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A011 RID: 106513
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleMeshPointNormals_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A012 RID: 106514 RVA: 0x00240F50 File Offset: 0x0023F150
		public override int IsA(string type)
		{
			return vtkTriangleMeshPointNormals.vtkTriangleMeshPointNormals_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A013 RID: 106515
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleMeshPointNormals_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A014 RID: 106516 RVA: 0x00240F70 File Offset: 0x0023F170
		public new static int IsTypeOf(string type)
		{
			return vtkTriangleMeshPointNormals.vtkTriangleMeshPointNormals_IsTypeOf_04(type);
		}

		// Token: 0x0601A015 RID: 106517
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangleMeshPointNormals_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A016 RID: 106518 RVA: 0x00240F8C File Offset: 0x0023F18C
		public new vtkTriangleMeshPointNormals NewInstance()
		{
			vtkTriangleMeshPointNormals result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangleMeshPointNormals.vtkTriangleMeshPointNormals_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangleMeshPointNormals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A017 RID: 106519
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangleMeshPointNormals_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A018 RID: 106520 RVA: 0x00240FE8 File Offset: 0x0023F1E8
		public new static vtkTriangleMeshPointNormals SafeDownCast(vtkObjectBase o)
		{
			vtkTriangleMeshPointNormals vtkTriangleMeshPointNormals = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangleMeshPointNormals.vtkTriangleMeshPointNormals_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriangleMeshPointNormals = (vtkTriangleMeshPointNormals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriangleMeshPointNormals.Register(null);
				}
			}
			return vtkTriangleMeshPointNormals;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C38 RID: 7224
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriangleMeshPointNormals";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C39 RID: 7225
		public new static readonly string MRClassNameKey = "class vtkTriangleMeshPointNormals";
	}
}
