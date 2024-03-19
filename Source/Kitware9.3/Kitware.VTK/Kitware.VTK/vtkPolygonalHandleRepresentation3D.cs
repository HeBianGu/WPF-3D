using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolygonalHandleRepresentation3D
	/// </summary>
	/// <remarks>
	///    represent a user defined handle geometry in 3D space
	///
	/// This class serves as the geometrical representation of a vtkHandleWidget.
	/// The handle can be represented by an arbitrary polygonal data (vtkPolyData),
	/// set via SetHandle(vtkPolyData *). The actual position of the handle
	/// will be initially assumed to be (0,0,0). You can specify an offset from
	/// this position if desired.
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointHandleRepresentation3D vtkHandleRepresentation vtkHandleWidget
	/// </seealso>
	// Token: 0x0200031A RID: 794
	public class vtkPolygonalHandleRepresentation3D : vtkAbstractPolygonalHandleRepresentation3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008E85 RID: 36485 RVA: 0x000CB22B File Offset: 0x000C942B
		static vtkPolygonalHandleRepresentation3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolygonalHandleRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygonalHandleRepresentation3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008E86 RID: 36486 RVA: 0x000CB253 File Offset: 0x000C9453
		public vtkPolygonalHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008E87 RID: 36487
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygonalHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008E88 RID: 36488 RVA: 0x000CB264 File Offset: 0x000C9464
		public new static vtkPolygonalHandleRepresentation3D New()
		{
			vtkPolygonalHandleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008E89 RID: 36489 RVA: 0x000CB2B8 File Offset: 0x000C94B8
		public vtkPolygonalHandleRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008E8A RID: 36490 RVA: 0x000CB2FC File Offset: 0x000C94FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008E8B RID: 36491
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008E8C RID: 36492 RVA: 0x000CB308 File Offset: 0x000C9508
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06008E8D RID: 36493
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008E8E RID: 36494 RVA: 0x000CB328 File Offset: 0x000C9528
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06008E8F RID: 36495
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygonalHandleRepresentation3D_GetOffset_03(HandleRef pThis);

		/// <summary>
		/// Set/get the offset of the handle position with respect to the handle
		/// center, assumed to be the origin.
		/// </summary>
		// Token: 0x06008E90 RID: 36496 RVA: 0x000CB344 File Offset: 0x000C9544
		public virtual double[] GetOffset()
		{
			IntPtr intPtr = vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_GetOffset_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008E91 RID: 36497
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalHandleRepresentation3D_GetOffset_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/get the offset of the handle position with respect to the handle
		/// center, assumed to be the origin.
		/// </summary>
		// Token: 0x06008E92 RID: 36498 RVA: 0x000CB38C File Offset: 0x000C958C
		public virtual void GetOffset(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_GetOffset_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06008E93 RID: 36499
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalHandleRepresentation3D_GetOffset_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the offset of the handle position with respect to the handle
		/// center, assumed to be the origin.
		/// </summary>
		// Token: 0x06008E94 RID: 36500 RVA: 0x000CB39E File Offset: 0x000C959E
		public virtual void GetOffset(IntPtr _arg)
		{
			vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_GetOffset_05(base.GetCppThis(), _arg);
		}

		// Token: 0x06008E95 RID: 36501
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalHandleRepresentation3D_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008E96 RID: 36502 RVA: 0x000CB3B0 File Offset: 0x000C95B0
		public override int IsA(string type)
		{
			return vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06008E97 RID: 36503
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalHandleRepresentation3D_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008E98 RID: 36504 RVA: 0x000CB3D0 File Offset: 0x000C95D0
		public new static int IsTypeOf(string type)
		{
			return vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_IsTypeOf_07(type);
		}

		// Token: 0x06008E99 RID: 36505
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygonalHandleRepresentation3D_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008E9A RID: 36506 RVA: 0x000CB3EC File Offset: 0x000C95EC
		public new vtkPolygonalHandleRepresentation3D NewInstance()
		{
			vtkPolygonalHandleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008E9B RID: 36507
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygonalHandleRepresentation3D_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008E9C RID: 36508 RVA: 0x000CB448 File Offset: 0x000C9648
		public new static vtkPolygonalHandleRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkPolygonalHandleRepresentation3D vtkPolygonalHandleRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolygonalHandleRepresentation3D = (vtkPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolygonalHandleRepresentation3D.Register(null);
				}
			}
			return vtkPolygonalHandleRepresentation3D;
		}

		// Token: 0x06008E9D RID: 36509
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalHandleRepresentation3D_SetOffset_11(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/get the offset of the handle position with respect to the handle
		/// center, assumed to be the origin.
		/// </summary>
		// Token: 0x06008E9E RID: 36510 RVA: 0x000CB4C7 File Offset: 0x000C96C7
		public virtual void SetOffset(double _arg1, double _arg2, double _arg3)
		{
			vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_SetOffset_11(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06008E9F RID: 36511
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalHandleRepresentation3D_SetOffset_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the offset of the handle position with respect to the handle
		/// center, assumed to be the origin.
		/// </summary>
		// Token: 0x06008EA0 RID: 36512 RVA: 0x000CB4D9 File Offset: 0x000C96D9
		public virtual void SetOffset(IntPtr _arg)
		{
			vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_SetOffset_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06008EA1 RID: 36513
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalHandleRepresentation3D_SetWorldPosition_13(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set the position of the point in world and display coordinates.
		/// </summary>
		// Token: 0x06008EA2 RID: 36514 RVA: 0x000CB4E9 File Offset: 0x000C96E9
		public override void SetWorldPosition(IntPtr p)
		{
			vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_SetWorldPosition_13(base.GetCppThis(), p);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BEE RID: 3054
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolygonalHandleRepresentation3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BEF RID: 3055
		public new static readonly string MRClassNameKey = "class vtkPolygonalHandleRepresentation3D";
	}
}
