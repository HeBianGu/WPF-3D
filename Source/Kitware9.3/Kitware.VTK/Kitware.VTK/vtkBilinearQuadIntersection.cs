using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBilinearQuadIntersection
	/// </summary>
	/// <remarks>
	///    Class to perform non planar quad intersection
	///
	/// Class for non planar quad intersection.
	/// This class is an updated and fixed version of the code by Ramsey et al.
	/// (http://shaunramsey.com/research/bp/).
	/// </remarks>
	// Token: 0x0200091A RID: 2330
	public class vtkBilinearQuadIntersection : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018266 RID: 98918 RVA: 0x0021CB3B File Offset: 0x0021AD3B
		static vtkBilinearQuadIntersection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBilinearQuadIntersection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBilinearQuadIntersection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018267 RID: 98919 RVA: 0x0021CB63 File Offset: 0x0021AD63
		public vtkBilinearQuadIntersection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018268 RID: 98920 RVA: 0x0021CB71 File Offset: 0x0021AD71
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018269 RID: 98921
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBilinearQuadIntersection_ComputeCartesianCoordinates_01(HandleRef pThis, double u, double v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Compute cartesian coordinates of point in the quad
		/// using parameteric coordinates
		/// </summary>
		// Token: 0x0601826A RID: 98922 RVA: 0x0021CB7C File Offset: 0x0021AD7C
		public vtkVector3d ComputeCartesianCoordinates(double u, double v)
		{
			vtkVector3d result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBilinearQuadIntersection.vtkBilinearQuadIntersection_ComputeCartesianCoordinates_01(base.GetCppThis(), u, v, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector3d)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601826B RID: 98923
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBilinearQuadIntersection_GetP00Data_02(HandleRef pThis);

		/// <summary>
		/// Get direct access to the underlying point data
		/// </summary>
		// Token: 0x0601826C RID: 98924 RVA: 0x0021CBD8 File Offset: 0x0021ADD8
		public IntPtr GetP00Data()
		{
			return vtkBilinearQuadIntersection.vtkBilinearQuadIntersection_GetP00Data_02(base.GetCppThis());
		}

		// Token: 0x0601826D RID: 98925
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBilinearQuadIntersection_GetP01Data_03(HandleRef pThis);

		/// <summary>
		/// Get direct access to the underlying point data
		/// </summary>
		// Token: 0x0601826E RID: 98926 RVA: 0x0021CBF8 File Offset: 0x0021ADF8
		public IntPtr GetP01Data()
		{
			return vtkBilinearQuadIntersection.vtkBilinearQuadIntersection_GetP01Data_03(base.GetCppThis());
		}

		// Token: 0x0601826F RID: 98927
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBilinearQuadIntersection_GetP10Data_04(HandleRef pThis);

		/// <summary>
		/// Get direct access to the underlying point data
		/// </summary>
		// Token: 0x06018270 RID: 98928 RVA: 0x0021CC18 File Offset: 0x0021AE18
		public IntPtr GetP10Data()
		{
			return vtkBilinearQuadIntersection.vtkBilinearQuadIntersection_GetP10Data_04(base.GetCppThis());
		}

		// Token: 0x06018271 RID: 98929
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBilinearQuadIntersection_GetP11Data_05(HandleRef pThis);

		/// <summary>
		/// Get direct access to the underlying point data
		/// </summary>
		// Token: 0x06018272 RID: 98930 RVA: 0x0021CC38 File Offset: 0x0021AE38
		public IntPtr GetP11Data()
		{
			return vtkBilinearQuadIntersection.vtkBilinearQuadIntersection_GetP11Data_05(base.GetCppThis());
		}

		// Token: 0x06018273 RID: 98931
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBilinearQuadIntersection_RayIntersection_06(HandleRef pThis, HandleRef r, HandleRef q, HandleRef uv);

		/// <summary>
		/// Compute the intersection between a ray r-&gt;q and the quad
		/// </summary>
		// Token: 0x06018274 RID: 98932 RVA: 0x0021CC58 File Offset: 0x0021AE58
		public bool RayIntersection(vtkVector3d r, vtkVector3d q, vtkVector3d uv)
		{
			return vtkBilinearQuadIntersection.vtkBilinearQuadIntersection_RayIntersection_06(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis(), (q == null) ? default(HandleRef) : q.GetCppThis(), (uv == null) ? default(HandleRef) : uv.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ADE RID: 6878
		public new const string MRFullTypeName = "Kitware.VTK.vtkBilinearQuadIntersection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ADF RID: 6879
		public new static readonly string MRClassNameKey = "class vtkBilinearQuadIntersection";
	}
}
