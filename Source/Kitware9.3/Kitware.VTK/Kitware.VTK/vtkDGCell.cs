using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGCell
	/// </summary>
	/// <remarks>
	///    Base class for a discontinuous Galerkin cells of all shapes.
	///
	/// This class exists to offer each shape's parameterization via a uniform API.
	///
	/// All DG cells have shapes that can be described by corner points in
	/// a reference (parametric) coordinate system. Sides (boundaries) of
	/// the element of any dimension can be fetched as offsets into the list
	/// of corners. You can also obtain a list of the coordinates in parametric
	/// space of all the corner points.
	/// </remarks>
	// Token: 0x020004DD RID: 1245
	public abstract class vtkDGCell : vtkCellMetadata
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E18D RID: 57741 RVA: 0x001396A3 File Offset: 0x001378A3
		static vtkDGCell()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGCell.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGCell"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E18E RID: 57742 RVA: 0x001396CB File Offset: 0x001378CB
		public vtkDGCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E18F RID: 57743 RVA: 0x001396D9 File Offset: 0x001378D9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E190 RID: 57744
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDGCell_DeepCopy_01(HandleRef pThis, HandleRef other);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E191 RID: 57745 RVA: 0x001396E4 File Offset: 0x001378E4
		public override void DeepCopy(vtkCellMetadata other)
		{
			vtkDGCell.vtkDGCell_DeepCopy_01(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0600E192 RID: 57746
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDGCell_FillReferencePoints_02(HandleRef pThis, HandleRef arr);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E193 RID: 57747 RVA: 0x00139714 File Offset: 0x00137914
		public void FillReferencePoints(vtkTypeFloat32Array arr)
		{
			vtkDGCell.vtkDGCell_FillReferencePoints_02(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x0600E194 RID: 57748
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDGCell_FillSideConnectivity_03(HandleRef pThis, HandleRef arr);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E195 RID: 57749 RVA: 0x00139744 File Offset: 0x00137944
		public void FillSideConnectivity(vtkTypeInt32Array arr)
		{
			vtkDGCell.vtkDGCell_FillSideConnectivity_03(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x0600E196 RID: 57750
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDGCell_FillSideOffsetsAndShapes_04(HandleRef pThis, HandleRef arr);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E197 RID: 57751 RVA: 0x00139774 File Offset: 0x00137974
		public void FillSideOffsetsAndShapes(vtkTypeInt32Array arr)
		{
			vtkDGCell.vtkDGCell_FillSideOffsetsAndShapes_04(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x0600E198 RID: 57752
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGCell_GetDimension_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E199 RID: 57753 RVA: 0x001397A4 File Offset: 0x001379A4
		public virtual int GetDimension()
		{
			return vtkDGCell.vtkDGCell_GetDimension_05(base.GetCppThis());
		}

		// Token: 0x0600E19A RID: 57754
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGCell_GetNumberOfCells_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E19B RID: 57755 RVA: 0x001397C4 File Offset: 0x001379C4
		public override long GetNumberOfCells()
		{
			return vtkDGCell.vtkDGCell_GetNumberOfCells_06(base.GetCppThis());
		}

		// Token: 0x0600E19C RID: 57756
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGCell_GetNumberOfCorners_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E19D RID: 57757 RVA: 0x001397E4 File Offset: 0x001379E4
		public virtual int GetNumberOfCorners()
		{
			return vtkDGCell.vtkDGCell_GetNumberOfCorners_07(base.GetCppThis());
		}

		// Token: 0x0600E19E RID: 57758
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGCell_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E19F RID: 57759 RVA: 0x00139804 File Offset: 0x00137A04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGCell.vtkDGCell_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600E1A0 RID: 57760
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGCell_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1A1 RID: 57761 RVA: 0x00139824 File Offset: 0x00137A24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGCell.vtkDGCell_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600E1A2 RID: 57762
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGCell_GetNumberOfSideTypes_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1A3 RID: 57763 RVA: 0x00139840 File Offset: 0x00137A40
		public virtual int GetNumberOfSideTypes()
		{
			return vtkDGCell.vtkDGCell_GetNumberOfSideTypes_10(base.GetCppThis());
		}

		// Token: 0x0600E1A4 RID: 57764
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGCell_GetNumberOfSidesOfDimension_11(HandleRef pThis, int dimension);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1A5 RID: 57765 RVA: 0x00139860 File Offset: 0x00137A60
		public virtual int GetNumberOfSidesOfDimension(int dimension)
		{
			return vtkDGCell.vtkDGCell_GetNumberOfSidesOfDimension_11(base.GetCppThis(), dimension);
		}

		// Token: 0x0600E1A6 RID: 57766
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGCell_GetReferencePoints_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1A7 RID: 57767 RVA: 0x00139880 File Offset: 0x00137A80
		public virtual vtkTypeFloat32Array GetReferencePoints()
		{
			vtkTypeFloat32Array vtkTypeFloat32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGCell.vtkDGCell_GetReferencePoints_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeFloat32Array = (vtkTypeFloat32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeFloat32Array.Register(null);
				}
			}
			return vtkTypeFloat32Array;
		}

		// Token: 0x0600E1A8 RID: 57768
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGCell_GetShape_13(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1A9 RID: 57769 RVA: 0x001398F0 File Offset: 0x00137AF0
		public virtual vtkDGCell.Shape GetShape()
		{
			return vtkDGCell.vtkDGCell_GetShape_13(base.GetCppThis());
		}

		// Token: 0x0600E1AA RID: 57770
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGCell_GetShapeCornerCount_14(vtkDGCell.Shape shape);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1AB RID: 57771 RVA: 0x00139910 File Offset: 0x00137B10
		public static int GetShapeCornerCount(vtkDGCell.Shape shape)
		{
			return vtkDGCell.vtkDGCell_GetShapeCornerCount_14(shape);
		}

		// Token: 0x0600E1AC RID: 57772
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGCell_GetShapeDimension_15(vtkDGCell.Shape shape);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1AD RID: 57773 RVA: 0x0013992C File Offset: 0x00137B2C
		public static int GetShapeDimension(vtkDGCell.Shape shape)
		{
			return vtkDGCell.vtkDGCell_GetShapeDimension_15(shape);
		}

		// Token: 0x0600E1AE RID: 57774
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGCell_GetShapeEnum_16(vtkStringToken shapeName);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1AF RID: 57775 RVA: 0x00139948 File Offset: 0x00137B48
		public static vtkDGCell.Shape GetShapeEnum(vtkStringToken shapeName)
		{
			return vtkDGCell.vtkDGCell_GetShapeEnum_16(shapeName);
		}

		// Token: 0x0600E1B0 RID: 57776
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkStringToken vtkDGCell_GetShapeName_17(vtkDGCell.Shape shape);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1B1 RID: 57777 RVA: 0x00139964 File Offset: 0x00137B64
		public static vtkStringToken GetShapeName(vtkDGCell.Shape shape)
		{
			return vtkDGCell.vtkDGCell_GetShapeName_17(shape);
		}

		// Token: 0x0600E1B2 RID: 57778
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGCell_GetSideConnectivity_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1B3 RID: 57779 RVA: 0x00139980 File Offset: 0x00137B80
		public virtual vtkTypeInt32Array GetSideConnectivity()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGCell.vtkDGCell_GetSideConnectivity_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt32Array = (vtkTypeInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt32Array.Register(null);
				}
			}
			return vtkTypeInt32Array;
		}

		// Token: 0x0600E1B4 RID: 57780
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGCell_GetSideOffsetsAndShapes_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1B5 RID: 57781 RVA: 0x001399F0 File Offset: 0x00137BF0
		public virtual vtkTypeInt32Array GetSideOffsetsAndShapes()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGCell.vtkDGCell_GetSideOffsetsAndShapes_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt32Array = (vtkTypeInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt32Array.Register(null);
				}
			}
			return vtkTypeInt32Array;
		}

		// Token: 0x0600E1B6 RID: 57782
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGCell_GetSideRangeForSideType_20(HandleRef pThis, int sideType);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1B7 RID: 57783 RVA: 0x00139A60 File Offset: 0x00137C60
		public IntPtr GetSideRangeForSideType(int sideType)
		{
			return vtkDGCell.vtkDGCell_GetSideRangeForSideType_20(base.GetCppThis(), sideType);
		}

		// Token: 0x0600E1B8 RID: 57784
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGCell_GetSideShape_21(HandleRef pThis, int side);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1B9 RID: 57785 RVA: 0x00139A80 File Offset: 0x00137C80
		public virtual vtkDGCell.Shape GetSideShape(int side)
		{
			return vtkDGCell.vtkDGCell_GetSideShape_21(base.GetCppThis(), side);
		}

		// Token: 0x0600E1BA RID: 57786
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGCell_GetSideTypeForShape_22(HandleRef pThis, vtkDGCell.Shape s);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1BB RID: 57787 RVA: 0x00139AA0 File Offset: 0x00137CA0
		public virtual int GetSideTypeForShape(vtkDGCell.Shape s)
		{
			return vtkDGCell.vtkDGCell_GetSideTypeForShape_22(base.GetCppThis(), s);
		}

		// Token: 0x0600E1BC RID: 57788
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGCell_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1BD RID: 57789 RVA: 0x00139AC0 File Offset: 0x00137CC0
		public override int IsA(string type)
		{
			return vtkDGCell.vtkDGCell_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0600E1BE RID: 57790
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGCell_IsInside_24(HandleRef pThis, HandleRef rst, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1BF RID: 57791 RVA: 0x00139AE0 File Offset: 0x00137CE0
		public virtual bool IsInside(vtkVector3d rst, double tolerance)
		{
			return vtkDGCell.vtkDGCell_IsInside_24(base.GetCppThis(), (rst == null) ? default(HandleRef) : rst.GetCppThis(), tolerance) != 0;
		}

		// Token: 0x0600E1C0 RID: 57792
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGCell_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1C1 RID: 57793 RVA: 0x00139B1C File Offset: 0x00137D1C
		public new static int IsTypeOf(string type)
		{
			return vtkDGCell.vtkDGCell_IsTypeOf_25(type);
		}

		// Token: 0x0600E1C2 RID: 57794
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGCell_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1C3 RID: 57795 RVA: 0x00139B38 File Offset: 0x00137D38
		public new vtkDGCell NewInstance()
		{
			vtkDGCell result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGCell.vtkDGCell_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E1C4 RID: 57796
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGCell_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1C5 RID: 57797 RVA: 0x00139B94 File Offset: 0x00137D94
		public new static vtkDGCell SafeDownCast(vtkObjectBase o)
		{
			vtkDGCell vtkDGCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGCell.vtkDGCell_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGCell = (vtkDGCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGCell.Register(null);
				}
			}
			return vtkDGCell;
		}

		// Token: 0x0600E1C6 RID: 57798
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDGCell_ShallowCopy_28(HandleRef pThis, HandleRef other);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1C7 RID: 57799 RVA: 0x00139C14 File Offset: 0x00137E14
		public override void ShallowCopy(vtkCellMetadata other)
		{
			vtkDGCell.vtkDGCell_ShallowCopy_28(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001095 RID: 4245
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGCell";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001096 RID: 4246
		public new static readonly string MRClassNameKey = "class vtkDGCell";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020004DE RID: 1246
		public enum Shape
		{
			/// <summary>enum member</summary>
			// Token: 0x04001098 RID: 4248
			Edge = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001099 RID: 4249
			Hexahedron = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400109A RID: 4250
			None = 8,
			/// <summary>enum member</summary>
			// Token: 0x0400109B RID: 4251
			Pyramid = 7,
			/// <summary>enum member</summary>
			// Token: 0x0400109C RID: 4252
			Quadrilateral = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400109D RID: 4253
			Tetrahedron,
			/// <summary>enum member</summary>
			// Token: 0x0400109E RID: 4254
			Triangle = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400109F RID: 4255
			Vertex = 0,
			/// <summary>enum member</summary>
			// Token: 0x040010A0 RID: 4256
			Wedge = 6
		}
	}
}
