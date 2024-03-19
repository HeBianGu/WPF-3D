using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyLineWidget
	/// </summary>
	/// <remarks>
	///    widget for vtkPolyLineRepresentation.
	///
	/// vtkPolyLineWidget is the vtkAbstractWidget subclass for
	/// vtkPolyLineRepresentation which manages the interactions with
	/// vtkPolyLineRepresentation. This is based on vtkPolyLineWidget.
	///
	/// This widget allows the creation of a polyline interactively by adding or removing points
	/// based on mouse position and a modifier key.
	///
	/// - ctrl+click inserts a new point on the selected line
	/// - shift+click deletes the selected point
	/// - alt+click adds a new point anywhere depending on last selected point.
	///   If the first point is selected, the new point is added at the beginning,
	///   else it is added at the end.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyLineRepresentation, vtkPolyLineWidget
	/// </seealso>
	// Token: 0x0200035B RID: 859
	public class vtkPolyLineWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009C52 RID: 40018 RVA: 0x000DD7C7 File Offset: 0x000DB9C7
		static vtkPolyLineWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyLineWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyLineWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009C53 RID: 40019 RVA: 0x000DD7EF File Offset: 0x000DB9EF
		public vtkPolyLineWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009C54 RID: 40020
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLineWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C55 RID: 40021 RVA: 0x000DD800 File Offset: 0x000DBA00
		public new static vtkPolyLineWidget New()
		{
			vtkPolyLineWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLineWidget.vtkPolyLineWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyLineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C56 RID: 40022 RVA: 0x000DD854 File Offset: 0x000DBA54
		public vtkPolyLineWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyLineWidget.vtkPolyLineWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009C57 RID: 40023 RVA: 0x000DD898 File Offset: 0x000DBA98
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009C58 RID: 40024
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLineWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set. By default,
		/// this is an instance of the vtkPolyLineRepresentation class.
		/// </summary>
		// Token: 0x06009C59 RID: 40025 RVA: 0x000DD8A3 File Offset: 0x000DBAA3
		public override void CreateDefaultRepresentation()
		{
			vtkPolyLineWidget.vtkPolyLineWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009C5A RID: 40026
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyLineWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C5B RID: 40027 RVA: 0x000DD8B4 File Offset: 0x000DBAB4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyLineWidget.vtkPolyLineWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06009C5C RID: 40028
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyLineWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C5D RID: 40029 RVA: 0x000DD8D4 File Offset: 0x000DBAD4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyLineWidget.vtkPolyLineWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06009C5E RID: 40030
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLineWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C5F RID: 40031 RVA: 0x000DD8F0 File Offset: 0x000DBAF0
		public override int IsA(string type)
		{
			return vtkPolyLineWidget.vtkPolyLineWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06009C60 RID: 40032
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLineWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C61 RID: 40033 RVA: 0x000DD910 File Offset: 0x000DBB10
		public new static int IsTypeOf(string type)
		{
			return vtkPolyLineWidget.vtkPolyLineWidget_IsTypeOf_05(type);
		}

		// Token: 0x06009C62 RID: 40034
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLineWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C63 RID: 40035 RVA: 0x000DD92C File Offset: 0x000DBB2C
		public new vtkPolyLineWidget NewInstance()
		{
			vtkPolyLineWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLineWidget.vtkPolyLineWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyLineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009C64 RID: 40036
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLineWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C65 RID: 40037 RVA: 0x000DD988 File Offset: 0x000DBB88
		public new static vtkPolyLineWidget SafeDownCast(vtkObjectBase o)
		{
			vtkPolyLineWidget vtkPolyLineWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLineWidget.vtkPolyLineWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyLineWidget = (vtkPolyLineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyLineWidget.Register(null);
				}
			}
			return vtkPolyLineWidget;
		}

		// Token: 0x06009C66 RID: 40038
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLineWidget_SetEnabled_09(HandleRef pThis, int enabling);

		/// <summary>
		/// Override superclasses' SetEnabled() method because the line
		/// widget must enable its internal handle widgets.
		/// </summary>
		// Token: 0x06009C67 RID: 40039 RVA: 0x000DDA07 File Offset: 0x000DBC07
		public override void SetEnabled(int enabling)
		{
			vtkPolyLineWidget.vtkPolyLineWidget_SetEnabled_09(base.GetCppThis(), enabling);
		}

		// Token: 0x06009C68 RID: 40040
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLineWidget_SetRepresentation_10(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of
		/// vtkProp so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06009C69 RID: 40041 RVA: 0x000DDA18 File Offset: 0x000DBC18
		public void SetRepresentation(vtkPolyLineRepresentation r)
		{
			vtkPolyLineWidget.vtkPolyLineWidget_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CA9 RID: 3241
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyLineWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CAA RID: 3242
		public new static readonly string MRClassNameKey = "class vtkPolyLineWidget";
	}
}
