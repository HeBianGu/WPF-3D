using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFocalPlaneContourRepresentation
	/// </summary>
	/// <remarks>
	///    represent a contour drawn on the
	/// focal plane.
	///
	///
	/// The contour will stay on the focal plane irrespective of camera
	/// position/orientation changes. The class was written in order to be able to
	/// draw contours on a volume widget and have the contours overlaid on the
	/// focal plane in order to do contour segmentation. The superclass,
	/// vtkContourRepresentation handles contours that are drawn in actual world
	/// position coordinates, so they would rotate with the camera position/
	/// orientation changes
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourWidget vtkHandleRepresentation vtkContourRepresentation
	/// </seealso>
	// Token: 0x0200031C RID: 796
	public abstract class vtkFocalPlaneContourRepresentation : vtkContourRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008EBF RID: 36543 RVA: 0x000CB7F7 File Offset: 0x000C99F7
		static vtkFocalPlaneContourRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFocalPlaneContourRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFocalPlaneContourRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008EC0 RID: 36544 RVA: 0x000CB81F File Offset: 0x000C9A1F
		public vtkFocalPlaneContourRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008EC1 RID: 36545 RVA: 0x000CB82D File Offset: 0x000C9A2D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008EC2 RID: 36546
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlaneContourRepresentation_GetIntermediatePointDisplayPosition_01(HandleRef pThis, int n, int idx, IntPtr point);

		/// <summary>
		/// Get the world position of the intermediate point at
		/// index idx between nodes n and (n+1) (or n and 0 if
		/// n is the last node and the loop is closed). Returns
		/// 1 on success or 0 if n or idx are out of range.
		/// </summary>
		// Token: 0x06008EC3 RID: 36547 RVA: 0x000CB838 File Offset: 0x000C9A38
		public virtual int GetIntermediatePointDisplayPosition(int n, int idx, IntPtr point)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_GetIntermediatePointDisplayPosition_01(base.GetCppThis(), n, idx, point);
		}

		// Token: 0x06008EC4 RID: 36548
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlaneContourRepresentation_GetIntermediatePointWorldPosition_02(HandleRef pThis, int n, int idx, IntPtr point);

		/// <summary>
		/// Get the world position of the intermediate point at
		/// index idx between nodes n and (n+1) (or n and 0 if
		/// n is the last node and the loop is closed). Returns
		/// 1 on success or 0 if n or idx are out of range.
		/// </summary>
		// Token: 0x06008EC5 RID: 36549 RVA: 0x000CB85C File Offset: 0x000C9A5C
		public override int GetIntermediatePointWorldPosition(int n, int idx, IntPtr point)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_GetIntermediatePointWorldPosition_02(base.GetCppThis(), n, idx, point);
		}

		// Token: 0x06008EC6 RID: 36550
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlaneContourRepresentation_GetNthNodeDisplayPosition_03(HandleRef pThis, int n, IntPtr pos);

		/// <summary>
		/// Get the nth node's display position. Will return
		/// 1 on success, or 0 if there are not at least
		/// (n+1) nodes (0 based counting).
		/// </summary>
		// Token: 0x06008EC7 RID: 36551 RVA: 0x000CB880 File Offset: 0x000C9A80
		public override int GetNthNodeDisplayPosition(int n, IntPtr pos)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_GetNthNodeDisplayPosition_03(base.GetCppThis(), n, pos);
		}

		// Token: 0x06008EC8 RID: 36552
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlaneContourRepresentation_GetNthNodeWorldPosition_04(HandleRef pThis, int n, IntPtr pos);

		/// <summary>
		/// Get the nth node's world position. Will return
		/// 1 on success, or 0 if there are not at least
		/// (n+1) nodes (0 based counting).
		/// </summary>
		// Token: 0x06008EC9 RID: 36553 RVA: 0x000CB8A4 File Offset: 0x000C9AA4
		public override int GetNthNodeWorldPosition(int n, IntPtr pos)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_GetNthNodeWorldPosition_04(base.GetCppThis(), n, pos);
		}

		// Token: 0x06008ECA RID: 36554
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008ECB RID: 36555 RVA: 0x000CB8C8 File Offset: 0x000C9AC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06008ECC RID: 36556
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008ECD RID: 36557 RVA: 0x000CB8E8 File Offset: 0x000C9AE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06008ECE RID: 36558
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlaneContourRepresentation_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008ECF RID: 36559 RVA: 0x000CB904 File Offset: 0x000C9B04
		public override int IsA(string type)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06008ED0 RID: 36560
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlaneContourRepresentation_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008ED1 RID: 36561 RVA: 0x000CB924 File Offset: 0x000C9B24
		public new static int IsTypeOf(string type)
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_IsTypeOf_08(type);
		}

		// Token: 0x06008ED2 RID: 36562
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFocalPlaneContourRepresentation_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008ED3 RID: 36563 RVA: 0x000CB940 File Offset: 0x000C9B40
		public new vtkFocalPlaneContourRepresentation NewInstance()
		{
			vtkFocalPlaneContourRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008ED4 RID: 36564
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFocalPlaneContourRepresentation_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008ED5 RID: 36565 RVA: 0x000CB99C File Offset: 0x000C9B9C
		public new static vtkFocalPlaneContourRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkFocalPlaneContourRepresentation vtkFocalPlaneContourRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFocalPlaneContourRepresentation = (vtkFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFocalPlaneContourRepresentation.Register(null);
				}
			}
			return vtkFocalPlaneContourRepresentation;
		}

		// Token: 0x06008ED6 RID: 36566
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlaneContourRepresentation_UpdateContour_11(HandleRef pThis);

		/// <summary>
		/// The method must be called whenever the contour needs to be updated, usually
		/// from RenderOpaqueGeometry()
		/// </summary>
		// Token: 0x06008ED7 RID: 36567 RVA: 0x000CBA1C File Offset: 0x000C9C1C
		public virtual int UpdateContour()
		{
			return vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_UpdateContour_11(base.GetCppThis());
		}

		// Token: 0x06008ED8 RID: 36568
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFocalPlaneContourRepresentation_UpdateContourWorldPositionsBasedOnDisplayPositions_12(HandleRef pThis);

		/// <summary>
		/// The class maintains its true contour locations based on display co-ords
		/// This method syncs the world co-ords data structure with the display co-ords.
		/// </summary>
		// Token: 0x06008ED9 RID: 36569 RVA: 0x000CBA3B File Offset: 0x000C9C3B
		public virtual void UpdateContourWorldPositionsBasedOnDisplayPositions()
		{
			vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_UpdateContourWorldPositionsBasedOnDisplayPositions_12(base.GetCppThis());
		}

		// Token: 0x06008EDA RID: 36570
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFocalPlaneContourRepresentation_UpdateLines_13(HandleRef pThis, int index);

		/// <summary>
		/// The method must be called whenever the contour needs to be updated, usually
		/// from RenderOpaqueGeometry()
		/// </summary>
		// Token: 0x06008EDB RID: 36571 RVA: 0x000CBA4A File Offset: 0x000C9C4A
		public virtual void UpdateLines(int index)
		{
			vtkFocalPlaneContourRepresentation.vtkFocalPlaneContourRepresentation_UpdateLines_13(base.GetCppThis(), index);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BF2 RID: 3058
		public new const string MRFullTypeName = "Kitware.VTK.vtkFocalPlaneContourRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BF3 RID: 3059
		public new static readonly string MRClassNameKey = "class vtkFocalPlaneContourRepresentation";
	}
}
