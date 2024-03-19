using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPickingManager
	/// Class defines API to manage the picking process.
	///
	/// The Picking Manager (PM) coordinates picking across widgets simultaneously.
	/// It maintains a collection of registered pickers;
	/// when the manager is picked (e.g. vtkPickingManager::Pick()),
	/// a pick is run on each picker but only the best picker
	/// (e.g. closest to camera point) is selected.
	/// It finally returns the widget/representation or picker that was
	/// selected.
	/// @warning
	/// Every time a vtkWidget and/or a vtkWidgetRepresentation is instantiated,
	/// it automatically registers its picker(s) and start being managed by
	/// delegating all its pick calls to the picking manager.
	/// It is possible to customize with the management in two ways:
	/// * at the widget level, the "ManagesPicking" variable can be changed
	/// from the widget/representation class to tell
	/// whether to use the manager or not.
	/// * Directly disable the picking manager itself with the boolean variable
	/// \sa Enabled using vtkPickingManager::EnabledOn(), EnabledOff(),
	/// SetEnabled(bool).
	/// @par Important:
	/// The picking manager is not active by default as it slightly reduces the
	/// performances when interacting with the scene.
	/// @par Important:
	/// When registering pickers, a null object is considered valid because we can
	/// managed picker without any associated object.
	/// It is really important to note that a null object is different from one
	/// to an other !!
	/// This has been done to allow adding multiple times the same picker to the manager
	/// by not passing the referenced object to not force the suppression of all pickers
	/// </summary>
	// Token: 0x02000812 RID: 2066
	public class vtkPickingManager : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015436 RID: 87094 RVA: 0x001E1BBF File Offset: 0x001DFDBF
		static vtkPickingManager()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPickingManager.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPickingManager"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015437 RID: 87095 RVA: 0x001E1BE7 File Offset: 0x001DFDE7
		public vtkPickingManager(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015438 RID: 87096
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPickingManager_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015439 RID: 87097 RVA: 0x001E1BF8 File Offset: 0x001DFDF8
		public new static vtkPickingManager New()
		{
			vtkPickingManager result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPickingManager.vtkPickingManager_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPickingManager)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601543A RID: 87098 RVA: 0x001E1C4C File Offset: 0x001DFE4C
		public vtkPickingManager() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPickingManager.vtkPickingManager_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601543B RID: 87099 RVA: 0x001E1C90 File Offset: 0x001DFE90
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601543C RID: 87100
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPickingManager_AddPicker_01(HandleRef pThis, HandleRef picker, HandleRef arg1);

		/// <summary>
		/// Register a picker into the picking manager.
		/// It can be internally associated (optional) with an \a object.
		/// This allows the removal of all the pickers of the given object.
		/// Note that a picker can be registered multiple times with different objects.
		/// \sa RemovePicker(), RemoveObject().
		/// </summary>
		// Token: 0x0601543D RID: 87101 RVA: 0x001E1C9C File Offset: 0x001DFE9C
		public void AddPicker(vtkAbstractPicker picker, vtkObject arg1)
		{
			vtkPickingManager.vtkPickingManager_AddPicker_01(base.GetCppThis(), (picker == null) ? default(HandleRef) : picker.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601543E RID: 87102
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPickingManager_EnabledOff_02(HandleRef pThis);

		/// <summary>
		/// Enable/Disable management.
		/// When disabled, it redirects every pick on the picker.
		/// By default the picking manager is disabled when initialized.
		/// </summary>
		// Token: 0x0601543F RID: 87103 RVA: 0x001E1CE0 File Offset: 0x001DFEE0
		public virtual void EnabledOff()
		{
			vtkPickingManager.vtkPickingManager_EnabledOff_02(base.GetCppThis());
		}

		// Token: 0x06015440 RID: 87104
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPickingManager_EnabledOn_03(HandleRef pThis);

		/// <summary>
		/// Enable/Disable management.
		/// When disabled, it redirects every pick on the picker.
		/// By default the picking manager is disabled when initialized.
		/// </summary>
		// Token: 0x06015441 RID: 87105 RVA: 0x001E1CEF File Offset: 0x001DFEEF
		public virtual void EnabledOn()
		{
			vtkPickingManager.vtkPickingManager_EnabledOn_03(base.GetCppThis());
		}

		// Token: 0x06015442 RID: 87106
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPickingManager_GetAssemblyPath_04(HandleRef pThis, double X, double Y, double Z, HandleRef picker, HandleRef renderer, HandleRef obj, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the picking manager is enabled, it runs the picking selection process
		/// and return the assembly path associated to the picker passed as
		/// argument if it is the one mediated.
		/// Otherwise it simply proceeds to a pick using the given renderer and
		/// returns the corresponding assembly path.
		/// </summary>
		// Token: 0x06015443 RID: 87107 RVA: 0x001E1D00 File Offset: 0x001DFF00
		public vtkAssemblyPath GetAssemblyPath(double X, double Y, double Z, vtkAbstractPropPicker picker, vtkRenderer renderer, vtkObject obj)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPickingManager.vtkPickingManager_GetAssemblyPath_04(base.GetCppThis(), X, Y, Z, (picker == null) ? default(HandleRef) : picker.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		// Token: 0x06015444 RID: 87108
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPickingManager_GetEnabled_05(HandleRef pThis);

		/// <summary>
		/// Enable/Disable management.
		/// When disabled, it redirects every pick on the picker.
		/// By default the picking manager is disabled when initialized.
		/// </summary>
		// Token: 0x06015445 RID: 87109 RVA: 0x001E1DBC File Offset: 0x001DFFBC
		public virtual bool GetEnabled()
		{
			return vtkPickingManager.vtkPickingManager_GetEnabled_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06015446 RID: 87110
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPickingManager_GetInteractor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the window interactor associated with the manager.
		/// </summary>
		// Token: 0x06015447 RID: 87111 RVA: 0x001E1DE4 File Offset: 0x001DFFE4
		public virtual vtkRenderWindowInteractor GetInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPickingManager.vtkPickingManager_GetInteractor_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		// Token: 0x06015448 RID: 87112
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPickingManager_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015449 RID: 87113 RVA: 0x001E1E54 File Offset: 0x001E0054
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPickingManager.vtkPickingManager_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601544A RID: 87114
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPickingManager_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601544B RID: 87115 RVA: 0x001E1E74 File Offset: 0x001E0074
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPickingManager.vtkPickingManager_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601544C RID: 87116
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPickingManager_GetNumberOfObjectsLinked_09(HandleRef pThis, HandleRef picker);

		/// <summary>
		/// Return the number of objects linked with a given \a picker.
		/// Note: a null object is counted as an associated object.
		/// </summary>
		// Token: 0x0601544D RID: 87117 RVA: 0x001E1E90 File Offset: 0x001E0090
		public int GetNumberOfObjectsLinked(vtkAbstractPicker picker)
		{
			return vtkPickingManager.vtkPickingManager_GetNumberOfObjectsLinked_09(base.GetCppThis(), (picker == null) ? default(HandleRef) : picker.GetCppThis());
		}

		// Token: 0x0601544E RID: 87118
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPickingManager_GetNumberOfPickers_10(HandleRef pThis);

		/// <summary>
		/// Return the number of pickers registered.
		/// If the same picker is added multiple times with different objects, it is
		/// counted once.
		/// </summary>
		// Token: 0x0601544F RID: 87119 RVA: 0x001E1EC4 File Offset: 0x001E00C4
		public int GetNumberOfPickers()
		{
			return vtkPickingManager.vtkPickingManager_GetNumberOfPickers_10(base.GetCppThis());
		}

		// Token: 0x06015450 RID: 87120
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPickingManager_GetOptimizeOnInteractorEvents_11(HandleRef pThis);

		/// <summary>
		/// Enable/Disable optimization depending on the renderWindowInteractor events.
		/// The mechanism keeps in cache the last selected picker as well as the last
		/// render time to recompute the selection only if a new render event
		/// occurred after the last selection; otherwise, it simply returns the last
		/// picker selected.
		/// By default pickingManagers does use the optimization.
		/// Warning: Turning off the caching significantly decreases performance.
		/// </summary>
		// Token: 0x06015451 RID: 87121 RVA: 0x001E1EE4 File Offset: 0x001E00E4
		public virtual bool GetOptimizeOnInteractorEvents()
		{
			return vtkPickingManager.vtkPickingManager_GetOptimizeOnInteractorEvents_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06015452 RID: 87122
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPickingManager_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015453 RID: 87123 RVA: 0x001E1F0C File Offset: 0x001E010C
		public override int IsA(string type)
		{
			return vtkPickingManager.vtkPickingManager_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06015454 RID: 87124
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPickingManager_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015455 RID: 87125 RVA: 0x001E1F2C File Offset: 0x001E012C
		public new static int IsTypeOf(string type)
		{
			return vtkPickingManager.vtkPickingManager_IsTypeOf_13(type);
		}

		// Token: 0x06015456 RID: 87126
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPickingManager_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015457 RID: 87127 RVA: 0x001E1F48 File Offset: 0x001E0148
		public new vtkPickingManager NewInstance()
		{
			vtkPickingManager result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPickingManager.vtkPickingManager_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPickingManager)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015458 RID: 87128
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPickingManager_Pick_16(HandleRef pThis, HandleRef picker, HandleRef arg1);

		/// <summary>
		/// Run the picking selection process and return true if the \a object
		/// is associated with the given picker if it is the best one, false otherwise.
		/// If OptimizeOnInteractorEvents is true, the pick can reuse cached
		/// information.
		/// </summary>
		// Token: 0x06015459 RID: 87129 RVA: 0x001E1FA4 File Offset: 0x001E01A4
		public bool Pick(vtkAbstractPicker picker, vtkObject arg1)
		{
			return vtkPickingManager.vtkPickingManager_Pick_16(base.GetCppThis(), (picker == null) ? default(HandleRef) : picker.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis()) != 0;
		}

		// Token: 0x0601545A RID: 87130
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPickingManager_Pick_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Run the picking selection process and return true if the \a object
		/// is associated with the best picker.
		/// This is an overloaded function.
		/// </summary>
		// Token: 0x0601545B RID: 87131 RVA: 0x001E1FF4 File Offset: 0x001E01F4
		public bool Pick(vtkObject arg0)
		{
			return vtkPickingManager.vtkPickingManager_Pick_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis()) != 0;
		}

		// Token: 0x0601545C RID: 87132
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPickingManager_Pick_18(HandleRef pThis, HandleRef picker);

		/// <summary>
		/// Run the picking selection process and return if \a picker is the one
		/// selected.
		/// This is an overloaded function.
		/// </summary>
		// Token: 0x0601545D RID: 87133 RVA: 0x001E2030 File Offset: 0x001E0230
		public bool Pick(vtkAbstractPicker picker)
		{
			return vtkPickingManager.vtkPickingManager_Pick_18(base.GetCppThis(), (picker == null) ? default(HandleRef) : picker.GetCppThis()) != 0;
		}

		// Token: 0x0601545E RID: 87134
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPickingManager_RemoveObject_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove all occurrence of the \a object from the registered list.
		/// If a picker associated with the \a object is not also associated with
		/// any other object, it is removed from the list as well.
		/// </summary>
		// Token: 0x0601545F RID: 87135 RVA: 0x001E206C File Offset: 0x001E026C
		public void RemoveObject(vtkObject arg0)
		{
			vtkPickingManager.vtkPickingManager_RemoveObject_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06015460 RID: 87136
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPickingManager_RemovePicker_20(HandleRef pThis, HandleRef picker, HandleRef arg1);

		/// <summary>
		/// Unregister the \a picker from the picking manager.
		/// If \a object is non null, only the pair (\a picker, \a object) is removed.
		/// </summary>
		// Token: 0x06015461 RID: 87137 RVA: 0x001E209C File Offset: 0x001E029C
		public void RemovePicker(vtkAbstractPicker picker, vtkObject arg1)
		{
			vtkPickingManager.vtkPickingManager_RemovePicker_20(base.GetCppThis(), (picker == null) ? default(HandleRef) : picker.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06015462 RID: 87138
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPickingManager_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015463 RID: 87139 RVA: 0x001E20E0 File Offset: 0x001E02E0
		public new static vtkPickingManager SafeDownCast(vtkObjectBase o)
		{
			vtkPickingManager vtkPickingManager = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPickingManager.vtkPickingManager_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPickingManager = (vtkPickingManager)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPickingManager.Register(null);
				}
			}
			return vtkPickingManager;
		}

		// Token: 0x06015464 RID: 87140
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPickingManager_SetEnabled_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable management.
		/// When disabled, it redirects every pick on the picker.
		/// By default the picking manager is disabled when initialized.
		/// </summary>
		// Token: 0x06015465 RID: 87141 RVA: 0x001E215F File Offset: 0x001E035F
		public virtual void SetEnabled(bool _arg)
		{
			vtkPickingManager.vtkPickingManager_SetEnabled_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06015466 RID: 87142
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPickingManager_SetInteractor_23(HandleRef pThis, HandleRef iren);

		/// <summary>
		/// Set the window interactor associated with the manager.
		/// </summary>
		// Token: 0x06015467 RID: 87143 RVA: 0x001E2178 File Offset: 0x001E0378
		public void SetInteractor(vtkRenderWindowInteractor iren)
		{
			vtkPickingManager.vtkPickingManager_SetInteractor_23(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis());
		}

		// Token: 0x06015468 RID: 87144
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPickingManager_SetOptimizeOnInteractorEvents_24(HandleRef pThis, byte optimize);

		/// <summary>
		/// Enable/Disable optimization depending on the renderWindowInteractor events.
		/// The mechanism keeps in cache the last selected picker as well as the last
		/// render time to recompute the selection only if a new render event
		/// occurred after the last selection; otherwise, it simply returns the last
		/// picker selected.
		/// By default pickingManagers does use the optimization.
		/// Warning: Turning off the caching significantly decreases performance.
		/// </summary>
		// Token: 0x06015469 RID: 87145 RVA: 0x001E21A7 File Offset: 0x001E03A7
		public void SetOptimizeOnInteractorEvents(bool optimize)
		{
			vtkPickingManager.vtkPickingManager_SetOptimizeOnInteractorEvents_24(base.GetCppThis(), optimize ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400186C RID: 6252
		public new const string MRFullTypeName = "Kitware.VTK.vtkPickingManager";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400186D RID: 6253
		public new static readonly string MRClassNameKey = "class vtkPickingManager";
	}
}
