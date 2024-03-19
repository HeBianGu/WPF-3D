using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointCloudWidget
	/// </summary>
	/// <remarks>
	///    select and manipulate a point from a point cloud
	///
	/// This 3D widget allows the user to query and select one point from a large
	/// collection of points (i.e., a point cloud). It is typically paired with a
	/// representation class such as vtkPointCloudRepresentation.
	///
	/// The widget emits several events during usage. When a point is successfully
	/// picked (via mousing over), it emits the vtkCommand::PickEvent. When a
	/// selection occurs, the vtkCommand::WidgetActivateEvent is invoked.
	///
	/// In usage this widget is typically paired with an additional widget to
	/// provide local point editing (e.g., move a point, modify associated
	/// attribute values); or uses callbacks (via the Observer mechanism) to
	/// perform additional operations on the selected point.
	///
	/// Typically the behavior of the widget is as follows. As the user mouses
	/// over the point cloud, picking continuously occurs. If a point is 1) picked
	/// (i.e., the cursor is within a tolerance) and 2) a different point is
	/// picked, then a widget pick event is invoked. The user, by observing the
	/// event, can display further information such as text strings
	/// etc. Additionally, the user can select the point (typically a left mouse
	/// button click) which invokes a widget select event.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointCloudRepresentation vtkPointWidget vtkTensorSizingWidget
	/// </seealso>
	// Token: 0x02000352 RID: 850
	public class vtkPointCloudWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009A6F RID: 39535 RVA: 0x000DAD71 File Offset: 0x000D8F71
		static vtkPointCloudWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointCloudWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointCloudWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009A70 RID: 39536 RVA: 0x000DAD99 File Offset: 0x000D8F99
		public vtkPointCloudWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009A71 RID: 39537
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06009A72 RID: 39538 RVA: 0x000DADA8 File Offset: 0x000D8FA8
		public new static vtkPointCloudWidget New()
		{
			vtkPointCloudWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointCloudWidget.vtkPointCloudWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointCloudWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06009A73 RID: 39539 RVA: 0x000DADFC File Offset: 0x000D8FFC
		public vtkPointCloudWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointCloudWidget.vtkPointCloudWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009A74 RID: 39540 RVA: 0x000DAE40 File Offset: 0x000D9040
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009A75 RID: 39541
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set. By default,
		/// this is an instance of the vtkPointCloudRepresentation class.
		/// </summary>
		// Token: 0x06009A76 RID: 39542 RVA: 0x000DAE4B File Offset: 0x000D904B
		public override void CreateDefaultRepresentation()
		{
			vtkPointCloudWidget.vtkPointCloudWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009A77 RID: 39543
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointCloudWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06009A78 RID: 39544 RVA: 0x000DAE5C File Offset: 0x000D905C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointCloudWidget.vtkPointCloudWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06009A79 RID: 39545
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointCloudWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06009A7A RID: 39546 RVA: 0x000DAE7C File Offset: 0x000D907C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointCloudWidget.vtkPointCloudWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06009A7B RID: 39547
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06009A7C RID: 39548 RVA: 0x000DAE98 File Offset: 0x000D9098
		public override int IsA(string type)
		{
			return vtkPointCloudWidget.vtkPointCloudWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06009A7D RID: 39549
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06009A7E RID: 39550 RVA: 0x000DAEB8 File Offset: 0x000D90B8
		public new static int IsTypeOf(string type)
		{
			return vtkPointCloudWidget.vtkPointCloudWidget_IsTypeOf_05(type);
		}

		// Token: 0x06009A7F RID: 39551
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06009A80 RID: 39552 RVA: 0x000DAED4 File Offset: 0x000D90D4
		public new vtkPointCloudWidget NewInstance()
		{
			vtkPointCloudWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointCloudWidget.vtkPointCloudWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointCloudWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009A81 RID: 39553
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06009A82 RID: 39554 RVA: 0x000DAF30 File Offset: 0x000D9130
		public new static vtkPointCloudWidget SafeDownCast(vtkObjectBase o)
		{
			vtkPointCloudWidget vtkPointCloudWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointCloudWidget.vtkPointCloudWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointCloudWidget = (vtkPointCloudWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointCloudWidget.Register(null);
				}
			}
			return vtkPointCloudWidget;
		}

		// Token: 0x06009A83 RID: 39555
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudWidget_SetEnabled_09(HandleRef pThis, int enabling);

		/// <summary>
		/// Override superclasses' SetEnabled() method because the line
		/// widget must enable its internal handle widgets.
		/// </summary>
		// Token: 0x06009A84 RID: 39556 RVA: 0x000DAFAF File Offset: 0x000D91AF
		public override void SetEnabled(int enabling)
		{
			vtkPointCloudWidget.vtkPointCloudWidget_SetEnabled_09(base.GetCppThis(), enabling);
		}

		// Token: 0x06009A85 RID: 39557
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudWidget_SetRepresentation_10(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06009A86 RID: 39558 RVA: 0x000DAFC0 File Offset: 0x000D91C0
		public void SetRepresentation(vtkPointCloudRepresentation r)
		{
			vtkPointCloudWidget.vtkPointCloudWidget_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C97 RID: 3223
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointCloudWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C98 RID: 3224
		public new static readonly string MRClassNameKey = "class vtkPointCloudWidget";
	}
}
