using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolygonBuilder
	///
	///
	///  The polygon output is the boundary of the union of the triangles.
	///  It is assumed that the input triangles form a simple polygon. It is
	///  currently used to compute polygons for slicing.
	///
	/// </summary>
	// Token: 0x02000B04 RID: 2820
	public class vtkPolygonBuilder : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DA2E RID: 121390 RVA: 0x0029D827 File Offset: 0x0029BA27
		static vtkPolygonBuilder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolygonBuilder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygonBuilder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DA2F RID: 121391 RVA: 0x0029D84F File Offset: 0x0029BA4F
		public vtkPolygonBuilder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DA30 RID: 121392 RVA: 0x0029D85D File Offset: 0x0029BA5D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DA31 RID: 121393
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonBuilder_GetPolygons_01(HandleRef pThis, HandleRef polys);

		/// <summary>
		/// Populate polys with lists of polygons, defined as sequential external
		/// vertices. It is the responsibility of the user to delete these generated
		/// lists in order to avoid memory leaks.
		/// </summary>
		// Token: 0x0601DA32 RID: 121394 RVA: 0x0029D868 File Offset: 0x0029BA68
		public void GetPolygons(vtkIdListCollection polys)
		{
			vtkPolygonBuilder.vtkPolygonBuilder_GetPolygons_01(base.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis());
		}

		// Token: 0x0601DA33 RID: 121395
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonBuilder_InsertTriangle_02(HandleRef pThis, IntPtr abc);

		/// <summary>
		/// Insert a triangle as a triplet of point IDs.
		/// </summary>
		// Token: 0x0601DA34 RID: 121396 RVA: 0x0029D897 File Offset: 0x0029BA97
		public void InsertTriangle(IntPtr abc)
		{
			vtkPolygonBuilder.vtkPolygonBuilder_InsertTriangle_02(base.GetCppThis(), abc);
		}

		// Token: 0x0601DA35 RID: 121397
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonBuilder_Reset_03(HandleRef pThis);

		/// <summary>
		/// Prepare the builder for a new set of inputs.
		/// </summary>
		// Token: 0x0601DA36 RID: 121398 RVA: 0x0029D8A7 File Offset: 0x0029BAA7
		public void Reset()
		{
			vtkPolygonBuilder.vtkPolygonBuilder_Reset_03(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F39 RID: 7993
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolygonBuilder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F3A RID: 7994
		public new static readonly string MRClassNameKey = "class vtkPolygonBuilder";
	}
}
