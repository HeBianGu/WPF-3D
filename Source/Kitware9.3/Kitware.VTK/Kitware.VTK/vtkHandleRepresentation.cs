using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHandleRepresentation
	/// </summary>
	/// <remarks>
	///    abstract class for representing widget handles
	///
	/// This class defines an API for widget handle representations. These
	/// representations interact with vtkHandleWidget. Various representations
	/// can be used depending on the nature of the handle. The basic functionality
	/// of the handle representation is to maintain a position. The position is
	/// represented via a vtkCoordinate, meaning that the position can be easily
	/// obtained in a variety of coordinate systems.
	///
	/// Optional features for this representation include an active mode (the widget
	/// appears only when the mouse pointer is close to it). The active distance is
	/// expressed in pixels and represents a circle in display space.
	///
	/// The class may be subclassed so that alternative representations can
	/// be created.  The class defines an API and a default implementation that
	/// the vtkHandleWidget interacts with to render itself in the scene.
	///
	/// @warning
	/// The separation of the widget event handling and representation enables
	/// users and developers to create new appearances for the widget. It also
	/// facilitates parallel processing, where the client application handles
	/// events, and remote representations of the widget are slaves to the
	/// client (and do not handle events).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRectilinearWipeWidget vtkWidgetRepresentation vtkAbstractWidget
	/// </seealso>
	// Token: 0x020002AD RID: 685
	public abstract class vtkHandleRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007BA1 RID: 31649 RVA: 0x000B1F3F File Offset: 0x000B013F
		static vtkHandleRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHandleRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHandleRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007BA2 RID: 31650 RVA: 0x000B1F67 File Offset: 0x000B0167
		public vtkHandleRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007BA3 RID: 31651 RVA: 0x000B1F75 File Offset: 0x000B0175
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007BA4 RID: 31652
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_ActiveRepresentationOff_01(HandleRef pThis);

		/// <summary>
		/// Flag controls whether the widget becomes visible when the mouse pointer
		/// moves close to it (i.e., the widget becomes active). By default,
		/// ActiveRepresentation is off and the representation is always visible.
		/// </summary>
		// Token: 0x06007BA5 RID: 31653 RVA: 0x000B1F80 File Offset: 0x000B0180
		public virtual void ActiveRepresentationOff()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_ActiveRepresentationOff_01(base.GetCppThis());
		}

		// Token: 0x06007BA6 RID: 31654
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_ActiveRepresentationOn_02(HandleRef pThis);

		/// <summary>
		/// Flag controls whether the widget becomes visible when the mouse pointer
		/// moves close to it (i.e., the widget becomes active). By default,
		/// ActiveRepresentation is off and the representation is always visible.
		/// </summary>
		// Token: 0x06007BA7 RID: 31655 RVA: 0x000B1F8F File Offset: 0x000B018F
		public virtual void ActiveRepresentationOn()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_ActiveRepresentationOn_02(base.GetCppThis());
		}

		// Token: 0x06007BA8 RID: 31656
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_CheckConstraint_03(HandleRef pThis, HandleRef renderer, IntPtr pos);

		/// <summary>
		/// Method has to be overridden in the subclasses which has
		/// constraints on placing the handle
		/// (Ex. vtkConstrainedPointHandleRepresentation). It should return 1
		/// if the position is within the constraint, else it should return
		/// 0. By default it returns 1.
		/// </summary>
		// Token: 0x06007BA9 RID: 31657 RVA: 0x000B1FA0 File Offset: 0x000B01A0
		public virtual int CheckConstraint(vtkRenderer renderer, IntPtr pos)
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_CheckConstraint_03(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), pos);
		}

		// Token: 0x06007BAA RID: 31658
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_ConstrainedOff_04(HandleRef pThis);

		/// <summary>
		/// Specify whether any motions (such as scale, translate, etc.) are
		/// constrained in some way (along an axis, etc.) Widgets can use this
		/// to control the resulting motion.
		/// </summary>
		// Token: 0x06007BAB RID: 31659 RVA: 0x000B1FD5 File Offset: 0x000B01D5
		public virtual void ConstrainedOff()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_ConstrainedOff_04(base.GetCppThis());
		}

		// Token: 0x06007BAC RID: 31660
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_ConstrainedOn_05(HandleRef pThis);

		/// <summary>
		/// Specify whether any motions (such as scale, translate, etc.) are
		/// constrained in some way (along an axis, etc.) Widgets can use this
		/// to control the resulting motion.
		/// </summary>
		// Token: 0x06007BAD RID: 31661 RVA: 0x000B1FE4 File Offset: 0x000B01E4
		public virtual void ConstrainedOn()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_ConstrainedOn_05(base.GetCppThis());
		}

		// Token: 0x06007BAE RID: 31662
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_DeepCopy_06(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06007BAF RID: 31663 RVA: 0x000B1FF4 File Offset: 0x000B01F4
		public virtual void DeepCopy(vtkProp prop)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_DeepCopy_06(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06007BB0 RID: 31664
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_GetActiveRepresentation_07(HandleRef pThis);

		/// <summary>
		/// Flag controls whether the widget becomes visible when the mouse pointer
		/// moves close to it (i.e., the widget becomes active). By default,
		/// ActiveRepresentation is off and the representation is always visible.
		/// </summary>
		// Token: 0x06007BB1 RID: 31665 RVA: 0x000B2024 File Offset: 0x000B0224
		public virtual int GetActiveRepresentation()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetActiveRepresentation_07(base.GetCppThis());
		}

		// Token: 0x06007BB2 RID: 31666
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_GetConstrained_08(HandleRef pThis);

		/// <summary>
		/// Specify whether any motions (such as scale, translate, etc.) are
		/// constrained in some way (along an axis, etc.) Widgets can use this
		/// to control the resulting motion.
		/// </summary>
		// Token: 0x06007BB3 RID: 31667 RVA: 0x000B2044 File Offset: 0x000B0244
		public virtual int GetConstrained()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetConstrained_08(base.GetCppThis());
		}

		// Token: 0x06007BB4 RID: 31668
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleRepresentation_GetCustomTranslationAxis_09(HandleRef pThis);

		/// <summary>
		/// Get/Set the translation axis used when vtkHandleRepresentation::TranslationAxis
		/// is set to Axis::Custom.
		///
		/// @see SetCustomTranslationAxisOn
		/// </summary>
		// Token: 0x06007BB5 RID: 31669 RVA: 0x000B2064 File Offset: 0x000B0264
		public virtual double[] GetCustomTranslationAxis()
		{
			IntPtr intPtr = vtkHandleRepresentation.vtkHandleRepresentation_GetCustomTranslationAxis_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007BB6 RID: 31670
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_GetCustomTranslationAxis_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get/Set the translation axis used when vtkHandleRepresentation::TranslationAxis
		/// is set to Axis::Custom.
		///
		/// @see SetCustomTranslationAxisOn
		/// </summary>
		// Token: 0x06007BB7 RID: 31671 RVA: 0x000B20AC File Offset: 0x000B02AC
		public virtual void GetCustomTranslationAxis(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_GetCustomTranslationAxis_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06007BB8 RID: 31672
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_GetCustomTranslationAxis_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the translation axis used when vtkHandleRepresentation::TranslationAxis
		/// is set to Axis::Custom.
		///
		/// @see SetCustomTranslationAxisOn
		/// </summary>
		// Token: 0x06007BB9 RID: 31673 RVA: 0x000B20BE File Offset: 0x000B02BE
		public virtual void GetCustomTranslationAxis(IntPtr _arg)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_GetCustomTranslationAxis_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06007BBA RID: 31674
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_GetDisplayPosition_12(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Handles usually have their coordinates set in display coordinates
		/// (generally by an associated widget) and internally maintain the position
		/// in world coordinates. (Using world coordinates insures that handles are
		/// rendered in the right position when the camera view changes.) These
		/// methods are often subclassed because special constraint operations can
		/// be used to control the actual positioning.
		/// </summary>
		// Token: 0x06007BBB RID: 31675 RVA: 0x000B20CE File Offset: 0x000B02CE
		public virtual void GetDisplayPosition(IntPtr pos)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_GetDisplayPosition_12(base.GetCppThis(), pos);
		}

		// Token: 0x06007BBC RID: 31676
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleRepresentation_GetDisplayPosition_13(HandleRef pThis);

		/// <summary>
		/// Handles usually have their coordinates set in display coordinates
		/// (generally by an associated widget) and internally maintain the position
		/// in world coordinates. (Using world coordinates insures that handles are
		/// rendered in the right position when the camera view changes.) These
		/// methods are often subclassed because special constraint operations can
		/// be used to control the actual positioning.
		/// </summary>
		// Token: 0x06007BBD RID: 31677 RVA: 0x000B20E0 File Offset: 0x000B02E0
		public virtual double[] GetDisplayPosition()
		{
			IntPtr intPtr = vtkHandleRepresentation.vtkHandleRepresentation_GetDisplayPosition_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007BBE RID: 31678
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_GetInteractionStateMaxValue_14(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., HandleWidget) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// processwith the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x06007BBF RID: 31679 RVA: 0x000B2128 File Offset: 0x000B0328
		public virtual int GetInteractionStateMaxValue()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetInteractionStateMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06007BC0 RID: 31680
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_GetInteractionStateMinValue_15(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., HandleWidget) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// processwith the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x06007BC1 RID: 31681 RVA: 0x000B2148 File Offset: 0x000B0348
		public virtual int GetInteractionStateMinValue()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetInteractionStateMinValue_15(base.GetCppThis());
		}

		// Token: 0x06007BC2 RID: 31682
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkHandleRepresentation_GetMTime_16(HandleRef pThis);

		/// <summary>
		/// Overload the superclasses' GetMTime() because the internal vtkCoordinates
		/// are used to keep the state of the representation.
		/// </summary>
		// Token: 0x06007BC3 RID: 31683 RVA: 0x000B2168 File Offset: 0x000B0368
		public override ulong GetMTime()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetMTime_16(base.GetCppThis());
		}

		// Token: 0x06007BC4 RID: 31684
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHandleRepresentation_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007BC5 RID: 31685 RVA: 0x000B2188 File Offset: 0x000B0388
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x06007BC6 RID: 31686
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHandleRepresentation_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007BC7 RID: 31687 RVA: 0x000B21A8 File Offset: 0x000B03A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x06007BC8 RID: 31688
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleRepresentation_GetPointPlacer_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the point placer. Point placers can be used to dictate constraints
		/// on the placement of handles. As an example, see vtkBoundedPlanePointPlacer
		/// (constrains the placement of handles to a set of bounded planes)
		/// vtkFocalPlanePointPlacer (constrains placement on the focal plane) etc.
		/// The default point placer is vtkPointPlacer (which does not apply any
		/// constraints, so the handles are free to move anywhere).
		/// </summary>
		// Token: 0x06007BC9 RID: 31689 RVA: 0x000B21C4 File Offset: 0x000B03C4
		public virtual vtkPointPlacer GetPointPlacer()
		{
			vtkPointPlacer vtkPointPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHandleRepresentation.vtkHandleRepresentation_GetPointPlacer_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointPlacer = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointPlacer.Register(null);
				}
			}
			return vtkPointPlacer;
		}

		// Token: 0x06007BCA RID: 31690
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_GetTolerance_20(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered near enough to the widget to
		/// be active.
		/// </summary>
		// Token: 0x06007BCB RID: 31691 RVA: 0x000B2234 File Offset: 0x000B0434
		public virtual int GetTolerance()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetTolerance_20(base.GetCppThis());
		}

		// Token: 0x06007BCC RID: 31692
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_GetToleranceMaxValue_21(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered near enough to the widget to
		/// be active.
		/// </summary>
		// Token: 0x06007BCD RID: 31693 RVA: 0x000B2254 File Offset: 0x000B0454
		public virtual int GetToleranceMaxValue()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetToleranceMaxValue_21(base.GetCppThis());
		}

		// Token: 0x06007BCE RID: 31694
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_GetToleranceMinValue_22(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered near enough to the widget to
		/// be active.
		/// </summary>
		// Token: 0x06007BCF RID: 31695 RVA: 0x000B2274 File Offset: 0x000B0474
		public virtual int GetToleranceMinValue()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetToleranceMinValue_22(base.GetCppThis());
		}

		// Token: 0x06007BD0 RID: 31696
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_GetTranslationAxis_23(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x06007BD1 RID: 31697 RVA: 0x000B2294 File Offset: 0x000B0494
		public virtual int GetTranslationAxis()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetTranslationAxis_23(base.GetCppThis());
		}

		// Token: 0x06007BD2 RID: 31698
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_GetTranslationAxisMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x06007BD3 RID: 31699 RVA: 0x000B22B4 File Offset: 0x000B04B4
		public virtual int GetTranslationAxisMaxValue()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetTranslationAxisMaxValue_24(base.GetCppThis());
		}

		// Token: 0x06007BD4 RID: 31700
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_GetTranslationAxisMinValue_25(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x06007BD5 RID: 31701 RVA: 0x000B22D4 File Offset: 0x000B04D4
		public virtual int GetTranslationAxisMinValue()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetTranslationAxisMinValue_25(base.GetCppThis());
		}

		// Token: 0x06007BD6 RID: 31702
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_GetTranslationVector_26(HandleRef pThis, IntPtr p1, IntPtr p2, IntPtr v);

		/// <summary>
		/// Gets the translation vector
		/// </summary>
		// Token: 0x06007BD7 RID: 31703 RVA: 0x000B22F3 File Offset: 0x000B04F3
		public virtual void GetTranslationVector(IntPtr p1, IntPtr p2, IntPtr v)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_GetTranslationVector_26(base.GetCppThis(), p1, p2, v);
		}

		// Token: 0x06007BD8 RID: 31704
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_GetWorldPosition_27(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Handles usually have their coordinates set in display coordinates
		/// (generally by an associated widget) and internally maintain the position
		/// in world coordinates. (Using world coordinates insures that handles are
		/// rendered in the right position when the camera view changes.) These
		/// methods are often subclassed because special constraint operations can
		/// be used to control the actual positioning.
		/// </summary>
		// Token: 0x06007BD9 RID: 31705 RVA: 0x000B2305 File Offset: 0x000B0505
		public virtual void GetWorldPosition(IntPtr pos)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_GetWorldPosition_27(base.GetCppThis(), pos);
		}

		// Token: 0x06007BDA RID: 31706
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleRepresentation_GetWorldPosition_28(HandleRef pThis);

		/// <summary>
		/// Handles usually have their coordinates set in display coordinates
		/// (generally by an associated widget) and internally maintain the position
		/// in world coordinates. (Using world coordinates insures that handles are
		/// rendered in the right position when the camera view changes.) These
		/// methods are often subclassed because special constraint operations can
		/// be used to control the actual positioning.
		/// </summary>
		// Token: 0x06007BDB RID: 31707 RVA: 0x000B2318 File Offset: 0x000B0518
		public virtual double[] GetWorldPosition()
		{
			IntPtr intPtr = vtkHandleRepresentation.vtkHandleRepresentation_GetWorldPosition_28(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007BDC RID: 31708
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007BDD RID: 31709 RVA: 0x000B2360 File Offset: 0x000B0560
		public override int IsA(string type)
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x06007BDE RID: 31710
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHandleRepresentation_IsTranslationConstrained_30(HandleRef pThis);

		/// <summary>
		/// Returns true if ConstrainedAxis
		/// </summary>
		// Token: 0x06007BDF RID: 31711 RVA: 0x000B2380 File Offset: 0x000B0580
		public bool IsTranslationConstrained()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_IsTranslationConstrained_30(base.GetCppThis()) != 0;
		}

		// Token: 0x06007BE0 RID: 31712
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleRepresentation_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007BE1 RID: 31713 RVA: 0x000B23A8 File Offset: 0x000B05A8
		public new static int IsTypeOf(string type)
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_IsTypeOf_31(type);
		}

		// Token: 0x06007BE2 RID: 31714
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleRepresentation_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007BE3 RID: 31715 RVA: 0x000B23C4 File Offset: 0x000B05C4
		public new vtkHandleRepresentation NewInstance()
		{
			vtkHandleRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHandleRepresentation.vtkHandleRepresentation_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007BE4 RID: 31716
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleRepresentation_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007BE5 RID: 31717 RVA: 0x000B2420 File Offset: 0x000B0620
		public new static vtkHandleRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHandleRepresentation.vtkHandleRepresentation_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		// Token: 0x06007BE6 RID: 31718
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetActiveRepresentation_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Flag controls whether the widget becomes visible when the mouse pointer
		/// moves close to it (i.e., the widget becomes active). By default,
		/// ActiveRepresentation is off and the representation is always visible.
		/// </summary>
		// Token: 0x06007BE7 RID: 31719 RVA: 0x000B249F File Offset: 0x000B069F
		public virtual void SetActiveRepresentation(int _arg)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetActiveRepresentation_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06007BE8 RID: 31720
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetConstrained_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether any motions (such as scale, translate, etc.) are
		/// constrained in some way (along an axis, etc.) Widgets can use this
		/// to control the resulting motion.
		/// </summary>
		// Token: 0x06007BE9 RID: 31721 RVA: 0x000B24AF File Offset: 0x000B06AF
		public virtual void SetConstrained(int _arg)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetConstrained_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06007BEA RID: 31722
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetCustomTranslationAxis_36(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Get/Set the translation axis used when vtkHandleRepresentation::TranslationAxis
		/// is set to Axis::Custom.
		///
		/// @see SetCustomTranslationAxisOn
		/// </summary>
		// Token: 0x06007BEB RID: 31723 RVA: 0x000B24BF File Offset: 0x000B06BF
		public virtual void SetCustomTranslationAxis(double _arg1, double _arg2, double _arg3)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetCustomTranslationAxis_36(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06007BEC RID: 31724
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetCustomTranslationAxis_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the translation axis used when vtkHandleRepresentation::TranslationAxis
		/// is set to Axis::Custom.
		///
		/// @see SetCustomTranslationAxisOn
		/// </summary>
		// Token: 0x06007BED RID: 31725 RVA: 0x000B24D1 File Offset: 0x000B06D1
		public virtual void SetCustomTranslationAxis(IntPtr _arg)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetCustomTranslationAxis_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06007BEE RID: 31726
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetCustomTranslationAxisOn_38(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06007BEF RID: 31727 RVA: 0x000B24E1 File Offset: 0x000B06E1
		public void SetCustomTranslationAxisOn()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetCustomTranslationAxisOn_38(base.GetCppThis());
		}

		// Token: 0x06007BF0 RID: 31728
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetDisplayPosition_39(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Handles usually have their coordinates set in display coordinates
		/// (generally by an associated widget) and internally maintain the position
		/// in world coordinates. (Using world coordinates insures that handles are
		/// rendered in the right position when the camera view changes.) These
		/// methods are often subclassed because special constraint operations can
		/// be used to control the actual positioning.
		/// </summary>
		// Token: 0x06007BF1 RID: 31729 RVA: 0x000B24F0 File Offset: 0x000B06F0
		public virtual void SetDisplayPosition(IntPtr pos)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetDisplayPosition_39(base.GetCppThis(), pos);
		}

		// Token: 0x06007BF2 RID: 31730
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetInteractionState_40(HandleRef pThis, int _arg);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., HandleWidget) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// processwith the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x06007BF3 RID: 31731 RVA: 0x000B2500 File Offset: 0x000B0700
		public virtual void SetInteractionState(int _arg)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetInteractionState_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06007BF4 RID: 31732
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetPointPlacer_41(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the point placer. Point placers can be used to dictate constraints
		/// on the placement of handles. As an example, see vtkBoundedPlanePointPlacer
		/// (constrains the placement of handles to a set of bounded planes)
		/// vtkFocalPlanePointPlacer (constrains placement on the focal plane) etc.
		/// The default point placer is vtkPointPlacer (which does not apply any
		/// constraints, so the handles are free to move anywhere).
		/// </summary>
		// Token: 0x06007BF5 RID: 31733 RVA: 0x000B2510 File Offset: 0x000B0710
		public virtual void SetPointPlacer(vtkPointPlacer arg0)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetPointPlacer_41(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007BF6 RID: 31734
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetRenderer_42(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06007BF7 RID: 31735 RVA: 0x000B2540 File Offset: 0x000B0740
		public override void SetRenderer(vtkRenderer ren)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetRenderer_42(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06007BF8 RID: 31736
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetTolerance_43(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered near enough to the widget to
		/// be active.
		/// </summary>
		// Token: 0x06007BF9 RID: 31737 RVA: 0x000B256F File Offset: 0x000B076F
		public virtual void SetTolerance(int _arg)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetTolerance_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06007BFA RID: 31738
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetTranslationAxis_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x06007BFB RID: 31739 RVA: 0x000B257F File Offset: 0x000B077F
		public virtual void SetTranslationAxis(int _arg)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetTranslationAxis_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06007BFC RID: 31740
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetTranslationAxisOff_45(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06007BFD RID: 31741 RVA: 0x000B258F File Offset: 0x000B078F
		public void SetTranslationAxisOff()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetTranslationAxisOff_45(base.GetCppThis());
		}

		// Token: 0x06007BFE RID: 31742
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetWorldPosition_46(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Handles usually have their coordinates set in display coordinates
		/// (generally by an associated widget) and internally maintain the position
		/// in world coordinates. (Using world coordinates insures that handles are
		/// rendered in the right position when the camera view changes.) These
		/// methods are often subclassed because special constraint operations can
		/// be used to control the actual positioning.
		/// </summary>
		// Token: 0x06007BFF RID: 31743 RVA: 0x000B259E File Offset: 0x000B079E
		public virtual void SetWorldPosition(IntPtr pos)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetWorldPosition_46(base.GetCppThis(), pos);
		}

		// Token: 0x06007C00 RID: 31744
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetXTranslationAxisOn_47(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06007C01 RID: 31745 RVA: 0x000B25AE File Offset: 0x000B07AE
		public void SetXTranslationAxisOn()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetXTranslationAxisOn_47(base.GetCppThis());
		}

		// Token: 0x06007C02 RID: 31746
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetYTranslationAxisOn_48(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06007C03 RID: 31747 RVA: 0x000B25BD File Offset: 0x000B07BD
		public void SetYTranslationAxisOn()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetYTranslationAxisOn_48(base.GetCppThis());
		}

		// Token: 0x06007C04 RID: 31748
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_SetZTranslationAxisOn_49(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06007C05 RID: 31749 RVA: 0x000B25CC File Offset: 0x000B07CC
		public void SetZTranslationAxisOn()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetZTranslationAxisOn_49(base.GetCppThis());
		}

		// Token: 0x06007C06 RID: 31750
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_ShallowCopy_50(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06007C07 RID: 31751 RVA: 0x000B25DC File Offset: 0x000B07DC
		public override void ShallowCopy(vtkProp prop)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_ShallowCopy_50(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06007C08 RID: 31752
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_Translate_51(HandleRef pThis, IntPtr p1, IntPtr p2);

		/// <summary>
		/// Translates world position by vector p1p2 projected on the constraint axis if any.
		/// </summary>
		// Token: 0x06007C09 RID: 31753 RVA: 0x000B260B File Offset: 0x000B080B
		public virtual void Translate(IntPtr p1, IntPtr p2)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_Translate_51(base.GetCppThis(), p1, p2);
		}

		// Token: 0x06007C0A RID: 31754
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleRepresentation_Translate_52(HandleRef pThis, IntPtr v);

		/// <summary>
		/// Translates world position by vector v projected on the constraint axis if any.
		/// </summary>
		// Token: 0x06007C0B RID: 31755 RVA: 0x000B261C File Offset: 0x000B081C
		public virtual void Translate(IntPtr v)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_Translate_52(base.GetCppThis(), v);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A6C RID: 2668
		public new const string MRFullTypeName = "Kitware.VTK.vtkHandleRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A6D RID: 2669
		public new static readonly string MRClassNameKey = "class vtkHandleRepresentation";

		/// <summary>
		/// Flag controls whether the widget becomes visible when the mouse pointer
		/// moves close to it (i.e., the widget becomes active). By default,
		/// ActiveRepresentation is off and the representation is always visible.
		/// </summary>
		// Token: 0x020002AE RID: 686
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000A6F RID: 2671
			Nearby = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000A70 RID: 2672
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000A71 RID: 2673
			Scaling = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000A72 RID: 2674
			Selecting = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000A73 RID: 2675
			Translating
		}
	}
}
