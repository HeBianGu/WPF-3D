using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSphereHandleRepresentation
	/// </summary>
	/// <remarks>
	///    A spherical rendition of point in 3D space
	///
	///
	/// This class is a concrete implementation of vtkHandleRepresentation. It
	/// renders handles as spherical blobs in 3D space.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHandleRepresentation vtkHandleWidget vtkSphereSource
	/// </seealso>
	// Token: 0x02000378 RID: 888
	public class vtkSphereHandleRepresentation : vtkHandleRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A0F9 RID: 41209 RVA: 0x000E49B7 File Offset: 0x000E2BB7
		static vtkSphereHandleRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphereHandleRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereHandleRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A0FA RID: 41210 RVA: 0x000E49DF File Offset: 0x000E2BDF
		public vtkSphereHandleRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A0FB RID: 41211
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereHandleRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600A0FC RID: 41212 RVA: 0x000E49F0 File Offset: 0x000E2BF0
		public new static vtkSphereHandleRepresentation New()
		{
			vtkSphereHandleRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600A0FD RID: 41213 RVA: 0x000E4A44 File Offset: 0x000E2C44
		public vtkSphereHandleRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A0FE RID: 41214 RVA: 0x000E4A88 File Offset: 0x000E2C88
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A0FF RID: 41215
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x0600A100 RID: 41216 RVA: 0x000E4A93 File Offset: 0x000E2C93
		public override void BuildRepresentation()
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A101 RID: 41217
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereHandleRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x0600A102 RID: 41218 RVA: 0x000E4AA4 File Offset: 0x000E2CA4
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x0600A103 RID: 41219
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_DeepCopy_03(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600A104 RID: 41220 RVA: 0x000E4AC8 File Offset: 0x000E2CC8
		public override void DeepCopy(vtkProp prop)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_DeepCopy_03(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600A105 RID: 41221
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_GetActors_04(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600A106 RID: 41222 RVA: 0x000E4AF8 File Offset: 0x000E2CF8
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetActors_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A107 RID: 41223
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereHandleRepresentation_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x0600A108 RID: 41224 RVA: 0x000E4B28 File Offset: 0x000E2D28
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A109 RID: 41225
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereHandleRepresentation_GetHotSpotSize_06(HandleRef pThis);

		/// <summary>
		/// Set the "hot spot" size; i.e., the region around the focus, in which the
		/// motion vector is used to control the constrained sliding action. Note the
		/// size is specified as a fraction of the length of the diagonal of the
		/// point widget's bounding box.
		/// </summary>
		// Token: 0x0600A10A RID: 41226 RVA: 0x000E4B70 File Offset: 0x000E2D70
		public virtual double GetHotSpotSize()
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetHotSpotSize_06(base.GetCppThis());
		}

		// Token: 0x0600A10B RID: 41227
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereHandleRepresentation_GetHotSpotSizeMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Set the "hot spot" size; i.e., the region around the focus, in which the
		/// motion vector is used to control the constrained sliding action. Note the
		/// size is specified as a fraction of the length of the diagonal of the
		/// point widget's bounding box.
		/// </summary>
		// Token: 0x0600A10C RID: 41228 RVA: 0x000E4B90 File Offset: 0x000E2D90
		public virtual double GetHotSpotSizeMaxValue()
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetHotSpotSizeMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0600A10D RID: 41229
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereHandleRepresentation_GetHotSpotSizeMinValue_08(HandleRef pThis);

		/// <summary>
		/// Set the "hot spot" size; i.e., the region around the focus, in which the
		/// motion vector is used to control the constrained sliding action. Note the
		/// size is specified as a fraction of the length of the diagonal of the
		/// point widget's bounding box.
		/// </summary>
		// Token: 0x0600A10E RID: 41230 RVA: 0x000E4BB0 File Offset: 0x000E2DB0
		public virtual double GetHotSpotSizeMinValue()
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetHotSpotSizeMinValue_08(base.GetCppThis());
		}

		// Token: 0x0600A10F RID: 41231
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereHandleRepresentation_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A110 RID: 41232 RVA: 0x000E4BD0 File Offset: 0x000E2DD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0600A111 RID: 41233
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereHandleRepresentation_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A112 RID: 41234 RVA: 0x000E4BF0 File Offset: 0x000E2DF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0600A113 RID: 41235
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereHandleRepresentation_GetProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x0600A114 RID: 41236 RVA: 0x000E4C0C File Offset: 0x000E2E0C
		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetProperty_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A115 RID: 41237
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereHandleRepresentation_GetSelectedProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x0600A116 RID: 41238 RVA: 0x000E4C7C File Offset: 0x000E2E7C
		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetSelectedProperty_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A117 RID: 41239
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereHandleRepresentation_GetSphereRadius_13(HandleRef pThis);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated simultaneously as the point moves
		/// (i.e., the left and middle mouse buttons act the same).  Otherwise, only
		/// the cursor focal point moves, which is constrained by the bounds of the
		/// point representation. (Note that the bounds can be scaled up using the
		/// right mouse button.)
		/// </summary>
		// Token: 0x0600A118 RID: 41240 RVA: 0x000E4CEC File Offset: 0x000E2EEC
		public double GetSphereRadius()
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetSphereRadius_13(base.GetCppThis());
		}

		// Token: 0x0600A119 RID: 41241
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereHandleRepresentation_GetTranslationMode_14(HandleRef pThis);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated simultaneously as the point moves
		/// (i.e., the left and middle mouse buttons act the same).  Otherwise, only
		/// the cursor focal point moves, which is constrained by the bounds of the
		/// point representation. (Note that the bounds can be scaled up using the
		/// right mouse button.)
		/// </summary>
		// Token: 0x0600A11A RID: 41242 RVA: 0x000E4D0C File Offset: 0x000E2F0C
		public virtual int GetTranslationMode()
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetTranslationMode_14(base.GetCppThis());
		}

		// Token: 0x0600A11B RID: 41243
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereHandleRepresentation_HasTranslucentPolygonalGeometry_15(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600A11C RID: 41244 RVA: 0x000E4D2C File Offset: 0x000E2F2C
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_HasTranslucentPolygonalGeometry_15(base.GetCppThis());
		}

		// Token: 0x0600A11D RID: 41245
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_Highlight_16(HandleRef pThis, int highlight);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600A11E RID: 41246 RVA: 0x000E4D4B File Offset: 0x000E2F4B
		public override void Highlight(int highlight)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_Highlight_16(base.GetCppThis(), highlight);
		}

		// Token: 0x0600A11F RID: 41247
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereHandleRepresentation_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A120 RID: 41248 RVA: 0x000E4D5C File Offset: 0x000E2F5C
		public override int IsA(string type)
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0600A121 RID: 41249
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereHandleRepresentation_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A122 RID: 41250 RVA: 0x000E4D7C File Offset: 0x000E2F7C
		public new static int IsTypeOf(string type)
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_IsTypeOf_18(type);
		}

		// Token: 0x0600A123 RID: 41251
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereHandleRepresentation_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A124 RID: 41252 RVA: 0x000E4D98 File Offset: 0x000E2F98
		public new vtkSphereHandleRepresentation NewInstance()
		{
			vtkSphereHandleRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A125 RID: 41253
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_PlaceWidget_21(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x0600A126 RID: 41254 RVA: 0x000E4DF2 File Offset: 0x000E2FF2
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_PlaceWidget_21(base.GetCppThis(), bounds);
		}

		// Token: 0x0600A127 RID: 41255
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_RegisterPickers_22(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600A128 RID: 41256 RVA: 0x000E4E02 File Offset: 0x000E3002
		public override void RegisterPickers()
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_RegisterPickers_22(base.GetCppThis());
		}

		// Token: 0x0600A129 RID: 41257
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_ReleaseGraphicsResources_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600A12A RID: 41258 RVA: 0x000E4E14 File Offset: 0x000E3014
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_ReleaseGraphicsResources_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A12B RID: 41259
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereHandleRepresentation_RenderOpaqueGeometry_24(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600A12C RID: 41260 RVA: 0x000E4E44 File Offset: 0x000E3044
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_RenderOpaqueGeometry_24(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600A12D RID: 41261
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereHandleRepresentation_RenderTranslucentPolygonalGeometry_25(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600A12E RID: 41262 RVA: 0x000E4E78 File Offset: 0x000E3078
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_RenderTranslucentPolygonalGeometry_25(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600A12F RID: 41263
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereHandleRepresentation_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A130 RID: 41264 RVA: 0x000E4EAC File Offset: 0x000E30AC
		public new static vtkSphereHandleRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkSphereHandleRepresentation vtkSphereHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereHandleRepresentation = (vtkSphereHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereHandleRepresentation.Register(null);
				}
			}
			return vtkSphereHandleRepresentation;
		}

		// Token: 0x0600A131 RID: 41265
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_SetDisplayPosition_27(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set the position of the point in world and display coordinates. Note
		/// that if the position is set outside of the bounding box, it will be
		/// clamped to the boundary of the bounding box. This method overloads
		/// the superclasses' SetWorldPosition() and SetDisplayPosition() in
		/// order to set the focal point of the cursor properly.
		/// </summary>
		// Token: 0x0600A132 RID: 41266 RVA: 0x000E4F2B File Offset: 0x000E312B
		public override void SetDisplayPosition(IntPtr p)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetDisplayPosition_27(base.GetCppThis(), p);
		}

		// Token: 0x0600A133 RID: 41267
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_SetHandleSize_28(HandleRef pThis, double size);

		/// <summary>
		/// Overload the superclasses SetHandleSize() method to update internal
		/// variables.
		/// </summary>
		// Token: 0x0600A134 RID: 41268 RVA: 0x000E4F3B File Offset: 0x000E313B
		public override void SetHandleSize(double size)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetHandleSize_28(base.GetCppThis(), size);
		}

		// Token: 0x0600A135 RID: 41269
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_SetHotSpotSize_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the "hot spot" size; i.e., the region around the focus, in which the
		/// motion vector is used to control the constrained sliding action. Note the
		/// size is specified as a fraction of the length of the diagonal of the
		/// point widget's bounding box.
		/// </summary>
		// Token: 0x0600A136 RID: 41270 RVA: 0x000E4F4B File Offset: 0x000E314B
		public virtual void SetHotSpotSize(double _arg)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetHotSpotSize_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A137 RID: 41271
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_SetProperty_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x0600A138 RID: 41272 RVA: 0x000E4F5C File Offset: 0x000E315C
		public void SetProperty(vtkProperty arg0)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetProperty_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A139 RID: 41273
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_SetSelectedProperty_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x0600A13A RID: 41274 RVA: 0x000E4F8C File Offset: 0x000E318C
		public void SetSelectedProperty(vtkProperty arg0)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetSelectedProperty_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A13B RID: 41275
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_SetSphereRadius_32(HandleRef pThis, double arg0);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated simultaneously as the point moves
		/// (i.e., the left and middle mouse buttons act the same).  Otherwise, only
		/// the cursor focal point moves, which is constrained by the bounds of the
		/// point representation. (Note that the bounds can be scaled up using the
		/// right mouse button.)
		/// </summary>
		// Token: 0x0600A13C RID: 41276 RVA: 0x000E4FBB File Offset: 0x000E31BB
		public void SetSphereRadius(double arg0)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetSphereRadius_32(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A13D RID: 41277
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_SetTranslationMode_33(HandleRef pThis, int _arg);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated simultaneously as the point moves
		/// (i.e., the left and middle mouse buttons act the same).  Otherwise, only
		/// the cursor focal point moves, which is constrained by the bounds of the
		/// point representation. (Note that the bounds can be scaled up using the
		/// right mouse button.)
		/// </summary>
		// Token: 0x0600A13E RID: 41278 RVA: 0x000E4FCB File Offset: 0x000E31CB
		public virtual void SetTranslationMode(int _arg)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetTranslationMode_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A13F RID: 41279
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_SetVisibility_34(HandleRef pThis, int visible);

		/// <summary>
		/// Override to ensure that the internal actor's visibility is consistent with
		/// this representation's visibility. Inconsistency between the two would cause
		/// issues in picking logic which relies on individual view prop visibility to
		/// determine whether the prop is pickable.
		/// </summary>
		// Token: 0x0600A140 RID: 41280 RVA: 0x000E4FDB File Offset: 0x000E31DB
		public override void SetVisibility(int visible)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetVisibility_34(base.GetCppThis(), visible);
		}

		// Token: 0x0600A141 RID: 41281
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_SetWorldPosition_35(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set the position of the point in world and display coordinates. Note
		/// that if the position is set outside of the bounding box, it will be
		/// clamped to the boundary of the bounding box. This method overloads
		/// the superclasses' SetWorldPosition() and SetDisplayPosition() in
		/// order to set the focal point of the cursor properly.
		/// </summary>
		// Token: 0x0600A142 RID: 41282 RVA: 0x000E4FEB File Offset: 0x000E31EB
		public override void SetWorldPosition(IntPtr p)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetWorldPosition_35(base.GetCppThis(), p);
		}

		// Token: 0x0600A143 RID: 41283
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_ShallowCopy_36(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600A144 RID: 41284 RVA: 0x000E4FFC File Offset: 0x000E31FC
		public override void ShallowCopy(vtkProp prop)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_ShallowCopy_36(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600A145 RID: 41285
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_StartWidgetInteraction_37(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x0600A146 RID: 41286 RVA: 0x000E502B File Offset: 0x000E322B
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_StartWidgetInteraction_37(base.GetCppThis(), eventPos);
		}

		// Token: 0x0600A147 RID: 41287
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_TranslationModeOff_38(HandleRef pThis);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated simultaneously as the point moves
		/// (i.e., the left and middle mouse buttons act the same).  Otherwise, only
		/// the cursor focal point moves, which is constrained by the bounds of the
		/// point representation. (Note that the bounds can be scaled up using the
		/// right mouse button.)
		/// </summary>
		// Token: 0x0600A148 RID: 41288 RVA: 0x000E503B File Offset: 0x000E323B
		public virtual void TranslationModeOff()
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_TranslationModeOff_38(base.GetCppThis());
		}

		// Token: 0x0600A149 RID: 41289
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_TranslationModeOn_39(HandleRef pThis);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated simultaneously as the point moves
		/// (i.e., the left and middle mouse buttons act the same).  Otherwise, only
		/// the cursor focal point moves, which is constrained by the bounds of the
		/// point representation. (Note that the bounds can be scaled up using the
		/// right mouse button.)
		/// </summary>
		// Token: 0x0600A14A RID: 41290 RVA: 0x000E504A File Offset: 0x000E324A
		public virtual void TranslationModeOn()
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_TranslationModeOn_39(base.GetCppThis());
		}

		// Token: 0x0600A14B RID: 41291
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereHandleRepresentation_WidgetInteraction_40(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x0600A14C RID: 41292 RVA: 0x000E5059 File Offset: 0x000E3259
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_WidgetInteraction_40(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CFA RID: 3322
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphereHandleRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CFB RID: 3323
		public new static readonly string MRClassNameKey = "class vtkSphereHandleRepresentation";
	}
}
