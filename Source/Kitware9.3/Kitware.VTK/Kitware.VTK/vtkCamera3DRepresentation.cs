using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCamera3DRepresentation
	/// </summary>
	/// <remarks>
	///    a class defining the representation for the vtkCamera3DWidget
	///
	/// This class is a concrete representation for the vtkCamera3DWidget.
	/// The camera is represented by a box and a cone. The first one allows
	/// camera movement, the second allows view angle update. There are three
	/// more handles to rotate the view up, and move the target position.
	/// It also has a frustum representation.
	///
	/// To use this representation, you can use the PlaceWidget() method
	/// to position the widget looking at a specified region in space. This
	/// is optional as you may want to not move the camera at setup.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCamera3DWidget
	/// </seealso>
	// Token: 0x020002DF RID: 735
	public class vtkCamera3DRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008440 RID: 33856 RVA: 0x000BCF13 File Offset: 0x000BB113
		static vtkCamera3DRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCamera3DRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCamera3DRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008441 RID: 33857 RVA: 0x000BCF3B File Offset: 0x000BB13B
		public vtkCamera3DRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008442 RID: 33858
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera3DRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008443 RID: 33859 RVA: 0x000BCF4C File Offset: 0x000BB14C
		public new static vtkCamera3DRepresentation New()
		{
			vtkCamera3DRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera3DRepresentation.vtkCamera3DRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCamera3DRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008444 RID: 33860 RVA: 0x000BCFA0 File Offset: 0x000BB1A0
		public vtkCamera3DRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCamera3DRepresentation.vtkCamera3DRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008445 RID: 33861 RVA: 0x000BCFE4 File Offset: 0x000BB1E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008446 RID: 33862
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008447 RID: 33863 RVA: 0x000BCFEF File Offset: 0x000BB1EF
		public override void BuildRepresentation()
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008448 RID: 33864
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera3DRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008449 RID: 33865 RVA: 0x000BD000 File Offset: 0x000BB200
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x0600844A RID: 33866
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_FrustumVisibilityOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to show camera frustum.
		/// Default: true.
		/// </summary>
		// Token: 0x0600844B RID: 33867 RVA: 0x000BD022 File Offset: 0x000BB222
		public virtual void FrustumVisibilityOff()
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_FrustumVisibilityOff_03(base.GetCppThis());
		}

		// Token: 0x0600844C RID: 33868
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_FrustumVisibilityOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to show camera frustum.
		/// Default: true.
		/// </summary>
		// Token: 0x0600844D RID: 33869 RVA: 0x000BD031 File Offset: 0x000BB231
		public virtual void FrustumVisibilityOn()
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_FrustumVisibilityOn_04(base.GetCppThis());
		}

		// Token: 0x0600844E RID: 33870
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_GetActors_05(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// GetActors adds all the internal props used by this representation to the supplied collection.
		/// </summary>
		// Token: 0x0600844F RID: 33871 RVA: 0x000BD040 File Offset: 0x000BB240
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetActors_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008450 RID: 33872
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera3DRepresentation_GetBounds_06(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008451 RID: 33873 RVA: 0x000BD070 File Offset: 0x000BB270
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008452 RID: 33874
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera3DRepresentation_GetCamera_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the camera.
		/// </summary>
		// Token: 0x06008453 RID: 33875 RVA: 0x000BD0B8 File Offset: 0x000BB2B8
		public vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetCamera_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x06008454 RID: 33876
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera3DRepresentation_GetFrontHandleDistance_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between camera position and the front handle.
		/// Note that the distance is scaled with view to keep the widget the same size.
		/// Default: 2.5.
		/// </summary>
		// Token: 0x06008455 RID: 33877 RVA: 0x000BD128 File Offset: 0x000BB328
		public virtual double GetFrontHandleDistance()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetFrontHandleDistance_08(base.GetCppThis());
		}

		// Token: 0x06008456 RID: 33878
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera3DRepresentation_GetFrontHandleDistanceMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between camera position and the front handle.
		/// Note that the distance is scaled with view to keep the widget the same size.
		/// Default: 2.5.
		/// </summary>
		// Token: 0x06008457 RID: 33879 RVA: 0x000BD148 File Offset: 0x000BB348
		public virtual double GetFrontHandleDistanceMaxValue()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetFrontHandleDistanceMaxValue_09(base.GetCppThis());
		}

		// Token: 0x06008458 RID: 33880
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera3DRepresentation_GetFrontHandleDistanceMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between camera position and the front handle.
		/// Note that the distance is scaled with view to keep the widget the same size.
		/// Default: 2.5.
		/// </summary>
		// Token: 0x06008459 RID: 33881 RVA: 0x000BD168 File Offset: 0x000BB368
		public virtual double GetFrontHandleDistanceMinValue()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetFrontHandleDistanceMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600845A RID: 33882
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCamera3DRepresentation_GetFrustumVisibility_11(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to show camera frustum.
		/// Default: true.
		/// </summary>
		// Token: 0x0600845B RID: 33883 RVA: 0x000BD188 File Offset: 0x000BB388
		public virtual bool GetFrustumVisibility()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetFrustumVisibility_11(base.GetCppThis()) != 0;
		}

		// Token: 0x0600845C RID: 33884
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCamera3DRepresentation_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600845D RID: 33885 RVA: 0x000BD1B0 File Offset: 0x000BB3B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0600845E RID: 33886
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCamera3DRepresentation_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600845F RID: 33887 RVA: 0x000BD1D0 File Offset: 0x000BB3D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06008460 RID: 33888
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCamera3DRepresentation_GetSecondaryHandlesVisibility_14(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to show secondary handles (spheres and lines).
		/// Default: true.
		/// </summary>
		// Token: 0x06008461 RID: 33889 RVA: 0x000BD1EC File Offset: 0x000BB3EC
		public virtual bool GetSecondaryHandlesVisibility()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetSecondaryHandlesVisibility_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06008462 RID: 33890
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCamera3DRepresentation_GetTranslatingAll_15(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to translate both position and target or not.
		/// Default: false.
		/// </summary>
		// Token: 0x06008463 RID: 33891 RVA: 0x000BD214 File Offset: 0x000BB414
		public virtual bool GetTranslatingAll()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetTranslatingAll_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06008464 RID: 33892
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera3DRepresentation_GetTranslationAxis_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the constraint axis for translations.
		/// Default: Axis::NONE (-1).
		/// </summary>
		// Token: 0x06008465 RID: 33893 RVA: 0x000BD23C File Offset: 0x000BB43C
		public virtual int GetTranslationAxis()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetTranslationAxis_16(base.GetCppThis());
		}

		// Token: 0x06008466 RID: 33894
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera3DRepresentation_GetTranslationAxisMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the constraint axis for translations.
		/// Default: Axis::NONE (-1).
		/// </summary>
		// Token: 0x06008467 RID: 33895 RVA: 0x000BD25C File Offset: 0x000BB45C
		public virtual int GetTranslationAxisMaxValue()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetTranslationAxisMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06008468 RID: 33896
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera3DRepresentation_GetTranslationAxisMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the constraint axis for translations.
		/// Default: Axis::NONE (-1).
		/// </summary>
		// Token: 0x06008469 RID: 33897 RVA: 0x000BD27C File Offset: 0x000BB47C
		public virtual int GetTranslationAxisMinValue()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetTranslationAxisMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600846A RID: 33898
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera3DRepresentation_GetUpHandleDistance_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between camera position and the up handle.
		/// Note that the distance is scaled with view to keep the widget the same size.
		/// Default: 1.5.
		/// </summary>
		// Token: 0x0600846B RID: 33899 RVA: 0x000BD29C File Offset: 0x000BB49C
		public virtual double GetUpHandleDistance()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetUpHandleDistance_19(base.GetCppThis());
		}

		// Token: 0x0600846C RID: 33900
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera3DRepresentation_GetUpHandleDistanceMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between camera position and the up handle.
		/// Note that the distance is scaled with view to keep the widget the same size.
		/// Default: 1.5.
		/// </summary>
		// Token: 0x0600846D RID: 33901 RVA: 0x000BD2BC File Offset: 0x000BB4BC
		public virtual double GetUpHandleDistanceMaxValue()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetUpHandleDistanceMaxValue_20(base.GetCppThis());
		}

		// Token: 0x0600846E RID: 33902
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera3DRepresentation_GetUpHandleDistanceMinValue_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between camera position and the up handle.
		/// Note that the distance is scaled with view to keep the widget the same size.
		/// Default: 1.5.
		/// </summary>
		// Token: 0x0600846F RID: 33903 RVA: 0x000BD2DC File Offset: 0x000BB4DC
		public virtual double GetUpHandleDistanceMinValue()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_GetUpHandleDistanceMinValue_21(base.GetCppThis());
		}

		// Token: 0x06008470 RID: 33904
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera3DRepresentation_HasTranslucentPolygonalGeometry_22(HandleRef pThis);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06008471 RID: 33905 RVA: 0x000BD2FC File Offset: 0x000BB4FC
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_HasTranslucentPolygonalGeometry_22(base.GetCppThis());
		}

		// Token: 0x06008472 RID: 33906
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera3DRepresentation_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008473 RID: 33907 RVA: 0x000BD31C File Offset: 0x000BB51C
		public override int IsA(string type)
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x06008474 RID: 33908
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera3DRepresentation_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008475 RID: 33909 RVA: 0x000BD33C File Offset: 0x000BB53C
		public new static int IsTypeOf(string type)
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_IsTypeOf_24(type);
		}

		// Token: 0x06008476 RID: 33910
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera3DRepresentation_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008477 RID: 33911 RVA: 0x000BD358 File Offset: 0x000BB558
		public new vtkCamera3DRepresentation NewInstance()
		{
			vtkCamera3DRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera3DRepresentation.vtkCamera3DRepresentation_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCamera3DRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008478 RID: 33912
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_PlaceWidget_27(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008479 RID: 33913 RVA: 0x000BD3B2 File Offset: 0x000BB5B2
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_PlaceWidget_27(base.GetCppThis(), bounds);
		}

		// Token: 0x0600847A RID: 33914
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_RegisterPickers_28(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkCamera3DWidget)
		/// or other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x0600847B RID: 33915 RVA: 0x000BD3C2 File Offset: 0x000BB5C2
		public override void RegisterPickers()
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_RegisterPickers_28(base.GetCppThis());
		}

		// Token: 0x0600847C RID: 33916
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_ReleaseGraphicsResources_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x0600847D RID: 33917 RVA: 0x000BD3D4 File Offset: 0x000BB5D4
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_ReleaseGraphicsResources_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600847E RID: 33918
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera3DRepresentation_RenderOpaqueGeometry_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x0600847F RID: 33919 RVA: 0x000BD404 File Offset: 0x000BB604
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_RenderOpaqueGeometry_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008480 RID: 33920
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera3DRepresentation_RenderTranslucentPolygonalGeometry_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06008481 RID: 33921 RVA: 0x000BD438 File Offset: 0x000BB638
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCamera3DRepresentation.vtkCamera3DRepresentation_RenderTranslucentPolygonalGeometry_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008482 RID: 33922
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera3DRepresentation_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008483 RID: 33923 RVA: 0x000BD46C File Offset: 0x000BB66C
		public new static vtkCamera3DRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCamera3DRepresentation vtkCamera3DRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera3DRepresentation.vtkCamera3DRepresentation_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera3DRepresentation = (vtkCamera3DRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera3DRepresentation.Register(null);
				}
			}
			return vtkCamera3DRepresentation;
		}

		// Token: 0x06008484 RID: 33924
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SecondaryHandlesVisibilityOff_33(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to show secondary handles (spheres and lines).
		/// Default: true.
		/// </summary>
		// Token: 0x06008485 RID: 33925 RVA: 0x000BD4EB File Offset: 0x000BB6EB
		public virtual void SecondaryHandlesVisibilityOff()
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SecondaryHandlesVisibilityOff_33(base.GetCppThis());
		}

		// Token: 0x06008486 RID: 33926
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SecondaryHandlesVisibilityOn_34(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to show secondary handles (spheres and lines).
		/// Default: true.
		/// </summary>
		// Token: 0x06008487 RID: 33927 RVA: 0x000BD4FA File Offset: 0x000BB6FA
		public virtual void SecondaryHandlesVisibilityOn()
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SecondaryHandlesVisibilityOn_34(base.GetCppThis());
		}

		// Token: 0x06008488 RID: 33928
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SetCamera_35(HandleRef pThis, HandleRef camera);

		/// <summary>
		/// Set/Get the camera.
		/// </summary>
		// Token: 0x06008489 RID: 33929 RVA: 0x000BD50C File Offset: 0x000BB70C
		public virtual void SetCamera(vtkCamera camera)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SetCamera_35(base.GetCppThis(), (camera == null) ? default(HandleRef) : camera.GetCppThis());
		}

		// Token: 0x0600848A RID: 33930
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SetFrontHandleDistance_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the distance between camera position and the front handle.
		/// Note that the distance is scaled with view to keep the widget the same size.
		/// Default: 2.5.
		/// </summary>
		// Token: 0x0600848B RID: 33931 RVA: 0x000BD53B File Offset: 0x000BB73B
		public virtual void SetFrontHandleDistance(double _arg)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SetFrontHandleDistance_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600848C RID: 33932
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SetFrustumVisibility_37(HandleRef pThis, byte visible);

		/// <summary>
		/// Set/Get whether to show camera frustum.
		/// Default: true.
		/// </summary>
		// Token: 0x0600848D RID: 33933 RVA: 0x000BD54B File Offset: 0x000BB74B
		public void SetFrustumVisibility(bool visible)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SetFrustumVisibility_37(base.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		// Token: 0x0600848E RID: 33934
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SetInteractionState_38(HandleRef pThis, int state);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkCamera3DWidget)
		/// or other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x0600848F RID: 33935 RVA: 0x000BD563 File Offset: 0x000BB763
		public void SetInteractionState(int state)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SetInteractionState_38(base.GetCppThis(), state);
		}

		// Token: 0x06008490 RID: 33936
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SetSecondaryHandlesVisibility_39(HandleRef pThis, byte visible);

		/// <summary>
		/// Set/Get whether to show secondary handles (spheres and lines).
		/// Default: true.
		/// </summary>
		// Token: 0x06008491 RID: 33937 RVA: 0x000BD573 File Offset: 0x000BB773
		public void SetSecondaryHandlesVisibility(bool visible)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SetSecondaryHandlesVisibility_39(base.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		// Token: 0x06008492 RID: 33938
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SetTranslatingAll_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether to translate both position and target or not.
		/// Default: false.
		/// </summary>
		// Token: 0x06008493 RID: 33939 RVA: 0x000BD58B File Offset: 0x000BB78B
		public virtual void SetTranslatingAll(bool _arg)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SetTranslatingAll_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06008494 RID: 33940
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SetTranslationAxis_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the constraint axis for translations.
		/// Default: Axis::NONE (-1).
		/// </summary>
		// Token: 0x06008495 RID: 33941 RVA: 0x000BD5A3 File Offset: 0x000BB7A3
		public virtual void SetTranslationAxis(int _arg)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SetTranslationAxis_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06008496 RID: 33942
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SetTranslationAxisToNone_42(HandleRef pThis);

		/// <summary>
		/// Set/Get the constraint axis for translations.
		/// Default: Axis::NONE (-1).
		/// </summary>
		// Token: 0x06008497 RID: 33943 RVA: 0x000BD5B3 File Offset: 0x000BB7B3
		public void SetTranslationAxisToNone()
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SetTranslationAxisToNone_42(base.GetCppThis());
		}

		// Token: 0x06008498 RID: 33944
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SetTranslationAxisToXAxis_43(HandleRef pThis);

		/// <summary>
		/// Set/Get the constraint axis for translations.
		/// Default: Axis::NONE (-1).
		/// </summary>
		// Token: 0x06008499 RID: 33945 RVA: 0x000BD5C2 File Offset: 0x000BB7C2
		public void SetTranslationAxisToXAxis()
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SetTranslationAxisToXAxis_43(base.GetCppThis());
		}

		// Token: 0x0600849A RID: 33946
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SetTranslationAxisToYAxis_44(HandleRef pThis);

		/// <summary>
		/// Set/Get the constraint axis for translations.
		/// Default: Axis::NONE (-1).
		/// </summary>
		// Token: 0x0600849B RID: 33947 RVA: 0x000BD5D1 File Offset: 0x000BB7D1
		public void SetTranslationAxisToYAxis()
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SetTranslationAxisToYAxis_44(base.GetCppThis());
		}

		// Token: 0x0600849C RID: 33948
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SetTranslationAxisToZAxis_45(HandleRef pThis);

		/// <summary>
		/// Set/Get the constraint axis for translations.
		/// Default: Axis::NONE (-1).
		/// </summary>
		// Token: 0x0600849D RID: 33949 RVA: 0x000BD5E0 File Offset: 0x000BB7E0
		public void SetTranslationAxisToZAxis()
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SetTranslationAxisToZAxis_45(base.GetCppThis());
		}

		// Token: 0x0600849E RID: 33950
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_SetUpHandleDistance_46(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the distance between camera position and the up handle.
		/// Note that the distance is scaled with view to keep the widget the same size.
		/// Default: 1.5.
		/// </summary>
		// Token: 0x0600849F RID: 33951 RVA: 0x000BD5EF File Offset: 0x000BB7EF
		public virtual void SetUpHandleDistance(double _arg)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_SetUpHandleDistance_46(base.GetCppThis(), _arg);
		}

		// Token: 0x060084A0 RID: 33952
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_StartWidgetInteraction_47(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060084A1 RID: 33953 RVA: 0x000BD5FF File Offset: 0x000BB7FF
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_StartWidgetInteraction_47(base.GetCppThis(), e);
		}

		// Token: 0x060084A2 RID: 33954
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_TranslatingAllOff_48(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to translate both position and target or not.
		/// Default: false.
		/// </summary>
		// Token: 0x060084A3 RID: 33955 RVA: 0x000BD60F File Offset: 0x000BB80F
		public virtual void TranslatingAllOff()
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_TranslatingAllOff_48(base.GetCppThis());
		}

		// Token: 0x060084A4 RID: 33956
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_TranslatingAllOn_49(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to translate both position and target or not.
		/// Default: false.
		/// </summary>
		// Token: 0x060084A5 RID: 33957 RVA: 0x000BD61E File Offset: 0x000BB81E
		public virtual void TranslatingAllOn()
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_TranslatingAllOn_49(base.GetCppThis());
		}

		// Token: 0x060084A6 RID: 33958
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DRepresentation_WidgetInteraction_50(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060084A7 RID: 33959 RVA: 0x000BD62D File Offset: 0x000BB82D
		public override void WidgetInteraction(IntPtr e)
		{
			vtkCamera3DRepresentation.vtkCamera3DRepresentation_WidgetInteraction_50(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B34 RID: 2868
		public new const string MRFullTypeName = "Kitware.VTK.vtkCamera3DRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B35 RID: 2869
		public new static readonly string MRClassNameKey = "class vtkCamera3DRepresentation";

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// GetActors adds all the internal props used by this representation to the supplied collection.
		/// </summary>
		// Token: 0x020002E0 RID: 736
		public enum Outside_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B37 RID: 2871
			Outside,
			/// <summary>enum member</summary>
			// Token: 0x04000B38 RID: 2872
			Scaling = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000B39 RID: 2873
			Translating = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000B3A RID: 2874
			TranslatingNearTarget = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000B3B RID: 2875
			TranslatingPosition = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000B3C RID: 2876
			TranslatingTarget = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000B3D RID: 2877
			TranslatingUp
		}
	}
}
