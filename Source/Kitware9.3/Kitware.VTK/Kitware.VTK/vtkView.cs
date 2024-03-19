using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkView
	/// </summary>
	/// <remarks>
	///    The superclass for all views.
	///
	///
	/// vtkView is the superclass for views.  A view is generally an area of an
	/// application's canvas devoted to displaying one or more VTK data objects.
	/// Associated representations (subclasses of vtkDataRepresentation) are
	/// responsible for converting the data into a displayable format.  These
	/// representations are then added to the view.
	///
	/// For views which display only one data object at a time you may set a
	/// data object or pipeline connection directly on the view itself (e.g.
	/// vtkGraphLayoutView, vtkLandscapeView, vtkTreeMapView).
	/// The view will internally create a vtkDataRepresentation for the data.
	///
	/// A view has the concept of linked selection.  If the same data is displayed
	/// in multiple views, their selections may be linked by setting the same
	/// vtkAnnotationLink on their representations (see vtkDataRepresentation).
	/// </remarks>
	// Token: 0x02000056 RID: 86
	public class vtkView : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000F98 RID: 3992 RVA: 0x0001C3C3 File Offset: 0x0001A5C3
		static vtkView()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkView"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000F99 RID: 3993 RVA: 0x0001C3EB File Offset: 0x0001A5EB
		public vtkView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000F9A RID: 3994
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000F9B RID: 3995 RVA: 0x0001C3FC File Offset: 0x0001A5FC
		public new static vtkView New()
		{
			vtkView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkView.vtkView_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000F9C RID: 3996 RVA: 0x0001C450 File Offset: 0x0001A650
		public vtkView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkView.vtkView_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000F9D RID: 3997 RVA: 0x0001C494 File Offset: 0x0001A694
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000F9E RID: 3998
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkView_AddRepresentation_01(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Adds the representation to the view.
		/// </summary>
		// Token: 0x06000F9F RID: 3999 RVA: 0x0001C4A0 File Offset: 0x0001A6A0
		public void AddRepresentation(vtkDataRepresentation rep)
		{
			vtkView.vtkView_AddRepresentation_01(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		// Token: 0x06000FA0 RID: 4000
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkView_AddRepresentationFromInput_02(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method which creates a simple representation with the
		/// specified input and adds it to the view.
		/// NOTE: The returned representation pointer is not reference-counted,
		/// so you MUST call Register() on the representation if you want to
		/// keep a reference to it.
		/// </summary>
		// Token: 0x06000FA1 RID: 4001 RVA: 0x0001C4D0 File Offset: 0x0001A6D0
		public vtkDataRepresentation AddRepresentationFromInput(vtkDataObject input)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkView.vtkView_AddRepresentationFromInput_02(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		// Token: 0x06000FA2 RID: 4002
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkView_AddRepresentationFromInputConnection_03(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method which creates a simple representation with the
		/// connection and adds it to the view.
		/// Returns the representation internally created.
		/// NOTE: The returned representation pointer is not reference-counted,
		/// so you MUST call Register() on the representation if you want to
		/// keep a reference to it.
		/// </summary>
		// Token: 0x06000FA3 RID: 4003 RVA: 0x0001C558 File Offset: 0x0001A758
		public vtkDataRepresentation AddRepresentationFromInputConnection(vtkAlgorithmOutput conn)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkView.vtkView_AddRepresentationFromInputConnection_03(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		// Token: 0x06000FA4 RID: 4004
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkView_ApplyViewTheme_04(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Apply a theme to the view.
		/// </summary>
		// Token: 0x06000FA5 RID: 4005 RVA: 0x0001C5E0 File Offset: 0x0001A7E0
		public virtual void ApplyViewTheme(vtkViewTheme arg0)
		{
			vtkView.vtkView_ApplyViewTheme_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000FA6 RID: 4006
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkView_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FA7 RID: 4007 RVA: 0x0001C610 File Offset: 0x0001A810
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkView.vtkView_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06000FA8 RID: 4008
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkView_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FA9 RID: 4009 RVA: 0x0001C630 File Offset: 0x0001A830
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkView.vtkView_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06000FAA RID: 4010
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkView_GetNumberOfRepresentations_07(HandleRef pThis);

		/// <summary>
		/// Returns the number of representations from first port(0) in this view.
		/// </summary>
		// Token: 0x06000FAB RID: 4011 RVA: 0x0001C64C File Offset: 0x0001A84C
		public int GetNumberOfRepresentations()
		{
			return vtkView.vtkView_GetNumberOfRepresentations_07(base.GetCppThis());
		}

		// Token: 0x06000FAC RID: 4012
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkView_GetObserver_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the observer that the subclasses can use to listen to additional
		/// events. Additionally these subclasses should override
		/// ProcessEvents() to handle these events.
		/// </summary>
		// Token: 0x06000FAD RID: 4013 RVA: 0x0001C66C File Offset: 0x0001A86C
		public vtkCommand GetObserver()
		{
			vtkCommand vtkCommand = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkView.vtkView_GetObserver_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommand = (vtkCommand)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommand.Register(null);
				}
			}
			return vtkCommand;
		}

		// Token: 0x06000FAE RID: 4014
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkView_GetRepresentation_09(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The representation at a specified index.
		/// </summary>
		// Token: 0x06000FAF RID: 4015 RVA: 0x0001C6DC File Offset: 0x0001A8DC
		public vtkDataRepresentation GetRepresentation(int index)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkView.vtkView_GetRepresentation_09(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		// Token: 0x06000FB0 RID: 4016
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkView_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FB1 RID: 4017 RVA: 0x0001C74C File Offset: 0x0001A94C
		public override int IsA(string type)
		{
			return vtkView.vtkView_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06000FB2 RID: 4018
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkView_IsRepresentationPresent_11(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Check to see if a representation is present in the view.
		/// </summary>
		// Token: 0x06000FB3 RID: 4019 RVA: 0x0001C76C File Offset: 0x0001A96C
		public bool IsRepresentationPresent(vtkDataRepresentation rep)
		{
			return vtkView.vtkView_IsRepresentationPresent_11(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis()) != 0;
		}

		// Token: 0x06000FB4 RID: 4020
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkView_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FB5 RID: 4021 RVA: 0x0001C7A8 File Offset: 0x0001A9A8
		public new static int IsTypeOf(string type)
		{
			return vtkView.vtkView_IsTypeOf_12(type);
		}

		// Token: 0x06000FB6 RID: 4022
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkView_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FB7 RID: 4023 RVA: 0x0001C7C4 File Offset: 0x0001A9C4
		public new vtkView NewInstance()
		{
			vtkView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkView.vtkView_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000FB8 RID: 4024
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkView_RegisterProgress_15(HandleRef pThis, HandleRef algorithm, [MarshalAs(UnmanagedType.LPUTF8Str)] string message);

		/// <summary>
		/// Meant for use by subclasses and vtkRepresentation subclasses.
		/// Call this method to register vtkObjects (generally
		/// vtkAlgorithm subclasses) which fire vtkCommand::ProgressEvent with the
		/// view. The view listens to vtkCommand::ProgressEvent and fires
		/// ViewProgressEvent with ViewProgressEventCallData containing the message and
		/// the progress amount. If message is not provided, then the class name for
		/// the algorithm is used.
		/// </summary>
		// Token: 0x06000FB9 RID: 4025 RVA: 0x0001C820 File Offset: 0x0001AA20
		public void RegisterProgress(vtkObject algorithm, string message)
		{
			vtkView.vtkView_RegisterProgress_15(base.GetCppThis(), (algorithm == null) ? default(HandleRef) : algorithm.GetCppThis(), message);
		}

		// Token: 0x06000FBA RID: 4026
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkView_RemoveAllRepresentations_16(HandleRef pThis);

		/// <summary>
		/// Removes all representations from the view.
		/// </summary>
		// Token: 0x06000FBB RID: 4027 RVA: 0x0001C850 File Offset: 0x0001AA50
		public void RemoveAllRepresentations()
		{
			vtkView.vtkView_RemoveAllRepresentations_16(base.GetCppThis());
		}

		// Token: 0x06000FBC RID: 4028
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkView_RemoveRepresentation_17(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Removes the representation from the view.
		/// </summary>
		// Token: 0x06000FBD RID: 4029 RVA: 0x0001C860 File Offset: 0x0001AA60
		public void RemoveRepresentation(vtkDataRepresentation rep)
		{
			vtkView.vtkView_RemoveRepresentation_17(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		// Token: 0x06000FBE RID: 4030
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkView_RemoveRepresentation_18(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Removes any representation with this connection from the view.
		/// </summary>
		// Token: 0x06000FBF RID: 4031 RVA: 0x0001C890 File Offset: 0x0001AA90
		public void RemoveRepresentation(vtkAlgorithmOutput rep)
		{
			vtkView.vtkView_RemoveRepresentation_18(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		// Token: 0x06000FC0 RID: 4032
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkView_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FC1 RID: 4033 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		public new static vtkView SafeDownCast(vtkObjectBase o)
		{
			vtkView vtkView = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkView.vtkView_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkView = (vtkView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkView.Register(null);
				}
			}
			return vtkView;
		}

		// Token: 0x06000FC2 RID: 4034
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkView_SetRepresentation_20(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Set the representation to the view.
		/// </summary>
		// Token: 0x06000FC3 RID: 4035 RVA: 0x0001C940 File Offset: 0x0001AB40
		public void SetRepresentation(vtkDataRepresentation rep)
		{
			vtkView.vtkView_SetRepresentation_20(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		// Token: 0x06000FC4 RID: 4036
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkView_SetRepresentationFromInput_21(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method which sets the representation to the
		/// specified input and adds it to the view.
		/// NOTE: The returned representation pointer is not reference-counted,
		/// so you MUST call Register() on the representation if you want to
		/// keep a reference to it.
		/// </summary>
		// Token: 0x06000FC5 RID: 4037 RVA: 0x0001C970 File Offset: 0x0001AB70
		public vtkDataRepresentation SetRepresentationFromInput(vtkDataObject input)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkView.vtkView_SetRepresentationFromInput_21(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		// Token: 0x06000FC6 RID: 4038
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkView_SetRepresentationFromInputConnection_22(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method which sets the representation with the
		/// connection and adds it to the view.
		/// Returns the representation internally created.
		/// NOTE: The returned representation pointer is not reference-counted,
		/// so you MUST call Register() on the representation if you want to
		/// keep a reference to it.
		/// </summary>
		// Token: 0x06000FC7 RID: 4039 RVA: 0x0001C9F8 File Offset: 0x0001ABF8
		public vtkDataRepresentation SetRepresentationFromInputConnection(vtkAlgorithmOutput conn)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkView.vtkView_SetRepresentationFromInputConnection_22(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		// Token: 0x06000FC8 RID: 4040
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkView_UnRegisterProgress_23(HandleRef pThis, HandleRef algorithm);

		/// <summary>
		/// Unregister objects previously registered with RegisterProgress.
		/// </summary>
		// Token: 0x06000FC9 RID: 4041 RVA: 0x0001CA80 File Offset: 0x0001AC80
		public void UnRegisterProgress(vtkObject algorithm)
		{
			vtkView.vtkView_UnRegisterProgress_23(base.GetCppThis(), (algorithm == null) ? default(HandleRef) : algorithm.GetCppThis());
		}

		// Token: 0x06000FCA RID: 4042
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkView_Update_24(HandleRef pThis);

		/// <summary>
		/// Update the view.
		/// </summary>
		// Token: 0x06000FCB RID: 4043 RVA: 0x0001CAAF File Offset: 0x0001ACAF
		public virtual void Update()
		{
			vtkView.vtkView_Update_24(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400042E RID: 1070
		public new const string MRFullTypeName = "Kitware.VTK.vtkView";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400042F RID: 1071
		public new static readonly string MRClassNameKey = "class vtkView";
	}
}
