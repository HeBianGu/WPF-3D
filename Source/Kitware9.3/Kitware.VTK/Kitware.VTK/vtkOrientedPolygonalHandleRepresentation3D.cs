using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOrientedPolygonalHandleRepresentation3D
	/// </summary>
	/// <remarks>
	///    represent a user defined handle geometry in 3D while maintaining a fixed orientation
	/// w.r.t the camera.
	///
	/// This class serves as the geometrical representation of a vtkHandleWidget.
	/// The handle can be represented by an arbitrary polygonal data (vtkPolyData),
	/// set via SetHandle(vtkPolyData *). The actual position of the handle
	/// will be initially assumed to be (0,0,0). You can specify an offset from
	/// this position if desired. This class differs from
	/// vtkPolygonalHandleRepresentation3D in that the handle will always remain
	/// front facing, ie it maintains a fixed orientation with respect to the
	/// camera. This is done by using vtkFollowers internally to render the actors.
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolygonalHandleRepresentation3D vtkHandleRepresentation vtkHandleWidget
	/// </seealso>
	// Token: 0x02000348 RID: 840
	public class vtkOrientedPolygonalHandleRepresentation3D : vtkAbstractPolygonalHandleRepresentation3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060098C7 RID: 39111 RVA: 0x000D87AF File Offset: 0x000D69AF
		static vtkOrientedPolygonalHandleRepresentation3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrientedPolygonalHandleRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientedPolygonalHandleRepresentation3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060098C8 RID: 39112 RVA: 0x000D87D7 File Offset: 0x000D69D7
		public vtkOrientedPolygonalHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060098C9 RID: 39113
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedPolygonalHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060098CA RID: 39114 RVA: 0x000D87E8 File Offset: 0x000D69E8
		public new static vtkOrientedPolygonalHandleRepresentation3D New()
		{
			vtkOrientedPolygonalHandleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientedPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060098CB RID: 39115 RVA: 0x000D883C File Offset: 0x000D6A3C
		public vtkOrientedPolygonalHandleRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060098CC RID: 39116 RVA: 0x000D8880 File Offset: 0x000D6A80
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060098CD RID: 39117
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrientedPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098CE RID: 39118 RVA: 0x000D888C File Offset: 0x000D6A8C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060098CF RID: 39119
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrientedPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098D0 RID: 39120 RVA: 0x000D88AC File Offset: 0x000D6AAC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060098D1 RID: 39121
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedPolygonalHandleRepresentation3D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098D2 RID: 39122 RVA: 0x000D88C8 File Offset: 0x000D6AC8
		public override int IsA(string type)
		{
			return vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060098D3 RID: 39123
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedPolygonalHandleRepresentation3D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098D4 RID: 39124 RVA: 0x000D88E8 File Offset: 0x000D6AE8
		public new static int IsTypeOf(string type)
		{
			return vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_IsTypeOf_04(type);
		}

		// Token: 0x060098D5 RID: 39125
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedPolygonalHandleRepresentation3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098D6 RID: 39126 RVA: 0x000D8904 File Offset: 0x000D6B04
		public new vtkOrientedPolygonalHandleRepresentation3D NewInstance()
		{
			vtkOrientedPolygonalHandleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientedPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060098D7 RID: 39127
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedPolygonalHandleRepresentation3D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098D8 RID: 39128 RVA: 0x000D8960 File Offset: 0x000D6B60
		public new static vtkOrientedPolygonalHandleRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkOrientedPolygonalHandleRepresentation3D vtkOrientedPolygonalHandleRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrientedPolygonalHandleRepresentation3D = (vtkOrientedPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrientedPolygonalHandleRepresentation3D.Register(null);
				}
			}
			return vtkOrientedPolygonalHandleRepresentation3D;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C72 RID: 3186
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrientedPolygonalHandleRepresentation3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C73 RID: 3187
		public new static readonly string MRClassNameKey = "class vtkOrientedPolygonalHandleRepresentation3D";
	}
}
