using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDistanceRepresentation2D
	/// </summary>
	/// <remarks>
	///    represent the vtkDistanceWidget
	///
	/// The vtkDistanceRepresentation2D is a representation for the
	/// vtkDistanceWidget. This representation consists of a measuring line (axis)
	/// and two vtkHandleWidgets to place the end points of the line. Note that
	/// this particular widget draws its representation in the overlay plane, and
	/// the handles also operate in the 2D overlay plane. (If you desire to use
	/// the distance widget for 3D measurements, use the
	/// vtkDistanceRepresentation3D.)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDistanceWidget vtkDistanceRepresentation vtkDistanceRepresentation3D
	/// </seealso>
	// Token: 0x0200030E RID: 782
	public class vtkDistanceRepresentation2D : vtkDistanceRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008CB2 RID: 36018 RVA: 0x000C88DB File Offset: 0x000C6ADB
		static vtkDistanceRepresentation2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistanceRepresentation2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceRepresentation2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008CB3 RID: 36019 RVA: 0x000C8903 File Offset: 0x000C6B03
		public vtkDistanceRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008CB4 RID: 36020
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06008CB5 RID: 36021 RVA: 0x000C8914 File Offset: 0x000C6B14
		public new static vtkDistanceRepresentation2D New()
		{
			vtkDistanceRepresentation2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06008CB6 RID: 36022 RVA: 0x000C8968 File Offset: 0x000C6B68
		public vtkDistanceRepresentation2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008CB7 RID: 36023 RVA: 0x000C89AC File Offset: 0x000C6BAC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008CB8 RID: 36024
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation2D_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x06008CB9 RID: 36025 RVA: 0x000C89B7 File Offset: 0x000C6BB7
		public override void BuildRepresentation()
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008CBA RID: 36026
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation2D_GetAxis_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the vtkAxisActor2D used to draw the measurement axis. With this
		/// properties can be set and so on. There is also a convenience method to
		/// get the axis property.
		/// </summary>
		// Token: 0x06008CBB RID: 36027 RVA: 0x000C89C8 File Offset: 0x000C6BC8
		public vtkAxisActor2D GetAxis()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetAxis_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		// Token: 0x06008CBC RID: 36028
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation2D_GetAxisProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the vtkAxisActor2D used to draw the measurement axis. With this
		/// properties can be set and so on. There is also a convenience method to
		/// get the axis property.
		/// </summary>
		// Token: 0x06008CBD RID: 36029 RVA: 0x000C8A38 File Offset: 0x000C6C38
		public vtkProperty2D GetAxisProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetAxisProperty_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x06008CBE RID: 36030
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDistanceRepresentation2D_GetDistance_04(HandleRef pThis);

		/// <summary>
		/// Satisfy the superclasses API.
		/// </summary>
		// Token: 0x06008CBF RID: 36031 RVA: 0x000C8AA8 File Offset: 0x000C6CA8
		public override double GetDistance()
		{
			return vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetDistance_04(base.GetCppThis());
		}

		// Token: 0x06008CC0 RID: 36032
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistanceRepresentation2D_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008CC1 RID: 36033 RVA: 0x000C8AC8 File Offset: 0x000C6CC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06008CC2 RID: 36034
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistanceRepresentation2D_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008CC3 RID: 36035 RVA: 0x000C8AE8 File Offset: 0x000C6CE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06008CC4 RID: 36036
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation2D_GetPoint1DisplayPosition_07(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008CC5 RID: 36037 RVA: 0x000C8B02 File Offset: 0x000C6D02
		public override void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetPoint1DisplayPosition_07(base.GetCppThis(), pos);
		}

		// Token: 0x06008CC6 RID: 36038
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation2D_GetPoint1WorldPosition_08(HandleRef pThis);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008CC7 RID: 36039 RVA: 0x000C8B14 File Offset: 0x000C6D14
		public override double[] GetPoint1WorldPosition()
		{
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetPoint1WorldPosition_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008CC8 RID: 36040
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation2D_GetPoint1WorldPosition_09(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008CC9 RID: 36041 RVA: 0x000C8B5C File Offset: 0x000C6D5C
		public override void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetPoint1WorldPosition_09(base.GetCppThis(), pos);
		}

		// Token: 0x06008CCA RID: 36042
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation2D_GetPoint2DisplayPosition_10(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008CCB RID: 36043 RVA: 0x000C8B6C File Offset: 0x000C6D6C
		public override void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetPoint2DisplayPosition_10(base.GetCppThis(), pos);
		}

		// Token: 0x06008CCC RID: 36044
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation2D_GetPoint2WorldPosition_11(HandleRef pThis);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008CCD RID: 36045 RVA: 0x000C8B7C File Offset: 0x000C6D7C
		public override double[] GetPoint2WorldPosition()
		{
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetPoint2WorldPosition_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008CCE RID: 36046
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation2D_GetPoint2WorldPosition_12(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008CCF RID: 36047 RVA: 0x000C8BC4 File Offset: 0x000C6DC4
		public override void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetPoint2WorldPosition_12(base.GetCppThis(), pos);
		}

		// Token: 0x06008CD0 RID: 36048
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation2D_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008CD1 RID: 36049 RVA: 0x000C8BD4 File Offset: 0x000C6DD4
		public override int IsA(string type)
		{
			return vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06008CD2 RID: 36050
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation2D_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008CD3 RID: 36051 RVA: 0x000C8BF4 File Offset: 0x000C6DF4
		public new static int IsTypeOf(string type)
		{
			return vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_IsTypeOf_14(type);
		}

		// Token: 0x06008CD4 RID: 36052
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation2D_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008CD5 RID: 36053 RVA: 0x000C8C10 File Offset: 0x000C6E10
		public new vtkDistanceRepresentation2D NewInstance()
		{
			vtkDistanceRepresentation2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008CD6 RID: 36054
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation2D_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06008CD7 RID: 36055 RVA: 0x000C8C6C File Offset: 0x000C6E6C
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_ReleaseGraphicsResources_17(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06008CD8 RID: 36056
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation2D_RenderOpaqueGeometry_18(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06008CD9 RID: 36057 RVA: 0x000C8C9C File Offset: 0x000C6E9C
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_RenderOpaqueGeometry_18(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06008CDA RID: 36058
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation2D_RenderOverlay_19(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06008CDB RID: 36059 RVA: 0x000C8CD0 File Offset: 0x000C6ED0
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_RenderOverlay_19(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06008CDC RID: 36060
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation2D_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008CDD RID: 36061 RVA: 0x000C8D04 File Offset: 0x000C6F04
		public new static vtkDistanceRepresentation2D SafeDownCast(vtkObjectBase o)
		{
			vtkDistanceRepresentation2D vtkDistanceRepresentation2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistanceRepresentation2D = (vtkDistanceRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistanceRepresentation2D.Register(null);
				}
			}
			return vtkDistanceRepresentation2D;
		}

		// Token: 0x06008CDE RID: 36062
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation2D_SetPoint1DisplayPosition_21(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008CDF RID: 36063 RVA: 0x000C8D83 File Offset: 0x000C6F83
		public override void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_SetPoint1DisplayPosition_21(base.GetCppThis(), pos);
		}

		// Token: 0x06008CE0 RID: 36064
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation2D_SetPoint1WorldPosition_22(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008CE1 RID: 36065 RVA: 0x000C8D93 File Offset: 0x000C6F93
		public override void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_SetPoint1WorldPosition_22(base.GetCppThis(), pos);
		}

		// Token: 0x06008CE2 RID: 36066
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation2D_SetPoint2DisplayPosition_23(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008CE3 RID: 36067 RVA: 0x000C8DA3 File Offset: 0x000C6FA3
		public override void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_SetPoint2DisplayPosition_23(base.GetCppThis(), pos);
		}

		// Token: 0x06008CE4 RID: 36068
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation2D_SetPoint2WorldPosition_24(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008CE5 RID: 36069 RVA: 0x000C8DB3 File Offset: 0x000C6FB3
		public override void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_SetPoint2WorldPosition_24(base.GetCppThis(), pos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BCA RID: 3018
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceRepresentation2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BCB RID: 3019
		public new static readonly string MRClassNameKey = "class vtkDistanceRepresentation2D";
	}
}
