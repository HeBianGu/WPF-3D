using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBoundaryMeshQuality
	/// </summary>
	/// <remarks>
	///    Computes metrics on the boundary faces of a mesh.
	///
	/// vtkBoundaryMeshQuality computes metrics on the boundary faces of a volumetric mesh.
	/// The metrics that can be computed on the boundary faces of the mesh and are:
	/// - Distance from cell center to face center
	/// - Distance from cell center to face's plane
	/// - Angle of face's plane normal and cell center to face center vector
	/// </remarks>
	// Token: 0x020008FD RID: 2301
	public class vtkBoundaryMeshQuality : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017C37 RID: 97335 RVA: 0x0021517B File Offset: 0x0021337B
		static vtkBoundaryMeshQuality()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoundaryMeshQuality.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoundaryMeshQuality"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017C38 RID: 97336 RVA: 0x002151A3 File Offset: 0x002133A3
		public vtkBoundaryMeshQuality(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017C39 RID: 97337
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundaryMeshQuality_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C3A RID: 97338 RVA: 0x002151B4 File Offset: 0x002133B4
		public new static vtkBoundaryMeshQuality New()
		{
			vtkBoundaryMeshQuality result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoundaryMeshQuality)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C3B RID: 97339 RVA: 0x00215208 File Offset: 0x00213408
		public vtkBoundaryMeshQuality() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017C3C RID: 97340 RVA: 0x0021524C File Offset: 0x0021344C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017C3D RID: 97341
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundaryMeshQuality_AngleFaceNormalAndCellCenterToFaceCenterVectorOff_01(HandleRef pThis);

		/// <summary>
		/// Specify whether to compute the angle between the face normal and cell center to face center
		/// vector. The angle is in degrees.
		/// </summary>
		// Token: 0x06017C3E RID: 97342 RVA: 0x00215257 File Offset: 0x00213457
		public virtual void AngleFaceNormalAndCellCenterToFaceCenterVectorOff()
		{
			vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_AngleFaceNormalAndCellCenterToFaceCenterVectorOff_01(base.GetCppThis());
		}

		// Token: 0x06017C3F RID: 97343
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundaryMeshQuality_AngleFaceNormalAndCellCenterToFaceCenterVectorOn_02(HandleRef pThis);

		/// <summary>
		/// Specify whether to compute the angle between the face normal and cell center to face center
		/// vector. The angle is in degrees.
		/// </summary>
		// Token: 0x06017C40 RID: 97344 RVA: 0x00215266 File Offset: 0x00213466
		public virtual void AngleFaceNormalAndCellCenterToFaceCenterVectorOn()
		{
			vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_AngleFaceNormalAndCellCenterToFaceCenterVectorOn_02(base.GetCppThis());
		}

		// Token: 0x06017C41 RID: 97345
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundaryMeshQuality_DistanceFromCellCenterToFaceCenterOff_03(HandleRef pThis);

		/// <summary>
		/// Specify whether to compute the distance from the cell center ot the face center.
		/// </summary>
		// Token: 0x06017C42 RID: 97346 RVA: 0x00215275 File Offset: 0x00213475
		public virtual void DistanceFromCellCenterToFaceCenterOff()
		{
			vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_DistanceFromCellCenterToFaceCenterOff_03(base.GetCppThis());
		}

		// Token: 0x06017C43 RID: 97347
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundaryMeshQuality_DistanceFromCellCenterToFaceCenterOn_04(HandleRef pThis);

		/// <summary>
		/// Specify whether to compute the distance from the cell center ot the face center.
		/// </summary>
		// Token: 0x06017C44 RID: 97348 RVA: 0x00215284 File Offset: 0x00213484
		public virtual void DistanceFromCellCenterToFaceCenterOn()
		{
			vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_DistanceFromCellCenterToFaceCenterOn_04(base.GetCppThis());
		}

		// Token: 0x06017C45 RID: 97349
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundaryMeshQuality_DistanceFromCellCenterToFacePlaneOff_05(HandleRef pThis);

		/// <summary>
		/// Specify whether to compute the distance from the cell center to the face's plane.
		/// </summary>
		// Token: 0x06017C46 RID: 97350 RVA: 0x00215293 File Offset: 0x00213493
		public virtual void DistanceFromCellCenterToFacePlaneOff()
		{
			vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_DistanceFromCellCenterToFacePlaneOff_05(base.GetCppThis());
		}

		// Token: 0x06017C47 RID: 97351
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundaryMeshQuality_DistanceFromCellCenterToFacePlaneOn_06(HandleRef pThis);

		/// <summary>
		/// Specify whether to compute the distance from the cell center to the face's plane.
		/// </summary>
		// Token: 0x06017C48 RID: 97352 RVA: 0x002152A2 File Offset: 0x002134A2
		public virtual void DistanceFromCellCenterToFacePlaneOn()
		{
			vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_DistanceFromCellCenterToFacePlaneOn_06(base.GetCppThis());
		}

		// Token: 0x06017C49 RID: 97353
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBoundaryMeshQuality_GetAngleFaceNormalAndCellCenterToFaceCenterVector_07(HandleRef pThis);

		/// <summary>
		/// Specify whether to compute the angle between the face normal and cell center to face center
		/// vector. The angle is in degrees.
		/// </summary>
		// Token: 0x06017C4A RID: 97354 RVA: 0x002152B4 File Offset: 0x002134B4
		public virtual bool GetAngleFaceNormalAndCellCenterToFaceCenterVector()
		{
			return vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_GetAngleFaceNormalAndCellCenterToFaceCenterVector_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06017C4B RID: 97355
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBoundaryMeshQuality_GetDistanceFromCellCenterToFaceCenter_08(HandleRef pThis);

		/// <summary>
		/// Specify whether to compute the distance from the cell center ot the face center.
		/// </summary>
		// Token: 0x06017C4C RID: 97356 RVA: 0x002152DC File Offset: 0x002134DC
		public virtual bool GetDistanceFromCellCenterToFaceCenter()
		{
			return vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_GetDistanceFromCellCenterToFaceCenter_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06017C4D RID: 97357
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBoundaryMeshQuality_GetDistanceFromCellCenterToFacePlane_09(HandleRef pThis);

		/// <summary>
		/// Specify whether to compute the distance from the cell center to the face's plane.
		/// </summary>
		// Token: 0x06017C4E RID: 97358 RVA: 0x00215304 File Offset: 0x00213504
		public virtual bool GetDistanceFromCellCenterToFacePlane()
		{
			return vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_GetDistanceFromCellCenterToFacePlane_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06017C4F RID: 97359
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoundaryMeshQuality_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C50 RID: 97360 RVA: 0x0021532C File Offset: 0x0021352C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06017C51 RID: 97361
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoundaryMeshQuality_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C52 RID: 97362 RVA: 0x0021534C File Offset: 0x0021354C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06017C53 RID: 97363
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundaryMeshQuality_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C54 RID: 97364 RVA: 0x00215368 File Offset: 0x00213568
		public override int IsA(string type)
		{
			return vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06017C55 RID: 97365
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundaryMeshQuality_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C56 RID: 97366 RVA: 0x00215388 File Offset: 0x00213588
		public new static int IsTypeOf(string type)
		{
			return vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_IsTypeOf_13(type);
		}

		// Token: 0x06017C57 RID: 97367
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundaryMeshQuality_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C58 RID: 97368 RVA: 0x002153A4 File Offset: 0x002135A4
		public new vtkBoundaryMeshQuality NewInstance()
		{
			vtkBoundaryMeshQuality result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoundaryMeshQuality)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017C59 RID: 97369
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundaryMeshQuality_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C5A RID: 97370 RVA: 0x00215400 File Offset: 0x00213600
		public new static vtkBoundaryMeshQuality SafeDownCast(vtkObjectBase o)
		{
			vtkBoundaryMeshQuality vtkBoundaryMeshQuality = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoundaryMeshQuality = (vtkBoundaryMeshQuality)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoundaryMeshQuality.Register(null);
				}
			}
			return vtkBoundaryMeshQuality;
		}

		// Token: 0x06017C5B RID: 97371
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundaryMeshQuality_SetAngleFaceNormalAndCellCenterToFaceCenterVector_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether to compute the angle between the face normal and cell center to face center
		/// vector. The angle is in degrees.
		/// </summary>
		// Token: 0x06017C5C RID: 97372 RVA: 0x0021547F File Offset: 0x0021367F
		public virtual void SetAngleFaceNormalAndCellCenterToFaceCenterVector(bool _arg)
		{
			vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_SetAngleFaceNormalAndCellCenterToFaceCenterVector_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017C5D RID: 97373
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundaryMeshQuality_SetDistanceFromCellCenterToFaceCenter_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether to compute the distance from the cell center ot the face center.
		/// </summary>
		// Token: 0x06017C5E RID: 97374 RVA: 0x00215497 File Offset: 0x00213697
		public virtual void SetDistanceFromCellCenterToFaceCenter(bool _arg)
		{
			vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_SetDistanceFromCellCenterToFaceCenter_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017C5F RID: 97375
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundaryMeshQuality_SetDistanceFromCellCenterToFacePlane_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether to compute the distance from the cell center to the face's plane.
		/// </summary>
		// Token: 0x06017C60 RID: 97376 RVA: 0x002154AF File Offset: 0x002136AF
		public virtual void SetDistanceFromCellCenterToFacePlane(bool _arg)
		{
			vtkBoundaryMeshQuality.vtkBoundaryMeshQuality_SetDistanceFromCellCenterToFacePlane_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A79 RID: 6777
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoundaryMeshQuality";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A7A RID: 6778
		public new static readonly string MRClassNameKey = "class vtkBoundaryMeshQuality";
	}
}
