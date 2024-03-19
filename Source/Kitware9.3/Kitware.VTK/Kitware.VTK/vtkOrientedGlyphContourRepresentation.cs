using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOrientedGlyphContourRepresentation
	/// </summary>
	/// <remarks>
	///    Default representation for the contour widget
	///
	/// This class provides the default concrete representation for the
	/// vtkContourWidget. It works in conjunction with the
	/// vtkContourLineInterpolator and vtkPointPlacer. See vtkContourWidget
	/// for details.
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourRepresentation vtkContourWidget vtkPointPlacer
	/// vtkContourLineInterpolator
	/// </seealso>
	// Token: 0x02000346 RID: 838
	public class vtkOrientedGlyphContourRepresentation : vtkContourRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009847 RID: 38983 RVA: 0x000D78E7 File Offset: 0x000D5AE7
		static vtkOrientedGlyphContourRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrientedGlyphContourRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientedGlyphContourRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009848 RID: 38984 RVA: 0x000D790F File Offset: 0x000D5B0F
		public vtkOrientedGlyphContourRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009849 RID: 38985
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600984A RID: 38986 RVA: 0x000D7920 File Offset: 0x000D5B20
		public new static vtkOrientedGlyphContourRepresentation New()
		{
			vtkOrientedGlyphContourRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientedGlyphContourRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600984B RID: 38987 RVA: 0x000D7974 File Offset: 0x000D5B74
		public vtkOrientedGlyphContourRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600984C RID: 38988 RVA: 0x000D79B8 File Offset: 0x000D5BB8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600984D RID: 38989
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_AlwaysOnTopOff_01(HandleRef pThis);

		/// <summary>
		/// Controls whether the contour widget should always appear on top
		/// of other actors in the scene. (In effect, this will disable OpenGL
		/// Depth buffer tests while rendering the contour).
		/// Default is to set it to false.
		/// </summary>
		// Token: 0x0600984E RID: 38990 RVA: 0x000D79C3 File Offset: 0x000D5BC3
		public virtual void AlwaysOnTopOff()
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_AlwaysOnTopOff_01(base.GetCppThis());
		}

		// Token: 0x0600984F RID: 38991
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_AlwaysOnTopOn_02(HandleRef pThis);

		/// <summary>
		/// Controls whether the contour widget should always appear on top
		/// of other actors in the scene. (In effect, this will disable OpenGL
		/// Depth buffer tests while rendering the contour).
		/// Default is to set it to false.
		/// </summary>
		// Token: 0x06009850 RID: 38992 RVA: 0x000D79D2 File Offset: 0x000D5BD2
		public virtual void AlwaysOnTopOn()
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_AlwaysOnTopOn_02(base.GetCppThis());
		}

		// Token: 0x06009851 RID: 38993
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_BuildRepresentation_03(HandleRef pThis);

		/// <summary>
		/// Subclasses of vtkOrientedGlyphContourRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x06009852 RID: 38994 RVA: 0x000D79E1 File Offset: 0x000D5BE1
		public override void BuildRepresentation()
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_BuildRepresentation_03(base.GetCppThis());
		}

		// Token: 0x06009853 RID: 38995
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphContourRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modified);

		/// <summary>
		/// Subclasses of vtkOrientedGlyphContourRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x06009854 RID: 38996 RVA: 0x000D79F0 File Offset: 0x000D5BF0
		public override int ComputeInteractionState(int X, int Y, int modified)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_ComputeInteractionState_04(base.GetCppThis(), X, Y, modified);
		}

		// Token: 0x06009855 RID: 38997
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetActiveCursorShape_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the shape of the cursor (handle) when it is active.
		/// This is the geometry that will be used when the mouse is
		/// close to the handle or if the user is manipulating the handle.
		/// </summary>
		// Token: 0x06009856 RID: 38998 RVA: 0x000D7A14 File Offset: 0x000D5C14
		public vtkPolyData GetActiveCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetActiveCursorShape_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06009857 RID: 38999
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetActiveProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is the property used when the user is interacting
		/// with the handle.
		/// </summary>
		// Token: 0x06009858 RID: 39000 RVA: 0x000D7A84 File Offset: 0x000D5C84
		public virtual vtkProperty GetActiveProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetActiveProperty_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009859 RID: 39001
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_GetActors_07(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600985A RID: 39002 RVA: 0x000D7AF4 File Offset: 0x000D5CF4
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetActors_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600985B RID: 39003
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphContourRepresentation_GetAlwaysOnTop_08(HandleRef pThis);

		/// <summary>
		/// Controls whether the contour widget should always appear on top
		/// of other actors in the scene. (In effect, this will disable OpenGL
		/// Depth buffer tests while rendering the contour).
		/// Default is to set it to false.
		/// </summary>
		// Token: 0x0600985C RID: 39004 RVA: 0x000D7B24 File Offset: 0x000D5D24
		public virtual int GetAlwaysOnTop()
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetAlwaysOnTop_08(base.GetCppThis());
		}

		// Token: 0x0600985D RID: 39005
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetBounds_09(HandleRef pThis);

		/// <summary>
		/// Return the bounds of the representation
		/// </summary>
		// Token: 0x0600985E RID: 39006 RVA: 0x000D7B44 File Offset: 0x000D5D44
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetBounds_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600985F RID: 39007
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetContourRepresentationAsPolyData_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the points in this contour as a vtkPolyData.
		/// </summary>
		// Token: 0x06009860 RID: 39008 RVA: 0x000D7B8C File Offset: 0x000D5D8C
		public override vtkPolyData GetContourRepresentationAsPolyData()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetContourRepresentationAsPolyData_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06009861 RID: 39009
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetCursorShape_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the cursor shape. Keep in mind that the shape will be
		/// aligned with the constraining plane by orienting it such that
		/// the x axis of the geometry lies along the normal of the plane.
		/// </summary>
		// Token: 0x06009862 RID: 39010 RVA: 0x000D7BFC File Offset: 0x000D5DFC
		public vtkPolyData GetCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetCursorShape_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06009863 RID: 39011
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetLinesProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is the property used by the lines.
		/// </summary>
		// Token: 0x06009864 RID: 39012 RVA: 0x000D7C6C File Offset: 0x000D5E6C
		public virtual vtkProperty GetLinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetLinesProperty_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009865 RID: 39013
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrientedGlyphContourRepresentation_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009866 RID: 39014 RVA: 0x000D7CDC File Offset: 0x000D5EDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06009867 RID: 39015
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrientedGlyphContourRepresentation_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009868 RID: 39016 RVA: 0x000D7CFC File Offset: 0x000D5EFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06009869 RID: 39017
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is the property used when the handle is not active
		/// (the mouse is not near the handle)
		/// </summary>
		// Token: 0x0600986A RID: 39018 RVA: 0x000D7D18 File Offset: 0x000D5F18
		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetProperty_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600986B RID: 39019
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphContourRepresentation_HasTranslucentPolygonalGeometry_16(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600986C RID: 39020 RVA: 0x000D7D88 File Offset: 0x000D5F88
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_HasTranslucentPolygonalGeometry_16(base.GetCppThis());
		}

		// Token: 0x0600986D RID: 39021
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphContourRepresentation_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600986E RID: 39022 RVA: 0x000D7DA8 File Offset: 0x000D5FA8
		public override int IsA(string type)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0600986F RID: 39023
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphContourRepresentation_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009870 RID: 39024 RVA: 0x000D7DC8 File Offset: 0x000D5FC8
		public new static int IsTypeOf(string type)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_IsTypeOf_18(type);
		}

		// Token: 0x06009871 RID: 39025
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009872 RID: 39026 RVA: 0x000D7DE4 File Offset: 0x000D5FE4
		public new vtkOrientedGlyphContourRepresentation NewInstance()
		{
			vtkOrientedGlyphContourRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientedGlyphContourRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009873 RID: 39027
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_ReleaseGraphicsResources_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009874 RID: 39028 RVA: 0x000D7E40 File Offset: 0x000D6040
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_ReleaseGraphicsResources_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009875 RID: 39029
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphContourRepresentation_RenderOpaqueGeometry_22(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009876 RID: 39030 RVA: 0x000D7E70 File Offset: 0x000D6070
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_RenderOpaqueGeometry_22(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009877 RID: 39031
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphContourRepresentation_RenderOverlay_23(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009878 RID: 39032 RVA: 0x000D7EA4 File Offset: 0x000D60A4
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_RenderOverlay_23(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009879 RID: 39033
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphContourRepresentation_RenderTranslucentPolygonalGeometry_24(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600987A RID: 39034 RVA: 0x000D7ED8 File Offset: 0x000D60D8
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_RenderTranslucentPolygonalGeometry_24(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600987B RID: 39035
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600987C RID: 39036 RVA: 0x000D7F0C File Offset: 0x000D610C
		public new static vtkOrientedGlyphContourRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkOrientedGlyphContourRepresentation vtkOrientedGlyphContourRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrientedGlyphContourRepresentation = (vtkOrientedGlyphContourRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrientedGlyphContourRepresentation.Register(null);
				}
			}
			return vtkOrientedGlyphContourRepresentation;
		}

		// Token: 0x0600987D RID: 39037
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_SetActiveCursorShape_26(HandleRef pThis, HandleRef activeShape);

		/// <summary>
		/// Specify the shape of the cursor (handle) when it is active.
		/// This is the geometry that will be used when the mouse is
		/// close to the handle or if the user is manipulating the handle.
		/// </summary>
		// Token: 0x0600987E RID: 39038 RVA: 0x000D7F8C File Offset: 0x000D618C
		public void SetActiveCursorShape(vtkPolyData activeShape)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SetActiveCursorShape_26(base.GetCppThis(), (activeShape == null) ? default(HandleRef) : activeShape.GetCppThis());
		}

		// Token: 0x0600987F RID: 39039
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_SetAlwaysOnTop_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Controls whether the contour widget should always appear on top
		/// of other actors in the scene. (In effect, this will disable OpenGL
		/// Depth buffer tests while rendering the contour).
		/// Default is to set it to false.
		/// </summary>
		// Token: 0x06009880 RID: 39040 RVA: 0x000D7FBB File Offset: 0x000D61BB
		public virtual void SetAlwaysOnTop(int _arg)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SetAlwaysOnTop_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06009881 RID: 39041
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_SetCursorShape_28(HandleRef pThis, HandleRef cursorShape);

		/// <summary>
		/// Specify the cursor shape. Keep in mind that the shape will be
		/// aligned with the constraining plane by orienting it such that
		/// the x axis of the geometry lies along the normal of the plane.
		/// </summary>
		// Token: 0x06009882 RID: 39042 RVA: 0x000D7FCC File Offset: 0x000D61CC
		public void SetCursorShape(vtkPolyData cursorShape)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SetCursorShape_28(base.GetCppThis(), (cursorShape == null) ? default(HandleRef) : cursorShape.GetCppThis());
		}

		// Token: 0x06009883 RID: 39043
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_SetLineColor_29(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Convenience method to set the line color.
		/// Ideally one should use GetLinesProperty()-&gt;SetColor().
		/// </summary>
		// Token: 0x06009884 RID: 39044 RVA: 0x000D7FFB File Offset: 0x000D61FB
		public void SetLineColor(double r, double g, double b)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SetLineColor_29(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06009885 RID: 39045
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_SetRenderer_30(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Subclasses of vtkOrientedGlyphContourRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x06009886 RID: 39046 RVA: 0x000D8010 File Offset: 0x000D6210
		public override void SetRenderer(vtkRenderer ren)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SetRenderer_30(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06009887 RID: 39047
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_SetShowSelectedNodes_31(HandleRef pThis, int arg0);

		/// <summary>
		/// A flag to indicate whether to show the Selected nodes
		/// Default is to set it to false.
		/// </summary>
		// Token: 0x06009888 RID: 39048 RVA: 0x000D803F File Offset: 0x000D623F
		public override void SetShowSelectedNodes(int arg0)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SetShowSelectedNodes_31(base.GetCppThis(), arg0);
		}

		// Token: 0x06009889 RID: 39049
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_StartWidgetInteraction_32(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Subclasses of vtkOrientedGlyphContourRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x0600988A RID: 39050 RVA: 0x000D804F File Offset: 0x000D624F
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_StartWidgetInteraction_32(base.GetCppThis(), eventPos);
		}

		// Token: 0x0600988B RID: 39051
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphContourRepresentation_WidgetInteraction_33(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Subclasses of vtkOrientedGlyphContourRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x0600988C RID: 39052 RVA: 0x000D805F File Offset: 0x000D625F
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_WidgetInteraction_33(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C6E RID: 3182
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrientedGlyphContourRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C6F RID: 3183
		public new static readonly string MRClassNameKey = "class vtkOrientedGlyphContourRepresentation";
	}
}
