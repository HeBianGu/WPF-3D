using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIntersectionCounter
	/// </summary>
	/// <remarks>
	///    Fast simple class for dealing with ray intersections
	///
	/// vtkIntersectionCounter is used to intersect data and merge coincident
	/// points along the intersect ray. It is light-weight and many of the member
	/// functions are in-lined so its very fast. It is not derived from vtkObject
	/// so it can be allocated on the stack.
	///
	/// This class makes the finite ray intersection process more robust. It
	/// merges intersections that are very close to one another (within a
	/// tolerance). Such situations are common when intersection rays pass through
	/// the edge or vertex of a mesh.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBoundingBox
	/// </seealso>
	// Token: 0x020009EE RID: 2542
	public class vtkIntersectionCounter : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A6A0 RID: 108192 RVA: 0x0024AEE0 File Offset: 0x002490E0
		static vtkIntersectionCounter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIntersectionCounter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIntersectionCounter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A6A1 RID: 108193 RVA: 0x0024AF08 File Offset: 0x00249108
		public vtkIntersectionCounter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A6A2 RID: 108194 RVA: 0x0024AF16 File Offset: 0x00249116
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A6A3 RID: 108195
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionCounter_AddIntersection_01(HandleRef pThis, double t);

		/// <summary>
		/// Add an intersection given by parametric coordinate t.
		/// </summary>
		// Token: 0x0601A6A4 RID: 108196 RVA: 0x0024AF21 File Offset: 0x00249121
		public void AddIntersection(double t)
		{
			vtkIntersectionCounter.vtkIntersectionCounter_AddIntersection_01(base.GetCppThis(), t);
		}

		// Token: 0x0601A6A5 RID: 108197
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntersectionCounter_CountIntersections_02(HandleRef pThis);

		/// <summary>
		/// Returns number of intersections (even number of intersections, outside
		/// or odd number of intersections, inside). This is done by considering
		/// close intersections (within Tolerance) as being the same point.
		/// </summary>
		// Token: 0x0601A6A6 RID: 108198 RVA: 0x0024AF34 File Offset: 0x00249134
		public int CountIntersections()
		{
			return vtkIntersectionCounter.vtkIntersectionCounter_CountIntersections_02(base.GetCppThis());
		}

		// Token: 0x0601A6A7 RID: 108199
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIntersectionCounter_GetTolerance_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the intersection tolerance.
		/// </summary>
		// Token: 0x0601A6A8 RID: 108200 RVA: 0x0024AF54 File Offset: 0x00249154
		public double GetTolerance()
		{
			return vtkIntersectionCounter.vtkIntersectionCounter_GetTolerance_03(base.GetCppThis());
		}

		// Token: 0x0601A6A9 RID: 108201
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionCounter_Reset_04(HandleRef pThis);

		/// <summary>
		/// Reset the intersection process.
		/// </summary>
		// Token: 0x0601A6AA RID: 108202 RVA: 0x0024AF73 File Offset: 0x00249173
		public void Reset()
		{
			vtkIntersectionCounter.vtkIntersectionCounter_Reset_04(base.GetCppThis());
		}

		// Token: 0x0601A6AB RID: 108203
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntersectionCounter_SetTolerance_05(HandleRef pThis, double tol);

		/// <summary>
		/// Set/Get the intersection tolerance.
		/// </summary>
		// Token: 0x0601A6AC RID: 108204 RVA: 0x0024AF82 File Offset: 0x00249182
		public void SetTolerance(double tol)
		{
			vtkIntersectionCounter.vtkIntersectionCounter_SetTolerance_05(base.GetCppThis(), tol);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CAC RID: 7340
		public new const string MRFullTypeName = "Kitware.VTK.vtkIntersectionCounter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CAD RID: 7341
		public new static readonly string MRClassNameKey = "class vtkIntersectionCounter";
	}
}
