using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPicker
	/// </summary>
	/// <remarks>
	///    superclass for 3D geometric pickers (uses ray cast)
	///
	/// vtkPicker is used to select instances of vtkProp3D by shooting a ray
	/// into a graphics window and intersecting with the actor's bounding box.
	/// The ray is defined from a point defined in window (or pixel) coordinates,
	/// and a point located from the camera's position.
	///
	/// vtkPicker may return more than one vtkProp3D, since more than one bounding
	/// box may be intersected. vtkPicker returns an unsorted list of props that
	/// were hit, and a list of the corresponding world points of the hits.
	/// For the vtkProp3D that is closest to the camera, vtkPicker returns the
	/// pick coordinates in world and untransformed mapper space, the prop itself,
	/// the data set, and the mapper.  For vtkPicker the closest prop is the one
	/// whose center point (i.e., center of bounding box) projected on the view
	/// ray is closest to the camera.  Subclasses of vtkPicker use other methods
	/// for computing the pick point.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPicker is used for quick geometric picking. If you desire more precise
	/// picking of points or cells based on the geometry of any vtkProp3D, use the
	/// subclasses vtkPointPicker or vtkCellPicker.  For hardware-accelerated
	/// picking of any type of vtkProp, use vtkPropPicker or vtkWorldPointPicker.
	/// </seealso>
	// Token: 0x02000368 RID: 872
	public class vtkPicker : vtkAbstractPropPicker
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009EB5 RID: 40629 RVA: 0x000E0E97 File Offset: 0x000DF097
		static vtkPicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009EB6 RID: 40630 RVA: 0x000E0EBF File Offset: 0x000DF0BF
		public vtkPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009EB7 RID: 40631
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009EB8 RID: 40632 RVA: 0x000E0ED0 File Offset: 0x000DF0D0
		public new static vtkPicker New()
		{
			vtkPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPicker.vtkPicker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009EB9 RID: 40633 RVA: 0x000E0F24 File Offset: 0x000DF124
		public vtkPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPicker.vtkPicker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009EBA RID: 40634 RVA: 0x000E0F68 File Offset: 0x000DF168
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009EBB RID: 40635
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPicker_GetActors_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a collection of all the actors that were intersected.
		/// This collection is not sorted. (This is a convenience method
		/// to maintain backward compatibility.)
		/// </summary>
		// Token: 0x06009EBC RID: 40636 RVA: 0x000E0F74 File Offset: 0x000DF174
		public vtkActorCollection GetActors()
		{
			vtkActorCollection vtkActorCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPicker.vtkPicker_GetActors_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActorCollection = (vtkActorCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActorCollection.Register(null);
				}
			}
			return vtkActorCollection;
		}

		// Token: 0x06009EBD RID: 40637
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPicker_GetCompositeDataSet_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the composite dataset that was picked (if any). If nothing
		/// was picked or a non-composite data object was picked then NULL is returned.
		/// </summary>
		// Token: 0x06009EBE RID: 40638 RVA: 0x000E0FE4 File Offset: 0x000DF1E4
		public virtual vtkCompositeDataSet GetCompositeDataSet()
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPicker.vtkPicker_GetCompositeDataSet_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x06009EBF RID: 40639
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPicker_GetDataSet_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the dataset that was picked (if any). If nothing
		/// was picked then NULL is returned.
		/// </summary>
		// Token: 0x06009EC0 RID: 40640 RVA: 0x000E1054 File Offset: 0x000DF254
		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPicker.vtkPicker_GetDataSet_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06009EC1 RID: 40641
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPicker_GetFlatBlockIndex_04(HandleRef pThis);

		/// <summary>
		/// Get the flat block index of the vtkDataSet in the composite dataset
		/// that was picked (if any). If nothing
		/// was picked or a non-composite data object was picked then -1 is returned.
		/// </summary>
		// Token: 0x06009EC2 RID: 40642 RVA: 0x000E10C4 File Offset: 0x000DF2C4
		public virtual long GetFlatBlockIndex()
		{
			return vtkPicker.vtkPicker_GetFlatBlockIndex_04(base.GetCppThis());
		}

		// Token: 0x06009EC3 RID: 40643
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPicker_GetMapper_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return mapper that was picked (if any).
		/// </summary>
		// Token: 0x06009EC4 RID: 40644 RVA: 0x000E10E4 File Offset: 0x000DF2E4
		public virtual vtkAbstractMapper3D GetMapper()
		{
			vtkAbstractMapper3D vtkAbstractMapper3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPicker.vtkPicker_GetMapper_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractMapper3D = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractMapper3D.Register(null);
				}
			}
			return vtkAbstractMapper3D;
		}

		// Token: 0x06009EC5 RID: 40645
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPicker_GetMapperPosition_06(HandleRef pThis);

		/// <summary>
		/// Return position in mapper (i.e., non-transformed) coordinates of
		/// pick point.
		/// </summary>
		// Token: 0x06009EC6 RID: 40646 RVA: 0x000E1154 File Offset: 0x000DF354
		public virtual double[] GetMapperPosition()
		{
			IntPtr intPtr = vtkPicker.vtkPicker_GetMapperPosition_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009EC7 RID: 40647
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPicker_GetMapperPosition_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Return position in mapper (i.e., non-transformed) coordinates of
		/// pick point.
		/// </summary>
		// Token: 0x06009EC8 RID: 40648 RVA: 0x000E119C File Offset: 0x000DF39C
		public virtual void GetMapperPosition(IntPtr data)
		{
			vtkPicker.vtkPicker_GetMapperPosition_07(base.GetCppThis(), data);
		}

		// Token: 0x06009EC9 RID: 40649
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPicker_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009ECA RID: 40650 RVA: 0x000E11AC File Offset: 0x000DF3AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPicker.vtkPicker_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06009ECB RID: 40651
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPicker_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009ECC RID: 40652 RVA: 0x000E11CC File Offset: 0x000DF3CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPicker.vtkPicker_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06009ECD RID: 40653
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPicker_GetPickedPositions_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a list of the points the actors returned by GetProp3Ds
		/// were intersected at. The order of this list will match the order of
		/// GetProp3Ds.
		/// </summary>
		// Token: 0x06009ECE RID: 40654 RVA: 0x000E11E8 File Offset: 0x000DF3E8
		public vtkPoints GetPickedPositions()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPicker.vtkPicker_GetPickedPositions_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009ECF RID: 40655
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPicker_GetProp3Ds_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a collection of all the prop 3D's that were intersected
		/// by the pick ray. This collection is not sorted.
		/// </summary>
		// Token: 0x06009ED0 RID: 40656 RVA: 0x000E1258 File Offset: 0x000DF458
		public vtkProp3DCollection GetProp3Ds()
		{
			vtkProp3DCollection vtkProp3DCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPicker.vtkPicker_GetProp3Ds_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3DCollection = (vtkProp3DCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3DCollection.Register(null);
				}
			}
			return vtkProp3DCollection;
		}

		// Token: 0x06009ED1 RID: 40657
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPicker_GetTolerance_12(HandleRef pThis);

		/// <summary>
		/// Specify tolerance for performing pick operation. Tolerance is specified
		/// as fraction of rendering window size. (Rendering window size is measured
		/// across diagonal.)
		/// </summary>
		// Token: 0x06009ED2 RID: 40658 RVA: 0x000E12C8 File Offset: 0x000DF4C8
		public virtual double GetTolerance()
		{
			return vtkPicker.vtkPicker_GetTolerance_12(base.GetCppThis());
		}

		// Token: 0x06009ED3 RID: 40659
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPicker_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009ED4 RID: 40660 RVA: 0x000E12E8 File Offset: 0x000DF4E8
		public override int IsA(string type)
		{
			return vtkPicker.vtkPicker_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06009ED5 RID: 40661
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPicker_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009ED6 RID: 40662 RVA: 0x000E1308 File Offset: 0x000DF508
		public new static int IsTypeOf(string type)
		{
			return vtkPicker.vtkPicker_IsTypeOf_14(type);
		}

		// Token: 0x06009ED7 RID: 40663
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPicker_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009ED8 RID: 40664 RVA: 0x000E1324 File Offset: 0x000DF524
		public new vtkPicker NewInstance()
		{
			vtkPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPicker.vtkPicker_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009ED9 RID: 40665
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPicker_Pick_17(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

		/// <summary>
		/// Perform pick operation with selection point provided. Normally the
		/// first two values for the selection point are x-y pixel coordinate, and
		/// the third value is =0. Return non-zero if something was successfully
		/// picked.
		/// </summary>
		// Token: 0x06009EDA RID: 40666 RVA: 0x000E1380 File Offset: 0x000DF580
		public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
		{
			return vtkPicker.vtkPicker_Pick_17(base.GetCppThis(), selectionX, selectionY, selectionZ, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x06009EDB RID: 40667
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPicker_Pick_18(HandleRef pThis, IntPtr selectionPt, HandleRef ren);

		/// <summary>
		/// Perform pick operation with selection point provided. Normally the first
		/// two values for the selection point are x-y pixel coordinate, and the
		/// third value is =0. Return non-zero if something was successfully picked.
		/// </summary>
		// Token: 0x06009EDC RID: 40668 RVA: 0x000E13BC File Offset: 0x000DF5BC
		public new int Pick(IntPtr selectionPt, vtkRenderer ren)
		{
			return vtkPicker.vtkPicker_Pick_18(base.GetCppThis(), selectionPt, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06009EDD RID: 40669
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPicker_Pick3DPoint_19(HandleRef pThis, IntPtr selectionPt, HandleRef ren);

		/// <summary>
		/// Perform pick operation with selection point provided. The
		/// selectionPt is in world coordinates.
		/// Return non-zero if something was successfully picked.
		/// </summary>
		// Token: 0x06009EDE RID: 40670 RVA: 0x000E13F4 File Offset: 0x000DF5F4
		public override int Pick3DPoint(IntPtr selectionPt, vtkRenderer ren)
		{
			return vtkPicker.vtkPicker_Pick3DPoint_19(base.GetCppThis(), selectionPt, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06009EDF RID: 40671
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPicker_Pick3DPoint_20(HandleRef pThis, IntPtr p1World, IntPtr p2World, HandleRef ren);

		/// <summary>
		/// Perform pick operation with selection point provided. The
		/// selectionPt is in world coordinates.
		/// Return non-zero if something was successfully picked.
		/// </summary>
		// Token: 0x06009EE0 RID: 40672 RVA: 0x000E142C File Offset: 0x000DF62C
		public virtual int Pick3DPoint(IntPtr p1World, IntPtr p2World, vtkRenderer ren)
		{
			return vtkPicker.vtkPicker_Pick3DPoint_20(base.GetCppThis(), p1World, p2World, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06009EE1 RID: 40673
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPicker_Pick3DRay_21(HandleRef pThis, IntPtr selectionPt, IntPtr orient, HandleRef ren);

		/// <summary>
		/// Perform pick operation with selection point and orientation provided.
		/// The selectionPt is in world coordinates.
		/// Return non-zero if something was successfully picked.
		/// </summary>
		// Token: 0x06009EE2 RID: 40674 RVA: 0x000E1464 File Offset: 0x000DF664
		public override int Pick3DRay(IntPtr selectionPt, IntPtr orient, vtkRenderer ren)
		{
			return vtkPicker.vtkPicker_Pick3DRay_21(base.GetCppThis(), selectionPt, orient, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06009EE3 RID: 40675
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPicker_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009EE4 RID: 40676 RVA: 0x000E149C File Offset: 0x000DF69C
		public new static vtkPicker SafeDownCast(vtkObjectBase o)
		{
			vtkPicker vtkPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPicker.vtkPicker_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPicker = (vtkPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPicker.Register(null);
				}
			}
			return vtkPicker;
		}

		// Token: 0x06009EE5 RID: 40677
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPicker_SetTolerance_23(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify tolerance for performing pick operation. Tolerance is specified
		/// as fraction of rendering window size. (Rendering window size is measured
		/// across diagonal.)
		/// </summary>
		// Token: 0x06009EE6 RID: 40678 RVA: 0x000E151B File Offset: 0x000DF71B
		public virtual void SetTolerance(double _arg)
		{
			vtkPicker.vtkPicker_SetTolerance_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CD1 RID: 3281
		public new const string MRFullTypeName = "Kitware.VTK.vtkPicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CD2 RID: 3282
		public new static readonly string MRClassNameKey = "class vtkPicker";
	}
}
