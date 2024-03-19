using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSplineWidget2
	/// </summary>
	/// <remarks>
	///    widget for vtkSplineRepresentation.
	///
	/// vtkSplineWidget2 is the vtkAbstractWidget subclass for
	/// vtkSplineRepresentation which manages the interactions with
	/// vtkSplineRepresentation. This is based on vtkSplineWidget.
	/// </remarks>
	/// <seealso>
	///
	/// vtkSplineRepresentation, vtkSplineWidget2
	/// </seealso>
	// Token: 0x0200037F RID: 895
	public class vtkSplineWidget2 : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A329 RID: 41769 RVA: 0x000E73DF File Offset: 0x000E55DF
		static vtkSplineWidget2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplineWidget2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineWidget2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A32A RID: 41770 RVA: 0x000E7407 File Offset: 0x000E5607
		public vtkSplineWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A32B RID: 41771
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A32C RID: 41772 RVA: 0x000E7418 File Offset: 0x000E5618
		public new static vtkSplineWidget2 New()
		{
			vtkSplineWidget2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineWidget2.vtkSplineWidget2_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A32D RID: 41773 RVA: 0x000E746C File Offset: 0x000E566C
		public vtkSplineWidget2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSplineWidget2.vtkSplineWidget2_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A32E RID: 41774 RVA: 0x000E74B0 File Offset: 0x000E56B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A32F RID: 41775
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set. By default,
		/// this is an instance of the vtkSplineRepresentation class.
		/// </summary>
		// Token: 0x0600A330 RID: 41776 RVA: 0x000E74BB File Offset: 0x000E56BB
		public override void CreateDefaultRepresentation()
		{
			vtkSplineWidget2.vtkSplineWidget2_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A331 RID: 41777
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplineWidget2_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A332 RID: 41778 RVA: 0x000E74CC File Offset: 0x000E56CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSplineWidget2.vtkSplineWidget2_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A333 RID: 41779
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplineWidget2_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A334 RID: 41780 RVA: 0x000E74EC File Offset: 0x000E56EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSplineWidget2.vtkSplineWidget2_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A335 RID: 41781
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget2_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A336 RID: 41782 RVA: 0x000E7508 File Offset: 0x000E5708
		public override int IsA(string type)
		{
			return vtkSplineWidget2.vtkSplineWidget2_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600A337 RID: 41783
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget2_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A338 RID: 41784 RVA: 0x000E7528 File Offset: 0x000E5728
		public new static int IsTypeOf(string type)
		{
			return vtkSplineWidget2.vtkSplineWidget2_IsTypeOf_05(type);
		}

		// Token: 0x0600A339 RID: 41785
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineWidget2_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A33A RID: 41786 RVA: 0x000E7544 File Offset: 0x000E5744
		public new vtkSplineWidget2 NewInstance()
		{
			vtkSplineWidget2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineWidget2.vtkSplineWidget2_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A33B RID: 41787
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineWidget2_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A33C RID: 41788 RVA: 0x000E75A0 File Offset: 0x000E57A0
		public new static vtkSplineWidget2 SafeDownCast(vtkObjectBase o)
		{
			vtkSplineWidget2 vtkSplineWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineWidget2.vtkSplineWidget2_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplineWidget = (vtkSplineWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplineWidget.Register(null);
				}
			}
			return vtkSplineWidget;
		}

		// Token: 0x0600A33D RID: 41789
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget2_SetEnabled_09(HandleRef pThis, int enabling);

		/// <summary>
		/// Override superclasses' SetEnabled() method because the line
		/// widget must enable its internal handle widgets.
		/// </summary>
		// Token: 0x0600A33E RID: 41790 RVA: 0x000E761F File Offset: 0x000E581F
		public override void SetEnabled(int enabling)
		{
			vtkSplineWidget2.vtkSplineWidget2_SetEnabled_09(base.GetCppThis(), enabling);
		}

		// Token: 0x0600A33F RID: 41791
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget2_SetRepresentation_10(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of
		/// vtkProp so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600A340 RID: 41792 RVA: 0x000E7630 File Offset: 0x000E5830
		public void SetRepresentation(vtkSplineRepresentation r)
		{
			vtkSplineWidget2.vtkSplineWidget2_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D0C RID: 3340
		public new const string MRFullTypeName = "Kitware.VTK.vtkSplineWidget2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D0D RID: 3341
		public new static readonly string MRClassNameKey = "class vtkSplineWidget2";
	}
}
