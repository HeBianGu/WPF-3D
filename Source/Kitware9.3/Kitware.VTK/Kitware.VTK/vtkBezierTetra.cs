using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBezierTetra
	/// </summary>
	/// <remarks>
	///    A 3D cell that represents an arbitrary order Bezier tetrahedron
	///
	/// vtkBezierTetra is a concrete implementation of vtkCell to represent a
	/// 3D tetrahedron using Bezier shape functions of user specified order.
	///
	/// The number of points in a Bezier cell determines the order over which they
	/// are iterated relative to the parametric coordinate system of the cell. The
	/// first points that are reported are vertices. They appear in the same order in
	/// which they would appear in linear cells. Mid-edge points are reported next.
	/// They are reported in sequence. For two- and three-dimensional (3D) cells, the
	/// following set of points to be reported are face points. Finally, 3D cells
	/// report points interior to their volume.
	/// </remarks>
	// Token: 0x02000A08 RID: 2568
	public class vtkBezierTetra : vtkHigherOrderTetra
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AAF9 RID: 109305 RVA: 0x00252175 File Offset: 0x00250375
		static vtkBezierTetra()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBezierTetra.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBezierTetra"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AAFA RID: 109306 RVA: 0x0025219D File Offset: 0x0025039D
		public vtkBezierTetra(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AAFB RID: 109307
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTetra_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAFC RID: 109308 RVA: 0x002521AC File Offset: 0x002503AC
		public new static vtkBezierTetra New()
		{
			vtkBezierTetra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTetra.vtkBezierTetra_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAFD RID: 109309 RVA: 0x00252200 File Offset: 0x00250400
		public vtkBezierTetra() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBezierTetra.vtkBezierTetra_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AAFE RID: 109310 RVA: 0x00252244 File Offset: 0x00250444
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AAFF RID: 109311
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierTetra_GetCellType_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB00 RID: 109312 RVA: 0x00252250 File Offset: 0x00250450
		public override int GetCellType()
		{
			return vtkBezierTetra.vtkBezierTetra_GetCellType_01(base.GetCppThis());
		}

		// Token: 0x0601AB01 RID: 109313
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTetra_GetEdge_02(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB02 RID: 109314 RVA: 0x00252270 File Offset: 0x00250470
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTetra.vtkBezierTetra_GetEdge_02(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601AB03 RID: 109315
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTetra_GetEdgeCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB04 RID: 109316 RVA: 0x002522E0 File Offset: 0x002504E0
		public override vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTetra.vtkBezierTetra_GetEdgeCell_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderCurve = (vtkHigherOrderCurve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderCurve.Register(null);
				}
			}
			return vtkHigherOrderCurve;
		}

		// Token: 0x0601AB05 RID: 109317
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTetra_GetFace_04(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB06 RID: 109318 RVA: 0x00252350 File Offset: 0x00250550
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTetra.vtkBezierTetra_GetFace_04(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601AB07 RID: 109319
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTetra_GetFaceCell_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB08 RID: 109320 RVA: 0x002523C0 File Offset: 0x002505C0
		public override vtkHigherOrderTriangle GetFaceCell()
		{
			vtkHigherOrderTriangle vtkHigherOrderTriangle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTetra.vtkBezierTetra_GetFaceCell_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderTriangle = (vtkHigherOrderTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderTriangle.Register(null);
				}
			}
			return vtkHigherOrderTriangle;
		}

		// Token: 0x0601AB09 RID: 109321
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierTetra_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB0A RID: 109322 RVA: 0x00252430 File Offset: 0x00250630
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBezierTetra.vtkBezierTetra_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601AB0B RID: 109323
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierTetra_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB0C RID: 109324 RVA: 0x00252450 File Offset: 0x00250650
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBezierTetra.vtkBezierTetra_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601AB0D RID: 109325
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTetra_GetRationalWeights_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB0E RID: 109326 RVA: 0x0025246C File Offset: 0x0025066C
		public vtkDoubleArray GetRationalWeights()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTetra.vtkBezierTetra_GetRationalWeights_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x0601AB0F RID: 109327
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierTetra_InterpolateDerivs_09(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB10 RID: 109328 RVA: 0x002524DB File Offset: 0x002506DB
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBezierTetra.vtkBezierTetra_InterpolateDerivs_09(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601AB11 RID: 109329
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierTetra_InterpolateFunctions_10(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB12 RID: 109330 RVA: 0x002524EC File Offset: 0x002506EC
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBezierTetra.vtkBezierTetra_InterpolateFunctions_10(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601AB13 RID: 109331
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierTetra_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB14 RID: 109332 RVA: 0x00252500 File Offset: 0x00250700
		public override int IsA(string type)
		{
			return vtkBezierTetra.vtkBezierTetra_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601AB15 RID: 109333
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierTetra_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB16 RID: 109334 RVA: 0x00252520 File Offset: 0x00250720
		public new static int IsTypeOf(string type)
		{
			return vtkBezierTetra.vtkBezierTetra_IsTypeOf_12(type);
		}

		// Token: 0x0601AB17 RID: 109335
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTetra_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB18 RID: 109336 RVA: 0x0025253C File Offset: 0x0025073C
		public new vtkBezierTetra NewInstance()
		{
			vtkBezierTetra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTetra.vtkBezierTetra_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AB19 RID: 109337
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTetra_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB1A RID: 109338 RVA: 0x00252598 File Offset: 0x00250798
		public new static vtkBezierTetra SafeDownCast(vtkObjectBase o)
		{
			vtkBezierTetra vtkBezierTetra = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTetra.vtkBezierTetra_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBezierTetra = (vtkBezierTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBezierTetra.Register(null);
				}
			}
			return vtkBezierTetra;
		}

		// Token: 0x0601AB1B RID: 109339
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierTetra_SetRationalWeightsFromPointData_16(HandleRef pThis, HandleRef point_data, long numPts);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB1C RID: 109340 RVA: 0x00252618 File Offset: 0x00250818
		public void SetRationalWeightsFromPointData(vtkPointData point_data, long numPts)
		{
			vtkBezierTetra.vtkBezierTetra_SetRationalWeightsFromPointData_16(base.GetCppThis(), (point_data == null) ? default(HandleRef) : point_data.GetCppThis(), numPts);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CE8 RID: 7400
		public new const string MRFullTypeName = "Kitware.VTK.vtkBezierTetra";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CE9 RID: 7401
		public new static readonly string MRClassNameKey = "class vtkBezierTetra";
	}
}
