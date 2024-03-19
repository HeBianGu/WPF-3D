using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkScalarBarWidget
	/// </summary>
	/// <remarks>
	///    2D widget for manipulating a scalar bar
	///
	/// This class provides support for interactively manipulating the position,
	/// size, and orientation of a scalar bar. It listens to Left mouse events and
	/// mouse movement. It also listens to Right mouse events and notifies any
	/// observers of Right mouse events on this object when they occur.
	/// It will change the cursor shape based on its location. If
	/// the cursor is over an edge of the scalar bar it will change the cursor
	/// shape to a resize edge shape. If the position of a scalar bar is moved to
	/// be close to the center of one of the four edges of the viewport, then the
	/// scalar bar will change its orientation to align with that edge. This
	/// orientation is sticky in that it will stay that orientation until the
	/// position is moved close to another edge.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorObserver
	/// </seealso>
	// Token: 0x02000370 RID: 880
	public class vtkScalarBarWidget : vtkBorderWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009FB5 RID: 40885 RVA: 0x000E299B File Offset: 0x000E0B9B
		static vtkScalarBarWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarBarWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarBarWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009FB6 RID: 40886 RVA: 0x000E29C3 File Offset: 0x000E0BC3
		public vtkScalarBarWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009FB7 RID: 40887
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009FB8 RID: 40888 RVA: 0x000E29D4 File Offset: 0x000E0BD4
		public new static vtkScalarBarWidget New()
		{
			vtkScalarBarWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarWidget.vtkScalarBarWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009FB9 RID: 40889 RVA: 0x000E2A28 File Offset: 0x000E0C28
		public vtkScalarBarWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkScalarBarWidget.vtkScalarBarWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009FBA RID: 40890 RVA: 0x000E2A6C File Offset: 0x000E0C6C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009FBB RID: 40891
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06009FBC RID: 40892 RVA: 0x000E2A77 File Offset: 0x000E0C77
		public override void CreateDefaultRepresentation()
		{
			vtkScalarBarWidget.vtkScalarBarWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009FBD RID: 40893
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarBarWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009FBE RID: 40894 RVA: 0x000E2A88 File Offset: 0x000E0C88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkScalarBarWidget.vtkScalarBarWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06009FBF RID: 40895
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarBarWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009FC0 RID: 40896 RVA: 0x000E2AA8 File Offset: 0x000E0CA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkScalarBarWidget.vtkScalarBarWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06009FC1 RID: 40897
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarWidget_GetProcessEvents_04(HandleRef pThis);

		/// <summary>
		/// Reimplement ProcessEvents to use vtkAbstractWidget instead of vtkBorderWidget,
		/// for interaction with the scalar bar, even when the scalar bar's position is not AnyLocation.
		/// </summary>
		// Token: 0x06009FC2 RID: 40898 RVA: 0x000E2AC4 File Offset: 0x000E0CC4
		public override int GetProcessEvents()
		{
			return vtkScalarBarWidget.vtkScalarBarWidget_GetProcessEvents_04(base.GetCppThis());
		}

		// Token: 0x06009FC3 RID: 40899
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarWidget_GetRepositionable_05(HandleRef pThis);

		/// <summary>
		/// Can the widget be moved. On by default. If off, the widget cannot be moved
		/// around.
		///
		/// TODO: This functionality should probably be moved to the superclass.
		/// </summary>
		// Token: 0x06009FC4 RID: 40900 RVA: 0x000E2AE4 File Offset: 0x000E0CE4
		public virtual int GetRepositionable()
		{
			return vtkScalarBarWidget.vtkScalarBarWidget_GetRepositionable_05(base.GetCppThis());
		}

		// Token: 0x06009FC5 RID: 40901
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarWidget_GetScalarBarActor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the ScalarBar used by this Widget. One is created automatically.
		/// </summary>
		// Token: 0x06009FC6 RID: 40902 RVA: 0x000E2B04 File Offset: 0x000E0D04
		public virtual vtkScalarBarActor GetScalarBarActor()
		{
			vtkScalarBarActor vtkScalarBarActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarWidget.vtkScalarBarWidget_GetScalarBarActor_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarActor = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarActor.Register(null);
				}
			}
			return vtkScalarBarActor;
		}

		// Token: 0x06009FC7 RID: 40903
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarWidget_GetScalarBarRepresentation_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkScalarBarRepresentation.
		/// </summary>
		// Token: 0x06009FC8 RID: 40904 RVA: 0x000E2B74 File Offset: 0x000E0D74
		public vtkScalarBarRepresentation GetScalarBarRepresentation()
		{
			vtkScalarBarRepresentation vtkScalarBarRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarWidget.vtkScalarBarWidget_GetScalarBarRepresentation_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarRepresentation = (vtkScalarBarRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarRepresentation.Register(null);
				}
			}
			return vtkScalarBarRepresentation;
		}

		// Token: 0x06009FC9 RID: 40905
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarWidget_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009FCA RID: 40906 RVA: 0x000E2BE4 File Offset: 0x000E0DE4
		public override int IsA(string type)
		{
			return vtkScalarBarWidget.vtkScalarBarWidget_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06009FCB RID: 40907
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarWidget_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009FCC RID: 40908 RVA: 0x000E2C04 File Offset: 0x000E0E04
		public new static int IsTypeOf(string type)
		{
			return vtkScalarBarWidget.vtkScalarBarWidget_IsTypeOf_09(type);
		}

		// Token: 0x06009FCD RID: 40909
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarWidget_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009FCE RID: 40910 RVA: 0x000E2C20 File Offset: 0x000E0E20
		public new vtkScalarBarWidget NewInstance()
		{
			vtkScalarBarWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarWidget.vtkScalarBarWidget_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009FCF RID: 40911
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarWidget_RepositionableOff_12(HandleRef pThis);

		/// <summary>
		/// Can the widget be moved. On by default. If off, the widget cannot be moved
		/// around.
		///
		/// TODO: This functionality should probably be moved to the superclass.
		/// </summary>
		// Token: 0x06009FD0 RID: 40912 RVA: 0x000E2C7A File Offset: 0x000E0E7A
		public virtual void RepositionableOff()
		{
			vtkScalarBarWidget.vtkScalarBarWidget_RepositionableOff_12(base.GetCppThis());
		}

		// Token: 0x06009FD1 RID: 40913
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarWidget_RepositionableOn_13(HandleRef pThis);

		/// <summary>
		/// Can the widget be moved. On by default. If off, the widget cannot be moved
		/// around.
		///
		/// TODO: This functionality should probably be moved to the superclass.
		/// </summary>
		// Token: 0x06009FD2 RID: 40914 RVA: 0x000E2C89 File Offset: 0x000E0E89
		public virtual void RepositionableOn()
		{
			vtkScalarBarWidget.vtkScalarBarWidget_RepositionableOn_13(base.GetCppThis());
		}

		// Token: 0x06009FD3 RID: 40915
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarWidget_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009FD4 RID: 40916 RVA: 0x000E2C98 File Offset: 0x000E0E98
		public new static vtkScalarBarWidget SafeDownCast(vtkObjectBase o)
		{
			vtkScalarBarWidget vtkScalarBarWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarWidget.vtkScalarBarWidget_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarWidget = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarWidget.Register(null);
				}
			}
			return vtkScalarBarWidget;
		}

		// Token: 0x06009FD5 RID: 40917
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarWidget_SetRepositionable_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Can the widget be moved. On by default. If off, the widget cannot be moved
		/// around.
		///
		/// TODO: This functionality should probably be moved to the superclass.
		/// </summary>
		// Token: 0x06009FD6 RID: 40918 RVA: 0x000E2D17 File Offset: 0x000E0F17
		public virtual void SetRepositionable(int _arg)
		{
			vtkScalarBarWidget.vtkScalarBarWidget_SetRepositionable_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06009FD7 RID: 40919
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarWidget_SetRepresentation_16(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06009FD8 RID: 40920 RVA: 0x000E2D28 File Offset: 0x000E0F28
		public virtual void SetRepresentation(vtkScalarBarRepresentation rep)
		{
			vtkScalarBarWidget.vtkScalarBarWidget_SetRepresentation_16(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		// Token: 0x06009FD9 RID: 40921
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarWidget_SetScalarBarActor_17(HandleRef pThis, HandleRef actor);

		/// <summary>
		/// Get the ScalarBar used by this Widget. One is created automatically.
		/// </summary>
		// Token: 0x06009FDA RID: 40922 RVA: 0x000E2D58 File Offset: 0x000E0F58
		public virtual void SetScalarBarActor(vtkScalarBarActor actor)
		{
			vtkScalarBarWidget.vtkScalarBarWidget_SetScalarBarActor_17(base.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CE6 RID: 3302
		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarBarWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CE7 RID: 3303
		public new static readonly string MRClassNameKey = "class vtkScalarBarWidget";
	}
}
