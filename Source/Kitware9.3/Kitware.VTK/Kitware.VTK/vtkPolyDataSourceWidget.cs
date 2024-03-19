using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataSourceWidget
	/// </summary>
	/// <remarks>
	///    abstract PolyDataSource-based 3D widget
	///
	/// This abstract class serves as parent to 3D widgets that have simple
	/// vtkPolyDataSource instances defining their geometry.
	///
	/// In addition to what is offered by the vtk3DWidget parent, this class
	/// makes it possible to manipulate the underlying polydatasource and to
	/// PlaceWidget() according to that, instead of having to make use of
	/// SetInput() or SetProp3D().
	///
	/// Implementors of child classes HAVE to implement their PlaceWidget(bounds)
	/// to check for the existence of Input and Prop3D FIRST.  If these don't
	/// exist, place according to the underlying PolyDataSource.  Child classes
	/// also have to imprement UpdatePlacement(), which updates the widget according
	/// to the geometry of the underlying PolyDataSource.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkLineWidget vtkPlaneWidget vtkSphereWidget
	/// </seealso>
	// Token: 0x02000325 RID: 805
	public abstract class vtkPolyDataSourceWidget : vtk3DWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008FF0 RID: 36848 RVA: 0x000CD04C File Offset: 0x000CB24C
		static vtkPolyDataSourceWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataSourceWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataSourceWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008FF1 RID: 36849 RVA: 0x000CD074 File Offset: 0x000CB274
		public vtkPolyDataSourceWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008FF2 RID: 36850 RVA: 0x000CD082 File Offset: 0x000CB282
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008FF3 RID: 36851
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataSourceWidget_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FF4 RID: 36852 RVA: 0x000CD090 File Offset: 0x000CB290
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06008FF5 RID: 36853
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataSourceWidget_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FF6 RID: 36854 RVA: 0x000CD0B0 File Offset: 0x000CB2B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06008FF7 RID: 36855
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataSourceWidget_GetPolyDataAlgorithm_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns underlying vtkPolyDataAlgorithm that determines geometry.  This
		/// can be modified after which PlaceWidget() or UpdatePlacement() can be
		/// called.  UpdatePlacement() will always update the planewidget according
		/// to the geometry of the underlying PolyDataAlgorithm.  PlaceWidget() will
		/// only make use of this geometry if there is no Input and no Prop3D set.
		/// </summary>
		// Token: 0x06008FF8 RID: 36856 RVA: 0x000CD0CC File Offset: 0x000CB2CC
		public virtual vtkPolyDataAlgorithm GetPolyDataAlgorithm()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_GetPolyDataAlgorithm_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		// Token: 0x06008FF9 RID: 36857
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataSourceWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FFA RID: 36858 RVA: 0x000CD13C File Offset: 0x000CB33C
		public override int IsA(string type)
		{
			return vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06008FFB RID: 36859
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataSourceWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FFC RID: 36860 RVA: 0x000CD15C File Offset: 0x000CB35C
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_IsTypeOf_05(type);
		}

		// Token: 0x06008FFD RID: 36861
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataSourceWidget_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FFE RID: 36862 RVA: 0x000CD178 File Offset: 0x000CB378
		public new vtkPolyDataSourceWidget NewInstance()
		{
			vtkPolyDataSourceWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataSourceWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008FFF RID: 36863
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSourceWidget_PlaceWidget_07(HandleRef pThis);

		/// <summary>
		/// Overrides vtk3DWidget PlaceWidget() so that it doesn't complain if
		/// there's no Input and no Prop3D.
		/// </summary>
		// Token: 0x06009000 RID: 36864 RVA: 0x000CD1D2 File Offset: 0x000CB3D2
		public override void PlaceWidget()
		{
			vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_PlaceWidget_07(base.GetCppThis());
		}

		// Token: 0x06009001 RID: 36865
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSourceWidget_PlaceWidget_08(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// We have to redeclare this abstract, PlaceWidget() requires it.  You HAVE
		/// to override this in your concrete child classes.  If there's no Prop3D
		/// and no Input, your PlaceWidget must make use of the underlying
		/// PolyDataSource to do its work.
		/// </summary>
		// Token: 0x06009002 RID: 36866 RVA: 0x000CD1E1 File Offset: 0x000CB3E1
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_PlaceWidget_08(base.GetCppThis(), bounds);
		}

		// Token: 0x06009003 RID: 36867
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSourceWidget_PlaceWidget_09(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Convenience method brought over from vtkPlaneWidget.
		/// </summary>
		// Token: 0x06009004 RID: 36868 RVA: 0x000CD1F1 File Offset: 0x000CB3F1
		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_PlaceWidget_09(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x06009005 RID: 36869
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataSourceWidget_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009006 RID: 36870 RVA: 0x000CD20C File Offset: 0x000CB40C
		public new static vtkPolyDataSourceWidget SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataSourceWidget vtkPolyDataSourceWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataSourceWidget = (vtkPolyDataSourceWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataSourceWidget.Register(null);
				}
			}
			return vtkPolyDataSourceWidget;
		}

		// Token: 0x06009007 RID: 36871
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSourceWidget_UpdatePlacement_11(HandleRef pThis);

		/// <summary>
		/// If you've made changes to the underlying vtkPolyDataSource AFTER your
		/// initial call to PlaceWidget(), use this method to realise the changes
		/// in the widget.
		/// </summary>
		// Token: 0x06009008 RID: 36872 RVA: 0x000CD28B File Offset: 0x000CB48B
		public virtual void UpdatePlacement()
		{
			vtkPolyDataSourceWidget.vtkPolyDataSourceWidget_UpdatePlacement_11(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C08 RID: 3080
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataSourceWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C09 RID: 3081
		public new static readonly string MRClassNameKey = "class vtkPolyDataSourceWidget";
	}
}
